﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteStudent
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
        Me.txtYearEnrolled = New System.Windows.Forms.TextBox()
        Me.comTeam = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtStuName = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtYearEnrolled
        '
        Me.txtYearEnrolled.Location = New System.Drawing.Point(164, 106)
        Me.txtYearEnrolled.Margin = New System.Windows.Forms.Padding(2)
        Me.txtYearEnrolled.Name = "txtYearEnrolled"
        Me.txtYearEnrolled.Size = New System.Drawing.Size(224, 23)
        Me.txtYearEnrolled.TabIndex = 30
        '
        'comTeam
        '
        Me.comTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comTeam.FormattingEnabled = True
        Me.comTeam.Items.AddRange(New Object() {"Red", "Yellow", "Blue", "Green"})
        Me.comTeam.Location = New System.Drawing.Point(165, 156)
        Me.comTeam.Margin = New System.Windows.Forms.Padding(2)
        Me.comTeam.Name = "comTeam"
        Me.comTeam.Size = New System.Drawing.Size(224, 23)
        Me.comTeam.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Team Colour:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(164, 79)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(224, 23)
        Me.txtAge.TabIndex = 27
        '
        'txtStuName
        '
        Me.txtStuName.Location = New System.Drawing.Point(164, 52)
        Me.txtStuName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStuName.Name = "txtStuName"
        Me.txtStuName.Size = New System.Drawing.Size(224, 23)
        Me.txtStuName.TabIndex = 26
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(164, 25)
        Me.txtStudentId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(165, 23)
        Me.txtStudentId.TabIndex = 25
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(257, 208)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 20)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(221, 133)
        Me.radFemale.Margin = New System.Windows.Forms.Padding(2)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(63, 19)
        Me.radFemale.TabIndex = 23
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(165, 133)
        Me.radMale.Margin = New System.Windows.Forms.Padding(2)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(51, 19)
        Me.radMale.TabIndex = 22
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'lblStuName
        '
        Me.lblStuName.AutoSize = True
        Me.lblStuName.Location = New System.Drawing.Point(55, 54)
        Me.lblStuName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(86, 15)
        Me.lblStuName.TabIndex = 21
        Me.lblStuName.Text = "Student Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Year Enrolled:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Gender:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(111, 208)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 20)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Delete"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Location = New System.Drawing.Point(75, 27)
        Me.lblStudentId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(65, 15)
        Me.lblStudentId.TabIndex = 16
        Me.lblStudentId.Text = "Student ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(334, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DeleteStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 270)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtYearEnrolled)
        Me.Controls.Add(Me.comTeam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtStuName)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblStudentId)
        Me.Name = "DeleteStudent"
        Me.Text = "Delete Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtYearEnrolled As TextBox
    Friend WithEvents comTeam As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtStuName As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents lblStuName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblStudentId As Label
    Friend WithEvents Button1 As Button
End Class
