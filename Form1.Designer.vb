<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login_page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.username_input_textfield = New System.Windows.Forms.TextBox()
        Me.password_input_textfield = New System.Windows.Forms.TextBox()
        Me.login_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(50, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SCHOOL DATABASE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password: "
        '
        'username_input_textfield
        '
        Me.username_input_textfield.Location = New System.Drawing.Point(159, 94)
        Me.username_input_textfield.Name = "username_input_textfield"
        Me.username_input_textfield.Size = New System.Drawing.Size(100, 23)
        Me.username_input_textfield.TabIndex = 3
        '
        'password_input_textfield
        '
        Me.password_input_textfield.Location = New System.Drawing.Point(159, 138)
        Me.password_input_textfield.Name = "password_input_textfield"
        Me.password_input_textfield.Size = New System.Drawing.Size(100, 23)
        Me.password_input_textfield.TabIndex = 4
        '
        'login_button
        '
        Me.login_button.Location = New System.Drawing.Point(121, 196)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(75, 23)
        Me.login_button.TabIndex = 5
        Me.login_button.Text = "Login"
        Me.login_button.UseVisualStyleBackColor = True
        '
        'login_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 290)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.password_input_textfield)
        Me.Controls.Add(Me.username_input_textfield)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login_page"
        Me.Text = "School Databse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents username_input_textfield As TextBox
    Friend WithEvents password_input_textfield As TextBox
    Friend WithEvents login_button As Button
End Class
