Public Class AddSubject
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtSubjectId.Text) Or String.IsNullOrEmpty(txtSName.Text) Then ' checking for empty fields
            MessageBox.Show("One or more fields are empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txtSubjectId.Text.Length > 3 Then
                MessageBox.Show("Subject ID can only support up to a maximum of 3 characters.", "Invalid Subject ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim subjectId As String = "'" & txtSubjectId.Text & "'"
                If txtSName.Text.Length > 30 Then
                    MessageBox.Show("Subject Name can only support up to a maximum of 30 characters.", "Invalid Subject Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim subjectName As String = txtSName.Text

                    Dim insertQuery As String = "INSERT INTO subject values (" & subjectId & "," & subjectName & ");"
                    Form2.run_query(insertQuery)
                    Form2.table_load("subject")

                    MessageBox.Show("Added New Subject " & subjectName & ".", "New Subject Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                End If
            End If
        End If
    End Sub

    Private Sub clear()
        txtSName.Text = ""
        txtSubjectId.Text = ""
    End Sub


End Class