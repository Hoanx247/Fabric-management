
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Text
Public Class List_mamau_input
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private dt_local As DataTable
    Private dt_nhom As DataTable
    '//
    Dim stCommand As String = String.Empty
    Dim _update_Ok As Boolean = False
    Private _Lbln_action_btn As Integer = 0
    Private _nhom_id As String = String.Empty
    Private dr0 As DataRow()
    Private Ischanged As Boolean = False
    Private _Lst_ID As String = String.Empty
    Private IsBusy As Boolean = False

    Private Sub Me_FormClosing(ByVal sender As Object, _
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        If Ischanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        dt_nhom = New DataTable
        '//
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        '//
        Load_Nhom()
    End Sub
    Private Sub Load_Nhom()
        dt_nhom = VpsXmlList_Load("", "", "nhom_mamau")
        LoadDataToCombox(dt_nhom, cboNhomMau, "nhommau", False)
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        If _mamau_status = 1 Then
            Call Clear_TextBox()
            cmdSave.Text = "Lưu Lại"
            _Lbln_action_btn = 1
            txtmamau.Focus()
        ElseIf _mamau_status = 2 Then
            _Lbln_action_btn = 2
            Call Load_TextBox()
            cmdSave.Text = "Cập Nhật"
            txtmamau.Focus()
        End If
    End Sub
    Private Sub Taophieumoi()
        Dim _Nam As String
        _Nam = Mid$(Now.Year.ToString, 3, 2)
        Dim str_sophieu As String = "MM" & _Nam
        _Lst_ID = VpsXmlList_CreateID(str_sophieu, "mamau")
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If _Lbln_action_btn = 1 Then
            Taophieumoi()
            Call Update_Data("", "insert")
            If _update_Ok = True Then
                _update_Ok = False
                Call Clear_TextBox()
                txtmamau.Focus()
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
        Dim _value As String = String.Empty
        Dim firstRow As DataRow = dt_nhom.Select("nhommau = '" & cboNhomMau.Text & "'", "").FirstOrDefault()

        If Not firstRow Is Nothing Then
            _nhom_id = firstRow.Item("nhommau_id")
        Else
            _nhom_id = String.Empty
            MsgBox("Vui lòng chọn Nhóm Màu.", MsgBoxStyle.Information, "Thông Báo")
            Exit Function
        End If
        '//
        Dim txt As TextBox = CType(txtmamau, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Mã Màu.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        '//
        txt = CType(txttenmau, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Tên Màu.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        If cboNhomMau.SelectedIndex = 0 Then

        End If
    End Function

    Private Sub Update_Data(ByVal sqlcommand As String, ByVal command As String)
        If CheckData() = True Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mamau_id='" + ReplaceTextXML(_Lst_ID) + "' ")
            sbXMLString.Append("mamau='" + ReplaceTextXML(txtmamau.Text) + "' ")
            sbXMLString.Append("tenmau='" + ReplaceTextXML(txttenmau.Text) + "' ")
            sbXMLString.Append("maquitrinh='" + ReplaceTextXML(txtmaquitrinh.Text) + "' ")
            sbXMLString.Append("nhommau_id='" + ReplaceTextXML(_nhom_id) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_MaMau_UpSet]", sbXMLString.ToString, command)
            _update_Ok = dtControler.UPSET_XML(_dt)
            If _update_Ok = True Then
                Ischanged = True
                '//
            End If

        End If
    End Sub

    Private Sub Load_TextBox()
        'Try
        Dim panel As GridPanel = List_mamau.Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        With dgvr
            _Lst_ID = .Cells(_colMamau_ID).Value
            txtmamau.Text = .Cells(_colMamau).Value
            txttenmau.Text = .Cells("tenmau").Value
            'txtmaquitrinh.Text = .Cells("maquitrinh").Value
            cboNhomMau.Text = .Cells("nhommau").Value
            txtghichu.Text = .Cells(_colghichu).Value
        End With
        Filterdata_Stored()
    End Sub
    Private Sub Clear_TextBox()
        _Lst_ID = String.Empty
        txtmamau.Text = String.Empty
        txttenmau.Text = String.Empty
        txtmamau.Focus()
    End Sub
    Protected Overloads Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            Return MyBase.ProcessDialogKey(Keys.Tab)
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function

    Private Sub txtmamau_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmamau.TextChanged

        Dim theText As String = txtmamau.Text
            Dim txtbox As TextBoxX = CType(sender, TextBoxX)
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
            Call Filterdata_Stored()
            txtbox.Text = theText
            txtbox.Select(SelectionIndex - Change, 0)
            'Call filte()


    End Sub

    Private Sub Filterdata_Stored()
        If IsBusy = True Then Return
        IsBusy = True
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(txtmamau.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("VpsXmlList_MaMau_UpSet", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)

        IsBusy = False

    End Sub


    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class