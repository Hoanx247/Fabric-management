Imports System
Imports System.Collections.Generic

Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Reflection
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Imports System.Net
Imports System.Text
Public Class frmPhieuLoiKyThuat
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim dt_kieunhap As DataTable

    Dim _List_MameID As String() = {}
    Dim strList As List(Of String) = _List_MameID.ToList()
    '--
    Dim _List_CongDoanID As String() = {}
    Dim strCongDoanID As List(Of String) = _List_CongDoanID.ToList()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"ghichu_thuchien_1"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    '--
    Dim _kieunhap_id As String
    Dim _stMakytu_Nhap As String
    Dim dr2 As DataRow()
    Dim _filter As Boolean = False
    Private _lbtn_command As SByte = 0

    Dim _intRows_ALL As Long = 0
    Dim _intColumns_ALL As Long = 0, _intGroup_count As Long = 0
    Dim _IntGroup_Column_Index As Byte = 0

    Dim _update_ok As Boolean = False, _Edit_Chungtu As Boolean = False
    Dim _bln_khachhang As Boolean = False, _bln_mahang As Boolean = False
    Dim _blnEdit As Boolean = False
    Private _mahang_id As String = String.Empty
    Private _donhang_id As String = String.Empty
    Private _chungtunhap_id As String = String.Empty
    Private _bln_donhang As Boolean = False
    '//
    Private DgvData As DataGridView = New DataGridView()
    '//
    Private Lsophieu As String = String.Empty
    Private LCongDoan As String = String.Empty
    Private Ldonhang As String = String.Empty
    Private Lmahang As String = String.Empty
    Private LKhachhang As String = String.Empty
    Private LLoaihang As String = String.Empty
    Private Lkhovai As String = String.Empty
    Private Lmetkg As String = String.Empty
    Private LMaMau As String = String.Empty
    Private LTenmau As String = String.Empty
    Private LMaCongNghe As String = String.Empty
    Private LGhichu As String = String.Empty
    Private Lmota As String = String.Empty
    Private LGhichu_donhang As String = String.Empty
    Private LMaMe As String = String.Empty
    Private LMaMe_Ghep As String = String.Empty
    Private LMaMe_All As String = String.Empty
    Private LSocay As Int16 = 0
    Private LSokg As Single = 0
    Private LSomet As Single = 0
    Private LBoPhan As String = String.Empty
    Private LNgayTao As String = String.Empty
#Region " Load du liệu lên bảng khi mở Form"

#Region "Private data"

    Private _BackColor As Background() = {New Background(Color.LightGreen),
        New Background(Color.FromArgb(&HE5, &HFF, &HDD)), New Background(Color.AliceBlue)}

    Private _MyFont As New Font("Time New Roman", 10, FontStyle.Bold Or FontStyle.Italic)
#End Region

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        Super_Dgv.Dispose()
        dt_local.Dispose()
        Super_Dgv.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        '--
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_local = New DataTable
        '--
        dt_kieunhap = New DataTable
        _kieunhap_id = ""

        With dt1_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        With dt2_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        Me.dt1_F.Value = CDate(FormatDateTime(DateSerial(Now.Year, Now.Month, Now.Day - 10), DateFormat.ShortDate))
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, CInt(Now.Day.ToString))
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--
        '--
        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick

        '--
        AddHandler btnAdd.Click, AddressOf ThemMoi
        'AddHandler CtxFunction_Add.Click, AddressOf ThemMoi
        'AddHandler btnCopy.Click, AddressOf SaoChep
        'AddHandler CtxFunction_Copy.Click, AddressOf SaoChep
        AddHandler btnModify.Click, AddressOf ChinhSua
        'AddHandler CtxFunction_Modify.Click, AddressOf ChinhSua
        'AddHandler btnDelete.Click, AddressOf Xoa
        AddHandler CtxMenu_Expand.Click, AddressOf Expand_SuperGrid
        AddHandler CtxMenu_Colapse.Click, AddressOf Collapse_SuperGrid
        '//
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler

        Me.ResumeLayout()
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            'btnAdd.Enabled = IIf(_btAdd = True, True, False)
            'btnModify.Enabled = IIf(_btModify = True, True, False)
            'btnDelete.Enabled = IIf(_btDelete = True, True, False)
            '----------

            Call Filterdata_Stored()

            _filter = True
            '----------------
            _blnEdit = False
        Else
            Me.Close()
        End If
    End Sub

#End Region


#Region "SUPERGRID"

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
                'ShowContextMenu(CtxMnuSelect)
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

        End If
        '_saveRowIndex = e.GridCell.RowIndex
        '//
        If dgvr IsNot Nothing Then
            Lsophieu = dgvr.Cells("sophieu").FormattedValue.ToString
            Ldonhang = dgvr.Cells("c_donhang").FormattedValue.ToString
            '//
            Lmahang = dgvr.Cells("c_mahang").FormattedValue.ToString
            LKhachhang = dgvr.Cells("c_khachhang").FormattedValue.ToString
            LLoaihang = dgvr.Cells("c_loaihang").FormattedValue.ToString
            'Lkhovai = dgvr.Cells("khovai").FormattedValue.ToString & " cm"
            'Lmetkg = dgvr.Cells("metkg").FormattedValue.ToString & " g/m2)"
            LMaMau = dgvr.Cells("c_mamau").FormattedValue.ToString
            LTenmau = dgvr.Cells("c_tenmau").FormattedValue.ToString
            '//
            LBoPhan = dgvr.Cells("c_bophan").FormattedValue.ToString
            LCongDoan = dgvr.Cells("c_congdoan").FormattedValue.ToString
            LGhichu = dgvr.Cells("c_ghichu").FormattedValue.ToString
            LMaMe = dgvr.Cells("c_mame").FormattedValue.ToString
            '//
            LSocay = dgvr.Cells("c_socay").Value
            '///
            Lmota = dgvr.Cells("c_mota").FormattedValue.ToString
            '///
            LNgayTao = dgvr.Cells("st_ngaytao").FormattedValue.ToString
            '//
            'Them <br/> để xuống dòng
            Dim stinfo As String = "<b><font size=""13""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo &= "<font size=""13""><font color=""Black""> {1} </font></font>"
            Dim stinfo_br As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
            stinfo_br &= "<font size=""13""><font color=""Blue""> {1} </font></font><br/>"
            '//

            Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
            '////
            panel.Footer.Text = String.Format(stinfo, "+ ĐƠN HÀNG: ", Ldonhang.ToUpper & " || ")
            panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ HÀNG: ", Lmahang.ToUpper & " - " & LLoaihang.ToUpper)
            panel.Footer.Text &= String.Format(stinfo_br, "+ GHI CHÚ: ", LGhichu)

        Else

        End If
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
        sbXMLString.Append("chungtu='" + ReplaceTextXML(txtchungtu_F.Text) + "' ")
        sbXMLString.Append("khachhang='" + ReplaceTextXML(txtkhachHang_F.Text) + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang_F.Text) + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML(txtloaihang_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")

        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_PhieuLoiKyThuat_Upset_2021]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)

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
        'lblRow.Text = "T.Số: " & panel.Rows.Count
    End Sub

    Private Sub UpdateShowALLRows(ByVal rows As IEnumerable(Of GridElement))
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        Dim _sValue As Decimal = 0
        Dim _chon_mau As String = String.Empty
        Dim _scolname As String = String.Empty
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
                        _scolname = "isluukhotam"
                        If ExistsColumnGridPanel(panel, _scolname) = True Then
                            If Convert.ToBoolean(row.Cells(_scolname).Value) = True Then
                                row.Cells(_scolname).CellStyles.Default.Background.Color1 = Color.Orange
                            Else
                                'row.RowStyles.Default.RowHeaderStyle.Background.Color1 = Color.Empty
                                row.Cells(_scolname).CellStyles.Default.Background.Color1 = Color.Empty
                            End If
                        End If
                        _scolname = "socay_tt"
                        If ExistsColumnGridPanel(panel, _scolname) = True Then
                            If row.Cells(_scolname).Value = 0 Then
                                row.Cells(_scolname).CellStyles.Default.Background.Color1 = Color.Red
                            ElseIf row.Cells(_scolname).Value > 0 AndAlso row.Cells("socay").Value > row.Cells(_scolname).Value Then
                                row.Cells("socay").CellStyles.Default.Background.Color1 = Color.Orange
                            ElseIf row.Cells(_scolname).Value > 0 AndAlso row.Cells("socay").Value < row.Cells(_scolname).Value Then
                                row.Cells(_scolname).CellStyles.Default.Background.Color1 = Color.Yellow
                            End If
                        End If
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
        'panel.AddGroup(panel.Columns("mucdich"))
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        '--
        _stName = "Theo_DauKy"
        _stHeadText = "Số Lượng"
        _stCol1 = "socay"
        _stCol2 = "somet"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_ThucNhap"
        _stHeadText = "Thực Nhập"
        _stCol1 = "socay_tt"
        _stCol2 = "somet_tt"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("st_ngaytao"), panel.Columns("sophieu")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        End If
        '//

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


    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmahang_F.KeyDown, txtloaihang_F.KeyDown, txtkhachHang_F.KeyDown, txtghichu_F.KeyDown, txtchungtu_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call Filterdata_Stored()
    End Sub

    Private Sub chk_tatca_CheckedChanged(sender As Object, e As EventArgs) Handles chk_tatca.CheckedChanged
        If chk_tatca.CheckState = CheckState.Checked Then
            dt1_F.Enabled = False
            dt2_F.Enabled = False
        Else
            dt1_F.Enabled = True
            dt2_F.Enabled = True
        End If
    End Sub
#Region "EXECUTE"
    Private Sub ShowModalForm_DonHang()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_DonHang))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmPhieuLoiKyThuat_Input
                .Size = New Size(Me.Width * 0.95, Me.Height)
                .StartPosition = FormStartPosition.CenterParent
                '//
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_Stored()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub
    Private Sub ThemMoi()
        _PhieuLKT_status = 1
        ShowModalForm_DonHang()
    End Sub

    Private Sub ChinhSua()

        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        'Try
        If dgvr Is Nothing Then
            MessageBox.Show("Xin vui lòng chọn dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmPhieuLoiKyThuat_Input.Chungtu = dgvr.Cells("sophieu").FormattedValue
        _PhieuLKT_status = 2
        ShowModalForm_DonHang()
    End Sub

    Private Sub SaoChep()
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("sophieu_id").Value.ToString
        Dim Code As String = dgvr.Cells("c_mahang").Value.ToString
        Dim CodeName As String = dgvr.Cells("sophieu").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Mã Hàng: " & Code _
                        & vbCrLf & vbCrLf & " - Số Phiếu: " & CodeName,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("sophieu_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_PhieuLoiKyThuat_Upset_2021]", sbXMLString.ToString, "delete")
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


#End Region

#Region "EXCEL"
    Private Sub btnExport_excel_Click(sender As Object, e As EventArgs) Handles btnExport_excel.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If Super_Dgv.PrimaryGrid.Rows.Count = 0 Then
            Exit Sub
        End If
        '--
        Dim btn As ToolStripButton = CType(sender, ToolStripButton)
        With btn
            .Text = "Xin Chờ..."
            .Enabled = False
            Call ExportExcel()
            .Text = "Xuất Excel"
            .Enabled = True
        End With
    End Sub
    Private Sub ExportExcel()
        moClsExcel = New ClsExportExcel
        With moClsExcel
            Dim dtExcel As DataTable = VpsXmlList_Load_Title("", "F005", "[VpsXmlList_InfoExcel_UpSet]", "select_id")
            If dtExcel.Rows.Count = 1 Then
                .strfolder_path = dtExcel.Rows(0).Item("folder_path")
                .strfileExcel_1 = dtExcel.Rows(0).Item("fileexcel")
            Else
                Exit Sub
            End If
            '.strfileExcel_1 = "BaoCaoPLKT.v1.21.xlsx"
            ._rangeExcel = "A9"
            ._Columns_1 = {"id", "st_ngaytao", "c_bophan", "sophieu", "c_donhang", "c_mahang", "c_loaihang",
               "c_mamau", "c_tenmau", "c_mame", "c_congdoan", "c_socay", "c_sokg", "c_mota"}
            ._rangeExcel_Text = {}
            ._rangeExcel_number_0 = {}
            ._rangeExcel_number_1 = {"M"}
            ._rangeExcel_number_2 = {}
            ._rangeExcel_Date = {"B"}
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
        _GdtNgayIn_2 = Format$(dt2_F.Value, "dd/MM/yyyy")
        '//
        _IsPrint_GridArea = True
        GdongIn_NgayThangNam = 4
        moClsExcel.ExportToExcelAsLocal(panel, Me.Name.ToString)
    End Sub



#End Region

#Region "EXCEL"
    Private Sub btnExport_PDF_Click(sender As Object, e As EventArgs) Handles btnExport_PDF.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If Super_Dgv.PrimaryGrid.Rows.Count = 0 Then
            Exit Sub
        End If
        '--
        Dim btn As ToolStripButton = CType(sender, ToolStripButton)
        With btn
            .Text = "Xin Chờ..."
            .Enabled = False
            '//Lay ID File Excel
            Dim LFileName As String = String.Empty
            Dim LFolder_Path As String = String.Empty
            Dim dtExcel As DataTable = VpsXmlList_Load_Title("", "F004", "[VpsXmlList_InfoExcel_UpSet]", "select_id")
            If dtExcel.Rows.Count = 1 Then
                LFolder_Path = dtExcel.Rows(0).Item("folder_path")
                LFileName = dtExcel.Rows(0).Item("fileexcel")
                Call Export_Excel_Chitiet(LFolder_Path, LFileName, True)
            Else
                LFolder_Path = String.Empty
                LFileName = String.Empty
            End If
            '//
            .Text = "In Phiếu"
            .Enabled = True
        End With
    End Sub
    Private Sub Export_Excel_Chitiet(ByVal strFolderPath As String, ByVal strSaveFilename As String, ByVal blnIsVisible As Boolean)
        Me.SuspendLayout()
        Dim strFileName As String = strFolderPath & "\" & strSaveFilename
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

        objExcel.visible = False
        objExcel.DisplayAlerts = True
        'objExcel.PrintCommunication = False

        Try
            objWorkbook = objExcel.Workbooks.Add(strFileName)
            objSheet = objWorkbook.Sheets("Sheet1")
            'Insert the DataTable into the Excel Spreadsheet
            'objSheet.PrintCommunication = False
            '-----------LOAD LEN EXCEL
            Dim intRow As Integer = 0, _SodongIn As Integer = 0
            Dim intdong_1 As Integer = 0, intdong_2 As Integer = 0, intdong_3 As Integer = 0, intdong_4 As Integer = 0
            Dim intdong_5 As Integer = 0, intdong_6 As Integer = 0, intdong_7 As Integer = 0, intdong_8 As Integer = 0
            Dim intdong_9 As Integer = 0, intdong_10 As Integer = 0, intdong_11 As Integer = 0, intdong_12 As Integer = 0
            Dim intdong_13 As Integer = 0, intdong_14 As Integer = 0, intdong_15 As Integer = 0, intdong_16 As Integer = 0

            Dim _sophieu As String = String.Empty, _khachhang As String = String.Empty
            Dim _loaihang As String = String.Empty, _mamau As String = String.Empty
            Dim _mame As String = String.Empty, _mame_id As String = String.Empty

            Dim _intNext_Temp As Byte = 0
            Dim _intNext_Temp_row As Byte = 0
            Dim _sodong As Byte = 0, _sodong_1 As Byte = 0, _sodong_2 As Byte = 0
            Dim _Tongcay As Integer = 0, _TongDong As Integer = 0
            Dim _TongKg As Single = 0, _Tongmet As Single = 0, _Tongyard As Single = 0
            Dim _dongia As Decimal = 0, _thanhtien As Decimal = 0
            Dim _Haohut As Single = 0
            Dim _mau As String = String.Empty, _Chungtuxuat_ID As String = String.Empty, _donhang As String = String.Empty
            Dim _khovai As String = String.Empty
            Dim _ghichu As String = String.Empty
            Dim strDong As String = String.Empty
            Dim _intTang_36 As Integer = 0, _intTang_36_1 As Integer = 0
            Dim nStartRow As Byte = 10
            Dim panel As GridPanel = Super_Dgv.PrimaryGrid
            Dim lngpos As Integer = 0
            Dim strText As String = "-"
            '//
            Dim intdong As Integer = 0
            Dim _LRow_1 As Integer = 0, _LRow_2 As Integer = 0, _LRow_3 As Integer = 0
            Dim _LRow_4 As Integer = 0, _LRow_5 As Integer = 0, _LRow_6 As Integer = 0
            Dim _Lsub_Int_Startrow As Integer = 4
            '//
            With objSheet
                With .Range("S1") 'ĐONHANG
                    'strText = "Khách Hàng: "
                    .Value = "Đơn Hàng"
                    '.Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T1") 'ĐONHANG
                    'strText = "Khách Hàng: "
                    .Value = Ldonhang
                    '.Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '//
                With .Range("S2") 'Mahang
                    .Value = "Mã Hàng: "
                    '.Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T2") 'Khách Hàng
                    .Value = Lmahang
                    '.Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '//
                With .Range("S3") 'Mahang
                    .Value = "Khách Hàng: "
                    '.Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T3") 'Khách Hàng
                    .Value = LKhachhang
                    '.Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '//
                With .Range("S4") 'Loại Hang
                    .Value = "Loại Hàng:"
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T4") 'Loại Hang
                    .Value = LLoaihang
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '//MAMAU
                With .Range("S5")
                    .Value = "Mã Màu: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T5")
                    .Value = LMaMau
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '///
                With .Range("S6")
                    .Value = "Tên Màu: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T6")
                    .Value = LTenmau
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '//
                With .Range("S7") 'Ten Mau
                    .Value = "Mã mẻ: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T7") 'Ten Mau
                    .Value = "'" & LMaMe
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '///
                With .Range("S8")
                    .Value = "Số Cây: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T8")
                    .Value = LSocay
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '///kho vai
                With .Range("S9")
                    .Value = "Số Kg: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T9")
                    .Value = LSokg
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '////MET/KG
                With .Range("S10")
                    .Value = "Số Mét: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T10")
                    .Value = LSomet
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '//QUI TRINH
                With .Range("S11") 'Qui Trình
                    .Value = "Mẻ Ghép: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T11") 'Qui Trình
                    .Value = LMaMe_All
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '//
                With .Range("S12")
                    .Value = "GHI CHÚ: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T12")
                    .Value = LGhichu
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With

                '//
                With .Range("S13")
                    .Value = "Mô Tả: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T13")
                    .Value = Lmota
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '// Ma Thiet ke
                With .Range("S14") 'Khách Hàng
                    .Value = "Khổ: "
                    '.Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T14") 'Khách Hàng
                    .Value = Lkhovai
                    '.Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '//
                With .Range("S15")
                    .Value = "T.Lượng: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T15")
                    .Value = Lmetkg
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '///
                With .Range("S16")
                    strText = "Công Đoạn: "
                    '.Value = LLoaiDay
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T16")
                    .Value = LCongDoan
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '///
                With .Range("S17")
                    strText = "Bộ Phận: "
                    '.Value = LLoaiDay
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T17")
                    .Value = LBoPhan
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '///
                With .Range("S18")
                    strText = "Số Phiếu: "
                    '.Value = LLoaiDay
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T18")
                    .Value = Lsophieu
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '///
                With .Range("S19")
                    strText = "Ngày lập: "
                    '.Value = LLoaiDay
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T19")
                    .Value = LNgayTao
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                _TongDong = 0
                Super_Dgv.SuspendLayout()
                '//
                If blnIsVisible = False Then
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

            End With
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
End Class