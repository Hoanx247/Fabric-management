Imports DevComponents.DotNetBar
Imports System.Threading
Imports System.Text
Public Class Form1
    Private intform As Integer, intLogin As Integer = 0
    Dim cls As New Clsconnect
    Private frmNew As Form
    Private sbXMLString As StringBuilder = New StringBuilder()
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private Sub tabStrip1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles tabStrip1.SelectedTabChanged
        Try
            If tabStrip1.Tabs.Count > 0 Then
                '--
                PictureBox1.Visible = False
            Else
                '--
                PictureBox1.Visible = True
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If intLogin = 0 Then
            Me.Dispose()
            frmLogin.Close()
            '--
        End If
    End Sub


    Private Sub RibbonStateCommand_Executed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonStateCommand.Executed
        ribbonControl1.Expanded = RibbonStateCommand.Checked
        RibbonStateCommand.Checked = Not RibbonStateCommand.Checked
    End Sub

    Private Function GetWeekNumber(ByVal startMonth As Integer, ByVal startDay As Integer, ByVal endDate As Date) As Integer
        Dim span As TimeSpan = endDate - New Date(endDate.Year, startMonth, startDay)
        Return (CInt(span.TotalDays) \ 7) + 1
    End Function

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.WindowState = FormWindowState.Maximized
        Me.ribbon_QLKho.Checked = True
        Call Load_TimeServer()
        LblTime.Text = "Hôm nay: " & Format$(_TimeServer, "dd/MM/yyyy") & "  Tuần: " & DatePart("ww", _TimeServer, vbSunday)
        '--
        Me.Lbl_User.Text = "User: " & strUser & "    " & "Nhóm: " & str_nhom
        'Call cls.LogIn_Soft()
        '--
        lblIPLocal.Text = "#IP: " & mdlIPAddress

        '//
    End Sub
    Private Sub btNguoidung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNguoidung.Click
        With List_user
            .Text = "Tài Khoản"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btDangnhaplai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDangnhaplai.Click
        intLogin = 1
        Me.Close()
        frmLogin.Show()
        frmLogin.Update()
    End Sub

    Private Sub btphanquyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btphanquyen.Click
        With List_Phanquyen
            .Text = "Phân Quyền"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_CapNhat_DonGiaMoc_Click(sender As Object, e As EventArgs) Handles ButtonItem_CapNhat_DonGiaMoc.Click
        With List_mahang_ApDonGia_Moc
            .Text = "Cập Nhật Giá Mộc"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub
    Private Sub btnPhanMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhanMe.Click
        With frmDieuDoSanXuat
            .Text = "Tổng KHSX"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnNhanVien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhanVien.Click
        With List_nhanvien
            .Text = "Nhân Viên"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnMaycang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaycang.Click
        With List_May
            .Text = "Ds Máy"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnKhachhang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKhachhang.Click
        With List_Khachhang
            .Text = "Khách Hàng"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnMamau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMamau.Click
        With List_mamau
            .Text = "Mã Màu"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnmahang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmahang.Click
        With List_mahang
            .Text = "Mã Hàng"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub
    Private Sub ButtonItem_CapNhat_DonGia_Nhuom_Click(sender As Object, e As EventArgs) Handles ButtonItem_CapNhat_DonGia_Nhuom.Click
        With frmDonHang_ApGia
            .Text = "Cập Nhật Giá Nhuộm"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub
    Private Sub btnCongdoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCongdoan.Click
        With List_Congdoan
            .Text = "Công Đoạn"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnQuitrinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu_PH.Click
        With List_CongDoan_DoPH
            .Text = "Công Đoạn (PH)"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnQLSX_TongQuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQLSX_TongQuan.Click
        With frmBaoCao_DuTinh_LenhSanXuat
            .Text = "Dự Tính LSX"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnKehoach_Detail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKehoach_Detail.Click
        With frmNhatKySanXuat
            .Text = "Nhật Ký SX"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_PhieuLoiKyThuat_Click(sender As Object, e As EventArgs) Handles ButtonItem_PhieuLoiKyThuat.Click
        With frmPhieuLoiKyThuat
            .Text = "Phiếu LKT"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_QuanLy_HaiDang_Click(sender As Object, e As EventArgs) Handles ButtonItem_QuanLy_HaiDang.Click
        With frmDieuDoSanXuat_quantri_haidang
            .Text = "Quản Lý Hải Đăng"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_XuatKho_Chitiet_Click(sender As Object, e As EventArgs) Handles ButtonItem_XuatKho_Chitiet.Click
        With frmXuatHang_Detail
            .Text = "Chi Tiết Xuất"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnInPhieu_Nhuom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInPhieu_Nhuom.Click
        With frmDieuDoSanXuat_InPhieuNhuom
            .Text = "In Phiếu Nhuộm"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnDoi_Matkhau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoi_Matkhau.Click
        Dim form As frmChange_Password = New frmChange_Password
        form.ShowDialog()
    End Sub

    Private Sub btnLenhSanXuat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLenhSanXuat.Click
        With frmDonHang_TienDo_CongDoan
            .Text = "Theo Dõi Đơn Hàng"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub


    Private Sub btnCanTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanTP.Click
        With frmNhapkho_HoanTat
            .Text = "Nhập Kho H.Tất"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnFrmName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrmName.Click
        With List_frmName
            .Text = "Danh sách form"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnmenu_FieldName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu_FieldName.Click
        With List_FieldName
            .Text = "Field Name"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_TonKhoThanhPham_Click(sender As Object, e As EventArgs) Handles ButtonItem_TonKhoThanhPham.Click
        With frmNhap_Xuat_Ton_TPham
            .Text = "NXT T.Phẩm"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub
    Private Sub ButtonItem_KhoThanhPham_ChiTiet_Click(sender As Object, e As EventArgs) Handles ButtonItem_KhoThanhPham_ChiTiet.Click
        With Stock_Thanhpham_Detail
            .Text = "Chi Tiết Kho TP"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub
    Private Sub BtnTimeLine_Click(sender As Object, e As EventArgs) Handles BtnTimeLine.Click
        With frmTimeLine
            .Text = "Tiến Độ SX"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnTongHop_KHSX_Click(sender As Object, e As EventArgs) Handles BtnTongHop_KHSX.Click
        With frmBaoCao_QLSX_ALL
            .Text = "Báo Cáo KHSX"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub
    Private Sub BtnMenu_DonHang_Click(sender As Object, e As EventArgs) Handles BtnMenu_DonHang.Click
        With frmDonHang_KinhDoanh
            .Text = "Đơn Hàng"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub


    Private Sub BtnKeHoach_LamViec_Click(sender As Object, e As EventArgs) Handles BtnKeHoach_LamViec.Click
        With FrmXacNhanGioLam
            .Text = "KẾ HOẠCH NHÂN SỰ"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnMenu_NhapMoc_Click(sender As Object, e As EventArgs) Handles BtnMenu_NhapMoc.Click
        With frmnhapmoc
            .Text = "Nhập Mộc"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnMenu_NhapXuatTon_Moc_Click(sender As Object, e As EventArgs) Handles BtnMenu_NhapXuatTon_Moc.Click
        With frmNhap_Xuat_Ton
            .Text = "K.Mộc NXT"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnMenu_TonMoc_Click(sender As Object, e As EventArgs) Handles BtnMenu_TonMoc.Click
        With Stock_TonMocChitiet
            .Text = "Tồn Mộc (M.Đích)"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub
    Private Sub ButtonItem_Menu_DonHang_Chitiet_Click(sender As Object, e As EventArgs) Handles ButtonItem_Menu_DonHang_Chitiet.Click
        With frmDonHang
            .Text = "Chi Tiết Đơn Hàng"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnMenu_PhanMe_Click(sender As Object, e As EventArgs) Handles BtnMenu_PhanMe.Click
        With frmDieuDoSanXuat_PhanMe
            .Text = "Phân Mộc Vào Mẻ"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        With frmDonHang_TienDo_CongDoan
            .Text = "Theo Dõi Đơn Hàng"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnMenu_TaoMeNhuom_Click(sender As Object, e As EventArgs) Handles BtnMenu_TaoMeNhuom.Click
        With frmDonHang_LenhSanXuat
            .Text = "Tạo Mẻ Nhuộm"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnMenu_KhoTam_Click(sender As Object, e As EventArgs) Handles BtnMenu_KhoTam.Click
        With frmKhoTam
            .Text = "Kho Bảo Vệ"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnMenu_ChitietMoc_Click(sender As Object, e As EventArgs) Handles BtnMenu_ChitietMoc.Click
        With frmNhapMoc_chiTiet
            .Text = "Chi Tiết Mộc"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub btnQuanTri_NhatKySX_Click(sender As Object, e As EventArgs) Handles btnQuanTri_NhatKySX.Click
        With frmNhatKySanXuat_quantri
            .Text = "Nhật Ký SX (QT)"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnKHSX_QuanTri_Click(sender As Object, e As EventArgs) Handles BtnKHSX_QuanTri.Click
        With frmDieuDoSanXuat_quantri
            .Text = "KHSX (QT)"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnMenu_BangLoiKyThuat_Click(sender As Object, e As EventArgs) Handles BtnMenu_BangLoiKyThuat.Click
        With List_BangLoi_KyThuat
            .Text = "Bảng Lỗi Kỹ Thuật"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub
    Private Sub btnMucDich_Click(sender As Object, e As EventArgs) Handles btnMucDich.Click
        With List_MucDich
            .Text = "Mục Đích"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnNhatKy_PhanMem_Click(sender As Object, e As EventArgs) Handles BtnNhatKy_PhanMem.Click
        With List_NhatKy
            .Text = "Nhật Ký (Xử Lý)"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub BtnMenu_TimeLine_List_Click(sender As Object, e As EventArgs)
        With frmTimeLine_List
            .Text = "List Công Đoạn"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ShowModalForm()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm))
        Else
            With frmNew
                '.Size = New Size(Me.Height * 0.95, .Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtControler = New ListMenuDAL()
        Gdatatable_phanquyen = New DataTable
        Gdatatable_ColName = New DataTable
        Gdatatable_FieldName = New DataTable
        '//
        Load_Initized_PhanQuyen()
        '//
        Load_Initized_ColName()
        '//
        Load_Initized_FieldName()
    End Sub

#Region "LOAD DEFAULT"
    Private Sub Load_Initized_PhanQuyen()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(_nhomUser_ID) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlLoad_Initial]", sbXMLString.ToString, "phanquyen")
        Gdatatable_phanquyen = dtControler.SELECT_XML_Datatable(_dt)
    End Sub
    Private Sub Load_Initized_ColName()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(strUser) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlLoad_Initial]", sbXMLString.ToString, "colname")
        Gdatatable_ColName = dtControler.SELECT_XML_Datatable(_dt)
    End Sub

    Private Sub ButtonItem_KhoHoanTat_TongQuan_Click(sender As Object, e As EventArgs) Handles ButtonItem_KhoHoanTat_TongQuan.Click
        With Stock_HoanTat
            .Text = "Kho Hoàn Tất"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_KhoThanhPham_TongQuan_Click(sender As Object, e As EventArgs) Handles ButtonItem_KhoThanhPham_TongQuan.Click
        With Stock_Thanhpham
            .Text = "Thành Phẩm"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_XuatKho_TongQuan_Click(sender As Object, e As EventArgs) Handles ButtonItem_XuatKho_TongQuan.Click
        With frmXuatHang
            .Text = "Xuất Hàng"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_NhatKy_DoPH_Click(sender As Object, e As EventArgs) Handles ButtonItem_NhatKy_DoPH.Click
        With frmQuanly_DoPH
            .Text = "Đo PH"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_BaoCao_NhatKySX_Click(sender As Object, e As EventArgs) Handles ButtonItem_BaoCao_NhatKySX.Click
        With frmReport_NhatKySanXuat
            .Text = "Báo Cáo (Nhật Ký SX)"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_NhatKy_LamViec_Click(sender As Object, e As EventArgs) Handles ButtonItem_NhatKy_LamViec.Click
        With frmNhatKy_LamViec
            .Text = "Nhật Ký Làm Việc"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub

    Private Sub ButtonItem_CauHinh_Excel_Click(sender As Object, e As EventArgs) Handles ButtonItem_CauHinh_Excel.Click
        With List_CauHinh_Excel
            .Text = "Excel"
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
            .Update()
        End With
    End Sub


    Private Sub Load_Initized_FieldName()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlLoad_Initial]", sbXMLString.ToString, "fieldname")
        Gdatatable_FieldName = dtControler.SELECT_XML_Datatable(_dt)
    End Sub
#End Region
End Class