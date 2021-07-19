<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_mamau_input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_mamau_input))
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtghichu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txttenmau = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmamau = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtmaquitrinh = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BtnChonLai = New System.Windows.Forms.Button()
        Me.BtnThemMoi_MaHang = New System.Windows.Forms.Button()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cboNhomMau = New System.Windows.Forms.ComboBox()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(113, 162)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(181, 60)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(299, 163)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(124, 58)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Thoát"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtghichu
        '
        Me.txtghichu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtghichu.Border.Class = "TextBoxBorder"
        Me.txtghichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtghichu, 2)
        Me.txtghichu.FocusHighlightEnabled = True
        Me.txtghichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu.Location = New System.Drawing.Point(113, 131)
        Me.txtghichu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(311, 26)
        Me.txtghichu.TabIndex = 4
        Me.txtghichu.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txttenmau
        '
        Me.txttenmau.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txttenmau.Border.Class = "TextBoxBorder"
        Me.txttenmau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txttenmau, 2)
        Me.txttenmau.FocusHighlightEnabled = True
        Me.txttenmau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenmau.Location = New System.Drawing.Point(113, 67)
        Me.txttenmau.Margin = New System.Windows.Forms.Padding(2)
        Me.txttenmau.Name = "txttenmau"
        Me.txttenmau.Size = New System.Drawing.Size(311, 26)
        Me.txttenmau.TabIndex = 2
        Me.txttenmau.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtmamau
        '
        Me.txtmamau.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmamau.Border.Class = "TextBoxBorder"
        Me.txtmamau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmamau, 2)
        Me.txtmamau.FocusHighlightEnabled = True
        Me.txtmamau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau.Location = New System.Drawing.Point(113, 35)
        Me.txtmamau.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmamau.Name = "txtmamau"
        Me.txtmamau.Size = New System.Drawing.Size(311, 26)
        Me.txtmamau.TabIndex = 1
        Me.txtmamau.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Super_Dgv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(474, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 362)
        Me.Panel2.TabIndex = 447
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
        Me.Super_Dgv.Location = New System.Drawing.Point(146, 140)
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
        Me.Super_Dgv.TabIndex = 460
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtmaquitrinh, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSave, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdExit, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnChonLai, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnThemMoi_MaHang, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmamau, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txttenmau, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboNhomMau, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichu, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(474, 362)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtmaquitrinh
        '
        Me.txtmaquitrinh.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmaquitrinh.Border.Class = "TextBoxBorder"
        Me.txtmaquitrinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmaquitrinh, 2)
        Me.txtmaquitrinh.FocusHighlightEnabled = True
        Me.txtmaquitrinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaquitrinh.Location = New System.Drawing.Point(113, 99)
        Me.txtmaquitrinh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmaquitrinh.Name = "txtmaquitrinh"
        Me.txtmaquitrinh.Size = New System.Drawing.Size(311, 26)
        Me.txtmaquitrinh.TabIndex = 3
        Me.txtmaquitrinh.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 102)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(107, 20)
        Me.LabelX1.TabIndex = 526
        Me.LabelX1.Text = "Mã Qui Trình:"
        '
        'BtnChonLai
        '
        Me.BtnChonLai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChonLai.Location = New System.Drawing.Point(429, 35)
        Me.BtnChonLai.Name = "BtnChonLai"
        Me.BtnChonLai.Size = New System.Drawing.Size(42, 26)
        Me.BtnChonLai.TabIndex = 462
        Me.BtnChonLai.Text = "..."
        Me.BtnChonLai.UseVisualStyleBackColor = True
        '
        'BtnThemMoi_MaHang
        '
        Me.BtnThemMoi_MaHang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnThemMoi_MaHang.Location = New System.Drawing.Point(429, 67)
        Me.BtnThemMoi_MaHang.Name = "BtnThemMoi_MaHang"
        Me.BtnThemMoi_MaHang.Size = New System.Drawing.Size(42, 26)
        Me.BtnThemMoi_MaHang.TabIndex = 461
        Me.BtnThemMoi_MaHang.Text = "..."
        Me.BtnThemMoi_MaHang.UseVisualStyleBackColor = True
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 70)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 20)
        Me.LabelX2.TabIndex = 525
        Me.LabelX2.Text = "Tên Màu:"
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(3, 38)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(71, 20)
        Me.LabelX5.TabIndex = 441
        Me.LabelX5.Text = "Mã Màu:"
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, 6)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(90, 20)
        Me.LabelX4.TabIndex = 462
        Me.LabelX4.Text = "Chọn Nhóm"
        '
        'cboNhomMau
        '
        Me.cboNhomMau.AllowDrop = True
        Me.cboNhomMau.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNhomMau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNhomMau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cboNhomMau, 2)
        Me.cboNhomMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNhomMau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNhomMau.ForeColor = System.Drawing.Color.Black
        Me.cboNhomMau.FormattingEnabled = True
        Me.cboNhomMau.Items.AddRange(New Object() {"Đặc Biệt", "Đậm", "Lợt", "Trung"})
        Me.cboNhomMau.Location = New System.Drawing.Point(114, 3)
        Me.cboNhomMau.Name = "cboNhomMau"
        Me.cboNhomMau.Size = New System.Drawing.Size(309, 27)
        Me.cboNhomMau.Sorted = True
        Me.cboNhomMau.TabIndex = 0
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(3, 134)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(62, 20)
        Me.LabelX6.TabIndex = 440
        Me.LabelX6.Text = "Ghi chú"
        '
        'List_mamau_input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(966, 362)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "List_mamau_input"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin mã màu"
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtghichu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txttenmau As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmamau As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnChonLai As Button
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnThemMoi_MaHang As Button
    Friend WithEvents cboNhomMau As ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtmaquitrinh As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
