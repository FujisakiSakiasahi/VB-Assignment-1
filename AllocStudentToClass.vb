Imports System.Data.SqlClient

Public Class AllocStudentToClass
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim studentId As Integer = comStudentId.SelectedItem
        Dim classId As String = "'" & comClassId.SelectedItem.ToString & "'"

        Dim insertQuery As String = "INSERT INTO enrolled VALUES (" & studentId & "," & classId & ");"
        Form2.run_query(insertQuery)
        Form2.table_load("enrolled")

        MessageBox.Show("Student " & studentId & " has been added to class " & classId & ".", "Student allocated", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AllocStudentToClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stuIdData As New SqlDataAdapter(New SqlCommand("SELECT stuId FROM student;", Form2.connection))
        Dim datatable As New DataTable()
        stuIdData.Fill(datatable)

        Dim classIdData As New SqlDataAdapter(New SqlCommand("SELECT classId FROM class;", Form2.connection))
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