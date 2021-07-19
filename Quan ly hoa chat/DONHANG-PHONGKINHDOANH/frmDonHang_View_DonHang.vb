Option Strict Off
Imports System
Imports System.Collections.Generic
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text

Public Class frmDonHang_View_DonHang
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
    Private _List_Column_Locked As String() = {"mamau_kh", "tenmau_kh", "mahang_khach", "loaihang_khach", "bennhan_khach", "khovai", "metkg", "ghichu"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Private _update_ok As Boolean = False
    Private _bln_mamau As Boolean = False
    Private Lmamau_id As String = String.Empty
    Private _donhang_id As String = String.Empty
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
    Private LListMame As String = String.Empty
    Private LSocay As Int16 = 0
    Private LSokg As Single = 0
    Private LSomet As Single = 0
    Private LLoaiDay As String = String.Empty
    Private LGhiChu As String = String.Empty
    Private _bln_donhang As Boolean = False
    Private _donhang As String = String.Empty
#Region " Load du liệu lên bảng khi mở Form"
    Public Property DonHang() As String
        Get
            Return _donhang
        End Get
        Set(ByVal value As String)
            _donhang = value
        End Set
    End Property
    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        Call clsDev.SaveColumn(Super_Dgv_TienDo.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()
        '--
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_local = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        Call clsDev.Format_Super_Dgv(Super_Dgv_TienDo, _MyFont_GridView - 1)
        '--
        With Super_Dgv
            .PrimaryGrid.GroupByRow.Visible = False
            .PrimaryGrid.Filter.Visible = False
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = Tbool.True
            '.GroupHeaderClickBehavior = GroupHeaderClickBehavior.ExpandCollapse
            '.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.SortAndReorder
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
        End With
        With Super_Dgv_TienDo
            .PrimaryGrid.GroupByRow.Visible = False
            .PrimaryGrid.Filter.Visible = False
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = Tbool.True
            '.GroupHeaderClickBehavior = GroupHeaderClickBehavior.ExpandCollapse
            '.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.SortAndReorder
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
        End With

        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        '--
        AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        '//
        AddHandler Super_Dgv_TienDo.DataBindingComplete, AddressOf Super_Dgv_TienDo_DataBindingComplete
        AddHandler Super_Dgv_TienDo.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows_TienDo
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler

        '//
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            'btnAdd.Enabled = CBool(IIf(_btAdd = True, True, False))
            'btnModify.Enabled = CBool(IIf(_btModify = True, True, False))
            'btnDelete.Enabled = CBool(IIf(_btDelete = True, True, False))
            Call Filterdata_chung()
            '----------------
            wait(100)
            '//
            Filterdata_TienDo_DonHang()
        Else
            Me.Close()
        End If
    End Sub

#End Region

#Region "SUPERGRID"
    Private Sub ShowModalForm_DonHang_MaMe()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_DonHang_MaMe))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmDonHang_MaMe
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
    Private Sub Super_Dgv_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellDoubleClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        'Try
        If dgvr IsNot Nothing AndAlso dgvr.IsDetailRow = False Then
            frmDonHang_MaMe.DonHang = Ldonhang
            ShowModalForm_DonHang_MaMe()
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
                '_donhang_id = dgvr.Cells("donhang_id").FormattedValue.ToString
                Ldonhang = dgvr.Cells("donhang").FormattedValue.ToString
                '//
                Lmahang = dgvr.Cells("mahang").FormattedValue.ToString
                LLoaihang = dgvr.Cells("loaihang").FormattedValue.ToString
                'Lmahang_khach = dgvr.Cells("mahang_khach").FormattedValue.ToString
                'Lloaihang_khach = dgvr.Cells("loaihang_khach").FormattedValue.ToString
                'Lkhovai = dgvr.Cells("khovai").FormattedValue.ToString & " cm"
                'Lmetkg = dgvr.Cells("metkg").FormattedValue.ToString & " g/m2)"
                '///
                'LMaMau = dgvr.Cells("mamau").FormattedValue.ToString
                'LTenmau = dgvr.Cells("tenmau").FormattedValue.ToString
                'LMaMau_khach = dgvr.Cells("mamau_khach").FormattedValue.ToString
                LTenmau_khach = dgvr.Cells("tenmau_khach").FormattedValue.ToString
                '//
                LGhiChu = dgvr.Cells("ghichu_ddsx").FormattedValue.ToString.Replace(vbCr, "").Replace(vbLf, "")
                LListMame = dgvr.Cells("mame").FormattedValue.ToString
                '//
                'Them <br/> để xuống dòng
                Dim stinfo As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<font size=""12""><font color=""Black""> {1} </font></font>"
                Dim stinfo_br As String = "<b><font size=""12""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo_br &= "<font size=""12""><font color=""Black""> {1} </font></font><br/>"
                '////
                Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                'panel.Footer.Text = String.Format(stinfo, "+ ĐƠN HÀNG: ", Ldonhang)
                'panel.Footer.Text &= String.Format(stinfo, "+ MÃ HÀNG (KHÁCH): ", Lmahang_khach & " - [" & Lloaihang_khach & "]")
                'panel.Footer.Text &= String.Format(stinfo, "+ (ST): ", Lmahang & " - [" & LLoaihang & "]")
                'panel.Footer.Text &= String.Format(stinfo_br, "+ Khổ: ", Lkhovai & " - [" & Lmetkg & "]")
                '//
                'panel.Footer.Text &= String.Format(stinfo, "+ MÃ MÀU (KHÁCH): ", LMaMau_khach & " - [" & LTenmau_khach & "]")
                'panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ MÀU (ST): ", LMaMau & " - [" & LTenmau & "]")
                '//
                'panel.Footer.Text &= String.Format(stinfo_br, "+ CHÚ Ý: ", LGhiChu)
                '//
                'panel.Footer.Text &= String.Format(stinfo_br, "+ MẺ: ", LListMame)
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
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        panel.FrozenColumnCount = _Column_Forzen_pos
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
        sbXMLString.Append("donhang='" + ReplaceTextXML(_donhang) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlDonHang_GetData_DonHang_2021]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"tongsome", "socay", "soluong", "sokg", "somet", "socay_khomoc", "sokg_khomoc", "somet_khomoc",
        "tongsome_khsx", "socay_khsx", "sokg_khsx", "somet_khsx", "socay_phanme", "sokg_phanme", "somet_phanme",
         "socay_thanhpham", "sokg_thanhpham", "somet_thanhpham",
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
        Dim st As String = "<div align=""center"">" & "<font color=""blue"">{0}</font><br/>" & "<font color=""black"">{1}</font>" & "</div>"
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
        'lblRow.Text = "T.Số: " & panel.Rows.Count
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
                        If CInt(row.Cells("tongsome_khsx").Value) = 0 Then
                            row.Cells("tongsome_khsx").CellStyles.Default.Background.Color1 = Color.Red
                        ElseIf CInt(row.Cells("tongsome_khsx").Value) > 0 AndAlso CInt(row.Cells("tongsome").Value) <> CInt(row.Cells("tongsome_khsx").Value) Then
                            row.Cells("tongsome_khsx").CellStyles.Default.Background.Color1 = Color.Orange
                        Else
                            row.Cells("tongsome_khsx").CellStyles.Default.Background.Color1 = Color.Empty
                        End If
                        '//
                        For x As Integer = 0 To _array_column.Length - 1
                            If _blnPress = False Then Exit For
                            If ExistsColumnGridPanel(panel, _array_column(x)) = True Then
                                _sValue = _array_value(x)
                                If IsDBNull(row.Cells(_array_column(x)).Value) = False Then
                                    _sValue += row.Cells(_array_column(x)).Value
                                End If

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
        panel.AddGroup(panel.Columns("loaihang"))
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '--
        _stName = "Theo_Mamau_khachhang"
        _stHeadText = "Mã Màu (Yêu Cầu)"
        _stCol1 = "mamau_khach"
        _stCol2 = "tenmau_khach"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If

        '--
        _stName = "Theo_YeuCau"
        _stHeadText = "Yêu Cầu"
        _stCol1 = "tongsome"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGreen))
        End If
        _stName = "Theo_KhoMoc"
        _stHeadText = "Kho Mộc"
        _stCol1 = "socay_khomoc"
        _stCol2 = "somet_khomoc"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGray))
        End If
        '--
        _stName = "Theo_TaoMe"
        _stHeadText = "KHSX"
        _stCol1 = "tongsome_khsx"
        _stCol2 = "somet_khsx"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightCyan))
        End If
        '--
        _stName = "Theo_PhanMe"
        _stHeadText = "Phân Mẻ"
        _stCol1 = "socay_phanme"
        _stCol2 = "somet_phanme"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGreen))
        End If

        '--
        _stName = "Theo_dinhhinh_tp"
        _stHeadText = "T.Phẩm"
        _stCol1 = "socay_thanhpham"
        _stCol2 = "somet_thanhpham"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_XuatHang"
        _stHeadText = "Xuất Hàng"
        _stCol1 = "socay_xuathang"
        _stCol2 = "somet_xuathang"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGreen))
        End If
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("intnhomhang"), panel.Columns("mahang"),
            panel.Columns("tenmau_khach")}
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
                Dim _GroupValue As String = e.GridGroup.GroupValue.ToString
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
                '//
                Dim _lsoluong As Decimal = clsDev.Total_Row(e.GridGroup)
                '//
                Dim stInfo As String = "<b><font size=""12""><font color=""black""> NỀN: {0}    </font></font></b>" ' MA MAY
                stInfo &= "<b><font size=""12""><font color=""blue"">    [ (Tổng Màu) {1}  ||  </font></font></b>" 'socay
                stInfo &= "<b><font size=""12""><font color=""RED"">    [ (Tổng Mẻ) {2}  ||  </font></font></b>" 'socay
                'stInfo &= "<b><font size=""12""><font color=""blue"">    {2} (Kg)  ]  </font></font></b>" 'sokg
                'stInfo &= "<b><font size=""14""><font color=""black"">{3} ] </font></font></b>"
                '///
                If e.GridGroup.Column.Name.ToString.ToUpper = "loaihang".ToString.ToUpper Then
                    e.GridColumn.EnableGroupHeaderMarkup = True
                    e.GridGroup.Text = String.Format(stInfo, e.GridGroup.GroupValue.ToString.ToUpper, _lsoluong, _Gnumber_group(0))
                    'e.GridGroup.Text = "NỀN: " & e.GridGroup.GroupValue.ToString.ToUpper
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
                'detailRows.Add(row)
                'e.DetailRows = detailRows
            End If
        End If
    End Sub

#End Region


#End Region

#Region "LOAD TIEN DO"
    Private Sub Filterdata_TienDo_DonHang()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(_donhang) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_TheoDoi_CongDoan_DonHang_2021]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv_TienDo.PrimaryGrid)

    End Sub
    Private Sub Super_Dgv_TienDo_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns

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
        panel.AddGroup(panel.Columns("macongdoan"))
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String


        '--
        _stName = "Theo_YeuCau"
        _stHeadText = "Yêu Cầu"
        _stCol1 = "tongsome"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGreen))
        End If
        _stName = "Theo_KhoMoc"
        _stHeadText = "Kho Mộc"
        _stCol1 = "socay_khomoc"
        _stCol2 = "somet_khomoc"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGray))
        End If

        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mahang"),
            panel.Columns("tenmau_khach")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirDescAscAsc_TienDo(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirDescAscAsc_TienDo(sortCols))
        End If
        '//

        'tpress.Enabled = True
    End Sub
    Public Function GetSortDirDescAscAsc_TienDo(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Ascending, SortDirection)})
    End Function
#Region "SuperGridControl1GetGroupDetailRows"


    Private Sub Super_Dgv_GroupHeader_Group_TienDo(ByVal rows As IEnumerable(Of GridElement))
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
                Super_Dgv_GroupHeader_Group_TienDo(group.Rows)
            End If
        Next
    End Sub

    <Obsolete>
    Private Sub SuperGridControl1GetGroupDetailRows_TienDo(ByVal sender As Object, ByVal e As GridGetGroupDetailRowsEventArgs)
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
                Dim _GroupValue As String = e.GridGroup.GroupValue.ToString
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
                '//
                Dim _lsoluong As Decimal = clsDev.Total_Row(e.GridGroup)
                '//
                Dim stInfo As String = "<b><font size=""12""><font color=""black""> NỀN: {0}    </font></font></b>" ' MA MAY
                stInfo &= "<b><font size=""12""><font color=""blue"">    [ (Tổng Màu) {1}  ||  </font></font></b>" 'socay
                stInfo &= "<b><font size=""12""><font color=""RED"">    [ (Tổng Mẻ) {2}  ||  </font></font></b>" 'socay
                'stInfo &= "<b><font size=""12""><font color=""blue"">    {2} (Kg)  ]  </font></font></b>" 'sokg
                'stInfo &= "<b><font size=""14""><font color=""black"">{3} ] </font></font></b>"
                '///
                If e.GridGroup.Column.Name.ToString.ToUpper = "loaihang".ToString.ToUpper Then
                    e.GridColumn.EnableGroupHeaderMarkup = True
                    e.GridGroup.Text = String.Format(stInfo, e.GridGroup.GroupValue.ToString.ToUpper, _lsoluong, _Gnumber_group(0))
                    'e.GridGroup.Text = "NỀN: " & e.GridGroup.GroupValue.ToString.ToUpper
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
                'detailRows.Add(row)
                'e.DetailRows = detailRows
            End If
        End If
    End Sub

#End Region

#End Region

#Region "EXCEL"
    Private Sub ToolStripButton_PhieuNhapKho_Click(sender As Object, e As EventArgs)
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
        '_GdtNgayIn_1 = Format$(dt1_F.Value, "dd/MM/yyyy")
        '_GdtNgayIn_2 = Format$(dt2_F.Value, "dd/MM/yyyy")
        '//
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub

#End Region

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Call Filterdata_chung()
        '//
        Call Filterdata_TienDo_DonHang()
    End Sub
End Class