<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteTeacher
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTeacherName = New System.Windows.Forms.TextBox()
        Me.txtTeacherId = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTeacherName = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblTeacherId = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtTeacherGender = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Gender:"
        '
        'txtTeacherName
        '
        Me.txtTeacherName.Location = New System.Drawing.Point(130, 46)
        Me.txtTeacherName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTeacherName.Name = "txtTeacherName"
        Me.txtTeacherName.ReadOnly = True
        Me.txtTeacherName.Size = New System.Drawing.Size(224, 23)
        Me.txtTeacherName.TabIndex = 35
        '
        'txtTeacherId
        '
        Me.txtTeacherId.Location = New System.Drawing.Point(130, 19)
        Me.txtTeacherId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTeacherId.Name = "txtTeacherId"
        Me.txtTeacherId.Size = New System.Drawing.Size(165, 23)
        Me.txtTeacherId.TabIndex = 34
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(217, 108)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTeacherName
        '
        Me.lblTeacherName.AutoSize = True
        Me.lblTeacherName.Location = New System.Drawing.Point(21, 48)
        Me.lblTeacherName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTeacherName.Name = "lblTeacherName"
        Me.lblTeacherName.Size = New System.Drawing.Size(85, 15)
        Me.lblTeacherName.TabIndex = 32
        Me.lblTeacherName.Text = "Teacher Name:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(55, 108)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblTeacherId
        '
        Me.lblTeacherId.AutoSize = True
        Me.lblTeacherId.Location = New System.Drawing.Point(41, 21)
        Me.lblTeacherId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTeacherId.Name = "lblTeacherId"
        Me.lblTeacherId.Size = New System.Drawing.Size(64, 15)
        Me.lblTeacherId.TabIndex = 30
        Me.lblTeacherId.Text = "Teacher ID:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(300, 17)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(54, 23)
        Me.btnSearch.TabIndex = 39
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtTeacherGender
        '
        Me.txtTeacherGender.Location = New System.Drawing.Point(130, 74)
        Me.txtTeacherGender.Name = "txtTeacherGender"
        Me.txtTeacherGender.ReadOnly = True
        Me.txtTeacherGender.Size = New System.Drawing.Size(224, 23)
        Me.txtTeacherGender.TabIndex = 40
        '
        'DeleteTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 153)
        Me.Controls.Add(Me.txtTeacherGender)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTeacherName)
        Me.Controls.Add(Me.txtTeacherId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTeacherName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblTeacherId)
        Me.Name = "DeleteTeacher"
        Me.Text = "Delete Teacher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTeacherName As TextBox
    Friend WithEvents txtTeacherId As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTeacherName As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblTeacherId As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtTeacherGender As TextBox
End Class
