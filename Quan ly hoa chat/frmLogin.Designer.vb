<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtgroup = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonX_Thoat = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX_Save = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bindingNavigatorEx1 = New DevComponents.DotNetBar.Controls.BindingNavigatorEx(Me.components)
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem_Up_scale = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Down_scale = New DevComponents.DotNetBar.ButtonItem()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingNavigatorEx1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtgroup, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtuser, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtpass, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonX_Thoat, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonX_Save, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(371, 223)
        Me.TableLayoutPanel1.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tài Khoản:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mật Khẩu:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quyền:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtgroup
        '
        Me.txtgroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtgroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtgroup, 2)
        Me.txtgroup.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgroup.Location = New System.Drawing.Point(98, 117)
        Me.txtgroup.Margin = New System.Windows.Forms.Padding(2)
        Me.txtgroup.Name = "txtgroup"
        Me.txtgroup.ReadOnly = True
        Me.txtgroup.Size = New System.Drawing.Size(260, 25)
        Me.txtgroup.TabIndex = 7
        '
        'txtuser
        '
        Me.txtuser.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtuser, 2)
        Me.txtuser.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(98, 53)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(260, 25)
        Me.txtuser.TabIndex = 1
        '
        'txtpass
        '
        Me.txtpass.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtpass, 2)
        Me.txtpass.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(98, 85)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(260, 25)
        Me.txtpass.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.HDWaterMark__Black
        Me.PictureBox1.Location = New System.Drawing.Point(243, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ButtonX_Thoat
        '
        Me.ButtonX_Thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX_Thoat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX_Thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX_Thoat.Location = New System.Drawing.Point(243, 149)
        Me.ButtonX_Thoat.Name = "ButtonX_Thoat"
        Me.ButtonX_Thoat.Size = New System.Drawing.Size(114, 39)
        Me.ButtonX_Thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX_Thoat.Symbol = ""
        Me.ButtonX_Thoat.SymbolSize = 20.0!
        Me.ButtonX_Thoat.TabIndex = 13
        Me.ButtonX_Thoat.Text = "Thoát"
        '
        'ButtonX_Save
        '
        Me.ButtonX_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX_Save.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX_Save.Location = New System.Drawing.Point(99, 149)
        Me.ButtonX_Save.Name = "ButtonX_Save"
        Me.ButtonX_Save.Size = New System.Drawing.Size(138, 39)
        Me.ButtonX_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX_Save.Symbol = ""
        Me.ButtonX_Save.SymbolSize = 20.0!
        Me.ButtonX_Save.TabIndex = 12
        Me.ButtonX_Save.Text = "Đăng Nhập"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 26)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "SONG THỦY H.K"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bindingNavigatorEx1
        '
        Me.bindingNavigatorEx1.CountLabel = Nothing
        Me.bindingNavigatorEx1.CountLabelFormat = "of {0}"
        Me.bindingNavigatorEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bindingNavigatorEx1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bindingNavigatorEx1.IsMaximized = False
        Me.bindingNavigatorEx1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.ButtonItem_Up_scale, Me.ButtonItem_Down_scale})
        Me.bindingNavigatorEx1.Location = New System.Drawing.Point(0, 192)
        Me.bindingNavigatorEx1.Name = "bindingNavigatorEx1"
        Me.bindingNavigatorEx1.Size = New System.Drawing.Size(371, 31)
        Me.bindingNavigatorEx1.Stretch = True
        Me.bindingNavigatorEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bindingNavigatorEx1.TabIndex = 546
        Me.bindingNavigatorEx1.TabStop = False
        Me.bindingNavigatorEx1.Text = "bindingNavigatorEx1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Symbol = ""
        Me.LabelItem1.Text = "http://haidangpro.com"
        Me.LabelItem1.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelItem1.Tooltip = "http://haidangpro.com"
        '
        'ButtonItem_Up_scale
        '
        Me.ButtonItem_Up_scale.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.ButtonItem_Up_scale.Name = "ButtonItem_Up_scale"
        Me.ButtonItem_Up_scale.Symbol = ""
        Me.ButtonItem_Up_scale.SymbolColor = System.Drawing.Color.Maroon
        Me.ButtonItem_Up_scale.Tooltip = "Scale Form Up"
        '
        'ButtonItem_Down_scale
        '
        Me.ButtonItem_Down_scale.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.ButtonItem_Down_scale.Name = "ButtonItem_Down_scale"
        Me.ButtonItem_Down_scale.Symbol = ""
        Me.ButtonItem_Down_scale.SymbolColor = System.Drawing.Color.Maroon
        Me.ButtonItem_Down_scale.Tooltip = "Scale Form Down"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(371, 223)
        Me.Controls.Add(Me.bindingNavigatorEx1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập [Quản lý Kho]"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingNavigatorEx1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtgroup As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonX_Thoat As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX_Save As DevComponents.DotNetBar.ButtonX
    Private WithEvents bindingNavigatorEx1 As DevComponents.DotNetBar.Controls.BindingNavigatorEx
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Private WithEvents ButtonItem_Up_scale As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItem_Down_scale As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Label3 As Label
End Class
