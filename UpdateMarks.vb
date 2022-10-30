Imports System.Data
Imports System.Data.SqlClient

Public Class UpdateMarks
    Private Sub UpdateMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtMark.Text) Then
            MessageBox.Show("One or more fields are empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtMark.Text) = False Then
            MessageBox.Show("Marks should not include characters or symbols. Please enter number in range of 0 - 100.", "Invalid Marks", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim examYear As Integer = comExamYear.SelectedIndex
            Dim mark As Integer = txtMark.Text
            If mark < 0 Or mark > 100 Then
                MessageBox.Show("Mark out of range. Please enter number in range of 0 - 100.", "Invalid Mark", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim studentId As Integer = comStudentId.SelectedItem
                Dim subjectId As String = "'" & comSubjectId.SelectedItem.ToString & "'"
                Dim insertQuery As String = "update marks set examyear = " & examYear & ", mark = " & mark & " where studentId = " & studentId & "AND subjectId = " & subjectId & " ;"
                Form2.run_query(insertQuery)
                Form2.table_load("marks")

                MessageBox.Show("Mark record of student with student id " & studentId & " for subject with subject id " & comSubjectId.SelectedItem.ToString & " has been updated", "Mark Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class