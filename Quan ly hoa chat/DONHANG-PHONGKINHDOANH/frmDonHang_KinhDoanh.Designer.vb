<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDonHang_KinhDoanh
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
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDonHang_KinhDoanh))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.CtxFunction = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Add = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Modify = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_delete = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Copy = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem4 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Export_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Expand = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Colapse = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSave_ColumnFrozen = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMnuSelect = New DevComponents.DotNetBar.ButtonItem()
        Me.mnu_Select_All = New DevComponents.DotNetBar.ButtonItem()
        Me.mnu_Remove_ALL = New DevComponents.DotNetBar.ButtonItem()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkTatCa = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.dt1_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dt2_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtkhachhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdonhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btTim = New DevComponents.DotNetBar.ButtonX()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.btnCopy = New DevComponents.DotNetBar.ButtonItem()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonItem()
        Me.btnModify = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnExport_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnLuuThayDoi = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnTinhTheoDonVi = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Enable = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Disable = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_View_DonHang = New DevComponents.DotNetBar.ButtonItem()
        Me.Panel1.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(997, 560)
        Me.Panel1.TabIndex = 413
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu, Me.CtxMnuSelect})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(308, 263)
        Me.ContextMenuBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(234, 25)
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
        Me.CtxFunction.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction_Add, Me.CtxFunction_Modify, Me.CtxFunction_delete, Me.CtxFunction_Refresh, Me.LabelItem3, Me.CtxFunction_Copy, Me.LabelItem4, Me.CtxFunction_Export_Excel})
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
        Me.LabelItem3.Text = "Sao Chép"
        '
        'CtxFunction_Copy
        '
        Me.CtxFunction_Copy.Image = Global.WindowsApplication1.My.Resources.Resources.mail_forward
        Me.CtxFunction_Copy.Name = "CtxFunction_Copy"
        Me.CtxFunction_Copy.Text = "Sao Chép"
        '
        'LabelItem4
        '
        Me.LabelItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem4.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem4.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem4.Name = "LabelItem4"
        Me.LabelItem4.PaddingBottom = 1
        Me.LabelItem4.PaddingLeft = 10
        Me.LabelItem4.PaddingTop = 1
        Me.LabelItem4.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem4.Text = "Xuất Excel"
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
        Me.CircularProgress1.Location = New System.Drawing.Point(150, 215)
        Me.CircularProgress1.Margin = New System.Windows.Forms.Padding(2)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(132, 86)
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
        Me.Super_Dgv.Location = New System.Drawing.Point(220, 83)
        Me.Super_Dgv.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Super_Dgv.PrimaryGrid.GroupByRow.WatermarkText = "Kéo cột cần xem vào đây"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Header.Text = ""
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
        Me.Super_Dgv.Size = New System.Drawing.Size(195, 109)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 417
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ChkTatCa, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dt1_F, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dt2_F, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang_F, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdonhang_F, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btTim, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 594)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(997, 35)
        Me.TableLayoutPanel1.TabIndex = 456
        '
        'ChkTatCa
        '
        Me.ChkTatCa.AutoSize = True
        '
        '
        '
        Me.ChkTatCa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkTatCa.CheckSignSize = New System.Drawing.Size(20, 20)
        Me.ChkTatCa.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTatCa.Location = New System.Drawing.Point(255, 3)
        Me.ChkTatCa.Name = "ChkTatCa"
        Me.ChkTatCa.Size = New System.Drawing.Size(59, 22)
        Me.ChkTatCa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkTatCa.TabIndex = 437
        Me.ChkTatCa.Text = "ALL"
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
        Me.dt1_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt1_F.IsPopupCalendarOpen = False
        Me.dt1_F.Location = New System.Drawing.Point(2, 2)
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
        Me.dt1_F.Size = New System.Drawing.Size(116, 25)
        Me.dt1_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt1_F.TabIndex = 395
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
        Me.dt2_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt2_F.IsPopupCalendarOpen = False
        Me.dt2_F.Location = New System.Drawing.Point(122, 2)
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
        Me.dt2_F.Size = New System.Drawing.Size(128, 25)
        Me.dt2_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt2_F.TabIndex = 396
        Me.dt2_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt2_F.WatermarkText = "Đến ngày"
        '
        'txtkhachhang_F
        '
        Me.txtkhachhang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkhachhang_F.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtkhachhang_F.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtkhachhang_F.Border.Class = "TextBoxBorder"
        Me.txtkhachhang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtkhachhang_F.FocusHighlightEnabled = True
        Me.txtkhachhang_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.Location = New System.Drawing.Point(570, 2)
        Me.txtkhachhang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkhachhang_F.Name = "txtkhachhang_F"
        Me.txtkhachhang_F.Size = New System.Drawing.Size(123, 25)
        Me.txtkhachhang_F.TabIndex = 404
        Me.txtkhachhang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtkhachhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.WatermarkText = "Khách Hàng"
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
        Me.txtdonhang_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.Location = New System.Drawing.Point(421, 2)
        Me.txtdonhang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdonhang_F.Name = "txtdonhang_F"
        Me.txtdonhang_F.Size = New System.Drawing.Size(145, 25)
        Me.txtdonhang_F.TabIndex = 390
        Me.txtdonhang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtdonhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.WatermarkText = "Đơn Hàng"
        '
        'btTim
        '
        Me.btTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTim.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btTim.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTim.Image = CType(resources.GetObject("btTim.Image"), System.Drawing.Image)
        Me.btTim.Location = New System.Drawing.Point(319, 2)
        Me.btTim.Margin = New System.Windows.Forms.Padding(2)
        Me.btTim.Name = "btTim"
        Me.btTim.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btTim.Size = New System.Drawing.Size(98, 24)
        Me.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btTim.TabIndex = 397
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
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnCopy, Me.btnAdd, Me.btnModify, Me.btnDelete, Me.BtnExport_Excel, Me.BtnLuuThayDoi, Me.BtnTinhTheoDonVi, Me.ButtonItem_View_DonHang})
        Me.ItemPanel1.ItemSpacing = 5
        Me.ItemPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(997, 34)
        Me.ItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.ItemPanel1.TabIndex = 457
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
        Me.BtnExport_Excel.Symbol = ""
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
        Me.BtnTinhTheoDonVi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnTinhTheoDonVi.Name = "BtnTinhTheoDonVi"
        Me.BtnTinhTheoDonVi.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_Enable, Me.ButtonItem_Disable})
        Me.BtnTinhTheoDonVi.Symbol = ""
        Me.BtnTinhTheoDonVi.Text = "Tính Năng"
        '
        'ButtonItem_Enable
        '
        Me.ButtonItem_Enable.Name = "ButtonItem_Enable"
        Me.ButtonItem_Enable.Text = "Sử Dụng"
        '
        'ButtonItem_Disable
        '
        Me.ButtonItem_Disable.Name = "ButtonItem_Disable"
        Me.ButtonItem_Disable.Text = "Không Sử Dụng"
        '
        'ButtonItem_View_DonHang
        '
        Me.ButtonItem_View_DonHang.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_View_DonHang.Name = "ButtonItem_View_DonHang"
        Me.ButtonItem_View_DonHang.Symbol = ""
        Me.ButtonItem_View_DonHang.Text = "Xem Tiến Độ Đơn Hàng"
        '
        'frmDonHang_KinhDoanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(997, 629)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmDonHang_KinhDoanh"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đơn Hàng (PKD)"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents CtxFunction As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Modify As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_delete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Copy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem4 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Export_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Expand As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Colapse As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSave_ColumnFrozen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMnuSelect As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnu_Select_All As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnu_Remove_ALL As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dt1_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dt2_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btTim As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtkhachhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdonhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents btnCopy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnModify As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnExport_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnLuuThayDoi As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ChkTatCa As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents BtnTinhTheoDonVi As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Enable As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Disable As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_View_DonHang As DevComponents.DotNetBar.ButtonItem
End Class
