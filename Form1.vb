Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1

    Private ReadOnly apiKey As String = "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"

    Private Async Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim userInput As String
        userInput = "Create an email template for " & txtInput.Text & " and only include the template in answer, no other text and between each newline for the email please put \n"

        If String.IsNullOrWhiteSpace(userInput) Then
            MessageBox.Show("Please enter a message.")
            Return
        End If

        ' Get the response from ChatGPT and update the multiline textbox with line breaks
        Dim response = Await GetChatGPTResponse(userInput)

        ' Ensure line breaks are properly formatted for multiline TextBox
        response = FormatResponse(response)

        ' Display the formatted response in the output box
        txtOutput.Text = response
    End Sub

    ' Function to handle formatting the response
    Private Function FormatResponse(response As String) As String
        ' Replace \n and \r\n with Environment.NewLine for proper line breaks in TextBox
        response = response.Replace("\n", Environment.NewLine).Replace("\r\n", Environment.NewLine)

        ' Also replace <br> tags if ChatGPT response contains HTML line breaks
        response = response.Replace("<br>", Environment.NewLine)

        Return response
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Async Function GetChatGPTResponse(prompt As String) As Task(Of String)
        Dim apiUrl As String = "https://api.openai.com/v1/chat/completions"
        Dim requestData As New With {
            .model = "gpt-3.5-turbo",
            .messages = New Object() {
                New With {.role = "user", .content = prompt}
            },
            .temperature = 0.7
        }

        Dim json As String = JsonConvert.SerializeObject(requestData)
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}")

            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Try
                Dim response = Await client.PostAsync(apiUrl, content)
                Dim responseString As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    Dim responseObject = JsonConvert.DeserializeObject(Of ChatGPTResponse)(responseString)
                    Return responseObject.choices(0).message.content.Trim()
                Else
                    ' Log the response error for more details
                    Return $"Error: {response.StatusCode} - {responseString}"
                End If
            Catch ex As Exception
                Return $"Exception: {ex.Message}"
            End Try
        End Using
    End Function


    ' Default folder path (optional)
    Dim defaultFolderPath As String = "C:\Your\Default\Directory"

        ' Function to open FolderBrowserDialog and return the selected folder path
        Private Function SelectFolder() As String
            ' Create a new instance of the FolderBrowserDialog
            Dim folderDialog As New FolderBrowserDialog()

            ' Set the initial directory (optional)
            folderDialog.SelectedPath = defaultFolderPath

            ' Show the dialog and check if the user selected a folder
            If folderDialog.ShowDialog() = DialogResult.OK Then
                ' Return the selected folder path
                Return folderDialog.SelectedPath
            Else
                ' Return Nothing if no folder is selected
                Return Nothing
            End If
        End Function

    Private Sub btnSaveToFile_Click(sender As Object, e As EventArgs) Handles btnSaveToFile.Click
        ' Call the SelectFolder function to let the user choose a folder
        Dim folderPath As String = SelectFolder()

        ' Check if a folder was selected
        If String.IsNullOrWhiteSpace(folderPath) Then
            MessageBox.Show("Please select a folder to save the file.")
            Return
        End If

        ' Set the filename (you can get it from another TextBox or generate dynamically)
        Dim fileName As String = txtFileName.Text & ".txt"
        Dim fullPath As String = Path.Combine(folderPath, fileName)

        ' Get the content from a TextBox (e.g., txtOutput.Text)
        Dim fileContent As String = txtOutput.Text

        If Not String.IsNullOrWhiteSpace(txtFileName.Text) Then
            MessageBox.Show("Template saved successfully to " & fullPath)
        Else
            MessageBox.Show("Please enter a file name in the correct box")
        End If

        ' Ensure the content is not empty
        If String.IsNullOrWhiteSpace(fileContent) Then
            MessageBox.Show("There is no content to save.")
            Return
        End If

        ' Save the file
        Try
            File.WriteAllText(fullPath, fileContent)
            MessageBox.Show("File saved successfully to " & fullPath)
        Catch ex As Exception
            MessageBox.Show("Error saving file: " & ex.Message)
        End Try
    End Sub

    Private connString As String = "Server=LC21208XX;Database=SwiftSend;User Id=sa;Password=saroot;"


    Private Sub MinimiseBtn_Click(sender As Object, e As EventArgs) Handles MinimiseBtn.Click
            Me.WindowState = FormWindowState.Minimized
        End Sub


    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Application.Exit()
    End Sub

    Private Sub LockBtn_Click(sender As Object, e As EventArgs) Handles LockBtn.Click
        Me.Hide()
        Dim Login As New Login
        Login.Show()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Me.Hide()
        Dim Students As New Students
        Students.Show()
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
End Class

Public Class ChatGPTResponse
    Public Property choices As Choice()
End Class

Public Class Choice
    Public Property message As Message
End Class

Public Class Message
    Public Property content As String
End Class
