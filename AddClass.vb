Imports System.Data.SqlClient

Public Class AddClass
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtClassId.Text) Then
            ' if field is empty, show error message
            MessageBox.Show("One or more fields are empty. Please provide information for these fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtClassId.Text.Length > 2 Then
            ' if class id too much characters, show error
            MessageBox.Show("Class ID can only support up to a maximum of 2 characters.", "Invalid Class ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' if input is valid, then start initalizing data
            Dim classId As String = "'" & txtClassId.Text & "'"

            ' retreive data from database to check if data already exist in the database
            Dim classIdData As New SqlDataAdapter(New SqlCommand("SELECT classId FROM class WHERE classId = " & classId & ";", mainForm.connection))
            Dim datatable As New DataTable()
            classIdData.Fill(datatable)

            If Not (datatable.Rows.Count > 0) Then
                ' if data does not already exist in database, insert new data into database
                Dim retreiveQuery As String = "INSERT INTO class values (" & classId & ");"
                mainForm.run_query(retreiveQuery)
                mainForm.table_load("class")

                MessageBox.Show("Added New Class " & classId & ".", "New Class Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            Else
                If txtClassId.Text = datatable.Rows(0).Item(0).ToString Then
                    ' if already exist in database, show error message
                    MessageBox.Show("Class ID already exists. Please enter a new class ID.", "Class ID Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim insertQuery As String = "INSERT INTO class values (" & classId & ");"
                    mainForm.run_query(insertQuery)
                    mainForm.table_load("class")

                    MessageBox.Show("Added New Class " & classId & ".", "New Class Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                End If
            End If
        End If
    End Sub

    Private Sub clear()
        txtClassId.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class