Imports System.Data.SqlClient

Public Class AddPeriod
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim periodId As Integer = comPeriodId.SelectedItem
        Dim day As String = "'Mon'"

        Select Case comDay.SelectedIndex
            Case 0
                day = "'Mon'"
            Case 1
                day = "'Tue'"
            Case 2
                day = "'Wed'"
            Case 3
                day = "'Thu'"
            Case 4
                day = "'Fri'"
        End Select

        Dim time As String = "'" & txtTime.Text & "'"
        Dim classId As String = "'" & comClassId.SelectedItem.ToString & "'"
        Dim subjectId As String = "'" & comSubjectId.SelectedItem.ToString & "'"

        Dim insertQuery As String = "INSERT INTO period VALUES (" & periodId & "," & day & "," & time & "," & classId & "," & subjectId & ");"
        Form2.run_query(insertQuery)
        Form2.table_load("period")

        MessageBox.Show("New period created.", "Period created", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub comPeriodId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPeriodId.SelectedIndexChanged
        Select Case comPeriodId.SelectedIndex
            Case 0
                txtTime.Text = "7:30"
            Case 1
                txtTime.Text = "8:00"
            Case 2
                txtTime.Text = "8:30"
            Case 3
                txtTime.Text = "9:00"
            Case 4
                txtTime.Text = "9:30"
            Case 5
                txtTime.Text = "10:00"
            Case 6
                txtTime.Text = "10:30"
            Case 7
                txtTime.Text = "11:00"
            Case 8
                txtTime.Text = "11:30"
            Case 9
                txtTime.Text = "12:00"
            Case 10
                txtTime.Text = "12:30"
            Case 11
                txtTime.Text = "1:30"
            Case 12
        End Select
    End Sub

    Private Sub AddPeriod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim classIdData As New SqlDataAdapter(New SqlCommand("SELECT classId FROM class;", Form2.connection))
        Dim datatable As New DataTable()
        classIdData.Fill(datatable)

        Dim i As Integer = 0
        Do While i < datatable.Rows.Count
            comClassId.Items.Add(datatable.Rows(i).Item(0).ToString)
            i += 1
        Loop

        Dim subjectIdData As New SqlDataAdapter(New SqlCommand("SELECT subjectId FROM subject;", Form2.connection))
        Dim datatable2 As New DataTable()
        subjectIdData.Fill(datatable2)

        Dim j As Integer = 0
        Do While j < datatable2.Rows.Count
            comSubjectId.Items.Add(datatable2.Rows(j).Item(0).ToString)
            j += 1
        Loop


        comPeriodId.SelectedIndex = 0
        comDay.SelectedIndex = 0
        comClassId.SelectedIndex = 0
        comSubjectId.SelectedIndex = 0
    End Sub

    ' remember to change Day, Class ID and Subject Id to dropdown list, with Class ID being normal class id
End Class