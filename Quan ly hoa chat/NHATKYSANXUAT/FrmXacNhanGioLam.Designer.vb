<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmXacNhanGioLam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmXacNhanGioLam))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnXacNhan_GioRa = New DevComponents.DotNetBar.ButtonX()
        Me.btnXacNhan_GioVao = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dt1_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnFind = New DevComponents.DotNetBar.ButtonX()
        Me.dt2_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtmasonhanvien = New System.Windows.Forms.TextBox()
        Me.txttennhanvien = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GP_Form_CapNhat = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtkhuvuc = New System.Windows.Forms.TextBox()
        Me.BtnExit_CapNhat = New System.Windows.Forms.Button()
        Me.txtsophieu = New System.Windows.Forms.TextBox()
        Me.CalendarView1 = New DevComponents.DotNetBar.Schedule.CalendarView()
        Me.Dgv_LichCang = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.contextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.InContentContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.InContentAddAppContextItem = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderShowSideBarContextItem = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderHideSideBarContextItem = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.InHeaderCalColorGreen = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorMaroon = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorSteel = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorTeal = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorBlue = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorPurple = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorOlive = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorRed = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorDarkPeach = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorDarkSteel = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorDarkGreen = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorYellow = New DevComponents.DotNetBar.ButtonItem()
        Me.InHeaderCalColorAutomatic = New DevComponents.DotNetBar.ButtonItem()
        Me.InSideBarContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.InSideBarHideContextItem = New DevComponents.DotNetBar.ButtonItem()
        Me.AppointmentContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem4 = New DevComponents.DotNetBar.LabelItem()
        Me.AppMarkerDefault = New DevComponents.DotNetBar.ButtonItem()
        Me.AppMarkerBusy = New DevComponents.DotNetBar.ButtonItem()
        Me.AppMarkerFree = New DevComponents.DotNetBar.ButtonItem()
        Me.AllDayPanelContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.AllDayShrinkContextItem = New DevComponents.DotNetBar.ButtonItem()
        Me.AllDayGrowContextItem = New DevComponents.DotNetBar.ButtonItem()
        Me.AllDayReset = New DevComponents.DotNetBar.ButtonItem()
        Me.TimeRulerPanelContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem5 = New DevComponents.DotNetBar.LabelItem()
        Me.TimeDuration30 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem15 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem16 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem22 = New DevComponents.DotNetBar.ButtonItem()
        Me.PeriodHeaderContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.lblPeriodHeader = New DevComponents.DotNetBar.LabelItem()
        Me.InPeriodHeaderHide = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem6 = New DevComponents.DotNetBar.LabelItem()
        Me.btnPeriodMinutes = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPeriodHours = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPeriodDays = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPeriodYears = New DevComponents.DotNetBar.ButtonItem()
        Me.IntervalHeaderContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.lblPeriodHeader2 = New DevComponents.DotNetBar.LabelItem()
        Me.btnIntervalHeaderShow = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem7 = New DevComponents.DotNetBar.LabelItem()
        Me.CondensedViewContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem8 = New DevComponents.DotNetBar.LabelItem()
        Me.btnCondensedViewAll = New DevComponents.DotNetBar.ButtonItem()
        Me.btnCondensedViewSelected = New DevComponents.DotNetBar.ButtonItem()
        Me.btnCondensedViewHidden = New DevComponents.DotNetBar.ButtonItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GP_Form_CapNhat.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.Dgv_LichCang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXacNhan_GioRa
        '
        Me.btnXacNhan_GioRa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXacNhan_GioRa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXacNhan_GioRa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXacNhan_GioRa.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhan_GioRa.Location = New System.Drawing.Point(691, 55)
        Me.btnXacNhan_GioRa.Name = "btnXacNhan_GioRa"
        Me.btnXacNhan_GioRa.Size = New System.Drawing.Size(205, 46)
        Me.btnXacNhan_GioRa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXacNhan_GioRa.Symbol = ""
        Me.btnXacNhan_GioRa.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnXacNhan_GioRa.TabIndex = 419
        Me.btnXacNhan_GioRa.Text = "F4 - GIỜ RA"
        Me.btnXacNhan_GioRa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnXacNhan_GioVao
        '
        Me.btnXacNhan_GioVao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXacNhan_GioVao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXacNhan_GioVao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXacNhan_GioVao.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhan_GioVao.Location = New System.Drawing.Point(691, 3)
        Me.btnXacNhan_GioVao.Name = "btnXacNhan_GioVao"
        Me.btnXacNhan_GioVao.Size = New System.Drawing.Size(205, 46)
        Me.btnXacNhan_GioVao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXacNhan_GioVao.Symbol = ""
        Me.btnXacNhan_GioVao.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnXacNhan_GioVao.TabIndex = 478
        Me.btnXacNhan_GioVao.Text = "F3 - GIỜ VÀO"
        Me.btnXacNhan_GioVao.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dt1_F, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnFind, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dt2_F, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1320, 49)
        Me.TableLayoutPanel1.TabIndex = 480
        '
        'dt1_F
        '
        Me.dt1_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt1_F.AutoSelectDate = True
        '
        '
        '
        Me.dt1_F.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt1_F.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt1_F.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dt1_F.ButtonDropDown.Visible = True
        Me.dt1_F.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector
        Me.dt1_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1_F.IsPopupCalendarOpen = False
        Me.dt1_F.Location = New System.Drawing.Point(2, 7)
        Me.dt1_F.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        '
        '
        '
        '
        '
        '
        Me.dt1_F.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt1_F.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dt1_F.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt1_F.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt1_F.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt1_F.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt1_F.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt1_F.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt1_F.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt1_F.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt1_F.MonthCalendar.DisplayMonth = New Date(2014, 11, 1, 0, 0, 0, 0)
        Me.dt1_F.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dt1_F.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt1_F.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt1_F.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt1_F.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt1_F.MonthCalendar.TodayButtonVisible = True
        Me.dt1_F.Name = "dt1_F"
        Me.dt1_F.ShowUpDown = True
        Me.dt1_F.Size = New System.Drawing.Size(195, 26)
        Me.dt1_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt1_F.TabIndex = 484
        Me.dt1_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt1_F.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.dt1_F.WatermarkText = "Từ ngày"
        '
        'btnFind
        '
        Me.btnFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFind.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFind.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnFind.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(448, 3)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btnFind.Size = New System.Drawing.Size(184, 34)
        Me.btnFind.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnFind.TabIndex = 488
        '
        'dt2_F
        '
        Me.dt2_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt2_F.AutoSelectDate = True
        '
        '
        '
        Me.dt2_F.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dt2_F.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt2_F.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dt2_F.ButtonDropDown.Visible = True
        Me.dt2_F.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector
        Me.dt2_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2_F.IsPopupCalendarOpen = False
        Me.dt2_F.Location = New System.Drawing.Point(201, 7)
        Me.dt2_F.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        '
        '
        '
        '
        '
        '
        Me.dt2_F.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt2_F.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dt2_F.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dt2_F.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dt2_F.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dt2_F.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dt2_F.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dt2_F.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dt2_F.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dt2_F.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt2_F.MonthCalendar.DisplayMonth = New Date(2014, 11, 1, 0, 0, 0, 0)
        Me.dt2_F.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dt2_F.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dt2_F.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dt2_F.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dt2_F.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dt2_F.MonthCalendar.TodayButtonVisible = True
        Me.dt2_F.Name = "dt2_F"
        Me.dt2_F.ShowUpDown = True
        Me.dt2_F.Size = New System.Drawing.Size(234, 26)
        Me.dt2_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt2_F.TabIndex = 485
        Me.dt2_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt2_F.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.dt2_F.WatermarkText = "Đến ngày"
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(88, 9)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(131, 34)
        Me.LabelX6.TabIndex = 452
        Me.LabelX6.Text = "KHU VỰC"
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(11, 61)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(208, 34)
        Me.LabelX1.TabIndex = 453
        Me.LabelX1.Text = "MÃ NHÂN VIÊN"
        '
        'txtmasonhanvien
        '
        Me.txtmasonhanvien.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmasonhanvien.BackColor = System.Drawing.Color.Yellow
        Me.txtmasonhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmasonhanvien.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmasonhanvien.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmasonhanvien.ForeColor = System.Drawing.Color.Red
        Me.txtmasonhanvien.Location = New System.Drawing.Point(224, 58)
        Me.txtmasonhanvien.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmasonhanvien.Name = "txtmasonhanvien"
        Me.txtmasonhanvien.Size = New System.Drawing.Size(213, 39)
        Me.txtmasonhanvien.TabIndex = 451
        Me.txtmasonhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttennhanvien
        '
        Me.txttennhanvien.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttennhanvien.BackColor = System.Drawing.SystemColors.Control
        Me.txttennhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttennhanvien.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttennhanvien.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttennhanvien.ForeColor = System.Drawing.Color.Red
        Me.txttennhanvien.Location = New System.Drawing.Point(441, 58)
        Me.txttennhanvien.Margin = New System.Windows.Forms.Padding(2)
        Me.txttennhanvien.Name = "txttennhanvien"
        Me.txttennhanvien.Size = New System.Drawing.Size(245, 39)
        Me.txttennhanvien.TabIndex = 452
        Me.txttennhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GP_Form_CapNhat)
        Me.Panel1.Controls.Add(Me.CalendarView1)
        Me.Panel1.Controls.Add(Me.Dgv_LichCang)
        Me.Panel1.Controls.Add(Me.contextMenuBar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1320, 669)
        Me.Panel1.TabIndex = 481
        '
        'GP_Form_CapNhat
        '
        Me.GP_Form_CapNhat.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form_CapNhat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form_CapNhat.Controls.Add(Me.TableLayoutPanel3)
        Me.GP_Form_CapNhat.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form_CapNhat.Location = New System.Drawing.Point(323, 44)
        Me.GP_Form_CapNhat.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form_CapNhat.Name = "GP_Form_CapNhat"
        Me.GP_Form_CapNhat.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form_CapNhat.Size = New System.Drawing.Size(941, 466)
        '
        '
        '
        Me.GP_Form_CapNhat.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form_CapNhat.Style.BackColorGradientAngle = 90
        Me.GP_Form_CapNhat.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form_CapNhat.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_CapNhat.Style.BorderBottomWidth = 1
        Me.GP_Form_CapNhat.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form_CapNhat.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_CapNhat.Style.BorderLeftWidth = 1
        Me.GP_Form_CapNhat.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_CapNhat.Style.BorderRightWidth = 1
        Me.GP_Form_CapNhat.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_CapNhat.Style.BorderTopWidth = 1
        Me.GP_Form_CapNhat.Style.CornerDiameter = 4
        Me.GP_Form_CapNhat.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form_CapNhat.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form_CapNhat.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form_CapNhat.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form_CapNhat.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form_CapNhat.TabIndex = 451
        Me.GP_Form_CapNhat.Text = "Cập Nhật Dữ Liệu"
        Me.GP_Form_CapNhat.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form_CapNhat.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtkhuvuc, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtmasonhanvien, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelX1, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelX6, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txttennhanvien, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnXacNhan_GioVao, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnXacNhan_GioRa, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnExit_CapNhat, 4, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtsophieu, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(911, 440)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'txtkhuvuc
        '
        Me.txtkhuvuc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkhuvuc.BackColor = System.Drawing.SystemColors.Control
        Me.txtkhuvuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkhuvuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtkhuvuc.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhuvuc.ForeColor = System.Drawing.Color.Red
        Me.txtkhuvuc.Location = New System.Drawing.Point(224, 6)
        Me.txtkhuvuc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkhuvuc.Name = "txtkhuvuc"
        Me.txtkhuvuc.Size = New System.Drawing.Size(213, 39)
        Me.txtkhuvuc.TabIndex = 453
        Me.txtkhuvuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnExit_CapNhat
        '
        Me.BtnExit_CapNhat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit_CapNhat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit_CapNhat.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnExit_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit_CapNhat.Location = New System.Drawing.Point(693, 109)
        Me.BtnExit_CapNhat.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnExit_CapNhat.Name = "BtnExit_CapNhat"
        Me.BtnExit_CapNhat.Size = New System.Drawing.Size(201, 44)
        Me.BtnExit_CapNhat.TabIndex = 9
        Me.BtnExit_CapNhat.Text = "Thoát"
        Me.BtnExit_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit_CapNhat.UseVisualStyleBackColor = True
        '
        'txtsophieu
        '
        Me.txtsophieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsophieu.BackColor = System.Drawing.SystemColors.Control
        Me.txtsophieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsophieu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsophieu.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsophieu.ForeColor = System.Drawing.Color.Red
        Me.txtsophieu.Location = New System.Drawing.Point(441, 6)
        Me.txtsophieu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsophieu.Name = "txtsophieu"
        Me.txtsophieu.Size = New System.Drawing.Size(245, 39)
        Me.txtsophieu.TabIndex = 453
        Me.txtsophieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CalendarView1
        '
        Me.CalendarView1.AllDayDisplayMode = DevComponents.DotNetBar.Schedule.eAllDayDisplayMode.ByDayPeriod
        Me.CalendarView1.AppointmentBorderWidth = 2
        Me.CalendarView1.AutoScroll = True
        Me.CalendarView1.AutoScrollMinSize = New System.Drawing.Size(26880, 102)
        Me.CalendarView1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CalendarView1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CalendarView1.ContainerControlProcessDialogKey = True
        Me.CalendarView1.FixedAllDayPanelHeight = 100
        Me.CalendarView1.ForeColor = System.Drawing.SystemColors.Control
        Me.CalendarView1.HighlightCurrentDay = True
        Me.CalendarView1.Is24HourFormat = True
        Me.CalendarView1.IsTimeRulerVisible = False
        Me.CalendarView1.LabelTimeSlots = True
        Me.CalendarView1.Location = New System.Drawing.Point(11, 174)
        Me.CalendarView1.MaximumAllDayPanelHeight = 100
        Me.CalendarView1.MinimumTimeSlotHeight = 50
        Me.CalendarView1.MultiUserTabHeight = 100
        Me.CalendarView1.Name = "CalendarView1"
        Me.CalendarView1.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.TimeLine
        Me.CalendarView1.ShowToolTips = False
        Me.CalendarView1.Size = New System.Drawing.Size(257, 139)
        Me.CalendarView1.TabIndex = 452
        Me.CalendarView1.Text = "CalendarView1"
        Me.CalendarView1.TimeIndicator.BorderColor = System.Drawing.Color.Red
        Me.CalendarView1.TimeIndicator.IndicatorArea = DevComponents.DotNetBar.Schedule.eTimeIndicatorArea.All
        Me.CalendarView1.TimeIndicator.Tag = Nothing
        Me.CalendarView1.TimeIndicator.Visibility = DevComponents.DotNetBar.Schedule.eTimeIndicatorVisibility.AllResources
        Me.CalendarView1.TimeSlotDuration = 30
        '
        'Dgv_LichCang
        '
        Me.Dgv_LichCang.AllowUserToAddRows = False
        Me.Dgv_LichCang.AllowUserToDeleteRows = False
        Me.Dgv_LichCang.AllowUserToResizeRows = False
        Me.Dgv_LichCang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_LichCang.DefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_LichCang.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Dgv_LichCang.Location = New System.Drawing.Point(43, 337)
        Me.Dgv_LichCang.Name = "Dgv_LichCang"
        Me.Dgv_LichCang.RowTemplate.Height = 24
        Me.Dgv_LichCang.Size = New System.Drawing.Size(79, 89)
        Me.Dgv_LichCang.TabIndex = 10
        '
        'contextMenuBar1
        '
        Me.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.contextMenuBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contextMenuBar1.IsMaximized = False
        Me.contextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.InContentContextMenu, Me.InHeaderContextMenu, Me.InSideBarContextMenu, Me.AppointmentContextMenu, Me.AllDayPanelContextMenu, Me.TimeRulerPanelContextMenu, Me.PeriodHeaderContextMenu, Me.IntervalHeaderContextMenu, Me.CondensedViewContextMenu})
        Me.contextMenuBar1.Location = New System.Drawing.Point(5, 26)
        Me.contextMenuBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.contextMenuBar1.Name = "contextMenuBar1"
        Me.contextMenuBar1.Size = New System.Drawing.Size(215, 113)
        Me.contextMenuBar1.Stretch = True
        Me.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.contextMenuBar1.TabIndex = 8
        Me.contextMenuBar1.TabStop = False
        Me.contextMenuBar1.Text = "contextMenuBar1"
        '
        'InContentContextMenu
        '
        Me.InContentContextMenu.AutoExpandOnClick = True
        Me.InContentContextMenu.Name = "InContentContextMenu"
        Me.InContentContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.InContentAddAppContextItem})
        Me.InContentContextMenu.Text = "InContent"
        '
        'InContentAddAppContextItem
        '
        Me.InContentAddAppContextItem.Name = "InContentAddAppContextItem"
        Me.InContentAddAppContextItem.Text = "Thêm Nhân Viên Vào Khu Vực"
        '
        'InHeaderContextMenu
        '
        Me.InHeaderContextMenu.AutoExpandOnClick = True
        Me.InHeaderContextMenu.Name = "InHeaderContextMenu"
        Me.InHeaderContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.InHeaderShowSideBarContextItem, Me.InHeaderHideSideBarContextItem, Me.labelItem2, Me.InHeaderCalColorGreen, Me.InHeaderCalColorMaroon, Me.InHeaderCalColorSteel, Me.InHeaderCalColorTeal, Me.InHeaderCalColorBlue, Me.InHeaderCalColorPurple, Me.InHeaderCalColorOlive, Me.InHeaderCalColorRed, Me.InHeaderCalColorDarkPeach, Me.InHeaderCalColorDarkSteel, Me.InHeaderCalColorDarkGreen, Me.InHeaderCalColorYellow, Me.InHeaderCalColorAutomatic})
        Me.InHeaderContextMenu.Text = "InHeader"
        '
        'InHeaderShowSideBarContextItem
        '
        Me.InHeaderShowSideBarContextItem.Name = "InHeaderShowSideBarContextItem"
        Me.InHeaderShowSideBarContextItem.Text = "Show SideBar"
        '
        'InHeaderHideSideBarContextItem
        '
        Me.InHeaderHideSideBarContextItem.Name = "InHeaderHideSideBarContextItem"
        Me.InHeaderHideSideBarContextItem.Text = "Hide SideBar"
        '
        'labelItem2
        '
        Me.labelItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.labelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.labelItem2.Name = "labelItem2"
        Me.labelItem2.PaddingBottom = 1
        Me.labelItem2.PaddingLeft = 10
        Me.labelItem2.PaddingTop = 1
        Me.labelItem2.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.labelItem2.Text = "Calendar Color"
        '
        'InHeaderCalColorGreen
        '
        Me.InHeaderCalColorGreen.Name = "InHeaderCalColorGreen"
        Me.InHeaderCalColorGreen.Text = "Green"
        '
        'InHeaderCalColorMaroon
        '
        Me.InHeaderCalColorMaroon.Name = "InHeaderCalColorMaroon"
        Me.InHeaderCalColorMaroon.Text = "Maroon"
        '
        'InHeaderCalColorSteel
        '
        Me.InHeaderCalColorSteel.Name = "InHeaderCalColorSteel"
        Me.InHeaderCalColorSteel.Text = "Steel"
        '
        'InHeaderCalColorTeal
        '
        Me.InHeaderCalColorTeal.Name = "InHeaderCalColorTeal"
        Me.InHeaderCalColorTeal.Text = "Teal"
        '
        'InHeaderCalColorBlue
        '
        Me.InHeaderCalColorBlue.Name = "InHeaderCalColorBlue"
        Me.InHeaderCalColorBlue.Text = "Blue"
        '
        'InHeaderCalColorPurple
        '
        Me.InHeaderCalColorPurple.Name = "InHeaderCalColorPurple"
        Me.InHeaderCalColorPurple.Text = "Purple"
        '
        'InHeaderCalColorOlive
        '
        Me.InHeaderCalColorOlive.Name = "InHeaderCalColorOlive"
        Me.InHeaderCalColorOlive.Text = "Olive"
        '
        'InHeaderCalColorRed
        '
        Me.InHeaderCalColorRed.Name = "InHeaderCalColorRed"
        Me.InHeaderCalColorRed.Text = "Red"
        '
        'InHeaderCalColorDarkPeach
        '
        Me.InHeaderCalColorDarkPeach.Name = "InHeaderCalColorDarkPeach"
        Me.InHeaderCalColorDarkPeach.Text = "DarkPeach"
        '
        'InHeaderCalColorDarkSteel
        '
        Me.InHeaderCalColorDarkSteel.Name = "InHeaderCalColorDarkSteel"
        Me.InHeaderCalColorDarkSteel.Text = "DarkSteel"
        '
        'InHeaderCalColorDarkGreen
        '
        Me.InHeaderCalColorDarkGreen.Name = "InHeaderCalColorDarkGreen"
        Me.InHeaderCalColorDarkGreen.Text = "DarkGreen"
        '
        'InHeaderCalColorYellow
        '
        Me.InHeaderCalColorYellow.Name = "InHeaderCalColorYellow"
        Me.InHeaderCalColorYellow.Text = "Yellow"
        '
        'InHeaderCalColorAutomatic
        '
        Me.InHeaderCalColorAutomatic.Name = "InHeaderCalColorAutomatic"
        Me.InHeaderCalColorAutomatic.Text = "Automatic"
        '
        'InSideBarContextMenu
        '
        Me.InSideBarContextMenu.AutoExpandOnClick = True
        Me.InSideBarContextMenu.Name = "InSideBarContextMenu"
        Me.InSideBarContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.InSideBarHideContextItem})
        Me.InSideBarContextMenu.Text = "InSideBar"
        '
        'InSideBarHideContextItem
        '
        Me.InSideBarHideContextItem.Name = "InSideBarHideContextItem"
        Me.InSideBarHideContextItem.Text = "Hide SideBar"
        '
        'AppointmentContextMenu
        '
        Me.AppointmentContextMenu.AutoExpandOnClick = True
        Me.AppointmentContextMenu.Name = "AppointmentContextMenu"
        Me.AppointmentContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem4, Me.AppMarkerDefault, Me.AppMarkerBusy, Me.AppMarkerFree})
        Me.AppointmentContextMenu.Text = "Appointment"
        '
        'labelItem4
        '
        Me.labelItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.labelItem4.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem4.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.labelItem4.Name = "labelItem4"
        Me.labelItem4.PaddingBottom = 1
        Me.labelItem4.PaddingLeft = 10
        Me.labelItem4.PaddingTop = 1
        Me.labelItem4.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.labelItem4.Text = "Tính Năng"
        '
        'AppMarkerDefault
        '
        Me.AppMarkerDefault.Name = "AppMarkerDefault"
        Me.AppMarkerDefault.Text = "Hủy Giờ Vào"
        '
        'AppMarkerBusy
        '
        Me.AppMarkerBusy.Name = "AppMarkerBusy"
        Me.AppMarkerBusy.Text = "Hủy Giờ Ra"
        '
        'AppMarkerFree
        '
        Me.AppMarkerFree.Name = "AppMarkerFree"
        Me.AppMarkerFree.Text = "Kết Thúc"
        '
        'AllDayPanelContextMenu
        '
        Me.AllDayPanelContextMenu.AutoExpandOnClick = True
        Me.AllDayPanelContextMenu.Name = "AllDayPanelContextMenu"
        Me.AllDayPanelContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.AllDayShrinkContextItem, Me.AllDayGrowContextItem, Me.AllDayReset})
        Me.AllDayPanelContextMenu.Text = "AllDayPanel"
        '
        'AllDayShrinkContextItem
        '
        Me.AllDayShrinkContextItem.Name = "AllDayShrinkContextItem"
        Me.AllDayShrinkContextItem.Text = "Shrink Panel"
        '
        'AllDayGrowContextItem
        '
        Me.AllDayGrowContextItem.Name = "AllDayGrowContextItem"
        Me.AllDayGrowContextItem.Text = "Grow Panel"
        '
        'AllDayReset
        '
        Me.AllDayReset.BeginGroup = True
        Me.AllDayReset.Name = "AllDayReset"
        Me.AllDayReset.Text = "Reset"
        '
        'TimeRulerPanelContextMenu
        '
        Me.TimeRulerPanelContextMenu.AutoExpandOnClick = True
        Me.TimeRulerPanelContextMenu.Name = "TimeRulerPanelContextMenu"
        Me.TimeRulerPanelContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem5, Me.TimeDuration30, Me.buttonItem6, Me.buttonItem7, Me.buttonItem8, Me.buttonItem9, Me.buttonItem11, Me.buttonItem12, Me.buttonItem13, Me.buttonItem15, Me.buttonItem16, Me.buttonItem22})
        Me.TimeRulerPanelContextMenu.Text = "InTimeRulerPanel"
        '
        'labelItem5
        '
        Me.labelItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.labelItem5.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem5.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.labelItem5.Name = "labelItem5"
        Me.labelItem5.PaddingBottom = 1
        Me.labelItem5.PaddingLeft = 10
        Me.labelItem5.PaddingTop = 1
        Me.labelItem5.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.labelItem5.Text = "TimeSlot Duration"
        '
        'TimeDuration30
        '
        Me.TimeDuration30.Name = "TimeDuration30"
        Me.TimeDuration30.Text = "30"
        '
        'buttonItem6
        '
        Me.buttonItem6.Name = "buttonItem6"
        Me.buttonItem6.Text = "20"
        '
        'buttonItem7
        '
        Me.buttonItem7.Name = "buttonItem7"
        Me.buttonItem7.Text = "15"
        '
        'buttonItem8
        '
        Me.buttonItem8.Name = "buttonItem8"
        Me.buttonItem8.Text = "12"
        '
        'buttonItem9
        '
        Me.buttonItem9.Name = "buttonItem9"
        Me.buttonItem9.Text = "10"
        '
        'buttonItem11
        '
        Me.buttonItem11.Name = "buttonItem11"
        Me.buttonItem11.Text = "6"
        '
        'buttonItem12
        '
        Me.buttonItem12.Name = "buttonItem12"
        Me.buttonItem12.Text = "5"
        '
        'buttonItem13
        '
        Me.buttonItem13.Name = "buttonItem13"
        Me.buttonItem13.Text = "4"
        '
        'buttonItem15
        '
        Me.buttonItem15.Name = "buttonItem15"
        Me.buttonItem15.Text = "3"
        '
        'buttonItem16
        '
        Me.buttonItem16.Name = "buttonItem16"
        Me.buttonItem16.Text = "2"
        '
        'buttonItem22
        '
        Me.buttonItem22.Name = "buttonItem22"
        Me.buttonItem22.Text = "1"
        '
        'PeriodHeaderContextMenu
        '
        Me.PeriodHeaderContextMenu.AutoExpandOnClick = True
        Me.PeriodHeaderContextMenu.Name = "PeriodHeaderContextMenu"
        Me.PeriodHeaderContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lblPeriodHeader, Me.InPeriodHeaderHide, Me.labelItem6, Me.btnPeriodMinutes, Me.btnPeriodHours, Me.btnPeriodDays, Me.btnPeriodYears})
        Me.PeriodHeaderContextMenu.Text = "InPeriodHeader"
        '
        'lblPeriodHeader
        '
        Me.lblPeriodHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lblPeriodHeader.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.lblPeriodHeader.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblPeriodHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblPeriodHeader.Name = "lblPeriodHeader"
        Me.lblPeriodHeader.PaddingBottom = 1
        Me.lblPeriodHeader.PaddingLeft = 10
        Me.lblPeriodHeader.PaddingTop = 1
        Me.lblPeriodHeader.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblPeriodHeader.Text = "Period Header"
        '
        'InPeriodHeaderHide
        '
        Me.InPeriodHeaderHide.Name = "InPeriodHeaderHide"
        Me.InPeriodHeaderHide.Text = "Hide Header"
        '
        'labelItem6
        '
        Me.labelItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.labelItem6.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem6.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.labelItem6.Name = "labelItem6"
        Me.labelItem6.PaddingBottom = 1
        Me.labelItem6.PaddingLeft = 10
        Me.labelItem6.PaddingTop = 1
        Me.labelItem6.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.labelItem6.Text = "Period Interval"
        '
        'btnPeriodMinutes
        '
        Me.btnPeriodMinutes.Checked = True
        Me.btnPeriodMinutes.Name = "btnPeriodMinutes"
        Me.btnPeriodMinutes.OptionGroup = "IntervalPeriod"
        Me.btnPeriodMinutes.Text = "Minutes"
        '
        'btnPeriodHours
        '
        Me.btnPeriodHours.Name = "btnPeriodHours"
        Me.btnPeriodHours.OptionGroup = "IntervalPeriod"
        Me.btnPeriodHours.Text = "Hours"
        '
        'btnPeriodDays
        '
        Me.btnPeriodDays.Name = "btnPeriodDays"
        Me.btnPeriodDays.OptionGroup = "IntervalPeriod"
        Me.btnPeriodDays.Text = "Days"
        '
        'btnPeriodYears
        '
        Me.btnPeriodYears.Name = "btnPeriodYears"
        Me.btnPeriodYears.OptionGroup = "IntervalPeriod"
        Me.btnPeriodYears.Text = "Years"
        '
        'IntervalHeaderContextMenu
        '
        Me.IntervalHeaderContextMenu.AutoExpandOnClick = True
        Me.IntervalHeaderContextMenu.Name = "IntervalHeaderContextMenu"
        Me.IntervalHeaderContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.lblPeriodHeader2, Me.btnIntervalHeaderShow, Me.labelItem7})
        Me.IntervalHeaderContextMenu.Text = "InIntervalHeader"
        '
        'lblPeriodHeader2
        '
        Me.lblPeriodHeader2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lblPeriodHeader2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.lblPeriodHeader2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblPeriodHeader2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblPeriodHeader2.Name = "lblPeriodHeader2"
        Me.lblPeriodHeader2.PaddingBottom = 1
        Me.lblPeriodHeader2.PaddingLeft = 10
        Me.lblPeriodHeader2.PaddingTop = 1
        Me.lblPeriodHeader2.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblPeriodHeader2.Text = "Period Header"
        '
        'btnIntervalHeaderShow
        '
        Me.btnIntervalHeaderShow.Name = "btnIntervalHeaderShow"
        Me.btnIntervalHeaderShow.Text = "Show Header"
        '
        'labelItem7
        '
        Me.labelItem7.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.labelItem7.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem7.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.labelItem7.Name = "labelItem7"
        Me.labelItem7.PaddingBottom = 1
        Me.labelItem7.PaddingLeft = 10
        Me.labelItem7.PaddingTop = 1
        Me.labelItem7.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.labelItem7.Text = "Interval Time"
        '
        'CondensedViewContextMenu
        '
        Me.CondensedViewContextMenu.AutoExpandOnClick = True
        Me.CondensedViewContextMenu.Name = "CondensedViewContextMenu"
        Me.CondensedViewContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem8, Me.btnCondensedViewAll, Me.btnCondensedViewSelected, Me.btnCondensedViewHidden})
        Me.CondensedViewContextMenu.Text = "InCondensedView"
        '
        'labelItem8
        '
        Me.labelItem8.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.labelItem8.Name = "labelItem8"
        Me.labelItem8.PaddingBottom = 1
        Me.labelItem8.PaddingLeft = 10
        Me.labelItem8.PaddingTop = 1
        Me.labelItem8.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.labelItem8.Text = "Visibility"
        '
        'btnCondensedViewAll
        '
        Me.btnCondensedViewAll.Name = "btnCondensedViewAll"
        Me.btnCondensedViewAll.Text = "All"
        '
        'btnCondensedViewSelected
        '
        Me.btnCondensedViewSelected.Name = "btnCondensedViewSelected"
        Me.btnCondensedViewSelected.Text = "Selected"
        '
        'btnCondensedViewHidden
        '
        Me.btnCondensedViewHidden.Name = "btnCondensedViewHidden"
        Me.btnCondensedViewHidden.Text = "Hidden"
        '
        'FrmXacNhanGioLam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1320, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmXacNhanGioLam"
        Me.Text = "KẾ HOẠCH PHÂN BỐ NHÂN SỰ"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GP_Form_CapNhat.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.Dgv_LichCang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnXacNhan_GioRa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnXacNhan_GioVao As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Private WithEvents contextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Private WithEvents InContentContextMenu As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InContentAddAppContextItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderContextMenu As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderShowSideBarContextItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderHideSideBarContextItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents labelItem2 As DevComponents.DotNetBar.LabelItem
    Private WithEvents InHeaderCalColorGreen As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorMaroon As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorSteel As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorTeal As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorBlue As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorPurple As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorOlive As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorRed As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorDarkPeach As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorDarkSteel As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorDarkGreen As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorYellow As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InHeaderCalColorAutomatic As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InSideBarContextMenu As DevComponents.DotNetBar.ButtonItem
    Private WithEvents InSideBarHideContextItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents AppointmentContextMenu As DevComponents.DotNetBar.ButtonItem
    Private WithEvents labelItem4 As DevComponents.DotNetBar.LabelItem
    Private WithEvents AppMarkerDefault As DevComponents.DotNetBar.ButtonItem
    Private WithEvents AppMarkerBusy As DevComponents.DotNetBar.ButtonItem
    Private WithEvents AppMarkerFree As DevComponents.DotNetBar.ButtonItem
    Private WithEvents AllDayPanelContextMenu As DevComponents.DotNetBar.ButtonItem
    Private WithEvents AllDayShrinkContextItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents AllDayGrowContextItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents AllDayReset As DevComponents.DotNetBar.ButtonItem
    Private WithEvents TimeRulerPanelContextMenu As DevComponents.DotNetBar.ButtonItem
    Private WithEvents labelItem5 As DevComponents.DotNetBar.LabelItem
    Private WithEvents TimeDuration30 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem6 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem7 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem8 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem9 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem11 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem12 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem13 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem15 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem16 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem22 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents PeriodHeaderContextMenu As DevComponents.DotNetBar.ButtonItem
    Private WithEvents lblPeriodHeader As DevComponents.DotNetBar.LabelItem
    Private WithEvents InPeriodHeaderHide As DevComponents.DotNetBar.ButtonItem
    Private WithEvents labelItem6 As DevComponents.DotNetBar.LabelItem
    Private WithEvents btnPeriodMinutes As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnPeriodHours As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnPeriodDays As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnPeriodYears As DevComponents.DotNetBar.ButtonItem
    Private WithEvents IntervalHeaderContextMenu As DevComponents.DotNetBar.ButtonItem
    Private WithEvents lblPeriodHeader2 As DevComponents.DotNetBar.LabelItem
    Private WithEvents btnIntervalHeaderShow As DevComponents.DotNetBar.ButtonItem
    Private WithEvents labelItem7 As DevComponents.DotNetBar.LabelItem
    Private WithEvents CondensedViewContextMenu As DevComponents.DotNetBar.ButtonItem
    Private WithEvents labelItem8 As DevComponents.DotNetBar.LabelItem
    Private WithEvents btnCondensedViewAll As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnCondensedViewSelected As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnCondensedViewHidden As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnFind As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dt1_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dt2_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Dgv_LichCang As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtmasonhanvien As TextBox
    Friend WithEvents txttennhanvien As TextBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GP_Form_CapNhat As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnExit_CapNhat As Button
    Friend WithEvents txtkhuvuc As TextBox
    Friend WithEvents txtsophieu As TextBox
    Friend WithEvents CalendarView1 As DevComponents.DotNetBar.Schedule.CalendarView
    Friend WithEvents Timer1 As Timer
End Class
