<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllocStudentToClass
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
        Me.lblClassId = New System.Windows.Forms.Label()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.comStudentId = New System.Windows.Forms.ComboBox()
        Me.comClassId = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblClassId
        '
        Me.lblClassId.AutoSize = True
        Me.lblClassId.Location = New System.Drawing.Point(65, 53)
        Me.lblClassId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassId.Name = "lblClassId"
        Me.lblClassId.Size = New System.Drawing.Size(51, 15)
        Me.lblClassId.TabIndex = 13
        Me.lblClassId.Text = "Class ID:"
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Location = New System.Drawing.Point(50, 26)
        Me.lblStudentId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(65, 15)
        Me.lblStudentId.TabIndex = 12
        Me.lblStudentId.Text = "Student ID:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(231, 97)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 20)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(85, 97)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 20)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'comStudentId
        '
        Me.comStudentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comStudentId.FormattingEnabled = True
        Me.comStudentId.Location = New System.Drawing.Point(139, 24)
        Me.comStudentId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.comStudentId.Name = "comStudentId"
        Me.comStudentId.Size = New System.Drawing.Size(224, 23)
        Me.comStudentId.TabIndex = 29
        '
        'comClassId
        '
        Me.comClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comClassId.FormattingEnabled = True
        Me.comClassId.Location = New System.Drawing.Point(139, 51)
        Me.comClassId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.comClassId.Name = "comClassId"
        Me.comClassId.Size = New System.Drawing.Size(224, 23)
        Me.comClassId.TabIndex = 28
        '
        'AllocStudentToClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 146)
        Me.Controls.Add(Me.comStudentId)
        Me.Controls.Add(Me.comClassId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblClassId)
        Me.Controls.Add(Me.lblStudentId)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AllocStudentToClass"
        Me.Text = "Add Student to Class"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClassId As Label
    Friend WithEvents lblStudentId As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents comStudentId As ComboBox
    Friend WithEvents comClassId As ComboBox
End Class
