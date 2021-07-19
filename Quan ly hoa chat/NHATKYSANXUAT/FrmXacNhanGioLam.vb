
Imports DevComponents.Schedule.Model
Imports DevComponents.Schedule
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Schedule
Imports System
Imports System.Collections.Generic

Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Net
Imports System.Text
Imports Microsoft.VisualBasic
Imports System.Globalization
Imports DevComponents.DotNetBar.Rendering

Public Class FrmXacNhanGioLam
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
    '//
    Private _Model As New CalendarModel()
    Private Lkhuvuc_id As String = String.Empty
    Private LID As String = String.Empty
    Dim dr2 As DataRow()
    '//
    Dim _List_Data As String() = {}
    Dim strData As List(Of String) = _List_Data.ToList()
    '//

    Private Sub Frm_Select_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Dispose()
        System.GC.Collect()
        System.GC.WaitForPendingFinalizers()
    End Sub
    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        With txtmasonhanvien
            If .Focused = False Then
                .Focus()
                .Text = e.KeyChar.ToString
                .SelectionStart = .Text.Length
                e.Handled = True
            End If
        End With
    End Sub

    Private Sub Me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New KhoSanXuatDAL
        mocls = New Clsconnect
        dt_congdoan = New DataTable

        dt_local = New DataTable
        dt_khuvuc = New DataTable

        Call Load_TimeServer()
        With dt1_F
            '.Value = Now
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy 00:00"
        End With
        With dt2_F
            '.Value = Now
            .Format = DevComponents.Editors.eDateTimePickerFormat.Custom
            .CustomFormat = "dd/MM/yyyy 23:59"
        End With
        '--
        Me.dt1_F.Value = _TimeServer.AddDays(-7)
        Me.dt2_F.Value = _TimeServer.AddDays(1)
        '--
        'InitializeComponent()
        CalendarView1.Dock = DockStyle.Fill
        '//
        _Model = New CalendarModel()

        CalendarView1.CalendarModel = _Model


        '//
        CalendarView1.TimeLinePeriodHeaderAlignment = eItemAlignment.Center
        '//
        CalendarView1.SelectedView = Schedule.eCalendarView.TimeLine
        CalendarView1.TimeLinePeriod = eTimeLinePeriod.Hours
        CalendarView1.TimeLineInterval = 1
        'AddHandler CalendarView1.AppointmentReminder, AddressOf AppointmentReminder
        ' AddHandler CalendarView1.AppointmentStartTimeReached, AddressOf AppointmentStartTimeReached
        CalendarView1.TimeLineMultiUserTabWidth = 100
        CalendarView1.TimeLineMultiUserTabOrientation = eOrientation.Horizontal
        CalendarView1.TimeLineHeight = 45
        CalendarView1.TimeLineStretchRowHeightMode = TimeLineStretchRowHeightMode.Full
        CalendarView1.TimeLineStretchRowHeight = True
        CalendarView1.TimeLineCondensedViewVisibility = eCondensedViewVisibility.Hidden
        CalendarView1.TimeLineCondensedViewHeight = 10
        CalendarView1.TimeLineShowCollateLines = False
        '//
        'CalendarView1.ViewDisplayCustomizations.DaySlotBackgrounds.Remove(DateTime.Today)
        'CalendarView1.ViewDisplayCustomizations.DaySlotBackgrounds.Remove(DayOfWeek.Sunday)
        CalendarView1.TimeIndicator.IndicatorTime = _TimeServer
        CalendarView1.TimeIndicator.Visibility = eTimeIndicatorVisibility.AllResources

        CalendarView1.CalendarModel.Appointments.Clear()
        '//
        AddHandler CalendarView1.GetDisplayTemplateText, AddressOf CalendarViewGetDisplayTemplateText
        AddHandler CalendarView1.TimeLineGetRowHeight, AddressOf CalendarViewTimeLineGetRowHeight
        'AddHandler CalendarView1.DisplayedOwnersChanged, AddressOf calendarView_OwnersChanged
        'AddHandler CalendarView1.SelectedOwnerChanged, AddressOf calendarView_OwnersChanged
        '--

        Try
            CalendarView1.CalendarModel.WorkDays.Add(New WorkDay(DayOfWeek.Saturday))
            Dim workStartTime As WorkTime = New WorkTime(0, 0)
            Dim workEndTime As WorkTime = New WorkTime(11, 59)

            For Each workDay As WorkDay In CalendarView1.CalendarModel.WorkDays
                workDay.WorkStartTime = workStartTime
                workDay.WorkEndTime = workEndTime
            Next
            ' Mark time slots every Sunday from 12:00 to 17:00

            Dim dsa As New DaySlotAppearance(New WorkTime(0, 0), New WorkTime(11, 59), Color.White, Color.White, Color.White)
            Dim dsb As New DaySlotBackground(DayOfWeek.Tuesday, dsa)

            CalendarView1.ViewDisplayCustomizations.DaySlotBackgrounds.Add(dsb)

            ' Mark time slots for today from 9:00 to 13:30

            dsa = New DaySlotAppearance(New WorkTime(12, 0), New WorkTime(23, 59), Color.Green, Color.Green, Color.Green)
            dsb = New DaySlotBackground(DayOfWeek.Tuesday, dsa)

        Catch
        End Try

        Call Load_CongDoan()
        'wait(200)
        '//

        CalendarView1.DisplayedOwners.AddRange(defUsers)
        ' And add our base set of users

    End Sub
    Private Sub Load_CongDoan()
        Dim owner As New Owner("JET 01", "JET 01", eCalendarColor.Red)
        Dim y As Integer = 0
        dt_khuvuc = VpsXmlList_Load("", "", "khuvuc")
        Dim myList As New List(Of String)()
        For Each row As DataRow In dt_khuvuc.Rows
            ' Write value of first Integer.
            myList.Add(row.Item("makhuvuc").ToString)
            'Console.WriteLine(row.Field(Of Integer)(0))
            y += 1
            If row.Item("khuvuc_id") = "V001" Then
                owner = New Owner(row.Item("makhuvuc").ToString, row.Item("tenkhuvuc").ToString.ToUpper,
                                  eCalendarColor.Red)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "V002" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper,
                                  eCalendarColor.Blue)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "V003" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Green)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "V004" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Steel)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "V005" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Green)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "V006" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Red)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "V007" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Green)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "V008" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Olive)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "V009" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Purple)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "V010" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Teal)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "M011" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Yellow)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "M012" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Green)
                _Model.Owners.Add(owner)
            ElseIf row.Item("khuvuc_id") = "M012" Then
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.DarkSteel)
                _Model.Owners.Add(owner)
            Else
                owner = New Owner(row.Item("makhuvuc").ToString.ToUpper, row.Item("tenkhuvuc").ToString.ToUpper, eCalendarColor.Automatic)
                _Model.Owners.Add(owner)
            End If
        Next
        defUsers = myList.ToArray
    End Sub
    Private Sub Frm_Select_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CalendarView1.TimeIndicator.IndicatorSource = eTimeIndicatorSource.UserSpecified
        CalendarView1.TimeIndicator.IndicatorTime = _TimeServer
        CalendarView1.TimeIndicator.Visibility = eTimeIndicatorVisibility.AllResources
        CalendarView1.TimeIndicator.IndicatorArea = eTimeIndicatorArea.All

        Call Filterdata_Stored()

    End Sub

    Private Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        CalendarView1.TimeLineViewStartDate = Format$(dt1_F.Value, "dd/MM/yyyy 00:00")
        CalendarView1.TimeLineViewEndDate = Format$(dt2_F.Value, "dd/MM/yyyy 23:59")
        '//
        CalendarView1.TimeLineViewScrollStartDate = _TimeServer.AddHours(-3)
        '//
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("dtngay1='" + Format$(dt1_F.Value, "MM/dd/yyyy HH:mm") + "' ")
        sbXMLString.Append("dtngay2='" + Format$(dt2_F.Value, "MM/dd/yyyy HH:mm") + "' ")
        sbXMLString.Append("tennhanvien='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New KhoSanXuatDTO("[VpsXmlvps_VP_KhuVuc_LamViec_Schedule]", sbXMLString.ToString, "select")
        dt_local = dtControler.SELECT_XML_Datatable(_dt)
        Dgv_LichCang.DataSource = New DataView(dt_local, "", "tennhanvien asc,thoigianvao desc,thoigianra asc,rid asc", DataViewRowState.CurrentRows)
        Call ADD_LichCang()
        '//
        IsBusy = False
    End Sub

#Region "TIMELINE"

    ''' <summary>
    ''' Handles CalendarView MouseUp events
    ''' </summary>
    ''' <param name="sender">Varied sender</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub calendarView1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' Process Right MouseUp event in order to
        ' present view specific ContextMenu

        If e.Button = MouseButtons.Right Then
            ' Main Calendar View hit

            If TypeOf sender Is BaseView Then
                BaseViewMouseUp(sender, e)

                ' AppointmentView hit

            ElseIf TypeOf sender Is AppointmentView Then
                AppointmentViewMouseUp(sender, e)

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
            'InDayOfWeekHeaderMouseUp(view, e)


        ElseIf area = eViewArea.InSideBarPanel Then
            'InSideBarMouseUp(view, e)

        ElseIf area = eViewArea.InCondensedView Then
            'InCondensedViewMouseUp(e)
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

        AddNewAppointment(startDate, endDate)

    End Sub

    ''' <summary>
    ''' Adds a new appointment at the user selected time
    ''' </summary>
    Private Function AddNewAppointment(ByVal startDate As DateTime, ByVal endDate As DateTime) As Appointment
        ' Create new appointment and add it to the model
        ' Appointment will show up in the view automatically

        Dim appointment As New Appointment()

        appointment.StartTime = startDate
        appointment.EndTime = endDate
        appointment.OwnerKey = CalendarView1.SelectedOwner

        appointment.Subject = "New " & appointment.CategoryColor & " appointment!"

        appointment.Description = "This is a new appointment"
        appointment.Tooltip = "This is a Custom tooltip for this new appointment"

        ' Add appointment to the model

        CalendarView1.CalendarModel.Appointments.Add(appointment)

        Return (appointment)
    End Function
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

    Private Sub TimeMarker_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AppMarkerFree.Click, AppMarkerDefault.Click, AppMarkerBusy.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As AppointmentView = TryCast(bi.Parent.Tag, AppointmentView)

        If view IsNot Nothing Then
            If bi.Text.Equals("Hủy Giờ Vào") Then
                'view.Appointment.TimeMarkedAs = Nothing
                'HuyGioVao()
            ElseIf bi.Text.Equals("Hủy Giờ Ra") Then
                'HuyGioRa()
            ElseIf bi.Text.Equals("Kết Thúc") Then
                btnXacNhan_GioRa_Click(Nothing, Nothing)
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
            'ti.IndicatorTime = _TimeServer
            'CalendarView1.TimeLineViewScrollStartDate = _TimeServer.AddHours(-3)
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
    Private Sub InPeriodHeaderHide_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InPeriodHeaderHide.Click
        CalendarView1.TimeLineShowPeriodHeader = False
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
    Private Sub btnPeriodDays_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnPeriodDays.Click
        If btnPeriodDays.Checked = True Then
            CalendarView1.TimeLinePeriod = eTimeLinePeriod.Days
        End If
    End Sub

    ''' <summary>
    ''' Handles PeriodHeaderContextMenu "Years" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPeriodYears_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnPeriodYears.Click
        If btnPeriodYears.Checked = True Then
            CalendarView1.TimeLinePeriod = eTimeLinePeriod.Years
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

    Private Sub CalendarViewTimeLineGetRowHeight(ByVal sender As Object, ByVal e As TimeLineGetRowHeightEventArgs)
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
        CalendarView1.TimeLineInterval = 30
        '--
        Call btnFind_Click(Nothing, Nothing)

    End Sub



    Private Sub CalendarView1_TimeLineViewStartDateChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.Schedule.DateChangeEventArgs)
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
    Private Sub CalendarView1_TimeLineViewEndDateChanged(sender As Object, e As DateChangeEventArgs)
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
        Dim _Endtime As DateTime
        Dim _Endtime_ChuaKetThuc As DateTime = _TimeServer
        Dim _Endtime_KetThuc As DateTime = _TimeServer
        Dim _CompareTime As DateTime
        Dim _order As Integer = 0
        Dim _order_medaxacnhan As Integer = 0
        Dim _thoigian_toithieu As Integer = 0
        '//
        Dim stInfo As String = "<div>" & "<b><font size=""12""><font color=""blue"">{0}</font></font></b><br />" ' MA MAY
        stInfo &= "<font size=""13""><font color=""Black""> {1} </font></font>" 'qui cahc
        stInfo &= "<h6><font color=""Black"">{2}</font></h6>" 'donhang
        stInfo &= "<h6><font color=""Brown"">{3}</font></h6>" & "</div>" 'Ngay Chay May
        '//
        '//
        Dgv_LichCang.ReadOnly = False
        For _stt = 0 To defUsers.Length - 1
            For Each row As DataGridViewRow In Dgv_LichCang.Rows
                _sSubject = String.Empty
                _stag = String.Empty
                '_sSubject = row.Cells(_colMame).Value.ToString.ToUpper
                _sSubject = String.Format(stInfo, row.Cells(_coltennhanvien).Value.ToString.ToUpper,
                                              "", "", "")

                _smamau = String.Empty
                Dim _color_me As String = Hex("-1")
                '--

                If row.Cells("makhuvuc").Value = defUsers(_stt) Then
                    _sToolTip = String.Empty
                    _sToolTip = "NHÂN VIÊN: " & row.Cells("tennhanvien").Value.ToString() & vbCrLf
                    If IsDBNull(row.Cells("thoigianvao").Value) = False Then
                        _sToolTip &= "GIỜ VÀO: " & row.Cells("thoigianvao").Value.ToString() & vbCrLf
                    Else
                        _sToolTip &= "GIỜ VÀO: - " & vbCrLf
                    End If
                    If IsDBNull(row.Cells("thoigianra").Value) = False Then
                        _sToolTip &= "GIỜ RA: " & row.Cells("thoigianra").Value.ToString() & vbCrLf
                    Else
                        _sToolTip &= "GIỜ RA: - "
                    End If
                    '_sToolTip &= "Mã Màu: " & row.Cells(_colMamau).Value.ToString() & vbCrLf
                    '_sToolTip &= "Mã Hàng: " & row.Cells(_colmahang).Value.ToString() & vbCrLf
                    '_sToolTip &= "Khách Hàng: " & row.Cells(_colkhachhang).Value.ToString() & vbCrLf
                    '_sToolTip &= "Ghi Chú: " & row.Cells(_colghichu).Value.ToString() & vbCrLf
                    _sToolTip &= "Nhân Viên: " & row.Cells("tennhanvien").Value.ToString() & vbCrLf
                    '///
                    _stag = row.Cells("maid").Value.ToString.ToUpper & ";"
                    _stag &= row.Cells("masonhanvien").Value.ToString.ToUpper
                    '///
                    '///Mẻ chưa xác nhận
                    _thoigian_toithieu = row.Cells("thoigian_toithieu").Value
                    If IsDBNull(row.Cells("thoigianvao").Value) = False AndAlso IsDBNull(row.Cells("thoigianra").Value) = True Then
                        _StartTime = row.Cells("thoigianvao").Value
                        _CompareTime = _StartTime.AddMinutes(_thoigian_toithieu)
                        If _CompareTime < _TimeServer Then
                            _Endtime_ChuaKetThuc = _TimeServer
                        Else
                            _Endtime_ChuaKetThuc = _CompareTime
                        End If
                        '//
                        Dim ap As Appointment = AddAppointment_DuKien(_sSubject, _smamau, _StartTime,
                                         _Endtime_ChuaKetThuc,
                        defUsers(_stt), _color_me, Appointment.TimerMarkerOutOfOffice, _sToolTip, _stag)
                        'CalendarView1.EnsureVisible(ap)
                        _order_medaxacnhan += 1
                        '//Mẻ Chưa Xác Nhận Vào

                    ElseIf IsDBNull(row.Cells("thoigianvao").Value) = False AndAlso IsDBNull(row.Cells("thoigianra").Value) = False Then
                        '///
                        _Endtime_KetThuc = row.Cells("thoigianra").Value
                        '//
                        Dim ap As Appointment = AddAppointment_DuKien(_sSubject, _smamau, row.Cells("thoigianvao").Value,
                                       row.Cells("thoigianra").Value,
                      defUsers(_stt), _color_me, Appointment.TimerMarkerTentative, _sToolTip, _stag)
                        'CalendarView1.EnsureVisible(ap)
                    ElseIf IsDBNull(row.Cells("thoigianvao").Value) = True Then
                        If _order = 0 Then
                            If _order_medaxacnhan = 0 Then
                                _StartTime = _TimeServer
                            Else
                                If _Endtime_ChuaKetThuc <= _Endtime_KetThuc Then
                                    _StartTime = _Endtime_KetThuc.AddMinutes(5)
                                Else
                                    _StartTime = _Endtime_ChuaKetThuc.AddMinutes(5)
                                End If

                            End If

                            _Endtime = _StartTime.AddMinutes(_thoigian_toithieu)
                            '_color_me = Hex(CStr(txtColor_ChuaCang.BackColor.ToArgb))
                            '//
                            Dim ap As Appointment = AddAppointment_DuKien(_sSubject, _smamau, _StartTime,
                                         _Endtime,
                        defUsers(_stt), _color_me, Appointment.TimerMarkerDefault, _sToolTip, _stag)
                            'CalendarView1.EnsureVisible(ap)
                        Else
                            _StartTime = _Endtime.AddMinutes(5)
                            _Endtime = _StartTime.AddMinutes(_thoigian_toithieu)
                            '//
                            '///
                            '_sToolTip &= "Giờ Ra: " & row.Cells("thoigian_thucte_ra").Value.ToString()
                            '_color_me = Hex(CStr(txtColor_ChuaCang.BackColor.ToArgb))
                            '//

                            Dim ap As Appointment = AddAppointment_DuKien(_sSubject, _smamau, _StartTime,
                                         _Endtime,
                        defUsers(_stt), _color_me, Appointment.TimerMarkerDefault, _sToolTip, _stag)
                            'CalendarView1.EnsureVisible(ap)
                        End If
                        _order += 1

                    End If
                Else
                    _order = 0
                    _order_medaxacnhan = 0
                End If

            Next
        Next
        Dgv_LichCang.ReadOnly = True

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
                                           ByVal ownerKey As String, ByVal color As String, ByVal marker As String, ByVal _tooltip As String,
                                           ByVal _tag As String) As Appointment
        Dim appointment As New Appointment()

        appointment.StartTime = startTime
        appointment.EndTime = endTime '.AddMinutes(CalendarView1.TimeLineInterval)
        appointment.OwnerKey = ownerKey
        appointment.Subject = s
        appointment.Description = _smamau
        appointment.Tag = _tag
        appointment.CategoryColor = "#" & color
        appointment.TimeMarkedAs = marker

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

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        isActive = False
        Call Filterdata_Stored()
    End Sub

#End Region
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


    Private _ColorCycle As Integer = 0
    ''' <summary>
    ''' Sets new colors for the given color table
    ''' </summary>
    ''' <param name="colors">Color Table</param>
    Private Sub SetNewScheme(ByVal colors As Color())
        ' Loop through each color in the table

        For i As Integer = 0 To colors.Length - 1
            colors(i) = GetNewColor(colors(i))
        Next
    End Sub

    ''' <summary>
    ''' Gets a new RGB cycle color
    ''' </summary>
    ''' <param name="color1">Current color</param>
    ''' <returns>New cycled color</returns>
    Private Function GetNewColor(ByVal color1 As Color) As Color
        If (_ColorCycle And 1) = 0 Then
            Return (Color.FromArgb(color1.R, color1.B, color1.G))
        End If

        Return (Color.FromArgb(color1.G, color1.R, color1.B))
    End Function
    Private Sub CycleViewColors_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
        If TypeOf GlobalManager.Renderer Is Office2007Renderer Then
            Dim ct As Office2007ColorTable = DirectCast(GlobalManager.Renderer, Office2007Renderer).ColorTable

            For Each val As Integer In [Enum].GetValues(GetType(eCalendarWeekDayPart))
                SetNewScheme(ct.CalendarView.WeekDayViewColors(val).Colors)
            Next

            For Each val As Integer In [Enum].GetValues(GetType(eCalendarMonthPart))
                SetNewScheme(ct.CalendarView.MonthViewColors(val).Colors)
            Next

            For Each val As Integer In [Enum].GetValues(GetType(eTimeRulerPart))
                SetNewScheme(ct.CalendarView.TimeRulerColors(val).Colors)
            Next

            CalendarView1.Refresh()

            _ColorCycle += 1
        End If
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
        _dt = New KhoSanXuatDTO("VpsXmlList_NhanVien_UpSet", sbXMLString.ToString, "select")
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

    Private Sub txtmasonhanvien_TextChanged(sender As Object, e As EventArgs) Handles txtmasonhanvien.TextChanged
        If txtmasonhanvien.Text.Length > 3 Then
            If gRight(txtmasonhanvien.Text, 1).ToLower = "w" Then
                Timer1.Enabled = True
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Dang_nhap()
    End Sub

    Private Sub btnXacNhan_GioVao_Click(sender As Object, e As EventArgs) Handles btnXacNhan_GioVao.Click
        dr2 = dt_khuvuc.Select("makhuvuc = '" & txtkhuvuc.Text & "'", "")
        If dr2.Length > 0 Then
            Lkhuvuc_id = dr2.First.Item("khuvuc_id")
        Else
            Lkhuvuc_id = String.Empty
            MsgBox("Vui Lòng Chọn Khu Vực Muốn Làm Việc", MsgBoxStyle.Information, "Thông Báo")
        End If
        '//Kiem Tra Thoi Gian Ra Max

        Dim lenh As String = String.Empty, _mamay_id As String = String.Empty
        LID = Now.Ticks.ToString
        Call Update_Data("update_start")
    End Sub

    Private Sub btnXacNhan_GioRa_Click(sender As Object, e As EventArgs) Handles btnXacNhan_GioRa.Click
        Call Update_Data("update_end")
    End Sub



    Private Sub Update_Data(ByVal sqlcommand As String)
        If MsgBox("Bạn có muốn thực hiện cập nhật?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Warning") = MsgBoxResult.No Then
            Exit Sub
        End If
        '//
        Call Load_TimeServer()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("maid='" + ReplaceTextXML(LID) + "' ")
        sbXMLString.Append("khuvuc_id='" + ReplaceTextXML(Lkhuvuc_id) + "' ")
        sbXMLString.Append("nv_id='" + ReplaceTextXML(LNV_ID) + "' ")
        sbXMLString.Append("thoigian='" + Format$(_TimeServer, "MM/dd/yyyy HH:mm:ss") + "' ")
        sbXMLString.Append(" />")
        '//
        sbXMLString.Append("</Root>")
        '//
        _dt = New KhoSanXuatDTO("[VpsXmlList_KhuVucLamViec_UpSet]", sbXMLString.ToString, sqlcommand)
        dtControler.UPSET_XML(_dt)
        '//
        Call Filterdata_Stored()
    End Sub

    Private Sub CalendarView1_DoubleClick(sender As Object, e As MouseEventArgs) 'Handles CalendarView1.DoubleClick
        'Try
        If TypeOf sender Is CalendarView Then
            ' Get our current mouse location and convert
            ' the point to local client coordinates

            Dim pt As Point = Control.MousePosition
            Dim c As Control = DirectCast(CalendarView1.GetContainerControl(), Control)

            If c IsNot Nothing Then
                pt = c.PointToClient(pt)
            End If

            ' Get the view to whom this point belongs

            Dim view As BaseView = CalendarView1.GetViewFromPoint(pt)

            If view IsNot Nothing Then
                ' Now locate where in the view the point really is.  If
                ' it is in the tab area, then simply launch a new tab
                Dim item As AppointmentView = TryCast(sender, AppointmentView)
                '//
                If item Is Nothing Then
                    'cboMay.Text = CalendarView1.SelectedOwner
                    '//
                    With GP_Form_CapNhat
                        '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.8)
                        .Location = New Point(CInt((CalendarView1.Width / 2) - (.Width / 2)), CInt((CalendarView1.Height / 2) - (.Height / 2)))
                        .Visible = True
                        '//

                        txtmasonhanvien.Focus()
                    End With
                    '//
                End If

            End If
        End If

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
        If item IsNot Nothing Then
            Dim ap As Appointment = item.Appointment
            _SelectedOwner = ap.OwnerKey

            _List_Data = {}
            Dim arrayLetters As String = ap.Tag
            arrayLetters = arrayLetters.Replace(" ", "")
            _List_Data = arrayLetters.Split(";")
            '///
            LID = _List_Data(0)
            txtmasonhanvien.Text = _List_Data(1)
            '//
            btnXacNhan_GioVao.Enabled = False
            btnXacNhan_GioRa.Enabled = True
        Else
            _SelectedOwner = CalendarView1.SelectedOwner
            txtmasonhanvien.Text = String.Empty
            txttennhanvien.Text = String.Empty
            '//
            btnXacNhan_GioVao.Enabled = True
            btnXacNhan_GioRa.Enabled = False
        End If
        '//
        txtkhuvuc.Text = _SelectedOwner
        '//
        With GP_Form_CapNhat
            '.Size = New Size(Super_Dgv.Width * 0.5, Super_Dgv.Height * 0.8)
            .Location = New Point(CInt((CalendarView1.Width / 2) - (.Width / 2)), CInt((CalendarView1.Height / 2) - (.Height / 2)))
            .Visible = True
            '//
            'SetNightTime()
            '//
            Call Load_TimeServer()
            '//
            txtmasonhanvien.Focus()
        End With
        '//
    End Sub

    Private Sub BtnExit_CapNhat_Click(sender As Object, e As EventArgs) Handles BtnExit_CapNhat.Click
        GP_Form_CapNhat.Visible = False
    End Sub

#End Region

End Class