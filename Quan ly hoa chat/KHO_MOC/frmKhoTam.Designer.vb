<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKhoTam
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
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderPattern1 As DevComponents.DotNetBar.SuperGrid.Style.BorderPattern = New DevComponents.DotNetBar.SuperGrid.Style.BorderPattern()
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.txtkhachHang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtghichu_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txttaixe_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtchungtu_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dt2_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtmahang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsoxe_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dt1_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.GridCell1 = New DevComponents.DotNetBar.SuperGrid.GridCell()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Grp_Info = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PnPopup_List = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboKieunhap = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtmadet = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbltrangthai = New System.Windows.Forms.Label()
        Me.txtchungtunhap = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtngaynhap = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltaixe = New System.Windows.Forms.Label()
        Me.txtmahang = New System.Windows.Forms.TextBox()
        Me.txtsomet = New System.Windows.Forms.TextBox()
        Me.txtkhachhang = New System.Windows.Forms.TextBox()
        Me.txtsoxe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtloaihang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtghichu = New System.Windows.Forms.TextBox()
        Me.lblghichu = New System.Windows.Forms.Label()
        Me.txtsocay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsokg = New System.Windows.Forms.TextBox()
        Me.txttaixe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Dgv_Chungtu = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.CtxFunction = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Add = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Modify = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_delete = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Copy = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Export_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Expand = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Colapse = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSave_ColumnFrozen = New DevComponents.DotNetBar.ButtonItem()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.GridColumn1 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.btnThutuCot = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.cboTatca = New DevComponents.Editors.ComboItem()
        Me.cboNhapdu = New DevComponents.Editors.ComboItem()
        Me.cboNhapchuadu = New DevComponents.Editors.ComboItem()
        Me.cboChuanhap = New DevComponents.Editors.ComboItem()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.ToolStrip_List_NhapMoc = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnModify = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExport_excel = New System.Windows.Forms.ToolStripButton()
        Me.lblRow = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCopy = New DevComponents.DotNetBar.ButtonItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtdonhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.chk_tatca = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtloaihang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Grp_Info.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Dgv_Chungtu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip_List_NhapMoc.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.btnSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnSearch.Location = New System.Drawing.Point(123, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 26)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.btnSearch.TabIndex = 402
        '
        'txtkhachHang_F
        '
        Me.txtkhachHang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtkhachHang_F.Border.Class = "TextBoxBorder"
        Me.txtkhachHang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtkhachHang_F.FocusHighlightEnabled = True
        Me.txtkhachHang_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachHang_F.Location = New System.Drawing.Point(348, 36)
        Me.txtkhachHang_F.Name = "txtkhachHang_F"
        Me.txtkhachHang_F.Size = New System.Drawing.Size(91, 24)
        Me.txtkhachHang_F.TabIndex = 399
        Me.txtkhachHang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtkhachHang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachHang_F.WatermarkText = "Khách Hàng"
        '
        'txtghichu_F
        '
        Me.txtghichu_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtghichu_F.Border.Class = "TextBoxBorder"
        Me.txtghichu_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtghichu_F.FocusHighlightEnabled = True
        Me.txtghichu_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu_F.Location = New System.Drawing.Point(544, 36)
        Me.txtghichu_F.Name = "txtghichu_F"
        Me.txtghichu_F.Size = New System.Drawing.Size(101, 24)
        Me.txtghichu_F.TabIndex = 398
        Me.txtghichu_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtghichu_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu_F.WatermarkText = "Ghi Chú"
        '
        'txttaixe_F
        '
        Me.txttaixe_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txttaixe_F.Border.Class = "TextBoxBorder"
        Me.txttaixe_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttaixe_F.FocusHighlightEnabled = True
        Me.txttaixe_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttaixe_F.Location = New System.Drawing.Point(445, 4)
        Me.txttaixe_F.Name = "txttaixe_F"
        Me.txttaixe_F.Size = New System.Drawing.Size(93, 24)
        Me.txttaixe_F.TabIndex = 394
        Me.txttaixe_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txttaixe_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttaixe_F.WatermarkText = "Tài xế"
        '
        'txtchungtu_F
        '
        Me.txtchungtu_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtchungtu_F.Border.Class = "TextBoxBorder"
        Me.txtchungtu_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtchungtu_F.FocusHighlightEnabled = True
        Me.txtchungtu_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchungtu_F.Location = New System.Drawing.Point(230, 4)
        Me.txtchungtu_F.Name = "txtchungtu_F"
        Me.txtchungtu_F.Size = New System.Drawing.Size(112, 24)
        Me.txtchungtu_F.TabIndex = 390
        Me.txtchungtu_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtchungtu_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchungtu_F.WatermarkText = "Chứng từ"
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
        Me.dt2_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2_F.IsPopupCalendarOpen = False
        Me.dt2_F.Location = New System.Drawing.Point(3, 36)
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
        Me.dt2_F.Size = New System.Drawing.Size(114, 24)
        Me.dt2_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt2_F.TabIndex = 396
        Me.dt2_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt2_F.WatermarkText = "Đến ngày"
        '
        'txtmahang_F
        '
        Me.txtmahang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmahang_F.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtmahang_F.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtmahang_F.Border.Class = "TextBoxBorder"
        Me.txtmahang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmahang_F.FocusHighlightEnabled = True
        Me.txtmahang_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.Location = New System.Drawing.Point(348, 4)
        Me.txtmahang_F.Name = "txtmahang_F"
        Me.txtmahang_F.Size = New System.Drawing.Size(91, 24)
        Me.txtmahang_F.TabIndex = 392
        Me.txtmahang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmahang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.WatermarkText = "Mã Hàng"
        '
        'txtsoxe_F
        '
        Me.txtsoxe_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtsoxe_F.Border.Class = "TextBoxBorder"
        Me.txtsoxe_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsoxe_F.FocusHighlightEnabled = True
        Me.txtsoxe_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsoxe_F.Location = New System.Drawing.Point(544, 4)
        Me.txtsoxe_F.Name = "txtsoxe_F"
        Me.txtsoxe_F.Size = New System.Drawing.Size(101, 24)
        Me.txtsoxe_F.TabIndex = 393
        Me.txtsoxe_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtsoxe_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsoxe_F.WatermarkText = "Số xe"
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
        Me.dt1_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1_F.IsPopupCalendarOpen = False
        Me.dt1_F.Location = New System.Drawing.Point(3, 4)
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
        Me.dt1_F.Size = New System.Drawing.Size(114, 24)
        Me.dt1_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt1_F.TabIndex = 395
        Me.dt1_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt1_F.WatermarkText = "Từ ngày"
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
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.AllowMultiLine = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
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
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Background2.Color1 = System.Drawing.Color.PapayaWhip
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.Background = Background2
        BorderPattern1.Bottom = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        BorderPattern1.Left = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        BorderPattern1.Right = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        BorderPattern1.Top = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.BorderPattern = BorderPattern1
        Thickness3.Bottom = 1
        Thickness3.Left = 1
        Thickness3.Right = 1
        Thickness3.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.BorderThickness = Thickness3
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square
        Me.Super_Dgv.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.Location = New System.Drawing.Point(11, 13)
        Me.Super_Dgv.Name = "Super_Dgv"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        Me.Super_Dgv.PrimaryGrid.AllowEdit = False
        Me.Super_Dgv.PrimaryGrid.AllowRowHeaderResize = True
        Me.Super_Dgv.PrimaryGrid.AllowRowResize = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Caption.AllowSelection = False
        Me.Super_Dgv.PrimaryGrid.Caption.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.BottomLeft
        Me.Super_Dgv.PrimaryGrid.Caption.EnableMarkup = False
        Me.Super_Dgv.PrimaryGrid.Caption.Text = ""
        Me.Super_Dgv.PrimaryGrid.Caption.Visible = False
        Me.Super_Dgv.PrimaryGrid.CheckBoxSize = New System.Drawing.Size(40, 40)
        Me.Super_Dgv.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells
        Me.Super_Dgv.PrimaryGrid.ColumnGroupHeaderClickBehavior = DevComponents.DotNetBar.SuperGrid.ColumnHeaderClickBehavior.None
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.RowHeaderText = ""
        Me.Super_Dgv.PrimaryGrid.ColumnHeaderClickBehavior = DevComponents.DotNetBar.SuperGrid.ColumnHeaderClickBehavior.[Select]
        BorderColor1.Bottom = System.Drawing.Color.Black
        BorderColor1.Left = System.Drawing.Color.Black
        BorderColor1.Right = System.Drawing.Color.Black
        BorderColor1.Top = System.Drawing.Color.Black
        Me.Super_Dgv.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor1
        Me.Super_Dgv.PrimaryGrid.EnableColumnFiltering = True
        Me.Super_Dgv.PrimaryGrid.EnableFiltering = True
        Me.Super_Dgv.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Filter.RowHeight = 30
        Me.Super_Dgv.PrimaryGrid.Filter.Visible = True
        Me.Super_Dgv.PrimaryGrid.FilterExpr = ""
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Footer.Text = ""
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.GroupByRow.AllowUserSort = False
        Me.Super_Dgv.PrimaryGrid.GroupByRow.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.Copy
        Me.Super_Dgv.PrimaryGrid.GroupByRow.Text = ""
        Me.Super_Dgv.PrimaryGrid.GroupByRow.Visible = True
        Me.Super_Dgv.PrimaryGrid.GroupByRow.WatermarkText = "Kéo cột cần xem vào đây"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Header.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.TopLeft
        Me.Super_Dgv.PrimaryGrid.Header.EnableMarkup = False
        Me.Super_Dgv.PrimaryGrid.Header.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.Always
        Me.Super_Dgv.PrimaryGrid.Header.Text = ""
        Me.Super_Dgv.PrimaryGrid.Header.Visible = False
        Me.Super_Dgv.PrimaryGrid.IndentGroups = False
        Me.Super_Dgv.PrimaryGrid.MinRowHeight = 30
        Me.Super_Dgv.PrimaryGrid.NoRowsText = ""
        Me.Super_Dgv.PrimaryGrid.ReadOnly = True
        Me.Super_Dgv.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.Super_Dgv.PrimaryGrid.RowHeaderWidth = 45
        Me.Super_Dgv.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.Super_Dgv.PrimaryGrid.Title.Text = ""
        Me.Super_Dgv.Size = New System.Drawing.Size(120, 83)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 413
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Grp_Info)
        Me.Panel1.Controls.Add(Me.ContextMenuBar1)
        Me.Panel1.Controls.Add(Me.CircularProgress1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1189, 597)
        Me.Panel1.TabIndex = 417
        '
        'Grp_Info
        '
        Me.Grp_Info.CanvasColor = System.Drawing.SystemColors.Control
        Me.Grp_Info.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Grp_Info.Controls.Add(Me.PnPopup_List)
        Me.Grp_Info.Controls.Add(Me.TableLayoutPanel1)
        Me.Grp_Info.Controls.Add(Me.Dgv_Chungtu)
        Me.Grp_Info.DisabledBackColor = System.Drawing.Color.Empty
        Me.Grp_Info.Location = New System.Drawing.Point(335, 69)
        Me.Grp_Info.Name = "Grp_Info"
        Me.Grp_Info.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.Grp_Info.Size = New System.Drawing.Size(582, 443)
        '
        '
        '
        Me.Grp_Info.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Grp_Info.Style.BackColorGradientAngle = 90
        Me.Grp_Info.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Grp_Info.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Grp_Info.Style.BorderBottomWidth = 1
        Me.Grp_Info.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Grp_Info.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Grp_Info.Style.BorderLeftWidth = 1
        Me.Grp_Info.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Grp_Info.Style.BorderRightWidth = 1
        Me.Grp_Info.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Grp_Info.Style.BorderTopWidth = 1
        Me.Grp_Info.Style.CornerDiameter = 4
        Me.Grp_Info.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Grp_Info.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Grp_Info.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Grp_Info.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Grp_Info.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Grp_Info.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Grp_Info.TabIndex = 438
        Me.Grp_Info.Text = "Nhập Mộc"
        Me.Grp_Info.Visible = False
        '
        'PnPopup_List
        '
        Me.PnPopup_List.Location = New System.Drawing.Point(690, 192)
        Me.PnPopup_List.Margin = New System.Windows.Forms.Padding(4)
        Me.PnPopup_List.Name = "PnPopup_List"
        Me.PnPopup_List.Size = New System.Drawing.Size(50, 75)
        Me.PnPopup_List.TabIndex = 536
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cboKieunhap, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmadet, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbltrangthai, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtchungtunhap, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.dtngaynhap, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.lbltaixe, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmahang, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtsomet, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtsoxe, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtloaihang, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichu, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lblghichu, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtsocay, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtsokg, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txttaixe, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExit, 3, 11)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(546, 417)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cboKieunhap
        '
        Me.cboKieunhap.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboKieunhap.DisplayMember = "Text"
        Me.cboKieunhap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKieunhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKieunhap.FocusHighlightEnabled = True
        Me.cboKieunhap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKieunhap.FormattingEnabled = True
        Me.cboKieunhap.ItemHeight = 20
        Me.cboKieunhap.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cboKieunhap.Location = New System.Drawing.Point(341, 3)
        Me.cboKieunhap.Name = "cboKieunhap"
        Me.cboKieunhap.Size = New System.Drawing.Size(187, 26)
        Me.cboKieunhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboKieunhap.TabIndex = 439
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Nhập Tạm"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Xuất Tạm"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(254, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 516
        Me.Label2.Text = "Mục Đích:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 134)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 19)
        Me.Label12.TabIndex = 537
        Me.Label12.Text = "Mã Dệt:"
        '
        'txtmadet
        '
        Me.txtmadet.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmadet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmadet, 3)
        Me.txtmadet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmadet.Location = New System.Drawing.Point(110, 132)
        Me.txtmadet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmadet.Name = "txtmadet"
        Me.txtmadet.Size = New System.Drawing.Size(417, 26)
        Me.txtmadet.TabIndex = 537
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 102)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 19)
        Me.Label11.TabIndex = 513
        Me.Label11.Text = "Tên Hàng:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 70)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 19)
        Me.Label10.TabIndex = 513
        Me.Label10.Text = "Khách Hàng:"
        '
        'lbltrangthai
        '
        Me.lbltrangthai.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltrangthai.AutoSize = True
        Me.lbltrangthai.BackColor = System.Drawing.Color.Transparent
        Me.lbltrangthai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrangthai.ForeColor = System.Drawing.Color.Black
        Me.lbltrangthai.Location = New System.Drawing.Point(4, 6)
        Me.lbltrangthai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltrangthai.Name = "lbltrangthai"
        Me.lbltrangthai.Size = New System.Drawing.Size(98, 19)
        Me.lbltrangthai.TabIndex = 514
        Me.lbltrangthai.Text = "Chứng từ:"
        '
        'txtchungtunhap
        '
        Me.txtchungtunhap.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtchungtunhap.BackColor = System.Drawing.Color.White
        Me.txtchungtunhap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchungtunhap.ForeColor = System.Drawing.Color.Red
        Me.txtchungtunhap.Location = New System.Drawing.Point(110, 4)
        Me.txtchungtunhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtchungtunhap.Name = "txtchungtunhap"
        Me.txtchungtunhap.ReadOnly = True
        Me.txtchungtunhap.Size = New System.Drawing.Size(136, 26)
        Me.txtchungtunhap.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.WindowsApplication1.My.Resources.Resources.Good_or_Tick_icon_24
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(111, 362)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 39)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Lưu Lại"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtngaynhap
        '
        Me.dtngaynhap.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtngaynhap.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtngaynhap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtngaynhap.Location = New System.Drawing.Point(110, 324)
        Me.dtngaynhap.Margin = New System.Windows.Forms.Padding(4)
        Me.dtngaynhap.Name = "dtngaynhap"
        Me.dtngaynhap.Size = New System.Drawing.Size(136, 26)
        Me.dtngaynhap.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 327)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 517
        Me.Label4.Text = "Ngày Tạo:"
        '
        'lbltaixe
        '
        Me.lbltaixe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltaixe.AutoSize = True
        Me.lbltaixe.BackColor = System.Drawing.Color.Transparent
        Me.lbltaixe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltaixe.Location = New System.Drawing.Point(4, 38)
        Me.lbltaixe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltaixe.Name = "lbltaixe"
        Me.lbltaixe.Size = New System.Drawing.Size(98, 19)
        Me.lbltaixe.TabIndex = 512
        Me.lbltaixe.Text = "Mã Hàng:"
        '
        'txtmahang
        '
        Me.txtmahang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmahang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmahang, 3)
        Me.txtmahang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang.Location = New System.Drawing.Point(110, 36)
        Me.txtmahang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmahang.Name = "txtmahang"
        Me.txtmahang.Size = New System.Drawing.Size(417, 26)
        Me.txtmahang.TabIndex = 1
        '
        'txtsomet
        '
        Me.txtsomet.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsomet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsomet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsomet.Location = New System.Drawing.Point(110, 228)
        Me.txtsomet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsomet.Name = "txtsomet"
        Me.txtsomet.Size = New System.Drawing.Size(136, 26)
        Me.txtsomet.TabIndex = 4
        Me.txtsomet.Text = "0"
        Me.txtsomet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtkhachhang
        '
        Me.txtkhachhang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkhachhang.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtkhachhang, 3)
        Me.txtkhachhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang.ForeColor = System.Drawing.Color.Red
        Me.txtkhachhang.Location = New System.Drawing.Point(110, 68)
        Me.txtkhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkhachhang.Name = "txtkhachhang"
        Me.txtkhachhang.ReadOnly = True
        Me.txtkhachhang.Size = New System.Drawing.Size(417, 26)
        Me.txtkhachhang.TabIndex = 524
        '
        'txtsoxe
        '
        Me.txtsoxe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsoxe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsoxe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsoxe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsoxe.Location = New System.Drawing.Point(110, 292)
        Me.txtsoxe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsoxe.Name = "txtsoxe"
        Me.txtsoxe.Size = New System.Drawing.Size(136, 26)
        Me.txtsoxe.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 294)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 518
        Me.Label3.Text = "Số xe:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 230)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 19)
        Me.Label8.TabIndex = 527
        Me.Label8.Text = "Mét:"
        '
        'txtloaihang
        '
        Me.txtloaihang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtloaihang.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtloaihang, 3)
        Me.txtloaihang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang.Location = New System.Drawing.Point(110, 100)
        Me.txtloaihang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtloaihang.Name = "txtloaihang"
        Me.txtloaihang.ReadOnly = True
        Me.txtloaihang.Size = New System.Drawing.Size(417, 26)
        Me.txtloaihang.TabIndex = 525
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 515
        Me.Label1.Text = "Số cây:"
        '
        'txtghichu
        '
        Me.txtghichu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtghichu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtghichu, 3)
        Me.txtghichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu.Location = New System.Drawing.Point(110, 260)
        Me.txtghichu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(417, 26)
        Me.txtghichu.TabIndex = 7
        '
        'lblghichu
        '
        Me.lblghichu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblghichu.AutoSize = True
        Me.lblghichu.BackColor = System.Drawing.Color.Transparent
        Me.lblghichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblghichu.Location = New System.Drawing.Point(4, 262)
        Me.lblghichu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblghichu.Name = "lblghichu"
        Me.lblghichu.Size = New System.Drawing.Size(98, 19)
        Me.lblghichu.TabIndex = 511
        Me.lblghichu.Text = "Ghi chú:"
        '
        'txtsocay
        '
        Me.txtsocay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsocay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsocay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsocay.Location = New System.Drawing.Point(110, 164)
        Me.txtsocay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsocay.Name = "txtsocay"
        Me.txtsocay.Size = New System.Drawing.Size(136, 26)
        Me.txtsocay.TabIndex = 2
        Me.txtsocay.Text = "0"
        Me.txtsocay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 198)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 520
        Me.Label6.Text = "Kg:"
        '
        'txtsokg
        '
        Me.txtsokg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsokg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsokg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsokg.Location = New System.Drawing.Point(110, 196)
        Me.txtsokg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsokg.Name = "txtsokg"
        Me.txtsokg.Size = New System.Drawing.Size(136, 26)
        Me.txtsokg.TabIndex = 3
        Me.txtsokg.Text = "0"
        Me.txtsokg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttaixe
        '
        Me.txttaixe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttaixe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttaixe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttaixe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttaixe.Location = New System.Drawing.Point(342, 292)
        Me.txttaixe.Margin = New System.Windows.Forms.Padding(4)
        Me.txttaixe.Name = "txttaixe"
        Me.txttaixe.Size = New System.Drawing.Size(185, 26)
        Me.txttaixe.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(254, 294)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 519
        Me.Label5.Text = "Tài xế:"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(344, 362)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(181, 39)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Thoát"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Dgv_Chungtu
        '
        Me.Dgv_Chungtu.AllowUserToAddRows = False
        Me.Dgv_Chungtu.AllowUserToDeleteRows = False
        Me.Dgv_Chungtu.AllowUserToResizeColumns = False
        Me.Dgv_Chungtu.AllowUserToResizeRows = False
        Me.Dgv_Chungtu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Chungtu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Chungtu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Chungtu.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Chungtu.EnableHeadersVisualStyles = False
        Me.Dgv_Chungtu.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Dgv_Chungtu.Location = New System.Drawing.Point(625, 294)
        Me.Dgv_Chungtu.Name = "Dgv_Chungtu"
        Me.Dgv_Chungtu.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Chungtu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Chungtu.RowTemplate.Height = 24
        Me.Dgv_Chungtu.Size = New System.Drawing.Size(127, 90)
        Me.Dgv_Chungtu.TabIndex = 535
        Me.Dgv_Chungtu.Visible = False
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(21, 431)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(152, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 416
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'CtxFunction
        '
        Me.CtxFunction.AutoExpandOnClick = True
        Me.CtxFunction.Name = "CtxFunction"
        Me.CtxFunction.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction_Add, Me.CtxFunction_Modify, Me.CtxFunction_delete, Me.CtxFunction_Refresh, Me.LabelItem2, Me.CtxFunction_Copy, Me.LabelItem3, Me.CtxFunction_Export_Excel})
        Me.CtxFunction.Text = "Function"
        '
        'CtxFunction_Add
        '
        Me.CtxFunction_Add.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.CtxFunction_Add.Name = "CtxFunction_Add"
        Me.CtxFunction_Add.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.CtxFunction_Add.Text = "Tạo Mới"
        '
        'CtxFunction_Modify
        '
        Me.CtxFunction_Modify.Image = Global.WindowsApplication1.My.Resources.Resources.note_edit
        Me.CtxFunction_Modify.Name = "CtxFunction_Modify"
        Me.CtxFunction_Modify.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE)
        Me.CtxFunction_Modify.Text = "Chỉnh Sửa"
        '
        'CtxFunction_delete
        '
        Me.CtxFunction_delete.Image = Global.WindowsApplication1.My.Resources.Resources.remove
        Me.CtxFunction_delete.Name = "CtxFunction_delete"
        Me.CtxFunction_delete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.CtxFunction_delete.Text = "Xóa"
        '
        'CtxFunction_Refresh
        '
        Me.CtxFunction_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.CtxFunction_Refresh.Name = "CtxFunction_Refresh"
        Me.CtxFunction_Refresh.Text = "Làm Mới"
        '
        'LabelItem2
        '
        Me.LabelItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.PaddingBottom = 1
        Me.LabelItem2.PaddingLeft = 10
        Me.LabelItem2.PaddingTop = 1
        Me.LabelItem2.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem2.Text = "Sao Chép"
        '
        'CtxFunction_Copy
        '
        Me.CtxFunction_Copy.Image = Global.WindowsApplication1.My.Resources.Resources.mail_forward
        Me.CtxFunction_Copy.Name = "CtxFunction_Copy"
        Me.CtxFunction_Copy.Text = "Sao Chép"
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
        Me.CircularProgress1.Location = New System.Drawing.Point(158, 13)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(108, 83)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 431
        Me.CircularProgress1.Visible = False
        '
        'btnThutuCot
        '
        Me.btnThutuCot.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnThutuCot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThutuCot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnThutuCot.HotFontUnderline = True
        Me.btnThutuCot.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnThutuCot.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.btnThutuCot.Name = "btnThutuCot"
        Me.btnThutuCot.Text = "Thứ Tự Cột"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "------------"
        '
        'cboTatca
        '
        Me.cboTatca.Text = "Tất Cả"
        '
        'cboNhapdu
        '
        Me.cboNhapdu.Text = "Nhập Xong"
        '
        'cboNhapchuadu
        '
        Me.cboNhapchuadu.Text = "Chưa nhập xong"
        '
        'cboChuanhap
        '
        Me.cboChuanhap.Text = "Chưa Nhập"
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultFont = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        '
        'ToolStrip_List_NhapMoc
        '
        Me.ToolStrip_List_NhapMoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip_List_NhapMoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip_List_NhapMoc.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_List_NhapMoc.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip_List_NhapMoc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.ToolStripSeparator4, Me.btnModify, Me.ToolStripSeparator2, Me.btnDelete, Me.ToolStripSeparator1, Me.btnExport_excel, Me.lblRow, Me.ToolStripSeparator3})
        Me.ToolStrip_List_NhapMoc.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_List_NhapMoc.Name = "ToolStrip_List_NhapMoc"
        Me.ToolStrip_List_NhapMoc.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip_List_NhapMoc.Size = New System.Drawing.Size(1189, 31)
        Me.ToolStrip_List_NhapMoc.TabIndex = 439
        Me.ToolStrip_List_NhapMoc.Text = "ToolStrip1"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 28)
        Me.btnAdd.Text = "Thêm Mới"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'btnModify
        '
        Me.btnModify.Image = Global.WindowsApplication1.My.Resources.Resources._20140115031102142_easyicon_net_24
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(108, 28)
        Me.btnModify.Text = "Chỉnh sửa"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.WindowsApplication1.My.Resources.Resources.delete_24
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 28)
        Me.btnDelete.Text = "Xóa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'btnExport_excel
        '
        Me.btnExport_excel.Image = Global.WindowsApplication1.My.Resources.Resources.microsoft_excel_24
        Me.btnExport_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport_excel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExport_excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport_excel.Name = "btnExport_excel"
        Me.btnExport_excel.Size = New System.Drawing.Size(110, 28)
        Me.btnExport_excel.Text = "Xuất Excel"
        '
        'lblRow
        '
        Me.lblRow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(68, 28)
        Me.lblRow.Text = "Tổng số:"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'btnCopy
        '
        Me.btnCopy.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnCopy.HotFontUnderline = True
        Me.btnCopy.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCopy.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.btnCopy.Image = Global.WindowsApplication1.My.Resources.Resources.mail_forward
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Text = "Sao Chép"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 10
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtdonhang_F, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.chk_tatca, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dt1_F, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dt2_F, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSearch, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtchungtu_F, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtghichu_F, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtloaihang_F, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtkhachHang_F, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtmahang_F, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txttaixe_F, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtsoxe_F, 5, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 628)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1189, 72)
        Me.TableLayoutPanel2.TabIndex = 445
        '
        'txtdonhang_F
        '
        Me.txtdonhang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtdonhang_F.Border.Class = "TextBoxBorder"
        Me.txtdonhang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdonhang_F.FocusHighlightEnabled = True
        Me.txtdonhang_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.Location = New System.Drawing.Point(230, 36)
        Me.txtdonhang_F.Name = "txtdonhang_F"
        Me.txtdonhang_F.Size = New System.Drawing.Size(112, 24)
        Me.txtdonhang_F.TabIndex = 439
        Me.txtdonhang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtdonhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.WatermarkText = "Đơn Hàng"
        '
        'chk_tatca
        '
        Me.chk_tatca.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chk_tatca.AutoSize = True
        Me.chk_tatca.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.chk_tatca.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chk_tatca.CheckSignSize = New System.Drawing.Size(25, 25)
        Me.chk_tatca.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_tatca.Location = New System.Drawing.Point(123, 35)
        Me.chk_tatca.Name = "chk_tatca"
        Me.chk_tatca.Size = New System.Drawing.Size(79, 27)
        Me.chk_tatca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chk_tatca.TabIndex = 540
        Me.chk_tatca.Text = "Tất Cả"
        '
        'txtloaihang_F
        '
        Me.txtloaihang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtloaihang_F.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtloaihang_F.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtloaihang_F.Border.Class = "TextBoxBorder"
        Me.txtloaihang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtloaihang_F.FocusHighlightEnabled = True
        Me.txtloaihang_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.Location = New System.Drawing.Point(445, 36)
        Me.txtloaihang_F.Name = "txtloaihang_F"
        Me.txtloaihang_F.Size = New System.Drawing.Size(93, 24)
        Me.txtloaihang_F.TabIndex = 439
        Me.txtloaihang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtloaihang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.WatermarkText = "Loại Hàng"
        '
        'frmKhoTam
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1189, 700)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ToolStrip_List_NhapMoc)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmKhoTam"
        Me.Text = "Kho Tạm"
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Grp_Info.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Dgv_Chungtu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip_List_NhapMoc.ResumeLayout(False)
        Me.ToolStrip_List_NhapMoc.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents GridCell1 As DevComponents.DotNetBar.SuperGrid.GridCell
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Private WithEvents txttaixe_F As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtchungtu_F As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents dt2_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents txtmahang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtsoxe_F As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents dt1_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents txtghichu_F As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtkhachHang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnThutuCot As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents btnCopy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cboTatca As DevComponents.Editors.ComboItem
    Friend WithEvents cboNhapdu As DevComponents.Editors.ComboItem
    Friend WithEvents cboNhapchuadu As DevComponents.Editors.ComboItem
    Friend WithEvents cboChuanhap As DevComponents.Editors.ComboItem
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents CtxFunction As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Modify As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_delete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Copy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Export_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Expand As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Colapse As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSave_ColumnFrozen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents ToolStrip_List_NhapMoc As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModify As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExport_excel As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblRow As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Grp_Info As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtsomet As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtloaihang As System.Windows.Forms.TextBox
    Friend WithEvents txtkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txttaixe As System.Windows.Forms.TextBox
    Friend WithEvents Dgv_Chungtu As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsokg As System.Windows.Forms.TextBox
    Friend WithEvents txtsoxe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtngaynhap As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsocay As System.Windows.Forms.TextBox
    Friend WithEvents txtchungtunhap As System.Windows.Forms.TextBox
    Friend WithEvents txtmahang As System.Windows.Forms.TextBox
    Friend WithEvents lbltrangthai As System.Windows.Forms.Label
    Friend WithEvents lblghichu As System.Windows.Forms.Label
    Friend WithEvents lbltaixe As System.Windows.Forms.Label
    Friend WithEvents txtghichu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PnPopup_List As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents chk_tatca As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Label12 As Label
    Friend WithEvents txtmadet As TextBox
    Private WithEvents txtloaihang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtdonhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As Label
    Friend WithEvents cboKieunhap As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
End Class
