Imports System.Data
Imports System.Data.SqlClient

Public Class DeleteMarks
    Private Sub DeleteMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_StudentIdCombobox()
    End Sub

    Private Sub load_StudentIdCombobox()
        comStudentId.Items.Clear()
        Dim stuIdData As New SqlDataAdapter(New SqlCommand("SELECT distinct studentId FROM marks;", Form2.connection))
        Dim datatable As New DataTable()
        stuIdData.Fill(datatable)

        If datatable.Rows.Count > 0 Then
            For i As Integer = 0 To datatable.Rows.Count - 1
                comStudentId.Items.Add(datatable.Rows(i).Item(0))
            Next

            comStudentId.SelectedIndex = 0
        Else
            MessageBox.Show("There are no any marks record in the database. ", "No marks record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If
    End Sub

    Private Sub comStudentId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStudentId.SelectedIndexChanged
        comSubjectId.Items.Clear()

        Dim subIdData As New SqlDataAdapter(New SqlCommand("SELECT distinct subjectId FROM marks where studentId = '" & comStudentId.SelectedItem & "';", Form2.connection))
        Dim datatable As New DataTable()
        subIdData.Fill(datatable)

        For i As Integer = 0 To datatable.Rows.Count - 1
            comSubjectId.Items.Add(datatable.Rows(i).Item(0))
        Next

        comSubjectId.SelectedIndex = 0
    End Sub

    Private Sub comSubjectId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSubjectId.SelectedIndexChanged
        Dim da As New SqlDataAdapter(New SqlCommand("SELECT distinct examyear FROM marks where studentId = '" & comStudentId.SelectedItem & "' AND subjectId = '" & comSubjectId.SelectedItem & "';", Form2.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        For i As Integer = 0 To datatable.Rows.Count - 1
            comExamYear.Items.Add(datatable.Rows(i).Item(0))
        Next

        comExamYear.SelectedIndex = 0
    End Sub
    Private Sub comExamYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comExamYear.SelectedIndexChanged
        Dim da As New SqlDataAdapter(New SqlCommand("SELECT mark FROM marks where studentId = '" & comStudentId.SelectedItem & "' AND subjectId = '" & comSubjectId.SelectedItem & "' AND examyear = " & comExamYear.SelectedItem & ";", Form2.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        txtMark.Text = datatable.Rows(0).Item(0)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim studentId As String = comStudentId.SelectedItem
        Dim subjectId As String = comSubjectId.SelectedItem
        Dim year As String = comExamYear.SelectedItem
        Dim proceedDelete As Integer = MessageBox.Show("Mark record of student with student id " & studentId & " for subject with subject id " & subjectId & " in year " & year & " will be deleted", "Delete Mark Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If proceedDelete = 6 Then
            Dim insertQuery As String = "delete from marks where studentId = '" & studentId & "' AND subjectId = '" & subjectId & "' AND examyear = " & year & " ;"
            Form2.run_query(insertQuery)
            Form2.table_load("marks")

            MessageBox.Show("Mark record of student with student id " & studentId & " for subject with subject id " & subjectId & " in year " & year & " has been deleted", "Mark Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_StudentIdCombobox()
        End If
    End Sub
End Class