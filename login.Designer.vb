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
        Me.school_name_label = New System.Windows.Forms.Label()
        Me.username_label = New System.Windows.Forms.Label()
        Me.pwd_label = New System.Windows.Forms.Label()
        Me.username_input_textfield = New System.Windows.Forms.TextBox()
        Me.password_input_textfield = New System.Windows.Forms.TextBox()
        Me.login_button = New System.Windows.Forms.Button()
        Me.school_logo_image = New System.Windows.Forms.PictureBox()
        CType(Me.school_logo_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'school_name_label
        '
        Me.school_name_label.AutoSize = True
        Me.school_name_label.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.school_name_label.Location = New System.Drawing.Point(334, 31)
        Me.school_name_label.Name = "school_name_label"
        Me.school_name_label.Size = New System.Drawing.Size(279, 32)
        Me.school_name_label.TabIndex = 0
        Me.school_name_label.Text = "SMJK Lee Tak Database"
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.Location = New System.Drawing.Point(334, 107)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(66, 15)
        Me.username_label.TabIndex = 1
        Me.username_label.Text = "Username: "
        '
        'pwd_label
        '
        Me.pwd_label.AutoSize = True
        Me.pwd_label.Location = New System.Drawing.Point(337, 134)
        Me.pwd_label.Name = "pwd_label"
        Me.pwd_label.Size = New System.Drawing.Size(63, 15)
        Me.pwd_label.TabIndex = 2
        Me.pwd_label.Text = "Password: "
        '
        'username_input_textfield
        '
        Me.username_input_textfield.Location = New System.Drawing.Point(410, 106)
        Me.username_input_textfield.Name = "username_input_textfield"
        Me.username_input_textfield.Size = New System.Drawing.Size(201, 23)
        Me.username_input_textfield.TabIndex = 3
        '
        'password_input_textfield
        '
        Me.password_input_textfield.Location = New System.Drawing.Point(410, 132)
        Me.password_input_textfield.Name = "password_input_textfield"
        Me.password_input_textfield.Size = New System.Drawing.Size(201, 23)
        Me.password_input_textfield.TabIndex = 4
        Me.password_input_textfield.UseSystemPasswordChar = True
        '
        'login_button
        '
        Me.login_button.Location = New System.Drawing.Point(428, 221)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(105, 31)
        Me.login_button.TabIndex = 5
        Me.login_button.Text = "Login"
        Me.login_button.UseVisualStyleBackColor = True
        '
        'school_logo_image
        '
        Me.school_logo_image.Image = Global.VB_Assignment.My.Resources.Resources.logo
        Me.school_logo_image.Location = New System.Drawing.Point(17, 31)
        Me.school_logo_image.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.school_logo_image.Name = "school_logo_image"
        Me.school_logo_image.Size = New System.Drawing.Size(260, 221)
        Me.school_logo_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.school_logo_image.TabIndex = 6
        Me.school_logo_image.TabStop = False
        '
        'login_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(667, 290)
        Me.Controls.Add(Me.school_logo_image)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.password_input_textfield)
        Me.Controls.Add(Me.username_input_textfield)
        Me.Controls.Add(Me.pwd_label)
        Me.Controls.Add(Me.username_label)
        Me.Controls.Add(Me.school_name_label)
        Me.Name = "login_page"
        Me.Text = "School Databse"
        CType(Me.school_logo_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents school_name_label As Label
    Friend WithEvents username_label As Label
    Friend WithEvents pwd_label As Label
    Friend WithEvents username_input_textfield As TextBox
    Friend WithEvents password_input_textfield As TextBox
    Friend WithEvents login_button As Button
    Friend WithEvents school_logo_image As PictureBox
End Class
