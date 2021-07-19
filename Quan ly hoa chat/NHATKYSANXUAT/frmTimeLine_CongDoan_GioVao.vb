Imports DevComponents.Schedule.Model
Imports DevComponents.Schedule
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Schedule
Imports System
Imports System.Collections.Generic

Imports System.Text


Public Class frmTimeLine_CongDoan_GioVao
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    '//
    Dim dt_khuvuc As DataTable
    Dim dt_local As DataTable
    Dim dt_congdoan As DataTable
    '///
    Private _UserStyleSet As Boolean
    Private _blnHide As Boolean = False
    Dim _dtStart As DateTime
    Private defUsers As String() '= New String() {"Jet 1", "Jet 2", "Jet 3", "Jet 4"}
    Private allUsers As String() = New String() {"Charlie", "Cheryl", "Denis",
    "Fred", "Grover", "Robert", "Sue", "Winnie", "Whitney"}
    Dim _intTime_Auto As Integer = 0
    Dim _Time_old As Integer = 0
    Dim aColor_chuacang As Color = Color.White
    Dim aColor_dacang As Color = Color.Green
    Dim aColor_MeCangLai As Color = Color.Yellow
    Dim aColor_MeLoi As Color = Color.Red
    Private ti As New TimeIndicator()
    Private IsBusy As Boolean = False
    Private LNV_ID As String = String.Empty
    '//
    Private moClsReadFile As ClsReadFile
    Private cls As Clsconnect
    Private moClsEncrypt As ClsEncrypt
    '//
    Private isActive As Boolean = False
    Private IsChanged As Boolean = False
    '//
    Private _Model As New CalendarModel()
    Private Lkhuvuc_id As String = String.Empty
    Private LID As String = String.Empty
    Dim dr2 As DataRow()
    Private Lmamay_id As String = String.Empty
    Private LCongDoan_id As String = String.Empty
    Private Lmame_id As String = String.Empty
    Private Lmame As String = String.Empty
    Private Lmacongdoan As String = String.Empty
    Private Lmamay As String = String.Empty
    Private intketqua As Int16 = 0
    '//
    Dim _List_Data As String() = {}
    Dim strData As List(Of String) = _List_Data.ToList()
    '//
    Public Property MaCongDoan() As String
        Get
            Return Lmacongdoan
        End Get
        Set(ByVal value As String)
            Lmacongdoan = value
        End Set
    End Property
    Public Property MaMay() As String
        Get
            Return Lmamay
        End Get
        Set(ByVal value As String)
            Lmamay = value
        End Set
    End Property
    Public Property MaID() As String
        Get
            Return LID
        End Get
        Set(ByVal value As String)
            LID = value
        End Set
    End Property
    Public Property CongDoan_ID() As String
        Get
            Return LCongDoan_id
        End Get
        Set(ByVal value As String)
            LCongDoan_id = value
        End Set
    End Property
    Public Property MaMe_ID() As String
        Get
            Return Lmame_id
        End Get
        Set(ByVal value As String)
            Lmame_id = value
        End Set
    End Property
    Public Property MaMe() As String
        Get
            Return Lmame
        End Get
        Set(ByVal value As String)
            Lmame = value
        End Set
    End Property
    Private Sub Me_FormClosing(ByVal sender As Object,
                                    ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                    Handles Me.FormClosing

        If IsChanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
        '///
        Me.Dispose()

    End Sub
    Private Sub frmTimeLine_CongDoan_GioVao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        '//
        dt_local = New DataTable
        dt_congdoan = New DataTable

    End Sub
    Private Sub frmTimeLine_CongDoan_GioRa_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '//
        txtmame.Text = Lmame
        txtmamay.Text = Lmamay
        txtmacongdoan.Text = Lmacongdoan
        '//
        txtmasonhanvien.Focus()
    End Sub

#Region "QUET MA SO NHAN VIEN"
    Private Sub Dang_nhap()
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("masonhanvien='" + ReplaceTextXML(txtmasonhanvien.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("VpsXmlListNhanVien_UpSet", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        If dt_local.Rows.Count > 0 Then
            strUser = txtmasonhanvien.Text
            LNV_ID = dt_local.Rows(0).Item("NV_ID")
            '//
            txttennhanvien.Text = dt_local.Rows(0).Item("tennhanvien")
        Else
            txttennhanvien.Text = String.Empty
            txtmasonhanvien.Text = String.Empty
            txtmasonhanvien.Focus()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        Dang_nhap()
    End Sub

    Private Sub txtmasonhanvien_TextChanged(sender As Object, e As EventArgs) Handles txtmasonhanvien.TextChanged
        If Len(txtmasonhanvien.Text) > 3 Then
            Timer2.Enabled = True
        End If

    End Sub

    Private Sub btnXacNhan_GioVao_Click(sender As Object, e As EventArgs) Handles btnXacNhan_GioVao.Click
        If Len(LID) = 0 Then Exit Sub
        Dim lenh As String = String.Empty
        Dim _QT_hientai As String = String.Empty
        'If MsgBox("Bạn có muốn xác nhận Giờ Bắt đầu?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xác Nhận Giờ Bắt Đầu") = MsgBoxResult.Yes Then
        Call Load_TimeServer()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        '//
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("maid='" + ReplaceTextXML(LID) + "' ")
        sbXMLString.Append("mamay_id='" + ReplaceTextXML(Lmamay_id) + "' ")
        sbXMLString.Append("mame_id='" + ReplaceTextXML(Lmame_id) + "' ")
        sbXMLString.Append("congdoan_id='" + ReplaceTextXML(LCongDoan_id) + "' ")
        sbXMLString.Append("nv_id='" + ReplaceTextXML(LNV_ID) + "' ")
        sbXMLString.Append("ismeghep='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("iscustom='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("thoigianvao='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
        sbXMLString.Append("thoigianra='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm") + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_congdoan_UpSet]", sbXMLString.ToString, "update_giovao")
        IsChanged = dtControler.UPSET_XML(_dt)
        Me.Close()
    End Sub

    Private Sub BtnExit_CapNhat_Click(sender As Object, e As EventArgs) Handles BtnExit_CapNhat.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

End Class