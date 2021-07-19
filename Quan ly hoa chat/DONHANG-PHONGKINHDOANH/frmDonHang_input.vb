Imports System
Imports System.Collections.Generic
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text

Public Class frmDonHang_input
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
    Private _macn_id As String = String.Empty, _donhang_id As String = String.Empty
    Private _c_id As String = String.Empty
    Private _IsBusy As Boolean = False
    Dim dr2 As DataRow()
    Dim _saveRowIndex As Integer = 0
    Dim _Column_Forzen_pos As Integer = 0
    Dim _intRows_ALL As Integer = 0
    Dim _intColumns_ALL As Integer = 0, _intGroup_count As Integer = 0
    Dim _List_MameID As String() = {}
    Dim strList As List(Of String) = _List_MameID.ToList()
    '--
    Dim _List_CongDoanID As String() = {}
    Dim strCongDoanID As List(Of String) = _List_CongDoanID.ToList()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"donhang", "ghichu_thuchien_1", "mamau_khachhang", "tenmau_nhuom", "macongnghe_yeucau", "mame_ghep"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    '//
    Private DgvData As DataGridView = New DataGridView()
    Private IsChanged As Boolean = False
    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing

        If IsChanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Me.Dispose()
        '--
    End Sub

    Private Sub List_DonHang_input_Load(sender As Object, e As EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_local = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        '--
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '--
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If _donhang_status = 1 Then
            Call Clear_TextBox()
            txtdonhang.Focus()
            btnSave.Text = "Lưu Lại"
        ElseIf _donhang_status = 2 Then
            Call Load_TextBox()
            btnSave.Text = "Cập Nhật"
            Filterdata_Stored()
        End If
    End Sub


#Region "DATAGRID"
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = e.GridColumn.ColumnIndex

            ShowContextMenu(CtxMenu)
        End If
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
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
        Dim _sDonHang_ID As String = dgvr.Cells(_colDonhang_ID).Value.ToString
    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub

    Private Sub CircleProcess_Start()
        Try
            With CircularProgress1
                .Location = New Point(CInt((Super_Dgv.Width - .Width) / 2), CInt((Super_Dgv.Height - .Height) / 2))
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

    Private Sub Filterdata_Stored()
        Me.SuspendLayout()
        'Try
        Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(txtdonhang.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlDonHang_Load_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        panel.DataSource = New DataView(dt_local, "", "", DataViewRowState.CurrentRows)
        '//
        If dt_local.Rows.Count > 0 Then
            'txtkhachhang.Enabled = False
            '--
            'txtkhachhang.Text = dt_local.Rows(0).Item(_colkhachhang).ToString
        Else
            'txtkhachhang.Enabled = True

        End If
        Call CircleProcess_Stop()
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"tongsome", "socay", "sokg", "somet", "soluong"}
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
        Dim st As String = "<div align=""center"">" & "<font color=""blue"">{0}</font><br/>" & "<font color=""black"">{1}</font>" & "</div>"
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
        'panel.AddGroup(panel.Columns("mucdich"))
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        '--
        _stName = "Theo_DauKy"
        _stHeadText = "Số Lượng"
        _stCol1 = "tongsome"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        '--
        _stName = "Theo_DonGia"
        _stHeadText = "Đơn Giá"
        _stCol1 = "dongia_von"
        _stCol2 = "dongia"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("st_ngaytao"), panel.Columns("donhang"),
            panel.Columns("mamau_khach"), panel.Columns("intnhomhang")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        End If
        '//

        tpress.Enabled = True
    End Sub
    Public Function GetSortDirDescAscAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection)})
    End Function
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
    Private Sub Update_Data(ByVal st As String, ByVal _command As String)
        If Trim(txtdonhang.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập mã đơn hàng.", "Thông báo")
            txtdonhang.Focus()
            Exit Sub
        ElseIf Trim(_mahang_id) = "" Then
            MessageBox.Show("Xin vui lòng nhập tên Mã hàng.", "Thông báo")
            txtdonhang.Focus()
            Exit Sub
        ElseIf Trim(txttenmau_khach.text) = "" Then
            MessageBox.Show("Xin vui lòng nhập Tên Màu Khách.", "Thông báo")
            txtmahang.Focus()
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("nhom_hoadon='" + CNumber_system(0) + "' ")
        sbXMLString.Append("c_id='" + ReplaceTextXML(_c_id) + "' ")
        sbXMLString.Append("donhang_id='" + ReplaceTextXML(_donhang_id) + "' ")
        sbXMLString.Append("madonhang='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(txtdonhang.Text) + "' ")
        sbXMLString.Append("mahang_id='" + ReplaceTextXML(_mahang_id) + "' ")
        sbXMLString.Append("khovai='" + ReplaceTextXML(txtkhovai.Text) + "' ")
        sbXMLString.Append("metkg='" + ReplaceTextXML(txtmetkg.Text) + "' ")
        '//
        sbXMLString.Append("bennhan_khach='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mahang_khach='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("loaihang_khach='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mamau_khach='" + ReplaceTextXML(txtmamau_khach.Text) + "' ")
        sbXMLString.Append("tenmau_khach='" + ReplaceTextXML(txttenmau_khach.Text) + "' ")
        sbXMLString.Append("tongsome='" + CNumber_system(txttongsome.Text) + "' ")
        sbXMLString.Append("socay='" + CNumber_system(txtsocay.Text) + "' ")
        sbXMLString.Append("soluong='" + CNumber_system(txtsocai.Text) + "' ")
        sbXMLString.Append("sokg='" + CNumber_system(txtsokg.Text) + "' ")
        sbXMLString.Append("somet='" + CNumber_system(txtsomet.Text) + "' ")
        sbXMLString.Append("dongia_von='" + CNumber_system(txtdongia_von.Text) + "' ")
        sbXMLString.Append("dongia='" + CNumber_system(txtdongia_thuongmai.Text) + "' ")
        sbXMLString.Append("ghichu='" + ReplaceTextXML(RichTextBoxEx_ghichu.Text) + "' ")
        sbXMLString.Append("dtngaytao='" + Format$(dtngaynhap.Value, "MM/dd/yyyy") + "' ")
        sbXMLString.Append("nguoitao='" + ReplaceTextXML(strUser) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlDonHang_UpSet_2021]", sbXMLString.ToString, _command)
        dtControler.UPSET_XML(_dt)
        '//
        _update_Ok = True
        IsChanged = True
        '//
        Call Filterdata_Stored()
        '//

    End Sub

    Private Sub Load_TextBox()
        Dim panel As GridPanel = frmDonHang.Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        With dgvr
            If dgvr IsNot Nothing Then
                _donhang_id = Exists_ColDev_Value(panel, "donhang_id").ToString
                'txtmadonhang.Text = Exists_Column_SuperDgv(panel, _colmadonhang).ToString
                txtdonhang.Text = Exists_Column_SuperDgv(panel, _coldonhang).ToString
                txtkhachhang.Text = Exists_ColDev_Value(panel, _colkhachhang).ToString
                '---
                _mahang_id = Exists_ColDev_Value(panel, _colMahang_ID).ToString
                txtmahang.Text = Exists_ColDev_Value(panel, _colmahang).ToString
                txtloaihang.Text = Exists_ColDev_Value(panel, _colloaihang).ToString
                txtkhovai.Text = Exists_ColDev_Value(panel, "khovai").ToString
                txtmetkg.Text = Exists_ColDev_Value(panel, "metkg").ToString
                '//
                'txtbennhan_khach.Text = Exists_ColDev_Value(panel, "bennhan_khach").ToString
                'txtmahang_khach.Text = Exists_ColDev_Value(panel, "mahang_khach").ToString
                'txtloaihang_khach.Text = Exists_ColDev_Value(panel, "loaihang_khach").ToString
                txttongsome.Text = FormatNumber(Exists_ColDev_Value(panel, "tongsome"), 0)
                txtsocay.Text = FormatNumber(Exists_ColDev_Value(panel, _colsocay), 0)
                txtsocai.Text = FormatNumber(Exists_ColDev_Value(panel, "soluong"), 0)
                txtsokg.Text = FormatNumber(Exists_ColDev_Value(panel, _colsokg), 1)
                txtsomet.Text = FormatNumber(Exists_ColDev_Value(panel, _colsomet), 1)
                '--
                '_mamau_id = Exists_ColDev_Value(panel, _colMamau_ID).ToString
                'txtmamau_khach.Text = Exists_ColDev_Value(panel, "mamau_khach").ToString
                'txttenmau_khach.Text = Exists_ColDev_Value(panel, "tenmau_khach").ToString
                '//

                '--
                RichTextBoxEx_ghichu.Text = Exists_Column_SuperDgv(panel, _colghichu).ToString
                dtngaynhap.Value = Format$(dgvr.Cells("dtngaytao").Value, "dd/MM/yyyy")
                'dtngaygiao.Value = Convert.ToDateTime(Exists_Column_SuperDgv(panel, _coldtngaygiao))
                txtmahang.Focus()
                '//
                Call Filterdata_Stored()
            End If
        End With
    End Sub

    Private Sub Load_TextBox_Local()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        With dgvr
            If dgvr IsNot Nothing Then
                _c_id = Exists_ColDev_Value(panel, "c_id").ToString
                _donhang_id = Exists_ColDev_Value(panel, "donhang_id").ToString
                txtdonhang.Text = Exists_Column_SuperDgv(panel, _coldonhang).ToString
                txtkhachhang.Text = Exists_ColDev_Value(panel, _colkhachhang).ToString
                '---
                _mahang_id = Exists_ColDev_Value(panel, _colMahang_ID).ToString
                txtmahang.Text = Exists_ColDev_Value(panel, _colmahang).ToString
                txtloaihang.Text = Exists_ColDev_Value(panel, _colloaihang).ToString
                txtkhovai.Text = Exists_ColDev_Value(panel, "khovai").ToString
                txtmetkg.Text = Exists_ColDev_Value(panel, "metkg").ToString
                '//
                'txtbennhan_khach.Text = Exists_ColDev_Value(panel, "bennhan_khach").ToString
                'txtmahang_khach.Text = Exists_ColDev_Value(panel, "mahang_khach").ToString
                'txtloaihang_khach.Text = Exists_ColDev_Value(panel, "loaihang_khach").ToString
                '//
                txttongsome.Text = FormatNumber(Exists_ColDev_Value(panel, "tongsome"), 0)
                txtsocay.Text = FormatNumber(Exists_ColDev_Value(panel, _colsocay), 0)
                txtsocai.Text = FormatNumber(Exists_ColDev_Value(panel, "soluong"), 0)
                txtsokg.Text = FormatNumber(Exists_ColDev_Value(panel, _colsokg), 1)
                txtsomet.Text = FormatNumber(Exists_ColDev_Value(panel, _colsomet), 1)
                '--
                '_mamau_id = Exists_ColDev_Value(panel, _colMamau_ID).ToString
                txtmamau_khach.Text = Exists_ColDev_Value(panel, "mamau_khach").ToString
                txttenmau_khach.Text = Exists_ColDev_Value(panel, "tenmau_khach").ToString
                '//
                '_macn_id = Exists_ColDev_Value(panel, "macn_id").ToString
                'txtmacongnghe.Text = Exists_ColDev_Value(panel, "macongnghe").ToString
                'RichTextBox1.Text = Exists_ColDev_Value(panel, "macongdoan_all").ToString
                '--
                RichTextBoxEx_ghichu.Text = Exists_Column_SuperDgv(panel, _colghichu).ToString
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
        btnSave.Enabled = False
        _bln_mamau = False
        _bln_mahang = False
        '//
        '//
        Dim TestComp As Integer = StrComp(btnSave.Text, "Lưu Lại", CompareMethod.Binary)
        If TestComp = 0 Then
            Call MdlData.Load_TimeServer()
            _c_id = "D" & _TimeServer.Ticks.ToString
            Call Update_Data("", "insert")
            If _update_Ok = True Then

                Call Clear_TextBox()
            End If
        Else
            If MsgBox("Bạn có muốn sửa nội dung không ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update")
            End If
        End If
        '//
        btnSave.Enabled = True
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

#Region "EXECUTE"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call Clear_TextBox()
        txtmamau_khach.Focus()
        btnSave.Text = "Lưu Lại"
        '//
    End Sub

    Private Sub ToolStripButton_DungLai_Click(sender As Object, e As EventArgs) Handles ToolStripButton_DungLai.Click
        Call Load_TextBox_Local()
        btnSave.Text = "Lưu Lại"
    End Sub
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Call Load_TextBox_Local()
        btnSave.Text = "Cập Nhật"
    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("c_id").Value.ToString
        Dim Code As String = dgvr.Cells("mahang").Value.ToString
        Dim CodeName As String = dgvr.Cells("donhang").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Hàng: " & Code _
                        & vbCrLf & vbCrLf & " - Đơn Hàng: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("c_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[VpsXmlDonHang_UpSet_2021]", sbXMLString.ToString, "delete")
            _update_Ok = dtControler.UPSET_XML(_dt)
            If _update_Ok = True Then
                IsChanged = True
                '//
                Call Filterdata_Stored()
            End If
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub
#End Region

#Region "TIM KIEM THONG TIN"
#Region "DON HANG"
    Private Sub txtdonhang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdonhang.KeyDown
        _bln_mamau = False
        _bln_mahang = False
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
                    Dim ucDclientCoordsRelativeToA = Me.PointToClient(ucDscreenCoords)
                    pnPopup.Location = New Point(ucDclientCoordsRelativeToA.X, ucDclientCoordsRelativeToA.Y + txt.Height)
                    pnPopup.Size = New Size(CInt(Me.Width * 0.7), CInt(Me.Height * 0.7))
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
                RichTextBoxEx_ghichu.Text = ExistsColumn_Dgv(Dgv, "canhbao_donhang", "").ToString
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvDonHang_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvDonHang_KeyDown
        PnPopup_List.Visible = False
        txtmahang.Focus()
        '//
        Filterdata_Stored()

    End Sub
#End Region

#Region "MA HANG"
    Private Sub txtmahang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmahang.KeyDown
        _bln_mamau = False
        _bln_donhang = False
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
            DgvData.AllowUserToAddRows = False
            'Me.Controls.Add(pnPopup)

            AddHandler DgvData.CellClick, AddressOf DgvMaHang_CellClick
            AddHandler DgvData.KeyDown, AddressOf DgvMaHang_KeyDown

            If Len(txt.Text) > 0 Then
                'ClsDatagridView.VpsListMaHang(txt.Text, "", DgvData)
                VpsList_Menu(txt.Text, "[VpsXmlList_MaHang_UpSet]", "select", DgvData)
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
                '//
                txtkhovai.Text = ExistsColumn_Dgv(Dgv, "khovai", "").ToString
                txtmetkg.Text = ExistsColumn_Dgv(Dgv, "metkg", "").ToString
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvMaHang_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvMaHang_KeyDown
        PnPopup_List.Visible = False
        txtkhovai.Focus()
        '//
        Filterdata_Stored()
    End Sub
#End Region

#Region "MA MAU"
    Private Sub txtmamau_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmamau_khach.KeyDown
        _bln_donhang = False
        _bln_mahang = False
        _bln_mamau = True
        If _bln_mamau = True Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                DgvData.Focus()
            End If
        End If
    End Sub

    Private Sub txtmamau_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmamau_khach.TextChanged
        If _bln_mamau = True Then
            Dim txt As TextBox = CType(sender, TextBox)
            Dim pnPopup As Panel = PnPopup_List
            pnPopup.Controls.Add(DgvData)
            'Me.Controls.Add(pnPopup)
            DgvData.AllowUserToAddRows = False
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
                If DgvData.Rows.Count = 0 Then
                    pnPopup.Visible = False

                Else
                    pnPopup.Visible = True
                End If
                '--
            Else
                pnPopup.Visible = False
                _bln_mamau = False
                _mamau_id = String.Empty
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
                txtmamau_khach.Text = ExistsColumn_Dgv(Dgv, _colMamau, "").ToString
                txttenmau_khach.Text = ExistsColumn_Dgv(Dgv, _colTenMau, "").ToString
                '//
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvMaMau_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvMaMau_KeyDown
        PnPopup_List.Visible = False
        txttongsome.Focus()
    End Sub
#End Region

#End Region

#Region "THEM NHANH LOAI HANG"
    Private Sub BtnThemMoi_MaHang_Click(sender As Object, e As EventArgs) Handles BtnThemMoi_MaHang.Click
        _Loaivai_status = 1
        ShowModalForm_MaHang()
    End Sub
    Private Sub ShowModalForm_MaHang()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_MaHang))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With List_mahang_input
                '.Size = New Size(Me.Width, Me.Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                '.Text = "XÁC NHẬN THỰC HIỆN"
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    'Call Filterdata_Stored()
                    txtmahang.Focus()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub
#End Region
#Region "THEM NHANH DON HANG"
    Private Sub BtnThemMoi_DonHang_Click(sender As Object, e As EventArgs) Handles BtnThemMoi_DonHang.Click
        _donhang_main_status = 1
        ShowModalForm_DonHang()
    End Sub
    Private Sub ShowModalForm_DonHang()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_DonHang))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmDonHang_kinhDoanh_input
                '.Size = New Size(Me.Width, Me.Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                '.Text = "XÁC NHẬN THỰC HIỆN"
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    'Call Filterdata_Stored()
                    txtdongia_thuongmai.Focus()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub
#End Region

    Private Sub ToolStripButton_Refresh_Click(sender As Object, e As EventArgs) Handles ToolStripButton_Refresh.Click
        Call Filterdata_Stored()
    End Sub
End Class