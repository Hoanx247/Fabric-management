
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports DevComponents.DotNetBar
Imports System.Text
Public Class List_frmName
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private dt_local As DataTable
    '--
    Dim dr2 As DataRow()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"frmnamefull", "stt", "invisible", "nhom", "ghichu"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Private _Order_ID As String = String.Empty
    Private IsProcessing As Boolean = False
    Private Ischeck As Boolean = False
    Private Isupdate As Boolean = False
#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Super_Dgv.Dispose()
        Me.Dispose()
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_local = New DataTable

        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView)
        '----------
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        'AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            Call Filterdata_Stored()
            '----------------
        Else
            Me.Close()
        End If
    End Sub

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
        If IsProcessing = True Then Exit Sub
        clsDev.SuperDgv_CellValueChanged(sender, e)
    End Sub

    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Super_Dgv.KeyDown
        clsDev.Super_Dgv_KeyDown(sender, e)
    End Sub
#End Region

#Region " THONG TIN CHUNG"

    Private Sub CircleProcess_Start()
        With CircularProgress1
            .Location = New Point(CInt((Super_Dgv.Width - .Width) / 2), CInt((Super_Dgv.Height - .Height) / 2))
            .IsRunning = True
            .Visible = True
        End With
    End Sub

    Private Sub CircleProcess_Stop()
        wait(300)
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
        sbXMLString.Append("code='" + ReplaceTextXML(txtfrm_F.Text) + "' ")
        sbXMLString.Append("codename='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("VpsXmlList_FrmName_UpSet", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '//
        Dim _condition As String = "frmname like '%" & txtfrm_F.Text & "%'"
        If CheckBoxX_All.CheckState = CheckState.Checked Then
            _condition = "frmname like '%" & txtfrm_F.Text & "%'"
        Else
            _condition = "invisible=0 and frmname like '%" & txtfrm_F.Text & "%'"

        End If
        Dim dataSource As Object = Nothing
        '--
        Dim rows() As DataRow = Nothing
        If String.IsNullOrEmpty(_condition) = True Then
            rows = dt_local.Select
        Else
            rows = dt_local.Select(_condition)
        End If
        If rows.Count > 0 Then ' first check to see if the array has rows '
            dataSource = rows.CopyToDataTable() ' dt now exists and contains rows '
        Else
            dataSource = Nothing
        End If
        '//
        Dim panel As GridPanel = CType(Super_Dgv.PrimaryGrid, GridPanel)
        panel.DataSource = dataSource
        '///
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub


    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '//Ẩn Cột
        For Each item As GridElement In panel.Columns
            Dim column As GridColumn = TryCast(item, GridColumn)
            Dim _TFormat As String = String.Empty
            If column.Name.ToLower.Contains("_id") = True Then
                column.Visible = False
            End If
            If column.Name.ToLower.Contains("nhom") = True Then
                column.HeaderText = "Nhóm"
            End If
        Next item
        '//
        '--
        Dim sortCols As GridColumn() = New GridColumn() {e.GridPanel.Columns("nhom"), e.GridPanel.Columns("frmname")}
        If e.GridPanel.SortColumns.Count = 2 Then
            e.GridPanel.SetSort(sortCols, clsDev.GetSortDirAscAsc(sortCols))
        Else
            e.GridPanel.SetSort(sortCols, clsDev.GetSortDirAscAsc(sortCols))
        End If
        '//
        For Each item As GridElement In panel.Rows
            Dim Row As GridRow = TryCast(item, GridRow)
            Dim _TFormat As String = String.Empty
            If Row IsNot Nothing AndAlso Row.IsDetailRow = False AndAlso Row.Visible = True Then
                If CBool(Row.Cells("invisible").Value) = True Then
                    Row.Cells("invisible").CellStyles.Default.Background.Color1 = Color.Red
                Else
                    Row.Cells("invisible").CellStyles.Default.Background.Color1 = Color.Empty
                End If
            End If
        Next item
        '//
        'Dim column As GridColumn
        'column = panel.Columns("btnedit")
        'column.EditorType = GetType(MyGridButtonXEditControl)
        '//
        'column = panel.Columns("btnedit_1")
        'column.EditorType = GetType(MyGridButtonXEditControl)
        '//
        'column = panel.Columns("btnedit_2")
        'column.EditorType = GetType(MyGridButtonXEditControl)
        '//
        'column = panel.Columns("btnopen_1")
        'column.EditorType = GetType(MyGridButtonXEditControl)
        '//
        'column = panel.Columns("btnopen_2")
        'column.EditorType = GetType(MyGridButtonXEditControl)
        '//
        'column = panel.Columns("btndelete")
        'column.EditorType = GetType(MyGridButtonXEditControl)
        '//
        'AddHandler tpress.Tick, AddressOf MyTickHandler
        'tpress.Enabled = True
    End Sub


#End Region
    Private Sub ButtonItem_LuuThayDoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem_LuuThayDoi.Click
        If IsProcessing = True Then Exit Sub
        IsProcessing = True
        '//
        Dim _FormName As String = String.Empty
        Dim intRow As Integer = 0
        Dim _frmname_ID As String = String.Empty
        Dim _visible As Boolean = False
        '--
        '//Add xml to insert
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '///
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim columns As GridColumnCollection = panel.Columns
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                sbXMLString.Append("<DATA ")
                sbXMLString.Append("frmname_id='" + ReplaceTextXML(row.Cells("frmname_id").Value.ToString) + "' ")
                sbXMLString.Append("frmname='" + ReplaceTextXML(row.Cells("frmname").Value.ToString) + "' ")
                sbXMLString.Append("frmnamefull='" + ReplaceTextXML(row.Cells("frmnamefull").Value.ToString) + "' ")
                sbXMLString.Append("nhom='" + ReplaceTextXML(row.Cells("nhom").Value.ToString) + "' ")
                sbXMLString.Append("ghichu='" + ReplaceTextXML(row.Cells("ghichu").Value.ToString) + "' ")
                sbXMLString.Append("invisible='" + ReplaceTextXML(row.Cells("invisible").Value.ToString) + "' ")
                sbXMLString.Append("stt='" + ReplaceTextXML(row.Cells("stt").Value.ToString) + "' ")
                sbXMLString.Append(" />")
            End If
        Next
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("VpsXmlList_FrmName_UpSet", sbXMLString.ToString, "update")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
        '//
        IsProcessing = False
    End Sub

    Private Sub ButtonItem_Upgrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem_Upgrade.Click
        If IsProcessing = True Then Exit Sub
        IsProcessing = True
        '//
        Dim _intLoop As Byte = 0
        Dim st As String = String.Empty
        Dim list = AppDomain.CurrentDomain.GetAssemblies().ToList().
                    SelectMany(Function(s) s.GetTypes()).
                    Where(Function(p) (p.BaseType Is [GetType]().BaseType AndAlso
                                       p.Assembly Is [GetType]().Assembly))
        '--
        'Call Refresh_New_Update()
        wait(200)
        '_Order_ID = Now.Ticks.ToString
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Dim _frmId As String = String.Empty
        For Each type As Type In list
            Dim typeName As String = type.Name
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("frmname_id='" + ReplaceTextXML(typeName.ToLower) + "' ")
            sbXMLString.Append("frmname='" + ReplaceTextXML(typeName) + "' ")
            sbXMLString.Append(" />")
        Next
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("VpsXmlList_FrmName_UpSet", sbXMLString.ToString, "insert")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
        '//
        IsProcessing = False
    End Sub

#Region "MyGridButtonXEditControl"

    ''' <summary>
    ''' GridButtonXEditControl Class that controls the
    ''' ButtonX color initialization and user button clicks.
    ''' </summary>
    Private Class MyGridButtonXEditControl
        Inherits GridButtonXEditControl
        ''' <summary>
        ''' Constructor
        ''' </summary>
        Public Sub New()
            ' We want to be notified when the user clicks the button
            ' so that we can change the underlying cell value to reflect
            ' the mouse click.

            AddHandler Click, AddressOf MyGridButtonXEditControlClick
        End Sub

#Region "InitializeContext"

        ''' <summary>
        ''' Initializes the color table for the button
        ''' </summary>
        ''' <param name="cell"></param>
        ''' <param name="style"></param>
        Public Overrides Sub InitializeContext(ByVal cell As GridCell, ByVal style As CellVisualStyle)
            MyBase.InitializeContext(cell, style)

            Dim running As Boolean = Text.Equals("Mở File") = False

            ColorTable = IIf(running = True, eButtonColor.OrangeWithBackground, eButtonColor.BlueOrb)
        End Sub

#End Region

#Region "MyGridButtonXEditControlClick"

        ''' <summary>
        ''' Handles user clicks of the button
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MyGridButtonXEditControlClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim running As Boolean = (EditorCell.Value IsNot Nothing)
            'EditorCell.GridRow.IsDeleted = True
            'EditorCell.Value = IIf(running = True, "Stop", "Start")
            ' Call ShowDialog.
            If EditorCell.Value.Equals("Tên File 1") Then
                Dim fd As OpenFileDialog = New OpenFileDialog()
                Dim strFileName As String
                fd.Title = "Open File Dialog"
                fd.InitialDirectory = My.Application.Info.DirectoryPath & "\Excel\"
                fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
                fd.FilterIndex = 2
                fd.RestoreDirectory = True

                If fd.ShowDialog() = DialogResult.OK Then
                    strFileName = fd.FileName
                    '//
                    EditorCell.GridRow.Cells("fileexcel_1").Value = fd.SafeFileName.ToString
                End If
            End If
            If EditorCell.Value.Equals("Mở File 1") Then
                Dim strFileName As String = My.Application.Info.DirectoryPath & "\Excel\" & EditorCell.GridRow.Cells("fileexcel_1").Value.ToString
                '///
                If EditorCell.GridRow.Cells("fileexcel_1").Value.ToString IsNot Nothing AndAlso Len(EditorCell.GridRow.Cells("fileexcel_1").Value.ToString) > 4 Then
                    System.Diagnostics.Process.Start(strFileName)
                End If

            End If
            '//
            If EditorCell.Value.Equals("Tên File 2") Then
                Dim fd As OpenFileDialog = New OpenFileDialog()
                Dim strFileName As String
                fd.Title = "Open File Dialog"
                fd.InitialDirectory = My.Application.Info.DirectoryPath & "\Excel\"
                fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
                fd.FilterIndex = 2
                fd.RestoreDirectory = True

                If fd.ShowDialog() = DialogResult.OK Then
                    strFileName = fd.FileName
                    '//
                    EditorCell.GridRow.Cells("fileexcel_2").Value = fd.SafeFileName.ToString
                End If
            End If
            '//
            If EditorCell.Value.Equals("Xóa") Then
                EditorCell.GridRow.IsDeleted = True
            End If
        End Sub

#End Region

    End Class

    Private Sub txtfrm_F_TextChanged(sender As Object, e As EventArgs) Handles txtfrm_F.TextChanged
        '//
        Dim _condition As String = "frmname like '%" & txtfrm_F.Text & "%'"
        Dim dataSource As Object = Nothing
        '--
        Dim rows() As DataRow = Nothing
        If String.IsNullOrEmpty(_condition) = True Then
            rows = dt_local.Select
        Else
            rows = dt_local.Select(_condition)
        End If
        If rows.Count > 0 Then ' first check to see if the array has rows '
            dataSource = rows.CopyToDataTable() ' dt now exists and contains rows '
        Else
            dataSource = Nothing
        End If
        '//
        Dim panel As GridPanel = CType(Super_Dgv.PrimaryGrid, GridPanel)
        panel.DataSource = dataSource
        '///
    End Sub

    Private Sub ButtonItem_Check_Click(sender As Object, e As EventArgs) Handles ButtonItem_Check.Click
        If IsProcessing = True Then Exit Sub
        IsProcessing = True
        '//
        Ischeck = False
        '//
        Dim _intLoop As Byte = 0
        Dim st As String = String.Empty
        Dim list = AppDomain.CurrentDomain.GetAssemblies().ToList().
                    SelectMany(Function(s) s.GetTypes()).
                    Where(Function(p) (p.BaseType Is [GetType]().BaseType AndAlso
                                       p.Assembly Is [GetType]().Assembly))
        wait(200)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        For Each type As Type In list
            Dim typeName As String = type.Name
            '//Ẩn Cột
            For Each item As GridElement In panel.Rows
                Dim Row As GridRow = TryCast(item, GridRow)
                Dim _TFormat As String = String.Empty
                If Row IsNot Nothing AndAlso Row.IsDetailRow = False AndAlso Row.Visible = True Then
                    If Row.Cells("frmname").Value.ToString.ToLower = typeName.ToLower.ToString Then
                        Row.Cells("new_update").Value = 1
                        Row.Cells("new_update").CellStyles.Default.Background.Color1 = Color.LightBlue
                    End If
                End If
            Next item
            '//
        Next
        '//
        IsProcessing = False

        Ischeck = True
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Ischeck = False Then Exit Sub
        '//
        If IsProcessing = True Then Exit Sub
        IsProcessing = True
        '//
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        For Each item As GridElement In panel.Rows
            Dim Row As GridRow = TryCast(item, GridRow)
            Dim _TFormat As String = String.Empty
            If Row IsNot Nothing AndAlso Row.IsDetailRow = False AndAlso Row.Visible = True AndAlso CBool(Row.Cells("new_update").Value) = False Then
                sbXMLString.Append("<DATA ")
                sbXMLString.Append("frmname_id='" + ReplaceTextXML(Row.Cells("frmname_id").Value.ToString) + "' ")
                sbXMLString.Append(" />")
            End If
        Next item
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("VpsXmlList_FrmName_UpSet", sbXMLString.ToString, "delete")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
        '//
        IsProcessing = False
        '//
        Ischeck = False
    End Sub


#End Region
    Private Sub btTim_Click(sender As Object, e As EventArgs) Handles btTim.Click
        Call Filterdata_Stored()
    End Sub

End Class