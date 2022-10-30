Public Class DeleteSubject
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim subjectId As String = comSubjectId.SelectedItem
        Dim proceedSubject As Integer = MessageBox.Show("All data that binds with class with class id " & subjectId & " will also be deleted", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If proceedSubject = 6 Then
            Dim insertQuery As String = "delete from enrolled where subjectId = '" & subjectId & "'"
            Form2.run_query(insertQuery)
            insertQuery = "delete from period where subjectId = '" & subjectId & "'"
            Form2.run_query(insertQuery)
            insertQuery = "delete from subject where subjectId = '" & subjectId & "'"
            Form2.run_query(insertQuery)
            Form2.table_load("enrolled")

            MessageBox.Show("Subject with subject ID" & subjectId & "has been deleted.", "Subject Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_combobox()
        End If

    End Sub
End Class