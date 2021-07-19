
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports DevComponents.AdvTree
Public Class frmNhatKySanXuat_Update_CongDoan
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim dt_congdoan As DataTable
    Dim dt_may As DataTable
    Dim dt_kieuxuat As DataTable

    Dim _Load_Ok As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Dim _bln_mamau As Boolean = False, _bln_donhang As Boolean = False
    Private _bln_macongnghe As Boolean = False
    Private _bln_mamau_1 As Boolean = False
    '--
    Dim ProgramPosition, cursorPoint As Point

    Dim _List_MameID As String() = {}
    Dim strList As List(Of String) = _List_MameID.ToList()
    '--
    Dim _List_CongDoanID As String() = {}
    Dim strCongDoanID As List(Of String) = _List_CongDoanID.ToList()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    '//
    Dim _List_Cells As String() = {}
    Dim strCells As List(Of String) = _List_Cells.ToList()
    '//
    Private _List_Column_Locked As String() = {"thutu_sanxuat_uutien", "thoigian_cho", "thoigian_toithieu", "ghichu", "phanloai_ngaydem"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    '--
    Dim _kieuxuat_id As String, _stMakytu_xuat As String
    Dim dr2 As DataRow()
    Dim _chungtuxuat_id As String
    Dim _load_finish As Boolean = False

    Private _congdoan_id As String = String.Empty
    Private Lmame As String = String.Empty
    Private Lmamau_id As String = String.Empty
    Private _Update_MaCongDoan_In As Boolean = False
    '//
    Private DgvData As DataGridView = New DataGridView()
    Private result As New List(Of String())
    '--
    Private _IsBusy As Boolean = False

    Private SoDongChon As Integer = 0
    Private _donhang As String = String.Empty
    Private _MaCongNghe As String = String.Empty
    Private _MaMay As String = String.Empty
    Dim _dtGiovao As DateTime
    Dim _dtGiora As DateTime
    '//
    Private IsFirstRow As Boolean = False
    '//
    Dim _List_Mame As String() = {}
    Dim strMame As List(Of String) = _List_Mame.ToList()

    Dim orderArray_CongDoan_ALL() As String = {}
    Dim orderArray_DaThucHien() As String = {}
    Private IsDrag As Boolean = False
    Private IsChangedValued As Boolean = False
    '//
    Dim _isPaste_G As Boolean = False
    Private _columnName As String = String.Empty
    Dim _ColorPick As String = String.Empty
    Private Lmamay_id As String = String.Empty
    Dim _mame_temp As String = String.Empty
    Private _MaID As String = String.Empty
    Private LTongcay_congdoan As Int16 = 0
    Private LTongKg_congdoan As Int16 = 0
    Private LTongMet_congdoan As Int16 = 0
    '//
#Region "Private variables"

    Private _SrcGrid As SuperGridControl
    Private _SrcElement As GridElement

    Private _DragOverRow As GridRow
    Private _DragOverCell As GridCell
    Private _DragOverColumn As GridColumn

    Private _MouseDownPoint As Point

#End Region
    Public Property DonHang() As String
        Get
            Return _donhang
        End Get
        Set(ByVal value As String)
            _donhang = value
        End Set
    End Property
    Public Property MaCongNghe() As String
        Get
            Return _MaCongNghe
        End Get
        Set(ByVal value As String)
            _MaCongNghe = value
        End Set
    End Property
    Public Property MaMay() As String
        Get
            Return _MaMay
        End Get
        Set(ByVal value As String)
            _MaMay = value
        End Set
    End Property
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

    Private Sub me_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect

        '//
        With dtNgayxuat_chungtu
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy HH:mm"
        End With
        Me.dtNgayxuat_chungtu.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))
        '--
        With dtngay_casanxuat
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        '//
        Me.dtngay_casanxuat.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))
        '//
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '//
        dt_local = New DataTable
        dt_congdoan = New DataTable
        dt_may = New DataTable
        dt_kieuxuat = New DataTable
        With Super_Dgv
            .AllowDrop = True
            .PrimaryGrid.KeepRowsSorted = False
            .PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.SortAndReorder
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = Tbool.True
            .PrimaryGrid.GroupHeaderClickBehavior = GroupHeaderClickBehavior.ExpandCollapse
        End With
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged

        AddHandler tpress.Tick, AddressOf MyTickHandler
        '//
        Load_CongDoan_Nhom()
        '//
        Load_MayNhuom()
    End Sub

#Region "FragrantComboBox"
    Private Sub Load_CongDoan_Nhom()
        dt_congdoan = VpsXmlList_Load("", "", "macongdoan")
    End Sub
    Private Sub Load_MayNhuom()
        dt_may = VpsXmlList_Load("", "", "danhsachmay")
    End Sub
    Friend Class FragrantComboBox
        Inherits GridComboBoxExEditControl
        Public Sub New(ByVal orderArray As IEnumerable)
            DataSource = orderArray
        End Sub
    End Class

#End Region
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

#Region "SUPERGRID"
    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        If IsChangedValued = False Then
            clsDev.SuperDgv_CellValueChanged(sender, e)
            '//
            If e.GridPanel.ActiveRow Is Nothing Then Exit Sub
            Dim dgvr As GridRow = CType(e.GridPanel.ActiveRow, GridRow)
            If dgvr.IsDetailRow = False Then
                If e.GridCell.GridColumn.Name.ToLower = "thoigian_cho" Then
                    tpress.Enabled = True
                ElseIf e.GridCell.GridColumn.Name.ToLower = "thutu_sanxuat_uutien" Then
                    BtnLuuTam_ViTri_Click(Nothing, Nothing)
                    '///
                    tpress.Enabled = True
                ElseIf e.GridCell.GridColumn.Name.ToLower = "thoigianvao_dukien" Then
                    Timer_NgayDuTinh.Enabled = True
                End If
            End If
        End If

    End Sub
    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Super_Dgv.KeyDown
        clsDev.Super_Dgv_KeyDown(sender, e)
    End Sub
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = CByte(e.GridColumn.ColumnIndex)
            If e.GridColumn.ColumnIndex = 0 Then
                ShowContextMenu(CtxMnuSelect)
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
                    dgvr.IsSelected = True
                Else
                    dgvr.IsSelected = False
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
                If dgvr IsNot Nothing Then
                    '//
                    txtnhommay_id.Text = dgvr.Cells("nhommay_id").Value.ToString
                    txtcongdoan_chonmay.Text = dgvr.Cells("macongdoan").Value.ToString
                    txtcongdoan_HuyLenh.Text = dgvr.Cells("macongdoan").Value.ToString
                    If IsDBNull(dgvr.Cells("thoigianra").Value) = False Then
                        BtnHuy_GioRa.Enabled = True
                        BtnHuy_GioVao.Enabled = False
                    Else
                        If IsDBNull(dgvr.Cells("thoigianvao").Value) = False Then
                            BtnHuy_GioVao.Enabled = True
                            BtnHuy_GioRa.Enabled = False
                        Else
                            BtnHuy_GioVao.Enabled = False
                            BtnHuy_GioRa.Enabled = False
                        End If
                    End If
                Else
                    Lmame = String.Empty
                End If


            ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
                panel.AllowEdit = False
                panel.ReadOnly = True
            End If

        End If
        _saveRowIndex = e.GridCell.RowIndex
        _columnName = panel.ActiveCell.GridColumn.Name
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

    Private Sub mnu_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Select_All.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, True)
    End Sub

    Private Sub mnu_Remove_ALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Remove_ALL.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, False)
    End Sub

    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_ColumnFrozen.Click

    End Sub
#End Region

#Region "LOAD DATA"
    Private Sub btTim_Click(sender As Object, e As EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub

    Public Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mamay='" + ReplaceTextXML(_MaMay) + "' ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(_donhang) + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang_F.Text) + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML(txtloaihang_F.Text) + "' ")
        sbXMLString.Append("mamau='" + ReplaceTextXML(txtmamau_F.Text) + "' ")
        sbXMLString.Append("tenmau='" + ReplaceTextXML(txtmau_F.Text) + "' ")
        sbXMLString.Append("mame_ghep='" + ReplaceTextXML(txtmame_ghep_F.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_Congdoan_KeHoachDuTinh_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        '//Lấy Data Dòng Đầu Tiên
        Dim LIsFirst As Boolean = False
        If dt_local.Rows.Count > 0 Then
            If IsDBNull(dt_local.Rows(0).Item("dtngaylap_kehoach")) = False Then
                dtNgayxuat_chungtu.Value = dt_local.Rows(0).Item("dtngaylap_kehoach")
            Else
                Call Load_TimeServer()
                dtNgayxuat_chungtu.Value = _TimeServer
            End If
        Else
            Call Load_TimeServer()
            dtNgayxuat_chungtu.Value = _TimeServer
        End If

        '//
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socaytt", "sokgtt", "somettt"}
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
        '//
        Call Load_TimeServer()
        '//
        IsFirstRow = False
        IsChangedValued = True
        '//
        Call UpdateShowALLRows(panel.Rows)
        '//
        IsChangedValued = False
        'lblRow.Text = "Tổng số: " & n
        Dim st As String = "<div align=""center"">" & "<font color=""red"">{0}</font><br/>" & "<font color=""green"">{1}</font>" & "</div>"
        'For x As Integer = 0 To _array_column.Length - 1
        'If columns.Contains(_array_column(x)) = True Then
        'With panel.Columns(_array_column(x))
        '.EnableHeaderMarkup = True
        'Dim stHeaderText As String = clsDev.Show_1Column(_array_column(x))
        'Dim stValue As Decimal = _array_value(x)
        '.HeaderText = String.Format(st, stHeaderText, FormatNumber(stValue, _intFormatText))
        'End With
        'End If
        'Next
    End Sub

    Private Sub UpdateShowALLRows(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        Dim _chon_mau As String = String.Empty
        Dim _congdoan_hientai As String = String.Empty
        Dim _congdoan_ketiep As String = String.Empty
        Dim _congdoan_all As String = String.Empty
        Dim _congdoan_Dathuchien As String = String.Empty
        Dim _isSame As Int16 = 0
        Dim _isSame_lenh As Int16 = 0
        Dim _colorhtml As String = String.Empty
        _mame_temp = String.Empty
        '_colorhtml = "#D3D3D3"
        '////
        For Each item As GridElement In rows
            If _blnPress = False Then Exit For
            If item.Visible = True Then

                Dim group As GridGroup = TryCast(item, GridGroup)
                If group IsNot Nothing Then
                    UpdateShowALLRows(group.Rows)
                Else
                    Dim row As GridRow = TryCast(item, GridRow)
                    Dim _Thoigian_toithieu As Integer = 0
                    Dim _Thoigian_delay As Integer = 0
                    If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                        Dim PreRow As GridRow = CType(row.PrevVisibleRow, GridRow)
                        Dim nextrow As GridRow = CType(row.NextVisibleRow, GridRow)
                        '//Mẻ
                        If row.Cells("mame_ghep").Value.ToString = _mame_temp Then
                            row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                            row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                        Else
                            _mame_temp = row.Cells("mame_ghep").Value.ToString
                            If _isSame = 0 Then
                                _colorhtml = "#FFFFFF"
                                row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                            ElseIf _isSame = 1 Then
                                _colorhtml = "#D3D3D3"
                                row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                'ElseIf _isSame = 2 Then
                                '_colorhtml = "#FAF0E6"
                                'row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                'row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                            Else
                                _colorhtml = "#FFFFFF"
                                row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                _isSame = 0
                            End If
                            _isSame += 1
                        End If


                        If PreRow IsNot Nothing Then
                            If IsDBNull(row.Cells("thoigianvao_dukien").Value) = False AndAlso IsDBNull(row.Cells("thoigianra_dukien").Value) = False Then
                                Dim _giovao_dukien As DateTime = CDate(row.Cells("thoigianvao_dukien").Value)
                                Dim _giora_dukien As DateTime = CDate(row.Cells("thoigianra_dukien").Value)
                                If _giovao_dukien.Day <> _giora_dukien.Day Then
                                    row.Cells("thoigianvao_dukien").CellStyles.Default.Background.Color1 = Color.Red
                                    row.Cells("thoigian_toithieu").CellStyles.Default.Background.Color1 = Color.Red
                                    row.Cells("thoigianra_dukien").CellStyles.Default.Background.Color1 = Color.Red
                                End If
                            End If

                            '//Mẻ
                            If row.Cells("phanloai_ngaydem").Value = PreRow.Cells("phanloai_ngaydem").Value Then
                                row.Cells("phanloai_ngaydem").CellStyles.Default.Background.Color1 = PreRow.Cells("phanloai_ngaydem").CellStyles.Default.Background.Color1
                                row.Cells("dtngaylap_kehoach").CellStyles.Default.Background.Color1 = PreRow.Cells("dtngaylap_kehoach").CellStyles.Default.Background.Color1
                                _isSame_lenh += 1
                            Else
                                If _isSame_lenh = 0 Then
                                    row.Cells("phanloai_ngaydem").CellStyles.Default.Background.Color1 = GetNewColor(Color.GhostWhite)
                                    row.Cells("dtngaylap_kehoach").CellStyles.Default.Background.Color1 = GetNewColor(Color.GhostWhite)
                                ElseIf _isSame_lenh = 1 Then
                                    row.Cells("phanloai_ngaydem").CellStyles.Default.Background.Color1 = GetNewColor(Color.LightGray)
                                    row.Cells("phanloai_ngaydem").CellStyles.Default.Background.Color1 = GetNewColor(Color.GhostWhite)
                                Else
                                    _isSame_lenh = 0
                                End If

                            End If
                        End If


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
        '//
        'columns("thutu_sanxuat_uutien").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml("#FFFF00")
        columns("thoigian_cho").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml("#FFFF00")
        columns("ghichu").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml("#FFFF00")
        'columns("thoigian_cho").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml("#FFFF00")
        '//
        panel.Caption.Text = "THIẾT BỊ:" & _MaMay.ToUpper
        panel.Caption.Visible = True
        '--g
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        _stName = "Theo_DuTinh_GioVao"
        _stHeadText = "Dự Tính Sản Xuất"
        _stCol1 = "thoigianvao_dukien"
        _stCol2 = "thoigian_cho"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_SoLuong"
        _stHeadText = "Số Lượng"
        _stCol1 = "socaytt"
        _stCol2 = "somettt"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If

        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("macongdoan"), panel.Columns("mamau"),
            panel.Columns("mame_ghep"), panel.Columns("intnhomhang")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscAscAscDesc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscAscAscDesc(sortCols))
        End If
        '//
        tpress.Enabled = True
    End Sub
    Public Function GetSortDirAscAscAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection)})
    End Function


#End Region

#Region "LUU THAY DOI"
    Private Sub BtnLuuThayDoi_Click(sender As Object, e As EventArgs) Handles BtnLuuThayDoi.Click
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_update_DatMau(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_congdoan_UpSet]", sbXMLString.ToString, "update_luuthaydoi")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
        End If

    End Sub
    Private Sub UpdateDetails_update_DatMau(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim _mamay_id As String = String.Empty
        Dim _congdoan_id As String = String.Empty
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_DatMau(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame").Value.ToString) + "' ")
                    sbXMLString.Append("phanloai_ngaydem='" + ReplaceTextXML(row.Cells("phanloai_ngaydem").Value.ToString) + "' ")
                    sbXMLString.Append("ghichu='" + ReplaceTextXML(row.Cells("ghichu").Value.ToString) + "' ")
                    sbXMLString.Append("thoigian='" + CNumber_system(row.Cells("thoigian_toithieu").Value) + "' ")
                    sbXMLString.Append("thoigian_cho='" + CNumber_system(row.Cells("thoigian_cho").Value) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

#End Region

#Region "SuperGrid support"

#Region "SuperGridControlItemDrag"

    ''' <summary>
    ''' Handles the initiation of SuperGrid
    ''' Drag and Drop operations.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Super_Dgv_ItemDrag(ByVal sender As Object, ByVal e As GridItemDragEventArgs) 'Handles Super_Dgv.ItemDrag
        Dim sg As SuperGridControl = TryCast(sender, SuperGridControl)

        If sg IsNot Nothing Then
            IsDrag = True
            ' Get the collection of selected items

            Dim items As SelectedElementCollection = Nothing

            If TypeOf e.Item Is GridCell Then
                'items = sg.PrimaryGrid.GetSelectedCells()
                items = sg.PrimaryGrid.GetSelectedRows()

            ElseIf TypeOf e.Item Is GridRow Then
                items = sg.PrimaryGrid.GetSelectedRows()

            ElseIf TypeOf e.Item Is GridColumn Then
                'items = sg.PrimaryGrid.GetSelectedColumns()
            End If

            ' If the user has selected items, then make the
            ' data accessible, and start the drag operation.

            If items IsNot Nothing AndAlso items.Count > 0 Then
                _SrcGrid = sg
                _SrcElement = TryCast(e.Item, GridElement)

                Dim dob As New DataObject(items)

                'If TypeOf e.Item Is GridRow Then
                Dim nodes(items.Count - 1) As Node

                For i As Integer = 0 To items.Count - 1
                    Dim row As GridRow = CType(items(i), GridRow)

                    Dim node As New Node()
                    node.Cells.Clear()

                    For Each cell As GridCell In row.Cells
                        Dim acell As New Cell(cell.Value.ToString())

                        node.Cells.Add(acell)
                    Next cell

                    nodes(i) = node
                Next i

                dob.SetData(nodes)
                'End If

                ' Initiate the drag operation

                sg.DoDragDrop(dob, DragDropEffects.Copy Or DragDropEffects.Move)

                _SrcGrid = Nothing
                _SrcElement = Nothing
            End If

            ClearDragHighlight()
            IsDrag = False
        End If
    End Sub


#End Region

#Region "SuperGridControlDragOver"

    ''' <summary>
    ''' Handles SuperGrid DragOver events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Super_Dgv_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) 'Handles Super_Dgv.DragOver
        Dim sg As SuperGridControl = TryCast(sender, SuperGridControl)

        If sg IsNot Nothing Then
            ClearDragHighlight()

            e.Effect = DragDropEffects.None

            Dim clientPoint As Point = sg.PointToClient(New Point(e.X, e.Y))
            Dim item As GridElement = sg.GetElementAt(clientPoint.X, clientPoint.Y)

            If TypeOf item Is GridCell Then
                If TypeOf _SrcElement Is GridRow Then
                    item = CType(item, GridCell).GridRow
                ElseIf _SrcElement Is Nothing OrElse TypeOf _SrcElement Is GridCell Then
                    _DragOverCell = CType(item, GridCell)
                    '_DragOverCell.CellStyles.Default.Background = New Background(Color.AliceBlue)

                    e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
                End If
            End If

            If TypeOf item Is GridRow Then
                If _SrcElement Is Nothing OrElse TypeOf _SrcElement Is GridRow Then
                    _DragOverRow = CType(item, GridRow)
                    '_DragOverRow.CellStyles.Default.Background = New Background(Color.AliceBlue)

                    e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
                End If
            ElseIf TypeOf item Is GridColumnHeader Then
                If TypeOf _SrcElement Is GridColumn Then
                    Dim doColumn As GridColumn = CType(item, GridColumnHeader).GetHitColumn(clientPoint)

                    If CType(_SrcElement, GridColumn).EditorType.Equals(doColumn.EditorType) Then
                        _DragOverColumn = doColumn
                        '_DragOverColumn.CellStyles.Default.Background = New Background(Color.AliceBlue)

                        e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
                    End If
                ElseIf _SrcElement Is Nothing OrElse TypeOf _SrcElement Is GridRow Then
                    e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
                End If
            End If

            If sg IsNot _SrcGrid Then
                e.Effect = e.Effect And Not (DragDropEffects.Move)
            Else
                If (e.KeyState And 8) <> 8 Then
                    e.Effect = e.Effect And Not (DragDropEffects.Copy)
                End If
            End If
        End If
    End Sub

#End Region

#Region "SuperGridControlDragDrop"

    ''' <summary>
    ''' Handles SuperGrid DragDrop events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Super_Dgvl_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) 'Handles Super_Dgv.DragDrop
        Dim sg As SuperGridControl = TryCast(sender, SuperGridControl)

        If sg IsNot Nothing Then
            ClearStyles(sg)

            Dim pt As Point = sg.PointToClient(New Point(e.X, e.Y))
            Dim item As GridElement = sg.GetElementAt(pt.X, pt.Y)

            ' If the data we are dropping is from a SuperGrid, then
            ' be a little bit more discerning about how we drop it

            If _SrcGrid IsNot Nothing Then
                Dim items As SelectedElementCollection = CType(e.Data.GetData(GetType(SelectedElementCollection)), SelectedElementCollection)

                If TypeOf item Is GridCell Then
                    If TypeOf _SrcElement Is GridRow Then
                        DropSgRow(e, CType(item, GridCell).GridRow, items)
                    Else
                        DropSgCell(CType(item, GridCell), items)
                    End If
                ElseIf TypeOf item Is GridRow Then
                    DropSgRow(e, CType(item, GridRow), items)

                ElseIf TypeOf item Is GridColumnHeader Then
                    DropSgColumnHeader(CType(item, GridColumnHeader), items, pt)

                ElseIf TypeOf item Is GridPanel Then
                    DropSgPanel(CType(item, GridPanel), items)
                End If
            Else
                If TypeOf item Is GridCell Then
                    If TypeOf _SrcElement Is GridRow Then
                        DropRow(e, CType(item, GridCell).GridRow)
                    Else
                        DropCell(e, CType(item, GridCell))
                    End If
                ElseIf TypeOf item Is GridRow Then
                    DropRow(e, CType(item, GridRow))

                ElseIf TypeOf item Is GridColumnHeader Then
                    DropColumnHeader(e, CType(item, GridColumnHeader), pt)
                End If
            End If

            ClearDragHighlight()
        End If
    End Sub

#Region "ClearStyles"

    Private Sub ClearStyles(ByVal sgrid As SuperGridControl)
        Dim panel As GridPanel = sgrid.PrimaryGrid

        For Each row As GridRow In panel.Rows
            For Each cell As GridCell In row.Cells
                cell.CellStyles.Default = Nothing
            Next cell
        Next row
    End Sub

#End Region

#End Region

#Region "SG_DragDrop"

#Region "DropSgCell"

    ''' <summary>
    ''' Handles Dropping data on a GridCell
    ''' </summary>
    ''' <param name="cell"></param>
    ''' <param name="cells"></param>
    Private Sub DropSgCell(ByVal cell As GridCell, ByVal cells As IEnumerable(Of GridElement))
        Dim sb As New StringBuilder()

        For Each droppedCell As GridCell In cells
            If droppedCell.Value IsNot Nothing Then
                sb.Append(droppedCell.Value.ToString())
                sb.Append(", ")
            End If
        Next droppedCell

        If sb.Length > 0 Then
            sb.Length -= 2
        End If

        cell.Value = sb.ToString()
        cell.CellStyles.Default.TextColor = Color.Red
    End Sub

#End Region

#Region "DropSgRow"

    ''' <summary>
    ''' Handles dropping row data on a SuperGrid
    ''' </summary>
    ''' <param name="e"></param>
    ''' <param name="row"></param>
    ''' <param name="rows"></param>
    Private Sub DropSgRow(ByVal e As DragEventArgs, ByVal row As GridRow, ByVal rows As IEnumerable(Of GridElement))
        If e.Effect = DragDropEffects.Move Then
            If row.IsSelected = False Then
                MoveSgRows(row, rows)
            End If
        Else
            CopySgRows(row, rows)
        End If
    End Sub

#End Region

#Region "CopySgRows"

    ''' <summary>
    ''' Handles copying GridRow data into a SuperGrid
    ''' </summary>
    ''' <param name="row"></param>
    ''' <param name="rows"></param>
    Private Sub CopySgRows(ByVal row As GridRow, ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = row.GridPanel

        For Each item As GridRow In rows
            If row Is Nothing Then
                row = New GridRow()
                panel.Rows.Add(row)
            End If

            Dim n As Integer = Math.Min(item.Cells.Count, panel.Columns.Count)

            For i As Integer = 0 To n - 1
                Dim cell As GridCell = item.Cells(i)

                Dim value As String = cell.Value.ToString()

                If i >= row.Cells.Count Then
                    row.Cells.Add(New GridCell(value))
                Else
                    If cell.Value IsNot Nothing Then
                        row.Cells(i).Value = value
                        row.Cells(i).CellStyles.Default.TextColor = Color.Red
                    End If
                End If
            Next i

            row = TryCast(row.NextVisibleRow, GridRow)
        Next item
    End Sub

#End Region

#Region "MoveSgRows"

    ''' <summary>
    ''' Handles moving GridRows within the same SuperGrid
    ''' </summary>
    ''' <param name="row"></param>
    ''' <param name="rows"></param>
    Private Sub MoveSgRows(ByVal row As GridRow, ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = row.GridPanel
        Super_Dgv.PrimaryGrid.ClearSort()
        Dim n As Integer = row.RowIndex

        For Each item As GridRow In rows
            panel.Rows.Remove(item)
        Next item

        For Each item As GridRow In rows
            panel.Rows.Insert(n, item)

            For Each cell As GridCell In item.Cells
                cell.CellStyles.Default.TextColor = Color.Red
            Next cell
        Next item
    End Sub

#End Region

#Region "DropSgColumnHeader"

    ''' <summary>
    ''' Handles dropping data onto a ColumnHeader
    ''' </summary>
    ''' <param name="item"></param>
    ''' <param name="items"></param>
    ''' <param name="pt"></param>
    Private Sub DropSgColumnHeader(ByVal item As GridColumnHeader, ByVal items As IEnumerable(Of GridElement), ByVal pt As Point)
        Dim column As GridColumn = item.GetHitColumn(pt)

        If column IsNot Nothing Then
            If TypeOf _SrcElement Is GridColumn Then
                DropSgColumns(column, items)
            Else
                DropSgPanel(item.GridPanel, items)
            End If
        End If
    End Sub

#Region "DropSgColumns"

    ''' <summary>
    ''' Handles dropping data onto a ColumnHeader
    ''' </summary>
    Private Sub DropSgColumns(ByVal column As GridColumn, ByVal cols As IEnumerable(Of GridElement))
        Dim panel1 As GridPanel = _SrcGrid.PrimaryGrid
        Dim panel2 As GridPanel = column.GridPanel

        If panel1.Rows.Count > panel2.Rows.Count Then
            For i As Integer = panel2.Rows.Count To panel1.Rows.Count - 1
                panel2.Rows.Add(New GridRow("", "", ""))
            Next i
        End If

        For Each item As GridColumn In cols
            If column Is Nothing OrElse column.EditorType.Equals(item.EditorType) = False Then
                Exit For
            End If

            Dim index1 As Integer = item.ColumnIndex
            Dim index2 As Integer = column.ColumnIndex

            For i As Integer = 0 To panel1.Rows.Count - 1
                Dim row1 As GridRow = CType(panel1.Rows(i), GridRow)
                Dim row2 As GridRow = CType(panel2.Rows(i), GridRow)

                Dim cell As GridCell = row1.Cells(index1)

                Dim value As Object = cell.Value

                If index2 >= row2.Cells.Count Then
                    For j As Integer = row2.Cells.Count To index2 - 1
                        cell = New GridCell("")
                        cell.CellStyles.Default.TextColor = Color.Red

                        row2.Cells.Add(cell)
                    Next j

                    row2.Cells.Add(New GridCell())
                End If

                row2.Cells(index2).Value = value
                row2.Cells(index2).CellStyles.Default.TextColor = Color.Red
            Next i

            column = column.NextVisibleColumn
        Next item
    End Sub

#End Region

#End Region

#Region "DropSgPanel"

    ''' <summary>
    ''' Handles dropping data on a GridPanel
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="rows"></param>
    Private Sub DropSgPanel(ByVal panel As GridPanel, ByVal rows As IEnumerable(Of GridElement))
        Dim lastRow As GridRow = Nothing

        For Each item As GridRow In rows
            Dim row As New GridRow()

            For i As Integer = 0 To item.Cells.Count - 1
                Dim cell As GridCell = item.Cells(i)

                cell = New GridCell(cell.Value)
                cell.CellStyles.Default.TextColor = Color.Red

                row.Cells.Add(cell)
            Next i

            panel.Rows.Add(row)

            lastRow = row
        Next item

        If lastRow IsNot Nothing Then
            lastRow.EnsureVisible()
        End If
    End Sub

#End Region

#End Region

#Region "NSG_DragDrop"

#Region "DropCell"

    ''' <summary>
    ''' Handles dropping non-grid data on a grid cell
    ''' </summary>
    ''' <param name="e"></param>
    ''' <param name="cell"></param>
    Private Sub DropCell(ByVal e As DragEventArgs, ByVal cell As GridCell)
        Dim sb As New StringBuilder()

        If e.Data.GetDataPresent(GetType(String)) = True Then
            Dim s As String = CStr(e.Data.GetData(GetType(String)))

            sb.Append(s)
        ElseIf e.Data.GetDataPresent(GetType(TreeNode)) = True Then
            Dim tnode As TreeNode = CType(e.Data.GetData(GetType(TreeNode)), TreeNode)

            sb.Append(tnode.Text)
        ElseIf e.Data.GetDataPresent(GetType(Node)) = True Then
            Dim node As Node = CType(e.Data.GetData(GetType(Node)), Node)

            For Each droppedCell As Cell In node.Cells
                sb.Append(droppedCell.Text)
                sb.Append(", ")
            Next droppedCell

            If sb.Length > 0 Then
                sb.Length -= 2
            End If
        ElseIf e.Data.GetDataPresent(GetType(Node())) = True Then
            Dim nodes() As Node = CType(e.Data.GetData(GetType(Node())), Node())

            For Each node As Node In nodes
                For Each droppedCell As Cell In node.Cells
                    sb.Append(droppedCell.Text)
                    sb.Append(", ")
                Next droppedCell

                If sb.Length > 0 Then
                    sb.Length -= 2
                End If
            Next node
        End If

        cell.Value = sb.ToString()
        cell.CellStyles.Default.TextColor = Color.Red
    End Sub

#End Region

#Region "DropRow"

    ''' <summary>
    ''' Handles dropping non-grid data on a grid row
    ''' </summary>
    ''' <param name="e"></param>
    ''' <param name="row"></param>
    Private Sub DropRow(ByVal e As DragEventArgs, ByVal row As GridRow)
        Dim panel As GridPanel = row.GridPanel

        If e.Data.GetDataPresent(GetType(String)) = True Then
            Dim s As String = CStr(e.Data.GetData(GetType(String)))

            DropTextRow(row, s.Split(","c))
        ElseIf e.Data.GetDataPresent(GetType(TreeNode)) = True Then
            Dim tnode As TreeNode = CType(e.Data.GetData(GetType(TreeNode)), TreeNode)

            DropTextRow(row, tnode.Text.Split(","c))
        ElseIf e.Data.GetDataPresent(GetType(Node)) = True Then
            Dim node As Node = CType(e.Data.GetData(GetType(Node)), Node)

            DropNodeRow(row, node.Cells)
        ElseIf e.Data.GetDataPresent(GetType(Node())) = True Then
            Dim nodes() As Node = CType(e.Data.GetData(GetType(Node())), Node())

            For Each node As Node In nodes
                If row Is Nothing Then
                    row = New GridRow()

                    panel.Rows.Add(row)
                End If

                DropNodeRow(row, node.Cells)

                row = TryCast(row.NextVisibleRow, GridRow)
            Next node
        End If
    End Sub

#Region "DropNodeRow"

    Private Sub DropNodeRow(ByVal row As GridRow, ByVal cells As CellCollection)
        Dim text(cells.Count - 1) As String

        For i As Integer = 0 To cells.Count - 1
            text(i) = cells(i).Text
        Next i

        DropTextRow(row, text)
    End Sub

#End Region

#Region "DropTextRow"

    Private Sub DropTextRow(ByVal row As GridRow, ByVal s() As String)
        Dim panel As GridPanel = row.GridPanel

        Dim n As Integer = Math.Min(s.Length, panel.Columns.Count)

        For i As Integer = 0 To n - 1
            If i >= row.Cells.Count Then
                row.Cells.Add(New GridCell())
            End If

            row.Cells(i).Value = s(i)
            row.Cells(i).CellStyles.Default.TextColor = Color.Red
        Next i

        row.EnsureVisible(False)
    End Sub



#End Region

#End Region

#Region "DropColumnHeader"

    ''' <summary>
    ''' Handles dropping non-grid data on a grid column header
    ''' </summary>
    ''' <param name="e"></param>
    ''' <param name="header"></param>
    ''' <param name="pt"></param>
    Private Sub DropColumnHeader(ByVal e As DragEventArgs, ByVal header As GridColumnHeader, ByVal pt As Point)
        Dim column As GridColumn = header.GetHitColumn(pt)

        If column IsNot Nothing Then
            Dim panel As GridPanel = column.GridPanel

            Dim row As New GridRow()
            panel.Rows.Add(row)

            If e.Data.GetDataPresent(GetType(String)) = True Then
                Dim s As String = CStr(e.Data.GetData(GetType(String)))

                DropTextRow(row, s.Split(","c))
            ElseIf e.Data.GetDataPresent(GetType(TreeNode)) = True Then
                Dim tnode As TreeNode = CType(e.Data.GetData(GetType(TreeNode)), TreeNode)

                DropTextRow(row, tnode.Text.Split(","c))
            ElseIf e.Data.GetDataPresent(GetType(Node)) = True Then
                Dim node As Node = CType(e.Data.GetData(GetType(Node)), Node)

                DropNodeRow(row, node.Cells)
            ElseIf e.Data.GetDataPresent(GetType(Node())) = True Then
                Dim nodes() As Node = CType(e.Data.GetData(GetType(Node())), Node())

                For Each node As Node In nodes
                    If row Is Nothing Then
                        row = New GridRow()

                        panel.Rows.Add(row)
                    End If

                    DropNodeRow(row, node.Cells)

                    row = TryCast(row.NextVisibleRow, GridRow)
                Next node
            End If
        End If
    End Sub

#End Region

#End Region

#Region "SuperGridControlDragLeave"

    ''' <summary>
    ''' Handles SuperGrid DragLeave events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SuperGridControlDragLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Super_Dgv.DragLeave
        ' Make sure our highlights are cleared

        ClearDragHighlight()
    End Sub

#End Region

#Region "ClearDragHighlight"

    ''' <summary>
    ''' Clears all temporary grid highlights
    ''' </summary>
    Private Sub ClearDragHighlight()
        If _DragOverRow IsNot Nothing Then
            _DragOverRow.CellStyles.Default.Background = Nothing
        End If

        If _DragOverCell IsNot Nothing Then
            _DragOverCell.CellStyles.Default.Background = Nothing
        End If

        If _DragOverColumn IsNot Nothing Then
            _DragOverColumn.CellStyles.Default.Background = Nothing
        End If
    End Sub

#End Region

#End Region

    Private Sub BtnLuuTam_ViTri_Click(sender As Object, e As EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim intFullIndex As Integer = 0
        Dim intGridIndex As Integer = 0
        Dim item As GridRow = Nothing
        'Try
        'If item IsNot Nothing Then
        Dim n As Integer = 0
        'Super_Dgv.BeginUpdate()
        For Each row As GridRow In panel.Rows
            If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True Then
                intFullIndex = row.FullIndex
                intGridIndex = row.GridIndex
                n = row.Cells("thutu_sanxuat_uutien").Value - 1
                n = n + intFullIndex - intGridIndex
                item = CType(row, GridRow)
                row.IsSelected = True
                Exit For
            End If
        Next row
        'Super_Dgv.EndUpdate()
        wait(100)
        If item IsNot Nothing Then
            Dim items As SelectedElementCollection = CType(panel.GetSelectedRows, SelectedElementCollection)
            '//
            panel.ClearSort()
            '//
            MoveSgRows_UpDown(item, items, n)
        End If
    End Sub

    Private Sub MoveSgRows_UpDown(ByVal row As GridRow, ByVal rows As IEnumerable(Of GridElement), ByVal intpos As Integer)
        Dim panel As GridPanel = row.GridPanel

        Dim n As Integer = intpos
        Super_Dgv.SuspendLayout()
        For Each item As GridRow In rows
            panel.Rows.Remove(item)
        Next item

        For Each item As GridRow In rows
            panel.Rows.Insert(n, item)

            For Each cell As GridCell In item.Cells
                cell.CellStyles.Default.TextColor = Color.Red
            Next cell
            item.Checked = False
        Next item
        Super_Dgv.ResumeLayout()
    End Sub


#Region "NGAY DU TINH LENH SAN XUAT"
    Private Sub btnChon_NgayDuTinh_Click(sender As Object, e As EventArgs) Handles btnChon_NgayDuTinh.Click
        btnChon_NgayDuTinh.Enabled = False
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_update_LenhsanXuat(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_congdoan_UpSet]", sbXMLString.ToString, "update_mamay_lenhsanxuat")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
        End If
    End Sub


    Private Sub UpdateDetails_update_LenhsanXuat(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim _mamay_id As String = String.Empty
        Dim _congdoan_id As String = String.Empty
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_LenhsanXuat(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame").Value.ToString) + "' ")
                    sbXMLString.Append("congdoan_id='" + ReplaceTextXML(_congdoan_id) + "' ")
                    sbXMLString.Append("mamay_id='" + ReplaceTextXML(_mamay_id) + "' ")
                    sbXMLString.Append("dtngaylap_kehoach='" + Format$(row.Cells("thoigianvao_dukien").Value, "MM/dd/yyyy") + "' ")
                    sbXMLString.Append("thoigianvao_dukien='" + Format$(row.Cells("thoigianvao_dukien").Value, "MM/dd/yyyy HH:mm") + "' ")
                    sbXMLString.Append("thoigianra_dukien='" + Format$(row.Cells("thoigianra_dukien").Value, "MM/dd/yyyy HH:mm") + "' ")
                    sbXMLString.Append("thoigian='" + CNumber_system(row.Cells("thoigian_toithieu").Value) + "' ")
                    sbXMLString.Append("thoigian_cho='" + CNumber_system(row.Cells("thoigian_cho").Value) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

    Private Sub btnChonNgay_BatDau_Click(sender As Object, e As EventArgs) Handles btnChonNgay_BatDau.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        'Try
        If dgvr IsNot Nothing Then
            dgvr.Cells("thoigianvao_dukien").Value = dtNgayxuat_chungtu.Value
            Timer_NgayDuTinh.Enabled = True
        End If

    End Sub

#End Region

#Region "SAP XEP NGAY DU TINH"
    Private Sub Timer_NgayDuTinh_Tick(sender As Object, e As EventArgs) Handles Timer_NgayDuTinh.Tick

        Timer_NgayDuTinh.Enabled = False
        IsFirstRow = False
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Update_ALL_NgayDuTinh(panel.Rows)
        '//
        btnChon_NgayDuTinh.Enabled = True
    End Sub

    Private Sub Update_ALL_NgayDuTinh(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        Dim _GioVao_Next As DateTime

        '////
        For Each item As GridElement In rows
            If _blnPress = False Then Exit For
            If item.Visible = True Then
                Dim group As GridGroup = TryCast(item, GridGroup)
                If group IsNot Nothing Then
                    Update_ALL_NgayDuTinh(group.Rows)
                Else
                    Dim row As GridRow = TryCast(item, GridRow)
                    Dim _Thoigian_toithieu As Integer = 0
                    Dim _Thoigian_delay As Integer = 0
                    If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                        Dim nextrow As GridRow = CType(row.NextVisibleRow, GridRow)
                        Dim Prerow As GridRow = CType(row.PrevVisibleRow, GridRow)
                        '//
                        _Thoigian_toithieu = CoToDec(row.Cells("thoigian_toithieu").Value, 0)
                        _Thoigian_delay = CoToDec(row.Cells("thoigian_cho").Value, 0)
                        '//
                        If IsFirstRow = False Then
                            IsFirstRow = True
                            If IsDBNull(row.Cells("thoigianvao_dukien").Value) = False Then
                                _dtGiovao = row.Cells("thoigianvao_dukien").Value
                            Else
                                _dtGiovao = _TimeServer
                            End If
                            row.Cells("thoigianvao_dukien").Value = _dtGiovao
                            _dtGiora = _dtGiovao.AddMinutes(_Thoigian_toithieu)
                            row.Cells("thoigianra_dukien").Value = _dtGiora
                            _GioVao_Next = _dtGiora.AddMinutes(_Thoigian_delay)
                        Else
                            _dtGiovao = _GioVao_Next
                            _dtGiora = _dtGiovao.AddMinutes(_Thoigian_toithieu)
                            row.Cells("thoigianvao_dukien").Value = _dtGiovao
                            row.Cells("thoigianra_dukien").Value = _dtGiora
                            '//
                            _GioVao_Next = _dtGiora.AddMinutes(_Thoigian_delay)
                        End If
                        If nextrow IsNot Nothing Then
                            '_GioVao_Next =
                        End If

                    End If
                End If

            End If
        Next

    End Sub

#End Region

#Region "COPY & PASTE"
#Region "PASTE"
    Dim _st As Object
    Dim _unit As String
    Dim _CountSelected As Integer = 0
    Dim _lenght As Integer = 0
    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _st = System.Windows.Forms.Clipboard.GetText.Trim
        _unit = panel.Columns(_columnName).EditorType.Name
        _CountSelected = 0

        _isPaste_G = True
        UpdateDetailsJobPaste(panel.Rows, _unit)
        wait(200)
        _isPaste_G = False
    End Sub
    Private Sub UpdateDetailsJobPaste(ByVal rows As IEnumerable(Of GridElement), _colunit As String)
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetailsJobPaste(group.Rows, _colunit)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Cells(_columnName).IsSelected = True AndAlso row.Cells(0).Value IsNot Nothing And row.IsDetailRow = False Then
                    If row.IsDetailRow = False Then
                        Try
                            row.Cells(_columnName).Value = _List_Cells(_CountSelected)
                            row.Cells(_columnName).EditorDirty = True
                            row.Checked = True
                            row.Cells(_columnName).CellStyles.Default.Background.Color1 = Color.GreenYellow
                            _CountSelected += 1
                            If _CountSelected > _List_Cells.Length - 1 Then
                                _CountSelected = 0
                            End If
                        Catch ex As Exception

                        End Try

                    End If

                End If
            End If
        Next
    End Sub


#End Region

#Region "Copy"
    Dim _st_copy As Object



    Dim _unit_copy As String



    Private Sub btnCopy_Cells_Click(sender As Object, e As EventArgs) Handles btnCopy_Cells.Click
        _List_Cells = {}
        If _columnName Is Nothing Then Exit Sub
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _st = System.Windows.Forms.Clipboard.GetText.Trim
        _unit_copy = panel.Columns(_columnName).EditorType.Name
        UpdateDetailsJob_CopyCells(panel.Rows, _unit_copy)
        wait(200)
    End Sub

    Private Sub UpdateDetailsJob_CopyCells(ByVal rows As IEnumerable(Of GridElement), _colunit As String)
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetailsJob_CopyCells(group.Rows, _colunit)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Cells(_columnName).IsSelected = True AndAlso row.Cells(0).Value IsNot Nothing And row.IsDetailRow = False Then
                    If row.IsDetailRow = False Then
                        _List_Cells = _List_Cells.Concat({row.Cells(_columnName).Value}).ToArray
                    End If
                End If
            End If
        Next
    End Sub


#End Region
#End Region


#Region "AP KE HOACH SAN XUAT"
    Private Sub BtnExit_Form_KeHoachSX_Click(sender As Object, e As EventArgs) Handles BtnExit_Form_KeHoachSX.Click
        GP_Form_KeHoach.Visible = False
    End Sub

    Private Sub ToolStripButton_ApCaSanXuat_Click(sender As Object, e As EventArgs) Handles BtnCaSanXuat.Click
        'Try
        Dim btn As ButtonX = CType(sender, ButtonX)
        With GP_Form_KeHoach
                .Text = "ÁP KẾ HOẠCH SẢN XUẤT"
                '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True
            End With
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub BtnXoaPhieu_Click(sender As Object, e As EventArgs) Handles BtnXoaPhieu.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện Xóa Phiếu Sản Xuất?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_update_KeHoach(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_CongDoan_UpSet]", sbXMLString.ToString, "update_xoaphieu_sanxuat")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub Btn_Update_Form_KeHoachSX_Click(sender As Object, e As EventArgs) Handles Btn_Update_Form_KeHoachSX.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện cập nhật Ca Sản Xuất?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        LTongcay_congdoan = 0
        LTongKg_congdoan = 0
        LTongMet_congdoan = 0
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_update_KeHoach(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_CongDoan_UpSet]", sbXMLString.ToString, "update_casanxuat")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub

    Private Sub UpdateDetails_update_KeHoach(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_KeHoach(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    LTongcay_congdoan += row.Cells("socay").Value
                    LTongcay_congdoan += row.Cells("sokg").Value
                    LTongcay_congdoan += row.Cells("somet").Value
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame").Value.ToString) + "' ")
                    sbXMLString.Append("congdoan_id='" + ReplaceTextXML(row.Cells("congdoan_id").Value.ToString) + "' ")
                    sbXMLString.Append("dtngaylap_kehoach='" + Format$(dtngay_casanxuat.Value, "MM/dd/yyyy") + "' ")
                    sbXMLString.Append("phanloai_ngaydem='" + ReplaceTextXML(txtsophieu_sx.Text) + "' ")
                    sbXMLString.Append("thutu_sanxuat='" + CNumber_system(txtthutu.Text) + "' ")
                    'sbXMLString.Append("tongcay='" + CNumber_system(txtthutu.Text) + "' ")
                    'sbXMLString.Append("tongkg='" + CNumber_system(txtthutu.Text) + "' ")
                    'sbXMLString.Append("tongmet='" + CNumber_system(txtthutu.Text) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

    Private Sub cboCa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCa.SelectedIndexChanged
        Change_PhanLoai()
    End Sub
    Private Sub Change_PhanLoai()
        Dim _stNgay As String = gRight("0" & dtngay_casanxuat.Value.Day, 2)
        Dim _stThang As String = gRight("0" & dtngay_casanxuat.Value.Month, 2)
        Dim _stNam As String = gRight(dtngay_casanxuat.Value.Year, 2)
        If cboCa.SelectedIndex = 0 Then
            txtphanloai_kehoach.Text = _stNgay & _stThang & _stNam & "N"
        Else
            txtphanloai_kehoach.Text = _stNgay & _stThang & _stNam & "D"
        End If
        '//
        txtsophieu_sx.Text = txtphanloai_kehoach.Text & txtthutu.Text
    End Sub

    Private Sub dtngay_casanxuat_ValueChanged(sender As Object, e As EventArgs) Handles dtngay_casanxuat.ValueChanged
        Change_PhanLoai()
    End Sub
    Private Sub txtthutu_TextChanged(sender As Object, e As EventArgs) Handles txtthutu.TextChanged
        txtsophieu_sx.Text = txtphanloai_kehoach.Text & txtthutu.Text
    End Sub

#End Region


#Region "AP THIET BI"
    Private Sub Btn_Refresh_Form_MayMoc_Click(sender As Object, e As EventArgs) Handles Btn_Refresh_Form_MayMoc.Click
        Load_May()
    End Sub
    Private Sub Load_May()
        dt_may = VpsXmlList_Load(txtnhommay_id.Text, "", "chonlua_may")
        LoadDataToCombox(dt_may, cboMay, "mamay", True)
        cboMay.SelectedIndex = -1
    End Sub
    Private Sub BtnExit_Form_MayMoc_Click(sender As Object, e As EventArgs) Handles BtnExit_Form_MayMoc.Click
        GP_Form_May.Visible = False
    End Sub



    Private Sub BtnChuyenMay_Click(sender As Object, e As EventArgs) Handles BtnChuyenMay.Click
        Try
            Dim btn As ButtonX = CType(sender, ButtonX)
            With GP_Form_May
                .Text = "CHUYỂN MÁY"
                '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True
                '//
                Load_May()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Update_Form_MayMoc_Click(sender As Object, e As EventArgs) Handles Btn_Update_Form_MayMoc.Click
        If MsgBox("Bạn có muốn thực hiện cập nhật Máy?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        dr2 = dt_may.Select("mamay = '" & cboMay.Text & "'", "")
        If dr2.Length > 0 Then
            Lmamay_id = dr2.First.Item("mamay_id")
        Else
            MsgBox("Vui lòng chọn máy.", MsgBoxStyle.Information, "Thông Báo")
            Exit Sub
        End If
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_update_MayMoc(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_CongDoan_UpSet]", sbXMLString.ToString, "update_mamay")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub

    Private Sub UpdateDetails_update_MayMoc(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_MayMoc(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString.Trim) + "' ")
                    sbXMLString.Append("congdoan_id='" + ReplaceTextXML(row.Cells("congdoan_id").Value.ToString.Trim) + "' ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame").Value.ToString.Trim) + "' ")
                    sbXMLString.Append("mamay_id='" + ReplaceTextXML(Lmamay_id) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

#End Region

#Region "AUTO CHANGE COLOR"
    Private _ColorCycle As Integer = 0
    ''' <summary>
    ''' Sets new colors for the given color table
    ''' </summary>
    ''' <param name="colors">Color Table</param>
    Private Sub SetNewScheme(ByVal colors As Color())
        ' Loop through each color in the table

        For i As Integer = 0 To colors.Length - 1
            colors(i) = GetNewColor(colors(i))
        Next
    End Sub


    ''' <summary>
    ''' Gets a new RGB cycle color
    ''' </summary>
    ''' <param name="color1">Current color</param>
    ''' <returns>New cycled color</returns>
    Private Function GetNewColor(ByVal color1 As Color) As Color
        If (_ColorCycle And 1) = 0 Then
            Return (Color.FromArgb(color1.R, color1.B, color1.G))
        End If

        Return (Color.FromArgb(color1.G, color1.R, color1.B))
    End Function


#End Region

#Region "DAT LAI THU TU SAN XUAT"
    Private Sub BtnReset_LenhSanXuat_Click(sender As Object, e As EventArgs) Handles BtnReset_LenhSanXuat.Click
        If MsgBox("Bạn có muốn thực hiện cập nhật ĐẶT LẠI THỨ TỰ SẢN XUẤT?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_update_RESETChaySanXuat(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_congdoan_UpSet]", sbXMLString.ToString, "update_mamay_thutuchay")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
        End If
    End Sub


    Private Sub UpdateDetails_update_RESETChaySanXuat(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim _mamay_id As String = String.Empty
        Dim _congdoan_id As String = String.Empty
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_RESETChaySanXuat(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False AndAlso IsDBNull(row.Cells("dtngaylap_kehoach").Value) = True Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame").Value.ToString) + "' ")
                    sbXMLString.Append("thutu_sanxuat='" + CNumber_system(1000) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub


#End Region
    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmahang_F.KeyDown,
     txtloaihang_F.KeyDown, txtmamau_F.KeyDown, txtmame_ghep_F.KeyDown,
       txtmame_F.KeyDown, txtmau_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

#Region "huy lenh"
    Private Sub BtnHuyLenh_Click(sender As Object, e As EventArgs) Handles BtnHuyLenh.Click
        Try
            Dim btn As ButtonX = CType(sender, ButtonX)
            With GP_Form_HuyCongDoan_DaSanXuat
                .Text = "HỦY LỆNH SẢN XUẤT"
                '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True
            End With
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnThoat_GP_HuyCongDoan_Click(sender As Object, e As EventArgs) Handles BtnThoat_GP_HuyCongDoan.Click
        GP_Form_HuyCongDoan_DaSanXuat.Visible = False
    End Sub



    Private Sub BtnHuy_GioVao_Click(sender As Object, e As EventArgs) Handles BtnHuy_GioVao.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = DirectCast(panel.ActiveRow, GridRow)
        If dgvr IsNot Nothing Then
            _MaID = dgvr.Cells("maid").Value
        End If


        mocls.AddParam("@MaID", _MaID)
        mocls.AddParam("@mamay_id", "")
        mocls.AddParam("@congdoan_id", "")
        mocls.AddParam("@ismeghep", 0)
        mocls.AddParam("@iscustom", 0)
        mocls.AddParam("@nv_id", "-")
        mocls.AddParam("@giobatdau", _TimeServer)
        mocls.AddParam("@gioketthuc", _TimeServer)
        mocls.AddParam("@command", "huygiovao")
        'Call mocls.ExecQuery_StoredProduce("vps_VP_Mame_Congdoan_execute")
        ' REPORT & ABORT ON ERRORS
        'If mocls.HasException(True) Then Exit Sub
        'cls.wait(200)
        'Call Filterdata_Stored()
    End Sub

    Private Sub BtnHuy_GioRa_Click(sender As Object, e As EventArgs) Handles BtnHuy_GioRa.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = DirectCast(panel.ActiveRow, GridRow)
        If dgvr IsNot Nothing Then
            _MaID = dgvr.Cells("maid").Value
        End If
        mocls.AddParam("@MaID", _MaID)
        mocls.AddParam("@mamay_id", "")
        mocls.AddParam("@congdoan_id", "")
        mocls.AddParam("@ismeghep", 0)
        mocls.AddParam("@iscustom", 0)
        mocls.AddParam("@nv_id", "-")
        mocls.AddParam("@giobatdau", _TimeServer)
        mocls.AddParam("@gioketthuc", _TimeServer)
        mocls.AddParam("@command", "huygiora")
        'Call mocls.ExecQuery_StoredProduce("vps_VP_Mame_Congdoan_execute")
        ' REPORT & ABORT ON ERRORS
        'If mocls.HasException(True) Then Exit Sub
        'cls.wait(200)
        'Call Filterdata_Stored()
    End Sub


#End Region

    Private Sub BtnHuyKeHoach_Click(sender As Object, e As EventArgs) Handles BtnHuyKeHoach.Click
        If MsgBox("Bạn có chắc HỦY KẾ HOẠCH không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CẢNH BÁO") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_update_KeHoach(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_CongDoan_UpSet]", sbXMLString.ToString, "update_huylenh")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub

End Class