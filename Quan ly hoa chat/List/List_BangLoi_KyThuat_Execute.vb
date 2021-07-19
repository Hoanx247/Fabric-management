Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Text
Public Class List_BangLoi_KyThuat_Execute
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private Ischanged As Boolean = False
    Private _Lbln_action_btn As Integer = 0
    Private _update_Ok As Boolean = False
    Private _Lst_ID As String = String.Empty
    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        If Ischanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
        Me.Dispose()
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        '//
        If _Congdoan_Status = 1 Then
            _Lbln_action_btn = 1
            Call Clear_TextBox()
            btnSave.Text = "Lưu Lại"
            txtmaCongdoan.Focus()
        ElseIf _Congdoan_Status = 2 Then
            _Lbln_action_btn = 2
            btnSave.Text = "Cập Nhật"
            Call Load_TextBox()
            txtmaCongdoan.Focus()
        ElseIf _Congdoan_Status = 3 Then
            _Lbln_action_btn = 1
            btnSave.Text = "Lưu Lại"
            Call Load_TextBox()
            txtmaCongdoan.Focus()
        End If
    End Sub

    Private Sub Load_TextBox()

        Dim panel As GridPanel = List_Congdoan.Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        With dgvr
            _Lst_ID = .Cells(_colMaCongdoan_ID).Value
            txtmaCongdoan.Text = .Cells(_colMacongdoan).Value
            txtCongdoan.Text = .Cells(_coltencongdoan).Value
            txtthoigian.Text = .Cells(_colthoigian).Value
            txtghichu.Text = .Cells(_colghichu).Value
            txtClr_selected.BackColor = Color.FromArgb(CInt(dgvr.Cells("chon_mau").Value))
        End With

    End Sub

    Private Sub Clear_TextBox()
        txtid.Text = String.Empty
        txtmaCongdoan.Text = String.Empty
        txtCongdoan.Text = String.Empty
        txtmaCongdoan.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If _Lbln_action_btn = 1 Then
            Call Load_TimeServer()
            _Lst_ID = Format$(MdlData._TimeServer, "yyMMddHHmmss")
            Call Update_Data("", "insert")
            If _update_Ok = True Then
                _update_Ok = False
                Call Clear_TextBox()
                txtmaCongdoan.Focus()
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

        Dim txt As TextBox = CType(txtmaCongdoan, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Mã Công Đoạn.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        txt = CType(txtCongdoan, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Công Đoạn.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
    End Function

    Private Sub Update_Data(ByVal sqlcommand As String, ByVal command As String)
        If CheckData() = True Then
            '//
            Dim _ColorPick As String = String.Empty
            _ColorPick = CStr(txtClr_selected.BackColor.ToArgb)
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("congdoan_id='" + ReplaceTextXML(_Lst_ID) + "' ")
            sbXMLString.Append("macongdoan='" + ReplaceTextXML(txtmaCongdoan.Text) + "' ")
            sbXMLString.Append("tencongdoan='" + ReplaceTextXML(txtCongdoan.Text) + "' ")
            sbXMLString.Append("thoigian='" + CNumber_system(txtthoigian.Text) + "' ")
            sbXMLString.Append("chon_mau='" + ReplaceTextXML(_ColorPick) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlCongDoanUpSet]", sbXMLString.ToString, command)
            _update_Ok = dtControler.UPSET_XML(_dt)
            If _update_Ok = True Then
                Ischanged = True
                '//
            End If

        End If
    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

#Region "COLOR"
    Private m_ColorSelected As Boolean = False
    Private Sub colorPickerCustomScheme_ExpandChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnColorPicker.SelectedColorChanged
        If BtnColorPicker.Expanded Then
            ' Remember the starting color scheme to apply if no color is selected during live-preview
            m_ColorSelected = False
            'm_BaseColorScheme = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable.InitialColorScheme
        Else
            If Not m_ColorSelected Then
                'RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, m_BaseColorScheme)
            End If
        End If
    End Sub
    Private Sub BtnColorPicker_SelectedColorChanged(sender As Object, e As EventArgs) Handles BtnColorPicker.SelectedColorChanged
        m_ColorSelected = True ' Indicate that color was selected for buttonStyleCustom_ExpandChange method
        txtClr_selected.BackColor = BtnColorPicker.SelectedColor
    End Sub

    Private Sub List_Congdoan_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region
End Class