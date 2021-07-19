Imports DevComponents.DotNetBar.SuperGrid
Public Class KhoMocNhapKhoDAL
    Private Cls As Clsconnect
    Private clsDev As ClsDevcomponent
    Public Sub New()
        Cls = New Clsconnect()
        clsDev = New ClsDevcomponent()
    End Sub

    Public Sub SuperDgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs, ByVal FormName As String)
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        '//
        Call clsDev.LoadColumn(panel, FormName)

    End Sub
    Public Sub PanelFooter(ByVal Panel As GridPanel, ByVal Data As String)
        Panel.Footer.Visible = True
        Panel.Footer.Text = Data
        Panel.DefaultVisualStyles.FooterStyles.Default.Alignment = Style.Alignment.MiddleLeft
        Panel.DefaultVisualStyles.FooterStyles.Default.Font = _MyFont_group
    End Sub

    Public Function UPSET_XML(ByVal D As KhoMocNhapKhoDTO) As Boolean
        Dim Result As Boolean = False
        Result = Cls.ExcuteDataStoredXML(D.sqlcommand, D.xml, D.Command)
        If Cls.HasException(True) = False Then
            Result = True
        Else
            Result = False
        End If
        Return Result
    End Function

    Public Function SELECT_XML(ByVal D As KhoMocNhapKhoDTO, ByVal panel As GridPanel) As DataTable
        Dim dt As New DataTable
        Cls.SelectData_Stored_XML(D.sqlcommand, D.xml, D.Command)
        ' REPORT & ABORT ON ERRORS
        If Cls.HasException(True) = False Then
            '//
            Dim _condition As String = String.Empty
            Dim dataSource As Object = Nothing
            '--
            Dim rows() As DataRow = Nothing
            If String.IsNullOrEmpty(_condition) = True Then
                rows = Cls.dt.Select
            Else
                rows = Cls.dt.Select(_condition)
            End If
            If rows.Count > 0 Then ' first check to see if the array has rows '
                dataSource = rows.CopyToDataTable() ' dt now exists and contains rows '
            Else
                dataSource = Nothing
            End If
            '//
            dt = Cls.dt
            panel.DataSource = dataSource
        Else
            dt = Nothing
        End If
        Return dt
    End Function
    Public Function SELECT_XML_Datatable(ByVal D As KhoMocNhapKhoDTO) As DataTable
        Dim dt As New DataTable
        Cls.SelectData_Stored_XML(D.sqlcommand, D.xml, D.Command)
        ' REPORT & ABORT ON ERRORS
        If Cls.HasException(True) = False Then
            dt = Cls.dt
        Else
            dt = Nothing
        End If
        Return dt
    End Function

End Class
