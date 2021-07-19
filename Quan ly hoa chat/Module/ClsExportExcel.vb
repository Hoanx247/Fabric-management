Imports System.Globalization
Imports System.Text
Imports DevComponents.DotNetBar.SuperGrid
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class ClsExportExcel
    Private style As NumberStyles
    Private culture As CultureInfo

    Public _Columns_1 As String() = New String() {"id"}
    Public _stt As Decimal = 0
    Private dr As DataRow()
    Public strfolder_path As String
    Public strfileExcel_1 As String
    Public strfileExcel_2 As String
    Public _rangeExcel As String ' Vùng paste data
    Public _rangeExcel_Text As String() = New String() {"id"}
    Public _rangeExcel_number_0 As String() = New String() {"id"}
    Public _rangeExcel_number_1 As String() = New String() {"id"}
    Public _rangeExcel_number_2 As String() = New String() {"id"}
    Public _rangeExcel_Date As String() = New String() {"id"}
    Public _rangeExcel_Date_Time As String() = New String() {"id"}
    Public _PrintArea As String() = New String() {"id"}
    Public _GridArea As String() = New String() {"id"}
    Public _Array_Cal As String() = New String() {"id"}
    Private _intRows_ALL As Decimal = 0
    Private _intGroup_Count As Integer = 0
    Private DataGridView1 As New DataGridView ' declare a new DataGridView
    Private _Tong_1 As Decimal = 0
    Private _Tong_2 As Decimal = 0
    Private _Tong_3 As Decimal = 0
    Private _Tong_4 As Decimal = 0
    Private _Tong_5 As Decimal = 0
    Private _Tong_6 As Decimal = 0
    Private _Tong_7 As Decimal = 0
    Private _Tong_8 As Decimal = 0
    Private _Tong_9 As Decimal = 0
    Private _Tong_10 As Decimal = 0
    Private _Tong_11 As Decimal = 0
    Private _Tong_12 As Decimal = 0
    Private _Tong_13 As Decimal = 0
    Private _Tong_14 As Decimal = 0
    Private _Tong_15 As Decimal = 0
    Private _Tong_16 As Decimal = 0
    Private _Tong_17 As Decimal = 0
    Private _Tong_18 As Decimal = 0
    '//
    Private _ThanhTien As Decimal = 0

    Private _LastColumn As Integer = 0

#Region "XUAT EXCEL KHO MOC"

    Private Function FormatForCSV(stringToProcess As String) As String
        If stringToProcess.Contains("""") Or stringToProcess.Contains(",") Then
            stringToProcess = String.Format("""{0}""", stringToProcess.Replace("""", """"""))
        End If
        Return stringToProcess
    End Function

    Private Sub UpdateShowALLRows_Excel(ByVal panel As GridPanel, ByVal rows As IEnumerable(Of GridElement))
        Dim myList As New List(Of Object)
        'Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing AndAlso group.Visible = True Then

                myList.Clear()
                '//
                _intGroup_Count += 1
                _intRows_ALL += 1
                For cc As Integer = 0 To _Columns_1.Length - 1
                    myList.Add(String.Empty)
                Next
                Dim _GroupValue_Parent As GridGroup = TryCast(group.Parent, GridGroup)
                If _GroupValue_Parent IsNot Nothing Then
                    myList(2) = group.GroupValue.ToString
                ElseIf _GroupValue_Parent Is Nothing Then
                    myList(1) = group.Text
                End If
                '//
                myList(0) = "[X]"
                '//
                If _IsNotPrint_GroupName = False Then
                    DataGridView1.Rows.Add(myList.ToArray())
                    '//
                End If
                '//Them các dòng trắng
                If _GInsertRow > 0 Then
                    myList.Clear()
                    For cc As Integer = 0 To _Columns_1.Length - 1
                        myList.Add(String.Empty)
                    Next
                    myList(0) = "[I]"
                    For y = 1 To _GInsertRow
                        DataGridView1.Rows.Add(myList.ToArray())
                    Next
                End If
                '//
                '//
                UpdateShowALLRows_Excel(panel, group.Rows)

            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                    myList.Clear()
                    '//
                    _intRows_ALL += 1
                    _stt += 1


                    For cc As Integer = 0 To _Columns_1.Length - 1
                        Dim _value As String
                        Dim str As String = _Columns_1(cc).ToLower
                        If str.Contains("+") = True Then
                            Dim leftPart As String = str.Split("+")(0)
                            Dim rightPart As String = str.Split("+")(1)

                            If columns.Contains(leftPart) = True AndAlso columns.Contains(rightPart) = True Then
                                _value = row.Cells(leftPart).Value.ToString & " / " & row.Cells(rightPart).Value.ToString
                            Else
                                _value = String.Empty
                            End If
                            myList.Add(_value)
                        Else

                            If columns.Contains(_Columns_1(cc).ToLower) = True Then
                                If row.Cells(_Columns_1(cc)).Value IsNot Nothing Then
                                    _value = row.Cells(_Columns_1(cc)).Value.ToString
                                Else
                                    _value = String.Empty
                                End If

                            Else
                                _value = String.Empty
                            End If
                            myList.Add(_value)
                        End If

                    Next
                    '//
                    myList(0) = _stt
                    '//
                    DataGridView1.Rows.Add(myList.ToArray())
                ElseIf row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = True Then


                    myList.Clear()
                    '//
                    _intRows_ALL += 1

                    For cc As Integer = 0 To _Columns_1.Length - 1
                        '_stt += 1
                        '//
                        Dim _value As String

                        If columns.Contains(_Columns_1(cc).ToLower) = True Then
                            If row.Cells(_Columns_1(cc)).Value IsNot Nothing Then
                                _value = row.Cells(_Columns_1(cc)).Value
                            Else
                                _value = String.Empty
                            End If
                        Else
                            _value = String.Empty
                        End If
                        myList.Add(_value)
                    Next
                    '//
                    myList(0) = "-"
                    '//
                    DataGridView1.Rows.Add(myList.ToArray())
                End If

            End If
        Next
    End Sub

    Private Sub DataGridToCSV(ByRef dt As DataGridView, Qualifier As String, _intgroup_Count As Integer)
        Dim TempDirectory As String = "Tempo"
        System.IO.Directory.CreateDirectory(TempDirectory)
        '///
        Dim filename_copy As String
        Dim copyOfOriginalFile As String = String.Empty
        Dim strFileName As String = strfolder_path & "\" & strfileExcel_1
        If System.IO.File.Exists(strFileName) = False Then
            MsgBox("Vui lòng kiểm tra file (" & strFileName & ").", MsgBoxStyle.Information, "Thông Báo")
            Exit Sub
        End If
        '//
        filename_copy = strfileExcel_1 & "." & System.IO.Path.GetRandomFileName & ".xls"
        '//Địa chỉ lưu tạm
        copyOfOriginalFile = My.Application.Info.DirectoryPath & "\" & TempDirectory & "\" & filename_copy
        'System.IO.File.Copy(strFileName, copyOfOriginalFile, True)
        '///
        Dim oWrite As System.IO.StreamWriter
        Dim file As String = System.IO.Path.GetRandomFileName & ".csv"
        oWrite = IO.File.CreateText(TempDirectory & "\" & file)
        'oWrite.Encoding = New Encoding.UTF8
        '//
        'oWrite = New System.IO.StreamWriter(filepath, Encoding.UTF32)
        Dim CSV As StringBuilder = New StringBuilder()
        Dim i As Integer = 1
        Dim CSVHeader As StringBuilder = New StringBuilder()
        _LastColumn = dt.Columns.Count
        '//
        For Each c As DataGridViewColumn In dt.Columns
            If i = 1 Then
                'CSVHeader.Append(Qualifier & c.HeaderText.ToString() & Qualifier)
                CSVHeader.Append(Qualifier & FormatForCSV(c.HeaderText.ToString()) & Qualifier)
            Else
                'CSVHeader.Append("," & Qualifier & c.HeaderText.ToString() & Qualifier)
                CSVHeader.Append("," & Qualifier & FormatForCSV(c.HeaderText.ToString()) & Qualifier)
            End If
            i += 1
        Next
        'CSV.AppendLine(CSVHeader.ToString())
        'oWrite.WriteLine(CSVHeader.ToString())
        'oWrite.Flush()
        For r As Integer = 0 To dt.Rows.Count - 1

            Dim CSVLine As StringBuilder = New StringBuilder()
            Dim s As String = ""
            For c As Integer = 0 To dt.Columns.Count - 1
                If c = 0 Then
                    'CSVLine.Append(Qualifier & gridResults.Rows(r).Cells(c).Value.ToString() & Qualifier)
                    s = s & Qualifier & FormatForCSV(dt.Rows(r).Cells(c).Value.ToString()) & Qualifier
                Else
                    'CSVLine.Append("," & Qualifier & gridResults.Rows(r).Cells(c).Value.ToString() & Qualifier)
                    s = s & "," & Qualifier & FormatForCSV(dt.Rows(r).Cells(c).Value.ToString()) & Qualifier
                End If
            Next
            oWrite.WriteLine(s, System.Text.Encoding.UTF8)
            oWrite.Flush()
            'CSV.AppendLine(CSVLine.ToString())
            'CSVLine.Clear()
        Next
        'oWrite.Write(CSV.ToString())
        oWrite.Close()
        oWrite = Nothing
        '//
        Dim strPath_CSV As String = My.Application.Info.DirectoryPath & "\" & TempDirectory & "\" & file
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim objExcel As Object, objWorkbook As Object
        Dim objSheet As Object
        objExcel = CreateObject("Excel.Application")
        '--if objexcel is already
        While Not objExcel.ready
            wait(100)
        End While
        'objExcel.Visible = False
        objWorkbook = objExcel.Workbooks.add(strFileName)
        objSheet = objWorkbook.Sheets(1)

        objExcel.displayalerts = False
        Dim locColumnTypes As New System.Collections.Generic.List(Of Integer)

        '//Xac dinh cot la text
        For cc As Integer = 0 To _LastColumn - 1
            locColumnTypes.Add(1)
        Next
        '//Text
        Dim _index_start As Integer = GetExcelColumnIndex(gLeft(_rangeExcel, 1)) - 1
        For cc As Integer = 0 To _rangeExcel_Text.Length - 1
            Dim st As String = _rangeExcel_Text(cc)
            If st <> "-" Then
                Dim _index As Integer = GetExcelColumnIndex(st) - 1
                locColumnTypes.Remove(_index - _index_start)
                locColumnTypes.Insert(_index - _index_start, 2)
            End If
        Next

        With objSheet.QueryTables.Add(Connection:="TEXT;" & strPath_CSV, Destination:=objSheet.Range(_rangeExcel))
            .TextFilePlatform = 65001
            .TextFileParseType = Excel.XlTextParsingType.xlDelimited
            .FieldNames = True
            .RowNumbers = False
            .FillAdjacentFormulas = False
            .PreserveFormatting = True
            .RefreshOnFileOpen = False
            .BackgroundQuery = True
            .RefreshStyle = Excel.XlCellInsertionMode.xlOverwriteCells
            .SavePassword = False
            .SaveData = True
            .AdjustColumnWidth = False
            .RefreshPeriod = 0
            .TextFileCommaDelimiter = True
            .TextFileSpaceDelimiter = False
            If decimalSeparator_system = "," Then
                .TextFileDecimalSeparator = ","
            Else
                .TextFileDecimalSeparator = "."
            End If

            .TextFileColumnDataTypes = locColumnTypes.ToArray()
            .TextFileTrailingMinusNumbers = True
            .Refresh(Backgroundquery:=False)
        End With
        objExcel.ActiveSheet.QueryTables(1).Delete()
        '//
        Dim nStartRow As Integer = Get_Only_num(_rangeExcel)
        Dim _AllRows As Integer = dt.Rows.Count + nStartRow
        Dim _AllRows_GroupCount As Integer = dt.Rows.Count + nStartRow - 1
        Dim _rowA As Integer = 2
        '//
        'Dim rg As Excel.Range
        With objSheet
            Call Load_TimeServer()
            '//Cong TY
            '.Cells(1, "A").Value = _GTenCongTy
            '.Cells(2, "A").Value = _GDiaChiCongTy
            If _GTieuDe.Length > 2 Then
                .Cells(1, "A").Value = _GTieuDe
            End If

            '//
            .Cells(1, "BA").Value = "NGƯỜI IN: " & strUser.ToUpper
            .Cells(1, "BB").Value = "NGÀY IN: " & Format(_TimeServer, "dd/MM/yyyy HH:mm")
            .Cells(1, "BC").Value = "SỐ HĐ: " & _GSoHoaDon.ToUpper
            .Cells(1, "BD").Value = "NGÀY NHẬP: " & _GdtNgayNhap
            .Cells(1, "BE").Value = "KHÁCH HÀNG: " & _GKhachHang.ToUpper
            .Cells(1, "BF").Value = _GMayCang.ToUpper
            .Cells(1, "BG").Value = _GChungtunhap.ToUpper
            .Cells(1, "BH").Value = _GChungtu_kemtheo.ToUpper
            '//
            .Cells(2, "BA").Value = GNoDauKy
            .Cells(2, "BB").Value = GPhatSinhCo
            .Cells(2, "BC").Value = GPhatSinhNo
            .Cells(2, "BD").Value = GDieuChinh
            .Cells(2, "BE").Value = GNoCuoiKy
            '//
            .Cells(3, "BA").Value = GDonhang
            .Cells(3, "BB").Value = GMahang
            .Cells(3, "BC").Value = GKhachhang
            .Cells(3, "BD").Value = GLoaihang
            .Cells(3, "BE").Value = GKhovai
            .Cells(3, "BF").Value = Gmetkg
            '//
            If _IsPrint_Sum = True Then
                .Cells(4, "BA").Value = _Tong_1
                .Cells(4, "BB").Value = _Tong_2
                .Cells(4, "BC").Value = _Tong_3
                '//
                .Cells(4, "BD").Value = _Tong_4
                .Cells(4, "BE").Value = _Tong_5
                .Cells(4, "BF").Value = _Tong_6
                '//
                .Cells(4, "BG").Value = _Tong_7
                .Cells(4, "BH").Value = _Tong_8
                .Cells(4, "BI").Value = _Tong_9
                '//
                .Cells(4, "BJ").Value = _Tong_10
                .Cells(4, "BK").Value = _Tong_11
                .Cells(4, "BL").Value = _Tong_12
                .Cells(4, "BM").Value = _Tong_13
                .Cells(4, "BN").Value = _Tong_14
                .Cells(4, "BO").Value = _Tong_15
                .Cells(4, "BP").Value = _Tong_16
                .Cells(4, "BQ").Value = _Tong_17
            End If
            '//
            If _GdtNgayIn_1.Length > 3 AndAlso _GdtNgayIn_2.Length > 3 Then
                .Cells(GdongIn_NgayThangNam, "A").Value = "Từ Ngày: " & _GdtNgayIn_1 & "  Đến Ngày: " & _GdtNgayIn_2
            ElseIf _GdtNgayIn_1.Length > 3 AndAlso _GdtNgayIn_2.Length = 0 Then
                .Cells(GdongIn_NgayThangNam, GCellIn_NgayThangNam).Value = _GdtNgayIn_1
            End If

            '--
            '//
            _AllRows = _AllRows + _intgroup_Count + _rowA
            For cc As Integer = 0 To _rangeExcel_Date.Length - 1
                Dim st As String = _rangeExcel_Date(cc)
                If st <> "-" Then
                    Dim _stLast As String = st & nStartRow.ToString & ":" & st & _AllRows
                    .Range(_stLast).NumberFormat = "dd/MM/yyyyy"
                End If
            Next
            '//
            For cc As Integer = 0 To _rangeExcel_Date_Time.Length - 1
                Dim st As String = _rangeExcel_Date_Time(cc)
                If st <> "-" Then
                    Dim _stLast As String = st & nStartRow.ToString & ":" & st & _AllRows
                    .Range(_stLast).NumberFormat = "dd/MM/yyyyy HH:mm"
                End If
            Next

            '//

            For cc As Integer = 0 To _rangeExcel_number_0.Length - 1
                    Dim st As String = _rangeExcel_number_0(cc)
                    If st <> "-" Then
                        Dim _stLast As String = st & "8" & ":" & st & _AllRows
                    'rg = .Columns(_stLast)
                    .Range(_stLast).NumberFormat = "###,###,###;(###,###,###);-"
                End If
                Next


            '//

            For cc As Integer = 0 To _rangeExcel_number_1.Length - 1
                    Dim st As String = _rangeExcel_number_1(cc)
                    If st <> "-" Then
                        Dim _stLast As String = st & "8" & ":" & st & _AllRows
                        'rg = .Columns(_stLast)
                        .Range(_stLast).NumberFormat = "###,##0.0;(###,##0.0);-"
                    End If

                Next


            '//

            For cc As Integer = 0 To _rangeExcel_number_2.Length - 1
                    Dim st As String = _rangeExcel_number_2(cc)
                    If st <> "-" Then
                        Dim _stLast As String = st & "8" & ":" & st & _AllRows
                    'rg = .Columns(_stLast)

                    .Range(_stLast).NumberFormat = "###,##0.#0;(###,##0.#0);-"
                End If
                Next


            '//Vùng In
            Dim _LastColName As String = ColIndexToColLetter(_LastColumn)
            Dim _sPintArea As String = _PrintArea(0) & "1" & ":" & _PrintArea(1) & _AllRows_GroupCount
            If _IsPrint_PrintArea = True Then
                .PageSetup.PrintArea = _sPintArea
            End If

            '---KE O
            Dim _sGridArea As String = _GridArea(0) & nStartRow.ToString & ":" & _LastColName & _AllRows_GroupCount
            If _IsPrint_GridArea = True Then
                .Range(_sGridArea).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            End If
        End With
        '//Enable marco
        Dim pdfOfOriginalFile As String = String.Empty
        If _IsPrint = True Then
            Dim filename_pdf As String = strfileExcel_1 & System.IO.Path.GetRandomFileName & ".pdf"
            pdfOfOriginalFile = My.Application.Info.DirectoryPath & "\" & TempDirectory & "\" & filename_pdf
            objWorkbook.ActiveSheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, pdfOfOriginalFile)
        Else
            '// Close As
            objWorkbook.SaveAs(copyOfOriginalFile, Excel.XlFileFormat.xlWorkbookNormal, System.Reflection.Missing.Value, System.Reflection.Missing.Value, False, False, Excel.XlSaveAsAccessMode.xlNoChange, False, False, System.Reflection.Missing.Value,
                               System.Reflection.Missing.Value, System.Reflection.Missing.Value)

        End If

        '//
        wait(100)
        _GTieuDe = String.Empty
        '//
        objWorkbook.Close(False)
        objExcel.Quit()
        GC.Collect()
        ReleaseObject(objWorkbook)
        ReleaseObject(objExcel)
        objExcel = Nothing
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

        '///
        wait(200)
        'Dim startInfo As ProcessStartInfo
        If _IsPrint = False Then
            System.Diagnostics.Process.Start(copyOfOriginalFile)
        Else
            System.Diagnostics.Process.Start(pdfOfOriginalFile)
        End If
        '//
        _IsEnable_Marco = False
        '//
        _isNoPrint_GroupName = False
        _IsPrint = False
    End Sub
    '//
    Public Sub ExportToExcelAsLocal(ByVal panel As GridPanel, _sfrmName As String)
        _intGroup_Count = 0
        _stt = 0
        _intRows_ALL = 0
        _Tong_1 = 0
        _Tong_2 = 0
        _Tong_3 = 0
        _Tong_4 = 0
        _Tong_5 = 0
        _Tong_6 = 0
        _Tong_7 = 0
        _Tong_8 = 0
        _Tong_9 = 0
        _Tong_10 = 0
        _Tong_11 = 0
        _Tong_12 = 0
        _Tong_13 = 0
        _Tong_14 = 0
        _Tong_15 = 0
        _Tong_16 = 0
        _Tong_17 = 0
        _Tong_18 = 0
        With DataGridView1
            .AllowUserToAddRows = False
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .Columns.Clear()
            .Rows.Clear()
            .VirtualMode = False
        End With

        For cc As Integer = 0 To _Columns_1.Length - 1
            Dim nc As New DataGridViewTextBoxColumn With {
                .Name = _Columns_1(cc)
            }
            DataGridView1.Columns.Add(nc)
        Next
        '///
        UpdateShowALLRows_Excel(panel, panel.Rows)
        '//Calcultae cell
        Dim columns As DataGridViewColumnCollection = DataGridView1.Columns
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                If row.Cells(0).Value.ToString <> "-" Then
                    For yy As Integer = 0 To _Array_Cal.Length - 1
                        If columns.Contains(_Array_Cal(yy)) = True Then
                            If yy = 0 Then
                                _Tong_1 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 1 Then
                                _Tong_2 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 2 Then
                                _Tong_3 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 3 Then
                                _Tong_4 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 4 Then
                                _Tong_5 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 5 Then
                                _Tong_6 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 6 Then
                                _Tong_7 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 7 Then
                                _Tong_8 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 8 Then
                                _Tong_9 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 9 Then
                                _Tong_10 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 10 Then
                                _Tong_11 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 11 Then
                                _Tong_12 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 12 Then
                                _Tong_13 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 13 Then
                                _Tong_14 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 14 Then
                                _Tong_15 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 15 Then
                                _Tong_16 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 16 Then
                                _Tong_17 += CoToDec(row.Cells(_Array_Cal(yy)).Value)
                            ElseIf yy = 17 Then
                                _Tong_18 += CoToDec(row.Cells(_Array_Cal(yy)).Value)

                            End If
                        End If
                    Next

                End If

            End If
        Next
        '//
        Dim myList As New List(Of Object)
        Dim _value As String = String.Empty
        For cc As Integer = 0 To _Columns_1.Length - 1
            _value = String.Empty
            For yy As Integer = 0 To _Array_Cal.Length - 1
                If _Columns_1(cc) = _Array_Cal(yy) Then
                    If yy = 0 Then
                        _value = _Tong_1
                    ElseIf yy = 1 Then
                        _value = _Tong_2
                    ElseIf yy = 2 Then
                        _value = _Tong_3
                    ElseIf yy = 3 Then
                        _value = _Tong_4
                    ElseIf yy = 4 Then
                        _value = _Tong_5
                    ElseIf yy = 5 Then
                        _value = _Tong_6
                    ElseIf yy = 6 Then
                        _value = _Tong_7
                    ElseIf yy = 7 Then
                        _value = _Tong_8
                    ElseIf yy = 8 Then
                        _value = _Tong_9
                    ElseIf yy = 9 Then
                        _value = _Tong_10
                    ElseIf yy = 10 Then
                        _value = _Tong_11
                    ElseIf yy = 11 Then
                        _value = _Tong_12
                    ElseIf yy = 12 Then
                        _value = _Tong_13
                    ElseIf yy = 13 Then
                        _value = _Tong_14
                    ElseIf yy = 14 Then
                        _value = _Tong_15
                    ElseIf yy = 15 Then
                        _value = _Tong_16
                    ElseIf yy = 16 Then
                        _value = _Tong_17
                    ElseIf yy = 17 Then
                        _value = _Tong_18
                    End If
                End If
            Next
            myList.Add(_value)
        Next
        myList(0) = "TỔNG"
        '//
        If _IsPrint_Sum = True Then
            DataGridView1.Rows.Add(myList.ToArray())
        End If
        '//
        DataGridToCSV(DataGridView1, "", _intGroup_Count)
        '///
        '--
    End Sub

    Public Sub ExportToExcelAsChecked(ByVal panel As GridPanel, _sfrmName As String)
        _intGroup_Count = 0
        _stt = 0
        _intRows_ALL = 0
        _Tong_1 = 0
        _Tong_2 = 0
        _Tong_3 = 0
        _Tong_4 = 0
        _Tong_5 = 0
        _Tong_6 = 0
        _Tong_7 = 0
        _Tong_8 = 0
        _Tong_9 = 0
        _Tong_10 = 0
        _Tong_11 = 0
        _Tong_12 = 0
        With DataGridView1
            .AllowUserToAddRows = False
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .Columns.Clear()
            .Rows.Clear()
            .VirtualMode = False
        End With

        For cc As Integer = 0 To _Columns_1.Length - 1
            Dim nc As New DataGridViewTextBoxColumn With {
                .Name = _Columns_1(cc)
            }
            DataGridView1.Columns.Add(nc)
        Next
        '///
        UpdateShowALLRows_Checked(panel, panel.Rows)
        '//Calcultae cell
        Dim columns As DataGridViewColumnCollection = DataGridView1.Columns
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                If row.Cells(0).Value.ToString <> "-" Then
                    For yy As Integer = 0 To _Array_Cal.Length - 1
                        If columns.Contains(_Array_Cal(yy)) = True Then
                            If yy = 0 Then
                                _Tong_1 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 1 Then
                                _Tong_2 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 2 Then
                                _Tong_3 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 3 Then
                                _Tong_4 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 4 Then
                                _Tong_5 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 5 Then
                                _Tong_6 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 6 Then
                                _Tong_7 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 7 Then
                                _Tong_8 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 8 Then
                                _Tong_9 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 9 Then
                                _Tong_10 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 10 Then
                                _Tong_11 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 11 Then
                                _Tong_12 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 12 Then
                                _Tong_13 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 13 Then
                                _Tong_14 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 14 Then
                                _Tong_15 += row.Cells(_Array_Cal(yy)).Value
                            End If
                        End If
                    Next

                End If

            End If
        Next
        '//
        Dim myList As New List(Of Object)
        Dim _value As String = String.Empty
        For cc As Integer = 0 To _Columns_1.Length - 1
            _value = String.Empty
            For yy As Integer = 0 To _Array_Cal.Length - 1
                If _Columns_1(cc) = _Array_Cal(yy) Then
                    If yy = 0 Then
                        _value = _Tong_1
                    ElseIf yy = 1 Then
                        _value = _Tong_2
                    ElseIf yy = 2 Then
                        _value = _Tong_3
                    ElseIf yy = 3 Then
                        _value = _Tong_4
                    ElseIf yy = 4 Then
                        _value = _Tong_5
                    ElseIf yy = 5 Then
                        _value = _Tong_6
                    ElseIf yy = 6 Then
                        _value = _Tong_7
                    ElseIf yy = 7 Then
                        _value = _Tong_8
                    ElseIf yy = 8 Then
                        _value = _Tong_9
                    ElseIf yy = 9 Then
                        _value = _Tong_10
                    ElseIf yy = 10 Then
                        _value = _Tong_11
                    ElseIf yy = 11 Then
                        _value = _Tong_12
                    ElseIf yy = 12 Then
                        _value = _Tong_13
                    ElseIf yy = 13 Then
                        _value = _Tong_14
                    ElseIf yy = 14 Then
                        _value = _Tong_15
                    End If
                End If
            Next
            myList.Add(_value)
        Next
        myList(0) = "TỔNG"
        '//
        If _IsPrint_Sum = True Then
            DataGridView1.Rows.Add(myList.ToArray())
        End If

        '//
        If _intRows_ALL > 0 Then
            DataGridToCSV(DataGridView1, "", _intGroup_Count)
            '///
        End If

        '--
    End Sub

    Private Sub UpdateShowALLRows_Checked(ByVal panel As GridPanel, ByVal rows As IEnumerable(Of GridElement))
        Dim myList As New List(Of Object)
        'Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing AndAlso group.Visible = True Then
                myList.Clear()
                '//
                _intGroup_Count += 1
                _intRows_ALL += 1
                For cc As Integer = 0 To _Columns_1.Length - 1
                    myList.Add(String.Empty)
                Next
                Dim _GroupValue_Parent As GridGroup = TryCast(group.Parent, GridGroup)
                If _GroupValue_Parent IsNot Nothing Then
                    myList(2) = group.GroupValue.ToString
                ElseIf _GroupValue_Parent Is Nothing Then
                    myList(1) = group.GroupValue.ToString
                End If
                '//
                myList(0) = "-"
                '//
                If _IsNotPrint_GroupName = False Then
                    DataGridView1.Rows.Add(myList.ToArray())
                    '//
                End If
                '//
                UpdateShowALLRows_Checked(panel, group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then
                    myList.Clear()
                    '//
                    _intRows_ALL += 1
                    _stt += 1

                    For cc As Integer = 0 To _Columns_1.Length - 1
                        Dim _value As String
                        Dim str As String = _Columns_1(cc).ToLower
                        If str.Contains("+") = True Then
                            Dim leftPart As String = str.Split("+")(0)
                            Dim rightPart As String = str.Split("+")(1)

                            If columns.Contains(leftPart) = True AndAlso columns.Contains(rightPart) = True Then
                                _value = row.Cells(leftPart).Value.ToString & " / " & row.Cells(rightPart).Value.ToString
                            Else
                                _value = String.Empty
                            End If
                            myList.Add(_value)
                        Else

                            If columns.Contains(_Columns_1(cc).ToLower) = True Then
                                _value = row.Cells(_Columns_1(cc)).Value.ToString
                            Else
                                _value = String.Empty
                            End If
                            myList.Add(_value)
                        End If

                    Next
                    '//
                    myList(0) = _stt
                    '//
                    DataGridView1.Rows.Add(myList.ToArray())
                ElseIf row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = True Then
                    myList.Clear()
                    '//
                    _intRows_ALL += 1

                    For cc As Integer = 0 To _Columns_1.Length - 1
                        '_stt += 1
                        '//
                        Dim _value As String

                        If columns.Contains(_Columns_1(cc).ToLower) = True Then
                            If row.Cells(_Columns_1(cc)).Value IsNot Nothing Then
                                _value = row.Cells(_Columns_1(cc)).Value
                            Else
                                _value = String.Empty
                            End If
                        Else
                            _value = String.Empty
                        End If
                        myList.Add(_value)
                    Next
                    '//
                    myList(0) = "-"
                    '//
                    DataGridView1.Rows.Add(myList.ToArray())
                End If
            End If
        Next
    End Sub


    Public Shared Function GetExcelColumnIndex(ByVal columnName As String) As Integer
        Dim ColumnLetterToNumber As Integer = 0
        For i = 1 To Len(columnName)
            ColumnLetterToNumber = ColumnLetterToNumber * 26 + (Asc(UCase(Mid(columnName, i, 1))) - 64)
        Next
        Return ColumnLetterToNumber
    End Function

    Public Sub ExportToExcelForALL(ByVal panel As GridPanel, _sfrmName As String)
        _Columns_1 = {}
        _rangeExcel_Text = {}
        _rangeExcel_number_0 = {}
        _rangeExcel_number_1 = {}
        _rangeExcel_number_2 = {}
        _rangeExcel_Date = {}
        _rangeExcel_Date_Time = {}
        _PrintArea = {}
        _GridArea = {}
        '//Các Cột Tính Tổng
        _Array_Cal = {}
        '//
        _Tong_1 = 0
        _Tong_2 = 0
        _Tong_3 = 0
        _Tong_4 = 0
        _Tong_5 = 0
        _Tong_6 = 0
        _Tong_7 = 0
        _Tong_8 = 0
        _Tong_9 = 0
        _Tong_10 = 0
        _Tong_11 = 0
        _Tong_12 = 0
        '//
        _ThanhTien = 0
        dr = dataset_all.Tables("tbfrmname").Select("frmname= '" & _sfrmName & "'", "")
        If dr.Length > 0 Then
            strfileExcel_1 = dr.First.Item("fileexcel_1")
            _rangeExcel = dr.First.Item("rangeexcel")
            '//
            Dim arrayLetters As String = dr.First.Item("columnexcel_1")
            arrayLetters = arrayLetters.Replace(" ", "")
            _Columns_1 = arrayLetters.Split(",")
            '//
            Dim arrayLetters_A As String = dr.First.Item("columnexcel_sum_1")
            arrayLetters_A = arrayLetters_A.Replace(" ", "")
            _Array_Cal = arrayLetters_A.Split(",")
            '//
            Dim arrayLetters_1 As String = dr.First.Item("rangeexcel_text")
            _rangeExcel_Text = arrayLetters_1.Split(",")
            Dim arrayLetters_2 As String = dr.First.Item("rangeexcel_number_0")
            _rangeExcel_number_0 = arrayLetters_2.Split(",")
            Dim arrayLetters_3 As String = dr.First.Item("rangeexcel_number_1")
            _rangeExcel_number_1 = arrayLetters_3.Split(",")
            Dim arrayLetters_4 As String = dr.First.Item("rangeexcel_number_2")
            _rangeExcel_number_2 = arrayLetters_4.Split(",")
            Dim arrayLetters_5 As String = dr.First.Item("rangeexcel_date")
            _rangeExcel_Date = arrayLetters_5.Split(",")
            '//
            Dim arrayLetters_6 As String = dr.First.Item("printarea")
            _PrintArea = arrayLetters_6.Split(",")
            Dim arrayLetters_7 As String = dr.First.Item("gridarea")
            _GridArea = arrayLetters_7.Split(",")
            Dim arrayLetters_8 As String = dr.First.Item("rangeexcel_date_time")
            _rangeExcel_Date_Time = arrayLetters_8.Split(",")
        End If
        '//
        _intGroup_Count = 0
        _stt = 0
        _intRows_ALL = 0
        With DataGridView1
            .AllowUserToAddRows = False
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .Columns.Clear()
            .Rows.Clear()
            .VirtualMode = False
        End With

        For cc As Integer = 0 To _Columns_1.Length - 1
            Dim nc As New DataGridViewTextBoxColumn With {
                .Name = _Columns_1(cc)
            }
            DataGridView1.Columns.Add(nc)
        Next
        '///
        UpdateShowALLRows_Excel(panel, panel.Rows)
        '//Calcultae cell
        Dim columns As DataGridViewColumnCollection = DataGridView1.Columns
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                If row.Cells(0).Value.ToString <> "-" Then
                    For yy As Integer = 0 To _Array_Cal.Length - 1
                        If columns.Contains(_Array_Cal(yy)) = True Then
                            If yy = 0 Then
                                _Tong_1 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 1 Then
                                _Tong_2 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 2 Then
                                _Tong_3 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 3 Then
                                _Tong_4 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 4 Then
                                _Tong_5 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 5 Then
                                _Tong_6 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 6 Then
                                _Tong_7 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 7 Then
                                _Tong_8 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 8 Then
                                _Tong_9 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 9 Then
                                _Tong_10 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 10 Then
                                _Tong_11 += row.Cells(_Array_Cal(yy)).Value
                            ElseIf yy = 11 Then
                                _Tong_12 += row.Cells(_Array_Cal(yy)).Value
                            End If
                        End If
                    Next

                End If

            End If
        Next
        '//
        Dim myList As New List(Of Object)
        Dim _value As String = String.Empty
        For cc As Integer = 0 To _Columns_1.Length - 1
            _value = String.Empty
            For yy As Integer = 0 To _Array_Cal.Length - 1
                If _Columns_1(cc) = _Array_Cal(yy) Then
                    If yy = 0 Then
                        _value = _Tong_1
                    ElseIf yy = 1 Then
                        _value = _Tong_2
                    ElseIf yy = 2 Then
                        _value = _Tong_3
                    ElseIf yy = 3 Then
                        _value = _Tong_4
                    ElseIf yy = 4 Then
                        _value = _Tong_5
                    ElseIf yy = 5 Then
                        _value = _Tong_6
                    ElseIf yy = 6 Then
                        _value = _Tong_7
                    ElseIf yy = 7 Then
                        _value = _Tong_8
                    ElseIf yy = 8 Then
                        _value = _Tong_9
                    ElseIf yy = 9 Then
                        _value = _Tong_10
                    ElseIf yy = 10 Then
                        _value = _Tong_11
                    ElseIf yy = 11 Then
                        _value = _Tong_12
                    End If
                End If
            Next
            myList.Add(_value)
        Next
        myList(0) = "TỔNG"
        '//
        If _IsPrint_Sum = False Then
            DataGridView1.Rows.Add(myList.ToArray())
        End If

        '//
        DataGridToCSV(DataGridView1, "", _intGroup_Count)
        '///
        '--
    End Sub

#End Region

    Private Function Remove_Multi_space(ByVal st As String) As String
        Dim st1 As String = st.Trim
        Dim arr As String() = st1.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim compressedSpaces As String = String.Join(" ", arr)
        Return compressedSpaces
    End Function

    Private Function ColIndexToColLetter(ByVal colIndex As Integer) As String
        Dim div As Integer = colIndex
        Dim colLetter As String = String.Empty

        While div > 0
            Dim modnum As Integer = (div - 1) Mod 26

            colLetter = Chr(65 + modnum) & colLetter
            div = CInt((div - modnum) \ 26)
        End While

        Return colLetter
    End Function

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

End Class