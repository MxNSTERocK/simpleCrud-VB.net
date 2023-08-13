<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chckShowHide = New System.Windows.Forms.CheckBox()
        Me.txtDentist_Names = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1s = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lnklblContactno = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lnklblFacebook = New System.Windows.Forms.LinkLabel()
        Me.pbTooth = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Chip1 = New Guna.UI2.WinForms.Guna2Chip()
        Me.lblTimein = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbTooth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(689, 345)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 13)
        Me.lblTimer.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(88, 234)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(214, 20)
        Me.txtPassword.TabIndex = 1
        '
        'chckShowHide
        '
        Me.chckShowHide.AutoSize = True
        Me.chckShowHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckShowHide.Location = New System.Drawing.Point(88, 260)
        Me.chckShowHide.Name = "chckShowHide"
        Me.chckShowHide.Size = New System.Drawing.Size(114, 16)
        Me.chckShowHide.TabIndex = 6
        Me.chckShowHide.Text = "Show/Hide Password"
        Me.chckShowHide.UseVisualStyleBackColor = True
        '
        'txtDentist_Names
        '
        Me.txtDentist_Names.BackColor = System.Drawing.Color.White
        Me.txtDentist_Names.Location = New System.Drawing.Point(88, 190)
        Me.txtDentist_Names.Name = "txtDentist_Names"
        Me.txtDentist_Names.Size = New System.Drawing.Size(214, 20)
        Me.txtDentist_Names.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'ProgressBar1s
        '
        Me.ProgressBar1s.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProgressBar1s.Location = New System.Drawing.Point(88, 347)
        Me.ProgressBar1s.Name = "ProgressBar1s"
        Me.ProgressBar1s.Size = New System.Drawing.Size(214, 18)
        Me.ProgressBar1s.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dentist name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Register"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.lblTimein)
        Me.Panel2.Controls.Add(Me.Guna2Chip1)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtDentist_Names)
        Me.Panel2.Controls.Add(Me.ProgressBar1s)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.chckShowHide)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Location = New System.Drawing.Point(418, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 400)
        Me.Panel2.TabIndex = 11
        '
        'btnCancel
        '
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(222, 300)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(80, 33)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        '
        'btnLogin
        '
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(88, 300)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(80, 33)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "Log in"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Dental_Clinic_Management.My.Resources.Resources.kaway
        Me.PictureBox1.Location = New System.Drawing.Point(88, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lnklblContactno)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lnklblFacebook)
        Me.Panel1.Controls.Add(Me.pbTooth)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(15, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 400)
        Me.Panel1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(149, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "(36) 486-123"
        '
        'lnklblContactno
        '
        Me.lnklblContactno.AutoSize = True
        Me.lnklblContactno.Location = New System.Drawing.Point(152, 319)
        Me.lnklblContactno.Name = "lnklblContactno"
        Me.lnklblContactno.Size = New System.Drawing.Size(64, 13)
        Me.lnklblContactno.TabIndex = 17
        Me.lnklblContactno.Text = "Contact No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(152, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Facebook"
        '
        'lnklblFacebook
        '
        Me.lnklblFacebook.AutoSize = True
        Me.lnklblFacebook.Location = New System.Drawing.Point(99, 290)
        Me.lnklblFacebook.Name = "lnklblFacebook"
        Me.lnklblFacebook.Size = New System.Drawing.Size(167, 13)
        Me.lnklblFacebook.TabIndex = 15
        Me.lnklblFacebook.TabStop = True
        Me.lnklblFacebook.Text = "www.Facebook.com/DentalHook"
        '
        'pbTooth
        '
        Me.pbTooth.BackColor = System.Drawing.Color.Transparent
        Me.pbTooth.Image = Global.Dental_Clinic_Management.My.Resources.Resources.flogo
        Me.pbTooth.Location = New System.Drawing.Point(68, 88)
        Me.pbTooth.Name = "pbTooth"
        Me.pbTooth.Size = New System.Drawing.Size(233, 175)
        Me.pbTooth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTooth.TabIndex = 14
        Me.pbTooth.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(99, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Dental Hook"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(97, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "your teeth your tooth"
        '
        'Guna2Chip1
        '
        Me.Guna2Chip1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Chip1.FillColor = System.Drawing.Color.LightSkyBlue
        Me.Guna2Chip1.ForeColor = System.Drawing.Color.White
        Me.Guna2Chip1.Location = New System.Drawing.Point(252, 0)
        Me.Guna2Chip1.Name = "Guna2Chip1"
        Me.Guna2Chip1.ShadowDecoration.Parent = Me.Guna2Chip1
        Me.Guna2Chip1.Size = New System.Drawing.Size(131, 23)
        Me.Guna2Chip1.TabIndex = 14
        '
        'lblTimein
        '
        Me.lblTimein.AutoSize = True
        Me.lblTimein.BackColor = System.Drawing.Color.Transparent
        Me.lblTimein.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTimein.Location = New System.Drawing.Point(258, 6)
        Me.lblTimein.Name = "lblTimein"
        Me.lblTimein.Size = New System.Drawing.Size(0, 13)
        Me.lblTimein.TabIndex = 15
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dental_Clinic_Management.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(816, 430)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbTooth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chckShowHide As CheckBox
    Friend WithEvents txtDentist_Names As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1s As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pbTooth As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lnklblContactno As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lnklblFacebook As LinkLabel
    Friend WithEvents lblTimein As Label
    Friend WithEvents Guna2Chip1 As Guna.UI2.WinForms.Guna2Chip
End Class
