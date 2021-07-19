Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Text
Public Class List_mahang_input
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent

    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private dt_local As DataTable
    Private dt_khachhang As DataTable
    Dim stCommand As String = String.Empty
    Dim _update_Ok As Boolean = False
    Private _Lbln_action_btn As Integer = 0
    Private _makh_id As String = String.Empty
    Private dr0 As DataRow()
    Private _Lst_ID As String = String.Empty
    Private IsBusy As Boolean = False
    Private _bln_khachhang As Boolean = False
    '//
    Private DgvData As DataGridView = New DataGridView()
    Private IsChanged As Boolean = False
    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        If Ischanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        dt_khachhang = New DataTable
        '//
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If _Loaivai_status = 1 Then
            _Lbln_action_btn = 1
            Call Clear_TextBox()
            cmdSave.Text = "Lưu Lại"
            txtmakhach.Focus()
        ElseIf _Loaivai_status = 2 Then
            cmdSave.Text = "Cập Nhật"
            _Lbln_action_btn = 2
            Call Load_TextBox()
            txtmahang.Focus()
        ElseIf _Loaivai_status = 3 Then
            _Lbln_action_btn = 1
            Call Load_TextBox()
            cmdSave.Text = "Lưu Lại"
            txtmahang.Focus()
        End If
    End Sub
    Private Sub Taophieumoi()
        Dim _Nam As String
        _Nam = Mid$(Now.Year.ToString, 3, 2)
        Dim str_sophieu As String = "MH" & _Nam
        _Lst_ID = VpsXmlList_CreateID(str_sophieu, "mahang")
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If _Lbln_action_btn = 1 Then
            Taophieumoi()
            Call Update_Data("", "insert")
            If _update_Ok = True Then
                _update_Ok = False
                Call Clear_TextBox()
                txtloaihang.Focus()
            End If
        ElseIf _Lbln_action_btn = 2 Then
            If MsgBox("Bạn có muốn sửa nội dung không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update")
            End If
            Me.Close()
        End If

    End Sub

    Private Function CheckData() As Boolean
        CheckData = True
        '//
        'Dim firstRow As DataRow = dt_khachhang.Select("khachhang = '" & cboKhachHang.Text & "'", "").FirstOrDefault()

        'If Not firstRow Is Nothing Then
        '_makh_id = firstRow.Item("makh_id")
        'Else
        'CheckData = False
        '_makh_id = String.Empty
        'MsgBox("Vui lòng chọn Khách Hàng.", MsgBoxStyle.Information, "Thông Báo")
        'Exit Function
        'End If
        If cboNhomHang.SelectedIndex = -1 Then
            CheckData = False
            MsgBox("Vui lòng chọn Nhóm Hàng.", MsgBoxStyle.Information, "Thông Báo")
            cboNhomHang.Focus()
            Exit Function
        End If

        '//

        Dim txt As TextBox = CType(txtmahang, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Mã Hàng.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        '//
        txt = CType(txtloaihang, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Loại Hàng.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
    End Function

    Private Sub Update_Data(ByVal sqlcommand As String, ByVal command As String)
        If CheckData() = True Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mahang_id='" + ReplaceTextXML(_Lst_ID) + "' ")
            sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang.Text) + "' ")
            sbXMLString.Append("makh_id='" + ReplaceTextXML(_makh_id) + "' ")
            sbXMLString.Append("loaihang='" + ReplaceTextXML(txtloaihang.Text) + "' ")
            sbXMLString.Append("khovai='" + ReplaceTextXML(txtkhovai.Text) + "' ")
            sbXMLString.Append("metkg='" + ReplaceTextXML(txtmetkg.Text) + "' ")
            sbXMLString.Append("solot='" + ReplaceTextXML(txtsolot.Text) + "' ")
            sbXMLString.Append("chonmay='" + ReplaceTextXML(cboLoaiDay.Text) + "' ")
            sbXMLString.Append("quicach='" + ReplaceTextXML("") + "' ")
            sbXMLString.Append("intnhomhang='" + CNumber_system(cboNhomHang.SelectedIndex) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_MaHang_UpSet]", sbXMLString.ToString, command)
            _update_Ok = dtControler.UPSET_XML(_dt)
            If _update_Ok = True Then
                Ischanged = True
                '//
            End If

        End If
    End Sub

    Private Sub Load_TextBox()
        'Try
        Dim panel As GridPanel = List_mahang.Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        With dgvr
            _Lst_ID = .Cells(_colMahang_ID).Value
            txtmahang.Text = .Cells(_colmahang).Value
            cboLoaiDay.Text = .Cells("chonmay").Value
            txtkhachhang.Text = .Cells("khachhang").Value
            _makh_id = .Cells("makh_id").Value
            txtloaihang.Text = .Cells(_colloaihang).Value
            txtkhovai.Text = .Cells("khovai").Value
            txtmetkg.Text = .Cells("metkg").Value
            txtsolot.Text = .Cells("solot").Value
            txtghichu.Text = .Cells(_colghichu).Value
            txtmakhach.Text = .Cells("makhach").Value
            cboNhomHang.SelectedIndex = .Cells("intnhomhang").Value
        End With
        'Catch ex As Exception
        'txtmahang.Focus()
        'End Try
    End Sub

    Private Sub Clear_TextBox()
        txtOrder_ID.Text = String.Empty
        txtmahang.Text = String.Empty
        txtloaihang.Text = String.Empty
        txtghichu.Text = String.Empty
        txtmahang.Focus()
    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Protected Overloads Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            Return MyBase.ProcessDialogKey(Keys.Tab)
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If

    End Function
    Private Sub txtmahang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmahang.TextChanged
        Dim txtbox As TextBoxX = CType(sender, TextBoxX)
        Dim theText As String = txtbox.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtbox.SelectionStart
        Dim Change As Integer
        For x As Integer = 0 To txtbox.Text.Length - 1
            Letter = txtbox.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
                Beep()
            End If
        Next
        txtbox.Text = theText
        txtbox.Select(SelectionIndex - Change, 0)
        Call Filterdata_Stored()
    End Sub
    Private Sub Filterdata_Stored()
        If IsBusy = True Then Return
        IsBusy = True
        Me.SuspendLayout()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(txtmahang.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("VpsXmlList_MaHang_UpSet", sbXMLString.ToString, "select")
        Super_Dgv.SuspendLayout()
        Super_Dgv.BeginUpdate()
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Super_Dgv.EndUpdate()
        Super_Dgv.ResumeLayout()
        IsBusy = False
        Me.ResumeLayout()
    End Sub


    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        'panel.AddGroup(panel.Columns(_colnhomhc))

        'AddHandler tpress.Tick, AddressOf MyTickHandler
        'tpress.Enabled = True
    End Sub

#Region "THEM NHANH LOAI HANG"
    Private Sub BtnThemNhanh_KhachHang_Click(sender As Object, e As EventArgs) Handles BtnThemNhanh_KhachHang.Click
        _Khachhang_status = 3
        ShowModalForm_KhachHang()
    End Sub
    Private Sub ShowModalForm_KhachHang()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_KhachHang))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With List_khachhang_input
                '.Size = New Size(.Width, .Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                '.Text = "XÁC NHẬN THỰC HIỆN"
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    'Call Filterdata_Stored()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub

    Private Sub BtnChonLai_Click(sender As Object, e As EventArgs) Handles BtnChonLai.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        If dgvr Is Nothing Then Exit Sub
        With dgvr
            _Lst_ID = .Cells(_colMahang_ID).Value
            txtmahang.Text = .Cells(_colmahang).Value
            cboLoaiDay.Text = .Cells("chonmay").Value
            txtmakhach.Text = .Cells("makhach").Value
            txtkhachhang.Text = .Cells("khachhang").Value
            txtloaihang.Text = .Cells(_colloaihang).Value
            txtkhovai.Text = .Cells("khovai").Value
            txtmetkg.Text = .Cells("metkg").Value
            txtghichu.Text = .Cells(_colghichu).Value
            cboNhomHang.SelectedIndex = .Cells("intnhomhang").Value
        End With
    End Sub

#End Region

#Region "TIM KIEM THONG TIN"

#Region "KHACH HANG"
    Private Sub txtmakhach_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmakhach.KeyDown
        _bln_khachhang = True
        If _bln_khachhang = True Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                DgvData.Focus()
            End If
        End If
    End Sub

    Private Sub txtmakhach_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmakhach.TextChanged
        If _bln_khachhang = True Then
            Dim txt As TextBox = CType(sender, TextBox)
            Dim pnPopup As Panel = PnPopup_List
            pnPopup.Controls.Add(DgvData)
            'Me.Controls.Add(pnPopup)

            AddHandler DgvData.CellClick, AddressOf DgvMaHang_CellClick
            AddHandler DgvData.KeyDown, AddressOf DgvMaHang_KeyDown

            If Len(txt.Text) > 0 Then
                'ClsDatagridView.VpsListMaHang(txt.Text, "", DgvData)
                VpsList_Menu(txt.Text, "[VpsXmlList_KhachHang_UpSet]", "select", DgvData)
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
                _bln_khachhang = False
                _makh_id = String.Empty
                txtkhachhang.Text = String.Empty
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
            If _bln_khachhang = True Then
                _bln_khachhang = False
                _makh_id = ExistsColumn_Dgv(Dgv, _colmakhach_id, "").ToString
                txtmakhach.Text = ExistsColumn_Dgv(Dgv, _colMakhach, "").ToString
                txtkhachhang.Text = ExistsColumn_Dgv(Dgv, _colkhachhang, "").ToString
                '//
                txtkhachhang.Text = ExistsColumn_Dgv(Dgv, "khachhang", "").ToString
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvMaHang_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvMaHang_KeyDown
        PnPopup_List.Visible = False
        txtmahang.Focus()

    End Sub
#End Region

#End Region


End Class