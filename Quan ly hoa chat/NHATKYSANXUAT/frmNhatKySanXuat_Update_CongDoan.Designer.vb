<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNhatKySanXuat_Update_CongDoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhatKySanXuat_Update_CongDoan))
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.PnPopup_Mamau = New System.Windows.Forms.Panel()
        Me.Dgv_mamau = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GP_Form_HuyCongDoan_DaSanXuat = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnHuy_GioRa = New System.Windows.Forms.Button()
        Me.cboLyDo_Huy = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnThoat_GP_HuyCongDoan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcongdoan_HuyLenh = New System.Windows.Forms.TextBox()
        Me.BtnHuy_GioVao = New System.Windows.Forms.Button()
        Me.GP_Form_May = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Refresh_Form_MayMoc = New System.Windows.Forms.Button()
        Me.cboMay = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_Update_Form_MayMoc = New System.Windows.Forms.Button()
        Me.BtnExit_Form_MayMoc = New System.Windows.Forms.Button()
        Me.txtcongdoan_chonmay = New System.Windows.Forms.TextBox()
        Me.txtnhommay_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GP_Form_KeHoach = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnXoaPhieu = New DevComponents.DotNetBar.ButtonX()
        Me.dtngay_casanxuat = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.Btn_Update_Form_KeHoachSX = New System.Windows.Forms.Button()
        Me.BtnExit_Form_KeHoachSX = New System.Windows.Forms.Button()
        Me.txtthutu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtphanloai_kehoach = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtsophieu_sx = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.CtxFunction = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.btnCopy_Cells = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPaste = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnReset_LenhSanXuat = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnHuyKeHoach = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Expand = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Colapse = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSave_ColumnFrozen = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMnuSelect = New DevComponents.DotNetBar.ButtonItem()
        Me.mnu_Select_All = New DevComponents.DotNetBar.ButtonItem()
        Me.mnu_Remove_ALL = New DevComponents.DotNetBar.ButtonItem()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.dtNgayxuat_chungtu = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkTatCa = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtmame_ghep_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtcongdoan_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmamau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtloaihang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmame_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btTim = New DevComponents.DotNetBar.ButtonX()
        Me.txtmahang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnHuyLenh = New DevComponents.DotNetBar.ButtonX()
        Me.BtnChuyenMay = New DevComponents.DotNetBar.ButtonX()
        Me.btnChon_NgayDuTinh = New DevComponents.DotNetBar.ButtonX()
        Me.btnChonNgay_BatDau = New DevComponents.DotNetBar.ButtonX()
        Me.BtnLuuThayDoi = New DevComponents.DotNetBar.ButtonX()
        Me.BtnCaSanXuat = New DevComponents.DotNetBar.ButtonX()
        Me.Timer_NgayDuTinh = New System.Windows.Forms.Timer(Me.components)
        Me.PnPopup_Mamau.SuspendLayout()
        CType(Me.Dgv_mamau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GP_Form_HuyCongDoan_DaSanXuat.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GP_Form_May.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GP_Form_KeHoach.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dtngay_casanxuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgayxuat_chungtu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnPopup_Mamau
        '
        Me.PnPopup_Mamau.Controls.Add(Me.Dgv_mamau)
        Me.PnPopup_Mamau.Location = New System.Drawing.Point(973, 158)
        Me.PnPopup_Mamau.Margin = New System.Windows.Forms.Padding(5)
        Me.PnPopup_Mamau.Name = "PnPopup_Mamau"
        Me.PnPopup_Mamau.Size = New System.Drawing.Size(102, 60)
        Me.PnPopup_Mamau.TabIndex = 518
        '
        'Dgv_mamau
        '
        Me.Dgv_mamau.AllowUserToAddRows = False
        Me.Dgv_mamau.AllowUserToDeleteRows = False
        Me.Dgv_mamau.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_mamau.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_mamau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_mamau.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dgv_mamau.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_mamau.ColumnHeadersHeight = 40
        Me.Dgv_mamau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_mamau.Location = New System.Drawing.Point(20, 14)
        Me.Dgv_mamau.Margin = New System.Windows.Forms.Padding(5)
        Me.Dgv_mamau.Name = "Dgv_mamau"
        Me.Dgv_mamau.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_mamau.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_mamau.RowHeadersWidth = 45
        Me.Dgv_mamau.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_mamau.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_mamau.RowTemplate.Height = 24
        Me.Dgv_mamau.Size = New System.Drawing.Size(66, 35)
        Me.Dgv_mamau.TabIndex = 374
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GP_Form_HuyCongDoan_DaSanXuat)
        Me.Panel1.Controls.Add(Me.GP_Form_May)
        Me.Panel1.Controls.Add(Me.GP_Form_KeHoach)
        Me.Panel1.Controls.Add(Me.ContextMenuBar1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1296, 557)
        Me.Panel1.TabIndex = 520
        '
        'GP_Form_HuyCongDoan_DaSanXuat
        '
        Me.GP_Form_HuyCongDoan_DaSanXuat.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form_HuyCongDoan_DaSanXuat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form_HuyCongDoan_DaSanXuat.Controls.Add(Me.TableLayoutPanel6)
        Me.GP_Form_HuyCongDoan_DaSanXuat.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form_HuyCongDoan_DaSanXuat.Location = New System.Drawing.Point(51, 359)
        Me.GP_Form_HuyCongDoan_DaSanXuat.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form_HuyCongDoan_DaSanXuat.Name = "GP_Form_HuyCongDoan_DaSanXuat"
        Me.GP_Form_HuyCongDoan_DaSanXuat.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form_HuyCongDoan_DaSanXuat.Size = New System.Drawing.Size(494, 177)
        '
        '
        '
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BackColorGradientAngle = 90
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BorderBottomWidth = 1
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BorderLeftWidth = 1
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BorderRightWidth = 1
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.BorderTopWidth = 1
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.CornerDiameter = 4
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form_HuyCongDoan_DaSanXuat.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form_HuyCongDoan_DaSanXuat.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form_HuyCongDoan_DaSanXuat.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form_HuyCongDoan_DaSanXuat.TabIndex = 463
        Me.GP_Form_HuyCongDoan_DaSanXuat.Text = "HỦY GIỜ SẢN XUẤT"
        Me.GP_Form_HuyCongDoan_DaSanXuat.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form_HuyCongDoan_DaSanXuat.Visible = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.BtnHuy_GioRa, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.cboLyDo_Huy, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.BtnThoat_GP_HuyCongDoan, 2, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txtcongdoan_HuyLenh, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.BtnHuy_GioVao, 0, 2)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(464, 153)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'BtnHuy_GioRa
        '
        Me.BtnHuy_GioRa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHuy_GioRa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHuy_GioRa.Image = Global.WindowsApplication1.My.Resources.Resources.delete_24
        Me.BtnHuy_GioRa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHuy_GioRa.Location = New System.Drawing.Point(152, 93)
        Me.BtnHuy_GioRa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnHuy_GioRa.Name = "BtnHuy_GioRa"
        Me.BtnHuy_GioRa.Size = New System.Drawing.Size(134, 45)
        Me.BtnHuy_GioRa.TabIndex = 464
        Me.BtnHuy_GioRa.Text = "HỦY GIỜ RA"
        Me.BtnHuy_GioRa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHuy_GioRa.UseVisualStyleBackColor = True
        '
        'cboLyDo_Huy
        '
        Me.cboLyDo_Huy.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.SetColumnSpan(Me.cboLyDo_Huy, 2)
        Me.cboLyDo_Huy.DisplayMember = "Text"
        Me.cboLyDo_Huy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLyDo_Huy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLyDo_Huy.FocusHighlightEnabled = True
        Me.cboLyDo_Huy.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLyDo_Huy.FormattingEnabled = True
        Me.cboLyDo_Huy.ItemHeight = 24
        Me.cboLyDo_Huy.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboLyDo_Huy.Location = New System.Drawing.Point(150, 50)
        Me.cboLyDo_Huy.Margin = New System.Windows.Forms.Padding(2)
        Me.cboLyDo_Huy.Name = "cboLyDo_Huy"
        Me.cboLyDo_Huy.Size = New System.Drawing.Size(312, 30)
        Me.cboLyDo_Huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.cboLyDo_Huy.TabIndex = 464
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "LOANG MÀU"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "CHUYỂN MÀU"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "HÀNG LỖI"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 524
        Me.Label5.Text = "LÝ DO:"
        '
        'BtnThoat_GP_HuyCongDoan
        '
        Me.BtnThoat_GP_HuyCongDoan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnThoat_GP_HuyCongDoan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnThoat_GP_HuyCongDoan.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnThoat_GP_HuyCongDoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnThoat_GP_HuyCongDoan.Location = New System.Drawing.Point(295, 95)
        Me.BtnThoat_GP_HuyCongDoan.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnThoat_GP_HuyCongDoan.Name = "BtnThoat_GP_HuyCongDoan"
        Me.BtnThoat_GP_HuyCongDoan.Size = New System.Drawing.Size(164, 41)
        Me.BtnThoat_GP_HuyCongDoan.TabIndex = 454
        Me.BtnThoat_GP_HuyCongDoan.Text = "Thoát"
        Me.BtnThoat_GP_HuyCongDoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnThoat_GP_HuyCongDoan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(35, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 520
        Me.Label3.Text = "CÔNG ĐOẠN:"
        '
        'txtcongdoan_HuyLenh
        '
        Me.txtcongdoan_HuyLenh.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcongdoan_HuyLenh.BackColor = System.Drawing.SystemColors.Window
        Me.txtcongdoan_HuyLenh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcongdoan_HuyLenh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel6.SetColumnSpan(Me.txtcongdoan_HuyLenh, 2)
        Me.txtcongdoan_HuyLenh.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtcongdoan_HuyLenh.Location = New System.Drawing.Point(153, 6)
        Me.txtcongdoan_HuyLenh.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcongdoan_HuyLenh.Name = "txtcongdoan_HuyLenh"
        Me.txtcongdoan_HuyLenh.ReadOnly = True
        Me.txtcongdoan_HuyLenh.Size = New System.Drawing.Size(306, 28)
        Me.txtcongdoan_HuyLenh.TabIndex = 519
        '
        'BtnHuy_GioVao
        '
        Me.BtnHuy_GioVao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHuy_GioVao.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHuy_GioVao.Image = Global.WindowsApplication1.My.Resources.Resources.delete_24
        Me.BtnHuy_GioVao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHuy_GioVao.Location = New System.Drawing.Point(4, 93)
        Me.BtnHuy_GioVao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnHuy_GioVao.Name = "BtnHuy_GioVao"
        Me.BtnHuy_GioVao.Size = New System.Drawing.Size(140, 45)
        Me.BtnHuy_GioVao.TabIndex = 453
        Me.BtnHuy_GioVao.Text = "HỦY GIỜ VÀO"
        Me.BtnHuy_GioVao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHuy_GioVao.UseVisualStyleBackColor = True
        '
        'GP_Form_May
        '
        Me.GP_Form_May.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form_May.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form_May.Controls.Add(Me.TableLayoutPanel5)
        Me.GP_Form_May.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form_May.Location = New System.Drawing.Point(10, 131)
        Me.GP_Form_May.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form_May.Name = "GP_Form_May"
        Me.GP_Form_May.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form_May.Size = New System.Drawing.Size(494, 177)
        '
        '
        '
        Me.GP_Form_May.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form_May.Style.BackColorGradientAngle = 90
        Me.GP_Form_May.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form_May.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_May.Style.BorderBottomWidth = 1
        Me.GP_Form_May.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form_May.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_May.Style.BorderLeftWidth = 1
        Me.GP_Form_May.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_May.Style.BorderRightWidth = 1
        Me.GP_Form_May.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_May.Style.BorderTopWidth = 1
        Me.GP_Form_May.Style.CornerDiameter = 4
        Me.GP_Form_May.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form_May.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form_May.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form_May.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form_May.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form_May.TabIndex = 462
        Me.GP_Form_May.Text = "Cập Nhật Máy - Thiết Bị"
        Me.GP_Form_May.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form_May.Visible = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Btn_Refresh_Form_MayMoc, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.cboMay, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Btn_Update_Form_MayMoc, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.BtnExit_Form_MayMoc, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.txtcongdoan_chonmay, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txtnhommay_id, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(464, 153)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Btn_Refresh_Form_MayMoc
        '
        Me.Btn_Refresh_Form_MayMoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Refresh_Form_MayMoc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Refresh_Form_MayMoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Refresh_Form_MayMoc.Location = New System.Drawing.Point(4, 83)
        Me.Btn_Refresh_Form_MayMoc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Refresh_Form_MayMoc.Name = "Btn_Refresh_Form_MayMoc"
        Me.Btn_Refresh_Form_MayMoc.Size = New System.Drawing.Size(94, 55)
        Me.Btn_Refresh_Form_MayMoc.TabIndex = 464
        Me.Btn_Refresh_Form_MayMoc.Text = "..."
        Me.Btn_Refresh_Form_MayMoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Refresh_Form_MayMoc.UseVisualStyleBackColor = True
        '
        'cboMay
        '
        Me.cboMay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.SetColumnSpan(Me.cboMay, 2)
        Me.cboMay.DisplayMember = "Text"
        Me.cboMay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMay.FocusHighlightEnabled = True
        Me.cboMay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMay.FormattingEnabled = True
        Me.cboMay.ItemHeight = 24
        Me.cboMay.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem5})
        Me.cboMay.Location = New System.Drawing.Point(104, 45)
        Me.cboMay.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMay.Name = "cboMay"
        Me.cboMay.Size = New System.Drawing.Size(358, 30)
        Me.cboMay.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.cboMay.TabIndex = 453
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Theo Công Đoạn"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Theo Mã Hàng"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 18)
        Me.Label10.TabIndex = 523
        Me.Label10.Text = "CHỌN MÁY:"
        '
        'Btn_Update_Form_MayMoc
        '
        Me.Btn_Update_Form_MayMoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Update_Form_MayMoc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update_Form_MayMoc.Image = CType(resources.GetObject("Btn_Update_Form_MayMoc.Image"), System.Drawing.Image)
        Me.Btn_Update_Form_MayMoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Update_Form_MayMoc.Location = New System.Drawing.Point(106, 83)
        Me.Btn_Update_Form_MayMoc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Update_Form_MayMoc.Name = "Btn_Update_Form_MayMoc"
        Me.Btn_Update_Form_MayMoc.Size = New System.Drawing.Size(137, 55)
        Me.Btn_Update_Form_MayMoc.TabIndex = 453
        Me.Btn_Update_Form_MayMoc.Text = "Cập Nhật"
        Me.Btn_Update_Form_MayMoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Update_Form_MayMoc.UseVisualStyleBackColor = True
        '
        'BtnExit_Form_MayMoc
        '
        Me.BtnExit_Form_MayMoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit_Form_MayMoc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit_Form_MayMoc.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnExit_Form_MayMoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit_Form_MayMoc.Location = New System.Drawing.Point(252, 85)
        Me.BtnExit_Form_MayMoc.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnExit_Form_MayMoc.Name = "BtnExit_Form_MayMoc"
        Me.BtnExit_Form_MayMoc.Size = New System.Drawing.Size(207, 51)
        Me.BtnExit_Form_MayMoc.TabIndex = 454
        Me.BtnExit_Form_MayMoc.Text = "Thoát"
        Me.BtnExit_Form_MayMoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit_Form_MayMoc.UseVisualStyleBackColor = True
        '
        'txtcongdoan_chonmay
        '
        Me.txtcongdoan_chonmay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcongdoan_chonmay.BackColor = System.Drawing.SystemColors.Window
        Me.txtcongdoan_chonmay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcongdoan_chonmay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcongdoan_chonmay.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtcongdoan_chonmay.Location = New System.Drawing.Point(252, 6)
        Me.txtcongdoan_chonmay.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcongdoan_chonmay.Name = "txtcongdoan_chonmay"
        Me.txtcongdoan_chonmay.ReadOnly = True
        Me.txtcongdoan_chonmay.Size = New System.Drawing.Size(207, 28)
        Me.txtcongdoan_chonmay.TabIndex = 519
        '
        'txtnhommay_id
        '
        Me.txtnhommay_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnhommay_id.BackColor = System.Drawing.SystemColors.Window
        Me.txtnhommay_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnhommay_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnhommay_id.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtnhommay_id.Location = New System.Drawing.Point(5, 6)
        Me.txtnhommay_id.Margin = New System.Windows.Forms.Padding(5)
        Me.txtnhommay_id.Name = "txtnhommay_id"
        Me.txtnhommay_id.ReadOnly = True
        Me.txtnhommay_id.Size = New System.Drawing.Size(92, 28)
        Me.txtnhommay_id.TabIndex = 524
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(134, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 520
        Me.Label4.Text = "CÔNG ĐOẠN:"
        '
        'GP_Form_KeHoach
        '
        Me.GP_Form_KeHoach.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form_KeHoach.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form_KeHoach.Controls.Add(Me.TableLayoutPanel4)
        Me.GP_Form_KeHoach.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form_KeHoach.Location = New System.Drawing.Point(578, 33)
        Me.GP_Form_KeHoach.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form_KeHoach.Name = "GP_Form_KeHoach"
        Me.GP_Form_KeHoach.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form_KeHoach.Size = New System.Drawing.Size(480, 188)
        '
        '
        '
        Me.GP_Form_KeHoach.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form_KeHoach.Style.BackColorGradientAngle = 90
        Me.GP_Form_KeHoach.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form_KeHoach.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_KeHoach.Style.BorderBottomWidth = 1
        Me.GP_Form_KeHoach.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form_KeHoach.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_KeHoach.Style.BorderLeftWidth = 1
        Me.GP_Form_KeHoach.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_KeHoach.Style.BorderRightWidth = 1
        Me.GP_Form_KeHoach.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_KeHoach.Style.BorderTopWidth = 1
        Me.GP_Form_KeHoach.Style.CornerDiameter = 4
        Me.GP_Form_KeHoach.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form_KeHoach.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form_KeHoach.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form_KeHoach.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form_KeHoach.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form_KeHoach.TabIndex = 461
        Me.GP_Form_KeHoach.Text = "Cập Nhật Ca Sản Xuất"
        Me.GP_Form_KeHoach.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form_KeHoach.Visible = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.BtnXoaPhieu, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.dtngay_casanxuat, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cboCa, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Update_Form_KeHoachSX, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnExit_Form_KeHoachSX, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtthutu, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtphanloai_kehoach, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtsophieu_sx, 2, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(450, 164)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'BtnXoaPhieu
        '
        Me.BtnXoaPhieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnXoaPhieu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnXoaPhieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnXoaPhieu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnXoaPhieu.Image = CType(resources.GetObject("BtnXoaPhieu.Image"), System.Drawing.Image)
        Me.BtnXoaPhieu.Location = New System.Drawing.Point(2, 101)
        Me.BtnXoaPhieu.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnXoaPhieu.Name = "BtnXoaPhieu"
        Me.BtnXoaPhieu.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.BtnXoaPhieu.Size = New System.Drawing.Size(108, 51)
        Me.BtnXoaPhieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.BtnXoaPhieu.Symbol = ""
        Me.BtnXoaPhieu.TabIndex = 538
        Me.BtnXoaPhieu.Text = "XÓA PHIẾU"
        Me.BtnXoaPhieu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right
        '
        'dtngay_casanxuat
        '
        Me.dtngay_casanxuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtngay_casanxuat.AutoSelectDate = True
        '
        '
        '
        Me.dtngay_casanxuat.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtngay_casanxuat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtngay_casanxuat.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtngay_casanxuat.ButtonDropDown.Visible = True
        Me.dtngay_casanxuat.CustomFormat = "dd/MM/yy"
        Me.dtngay_casanxuat.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector
        Me.dtngay_casanxuat.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtngay_casanxuat.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtngay_casanxuat.IsPopupCalendarOpen = False
        Me.dtngay_casanxuat.Location = New System.Drawing.Point(114, 5)
        Me.dtngay_casanxuat.Margin = New System.Windows.Forms.Padding(2)
        '
        '
        '
        '
        '
        '
        Me.dtngay_casanxuat.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtngay_casanxuat.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtngay_casanxuat.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtngay_casanxuat.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtngay_casanxuat.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtngay_casanxuat.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtngay_casanxuat.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtngay_casanxuat.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtngay_casanxuat.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtngay_casanxuat.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtngay_casanxuat.MonthCalendar.DisplayMonth = New Date(2014, 11, 1, 0, 0, 0, 0)
        Me.dtngay_casanxuat.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtngay_casanxuat.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtngay_casanxuat.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtngay_casanxuat.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtngay_casanxuat.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtngay_casanxuat.MonthCalendar.TodayButtonVisible = True
        Me.dtngay_casanxuat.Name = "dtngay_casanxuat"
        Me.dtngay_casanxuat.ShowUpDown = True
        Me.dtngay_casanxuat.Size = New System.Drawing.Size(151, 35)
        Me.dtngay_casanxuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtngay_casanxuat.TabIndex = 527
        Me.dtngay_casanxuat.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dtngay_casanxuat.WatermarkText = "Từ ngày"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 36)
        Me.Label2.TabIndex = 528
        Me.Label2.Text = "NGÀY LẬP KẾ HOẠCH"
        '
        'cboCa
        '
        Me.cboCa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCa.DisplayMember = "Text"
        Me.cboCa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCa.FocusHighlightEnabled = True
        Me.cboCa.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCa.FormattingEnabled = True
        Me.cboCa.ItemHeight = 29
        Me.cboCa.Items.AddRange(New Object() {Me.ComboItem8, Me.ComboItem9})
        Me.cboCa.Location = New System.Drawing.Point(269, 5)
        Me.cboCa.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCa.Name = "cboCa"
        Me.cboCa.Size = New System.Drawing.Size(120, 35)
        Me.cboCa.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.cboCa.TabIndex = 526
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "N"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "D"
        '
        'Btn_Update_Form_KeHoachSX
        '
        Me.Btn_Update_Form_KeHoachSX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Update_Form_KeHoachSX.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update_Form_KeHoachSX.Image = CType(resources.GetObject("Btn_Update_Form_KeHoachSX.Image"), System.Drawing.Image)
        Me.Btn_Update_Form_KeHoachSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Update_Form_KeHoachSX.Location = New System.Drawing.Point(116, 102)
        Me.Btn_Update_Form_KeHoachSX.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Update_Form_KeHoachSX.Name = "Btn_Update_Form_KeHoachSX"
        Me.Btn_Update_Form_KeHoachSX.Size = New System.Drawing.Size(147, 49)
        Me.Btn_Update_Form_KeHoachSX.TabIndex = 453
        Me.Btn_Update_Form_KeHoachSX.Text = "Cập Nhật"
        Me.Btn_Update_Form_KeHoachSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Update_Form_KeHoachSX.UseVisualStyleBackColor = True
        '
        'BtnExit_Form_KeHoachSX
        '
        Me.BtnExit_Form_KeHoachSX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.SetColumnSpan(Me.BtnExit_Form_KeHoachSX, 2)
        Me.BtnExit_Form_KeHoachSX.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit_Form_KeHoachSX.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnExit_Form_KeHoachSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit_Form_KeHoachSX.Location = New System.Drawing.Point(272, 104)
        Me.BtnExit_Form_KeHoachSX.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnExit_Form_KeHoachSX.Name = "BtnExit_Form_KeHoachSX"
        Me.BtnExit_Form_KeHoachSX.Size = New System.Drawing.Size(165, 45)
        Me.BtnExit_Form_KeHoachSX.TabIndex = 454
        Me.BtnExit_Form_KeHoachSX.Text = "Thoát"
        Me.BtnExit_Form_KeHoachSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit_Form_KeHoachSX.UseVisualStyleBackColor = True
        '
        'txtthutu
        '
        Me.txtthutu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtthutu.Border.Class = "TextBoxBorder"
        Me.txtthutu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtthutu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtthutu.DisabledBackColor = System.Drawing.Color.White
        Me.txtthutu.FocusHighlightEnabled = True
        Me.txtthutu.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtthutu.Location = New System.Drawing.Point(393, 5)
        Me.txtthutu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtthutu.Name = "txtthutu"
        Me.txtthutu.Size = New System.Drawing.Size(47, 35)
        Me.txtthutu.TabIndex = 530
        Me.txtthutu.WatermarkColor = System.Drawing.Color.Blue
        Me.txtthutu.WatermarkFont = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtphanloai_kehoach
        '
        Me.txtphanloai_kehoach.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtphanloai_kehoach.Border.Class = "TextBoxBorder"
        Me.txtphanloai_kehoach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtphanloai_kehoach.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtphanloai_kehoach.DisabledBackColor = System.Drawing.Color.White
        Me.txtphanloai_kehoach.FocusHighlightEnabled = True
        Me.txtphanloai_kehoach.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphanloai_kehoach.Location = New System.Drawing.Point(114, 54)
        Me.txtphanloai_kehoach.Margin = New System.Windows.Forms.Padding(2)
        Me.txtphanloai_kehoach.Name = "txtphanloai_kehoach"
        Me.txtphanloai_kehoach.ReadOnly = True
        Me.txtphanloai_kehoach.Size = New System.Drawing.Size(151, 35)
        Me.txtphanloai_kehoach.TabIndex = 529
        Me.txtphanloai_kehoach.WatermarkColor = System.Drawing.Color.Blue
        Me.txtphanloai_kehoach.WatermarkFont = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtsophieu_sx
        '
        Me.txtsophieu_sx.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtsophieu_sx.Border.Class = "TextBoxBorder"
        Me.txtsophieu_sx.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtsophieu_sx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsophieu_sx.DisabledBackColor = System.Drawing.Color.White
        Me.txtsophieu_sx.FocusHighlightEnabled = True
        Me.txtsophieu_sx.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsophieu_sx.Location = New System.Drawing.Point(269, 54)
        Me.txtsophieu_sx.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsophieu_sx.Name = "txtsophieu_sx"
        Me.txtsophieu_sx.ReadOnly = True
        Me.txtsophieu_sx.Size = New System.Drawing.Size(120, 35)
        Me.txtsophieu_sx.TabIndex = 531
        Me.txtsophieu_sx.WatermarkColor = System.Drawing.Color.Blue
        Me.txtsophieu_sx.WatermarkFont = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu, Me.CtxMnuSelect})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(10, 89)
        Me.ContextMenuBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(234, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 435
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'CtxFunction
        '
        Me.CtxFunction.AutoExpandOnClick = True
        Me.CtxFunction.Name = "CtxFunction"
        Me.CtxFunction.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction_Refresh, Me.LabelItem1, Me.btnCopy_Cells, Me.btnPaste, Me.BtnReset_LenhSanXuat, Me.BtnHuyKeHoach})
        Me.CtxFunction.Text = "Function"
        '
        'CtxFunction_Refresh
        '
        Me.CtxFunction_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.CtxFunction_Refresh.Name = "CtxFunction_Refresh"
        Me.CtxFunction_Refresh.Text = "Làm Mới"
        '
        'LabelItem1
        '
        Me.LabelItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem1.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.PaddingBottom = 1
        Me.LabelItem1.PaddingLeft = 10
        Me.LabelItem1.PaddingTop = 1
        Me.LabelItem1.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem1.Text = "Copy"
        '
        'btnCopy_Cells
        '
        Me.btnCopy_Cells.Name = "btnCopy_Cells"
        Me.btnCopy_Cells.Text = "Copy"
        '
        'btnPaste
        '
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Text = "Dán"
        '
        'BtnReset_LenhSanXuat
        '
        Me.BtnReset_LenhSanXuat.Name = "BtnReset_LenhSanXuat"
        Me.BtnReset_LenhSanXuat.Text = "Đặt Lại Thứ Tự Sản Xuất"
        '
        'BtnHuyKeHoach
        '
        Me.BtnHuyKeHoach.Name = "BtnHuyKeHoach"
        Me.BtnHuyKeHoach.Text = "Hủy Kế Hoạch"
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
        'Super_Dgv
        '
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        Thickness1.Bottom = 1
        Thickness1.Left = 1
        Thickness1.Right = 1
        Thickness1.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.BorderThickness = Thickness1
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.AllowMultiLine = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Thickness3.Bottom = 1
        Thickness3.Left = 1
        Thickness3.Right = 1
        Thickness3.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.BorderThickness = Thickness3
        Me.Super_Dgv.DefaultVisualStyles.HeaderStyles.Default.RowHeaderStyle.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.Super_Dgv.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square
        Me.Super_Dgv.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.Location = New System.Drawing.Point(28, 24)
        Me.Super_Dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.Super_Dgv.Name = "Super_Dgv"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.None
        Me.Super_Dgv.PrimaryGrid.AllowEdit = False
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
        Me.Super_Dgv.PrimaryGrid.CollapseImage = Global.WindowsApplication1.My.Resources.Resources.add_item
        Me.Super_Dgv.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.MinRowHeight = 40
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.RowHeaderText = ""
        Me.Super_Dgv.PrimaryGrid.ColumnHeader.RowHeight = 40
        BorderColor1.Bottom = System.Drawing.Color.Black
        BorderColor1.Left = System.Drawing.Color.Black
        BorderColor1.Right = System.Drawing.Color.Black
        BorderColor1.Top = System.Drawing.Color.Black
        Me.Super_Dgv.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor1
        Me.Super_Dgv.PrimaryGrid.EnableColumnFiltering = True
        Me.Super_Dgv.PrimaryGrid.EnableFiltering = True
        Me.Super_Dgv.PrimaryGrid.EnableRowFiltering = True
        Me.Super_Dgv.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Circle
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Filter.RowHeight = 30
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
        Me.Super_Dgv.PrimaryGrid.Header.Visible = False
        Me.Super_Dgv.PrimaryGrid.MinRowHeight = 30
        Me.Super_Dgv.PrimaryGrid.NoRowsText = ""
        Me.Super_Dgv.PrimaryGrid.ReadOnly = True
        Me.Super_Dgv.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.Super_Dgv.PrimaryGrid.RowHeaderWidth = 30
        Me.Super_Dgv.PrimaryGrid.RowHighlightType = DevComponents.DotNetBar.SuperGrid.RowHighlightType.None
        Me.Super_Dgv.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.Super_Dgv.PrimaryGrid.Title.Text = ""
        Me.Super_Dgv.Size = New System.Drawing.Size(113, 47)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 434
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
        Me.dtNgayxuat_chungtu.CustomFormat = "dd/MM/yy"
        Me.dtNgayxuat_chungtu.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector
        Me.dtNgayxuat_chungtu.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtNgayxuat_chungtu.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtNgayxuat_chungtu.IsPopupCalendarOpen = False
        Me.dtNgayxuat_chungtu.Location = New System.Drawing.Point(719, 3)
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
        Me.dtNgayxuat_chungtu.Size = New System.Drawing.Size(107, 28)
        Me.dtNgayxuat_chungtu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtNgayxuat_chungtu.TabIndex = 531
        Me.dtNgayxuat_chungtu.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dtNgayxuat_chungtu.WatermarkText = "Từ ngày"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(541, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 18)
        Me.Label1.TabIndex = 532
        Me.Label1.Text = "NGÀY DỰ TÍNH LSX"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 12
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.chkTatCa, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame_ghep_F, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtcongdoan_F, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmamau_F, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmau_F, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtloaihang_F, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame_F, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btTim, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmahang_F, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 625)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1296, 42)
        Me.TableLayoutPanel1.TabIndex = 522
        '
        'chkTatCa
        '
        Me.chkTatCa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTatCa.AutoSize = True
        '
        '
        '
        Me.chkTatCa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkTatCa.CheckSignSize = New System.Drawing.Size(30, 20)
        Me.chkTatCa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTatCa.Location = New System.Drawing.Point(147, 6)
        Me.chkTatCa.Name = "chkTatCa"
        Me.chkTatCa.Size = New System.Drawing.Size(87, 22)
        Me.chkTatCa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkTatCa.TabIndex = 486
        Me.chkTatCa.Text = "Tất Cả"
        '
        'txtmame_ghep_F
        '
        Me.txtmame_ghep_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmame_ghep_F.Border.Class = "TextBoxBorder"
        Me.txtmame_ghep_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmame_ghep_F.FocusHighlightEnabled = True
        Me.txtmame_ghep_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_ghep_F.Location = New System.Drawing.Point(848, 4)
        Me.txtmame_ghep_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmame_ghep_F.Name = "txtmame_ghep_F"
        Me.txtmame_ghep_F.Size = New System.Drawing.Size(140, 26)
        Me.txtmame_ghep_F.TabIndex = 463
        Me.txtmame_ghep_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmame_ghep_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_ghep_F.WatermarkText = "Mẻ Ghép"
        Me.txtmame_ghep_F.WordWrap = False
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
        Me.txtcongdoan_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcongdoan_F.Location = New System.Drawing.Point(730, 4)
        Me.txtcongdoan_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcongdoan_F.Name = "txtcongdoan_F"
        Me.txtcongdoan_F.Size = New System.Drawing.Size(114, 26)
        Me.txtcongdoan_F.TabIndex = 409
        Me.txtcongdoan_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtcongdoan_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcongdoan_F.WatermarkText = "Công Đoạn"
        Me.txtcongdoan_F.WordWrap = False
        '
        'txtmamau_F
        '
        Me.txtmamau_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmamau_F.Border.Class = "TextBoxBorder"
        Me.txtmamau_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmamau_F.FocusHighlightEnabled = True
        Me.txtmamau_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau_F.Location = New System.Drawing.Point(526, 4)
        Me.txtmamau_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmamau_F.Name = "txtmamau_F"
        Me.txtmamau_F.Size = New System.Drawing.Size(96, 26)
        Me.txtmamau_F.TabIndex = 393
        Me.txtmamau_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmamau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau_F.WatermarkText = "Mã Màu"
        Me.txtmamau_F.WordWrap = False
        '
        'txtmau_F
        '
        Me.txtmau_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmau_F.Border.Class = "TextBoxBorder"
        Me.txtmau_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmau_F.FocusHighlightEnabled = True
        Me.txtmau_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmau_F.Location = New System.Drawing.Point(626, 4)
        Me.txtmau_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmau_F.Name = "txtmau_F"
        Me.txtmau_F.Size = New System.Drawing.Size(100, 26)
        Me.txtmau_F.TabIndex = 394
        Me.txtmau_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmau_F.WatermarkText = "Màu"
        Me.txtmau_F.WordWrap = False
        '
        'txtloaihang_F
        '
        Me.txtloaihang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtloaihang_F.Border.Class = "TextBoxBorder"
        Me.txtloaihang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtloaihang_F.FocusHighlightEnabled = True
        Me.txtloaihang_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.Location = New System.Drawing.Point(441, 4)
        Me.txtloaihang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtloaihang_F.Name = "txtloaihang_F"
        Me.txtloaihang_F.Size = New System.Drawing.Size(81, 26)
        Me.txtloaihang_F.TabIndex = 392
        Me.txtloaihang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtloaihang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.WatermarkText = "Loại Hàng"
        Me.txtloaihang_F.WordWrap = False
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
        Me.txtmame_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.Location = New System.Drawing.Point(992, 4)
        Me.txtmame_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmame_F.Name = "txtmame_F"
        Me.txtmame_F.Size = New System.Drawing.Size(109, 26)
        Me.txtmame_F.TabIndex = 398
        Me.txtmame_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmame_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.WatermarkText = "Mã Mẻ"
        Me.txtmame_F.WordWrap = False
        '
        'btTim
        '
        Me.btTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTim.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btTim.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTim.Image = CType(resources.GetObject("btTim.Image"), System.Drawing.Image)
        Me.btTim.Location = New System.Drawing.Point(26, 2)
        Me.btTim.Margin = New System.Windows.Forms.Padding(2)
        Me.btTim.Name = "btTim"
        Me.btTim.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btTim.Size = New System.Drawing.Size(116, 31)
        Me.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btTim.TabIndex = 397
        '
        'txtmahang_F
        '
        Me.txtmahang_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmahang_F.Border.Class = "TextBoxBorder"
        Me.txtmahang_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmahang_F.FocusHighlightEnabled = True
        Me.txtmahang_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.Location = New System.Drawing.Point(333, 4)
        Me.txtmahang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmahang_F.Name = "txtmahang_F"
        Me.txtmahang_F.Size = New System.Drawing.Size(104, 26)
        Me.txtmahang_F.TabIndex = 405
        Me.txtmahang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmahang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.WatermarkText = "Mã Hàng"
        Me.txtmahang_F.WordWrap = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 12
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnHuyLenh, 9, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnChuyenMay, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnChon_NgayDuTinh, 8, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dtNgayxuat_chungtu, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnChonNgay_BatDau, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnLuuThayDoi, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnCaSanXuat, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.47059!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.52941!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1296, 68)
        Me.TableLayoutPanel2.TabIndex = 523
        '
        'BtnHuyLenh
        '
        Me.BtnHuyLenh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnHuyLenh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHuyLenh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnHuyLenh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHuyLenh.Image = CType(resources.GetObject("BtnHuyLenh.Image"), System.Drawing.Image)
        Me.BtnHuyLenh.Location = New System.Drawing.Point(936, 2)
        Me.BtnHuyLenh.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHuyLenh.Name = "BtnHuyLenh"
        Me.TableLayoutPanel2.SetRowSpan(Me.BtnHuyLenh, 2)
        Me.BtnHuyLenh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.BtnHuyLenh.Size = New System.Drawing.Size(137, 64)
        Me.BtnHuyLenh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.BtnHuyLenh.Symbol = ""
        Me.BtnHuyLenh.TabIndex = 537
        Me.BtnHuyLenh.Text = "HỦY LỆNH"
        '
        'BtnChuyenMay
        '
        Me.BtnChuyenMay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnChuyenMay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChuyenMay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnChuyenMay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChuyenMay.Image = CType(resources.GetObject("BtnChuyenMay.Image"), System.Drawing.Image)
        Me.BtnChuyenMay.Location = New System.Drawing.Point(343, 2)
        Me.BtnChuyenMay.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnChuyenMay.Name = "BtnChuyenMay"
        Me.TableLayoutPanel2.SetRowSpan(Me.BtnChuyenMay, 2)
        Me.BtnChuyenMay.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.BtnChuyenMay.Size = New System.Drawing.Size(193, 64)
        Me.BtnChuyenMay.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.BtnChuyenMay.Symbol = ""
        Me.BtnChuyenMay.TabIndex = 536
        Me.BtnChuyenMay.Text = "CHUYỂN MÁY"
        '
        'btnChon_NgayDuTinh
        '
        Me.btnChon_NgayDuTinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChon_NgayDuTinh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChon_NgayDuTinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChon_NgayDuTinh.Enabled = False
        Me.btnChon_NgayDuTinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChon_NgayDuTinh.Image = CType(resources.GetObject("btnChon_NgayDuTinh.Image"), System.Drawing.Image)
        Me.btnChon_NgayDuTinh.Location = New System.Drawing.Point(830, 2)
        Me.btnChon_NgayDuTinh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChon_NgayDuTinh.Name = "btnChon_NgayDuTinh"
        Me.TableLayoutPanel2.SetRowSpan(Me.btnChon_NgayDuTinh, 2)
        Me.btnChon_NgayDuTinh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btnChon_NgayDuTinh.Size = New System.Drawing.Size(102, 64)
        Me.btnChon_NgayDuTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnChon_NgayDuTinh.Symbol = ""
        Me.btnChon_NgayDuTinh.TabIndex = 534
        Me.btnChon_NgayDuTinh.Text = "Áp Ngày Dự Tính"
        '
        'btnChonNgay_BatDau
        '
        Me.btnChonNgay_BatDau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChonNgay_BatDau.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChonNgay_BatDau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChonNgay_BatDau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChonNgay_BatDau.Image = CType(resources.GetObject("btnChonNgay_BatDau.Image"), System.Drawing.Image)
        Me.btnChonNgay_BatDau.Location = New System.Drawing.Point(540, 37)
        Me.btnChonNgay_BatDau.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChonNgay_BatDau.Name = "btnChonNgay_BatDau"
        Me.btnChonNgay_BatDau.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btnChonNgay_BatDau.Size = New System.Drawing.Size(165, 29)
        Me.btnChonNgay_BatDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btnChonNgay_BatDau.Symbol = ""
        Me.btnChonNgay_BatDau.TabIndex = 535
        Me.btnChonNgay_BatDau.Text = "Chọn Ngày Bắt Đầu"
        '
        'BtnLuuThayDoi
        '
        Me.BtnLuuThayDoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnLuuThayDoi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLuuThayDoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnLuuThayDoi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLuuThayDoi.Image = CType(resources.GetObject("BtnLuuThayDoi.Image"), System.Drawing.Image)
        Me.BtnLuuThayDoi.Location = New System.Drawing.Point(2, 2)
        Me.BtnLuuThayDoi.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLuuThayDoi.Name = "BtnLuuThayDoi"
        Me.TableLayoutPanel2.SetRowSpan(Me.BtnLuuThayDoi, 2)
        Me.BtnLuuThayDoi.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.BtnLuuThayDoi.Size = New System.Drawing.Size(107, 64)
        Me.BtnLuuThayDoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.BtnLuuThayDoi.Symbol = ""
        Me.BtnLuuThayDoi.TabIndex = 535
        Me.BtnLuuThayDoi.Text = "Lưu Nội Dung"
        '
        'BtnCaSanXuat
        '
        Me.BtnCaSanXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCaSanXuat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCaSanXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCaSanXuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCaSanXuat.Image = CType(resources.GetObject("BtnCaSanXuat.Image"), System.Drawing.Image)
        Me.BtnCaSanXuat.Location = New System.Drawing.Point(127, 2)
        Me.BtnCaSanXuat.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCaSanXuat.Name = "BtnCaSanXuat"
        Me.TableLayoutPanel2.SetRowSpan(Me.BtnCaSanXuat, 2)
        Me.BtnCaSanXuat.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.BtnCaSanXuat.Size = New System.Drawing.Size(89, 64)
        Me.BtnCaSanXuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.BtnCaSanXuat.Symbol = ""
        Me.BtnCaSanXuat.TabIndex = 537
        Me.BtnCaSanXuat.Text = "CA SẢN XUẤT"
        Me.BtnCaSanXuat.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right
        '
        'Timer_NgayDuTinh
        '
        Me.Timer_NgayDuTinh.Interval = 200
        '
        'frmDatmau_Update_CongDoan_TimeLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1296, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.PnPopup_Mamau)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmNhatKySanXuat_Update_CongDoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cập Nhật Máy"
        Me.PnPopup_Mamau.ResumeLayout(False)
        CType(Me.Dgv_mamau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GP_Form_HuyCongDoan_DaSanXuat.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.GP_Form_May.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GP_Form_KeHoach.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.dtngay_casanxuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgayxuat_chungtu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnPopup_Mamau As System.Windows.Forms.Panel
    Friend WithEvents Dgv_mamau As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents CtxFunction As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Expand As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Colapse As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSave_ColumnFrozen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMnuSelect As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnu_Select_All As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnu_Remove_ALL As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents txtphanloai_kehoach As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtNgayxuat_chungtu As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btTim As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtmahang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtloaihang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmau_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmamau_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmame_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtcongdoan_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnChon_NgayDuTinh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnChonNgay_BatDau As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnLuuThayDoi As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnChuyenMay As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Timer_NgayDuTinh As Timer
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents btnCopy_Cells As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnPaste As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GP_Form_KeHoach As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dtngay_casanxuat As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Btn_Update_Form_KeHoachSX As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents BtnExit_Form_KeHoachSX As Button
    Friend WithEvents BtnCaSanXuat As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GP_Form_May As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents cboMay As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Btn_Update_Form_MayMoc As Button
    Friend WithEvents BtnExit_Form_MayMoc As Button
    Friend WithEvents txtcongdoan_chonmay As TextBox
    Friend WithEvents BtnReset_LenhSanXuat As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents txtmame_ghep_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GP_Form_HuyCongDoan_DaSanXuat As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents BtnHuy_GioRa As Button
    Friend WithEvents cboLyDo_Huy As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnThoat_GP_HuyCongDoan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcongdoan_HuyLenh As TextBox
    Friend WithEvents BtnHuy_GioVao As Button
    Friend WithEvents BtnHuyLenh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtnHuyKeHoach As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents txtnhommay_id As TextBox
    Friend WithEvents chkTatCa As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtthutu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Btn_Refresh_Form_MayMoc As Button
    Friend WithEvents txtsophieu_sx As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnXoaPhieu As DevComponents.DotNetBar.ButtonX
End Class
