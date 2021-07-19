<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDieuDoSanXuat_InPhieuNhuom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDieuDoSanXuat_InPhieuNhuom))
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.btnInphieu = New System.Windows.Forms.Button()
        Me.lblsophieu = New System.Windows.Forms.Label()
        Me.txtmame = New System.Windows.Forms.TextBox()
        Me.txtmame_ghep = New System.Windows.Forms.TextBox()
        Me.ChkInMet = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GP_Form_ChungTuXuat = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtNgayXuat_SX = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnThoat_GP_Form_CTXuat = New System.Windows.Forms.Button()
        Me.BtnCapNhat_XuatSX = New System.Windows.Forms.Button()
        Me.txtchungtuxuat = New System.Windows.Forms.TextBox()
        Me.cboKieuXuat = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtmacongnghe = New System.Windows.Forms.TextBox()
        Me.txtngayXuat_SanXuat = New System.Windows.Forms.TextBox()
        Me.BtnXacNhan_SanXuat = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Super_Dgv_Info = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.GroupBox2.SuspendLayout()
        Me.GP_Form_ChungTuXuat.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.dtNgayXuat_SX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInphieu
        '
        Me.btnInphieu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInphieu.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnInphieu.Location = New System.Drawing.Point(341, 42)
        Me.btnInphieu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInphieu.Name = "btnInphieu"
        Me.btnInphieu.Size = New System.Drawing.Size(133, 28)
        Me.btnInphieu.TabIndex = 300
        Me.btnInphieu.Text = "IN PHIẾU (F12)"
        Me.btnInphieu.UseVisualStyleBackColor = True
        '
        'lblsophieu
        '
        Me.lblsophieu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblsophieu.AutoSize = True
        Me.lblsophieu.BackColor = System.Drawing.Color.Transparent
        Me.lblsophieu.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsophieu.ForeColor = System.Drawing.Color.DarkRed
        Me.lblsophieu.Location = New System.Drawing.Point(3, 45)
        Me.lblsophieu.Name = "lblsophieu"
        Me.lblsophieu.Size = New System.Drawing.Size(201, 22)
        Me.lblsophieu.TabIndex = 284
        Me.lblsophieu.Text = "NHẬP MÃ MẺ CẦN IN"
        '
        'txtmame
        '
        Me.txtmame.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmame.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtmame.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmame.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtmame.Location = New System.Drawing.Point(3, 77)
        Me.txtmame.Name = "txtmame"
        Me.txtmame.Size = New System.Drawing.Size(201, 29)
        Me.txtmame.TabIndex = 283
        '
        'txtmame_ghep
        '
        Me.txtmame_ghep.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmame_ghep.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtmame_ghep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmame_ghep, 3)
        Me.txtmame_ghep.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_ghep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtmame_ghep.Location = New System.Drawing.Point(210, 77)
        Me.txtmame_ghep.Name = "txtmame_ghep"
        Me.txtmame_ghep.Size = New System.Drawing.Size(441, 29)
        Me.txtmame_ghep.TabIndex = 333
        '
        'ChkInMet
        '
        Me.ChkInMet.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ChkInMet.AutoSize = True
        '
        '
        '
        Me.ChkInMet.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkInMet.CheckSignSize = New System.Drawing.Size(25, 25)
        Me.ChkInMet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkInMet.Location = New System.Drawing.Point(209, 42)
        Me.ChkInMet.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkInMet.Name = "ChkInMet"
        Me.ChkInMet.Size = New System.Drawing.Size(118, 27)
        Me.ChkInMet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkInMet.TabIndex = 328
        Me.ChkInMet.Text = "IN SỐ MÉT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GP_Form_ChungTuXuat)
        Me.GroupBox2.Controls.Add(Me.Super_Dgv)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(504, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(582, 547)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chi Tiết Mẻ Nhuộm"
        '
        'GP_Form_ChungTuXuat
        '
        Me.GP_Form_ChungTuXuat.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form_ChungTuXuat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form_ChungTuXuat.Controls.Add(Me.TableLayoutPanel5)
        Me.GP_Form_ChungTuXuat.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form_ChungTuXuat.Location = New System.Drawing.Point(101, 184)
        Me.GP_Form_ChungTuXuat.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form_ChungTuXuat.Name = "GP_Form_ChungTuXuat"
        Me.GP_Form_ChungTuXuat.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form_ChungTuXuat.Size = New System.Drawing.Size(430, 196)
        '
        '
        '
        Me.GP_Form_ChungTuXuat.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form_ChungTuXuat.Style.BackColorGradientAngle = 90
        Me.GP_Form_ChungTuXuat.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form_ChungTuXuat.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_ChungTuXuat.Style.BorderBottomWidth = 1
        Me.GP_Form_ChungTuXuat.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form_ChungTuXuat.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_ChungTuXuat.Style.BorderLeftWidth = 1
        Me.GP_Form_ChungTuXuat.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_ChungTuXuat.Style.BorderRightWidth = 1
        Me.GP_Form_ChungTuXuat.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_ChungTuXuat.Style.BorderTopWidth = 1
        Me.GP_Form_ChungTuXuat.Style.CornerDiameter = 4
        Me.GP_Form_ChungTuXuat.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form_ChungTuXuat.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form_ChungTuXuat.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form_ChungTuXuat.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form_ChungTuXuat.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form_ChungTuXuat.TabIndex = 454
        Me.GP_Form_ChungTuXuat.Text = "Cập Nhật Xuất Sản Xuất"
        Me.GP_Form_ChungTuXuat.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form_ChungTuXuat.Visible = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.dtNgayXuat_SX, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.btnThoat_GP_Form_CTXuat, 2, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.BtnCapNhat_XuatSX, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.txtchungtuxuat, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cboKieuXuat, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(400, 172)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'dtNgayXuat_SX
        '
        Me.dtNgayXuat_SX.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtNgayXuat_SX.AutoSelectDate = True
        '
        '
        '
        Me.dtNgayXuat_SX.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtNgayXuat_SX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXuat_SX.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtNgayXuat_SX.ButtonDropDown.Visible = True
        Me.dtNgayXuat_SX.CustomFormat = "dd/MM/yy"
        Me.dtNgayXuat_SX.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector
        Me.dtNgayXuat_SX.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtNgayXuat_SX.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtNgayXuat_SX.IsPopupCalendarOpen = False
        Me.dtNgayXuat_SX.Location = New System.Drawing.Point(104, 73)
        Me.dtNgayXuat_SX.Margin = New System.Windows.Forms.Padding(2)
        '
        '
        '
        '
        '
        '
        Me.dtNgayXuat_SX.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXuat_SX.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtNgayXuat_SX.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXuat_SX.MonthCalendar.DisplayMonth = New Date(2014, 11, 1, 0, 0, 0, 0)
        Me.dtNgayXuat_SX.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtNgayXuat_SX.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtNgayXuat_SX.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtNgayXuat_SX.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtNgayXuat_SX.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXuat_SX.MonthCalendar.TodayButtonVisible = True
        Me.dtNgayXuat_SX.Name = "dtNgayXuat_SX"
        Me.dtNgayXuat_SX.ShowUpDown = True
        Me.dtNgayXuat_SX.Size = New System.Drawing.Size(141, 28)
        Me.dtNgayXuat_SX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtNgayXuat_SX.TabIndex = 492
        Me.dtNgayXuat_SX.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dtNgayXuat_SX.WatermarkText = "Từ ngày"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(12, 78)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 18)
        Me.Label12.TabIndex = 493
        Me.Label12.Text = "Ngày Xuất"
        '
        'btnThoat_GP_Form_CTXuat
        '
        Me.btnThoat_GP_Form_CTXuat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat_GP_Form_CTXuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat_GP_Form_CTXuat.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.btnThoat_GP_Form_CTXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat_GP_Form_CTXuat.Location = New System.Drawing.Point(252, 110)
        Me.btnThoat_GP_Form_CTXuat.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThoat_GP_Form_CTXuat.Name = "btnThoat_GP_Form_CTXuat"
        Me.btnThoat_GP_Form_CTXuat.Size = New System.Drawing.Size(143, 43)
        Me.btnThoat_GP_Form_CTXuat.TabIndex = 454
        Me.btnThoat_GP_Form_CTXuat.Text = "Thoát"
        Me.btnThoat_GP_Form_CTXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat_GP_Form_CTXuat.UseVisualStyleBackColor = True
        '
        'BtnCapNhat_XuatSX
        '
        Me.BtnCapNhat_XuatSX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCapNhat_XuatSX.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCapNhat_XuatSX.Image = CType(resources.GetObject("BtnCapNhat_XuatSX.Image"), System.Drawing.Image)
        Me.BtnCapNhat_XuatSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCapNhat_XuatSX.Location = New System.Drawing.Point(106, 108)
        Me.BtnCapNhat_XuatSX.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCapNhat_XuatSX.Name = "BtnCapNhat_XuatSX"
        Me.BtnCapNhat_XuatSX.Size = New System.Drawing.Size(137, 47)
        Me.BtnCapNhat_XuatSX.TabIndex = 453
        Me.BtnCapNhat_XuatSX.Text = "Cập Nhật"
        Me.BtnCapNhat_XuatSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCapNhat_XuatSX.UseVisualStyleBackColor = True
        '
        'txtchungtuxuat
        '
        Me.txtchungtuxuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtchungtuxuat.BackColor = System.Drawing.Color.White
        Me.txtchungtuxuat.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtchungtuxuat.Location = New System.Drawing.Point(107, 40)
        Me.txtchungtuxuat.Margin = New System.Windows.Forms.Padding(5)
        Me.txtchungtuxuat.Name = "txtchungtuxuat"
        Me.txtchungtuxuat.Size = New System.Drawing.Size(135, 28)
        Me.txtchungtuxuat.TabIndex = 488
        '
        'cboKieuXuat
        '
        Me.cboKieuXuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.SetColumnSpan(Me.cboKieuXuat, 2)
        Me.cboKieuXuat.DisplayMember = "Text"
        Me.cboKieuXuat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKieuXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKieuXuat.FocusHighlightEnabled = True
        Me.cboKieuXuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKieuXuat.FormattingEnabled = True
        Me.cboKieuXuat.ItemHeight = 20
        Me.cboKieuXuat.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10})
        Me.cboKieuXuat.Location = New System.Drawing.Point(104, 4)
        Me.cboKieuXuat.Margin = New System.Windows.Forms.Padding(2)
        Me.cboKieuXuat.Name = "cboKieuXuat"
        Me.cboKieuXuat.Size = New System.Drawing.Size(294, 26)
        Me.cboKieuXuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboKieuXuat.TabIndex = 491
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Vải"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Bo"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(21, 8)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 18)
        Me.Label14.TabIndex = 489
        Me.Label14.Text = "Mục Đích"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(19, 43)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 18)
        Me.Label13.TabIndex = 490
        Me.Label13.Text = "Chứng Từ"
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
        Me.Super_Dgv.Location = New System.Drawing.Point(119, 42)
        Me.Super_Dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.Super_Dgv.Name = "Super_Dgv"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        Me.Super_Dgv.PrimaryGrid.AllowEdit = False
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
        Me.Super_Dgv.PrimaryGrid.CollapseImage = Global.WindowsApplication1.My.Resources.Resources.add_item
        Me.Super_Dgv.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.MinRowHeight = 40
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.RowHeaderText = ""
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.RowHeight = 40
        BorderColor1.Bottom = System.Drawing.Color.Black
        BorderColor1.Left = System.Drawing.Color.Black
        BorderColor1.Right = System.Drawing.Color.Black
        BorderColor1.Top = System.Drawing.Color.Black
        Me.Super_Dgv.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor1
        Me.Super_Dgv.PrimaryGrid.EnableColumnFiltering = True
        Me.Super_Dgv.PrimaryGrid.EnableFiltering = True
        Me.Super_Dgv.PrimaryGrid.EnableRowFiltering = True
        Me.Super_Dgv.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Circle
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
        Me.Super_Dgv.PrimaryGrid.GroupByRow.WatermarkText = "Kéo cột cần xem vào đây"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Header.Text = ""
        Me.Super_Dgv.PrimaryGrid.Header.Visible = False
        Me.Super_Dgv.PrimaryGrid.MinRowHeight = 30
        Me.Super_Dgv.PrimaryGrid.NoRowsText = ""
        Me.Super_Dgv.PrimaryGrid.ReadOnly = True
        Me.Super_Dgv.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.Super_Dgv.PrimaryGrid.RowHeaderWidth = 30
        Me.Super_Dgv.PrimaryGrid.RowHighlightType = DevComponents.DotNetBar.SuperGrid.RowHighlightType.None
        Me.Super_Dgv.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.Super_Dgv.PrimaryGrid.Title.Text = ""
        Me.Super_Dgv.Size = New System.Drawing.Size(202, 103)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 455
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabIndex = -1
        Me.SuperTabControl1.Size = New System.Drawing.Size(200, 100)
        Me.SuperTabControl1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtmacongnghe, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtngayXuat_SanXuat, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInphieu, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblsophieu, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnXacNhan_SanXuat, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame_ghep, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkInMet, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 547)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1086, 119)
        Me.TableLayoutPanel1.TabIndex = 310
        '
        'txtmacongnghe
        '
        Me.txtmacongnghe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmacongnghe.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtmacongnghe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmacongnghe, 7)
        Me.txtmacongnghe.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmacongnghe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtmacongnghe.Location = New System.Drawing.Point(3, 5)
        Me.txtmacongnghe.Name = "txtmacongnghe"
        Me.txtmacongnghe.Size = New System.Drawing.Size(1080, 29)
        Me.txtmacongnghe.TabIndex = 456
        '
        'txtngayXuat_SanXuat
        '
        Me.txtngayXuat_SanXuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtngayXuat_SanXuat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtngayXuat_SanXuat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtngayXuat_SanXuat.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtngayXuat_SanXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtngayXuat_SanXuat.Location = New System.Drawing.Point(657, 77)
        Me.txtngayXuat_SanXuat.Name = "txtngayXuat_SanXuat"
        Me.txtngayXuat_SanXuat.Size = New System.Drawing.Size(202, 29)
        Me.txtngayXuat_SanXuat.TabIndex = 334
        '
        'BtnXacNhan_SanXuat
        '
        Me.BtnXacNhan_SanXuat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnXacNhan_SanXuat.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtnXacNhan_SanXuat.Location = New System.Drawing.Point(656, 42)
        Me.BtnXacNhan_SanXuat.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnXacNhan_SanXuat.Name = "BtnXacNhan_SanXuat"
        Me.BtnXacNhan_SanXuat.Size = New System.Drawing.Size(204, 28)
        Me.BtnXacNhan_SanXuat.TabIndex = 335
        Me.BtnXacNhan_SanXuat.Text = "Xuất Đi Sản Xuất"
        Me.BtnXacNhan_SanXuat.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Super_Dgv_Info)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 547)
        Me.GroupBox1.TabIndex = 311
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "THÔNG TIN MẺ NHUỘM"
        '
        'Super_Dgv_Info
        '
        Me.Super_Dgv_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Super_Dgv_Info.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv_Info.Location = New System.Drawing.Point(3, 19)
        Me.Super_Dgv_Info.Name = "Super_Dgv_Info"
        '
        '
        '
        Me.Super_Dgv_Info.PrimaryGrid.AllowSelection = False
        Me.Super_Dgv_Info.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.Super_Dgv_Info.Size = New System.Drawing.Size(498, 525)
        Me.Super_Dgv_Info.TabIndex = 2
        Me.Super_Dgv_Info.Tag = "1"
        Me.Super_Dgv_Info.Text = "SuperGridControl1"
        '
        'frmDieuDoSanXuat_InPhieuNhuom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1086, 666)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmDieuDoSanXuat_InPhieuNhuom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IN PHIẾU NHUỘM"
        Me.GroupBox2.ResumeLayout(False)
        Me.GP_Form_ChungTuXuat.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.dtNgayXuat_SX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblsophieu As System.Windows.Forms.Label
    Friend WithEvents txtmame As System.Windows.Forms.TextBox
    Friend WithEvents btnInphieu As System.Windows.Forms.Button
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkInMet As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtmame_ghep As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtngayXuat_SanXuat As TextBox
    Friend WithEvents BtnXacNhan_SanXuat As Button
    Friend WithEvents GP_Form_ChungTuXuat As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents dtNgayXuat_SX As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label12 As Label
    Friend WithEvents btnThoat_GP_Form_CTXuat As Button
    Friend WithEvents BtnCapNhat_XuatSX As Button
    Friend WithEvents txtchungtuxuat As TextBox
    Friend WithEvents cboKieuXuat As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Super_Dgv_Info As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents txtmacongnghe As TextBox
End Class
