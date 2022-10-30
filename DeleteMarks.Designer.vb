<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteMarks
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
        Me.comStudentId = New System.Windows.Forms.ComboBox()
        Me.comSubjectId = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.txtExamYear = New System.Windows.Forms.TextBox()
        Me.lblMark = New System.Windows.Forms.Label()
        Me.lblExamYear = New System.Windows.Forms.Label()
        Me.lblSubjectId = New System.Windows.Forms.Label()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comStudentId
        '
        Me.comStudentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comStudentId.FormattingEnabled = True
        Me.comStudentId.Location = New System.Drawing.Point(154, 33)
        Me.comStudentId.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.comStudentId.Name = "comStudentId"
        Me.comStudentId.Size = New System.Drawing.Size(255, 28)
        Me.comStudentId.TabIndex = 37
        '
        'comSubjectId
        '
        Me.comSubjectId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSubjectId.FormattingEnabled = True
        Me.comSubjectId.Location = New System.Drawing.Point(154, 69)
        Me.comSubjectId.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.comSubjectId.Name = "comSubjectId"
        Me.comSubjectId.Size = New System.Drawing.Size(255, 28)
        Me.comSubjectId.TabIndex = 36
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(279, 196)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 27)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(112, 196)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 27)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(154, 141)
        Me.txtMark.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.ReadOnly = True
        Me.txtMark.Size = New System.Drawing.Size(255, 27)
        Me.txtMark.TabIndex = 33
        '
        'txtExamYear
        '
        Me.txtExamYear.Location = New System.Drawing.Point(154, 105)
        Me.txtExamYear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtExamYear.Name = "txtExamYear"
        Me.txtExamYear.ReadOnly = True
        Me.txtExamYear.Size = New System.Drawing.Size(255, 27)
        Me.txtExamYear.TabIndex = 32
        '
        'lblMark
        '
        Me.lblMark.AutoSize = True
        Me.lblMark.Location = New System.Drawing.Point(88, 144)
        Me.lblMark.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(45, 20)
        Me.lblMark.TabIndex = 31
        Me.lblMark.Text = "Mark:"
        '
        'lblExamYear
        '
        Me.lblExamYear.AutoSize = True
        Me.lblExamYear.Location = New System.Drawing.Point(57, 107)
        Me.lblExamYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExamYear.Name = "lblExamYear"
        Me.lblExamYear.Size = New System.Drawing.Size(80, 20)
        Me.lblExamYear.TabIndex = 30
        Me.lblExamYear.Text = "Exam Year:"
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.Location = New System.Drawing.Point(55, 72)
        Me.lblSubjectId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(80, 20)
        Me.lblSubjectId.TabIndex = 29
        Me.lblSubjectId.Text = "Subject ID:"
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Location = New System.Drawing.Point(53, 35)
        Me.lblStudentId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(82, 20)
        Me.lblStudentId.TabIndex = 28
        Me.lblStudentId.Text = "Student ID:"
        '
        'DeleteMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 257)
        Me.Controls.Add(Me.comStudentId)
        Me.Controls.Add(Me.comSubjectId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.txtExamYear)
        Me.Controls.Add(Me.lblMark)
        Me.Controls.Add(Me.lblExamYear)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Controls.Add(Me.lblStudentId)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DeleteMarks"
        Me.Text = "Delete Mark"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comStudentId As ComboBox
    Friend WithEvents comSubjectId As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtMark As TextBox
    Friend WithEvents txtExamYear As TextBox
    Friend WithEvents lblMark As Label
    Friend WithEvents lblExamYear As Label
    Friend WithEvents lblSubjectId As Label
    Friend WithEvents lblStudentId As Label
End Class
