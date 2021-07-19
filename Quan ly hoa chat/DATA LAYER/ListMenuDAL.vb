Imports DevComponents.DotNetBar.SuperGrid
Public Class ListMenuDAL
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

    Public Function UPSET_XML(ByVal D As ListMenuDTO) As Boolean
        Dim Result As Boolean = False
        Result = Cls.ExcuteDataStoredXML(D.sqlcommand, D.xml, D.Command)
        ' REPORT & ABORT ON ERRORS
        Cls.HasException(True)
        '//
        Return Result
    End Function

    Public Sub SELECT_XML(ByVal D As ListMenuDTO, ByVal panel As GridPanel)
        Cls.SelectData_Stored_XML(D.sqlcommand, D.xml, D.Command)
        ' REPORT & ABORT ON ERRORS
        If Cls.HasException(True) Then Exit Sub
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
        panel.DataSource = dataSource
    End Sub

    Public Function SELECT_XML_Datatable(ByVal D As ListMenuDTO)
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
