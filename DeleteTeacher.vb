Imports System.Data
Imports System.Data.SqlClient

Public Class DeleteTeacher
    Dim teacherId As Integer
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrEmpty(txtTeacherId.Text) Then ' checking for empty fields
            MessageBox.Show("'Teacher ID' field cannot be empty to search.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If IsNumeric(txtTeacherId.Text) = False Then
                MessageBox.Show("Teacher ID should not include characters or symbols. Please enter number in range of 1000 - 9999.", "Invalid Teacher ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                teacherId = txtTeacherId.Text

                If Not (teacherId >= 1000 And teacherId <= 9999) Then   ' id range checking
                    MessageBox.Show("Teacher ID out of range. Please enter number in range of 1000 - 9999.", "Invalid Teacher ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim da As SqlDataAdapter = New SqlDataAdapter(New SqlCommand("select * from teacher where teacherId = " & teacherId & " ;", Form2.connection))
                    Dim datatable As New DataTable()
                    da.Fill(datatable)


                    If datatable.Rows.Count > 0 Then
                        'got result
                        'put the result into respective controls
                        txtTeacherName.Text = datatable.Rows(0).Item(1).ToString
                        Dim gender As String = datatable.Rows(0).Item(2).ToString
                        If gender = "f" Then
                            txtTeacherGender.Text = "Female"
                        Else
                            txtTeacherGender.Text = "Male"
                        End If


                        'enable the controls
                        txtTeacherName.Enabled = True
                        txtTeacherGender.Enabled = True
                    Else
                        'no result
                        Clear()

                        'error message for no result
                        MessageBox.Show("Teacher with teacher id '" & teacherId & "' is not in the databse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim proceedDelete As Integer = MessageBox.Show("All data that binds with teacher with teacher id " & teacherId & " will also be deleted", "Delete Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If proceedDelete = 6 Then
            Dim insertQuery As String = "delete from teacher where teacherId = " & teacherId
            Form2.run_query(insertQuery)
            Form2.table_load("teacher")

            MessageBox.Show("Teacher with teacher ID" & teacherId & "has been deleted.", "Teacher Information Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Clear()
        'clear the controls
        txtTeacherId.Text = ""
        txtTeacherName.Text = ""
        txtTeacherGender.Text = ""

        'disable the controls
        txtTeacherName.Enabled = False
        txtTeacherGender.Enabled = False
    End Sub
End Class