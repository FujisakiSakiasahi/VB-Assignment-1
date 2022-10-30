<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateSubject
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
        Me.lblSubjectId = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblSName = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.comSubjectId = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.Location = New System.Drawing.Point(52, 20)
        Me.lblSubjectId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(63, 15)
        Me.lblSubjectId.TabIndex = 34
        Me.lblSubjectId.Text = "Subject ID:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(66, 89)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(78, 20)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblSName
        '
        Me.lblSName.AutoSize = True
        Me.lblSName.Location = New System.Drawing.Point(32, 48)
        Me.lblSName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(84, 15)
        Me.lblSName.TabIndex = 36
        Me.lblSName.Text = "Subject Name:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(229, 89)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 20)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(141, 46)
        Me.txtSName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(224, 23)
        Me.txtSName.TabIndex = 38
        '
        'comSubjectId
        '
        Me.comSubjectId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSubjectId.FormattingEnabled = True
        Me.comSubjectId.Location = New System.Drawing.Point(141, 18)
        Me.comSubjectId.Name = "comSubjectId"
        Me.comSubjectId.Size = New System.Drawing.Size(224, 23)
        Me.comSubjectId.TabIndex = 40
        '
        'UpdateSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 136)
        Me.Controls.Add(Me.comSubjectId)
        Me.Controls.Add(Me.txtSName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblSName)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Name = "UpdateSubject"
        Me.Text = "Update Subject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubjectId As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblSName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtSName As TextBox
    Friend WithEvents comSubjectId As ComboBox
End Class
