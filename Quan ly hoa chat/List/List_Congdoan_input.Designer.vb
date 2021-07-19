<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_Congdoan_input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_Congdoan_input))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtOrder_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtghichu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCongdoan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmaCongdoan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtthoigian = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtClr_selected = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnColorPicker = New DevComponents.DotNetBar.ColorPickerButton()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(185, 185)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(144, 40)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Lưu"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(336, 185)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(105, 40)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Thoát"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.Location = New System.Drawing.Point(565, 65)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(54, 28)
        Me.txtid.TabIndex = 374
        '
        'txtOrder_ID
        '
        Me.txtOrder_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrder_ID.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrder_ID.ForeColor = System.Drawing.Color.Black
        Me.txtOrder_ID.Location = New System.Drawing.Point(596, 167)
        Me.txtOrder_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrder_ID.Name = "txtOrder_ID"
        Me.txtOrder_ID.Size = New System.Drawing.Size(29, 29)
        Me.txtOrder_ID.TabIndex = 377
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(474, 173)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 22)
        Me.Label3.TabIndex = 378
        Me.Label3.Text = "Order ID:"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(25, 49)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(110, 20)
        Me.LabelX8.TabIndex = 445
        Me.LabelX8.Text = "Tên Công Đoạn"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(78, 108)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(57, 20)
        Me.LabelX7.TabIndex = 444
        Me.LabelX7.Text = "Ghi chú"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(28, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(107, 20)
        Me.LabelX1.TabIndex = 443
        Me.LabelX1.Text = "Mã Công Đoạn"
        '
        'txtghichu
        '
        '
        '
        '
        Me.txtghichu.Border.Class = "TextBoxBorder"
        Me.txtghichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtghichu.FocusHighlightEnabled = True
        Me.txtghichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu.Location = New System.Drawing.Point(151, 108)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(290, 26)
        Me.txtghichu.TabIndex = 3
        Me.txtghichu.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtCongdoan
        '
        '
        '
        '
        Me.txtCongdoan.Border.Class = "TextBoxBorder"
        Me.txtCongdoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCongdoan.FocusHighlightEnabled = True
        Me.txtCongdoan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCongdoan.Location = New System.Drawing.Point(151, 44)
        Me.txtCongdoan.Name = "txtCongdoan"
        Me.txtCongdoan.Size = New System.Drawing.Size(290, 26)
        Me.txtCongdoan.TabIndex = 1
        Me.txtCongdoan.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtmaCongdoan
        '
        '
        '
        '
        Me.txtmaCongdoan.Border.Class = "TextBoxBorder"
        Me.txtmaCongdoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmaCongdoan.FocusHighlightEnabled = True
        Me.txtmaCongdoan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaCongdoan.Location = New System.Drawing.Point(151, 8)
        Me.txtmaCongdoan.Name = "txtmaCongdoan"
        Me.txtmaCongdoan.Size = New System.Drawing.Size(290, 26)
        Me.txtmaCongdoan.TabIndex = 0
        Me.txtmaCongdoan.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(62, 82)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(73, 20)
        Me.LabelX2.TabIndex = 447
        Me.LabelX2.Text = "Thời Gian"
        '
        'txtthoigian
        '
        '
        '
        '
        Me.txtthoigian.Border.Class = "TextBoxBorder"
        Me.txtthoigian.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtthoigian.FocusHighlightEnabled = True
        Me.txtthoigian.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtthoigian.Location = New System.Drawing.Point(151, 76)
        Me.txtthoigian.Name = "txtthoigian"
        Me.txtthoigian.Size = New System.Drawing.Size(123, 26)
        Me.txtthoigian.TabIndex = 2
        Me.txtthoigian.Text = "0"
        Me.txtthoigian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtthoigian.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtClr_selected
        '
        '
        '
        '
        Me.txtClr_selected.Border.Class = "TextBoxBorder"
        Me.txtClr_selected.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtClr_selected.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClr_selected.Location = New System.Drawing.Point(312, 140)
        Me.txtClr_selected.Name = "txtClr_selected"
        Me.txtClr_selected.PreventEnterBeep = True
        Me.txtClr_selected.Size = New System.Drawing.Size(129, 38)
        Me.txtClr_selected.TabIndex = 481
        '
        'BtnColorPicker
        '
        Me.BtnColorPicker.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnColorPicker.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnColorPicker.Image = CType(resources.GetObject("BtnColorPicker.Image"), System.Drawing.Image)
        Me.BtnColorPicker.Location = New System.Drawing.Point(151, 140)
        Me.BtnColorPicker.Name = "BtnColorPicker"
        Me.BtnColorPicker.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.BtnColorPicker.Size = New System.Drawing.Size(155, 38)
        Me.BtnColorPicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnColorPicker.SubItemsExpandWidth = 25
        Me.BtnColorPicker.TabIndex = 480
        '
        'List_Congdoan_input
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(447, 233)
        Me.Controls.Add(Me.txtClr_selected)
        Me.Controls.Add(Me.BtnColorPicker)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtthoigian)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtghichu)
        Me.Controls.Add(Me.txtCongdoan)
        Me.Controls.Add(Me.txtmaCongdoan)
        Me.Controls.Add(Me.txtOrder_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "List_Congdoan_input"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin Công Đoạn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtOrder_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtghichu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCongdoan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmaCongdoan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtthoigian As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtClr_selected As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnColorPicker As DevComponents.DotNetBar.ColorPickerButton
End Class
