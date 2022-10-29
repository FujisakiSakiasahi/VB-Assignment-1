Public Class AddClass
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtClassId.Text) Then
            MessageBox.Show("One or more fields are empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtClassId.Text.Length > 2 Then
            MessageBox.Show("Class ID can only support up to a maximum of 2 characters.", "Invalid Class ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim classId As String = "'" & txtClassId.Text & "'"

            Dim insertQuery As String = "INSERT INTO class values (" & classId & ");"
            Form2.run_query(insertQuery)
            Form2.table_load("class")

            MessageBox.Show("Added New Class " & classId & ".", "New Class Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()
        End If
    End Sub

    Private Sub clear()
        txtClassId.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class