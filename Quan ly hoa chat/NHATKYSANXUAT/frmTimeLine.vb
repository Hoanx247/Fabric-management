Imports DevComponents.Schedule.Model
Imports DevComponents.Schedule
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Schedule
Imports System
Imports System.Collections.Generic

Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Reflection
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Net
Imports System.Text
Imports Microsoft.VisualBasic
Imports System.Globalization

Public Class frmTimeLine
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    Private mocls As Clsconnect
    '//
    Private dtControler As KhoSanXuatDAL
    Private _dt As KhoSanXuatDTO
    '//
    Dim dt_maycang As DataTable
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
    '//
    Private moClsReadFile As ClsReadFile
    Private cls As Clsconnect
    Private moClsEncrypt As ClsEncrypt
    '//
    Private isActive As Boolean = False
    '//
    Private _Model As New CalendarModel()
    '//
    Dim _List_Data As String() = {}
    Dim strData As List(Of String) = _List_Data.ToList()
    Dim dr2 As DataRow()
    Dim LID As String = String.Empty
    Dim LNV_ID As String = String.Empty
    Dim LKhuvuc_ID As String = String.Empty
    Dim _LMamay_id As String = String.Empty
    Dim _LCongDoan_id As String = String.Empty
    Dim _LMaCongDoan As String = String.Empty
    Dim _LPhanLoai_NgayDem As String = String.Empty
    Private _GioVao As DateTime
    Private _GioKetThuc As DateTime
    Private _thoigian_toithieu As Int16 = 0
    Dim _ImageInt As Int16 = 0
    '//
    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If GP_Form_CapNhat.Visible = True Then
            Dim _maso_quanly As String = txttenquanly.Text.Trim
            If _maso_quanly.Length > 0 Then
                With txtmasonhanvien
                    If .Focused = False Then
                        .Focus()
                        .Text = e.KeyChar.ToString
                        .SelectionStart = .Text.Length
                        e.Handled = True
                    End If
                End With
            Else
                With txtmaso_quanly
                    If .Focused = False Then
                        .Focus()
                        .Text = e.KeyChar.ToString
                        .SelectionStart = .Text.Length
                        e.Handled = True
                    End If
                End With
            End If

        End If

    End Sub
    '///
    Private Sub Me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Dispose()
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
    End Sub

    Private Sub Me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_congdoan = New DataTable

        With Dgv_LichCang
            '.Dock = DockStyle.Fill
        End With
        Call Load_TimeServer()
        With dt1_F
            '.Value = Now
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy HH:mm"
        End With
        With dt2_F
            '.Value = Now
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy HH:mm"
        End With
        '--
        Me.dt1_F.Value = _TimeServer.AddDays(-1)
        Me.dt2_F.Value = _TimeServer.AddDays(20)
        '--
        'InitializeComponent()
        CalendarView1.Dock = DockStyle.Fill
        dt_maycang = New DataTable
        dt_local = New DataTable
        '//
        _Model = New CalendarModel()
        'AddSampleAppointments()
        'AddHolidaySchedule()
        CalendarView1.CalendarModel = _Model

        Call Load_MayMoc()
        'wait(200)
        '//
        CalendarView1.DisplayedOwners.AddRange(defUsers)

        ' And add our base set of users

        '//
        '//
        CalendarView1.SelectedView = Schedule.eCalendarView.TimeLine
        CalendarView1.TimeLinePeriod = eTimeLinePeriod.Minutes
        CalendarView1.TimeLineInterval = 60
        'AddHandler CalendarView1.AppointmentReminder, AddressOf AppointmentReminder
        ' AddHandler CalendarView1.AppointmentStartTimeReached, AddressOf AppointmentStartTimeReached
        CalendarView1.TimeLineMultiUserTabWidth = 100
        CalendarView1.TimeLineMultiUserTabOrientation = eOrientation.Horizontal
        CalendarView1.TimeLineHeight = 35
        CalendarView1.TimeLineHorizontalPadding = 0
        CalendarView1.TimeLineStretchRowHeightMode = TimeLineStretchRowHeightMode.Full
        CalendarView1.TimeLineStretchRowHeight = True
        CalendarView1.TimeLineCondensedViewVisibility = eCondensedViewVisibility.Hidden
        CalendarView1.TimeLineCondensedViewHeight = 10
        CalendarView1.TimeLineShowCollateLines = False
        CalendarView1.TimeLineCanExtendRange = True
        CalendarView1.TimeLinePeriodHeaderEnableMarkup = True

        '//
        'CalendarView1.ViewDisplayCustomizations.DaySlotBackgrounds.Remove(DateTime.Today)
        'CalendarView1.ViewDisplayCustomizations.DaySlotBackgrounds.Remove(DayOfWeek.Sunday)
        CalendarView1.TimeIndicator.IndicatorTime = _TimeServer
        CalendarView1.TimeIndicator.Visibility = eTimeIndicatorVisibility.AllResources

        CalendarView1.CalendarModel.Appointments.Clear()
        '//
        'AddHandler CalendarView1.GetDisplayTemplateText, AddressOf CalendarViewGetDisplayTemplateText
        AddHandler CalendarView1.TimeLineGetRowHeight, AddressOf CalendarViewTimeLineGetRowHeight
        'AddHandler CalendarView1.DisplayedOwnersChanged, AddressOf calendarView_OwnersChanged
        'AddHandler CalendarView1.SelectedOwnerChanged, AddressOf calendarView_OwnersChanged
        '--

        'Try
        CalendarView1.CalendarModel.WorkDays.Add(New WorkDay(DayOfWeek.Saturday))
        Dim workStartTime As WorkTime = New WorkTime(0, 0)
        Dim workEndTime As WorkTime = New WorkTime(12, 0)

        For Each workDay As WorkDay In CalendarView1.CalendarModel.WorkDays
            workDay.WorkStartTime = workStartTime
            workDay.WorkEndTime = workEndTime
        Next
        'Catch
        'End Try
        '//
        Load_KhuVuc()

    End Sub
    Private Sub Load_CongDoan()
        dt_congdoan = VpsXmlList_Load("", "", "macongdoan")
        'LoadDataToCombox(dt_congdoan, cboTencongdoan, "tencongdoan", False)
    End Sub
    Private Sub Load_KhuVuc()
        dt_local = VpsXmlList_Load("", "", "khuvuc")
        Dim dv As DataView = New DataView(dt_local, "nhom=1", "makhuvuc asc", DataViewRowState.CurrentRows)
        'dv.Sort = "hoanthanh asc,mamay asc,rid asc"
        dt_local = dv.ToTable()
        LoadDataToCombox(dt_local, cboKhuVuc, "makhuvuc", True)
    End Sub
    Private Sub Load_MayMoc()
        Dim owner As New Owner("JET 01", "JET 01", eCalendarColor.Red)
        Dim y As Integer = 0
        'dt_maycang = ShellServices.vps_ListGroupLoad(cboKhuVuc.Text, "khuvuc_may")
        dt_maycang = VpsXmlList_Load(cboKhuVuc.Text, "", "khuvuc_may")

        '//
        'Dim dataView As New DataView(dt_maycang)
        Dim dv As DataView = New DataView(dt_maycang, "nhom=1", "thutu asc,mamay asc", DataViewRowState.CurrentRows)
        'dt_local = dv.ToTable()
        'dv.Sort = "thutu asc,mamay asc"
        Dim dataTable As DataTable = dv.ToTable()

        Dim myList As New List(Of String)()
        For Each row As DataRow In dataTable.Rows
            ' Write value of first Integer.
            myList.Add(row.Item("mamay").ToString)
            If row.Item("nhommay_id") = "G001" Then
                owner = New Owner(row.Item("mamay").ToString, row.Item("mamay").ToString.ToUpper, eCalendarColor.Red)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G002" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Blue)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G003" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Green)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G004" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Steel)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G005" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Green)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G006" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Red)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G007" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Green)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G008" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Olive)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G009" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Purple)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G010" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Teal)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "M011" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Yellow)
                _Model.Owners.Add(owner)
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eBorderSide.All)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G012" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Green)
                _Model.Owners.Add(owner)
            ElseIf row.Item("nhommay_id") = "G013" Then
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.DarkSteel)
                _Model.Owners.Add(owner)
            Else
                owner = New Owner(row.Item("mamay").ToString.ToUpper, row.Item("mamay").ToString.ToUpper, eCalendarColor.Automatic)
                _Model.Owners.Add(owner)
            End If
            '//

        Next
        defUsers = myList.ToArray
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        '//
        CalendarView1.TimeIndicator.IndicatorSource = eTimeIndicatorSource.UserSpecified
        CalendarView1.TimeIndicator.IndicatorTime = _TimeServer
        CalendarView1.TimeIndicator.Visibility = eTimeIndicatorVisibility.AllResources
        CalendarView1.TimeIndicator.IndicatorArea = eTimeIndicatorArea.Header

        '//

        ti.IndicatorTime = _TimeServer
        ti.IndicatorSource = eTimeIndicatorSource.UserSpecified
        ti.Thickness = 3
        'ti.IndicatorTimeOffset = New TimeSpan(0, 0, 0)
        ti.BorderColor = Color.Green
        ti.IndicatorColor = New ColorDef(New Color() {Color.Empty, Color.GreenYellow, Color.Green}, New Single() {0F, 0.5F, 1.0F})
        ti.Visibility = eTimeIndicatorVisibility.AllResources
        ti.IndicatorArea = eTimeIndicatorArea.All
        ' Add indicator to the collection
        CalendarView1.TimeIndicators.Add(ti)
        '//
        Call Filterdata_Stored()
    End Sub

    Private Sub Filterdata_Stored()
        Me.SuspendLayout()
        'txtsolanquet.Text = _SolanLoad
        If IsBusy = True Then Exit Sub
        IsBusy = True
        '//
        ti.IndicatorTime = _TimeServer
        'Try
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("dtngay1='" + Format$(dt1_F.Value, "yyyyMMdd 00:00") + "' ")
        sbXMLString.Append("dtngay2='" + Format$(dt2_F.Value, "yyyyMMdd 23:59") + "' ")
        sbXMLString.Append("makhuvuc='" + ReplaceTextXML(cboKhuVuc.Text) + "' ")
        sbXMLString.Append("mame='" + ReplaceTextXML(txtmame_F.Text) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlKhoSanXuat_MeNhuom_CongDoan_Schedule_2021]", sbXMLString.ToString, "select")
        Dim sortedDT As DataTable = dtControler.SELECT_XML_Datatable(_dt)
        Me.ResumeLayout()
        '//
        If sortedDT IsNot Nothing Then
            'Dgv_LichCang.DataSource = New DataView(sortedDT, "", "", DataViewRowState.CurrentRows)
            Dim dv As DataView = New DataView(sortedDT, "", "", DataViewRowState.CurrentRows)
            dv.Sort = "mamay asc,hoanthanh asc,rid asc"
            dt_local = dv.ToTable()
            Update_Datatable()
        End If

        '//
        IsBusy = False
    End Sub
    Private Sub Update_Datatable()
        dt_local.Columns("sttmame").ReadOnly = False
        '//
        Dim _StartTime As DateTime
        Dim _Endtime_dutinh As DateTime
        Dim _Endtime_ChuaKetThuc As DateTime = _TimeServer
        Dim _Endtime_KetThuc As DateTime = _TimeServer
        Dim _thoigian_toithieu As Integer = 0
        Dim _IsMeDangSanXuat As Boolean = False
        Dim _Thoigian_cho As Integer = 0
        Dim _sttMe_CongDoan As Integer = 0
        Dim _MaMe_ID As String = String.Empty
        Dim _sMamay As String = String.Empty
        For _stt = 0 To defUsers.Length - 1
            _StartTime = _TimeServer
            _Endtime_dutinh = _TimeServer
            _Endtime_KetThuc = _TimeServer
            _IsMeDangSanXuat = False
            _thoigian_toithieu = 0
            _Thoigian_cho = 0
            '//
            For Each row As DataRow In dt_local.Rows
                If row.Item("mamay").ToString.ToLower = defUsers(_stt).ToLower Then
                    _thoigian_toithieu = CInt(row.Item("thoigian_toithieu"))
                    _Thoigian_cho = CInt(row.Item("thoigian_cho"))
                    _sMamay = row.Item("mamay").ToString
                    '//
                    If row.Item("hoanthanh") = 1 Then
                        _StartTime = row.Item("thoigianvao")
                        _Endtime_dutinh = _StartTime.AddMinutes(_thoigian_toithieu)

                        '//So Sanh voi thoi gian hien tai
                        If _Endtime_dutinh <= _TimeServer Then
                            _Endtime_KetThuc = _TimeServer
                        Else
                            _Endtime_KetThuc = _Endtime_dutinh
                        End If
                        _IsMeDangSanXuat = True
                        row.Item("thoigianra_dukien") = _Endtime_KetThuc

                    ElseIf row.Item("hoanthanh") = 2 Then '//MẺ CÓ KẾ HOẠCH
                        If _IsMeDangSanXuat = False Then
                            _StartTime = _Endtime_KetThuc.AddMinutes(_Thoigian_cho)
                            _Endtime_KetThuc = _StartTime.AddMinutes(_thoigian_toithieu)
                        Else

                            _StartTime = _Endtime_KetThuc.AddMinutes(_Thoigian_cho)
                            _Endtime_KetThuc = _StartTime.AddMinutes(_thoigian_toithieu)

                        End If
                        '//
                        row.Item("thoigianvao_dukien") = _StartTime
                        row.Item("thoigianra_dukien") = _Endtime_KetThuc
                    End If
                End If
            Next

        Next

        dt_local.AcceptChanges()
        Dgv_LichCang.DataSource = New DataView(dt_local, "", "", DataViewRowState.CurrentRows)
    End Sub

    Private Sub Dgv_LichCang_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Dgv_LichCang.DataBindingComplete
        Call ADD_LichCang()
        '///
        'Try
        'CalendarView1.TimeLineViewStartDate = Format$(_TimeServer, "dd/MM/yyyy 00:00")
        'CalendarView1.TimeLineViewEndDate = Format$(_TimeServer, "dd/MM/yyyy 23:59")

        'CalendarView1.TimeLineVie
        '//
        'ti.IndicatorTime = _TimeServer
        Dim TimeEnd As DateTime = #5:00:00 PM#
        Dim span As System.TimeSpan = _TimeServer.TimeOfDay - TimeEnd.TimeOfDay
        If span.TotalMinutes > 0 Then
            CalendarView1.TimeLineViewScrollStartDate = _TimeServer.AddHours(-3)
        End If
        '//
        For y As Int16 = 0 To CalendarView1.MultiCalendarTimeLineViews.Count - 1
            Dim st As String = CalendarView1.MultiCalendarTimeLineViews.Item(y).OwnerKey.ToString
            Dim stNhomMay As String = String.Empty
            '--Kiem Tra Khu Vuc
            dr2 = dt_maycang.Select("mamay = '" & st & "'", "")
            If dr2.Length > 0 Then
                stNhomMay = dr2.First.Item("nhommay_id")
            Else
                stNhomMay = String.Empty
            End If

            If stNhomMay = "M001" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)
            ElseIf stNhomMay = "M002" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Italic)
            ElseIf stNhomMay = "M003" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)
            ElseIf stNhomMay = "M004" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Italic)
            ElseIf stNhomMay = "M005" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)
            ElseIf stNhomMay = "M006" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Italic)
            ElseIf stNhomMay = "M007" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)
            ElseIf stNhomMay = "M008" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Italic)
            ElseIf stNhomMay = "M009" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)
            ElseIf stNhomMay = "M010" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Italic)
            ElseIf stNhomMay = "M011" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)
            ElseIf stNhomMay = "M012" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Italic)
            ElseIf stNhomMay = "M013" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)
            ElseIf stNhomMay = "M014" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Italic)
            ElseIf stNhomMay = "M015" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)
            ElseIf stNhomMay = "M016" Then
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Italic)
            Else
                CalendarView1.MultiCalendarTimeLineViews.Item(y).Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Regular)

            End If
        Next
    End Sub

#Region "TIMELINE"

    ''' <summary>
    ''' Handles CalendarView MouseUp events
    ''' </summary>
    ''' <param name="sender">Varied sender</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub calendarView1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CalendarView1.MouseUp
        ' Process Right MouseUp event in order to
        ' present view specific ContextMenu

        If e.Button = MouseButtons.Right Then
            ' Main Calendar View hit

            If TypeOf sender Is BaseView Then
                BaseViewMouseUp(sender, e)

                ' AppointmentView hit

            ElseIf TypeOf sender Is AppointmentView Then
                'AppointmentViewMouseUp(sender, e)

                ' AllDayPanel hit

            ElseIf TypeOf sender Is AllDayPanel Then
                AllDayPanelMouseUp(sender, e)

                ' TimeRulerPanel hit

            ElseIf TypeOf sender Is TimeRulerPanel Then
                TimeRulerPanelMouseUp(sender, e)

                ' TimeLineHeaderPanel

            ElseIf TypeOf sender Is TimeLineHeaderPanel Then
                TimeLineHeaderPanelMouseUp(sender, e)
            End If
        End If
    End Sub

#Region "BaseViewMouseUp"

    ''' <summary>
    ''' Handles Day, Week, and Month View MouseUp events
    ''' </summary>
    ''' <param name="sender">BaseView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub BaseViewMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim view As BaseView = TryCast(sender, BaseView)
        Dim area As eViewArea = view.GetViewAreaFromPoint(e.Location)

        If area = eViewArea.InContent Then
            InContentMouseUp(view, e)

        ElseIf area = eViewArea.InDayOfWeekHeader Then
            InDayOfWeekHeaderMouseUp(view, e)


        ElseIf area = eViewArea.InSideBarPanel Then
            InSideBarMouseUp(view, e)

        ElseIf area = eViewArea.InCondensedView Then
            InCondensedViewMouseUp(e)
        End If
    End Sub

#Region "InContentMouseUp"

    ''' <summary>
    ''' Handles BaseView InContent MouseUp events
    ''' </summary>
    ''' <param name="view">BaseView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InContentMouseUp(ByVal view As BaseView, ByVal e As MouseEventArgs)
        ' Get the DateSelection start and end
        ' from the current mouse location

        Dim startDate As DateTime, endDate As DateTime

        If CalendarView1.GetDateSelectionFromPoint(e.Location, startDate, endDate) = True Then
            ' If this date already falls outside the currently
            ' selected range (DateSelectionStart and DateSelectionEnd)
            ' then select the new range

            If IsDateSelected(startDate, endDate) = False Then
                CalendarView1.DateSelectionStart = startDate
                CalendarView1.DateSelectionEnd = endDate
            End If
        End If

        ' Remove any previously added view specific items

        For i As Integer = InContentContextMenu.SubItems.Count - 1 To 1 Step -1
            InContentContextMenu.SubItems.RemoveAt(i)
        Next

        ' If this is a TimeLine view, then add a couple
        ' of extra items

        If TypeOf view Is TimeLineView Then
            Dim bi As New ButtonItem()

            ' Page Navigator

            If CalendarView1.TimeLineShowPageNavigation = True Then
                bi.Text = "Hide Page Navigator"
            Else
                bi.Text = "Show Page Navigator"
            End If

            bi.BeginGroup = True

            AddHandler bi.Click, AddressOf bi_PageNavigatorClick

            InContentContextMenu.SubItems.Add(bi)

            ' Condensed Visibility

            If CalendarView1.TimeLineCondensedViewVisibility = eCondensedViewVisibility.Hidden Then
                bi = New ButtonItem("", "Show Condensed View")
                AddHandler bi.Click, AddressOf bi_CondensedClick

                InContentContextMenu.SubItems.Add(bi)
            End If
        End If

        ShowContextMenu(InContentContextMenu)
    End Sub

#Region "bi_CondensedClick"

    ''' <summary>
    ''' Handles InContentContextMenu Condensed selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bi_CondensedClick(ByVal sender As Object, ByVal e As EventArgs)
        CalendarView1.TimeLineCondensedViewVisibility = eCondensedViewVisibility.AllResources
    End Sub

#End Region

#Region "bi_PageNavigatorClick"

    ''' <summary>
    ''' Handles InContentContextMenu PageNavigator selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bi_PageNavigatorClick(ByVal sender As Object, ByVal e As EventArgs)
        CalendarView1.TimeLineShowPageNavigation = (CalendarView1.TimeLineShowPageNavigation = False)
    End Sub

#End Region

#Region "IsDateSelected"

    ''' <summary>
    ''' Determines if the given date range is within the currently selected
    ''' CalendarView selection range (DateSelectionStart to DateSelectionEnd)
    ''' </summary>
    ''' <param name="startDate">Start date range</param>
    ''' <param name="endDate">End date range</param>
    ''' <returns>True if selected</returns>
    Private Function IsDateSelected(ByVal startDate As DateTime, ByVal endDate As DateTime) As Boolean
        If CalendarView1.DateSelectionStart.HasValue AndAlso CalendarView1.DateSelectionEnd.HasValue Then
            If CalendarView1.DateSelectionStart.Value <= startDate AndAlso CalendarView1.DateSelectionEnd.Value >= endDate Then
                Return (True)
            End If
        End If

        Return (False)
    End Function

#End Region

#Region "miAdd_Click"

    ''' <summary>
    ''' Handles BaseView "Add Appointment" 
    ''' ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InContentAddAppContextItem.Click
        Dim startDate As DateTime = CalendarView1.DateSelectionStart.GetValueOrDefault()
        Dim endDate As DateTime = CalendarView1.DateSelectionEnd.GetValueOrDefault()

        'AddNewAppointment(startDate, endDate)

    End Sub
#End Region

#End Region

#Region "InDayOfWeekHeaderMouseUp"

    ''' <summary>
    ''' Handles BaseView InDayOfWeekHeader MouseUp events.
    ''' </summary>
    ''' <param name="view">BaseView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InDayOfWeekHeaderMouseUp(ByVal view As BaseView, ByVal e As MouseEventArgs)
        If TypeOf view Is MonthView Then
            Dim mv As MonthView = TryCast(view, MonthView)

            ' The View is a month view, so let the user
            ' hide or show the SideBar panel

            If mv.IsSideBarVisible = True Then
                InHeaderHideSideBarContextItem.Visible = True
                InHeaderShowSideBarContextItem.Visible = False
            Else
                InHeaderHideSideBarContextItem.Visible = False
                InHeaderShowSideBarContextItem.Visible = True
            End If
        Else
            InHeaderHideSideBarContextItem.Visible = False
            InHeaderShowSideBarContextItem.Visible = False
        End If

        InHeaderContextMenu.Tag = view

        ShowContextMenu(InHeaderContextMenu)
    End Sub

#Region "miCalendarColor_Click"

    ''' <summary>
    ''' Handles selection of a ContextMenu color item
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miCalendarColor_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim mi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As BaseView = TryCast(mi.Parent.Tag, BaseView)

        If view IsNot Nothing Then
            view.CalendarColor = DirectCast([Enum].Parse(GetType(eCalendarColor), mi.Text), eCalendarColor)
        End If
    End Sub

#End Region

#Region "SideBar show/hide"

    ''' <summary>
    ''' Handles ContextMenu "Show" for the SideBar panel
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miShowSideBar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As MonthView = TryCast(bi.Parent.Tag, MonthView)

        If view IsNot Nothing Then
            view.IsSideBarVisible = True
        End If
    End Sub

    ''' <summary>
    ''' Handles ContextMenu "Hide" for the SideBar panel
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miHideSideBar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As MonthView = TryCast(bi.Parent.Tag, MonthView)

        If view IsNot Nothing Then
            view.IsSideBarVisible = False
        End If
    End Sub


#End Region

#End Region

#Region "InMonthHeaderMouseUp"


#Region "Gridlines show/hide"

    ''' <summary>
    ''' Handles ContextMenu "Show GridLines" for the Year View
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miShowGridLines_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As YearView = TryCast(bi.Parent.Tag, YearView)

        If view IsNot Nothing Then
            CalendarView1.YearViewShowGridLines = True
        End If
    End Sub

    ''' <summary>
    ''' Handles ContextMenu "Hide GridLines" for the Year View
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miHideGridLines_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As YearView = TryCast(bi.Parent.Tag, YearView)

        If view IsNot Nothing Then
            CalendarView1.YearViewShowGridLines = False
        End If
    End Sub

#End Region

#Region "miCycleHighlight_Click"

    ''' <summary>
    ''' Handles ContextMenu "Cycle Highlight" for the Year View.  This
    ''' routine cycles through all the possible Day Link Highlight values
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miCycleHighlight_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As YearView = TryCast(bi.Parent.Tag, YearView)

        If view IsNot Nothing Then
            If CalendarView1.YearViewAppointmentLinkStyle = eYearViewLinkStyle.None Then
                If _UserStyleSet = False Then
                    _UserStyleSet = True

                    AddHandler CalendarView1.YearViewDrawDayBackground, AddressOf YearViewDrawDayBackground

                    CalendarView1.Refresh()
                Else
                    _UserStyleSet = False

                    RemoveHandler CalendarView1.YearViewDrawDayBackground, AddressOf YearViewDrawDayBackground

                    NextLinkStyle()
                End If
            Else
                NextLinkStyle()
            End If
        End If
    End Sub

#End Region

#Region "NextLinkStyle"

    ''' <summary>
    ''' Sets the next available Link style
    ''' </summary>
    Private Sub NextLinkStyle()
        Dim linkStyle As eYearViewLinkStyle = CalendarView1.YearViewAppointmentLinkStyle

        linkStyle += 1

        If linkStyle > eYearViewLinkStyle.Style5 Then
            linkStyle = eYearViewLinkStyle.None
        End If

        CalendarView1.YearViewAppointmentLinkStyle = linkStyle
    End Sub

#End Region

#Region "YearViewDrawDayBackground"

    ''' <summary>
    ''' Draws the YearView day background
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub YearViewDrawDayBackground(ByVal sender As Object, ByVal e As YearViewDrawDayBackgroundEventArgs)
        If (e.YearMonth.DayIsSelected(e.Date.Day) = False) And (e.YearMonth.DayHasAppointments(e.Date.Day) = True) Then
            Dim color__1 As Color

            Select Case e.[Date].DayOfWeek
                Case DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Friday
                    color__1 = Color.Yellow
                    Exit Select

                Case DayOfWeek.Tuesday, DayOfWeek.Thursday
                    color__1 = Color.Coral
                    Exit Select
                Case Else

                    color__1 = Color.LightGreen
                    Exit Select
            End Select

            Using br As Brush = New SolidBrush(color__1)
                e.Graphics.FillRectangle(br, e.Bounds)
            End Using

            e.Cancel = True
        End If

    End Sub

#End Region

#End Region

#Region "InSideBarMouseUp"

    ''' <summary>
    ''' Handles SideBar MouseUp events
    ''' </summary>
    ''' <param name="view">BaseView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InSideBarMouseUp(ByVal view As BaseView, ByVal e As MouseEventArgs)
        InSideBarContextMenu.Tag = view

        ShowContextMenu(InSideBarContextMenu)
    End Sub

#End Region


#Region "InCondensedViewMouseUp"

    ''' <summary>
    ''' Handles Mouse Up events in the CondensedView
    ''' area of the control
    ''' </summary>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InCondensedViewMouseUp(ByVal e As MouseEventArgs)
        ShowContextMenu(CondensedViewContextMenu)
    End Sub

#End Region

#End Region

#Region "AppointmentViewMouseUp"

    ''' <summary>
    ''' Handles AppointmentView MouseUp events
    ''' </summary>
    ''' <param name="sender">AppointmentView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub AppointmentViewMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim view As AppointmentView = TryCast(sender, AppointmentView)

        ' Select the appointment
        view.IsSelected = True

        ' Let the user delete the appointment
        'AppDeleteContextItem.Enabled = (view.Appointment.IsRecurringInstance = False)
        AppointmentContextMenu.Tag = view

        ShowContextMenu(AppointmentContextMenu)
    End Sub

#Region "miDelete_Click"

    ''' <summary>
    ''' Handles BaseView "Delete Appointment" 
    ''' ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As AppointmentView = TryCast(bi.Parent.Tag, AppointmentView)

        If view IsNot Nothing Then
            CalendarView1.CalendarModel.Appointments.Remove(view.Appointment)
        End If
    End Sub

#End Region

#Region "CategoryColor_Click"

    Private Sub CategoryColor_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As AppointmentView = TryCast(bi.Parent.Tag, AppointmentView)

        If view IsNot Nothing Then
            view.Appointment.CategoryColor = bi.Text
        End If
    End Sub

#End Region

#Region "TimeMarker_Click"

    Private Sub TimeMarker_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AppMarkerTentative.Click, AppMarkerOutOfOffice.Click, AppMarkerFree.Click, AppMarkerDefault.Click, AppMarkerBusy.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As AppointmentView = TryCast(bi.Parent.Tag, AppointmentView)

        If view IsNot Nothing Then
            If bi.Text.Equals("Default") Then
                view.Appointment.TimeMarkedAs = Nothing
            Else
                view.Appointment.TimeMarkedAs = bi.Text
            End If
        End If
    End Sub

#End Region

#End Region

#Region "AllDayPanelMouseUp"

    ''' <summary>
    ''' Handles AllDayPanel MouseUp events
    ''' </summary>
    ''' <param name="sender">AllDayPanel</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub AllDayPanelMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' Let the user Shrink and expand the panel
        ' by 20 each time

        AllDayShrinkContextItem.Enabled = CalendarView1.FixedAllDayPanelHeight = -1 OrElse CalendarView1.FixedAllDayPanelHeight > 20

        AllDayGrowContextItem.Enabled = CalendarView1.FixedAllDayPanelHeight < 200
        AllDayReset.Enabled = CalendarView1.FixedAllDayPanelHeight <> -1
        AllDayPanelContextMenu.Tag = sender

        ShowContextMenu(AllDayPanelContextMenu)
    End Sub

    ''' <summary>
    ''' Handles "Shrink" ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miShrink_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AllDayShrinkContextItem.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim panel As AllDayPanel = TryCast(bi.Parent.Tag, AllDayPanel)

        If CalendarView1.FixedAllDayPanelHeight = -1 Then
            CalendarView1.FixedAllDayPanelHeight = panel.PanelHeight - 20
        Else

            CalendarView1.FixedAllDayPanelHeight = Math.Max(20, CalendarView1.FixedAllDayPanelHeight - 20)
        End If
    End Sub

    ''' <summary>
    ''' Handles "Grow" ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miGrow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AllDayGrowContextItem.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim panel As AllDayPanel = TryCast(bi.Tag, AllDayPanel)

        If CalendarView1.FixedAllDayPanelHeight = -1 Then
            CalendarView1.FixedAllDayPanelHeight = panel.PanelHeight + 20
        Else

            CalendarView1.FixedAllDayPanelHeight = Math.Min(500, CalendarView1.FixedAllDayPanelHeight + 20)
        End If
    End Sub

    ''' <summary>
    ''' Handles "Reset" ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AllDayReset.Click
        CalendarView1.FixedAllDayPanelHeight = -1
    End Sub

#End Region

#Region "TimeRulerPanelMouseUp"

    ''' <summary>
    ''' Handles TimeRulerPanel MouseUp events
    ''' </summary>
    ''' <param name="sender">TimeRulerPanel</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub TimeRulerPanelMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        ShowContextMenu(TimeRulerPanelContextMenu)
    End Sub

    ''' <summary>
    ''' Handles "TimeSlotDuration" ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miTimeDuration_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TimeDuration30.Click, buttonItem9.Click, buttonItem8.Click, buttonItem7.Click, buttonItem6.Click, buttonItem22.Click, buttonItem16.Click, buttonItem15.Click, buttonItem13.Click, buttonItem12.Click, buttonItem11.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        Dim duration As Integer

        If Integer.TryParse(bi.Text, duration) = True Then
            CalendarView1.TimeSlotDuration = duration
            ti.IndicatorTime = _TimeServer
            CalendarView1.TimeLineViewScrollStartDate = _TimeServer.AddHours(-3)
        End If
    End Sub

#End Region

#Region "TimeLineHeaderPanelMouseUp"

    ''' <summary>
    ''' Handles Mouse Up events in the TimeLineHeaderPanel.
    ''' 
    ''' (The TimeLineHeaderPanel is the area at the top of the
    ''' TimeLineView that holds the Period and Interval Headers.)
    ''' </summary>
    ''' <param name="sender">TimeLineHeaderPanel</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub TimeLineHeaderPanelMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim tp As TimeLineHeaderPanel = TryCast(sender, TimeLineHeaderPanel)

        If tp IsNot Nothing Then
            Dim area As eViewArea = tp.GetViewAreaFromPoint(e.Location)

            If area = eViewArea.InPeriodHeader Then
                InPeriodHeaderMouseUp(e)

            ElseIf area = eViewArea.InIntervalHeader Then
                InIntervalHeaderMouseUp(e)
            End If
        End If
    End Sub

#Region "InPeriodHeaderMouseUp"

    ''' <summary>
    ''' Handles MouseUp events in the Period Header
    ''' </summary>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InPeriodHeaderMouseUp(ByVal e As MouseEventArgs)
        ShowContextMenu(PeriodHeaderContextMenu)
    End Sub

#End Region

#Region "InPeriodHeaderHide_Click"

    ''' <summary>
    ''' Handles Period Header "Hide" menu selections
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InPeriodHeaderHide_Click(ByVal sender As Object, ByVal e As EventArgs) 'Handles InPeriodHeaderHide.Click
        'CalendarView1.TimeLineShowPeriodHeader = False
    End Sub

#End Region

#Region "PeriodHeaderContextMenu Period change"

    ''' <summary>
    ''' Handles PeriodHeaderContextMenu "Minute" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPeriodMinutes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnPeriodMinutes.Click
        If btnPeriodMinutes.Checked = True Then
            CalendarView1.TimeLinePeriod = eTimeLinePeriod.Minutes
        End If
    End Sub

    ''' <summary>
    ''' Handles PeriodHeaderContextMenu "Hours" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPeriodHours_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnPeriodHours.Click
        If btnPeriodHours.Checked = True Then
            CalendarView1.TimeLinePeriod = eTimeLinePeriod.Hours
        End If
    End Sub

    ''' <summary>
    ''' Handles PeriodHeaderContextMenu "Days" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPeriodDays_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) 'Handles btnPeriodDays.Click
        If btnPeriodDays.Checked = True Then
            'CalendarView1.TimeLinePeriod = eTimeLinePeriod.Days
        End If
    End Sub

    ''' <summary>
    ''' Handles PeriodHeaderContextMenu "Years" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPeriodYears_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) 'Handles btnPeriodYears.Click
        If btnPeriodYears.Checked = True Then
            'CalendarView1.TimeLinePeriod = eTimeLinePeriod.Years
        End If
    End Sub

#End Region

#Region "InIntervalHeaderMouseUp"

    ''' <summary>
    ''' Handles MouseUp events in the IntervalHeader
    ''' </summary>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InIntervalHeaderMouseUp(ByVal e As MouseEventArgs)
        ' Get rid of any previously added non-essential items

        For i As Integer = IntervalHeaderContextMenu.SubItems.Count - 1 To 3 Step -1
            IntervalHeaderContextMenu.SubItems.RemoveAt(i)
        Next

        ' If the Period Header is not visible, present the user
        ' with the items to be able to re-show it

        lblPeriodHeader2.Visible = (CalendarView1.TimeLineShowPeriodHeader = False)

        btnIntervalHeaderShow.Visible = (CalendarView1.TimeLineShowPeriodHeader = False)

        ' Add some Interval time selection options
        ' for the current selected Interval Period

        Select Case CalendarView1.TimeLinePeriod
            Case eTimeLinePeriod.Minutes
                AddIntervalMinutes()
                Exit Select

            Case eTimeLinePeriod.Hours
                AddIntervalHours()
                Exit Select

            Case eTimeLinePeriod.Days
                AddIntervalDays()
                Exit Select

            Case eTimeLinePeriod.Years
                AddIntervalYears()
                Exit Select
        End Select

        ShowContextMenu(IntervalHeaderContextMenu)
    End Sub

#Region "Interval time support"

#Region "AddIntervalMinutes"

    ''' <summary>
    ''' Adds Interval "Minute" items
    ''' </summary>
    Private Sub AddIntervalMinutes()
        'For i As Integer = 1 To 60
        'If i Mod 5 = 0 Then
        AddIntervalItem(15)
        AddIntervalItem(30)
        AddIntervalItem(45)
        AddIntervalItem(60)
        'End If
        'Next
    End Sub

#End Region

#Region "AddIntervalHours"

    ''' <summary>
    ''' Adds Interval "Hour" items
    ''' </summary>
    Private Sub AddIntervalHours()
        For i As Integer = 1 To 24
            If 24 Mod i = 0 Then
                AddIntervalItem(i)
            End If
        Next
    End Sub

#End Region

#Region "AddIntervalDays"

    ''' <summary>
    ''' Adds Interval "Day" items
    ''' </summary>
    Private Sub AddIntervalDays()
        For i As Integer = 1 To 10
            AddIntervalItem(i)
        Next

        For i As Integer = 30 To 199 Step 30
            AddIntervalItem(i)
        Next

        AddIntervalItem(365)
    End Sub

#End Region

#Region "AddIntervalYears"

    ''' <summary>
    ''' Adds Interval "Year" items
    ''' </summary>
    Private Sub AddIntervalYears()
        For i As Integer = 1 To 10
            AddIntervalItem(i)
        Next
    End Sub

#End Region

#Region "AddIntervalItem"

    ''' <summary>
    ''' Adds individual Interval items
    ''' </summary>
    ''' <param name="i">Item to add</param>
    Private Sub AddIntervalItem(ByVal i As Integer)
        Dim bi As New ButtonItem("", i.ToString())

        AddHandler bi.Click, AddressOf bi_IntervalClick

        If CalendarView1.TimeLineInterval = i Then
            bi.Checked = True
        End If

        IntervalHeaderContextMenu.SubItems.Add(bi)
    End Sub

#End Region

#Region "bi_IntervalClick"

    ''' <summary>
    ''' Handles Interval time selections
    ''' </summary>
    ''' <param name="sender">ButtonItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub bi_IntervalClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        Dim n As Integer

        If Integer.TryParse(bi.Text, n) = True Then
            Try
                CalendarView1.TimeLineInterval = n
                CalendarView1.TimeLineViewScrollStartDate = _TimeServer.AddHours(-2)
            Catch ex As Exception

            End Try

        End If
    End Sub

#End Region

#End Region

#Region "btnIntervalHeaderShow_Click"

    ''' <summary>
    ''' Handles IntervalHeaderContextMenu "Show Header" selections
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnIntervalHeaderShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnIntervalHeaderShow.Click
        CalendarView1.TimeLineShowPeriodHeader = True
    End Sub

#End Region

#End Region

#End Region

#Region "ShowContextMenu"

    ''' <summary>
    ''' Shows the given ContextMenu
    ''' </summary>
    ''' <param name="cm">ContextMenu to show</param>
    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        Dim pt As Point = Control.MousePosition
        cm.Popup(pt)
    End Sub

#End Region

    Private Sub CalendarViewTimeLineGetRowHeight(ByVal sender As Object, ByVal e As TimeLineGetRowHeightEventArgs) Handles CalendarView1.TimeLineGetRowHeight
        Dim ap As Appointment = TryCast(e.CalendarItem.ModelItem, Appointment)

        If ap IsNot Nothing Then
            ' Just for an example, let's make all default color appointments 140 pixels high,
            ' all Blue appointments 70 high, and everything else we will keep the default value.

            If ap.CategoryColor Is Nothing OrElse ap.CategoryColor.Equals("Default") Then
                e.Height = 70

            ElseIf ap.CategoryColor.Equals(Appointment.CategoryBlue) Then
                e.Height = 20
            End If
        End If
    End Sub

    Private Sub btnTimeLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles btnTimeLine.Click
        CalendarView1.SelectedView = Schedule.eCalendarView.TimeLine
        CalendarView1.TimeLinePeriod = eTimeLinePeriod.Minutes
        CalendarView1.TimeLineInterval = 15
        '--
        Call btnFind_Click(Nothing, Nothing)

    End Sub



    Private Sub CalendarView1_TimeLineViewStartDateChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.Schedule.DateChangeEventArgs) Handles CalendarView1.TimeLineViewStartDateChanged
        'Call btnFind_Click(Nothing, Nothing)
        Try
            Dim _StartDate As Date = CDate(sender.TimeLineViewStartDate)
            If _StartDate.Day < dt1_F.Value.Day Then
                CalendarView1.TimeLineViewStartDate = dt1_F.Value
            End If
        Catch ex As Exception
            CalendarView1.TimeLineViewStartDate = dt1_F.Value
        End Try


    End Sub
    Private Sub CalendarView1_TimeLineViewEndDateChanged(sender As Object, e As DateChangeEventArgs) Handles CalendarView1.TimeLineViewEndDateChanged
        Try
            Dim _EndDate As Date = CDate(sender.TimeLineViewEndDate)
            If _EndDate.Day >= dt2_F.Value.Day Then
                CalendarView1.TimeLineViewEndDate = dt2_F.Value
            End If
        Catch ex As Exception
            CalendarView1.TimeLineViewEndDate = dt2_F.Value
        End Try

    End Sub

    Private Sub ADD_LichCang()

        Call Load_TimeServer()
        Dim _sSubject As String = String.Empty, _smamau As String = String.Empty
        Dim _sToolTip As String = String.Empty
        Dim _stag As String = String.Empty
        CalendarView1.CalendarModel.Appointments.Clear()
        Dim _StartTime As DateTime
        Dim _Endtime_ChuaKetThuc As DateTime = _TimeServer
        Dim _Endtime_KetThuc As DateTime = _TimeServer
        Dim _order As Integer = 0
        Dim _order_medaxacnhan As Integer = 0

        '//
        Dim _intMinute As Integer = 0
        '//
        Dim stInfo As String = "<div>" & "<b><font size=""11""><font color=""blue"">{0}</font></font></b><br />" ' MA MAY
        stInfo &= "<font size=""8""><font color=""Black""> {1} </font></font>" & "</div>" 'qui cahc
        '//
        '//
        CalendarView1.SuspendLayout()
        'CalendarView1.BeginUpdate()
        Dgv_LichCang.ReadOnly = False
        For _stt = 0 To defUsers.Length - 1

            For Each row As DataGridViewRow In Dgv_LichCang.Rows
                If row.Cells("mamay").Value.ToString = defUsers(_stt) Then
                    _sSubject = String.Empty
                    '_sSubject = row.Cells(_colMame).Value.ToString.ToUpper
                    _sSubject = String.Format(stInfo, row.Cells("mame_all").Value.ToString.ToUpper,
                                                      row.Cells("phanloai_ngaydem").Value.ToString.ToUpper & "   [" & row.Cells(_coltencongdoan).Value.ToString.ToUpper & "]")

                    _smamau = String.Empty
                    Dim _color_me As String
                    If row.Cells("chon_mau").Value = "-" Then
                        _color_me = Hex(-1)
                    Else
                        _color_me = Hex(row.Cells("chon_mau").Value)
                    End If

                    '--
                    _sToolTip = String.Empty
                    _sToolTip = "Lệnh: " & row.Cells("phanloai_ngaydem").Value.ToString() & vbCrLf
                    _sToolTip &= "Mẻ: " & row.Cells("mame_all").Value.ToString() '& "/" & "Mẻ Ghép: " & row.Cells("mame_ghep").Value.ToString() & vbCrLf
                    '_sToolTip &= "Mẻ: " & row.Cells(_colMame).Value.ToString() & vbCrLf
                    '_sToolTip &= "Màu: " & row.Cells(_colMau).Value.ToString() & " / " & row.Cells(_colMamau).Value.ToString() & vbCrLf
                    '_sToolTip &= "Mã Hàng: " & row.Cells(_colmahang).Value.ToString() & vbCrLf
                    _sToolTip &= "Công Đoạn: " & row.Cells("tencongdoan").Value.ToString() & vbCrLf
                    _sToolTip &= "T.Gian Tối Thiểu: " & row.Cells("thoigian_toithieu").Value.ToString() & vbCrLf
                    '_sToolTip &= "Ghi Chú: " & row.Cells("ghichu").Value.ToString() & vbCrLf
                    '_sToolTip &= "Nhân Viên: " & row.Cells("tennhanvien").Value.ToString()

                    '---
                    _stag = row.Cells("phanloai_ngaydem").Value.ToString.ToUpper & ";"
                    _stag &= row.Cells("congdoan_id").Value.ToString.ToUpper & ";"
                    '_stag &= row.Cells("phanloai_ngaydem").Value.ToString.ToUpper & ";"
                    '_stag &= row.Cells("macongdoan").Value.ToString.ToUpper & ";"
                    '_stag &= row.Cells("mamay_id").Value.ToString.ToUpper & ";"
                    '_stag &= row.Cells("thoigian_toithieu").Value.ToString.ToUpper & ";"

                    '///Mẻ chưa xác nhận
                    _thoigian_toithieu = row.Cells("thoigian_toithieu").Value
                    If row.Cells("hoanthanh").Value = 0 Then
                        '//
                        _sToolTip &= "Giờ Vào: " & row.Cells("thoigianvao").Value.ToString() & vbCrLf
                        _sToolTip &= "Giờ Ra: " & row.Cells("thoigianra").Value.ToString()
                        '//
                        '//Hình Ảnh
                        If row.Cells("ketqua").Value = 1 Then
                            _ImageInt = 0
                        ElseIf row.Cells("ketqua").Value = 2 Then
                            _ImageInt = 4
                        Else
                            _ImageInt = 0
                        End If

                        '//
                        Dim ap As Appointment = AddAppointment_DuKien(_sSubject, _smamau, row.Cells("thoigianvao").Value,
                                           row.Cells("thoigianra").Value,
                            defUsers(_stt), _color_me, Appointment.TimerMarkerTentative, _sToolTip, _stag)
                        'CalendarView1.EnsureVisible(ap)
                    ElseIf row.Cells("hoanthanh").Value = 1 Then
                        _ImageInt = 0
                        _StartTime = row.Cells("thoigianvao").Value
                        _Endtime_KetThuc = row.Cells("thoigianra_dukien").Value
                        '//
                        _sToolTip &= "Giờ Vào: " & row.Cells("thoigianvao").Value.ToString() & vbCrLf
                        _sToolTip &= "Giờ Ra: " & row.Cells("thoigianra_dukien").Value.ToString()

                        '//
                        Dim ap As Appointment = AddAppointment_DuKien(_sSubject, _smamau, _StartTime,
                                             _Endtime_KetThuc,
                            defUsers(_stt), _color_me, Appointment.TimerMarkerOutOfOffice, _sToolTip, _stag)

                    ElseIf row.Cells("hoanthanh").Value = 2 Then
                        _ImageInt = 0
                        _StartTime = row.Cells("thoigianvao_dukien").Value
                        _Endtime_KetThuc = row.Cells("thoigianra_dukien").Value

                        '//
                        Dim ap As Appointment = AddAppointment_DuKien(_sSubject, _smamau, _StartTime,
                                                   _Endtime_KetThuc,
                                    defUsers(_stt), _color_me, Appointment.TimerMarkerDefault, _sToolTip, _stag)
                        'CalendarView1.EnsureVisible(ap)
                    End If
                End If
            Next

        Next
        'CalendarView1.EndUpdate()
        CalendarView1.ResumeLayout()
    End Sub
    Private Sub CalendarViewGetDisplayTemplateText(sender As Object, e As GetDisplayTemplateTextEventArgs)
        Dim view As AppointmentView = TryCast(e.CalendarItem, AppointmentView)

        If view IsNot Nothing Then
            Select Case e.DisplayTemplate
                Case "[MyStartTimeTemplate]"
                    e.DisplayText = [String].Format("{0:F}", view.Appointment.StartTime)
                    Exit Select

                Case "[MyEndTimeTemplate]"
                    e.DisplayText = [String].Format("{0:T}", view.Appointment.EndTime)
                    Exit Select
            End Select
        End If
    End Sub
    Private Function AddAppointment_DuKien(ByVal s As String, ByVal _smamau As String, ByVal startTime As DateTime, ByVal endTime As DateTime,
                                           ByVal ownerKey As String, ByVal color As String, ByVal marker As String,
                                           ByVal _tooltip As String, ByVal _tag As String) As Appointment
        Dim appointment As New Appointment()

        appointment.StartTime = startTime
        appointment.EndTime = endTime '.AddMinutes(CalendarView1.TimeLineInterval)
        appointment.OwnerKey = ownerKey
        appointment.Subject = s
        appointment.Description = _smamau
        appointment.Tag = _tag
        appointment.CategoryColor = "#" & color
        appointment.TimeMarkedAs = marker
        If _ImageInt > 0 Then
            Dim st As String = ImageList1.Images.Keys.Item(_ImageInt).ToString
            appointment.ImageKey = st
            appointment.ImageAlign = eImageContentAlignment.MiddleRight
        End If

        If color = "FF000000" Then
            'appointment.DisplayTemplate = " <font color='#ffffff'><font size='10'><b>[Subject]</b></font></font>"
        ElseIf color = "FFFFFFFF" Then
            'appointment.DisplayTemplate = " <font color='#000000'><font size='10'><b>[Subject]</b></font></font>"
        Else
            'appointment.DisplayTemplate = " <font size='10'><b>[Subject]</b></font>"
        End If
        'appointment.DisplayTemplate = "<b><i>[StartDate]</i></b>" & " " & "<b>[StartTime] – [EndTime]</b>" & " <font color='#ED1C24'>[Subject]</font><br/>" & "<font size='14'>[Description]</font><br/>" & "[Tag]"
        appointment.Tooltip = _tooltip
        CalendarView1.CalendarModel.Appointments.Add(appointment)
        appointment.Locked = True
        Return (appointment)
    End Function

#End Region

#Region "COLOR"
    Private Function AddColor(ByVal Text As String, ByVal word As String, ByVal color As String) As String
        Return Text.Replace(word, "<span color: '" & color & "'>" & word & "</span>")
    End Function

    Private Function ContrastColor(ByVal color As Color) As Color
        Dim d As Integer = 0
        Dim luminance As Double = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255

        If luminance > 0.5 Then
            d = 0
        Else
            d = 255
        End If

        Return Color.FromArgb(d, d, d)
    End Function
    Public Shared Function HexToColor(ByVal hexColor As String) As Color
        If hexColor.IndexOf("#"c) <> -1 Then
            hexColor = hexColor.Replace("#", "")
        End If
        Dim red As Integer = 0
        Dim green As Integer = 0
        Dim blue As Integer = 0
        If hexColor.Length = 6 Then
            red = Integer.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier)
            green = Integer.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier)
            blue = Integer.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier)
        ElseIf hexColor.Length = 3 Then
            red = Integer.Parse(hexColor(0).ToString() + hexColor(0).ToString(), NumberStyles.AllowHexSpecifier)
            green = Integer.Parse(hexColor(1).ToString() + hexColor(1).ToString(), NumberStyles.AllowHexSpecifier)
            blue = Integer.Parse(hexColor(2).ToString() + hexColor(2).ToString(), NumberStyles.AllowHexSpecifier)
        End If
        Return Color.FromArgb(red, green, blue)
    End Function

#End Region
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If chkAuto_Refresh.CheckState = CheckState.Checked Then
            Dim _Minutes As Integer = CInt(Now.Minute.ToString)
            If _Minutes <> _Time_old Then
                Call Filterdata_Stored()
                _Time_old = _Minutes
            End If
        Else
            _intTime_Auto = 0
        End If
    End Sub

    Private Sub chkAuto_Refresh_CheckedChanged(sender As Object, e As EventArgs)
        If chkAuto_Refresh.CheckState = CheckState.Checked Then
            'Timer1.Enabled = True
        Else
            'Timer1.Enabled = False
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        isActive = False
        '//
        CalendarView1.DisplayedOwners.Clear()
        '_Model = New CalendarModel()
        'AddSampleAppointments()
        'AddHolidaySchedule()
        'CalendarView1.CalendarModel = _Model

        Call Load_MayMoc()
        'wait(200)
        '//
        CalendarView1.DisplayedOwners.AddRange(defUsers)
        '//
        Call Filterdata_Stored()
    End Sub


#Region "calendarView1_ItemDoubleClick"

    ''' <summary>
    ''' Handles Appointment View double clicks
    ''' </summary>
    ''' <param name="sender">AppointmentView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub calendarView1_ItemDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CalendarView1.ItemDoubleClick
        Dim item As AppointmentView = TryCast(sender, AppointmentView)
        Dim _SelectedOwner As String = String.Empty
        Dim _Mame As String = String.Empty
        If item IsNot Nothing Then
            Dim ap As Appointment = item.Appointment
            _SelectedOwner = ap.OwnerKey

            _List_Data = {}
            Dim arrayLetters As String = ap.Tag
            arrayLetters = arrayLetters.Replace(" ", "")
            _List_Data = arrayLetters.Split(";")
            '///
            _LPhanLoai_NgayDem = _List_Data(0)
            '_Mame = _List_Data(1)
            _LCongDoan_id = _List_Data(1)
            '_LMaCongDoan = _List_Data(3)
            _LMamay_id = _List_Data(2)
            '_thoigian_toithieu = _List_Data(5)
            '_GioVao = ap.StartTime
            '//
            With frmTimeLine_Confirm_View
                .CongDoan_ID = _LCongDoan_id
                '.MaCongDoan = _LMaCongDoan
                .PhanLoai_NgayDem = _LPhanLoai_NgayDem
                .MaMay = _SelectedOwner
            End With

            ShowModalForm_CongDoan_View()
        Else
            _SelectedOwner = CalendarView1.SelectedOwner
            frmNhatKySanXuat_Update_CongDoan.MaMay = _SelectedOwner
            ShowModalForm_SapXepMeNhuom()
        End If


        '//
    End Sub


#End Region

#Region "XAC NHAN ME NHUOM"
    Private Sub ShowModalForm_CongDoan_View()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_CongDoan_View))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmTimeLine_Confirm_View
                .Size = New Size(Form_KhoMoc.Width * 0.95, Form_KhoMoc.Height * 0.95)
                .StartPosition = FormStartPosition.CenterParent
                '//
                .Text = "XÁC NHẬN THỰC HIỆN"
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_Stored()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub
    Private Sub ShowModalForm_XacNhanThucHien()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_XacNhanThucHien))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmTimeLine_Confirm
                .Size = New Size(Form_KhoMoc.Width * 0.95, Form_KhoMoc.Height * 0.85)
                .StartPosition = FormStartPosition.CenterParent
                '//
                .Text = "XÁC NHẬN THỰC HIỆN"
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_Stored()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub
#End Region


#Region "SAP XEP ME"
    Private Sub ShowModalForm_SapXepMeNhuom()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New Action(AddressOf ShowModalForm_SapXepMeNhuom))
        Else
            'Using f As frmKhoTong_NhapKho_input ' = New frmKhoTong_NhapKho_input With {.MaximizeBox = False, .MinimizeBox = False}
            With frmNhatKySanXuat_Update_CongDoan
                .Size = New Size(Form_KhoMoc.Width * 0.95, Form_KhoMoc.Height * 0.95)
                .StartPosition = FormStartPosition.CenterParent
                '//
                .Text = "Dự Tính Lệnh Sản Xuất"
                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ' Yes, so grab the values you want from the dialog here
                    Call Filterdata_Stored()
                Else
                    Me.Focus()
                End If

            End With
            'End Using
        End If
    End Sub



#End Region

#Region "tooltip"
    Private _AppointmentBalloon As Balloon = Nothing

    Private Sub SetupAppointmentBalloon()
        _AppointmentBalloon = New Balloon()
        _AppointmentBalloon.AutoCloseTimeOut = 10
        _AppointmentBalloon.Owner = Me

    End Sub
    Private Sub calendarView1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles CalendarView1.MouseEnter
        Dim view As AppointmentView = TryCast(sender, AppointmentView)
        If view Is Nothing Then
            Return
        End If

        If _AppointmentBalloon Is Nothing Then
            SetupAppointmentBalloon()
        End If
        Try
            _AppointmentBalloon.CaptionText = "THÔNG TIN MẺ NHUỘM"
            _AppointmentBalloon.Text = view.Tooltip
            _AppointmentBalloon.AutoResize()
            _AppointmentBalloon.Show(view, False)
            _AppointmentBalloon.Font = New System.Drawing.Font("Time New Roman", 12, FontStyle.Regular)
            _AppointmentBalloon.CaptionFont = New System.Drawing.Font("Time New Roman", 12, FontStyle.Bold)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub calendarView1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles CalendarView1.MouseLeave
        If _AppointmentBalloon IsNot Nothing AndAlso _AppointmentBalloon.Visible Then
            _AppointmentBalloon.Hide()
        End If
    End Sub

#End Region

#Region "QUET MA QUAN LY"
    Private Sub Dang_nhap_ly()
        Dim _masonhanvien As String = gLeft(txtmaso_quanly.Text, Len(txtmaso_quanly.Text) - 1)
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("masonhanvien='" + ReplaceTextXML(_masonhanvien) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("VpsXmlList_NhanVien_UpSet", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        If dt_local.Rows.Count > 0 Then
            txttenquanly.Text = dt_local.Rows(0).Item("tennhanvien")
        Else
            txttenquanly.Text = String.Empty
            txtmasonhanvien.Focus()
        End If
    End Sub

    Private Sub txtmaso_quanly_TextChanged(sender As Object, e As EventArgs) Handles txtmaso_quanly.TextChanged
        If txtmaso_quanly.Text.Length > 2 Then
            If gRight(txtmaso_quanly.Text, 1).ToLower = "w" Then
                Dang_nhap_ly()
            End If
        Else
            txttenquanly.Text = String.Empty
        End If

    End Sub

#End Region

#Region "QUET MA NHAN VIEN"
    Private Sub btnXacNhan_CongDoan_Click(sender As Object, e As EventArgs) Handles btnXacNhan_CongDoan.Click
        '//
        With GP_Form_CapNhat
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.8)
            .Location = New Point(CInt((CalendarView1.Width / 2) - (.Width / 2)), CInt((CalendarView1.Height / 2) - (.Height / 2)))
            .Visible = True
            '//

            txtmaso_quanly.Focus()
        End With
        '//
    End Sub
    '//
    Private Sub Dang_nhap()
        Dim _masonhanvien As String = gLeft(txtmasonhanvien.Text, Len(txtmasonhanvien.Text) - 1)
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("masonhanvien='" + ReplaceTextXML(_masonhanvien) + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("VpsXmlList_NhanVien_UpSet", sbXMLString.ToString, "select_khuvuc")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        If dt_local.Rows.Count > 0 Then
            strUser = txtmasonhanvien.Text
            LNV_ID = dt_local.Rows(0).Item("NV_ID")
            LKhuvuc_ID = dt_local.Rows(0).Item("khuvuc_id")
            '//
            txttennhanvien.Text = dt_local.Rows(0).Item("tennhanvien")
            txtkhuvuc.Text = dt_local.Rows(0).Item("tenkhuvuc")
            '//
            frmTimeLine_Confirm.KhuVuc_ID = LKhuvuc_ID
            frmTimeLine_Confirm.NhanVien_ID = LNV_ID
            frmTimeLine_Confirm.NhanVien = txttennhanvien.Text
            frmTimeLine_Confirm.KhuVuc = txtkhuvuc.Text
            GP_Form_CapNhat.Visible = False
            ShowModalForm_XacNhanThucHien()
        Else
            LNV_ID = String.Empty
            LKhuvuc_ID = String.Empty
            txttennhanvien.Text = String.Empty
            txtmasonhanvien.Text = String.Empty
            txtkhuvuc.Text = String.Empty
            txtmasonhanvien.Focus()
        End If
    End Sub

    Private Sub txtmasonhanvien_TextChanged(sender As Object, e As EventArgs) Handles txtmasonhanvien.TextChanged
        If txtmasonhanvien.Text.Length > 2 Then
            If gRight(txtmasonhanvien.Text, 1).ToLower = "w" Then
                Dang_nhap()
                BtnExit_CapNhat_Click(Nothing, Nothing)
            End If
        End If

    End Sub
    Private Sub BtnExit_CapNhat_Click(sender As Object, e As EventArgs) Handles BtnExit_CapNhat.Click
        GP_Form_CapNhat.Visible = False
    End Sub

    Private Sub btnXacNhan_GioRa_Click(sender As Object, e As EventArgs) Handles btnXacNhan_GioRa.Click
        If txtmasonhanvien.Text.Length > 2 Then
            If gRight(txtmasonhanvien.Text, 1).ToLower = "w" Then
                Dang_nhap()
                BtnExit_CapNhat_Click(Nothing, Nothing)
            End If
        End If
    End Sub



#End Region

End Class