<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_May
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
        Dim Thickness1 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Thickness2 As DevComponents.DotNetBar.SuperGrid.Style.Thickness = New DevComponents.DotNetBar.SuperGrid.Style.Thickness()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim BorderColor1 As DevComponents.DotNetBar.SuperGrid.Style.BorderColor = New DevComponents.DotNetBar.SuperGrid.Style.BorderColor()
        Me.txtghichu_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txttenmay_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtmamay_F = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Super_Dgv = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ContextMenu_Mamay = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.context_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Context_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Context_Modify = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Context_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.XuấtExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.BtnAdd = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnModify = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnExport_Excel = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnPrint_Barcode = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnDiable = New DevComponents.DotNetBar.ButtonItem()
        Me.BtnEnable = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem_Nhom = New DevComponents.DotNetBar.ButtonItem()
        Me.Panel1.SuspendLayout()
        Me.ContextMenu_Mamay.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtghichu_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtghichu_F.Location = New System.Drawing.Point(243, 3)
        Me.txtghichu_F.Name = "txtghichu_F"
        Me.txtghichu_F.Size = New System.Drawing.Size(114, 26)
        Me.txtghichu_F.TabIndex = 293
        Me.txtghichu_F.WatermarkFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu_F.WatermarkText = "Ghi chú"
        '
        'txttenmay_F
        '
        Me.txttenmay_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txttenmay_F.Border.Class = "TextBoxBorder"
        Me.txttenmay_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttenmay_F.FocusHighlightEnabled = True
        Me.txttenmay_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txttenmay_F.Location = New System.Drawing.Point(123, 3)
        Me.txttenmay_F.Name = "txttenmay_F"
        Me.txttenmay_F.Size = New System.Drawing.Size(114, 26)
        Me.txttenmay_F.TabIndex = 291
        Me.txttenmay_F.WatermarkFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenmay_F.WatermarkText = "Tên Máy"
        '
        'txtmamay_F
        '
        Me.txtmamay_F.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtmamay_F.Border.Class = "TextBoxBorder"
        Me.txtmamay_F.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmamay_F.FocusHighlightEnabled = True
        Me.txtmamay_F.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtmamay_F.Location = New System.Drawing.Point(3, 3)
        Me.txtmamay_F.Name = "txtmamay_F"
        Me.txtmamay_F.Size = New System.Drawing.Size(114, 26)
        Me.txtmamay_F.TabIndex = 225
        Me.txtmamay_F.WatermarkFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamay_F.WatermarkText = "Mã Máy"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Super_Dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 534)
        Me.Panel1.TabIndex = 409
        '
        'Super_Dgv
        '
        Me.Super_Dgv.ContextMenuStrip = Me.ContextMenu_Mamay
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
        Me.Super_Dgv.Location = New System.Drawing.Point(183, 122)
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
        Me.Super_Dgv.Size = New System.Drawing.Size(244, 136)
        Me.Super_Dgv.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.[ReadOnly]
        Me.Super_Dgv.TabIndex = 418
        '
        'ContextMenu_Mamay
        '
        Me.ContextMenu_Mamay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenu_Mamay.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenu_Mamay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.context_Add, Me.ToolStripSeparator6, Me.Context_Copy, Me.ToolStripSeparator7, Me.Context_Modify, Me.ToolStripSeparator8, Me.Context_Delete, Me.ToolStripSeparator9, Me.XuấtExcelToolStripMenuItem})
        Me.ContextMenu_Mamay.Name = "ContextMenuStrip1"
        Me.ContextMenu_Mamay.Size = New System.Drawing.Size(177, 178)
        '
        'context_Add
        '
        Me.context_Add.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.context_Add.Name = "context_Add"
        Me.context_Add.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.context_Add.Size = New System.Drawing.Size(176, 30)
        Me.context_Add.Text = "Thêm Mới"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(173, 6)
        '
        'Context_Copy
        '
        Me.Context_Copy.Image = Global.WindowsApplication1.My.Resources.Resources.mail_forward
        Me.Context_Copy.Name = "Context_Copy"
        Me.Context_Copy.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.Context_Copy.Size = New System.Drawing.Size(176, 30)
        Me.Context_Copy.Text = "Sao Chép"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(173, 6)
        '
        'Context_Modify
        '
        Me.Context_Modify.Image = Global.WindowsApplication1.My.Resources.Resources.note_edit
        Me.Context_Modify.Name = "Context_Modify"
        Me.Context_Modify.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.Context_Modify.Size = New System.Drawing.Size(176, 30)
        Me.Context_Modify.Text = "Chỉnh Sửa"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(173, 6)
        '
        'Context_Delete
        '
        Me.Context_Delete.Image = Global.WindowsApplication1.My.Resources.Resources.remove
        Me.Context_Delete.Name = "Context_Delete"
        Me.Context_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.Context_Delete.Size = New System.Drawing.Size(176, 30)
        Me.Context_Delete.Text = "Xoá"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(173, 6)
        '
        'XuấtExcelToolStripMenuItem
        '
        Me.XuấtExcelToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.report
        Me.XuấtExcelToolStripMenuItem.Name = "XuấtExcelToolStripMenuItem"
        Me.XuấtExcelToolStripMenuItem.Size = New System.Drawing.Size(176, 30)
        Me.XuấtExcelToolStripMenuItem.Text = "Xuất Excel"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtghichu_F, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtmamay_F, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txttenmay_F, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 568)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1048, 38)
        Me.TableLayoutPanel1.TabIndex = 440
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
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnAdd, Me.BtnModify, Me.BtnDelete, Me.BtnExport_Excel, Me.BtnPrint_Barcode, Me.ButtonItem_Nhom})
        Me.ItemPanel1.ItemSpacing = 5
        Me.ItemPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(1048, 34)
        Me.ItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ItemPanel1.TabIndex = 441
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
        'BtnPrint_Barcode
        '
        Me.BtnPrint_Barcode.AutoExpandOnClick = True
        Me.BtnPrint_Barcode.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BtnPrint_Barcode.Name = "BtnPrint_Barcode"
        Me.BtnPrint_Barcode.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnDiable, Me.BtnEnable})
        Me.BtnPrint_Barcode.Symbol = ""
        Me.BtnPrint_Barcode.Text = "Tính Năng"
        '
        'BtnDiable
        '
        Me.BtnDiable.Name = "BtnDiable"
        Me.BtnDiable.Text = "Không Sử Dụng"
        '
        'BtnEnable
        '
        Me.BtnEnable.Name = "BtnEnable"
        Me.BtnEnable.Text = "Sử Dụng"
        '
        'ButtonItem_Nhom
        '
        Me.ButtonItem_Nhom.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem_Nhom.Name = "ButtonItem_Nhom"
        Me.ButtonItem_Nhom.Symbol = ""
        Me.ButtonItem_Nhom.Text = "Nhóm"
        '
        'List_May
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1048, 606)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "List_May"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh Sách Máy"
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenu_Mamay.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txttenmay_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtmamay_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtghichu_F As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Super_Dgv As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ContextMenu_Mamay As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents context_Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Context_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Context_Modify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Context_Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents XuấtExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents BtnAdd As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnModify As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnDelete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnExport_Excel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnPrint_Barcode As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnDiable As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BtnEnable As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem_Nhom As DevComponents.DotNetBar.ButtonItem
End Class
