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
Public Class frmnhapmoc
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
    '//
    Private Ldonhang As String = String.Empty
    Private Lmahang As String = String.Empty
    Private LKhachhang As String = String.Empty
    Private LLoaihang As String = String.Empty
    Private Lkhovai As String = String.Empty
    Private Lmetkg As String = String.Empty
    Private LMaMau As String = String.Empty
    Private LTenmau As String = String.Empty
    Private LSocay As Int16 = 0
    Private LSokg As Single = 0
    Private LSomet As Single = 0
    Private LLoaiDay As String = String.Empty
    Private LGhiChu As String = String.Empty

#Region " Load du liệu lên bảng khi mở Form"

#Region "Private data"

    Private _BackColor As Background() = {New Background(Color.LightGreen), _
        New Background(Color.FromArgb(&HE5, &HFF, &HDD)), New Background(Color.AliceBlue)}

    Private _MyFont As New Font("Time New Roman", 10, FontStyle.Bold Or FontStyle.Italic)
#End Region

    Private Sub Me_FormClosing(ByVal sender As Object, _
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        Super_Dgv.Dispose()
        dt_local.Dispose()
        Super_Dgv.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SuspendLayout()
        '--
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
        AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
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
        If _btView = True Then
            btnAdd.Enabled = IIf(_btAdd = True, True, False)
            btnModify.Enabled = IIf(_btModify = True, True, False)
            btnDelete.Enabled = IIf(_btDelete = True, True, False)
            '----------
            cboSoluong.SelectedIndex = 0
            Call Filterdata_Stored()
            '----------------
            txtClr_Vuot.BackColor = Color.MediumVioletRed
            txtClr_Chuanhapdu.BackColor = Color.Violet
            txtClr_NhapDu.BackColor = Color.White
            txtClr_ChuaNhap.BackColor = Color.LightSeaGreen
            _filter = True
            '----------------
            _blnEdit = False
        Else
            Me.Close()
        End If
    End Sub

#End Region

#Region "XEM CHI TIET"
    Private Sub ShowModalForm_XemChiTiet()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_XemChiTiet))
        Else
            With frmNhapMoc_chiTiet_View
                .Size = New Size(Form1.Width * 0.95, Form1.Height * 0.9)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_Stored()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub

    Private Sub Super_Dgv_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellDoubleClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        'Try
        If dgvr IsNot Nothing Then
            With frmNhapMoc_chiTiet_View
                .Chungtunhap_id = dgvr.Cells("chungtunhap_id").Value
            End With
            ShowModalForm_XemChiTiet()
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
        '//
        If dgvr IsNot Nothing Then
            Ldonhang = dgvr.Cells("donhang").FormattedValue.ToString
            '//
            Lmahang = dgvr.Cells("mahang").FormattedValue.ToString
            LLoaihang = dgvr.Cells("loaihang").FormattedValue.ToString
            'Lkhovai = dgvr.Cells("khovai").FormattedValue.ToString & " cm"
            'Lmetkg = dgvr.Cells("metkg").FormattedValue.ToString & " g/m2)"
            '///
            LGhiChu = dgvr.Cells("ghichu").FormattedValue.ToString
            '//
            'Them <br/> để xuống dòng
            Dim stinfo As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo &= "<font size=""12""><font color=""Black""> {1} </font></font>"
            Dim stinfo_br As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo_br &= "<font size=""12""><font color=""RED""> {1} </font></font><br/>"
            '//

            Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
            '////
            panel.Footer.Text = String.Format(stinfo, "+ ĐƠN HÀNG: ", Ldonhang.ToUpper & " || ")
            panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ HÀNG: ", Lmahang.ToUpper & " - " & LLoaihang.ToUpper)
            panel.Footer.Text &= String.Format(stinfo_br, "+ GHI CHÚ: ", LGhiChu)

        Else

        End If

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

    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_ColumnFrozen.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        panel.FrozenColumnCount = _Column_Forzen_pos
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
        sbXMLString.Append("donhang='" + ReplaceTextXML(txtdonhang_F.Text) + "' ")
        sbXMLString.Append("makhach='" + ReplaceTextXML("") + "' ")
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
                _dt = New KhoSanXuatDTO("[VpsXmlKhoMoc_NhapKho_GetData_ALL_2021]", sbXMLString.ToString, "select")
                dt_local = dtControler.SELECT_XML_Datatable(_dt)
            End If

        Else
            _dt = New KhoSanXuatDTO("[VpsXmlKhoMoc_NhapKho_GetData_2021]", sbXMLString.ToString, "select")
            dt_local = dtControler.SELECT_XML_Datatable(_dt)
        End If
        '//

        Dim _condition As String = String.Empty
        Dim dataSource As Object = Nothing
        '//
        If cboSoluong.SelectedIndex = 0 Then
            _condition = ""
        ElseIf cboSoluong.SelectedIndex = 1 Then
            _condition = "socay=socay_tt"
        ElseIf cboSoluong.SelectedIndex = 2 Then
            _condition = "socay>socay_tt and socay_tt>0"
        ElseIf cboSoluong.SelectedIndex = 3 Then
            _condition = "socay_tt=0"
        End If
        '//
        '--
        Dim rows() As DataRow = Nothing
        If String.IsNullOrEmpty(_condition) = True Then
            rows = dt_local.Select
        Else
            rows = dt_local.Select(_condition)
        End If
        If rows.Count > 0 Then ' first check to see if the array has rows '
            dataSource = rows.CopyToDataTable() ' dt now exists and contains rows '
        Else
            dataSource = Nothing
        End If
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        panel.DataSource = dataSource
        '///
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socay", "sokg", "somet", "socay_tt", "sokg_tt", "somet_tt"}
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
        Dim st As String = "<div align=""center"">" & "<font color=""Blue"">{0}</font><br/>" & "<font color=""Black"">{1}</font>" & "</div>"
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
                                If IsDBNull(row.Cells(_array_column(x)).Value) = False Then
                                    _sValue += row.Cells(_array_column(x)).Value
                                End If
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
        '//Ẩn Cột
        For Each item As GridElement In panel.Columns
            Dim column As GridColumn = TryCast(item, GridColumn)
            Dim _TFormat As String = String.Empty
            If column.Name.ToLower.Contains("_id") = True Then
                column.Visible = False
            End If
        Next item
        '//
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("dtngaynhap"), panel.Columns("chungtunhap")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirDesDes(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDesDes(sortCols))
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
        txtmahang_F.KeyDown, txtsoxe_F.KeyDown, txttaixe_F.KeyDown, txtghichu_F.KeyDown, txtloaihang_F.KeyDown, txtdonhang_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call Filterdata_Stored()
    End Sub


#Region "EXECUTE"
    Private Sub ShowModalForm_DonHang()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_DonHang))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmnhapmoc_Input
                .Size = New Size(Me.Width * 0.95, Me.Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_Stored()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub
    Private Sub ThemMoi()
        _Nhapmoc_status = 1
        ShowModalForm_DonHang()
    End Sub

    Private Sub ChinhSua()

        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        'Try
        If dgvr Is Nothing Then
            MessageBox.Show("Xin vui lòng chọn dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmnhapmoc_Input.DonHang = dgvr.Cells("donhang").FormattedValue
        frmnhapmoc_Input.Chungtu = dgvr.Cells("chungtunhap").FormattedValue
        _Nhapmoc_status = 2
        ShowModalForm_DonHang()
    End Sub

    Private Sub SaoChep()
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("chungtunhap_id").Value.ToString
        Dim Code As String = dgvr.Cells("mahang").Value.ToString
        Dim CodeName As String = dgvr.Cells("chungtunhap").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Hàng: " & Code _
                        & vbCrLf & vbCrLf & " - Chứng Từ: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("chungtunhap_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[vpsXmlKhoMoc_NhapKho_UPSET_2021]", sbXMLString.ToString, "delete")
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

    Private Sub btnCanmoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanMoc.Click
        Dim _kieunhap_id As String = String.Empty

        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        If dgvr IsNot Nothing Then
            '_kieunhap_id = dgvr.Cells(_colkieunhap_id).Value
            frmNhapMoc_CanMoc.ShowDialog()
        End If
        Call Filterdata_Stored()
    End Sub

    Private Sub chk_tatca_CheckedChanged(sender As Object, e As EventArgs) Handles chk_tatca.CheckedChanged
        If chk_tatca.CheckState = CheckState.Checked Then
            dt1_F.Enabled = False
            dt2_F.Enabled = False
        Else
            dt1_F.Enabled = True
            dt2_F.Enabled = True
        End If
    End Sub

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
            If MsgBox("Bạn có Muốn Xuất Excel (Yes: Xuất Excel / No: Thoát) ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "In PDF") = MsgBoxResult.Yes Then
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
            '//Lay ID File Excel
            'Dim LFileName As String = String.Empty
            'Dim LFolder_Path As String = String.Empty
            Dim dtExcel As DataTable = VpsXmlList_Load_Title("", "F002", "[VpsXmlList_InfoExcel_UpSet]", "select_id")
            If dtExcel.Rows.Count = 1 Then
                .strfolder_path = dtExcel.Rows(0).Item("folder_path")
                .strfileExcel_1 = dtExcel.Rows(0).Item("fileexcel")
            Else
                Exit Sub
            End If
            '//
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "dtngaynhap", "chungtunhap", "A", "donhang", "mahang", "khachhang", "loaihang",
                "khovai", "metkg", "socay", "sokg", "somet", "socay_tt", "sokg_tt", "somet_tt", "mucdich", "noidung",
                "ghichu", "soxe", "taixe", "nhanvien", "dtcapnhat"}
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

#Region "DON HANG"
    Private Sub txtdonhang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdonhang.KeyDown
        _bln_donhang = True
        If _bln_donhang = True Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                DgvData.Focus()
            End If
        End If
    End Sub

    Private Sub txtdonhang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdonhang.TextChanged
        If _bln_donhang = True Then
            Dim txt As TextBox = CType(sender, TextBox)
            Dim pnPopup As Panel = PnPopup_List
            pnPopup.Controls.Add(DgvData)
            DgvData.AllowUserToAddRows = False
            'Me.Controls.Add(pnPopup)

            AddHandler DgvData.CellClick, AddressOf DgvDonHang_CellClick
            AddHandler DgvData.KeyDown, AddressOf DgvDonHang_KeyDown

            If Len(txt.Text) > 0 Then
                VpsList_Menu(txt.Text, "[VpsXmlDonHang_Main_GetData_2021]", "select_find", DgvData)
                '// 
                If DgvData.Rows.Count > 0 Then
                    Dim ucDscreenCoords = txt.PointToScreen(New Point(0, 0))
                    Dim ucDclientCoordsRelativeToA = GP_Form_CapNhat_DonHang.PointToClient(ucDscreenCoords)
                    pnPopup.Location = New Point(ucDclientCoordsRelativeToA.X, ucDclientCoordsRelativeToA.Y + txt.Height)
                    pnPopup.Size = New Size(CInt(GP_Form_CapNhat_DonHang.Width * 0.8), CInt(GP_Form_CapNhat_DonHang.Height * 0.8))
                    pnPopup.Visible = True
                    pnPopup.BringToFront()
                    '--
                Else
                    pnPopup.Visible = False
                End If

            Else
                pnPopup.Visible = False
                _bln_donhang = False
                _donhang_id = String.Empty
            End If
        End If
    End Sub

    Private Sub DgvDonHang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Call Load_Textbox_DonHang(sender)
    End Sub

    Private Sub DgvDonHang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Load_Textbox_DonHang(sender)
        End If
    End Sub

    Private Sub Load_Textbox_DonHang(ByVal Dgv As DataGridView)
        With Dgv
            If _bln_donhang = True Then
                _bln_donhang = False
                _donhang_id = ExistsColumn_Dgv(Dgv, _colDonhang_ID, "").ToString
                txtdonhang.Text = ExistsColumn_Dgv(Dgv, _coldonhang, "").ToString
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvDonHang_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvDonHang_KeyDown
        PnPopup_List.Visible = False
        txtghichu_F.Focus()

    End Sub
#End Region

#Region "CAP NHAT DON HANG"
    Private Sub BtnThoat_Panel_Mamau_Click(sender As Object, e As EventArgs) Handles BtnThoat_Panel_Mamau.Click
        GP_Form_CapNhat_DonHang.Visible = False
    End Sub


    Private Sub ToolStripButton_DonHang_Click(sender As Object, e As EventArgs) Handles ToolStripButton_DonHang.Click
        Dim btn As ToolStripButton = CType(sender, ToolStripButton)
        With GP_Form_CapNhat_DonHang
            .Text = "CẬP NHẬT ĐƠN HÀNG"
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
            .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
            .BringToFront()
            .Visible = True
        End With
    End Sub
    Private Sub btnCapNhat_MaMau_Click(sender As Object, e As EventArgs) Handles btnCapNhat_MaMau.Click
        If Len(_donhang_id) = 0 Then Exit Sub
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện thay đổi ĐƠN HÀNG?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_update_donhang(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[vpsXmlKhoMoc_NhapKho_UPSET_2021]", sbXMLString.ToString, "update_admin")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub UpdateDetails_update_donhang(ByVal rows As IEnumerable(Of GridElement))
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_donhang(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("chungtunhap_id='" + ReplaceTextXML(row.Cells("chungtunhap_id").Value.ToString.Trim) + "' ")
                    sbXMLString.Append("donhang_id='" + ReplaceTextXML(_donhang_id) + "' ")
                    'sbXMLString.Append("khovai='" + ReplaceTextXML(txtkhovai.Text) + "' ")
                    'sbXMLString.Append("metkg='" + ReplaceTextXML(txtmetkg.Text) + "' ")
                    sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
                    '//
                    Dim _mota_chuyenmau As String = "CHUYỂN ĐƠN HÀNG"
                    sbXMLString.Append("mota_chuyenmau='" + ReplaceTextXML(_mota_chuyenmau) + "' ")
                    sbXMLString.Append("tenform='" + ReplaceTextXML(Me.Name.ToString) + "' ")
                    sbXMLString.Append("tencot='" + ReplaceTextXML(row.Cells("mahang").Value.ToString.Trim) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next
    End Sub
#End Region
End Class