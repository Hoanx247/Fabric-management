<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDonHang_kinhDoanh_input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDonHang_kinhDoanh_input))
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtOrder_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtdonhang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtngaynhap = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtngaygiao = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblkhachhang = New System.Windows.Forms.Label()
        Me.lbltaixe = New System.Windows.Forms.Label()
        Me.txtmakhach = New System.Windows.Forms.TextBox()
        Me.txtkhachhang = New System.Windows.Forms.TextBox()
        Me.cboNhomHoaDon = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.RichTextBoxEx_ghichu = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ToolStrip_List_Khachhang = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnModify = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExport_Excel = New System.Windows.Forms.ToolStripButton()
        Me.lblRow = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PnPopup_List = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.CtxFunction = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Add = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Modify = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_delete = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxFunction_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem4 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Copy = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem5 = New DevComponents.DotNetBar.LabelItem()
        Me.CtxFunction_Export_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem6 = New DevComponents.DotNetBar.LabelItem()
        Me.btnDefault = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Expand = New DevComponents.DotNetBar.ButtonItem()
        Me.CtxMenu_Colapse = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSave_ColumnFrozen = New DevComponents.DotNetBar.ButtonItem()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip_List_Khachhang.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnSave, 2)
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(119, 350)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 46)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Lưu"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(276, 351)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(92, 44)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Text = "Thoát"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.Location = New System.Drawing.Point(960, 103)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(44, 28)
        Me.txtid.TabIndex = 374
        '
        'txtOrder_ID
        '
        Me.txtOrder_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrder_ID.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrder_ID.ForeColor = System.Drawing.Color.Black
        Me.txtOrder_ID.Location = New System.Drawing.Point(1023, 139)
        Me.txtOrder_ID.Name = "txtOrder_ID"
        Me.txtOrder_ID.Size = New System.Drawing.Size(24, 29)
        Me.txtOrder_ID.TabIndex = 377
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(925, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 378
        Me.Label3.Text = "Order ID:"
        '
        'LabelX8
        '
        Me.LabelX8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(16, 38)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(99, 20)
        Me.LabelX8.TabIndex = 445
        Me.LabelX8.Text = "Mã Đơn Hàng:"
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
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtdonhang, 4)
        Me.txtdonhang.FocusHighlightEnabled = True
        Me.txtdonhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdonhang.Location = New System.Drawing.Point(119, 35)
        Me.txtdonhang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdonhang.Name = "txtdonhang"
        Me.txtdonhang.Size = New System.Drawing.Size(373, 26)
        Me.txtdonhang.TabIndex = 2
        Me.txtdonhang.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 451
        Me.Label4.Text = "Ngày Đặt:"
        '
        'dtngaynhap
        '
        Me.dtngaynhap.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtngaynhap.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.SetColumnSpan(Me.dtngaynhap, 2)
        Me.dtngaynhap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtngaynhap.Location = New System.Drawing.Point(120, 3)
        Me.dtngaynhap.Name = "dtngaynhap"
        Me.dtngaynhap.Size = New System.Drawing.Size(150, 26)
        Me.dtngaynhap.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 453
        Me.Label1.Text = "Ngày Giao:"
        '
        'dtngaygiao
        '
        Me.dtngaygiao.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtngaygiao.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.SetColumnSpan(Me.dtngaygiao, 2)
        Me.dtngaygiao.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtngaygiao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtngaygiao.Location = New System.Drawing.Point(120, 163)
        Me.dtngaygiao.Name = "dtngaygiao"
        Me.dtngaygiao.Size = New System.Drawing.Size(150, 26)
        Me.dtngaygiao.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdonhang, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdExit, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblkhachhang, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbltaixe, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmakhach, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.dtngaygiao, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.dtngaynhap, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboNhomHoaDon, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBoxEx_ghichu, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(543, 462)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 511
        Me.Label2.Text = "Chọn Nhóm:"
        '
        'lblkhachhang
        '
        Me.lblkhachhang.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblkhachhang.AutoSize = True
        Me.lblkhachhang.BackColor = System.Drawing.Color.Transparent
        Me.lblkhachhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkhachhang.Location = New System.Drawing.Point(26, 102)
        Me.lblkhachhang.Name = "lblkhachhang"
        Me.lblkhachhang.Size = New System.Drawing.Size(88, 19)
        Me.lblkhachhang.TabIndex = 510
        Me.lblkhachhang.Text = "Khách Hàng:"
        '
        'lbltaixe
        '
        Me.lbltaixe.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbltaixe.AutoSize = True
        Me.lbltaixe.BackColor = System.Drawing.Color.Transparent
        Me.lbltaixe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltaixe.Location = New System.Drawing.Point(37, 70)
        Me.lbltaixe.Name = "lbltaixe"
        Me.lbltaixe.Size = New System.Drawing.Size(77, 19)
        Me.lbltaixe.TabIndex = 501
        Me.lbltaixe.Text = "Mã Khách:"
        '
        'txtmakhach
        '
        Me.txtmakhach.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmakhach.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmakhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmakhach, 4)
        Me.txtmakhach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhach.Location = New System.Drawing.Point(120, 68)
        Me.txtmakhach.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmakhach.Name = "txtmakhach"
        Me.txtmakhach.Size = New System.Drawing.Size(371, 26)
        Me.txtmakhach.TabIndex = 4
        '
        'txtkhachhang
        '
        Me.txtkhachhang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkhachhang.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtkhachhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkhachhang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtkhachhang, 4)
        Me.txtkhachhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang.ForeColor = System.Drawing.Color.Red
        Me.txtkhachhang.Location = New System.Drawing.Point(120, 100)
        Me.txtkhachhang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtkhachhang.Name = "txtkhachhang"
        Me.txtkhachhang.ReadOnly = True
        Me.txtkhachhang.Size = New System.Drawing.Size(371, 26)
        Me.txtkhachhang.TabIndex = 511
        '
        'cboNhomHoaDon
        '
        Me.cboNhomHoaDon.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.cboNhomHoaDon, 2)
        Me.cboNhomHoaDon.DisplayMember = "Text"
        Me.cboNhomHoaDon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNhomHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNhomHoaDon.FocusHighlightEnabled = True
        Me.cboNhomHoaDon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNhomHoaDon.FormattingEnabled = True
        Me.cboNhomHoaDon.ItemHeight = 22
        Me.cboNhomHoaDon.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cboNhomHoaDon.Location = New System.Drawing.Point(119, 130)
        Me.cboNhomHoaDon.Margin = New System.Windows.Forms.Padding(2)
        Me.cboNhomHoaDon.Name = "cboNhomHoaDon"
        Me.cboNhomHoaDon.Size = New System.Drawing.Size(152, 28)
        Me.cboNhomHoaDon.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.cboNhomHoaDon.TabIndex = 512
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Nhóm HĐ"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Nhóm KHD"
        '
        'RichTextBoxEx_ghichu
        '
        Me.RichTextBoxEx_ghichu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.RichTextBoxEx_ghichu.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.RichTextBoxEx_ghichu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.RichTextBoxEx_ghichu, 4)
        Me.RichTextBoxEx_ghichu.Location = New System.Drawing.Point(120, 195)
        Me.RichTextBoxEx_ghichu.Name = "RichTextBoxEx_ghichu"
        Me.RichTextBoxEx_ghichu.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 " &
    "Times New Roman;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\*\generator Riched20 10.0.19041}\viewkind4\uc1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\pard\f0\" &
    "fs21\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBoxEx_ghichu.Size = New System.Drawing.Size(371, 150)
        Me.RichTextBoxEx_ghichu.TabIndex = 513
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX2.Location = New System.Drawing.Point(6, 240)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(109, 60)
        Me.LabelX2.TabIndex = 514
        Me.LabelX2.Text = "Cảnh Báo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Đơn Hàng:"
        '
        'ToolStrip_List_Khachhang
        '
        Me.ToolStrip_List_Khachhang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip_List_Khachhang.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip_List_Khachhang.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_List_Khachhang.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip_List_Khachhang.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.ToolStripSeparator4, Me.btnModify, Me.ToolStripSeparator2, Me.btnDelete, Me.ToolStripSeparator1, Me.btnExport_Excel, Me.lblRow, Me.ToolStripSeparator3})
        Me.ToolStrip_List_Khachhang.Location = New System.Drawing.Point(543, 0)
        Me.ToolStrip_List_Khachhang.Name = "ToolStrip_List_Khachhang"
        Me.ToolStrip_List_Khachhang.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip_List_Khachhang.Size = New System.Drawing.Size(820, 31)
        Me.ToolStrip_List_Khachhang.TabIndex = 512
        Me.ToolStrip_List_Khachhang.Text = "ToolStrip1"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 28)
        Me.btnAdd.Text = "Thêm Mới"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'btnModify
        '
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(71, 28)
        Me.btnModify.Text = "Chỉnh sửa"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.WindowsApplication1.My.Resources.Resources.delete_24
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(60, 28)
        Me.btnDelete.Text = "Xóa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'btnExport_Excel
        '
        Me.btnExport_Excel.Image = Global.WindowsApplication1.My.Resources.Resources.microsoft_excel_24
        Me.btnExport_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport_Excel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExport_Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport_Excel.Name = "btnExport_Excel"
        Me.btnExport_Excel.Size = New System.Drawing.Size(101, 28)
        Me.btnExport_Excel.Text = "Xuất Excel"
        '
        'lblRow
        '
        Me.lblRow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(58, 28)
        Me.lblRow.Text = "Tổng số:"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'PnPopup_List
        '
        Me.PnPopup_List.Location = New System.Drawing.Point(566, 324)
        Me.PnPopup_List.Margin = New System.Windows.Forms.Padding(5)
        Me.PnPopup_List.Name = "PnPopup_List"
        Me.PnPopup_List.Size = New System.Drawing.Size(90, 79)
        Me.PnPopup_List.TabIndex = 520
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ContextMenuBar1)
        Me.Panel2.Controls.Add(Me.CircularProgress1)
        Me.Panel2.Controls.Add(Me.Super_Dgv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(543, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(820, 431)
        Me.Panel2.TabIndex = 521
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction, Me.CtxMenu})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(309, 160)
        Me.ContextMenuBar1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(165, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 451
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'CtxFunction
        '
        Me.CtxFunction.AutoExpandOnClick = True
        Me.CtxFunction.Name = "CtxFunction"
        Me.CtxFunction.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CtxFunction_Add, Me.CtxFunction_Modify, Me.CtxFunction_delete, Me.CtxFunction_Refresh, Me.LabelItem4, Me.CtxFunction_Copy, Me.LabelItem5, Me.CtxFunction_Export_Excel, Me.LabelItem6, Me.btnDefault})
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
        Me.LabelItem4.Text = "Sao Chép"
        '
        'CtxFunction_Copy
        '
        Me.CtxFunction_Copy.Name = "CtxFunction_Copy"
        Me.CtxFunction_Copy.Text = "Sao Chép"
        '
        'LabelItem5
        '
        Me.LabelItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem5.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem5.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem5.Name = "LabelItem5"
        Me.LabelItem5.PaddingBottom = 1
        Me.LabelItem5.PaddingLeft = 10
        Me.LabelItem5.PaddingTop = 1
        Me.LabelItem5.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem5.Text = "Xuất Excel"
        '
        'CtxFunction_Export_Excel
        '
        Me.CtxFunction_Export_Excel.Image = Global.WindowsApplication1.My.Resources.Resources.report
        Me.CtxFunction_Export_Excel.Name = "CtxFunction_Export_Excel"
        Me.CtxFunction_Export_Excel.Text = "Xuất Excel"
        '
        'LabelItem6
        '
        Me.LabelItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem6.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem6.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem6.Name = "LabelItem6"
        Me.LabelItem6.PaddingBottom = 1
        Me.LabelItem6.PaddingLeft = 10
        Me.LabelItem6.PaddingTop = 1
        Me.LabelItem6.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem6.Text = "Default"
        '
        'btnDefault
        '
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Text = "Default"
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
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgress1.Location = New System.Drawing.Point(397, 191)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(123, 109)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 450
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
        Me.Super_Dgv.Location = New System.Drawing.Point(58, 71)
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
        Me.Super_Dgv.PrimaryGrid.NoRowsText = "Không có dữ liệu"
        Me.Super_Dgv.PrimaryGrid.ReadOnly = True
        Me.Super_Dgv.PrimaryGrid.RowHeaderWidth = 45
        Me.Super_Dgv.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.Super_Dgv.PrimaryGrid.Title.Text = ""
        Me.Super_Dgv.Size = New System.Drawing.Size(195, 147)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 449
        '
        'frmDonHang_kinhDoanh_input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1363, 462)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PnPopup_List)
        Me.Controls.Add(Me.ToolStrip_List_Khachhang)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtOrder_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDonHang_kinhDoanh_input"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phòng kinh doanh"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip_List_Khachhang.ResumeLayout(False)
        Me.ToolStrip_List_Khachhang.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtOrder_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtdonhang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtngaynhap As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtngaygiao As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtkhachhang As TextBox
    Friend WithEvents lblkhachhang As Label
    Friend WithEvents lbltaixe As Label
    Friend WithEvents txtmakhach As TextBox
    Friend WithEvents ToolStrip_List_Khachhang As ToolStrip
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnModify As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnExport_Excel As ToolStripButton
    Friend WithEvents lblRow As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PnPopup_List As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents CtxFunction As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Modify As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_delete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxFunction_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem4 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Copy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem5 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents CtxFunction_Export_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem6 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents btnDefault As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Expand As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CtxMenu_Colapse As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSave_ColumnFrozen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents cboNhomHoaDon As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents RichTextBoxEx_ghichu As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
