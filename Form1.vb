Public Class login_page
    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        'Getting input text
        Dim username_input As String = username_input_textfield.Text()
        Dim password_input As String = password_input_textfield.Text()
        Static count As Integer = 1

        'Username and Password Checking
        If username_input = "" And password_input = "" Then 'the username and password need to be set 
            'Showing main page form
            Form2.Show()

            'Hiding login page form
            'Need to be test out later
            Me.Hide()
        ElseIf count = 3 Then
            'MessageBox.Show(Message, Title, MessageBoxButtons.<button of choice>, MessageBoxIcon.<Icon of choice>)
            MessageBox.Show("Incorrect for 3 times, exiting app", "Exiting App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            MessageBox.Show("Username or password is incorrect. Please try again", "Invalid username or password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            count += 1
        End If

    End Sub
End Class
