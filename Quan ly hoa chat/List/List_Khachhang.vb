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

Public Class List_Khachhang
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Dim dt_local As New DataTable
    Dim dt_khachhang As New DataTable
    '--
    Dim _Load_Ok As Boolean = False
    Dim _Local_ColumnWidth_Changed As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Dim _LL1_local As Boolean = False, _LL2_local As Boolean = False, _LL3_local As Boolean = False
    Dim dr2 As DataRow()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"ghichu", "nganhnghe", "nguoilienhe"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Private _update_ok As Boolean = False
    Private _makh_id As String = String.Empty
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
        dt_khachhang = New DataTable
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        'AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        '--
        AddHandler btnAdd.Click, AddressOf ThemMoi
        AddHandler CtxFunction_Add.Click, AddressOf ThemMoi
        AddHandler btnCopy.Click, AddressOf SaoChep
        AddHandler CtxFunction_Copy.Click, AddressOf SaoChep
        AddHandler btnModify.Click, AddressOf ChinhSua
        AddHandler CtxFunction_Modify.Click, AddressOf ChinhSua
        AddHandler btnDelete.Click, AddressOf Xoa
        AddHandler CtxFunction_delete.Click, AddressOf Xoa
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
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        End If
        _saveRowIndex = e.GridCell.RowIndex
    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub

    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_ColumnFrozen.Click
        Filterdata_Stored()
    End Sub

#End Region

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
        wait(500)
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub

    Public Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        'Try
        Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("codename='" + ReplaceTextXML(txtkhachhang_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("VpsXmlList_KhachHang_UpSet", sbXMLString.ToString, "select")
        Super_Dgv.SuspendLayout()
        Super_Dgv.BeginUpdate()
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Super_Dgv.EndUpdate()
        Super_Dgv.ResumeLayout()
        Call CircleProcess_Stop()
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

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkhachhang_F.KeyDown, _
        txtdiachi_F.KeyDown, txtnganhnghe_F.KeyDown, txtnguoilienhe_F.KeyDown, txtGhichu_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

#Region "EXECUTE-DELETE"
    Private Sub ShowModalForm()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With List_khachhang_input
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

        _Khachhang_status = 1
            ShowModalForm()

    End Sub

    Private Sub SaoChep(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow

        Try
            _Khachhang_status = 3
            Dim form As List_khachhang_input = New List_khachhang_input
            form.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChinhSua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow

        If dgvr Is Nothing Then
                MessageBox.Show("Vui lòng chọn dữ liệu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            _Khachhang_status = 2
            ShowModalForm()

    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells(_colmakhach_id).Value.ToString
        Dim Code As String = dgvr.Cells(_colMakhach).Value.ToString
        Dim CodeName As String = dgvr.Cells(_colkhachhang).Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Khách: " & Code _
                        & vbCrLf & vbCrLf & " - Khách Hàng: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("makh_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("VpsXmlList_khachhang_UpSet", sbXMLString.ToString, "delete")
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
    Private Sub ShowModalForm_Nhom()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_Nhom))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With List_KhachHang_Nhom
                .Size = New Size(Me.Width * 0.8, .Height)
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
    Private Sub ButtonItem_NhomKhach_Click(sender As Object, e As EventArgs) Handles ButtonItem_NhomKhach.Click
        ShowModalForm_Nhom()
    End Sub

End Class