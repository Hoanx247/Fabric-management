Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text


Public Class Stock_Thanhpham_DonGiaVon
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    '//
    Private dtControler As KhoMocNhapKhoDAL
    Private _dt As KhoMocNhapKhoDTO
    Private dt_local As DataTable
    Private dt_kieuxuat As DataTable
    '--
    Dim dr2 As DataRow()
    Dim _filter As Boolean = False

    Dim _saveRowIndex As Integer = 0
    Dim _Column_Forzen_pos As Byte = 0
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"frmnamefull", "formgroup", "stt"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    '//
    Private _makh_id As String = String.Empty
    Private _mahang_id As String = String.Empty
    Private _mamau_id As String = String.Empty
    Private _mame_id As String = String.Empty
    Private _load_finish As Boolean = False
    Private _stMakytu_xuat As String = String.Empty
    Private _kieuxuat_id As String = String.Empty
    Private _chungtuxuat_id As String = String.Empty

#Region " Load du liệu lên bảng khi mở Form"


#Region "Private data"

    Private _BackColor As Background() = {New Background(Color.LightGreen),
        New Background(Color.FromArgb(&HE5, &HFF, &HDD)), New Background(Color.AliceBlue)}

    Private _MyFont As New Font("Time New Roman", 10, FontStyle.Bold Or FontStyle.Italic)
    Private _MyFont_normal As New Font("Time New Roman", 11, FontStyle.Regular)
#End Region

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Super_Dgv.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoMocNhapKhoDAL
        '// 
        '--
        dt_local = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '//
        dt_local = New DataTable
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


    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            'btnAdd.Enabled = IIf(_btAdd = True, True, False)
            'btnModify.Enabled = IIf(_btModify = True, True, False)
            'btnDelete.Enabled = IIf(_btDelete = True, True, False)

            Call Filterdata_Stored()
            _load_finish = True
            '_filter = True
            '----------------
        Else
            Me.Close()
        End If
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

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub


    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_ColumnFrozen.Click

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
        sbXMLString.Append("makhach='' ")
        sbXMLString.Append("khachhang='" + ReplaceTextXML(txtkhachhang_F.Text) + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang_F.Text) + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML(txtloaihang_F.Text) + "' ")
        sbXMLString.Append("mamau='" + ReplaceTextXML(txtmamau_F.Text) + "' ")
        sbXMLString.Append("tenmau='" + ReplaceTextXML(txtmau_F.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append("donhang='" + ReplaceTextXML(txtdonhang_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        If ChkTon_KhoHoanTat.CheckState = CheckState.Checked Then
            _dt = New KhoMocNhapKhoDTO("[VpsXmlKhoMoc_TonKho_ThanhPham_GiaVon_GetData]", sbXMLString.ToString, "select")
        Else
            _dt = New KhoMocNhapKhoDTO("[VpsXmlKhoMoc_TonKho_ThanhPham_GiaVon_GetData_all]", sbXMLString.ToString, "select")
        End If

        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"


    Dim _array_column As String() = {"socaymoc", "sokgmoc", "sometmoc", "socaytp", "sokgtp", "somettp", "socayton",
        "sokgton", "sometton", "thanhtien"}
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
        ''panel.AddGroup(panel.Columns("mucdich"))
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '--
        _stName = "Theo_Moc"
        _stHeadText = "Mộc"
        _stCol1 = "socaymoc"
        _stCol2 = "sometmoc"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_Tpham"
        _stHeadText = "T.Phẩm"
        _stCol1 = "socaytp"
        _stCol2 = "somettp"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_TonKho"
        _stHeadText = "Tồn Kho"
        _stCol1 = "socayton"
        _stCol2 = "sometton"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_HaoHut"
        _stHeadText = "H.Hụt (%)"
        _stCol1 = "haohut_kg"
        _stCol2 = "haohut_met"
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("dtngaynhap_chungtu"), panel.Columns("mahang"), panel.Columns("mame")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirDescDescAsc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDescDescAsc(sortCols))
        End If
        '//

        If _filter = False Then
            AddHandler tpress.Tick, AddressOf MyTickHandler
        End If
        tpress.Enabled = True
    End Sub

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
    Private Sub btTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call Filterdata_Stored()
    End Sub


    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdonhang_F.KeyDown,
         txtkhachhang_F.KeyDown, txtmahang_F.KeyDown, txtmamau_F.KeyDown, txtmau_F.KeyDown, txtmame_F.KeyDown, txtghichu_F.KeyDown,
         txtkhovai_F.KeyDown, txtmetKg_F.KeyDown, txtloaihang_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

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
            .strfileExcel_1 = "Report_NhatKy_Nhapkho_TP.xls"
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "dinhhinh", "kcs", "dtngaynhap_chungtu", "chungtunhap_khotp", "dtngayxuat", "chungtuxuat",
               "donhang", _colmahang, _colkhachhang, _colloaihang, "quicach", "khovai", "trongluong",
               _colMamau, _colTenMau, "tenmau_nhuom", "lvs", "loaimay", _colMame,
                "socaymoc", "sokgmoc", "sometmoc", "socaytp", "sokgtp", "somettp", "socayton", "sokgton", "sometton",
"haohut_kg", "haohut_met", "dongia", "thanhtien", "ghichu"}
            ._rangeExcel_Text = {}
            ._rangeExcel_number_0 = {"U", "X", "AA", "AF", "AG"}
            ._rangeExcel_number_1 = {"V", "W", "Y", "Z", "AB", "AC", "AD", "AE"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "AH"}
            ._GridArea = {"A", "AH"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socaymoc", "sokgmoc", "sometmoc", "socaytp", "sokgtp", "somettp", "socayton", "sokgton", "sometton",
"haohut_kg", "haohut_met", "thanhtien"}
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