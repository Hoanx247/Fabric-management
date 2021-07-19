Option Strict Off
Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text

Public Class frmNhapMoc_chiTiet_View
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim st As String = String.Empty
    Dim _Chungtunhap_id As String = String.Empty
    Private _List_Column_Locked As String() = {"ghichu", "xuly1", "xuly2"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Dim _load_finish As Boolean = False
    Private IsBusy As Boolean = False
    Public Property Chungtunhap_id() As String
        Get
            Return _Chungtunhap_id
        End Get
        Set(ByVal value As String)
            _Chungtunhap_id = value
        End Set
    End Property


#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Me.DialogResult = DialogResult.OK
        '//
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()

    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        '//
        'With dtNgayXuat_SX
        '.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        '.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        'End With

        'Me.dtNgayXuat_SX.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))
        '//
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '///
        With Super_Dgv
            .PrimaryGrid.KeepRowsSorted = False
        End With
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged

        AddHandler tpress.Tick, AddressOf MyTickHandler
        '----------
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            Call Filterdata_Stored()
            _load_finish = True
            '----------------
        Else
            Me.Close()
        End If
    End Sub



#End Region

#Region "SUPERGRID"
    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        If _load_finish = True Then
            clsDev.SuperDgv_CellValueChanged(sender, e)
        End If

    End Sub
    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Super_Dgv.KeyDown
        clsDev.Super_Dgv_KeyDown(sender, e)
    End Sub
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = CByte(e.GridColumn.ColumnIndex)
            If e.GridColumn.ColumnIndex = 0 Then
                'ShowContextMenu(CtxMnuSelect)
            Else
                'ShowContextMenu(CtxMenu)
            End If
        Else

        End If
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            'ShowContextMenu(CtxFunction)
        Else
            If e.GridCell.ColumnIndex = 0 Then
                panel.ReadOnly = False
                panel.AllowEdit = True
                If dgvr.Checked = False Then
                    dgvr.Checked = True
                    dgvr.Cells(0).CellStyles.Default.Background.Color1 = Color.GreenYellow
                Else
                    dgvr.Checked = False
                    dgvr.Cells(0).CellStyles.Default.Background.Color1 = Color.Empty
                End If
            ElseIf e.GridCell.ColumnIndex > 0 AndAlso e.GridCell.ColumnIndex <= e.GridPanel.Columns.Count - 1 Then
                Dim result As String = Array.Find(_List_Column_Locked, Function(s) s = e.GridCell.GridColumn.Name.ToLower)
                If result IsNot Nothing Then
                    panel.AllowEdit = True
                    panel.ReadOnly = False
                Else
                    panel.AllowEdit = False
                    panel.ReadOnly = True
                End If
                '//
                '//
                If dgvr IsNot Nothing Then


                Else

                End If

            ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
                panel.AllowEdit = False
                panel.ReadOnly = True
            End If

        End If
        _saveRowIndex = e.GridCell.RowIndex
        '_columnName = panel.ActiveCell.GridColumn.Name

    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub

    Private Sub Expand_SuperGrid()
        Super_Dgv.PrimaryGrid.ExpandAll()
    End Sub

    Private Sub Collapse_SuperGrid()
        Super_Dgv.PrimaryGrid.CollapseAll()
    End Sub

    Private Sub mnu_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles mnu_Select_All.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, True)
    End Sub

    Private Sub mnu_Remove_ALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles mnu_Remove_ALL.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, False)
    End Sub

    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btnSave_ColumnFrozen.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        panel.FrozenColumnCount = _Column_Forzen_pos
    End Sub
#End Region

#Region "LOAD DATA"
    Public Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("chungtu_id='" + ReplaceTextXML(_Chungtunhap_id) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoMoc_NhapKho_GetData_ChiTiet_2021]", sbXMLString.ToString, "select_chungtu")
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        dtControler.SELECT_XML(_dt, panel)
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socay", "sokgmoc", "sometmoc"}
    Dim _array_value As Decimal() = {0, 0, 0, 0}
    Private tpress As New Timer With {.Interval = 200}
    Dim _blnPress As Boolean = False

    Private Sub Super_Dgv_FilterEditValueChanged(sender As Object, e As GridFilterEditValueChangedEventArgs) Handles Super_Dgv.FilterEditValueChanged
        Super_Dgv.SuspendLayout()
        _blnPress = False
        tpress.Enabled = False
        tpress.Enabled = True
        Super_Dgv.ResumeLayout()
    End Sub


    Sub MyTickHandler(ByVal sender As Object, ByVal e As EventArgs)
        '//
        tpress.Enabled = False
        _blnPress = True
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        ReDim Preserve _array_value(_array_column.Length)
        Array.Clear(_array_value, 0, _array_value.Length)
        'IsChanged = True '//Khong đánh dấu khi load data
        Call UpdateShowALLRows(panel.Rows)
        'IsChanged = False
        'lblRow.Text = "Tổng số: " & n
        Dim st As String = "<div align=""center"">" & "<font color=""red"">{0}</font><br/>" & "<font color=""green"">{1}</font>" & "</div>"
        For x As Integer = 0 To _array_column.Length - 1
            If columns.Contains(_array_column(x)) = True Then
                With panel.Columns(_array_column(x))
                    .EnableHeaderMarkup = True
                    Dim stHeaderText As String = clsDev.Show_1Column(_array_column(x))
                    Dim stValue As Decimal = _array_value(x)
                    .HeaderText = String.Format(st, stHeaderText, FormatNumber(stValue, _intFormatText))
                End With
            End If
        Next
    End Sub

    Private Sub UpdateShowALLRows(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        Dim _chon_mau As String = String.Empty
        '////
        Dim _isSame As Int16 = 0
        Dim _colorhtml As String = String.Empty
        '////
        For Each item As GridElement In rows
            If _blnPress = False Then Exit For
            If item.Visible = True Then

                Dim group As GridGroup = TryCast(item, GridGroup)
                If group IsNot Nothing Then
                    UpdateShowALLRows(group.Rows)
                Else
                    Dim row As GridRow = TryCast(item, GridRow)
                    If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then

                        For x As Integer = 0 To _array_column.Length - 1
                            If _blnPress = False Then Exit For
                            If ExistsColumnGridPanel(panel, _array_column(x)) = True Then
                                _sValue = _array_value(x)
                                _sValue += row.Cells(_array_column(x)).Value
                                _array_value.SetValue(_sValue, x)
                            End If
                        Next
                    End If
                End If

            End If
        Next

    End Sub

#End Region

    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '--
        Dim _stCol As String
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '//
        _stName = "Theo_DauKy"
        _stHeadText = "Số Lượng"
        _stCol1 = "socay"
        _stCol2 = "sometmoc"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If

        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mahang"), panel.Columns("mame"), panel.Columns("macay")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        End If
        '//
        tpress.Enabled = True

    End Sub
    Public Function GetSortDirAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Ascending, SortDirection)})
    End Function


#End Region

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub
    Private Sub btTim_Click(sender As Object, e As EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub

End Class