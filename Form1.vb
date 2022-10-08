Public Class login_page
    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        'Getting input text
        Dim username_input As String = username_input_textfield.Text()
        Dim password_input As String = password_input_textfield.Text()

        'Username and Password Checking
        If username_input = "" And password_input = "" Then 'the username and password need to be set
            'Showing main page form
            Form2.Show()

            'Hiding login page form
            'Need to be test out later
            'Me.Hide()
        End If

    End Sub
End Class
