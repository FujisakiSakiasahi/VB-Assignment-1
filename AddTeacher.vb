Public Class AddTeacher
    Private Sub AddTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radMale.Checked = True
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtTeacherName.Text) Or String.IsNullOrEmpty(txtTeacherId.Text) Then ' checking for empty fields
            MessageBox.Show("One or more fields are empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If IsNumeric(txtTeacherId.Text) = False Then
                MessageBox.Show("Teacher ID should not include characters or symbols. Please enter number in range of 1000 - 9999.", "Invalid Teacher ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim teacherId As Integer = txtTeacherId.Text ' TODO: add new checking that checks if id already exists in the table !!!

                If Not (teacherId >= 1000 And teacherId <= 9999) Then   ' id range checking
                    MessageBox.Show("Teacher ID out of range. Please enter number in range of 1000 - 9999.", "Invalid Teacher ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim teacherName As String = "'" & txtTeacherName.Text & "'"

                    Dim gender As String = "m"
                    If radMale.Checked = True Then
                        gender = "'m'"
                    ElseIf radFemale.Checked = True Then
                        gender = "'f'"
                    End If

                    Dim insertQuery As String = "INSERT INTO teacher values (" & teacherId & "," & teacherName & "," & gender & ");"
                    Form2.run_query(insertQuery)
                    Form2.table_load("teacher")

                    MessageBox.Show("Added New Teacher " & teacherName & ".", "New Teacher Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                End If
            End If
        End If
    End Sub

    Private Sub clear() ' clears input fields 
        txtTeacherName.Text = ""
        txtTeacherId.Text = ""
        radMale.Checked = True
        radFemale.Checked = False
    End Sub
End Class