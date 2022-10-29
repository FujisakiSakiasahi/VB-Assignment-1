<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPeriod
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
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblClassId = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblSubjectId = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.comClassId = New System.Windows.Forms.ComboBox()
        Me.comSubjectId = New System.Windows.Forms.ComboBox()
        Me.comPeriodId = New System.Windows.Forms.ComboBox()
        Me.comDay = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtTime
        '
        Me.txtTime.Enabled = False
        Me.txtTime.Location = New System.Drawing.Point(179, 103)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(319, 31)
        Me.txtTime.TabIndex = 30
        '
        'lblClassId
        '
        Me.lblClassId.AutoSize = True
        Me.lblClassId.Location = New System.Drawing.Point(77, 144)
        Me.lblClassId.Name = "lblClassId"
        Me.lblClassId.Size = New System.Drawing.Size(79, 25)
        Me.lblClassId.TabIndex = 29
        Me.lblClassId.Text = "Class ID:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(102, 106)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(54, 25)
        Me.lblTime.TabIndex = 28
        Me.lblTime.Text = "Time:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(109, 69)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(47, 25)
        Me.lblDay.TabIndex = 25
        Me.lblDay.Text = "Day:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(122, 31)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(34, 25)
        Me.lblId.TabIndex = 24
        Me.lblId.Text = "ID:"
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.Location = New System.Drawing.Point(59, 181)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(97, 25)
        Me.lblSubjectId.TabIndex = 32
        Me.lblSubjectId.Text = "Subject ID:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(335, 258)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(127, 258)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 34)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'comClassId
        '
        Me.comClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comClassId.FormattingEnabled = True
        Me.comClassId.Location = New System.Drawing.Point(179, 141)
        Me.comClassId.Name = "comClassId"
        Me.comClassId.Size = New System.Drawing.Size(319, 33)
        Me.comClassId.TabIndex = 36
        '
        'comSubjectId
        '
        Me.comSubjectId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSubjectId.FormattingEnabled = True
        Me.comSubjectId.Location = New System.Drawing.Point(179, 178)
        Me.comSubjectId.Name = "comSubjectId"
        Me.comSubjectId.Size = New System.Drawing.Size(319, 33)
        Me.comSubjectId.TabIndex = 37
        '
        'comPeriodId
        '
        Me.comPeriodId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPeriodId.FormattingEnabled = True
        Me.comPeriodId.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.comPeriodId.Location = New System.Drawing.Point(179, 27)
        Me.comPeriodId.Name = "comPeriodId"
        Me.comPeriodId.Size = New System.Drawing.Size(319, 33)
        Me.comPeriodId.TabIndex = 38
        '
        'comDay
        '
        Me.comDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comDay.FormattingEnabled = True
        Me.comDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.comDay.Location = New System.Drawing.Point(179, 66)
        Me.comDay.Name = "comDay"
        Me.comDay.Size = New System.Drawing.Size(319, 33)
        Me.comDay.TabIndex = 39
        '
        'AddPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 358)
        Me.Controls.Add(Me.comDay)
        Me.Controls.Add(Me.comPeriodId)
        Me.Controls.Add(Me.comSubjectId)
        Me.Controls.Add(Me.comClassId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblClassId)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblId)
        Me.Name = "AddPeriod"
        Me.Text = "AddPeriod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblClassId As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblSubjectId As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents comClassId As ComboBox
    Friend WithEvents comSubjectId As ComboBox
    Friend WithEvents comPeriodId As ComboBox
    Friend WithEvents comDay As ComboBox
End Class
