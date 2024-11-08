Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mail

Public Class Email

    Private connectionString As String = "Server=LC21208XX;Database=SwiftSend;User Id=sa;Password=saroot;" ' Replace with your actual connection string.

    Private Sub EmailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClasses()
        LoadStudents()
    End Sub

    ' Step 1: Load available classes into the CheckedListBox
    Private Sub LoadClasses()
        chkClasses.Items.Clear()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT ClassID, ClassName FROM Classes"
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim classItem As New With {
                            .ClassID = reader("ClassID"),
                            .ClassName = reader("ClassName").ToString()
                        }
                        chkClasses.Items.Add(classItem)
                    End While
                End Using
            End Using
        End Using
        chkClasses.DisplayMember = "ClassName"
        chkClasses.ValueMember = "ClassID"
    End Sub

    ' Step 2: Load available students into the CheckedListBox
    Private Sub LoadStudents()
        chkStudents.Items.Clear()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT StudentID, Name, Email FROM Students"
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim studentItem As New With {
                            .StudentID = reader("StudentID"),
                            .Name = reader("Name").ToString(),
                            .Email = reader("Email").ToString()
                        }
                        chkStudents.Items.Add(studentItem)
                    End While
                End Using
            End Using
        End Using
        chkStudents.DisplayMember = "Name"
        chkStudents.ValueMember = "StudentID"
    End Sub

    ' Step 3: Handle the Send Email button click event
    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click
        Dim emailSubject As String = txtEmailSubject.Text
        Dim emailBody As String = txtEmailBody.Text

        ' Validate input
        If String.IsNullOrWhiteSpace(emailSubject) Or String.IsNullOrWhiteSpace(emailBody) Then
            MessageBox.Show("Please enter both a subject and a message.")
            Return
        End If

        Dim recipientEmails As New List(Of String)

        ' Step 4: Check if the "Select by Class" checkbox is checked
        If chkSelectByClass.Checked Then
            If chkClasses.CheckedItems.Count > 0 Then
                ' If classes are selected, add all emails of students in these classes
                For Each selectedClass As Object In chkClasses.CheckedItems
                    Dim classID As Integer = selectedClass.ClassID
                    recipientEmails.AddRange(GetEmailsByClass(classID))
                Next
            Else
                MessageBox.Show("Please select a class to send the email to.")
                Return
            End If
        Else
            ' Step 5: Add selected students' emails to the list
            If chkStudents.CheckedItems.Count > 0 Then
                For Each selectedStudent As Object In chkStudents.CheckedItems
                    recipientEmails.Add(selectedStudent.Email)
                Next
            Else
                MessageBox.Show("Please select students to send the email to.")
                Return
            End If
        End If

        ' Step 6: Remove duplicate emails and send the email
        Dim uniqueEmails = recipientEmails.Distinct().ToList()
        SendEmail(uniqueEmails, emailSubject, emailBody)
    End Sub

    ' Helper function to get emails by class ID
    Private Function GetEmailsByClass(classID As Integer) As List(Of String)
        Dim emails As New List(Of String)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT Students.Email 
                                   FROM Students 
                                   INNER JOIN ClassStudent ON Students.StudentID = ClassStudent.StudentID 
                                   WHERE ClassStudent.ClassID = @ClassID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClassID", classID)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        emails.Add(reader("Email").ToString())
                    End While
                End Using
            End Using
        End Using
        Return emails
    End Function

    ' Helper function to send the email
    Private Sub SendEmail(recipients As List(Of String), subject As String, body As String)
        Try
            Dim smtpClient As New SmtpClient("smtp.yourserver.com") ' Replace with your SMTP server
            Dim mailMessage As New MailMessage()
            mailMessage.Subject = subject
            mailMessage.Body = body
            mailMessage.From = New MailAddress("yourcollege@domain.com")

            ' Add each recipient email to the BCC to avoid multiple emails being shown
            For Each recipient As String In recipients
                mailMessage.Bcc.Add(recipient)
            Next

            smtpClient.Send(mailMessage)
            MessageBox.Show("Email sent successfully!")
        Catch ex As Exception
            MessageBox.Show($"Error sending email: {ex.Message}")
        End Try
    End Sub

    ' Minimise form
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

    ' Load email template
    Private Sub btnLoadTemplate_Click(sender As Object, e As EventArgs) Handles btnLoadTemplate.Click
        ' Create and configure the OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog.Title = "Open Email Template"

        ' Show the dialog and check if a file was selected
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Read the content of the selected file
                Dim filePath As String = openFileDialog.FileName
                Dim fileContent As String = File.ReadAllText(filePath)

                ' Display the file content in txtEmailBody
                txtEmailBody.Text = fileContent
            Catch ex As Exception
                MessageBox.Show("Error reading file: " & ex.Message)
            End Try
        End If
    End Sub

    ' Navigate to the Students form
    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Me.Hide()
        Dim Students As New Students
        Students.Show()
    End Sub

    ' Navigate to the Classes form
    Private Sub btnClasses_Click(sender As Object, e As EventArgs) Handles btnClasses.Click
        Me.Hide()
        Dim Classes As New Classes
        Classes.Show()
    End Sub

    ' Navigate to the Template form
    Private Sub btnTemplate_Click(sender As Object, e As EventArgs) Handles btnTemplate.Click
        Me.Hide()
        Dim Form1 As New Form1
        Form1.Show()
    End Sub

    ' Handle ListBox selection change event (optional)
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub
End Class
