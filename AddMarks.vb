Imports System.Data.SqlClient

Public Class AddMarks
    Private Sub AddMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New SqlDataAdapter(New SqlCommand("SELECT stuId FROM student;", Form2.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        Dim db As New SqlDataAdapter(New SqlCommand("SELECT subjectId FROM subject;", Form2.connection))
        Dim datatable2 As New DataTable()
        db.Fill(datatable2)

        If Not (datatable.Rows.Count > 0) Then
            MessageBox.Show("There are no students in the database. Please insert a new student before creating marks.", "Missing Required Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        ElseIf Not (datatable2.Rows.Count > 0) Then
            MessageBox.Show("There are no subjects in the database. Please insert a new subject before creating marks.", "Missing Required Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
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

            comStudentId.SelectedIndex = 0
            comSubjectId.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtExamYear.Text) Or String.IsNullOrEmpty(txtMark.Text) Then
            MessageBox.Show("One or more fields are empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtExamYear.Text) = False Then
            MessageBox.Show("Exam Year should not include characters or symbols. Please enter number in range of 2000 - 3000.", "Invalid Exam Year", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(txtMark.Text) = False Then
            MessageBox.Show("Marks should not include characters or symbols. Please enter number in range of 0 - 100.", "Invalid Marks", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim examYear As Integer = txtExamYear.Text
            If examYear < 2000 Or examYear > 3000 Then
                MessageBox.Show("Exam year out of range. Please enter number in range of 2000 - 3000.", "Invalid Exam Year", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim mark As Integer = txtMark.Text
                If mark < 0 Or mark > 100 Then
                    MessageBox.Show("Mark out of range. Please enter number in range of 0 - 100.", "Invalid Mark", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim studentId As Integer = comStudentId.SelectedItem
                    Dim subjectId As String = "'" & comSubjectId.SelectedItem.ToString & "'"

                    Dim insertQuery As String = "INSERT INTO marks VALUES (" & studentId & "," & subjectId & "," & examYear & "," & mark & ");"
                    Form2.run_query(insertQuery)
                    Form2.table_load("marks")

                    MessageBox.Show("Added New Mark.", "New Mark Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
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