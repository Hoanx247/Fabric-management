Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text
Public Class frmDieuDoSanXuat_UPSET
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
    Dim _List_Cells As String() = {}
    Dim strCells As List(Of String) = _List_Cells.ToList()
    '--
    Dim _List_CongDoanID As String() = {}
    Dim strCongDoanID As List(Of String) = _List_CongDoanID.ToList()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"mame_01", "mame_02", "mame_03", "mame_04", "mame_ghep", "menhuom_chung"}
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
    Dim _isPaste_G As Boolean = False
    Private _columnName As String = String.Empty
    Private _mamay_id As String = String.Empty
    '//
    Dim _List_MaCongNghe_DangThucHien As String() = {}
    Dim _List_MaCongNghe_DaThucHien As String() = {}
    Dim _List_Mame As String() = {}
    '//
    Dim strMame As List(Of String) = _List_Mame.ToList()
    Private _macongdoan_id_all As String = String.Empty
    '//
    Dim _List_Mamay_id As String() = {}
    Dim strMamay_id As List(Of String) = _List_Mamay_id.ToList()
    '//
    Dim _List_Thoigian As String() = {}
    Dim str_Thoigian As List(Of String) = _List_Thoigian.ToList()
    '//
    Dim _mame_temp As String = String.Empty
    Private LMaMe_01 As String = String.Empty
    Private LMaMe_02 As String = String.Empty
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
    Private LGhiChu_ddsx As String = String.Empty
    '///
    Private LSophieu_LKT As String = String.Empty
    Private LCongdoan_LKT As String = String.Empty
    Private LGhiChu_LKT As String = String.Empty
    Private LCanhBao_DonHang As String = String.Empty
    Private LListMame_all As String = String.Empty
    '//
#Region "Move Panel"
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point

#Region "ALL"
    Private Sub GP_Form_CongDoan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_CongDoan.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub
    Private Sub GP_Form_CongDoan_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_CongDoan.MouseMove
        If allowCoolMove = True Then
            Me.SuspendLayout()
            With GP_Form_CongDoan
                .Location = New Point(.Location.X + e.X - myCoolPoint.X, .Location.Y + e.Y - myCoolPoint.Y)
            End With
            Me.ResumeLayout()
        End If
    End Sub
    Private Sub GP_Form_CongDoan_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_CongDoan.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "MOVE PANEL MAMAU"
    Private Sub GP_Form_CapNhat_MaMau_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_CapNhat_MaMau.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub
    Private Sub GP_Form_CapNhat_MaMau_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_CapNhat_MaMau.MouseMove
        If allowCoolMove = True Then
            Me.SuspendLayout()
            With GP_Form_CapNhat_MaMau
                .Location = New Point(.Location.X + e.X - myCoolPoint.X, .Location.Y + e.Y - myCoolPoint.Y)
            End With
            Me.ResumeLayout()
        End If
    End Sub
    Private Sub GP_Form_CapNhat_MaMau_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GP_Form_CapNhat_MaMau.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub
#End Region


#End Region
    '/
    Dim orderArray_May() As String = {}
    Private IsChanged As Boolean = 0
    Private Lmamay_id As String = String.Empty
    Private Lcongdoan_id As String = String.Empty
    '//
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
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '//
        dt_local = New DataTable
        dt_congdoan = New DataTable
        dt_may = New DataTable
        dt_kieuxuat = New DataTable
        '--
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        ListView1.Columns.Clear()
        ListView2.Columns.Clear()
        ListView1.Columns.Add("Mã CĐ", 80)
        ListView1.Columns.Add("Tên CĐ", 180)
        ListView1.Columns.Add("T.Gian", 80)
        ListView1.Columns.Add("Mã Máy", 80)
        ListView1.Columns.Add("Thiết Bị", 80)
        ListView1.Columns.Add("ID", 80)
        '//
        ListView2.Columns.Add("Mã CĐ", 80)
        ListView2.Columns.Add("Tên CĐ", 180)
        ListView2.Columns.Add("T.Gian", 80)
        ListView2.Columns.Add("Mã Máy", 80)
        ListView2.Columns.Add("Thiết Bị", 80)
        ListView2.Columns.Add("ID", 80)
        '//
        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged

        AddHandler tpress.Tick, AddressOf MyTickHandler
        '//
        Call Load_CongDoan()
        '//
        Load_CongDoan_Nhom()
        '//
        Load_MayNhuom()

    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            Call Filterdata_Stored()
        Else
            Me.Close()
        End If

    End Sub

#Region "FragrantComboBox"
    Private Sub Load_CongDoan_Nhom()
        dt_congdoan = VpsXmlList_Load("", "", "macongdoan")
        LoadDataToCombox(dt_congdoan, cboCongDoan_Xoa, "macongdoan", False)
    End Sub
    Private Sub Load_MayNhuom()
        dt_may = VpsXmlList_Load("", "", "danhsachmay")
    End Sub
    Friend Class FragrantComboBox
        Inherits GridComboBoxExEditControl
        Public Sub New(ByVal orderArray As IEnumerable)
            DataSource = orderArray
        End Sub
    End Class

#End Region

#Region "SUPERGRID"
    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        If _load_finish = True Then
            'clsDev.SuperDgv_CellValueChanged(sender, e)
        End If

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
        Else
            '//e.GridColumn
            If e.GridColumn.Name = "mame_ghep" Or e.GridColumn.Name = "mame" Or e.GridColumn.Name = "mahang" Or e.GridColumn.Name = "khovai" Then
                With Super_Dgv
                    .PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.SortAndReorder
                End With
            Else
                With Super_Dgv
                    .PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None

                End With
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
            '//
            If dgvr IsNot Nothing Then
                If dgvr.Cells("makytu").FormattedValue.ToString = "XT" Then
                    ButtonItem_Update_CongDoan.Enabled = False
                    ButtonItem_ChonMeChinh.Enabled = False
                Else
                    ButtonItem_Update_CongDoan.Enabled = True
                    ButtonItem_ChonMeChinh.Enabled = True
                End If
                If dgvr.Cells("nhomloi_id").FormattedValue.ToString = "-" Then
                    ButtonItem_MeLoi_ChuyenMau.Enabled = False
                Else
                    ButtonItem_MeLoi_ChuyenMau.Enabled = True
                End If
                '//
                txtmame_ghep.Text = dgvr.Cells("mame").FormattedValue.ToString
                Lmamau_id = dgvr.Cells("mamau_id").FormattedValue.ToString
                txtmamau.Text = dgvr.Cells("mamau").FormattedValue.ToString
                txttenmau.Text = dgvr.Cells("tenmau").FormattedValue.ToString
                '//
                LGhiChu_ddsx = dgvr.Cells("ghichu_ddsx").FormattedValue.ToString.Replace(vbCr, "").Replace(vbLf, "")
                txtmame_ghichu.Text = LGhiChu_ddsx
                LCanhBao_DonHang = dgvr.Cells("canhbao_donhang").FormattedValue.ToString.Replace(vbCr, "").Replace(vbLf, "")
                '//
                txttenmau_cu.Text = txttenmau.Text & " [" & txtmamau.Text & "]"
                '//
                'Lmame_id = dgvr.Cells("mame_id").FormattedValue.ToString
                Lmame = dgvr.Cells("mame").FormattedValue.ToString
                LListMame_all = dgvr.Cells("mame_all").FormattedValue.ToString
                txtmame_ghichu.Text = Lmame
                '//
                LMaMe_01 = dgvr.Cells("mame_01").FormattedValue.ToString
                LMaMe_02 = dgvr.Cells("mame_02").FormattedValue.ToString
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
                LSophieu_LKT = dgvr.Cells("sophieu_loikythuat").FormattedValue.ToString
                LCongdoan_LKT = dgvr.Cells("congdoan_loikythuat").FormattedValue.ToString
                LGhiChu_LKT = dgvr.Cells("ghichu_loikythuat").FormattedValue.ToString
                '//
                '//
                'Them <br/> để xuống dòng
                Dim stinfo As String = "<b><font size=""10""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<font size=""10""><font color=""Black""> {1} </font></font>"
                Dim stinfo_br As String = "<b><font size=""10""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo_br &= "<font size=""10""><font color=""BLUE""> {1} </font></font><br/>"
                '//

                Dim _tab As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                '////
                panel.Footer.Text = String.Format(stinfo, "+ ĐƠN HÀNG: ", Ldonhang.ToUpper & " || ")
                panel.Footer.Text &= String.Format(stinfo, "+ MÃ HÀNG: ", Lmahang.ToUpper & " - " & LLoaihang.ToUpper)
                panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ MÀU: ", LMaMau.ToUpper & " - " & LTenmau.ToUpper & " || ")
                panel.Footer.Text &= String.Format(stinfo_br, "+ MÃ CN: ", LMaCongNghe)
                panel.Footer.Text &= String.Format(stinfo_br, "+ MẺ: ",
                                   Lmame.ToUpper & " - " & LMaMe_01.ToUpper & " - " & LMaMe_02.ToUpper & " [Mẻ Ghép: " & LListMame_all & "] ")
                panel.Footer.Text &= String.Format(stinfo_br, "+ CẢNH BÁO: ", LCanhBao_DonHang)
                panel.Footer.Text &= String.Format(stinfo_br, "+ GHI CHÚ: ", LGhiChu_ddsx)
                panel.Footer.Text &= String.Format(stinfo, "+ PHIẾU LKT: ",
                                 LSophieu_LKT.ToUpper & " - " & LCongdoan_LKT.ToUpper & " - " & LGhiChu_LKT.ToUpper)

            Else
                LMaCongNghe = String.Empty
                Lmame = String.Empty
            End If

            '//
            If GP_Form_CongDoan.Visible = True Then
                '//Mame
                _List_Mame = {}
                ListView1.Items.Clear()
                ListView2.Items.Clear()
                '//
                Call Load_CongDoan()
                '///
                Dim toMove As ListViewItem
                Dim arrayLetters As String = LMaCongNghe
                arrayLetters = arrayLetters.Replace(" ", "")
                _List_Mame = arrayLetters.Split(",")
                For Each _Mame As String In _List_Mame
                    For Each item As ListViewItem In Me.ListView1.Items
                        If item.SubItems.Item(0).Text.ToLower = _Mame.ToLower Then
                            lvi = item.Clone()
                            ListView2.Items.Add(lvi)
                            '//
                            toMove = item
                            ListView1.Items.Remove(toMove)
                        End If

                    Next
                Next

            End If


        End If
        _saveRowIndex = e.GridCell.RowIndex
        _columnName = panel.ActiveCell.GridColumn.Name

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
        sbXMLString.Append("donhang='" + ReplaceTextXML(_donhang) + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mamau='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("tenmau='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mame_ghep='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_DonHang_Edit_2021]", sbXMLString.ToString, "select")
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        dtControler.SELECT_XML(_dt, panel)
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socay", "sokg", "somet", "socay_phanme", "sokg_phanme", "somet_phanme"}
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
        IsChanged = True '//Khong đánh dấu khi load data
        Call UpdateShowALLRows(panel.Rows)
        IsChanged = False
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
        Dim _MaCongNghe_all As String = String.Empty
        Dim _sSubject As String = String.Empty
        Dim _sValue1 As String = String.Empty
        Dim _sValue2 As String = String.Empty
        Dim _sValue3 As String = String.Empty
        Dim _StartIndex As Integer = 0
        '////
        Dim _isSame As Int16 = 0
        Dim _colorhtml As String = String.Empty
        _mame_temp = String.Empty
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
                        '//Quét
                        _MaCongNghe_all = row.Cells("macongnghe_all").FormattedValue.ToString
                        '//
                        If _MaCongNghe_all.Length > 3 Then
                            row.RowStyles.Default.RowHeaderStyle.Background.Color1 = Color.Empty
                        Else
                            row.RowStyles.Default.RowHeaderStyle.Background.Color1 = Color.Red
                        End If

                        _MaCongNghe_dangthuchien = row.Cells("macongnghe_dangthuchien").FormattedValue.ToString
                        _MaCongNghe_dathuchien = row.Cells("macongnghe_dathuchien").FormattedValue.ToString
                        If _MaCongNghe_dangthuchien.Length = 0 AndAlso _MaCongNghe_dathuchien.Length = 0 Then
                            _StartIndex = 1
                        ElseIf _MaCongNghe_dangthuchien.Length = 0 AndAlso _MaCongNghe_dathuchien.Length > 0 Then
                            _StartIndex = _MaCongNghe_dangthuchien.Length + _MaCongNghe_dathuchien.Length + 1
                        ElseIf _MaCongNghe_dangthuchien.Length > 0 AndAlso _MaCongNghe_dathuchien.Length = 0 Then
                            _StartIndex = _MaCongNghe_dangthuchien.Length + _MaCongNghe_dathuchien.Length + 1
                        ElseIf _MaCongNghe_dangthuchien.Length > 0 AndAlso _MaCongNghe_dathuchien.Length > 0 Then
                            _StartIndex = _MaCongNghe_dangthuchien.Length + _MaCongNghe_dathuchien.Length + 2
                        End If
                        _sValue1 = Mid(_MaCongNghe_all, _StartIndex, _MaCongNghe_all.Length)
                        _sValue2 = _MaCongNghe_dangthuchien
                        If _MaCongNghe_dangthuchien.Length = 0 AndAlso _MaCongNghe_dathuchien.Length = 0 Then
                            row.Cells("macongnghe_all").Value = _MaCongNghe_all
                        ElseIf _MaCongNghe_dangthuchien.Length = 0 AndAlso _MaCongNghe_dathuchien.Length > 0 Then
                            row.Cells("macongnghe_all").Value = _MaCongNghe_dathuchien & ",  [ " & _MaCongNghe_dangthuchien & " ]  " & _sValue1
                        ElseIf _MaCongNghe_dangthuchien.Length > 0 AndAlso _MaCongNghe_dathuchien.Length = 0 Then
                            row.Cells("macongnghe_all").Value = _MaCongNghe_dathuchien & "[ " & _MaCongNghe_dangthuchien & " ]  " & _sValue1
                        ElseIf _MaCongNghe_dangthuchien.Length > 0 AndAlso _MaCongNghe_dathuchien.Length > 0 Then
                            row.Cells("macongnghe_all").Value = _MaCongNghe_dathuchien & ",  [ " & _MaCongNghe_dangthuchien & " ]  " & _sValue1
                        End If
                        '//
                        '--
                        If CInt(row.Cells("socay_phanme").Value) = 0 Then
                            row.Cells(_colMame).CellStyles.Default.Background.Color1 = Color.Red
                        ElseIf CInt(row.Cells("socay_phanme").Value) > 0 AndAlso CInt(row.Cells("socay_phanme").Value) <> CInt(row.Cells("socay").Value) Then
                            row.Cells(_colMame).CellStyles.Default.Background.Color1 = Color.Orange
                        Else
                            row.Cells(_colMame).CellStyles.Default.Background.Color1 = Color.Empty
                        End If
                        '//
                        If Len(row.Cells("mamau_id").Value) < 3 Then
                            row.Cells(_colMamau).CellStyles.Default.Background.Color1 = Color.Red
                        Else
                            row.Cells(_colMamau).CellStyles.Default.Background.Color1 = Color.Empty
                        End If
                        '//
                        If IsDBNull(row.Cells("dtngayxuat_sanxuat").Value) = True Then
                            row.Cells("dtngayxuat_sanxuat").CellStyles.Default.Background.Color1 = Color.Red
                        Else
                            row.Cells("dtngayxuat_sanxuat").CellStyles.Default.Background.Color1 = Color.Empty
                        End If
                        '//
                        '///
                        If CBool(row.Cells("ismenhuom_chuyenmau").Value) = True Then
                            row.Cells("ismenhuom_chuyenmau").CellStyles.Default.Background.Color1 = Color.Red
                        Else
                            row.Cells("ismenhuom_chuyenmau").CellStyles.Default.Background.Color1 = Color.Empty
                        End If
                        '//
                        '//
                        '//Mẻ
                        If row.Cells("mame_ghep").Value.ToString = _mame_temp Then
                            row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                            'row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                        Else
                            _mame_temp = row.Cells("mame_ghep").Value.ToString
                            If _isSame = 0 Then
                                _colorhtml = "#FFFFFF"
                                row.Cells("mame_ghep").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                'row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
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
                                'row.Cells("mame").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(_colorhtml)
                                _isSame = 0
                            End If
                            _isSame += 1
                        End If
                        '//
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
        '--
        Dim _stCol As String
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '--
        _stName = "Theo_MauKhach"
        _stHeadText = "Màu (Khách)"
        _stCol1 = "mamau_khach"
        _stCol2 = "tenmau_khach"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightGreen))
        End If
        '--
        _stName = "Theo_MauSongThuy"
        _stHeadText = "Màu (ST)"
        _stCol1 = "mamau"
        _stCol2 = "tenmau"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeaderColor(columns, _stCol1, _stCol2, _stName, _stHeadText, Color.LightSeaGreen))
        End If
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mamau"), panel.Columns("mame_ghep"), panel.Columns("intnhomhang")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirAscAscAsc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirAscAscAsc(sortCols))
        End If
        '//
        tpress.Enabled = True

    End Sub
    Public Function GetSortDirAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Descending, SortDirection)})
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


    Private Sub ButtonItem_ThayDoi_MaMau_Click(sender As Object, e As EventArgs) Handles ButtonItem_ThayDoi_MaMau.Click
        Try
            Dim btn As ButtonItem = CType(sender, ButtonItem)
            With GP_Form_CapNhat_MaMau
                .Text = "CẬP NHẬT MÃ MÀU"
                '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True
            End With
        Catch ex As Exception

        End Try
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
        Call UpdateDetails_update_mamau_1(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_thaydoimau")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub UpdateDetails_update_mamau_1(ByVal rows As IEnumerable(Of GridElement))
        _List_Mame = {}
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_mamau_1(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    If Len(row.Cells("mame").Value.ToString) > 2 Then
                        '//
                        sbXMLString.Append("<DATA ")
                        sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString.Trim) + "' ")
                        sbXMLString.Append("mamau_id='" + ReplaceTextXML(Lmamau_id) + "' ")
                        Dim _mota_chuyenmau As String = txttenmau_cu.Text.ToUpper & " -> " & txttenmau.Text.ToUpper & " [" & txtmamau.Text.ToUpper & "]"
                        sbXMLString.Append("mota_chuyenmau='" + ReplaceTextXML(_mota_chuyenmau) + "' ")
                        sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
                        sbXMLString.Append("tenform='" + ReplaceTextXML(Me.Name.ToString) + "' ")
                        sbXMLString.Append("tencot='" + ReplaceTextXML(row.Cells("mame").Value.ToString.Trim) + "' ")
                        sbXMLString.Append(" />")
                    End If

                End If
            End If
        Next
    End Sub

#End Region

#Region "CAP NHAT ME GHEP"
    Private Sub BtnThoat_Panel_MeGhep_Click(sender As Object, e As EventArgs) Handles BtnThoat_Panel_MeGhep.Click
        GP_Form_CapNhat_MaGhep.Visible = False
    End Sub


    Private Sub ButtonItem_ChonMeChinh_Click(sender As Object, e As EventArgs) Handles ButtonItem_ChonMeChinh.Click
        Try
            Dim btn As ButtonItem = CType(sender, ButtonItem)
            With GP_Form_CapNhat_MaGhep
                .Text = "CẬP NHẬT MẺ GHÉP"
                '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnCapNhat_MeGhep_Click(sender As Object, e As EventArgs) Handles btnCapNhat_MeGhep.Click
        If Len(txtmame_ghep.Text) = 0 Then Exit Sub
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện áp mẻ ghép?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//

        Call UpdateDetails_update_maghep(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_meghep")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub UpdateDetails_update_maghep(ByVal rows As IEnumerable(Of GridElement))
        _List_Mame = {}
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_update_maghep(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    If Len(row.Cells("mame").Value.ToString) > 2 Then
                        '//
                        sbXMLString.Append("<DATA ")
                        sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString.Trim) + "' ")
                        sbXMLString.Append("mame_ghep='" + ReplaceTextXML(txtmame_ghep.Text) + "' ")
                        sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
                        sbXMLString.Append(" />")
                    End If

                End If
            End If
        Next
    End Sub

#End Region

#Region "XOA MÃ CÔNG NGHỆ"
    Private Sub ButtonItem_XoaTatCa_CongDoan_Click(sender As Object, e As EventArgs) Handles ButtonItem_XoaTatCa_CongDoan.Click
        If MsgBox("Bạn có muốn thực hiện xóa công đoạn thực hiện?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//Mame
        _List_Mame = {}
        '//Lấy Mẻ
        Call UpdateDetails_GetMaMe(Super_Dgv.PrimaryGrid.Rows)
        '//Update Mã Công Đoạn
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        For Each _Mame As String In _List_Mame

            sbXMLString.Append("<DATA ")
            sbXMLString.Append("mame_id='" + ReplaceTextXML(_Mame) + "' ")
            sbXMLString.Append(" />")
        Next
        '//
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_congdoan_UpSet]", sbXMLString.ToString, "delete_datmau")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub UpdateDetails_GetMaMe(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_GetMaMe(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    If Len(row.Cells("mame").Value.ToString) > 2 Then
                        '//
                        Dim _stMame As String = row.Cells("mame").Value.ToString.Trim
                        Dim result As String = Array.Find(_List_Mame, Function(s) s = _stMame)
                        If result Is Nothing Then
                            _List_Mame = _List_Mame.Concat({_stMame}).ToArray
                        End If
                    End If

                End If
            End If
        Next
    End Sub

#End Region

#Region "THEM CONG DOAN"
    '//
    Dim lvi As ListViewItem

    Private Sub BtnExit_ThemCongDoan_Click(sender As Object, e As EventArgs) Handles BtnExit_ThemCongDoan.Click
        With GP_Form_CongDoan
            .Visible = False
        End With
    End Sub

    Private Sub ButtonItem_Update_CongDoan_Click(sender As Object, e As EventArgs) Handles ButtonItem_Update_CongDoan.Click
        Try
            Dim btn As ButtonItem = CType(sender, ButtonItem)
            'Initail_INNERFORM(btn.Name, False)
            _Update_MaCongDoan_In = True
            With GP_Form_CongDoan
                .Text = "THÊM CÔNG ĐOẠN SẢN XUẤT"
                .Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
                .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
                .BringToFront()
                .Visible = True

            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Load_CongDoan()
        Dim str(5) As String
        Dim itm As ListViewItem
        dt_congdoan = VpsXmlList_Load("", "", "macongdoan")
        For Each row As DataRow In dt_congdoan.Rows
            str(0) = row.Item("macongdoan")
            str(1) = row.Item("tencongdoan")
            str(2) = row.Item("thoigian")
            str(3) = row.Item("mamay_id")
            str(4) = 0
            str(5) = row.Item("congdoan_id")
            itm = New ListViewItem(str)
            ListView1.Items.Add(itm)
        Next
    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Me.SuspendLayout()
        ListView1.SuspendLayout()
        lvi = ListView1.SelectedItems(0).Clone()
        ListView2.Items.Add(lvi)
        '//
        '//     
        Dim toMove As ListViewItem
        Dim oldIndex As Integer
        oldIndex = ListView1.SelectedItems(0).Index
        toMove = ListView1.SelectedItems(0)
        ListView1.Items.Remove(toMove)
        '//
        ListView1.ResumeLayout()
        Me.ResumeLayout()
    End Sub
    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListView2.DoubleClick
        Me.SuspendLayout()
        ListView2.SuspendLayout()
        ListView1.SuspendLayout()
        lvi = ListView2.SelectedItems(0).Clone()
        ListView1.Items.Add(lvi)
        '//     
        Dim toMove As ListViewItem
        Dim oldIndex As Integer
        oldIndex = ListView2.SelectedItems(0).Index
        toMove = ListView2.SelectedItems(0)
        ListView2.Items.Remove(toMove)
        '//
        'Set the ListviewItemSorter property to a new ListviewItemComparer object
        'Me.ListView1.ListViewItemSorter = New ListViewItemComparer(0, ListView1.Sorting)

        ' Call the sort method to manually sort
        ListView1.Sort()
        ListView1.ResumeLayout()
        ListView2.ResumeLayout()
        Me.ResumeLayout()
    End Sub
    Private Sub ListView1_ItemDrag(ByVal sender As Object, ByVal e As _
    System.Windows.Forms.ItemDragEventArgs) Handles ListView1.ItemDrag
        lvi = ListView1.SelectedItems(0).Clone()

        ' Create a DataObject that holds the ListViewItem.
        sender.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem", lvi), DragDropEffects.Copy)
    End Sub
    Private Sub ListView2_DragEnter(ByVal sender As Object, ByVal e As _
   System.Windows.Forms.DragEventArgs) Handles ListView2.DragEnter
        ' Check that a ListViewItem is being passed.
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem") Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub ListView2_DragDrop(ByVal sender As Object, ByVal e As _
   System.Windows.Forms.DragEventArgs) Handles ListView2.DragDrop

        ListView2.Items.Add(lvi)
    End Sub
    Sub MoveListViewItemUp(ByVal _ListView As ListView)
        Try
            Me.SuspendLayout()

            If Not _ListView.SelectedItems(0).Index = 0 Then
                Dim toMove As ListViewItem
                Dim oldIndex As Integer

                oldIndex = _ListView.SelectedItems(0).Index
                toMove = _ListView.SelectedItems(0)

                _ListView.Items.Remove(toMove)
                _ListView.Items.Insert(oldIndex - 1, toMove)
            End If
            Me.ResumeLayout()
        Catch ex As Exception

        End Try

    End Sub


    Sub MoveListViewItemDown(ByVal _ListView As ListView)
        Try
            If Not _ListView.SelectedItems(0).Index + 1 = _ListView.Items.Count Then
                Dim toMove As ListViewItem
                Dim oldIndex As Integer

                oldIndex = _ListView.SelectedItems(0).Index
                toMove = _ListView.SelectedItems(0)

                _ListView.Items.Remove(toMove)
                _ListView.Items.Insert(oldIndex + 1, toMove)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles BtnUp.Click

        MoveListViewItemUp(ListView2)
    End Sub

    Private Sub BtnDown_Click(sender As Object, e As EventArgs) Handles BtnDown.Click
        MoveListViewItemDown(ListView2)
    End Sub
    Private Sub BtnLuuLai_Click(sender As Object, e As EventArgs) Handles BtnLuuLai.Click
        _List_Mame = {}
        _List_Mamay_id = {}
        _List_Thoigian = {}
        _macongdoan_id_all = String.Empty
        Dim st1 As String = String.Empty
        Dim st2 As String = String.Empty
        Dim st3 As String = String.Empty
        Dim st4 As String = String.Empty
        Dim st5 As String = String.Empty
        Dim st6 As String = String.Empty
        Dim stt As Integer = 0
        For Each Listitem As ListViewItem In Me.ListView2.Items
            st1 = Listitem.SubItems.Item(0).Text
            st2 = Listitem.SubItems.Item(1).Text
            st3 = Listitem.SubItems.Item(2).Text
            st4 = Listitem.SubItems.Item(3).Text
            st5 = Listitem.SubItems.Item(4).Text
            st6 = Listitem.SubItems.Item(5).Text
            stt += 1
            '//
            Dim _stcongdoan_id As String = st6
            Dim result As String = Array.Find(_List_Mame, Function(s) s = _stcongdoan_id)
            If result Is Nothing Then
                _List_Mame = _List_Mame.Concat({_stcongdoan_id}).ToArray
                _macongdoan_id_all &= _stcongdoan_id & ","
            End If
            'Dim _stMaMay_ID As String = st4
            'Dim result_1 As String = Array.Find(_List_Mamay_id, Function(s) s = _stMaMay_ID)
            'If result_1 Is Nothing Then
            '_List_Mamay_id = _List_Mamay_id.Concat({_stMaMay_ID}).ToArray
            'Dim _stThoigian As String = st3
            '//Thoi Gian TOi Thieu
            '_List_Thoigian = _List_Thoigian.Concat({_stThoigian}).ToArray
            'End If
            '//
        Next
        _macongdoan_id_all = Mid(_macongdoan_id_all, 1, Len(_macongdoan_id_all) - 1)
        '//
        Update_CongDoan_Insert("Insert")
        '///
        Call Filterdata_Stored()
    End Sub
    Private Sub Update_CongDoan(ByVal _command As String)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call Load_TimeServer()
        Dim _stt As Integer = 0
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        _stt = 0
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked Then
                If Len(row.Cells("mame").Value.ToString) > 2 Then
                    For y = 0 To _List_Mame.Length - 1
                        sbXMLString.Append("<DATA ")
                        sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                        sbXMLString.Append("macongdoan_yeucau='" + ReplaceTextXML(_macongdoan_id_all) + "' ")
                        sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
                        sbXMLString.Append(" />")
                        _stt += 1
                    Next
                End If
            End If
        Next
        '//
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet]", sbXMLString.ToString, _command)
        dtControler.UPSET_XML(_dt)

    End Sub

    Private Sub Update_CongDoan_Insert(ByVal _command As String)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call Load_TimeServer()
        Dim _stt As Integer = 0
        Dim _mame_last As String = String.Empty
        '//

        Dim _thutu As Integer = 0
        '//
        _stt = 0
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked Then
                If Len(row.Cells("mame").Value.ToString) > 2 Then
                    If row.Cells("mame").Value.ToString <> _mame_last Then
                        _mame_last = row.Cells("mame").Value.ToString
                        _thutu = 0
                    End If
                    For y = 0 To _List_Mame.Length - 1
                        sbXMLString = New StringBuilder()
                        sbXMLString.Append("<Root>")
                        sbXMLString.Append("<DATA ")
                        sbXMLString.Append("maid='" + ReplaceTextXML(_TimeServer.Ticks & "M" & _stt) + "' ")
                        sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                        sbXMLString.Append("congdoan_id='" + ReplaceTextXML(_List_Mame(y)) + "' ")
                        sbXMLString.Append("thutu='" + _thutu.ToString + "' ")
                        sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
                        sbXMLString.Append(" />")
                        '//
                        sbXMLString.Append("</Root>")
                        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_congdoan_UpSet_combine]", sbXMLString.ToString, _command)
                        dtControler.UPSET_XML(_dt)
                        _stt += 1
                        _thutu += 1
                    Next
                End If
            End If
        Next


    End Sub

#End Region

#Region "XOA CONG DOAN"
    Private Sub ButtonItem_Xoa_1_CongDoan_Click(sender As Object, e As EventArgs) Handles ButtonItem_Xoa_1_CongDoan.Click
        Dim btn As ButtonItem = CType(sender, ButtonItem)
        '//
        With GP_Form_XoaCongDoan
            .Text = "XÓA CÔNG ĐOẠN"
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
            .Location = New Point(CInt((Super_Dgv.Width / 2) - (.Width / 2)), CInt((Super_Dgv.Height / 2) - (.Height / 2)))
            .Visible = True
        End With
    End Sub
    Private Sub BtnHidden_Panel_XoaCongDoan_Click(sender As Object, e As EventArgs) Handles BtnHidden_Panel_XoaCongDoan.Click
        GP_Form_XoaCongDoan.Visible = False
    End Sub
    Private Sub BtnXoa1CongDoan_Click(sender As Object, e As EventArgs) Handles BtnXoa1CongDoan.Click
        If MsgBox("Bạn có muốn thực hiện xóa một công đoạn không?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Call Load_TimeServer()
        Dim _stt As Integer = 0
        '///
        '--Kiem Tra Kieu xuat
        dr2 = dt_congdoan.Select("macongdoan = '" & cboCongDoan_Xoa.Text & "'", "")
        If dr2.Length > 0 Then
            _congdoan_id = dr2.First.Item("congdoan_id")
        Else
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        _stt = 0
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked Then
                If Len(row.Cells("mame").Value.ToString) > 3 Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame").Value.ToString) + "' ")
                    sbXMLString.Append("congdoan_id='" + ReplaceTextXML(_congdoan_id) + "' ")
                    sbXMLString.Append(" />")

                End If
            End If
        Next
        '//
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_congdoan_UpSet]", sbXMLString.ToString, "xoa_1_Congdoan")
        dtControler.UPSET_XML(_dt)
        '//

        Call Filterdata_Stored()
    End Sub

#End Region


#Region "AUTO CHANGE COLOR"
    Private _ColorCycle As Integer = 0



    ''' <summary>
    ''' Sets new colors for the given color table
    ''' </summary>
    ''' <param name="colors">Color Table</param>
    Private Sub SetNewScheme(ByVal colors As Color())
        ' Loop through each color in the table

        For i As Integer = 0 To colors.Length - 1
            colors(i) = GetNewColor(colors(i))
        Next
    End Sub


    ''' <summary>
    ''' Gets a new RGB cycle color
    ''' </summary>
    ''' <param name="color1">Current color</param>
    ''' <returns>New cycled color</returns>
    Private Function GetNewColor(ByVal color1 As Color) As Color
        If (_ColorCycle And 1) = 0 Then
            Return (Color.FromArgb(color1.R, color1.B, color1.G))
        End If

        Return (Color.FromArgb(color1.G, color1.R, color1.B))
    End Function

#End Region

    Private Sub TextBoxNumeric_KeyDown(sender As Object, e As KeyEventArgs)
        '//
        Dim _List_Except As String() = {}
        '//
        If e.KeyCode = Keys.Enter Then
            Dim txtbox As TextBox = CType(sender, TextBox)
            Dim result As String = Array.Find(_List_Except, Function(s) s = txtbox.Name)
            If result IsNot Nothing Then
                OnlyNumericKeysLevave(txtbox)
            End If
            '//
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
            '//
        End If
    End Sub

#Region "CHUYEN MAU"
    Private Sub ButtonItem_MeLoi_ChuyenMau_Click(sender As Object, e As EventArgs) Handles ButtonItem_MeLoi_ChuyenMau.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        'Try
        If dgvr IsNot Nothing Then
            _donhang_status = 14
            frmDonHang_LenhSanXuat_ChuyenMau.Mame_id = dgvr.Cells("mame_id").FormattedValue
            ShowModalForm_ChuyenMau()
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub
    Private Sub ShowModalForm_ChuyenMau()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_ChuyenMau))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmDonHang_LenhSanXuat_ChuyenMau
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




#End Region

#Region "XUAT DI SAN XUAT"
    Private Sub Load_KieuXuat_CTXuat()
        dt_kieuxuat = VpsXmlList_Load("", "", "khosanxuat_mucdich")
        LoadDataToCombox(dt_kieuxuat, cboKieuXuat, "mucdich", False)
    End Sub

    Private Sub ButtonItem_ChoDi_SanXuat_Click(sender As Object, e As EventArgs) Handles ButtonItem_ChoDi_SanXuat.Click
        Dim btn As ButtonItem = CType(sender, ButtonItem)
        '//
        Call Load_TimeServer()
        Me.dtNgayXuat_SX.Value = _TimeServer
        _Nam = KyTu_Nam(Mid$(_TimeServer.Year.ToString, 4, 1))
        _thang = KyTu_Thang(_TimeServer.Month)
        Dim stMa As String = _Nam & _thang & "X"
        txtchungtuxuat.Text = stMa
        '//
        With GP_Form_ChungTuXuat
            .Text = "XUẤT ĐI SẢN XUẤT"
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
            .Location = New Point(CInt((Me.Width / 2) - (.Width / 2)), CInt((Me.Height / 2) - (.Height / 2)))
            .Visible = True
            '//
            Load_KieuXuat_CTXuat()
        End With
    End Sub



    Private Sub btnThoat_GP_Form_CTXuat_Click(sender As Object, e As EventArgs) Handles btnThoat_GP_Form_CTXuat.Click
        GP_Form_ChungTuXuat.Visible = False
    End Sub
    Private Sub BtnCapNhat_XuatSX_Click(sender As Object, e As EventArgs) Handles BtnCapNhat_XuatSX.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        '--Kiem Tra Kieu xuat
        dr2 = dt_kieuxuat.Select("mucdich = '" & cboKieuXuat.Text & "'", "")
        If dr2.Length > 0 Then
            _stMakytu_xuat = dr2.First.Item(1)
            _kieuxuat_id = dr2.First.Item("mucdich_id")
        End If
        If MsgBox("Bạn có muốn thực hiện cập nhật?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        UpdateDetails_XuatDiSanXuat(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_XuatNhuom")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub
    Private Sub UpdateDetails_XuatDiSanXuat(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_XuatDiSanXuat(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("mame_id='" + ReplaceTextXML(row.Cells("mame_id").Value.ToString) + "' ")
                    sbXMLString.Append("mucdich_id='" + ReplaceTextXML(_kieuxuat_id) + "' ")
                    sbXMLString.Append("chungtuxuat_noibo='" + ReplaceTextXML(txtchungtuxuat.Text.Trim) + "' ")
                    sbXMLString.Append("ghichu_xuatmoc='" + ReplaceTextXML(txtghichu_xuat.Text.Trim) + "' ")
                    sbXMLString.Append("dtngayxuat_sanxuat='" + Format$(dtNgayXuat_SX.Value, "MM/dd/yyyy HH:mm:ss") + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub
    Private Sub ButtonItem_HuyDiSanXuat_Click(sender As Object, e As EventArgs) Handles ButtonItem_HuyDiSanXuat.Click
        If MsgBox("Bạn có muốn thực hiện cập nhật?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        '--Kiem Tra Kieu xuat
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        UpdateDetails_XuatDiSanXuat(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_HuyXuatNhuom")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub



#End Region

#Region "GHI CHU"
    Private Sub ButtonItem_Ghichu_Ddsx_Click(sender As Object, e As EventArgs) Handles ButtonItem_Ghichu_Ddsx.Click
        Dim btn As ButtonItem = CType(sender, ButtonItem)

        With GroupPanel_GhiChu
            .Text = "GHI CHÚ ĐIỀU ĐỘ"
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.9)
            .Location = New Point(CInt((Me.Width / 2) - (.Width / 2)), CInt((Me.Height / 2) - (.Height / 2)))
            .Visible = True
        End With
    End Sub



    Private Sub Button_Thoat_GhiChu_Click(sender As Object, e As EventArgs) Handles Button_Thoat_GhiChu.Click
        GroupPanel_GhiChu.Visible = False
    End Sub



    Private Sub Button_CapNhat_Ghichu_Click(sender As Object, e As EventArgs) Handles Button_CapNhat_Ghichu.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If MsgBox("Bạn có muốn thực hiện cập nhật?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_ghichu.Text) + "' ")
        sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu_ddsx.Text.Trim) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_ghichu")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub



#End Region

#Region "XAC NHAN ME LOI"
    Private Sub ButtonItem_XacNhan_MeLoi_Click(sender As Object, e As EventArgs) Handles ButtonItem_XacNhan_MeLoi.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        'Try
        If dgvr IsNot Nothing Then
            _PhieuLKT_status = 3
            frmPhieuLoiKyThuat_Input.MaMe = dgvr.Cells("mame").FormattedValue
            ShowModalForm_PhieuLoi_KyThuat()
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Private Sub ShowModalForm_PhieuLoi_KyThuat()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_PhieuLoi_KyThuat))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmPhieuLoiKyThuat_Input
                '.Size = New Size(Me.Width * 0.95, Me.Height)
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


#End Region

    Private Sub ButtonItem_LamMoi_Click(sender As Object, e As EventArgs) Handles ButtonItem_LamMoi.Click
        Call Filterdata_Stored()
    End Sub

#Region "ME LOI KY THUAT"
    Private Sub ButtonItem_ChuyenMocSangMe_Click(sender As Object, e As EventArgs) Handles ButtonItem_ChuyenMocSangMe.Click
        ShowModalForm_ChuyenMoc()
    End Sub
    Private Sub ShowModalForm_ChuyenMoc()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_ChuyenMoc))
        Else
            'Using f As frmKhoTong_Nhapkhovai_1input ' = New frmKhoTong_Nhapkhovai_1input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmDieuDoSanXuat_ChuyenMe_Upset
                .Size = New Size(Form1.Width * 0.95, Form1.Height * 0.95)
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
#End Region

End Class