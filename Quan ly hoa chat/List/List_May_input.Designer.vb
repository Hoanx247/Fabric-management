<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_May_input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_May_input))
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtOrder_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtghichu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txttenmay = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtmamay = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboNhom = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(153, 215)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(144, 40)
        Me.cmdSave.TabIndex = 372
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.Location = New System.Drawing.Point(304, 215)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(105, 40)
        Me.cmdExit.TabIndex = 371
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
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(12, 121)
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
        Me.LabelX1.Location = New System.Drawing.Point(12, 54)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(64, 20)
        Me.LabelX1.TabIndex = 443
        Me.LabelX1.Text = "Tên Máy"
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
        Me.txtghichu.Location = New System.Drawing.Point(119, 120)
        Me.txtghichu.Multiline = True
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(290, 88)
        Me.txtghichu.TabIndex = 442
        Me.txtghichu.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txttenmay
        '
        '
        '
        '
        Me.txttenmay.Border.Class = "TextBoxBorder"
        Me.txttenmay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttenmay.FocusHighlightEnabled = True
        Me.txttenmay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenmay.Location = New System.Drawing.Point(119, 48)
        Me.txttenmay.MaxLength = 100
        Me.txttenmay.Name = "txttenmay"
        Me.txttenmay.Size = New System.Drawing.Size(290, 26)
        Me.txttenmay.TabIndex = 440
        Me.txttenmay.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(12, 18)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(61, 20)
        Me.LabelX2.TabIndex = 446
        Me.LabelX2.Text = "Mã Máy"
        '
        'txtmamay
        '
        '
        '
        '
        Me.txtmamay.Border.Class = "TextBoxBorder"
        Me.txtmamay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmamay.FocusHighlightEnabled = True
        Me.txtmamay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamay.Location = New System.Drawing.Point(119, 12)
        Me.txtmamay.MaxLength = 100
        Me.txtmamay.Name = "txtmamay"
        Me.txtmamay.Size = New System.Drawing.Size(290, 26)
        Me.txtmamay.TabIndex = 445
        Me.txtmamay.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboNhom
        '
        Me.cboNhom.DisplayMember = "Text"
        Me.cboNhom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNhom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNhom.FormattingEnabled = True
        Me.cboNhom.ItemHeight = 24
        Me.cboNhom.Location = New System.Drawing.Point(119, 84)
        Me.cboNhom.Name = "cboNhom"
        Me.cboNhom.Size = New System.Drawing.Size(290, 30)
        Me.cboNhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboNhom.TabIndex = 447
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(12, 90)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(92, 20)
        Me.LabelX3.TabIndex = 448
        Me.LabelX3.Text = "Thuộc Nhóm"
        '
        'List_May_input
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(413, 260)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.cboNhom)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtmamay)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtghichu)
        Me.Controls.Add(Me.txttenmay)
        Me.Controls.Add(Me.txtOrder_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "List_May_input"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin Máy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtOrder_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtghichu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txttenmay As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtmamay As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboNhom As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
End Class
