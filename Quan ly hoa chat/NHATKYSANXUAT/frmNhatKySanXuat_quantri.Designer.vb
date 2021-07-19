<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNhatKySanXuat_quantri
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
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhatKySanXuat_quantri))
        Me.txttongkg_chung = New System.Windows.Forms.TextBox()
        Me.txttongcay_chung = New System.Windows.Forms.TextBox()
        Me.btnSelect_Day = New DevComponents.DotNetBar.ButtonX()
        Me.dt2_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dt1_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtkhachhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtloaihang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmame_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmamau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmahang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdonhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.btExcel_chung = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.CtxFunction = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_delete = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Export_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Expand = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Colapse = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSave_ColumnFrozen = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMnu_Select = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMnu_Select_ALL = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMnuSelect_Remove = New DevComponents.DotNetBar.ButtonItem()
        Me.ToolStrip_List_QLSX = New System.Windows.Forms.ToolStrip()
        Me.cmdRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInLenh_SX = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRow = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton_CapNhat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_ApThietBi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_HuyCongDoan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_XacNhanHoanThanh = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkMeChuaSanXuat = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboTencongdoan = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip_List_QLSX.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txttongkg_chung
        '
        Me.txttongkg_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttongkg_chung.BackColor = System.Drawing.Color.AliceBlue
        Me.txttongkg_chung.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txttongkg_chung.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txttongkg_chung.Location = New System.Drawing.Point(140, 6)
        Me.txttongkg_chung.Margin = New System.Windows.Forms.Padding(4)
        Me.txttongkg_chung.Name = "txttongkg_chung"
        Me.txttongkg_chung.ReadOnly = True
        Me.txttongkg_chung.Size = New System.Drawing.Size(122, 29)
        Me.txttongkg_chung.TabIndex = 203
        Me.txttongkg_chung.Text = "0"
        Me.txttongkg_chung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttongcay_chung
        '
        Me.txttongcay_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttongcay_chung.BackColor = System.Drawing.Color.AliceBlue
        Me.txttongcay_chung.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txttongcay_chung.ForeColor = System.Drawing.Color.SeaGreen
        Me.txttongcay_chung.Location = New System.Drawing.Point(9, 6)
        Me.txttongcay_chung.Margin = New System.Windows.Forms.Padding(4)
        Me.txttongcay_chung.Name = "txttongcay_chung"
        Me.txttongcay_chung.ReadOnly = True
        Me.txttongcay_chung.Size = New System.Drawing.Size(122, 29)
        Me.txttongcay_chung.TabIndex = 202
        Me.txttongcay_chung.Text = "0"
        Me.txttongcay_chung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSelect_Day
        '
        Me.btnSelect_Day.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSelect_Day.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect_Day.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSelect_Day.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.btnSelect_Day.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnSelect_Day.Location = New System.Drawing.Point(138, 2)
        Me.btnSelect_Day.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelect_Day.Name = "btnSelect_Day"
        Me.btnSelect_Day.PopupSide = DevComponents.DotNetBar.ePopupSide.Right
        Me.TableLayoutPanel1.SetRowSpan(Me.btnSelect_Day, 2)
        Me.btnSelect_Day.Size = New System.Drawing.Size(41, 66)
        Me.btnSelect_Day.SplitButton = True
        Me.btnSelect_Day.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.btnSelect_Day.TabIndex = 405
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
        Me.dt2_F.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2_F.IsPopupCalendarOpen = False
        Me.dt2_F.Location = New System.Drawing.Point(2, 38)
        Me.dt2_F.Margin = New System.Windows.Forms.Padding(2)
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
        Me.dt2_F.Size = New System.Drawing.Size(132, 28)
        Me.dt2_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt2_F.TabIndex = 404
        Me.dt2_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt2_F.WatermarkText = "Đến ngày"
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
        Me.dt1_F.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1_F.IsPopupCalendarOpen = False
        Me.dt1_F.Location = New System.Drawing.Point(2, 3)
        Me.dt1_F.Margin = New System.Windows.Forms.Padding(2)
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
        Me.dt1_F.Size = New System.Drawing.Size(132, 28)
        Me.dt1_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt1_F.TabIndex = 403
        Me.dt1_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt1_F.WatermarkText = "Từ ngày"
        '
        'txtkhachhang_F
        '
        Me.txtkhachhang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtkhachhang_F.Border.Class = "TextBoxBorder"
        Me.txtkhachhang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtkhachhang_F.DisabledBackColor = System.Drawing.Color.White
        Me.txtkhachhang_F.FocusHighlightEnabled = True
        Me.txtkhachhang_F.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.Location = New System.Drawing.Point(183, 3)
        Me.txtkhachhang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkhachhang_F.Name = "txtkhachhang_F"
        Me.txtkhachhang_F.Size = New System.Drawing.Size(98, 28)
        Me.txtkhachhang_F.TabIndex = 398
        Me.txtkhachhang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtkhachhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.WatermarkText = "Khách hàng"
        '
        'txtloaihang_F
        '
        Me.txtloaihang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtloaihang_F.Border.Class = "TextBoxBorder"
        Me.txtloaihang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtloaihang_F.DisabledBackColor = System.Drawing.Color.White
        Me.txtloaihang_F.FocusHighlightEnabled = True
        Me.txtloaihang_F.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.Location = New System.Drawing.Point(285, 38)
        Me.txtloaihang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtloaihang_F.Name = "txtloaihang_F"
        Me.txtloaihang_F.Size = New System.Drawing.Size(93, 28)
        Me.txtloaihang_F.TabIndex = 397
        Me.txtloaihang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtloaihang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.WatermarkText = "Loại Hàng"
        '
        'txtmame_F
        '
        Me.txtmame_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmame_F.Border.Class = "TextBoxBorder"
        Me.txtmame_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmame_F.DisabledBackColor = System.Drawing.Color.White
        Me.txtmame_F.FocusHighlightEnabled = True
        Me.txtmame_F.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.Location = New System.Drawing.Point(468, 3)
        Me.txtmame_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmame_F.Name = "txtmame_F"
        Me.txtmame_F.Size = New System.Drawing.Size(104, 28)
        Me.txtmame_F.TabIndex = 343
        Me.txtmame_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmame_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.WatermarkText = "Mã Mẻ"
        '
        'txtmamau_F
        '
        Me.txtmamau_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmamau_F.Border.Class = "TextBoxBorder"
        Me.txtmamau_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmamau_F.DisabledBackColor = System.Drawing.Color.White
        Me.txtmamau_F.FocusHighlightEnabled = True
        Me.txtmamau_F.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau_F.Location = New System.Drawing.Point(382, 3)
        Me.txtmamau_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmamau_F.Name = "txtmamau_F"
        Me.txtmamau_F.Size = New System.Drawing.Size(82, 28)
        Me.txtmamau_F.TabIndex = 342
        Me.txtmamau_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmamau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau_F.WatermarkText = "Mã Màu"
        '
        'txtmau_F
        '
        Me.txtmau_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmau_F.Border.Class = "TextBoxBorder"
        Me.txtmau_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmau_F.DisabledBackColor = System.Drawing.Color.White
        Me.txtmau_F.FocusHighlightEnabled = True
        Me.txtmau_F.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmau_F.Location = New System.Drawing.Point(382, 38)
        Me.txtmau_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmau_F.Name = "txtmau_F"
        Me.txtmau_F.Size = New System.Drawing.Size(82, 28)
        Me.txtmau_F.TabIndex = 341
        Me.txtmau_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmau_F.WatermarkText = "Màu"
        '
        'txtmahang_F
        '
        Me.txtmahang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmahang_F.Border.Class = "TextBoxBorder"
        Me.txtmahang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmahang_F.DisabledBackColor = System.Drawing.Color.White
        Me.txtmahang_F.FocusHighlightEnabled = True
        Me.txtmahang_F.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.Location = New System.Drawing.Point(285, 3)
        Me.txtmahang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmahang_F.Name = "txtmahang_F"
        Me.txtmahang_F.Size = New System.Drawing.Size(93, 28)
        Me.txtmahang_F.TabIndex = 340
        Me.txtmahang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmahang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.WatermarkText = "Mã Hàng"
        '
        'txtdonhang_F
        '
        Me.txtdonhang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtdonhang_F.Border.Class = "TextBoxBorder"
        Me.txtdonhang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdonhang_F.DisabledBackColor = System.Drawing.Color.White
        Me.txtdonhang_F.FocusHighlightEnabled = True
        Me.txtdonhang_F.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.Location = New System.Drawing.Point(183, 38)
        Me.txtdonhang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdonhang_F.Name = "txtdonhang_F"
        Me.txtdonhang_F.Size = New System.Drawing.Size(98, 28)
        Me.txtdonhang_F.TabIndex = 338
        Me.txtdonhang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtdonhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.WatermarkText = "Đơn Hàng"
        '
        'CircularProgress1
        '
        Me.CircularProgress1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.CircularProgress1.BackgroundStyle.CornerDiameter = 20
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgress1.Location = New System.Drawing.Point(523, 250)
        Me.CircularProgress1.Margin = New System.Windows.Forms.Padding(2)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(102, 98)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 432
        Me.CircularProgress1.Visible = False
        '
        'Super_Dgv
        '
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Thickness1.Bottom = 1
        Thickness1.Left = 1
        Thickness1.Right = 1
        Thickness1.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.BorderThickness = Thickness1
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.Bottom
        Me.Super_Dgv.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Thickness2.Bottom = 1
        Thickness2.Left = 1
        Thickness2.Right = 1
        Thickness2.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.BorderThickness = Thickness2
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Background1.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Super_Dgv.DefaultVisualStyles.FilterRowStyles.Default.FilterBackground = Background1
        Me.Super_Dgv.DefaultVisualStyles.GridPanelStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.GroupByStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.AllowMultiLine = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Thickness3.Bottom = 1
        Thickness3.Left = 1
        Thickness3.Right = 1
        Thickness3.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.BorderThickness = Thickness3
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.RowHeaderStyle.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.Super_Dgv.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square
        Me.Super_Dgv.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.Location = New System.Drawing.Point(95, 111)
        Me.Super_Dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.Super_Dgv.Name = "Super_Dgv"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        Me.Super_Dgv.PrimaryGrid.AutoExpandSetGroup = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Caption.AllowSelection = False
        Me.Super_Dgv.PrimaryGrid.Caption.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.BottomLeft
        Me.Super_Dgv.PrimaryGrid.Caption.Text = "ĐƠN HÀNG:"
        Me.Super_Dgv.PrimaryGrid.CheckBoxes = True
        Me.Super_Dgv.PrimaryGrid.CheckBoxSize = New System.Drawing.Size(20, 20)
        Me.Super_Dgv.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.RowHeaderText = ""
        BorderColor1.Bottom = System.Drawing.Color.Black
        BorderColor1.Left = System.Drawing.Color.Black
        BorderColor1.Right = System.Drawing.Color.Black
        BorderColor1.Top = System.Drawing.Color.Black
        Me.Super_Dgv.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor1
        Me.Super_Dgv.PrimaryGrid.EnableCellExpressions = True
        Me.Super_Dgv.PrimaryGrid.EnableColumnFiltering = True
        Me.Super_Dgv.PrimaryGrid.EnableFiltering = True
        Me.Super_Dgv.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Filter.RowHeight = 30
        Me.Super_Dgv.PrimaryGrid.FilterExpr = ""
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Footer.Text = ""
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.GroupByRow.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.Copy
        Me.Super_Dgv.PrimaryGrid.GroupByRow.Text = ""
        Me.Super_Dgv.PrimaryGrid.GroupByRow.Visible = True
        Me.Super_Dgv.PrimaryGrid.GroupByRow.WatermarkText = "Kéo cột cần xem vào đây"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Header.Text = ""
        Me.Super_Dgv.PrimaryGrid.Header.Visible = False
        Me.Super_Dgv.PrimaryGrid.MinRowHeight = 30
        Me.Super_Dgv.PrimaryGrid.NoRowsText = ""
        Me.Super_Dgv.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.Super_Dgv.PrimaryGrid.RowHeaderWidth = 45
        Me.Super_Dgv.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.Super_Dgv.PrimaryGrid.Title.Text = ""
        Me.Super_Dgv.Size = New System.Drawing.Size(202, 172)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 415
        '
        'btExcel_chung
        '
        Me.btExcel_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btExcel_chung.Image = CType(resources.GetObject("btExcel_chung.Image"), System.Drawing.Image)
        Me.btExcel_chung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btExcel_chung.Location = New System.Drawing.Point(850, 6)
        Me.btExcel_chung.Margin = New System.Windows.Forms.Padding(4)
        Me.btExcel_chung.Name = "btExcel_chung"
        Me.btExcel_chung.Size = New System.Drawing.Size(138, 35)
        Me.btExcel_chung.TabIndex = 31
        Me.btExcel_chung.Text = "Xuất Excel"
        Me.btExcel_chung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btExcel_chung.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ContextMenuBar1)
        Me.Panel1.Controls.Add(Me.CircularProgress1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1095, 558)
        Me.Panel1.TabIndex = 433
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu, Me.CtxMnu_Select})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(162, 23)
        Me.ContextMenuBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(229, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 417
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'CtxFunction
        '
        Me.CtxFunction.AutoExpandOnClick = True
        Me.CtxFunction.Name = "CtxFunction"
        Me.CtxFunction.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction_delete, Me.CtxFunction_Refresh, Me.LabelItem3, Me.CtxFunction_Export_Excel})
        Me.CtxFunction.Text = "Function"
        '
        'CtxFunction_delete
        '
        Me.CtxFunction_delete.Image = Global.WindowsApplication1.My.Resources.Resources.remove
        Me.CtxFunction_delete.Name = "CtxFunction_delete"
        Me.CtxFunction_delete.Text = "Xóa"
        '
        'CtxFunction_Refresh
        '
        Me.CtxFunction_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.CtxFunction_Refresh.Name = "CtxFunction_Refresh"
        Me.CtxFunction_Refresh.Text = "Làm Mới"
        '
        'LabelItem3
        '
        Me.LabelItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem3.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem3.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.PaddingBottom = 1
        Me.LabelItem3.PaddingLeft = 10
        Me.LabelItem3.PaddingTop = 1
        Me.LabelItem3.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem3.Text = "Xuất Excel"
        '
        'CtxFunction_Export_Excel
        '
        Me.CtxFunction_Export_Excel.Image = Global.WindowsApplication1.My.Resources.Resources.report
        Me.CtxFunction_Export_Excel.Name = "CtxFunction_Export_Excel"
        Me.CtxFunction_Export_Excel.Text = "Xuất Excel"
        '
        'CtxMenu
        '
        Me.CtxMenu.AutoExpandOnClick = True
        Me.CtxMenu.Name = "CtxMenu"
        Me.CtxMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxMenu_Expand, Me.CtxMenu_Colapse, Me.btnSave_ColumnFrozen})
        Me.CtxMenu.Text = "Menu"
        '
        'CtxMenu_Expand
        '
        Me.CtxMenu_Expand.Name = "CtxMenu_Expand"
        Me.CtxMenu_Expand.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlUp)
        Me.CtxMenu_Expand.Text = "Mở Rộng"
        '
        'CtxMenu_Colapse
        '
        Me.CtxMenu_Colapse.Name = "CtxMenu_Colapse"
        Me.CtxMenu_Colapse.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlDown)
        Me.CtxMenu_Colapse.Text = "Thu gọn"
        '
        'btnSave_ColumnFrozen
        '
        Me.btnSave_ColumnFrozen.Name = "btnSave_ColumnFrozen"
        Me.btnSave_ColumnFrozen.Text = "Khóa Cột"
        '
        'CtxMnu_Select
        '
        Me.CtxMnu_Select.AutoExpandOnClick = True
        Me.CtxMnu_Select.Name = "CtxMnu_Select"
        Me.CtxMnu_Select.PopupFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtxMnu_Select.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxMnu_Select_ALL, Me.CtxMnuSelect_Remove})
        Me.CtxMnu_Select.Text = "Select ALL"
        '
        'CtxMnu_Select_ALL
        '
        Me.CtxMnu_Select_ALL.Name = "CtxMnu_Select_ALL"
        Me.CtxMnu_Select_ALL.Text = "Chọn hết"
        '
        'CtxMnuSelect_Remove
        '
        Me.CtxMnuSelect_Remove.Name = "CtxMnuSelect_Remove"
        Me.CtxMnuSelect_Remove.Text = "Bỏ chọn"
        '
        'ToolStrip_List_QLSX
        '
        Me.ToolStrip_List_QLSX.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip_List_QLSX.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip_List_QLSX.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_List_QLSX.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip_List_QLSX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRefresh, Me.ToolStripSeparator4, Me.btnInLenh_SX, Me.ToolStripSeparator6, Me.lblRow, Me.ToolStripButton_CapNhat, Me.ToolStripSeparator1, Me.ToolStripButton_ApThietBi, Me.ToolStripSeparator2, Me.ToolStripButton_HuyCongDoan, Me.ToolStripSeparator3, Me.ToolStripButton_XacNhanHoanThanh})
        Me.ToolStrip_List_QLSX.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_List_QLSX.Name = "ToolStrip_List_QLSX"
        Me.ToolStrip_List_QLSX.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip_List_QLSX.Size = New System.Drawing.Size(1095, 31)
        Me.ToolStrip_List_QLSX.TabIndex = 438
        Me.ToolStrip_List_QLSX.Text = "ToolStrip1"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.cmdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(99, 28)
        Me.cmdRefresh.Text = "Làm Mới"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'btnInLenh_SX
        '
        Me.btnInLenh_SX.Image = Global.WindowsApplication1.My.Resources.Resources.printer
        Me.btnInLenh_SX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInLenh_SX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnInLenh_SX.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInLenh_SX.Name = "btnInLenh_SX"
        Me.btnInLenh_SX.Size = New System.Drawing.Size(111, 28)
        Me.btnInLenh_SX.Text = "In Lệnh SX"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'lblRow
        '
        Me.lblRow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(68, 28)
        Me.lblRow.Text = "Tổng số:"
        '
        'ToolStripButton_CapNhat
        '
        Me.ToolStripButton_CapNhat.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.ToolStripButton_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton_CapNhat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_CapNhat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_CapNhat.Name = "ToolStripButton_CapNhat"
        Me.ToolStripButton_CapNhat.Size = New System.Drawing.Size(102, 28)
        Me.ToolStripButton_CapNhat.Text = "Cập Nhật"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton_ApThietBi
        '
        Me.ToolStripButton_ApThietBi.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.ToolStripButton_ApThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton_ApThietBi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_ApThietBi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ApThietBi.Name = "ToolStripButton_ApThietBi"
        Me.ToolStripButton_ApThietBi.Size = New System.Drawing.Size(230, 28)
        Me.ToolStripButton_ApThietBi.Text = "Áp Thiết Bị Cho Công Đoạn"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton_HuyCongDoan
        '
        Me.ToolStripButton_HuyCongDoan.Image = Global.WindowsApplication1.My.Resources.Resources.database_next
        Me.ToolStripButton_HuyCongDoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton_HuyCongDoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_HuyCongDoan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_HuyCongDoan.Name = "ToolStripButton_HuyCongDoan"
        Me.ToolStripButton_HuyCongDoan.Size = New System.Drawing.Size(146, 28)
        Me.ToolStripButton_HuyCongDoan.Text = "Hủy Công Đoạn"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton_XacNhanHoanThanh
        '
        Me.ToolStripButton_XacNhanHoanThanh.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.ToolStripButton_XacNhanHoanThanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton_XacNhanHoanThanh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_XacNhanHoanThanh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_XacNhanHoanThanh.Name = "ToolStripButton_XacNhanHoanThanh"
        Me.ToolStripButton_XacNhanHoanThanh.Size = New System.Drawing.Size(191, 28)
        Me.ToolStripButton_XacNhanHoanThanh.Text = "Xác Nhận Hoàn Thành"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 11
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ChkMeChuaSanXuat, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboTencongdoan, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dt1_F, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dt2_F, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame_F, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtloaihang_F, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmau_F, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang_F, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdonhang_F, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmahang_F, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmamau_F, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSelect_Day, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 589)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1095, 75)
        Me.TableLayoutPanel1.TabIndex = 439
        '
        'ChkMeChuaSanXuat
        '
        Me.ChkMeChuaSanXuat.AutoSize = True
        '
        '
        '
        Me.ChkMeChuaSanXuat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkMeChuaSanXuat.CheckSignSize = New System.Drawing.Size(25, 25)
        Me.ChkMeChuaSanXuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMeChuaSanXuat.Location = New System.Drawing.Point(577, 38)
        Me.ChkMeChuaSanXuat.Name = "ChkMeChuaSanXuat"
        Me.ChkMeChuaSanXuat.Size = New System.Drawing.Size(166, 27)
        Me.ChkMeChuaSanXuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkMeChuaSanXuat.TabIndex = 433
        Me.ChkMeChuaSanXuat.Text = "Mẻ Chưa Sản Xuất"
        '
        'cboTencongdoan
        '
        Me.cboTencongdoan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTencongdoan.DisplayMember = "Text"
        Me.cboTencongdoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTencongdoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTencongdoan.FocusHighlightEnabled = True
        Me.cboTencongdoan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTencongdoan.FormattingEnabled = True
        Me.cboTencongdoan.ItemHeight = 24
        Me.cboTencongdoan.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboTencongdoan.Location = New System.Drawing.Point(576, 2)
        Me.cboTencongdoan.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTencongdoan.Name = "cboTencongdoan"
        Me.cboTencongdoan.Size = New System.Drawing.Size(235, 30)
        Me.cboTencongdoan.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.cboTencongdoan.TabIndex = 433
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Tất Cả"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Thành Phẩm"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Xử Lý Lại"
        '
        'frmNhatKySanXuat_quantri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1095, 664)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip_List_QLSX)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmNhatKySanXuat_quantri"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhật Ký (Quản Trị)"
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip_List_QLSX.ResumeLayout(False)
        Me.ToolStrip_List_QLSX.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttongkg_chung As System.Windows.Forms.TextBox
    Friend WithEvents txttongcay_chung As System.Windows.Forms.TextBox
    Friend WithEvents btExcel_chung As System.Windows.Forms.Button
    Friend WithEvents txtmame_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmamau_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmau_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmahang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdonhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtkhachhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtloaihang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnSelect_Day As DevComponents.DotNetBar.ButtonX
    Private WithEvents dt2_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents dt1_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents CtxFunction As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_delete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Export_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Expand As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Colapse As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSave_ColumnFrozen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMnu_Select As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMnu_Select_ALL As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMnuSelect_Remove As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ToolStrip_List_QLSX As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnInLenh_SX As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblRow As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cboTencongdoan As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ToolStripButton_CapNhat As ToolStripButton
    Friend WithEvents ChkMeChuaSanXuat As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton_ApThietBi As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton_HuyCongDoan As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton_XacNhanHoanThanh As ToolStripButton
End Class
