<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List_nhanvien_input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_nhanvien_input))
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness4 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderColor2 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdThoat = New System.Windows.Forms.Button()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtmaso = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txttennhanvien = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdienthoai = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtghichu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnChonLai = New System.Windows.Forms.Button()
        Me.BtnThemMoi_MaHang = New System.Windows.Forms.Button()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cboNhom = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(101, 163)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(192, 58)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdThoat
        '
        Me.cmdThoat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdThoat.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThoat.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.cmdThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdThoat.Location = New System.Drawing.Point(300, 164)
        Me.cmdThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(122, 56)
        Me.cmdThoat.TabIndex = 6
        Me.cmdThoat.Text = "Thoát"
        Me.cmdThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdThoat.UseVisualStyleBackColor = True
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(11, 35)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(84, 26)
        Me.LabelX1.TabIndex = 445
        Me.LabelX1.Text = "Mã Số NV:"
        '
        'txtmaso
        '
        Me.txtmaso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmaso.Border.Class = "TextBoxBorder"
        Me.txtmaso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmaso, 2)
        Me.txtmaso.FocusHighlightEnabled = True
        Me.txtmaso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaso.Location = New System.Drawing.Point(101, 35)
        Me.txtmaso.Name = "txtmaso"
        Me.txtmaso.Size = New System.Drawing.Size(322, 26)
        Me.txtmaso.TabIndex = 0
        Me.txtmaso.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(7, 67)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(88, 26)
        Me.LabelX2.TabIndex = 446
        Me.LabelX2.Text = "Nhân Viên:"
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, 99)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(93, 26)
        Me.LabelX4.TabIndex = 448
        Me.LabelX4.Text = "Điện Thoại:"
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(25, 131)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(70, 26)
        Me.LabelX5.TabIndex = 449
        Me.LabelX5.Text = "Ghi Chú:"
        '
        'txttennhanvien
        '
        Me.txttennhanvien.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txttennhanvien.Border.Class = "TextBoxBorder"
        Me.txttennhanvien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txttennhanvien, 2)
        Me.txttennhanvien.FocusHighlightEnabled = True
        Me.txttennhanvien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttennhanvien.Location = New System.Drawing.Point(101, 67)
        Me.txttennhanvien.Name = "txttennhanvien"
        Me.txttennhanvien.Size = New System.Drawing.Size(322, 26)
        Me.txttennhanvien.TabIndex = 1
        Me.txttennhanvien.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtdienthoai
        '
        Me.txtdienthoai.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtdienthoai.Border.Class = "TextBoxBorder"
        Me.txtdienthoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtdienthoai, 2)
        Me.txtdienthoai.FocusHighlightEnabled = True
        Me.txtdienthoai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdienthoai.Location = New System.Drawing.Point(101, 99)
        Me.txtdienthoai.Name = "txtdienthoai"
        Me.txtdienthoai.Size = New System.Drawing.Size(322, 26)
        Me.txtdienthoai.TabIndex = 3
        Me.txtdienthoai.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtghichu.Location = New System.Drawing.Point(101, 131)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(322, 26)
        Me.txtghichu.TabIndex = 4
        Me.txtghichu.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichu, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdThoat, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSave, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdienthoai, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnChonLai, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnThemMoi_MaHang, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txttennhanvien, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmaso, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cboNhom, 1, 0)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(474, 383)
        Me.TableLayoutPanel1.TabIndex = 450
        '
        'BtnChonLai
        '
        Me.BtnChonLai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChonLai.Location = New System.Drawing.Point(429, 3)
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
        Me.BtnThemMoi_MaHang.Location = New System.Drawing.Point(429, 35)
        Me.BtnThemMoi_MaHang.Name = "BtnThemMoi_MaHang"
        Me.BtnThemMoi_MaHang.Size = New System.Drawing.Size(42, 26)
        Me.BtnThemMoi_MaHang.TabIndex = 461
        Me.BtnThemMoi_MaHang.Text = "..."
        Me.BtnThemMoi_MaHang.UseVisualStyleBackColor = True
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
        Me.LabelX6.Location = New System.Drawing.Point(3, 6)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(90, 20)
        Me.LabelX6.TabIndex = 462
        Me.LabelX6.Text = "Chọn Nhóm"
        '
        'cboNhom
        '
        Me.cboNhom.AllowDrop = True
        Me.cboNhom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNhom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNhom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cboNhom, 2)
        Me.cboNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNhom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNhom.ForeColor = System.Drawing.Color.Black
        Me.cboNhom.FormattingEnabled = True
        Me.cboNhom.Items.AddRange(New Object() {"Đặc Biệt", "Đậm", "Lợt", "Trung"})
        Me.cboNhom.Location = New System.Drawing.Point(101, 3)
        Me.cboNhom.Name = "cboNhom"
        Me.cboNhom.Size = New System.Drawing.Size(322, 27)
        Me.cboNhom.Sorted = True
        Me.cboNhom.TabIndex = 461
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Super_Dgv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(474, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(598, 383)
        Me.Panel2.TabIndex = 451
        '
        'Super_Dgv
        '
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Thickness3.Bottom = 1
        Thickness3.Left = 1
        Thickness3.Right = 1
        Thickness3.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.BorderThickness = Thickness3
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.Bottom
        Me.Super_Dgv.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Thickness4.Bottom = 1
        Thickness4.Left = 1
        Thickness4.Right = 1
        Thickness4.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.BorderThickness = Thickness4
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Background2.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Super_Dgv.DefaultVisualStyles.FilterRowStyles.Default.FilterBackground = Background2
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
        BorderColor2.Bottom = System.Drawing.Color.Black
        BorderColor2.Left = System.Drawing.Color.Black
        BorderColor2.Right = System.Drawing.Color.Black
        BorderColor2.Top = System.Drawing.Color.Black
        Me.Super_Dgv.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor2
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
        'List_nhanvien_input
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1072, 383)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "List_nhanvien_input"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm thông tin nhân viên"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdThoat As System.Windows.Forms.Button
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtmaso As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txttennhanvien As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdienthoai As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtghichu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnChonLai As Button
    Friend WithEvents BtnThemMoi_MaHang As Button
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboNhom As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
End Class
