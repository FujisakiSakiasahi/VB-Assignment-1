Imports System.Data.SqlClient

Public Class AllocStudentToClass
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim studentId As Integer = comStudentId.SelectedItem
        Dim classId As String = "'" & comClassId.SelectedItem.ToString & "'"
        Dim stuIdAndClassIdData As New SqlDataAdapter(New SqlCommand("Select * FROM enrolled WHERE studentId = " & studentId & "AND classId = " & classId & ";", mainForm.connection))
        Dim datatable As New DataTable()
        stuIdAndClassIdData.Fill(datatable)


        If Not (datatable.Rows.Count > 0) Then
            ' if there is no existing data that has the same combination of studentId and classId inputted, create new datatable
            Dim stuIdData As New SqlDataAdapter(New SqlCommand("Select studentId FROM enrolled WHERE studentId = " & studentId & ";", mainForm.connection))
            Dim datatable2 As New DataTable()
            stuIdData.Fill(datatable2)

            If Not (datatable2.Rows.Count > 0) Then
                ' if studentId does not already exist in the table, create new data
                Dim insertQuery2 As String = "INSERT INTO enrolled VALUES (" & studentId & "," & classId & ");"
                mainForm.run_query(insertQuery2)
                mainForm.table_load("enrolled")

                MessageBox.Show("Student " & studentId & " has been added to class " & classId & ".", "Student allocated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf comStudentId.SelectedItem.ToString = datatable2.Rows(0).Item(0).ToString Then
                ' if studentId already exist in the table, tell user to remove the data to reassign
                MessageBox.Show("Student ID already assiged to a class. Please remove the student from the current class he/she is in to assign them into a new class", "Student ID Already Assigned To A Class", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf comStudentId.SelectedItem.ToString = datatable.Rows(0).Item(0).ToString And comClassId.SelectedItem.ToString = datatable.Rows(0).Item(1).ToString Then
            ' if there is an existing data that has the same combination of studentId and classId inputted, inform user that student already exist in the class
            MessageBox.Show("Student ID already exists in the class.", "Student ID Already Exists In Class", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AllocStudentToClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stuIdData As New SqlDataAdapter(New SqlCommand("SELECT stuId FROM student;", mainForm.connection))
        Dim datatable As New DataTable()
        stuIdData.Fill(datatable)

        Dim classIdData As New SqlDataAdapter(New SqlCommand("SELECT classId FROM class;", mainForm.connection))
        Dim datatable2 As New DataTable()
        classIdData.Fill(datatable2)

        If Not (datatable.Rows.Count > 0) Then
            MessageBox.Show("There are no students in the database. Please insert a new student before assigning student to a class.", "Missing Required Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        ElseIf Not (datatable2.Rows.Count > 0) Then
            MessageBox.Show("There are no class in the database. Please insert a new class before assigning student to a class.", "Missing Required Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
            Dim i As Integer = 0
            Do While i < datatable.Rows.Count
                comStudentId.Items.Add(datatable.Rows(i).Item(0).ToString)
                i += 1
            Loop

            Dim j As Integer = 0
            Do While j < datatable2.Rows.Count
                comClassId.Items.Add(datatable2.Rows(j).Item(0).ToString)
                j += 1
            Loop

            comStudentId.SelectedIndex = 0
            comClassId.SelectedIndex = 0
        End If
    End Sub
End Class