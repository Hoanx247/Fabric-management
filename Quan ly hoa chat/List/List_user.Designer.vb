<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_user
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Grp_Info = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtten_chung = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboNhom_chung = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtuser_chung = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtpass_chung = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnExit = New System.Windows.Forms.Button()
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
        Me.ButtonItem_Add = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Modify = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Delete = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnPrint_Barcode = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnDiable = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnEnable = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Nhom = New DevComponents.DotNetBar.ButtonItem()
        Me.Panel1.SuspendLayout()
        Me.Grp_Info.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Grp_Info)
        Me.Panel1.Controls.Add(Me.ContextMenuBar1)
        Me.Panel1.Controls.Add(Me.CircularProgress1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 520)
        Me.Panel1.TabIndex = 410
        '
        'Grp_Info
        '
        Me.Grp_Info.CanvasColor = System.Drawing.SystemColors.Control
        Me.Grp_Info.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Grp_Info.Controls.Add(Me.TableLayoutPanel1)
        Me.Grp_Info.DisabledBackColor = System.Drawing.Color.Empty
        Me.Grp_Info.Location = New System.Drawing.Point(316, 162)
        Me.Grp_Info.Name = "Grp_Info"
        Me.Grp_Info.Padding = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.Grp_Info.Size = New System.Drawing.Size(421, 222)
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
        Me.Grp_Info.Text = "Thêm Mới Tài Khoản"
        Me.Grp_Info.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtten_chung, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cboNhom_chung, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtuser_chung, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtpass_chung, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExit, 2, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(390, 196)
        Me.TableLayoutPanel1.TabIndex = 499
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 19)
        Me.Label6.TabIndex = 386
        Me.Label6.Text = "Mật Khẩu:"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.WindowsApplication1.My.Resources.Resources.Good_or_Tick_icon_24
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(125, 132)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 50)
        Me.btnSave.TabIndex = 498
        Me.btnSave.Text = "Lưu Lại"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 387
        Me.Label2.Text = "Tên Truy Cập:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 388
        Me.Label1.Text = "Nhóm:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 19)
        Me.Label3.TabIndex = 389
        Me.Label3.Text = "Tên Đầy Đủ:"
        '
        'txtten_chung
        '
        Me.txtten_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtten_chung.Border.Class = "TextBoxBorder"
        Me.txtten_chung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtten_chung, 2)
        Me.txtten_chung.FocusHighlightEnabled = True
        Me.txtten_chung.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten_chung.Location = New System.Drawing.Point(123, 99)
        Me.txtten_chung.Name = "txtten_chung"
        Me.txtten_chung.Size = New System.Drawing.Size(234, 26)
        Me.txtten_chung.TabIndex = 392
        '
        'cboNhom_chung
        '
        Me.cboNhom_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.cboNhom_chung, 2)
        Me.cboNhom_chung.DisplayMember = "Text"
        Me.cboNhom_chung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNhom_chung.FocusHighlightEnabled = True
        Me.cboNhom_chung.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNhom_chung.FormattingEnabled = True
        Me.cboNhom_chung.ItemHeight = 20
        Me.cboNhom_chung.Location = New System.Drawing.Point(123, 3)
        Me.cboNhom_chung.Name = "cboNhom_chung"
        Me.cboNhom_chung.Size = New System.Drawing.Size(234, 26)
        Me.cboNhom_chung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboNhom_chung.TabIndex = 393
        '
        'txtuser_chung
        '
        Me.txtuser_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtuser_chung.Border.Class = "TextBoxBorder"
        Me.txtuser_chung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtuser_chung, 2)
        Me.txtuser_chung.FocusHighlightEnabled = True
        Me.txtuser_chung.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser_chung.Location = New System.Drawing.Point(123, 35)
        Me.txtuser_chung.Name = "txtuser_chung"
        Me.txtuser_chung.Size = New System.Drawing.Size(234, 26)
        Me.txtuser_chung.TabIndex = 390
        '
        'txtpass_chung
        '
        Me.txtpass_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtpass_chung.Border.Class = "TextBoxBorder"
        Me.txtpass_chung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtpass_chung, 2)
        Me.txtpass_chung.FocusHighlightEnabled = True
        Me.txtpass_chung.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass_chung.Location = New System.Drawing.Point(123, 67)
        Me.txtpass_chung.Name = "txtpass_chung"
        Me.txtpass_chung.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass_chung.Size = New System.Drawing.Size(234, 26)
        Me.txtpass_chung.TabIndex = 391
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(246, 134)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 46)
        Me.btnExit.TabIndex = 496
        Me.btnExit.Text = "Thoát"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(3, 238)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(185, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 437
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
        Me.CircularProgress1.Location = New System.Drawing.Point(13, 273)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(144, 111)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 436
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
        Me.Super_Dgv.Location = New System.Drawing.Point(53, 28)
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
        Me.Super_Dgv.TabIndex = 435
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
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_Add, Me.ButtonItem_Modify, Me.ButtonItem_Delete, Me.ButtonItem4, Me.ButtonItem_Nhom, Me.BtnPrint_Barcode})
        Me.ItemPanel1.ItemSpacing = 5
        Me.ItemPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(998, 34)
        Me.ItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ItemPanel1.TabIndex = 442
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'ButtonItem_Add
        '
        Me.ButtonItem_Add.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_Add.Name = "ButtonItem_Add"
        Me.ButtonItem_Add.Symbol = "57404"
        Me.ButtonItem_Add.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem_Add.Text = "Thêm Mới"
        '
        'ButtonItem_Modify
        '
        Me.ButtonItem_Modify.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_Modify.Name = "ButtonItem_Modify"
        Me.ButtonItem_Modify.Symbol = ""
        Me.ButtonItem_Modify.Text = "Chỉnh Sửa"
        '
        'ButtonItem_Delete
        '
        Me.ButtonItem_Delete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_Delete.Name = "ButtonItem_Delete"
        Me.ButtonItem_Delete.Symbol = ""
        Me.ButtonItem_Delete.Text = "Xóa"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Symbol = ""
        Me.ButtonItem4.Text = "Xuất Excel"
        '
        'BtnPrint_Barcode
        '
        Me.BtnPrint_Barcode.AutoExpandOnClick = True
        Me.BtnPrint_Barcode.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnPrint_Barcode.Name = "BtnPrint_Barcode"
        Me.BtnPrint_Barcode.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnDiable, Me.BtnEnable})
        Me.BtnPrint_Barcode.Symbol = ""
        Me.BtnPrint_Barcode.Text = "Tính Năng"
        '
        'BtnDiable
        '
        Me.BtnDiable.Name = "BtnDiable"
        Me.BtnDiable.Text = "Không Sử Dụng"
        '
        'BtnEnable
        '
        Me.BtnEnable.Name = "BtnEnable"
        Me.BtnEnable.Text = "Sử Dụng"
        '
        'ButtonItem_Nhom
        '
        Me.ButtonItem_Nhom.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_Nhom.Name = "ButtonItem_Nhom"
        Me.ButtonItem_Nhom.Symbol = ""
        Me.ButtonItem_Nhom.Text = "Nhóm"
        '
        'List_user
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(998, 554)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "List_user"
        Me.ShowInTaskbar = False
        Me.Text = "Quản lý tài khoản"
        Me.Panel1.ResumeLayout(False)
        Me.Grp_Info.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Grp_Info As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cboNhom_chung As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtten_chung As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtpass_chung As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtuser_chung As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents ButtonItem_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Modify As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Delete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnPrint_Barcode As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnDiable As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnEnable As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Nhom As DevComponents.DotNetBar.ButtonItem
End Class
