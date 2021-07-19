Imports System
Imports System.Collections.Generic
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text

Public Class frmDonHang_LenhSanXuat_TaoMe
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable

    Dim _update_Ok As Boolean = False
    Dim _local_command As String = String.Empty
    Dim _bln_khachhang As Boolean = False, _bln_mahang As Boolean = False, _bln_mamau As Boolean = False, _bln_donhang As Boolean = False
    Private _bln_macongnghe As Boolean = False
    Dim _bln_tenmau As Boolean = False
    Private _makh_id As String = String.Empty, _mahang_id As String = String.Empty, _mamau_id As String = String.Empty
    Private _sName As String = String.Empty
    Private _mame_id As String = String.Empty, _donhang_id As String = String.Empty, _macn_id As String = String.Empty
    Private _donhang As String = String.Empty
    Private _lbtn_command As SByte = 0
    Private _IsBusy As Boolean = False
    Dim dr2 As DataRow()
    Dim _saveRowIndex As Integer = 0
    Dim _Column_Forzen_pos As Integer = 0
    Dim _intRows_ALL As Integer = 0
    Dim _intColumns_ALL As Integer = 0, _intGroup_count As Integer = 0
    Dim _List_MameID As String() = {}
    Dim strList As List(Of String) = _List_MameID.ToList()
    Dim Lc_id_donhang As String = String.Empty

    '///
    '//
    Dim _List_Mame As String() = {}
    Dim strMame As List(Of String) = _List_Mame.ToList()
    '//
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"donhang", "ghichu_thuchien_1", "mamau_khachhang", "tenmau_nhuom", "macongnghe_yeucau", "mame_ghep"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    '//
    Private DgvData As DataGridView = New DataGridView()
    Public Property DonHang() As String
        Get
            Return _donhang
        End Get
        Set(ByVal value As String)
            _donhang = value
        End Set
    End Property
    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing

        Me.DialogResult = DialogResult.OK
        '//
        Call clsDev.SaveColumn(Super_Dgv_DonHang.PrimaryGrid, Me.Name.ToString)
        Call clsDev.SaveColumn(Super_Dgv_MaMe.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Me.Dispose()
        '--
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_local = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv_DonHang, _MyFont_GridView - 1)
        Call clsDev.Format_Super_Dgv(Super_Dgv_MaMe, _MyFont_GridView - 1)
        With Super_Dgv_MaMe
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = Tbool.False
        End With
        '--  
        AddHandler Super_Dgv_DonHang.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv_DonHang.CellClick, AddressOf Super_Dgv_DonHang_CellClick
        AddHandler Super_Dgv_DonHang.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv_MaMe.DataBindingComplete, AddressOf Super_Dgv_MaMe_DataBindingComplete
        '--
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '--
        ChkMeMau.CheckState = CheckState.Unchecked
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If _donhang_status = 10 Then
            _lbtn_command = 1
            '//
            Call Filterdata_Stored_DonHang()
        End If
    End Sub

    Private Sub Taophieumoi()
        Dim str_sophieu As String
        Dim _Nam As String, _Thang As String
        Dim dbl_stt As Integer = 0
        str_sophieu = String.Empty
        '---Load gio he thong

        Call Load_TimeServer()
        _Nam = Mid$(_TimeServer.Year.ToString, 4, 1)
        _Thang = KyTu_Thang_Nhom2(_TimeServer.Month)
        str_sophieu = _Nam & _Thang
        'dt_local = ShellServices.VpsCheckExistsCode(str_sophieu, "mame_nhom_khonghoadon")

        '--
        txtmame.Text = VpsXmlList_CreateID(str_sophieu, "mame")
        'If dt_local.Rows.Count > 0 Then
        'txtmame.Text = dt_local.Rows(0).Item(0)
        'Else
        'txtmame.Text = str_sophieu & "0001"
        'End If
        _lbtn_command = 1
        '//
        btnSave.Text = "Lưu Lại"
    End Sub

#Region "DON HANG"
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = e.GridColumn.ColumnIndex

            ShowContextMenu(CtxMenu)
        End If
    End Sub

    Private Sub Super_Dgv_DonHang_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv_DonHang.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        End If
        If e.GridCell.ColumnIndex = 0 Then
            panel.ReadOnly = False
            If dgvr.Checked = False Then
                dgvr.Checked = True
                dgvr.CellStyles.Default.Background.Color1 = Color.GreenYellow
            Else
                dgvr.Checked = False
                dgvr.CellStyles.Default.Background.Color1 = Color.Empty
            End If
        Else
            panel.ReadOnly = True
        End If
        _saveRowIndex = e.GridCell.RowIndex
        If dgvr IsNot Nothing AndAlso dgvr.IsDetailRow = False Then
            Lc_id_donhang = Exists_ColDev_Value(panel, "c_id").ToString
            _donhang_id = Exists_ColDev_Value(panel, "donhang_id").ToString
            txtmadonhang.Text = Exists_Column_SuperDgv(panel, _colmadonhang).ToString
            txtdonhang.Text = Exists_Column_SuperDgv(panel, _coldonhang).ToString
            txtkhachhang.Text = Exists_ColDev_Value(panel, _colkhachhang).ToString
            '---
            _mahang_id = Exists_ColDev_Value(panel, _colMahang_ID).ToString
            txtmahang.Text = Exists_ColDev_Value(panel, _colmahang).ToString
            txtloaihang.Text = Exists_ColDev_Value(panel, _colloaihang).ToString
            'txtmadet.Text = Exists_ColDev_Value(panel, "madet").ToString
            txtkhovai.Text = Exists_ColDev_Value(panel, "khovai").ToString
            txtmetkg.Text = Exists_ColDev_Value(panel, "metkg").ToString
            '--
            'txtsocay.Text = FormatNumber(Exists_ColDev_Value(panel, _colsocay), 0)
            'txtsokg.Text = FormatNumber(Exists_ColDev_Value(panel, _colsokg), 1)
            'txtsomet.Text = FormatNumber(Exists_ColDev_Value(panel, _colsomet), 1)
            '--
            '_mamau_id = Exists_ColDev_Value(panel, _colMamau_ID).ToString
            'txtmamau.Text = Exists_ColDev_Value(panel, "mamau").ToString
            'txtmau.Text = Exists_ColDev_Value(panel, "tenmau").ToString
            '//
            txtmamau_khach.Text = Exists_ColDev_Value(panel, "mamau_khach").ToString
            txttenmau_khach.Text = Exists_ColDev_Value(panel, "tenmau_khach").ToString
            '--
            RichTextBoxEx_ghichu.Text = Exists_Column_SuperDgv(panel, "canhbao_donhang").ToString
            txtmahang.Focus()
            '//
            Taophieumoi()
            '//
            Call Filterdata_Stored_MaMe()
        End If
    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub

    Private Sub CircleProcess_Start()
        Try
            With CircularProgress1
                .Location = New Point(CInt((Super_Dgv_DonHang.Width - .Width) / 2), CInt((Super_Dgv_DonHang.Height - .Height) / 2))
                .IsRunning = True
                .Visible = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CircleProcess_Stop()
        wait(200)
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub

    Private Sub Filterdata_Stored_DonHang()
        Me.SuspendLayout()
        'Try
        Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(_donhang) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_DonHang_TaoMeNhuom_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '//
        'Dim panel As GridPanel = Super_Dgv_DonHang.PrimaryGrid
        dtControler.SELECT_XML(_dt, Super_Dgv_DonHang.PrimaryGrid)
        'panel.DataSource = New DataView(dt_local, "", "", DataViewRowState.CurrentRows)
        '//

        Call CircleProcess_Stop()
        Me.ResumeLayout()
    End Sub
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
        panel.AddGroup(panel.Columns("mahang"))
        '//
        _List_group = {}
        _List_group = _List_group.Concat({txtmahang.Text}).ToArray
        '//
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        '--
        _stName = "Theo_DauKy"
        _stHeadText = "Số Lượng"
        _stCol1 = "tongsome"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            'panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_YeuCau"
        _stHeadText = "Yêu Cầu"
        _stCol1 = "socay"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '//
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("intnhomhang"), panel.Columns("mahang"),
              panel.Columns("mamau_khach")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        End If
        '//
        tpress.Enabled = True
        '//
    End Sub


#Region "SUM"

    Dim _array_column As String() = {"tongsome", "tongsome_phanme", "socay", "sokg", "socay_phanme"}
    Dim _array_value As Decimal() = {0, 0, 0, 0}
    Private tpress As New Timer With {.Interval = 200}
    Dim _blnPress As Boolean = False

    Private Sub Super_Dgv_FilterEditValueChanged(sender As Object, e As GridFilterEditValueChangedEventArgs) Handles Super_Dgv_DonHang.FilterEditValueChanged
        Super_Dgv_DonHang.SuspendLayout()
        _blnPress = False
        tpress.Enabled = False
        tpress.Enabled = True
        Super_Dgv_DonHang.ResumeLayout()
    End Sub

    Sub MyTickHandler(ByVal sender As Object, ByVal e As EventArgs)
        '//
        tpress.Enabled = False
        _blnPress = True
        Dim panel As GridPanel = Super_Dgv_DonHang.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        ReDim Preserve _array_value(_array_column.Length)
        Array.Clear(_array_value, 0, _array_value.Length)

        Call UpdateShowALLRows(panel.Rows)

        'lblRow.Text = "Tổng số: " & n
        Dim st As String = "<div align=""center"">" & "<font color=""Black"">{0}</font><br/>" & "<font color=""Blue"">{1}</font>" & "</div>"
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
        Dim panel As GridPanel = Super_Dgv_DonHang.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        Dim _chon_mau As String = String.Empty
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
    Public Function GetSortDirDescAscAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Ascending, SortDirection)})
    End Function

#Region "SuperGridControl1GetGroupDetailRows"
    '//
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
                Dim _lsoluong As Decimal = clsDev.Total_Row(e.GridGroup)
                Dim _GroupValue As String = e.GridGroup.GroupValue.ToString
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
                If e.GridGroup.Column.Name.ToString.ToUpper = "mahang".ToString.ToUpper Then
                    e.GridGroup.Text = "MÃ HÀNG: " & e.GridGroup.GroupValue.ToString.ToUpper & " - " & _lsoluong
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

#Region "MA ME"

    Private Sub Filterdata_Stored_MaMe()
        If Lc_id_donhang.Length < 3 Then Exit Sub
        Me.SuspendLayout()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("c_id='" + ReplaceTextXML(Lc_id_donhang) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_DonHang_MeNhuom_GetData_ID]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML(_dt, Super_Dgv_MaMe.PrimaryGrid)
        Me.ResumeLayout()
    End Sub

    Private Sub Super_Dgv_MaMe_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
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
        _stName = "Theo_MauKhach"
        _stHeadText = "Khách Hàng"
        _stCol1 = "mamau_khach"
        _stCol2 = "tenmau_khach"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_MauSTh"
        _stHeadText = "Song Thủy"
        _stCol1 = "mamau"
        _stCol2 = "tenmau"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_YeuCau"
        _stHeadText = "Yêu Cầu"
        _stCol1 = "socay"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_PhanMe"
        _stHeadText = "Phân Mẻ"
        _stCol1 = "socay_phanme"
        _stCol2 = "somet_phanme"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '//
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("dtngaytao"), panel.Columns("intnhomhang"),
            panel.Columns("mahang")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        End If
        '//

    End Sub

#End Region
    Private Sub Update_Data(ByVal st As String, ByVal _command As String)
        If Trim(txtmame.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập mã mẻ.", "Thông báo")
            txtmame.Focus()
            Exit Sub
        ElseIf Trim(txtdonhang.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập tên đơn hàng.", "Thông báo")
            txtdonhang.Focus()
            Exit Sub
        ElseIf Trim(_mahang_id) = "" Then
            MessageBox.Show("Xin vui lòng nhập Mã hàng.", "Thông báo")
            txtmahang.Focus()
            Exit Sub
        ElseIf CInt(CNumber_system(txtsocay.Text)) = 0 Then
            MessageBox.Show("Xin vui lòng nhập số cây.", "Thông báo")
            txtsocay.Focus()
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("c_id_donhang='" + ReplaceTextXML(Lc_id_donhang) + "' ")
        sbXMLString.Append("donhang_id='" + ReplaceTextXML(_donhang_id) + "' ")
        sbXMLString.Append("mahang_id='" + ReplaceTextXML(_mahang_id) + "' ")
        sbXMLString.Append("makh_id='" + ReplaceTextXML("-") + "' ")
        sbXMLString.Append("mamau_id='" + ReplaceTextXML(_mamau_id) + "' ")
        sbXMLString.Append("mamau_khach='" + ReplaceTextXML(txtmamau_khach.Text) + "' ")
        sbXMLString.Append("tenmau_khach='" + ReplaceTextXML(txttenmau_khach.Text) + "' ")
        sbXMLString.Append("macongdoan_yeucau='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame.Text.Trim) + "' ")
        sbXMLString.Append("mame_ghep='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(txtmame.Text.Trim) + "' ")
        sbXMLString.Append("issample='" + CNumber_system(ChkMeMau.CheckValue) + "' ")
        sbXMLString.Append("nhom_hoadon='" + CNumber_system(0) + "' ")
        sbXMLString.Append("nhomloi_id='" + ReplaceTextXML("NL00") + "' ")
        sbXMLString.Append("khovai='" + ReplaceTextXML(txtkhovai.Text) + "' ")
        sbXMLString.Append("metkg='" + ReplaceTextXML(txtmetkg.Text) + "' ")
        sbXMLString.Append("socay='" + CNumber_system(txtsocay.Text) + "' ")
        sbXMLString.Append("sokg='" + CNumber_system(txtsokg.Text) + "' ")
        sbXMLString.Append("somet='" + CNumber_system(txtsomet.Text) + "' ")
        sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
        sbXMLString.Append("nguoitao='" + ReplaceTextXML(strUser) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, _command)
        dtControler.UPSET_XML(_dt)
        '//
        _update_Ok = True
        '//
        Call Filterdata_Stored_DonHang()
        '//
        Call Filterdata_Stored_MaMe()
        '//
    End Sub

    Private Sub Rdb_Nhom1_CheckedChanged(sender As Object, e As EventArgs)
        Call Taophieumoi()
    End Sub

    Private Sub Load_TextBox_Local()
        Dim panel As GridPanel = Super_Dgv_DonHang.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        With dgvr
            If dgvr IsNot Nothing Then
                _donhang_id = Exists_ColDev_Value(panel, "donhang_id").ToString
                txtmadonhang.Text = Exists_Column_SuperDgv(panel, _colmadonhang).ToString
                txtdonhang.Text = Exists_Column_SuperDgv(panel, _coldonhang).ToString
                txtkhachhang.Text = Exists_ColDev_Value(panel, _colkhachhang).ToString
                '---
                _mahang_id = Exists_ColDev_Value(panel, _colMahang_ID).ToString
                txtmahang.Text = Exists_ColDev_Value(panel, _colmahang).ToString
                txtloaihang.Text = Exists_ColDev_Value(panel, _colloaihang).ToString
                'txtmadet.Text = Exists_ColDev_Value(panel, "madet").ToString
                txtkhovai.Text = Exists_ColDev_Value(panel, "khovai").ToString
                txtmetkg.Text = Exists_ColDev_Value(panel, "metkg").ToString
                '--
                txtmame.Text = Exists_ColDev_Value(panel, "mame").ToString
                txtsocay.Text = FormatNumber(Exists_ColDev_Value(panel, _colsocay), 0)
                txtsokg.Text = FormatNumber(Exists_ColDev_Value(panel, _colsokg), 1)
                txtsomet.Text = FormatNumber(Exists_ColDev_Value(panel, _colsomet), 1)
                '//
                txtmamau_khach.Text = Exists_ColDev_Value(panel, "mamau_khach").ToString
                txttenmau_khach.Text = Exists_ColDev_Value(panel, "tenmau_khach").ToString
                '--
                _mamau_id = Exists_ColDev_Value(panel, _colMamau_ID).ToString
                txtmamau.Text = Exists_ColDev_Value(panel, _colMamau).ToString
                txtmau.Text = Exists_ColDev_Value(panel, _colMau).ToString
                '--
                txtghichu.Text = Exists_Column_SuperDgv(panel, _colghichu).ToString
                dtngaynhap.Value = Format$(dgvr.Cells("dtngaytao").Value, "dd/MM/yyyy")
                'dtngaygiao.Value = Convert.ToDateTime(Exists_Column_SuperDgv(panel, _coldtngaygiao))
                txtmahang.Focus()
            End If
        End With
    End Sub

    Private Sub Clear_TextBox()
        txtsocay.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If _lbtn_command = 1 Then
            Call MdlData.Load_TimeServer()
            _mame_id = "D" & _TimeServer.Ticks.ToString
            Call Update_Data("", "insert")
            If _update_Ok = True Then
                Call Clear_TextBox()
                '///
                btnAdd_Click(Nothing, Nothing)
            End If
        Else
            If MsgBox("Bạn có muốn sửa nội dung không ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update_taomenhuom")
            End If
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonItem_MaMe_Delete_Click(sender As Object, e As EventArgs) Handles ButtonItem_MaMe_Delete.Click
        Dim panel As GridPanel = Super_Dgv_MaMe.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("mame_id").Value.ToString
        Dim Code As String = dgvr.Cells("mame").Value.ToString
        Dim CodeName As String = dgvr.Cells("donhang").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Mẻ: " & Code _
                        & vbCrLf & vbCrLf & " - Đơn Hàng: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mame_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append("mota_chuyenmau='" + ReplaceTextXML("Xóa Mẻ") + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append("tenform='" + ReplaceTextXML(Me.Name.ToString) + "' ")
            sbXMLString.Append("tencot='" + ReplaceTextXML(Code) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "delete")
            _update_Ok = dtControler.UPSET_XML(_dt)
            If _update_Ok = True Then
                'ISChanged = True
                '//
                Call Filterdata_Stored_DonHang()
                '//
                Call Filterdata_Stored_MaMe()
            End If
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub

    Private Sub ButtonItem_MaMe_ChinhSua_Click(sender As Object, e As EventArgs) Handles ButtonItem_MaMe_ChinhSua.Click
        Dim panel As GridPanel = Super_Dgv_MaMe.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)

        If dgvr IsNot Nothing AndAlso dgvr.IsDetailRow = False Then
            Lc_id_donhang = Exists_ColDev_Value(panel, "c_id_donhang").ToString
            _donhang_id = Exists_ColDev_Value(panel, "donhang_id").ToString
            txtmadonhang.Text = Exists_Column_SuperDgv(panel, _colmadonhang).ToString
            txtdonhang.Text = Exists_Column_SuperDgv(panel, _coldonhang).ToString
            txtkhachhang.Text = Exists_ColDev_Value(panel, _colkhachhang).ToString
            txtmame.Text = Exists_ColDev_Value(panel, "mame").ToString
            '---
            _mahang_id = Exists_ColDev_Value(panel, _colMahang_ID).ToString
            txtmahang.Text = Exists_ColDev_Value(panel, _colmahang).ToString
            txtloaihang.Text = Exists_ColDev_Value(panel, _colloaihang).ToString
            txtkhovai.Text = Exists_ColDev_Value(panel, "khovai").ToString
            txtmetkg.Text = Exists_ColDev_Value(panel, "metkg").ToString
            '--
            txtsocay.Text = FormatNumber(Exists_ColDev_Value(panel, _colsocay), 0)
            txtsokg.Text = FormatNumber(Exists_ColDev_Value(panel, _colsokg), 1)
            txtsomet.Text = FormatNumber(Exists_ColDev_Value(panel, _colsomet), 1)
            '--
            '_mamau_id = Exists_ColDev_Value(panel, _colMamau_ID).ToString
            'txtmamau.Text = Exists_ColDev_Value(panel, "mamau").ToString
            'txtmau.Text = Exists_ColDev_Value(panel, "tenmau").ToString
            '//
            txtmamau_khach.Text = Exists_ColDev_Value(panel, "mamau_khach").ToString
            txttenmau_khach.Text = Exists_ColDev_Value(panel, "tenmau_khach").ToString
            '--
            RichTextBoxEx_ghichu.Text = Exists_Column_SuperDgv(panel, "canhbao_donhang").ToString
            txtmahang.Focus()
            '//
            _lbtn_command = 2
            '//
            btnSave.Text = "Cập Nhật"
        End If
    End Sub



#Region "EXECUTE"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Call Clear_TextBox()
        txtdonhang.Focus()
        btnSave.Text = "Lưu Lại"
        '//
        Call Taophieumoi()
    End Sub


    Private Sub btnModify_Click(sender As Object, e As EventArgs)
        Call Load_TextBox_Local()
        btnSave.Text = "Cập Nhật"
    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv_DonHang.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("mame_id").Value.ToString
        Dim Code As String = dgvr.Cells("mame").Value.ToString
        Dim CodeName As String = dgvr.Cells("donhang").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mẻ Nhuộm: " & Code _
                        & vbCrLf & vbCrLf & " - Đơn Hàng: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mame_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "delete")
            _update_Ok = dtControler.UPSET_XML(_dt)
            If _update_Ok = True Then
                'ISChanged = True

                Call Filterdata_Stored_DonHang()
                '//
                Call Filterdata_Stored_MaMe()
            End If
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub
#End Region

#Region "MA MAU"
    Private Sub txtmamau_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmamau.KeyDown
        _bln_mamau = True
        If _bln_mamau = True Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                DgvData.Focus()
            End If
        End If
    End Sub

    Private Sub txtmamau_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmamau.TextChanged
        If _bln_mamau = True Then
            Dim txt As TextBox = CType(sender, TextBox)
            Dim pnPopup As Panel = PnPopup_List
            pnPopup.Controls.Add(DgvData)
            'Me.Controls.Add(pnPopup)

            AddHandler DgvData.CellClick, AddressOf DgvMaMau_CellClick
            AddHandler DgvData.KeyDown, AddressOf DgvMaMau_KeyDown

            If Len(txt.Text) > 0 Then
                VpsList_Menu(txt.Text, "[VpsXmlList_MaMau_UpSet]", "select_find", DgvData)
                '// 
                Dim ucDscreenCoords = txt.PointToScreen(New Point(0, 0))
                Dim ucDclientCoordsRelativeToA = Me.PointToClient(ucDscreenCoords)
                pnPopup.Location = New Point(ucDclientCoordsRelativeToA.X, ucDclientCoordsRelativeToA.Y + txt.Height)
                pnPopup.Size = New Size(CInt(Me.Width * 0.7), CInt(Me.Height * 0.7))
                pnPopup.Visible = True
                pnPopup.BringToFront()
                '--
            Else
                pnPopup.Visible = False
                _bln_mamau = False
                _mamau_id = String.Empty
                txtmau.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub DgvMaMau_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Call Load_Textbox_MaMau(sender)
    End Sub

    Private Sub DgvMaMau_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Load_Textbox_MaMau(sender)
        End If
    End Sub



    Private Sub Load_Textbox_MaMau(ByVal Dgv As DataGridView)
        With Dgv
            If _bln_mamau = True Then
                _bln_mamau = False
                _mamau_id = ExistsColumn_Dgv(Dgv, _colMamau_ID, "").ToString
                txtmamau.Text = ExistsColumn_Dgv(Dgv, _colMamau, "").ToString
                txtmau.Text = ExistsColumn_Dgv(Dgv, _colTenMau, "").ToString
                '//
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvMaMau_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvMaMau_KeyDown
        PnPopup_List.Visible = False
        'txtmacongnghe.Focus()
    End Sub
#End Region

End Class