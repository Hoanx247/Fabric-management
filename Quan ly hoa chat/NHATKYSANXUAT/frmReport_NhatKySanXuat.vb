Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text


Public Class frmReport_NhatKySanXuat
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim dt_congdoan As DataTable
    Dim dt_may As DataTable

    Dim _Load_Ok As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Dim _bln_mamau As Boolean = False, _bln_donhang As Boolean = False
    '--
    Dim ProgramPosition, cursorPoint As Point

    Dim _List_MameID As String() = {}
    Dim strList As List(Of String) = _List_MameID.ToList()
    '--
    Dim _List_CongDoanID As String() = {}
    Dim strCongDoanID As List(Of String) = _List_CongDoanID.ToList()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"phanloai_ngaydem", "ghichu"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Private _load_finish As Boolean = False
    Private Lmamay_id As String = String.Empty
    Dim dr2 As DataRow()
    Private SoDongChon As Integer = 0
    Dim _ColorPick As String = String.Empty
    '//
    Dim _mame_temp As String = String.Empty

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
        '//
        With Super_Dgv.PrimaryGrid
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = Tbool.True
            .GroupHeaderClickBehavior = GroupHeaderClickBehavior.ExpandCollapse
            .ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .Caption.Visible = True
            'Them <br/> để xuống dòng
            Dim stinfo As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo &= "<font size=""16""><font color=""Black""> {1} </font></font>"
            Dim stinfo_br As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo_br &= "<font size=""16""><font color=""RED""> {1} </font></font><br/>"
            '//
            '//
            .Caption.Text = String.Format(stinfo_br, "+ CA NGÀY: ", "7:00 - 19:00" & " || ")
            .Caption.Text &= String.Format(stinfo_br, "+ CA ĐÊM: ", "19:00 - 7:00" & " || ")
        End With
        '//
        dt_local = New DataTable
        dt_congdoan = New DataTable
        dt_may = New DataTable
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
        Me.dt1_F.Value = CDate(FormatDateTime(DateSerial(Now.Year, Now.Month, Now.Day - 15), DateFormat.ShortDate))
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))

        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '//
        Load_CongDoan_Nhom()

    End Sub
    Private Sub Load_CongDoan_Nhom()
        dt_congdoan = VpsXmlList_Load("", "", "nhommay")
        LoadDataToCombox(dt_congdoan, cboTencongdoan, "nhommay", True)
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call Filterdata_Stored()
        _load_finish = True
    End Sub

    Private Sub mnu_Select_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtxMnu_Select_ALL.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, True)
    End Sub

    Private Sub mnu_Remove_ALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtxMnuSelect_Remove.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call clsDev.UpdateDetails_Checked(panel.Rows, False)
    End Sub

    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = CByte(e.GridColumn.ColumnIndex)
            If e.GridColumn.ColumnIndex = 0 Then
                ShowContextMenu(CtxMnu_Select)
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
    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub


#End Region

#Region "THÔNG TIN CHUNG"
    Private Sub ClearColumns_Click(sender As Object, e As EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim intY As Int16 = 0
        'Super_Dgv.PrimaryGrid.SelectAll()
        Super_Dgv.PrimaryGrid.DetachDataSource(False)
        Dim _intCount As Int16 = panel.Columns.Count - 1

        Dim counter As Integer
        For counter = _intCount To 0 Step -1
            panel.Columns.Remove(Super_Dgv.PrimaryGrid.Columns(counter))
        Next
        panel.Dispose()
    End Sub
    Private Sub CircleProcess_Start()
        Me.SuspendLayout()
        With CircularProgress1
            .Location = New Point((Super_Dgv.Width / 2) - (.Width / 2), (Super_Dgv.Height / 2) - (.Height / 2))
            .IsRunning = True
            .Visible = True
        End With
        Me.ResumeLayout()
    End Sub

    Private Sub CircleProcess_Stop()

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
        sbXMLString.Append("dtngay1='" + Format$(dt1_F.Value, "MM/dd/yyyy 00:00") + "' ")
        sbXMLString.Append("dtngay2='" + Format$(dt2_F.Value, "MM/dd/yyyy 23:59") + "' ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(txtdonhang_F.Text) + "' ")
        sbXMLString.Append("khachhang='" + ReplaceTextXML(txtkhachhang_F.Text) + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang_F.Text) + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML(txtloaihang_F.Text) + "' ")
        sbXMLString.Append("mamau='" + ReplaceTextXML(txtmamau_F.Text) + "' ")
        sbXMLString.Append("tenmau='" + ReplaceTextXML(txtmau_F.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append("nhommay='" + ReplaceTextXML(cboTencongdoan.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlReport_MeNhuom_CongDoan_GetData_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '///
        '//
        Dim _condition As String = String.Empty
        Dim dataSource As Object = Nothing
        _condition = "nhommay like '" & cboTencongdoan.Text & "%'"
        '--
        Dim rows() As DataRow = Nothing
        If String.IsNullOrEmpty(_condition) = True Then
            rows = dt_local.Select
        Else
            rows = dt_local.Select(_condition)
        End If
        If rows.Count > 0 Then ' first check to see if the array has rows '
            dataSource = rows.CopyToDataTable() ' dt now exists and contains rows '
        Else
            dataSource = Nothing
        End If
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        panel.DataSource = dataSource
        '//
        '//
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()

    End Sub


#Region "SUM"

    Dim _array_column As String() = {"socay", "sokg", "somet"}
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
        'Dim st As String = "<div align=""center"">" & "<font color=""red"">{0}</font><br/>" & "<font color=""green"">{1}</font>" & "</div>"
        'For x As Integer = 0 To _array_column.Length - 1
        'If columns.Contains(_array_column(x)) = True Then
        'With panel.Columns(_array_column(x))
        '.EnableHeaderMarkup = True
        'Dim stHeaderText As String = clsDev.Show_1Column(_array_column(x))
        'Dim stValue As Decimal = _array_value(x)
        '.HeaderText = String.Format(st, stHeaderText, FormatNumber(stValue, _intFormatText))
        'End With
        'End If
        'Next
        lblRow.Text = "T.Số: " & panel.Rows.Count
    End Sub

    Private Sub UpdateShowALLRows(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        Dim _chon_mau As String = String.Empty
        Dim _colorhtml As String = String.Empty
        '////
        Dim _isSame As Int16 = 0
        _mame_temp = String.Empty
        Super_Dgv.SuspendLayout()
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
                        '//Mẻ
                        '//
                        '//Mẻ
                        If row.Cells("mame_ghep").Value.ToString = _mame_temp Then
                            row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                            row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                        Else
                            _mame_temp = row.Cells("mame_ghep").Value.ToString
                            If _isSame = 0 Then
                                _colorhtml = "#FFFFFF"
                                row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                            ElseIf _isSame = 1 Then
                                _colorhtml = "#D3D3D3"
                                row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                'ElseIf _isSame = 2 Then
                                '_colorhtml = "#FAF0E6"
                                'row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                'row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                            Else
                                _colorhtml = "#FFFFFF"
                                row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                _isSame = 0
                            End If
                            _isSame += 1
                        End If
                        'row.Cells("samegroup").Value = _isSame
                        '//
                        '///
                        If IsDBNull(row.Cells("chon_mau").Value) = False Then
                            If row.Cells("chon_mau").Value.ToString <> "-" Then
                                row.Cells("mamau").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
                                row.Cells("tenmau").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
                                row.Cells("nhommau").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
                                'row.RowStyles.Default.RowHeaderStyle.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value.ToString)
                            End If
                        End If

                        If ExistsColumnGridPanel(panel, "hieusuat") = True Then
                            'If CInt(row.Cells("hieusuat").Value) > CInt(row.Cells("dungsai_tre").Value) Then
                            'row.Cells("hieusuat").CellStyles.Default.Background.Color1 = Color.OrangeRed
                            'End If
                            'If CInt(row.Cells("hieusuat").Value) < CInt(row.Cells("dungsai_som").Value) Then
                            'row.Cells("hieusuat").CellStyles.Default.Background.Color1 = Color.Violet
                            'End If
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
        Super_Dgv.ResumeLayout()
    End Sub

#End Region

    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '//Ẩn Cột
        For Each item As GridElement In panel.Columns
            Dim column As GridColumn = TryCast(item, GridColumn)
            Dim _TFormat As String = String.Empty
            If column.Name.ToLower.Contains("_id") = True Then
                column.Visible = False
            End If
        Next item
        '//
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        '--
        _stName = "Theo_ThoiGianThucTe"
        _stHeadText = "Giờ Thực Tế"
        _stCol1 = "thoigianvao"
        _stCol2 = "thoigianra"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_soluong"
        _stHeadText = "Số Lượng"
        _stCol1 = "socay"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mahang"), panel.Columns("thutu"),
            panel.Columns("mame_ghep"), panel.Columns("socay")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscAscAscDesc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscAscAscDesc(sortCols))
        End If
        '//
        tpress.Enabled = True
    End Sub
    Public Function GetSortDirAscAscAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Descending, SortDirection)})
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
                If e.GridGroup.Column.Name.ToString.ToUpper = _colkhachhang.ToString.ToUpper Then
                    e.GridGroup.Text = "KHÁCH HÀNG: " & e.GridGroup.GroupValue.ToString.ToUpper
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

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
        txtmahang_F.KeyDown, txtloaihang_F.KeyDown, txtmamau_F.KeyDown,
        txtdonhang_F.KeyDown, txtmame_F.KeyDown, txtkhachhang_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub


    Private Sub btnSelect_Day_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect_Day.Click
        'ClearColumns_Click(Nothing, Nothing)
        Call Filterdata_Stored()
    End Sub

    Private Sub cboTencongdoan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTencongdoan.SelectedIndexChanged
        If _load_finish = True Then
            Call Filterdata_Stored()
        End If

    End Sub

#Region "EXCEL"
    Private Sub ToolStripButton_PhieuNhapKho_Click(sender As Object, e As EventArgs) Handles btnInLenh_SX.Click
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
                _IsPrint_Sum = False
                _IsPrint_GridArea = True
                _IsNotPrint_GroupName = False
                _GUseConditionalFormatting = False
                _GInsertRow = 2
                '//
                Call ExportExcel()
                '//
                _GUseConditionalFormatting = False
                _IsPrint_PrintArea = False
                _IsPrint_Sum = False
                _IsPrint_GridArea = False
                _IsNotPrint_GroupName = False
                _GInsertRow = 0
            End If
            .Text = "Xuất Excel"
            .Enabled = True
        End With
    End Sub
    Private Sub ExportExcel()
        moClsExcel = New ClsExportExcel
        With moClsExcel
            .strfileExcel_1 = "NKSX_DINHHINH_v2.21.xlsx"
            ._rangeExcel = "A9"
            ._Columns_1 = {"id", "mamay", "thutu_sanxuat", "mahang", "loaihang", "macongdoan",
               "tenmau", "mamau", "phanloai_ngaydem", "mame",
               "socay", "sokg", "ghichu", "mame_ghep"}
            ._rangeExcel_Text = {}
            ._rangeExcel_number_0 = {"L"}
            ._rangeExcel_number_1 = {"M", "N"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "N"}
            ._GridArea = {"A", "N"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socay", "sokg"}
        End With
        '//
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _GdtNgayIn_1 = Format$(dt1_F.Value, "dd/MM/yyyy")
        _GdtNgayIn_2 = String.Empty
        '//
        '//
        GdongIn_NgayThangNam = 1
        GCellIn_NgayThangNam = "F"
        _GInsertRow = 0
        _GChungtu_kemtheo = "PHÂN XƯỞNG " & cboTencongdoan.Text.ToUpper
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub

#End Region

End Class