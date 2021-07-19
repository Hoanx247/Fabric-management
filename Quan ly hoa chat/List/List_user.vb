Option Strict Off

Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text
Public Class List_user
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private moClsEncrypt As ClsEncrypt
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private dt_local As DataTable
    Private dt_nhom As DataTable
    '--
    Dim dr2 As DataRow()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"frmnamefull", "formgroup", "stt"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Dim _Column_Forzen_pos As Integer = 0
    Dim _saveRowIndex As Integer = 0
    Private _update_ok As Boolean = False
    Private LUserId As String = String.Empty
    Private LNhomId As String = String.Empty
    Private _Lbln_action As Int16 = 0
    Private Ischanged As Boolean = False

#Region "Load du lieu hien thi"
    Private Sub Me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        moClsEncrypt = New ClsEncrypt
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        dt_nhom = New DataTable

        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        'AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '--
        AddHandler ButtonItem_Add.Click, AddressOf ThemMoi
        AddHandler CtxFunction_Add.Click, AddressOf ThemMoi
        AddHandler ButtonItem_Modify.Click, AddressOf ChinhSua
        AddHandler CtxFunction_Modify.Click, AddressOf ChinhSua
        AddHandler ButtonItem_Delete.Click, AddressOf Xoa
        AddHandler CtxFunction_delete.Click, AddressOf Xoa

        Load_Nhom()
    End Sub
    Private Sub Load_Nhom()
        dt_nhom = VpsXmlList_Load("", "", "nhom_user")
        LoadDataToCombox(dt_nhom, cboNhom_chung, "nhom", False)
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If _btView = True Then
            ButtonItem_Add.Enabled = CBool(IIf(_btAdd = True, True, False))
            ButtonItem_Modify.Enabled = CBool(IIf(_btModify = True, True, False))
            ButtonItem_Delete.Enabled = CBool(IIf(_btDelete = True, True, False))
            '----------
            Call Filterdata_chung()
            '----------------
        Else
            Me.Close()
        End If
    End Sub


    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = CByte(e.GridColumn.ColumnIndex)
            ShowContextMenu(CtxMenu)
        End If
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        End If
        _saveRowIndex = e.GridCell.RowIndex
    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub
#End Region

#Region "LOAD DATA"

    Private Sub CircleProcess_Start()
        Try
            With CircularProgress1
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .IsRunning = True
                .Visible = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CircleProcess_Stop()
        wait(200)
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub

    Private Sub Filterdata_chung()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        'Try
        Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("VpsXmlList_User_UpSet", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Call CircleProcess_Stop()
        IsBusy = False
    End Sub
#Region "SUM"
    Private IsLoad_Finished As Boolean = False
    Private _array_column As String() = {"socay_1"}
    Private _array_value As Decimal() = {0, 0, 0, 0}
    Private tpress As New Timer With {.Interval = 200}
    Private _blnPress As Boolean = False

    Private Sub Super_Dgv_FilterEditValueChanged(sender As Object, e As GridFilterEditValueChangedEventArgs) Handles Super_Dgv.FilterEditValueChanged
        Super_Dgv.SuspendLayout()
        _blnPress = False
        tpress.Enabled = False
        tpress.Enabled = True
        Super_Dgv.ResumeLayout()
    End Sub

    Sub MyTickHandler(ByVal sender As Object, ByVal e As EventArgs)
        '//
        tpress.Enabled = False
        _blnPress = True
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        ReDim Preserve _array_value(_array_column.Length)
        Array.Clear(_array_value, 0, _array_value.Length)

        Call UpdateShowALLRows(panel.Rows)

        'lblRow.Text = "Tổng số: " & n
        Dim st As String = "<div align=""center"">" & "<font color=""red"">{0}</font><br/>" & "<font color=""green"">{1}</font>" & "</div>"
        For x As Integer = 0 To _array_column.Length - 1
            If columns.Contains(_array_column(x)) = True Then
                With panel.Columns(_array_column(x))
                    .EnableHeaderMarkup = True
                    Dim stHeaderText As String = clsDev.Show_1Column(_array_column(x))
                    Dim stValue As Decimal = _array_value(x)
                    .HeaderText = String.Format(st, stHeaderText, FormatNumber(stValue, _intFormatText))
                End With
            End If
        Next
    End Sub

    Private Sub UpdateShowALLRows(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        '////
        For Each item As GridElement In rows
            If _blnPress = False Then Exit For
            If item.Visible = True Then

                Dim group As GridGroup = TryCast(item, GridGroup)
                If group IsNot Nothing Then
                    UpdateShowALLRows(group.Rows)
                Else
                    Dim row As GridRow = TryCast(item, GridRow)
                    If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                        If ExistsColumnGridPanel(panel, "chon_mau") = True Then
                            If CBool(row.Cells("chon_mau").Value) = True Then
                                row.CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
                                row.RowStyles.Default.RowHeaderStyle.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
                            End If
                        End If

                        For x As Integer = 0 To _array_column.Length - 1
                            If _blnPress = False Then Exit For
                            If ExistsColumnGridPanel(panel, _array_column(x)) = True Then
                                _sValue = _array_value(x)
                                _sValue += row.Cells(_array_column(x)).Value
                                _array_value.SetValue(_sValue, x)
                            End If
                        Next
                    End If
                End If

            End If
        Next

    End Sub

#End Region

    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns

        'panel.AddGroup(panel.Columns(_colnhomhc))
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("nhom")}
        If panel.SortColumns.Count = 1 Then
            panel.SetSort(sortCols, clsDev.GetSortDir_Asc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirAscAsc(sortCols))
        End If
        '//

        tpress.Enabled = True
    End Sub


#End Region

#Region "EXECUTE - DELETE"
    Private Sub Display_Grp_Info()
        With Grp_Info
            .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
            .Visible = True
        End With
    End Sub

    Private Sub ThemMoi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Call ClearTextBox()
            '--
            Call Display_Grp_Info()
            Grp_Info.Text = "Thêm Mới Tài Khoản"
            '--
            btnSave.Text = "Lưu Lại"
            _Lbln_action = 1
            '--
            txtuser_chung.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChinhSua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Try
            If dgvr Is Nothing Then
                MessageBox.Show("Xin vui lòng chọn dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Call Display_Grp_Info()
            Grp_Info.Text = "Cập Nhật"
            _Lbln_action = 2
            btnSave.Text = "Cập Nhật"
            With Me
                LUserId = dgvr.Cells("userid").Value.ToString
                .txtuser_chung.Text = dgvr.Cells("tentruycap").Value.ToString
                '.txtpass_chung.Text = dgvr.Cells("matkhau").Value.ToString
                .cboNhom_chung.Text = dgvr.Cells("nhom").Value.ToString
                .txtten_chung.Text = dgvr.Cells("hoten").Value.ToString
                LNhomId = dgvr.Cells("nhom_id").Value.ToString
            End With
            '--
            txtuser_chung.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("userid").Value.ToString
        Dim Code As String = dgvr.Cells("tentruycap").Value.ToString
        Dim CodeName As String = dgvr.Cells("hoten").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Số: " & Code _
                        & vbCrLf & vbCrLf & " - Công Đoạn: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("code_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("VpsXmlList_User_UpSet", sbXMLString.ToString, "delete")
            _update_ok = dtControler.UPSET_XML(_dt)
            If _update_ok = True Then
                'ISChanged = True
                '//
                Call Filterdata_chung()
            End If
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub

    Private Sub ClearTextBox()
        txtuser_chung.Text = String.Empty
        txtpass_chung.Text = String.Empty
        txtten_chung.Text = String.Empty
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If _Lbln_action = 1 Then

            LUserId = TaoMa_NgauNhien(6)
            Call Update_Data("", "insert")
            If _update_ok = True Then
                _update_ok = False
                txtuser_chung.Focus()
            End If
        ElseIf _Lbln_action = 2 Then
            If MsgBox("Bạn có muốn sửa nội dung không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update")
            End If
            btnExit_Click(Nothing, Nothing)
        End If
    End Sub

    Private Function CheckData() As Boolean
        CheckData = True
        '//
        'Dim row As DataRow
        dr2 = dt_nhom.Select("nhom = '" & cboNhom_chung.Text & "'", "")
        If dr2.Length = 0 Then
            CheckData = False
            MsgBox("Vui lòng chọn Nhóm Người Dùng.", MsgBoxStyle.Information, "Thông Báo")
            Exit Function
        Else
            LNhomId = dr2.First.Item("nhom_id").ToString
        End If
        '//Don Vi
        Dim txt As TextBox = CType(txtuser_chung, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập người dùng.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        '//
        If _Lbln_action = 1 Then
            txt = CType(txtpass_chung, TextBox)
            If Len(txt.Text) < 6 Then
                CheckData = False
                MsgBox("Mật Khẩu phải hơn 5 ký tự. Vui lòng nhập lại.", MsgBoxStyle.Exclamation, "Thông Báo!")
                txt.Focus()
                Exit Function
            End If
        End If

    End Function

    Private Sub Update_Data(ByVal sqlcommand As String, ByVal command As String)
        If CheckData() = True Then
            '//
            Dim _matkhau As String = moClsEncrypt.EncryptHD(txtpass_chung.Text)
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("userid='" + ReplaceTextXML(LUserId) + "' ")
            sbXMLString.Append("tentruycap='" + ReplaceTextXML(txtuser_chung.Text) + "' ")
            sbXMLString.Append("matkhau='" + ReplaceTextXML(_matkhau) + "' ")
            sbXMLString.Append("hoten='" + ReplaceTextXML(txtten_chung.Text) + "' ")
            sbXMLString.Append("nhom_id='" + ReplaceTextXML(LNhomId) + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_User_UpSet]", sbXMLString.ToString, command)
            If dtControler.UPSET_XML(_dt) = True Then
                Call Filterdata_chung()
            End If
        End If
    End Sub


#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Call ClearTextBox()
        Grp_Info.Visible = False
    End Sub

    Private Sub ShowModalForm_Nhom()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_Nhom))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With List_User_Nhom
                '.Size = New Size(Me.Width * 0.95, Me.Height)
                .StartPosition = FormStartPosition.CenterParent
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


    Private Sub ButtonItem_Nhom_Click(sender As Object, e As EventArgs) Handles ButtonItem_Nhom.Click
        ShowModalForm_Nhom()
    End Sub

End Class