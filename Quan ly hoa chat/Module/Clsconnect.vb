Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.ComponentModel

Imports System.Text
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Clsconnect
    Private cn As SqlConnection
    Private cmd As SqlCommand
    Private adapter As SqlDataAdapter
    Private ds As DataSet

    Public dt As DataTable
    Dim dt_local As New DataTable
    Private gsqlDataReader As SqlDataReader

    '--
    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String


#Region "SQL NEW"
    ' ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function

#End Region


#Region "Mo ket noi"
    Private Sub EnableConnect()
        Try
            Dim st As String
            ' Chuoi ket noi theo dac quyen he dieu hanh
            'st = "Data Source=(local);Database=MyDB;Integrated Security=true;"
            ' Chuoi ket noi theo dac quyen cua he quan tri SQL
            st = "Data Source='" & _GConnect_LDatasource_KhoMoc & "';uid='" & _GConnect_LUser_KhoMoc & "';pwd='" & _GConnect_LPass_KhoMoc & "';Database='" & _GConnect_LDatabase_KhoMoc & "';Integrated Security=false;"
            'st = "Data Source=HOANGUYEN\HOANGUYEN;uid=sa;pwd=pm@12345;Database=MyDB;Integrated Security=false;"
            Khoitao()
            cn.ConnectionString = st
            cn.Open()
        Catch ex As Exception
            Dong()
        End Try

    End Sub
    Public Sub Khoitao()
        Try
            cn = New SqlConnection
            cmd = New SqlCommand
            adapter = New SqlDataAdapter(cmd)
            ds = New DataSet
            dt = New DataTable
        Catch ex As Exception
            cn.Dispose()
            cmd.Dispose()
            adapter.Dispose()
            ds.Dispose()
            dt.Dispose()
        End Try
    End Sub
    Public Sub Dong()
        cn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        ds.Dispose()
    End Sub
#End Region


#Region "XML"
    Public Function SelectData_Stored_XML(ByVal st As String, ByVal _xml As String, ByVal _command As String) As DataTable
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
        'Try
        EnableConnect()
            dt.Clone()
            cmd.CommandText = st
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            '//
            cmd.Parameters.Add("@XmlString", SqlDbType.NVarChar).Value = _xml
            cmd.Parameters.Add("@command", SqlDbType.VarChar).Value = _command
            '//
            '--
            adapter.SelectCommand.CommandTimeout = 300
            gsqlDataReader = cmd.ExecuteReader(CommandBehavior.SequentialAccess)
            dt.Load(gsqlDataReader)
            For Each dc As DataColumn In dt.Columns
                dc.ColumnName = dc.ColumnName.ToLower
            Next
            '-
            dt.AcceptChanges()
            '//
            Return dt

        'Catch ex As Exception
        ' CAPTURE ERROR
        'Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        'GoTo SWERLExit
        'Finally
        '-
        ' CLOSE CONNECTION
        If cn.State = ConnectionState.Open Then
                If gsqlDataReader IsNot Nothing Then
                    gsqlDataReader.Close()
                    gsqlDataReader = Nothing
                End If

                cn.Close()
                Dong()
            End If
        'End Try
        'SWERLExit:
        'Return Nothing
    End Function
    Public Function ExcuteDataStoredXML(ByVal st As String, ByVal _xml As String, ByVal _command As String) As Boolean
        Try
            EnableConnect()
            cmd.CommandText = st
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            '//
            cmd.Parameters.Add("@XmlString", SqlDbType.NVarChar).Value = _xml
            cmd.Parameters.Add("@command", SqlDbType.VarChar).Value = _command
            '//
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
            GoTo SWERLExit
        Finally
            ' CLOSE CONNECTION
            If cn.State = ConnectionState.Open Then
                cn.Close()
                Dong()
            End If
        End Try
SWERLExit:
        Return False
    End Function

#End Region


#Region "LoadRtbText"

    Public Shared Sub LoadRtbText(ByVal rtb As RichTextBox, ByVal resource As String)
        Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(resource)
            If stream IsNot Nothing Then
                Using reader As New StreamReader(stream)
                    rtb.Rtf = reader.ReadToEnd()
                End Using
            End If
        End Using
    End Sub

    Public Shared Sub LoadRtbText(ByVal rtb As DevComponents.DotNetBar.Controls.RichTextBoxEx, ByVal strSaveFilename As String)
        Dim strFileName As String
        strFileName = My.Application.Info.DirectoryPath & "\Resources\" & strSaveFilename
        If IO.File.Exists(strFileName) Then
            Try
                Dim MyFileStream As New FileStream(strFileName, FileMode.Open)
                rtb.LoadFile(MyFileStream, RichTextBoxStreamType.RichText)
                MyFileStream.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("I'm afraid I could not find your instructions file.")
        End If
    End Sub

#End Region


End Class
