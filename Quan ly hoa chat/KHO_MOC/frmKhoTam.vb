Imports System
Imports System.Collections.Generic

Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Reflection
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Imports System.Net
Imports System.Text
Public Class frmKhoTam
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim dt_kieunhap As DataTable

    Dim _List_MameID As String() = {}
    Dim strList As List(Of String) = _List_MameID.ToList()
    '--
    Dim _List_CongDoanID As String() = {}
    Dim strCongDoanID As List(Of String) = _List_CongDoanID.ToList()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"ghichu_thuchien_1"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    '--
    Dim _kieunhap_id As String
    Dim _stMakytu_Nhap As String
    Dim dr2 As DataRow()
    Dim _filter As Boolean = False
    Private _lbtn_command As SByte = 0

    Dim _intRows_ALL As Long = 0
    Dim _intColumns_ALL As Long = 0, _intGroup_count As Long = 0
    Dim _IntGroup_Column_Index As Byte = 0

    Dim _update_ok As Boolean = False, _Edit_Chungtu As Boolean = False
    Dim _bln_khachhang As Boolean = False, _bln_mahang As Boolean = False
    Dim _blnEdit As Boolean = False
    Private _mahang_id As String = String.Empty
    Private _donhang_id As String = String.Empty
    Private _chungtunhap_id As String = String.Empty
    Private _bln_donhang As Boolean = False
    '//
    Private DgvData As DataGridView = New DataGridView()

#Region " Load du liệu lên bảng khi mở Form"

#Region "Private data"

    Private _BackColor As Background() = {New Background(Color.LightGreen),
        New Background(Color.FromArgb(&HE5, &HFF, &HDD)), New Background(Color.AliceBlue)}

    Private _MyFont As New Font("Time New Roman", 10, FontStyle.Bold Or FontStyle.Italic)
#End Region

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        '-------------------
        Dgv_Chungtu.Dispose()
        Super_Dgv.Dispose()
        dt_local.Dispose()
        Super_Dgv.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SuspendLayout()
        '--
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_local = New DataTable
        '--
        dt_kieunhap = New DataTable
        _kieunhap_id = ""

        With dt1_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        With dt2_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        Me.dt1_F.Value = CDate(FormatDateTime(DateSerial(Now.Year, Now.Month, Now.Day - 10), DateFormat.ShortDate))
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        '--
        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick

        '--
        AddHandler btnAdd.Click, AddressOf ThemMoi
        'AddHandler CtxFunction_Add.Click, AddressOf ThemMoi
        'AddHandler btnCopy.Click, AddressOf SaoChep
        'AddHandler CtxFunction_Copy.Click, AddressOf SaoChep
        AddHandler btnModify.Click, AddressOf ChinhSua
        'AddHandler CtxFunction_Modify.Click, AddressOf ChinhSua
        'AddHandler btnDelete.Click, AddressOf Xoa
        AddHandler CtxMenu_Expand.Click, AddressOf Expand_SuperGrid
        AddHandler CtxMenu_Colapse.Click, AddressOf Collapse_SuperGrid
        '//
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler

        Me.ResumeLayout()
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            'btnAdd.Enabled = IIf(_btAdd = True, True, False)
            'btnModify.Enabled = IIf(_btModify = True, True, False)
            'btnDelete.Enabled = IIf(_btDelete = True, True, False)
            '----------

            Call Filterdata_Stored()

            _filter = True
            '----------------
            _blnEdit = False
        Else
            Me.Close()
        End If
    End Sub

#End Region


#Region "SUPERGRID"

    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        clsDev.SuperDgv_CellValueChanged(sender, e)
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
                ShowContextMenu(CtxMenu)
            End If

        End If
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        Else
            If e.GridCell.ColumnIndex = 0 Then
                panel.ReadOnly = False
                panel.AllowEdit = True
                If dgvr.Checked = False Then
                    dgvr.Checked = True
                    dgvr.Cells(0).CellStyles.Default.Background.Color1 = Color.GreenYellow
                Else
                    dgvr.Checked = False
                    dgvr.Cells(0).CellStyles.Default.Background.Color1 = Color.GreenYellow
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

            ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
                panel.AllowEdit = False
                panel.ReadOnly = True
            End If

        End If
        '_saveRowIndex = e.GridCell.RowIndex

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

    Private Sub mnu_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, True)
    End Sub

    Private Sub mnu_Remove_ALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, False)
    End Sub

    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
#End Region

#Region "LOAD DATA"
    Private Sub CircleProcess_Start()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        'panel.ClearAll()
        panel.DataSource = Nothing
        CircularProgress1.Location = New Point(CInt(Super_Dgv.Width / 3), CInt(Super_Dgv.Height / 3.5))
        CircularProgress1.IsRunning = True
        CircularProgress1.Visible = True
    End Sub

    Private Sub CircleProcess_Stop()
        wait(200)
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
        sbXMLString.Append("dtngay1='" + Format$(dt1_F.Value, "yyyyMMdd 00:00") + "' ")
        sbXMLString.Append("dtngay2='" + Format$(dt2_F.Value, "yyyyMMdd 23:59") + "' ")
        sbXMLString.Append("chungtu='" + ReplaceTextXML(txtchungtu_F.Text) + "' ")
        sbXMLString.Append("khachhang='" + ReplaceTextXML(txtkhachHang_F.Text) + "' ")
        sbXMLString.Append("madet='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang_F.Text) + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML(txtLoaihang_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        If chk_tatca.CheckState = CheckState.Checked Then
            If Len(txtmahang_F.Text) = 0 AndAlso Len(txtkhachHang_F.Text) = 0 AndAlso Len(txtloaihang_F.Text) = 0 Then
                txtmahang_F.Focus()
            Else
                _dt = New KhoSanXuatDTO("[VpsXmlKhoTam_GetData_ALL_2021]", sbXMLString.ToString, "select")
                dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
            End If

        Else
            _dt = New KhoSanXuatDTO("[VpsXmlKhoTam_GetData_2021]", sbXMLString.ToString, "select")
            dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        End If
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socay", "sokg", "somet"}
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
        'lblRow.Text = "T.Số: " & panel.Rows.Count
    End Sub

    Private Sub UpdateShowALLRows(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        Dim _chon_mau As String = String.Empty
        Dim _scolname As String = String.Empty
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
                        _scolname = "isluukhotam"
                        If ExistsColumnGridPanel(panel, _scolname) = True Then
                            If Convert.ToBoolean(row.Cells(_scolname).Value) = True Then
                                row.Cells(_scolname).CellStyles.Default.Background.Color1 = Color.Orange
                            Else
                                'row.RowStyles.Default.RowHeaderStyle.Background.Color1 = Color.Empty
                                row.Cells(_scolname).CellStyles.Default.Background.Color1 = Color.Empty
                            End If
                        End If
                        _scolname = "socay_tt"
                        If ExistsColumnGridPanel(panel, _scolname) = True Then
                            If row.Cells(_scolname).Value = 0 Then
                                row.Cells(_scolname).CellStyles.Default.Background.Color1 = Color.Red
                            ElseIf row.Cells(_scolname).Value > 0 AndAlso row.Cells("socay").Value > row.Cells(_scolname).Value Then
                                row.Cells("socay").CellStyles.Default.Background.Color1 = Color.Orange
                            ElseIf row.Cells(_scolname).Value > 0 AndAlso row.Cells("socay").Value < row.Cells(_scolname).Value Then
                                row.Cells(_scolname).CellStyles.Default.Background.Color1 = Color.Yellow
                            End If
                        End If
                        '///
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
        'panel.AddGroup(panel.Columns("mucdich"))
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        '--
        _stName = "Theo_DauKy"
        _stHeadText = "Số Lượng"
        _stCol1 = "socay"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_ThucNhap"
        _stHeadText = "Thực Nhập"
        _stCol1 = "socay_tt"
        _stCol2 = "somet_tt"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("dtngaytao"), panel.Columns("chungtu")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        End If
        '//

        tpress.Enabled = True
    End Sub

#Region "SuperGridControl1GetGroupDetailRows"

    Private Sub Super_Dgv_GroupHeaderClick(sender As Object, e As GridGroupHeaderClickEventArgs) Handles Super_Dgv.GroupHeaderClick
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        _List_group = {}
        Super_Dgv_GroupHeader_Group(panel.Rows)

    End Sub

    Private Sub Super_Dgv_GroupHeader_Group(ByVal rows As IEnumerable(Of GridElement))
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                '////
                Dim _GroupValue_Parent_name As String = String.Empty
                Dim _GroupValue_Parent As GridGroup = TryCast(group.Parent, GridGroup)
                If _GroupValue_Parent IsNot Nothing Then
                    _GroupValue_Parent_name = _GroupValue_Parent.GroupValue.ToString
                Else
                    _GroupValue_Parent_name = String.Empty
                End If
                Dim _GroupValue As String = _GroupValue_Parent_name & "-" & group.GroupValue.ToString
                If group.Expanded = True Then
                    _List_group = _List_group.Concat({_GroupValue}).ToArray
                End If
                '//
                Super_Dgv_GroupHeader_Group(group.Rows)
            End If
        Next
    End Sub

    <Obsolete>
    Private Sub SuperGridControl1GetGroupDetailRows(ByVal sender As Object, ByVal e As GridGetGroupDetailRowsEventArgs)
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns

        If panel.GroupColumns IsNot Nothing Then
            If e.GridGroup.Rows.Count > 0 Then
                Dim index As Integer = e.GridGroup.Column.ColumnIndex
                Dim detailRows As New List(Of GridRow)()
                Dim row As GridRow = clsDev.GetNewDetailRow(panel)
                Dim _Index As Integer = 0

                '---Tinh tong so cay
                row.Cells(index).EditorType = GetType(GridTextBoxXEditControl)
                row.Cells(index).Value = Convert.ToString(e.GridGroup.GroupValue)
                '//
                Dim _GroupValue_Parent_name As String = String.Empty
                Dim _GroupValue_Parent As GridGroup = TryCast(e.GridGroup.Parent, GridGroup)
                If _GroupValue_Parent IsNot Nothing Then
                    _GroupValue_Parent_name = _GroupValue_Parent.GroupValue.ToString
                Else
                    _GroupValue_Parent_name = String.Empty
                End If
                Dim _GroupValue As String = _GroupValue_Parent_name & "-" & e.GridGroup.GroupValue.ToString
                Dim result As String = Array.Find(_List_group, Function(s) s = _GroupValue)
                If result IsNot Nothing Then
                    e.GridGroup.Expanded = True
                Else
                    e.GridGroup.Expanded = False
                End If
                '///
                '---
                '///Initial Array
                ReDim Preserve _Gnumber_group(_array_column.Length)
                Array.Clear(_Gnumber_group, 0, _Gnumber_group.Length)
                '//
                clsDev.Total_Group(columns, e.GridGroup, False, _array_column)
                For x As Integer = 0 To _array_column.Length - 1
                    Dim st As Integer = clsDev.GetDisplayIndex(columns, _array_column(x))
                    Dim _svalue As Decimal = _Gnumber_group(x)
                    row.Cells(st).Value = _Gnumber_group(x)
                Next
                '///
                If e.GridGroup.Column.Name.ToString.ToUpper = _colmucdich.ToString.ToUpper Then
                    e.GridGroup.Text = "MỤC ĐÍCH: " & e.GridGroup.GroupValue.ToString.ToUpper
                    'e.GridGroup.GroupHeaderVisualStyles.Default.Background.Color1 = Color.LawnGreen
                    e.GridGroup.GroupHeaderVisualStyles.Default.TextColor = Color.Blue

                End If

                row.CellStyles.[Default].Font = _MyFont_group
                '--
                'For i As Integer = 0 To panel.Columns.Count - 1
                'row.Cells(i).CellStyles.[Default].Background = _BackColor(0)
                'Next
                ' Just for grins, let's add some color to make the
                ' totals association more readily obvious to the user
                detailRows.Add(row)
                e.DetailRows = detailRows
            End If
        End If
    End Sub

#End Region


#End Region


    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtchungtu_F.KeyDown, txtkhachHang_F.KeyDown,
        txtmahang_F.KeyDown, txtsoxe_F.KeyDown, txttaixe_F.KeyDown, txtghichu_F.KeyDown, txtloaihang_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub cboSoluong_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _filter = True Then
            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call Filterdata_Stored()
    End Sub

#Region "EXECUTE"

    Private Sub Display_Grp_Info()
        With Grp_Info
            .Location = New Point((Super_Dgv.Width / 2) - (.Width / 2), (Super_Dgv.Height / 2) - (.Height / 2))
            .Visible = True
        End With
    End Sub

    Private Sub ThemMoi()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        'Try
        Call ClearTextBox()
        _lbtn_command = 1
        '--
        Call Display_Grp_Info()
        Grp_Info.Text = "Thêm Mới Nhập Mộc"
        btnSave.Text = "Lưu Lại"
        '--
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        Taophieumoi()
    End Sub

    Private Sub ChinhSua()
        _Edit_Chungtu = True
        '--
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        'Try
        If dgvr Is Nothing Then
            MessageBox.Show("Xin vui lòng chọn dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Call Display_Grp_Info()
        Grp_Info.Text = "Cập Nhật Thông Tin Nhập Mộc"
        _lbtn_command = 2
        btnSave.Text = "Cập Nhật"
        '--
        With Me
            _chungtunhap_id = dgvr.Item("chungtu_id").Value
            .dtngaynhap.Value = dgvr.Item(_coldtngaytao).Value
            .txtchungtunhap.Text = dgvr.Item("chungtu").Value
            .txtkhachhang.Text = dgvr.Item(_colkhachhang).Value
            _Mahang_ID_MDL = dgvr.Item(_colMahang_ID).Value
            .txtmahang.Text = dgvr.Item(_colmahang).Value
            .txtloaihang.Text = dgvr.Item(_colloaihang).Value
            .txtsocay.Text = dgvr.Item(_colsocay).Value
            .txtsokg.Text = dgvr.Item(_colsokg).Value
            .txtsomet.Text = dgvr.Item(_colsomet).Value
            '.txtnoidung.Text = dgvr.Item(_colnoidung).Value
            .txtghichu.Text = dgvr.Item(_colghichu).Value
            .txtsoxe.Text = dgvr.Item(_colsoxe).Value
            .txttaixe.Text = dgvr.Item(_coltaixe).Value
        End With
        _blnEdit = True
        _Edit_Chungtu = False
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub SaoChep()
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearTextBox()
        txtchungtunhap.Text = String.Empty
        txtghichu.Text = String.Empty
        txtsoxe.Text = String.Empty
        txtmahang.Text = String.Empty
        txtloaihang.Text = String.Empty
        txtkhachhang.Text = String.Empty
        txtsokg.Text = 0
        txtsocay.Text = 0
        txtsomet.Text = 0
    End Sub

    Private Sub Taophieumoi()
        Dim str_sophieu As String
        Dim _Nam As String, _Thang As String
        Dim dbl_stt As Integer = 0
        str_sophieu = String.Empty
        '---Load gio he thong
        Call Load_TimeServer()
        _Nam = Mid$(_TimeServer.Year.ToString, 4, 1)
        _Nam = KyTu_Nam(_Nam)
        _Thang = KyTu_Thang(_TimeServer.Month)
        str_sophieu = _Nam & _Thang & _stMakytu_Nhap & "N"
        txtchungtunhap.Text = VpsXmlList_CreateID(str_sophieu, "chungtunhap")
        'dt_local = ShellServices.VpsCheckExistsCode(str_sophieu, "chungtunhap_cohoadon")
        'If dt_local.Rows.Count > 0 Then
        'txtchungtunhap.Text = dt_local.Rows(0).Item(0)
        'Else
        'txtchungtunhap.Text = str_sophieu & "0001"
        'End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Grp_Info.Visible = False
        _blnEdit = False
    End Sub
    Private Sub Update_Data(ByVal st As String, ByVal _command As String)
        If Trim(txtchungtunhap.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập mã đơn hàng.", "Thông báo")
            txtchungtunhap.Focus()
            Exit Sub

        ElseIf Trim(txtmahang.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập Mã Hàng.", "Thông báo")
            txtmahang.Focus()
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("chungtu_id='" + ReplaceTextXML(_chungtunhap_id) + "' ")
        sbXMLString.Append("chungtu='" + ReplaceTextXML(txtchungtunhap.Text) + "' ")
        sbXMLString.Append("mahang_id='" + ReplaceTextXML(_mahang_id) + "' ")
        sbXMLString.Append("madet='" + ReplaceTextXML(txtmadet.Text) + "' ")
        sbXMLString.Append("socay='" + CNumber_system(txtsocay.Text) + "' ")
        sbXMLString.Append("sokg='" + CNumber_system(txtsokg.Text) + "' ")
        sbXMLString.Append("somet='" + CNumber_system(txtsomet.Text) + "' ")
        sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
        'sbXMLString.Append("noidung='" + ReplaceTextXML(txtnoidung.Text) + "' ")
        sbXMLString.Append("soxe='" + ReplaceTextXML(txtsoxe.Text) + "' ")
        sbXMLString.Append("taixe='" + ReplaceTextXML(txttaixe.Text) + "' ")
        sbXMLString.Append("dtngaytao='" + Format$(dtngaynhap.Value, "MM/dd/yyyy") + "' ")
        sbXMLString.Append("nguoitao='" + ReplaceTextXML(strUser) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[vpsXmlKhoTam_UPSET_2021]", sbXMLString.ToString, _command)
        dtControler.UPSET_XML(_dt)
        '//
        _update_ok = True
        Call Filterdata_Stored()
        '//
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim TestComp As Integer = StrComp(btnSave.Text, "Lưu Lại", CompareMethod.Binary)
        If _lbtn_command = 1 Then
            Call MdlData.Load_TimeServer()
            _chungtunhap_id = "D" & _TimeServer.Ticks.ToString
            Call Update_Data("", "insert")
            If _update_ok = True Then
                'Call Clear_TextBox()
            End If
        Else
            If MsgBox("Bạn có muốn sửa nội dung không ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update")
            End If
        End If

    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("chungtu_id").Value.ToString
        Dim Code As String = dgvr.Cells("mahang").Value.ToString
        Dim CodeName As String = dgvr.Cells("chungtu").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Hàng: " & Code _
                        & vbCrLf & vbCrLf & " - Chứng Từ: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("chungtu_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[vpsXmlKhoTam_UPSET_2021]", sbXMLString.ToString, "delete")
            _update_ok = dtControler.UPSET_XML(_dt)
            If _update_ok = True Then
                'ISChanged = True
                '//
                Call Filterdata_Stored()
            End If
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub


#End Region

    Private Sub chk_tatca_CheckedChanged(sender As Object, e As EventArgs) Handles chk_tatca.CheckedChanged
        If chk_tatca.CheckState = CheckState.Checked Then
            dt1_F.Enabled = False
            dt2_F.Enabled = False
        Else
            dt1_F.Enabled = True
            dt2_F.Enabled = True
        End If
    End Sub
#Region "MA HANG"
    Private Sub txtmahang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmahang.KeyDown
        _bln_mahang = True
        If _bln_mahang = True Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                DgvData.Focus()
            End If
        End If
    End Sub

    Private Sub txtmahang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmahang.TextChanged
        If _bln_mahang = True Then
            Dim txt As TextBox = CType(sender, TextBox)
            Dim pnPopup As Panel = PnPopup_List
            pnPopup.Controls.Add(DgvData)
            'Me.Controls.Add(pnPopup)

            AddHandler DgvData.CellClick, AddressOf DgvMaHang_CellClick
            AddHandler DgvData.KeyDown, AddressOf DgvMaHang_KeyDown

            If Len(txt.Text) > 0 Then
                'ClsDatagridView.VpsListMaHang(txt.Text, "", DgvData)
                VpsList_Menu(txt.Text, "[VpsXmlList_MaHang_UpSet]", "select", DgvData)
                '// 
                Dim ucDscreenCoords = txt.PointToScreen(New Point(0, 0))
                Dim ucDclientCoordsRelativeToA = Me.Grp_Info.PointToClient(ucDscreenCoords)
                pnPopup.Location = New Point(ucDclientCoordsRelativeToA.X, ucDclientCoordsRelativeToA.Y + txt.Height)
                pnPopup.Size = New Size(CInt(Me.Width * 0.7), CInt(Me.Height * 0.7))
                pnPopup.Visible = True
                pnPopup.BringToFront()
                '--
            Else
                pnPopup.Visible = False
                _bln_mahang = False
                _mahang_id = String.Empty
                txtloaihang.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub DgvMaHang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Call Load_Textbox_MaHang(sender)
    End Sub

    Private Sub DgvMaHang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Load_Textbox_MaHang(sender)
        End If
    End Sub

    Private Sub Load_Textbox_MaHang(ByVal Dgv As DataGridView)
        With Dgv
            If _bln_mahang = True Then
                _bln_mahang = False
                _mahang_id = ExistsColumn_Dgv(Dgv, _colMahang_ID, "").ToString
                txtmahang.Text = ExistsColumn_Dgv(Dgv, _colmahang, "").ToString
                txtloaihang.Text = ExistsColumn_Dgv(Dgv, _colloaihang, "").ToString
                '//
                txtkhachhang.Text = ExistsColumn_Dgv(Dgv, "khachhang", "").ToString
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvMaHang_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvMaHang_KeyDown
        PnPopup_List.Visible = False
        txtmadet.Focus()
        '//
        Filterdata_Stored()
    End Sub
#End Region

#Region "EXCEL"
    Private Sub ToolStripButton_PhieuNhapKho_Click(sender As Object, e As EventArgs) Handles btnExport_excel.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If Super_Dgv.PrimaryGrid.Rows.Count = 0 Then
            Exit Sub
        End If
        '--
        Dim btn As ToolStripButton = CType(sender, ToolStripButton)
        With btn
            .Text = "Xin Chờ..."
            .Enabled = False
            If MsgBox("Bạn có Muốn In (Yes: In / No: Thoát) ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "In PDF") = MsgBoxResult.Yes Then
                _IsPrint = False
                _IsPrint_PrintArea = True
                _IsPrint_Sum = True
                _IsPrint_GridArea = True
                _IsNotPrint_GroupName = True
                '//
                Call ExportExcel()
                _IsPrint_PrintArea = False
                _IsPrint_Sum = False
                _IsPrint_GridArea = False
                _IsNotPrint_GroupName = False
            End If
            .Text = "Xuất Excel"
            .Enabled = True
        End With
    End Sub
    Private Sub ExportExcel()
        moClsExcel = New ClsExportExcel
        With moClsExcel
            .strfileExcel_1 = "Report_NhapMoc.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "dtngaynhap", "chungtunhap", "A", "donhang", "mahang", "khachhang", "loaihang",
               "quicach", "madet", "socay", "sokg", "somet", "socay_tt", "sokg_tt", "somet_tt", "nhom_hoadon",
               "makytu", "mucdich", "noidung", "ghichu", "soxe", "taixe", "nhanvien", "dtcapnhat"}
            ._rangeExcel_Text = {"I"}
            ._rangeExcel_number_0 = {"J", "M"}
            ._rangeExcel_number_1 = {"K", "L", "N", "O"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "X"}
            ._GridArea = {"A", "X"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socay", "sokg", "somet", "socay_tt", "sokg_tt", "somet_tt"}
        End With
        '//
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _GdtNgayIn_1 = Format$(dt1_F.Value, "dd/MM/yyyy")
        _GdtNgayIn_2 = Format$(dt2_F.Value, "dd/MM/yyyy")
        '//
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub



#End Region
End Class