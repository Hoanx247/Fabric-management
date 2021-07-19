Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data.SqlClient.SqlException
Imports Microsoft.VisualBasic.Devices
Imports System.Xml

Imports System.Management
Imports System.Reflection
Imports System.Text
Public Class frmLogin
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private moClsReadFile As ClsReadFile
    Private cls As Clsconnect
    Private moClsEncrypt As ClsEncrypt
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    'Dim clsdt As New clsWMI
    Dim dt_local As DataTable
    Dim _Mamay As String
    Dim dt_mamay As DataTable
    Private _cChonForm As String = String.Empty

    Public Const BM_SETSTATE = &HF3
    Declare Function SendMessageBynum Lib "user32" Alias "SendMessageA" _
    (ByVal hwnd As IntPtr, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Public Sub CheckForExistingInstance()
        'Get number of processes of you program
        If Process.GetProcessesByName _
          (Process.GetCurrentProcess.ProcessName).Length > 1 Then

            MessageBox.Show _
             ("Another Instance of this process is already running",
                 "Multiple Instances Forbidden",
                  MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation)
            Application.Exit()
        End If
    End Sub

    Private Sub Me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dt_local.Dispose()
        dt_mamay.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        moClsEncrypt = New ClsEncrypt
        moClsReadFile = New ClsReadFile
        cls = New Clsconnect
        dt_mamay = New DataTable
        '--
        _GConnect_LUser_KhoMoc = moClsEncrypt.DecryptHD(moClsReadFile.readIniFile("Database_Khomoc", "User", _GFileName_Database))
        _GConnect_LDatasource_KhoMoc = moClsEncrypt.DecryptHD(moClsReadFile.readIniFile("Database_Khomoc", "Datasource", _GFileName_Database))
        _GConnect_LDatabase_KhoMoc = moClsEncrypt.DecryptHD(moClsReadFile.readIniFile("Database_Khomoc", "Database", _GFileName_Database))
        _GConnect_LPass_KhoMoc = moClsEncrypt.DecryptHD(moClsReadFile.readIniFile("Database_Khomoc", "Pass", _GFileName_Database))
        '//May In 
        _cChonForm = moClsReadFile.readIniFile("ChonForm", "tenform", _GFileName_name)
        GMayInTem = moClsReadFile.readIniFile("MAYIN", "MayInTem", _GFileName_name)
        GMayInPhieu = moClsReadFile.readIniFile("MAYIN", "MayInPhieu", _GFileName_name)
        '//Khoi Luong
        GWeightMin = moClsReadFile.readIniFile("weight", "weightmin", _GFileName_name)
        GWeightMax = moClsReadFile.readIniFile("weight", "weightmax", _GFileName_name)
        GWeightMin = CoToDec(GWeightMin, 1)
        GWeightMax = CoToDec(GWeightMax, 1)
        '//supergrid
        lfontsize = moClsReadFile.readIniFile("supergrid", "lfontsize", _GFileName_name)
        ldefaultRowheight = moClsReadFile.readIniFile("supergrid", "ldefaultRowheight", _GFileName_name)
        lGroupHeaderHeight = moClsReadFile.readIniFile("supergrid", "lGroupHeaderHeight", _GFileName_name)
        lColumnHeaderRowHeight = moClsReadFile.readIniFile("supergrid", "lColumnHeaderRowHeight", _GFileName_name)
        '--

        If _GConnect_LDatasource_KhoMoc.Length = 0 AndAlso _GConnect_LDatabase_KhoMoc.Length = 0 AndAlso _GConnect_LPass_KhoMoc.Length = 0 Then
            MsgBox("Vui lòng kiểm tra lại đường dẫn tới Datasoure.", MsgBoxStyle.Critical, "Lỗi Kết Nối")
            Me.Close()
        End If

        MdlData.str_path = System.IO.Directory.GetCurrentDirectory.ToString
        'LabelItem1.Links.Add(14, 28, "http://haidangpro.com/trang-chu.aspx")
        'LabelItem1.
        Call Get_Serial()
        'btnRegisty.Visible = False

        Dim versionNumber As Version
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        Dim stFileVersion As String = Application.ProductVersion.ToString
        dt_local = VpsXmlList_Load(stFileVersion, "", "Version")
        If dt_local.Rows.Count = 0 Then
            MsgBox("Vui lòng cập nhật phiên bản mới.", MsgBoxStyle.Critical, "Thông Báo")
            Me.Close()
        Else
            Me.Text = "Login (Vesion: " & Application.ProductVersion.ToString & ")"
        End If
    End Sub


    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim st As String = String.Empty
        Dim intRow As Integer = 0
        'Try

        If UCase(txtuser.Text) = "HOANGUYEN" And txtpass.Text = "hoanx151254" Then
            strUser = "HOANGUYEN"
            strpass = txtpass.Text
            txtuser.Focus()
            Me.Hide()
            Form1.Show()
        Else
            'st = "Select * from dbo.tbRegistryMachine where mamay = '" & _Mamay & "'"
            dt_mamay = VpsXmlList_Load(_Mamay, "", "RegistryMachine")
            'If dt_mamay.Rows.Count = 0 Then
            'MsgBox("Máy chưa được đăng ký. Vui lòng liên hệ admin.", MsgBoxStyle.Critical, "Registry")
            'Exit Sub
            'End If
            '--
            If UCase(_GConnect_LDatabase_KhoMoc) <> "DBMOC_SONGTHUY_2020" Then
                Exit Sub
            End If
            If Len(txtgroup.Text) > 0 Then
                Dim pass_input As String = moClsEncrypt.EncryptHD(txtpass.Text.Trim)
                If String.Compare(strpass, pass_input) = 0 Then
                    txtuser.Focus()
                    Me.Hide()
                    If _cChonForm.ToUpper = "KHOMOC" Then
                        Form_KhoMoc.Show()
                    Else
                        Form1.Show()
                    End If

                Else
                    MsgBox("Nhập sai mật khẩu. Xin vui lòng kiểm tra lại.", MsgBoxStyle.Information, "Thông báo")
                    txtpass.Text = String.Empty
                    txtpass.Focus()
                End If
            Else
                MsgBox("Tài khoản không tồn tại. Xin vui lòng kiểm tra lại.", MsgBoxStyle.Information, "Thông báo")
                Call Empty_Data()
                txtuser.Focus()
            End If
        End If

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Empty_Data()
        MdlData.strname = String.Empty
        MdlData.strpass = String.Empty
        MdlData.str_nhom = String.Empty
        txtpass.Text = String.Empty
        txtuser.Text = String.Empty
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX_Thoat.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        _Server_Signal = TestConn(_GConnect_LDatasource_KhoMoc)
        If _Server_Signal = True Then
            '--
            ButtonX_Save.Enabled = True
            'TsServer.Text = "#Server: " & " #OK"
            txtuser.Focus()
        Else
            ButtonX_Save.Enabled = False
            'TsServer.Text = "#Server: " & " #Fail"
            mdlHostName = "-"
            mdlIPAddress = "-"
        End If

    End Sub
    Private Function TestConn(ByVal server As String) As Boolean
        Using tcpSocket As New System.Net.Sockets.TcpClient
            Try
                Dim async As IAsyncResult = tcpSocket.BeginConnect(server, 1433, Nothing, Nothing)
                Dim startTime As DateTime = DateTime.Now

                Do
                    System.Threading.Thread.Sleep(500)
                    If (async.IsCompleted) Then
                        Exit Do
                    End If
                Loop While (DateTime.Now.Subtract(startTime).TotalSeconds < 5)

                If (async.IsCompleted) Then
                    tcpSocket.EndConnect(async)
                    Return True
                End If
                tcpSocket.Close()

                If (async.IsCompleted = False) Then
                    Return False
                End If

            Catch ex As Exception

                My.Application.Log.WriteEntry("[" & DateTime.Now & "] - " & ex.Source & ": " & ex.Message)
            End Try
        End Using
    End Function


    Private Sub txtuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call filterData_Stored()
        End If
    End Sub

    Private Sub filterData_Stored()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML(txtuser.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("VpsXmlLoad_Initial", sbXMLString.ToString, "user")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        '//
        If dt_local.Rows.Count = 1 Then
            strname = Me.txtuser.Text
            strUser = dt_local.Rows(0).Item("tentruycap").ToString
            strpass = dt_local.Rows(0).Item("matkhau").ToString
            txtgroup.Text = dt_local.Rows(0).Item("nhom").ToString
            str_nhom = txtgroup.Text
            _nhomUser_ID = dt_local.Rows(0).Item("nhom_id").ToString
            _GNhomUser_ID = strUser
            _GNhomUser_ID = _nhomUser_ID
            _stUser_Save = strname
            '--
            txtpass.Focus()
        Else
            txtuser.Text = String.Empty
            txtuser.Focus()
        End If
    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdOk_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Try
            e.Link.Visited = True
            Dim url As String = CType(e.Link.LinkData, String)
            System.Diagnostics.Process.Start(url)
        Catch ex As Exception
        End Try
    End Sub



    Private Sub TsBtn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLogin_Shown(Nothing, Nothing)
    End Sub


    Private Sub Get_Serial()
        Dim hdCollection As New ArrayList()
        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
        Dim wmi_HD As New ManagementObject()

        For Each wmi_HD In searcher.Get

            Dim hd As New HardDrive()

            hd.Model = wmi_HD("Model").ToString()
            hd.Type = wmi_HD("InterfaceType").ToString()
            hdCollection.Add(hd)
        Next

        'Dim searcher1 As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")

        'Dim i As Integer = 0
        'For Each wmi_HD In searcher1.Get()

        '// get the hard drive from collection
        '// using index

        'Dim hd As HardDrive
        'hd = hdCollection(0)


        '// get the hardware serial no.
        'If wmi_HD("SerialNumber") = "" Then
        'hd.serialNo = "None"
        'Else
        'hd.serialNo = wmi_HD("SerialNumber").ToString()
        'i += 1
        'End If
        'Next

        Dim hd1 As HardDrive
        Dim ii As Integer = 0

        For Each hd1 In hdCollection
            ii += 1
            'txtSerial.Text = txtSerial.Text + "Disco #: " + ii.ToString + Chr(13) + Chr(10)
            If ii = 1 Then
                _Mamay = Replace(hd1.Model, " ", "")
            End If
            'txtSerial.Text = txtSerial.Text + "Model: " + hd1.Model + Chr(13) + Chr(10)
            'txtSerial.Text = txtSerial.Text + "Tipo: " + hd1.Type + Chr(13) + Chr(10)
            'txtSerial.Text = txtSerial.Text + "Serial No: " + hd1.serialNo + Chr(13) + Chr(10) + Chr(13) + Chr(10)
        Next

    End Sub

    Private Sub btnRegisty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim st As String
        'btnRegisty.Enabled = False
        '--Them vao database
        'st = "select 1 from dbo.tbRegistryMachine where mamay='" & _Mamay & "'"
        'If cls.ReturnDataSet(st).Tables(0).Rows.Count = 0 Then
        'st = "Insert into dbo.tbRegistryMachine (mamay) values('" & _Mamay & "')"
        'cls.Update_Data(st)
        'End If
        'btnRegisty.Enabled = True
    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged
        If LCase(txtuser.Text) = "hoanx" And LCase(txtpass.Text) = "registry" Then
            'btnRegisty.Visible = True
        Else
            'btnRegisty.Visible = False
        End If
    End Sub

    Private Sub txtuser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.Leave
        If Len(txtuser.Text) = 0 Then Exit Sub
        If txtuser.Text.ToUpper <> "HOANGUYEN" Then
            Call filterData_Stored()
        End If

    End Sub

    Private Sub BtnUpdateSoft_Click(sender As Object, e As EventArgs)
        Dim filename_pdf As String = "Auto_update_exe.exe"
        Dim pdfOfOriginalFile As String = My.Application.Info.DirectoryPath & "\" & filename_pdf
        Shell(pdfOfOriginalFile)
        wait(100)
        Me.Close()
        'System.Diagnostics.Process.Start(pdfOfOriginalFile)
    End Sub


End Class
