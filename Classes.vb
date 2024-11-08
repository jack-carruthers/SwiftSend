Imports System.Data.SqlClient

Public Class Classes
    Private connectionString As String = "Server=LC21208XX;Database=SwiftSend;User Id=sa;Password=saroot;" ' Replace with your actual connection string.

    Private Sub FormAddClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClasses()
        LoadAvailableStudents()
    End Sub

    ' Step 1: Load Classes into lstClasses
    Private Sub LoadClasses()
        lstClasses.Items.Clear()
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
                        lstClasses.Items.Add(classItem)
                    End While
                End Using
            End Using
        End Using

        ' Set display member to show ClassName and value member to use ClassID
        lstClasses.DisplayMember = "ClassName"
        lstClasses.ValueMember = "ClassID"
    End Sub

    ' Step 2: Load Available Students into lstAvailableStudents
    Private Sub LoadAvailableStudents()
        lstAvailableStudents.Items.Clear()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT StudentID, Name FROM Students"
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim studentItem As String = $"{reader("StudentID")} - {reader("Name")}"
                        lstAvailableStudents.Items.Add(studentItem)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Step 3: When a class is selected, load students in that class
    Private Sub lstClasses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClasses.SelectedIndexChanged
        If lstClasses.SelectedIndex >= 0 Then
            ' Retrieve the selected class ID
            Dim selectedClass = CType(lstClasses.SelectedItem, Object)
            Dim classID As Integer = selectedClass.ClassID

            ' Load students in this class
            LoadClassStudents(classID)
        End If
    End Sub

    ' Load students in the selected class into lstClassStudents
    Private Sub LoadClassStudents(classID As Integer)
        lstClassStudents.Items.Clear()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT Students.StudentID, Students.Name 
                                   FROM Students
                                   INNER JOIN ClassStudent ON Students.StudentID = ClassStudent.StudentID
                                   WHERE ClassStudent.ClassID = @ClassID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClassID", classID)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim studentItem As String = $"{reader("StudentID")} - {reader("Name")}"
                        lstClassStudents.Items.Add(studentItem)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Step 4: Add selected student to the selected class
    Private Sub btnAddStudentToClass_Click(sender As Object, e As EventArgs) Handles btnAddStudentToClass.Click
        If lstAvailableStudents.SelectedIndex >= 0 AndAlso lstClasses.SelectedIndex >= 0 Then
            ' Get selected student ID
            Dim selectedStudent As String = lstAvailableStudents.SelectedItem.ToString()
            Dim studentID As Integer = CInt(selectedStudent.Split("-"c)(0).Trim())

            ' Get selected class ID
            Dim selectedClass = CType(lstClasses.SelectedItem, Object)
            Dim classID As Integer = selectedClass.ClassID

            ' Add student to class and refresh class students list
            AddStudentToClass(classID, studentID)
            LoadClassStudents(classID)
        Else
            MessageBox.Show("Please select both a class and a student.")
        End If
    End Sub

    ' Helper function to add a student to a class in the ClassStudent table
    Private Sub AddStudentToClass(classID As Integer, studentID As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO ClassStudent (ClassID, StudentID) VALUES (@ClassID, @StudentID)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClassID", classID)
                command.Parameters.AddWithValue("@StudentID", studentID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' New: Remove selected student from the selected class
    Private Sub btnRemoveStudentFromClass_Click(sender As Object, e As EventArgs) Handles btnRemoveStudentFromClass.Click
        If lstClassStudents.SelectedIndex >= 0 AndAlso lstClasses.SelectedIndex >= 0 Then
            ' Get selected student ID from lstClassStudents
            Dim selectedStudent As String = lstClassStudents.SelectedItem.ToString()
            Dim studentID As Integer = CInt(selectedStudent.Split("-"c)(0).Trim())

            ' Get selected class ID from lstClasses
            Dim selectedClass = CType(lstClasses.SelectedItem, Object)
            Dim classID As Integer = selectedClass.ClassID

            ' Remove student from the selected class and refresh class students list
            RemoveStudentFromClass(classID, studentID)
            LoadClassStudents(classID)
        Else
            MessageBox.Show("Please select both a class and a student to remove.")
        End If
    End Sub

    ' Helper function to remove a student from a class in the ClassStudent table
    Private Sub RemoveStudentFromClass(classID As Integer, studentID As Integer)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM ClassStudent WHERE ClassID = @ClassID AND StudentID = @StudentID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClassID", classID)
                command.Parameters.AddWithValue("@StudentID", studentID)
                connection.Open()
                command.ExecuteNonQuery()
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

    ' Navigation buttons for other forms
    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Me.Hide()
        Dim Students As New Students
        Students.Show()
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
