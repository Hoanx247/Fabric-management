<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List_mahang_input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_mahang_input))
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtOrder_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtghichu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtloaihang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmahang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtNL1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNL2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNL3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNL4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNL5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNL6 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNL7 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtsolot = New System.Windows.Forms.TextBox()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtmetkg = New System.Windows.Forms.TextBox()
        Me.txtkhovai = New System.Windows.Forms.TextBox()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.BtnThemNhanh_KhachHang = New System.Windows.Forms.Button()
        Me.txtkhachhang = New System.Windows.Forms.TextBox()
        Me.txtmakhach = New System.Windows.Forms.TextBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BtnChonLai = New System.Windows.Forms.Button()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.cboLoaiDay = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cboNhomHang = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.PnPopup_List = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmdSave, 2)
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(115, 291)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(204, 47)
        Me.cmdSave.TabIndex = 9
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(326, 292)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(138, 45)
        Me.cmdExit.TabIndex = 10
        Me.cmdExit.Text = "Thoát"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(1008, 616)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(74, 29)
        Me.txtid.TabIndex = 380
        '
        'txtOrder_ID
        '
        Me.txtOrder_ID.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrder_ID.Location = New System.Drawing.Point(1008, 579)
        Me.txtOrder_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrder_ID.Name = "txtOrder_ID"
        Me.txtOrder_ID.Size = New System.Drawing.Size(74, 29)
        Me.txtOrder_ID.TabIndex = 381
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1004, 659)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 22)
        Me.Label3.TabIndex = 382
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
        Me.LabelX8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(37, 38)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(72, 20)
        Me.LabelX8.TabIndex = 441
        Me.LabelX8.Text = "Mã Hàng"
        '
        'LabelX7
        '
        Me.LabelX7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(47, 262)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(62, 20)
        Me.LabelX7.TabIndex = 440
        Me.LabelX7.Text = "Ghi chú"
        '
        'txtghichu
        '
        Me.txtghichu.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtghichu.Border.Class = "TextBoxBorder"
        Me.txtghichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtghichu, 3)
        Me.txtghichu.FocusHighlightEnabled = True
        Me.txtghichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu.Location = New System.Drawing.Point(115, 259)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(350, 26)
        Me.txtghichu.TabIndex = 8
        Me.txtghichu.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtloaihang
        '
        Me.txtloaihang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtloaihang.Border.Class = "TextBoxBorder"
        Me.txtloaihang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtloaihang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtloaihang, 3)
        Me.txtloaihang.FocusHighlightEnabled = True
        Me.txtloaihang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloaihang.Location = New System.Drawing.Point(115, 67)
        Me.txtloaihang.Name = "txtloaihang"
        Me.txtloaihang.Size = New System.Drawing.Size(350, 26)
        Me.txtloaihang.TabIndex = 2
        Me.txtloaihang.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtmahang
        '
        Me.txtmahang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmahang.Border.Class = "TextBoxBorder"
        Me.txtmahang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmahang, 3)
        Me.txtmahang.FocusHighlightEnabled = True
        Me.txtmahang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahang.Location = New System.Drawing.Point(115, 35)
        Me.txtmahang.Name = "txtmahang"
        Me.txtmahang.Size = New System.Drawing.Size(350, 26)
        Me.txtmahang.TabIndex = 1
        Me.txtmahang.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(29, 70)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(80, 20)
        Me.LabelX2.TabIndex = 443
        Me.LabelX2.Text = "Loại Hàng"
        '
        'txtNL1
        '
        '
        '
        '
        Me.txtNL1.Border.Class = "TextBoxBorder"
        Me.txtNL1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNL1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNL1.FocusHighlightEnabled = True
        Me.txtNL1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNL1.Location = New System.Drawing.Point(1062, 336)
        Me.txtNL1.Name = "txtNL1"
        Me.txtNL1.Size = New System.Drawing.Size(244, 26)
        Me.txtNL1.TabIndex = 444
        Me.txtNL1.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNL2
        '
        '
        '
        '
        Me.txtNL2.Border.Class = "TextBoxBorder"
        Me.txtNL2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNL2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNL2.FocusHighlightEnabled = True
        Me.txtNL2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNL2.Location = New System.Drawing.Point(1062, 372)
        Me.txtNL2.Name = "txtNL2"
        Me.txtNL2.Size = New System.Drawing.Size(244, 26)
        Me.txtNL2.TabIndex = 446
        Me.txtNL2.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNL3
        '
        '
        '
        '
        Me.txtNL3.Border.Class = "TextBoxBorder"
        Me.txtNL3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNL3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNL3.FocusHighlightEnabled = True
        Me.txtNL3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNL3.Location = New System.Drawing.Point(1062, 408)
        Me.txtNL3.Name = "txtNL3"
        Me.txtNL3.Size = New System.Drawing.Size(244, 26)
        Me.txtNL3.TabIndex = 448
        Me.txtNL3.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNL4
        '
        '
        '
        '
        Me.txtNL4.Border.Class = "TextBoxBorder"
        Me.txtNL4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNL4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNL4.FocusHighlightEnabled = True
        Me.txtNL4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNL4.Location = New System.Drawing.Point(1062, 444)
        Me.txtNL4.Name = "txtNL4"
        Me.txtNL4.Size = New System.Drawing.Size(244, 26)
        Me.txtNL4.TabIndex = 450
        Me.txtNL4.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNL5
        '
        '
        '
        '
        Me.txtNL5.Border.Class = "TextBoxBorder"
        Me.txtNL5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNL5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNL5.FocusHighlightEnabled = True
        Me.txtNL5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNL5.Location = New System.Drawing.Point(1062, 480)
        Me.txtNL5.Name = "txtNL5"
        Me.txtNL5.Size = New System.Drawing.Size(244, 26)
        Me.txtNL5.TabIndex = 452
        Me.txtNL5.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNL6
        '
        '
        '
        '
        Me.txtNL6.Border.Class = "TextBoxBorder"
        Me.txtNL6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNL6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNL6.FocusHighlightEnabled = True
        Me.txtNL6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNL6.Location = New System.Drawing.Point(1062, 516)
        Me.txtNL6.Name = "txtNL6"
        Me.txtNL6.Size = New System.Drawing.Size(244, 26)
        Me.txtNL6.TabIndex = 454
        Me.txtNL6.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNL7
        '
        '
        '
        '
        Me.txtNL7.Border.Class = "TextBoxBorder"
        Me.txtNL7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNL7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNL7.FocusHighlightEnabled = True
        Me.txtNL7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNL7.Location = New System.Drawing.Point(1062, 552)
        Me.txtNL7.Name = "txtNL7"
        Me.txtNL7.Size = New System.Drawing.Size(244, 26)
        Me.txtNL7.TabIndex = 456
        Me.txtNL7.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtsolot, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmetkg, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhovai, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnThemNhanh_KhachHang, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmakhach, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX7, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichu, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdExit, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSave, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtloaihang, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmahang, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnChonLai, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX11, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cboLoaiDay, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cboNhomHang, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(511, 400)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtsolot
        '
        Me.txtsolot.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsolot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsolot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtsolot, 2)
        Me.txtsolot.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsolot.Location = New System.Drawing.Point(115, 164)
        Me.txtsolot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsolot.Name = "txtsolot"
        Me.txtsolot.Size = New System.Drawing.Size(204, 26)
        Me.txtsolot.TabIndex = 5
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(52, 166)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(57, 20)
        Me.LabelX6.TabIndex = 462
        Me.LabelX6.Text = "Số Lot:"
        '
        'txtmetkg
        '
        Me.txtmetkg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmetkg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmetkg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmetkg, 2)
        Me.txtmetkg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmetkg.Location = New System.Drawing.Point(115, 132)
        Me.txtmetkg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmetkg.Name = "txtmetkg"
        Me.txtmetkg.Size = New System.Drawing.Size(204, 26)
        Me.txtmetkg.TabIndex = 4
        '
        'txtkhovai
        '
        Me.txtkhovai.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkhovai.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtkhovai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtkhovai, 2)
        Me.txtkhovai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhovai.Location = New System.Drawing.Point(115, 100)
        Me.txtkhovai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtkhovai.Name = "txtkhovai"
        Me.txtkhovai.Size = New System.Drawing.Size(204, 26)
        Me.txtkhovai.TabIndex = 3
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(5, 134)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(104, 20)
        Me.LabelX5.TabIndex = 461
        Me.LabelX5.Text = "Trọng Lượng:"
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(40, 102)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(69, 20)
        Me.LabelX3.TabIndex = 461
        Me.LabelX3.Text = "Khổ Vải:"
        '
        'BtnThemNhanh_KhachHang
        '
        Me.BtnThemNhanh_KhachHang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnThemNhanh_KhachHang.Location = New System.Drawing.Point(471, 3)
        Me.BtnThemNhanh_KhachHang.Name = "BtnThemNhanh_KhachHang"
        Me.BtnThemNhanh_KhachHang.Size = New System.Drawing.Size(37, 26)
        Me.BtnThemNhanh_KhachHang.TabIndex = 463
        Me.BtnThemNhanh_KhachHang.Text = "..."
        Me.BtnThemNhanh_KhachHang.UseVisualStyleBackColor = True
        '
        'txtkhachhang
        '
        Me.txtkhachhang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkhachhang.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtkhachhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkhachhang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtkhachhang, 2)
        Me.txtkhachhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang.ForeColor = System.Drawing.Color.Red
        Me.txtkhachhang.Location = New System.Drawing.Point(241, 4)
        Me.txtkhachhang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtkhachhang.Name = "txtkhachhang"
        Me.txtkhachhang.ReadOnly = True
        Me.txtkhachhang.Size = New System.Drawing.Size(224, 26)
        Me.txtkhachhang.TabIndex = 513
        '
        'txtmakhach
        '
        Me.txtmakhach.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmakhach.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmakhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmakhach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhach.Location = New System.Drawing.Point(115, 4)
        Me.txtmakhach.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmakhach.Name = "txtmakhach"
        Me.txtmakhach.Size = New System.Drawing.Size(120, 26)
        Me.txtmakhach.TabIndex = 0
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(16, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(93, 20)
        Me.LabelX1.TabIndex = 525
        Me.LabelX1.Text = "Khách Hàng"
        '
        'BtnChonLai
        '
        Me.BtnChonLai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChonLai.Location = New System.Drawing.Point(471, 35)
        Me.BtnChonLai.Name = "BtnChonLai"
        Me.BtnChonLai.Size = New System.Drawing.Size(37, 26)
        Me.BtnChonLai.TabIndex = 462
        Me.BtnChonLai.Text = "..."
        Me.BtnChonLai.UseVisualStyleBackColor = True
        '
        'LabelX11
        '
        Me.LabelX11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX11.AutoSize = True
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.Location = New System.Drawing.Point(33, 230)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(76, 20)
        Me.LabelX11.TabIndex = 460
        Me.LabelX11.Text = "Chọn Dây"
        '
        'cboLoaiDay
        '
        Me.cboLoaiDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.cboLoaiDay, 2)
        Me.cboLoaiDay.DisplayMember = "Text"
        Me.cboLoaiDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLoaiDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoaiDay.FocusHighlightEnabled = True
        Me.cboLoaiDay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoaiDay.FormattingEnabled = True
        Me.cboLoaiDay.ItemHeight = 22
        Me.cboLoaiDay.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7})
        Me.cboLoaiDay.Location = New System.Drawing.Point(114, 226)
        Me.cboLoaiDay.Margin = New System.Windows.Forms.Padding(2)
        Me.cboLoaiDay.Name = "cboLoaiDay"
        Me.cboLoaiDay.Size = New System.Drawing.Size(206, 28)
        Me.cboLoaiDay.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.cboLoaiDay.TabIndex = 7
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "1 DÂY"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "2 DÂY"
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(19, 198)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(90, 20)
        Me.LabelX4.TabIndex = 462
        Me.LabelX4.Text = "Chọn Nhóm"
        '
        'cboNhomHang
        '
        Me.cboNhomHang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.cboNhomHang, 2)
        Me.cboNhomHang.DisplayMember = "Text"
        Me.cboNhomHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNhomHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNhomHang.FocusHighlightEnabled = True
        Me.cboNhomHang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNhomHang.FormattingEnabled = True
        Me.cboNhomHang.ItemHeight = 22
        Me.cboNhomHang.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cboNhomHang.Location = New System.Drawing.Point(114, 194)
        Me.cboNhomHang.Margin = New System.Windows.Forms.Padding(2)
        Me.cboNhomHang.Name = "cboNhomHang"
        Me.cboNhomHang.Size = New System.Drawing.Size(206, 28)
        Me.cboNhomHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.cboNhomHang.TabIndex = 6
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Nền"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "RIB"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "BO CỔ"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "BO TAY"
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
        Me.Super_Dgv.Location = New System.Drawing.Point(61, 32)
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
        Me.Super_Dgv.TabIndex = 459
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CircularProgress1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(511, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 400)
        Me.Panel1.TabIndex = 460
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
        Me.CircularProgress1.Location = New System.Drawing.Point(402, 69)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SpringGreen
        Me.CircularProgress1.ProgressText = "Loading..."
        Me.CircularProgress1.ProgressTextColor = System.Drawing.Color.Blue
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(116, 122)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 460
        Me.CircularProgress1.Visible = False
        '
        'PnPopup_List
        '
        Me.PnPopup_List.Location = New System.Drawing.Point(570, 161)
        Me.PnPopup_List.Margin = New System.Windows.Forms.Padding(5)
        Me.PnPopup_List.Name = "PnPopup_List"
        Me.PnPopup_List.Size = New System.Drawing.Size(90, 79)
        Me.PnPopup_List.TabIndex = 521
        '
        'List_mahang_input
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(1103, 400)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnPopup_List)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtNL7)
        Me.Controls.Add(Me.txtNL6)
        Me.Controls.Add(Me.txtNL5)
        Me.Controls.Add(Me.txtNL4)
        Me.Controls.Add(Me.txtNL3)
        Me.Controls.Add(Me.txtNL2)
        Me.Controls.Add(Me.txtNL1)
        Me.Controls.Add(Me.txtOrder_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "List_mahang_input"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin Mã Hàng"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtOrder_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtghichu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtloaihang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmahang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNL1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNL2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNL3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNL4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNL5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNL6 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNL7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnChonLai As Button
    Friend WithEvents cboNhomHang As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents txtkhachhang As TextBox
    Friend WithEvents txtmakhach As TextBox
    Friend WithEvents PnPopup_List As Panel
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents cboLoaiDay As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents BtnThemNhanh_KhachHang As Button
    Friend WithEvents txtmetkg As TextBox
    Friend WithEvents txtkhovai As TextBox
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtsolot As TextBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
End Class
