Imports System.Data
Imports System.Data.SqlClient

Public Class UpdateSubject
    Private Sub UpdateSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_combobox()
    End Sub

    Private Sub load_combobox()
        comSubjectId.Items.Clear()
        txtSName.Enabled = False
        txtSName.Text = ""


        Dim da As New SqlDataAdapter(New SqlCommand("select * from subject", Form2.connection))
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub comSubjectId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSubjectId.SelectedIndexChanged
        Dim da As New SqlDataAdapter(New SqlCommand("select * from subject", Form2.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        txtSName.Enabled = True
        txtSName.Text = datatable.Rows(comSubjectId.SelectedIndex).Item(1)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtSName.Text) Then
            MessageBox.Show("Subject name field cannot be empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txtSName.Text.Length > 30 Then
                MessageBox.Show("Subject Name can only support up to a maximum of 30 characters.", "Invalid Subject Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim insertQuery As String = "update subject set sname = '" & txtSName.Text.ToString & "' where subjectId = '" & comSubjectId.SelectedItem & "';"
                Form2.run_query(insertQuery)
                Form2.table_load("subject")

                MessageBox.Show("Subject with subject id " & comSubjectId.SelectedItem & " has been updated.", "Subject Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                load_combobox()
            End If
        End If
    End Sub
End Class