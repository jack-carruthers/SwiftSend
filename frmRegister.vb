Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmRegister

    Private Sub MinimiseBtn_Click(sender As Object, e As EventArgs) Handles MinimiseBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Application.Exit()
    End Sub


    ' Generate a random salt
    Private Function GenerateSalt() As Byte()
        Dim salt(15) As Byte  ' 16 bytes for the salt
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using
        Return salt
    End Function

    ' Hash the password with the salt
    Private Function HashPasswordWithSalt(password As String, salt As Byte()) As Byte()
        Using sha256 As SHA256 = SHA256.Create()
            Dim passwordBytes = Encoding.UTF8.GetBytes(password)
            Dim passwordWithSalt = salt.Concat(passwordBytes).ToArray()  ' Combine salt and password
            Return sha256.ComputeHash(passwordWithSalt)
        End Using
    End Function

    ' Register a new user
    Private Sub RegisterUser(username As String, password As String)
        Dim salt = GenerateSalt()
        Dim hashedPassword = HashPasswordWithSalt(password, salt)

        ' Connection string (adjust with your server details)
        Dim connectionString As String = "Server=LC21208XX;Database=SwiftSend;User Id=sa;Password=saroot;"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("INSERT INTO Users (Username, PasswordHash, PasswordSalt) VALUES (@Username, @PasswordHash, @PasswordSalt)", connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@PasswordHash", hashedPassword)
            command.Parameters.AddWithValue("@PasswordSalt", salt)

            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    ' Handle the Register button click event
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtNewUsername.Text
        Dim password As String = txtNewPassword.Text

        ' Basic validation
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username and password are required.")
            Return
        End If

        Try
            ' Register the user
            RegisterUser(username, password)
            MessageBox.Show("User registered successfully!")
            Me.Hide()
            Dim Login As New Login
            Login.Show()
        Catch ex As SqlException When ex.Number = 2627  ' Unique constraint error (duplicate username)
            MessageBox.Show("This username is already taken. Please choose another.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim Login As New Login
        Login.Show()
    End Sub




    Private Sub txtNewUsername_Enter(sender As Object, e As EventArgs) Handles txtNewUsername.Enter
        txtNewUsername.BackColor = Color.FromArgb(61, 58, 75)
        NewUserPanel.BackColor = Color.FromArgb(61, 58, 75)
    End Sub

    Private Sub txtNewUsername_Leave(sender As Object, e As EventArgs) Handles txtNewUsername.Leave
        txtNewUsername.BackColor = Color.FromArgb(42, 40, 54)
        NewUserPanel.BackColor = Color.FromArgb(42, 40, 54)
    End Sub

    Private Sub txtNewPassword_Enter(sender As Object, e As EventArgs) Handles txtNewPassword.Enter
        txtNewPassword.BackColor = Color.FromArgb(61, 58, 75)
        NewPasswordPanel.BackColor = Color.FromArgb(61, 58, 75)
    End Sub

    Private Sub txtNewPassword_Leave(sender As Object, e As EventArgs) Handles txtNewPassword.Leave
        txtNewPassword.BackColor = Color.FromArgb(42, 40, 54)
        NewPasswordPanel.BackColor = Color.FromArgb(42, 40, 54)
    End Sub
End Class
