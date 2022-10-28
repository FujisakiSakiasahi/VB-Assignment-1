<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMarks
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
        Me.lblSubjectId = New System.Windows.Forms.Label()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.txtExamYear = New System.Windows.Forms.TextBox()
        Me.lblMark = New System.Windows.Forms.Label()
        Me.lblExamYear = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtStuName
        '
        Me.txtStuName.Location = New System.Drawing.Point(180, 84)
        Me.txtStuName.Name = "txtStuName"
        Me.txtStuName.Size = New System.Drawing.Size(319, 31)
        Me.txtStuName.TabIndex = 19
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(180, 46)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(319, 31)
        Me.txtStudentId.TabIndex = 18
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.Location = New System.Drawing.Point(56, 87)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(97, 25)
        Me.lblSubjectId.TabIndex = 17
        Me.lblSubjectId.Text = "Subject ID:"
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Location = New System.Drawing.Point(53, 49)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(100, 25)
        Me.lblStudentId.TabIndex = 16
        Me.lblStudentId.Text = "Student ID:"
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(180, 159)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(319, 31)
        Me.txtMark.TabIndex = 23
        '
        'txtExamYear
        '
        Me.txtExamYear.Location = New System.Drawing.Point(180, 121)
        Me.txtExamYear.Name = "txtExamYear"
        Me.txtExamYear.Size = New System.Drawing.Size(319, 31)
        Me.txtExamYear.TabIndex = 22
        '
        'lblMark
        '
        Me.lblMark.AutoSize = True
        Me.lblMark.Location = New System.Drawing.Point(97, 162)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(56, 25)
        Me.lblMark.TabIndex = 21
        Me.lblMark.Text = "Mark:"
        '
        'lblExamYear
        '
        Me.lblExamYear.AutoSize = True
        Me.lblExamYear.Location = New System.Drawing.Point(58, 124)
        Me.lblExamYear.Name = "lblExamYear"
        Me.lblExamYear.Size = New System.Drawing.Size(95, 25)
        Me.lblExamYear.TabIndex = 20
        Me.lblExamYear.Text = "Exam Year:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(337, 231)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(129, 231)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 34)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'AddMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 301)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.txtExamYear)
        Me.Controls.Add(Me.lblMark)
        Me.Controls.Add(Me.lblExamYear)
        Me.Controls.Add(Me.txtStuName)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Controls.Add(Me.lblStudentId)
        Me.Name = "AddMarks"
        Me.Text = "AddMarks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStuName As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents lblSubjectId As Label
    Friend WithEvents lblStudentId As Label
    Friend WithEvents txtMark As TextBox
    Friend WithEvents txtExamYear As TextBox
    Friend WithEvents lblMark As Label
    Friend WithEvents lblExamYear As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
End Class
