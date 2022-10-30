<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletePeriod
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
        Me.comDay = New System.Windows.Forms.ComboBox()
        Me.comPeriodId = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSubjectId = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblClassId = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtSubjectId = New System.Windows.Forms.TextBox()
        Me.comClassId = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'comDay
        '
        Me.comDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comDay.FormattingEnabled = True
        Me.comDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.comDay.Location = New System.Drawing.Point(125, 43)
        Me.comDay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.comDay.Name = "comDay"
        Me.comDay.Size = New System.Drawing.Size(224, 23)
        Me.comDay.TabIndex = 51
        '
        'comPeriodId
        '
        Me.comPeriodId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPeriodId.FormattingEnabled = True
        Me.comPeriodId.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.comPeriodId.Location = New System.Drawing.Point(125, 16)
        Me.comPeriodId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.comPeriodId.Name = "comPeriodId"
        Me.comPeriodId.Size = New System.Drawing.Size(224, 23)
        Me.comPeriodId.TabIndex = 50
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(234, 173)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 20)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(89, 173)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(78, 20)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.Location = New System.Drawing.Point(44, 129)
        Me.lblSubjectId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(63, 15)
        Me.lblSubjectId.TabIndex = 45
        Me.lblSubjectId.Text = "Subject ID:"
        '
        'txtTime
        '
        Me.txtTime.Enabled = False
        Me.txtTime.Location = New System.Drawing.Point(125, 70)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(224, 23)
        Me.txtTime.TabIndex = 44
        '
        'lblClassId
        '
        Me.lblClassId.AutoSize = True
        Me.lblClassId.Location = New System.Drawing.Point(56, 101)
        Me.lblClassId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassId.Name = "lblClassId"
        Me.lblClassId.Size = New System.Drawing.Size(51, 15)
        Me.lblClassId.TabIndex = 43
        Me.lblClassId.Text = "Class ID:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(71, 72)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(36, 15)
        Me.lblTime.TabIndex = 42
        Me.lblTime.Text = "Time:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(76, 44)
        Me.lblDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(30, 15)
        Me.lblDay.TabIndex = 41
        Me.lblDay.Text = "Day:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(85, 19)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 15)
        Me.lblId.TabIndex = 40
        Me.lblId.Text = "ID:"
        '
        'txtSubjectId
        '
        Me.txtSubjectId.Location = New System.Drawing.Point(125, 126)
        Me.txtSubjectId.Name = "txtSubjectId"
        Me.txtSubjectId.ReadOnly = True
        Me.txtSubjectId.Size = New System.Drawing.Size(224, 23)
        Me.txtSubjectId.TabIndex = 53
        '
        'comClassId
        '
        Me.comClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comClassId.FormattingEnabled = True
        Me.comClassId.Location = New System.Drawing.Point(125, 98)
        Me.comClassId.Name = "comClassId"
        Me.comClassId.Size = New System.Drawing.Size(224, 23)
        Me.comClassId.TabIndex = 54
        '
        'DeletePeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 215)
        Me.Controls.Add(Me.comClassId)
        Me.Controls.Add(Me.txtSubjectId)
        Me.Controls.Add(Me.comDay)
        Me.Controls.Add(Me.comPeriodId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblClassId)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblId)
        Me.Name = "DeletePeriod"
        Me.Text = "Delete Period"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comDay As ComboBox
    Friend WithEvents comPeriodId As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblSubjectId As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblClassId As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblId As Label
    Friend WithEvents txtSubjectId As TextBox
    Friend WithEvents comClassId As ComboBox
End Class
