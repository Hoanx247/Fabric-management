Option Explicit Off
Option Strict Off

Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text

Public Class List_colName
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private dt_local As DataTable
    Private dt_nhom As DataTable
    '--
    Dim dr2 As DataRow()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"frmnamefull", "formgroup", "stt"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Dim _Column_Forzen_pos As Integer = 0
    Dim _saveRowIndex As Integer = 0
    Private _update_ok As Boolean = False

    Dim _Macay_Selected As String = String.Empty
    Dim _bln_Saved As Boolean = False
    '--
    Dim _intRows_ALL As Integer = 0
    Dim _intColumns_ALL As Integer = 0, _intGroup_count As Integer = 0

    Private _IsBusy As Boolean = False


#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object, _
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing


        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        dt_nhom = New DataTable

        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        '--
        With dt1_F
            .Value = Now
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        With dt2_F
            .Value = Now
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With

        Me.dt1_F.Value = DateSerial(Now.Year, Now.Month, Now.Day - 10)
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, Now.Day)
        '--
        With Super_Dgv
            .DefaultVisualStyles.FooterStyles.Default.Font = New Font("Time New Roman", 10, FontStyle.Bold)
            .DefaultVisualStyles.FooterStyles.Default.Alignment = Alignment.MiddleLeft
            .PrimaryGrid.AllowEdit = True
            .PrimaryGrid.ReadOnly = False
        End With
        '----------
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        'AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler tpress.Tick, AddressOf MyTickHandler
    End Sub


    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call Filterdata_Stored()
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
                    dgvr.CellStyles.Default.Background.Color1 = Color.GreenYellow
                Else
                    dgvr.Checked = False
                    dgvr.CellStyles.Default.Background.Color1 = Color.White
                End If
            ElseIf e.GridCell.ColumnIndex = 3 Or e.GridCell.ColumnIndex = 4 Then
                panel.ReadOnly = False
                panel.AllowEdit = True
            Else
                panel.ReadOnly = True
                panel.AllowEdit = False
            End If
            _saveRowIndex = e.GridCell.RowIndex
        End If

    End Sub
#End Region

#Region " THONG TIN CHUNG"

    Private Sub CircleProcess_Start()
        With CircularProgress1
            .Location = New Point(CInt((Super_Dgv.Width - .Width) / 2), CInt((Super_Dgv.Height - .Height) / 2))
            .IsRunning = True
            .Visible = True
        End With
    End Sub

    Private Sub CircleProcess_Stop()
        wait(300)
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub

    Private Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        'Try
        Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlList_ColName_UpSet]", sbXMLString.ToString, "select")
        Super_Dgv.SuspendLayout()
        Super_Dgv.BeginUpdate()
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Super_Dgv.EndUpdate()
        Super_Dgv.ResumeLayout()
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
        'End Try
    End Sub
#Region "SUM"
    Private IsLoad_Finished As Boolean = False
    Private _array_column As String() = {"socay_1"}
    Private _array_value As Decimal() = {0, 0, 0, 0}
    Private tpress As New Timer With {.Interval = 200}
    Private _blnPress As Boolean = False

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

        Call UpdateShowALLRows(panel.Rows)

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
                        If ExistsColumnGridPanel(panel, "chon_mau") = True Then
                            If CBool(row.Cells("chon_mau").Value) = True Then
                                row.CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
                                row.RowStyles.Default.RowHeaderStyle.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
                            End If
                        End If

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

        'panel.AddGroup(panel.Columns(_colnhomhc))
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns(_colmasonhanvien)}
        If panel.SortColumns.Count = 1 Then
            panel.SetSort(sortCols, clsDev.GetSortDir_Asc(sortCols))
        ElseIf panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirAscAsc(sortCols))
        End If
        '//

        tpress.Enabled = True
    End Sub


#End Region

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click

    End Sub

    Private Sub btTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    End Sub


End Class