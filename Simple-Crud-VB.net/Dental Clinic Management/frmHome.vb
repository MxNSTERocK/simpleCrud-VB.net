Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmHome
    Dim mode As String
    Dim cnn As New MySqlConnection("Server = Localhost; User = root; Password = ; Database = Dental Clinic Management")
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String

    Private Sub Refreshdatagrid()
        Try
            cnn.Open()
        Catch exError As Exception
            MessageBox.Show(exError.Message, "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If cnn.State <> ConnectionState.Open Then
            MessageBox.Show("Database Connection is Failed")
            Exit Sub
        End If
        cnn.Close()

        Dim DisplayPersonCommand As New MySqlCommand
        Dim PersonDataAdapter As New MySqlDataAdapter
        Dim PersonDT As New DataTable

        DisplayPersonCommand.Connection = cnn
        DisplayPersonCommand.CommandText = "SELECT * FROM tblPerson"

        PersonDataAdapter.SelectCommand = DisplayPersonCommand
        PersonDataAdapter.Fill(PersonDT)

        DataGridView1.DataSource = PersonDT
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoResizeColumns()
        DataGridView1.AllowUserToAddRows = False


        Me.txtPatient.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Me.txtFirstname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Me.txtLastname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Me.txtAddress.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString

        PersonDataAdapter.Dispose()
        PersonDataAdapter = Nothing
        DisplayPersonCommand.Dispose()
        DisplayPersonCommand = Nothing
        PersonDT.Dispose()
        PersonDT = Nothing
    End Sub
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New MySqlConnection()
        cnn.ConnectionString = "server=localhost;user id=root;" & "password=;database=Dental Clinic Management"
        Try
            cnn.Open()
            SQL = "Select * From tblperson"

            myCommand.Connection = cnn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            DataGridView1.DataSource = myData

            cnn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            cnn.Dispose()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim DeletePersonCommand As New MySqlCommand

            DeletePersonCommand.Connection = cnn

            DeletePersonCommand.CommandText = "delete  from tblperson where Patient_number = " & DataGridView1.CurrentRow.Cells(0).Value.ToString()

            cnn.Open()
            DeletePersonCommand.Parameters.AddWithValue("@patient_number", txtPatient)
            DeletePersonCommand.ExecuteNonQuery()
            MessageBox.Show("Record Deleted Successfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cnn.Close()
            Me.Refreshdatagrid()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            txtFirstname.Text = row.Cells("Firstname").Value.ToString
            txtLastname.Text = row.Cells("Lastname").Value.ToString
            txtAddress.Text = row.Cells("Address").Value.ToString

        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        mode = "add"
        txtPatient.Text = "Computer Generated"
        txtFirstname.Enabled = True
        txtLastname.Enabled = True
        txtAddress.Enabled = True

        If mode = "add" Then
            If txtFirstname.Text = "" Or txtLastname.Text = "" Or txtAddress.Text = "" Then
                MessageBox.Show("All field are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFirstname.Focus()
            Else
                Dim addPersonCommand As New MySqlCommand("Server = Localhost; User = root; Password = ; Database = Dental Clinic Management")

                addPersonCommand.Connection = cnn
                addPersonCommand.CommandText = "INSERT INTO tblperson (Firstname,Lastname,Address) VALUES (@Firstname,@Lastname,@address)"

                addPersonCommand.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
                addPersonCommand.Parameters.AddWithValue("@Lastname", txtLastname.Text)
                addPersonCommand.Parameters.AddWithValue("@Address", txtAddress.Text)

                cnn.Open()
                addPersonCommand.ExecuteNonQuery()
                MessageBox.Show("Record Added Sucessfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnn.Close()

                btnInsert.Enabled = True

                btnDelete.Enabled = True
                DataGridView1.Enabled = True
                txtPatient.Text = False
                txtFirstname.Text = False
                txtLastname.Text = False
                txtAddress.Text = False

                Call Refreshdatagrid()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cnn As New MySqlConnection("Server = Localhost; User = root; Password = ; Database = Dental Clinic Management")
        Dim UpdatePersonCommand As New MySqlCommand

        UpdatePersonCommand.Connection = cnn
        UpdatePersonCommand.CommandText = "UPDATE tblperson SET Firstname = @FirstName, LastName = @LastName, Address = @Address WHERE Patient_number = @Patient_number”
        cnn.Open()

        UpdatePersonCommand.Parameters.AddWithValue("@Patient_Number", txtPatient.Text)
        UpdatePersonCommand.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
        UpdatePersonCommand.Parameters.AddWithValue("@Lastname", txtLastname.Text)
        UpdatePersonCommand.Parameters.AddWithValue("@Address", txtAddress.Text)

        UpdatePersonCommand.ExecuteNonQuery()
        MessageBox.Show("Record Updated Successfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cnn.Close()
        Me.Refreshdatagrid()
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim DeletePersonCommand As New MySqlCommand

            DeletePersonCommand.Connection = cnn

            DeletePersonCommand.CommandText = "delete  from tblperson where Patient_number = " & DataGridView1.CurrentRow.Cells(0).Value.ToString()

            cnn.Open()
            DeletePersonCommand.Parameters.AddWithValue("@patient_number", txtPatient)
            DeletePersonCommand.ExecuteNonQuery()
            MessageBox.Show("Record Deleted Successfully", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cnn.Close()
            Me.Refreshdatagrid()
        End If
    End Sub

    Private Sub btnSearchs_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtAddress.Text = ""

        MessageBox.Show("All Fields are Cleared")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(DataGridView1.Width, DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, DataGridView1.Width, DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PrintPreviewDialog1.WindowState = FormWindowState.Normal
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        PrintPreviewDialog1.ClientSize = New Size(600, 600)

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            MessageBox.Show("Field is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class