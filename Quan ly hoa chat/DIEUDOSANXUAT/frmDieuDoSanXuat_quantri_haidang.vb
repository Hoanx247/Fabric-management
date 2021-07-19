

Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text

Public Class frmDieuDoSanXuat_quantri_haidang
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim dt_congdoan As DataTable
    Dim dt_kieuxuat As DataTable

    Dim _Load_Ok As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Dim _bln_mamau As Boolean = False, _bln_donhang As Boolean = False
    Private _bln_macongnghe As Boolean = False
    Private _bln_mamau_1 As Boolean = False
    '--
    Dim ProgramPosition, cursorPoint As Point

    Dim _List_MameID As String() = {}
    Dim strList As List(Of String) = _List_MameID.ToList()
    '--
    Dim _List_CongDoanID As String() = {}
    Dim strCongDoanID As List(Of String) = _List_CongDoanID.ToList()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"mame_01", "mame_02", "mame_03", "mame_04", "khovai", "metkg", "ghichu"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    '--
    Dim _kieuxuat_id As String, _stMakytu_xuat As String
    Dim dr2 As DataRow()
    Dim _chungtuxuat_id As String
    Dim _load_finish As Boolean = False

    Private _congdoan_id As String = String.Empty
    Private Lmame As String = String.Empty
    Private Lmamau_id As String = String.Empty
    Private Lmame_id As String = String.Empty
    Private _Update_MaCongDoan_In As Boolean = False
    '//
    Private DgvData As DataGridView = New DataGridView()
    Private result As New List(Of String())
    '--
    Private _IsBusy As Boolean = False

    Private SoDongChon As Integer = 0
    '//
    Dim _List_Mame As String() = {}
    Dim strMame As List(Of String) = _List_Mame.ToList()
    '//
    Private _Update_OK As Boolean = False
    Private _nhomloi_id As String = String.Empty
    Private LDonHang As String = String.Empty
    Private LMaMe_01 As String = String.Empty
    Private _donhang_id As String = String.Empty
    Private Lmahang_id As String = String.Empty
    Private Lc_id As String = String.Empty
#Region "Move Panel"
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point


#Region "MOVE PANEL MAMAU"
    Private Sub GP_Form_CapNhat_MaMau_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_CapNhat_MaMau.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub
    Private Sub GP_Form_CapNhat_MaMau_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_CapNhat_MaMau.MouseMove
        If allowCoolMove = True Then
            Me.SuspendLayout()
            With GP_Form_CapNhat_MaMau
                .Location = New Point(.Location.X + e.X - myCoolPoint.X, .Location.Y + e.Y - myCoolPoint.Y)
            End With
            Me.ResumeLayout()
        End If
    End Sub
    Private Sub GP_Form_CapNhat_MaMau_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_CapNhat_MaMau.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub
#End Region


#End Region

#Region " Load du liệu lên bảng khi mở Form"


#Region "Private data"

    Private _BackColor As Background() = {New Background(Color.LightGreen),
        New Background(Color.FromArgb(&HE5, &HFF, &HDD)), New Background(Color.AliceBlue)}
    Private _MyFont As New Font("Time New Roman", 10, FontStyle.Bold Or FontStyle.Italic)

#End Region

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_congdoan.Dispose()
        dt_local.Dispose()
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()
        '--
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        Call clsDev.Format_Super_Dgv(Super_Dgv_DonHang_MaMau, _MyFont_GridView - 1)
        '//
        dt_local = New DataTable
        dt_congdoan = New DataTable

        '--
        With dt1_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        With dt2_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        '//
        '--
        Me.dt1_F.Value = CDate(FormatDateTime(DateSerial(Now.Year, Now.Month, Now.Day - 10), DateFormat.ShortDate))
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))

        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        '//
        AddHandler Super_Dgv_DonHang_MaMau.CellClick, AddressOf Super_Dgv_DonHang_MaMau_CellClick
        'AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        '--

        'AddHandler btnAdd.Click, AddressOf ThemMoi
        'AddHandler CtxFunction_Add.Click, AddressOf ThemMoi
        'AddHandler btnCopy.Click, AddressOf SaoChep
        'AddHandler CtxFunction_Copy.Click, AddressOf SaoChep
        'AddHandler btnModify.Click, AddressOf ChinhSua
        'AddHandler CtxFunction_Modify.Click, AddressOf ChinhSua
        'AddHandler btnDelete.Click, AddressOf Xoa
        'AddHandler CtxFunction_delete.Click, AddressOf Xoa
        'AddHandler CtxFunction_Refresh.Click, AddressOf Filterdata_Stored
        'AddHandler CtxMenu_Expand.Click, AddressOf Expand_SuperGrid
        'AddHandler CtxMenu_Colapse.Click, AddressOf Collapse_SuperGrid
        '--
        'AddHandler btnChuyen_MaCD.Click, AddressOf btnChuyen_MaCN_Click
        'AddHandler btnChuyen_Mamau.Click, AddressOf btnChuyen_Mamau_Click

    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If True = True Then

            Call Filterdata_Stored()
            _load_finish = True
            '----------------
        Else
            Me.Close()
        End If

    End Sub


    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        'clsDev.SuperDgv_CellValueChanged(sender, e)
    End Sub
    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Super_Dgv.KeyDown
        clsDev.Super_Dgv_KeyDown(sender, e)
    End Sub
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = CByte(e.GridColumn.ColumnIndex)
            If e.GridColumn.ColumnIndex = 0 Then
                ShowContextMenu(CtxMnuSelect)
            Else
                ShowContextMenu(CtxMenu)
            End If

        End If
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        Else
            If e.GridCell.ColumnIndex = 0 Then
                panel.ReadOnly = False
                panel.AllowEdit = True
                If dgvr.Checked = False Then
                    dgvr.Checked = True
                    dgvr.Cells(0).CellStyles.Default.Background.Color1 = Color.GreenYellow
                Else
                    dgvr.Checked = False
                    dgvr.Cells(0).CellStyles.Default.Background.Color1 = Color.Empty
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

        End If
        _saveRowIndex = e.GridCell.RowIndex

    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub

    Private Sub mnu_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Select_All.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, True)
    End Sub

    Private Sub mnu_Remove_ALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Remove_ALL.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, False)
    End Sub

    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_ColumnFrozen.Click

    End Sub

#End Region

#Region "LOAD DON HANG VA MA HANG"
    Private Sub Filterdata_Stored_DonHang_MaHang()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        'Try
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(txtdonhang_Check.Text) + "' ")
        'sbXMLString.Append("mahang_id='" + ReplaceTextXML(Lmahang_id) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlDonHang_Check_2021]", sbXMLString.ToString, "select")

        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '///
        Dim _condition As String = String.Empty
        Dim dataSource As Object = Nothing
        Dim rows() As DataRow = dt_local.Select("")
        If rows.Count > 0 Then ' first check to see if the array has rows '
            dataSource = rows.CopyToDataTable() ' dt now exists and contains rows '
        Else
            dataSource = Nothing
        End If
        '//
        Dim panel As GridPanel = Super_Dgv_DonHang_MaMau.PrimaryGrid
        panel.DataSource = dataSource

        IsBusy = False
        Me.ResumeLayout()
    End Sub

#End Region
#Region "LOAD DATA"


    Private Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        'Try

        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("dtngay1='" + Format$(dt1_F.Value, "yyyyMMdd 00:00") + "' ")
        sbXMLString.Append("dtngay2='" + Format$(dt2_F.Value, "yyyyMMdd 23:59") + "' ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(txtdonhang_F.Text) + "' ")
        sbXMLString.Append("khachhang='" + ReplaceTextXML(txtkhachhang_F.Text) + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang_F.Text) + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML(txtloaihang_F.Text) + "' ")
        sbXMLString.Append("mamau='" + ReplaceTextXML(txtmamau_F.Text) + "' ")
        sbXMLString.Append("tenmau='" + ReplaceTextXML(txtmau_F.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append("mame_ghep='" + ReplaceTextXML(txtmame_ghep_F.Text) + "' ")
        sbXMLString.Append("khovai='" + ReplaceTextXML(txtkhovai_F.Text) + "' ")
        sbXMLString.Append("metkg='" + ReplaceTextXML(txtmetkg_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_GetData_2021_haidang]", sbXMLString.ToString, "select")

        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '///
        Dim _condition As String = String.Empty
        Dim dataSource As Object = Nothing
        Dim rows() As DataRow = dt_local.Select("")
        If rows.Count > 0 Then ' first check to see if the array has rows '
            dataSource = rows.CopyToDataTable() ' dt now exists and contains rows '
        Else
            dataSource = Nothing
        End If
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        panel.DataSource = dataSource

        IsBusy = False
        Me.ResumeLayout()
    End Sub
    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        'dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        'panel.AddGroup(panel.Columns("mucdich"))
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '--
        _stName = "Theo_DauKy"
        _stHeadText = "Yêu Cầu"
        _stCol1 = "socay"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '//
        '--
        _stName = "Theo_PhanMe"
        _stHeadText = "Phân Mẻ"
        _stCol1 = "socay_phanme"
        _stCol2 = "somet_phanme"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_dinhhinh_sobo"
        _stHeadText = "Sơ Bộ"
        _stCol1 = "socay_sobo"
        _stCol2 = "somet_sobo"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_dinhhinh_tp"
        _stHeadText = "Đ.Hình TP"
        _stCol1 = "socay_dinhhinh"
        _stCol2 = "somet_dinhhinh"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_kcs"
        _stHeadText = "Kiểm Phẩm"
        _stCol1 = "socay_kcs"
        _stCol2 = "somet_kcs"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_XuatHang"
        _stHeadText = "Xuất Hàng"
        _stCol1 = "socay_xuathang"
        _stCol2 = "somet_xuathang"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_NhapTk"
        _stHeadText = "Mã CN"
        _stCol1 = "macongnghe"
        _stCol2 = "macongnghe_tt"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("dtngaytao"), panel.Columns("mame_ghep"), panel.Columns("mame")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        End If

    End Sub
    Public Function GetSortDirAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Descending, SortDirection)})
    End Function

#End Region

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkhovai_F.KeyDown, txtkhachhang_F.KeyDown,
        txtmahang_F.KeyDown, txtmetkg_F.KeyDown, txtloaihang_F.KeyDown, txtmamau_F.KeyDown, txtghichu_F.KeyDown, txtdonhang_F.KeyDown, txtmame_F.KeyDown, txtmau_F.KeyDown, txtghichumoc_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub btTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub


#Region "INPUT TEXTBOX"
    Private Sub TextBoxNumeric_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txtbox As TextBox = CType(sender, TextBox)
        Call OnlyNumericKeysLevave(txtbox)

    End Sub


    Private Sub TextBoxNumeric_KeyDown(sender As Object, e As KeyEventArgs)
        '//
        Dim _List_Except As String() = {}
        '//
        If e.KeyCode = Keys.Enter Then
            Dim txtbox As TextBox = CType(sender, TextBox)
            Dim result As String = Array.Find(_List_Except, Function(s) s = txtbox.Name)
            If result IsNot Nothing Then
                OnlyNumericKeysLevave(txtbox)
            End If
            '//
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
            '//
        End If
    End Sub

    Private Sub TextBoxNumeric_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call OnlyNumericKeysKeyPress(sender, e)
    End Sub


    Private Sub cboDonvi_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            '//
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
            '//
        End If
    End Sub
#End Region

    Private Sub chkTatCa_CheckedChanged(sender As Object, e As EventArgs) Handles chkTatCa.CheckedChanged
        If chkTatCa.Checked = False Then
            dt1_F.Enabled = True
            dt2_F.Enabled = True
        Else
            dt1_F.Enabled = False
            dt2_F.Enabled = False
        End If
    End Sub

#Region "CAP NHAT DON HANG"

    Private Sub btnCapNhat_DonHang_Click(sender As Object, e As EventArgs) Handles btnCapNhat_MaMau.Click
        If Len(_donhang_id) = 0 Then Exit Sub
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện thay đổi ĐƠN HÀNG?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_update_donhang(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_haidang")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub

    Private Sub UpdateDetails_update_donhang(ByVal rows As IEnumerable(Of GridElement))
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_donhang(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame").Value.ToString.Trim) + "' ")
                    sbXMLString.Append("c_id_donhang='" + ReplaceTextXML(Lc_id) + "' ")
                    sbXMLString.Append("donhang_id='" + ReplaceTextXML(_donhang_id) + "' ")
                    sbXMLString.Append("mahang_id='" + ReplaceTextXML(Lmahang_id) + "' ")
                    sbXMLString.Append("mamau_khach='" + ReplaceTextXML(txtmamau.Text) + "' ")
                    sbXMLString.Append("tenmau_khach='" + ReplaceTextXML(txttenmau.Text) + "' ")
                    sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
                    '//
                    Dim _mota_chuyenmau As String = "CHUYỂN ĐƠN HÀNG"
                    sbXMLString.Append("mota_chuyenmau='" + ReplaceTextXML(_mota_chuyenmau) + "' ")
                    sbXMLString.Append("tenform='" + ReplaceTextXML(Me.Name.ToString) + "' ")
                    sbXMLString.Append("tencot='" + ReplaceTextXML(row.Cells("mamau_khach").Value.ToString.Trim) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next
    End Sub

#End Region

    Private Sub ToolStripButton_Mamau_Click(sender As Object, e As EventArgs) Handles ToolStripButton_Mamau.Click
        Try
            Dim btn As ToolStripButton = CType(sender, ToolStripButton)
            With GP_Form_CapNhat_MaMau
                .Text = "CẬP NHẬT"
                '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton_XacNhanMeMau_Click(sender As Object, e As EventArgs) Handles ToolStripButton_XacNhanMeMau.Click

    End Sub

    Private Sub BtnThoat_Panel_mamau_Click(sender As Object, e As EventArgs) Handles BtnThoat_Panel_mamau.Click
        GP_Form_CapNhat_MaMau.Visible = False
    End Sub

    Private Sub Super_Dgv_DonHang_MaMau_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv_DonHang_MaMau.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        Else
            '//
            If dgvr IsNot Nothing Then
                Lc_id = dgvr.Cells("c_id").FormattedValue.ToString
                _donhang_id = dgvr.Cells("donhang_id").FormattedValue.ToString
                Lmahang_id = dgvr.Cells("mahang_id").FormattedValue.ToString
                txtdonhang_Check.Text = dgvr.Cells("donhang").FormattedValue.ToString
                txtmahang_check.Text = dgvr.Cells("mahang").FormattedValue.ToString
                txtmamau.Text = dgvr.Cells("mamau_khach").FormattedValue.ToString
                txttenmau.Text = dgvr.Cells("tenmau_khach").FormattedValue.ToString

            Else
                Lc_id = String.Empty
                _donhang_id = String.Empty
                Lmahang_id = String.Empty
            End If

        End If
        _saveRowIndex = e.GridCell.RowIndex

    End Sub

    Private Sub txtdonhang_Check_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdonhang_Check.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored_DonHang_MaHang()
        End If
    End Sub

End Class