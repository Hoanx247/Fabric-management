<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stock_Thanhpham_Detail_View
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.CtxFunction = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Copy = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Export_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Expand = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Colapse = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSave_ColumnFrozen = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMnu_Select = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMnu_Select_ALL = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMnuSelect_Remove = New DevComponents.DotNetBar.ButtonItem()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.BtnAdd = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.btnExport_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtsomet = New System.Windows.Forms.TextBox()
        Me.txtsocay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtNgayxuat_chungtu = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtsokg = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtmame = New System.Windows.Forms.TextBox()
        Me.txtchungtuxuat = New System.Windows.Forms.TextBox()
        Me.cmdCapnhat = New System.Windows.Forms.Button()
        Me.lblloaixe = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtghichu = New System.Windows.Forms.TextBox()
        Me.cboKieuNXuat = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dtNgayxuat_chungtu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ContextMenuBar1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(427, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 570)
        Me.Panel1.TabIndex = 403
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu, Me.CtxMnu_Select})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(235, 272)
        Me.ContextMenuBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(225, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 438
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'CtxFunction
        '
        Me.CtxFunction.AutoExpandOnClick = True
        Me.CtxFunction.Name = "CtxFunction"
        Me.CtxFunction.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction_Refresh, Me.LabelItem2, Me.CtxFunction_Copy, Me.LabelItem3, Me.CtxFunction_Export_Excel})
        Me.CtxFunction.Text = "Function"
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
        Me.Super_Dgv.Location = New System.Drawing.Point(25, 15)
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
        Me.Super_Dgv.Size = New System.Drawing.Size(221, 167)
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
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnAdd, Me.BtnDelete, Me.btnExport_Excel})
        Me.ItemPanel1.ItemSpacing = 5
        Me.ItemPanel1.Location = New System.Drawing.Point(427, 0)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(697, 34)
        Me.ItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ItemPanel1.TabIndex = 458
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'BtnAdd
        '
        Me.BtnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Symbol = "57404"
        Me.BtnAdd.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.BtnAdd.Text = "Lưu Thay Đổi"
        '
        'BtnDelete
        '
        Me.BtnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Symbol = ""
        Me.BtnDelete.Text = "Trả Về Kho Hoàn Tất"
        '
        'btnExport_Excel
        '
        Me.btnExport_Excel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExport_Excel.Name = "btnExport_Excel"
        Me.btnExport_Excel.Symbol = ""
        Me.btnExport_Excel.Text = "Xuất Excel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtsomet, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtsocay, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.dtNgayxuat_chungtu, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtsokg, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label19, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtmame, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtchungtuxuat, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdCapnhat, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.lblloaixe, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdExit, 2, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txtdongia, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtghichu, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.cboKieuNXuat, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(427, 604)
        Me.TableLayoutPanel2.TabIndex = 478
        '
        'txtsomet
        '
        Me.txtsomet.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsomet.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsomet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtsomet.Location = New System.Drawing.Point(301, 101)
        Me.txtsomet.Margin = New System.Windows.Forms.Padding(5)
        Me.txtsomet.Name = "txtsomet"
        Me.txtsomet.ReadOnly = True
        Me.txtsomet.Size = New System.Drawing.Size(69, 26)
        Me.txtsomet.TabIndex = 487
        '
        'txtsocay
        '
        Me.txtsocay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsocay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsocay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtsocay.Location = New System.Drawing.Point(301, 69)
        Me.txtsocay.Margin = New System.Windows.Forms.Padding(5)
        Me.txtsocay.Name = "txtsocay"
        Me.txtsocay.ReadOnly = True
        Me.txtsocay.Size = New System.Drawing.Size(69, 26)
        Me.txtsocay.TabIndex = 486
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(5, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 470
        Me.Label5.Text = "Ghi Chú"
        '
        'dtNgayxuat_chungtu
        '
        Me.dtNgayxuat_chungtu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtNgayxuat_chungtu.AutoSelectDate = True
        '
        '
        '
        Me.dtNgayxuat_chungtu.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtNgayxuat_chungtu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayxuat_chungtu.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtNgayxuat_chungtu.ButtonDropDown.Visible = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.dtNgayxuat_chungtu, 2)
        Me.dtNgayxuat_chungtu.CustomFormat = "dd/MM/yy"
        Me.dtNgayxuat_chungtu.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector
        Me.dtNgayxuat_chungtu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtNgayxuat_chungtu.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtNgayxuat_chungtu.IsPopupCalendarOpen = False
        Me.dtNgayxuat_chungtu.Location = New System.Drawing.Point(99, 195)
        Me.dtNgayxuat_chungtu.Margin = New System.Windows.Forms.Padding(2)
        '
        '
        '
        '
        '
        '
        Me.dtNgayxuat_chungtu.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayxuat_chungtu.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtNgayxuat_chungtu.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtNgayxuat_chungtu.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtNgayxuat_chungtu.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtNgayxuat_chungtu.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtNgayxuat_chungtu.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtNgayxuat_chungtu.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtNgayxuat_chungtu.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtNgayxuat_chungtu.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayxuat_chungtu.MonthCalendar.DisplayMonth = New Date(2014, 11, 1, 0, 0, 0, 0)
        Me.dtNgayxuat_chungtu.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtNgayxuat_chungtu.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtNgayxuat_chungtu.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtNgayxuat_chungtu.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtNgayxuat_chungtu.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayxuat_chungtu.MonthCalendar.TodayButtonVisible = True
        Me.dtNgayxuat_chungtu.Name = "dtNgayxuat_chungtu"
        Me.dtNgayxuat_chungtu.ShowUpDown = True
        Me.dtNgayxuat_chungtu.Size = New System.Drawing.Size(195, 26)
        Me.dtNgayxuat_chungtu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtNgayxuat_chungtu.TabIndex = 477
        Me.dtNgayxuat_chungtu.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dtNgayxuat_chungtu.WatermarkText = "Từ ngày"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label20.Location = New System.Drawing.Point(227, 103)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 18)
        Me.Label20.TabIndex = 482
        Me.Label20.Text = "Số Mét"
        '
        'txtsokg
        '
        Me.txtsokg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsokg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsokg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtsokg.Location = New System.Drawing.Point(102, 101)
        Me.txtsokg.Margin = New System.Windows.Forms.Padding(5)
        Me.txtsokg.Name = "txtsokg"
        Me.txtsokg.ReadOnly = True
        Me.txtsokg.Size = New System.Drawing.Size(115, 26)
        Me.txtsokg.TabIndex = 488
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(227, 71)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 18)
        Me.Label9.TabIndex = 484
        Me.Label9.Text = "Số Cây:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(5, 199)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 18)
        Me.Label7.TabIndex = 478
        Me.Label7.Text = "Ngày Xuất"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(5, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 463
        Me.Label2.Text = "Chứng Từ"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label19.Location = New System.Drawing.Point(5, 103)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 18)
        Me.Label19.TabIndex = 483
        Me.Label19.Text = "Số Kg"
        '
        'txtmame
        '
        Me.txtmame.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmame.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmame.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtmame.Location = New System.Drawing.Point(102, 69)
        Me.txtmame.Margin = New System.Windows.Forms.Padding(5)
        Me.txtmame.Name = "txtmame"
        Me.txtmame.ReadOnly = True
        Me.txtmame.Size = New System.Drawing.Size(115, 26)
        Me.txtmame.TabIndex = 485
        '
        'txtchungtuxuat
        '
        Me.txtchungtuxuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtchungtuxuat.BackColor = System.Drawing.Color.White
        Me.txtchungtuxuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchungtuxuat.Location = New System.Drawing.Point(102, 5)
        Me.txtchungtuxuat.Margin = New System.Windows.Forms.Padding(5)
        Me.txtchungtuxuat.Name = "txtchungtuxuat"
        Me.txtchungtuxuat.Size = New System.Drawing.Size(115, 26)
        Me.txtchungtuxuat.TabIndex = 461
        '
        'cmdCapnhat
        '
        Me.cmdCapnhat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCapnhat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCapnhat.Image = Global.WindowsApplication1.My.Resources.Resources.Good_or_Tick_icon_24
        Me.cmdCapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCapnhat.Location = New System.Drawing.Point(101, 227)
        Me.cmdCapnhat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdCapnhat.Name = "cmdCapnhat"
        Me.cmdCapnhat.Size = New System.Drawing.Size(117, 54)
        Me.cmdCapnhat.TabIndex = 465
        Me.cmdCapnhat.Text = "Cập Nhật"
        Me.cmdCapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCapnhat.UseVisualStyleBackColor = True
        '
        'lblloaixe
        '
        Me.lblloaixe.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblloaixe.AutoSize = True
        Me.lblloaixe.BackColor = System.Drawing.Color.Transparent
        Me.lblloaixe.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblloaixe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblloaixe.Location = New System.Drawing.Point(5, 39)
        Me.lblloaixe.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblloaixe.Name = "lblloaixe"
        Me.lblloaixe.Size = New System.Drawing.Size(76, 18)
        Me.lblloaixe.TabIndex = 462
        Me.lblloaixe.Text = "Mục Đích"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.cmdExit, 2)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(227, 229)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(143, 50)
        Me.cmdExit.TabIndex = 464
        Me.cmdExit.Text = "Thoát"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtdongia
        '
        Me.txtdongia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdongia.BackColor = System.Drawing.Color.White
        Me.txtdongia.Enabled = False
        Me.txtdongia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdongia.Location = New System.Drawing.Point(102, 133)
        Me.txtdongia.Margin = New System.Windows.Forms.Padding(5)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(115, 26)
        Me.txtdongia.TabIndex = 473
        Me.txtdongia.Text = "0"
        Me.txtdongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtghichu
        '
        Me.txtghichu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtghichu.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtghichu, 3)
        Me.txtghichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu.Location = New System.Drawing.Point(102, 165)
        Me.txtghichu.Margin = New System.Windows.Forms.Padding(5)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(268, 26)
        Me.txtghichu.TabIndex = 469
        '
        'cboKieuNXuat
        '
        Me.cboKieuNXuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.cboKieuNXuat, 3)
        Me.cboKieuNXuat.DisplayMember = "Text"
        Me.cboKieuNXuat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKieuNXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKieuNXuat.FocusHighlightEnabled = True
        Me.cboKieuNXuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKieuNXuat.FormattingEnabled = True
        Me.cboKieuNXuat.ItemHeight = 20
        Me.cboKieuNXuat.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem5})
        Me.cboKieuNXuat.Location = New System.Drawing.Point(99, 35)
        Me.cboKieuNXuat.Margin = New System.Windows.Forms.Padding(2)
        Me.cboKieuNXuat.Name = "cboKieuNXuat"
        Me.cboKieuNXuat.Size = New System.Drawing.Size(274, 26)
        Me.cboKieuNXuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboKieuNXuat.TabIndex = 466
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Vải"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Bo"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(5, 135)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 474
        Me.Label6.Text = "Đơn Giá:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(5, 71)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 18)
        Me.Label8.TabIndex = 479
        Me.Label8.Text = "Mã Mẻ:"
        '
        'Stock_Thanhpham_Detail_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 604)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "Stock_Thanhpham_Detail_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chi Tiết Mẻ Thành Phẩm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dtNgayxuat_chungtu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents BtnAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnDelete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnExport_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtsomet As TextBox
    Friend WithEvents txtsocay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtNgayxuat_chungtu As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label20 As Label
    Friend WithEvents txtsokg As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtmame As TextBox
    Friend WithEvents txtchungtuxuat As TextBox
    Friend WithEvents cmdCapnhat As Button
    Friend WithEvents lblloaixe As Label
    Friend WithEvents cmdExit As Button
    Friend WithEvents txtdongia As TextBox
    Friend WithEvents txtghichu As TextBox
    Friend WithEvents cboKieuNXuat As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents CtxFunction As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Copy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Export_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Expand As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Colapse As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSave_ColumnFrozen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMnu_Select As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMnu_Select_ALL As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMnuSelect_Remove As DevComponents.DotNetBar.ButtonItem
End Class
