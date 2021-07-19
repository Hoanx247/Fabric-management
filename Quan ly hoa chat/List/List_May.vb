
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text

Public Class List_May
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Dim dt_local As New DataTable
    '--
    Dim _Load_Ok As Boolean = False
    Dim _Local_ColumnWidth_Changed As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Dim _LL1_local As Boolean = False, _LL2_local As Boolean = False, _LL3_local As Boolean = False
    Dim dr2 As DataRow()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"mamay", "tenmay", "sothietbi"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Private _update_ok As Boolean = False

#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object, _
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
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        '--
        AddHandler btnAdd.Click, AddressOf ThemMoi
        'AddHandler CtxFunction_Add.Click, AddressOf ThemMoi
        'AddHandler CtxFunction_Copy.Click, AddressOf SaoChep
        AddHandler btnModify.Click, AddressOf ChinhSua
        'AddHandler CtxFunction_Modify.Click, AddressOf ChinhSua
        AddHandler btnDelete.Click, AddressOf Xoa
        'AddHandler CtxFunction_delete.Click, AddressOf btnDelete_Click
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If _btView = True Then
            btnAdd.Enabled = CBool(IIf(_btAdd = True, True, False))
            btnModify.Enabled = CBool(IIf(_btModify = True, True, False))
            btnDelete.Enabled = CBool(IIf(_btDelete = True, True, False))
            _LL1_local = CBool(IIf(_btmaster = True, True, False))
            _LL2_local = CBool(IIf(_btmaster_1 = True, True, False))
            _LL3_local = CBool(IIf(_btmaster_2 = True, True, False))

            Call Filterdata_Stored()
            '----------------
        Else
            Me.Close()
        End If
    End Sub

#End Region

#Region "SUPERGRID"
    Private Sub Super_Dgv_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellDoubleClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        'Try
        If dgvr IsNot Nothing Then
            ChinhSua(Nothing, Nothing)

        End If

    End Sub
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = CByte(e.GridColumn.ColumnIndex)
            'ShowContextMenu(CtxMenu)
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
        clsDev.SuperDgv_CellValueChanged(sender, e)
    End Sub
    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Super_Dgv.KeyDown
        clsDev.Super_Dgv_KeyDown(sender, e)
    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub

#End Region

#Region " Hien thi len tung trang cua Datagrid"

    Public Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        'Try
        'Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mamay='" + ReplaceTextXML(txtmamay_F.Text) + "' ")
        sbXMLString.Append("tenmay='" + ReplaceTextXML(txttenmay_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("VpsXmlList_MaMay_UpSet", sbXMLString.ToString, "select")
        Super_Dgv.SuspendLayout()
        Super_Dgv.BeginUpdate()
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Super_Dgv.EndUpdate()
        Super_Dgv.ResumeLayout()
        'Call CircleProcess_Stop()
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

#End Region

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmamay_F.KeyDown, _
        txttenmay_F.KeyDown, txtghichu_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

#Region "EXECUTE -DELETE"
    Private Sub ShowModalForm()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm))
        Else
            With List_May_input
                '.Size = New Size(Me.Height * 0.95, .Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Filterdata_Stored()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub
    Private Sub ThemMoi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        _maycang_status = 1
        ShowModalForm()

    End Sub

    Private Sub SaoChep(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If dgvr Is Nothing Then
            'MessageBox.Show("Xin vui lòng chọn chứng từ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _maycang_status = 3
            ShowModalForm()
        End If
    End Sub

    Private Sub ChinhSua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If dgvr Is Nothing Then
            'MessageBox.Show("Xin vui lòng chọn chứng từ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _maycang_status = 2
            ShowModalForm()
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
        Dim EmpID As String = dgvr.Cells(_colMamay_ID).Value.ToString
        Dim Code As String = dgvr.Cells(_colMamay).Value.ToString
        Dim CodeName As String = dgvr.Cells(_coltenmay).Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Máy: " & Code _
                        & vbCrLf & vbCrLf & " - Tên Máy: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mamay_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("VpsXmlList_MaMay_UpSet", sbXMLString.ToString, "delete")
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

#Region "LUU THAY DOI"
    Private Sub btnLuuThayDoi_Click(sender As Object, e As EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện lưu thay đổi?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetailsInsertJob(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("VpsXmlMaMayUpSet", sbXMLString.ToString, "update_luuthaydoi")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub UpdateDetailsInsertJob(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetailsInsertJob(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("mamay_id='" + ReplaceTextXML(row.Cells("mamay_id").Value.ToString) + "' ")
                    sbXMLString.Append("mamay='" + ReplaceTextXML(row.Cells("mamay").Value.ToString) + "' ")
                    sbXMLString.Append("tenmay='" + ReplaceTextXML(row.Cells("tenmay").Value.ToString) + "' ")
                    sbXMLString.Append("nhommay_id='" + ReplaceTextXML(row.Cells("nhommay").Value.ToString) + "' ")
                    sbXMLString.Append("nhom_mau='" + ReplaceTextXML("-") + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

#End Region

    Private Sub ButtonItem_Nhom_Click(sender As Object, e As EventArgs) Handles ButtonItem_Nhom.Click
        ShowModalForm_Nhom()
    End Sub
    Private Sub ShowModalForm_Nhom()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_Nhom))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With List_May_Nhom
                '.Size = New Size(intX_W * 0.95, Me.Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    'Call Filterdata_chung()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub
End Class