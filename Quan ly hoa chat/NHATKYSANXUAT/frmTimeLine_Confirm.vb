Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports DevComponents.AdvTree

Public Class frmTimeLine_Confirm
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim dt_congdoan As DataTable
    Dim dt_congdoan_ph As DataTable
    Dim dt_may As DataTable
    Private dr0 As DataRow()

    Dim _Load_Ok As Boolean = False
    Dim _saveRowIndex As Integer = 0

    Dim _List_Cells As String() = {}
    Dim strCells As List(Of String) = _List_Cells.ToList()
    '//
    Private _List_Column_Locked As String() = {"thutu_sanxuat_uutien", "thoigian_cho", "thoigian_toithieu", "ghichu", "phanloai_ngaydem"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Private IsChanged As Boolean = False
    '--
    Dim _kieuxuat_id As String, _stMakytu_xuat As String
    Dim dr2 As DataRow()
    Dim _chungtuxuat_id As String
    Dim _load_finish As Boolean = False

    Private _congdoan_id As String = String.Empty
    Private _macongdoan As String = String.Empty
    Private Lmame As String = String.Empty
    '//
    Private _IsBusy As Boolean = False

    Private SoDongChon As Integer = 0
    Private _MaMe As String = String.Empty
    Private _MaMay As String = String.Empty

    '//
    Private _columnName As String = String.Empty
    Dim _ColorPick As String = String.Empty
    Private Lmamay_id As String = String.Empty
    Private Lmame_id As String = String.Empty
    Private LNV_ID As String = String.Empty
    Private LNhanVien As String = String.Empty
    Private LID As String = String.Empty
    Private LCongDoan_id As String = String.Empty
    Private Lkhuvuc_id As String = String.Empty
    Private Lkhuvuc As String = String.Empty
    '//
    Private Lmahang_id As String = String.Empty
    Private Lmahang As String = String.Empty
    Private Lmamau_id As String = String.Empty
    Private Lmamau As String = String.Empty
    '//
    Private _GioVao As DateTime
    Private _GioKetThuc As DateTime
    Private _thoigian_toithieu As Int16 = 0
    Private IsSelected_Row As Boolean = False
    Private tpress As New Timer With {.Interval = 200}
    Private _IsFirst As Boolean = False
    Private Lsocay_phanme As Int16 = 0
    Private Lsocay_xuatmoc As Int16 = 0
    '//
    Public Property MaMe_ID() As String
        Get
            Return Lmame_id
        End Get
        Set(ByVal value As String)
            Lmame_id = value
        End Set
    End Property
    Public Property KhuVuc_ID() As String
        Get
            Return Lkhuvuc_id
        End Get
        Set(ByVal value As String)
            Lkhuvuc_id = value
        End Set
    End Property
    Public Property KhuVuc() As String
        Get
            Return Lkhuvuc
        End Get
        Set(ByVal value As String)
            Lkhuvuc = value
        End Set
    End Property
    Public Property NhanVien_ID() As String
        Get
            Return LNV_ID
        End Get
        Set(ByVal value As String)
            LNV_ID = value
        End Set
    End Property
    Public Property NhanVien() As String
        Get
            Return LNhanVien
        End Get
        Set(ByVal value As String)
            LNhanVien = value
        End Set
    End Property
    '//
#Region "LOAD FORMAT"
    Dim _MyFont_Header_dgv As New Font("Time New Roman", 13, FontStyle.Bold)
    Dim _MyFont_dgv As New Font("Time New Roman", 13, FontStyle.Regular)
    Private Sub Format_SuperGrid()
        Super_Dgv_Info.Dock = DockStyle.Fill
        '//
        Dim panel As GridPanel = TryCast(Super_Dgv_Info.PrimaryGrid, GridPanel)
        With panel
            .BeginDataUpdate()
            .VirtualMode = False
            .ReadOnly = True
            .ColumnHeader.Visible = False
            .RowHeaderWidth = 0
            .Filter.Visible = False
            .RowHeaderIndexOffset = 1
            .DefaultRowHeight = 30
            '.UseAlternateRowStyle = True
            '.UseAlternateColumnStyle = True
            .ColumnAutoSizeMode = ColumnAutoSizeMode.DisplayedCells
            .ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CellStyles.Default.Font = _MyFont_dgv
            .DefaultVisualStyles.ColumnHeaderStyles.Default.Font = _MyFont_Header_dgv
            .DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = Alignment.MiddleRight
            .DefaultVisualStyles.HeaderStyles.Default.Alignment = Alignment.MiddleCenter
            .DefaultVisualStyles.GroupHeaderStyles.Default.Alignment = Alignment.MiddleCenter
            .DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleLeft
            .DefaultVisualStyles.CellStyles.Default.Margin.Left = 5
            .DefaultVisualStyles.CellStyles.Default.Margin.Right = 5
            '.DefaultVisualStyles.CaptionStyles.Default.Image = ImageList1.Images(0)
            .SelectionGranularity = SelectionGranularity.RowWithCellHighlight
            '.GridLines = GridLines.Horizontal
            .AllowSelection = False
            .DefaultVisualStyles.CaptionStyles.Default.Background.Color1 = Color.Yellow
            '//
            '.AllowDrop = True
            .KeepRowsSorted = False
            .ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .Caption.EnableMarkup = True
            .Caption.Visible = True
            '////

            '.Caption.Visible = True
            Dim gc As DevComponents.DotNetBar.SuperGrid.GridColumn = Nothing
            gc = New DevComponents.DotNetBar.SuperGrid.GridColumn("id")
            gc.HeaderText = "A"
            'gc.HeaderStyles.Default.Image = ImageList1.Images(0)
            gc.HeaderStyles.Default.Alignment = Alignment.MiddleCenter
            gc.Name = "id"
            gc.CellStyles.Default.Alignment = Alignment.MiddleRight
            gc.EnableHeaderMarkup = True
            'gc.Width = 100
            gc.CellStyles.Default.Font = _MyFont_Header_dgv
            'gc.CellStyles.Default.Image = ImageList2.Images(0)
            .Columns.Add(gc)
            gc = New DevComponents.DotNetBar.SuperGrid.GridColumn("name")
            gc.HeaderText = "B"
            'gc.HeaderStyles.Default.Image = ImageList1.Images(0)
            gc.HeaderStyles.Default.Alignment = Alignment.MiddleCenter
            gc.Name = "name"
            gc.EnableHeaderMarkup = True
            .Columns.Add(gc)

            .EndDataUpdate()
        End With
    End Sub

    Private Sub Add_Data()
        Dim panel As GridPanel = TryCast(Super_Dgv_Info.PrimaryGrid, GridPanel)
        With panel
            .BeginDataUpdate()
            If _IsFirst = False Then
                _IsFirst = True
                wait(100)
            End If
            '//
            If .Rows.Count = 0 Then
                panel.Rows.Add(GetNewRow("Giờ Vào", Now, 1))
            End If
            '//
            .EndDataUpdate()
        End With
    End Sub
    Private Function GetNewRow(ByVal _data1 As String, ByVal _data2 As String, ByVal _data3 As Int16) As GridRow
        ' GridRows can be created with varying parameters set
        ' to the GridRow constructor. In this case we are
        ' sending a variable list of parameters.
        Dim row As New GridRow(_data1, _data2)
        If _data3 = 1 Then
            'row.Cells(0).CellStyles.Default.Image = ImageList2.Images(0)
        End If

        Return (row)
    End Function
#End Region

    Private Sub BtnExit_CapNhat_Click(sender As Object, e As EventArgs) Handles BtnExit_CapNhat.Click
        Me.Close()
    End Sub
    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Lkhuvuc.Length > 0 Then
            With txtmame_scanner
                If .Focused = False Then
                    .Focus()
                    .Text = e.KeyChar.ToString
                    .SelectionStart = .Text.Length
                    e.Handled = True
                End If
            End With
        End If

    End Sub
    Private Sub Me_FormClosing(ByVal sender As Object,
                                    ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                    Handles Me.FormClosing

        If IsChanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
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
        Call clsDev.Format_Super_Dgv(Super_Dgv_LenhSanXuat, _MyFont_GridView - 1)
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '//
        dt_local = New DataTable
        dt_congdoan = New DataTable
        dt_congdoan_ph = New DataTable
        dt_may = New DataTable
        '//

        With Super_Dgv
            .PrimaryGrid.Filter.Visible = False
            .AllowDrop = True
            .PrimaryGrid.KeepRowsSorted = False
            .PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .PrimaryGrid.Caption.EnableMarkup = True
            .PrimaryGrid.Caption.Visible = True
            .PrimaryGrid.Caption.Text = "NHẬT KÝ CÔNG ĐOẠN: "
        End With
        With Super_Dgv_LenhSanXuat
            .PrimaryGrid.Filter.Visible = False
            .AllowDrop = True
            .PrimaryGrid.KeepRowsSorted = False
            .PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .PrimaryGrid.Caption.EnableMarkup = True
            .PrimaryGrid.Caption.Visible = True
            .PrimaryGrid.Caption.Text = "NHẬT KÝ ĐO PH: "
        End With

        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        'AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        'AddHandler Super_Dgv.CellClick, AddressOf CellClick
        'AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        'AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        '//
        AddHandler Super_Dgv_LenhSanXuat.DataBindingComplete, AddressOf Super_Dgv_LenhSanXuat_DataBindingComplete
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '//

        Format_SuperGrid()
    End Sub

    Private Sub Load_CongDoan_PH()
        dt_congdoan_ph = VpsXmlList_Load(_macongdoan, "", "congdoan_ph")
        LoadDataToCombox(dt_congdoan_ph, CboCongDoan_PH, "phanloai", True)
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Call Check_administrator(Me.Name.ToString)
        If True = True Then
            With Super_Dgv_Info
                'Them <br/> để xuống dòng
                Dim stinfo As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<font size=""16""><font color=""Black""> {1} </font></font>"
                Dim stinfo_br As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo_br &= "<font size=""16""><font color=""RED""> {1} </font></font><br/>"
                '//
                Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                .PrimaryGrid.Caption.Text = String.Format(stinfo, "+ KHU VỰC: ", Lkhuvuc.ToUpper)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, _tab & "+ NHÂN VIÊN: ", LNhanVien.ToUpper)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "======================", "")
                'Add_Data()
                '////
            End With
            _load_finish = True
        Else
            Me.Close()
        End If
    End Sub

#Region "LOAD TAT CA CONG DOAN ME"
    Private Sub Filterdata_chung()
        Me.SuspendLayout()
        'Try
        'Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_scanner.Text) + "' ")
        sbXMLString.Append("khuvuc_id='" + ReplaceTextXML(Lkhuvuc_id) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_NhatKy_CongDoan_View_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
    End Sub
    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '//
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("thutu")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDir_Asc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDir_Asc(sortCols))
        End If

        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)

        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '--
        _stName = "Theo_NhanVienVao"
        _stHeadText = "Nhân Viên Vào"
        _stCol1 = "masonhanvien"
        _stCol2 = "thoigianvao"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        _stName = "Theo_NhanVienRa"
        _stHeadText = "Nhân Viên Ra"
        _stCol1 = "masonhanvien_1"
        _stCol2 = "thoigianra"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If

        '//

        tpress.Enabled = True

    End Sub
    Sub MyTickHandler(ByVal sender As Object, ByVal e As EventArgs)
        '//
        tpress.Enabled = False
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        '//
        'Them <br/> để xuống dòng
        Dim stinfo As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
        stinfo &= "<font size=""16""><font color=""Black""> {1} </font></font>"
        Dim stinfo_br As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
        stinfo_br &= "<font size=""16""><font color=""RED""> {1} </font></font><br/>"
        '//
        '//
        Dim inty As Int16 = 0
        IsSelected_Row = False
        For Each row As GridRow In panel.Rows
            If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                Lsocay_phanme = row.Cells("socay_phanme").Value
                Lsocay_xuatmoc = row.Cells("socay_xuatmoc").Value
                '//
                If IsSelected_Row = False Then
                    If IsDBNull(row.Cells("thoigianvao").Value) = True AndAlso IsDBNull(row.Cells("thoigianra").Value) = True Then
                        _MaMe = row.Cells("mame").Value
                        _macongdoan = row.Cells("macongdoan").Value
                        LID = row.Cells("maid").Value
                        LCongDoan_id = row.Cells("congdoan_id").Value
                        _thoigian_toithieu = row.Cells("thoigian_toithieu").Value
                        _MaMay = row.Cells("mamay").Value
                        Lmamay_id = row.Cells("mamay_id").Value
                        Lmame_id = row.Cells("mame_id").Value
                        '//
                        Lmahang_id = row.Cells("mahang_id").Value
                        Lmahang = row.Cells("mahang").Value
                        Lmamau_id = row.Cells("mamau_id").Value
                        Lmamau = row.Cells("mamau").Value
                        '//
                        _GioVao = Now
                        btnXacNhan_GioVao.Enabled = True
                        btnXacNhan_GioRa.Enabled = False
                        IsSelected_Row = True
                        '--
                        row.SetActive()
                        row.IsSelected = True
                        inty += 1
                    ElseIf IsDBNull(row.Cells("thoigianvao").Value) = False AndAlso IsDBNull(row.Cells("thoigianra").Value) = True Then
                        '//
                        Lmahang_id = row.Cells("mahang_id").Value
                        Lmahang = row.Cells("mahang").Value
                        Lmamau_id = row.Cells("mamau_id").Value
                        Lmamau = row.Cells("mamau").Value
                        '//
                        Lmamay_id = row.Cells("mamay_id").Value
                        Lmame_id = row.Cells("mame_id").Value
                        _MaMe = row.Cells("mame").Value
                        _macongdoan = row.Cells("macongdoan").Value
                        LID = row.Cells("maid").Value
                        _GioVao = row.Cells("thoigianvao").Value
                        _thoigian_toithieu = row.Cells("thoigian_toithieu").Value
                        btnXacNhan_GioVao.Enabled = False
                        btnXacNhan_GioRa.Enabled = True
                        '//
                        LCongDoan_id = row.Cells("congdoan_id").Value
                        _MaMay = row.Cells("mamay").Value
                        '--
                        IsSelected_Row = True
                        row.SetActive()
                        row.IsSelected = True
                    End If
                    '//
                    Load_CongDoan_PH()
                    '//
                    Filterdata_ThietBi()
                    '//
                    Call Filterdata_LenhSanXuat()
                    '//
                    Super_Dgv_Info.PrimaryGrid.Caption.Text = String.Format(stinfo, "+ KHU VỰC: ", KhuVuc.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ NHÂN VIÊN: ", NhanVien.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo_br, "======================", "")
                    '////
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo_br, "+ ĐƠN HÀNG: ",
                                                       row.Cells("donhang").FormattedValue.ToString.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ MÃ HÀNG: ",
                                                    row.Cells("mahang").FormattedValue.ToString.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo_br, "+ LOẠI HÀNG: ",
                                                     row.Cells("loaihang").FormattedValue.ToString.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo_br, "+ MÀU: ",
                                                     row.Cells("tenmau").FormattedValue.ToString.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ MẺ: ",
                                                     row.Cells("mame").FormattedValue.ToString.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo_br, "+ SỐ CÂY: ",
                                                     Lsocay_phanme & " - " & Lsocay_xuatmoc)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo_br, "======================", "")
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ TÊN MÁY: ", _MaMay.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ CÔNG ĐOẠN: ", _macongdoan.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ T.GIAN: ", _thoigian_toithieu.ToString.ToUpper)
                    '//
                    'Add_Data()
                    If row.Cells("ketqua").Value = 2 Then
                        btnXacNhan_GioVao.Enabled = False
                        btnXacNhan_GioRa.Enabled = False
                        Exit For
                    End If
                End If

            End If
        Next
    End Sub

#End Region

#Region "LOAD LENH SAN XUAT"
    Private Sub Filterdata_ThietBi()
        Me.SuspendLayout()
        'Try
        'Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mamay_id='" + ReplaceTextXML(Lmamay_id) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_CongDoan_ThietBi_DangHoatDong_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        txtsome_dangsanxuat.Text = dt_local.Rows.Count
    End Sub
#End Region


#Region "LOAD LENH SAN XUAT"
    Private Sub Filterdata_LenhSanXuat()
        Me.SuspendLayout()
        'Try
        'Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame='" + ReplaceTextXML(_MaMe) + "' ")
        sbXMLString.Append("congdoan_id='" + ReplaceTextXML(LCongDoan_id) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_NhatKy_DoPH_mame]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML(_dt, Super_Dgv_LenhSanXuat.PrimaryGrid)
    End Sub
    Private Sub Super_Dgv_LenhSanXuat_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)

        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '--
        _stName = "Theo_NhanVienVao"
        _stHeadText = "Nhân Viên Vào"
        _stCol1 = "masonhanvien"
        _stCol2 = "thoigianvao"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        _stName = "Theo_NhanVienRa"
        _stHeadText = "Nhân Viên Ra"
        _stCol1 = "masonhanvien_1"
        _stCol2 = "thoigianra"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mame"), panel.Columns("macongdoan"), panel.Columns("ngaydo")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscAscAscAsc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscAscAscAsc(sortCols))
        End If

    End Sub
    Public Function GetSortDirAscAscAscAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Ascending, SortDirection)})
    End Function

#End Region

    Private Sub CboCongDoan_PH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCongDoan_PH.SelectedIndexChanged
        If _load_finish = True Then
            dr0 = dt_congdoan_ph.Select("phanloai = '" & CboCongDoan_PH.Text & "'", "")
            If dr0.Length > 0 Then
                txtgiatri_min.Text = dr0.First.Item("giatri_min")
                txtgiatri_max.Text = dr0.First.Item("giatri_max")
            Else
                'MsgBox("Vui lòng chọn Khách Hàng.", MsgBoxStyle.Information, "Thông Báo")
                txtgiatri_min.Text = 0
                txtgiatri_max.Text = 0
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtmame_scanner.Text = String.Empty
        txtmame_scanner.Focus()
    End Sub

#Region "XAC NHAN GIO VAO"

    Private Sub ShowModalForm_XacNhan_GioVao()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_XacNhan_GioVao))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmTimeLine_CongDoan_GioVao
                '.Size = New Size(Form1.Width * 0.95, Form1.Height * 0.95)
                .StartPosition = FormStartPosition.CenterParent
                '//
                .Text = "XÁC NHẬN GIỜ VÀO"
                '//
                .MaID = LID
                .MaMe_ID = Lmame_id
                .CongDoan_ID = _congdoan_id
                .MaCongDoan = _macongdoan
                .MaMay = _MaMay
                .MaMe = _MaMe
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_chung()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub

    Private Sub btnXacNhan_GioVao_Click(sender As Object, e As EventArgs) Handles btnXacNhan_GioVao.Click
        If Lsocay_phanme <> Lsocay_xuatmoc Then
            MsgBox("Vui lòng xác nhận xuất mộc.", MsgBoxStyle.Information, "Thông Báo")
            Exit Sub
        End If
        'GioVao()
        If CInt(txtsome_dangsanxuat.Text) = 0 Then
            XacNhan_GioVao()
        Else
            MsgBox("Vui lòng kết thúc mẻ đang chạy trên thiết bị.", MsgBoxStyle.Information, "Thông Báo")
        End If

    End Sub
    Private Sub XacNhan_GioVao()
        If Len(LID) = 0 Then Exit Sub
        Dim lenh As String = String.Empty
        Dim _QT_hientai As String = String.Empty
        'If MsgBox("Bạn có muốn xác nhận Giờ Bắt đầu?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xác Nhận Giờ Bắt Đầu") = MsgBoxResult.Yes Then
        Call Load_TimeServer()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("maid='" + ReplaceTextXML(LID) + "' ")
        sbXMLString.Append("mamay_id='" + ReplaceTextXML(Lmamay_id) + "' ")
        sbXMLString.Append("congdoan_id='" + ReplaceTextXML(LCongDoan_id) + "' ")
        sbXMLString.Append("nv_id='" + ReplaceTextXML(LNV_ID) + "' ")
        sbXMLString.Append("ismeghep='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("iscustom='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("thoigianvao='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
        sbXMLString.Append("thoigianra='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet_2021]", sbXMLString.ToString, "update_giovao")
        IsChanged = dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_chung()
        '//
        Call Filterdata_LenhSanXuat()
    End Sub

#End Region

#Region "XAC NHAN GIO RA"
    Private Sub ShowModalForm_XacNhan_GioRa()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_XacNhan_GioRa))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmTimeLine_CongDoan_GioRa
                .Size = New Size(Form1.Width * 0.95, Form1.Height * 0.9)
                .StartPosition = FormStartPosition.CenterParent
                '//
                .Text = "XÁC NHẬN GIỜ RA"
                '//
                .MaID = LID
                .MaMay_ID = Lmamay_id
                .MaCongDoan = _macongdoan
                .MaCongDoan_id = LCongDoan_id
                .MaMe = _MaMe
                .MaMe_id = Lmame_id
                .Mahang = Lmahang
                .Mahang_id = Lmahang_id
                .Mamau = Lmamau
                .Mamau_id = Lmamau_id
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_chung()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub


    Private Sub btnXacNhan_GioRa_Click(sender As Object, e As EventArgs) Handles btnXacNhan_GioRa.Click

        ShowModalForm_XacNhan_GioRa()
    End Sub


    Private Sub txtmame_scanner_TextChanged(sender As Object, e As EventArgs) Handles txtmame_scanner.TextChanged
        If Len(txtmame_scanner.Text) = 5 Then
            Call Filterdata_chung()
            '//
            Call Filterdata_LenhSanXuat()
        End If
    End Sub
#End Region

#Region "DO PH"
    Private Sub BtnDoPH_Click(sender As Object, e As EventArgs) Handles BtnDoPH.Click
        If CboCongDoan_PH.SelectedIndex = 0 Then Exit Sub
        XacNhan_DoPH()
    End Sub


    Private Sub XacNhan_DoPH()
        If Len(LID) = 0 Then Exit Sub
        Dim lenh As String = String.Empty
        Dim _QT_hientai As String = String.Empty
        'If MsgBox("Bạn có muốn xác nhận Giờ Bắt đầu?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xác Nhận Giờ Bắt Đầu") = MsgBoxResult.Yes Then
        Call Load_TimeServer()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(Lmame_id) + "' ")
        sbXMLString.Append("congdoan_id='" + ReplaceTextXML(LCongDoan_id) + "' ")
        sbXMLString.Append("doph='" + ReplaceTextXML(txtgiatri_min.Text) + "' ")
        sbXMLString.Append("nhietdo='" + ReplaceTextXML(txtgiatri_max.Text) + "' ")
        sbXMLString.Append("ghichu='" + ReplaceTextXML(CboCongDoan_PH.Text) + "' ")
        sbXMLString.Append("tenhinhanh='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlDoPH_UpSet_2021]", sbXMLString.ToString, "insert")
        IsChanged = dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_chung()
        '//
        Call Filterdata_LenhSanXuat()
    End Sub
#End Region


End Class