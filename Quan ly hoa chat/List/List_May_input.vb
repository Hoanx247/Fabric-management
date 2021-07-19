Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Text

Public Class List_May_input
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private Ischanged As Boolean = False
    Private _Lbln_action_btn As Integer = 0
    Private _update_Ok As Boolean = False
    Private _Lst_ID As String = String.Empty
    Private _intBtn As Int16 = 0
    Private dt_nhommay As DataTable
    Private Lnhommay_id As String = String.Empty
    Dim dr2 As DataRow()
    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        If Ischanged = True Then
            Me.DialogResult = DialogResult.OK
        End If

        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        '//
        dt_nhommay = New DataTable
        '//
        Load_NhomMay()
    End Sub
    Private Sub Load_NhomMay()
        dt_nhommay = VpsXmlList_Load("", "", "nhommay")
        LoadDataToCombox(dt_nhommay, cboNhom, "nhommay", True)
        cboNhom.SelectedIndex = -1
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If _maycang_status = 1 Then
            _intBtn = 1
            Call Clear_TextBox()
            cmdSave.Text = "Lưu Lại"
        ElseIf _maycang_status = 2 Then
            _intBtn = 2
            Call Load_TextBox()
            cmdSave.Text = "Cập Nhật"
        ElseIf _maycang_status = 3 Then
            _intBtn = 1
            Call Load_TextBox()
            cmdSave.Text = "Lưu Lại"
        End If
        txtmamay.Focus()
    End Sub

    Private Sub Tao_ID()
        Call MdlData.Load_TimeServer()
        _Lst_ID = Format$(_TimeServer, "yMdHmmss")
    End Sub

    Private Function CheckData() As Boolean
        CheckData = True

        Dim txt As TextBox = CType(txtmamay, TextBoxX)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Mã Máy.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        txt = CType(txttenmay, TextBoxX)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Tên Máy.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
    End Function

    Private Sub Update_Data(ByVal st As String, ByVal _command As String)
        If CheckData() = True Then
            dr2 = dt_nhommay.Select("nhommay = '" & cboNhom.Text & "'", "")
            If dr2.Length > 0 Then
                Lnhommay_id = dr2.First.Item("nhommay_id")
            Else
                MsgBox("Vui lòng chọn nhóm máy.", MsgBoxStyle.Information, "Thông Báo")
                Exit Sub
            End If
            '//
            '//
            Dim _ColorPick As String = String.Empty
            '_ColorPick = CStr(txtClr_selected.BackColor.ToArgb)
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mamay_id='" + ReplaceTextXML(_Lst_ID) + "' ")
            sbXMLString.Append("mamay='" + ReplaceTextXML(txtmamay.Text) + "' ")
            sbXMLString.Append("tenmay='" + ReplaceTextXML(txttenmay.Text) + "' ")
            sbXMLString.Append("nhommay_id='" + ReplaceTextXML(Lnhommay_id) + "' ")
            sbXMLString.Append("chonmau='" + ReplaceTextXML(_ColorPick) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_MaMay_UpSet]", sbXMLString.ToString, _command)
            _update_Ok = dtControler.UPSET_XML(_dt)
            If _update_Ok = True Then
                Ischanged = True
                '//
            End If

        End If
    End Sub

    Private Sub Load_TextBox()
        Try
            Dim panel As GridPanel = List_May.Super_Dgv.PrimaryGrid
            Dim dgvr As GridRow = panel.ActiveRow
            With dgvr
                _Lst_ID = .Cells(_colMamay_ID).Value
                txtmamay.Text = Trim(.Cells(_colMamay).Value)
                txttenmay.Text = Trim(.Cells(_coltenmay).Value)
                cboNhom.Text = Trim(.Cells("nhommay").Value)
                txtghichu.Text = Trim(.Cells(_colghichu).Value)
            End With
        Catch ex As Exception
            txtmamay.Focus()
        End Try
    End Sub

    Private Sub Clear_TextBox()
        txtid.Text = String.Empty
        txttenmay.Text = String.Empty
        txttenmay.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If _intBtn = 1 Then
            Call Tao_ID()
            Call Update_Data("[VpsXmlList_MaMay_UpSet]", "insert")
            If _update_Ok = True Then
                Call Clear_TextBox()
                txttenmay.Focus()
            End If
        Else
            Call Update_Data("[VpsXmlList_MaMay_UpSet]", "update")
            If _update_Ok = True Then
                Me.Close()
            End If
        End If

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

End Class