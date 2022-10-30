Imports System.Data.SqlClient

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

                    Dim subjectIdData As New SqlDataAdapter(New SqlCommand("SELECT subjectId FROM subject WHERE subjectid = " & subjectId & ";", mainForm.connection))
                    Dim datatable As New DataTable()
                    subjectIdData.Fill(datatable)

                    Dim subjectName As String = "'" & txtSName.Text & "'"

                    If Not (datatable.Rows.Count > 0) Then
                        Dim insertQuery As String = "INSERT INTO subject values (" & subjectId & "," & subjectName & ");"
                        mainForm.run_query(insertQuery)
                        mainForm.table_load("subject")

                        MessageBox.Show("Added New Subject " & subjectName & ".", "New Subject Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clear()
                    Else
                        If txtSubjectId.Text = datatable.Rows(0).Item(0).ToString Then
                            MessageBox.Show("Subject ID already exists. Please enter a new subject ID.", "Subject ID Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            Dim insertQuery As String = "INSERT INTO subject values (" & subjectId & "," & subjectName & ");"
                            mainForm.run_query(insertQuery)
                            mainForm.table_load("subject")

                            MessageBox.Show("Added New Subject " & subjectName & ".", "New Subject Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            clear()
                        End If
                    End If


                End If
            End If
        End If
    End Sub

    Private Sub clear()
        txtSName.Text = ""
        txtSubjectId.Text = ""
    End Sub
End Class