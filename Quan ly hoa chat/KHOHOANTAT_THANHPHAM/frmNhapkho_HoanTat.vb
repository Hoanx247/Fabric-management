Option Strict Off
Imports System.IO

Imports System.Xml
Imports System.Drawing

Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Imports System.Text
Imports System.ComponentModel

Public Class frmNhapkho_HoanTat
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Private moClsReadFile As ClsReadFile
    '//
    Dim dt_local As DataTable
    Dim dt_macay As DataTable
    Dim dt_local_detail As New DataTable
    Dim dr As DataRow()
    '--
    '---resize form
    Dim intChophepluu As Integer = 0
    Dim _blnThoat As Boolean = False
    Dim _disable_Load As Boolean = False
    Private _mame_id As String = String.Empty
    Dim dr2 As DataRow()
    Dim _Save_Finish As Boolean = False
    '----------------------
    Private _IsFirst As Boolean = False
    Dim _kgmoc As Single = 0

    Private _Update_KCS As Boolean = False, _Insert_KCS As Boolean = False
    '------
    Dim _intRows_ALL As Integer = 0
    Dim _intColumns_ALL As Integer = 0, _intGroup_count As Integer = 0
    '--
    Dim _saveRowIndex As Integer = 0
    Private strFileName_SerialPort As String = My.Application.Info.DirectoryPath & "\Name.ini"
    Private strFileName_Printer As String = My.Application.Info.DirectoryPath & "\Printer.ini"
    Private IsBusy As Boolean = False
    '//
    Private LDonHang As String = String.Empty
    Private LMaHang As String = String.Empty
    Private LKhachHang As String = String.Empty
    Private LLoaiHang As String = String.Empty
    Private LMaMau As String = String.Empty
    Private LTenMau As String = String.Empty
    Private LKhoVai As String = String.Empty
    Private LMetKg As String = String.Empty
    Private LMaMe As String = String.Empty
    Private dblKgCan As Single = 0
    '//
    Dim _bit_Saving As Boolean = False, _bit_active As Boolean = False
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

#Region " Load du liệu lên bảng khi mở Form"

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F10
                Call btnSave_Click(Nothing, Nothing)
            Case Keys.F12
            Case Keys.Escape

            Case Else
                Return MyBase.ProcessCmdKey(msg, keyData)

        End Select

        Return True
    End Function

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If _blnThoat = False Then
            e.Cancel = True
            MessageBox.Show("Xin Vui Lòng Bấm Nút Thoát!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else

            dt_local.Dispose()
            dt_macay.Dispose()
            dt_local_detail.Dispose()
            Me.Dispose()
            System.GC.Collect()
            System.GC.WaitForPendingFinalizers()
        End If
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtControler = New KhoSanXuatDAL
        clsDev = New ClsDevcomponent
        dt_local = New DataTable
        dt_macay = New DataTable
        '--Dang Ky HotKeys

        Chk_Intem.Checked = True
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView)
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        '--
        AddHandler Dgv_chung.DataBindingComplete, AddressOf Dgv_Chung_DataBindingComplete
        AddHandler Dgv_Chitiet.DataBindingComplete, AddressOf Dgv_Chitiet_DataBindingComplete
        With Dgv_Chitiet
            .Dock = DockStyle.Fill
        End With
        '--
        '_kgoffset = readIniFile("kgoffset", "sokg", strFileName_SerialPort)
        '---
        chkIn_Sokg.CheckState = CheckState.Unchecked
        _disable_Load = False
        My.Settings.Save()
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler
        '--
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        RdbTem1.Checked = True
        '//
        Me.txtmame_F.Focus()
        cboghichu.SelectedIndex = 0
        cbophanloai.SelectedIndex = 0
        '//
        Format_SuperGrid()
    End Sub

#End Region

#Region "LAY THONG TIN ME NHUOM"
    Private Sub txtmame_F_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmame_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(txtmame_F.Text) > 2 Then
                txtmame_F.ReadOnly = True
                txtmacay.Text = String.Empty
                Call Filter_Information_mame()
                'Call Filterdata_chung()
                'Call Filterdata_Moc("*")
                txtmame_F.ReadOnly = False
                txtmame_F.Focus()
            End If
        End If
    End Sub

    Private Sub Filter_Information_mame()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_DinhHinh_KCS]", sbXMLString.ToString, "select")
        Dgv_chung.DataSource = dtControler.SELECT_XML_Datatable(_dt)
        IsBusy = False
        Me.ResumeLayout()
    End Sub

    Private Sub Dgv_Chung_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs)
        If Dgv_chung.Rows.Count > 0 Then
            With Dgv_chung
                LDonHang = .Rows(0).Cells(_coldonhang).Value
                _mame_id = .Rows(0).Cells("mame_id").Value
                LMaHang = .Rows(0).Cells(_colmahang).Value
                LKhachHang = .Rows(0).Cells(_colkhachhang).Value
                LLoaiHang = .Rows(0).Cells(_colloaihang).Value
                Lmame = .Rows(0).Cells("mame").Value
                LKhoVai = .Rows(0).Cells(_colkhovai).Value
                LMetKg = .Rows(0).Cells(_colmetkg).Value
                LMaMau = .Rows(0).Cells(_colMamau).Value
                LTenMau = .Rows(0).Cells(_colMau).Value
                'txtyeucauTP.Text = .Rows(0).Cells("yeucau_dinhhinh").Value
                'txtghichu.Text = .Rows(0).Cells(_colghichu).Value
                'txtghichu_nhuom.Text = .Rows(0).Cells("yeucau_nhuom").Value
                'txtmacongnghe.Text = .Rows(0).Cells("macongnghe").Value
            End With
        Else
            LDonHang = String.Empty
            _mame_id = String.Empty
            LMaHang = String.Empty
            LKhachHang = String.Empty
            LLoaiHang = String.Empty
            LMaMe = String.Empty
            LKhoVai = String.Empty
            LMetKg = String.Empty
            LMaMau = String.Empty
            LTenMau = String.Empty
        End If
        '//
        '//
        Dim stDonHang As String = "<div>" & "<b><font size=""16""><font color=""BLACK"">{0}</font></font></b>" 'ĐƠN HÀNG
        stDonHang &= "<b><font size=""16""><font color=""BLACK""> {1} </font></font></b>" & "</div>"
        Dim stMaHang As String = "<div>" & "<b><font size=""16""><font color=""BLACK"">{0}</font></font></b>" 'ĐƠN HÀNG
        stMaHang &= "<b><font size=""16""><font color=""Black""> {1} </font></font></b>" & "</div>"
        '////
        Super_Dgv_Info.PrimaryGrid.Caption.Text = String.Format(stDonHang, "+ ĐƠN HÀNG: ",
                                                       LDonHang.ToUpper)
        Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ MÃ HÀNG: ",
                                                    LMaHang.ToUpper)
        Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ KHÁCH HÀNG: ",
                                                     LKhachHang.ToUpper)
        Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ LOẠI HÀNG: ",
                                                     LLoaiHang.ToUpper)
        Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ MÃ MÀU: ",
                                                     LMaMau.ToUpper)
        Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ TÊN MÀU: ",
                                                     LTenMau.ToUpper)
        '//
        Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "================", "")
        Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ KHỔ/MÉT.KG: ",
                                                     LKhoVai.ToUpper & "/" & LMetKg.ToUpper)
        Super_Dgv_Info.PrimaryGrid.Caption.Text &= String.Format(stMaHang, "+ MÃ MẺ: ",
                                                     LMaMe.ToUpper)
        '//
        ''
        Call Filterdata_chung()
        '//
    End Sub
#End Region


#Region "MOC SAN XUAT"

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            'ShowContextMenu(CtxFunction)
        Else
            'Try
            Dim panel As GridPanel = Super_Dgv.PrimaryGrid
            Dim dgvr As GridRow = DirectCast(panel.ActiveRow, GridRow)
            If dgvr IsNot Nothing Then
                _kgmoc = Convert.ToSingle(dgvr.Cells(_colsokgM).Value)
                txtmacay.Text = Convert.ToString(dgvr.Cells(_colmacay).Value)
                'txtsocay_dinhhinh.Text = String.Format("{0:0.0}", dgvr.Cells(_colsocayTp).Value)
                Call Filterdata_Moc(txtmacay.Text)
            Else
                _kgmoc = 0
                'txtsocay_dinhhinh.Text = "0"
                txtmacay.Text = String.Empty
                Call Filterdata_Moc("***")
            End If
            'Catch ex As Exception

            'End Try
        End If

    End Sub


    Private Sub Filterdata_chung()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_CangThanhPham_01]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        panel.DataSource = New DataView(dt_local, "", "macay asc", DataViewRowState.CurrentRows)
    End Sub
#Region "SUM"

    Dim _array_column As String() = {"socaytp", "sokgtp", "somettp", "socay_phanme", "sokgmoc", "sometmoc",
         "socay_dinhhinh", "sokg_dinhhinh", "somet_dinhhinh"}
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
        Dim st As String = "<div align=""center"">" & "<font color=""Black"">{0}</font><br/>" & "<font color=""Blue"">{1}</font>" & "</div>"
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
        _stName = "Theo_Moc"
        _stHeadText = "Mộc"
        _stCol1 = "sokgmoc"
        _stCol2 = "sometmoc"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_ThanhPham"
        _stHeadText = "T.Phẩm"
        _stCol1 = "socaytp"
        _stCol2 = "somettp"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '----
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

                        '---
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("macay")}
        If sortCols.Length = 1 Then
            panel.SetSort(sortCols, GetSortDir_Asc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        End If
        '//
        _bit_active = False
        '--Quét màu cảnh báo
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                '--Quét màu cảnh báo
                If ExistsColumnGridPanel(panel, "sokgtp") = True Then
                    If Convert.ToSingle(row.Cells("sokgtp").Value) + Convert.ToSingle(row.Cells("somettp").Value) > 0 Then
                        row.CellStyles.Default.Background.Color1 = Color.GreenYellow
                        _saveRowIndex += 1
                    Else
                        If _bit_active = False Then
                            row.SetActive()
                            row.IsSelected = True
                            row.CellStyles.Default.Background.Color1 = Color.HotPink
                            Call Chon_Macay()
                            _bit_active = True
                        End If
                    End If

                End If

            End If

        Next
        tpress.Enabled = True
    End Sub

    Private Sub Chon_Macay()
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        'Try
        If dgvr IsNot Nothing Then
            txtmacay.Text = dgvr.Cells("macay").Value.ToString
            Call Filterdata_Moc(txtmacay.Text)
        Else
            txtmacay.Text = String.Empty
        End If
    End Sub
    Public Function GetSortDir_Asc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection)})
    End Function

    Private Sub Filterdata_Moc(ByVal _macay As String)
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("macay='" + ReplaceTextXML(txtmacay.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_CangThanhPham_02]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        Dgv_Chitiet.DataSource = New DataView(dt_local, "", "macay asc", DataViewRowState.CurrentRows)
    End Sub

    Private Sub Dgv_Chitiet_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs)

        With Dgv_Chitiet
            .ClearSelection()
            .CurrentCell = Nothing
            '---Load gio he thong

            '--Xử lý Column
            With Dgv_Chitiet
                Dim columns As DataGridViewColumnCollection = .Columns
                Dim _sQuery As String = String.Empty
                Dim _sName_Temp As String = String.Empty
                Dim dr As DataRow()
                Dim _sCol1 As Integer = 0
                Dim _sCol2 As Integer = .ColumnCount - 1

                '--
                _Update_KCS = False
                For Each row As DataGridViewRow In .Rows
                    If IsDBNull(row.Cells("dtthanhpham_kcs").Value) = False Then
                        _Update_KCS = True
                    End If
                Next
                If _Update_KCS = False Then
                    btnMoc_bebe.Enabled = False
                Else
                    btnMoc_bebe.Enabled = True
                End If
                '--
            End With
        End With
    End Sub

    Private Sub Update_Data(ByVal _Command As String)
        '-- KIỂM TRA TRƯỚC KHI LƯU
        Dim _bebe As Byte = 0
        '1) Mã cây phải nhiều hơn 6 ký tự, không có mã mẻ, số kg phải lớn hơn 3 kg
        If Me.txtmame_F.Text.Length < 3 Then
            Exit Sub
        End If
        '--
        Call Load_TimeServer()
        If dblKgCan < 1 Then
            'Exit Sub
        End If
        '----------------------------------
        If _Save_Finish = False Then
            _Save_Finish = True
            dblKgCan = Convert.ToSingle(txtScale1.Text)
        End If

        '---
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(_mame_id) + "' ")
        sbXMLString.Append("macay_old='" + ReplaceTextXML(txtmacay.Text) + "' ")
        sbXMLString.Append("macay='" + ReplaceTextXML(txtmacay.Text) + "' ")
        sbXMLString.Append("sokgtp='" + CNumber_system(dblKgCan) + "' ")
        sbXMLString.Append("somettp='" + CNumber_system(txtsometTP.Text) + "' ")
        sbXMLString.Append("nhanviencang='" + ReplaceTextXML(_stUser_Save) + "' ")
        sbXMLString.Append("phanloai='" + ReplaceTextXML(cbophanloai.Text) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[vpsXmlKhoThanhPham_ChiTiet_Update]", sbXMLString.ToString, _Command)
        dtControler.UPSET_XML(_dt)
        '---
        _Save_Finish = False
        Call Filterdata_chung()
        Call Filterdata_Moc(txtmacay.Text)
    End Sub

#End Region
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        ' These calls will remove the OPC items, Group, and Disconnect in the proper order
        Timer_ReadScale_1.Enabled = False
        wait(100)
        _blnThoat = True

        wait(200)
        Me.Close()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        txtmame_F.Text = String.Empty
        txtmame_F.Focus()
    End Sub

    Private Sub Timer_save_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_save.Tick
        Timer_save.Enabled = False
        'lbChophep.Visible = False
        intChophepluu = 1
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If LMaMe.ToUpper <> txtmame_F.Text.ToUpper Then
            MsgBox("Vui lòng bấm nhập mẻ và Enter.", MsgBoxStyle.Critical, "Thông Báo")
            Exit Sub
        End If
        If txtmacay.Text.Length = 0 Then
            MsgBox("Vui lòng chọn mã cây.", MsgBoxStyle.Critical, "Thông Báo")
            Exit Sub
        End If
        btnSave.Enabled = False
        wait(100)
        '_Macay_Luu = txtmacay.Text
        If _Update_KCS = False Then
            Update_Data("insert_kcs")
        Else
            Update_Data("update_kcs")
        End If

        wait(100)
        btnSave.Enabled = True
    End Sub

    Private Sub Dgv_Chitiet_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_Chitiet.CellClick
        Dim dgvr As DataGridViewRow = Dgv_Chitiet.CurrentRow
        If dgvr IsNot Nothing Then
            btnXoa.Enabled = True
        Else
            btnXoa.Enabled = False
        End If
    End Sub


    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim character As String = String.Empty
        If Asc(e.KeyChar).ToString <> CStr(8) Then
            If decimalSeparator_system = "," Then
                Dim str As String = "0123456789,"
                If str.Contains(e.KeyChar) = True Then
                    e.Handled = False

                Else
                    e.Handled = True
                End If
            Else
                Dim str As String = "0123456789."
                If str.Contains(e.KeyChar) = True Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
        End If

    End Sub



    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim _command As String = String.Empty
            btnXoa.Enabled = False
            Dim dgvr As DataGridViewRow = Dgv_Chitiet.CurrentRow
            Dim _lmacay As String = String.Empty
            Dim _tp_bebe As Integer = 0
            If dgvr IsNot Nothing Then
                'Kiem Tra da thanh pham chua
                If MsgBox("Bạn có muốn xóa cây Thành Phẩm không ?", DirectCast(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Xóa Dữ Liệu") = MsgBoxResult.Yes Then
                    _lmacay = dgvr.Cells(_colmacay).Value.ToString
                    'If _stUser_Save.ToLower <> "hoanx" Then
                    If Dgv_Chitiet.RowCount = 1 Then
                        Dim diffminutes = DateDiff(DateInterval.Minute, dgvr.Cells("dtthanhpham").Value, dgvr.Cells("dtthanhpham_kcs").Value)
                        If diffminutes < 3 Then
                            _command = "delete_thanhpham"
                        Else
                            _command = "delete_kcs"
                        End If
                    ElseIf Dgv_Chitiet.RowCount > 1 Then
                        If dgvr.Cells("tp_bebe").Value > 0 Then
                            _command = "delete_kcs"
                        Else
                            MsgBox("Vui lòng xóa cây bể bế trước.", MsgBoxStyle.Critical, "Thông Báo")
                        End If
                    End If
                    '//
                    Xoa_KCS(_command, _lmacay)
                    'Else
                    '//
                    'End If

                End If
            Else
                MsgBox("Xin vui lòng chọn dữ liệu để xoá.", MsgBoxStyle.Information, "Thông báo!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Thông báo!")
        Finally
            btnXoa.Enabled = True
            ' REPORT & ABORT ON ERRORS
            Call Filterdata_chung()
            Call Filterdata_Moc(txtmacay.Text)
        End Try
    End Sub
    Private Sub Xoa_KCS(ByVal _Command As String, ByVal _LMacay As String)
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(_mame_id) + "' ")
        sbXMLString.Append("macay_old='" + ReplaceTextXML(txtmacay.Text) + "' ")
        sbXMLString.Append("macay='" + ReplaceTextXML(_LMacay) + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[vpsXmlKhoThanhPham_ChiTiet_Update]", sbXMLString.ToString, _Command)
        dtControler.UPSET_XML(_dt)

    End Sub

    Private Sub txtScale1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtScale1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If LMaMe.ToUpper <> txtmame_F.Text.ToUpper Then
                MsgBox("Vui lòng bấm nhập mẻ và Enter.", MsgBoxStyle.Critical, "Thông Báo")
                Exit Sub
            End If
            If txtmacay.Text.Length = 0 Then
                MsgBox("Vui lòng chọn mã cây.", MsgBoxStyle.Critical, "Thông Báo")
                Exit Sub
            End If
            btnSave.Enabled = False
            wait(100)
            '_Macay_Luu = txtmacay.Text
            If _Update_KCS = False Then
                Update_Data("insert_kcs")
            Else
                Update_Data("update_kcs")
            End If

            wait(100)
            btnSave.Enabled = True
        End If
    End Sub
End Class