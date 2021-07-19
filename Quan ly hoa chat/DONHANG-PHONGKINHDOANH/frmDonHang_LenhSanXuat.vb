Option Strict Off
Imports System
Imports System.Collections.Generic
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text

Public Class frmDonHang_LenhSanXuat
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable

    Dim _List_MameID As String() = {}
    Dim strList As List(Of String) = _List_MameID.ToList()
    '--
    Dim _List_CongDoanID As String() = {}
    Dim strCongDoanID As List(Of String) = _List_CongDoanID.ToList()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"donhang", "ghichu_thuchien_1", "mamau_khachhang", "tenmau_nhuom", "macongnghe_yeucau", "mame_ghep"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Private _update_ok As Boolean = False
    Private _bln_mamau As Boolean = False
    Private Lmamau_id As String = String.Empty
    Private DgvData As DataGridView = New DataGridView()
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
    Private LSocay As Int16 = 0
    Private LSokg As Single = 0
    Private LSomet As Single = 0
    Private LLoaiDay As String = String.Empty
    Private LGhiChu As String = String.Empty
    Private LListMame As String = String.Empty
#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()
        '--
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With dt1_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        With dt2_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        Me.dt1_F.Value = CDate(FormatDateTime(DateSerial(Now.Year, Now.Month, Now.Day - 5), DateFormat.ShortDate))
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_local = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        With Super_Dgv
            .PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.AllowWrap = True
        End With

        'AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        '--
        'AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler

        '//
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            Call Filterdata_chung()
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
            'Dim form As frm_Menhuom_Detail = New frm_Menhuom_Detail
            'Form.ShowDialog()
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
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
                '//

            ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
                panel.AllowEdit = False
                panel.ReadOnly = True
            End If
            '//
            If dgvr IsNot Nothing Then
                Ldonhang = dgvr.Cells("donhang").FormattedValue.ToString
                '//
                Lmahang = dgvr.Cells("mahang").FormattedValue.ToString
                LLoaihang = dgvr.Cells("loaihang").FormattedValue.ToString
                'Lmahang_khach = dgvr.Cells("mahang_khach").FormattedValue.ToString
                'Lloaihang_khach = dgvr.Cells("loaihang_khach").FormattedValue.ToString
                Lkhovai = dgvr.Cells("khovai").FormattedValue.ToString & " cm"
                Lmetkg = dgvr.Cells("metkg").FormattedValue.ToString & " g/m2)"
                '///
                'LMaMau = dgvr.Cells("mamau").FormattedValue.ToString
                'LTenmau = dgvr.Cells("tenmau").FormattedValue.ToString
                'LMaMau_khach = dgvr.Cells("mamau_khach").FormattedValue.ToString
                'LTenmau_khach = dgvr.Cells("tenmau_khach").FormattedValue.ToString
                '//
                LGhiChu = dgvr.Cells("ghichu").FormattedValue.ToString.Replace(vbCr, "").Replace(vbLf, "")
                LListMame = dgvr.Cells("mame").FormattedValue.ToString
                '//
                'Them <br/> để xuống dòng
                Dim stinfo As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<font size=""12""><font color=""Black""> {1} </font></font>"
                Dim stinfo_br As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo_br &= "<font size=""12""><font color=""Black""> {1} </font></font><br/>"
                '//
                Dim stMaCongNghe As String = "<div>" & "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stMaCongNghe &= "<font size=""12""><font color=""Black""> {1} </font></font>" & "</div>"
                '////
                panel.Footer.Text = String.Format(stinfo, "+ ĐƠN HÀNG: ", Ldonhang)
                '///panel.Footer.Text &= String.Format(stinfo, "+ MÃ HÀNG (KHÁCH): ", Lmahang_khach & " - [" & Lloaihang_khach & "]")
                panel.Footer.Text &= String.Format(stinfo, "+ MÃ HÀNG: ", Lmahang & " - [" & LLoaihang & "]")
                panel.Footer.Text &= String.Format(stinfo_br, "+ KHỔ: ", Lkhovai & " - [" & Lmetkg & "]")
                '//
                panel.Footer.Text &= String.Format(stinfo, "+ MÃ MÀU (KHÁCH): ", LMaMau_khach & " - [" & LTenmau_khach & "]")
                panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ MÀU (ST): ", LMaMau & " - [" & LTenmau & "]")
                '//
                panel.Footer.Text &= String.Format(stinfo_br, "+ CHÚ Ý: ", LGhiChu)
                '//
                panel.Footer.Text &= String.Format(stinfo, "+ MẺ: ", LListMame)
                '/---Khong Cho tao mẻ nếu chưa áp mã màu
                'If dgvr.Cells("mamau").Value.ToString.Length = 0 Then
                ' BtnMenu_LenhSanXuat.Enabled = False
                'panel.Footer.Text &= String.Format(stinfo, "+ ÁP MÃ MÀU: ", "Vui lòng áp mã màu cho mã hàng trước khi tạo mẻ. (Chọn nhiều mã hàng 1 lúc)")
                'Else
                ' BtnMenu_LenhSanXuat.Enabled = True
                'End If

            End If
        End If
        '_saveRowIndex = e.GridCell.RowIndex

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

    Private Sub mnu_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, True)
    End Sub

    Private Sub mnu_Remove_ALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, False)
    End Sub

    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
#End Region


#Region "LOAD DATA"
    Private Sub CircleProcess_Start()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        'panel.ClearAll()
        panel.DataSource = Nothing
        CircularProgress1.Location = New Point(CInt(Super_Dgv.Width / 3), CInt(Super_Dgv.Height / 3.5))
        CircularProgress1.IsRunning = True
        CircularProgress1.Visible = True
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
        sbXMLString.Append("dtngay1='" + Format$(dt1_F.Value, "yyyyMMdd 00:00") + "' ")
        sbXMLString.Append("dtngay2='" + Format$(dt2_F.Value, "yyyyMMdd 23:59") + "' ")
        sbXMLString.Append("madonhang='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(txtdonhang_F.Text) + "' ")
        sbXMLString.Append("makhach='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("khachhang='" + ReplaceTextXML(txtkhachhang_F.Text) + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang_F.Text) + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML(txtloaihang_F.Text) + "' ")
        sbXMLString.Append("mamau='" + ReplaceTextXML(txtmamau_F.Text) + "' ")
        sbXMLString.Append("tenmau='" + ReplaceTextXML(txtmau_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlDonHang_LenhSanXuat_GetData_2021]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socay_khomoc", "tongsome", "socay", "sokg", "somet", "tongsome_khsx", "socay_khsx", "sokg_khsx", "somet_khsx",
        "tongsome_phanme", "socay_phanme", "sokg_phanme", "somet_phanme"}
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
        Dim st As String = "<div align=""center"">" & "<font color=""blue"">{0}</font><br/>" & "<font color=""black"">{1}</font>" & "</div>"
        For x As Integer = 0 To _array_column.Length - 1
            If columns.Contains(_array_column(x)) = True Then
                With panel.Columns(_array_column(x))
                    .EnableHeaderMarkup = True
                    Dim stHeaderText As String = .HeaderText 'clsDev.Show_1Column(_array_column(x))
                    Dim stValue As Decimal = _array_value(x)
                    .HeaderText = String.Format(st, stHeaderText, FormatNumber(stValue, _intFormatText))
                End With
            End If
        Next
        'lblRow.Text = "T.Số: " & panel.Rows.Count
    End Sub

    Private Sub UpdateShowALLRows(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        Dim _chon_mau As String = String.Empty '
        Dim sColName_1 As String = String.Empty, sColName_2 As String = String.Empty
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
                        sColName_1 = "tongsome_khsx"
                        sColName_2 = "tongsome_khsx"
                        If ExistsColumnGridPanel(panel, sColName_1) = True AndAlso ExistsColumnGridPanel(panel, sColName_2) = True Then
                            If CInt(row.Cells(sColName_1).Value) = 0 Then
                                row.Cells(sColName_1).CellStyles.Default.Background.Color1 = Color.Red
                            ElseIf CInt(row.Cells(sColName_1).Value) > 0 AndAlso CInt(row.Cells(sColName_2).Value) <> CInt(row.Cells(sColName_1).Value) Then
                                row.Cells(sColName_1).CellStyles.Default.Background.Color1 = Color.Orange
                            Else
                                row.Cells(sColName_1).CellStyles.Default.Background.Color1 = Color.Empty
                            End If
                        End If
                        '--
                        sColName_1 = "socay_khomoc"
                        sColName_2 = "socay"
                        If ExistsColumnGridPanel(panel, sColName_1) = True AndAlso ExistsColumnGridPanel(panel, sColName_2) = True Then
                            If CInt(row.Cells(sColName_1).Value) = 0 Then
                                row.Cells(sColName_1).CellStyles.Default.Background.Color1 = Color.Red
                            ElseIf CInt(row.Cells(sColName_1).Value) > 0 AndAlso CInt(row.Cells(sColName_2).Value) <> CInt(row.Cells(sColName_1).Value) Then
                                row.Cells(sColName_1).CellStyles.Default.Background.Color1 = Color.Orange
                            Else
                                row.Cells(sColName_1).CellStyles.Default.Background.Color1 = Color.Empty
                            End If
                        End If
                        '--
                        '///
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
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '--
        _stName = "Theo_MaMau_Khach"
        _stHeadText = "Mã Màu (Yêu Cầu)"
        _stCol1 = "mamau_khach"
        _stCol2 = "tenmau_khach"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGreen))
        End If
        '--
        _stName = "Theo_MaMau_SongThuy"
        _stHeadText = "Mã Màu (ST)"
        _stCol1 = "mamau"
        _stCol2 = "tenmau"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGray))
        End If
        '--
        _stName = "Theo_YeuCau"
        _stHeadText = "Yêu Cầu"
        _stCol1 = "socay_khomoc"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            columns(_stCol1).HeaderText = "T.Cây Mộc"
            columns("socay").HeaderText = "T.Cây Đ.Hàng"
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGreen))
        End If
        '/
        _stName = "Theo_TongSoMe"
        _stHeadText = "Tổng Số Mẻ"
        _stCol1 = "tongsome"
        _stCol2 = "tongsome_phanme"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            columns(_stCol1).HeaderText = "T.Mẻ Đ.Hàng"
            columns("tongsome_khsx").HeaderText = "T.Mẻ KHSX"
            columns(_stCol2).HeaderText = "T.Mẻ Có Mộc"
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGray))
        End If
        '--
        _stName = "Theo_TaoMe"
        _stHeadText = "KHSX"
        _stCol1 = "socay_khsx"
        _stCol2 = "somet_khsx"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGreen))
        End If
        '--
        _stName = "Theo_PhanMe"
        _stHeadText = "Phân Mẻ"
        _stCol1 = "socay_phanme"
        _stCol2 = "somet_phanme"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("st_ngaytao"), panel.Columns("donhang"),
             panel.Columns("intnhomhang")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirDescAscAsc(sortCols))
        End If
        '//

        tpress.Enabled = True
    End Sub
    Public Function GetSortDirDescAscAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Ascending, SortDirection)})
    End Function

#Region "SuperGridControl1GetGroupDetailRows"

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

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdonhang_F.KeyDown,
            txtmahang_F.KeyDown, txtloaihang_F.KeyDown, txtkhachhang_F.KeyDown, txtmamau_F.KeyDown, txtmau_F.KeyDown, txtmame_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_chung()
        End If
    End Sub

#Region "EXECUTE -DELETE"

    Private Sub ShowModalForm_DonHang()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_DonHang))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmDonHang_input
                .Size = New Size(Me.Width * 0.95, Me.Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_chung()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub

    Private Sub ThemMoi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            _donhang_status = 1
            ShowModalForm_DonHang()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaoChep(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Try
            _donhang_status = 3
            ShowModalForm_DonHang()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChinhSua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Try
            If dgvr Is Nothing Then
                MessageBox.Show("Xin vui lòng chọn chứng từ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                _donhang_status = 2
                ShowModalForm_DonHang()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("donhang_id").Value.ToString
        Dim Code As String = dgvr.Cells("mahang").Value.ToString
        Dim CodeName As String = dgvr.Cells("donhang").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Hàng: " & Code _
                        & vbCrLf & vbCrLf & " - Đơn Hàng: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("donhang_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[VpsXmlDonHang_UpSet_2021]", sbXMLString.ToString, "delete")
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
    Private Sub btTim_Click(sender As Object, e As EventArgs) Handles btTim.Click
        Call Filterdata_chung()
    End Sub


#Region "EXECUTE -DELETE"

    Private Sub ShowModalForm_LenhSanXuat_Test()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_LenhSanXuat_Test))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmDonHang_LenhSanXuat_TaoMe
                .Size = New Size(Form1.Width * 0.95, Form1.Height * 0.9)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_chung()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub

    Private Sub BtnMenu_LenhSanXuat_Lick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenu_LenhSanXuat.Click
        Try
            _donhang_status = 10
            Dim panel As GridPanel = Super_Dgv.PrimaryGrid
            Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
            Try
                If dgvr Is Nothing Then
                    MessageBox.Show("Xin vui lòng chọn chứng từ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    frmDonHang_LenhSanXuat_TaoMe.DonHang = dgvr.Cells("donhang").Value.ToString
                    ShowModalForm_LenhSanXuat()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ShowModalForm_LenhSanXuat()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_LenhSanXuat))
        Else

            Dim frmCollection = System.Windows.Forms.Application.OpenForms
            If frmCollection.OfType(Of frmDonHang_LenhSanXuat_TaoMe).Any Then
                frmCollection.Item("frmDonHang_LenhSanXuat_TaoMe").Activate()
            Else
                With frmDonHang_LenhSanXuat_TaoMe
                    .Size = New Size(Form1.Width * 0.95, Form1.Height * 0.9)
                    .Show()
                End With
            End If
        End If
    End Sub

#End Region
#Region "MA MAU"
    Private Sub txtmamau_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmamau.KeyDown
        _bln_mamau = True
        If _bln_mamau = True Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                DgvData.Focus()
            End If
        End If
    End Sub

    Private Sub txtmamau_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmamau.TextChanged
        If _bln_mamau = True Then
            Dim txt As TextBox = CType(sender, TextBox)
            Dim pnPopup As Panel = PnPopup_List
            pnPopup.Controls.Add(DgvData)
            'Me.Controls.Add(pnPopup)

            AddHandler DgvData.CellClick, AddressOf DgvMaMau_CellClick
            AddHandler DgvData.KeyDown, AddressOf DgvMaMau_KeyDown

            If Len(txt.Text) > 0 Then
                VpsList_Menu(txt.Text, "[VpsXmlList_MaMau_UpSet]", "select", DgvData)
                '// 
                Dim ucDscreenCoords = txt.PointToScreen(New Point(0, 0))
                Dim ucDclientCoordsRelativeToA = GP_Form_CapNhat_MaMau.PointToClient(ucDscreenCoords)
                pnPopup.Location = New Point(ucDclientCoordsRelativeToA.X, ucDclientCoordsRelativeToA.Y + txt.Height)
                pnPopup.Size = New Size(CInt(GP_Form_CapNhat_MaMau.Width * 0.7), CInt(GP_Form_CapNhat_MaMau.Height * 0.7))
                pnPopup.Visible = True
                pnPopup.BringToFront()
                '--
            Else
                pnPopup.Visible = False
                _bln_mamau = False
                Lmamau_id = String.Empty
                txttenmau.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub DgvMaMau_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Call Load_Textbox_MaMau(sender)
    End Sub

    Private Sub DgvMaMau_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Load_Textbox_MaMau(sender)
        End If
    End Sub

    Private Sub Load_Textbox_MaMau(ByVal Dgv As DataGridView)
        With Dgv
            If _bln_mamau = True Then
                _bln_mamau = False
                Lmamau_id = ExistsColumn_Dgv(Dgv, _colMamau_ID, "").ToString
                txtmamau.Text = ExistsColumn_Dgv(Dgv, _colMamau, "").ToString
                txttenmau.Text = ExistsColumn_Dgv(Dgv, _colTenMau, "").ToString
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvMaMau_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvMaMau_KeyDown
        PnPopup_List.Visible = False
        btnCapNhat_MaMau.Focus()
    End Sub
#End Region

#Region "CAP NHAT MAU"
    Private Sub BtnThoat_Panel_Mamau_Click(sender As Object, e As EventArgs) Handles BtnThoat_Panel_Mamau.Click
        GP_Form_CapNhat_MaMau.Visible = False
    End Sub


    Private Sub btnMaMau_Changed_Click(sender As Object, e As EventArgs) Handles btnMaMau_Changed.Click
        Dim btn As ButtonItem = CType(sender, ButtonItem)
        With GP_Form_CapNhat_MaMau
            .Text = "CẬP NHẬT MÃ MÀU"
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
            .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
            .BringToFront()
            .Visible = True
        End With
    End Sub
    Private Sub btnCapNhat_MaMau_Click(sender As Object, e As EventArgs) Handles btnCapNhat_MaMau.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện thay đổi MÃ MÀU?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        If Len(Lmamau_id) = 0 Then Lmamau_id = "-"
        Call UpdateDetails_update_mamau(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlDonHang_UpSet_2021]", sbXMLString.ToString, "update_thaydoimau")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_chung()
    End Sub
    Private Sub UpdateDetails_update_mamau(ByVal rows As IEnumerable(Of GridElement))
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_mamau(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("donhang_id='" + ReplaceTextXML(row.Cells("donhang_id").Value.ToString.Trim) + "' ")
                    sbXMLString.Append("mamau_id='" + ReplaceTextXML(Lmamau_id) + "' ")
                    sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
                    '//
                    Dim _mota_chuyenmau As String = txttenmau_cu.Text.ToUpper & " -> " & txttenmau.Text.ToUpper & " [" & txtmamau.Text.ToUpper & "]"
                    sbXMLString.Append("mota_chuyenmau='" + ReplaceTextXML(_mota_chuyenmau) + "' ")
                    sbXMLString.Append("tenform='" + ReplaceTextXML(Me.Name.ToString) + "' ")
                    sbXMLString.Append("tencot='" + ReplaceTextXML(row.Cells("mahang").Value.ToString.Trim) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next
    End Sub
#End Region

#Region "EXCEL"
    Private Sub ToolStripButton_PhieuNhapKho_Click(sender As Object, e As EventArgs) Handles BtnExport_Excel.Click
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
            .strfileExcel_1 = "Report_DonHang.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "dtngaytao", "nhom_hoadon", "donhang", "madonhang", "benhnhan_khach", "mahang_khach", "loaihang_khach",
                "mamau_khach", "tenmau_khach", "mahang", "khachhang", "loaihang", "mamau", "tenmau",
               "khovai", "metkg", "dongia", "tongsome", "socay", "sokg", "somet", "tongsome_khsx", "socay_khsx", "sokg_khsx", "somet_khsx",
                "ghichu", "nguoitao", "dtngaysua"}
            ._rangeExcel_Text = {"I"}
            ._rangeExcel_number_0 = {"Q", "R", "S", "V", "W"}
            ._rangeExcel_number_1 = {"T", "U", "N", "O"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "AB"}
            ._GridArea = {"A", "AB"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"tongsome", "socay", "sokg", "somet", "tongsome_khsx", "socay_khsx", "sokg_khsx", "somet_khsx"}
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

#Region "EXCEL GIA CONG"
    Private Sub BtnDonDatHang_GiaCong_Click(sender As Object, e As EventArgs)
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
                Call ExportExcel_GiaCong()
                _IsPrint_PrintArea = False
                _IsPrint_Sum = False
                _IsPrint_GridArea = False
                _IsNotPrint_GroupName = False
            End If
            .Text = "Đơn Đặt Hàng Gia Công"
            .Enabled = True
        End With
    End Sub
    Private Sub ExportExcel_GiaCong()
        moClsExcel = New ClsExportExcel
        With moClsExcel
            .strfileExcel_1 = "Report_DonHang_Form.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "dtngaytao", "donhang", "madonhang", "mamau_khach", "tenmau_khach", "mahang", "khachhang", "loaihang", "mamau", "tenmau",
               "khovai", "metkg", "mame", "tongsome", "socay", "sokg", "somet"}
            ._rangeExcel_Text = {"L", "M"}
            ._rangeExcel_number_0 = {"O", "P"}
            ._rangeExcel_number_1 = {"Q", "R"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "R"}
            ._GridArea = {"A", "R"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"tongsome", "socay", "sokg", "somet"}
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