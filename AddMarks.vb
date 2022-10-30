Imports System.Data.SqlClient

Public Class AddMarks
    Private Sub AddMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' retreive data from Database to check if data already exists in the Database
        Dim da As New SqlDataAdapter(New SqlCommand("SELECT stuId FROM student;", mainForm.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        Dim db As New SqlDataAdapter(New SqlCommand("SELECT subjectId FROM subject;", mainForm.connection))
        Dim datatable2 As New DataTable()
        db.Fill(datatable2)

        If Not (datatable.Rows.Count > 0) Then
            ' if there are no students in database, show error message then close the form
            MessageBox.Show("There are no students in the database. Please insert a new student before creating marks.", "Missing Required Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        ElseIf Not (datatable2.Rows.Count > 0) Then
            ' if there are no subjects in the database, show error message then close the form
            MessageBox.Show("There are no subjects in the database. Please insert a new subject before creating marks.", "Missing Required Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
            ' fill the combo boxes with data that will be selected
            Dim i As Integer = 0
            Do While i < datatable.Rows.Count
                comStudentId.Items.Add(datatable.Rows(i).Item(0).ToString)
                i += 1
            Loop

            Dim j As Integer = 0
            Do While j < datatable2.Rows.Count
                comSubjectId.Items.Add(datatable2.Rows(j).Item(0).ToString)
                j += 1
            Loop

            ' select values on load
            comStudentId.SelectedIndex = 0
            comSubjectId.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtExamYear.Text) Or String.IsNullOrEmpty(txtMark.Text) Then
            ' if any fields empty, show error
            MessageBox.Show("One or more fields are empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtExamYear.Text) = False Then
            ' if exam year is not numeric, show error
            MessageBox.Show("Exam Year should not include characters or symbols. Please enter number in range of 2000 - 3000.", "Invalid Exam Year", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtMark.Text) = False Then
            ' if mark is not numeric, show error
            MessageBox.Show("Marks should not include characters or symbols. Please enter number in range of 0 - 100.", "Invalid Marks", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim examYear As Integer = txtExamYear.Text
            If examYear < 2000 Or examYear > 3000 Then
                ' if exam year out of range, show error
                MessageBox.Show("Exam year out of range. Please enter number in range of 2000 - 3000.", "Invalid Exam Year", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim mark As Integer = txtMark.Text
                If mark < 0 Or mark > 100 Then
                    ' if mark out of range, show error
                    MessageBox.Show("Mark out of range. Please enter number in range of 0 - 100.", "Invalid Mark", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim studentId As Integer = comStudentId.SelectedItem
                    Dim subjectId As String = "'" & comSubjectId.SelectedItem.ToString & "'"

                    ' retreive data from Database to check if data already exists in the Database
                    Dim markData As New SqlDataAdapter(New SqlCommand("SELECT * FROM marks WHERE studentId = " & studentId & " AND subjectId = " & subjectId & " AND examyear = " & examYear & ";", mainForm.connection))
                    Dim datatable As New DataTable()
                    markData.Fill(datatable)

                    If Not (datatable.Rows.Count > 0) Then
                        'if data not already exist in database, add into database
                        Dim insertQuery As String = "INSERT INTO marks VALUES (" & studentId & "," & subjectId & "," & examYear & "," & mark & ");"
                        mainForm.run_query(insertQuery)
                        mainForm.table_load("marks")

                        MessageBox.Show("Added New Mark.", "New Mark Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clear()
                    Else
                        If comStudentId.SelectedItem.ToString = datatable.Rows(0).Item(0).ToString And comSubjectId.SelectedItem.ToString = datatable.Rows(0).Item(1).ToString And txtExamYear.Text = datatable.Rows(0).Item(2).ToString Then
                            ' if mark already exist, show error
                            MessageBox.Show("Mark already exists. Please check if the student ID, subject ID, and Exam year inputted is correct.", "Mark Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub clear()
        txtExamYear.Text = ""
        txtMark.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class