<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_mahang
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
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_mahang))
        Me.txtloaihang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmahang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GP_Form_May = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboKhachHang = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_Update_KhachHang = New System.Windows.Forms.Button()
        Me.BtnExit_Form_KhachHang = New System.Windows.Forms.Button()
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
        Me.CtxMnuSelect = New DevComponents.DotNetBar.ButtonItem()
        Me.mnu_Select_All = New DevComponents.DotNetBar.ButtonItem()
        Me.mnu_Remove_ALL = New DevComponents.DotNetBar.ButtonItem()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.btnThutuCot = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.btnCopy = New DevComponents.DotNetBar.ButtonItem()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonItem()
        Me.btnModify = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnExport_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnLuuThayDoi = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnTinhTheoDonVi = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnTinhTheoKg = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnTinhTheoMet = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnMnu_KhachHang = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Nen = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Rib = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_BoCo = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_BoTay = New DevComponents.DotNetBar.ButtonItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtGhichu_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtkhachhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1.SuspendLayout()
        Me.GP_Form_May.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtloaihang_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtloaihang_F.Location = New System.Drawing.Point(243, 3)
        Me.txtloaihang_F.Name = "txtloaihang_F"
        Me.txtloaihang_F.Size = New System.Drawing.Size(114, 24)
        Me.txtloaihang_F.TabIndex = 291
        Me.txtloaihang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.WatermarkText = "Loại Hàng"
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
        Me.txtmahang_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtmahang_F.Location = New System.Drawing.Point(3, 3)
        Me.txtmahang_F.Name = "txtmahang_F"
        Me.txtmahang_F.Size = New System.Drawing.Size(114, 24)
        Me.txtmahang_F.TabIndex = 225
        Me.txtmahang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.WatermarkText = "Mã Hàng"
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
        Me.Super_Dgv.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square
        Me.Super_Dgv.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.Location = New System.Drawing.Point(83, 51)
        Me.Super_Dgv.Name = "Super_Dgv"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        Me.Super_Dgv.PrimaryGrid.AllowEdit = False
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
        Me.Super_Dgv.PrimaryGrid.GroupByRow.Visible = True
        Me.Super_Dgv.PrimaryGrid.GroupByRow.WatermarkText = "Kéo cột cần xem vào đây"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Header.Text = ""
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
        Me.Super_Dgv.Size = New System.Drawing.Size(244, 136)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 416
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GP_Form_May)
        Me.Panel1.Controls.Add(Me.ContextMenuBar1)
        Me.Panel1.Controls.Add(Me.CircularProgress1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 539)
        Me.Panel1.TabIndex = 417
        '
        'GP_Form_May
        '
        Me.GP_Form_May.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form_May.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form_May.Controls.Add(Me.TableLayoutPanel5)
        Me.GP_Form_May.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form_May.Location = New System.Drawing.Point(263, 144)
        Me.GP_Form_May.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form_May.Name = "GP_Form_May"
        Me.GP_Form_May.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form_May.Size = New System.Drawing.Size(494, 177)
        '
        '
        '
        Me.GP_Form_May.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form_May.Style.BackColorGradientAngle = 90
        Me.GP_Form_May.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form_May.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_May.Style.BorderBottomWidth = 1
        Me.GP_Form_May.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form_May.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_May.Style.BorderLeftWidth = 1
        Me.GP_Form_May.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_May.Style.BorderRightWidth = 1
        Me.GP_Form_May.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_May.Style.BorderTopWidth = 1
        Me.GP_Form_May.Style.CornerDiameter = 4
        Me.GP_Form_May.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form_May.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form_May.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form_May.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form_May.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form_May.TabIndex = 463
        Me.GP_Form_May.Text = "Cập Nhật Khách Hàng"
        Me.GP_Form_May.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form_May.Visible = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.cboKhachHang, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Btn_Update_KhachHang, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.BtnExit_Form_KhachHang, 2, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(464, 149)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'cboKhachHang
        '
        Me.cboKhachHang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.SetColumnSpan(Me.cboKhachHang, 2)
        Me.cboKhachHang.DisplayMember = "Text"
        Me.cboKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKhachHang.FocusHighlightEnabled = True
        Me.cboKhachHang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKhachHang.FormattingEnabled = True
        Me.cboKhachHang.ItemHeight = 24
        Me.cboKhachHang.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem5})
        Me.cboKhachHang.Location = New System.Drawing.Point(127, 30)
        Me.cboKhachHang.Margin = New System.Windows.Forms.Padding(2)
        Me.cboKhachHang.Name = "cboKhachHang"
        Me.cboKhachHang.Size = New System.Drawing.Size(335, 30)
        Me.cboKhachHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.cboKhachHang.TabIndex = 453
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Theo Công Đoạn"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Theo Mã Hàng"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 18)
        Me.Label10.TabIndex = 523
        Me.Label10.Text = "KHÁCH HÀNG"
        '
        'Btn_Update_KhachHang
        '
        Me.Btn_Update_KhachHang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Update_KhachHang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update_KhachHang.Image = CType(resources.GetObject("Btn_Update_KhachHang.Image"), System.Drawing.Image)
        Me.Btn_Update_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Update_KhachHang.Location = New System.Drawing.Point(129, 83)
        Me.Btn_Update_KhachHang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Update_KhachHang.Name = "Btn_Update_KhachHang"
        Me.Btn_Update_KhachHang.Size = New System.Drawing.Size(149, 55)
        Me.Btn_Update_KhachHang.TabIndex = 453
        Me.Btn_Update_KhachHang.Text = "Cập Nhật"
        Me.Btn_Update_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Update_KhachHang.UseVisualStyleBackColor = True
        '
        'BtnExit_Form_KhachHang
        '
        Me.BtnExit_Form_KhachHang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit_Form_KhachHang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit_Form_KhachHang.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnExit_Form_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit_Form_KhachHang.Location = New System.Drawing.Point(287, 85)
        Me.BtnExit_Form_KhachHang.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnExit_Form_KhachHang.Name = "BtnExit_Form_KhachHang"
        Me.BtnExit_Form_KhachHang.Size = New System.Drawing.Size(172, 51)
        Me.BtnExit_Form_KhachHang.TabIndex = 454
        Me.BtnExit_Form_KhachHang.Text = "Thoát"
        Me.BtnExit_Form_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit_Form_KhachHang.UseVisualStyleBackColor = True
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu, Me.CtxMnuSelect})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(106, 234)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(185, 47)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 434
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
        'CtxMnuSelect
        '
        Me.CtxMnuSelect.AutoExpandOnClick = True
        Me.CtxMnuSelect.Name = "CtxMnuSelect"
        Me.CtxMnuSelect.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnu_Select_All, Me.mnu_Remove_ALL})
        Me.CtxMnuSelect.Text = "Select All"
        '
        'mnu_Select_All
        '
        Me.mnu_Select_All.Name = "mnu_Select_All"
        Me.mnu_Select_All.Text = "Chọn hết"
        '
        'mnu_Remove_ALL
        '
        Me.mnu_Remove_ALL.Name = "mnu_Remove_ALL"
        Me.mnu_Remove_ALL.Text = "Bỏ Chọn"
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
        Me.CircularProgress1.Location = New System.Drawing.Point(523, 51)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(144, 111)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 433
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
        'ItemPanel1
        '
        Me.ItemPanel1.BackColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.ItemPanel1.BackgroundStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ItemPanel1.BackgroundStyle.Class = "ItemPanel"
        Me.ItemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemPanel1.ContainerControlProcessDialogKey = True
        Me.ItemPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ItemPanel1.DragDropSupport = True
        Me.ItemPanel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnCopy, Me.btnAdd, Me.btnModify, Me.btnDelete, Me.BtnExport_Excel, Me.BtnLuuThayDoi, Me.BtnTinhTheoDonVi})
        Me.ItemPanel1.ItemSpacing = 5
        Me.ItemPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(1055, 34)
        Me.ItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ItemPanel1.TabIndex = 438
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'btnCopy
        '
        Me.btnCopy.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Symbol = "57677"
        Me.btnCopy.SymbolColor = System.Drawing.Color.Blue
        Me.btnCopy.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.btnCopy.Text = "Sao Chép"
        '
        'btnAdd
        '
        Me.btnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Symbol = "57404"
        Me.btnAdd.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.btnAdd.Text = "Thêm Mới"
        '
        'btnModify
        '
        Me.btnModify.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Symbol = ""
        Me.btnModify.Text = "Chỉnh Sửa"
        '
        'btnDelete
        '
        Me.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Symbol = ""
        Me.btnDelete.Text = "Xóa"
        '
        'BtnExport_Excel
        '
        Me.BtnExport_Excel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnExport_Excel.Name = "BtnExport_Excel"
        Me.BtnExport_Excel.Symbol = ""
        Me.BtnExport_Excel.Text = "Xuất Excel"
        '
        'BtnLuuThayDoi
        '
        Me.BtnLuuThayDoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnLuuThayDoi.Name = "BtnLuuThayDoi"
        Me.BtnLuuThayDoi.Symbol = ""
        Me.BtnLuuThayDoi.Text = "Lưu Thay Đổi"
        '
        'BtnTinhTheoDonVi
        '
        Me.BtnTinhTheoDonVi.AutoExpandOnClick = True
        Me.BtnTinhTheoDonVi.Name = "BtnTinhTheoDonVi"
        Me.BtnTinhTheoDonVi.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnTinhTheoKg, Me.BtnTinhTheoMet, Me.BtnMnu_KhachHang, Me.ButtonItem_Nen, Me.ButtonItem_Rib, Me.ButtonItem_BoCo, Me.ButtonItem_BoTay})
        Me.BtnTinhTheoDonVi.Text = "Tính Theo Đơn Vị"
        '
        'BtnTinhTheoKg
        '
        Me.BtnTinhTheoKg.Name = "BtnTinhTheoKg"
        Me.BtnTinhTheoKg.Text = "Tính Theo Kg"
        '
        'BtnTinhTheoMet
        '
        Me.BtnTinhTheoMet.Name = "BtnTinhTheoMet"
        Me.BtnTinhTheoMet.Text = "Tính Theo Mét"
        '
        'BtnMnu_KhachHang
        '
        Me.BtnMnu_KhachHang.Name = "BtnMnu_KhachHang"
        Me.BtnMnu_KhachHang.Text = "Cập Nhật Khách Hàng"
        '
        'ButtonItem_Nen
        '
        Me.ButtonItem_Nen.Name = "ButtonItem_Nen"
        Me.ButtonItem_Nen.Text = "NỀN"
        '
        'ButtonItem_Rib
        '
        Me.ButtonItem_Rib.Name = "ButtonItem_Rib"
        Me.ButtonItem_Rib.Text = "RIB"
        '
        'ButtonItem_BoCo
        '
        Me.ButtonItem_BoCo.Name = "ButtonItem_BoCo"
        Me.ButtonItem_BoCo.Text = "BO CỔ"
        '
        'ButtonItem_BoTay
        '
        Me.ButtonItem_BoTay.Name = "ButtonItem_BoTay"
        Me.ButtonItem_BoTay.Text = "BO TAY"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtloaihang_F, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGhichu_F, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang_F, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmahang_F, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 573)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1055, 38)
        Me.TableLayoutPanel1.TabIndex = 442
        '
        'txtGhichu_F
        '
        Me.txtGhichu_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtGhichu_F.Border.Class = "TextBoxBorder"
        Me.txtGhichu_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtGhichu_F.FocusHighlightEnabled = True
        Me.txtGhichu_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtGhichu_F.Location = New System.Drawing.Point(494, 3)
        Me.txtGhichu_F.Name = "txtGhichu_F"
        Me.txtGhichu_F.Size = New System.Drawing.Size(135, 24)
        Me.txtGhichu_F.TabIndex = 229
        Me.txtGhichu_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhichu_F.WatermarkText = "Ghi Chú"
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
        Me.txtkhachhang_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtkhachhang_F.Location = New System.Drawing.Point(123, 3)
        Me.txtkhachhang_F.Name = "txtkhachhang_F"
        Me.txtkhachhang_F.Size = New System.Drawing.Size(114, 24)
        Me.txtkhachhang_F.TabIndex = 225
        Me.txtkhachhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.WatermarkText = "Khách Hàng"
        '
        'List_mahang
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1055, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "List_mahang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loại Hàng"
        Me.Panel1.ResumeLayout(False)
        Me.GP_Form_May.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtloaihang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmahang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnThutuCot As DevComponents.DotNetBar.ButtonItem
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
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents btnCopy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnModify As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnExport_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnLuuThayDoi As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnTinhTheoDonVi As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnTinhTheoKg As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnTinhTheoMet As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GP_Form_May As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents cboKhachHang As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents Label10 As Label
    Friend WithEvents Btn_Update_KhachHang As Button
    Friend WithEvents BtnExit_Form_KhachHang As Button
    Friend WithEvents BtnMnu_KhachHang As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMnuSelect As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnu_Select_All As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnu_Remove_ALL As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtGhichu_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtkhachhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonItem_Nen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Rib As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_BoCo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_BoTay As DevComponents.DotNetBar.ButtonItem
End Class
