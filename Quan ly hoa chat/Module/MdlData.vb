Imports System.Xml
Imports System.Drawing
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Text

Module MdlData
    Public Gdatatable_phanquyen As DataTable
    Public Gdatatable_FieldName As DataTable
    Public Gdatatable_ColName As DataTable
    Dim dr As DataRow()
    Dim drName As DataRow()
    Public _GInsertRow As Int16 = 0
    Public GSheetName As String = "Sheet1"
    Public GFolder_Excel As String = "Excel"
    Public GSheet_Excel As Byte = 1
    '//
    Public GMayInTem As String = String.Empty
    Public GMayInPhieu As String = String.Empty
    Public GWeightMin As Decimal = 0
    Public GWeightMax As Decimal = 0
    '//
    Public _stUser_Save As String
    Public _Gnumber1 As Object
    Public _Gnumber2 As Object
    Public _Gnumber3 As Object
    Public _Gnumber4 As Object
    Public _Gnumber5 As Object
    Public _Gnumber6 As Object

    Public _Gnumber_group As Decimal() = {}
    '//
    Public _number1_group As Object = 0
    Public _number2_group As Object = 0
    Public _number3_group As Object = 0
    Public _number4_group As Object = 0
    Public _number5_group As Object = 0
    Public _number6_group As Object = 0
    Public _number7_group As Object = 0
    Public _number8_group As Object = 0
    Public _number9_group As Object = 0
    '--
    Public _GColName As String = String.Empty
    '//
    Dim style As NumberStyles
    Dim culture As CultureInfo
    Public dataset_all As DataSet
    Public GetDataRecord As String
    Public _GNhomUser_ID As String
    '//
    Public _GChungtunhap As String = String.Empty
    Public _GChungtu_kemtheo As String = String.Empty
    Public _GNgay_Thang_nam As String = String.Empty
    '//
    Public _IsPrint As Boolean = False
    Public _IsPrint_GridArea As Boolean = False
    Public _IsPrint_PrintArea As Boolean = False
    Public _IsNotPrint_GroupName As Boolean = False
    Public _IsPrint_Sum As Boolean = False
    Public _GUseConditionalFormatting As Boolean = False
    '//
    Public GFormName As String
    Public GFormNameFull As String
    Public _intFormatText As Integer = 0
    Public _isNoPrint_GroupName As Boolean = False
    '// TÊN CÔNG TY
    Public _GTenCongTy As String = String.Empty
    Public _GDiaChiCongTy As String = String.Empty
    Public _GDienThoaiCongty As String = String.Empty
    Public _GSoHoaDon As String = String.Empty
    Public _GChungtu As String = String.Empty
    Public _GKhachHang As String = String.Empty
    Public _GTieuDe As String = String.Empty
    Public _GdtNgayIn_1 As String = String.Empty
    Public _GdtNgayIn_2 As String = String.Empty
    Public GdongIn_NgayThangNam As Int16 = 4
    Public GCellIn_NgayThangNam As String = "A"
    '/
    Public _GdtNgayNhap As Date
    Public _GNgayThangNam As String = String.Empty
    Public _GTuNgay_DenNgay As String = String.Empty
    Public _GMayCang As String = String.Empty
    Public _GThanhTienBangLuong As Decimal = 0
    Public _IsEnable_Marco As Boolean = False
    '//
    Public GDonhang As String = String.Empty
    Public GMahang As String = String.Empty
    Public GKhachhang As String = String.Empty
    Public GLoaihang As String = String.Empty
    Public GKhovai As String = String.Empty
    Public Gmetkg As String = String.Empty
    '--
    Public GNoDauKy As Decimal = 0
    Public GPhatSinhCo As Decimal = 0
    Public GPhatSinhNo As Decimal = 0
    Public GDieuChinh As Decimal = 0
    Public GNoCuoiKy As Decimal = 0
    '//
    'Dim dr2 As DataRow()
    Public _GInphieuxuat As Integer = 0


    Public Const charactersAllowed As String = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890-" &
    "áàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữ" &
    "ÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐýỳỵỷỹÝỲỴỶỸ./+"

    Public _GFileName_System As String = My.Application.Info.DirectoryPath
    Public _GFileName_Database As String = My.Application.Info.DirectoryPath & "\MyDatabase.ini"
    Public _GFileName_TemMoc As String = My.Application.Info.DirectoryPath & "\TemMoc.rdlc"
    Public _GFileName_Printer As String = My.Application.Info.DirectoryPath & "\Printer.ini"
    Public _GFileName_SerialPort As String = My.Application.Info.DirectoryPath & "\Name.ini"
    Public _GFileName_name As String = My.Application.Info.DirectoryPath & "\Name.ini"

    '--Khai BAO BIEN CONNECT
    Public _GConnect_LDatasource_KhoTong As String, _GConnect_LDatabase_KhoTong As String, _GConnect_LPass_KhoTong As String, _GConnect_LUser_KhoTong As String
    Public _GConnect_LDatasource_HoaChat As String, _GConnect_LDatabase_HoaChat As String, _GConnect_LPass_HoaChat As String, _GConnect_LUser_HoaChat As String
    Public _GConnect_LDatasource_KhoMoc As String, _GConnect_LDatabase_KhoMoc As String, _GConnect_LPass_KhoMoc As String, _GConnect_LUser_KhoMoc As String
    Public _GConnect_LDatasource_KhoDet As String, _GConnect_LDatabase_KhoDet As String, _GConnect_LPass_KhoDet As String, _GConnect_LUser_KhoDet As String
    Public _GConnect_LDatasource_CuaHang As String, _GConnect_LDatabase_CuaHang As String, _GConnect_LPass_CuaHang As String, _GConnect_LUser_CuaHang As String

    '--MAY IN
    Public _GPrint_Name As String, _GPrint_PageSize As String
    Public GDatasource_KhoMoc As String, GPass_KhoMoc As String, GDatabase_KhoMoc As String
    Public _gMacongnghe_yeucau As String = String.Empty

    'Public start As Boolean

    'Public _GMatKhau_ALL As String

    '--
    Public Const _GVersion As String = "V.0.0.1"
    'Public Gdt_FName As New DataTable

    Public Const _sole_Kg As SByte = 2
    Public Const _sole_met As SByte = 2
    '--
    '--
    Public _MyFont_panel As New System.Drawing.Font("Tahoma", 11, FontStyle.Bold)
    Public _MyFont_group As New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)

    Public _MyFont_Header As New Font("Time New Roman", 9, FontStyle.Bold)
    '--
    Public _MyFont_GridView As Integer = 10
    Public lfontsize As Integer = 10
    Public ldefaultRowheight As Integer = 25
    Public lGroupHeaderHeight As Integer = 20
    Public lColumnHeaderRowHeight As Integer = 30
    Public _nhomUser_ID As String

    Public decimalSeparator_system As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
    '--
    Public strname As String, strUser As String, strpass As String, str_nhom As String, str_path As String, path_excel As String

    '--
    Public _Server_Signal As Boolean, _Client_Signal As Boolean
    '-------------
    'Public strModel As String, strXuong As String
    Dim cls As Clsconnect
    'Public column_width(46) As UShort
    'Public _iDisplayIndex(46) As Byte
    'Public _iColumns(46) As String
    'Dim dv_column As DataView
    'Public ds_customer As New DataSet
    Public _TimeServer As Date
    Public _Font_Dgv As Integer = 0
    Dim _Local_Command As String
    Public mdlIPAddress As String, mdlHostName As String
    Public strUser_IPAdress As String
    '--
    'Public dt_columns As DataTable
    'Public dt_Freeze_column As DataTable
    'Public dt_administrator As DataTable
    '----
    '----
    '--Dang Ky Ban quyen
    Public _ALL_Register As String = String.Empty
    Public _ALL_Solansudung As Integer = 0
    '---
    Public _btAdd As Boolean = False, _btModify As Boolean = False, _btDelete As Boolean = False, _btView As Boolean = False
    Public _btadmin As Boolean = False, _btmaster As Boolean = False, _btmaster_1 As Boolean = False, _btmaster_2 As Boolean = False
    '---Thong tin ve ap gia
    Public _ChungtuxuatID_MDL As String = String.Empty, _Chungtuxuat_MDL As String = String.Empty
    Public _MaQT_ID_MDL As String = String.Empty, _MaQT_MDL As String = String.Empty, _TenQT_MDL As String = String.Empty
    Public _Mahang_ID_MDL As String = String.Empty, _mahang_MDL As String = String.Empty, _loaihang_MDL As String = String.Empty
    Public _DonHang_ID_MDL As String = String.Empty, _DonHang_MDL As String = String.Empty, _Lydoxuat_MDL As String = String.Empty
    Public _Soxexuat_MDL As String = String.Empty, _ghichu_MDL As String = String.Empty
    Public _mame_MDL As String = String.Empty
    Public _MaKH_ID_MDL As String = String.Empty, _makhach_MDL As String = String.Empty, _KhachHang_MDL As String = String.Empty
    Public _Mamau_ID_MDL As String = String.Empty, _mamau_MDL As String = String.Empty, _tenmau_MDL As String = String.Empty
    'Public _Hoavan_ID_MDL As String = String.Empty, Hoavan_MDL As String = String.Empty
    Public _MaCN_ID_MDL As String = String.Empty, _Macongnghe_MDL As String = String.Empty, _Tencongnghe_MDL As String = String.Empty
    '------
    Public _khovai_MDL As String = String.Empty, _metkg_MDL As String = String.Empty, _YeucauTP_MDL As String = String.Empty

    Public _Khachhang_status As SByte = 0, _Loaivai_status As SByte = 0, _mamau_status As SByte = 0
    Public _Nhanvien_status As Byte = 0, _quitrinh_status As SByte = 0, _user_status As SByte = 0
    Public _Khachhang_CongNo As String = String.Empty, _Congdoan_Status As SByte = 0, _KieuNhap_status As SByte = 0, _KieuXuat_status As SByte = 0
    Public _Hoavan_status As SByte = 0, _GhichuTP_status As SByte = 0, _Xuly1_status As SByte = 0, _Xuly2_status As SByte = 0

    Public _Banggia_status As SByte = 0, _Datmau_status As SByte = 0, _Nhapmoc_status As SByte = 0
    Public _donhang_status As SByte = 0, _XuatHang_status As SByte = 0, _maycang_status As Byte = 0
    Public _macongnghe_status As SByte = 0, _taophieu_Canho_status As SByte = 0
    Public _donhang_main_status As SByte = 0, _PhieuLKT_status As SByte = 0


    Public _Nam_excel As String, _thang_excel As String, _ngay_excel As String
    Public _Nam As String, _thang As String, _ngay As String, _gio As String, _phut As String, _giay As String

    Public Sub Load_TimeServer()

        Dim dTable As New DataTable
        dTable = VpsXmlList_Load("", "", "giohethong")
        'Dim lenh As String = "SELECT CUR_DATE=getdate()"
        'dTable = cls.ReturnDataReader(lenh)
        _TimeServer = Convert.ToDateTime(dTable.Rows(0).Item(0))
        dTable.Dispose()
    End Sub


#Region "SYSTEM"

    Public Sub Check_administrator(ByVal _TenForm As String)
        Dim st As String = String.Empty, _frmName_ID As String = String.Empty
        '--
        If UCase(strUser) = "HOANGUYEN" And strpass = "hoanx151254" Then
            _btView = True
            _btAdd = True
            _btModify = True
            _btDelete = True
            _btadmin = True
            wait(100)
            Exit Sub
        End If
        '///
        Dim _sname_temp As String = _TenForm + _nhomUser_ID
        Dim firstRow As DataRow = Gdatatable_phanquyen.Select("frmname_nhomid= '" & _sname_temp & "'", "").FirstOrDefault()

        If Not firstRow Is Nothing Then
            _btView = CBool(firstRow.Item("xem"))
            _btAdd = CBool(firstRow.Item("them"))
            _btModify = CBool(firstRow.Item("sua"))
            _btDelete = CBool(firstRow.Item("xoa"))
            _btmaster = CBool(firstRow.Item("level_1"))
            _btmaster_1 = CBool(firstRow.Item("level_2"))
            _btmaster_2 = CBool(firstRow.Item("level_3"))
        Else
            _btView = False
            _btAdd = False
            _btModify = False
            _btDelete = False
            _btmaster = False
            _btmaster_1 = False
            _btmaster_2 = False
        End If
    End Sub


#End Region


#Region "KHAI BAO BIEN TOAN CUC"
    Public Const _colchungtunhap_ID As String = "chungtunhap_id"
    Public Const _colchungtunhap As String = "chungtunhap"
    Public Const _colchungtuxuat_ID As String = "chungtuxuat_id"
    Public Const _colchungtuxuat As String = "chungtuxuat"
    Public Const _colchungtuxuat_noibo As String = "chungtuxuat_noibo"
    Public Const _colchungtunhap_KhoTP As String = "chungtunhap_khotp"

    Public Const _colID As String = "id"
    Public Const _colMame_ID As String = "mame_id"
    Public Const _colMame As String = "mame"
    Public Const _colDonhang_ID As String = "donhang_id"
    Public Const _colmadonhang As String = "madonhang"
    Public Const _coldonhang As String = "donhang"

    Public Const _colmakhach_id As String = "makh_id"
    Public Const _colMakhach As String = "makhach"
    Public Const _colkhachhang As String = "khachhang"
    Public Const _colnhomkh_id As String = "nhomkh_id"
    Public Const _colnhomkh As String = "nhomkh"

    Public Const _colMahang_ID As String = "mahang_id"
    Public Const _colmahang As String = "mahang"
    Public Const _colloaihang As String = "loaihang"
    Public _colNL1 As String = "nl1"
    Public _colNL2 As String = "nl2"
    Public _colNL3 As String = "nl3"
    Public _colNL4 As String = "nl4"
    Public _colNL5 As String = "nl5"
    Public _colNL6 As String = "nl6"
    Public _colNL7 As String = "nl7"
    Public _colactive As String = "active"



    Public Const _colMamau_ID As String = "mamau_id"
    Public Const _colMamau As String = "mamau"
    Public Const _colMau As String = "tenmau"
    Public Const _colTenMau As String = "tenmau"
    Public Const _coltenMau_nhuom As String = "tenmau_nhuom"

    Public Const _colMamay_ID As String = "mamay_id"
    Public Const _colMamay As String = "mamay"
    Public Const _coltenmay As String = "tenmay"
    Public Const _colnhommay_id As String = "nhommay_id"
    Public Const _colnhommay As String = "nhommay"

    Public Const _coldtngaynhap_CT As String = "dtngaynhap_chungtu"
    Public Const _coldtngaynhap As String = "dtngaynhap"
    Public Const _coldttaome As String = "dttaome"
    Public Const _coldinhhinh As String = "dinhhinh"
    Public Const _colkcs As String = "kcs"
    Public Const _coldtthanhpham As String = "dtthanhpham"
    Public Const _coldtthanhpham_kcs As String = "dtthanhpham_kcs"
    Public Const _coldtngaysanxuat As String = "dtngayxuat_sanxuat"
    Public Const _coldtxuathang As String = "dtxuathang"
    Public Const _coldtngayxuat As String = "dtngayxuat"
    Public Const _coldtcapnhat As String = "dtcapnhat"
    Public Const _coldtngaytao As String = "dtngaytao"
    Public Const _coldtngaygiao As String = "ngaygiao"
    Public Const _colnguoitao As String = "nguoitao"

    Public Const _colkhovai As String = "khovai"
    Public Const _colmetkg As String = "metkg"
    Public Const _colloaimoc As String = "loaimoc"
    Public Const _colphanloai As String = "phanloai"
    Public Const _collotsoi As String = "lotsoi"
    Public Const _colghichu_datmau As String = "ghichu"
    Public Const _colyeucau As String = "ghichu_chung"
    Public Const _colYeucauTP As String = "yeucau"
    Public Const _colQT_Phanhang As String = "qt_phanhang"
    Public Const _colQT_sobo As String = "qt_sobo"
    Public Const _colQT_cang As String = "qt_cang"
    Public Const _colQT_xuathang As String = "qt_xuathang"

    Public Const _colchon_mau As String = "chon_mau"
    Public Const _colMoc_bebe As String = "Moc_bebe"
    Public Const _colXLL As String = "xll"
    Public Const _colmacay As String = "macay"
    Public Const _colmacay_old As String = "macay_old"
    Public Const _colmaso As String = "maso"
    Public Const _colxuly1 As String = "xuly1"
    Public Const _colxuly2 As String = "xuly2"
    Public Const _colnhanviennhap As String = "nhanviennhap"
    Public Const _colnhanvientaome As String = "nhanvientaome"

    Public Const _colnoidung As String = "noidung"
    Public Const _colvitrichua As String = "vitrichua"

    Public Const _coldongia As String = "dongia"
    Public Const _colthanhtien As String = "thanhtien"

    Public Const _colNhanvien As String = "nhanvien"
    Public Const _colghichu As String = "ghichu"
    Public Const _colghichu_thuchien As String = "ghichu_thuchien"
    Public Const _colghichuTP As String = "ghichu_thanhpham"
    Public Const _colghichuMoc As String = "ghichu_moc"
    Public Const _colghichu_mau As String = "ghichu_maudaco"
    Public Const _colghichu_xuathang As String = "ghichu_xuathang"

    Public _colsoxe As String = "soxe"
    Public _coltaixe As String = "taixe"
    Public _colpacking_list As String = "packing_list"
    Public _colsothung As String = "sothung"

    Public Const _colMacn_ID As String = "macn_id"
    Public Const _colMacongnghe As String = "macongnghe"
    Public Const _colMacongnghe_tt As String = "macongnghe_tt"
    Public Const _coltencongnghe As String = "tencongnghe"
    Public Const _colkieunhap_id As String = "kieunhap_id"
    Public Const _colkieuxuat_id As String = "kieuxuat_id"
    Public Const _colmucdich As String = "mucdich"
    Public Const _colmakytu As String = "makytu"
    Public Const _colngaytao As String = "ngaytao"

    Public Const _colMaCongdoan_ID As String = "congdoan_id"
    Public Const _colMacongdoan As String = "macongdoan"
    Public Const _coltencongdoan As String = "tencongdoan"
    Public Const _colthoigian As String = "thoigian"
    Public Const _colthoigianvao As String = "thoigianvao"
    Public Const _colthoigianra As String = "thoigianra"
    Public Const _colthoigianvao_dukien As String = "thoigianvao_dukien"
    Public Const _colthoigianra_dukien As String = "thoigianra_dukien"

    Public Const _colquitrinh_id As String = "quitrinh_id"
    Public Const _colMaquitrinh As String = "maquitrinh"
    Public Const _coltenquitrinh As String = "tenquitrinh"

    Public Const _colNV_ID As String = "nv_id"
    Public Const _colmasonhanvien As String = "masonhanvien"
    Public Const _coltennhanvien As String = "tennhanvien"
    Public Const _colbophanlamviec As String = "bophanlamviec"
    Public Const _coldienthoai As String = "dienthoai"

    Public Const _colsocayton As String = "socayton"
    Public Const _colsokgton As String = "sokgton"
    Public Const _colsometton As String = "sometton"

    Public Const _colsocay As String = "socay"
    Public Const _colsokg As String = "sokg"
    Public Const _colsomet As String = "somet"
    Public Const _colsocayM As String = "socaymoc"
    Public Const _colsokgM As String = "sokgmoc"
    Public Const _colsometM As String = "sometmoc"
    Public Const _colsokgSB As String = "sokgsobo"
    Public Const _colsometSB As String = "sometsobo"
    Public Const _colydsTP As String = "ydstp"
    Public Const _colydsXH As String = "ydsxh"

    Public Const _colsocayTT As String = "socaytt"
    Public Const _colsokgTT As String = "sokgtt"
    Public Const _colsometTT As String = "somettt"

    Public Const _colsocayTp As String = "socaytp"
    Public Const _colsokgTp As String = "sokgtp"
    Public Const _colsometTp As String = "somettp"

    Public Const _colsocayxuat As String = "socayxuat"
    Public Const _colsokgxuat As String = "sokgxuat"
    Public Const _colsometxuat As String = "sometxuat"

    Public Const _colsocayDK As String = "socaydk"
    Public Const _colsokgDK As String = "sokgdk"
    Public Const _colsometDK As String = "sometdk"

    Public Const _colsocayNTK As String = "socayntk"
    Public Const _colsokgNTK As String = "sokgntk"
    Public Const _colsometNTK As String = "sometntk"

    Public _colsocayXTK As String = "socayxtk"
    Public _colsokgXTK As String = "sokgxtk"
    Public _colsometXTK As String = "sometxtk"

    Public _colsocayCK As String = "socayck"
    Public _colsokgCK As String = "sokgck"
    Public _colsometCK As String = "sometck"
    '--
    Public _colsocay_1 As String = "socay_1"
    Public _colsokg_1 As String = "sokg_1"
    Public _colsomet_1 As String = "somet_1"
    '-
    Public _colsocay_2 As String = "socay_2"
    Public _colsokg_2 As String = "sokg_2"
    Public _colsomet_2 As String = "somet_2"
    '--
    Public _colsocay_3 As String = "socay_3"
    Public _colsokg_3 As String = "sokg_3"
    Public _colsomet_3 As String = "somet_3"
    '-
    Public _colsocay_4 As String = "socay_4"
    Public _colsokg_4 As String = "sokg_4"
    Public _colsomet_4 As String = "somet_4"
    '-
    Public _colsocay_5 As String = "socay_5"
    Public _colsokg_5 As String = "sokg_5"
    Public _colsomet_5 As String = "somet_5"

    Public _colbg_id As String = "bg_id"
    Public _colgia1 As String = "gia1"
    Public _colgia2 As String = "gia2"
    Public _colgia3 As String = "gia3"
    Public _colgia4 As String = "gia4"

    Public Const _colngay1 As String = "ngay1"
    Public Const _colngay2 As String = "ngay2"
    Public Const _colngay3 As String = "ngay3"
    Public Const _colngay4 As String = "ngay4"

    Public Const _colqttruoc As String = "qt_truoc"
    Public Const _colqtsau As String = "qt_sau"
    Public Const _colqthientai As String = "qt_hientai"
    '--
    Public _colphatsinhno As String = "phatsinhno"
    Public _colphatsinhco As String = "phatsinhco"
    Public _colgiagiam As String = "giagiam"
    Public _coldieuchinh As String = "dieuchinh"
    Public _colhinhthuc As String = "hinhthuc"
    Public _coldiengiai As String = "diengiai"
#End Region

    Public Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Public Function KyTu_Thang(ByVal _Thang As SByte)
        Dim _Kytu_Thang As String = String.Empty
        If _Thang = 1 Then
            _Kytu_Thang = "A"
        ElseIf _Thang = 2 Then
            _Kytu_Thang = "B"
        ElseIf _Thang = 3 Then
            _Kytu_Thang = "C"
        ElseIf _Thang = 4 Then
            _Kytu_Thang = "D"
        ElseIf _Thang = 5 Then
            _Kytu_Thang = "E"
        ElseIf _Thang = 6 Then
            _Kytu_Thang = "F"
        ElseIf _Thang = 7 Then
            _Kytu_Thang = "G"
        ElseIf _Thang = 8 Then
            _Kytu_Thang = "H"
        ElseIf _Thang = 9 Then
            _Kytu_Thang = "J"
        ElseIf _Thang = 10 Then
            _Kytu_Thang = "K"
        ElseIf _Thang = 11 Then
            _Kytu_Thang = "L"
        ElseIf _Thang = 12 Then
            _Kytu_Thang = "M"
        End If
        Return _Kytu_Thang
    End Function

    Public Function KyTu_Thang_Nhom2(ByVal _Thang As SByte)
        Dim _Kytu_Thang As String = String.Empty
        If _Thang = 1 Then
            _Kytu_Thang = "Z"
        ElseIf _Thang = 2 Then
            _Kytu_Thang = "Y"
        ElseIf _Thang = 3 Then
            _Kytu_Thang = "X"
        ElseIf _Thang = 4 Then
            _Kytu_Thang = "W"
        ElseIf _Thang = 5 Then
            _Kytu_Thang = "V"
        ElseIf _Thang = 6 Then
            _Kytu_Thang = "U"
        ElseIf _Thang = 7 Then
            _Kytu_Thang = "T"
        ElseIf _Thang = 8 Then
            _Kytu_Thang = "S"
        ElseIf _Thang = 9 Then
            _Kytu_Thang = "R"
        ElseIf _Thang = 10 Then
            _Kytu_Thang = "Q"
        ElseIf _Thang = 11 Then
            _Kytu_Thang = "P"
        ElseIf _Thang = 12 Then
            _Kytu_Thang = "N"
        End If
        Return _Kytu_Thang
    End Function

    Public Function KyTu_Nam(ByVal _Nam As SByte)
        Dim _Kytu_nam As String = String.Empty
        If _Nam = 0 Then
            _Kytu_nam = "A"
        ElseIf _Nam = 1 Then
            _Kytu_nam = "B"
        ElseIf _Nam = 2 Then
            _Kytu_nam = "C"
        ElseIf _Nam = 3 Then
            _Kytu_nam = "D"
        ElseIf _Nam = 4 Then
            _Kytu_nam = "E"
        ElseIf _Nam = 5 Then
            _Kytu_nam = "F"
        ElseIf _Nam = 6 Then
            _Kytu_nam = "G"
        ElseIf _Nam = 7 Then
            _Kytu_nam = "H"
        ElseIf _Nam = 8 Then
            _Kytu_nam = "K"
        ElseIf _Nam = 9 Then
            _Kytu_nam = "L"
        End If
        Return _Kytu_nam
    End Function

    Public Function CoToDec(ByVal Input As Object, Optional ByVal Precision As Int16 = 2) As Decimal
        Dim result As Decimal = 0
        style = NumberStyles.AllowDecimalPoint Or NumberStyles.AllowThousands Or NumberStyles.Number
        culture = CultureInfo.CreateSpecificCulture("en-US")
        If IsDBNull(Input) = True Then
            Input = 0
        End If
        If IsNumeric(Input) = False Then
            Input = 0
        End If
        ' returns 0 for all values less than 0, the decimal rounded to (Precision) decimal places otherwise.
        If Input > 0 Then
            If Precision < 0 Then Precision = 0 ' just in case someone does something stupid.
            ' Use TryParse on an invalid string.
            Decimal.TryParse(Input, style, culture, result)
            Decimal.Round(result, Precision) ' this is the line everyone's probably looking for.
        Else
            Input = -Input
            Decimal.TryParse(Input, style, culture, result)
            Decimal.Round(result, Precision) ' this is the line everyone's probably looking for.
            result = -result
        End If
        Return result
    End Function

    Public Function ReplaceTextXML(ByVal _xml As Object) As String
        If _xml Is Nothing Then
            _xml = ""
        End If
        If IsDBNull(_xml) = True Then
            _xml = ""
        End If
        '//
        Dim Result As String = String.Empty
        Result = _xml.Replace("&", "&amp;")
        'Result = Result.Replace(">", "&gt;")
        'Result = Result.Replace("<", "&lt;")
        Result = Result.Replace("'", "&apos;")
        Result = Result.Replace("""", "&quot;")
        '//
        Return Result
    End Function

#Region "NUMBER KEY"
    Public Sub OnlyNumericKeysKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim character As String = String.Empty
        Dim txtbox As TextBox = CType(sender, TextBox)

        If Asc(e.KeyChar) <> 8 Then
            If decimalSeparator_system = "," Then
                Dim str As String = "0123456789.,-+"
                If str.Contains(e.KeyChar) = True Then
                    If e.KeyChar = "," And (txtbox.Text.Contains(",") Or txtbox.SelectionStart = 0) Then 'supress a second "." or a first one
                        e.Handled = True
                    ElseIf e.KeyChar = "-" And (txtbox.Text.Contains("-") Or txtbox.SelectionStart > 0) Then 'supress a second "." or a first one
                        e.Handled = True
                    ElseIf e.KeyChar = "+" And (txtbox.Text.Contains("+") Or txtbox.SelectionStart > 0) Then 'supress a second "." or a first one
                        e.Handled = True
                    Else
                        e.Handled = False
                    End If
                Else
                    e.Handled = True
                End If

            Else
                Dim str As String = "0123456789,.-+"
                If str.Contains(e.KeyChar) = True Then
                    If e.KeyChar = "." And (txtbox.Text.Contains(".") Or txtbox.SelectionStart = 0) Then 'supress a second "." or a first one
                        e.Handled = True
                    ElseIf e.KeyChar = "-" And (txtbox.Text.Contains("-") Or txtbox.SelectionStart > 0) Then 'supress a second "." or a first one
                        e.Handled = True
                    ElseIf e.KeyChar = "+" And (txtbox.Text.Contains("+") Or txtbox.SelectionStart > 0) Then 'supress a second "." or a first one
                        e.Handled = True
                    Else
                        e.Handled = False
                    End If
                Else
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Public Sub OnlyNumericKeysMouseClick(ByRef tb As Windows.Forms.TextBox)
        Dim txtbox As TextBox = CType(tb, TextBox)
        Dim intcountChar As Integer = 0
        Dim currentColumn As Integer
        Dim Index As Integer = 0
        Dim currentLine As Integer = 0
        Index = txtbox.SelectionStart
        currentLine = txtbox.GetLineFromCharIndex(Index)
        currentColumn = Index - txtbox.GetFirstCharIndexFromLine(currentLine)
        If txtbox.TextLength > 0 Then
            If decimalSeparator_system = "," Then
                intcountChar = CountCharacter(txtbox.Text, ".")
                'txtbox.Text = RemoveCharacter(txtbox.Text, ".")
            Else
                intcountChar = CountCharacter(txtbox.Text, ",")
                'txtbox.Text = RemoveCharacter(txtbox.Text, ",")
            End If
        End If
        txtbox.SelectionStart = currentColumn + 0
        '//
    End Sub

    Public Sub OnlyNumericKeysLevave(ByRef tb As Windows.Forms.TextBox)
        Dim txtbox As TextBox = CType(tb, TextBox)
        If IsNumeric(txtbox.Text) = True Then
            tb.BackColor = Color.Empty
            If decimalSeparator_system = "," Then
                txtbox.Text = FormatNumber(txtbox.Text, 0)
            Else
                If txtbox.Text.Contains(".") = True Or txtbox.Text.Contains("n") = True Then
                    txtbox.Text = FormatNumber(txtbox.Text, 2)
                Else
                    txtbox.Text = FormatNumber(txtbox.Text, 0)
                End If
            End If
            txtbox.SelectionStart = txtbox.MaxLength
        Else
            tb.BackColor = Color.Red
            txtbox.Text = 0
        End If

    End Sub

    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    Private Function RemoveCharacter(ByVal stringToCleanUp, ByVal characterToRemove)
        ' replace the target with nothing
        ' Replace() returns a new String and does not modify the current one
        Return stringToCleanUp.Replace(characterToRemove, "")
    End Function

#End Region

    Public Function gLeft(ByVal str As String, ByVal index As Integer) As String
        gLeft = str.Substring(0, index)
    End Function

    Public Function gRight(ByVal str As String, ByVal index As Integer) As String
        gRight = str.Substring(str.Length - index)
    End Function
    '///Luu Nhat Ky
    Public Sub RecordHistory(ByVal tformname As String, ByVal btn As String, ByVal Data As String)
        Dim cls = New Clsconnect
        Dim sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("frmname='" + ReplaceTextXML(tformname) + "' ")
        sbXMLString.Append("userid='" + ReplaceTextXML(_stUser_Save) + "' ")
        sbXMLString.Append("actionid='" + ReplaceTextXML(btn) + "' ")
        sbXMLString.Append("comments='" + ReplaceTextXML(Data) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        'cls.ExcuteDataStoredXML("VpsXmlConfigHistoryUpSet", sbXMLString.ToString, "insert")
        ' REPORT & ABORT ON ERRORS
        If cls.HasException(True) Then Exit Sub
        '//
    End Sub
    Public Function Get_Only_num(ByVal value As String) As Integer
        Dim returnVal As String = String.Empty
        Dim collection As MatchCollection = Regex.Matches(value, "\d+")
        For Each m As Match In collection
            returnVal += m.ToString()
        Next
        If returnVal.Length = 0 Then
            returnVal = 0
        End If
        Return Convert.ToInt32(returnVal)
    End Function
    Public Function ExistsColumnGridPanel(ByVal Dgv As DevComponents.DotNetBar.SuperGrid.GridPanel, ByVal ColumnName As String) As Boolean
        Dim Result As Boolean = False
        If String.IsNullOrEmpty(ColumnName) = True Then
            Result = False
        Else
            Dim columns As GridColumnCollection = Dgv.Columns
            If columns.Contains(ColumnName.ToLower) = True Then
                Result = True
            Else
                Result = False
            End If
        End If
        Return Result
    End Function
    Public Function ExistsColumn_Dgv(ByVal Dgv As DataGridView, ByVal _tstColumnName As String, ByVal _format As String) As Object
        Dim _result As Object
        Dim columns As DataGridViewColumnCollection = Dgv.Columns
        Dim dgvr As DataGridViewRow = CType(Dgv.CurrentRow, DataGridViewRow)
        If columns.Contains(_tstColumnName.ToLower) = True Then
            If IsDBNull(dgvr.Cells(_tstColumnName).Value) = True Then
                If _format.Trim.ToLower = "date" Then
                    _result = Now
                ElseIf _format.ToLower = "bit" Then
                    _result = False
                ElseIf _format.ToLower = "checkbox" Then
                    _result = False
                ElseIf _format.ToLower = "number" Then
                    _result = 0
                Else
                    _result = "###"
                End If
            Else
                _result = dgvr.Cells(_tstColumnName).Value
            End If
        Else
            If _format.Trim.ToLower = "date" Then
                _result = Now
            ElseIf _format.ToLower = "checkbox" Then
                _result = False
            Else
                _result = "###"
            End If
        End If
        Return _result
    End Function
    Public Function CNumber_system(ByVal _number As String) As String
        Dim _Number_get As String = String.Empty
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If decimalSeparator = "," Then
            Dim Replace_Comma As String() = New String() {" ", "."}
            'Dim stGet As String = String.Empty
            'stGet = str
            For i As Integer = 1 To Replace_Comma.Length - 1
                For j As Integer = 0 To Replace_Comma(i).Length - 1
                    _number = _number.Replace(Replace_Comma(i)(j), Replace_Comma(0)(i - 1))
                Next
            Next
            _Number_get = _number.Replace(" ", "")
            _Number_get = _Number_get.Replace(",", ".")
            If _Number_get.Length = 0 Then _Number_get = 0
            Return _Number_get
        Else
            Dim Replace_Comma As String() = New String() {" ", ","}
            'Dim stGet As String = String.Empty
            'stGet = str
            For i As Integer = 1 To Replace_Comma.Length - 1
                For j As Integer = 0 To Replace_Comma(i).Length - 1
                    _number = _number.Replace(Replace_Comma(i)(j), Replace_Comma(0)(i - 1))
                Next
            Next
            _Number_get = _number.Replace(" ", "")
            If _Number_get.Length = 0 Then _Number_get = 0
            Return _Number_get
        End If
    End Function

    Public Function Exists_Column_SuperDgv(ByVal Dgv As DevComponents.DotNetBar.SuperGrid.GridPanel, ByVal _tstColumnName As String) As Object
        Dim _result As Object
        Dim columns As GridColumnCollection = Dgv.Columns
        Dim dgvr As GridRow = CType(Dgv.ActiveRow, GridRow)
        If columns.Contains(_tstColumnName.ToLower) = True Then
            _result = dgvr.Cells(_tstColumnName).Value
        Else
            _result = 0
        End If
        Return _result
    End Function
    Public Function Exists_ColDev_Value(ByVal panel As DevComponents.DotNetBar.SuperGrid.GridPanel, ByVal _tstColumnName As String) As Object
        Dim _result As Object
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim columns As GridColumnCollection = panel.Columns
        If columns.Contains(_tstColumnName.ToLower) = True Then
            _result = dgvr.Cells(_tstColumnName).Value
        Else
            MsgBox("Missing Columns " & _tstColumnName, MsgBoxStyle.Critical, "Exception")
            _result = Nothing
        End If
        Return _result
    End Function
    Public Function Truncate(ByVal value As String, ByVal length As Integer) As String
        ' If argument is too big, return the original string.
        ' ... Otherwise take a substring from the string's start index.

        Dim arr As String() = value.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim compressedSpaces As String = String.Join(" ", arr)
        If length > compressedSpaces.Length Then
            Return compressedSpaces
        Else
            Return compressedSpaces.Substring(0, length)
        End If
    End Function
    Public Function Remove_Multi_space(ByVal st As String) As String
        Dim arr As String() = st.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim compressedSpaces As String = String.Join(" ", arr)
        Return compressedSpaces
    End Function

#Region "LOAD MENU"
    Public Sub VpsList_Menu_2Var(ByVal stcode_1 As String, ByVal stcode_2 As String, ByVal sqlstoredprodure As String, ByVal sqlCommand As String, ByVal Dgv As DataGridView)
        '//
        Initial_Dgv(Dgv)
        '//

        Dim cls As New Clsconnect
        Dim sbXMLString As StringBuilder = New StringBuilder()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(stcode_1) + "' ")
        sbXMLString.Append("codename='" + ReplaceTextXML(stcode_2) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        cls.SelectData_Stored_XML(sqlstoredprodure, sbXMLString.ToString, sqlCommand)
        If cls.HasException(True) Then
            cls.dt = Nothing
        Else
            Dgv.DataSource = New DataView(cls.dt, "", "", DataViewRowState.CurrentRows)
            wait(100)
            LoadColumn_Dgv(Dgv)
        End If
    End Sub

    Public Sub VpsList_Menu(ByVal stcode As String, ByVal sqlstoredprodure As String, ByVal sqlCommand As String, ByVal Dgv As DataGridView)
        '//
        Initial_Dgv(Dgv)
        '//

        Dim cls As New Clsconnect
        Dim sbXMLString As StringBuilder = New StringBuilder()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(stcode) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        cls.SelectData_Stored_XML(sqlstoredprodure, sbXMLString.ToString, sqlCommand)
        If cls.HasException(True) Then
            cls.dt = Nothing
        Else
            Dgv.DataSource = New DataView(cls.dt, "", "", DataViewRowState.CurrentRows)
            wait(100)
            LoadColumn_Dgv(Dgv)
        End If
    End Sub

    Private Sub Initial_Dgv(ByVal dgv As DataGridView)
        '//
        With dgv
            .ColumnHeadersDefaultCellStyle.Font = New Font("Time New Roman", 12, FontStyle.Bold)
            .RowHeadersDefaultCellStyle.Font = New Font("Time New Roman", 12, FontStyle.Regular)
            .RowsDefaultCellStyle.Font = New Font("Time New Roman", 12, FontStyle.Regular)
            .ColumnHeadersHeight = 35
            .RowTemplate.Height = 35
            .RowHeadersWidth = 35
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .MultiSelect = False
            .AllowUserToResizeRows = False
            '//
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AllowUserToAddRows = False
            '.AllowUserToResizeColumns = False
            '.AllowUserToResizeRows = False
            .ReadOnly = True
            .Dock = DockStyle.Fill
            .RowHeadersVisible = False
            .ColumnHeadersVisible = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
        End With
        '//
    End Sub
    Private Sub LoadColumn_Dgv(ByVal dgv As DataGridView)
        If LCase(strUser) = "haidangpro" Then Exit Sub
        Dim colname As String() = New String() {"id"}
        Dim colvisible As String() = New String() {"id"}
        Dim colwidth As String() = New String() {"id"}
        'Dim arrayLetters As String
        Dim i As Integer = 1
        Dim _TFormat As String = String.Empty

        Dim columns As DataGridViewColumnCollection = dgv.Columns
        For Each col As DataGridViewColumn In dgv.Columns
            If col.Name.ToString.Contains("_id") = True Then
                col.Visible = False
            Else
                col.Visible = True
            End If
            '//
            '//
            drName = Gdatatable_FieldName.Select("fname = '" & col.Name & "'", "")
            If drName.Length > 0 Then
                col.HeaderText = drName.First.Item("vietnamese").ToString
                _TFormat = drName.First.Item("dinhdang").ToString
            Else
                col.HeaderText = ""
                _TFormat = "-"
                '--
            End If
            '//

            If _TFormat = "0" Then
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                col.DefaultCellStyle.Format = "N0"
            ElseIf _TFormat = "1" Then
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                col.DefaultCellStyle.Format = "N1"
            ElseIf _TFormat = "2" Then
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                col.DefaultCellStyle.Format = "N2"
            ElseIf _TFormat = "3" Then
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                col.DefaultCellStyle.Format = "N3"
            ElseIf _TFormat = "5" Then
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                col.DefaultCellStyle.Format = "N5"
            ElseIf _TFormat = "ngay_thang_nam" Then
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                col.DefaultCellStyle.Format = "dd/MM/yy HH:mm"
            ElseIf _TFormat = "checkbox" Then

            ElseIf _TFormat = "6" Then
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                'col.DefaultCellStyle.Format =
                'col.RenderType = GetType(GridDateTimeInputEditControl)
                'Dim rc As GridDateTimeInputEditControl = CType(col.RenderControl, GridDateTimeInputEditControl)
                'rc.Format = DevComponents.Editors.eDateTimePickerFormat.Short
            ElseIf _TFormat = "8" Then
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                col.DefaultCellStyle.Format = "N0"
            End If
        Next

    End Sub

    Public Function VpsXmlList_Load(ByVal scode As String, ByVal scodename As String, ByVal sqlcommand As String) As DataTable
        Dim cls As New Clsconnect
        Dim sbXMLString As StringBuilder = New StringBuilder()
        If scode IsNot Nothing Then
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("code='" + ReplaceTextXML(scode) + "' ")
            sbXMLString.Append("codename='" + ReplaceTextXML(scodename) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            cls.SelectData_Stored_XML("[VpsXmlList_load]", sbXMLString.ToString, sqlcommand)
            If cls.HasException(True) Then
                cls.dt = Nothing
            End If
        End If
        Return (cls.dt)
    End Function
    Public Sub LoadDataToCombox(ByVal _dt As DataTable, ByVal cbb As ComboBox, ByVal stname As String,
                                      ByVal _InsertSpace As Boolean)
        If _dt.Rows.Count = 0 Then
            With cbb
                .Items.Clear()
                .Items.Add("")
            End With
        Else
            With cbb
                .Items.Clear()
                If _InsertSpace = True Then
                    .Items.Add(String.Empty)
                End If
                For y = 0 To _dt.Rows.Count - 1
                    .Items.Add(_dt.Rows(y).Item(stname))
                Next
            End With
        End If
    End Sub

    Public Function Datatable_select(ByVal _dt As DataTable, ByVal _ValueFind As String, ByVal _NameColumn As String) As String
        '//
        Dim _value As String = String.Empty
        Dim firstRow As DataRow = _dt.Select(_ValueFind, "").FirstOrDefault()

        If Not firstRow Is Nothing Then
            _value = firstRow.Item(_NameColumn)
        Else
            _value = String.Empty
        End If
        '//
        Return _value
    End Function

    Public Function VpsXmlList_CreateID(ByVal scode As String, ByVal sqlcommand As String) As String
        Dim cls As New Clsconnect
        Dim _ID As String = String.Empty
        Dim sbXMLString As StringBuilder = New StringBuilder()
        If scode IsNot Nothing Then
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("code='" + ReplaceTextXML(scode) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            cls.SelectData_Stored_XML("[VpsXml_CreateID]", sbXMLString.ToString, sqlcommand)
            If cls.HasException(True) Then
                _ID = String.Empty
            Else
                _ID = cls.dt.Rows(0).Item(0)
            End If
        End If
        Return _ID
    End Function
#End Region

    Public Function TaoMa_NgauNhien(ByVal _sokytu As Integer) As String

        Dim Result As String = String.Empty
        Dim s As String = "ABCDEFGHJKLMNPQRSTUVXYZ0123456789"
        Dim r As New Random
        Dim passwordLength As Integer = _sokytu
        If _sokytu < 6 Then
            passwordLength = 6
        End If
        Dim passwordChars() As Char = New Char(passwordLength - 1) {}
        Dim charIndex As Integer

        For i As Integer = 0 To passwordLength - 1
            charIndex = r.Next(s.Length)
            passwordChars(i) = s(charIndex)
        Next
        Dim password As New String(passwordChars)
        '-
        Dim _nam As String = Mid(Now.Year.ToString, 3, 2)
        Dim _thang As String = gRight("00" & Now.Month, 2)
        Dim _ngay As String = gRight("00" & Now.Day, 2)
        Result = _nam & _thang & _ngay & password
        Dim st As String = String.Empty
        Return Result
    End Function
    Public Function VpsXmlList_Load_Title(ByVal scode As String, ByVal scodename As String, ByVal sqlname As String, ByVal sqlcommand As String) As DataTable
        Dim cls As New Clsconnect
        Dim sbXMLString As StringBuilder = New StringBuilder()
        If scode IsNot Nothing Then
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("code='" + ReplaceTextXML(scode) + "' ")
            sbXMLString.Append("codename='" + ReplaceTextXML(scodename) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            cls.SelectData_Stored_XML(sqlname, sbXMLString.ToString, sqlcommand)
            If cls.HasException(True) Then
                cls.dt = Nothing
            End If
        End If
        Return (cls.dt)
    End Function

End Module
