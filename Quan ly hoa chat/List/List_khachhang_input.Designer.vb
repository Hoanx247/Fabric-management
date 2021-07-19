<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_khachhang_input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_khachhang_input))
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.txtmakhach = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtghichu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtgiaodich = New System.Windows.Forms.DateTimePicker()
        Me.cbochucvu_1 = New System.Windows.Forms.ComboBox()
        Me.txtTel_1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtWeb = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbltaixe = New System.Windows.Forms.Label()
        Me.txtpeople1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtdiachi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbonhom = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.VIP = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.txtmasothue = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtkhachhang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnganhghe = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltrangthai = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdThoat = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtmakhach
        '
        Me.txtmakhach.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmakhach.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtmakhach.Border.Class = "TextBoxBorder"
        Me.txtmakhach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmakhach, 2)
        Me.txtmakhach.FocusHighlightEnabled = True
        Me.txtmakhach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhach.Location = New System.Drawing.Point(151, 4)
        Me.txtmakhach.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmakhach.Name = "txtmakhach"
        Me.txtmakhach.Size = New System.Drawing.Size(258, 26)
        Me.txtmakhach.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 390
        Me.Label1.Text = "*Mã Khách:"
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
        Me.txtghichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu.Location = New System.Drawing.Point(151, 388)
        Me.txtghichu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtghichu.Multiline = True
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(258, 24)
        Me.txtghichu.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(57, 357)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 22)
        Me.Label4.TabIndex = 407
        Me.Label4.Text = "Ngày GD:"
        '
        'dtgiaodich
        '
        Me.dtgiaodich.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgiaodich.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgiaodich.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtgiaodich.Location = New System.Drawing.Point(150, 355)
        Me.dtgiaodich.Name = "dtgiaodich"
        Me.dtgiaodich.Size = New System.Drawing.Size(143, 26)
        Me.dtgiaodich.TabIndex = 11
        '
        'cbochucvu_1
        '
        Me.cbochucvu_1.AllowDrop = True
        Me.cbochucvu_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbochucvu_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbochucvu_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cbochucvu_1, 2)
        Me.cbochucvu_1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbochucvu_1.ForeColor = System.Drawing.Color.Black
        Me.cbochucvu_1.FormattingEnabled = True
        Me.cbochucvu_1.Items.AddRange(New Object() {"Giám Đốc", "Nhân Viên", "P. Giám Đốc"})
        Me.cbochucvu_1.Location = New System.Drawing.Point(150, 227)
        Me.cbochucvu_1.Name = "cbochucvu_1"
        Me.cbochucvu_1.Size = New System.Drawing.Size(260, 27)
        Me.cbochucvu_1.Sorted = True
        Me.cbochucvu_1.TabIndex = 7
        '
        'txtTel_1
        '
        Me.txtTel_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtTel_1.Border.Class = "TextBoxBorder"
        Me.txtTel_1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtTel_1, 2)
        Me.txtTel_1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel_1.Location = New System.Drawing.Point(151, 260)
        Me.txtTel_1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTel_1.Name = "txtTel_1"
        Me.txtTel_1.Size = New System.Drawing.Size(258, 26)
        Me.txtTel_1.TabIndex = 8
        '
        'txtWeb
        '
        Me.txtWeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtWeb.Border.Class = "TextBoxBorder"
        Me.txtWeb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtWeb, 2)
        Me.txtWeb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.Location = New System.Drawing.Point(151, 324)
        Me.txtWeb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(258, 26)
        Me.txtWeb.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(41, 261)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 22)
        Me.Label12.TabIndex = 393
        Me.Label12.Text = "Điện Thoại:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(85, 293)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 22)
        Me.Label10.TabIndex = 404
        Me.Label10.Text = "Email:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(62, 229)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 22)
        Me.Label11.TabIndex = 392
        Me.Label11.Text = "Chức vụ:"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtEmail.Border.Class = "TextBoxBorder"
        Me.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtEmail, 2)
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(151, 292)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(258, 26)
        Me.txtEmail.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 197)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 22)
        Me.Label8.TabIndex = 391
        Me.Label8.Text = "Người liên hệ 1:"
        '
        'lbltaixe
        '
        Me.lbltaixe.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbltaixe.AutoSize = True
        Me.lbltaixe.BackColor = System.Drawing.Color.Transparent
        Me.lbltaixe.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltaixe.ForeColor = System.Drawing.Color.Black
        Me.lbltaixe.Location = New System.Drawing.Point(65, 325)
        Me.lbltaixe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltaixe.Name = "lbltaixe"
        Me.lbltaixe.Size = New System.Drawing.Size(78, 22)
        Me.lbltaixe.TabIndex = 402
        Me.lbltaixe.Text = "Website:"
        '
        'txtpeople1
        '
        Me.txtpeople1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtpeople1.Border.Class = "TextBoxBorder"
        Me.txtpeople1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtpeople1, 2)
        Me.txtpeople1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpeople1.Location = New System.Drawing.Point(151, 196)
        Me.txtpeople1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpeople1.Name = "txtpeople1"
        Me.txtpeople1.Size = New System.Drawing.Size(258, 26)
        Me.txtpeople1.TabIndex = 6
        '
        'txtdiachi
        '
        Me.txtdiachi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtdiachi.Border.Class = "TextBoxBorder"
        Me.txtdiachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtdiachi, 2)
        Me.txtdiachi.FocusHighlightEnabled = True
        Me.txtdiachi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi.Location = New System.Drawing.Point(151, 132)
        Me.txtdiachi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(258, 26)
        Me.txtdiachi.TabIndex = 4
        '
        'cbonhom
        '
        Me.cbonhom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.cbonhom, 2)
        Me.cbonhom.DisplayMember = "Text"
        Me.cbonhom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbonhom.FocusHighlightEnabled = True
        Me.cbonhom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbonhom.FormattingEnabled = True
        Me.cbonhom.ItemHeight = 20
        Me.cbonhom.Items.AddRange(New Object() {Me.VIP, Me.ComboItem1})
        Me.cbonhom.Location = New System.Drawing.Point(150, 67)
        Me.cbonhom.Name = "cbonhom"
        Me.cbonhom.Size = New System.Drawing.Size(260, 26)
        Me.cbonhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbonhom.TabIndex = 2
        '
        'VIP
        '
        Me.VIP.Text = "VIP"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Khách Lẻ"
        '
        'txtmasothue
        '
        Me.txtmasothue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmasothue.Border.Class = "TextBoxBorder"
        Me.txtmasothue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtmasothue, 2)
        Me.txtmasothue.FocusHighlightEnabled = True
        Me.txtmasothue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmasothue.Location = New System.Drawing.Point(151, 164)
        Me.txtmasothue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmasothue.Name = "txtmasothue"
        Me.txtmasothue.Size = New System.Drawing.Size(258, 26)
        Me.txtmasothue.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(34, 165)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 22)
        Me.Label13.TabIndex = 387
        Me.Label13.Text = "Mã số Thuế:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(70, 133)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 22)
        Me.Label7.TabIndex = 385
        Me.Label7.Text = "Địa Chỉ:"
        '
        'txtkhachhang
        '
        Me.txtkhachhang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtkhachhang.Border.Class = "TextBoxBorder"
        Me.txtkhachhang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtkhachhang, 2)
        Me.txtkhachhang.FocusHighlightEnabled = True
        Me.txtkhachhang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhachhang.Location = New System.Drawing.Point(151, 36)
        Me.txtkhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkhachhang.Name = "txtkhachhang"
        Me.txtkhachhang.Size = New System.Drawing.Size(258, 26)
        Me.txtkhachhang.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(29, 101)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 22)
        Me.Label6.TabIndex = 382
        Me.Label6.Text = "Ngành Nghề:"
        '
        'txtnganhghe
        '
        Me.txtnganhghe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtnganhghe.Border.Class = "TextBoxBorder"
        Me.txtnganhghe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtnganhghe, 2)
        Me.txtnganhghe.FocusHighlightEnabled = True
        Me.txtnganhghe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnganhghe.Location = New System.Drawing.Point(151, 100)
        Me.txtnganhghe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnganhghe.Name = "txtnganhghe"
        Me.txtnganhghe.Size = New System.Drawing.Size(258, 26)
        Me.txtnganhghe.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(70, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 380
        Me.Label2.Text = "*Nhóm:"
        '
        'lbltrangthai
        '
        Me.lbltrangthai.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbltrangthai.AutoSize = True
        Me.lbltrangthai.BackColor = System.Drawing.Color.Transparent
        Me.lbltrangthai.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrangthai.ForeColor = System.Drawing.Color.Black
        Me.lbltrangthai.Location = New System.Drawing.Point(22, 37)
        Me.lbltrangthai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltrangthai.Name = "lbltrangthai"
        Me.lbltrangthai.Size = New System.Drawing.Size(121, 22)
        Me.lbltrangthai.TabIndex = 379
        Me.lbltrangthai.Text = "*Khách Hàng:"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(150, 419)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(143, 47)
        Me.cmdSave.TabIndex = 386
        Me.cmdSave.Text = "Lưu (F5)"
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
        Me.cmdThoat.Location = New System.Drawing.Point(300, 420)
        Me.cmdThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdThoat.Name = "cmdThoat"
        Me.cmdThoat.Size = New System.Drawing.Size(109, 45)
        Me.cmdThoat.TabIndex = 2
        Me.cmdThoat.Text = "Thoát"
        Me.cmdThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdThoat.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichu, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdThoat, 2, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtgiaodich, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.lbltrangthai, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWeb, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTel_1, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmail, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.cbochucvu_1, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtpeople1, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmasothue, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtdiachi, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cbonhom, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtnganhghe, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lbltaixe, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txtkhachhang, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmakhach, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdSave, 1, 13)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 15
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(450, 474)
        Me.TableLayoutPanel1.TabIndex = 393
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CircularProgress1)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(450, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 474)
        Me.Panel1.TabIndex = 461
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
        Me.Super_Dgv.PrimaryGrid.GroupByRow.Visible = True
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
        'List_khachhang_input
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1217, 474)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "List_khachhang_input"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Thông tin khách hàng"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtghichu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtgiaodich As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbochucvu_1 As System.Windows.Forms.ComboBox
    Private WithEvents txtTel_1 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtWeb As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents txtEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbltaixe As System.Windows.Forms.Label
    Private WithEvents txtpeople1 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtdiachi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbonhom As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents VIP As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Private WithEvents txtmasothue As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtkhachhang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtnganhghe As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltrangthai As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdThoat As System.Windows.Forms.Button
    Private WithEvents txtmakhach As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
End Class
