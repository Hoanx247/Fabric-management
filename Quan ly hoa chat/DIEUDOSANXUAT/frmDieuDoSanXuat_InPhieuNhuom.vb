Imports System.Data.SqlClient
Imports System.Windows.Forms
'Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Excel = Microsoft.Office.Interop.Excel
Imports ThoughtWorks.QRCode.Codec
Imports System.Xml
Imports System.Drawing
Imports System.Text
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Public Class frmDieuDoSanXuat_InPhieuNhuom
    Private sbXMLString As StringBuilder = New StringBuilder()
    Dim clsDev As New ClsDevcomponent
    Dim cls As New Clsconnect
    Dim dt_local As DataTable
    Dim dt_local_detail As DataTable

    Private _IsBusy As Boolean = False
    Private _istxtJobProcessing As Boolean
    Dim dt_kieuxuat As DataTable
    Dim _kieuxuat_id As String, _stMakytu_xuat As String
    Dim dr2 As DataRow()
    Private _mame_id As String = String.Empty
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    Private IsBusy As Boolean = False
    Private Ldonhang As String = String.Empty
    Private Lmahang As String = String.Empty
    Private LKhachhang As String = String.Empty
    Private LLoaihang As String = String.Empty
    Private Lkhovai As String = String.Empty
    Private Lmetkg As String = String.Empty
    Private LMaMau As String = String.Empty
    Private LTenmau As String = String.Empty
    Private LMaCongNghe As String = String.Empty
    Private LGhichu_moc As String = String.Empty
    Private LGhichu_dieudosx As String = String.Empty
    Private LGhichu_donhang As String = String.Empty
    Private LMaMe As String = String.Empty
    Private LMaMe_Ghep As String = String.Empty
    Private LMaMe_All As String = String.Empty
    Private LSocay As Int16 = 0
    Private LSokg As Single = 0
    Private LSomet As Single = 0
    Private LLoaiDay As String = String.Empty
    Public Property MaMe() As String
        Get
            Return LMaMe
        End Get
        Set(ByVal value As String)
            LMaMe = value
        End Set
    End Property

#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        dt_local_detail.Dispose()
        Me.Dispose()
        '--
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtControler = New KhoSanXuatDAL
        dt_local = New DataTable
        dt_local_detail = New DataTable
        dt_kieuxuat = New DataTable
        '/
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        '//
        '//
        Load_KieuXuat_CTXuat()
        '//
        AddHandler tpress.Tick, AddressOf MyTickHandler
    End Sub
    Private Sub Load_KieuXuat_CTXuat()
        dt_kieuxuat = VpsXmlList_Load("", "", "khosanxuat_mucdich")
        LoadDataToCombox(dt_kieuxuat, cboKieuXuat, "mucdich", False)
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtmame.Focus()
    End Sub
    Private Sub frmInphieunhuom_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtmame.Text = LMaMe
    End Sub

#Region "LOAD FORMAT"
    Dim _MyFont_Header_dgv As New Font("Time New Roman", 13, FontStyle.Bold)
    Dim _MyFont_dgv As New Font("Time New Roman", 13, FontStyle.Regular)
    Private Sub Format_SuperGrid()
        Super_Dgv_Info.Dock = DockStyle.Fill
        '//
        Dim panel As GridPanel = TryCast(Super_Dgv_Info.PrimaryGrid, GridPanel)
        With panel
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
        End With
    End Sub

    Private Sub Add_Data()
        Dim panel As GridPanel = TryCast(Super_Dgv_Info.PrimaryGrid, GridPanel)
        With panel
            .BeginDataUpdate()
            If .Rows.Count = 0 Then
                'panel.Rows.Add(GetNewRow("Giờ Vào", Now, 1))
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

#End Region

    Private Sub txtmame_chung_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmame.KeyDown
        If e.KeyCode = Keys.Enter Then
            wait(200)
            txtmame.Focus()
        End If
    End Sub

#Region "CHI TIET ME NHUOM"

    Private Sub Filter_MocNhuom()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame.Text.Trim) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_InMeNhuom_2021]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        If dt_local.Rows.Count > 0 Then
            With Super_Dgv_Info
                _mame_id = dt_local.Rows(0).Item("mame_id").ToUpper
                Ldonhang = dt_local.Rows(0).Item("donhang").ToUpper
                Lmahang = dt_local.Rows(0).Item("mahang").ToUpper
                LKhachhang = dt_local.Rows(0).Item("khachhang").ToUpper
                LLoaihang = dt_local.Rows(0).Item("loaihang").ToUpper
                Lkhovai = dt_local.Rows(0).Item("khovai").ToUpper
                Lmetkg = dt_local.Rows(0).Item("metkg").ToUpper
                LMaMau = dt_local.Rows(0).Item("mamau").ToUpper
                LTenmau = dt_local.Rows(0).Item("tenmau").ToUpper
                LMaMe = dt_local.Rows(0).Item("mame").ToUpper
                LMaMe_Ghep = dt_local.Rows(0).Item("mame_ghep").ToUpper
                txtmame_ghep.Text = dt_local.Rows(0).Item("mame_all").ToUpper
                LGhichu_moc = dt_local.Rows(0).Item("ghichu_moc").ToUpper
                LGhichu_dieudosx = dt_local.Rows(0).Item("ghichu_ddsx").ToUpper
                LGhichu_donhang = dt_local.Rows(0).Item("canhbao_donhang").ToUpper
                'Them <br/> để xuống dòng
                Dim stinfo As String = "<b><font size=""16""><font color=""blue"">{0}</font></font></b>" 'ĐƠN HÀNG
                stinfo &= "<font size=""16""><font color=""Black""> {1} </font></font><br/>"
                .PrimaryGrid.Caption.Text = String.Format(stinfo, "+ ĐƠN HÀNG: ", Ldonhang)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ MÃ HÀNG: ", Lmahang)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ KHÁCH HÀNG: ", LKhachhang)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ LOẠI HÀNG: ", LLoaihang)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ KHỔ: ", Lkhovai)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ T.LƯỢNG: ", Lmetkg)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "======================", "")
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ MÃ MÀU: ", LMaMau)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ TÊN MÀU: ", LTenmau)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "======================", "")
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ MÃ MẺ: ", LMaMe & " / " & LMaMe_Ghep)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ SỐ CÂY: ", 0)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ SỐ KG: ", 0)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ SỐ MÉT: ", 0)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "======================", "")
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ GHI CHÚ KHO MỘC: ", LGhichu_moc)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "======================", "")
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ GHI CHÚ ĐĐSX: ", LGhichu_dieudosx)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "======================", "")
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ CẢNH BÁO: ", LGhichu_donhang)
                .PrimaryGrid.Caption.Text &= String.Format(stinfo, "======================", "")
                If Convert.ToBoolean(dt_local.Rows(0).Item("ismenhuom_chuyenmau")) = True Then
                    .PrimaryGrid.Caption.Text &= String.Format(stinfo, "+ CẢNH BÁO: ", "MẺ CHUYỂN MÀU")
                End If
                txtmacongnghe.Text = dt_local.Rows(0).Item("macongnghe").ToUpper
                'Add_Data()
                '////
            End With
        End If

    End Sub
#Region "SUM"

    Dim _array_column As String() = {"socaytt", "sokgtt", "somettt"}
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
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        '--
        _stName = "Theo_DauKy"
        _stHeadText = "Số Lượng"
        _stCol1 = "socaytt"
        _stCol2 = "somettt"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_NhapTk"
        _stHeadText = "Mã CN"
        _stCol1 = "macongnghe"
        _stCol2 = "macongnghe_tt"
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("macay")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        Else
            panel.SetSort(sortCols, GetSortDirAscDesc(sortCols))
        End If
        '//

        tpress.Enabled = True
    End Sub
    Public Function GetSortDirAscDesc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection)})
    End Function
#End Region

    Private Sub txtmame_chung_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmame.TextChanged
        If _istxtJobProcessing Then Return
        'Set a flag so that we know that we are already processing.
        _istxtJobProcessing = True
        If Len(txtmame.Text) > 4 Then
            Call Filter_MocNhuom()
        End If
        _istxtJobProcessing = False
    End Sub

#Region "XUAT DI SAN XUAT"
    Private Sub BtnXacNhan_SanXuat_Click(sender As Object, e As EventArgs) Handles BtnXacNhan_SanXuat.Click
        Dim btn As Button = CType(sender, Button)
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
            .Location = New Point(CInt((GroupBox2.Width / 2) - (.Width / 2)), CInt((GroupBox2.Height / 2) - (.Height / 2)))
            .Visible = True
        End With
    End Sub

    Private Sub btnThoat_GP_Form_CTXuat_Click(sender As Object, e As EventArgs) Handles btnThoat_GP_Form_CTXuat.Click
        GP_Form_ChungTuXuat.Visible = False
    End Sub
    Private Sub BtnCapNhat_XuatSX_Click(sender As Object, e As EventArgs) Handles BtnCapNhat_XuatSX.Click
        '--Kiem Tra Kieu xuat
        dr2 = dt_kieuxuat.Select("mucdich = '" & cboKieuXuat.Text & "'", "")
        If dr2.Length > 0 Then
            _stMakytu_xuat = dr2.First.Item(1)
            _kieuxuat_id = dr2.First.Item(0)
        End If
        If MsgBox("Bạn có muốn thực hiện cập nhật?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(_mame_id) + "' ")
        sbXMLString.Append("kieuxuat_id='" + ReplaceTextXML(_kieuxuat_id) + "' ")
        sbXMLString.Append("chungtuxuat_noibo='" + ReplaceTextXML(txtchungtuxuat.Text.Trim) + "' ")
        sbXMLString.Append("dtngayxuat_sanxuat='" + Format$(dtNgayXuat_SX.Value, "MM/dd/yyyy HH:mm:ss") + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_XuatNhuom")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filter_MocNhuom()
    End Sub

#End Region


#Region "EXCEL"
    Private Sub btnInPhieu_Click(sender As Object, e As EventArgs) Handles btnInphieu.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        If Super_Dgv.PrimaryGrid.Rows.Count = 0 Then
            Exit Sub
        End If
        '--
        Dim btn As Button = CType(sender, Button)
        With btn
            .Text = "Xin Chờ..."
            .Enabled = False
            '//Lay ID File Excel
            Dim LFileName As String = String.Empty
            Dim LFolder_Path As String = String.Empty
            Dim dtExcel As DataTable = VpsXmlList_Load_Title("", "F001", "[VpsXmlList_InfoExcel_UpSet]", "select_id")
            If dtExcel.Rows.Count = 1 Then
                LFolder_Path = dtExcel.Rows(0).Item("folder_path")
                LFileName = dtExcel.Rows(0).Item("fileexcel")
                Call Export_Excel_Chitiet(LFolder_Path, LFileName, True)
                '//
                sbXMLString = New StringBuilder()
                sbXMLString.Append("<Root>")
                sbXMLString.Append("<DATA ")
                sbXMLString.Append("mame_id='" + ReplaceTextXML(_mame_id) + "' ")
                sbXMLString.Append(" />")
                '//
                sbXMLString.Append("</Root>")
                '//
                _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_UpSet_2021]", sbXMLString.ToString, "update_InPhieuNhuom")
                dtControler.UPSET_XML(_dt)
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
            objSheet = objWorkbook.Sheets("PhieuSanXuat")
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
                    .Value = "MÃ CN: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T11") 'Qui Trình
                    .Value = txtmacongnghe.Text
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '//
                With .Range("S12")
                    .Value = "GHI CHÚ MỘC: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T12")
                    .Value = LGhichu_moc
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With

                '//
                With .Range("S13")
                    .Value = "GHI CHÚ ĐĐSX: "
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T13")
                    .Value = LGhichu_dieudosx
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
                    strText = "Loại Dây: "
                    '.Value = LLoaiDay
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T17")
                    .Value = LLoaiDay
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '///
                With .Range("S18")
                    strText = "Mẻ Ghép: "
                    '.Value = LLoaiDay
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T18")
                    .Value = txtmame_ghep.Text
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                '///
                With .Range("S19")
                    strText = "Cảnh Báo: "
                    '.Value = LLoaiDay
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                With .Range("T19")
                    .Value = LGhichu_donhang
                    .Characters(Start:=1, Length:=strText.Length).Font.FontStyle = "Bold"
                End With
                _TongDong = 0
                Super_Dgv.SuspendLayout()
                Dim y As Integer = 0
                For Each item As GridElement In panel.Rows
                    Dim row As GridRow = TryCast(item, GridRow)
                    If row IsNot Nothing AndAlso row.Visible = True Then
                        If intdong < 20 Then
                            .Cells(_LRow_1 + _Lsub_Int_Startrow, "B").Value = row.Cells("xuly1").Value
                            .Cells(_LRow_1 + _Lsub_Int_Startrow, "C").Value = "'" & row.Cells("macay").Value
                            If ChkInMet.CheckState = CheckState.Unchecked Then
                                .Cells(_LRow_1 + _Lsub_Int_Startrow, "D").Value = row.Cells(_colsokgM).Value
                            Else
                                .Cells(_LRow_1 + _Lsub_Int_Startrow, "D").Value = row.Cells(_colsometM).Value
                            End If
                            .Cells(_LRow_1 + _Lsub_Int_Startrow, "E").Value = row.Cells("ghichu_moc").Value
                            _LRow_1 += 1
                            intdong += 1
                        End If

                    End If
                Next
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