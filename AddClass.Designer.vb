<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtStuName = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.lblClassId = New System.Windows.Forms.Label()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtStuName
        '
        Me.txtStuName.Location = New System.Drawing.Point(199, 78)
        Me.txtStuName.Name = "txtStuName"
        Me.txtStuName.Size = New System.Drawing.Size(319, 31)
        Me.txtStuName.TabIndex = 15
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(199, 40)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(319, 31)
        Me.txtStudentId.TabIndex = 14
        '
        'lblClassId
        '
        Me.lblClassId.AutoSize = True
        Me.lblClassId.Location = New System.Drawing.Point(93, 81)
        Me.lblClassId.Name = "lblClassId"
        Me.lblClassId.Size = New System.Drawing.Size(79, 25)
        Me.lblClassId.TabIndex = 13
        Me.lblClassId.Text = "Class ID:"
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Location = New System.Drawing.Point(72, 43)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(100, 25)
        Me.lblStudentId.TabIndex = 12
        Me.lblStudentId.Text = "Student ID:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(330, 162)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(122, 162)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 34)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'AddClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 243)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtStuName)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.lblClassId)
        Me.Controls.Add(Me.lblStudentId)
        Me.Name = "AddClass"
        Me.Text = "Add Student to Class"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStuName As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents lblClassId As Label
    Friend WithEvents lblStudentId As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
End Class
