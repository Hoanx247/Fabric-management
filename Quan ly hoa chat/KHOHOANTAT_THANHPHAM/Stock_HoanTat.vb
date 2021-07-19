
Imports System.Runtime.InteropServices
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text


Public Class Stock_HoanTat
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
    Dim dt_mame As DataTable, dt_kieunhap As DataTable


    Dim _intRows_ALL As Integer = 0
    Dim _intColumns_ALL As Integer = 0, _intGroup_count As Integer = 0
    Dim _filter As Boolean = False
    Dim _saveRowIndex As Integer = 0
    Dim _Column_Forzen_pos As Byte = 0

    '--
    Dim _mame_id As String, _mame As String
    Dim _kieuxuat_id As String, _stMakytu_xuat As String
    Dim dr2 As DataRow()
    Dim _chungtunhap_id As String
    Dim ProgramPosition, cursorPoint As Point
    Dim _kieunhap_id As String, _stMakytu_nhap As String
    Dim _load_Finish As Boolean = False
    Dim _makh_id As String = String.Empty, _mahang_id As String = String.Empty, _mamau_id As String = String.Empty
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private IsBusy As Boolean = False
    Private _update_ok As Boolean = False
    Private Lmame As String = String.Empty
    Private LMaMe_01 As String = String.Empty
    '//
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
    Private _MyFont_normal As New Font("Time New Roman", 11, FontStyle.Regular)
#End Region

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing

        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
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
        '//
        dt_local = New DataTable
        dt_mame = New DataTable
        dt_kieunhap = New DataTable
        '--
        With dt1_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        With dt2_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        '--
        Me.dt1_F.Value = CDate(FormatDateTime(DateSerial(Now.Year, Now.Month, Now.Day - 10), DateFormat.ShortDate))
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))
        cboLoai.SelectedIndex = 0
        '--
        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        AddHandler Super_Dgv.KeyDown, AddressOf Super_Dgv_KeyDown
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '--
        '//
        Load_KieuNhap()
    End Sub


    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call Check_administrator(Me.Name.ToString)
        If _btView = True Then
            'btnAdd.Enabled = IIf(_btAdd = True, True, False)
            'btnModify.Enabled = IIf(_btModify = True, True, False)
            'btnDelete.Enabled = IIf(_btDelete = True, True, False)
            '----------
            Call Filterdata_Stored()
            _load_Finish = True
            '----------------
            '_filter = True
            '----------------
        Else
            Me.Close()
        End If
    End Sub
    Private Sub Load_KieuNhap()
        dt_kieunhap = VpsXmlList_Load("", "", "khothanhpham_mucdich")
        LoadDataToCombox(dt_kieunhap, cboKieuNhap, "mucdich", False)
    End Sub
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = e.GridColumn.ColumnIndex
            If e.GridColumn.ColumnIndex = 0 Then
                ShowContextMenu(CtxMnu_Select)
            Else
                ShowContextMenu(CtxMenu)
            End If
        End If
    End Sub
    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        clsDev.Super_Dgv_KeyDown(sender, e)
    End Sub
    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
            _mame_id = String.Empty
        Else
            _mame_id = dgvr.Cells(_colMame_ID).Value
            _mame = dgvr.Cells(_colMame).Value
            'txtdongia.Text = dgvr.Cells("dongia").Value
            txtsocay.Text = dgvr.Cells("socay_dinhhinh").Value
            txtsokg.Text = dgvr.Cells("sokg_dinhhinh").Value
            txtsomet.Text = dgvr.Cells("somet_dinhhinh").Value
            '--
            txtmame.Text = _mame
            Grp_ChungtuXuat.Text = "NHẬP KHO MẺ: " & _mame
            If e.GridCell.ColumnIndex = 0 Then
                panel.ReadOnly = True
                If dgvr.Checked = False Then
                    dgvr.Checked = True
                    dgvr.CellStyles.Default.Background.Color1 = Color.GreenYellow
                Else
                    dgvr.Checked = False
                    dgvr.CellStyles.Default.Background.Color1 = Color.White
                End If
            Else
                panel.ReadOnly = True
            End If

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
            '//
            'LGhiChu = dgvr.Cells("ghichu_ddsx").FormattedValue.ToString & " g/m2)"
            '///
            LMaMau = dgvr.Cells("mamau").FormattedValue.ToString
            LTenmau = dgvr.Cells("tenmau").FormattedValue.ToString
            '//
            'LSophieu_LKT = dgvr.Cells("sophieu_loikythuat").FormattedValue.ToString
            'LCongdoan_LKT = dgvr.Cells("congdoan_loikythuat").FormattedValue.ToString
            'LGhiChu_LKT = dgvr.Cells("ghichu_loikythuat").FormattedValue.ToString
            '//
            'Them <br/> để xuống dòng
            Dim stinfo As String = "<b><font size=""13""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo &= "<font size=""13""><font color=""Black""> {1} </font></font>"
            Dim stinfo_br As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo_br &= "<font size=""13""><font color=""Black""> {1} </font></font><br/>"
            '//

            Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
            '////
            panel.Footer.Text = String.Format(stinfo, "+ ĐƠN HÀNG: ", Ldonhang.ToUpper & " || ")
            panel.Footer.Text &= String.Format(stinfo, "+ MÃ HÀNG: ", Lmahang.ToUpper & " - " & LLoaihang.ToUpper)
            panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ MÀU: ", LMaMau.ToUpper & " - " & LTenmau.ToUpper & " || ")
            panel.Footer.Text &= String.Format(stinfo, "+ MẺ: ",
                               Lmame.ToUpper & " - " & LMaMe_01.ToUpper)
            panel.Footer.Text &= String.Format(stinfo_br, "+ GHI CHÚ: ", LGhiChu)
            'panel.Footer.Text &= String.Format(stinfo, "+ PHIẾU LKT: ",
            'LSophieu_LKT.ToUpper & " - " & LCongdoan_LKT.ToUpper & " - " & LGhiChu_LKT.ToUpper)
        Else
            LMaMe_01 = String.Empty
            Ldonhang = String.Empty
            Lmame = String.Empty
        End If
        '//
        Call Taophieumoi()
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
        sbXMLString.Append("tenmau='" + ReplaceTextXML(txtmau_F.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoHoanTat_GetData_2021]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socay_phanme", "sokg_phanme", "somet_phanme", "socay_dinhhinh", "sokg_dinhhinh", "somet_dinhhinh"}
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
                        If CSng(row.Cells("haohut_sokg").Value) > 6 Then
                            row.Cells(_colMame).CellStyles.Default.Background.Color1 = Color.Red
                            row.Cells("haohut_sokg").CellStyles.Default.Background.Color1 = Color.Red
                        End If
                        If CSng(row.Cells("haohut_somet").Value) > 6 Then
                            row.Cells(_colMame).CellStyles.Default.Background.Color1 = Color.Red
                            row.Cells("haohut_somet").CellStyles.Default.Background.Color1 = Color.Red
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("dtthanhpham_kcs"), panel.Columns("mame_ghep"), panel.Columns("intnhomhang")}
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
            CType(SortDirection.Ascending, SortDirection)})
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

    Private Sub btTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call Filterdata_Stored()
    End Sub




#Region "NHAP KHO THANH PHAM"

    Private Sub btnTaoChungTu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaoChungTu.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        If dgvr Is Nothing Then Exit Sub
        'Try
        Me.dtNgayNhap_chungtu.Value = DateSerial(Now.Year, Now.Month, Now.Day.ToString)
        With dgvr
            _mame_id = .Cells(_colMame_ID).Value
            _mame = .Cells(_colMame).Value
            cboKieuNhap.SelectedIndex = 0
        End With
        Grp_ChungtuXuat.Text = "NHẬP KHO MẺ: " & _mame
        '---
        With Grp_ChungtuXuat
            .Location = New Point((Super_Dgv.Width / 2) - (.Width / 2), (Super_Dgv.Height / 2) - (.Height / 2))
            .Visible = True
        End With
        wait(200)
        '--Kiem Tra Kieu Nhap
        dr2 = dt_kieunhap.Select("mucdich = '" & cboKieuNhap.Text & "'", "")
        If dr2.Length > 0 Then
            _stMakytu_nhap = dr2.First.Item(1)
            _kieunhap_id = dr2.First.Item(0)
            Call Taophieumoi()
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Taophieumoi()
        Dim dt_Temp As New DataTable
        Dim str_sophieu As String
        Dim _Nam As String, _Thang As String, _Ngay As String
        Dim dbl_stt As Integer = 0
        str_sophieu = String.Empty
        '---Load gio he thong
        'Try
        dr2 = dt_kieunhap.Select("mucdich = '" & cboKieuNhap.Text & "'", "")
        If dr2.Length > 0 Then
            _stMakytu_nhap = dr2.First.Item("makytu")
            _kieunhap_id = dr2.First.Item("mucdich_id")
        End If
        Call Load_TimeServer()
        _Ngay = _TimeServer.Day.ToString
        _Nam = Mid$(_TimeServer.Year.ToString, 4, 1)
        _Nam = KyTu_Nam(_Nam)
        ''//
        _Thang = KyTu_Thang_Nhom2(_TimeServer.Month)
        '//
        If Len(_Ngay) = 1 Then _Ngay = "0" & _Ngay
        '---------
        str_sophieu = "TP" & _Nam & _Thang
        txtchungtunhap.Text = VpsXmlList_CreateID(str_sophieu, "chungtu_thanhpham")

    End Sub

    Private Sub cboKieuNhap_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboKieuNhap.SelectedIndexChanged
        '--Kiem Tra Kieu Nhap
        If _load_Finish = True Then
            Call Taophieumoi()
        End If

    End Sub

    Private Sub Rdb_Nhom1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _load_Finish = True Then
            Call Taophieumoi()
        End If

    End Sub
    Private Sub Rdb_Nhom2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _load_Finish = True Then
            Call Taophieumoi()
        End If

    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Grp_ChungtuXuat.Visible = False
    End Sub
#End Region



    Private Sub ChkTon_KhoHoanTat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTon_KhoHoanTat.CheckedChanged
        If ChkTon_KhoHoanTat.CheckState = CheckState.Checked Then
            dt1_F.Enabled = False
            dt2_F.Enabled = False
        Else
            dt1_F.Enabled = True
            dt2_F.Enabled = True
        End If
    End Sub

#Region "EXECUTE"
    Private Sub btnXacNhan_DaCang_Click(sender As Object, e As EventArgs) Handles cmdCapnhat.Click
        _chungtunhap_id = txtchungtunhap.Text.Trim & _mame_id.Trim
        Update_Data("", "")
    End Sub

    Private Function CheckData() As Boolean
        CheckData = True
        '---Kiem tra don hàng
        If _mame_id.Length = 0 Then
            MessageBox.Show("Xin kiểm tra Mẻ Nhuộm!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmame_F.Focus()
            CheckData = False
            Exit Function
        End If
        If _kieunhap_id.Length = 0 Then
            MessageBox.Show("Xin kiểm tra mục đích nhập!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboKieuNhap.Focus()
            CheckData = False
            Exit Function
        End If
    End Function

    Private Sub Update_Data(ByVal sqlcommand As String, ByVal command As String)
        If CheckData() = True Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mame_id='" + ReplaceTextXML(_mame_id) + "' ")
            sbXMLString.Append("socay='" + CNumber_system(txtsocay.Text) + "' ")
            sbXMLString.Append("sokg='" + CNumber_system(txtsokg.Text) + "' ")
            sbXMLString.Append("somet='" + CNumber_system(txtsomet.Text) + "' ")
            sbXMLString.Append("dongia='" + CNumber_system(txtdongia.Text) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
            sbXMLString.Append("mucdich_id='" + ReplaceTextXML(_kieunhap_id) + "' ")
            sbXMLString.Append("chungtu_id='" + ReplaceTextXML(_chungtunhap_id) + "' ")
            sbXMLString.Append("chungtu='" + ReplaceTextXML(txtchungtunhap.Text) + "' ")
            sbXMLString.Append("dtngaytao='" + Format$(dtNgayNhap_chungtu.Value, "MM/dd/yyyy") + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(strname) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")

            '//
            _dt = New KhoSanXuatDTO("[vpsXmlKhoThanhPham_UPSET_combine_2021]", sbXMLString.ToString, "insert")
            _update_ok = dtControler.UPSET_XML(_dt)
            If _update_ok = True Then
                '//
                Call Filterdata_Stored()
            End If

        End If
    End Sub

#End Region
#Region "XEM CHI TIET"
    Private Sub ShowModalForm_ChiTietMe()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_ChiTietMe))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With Stock_HoanTat_Detail_View
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
            Stock_HoanTat_Detail_View.Chungtu = dgvr.Cells("mame").FormattedValue
            ShowModalForm_ChiTietMe()
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
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
                _IsPrint_PrintArea = False
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
            .strfileExcel_1 = "06_Report_KhoHoanTat.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "dtthanhpham_kcs", "chungtu_thanhpham",
               "donhang", _colmahang, _colkhachhang, _colloaihang, _colkhovai, _colmetkg, "mamau_khach", "tenmau_khach",
               _colMamau, _colTenMau, "mame_ghep", _colMame,
                "socay_phanme", "sokg_phanme", "somet_phanme", "socay_dinhhinh", "sokg_dinhhinh", "somet_dinhhinh",
                "haohut_sokg", "haohut_somet",
                 "dongia", "thanhtien", "ghichu_thanhpham"}
            ._rangeExcel_Text = {"H", "I"}
            ._rangeExcel_number_0 = {}
            ._rangeExcel_number_1 = {"Q", "T"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "AB"}
            ._GridArea = {"A", "AB"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socay_phanme", "sokg_phanme", "sometmoc", "socay_dinhhinh", "sokg_dinhhinh", "somet_dinhhinh",
              "thanhtien"}
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

End Class