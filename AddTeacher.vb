Public Class AddTeacher
    Private Sub AddTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radMale.Checked = True
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class