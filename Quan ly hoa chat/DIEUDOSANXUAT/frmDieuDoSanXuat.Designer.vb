<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDieuDoSanXuat
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
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDieuDoSanXuat))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txttongkg_chung = New System.Windows.Forms.TextBox()
        Me.txttongcay_chung = New System.Windows.Forms.TextBox()
        Me.txtmahang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtkhachhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmetkg_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtkhovai_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtghichu_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmame_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdonhang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dt2_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtloaihang_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmamau_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dt1_F = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.btnExpand = New DevComponents.DotNetBar.ButtonItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GP_Form_ChungTuXuat = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCapNhat_XuatSX = New System.Windows.Forms.Button()
        Me.txtchungtuxuat = New System.Windows.Forms.TextBox()
        Me.cboKieuXuat = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtNgayXuat_SX = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnThoat_GP_Form_CTXuat = New System.Windows.Forms.Button()
        Me.txtghichu_xuat = New System.Windows.Forms.RichTextBox()
        Me.GP_Form_XacNhan_LoiKyThuat = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtghichu_xacnhan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboThuocNhom = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnXacNhan_LoiKyThuat = New System.Windows.Forms.Button()
        Me.BtnHidden_XacNhan_LKT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GP_Form = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.CtxFunction = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_InPhieu_SX = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_XemDonHang = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_NhatKy = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnView_KHSX_DonHang = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem4 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Export_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Expand = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Colapse = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSave_ColumnFrozen = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMnuSelect = New DevComponents.DotNetBar.ButtonItem()
        Me.mnu_Select_All = New DevComponents.DotNetBar.ButtonItem()
        Me.mnu_Remove_ALL = New DevComponents.DotNetBar.ButtonItem()
        Me.DataGridViewX_PhieuSanXuat = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer5 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer6 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer7 = New DevComponents.DotNetBar.ItemContainer()
        Me.ToolStrip_List_ThanhPham = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton_ApDonHang = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnXacNhan_DiSanXuat = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExport_Excel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRow = New System.Windows.Forms.ToolStripLabel()
        Me.BtnLuuThayDoi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_Delete_MeNhuom = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton_InPhieu = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboPhanLoai = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.txtghichumoc_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmame_ghep_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btTim = New DevComponents.DotNetBar.ButtonX()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btExcel_chung = New System.Windows.Forms.Button()
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GP_Form_ChungTuXuat.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.dtNgayXuat_SX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GP_Form_XacNhan_LoiKyThuat.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GP_Form.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewX_PhieuSanXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip_List_ThanhPham.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txttongkg_chung
        '
        Me.txttongkg_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttongkg_chung.BackColor = System.Drawing.Color.AliceBlue
        Me.txttongkg_chung.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txttongkg_chung.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txttongkg_chung.Location = New System.Drawing.Point(140, 6)
        Me.txttongkg_chung.Margin = New System.Windows.Forms.Padding(4)
        Me.txttongkg_chung.Name = "txttongkg_chung"
        Me.txttongkg_chung.ReadOnly = True
        Me.txttongkg_chung.Size = New System.Drawing.Size(122, 29)
        Me.txttongkg_chung.TabIndex = 203
        Me.txttongkg_chung.Text = "0"
        Me.txttongkg_chung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttongcay_chung
        '
        Me.txttongcay_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttongcay_chung.BackColor = System.Drawing.Color.AliceBlue
        Me.txttongcay_chung.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txttongcay_chung.ForeColor = System.Drawing.Color.SeaGreen
        Me.txttongcay_chung.Location = New System.Drawing.Point(9, 6)
        Me.txttongcay_chung.Margin = New System.Windows.Forms.Padding(4)
        Me.txttongcay_chung.Name = "txttongcay_chung"
        Me.txttongcay_chung.ReadOnly = True
        Me.txttongcay_chung.Size = New System.Drawing.Size(122, 29)
        Me.txttongcay_chung.TabIndex = 202
        Me.txttongcay_chung.Text = "0"
        Me.txttongcay_chung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtmahang_F.Location = New System.Drawing.Point(464, 2)
        Me.txtmahang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmahang_F.Name = "txtmahang_F"
        Me.txtmahang_F.Size = New System.Drawing.Size(91, 25)
        Me.txtmahang_F.TabIndex = 405
        Me.txtmahang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmahang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang_F.WatermarkText = "Mã Hàng"
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
        Me.txtkhachhang_F.Location = New System.Drawing.Point(364, 30)
        Me.txtkhachhang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkhachhang_F.Name = "txtkhachhang_F"
        Me.txtkhachhang_F.Size = New System.Drawing.Size(96, 25)
        Me.txtkhachhang_F.TabIndex = 404
        Me.txtkhachhang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtkhachhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang_F.WatermarkText = "Khách Hàng"
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
        Me.txtmetkg_F.Location = New System.Drawing.Point(738, 30)
        Me.txtmetkg_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmetkg_F.Name = "txtmetkg_F"
        Me.txtmetkg_F.Size = New System.Drawing.Size(81, 25)
        Me.txtmetkg_F.TabIndex = 403
        Me.txtmetkg_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmetkg_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmetkg_F.WatermarkText = "Métkg"
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
        Me.txtkhovai_F.Location = New System.Drawing.Point(738, 2)
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
        Me.txtghichu_F.Location = New System.Drawing.Point(823, 2)
        Me.txtghichu_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtghichu_F.Name = "txtghichu_F"
        Me.txtghichu_F.Size = New System.Drawing.Size(199, 25)
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
        Me.txtmame_F.Location = New System.Drawing.Point(659, 2)
        Me.txtmame_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmame_F.Name = "txtmame_F"
        Me.txtmame_F.Size = New System.Drawing.Size(75, 25)
        Me.txtmame_F.TabIndex = 398
        Me.txtmame_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmame_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_F.WatermarkText = "Mã Mẻ"
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
        Me.txtmau_F.Location = New System.Drawing.Point(559, 2)
        Me.txtmau_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmau_F.Name = "txtmau_F"
        Me.txtmau_F.Size = New System.Drawing.Size(96, 26)
        Me.txtmau_F.TabIndex = 394
        Me.txtmau_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmau_F.WatermarkText = "Màu"
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
        Me.txtdonhang_F.Location = New System.Drawing.Point(364, 2)
        Me.txtdonhang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdonhang_F.Name = "txtdonhang_F"
        Me.txtdonhang_F.Size = New System.Drawing.Size(96, 25)
        Me.txtdonhang_F.TabIndex = 390
        Me.txtdonhang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtdonhang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang_F.WatermarkText = "Đơn Hàng"
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
        Me.dt2_F.Location = New System.Drawing.Point(2, 30)
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
        Me.dt2_F.Size = New System.Drawing.Size(116, 25)
        Me.dt2_F.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dt2_F.TabIndex = 396
        Me.dt2_F.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dt2_F.WatermarkText = "Đến ngày"
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
        Me.txtloaihang_F.Location = New System.Drawing.Point(464, 30)
        Me.txtloaihang_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtloaihang_F.Name = "txtloaihang_F"
        Me.txtloaihang_F.Size = New System.Drawing.Size(91, 25)
        Me.txtloaihang_F.TabIndex = 392
        Me.txtloaihang_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtloaihang_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang_F.WatermarkText = "Loại Hàng"
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
        Me.txtmamau_F.Location = New System.Drawing.Point(559, 30)
        Me.txtmamau_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmamau_F.Name = "txtmamau_F"
        Me.txtmamau_F.Size = New System.Drawing.Size(96, 25)
        Me.txtmamau_F.TabIndex = 393
        Me.txtmamau_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmamau_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamau_F.WatermarkText = "Mã Màu"
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
        Me.Super_Dgv.Location = New System.Drawing.Point(192, 49)
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
        Me.Super_Dgv.PrimaryGrid.GroupByRow.Visible = True
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
        Me.Super_Dgv.Size = New System.Drawing.Size(202, 103)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 414
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        '
        'btnExpand
        '
        Me.btnExpand.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExpand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnExpand.HotFontUnderline = True
        Me.btnExpand.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExpand.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Text = "Mở rộng cột"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GP_Form_ChungTuXuat)
        Me.Panel1.Controls.Add(Me.GP_Form_XacNhan_LoiKyThuat)
        Me.Panel1.Controls.Add(Me.GP_Form)
        Me.Panel1.Controls.Add(Me.CircularProgress1)
        Me.Panel1.Controls.Add(Me.ContextMenuBar1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Controls.Add(Me.DataGridViewX_PhieuSanXuat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1348, 637)
        Me.Panel1.TabIndex = 425
        '
        'GP_Form_ChungTuXuat
        '
        Me.GP_Form_ChungTuXuat.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form_ChungTuXuat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form_ChungTuXuat.Controls.Add(Me.TableLayoutPanel5)
        Me.GP_Form_ChungTuXuat.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form_ChungTuXuat.Location = New System.Drawing.Point(16, 168)
        Me.GP_Form_ChungTuXuat.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form_ChungTuXuat.Name = "GP_Form_ChungTuXuat"
        Me.GP_Form_ChungTuXuat.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form_ChungTuXuat.Size = New System.Drawing.Size(514, 212)
        '
        '
        '
        Me.GP_Form_ChungTuXuat.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form_ChungTuXuat.Style.BackColorGradientAngle = 90
        Me.GP_Form_ChungTuXuat.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form_ChungTuXuat.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_ChungTuXuat.Style.BorderBottomWidth = 1
        Me.GP_Form_ChungTuXuat.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form_ChungTuXuat.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_ChungTuXuat.Style.BorderLeftWidth = 1
        Me.GP_Form_ChungTuXuat.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_ChungTuXuat.Style.BorderRightWidth = 1
        Me.GP_Form_ChungTuXuat.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_ChungTuXuat.Style.BorderTopWidth = 1
        Me.GP_Form_ChungTuXuat.Style.CornerDiameter = 4
        Me.GP_Form_ChungTuXuat.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form_ChungTuXuat.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form_ChungTuXuat.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form_ChungTuXuat.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form_ChungTuXuat.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form_ChungTuXuat.TabIndex = 456
        Me.GP_Form_ChungTuXuat.Text = "Cập Nhật Xuất Sản Xuất"
        Me.GP_Form_ChungTuXuat.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form_ChungTuXuat.Visible = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.BtnCapNhat_XuatSX, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.txtchungtuxuat, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cboKieuXuat, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.dtNgayXuat_SX, 3, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label12, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btnThoat_GP_Form_CTXuat, 3, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.txtghichu_xuat, 0, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(484, 186)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'BtnCapNhat_XuatSX
        '
        Me.BtnCapNhat_XuatSX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCapNhat_XuatSX.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCapNhat_XuatSX.Image = CType(resources.GetObject("BtnCapNhat_XuatSX.Image"), System.Drawing.Image)
        Me.BtnCapNhat_XuatSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCapNhat_XuatSX.Location = New System.Drawing.Point(106, 132)
        Me.BtnCapNhat_XuatSX.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCapNhat_XuatSX.Name = "BtnCapNhat_XuatSX"
        Me.BtnCapNhat_XuatSX.Size = New System.Drawing.Size(137, 47)
        Me.BtnCapNhat_XuatSX.TabIndex = 453
        Me.BtnCapNhat_XuatSX.Text = "Cập Nhật"
        Me.BtnCapNhat_XuatSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCapNhat_XuatSX.UseVisualStyleBackColor = True
        '
        'txtchungtuxuat
        '
        Me.txtchungtuxuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtchungtuxuat.BackColor = System.Drawing.Color.White
        Me.txtchungtuxuat.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtchungtuxuat.Location = New System.Drawing.Point(107, 40)
        Me.txtchungtuxuat.Margin = New System.Windows.Forms.Padding(5)
        Me.txtchungtuxuat.Name = "txtchungtuxuat"
        Me.txtchungtuxuat.Size = New System.Drawing.Size(135, 28)
        Me.txtchungtuxuat.TabIndex = 488
        '
        'cboKieuXuat
        '
        Me.cboKieuXuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.SetColumnSpan(Me.cboKieuXuat, 3)
        Me.cboKieuXuat.DisplayMember = "Text"
        Me.cboKieuXuat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboKieuXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKieuXuat.FocusHighlightEnabled = True
        Me.cboKieuXuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKieuXuat.FormattingEnabled = True
        Me.cboKieuXuat.ItemHeight = 20
        Me.cboKieuXuat.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10})
        Me.cboKieuXuat.Location = New System.Drawing.Point(104, 4)
        Me.cboKieuXuat.Margin = New System.Windows.Forms.Padding(2)
        Me.cboKieuXuat.Name = "cboKieuXuat"
        Me.cboKieuXuat.Size = New System.Drawing.Size(378, 26)
        Me.cboKieuXuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboKieuXuat.TabIndex = 491
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Vải"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Bo"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(21, 8)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 18)
        Me.Label14.TabIndex = 489
        Me.Label14.Text = "Mục Đích"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(19, 43)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 18)
        Me.Label13.TabIndex = 490
        Me.Label13.Text = "Chứng Từ"
        '
        'dtNgayXuat_SX
        '
        Me.dtNgayXuat_SX.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtNgayXuat_SX.AutoSelectDate = True
        '
        '
        '
        Me.dtNgayXuat_SX.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtNgayXuat_SX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXuat_SX.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtNgayXuat_SX.ButtonDropDown.Visible = True
        Me.dtNgayXuat_SX.CustomFormat = "dd/MM/yy"
        Me.dtNgayXuat_SX.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.DateSelector
        Me.dtNgayXuat_SX.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtNgayXuat_SX.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtNgayXuat_SX.IsPopupCalendarOpen = False
        Me.dtNgayXuat_SX.Location = New System.Drawing.Point(355, 38)
        Me.dtNgayXuat_SX.Margin = New System.Windows.Forms.Padding(2)
        '
        '
        '
        '
        '
        '
        Me.dtNgayXuat_SX.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXuat_SX.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtNgayXuat_SX.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtNgayXuat_SX.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXuat_SX.MonthCalendar.DisplayMonth = New Date(2014, 11, 1, 0, 0, 0, 0)
        Me.dtNgayXuat_SX.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtNgayXuat_SX.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtNgayXuat_SX.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtNgayXuat_SX.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtNgayXuat_SX.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtNgayXuat_SX.MonthCalendar.TodayButtonVisible = True
        Me.dtNgayXuat_SX.Name = "dtNgayXuat_SX"
        Me.dtNgayXuat_SX.ShowUpDown = True
        Me.dtNgayXuat_SX.Size = New System.Drawing.Size(127, 28)
        Me.dtNgayXuat_SX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtNgayXuat_SX.TabIndex = 492
        Me.dtNgayXuat_SX.Value = New Date(2014, 11, 12, 22, 2, 10, 0)
        Me.dtNgayXuat_SX.WatermarkText = "Từ ngày"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(263, 43)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 18)
        Me.Label12.TabIndex = 493
        Me.Label12.Text = "Ngày Xuất"
        '
        'btnThoat_GP_Form_CTXuat
        '
        Me.btnThoat_GP_Form_CTXuat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat_GP_Form_CTXuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat_GP_Form_CTXuat.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.btnThoat_GP_Form_CTXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThoat_GP_Form_CTXuat.Location = New System.Drawing.Point(358, 134)
        Me.btnThoat_GP_Form_CTXuat.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThoat_GP_Form_CTXuat.Name = "btnThoat_GP_Form_CTXuat"
        Me.btnThoat_GP_Form_CTXuat.Size = New System.Drawing.Size(121, 43)
        Me.btnThoat_GP_Form_CTXuat.TabIndex = 454
        Me.btnThoat_GP_Form_CTXuat.Text = "Thoát"
        Me.btnThoat_GP_Form_CTXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThoat_GP_Form_CTXuat.UseVisualStyleBackColor = True
        '
        'txtghichu_xuat
        '
        Me.txtghichu_xuat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtghichu_xuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel5.SetColumnSpan(Me.txtghichu_xuat, 4)
        Me.txtghichu_xuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu_xuat.Location = New System.Drawing.Point(3, 73)
        Me.txtghichu_xuat.Name = "txtghichu_xuat"
        Me.txtghichu_xuat.Size = New System.Drawing.Size(478, 53)
        Me.txtghichu_xuat.TabIndex = 494
        Me.txtghichu_xuat.Text = ""
        '
        'GP_Form_XacNhan_LoiKyThuat
        '
        Me.GP_Form_XacNhan_LoiKyThuat.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form_XacNhan_LoiKyThuat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form_XacNhan_LoiKyThuat.Controls.Add(Me.TableLayoutPanel2)
        Me.GP_Form_XacNhan_LoiKyThuat.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form_XacNhan_LoiKyThuat.Location = New System.Drawing.Point(13, 412)
        Me.GP_Form_XacNhan_LoiKyThuat.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form_XacNhan_LoiKyThuat.Name = "GP_Form_XacNhan_LoiKyThuat"
        Me.GP_Form_XacNhan_LoiKyThuat.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form_XacNhan_LoiKyThuat.Size = New System.Drawing.Size(461, 157)
        '
        '
        '
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BackColorGradientAngle = 90
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BorderBottomWidth = 1
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BorderLeftWidth = 1
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BorderRightWidth = 1
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_XacNhan_LoiKyThuat.Style.BorderTopWidth = 1
        Me.GP_Form_XacNhan_LoiKyThuat.Style.CornerDiameter = 4
        Me.GP_Form_XacNhan_LoiKyThuat.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form_XacNhan_LoiKyThuat.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form_XacNhan_LoiKyThuat.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form_XacNhan_LoiKyThuat.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form_XacNhan_LoiKyThuat.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form_XacNhan_LoiKyThuat.TabIndex = 455
        Me.GP_Form_XacNhan_LoiKyThuat.Text = "Xác Nhận Lỗi"
        Me.GP_Form_XacNhan_LoiKyThuat.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form_XacNhan_LoiKyThuat.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtghichu_xacnhan, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cboThuocNhom, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnXacNhan_LoiKyThuat, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnHidden_XacNhan_LKT, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(431, 131)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txtghichu_xacnhan
        '
        Me.txtghichu_xacnhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtghichu_xacnhan.Border.Class = "TextBoxBorder"
        Me.txtghichu_xacnhan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtghichu_xacnhan, 2)
        Me.txtghichu_xacnhan.FocusHighlightEnabled = True
        Me.txtghichu_xacnhan.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu_xacnhan.Location = New System.Drawing.Point(104, 40)
        Me.txtghichu_xacnhan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtghichu_xacnhan.Name = "txtghichu_xacnhan"
        Me.txtghichu_xacnhan.Size = New System.Drawing.Size(325, 25)
        Me.txtghichu_xacnhan.TabIndex = 456
        Me.txtghichu_xacnhan.WatermarkColor = System.Drawing.Color.Blue
        Me.txtghichu_xacnhan.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboThuocNhom
        '
        Me.cboThuocNhom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.cboThuocNhom, 2)
        Me.cboThuocNhom.DisplayMember = "Text"
        Me.cboThuocNhom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboThuocNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboThuocNhom.FocusHighlightEnabled = True
        Me.cboThuocNhom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboThuocNhom.FormattingEnabled = True
        Me.cboThuocNhom.ItemHeight = 20
        Me.cboThuocNhom.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem8})
        Me.cboThuocNhom.Location = New System.Drawing.Point(104, 4)
        Me.cboThuocNhom.Margin = New System.Windows.Forms.Padding(2)
        Me.cboThuocNhom.Name = "cboThuocNhom"
        Me.cboThuocNhom.Size = New System.Drawing.Size(325, 26)
        Me.cboThuocNhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboThuocNhom.TabIndex = 491
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Vải"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Bo"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(46, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 489
        Me.Label3.Text = "Nhóm"
        '
        'BtnXacNhan_LoiKyThuat
        '
        Me.BtnXacNhan_LoiKyThuat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnXacNhan_LoiKyThuat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnXacNhan_LoiKyThuat.Image = CType(resources.GetObject("BtnXacNhan_LoiKyThuat.Image"), System.Drawing.Image)
        Me.BtnXacNhan_LoiKyThuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnXacNhan_LoiKyThuat.Location = New System.Drawing.Point(106, 73)
        Me.BtnXacNhan_LoiKyThuat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnXacNhan_LoiKyThuat.Name = "BtnXacNhan_LoiKyThuat"
        Me.BtnXacNhan_LoiKyThuat.Size = New System.Drawing.Size(137, 41)
        Me.BtnXacNhan_LoiKyThuat.TabIndex = 453
        Me.BtnXacNhan_LoiKyThuat.Text = "Cập Nhật"
        Me.BtnXacNhan_LoiKyThuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnXacNhan_LoiKyThuat.UseVisualStyleBackColor = True
        '
        'BtnHidden_XacNhan_LKT
        '
        Me.BtnHidden_XacNhan_LKT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHidden_XacNhan_LKT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHidden_XacNhan_LKT.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnHidden_XacNhan_LKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHidden_XacNhan_LKT.Location = New System.Drawing.Point(252, 75)
        Me.BtnHidden_XacNhan_LKT.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnHidden_XacNhan_LKT.Name = "BtnHidden_XacNhan_LKT"
        Me.BtnHidden_XacNhan_LKT.Size = New System.Drawing.Size(174, 37)
        Me.BtnHidden_XacNhan_LKT.TabIndex = 454
        Me.BtnHidden_XacNhan_LKT.Text = "Thoát"
        Me.BtnHidden_XacNhan_LKT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHidden_XacNhan_LKT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(32, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 492
        Me.Label2.Text = "Ghi Chú"
        '
        'GP_Form
        '
        Me.GP_Form.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form.Controls.Add(Me.Panel2)
        Me.GP_Form.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form.Location = New System.Drawing.Point(10, 49)
        Me.GP_Form.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form.Name = "GP_Form"
        Me.GP_Form.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form.Size = New System.Drawing.Size(149, 92)
        '
        '
        '
        Me.GP_Form.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form.Style.BackColorGradientAngle = 90
        Me.GP_Form.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form.Style.BorderBottomWidth = 1
        Me.GP_Form.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form.Style.BorderLeftWidth = 1
        Me.GP_Form.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form.Style.BorderRightWidth = 1
        Me.GP_Form.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form.Style.BorderTopWidth = 1
        Me.GP_Form.Style.CornerDiameter = 4
        Me.GP_Form.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form.TabIndex = 446
        Me.GP_Form.Text = "GroupPanel1"
        Me.GP_Form.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(119, 66)
        Me.Panel2.TabIndex = 0
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
        Me.CircularProgress1.Location = New System.Drawing.Point(1221, 26)
        Me.CircularProgress1.Margin = New System.Windows.Forms.Padding(2)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(115, 91)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 434
        Me.CircularProgress1.Visible = False
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu, Me.CtxMnuSelect})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(463, 39)
        Me.ContextMenuBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(234, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 433
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'CtxFunction
        '
        Me.CtxFunction.AutoExpandOnClick = True
        Me.CtxFunction.Name = "CtxFunction"
        Me.CtxFunction.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem_InPhieu_SX, Me.CtxFunction_XemDonHang, Me.CtxFunction_NhatKy, Me.CtxFunction_Refresh, Me.BtnView_KHSX_DonHang, Me.LabelItem4, Me.CtxFunction_Export_Excel})
        Me.CtxFunction.Text = "Function"
        '
        'ButtonItem_InPhieu_SX
        '
        Me.ButtonItem_InPhieu_SX.Name = "ButtonItem_InPhieu_SX"
        Me.ButtonItem_InPhieu_SX.Text = "In Phiếu SX"
        '
        'CtxFunction_XemDonHang
        '
        Me.CtxFunction_XemDonHang.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.CtxFunction_XemDonHang.Name = "CtxFunction_XemDonHang"
        Me.CtxFunction_XemDonHang.Text = "Xem Đơn Hàng"
        '
        'CtxFunction_NhatKy
        '
        Me.CtxFunction_NhatKy.Image = Global.WindowsApplication1.My.Resources.Resources.note_edit
        Me.CtxFunction_NhatKy.Name = "CtxFunction_NhatKy"
        Me.CtxFunction_NhatKy.Text = "Xem Nhật Ký Sản Xuất"
        '
        'CtxFunction_Refresh
        '
        Me.CtxFunction_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.CtxFunction_Refresh.Name = "CtxFunction_Refresh"
        Me.CtxFunction_Refresh.Text = "Làm Mới"
        '
        'BtnView_KHSX_DonHang
        '
        Me.BtnView_KHSX_DonHang.Name = "BtnView_KHSX_DonHang"
        Me.BtnView_KHSX_DonHang.Text = "KHSX Đơn Hàng"
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
        'DataGridViewX_PhieuSanXuat
        '
        Me.DataGridViewX_PhieuSanXuat.AllowUserToAddRows = False
        Me.DataGridViewX_PhieuSanXuat.AllowUserToDeleteRows = False
        Me.DataGridViewX_PhieuSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX_PhieuSanXuat.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX_PhieuSanXuat.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX_PhieuSanXuat.Location = New System.Drawing.Point(794, 273)
        Me.DataGridViewX_PhieuSanXuat.Name = "DataGridViewX_PhieuSanXuat"
        Me.DataGridViewX_PhieuSanXuat.Size = New System.Drawing.Size(295, 166)
        Me.DataGridViewX_PhieuSanXuat.TabIndex = 457
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.Name = "ItemContainer1"
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.Name = "ItemContainer2"
        '
        '
        '
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.Name = "ItemContainer3"
        '
        '
        '
        Me.ItemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer4.Name = "ItemContainer4"
        '
        '
        '
        Me.ItemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer5
        '
        '
        '
        '
        Me.ItemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer5.Name = "ItemContainer5"
        '
        '
        '
        Me.ItemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer6
        '
        '
        '
        '
        Me.ItemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer6.Name = "ItemContainer6"
        '
        '
        '
        Me.ItemContainer6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer7
        '
        '
        '
        '
        Me.ItemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer7.Name = "ItemContainer7"
        '
        '
        '
        Me.ItemContainer7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ToolStrip_List_ThanhPham
        '
        Me.ToolStrip_List_ThanhPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip_List_ThanhPham.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip_List_ThanhPham.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_List_ThanhPham.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip_List_ThanhPham.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_ApDonHang, Me.ToolStripSeparator10, Me.btnXacNhan_DiSanXuat, Me.ToolStripSeparator6, Me.btnExport_Excel, Me.ToolStripSeparator8, Me.lblRow, Me.BtnLuuThayDoi, Me.ToolStripSeparator5, Me.ToolStripButton_Delete_MeNhuom, Me.ToolStripSeparator1, Me.ToolStripButton_InPhieu})
        Me.ToolStrip_List_ThanhPham.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_List_ThanhPham.Name = "ToolStrip_List_ThanhPham"
        Me.ToolStrip_List_ThanhPham.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip_List_ThanhPham.Size = New System.Drawing.Size(1348, 31)
        Me.ToolStrip_List_ThanhPham.Stretch = True
        Me.ToolStrip_List_ThanhPham.TabIndex = 449
        Me.ToolStrip_List_ThanhPham.Text = "ToolStrip1"
        '
        'ToolStripButton_ApDonHang
        '
        Me.ToolStripButton_ApDonHang.Image = Global.WindowsApplication1.My.Resources.Resources.accept_24
        Me.ToolStripButton_ApDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton_ApDonHang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_ApDonHang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_ApDonHang.Name = "ToolStripButton_ApDonHang"
        Me.ToolStripButton_ApDonHang.Size = New System.Drawing.Size(172, 28)
        Me.ToolStripButton_ApDonHang.Text = "Kế Hoạch (Đ.Hàng)"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 31)
        '
        'btnXacNhan_DiSanXuat
        '
        Me.btnXacNhan_DiSanXuat.Image = Global.WindowsApplication1.My.Resources.Resources._next
        Me.btnXacNhan_DiSanXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXacNhan_DiSanXuat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnXacNhan_DiSanXuat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnXacNhan_DiSanXuat.Name = "btnXacNhan_DiSanXuat"
        Me.btnXacNhan_DiSanXuat.Size = New System.Drawing.Size(150, 28)
        Me.btnXacNhan_DiSanXuat.Text = "Xác Nhận Đi SX"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'btnExport_Excel
        '
        Me.btnExport_Excel.Image = Global.WindowsApplication1.My.Resources.Resources.microsoft_excel_24
        Me.btnExport_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport_Excel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExport_Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport_Excel.Name = "btnExport_Excel"
        Me.btnExport_Excel.Size = New System.Drawing.Size(110, 28)
        Me.btnExport_Excel.Text = "Xuất Excel"
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton_Delete_MeNhuom
        '
        Me.ToolStripButton_Delete_MeNhuom.Image = Global.WindowsApplication1.My.Resources.Resources.delete_24
        Me.ToolStripButton_Delete_MeNhuom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton_Delete_MeNhuom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_Delete_MeNhuom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_Delete_MeNhuom.Name = "ToolStripButton_Delete_MeNhuom"
        Me.ToolStripButton_Delete_MeNhuom.Size = New System.Drawing.Size(144, 28)
        Me.ToolStripButton_Delete_MeNhuom.Text = "Xóa Mẻ Nhuộm"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton_InPhieu
        '
        Me.ToolStripButton_InPhieu.Image = Global.WindowsApplication1.My.Resources.Resources.printer
        Me.ToolStripButton_InPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton_InPhieu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton_InPhieu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton_InPhieu.Name = "ToolStripButton_InPhieu"
        Me.ToolStripButton_InPhieu.Size = New System.Drawing.Size(91, 28)
        Me.ToolStripButton_InPhieu.Text = "In Phiếu"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 11
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cboPhanLoai, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichumoc_F, 8, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame_ghep_F, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dt1_F, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dt2_F, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmetkg_F, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btTim, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhovai_F, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmame_F, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmamau_F, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmau_F, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtloaihang_F, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichu_F, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmahang_F, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang_F, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdonhang_F, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 668)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1348, 65)
        Me.TableLayoutPanel1.TabIndex = 455
        '
        'cboPhanLoai
        '
        Me.cboPhanLoai.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPhanLoai.DisplayMember = "Text"
        Me.cboPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhanLoai.FocusHighlightEnabled = True
        Me.cboPhanLoai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPhanLoai.FormattingEnabled = True
        Me.cboPhanLoai.ItemHeight = 20
        Me.cboPhanLoai.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cboPhanLoai.Location = New System.Drawing.Point(164, 2)
        Me.cboPhanLoai.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPhanLoai.Name = "cboPhanLoai"
        Me.cboPhanLoai.Size = New System.Drawing.Size(196, 26)
        Me.cboPhanLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboPhanLoai.TabIndex = 492
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Tất Cả"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Mẻ Chưa Xuất SX"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Mẻ Chưa Áp Màu"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Mẻ Chưa Có Mộc"
        '
        'txtghichumoc_F
        '
        Me.txtghichumoc_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtghichumoc_F.Border.Class = "TextBoxBorder"
        Me.txtghichumoc_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtghichumoc_F.FocusHighlightEnabled = True
        Me.txtghichumoc_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichumoc_F.Location = New System.Drawing.Point(823, 30)
        Me.txtghichumoc_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtghichumoc_F.Name = "txtghichumoc_F"
        Me.txtghichumoc_F.Size = New System.Drawing.Size(199, 25)
        Me.txtghichumoc_F.TabIndex = 457
        Me.txtghichumoc_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtghichumoc_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichumoc_F.WatermarkText = "Ghi chú Mộc"
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
        Me.txtmame_ghep_F.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_ghep_F.Location = New System.Drawing.Point(659, 30)
        Me.txtmame_ghep_F.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmame_ghep_F.Name = "txtmame_ghep_F"
        Me.txtmame_ghep_F.Size = New System.Drawing.Size(75, 25)
        Me.txtmame_ghep_F.TabIndex = 457
        Me.txtmame_ghep_F.WatermarkColor = System.Drawing.Color.Blue
        Me.txtmame_ghep_F.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame_ghep_F.WatermarkText = "Mẻ Ghép"
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
        Me.btTim.Location = New System.Drawing.Point(122, 2)
        Me.btTim.Margin = New System.Windows.Forms.Padding(2)
        Me.btTim.Name = "btTim"
        Me.TableLayoutPanel1.SetRowSpan(Me.btTim, 2)
        Me.btTim.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
        Me.btTim.Size = New System.Drawing.Size(38, 52)
        Me.btTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.btTim.TabIndex = 397
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Size = New System.Drawing.Size(345, 146)
        Me.ShapeContainer4.TabIndex = 0
        Me.ShapeContainer4.TabStop = False
        '
        'btExcel_chung
        '
        Me.btExcel_chung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btExcel_chung.Image = CType(resources.GetObject("btExcel_chung.Image"), System.Drawing.Image)
        Me.btExcel_chung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btExcel_chung.Location = New System.Drawing.Point(850, 6)
        Me.btExcel_chung.Margin = New System.Windows.Forms.Padding(4)
        Me.btExcel_chung.Name = "btExcel_chung"
        Me.btExcel_chung.Size = New System.Drawing.Size(138, 35)
        Me.btExcel_chung.TabIndex = 31
        Me.btExcel_chung.Text = "Xuất Excel"
        Me.btExcel_chung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btExcel_chung.UseVisualStyleBackColor = True
        '
        'frmDieuDoSanXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip_List_ThanhPham)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmDieuDoSanXuat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Điều Độ Sản Xuất"
        CType(Me.dt2_F, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt1_F, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GP_Form_ChungTuXuat.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.dtNgayXuat_SX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GP_Form_XacNhan_LoiKyThuat.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GP_Form.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewX_PhieuSanXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip_List_ThanhPham.ResumeLayout(False)
        Me.ToolStrip_List_ThanhPham.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttongkg_chung As System.Windows.Forms.TextBox
    Friend WithEvents txttongcay_chung As System.Windows.Forms.TextBox
    Friend WithEvents btExcel_chung As System.Windows.Forms.Button
    Friend WithEvents btTim As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtmau_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdonhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dt2_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtloaihang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmamau_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dt1_F As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtmame_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtghichu_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmetkg_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtkhovai_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtkhachhang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmahang_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExpand As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents CtxFunction As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_XemDonHang As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_NhatKy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem4 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Export_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Expand As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Colapse As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents btnSave_ColumnFrozen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer5 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer6 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer7 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents CtxMnuSelect As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnu_Select_All As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnu_Remove_ALL As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ToolStrip_List_ThanhPham As System.Windows.Forms.ToolStrip
    Friend WithEvents btnExport_Excel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblRow As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GP_Form As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnLuuThayDoi As ToolStripButton
    Private WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents GP_Form_XacNhan_LoiKyThuat As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cboThuocNhom As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnXacNhan_LoiKyThuat As Button
    Friend WithEvents BtnHidden_XacNhan_LKT As Button
    Friend WithEvents txtghichu_xacnhan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton_ApDonHang As ToolStripButton
    Friend WithEvents GP_Form_ChungTuXuat As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents dtNgayXuat_SX As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label12 As Label
    Friend WithEvents btnThoat_GP_Form_CTXuat As Button
    Friend WithEvents BtnCapNhat_XuatSX As Button
    Friend WithEvents txtchungtuxuat As TextBox
    Friend WithEvents cboKieuXuat As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents txtghichu_xuat As RichTextBox
    Friend WithEvents txtghichumoc_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmame_ghep_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnView_KHSX_DonHang As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnXacNhan_DiSanXuat As ToolStripButton
    Friend WithEvents ToolStripButton_Delete_MeNhuom As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton_InPhieu As ToolStripButton
    Friend WithEvents cboPhanLoai As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridViewX_PhieuSanXuat As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonItem_InPhieu_SX As DevComponents.DotNetBar.ButtonItem
End Class
