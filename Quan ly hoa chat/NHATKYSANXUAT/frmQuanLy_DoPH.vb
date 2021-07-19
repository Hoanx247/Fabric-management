Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.IO
Imports System.Text
Public Class frmQuanly_DoPH
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    '//
    Private dtControler As KhoMocNhapKhoDAL
    Private _dt As KhoMocNhapKhoDTO
    Private dt_local As DataTable
    Private dt_kieunhap As DataTable
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
    Private _Lmame As String = String.Empty
    Dim dt_hinhanh As DataTable
    '//
    ' The original image that is maintained in order to revert.
    Private originalImage As Image = Nothing
    ' The current image that it being edited and updated.
    Private currentImage As Image = Nothing
    ' The image that is stored to undo the most recent change.
    Private undoImage As Image = Nothing
    ' The value used to determine the current zoom factor.
    Private zoomFactor As Double = 1
    ' The width of the image on the screen in pixels.
    Private screenImageWidth As Integer = 0
    ' The height of the image on the screen in pixels.
    Private screenImageHeight As Integer = 0
    ' Current X value of the mouse over the image.
    Private X As Integer = 0
    ' Current Y value of the mouse over the image.
    Private Y As Integer = 0

    ' The percentage of the size of the current image to make the thumbnail.
    Const thumbnailFactor As Double = 0.15

#Region " Load du liệu lên bảng khi mở Form"

#Region "Private data"

    Private _BackColor As Background() = {New Background(Color.LightGreen), _
        New Background(Color.FromArgb(&HE5, &HFF, &HDD)), New Background(Color.AliceBlue)}

    Private _MyFont As New Font("Time New Roman", 10, FontStyle.Bold Or FontStyle.Italic)

#End Region

    Private Sub Me_FormClosing(ByVal sender As Object, _
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------

        'Dgv_chung.Dispose()
        dt_local.Dispose()
        Super_Dgv.Dispose()
        Me.Dispose()
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
        '---
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoMocNhapKhoDAL
        '// 
        '--
        dt_local = New DataTable
        dt_hinhanh = New DataTable
        '--
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '//
        '--
        With dt1_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        With dt2_F
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy"
        End With
        Me.dt1_F.Value = FormatDateTime(DateSerial(Now.Year, Now.Month, Now.Day - 5), DateFormat.ShortDate)
        Me.dt2_F.Value = DateSerial(Now.Year, Now.Month, Now.Day.ToString)
        '--
        Call Load_TimeServer()
        '--
        dt_local = New DataTable
        '--

        AddHandler Super_Dgv.GetGroupDetailRows, AddressOf SuperGridControl1GetGroupDetailRows
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick


    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            '----------
            Call Filterdata_Stored()
            '----------------
        Else
            Me.Close()
        End If

    End Sub

    Private Sub ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            _Column_Forzen_pos = e.GridColumn.ColumnIndex
            If e.GridColumn.ColumnIndex = 0 Then
                ShowContextMenu(CtxMnuSelect)
            Else
                ShowContextMenu(CtxMenu)
            End If

        End If
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)

        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
        Else
            Dim panel As GridPanel = Super_Dgv.PrimaryGrid
            Dim dgvr As GridRow = panel.ActiveRow
            If dgvr IsNot Nothing Then
                _Lmame = dgvr.Cells("mame").Value.ToString
                Check_HinhAnh()
            Else
                MsgBox("Vui lòng chọn mẻ xác nhận.", MsgBoxStyle.Information, "Chọn Mẻ Nhuộm")
            End If
            If e.GridCell.ColumnIndex = 0 Then
                Panel.ReadOnly = True
                If dgvr.Checked = False Then
                    dgvr.Checked = True
                    dgvr.CellStyles.Default.Background.Color1 = Color.GreenYellow
                Else
                    dgvr.Checked = False
                    dgvr.CellStyles.Default.Background.Color1 = Color.White
                End If
            Else
                Panel.ReadOnly = True
            End If

        End If
        _saveRowIndex = e.GridCell.RowIndex

    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub

    Private Sub btnSave_ColumnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_ColumnFrozen.Click

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
        sbXMLString.Append("dtngay1='" + Format$(dt1_F.Value, "MM/dd/yyyy 00:00") + "' ")
        sbXMLString.Append("dtngay2='" + Format$(dt2_F.Value, "MM/dd/yyyy 23:59") + "' ")
        sbXMLString.Append("makhach='' ")
        sbXMLString.Append("khachhang='" + ReplaceTextXML(txtkhachhang_F.Text) + "' ")
        sbXMLString.Append("mahang='" + ReplaceTextXML(txtmahang_F.Text) + "' ")
        sbXMLString.Append("loaihang='" + ReplaceTextXML(txtloaihang_F.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoMocNhapKhoDTO("[VpsXmlKhoSanXuat_MeNhuom_NhatKy_DoPH]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub

#Region "SUM"

    Dim _array_column As String() = {"socay", "sokg"}
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
        panel.AddGroup(panel.Columns("mucdich"))
        '--
        Dim _stCol1 As String, _stCol2 As String
        Dim _stName As String, _stHeadText As String

        '--
        _stName = "Theo_DauKy"
        _stHeadText = "Tồn Đầu"
        _stCol1 = "socaydk"
        _stCol2 = "sometdk"
        If columns.Contains(_stCol1) = True AndAlso columns.Contains(_stCol2) = True Then
            panel.ColumnHeader.GroupHeaders.Add(clsDev.GetInfoHeader(columns, _stCol1, _stCol2, _stName, _stHeadText))
        End If
        '--
        _stName = "Theo_NhapTk"
        _stHeadText = "Nhập Trong Kỳ"
        _stCol1 = "socayntk"
        _stCol2 = "sometntk"
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
        Dim sortCols As GridColumn() = New GridColumn() {panel.Columns("mahang"), panel.Columns("mamau"), panel.Columns("mame")}
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

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkhovai_F.KeyDown, txtkhachhang_F.KeyDown, _
        txtmahang_F.KeyDown, txtmetkg_F.KeyDown, txtloaihang_F.KeyDown, txtmamau_F.KeyDown, txtghichu_F.KeyDown, _
         txtdonhang_F.KeyDown, txtmame_F.KeyDown, txtmau_F.KeyDown, txtcongdoan_F.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Filterdata_Stored()
        End If
    End Sub

    Private Sub btTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub

    Private Sub btnXemChiTiet_Click(sender As Object, e As EventArgs) Handles btnXemChiTiet.Click
        Display_Grp_Info()
    End Sub
    Private Sub Display_Grp_Info()
        With GP_Form
            .Location = New Point((Super_Dgv.Width / 2) - (.Width / 2), (Super_Dgv.Height / 2) - (.Height / 2))
            .Visible = True
        End With
    End Sub
    Private Sub Check_HinhAnh()
        If GP_Form.Visible = False Then Exit Sub
        If Len(_Lmame) = 0 Then Exit Sub
        '--
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("mame='" + ReplaceTextXML(_Lmame) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoMocNhapKhoDTO("[VpsXmlvps_DoPH_Mame_HinhAnh_Get]", sbXMLString.ToString, "select")
        dt_hinhanh = dtControler.SELECT_XML_Datatable(_dt)

        If dt_hinhanh.Rows.Count > 0 Then
            Call Load_Image_1()
        Else
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
            PictureBox4.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox6.Image = Nothing
        End If
        '--
    End Sub
    Private Sub Load_Image_1()
        ' Try
        Dim imageData As Byte() = DirectCast(dt_hinhanh.Rows(0).Item("hinhanh_lan1"), Byte())

        'Initialize image variable
        Dim newImage As Image
        'Read image data into a memory stream
        Using ms As New MemoryStream(imageData, 0, imageData.Length)
            ms.Write(imageData, 0, imageData.Length)

            'Set image variable value using memory stream.
            newImage = New Bitmap(Image.FromStream(ms)) 'Image.FromStream(ms, True)
        End Using

        'set picture
        PictureBox1.Image = newImage
        currentImage = newImage

        ' Determine appropriate zoom for initial view of image.
        If currentImage.Width / 2 > PictureBox1.Width Or
             currentImage.Height / 2 > PictureBox1.Height Then
            Zoom_1(0.25)
        ElseIf currentImage.Width > PictureBox1.Width Or
             currentImage.Height > PictureBox1.Height Then
            Zoom_1(0.5)
        ElseIf currentImage.Width * 2 < PictureBox1.Width _
             And currentImage.Height * 2 < PictureBox1.Height Then
            Zoom_1(2)
        ElseIf currentImage.Width * 2 > PictureBox1.Width _
             And currentImage.Height * 2 > PictureBox1.Height Then
            Zoom_1(2)
        ElseIf currentImage.Width * 1.5 < PictureBox1.Width _
             And currentImage.Height * 2 < PictureBox1.Height Then
            Zoom_1(1.5)
        Else
            Zoom_1(1)
        End If
        'Catch ex As Exception
        'PictureBox1.Image = Nothing
        ' End Try
    End Sub
    Private Sub Load_Image_2()
        ' Try
        Dim imageData As Byte() = DirectCast(dt_hinhanh.Rows(0).Item("hinhanh_lan1"), Byte())

        If Not imageData Is Nothing Then
            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                PictureBox1.BackgroundImage = Image.FromStream(ms, True)
            End Using
        End If
    End Sub
    Private Sub Zoom_1(ByVal factor As Double)

        ' Save the factor in global variable.
        zoomFactor = factor

        ' Get the resized image.
        Dim sourceBitmap As New Bitmap(currentImage)
        Dim destBitmap As New Bitmap(CInt(sourceBitmap.Width * factor),
            CInt(sourceBitmap.Height * factor))
        Dim destGraphic As Graphics = Graphics.FromImage(destBitmap)

        destGraphic.DrawImage(sourceBitmap, 0, 0, destBitmap.Width + 1,
            destBitmap.Height + 1)

        ' Save the size of the image on the screen in globals.
        screenImageWidth = destBitmap.Width
        screenImageHeight = destBitmap.Height

        PictureBox1.Image = destBitmap

        ' Update the zoom label on the form.
        'ZoomLabel.Text = "Zoom: " & zoomFactor * 100 & "%"

        ' Update the zoom menu selection.
        ' UpdateZoomMenu()

    End Sub

End Class