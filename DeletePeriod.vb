Imports System.Data
Imports System.Data.SqlClient

Public Class DeletePeriod
    Private Sub DeletePeriod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_PeriodIdComboBox()
    End Sub

    Private Sub load_PeriodIdComboBox()
        comPeriodId.Items.Clear()
        Dim da As New SqlDataAdapter(New SqlCommand("SELECT distinct periodId FROM period;", Form2.connection))
        Dim datatable As New DataTable()
        da.Fill(datatable)

        If datatable.Rows.Count > 0 Then
            For i As Integer = 0 To datatable.Rows.Count - 1
                comPeriodId.Items.Add(datatable.Rows(i).Item(0))
            Next

            comPeriodId.SelectedIndex = 0
        Else
            MessageBox.Show("There are no period in the database. ", "No period record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If
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
                txtTime.Text = "1:00"
            Case 12
                txtTime.Text = "1:30"
        End Select

        comDay.Items.Clear()
        Dim da As New SqlDataAdapter(New SqlCommand("SELECT distinct periodDay FROM period where periodId = " & comPeriodId.SelectedItem & ";", Form2.connection))
        Dim datatable As New DataTable()
        da.Fill(DataTable)

        For i As Integer = 0 To datatable.Rows.Count - 1
            comDay.Items.Add(datatable.Rows(i).Item(0))
        Next

        comDay.SelectedIndex = 0
    End Sub

    Private Sub comDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comDay.SelectedIndexChanged
        comClassId.Items.Clear()
        Dim data As New SqlDataAdapter(New SqlCommand("SELECT distinct classId FROM period where periodId = " & comPeriodId.SelectedItem & "AND periodDay = '" & comDay.SelectedItem & "' ;", Form2.connection))
        Dim datatable As New DataTable()
        data.Fill(datatable)

        For i As Integer = 0 To datatable.Rows.Count - 1
            comClassId.Items.Add(datatable.Rows(i).Item(0))
        Next

        comClassId.SelectedIndex = 0
    End Sub

    Private Sub comClassId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comClassId.SelectedIndexChanged
        Dim data As New SqlDataAdapter(New SqlCommand("SELECT subjectId FROM period where periodId = " & comPeriodId.SelectedItem & "AND periodDay = '" & comDay.SelectedItem & "' AND classId = '" & comClassId.SelectedItem & "' ;", Form2.connection))
        Dim datatable As New DataTable()
        data.Fill(datatable)

        txtSubjectId.Text = datatable.Rows(0).Item(0)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim insertQuery As String = "delete from period  where periodId = " & comPeriodId.SelectedItem & "AND periodDay = '" & comDay.SelectedItem & "' AND classId = '" & comClassId.SelectedItem & "' ;"
        Form2.run_query(insertQuery)
        Form2.table_load("period")

        MessageBox.Show("The period " & (comPeriodId.SelectedIndex + 1) & " on " & comDay.SelectedItem & " at " & txtTime.Text & " for class " & comClassId.SelectedItem & "for subject " & txtSubjectId.Text & "has been deleted.", "Period Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        load_PeriodIdComboBox()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class