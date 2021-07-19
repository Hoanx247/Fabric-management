
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text
Imports System.IO
Imports System.Reflection
Public Class List_CauHinh_Excel
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Dim dt_local As New DataTable
    Private dt_Form As DataTable
    '--
    Dim _Load_Ok As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Dim _LL1_local As Boolean = False, _LL2_local As Boolean = False, _LL3_local As Boolean = False
    Dim dr2 As DataRow()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"ghichu"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Private _update_ok As Boolean = False
    Private Ischanged As Boolean = False
    Private _Lbln_action_btn As Integer = 0
    Private _Lst_ID As String = String.Empty
    Private Lfrmname_id As String = String.Empty
    Private IsProcessing As Boolean = False

#Region "Move Panel"
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point

#Region "GP_Form"
    Private Sub GP_Form_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub
    Private Sub GP_Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form.MouseMove
        If allowCoolMove = True Then
            Me.SuspendLayout()
            With GP_Form
                .Location = New Point(.Location.X + e.X - myCoolPoint.X, .Location.Y + e.Y - myCoolPoint.Y)
            End With
            Me.ResumeLayout()
        End If
    End Sub
    Private Sub GP_Form_CongDoan_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "GP_Form_Folder_Path"
    Private Sub GP_Form_Folder_Path_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_Folder_Path.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub
    Private Sub GP_Form_Folder_Path_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_Folder_Path.MouseMove
        If allowCoolMove = True Then
            Me.SuspendLayout()
            With GP_Form_Folder_Path
                .Location = New Point(.Location.X + e.X - myCoolPoint.X, .Location.Y + e.Y - myCoolPoint.Y)
            End With
            Me.ResumeLayout()
        End If
    End Sub
    Private Sub GP_Form_Folder_Path_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_Folder_Path.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub
#End Region


#End Region

#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        dt_Form = New DataTable
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        With Super_Dgv
            '.PrimaryGrid.CheckBoxes = True
        End With
        '--

        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.CellClick, AddressOf Super_Dgv_CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        '--
        AddHandler btnAdd.Click, AddressOf ThemMoi

        AddHandler btnModify.Click, AddressOf ChinhSua
        AddHandler btnDelete.Click, AddressOf Xoa
        '--
        Call Load_Form()
    End Sub
    Private Sub Load_Form()
        dt_Form = VpsXmlList_Load_Title("", "", "[VpsXmlList_FrmName_UpSet]", "select_load")
        LoadDataToCombox(dt_Form, cboNhom, "frmname", False)
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            'BtnAdd.Enabled = CBool(IIf(_btAdd = True, True, False))
            'BtnModify.Enabled = CBool(IIf(_btModify = True, True, False))
            'BtnDelete.Enabled = CBool(IIf(_btDelete = True, True, False))
            Call Filterdata_Stored()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = CType(sender.PrimaryGrid, GridPanel)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            'ShowContextMenu(CtxFunction)
        End If
        '//
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then Exit Sub
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
        ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
            panel.AllowEdit = False
            panel.ReadOnly = True
        End If
    End Sub

    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        If IsProcessing = True Then Exit Sub
        clsDev.SuperDgv_CellValueChanged(sender, e)
    End Sub

#End Region

#Region " Hien thi len tung trang cua Datagrid"
    Private Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("codename='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlList_InfoExcel_UpSet]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)

        Dim dataSource As Object = Nothing

        '//
        Dim rows() As DataRow = Nothing
        rows = dt_local.Select()
        If rows.Count > 0 Then ' first check to see if the array has rows '
            dataSource = rows.CopyToDataTable() ' dt now exists and contains rows '
        Else
            dataSource = Nothing
        End If
        '--
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        panel.DataSource = dataSource
        IsBusy = False
        Me.ResumeLayout()
    End Sub


    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '//Ẩn Cột
        For Each item As GridElement In panel.Columns
            Dim column As GridColumn = TryCast(item, GridColumn)
            Dim _TFormat As String = String.Empty
            If column.Name.ToLower.Contains("_id") = True Then
                column.Visible = False
            End If
            If column.Name.ToLower.Contains("nhom") = True Then
                column.HeaderText = "Nhóm"
            End If
        Next item
        '//
        '//
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("nhom"), panel.Columns("frmname")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        End If
        '//
        Dim columnA As GridColumn
        columnA = panel.Columns("btnopen_1")
        columnA.EditorType = GetType(MyGridButtonXEditControl)
        '//
        'columnA = panel.Columns("btndelete")
        'columnA.EditorType = GetType(MyGridButtonXEditControl)
        '//
        columnA = panel.Columns("btnopen_folder")
        columnA.EditorType = GetType(MyGridButtonXEditControl)
        '//
        '//
        columnA = panel.Columns("btnchonfile")
        columnA.EditorType = GetType(MyGridButtonXEditControl)
        '//
        Tao_CodeID()
    End Sub
    Public Function GetSortDirDescAscAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection)})
    End Function
#End Region


#Region "EXECUTE-DELETE"
    Private Sub ButtonX_GP_Form_Exit_Click(sender As Object, e As EventArgs) Handles ButtonX_GP_Form_Exit.Click
        GP_Form.Visible = False
    End Sub

    Private Sub ThemMoi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txttinhnang.Text = String.Empty
        txttenfile.Text = String.Empty
        txtghichu.Text = String.Empty
        txttinhnang.Focus()
        txttenfile.ReadOnly = False
        txtghichu.ReadOnly = False
        _Lbln_action_btn = 1
        BtnSave.Text = "Lưu Lại"
        '//
        '//
        With GP_Form
            .Text = "Thêm Mới"
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
            .Location = New Point(CInt((Me.Width / 2) - (.Width / 2)), CInt((Me.Height / 2) - (.Height / 2)))
            .Visible = True
        End With
        '//
        Tao_CodeID()
    End Sub

    Private Sub ChinhSua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If dgvr Is Nothing Then
                Exit Sub
            End If
            txttenfile.ReadOnly = False
            txtghichu.ReadOnly = False
        _Lbln_action_btn = 2
        BtnSave.Text = "Cập Nhật"
        '//
        With GP_Form
            .Text = "Chỉnh Sửa"
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
            .Location = New Point(CInt((Me.Width / 2) - (.Width / 2)), CInt((Me.Height / 2) - (.Height / 2)))
            .Visible = True
        End With
    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("c_id").Value.ToString
        'Dim Code As String = dgvr.Cells("mucdich").Value.ToString
        'Dim CodeName As String = dgvr.Cells("mucdich").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("c_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_InfoExcel_UpSet]", sbXMLString.ToString, "delete")
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

    Private Sub Super_Dgv_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim Lcolname As String = String.Empty
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            'ShowContextMenu(CtxFunction)
        End If
        '///
        If e.MouseEventArgs.Button = MouseButtons.Left Then

        End If
        '///
        If e.GridCell.ColumnIndex = 0 Then
            panel.ReadOnly = False
            panel.AllowEdit = True
            If dgvr.Checked = False Then
                dgvr.Checked = True
                dgvr.CellStyles.Default.Background.Color1 = Color.GreenYellow
            Else
                dgvr.Checked = False
                dgvr.CellStyles.Default.Background.Color1 = Color.Empty
            End If
        ElseIf e.GridCell.ColumnIndex > 0 AndAlso e.GridCell.ColumnIndex <= e.GridPanel.Columns.Count - 1 Then
            Dim result As String = Array.Find(_List_Column_Locked, Function(s) s = e.GridCell.GridColumn.Name.ToLower)
            If result IsNot Nothing Then
                panel.AllowEdit = True
                panel.ReadOnly = False
            Else
                panel.AllowEdit = True
                panel.ReadOnly = False
            End If
        ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
            panel.AllowEdit = False
            panel.ReadOnly = True
        End If
        '//
        If dgvr Is Nothing Then
                txttinhnang.Text = String.Empty
                txttenfile.Text = String.Empty
                txtghichu.Text = String.Empty
                Exit Sub
            Else
                Lcolname = "c_id"
            If panel.Columns.Contains(Lcolname) Then
                _Lst_ID = dgvr.Cells(Lcolname).Value.ToString
            End If
            Lcolname = "frmname"
            If panel.Columns.Contains(Lcolname) Then
                cboNhom.Text = dgvr.Cells(Lcolname).Value.ToString
            End If
            Lcolname = "codename"
            If panel.Columns.Contains(Lcolname) Then
                txtcodename.Text = dgvr.Cells(Lcolname).Value.ToString
            End If
            Lcolname = "tinhnang"
            If panel.Columns.Contains(Lcolname) Then
                txttinhnang.Text = dgvr.Cells(Lcolname).Value.ToString
            End If
            '//
            Lcolname = "folder_path"
            If panel.Columns.Contains(Lcolname) Then
                RichTextBoxEx_Folder_Path.Text = dgvr.Cells(Lcolname).Value.ToString
                RichTextBoxEx_Folder_Path_00.Text = dgvr.Cells(Lcolname).Value.ToString
            End If
            '//
            Lcolname = "fileexcel"
            If panel.Columns.Contains(Lcolname) Then
                txttenfile.Text = dgvr.Cells(Lcolname).Value.ToString
            End If
            '//
            Lcolname = "ghichu"
            If panel.Columns.Contains(Lcolname) Then
                txtghichu.Text = dgvr.Cells(Lcolname).Value.ToString
            End If
            '//
            '//
            'Them <br/> để xuống dòng
            Dim stinfo As String = "<b><font size=""10""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo &= "<font size=""10""><font color=""Black""> {1} </font></font>"
            Dim stinfo_br As String = "<b><font size=""10""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo_br &= "<font size=""10""><font color=""Black""> {1} </font></font><br/>"
            '//

            Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
            '////
            panel.Footer.Text = String.Format(stinfo_br, "+ Đường Dẫn: ", RichTextBoxEx_Folder_Path_00.Text)
            panel.Footer.Text &= String.Format(stinfo, "+ Tên Form (Code): ", cboNhom.Text)
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If _Lbln_action_btn = 1 Then
            _Lst_ID = TaoMa_NgauNhien(4)
            '//
            Call Update_Data("", "insert")
            If _update_ok = True Then
                _update_ok = False
                txttenfile.Focus()
            End If
        ElseIf _Lbln_action_btn = 2 Then
            If MsgBox("Bạn có muốn sửa nội dung không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update")
            End If
        End If

    End Sub

    Private Sub ButtonX_ChonFile_Click(sender As Object, e As EventArgs) Handles ButtonX_ChonFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String
        fd.Title = "Open File Dialog"
        If Len(RichTextBoxEx_Folder_Path.Text) > 1 Then
            fd.InitialDirectory = RichTextBoxEx_Folder_Path_00.Text
        Else
            fd.InitialDirectory = My.Application.Info.DirectoryPath
        End If

        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        Dim Lpath As String = My.Application.Info.DirectoryPath
        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            '//
            txttenfile.Text = fd.SafeFileName.ToString
            'Dim strtext As String = StrReverse(fd.SafeFileName.ToString)
            'txtformatfile.Text = "." & StrReverse(strtext.Split(".")(0))
            '//
            'txttenfile.Text = Mid$(fd.SafeFileName.ToString, 1, fd.SafeFileName.ToString.Length - txtformatfile.Text.Length)
            '//
            Dim LFolder As String = Mid$(strFileName, 1, strFileName.Length - fd.SafeFileName.ToString.Length)
            RichTextBoxEx_Folder_Path_00.Text = LFolder
            '///

        End If
    End Sub

    Private Sub ButtonItem_Refresh_Click(sender As Object, e As EventArgs) Handles ButtonItem_Refresh.Click
        Call Filterdata_Stored()
    End Sub


    Private Function CheckData() As Boolean
        CheckData = True

        Dim txt As TextBoxX = CType(txttinhnang, TextBoxX)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập mã ký tự.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        txt = CType(txttenfile, TextBoxX)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Mục Đích.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        '//
        Dim _value As String = String.Empty
        Dim firstRow As DataRow = dt_Form.Select("frmname = '" & cboNhom.Text & "'", "").FirstOrDefault()

        If Not firstRow Is Nothing Then
            Lfrmname_id = firstRow.Item("frmname_id")
        Else
            Lfrmname_id = String.Empty
            MsgBox("Vui lòng chọn Form.", MsgBoxStyle.Information, "Thông Báo")
            Exit Function
        End If
        '//
    End Function

    Private Sub Update_Data(ByVal sqlcommand As String, ByVal command As String)
        If CheckData() = True Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("c_id='" + ReplaceTextXML(_Lst_ID) + "' ")
            sbXMLString.Append("frmname_id='" + ReplaceTextXML(Lfrmname_id) + "' ")
            sbXMLString.Append("codename='" + ReplaceTextXML(txtcodename.Text) + "' ")
            sbXMLString.Append("tinhnang='" + ReplaceTextXML(txttinhnang.Text) + "' ")
            sbXMLString.Append("folder_excel='" + ReplaceTextXML("") + "' ")
            sbXMLString.Append("folder_path='" + ReplaceTextXML(RichTextBoxEx_Folder_Path_00.Text) + "' ")
            sbXMLString.Append("fileexcel='" + ReplaceTextXML(txttenfile.Text) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_InfoExcel_UpSet]", sbXMLString.ToString, command)
            _update_ok = dtControler.UPSET_XML(_dt)
            If _update_ok = True Then
                Ischanged = True
                '//
                Call Filterdata_Stored()
                '//
            End If

        End If
    End Sub

#Region "TAO MA ID"
    Private Sub Tao_CodeID()
        '//Ma Don Hang
        Dim LCodeName As String = String.Empty
        Dim LStt As String = String.Empty
        For y = 1 To 99
            LStt = "00" & y
            LStt = gRight(LStt, 3)
            LCodeName = "F" & LStt
            If SearchUsingForLoop(LCodeName) = False Then
                GoTo SWERLExit
                Exit For
            End If
        Next

SWERLExit:
        txtcodename.Text = LCodeName
    End Sub
    Private Function SearchUsingForLoop(ByVal TCodeName As String) As Boolean
        Dim result As Boolean = False
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                RichTextBoxEx_Folder_Path.Text = row.Cells("folder_path").Value.ToString
                '//
                If row.Cells("codename").FormattedValue.ToUpper = TCodeName.ToUpper Then
                    result = True
                End If
            End If
        Next
        Return result
    End Function
#End Region



#Region "MyGridButtonXEditControl"

    ''' <summary>
    ''' GridButtonXEditControl Class that controls the
    ''' ButtonX color initialization and user button clicks.
    ''' </summary>
    Private Class MyGridButtonXEditControl
        Inherits GridButtonXEditControl
        ''' <summary>
        ''' Constructor
        ''' </summary>
        Public Sub New()
            ' We want to be notified when the user clicks the button
            ' so that we can change the underlying cell value to reflect
            ' the mouse click.

            AddHandler Click, AddressOf MyGridButtonXEditControlClick
        End Sub

#Region "InitializeContext"

        ''' <summary>
        ''' Initializes the color table for the button
        ''' </summary>
        ''' <param name="cell"></param>
        ''' <param name="style"></param>
        Public Overrides Sub InitializeContext(ByVal cell As GridCell, ByVal style As CellVisualStyle)
            MyBase.InitializeContext(cell, style)

            Dim running As Boolean = Text.Equals("Mở File") = False

            ColorTable = IIf(running = True, eButtonColor.OrangeWithBackground, eButtonColor.BlueOrb)
        End Sub

#End Region

#Region "MyGridButtonXEditControlClick"

        ''' <summary>
        ''' Handles user clicks of the button
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MyGridButtonXEditControlClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim running As Boolean = (EditorCell.Value IsNot Nothing)
            'EditorCell.GridRow.IsDeleted = True
            'EditorCell.Value = IIf(running = True, "Stop", "Start")
            ' Call ShowDialog.
            If EditorCell.Value.Equals("Mở File") Then
                Dim strFolder_path As String = EditorCell.GridRow.Cells("folder_path").Value
                Dim strFileName As String = EditorCell.GridRow.Cells("fileexcel").Value.ToString
                '///
                If strFileName IsNot Nothing AndAlso Len(strFileName) > 4 Then
                    Dim Filename As String = strFolder_path & "\" & strFileName
                    If System.IO.File.Exists(Filename) = False Then
                        MsgBox("Vui lòng kiểm tra file (" & Filename & ").", MsgBoxStyle.Information, "Thông Báo")
                    Else
                        System.Diagnostics.Process.Start(Filename)
                    End If

                End If
            End If
            '//Chon File
            If EditorCell.Value.Equals("Chọn File") Then
                Dim strFolder_path As String = EditorCell.GridRow.Cells("folder_path").Value
                If Len(strFolder_path) > 0 Then
                    '//
                    Dim fd As OpenFileDialog = New OpenFileDialog()
                    Dim strFileName As String
                    fd.Title = "Open File Dialog"
                    If strFolder_path.Length > 3 Then
                        fd.InitialDirectory = strFolder_path & "\"
                    Else
                        fd.InitialDirectory = My.Application.Info.DirectoryPath & "\"
                    End If

                    fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
                    fd.FilterIndex = 2
                    fd.RestoreDirectory = True

                    If fd.ShowDialog() = DialogResult.OK Then
                        strFileName = fd.FileName
                        '//
                        EditorCell.GridRow.Cells("fileexcel").Value = fd.SafeFileName.ToString
                    End If
                End If

            End If
            '//Mo Folder
            If EditorCell.Value.Equals("Mở Folder") Then
                Dim strFolderPath As String = EditorCell.GridRow.Cells("folder_path").Value
                If strFolderPath.Length > 1 Then
                    Process.Start(strFolderPath)
                End If

            End If
            '//
            If EditorCell.Value.Equals("Xóa") Then
                'EditorCell.GridRow.IsDeleted = True
            End If
        End Sub

#End Region
    End Class

#End Region


#Region "BROWSE FOLDER"
    Private Sub ButtonItem_ChonThuMuc_Click(sender As Object, e As EventArgs) Handles ButtonItem_ChonThuMuc.Click
        '//
        With GP_Form_Folder_Path
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
            .Location = New Point(CInt((Me.Width / 2) - (.Width / 2)), CInt((Me.Height / 2) - (.Height / 2)))
            .Visible = True
        End With
        '//
    End Sub
    Private Sub BtnHidden_Panel_Folder_Path_Click(sender As Object, e As EventArgs) Handles BtnHidden_Panel_Folder_Path.Click
        GP_Form_Folder_Path.Visible = False
    End Sub

#Region "GET PATH LOCAL SHARE"
    Private Sub ButtonX_Browser_Path_Click(sender As Object, e As EventArgs) Handles ButtonX_Browser_Path.Click
        If CheckBoxX_LocalNetwork.CheckState = CheckState.Unchecked Then
            'Dim fd As FolderBrowserDialog = New FolderBrowserDialog()
            'If fd.ShowDialog() = DialogResult.OK Then
            'TxtFolder_path.Text = fd.SelectedPath.ToString
            Dim objFolderDialog As New FolderBrowserDialog()
            '===== Pass object as Parameter and get Selected network folder
            RichTextBoxEx_Folder_Path.Text = GetNetworkFolders(objFolderDialog, False)

        Else
            '====== Create folder dialog box object
            Dim objFolderDialog As New FolderBrowserDialog()
            '===== Pass object as Parameter and get Selected network folder
            RichTextBoxEx_Folder_Path.Text = GetNetworkFolders(objFolderDialog, True)
        End If

    End Sub


    ''' <summary>
    ''' This function will get the Folderdialog as parameter and return the Selected
    ''' Folders UNC path. 
    ''' Ex: \\Server1\TestFolder
    ''' </summary>
    ''' <param name="oFolderBrowserDialog"></param>
    ''' <returns>it will return the Selected Folders UNC Path</returns>
    ''' <remarks></remarks>
    Public Shared Function GetNetworkFolders(ByVal oFolderBrowserDialog As FolderBrowserDialog, ByVal IsLocal As Boolean) _
                           As String
        If IsLocal = False Then
        Else
            '======= Get type of Folder Dialog bog
            Dim type As Type = oFolderBrowserDialog.[GetType]
            '======== Get Fieldinfo for rootfolder.
            Dim fieldInfo As Reflection.FieldInfo = type.GetField("rootFolder",
                        BindingFlags.NonPublic Or BindingFlags.Instance)
            '========= Now set the value for Folder Dialog using DirectCast
            '=== 18 = Network Neighborhood is the root
            fieldInfo.SetValue(oFolderBrowserDialog, DirectCast(18, Environment.SpecialFolder))
            '==== if user click on Ok, then it will return the selected folder.
            '===== otherwise return the blank string.
        End If

        If oFolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Return oFolderBrowserDialog.SelectedPath
        Else
            Return ""
        End If
    End Function

    Private Sub BtnFolder_Path_Save_Click(sender As Object, e As EventArgs) Handles BtnFolder_Path_Save.Click
        '//
        If IsProcessing = True Then Exit Sub
        IsProcessing = True
        '//
        Dim LblnChecked As Boolean = False
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        For Each item As GridElement In panel.Rows
            Dim Row As GridRow = TryCast(item, GridRow)
            Dim _TFormat As String = String.Empty
            If Row IsNot Nothing AndAlso Row.IsDetailRow = False AndAlso Row.Visible = True AndAlso Row.Checked = True Then
                sbXMLString.Append("<DATA ")
                sbXMLString.Append("c_id='" + ReplaceTextXML(Row.Cells("c_id").Value.ToString) + "' ")
                sbXMLString.Append("folder_path='" + ReplaceTextXML(RichTextBoxEx_Folder_Path.Text) + "' ")
                sbXMLString.Append(" />")
                LblnChecked = True
            End If
        Next item
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("VpsXmlList_InfoExcel_UpSet", sbXMLString.ToString, "update_path")
        If LblnChecked = True Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
            '//
        End If
        IsProcessing = False
    End Sub

#End Region

#End Region

#Region "EXCEL"
    Private Sub BtnExport_Excel_Click(sender As Object, e As EventArgs) Handles BtnExport_Excel.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If Super_Dgv.PrimaryGrid.Rows.Count = 0 Then
            Exit Sub
        End If
        '--
        Dim btn As ButtonItem = CType(sender, ButtonItem)
        With btn
            .Text = "Xin Chờ..."
            .Enabled = False
            If MsgBox("Bạn có Muốn In (Yes: In / No: Thoát) ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "In PDF") = MsgBoxResult.Yes Then
                _IsPrint = False
                _IsPrint_PrintArea = True
                _IsPrint_Sum = True
                _IsPrint_GridArea = True
                _IsNotPrint_GroupName = True
                '//
                Call ExportExcel()
                _IsPrint_PrintArea = False
                _IsPrint_Sum = False
                _IsPrint_GridArea = False
                _IsNotPrint_GroupName = False
            End If
            .Text = "Xuất Excel"
            .Enabled = True
        End With
    End Sub
    Private Sub ExportExcel()
        moClsExcel = New ClsExportExcel
        With moClsExcel
            Dim dtExcel As DataTable = VpsXmlList_Load_Title("", "List_Excel", "[VpsXmlList_InfoExcel_UpSet]", "select_id")
            If dtExcel.Rows.Count = 1 Then
                .strfolder_path = dtExcel.Rows(0).Item("folder_path")
                .strfileExcel_1 = dtExcel.Rows(0).Item("fileexcel")
            Else
                Exit Sub
            End If
            '//
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "c_id", "frmname_id", "codename", "tinhnang", "fileexcel", "folder_excel", "ghichu"}
            ._rangeExcel_Text = {}
            ._rangeExcel_number_0 = {}
            ._rangeExcel_number_1 = {}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "W"}
            ._GridArea = {"A", "W"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {}
        End With
        '//
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _GdtNgayIn_1 = Format$(Now, "dd/MM/yyyy")
        _GdtNgayIn_2 = String.Empty
        '//
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub
#End Region
End Class