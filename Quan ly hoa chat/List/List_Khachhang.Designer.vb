<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_Khachhang
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
        Me.txtGhichu_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnguoilienhe_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnganhnghe_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdiachi_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtkhachhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.btnCopy = New DevComponents.DotNetBar.ButtonItem()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonItem()
        Me.btnModify = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnExport_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnLuuThayDoi = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnTinhTheoDonVi = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_NhomKhach = New DevComponents.DotNetBar.ButtonItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonItem_Nhom = New DevComponents.DotNetBar.ButtonItem()
        Me.Panel1.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'txtnguoilienhe_F
        '
        Me.txtnguoilienhe_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtnguoilienhe_F.Border.Class = "TextBoxBorder"
        Me.txtnguoilienhe_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnguoilienhe_F.FocusHighlightEnabled = True
        Me.txtnguoilienhe_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtnguoilienhe_F.Location = New System.Drawing.Point(363, 3)
        Me.txtnguoilienhe_F.Name = "txtnguoilienhe_F"
        Me.txtnguoilienhe_F.Size = New System.Drawing.Size(125, 24)
        Me.txtnguoilienhe_F.TabIndex = 228
        Me.txtnguoilienhe_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnguoilienhe_F.WatermarkText = "Người Liên Hệ"
        '
        'txtnganhnghe_F
        '
        Me.txtnganhnghe_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtnganhnghe_F.Border.Class = "TextBoxBorder"
        Me.txtnganhnghe_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtnganhnghe_F.FocusHighlightEnabled = True
        Me.txtnganhnghe_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtnganhnghe_F.Location = New System.Drawing.Point(243, 3)
        Me.txtnganhnghe_F.Name = "txtnganhnghe_F"
        Me.txtnganhnghe_F.Size = New System.Drawing.Size(114, 24)
        Me.txtnganhnghe_F.TabIndex = 227
        Me.txtnganhnghe_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnganhnghe_F.WatermarkText = "Ngành Nghề"
        '
        'txtdiachi_F
        '
        Me.txtdiachi_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtdiachi_F.Border.Class = "TextBoxBorder"
        Me.txtdiachi_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdiachi_F.FocusHighlightEnabled = True
        Me.txtdiachi_F.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtdiachi_F.Location = New System.Drawing.Point(123, 3)
        Me.txtdiachi_F.Name = "txtdiachi_F"
        Me.txtdiachi_F.Size = New System.Drawing.Size(114, 24)
        Me.txtdiachi_F.TabIndex = 226
        Me.txtdiachi_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi_F.WatermarkText = "Địa chỉ"
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
        Me.txtkhachhang_F.Location = New System.Drawing.Point(3, 3)
        Me.txtkhachhang_F.Name = "txtkhachhang_F"
        Me.txtkhachhang_F.Size = New System.Drawing.Size(114, 24)
        Me.txtkhachhang_F.TabIndex = 225
        Me.txtkhachhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.WatermarkText = "Khách Hàng"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ContextMenuBar1)
        Me.Panel1.Controls.Add(Me.CircularProgress1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1058, 466)
        Me.Panel1.TabIndex = 410
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(179, 280)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(440, 25)
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
        Me.CircularProgress1.Location = New System.Drawing.Point(237, 161)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(141, 113)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 433
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
        Me.Super_Dgv.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square
        Me.Super_Dgv.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.Location = New System.Drawing.Point(211, 112)
        Me.Super_Dgv.Name = "Super_Dgv"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        Me.Super_Dgv.PrimaryGrid.AllowEdit = False
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
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.RowHeaderText = ""
        BorderColor1.Bottom = System.Drawing.Color.Black
        BorderColor1.Left = System.Drawing.Color.Black
        BorderColor1.Right = System.Drawing.Color.Black
        BorderColor1.Top = System.Drawing.Color.Black
        Me.Super_Dgv.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor1
        Me.Super_Dgv.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Super_Dgv.TabIndex = 414
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
        Me.ItemPanel1.Size = New System.Drawing.Size(1058, 34)
        Me.ItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ItemPanel1.TabIndex = 439
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
        Me.BtnTinhTheoDonVi.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_NhomKhach})
        Me.BtnTinhTheoDonVi.Text = "Khác"
        '
        'ButtonItem_NhomKhach
        '
        Me.ButtonItem_NhomKhach.Name = "ButtonItem_NhomKhach"
        Me.ButtonItem_NhomKhach.Text = "Nhóm Khách"
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
        Me.TableLayoutPanel1.Controls.Add(Me.txtGhichu_F, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang_F, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtnguoilienhe_F, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdiachi_F, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtnganhnghe_F, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 500)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1058, 38)
        Me.TableLayoutPanel1.TabIndex = 440
        '
        'ButtonItem_Nhom
        '
        Me.ButtonItem_Nhom.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_Nhom.Name = "ButtonItem_Nhom"
        Me.ButtonItem_Nhom.Symbol = ""
        Me.ButtonItem_Nhom.Text = "Nhóm"
        '
        'List_Khachhang
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1058, 538)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "List_Khachhang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Quản lý khách hàng"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub btEarse_chung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Friend WithEvents txtkhachhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnguoilienhe_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnganhnghe_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdiachi_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtGhichu_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
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
    Friend WithEvents ButtonItem_NhomKhach As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonItem_Nhom As DevComponents.DotNetBar.ButtonItem
End Class
