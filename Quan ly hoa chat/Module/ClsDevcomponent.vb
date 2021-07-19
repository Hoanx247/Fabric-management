Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.ComponentModel
Imports System.Text

Public Class ClsDevcomponent
    Dim cls As New Clsconnect
    Dim dr As DataRow()
    '//
    Private sbXMLString As StringBuilder = New StringBuilder()
    Dim drName As DataRow()
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Dim _intColumnFrozen As Int16 = 1
    '///
    '--<Description("Demonstrates DisplayNameAttribute."), DisplayName("Mã Khách")>
    'Public ReadOnly Property makhach() As Boolean
    '   Get
    '      Return True
    '  End Get
    'End Property
#Region "SORT"
    Public Function GetSortDir_Asc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection)})
    End Function


    Public Function GetSortDirDesDes(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Descending, SortDirection)})
    End Function

    Public Function GetSortDirAscAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection)})
    End Function

    Public Function GetSortDirDesAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Ascending, SortDirection)})
    End Function
    Public Function GetSortDirAscAscAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection)})
    End Function
    Public Function GetSortDirDescAscAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Ascending, SortDirection), CType(SortDirection.Ascending, SortDirection)})
    End Function
    Public Function GetSortDirDescDescAsc(ByVal cols As GridColumn()) As SortDirection()
        Return (New SortDirection() {CType(SortDirection.Descending, SortDirection), CType(SortDirection.Descending, SortDirection), CType(SortDirection.Ascending, SortDirection)})
    End Function
#End Region
    Public Function RecordsData(ByVal _Rows As GridRow) As String
        Dim results As String = String.Empty
        Dim dgvr As GridRow = CType(_Rows, GridRow)
        If dgvr IsNot Nothing Then
            Dim sb As New StringBuilder()
            For Each o As GridCell In dgvr.Cells
                sb.Append("[" & o.GridColumn.Name.ToString & "]" & o.Value.ToString)
                sb.Append(", ")
            Next
            results = sb.ToString
        Else
            results = String.Empty
        End If
        Return results
    End Function

#Region "EVENT SUPERGRID"
    Public Function CheckExistColumn(ByVal columns As GridColumnCollection, ByVal name As String) As Boolean
        Dim Result As Boolean = False
        If String.IsNullOrEmpty(name) = True Then
            Result = False
        Else
            If columns.Contains(name.ToLower) = True Then
                Result = True
            Else
                Result = False
            End If
        End If

        Return Result
    End Function
    Public Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Control Then
            Try
                Dim panel As GridPanel = CType(sender.PrimaryGrid, GridPanel)
                System.Windows.Forms.Clipboard.SetText(panel.ActiveCell.Value.ToString)
            Catch ex As Exception

            End Try

        End If

    End Sub

    Public Sub SuperDgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        Try

            If e.GridPanel.ActiveRow Is Nothing Then Exit Sub
            Dim dgvr As GridRow = CType(e.GridPanel.ActiveRow, GridRow)
            If dgvr.IsDetailRow = False Then
                e.GridCell.Value = e.NewValue
                e.GridCell.EditorDirty = True
                e.GridPanel.ActiveRow.Checked = True
                e.GridPanel.ActiveCell.CellStyles.Default.Background.Color1 = Color.GreenYellow
                Dim nextrow As GridRow = CType(e.GridPanel.ActiveRow.NextVisibleRow, GridRow)
                If nextrow.IsDetailRow = False Then
                    e.GridPanel.EnterKeySelectsNextRow = True
                Else
                    e.GridPanel.EnterKeySelectsNextRow = False
                End If
            Else
                e.GridPanel.EnterKeySelectsNextRow = True
            End If

        Catch ex As Exception
            GoTo SWERLExit
        End Try
SWERLExit:
        Return
    End Sub
#End Region

#Region "SUPER GRID"
    Public Function Show_1Column(ByVal name As String) As String
        Dim _TFormat As String = String.Empty
        Dim _TName As String = String.Empty
        'col.DisplayIndex = dindex
        dr = Gdatatable_FieldName.Select("fname = '" & name & "'", "")
        If dr.Length > 0 Then
            _TName = dr.First.Item("vietnamese").ToString
            _TFormat = dr.First.Item("dinhdang").ToString
        Else
            _TName = name
            _TFormat = "-"

        End If
        '--
        If _TFormat = "0" Then
            _intFormatText = 0
        ElseIf _TFormat = "1" Then
            _intFormatText = 1
        ElseIf _TFormat = "2" Then
            _intFormatText = 2
        ElseIf _TFormat = "3" Then
            _intFormatText = 3
        End If
        Return _TName
    End Function

    Public Sub ShowColumn_SuperDgv1(ByVal columns As GridColumnCollection, ByVal name As String,
                         ByVal dVisible As Boolean, Optional ByVal headerText As String = Nothing)
        Dim col As GridColumn = columns(name)

        If dVisible = True Then
            'col.Visible = True
        Else
            'col.Visible = False
        End If
        If headerText IsNot Nothing Then
            col.HeaderText = headerText
        End If
    End Sub

    Public Sub FrozenColumn(ByVal SuperDgv As DevComponents.DotNetBar.SuperGrid.GridPanel, ByVal _intColumn As Integer)
        SuperDgv.FrozenColumnCount = _intColumn
    End Sub

    Public Sub SaveColumn(ByVal SuperDgv As DevComponents.DotNetBar.SuperGrid.GridPanel, ByVal frmName As String)
        If LCase(strUser) = "haidangpro" Then Exit Sub
        _intColumnFrozen = SuperDgv.FrozenColumnCount
        Dim colname As StringBuilder = New StringBuilder()
        Dim colvisible As StringBuilder = New StringBuilder()
        Dim colwidth As StringBuilder = New StringBuilder()
        Dim i As Integer = 1
        '//Add xml to insert
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim columns As GridColumnCollection = SuperDgv.Columns
        For Each item As GridElement In columns
            Dim Column As GridColumn = CType(item, GridColumn)
            If i = 1 Then
                colname.Append(Column.Name.ToLower)
                colwidth.Append(Column.Width.ToString)
                If Column.Visible = False Then
                    colvisible.Append(0)
                Else
                    colvisible.Append(1)
                End If

            Else
                colname.Append("," & Column.Name.ToLower)
                colwidth.Append("," & Column.Width.ToString)
                If Column.Visible = False Then
                    colvisible.Append("," & 0)
                Else
                    colvisible.Append("," & 1)
                End If
            End If
            i += 1
            '//
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("fname='" + ReplaceTextXML(Column.Name.ToLower) + "' ")
            sbXMLString.Append("vietnamese='-' ")
            sbXMLString.Append("english='-' ")
            sbXMLString.Append("ghichu='-' ")
            sbXMLString.Append("dinhdang='-' ")
            sbXMLString.Append(" />")
        Next
        '//
        sbXMLString.Append("</Root>")
        cls.ExcuteDataStoredXML("[VpsXmlList_FieldName_UpSet]", sbXMLString.ToString, "insert")
        '//
        Dim _sname As String = _stUser_Save.ToLower & "/" & frmName.ToLower & "/" & SuperDgv.SuperGrid.Name.ToLower
        '//Add xml to insert
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("frmname_nhomuser_dgv_col='" + ReplaceTextXML(_sname) + "' ")
        sbXMLString.Append("colname='" + ReplaceTextXML(colname.ToString) + "' ")
        sbXMLString.Append("colwidth='" + ReplaceTextXML(colwidth.ToString) + "' ")
        sbXMLString.Append("colvisible='" + ReplaceTextXML(colvisible.ToString) + "' ")
        sbXMLString.Append("colfrozen='" + CNumber_system(_intColumnFrozen) + "' ")
        sbXMLString.Append("nhom_user='" + ReplaceTextXML(_stUser_Save.ToLower) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        If colwidth.Length > 10 Then
            cls.ExcuteDataStoredXML("[VpsXmlList_Colname_UpSet]", sbXMLString.ToString, "insert")
        End If

        '///
        Load_Initized_ColName()
    End Sub
    Private Sub Load_Initized_ColName()
        dtControler = New ListMenuDAL()
        'Gdatatable_ColName = New DataTable
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(_stUser_Save) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlLoad_Initial]", sbXMLString.ToString, "colname")
        Gdatatable_ColName = dtControler.SELECT_XML_Datatable(_dt)
    End Sub
    Public Sub LoadColumn(ByVal SuperDgv As DevComponents.DotNetBar.SuperGrid.GridPanel, ByVal frmName As String)
        If LCase(strUser) = "haidangpro" Then Exit Sub
        Dim colname As String() = New String() {"id"}
        Dim colvisible As String() = New String() {"id"}
        Dim colwidth As String() = New String() {"id"}
        Dim arrayLetters As String
        Dim i As Integer = 1
        Dim columns As GridColumnCollection = SuperDgv.Columns
        '//
        Dim _sname_temp As String
        _sname_temp = _stUser_Save.ToLower & "/" & frmName.ToLower & "/" & SuperDgv.SuperGrid.Name.ToLower
        dr = Gdatatable_ColName.Select("frmname_nhomuser_dgv_col= '" & _sname_temp & "'", "")


        '//Xu Ly Luu Độ rộng cột
        If dr.Length > 0 Then
            arrayLetters = dr.First.Item("colname")
            arrayLetters = arrayLetters.Replace(" ", "")
            colname = arrayLetters.Split(",")
            '//
            arrayLetters = dr.First.Item("colwidth")
            arrayLetters = arrayLetters.Replace(" ", "")
            colwidth = arrayLetters.Split(",")
            '//
            arrayLetters = dr.First.Item("colvisible")
            arrayLetters = arrayLetters.Replace(" ", "")
            colvisible = arrayLetters.Split(",")
            SuperDgv.FrozenColumnCount = 1 ' dr.First.Item("colfrozen") + 1
            '//
            i = 0

            For Each item As GridElement In SuperDgv.Columns
                Dim column As GridColumn = TryCast(item, GridColumn)
                Dim _TFormat As String = String.Empty
                '//
                If i <= colname.Length - 1 Then
                    If colname(i) = column.Name.ToLower Then
                        Dim col As GridColumn = columns(colname(i))
                        '//
                        column.Width = colwidth(i)
                        If column.Name.ToLower.Contains("_id") = True Then
                            column.Visible = False
                        End If

                        '//
                        i += 1
                    End If
                End If

            Next item
        End If
        '//Add xml to insert
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        For Each item As GridElement In SuperDgv.Columns
            Dim column As GridColumn = TryCast(item, GridColumn)
            Dim _TFormat As String = String.Empty
            '//
            Dim col As GridColumn = columns(column.Name)
            drName = Gdatatable_FieldName.Select("fname = '" & column.Name & "'", "")
            If drName.Length > 0 Then
                col.HeaderText = drName.First.Item("vietnamese").ToString
                _TFormat = drName.First.Item("dinhdang").ToString
            Else
                col.HeaderText = ""
                _TFormat = "-"
                '--
                sbXMLString.Append("<DATA ")
                sbXMLString.Append("fname='" + ReplaceTextXML(column.Name.ToLower) + "' ")
                sbXMLString.Append("vietnamese='-' ")
                sbXMLString.Append("english='-' ")
                sbXMLString.Append("ghichu='-' ")
                sbXMLString.Append("dinhdang='-' ")
                sbXMLString.Append(" />")

            End If
            '--
            If _TFormat = "0" Then
                col.EditorType = GetType(GridNumericUpDownEditControl)
                col.CellStyles.Default.Alignment = Alignment.MiddleRight
                Dim nc As GridNumericUpDownEditControl = CType(col.EditControl, GridNumericUpDownEditControl)
                nc.Minimum = -900000000000
                nc.Maximum = +900000000000
                nc.DecimalPlaces = 0
                '//
                col.RenderType = GetType(GridDoubleInputEditControl)
                Dim rc As GridDoubleInputEditControl = CType(col.RenderControl, GridDoubleInputEditControl)
                rc.DisplayFormat = "#,###,###;(#,###,###);-"
            ElseIf _TFormat = "1" Then
                col.EditorType = GetType(GridNumericUpDownEditControl)
                col.CellStyles.Default.Alignment = Alignment.MiddleRight
                Dim nc As GridNumericUpDownEditControl = CType(col.EditControl, GridNumericUpDownEditControl)
                nc.Minimum = -900000000000
                nc.Maximum = +900000000000
                nc.DecimalPlaces = 1
                '//
                col.RenderType = GetType(GridDoubleInputEditControl)
                Dim rc As GridDoubleInputEditControl = CType(col.RenderControl, GridDoubleInputEditControl)
                rc.DisplayFormat = "#,###.0;(#,###.0);-"
            ElseIf _TFormat = "2" Then
                col.EditorType = GetType(GridNumericUpDownEditControl)
                col.CellStyles.Default.Alignment = Alignment.MiddleRight
                Dim nc As GridNumericUpDownEditControl = CType(col.EditControl, GridNumericUpDownEditControl)
                nc.Minimum = -900000000000
                nc.Maximum = +900000000000
                nc.DecimalPlaces = 2
                '//
                col.RenderType = GetType(GridDoubleInputEditControl)
                Dim rc As GridDoubleInputEditControl = CType(col.RenderControl, GridDoubleInputEditControl)
                rc.DisplayFormat = "#,##0.#0#;(#,##0.#0#);-"
            ElseIf _TFormat = "3" Then
                col.EditorType = GetType(GridNumericUpDownEditControl)
                col.CellStyles.Default.Alignment = Alignment.MiddleRight
                Dim nc As GridNumericUpDownEditControl = CType(col.EditControl, GridNumericUpDownEditControl)
                nc.Minimum = -900000000000
                nc.Maximum = +900000000000
                nc.DecimalPlaces = 3
                '//
                col.RenderType = GetType(GridDoubleInputEditControl)
                Dim rc As GridDoubleInputEditControl = CType(col.RenderControl, GridDoubleInputEditControl)
                rc.DisplayFormat = "#,##0.##0;(#,##0.##0); "
            ElseIf _TFormat = "date" Then
                col.CellStyles.Default.Alignment = Alignment.MiddleLeft
                col.RenderType = GetType(GridDateTimeInputEditControl)
                Dim rc As GridDateTimeInputEditControl = CType(col.RenderControl, GridDateTimeInputEditControl)
                rc.CustomFormat = "dd/MM/yyyy"
                rc.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            ElseIf _TFormat = "datetime" Then
                col.CellStyles.Default.Alignment = Alignment.MiddleLeft
                col.RenderType = GetType(GridDateTimeInputEditControl)
                Dim rc As GridDateTimeInputEditControl = CType(col.RenderControl, GridDateTimeInputEditControl)

                rc.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
                rc.CustomFormat = "dd/MM/yy HH:mm:ss"
                '//
                'col.RenderType = GetType(GridDoubleInputEditControl)
                'Dim rc As GridDoubleInputEditControl = CType(col.RenderControl, GridDoubleInputEditControl)
                'rc.DisplayFormat = "#,##0.##0;(#,##0.##0); "

            ElseIf _TFormat = "checkbox" Then
                col.CellStyles.Default.Alignment = Alignment.MiddleCenter
                col.RenderType = GetType(GridCheckBoxXEditControl)
                Dim rc As GridCheckBoxXEditControl = CType(col.RenderControl, GridCheckBoxXEditControl)
                rc.CheckBoxStyle = eCheckBoxStyle.CheckBox
                rc.Width = 30
                rc.Height = 30
            ElseIf _TFormat = "6" Then
                col.CellStyles.Default.Alignment = Alignment.MiddleLeft
                col.RenderType = GetType(GridDateTimeInputEditControl)
                Dim rc As GridDateTimeInputEditControl = CType(col.RenderControl, GridDateTimeInputEditControl)
                rc.Format = DevComponents.Editors.eDateTimePickerFormat.Short
            ElseIf _TFormat = "8" Then
                col.EditorType = GetType(GridNumericUpDownEditControl)
                col.CellStyles.Default.Alignment = Alignment.MiddleRight
                Dim nc As GridNumericUpDownEditControl = CType(col.EditControl, GridNumericUpDownEditControl)
                nc.Minimum = -900000000000
                nc.Maximum = +900000000000
                nc.DecimalPlaces = 0
                '//
                col.RenderType = GetType(GridDoubleInputEditControl)
                Dim rc As GridDoubleInputEditControl = CType(col.RenderControl, GridDoubleInputEditControl)
                rc.DisplayFormat = "#,###,###;(#,###,###);-"
            End If
        Next item
        '//
        sbXMLString.Append("</Root>")
        cls.ExcuteDataStoredXML("[VpsXmlList_FieldName_UpSet]", sbXMLString.ToString, "insert")
    End Sub

#End Region

    Public Sub Format_Super_Dgv(ByVal dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl, ByVal _fontSize As Integer)
        If IsNumeric(_fontSize) = False Then
            _fontSize = 9
        Else
            If _fontSize < 8 Then
                _fontSize = 8
            End If
        End If
        Dim _MyFont_Header_dgv As New Font("Time New Roman", lfontsize - 1, FontStyle.Bold)
        Dim _MyFont_dgv As New Font("Time New Roman", lfontsize, FontStyle.Regular)
        With dgv
            .Dock = DockStyle.Fill
            .DefaultVisualStyles.FilterColumnHeaderStyles.Default.Background.Color1 = Color.White
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowMultiLine = Tbool.True
            .DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = Tbool.True
            With .PrimaryGrid
                .GroupHeaderClickBehavior = GroupHeaderClickBehavior.ExpandCollapse
                .GroupHeaderHeight = lGroupHeaderHeight
                .ColumnHeader.RowHeight = lColumnHeaderRowHeight
                .Filter.Visible = True
                .RowHeaderIndexOffset = 1
                .NoRowsText = ""
                .AutoExpandSetGroup = False
                .ColumnAutoSizeMode = ColumnAutoSizeMode.None
                .DefaultVisualStyles.CellStyles.Default.Font = _MyFont_dgv
                .DefaultVisualStyles.ColumnHeaderStyles.Default.Font = _MyFont_Header_dgv
                .DefaultVisualStyles.GroupHeaderStyles.Default.Font = _MyFont_Header_dgv
                .DefaultVisualStyles.FilterColumnHeaderStyles.Default.Font = _MyFont_dgv
                .DefaultVisualStyles.CellStyles.Default.Margin.Left = 10
                .DefaultVisualStyles.CellStyles.Default.Margin.Right = 5
                .DefaultRowHeight = ldefaultRowheight
                .MinRowHeight = ldefaultRowheight
                .VirtualRowHeight = 25
                .Filter.RowHeight = 25
                .GroupByRow.RowHeight = 25
                .DefaultVisualStyles.FilterColumnHeaderStyles.Default.Background.Color1 = Color.Yellow
            End With
        End With
    End Sub

    Public Sub UpdateDetails_Checked(ByVal rows As IEnumerable(Of GridElement), ByVal _value As Boolean)
        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetails_Checked(group.Rows, _value)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True Then
                    row.Checked = _value
                End If
            End If
        Next
    End Sub


    Public Function Total_Row(ByVal group As GridGroup) As Integer
        Dim n As Integer = 0
        For Each item As GridElement In group.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True AndAlso row.IsDetailRow = False Then
                n += 1
            End If
        Next
        Return (n)
    End Function
    Public Function Total_Group(ByVal columns As GridColumnCollection, ByVal group As GridGroup, ByVal detailRow As Boolean, ByVal _array As String()) As Object

        For Each item As GridContainer In group.Rows
            Dim aControl As GridGroup = TryCast(item, GridGroup)
            If aControl IsNot Nothing Then
                _Gnumber1 += Total_Group(columns, aControl, False, _array)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True Then
                    If row.IsDetailRow = False Then
                        '--
                        Dim _svalue As Decimal = 0
                        For x As Integer = 0 To _array.Length - 1
                            If columns.Contains(_array(x)) = True Then
                                _svalue = _Gnumber_group(x)
                                If IsDBNull(row.Cells(_array(x)).Value) = False Then
                                    _svalue += row.Cells(_array(x)).Value
                                End If
                                _Gnumber_group.SetValue(_svalue, x)
                            Else
                                '_Gnumber_group.SetValue(0, x)
                            End If

                        Next
                    End If
                End If
            End If
        Next item
        Return Nothing
    End Function


#Region "PROPERTY"
    Public Function GetInfoHeaderColor(ByVal columns As GridColumnCollection, ByVal _col1 As String, ByVal _col2 As String,
                                             ByVal _Name As String, ByVal _HextTex As String, ByVal _Color As Color) As ColumnGroupHeader
        Dim cgh As New ColumnGroupHeader()
        If columns.Contains(_col1) = True AndAlso columns.Contains(_col2) = True Then

            cgh.Name = _Name
            cgh.HeaderText = _HextTex
            cgh.MinRowHeight = 25
            cgh.HeaderStyles.Default.ImagePadding = New DevComponents.DotNetBar.SuperGrid.Style.Padding(6)
            ' Set the header's start and end Display Indecees
            If GetDisplayIndex(columns, _col1) < GetDisplayIndex(columns, _col2) Then
                cgh.StartDisplayIndex = GetDisplayIndex(columns, _col1)
                cgh.EndDisplayIndex = GetDisplayIndex(columns, _col2)
            Else
                cgh.StartDisplayIndex = 0
                cgh.EndDisplayIndex = 0
            End If
        Else
            cgh.StartDisplayIndex = 0
            cgh.EndDisplayIndex = 0
        End If
        cgh.HeaderStyles.Default.Background.Color1 = _Color
        Return (cgh)
    End Function

    Public Function GetInfoHeader(ByVal columns As GridColumnCollection, ByVal _col1 As String, ByVal _col2 As String,
                                             ByVal _Name As String, ByVal _HextTex As String) As ColumnGroupHeader
        Dim cgh As New ColumnGroupHeader()
        If columns.Contains(_col1) = True AndAlso columns.Contains(_col2) = True Then

            cgh.Name = _Name
            cgh.HeaderText = _HextTex
            cgh.MinRowHeight = 25
            cgh.HeaderStyles.Default.ImagePadding = New DevComponents.DotNetBar.SuperGrid.Style.Padding(6)
            ' Set the header's start and end Display Indecees
            If GetDisplayIndex(columns, _col1) < GetDisplayIndex(columns, _col2) Then
                cgh.StartDisplayIndex = GetDisplayIndex(columns, _col1)
                cgh.EndDisplayIndex = GetDisplayIndex(columns, _col2)
            Else
                cgh.StartDisplayIndex = 0
                cgh.EndDisplayIndex = 0
            End If
        Else
            cgh.StartDisplayIndex = 0
            cgh.EndDisplayIndex = 0
        End If
        'cgh.HeaderStyles.Default.Background.Color1 = Color.AliceBlue
        Return (cgh)
    End Function

    Public Function GetDisplayIndex(ByVal columns As GridColumnCollection, ByVal name As String) As Integer
        If columns.Contains(name.ToLower) = True Then
            Return (columns.GetDisplayIndex(columns(name)))
        End If

    End Function

    Public Function GetNewDetailRow(ByVal panel As GridPanel) As GridRow
        Dim myList As New List(Of Object)
        For y = 0 To panel.Columns.Count
            myList.Add(Nothing)
        Next
        Dim row As New GridRow(myList)
        ' Don't let the user change the row contents
        row.[ReadOnly] = True
        Return (row)
    End Function

#End Region

#Region "GETVALUE"
    Public Function GetValueSuperStr(ByVal Panel As DevComponents.DotNetBar.SuperGrid.GridPanel, ByVal name As String) As String
        Dim columns As GridColumnCollection = Panel.Columns
        Dim dgvr As GridRow = CType(Panel.ActiveRow, GridRow)
        Dim Result As String = String.Empty
        If columns.Contains(name.ToLower) = True Then
            Result = dgvr.Cells(name).Value.ToString
        End If
        Return Result
    End Function

#End Region


End Class
