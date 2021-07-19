Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports DevComponents.AdvTree

Public Class frmTimeLine_Confirm_XuatMoc_DiNhuom
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim dt_congdoan As DataTable
    Dim dt_congdoan_ph As DataTable
    Dim dt_may As DataTable
    Private dr0 As DataRow()

    Dim _Load_Ok As Boolean = False
    Dim _saveRowIndex As Integer = 0

    Dim _List_Cells As String() = {}
    Dim strCells As List(Of String) = _List_Cells.ToList()
    '//
    Private _List_Column_Locked As String() = {"thutu_sanxuat_uutien", "thoigian_cho", "thoigian_toithieu", "ghichu", "phanloai_ngaydem"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Private IsChanged As Boolean = False
    '--
    Dim _kieuxuat_id As String, _stMakytu_xuat As String
    Dim dr2 As DataRow()
    Dim _chungtuxuat_id As String
    Dim _load_finish As Boolean = False

    Private _congdoan_id As String = String.Empty
    Private _macongdoan As String = String.Empty
    Private Lmame As String = String.Empty
    '//
    Private _IsBusy As Boolean = False

    Private SoDongChon As Integer = 0
    Private _MaMe As String = String.Empty
    Private _MaMay As String = String.Empty

    '//
    Private _columnName As String = String.Empty
    Dim _ColorPick As String = String.Empty
    Private Lmamay_id As String = String.Empty
    Private Lmame_id As String = String.Empty
    Private LNV_ID As String = String.Empty
    Private LNhanVien As String = String.Empty
    Private LID As String = String.Empty
    Private LCongDoan_id As String = String.Empty
    Private Lkhuvuc_id As String = String.Empty
    Private Lkhuvuc As String = String.Empty
    '//
    Private Lmahang_id As String = String.Empty
    Private Lmahang As String = String.Empty
    Private Lmamau_id As String = String.Empty
    Private Lmamau As String = String.Empty
    '//
    Private _GioVao As DateTime
    Private _GioKetThuc As DateTime
    Private _thoigian_toithieu As Int16 = 0
    Private IsSelected_Row As Boolean = False
    Private tpress As New Timer With {.Interval = 200}
    Private _IsFirst As Boolean = False
    '//
    Public Property MaMe_ID() As String
        Get
            Return Lmame_id
        End Get
        Set(ByVal value As String)
            Lmame_id = value
        End Set
    End Property
    Public Property KhuVuc_ID() As String
        Get
            Return Lkhuvuc_id
        End Get
        Set(ByVal value As String)
            Lkhuvuc_id = value
        End Set
    End Property
    Public Property KhuVuc() As String
        Get
            Return Lkhuvuc
        End Get
        Set(ByVal value As String)
            Lkhuvuc = value
        End Set
    End Property
    Public Property NhanVien_ID() As String
        Get
            Return LNV_ID
        End Get
        Set(ByVal value As String)
            LNV_ID = value
        End Set
    End Property
    Public Property NhanVien() As String
        Get
            Return LNhanVien
        End Get
        Set(ByVal value As String)
            LNhanVien = value
        End Set
    End Property
    '//
#Region "LOAD FORMAT"
    Dim _MyFont_Header_dgv As New Font("Time New Roman", 13, FontStyle.Bold)
    Dim _MyFont_dgv As New Font("Time New Roman", 13, FontStyle.Regular)
    Private Sub Format_SuperGrid()
        Super_Dgv_Info.Dock = DockStyle.Fill
        '//
        Dim panel As GridPanel = TryCast(Super_Dgv_Info.PrimaryGrid, GridPanel)
        With panel
            .BeginDataUpdate()
            .VirtualMode = False
            .ReadOnly = True
            .ColumnHeader.Visible = False
            .RowHeaderWidth = 0
            .Filter.Visible = False
            .RowHeaderIndexOffset = 1
            .DefaultRowHeight = 30
            '.UseAlternateRowStyle = True
            '.UseAlternateColumnStyle = True
            .ColumnAutoSizeMode = ColumnAutoSizeMode.DisplayedCells
            .ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CellStyles.Default.Font = _MyFont_dgv
            .DefaultVisualStyles.ColumnHeaderStyles.Default.Font = _MyFont_Header_dgv
            .DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = Alignment.MiddleRight
            .DefaultVisualStyles.HeaderStyles.Default.Alignment = Alignment.MiddleCenter
            .DefaultVisualStyles.GroupHeaderStyles.Default.Alignment = Alignment.MiddleCenter
            .DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleLeft
            .DefaultVisualStyles.CellStyles.Default.Margin.Left = 5
            .DefaultVisualStyles.CellStyles.Default.Margin.Right = 5
            '.DefaultVisualStyles.CaptionStyles.Default.Image = ImageList1.Images(0)
            .SelectionGranularity = SelectionGranularity.RowWithCellHighlight
            '.GridLines = GridLines.Horizontal
            .AllowSelection = False
            .DefaultVisualStyles.CaptionStyles.Default.Background.Color1 = Color.Yellow
            '//
            '.AllowDrop = True
            .KeepRowsSorted = False
            .ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .Caption.EnableMarkup = True
            .Caption.Visible = True
            '////

            '.Caption.Visible = True
            Dim gc As DevComponents.DotNetBar.SuperGrid.GridColumn = Nothing
            gc = New DevComponents.DotNetBar.SuperGrid.GridColumn("id")
            gc.HeaderText = "A"
            'gc.HeaderStyles.Default.Image = ImageList1.Images(0)
            gc.HeaderStyles.Default.Alignment = Alignment.MiddleCenter
            gc.Name = "id"
            gc.CellStyles.Default.Alignment = Alignment.MiddleRight
            gc.EnableHeaderMarkup = True
            'gc.Width = 100
            gc.CellStyles.Default.Font = _MyFont_Header_dgv
            'gc.CellStyles.Default.Image = ImageList2.Images(0)
            .Columns.Add(gc)
            gc = New DevComponents.DotNetBar.SuperGrid.GridColumn("name")
            gc.HeaderText = "B"
            'gc.HeaderStyles.Default.Image = ImageList1.Images(0)
            gc.HeaderStyles.Default.Alignment = Alignment.MiddleCenter
            gc.Name = "name"
            gc.EnableHeaderMarkup = True
            .Columns.Add(gc)

            .EndDataUpdate()
        End With
    End Sub

    Private Sub Add_Data()
        Dim panel As GridPanel = TryCast(Super_Dgv_Info.PrimaryGrid, GridPanel)
        With panel
            .BeginDataUpdate()
            If _IsFirst = False Then
                _IsFirst = True
                wait(100)
            End If
            '//
            If .Rows.Count = 0 Then
                panel.Rows.Add(GetNewRow("Giờ Vào", Now, 1))
            End If
            '//
            .EndDataUpdate()
        End With
    End Sub
    Private Function GetNewRow(ByVal _data1 As String, ByVal _data2 As String, ByVal _data3 As Int16) As GridRow
        ' GridRows can be created with varying parameters set
        ' to the GridRow constructor. In this case we are
        ' sending a variable list of parameters.
        Dim row As New GridRow(_data1, _data2)
        If _data3 = 1 Then
            'row.Cells(0).CellStyles.Default.Image = ImageList2.Images(0)
        End If

        Return (row)
    End Function
#End Region

    Private Sub BtnExit_CapNhat_Click(sender As Object, e As EventArgs) Handles BtnExit_CapNhat.Click
        Me.Close()
    End Sub
    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If txtmame_scanner.Text.Length >= 6 Then
            With txtmacay_scanner
                If .Focused = False Then
                    .Focus()
                    .Text = e.KeyChar.ToString
                    .SelectionStart = .Text.Length
                    e.Handled = True
                End If
            End With
        Else
            With txtmame_scanner
                If .Focused = False Then
                    .Focus()
                    .Text = e.KeyChar.ToString
                    .SelectionStart = .Text.Length
                    e.Handled = True
                End If
            End With
        End If

    End Sub
    Private Sub Me_FormClosing(ByVal sender As Object,
                                    ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                    Handles Me.FormClosing

        If IsChanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
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
        dt_congdoan_ph = New DataTable
        dt_may = New DataTable
        '//

        With Super_Dgv
            .AllowDrop = True
            .PrimaryGrid.KeepRowsSorted = False
            .PrimaryGrid.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.None
            .DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft
            .PrimaryGrid.Caption.EnableMarkup = True
            .PrimaryGrid.Caption.Visible = True
            .PrimaryGrid.Caption.Text = "DANH SÁCH CHI TIẾT MẺ: "
        End With
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        'AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        'AddHandler Super_Dgv.CellClick, AddressOf CellClick
        'AddHandler Super_Dgv.CellDoubleClick, AddressOf Super_Dgv_CellDoubleClick
        'AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        '//

        Format_SuperGrid()
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Call Check_administrator(Me.Name.ToString)
        If True = True Then
            With Super_Dgv_Info
                Dim stinfo As String = "<div>" & "<b><font size=""16""><font color=""BLACK"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<b><font size=""16""><font color=""BLACK""> {1} </font></font></b>" & "</div>"
                .PrimaryGrid.Caption.Text = String.Format(stinfo, "+ KHU VỰC: ", Lkhuvuc.ToUpper)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ NHÂN VIÊN: ", LNhanVien.ToUpper)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "======================", "")
                Add_Data()
                '////
            End With
            '//

            _load_finish = True
        Else
            Me.Close()
        End If
    End Sub

#Region "LOAD TAT CA CONG DOAN ME"
    Private Sub txtmame_scanner_TextChanged(sender As Object, e As EventArgs) Handles txtmame_scanner.TextChanged
        If Len(txtmame_scanner.Text) = 6 Then
            Call Filterdata_chung()
        End If
    End Sub

    Private Sub Filterdata_chung()
        Me.SuspendLayout()
        'Try
        'Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_scanner.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_XacNhan_XuatMoc]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        If dt_local.Rows.Count > 0 Then
            Lmame_id = dt_local.Rows(0).Item("mame_id").ToString
        Else
            Lmame_id = String.Empty
        End If
    End Sub


    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '//
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("dtngayxuat_sanxuat_xacnhan"), panel.Columns("macay")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirDesDes(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDesDes(sortCols))
        End If

        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)

        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String
        '--
        _stName = "Theo_NhanVienVao"
        _stHeadText = "Nhân Viên Vào"
        _stCol1 = "masonhanvien"
        _stCol2 = "thoigianvao"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        _stName = "Theo_NhanVienRa"
        _stHeadText = "Nhân Viên Ra"
        _stCol1 = "masonhanvien_1"
        _stCol2 = "thoigianra"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If

    End Sub

#End Region
#Region "LUU DATA"

    Private Sub txtmacay_scanner_TextChanged(sender As Object, e As EventArgs) Handles txtmacay_scanner.TextChanged
        If Len(txtmacay_scanner.Text) = 6 Then
            txtmacay_scanner.ReadOnly = True
            Call LuuXuatNhuom()
        End If
    End Sub


    Private Sub LuuXuatNhuom()
        If Lmame_id.Length > 3 Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            '//
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("macay='" + ReplaceTextXML(txtmacay_scanner.Text) + "' ")
            sbXMLString.Append("mame_id='" + ReplaceTextXML(Lmame_id) + "' ")
            sbXMLString.Append(" />")
            '//
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoSanXuatDTO("[vpsXmlKhoMoc_Detail_XuatNhuom_UPSET_2021]", sbXMLString.ToString, "update_XacNhan_XuatNhuom")
            If dtControler.UPSET_XML(_dt) = True Then
                Call Filterdata_chung()
                '//
                txtmacay_scanner.ReadOnly = False
                txtmacay_scanner.Text = String.Empty
                txtmacay_scanner.Focus()
            End If
        Else
            txtmacay_scanner.ReadOnly = False
        End If
    End Sub
#End Region
End Class