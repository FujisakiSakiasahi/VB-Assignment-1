Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    'Establish connection with the database server
    Public connection As New SqlConnection("Server=BRUH-LAPTOP\SQLEXPRESS04 ; Database=SchoolDb ; Integrated Security = TRUE")
    'Public connection As New SqlConnection("Server=localhost\SQLEXPRESS ; Database=SchoolDb ; Integrated Security = TRUE")

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
        table_load("teacher")
        table_load("enrolled")
        table_load("subject")
        table_load("marks")
        table_load("period")

        'load combobox for each tab
        'for student tab
        With studentSearch_comboBox
            .Items.Add(student_table.Columns(0).HeaderText)
            .Items.Add(student_table.Columns(1).HeaderText)
            .Items.Add(student_table.Columns(2).HeaderText)
            .Items.Add(student_table.Columns(3).HeaderText)
            .Items.Add(student_table.Columns(4).HeaderText)
            .Items.Add(student_table.Columns(5).HeaderText)
        End With
        'for teacher tab
        With teacherSearch_comboBox
            .Items.Add(teacher_table.Columns(0).HeaderText)
            .Items.Add(teacher_table.Columns(1).HeaderText)
            .Items.Add(teacher_table.Columns(2).HeaderText)
        End With
        'for class tab
        With classSearch_comboBox
            .Items.Add(class_table.Columns(0).HeaderText)
            .Items.Add(class_table.Columns(1).HeaderText)
        End With
        'for subject tab
        With subjectSearch_comboBox
            .Items.Add(subject_table.Columns(0).HeaderText)
            .Items.Add(subject_table.Columns(1).HeaderText)
        End With
        'for marks tab
        With marksSearch_comboBox
            .Items.Add(marks_table.Columns(0).HeaderText)
            .Items.Add(marks_table.Columns(1).HeaderText)
            .Items.Add(marks_table.Columns(2).HeaderText)
            .Items.Add(marks_table.Columns(3).HeaderText)
        End With
        'for period tab
        With periodSearch_comboBox
            .Items.Add(period_table.Columns(0).HeaderText)
            .Items.Add(period_table.Columns(1).HeaderText)
            .Items.Add(period_table.Columns(2).HeaderText)
            .Items.Add(period_table.Columns(3).HeaderText)
            .Items.Add(period_table.Columns(4).HeaderText)
        End With

        'set combobox initial selected item
        studentSearch_comboBox.SelectedIndex = 0
        teacherSearch_comboBox.SelectedIndex = 0
        classSearch_comboBox.SelectedIndex = 0
        subjectSearch_comboBox.SelectedIndex = 0
        marksSearch_comboBox.SelectedIndex = 0
        periodSearch_comboBox.SelectedIndex = 0
    End Sub

    'load / refresh controls / tables when tab changes
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

    'Search function
    'based on combo box selection
    'for student
    Private Sub studentSearch_TextChanged(sender As Object, e As EventArgs) Handles studentSearch_textBox.TextChanged, studentSearch_comboBox.SelectedIndexChanged
        Dim column() As String = {"stuId", "stuName", "age", "enrollyear", "stugender", "team"}

        Dim da As New SqlDataAdapter(New SqlCommand("select * from student where " & column(studentSearch_comboBox.SelectedIndex) & " like '%" & studentSearch_textBox.Text & "%' ;", connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        student_table.DataSource = datatable
    End Sub

    'for teacher
    Private Sub teacherSearch_TextChanged(sender As Object, e As EventArgs) Handles teacherSearch_textBox.TextChanged, teacherSearch_comboBox.SelectedIndexChanged
        Dim column() As String = {"teacherId", "teacherName", "teacherGender"}

        Dim da As New SqlDataAdapter(New SqlCommand("select * from teacher where " & column(teacherSearch_comboBox.SelectedIndex) & " like '%" & teacherSearch_textBox.Text & "%' ;", connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        teacher_table.DataSource = datatable
    End Sub

    'for class
    Private Sub classSearch_TextChanged(sender As Object, e As EventArgs) Handles classSearch_textBox.TextChanged, classSearch_comboBox.SelectedIndexChanged
        Dim column() As String = {"studentId", "classId"}

        Dim da As New SqlDataAdapter(New SqlCommand("select * from enrolled where " & column(classSearch_comboBox.SelectedIndex) & " like '%" & classSearch_textBox.Text & "%' ;", connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        class_table.DataSource = datatable
    End Sub

    'for subject
    Private Sub subjectSearch_TextChanged(sender As Object, e As EventArgs) Handles subjectSearch_textBox.TextChanged, subjectSearch_comboBox.SelectedIndexChanged
        Dim column() As String = {"subjectId", "sname"}

        Dim da As New SqlDataAdapter(New SqlCommand("select * from subject where " & column(subjectSearch_comboBox.SelectedIndex) & " like '%" & subjectSearch_textBox.Text & "%' ;", connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        subject_table.DataSource = datatable
    End Sub

    'for marks
    Private Sub marksSearch_TextChanged(sender As Object, e As EventArgs) Handles marksSearch_textBox.TextChanged, marksSearch_comboBox.SelectedIndexChanged
        Dim column() As String = {"studentId", "subjectId", "examyear", "mark"}

        Dim da As New SqlDataAdapter(New SqlCommand("select * from marks where " & column(marksSearch_comboBox.SelectedIndex) & " like '%" & marksSearch_textBox.Text & "%' ;", connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        marks_table.DataSource = datatable
    End Sub

    'for period
    Private Sub periodSearch_TextChanged(sender As Object, e As EventArgs) Handles periodSearch_textBox.TextChanged, periodSearch_comboBox.SelectedIndexChanged
        Dim column() As String = {"periodId", "periodDay", "periodTime", "classId", "subjectId"}

        Dim da As New SqlDataAdapter(New SqlCommand("select * from period where " & column(periodSearch_comboBox.SelectedIndex) & " like '%" & periodSearch_textBox.Text & "%' ;", connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        period_table.DataSource = datatable
    End Sub

    'FOR ADD, UPDATE, DELETE FUNCTION: summon add win form
    'for student tab / table
    Private Sub studentAdd_button_Click(sender As Object, e As EventArgs) Handles studentAdd_button.Click
        Dim formStudent As New StudentAddForm
        formStudent.Show()
    End Sub

    Private Sub studentUpdate_button_Click(sender As Object, e As EventArgs) Handles studentUpdate_button.Click

    End Sub

    'for teacher tab / table
    Private Sub teacherAdd_button_Click(sender As Object, e As EventArgs) Handles teacherAdd_button.Click
        Dim formTeacher As New AddTeacher
        formTeacher.Show()
    End Sub
    Private Sub teacherUpdate_button_Click(sender As Object, e As EventArgs) Handles teacherUpdate_button.Click

    End Sub

    'for subject tab / table
    Private Sub subjectAdd_button_Click(sender As Object, e As EventArgs) Handles subjectAdd_button.Click
        Dim formSubject As New AddSubject
        formSubject.Show()
    End Sub
    Private Sub subjectUpdate_button_Click(sender As Object, e As EventArgs) Handles subjectUpdate_button.Click

    End Sub

    'for allocate student in class tab / table
    Private Sub classAddClass_button_Click(sender As Object, e As EventArgs) Handles classAddClass_button.Click
        Dim formNewClass As New AddClass
        formNewClass.Show()
    End Sub
    Private Sub classAllocStudent_button_Click(sender As Object, e As EventArgs) Handles classAllocStudent_button.Click
        Dim formClass As New AllocStudentToClass
        formClass.Show()
    End Sub
    Private Sub classUpdate_button_Click(sender As Object, e As EventArgs) Handles classUpdate_button.Click

    End Sub


    'for marks tab / table
    Private Sub marksAdd_button_Click(sender As Object, e As EventArgs) Handles marksAdd_button.Click
        Dim formMarks As New AddMarks
        formMarks.Show()
    End Sub
    Private Sub marksUpdate_button_Click(sender As Object, e As EventArgs) Handles marksUpdate_button.Click

    End Sub

    'for period tab / table
    Private Sub periodAdd_button_Click(sender As Object, e As EventArgs) Handles periodAdd_button.Click
        Dim formPeriod As New AddPeriod
        formPeriod.Show()
    End Sub
    Private Sub periodUpdate_button_Click(sender As Object, e As EventArgs) Handles periodUpdate_button.Click

    End Sub

    Private Sub classDelete_button_Click(sender As Object, e As EventArgs) Handles classRemoveStudent_button.Click
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