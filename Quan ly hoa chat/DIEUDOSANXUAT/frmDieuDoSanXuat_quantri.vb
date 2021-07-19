

Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text

Public Class frmDieuDoSanXuat_quantri
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
    Private _bln_mahang As Boolean = False
    Private Lmahang_id As String = String.Empty
    Private Lc_id As String = String.Empty

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

        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        '--
        AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler
        AddHandler Super_Dgv_DonHang_MaMau.CellClick, AddressOf Super_Dgv_DonHang_MaMau_CellClick
        AddHandler Super_Dgv_DonHang_MaMau.DataBindingComplete, AddressOf Super_Dgv_donhang_DataBindingComplete
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
        '//
        Load_CongDoan()
    End Sub
    Private Sub Load_CongDoan()
        dt_congdoan = VpsXmlList_Load("", "", "nhomloi_menhuom")
        LoadDataToCombox(dt_congdoan, cboThuocNhom, "nhomloi", False)
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
        clsDev.SuperDgv_CellValueChanged(sender, e)
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
            '//
            If dgvr IsNot Nothing Then
                '_donhang_id = dgvr.Cells("donhang_id").FormattedValue.ToString
                'txtdonhang.Text = dgvr.Cells("donhang").FormattedValue.ToString
                '//
                Lmame_id = dgvr.Cells("mame_id").FormattedValue.ToString
                Lmame = dgvr.Cells("mame").FormattedValue.ToString
                LMaMe_01 = dgvr.Cells("mame_01").FormattedValue.ToString
                LDonHang = dgvr.Cells("donhang").FormattedValue.ToString
                '//
                Dim stDonHang As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stDonHang &= "<font size=""12""><font color=""Black""> {1} </font></font>"
                Dim stMaHang As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stMaHang &= "<font size=""12""><font color=""Black""> {1} </font></font><br/>"
                Dim stMaMau As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stMaMau &= "<font size=""12""><font color=""Black""> {1} </font></font>"
                Dim stMaMe As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stMaMe &= "<font size=""12""><font color=""Black""> {1} </font></font><br/>"
                '//
                Dim stMaCongNghe As String = "<div>" & "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stMaCongNghe &= "<font size=""12""><font color=""Black""> {1} </font></font>" & "</div>"
                '////
                panel.Caption.Text = String.Format(stDonHang, "+ ĐƠN HÀNG: ", dgvr.Cells("donhang").FormattedValue.ToString.ToUpper & " || ")
                panel.Caption.Text &= String.Format(stMaHang, "+ MÃ HÀNG: ",
                                                    dgvr.Cells("mahang").FormattedValue.ToString.ToUpper & " - " & dgvr.Cells("loaihang").FormattedValue.ToString.ToUpper)
                panel.Caption.Text &= String.Format(stMaMau, "+ MÃ MÀU: ",
                                                    dgvr.Cells("mamau").FormattedValue.ToString.ToUpper & " - " & dgvr.Cells("tenmau").FormattedValue.ToString.ToUpper & " || ")
                panel.Caption.Text &= String.Format(stMaMe, "+ MẺ: ",
                                    dgvr.Cells("mame").FormattedValue.ToString.ToUpper & " - " & dgvr.Cells("mame_ghep").FormattedValue.ToString.ToUpper)
                panel.Caption.Text &= String.Format(stMaMe, "+ MÃ CN: ",
                    dgvr.Cells("macongnghe").FormattedValue.ToString.ToUpper)
            Else
                LMaMe_01 = String.Empty
                LDonHang = String.Empty
                Lmame_id = String.Empty
                Lmame = String.Empty
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


#Region "LOAD DATA"

    Private Sub CircleProcess_Start()
        With CircularProgress1
            .Location = New Point((Super_Dgv.Width / 2) - (.Width / 2), (Super_Dgv.Height / 2) - (.Height / 2))
            .IsRunning = True
            .Visible = True
        End With

    End Sub

    Private Sub CircleProcess_Stop()
        wait(200)
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub

    Private Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        'Try
        Call CircleProcess_Start()
        '//
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
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_GetData_2021_admin]", sbXMLString.ToString, "select")

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
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socaytt", "sokgtt", "somettt"}
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
        Dim st As String = "<div align=""center"">" & "<font color=""Black"">{0}</font><br/>" & "<font color=""Blue"">{1}</font>" & "</div>"
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
        lblRow.Text = "T.Số: " & panel.Rows.Count
    End Sub

    Private Sub UpdateShowALLRows(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        Dim _chon_mau As String = String.Empty
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
                        '---Quet mau cong doan
                        'dr2 = dt_congdoan.Select("macongdoan = '" & row.Cells("chon_mau").Value.ToString & "'", "")
                        'If dr2.Length > 0 Then
                        '_chon_mau = dr2.First.Item("chon_mau").ToString
                        'Else
                        '_chon_mau = "-1"
                        'End If
                        'row.Cells(_colMacongnghe).CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_chon_mau)
                        'row.Cells(_colMacongnghe_tt).CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_chon_mau)

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
        '//
        'columns(_colMakhach).HeaderText = "Mã Lò"
        'columns(_colkhachhang).HeaderText = "Lò Dệt"
        '//
        '--
        '//Ẩn Cột
        For Each item As GridElement In panel.Columns
            Dim column As GridColumn = TryCast(item, GridColumn)
            Dim _TFormat As String = String.Empty
            If column.Name.ToLower.Contains("_id") = True Then
                column.Visible = False
            End If
        Next item
        '//
        'panel.AddGroup(panel.Columns("mucdich"))
        '//
        If _List_ColumnGrouped.Length > 0 Then
            For Each _ColumnGrouped As String In _List_ColumnGrouped
                panel.AddGroup(panel.Columns(_ColumnGrouped))
            Next
        End If

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
        '//

        tpress.Enabled = True
    End Sub
    Public Function GetSortDirAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Descending, SortDirection)})
    End Function

#Region "SuperGridControl1GetGroupDetailRows"
    '//
    Private _List_ColumnGrouped As String() = {}
    Private strList_ColumnGrouped As List(Of String) = _List_ColumnGrouped.ToList()
    Private Sub Super_Dgv_ColumnGrouped(sender As Object, e As GridColumnGroupedEventArgs) Handles Super_Dgv.ColumnGrouped
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns

        If panel.GroupColumns IsNot Nothing Then

            If panel.GroupColumns.Count = 1 Then
                _List_ColumnGrouped = {}
                Dim result As String = Array.Find(_List_ColumnGrouped, Function(s) s = panel.GroupColumns(0).Name)
                If result Is Nothing Then
                    _List_ColumnGrouped = _List_ColumnGrouped.Concat({panel.GroupColumns(0).Name}).ToArray
                End If
            ElseIf panel.GroupColumns.Count = 2 Then
                _List_ColumnGrouped = {}
                Dim result As String = Array.Find(_List_ColumnGrouped, Function(s) s = panel.GroupColumns(0).Name)
                If result Is Nothing Then
                    _List_ColumnGrouped = _List_ColumnGrouped.Concat({panel.GroupColumns(0).Name}).ToArray
                End If
                '//
                result = Array.Find(_List_ColumnGrouped, Function(s) s = panel.GroupColumns(1).Name)
                If result Is Nothing Then
                    _List_ColumnGrouped = _List_ColumnGrouped.Concat({panel.GroupColumns(1).Name}).ToArray
                End If
            Else
                _List_ColumnGrouped = {}
            End If
        Else
            _List_ColumnGrouped = {}
        End If
    End Sub
    Private Sub Super_Dgv_GroupHeaderClick(sender As Object, e As GridGroupHeaderClickEventArgs) Handles Super_Dgv.GroupHeaderClick
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        _List_group = {}
        Super_Dgv_GroupHeader_Group(panel.Rows)

    End Sub

    Private Sub Super_Dgv_GroupHeader_Group(ByVal rows As IEnumerable(Of GridElement))
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                '////
                Dim _GroupValue_Parent_name As String = String.Empty
                Dim _GroupValue_Parent As GridGroup = TryCast(group.Parent, GridGroup)
                If _GroupValue_Parent IsNot Nothing Then
                    _GroupValue_Parent_name = _GroupValue_Parent.GroupValue.ToString
                Else
                    _GroupValue_Parent_name = String.Empty
                End If
                Dim _GroupValue As String = _GroupValue_Parent_name & "-" & group.GroupValue.ToString
                If group.Expanded = True Then
                    _List_group = _List_group.Concat({_GroupValue}).ToArray
                End If
                '//
                Super_Dgv_GroupHeader_Group(group.Rows)
            End If
        Next
    End Sub

    <Obsolete>
    Private Sub SuperGridControl1GetGroupDetailRows(ByVal sender As Object, ByVal e As GridGetGroupDetailRowsEventArgs)
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns

        If panel.GroupColumns IsNot Nothing Then
            If e.GridGroup.Rows.Count > 0 Then
                Dim index As Integer = e.GridGroup.Column.ColumnIndex
                Dim detailRows As New List(Of GridRow)()
                Dim row As GridRow = clsDev.GetNewDetailRow(panel)
                Dim _Index As Integer = 0

                '---Tinh tong so cay
                row.Cells(index).EditorType = GetType(GridTextBoxXEditControl)
                row.Cells(index).Value = Convert.ToString(e.GridGroup.GroupValue)
                '//
                Dim _GroupValue_Parent_name As String = String.Empty
                Dim _GroupValue_Parent As GridGroup = TryCast(e.GridGroup.Parent, GridGroup)
                If _GroupValue_Parent IsNot Nothing Then
                    _GroupValue_Parent_name = _GroupValue_Parent.GroupValue.ToString
                Else
                    _GroupValue_Parent_name = String.Empty
                End If
                Dim _GroupValue As String = _GroupValue_Parent_name & "-" & e.GridGroup.GroupValue.ToString
                Dim result As String = Array.Find(_List_group, Function(s) s = _GroupValue)
                If result IsNot Nothing Then
                    e.GridGroup.Expanded = True
                Else
                    e.GridGroup.Expanded = False
                End If
                '///
                '---
                '///Initial Array
                ReDim Preserve _Gnumber_group(_array_column.Length)
                Array.Clear(_Gnumber_group, 0, _Gnumber_group.Length)
                '//
                clsDev.Total_Group(columns, e.GridGroup, False, _array_column)
                For x As Integer = 0 To _array_column.Length - 1
                    Dim st As Integer = clsDev.GetDisplayIndex(columns, _array_column(x))
                    Dim _svalue As Decimal = _Gnumber_group(x)
                    row.Cells(st).Value = _Gnumber_group(x)
                Next
                '///
                If e.GridGroup.Column.Name.ToString.ToUpper = _colmucdich.ToString.ToUpper Then
                    e.GridGroup.Text = "MỤC ĐÍCH: " & e.GridGroup.GroupValue.ToString.ToUpper
                    'e.GridGroup.GroupHeaderVisualStyles.Default.Background.Color1 = Color.LawnGreen
                    e.GridGroup.GroupHeaderVisualStyles.Default.TextColor = Color.Blue

                End If

                row.CellStyles.[Default].Font = _MyFont_group
                '--
                'For i As Integer = 0 To panel.Columns.Count - 1
                'row.Cells(i).CellStyles.[Default].Background = _BackColor(0)
                'Next
                ' Just for grins, let's add some color to make the
                ' totals association more readily obvious to the user
                detailRows.Add(row)
                e.DetailRows = detailRows
            End If
        End If
    End Sub

#End Region

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


#Region "LUU THAY DOI"
    Private Sub btnLuuThayDoi_DonHang_Click(sender As Object, e As EventArgs)
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
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_DatMau_UpSet]", sbXMLString.ToString, "update_luuthaydoi")
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
                    If Len(row.Cells("mame").Value.ToString) > 3 Then
                        sbXMLString.Append("<DATA ")
                        sbXMLString.Append("mame='" + ReplaceTextXML(row.Cells("mame").Value.ToString) + "' ")
                        sbXMLString.Append("mamau_id='" + ReplaceTextXML(Lmamau_id) + "' ")
                        sbXMLString.Append("donhang='" + ReplaceTextXML(row.Cells("donhang").Value.ToString) + "' ")
                        sbXMLString.Append("khovai='" + ReplaceTextXML(row.Cells("khovai").Value.ToString) + "' ")
                        sbXMLString.Append("metkg='" + ReplaceTextXML(row.Cells("metkg").Value.ToString) + "' ")
                        sbXMLString.Append("tenmau_nhuom='" + ReplaceTextXML(row.Cells("tenmau_nhuom").Value.ToString) + "' ")
                        sbXMLString.Append("mamau_khachhang='" + ReplaceTextXML(row.Cells("mamau_khachhang").Value.ToString) + "' ")
                        sbXMLString.Append("ghichu_thuchien_1='" + ReplaceTextXML(row.Cells("ghichu_thuchien_1").Value.ToString) + "' ")
                        sbXMLString.Append("nhanvien_apmau='" + ReplaceTextXML(_stUser_Save) + "' ")
                        sbXMLString.Append(" />")
                    End If

                End If
            End If
        Next

    End Sub

#End Region

#Region "IN DON HANG SX"
    Private Sub btnExcel_DonHang_GiaCong_Click(sender As Object, e As EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If Super_Dgv.PrimaryGrid.Rows.Count = 0 Then
            Exit Sub
        End If
        '--
        Dim btn As ToolStripButton = CType(sender, ToolStripButton)
        With btn
            .Text = "Xin Chờ..."
            .Enabled = False
            'If MsgBox("Bạn có Muốn In (Yes: In / No: Thoát) ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "In PDF") = MsgBoxResult.Yes Then
            _IsPrint = False
            _IsPrint_PrintArea = False
            _IsPrint_Sum = False
            _IsPrint_GridArea = False
            _IsNotPrint_GroupName = True
            '//
            Call ExportExcel_DonHang()
            _IsPrint_PrintArea = False
            _IsPrint_Sum = False
            _IsPrint_GridArea = False
            _IsNotPrint_GroupName = False
            'End If
            .Text = "ĐH Gia Công"
            .Enabled = True
        End With
    End Sub
    Private Sub ExportExcel_DonHang()
        moClsExcel = New ClsExportExcel
        With moClsExcel
            .strfileExcel_1 = "donhang_giacong.xls"
            ._rangeExcel = "A12"
            ._Columns_1 = {"id", "tenmau", "C", "mamau", "E", "mame", "G", "H", "socaytt", "sokgtt", "somettt"}
            ._rangeExcel_Text = {}
            ._rangeExcel_number_0 = {"I"}
            ._rangeExcel_number_1 = {"J", "K"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "V"}
            ._GridArea = {"A", "V"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socaytt", "sokgtt", "somettt"}
        End With
        '//
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _GdtNgayIn_1 = Format$(dt1_F.Value, "dd/MM/yyyy")
        _GdtNgayIn_2 = Format$(dt2_F.Value, "dd/MM/yyyy")
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If dgvr IsNot Nothing Then
            GDonhang = dgvr.Cells("donhang").FormattedValue.ToString
            GMahang = dgvr.Cells("mahang").FormattedValue.ToString
            GKhachhang = dgvr.Cells("khachhang").FormattedValue.ToString
            GLoaihang = dgvr.Cells("loaihang").FormattedValue.ToString
            GKhovai = dgvr.Cells("khovai").FormattedValue.ToString
            Gmetkg = dgvr.Cells("metkg").FormattedValue.ToString
        End If
        '//
        moClsExcel.ExportToExcelAsChecked(panel, Me.Name.ToString)
    End Sub
#End Region

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

#Region "EXCEL"
    Private Sub ToolStripButton_PhieuNhapKho_Click(sender As Object, e As EventArgs) Handles btnExport_Excel.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If Super_Dgv.PrimaryGrid.Rows.Count = 0 Then
            Exit Sub
        End If
        '--
        Dim btn As ToolStripButton = CType(sender, ToolStripButton)
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
            .strfileExcel_1 = "Report_DieuDo_Sanxuat.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "dttaome", "dtngaysanxuat", "donhang", "mahang", "khachhang", "loaihang",
               "quicach", "khovai", "metkg", _colMamau, _colTenMau, "tenmau_nhuom", "macongnghe", "macongnghe_tt",
               "mame_ghep", _colMame, "socaytt", "sokgtt", "somettt", "ghichu_thuchien_1", "ghichu"}
            ._rangeExcel_Text = {"Q", "R"}
            ._rangeExcel_number_0 = {"S"}
            ._rangeExcel_number_1 = {"T", "U"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B", "C"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "W"}
            ._GridArea = {"A", "W"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socaytt", "sokgtt", "somettt"}
        End With
        '//
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _GdtNgayIn_1 = Format$(dt1_F.Value, "dd/MM/yyyy")
        _GdtNgayIn_2 = Format$(dt2_F.Value, "dd/MM/yyyy")
        '//
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub



#End Region

#Region "XEM CHI TIET"
    Private Sub ShowModalForm_ChiTietMe()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_ChiTietMe))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmDieuDoSanXuat_Detail
                .Size = New Size(Me.Width * 0.95, Me.Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here

                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub



    Private Sub Super_Dgv_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellDoubleClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        'Try
        If dgvr IsNot Nothing Then
            frmDieuDoSanXuat_Detail.MaMe_id = dgvr.Cells("mame_id").FormattedValue
            ShowModalForm_ChiTietMe()
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
#End Region


#Region "XAC NHAN"
    Private Sub BtnHidden_XacNhan_LKT_Click(sender As Object, e As EventArgs) Handles BtnHidden_XacNhan_LKT.Click
        GP_Form_XacNhan_LoiKyThuat.Visible = False
    End Sub


    Private Sub XácNhậnMẻLỗiKỹThuậtToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim btn As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            'Initail_INNERFORM(btn.Name, False)
            _Update_MaCongDoan_In = True
            With GP_Form_XacNhan_LoiKyThuat
                .Text = "XÁC NHẬN LỖI KỸ THUẬT"
                .Size = New Size(.Width, .Height)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True

            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboThuocNhom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboThuocNhom.SelectedIndexChanged
        dr2 = dt_congdoan.Select("nhomloi = '" & cboThuocNhom.Text & "'", "")
        If dr2.Length > 0 Then
            _nhomloi_id = dr2.First.Item("nhomloi_id")
        Else
            'MsgBox("Vui lòng chọn nhóm.", MsgBoxStyle.Information, "Thông Báo")
            'Exit Sub
            _nhomloi_id = String.Empty
        End If
    End Sub

    Private Sub BtnXacNhan_LoiKyThuat_Click(sender As Object, e As EventArgs) Handles BtnXacNhan_LoiKyThuat.Click
        If _nhomloi_id.Length = 0 Then
            MsgBox("Vui lòng chọn nhóm.", MsgBoxStyle.Information, "Thông Báo")
            Exit Sub
        End If

        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có xác nhận mẻ lỗi kỹ thuật?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_fuction(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet]", sbXMLString.ToString, "update_loikythuat")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub UpdateDetails_fuction(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetailsInsertJob(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                    sbXMLString.Append("nhomloi_id='" + ReplaceTextXML(_nhomloi_id) + "' ")
                    sbXMLString.Append("ghichu_xacnhan='" + ReplaceTextXML(txtghichu_xacnhan.Text) + "' ")
                    'sbXMLString.Append("nhanvien_apmau='" + ReplaceTextXML(_stUser_Save) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

#End Region

#Region "XOA"
    Private Sub ToolStripMenuItem_HuyMeNhuom_Click(sender As Object, e As EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("mame_id").Value.ToString
        Dim Code As String = dgvr.Cells("mame").Value.ToString
        Dim CodeName As String = dgvr.Cells("donhang").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mẻ Nhuộm: " & Code _
                        & vbCrLf & vbCrLf & " - Đơn Hàng: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mame_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet]", sbXMLString.ToString, "delete")
            _Update_OK = dtControler.UPSET_XML(_dt)
            If _Update_OK = True Then
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
    Private Sub btnLuuThayDoi_Click(sender As Object, e As EventArgs) Handles BtnLuuThayDoi.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện lưu thay đổi?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_LuuThayDoi(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_luuthaydoi")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub UpdateDetails_LuuThayDoi(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_LuuThayDoi(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then

                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                    sbXMLString.Append("mame_01='" + ReplaceTextXML(row.Cells("mame_01").Value.ToString) + "' ")
                    sbXMLString.Append("mame_02='" + ReplaceTextXML(row.Cells("mame_02").Value.ToString) + "' ")
                    sbXMLString.Append("socay='" + CNumber_system(row.Cells("socay").Value.ToString) + "' ")
                    sbXMLString.Append("sokg='" + CNumber_system(row.Cells("sokg").Value.ToString) + "' ")
                    sbXMLString.Append("somet='" + CNumber_system(row.Cells("somet").Value.ToString) + "' ")
                    sbXMLString.Append("ghichu='" + ReplaceTextXML(row.Cells("ghichu").Value.ToString) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

#End Region

#Region " NHAT KY SAN XUAT"

    Private Sub CtxFunction_NhatKy_Click(sender As Object, e As EventArgs) Handles CtxFunction_NhatKy.Click
        If LMaMe_01.Length < 2 Then Exit Sub
        ShowModalForm_NhatKySanXuat()
    End Sub
    Private Sub ShowModalForm_NhatKySanXuat()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_NhatKySanXuat))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmDieuDoSanXuat_NhatKySanXuat_MaMe
                .Size = New Size(Form1.Width * 0.98, Form1.Height * 0.95)
                .StartPosition = FormStartPosition.CenterParent
                '//
                .MaMe = LMaMe_01
                '.MaCongNghe = txtmacongnghe_info.Text
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here

                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub

#End Region

#Region "XEM KHSX DON HANG"
    Private Sub ShowModalForm_KHSX_DonHang()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_KHSX_DonHang))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmBaoCao_QLSX_ALL_donHang
                .Size = New Size(Form1.Width * 0.9, Form1.Height * 0.8)
                .StartPosition = FormStartPosition.CenterParent
                '//
                .Donhang = LDonHang
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here

                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub

    Private Sub BtnView_KHSX_DonHang_Click(sender As Object, e As EventArgs) Handles BtnView_KHSX_DonHang.Click
        If LDonHang.Length < 2 Then
            MsgBox("Vui lòng chọn Đơn Hàng.", MsgBoxStyle.Information, "Thông Báo")
        Else
            ShowModalForm_KHSX_DonHang()
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

    Private Sub ToolStripButton_Delete_MeNhuom_Click(sender As Object, e As EventArgs) Handles ToolStripButton_Delete_MeNhuom.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("mame_id").Value.ToString
        Dim Code As String = dgvr.Cells("mame").Value.ToString
        Dim CodeName As String = dgvr.Cells("donhang").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Mẻ: " & Code _
                        & vbCrLf & vbCrLf & " - Đơn Hàng: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mame_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append("mota_chuyenmau='" + ReplaceTextXML("Xóa Mẻ") + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append("tenform='" + ReplaceTextXML(Me.Name.ToString) + "' ")
            sbXMLString.Append("tencot='" + ReplaceTextXML(Code) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "delete")
            _Update_OK = dtControler.UPSET_XML(_dt)
            If _Update_OK = True Then
                'ISChanged = True
                '//
                Call Filterdata_Stored()
            End If
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub

#Region "CAP NHAT DON HANG"
    Private Sub ToolStripButton_Mamau_Click(sender As Object, e As EventArgs) Handles ToolStripButton_DonHang.Click
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



    Private Sub Super_Dgv_donhang_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '//
        'columns(_colMakhach).HeaderText = "Mã Lò"
        'columns(_colkhachhang).HeaderText = "Lò Dệt"
        '//
        '--
        '//Ẩn Cột
        For Each item As GridElement In panel.Columns
            Dim column As GridColumn = TryCast(item, GridColumn)
            Dim _TFormat As String = String.Empty
            If column.Name.ToLower.Contains("_id") = True Then
                column.Visible = False
            End If
        Next item
        '//
        'panel.AddGroup(panel.Columns("mucdich"))
        '//
        If _List_ColumnGrouped.Length > 0 Then
            For Each _ColumnGrouped As String In _List_ColumnGrouped
                panel.AddGroup(panel.Columns(_ColumnGrouped))
            Next
        End If

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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mahang")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDir_Asc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDir_Asc(sortCols))
        End If

    End Sub
#End Region
#End Region

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

#Region " XAC NHAN ME MAU"
    Private Sub ToolStripButton_XacNhanMeMau_Click(sender As Object, e As EventArgs) Handles ToolStripButton_XacNhanMeMau.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có xác nhận mẻ mẫu?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_fuction_sampleBatch(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_memau")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub UpdateDetails_fuction_sampleBatch(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetailsInsertJob(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub
#End Region
End Class