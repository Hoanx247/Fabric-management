Imports System.IO
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.SqlClient.SqlException
'--

Imports System.Xml
Imports System.Drawing

Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text
Imports System.Net
Imports Microsoft.Office.Interop

Public Class frmNhapMoc_CanMoc

    Private ClsReadFile As New ClsReadFile
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private moCls As Clsconnect
    '//
    Private dtControler As KhoMocNhapKhoDAL
    Private _dt As KhoMocNhapKhoDTO
    Private dt_local As DataTable
    Private dt_kieunhap As DataTable
    Dim dt_local_ALL As DataTable
    Dim dt_chungtu As DataTable
    Dim dt_kytu_macay As DataTable
    Dim dt_macay As DataTable

    Dim _ColorPick As String = String.Empty
    Dim dt_RGB As DataTable
    '--
    Dim _XLL As SByte = 0
    '---resize form
    Dim intmame As Integer = 0, _intMacay As Integer = 0
    Dim dblkhoiluongcan As Double = 0
    Dim dv As DataGridView
    Dim intChophepluu As Integer = 0, _Bit_doccan As Boolean = False
    Dim bln_chungtu As Boolean = False, bln_mame As Boolean = False
    Dim _bln_Saving As Boolean = False
    Private _bln_mame As Boolean = False
    Dim _blnThoat As Boolean = False
    '--
    Dim Replace_Chars_1 As String() = New String() {" ", "=ACDEF+,USTNGW:gkB@"}
    Dim stGet_1 As String = String.Empty
    '---
    Dim Replace_Chars_2 As String() = New String() {" ", "SUTGgN,"}
    Dim stGet_2 As String = String.Empty
    '--
    Private WithEvents moRS232_1 As Rs232_1
    Private WithEvents moRS232_2 As Rs232_2
    Private miComPort_1 As Integer, miComPort_2 As Integer
    'Private Delegate Sub CommEventUpdate(ByVal source As Rs232, ByVal mask As Rs232.EventMasks)
    Private _Program_scale As Int16 = 0
    Dim _blnStop_Scale_1 As Boolean = False, _Bln_Chophepluu_1 As Boolean = False
    Dim _blnStop_Scale_2 As Boolean = False, _Bln_Chophepluu_2 As Boolean = False

    Private _lst_buffer_1 As String = String.Empty, _lst_buffer_2 As String = String.Empty
    Private _buffer_1 As StringBuilder = New StringBuilder
    Private _buffer_2 As StringBuilder = New StringBuilder
    Private _array_char_1(512) As Integer, _array_char_2(512) As Integer
    Private _lblnProcess_1 As Boolean = False, _lblnProcess_2 As Boolean = False

    Private _Lst_Sophieu As String = String.Empty
    Private _Lma_Barcode As String = String.Empty
    Private _Lbln_ChoPhep_Can As Boolean = False
    Private _lInt_Hoachat_Chuacan As Integer = 0, _lInt_Hoachat_TongSo As Integer = 0

    Private _LOpen_Com1 As Boolean = False, _LClose_Com1 As Boolean = False
    Private _LOpen_Com2 As Boolean = False, _LClose_Com2 As Boolean = False

    Private _Ltest_stBuilder_1 As StringBuilder = New StringBuilder
    Private _Ltest_stBuilder_2 As StringBuilder = New StringBuilder
    Private _sngKL_stable_1 As Single = 0, _sngKL_stable_2 As Single = 0

    Private _TongcayTT As Integer = 0
    Private _TongKg As Single = 0
    Dim _Lsub_Count As Integer = 0, _Lsub_Count_1 As Integer = 0
    Dim _Lsub_Count_2 As Integer = 0, _Lsub_Count_3 As Integer = 0
    Dim _Bit_XacNhan_HoaChat As Boolean = False
    Private _buffer_1_text As String = String.Empty
    Private _buffer_2_text As String = String.Empty
    Dim _sngKL_Scale1 As Single = 0, _sngKL_Scale2 As Single = 0
    Dim _sngKL_Scale1_1 As Single = 0, _sngKL_Scale1_2 As Single = 0, _sngKL_Scale2_1 As Single = 0, _sngKL_Scale2_2 As Single = 0
    Dim _sngKLCan1_truoc As Single = 0, _sngKLCan2_truoc As Single = 0
    Dim _scale_1_Temp_1 As String = String.Empty, _scale_2_Temp_1 As String = String.Empty
    Dim _scale_1_Temp_2 As String = String.Empty, _scale_2_Temp_2 As String = String.Empty
    '///
    Dim _Bit_Stop_Scale_1 As Boolean = False
    Dim _scale_1_Temp As String = String.Empty
    '--
    Dim _IntTongmacay As Integer = 0
    Dim dr2 As DataRow()
    Private IsBusy As Boolean = False
    Private IsLoaded_Finished As Boolean = False
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"frmnamefull", "formgroup", "stt"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private LChungtu_id As String = String.Empty
    Private LMakhach_id As String = String.Empty
    Private LMahang_id As String = String.Empty
    Private LMucDich_id As String = String.Empty
    Private Lmame_id As String = String.Empty
    Private LMaKyTu As String = String.Empty
    Private LdtNgayNhap As DateTime
    Private DgvData As DataGridView = New DataGridView()
    'Scale 1
    Dim scale1Comport As String = String.Empty, scale1Baudrate As String = String.Empty, scale1Parity As String = String.Empty
    Dim scale1Databit As String = String.Empty, scale1Stopbit As String = String.Empty, scale1Reserve As String = String.Empty
    Dim scale1Use As String = String.Empty, scale1ReadBytes As String = String.Empty, scale1Mode As String = String.Empty
    Dim scale1Tolerance As String = String.Empty
    Dim scale1_STX As Integer = 0
    'Scale 2
    Dim scale2Comport As String = String.Empty, scale2Baudrate As String = String.Empty, scale2Parity As String = String.Empty
    Dim scale2Databit As String = String.Empty, scale2Stopbit As String = String.Empty, scale2Reserve As String = String.Empty
    Dim scale2Use As String = String.Empty, scale2ReadBytes As String = String.Empty, scale2Mode As String = String.Empty
    Dim scale2Tolerance As String = String.Empty
    '--
    Dim scale2_STX As Integer = 0
    Dim scale2_Solap As Integer = 0
    Dim _scale_2_Temp As String = String.Empty
    Dim _blnScale1_Use As Boolean = False, _blnScale2_Use As Boolean = False
    '--
#Region " Load du liệu lên bảng khi mở Form"


    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If scale2Use = "1" Then
            If Not moRS232_2 Is Nothing Then
                '// Disables Events if active
                moRS232_2.DisableEvents()
                If moRS232_2.IsOpen Then moRS232_2.Close()
            End If
        End If
        Dim st As String = String.Empty

        If _blnThoat = False Then
            e.Cancel = True
            MessageBox.Show("Xin Vui Lòng Bấm Nút Thoát!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            dt_local_ALL.Dispose()
            dt_chungtu.Dispose()
            dt_kytu_macay.Dispose()
            dt_local.Dispose()
            dt_RGB.Dispose()
            Me.Dispose()
        End If
    End Sub

    Private Sub Me_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F8 Then
            If chk_Cantay.CheckState = CheckState.Unchecked Then
                'If intChophepluu = 1 Then
                Call btnLuu_Click(Nothing, Nothing)
                'Else
                'My.Computer.Audio.Play(MdlData.str_path & "\Stop.wav", AudioPlayMode.Background)
                'End If
            Else
                Call btnLuu_Click(Nothing, Nothing)
            End If

        End If
    End Sub

    Private Sub Me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoMocNhapKhoDAL
        moCls = New Clsconnect
        '// 
        '--
        dt_chungtu = New DataTable
        dt_local = New DataTable
        dt_RGB = New DataTable
        dt_kytu_macay = New DataTable
        dt_local_ALL = New DataTable
        dt_macay = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        'AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        '//
        With Super_Dgv.PrimaryGrid
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = Tbool.True
            .GroupHeaderClickBehavior = GroupHeaderClickBehavior.ExpandCollapse
        End With
        '//

        Call Read_xmlScale()
        '--
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        Local_List_Kytu_macay()
        Call Filterdata_Tim_Macay()

        'Call Load_Maydet()
        ChkIntem.Checked = False

        Dim panel As GridPanel = frmnhapmoc.Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        '--
        With dgvr
            LChungtu_id = dgvr.Cells(_colchungtunhap_ID).Value
            txtchungtu.Text = dgvr.Cells(_colchungtunhap).Value
            txtkhachhang.Text = dgvr.Cells(_colkhachhang).Value
            txtmahang.Text = dgvr.Cells(_colmahang).Value
            txtloaihang.Text = dgvr.Cells(_colloaihang).Value
            'txtmadet.Text = dgvr.Cells("madet").Value
            txttongcay.Text = dgvr.Cells(_colsocay).Value
            LdtNgayNhap = dgvr.Cells(_coldtngaynhap).Value
            LMahang_id = dgvr.Cells(_colMahang_ID).Value.ToString
            LMucDich_id = dgvr.Cells("mucdich_id").Value.ToString
            txtghichu.Text = dgvr.Cells(_colnoidung).Value
            txtmucdich.Text = dgvr.Cells(_colmucdich).Value
            LMaKyTu = dgvr.Cells(_colmakytu).FormattedValue.ToString
            '//
            Call Filter_data_Chungtu()
            IsLoaded_Finished = True

            '--
            If _LClose_Com2 = False Then
                Call Connect_scale_2()

            End If
            '//
        End With

    End Sub



#End Region

#Region "MOC SAN XUAT"
    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = CType(sender.PrimaryGrid, GridPanel)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            'ShowContextMenu(CtxFunction)
        End If
        '//
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then Exit Sub
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
        ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
            panel.AllowEdit = False
            panel.ReadOnly = True
        End If
    End Sub
    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        clsDev.SuperDgv_CellValueChanged(sender, e)
    End Sub
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

    Private Sub Filter_data_Chungtu()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        'Try
        'Call CircleProcess_Start()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("chungtunhap_id='" + ReplaceTextXML(LChungtu_id) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoMocNhapKhoDTO("[VpsXmlKhoMoc_CanMoc_ChungTuID_GetData_2021]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        'Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"sokgmoc", "sometmoc"}
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
                        If ExistsColumnGridPanel(panel, "chon_mau") = True Then
                            If CBool(row.Cells("chon_mau").Value) = True Then
                                row.Cells("chon_mau").CellStyles.Default.Background.Color1 = System.Drawing.ColorTranslator.FromHtml(row.Cells("chon_mau").Value)
                            End If
                        End If
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

        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        '--
        _stName = "Theo_ChungTu"
        _stHeadText = "Chứng Từ"
        _stCol1 = _colsocay
        _stCol2 = _colsomet
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_ThucNhap"
        _stHeadText = "ThucNhap"
        _stCol1 = "socaytt"
        _stCol2 = "somettt"
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mame"), panel.Columns("mame"), panel.Columns("macay")}
        If panel.SortColumns.Count = 2 Then
            panel.SetSort(sortCols, clsDev.GetSortDirDescDescAsc(sortCols))
        Else
            panel.SetSort(sortCols, clsDev.GetSortDirDescDescAsc(sortCols))
        End If
        '//
        panel.AddGroup(panel.Columns("c_mame_temp"))
        '//
        _List_group = {}
        _List_group = _List_group.Concat({txtmame.Text}).ToArray
        '//
        '--

        'tpress.Enabled = True
    End Sub

#Region "SuperGridControl1GetGroupDetailRows"

    Private Sub Super_Dgv_GroupHeaderClick(sender As Object, e As GridGroupHeaderClickEventArgs) Handles Super_Dgv.GroupHeaderClick
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        '_List_group = {}
        'Super_Dgv_GroupHeader_Group(panel.Rows)

    End Sub

    Private Sub Super_Dgv_GroupHeader_Group(ByVal rows As IEnumerable(Of GridElement))
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                '////
                Dim _GroupValue As String = String.Empty
                Dim _GroupValue_Parent_name As String = String.Empty
                Dim _GroupValue_Parent As GridGroup = TryCast(group.Parent, GridGroup)
                If _GroupValue_Parent IsNot Nothing Then
                    _GroupValue_Parent_name = _GroupValue_Parent.GroupValue.ToString
                    _GroupValue = _GroupValue_Parent_name & "-" & group.GroupValue.ToString
                Else
                    _GroupValue_Parent_name = String.Empty
                    _GroupValue = group.GroupValue.ToString
                End If

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
                '--
                Dim _items As Integer = clsDev.Total_Row(e.GridGroup)
                '//
                Dim stInfo As String = "<b><font size=""12""><font color=""black""> MÃ MẺ: {0}    </font></font></b>" ' MA MAY
                stInfo &= "<b><font size=""12""><font color=""blue"">    [ {1} (CÂY) ||  </font></font></b>" 'socay
                stInfo &= "<b><font size=""12""><font color=""red"">    {2} (KG)  ]  </font></font></b>" 'sokg
                stInfo &= "<b><font size=""12""><font color=""blue"">   {3} (MÉT) ] </font></font></b>"


                If e.GridGroup.Column.Name.ToString.ToUpper = "c_mame_temp".ToString.ToUpper Then
                    _TongcayTT = _items
                    'e.GridGroup.GroupHeaderVisualStyles.Default.TextColor = Color.Blue
                    e.GridColumn.EnableGroupHeaderMarkup = True
                    e.GridGroup.Text = String.Format(stInfo, e.GridGroup.GroupValue.ToString.ToUpper, FormatNumber(_items, 0), FormatNumber(_Gnumber_group(0), 1), FormatNumber(_Gnumber_group(1), 1))
                    'e.GridGroup.GroupHeaderVisualStyles.Default.Background.Color1 = Color.LawnGreen
                    row.Cells(0).Value = Nothing
                    detailRows.Add(row)
                    e.DetailRows = detailRows
                End If

                row.CellStyles.[Default].Font = _MyFont_group
                '--
                'For i As Integer = 0 To panel.Columns.Count - 1
                'row.Cells(i).CellStyles.[Default].Background = _BackColor(0)
                'Next
                ' Just for grins, let's add some color to make the
                ' totals association more readily obvious to the user
            End If
        End If
    End Sub

#End Region

#End Region

    Private Sub cap_nhat_data()

        If CInt(txttongcay.Text) > _TongcayTT Then
            Try
                Call Update_Data_Nhapmoc()
            Catch ex As Exception
                My.Computer.Audio.Play(MdlData.str_path & "\Stop.wav", AudioPlayMode.Background)
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            If MsgBox("Đã Quá Số Cây. Bạn có muốn tiếp tục?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo") = MsgBoxResult.Yes Then
                Call Update_Data_Nhapmoc()
            End If
        End If

    End Sub

    Private Sub Update_Data_Nhapmoc()
        Dim sqlcommand As String = String.Empty
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("chungtunhap_id='" + ReplaceTextXML(LChungtu_id) + "' ")
        sbXMLString.Append("c_mame_temp='" + ReplaceTextXML(txtmame.Text) + "' ")
        sbXMLString.Append("macay='" + ReplaceTextXML(txtmacay.Text.Trim) + "' ")
        If ChkXeBien.CheckState = CheckState.Checked Then
            sbXMLString.Append("xuly1='" + ReplaceTextXML("XB") + "' ")
        Else
            sbXMLString.Append("xuly1='" + ReplaceTextXML("") + "' ")
        End If

        sbXMLString.Append("xuly2='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("ghichu_moc='" + ReplaceTextXML(txtghichu_chitiet.Text) + "' ")
        sbXMLString.Append("sokgmoc='" + CNumber_system(txtScale1.Text) + "' ")
        sbXMLString.Append("sometmoc='" + CNumber_system(txtsometmoc.Text) + "' ")
        sbXMLString.Append("mauvai_moc='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("tenmaydet='" + ReplaceTextXML(txtmaydet.Text) + "' ")

        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoMocNhapKhoDTO("[vpsXmlKhoMoc_NhapKho_Chitiet_UPSET_2021]", sbXMLString.ToString, "insert")
        If dtControler.UPSET_XML(_dt) = True Then
            If ChkIntem.CheckState = CheckState.Checked Then
                cmdPrint()
            End If

            '//
            Call Filter_data_Chungtu()

            '/// tANG MA CAY
            If Len(txtmacay.Text) = 6 Then
                Dim stMaCay As String = txtmacay.Text
                Dim _stt As String = "000" & CInt(gRight(txtmacay.Text, 3)) + 1
                txtmacay.Text = gLeft(stMaCay, 3) & gRight(_stt, 3)
            End If

        End If


    End Sub


#Region " XU LY MA CAY - AUTO INCREATE"

    Private Sub Local_List_Kytu_macay()
        dt_kytu_macay = VpsXmlList_Load("", "", "kytu_macay")
    End Sub

    Private Sub btnRefresh_Macay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh_Macay.Click
        Call Filterdata_Tim_Macay()
    End Sub

    Private Sub BtnThoat_Click(sender As Object, e As EventArgs) Handles BtnThoat.Click
        _blnThoat = True
        Me.Close()
    End Sub

    Private Sub Filterdata_Tim_Macay()
        Dim _macay_Find As String
        Dim _stt As String = String.Empty
        If txtmacay.Text.Trim.Length = 0 Then
            Call Load_TimeServer()
            _Nam = Mid$(_TimeServer.Year.ToString, 4, 1)
            _thang = KyTu_Thang(_TimeServer.Month)
            txtmacay.Text = _Nam & _thang & "A001"
        End If
        _macay_Find = Mid(txtmacay.Text, 1, 2)
        Try
            dt_macay = VpsXmlList_Load(_macay_Find, "", "macay")
            DataGridView2.DataSource = dt_macay
            If dt_macay.Rows.Count > 0 Then
                _macay_Find = dt_macay.Rows(0).Item("code")
                If CInt(gRight(_macay_Find, 3)) = 999 Then
                    'Call btnNext_Click(Nothing, Nothing)
                    '//Xử Lý Nhảy Cây

                Else
                    _stt = "000" & CInt(gRight(_macay_Find, 3))
                    txtmacay.Text = gLeft(_macay_Find, 3) & gRight(_stt, 3)
                End If
            Else
                txtmacay.Text = _Nam & _thang & "A001"
            End If
            '--
        Catch ex As Exception
            MessageBox.Show("Vui Lòng Bấm Next để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPre.Click
        Dim _sothutu As Integer = 0
        Call Load_TimeServer()
        _Nam = Mid$(_TimeServer.Year.ToString, 4, 1)
        _thang = KyTu_Thang(_TimeServer.Month)
        '--
        Dim _st As String = Mid(txtmacay.Text, 3, 1)
        Dim _st1 As String = String.Empty
        '--Kiem Tra Kieu Nhap
        Dim row As DataRow = dt_kytu_macay.Select("kytu_macay = '" & _st & "'", "sothutu asc").FirstOrDefault()
        If Not row Is Nothing Then
            _sothutu = CInt(row.Item("sothutu"))
            If _sothutu > 1 Then
                _sothutu = _sothutu - 1
                wait(20)
                _st1 = dt_kytu_macay.Rows(_sothutu).Item("kytu_macay").ToString
            ElseIf _sothutu > 33 Then
                _st1 = "A"
            End If
        Else
            _st1 = "A"
        End If
        txtmacay.Text = _Nam & _thang & _st1 & "001"
        wait(20)
        Call Filterdata_Tim_Macay()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Dim _st As String
        Dim _sothutu As Integer = 0
        Call Load_TimeServer()
        _Nam = Mid$(_TimeServer.Year.ToString, 4, 1)
        _thang = KyTu_Thang(_TimeServer.Month)
        '--
        _st = Mid(txtmacay.Text, 3, 1)
        '--Kiem Tra Kieu Nhap

        dr2 = dt_kytu_macay.Select("kytu_macay = '" & _st & "'", "")
        If dr2.Length = 0 Then
            _sothutu = 0
        Else
            _sothutu = Convert.ToInt32(dr2.First.Item("sothutu"))
            wait(20)
            If _sothutu < 34 Then
                _sothutu = _sothutu + 1
                wait(20)
                _st = dt_kytu_macay.Rows(_sothutu).Item("kytu_macay").ToString
            ElseIf _sothutu > 34 Then
                _st = "A"
            End If
        End If
        txtmacay.Text = _Nam & _thang & _st & "001"
        wait(20)
        Call Filterdata_Tim_Macay()
    End Sub

#End Region

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnXoaCay.Click
        Dim stmacay As String = String.Empty
        Dim stmame_id As String = String.Empty
        Dim _intMinute As Int32 = 0
        Dim _GioTao As DateTime
        If MsgBox("Bạn có muốn xóa nội dung không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo") = MsgBoxResult.Yes Then
            '_GioTao = .CurrentRow.Cells("dtnhapmoc").Value
            'stma = .CurrentRow.Cells("macay").Value
            '_intMinute = DateDiff(DateInterval.Minute, _GioTao, Now)
            If _intMinute > 3000 Then
                'MessageBox.Show("Vui Lòng Liên Hệ Trưởng Ca.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else

            End If

            Dim panel As GridPanel = Super_Dgv.PrimaryGrid
            Dim dgvr As GridRow = panel.ActiveRow
            '--
            If dgvr Is Nothing Then Exit Sub
            With dgvr
                stmacay = dgvr.Cells("macay").Value
            End With
            '///
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            '//
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("macay='" + ReplaceTextXML(stmacay) + "' ")
            sbXMLString.Append(" />")
            '//
            sbXMLString.Append("</Root>")
            '//
            _dt = New KhoMocNhapKhoDTO("[vpsXmlKhoMoc_NhapKho_Chitiet_UPSET_2021]", sbXMLString.ToString, "delete")
            dtControler.UPSET_XML(_dt)

            Call Filter_data_Chungtu()
        End If
    End Sub

    Private Sub BtnLuuLai_Click(sender As Object, e As EventArgs) Handles BtnLuuLai.Click
        btnLuu_Click(Nothing, Nothing)
    End Sub

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myString As String = LMaKyTu
        Dim numberString As String = String.Empty

        If myString.Contains("LKT") Then
            Call cap_nhat_data()
        Else
            If CSng(txtScale1.Text) > 0 And Len(txtmacay.Text) >= 6 Then
                Call cap_nhat_data()
            End If
        End If


    End Sub

    Private Sub btnAp_Mau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim stma As String = String.Empty
        Dim st As String
        If MsgBox("Bạn có muốn CHUYỂN MÀU không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo") = MsgBoxResult.Yes Then

            Call Filter_data_Chungtu()
            'End With

        End If
    End Sub

    Private Sub btnTim_Macay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Filterdata_Tim_Macay()
    End Sub


#Region "Tim kiem thong tin"

#Region "MA ME"
    Private Sub txtmame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        _bln_mame = True
        If _bln_mame = True Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
                DgvData.Focus()
            End If
        End If
    End Sub

    Private Sub txtmame_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If _bln_mame = True Then
            Dim txt As TextBox = CType(sender, TextBox)
            Dim pnPopup As Panel = PnPopup_List
            pnPopup.Controls.Add(DgvData)
            'Me.Controls.Add(pnPopup)

            AddHandler DgvData.CellClick, AddressOf DgvMaHang_CellClick
            AddHandler DgvData.KeyDown, AddressOf DgvMaHang_KeyDown

            If Len(txt.Text) > 0 Then
                'moClsDatagridView.VpsList_LenhSanXuat_Nhuom(txt.Text, txtmahang.Text, DgvData)
                VpsList_Menu_2Var(txt.Text, txtmahang.Text, "[VpsXmlKhoSanXuat_MeNhuom_Find_2021]", "select", DgvData)
                '// 
                Dim ucDscreenCoords = txt.PointToScreen(New Point(0, 0))
                Dim ucDclientCoordsRelativeToA = Me.PointToClient(ucDscreenCoords)
                pnPopup.Location = New Point(ucDclientCoordsRelativeToA.X, ucDclientCoordsRelativeToA.Y + txt.Height)
                pnPopup.Size = New Size(CInt(Me.Width * 0.7), CInt(txt.Height * 7))
                pnPopup.Visible = True
                pnPopup.BringToFront()
                '--
            Else
                pnPopup.Visible = False
                _bln_mame = False
                Lmame_id = String.Empty

            End If
        End If
    End Sub



    Private Sub DgvMaHang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Call Load_Textbox_MaHang(sender)
    End Sub

    Private Sub DgvMaHang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Load_Textbox_MaHang(sender)
        End If
    End Sub

    Private Sub Load_Textbox_MaHang(ByVal Dgv As DataGridView)
        With Dgv
            If _bln_mame = True Then
                _bln_mame = False
                Lmame_id = ExistsColumn_Dgv(Dgv, "mame_id", "").ToString
                txtmame.Text = ExistsColumn_Dgv(Dgv, "mame", "").ToString
                'txtmahang_donhang.Text = ExistsColumn_Dgv(Dgv, "mahang", "").ToString
                'txtsocay_phanme.Text = ExistsColumn_Dgv(Dgv, "socay", "").ToString
            End If
        End With
        RemoveHandler DgvData.CellClick, AddressOf DgvMaHang_CellClick
        RemoveHandler DgvData.KeyDown, AddressOf DgvMaHang_KeyDown
        PnPopup_List.Visible = False
    End Sub
#End Region
#End Region


#Region "COM232 - DOC DU LIEU"

    Private Sub Read_xmlScale()
        Dim _GFileName_SerialPort As String = My.Application.Info.DirectoryPath & "\Parameters.ini"
        If (IO.File.Exists("Parameters.ini")) Then
            '--
            Dim _lName As String = String.Empty
            scale1Comport = ClsReadFile.readIniFile("", "ComPort", _GFileName_SerialPort)
            _lName = "SCALE_1"
            scale1Comport = ClsReadFile.readIniFile(_lName, "ComPort", _GFileName_SerialPort)
            scale1Baudrate = ClsReadFile.readIniFile(_lName, "BaudRate", _GFileName_SerialPort)
            scale1Databit = ClsReadFile.readIniFile(_lName, "Databits", _GFileName_SerialPort)
            scale1Parity = ClsReadFile.readIniFile(_lName, "Parity", _GFileName_SerialPort)
            scale1Stopbit = ClsReadFile.readIniFile(_lName, "Stopbits", _GFileName_SerialPort)
            scale1Reserve = ClsReadFile.readIniFile(_lName, "Reverse", _GFileName_SerialPort)
            scale1Mode = ClsReadFile.readIniFile(_lName, "Mode", _GFileName_SerialPort)
            scale1Use = ClsReadFile.readIniFile(_lName, "Use", _GFileName_SerialPort)
            scale1ReadBytes = ClsReadFile.readIniFile(_lName, "Readbytes", _GFileName_SerialPort)
            scale1Tolerance = ClsReadFile.readIniFile(_lName, "Tolerance", _GFileName_SerialPort)
            miComPort_1 = scale1Comport.Substring(scale1Comport.Length - 1, 1)
            '--
            _lName = "SCALE_2"
            scale2Comport = ClsReadFile.readIniFile(_lName, "ComPort", _GFileName_SerialPort)
            scale2Baudrate = ClsReadFile.readIniFile(_lName, "BaudRate", _GFileName_SerialPort)
            scale2Databit = ClsReadFile.readIniFile(_lName, "Databits", _GFileName_SerialPort)
            scale2Parity = ClsReadFile.readIniFile(_lName, "Parity", _GFileName_SerialPort)
            scale2Stopbit = ClsReadFile.readIniFile(_lName, "Stopbits", _GFileName_SerialPort)
            scale2Reserve = ClsReadFile.readIniFile(_lName, "Reverse", _GFileName_SerialPort)
            scale2Mode = ClsReadFile.readIniFile(_lName, "Mode", _GFileName_SerialPort)
            scale2Use = ClsReadFile.readIniFile(_lName, "Use", _GFileName_SerialPort)
            scale2ReadBytes = ClsReadFile.readIniFile(_lName, "Readbytes", _GFileName_SerialPort)
            scale2Tolerance = ClsReadFile.readIniFile(_lName, "Tolerance", _GFileName_SerialPort)
            miComPort_2 = scale2Comport.Substring(scale2Comport.Length - 1, 1)
        Else
            MessageBox.Show("Vui lòng kiểm tra tên file.")
        End If
    End Sub


#Region "Scale 2"

    Private Sub Connect_scale_2()
        If scale2Use = "0" Then
            Exit Sub
        End If
        moRS232_2 = New Rs232_2()
        Try
            '// Setup parameters
            With moRS232_2
                .Port = miComPort_2
                .BaudRate = Int32.Parse(scale2Baudrate)
                .DataBit = Int32.Parse(scale2Databit)
                If Int32.Parse(scale2Stopbit) = 1 Then
                    .StopBit = Rs232_2.DataStopBit.StopBit_1
                Else
                    .StopBit = Rs232_2.DataStopBit.StopBit_2
                End If
                If scale2Parity = "Even" Then
                    .Parity = Rs232_2.DataParity.Parity_Even
                ElseIf scale2Parity = "Mark" Then
                    .Parity = Rs232_2.DataParity.Parity_Mark
                ElseIf scale2Parity = "None" Then
                    .Parity = Rs232_2.DataParity.Parity_None
                ElseIf scale2Parity = "Odd" Then
                    .Parity = Rs232_2.DataParity.Parity_Odd
                End If
                .Timeout = Int32.Parse(1500)
            End With
            '// Initializes port
            moRS232_2.Open()
            '// Set state of RTS / DTS
            moRS232_2.Dtr = False
            moRS232_2.Rts = True
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Connection Error", MessageBoxButtons.OK)
        Finally
            _LClose_Com2 = moRS232_2.IsOpen
            _LOpen_Com2 = Not moRS232_2.IsOpen
            Timer_ReadScale_2.Enabled = True
            'btnCloseCom.Enabled = moRS232.IsOpen
            'btnOpenCom.Enabled = Not moRS232.IsOpen
        End Try
    End Sub

    Private Sub DisConnect_scale_2()
        moRS232_2.Close()
        _LClose_Com2 = moRS232_2.IsOpen
        _LOpen_Com2 = Not moRS232_2.IsOpen
        'btnCloseCom.Enabled = moRS232.IsOpen
        'btnOpenCom.Enabled = Not moRS232.IsOpen
    End Sub
    Private Sub moRS232_2_Read_by_Step(sender As Object, e As EventArgs)
        'Try
        If _LClose_Com2 = True Then
            If _Program_scale = 0 Then
                moRS232_2.Read(7)
                '// Fills listbox with hex values
                Dim aBytes As Byte() = moRS232_2.InputStream
                Dim iPnt As Int32
                For iPnt = 0 To aBytes.Length - 1
                    _buffer_2.Append(Chr(aBytes(iPnt)))
                Next
            Else
                moRS232_2.Read(7)
                'txtghichu.Text = moRS232_1.InputStreamString
                'txtRx.ForeColor = Color.Black
                'txtRx.BackColor = Color.White
                '// Fills listbox with hex values
                'Dim aBytes As Byte() = moRS232.InputStream
                _buffer_2.AppendLine(moRS232_2.InputStreamString)

            End If
            Me.BeginInvoke(New MethodInvoker(AddressOf DoUpdate_sp_Big), _buffer_2)

        End If
        'Catch ex As Exception

        'End Try



    End Sub

    Private Sub DoUpdate_sp_Big()
        Try
            _Ltest_stBuilder_2 = _buffer_2
            '--
            _Ltest_stBuilder_2.Replace("=", vbLf)
            Rtx_2.Text = _Ltest_stBuilder_2.ToString
            Dim _stt As Integer = 0, _int_array As Integer = 0
            _stt = Rtx_2.Lines.Length
            '--
            _int_array = 0
            'For y = 0 To 4
            '_lArray_Scale2(5 - y) = _lArray_Scale2(4 - y)
            'Next
            'txtScale2.Text = _stt
            If _stt.ToString.Trim > 0 Then
                For i As Integer = 0 To Rtx_2.Lines.Length - 1
                    If Rtx_2.Lines(i).ToString.Trim.Length = 7 Then
                        _scale_2_Temp_1 = Rtx_2.Lines.GetValue(i).ToString.Trim
                        _scale_2_Temp_1 = Replace_String_2(_scale_2_Temp_1)
                        If scale2Reserve = "1" Then
                            _scale_2_Temp_1 = StrReverse(Remove_Multi_space(_scale_2_Temp_1.Trim))
                        End If
                        _scale_2_Temp_1 = Remove_Multi_space(_scale_2_Temp_1)
                        If IsNumeric(_scale_2_Temp_1) = True Then
                            _sngKL_Scale2_1 = CSng(_scale_2_Temp_1)
                            'If _int_array < 3 Then
                            '_lArray_Scale2(_int_array) = _sngKL_Scale2_1
                        End If
                        '_int_array += 1
                        '_sngKL_Scale2_1 = _sngKL_Scale2_1
                        'End If

                    End If
                Next
            End If
            '--Kiem tra on dinh can
            If Math.Abs(_sngKL_stable_2 - _sngKL_Scale2_1) > CSng(0.2) Then
                _sngKL_stable_2 = _sngKL_Scale2_1
                '_sngKL_Scale2_1 = _sngKL_stable_2 * 1000
                Timer_Save_2.Enabled = False
                _Bln_Chophepluu_2 = False
            Else
                Timer_Save_2.Enabled = True
            End If

            _Lsub_Count = _buffer_2.Length - 1
            _Lsub_Count_1 = _Lsub_Count - 30
            If _Lsub_Count > 32 Then
                _buffer_2.Remove(0, _Lsub_Count_1)
            End If
            If chk_Cantay.CheckState = CheckState.Unchecked Then
                AppendTextBox_2(txtScale1, _sngKL_stable_2)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Thông Báo")
        End Try
    End Sub


    Private Function Replace_String_2(ByVal str As String) As String
        'stGet = str
        For i As Integer = 1 To Replace_Chars_2.Length - 1
            For j As Integer = 0 To Replace_Chars_2(i).Length - 1
                str = str.Replace(Replace_Chars_2(i)(j), Replace_Chars_2(0)(i - 1))
            Next
        Next
        stGet_2 = str.Replace(" ", "")
        Return stGet_2
    End Function

#End Region

    Private Delegate Sub AppendTextBoxDelegate_2(ByVal TB As TextBox, ByVal txt As Single)

    Private Sub AppendTextBox_2(ByVal TB As TextBox, ByVal txt As Single)
        If TB.InvokeRequired Then
            TB.Invoke(New AppendTextBoxDelegate_2(AddressOf AppendTextBox_2), New Object() {TB, txt})
        Else
            TB.Text = FormatNumber(txt, 1)
            '_sngKL_Scale2 = CSng(txt)
        End If
    End Sub

    Private Sub Timer_ReadScale_2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_ReadScale_2.Tick
        Timer_ReadScale_2.Enabled = False
        Call moRS232_2_Read_by_Step(Nothing, Nothing)
        Timer_ReadScale_2.Enabled = True
    End Sub
    Private Sub Timer_Save_2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Save_2.Tick
        Timer_Save_2.Enabled = False
        _Bln_Chophepluu_2 = True
    End Sub
#End Region

#Region "IN TEM - IN PHIẾU"

    Private Sub Export_Excel_Chitiet(ByVal strSaveFilename As String, ByVal blnIsVisible As Boolean)
        Dim strFileName As String = My.Application.Info.DirectoryPath & "\TEM\" & strSaveFilename
        If System.IO.File.Exists(strFileName) = False Then
            MsgBox("Vui lòng kiểm tra file (" & strSaveFilename & ").", MsgBoxStyle.Information, "Thông Báo")
            Exit Sub
        End If
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        Dim objExcel As Object, objWorkbook As Object
        Dim objSheet As Object
        objExcel = CreateObject("Excel.Application")
        objExcel.Visible = False
        objExcel.DisplayAlerts = True
        Try
            'strFileName = My.Application.Info.DirectoryPath & "\Excel\" & strSaveFilename
            objWorkbook = objExcel.Workbooks.Add(strFileName)

            objSheet = objWorkbook.Sheets("Sheet1")
            'Insert the DataTable into the Excel Spreadsheet
            Dim nStartRow As Byte = 10
            Dim Introw As Integer = 0
            Dim _macay_in As String
            If Chk_TachCay.CheckState = CheckState.Checked Then
                _macay_in = txtmacay.Text
            Else
                _macay_in = Mid(txtmacay.Text, 1, 6)
            End If

            ' Dim group As GridGroup = Super_Dgv.gr
            Call Load_TimeServer()
            With objSheet
                .Cells(1, "B").Value = "'" & _TimeServer.Day & "/" & _TimeServer.Month & "/" & _TimeServer.Year & " " & _TimeServer.Hour & ":" & _TimeServer.Minute
                .Cells(1, "E").Value = "!" & _macay_in & "!"
                .Cells(2, "B").Value = txtmahang.Text.ToUpper
                .Cells(3, "B").Value = txtloaihang.Text.ToUpper
                .Cells(4, "B").Value = FormatNumber(txtScale1.Text, 1)
                .Cells(4, "D").Value = FormatNumber(txtsometmoc.Text, 1)
                .Cells(4, "E").Value = "'" & _macay_in
                .Cells(5, "B").Value = txtmucdich.Text
                .Cells(6, "B").Value = txtghichu.Text
            End With
            'If Visible, then exit so user can see it, otherwise save and exit
            If blnIsVisible = False Then
                'objWorkbook.SaveAs(strSaveFilename, Excel.XlFileFormat.xlWorkbookDefault)
                objSheet.PrintOut()
                objWorkbook.Close(False)
                objExcel.Quit()
            End If
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Catch ex As Exception
            If blnIsVisible Then MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Error populating workbook")
            ForceExcelToQuit(objExcel)
        End Try
    End Sub

    Private Sub ForceExcelToQuit(ByVal objExcel As Excel.Application)
        Try
            objExcel.Quit()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint()
        Call Export_Excel_Chitiet("Tem_Moc.xls", False)
    End Sub

#End Region

End Class