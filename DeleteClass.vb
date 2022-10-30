Imports System.Data
Imports System.Data.SqlClient

Public Class DeleteClass
    Private Sub DeleteClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load classes list into combo box
        load_combobox()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim classId As String = comClassId.SelectedItem
        Dim proceedDelete As Integer = MessageBox.Show("All data that binds with class with class id " & classId & " will also be deleted", "Delete Class", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If proceedDelete = 6 Then
            Dim insertQuery As String = "delete from enrolled where classId = '" & classId & "'"
            mainForm.run_query(insertQuery)
            insertQuery = "delete from period where classId = '" & classId & "'"
            mainForm.run_query(insertQuery)
            insertQuery = "delete from class where classId = '" & classId & "'"
            mainForm.run_query(insertQuery)
            mainForm.table_load("enrolled")

            MessageBox.Show("Class with class ID " & classId & " has been deleted.", "Class Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            load_combobox()
        End If
    End Sub

    Private Sub load_combobox()
        comClassId.Items.Clear()

        Dim da As New SqlDataAdapter(New SqlCommand("select * from class", mainForm.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        If datatable.Rows.Count > 0 Then
            For i As Integer = 0 To datatable.Rows.Count - 1
                comClassId.Items.Add(datatable.Rows(i).Item(0))
            Next

            comClassId.SelectedIndex = 0
        Else
            MessageBox.Show("There is no class in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
End Class