Public Class StudentAddForm
    Private Sub StudentAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radMale.Checked = True
        ComYear.SelectedIndex = 0
        comTeam.SelectedIndex = 0
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim studentId As Integer = txtStudentId.Text
        Dim stuName As String = "'" & txtStuName.Text & "'"
        Dim age As Integer = txtAge.Text
        Dim yearEnrolled As Integer = ComYear.SelectedItem.ToString
        Dim gender As String = "m"
        If radMale.Checked = True Then
            gender = "'m'"
        ElseIf radFemale.Checked = True Then
            gender = "'f'"
        End If
        Dim teamColour As String = "'" & comTeam.SelectedItem.ToString & "'"



        Dim insertQuery As String = "INSERT INTO student values (" & studentId & "," & stuName & "," & age & "," & yearEnrolled & "," & gender & "," & teamColour & ");"
        Form2.run_query(insertQuery)
        Form2.table_load("student")

        MessageBox.Show("Added Student")
        clear()

    End Sub

    Private Sub clear()
        txtStuName.Text = ""
        txtStudentId.Text = ""
        txtAge.Text = ""
        radFemale.Checked = False
        radMale.Checked = True
        ComYear.SelectedIndex = 0
        comTeam.SelectedIndex = 0
    End Sub

    'remember to add class using dropdown
End Class