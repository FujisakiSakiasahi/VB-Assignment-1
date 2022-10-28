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
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.txtExamYear = New System.Windows.Forms.TextBox()
        Me.lblClassId = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtStuName = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblSubjectId = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(179, 141)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(319, 31)
        Me.txtMark.TabIndex = 31
        '
        'txtExamYear
        '
        Me.txtExamYear.Location = New System.Drawing.Point(179, 103)
        Me.txtExamYear.Name = "txtExamYear"
        Me.txtExamYear.Size = New System.Drawing.Size(319, 31)
        Me.txtExamYear.TabIndex = 30
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
        'txtStuName
        '
        Me.txtStuName.Location = New System.Drawing.Point(179, 66)
        Me.txtStuName.Name = "txtStuName"
        Me.txtStuName.Size = New System.Drawing.Size(319, 31)
        Me.txtStuName.TabIndex = 27
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(179, 28)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(319, 31)
        Me.txtStudentId.TabIndex = 26
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(179, 178)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(319, 31)
        Me.TextBox1.TabIndex = 33
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
        'AddPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 358)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.txtExamYear)
        Me.Controls.Add(Me.lblClassId)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtStuName)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblId)
        Me.Name = "AddPeriod"
        Me.Text = "AddPeriod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMark As TextBox
    Friend WithEvents txtExamYear As TextBox
    Friend WithEvents lblClassId As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents txtStuName As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblId As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblSubjectId As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
End Class
