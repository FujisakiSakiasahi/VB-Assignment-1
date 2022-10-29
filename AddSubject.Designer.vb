<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSubject
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
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblSName = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblSubjectId = New System.Windows.Forms.Label()
        Me.txtSubjectId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(202, 69)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(319, 31)
        Me.txtSName.TabIndex = 32
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(327, 148)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblSName
        '
        Me.lblSName.AutoSize = True
        Me.lblSName.Location = New System.Drawing.Point(46, 72)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(126, 25)
        Me.lblSName.TabIndex = 29
        Me.lblSName.Text = "Subject Name:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(95, 148)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 34)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.Location = New System.Drawing.Point(75, 34)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(97, 25)
        Me.lblSubjectId.TabIndex = 27
        Me.lblSubjectId.Text = "Subject ID:"
        '
        'txtSubjectId
        '
        Me.txtSubjectId.Location = New System.Drawing.Point(202, 31)
        Me.txtSubjectId.Name = "txtSubjectId"
        Me.txtSubjectId.Size = New System.Drawing.Size(319, 31)
        Me.txtSubjectId.TabIndex = 33
        '
        'AddSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 226)
        Me.Controls.Add(Me.txtSubjectId)
        Me.Controls.Add(Me.txtSName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblSName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Name = "AddSubject"
        Me.Text = "Add New Subject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSName As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblSName As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblSubjectId As Label
    Friend WithEvents txtSubjectId As TextBox
End Class
