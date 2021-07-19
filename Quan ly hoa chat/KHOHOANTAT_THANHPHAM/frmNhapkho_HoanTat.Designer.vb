<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNhapkho_HoanTat
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderPattern1 As DevComponents.DotNetBar.SuperGrid.Style.BorderPattern = New DevComponents.DotNetBar.SuperGrid.Style.BorderPattern()
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.Dgv_chung = New System.Windows.Forms.DataGridView()
        Me.Timer_Stop_Scale = New System.Windows.Forms.Timer(Me.components)
        Me.Super_Dgv_Info = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtScale1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboghichu = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.RbdTem2 = New System.Windows.Forms.RadioButton()
        Me.cbophanloai = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.RdbTem1 = New System.Windows.Forms.RadioButton()
        Me.Panel_Detail = New System.Windows.Forms.Panel()
        Me.Dgv_Chitiet = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Timer_ReadScale_1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_save = New System.Windows.Forms.Timer(Me.components)
        Me.txtmacay = New System.Windows.Forms.TextBox()
        Me.Chk_Intem = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chkIn_Sokg = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtSocay_BeBe = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnMoc_bebe = New System.Windows.Forms.Button()
        Me.txtmame_F = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.Timer_save_1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtsometTP = New System.Windows.Forms.TextBox()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Rtx_1 = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RTX_PLC = New System.Windows.Forms.RichTextBox()
        Me.Panel_General = New System.Windows.Forms.Panel()
        CType(Me.Dgv_chung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Detail.SuspendLayout()
        CType(Me.Dgv_Chitiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel_General.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_chung
        '
        Me.Dgv_chung.AllowUserToAddRows = False
        Me.Dgv_chung.AllowUserToDeleteRows = False
        Me.Dgv_chung.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_chung.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_chung.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dgv_chung.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_chung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_chung.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_chung.ColumnHeadersHeight = 50
        Me.Dgv_chung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_chung.Location = New System.Drawing.Point(278, 205)
        Me.Dgv_chung.Name = "Dgv_chung"
        Me.Dgv_chung.ReadOnly = True
        Me.Dgv_chung.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_chung.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_chung.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_chung.RowTemplate.Height = 24
        Me.Dgv_chung.ShowEditingIcon = False
        Me.Dgv_chung.Size = New System.Drawing.Size(298, 105)
        Me.Dgv_chung.StandardTab = True
        Me.Dgv_chung.TabIndex = 438
        Me.Dgv_chung.VirtualMode = True
        '
        'Timer_Stop_Scale
        '
        Me.Timer_Stop_Scale.Interval = 200
        '
        'Super_Dgv_Info
        '
        Me.Super_Dgv_Info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.Super_Dgv_Info, 3)
        Me.Super_Dgv_Info.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv_Info.Location = New System.Drawing.Point(3, 23)
        Me.Super_Dgv_Info.Name = "Super_Dgv_Info"
        '
        '
        '
        Me.Super_Dgv_Info.PrimaryGrid.AllowSelection = False
        Me.Super_Dgv_Info.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.Super_Dgv_Info.Size = New System.Drawing.Size(417, 387)
        Me.Super_Dgv_Info.TabIndex = 439
        Me.Super_Dgv_Info.Tag = "1"
        Me.Super_Dgv_Info.Text = "SuperGridControl1"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 551)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 19)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "KG:"
        '
        'txtScale1
        '
        Me.txtScale1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScale1.BackColor = System.Drawing.Color.Maroon
        Me.txtScale1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScale1.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScale1.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.txtScale1.Location = New System.Drawing.Point(102, 543)
        Me.txtScale1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtScale1.Name = "txtScale1"
        Me.txtScale1.Size = New System.Drawing.Size(126, 39)
        Me.txtScale1.TabIndex = 145
        Me.txtScale1.Text = "0"
        Me.txtScale1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 598)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 19)
        Me.Label19.TabIndex = 163
        Me.Label19.Text = "Mét H.Tất"
        '
        'cboghichu
        '
        Me.cboghichu.DisplayMember = "Text"
        Me.cboghichu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboghichu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboghichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboghichu.FormattingEnabled = True
        Me.cboghichu.ItemHeight = 20
        Me.cboghichu.Items.AddRange(New Object() {Me.ComboItem5})
        Me.cboghichu.Location = New System.Drawing.Point(100, 507)
        Me.cboghichu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboghichu.Name = "cboghichu"
        Me.cboghichu.Size = New System.Drawing.Size(130, 26)
        Me.cboghichu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboghichu.TabIndex = 162
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "-"
        '
        'RbdTem2
        '
        Me.RbdTem2.AutoSize = True
        Me.RbdTem2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbdTem2.Location = New System.Drawing.Point(787, 36)
        Me.RbdTem2.Name = "RbdTem2"
        Me.RbdTem2.Size = New System.Drawing.Size(97, 25)
        Me.RbdTem2.TabIndex = 443
        Me.RbdTem2.TabStop = True
        Me.RbdTem2.Text = "TEM 2 (+BÌ)"
        Me.RbdTem2.UseVisualStyleBackColor = True
        '
        'cbophanloai
        '
        Me.cbophanloai.DisplayMember = "Text"
        Me.cbophanloai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbophanloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbophanloai.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbophanloai.FormattingEnabled = True
        Me.cbophanloai.ItemHeight = 22
        Me.cbophanloai.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cbophanloai.Location = New System.Drawing.Point(100, 472)
        Me.cbophanloai.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbophanloai.Name = "cbophanloai"
        Me.cbophanloai.Size = New System.Drawing.Size(130, 28)
        Me.cbophanloai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbophanloai.TabIndex = 161
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "A"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "B"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "C"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "D"
        '
        'RdbTem1
        '
        Me.RdbTem1.AutoSize = True
        Me.RdbTem1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbTem1.Location = New System.Drawing.Point(787, 3)
        Me.RdbTem1.Name = "RdbTem1"
        Me.RdbTem1.Size = New System.Drawing.Size(81, 25)
        Me.RdbTem1.TabIndex = 442
        Me.RdbTem1.TabStop = True
        Me.RdbTem1.Text = "TEM 1"
        Me.RdbTem1.UseVisualStyleBackColor = True
        '
        'Panel_Detail
        '
        Me.Panel_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Detail.Controls.Add(Me.Dgv_Chitiet)
        Me.Panel_Detail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Detail.Location = New System.Drawing.Point(434, 543)
        Me.Panel_Detail.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel_Detail.Name = "Panel_Detail"
        Me.Panel_Detail.Size = New System.Drawing.Size(760, 101)
        Me.Panel_Detail.TabIndex = 441
        '
        'Dgv_Chitiet
        '
        Me.Dgv_Chitiet.AllowUserToAddRows = False
        Me.Dgv_Chitiet.AllowUserToDeleteRows = False
        Me.Dgv_Chitiet.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Chitiet.DefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_Chitiet.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Dgv_Chitiet.Location = New System.Drawing.Point(164, 3)
        Me.Dgv_Chitiet.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Dgv_Chitiet.MultiSelect = False
        Me.Dgv_Chitiet.Name = "Dgv_Chitiet"
        Me.Dgv_Chitiet.ReadOnly = True
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Chitiet.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv_Chitiet.RowTemplate.Height = 24
        Me.Dgv_Chitiet.Size = New System.Drawing.Size(70, 79)
        Me.Dgv_Chitiet.TabIndex = 415
        '
        'Timer_save
        '
        Me.Timer_save.Interval = 1000
        '
        'txtmacay
        '
        Me.txtmacay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmacay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmacay.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmacay.Location = New System.Drawing.Point(100, 436)
        Me.txtmacay.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtmacay.Name = "txtmacay"
        Me.txtmacay.ReadOnly = True
        Me.txtmacay.Size = New System.Drawing.Size(130, 29)
        Me.txtmacay.TabIndex = 24
        '
        'Chk_Intem
        '
        Me.Chk_Intem.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Chk_Intem.AutoSize = True
        '
        '
        '
        Me.Chk_Intem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Chk_Intem.CheckSignSize = New System.Drawing.Size(30, 25)
        Me.Chk_Intem.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Intem.Location = New System.Drawing.Point(234, 508)
        Me.Chk_Intem.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Chk_Intem.Name = "Chk_Intem"
        Me.Chk_Intem.Size = New System.Drawing.Size(97, 27)
        Me.Chk_Intem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Chk_Intem.TabIndex = 46
        Me.Chk_Intem.Text = "In Tem"
        Me.Chk_Intem.TextColor = System.Drawing.Color.Red
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(2, 512)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 18)
        Me.Label25.TabIndex = 164
        Me.Label25.Text = "GHI CHÚ"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(2, 475)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 22)
        Me.Label23.TabIndex = 163
        Me.Label23.Text = "P.LOẠI"
        '
        'chkIn_Sokg
        '
        Me.chkIn_Sokg.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkIn_Sokg.AutoSize = True
        '
        '
        '
        Me.chkIn_Sokg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkIn_Sokg.CheckSignSize = New System.Drawing.Size(30, 25)
        Me.chkIn_Sokg.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIn_Sokg.Location = New System.Drawing.Point(234, 473)
        Me.chkIn_Sokg.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkIn_Sokg.Name = "chkIn_Sokg"
        Me.chkIn_Sokg.Size = New System.Drawing.Size(109, 27)
        Me.chkIn_Sokg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkIn_Sokg.TabIndex = 166
        Me.chkIn_Sokg.Text = "In Số Kg"
        Me.chkIn_Sokg.TextColor = System.Drawing.Color.Red
        '
        'txtSocay_BeBe
        '
        Me.txtSocay_BeBe.BackColor = System.Drawing.SystemColors.Info
        Me.txtSocay_BeBe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSocay_BeBe.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSocay_BeBe.Location = New System.Drawing.Point(234, 436)
        Me.txtSocay_BeBe.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSocay_BeBe.Name = "txtSocay_BeBe"
        Me.txtSocay_BeBe.ReadOnly = True
        Me.txtSocay_BeBe.Size = New System.Drawing.Size(41, 29)
        Me.txtSocay_BeBe.TabIndex = 157
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(2, 440)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 22)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "MÃ CÂY"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 11
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RbdTem2, 7, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdExit, 10, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnXoa, 9, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RdbTem1, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPrint, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnMoc_bebe, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtmame_F, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdNew, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 644)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1194, 75)
        Me.TableLayoutPanel2.TabIndex = 443
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdExit.Location = New System.Drawing.Point(1076, 3)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExit.Name = "cmdExit"
        Me.TableLayoutPanel2.SetRowSpan(Me.cmdExit, 2)
        Me.cmdExit.Size = New System.Drawing.Size(116, 58)
        Me.cmdExit.TabIndex = 155
        Me.cmdExit.Text = "THOÁT"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnXoa.Location = New System.Drawing.Point(956, 3)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnXoa.Name = "btnXoa"
        Me.TableLayoutPanel2.SetRowSpan(Me.btnXoa, 2)
        Me.btnXoa.Size = New System.Drawing.Size(110, 58)
        Me.btnXoa.TabIndex = 162
        Me.btnXoa.Text = "Xoá Cây"
        Me.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.WindowsApplication1.My.Resources.Resources.barcode
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(677, 3)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.TableLayoutPanel2.SetRowSpan(Me.btnPrint, 2)
        Me.btnPrint.Size = New System.Drawing.Size(105, 58)
        Me.btnPrint.TabIndex = 156
        Me.btnPrint.Text = "IN TEM"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnMoc_bebe
        '
        Me.btnMoc_bebe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoc_bebe.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoc_bebe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoc_bebe.Location = New System.Drawing.Point(534, 3)
        Me.btnMoc_bebe.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnMoc_bebe.Name = "btnMoc_bebe"
        Me.TableLayoutPanel2.SetRowSpan(Me.btnMoc_bebe, 2)
        Me.btnMoc_bebe.Size = New System.Drawing.Size(139, 58)
        Me.btnMoc_bebe.TabIndex = 245
        Me.btnMoc_bebe.Text = "BỂ BẾ (F12)"
        Me.btnMoc_bebe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMoc_bebe.UseVisualStyleBackColor = True
        '
        'txtmame_F
        '
        Me.txtmame_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmame_F.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtmame_F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmame_F.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmame_F.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.Location = New System.Drawing.Point(95, 8)
        Me.txtmame_F.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtmame_F.Name = "txtmame_F"
        Me.TableLayoutPanel2.SetRowSpan(Me.txtmame_F, 2)
        Me.txtmame_F.Size = New System.Drawing.Size(143, 48)
        Me.txtmame_F.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(382, 3)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.TableLayoutPanel2.SetRowSpan(Me.btnSave, 2)
        Me.btnSave.Size = New System.Drawing.Size(148, 58)
        Me.btnSave.TabIndex = 157
        Me.btnSave.Text = "LƯU (F10)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.TableLayoutPanel2.SetRowSpan(Me.Label2, 2)
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MẺ CĂNG"
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.Location = New System.Drawing.Point(242, 3)
        Me.cmdNew.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNew.Name = "cmdNew"
        Me.TableLayoutPanel2.SetRowSpan(Me.cmdNew, 2)
        Me.cmdNew.Size = New System.Drawing.Size(39, 58)
        Me.cmdNew.TabIndex = 150
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'Timer_save_1
        '
        Me.Timer_save_1.Interval = 1000
        '
        'txtsometTP
        '
        Me.txtsometTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsometTP.BackColor = System.Drawing.Color.Maroon
        Me.txtsometTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsometTP.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsometTP.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.txtsometTP.Location = New System.Drawing.Point(102, 588)
        Me.txtsometTP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsometTP.Name = "txtsometTP"
        Me.txtsometTP.Size = New System.Drawing.Size(126, 39)
        Me.txtsometTP.TabIndex = 161
        Me.txtsometTP.Text = "0"
        Me.txtsometTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Super_Dgv.Location = New System.Drawing.Point(18, 3)
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
        Me.Super_Dgv.Size = New System.Drawing.Size(184, 97)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 415
        '
        'Rtx_1
        '
        Me.Rtx_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rtx_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Rtx_1.Location = New System.Drawing.Point(528, 3)
        Me.Rtx_1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Rtx_1.Name = "Rtx_1"
        Me.Rtx_1.Size = New System.Drawing.Size(151, 97)
        Me.Rtx_1.TabIndex = 437
        Me.Rtx_1.Text = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Super_Dgv_Info, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtScale1, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cboghichu, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cbophanloai, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmacay, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Chk_Intem, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label25, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.chkIn_Sokg, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSocay_BeBe, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtsometTP, 1, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(434, 644)
        Me.TableLayoutPanel1.TabIndex = 442
        '
        'RTX_PLC
        '
        Me.RTX_PLC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTX_PLC.Location = New System.Drawing.Point(371, 3)
        Me.RTX_PLC.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RTX_PLC.Name = "RTX_PLC"
        Me.RTX_PLC.Size = New System.Drawing.Size(153, 97)
        Me.RTX_PLC.TabIndex = 416
        Me.RTX_PLC.Text = ""
        '
        'Panel_General
        '
        Me.Panel_General.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_General.Controls.Add(Me.Super_Dgv)
        Me.Panel_General.Controls.Add(Me.Rtx_1)
        Me.Panel_General.Controls.Add(Me.RTX_PLC)
        Me.Panel_General.Controls.Add(Me.Dgv_chung)
        Me.Panel_General.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_General.Location = New System.Drawing.Point(434, 0)
        Me.Panel_General.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel_General.Name = "Panel_General"
        Me.Panel_General.Size = New System.Drawing.Size(760, 543)
        Me.Panel_General.TabIndex = 440
        '
        'frmNhapkho_HoanTat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 719)
        Me.Controls.Add(Me.Panel_General)
        Me.Controls.Add(Me.Panel_Detail)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNhapkho_HoanTat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nhập Kho Hoàn Tất"
        CType(Me.Dgv_chung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Detail.ResumeLayout(False)
        CType(Me.Dgv_Chitiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel_General.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dgv_chung As DataGridView
    Friend WithEvents Timer_Stop_Scale As Timer
    Friend WithEvents Super_Dgv_Info As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtScale1 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cboghichu As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents cbophanloai As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents txtmacay As TextBox
    Friend WithEvents Chk_Intem As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents chkIn_Sokg As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtSocay_BeBe As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtsometTP As TextBox
    Friend WithEvents RbdTem2 As RadioButton
    Friend WithEvents RdbTem1 As RadioButton
    Friend WithEvents Panel_Detail As Panel
    Friend WithEvents Dgv_Chitiet As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Timer_ReadScale_1 As Timer
    Friend WithEvents Timer_save As Timer
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmdExit As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnMoc_bebe As Button
    Friend WithEvents txtmame_F As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdNew As Button
    Friend WithEvents Timer_save_1 As Timer
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Rtx_1 As RichTextBox
    Friend WithEvents RTX_PLC As RichTextBox
    Friend WithEvents Panel_General As Panel
End Class
