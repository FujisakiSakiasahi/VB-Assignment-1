Imports System.Data
Imports System.Data.SqlClient

Public Class DeleteSubject
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim subjectId As String = comSubjectId.SelectedItem
        Dim proceedSubject As Integer = MessageBox.Show("All data that binds with class with class id " & subjectId & " will also be deleted", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If proceedSubject = 6 Then
            Dim insertQuery As String = "delete from marks where subjectId = '" & subjectId & "'"
            mainForm.run_query(insertQuery)
            insertQuery = "delete from period where subjectId = '" & subjectId & "'"
            mainForm.run_query(insertQuery)
            insertQuery = "delete from subject where subjectId = '" & subjectId & "'"
            mainForm.run_query(insertQuery)
            mainForm.table_load("subject")

            MessageBox.Show("Subject with subject ID" & subjectId & "has been deleted.", "Subject Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_combobox()
        End If
    End Sub

    Private Sub DeleteSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_combobox()
    End Sub

    Private Sub load_combobox()
        comSubjectId.Items.Clear()

        Dim da As New SqlDataAdapter(New SqlCommand("select * from subject", mainForm.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        If datatable.Rows.Count > 0 Then
            For i As Integer = 0 To datatable.Rows.Count - 1
                comSubjectId.Items.Add(datatable.Rows(i).Item(0))
            Next

            comSubjectId.SelectedIndex = 0
        Else
            MessageBox.Show("There is no subject in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub comSubjectId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSubjectId.SelectedIndexChanged
        Dim da As New SqlDataAdapter(New SqlCommand("select * from subject", mainForm.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        txtSName.Text = datatable.Rows(comSubjectId.SelectedIndex).Item(1)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class