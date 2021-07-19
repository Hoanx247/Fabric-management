Imports DevComponents.Schedule.Model
Imports DevComponents.Schedule
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Schedule
Imports System
Imports System.Collections.Generic

Imports System.Text
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Public Class frmTimeLine_CongDoan_GioRa
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    '//
    Dim dt_khuvuc As DataTable
    Dim dt_local As DataTable
    Dim dt_nhomloi As DataTable
    Private dr0 As DataRow()
    '///
    Private _UserStyleSet As Boolean
    Private _blnHide As Boolean = False
    Dim _dtStart As DateTime
    Private defUsers As String() '= New String() {"Jet 1", "Jet 2", "Jet 3", "Jet 4"}
    Private allUsers As String() = New String() {"Charlie", "Cheryl", "Denis",
    "Fred", "Grover", "Robert", "Sue", "Winnie", "Whitney"}
    Dim _intTime_Auto As Integer = 0
    Dim _Time_old As Integer = 0
    Dim aColor_chuacang As Color = Color.White
    Dim aColor_dacang As Color = Color.Green
    Dim aColor_MeCangLai As Color = Color.Yellow
    Dim aColor_MeLoi As Color = Color.Red
    Private ti As New TimeIndicator()
    Private IsBusy As Boolean = False
    Private LNV_ID As String = String.Empty
    '//
    Private moClsReadFile As ClsReadFile
    Private cls As Clsconnect
    Private moClsEncrypt As ClsEncrypt
    '//
    Private isActive As Boolean = False
    Private IsChanged As Boolean = False
    '//
    Private _Model As New CalendarModel()
    Private Lkhuvuc_id As String = String.Empty
    Private Lnhomloi_id As String = String.Empty
    Private LID As String = String.Empty
    Dim dr2 As DataRow()
    Private Lmamay_id As String = String.Empty
    Private LCongDoan_id As String = String.Empty
    Private Lmame_id As String = String.Empty
    Private Lmahang_id As String = String.Empty
    Private Lmahang As String = String.Empty
    Private Lmamau_id As String = String.Empty
    Private Lmamau As String = String.Empty
    Private Lmame As String = String.Empty
    Private Lmacongdoan As String = String.Empty
    Private Lmamay As String = String.Empty
    Private intketqua As Int16 = 0
    '//
    Dim _List_Data As String() = {}
    Dim strData As List(Of String) = _List_Data.ToList()
    Private tpress As New Timer With {.Interval = 200}
    Private _IsFirst As Boolean = False
    '//
#Region "BIEN"
    Public Property MaID() As String
        Get
            Return LID
        End Get
        Set(ByVal value As String)
            LID = value
        End Set
    End Property
    Public Property MaMay_ID() As String
        Get
            Return Lmamay_id
        End Get
        Set(ByVal value As String)
            Lmamay_id = value
        End Set
    End Property
    Public Property MaCongDoan() As String
        Get
            Return Lmacongdoan
        End Get
        Set(ByVal value As String)
            Lmacongdoan = value
        End Set
    End Property
    Public Property MaCongDoan_id() As String
        Get
            Return LCongDoan_id
        End Get
        Set(ByVal value As String)
            LCongDoan_id = value
        End Set
    End Property
    Public Property MaMe() As String
        Get
            Return Lmame
        End Get
        Set(ByVal value As String)
            Lmame = value
        End Set
    End Property
    Public Property MaMe_id() As String
        Get
            Return Lmame_id
        End Get
        Set(ByVal value As String)
            Lmame_id = value
        End Set
    End Property
    '//
    Public Property Mahang_id() As String
        Get
            Return Lmahang_id
        End Get
        Set(ByVal value As String)
            Lmahang_id = value
        End Set
    End Property
    Public Property Mahang() As String
        Get
            Return Lmahang
        End Get
        Set(ByVal value As String)
            Lmahang = value
        End Set
    End Property
    Public Property Mamau_id() As String
        Get
            Return Lmamau_id
        End Get
        Set(ByVal value As String)
            Lmamau_id = value
        End Set
    End Property
    Public Property Mamau() As String
        Get
            Return Lmamau
        End Get
        Set(ByVal value As String)
            Lmamau = value
        End Set
    End Property
#End Region


    Private Sub Me_FormClosing(ByVal sender As Object,
                                    ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                    Handles Me.FormClosing

        If IsChanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        '///
        Me.Dispose()

    End Sub
    Private Sub frmTimeLine_CongDoan_GioVao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        '//
        With dtNgayXacNhanRa
            .Value = Now
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy HH:mm"
        End With
        '//
        dt_local = New DataTable
        dt_nhomloi = New DataTable
        '//
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)

        With Super_Dgv
            .AllowDrop = True
            .PrimaryGrid.KeepRowsSorted = False
            .PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .PrimaryGrid.Caption.EnableMarkup = True
            .PrimaryGrid.Caption.Visible = True
            .PrimaryGrid.Caption.Text = "DANH SÁCH MẺ CÙNG MÃ MÀU: "
        End With
        With Super_Dgv_CongDoan
            .AllowDrop = True
            .PrimaryGrid.KeepRowsSorted = False
            .PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .PrimaryGrid.Caption.EnableMarkup = True
            .PrimaryGrid.Caption.Visible = True
            .PrimaryGrid.Caption.Text = "CÔNG ĐOẠN MẺ NHUỘM"
        End With
        '//
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '///
        AddHandler Super_Dgv_CongDoan.DataBindingComplete, AddressOf Super_Dgv_CongDoan_DataBindingComplete

        '//
        Load_NhomLoi()
        '//
        CboKetQua.SelectedIndex = 0
    End Sub
    Private Sub Load_NhomLoi()
        dt_nhomloi = VpsXmlList_Load("", "", "maloi_kythuat")
        LoadDataToCombox(dt_nhomloi, cboLyDo, "nhomloi", True)
    End Sub
    Private Sub frmTimeLine_CongDoan_GioRa_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        '//
        Call Filterdata_chung()
        '//
        Call Filterdata_Congdoan()
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
        sbXMLString.Append("mahang_id='" + ReplaceTextXML(Lmahang_id) + "' ")
        sbXMLString.Append("mamau_id='" + ReplaceTextXML(Lmamau_id) + "' ")
        sbXMLString.Append("congdoan_id='" + ReplaceTextXML(LCongDoan_id) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_CongDoan_MaHang]", sbXMLString.ToString, "select")
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
        Dim stDonHang As String = "<div>" & "<b><font size=""16""><font color=""BLACK"">{0}</font></font></b>" 'ĐƠN HÀNG
        stDonHang &= "<b><font size=""16""><font color=""BLACK""> {1} </font></font></b>" & "</div>"
        Dim stMaHang As String = "<div>" & "<b><font size=""16""><font color=""BLACK"">{0}</font></font></b>" 'ĐƠN HÀNG
        stMaHang &= "<b><font size=""16""><font color=""Black""> {1} </font></font></b>" & "</div>"
        '//
        Dim inty As Int16 = 0

    End Sub

#End Region

#Region "LOAD TAT CA CONG DOAN ME"
    Private Sub Filterdata_Congdoan()
        Me.SuspendLayout()
        'Try
        'Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame='" + ReplaceTextXML(Lmame) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_NhatKy_CongDoan_view_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML(_dt, Super_Dgv_CongDoan.PrimaryGrid)
    End Sub
    Private Sub Super_Dgv_CongDoan_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
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
    End Sub

#End Region

#Region "XAC NHAN GIO RA"

    Private Sub btnXacNhan_GioVao_Click(sender As Object, e As EventArgs) Handles btnXacNhan_GioVao.Click
        If CboKetQua.SelectedIndex = 1 AndAlso cboLyDo.SelectedIndex = 0 Then
            MsgBox("Vui lòng chọn lỗi.", MsgBoxStyle.Exclamation, "Thông Báo!")
            Exit Sub
        End If
        '//
        dr0 = dt_nhomloi.Select("nhomloi = '" & cboLyDo.Text & "'", "")
        If dr0.Length > 0 Then
            Lnhomloi_id = dr0.First.Item("nhomloi_id")
        Else
            Lnhomloi_id = "NL00"
        End If
        '//
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
        sbXMLString.Append("mame_id='" + ReplaceTextXML(Lmame_id) + "' ")
        sbXMLString.Append("nv_id='" + ReplaceTextXML(LNV_ID) + "' ")
        sbXMLString.Append("ketqua='" + CNumber_system(intketqua) + "' ")
        sbXMLString.Append("danhgia='" + ReplaceTextXML(cboLyDo.Text) + "' ")
        sbXMLString.Append("thoigianra='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
        sbXMLString.Append("nhomloi_id='" + ReplaceTextXML(Lnhomloi_id) + "' ")
        sbXMLString.Append("sophieu_loikythuat='" + ReplaceTextXML(txtsophieu_LKT.Text) + "' ")
        sbXMLString.Append("ghichu_loikythuat='" + ReplaceTextXML(cboLyDo.Text) + "' ")
        sbXMLString.Append("congdoan_loikythuat='" + ReplaceTextXML(Lmacongdoan) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        If CboKetQua.SelectedIndex = 0 Then
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet_2021]", sbXMLString.ToString, "update_giora_dat")
        Else
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet_2021]", sbXMLString.ToString, "update_giora_khongdat")
        End If
        IsChanged = dtControler.UPSET_XML(_dt)
        Me.Close()
    End Sub

    Private Sub BtnExit_CapNhat_Click(sender As Object, e As EventArgs) Handles BtnExit_CapNhat.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub CboKetQua_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboKetQua.SelectedIndexChanged
        If CboKetQua.SelectedIndex = 0 Then
            cboLyDo.SelectedIndex = 0
            cboLyDo.Enabled = False
            intketqua = 1
        ElseIf CboKetQua.SelectedIndex = 1 Then
            cboLyDo.Enabled = True
            intketqua = 2
        End If
    End Sub



#End Region

End Class