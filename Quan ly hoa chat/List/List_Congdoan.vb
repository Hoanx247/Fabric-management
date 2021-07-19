Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text

Public Class List_Congdoan
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private dt_local As DataTable
    '--
    Dim dr2 As DataRow()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"frmnamefull", "formgroup", "stt", "nhomcongdoan"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Dim _Column_Forzen_pos As Integer = 0
    Dim _saveRowIndex As Integer = 0
    Private _update_ok As Boolean = False
    Private SoDongChon As Integer = 0
    '//
    Private dt_nhommay As DataTable
    Private dt_khuvuc As DataTable
    Private Lnhommay_id As String = String.Empty
    Private Lmamay_id As String = String.Empty
    Private Lkhuvuc_id As String = String.Empty
    Private _isSame As Int16 = 0
    Private _IsCheck_PH As Int16 = 0
    Private _Lst_ID As String = String.Empty
#Region "Move Panel"
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point

    Private Sub GP_Form_ThemMoi_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_ThemMoi.MouseDown
        Me.SuspendLayout()
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
        Me.ResumeLayout()
    End Sub
    Private Sub GP_Form_ThemMoi_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_ThemMoi.MouseMove
        Me.SuspendLayout()
        If allowCoolMove = True Then
            With GP_Form_ThemMoi
                .SuspendLayout()
                .Location = New Point(.Location.X + e.X - myCoolPoint.X, .Location.Y + e.Y - myCoolPoint.Y)
                .ResumeLayout()
            End With
        End If
        Me.ResumeLayout()
    End Sub
    Private Sub GP_Form_ThemMoi_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_ThemMoi.MouseUp
        Me.SuspendLayout()
        allowCoolMove = False
        Me.Cursor = Cursors.Default
        Me.ResumeLayout()
    End Sub

#End Region


#Region " Load du liệu lên bảng khi mở Form"
    Private Sub Me_FormClosing(ByVal sender As Object, _
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        dt_nhommay = New DataTable
        dt_khuvuc = New DataTable

        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)

        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '--
        AddHandler btnAdd.Click, AddressOf ThemMoi

        AddHandler btnCopy.Click, AddressOf SaoChep

        AddHandler btnModify.Click, AddressOf ChinhSua
        AddHandler btnDelete.Click, AddressOf Xoa

        '//
        Call Load_NhomMay()
        '/
        Load_KhuVuc()

    End Sub
    Private Sub Load_NhomMay()
        dt_nhommay = VpsXmlList_Load("", "", "danhsachmay")
        LoadDataToCombox(dt_nhommay, cboMay, "tenmay", False)
        cboMay.SelectedIndex = -1
    End Sub

    Private Sub Load_KhuVuc()
        dt_khuvuc = VpsXmlList_Load("", "", "khuvuc")
        LoadDataToCombox(dt_khuvuc, cbokhuvuc, "tenkhuvuc", False)

        cbokhuvuc.SelectedIndex = -1
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If _btView = True Then
            btnAdd.Enabled = CBool(IIf(_btAdd = True, True, False))
            btnModify.Enabled = CBool(IIf(_btModify = True, True, False))
            btnDelete.Enabled = CBool(IIf(_btDelete = True, True, False))

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
        If dgvr IsNot Nothing Then
            If _Congdoan_Status = 2 Then
                With dgvr
                    _Lst_ID = .Cells(_colMaCongdoan_ID).Value
                    txtmaID.Text = _Lst_ID
                    txtmaCongdoan.Text = .Cells(_colMacongdoan).Value
                    txtCongdoan.Text = .Cells(_coltencongdoan).Value
                    txtthoigian.Text = .Cells(_colthoigian).Value
                    txtghichu.Text = .Cells(_colghichu).Value
                    txtClr_selected.BackColor = Color.FromArgb(CInt(dgvr.Cells("chon_mau").Value))
                End With
            End If

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
        With CircularProgress1
            .Location = New Point(CInt((Super_Dgv.Width - .Width) / 2), CInt((Super_Dgv.Height - .Height) / 2))
            .IsRunning = True
            .Visible = True
        End With
    End Sub

    Private Sub CircleProcess_Stop()
        wait(200)
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub

    Private Sub Filterdata_chung()
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
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlList_CongDoan_UpSet]", sbXMLString.ToString, "select")
        Super_Dgv.SuspendLayout()
        Super_Dgv.BeginUpdate()
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Super_Dgv.EndUpdate()
        Super_Dgv.ResumeLayout()
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
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
        _isSame = 0
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
                        Dim PreRow As GridRow = CType(row.PrevVisibleRow, GridRow)
                        Dim nextrow As GridRow = CType(row.NextVisibleRow, GridRow)
                        '//Quét

                        '/---
                        If ExistsColumnGridPanel(panel, "chon_mau") = True Then
                            If CBool(row.Cells("chon_mau").Value) = True Then
                                row.Cells("chon_mau").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
                                'row.RowStyles.Default.RowHeaderStyle.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("stt")}
        If panel.SortColumns.Count = 1 Then
            panel.SetSort(sortCols, clsDev.GetSortDir_Asc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDir_Asc(sortCols))
        End If
        '//
        tpress.Enabled = True
    End Sub


#End Region

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmaCongdoan_F.KeyDown, _
        txtCongdoan_F.KeyDown, txtghichu_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_chung()
        End If
    End Sub

#Region "EXECUTE -DELETE"
    Private Sub ShowModalForm()
        With GP_Form_ThemMoi
            If _Congdoan_Status = 1 Then
                .Text = "THÊM MỚI"
                Call Tao_MaID()
                txtmaID.Text = _Lst_ID
            Else
                .Text = "CẬP NHẬT"
            End If
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
            .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
            .BringToFront()
            .Visible = True
        End With

    End Sub

    Private Sub ThemMoi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _Congdoan_Status = 1
        ShowModalForm()
    End Sub

    Private Sub SaoChep(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _Congdoan_Status = 3
        ShowModalForm()
    End Sub

    Private Sub ChinhSua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If dgvr Is Nothing Then
            MessageBox.Show("Xin vui lòng chọn chứng từ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            _Congdoan_Status = 2
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
        Dim EmpID As String = dgvr.Cells("congdoan_id").Value.ToString
        Dim Code As String = dgvr.Cells(_colMacongdoan).Value.ToString
        Dim CodeName As String = dgvr.Cells(_coltencongdoan).Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã CĐ: " & Code _
                        & vbCrLf & vbCrLf & " - Công Đoạn: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("congdoan_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_CongDoan_UpSet]", sbXMLString.ToString, "delete")
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

#End Region

    Private Sub BtnLuuThayDoi_Click(sender As Object, e As EventArgs) Handles BtnLuuThayDoi.Click
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_update_congdoan(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("[VpsXmlList_CongDoan_UpSet]", sbXMLString.ToString, "update_luuthaydoi")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_chung()
        End If

    End Sub
    Private Sub UpdateDetails_update_congdoan(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_congdoan(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("congdoan_id='" + ReplaceTextXML(row.Cells("congdoan_id").Value.ToString) + "' ")
                    sbXMLString.Append("macongdoan='" + ReplaceTextXML(row.Cells("macongdoan").Value.ToString) + "' ")
                    sbXMLString.Append("tencongdoan='" + ReplaceTextXML(row.Cells("tencongdoan").Value.ToString.ToUpper) + "' ")
                    sbXMLString.Append("nhomcongdoan='" + ReplaceTextXML(row.Cells("nhomcongdoan").Value.ToString.ToUpper) + "' ")
                    sbXMLString.Append("dongia='" + CNumber_system(row.Cells("dongia").Value) + "' ")
                    sbXMLString.Append("thoigian='" + CNumber_system(row.Cells("thoigian").Value) + "' ")
                    sbXMLString.Append("sothietbi='" + CNumber_system(row.Cells("sothietbi").Value) + "' ")
                    sbXMLString.Append("tennhom='" + ReplaceTextXML(row.Cells("tennhom").Value.ToString) + "' ")
                    sbXMLString.Append("ghichu='" + ReplaceTextXML(row.Cells("ghichu").Value.ToString) + "' ")
                    sbXMLString.Append("stt='" + CNumber_system(row.Cells("stt").Value) + "' ")
                    sbXMLString.Append("thutu_theodoi='" + CNumber_system(row.Cells("thutu_theodoi").Value) + "' ")
                    sbXMLString.Append("nguoitao='" + ReplaceTextXML(strUser) + "' ")
                    sbXMLString.Append(" />")


                End If
            End If
        Next

    End Sub

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
            If MsgBox("Bạn có Muốn In (Yes: In / No: Thoát) ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Xuất Excel") = MsgBoxResult.Yes Then
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
            .strfileExcel_1 = "List_congdoan.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "barcode", _colMacongdoan, _coltencongdoan, "dongia", "thoigian", "ghichu", "ngaytao", "nguoitao", "chon_mau"}
            ._rangeExcel_Text = {"j"}
            ._rangeExcel_number_0 = {}
            ._rangeExcel_number_1 = {}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "j"}
            ._GridArea = {"A", "j"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {}
        End With
        '//
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _GdtNgayIn_1 = Format$(Now, "dd/MM/yyyy HH:mm:ss")
        '_GdtNgayIn_2 = Format$(dt2_F.Value, "dd/MM/yyyy")
        '//
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub
#End Region

#Region "AP THIET BI"

    Private Sub BtnExit_Form_MayMoc_Click(sender As Object, e As EventArgs) Handles BtnExit_Form_MayMoc.Click
        GP_Form_May.Visible = False
    End Sub

    Private Sub BtnChonMayChoCongDoan_Click(sender As Object, e As EventArgs) Handles BtnChonMayChoCongDoan.Click
        Try
            Dim btn As ButtonItem = CType(sender, ButtonItem)
            With GP_Form_May
                .Text = "ÁP NHÓM THIẾT BỊ"
                '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Update_Form_MayMoc_Click(sender As Object, e As EventArgs) Handles Btn_Update_Form_MayMoc.Click
        dr2 = dt_nhommay.Select("tenmay = '" & cboMay.Text & "'", "")
        If dr2.Length > 0 Then
            Lmamay_id = dr2.First.Item("mamay_id")
            Lnhommay_id = dr2.First.Item("nhommay_id")
        Else
            MsgBox("Vui lòng chọn máy.", MsgBoxStyle.Information, "Thông Báo")
            Exit Sub
        End If
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện cập nhật Máy?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If

        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_update_MayMoc(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("[VpsXmlList_CongDoan_UpSet]", sbXMLString.ToString, "update_mamay")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_chung()
    End Sub

    Private Sub UpdateDetails_update_MayMoc(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_MayMoc(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("congdoan_id='" + ReplaceTextXML(row.Cells("congdoan_id").Value.ToString) + "' ")
                    sbXMLString.Append("mamay_id='" + ReplaceTextXML(Lmamay_id) + "' ")
                    sbXMLString.Append("nhommay_id='" + ReplaceTextXML(Lnhommay_id) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub
#End Region

#Region "AP KHU VỰC"

    Private Sub BtnExit_Form_KhuVuc_Click(sender As Object, e As EventArgs) Handles BtnExit_Form_KhuVuc.Click
        GP_Form_KhuVuc.Visible = False
    End Sub

    Private Sub BtnChonKhuVuc_May_Click(sender As Object, e As EventArgs) Handles BtnChonKhuVuc_May.Click
        Try
            Dim btn As ButtonItem = CType(sender, ButtonItem)
            With GP_Form_KhuVuc
                .Text = "ÁP KHU VỰC"
                '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True
                '//
                Call Load_KhuVuc()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Update_Form_KhuVuc_Click(sender As Object, e As EventArgs) Handles Btn_Update_Form_KhuVuc.Click
        dr2 = dt_khuvuc.Select("tenkhuvuc = '" & cbokhuvuc.Text & "'", "")
        If dr2.Length > 0 Then
            Lkhuvuc_id = dr2.First.Item("khuvuc_id")
        Else
            MsgBox("Vui lòng chọn Khu Vực.", MsgBoxStyle.Information, "Thông Báo")
            Exit Sub
        End If
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện cập nhật Khu Vực?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If

        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_update_KhuVuc(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("[VpsXmlList_CongDoan_UpSet]", sbXMLString.ToString, "update_khuvuc")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_chung()
    End Sub

    Private Sub UpdateDetails_update_KhuVuc(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_KhuVuc(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("congdoan_id='" + ReplaceTextXML(row.Cells("congdoan_id").Value.ToString) + "' ")
                    sbXMLString.Append("khuvuc_id='" + ReplaceTextXML(Lkhuvuc_id) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub
#End Region


#Region "AUTO CHANGE COLOR"
    Private _ColorCycle As Integer = 0
    ''' <summary>
    ''' Sets new colors for the given color table
    ''' </summary>
    ''' <param name="colors">Color Table</param>
    Private Sub SetNewScheme(ByVal colors As Color())
        ' Loop through each color in the table

        For i As Integer = 0 To colors.Length - 1
            colors(i) = GetNewColor(colors(i))
        Next
    End Sub

    ''' <summary>
    ''' Gets a new RGB cycle color
    ''' </summary>
    ''' <param name="color1">Current color</param>
    ''' <returns>New cycled color</returns>
    Private Function GetNewColor(ByVal color1 As Color) As Color
        If (_ColorCycle And 1) = 0 Then
            Return (Color.FromArgb(color1.R, color1.B, color1.G))
        End If

        Return (Color.FromArgb(color1.G, color1.R, color1.B))
    End Function



#End Region

#Region "XAC NHAN DO PH"
    Private Sub BtnConfirm_DoPH_Click(sender As Object, e As EventArgs) Handles BtnConfirm_DoPH.Click
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện cập nhật Khu Vực?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        _IsCheck_PH = 1
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_update_DoPH(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("[VpsXmlCongDoanUpSet]", sbXMLString.ToString, "update_doph")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_chung()
    End Sub
    Private Sub UpdateDetails_update_DoPH(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_DoPH(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("congdoan_id='" + ReplaceTextXML(row.Cells("congdoan_id").Value.ToString) + "' ")
                    sbXMLString.Append("ischeck_ph='" + CNumber_system(_IsCheck_PH) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub




#End Region

#Region "TAO MA ID"
    Private Sub Clear_Text()
        txtmaCongdoan.Text = String.Empty
        txtCongdoan.Text = String.Empty
        txtthoigian.Text = String.Empty
        txtghichu.Text = String.Empty
    End Sub
    Private Sub Tao_MaID()
        '//Ma Don Hang
        Dim _LID As String = String.Empty
        Dim _stt As String = String.Empty
        For y = 1 To 999
            _stt = "00" & y
            _LID = "CD" & gRight(_stt, 3)
            If SearchUsingForLoop(_LID, "congdoan_id") = False Then
                GoTo SWERLExit
                Exit Sub
            End If
        Next
SWERLExit:
        _Lst_ID = _LID
    End Sub
    Private Function SearchUsingForLoop(ByVal _Tmaso As String, ByVal _Colname As String) As Boolean
        Dim result As Boolean = False
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing Then
                If row.Cells(_Colname).FormattedValue.ToUpper = _Tmaso.ToUpper Then
                    result = True
                End If
            End If
        Next
        Return result
    End Function
#End Region

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



#End Region

#Region "EXECUTE"
    Private Sub ButtonX_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX_Save.Click
        If _Congdoan_Status = 1 Then
            Call Tao_MaID()
            '//
            txtmaID.Text = _Lst_ID
            '//
            Call Update_Data("", "insert")
            If _update_ok = True Then
                Clear_Text()
                '//
                Call Tao_MaID()
                '//
                _update_ok = False
                txtmaCongdoan.Focus()
            End If
        ElseIf _Congdoan_Status = 2 Then
            If MsgBox("Bạn có muốn sửa nội dung không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update")
            End If
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
            _dt = New ListMenuDTO("[VpsXmlList_CongDoan_UpSet]", sbXMLString.ToString, command)
            _update_ok = dtControler.UPSET_XML(_dt)
            If _update_ok = True Then
                Call Filterdata_chung()
                '//
            End If

        End If
    End Sub

    Private Sub ButtonX_Exit_Click(sender As Object, e As EventArgs) Handles ButtonX_Exit.Click
        GP_Form_ThemMoi.Visible = False
    End Sub

#End Region
End Class