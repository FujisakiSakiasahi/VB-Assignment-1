Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Dim connection As New SqlConnection("Server=BRUH-LAPTOP\SQLEXPRESS04 ; Database=SchoolDb ; Integrated Security = TRUE")
    'Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS ; Database=SchoolDb ; Integrated Security = TRUE")

    Private Sub run_query(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub app_close() Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub table_load(table As String)
        Dim da As New SqlDataAdapter(New SqlCommand("select * from " & table & " ;", connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)
        Select Case table
            Case "student"
                student_table.DataSource = datatable
            Case "teacher"
                teacher_table.DataSource = datatable
            Case "class"
                class_table.DataSource = datatable
            Case "subject"
                subject_table.DataSource = datatable
        End Select
    End Sub

    Private Sub window_onload() Handles Me.Load
        table_load("student")
    End Sub

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
                table_load("class")
            Case 3
                table_load("subject")
        End Select
    End Sub
    Private Sub student_add_button_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub student_update_button_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub student_delete_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub student_search_button_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub teacher_add_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub teacher_delete_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub teacher_update_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub teacher_search_button_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub class_add_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub class_update_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub class_delete_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub class_search_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub subject_update_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub subject_delete_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub subject_search_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub student_add_button_Click_1(sender As Object, e As EventArgs) Handles student_add_button.Click
        Dim formStudent As New StudentAddForm

        formStudent.Show()
    End Sub
End Class