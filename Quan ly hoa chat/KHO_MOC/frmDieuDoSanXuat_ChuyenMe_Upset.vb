Imports System
Imports System.Collections.Generic
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text
Imports System.Globalization

Public Class frmDieuDoSanXuat_ChuyenMe_Upset
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable


    Dim _update_Ok As Boolean = False
    Dim _local_command As String = String.Empty
    Dim _bln_khachhang As Boolean = False, _bln_mahang As Boolean = False, _bln_mamau As Boolean = False, _bln_donhang As Boolean = False
    Private _bln_macongnghe As Boolean = False
    Dim _bln_tenmau As Boolean = False
    Private _makh_id As String = String.Empty, _mahang_id As String = String.Empty, _mamau_id As String = String.Empty
    Private _sName As String = String.Empty
    Private _mame_id As String = String.Empty, _donhang_id As String = String.Empty, _macn_id As String = String.Empty
    Private _lbtn_command As SByte = 0
    Private _IsBusy As Boolean = False
    Dim dr2 As DataRow()
    Dim _saveRowIndex As Integer = 0
    Dim _Column_Forzen_pos As Integer = 0
    Dim _intRows_ALL As Integer = 0
    Dim _intColumns_ALL As Integer = 0, _intGroup_count As Integer = 0
    Dim _List_MameID As String() = {}
    Dim strList As List(Of String) = _List_MameID.ToList()
    '--
    Dim _List_CongDoanID As String() = {}
    Dim strCongDoanID As List(Of String) = _List_CongDoanID.ToList()
    Private _macongdoan_id_all As String = String.Empty
    '//
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"donhang", "ghichu_thuchien_1", "mamau_khachhang", "tenmau_nhuom", "macongnghe_yeucau", "mame_ghep"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    '//
    Private DgvData As DataGridView = New DataGridView()
    Private _mame_cu As String = String.Empty
    Private _mame As String = String.Empty
    Private _isdathanhpham As Boolean = False
    Public Property Mame_id() As String
        Get
            Return _mame_id
        End Get
        Set(ByVal value As String)
            _mame_id = value
        End Set
    End Property
    Public Property Mame() As String
        Get
            Return _mame
        End Get
        Set(ByVal value As String)
            _mame = value
        End Set
    End Property
    Public Property Mame_cu() As String
        Get
            Return _mame_cu
        End Get
        Set(ByVal value As String)
            _mame_cu = value
        End Set
    End Property


    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing

        Me.DialogResult = DialogResult.OK
        Call clsDev.SaveColumn(Super_Dgv_TonMoc.PrimaryGrid, Me.Name.ToString)
        Call clsDev.SaveColumn(Super_Dgv_PhanMe.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Me.Dispose()
        '--
    End Sub

    Private Sub List_DonHang_input_Load(sender As Object, e As EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_local = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv_TonMoc, _MyFont_GridView - 1)
        Call clsDev.Format_Super_Dgv(Super_Dgv_PhanMe, _MyFont_GridView - 1)
        '--
        AddHandler Super_Dgv_TonMoc.DataBindingComplete, AddressOf Super_Dgv_TonMoc_DataBindingComplete
        AddHandler Super_Dgv_TonMoc.CellClick, AddressOf Super_Dgv_TonMoc_CellClick
        '//
        AddHandler Super_Dgv_PhanMe.DataBindingComplete, AddressOf Super_Dgv_PhanMe_DataBindingComplete
        AddHandler Super_Dgv_PhanMe.CellClick, AddressOf Super_Dgv_PhanMe_CellClick
        '--
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        _lbtn_command = 3
        Call Load_TextBox()

    End Sub


#Region "DATAGRID"
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = e.GridColumn.ColumnIndex

            ShowContextMenu(CtxMenu)
        End If
    End Sub

    Private Sub Super_Dgv_TonMoc_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv_TonMoc.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        End If
        If e.GridCell.ColumnIndex = 0 Then
            panel.ReadOnly = False
            If dgvr.Checked = False Then
                dgvr.Checked = True
                dgvr.CellStyles.Default.Background.Color1 = Color.GreenYellow
            Else
                dgvr.Checked = False
                dgvr.CellStyles.Default.Background.Color1 = Color.Empty
            End If
        Else
            panel.ReadOnly = True
        End If
        _saveRowIndex = e.GridCell.RowIndex
    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub

    Private Sub CircleProcess_Start()
        Try
            With CircularProgress1
                .Location = New Point(CInt((Super_Dgv_TonMoc.Width - .Width) / 2), CInt((Super_Dgv_TonMoc.Height - .Height) / 2))
                .IsRunning = True
                .Visible = True
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CircleProcess_Stop()
        wait(200)
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub

    Private Sub Filterdata_Stored()
        Me.SuspendLayout()
        'Try
        Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(txtmame_cu.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_ChiTiet_GetData_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML(_dt, Super_Dgv_TonMoc.PrimaryGrid)

        Call CircleProcess_Stop()
        Me.ResumeLayout()
    End Sub
    Private Sub Super_Dgv_TonMoc_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("macay"), panel.Columns("mauvai_moc")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        End If
        '//
    End Sub



#End Region

#Region "PHAN ME"
    Private Sub Super_Dgv_PhanMe_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv_PhanMe.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        End If
        If e.GridCell.ColumnIndex = 0 Then
            panel.ReadOnly = False
            If dgvr.Checked = False Then
                dgvr.Checked = True
                dgvr.CellStyles.Default.Background.Color1 = Color.GreenYellow
            Else
                dgvr.Checked = False
                dgvr.CellStyles.Default.Background.Color1 = Color.Empty
            End If
        Else
            panel.ReadOnly = True
        End If
        _saveRowIndex = e.GridCell.RowIndex
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Filterdata_Stored()
    End Sub

    Private Sub Filterdata_MeNhuom()
        Me.SuspendLayout()
        'Try
        Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(_mame_id) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_ChiTiet_GetData_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML(_dt, Super_Dgv_PhanMe.PrimaryGrid)

        Call CircleProcess_Stop()
        Me.ResumeLayout()
    End Sub
    Private Sub Super_Dgv_PhanMe_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("macay"), panel.Columns("mauvai_moc")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        End If
        '//
    End Sub

#End Region
    Private Sub Update_Data(ByVal st As String, ByVal _command As String)
        If Trim(txtmame.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập mã mẻ.", "Thông báo")
            txtmame.Focus()
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("donhang_id='" + ReplaceTextXML(_donhang_id) + "' ")
        sbXMLString.Append("mahang_id='" + ReplaceTextXML(_mahang_id) + "' ")
        sbXMLString.Append("mamau_id='" + ReplaceTextXML(_mamau_id) + "' ")
        sbXMLString.Append("macongdoan_yeucau='" + ReplaceTextXML(_macongdoan_id_all) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame.Text) + "' ")
        sbXMLString.Append("mame_ghep='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(_mame_id) + "' ")
        sbXMLString.Append("socay='" + CNumber_system(txtsocay.Text) + "' ")
        sbXMLString.Append("sokg='" + CNumber_system(txtsokg.Text) + "' ")
        sbXMLString.Append("somet='" + CNumber_system(txtsomet.Text) + "' ")
        sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
        sbXMLString.Append("dtngaytao='" + Format$(dtngaynhap.Value, "MM/dd/yyyy") + "' ")
        sbXMLString.Append("nguoitao='" + ReplaceTextXML(strUser) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet]", sbXMLString.ToString, _command)
        'dtControler.UPSET_XML(_dt)
        '//
        _update_Ok = True

        Call Filterdata_Stored()
        '//
    End Sub

    Private Sub Load_TextBox()
        Dim panel As GridPanel = frmDieuDoSanXuat_UPSET.Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        With dgvr
            If dgvr IsNot Nothing Then
                txtdonhang.Text = Exists_Column_SuperDgv(panel, _coldonhang).ToString
                txtkhachhang.Text = Exists_ColDev_Value(panel, _colkhachhang).ToString
                '---
                txtmahang.Text = Exists_ColDev_Value(panel, _colmahang).ToString
                txtloaihang.Text = Exists_ColDev_Value(panel, _colloaihang).ToString
                'txtmadet.Text = Exists_ColDev_Value(panel, "madet").ToString
                txtkhovai.Text = Exists_ColDev_Value(panel, "khovai").ToString
                txtmetkg.Text = Exists_ColDev_Value(panel, "metkg").ToString
                '--
                _mame_id = Exists_ColDev_Value(panel, "mame_id").ToString
                txtmame.Text = Exists_ColDev_Value(panel, "mame").ToString
                txtmame_cu.Text = Exists_ColDev_Value(panel, "mame_01").ToString
                txtsocay.Text = FormatNumber(Exists_ColDev_Value(panel, _colsocay), 0)
                txtsokg.Text = FormatNumber(Exists_ColDev_Value(panel, _colsokg), 1)
                txtsomet.Text = FormatNumber(Exists_ColDev_Value(panel, _colsomet), 1)
                '///
                txtmamau.Text = Exists_ColDev_Value(panel, _colMamau).ToString
                txtmau.Text = Exists_ColDev_Value(panel, _colMau).ToString
                '--
                txtghichu.Text = Exists_Column_SuperDgv(panel, _colghichu).ToString
                dtngaynhap.Value = Format$(dgvr.Cells("dtngaytao").Value, "dd/MM/yyyy")
                'dtngaygiao.Value = Convert.ToDateTime(Exists_Column_SuperDgv(panel, _coldtngaygiao))
                txtmahang.Focus()
                '//
                Call Filterdata_Stored()
                '//
                wait(100)
                '//
                Call Filterdata_MeNhuom()

            End If
        End With
    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

#Region "XAC NHAN XUAT MOC"
    Private Sub ToolStripButton_XuatMoc_Click(sender As Object, e As EventArgs) Handles ToolStripButton_XuatMoc.Click
        '//
        _isdathanhpham = False
        Dim panel As GridPanel = Super_Dgv_TonMoc.PrimaryGrid
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_XuatMoc(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[vpsXmlKhoMoc_Detail_XuatNhuom_UPSET]", sbXMLString.ToString, "update_XacNhan_ChuyenMe")
        If _isdathanhpham = False Then
            dtControler.UPSET_XML(_dt)
        End If

        '//
        Call Filterdata_Stored()
        '//
        Call Filterdata_MeNhuom()
    End Sub
    Private Sub UpdateDetails_XuatMoc(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_XuatMoc(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    If IsDBNull(row.Cells("dtthanhpham").Value) = True Then
                        sbXMLString.Append("<DATA ")
                        sbXMLString.Append("macay='" + ReplaceTextXML(row.Cells("macay").Value.ToString) + "' ")
                        sbXMLString.Append("mame_id='" + ReplaceTextXML(_mame_id) + "' ")
                        sbXMLString.Append("mame_01='" + ReplaceTextXML(txtmame_cu.Text) + "' ")
                        sbXMLString.Append(" />")
                    Else
                        _isdathanhpham = True

                    End If

                End If
            End If
        Next

    End Sub

#End Region

#Region "TRA MOC VE KHO"
    Private Sub ToolStripButton_TraVeKhoMoc_Click(sender As Object, e As EventArgs) Handles ToolStripButton_TraVeKhoMoc.Click
        '//
        Dim panel As GridPanel = Super_Dgv_PhanMe.PrimaryGrid
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetails_XuatMoc(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[vpsXmlKhoMoc_Detail_XuatNhuom_UPSET]", sbXMLString.ToString, "update_TraVeKhoMoc")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
        '//
        Call Filterdata_MeNhuom()
    End Sub


#End Region


End Class