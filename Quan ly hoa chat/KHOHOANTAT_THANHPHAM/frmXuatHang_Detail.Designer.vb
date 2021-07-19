<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXuatHang_Detail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderPattern1 As DevComponents.DotNetBar.SuperGrid.Style.BorderPattern = New DevComponents.DotNetBar.SuperGrid.Style.BorderPattern()
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXuatHang_Detail))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ToolStrip_List_Nhapmoc_De = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnXoa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExport_Excel = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txttenmau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btTim = New DevComponents.DotNetBar.ButtonX()
        Me.dt1_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dt2_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtsoxe_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtloaihang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmame_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmahang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdonhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbokieuxuat = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.txtchungtu_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtkhachhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmamau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip_List_Nhapmoc_De.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1124, 492)
        Me.Panel1.TabIndex = 403
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
        Me.Super_Dgv.Location = New System.Drawing.Point(132, 121)
        Me.Super_Dgv.Name = "Super_Dgv"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        Me.Super_Dgv.PrimaryGrid.AllowEdit = False
        Me.Super_Dgv.PrimaryGrid.AllowRowHeaderResize = True
        Me.Super_Dgv.PrimaryGrid.AllowRowResize = True
        Me.Super_Dgv.PrimaryGrid.AutoExpandSetGroup = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Caption.AllowSelection = False
        Me.Super_Dgv.PrimaryGrid.Caption.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.BottomLeft
        Me.Super_Dgv.PrimaryGrid.Caption.EnableMarkup = False
        Me.Super_Dgv.PrimaryGrid.Caption.Text = ""
        Me.Super_Dgv.PrimaryGrid.Caption.Visible = False
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
        Me.Super_Dgv.PrimaryGrid.GroupByRow.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.Copy
        Me.Super_Dgv.PrimaryGrid.GroupByRow.Text = ""
        Me.Super_Dgv.PrimaryGrid.GroupByRow.WatermarkText = "Kéo cột cần xem vào đây"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Header.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.TopLeft
        Me.Super_Dgv.PrimaryGrid.Header.EnableMarkup = False
        Me.Super_Dgv.PrimaryGrid.Header.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.Always
        Me.Super_Dgv.PrimaryGrid.Header.Text = ""
        Me.Super_Dgv.PrimaryGrid.Header.Visible = False
        Me.Super_Dgv.PrimaryGrid.MinRowHeight = 30
        Me.Super_Dgv.PrimaryGrid.NoRowsText = "Không có dữ liệu"
        Me.Super_Dgv.PrimaryGrid.ReadOnly = True
        Me.Super_Dgv.PrimaryGrid.RowHeaderWidth = 45
        Me.Super_Dgv.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.Super_Dgv.PrimaryGrid.Title.Text = ""
        Me.Super_Dgv.Size = New System.Drawing.Size(342, 258)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 414
        '
        'ToolStrip_List_Nhapmoc_De
        '
        Me.ToolStrip_List_Nhapmoc_De.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip_List_Nhapmoc_De.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip_List_Nhapmoc_De.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip_List_Nhapmoc_De.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.ToolStripSeparator2, Me.btnXoa, Me.ToolStripSeparator3, Me.btnExport_Excel})
        Me.ToolStrip_List_Nhapmoc_De.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_List_Nhapmoc_De.Name = "ToolStrip_List_Nhapmoc_De"
        Me.ToolStrip_List_Nhapmoc_De.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip_List_Nhapmoc_De.Size = New System.Drawing.Size(1124, 39)
        Me.ToolStrip_List_Nhapmoc_De.TabIndex = 410
        Me.ToolStrip_List_Nhapmoc_De.Text = "ToolStrip1"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.WindowsApplication1.My.Resources.Resources.note_edit
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.Text = "Lưu Lại"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.WindowsApplication1.My.Resources.Resources.remove
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(63, 36)
        Me.btnXoa.Text = "Xoá"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnExport_Excel
        '
        Me.btnExport_Excel.Image = Global.WindowsApplication1.My.Resources.Resources.report
        Me.btnExport_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport_Excel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExport_Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport_Excel.Name = "btnExport_Excel"
        Me.btnExport_Excel.Size = New System.Drawing.Size(111, 36)
        Me.btnExport_Excel.Text = "Xuất Excel"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txttenmau_F, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btTim, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dt1_F, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dt2_F, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtsoxe_F, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtloaihang_F, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame_F, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmahang_F, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdonhang_F, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbokieuxuat, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtchungtu_F, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang_F, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmamau_F, 5, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 531)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1124, 73)
        Me.TableLayoutPanel1.TabIndex = 425
        '
        'txttenmau_F
        '
        Me.txttenmau_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txttenmau_F.Border.Class = "TextBoxBorder"
        Me.txttenmau_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttenmau_F.FocusHighlightEnabled = True
        Me.txttenmau_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenmau_F.Location = New System.Drawing.Point(562, 39)
        Me.txttenmau_F.Name = "txttenmau_F"
        Me.txttenmau_F.Size = New System.Drawing.Size(90, 26)
        Me.txttenmau_F.TabIndex = 425
        Me.txttenmau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenmau_F.WatermarkText = "Tên màu"
        '
        'btTim
        '
        Me.btTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTim.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btTim.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTim.Image = CType(resources.GetObject("btTim.Image"), System.Drawing.Image)
        Me.btTim.Location = New System.Drawing.Point(123, 3)
        Me.btTim.Name = "btTim"
        Me.btTim.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btTim.Size = New System.Drawing.Size(48, 29)
        Me.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btTim.TabIndex = 393
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
        Me.dt1_F.Size = New System.Drawing.Size(114, 26)
        Me.dt1_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt1_F.TabIndex = 387
        Me.dt1_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt1_F.WatermarkText = "Từ ngày"
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
        Me.dt2_F.Location = New System.Drawing.Point(3, 39)
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
        Me.dt2_F.Size = New System.Drawing.Size(114, 26)
        Me.dt2_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt2_F.TabIndex = 388
        Me.dt2_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt2_F.WatermarkText = "Đến ngày"
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
        Me.txtsoxe_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsoxe_F.Location = New System.Drawing.Point(658, 39)
        Me.txtsoxe_F.Name = "txtsoxe_F"
        Me.txtsoxe_F.Size = New System.Drawing.Size(59, 26)
        Me.txtsoxe_F.TabIndex = 395
        Me.txtsoxe_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsoxe_F.WatermarkText = "Số Xe"
        '
        'txtloaihang_F
        '
        Me.txtloaihang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtloaihang_F.Border.Class = "TextBoxBorder"
        Me.txtloaihang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtloaihang_F.FocusHighlightEnabled = True
        Me.txtloaihang_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.Location = New System.Drawing.Point(444, 39)
        Me.txtloaihang_F.Name = "txtloaihang_F"
        Me.txtloaihang_F.Size = New System.Drawing.Size(112, 26)
        Me.txtloaihang_F.TabIndex = 396
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
        Me.txtmame_F.FocusHighlightEnabled = True
        Me.txtmame_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.Location = New System.Drawing.Point(658, 4)
        Me.txtmame_F.Name = "txtmame_F"
        Me.txtmame_F.Size = New System.Drawing.Size(59, 26)
        Me.txtmame_F.TabIndex = 394
        Me.txtmame_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.WatermarkText = "Mã Mẻ"
        '
        'txtmahang_F
        '
        Me.txtmahang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmahang_F.Border.Class = "TextBoxBorder"
        Me.txtmahang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmahang_F.FocusHighlightEnabled = True
        Me.txtmahang_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.Location = New System.Drawing.Point(444, 4)
        Me.txtmahang_F.Name = "txtmahang_F"
        Me.txtmahang_F.Size = New System.Drawing.Size(112, 26)
        Me.txtmahang_F.TabIndex = 399
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
        Me.txtdonhang_F.FocusHighlightEnabled = True
        Me.txtdonhang_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.Location = New System.Drawing.Point(323, 39)
        Me.txtdonhang_F.Name = "txtdonhang_F"
        Me.txtdonhang_F.Size = New System.Drawing.Size(115, 26)
        Me.txtdonhang_F.TabIndex = 400
        Me.txtdonhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.WatermarkText = "Đơn Hàng"
        '
        'cbokieuxuat
        '
        Me.cbokieuxuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbokieuxuat.DisplayMember = "Text"
        Me.cbokieuxuat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbokieuxuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbokieuxuat.FocusHighlightEnabled = True
        Me.cbokieuxuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbokieuxuat.FormattingEnabled = True
        Me.cbokieuxuat.ItemHeight = 20
        Me.cbokieuxuat.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem1, Me.ComboItem6, Me.ComboItem5})
        Me.cbokieuxuat.Location = New System.Drawing.Point(177, 4)
        Me.cbokieuxuat.Name = "cbokieuxuat"
        Me.cbokieuxuat.Size = New System.Drawing.Size(140, 26)
        Me.cbokieuxuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbokieuxuat.TabIndex = 397
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Tất Cả"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Xuất Đủ"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Xuất chưa đủ"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Chưa Xuất"
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
        Me.txtchungtu_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchungtu_F.Location = New System.Drawing.Point(177, 39)
        Me.txtchungtu_F.Name = "txtchungtu_F"
        Me.txtchungtu_F.Size = New System.Drawing.Size(140, 26)
        Me.txtchungtu_F.TabIndex = 2
        Me.txtchungtu_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchungtu_F.WatermarkText = "Chứng từ"
        '
        'txtkhachhang_F
        '
        Me.txtkhachhang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtkhachhang_F.Border.Class = "TextBoxBorder"
        Me.txtkhachhang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtkhachhang_F.FocusHighlightEnabled = True
        Me.txtkhachhang_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.Location = New System.Drawing.Point(323, 4)
        Me.txtkhachhang_F.Name = "txtkhachhang_F"
        Me.txtkhachhang_F.Size = New System.Drawing.Size(115, 26)
        Me.txtkhachhang_F.TabIndex = 3
        Me.txtkhachhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.WatermarkText = "Khách Hàng"
        '
        'txtmamau_F
        '
        Me.txtmamau_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmamau_F.Border.Class = "TextBoxBorder"
        Me.txtmamau_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmamau_F.FocusHighlightEnabled = True
        Me.txtmamau_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau_F.Location = New System.Drawing.Point(562, 4)
        Me.txtmamau_F.Name = "txtmamau_F"
        Me.txtmamau_F.Size = New System.Drawing.Size(90, 26)
        Me.txtmamau_F.TabIndex = 398
        Me.txtmamau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau_F.WatermarkText = "Mã màu"
        '
        'frmXuatHang_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 604)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip_List_Nhapmoc_De)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "frmXuatHang_Detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chứng Từ Nhập  - Chi Tiết"
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip_List_Nhapmoc_De.ResumeLayout(False)
        Me.ToolStrip_List_Nhapmoc_De.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ToolStrip_List_Nhapmoc_De As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnXoa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExport_Excel As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txttenmau_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btTim As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dt1_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dt2_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtsoxe_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtloaihang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmame_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmahang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdonhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbokieuxuat As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents txtchungtu_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtkhachhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmamau_F As DevComponents.DotNetBar.Controls.TextBoxX
End Class
