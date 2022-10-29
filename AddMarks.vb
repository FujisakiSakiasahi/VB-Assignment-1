Imports System.Data.SqlClient

Public Class AddMarks
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    End Sub

    Private Sub AddMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New SqlDataAdapter(New SqlCommand("SELECT stuId FROM student;", Form2.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        Dim i As Integer = 0
        Do While i < datatable.Rows.Count
            comStudentId.Items.Add(datatable.Rows(i).Item(0).ToString)
            i += 1
        Loop

    End Sub

    'remember to change to dropdown lst for subjectID
End Class