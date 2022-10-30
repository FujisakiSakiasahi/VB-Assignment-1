<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteSubject
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSubjectId = New System.Windows.Forms.Label()
        Me.comSubjectId = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(161, 61)
        Me.txtSName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.ReadOnly = True
        Me.txtSName.Size = New System.Drawing.Size(255, 27)
        Me.txtSName.TabIndex = 38
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(262, 119)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 27)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblSName
        '
        Me.lblSName.AutoSize = True
        Me.lblSName.Location = New System.Drawing.Point(37, 64)
        Me.lblSName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(105, 20)
        Me.lblSName.TabIndex = 36
        Me.lblSName.Text = "Subject Name:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(75, 119)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 27)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.Location = New System.Drawing.Point(59, 27)
        Me.lblSubjectId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(80, 20)
        Me.lblSubjectId.TabIndex = 34
        Me.lblSubjectId.Text = "Subject ID:"
        '
        'comSubjectId
        '
        Me.comSubjectId.FormattingEnabled = True
        Me.comSubjectId.Location = New System.Drawing.Point(161, 25)
        Me.comSubjectId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comSubjectId.Name = "comSubjectId"
        Me.comSubjectId.Size = New System.Drawing.Size(255, 28)
        Me.comSubjectId.TabIndex = 39
        '
        'DeleteSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 181)
        Me.Controls.Add(Me.comSubjectId)
        Me.Controls.Add(Me.txtSName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblSName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DeleteSubject"
        Me.Text = "Delete Subject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSName As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblSName As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblSubjectId As Label
    Friend WithEvents comSubjectId As ComboBox
End Class
