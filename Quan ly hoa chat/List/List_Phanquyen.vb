

Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text
Public Class List_Phanquyen
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private dt_local As DataTable
    Private dt_frame As DataTable
    '--
    Dim dr2 As DataRow()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"xem", "them", "stt"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    '//
    Dim _Order_ID_Nhom As String = String.Empty, _Order_ID As String = String.Empty

#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        Call clsDev.SaveColumn(Super_Dgv_Group.PrimaryGrid, Me.Name.ToString)
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
        dt_frame = New DataTable
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView)
        '----------
        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv_Group.DataBindingComplete, AddressOf Super_Dgv_group_DataBindingComplete
        'AddHandler Super_Dgv.ColumnHeaderClick, AddressOf ColumnHeaderClick
        AddHandler Super_Dgv.CellClick, AddressOf CellClick
        AddHandler Super_Dgv.CellValueChanged, AddressOf Super_Dgv_CellValueChanged
        '//
        With Super_Dgv_Group
            .PrimaryGrid.CheckBoxes = False
            .PrimaryGrid.Filter.Visible = False
            .PrimaryGrid.MultiSelect = False
            .PrimaryGrid.RowHeaderIndexOffset = 1
        End With
    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        'Call Check_administrator(Me.Name.ToString)
        If True = True Then
            Call Filterdata_Stored()
            Call Filterdata_chung()
            '----------------
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        cm.Popup(MousePosition)
    End Sub
    Private Sub CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = CType(sender.PrimaryGrid, GridPanel)
        If e.MouseEventArgs.Button = MouseButtons.Right Then
            ShowContextMenu(CtxFunction)
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
                panel.AllowEdit = True
                panel.ReadOnly = False
            End If
        ElseIf e.GridCell.ColumnIndex > e.GridPanel.Columns.Count Then
            panel.AllowEdit = False
            panel.ReadOnly = True
        End If
    End Sub

    Private Sub Super_Dgv_CellValueChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs)
        clsDev.SuperDgv_CellValueChanged(sender, e)
    End Sub

    Private Sub Super_Dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Super_Dgv.KeyDown
        clsDev.Super_Dgv_KeyDown(sender, e)
    End Sub
#End Region

#Region "DGV_CHUNG"
    Private Sub Super_Dgv_Group_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs) Handles Super_Dgv_Group.CellClick
        Dim panel As GridPanel = Super_Dgv_Group.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        'If e.MouseEventArgs.Button = MouseButtons.Right Then
        'ShowContextMenu(CtxFunction)
        'End If
        If e.GridCell.ColumnIndex = 0 Then
            panel.ReadOnly = False
            If dgvr.Checked = False Then
                'dgvr.Checked = True
                'dgvr.CellStyles.Default.Background.Color1 = Color.GreenYellow
            Else
                'dgvr.Checked = False
                'dgvr.CellStyles.Default.Background.Color1 = Color.White
            End If
        Else
            panel.AllowEdit = False
            panel.ReadOnly = True
        End If
        '//
        If dgvr Is Nothing Then
            _Order_ID_Nhom = String.Empty
            Exit Sub
        Else
            _Order_ID_Nhom = dgvr.Cells("nhom_id").Value.ToString
            panel.Caption.Text = "NHÓM: " & dgvr.Cells("nhom").Value.ToString
        End If
        Call Filterdata_Stored()
    End Sub

    Private Sub Filterdata_chung()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlList_User_Nhom_UpSet]", sbXMLString.ToString, "select_group")
        dtControler.SELECT_XML(_dt, Super_Dgv_Group.PrimaryGrid)

    End Sub
    Private Sub Super_Dgv_group_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        '//
        Dim sortCols As GridColumn() = New GridColumn() {e.GridPanel.Columns("tennhom"), e.GridPanel.Columns("nhom_id")}

        If e.GridPanel.SortColumns.Count = 2 Then
            'e.GridPanel.SetSort(sortCols, clsDev.GetSortDirAscAsc(sortCols))
        Else
            'e.GridPanel.SetSort(sortCols, clsDev.GetSortDirAscAsc(sortCols))
        End If
        '//
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
        sbXMLString.Append("nhom_id='" + ReplaceTextXML(_Order_ID_Nhom) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmllIST_PhanQuyen_UpSet]", sbXMLString.ToString, "select_group")
        Super_Dgv.SuspendLayout()
        Super_Dgv.BeginUpdate()
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        Super_Dgv.EndUpdate()
        Super_Dgv.ResumeLayout()
        Call CircleProcess_Stop()
        IsBusy = False
        Me.ResumeLayout()
    End Sub


    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        'panel.AddGroup(panel.Columns(_colnhomhc))
        '--
        Dim sortCols As GridColumn() = New GridColumn() {e.GridPanel.Columns("formgroup"), e.GridPanel.Columns("frmname")}
        If panel.SortColumns.Count = 2 Then
            'panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        Else
            'panel.SetSort(sortCols, clsDev.GetSortDirDesAsc(sortCols))
        End If
        '//
        '//
        'AddHandler tpress.Tick, AddressOf MyTickHandler
        'tpress.Enabled = True
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
                If e.GridGroup.Column.Name.ToString.ToUpper = _colkhachhang.ToString.ToUpper Then
                    e.GridGroup.Text = "NHÓM: " & e.GridGroup.GroupValue.ToString.ToUpper
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
    Private Sub Filterdata_Frame()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("codename='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("VpsXmlList_FrmName_UpSet", sbXMLString.ToString, "select")
        dt_frame = dtControler.SELECT_XML_Datatable(_dt)
    End Sub
    Private Sub btLoad_AllForm_Click(sender As Object, e As EventArgs) Handles btLoad_AllForm.Click
        Filterdata_Frame()
        '///
        If _Order_ID_Nhom = "" Then
            MsgBox("Kiểm tra nhóm.", MsgBoxStyle.Critical, "Fault")
            Exit Sub
        End If
        '//

        btLoad_AllForm.Enabled = False
        Dim _intLoop As Integer = 0
        Dim st As String = String.Empty
        Dim _frmname As String = String.Empty

        '//Add xml to insert
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        For Each dt2_row As System.Data.DataRow In dt_frame.Rows
            _intLoop += 1
            '//
            _frmname = dt2_row.Item("frmname_id")
            Dim _phanquyen_id As String = _Order_ID_Nhom & _intLoop.ToString
            Dim _frmname_nhom_id As String = _frmname.ToLower & _Order_ID_Nhom.ToLower
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("phanquyen_id='" + ReplaceTextXML(_phanquyen_id.ToLower) + "' ")
            sbXMLString.Append("frmname_nhomid='" + ReplaceTextXML(_frmname_nhom_id) + "' ")
            sbXMLString.Append("nhom_id='" + ReplaceTextXML(_Order_ID_Nhom) + "' ")
            sbXMLString.Append("frmname_id='" + ReplaceTextXML(_frmname) + "' ")
            sbXMLString.Append("them='0' ")
            sbXMLString.Append("sua='0' ")
            sbXMLString.Append("xoa='0' ")
            sbXMLString.Append("xem='0' ")
            sbXMLString.Append("excel='0' ")
            sbXMLString.Append("pdf='0' ")
            sbXMLString.Append("level_1='0' ")
            sbXMLString.Append("level_2='0' ")
            sbXMLString.Append("level_3='0' ")
            sbXMLString.Append(" />")
        Next dt2_row
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("VpsXmllIST_PhanQuyen_UpSet", sbXMLString.ToString, "insert")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
        btLoad_AllForm.Enabled = True
    End Sub

    Private Sub CtxFunction_Modify_Click(sender As Object, e As EventArgs) Handles CtxFunction_Modify.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                row.Cells("sua").Value = True
                row.Checked = True
            End If
        Next
    End Sub

    Private Sub CtxFunction_delete_Click(sender As Object, e As EventArgs) Handles CtxFunction_delete.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                row.Cells("xoa").Value = True
                row.Checked = True
            End If
        Next
    End Sub

    Private Sub CtxFunction_Xem_Click(sender As Object, e As EventArgs) Handles CtxFunction_Xem.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                row.Cells("xem").Value = True
                row.Checked = True
            End If
        Next
    End Sub



    Private Sub CtxFunction_Add_Click(sender As Object, e As EventArgs) Handles CtxFunction_Add.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                row.Cells("them").Value = True
                row.Checked = True
            End If
        Next
    End Sub


#Region "LUU THAY DOI"
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        Call UpdateDetailsInsertJob(panel.Rows)
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New ListMenuDTO("[VpsXmllIST_PhanQuyen_UpSet]", sbXMLString.ToString, "update")
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub



    Private Sub UpdateDetailsInsertJob(ByVal rows As IEnumerable(Of GridElement))

        For Each item As GridElement In rows
            Dim group As GridGroup = TryCast(item, GridGroup)
            If group IsNot Nothing Then
                UpdateDetailsInsertJob(group.Rows)
            Else
                Dim row As GridRow = TryCast(item, GridRow)
                If row IsNot Nothing AndAlso row.Visible = True AndAlso row.Checked = True AndAlso row.IsDetailRow = False Then

                    sbXMLString.Append("<DATA ")
                    sbXMLString.Append("phanquyen_id='" + ReplaceTextXML(row.Cells("phanquyen_id").Value.ToString) + "' ")
                    sbXMLString.Append("them='" + row.Cells("them").Value.ToString + "' ")
                    sbXMLString.Append("sua='" + row.Cells("sua").Value.ToString + "' ")
                    sbXMLString.Append("xoa='" + row.Cells("xoa").Value.ToString + "' ")
                    sbXMLString.Append("xem='" + row.Cells("xem").Value.ToString + "' ")
                    sbXMLString.Append("excel='" + row.Cells("excel").Value.ToString + "' ")
                    sbXMLString.Append("pdf='" + row.Cells("pdf").Value.ToString + "' ")
                    sbXMLString.Append("level_1='" + row.Cells("level_1").Value.ToString + "' ")
                    sbXMLString.Append("level_2='" + row.Cells("level_2").Value.ToString + "' ")
                    sbXMLString.Append("level_3='" + row.Cells("level_3").Value.ToString + "' ")
                    sbXMLString.Append(" />")
                End If
            End If
        Next

    End Sub





#End Region
    Private Sub ButtonItem_Disable_Add_Click(sender As Object, e As EventArgs) Handles ButtonItem_Disable_Add.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                row.Cells("them").Value = False
                row.Checked = True
            End If
        Next
    End Sub

    Private Sub ButtonItem_Disable_Delete_Click(sender As Object, e As EventArgs) Handles ButtonItem_Disable_Delete.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                row.Cells("xoa").Value = False
                row.Checked = True
            End If
        Next
    End Sub

    Private Sub ButtonItem_Disable_View_Click(sender As Object, e As EventArgs) Handles ButtonItem_Disable_View.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                row.Cells("xem").Value = False
                row.Checked = True
            End If
        Next
    End Sub

    Private Sub ButtonItem_Disable_Update_Click(sender As Object, e As EventArgs) Handles ButtonItem_Disable_Update.Click
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        For Each item As GridElement In panel.Rows
            Dim row As GridRow = TryCast(item, GridRow)
            If row IsNot Nothing AndAlso row.Visible = True Then
                row.Cells("sua").Value = False
                row.Checked = True
            End If
        Next
    End Sub
End Class