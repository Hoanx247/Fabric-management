﻿Imports System
Imports System.Collections.Generic
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text

Public Class frmDonHang_LenhSanXuat_ChuyenMau
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Dim dt_local As DataTable
    Dim dt_congdoan As DataTable

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
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"donhang", "ghichu_thuchien_1", "mamau_khachhang", "tenmau_nhuom", "macongnghe_yeucau", "mame_ghep"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private Lnhom_hoadon As Int16 = 0
    Private Lc_id_donhang As String = String.Empty
    '//
    Private DgvData As DataGridView = New DataGridView()
    Public Property Mame_id() As String
        Get
            Return _mame_id
        End Get
        Set(ByVal value As String)
            _mame_id = value
        End Set
    End Property
    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing

        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
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
        dt_congdoan = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        Call clsDev.Format_Super_Dgv(Super_Dgv_MaMe, _MyFont_GridView - 1)
        '--
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        '--
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If _donhang_status = 14 Then
            _lbtn_command = 1
            Call Load_TextBox()
            '//
            btnSave.Text = "Lưu Lại"
        End If
    End Sub

#Region "DATAGRID"
    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = e.GridColumn.ColumnIndex

            ShowContextMenu(CtxMenu)
        End If
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        End If
        If e.GridCell.ColumnIndex = 0 Then
            panel.ReadOnly = False
            If dgvr.Checked = False Then
                'dgvr.Checked = True
                'dgvr.CellStyles.Default.Background.Color1 = Color.GreenYellow
            Else
                'dgvr.Checked = False
                'dgvr.CellStyles.Default.Background.Color1 = Color.Empty
            End If
        Else
            panel.ReadOnly = True
        End If
        _saveRowIndex = e.GridCell.RowIndex
        If dgvr IsNot Nothing Then
            Dim _sDonHang_ID As String = dgvr.Cells(_colDonhang_ID).Value.ToString
            _mamau_id = dgvr.Cells(_colMamau_ID).Value.ToString
            txtmamau.Text = dgvr.Cells("mamau_khach").Value.ToString
            txtmau.Text = dgvr.Cells("tenmau_khach").Value.ToString
        End If

    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub

    Private Sub CircleProcess_Start()
        Try
            With CircularProgress1
                .Location = New Point(CInt((Super_Dgv.Width - .Width) / 2), CInt((Super_Dgv.Height - .Height) / 2))
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
        sbXMLString.Append("donhang='" + ReplaceTextXML(txtdonhang.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_DonHang_TaoMeNhuom_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        panel.DataSource = New DataView(dt_local, "", "", DataViewRowState.CurrentRows)
        Call CircleProcess_Stop()
        Me.ResumeLayout()
    End Sub

    Private Sub Rdb_Nhom1_CheckedChanged(sender As Object, e As EventArgs)
        Call Taophieumoi()
    End Sub

    Private Sub Rdb_Nhom2_CheckedChanged(sender As Object, e As EventArgs)
        Call Taophieumoi()
    End Sub

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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mame"), panel.Columns("mahang")}
        If panel.SortColumns.Count = 2 Then
            'panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        Else
            'panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        End If

    End Sub

#End Region
    Private Sub Update_Data(ByVal st As String, ByVal _command As String)
        '//
        If Trim(txtmame.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập mã mẻ.", "Thông báo")
            txtmadonhang.Focus()
            Exit Sub
        ElseIf Trim(txtdonhang.Text) = "" Then
            MessageBox.Show("Xin vui lòng nhập tên đơn hàng.", "Thông báo")
            txtdonhang.Focus()
            Exit Sub
        ElseIf Trim(_mahang_id) = "" Then
            _mahang_id = "-"
        ElseIf Trim(_mamau_id) = "" Then
            _mamau_id = "-"
        End If
        '//
        If Len(txtmame_01.Text) < 3 Then
            txtmame_01.Text = txtmame_cu.Text
        Else
            If Len(txtmame_02.Text) < 3 Then
                txtmame_02.Text = txtmame_cu.Text
            Else
                If Len(txtmame_03.Text) < 4 Then
                    txtmame_03.Text = txtmame_cu.Text
                End If
            End If
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("c_id_donhang='" + ReplaceTextXML(Lc_id_donhang) + "' ")
        sbXMLString.Append("donhang_id='" + ReplaceTextXML(_donhang_id) + "' ")
        sbXMLString.Append("mahang_id='" + ReplaceTextXML(_mahang_id) + "' ")
        sbXMLString.Append("mamau_khach='" + ReplaceTextXML(txtmamau.Text) + "' ")
        sbXMLString.Append("tenmau_khach='" + ReplaceTextXML(txtmau.Text) + "' ")
        sbXMLString.Append("macongdoan_yeucau='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame.Text) + "' ")
        sbXMLString.Append("mame_ghep='" + ReplaceTextXML(txtmame_ghep.Text) + "' ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(txtmame.Text) + "' ")
        sbXMLString.Append("nhomloi_id='" + ReplaceTextXML("NL00") + "' ")
        sbXMLString.Append("khovai='" + ReplaceTextXML(txtkhovai.Text) + "' ")
        sbXMLString.Append("metkg='" + ReplaceTextXML(txtmetkg.Text) + "' ")
        sbXMLString.Append("socay='" + CNumber_system(txtsocay.Text) + "' ")
        sbXMLString.Append("sokg='" + CNumber_system(txtsokg.Text) + "' ")
        sbXMLString.Append("somet='" + CNumber_system(txtsomet.Text) + "' ")
        sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
        Dim _mota_chuyenmau As String = txttenmau_cu.Text.ToUpper & " -> " & txtmau.Text.ToUpper & " [" & txtmamau.Text.ToUpper & "]"
        sbXMLString.Append("mota_chuyenmau='" + ReplaceTextXML(_mota_chuyenmau) + "' ")
        sbXMLString.Append("dtngaytao='" + Format$(dtngaynhap.Value, "MM/dd/yyyy") + "' ")
        sbXMLString.Append("nguoitao='" + ReplaceTextXML(strUser) + "' ")
        sbXMLString.Append("mame_01='" + ReplaceTextXML(txtmame_01.Text) + "' ")
        sbXMLString.Append("mame_02='" + ReplaceTextXML(txtmame_02.Text) + "' ")
        sbXMLString.Append("mame_03='" + ReplaceTextXML(txtmame_03.Text) + "' ")
        sbXMLString.Append("mame_04='" + ReplaceTextXML(txtmame_04.Text) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, _command)
        dtControler.UPSET_XML(_dt)
        '//
        _update_Ok = True
        '//
        'Update_CongDoan("insert")
        '//
        Call Filterdata_Stored()
        '//
    End Sub


    Private Sub Load_TextBox()
        Dim panel As GridPanel = frmDieuDoSanXuat_UPSET.Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        With dgvr
            If dgvr IsNot Nothing Then
                Lc_id_donhang = Exists_ColDev_Value(panel, "c_id").ToString
                _donhang_id = Exists_ColDev_Value(panel, "donhang_id").ToString
                txtmadonhang.Text = Exists_Column_SuperDgv(panel, _colmadonhang).ToString
                txtdonhang.Text = Exists_Column_SuperDgv(panel, _coldonhang).ToString
                txtkhachhang.Text = Exists_ColDev_Value(panel, _colkhachhang).ToString
                '---
                _mahang_id = Exists_ColDev_Value(panel, _colMahang_ID).ToString
                txtmahang.Text = Exists_ColDev_Value(panel, _colmahang).ToString
                txtloaihang.Text = Exists_ColDev_Value(panel, _colloaihang).ToString
                txtkhovai.Text = Exists_ColDev_Value(panel, "khovai").ToString
                txtmetkg.Text = Exists_ColDev_Value(panel, "metkg").ToString
                '--
                '_mame_id = Exists_ColDev_Value(panel, "mame_id").ToString
                txtmame_cu.Text = Exists_ColDev_Value(panel, "mame").ToString
                txtmame_ghep.Text = Exists_ColDev_Value(panel, "mame_ghep").ToString & "X"
                txtsocay.Text = FormatNumber(Exists_ColDev_Value(panel, _colsocay), 0)
                txtsokg.Text = FormatNumber(Exists_ColDev_Value(panel, _colsokg), 1)
                txtsomet.Text = FormatNumber(Exists_ColDev_Value(panel, _colsomet), 1)
                '//
                txtmame_01.Text = Exists_ColDev_Value(panel, "mame_01").ToString
                txtmame_02.Text = Exists_ColDev_Value(panel, "mame_02").ToString
                txtmame_03.Text = Exists_ColDev_Value(panel, "mame_03").ToString
                txtmame_04.Text = Exists_ColDev_Value(panel, "mame_04").ToString
                Lnhom_hoadon = Exists_ColDev_Value(panel, "nhom_hoadon").ToString
                '--
                '///
                _mamau_id = Exists_ColDev_Value(panel, _colMamau_ID).ToString
                txtmamau.Text = Exists_ColDev_Value(panel, _colMamau).ToString
                txtmau.Text = Exists_ColDev_Value(panel, _colMau).ToString
                '//
                txttenmau_cu.Text = txtmau.Text & " [" & txtmamau.Text & "]"
                '--
                txtghichu.Text = Exists_Column_SuperDgv(panel, _colghichu).ToString
                dtngaynhap.Value = Format$(dgvr.Cells("dtngaytao").Value, "dd/MM/yyyy")
                txtmahang.Focus()
                '//
                Call Filterdata_Stored()
                '//
                Call btnAdd_Click(Nothing, Nothing)
            End If
        End With
    End Sub

    Private Sub Clear_TextBox()
        txtsocay.Text = String.Empty
        txtsokg.Text = String.Empty
        txtsomet.Text = String.Empty
        txtsocay.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If _lbtn_command = 1 Then
            Call MdlData.Load_TimeServer()
            _mame_id = "D" & _TimeServer.Ticks.ToString
            Call Update_Data("", "insert_chuyenmau")
            If _update_Ok = True Then
                Call Clear_TextBox()
            End If
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

#Region "EXECUTE"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs)

        btnSave.Text = "Lưu Lại"
        '//
        Call Taophieumoi()
    End Sub
#End Region

    Private Sub Taophieumoi()
        Dim str_sophieu As String
        Dim _Nam As String, _Thang As String
        Dim dbl_stt As Integer = 0
        str_sophieu = String.Empty
        '---Load gio he thong

        Call Load_TimeServer()
        _Nam = Mid$(_TimeServer.Year.ToString, 4, 1)

        _Thang = KyTu_Thang_Nhom2(_TimeServer.Month)
            str_sophieu = _Nam & _Thang
        'dt_local = ShellServices.VpsCheckExistsCode(str_sophieu, "mame_nhom_khonghoadon")

        '//
        txtmame.Text = VpsXmlList_CreateID(str_sophieu, "mame")
        '--

        'If dt_local.Rows.Count > 0 Then
        'txtmame.Text = dt_local.Rows(0).Item(0)
        'Else
        'txtmame.Text = str_sophieu & "0001"
        'End If

    End Sub
End Class