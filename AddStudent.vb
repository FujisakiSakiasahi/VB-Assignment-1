Imports System.Data.SqlClient
Public Class AddStudent
    Private Sub StudentAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radMale.Checked = True
        comTeam.SelectedIndex = 0
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If String.IsNullOrEmpty(txtStudentId.Text) Or String.IsNullOrEmpty(txtStuName.Text) Or String.IsNullOrEmpty(txtAge.Text) Or String.IsNullOrEmpty(txtYearEnrolled.Text) Then
            MessageBox.Show("One or more fields are empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If IsNumeric(txtStudentId.Text) = False Then
                MessageBox.Show("Student ID should not include characters or symbols. Please enter number in range of 10000 - 99999.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim studentId As Integer = txtStudentId.Text
                If Not (studentId >= 10000 And studentId <= 99999) Then
                    MessageBox.Show("Student ID out of range. Please enter a number in the range of 10000 - 99999", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If IsNumeric(txtAge.Text) = False Then
                        MessageBox.Show("Age should not include characters or symbols. Please enter number in range of 1 - 90.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim age As Integer = txtAge.Text
                        If Not (age >= 1 And age <= 99) Then
                            MessageBox.Show("Age out of range. Please enter number in range of 1 - 99.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            If IsNumeric(txtYearEnrolled.Text) = False Then
                                MessageBox.Show("Year should not include characters or symbols. Please enter number in range of 2000 - 3000.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Else
                                Dim yearEnrolled As Integer = txtYearEnrolled.Text
                                If Not (yearEnrolled >= 2000 And yearEnrolled <= 3000) Then
                                    MessageBox.Show("Year out of range. Please enter number in range of 2000 - 3000.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Else
                                    Dim stuName As String = "'" & txtStuName.Text & "'"
                                    Dim gender As String = "m"
                                    If radMale.Checked = True Then
                                        gender = "'m'"
                                    ElseIf radFemale.Checked = True Then
                                        gender = "'f'"
                                    End If
                                    Dim teamColour As String = "'" & comTeam.SelectedItem.ToString & "'"

                                    Dim studentIdData As New SqlDataAdapter(New SqlCommand("SELECT stuId FROM student WHERE stuId = " & studentId & ";", Form2.connection))
                                    Dim datatable As New DataTable()
                                    studentIdData.Fill(datatable)

                                    If Not (datatable.Rows.Count > 0) Then
                                        Dim insertQuery As String = "INSERT INTO student values (" & studentId & "," & stuName & "," & age & "," & yearEnrolled & "," & gender & "," & teamColour & ");"
                                        Form2.run_query(insertQuery)
                                        Form2.table_load("student")

                                        MessageBox.Show("Added New Student " & stuName & ".", "New Student Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        clear()
                                    Else
                                        If txtStudentId.Text = datatable.Rows(0).Item(0).ToString Then
                                            MessageBox.Show("Student ID already exists. Please enter a new student ID.", "Student ID Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Else
                                            Dim insertQuery As String = "INSERT INTO student values (" & studentId & "," & stuName & "," & age & "," & yearEnrolled & "," & gender & "," & teamColour & ");"
                                            Form2.run_query(insertQuery)
                                            Form2.table_load("student")

                                            MessageBox.Show("Added New Student " & stuName & ".", "New Student Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            clear()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub clear()
        txtStuName.Text = ""
        txtStudentId.Text = ""
        txtAge.Text = ""
        txtYearEnrolled.Text = ""
        radFemale.Checked = False
        radMale.Checked = True
        comTeam.SelectedIndex = 0
    End Sub

    'remember to add class using dropdown
End Class