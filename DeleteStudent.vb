Imports System.Data
Imports System.Data.SqlClient

Public Class DeleteStudent
    Dim studentId As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'check the student id that will be use for searching
        If String.IsNullOrEmpty(txtStudentId.Text) Then
            MessageBox.Show("'Student ID' field cannot be empty to search.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If IsNumeric(txtStudentId.Text) = False Then
                MessageBox.Show("Student ID should not include characters or symbols. Please enter number in range of 10000 - 99999.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                studentId = txtStudentId.Text
                If Not (studentId >= 10000 And studentId <= 99999) Then
                    MessageBox.Show("Student ID out of range. Please enter a number in the range of 10000 - 99999", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    studentId = txtStudentId.Text

                    Dim da As SqlDataAdapter = New SqlDataAdapter(New SqlCommand("select * from student where stuId = " & studentId & " ;", Form2.connection))
                    Dim datatable As New DataTable()
                    da.Fill(datatable)

                    If datatable.Rows.Count > 0 Then
                        'got result
                        'put the result into respective controls
                        txtStuName.Text = datatable.Rows(0).Item(1).ToString
                        txtAge.Text = datatable.Rows(0).Item(2).ToString
                        txtYearEnrolled.Text = datatable.Rows(0).Item(3).ToString
                        Dim gender As String = = datatable.Rows(0).Item(4).ToString
                        If gender = "f" Then
                            txtGender.Text = "Female"
                        Else
                            txtGender.Text = "Male"
                        End If

                        txtTeam.Text = datatable.Rows(0).Item(5).ToString

                        'enables the controls for editing
                        txtStuName.Enabled = True
                        txtAge.Enabled = True
                        txtYearEnrolled.Enabled = True
                        txtGender.Enabled = True
                        txtTeam.Enabled = True
                    Else
                        'no result
                        clear()

                        'error message for no result
                        MessageBox.Show("Student with student id '" & studentId & "' is not in the databse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub clear()
        'reset control
        txtStuName.Text = ""
        txtStudentId.Text = ""
        txtAge.Text = ""
        txtYearEnrolled.Text = ""
        txtGender.Text = ""
        txtTeam.Text = ""

        'disable the controls
        txtStuName.Enabled = False
        txtAge.Enabled = False
        txtYearEnrolled.Enabled = False
        txtGender.Enabled = False
        txtTeam.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub DeleteStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim proceedDelete As Integer = MessageBox.Show("All data that binds with student with student id " & studentId & " will also be deleted", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If proceedDelete = 6 Then
            Dim insertQuery As String = "delete from marks where stuId = " & studentId
            Form2.run_query(insertQuery)
            insertQuery = "delete from enrolled where stuId = " & studentId
            Form2.run_query(insertQuery)
            insertQuery = "delete from student where stuId = " & studentId
            Form2.run_query(insertQuery)
            Form2.table_load("student")

            MessageBox.Show("Student with student ID" & studentId & "has been deleted.", "Student Information Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()
        End If
    End Sub
End Class