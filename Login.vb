Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text




Public Class Login

    Private Sub ShowPassCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassCheck.CheckedChanged
        If ShowPassCheck.Checked Then
            txtPassword.PasswordChar = Nothing
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub


    Private Sub MinimiseBtn_Click(sender As Object, e As EventArgs) Handles MinimiseBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Application.Exit()
    End Sub


    Private Function GenerateSalt() As Byte()
        Dim salt(15) As Byte  ' 16 bytes for the salt
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using
        Return salt
    End Function

    Private Function HashPasswordWithSalt(password As String, salt As Byte()) As Byte()
        Using sha256 As SHA256 = SHA256.Create()
            Dim passwordBytes = Encoding.UTF8.GetBytes(password)
            Dim passwordWithSalt = salt.Concat(passwordBytes).ToArray()  ' Combine salt and password
            Return sha256.ComputeHash(passwordWithSalt)
        End Using
    End Function

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim isAuthenticated As Boolean = False

        ' Connection string (adjust with your server details)
        Dim connectionString As String = "Server=LC21208XX;Database=SwiftSend;User Id=sa;Password=saroot;"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("SELECT PasswordHash, PasswordSalt FROM Users WHERE Username = @Username", connection)
            command.Parameters.AddWithValue("@Username", username)

            connection.Open()
            Using reader = command.ExecuteReader()
                If reader.Read() Then
                    Dim storedHash As Byte() = CType(reader("PasswordHash"), Byte())
                    Dim storedSalt As Byte() = CType(reader("PasswordSalt"), Byte())

                    ' Hash the entered password with the retrieved salt
                    Dim enteredPasswordHash = HashPasswordWithSalt(password, storedSalt)

                    ' Compare the hashed password to the stored hash
                    isAuthenticated = storedHash.SequenceEqual(enteredPasswordHash)
                End If
            End Using
        End Using

        Return isAuthenticated
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If AuthenticateUser(username, password) Then
            MessageBox.Show("Login successful!")
            ' Proceed to the main application screen or dashboard
            Me.Hide()
            Dim Form1 As New Form1
            Form1.Show()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub CreateLabel_Click(sender As Object, e As EventArgs) Handles CreateLabel.Click
        Me.Hide()
        Dim frmRegister As New frmRegister
        frmRegister.Show()
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        txtUsername.BackColor = Color.FromArgb(61, 58, 75)
        UserPanel.BackColor = Color.FromArgb(61, 58, 75)
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        txtUsername.BackColor = Color.FromArgb(42, 40, 54)
        UserPanel.BackColor = Color.FromArgb(42, 40, 54)
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.BackColor = Color.FromArgb(61, 58, 75)
        PasswordPanel.BackColor = Color.FromArgb(61, 58, 75)
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        txtPassword.BackColor = Color.FromArgb(42, 40, 54)
        PasswordPanel.BackColor = Color.FromArgb(42, 40, 54)
    End Sub
End Class