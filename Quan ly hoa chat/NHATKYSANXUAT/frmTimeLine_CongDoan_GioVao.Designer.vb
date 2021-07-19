<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeLine_CongDoan_GioVao
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtkhuvuc = New System.Windows.Forms.TextBox()
        Me.BtnExit_CapNhat = New System.Windows.Forms.Button()
        Me.txtmasonhanvien = New System.Windows.Forms.TextBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txttennhanvien = New System.Windows.Forms.TextBox()
        Me.btnXacNhan_GioVao = New DevComponents.DotNetBar.ButtonX()
        Me.txtmame = New System.Windows.Forms.TextBox()
        Me.txtmacongdoan = New System.Windows.Forms.TextBox()
        Me.txtmamay = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtkhuvuc, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnExit_CapNhat, 3, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txtmasonhanvien, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelX1, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelX6, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txttennhanvien, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnXacNhan_GioVao, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txtmame, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtmacongdoan, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtmamay, 4, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(815, 251)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'txtkhuvuc
        '
        Me.txtkhuvuc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkhuvuc.BackColor = System.Drawing.SystemColors.Control
        Me.txtkhuvuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkhuvuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtkhuvuc, 2)
        Me.txtkhuvuc.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhuvuc.ForeColor = System.Drawing.Color.Red
        Me.txtkhuvuc.Location = New System.Drawing.Point(180, 10)
        Me.txtkhuvuc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtkhuvuc.Name = "txtkhuvuc"
        Me.txtkhuvuc.Size = New System.Drawing.Size(403, 39)
        Me.txtkhuvuc.TabIndex = 453
        Me.txtkhuvuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnExit_CapNhat
        '
        Me.BtnExit_CapNhat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit_CapNhat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit_CapNhat.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnExit_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit_CapNhat.Location = New System.Drawing.Point(395, 154)
        Me.BtnExit_CapNhat.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnExit_CapNhat.Name = "BtnExit_CapNhat"
        Me.BtnExit_CapNhat.Size = New System.Drawing.Size(185, 80)
        Me.BtnExit_CapNhat.TabIndex = 9
        Me.BtnExit_CapNhat.Text = "Thoát"
        Me.BtnExit_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit_CapNhat.UseVisualStyleBackColor = True
        '
        'txtmasonhanvien
        '
        Me.txtmasonhanvien.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmasonhanvien.BackColor = System.Drawing.Color.Yellow
        Me.txtmasonhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmasonhanvien.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmasonhanvien.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmasonhanvien.ForeColor = System.Drawing.Color.Red
        Me.txtmasonhanvien.Location = New System.Drawing.Point(180, 62)
        Me.txtmasonhanvien.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmasonhanvien.Name = "txtmasonhanvien"
        Me.txtmasonhanvien.Size = New System.Drawing.Size(208, 39)
        Me.txtmasonhanvien.TabIndex = 451
        Me.txtmasonhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(19, 64)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(156, 34)
        Me.LabelX1.TabIndex = 453
        Me.LabelX1.Text = "NHÂN VIÊN"
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(44, 13)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(131, 34)
        Me.LabelX6.TabIndex = 452
        Me.LabelX6.Text = "KHU VỰC"
        '
        'txttennhanvien
        '
        Me.txttennhanvien.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttennhanvien.BackColor = System.Drawing.SystemColors.Control
        Me.txttennhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttennhanvien.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttennhanvien.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttennhanvien.ForeColor = System.Drawing.Color.Red
        Me.txttennhanvien.Location = New System.Drawing.Point(392, 62)
        Me.txttennhanvien.Margin = New System.Windows.Forms.Padding(2)
        Me.txttennhanvien.Name = "txttennhanvien"
        Me.txttennhanvien.Size = New System.Drawing.Size(191, 39)
        Me.txttennhanvien.TabIndex = 452
        Me.txttennhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnXacNhan_GioVao
        '
        Me.btnXacNhan_GioVao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnXacNhan_GioVao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnXacNhan_GioVao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnXacNhan_GioVao.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacNhan_GioVao.Location = New System.Drawing.Point(181, 152)
        Me.btnXacNhan_GioVao.Name = "btnXacNhan_GioVao"
        Me.btnXacNhan_GioVao.Size = New System.Drawing.Size(206, 84)
        Me.btnXacNhan_GioVao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnXacNhan_GioVao.Symbol = ""
        Me.btnXacNhan_GioVao.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnXacNhan_GioVao.TabIndex = 478
        Me.btnXacNhan_GioVao.Text = "F3 - GIỜ VÀO"
        Me.btnXacNhan_GioVao.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'txtmame
        '
        Me.txtmame.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmame.BackColor = System.Drawing.SystemColors.Control
        Me.txtmame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmame.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmame.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmame.ForeColor = System.Drawing.Color.Red
        Me.txtmame.Location = New System.Drawing.Point(587, 10)
        Me.txtmame.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmame.Name = "txtmame"
        Me.txtmame.Size = New System.Drawing.Size(215, 39)
        Me.txtmame.TabIndex = 494
        Me.txtmame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmacongdoan
        '
        Me.txtmacongdoan.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmacongdoan.BackColor = System.Drawing.SystemColors.Control
        Me.txtmacongdoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmacongdoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmacongdoan.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmacongdoan.ForeColor = System.Drawing.Color.Red
        Me.txtmacongdoan.Location = New System.Drawing.Point(587, 62)
        Me.txtmacongdoan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmacongdoan.Name = "txtmacongdoan"
        Me.txtmacongdoan.Size = New System.Drawing.Size(215, 39)
        Me.txtmacongdoan.TabIndex = 496
        Me.txtmacongdoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmamay
        '
        Me.txtmamay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmamay.BackColor = System.Drawing.SystemColors.Control
        Me.txtmamay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmamay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmamay.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamay.ForeColor = System.Drawing.Color.Red
        Me.txtmamay.Location = New System.Drawing.Point(587, 106)
        Me.txtmamay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmamay.Name = "txtmamay"
        Me.txtmamay.Size = New System.Drawing.Size(215, 39)
        Me.txtmamay.TabIndex = 497
        Me.txtmamay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'frmTimeLine_CongDoan_GioVao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 251)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimeLine_CongDoan_GioVao"
        Me.Text = "frmTimeLine_CongDoan_GioVao"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtkhuvuc As TextBox
    Friend WithEvents BtnExit_CapNhat As Button
    Friend WithEvents btnXacNhan_GioVao As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtmasonhanvien As TextBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txttennhanvien As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtmame As TextBox
    Friend WithEvents txtmacongdoan As TextBox
    Friend WithEvents txtmamay As TextBox
End Class
