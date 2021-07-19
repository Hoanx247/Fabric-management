Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text


Public Class frmXuatHang
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    '//
    Private dtControler As KhoMocNhapKhoDAL
    Private _dt As KhoMocNhapKhoDTO
    Private dt_local As DataTable
    Private _Haohut_Kg As Single = 0, _Haohut_met As Single = 0
    '--
    Dim _saveRowIndex As Integer = 0
    Dim _Column_Forzen_pos As Byte = 0
    Private _update_ok As Boolean = False
    Dim _intRows_ALL As Integer = 0
    Dim _intColumns_ALL As Integer = 0, _intGroup_count As Integer = 0
    'Dim dr2 As DataRow()
    Dim ProgramPosition, cursorPoint As Point

    Dim _kieuxuat_id As String, _stMakytu_xuat As String
    Dim dr0 As DataRow()
    Dim _chungtuxuat_id As String
    Dim dt_kieuxuat As DataTable
    Private IsBusy As Boolean = False
    Private _IsBusy As Boolean = False
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _Nam_in As String = String.Empty, _Thang_in As String = String.Empty, _Ngay_in As String = String.Empty
    Private _TongKg_Moc As Single = 0
    Private _TongMet_Moc As Single = 0
    Private SoDongChon As Integer = 0
    Private _List_Column_Locked As String() = {"ghichu", "chungtu"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private Lmame As String = String.Empty
    Private LMaMe_01 As String = String.Empty
    '//
    Private LChungtu_id As String = String.Empty
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
    Dim dr2 As DataRow()

#Region "Move Panel"
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point


#Region "MOVE PANEL MAMAU"
    Private Sub GP_Form_CapNhat_MaMau_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grp_ChungtuXuat.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub
    Private Sub GP_Form_CapNhat_MaMau_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grp_ChungtuXuat.MouseMove
        If allowCoolMove = True Then
            Me.SuspendLayout()
            With Grp_ChungtuXuat
                .Location = New Point(.Location.X + e.X - myCoolPoint.X, .Location.Y + e.Y - myCoolPoint.Y)
            End With
            Me.ResumeLayout()
        End If
    End Sub
    Private Sub GP_Form_CapNhat_MaMau_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grp_ChungtuXuat.MouseUp
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
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        Call clsDev.SaveColumn(Super_Dgv_Detail.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Super_Dgv.Dispose()
    End Sub


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoMocNhapKhoDAL
        '// 
        '--
        dt_local = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        Call clsDev.Format_Super_Dgv(Super_Dgv_Detail, _MyFont_GridView - 1)
        '--
        With dt1_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        With dt2_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        Me.dt1_F.Value = CDate(FormatDateTime(DateSerial(Now.Year, Now.Month, Now.Day - 2), DateFormat.ShortDate))
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))
        '--
        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        AddHandler Super_Dgv.KeyDown, AddressOf Super_Dgv_KeyDown
        '--
        AddHandler Super_Dgv_Detail.DataBindingComplete, AddressOf Super_Dgv_detail_DataBindingComplete
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '--
        Option_Kg_Thanhpham.Checked = True
        '///
        Load_KieuXuat()
    End Sub
    Private Sub Load_KieuXuat()
        dt_kieuxuat = VpsXmlList_Load("", "", "xuathang_mucdich")
        LoadDataToCombox(dt_kieuxuat, cboKieuNXuat, "mucdich", False)
        LoadDataToCombox(dt_kieuxuat, cbokieuxuat, "mucdich", True)
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        cbokieuxuat.SelectedIndex = 0
        Call Check_administrator(Me.Name.ToString)
        If _btView = True Then
            btnAdd.Enabled = IIf(_btAdd = True, True, False)
            btnModify.Enabled = IIf(_btModify = True, True, False)
            btnDelete.Enabled = IIf(_btDelete = True, True, False)

            Call Filterdata_Stored()
            '----------------
            'txtClr_Vuot.BackColor = Color.MediumVioletRed
            'txtClr_Chuanhapdu.BackColor = Color.Violet
            'txtClr_NhapDu.BackColor = Color.White
            'txtClr_ChuaNhap.BackColor = Color.LightSeaGreen
            '_filter = True
            '----------------
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = e.GridColumn.ColumnIndex

            ShowContextMenu(CtxMenu)
        End If
    End Sub
    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        clsDev.Super_Dgv_KeyDown(sender, e)
    End Sub
    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        clsDev.SuperDgv_CellValueChanged(sender, e)
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

            ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
                panel.AllowEdit = False
                panel.ReadOnly = True
            End If
            '//
            If dgvr IsNot Nothing Then
                'If GroupPanel_ThayDoi_ThongTin.Visible = True Then
                cboKieuNXuat.Text = dgvr.Cells("mucdich").FormattedValue.ToString
                    txtchungtuxuat_Thongtin.Text = dgvr.Cells("chungtu").FormattedValue.ToString
                LChungtu_id = dgvr.Cells("chungtu_id").Value
                dtNgayxuat_chungtu.Value = dgvr.Cells("st_ngaytao").Value
                txtghichu_thongtin.Text = dgvr.Cells("ghichu").FormattedValue.ToString
                'End If
                '///
                Lmame = dgvr.Cells("mame").FormattedValue.ToString
                'LMaMe_01 = dgvr.Cells("mame_01").FormattedValue.ToString
                Ldonhang = dgvr.Cells("donhang").FormattedValue.ToString
                '//
                Lmahang = dgvr.Cells("mahang").FormattedValue.ToString
                LLoaihang = dgvr.Cells("loaihang").FormattedValue.ToString
                Lkhovai = dgvr.Cells("khovai").FormattedValue.ToString & " cm"
                Lmetkg = dgvr.Cells("metkg").FormattedValue.ToString & " g/m2)"
                '//
                LGhiChu = dgvr.Cells("ghichu").FormattedValue.ToString
                '///
                LMaMau = dgvr.Cells("mamau").FormattedValue.ToString
                LTenmau = dgvr.Cells("tenmau").FormattedValue.ToString
                LMaMau_khach = dgvr.Cells("mamau_khach").FormattedValue.ToString
                LTenmau_khach = dgvr.Cells("tenmau_khach").FormattedValue.ToString
                'LMaCongNghe = dgvr.Cells("macongnghe").FormattedValue.ToString
                '//
                'LSophieu_LKT = dgvr.Cells("sophieu_loikythuat").FormattedValue.ToString
                'LCongdoan_LKT = dgvr.Cells("congdoan_loikythuat").FormattedValue.ToString
                'LGhiChu_LKT = dgvr.Cells("ghichu_loikythuat").FormattedValue.ToString
                '//
                'Them <br/> để xuống dòng
                Dim stinfo As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<font size=""12""><font color=""Black""> {1} </font></font>"
                Dim stinfo_br As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo_br &= "<font size=""12""><font color=""Black""> {1} </font></font><br/>"
                '//

                Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                '////
                panel.Footer.Text = String.Format(stinfo, "+ ĐƠN HÀNG: ", Ldonhang.ToUpper & " || ")
                panel.Footer.Text &= String.Format(stinfo, "+ MÃ HÀNG: ", Lmahang.ToUpper & " - " & LLoaihang.ToUpper)
                panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ MÀU: ", LMaMau.ToUpper & " - " & LTenmau.ToUpper & " || ")
                panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ CN: ", LMaCongNghe)
                panel.Footer.Text &= String.Format(stinfo, "+ MẺ: ",
                                   Lmame.ToUpper & " - " & LMaMe_01.ToUpper)
                panel.Footer.Text &= String.Format(stinfo_br, "+ GHI CHÚ: ", LGhiChu)
                panel.Footer.Text &= String.Format(stinfo, "+ PHIẾU LKT: ",
                                 LSophieu_LKT.ToUpper & " - " & LCongdoan_LKT.ToUpper & " - " & LGhiChu_LKT.ToUpper)
            Else
                LMaMe_01 = String.Empty
                Ldonhang = String.Empty
                Lmame = String.Empty

            End If

        End If
        _saveRowIndex = e.GridCell.RowIndex

        If dgvr IsNot Nothing Then
            If Grp_ChungtuXuat.Visible = True Then
                _chungtuxuat_id = dgvr.Cells("chungtu_id").Value
                txtchungtuxuat.Text = dgvr.Cells("chungtu").Value
                txtmame.Text = dgvr.Cells("mame").Value
                txttongcay_xuat.Text = dgvr.Cells("socay_xuathang").Value.ToString
                txtTongKg.Text = FormatNumber(dgvr.Cells("sokg_xuathang").Value, 2)
                txttongsomet.Text = FormatNumber(dgvr.Cells("somet_xuathang").Value, 2)
                '//
                _TongKg_Moc = FormatNumber(dgvr.Cells("sokg_phanme").Value, 2)
                _TongMet_Moc = FormatNumber(dgvr.Cells("somet_phanme").Value, 2)
                '//
                txtdongia.Text = FormatNumber(dgvr.Cells("dongia").Value, 0)
                txtthanhtien.Text = FormatNumber(dgvr.Cells("thanhtien").Value, 0)
                txtghichu.Text = dgvr.Cells("ghichu").Value
                '//
                _Nam_in = Format$(dgvr.Cells("st_ngaytao").Value, "yyyy")
                _Thang_in = Format$(dgvr.Cells("st_ngaytao").Value, "MM")
                _Ngay_in = Format$(dgvr.Cells("st_ngaytao").Value, "dd")
                '--
                Lkhachhang = UCase(dgvr.Cells(_colkhachhang).Value.ToString)
                LLoaihang = UCase(dgvr.Cells(_colloaihang).Value.ToString)
                Lmahang = dgvr.Cells(_colmahang).Value.ToString
                Lmamau = dgvr.Cells(_colMamau).Value.ToString
                Ltenmau = dgvr.Cells("tenmau").Value.ToString
                '//
                wait(100)

                '//
                If Len(txtchungtuxuat.Text) > 5 Then
                    Call Filterdata_Detail()
                End If
            Else
                _chungtuxuat_id = String.Empty
                txttongcay_xuat.Text = 0
                txtchungtuxuat.Text = ""
            End If

        End If
        btnInPhieu.Enabled = True
    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub


    Private Sub Expand_SuperGrid()
        Super_Dgv.PrimaryGrid.ExpandAll()
    End Sub

    Private Sub Collapse_SuperGrid()
        Super_Dgv.PrimaryGrid.CollapseAll()
    End Sub
#End Region


    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkhachhang_F.KeyDown,
         txtloaihang_F.KeyDown, txtmamau_F.KeyDown,
        cbokieuxuat.KeyDown, txtmame_F.KeyDown, txtmahang_F.KeyDown, txtmame_F.KeyDown,
        txtchungtu_F.KeyDown, txtdonhang_F.KeyDown, txtdonhang_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub btTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub
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
        sbXMLString.Append("dtngay1='" + Format$(dt1_F.Value, "yyyyMMdd 00:00") + "' ")
        sbXMLString.Append("dtngay2='" + Format$(dt2_F.Value, "yyyyMMdd 23:59") + "' ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(txtdonhang_F.Text) + "' ")
        sbXMLString.Append("khachhang='" + ReplaceTextXML(txtkhachhang_F.Text) + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang_F.Text) + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML(txtloaihang_F.Text) + "' ")
        sbXMLString.Append("mamau='" + ReplaceTextXML(txtmamau_F.Text) + "' ")
        sbXMLString.Append("tenmau='" + ReplaceTextXML(txttenmau_F.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoMocNhapKhoDTO("[VpsXmlKhoXuat_GetData_2021]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socay_phanme", "sokg_phanme", "somet_phanme", "socay_dinhhinh", "sokg_dinhhinh", "somet_dinhhinh",
        "socay_xuathang", "sokg_xuathang", "somet_xuathang"}
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
                        '--
                        'If CInt(row.Cells("solan").Value) > 1 Then
                        'row.Cells(_colMame).CellStyles.Default.Background.Color1 = Color.Red
                        'Else
                        'row.Cells(_colMame).CellStyles.Default.Background.Color1 = Color.Empty
                        'ElseIf row.Cells(_colsocay).Value > row.Cells(_colsocayTT).Value And row.Cells(_colsocayTT).Value > 0 Then
                        'row.RowStyles.Default.RowHeaderStyle.Background.Color1 = Color.YellowGreen
                        'ElseIf row.Cells(_colsocayTT).Value = 0 Then
                        'row.RowStyles.Default.RowHeaderStyle.Background.Color1 = Color.LightSeaGreen
                        'If

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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("st_ngaytao"), panel.Columns("chungtu"), panel.Columns("mame")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        End If
        '//

        tpress.Enabled = True
    End Sub
    Public Function GetSortDirAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection),
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

#Region "XUAT HANG"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Grp_ChungtuXuat.Visible = False
    End Sub

    Private Sub Option_Kg_Thanhpham_CheckedChanged(sender As Object, e As EventArgs) Handles Option_Kg_Thanhpham.CheckedChanged
        Call Filterdata_Detail()
    End Sub

    Private Sub chkIn_KgMoc_CheckedChanged(sender As Object, e As EventArgs) Handles chkIn_KgMoc.CheckedChanged
        Call Filterdata_Detail()
    End Sub

    Private Sub Option_Mets_thanhpham_CheckedChanged(sender As Object, e As EventArgs) Handles Option_Mets_thanhpham.CheckedChanged
        'Call Filterdata_Detail()
    End Sub
#End Region

    Private Sub btnInPhieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInPhieu.Click
        With Grp_ChungtuXuat
            .Location = New Point((Super_Dgv.Width / 2) - (.Width / 2), (Super_Dgv.Height / 2) - (.Height / 2))
            .Visible = True
        End With
        wait(100)
        '--
        txtchungtuxuat.Text = String.Empty
        txtchungtuxuat.Focus()
    End Sub

#Region "IN PHIEU XUAT"

    Private Sub Filterdata_Detail()
        btn_InphieuXuat.Enabled = False
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("chungtu_id='" + ReplaceTextXML(_chungtuxuat_id) + "' ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoMocNhapKhoDTO("[VpsXmlKhoXuat_Chitiet_InPhieu_GetData_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '//
        dtControler.SELECT_XML(_dt, Super_Dgv_Detail.PrimaryGrid)

    End Sub


    Private Sub Super_Dgv_detail_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        'panel.AddGroup(panel.Columns("mucdich"))
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("macay")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscDesc_Detail(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscDesc_Detail(sortCols))
        End If
        '//

        'tpress.Enabled = True

        btn_InphieuXuat.Enabled = True
    End Sub
    Public Function GetSortDirAscDesc_Detail(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection)})
    End Function
#End Region

    Private Sub txtchungtuxuat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtchungtuxuat.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtchungtuxuat.Text) > 3 Then
                Call Filterdata_Detail()
            End If
        End If
    End Sub

    Private Sub BtnExport_Excel_Click(sender As Object, e As EventArgs) Handles BtnExport_Excel.Click
        If Len(txtchungtuxuat.Text) < 3 Then
            Exit Sub
        End If

        Super_Dgv.Enabled = False
        With BtnExport_Excel
            .Text = "Xin Chờ..."
            .Enabled = False
            Call Export_Excel_Chitiet("Print_xuathang.xls", False)
            .Text = "Xuất Excel"
            .Enabled = True
        End With
        Super_Dgv.Enabled = True
    End Sub

    Private Sub btn_InphieuXuat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_InphieuXuat.Click

        If Len(txtchungtuxuat.Text) < 3 Then
            Exit Sub
        End If

        Super_Dgv.Enabled = False
        With btn_InphieuXuat
            .Text = "Xin Chờ..."
            .Enabled = False
            Call Export_Excel_Chitiet("Print_xuathang.xls", True)
            .Text = "In Phiếu"
            .Enabled = True
        End With
        Super_Dgv.Enabled = True
    End Sub

#Region "XUAT EXCEL"
    Private Sub Export_Excel_Chitiet(ByVal strSaveFilename As String, ByVal blnIsVisible As Boolean)
        Me.SuspendLayout()
        Dim strFileName As String = My.Application.Info.DirectoryPath & "\Excel\" & strSaveFilename
        If System.IO.File.Exists(strFileName) = False Then
            MsgBox("Vui lòng kiểm tra file (" & strSaveFilename & ").", MsgBoxStyle.Information, "Thông Báo")
            Exit Sub
        End If
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim objExcel As Object, objWorkbook As Object
        Dim objSheet As Object
        'Gio chay
        objExcel = CreateObject("Excel.Application")
        While Not objExcel.ready
            wait(100)
        End While
        objExcel.visible = False
        objExcel.DisplayAlerts = False
        Try
            objWorkbook = objExcel.Workbooks.Add(strFileName)
            Dim nStartRow As Byte = 10
            Dim Introw As Integer = 0
            Dim _tongkg_M As Single = 0, _tongkg_X As Single = 0
            Dim _tongmet_M As Single = 0, _tongmet_X As Single = 0
            Dim intdong_1 As Integer = 0, intdong_2 As Integer = 10, intdong_3 As Integer = 10, intdong_4 As Integer = 10
            Dim intDong As Int16 = 0
            '--
            objSheet = objWorkbook.Sheets("Sheet1")
            'Insert the DataTable into the Excel Spreadsheet
            Dim _tongkg As Single = 0
            Dim _tongmet As Single = 0
            With objSheet
                Dim _index As SByte = 0
                .Cells(1, 8).Value = _Ngay_in
                .Cells(1, 10).Value = _Thang_in
                .Cells(1, 11).Value = _Nam_in
                .Cells(3, "D").Value = Lkhachhang
                .Cells(4, "D").Value = LLoaihang
                .Cells(3, "K").Value = Lmahang

                .Cells(19, "E").Value = CInt(txttongcay_xuat.Text)
                '--
                .Cells(3, "O").Value = txtmame.Text
                If Len(Lmamau) < 3 Then
                    .Cells(4, "K").Value = LMaMau_khach
                    .Cells(4, "O").Value = LTenmau_khach
                Else
                    .Cells(4, "K").Value = LMaMau
                    .Cells(4, "O").Value = Ltenmau
                End If
                '-
                .Cells(1, "O").Value = txtchungtuxuat.Text
                Dim panel As GridPanel = Super_Dgv_Detail.PrimaryGrid
                '---
                For Each item As GridElement In panel.Rows
                    Dim row As GridRow = TryCast(item, GridRow)
                    If row IsNot Nothing AndAlso row.Visible = True Then
                        If intDong <= 9 Then
                            .Cells(intDong + 7, "C").Value = row.Cells(_colmacay).Value
                            If chkIn_KgMoc.Checked = False Then
                                If Option_Kg_Thanhpham.Checked = True Then
                                    .Cells(intDong + 7, "F").Value = FormatNumber(row.Cells("sokgtp").Value, 2)
                                Else
                                    .Cells(intDong + 7, "F").Value = FormatNumber(row.Cells("somettp").Value, 2)
                                End If
                            Else

                                If Option_Kg_Thanhpham.Checked = True Then
                                    .Cells(intDong + 7, "D").Value = FormatNumber(row.Cells("sokgmoc").Value, 2)
                                    .Cells(intDong + 7, "F").Value = FormatNumber(row.Cells("sokgtp").Value, 2)
                                Else
                                    .Cells(intDong + 7, "D").Value = FormatNumber(row.Cells("sometmoc").Value, 2)
                                    .Cells(intDong + 7, "F").Value = FormatNumber(row.Cells("somettp").Value, 2)
                                End If
                            End If


                        ElseIf intDong > 9 And intDong <= 19 Then
                            .Cells(intdong_1 + 7, "K").Value = row.Cells(_colmacay).Value 'Mid(dgv.Rows(intDong).Cells(_colmacay).Value, 1, Len(dgv.Rows(intDong).Cells(_colmacay).Value)) & Replace_macay(dgv.Rows(intDong).Cells(_colmacay).Value)
                            If chkIn_KgMoc.Checked = False Then
                                If Option_Kg_Thanhpham.Checked = True Then
                                    .Cells(intdong_1 + 7, "O").Value = FormatNumber(row.Cells("sokgmoc").Value, 1)
                                Else
                                    .Cells(intdong_1 + 7, "O").Value = FormatNumber(row.Cells(_colsomet).Value, 1)
                                End If
                            Else

                                If Option_Kg_Thanhpham.Checked = True Then
                                    .Cells(intdong_1 + 7, "M").Value = FormatNumber(row.Cells("sokgmoc").Value, 2)
                                    .Cells(intdong_1 + 7, "O").Value = FormatNumber(row.Cells("sokgtp").Value, 1)
                                Else
                                    .Cells(intdong_1 + 7, "M").Value = FormatNumber(row.Cells("sometmoc").Value, 2)
                                    .Cells(intdong_1 + 7, "O").Value = FormatNumber(row.Cells("somettp").Value, 1)
                                End If
                            End If

                            intdong_1 = intdong_1 + 1
                        End If
                        intDong += 1
                    End If
                Next
                '///
                If chkIn_KgMoc.CheckState = CheckState.Checked Then
                    If Option_Kg_Thanhpham.Checked = True Then
                        '.Cells(23, "K").Value = FormatNumber(_TongKg_Moc, 1)
                        '.Cells(24, "K").Value = " Kg"
                        .Cells(19, "C").Value = "'" & FormatNumber(_TongKg_Moc, 1) & " Kg"
                    Else
                        '.Cells(23, "K").Value = FormatNumber(_TongMet_Moc, 1)
                        '.Cells(24, "K").Value = " Mét"
                        .Cells(19, "C").Value = "'" & FormatNumber(_TongMet_Moc, 1) & " Mét"
                    End If
                Else
                    .Cells(19, "C").Value = 0
                End If

                '.Cells(19, "F").Value = txtTongKg.Text
                If Option_Kg_Thanhpham.Checked = True Then
                    '.Cells(23, "L").Value = FormatNumber(txtTongKg.Text, 1)
                    '.Cells(24, "L").Value = " Kg"
                    .Cells(19, "H").Value = "'" & FormatNumber(txtTongKg.Text, 1) & " Kg"
                Else
                    '.Cells(23, "L").Value = FormatNumber(txttongsomet.Text, 1)
                    '.Cells(24, "L").Value = " Mét"
                    .Cells(19, "H").Value = "'" & FormatNumber(txttongsomet.Text, 1) & " Mét"
                End If
                '.Cells(19, "H").Value = _tongmet
                If Option_InDonGia.Checked = True Then
                    .Cells(19, "K").Value = txtdongia.Text
                    .Cells(19, "M").Value = txtthanhtien.Text
                Else
                    .Cells(19, "K").Value = ""
                    .Cells(19, "M").Value = ""
                End If
            End With
            If blnIsVisible = True Then
                'objWorkbook.SaveAs(strSaveFilename, Excel.XlFileFormat.xlWorkbookDefault)

                objSheet.PrintOut(1, 1, 1, False)
                '--
                'Dim dateEnd As Date = Date.Now
                'objExcel.PrintCommunication = True
                '--
                objWorkbook.Close(False)
                '~~> Quit the Excel Application
                objExcel.Quit()
                '~~> Clean Up
                objWorkbook = Nothing
                objExcel = Nothing
                ReleaseObject(objSheet)
                ReleaseObject(objWorkbook)
                ReleaseObject(objExcel)
                GC.Collect()
                GC.WaitForPendingFinalizers()
                GC.Collect()
                GC.WaitForPendingFinalizers()
                'End_Excel_App(datestart, dateEnd) ' This closes excel proces
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
                Me.ResumeLayout()
            Else
                objExcel.Visible = True
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
                'objExcel.PrintCommunication = True
            End If
        Catch ex As Exception
            objExcel.Quit()
            '~~> Clean Up
            objWorkbook = Nothing
            objExcel = Nothing
            ReleaseObject(objWorkbook)
            ReleaseObject(objExcel)
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            Dim intRel As Integer = 0
            Do
                intRel = System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            Loop While intRel > 0
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub


#End Region

#Region "XEM CHI TIET"
    Private Sub ShowModalForm_ChiTietMe()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_ChiTietMe))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmXuatHang_Detail_View
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
            frmXuatHang_Detail_View.Chungtu_ID = dgvr.Cells("chungtu_id").FormattedValue
            frmXuatHang_Detail_View.Chungtu = dgvr.Cells("chungtu").FormattedValue
            ShowModalForm_ChiTietMe()
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub


#End Region

    Private Sub ToolStripButton_delete_Click(sender As Object, e As EventArgs) Handles ToolStripButton_delete.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("chungtu_id").Value.ToString
        Dim Code As String = dgvr.Cells("mahang").Value.ToString
        Dim CodeName As String = dgvr.Cells("chungtu").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Hàng: " & Code _
                        & vbCrLf & vbCrLf & " - Chứng Từ: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("chungtu_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append("mota_chuyenmau='" + ReplaceTextXML("Xóa Mẻ") + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append("tenform='" + ReplaceTextXML(Me.Name.ToString) + "' ")
            sbXMLString.Append("tencot='" + ReplaceTextXML(CodeName) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoMocNhapKhoDTO("[vpsXmlXuatHang_UPSET]", sbXMLString.ToString, "delete_chungtu")
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



#Region "EXCEL"
    Private Sub ToolStripButton_PhieuNhapKho_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
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
            .strfileExcel_1 = "Report_XuatKho_ThanhPham.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "st_ngaytao", "chungtu",
               "donhang", _colmahang, _colkhachhang, _colloaihang, _colMamau, _colTenMau, _colMame,
                 "socay_xuathang", "sokg_xuathang", "somet_xuathang",
                "dongia", "thanhtien", "ghichu", "mame_ghep", "mamau_khach", "tenmau_khach"}
            ._rangeExcel_Text = {}
            ._rangeExcel_number_0 = {"K"}
            ._rangeExcel_number_1 = {"L", "M"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "P"}
            ._GridArea = {"A", "P"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socay_xuathang", "sokg_xuathang", "somet_xuathang", "thanhtien"}
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

#Region "LUU THAY DOI"
    Private Sub ToolStripButton_XacNhanHoanThanh_Click(sender As Object, e As EventArgs) Handles ToolStripButton_LuuThayDoi.Click
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_update_XuatHang(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoMocNhapKhoDTO("[vpsXmlXuatHang_UPSET]", sbXMLString.ToString, "update_luuthaydoi")
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
                    sbXMLString.Append("ghichu='" + ReplaceTextXML(row.Cells("ghichu").Value) + "' ")
                    sbXMLString.Append("chungtu_id='" + ReplaceTextXML(row.Cells("chungtu_id").Value) + "' ")
                    sbXMLString.Append("chungtu='" + ReplaceTextXML(row.Cells("chungtu").Value) + "' ")
                    sbXMLString.Append("nguoitao='" + ReplaceTextXML(strname) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub



#End Region

#Region "EXCEL"
    Private Sub ToolStripButton_Excel_ALL_Click(sender As Object, e As EventArgs) Handles ToolStripButton_Excel_ALL.Click
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
                Call ExportExcel_ALL()
                _IsPrint_PrintArea = False
                _IsPrint_Sum = False
                _IsPrint_GridArea = False
                _IsNotPrint_GroupName = False
            End If
            .Text = "Xuất Excel (Tất Cả)"
            .Enabled = True
        End With
    End Sub
    Private Sub ExportExcel_ALL()
        moClsExcel = New ClsExportExcel
        With moClsExcel
            .strfileExcel_1 = "05_Report_XuatKho.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "st_ngaytao", "chungtu",
               "donhang", _colmahang, _colkhachhang, _colloaihang, _colkhovai, _colmetkg, "mamau_khach", "tenmau_khach",
               _colMamau, _colTenMau, "mame_ghep", _colMame,
                "socay_phanme", "sokg_phanme", "somet_phanme", "socay_dinhhinh", "sokg_dinhhinh", "somet_dinhhinh",
                "socay_xuathang", "sokg_xuathang", "somet_xuathang", "haohut_sokg", "haohut_somet",
                 "dongia", "thanhtien", "ghichu"}
            ._rangeExcel_Text = {}
            ._rangeExcel_number_0 = {}
            ._rangeExcel_number_1 = {"R", "S"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "AB"}
            ._GridArea = {"A", "AB"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socay_phanme", "sokg_phanme", "sometmoc", "socay_dinhhinh", "sokg_dinhhinh", "somet_dinhhinh",
                "socay_xuathang", "sokg_xuathang", "somet_xuathang", "thanhtien"}
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

#Region " THAY DOI THONG TIN"
    Private Sub ToolStripButton_ThongTin_Click(sender As Object, e As EventArgs) Handles ToolStripButton_ThongTin.Click
        With GroupPanel_ThayDoi_ThongTin
            .Location = New Point((Super_Dgv.Width / 2) - (.Width / 2), (Super_Dgv.Height / 2) - (.Height / 2))
            .Visible = True
        End With
        '//
        BtnCapNhat_ThongTin.Enabled = True
        '//
        txtchungtuxuat.Text = String.Empty
        txtchungtuxuat.Focus()
    End Sub
    Private Sub Button_ThongTin_Exit_Click(sender As Object, e As EventArgs) Handles Button_ThongTin_Exit.Click
        GroupPanel_ThayDoi_ThongTin.Visible = False
    End Sub
    Private Function CheckData() As Boolean
        CheckData = True
        dr2 = dt_kieuxuat.Select("mucdich = '" & cboKieuNXuat.Text & "'", "")
        If dr2.Length > 0 Then
            _kieuxuat_id = dr2.First.Item("mucdich_id")
        End If
        '---Kiem tra don hàng
        If LChungtu_id.Length = 0 Then
            MessageBox.Show("Xin kiểm tra Mẻ Nhuộm!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmame_F.Focus()
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
    Private Sub BtnCapNhat_ThongTin_Click(sender As Object, e As EventArgs) Handles BtnCapNhat_ThongTin.Click
        BtnCapNhat_ThongTin.Enabled = False
        Update_Data("", "update")
    End Sub
    Private Sub Update_Data(ByVal sqlcommand As String, ByVal command As String)
        If CheckData() = True Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("chungtu_id='" + ReplaceTextXML(LChungtu_id) + "' ")
            sbXMLString.Append("chungtu='" + ReplaceTextXML(txtchungtuxuat_Thongtin.Text) + "' ")
            sbXMLString.Append("mucdich_id='" + ReplaceTextXML(_kieuxuat_id) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu_thongtin.Text) + "' ")
            sbXMLString.Append("dtngaytao='" + Format$(dtNgayxuat_chungtu.Value, "MM/dd/yyyy") + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(strname) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoMocNhapKhoDTO("[VpsXmlKhoXuat_UPSET_2021]", sbXMLString.ToString, "Update")
            _update_ok = dtControler.UPSET_XML(_dt)
            If _update_ok = True Then
                Call Filterdata_Stored()
                BtnCapNhat_ThongTin.Enabled = True
            End If

        End If
    End Sub

#End Region
End Class