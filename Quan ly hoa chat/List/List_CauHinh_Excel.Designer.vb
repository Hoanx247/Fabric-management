<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List_CauHinh_Excel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_CauHinh_Excel))
        Dim Thickness3 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness4 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderColor2 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GP_Form_Folder_Path = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBoxX_LocalNetwork = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX_Browser_Path = New DevComponents.DotNetBar.ButtonX()
        Me.BtnHidden_Panel_Folder_Path = New System.Windows.Forms.Button()
        Me.RichTextBoxEx_Folder_Path = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.BtnFolder_Path_Save = New System.Windows.Forms.Button()
        Me.GP_Form = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonX_GP_Form_Exit = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX_ChonFile = New DevComponents.DotNetBar.ButtonX()
        Me.txtcodename = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cboNhom = New System.Windows.Forms.ComboBox()
        Me.txttinhnang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txttenfile = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtghichu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.BtnAdd = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnModify = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnExport_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Refresh = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_LuuThayDoi = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_ChonThuMuc = New DevComponents.DotNetBar.ButtonItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.RichTextBoxEx_Folder_Path_00 = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1.SuspendLayout()
        Me.GP_Form_Folder_Path.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GP_Form.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GP_Form_Folder_Path)
        Me.Panel1.Controls.Add(Me.GP_Form)
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1035, 577)
        Me.Panel1.TabIndex = 430
        '
        'GP_Form_Folder_Path
        '
        Me.GP_Form_Folder_Path.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form_Folder_Path.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form_Folder_Path.Controls.Add(Me.TableLayoutPanel2)
        Me.GP_Form_Folder_Path.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form_Folder_Path.Location = New System.Drawing.Point(10, 361)
        Me.GP_Form_Folder_Path.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form_Folder_Path.Name = "GP_Form_Folder_Path"
        Me.GP_Form_Folder_Path.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form_Folder_Path.Size = New System.Drawing.Size(529, 176)
        '
        '
        '
        Me.GP_Form_Folder_Path.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GP_Form_Folder_Path.Style.BackColorGradientAngle = 90
        Me.GP_Form_Folder_Path.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GP_Form_Folder_Path.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_Folder_Path.Style.BorderBottomWidth = 1
        Me.GP_Form_Folder_Path.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GP_Form_Folder_Path.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_Folder_Path.Style.BorderLeftWidth = 1
        Me.GP_Form_Folder_Path.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_Folder_Path.Style.BorderRightWidth = 1
        Me.GP_Form_Folder_Path.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GP_Form_Folder_Path.Style.BorderTopWidth = 1
        Me.GP_Form_Folder_Path.Style.CornerDiameter = 4
        Me.GP_Form_Folder_Path.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GP_Form_Folder_Path.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GP_Form_Folder_Path.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GP_Form_Folder_Path.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GP_Form_Folder_Path.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GP_Form_Folder_Path.TabIndex = 455
        Me.GP_Form_Folder_Path.Text = "Đường Dẫn"
        Me.GP_Form_Folder_Path.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form_Folder_Path.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBoxX_LocalNetwork, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonX_Browser_Path, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnHidden_Panel_Folder_Path, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBoxEx_Folder_Path, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnFolder_Path_Save, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(499, 150)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'CheckBoxX_LocalNetwork
        '
        Me.CheckBoxX_LocalNetwork.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheckBoxX_LocalNetwork.AutoSize = True
        '
        '
        '
        Me.CheckBoxX_LocalNetwork.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX_LocalNetwork.CheckSignSize = New System.Drawing.Size(25, 25)
        Me.CheckBoxX_LocalNetwork.Location = New System.Drawing.Point(3, 104)
        Me.CheckBoxX_LocalNetwork.Name = "CheckBoxX_LocalNetwork"
        Me.CheckBoxX_LocalNetwork.Size = New System.Drawing.Size(90, 27)
        Me.CheckBoxX_LocalNetwork.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX_LocalNetwork.TabIndex = 418
        Me.CheckBoxX_LocalNetwork.Text = "Network"
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(3, 34)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(96, 24)
        Me.LabelX6.TabIndex = 416
        Me.LabelX6.Text = "Đường Dẫn:"
        '
        'ButtonX_Browser_Path
        '
        Me.ButtonX_Browser_Path.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX_Browser_Path.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX_Browser_Path.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX_Browser_Path.Location = New System.Drawing.Point(105, 96)
        Me.ButtonX_Browser_Path.Name = "ButtonX_Browser_Path"
        Me.ButtonX_Browser_Path.Size = New System.Drawing.Size(119, 43)
        Me.ButtonX_Browser_Path.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX_Browser_Path.TabIndex = 417
        Me.ButtonX_Browser_Path.Text = "..."
        '
        'BtnHidden_Panel_Folder_Path
        '
        Me.BtnHidden_Panel_Folder_Path.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHidden_Panel_Folder_Path.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHidden_Panel_Folder_Path.Image = Global.WindowsApplication1.My.Resources.Resources._Exit
        Me.BtnHidden_Panel_Folder_Path.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHidden_Panel_Folder_Path.Location = New System.Drawing.Point(385, 98)
        Me.BtnHidden_Panel_Folder_Path.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnHidden_Panel_Folder_Path.Name = "BtnHidden_Panel_Folder_Path"
        Me.BtnHidden_Panel_Folder_Path.Size = New System.Drawing.Size(109, 39)
        Me.BtnHidden_Panel_Folder_Path.TabIndex = 454
        Me.BtnHidden_Panel_Folder_Path.Text = "Thoát"
        Me.BtnHidden_Panel_Folder_Path.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHidden_Panel_Folder_Path.UseVisualStyleBackColor = True
        '
        'RichTextBoxEx_Folder_Path
        '
        Me.RichTextBoxEx_Folder_Path.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.RichTextBoxEx_Folder_Path.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.RichTextBoxEx_Folder_Path.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel2.SetColumnSpan(Me.RichTextBoxEx_Folder_Path, 3)
        Me.RichTextBoxEx_Folder_Path.DetectUrls = False
        Me.RichTextBoxEx_Folder_Path.Location = New System.Drawing.Point(105, 3)
        Me.RichTextBoxEx_Folder_Path.Name = "RichTextBoxEx_Folder_Path"
        Me.RichTextBoxEx_Folder_Path.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 " &
    "Times New Roman;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\*\generator Riched20 10.0.19041}\viewkind4\uc1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\pard\f0\" &
    "fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBoxEx_Folder_Path.Size = New System.Drawing.Size(391, 87)
        Me.RichTextBoxEx_Folder_Path.TabIndex = 455
        '
        'BtnFolder_Path_Save
        '
        Me.BtnFolder_Path_Save.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFolder_Path_Save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFolder_Path_Save.Image = CType(resources.GetObject("BtnFolder_Path_Save.Image"), System.Drawing.Image)
        Me.BtnFolder_Path_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFolder_Path_Save.Location = New System.Drawing.Point(231, 96)
        Me.BtnFolder_Path_Save.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnFolder_Path_Save.Name = "BtnFolder_Path_Save"
        Me.BtnFolder_Path_Save.Size = New System.Drawing.Size(145, 43)
        Me.BtnFolder_Path_Save.TabIndex = 453
        Me.BtnFolder_Path_Save.Text = "Cập Nhật"
        Me.BtnFolder_Path_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFolder_Path_Save.UseVisualStyleBackColor = True
        '
        'GP_Form
        '
        Me.GP_Form.CanvasColor = System.Drawing.SystemColors.Control
        Me.GP_Form.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GP_Form.Controls.Add(Me.TableLayoutPanel1)
        Me.GP_Form.DisabledBackColor = System.Drawing.Color.Empty
        Me.GP_Form.Location = New System.Drawing.Point(438, 4)
        Me.GP_Form.Margin = New System.Windows.Forms.Padding(2)
        Me.GP_Form.Name = "GP_Form"
        Me.GP_Form.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
        Me.GP_Form.Size = New System.Drawing.Size(490, 340)
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
        Me.GP_Form.TabIndex = 447
        Me.GP_Form.Text = "GroupPanel1"
        Me.GP_Form.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Right
        Me.GP_Form.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonX_GP_Form_Exit, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cboNhom, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txttinhnang, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txttenfile, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichu, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSave, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtcodename, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonX_ChonFile, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBoxEx_Folder_Path_00, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX7, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(460, 314)
        Me.TableLayoutPanel1.TabIndex = 416
        '
        'ButtonX_GP_Form_Exit
        '
        Me.ButtonX_GP_Form_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX_GP_Form_Exit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX_GP_Form_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.TableLayoutPanel1.SetColumnSpan(Me.ButtonX_GP_Form_Exit, 2)
        Me.ButtonX_GP_Form_Exit.Location = New System.Drawing.Point(308, 243)
        Me.ButtonX_GP_Form_Exit.Name = "ButtonX_GP_Form_Exit"
        Me.ButtonX_GP_Form_Exit.Size = New System.Drawing.Size(141, 54)
        Me.ButtonX_GP_Form_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX_GP_Form_Exit.Symbol = ""
        Me.ButtonX_GP_Form_Exit.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonX_GP_Form_Exit.TabIndex = 448
        Me.ButtonX_GP_Form_Exit.Text = "Thoát"
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(3, 6)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(76, 20)
        Me.LabelX3.TabIndex = 416
        Me.LabelX3.Text = "Chọn Form"
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 38)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(71, 20)
        Me.LabelX1.TabIndex = 294
        Me.LabelX1.Text = "Tính Năng"
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, 102)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(56, 20)
        Me.LabelX4.TabIndex = 417
        Me.LabelX4.Text = "Tên File"
        '
        'ButtonX_ChonFile
        '
        Me.ButtonX_ChonFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX_ChonFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX_ChonFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX_ChonFile.Location = New System.Drawing.Point(407, 99)
        Me.ButtonX_ChonFile.Name = "ButtonX_ChonFile"
        Me.ButtonX_ChonFile.Size = New System.Drawing.Size(42, 26)
        Me.ButtonX_ChonFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX_ChonFile.TabIndex = 416
        Me.ButtonX_ChonFile.Text = "..."
        '
        'txtcodename
        '
        Me.txtcodename.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcodename.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.txtcodename.Border.Class = "TextBoxBorder"
        Me.txtcodename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtcodename, 2)
        Me.txtcodename.FocusHighlightEnabled = True
        Me.txtcodename.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtcodename.Location = New System.Drawing.Point(90, 67)
        Me.txtcodename.Name = "txtcodename"
        Me.txtcodename.Size = New System.Drawing.Size(311, 26)
        Me.txtcodename.TabIndex = 416
        Me.txtcodename.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 214)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(57, 20)
        Me.LabelX2.TabIndex = 295
        Me.LabelX2.Text = "Ghi Chú"
        '
        'cboNhom
        '
        Me.cboNhom.AllowDrop = True
        Me.cboNhom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNhom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboNhom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cboNhom, 2)
        Me.cboNhom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNhom.ForeColor = System.Drawing.Color.Black
        Me.cboNhom.FormattingEnabled = True
        Me.cboNhom.Items.AddRange(New Object() {"1 DÂY", "2 DÂY"})
        Me.cboNhom.Location = New System.Drawing.Point(90, 3)
        Me.cboNhom.Name = "cboNhom"
        Me.cboNhom.Size = New System.Drawing.Size(311, 27)
        Me.cboNhom.Sorted = True
        Me.cboNhom.TabIndex = 461
        '
        'txttinhnang
        '
        Me.txttinhnang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txttinhnang.Border.Class = "TextBoxBorder"
        Me.txttinhnang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txttinhnang, 2)
        Me.txttinhnang.FocusHighlightEnabled = True
        Me.txttinhnang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txttinhnang.Location = New System.Drawing.Point(90, 35)
        Me.txttinhnang.Name = "txttinhnang"
        Me.txttinhnang.Size = New System.Drawing.Size(311, 26)
        Me.txttinhnang.TabIndex = 416
        Me.txttinhnang.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txttenfile
        '
        Me.txttenfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txttenfile.Border.Class = "TextBoxBorder"
        Me.txttenfile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.txttenfile, 2)
        Me.txttenfile.FocusHighlightEnabled = True
        Me.txttenfile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txttenfile.Location = New System.Drawing.Point(90, 99)
        Me.txttenfile.Name = "txttenfile"
        Me.txttenfile.Size = New System.Drawing.Size(311, 26)
        Me.txttenfile.TabIndex = 225
        Me.txttenfile.WatermarkFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtghichu.FocusHighlightEnabled = True
        Me.txtghichu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtghichu.Location = New System.Drawing.Point(90, 211)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(311, 26)
        Me.txtghichu.TabIndex = 293
        Me.txtghichu.WatermarkFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Location = New System.Drawing.Point(90, 243)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(212, 54)
        Me.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSave.Symbol = ""
        Me.BtnSave.TabIndex = 296
        Me.BtnSave.Text = "Lưu Lại"
        '
        'Super_Dgv
        '
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Thickness3.Bottom = 1
        Thickness3.Left = 1
        Thickness3.Right = 1
        Thickness3.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.BorderThickness = Thickness3
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.Super_Dgv.DefaultVisualStyles.CaptionStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.Bottom
        Me.Super_Dgv.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Thickness4.Bottom = 1
        Thickness4.Left = 1
        Thickness4.Right = 1
        Thickness4.Top = 1
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.BorderThickness = Thickness4
        Me.Super_Dgv.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Background2.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Super_Dgv.DefaultVisualStyles.FilterRowStyles.Default.FilterBackground = Background2
        Me.Super_Dgv.DefaultVisualStyles.GridPanelStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.GroupByStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square
        Me.Super_Dgv.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Super_Dgv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Super_Dgv.Location = New System.Drawing.Point(70, 27)
        Me.Super_Dgv.Name = "Super_Dgv"
        '
        '
        '
        Me.Super_Dgv.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.Both
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
        BorderColor2.Bottom = System.Drawing.Color.Black
        BorderColor2.Left = System.Drawing.Color.Black
        BorderColor2.Right = System.Drawing.Color.Black
        BorderColor2.Top = System.Drawing.Color.Black
        Me.Super_Dgv.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.BorderColor = BorderColor2
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
        Me.Super_Dgv.Size = New System.Drawing.Size(157, 128)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 415
        '
        'ItemPanel1
        '
        Me.ItemPanel1.BackColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.ItemPanel1.BackgroundStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ItemPanel1.BackgroundStyle.Class = "ItemPanel"
        Me.ItemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemPanel1.ContainerControlProcessDialogKey = True
        Me.ItemPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ItemPanel1.DragDropSupport = True
        Me.ItemPanel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnAdd, Me.BtnModify, Me.BtnDelete, Me.BtnExport_Excel, Me.ButtonItem_Refresh, Me.ButtonItem_LuuThayDoi, Me.ButtonItem_ChonThuMuc})
        Me.ItemPanel1.ItemSpacing = 5
        Me.ItemPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(1035, 34)
        Me.ItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ItemPanel1.TabIndex = 438
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'BtnAdd
        '
        Me.BtnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Symbol = "57404"
        Me.BtnAdd.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.BtnAdd.Text = "Thêm Mới"
        '
        'BtnModify
        '
        Me.BtnModify.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Symbol = ""
        Me.BtnModify.Text = "Chỉnh Sửa"
        '
        'BtnDelete
        '
        Me.BtnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Symbol = ""
        Me.BtnDelete.Text = "Xóa"
        '
        'BtnExport_Excel
        '
        Me.BtnExport_Excel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnExport_Excel.Name = "BtnExport_Excel"
        Me.BtnExport_Excel.Symbol = ""
        Me.BtnExport_Excel.Text = "Xuất Excel"
        '
        'ButtonItem_Refresh
        '
        Me.ButtonItem_Refresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_Refresh.Name = "ButtonItem_Refresh"
        Me.ButtonItem_Refresh.Symbol = ""
        Me.ButtonItem_Refresh.Text = "Làm Mới"
        '
        'ButtonItem_LuuThayDoi
        '
        Me.ButtonItem_LuuThayDoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_LuuThayDoi.Name = "ButtonItem_LuuThayDoi"
        Me.ButtonItem_LuuThayDoi.Symbol = ""
        Me.ButtonItem_LuuThayDoi.Text = "Lưu Thay Đổi"
        '
        'ButtonItem_ChonThuMuc
        '
        Me.ButtonItem_ChonThuMuc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_ChonThuMuc.Name = "ButtonItem_ChonThuMuc"
        Me.ButtonItem_ChonThuMuc.Symbol = ""
        Me.ButtonItem_ChonThuMuc.Text = "Chọn Thư Mục"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(3, 70)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(49, 20)
        Me.LabelX5.TabIndex = 456
        Me.LabelX5.Text = "Mã ID:"
        '
        'RichTextBoxEx_Folder_Path_00
        '
        Me.RichTextBoxEx_Folder_Path_00.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.RichTextBoxEx_Folder_Path_00.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.RichTextBoxEx_Folder_Path_00.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel1.SetColumnSpan(Me.RichTextBoxEx_Folder_Path_00, 2)
        Me.RichTextBoxEx_Folder_Path_00.DetectUrls = False
        Me.RichTextBoxEx_Folder_Path_00.Location = New System.Drawing.Point(90, 131)
        Me.RichTextBoxEx_Folder_Path_00.Name = "RichTextBoxEx_Folder_Path_00"
        Me.RichTextBoxEx_Folder_Path_00.ReadOnly = True
        Me.RichTextBoxEx_Folder_Path_00.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 " &
    "Times New Roman;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\*\generator Riched20 10.0.19041}\viewkind4\uc1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\pard\f0\" &
    "fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBoxEx_Folder_Path_00.Size = New System.Drawing.Size(311, 74)
        Me.RichTextBoxEx_Folder_Path_00.TabIndex = 462
        '
        'LabelX7
        '
        Me.LabelX7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(3, 158)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(82, 20)
        Me.LabelX7.TabIndex = 463
        Me.LabelX7.Text = "Đường Dẫn:"
        '
        'List_CauHinh_Excel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1035, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "List_CauHinh_Excel"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List_CauHinh_Excel"
        Me.Panel1.ResumeLayout(False)
        Me.GP_Form_Folder_Path.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GP_Form.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtghichu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txttenfile As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents BtnAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnModify As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnDelete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnExport_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txttinhnang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboNhom As ComboBox
    Friend WithEvents ButtonX_ChonFile As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ButtonItem_Refresh As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX_Browser_Path As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents txtcodename As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GP_Form As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX_GP_Form_Exit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CheckBoxX_LocalNetwork As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonItem_LuuThayDoi As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GP_Form_Folder_Path As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnHidden_Panel_Folder_Path As Button
    Friend WithEvents RichTextBoxEx_Folder_Path As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents BtnFolder_Path_Save As Button
    Friend WithEvents ButtonItem_ChonThuMuc As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RichTextBoxEx_Folder_Path_00 As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
End Class
