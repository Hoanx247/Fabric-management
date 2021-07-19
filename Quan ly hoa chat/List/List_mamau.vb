Option Strict Off
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

Imports System.Text

Public Class List_mamau
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
    Private _List_Column_Locked As String() = {"ghichu"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Private _update_ok As Boolean = False

#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object, _
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()
        '--
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
    End Sub


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        '--
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        'AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        '--
        AddHandler btnAdd.Click, AddressOf ThemMoi
        AddHandler CtxFunction_Add.Click, AddressOf ThemMoi
        AddHandler BtnModify.Click, AddressOf ChinhSua
        AddHandler CtxFunction_Modify.Click, AddressOf ChinhSua
        'AddHandler btnDelete.Click, AddressOf Xoa
        'AddHandler CtxFunction_delete.Click, AddressOf Xoa
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call Check_administrator(Me.Name.ToString)
        If _btView = True Then
            btnAdd.Enabled = CBool(IIf(_btAdd = True, True, False))
            btnModify.Enabled = CBool(IIf(_btModify = True, True, False))
            btnDelete.Enabled = CBool(IIf(_btDelete = True, True, False))
            '----------
            Call Filterdata_Stored()
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
        Dim panel As GridPanel = CType(sender.PrimaryGrid, GridPanel)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
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
                panel.AllowEdit = True
                panel.ReadOnly = False
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

    Public Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        'Try
        Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(txtmamau_F.Text) + "' ")
        sbXMLString.Append("codename='" + ReplaceTextXML(txtmau_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlList_MaMau_UpSet]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Call CircleProcess_Stop()
        IsBusy = False
    End Sub

#Region "SUM"

    Dim _array_column As String() = {}
    Dim _array_value As Decimal() = {0, 0, 0, 0}
    Private tpress As New Timer With {.Interval = 200}
    Dim _blnPress As Boolean = False

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
                        If CBool(row.Cells("isactive").Value) = False Then
                            row.Cells("isactive").CellStyles.Default.Background.Color1 = Color.Red

                        Else
                            row.Cells("isactive").CellStyles.Default.Background.Color1 = Color.Empty
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

        '
        tpress.Enabled = True
    End Sub


#End Region

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmamau_F.KeyDown, _
        txtmau_F.KeyDown, txtghichu_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

#Region "EXECUTE - DELETE"
    Private Sub ShowModalForm()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With List_mamau_input
                .Size = New Size(Me.Width * 0.95, .Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_Stored()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub
    Private Sub ThemMoi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _mamau_status = 1
        ShowModalForm()
    End Sub

    Private Sub SaoChep(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If dgvr Is Nothing Then Exit Sub
        _mamau_status = 3
        ShowModalForm()


    End Sub


    Private Sub ChinhSua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If dgvr Is Nothing Then Exit Sub

        _mamau_status = 2
        ShowModalForm()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("mamau_id").Value.ToString
        Dim Code As String = dgvr.Cells("mamau").Value.ToString
        Dim CodeName As String = dgvr.Cells("tenmau").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Màu: " & Code _
                        & vbCrLf & vbCrLf & " - Tên Màu: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mamau_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("VpsXmlList_MaMau_UpSet", sbXMLString.ToString, "delete")
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

    Private Sub BtnEnable_Click(sender As Object, e As EventArgs) Handles BtnEnable.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("mamau_id").Value.ToString
        Dim Code As String = dgvr.Cells("mamau").Value.ToString
        Dim CodeName As String = dgvr.Cells("tenmau").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn Sử Dụng:" _
                        & vbCrLf & vbCrLf & " - Mã Màu: " & Code _
                        & vbCrLf & vbCrLf & " - Tên Màu: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            FunctionOfUser("update_enable")
        End If
    End Sub

    Private Sub BtnDiable_Click(sender As Object, e As EventArgs) Handles BtnDiable.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("mamau_id").Value.ToString
        Dim Code As String = dgvr.Cells("mamau").Value.ToString
        Dim CodeName As String = dgvr.Cells("tenmau").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn NGƯNG SỬ DỤNG:" _
                        & vbCrLf & vbCrLf & " - Mã Màu: " & Code _
                        & vbCrLf & vbCrLf & " - Tên Màu: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            FunctionOfUser("update_disable")
        End If
    End Sub
    Private Sub FunctionOfUser(ByVal _sqlcommand As String)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("mamau_id").Value.ToString

        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mamau_id='" + ReplaceTextXML(EmpID) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("VpsXmlList_MaMau_UpSet", sbXMLString.ToString, _sqlcommand)
        _update_ok = dtControler.UPSET_XML(_dt)
        If _update_ok = True Then
            '//
            Call Filterdata_Stored()
        End If

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
            With List_MaMau_Nhom
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