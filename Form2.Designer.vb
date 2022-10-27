<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tab_control = New System.Windows.Forms.TabControl()
        Me.student_tab = New System.Windows.Forms.TabPage()
        Me.Label = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.student_add_button = New System.Windows.Forms.Button()
        Me.student_table = New System.Windows.Forms.DataGridView()
        Me.student_delete_button = New System.Windows.Forms.Button()
        Me.student_update_button = New System.Windows.Forms.Button()
        Me.teacher_tab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.teacher_add_button = New System.Windows.Forms.Button()
        Me.teacher_update_button = New System.Windows.Forms.Button()
        Me.teacher_delete_button = New System.Windows.Forms.Button()
        Me.teacher_table = New System.Windows.Forms.DataGridView()
        Me.class_tab = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.class_add_button = New System.Windows.Forms.Button()
        Me.class_update_button = New System.Windows.Forms.Button()
        Me.class_delete_button = New System.Windows.Forms.Button()
        Me.class_table = New System.Windows.Forms.DataGridView()
        Me.subject_tab = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.subject_add_button = New System.Windows.Forms.Button()
        Me.subject_update_button = New System.Windows.Forms.Button()
        Me.subject_delete_button = New System.Windows.Forms.Button()
        Me.subject_table = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tab_control.SuspendLayout()
        Me.student_tab.SuspendLayout()
        CType(Me.student_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.teacher_tab.SuspendLayout()
        CType(Me.teacher_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.class_tab.SuspendLayout()
        CType(Me.class_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.subject_tab.SuspendLayout()
        CType(Me.subject_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_control
        '
        Me.tab_control.Controls.Add(Me.student_tab)
        Me.tab_control.Controls.Add(Me.teacher_tab)
        Me.tab_control.Controls.Add(Me.class_tab)
        Me.tab_control.Controls.Add(Me.subject_tab)
        Me.tab_control.Controls.Add(Me.TabPage1)
        Me.tab_control.Controls.Add(Me.TabPage2)
        Me.tab_control.Location = New System.Drawing.Point(12, 12)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.SelectedIndex = 0
        Me.tab_control.Size = New System.Drawing.Size(862, 426)
        Me.tab_control.TabIndex = 1
        '
        'student_tab
        '
        Me.student_tab.Controls.Add(Me.Label4)
        Me.student_tab.Controls.Add(Me.ComboBox1)
        Me.student_tab.Controls.Add(Me.Label)
        Me.student_tab.Controls.Add(Me.TextBox1)
        Me.student_tab.Controls.Add(Me.student_add_button)
        Me.student_tab.Controls.Add(Me.student_table)
        Me.student_tab.Controls.Add(Me.student_delete_button)
        Me.student_tab.Controls.Add(Me.student_update_button)
        Me.student_tab.Location = New System.Drawing.Point(4, 24)
        Me.student_tab.Name = "student_tab"
        Me.student_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.student_tab.Size = New System.Drawing.Size(854, 398)
        Me.student_tab.TabIndex = 0
        Me.student_tab.Text = "Student"
        Me.student_tab.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label.Location = New System.Drawing.Point(87, 6)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(64, 21)
        Me.Label.TabIndex = 17
        Me.Label.Text = "Search: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(161, 5)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(424, 23)
        Me.TextBox1.TabIndex = 16
        '
        'student_add_button
        '
        Me.student_add_button.Location = New System.Drawing.Point(6, 6)
        Me.student_add_button.Name = "student_add_button"
        Me.student_add_button.Size = New System.Drawing.Size(75, 23)
        Me.student_add_button.TabIndex = 11
        Me.student_add_button.Text = "Add New"
        Me.student_add_button.UseVisualStyleBackColor = True
        '
        'student_table
        '
        Me.student_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.student_table.Location = New System.Drawing.Point(87, 34)
        Me.student_table.Name = "student_table"
        Me.student_table.RowHeadersWidth = 51
        Me.student_table.RowTemplate.Height = 25
        Me.student_table.Size = New System.Drawing.Size(761, 358)
        Me.student_table.TabIndex = 10
        '
        'student_delete_button
        '
        Me.student_delete_button.Location = New System.Drawing.Point(6, 64)
        Me.student_delete_button.Name = "student_delete_button"
        Me.student_delete_button.Size = New System.Drawing.Size(75, 23)
        Me.student_delete_button.TabIndex = 13
        Me.student_delete_button.Text = "Delete"
        Me.student_delete_button.UseVisualStyleBackColor = True
        '
        'student_update_button
        '
        Me.student_update_button.Location = New System.Drawing.Point(6, 35)
        Me.student_update_button.Name = "student_update_button"
        Me.student_update_button.Size = New System.Drawing.Size(75, 23)
        Me.student_update_button.TabIndex = 12
        Me.student_update_button.Text = "Update"
        Me.student_update_button.UseVisualStyleBackColor = True
        '
        'teacher_tab
        '
        Me.teacher_tab.Controls.Add(Me.Label1)
        Me.teacher_tab.Controls.Add(Me.TextBox2)
        Me.teacher_tab.Controls.Add(Me.teacher_add_button)
        Me.teacher_tab.Controls.Add(Me.teacher_update_button)
        Me.teacher_tab.Controls.Add(Me.teacher_delete_button)
        Me.teacher_tab.Controls.Add(Me.teacher_table)
        Me.teacher_tab.Location = New System.Drawing.Point(4, 24)
        Me.teacher_tab.Name = "teacher_tab"
        Me.teacher_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.teacher_tab.Size = New System.Drawing.Size(854, 398)
        Me.teacher_tab.TabIndex = 1
        Me.teacher_tab.Text = "Teacher"
        Me.teacher_tab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(87, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search: "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(157, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(691, 23)
        Me.TextBox2.TabIndex = 10
        '
        'teacher_add_button
        '
        Me.teacher_add_button.Location = New System.Drawing.Point(6, 6)
        Me.teacher_add_button.Name = "teacher_add_button"
        Me.teacher_add_button.Size = New System.Drawing.Size(75, 23)
        Me.teacher_add_button.TabIndex = 5
        Me.teacher_add_button.Text = "Add New"
        Me.teacher_add_button.UseVisualStyleBackColor = True
        '
        'teacher_update_button
        '
        Me.teacher_update_button.Location = New System.Drawing.Point(6, 35)
        Me.teacher_update_button.Name = "teacher_update_button"
        Me.teacher_update_button.Size = New System.Drawing.Size(75, 23)
        Me.teacher_update_button.TabIndex = 6
        Me.teacher_update_button.Text = "Update"
        Me.teacher_update_button.UseVisualStyleBackColor = True
        '
        'teacher_delete_button
        '
        Me.teacher_delete_button.Location = New System.Drawing.Point(6, 64)
        Me.teacher_delete_button.Name = "teacher_delete_button"
        Me.teacher_delete_button.Size = New System.Drawing.Size(75, 23)
        Me.teacher_delete_button.TabIndex = 7
        Me.teacher_delete_button.Text = "Delete"
        Me.teacher_delete_button.UseVisualStyleBackColor = True
        '
        'teacher_table
        '
        Me.teacher_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.teacher_table.Location = New System.Drawing.Point(87, 35)
        Me.teacher_table.Name = "teacher_table"
        Me.teacher_table.RowHeadersWidth = 51
        Me.teacher_table.RowTemplate.Height = 25
        Me.teacher_table.Size = New System.Drawing.Size(764, 360)
        Me.teacher_table.TabIndex = 1
        '
        'class_tab
        '
        Me.class_tab.Controls.Add(Me.TextBox3)
        Me.class_tab.Controls.Add(Me.Label2)
        Me.class_tab.Controls.Add(Me.class_add_button)
        Me.class_tab.Controls.Add(Me.class_update_button)
        Me.class_tab.Controls.Add(Me.class_delete_button)
        Me.class_tab.Controls.Add(Me.class_table)
        Me.class_tab.Location = New System.Drawing.Point(4, 24)
        Me.class_tab.Name = "class_tab"
        Me.class_tab.Size = New System.Drawing.Size(854, 398)
        Me.class_tab.TabIndex = 2
        Me.class_tab.Text = "Class"
        Me.class_tab.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(157, 6)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(694, 23)
        Me.TextBox3.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(87, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Search: "
        '
        'class_add_button
        '
        Me.class_add_button.Location = New System.Drawing.Point(6, 6)
        Me.class_add_button.Name = "class_add_button"
        Me.class_add_button.Size = New System.Drawing.Size(75, 23)
        Me.class_add_button.TabIndex = 5
        Me.class_add_button.Text = "Add New"
        Me.class_add_button.UseVisualStyleBackColor = True
        '
        'class_update_button
        '
        Me.class_update_button.Location = New System.Drawing.Point(6, 35)
        Me.class_update_button.Name = "class_update_button"
        Me.class_update_button.Size = New System.Drawing.Size(75, 23)
        Me.class_update_button.TabIndex = 6
        Me.class_update_button.Text = "Update"
        Me.class_update_button.UseVisualStyleBackColor = True
        '
        'class_delete_button
        '
        Me.class_delete_button.Location = New System.Drawing.Point(6, 64)
        Me.class_delete_button.Name = "class_delete_button"
        Me.class_delete_button.Size = New System.Drawing.Size(75, 23)
        Me.class_delete_button.TabIndex = 7
        Me.class_delete_button.Text = "Delete"
        Me.class_delete_button.UseVisualStyleBackColor = True
        '
        'class_table
        '
        Me.class_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.class_table.Location = New System.Drawing.Point(87, 35)
        Me.class_table.Name = "class_table"
        Me.class_table.RowHeadersWidth = 51
        Me.class_table.RowTemplate.Height = 25
        Me.class_table.Size = New System.Drawing.Size(764, 354)
        Me.class_table.TabIndex = 1
        '
        'subject_tab
        '
        Me.subject_tab.Controls.Add(Me.TextBox4)
        Me.subject_tab.Controls.Add(Me.Label3)
        Me.subject_tab.Controls.Add(Me.subject_add_button)
        Me.subject_tab.Controls.Add(Me.subject_update_button)
        Me.subject_tab.Controls.Add(Me.subject_delete_button)
        Me.subject_tab.Controls.Add(Me.subject_table)
        Me.subject_tab.Location = New System.Drawing.Point(4, 24)
        Me.subject_tab.Name = "subject_tab"
        Me.subject_tab.Size = New System.Drawing.Size(854, 398)
        Me.subject_tab.TabIndex = 3
        Me.subject_tab.Text = "Subject"
        Me.subject_tab.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(153, 6)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(698, 23)
        Me.TextBox4.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(87, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Search:"
        '
        'subject_add_button
        '
        Me.subject_add_button.Location = New System.Drawing.Point(6, 6)
        Me.subject_add_button.Name = "subject_add_button"
        Me.subject_add_button.Size = New System.Drawing.Size(75, 23)
        Me.subject_add_button.TabIndex = 5
        Me.subject_add_button.Text = "Add New"
        Me.subject_add_button.UseVisualStyleBackColor = True
        '
        'subject_update_button
        '
        Me.subject_update_button.Location = New System.Drawing.Point(6, 35)
        Me.subject_update_button.Name = "subject_update_button"
        Me.subject_update_button.Size = New System.Drawing.Size(75, 23)
        Me.subject_update_button.TabIndex = 6
        Me.subject_update_button.Text = "Update"
        Me.subject_update_button.UseVisualStyleBackColor = True
        '
        'subject_delete_button
        '
        Me.subject_delete_button.Location = New System.Drawing.Point(6, 64)
        Me.subject_delete_button.Name = "subject_delete_button"
        Me.subject_delete_button.Size = New System.Drawing.Size(75, 23)
        Me.subject_delete_button.TabIndex = 7
        Me.subject_delete_button.Text = "Delete"
        Me.subject_delete_button.UseVisualStyleBackColor = True
        '
        'subject_table
        '
        Me.subject_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subject_table.Location = New System.Drawing.Point(87, 35)
        Me.subject_table.Name = "subject_table"
        Me.subject_table.RowHeadersWidth = 51
        Me.subject_table.RowTemplate.Height = 25
        Me.subject_table.Size = New System.Drawing.Size(764, 354)
        Me.subject_table.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(683, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 23)
        Me.ComboBox1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(590, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Search for: "
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(854, 398)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Marks"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(854, 398)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Timetable"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 449)
        Me.Controls.Add(Me.tab_control)
        Me.Name = "Form2"
        Me.Text = "School Database"
        Me.tab_control.ResumeLayout(False)
        Me.student_tab.ResumeLayout(False)
        Me.student_tab.PerformLayout()
        CType(Me.student_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.teacher_tab.ResumeLayout(False)
        Me.teacher_tab.PerformLayout()
        CType(Me.teacher_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.class_tab.ResumeLayout(False)
        Me.class_tab.PerformLayout()
        CType(Me.class_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.subject_tab.ResumeLayout(False)
        Me.subject_tab.PerformLayout()
        CType(Me.subject_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_control As TabControl
    Friend WithEvents student_tab As TabPage
    Friend WithEvents teacher_tab As TabPage
    Friend WithEvents class_tab As TabPage
    Friend WithEvents subject_tab As TabPage
    Friend WithEvents class_add_button As Button
    Friend WithEvents class_update_button As Button
    Friend WithEvents class_delete_button As Button
    Friend WithEvents class_table As DataGridView
    Friend WithEvents subject_add_button As Button
    Friend WithEvents subject_update_button As Button
    Friend WithEvents subject_delete_button As Button
    Friend WithEvents subject_table As DataGridView
    Friend WithEvents student_add_button As Button
    Friend WithEvents student_table As DataGridView
    Friend WithEvents student_delete_button As Button
    Friend WithEvents student_update_button As Button
    Friend WithEvents teacher_add_button As Button
    Friend WithEvents teacher_update_button As Button
    Friend WithEvents teacher_delete_button As Button
    Friend WithEvents teacher_table As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
