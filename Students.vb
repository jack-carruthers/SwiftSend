Imports System.Data.SqlClient

Public Class Students
    Private connectionString As String = "Server=LC21208XX;Database=SwiftSend;User Id=sa;Password=saroot;"

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim studentName As String = txtStudentName.Text
        Dim studentEmail As String = txtStudentEmail.Text

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Students (Name, Email) VALUES (@Name, @Email)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", studentName)
                command.Parameters.AddWithValue("@Email", studentEmail)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Student added successfully!")
            End Using
        End Using
    End Sub

    Private Sub MinimiseBtn_Click(sender As Object, e As EventArgs) Handles MinimiseBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Close application
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Application.Exit()
    End Sub

    ' Lock the form
    Private Sub LockBtn_Click(sender As Object, e As EventArgs) Handles LockBtn.Click
        Me.Hide()
        Dim Login As New Login
        Login.Show()
    End Sub

    Private Sub btnClasses_Click(sender As Object, e As EventArgs) Handles btnClasses.Click
        Me.Hide()
        Dim Classes As New Classes
        Classes.Show()
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        Me.Hide()
        Dim Email As New Email
        Email.Show()
    End Sub

    Private Sub btnTemplate_Click(sender As Object, e As EventArgs) Handles btnTemplate.Click
        Me.Hide()
        Dim Form1 As New Form1
        Form1.Show()
    End Sub
End Class
