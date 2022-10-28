<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddTeacher
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
        Me.txtStuName = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTeacherName = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTeacherId = New System.Windows.Forms.Label()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtStuName
        '
        Me.txtStuName.Location = New System.Drawing.Point(186, 70)
        Me.txtStuName.Name = "txtStuName"
        Me.txtStuName.Size = New System.Drawing.Size(319, 31)
        Me.txtStuName.TabIndex = 26
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(186, 32)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(319, 31)
        Me.txtStudentId.TabIndex = 25
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(310, 180)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTeacherName
        '
        Me.lblTeacherName.AutoSize = True
        Me.lblTeacherName.Location = New System.Drawing.Point(30, 73)
        Me.lblTeacherName.Name = "lblTeacherName"
        Me.lblTeacherName.Size = New System.Drawing.Size(126, 25)
        Me.lblTeacherName.TabIndex = 20
        Me.lblTeacherName.Text = "Teacher Name:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(78, 180)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 34)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTeacherId
        '
        Me.lblTeacherId.AutoSize = True
        Me.lblTeacherId.Location = New System.Drawing.Point(59, 35)
        Me.lblTeacherId.Name = "lblTeacherId"
        Me.lblTeacherId.Size = New System.Drawing.Size(97, 25)
        Me.lblTeacherId.TabIndex = 15
        Me.lblTeacherId.Text = "Teacher ID:"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(269, 108)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(93, 29)
        Me.radFemale.TabIndex = 29
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(188, 108)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(75, 29)
        Me.radMale.TabIndex = 28
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Gender:"
        '
        'AddTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 255)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStuName)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTeacherName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTeacherId)
        Me.Name = "AddTeacher"
        Me.Text = "Add New Teacher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtStuName As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents lblTeacherName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblTeacherId As Label
End Class
