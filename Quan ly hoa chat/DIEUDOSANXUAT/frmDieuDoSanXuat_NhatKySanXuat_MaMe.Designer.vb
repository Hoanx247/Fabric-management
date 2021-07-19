<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDieuDoSanXuat_NhatKySanXuat_MaMe
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
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ToolStrip_List_ThanhPham = New System.Windows.Forms.ToolStrip()
        Me.btnChuyen_Mamau = New System.Windows.Forms.ToolStripDropDownButton()
        Me.XácNhậnChuyểnMàuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.XácNhậnMẻLỗiKỹThuậtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.XácNhậnHủyMẻToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRow = New System.Windows.Forms.ToolStripLabel()
        Me.BtnLuuThayDoi = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtsomet = New System.Windows.Forms.TextBox()
        Me.txtmau = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsokg = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtsocay = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblloaixe = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbltaixe = New System.Windows.Forms.Label()
        Me.txtdonhang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.lblkhachhang = New System.Windows.Forms.Label()
        Me.txtkhachhang = New System.Windows.Forms.TextBox()
        Me.txtloaihang = New System.Windows.Forms.TextBox()
        Me.txtmahang = New System.Windows.Forms.TextBox()
        Me.txtmamau = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtkhovai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmetkg = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip_List_ThanhPham.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CircularProgress1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 172)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1072, 421)
        Me.Panel1.TabIndex = 399
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
        Me.CircularProgress1.Location = New System.Drawing.Point(375, 133)
        Me.CircularProgress1.Margin = New System.Windows.Forms.Padding(2)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(136, 106)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 432
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
        Me.Super_Dgv.Location = New System.Drawing.Point(51, 58)
        Me.Super_Dgv.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Super_Dgv.Size = New System.Drawing.Size(274, 206)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 416
        '
        'ToolStrip_List_ThanhPham
        '
        Me.ToolStrip_List_ThanhPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip_List_ThanhPham.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip_List_ThanhPham.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_List_ThanhPham.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip_List_ThanhPham.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChuyen_Mamau, Me.ToolStripSeparator6, Me.ToolStripButton2, Me.ToolStripButton1, Me.ToolStripSeparator8, Me.lblRow, Me.BtnLuuThayDoi})
        Me.ToolStrip_List_ThanhPham.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_List_ThanhPham.Name = "ToolStrip_List_ThanhPham"
        Me.ToolStrip_List_ThanhPham.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip_List_ThanhPham.Size = New System.Drawing.Size(1072, 31)
        Me.ToolStrip_List_ThanhPham.Stretch = True
        Me.ToolStrip_List_ThanhPham.TabIndex = 450
        Me.ToolStrip_List_ThanhPham.Text = "ToolStrip1"
        '
        'btnChuyen_Mamau
        '
        Me.btnChuyen_Mamau.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XácNhậnChuyểnMàuToolStripMenuItem, Me.ToolStripSeparator1, Me.XácNhậnMẻLỗiKỹThuậtToolStripMenuItem, Me.ToolStripSeparator2, Me.XácNhậnHủyMẻToolStripMenuItem, Me.ToolStripSeparator3})
        Me.btnChuyen_Mamau.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.btnChuyen_Mamau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChuyen_Mamau.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnChuyen_Mamau.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChuyen_Mamau.Name = "btnChuyen_Mamau"
        Me.btnChuyen_Mamau.Size = New System.Drawing.Size(113, 28)
        Me.btnChuyen_Mamau.Text = "Xác Nhận"
        '
        'XácNhậnChuyểnMàuToolStripMenuItem
        '
        Me.XácNhậnChuyểnMàuToolStripMenuItem.Name = "XácNhậnChuyểnMàuToolStripMenuItem"
        Me.XácNhậnChuyểnMàuToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.XácNhậnChuyểnMàuToolStripMenuItem.Text = "Xác Nhận Chuyển Màu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(257, 6)
        '
        'XácNhậnMẻLỗiKỹThuậtToolStripMenuItem
        '
        Me.XácNhậnMẻLỗiKỹThuậtToolStripMenuItem.Name = "XácNhậnMẻLỗiKỹThuậtToolStripMenuItem"
        Me.XácNhậnMẻLỗiKỹThuậtToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.XácNhậnMẻLỗiKỹThuậtToolStripMenuItem.Text = "Xác Nhận Mẻ Lỗi Kỹ Thuật"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(257, 6)
        '
        'XácNhậnHủyMẻToolStripMenuItem
        '
        Me.XácNhậnHủyMẻToolStripMenuItem.Name = "XácNhậnHủyMẻToolStripMenuItem"
        Me.XácNhậnHủyMẻToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.XácNhậnHủyMẻToolStripMenuItem.Text = "Xác Nhận Hủy Mẻ"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(257, 6)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.ToolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(122, 28)
        Me.ToolStripButton2.Text = "Chuyển Màu"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.WindowsApplication1.My.Resources.Resources.microsoft_excel_24
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(110, 28)
        Me.ToolStripButton1.Text = "Xuất Excel"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'lblRow
        '
        Me.lblRow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(68, 28)
        Me.lblRow.Text = "Tổng số:"
        '
        'BtnLuuThayDoi
        '
        Me.BtnLuuThayDoi.Image = Global.WindowsApplication1.My.Resources.Resources.save
        Me.BtnLuuThayDoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLuuThayDoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnLuuThayDoi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLuuThayDoi.Name = "BtnLuuThayDoi"
        Me.BtnLuuThayDoi.Size = New System.Drawing.Size(130, 28)
        Me.BtnLuuThayDoi.Text = "Lưu Thay Đổi"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtsomet, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmau, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtsokg, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtsocay, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblloaixe, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbltaixe, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdonhang, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblkhachhang, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtloaihang, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmahang, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmamau, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhovai, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmetkg, 3, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1072, 141)
        Me.TableLayoutPanel1.TabIndex = 454
        '
        'txtsomet
        '
        Me.txtsomet.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsomet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsomet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsomet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsomet.Location = New System.Drawing.Point(781, 68)
        Me.txtsomet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsomet.Name = "txtsomet"
        Me.txtsomet.Size = New System.Drawing.Size(117, 26)
        Me.txtsomet.TabIndex = 511
        Me.txtsomet.Text = "0"
        Me.txtsomet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtmau
        '
        Me.txtmau.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmau.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtmau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmau.Location = New System.Drawing.Point(460, 68)
        Me.txtmau.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmau.Name = "txtmau"
        Me.txtmau.Size = New System.Drawing.Size(251, 26)
        Me.txtmau.TabIndex = 525
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(717, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 19)
        Me.Label10.TabIndex = 514
        Me.Label10.Text = "Số Mét:"
        '
        'txtsokg
        '
        Me.txtsokg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsokg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsokg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsokg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsokg.Location = New System.Drawing.Point(781, 36)
        Me.txtsokg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsokg.Name = "txtsokg"
        Me.txtsokg.Size = New System.Drawing.Size(117, 26)
        Me.txtsokg.TabIndex = 510
        Me.txtsokg.Text = "0"
        Me.txtsokg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label11.Location = New System.Drawing.Point(387, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 19)
        Me.Label11.TabIndex = 526
        Me.Label11.Text = "Tên Màu:"
        '
        'txtsocay
        '
        Me.txtsocay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsocay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsocay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsocay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsocay.Location = New System.Drawing.Point(781, 4)
        Me.txtsocay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsocay.Name = "txtsocay"
        Me.txtsocay.Size = New System.Drawing.Size(117, 26)
        Me.txtsocay.TabIndex = 509
        Me.txtsocay.Text = "0"
        Me.txtsocay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(723, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 19)
        Me.Label9.TabIndex = 513
        Me.Label9.Text = "Số Kg:"
        '
        'lblloaixe
        '
        Me.lblloaixe.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblloaixe.AutoSize = True
        Me.lblloaixe.BackColor = System.Drawing.Color.Transparent
        Me.lblloaixe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloaixe.ForeColor = System.Drawing.Color.Red
        Me.lblloaixe.Location = New System.Drawing.Point(25, 70)
        Me.lblloaixe.Name = "lblloaixe"
        Me.lblloaixe.Size = New System.Drawing.Size(84, 19)
        Me.lblloaixe.TabIndex = 505
        Me.lblloaixe.Text = "Mã màu (*):"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(721, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 19)
        Me.Label5.TabIndex = 512
        Me.Label5.Text = "Số cây:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(383, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 19)
        Me.Label8.TabIndex = 506
        Me.Label8.Text = "Tên Hàng:"
        '
        'lbltaixe
        '
        Me.lbltaixe.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbltaixe.AutoSize = True
        Me.lbltaixe.BackColor = System.Drawing.Color.Transparent
        Me.lbltaixe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltaixe.Location = New System.Drawing.Point(40, 38)
        Me.lbltaixe.Name = "lbltaixe"
        Me.lbltaixe.Size = New System.Drawing.Size(69, 19)
        Me.lbltaixe.TabIndex = 503
        Me.lbltaixe.Text = "Mã Hàng:"
        '
        'txtdonhang
        '
        Me.txtdonhang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdonhang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtdonhang.Border.Class = "TextBoxBorder"
        Me.txtdonhang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdonhang.FocusHighlightEnabled = True
        Me.txtdonhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang.Location = New System.Drawing.Point(114, 3)
        Me.txtdonhang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdonhang.Name = "txtdonhang"
        Me.txtdonhang.Size = New System.Drawing.Size(228, 26)
        Me.txtdonhang.TabIndex = 446
        Me.txtdonhang.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(36, 6)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(74, 20)
        Me.LabelX1.TabIndex = 447
        Me.LabelX1.Text = "Đơn Hàng:"
        '
        'lblkhachhang
        '
        Me.lblkhachhang.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblkhachhang.AutoSize = True
        Me.lblkhachhang.BackColor = System.Drawing.Color.Transparent
        Me.lblkhachhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkhachhang.Location = New System.Drawing.Point(366, 6)
        Me.lblkhachhang.Name = "lblkhachhang"
        Me.lblkhachhang.Size = New System.Drawing.Size(88, 19)
        Me.lblkhachhang.TabIndex = 512
        Me.lblkhachhang.Text = "Khách Hàng:"
        '
        'txtkhachhang
        '
        Me.txtkhachhang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkhachhang.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtkhachhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkhachhang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtkhachhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang.ForeColor = System.Drawing.Color.Red
        Me.txtkhachhang.Location = New System.Drawing.Point(460, 4)
        Me.txtkhachhang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtkhachhang.Name = "txtkhachhang"
        Me.txtkhachhang.ReadOnly = True
        Me.txtkhachhang.Size = New System.Drawing.Size(251, 26)
        Me.txtkhachhang.TabIndex = 513
        '
        'txtloaihang
        '
        Me.txtloaihang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtloaihang.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtloaihang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtloaihang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang.Location = New System.Drawing.Point(460, 36)
        Me.txtloaihang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtloaihang.Name = "txtloaihang"
        Me.txtloaihang.ReadOnly = True
        Me.txtloaihang.Size = New System.Drawing.Size(251, 26)
        Me.txtloaihang.TabIndex = 507
        '
        'txtmahang
        '
        Me.txtmahang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmahang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmahang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmahang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang.Location = New System.Drawing.Point(115, 36)
        Me.txtmahang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmahang.Name = "txtmahang"
        Me.txtmahang.Size = New System.Drawing.Size(226, 26)
        Me.txtmahang.TabIndex = 502
        '
        'txtmamau
        '
        Me.txtmamau.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmamau.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmamau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmamau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau.Location = New System.Drawing.Point(115, 68)
        Me.txtmamau.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmamau.Name = "txtmamau"
        Me.txtmamau.Size = New System.Drawing.Size(226, 26)
        Me.txtmamau.TabIndex = 504
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 513
        Me.Label6.Text = "Khổ Vải"
        '
        'txtkhovai
        '
        Me.txtkhovai.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkhovai.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtkhovai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkhovai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtkhovai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhovai.ForeColor = System.Drawing.Color.Red
        Me.txtkhovai.Location = New System.Drawing.Point(115, 100)
        Me.txtkhovai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtkhovai.Name = "txtkhovai"
        Me.txtkhovai.Size = New System.Drawing.Size(226, 26)
        Me.txtkhovai.TabIndex = 512
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(390, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 514
        Me.Label7.Text = "T.Lượng:"
        '
        'txtmetkg
        '
        Me.txtmetkg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmetkg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmetkg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmetkg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmetkg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmetkg.ForeColor = System.Drawing.Color.Red
        Me.txtmetkg.Location = New System.Drawing.Point(460, 100)
        Me.txtmetkg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmetkg.Name = "txtmetkg"
        Me.txtmetkg.Size = New System.Drawing.Size(251, 26)
        Me.txtmetkg.TabIndex = 513
        '
        'frmDieuDoSanXuat_NhatKySanXuat_MaMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1072, 593)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip_List_ThanhPham)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBox = False
        Me.Name = "frmDieuDoSanXuat_NhatKySanXuat_MaMe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDieuDoSanXuat_NhatKySanXuat_MaMe"
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip_List_ThanhPham.ResumeLayout(False)
        Me.ToolStrip_List_ThanhPham.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents ToolStrip_List_ThanhPham As ToolStrip
    Friend WithEvents btnChuyen_Mamau As ToolStripDropDownButton
    Friend WithEvents XácNhậnChuyểnMàuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents XácNhậnMẻLỗiKỹThuậtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents XácNhậnHủyMẻToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents lblRow As ToolStripLabel
    Friend WithEvents BtnLuuThayDoi As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtdonhang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblkhachhang As Label
    Friend WithEvents txtkhachhang As TextBox
    Friend WithEvents txtmahang As TextBox
    Friend WithEvents lbltaixe As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtloaihang As TextBox
    Friend WithEvents txtkhovai As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmetkg As TextBox
    Friend WithEvents lblloaixe As Label
    Friend WithEvents txtmamau As TextBox
    Friend WithEvents txtmau As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtsomet As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsokg As TextBox
    Friend WithEvents txtsocay As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
End Class
