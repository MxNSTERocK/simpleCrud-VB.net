<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPatient = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnPreview = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnInsert = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnClear = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnReport = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSetting = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnRecord = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 29)
        Me.Panel2.TabIndex = 1
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(410, 1)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(190, 22)
        Me.Guna2DateTimePicker1.TabIndex = 34
        Me.Guna2DateTimePicker1.Value = New Date(2021, 1, 25, 0, 6, 2, 356)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem2.Text = "Add New Record"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem3.Text = "Save Record"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem4.Text = "Delete Record"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(208, 44)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(419, 21)
        Me.txtSearch.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(630, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Patient Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(630, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(630, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(630, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Lastname"
        '
        'txtPatient
        '
        Me.txtPatient.Enabled = False
        Me.txtPatient.Location = New System.Drawing.Point(633, 98)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.Size = New System.Drawing.Size(155, 20)
        Me.txtPatient.TabIndex = 16
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(633, 134)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(155, 20)
        Me.txtFirstname.TabIndex = 17
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(633, 171)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(155, 20)
        Me.txtLastname.TabIndex = 18
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(633, 208)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(155, 20)
        Me.txtAddress.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.Name = Nothing
        Me.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(206, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(421, 338)
        Me.DataGridView1.TabIndex = 20
        Me.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(200, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(600, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel1.Text = "Logged as in"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'btnPreview
        '
        Me.btnPreview.CheckedState.Parent = Me.btnPreview
        Me.btnPreview.CustomImages.Parent = Me.btnPreview
        Me.btnPreview.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnPreview.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnPreview.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.HoverState.Parent = Me.btnPreview
        Me.btnPreview.Location = New System.Drawing.Point(711, 244)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.ShadowDecoration.Parent = Me.btnPreview
        Me.btnPreview.Size = New System.Drawing.Size(74, 32)
        Me.btnPreview.TabIndex = 33
        Me.btnPreview.Text = "Preview"
        '
        'btnInsert
        '
        Me.btnInsert.CheckedState.Parent = Me.btnInsert
        Me.btnInsert.CustomImages.Parent = Me.btnInsert
        Me.btnInsert.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnInsert.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnInsert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.HoverState.Parent = Me.btnInsert
        Me.btnInsert.Location = New System.Drawing.Point(636, 352)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.ShadowDecoration.Parent = Me.btnInsert
        Me.btnInsert.Size = New System.Drawing.Size(152, 30)
        Me.btnInsert.TabIndex = 27
        Me.btnInsert.Text = "Insert"
        '
        'btnUpdate
        '
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnUpdate.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Location = New System.Drawing.Point(636, 388)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(152, 30)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnDelete.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(636, 316)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(152, 30)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete"
        '
        'btnClear
        '
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(636, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(149, 30)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        '
        'btnReport
        '
        Me.btnReport.CheckedState.Parent = Me.btnReport
        Me.btnReport.CustomImages.Parent = Me.btnReport
        Me.btnReport.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnReport.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.HoverState.Parent = Me.btnReport
        Me.btnReport.Location = New System.Drawing.Point(636, 244)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.ShadowDecoration.Parent = Me.btnReport
        Me.btnReport.Size = New System.Drawing.Size(73, 32)
        Me.btnReport.TabIndex = 31
        Me.btnReport.Text = "Report"
        '
        'btnSearch
        '
        Me.btnSearch.CheckedState.Parent = Me.btnSearch
        Me.btnSearch.CustomImages.Parent = Me.btnSearch
        Me.btnSearch.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.HoverState.Parent = Me.btnSearch
        Me.btnSearch.Location = New System.Drawing.Point(645, 35)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(143, 34)
        Me.btnSearch.TabIndex = 32
        Me.btnSearch.Text = "Search"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSetting)
        Me.Panel1.Controls.Add(Me.btnHistory)
        Me.Panel1.Controls.Add(Me.btnRecord)
        Me.Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 450)
        Me.Panel1.TabIndex = 0
        '
        'btnSetting
        '
        Me.btnSetting.CheckedState.Parent = Me.btnSetting
        Me.btnSetting.CustomImages.Parent = Me.btnSetting
        Me.btnSetting.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnSetting.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnSetting.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSetting.ForeColor = System.Drawing.Color.White
        Me.btnSetting.HoverState.Parent = Me.btnSetting
        Me.btnSetting.Location = New System.Drawing.Point(0, 339)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.ShadowDecoration.Parent = Me.btnSetting
        Me.btnSetting.Size = New System.Drawing.Size(200, 53)
        Me.btnSetting.TabIndex = 36
        Me.btnSetting.Text = "SETTING"
        '
        'btnHistory
        '
        Me.btnHistory.CheckedState.Parent = Me.btnHistory
        Me.btnHistory.CustomImages.Parent = Me.btnHistory
        Me.btnHistory.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnHistory.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.HoverState.Parent = Me.btnHistory
        Me.btnHistory.Location = New System.Drawing.Point(0, 219)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.ShadowDecoration.Parent = Me.btnHistory
        Me.btnHistory.Size = New System.Drawing.Size(200, 53)
        Me.btnHistory.TabIndex = 35
        Me.btnHistory.Text = "HISTORY"
        '
        'btnRecord
        '
        Me.btnRecord.CheckedState.Parent = Me.btnRecord
        Me.btnRecord.CustomImages.Parent = Me.btnRecord
        Me.btnRecord.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnRecord.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.btnRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRecord.ForeColor = System.Drawing.Color.White
        Me.btnRecord.HoverState.Parent = Me.btnRecord
        Me.btnRecord.Location = New System.Drawing.Point(0, 160)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.ShadowDecoration.Parent = Me.btnRecord
        Me.btnRecord.Size = New System.Drawing.Size(200, 53)
        Me.btnRecord.TabIndex = 34
        Me.btnRecord.Text = "RECORD"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.Dental_Clinic_Management.My.Resources.Resources.person_Flat
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(152, 132)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 1
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 154)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtPatient)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmHome"
        Me.Text = "frmHome"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPatient As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents DataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents btnInsert As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnReport As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPreview As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSetting As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnRecord As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
