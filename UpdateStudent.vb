Imports System.Data.SqlClient
Imports System.Data

Public Class UpdateStudent
    Dim studentId As Integer

    Private Sub UpdateStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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
                        Dim mORf As String = datatable.Rows(0).Item(4).ToString
                        If mORf = "m" Then
                            radMale.Checked = True
                            radFemale.Checked = False
                        Else
                            radMale.Checked = False
                            radFemale.Checked = True
                        End If
                        Dim team() As String = {"red", "blue", "yellow", "green"}
                        Dim studentTeam = datatable.Rows(0).Item(5).ToString
                        Select Case studentTeam
                            Case team(0)
                                comTeam.SelectedIndex = 0
                            Case team(1)
                                comTeam.SelectedIndex = 1
                            Case team(2)
                                comTeam.SelectedIndex = 2
                            Case team(3)
                                comTeam.SelectedIndex = 3
                            Case Else
                                MsgBox("some error occured " & studentTeam, MsgBoxStyle.Exclamation)
                        End Select

                        'enables the controls for editing
                        txtStuName.Enabled = True
                        txtAge.Enabled = True
                        txtYearEnrolled.Enabled = True
                        radMale.Enabled = True
                        radFemale.Enabled = True
                        comTeam.Enabled = True

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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'error checking, after error chceking updating data
        If String.IsNullOrEmpty(txtStuName.Text) Or String.IsNullOrEmpty(txtAge.Text) Or String.IsNullOrEmpty(txtYearEnrolled.Text) Then
            MessageBox.Show("One or more fields are empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                            Dim teamColour As String = "'" & comTeam.SelectedItem.ToString.ToLower & "'"



                            Dim insertQuery As String = "update student set stuName = " & stuName & ", age = " & age & ", enrollyear = " & yearEnrolled & ", stuGender = " & gender & ", team = " & teamColour & " where stuId = " & studentId & ";"
                            Form2.run_query(insertQuery)
                            Form2.table_load("student")

                            MessageBox.Show("Student " & stuName & "'s Detail has updated", "Student Detail Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            clear()
                        End If
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
        radMale.Checked = False
        radFemale.Checked = False
        comTeam.SelectedIndex = 0

        'disable the controls
        txtStuName.Enabled = False
        txtAge.Enabled = False
        txtYearEnrolled.Enabled = False
        radMale.Enabled = False
        radFemale.Enabled = False
        comTeam.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class