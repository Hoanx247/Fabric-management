Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text


Public Class Stock_Thanhpham_Detail_View
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim st As String = String.Empty
    Dim _Chungtu As String = String.Empty
    Private _List_Column_Locked As String() = {"khovai", "ghichu_thuchien_1", "mamau_khachhang", "metkg", "mame_ghep", "menhuom_chung"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Dim _load_finish As Boolean = False
    Private IsBusy As Boolean = False
    '//
    Dim dr2 As DataRow()
    Private dt_kieuxuat As DataTable
    Private _kieuxuat_id As String = String.Empty
    Private _chungtuxuat_id As String = String.Empty
    Private SoDongChon As Int16 = 0
    '//
    '//
    Private Lmame As String = String.Empty
    Private LMaMe_01 As String = String.Empty
    Private Ldonhang As String = String.Empty
    Private Lmahang As String = String.Empty
    Private LKhachhang As String = String.Empty
    Private LLoaihang As String = String.Empty
    Private Lmahang_khach As String = String.Empty
    Private Lloaihang_khach As String = String.Empty
    Private LBenNhan_khach As String = String.Empty
    Private Lkhovai As String = String.Empty
    Private Lmetkg As String = String.Empty
    Private LMaMau As String = String.Empty
    Private LTenmau As String = String.Empty
    Private LMaMau_khach As String = String.Empty
    Private LTenmau_khach As String = String.Empty
    Private LListMame As String = String.Empty
    Private LMaCongNghe As String = String.Empty
    Private LSocay As Int16 = 0
    Private LSokg As Single = 0
    Private LSomet As Single = 0
    Private LLoaiDay As String = String.Empty
    Private LGhiChu As String = String.Empty
    '///
    Private LSophieu_LKT As String = String.Empty
    Private LCongdoan_LKT As String = String.Empty
    Private LGhiChu_LKT As String = String.Empty

    '//
    Private _stMakytu_xuat As String = String.Empty
    '//
    Private T_mame_id As String = String.Empty
    Public Property MaMe_id() As String
        Get
            Return T_mame_id
        End Get
        Set(ByVal value As String)
            T_mame_id = value
        End Set
    End Property


#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Me.DialogResult = DialogResult.OK
        '//
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()

    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_kieuxuat = New DataTable
        '//
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '///
        With Super_Dgv
            .PrimaryGrid.KeepRowsSorted = False
        End With
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged

        AddHandler tpress.Tick, AddressOf MyTickHandler
        '----------
        Call Load_KieuXuat()
        '--
        With dtNgayxuat_chungtu
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        Call Load_TimeServer()
        dtNgayxuat_chungtu.Value = _TimeServer
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



#End Region

#Region "SUPERGRID"
    Private Sub mnu_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtxMnu_Select_ALL.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, True)
    End Sub

    Private Sub mnu_Remove_ALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtxMnuSelect_Remove.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, False)
    End Sub
    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        If _load_finish = True Then
            clsDev.SuperDgv_CellValueChanged(sender, e)
        End If

    End Sub
    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Super_Dgv.KeyDown
        clsDev.Super_Dgv_KeyDown(sender, e)
    End Sub
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = CByte(e.GridColumn.ColumnIndex)
            If e.GridColumn.ColumnIndex = 0 Then
                ShowContextMenu(CtxMnu_Select)
            Else
                ShowContextMenu(CtxMenu)
            End If
        Else

        End If
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            'ShowContextMenu(CtxFunction)
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
                '//

            ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
                panel.AllowEdit = False
                panel.ReadOnly = True
            End If
            '//
            '//
            If dgvr IsNot Nothing Then
                'txtghichu_xuat.Text = dgvr.Cells("macongdoan_yeucau").FormattedValue.ToString
                'Lmame_id = dgvr.Cells("mame_id").FormattedValue.ToString
                Lmame = dgvr.Cells("mame").FormattedValue.ToString
                'LMaMe_01 = dgvr.Cells("mame_01").FormattedValue.ToString
                Ldonhang = dgvr.Cells("donhang").FormattedValue.ToString
                '//
                Lmahang = dgvr.Cells("mahang").FormattedValue.ToString
                LLoaihang = dgvr.Cells("loaihang").FormattedValue.ToString
                Lkhovai = dgvr.Cells("khovai").FormattedValue.ToString & " cm"
                Lmetkg = dgvr.Cells("metkg").FormattedValue.ToString & " g/m2)"
                '///
                LMaMau = dgvr.Cells("mamau").FormattedValue.ToString
                LTenmau = dgvr.Cells("tenmau").FormattedValue.ToString
                'LMaCongNghe = dgvr.Cells("macongnghe").FormattedValue.ToString
                '//
                'LSophieu_LKT = dgvr.Cells("sophieu_loikythuat").FormattedValue.ToString
                'LCongdoan_LKT = dgvr.Cells("congdoan_loikythuat").FormattedValue.ToString
                'LGhiChu_LKT = dgvr.Cells("ghichu_loikythuat").FormattedValue.ToString
                '//
                'Them <br/> để xuống dòng
                Dim stinfo As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<font size=""16""><font color=""Black""> {1} </font></font>"
                Dim stinfo_br As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo_br &= "<font size=""16""><font color=""RED""> {1} </font></font><br/>"
                '//

                Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                '////
                panel.Footer.Text = String.Format(stinfo, "+ ĐƠN HÀNG: ", Ldonhang.ToUpper & " || ")
                panel.Footer.Text &= String.Format(stinfo, "+ MÃ HÀNG: ", Lmahang.ToUpper & " - " & LLoaihang.ToUpper)
                panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ MÀU: ", LMaMau.ToUpper & " - " & LTenmau.ToUpper & " || ")
                panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ CN: ", LMaCongNghe)
                panel.Footer.Text &= String.Format(stinfo, "+ MẺ: ",
                                   Lmame.ToUpper & " - " & LMaMe_01.ToUpper)
                panel.Footer.Text &= String.Format(stinfo, "+ PHIẾU LKT: ",
                                 LSophieu_LKT.ToUpper & " - " & LCongdoan_LKT.ToUpper & " - " & LGhiChu_LKT.ToUpper)
            Else
                LMaMe_01 = String.Empty
                Ldonhang = String.Empty
                Lmame = String.Empty
            End If

        End If
        _saveRowIndex = e.GridCell.RowIndex
        '_columnName = panel.ActiveCell.GridColumn.Name

    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub
    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btnSave_ColumnFrozen.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        panel.FrozenColumnCount = _Column_Forzen_pos
    End Sub

#End Region

#Region "LOAD DATA"
    Private Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(T_mame_id) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoThanhPham_Chitiet_MaMe_2021]", sbXMLString.ToString, "select")
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        dtControler.SELECT_XML(_dt, panel)
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"sokgmoc", "sometmoc", "sokgtp", "somettp"}
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
        'IsChanged = True '//Khong đánh dấu khi load data
        Call UpdateShowALLRows(panel.Rows)
        'IsChanged = False
        'lblRow.Text = "Tổng số: " & n
        Dim st As String = "<div align=""center"">" & "<font color=""Blue"">{0}</font><br/>" & "<font color=""Black"">{1}</font>" & "</div>"
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
        Dim _chon_mau As String = String.Empty
        Dim _MaCongNghe_dangthuchien As String = String.Empty
        Dim _MaCongNghe_dathuchien As String = String.Empty
        '////
        Dim _isSame As Int16 = 0
        Dim _colorhtml As String = String.Empty
        '////
        For Each item As GridElement In rows
            If _blnPress = False Then Exit For
            If item.Visible = True Then

                Dim group As GridGroup = TryCast(item, GridGroup)
                If group IsNot Nothing Then
                    UpdateShowALLRows(group.Rows)
                Else
                    Dim row As GridRow = TryCast(item, GridRow)

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
        '--
        Dim _stCol As String
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '//
        _stName = "Theo_Moc"
        _stHeadText = "Mộc"
        _stCol1 = "sokgmoc"
        _stCol2 = "sometmoc"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_ThanhPham"
        _stHeadText = "T.Phẩm"
        _stCol1 = "sokgtp"
        _stCol2 = "somettp"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If

        '--
        _stName = "Theo_ThanhTien"
        _stHeadText = "Thành Tiền"
        _stCol1 = _coldongia
        _stCol2 = _colthanhtien
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mame"), panel.Columns("macay")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        End If
        '//
        tpress.Enabled = True

    End Sub
    Public Function GetSortDirAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Descending, SortDirection)})
    End Function

#End Region
    Private Sub btnXoa_Click(sender As Object, e As EventArgs)
        Dim stmacay As String = String.Empty
        Dim stchungtu_id As String = String.Empty
        Dim _intMinute As Int32 = 0
        If MsgBox("Bạn có muốn xóa mã cây ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo") = MsgBoxResult.Yes Then
            '_GioTao = .CurrentRow.Cells("dtnhapmoc").Value
            'stma = .CurrentRow.Cells("macay").Value
            '_intMinute = DateDiff(DateInterval.Minute, _GioTao, Now)
            If _intMinute > 3000 Then
                'MessageBox.Show("Vui Lòng Liên Hệ Trưởng Ca.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else

            End If

            Dim panel As GridPanel = Super_Dgv.PrimaryGrid
            Dim dgvr As GridRow = panel.ActiveRow
            '--
            If dgvr Is Nothing Then Exit Sub
            With dgvr
                stmacay = dgvr.Cells("macay").Value
                stchungtu_id = dgvr.Cells("chungtu_id").Value
            End With
            '///
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            '//
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("macay='" + ReplaceTextXML(stmacay) + "' ")
            sbXMLString.Append(" />")
            '//
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[vpsXmlKhoThanhPham_XuatKho_Detail_UPSET_2021]", sbXMLString.ToString, "update_trakhothanhpham")
            'dtControler.UPSET_XML(_dt)

            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub btTim_Click(sender As Object, e As EventArgs)
        Call Filterdata_Stored()
    End Sub


#Region "EXCEL"
    Private Sub btnExport_Excel_Click(sender As Object, e As EventArgs) Handles btnExport_Excel.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If Super_Dgv.PrimaryGrid.Rows.Count = 0 Then
            Exit Sub
        End If
        '--
        Dim btn As ButtonItem = CType(sender, ButtonItem)
        With btn
            .Text = "Xin Chờ..."
            .Enabled = False
            If MsgBox("Bạn có Muốn Xuất Excel (Yes: Xuất Excel / No: Thoát) ?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "In PDF") = MsgBoxResult.Yes Then
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
            .strfileExcel_1 = "Report_packing_list.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "donhang", _colmahang, _colkhachhang, _colloaihang, _colkhovai, _colmetkg, _colMamau, _colTenMau, _colMame, "macay", "sokgtp", "somettp", "dongia", "thanhtien", "ghichu"}
            ._rangeExcel_Text = {"J"}
            ._rangeExcel_number_0 = {}
            ._rangeExcel_number_1 = {}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "M"}
            ._GridArea = {"A", "M"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {}
        End With
        '//
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _GdtNgayIn_1 = ""
        _GdtNgayIn_2 = ""
        '//
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub


#End Region

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim stmacay As String = String.Empty
        Dim stchungtu_id As String = String.Empty
        Dim _intMinute As Int32 = 0
        If MsgBox("Bạn có muốn xóa trả về kho Thành Phẩm ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo") = MsgBoxResult.Yes Then
            '_GioTao = .CurrentRow.Cells("dtnhapmoc").Value
            'stma = .CurrentRow.Cells("macay").Value
            '_intMinute = DateDiff(DateInterval.Minute, _GioTao, Now)
            If _intMinute > 3000 Then
                'MessageBox.Show("Vui Lòng Liên Hệ Trưởng Ca.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else

            End If

            Dim panel As GridPanel = Super_Dgv.PrimaryGrid
            Dim dgvr As GridRow = panel.ActiveRow
            '--
            If dgvr Is Nothing Then Exit Sub
            With dgvr
                stmacay = dgvr.Cells("macay").Value
                'stchungtu_id = dgvr.Cells("chungtu_id").Value
            End With
            '///
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            '//
            '//

            Call UpdateDetails_update_TraKhoHoaTat(panel.Rows)
            '//
            '//
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[vpsXmlKhoThanhPham_ChiTiet_Update]", sbXMLString.ToString, "delete_TraVeKhoHoanTat")
            dtControler.UPSET_XML(_dt)

            Call Filterdata_Stored()
        End If
    End Sub
    Private Sub UpdateDetails_update_TraKhoHoaTat(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim _mamay_id As String = String.Empty
        Dim _congdoan_id As String = String.Empty
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_TraKhoHoaTat(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("macay='" + CNumber_system(row.Cells("macay").Value) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub
#Region "XUAT HANG"
    Private Sub ToolStripButton_XacNhanHoanThanh_Click(sender As Object, e As EventArgs) Handles cmdCapnhat.Click
        _chungtuxuat_id = txtchungtuxuat.Text & T_mame_id
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//

        Call UpdateDetails_update_XuatHang(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[vpsXmlKhoThanhPham_XuatHang_UPSET_combine_Macay_2021]", sbXMLString.ToString, "insert")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
        End If

    End Sub
    Private Sub UpdateDetails_update_XuatHang(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim _mamay_id As String = String.Empty
        Dim _congdoan_id As String = String.Empty
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_XuatHang(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(T_mame_id) + "' ")
                    sbXMLString.Append("macay='" + CNumber_system(row.Cells("macay").Value) + "' ")
                    sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
                    sbXMLString.Append("mucdich_id='" + ReplaceTextXML(_kieuxuat_id) + "' ")
                    sbXMLString.Append("chungtu_id='" + ReplaceTextXML(_chungtuxuat_id) + "' ")
                    sbXMLString.Append("chungtu='" + ReplaceTextXML(txtchungtuxuat.Text) + "' ")
                    sbXMLString.Append("dtngaytao='" + Format$(dtNgayxuat_chungtu.Value, "MM/dd/yyyy") + "' ")
                    sbXMLString.Append("nguoitao='" + ReplaceTextXML(strname) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

    Private Function CheckData() As Boolean
        CheckData = True
        '---Kiem tra don hàng
        If T_mame_id.Length = 0 Then
            MessageBox.Show("Xin kiểm tra Mẻ Nhuộm!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmame.Focus()
            CheckData = False
            Exit Function
        End If
        If _kieuxuat_id.Length = 0 Then
            MessageBox.Show("Xin kiểm tra mục đích Xuất!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboKieuNXuat.Focus()
            CheckData = False
            Exit Function
        End If
    End Function


    Private Sub Load_KieuXuat()
        dt_kieuxuat = VpsXmlList_Load("", "", "xuathang_mucdich")
        LoadDataToCombox(dt_kieuxuat, cboKieuNXuat, "mucdich", False)

    End Sub
    Private Sub cboKieuXuat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboKieuNXuat.SelectedIndexChanged
        '--Kiem Tra Kieu Nhap
        If _load_finish = True Then
            Call Taophieumoi()
        End If
    End Sub

    Private Sub Taophieumoi()
        Dim dt_Temp As New DataTable
        Dim str_sophieu As String, stMa As String
        Dim _Nam As String, _Thang As String
        Dim dbl_stt As Integer = 0
        str_sophieu = String.Empty
        '---Load gio he thong
        dr2 = dt_kieuxuat.Select("mucdich = '" & cboKieuNXuat.Text & "'", "")
        If dr2.Length > 0 Then
            _stMakytu_xuat = dr2.First.Item("makytu")
            _kieuxuat_id = dr2.First.Item("mucdich_id")
        End If
        Call MdlData.Load_TimeServer()
        _Nam = KyTu_Nam(Mid$(_TimeServer.Year.ToString, 4, 1))
        _Thang = KyTu_Thang_Nhom2(_TimeServer.Month)
        stMa = _Nam & _Thang & "X"
        '---------
        '///
        txtchungtuxuat.Text = VpsXmlList_CreateID(stMa, "chungtuxuat")
        If Len(txtchungtuxuat.Text) = 0 Then
            txtchungtuxuat.Text = stMa & "0001"
        End If
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

#End Region

End Class