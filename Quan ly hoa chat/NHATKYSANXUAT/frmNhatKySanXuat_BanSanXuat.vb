Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text


Public Class frmNhatKySanXuat_BanSanXuat
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
    Private LListMame_all As String = String.Empty
    Private Lmame As String = String.Empty
    Private Lmame_tranfer As String = String.Empty
    Public Property Mame() As String
        Get
            Return Lmame_tranfer
        End Get
        Set(ByVal value As String)
            Lmame_tranfer = value
        End Set
    End Property

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
        '//
        Me.DialogResult = DialogResult.OK
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
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView)
        '//
        With Super_Dgv.PrimaryGrid
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = Tbool.True
            .GroupHeaderClickBehavior = GroupHeaderClickBehavior.ExpandCollapse
            .ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.Select
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            '.Caption.Visible = True
            .MinRowHeight = 32
            .DefaultRowHeight = 32

        End With
        '//
        dt_local = New DataTable
        dt_congdoan = New DataTable
        dt_may = New DataTable

        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '//

        'ChkMeChuaSanXuat.Checked = True
        txtmame_F.Text = Lmame_tranfer
        txtmame_F.Focus()
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call Filterdata_Stored()
        txtmame_F.Focus()
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
        ElseIf e.MouseEventArgs.Button = MouseButtons.Left Then

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
        '//
        If dgvr IsNot Nothing Then
            'Lmame_id = dgvr.Cells("mame_id").FormattedValue.ToString
            Lmame = dgvr.Cells("mame").FormattedValue.ToString
            'LMaMe_01 = dgvr.Cells("mame_01").FormattedValue.ToString
            'Ldonhang = dgvr.Cells("donhang").FormattedValue.ToString
            '//
            'Lmahang = dgvr.Cells("mahang").FormattedValue.ToString
            ' LLoaihang = dgvr.Cells("loaihang").FormattedValue.ToString
            'Lkhovai = dgvr.Cells("khovai").FormattedValue.ToString & " cm"
            'Lmetkg = dgvr.Cells("metkg").FormattedValue.ToString & " g/m2)"
            '//
            'LGhiChu = dgvr.Cells("ghichu_thanhpham").FormattedValue.ToString & " g/m2)"
            '///
            'LMaMau = dgvr.Cells("mamau").FormattedValue.ToString
            'LTenmau = dgvr.Cells("tenmau").FormattedValue.ToString
            'LMaCongNghe = dgvr.Cells("macongnghe").FormattedValue.ToString
            LListMame_all = dgvr.Cells("mame_all").FormattedValue.ToString
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
            panel.Footer.Text = String.Format(stinfo, "+ MẺ: ",
                                   Lmame.ToUpper & " - " & " [Mẻ Ghép: " & LListMame_all & "] ")
            'panel.Footer.Text &= String.Format(stinfo_br, "+ GHI CHÚ: ", LGhiChu)
            'panel.Footer.Text &= String.Format(stinfo, "+ PHIẾU LKT: ",
            'LSophieu_LKT.ToUpper & " - " & LCongdoan_LKT.ToUpper & " - " & LGhiChu_LKT.ToUpper)
        Else
            ' LMaMe_01 = String.Empty
            ' Ldonhang = String.Empty
            'Lmame = String.Empty
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
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_CongDoan_GetData_2021_BanSanXuat]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '///
        '//
        Dim _condition As String = String.Empty
        Dim dataSource As Object = Nothing
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
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '//

        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        '--
        _stName = "Theo_CongDoan"
        _stHeadText = "Công Đoạn"
        _stCol1 = "macongdoan"
        _stCol2 = "nhommay"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If

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
        _stHeadText = "Mộc"
        _stCol1 = "socay"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_sanXuat"
        _stHeadText = "Ghép"
        _stCol1 = "tongcay"
        _stCol2 = "tongmet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        '//
        'If _List_ColumnGrouped.Length > 0 Then
        'For Each _ColumnGrouped As String In _List_ColumnGrouped
        'panel.AddGroup(panel.Columns(_ColumnGrouped))
        'Next
        'Else
        panel.AddGroup(panel.Columns("mame"))
        '//
        _List_group = {}
        _List_group = _List_group.Concat({txtmame_F.Text}).ToArray
        '//

        'End If
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mame"), panel.Columns("thutu")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscAscAscDesc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscAscAscDesc(sortCols))
        End If
        '//
        tpress.Enabled = True
    End Sub
    Public Function GetSortDirAscAscAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Ascending, SortDirection)})
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
                '//
                Dim _lsoluong As Decimal = clsDev.Total_Row(e.GridGroup)
                '//
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
                Dim stInfo As String = "<b><font size=""12""><font color=""black""> {0}    </font></font></b>" ' MA MAY
                stInfo &= "<b><font size=""12""><font color=""blue"">    [ {1} (Công Đoạn) ||  </font></font></b>" 'socay
                'stInfo &= "<b><font size=""12""><font color=""blue"">    {2} (Kg)  ]  </font></font></b>" 'sokg
                'stInfo &= "<b><font size=""14""><font color=""black"">{3} ] </font></font></b>"

                If e.GridGroup.Column.Name.ToString.ToUpper = "mame".ToString.ToUpper Then
                    'e.GridGroup.GroupHeaderVisualStyles.Default.TextColor = Color.Blue
                    e.GridColumn.EnableGroupHeaderMarkup = True
                    e.GridGroup.Text = String.Format(stInfo, e.GridGroup.GroupValue.ToString.ToUpper, _lsoluong)
                    'e.GridGroup.GroupHeaderVisualStyles.Default.Background.Color1 = Color.LawnGreen
                    'row.Cells(0).Value = Nothing
                End If
                '//

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

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
          txtmame_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub


    Private Sub btnSelect_Day_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ClearColumns_Click(Nothing, Nothing)
        Call Filterdata_Stored()
    End Sub

    Private Sub cboTencongdoan_SelectedIndexChanged(sender As Object, e As EventArgs)
        If _load_finish = True Then
            Call Filterdata_Stored()
        End If

    End Sub

#Region "EXCEL"
    Private Sub ToolStripButton_PhieuNhapKho_Click(sender As Object, e As EventArgs)
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
                _IsNotPrint_GroupName = True
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
            .strfileExcel_1 = "Lenhsanxuat_all.xls"
            ._rangeExcel = "A8"
            ._Columns_1 = {"id", "mamay", "thutu_sanxuat", "-", "mahang", "loaihang", "macongdoan",
               "tenmau", "mamau", "phanloai_ngaydem", "mame",
               "socay", "sokg", "tongcay", "tongkg", "ghichu", "mame_ghep"}
            ._rangeExcel_Text = {}
            ._rangeExcel_number_0 = {"L"}
            ._rangeExcel_number_1 = {"M", "N"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "Q"}
            ._GridArea = {"A", "Q"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socay", "sokg", "tongcay", "tongkg"}
        End With
        '//
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        '_GdtNgayIn_1 = Format$(dt1_F.Value, "dd/MM/yyyy"       
        '_GdtNgayIn_1 = Format$(dt1_F.Value, "dd/MM/yyyy")

        '_GdtNgayIn_2 = Format$(dt2_F.Value, "dd/MM/yyyy")
        '//
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub

#End Region


#Region "AP THIET BI"
    Private Sub ButtonItem_HuyXacNhan_Click(sender As Object, e As EventArgs) Handles ButtonItem_HuyXacNhan.Click
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_HuyCongDoan(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet_2021]", sbXMLString.ToString, "update_huycongdoan")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
        End If

    End Sub
    Private Sub UpdateDetails_HuyCongDoan(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim _mamay_id As String = String.Empty
        Dim _congdoan_id As String = String.Empty
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_HuyCongDoan(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                    sbXMLString.Append("congdoan_id='" + ReplaceTextXML(row.Cells("congdoan_id").Value.ToString) + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

    Private Sub btnClear_Mame_Click(sender As Object, e As EventArgs) Handles btnClear_Mame.Click
        txtmame_F.Text = String.Empty
        txtmame_F.Focus()
    End Sub


#End Region

#Region "HOAN THANH"
    Private Sub ButtonItem_HoanThanh_Click(sender As Object, e As EventArgs) Handles ButtonItem_HoanThanh.Click
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_update_HoanThanh_CongDoan(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet_2021]", sbXMLString.ToString, "update_hoanthanh_congdoan_admin")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
        End If

    End Sub

    Private Sub ButtonX_Refresh_Click(sender As Object, e As EventArgs) Handles ButtonX_Refresh.Click
        Call Filterdata_Stored()
    End Sub



    Private Sub UpdateDetails_update_HoanThanh_CongDoan(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim _mamay_id As String = String.Empty
        Dim _congdoan_id As String = String.Empty
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_HoanThanh_CongDoan(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                    sbXMLString.Append("thoigianvao='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
                    sbXMLString.Append("thoigianra='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub


#End Region

    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Super_Dgv.KeyDown
        If e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Control Then
            Dim st As String
            st = Super_Dgv.PrimaryGrid.ActiveCell.Value.ToString
            System.Windows.Forms.Clipboard.SetText(st)
        End If
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub


#Region "XAC NHAN VAO RA"

    Private Sub ButtonItem_XacNhanGioRa_Click(sender As Object, e As EventArgs) Handles ButtonItem_XacNhanGioRa.Click
        Call Load_TimeServer()
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_update_ThucHien(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet_2021]", sbXMLString.ToString, "update_giora_dat")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
        End If
    End Sub



    Private Sub ButtonItem_XacNhanVao_Click(sender As Object, e As EventArgs) Handles ButtonItem_XacNhanVao.Click
        Call Load_TimeServer()
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_update_ThucHien(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet_2021]", sbXMLString.ToString, "update_giovao")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
        End If
    End Sub


    Private Sub UpdateDetails_update_ThucHien(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim _mamay_id As String = String.Empty
        Dim _congdoan_id As String = String.Empty
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_ThucHien(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                    sbXMLString.Append("nv_id='" + ReplaceTextXML("-") + "' ")
                    sbXMLString.Append("thoigianvao='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
                    sbXMLString.Append("thoigian='" + CNumber_system(15) + "' ")
                    sbXMLString.Append("thoigianra='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                    sbXMLString.Append("nhomloi_id='" + ReplaceTextXML("-") + "' ")
                    sbXMLString.Append("ketqua='" + CNumber_system(1) + "' ")
                    sbXMLString.Append("danhgia='" + ReplaceTextXML("") + "' ")
                    sbXMLString.Append("sophieu_loikythuat='" + ReplaceTextXML("") + "' ")
                    sbXMLString.Append("ghichu_loikythuat='" + ReplaceTextXML("") + "' ")
                    sbXMLString.Append("congdoan_loikythuat='" + ReplaceTextXML("") + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub

#End Region

#Region "HUY CONG DOAN ME LOI"
    Private Sub ButtonItem_XacNhan_HuyCongDoan_Click(sender As Object, e As EventArgs) Handles ButtonItem_XacNhan_HuyCongDoan.Click
        SoDongChon = 0
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call UpdateDetails_HuyCongDoan_MeLoi(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet_2021]", sbXMLString.ToString, "update_huycongdoan_meloi")
        If SoDongChon > 0 Then
            dtControler.UPSET_XML(_dt)
            '//
            Call Filterdata_Stored()
        End If

    End Sub
    Private Sub UpdateDetails_HuyCongDoan_MeLoi(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim _mamay_id As String = String.Empty
        Dim _congdoan_id As String = String.Empty
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_HuyCongDoan_MeLoi(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    SoDongChon += 1
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("maid='" + ReplaceTextXML(row.Cells("maid").Value.ToString) + "' ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                    sbXMLString.Append("thoigianvao='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
                    sbXMLString.Append("thoigianra='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub


#End Region
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
End Class