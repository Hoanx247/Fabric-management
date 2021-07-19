<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeLine_Confirm
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
        Me.components = New System.ComponentModel.Container()
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderPattern1 As DevComponents.DotNetBar.SuperGrid.Style.BorderPattern = New DevComponents.DotNetBar.SuperGrid.Style.BorderPattern()
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim Thickness4 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness5 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background4 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderPattern2 As DevComponents.DotNetBar.SuperGrid.Style.BorderPattern = New DevComponents.DotNetBar.SuperGrid.Style.BorderPattern()
        Dim Thickness6 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor2 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeLine_Confirm))
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtsome_dangsanxuat = New System.Windows.Forms.TextBox()
        Me.BtnDoPH = New DevComponents.DotNetBar.ButtonX()
        Me.CboCongDoan_PH = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtgiatri_min = New System.Windows.Forms.TextBox()
        Me.txtgiatri_max = New System.Windows.Forms.TextBox()
        Me.btnXacNhan_QuanLy = New DevComponents.DotNetBar.ButtonX()
        Me.BtnExit_CapNhat = New System.Windows.Forms.Button()
        Me.txtmame_scanner = New System.Windows.Forms.TextBox()
        Me.btnXacNhan_GioRa = New DevComponents.DotNetBar.ButtonX()
        Me.btnXacNhan_GioVao = New DevComponents.DotNetBar.ButtonX()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Super_Dgv_LenhSanXuat = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Super_Dgv_Info = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 8
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtsome_dangsanxuat, 7, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnDoPH, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CboCongDoan_PH, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtgiatri_min, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtgiatri_max, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnXacNhan_QuanLy, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnExit_CapNhat, 7, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(467, 619)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(723, 113)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'txtsome_dangsanxuat
        '
        Me.txtsome_dangsanxuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsome_dangsanxuat.BackColor = System.Drawing.Color.Yellow
        Me.txtsome_dangsanxuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsome_dangsanxuat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsome_dangsanxuat.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsome_dangsanxuat.ForeColor = System.Drawing.Color.Red
        Me.txtsome_dangsanxuat.Location = New System.Drawing.Point(628, 57)
        Me.txtsome_dangsanxuat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsome_dangsanxuat.Name = "txtsome_dangsanxuat"
        Me.txtsome_dangsanxuat.Size = New System.Drawing.Size(93, 35)
        Me.txtsome_dangsanxuat.TabIndex = 453
        Me.txtsome_dangsanxuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnDoPH
        '
        Me.BtnDoPH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnDoPH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDoPH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnDoPH.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDoPH.Location = New System.Drawing.Point(11, 3)
        Me.BtnDoPH.Name = "BtnDoPH"
        Me.BtnDoPH.Size = New System.Drawing.Size(149, 44)
        Me.BtnDoPH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnDoPH.Symbol = ""
        Me.BtnDoPH.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDoPH.TabIndex = 420
        Me.BtnDoPH.Text = "F5 - ĐO PH"
        Me.BtnDoPH.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'CboCongDoan_PH
        '
        Me.CboCongDoan_PH.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.CboCongDoan_PH, 2)
        Me.CboCongDoan_PH.DisplayMember = "Text"
        Me.CboCongDoan_PH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboCongDoan_PH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCongDoan_PH.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCongDoan_PH.FormattingEnabled = True
        Me.CboCongDoan_PH.ItemHeight = 30
        Me.CboCongDoan_PH.Location = New System.Drawing.Point(166, 7)
        Me.CboCongDoan_PH.Name = "CboCongDoan_PH"
        Me.CboCongDoan_PH.Size = New System.Drawing.Size(206, 36)
        Me.CboCongDoan_PH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CboCongDoan_PH.TabIndex = 418
        '
        'txtgiatri_min
        '
        Me.txtgiatri_min.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtgiatri_min.BackColor = System.Drawing.Color.Yellow
        Me.txtgiatri_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgiatri_min.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgiatri_min.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgiatri_min.ForeColor = System.Drawing.Color.Red
        Me.txtgiatri_min.Location = New System.Drawing.Point(377, 7)
        Me.txtgiatri_min.Margin = New System.Windows.Forms.Padding(2)
        Me.txtgiatri_min.Name = "txtgiatri_min"
        Me.txtgiatri_min.Size = New System.Drawing.Size(84, 35)
        Me.txtgiatri_min.TabIndex = 452
        Me.txtgiatri_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtgiatri_max
        '
        Me.txtgiatri_max.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtgiatri_max.BackColor = System.Drawing.Color.Yellow
        Me.txtgiatri_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgiatri_max.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgiatri_max.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgiatri_max.ForeColor = System.Drawing.Color.Red
        Me.txtgiatri_max.Location = New System.Drawing.Point(465, 7)
        Me.txtgiatri_max.Margin = New System.Windows.Forms.Padding(2)
        Me.txtgiatri_max.Name = "txtgiatri_max"
        Me.txtgiatri_max.Size = New System.Drawing.Size(105, 35)
        Me.txtgiatri_max.TabIndex = 486
        Me.txtgiatri_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnXacNhan_QuanLy
        '
        Me.btnXacNhan_QuanLy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXacNhan_QuanLy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXacNhan_QuanLy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXacNhan_QuanLy.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhan_QuanLy.Location = New System.Drawing.Point(11, 53)
        Me.btnXacNhan_QuanLy.Name = "btnXacNhan_QuanLy"
        Me.btnXacNhan_QuanLy.Size = New System.Drawing.Size(149, 44)
        Me.btnXacNhan_QuanLy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXacNhan_QuanLy.Symbol = ""
        Me.btnXacNhan_QuanLy.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnXacNhan_QuanLy.TabIndex = 420
        Me.btnXacNhan_QuanLy.Text = "F4 - GIỜ RA"
        Me.btnXacNhan_QuanLy.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'BtnExit_CapNhat
        '
        Me.BtnExit_CapNhat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit_CapNhat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit_CapNhat.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnExit_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit_CapNhat.Location = New System.Drawing.Point(631, 5)
        Me.BtnExit_CapNhat.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnExit_CapNhat.Name = "BtnExit_CapNhat"
        Me.BtnExit_CapNhat.Size = New System.Drawing.Size(87, 40)
        Me.BtnExit_CapNhat.TabIndex = 9
        Me.BtnExit_CapNhat.Text = "Thoát"
        Me.BtnExit_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit_CapNhat.UseVisualStyleBackColor = True
        '
        'txtmame_scanner
        '
        Me.txtmame_scanner.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmame_scanner.BackColor = System.Drawing.Color.Yellow
        Me.txtmame_scanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmame_scanner.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmame_scanner.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_scanner.ForeColor = System.Drawing.Color.Red
        Me.txtmame_scanner.Location = New System.Drawing.Point(133, 356)
        Me.txtmame_scanner.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmame_scanner.Name = "txtmame_scanner"
        Me.txtmame_scanner.Size = New System.Drawing.Size(270, 35)
        Me.txtmame_scanner.TabIndex = 453
        Me.txtmame_scanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnXacNhan_GioRa
        '
        Me.btnXacNhan_GioRa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXacNhan_GioRa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXacNhan_GioRa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXacNhan_GioRa.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhan_GioRa.Location = New System.Drawing.Point(134, 477)
        Me.btnXacNhan_GioRa.Name = "btnXacNhan_GioRa"
        Me.btnXacNhan_GioRa.Size = New System.Drawing.Size(268, 34)
        Me.btnXacNhan_GioRa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXacNhan_GioRa.Symbol = ""
        Me.btnXacNhan_GioRa.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnXacNhan_GioRa.TabIndex = 419
        Me.btnXacNhan_GioRa.Text = "F4 - GIỜ RA"
        Me.btnXacNhan_GioRa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnXacNhan_GioVao
        '
        Me.btnXacNhan_GioVao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXacNhan_GioVao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXacNhan_GioVao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXacNhan_GioVao.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhan_GioVao.Location = New System.Drawing.Point(134, 517)
        Me.btnXacNhan_GioVao.Name = "btnXacNhan_GioVao"
        Me.btnXacNhan_GioVao.Size = New System.Drawing.Size(268, 34)
        Me.btnXacNhan_GioVao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXacNhan_GioVao.Symbol = ""
        Me.btnXacNhan_GioVao.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnXacNhan_GioVao.TabIndex = 478
        Me.btnXacNhan_GioVao.Text = "F3 - GIỜ VÀO"
        Me.btnXacNhan_GioVao.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
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
        Me.Super_Dgv.Location = New System.Drawing.Point(22, 23)
        Me.Super_Dgv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.Super_Dgv.Size = New System.Drawing.Size(129, 119)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 417
        '
        'Super_Dgv_LenhSanXuat
        '
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.CaptionStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Thickness4.Bottom = 1
        Thickness4.Left = 1
        Thickness4.Right = 1
        Thickness4.Top = 1
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.CaptionStyles.Default.BorderThickness = Thickness4
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.CaptionStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.CaptionStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.CaptionStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.Bottom
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.ColumnHeaderStyles.Default.AllowMultiLine = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.ColumnHeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Thickness5.Bottom = 1
        Thickness5.Left = 1
        Thickness5.Right = 1
        Thickness5.Top = 1
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.ColumnHeaderStyles.Default.BorderThickness = Thickness5
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Background3.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.FilterRowStyles.Default.FilterBackground = Background3
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.GridPanelStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.GroupByStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Background4.Color1 = System.Drawing.Color.PapayaWhip
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.HeaderStyles.Default.Background = Background4
        BorderPattern2.Bottom = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        BorderPattern2.Left = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        BorderPattern2.Right = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        BorderPattern2.Top = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Solid
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.HeaderStyles.Default.BorderPattern = BorderPattern2
        Thickness6.Bottom = 1
        Thickness6.Left = 1
        Thickness6.Right = 1
        Thickness6.Top = 1
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.HeaderStyles.Default.BorderThickness = Thickness6
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.HeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_LenhSanXuat.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_LenhSanXuat.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square
        Me.Super_Dgv_LenhSanXuat.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv_LenhSanXuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv_LenhSanXuat.Location = New System.Drawing.Point(22, 369)
        Me.Super_Dgv_LenhSanXuat.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Super_Dgv_LenhSanXuat.Name = "Super_Dgv_LenhSanXuat"
        '
        '
        '
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        '
        '
        '
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Caption.AllowSelection = False
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Caption.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.BottomLeft
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Caption.EnableMarkup = False
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Caption.Text = ""
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Caption.Visible = False
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.CheckBoxSize = New System.Drawing.Size(20, 20)
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells
        '
        '
        '
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.ColumnHeader.RowHeaderText = ""
        BorderColor2.Bottom = System.Drawing.Color.Black
        BorderColor2.Left = System.Drawing.Color.Black
        BorderColor2.Right = System.Drawing.Color.Black
        BorderColor2.Top = System.Drawing.Color.Black
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor2
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.EnableColumnFiltering = True
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.EnableFiltering = True
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Filter.RowHeight = 30
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Filter.Visible = True
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.FilterExpr = ""
        '
        '
        '
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Footer.Text = ""
        '
        '
        '
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.GroupByRow.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.Copy
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.GroupByRow.Text = ""
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.GroupByRow.WatermarkText = "Kéo cột cần xem vào đây"
        '
        '
        '
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Header.BackgroundImageLayout = DevComponents.DotNetBar.SuperGrid.GridBackgroundImageLayout.TopLeft
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Header.EnableMarkup = False
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Header.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.Always
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Header.Text = ""
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Header.Visible = False
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.MinRowHeight = 30
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.NoRowsText = ""
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.ReadOnly = True
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.RowHeaderWidth = 45
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.Super_Dgv_LenhSanXuat.PrimaryGrid.Title.Text = ""
        Me.Super_Dgv_LenhSanXuat.Size = New System.Drawing.Size(129, 119)
        Me.Super_Dgv_LenhSanXuat.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv_LenhSanXuat.TabIndex = 417
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Super_Dgv, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Super_Dgv_LenhSanXuat, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(467, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(723, 732)
        Me.TableLayoutPanel1.TabIndex = 421
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Yellow
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(2, 714)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(16, 35)
        Me.TextBox1.TabIndex = 454
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Super_Dgv_Info
        '
        Me.Super_Dgv_Info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.Super_Dgv_Info, 3)
        Me.Super_Dgv_Info.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv_Info.Location = New System.Drawing.Point(3, 3)
        Me.Super_Dgv_Info.Name = "Super_Dgv_Info"
        '
        '
        '
        Me.Super_Dgv_Info.PrimaryGrid.AllowSelection = False
        Me.Super_Dgv_Info.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.Super_Dgv_Info.Size = New System.Drawing.Size(461, 348)
        Me.Super_Dgv_Info.TabIndex = 1
        Me.Super_Dgv_Info.Tag = "1"
        Me.Super_Dgv_Info.Text = "SuperGridControl1"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "process.png")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "promotion.png")
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Super_Dgv_Info, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtmame_scanner, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnXacNhan_GioRa, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnXacNhan_GioVao, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnClear, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox2, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(467, 732)
        Me.TableLayoutPanel2.TabIndex = 422
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(44, 360)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(84, 28)
        Me.LabelX2.TabIndex = 456
        Me.LabelX2.Text = "MÃ MẺ:"
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(408, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(56, 34)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.TabIndex = 480
        Me.btnClear.Text = ".."
        Me.btnClear.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.Yellow
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBox2, 3)
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Red
        Me.TextBox2.Location = New System.Drawing.Point(2, 396)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(463, 35)
        Me.TextBox2.TabIndex = 479
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmTimeLine_Confirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 732)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmTimeLine_Confirm"
        Me.Text = "frmTimeLine_Confirm"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnXacNhan_GioVao As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnXacNhan_GioRa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnExit_CapNhat As Button
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Super_Dgv_LenhSanXuat As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents CboCongDoan_PH As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtgiatri_min As TextBox
    Friend WithEvents txtgiatri_max As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Super_Dgv_Info As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents BtnDoPH As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtsome_dangsanxuat As TextBox
    Friend WithEvents txtmame_scanner As TextBox
    Friend WithEvents btnXacNhan_QuanLy As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBox2 As TextBox
End Class
