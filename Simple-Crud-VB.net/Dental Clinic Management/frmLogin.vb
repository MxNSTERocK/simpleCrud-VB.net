Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        lblTimein.Text = Now()
    End Sub
    Private Sub chckShowHide_CheckedChanged(sender As Object, e As EventArgs) Handles chckShowHide.CheckedChanged
        If chckShowHide.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1s.Click
        If ProgressBar1s.Value = ProgressBar1s.Maximum Then
            Timer1.Stop()
            Me.Hide()
            frmHome.Show()
            lblTimer.Text = "Idle"
        End If
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Len(Trim(txtDentist_Names.Text)) = 0 And Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please Enter your Name and Password", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDentist_Names.Focus()
            Exit Sub
        ElseIf Len(Trim(txtDentist_Names.Text)) = 0 Then
            MessageBox.Show("Please Enter your Name", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDentist_Names.Focus()
            Exit Sub
        ElseIf Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please Enter your Password", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub

        End If
        Dim Cnn As New MySqlConnection("Server = Localhost; User = root; Password = ; Database = Dental Clinic Management")


        Dim logincommand As New MySqlCommand
        Dim LoginDataReader As MySqlDataReader

        logincommand.Connection = Cnn
        logincommand.CommandText = "SELECT * FROM tblDentist WHERE Dentist_Name = @Dentist_Name and Password = @Password"

        logincommand.Parameters.AddWithValue("@Dentist_name", txtDentist_Names.Text)
        logincommand.Parameters.AddWithValue("@Password", txtPassword.Text)
        Cnn.Open()
        LoginDataReader = logincommand.ExecuteReader()

        If (LoginDataReader.HasRows = True) Then

            ProgressBar1s.Visible = True
            ProgressBar1s.Maximum = 5000
            ProgressBar1s.Minimum = 0
            ProgressBar1s.Value = 1
            ProgressBar1s.Step = 1

            For i = 0 To 5000
                ProgressBar1s.PerformStep()
            Next
            MessageBox.Show("Login Successful", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmHome.StatusStrip1.Text = Me.txtDentist_Names.Text
            frmHome.Show()
            Me.Hide()
            ProgressBar1s.Value = 4
            txtDentist_Names.Clear()
            txtPassword.Clear()

            Cnn.Close()
            Cnn.Dispose()
            Cnn = Nothing
        Else
            MessageBox.Show("Invalid Username or Password" & vbCrLf & "Please Try Again", "Invalid Input", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtDentist_Names.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ProgressBar1_ProgressChanged(sender As Object, e As EventArgs)

    End Sub
End Class
