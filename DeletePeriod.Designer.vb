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
        Me.txtClassId = New System.Windows.Forms.TextBox()
        Me.txtSubjectId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'comDay
        '
        Me.comDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comDay.FormattingEnabled = True
        Me.comDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.comDay.Location = New System.Drawing.Point(143, 57)
        Me.comDay.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.comDay.Name = "comDay"
        Me.comDay.Size = New System.Drawing.Size(255, 28)
        Me.comDay.TabIndex = 51
        '
        'comPeriodId
        '
        Me.comPeriodId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPeriodId.FormattingEnabled = True
        Me.comPeriodId.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.comPeriodId.Location = New System.Drawing.Point(143, 21)
        Me.comPeriodId.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.comPeriodId.Name = "comPeriodId"
        Me.comPeriodId.Size = New System.Drawing.Size(255, 28)
        Me.comPeriodId.TabIndex = 50
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(267, 231)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 27)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(102, 231)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 27)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.Location = New System.Drawing.Point(50, 172)
        Me.lblSubjectId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(80, 20)
        Me.lblSubjectId.TabIndex = 45
        Me.lblSubjectId.Text = "Subject ID:"
        '
        'txtTime
        '
        Me.txtTime.Enabled = False
        Me.txtTime.Location = New System.Drawing.Point(143, 93)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(255, 27)
        Me.txtTime.TabIndex = 44
        '
        'lblClassId
        '
        Me.lblClassId.AutoSize = True
        Me.lblClassId.Location = New System.Drawing.Point(64, 135)
        Me.lblClassId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassId.Name = "lblClassId"
        Me.lblClassId.Size = New System.Drawing.Size(64, 20)
        Me.lblClassId.TabIndex = 43
        Me.lblClassId.Text = "Class ID:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(81, 96)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(45, 20)
        Me.lblTime.TabIndex = 42
        Me.lblTime.Text = "Time:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(87, 59)
        Me.lblDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(38, 20)
        Me.lblDay.TabIndex = 41
        Me.lblDay.Text = "Day:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(97, 25)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(27, 20)
        Me.lblId.TabIndex = 40
        Me.lblId.Text = "ID:"
        '
        'txtClassId
        '
        Me.txtClassId.Location = New System.Drawing.Point(143, 131)
        Me.txtClassId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtClassId.Name = "txtClassId"
        Me.txtClassId.ReadOnly = True
        Me.txtClassId.Size = New System.Drawing.Size(255, 27)
        Me.txtClassId.TabIndex = 52
        '
        'txtSubjectId
        '
        Me.txtSubjectId.Location = New System.Drawing.Point(143, 168)
        Me.txtSubjectId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSubjectId.Name = "txtSubjectId"
        Me.txtSubjectId.ReadOnly = True
        Me.txtSubjectId.Size = New System.Drawing.Size(255, 27)
        Me.txtSubjectId.TabIndex = 53
        '
        'DeletePeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 287)
        Me.Controls.Add(Me.txtSubjectId)
        Me.Controls.Add(Me.txtClassId)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
    Friend WithEvents txtClassId As TextBox
    Friend WithEvents txtSubjectId As TextBox
End Class
