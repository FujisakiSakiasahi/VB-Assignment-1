Imports System.Data
Imports System.Data.SqlClient

Public Class UpdateTeacher
    Dim teacherId As Integer
    Private Sub UpdateTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub Clear()
        'clear input controls
        txtTeacherName.Text = ""
        radMale.Checked = False
        radFemale.Checked = False
        btnUpdate.Enabled = False

        'disable controls
        txtTeacherName.Enabled = False
        radMale.Enabled = False
        radFemale.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

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
                    Dim da As SqlDataAdapter = New SqlDataAdapter(New SqlCommand("select * from teacher where teacherId = " & teacherId & " ;", mainForm.connection))
                    Dim datatable As New DataTable()
                    da.Fill(datatable)


                    If datatable.Rows.Count > 0 Then
                        'got result
                        'put the result into respective controls
                        txtTeacherName.Text = datatable.Rows(0).Item(1).ToString
                        Dim mORf As String = datatable.Rows(0).Item(2).ToString
                        If mORf = "m" Then
                            radMale.Checked = True
                            radFemale.Checked = False
                        Else
                            radMale.Checked = False
                            radFemale.Checked = True
                        End If

                        'enables the controls for editing
                        txtTeacherName.Enabled = True
                        radMale.Enabled = True
                        radFemale.Enabled = True
                        btnUpdate.Enabled = True
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtTeacherName.Text) Then ' checking for empty fields
            MessageBox.Show("'Teacher name' field cannot be empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim teacherName As String = "'" & txtTeacherName.Text & "'"
            Dim gender As String = "m"
            If radMale.Checked = True Then
                gender = "'m'"
            ElseIf radFemale.Checked = True Then
                gender = "'f'"
            End If

            Dim insertQuery As String = "update teacher set teacherName = " & teacherName & ", teacherGender = " & gender & " where teacherId = " & teacherId & ";"
            mainForm.run_query(insertQuery)
            mainForm.table_load("teacher")

            MessageBox.Show("Teacher " & teacherName & "'s Detail has updated", "Student Detail Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
        End If
    End Sub
End Class