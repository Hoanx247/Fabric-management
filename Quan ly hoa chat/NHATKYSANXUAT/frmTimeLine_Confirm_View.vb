Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports DevComponents.AdvTree

Public Class frmTimeLine_Confirm_View
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
    Dim dt_nhomloi As DataTable
    '//
    Private _columnName As String = String.Empty
    Dim _ColorPick As String = String.Empty
    Private Lmamay As String = String.Empty
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
    Private Lphanloai_ngaydem As String = String.Empty
    Private intketqua As Integer = 0
    '//
    Private _GioVao As DateTime
    Private _GioKetThuc As DateTime
    Private _thoigian_toithieu As Int16 = 0
    Private IsSelected_Row As Boolean = False
    Private tpress As New Timer With {.Interval = 200}
    Private _IsFirst As Boolean = False
    Private Lsocay_phanme As Int16 = 0
    Private Lsocay_xuatmoc As Int16 = 0
    Private _HieuLuc_GioVao As Boolean = False
    '//
    Private Lnhomloi_id As String = String.Empty
    Private Lmacongdoan As String = String.Empty
    Private LMaCongDoan_Ketiep As String = String.Empty
    Private LMaCongNghe As String = String.Empty
    Private LMaCongNghe_dathuchien As String = String.Empty
    '//
    Public Property PhanLoai_NgayDem() As String
        Get
            Return Lphanloai_ngaydem
        End Get
        Set(ByVal value As String)
            Lphanloai_ngaydem = value
        End Set
    End Property
    Public Property MaMe_ID() As String
        Get
            Return Lmame_id
        End Get
        Set(ByVal value As String)
            Lmame_id = value
        End Set
    End Property
    Public Property congdoan_ID() As String
        Get
            Return LCongDoan_id
        End Get
        Set(ByVal value As String)
            LCongDoan_id = value
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
    Public Property Mamay() As String
        Get
            Return Lmamay
        End Get
        Set(ByVal value As String)
            Lmamay = value
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
    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
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
                                    ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing


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
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        '//

        With Super_Dgv
            .AllowDrop = True
            .PrimaryGrid.KeepRowsSorted = True
            .PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.SortAndReorder
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .PrimaryGrid.Caption.EnableMarkup = True
            .PrimaryGrid.Caption.Visible = True
            .PrimaryGrid.Caption.Text = "NHẬT KÝ CÔNG ĐOẠN: "
        End With
        With Super_Dgv_LenhSanXuat
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
        '//
        Load_NhomLoi()
        '//
        CboKetQua.SelectedIndex = 0
        '//
        Format_SuperGrid()
        '//
        Load_TimeServer()
        With dt1_F
            .Value = _TimeServer
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy HH:mm"
        End With
        With dt2_F
            .Value = _TimeServer
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy HH:mm"
        End With
    End Sub
    Private Sub Load_NhomLoi()
        dt_nhomloi = VpsXmlList_Load("", "", "maloi_kythuat")
        LoadDataToCombox(dt_nhomloi, cboLyDo, "nhomloi", True)
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'Call Check_administrator(Me.Name.ToString)
        If True = True Then
            With Super_Dgv_Info
                Dim stinfo As String = "<div>" & "<b><font size=""16""><font color=""BLACK"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<b><font size=""16""><font color=""BLACK""> {1} </font></font></b>" & "</div>"
                .PrimaryGrid.Caption.Text = String.Format(stinfo, "+ KHU VỰC: ", Lkhuvuc.ToUpper)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ NHÂN VIÊN: ", LNhanVien.ToUpper)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "======================", "")
                Add_Data()
                '////
            End With
            '//
            Call Filterdata_chung()
            _load_finish = True
        Else
            Me.Close()
        End If
    End Sub

#Region "LOAD TAT CA CONG DOAN ME"
    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            'ShowContextMenu(CtxFunction)
        Else
            If dgvr IsNot Nothing Then
                LMaCongNghe = dgvr.Cells("macongnghe_all").FormattedValue.ToString
                LMaCongNghe_dathuchien = dgvr.Cells("macongnghe_dathuchien").FormattedValue.ToString

                '//
                'Them <br/> để xuống dòng
                Dim stinfo As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<font size=""12""><font color=""Black""> {1} </font></font>"
                Dim stinfo_br As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo_br &= "<font size=""12""><font color=""Black""> {1} </font></font><br/>"
                '//

                Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                '////
                panel.Footer.Text = String.Format(stinfo_br, "+ 01: ", LMaCongNghe.ToUpper)
                panel.Footer.Text &= String.Format(stinfo, "+ 02: ", LMaCongNghe_dathuchien.ToUpper)

            Else
                Lmame = String.Empty
            End If

        End If
        _saveRowIndex = e.GridCell.RowIndex
        _columnName = panel.ActiveCell.GridColumn.Name
    End Sub

    Private Sub Filterdata_chung()
        _HieuLuc_GioVao = False
        '///
        Me.SuspendLayout()
        'Try
        'Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("phanloai_ngaydem='" + ReplaceTextXML(Lphanloai_ngaydem) + "' ")
        sbXMLString.Append("congdoan_id='" + ReplaceTextXML(LCongDoan_id) + "' ")
        'sbXMLString.Append("mamay='" + ReplaceTextXML(Lmamay) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_CongDoan_XacNhanVao_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '///
        Dim _condition As String = "mamay = '" & Lmamay & "'"
        Dim dataSource As Object = Nothing
        Dim rows() As DataRow = dt_local.Select(_condition)
        If rows.Count > 0 Then ' first check to see if the array has rows '
            dataSource = rows.CopyToDataTable() ' dt now exists and contains rows '
        Else
            dataSource = Nothing
        End If
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        panel.DataSource = dataSource
    End Sub
    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)

        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)

        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '//
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mame_ghep"), panel.Columns("intnhomhang")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirAscAsc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirAscAsc(sortCols))
        End If

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
        Dim stDonHang As String = "<div>" & "<b><font size=""16""><font color=""BLACK"">{0}</font></font></b>" 'ĐƠN HÀNG
        stDonHang &= "<b><font size=""16""><font color=""BLACK""> {1} </font></font></b>" & "</div>"
        Dim stMaHang As String = "<div>" & "<b><font size=""16""><font color=""BLACK"">{0}</font></font></b>" 'ĐƠN HÀNG
        stMaHang &= "<b><font size=""16""><font color=""Black""> {1} </font></font></b>" & "</div>"
        '//
        Dim inty As Int16 = 0
        IsSelected_Row = False
        For Each row As GridRow In panel.Rows
            If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                'Lsocay_phanme = row.Cells("socay_phanme").Value
                'Lsocay_xuatmoc = row.Cells("socay_xuatmoc").Value
                If IsDBNull(row.Cells("congdoan_ketiep").Value) = False Then
                    If row.Cells("congdoan_ketiep").Value = row.Cells("macongdoan").Value Then
                        _HieuLuc_GioVao = True
                        btnXacNhan_GioVao.Enabled = True
                    Else
                        _HieuLuc_GioVao = False
                        btnXacNhan_GioVao.Enabled = False
                        Exit For
                    End If
                End If

                '//
                If IsSelected_Row = False Then
                    If IsDBNull(row.Cells("thoigianvao").Value) = True AndAlso IsDBNull(row.Cells("thoigianra").Value) = True Then
                        _MaMe = row.Cells("mame").Value
                        _macongdoan = row.Cells("macongdoan").Value
                        LID = row.Cells("maid").Value
                        'LCongDoan_id = row.Cells("congdoan_id").Value
                        _thoigian_toithieu = row.Cells("thoigian_toithieu").Value
                        _MaMay = row.Cells("mamay").Value
                        'Lmamay_id = row.Cells("mamay_id").Value
                        'Lmame_id = row.Cells("mame_id").Value
                        '//
                        'Lmahang_id = row.Cells("mahang_id").Value
                        Lmahang = row.Cells("mahang").Value
                        'Lmamau_id = row.Cells("mamau_id").Value
                        Lmamau = row.Cells("mamau").Value
                        '//
                        _GioVao = Now
                        IsSelected_Row = True
                        '--
                        row.SetActive()
                        row.IsSelected = True
                        inty += 1
                        '//
                        btnXacNhan_GioRa.Enabled = False
                    ElseIf IsDBNull(row.Cells("thoigianvao").Value) = False AndAlso IsDBNull(row.Cells("thoigianra").Value) = True Then
                        '//
                        'Lmahang_id = row.Cells("mahang_id").Value
                        Lmahang = row.Cells("mahang").Value
                        'Lmamau_id = row.Cells("mamau_id").Value
                        Lmamau = row.Cells("mamau").Value
                        '//
                        'Lmamay_id = row.Cells("mamay_id").Value
                        'Lmame_id = row.Cells("mame_id").Value
                        _MaMe = row.Cells("mame").Value
                        _macongdoan = row.Cells("macongdoan").Value
                        LID = row.Cells("maid").Value
                        _GioVao = row.Cells("thoigianvao").Value
                        _thoigian_toithieu = row.Cells("thoigian_toithieu").Value
                        '//
                        'LCongDoan_id = row.Cells("congdoan_id").Value
                        '_MaMay = row.Cells("mamay").Value
                        '///
                        dt1_F.Value = row.Cells("thoigianvao").FormattedValue
                        txtthoigian_toithieu.Text = row.Cells("thoigian").FormattedValue
                        '--
                        IsSelected_Row = True
                        row.SetActive()
                        row.IsSelected = True
                        '//
                        btnXacNhan_GioRa.Enabled = True
                    End If
                    '//
                    Filterdata_ThietBi()
                    '//
                    Super_Dgv_Info.PrimaryGrid.Caption.Text = String.Format(stDonHang, "+ KHU VỰC: ", KhuVuc.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ NHÂN VIÊN: ", NhanVien.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "======================", "")
                    '////
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stDonHang, "+ ĐƠN HÀNG: ", "")
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ MÃ HÀNG: ", "")
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ LOẠI HÀNG: ", "")
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ MÀU: ", "")
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ MẺ: ", "")
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ SỐ CÂY: ",
                                                     Lsocay_phanme & " - " & Lsocay_xuatmoc)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "======================", "")
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ TÊN MÁY: ", _MaMay.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ CÔNG ĐOẠN: ", _macongdoan.ToUpper)
                    Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ T.GIAN: ", _thoigian_toithieu.ToString.ToUpper)
                    '//
                    'Add_Data()
                    If row.Cells("ketqua").Value = 2 Then
                        'Exit For
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
        sbXMLString.Append("mamay='" + ReplaceTextXML(Lmamay) + "' ")
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
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_NhatKy_DoPH]", sbXMLString.ToString, "select")
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

    Private Sub btnXacNhan_GioRa_Click(sender As Object, e As EventArgs) Handles btnXacNhan_GioRa.Click

    End Sub
    Private Sub UpdateDetails_XacNhan_GioRa(ByVal rows As IEnumerable(Of GridElement))
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_XacNhan_GioRa(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                    If Len(row.Cells("mame").Value.ToString) > 2 Then
                        '//
                        sbXMLString.Append("<DATA ")
                        sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                        sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                        sbXMLString.Append("nv_id='" + ReplaceTextXML(LNV_ID) + "' ")
                        sbXMLString.Append("ketqua='" + CNumber_system(intketqua) + "' ")
                        sbXMLString.Append("danhgia='" + ReplaceTextXML(cboLyDo.Text) + "' ")
                        sbXMLString.Append("thoigianra='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
                        sbXMLString.Append("nhomloi_id='" + ReplaceTextXML(Lnhomloi_id) + "' ")
                        sbXMLString.Append("sophieu_loikythuat='" + ReplaceTextXML("") + "' ")
                        sbXMLString.Append("ghichu_loikythuat='" + ReplaceTextXML(cboLyDo.Text) + "' ")
                        sbXMLString.Append("congdoan_loikythuat='" + ReplaceTextXML(_macongdoan) + "' ")
                        sbXMLString.Append(" />")
                    End If

                End If
            End If
        Next
    End Sub



    Private Sub CboKetQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboKetQua.SelectedIndexChanged

    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        Dim lenh As String = String.Empty
        Dim _QT_hientai As String = String.Empty
        If CInt(txtthoigian_toithieu.Text) < 15 Then
            txtthoigian_toithieu.Text = 15
        End If

        'If MsgBox("Bạn có muốn xác nhận Giờ Bắt đầu?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xác Nhận Giờ Bắt Đầu") = MsgBoxResult.Yes Then
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_XacNhan_GioVao(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet_2021]", sbXMLString.ToString, "update_giovao")
        IsChanged = dtControler.UPSET_XML(_dt)
    End Sub
    Private Sub UpdateDetails_XacNhan_GioVao(ByVal rows As IEnumerable(Of GridElement))
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_XacNhan_GioVao(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                    If Len(row.Cells("mame").Value.ToString) > 2 Then
                        '//
                        sbXMLString.Append("<DATA ")
                        sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                        sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                        sbXMLString.Append("nv_id='" + ReplaceTextXML(LNV_ID) + "' ")
                        sbXMLString.Append("ketqua='" + CNumber_system(intketqua) + "' ")
                        sbXMLString.Append("danhgia='" + ReplaceTextXML(cboLyDo.Text) + "' ")
                        sbXMLString.Append("thoigianvao='" + Format$(dt1_F.Value, "MM/dd/yyyy HH:mm") + "' ")
                        sbXMLString.Append("thoigian='" + CNumber_system(txtthoigian_toithieu.Text) + "' ")
                        sbXMLString.Append("nhomloi_id='" + ReplaceTextXML(Lnhomloi_id) + "' ")
                        sbXMLString.Append("sophieu_loikythuat='" + ReplaceTextXML("") + "' ")
                        sbXMLString.Append("ghichu_loikythuat='" + ReplaceTextXML(cboLyDo.Text) + "' ")
                        sbXMLString.Append("congdoan_loikythuat='" + ReplaceTextXML(_macongdoan) + "' ")
                        sbXMLString.Append(" />")
                    End If

                End If
            End If
        Next
    End Sub
End Class