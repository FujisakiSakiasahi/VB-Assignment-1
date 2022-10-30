Imports System.Data.SqlClient

Public Class AddPeriod
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim periodId As Integer = comPeriodId.SelectedItem
        Dim day As String = "'Mon'"

        ' assign day to what is selected from comDay
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

        ' retreive data from Database to check if data already exists in the Database
        Dim periodData As New SqlDataAdapter(New SqlCommand("SELECT * FROM period WHERE periodId = " & periodId & " AND periodDay = " & day & " AND classId = " & classId & " AND subjectId = " & subjectId & ";", mainForm.connection))
        Dim datatable As New DataTable()
        periodData.Fill(datatable)


        If Not (datatable.Rows.Count > 0) Then
            ' if data does not already exist in database, then retreive another list of data to check if there is clashing time
            Dim periodData2 As New SqlDataAdapter(New SqlCommand("SELECT * FROM period WHERE periodId = " & periodId & " AND periodDay = " & day & " AND classId = " & classId & ";", mainForm.connection))
            Dim datatable2 As New DataTable()
            periodData2.Fill(datatable2)

            If Not (datatable2.Rows.Count > 0) Then
                ' if not clashing time, insert into database
                Dim insertQuery As String = "INSERT INTO period VALUES (" & periodId & "," & day & "," & time & "," & classId & "," & subjectId & ");"
                mainForm.run_query(insertQuery)
                mainForm.table_load("period")

                MessageBox.Show("New period created.", "Period created", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf comPeriodId.SelectedItem.ToString = datatable2.Rows(0).Item(0).ToString And day.Substring(1, 3) = datatable2.Rows(0).Item(1).ToString And comClassId.SelectedItem.ToString = datatable2.Rows(0).Item(3).ToString Then
                'if there is clashing, show error
                MessageBox.Show("New period clashing with existing period. Please remove or updata existing period before inserting new period at this specific time.", "Period Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            If comPeriodId.SelectedItem.ToString = datatable.Rows(0).Item(0).ToString And day.Substring(1, 3) = datatable.Rows(0).Item(1).ToString And comClassId.SelectedItem.ToString = datatable.Rows(0).Item(3).ToString And comSubjectId.SelectedItem.ToString = datatable.Rows(0).Item(4).ToString Then
                ' if data already exists, show error
                MessageBox.Show("Period already exists. Please check if any input is incorrect.", "Period Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim insertQuery As String = "INSERT INTO period VALUES (" & periodId & "," & day & "," & time & "," & classId & "," & subjectId & ");"
                mainForm.run_query(insertQuery)
                mainForm.table_load("period")

                MessageBox.Show("New period created.", "Period created", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub comPeriodId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPeriodId.SelectedIndexChanged
        ' changes time according to period selected
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
    End Sub

    Private Sub AddPeriod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' retreives data from other tables to fill into combo boxes
        Dim classIdData As New SqlDataAdapter(New SqlCommand("SELECT classId FROM class;", mainForm.connection))
        Dim datatable As New DataTable()
        classIdData.Fill(datatable)

        Dim subjectIdData As New SqlDataAdapter(New SqlCommand("SELECT subjectId FROM subject;", mainForm.connection))
        Dim datatable2 As New DataTable()
        subjectIdData.Fill(datatable2)

        If Not (datatable.Rows.Count > 0) Then
            ' if there is no class in database, show error
            MessageBox.Show("There are no class in the database. Please insert a new class before creating period.", "Missing Required Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        ElseIf Not (datatable2.Rows.Count > 0) Then
            ' if there is no subject in database, show error
            MessageBox.Show("There are no subject in the database. Please insert a new subject before creating period.", "Missing Required Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
            ' fills in the combo boxes
            Dim i As Integer = 0
            Do While i < datatable.Rows.Count
                comClassId.Items.Add(datatable.Rows(i).Item(0).ToString)
                i += 1
            Loop

            Dim j As Integer = 0
            Do While j < datatable2.Rows.Count
                comSubjectId.Items.Add(datatable2.Rows(j).Item(0).ToString)
                j += 1
            Loop

            comPeriodId.SelectedIndex = 0
            comDay.SelectedIndex = 0
            comClassId.SelectedIndex = 0
            comSubjectId.SelectedIndex = 0
        End If
    End Sub
End Class