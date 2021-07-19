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
Public Class frmPhieuLoiKyThuat_Input
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
    Dim dt_nhomloi As DataTable
    Dim _filter As Boolean = False
    Private _lbtn_command As SByte = 0
    Private Lnhomloi_id As String = String.Empty

    Dim _intRows_ALL As Long = 0
    Dim _intColumns_ALL As Long = 0, _intGroup_count As Long = 0
    Dim _IntGroup_Column_Index As Byte = 0

    Dim _update_ok As Boolean = False, _Edit_Chungtu As Boolean = False
    Dim _bln_khachhang As Boolean = False, _bln_mahang As Boolean = False
    Dim _blnEdit As Boolean = False
    Private _mahang_id As String = String.Empty
    Private Ldonhang As String = String.Empty
    Private LChungtu As String = String.Empty
    Private _chungtunhap_id As String = String.Empty
    Private _donhang_id As String = String.Empty
    Private _bln_donhang As Boolean = False
    Private Ischanged As Boolean = False
    Private LMaMe As String = String.Empty
    '//
    Private DgvData As DataGridView = New DataGridView()
    Public Property MaMe() As String
        Get
            Return Lmame
        End Get
        Set(ByVal value As String)
            Lmame = value
        End Set
    End Property
    Public Property Chungtu() As String
        Get
            Return LChungtu
        End Get
        Set(ByVal value As String)
            LChungtu = value
        End Set
    End Property
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
        If Ischanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
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
        dt_nhomloi = New DataTable

        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
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
        Load_NhomLoi()
        '//
        Me.ResumeLayout()
    End Sub
    Private Sub Load_NhomLoi()
        dt_nhomloi = VpsXmlList_Load("", "", "maloi_kythuat")
        LoadDataToCombox(dt_nhomloi, cboLyDo, "nhomloi", True)
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If _PhieuLKT_status = 1 Then
            Taophieumoi()
            '//
            txtmame_input.Focus()
            btnSave.Text = "Lưu Lại"
            _lbtn_command = 1
        ElseIf _PhieuLKT_status = 2 Then
            _lbtn_command = 2

            btnSave.Text = "Cập Nhật"
            '//
            txtchungtunhap.Text = LChungtu
            Filterdata_Stored()
        ElseIf _PhieuLKT_status = 3 Then
            Taophieumoi()
            _lbtn_command = 1
            btnSave.Text = "Lưu Lại"
            '//
            txtmame_input.Text = LMaMe
            _bln_donhang = True
            Filterdata_Stored()
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
        sbXMLString.Append("sophieu='" + ReplaceTextXML(txtchungtunhap.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_PhieuLoiKyThuat_UpSet_2021]", sbXMLString.ToString, "select_sophieu")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)

        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("st_ngaytao"), panel.Columns("sophieu")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        End If

    End Sub

#End Region

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub cboSoluong_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _filter = True Then
            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Filterdata_Stored()
    End Sub

#Region "EXECUTE"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ThemMoi()
    End Sub

    Private Sub ThemMoi()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        'Try
        Call ClearTextBox()
        _lbtn_command = 1
        '--
        btnSave.Text = "Lưu Lại"
        cboNoiTao.SelectedIndex = 1
        '--
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
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
        _lbtn_command = 2
        btnSave.Text = "Cập Nhật"
        '--
        With Me
            _chungtunhap_id = dgvr.Cells("sophieu_id").Value
            dtngaynhap.Value = dgvr.Cells(_coldtngaytao).Value
            txtchungtunhap.Text = dgvr.Cells("sophieu").Value
            txtdonhang.Text = dgvr.Cells("c_donhang").Value
            txtcongdoan.Text = dgvr.Cells("c_congdoan").Value
            cboNoiTao.Text = dgvr.Cells("c_bophan").Value
            '///
            txtkhachhang.Text = dgvr.Cells("c_khachhang").Value
            txtmahang.Text = dgvr.Cells("c_mahang").Value
            txtloaihang.Text = dgvr.Cells("c_loaihang").Value
            txtmamau.Text = dgvr.Cells("c_mamau").Value
            txttenmau.Text = dgvr.Cells("c_tenmau").Value
            txtmame.Text = dgvr.Cells("c_mame").Value
            txtsocay.Text = dgvr.Cells("c_socay").Value
            txtsokg.Text = dgvr.Cells("c_sokg").Value
            'txtsomet.Text = dgvr.Cells("c_somet").Value

            .cboNoiTao.Text = dgvr.Cells("c_bophan").Value
            .txtdonhang.Text = dgvr.Cells("c_donhang").Value
            .txtnoidung.Text = dgvr.Cells("c_mota").Value
            .txtghichu.Text = dgvr.Cells("c_ghichu").Value
        End With
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
        txtmahang.Text = String.Empty
        txtloaihang.Text = String.Empty
        txtkhachhang.Text = String.Empty
        txtsokg.Text = 0
        txtsocay.Text = 0
        'txtsomet.Text = 0
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
        '///
        '_Thang = _TimeServer.Month
        str_sophieu = _Nam
        '///
        txtchungtunhap.Text = VpsXmlList_CreateID(str_sophieu, "sophieu_loikythuat")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        _blnEdit = False
        Me.Close()
    End Sub
    Private Sub Update_Data(ByVal st As String, ByVal _command As String)
        If Trim(txtchungtunhap.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập mã Chứng Từ.", "Thông báo")
            txtchungtunhap.Focus()
            Exit Sub

        ElseIf Trim(txtmahang.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập Mã Hàng.", "Thông báo")
            txtmahang.Focus()
            Exit Sub
        End If
        '//
        dr2 = dt_nhomloi.Select("nhomloi = '" & cboLyDo.Text & "'", "")
        If dr2.Length > 0 Then
            Lnhomloi_id = dr2.First.Item("nhomloi_id")
        Else
            Lnhomloi_id = "NL00"
        End If
        '//
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("sophieu_id='" + ReplaceTextXML(_chungtunhap_id) + "' ")
        sbXMLString.Append("sophieu='" + ReplaceTextXML(txtchungtunhap.Text) + "' ")
        sbXMLString.Append("nhomloi_id='" + ReplaceTextXML(Lnhomloi_id) + "' ")
        sbXMLString.Append("c_bophan='" + ReplaceTextXML(cboNoiTao.Text) + "' ")
        sbXMLString.Append("c_congdoan='" + ReplaceTextXML(txtcongdoan.Text) + "' ")
        sbXMLString.Append("c_donhang='" + ReplaceTextXML(txtdonhang.Text) + "' ")
        sbXMLString.Append("c_mahang='" + ReplaceTextXML(txtmahang.Text) + "' ")
        sbXMLString.Append("c_khachhang='" + ReplaceTextXML(txtkhachhang.Text) + "' ")
        sbXMLString.Append("c_loaihang='" + ReplaceTextXML(txtloaihang.Text) + "' ")
        sbXMLString.Append("c_mamau='" + ReplaceTextXML(txtmamau.Text) + "' ")
        sbXMLString.Append("c_tenmau='" + ReplaceTextXML(txttenmau.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_input.Text) + "' ")
        sbXMLString.Append("c_mame='" + ReplaceTextXML(txtmame.Text) + "' ")
        sbXMLString.Append("c_socay='" + CNumber_system(txtsocay.Text) + "' ")
        sbXMLString.Append("c_sokg='" + CNumber_system(txtsokg.Text) + "' ")
        sbXMLString.Append("c_somet='" + CNumber_system(0) + "' ")
        sbXMLString.Append("c_ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
        sbXMLString.Append("c_mota='" + ReplaceTextXML(txtnoidung.Text) + "' ")
        sbXMLString.Append("dtngaytao='" + Format$(dtngaynhap.Value, "MM/dd/yyyy") + "' ")
        sbXMLString.Append("nguoitao='" + ReplaceTextXML(strUser) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_PhieuLoiKyThuat_UpSet_2021]", sbXMLString.ToString, _command)
        Ischanged = dtControler.UPSET_XML(_dt)
        '//
        _update_ok = True
        Call Filterdata_Stored()
        '//
    End Sub
    Private Sub Tao_ID()
        Dim _Nam As String
        _Nam = Mid$(Now.Year.ToString, 3, 2)
        Dim str_sophieu As String = "NM" & _Nam
        _chungtunhap_id = VpsXmlList_CreateID(str_sophieu, "nhapmoc")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim TestComp As Integer = StrComp(btnSave.Text, "Lưu Lại", CompareMethod.Binary)
        If _lbtn_command = 1 Then
            _chungtunhap_id = TaoMa_NgauNhien(6)
            '//
            Call Update_Data("", "insert")
            If _update_ok = True Then
                Call Taophieumoi()
                'Call Clear_TextBox()
            End If
        Else
            If MsgBox("Bạn có muốn sửa nội dung không ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update")
            End If
        End If

    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_PhieuLoiKyThuat_UpSet_2021]", sbXMLString.ToString, "delete")
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

#Region "DON HANG"
    Private Sub txtmame_input_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmame_input.KeyDown
        _bln_donhang = True
        If _bln_donhang = True Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                DgvData.Focus()
            End If
        End If
    End Sub
    Private Sub txtmame_input_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmame_input.TextChanged
        If _bln_donhang = True Then
            Dim txt As TextBox = CType(sender, TextBox)
            Dim pnPopup As Panel = PnPopup_List
            pnPopup.Controls.Add(DgvData)
            'Me.Controls.Add(pnPopup)

            AddHandler DgvData.CellClick, AddressOf DgvDonHang_CellClick
            AddHandler DgvData.KeyDown, AddressOf DgvDonHang_KeyDown

            If Len(txt.Text) > 0 Then
                VpsList_Menu(txt.Text, "[VpsXmlKhoSanXuat_MeNhuom_Info_2021]", "select", DgvData)
                '// 
                Dim ucDscreenCoords = txt.PointToScreen(New Point(0, 0))
                Dim ucDclientCoordsRelativeToA = Me.PointToClient(ucDscreenCoords)
                pnPopup.Location = New Point(ucDclientCoordsRelativeToA.X, ucDclientCoordsRelativeToA.Y + txt.Height)
                pnPopup.Size = New Size(CInt(Me.Width * 0.7), CInt(txt.Height * 15))
                pnPopup.Visible = True
                pnPopup.BringToFront()
                '--
            Else
                pnPopup.Visible = False
                _bln_donhang = False
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
                txtdonhang.Text = ExistsColumn_Dgv(Dgv, "donhang", "").ToString
                '//
                txtmame_input.Text = ExistsColumn_Dgv(Dgv, "mame", "").ToString
                txtkhachhang.Text = ExistsColumn_Dgv(Dgv, "khachhang", "").ToString
                txtmahang.Text = ExistsColumn_Dgv(Dgv, "mahang", "").ToString
                txtloaihang.Text = ExistsColumn_Dgv(Dgv, "loaihang", "").ToString
                txtmamau.Text = ExistsColumn_Dgv(Dgv, "mamau", "").ToString
                txttenmau.Text = ExistsColumn_Dgv(Dgv, "tenmau", "").ToString
                txtmame.Text = ExistsColumn_Dgv(Dgv, "mame_all", "").ToString
                '//
                txtsocay.Text = ExistsColumn_Dgv(Dgv, "socay_phanme", "").ToString
                txtsokg.Text = ExistsColumn_Dgv(Dgv, "sokg_phanme", "").ToString
                'txtsomet.Text = ExistsColumn_Dgv(Dgv, "somet", "").ToString
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvDonHang_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvDonHang_KeyDown
        PnPopup_List.Visible = False
        '//
        'Call Filterdata_Stored()
        '//
        txtsocay.Focus()
    End Sub


#End Region

End Class