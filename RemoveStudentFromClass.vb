Imports System.Data
Imports System.Data.SqlClient

Public Class RemoveStudentFromClass
    Private Sub RemoveStudentFromClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disable student id combo box
        comStudentId.Enabled = False

        'load class id
        Dim classIdData As New SqlDataAdapter(New SqlCommand("SELECT classId FROM class;", mainForm.connection))
        Dim datatable As New DataTable()
        classIdData.Fill(datatable)

        If datatable.Rows.Count > 0 Then
            Dim j As Integer = 0
            Do While j < datatable.Rows.Count
                comClassId.Items.Add(datatable.Rows(j).Item(0).ToString)
                j += 1
            Loop

            comClassId.SelectedIndex = 0
        Else
            MessageBox.Show("There are no class in the database. Please insert a new class before assigning student to a class.", "No Class Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim classId As String = comClassId.SelectedItem
        Dim studentId As String = comStudentId.SelectedItem
        Dim proceedDelete As Integer = MessageBox.Show("Student with student ID " & studentId & " will be removed from class with class ID " & classId & ".", "Remove student from class", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If proceedDelete = 6 Then
            Dim insertQuery As String = "delete from enrolled where classId = '" & classId & "'AND studentID = '" & studentId & "' ;"
            mainForm.run_query(insertQuery)
            mainForm.table_load("enrolled")

            MessageBox.Show("Student with student ID " & studentId & " has been removed from class with class ID " & classId & ".", "Student Removed from Class.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_studentList()
        End If
    End Sub

    Private Sub comClassId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comClassId.SelectedIndexChanged
        'load student id of the selected class
        load_studentList()
    End Sub

    Private Sub load_studentList()
        comStudentId.Items.Clear()

        Dim stuIdData As New SqlDataAdapter(New SqlCommand("SELECT studentId FROM enrolled where classId = '" & comClassId.SelectedItem & "' ;", mainForm.connection))
        Dim datatable As New DataTable()
        stuIdData.Fill(datatable)

        If datatable.Rows.Count > 0 Then
            Dim i As Integer = 0
            Do While i < datatable.Rows.Count
                comStudentId.Items.Add(datatable.Rows(i).Item(0).ToString)
                i += 1
            Loop

            'enable the combo box
            comStudentId.Enabled = True
            btnRemove.Enabled = True
            comStudentId.SelectedIndex = 0
        Else
            MessageBox.Show("There are no students in the selected class.", "No Student Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            comStudentId.Enabled = False
            btnRemove.Enabled = False
            comStudentId.Items.Clear()
        End If
    End Sub
End Class