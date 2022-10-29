<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateMarks
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
        Me.btnAdd = New System.Windows.Forms.Button()
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
        Me.comStudentId.Location = New System.Drawing.Point(135, 25)
        Me.comStudentId.Margin = New System.Windows.Forms.Padding(2)
        Me.comStudentId.Name = "comStudentId"
        Me.comStudentId.Size = New System.Drawing.Size(224, 23)
        Me.comStudentId.TabIndex = 37
        '
        'comSubjectId
        '
        Me.comSubjectId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSubjectId.FormattingEnabled = True
        Me.comSubjectId.Location = New System.Drawing.Point(135, 52)
        Me.comSubjectId.Margin = New System.Windows.Forms.Padding(2)
        Me.comSubjectId.Name = "comSubjectId"
        Me.comSubjectId.Size = New System.Drawing.Size(224, 23)
        Me.comSubjectId.TabIndex = 36
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(244, 147)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 20)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(98, 147)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 20)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "Update"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(135, 106)
        Me.txtMark.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(224, 23)
        Me.txtMark.TabIndex = 33
        '
        'txtExamYear
        '
        Me.txtExamYear.Location = New System.Drawing.Point(135, 79)
        Me.txtExamYear.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExamYear.Name = "txtExamYear"
        Me.txtExamYear.Size = New System.Drawing.Size(224, 23)
        Me.txtExamYear.TabIndex = 32
        '
        'lblMark
        '
        Me.lblMark.AutoSize = True
        Me.lblMark.Location = New System.Drawing.Point(77, 108)
        Me.lblMark.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(37, 15)
        Me.lblMark.TabIndex = 31
        Me.lblMark.Text = "Mark:"
        '
        'lblExamYear
        '
        Me.lblExamYear.AutoSize = True
        Me.lblExamYear.Location = New System.Drawing.Point(50, 80)
        Me.lblExamYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExamYear.Name = "lblExamYear"
        Me.lblExamYear.Size = New System.Drawing.Size(64, 15)
        Me.lblExamYear.TabIndex = 30
        Me.lblExamYear.Text = "Exam Year:"
        '
        'lblSubjectId
        '
        Me.lblSubjectId.AutoSize = True
        Me.lblSubjectId.Location = New System.Drawing.Point(48, 54)
        Me.lblSubjectId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubjectId.Name = "lblSubjectId"
        Me.lblSubjectId.Size = New System.Drawing.Size(63, 15)
        Me.lblSubjectId.TabIndex = 29
        Me.lblSubjectId.Text = "Subject ID:"
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Location = New System.Drawing.Point(46, 26)
        Me.lblStudentId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(65, 15)
        Me.lblStudentId.TabIndex = 28
        Me.lblStudentId.Text = "Student ID:"
        '
        'UpdateMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 193)
        Me.Controls.Add(Me.comStudentId)
        Me.Controls.Add(Me.comSubjectId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.txtExamYear)
        Me.Controls.Add(Me.lblMark)
        Me.Controls.Add(Me.lblExamYear)
        Me.Controls.Add(Me.lblSubjectId)
        Me.Controls.Add(Me.lblStudentId)
        Me.Name = "UpdateMarks"
        Me.Text = "Update Mark"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comStudentId As ComboBox
    Friend WithEvents comSubjectId As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtMark As TextBox
    Friend WithEvents txtExamYear As TextBox
    Friend WithEvents lblMark As Label
    Friend WithEvents lblExamYear As Label
    Friend WithEvents lblSubjectId As Label
    Friend WithEvents lblStudentId As Label
End Class
