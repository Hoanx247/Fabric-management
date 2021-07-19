<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDieuDoSanXuat_PhanMe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDieuDoSanXuat_PhanMe))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ToolStrip_List_ThanhPham = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_PhanMe = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRow = New System.Windows.Forms.ToolStripLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkMoc_ChuaPhanMe = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtcongdoan_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtchungtunhap_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmetkg_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btTim = New DevComponents.DotNetBar.ButtonX()
        Me.txtkhovai_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtghichu_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmame_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtkhachhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmamau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdonhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmahang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtloaihang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1072, 567)
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
        Me.CircularProgress1.Location = New System.Drawing.Point(301, 138)
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
        Me.Super_Dgv.Location = New System.Drawing.Point(515, 246)
        Me.Super_Dgv.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Super_Dgv.TabIndex = 416
        '
        'ToolStrip_List_ThanhPham
        '
        Me.ToolStrip_List_ThanhPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip_List_ThanhPham.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip_List_ThanhPham.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_List_ThanhPham.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip_List_ThanhPham.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.ToolStripButton_PhanMe, Me.ToolStripButton_ExportExcel, Me.ToolStripSeparator8, Me.lblRow})
        Me.ToolStrip_List_ThanhPham.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_List_ThanhPham.Name = "ToolStrip_List_ThanhPham"
        Me.ToolStrip_List_ThanhPham.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip_List_ThanhPham.Size = New System.Drawing.Size(1072, 31)
        Me.ToolStrip_List_ThanhPham.Stretch = True
        Me.ToolStrip_List_ThanhPham.TabIndex = 450
        Me.ToolStrip_List_ThanhPham.Text = "ToolStrip1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton_PhanMe
        '
        Me.ToolStripButton_PhanMe.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.ToolStripButton_PhanMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton_PhanMe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_PhanMe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_PhanMe.Name = "ToolStripButton_PhanMe"
        Me.ToolStripButton_PhanMe.Size = New System.Drawing.Size(161, 28)
        Me.ToolStripButton_PhanMe.Text = "Đưa Mộc Vào Mẻ"
        '
        'ToolStripButton_ExportExcel
        '
        Me.ToolStripButton_ExportExcel.Image = Global.WindowsApplication1.My.Resources.Resources.microsoft_excel_24
        Me.ToolStripButton_ExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton_ExportExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_ExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ExportExcel.Name = "ToolStripButton_ExportExcel"
        Me.ToolStripButton_ExportExcel.Size = New System.Drawing.Size(110, 28)
        Me.ToolStripButton_ExportExcel.Text = "Xuất Excel"
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.chkMoc_ChuaPhanMe, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtcongdoan_F, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtchungtunhap_F, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmetkg_F, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btTim, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhovai_F, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichu_F, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame_F, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang_F, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmamau_F, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdonhang_F, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmau_F, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmahang_F, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtloaihang_F, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 598)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1072, 65)
        Me.TableLayoutPanel1.TabIndex = 457
        '
        'chkMoc_ChuaPhanMe
        '
        Me.chkMoc_ChuaPhanMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMoc_ChuaPhanMe.AutoSize = True
        '
        '
        '
        Me.chkMoc_ChuaPhanMe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkMoc_ChuaPhanMe.Checked = True
        Me.chkMoc_ChuaPhanMe.CheckSignSize = New System.Drawing.Size(30, 25)
        Me.chkMoc_ChuaPhanMe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMoc_ChuaPhanMe.CheckValue = "Y"
        Me.chkMoc_ChuaPhanMe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMoc_ChuaPhanMe.Location = New System.Drawing.Point(737, 14)
        Me.chkMoc_ChuaPhanMe.Name = "chkMoc_ChuaPhanMe"
        Me.TableLayoutPanel1.SetRowSpan(Me.chkMoc_ChuaPhanMe, 2)
        Me.chkMoc_ChuaPhanMe.Size = New System.Drawing.Size(162, 27)
        Me.chkMoc_ChuaPhanMe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkMoc_ChuaPhanMe.TabIndex = 485
        Me.chkMoc_ChuaPhanMe.Text = "Mẻ Chưa Có Mộc"
        '
        'txtcongdoan_F
        '
        Me.txtcongdoan_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtcongdoan_F.Border.Class = "TextBoxBorder"
        Me.txtcongdoan_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcongdoan_F.FocusHighlightEnabled = True
        Me.txtcongdoan_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcongdoan_F.Location = New System.Drawing.Point(645, 30)
        Me.txtcongdoan_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcongdoan_F.Name = "txtcongdoan_F"
        Me.txtcongdoan_F.Size = New System.Drawing.Size(87, 25)
        Me.txtcongdoan_F.TabIndex = 408
        Me.txtcongdoan_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtcongdoan_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcongdoan_F.WatermarkText = "Công Đoạn"
        '
        'txtchungtunhap_F
        '
        Me.txtchungtunhap_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtchungtunhap_F.Border.Class = "TextBoxBorder"
        Me.txtchungtunhap_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtchungtunhap_F.FocusHighlightEnabled = True
        Me.txtchungtunhap_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchungtunhap_F.Location = New System.Drawing.Point(645, 2)
        Me.txtchungtunhap_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtchungtunhap_F.Name = "txtchungtunhap_F"
        Me.txtchungtunhap_F.Size = New System.Drawing.Size(87, 25)
        Me.txtchungtunhap_F.TabIndex = 407
        Me.txtchungtunhap_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtchungtunhap_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchungtunhap_F.WatermarkText = "CT Nhập"
        '
        'txtmetkg_F
        '
        Me.txtmetkg_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmetkg_F.Border.Class = "TextBoxBorder"
        Me.txtmetkg_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmetkg_F.FocusHighlightEnabled = True
        Me.txtmetkg_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmetkg_F.Location = New System.Drawing.Point(560, 30)
        Me.txtmetkg_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmetkg_F.Name = "txtmetkg_F"
        Me.txtmetkg_F.Size = New System.Drawing.Size(81, 25)
        Me.txtmetkg_F.TabIndex = 403
        Me.txtmetkg_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmetkg_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmetkg_F.WatermarkText = "Métkg"
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
        Me.btTim.Location = New System.Drawing.Point(23, 2)
        Me.btTim.Margin = New System.Windows.Forms.Padding(2)
        Me.btTim.Name = "btTim"
        Me.TableLayoutPanel1.SetRowSpan(Me.btTim, 2)
        Me.btTim.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btTim.Size = New System.Drawing.Size(77, 52)
        Me.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btTim.TabIndex = 397
        '
        'txtkhovai_F
        '
        Me.txtkhovai_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtkhovai_F.Border.Class = "TextBoxBorder"
        Me.txtkhovai_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtkhovai_F.FocusHighlightEnabled = True
        Me.txtkhovai_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhovai_F.Location = New System.Drawing.Point(560, 2)
        Me.txtkhovai_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkhovai_F.Name = "txtkhovai_F"
        Me.txtkhovai_F.Size = New System.Drawing.Size(81, 25)
        Me.txtkhovai_F.TabIndex = 402
        Me.txtkhovai_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtkhovai_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhovai_F.WatermarkText = "Khổ vải"
        '
        'txtghichu_F
        '
        Me.txtghichu_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtghichu_F.Border.Class = "TextBoxBorder"
        Me.txtghichu_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtghichu_F.FocusHighlightEnabled = True
        Me.txtghichu_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu_F.Location = New System.Drawing.Point(481, 30)
        Me.txtghichu_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtghichu_F.Name = "txtghichu_F"
        Me.txtghichu_F.Size = New System.Drawing.Size(75, 25)
        Me.txtghichu_F.TabIndex = 400
        Me.txtghichu_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtghichu_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu_F.WatermarkText = "Ghi chú"
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
        Me.txtmame_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.Location = New System.Drawing.Point(481, 2)
        Me.txtmame_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmame_F.Name = "txtmame_F"
        Me.txtmame_F.Size = New System.Drawing.Size(75, 25)
        Me.txtmame_F.TabIndex = 398
        Me.txtmame_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmame_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.WatermarkText = "Mã Mẻ"
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
        Me.txtkhachhang_F.Location = New System.Drawing.Point(104, 2)
        Me.txtkhachhang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkhachhang_F.Name = "txtkhachhang_F"
        Me.txtkhachhang_F.Size = New System.Drawing.Size(124, 25)
        Me.txtkhachhang_F.TabIndex = 404
        Me.txtkhachhang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtkhachhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.WatermarkText = "Khách Hàng"
        '
        'txtmamau_F
        '
        Me.txtmamau_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmamau_F.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtmamau_F.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtmamau_F.Border.Class = "TextBoxBorder"
        Me.txtmamau_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmamau_F.FocusHighlightEnabled = True
        Me.txtmamau_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau_F.Location = New System.Drawing.Point(381, 30)
        Me.txtmamau_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmamau_F.Name = "txtmamau_F"
        Me.txtmamau_F.Size = New System.Drawing.Size(96, 25)
        Me.txtmamau_F.TabIndex = 393
        Me.txtmamau_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmamau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau_F.WatermarkText = "Mã Màu"
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
        Me.txtdonhang_F.Location = New System.Drawing.Point(104, 30)
        Me.txtdonhang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdonhang_F.Name = "txtdonhang_F"
        Me.txtdonhang_F.Size = New System.Drawing.Size(124, 25)
        Me.txtdonhang_F.TabIndex = 390
        Me.txtdonhang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtdonhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.WatermarkText = "Đơn Hàng"
        '
        'txtmau_F
        '
        Me.txtmau_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmau_F.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtmau_F.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtmau_F.Border.Class = "TextBoxBorder"
        Me.txtmau_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmau_F.FocusHighlightEnabled = True
        Me.txtmau_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmau_F.Location = New System.Drawing.Point(381, 2)
        Me.txtmau_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmau_F.Name = "txtmau_F"
        Me.txtmau_F.Size = New System.Drawing.Size(96, 26)
        Me.txtmau_F.TabIndex = 394
        Me.txtmau_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmau_F.WatermarkText = "Màu"
        '
        'txtmahang_F
        '
        Me.txtmahang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmahang_F.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtmahang_F.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtmahang_F.Border.Class = "TextBoxBorder"
        Me.txtmahang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmahang_F.FocusHighlightEnabled = True
        Me.txtmahang_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.Location = New System.Drawing.Point(232, 2)
        Me.txtmahang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmahang_F.Name = "txtmahang_F"
        Me.txtmahang_F.Size = New System.Drawing.Size(145, 25)
        Me.txtmahang_F.TabIndex = 405
        Me.txtmahang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmahang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.WatermarkText = "Mã Hàng"
        '
        'txtloaihang_F
        '
        Me.txtloaihang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtloaihang_F.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtloaihang_F.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txtloaihang_F.Border.Class = "TextBoxBorder"
        Me.txtloaihang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtloaihang_F.FocusHighlightEnabled = True
        Me.txtloaihang_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.Location = New System.Drawing.Point(232, 30)
        Me.txtloaihang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtloaihang_F.Name = "txtloaihang_F"
        Me.txtloaihang_F.Size = New System.Drawing.Size(145, 25)
        Me.txtloaihang_F.TabIndex = 392
        Me.txtloaihang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtloaihang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.WatermarkText = "Loại Hàng"
        '
        'frmDieuDoSanXuat_PhanMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1072, 663)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip_List_ThanhPham)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBox = False
        Me.Name = "frmDieuDoSanXuat_PhanMe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDieuDoSanXuat_PhanMe"
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
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton_PhanMe As ToolStripButton
    Friend WithEvents ToolStripButton_ExportExcel As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents lblRow As ToolStripLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtcongdoan_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtchungtunhap_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmetkg_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btTim As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtkhovai_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtghichu_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmame_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtkhachhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmamau_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdonhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmau_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmahang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtloaihang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chkMoc_ChuaPhanMe As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
