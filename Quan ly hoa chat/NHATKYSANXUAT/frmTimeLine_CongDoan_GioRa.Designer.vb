<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTimeLine_CongDoan_GioRa
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
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderPattern1 As DevComponents.DotNetBar.SuperGrid.Style.BorderPattern = New DevComponents.DotNetBar.SuperGrid.Style.BorderPattern()
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim Thickness4 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness5 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background4 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderPattern2 As DevComponents.DotNetBar.SuperGrid.Style.BorderPattern = New DevComponents.DotNetBar.SuperGrid.Style.BorderPattern()
        Dim Thickness6 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor2 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtNgayXacNhanRa = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.CboKetQua = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.txtsophieu_LKT = New System.Windows.Forms.TextBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cboLyDo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.BtnExit_CapNhat = New System.Windows.Forms.Button()
        Me.btnXacNhan_GioVao = New DevComponents.DotNetBar.ButtonX()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Super_Dgv_CongDoan = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dtNgayXacNhanRa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dtNgayXacNhanRa, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelX4, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelX2, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.CboKetQua, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtsophieu_LKT, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelX3, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.cboLyDo, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnExit_CapNhat, 4, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btnXacNhan_GioVao, 3, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Super_Dgv, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Super_Dgv_CongDoan, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1159, 739)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'dtNgayXacNhanRa
        '
        Me.dtNgayXacNhanRa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtNgayXacNhanRa.AutoSelectDate = True
        '
        '
        '
        Me.dtNgayXacNhanRa.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtNgayXacNhanRa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXacNhanRa.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtNgayXacNhanRa.ButtonDropDown.Visible = True
        Me.dtNgayXacNhanRa.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector
        Me.dtNgayXacNhanRa.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtNgayXacNhanRa.IsPopupCalendarOpen = False
        Me.dtNgayXacNhanRa.Location = New System.Drawing.Point(954, 6)
        Me.dtNgayXacNhanRa.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        '
        '
        '
        '
        '
        '
        Me.dtNgayXacNhanRa.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXacNhanRa.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtNgayXacNhanRa.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtNgayXacNhanRa.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtNgayXacNhanRa.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtNgayXacNhanRa.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtNgayXacNhanRa.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtNgayXacNhanRa.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtNgayXacNhanRa.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtNgayXacNhanRa.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXacNhanRa.MonthCalendar.DisplayMonth = New Date(2014, 11, 1, 0, 0, 0, 0)
        Me.dtNgayXacNhanRa.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtNgayXacNhanRa.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtNgayXacNhanRa.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtNgayXacNhanRa.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtNgayXacNhanRa.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXacNhanRa.MonthCalendar.TodayButtonVisible = True
        Me.dtNgayXacNhanRa.Name = "dtNgayXacNhanRa"
        Me.dtNgayXacNhanRa.ShowUpDown = True
        Me.dtNgayXacNhanRa.Size = New System.Drawing.Size(203, 29)
        Me.dtNgayXacNhanRa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtNgayXacNhanRa.TabIndex = 486
        Me.dtNgayXacNhanRa.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dtNgayXacNhanRa.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.dtNgayXacNhanRa.WatermarkText = "Từ ngày"
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(859, 5)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(90, 31)
        Me.LabelX4.TabIndex = 492
        Me.LabelX4.Text = "GIỜ RA"
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(556, 44)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(113, 31)
        Me.LabelX2.TabIndex = 489
        Me.LabelX2.Text = "KẾT QUẢ"
        '
        'CboKetQua
        '
        Me.CboKetQua.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboKetQua.DisplayMember = "Text"
        Me.CboKetQua.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboKetQua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboKetQua.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboKetQua.FormattingEnabled = True
        Me.CboKetQua.ItemHeight = 23
        Me.CboKetQua.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.CboKetQua.Location = New System.Drawing.Point(675, 44)
        Me.CboKetQua.Name = "CboKetQua"
        Me.CboKetQua.Size = New System.Drawing.Size(274, 29)
        Me.CboKetQua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboKetQua.TabIndex = 487
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Đạt"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Không Đạt"
        '
        'txtsophieu_LKT
        '
        Me.txtsophieu_LKT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsophieu_LKT.BackColor = System.Drawing.SystemColors.Control
        Me.txtsophieu_LKT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsophieu_LKT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsophieu_LKT.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsophieu_LKT.ForeColor = System.Drawing.Color.Red
        Me.txtsophieu_LKT.Location = New System.Drawing.Point(954, 43)
        Me.txtsophieu_LKT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsophieu_LKT.Name = "txtsophieu_LKT"
        Me.txtsophieu_LKT.Size = New System.Drawing.Size(203, 32)
        Me.txtsophieu_LKT.TabIndex = 488
        Me.txtsophieu_LKT.Text = "LKT0001"
        Me.txtsophieu_LKT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(591, 83)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(78, 31)
        Me.LabelX3.TabIndex = 490
        Me.LabelX3.Text = "LÝ DO"
        '
        'cboLyDo
        '
        Me.cboLyDo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.cboLyDo, 2)
        Me.cboLyDo.DisplayMember = "Text"
        Me.cboLyDo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLyDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLyDo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLyDo.FormattingEnabled = True
        Me.cboLyDo.ItemHeight = 23
        Me.cboLyDo.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4})
        Me.cboLyDo.Location = New System.Drawing.Point(675, 84)
        Me.cboLyDo.Name = "cboLyDo"
        Me.cboLyDo.Size = New System.Drawing.Size(481, 29)
        Me.cboLyDo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboLyDo.TabIndex = 491
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Loang Màu"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Dơ"
        '
        'BtnExit_CapNhat
        '
        Me.BtnExit_CapNhat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit_CapNhat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit_CapNhat.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnExit_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit_CapNhat.Location = New System.Drawing.Point(957, 126)
        Me.BtnExit_CapNhat.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnExit_CapNhat.Name = "BtnExit_CapNhat"
        Me.BtnExit_CapNhat.Size = New System.Drawing.Size(197, 44)
        Me.BtnExit_CapNhat.TabIndex = 9
        Me.BtnExit_CapNhat.Text = "Thoát"
        Me.BtnExit_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit_CapNhat.UseVisualStyleBackColor = True
        '
        'btnXacNhan_GioVao
        '
        Me.btnXacNhan_GioVao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXacNhan_GioVao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXacNhan_GioVao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXacNhan_GioVao.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhan_GioVao.Location = New System.Drawing.Point(675, 124)
        Me.btnXacNhan_GioVao.Name = "btnXacNhan_GioVao"
        Me.btnXacNhan_GioVao.Size = New System.Drawing.Size(274, 48)
        Me.btnXacNhan_GioVao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXacNhan_GioVao.Symbol = ""
        Me.btnXacNhan_GioVao.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnXacNhan_GioVao.TabIndex = 478
        Me.btnXacNhan_GioVao.Text = "F3 - GIỜ RA"
        Me.btnXacNhan_GioVao.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'Super_Dgv
        '
        Me.Super_Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Super_Dgv.Location = New System.Drawing.Point(15, 345)
        Me.Super_Dgv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Super_Dgv.Name = "Super_Dgv"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Caption.AllowSelection = False
        Me.Super_Dgv.PrimaryGrid.Caption.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.BottomLeft
        Me.Super_Dgv.PrimaryGrid.Caption.EnableMarkup = False
        Me.Super_Dgv.PrimaryGrid.Caption.Text = ""
        Me.Super_Dgv.PrimaryGrid.Caption.Visible = False
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
        Me.Super_Dgv.Size = New System.Drawing.Size(527, 391)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 418
        '
        'Super_Dgv_CongDoan
        '
        Me.Super_Dgv_CongDoan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.Super_Dgv_CongDoan, 3)
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.CaptionStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Thickness4.Bottom = 1
        Thickness4.Left = 1
        Thickness4.Right = 1
        Thickness4.Top = 1
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.CaptionStyles.Default.BorderThickness = Thickness4
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.CaptionStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.CaptionStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.CaptionStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.Bottom
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.ColumnHeaderStyles.Default.AllowMultiLine = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Thickness5.Bottom = 1
        Thickness5.Left = 1
        Thickness5.Right = 1
        Thickness5.Top = 1
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.ColumnHeaderStyles.Default.BorderThickness = Thickness5
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Background3.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.FilterRowStyles.Default.FilterBackground = Background3
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.GridPanelStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.GroupByStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Background4.Color1 = System.Drawing.Color.PapayaWhip
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.HeaderStyles.Default.Background = Background4
        BorderPattern2.Bottom = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        BorderPattern2.Left = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        BorderPattern2.Right = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        BorderPattern2.Top = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.HeaderStyles.Default.BorderPattern = BorderPattern2
        Thickness6.Bottom = 1
        Thickness6.Left = 1
        Thickness6.Right = 1
        Thickness6.Top = 1
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.HeaderStyles.Default.BorderThickness = Thickness6
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.HeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_CongDoan.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_CongDoan.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square
        Me.Super_Dgv_CongDoan.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv_CongDoan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_CongDoan.Location = New System.Drawing.Point(546, 345)
        Me.Super_Dgv_CongDoan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Super_Dgv_CongDoan.Name = "Super_Dgv_CongDoan"
        '
        '
        '
        Me.Super_Dgv_CongDoan.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        '
        '
        '
        Me.Super_Dgv_CongDoan.PrimaryGrid.Caption.AllowSelection = False
        Me.Super_Dgv_CongDoan.PrimaryGrid.Caption.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.BottomLeft
        Me.Super_Dgv_CongDoan.PrimaryGrid.Caption.EnableMarkup = False
        Me.Super_Dgv_CongDoan.PrimaryGrid.Caption.Text = ""
        Me.Super_Dgv_CongDoan.PrimaryGrid.Caption.Visible = False
        Me.Super_Dgv_CongDoan.PrimaryGrid.CheckBoxSize = New System.Drawing.Size(20, 20)
        Me.Super_Dgv_CongDoan.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells
        '
        '
        '
        Me.Super_Dgv_CongDoan.PrimaryGrid.ColumnHeader.RowHeaderText = ""
        BorderColor2.Bottom = System.Drawing.Color.Black
        BorderColor2.Left = System.Drawing.Color.Black
        BorderColor2.Right = System.Drawing.Color.Black
        BorderColor2.Top = System.Drawing.Color.Black
        Me.Super_Dgv_CongDoan.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor2
        Me.Super_Dgv_CongDoan.PrimaryGrid.EnableColumnFiltering = True
        Me.Super_Dgv_CongDoan.PrimaryGrid.EnableFiltering = True
        Me.Super_Dgv_CongDoan.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.Super_Dgv_CongDoan.PrimaryGrid.Filter.RowHeight = 30
        Me.Super_Dgv_CongDoan.PrimaryGrid.Filter.Visible = True
        Me.Super_Dgv_CongDoan.PrimaryGrid.FilterExpr = ""
        '
        '
        '
        Me.Super_Dgv_CongDoan.PrimaryGrid.Footer.Text = ""
        '
        '
        '
        Me.Super_Dgv_CongDoan.PrimaryGrid.GroupByRow.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.Copy
        Me.Super_Dgv_CongDoan.PrimaryGrid.GroupByRow.Text = ""
        Me.Super_Dgv_CongDoan.PrimaryGrid.GroupByRow.WatermarkText = "Kéo cột cần xem vào đây"
        '
        '
        '
        Me.Super_Dgv_CongDoan.PrimaryGrid.Header.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.TopLeft
        Me.Super_Dgv_CongDoan.PrimaryGrid.Header.EnableMarkup = False
        Me.Super_Dgv_CongDoan.PrimaryGrid.Header.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.Always
        Me.Super_Dgv_CongDoan.PrimaryGrid.Header.Text = ""
        Me.Super_Dgv_CongDoan.PrimaryGrid.Header.Visible = False
        Me.Super_Dgv_CongDoan.PrimaryGrid.MinRowHeight = 30
        Me.Super_Dgv_CongDoan.PrimaryGrid.NoRowsText = ""
        Me.Super_Dgv_CongDoan.PrimaryGrid.ReadOnly = True
        Me.Super_Dgv_CongDoan.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.Super_Dgv_CongDoan.PrimaryGrid.RowHeaderWidth = 45
        Me.Super_Dgv_CongDoan.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.Super_Dgv_CongDoan.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.Super_Dgv_CongDoan.PrimaryGrid.Title.Text = ""
        Me.Super_Dgv_CongDoan.Size = New System.Drawing.Size(611, 391)
        Me.Super_Dgv_CongDoan.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv_CongDoan.TabIndex = 493
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(16, 3)
        Me.Panel1.Name = "Panel1"
        Me.TableLayoutPanel3.SetRowSpan(Me.Panel1, 5)
        Me.Panel1.Size = New System.Drawing.Size(525, 336)
        Me.Panel1.TabIndex = 494
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'frmTimeLine_CongDoan_GioRa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1159, 739)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimeLine_CongDoan_GioRa"
        Me.Text = "frmTimeLine_CongDoan_GioRa"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.dtNgayXacNhanRa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnExit_CapNhat As Button
    Friend WithEvents btnXacNhan_GioVao As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Timer2 As Timer
    Friend WithEvents dtNgayXacNhanRa As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents CboKetQua As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents txtsophieu_LKT As TextBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboLyDo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Super_Dgv_CongDoan As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Panel1 As Panel
End Class
