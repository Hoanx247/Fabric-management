<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmabout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmabout))
        Me.lblmodel_may = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.btKey = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmodel_may
        '
        Me.lblmodel_may.AutoSize = True
        Me.lblmodel_may.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodel_may.Location = New System.Drawing.Point(615, 155)
        Me.lblmodel_may.Name = "lblmodel_may"
        Me.lblmodel_may.Size = New System.Drawing.Size(48, 16)
        Me.lblmodel_may.TabIndex = 15
        Me.lblmodel_may.Text = "12345"
        '
        'txtKey
        '
        Me.txtKey.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Location = New System.Drawing.Point(602, 177)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(103, 26)
        Me.txtKey.TabIndex = 10
        Me.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btKey
        '
        Me.btKey.Location = New System.Drawing.Point(602, 51)
        Me.btKey.Name = "btKey"
        Me.btKey.Size = New System.Drawing.Size(158, 31)
        Me.btKey.TabIndex = 9
        Me.btKey.Text = "Kích hoạt"
        Me.btKey.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "QUẢN LÝ KHO MỘC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(621, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Version: 1.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(598, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Author: Hoa Nguyen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(598, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tel: 0982 283 629"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 130)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(254, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "ĐƠN VỊ: SONG THỦY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(260, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Hỗ trợ kỹ thuật"
        '
        'frmabout
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(566, 208)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblmodel_may)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.btKey)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmabout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin phần mềm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmodel_may As System.Windows.Forms.Label
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents btKey As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
