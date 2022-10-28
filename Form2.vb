Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    'Establish connection with the database server
    'Dim connection As New SqlConnection("Server=BRUH-LAPTOP\SQLEXPRESS04 ; Database=SchoolDb ; Integrated Security = TRUE")
    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS ; Database=SchoolDb ; Integrated Security = TRUE")

    'function use to run sql query
    Public Sub run_query(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    '
    Public Sub fnA(a As String)
        MessageBox.Show(a)
    End Sub

    'Close the entire program
    Private Sub app_close() Handles Me.Closed
        Application.Exit()
    End Sub

    'Loading table for each tab
    Public Sub table_load(table As String)
        Dim da As New SqlDataAdapter(New SqlCommand("select * from " & table & " ;", connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)
        Select Case table
            Case "student"
                student_table.DataSource = datatable
                With student_table
                    .Columns(0).HeaderCell.Value() = "ID"
                    .Columns(1).HeaderCell.Value() = "Name"
                    .Columns(2).HeaderCell.Value() = "Age"
                    .Columns(3).HeaderCell.Value() = "Enrolled Year"
                    .Columns(4).HeaderCell.Value() = "Gender"
                    .Columns(5).HeaderCell.Value() = "Team"
                End With
            Case "teacher"
                teacher_table.DataSource = datatable
                With teacher_table
                    .Columns(0).HeaderCell.Value() = "ID"
                    .Columns(1).HeaderCell.Value() = "Name"
                    .Columns(2).HeaderCell.Value() = "Gender"
                End With
            Case "enrolled"
                class_table.DataSource = datatable
                With class_table
                    .Columns(0).HeaderCell.Value() = "Student ID"
                    .Columns(1).HeaderCell.Value() = "Class ID"
                End With
            Case "subject"
                subject_table.DataSource = datatable
                With subject_table
                    .Columns(0).HeaderCell.Value() = "ID"
                    .Columns(1).HeaderCell.Value() = "Name"
                End With
            Case "marks"
                marks_table.DataSource = datatable
                With marks_table
                    .Columns(0).HeaderCell.Value() = "Student ID"
                    .Columns(1).HeaderCell.Value() = "Subject ID"
                    .Columns(2).HeaderCell.Value() = "Exam Year"
                    .Columns(3).HeaderCell.Value() = "Mark"
                End With
            Case "period"
                period_table.DataSource = datatable
                With period_table
                    .Columns(0).HeaderCell.Value() = "ID"
                    .Columns(1).HeaderCell.Value() = "Day"
                    .Columns(2).HeaderCell.Value() = "Time"
                    .Columns(3).HeaderCell.Value() = "Class ID"
                    .Columns(4).HeaderCell.Value() = "Subject ID"
                End With
        End Select
    End Sub

    'load things on start
    Private Sub window_onload() Handles Me.Load
        table_load("student")
    End Sub

    'load the table when a tab is open / refresh table when tab changes
    Private Sub tab_load() Handles tab_control.SelectedIndexChanged
        'get selected tab index
        Dim tab_index As Integer = tab_control.SelectedIndex

        'debugging code
        'MsgBox("" & tab_index)

        'call function to load table
        Select Case tab_index
            Case 0
                table_load("student")
            Case 1
                table_load("teacher")
            Case 2
                table_load("enrolled")
            Case 3
                table_load("subject")
            Case 4
                table_load("marks")
            Case 5
                table_load("period")
        End Select
    End Sub

    'FOR ADD FUNCTION: summon add win form
    'for student tab / table
    Private Sub studentAdd_button_Click(sender As Object, e As EventArgs) Handles studentAdd_button.Click
        Dim formStudent As New StudentAddForm
        formStudent.Show()
    End Sub

    'for teacher tab / table
    Private Sub teacherAdd_button_Click_1(sender As Object, e As EventArgs) Handles teacherAdd_button.Click
        Dim formTeacher As New AddTeacher
        formTeacher.Show()
    End Sub

    'for subject tab / table
    Private Sub subjectAdd_button_Click(sender As Object, e As EventArgs) Handles subjectAdd_button.Click
        Dim formSubject As New AddSubject
        formSubject.Show()
    End Sub



    Private Sub class_delete_button_Click(sender As Object, e As EventArgs) Handles classDelete_button.Click
        Dim loopStatus As Boolean = True
        Dim debugVar As Integer = 0
        Do
            Dim studentName = InputBox(" Please enter the student name: ", "Delete student info")

            If debugVar <> 0 Then
                loopStatus = False
            Else
                MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Loop Until loopStatus '= False

    End Sub

End Class