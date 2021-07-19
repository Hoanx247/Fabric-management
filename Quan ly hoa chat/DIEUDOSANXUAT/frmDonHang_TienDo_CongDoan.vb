
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text
Public Class frmDonHang_TienDo_CongDoan
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
    Private _List_Column_Locked As String() = {}
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
    Private _Update_MaCongDoan_In As Boolean = False
    '//
    Private DgvData As DataGridView = New DataGridView()
    Private result As New List(Of String())
    '--
    Private _IsBusy As Boolean = False

    Private SoDongChon As Integer = 0
    Private _donhang As String = String.Empty
    Private _MaCongNghe As String = String.Empty
    '//
    Dim _List_MaCongNghe_DangThucHien As String() = {}
    Dim _List_MaCongNghe_DaThucHien As String() = {}
    Dim _List_Mame As String() = {}
    Dim strMame As List(Of String) = _List_Mame.ToList()
    Dim orderArray_May() As String = {}
    '//
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
    Public Property DonHang() As String
        Get
            Return _donhang
        End Get
        Set(ByVal value As String)
            _donhang = value
        End Set
    End Property
    Public Property MaCongNghe() As String
        Get
            Return _MaCongNghe
        End Get
        Set(ByVal value As String)
            _MaCongNghe = value
        End Set
    End Property

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

    Private Sub me_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        '//
        With dt1_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        With dt2_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With

        Me.dt1_F.Value = CDate(FormatDateTime(DateSerial(Now.Year, Now.Month, Now.Day - 7), DateFormat.ShortDate))
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))
        '///
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '//
        With Super_Dgv.PrimaryGrid
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = Tbool.True
            .GroupHeaderClickBehavior = GroupHeaderClickBehavior.ExpandCollapse
            .ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.SortAndReorder
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .Caption.Visible = True
        End With
        '//
        dt_local = New DataTable
        dt_congdoan = New DataTable
        dt_may = New DataTable
        '//
        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick

        AddHandler tpress.Tick, AddressOf MyTickHandler
        '//
        Load_CongDoan_Nhom()
        '//

        Load_MayNhuom()
    End Sub

#Region "FragrantComboBox"
    Private Sub Load_CongDoan_Nhom()
        dt_congdoan = VpsXmlList_Load("", "", "macongdoan")

    End Sub
    Private Sub Load_MayNhuom()
        'dt_may = ShellServices.VpsListMay("", "")
    End Sub
    Friend Class FragrantComboBox
        Inherits GridComboBoxExEditControl
        Public Sub New(ByVal orderArray As IEnumerable)
            DataSource = orderArray
        End Sub
    End Class

#End Region

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            ChkTonSanXuat.CheckState = CheckState.Checked
            Call Filterdata_Stored()
            _load_finish = True
            '----------------
        Else
            Me.Close()
        End If

    End Sub

#Region "SUPERGRID"
    Private Sub ShowModalForm_DonHang_MaMe()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_DonHang_MaMe))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmNhatKySanXuat_BanSanXuat
                .Size = New Size(Me.Width * 0.95, Me.Height)
                .StartPosition = FormStartPosition.CenterParent

                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    'Call Filterdata_chung()
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
            frmNhatKySanXuat_BanSanXuat.Mame = Lmame
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
            '///
            If dgvr IsNot Nothing Then
                Lmame = dgvr.Cells("mame").FormattedValue.ToString
                LMaMe_01 = dgvr.Cells("mame_01").FormattedValue.ToString
                Ldonhang = dgvr.Cells("donhang").FormattedValue.ToString
                '//
                Lmahang = dgvr.Cells("mahang").FormattedValue.ToString
                LLoaihang = dgvr.Cells("loaihang").FormattedValue.ToString
                Lkhovai = dgvr.Cells("khovai").FormattedValue.ToString & " cm"
                Lmetkg = dgvr.Cells("metkg").FormattedValue.ToString & " g/m2)"
                '///
                LMaMau = dgvr.Cells("mamau").FormattedValue.ToString
                LTenmau = dgvr.Cells("tenmau").FormattedValue.ToString
                LMaCongNghe = dgvr.Cells("macongnghe_all").FormattedValue.ToString
                '//
                'LSophieu_LKT = dgvr.Cells("sophieu_loikythuat").FormattedValue.ToString
                'LCongdoan_LKT = dgvr.Cells("congdoan_loikythuat").FormattedValue.ToString
                'LGhiChu_LKT = dgvr.Cells("ghichu_loikythuat").FormattedValue.ToString
                '//
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
                panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ HÀNG: ", Lmahang.ToUpper & " - " & LLoaihang.ToUpper)
                panel.Footer.Text &= String.Format(stinfo, "+ MÃ MÀU: ", LMaMau.ToUpper & " - " & LTenmau.ToUpper & " || ")
                panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ CN: ", LMaCongNghe)
                panel.Footer.Text &= String.Format(stinfo, "+ MẺ: ",
                                   Lmame.ToUpper & " - " & LMaMe_01.ToUpper)
                panel.Footer.Text &= String.Format(stinfo, "+ PHIẾU LKT: ",
                              LSophieu_LKT.ToUpper & " - " & LCongdoan_LKT.ToUpper & " - " & LGhiChu_LKT.ToUpper)

            End If
        End If
        _saveRowIndex = e.GridCell.RowIndex

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
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        If ChkTonSanXuat.CheckState = CheckState.Checked Then
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_SanXuatDoDang]", sbXMLString.ToString, "tonsanxuat")
        Else
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_SanXuatDoDang_TheoNgay]", sbXMLString.ToString, "select")
        End If

        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '//
        '//
        If dt_local IsNot Nothing Then
            'Dim dv As DataView = sortedDT.DefaultView
            'dv.Sort = "hoanthanh asc,mamay asc,rid asc"
            'dt_local = dv.ToTable()
            Update_Datatable()

        End If

        '//
        IsBusy = False
        Me.ResumeLayout()
    End Sub
    Private Sub Update_Datatable()
        dt_local.Columns("macongnghe_all").ReadOnly = False
        dt_local.Columns("thoigiantre_sanxuat").ReadOnly = False
        Dim _StartIndex As Integer = 0
        Dim _sValue1 As String = String.Empty
        Dim _sValue2 As String = String.Empty
        Dim _sValue3 As String = String.Empty
        Dim _MaCongNghe_all As String = String.Empty
        Dim _MaCongNghe_dangthuchien As String = String.Empty
        Dim _MaCongNghe_dathuchien As String = String.Empty
        For Each row As DataRow In dt_local.Rows
            If Len(row.Item("congdoan_dangthuchien").ToString) = 0 AndAlso IsDBNull(row.Item("thoigianra_max")) = False Then
                Dim myMinutes As Long = DateDiff(DateInterval.Minute, row.Item("thoigianra_max"), _TimeServer)
                row.Item("thoigiantre_sanxuat") = (myMinutes / 60)
            End If
        Next
        dt_local.AcceptChanges()
        '//
        Dim dataSource As Object = Nothing
        Dim rows() As DataRow = Nothing
        rows = dt_local.Select
        dataSource = rows.CopyToDataTable()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        panel.DataSource = dataSource 'New DataView(dt_local, "", "", DataViewRowState.CurrentRows)
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socay", "sokg", "somet", "thanhtien"}
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

        Dim stInfo As String = "<div>" & "<b><font size=""11""><font color=""blue"">{0}</font></font></b>" ' MA MAY
        stInfo &= "<font size=""8""><font color=""Black""> {1} </font></font>" & "</div>" 'qui cahc
        Dim st As String = "<div align=""center"">" & "<font color=""red"">{0}</font><br/>" & "<font color=""green"">{1}</font>" & "</div>"
        '////
        Super_Dgv.BeginUpdate()

        For Each item As GridElement In rows
            If _blnPress = False Then Exit For
            If item.Visible = True Then

                Dim group As GridGroup = TryCast(item, GridGroup)
                If group IsNot Nothing Then
                    UpdateShowALLRows(group.Rows)
                Else
                    Dim row As GridRow = TryCast(item, GridRow)
                    If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                        '//
                        If Len(row.Cells("macongnghe_all").Value) = 0 Then
                            row.RowStyles.Default.RowHeaderStyle.Background.Color1 = Color.Red
                        Else
                            row.RowStyles.Default.RowHeaderStyle.Background.Color1 = Color.Empty
                        End If
                        '///
                        If CBool(row.Cells("ismenhuom_chuyenmau").Value) = True Then
                            row.Cells("ismenhuom_chuyenmau").CellStyles.Default.Background.Color1 = Color.Red
                        Else
                            row.Cells("ismenhuom_chuyenmau").CellStyles.Default.Background.Color1 = Color.Empty
                        End If
                        '//
                        '//
                        For x As Integer = 0 To _array_column.Length - 1
                            If _blnPress = False Then Exit For
                            If ExistsColumnGridPanel(panel, _array_column(x)) = True Then
                                If IsDBNull(_array_value(x)) = False Then
                                    _sValue = _array_value(x)
                                    If IsDBNull(row.Cells(_array_column(x)).Value) = False Then
                                        _sValue += row.Cells(_array_column(x)).Value
                                    End If
                                    _array_value.SetValue(_sValue, x)
                                End If

                            End If
                        Next
                    End If
                End If

            End If
        Next
        Super_Dgv.EndUpdate()
    End Sub


#End Region

    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '----
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '-----
        _stName = "Theo_DauKy"
        _stHeadText = "CĐ Hoàn Thành Cuối"
        _stCol1 = "congdoan_cuoicung"
        _stCol2 = "thoigiantre_sanxuat"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '//
        '----
        _stName = "Theo_PhanMe"
        _stHeadText = "CĐ Đang Thực Hiện"
        _stCol1 = "congdoan_dangthuchien"
        _stCol2 = "thoigian_dangthuchien"
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
        '//
        panel.AddGroup(panel.Columns("stt_congdoan"))
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mamau_khach"), panel.Columns("mame_ghep"), panel.Columns("intnhomhang")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        End If
        '//
        tpress.Enabled = True

    End Sub
    Public Function GetSortDirAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection),
            CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Descending, SortDirection)})
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
                '//
                Dim stInfo As String = "<b><font size=""12""><font color=""black""> CĐ: {0}    </font></font></b>" ' MA MAY
                stInfo &= "<b><font size=""12""><font color=""blue"">    [ {1} (Mẻ) ||  </font></font></b>" 'socay
                'stInfo &= "<b><font size=""12""><font color=""blue"">    {2} (Kg)  ]  </font></font></b>" 'sokg
                'stInfo &= "<b><font size=""14""><font color=""black"">{3} ] </font></font></b>"

                If e.GridGroup.Column.Name.ToString.ToUpper = "stt_congdoan".ToString.ToUpper Then
                    'e.GridGroup.GroupHeaderVisualStyles.Default.TextColor = Color.Blue
                    e.GridColumn.EnableGroupHeaderMarkup = True
                    'e.GridGroup.Text = String.Format(stInfo, e.GridGroup.GroupValue.ToString.ToUpper, _lsoluong)
                    e.GridGroup.Text = e.GridGroup.GroupValue.ToString.ToUpper & " - " & _lsoluong & " MẺ"
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
                detailRows.Add(row)
                e.DetailRows = detailRows
            End If
        End If
    End Sub

#End Region

#End Region
    Private Sub btTim_Click(sender As Object, e As EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub

    Private Sub ChkTonSanXuat_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTonSanXuat.CheckedChanged
        If ChkTonSanXuat.CheckState = CheckState.Unchecked Then
            dt1_F.Enabled = True
            dt2_F.Enabled = True
        Else
            dt1_F.Enabled = False
            dt2_F.Enabled = False
        End If
    End Sub

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
        txtmahang_F.KeyDown, txtloaihang_F.KeyDown, txtmamau_F.KeyDown,
        txtdonhang_F.KeyDown, txtmame_F.KeyDown, txtkhachhang_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            '//

            Call Filterdata_Stored()
        End If
    End Sub

#Region "EXCEL"
    Private Sub btnExcel_DonHang_GiaCong_Click(sender As Object, e As EventArgs) Handles btnExcel_DonHang_GiaCong.Click
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
            Dim dtExcel As DataTable = VpsXmlList_Load_Title("", "F010", "[VpsXmlList_InfoExcel_UpSet]", "select_id")
            If dtExcel.Rows.Count = 1 Then
                .strfolder_path = dtExcel.Rows(0).Item("folder_path")
                .strfileExcel_1 = dtExcel.Rows(0).Item("fileexcel")
            Else
                Exit Sub
            End If
            ._rangeExcel = "A11"
            ._Columns_1 = {"id", "donhang", "khachhang", "mahang", "loaihang", "mamau_khach", "mamau", "tenmau",
               "khovai", "metkg", "mame", "congdoan_cuoicung", "thoigiantre_sanxuat", "congdoan_dangthuchien",
                "socay", "sokg", "somet", "dongia_moc", "thanhtien", "ghichu"}
            ._rangeExcel_Text = {"I"}
            ._rangeExcel_number_0 = {"Q", "R"}
            ._rangeExcel_number_1 = {"O", "P"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
            ._rangeExcel_Date_Time = {}
            ._PrintArea = {"A", "S"}
            ._GridArea = {"A", "S"}
            '//Các Cột Tính Tổng
            ._Array_Cal = {"socay", "sokg", "somet", "thanhtien"}
        End With
        '//
        Call Load_TimeServer()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        _GdtNgayIn_1 = Format$(dt1_F.Value, "dd/MM/yyyy")
        _GdtNgayIn_2 = Format$(dt2_F.Value, "dd/MM/yyyy")
        '//
        GdongIn_NgayThangNam = 4
        GCellIn_NgayThangNam = "A"
        _GInsertRow = 0
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub
#End Region
End Class