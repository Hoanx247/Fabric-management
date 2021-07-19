<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNhatKySanXuat_BanSanXuat
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
        Dim Thickness4 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness5 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Thickness6 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor2 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhatKySanXuat_BanSanXuat))
        Me.txttongkg_chung = New System.Windows.Forms.TextBox()
        Me.txttongcay_chung = New System.Windows.Forms.TextBox()
        Me.txtmame_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.btExcel_chung = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.CtxFunction = New DevComponents.DotNetBar.ButtonItem()
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonX_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.btnClear_Mame = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.ButtonItem_XacNhanVao = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_XacNhanGioRa = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_HoanThanh = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_XacNhan_HuyCongDoan = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnExport_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnTinhTheoDonVi = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_HuyXacNhan = New DevComponents.DotNetBar.ButtonItem()
        Me.Panel1.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txtmame_F
        '
        Me.txtmame_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmame_F.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtmame_F.Border.Class = "TextBoxBorder"
        Me.txtmame_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmame_F.DisabledBackColor = System.Drawing.Color.White
        Me.txtmame_F.FocusHighlightEnabled = True
        Me.txtmame_F.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.Location = New System.Drawing.Point(180, 7)
        Me.txtmame_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmame_F.Name = "txtmame_F"
        Me.txtmame_F.Size = New System.Drawing.Size(139, 35)
        Me.txtmame_F.TabIndex = 343
        Me.txtmame_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmame_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.WatermarkText = "Mã Mẻ"
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
        Thickness4.Bottom = 1
        Thickness4.Left = 1
        Thickness4.Right = 1
        Thickness4.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.BorderThickness = Thickness4
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.Bottom
        Me.Super_Dgv.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Thickness5.Bottom = 1
        Thickness5.Left = 1
        Thickness5.Right = 1
        Thickness5.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.BorderThickness = Thickness5
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Background2.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Super_Dgv.DefaultVisualStyles.FilterRowStyles.Default.FilterBackground = Background2
        Me.Super_Dgv.DefaultVisualStyles.GridPanelStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.GroupByStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.AllowMultiLine = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Thickness6.Bottom = 1
        Thickness6.Left = 1
        Thickness6.Right = 1
        Thickness6.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.BorderThickness = Thickness6
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
        Me.Super_Dgv.PrimaryGrid.Caption.Visible = False
        Me.Super_Dgv.PrimaryGrid.CheckBoxes = True
        Me.Super_Dgv.PrimaryGrid.CheckBoxSize = New System.Drawing.Size(20, 20)
        Me.Super_Dgv.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.RowHeaderText = ""
        BorderColor2.Bottom = System.Drawing.Color.Black
        BorderColor2.Left = System.Drawing.Color.Black
        BorderColor2.Right = System.Drawing.Color.Black
        BorderColor2.Top = System.Drawing.Color.Black
        Me.Super_Dgv.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor2
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
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1141, 546)
        Me.Panel1.TabIndex = 433
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu, Me.CtxMnu_Select})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(600, 121)
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
        Me.CtxFunction.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction_Refresh, Me.LabelItem3, Me.CtxFunction_Export_Excel})
        Me.CtxFunction.Text = "Function"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 11
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonX_Refresh, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClear_Mame, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame_F, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonX1, 9, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 580)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1141, 56)
        Me.TableLayoutPanel1.TabIndex = 439
        '
        'ButtonX_Refresh
        '
        Me.ButtonX_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX_Refresh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.ButtonX_Refresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.ButtonX_Refresh.Location = New System.Drawing.Point(423, 2)
        Me.ButtonX_Refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonX_Refresh.Name = "ButtonX_Refresh"
        Me.ButtonX_Refresh.PopupSide = DevComponents.DotNetBar.ePopupSide.Right
        Me.ButtonX_Refresh.Size = New System.Drawing.Size(98, 45)
        Me.ButtonX_Refresh.SplitButton = True
        Me.ButtonX_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ButtonX_Refresh.TabIndex = 434
        '
        'btnClear_Mame
        '
        Me.btnClear_Mame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear_Mame.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear_Mame.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear_Mame.Image = Global.WindowsApplication1.My.Resources.Resources._20140115025251377_easyicon_net_24
        Me.btnClear_Mame.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.btnClear_Mame.Location = New System.Drawing.Point(323, 2)
        Me.btnClear_Mame.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear_Mame.Name = "btnClear_Mame"
        Me.btnClear_Mame.PopupSide = DevComponents.DotNetBar.ePopupSide.Right
        Me.btnClear_Mame.Size = New System.Drawing.Size(96, 45)
        Me.btnClear_Mame.SplitButton = True
        Me.btnClear_Mame.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.btnClear_Mame.TabIndex = 433
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(169, 31)
        Me.LabelX1.TabIndex = 433
        Me.LabelX1.Text = "NHẬP MÃ MẺ:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(954, 3)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(164, 43)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX1.SymbolSize = 20.0!
        Me.ButtonX1.TabIndex = 459
        Me.ButtonX1.Text = "THOÁT"
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
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_XacNhanVao, Me.ButtonItem_XacNhanGioRa, Me.ButtonItem_HoanThanh, Me.ButtonItem_XacNhan_HuyCongDoan, Me.BtnExport_Excel, Me.BtnTinhTheoDonVi})
        Me.ItemPanel1.ItemSpacing = 5
        Me.ItemPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(1141, 34)
        Me.ItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.ItemPanel1.TabIndex = 458
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'ButtonItem_XacNhanVao
        '
        Me.ButtonItem_XacNhanVao.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_XacNhanVao.Name = "ButtonItem_XacNhanVao"
        Me.ButtonItem_XacNhanVao.Symbol = ""
        Me.ButtonItem_XacNhanVao.SymbolColor = System.Drawing.Color.Blue
        Me.ButtonItem_XacNhanVao.Text = "Xác Nhận Giờ Vào"
        '
        'ButtonItem_XacNhanGioRa
        '
        Me.ButtonItem_XacNhanGioRa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_XacNhanGioRa.Name = "ButtonItem_XacNhanGioRa"
        Me.ButtonItem_XacNhanGioRa.Symbol = ""
        Me.ButtonItem_XacNhanGioRa.Text = "Xác Nhận Giờ Ra"
        '
        'ButtonItem_HoanThanh
        '
        Me.ButtonItem_HoanThanh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_HoanThanh.Name = "ButtonItem_HoanThanh"
        Me.ButtonItem_HoanThanh.Symbol = ""
        Me.ButtonItem_HoanThanh.Text = "Xác nhận hoàn thành"
        '
        'ButtonItem_XacNhan_HuyCongDoan
        '
        Me.ButtonItem_XacNhan_HuyCongDoan.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_XacNhan_HuyCongDoan.Name = "ButtonItem_XacNhan_HuyCongDoan"
        Me.ButtonItem_XacNhan_HuyCongDoan.Symbol = "59545"
        Me.ButtonItem_XacNhan_HuyCongDoan.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem_XacNhan_HuyCongDoan.Text = "Xác Nhận Hủy Công Đoạn"
        '
        'BtnExport_Excel
        '
        Me.BtnExport_Excel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnExport_Excel.Name = "BtnExport_Excel"
        Me.BtnExport_Excel.Symbol = ""
        Me.BtnExport_Excel.Text = "Xuất Excel"
        '
        'BtnTinhTheoDonVi
        '
        Me.BtnTinhTheoDonVi.AutoExpandOnClick = True
        Me.BtnTinhTheoDonVi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnTinhTheoDonVi.Name = "BtnTinhTheoDonVi"
        Me.BtnTinhTheoDonVi.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_HuyXacNhan})
        Me.BtnTinhTheoDonVi.Symbol = ""
        Me.BtnTinhTheoDonVi.Text = "Tính Năng"
        '
        'ButtonItem_HuyXacNhan
        '
        Me.ButtonItem_HuyXacNhan.Name = "ButtonItem_HuyXacNhan"
        Me.ButtonItem_HuyXacNhan.Text = "Hủy Xác Nhận"
        '
        'frmNhatKySanXuat_BanSanXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1141, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmNhatKySanXuat_BanSanXuat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xác Nhận"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txttongkg_chung As System.Windows.Forms.TextBox
    Friend WithEvents txttongcay_chung As System.Windows.Forms.TextBox
    Friend WithEvents btExcel_chung As System.Windows.Forms.Button
    Friend WithEvents txtmame_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents CtxFunction As DevComponents.DotNetBar.ButtonItem
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents btnClear_Mame As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents ButtonItem_XacNhanVao As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_XacNhanGioRa As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_HoanThanh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_XacNhan_HuyCongDoan As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnExport_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnTinhTheoDonVi As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_HuyXacNhan As DevComponents.DotNetBar.ButtonItem
End Class
