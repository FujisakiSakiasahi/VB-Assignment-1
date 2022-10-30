<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteClass
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
        Me.comClassId = New System.Windows.Forms.ComboBox()
        Me.lblClassId = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'comClassId
        '
        Me.comClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comClassId.FormattingEnabled = True
        Me.comClassId.Location = New System.Drawing.Point(139, 24)
        Me.comClassId.Name = "comClassId"
        Me.comClassId.Size = New System.Drawing.Size(224, 23)
        Me.comClassId.TabIndex = 0
        '
        'lblClassId
        '
        Me.lblClassId.AutoSize = True
        Me.lblClassId.Location = New System.Drawing.Point(65, 26)
        Me.lblClassId.Name = "lblClassId"
        Me.lblClassId.Size = New System.Drawing.Size(54, 15)
        Me.lblClassId.TabIndex = 1
        Me.lblClassId.Text = "Class ID: "
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(85, 97)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(231, 97)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DeleteClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 146)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblClassId)
        Me.Controls.Add(Me.comClassId)
        Me.Name = "DeleteClass"
        Me.Text = "Delete Class"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comClassId As ComboBox
    Friend WithEvents lblClassId As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
End Class
