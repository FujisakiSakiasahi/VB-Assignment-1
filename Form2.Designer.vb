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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.studentSearch_comboBox = New System.Windows.Forms.ComboBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.studentSearch_textBox = New System.Windows.Forms.TextBox()
        Me.studentAdd_button = New System.Windows.Forms.Button()
        Me.student_table = New System.Windows.Forms.DataGridView()
        Me.studentDelete_button = New System.Windows.Forms.Button()
        Me.studentUpdate_button = New System.Windows.Forms.Button()
        Me.teacher_tab = New System.Windows.Forms.TabPage()
        Me.teacherSearch_comboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teacherSearch_textBox = New System.Windows.Forms.TextBox()
        Me.teacherAdd_button = New System.Windows.Forms.Button()
        Me.teacherUpdate_button = New System.Windows.Forms.Button()
        Me.teacherDelete_button = New System.Windows.Forms.Button()
        Me.teacher_table = New System.Windows.Forms.DataGridView()
        Me.class_tab = New System.Windows.Forms.TabPage()
        Me.classAddClass_button = New System.Windows.Forms.Button()
        Me.classDeleteClass_button = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.classSearch_comboBox = New System.Windows.Forms.ComboBox()
        Me.classSearch_textBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.classAllocStudent_button = New System.Windows.Forms.Button()
        Me.classUpdate_button = New System.Windows.Forms.Button()
        Me.classRemoveStudent_button = New System.Windows.Forms.Button()
        Me.class_table = New System.Windows.Forms.DataGridView()
        Me.subject_tab = New System.Windows.Forms.TabPage()
        Me.subjectSearch_comboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.subjectSearch_textBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.subjectAdd_button = New System.Windows.Forms.Button()
        Me.subjectUpdate_button = New System.Windows.Forms.Button()
        Me.subjectDelete_button = New System.Windows.Forms.Button()
        Me.subject_table = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.marks_table = New System.Windows.Forms.DataGridView()
        Me.marksSearch_comboBox = New System.Windows.Forms.ComboBox()
        Me.marksSearch_textBox = New System.Windows.Forms.TextBox()
        Me.marksDelete_button = New System.Windows.Forms.Button()
        Me.marksUpdate_button = New System.Windows.Forms.Button()
        Me.marksAdd_button = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.periodSearch_textBox = New System.Windows.Forms.TextBox()
        Me.period_table = New System.Windows.Forms.DataGridView()
        Me.periodSearch_comboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.periodDelete_button = New System.Windows.Forms.Button()
        Me.periodUpdate_button = New System.Windows.Forms.Button()
        Me.periodAdd_button = New System.Windows.Forms.Button()
        Me.tab_control.SuspendLayout()
        Me.student_tab.SuspendLayout()
        CType(Me.student_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.teacher_tab.SuspendLayout()
        CType(Me.teacher_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.class_tab.SuspendLayout()
        CType(Me.class_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.subject_tab.SuspendLayout()
        CType(Me.subject_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.marks_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.period_table, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.student_tab.Controls.Add(Me.studentSearch_comboBox)
        Me.student_tab.Controls.Add(Me.Label)
        Me.student_tab.Controls.Add(Me.studentSearch_textBox)
        Me.student_tab.Controls.Add(Me.studentAdd_button)
        Me.student_tab.Controls.Add(Me.student_table)
        Me.student_tab.Controls.Add(Me.studentDelete_button)
        Me.student_tab.Controls.Add(Me.studentUpdate_button)
        Me.student_tab.Location = New System.Drawing.Point(4, 24)
        Me.student_tab.Name = "student_tab"
        Me.student_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.student_tab.Size = New System.Drawing.Size(854, 398)
        Me.student_tab.TabIndex = 0
        Me.student_tab.Text = "Student"
        Me.student_tab.UseVisualStyleBackColor = True
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
        'studentSearch_comboBox
        '
        Me.studentSearch_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.studentSearch_comboBox.FormattingEnabled = True
        Me.studentSearch_comboBox.Location = New System.Drawing.Point(683, 6)
        Me.studentSearch_comboBox.Name = "studentSearch_comboBox"
        Me.studentSearch_comboBox.Size = New System.Drawing.Size(165, 23)
        Me.studentSearch_comboBox.TabIndex = 18
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
        'studentSearch_textBox
        '
        Me.studentSearch_textBox.Location = New System.Drawing.Point(157, 6)
        Me.studentSearch_textBox.Margin = New System.Windows.Forms.Padding(2)
        Me.studentSearch_textBox.Name = "studentSearch_textBox"
        Me.studentSearch_textBox.Size = New System.Drawing.Size(424, 23)
        Me.studentSearch_textBox.TabIndex = 16
        '
        'studentAdd_button
        '
        Me.studentAdd_button.Location = New System.Drawing.Point(6, 6)
        Me.studentAdd_button.Name = "studentAdd_button"
        Me.studentAdd_button.Size = New System.Drawing.Size(75, 23)
        Me.studentAdd_button.TabIndex = 11
        Me.studentAdd_button.Text = "Add New"
        Me.studentAdd_button.UseVisualStyleBackColor = True
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
        'studentDelete_button
        '
        Me.studentDelete_button.Location = New System.Drawing.Point(6, 64)
        Me.studentDelete_button.Name = "studentDelete_button"
        Me.studentDelete_button.Size = New System.Drawing.Size(75, 23)
        Me.studentDelete_button.TabIndex = 13
        Me.studentDelete_button.Text = "Delete"
        Me.studentDelete_button.UseVisualStyleBackColor = True
        '
        'studentUpdate_button
        '
        Me.studentUpdate_button.Location = New System.Drawing.Point(6, 35)
        Me.studentUpdate_button.Name = "studentUpdate_button"
        Me.studentUpdate_button.Size = New System.Drawing.Size(75, 23)
        Me.studentUpdate_button.TabIndex = 12
        Me.studentUpdate_button.Text = "Update"
        Me.studentUpdate_button.UseVisualStyleBackColor = True
        '
        'teacher_tab
        '
        Me.teacher_tab.Controls.Add(Me.teacherSearch_comboBox)
        Me.teacher_tab.Controls.Add(Me.Label9)
        Me.teacher_tab.Controls.Add(Me.Label1)
        Me.teacher_tab.Controls.Add(Me.teacherSearch_textBox)
        Me.teacher_tab.Controls.Add(Me.teacherAdd_button)
        Me.teacher_tab.Controls.Add(Me.teacherUpdate_button)
        Me.teacher_tab.Controls.Add(Me.teacherDelete_button)
        Me.teacher_tab.Controls.Add(Me.teacher_table)
        Me.teacher_tab.Location = New System.Drawing.Point(4, 24)
        Me.teacher_tab.Name = "teacher_tab"
        Me.teacher_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.teacher_tab.Size = New System.Drawing.Size(854, 398)
        Me.teacher_tab.TabIndex = 1
        Me.teacher_tab.Text = "Teacher"
        Me.teacher_tab.UseVisualStyleBackColor = True
        '
        'teacherSearch_comboBox
        '
        Me.teacherSearch_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.teacherSearch_comboBox.FormattingEnabled = True
        Me.teacherSearch_comboBox.Location = New System.Drawing.Point(683, 6)
        Me.teacherSearch_comboBox.Name = "teacherSearch_comboBox"
        Me.teacherSearch_comboBox.Size = New System.Drawing.Size(165, 23)
        Me.teacherSearch_comboBox.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(590, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 21)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Search for: "
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
        'teacherSearch_textBox
        '
        Me.teacherSearch_textBox.Location = New System.Drawing.Point(157, 6)
        Me.teacherSearch_textBox.Name = "teacherSearch_textBox"
        Me.teacherSearch_textBox.Size = New System.Drawing.Size(424, 23)
        Me.teacherSearch_textBox.TabIndex = 10
        '
        'teacherAdd_button
        '
        Me.teacherAdd_button.Location = New System.Drawing.Point(6, 6)
        Me.teacherAdd_button.Name = "teacherAdd_button"
        Me.teacherAdd_button.Size = New System.Drawing.Size(75, 23)
        Me.teacherAdd_button.TabIndex = 5
        Me.teacherAdd_button.Text = "Add New"
        Me.teacherAdd_button.UseVisualStyleBackColor = True
        '
        'teacherUpdate_button
        '
        Me.teacherUpdate_button.Location = New System.Drawing.Point(6, 35)
        Me.teacherUpdate_button.Name = "teacherUpdate_button"
        Me.teacherUpdate_button.Size = New System.Drawing.Size(75, 23)
        Me.teacherUpdate_button.TabIndex = 6
        Me.teacherUpdate_button.Text = "Update"
        Me.teacherUpdate_button.UseVisualStyleBackColor = True
        '
        'teacherDelete_button
        '
        Me.teacherDelete_button.Location = New System.Drawing.Point(6, 64)
        Me.teacherDelete_button.Name = "teacherDelete_button"
        Me.teacherDelete_button.Size = New System.Drawing.Size(75, 23)
        Me.teacherDelete_button.TabIndex = 7
        Me.teacherDelete_button.Text = "Delete"
        Me.teacherDelete_button.UseVisualStyleBackColor = True
        '
        'teacher_table
        '
        Me.teacher_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.teacher_table.Location = New System.Drawing.Point(87, 34)
        Me.teacher_table.Name = "teacher_table"
        Me.teacher_table.RowHeadersWidth = 51
        Me.teacher_table.RowTemplate.Height = 25
        Me.teacher_table.Size = New System.Drawing.Size(761, 358)
        Me.teacher_table.TabIndex = 1
        '
        'class_tab
        '
        Me.class_tab.Controls.Add(Me.classAddClass_button)
        Me.class_tab.Controls.Add(Me.classDeleteClass_button)
        Me.class_tab.Controls.Add(Me.Label10)
        Me.class_tab.Controls.Add(Me.classSearch_comboBox)
        Me.class_tab.Controls.Add(Me.classSearch_textBox)
        Me.class_tab.Controls.Add(Me.Label2)
        Me.class_tab.Controls.Add(Me.classAllocStudent_button)
        Me.class_tab.Controls.Add(Me.classUpdate_button)
        Me.class_tab.Controls.Add(Me.classRemoveStudent_button)
        Me.class_tab.Controls.Add(Me.class_table)
        Me.class_tab.Location = New System.Drawing.Point(4, 24)
        Me.class_tab.Name = "class_tab"
        Me.class_tab.Size = New System.Drawing.Size(854, 398)
        Me.class_tab.TabIndex = 2
        Me.class_tab.Text = "Class"
        Me.class_tab.UseVisualStyleBackColor = True
        '
        'classAddClass_button
        '
        Me.classAddClass_button.Location = New System.Drawing.Point(6, 6)
        Me.classAddClass_button.Name = "classAddClass_button"
        Me.classAddClass_button.Size = New System.Drawing.Size(75, 23)
        Me.classAddClass_button.TabIndex = 15
        Me.classAddClass_button.Text = "Add Class"
        Me.classAddClass_button.UseVisualStyleBackColor = True
        '
        'classDeleteClass_button
        '
        Me.classDeleteClass_button.Location = New System.Drawing.Point(6, 35)
        Me.classDeleteClass_button.Name = "classDeleteClass_button"
        Me.classDeleteClass_button.Size = New System.Drawing.Size(75, 23)
        Me.classDeleteClass_button.TabIndex = 14
        Me.classDeleteClass_button.Text = "Delete Class"
        Me.classDeleteClass_button.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(590, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 21)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Search for: "
        '
        'classSearch_comboBox
        '
        Me.classSearch_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classSearch_comboBox.FormattingEnabled = True
        Me.classSearch_comboBox.Location = New System.Drawing.Point(683, 6)
        Me.classSearch_comboBox.Name = "classSearch_comboBox"
        Me.classSearch_comboBox.Size = New System.Drawing.Size(165, 23)
        Me.classSearch_comboBox.TabIndex = 12
        '
        'classSearch_textBox
        '
        Me.classSearch_textBox.Location = New System.Drawing.Point(157, 6)
        Me.classSearch_textBox.Name = "classSearch_textBox"
        Me.classSearch_textBox.Size = New System.Drawing.Size(424, 23)
        Me.classSearch_textBox.TabIndex = 11
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
        'classAllocStudent_button
        '
        Me.classAllocStudent_button.Location = New System.Drawing.Point(6, 64)
        Me.classAllocStudent_button.Name = "classAllocStudent_button"
        Me.classAllocStudent_button.Size = New System.Drawing.Size(75, 23)
        Me.classAllocStudent_button.TabIndex = 5
        Me.classAllocStudent_button.Text = "Allocate Student"
        Me.classAllocStudent_button.UseVisualStyleBackColor = True
        '
        'classUpdate_button
        '
        Me.classUpdate_button.Location = New System.Drawing.Point(6, 93)
        Me.classUpdate_button.Name = "classUpdate_button"
        Me.classUpdate_button.Size = New System.Drawing.Size(75, 23)
        Me.classUpdate_button.TabIndex = 6
        Me.classUpdate_button.Text = "Update"
        Me.classUpdate_button.UseVisualStyleBackColor = True
        '
        'classRemoveStudent_button
        '
        Me.classRemoveStudent_button.Location = New System.Drawing.Point(6, 122)
        Me.classRemoveStudent_button.Name = "classRemoveStudent_button"
        Me.classRemoveStudent_button.Size = New System.Drawing.Size(75, 23)
        Me.classRemoveStudent_button.TabIndex = 7
        Me.classRemoveStudent_button.Text = "Remove Student"
        Me.classRemoveStudent_button.UseVisualStyleBackColor = True
        '
        'class_table
        '
        Me.class_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.class_table.Location = New System.Drawing.Point(87, 34)
        Me.class_table.Name = "class_table"
        Me.class_table.RowHeadersWidth = 51
        Me.class_table.RowTemplate.Height = 25
        Me.class_table.Size = New System.Drawing.Size(761, 358)
        Me.class_table.TabIndex = 1
        '
        'subject_tab
        '
        Me.subject_tab.Controls.Add(Me.subjectSearch_comboBox)
        Me.subject_tab.Controls.Add(Me.Label11)
        Me.subject_tab.Controls.Add(Me.subjectSearch_textBox)
        Me.subject_tab.Controls.Add(Me.Label3)
        Me.subject_tab.Controls.Add(Me.subjectAdd_button)
        Me.subject_tab.Controls.Add(Me.subjectUpdate_button)
        Me.subject_tab.Controls.Add(Me.subjectDelete_button)
        Me.subject_tab.Controls.Add(Me.subject_table)
        Me.subject_tab.Location = New System.Drawing.Point(4, 24)
        Me.subject_tab.Name = "subject_tab"
        Me.subject_tab.Size = New System.Drawing.Size(854, 398)
        Me.subject_tab.TabIndex = 3
        Me.subject_tab.Text = "Subject"
        Me.subject_tab.UseVisualStyleBackColor = True
        '
        'subjectSearch_comboBox
        '
        Me.subjectSearch_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subjectSearch_comboBox.FormattingEnabled = True
        Me.subjectSearch_comboBox.Location = New System.Drawing.Point(683, 6)
        Me.subjectSearch_comboBox.Name = "subjectSearch_comboBox"
        Me.subjectSearch_comboBox.Size = New System.Drawing.Size(165, 23)
        Me.subjectSearch_comboBox.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(590, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 21)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Search for: "
        '
        'subjectSearch_textBox
        '
        Me.subjectSearch_textBox.Location = New System.Drawing.Point(157, 6)
        Me.subjectSearch_textBox.Name = "subjectSearch_textBox"
        Me.subjectSearch_textBox.Size = New System.Drawing.Size(424, 23)
        Me.subjectSearch_textBox.TabIndex = 11
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
        'subjectAdd_button
        '
        Me.subjectAdd_button.Location = New System.Drawing.Point(6, 6)
        Me.subjectAdd_button.Name = "subjectAdd_button"
        Me.subjectAdd_button.Size = New System.Drawing.Size(75, 23)
        Me.subjectAdd_button.TabIndex = 5
        Me.subjectAdd_button.Text = "Add New"
        Me.subjectAdd_button.UseVisualStyleBackColor = True
        '
        'subjectUpdate_button
        '
        Me.subjectUpdate_button.Location = New System.Drawing.Point(6, 35)
        Me.subjectUpdate_button.Name = "subjectUpdate_button"
        Me.subjectUpdate_button.Size = New System.Drawing.Size(75, 23)
        Me.subjectUpdate_button.TabIndex = 6
        Me.subjectUpdate_button.Text = "Update"
        Me.subjectUpdate_button.UseVisualStyleBackColor = True
        '
        'subjectDelete_button
        '
        Me.subjectDelete_button.Location = New System.Drawing.Point(6, 64)
        Me.subjectDelete_button.Name = "subjectDelete_button"
        Me.subjectDelete_button.Size = New System.Drawing.Size(75, 23)
        Me.subjectDelete_button.TabIndex = 7
        Me.subjectDelete_button.Text = "Delete"
        Me.subjectDelete_button.UseVisualStyleBackColor = True
        '
        'subject_table
        '
        Me.subject_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subject_table.Location = New System.Drawing.Point(87, 34)
        Me.subject_table.Name = "subject_table"
        Me.subject_table.RowHeadersWidth = 51
        Me.subject_table.RowTemplate.Height = 25
        Me.subject_table.Size = New System.Drawing.Size(761, 358)
        Me.subject_table.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.marks_table)
        Me.TabPage1.Controls.Add(Me.marksSearch_comboBox)
        Me.TabPage1.Controls.Add(Me.marksSearch_textBox)
        Me.TabPage1.Controls.Add(Me.marksDelete_button)
        Me.TabPage1.Controls.Add(Me.marksUpdate_button)
        Me.TabPage1.Controls.Add(Me.marksAdd_button)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(854, 398)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Marks"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(590, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Search for: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(87, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Search: "
        '
        'marks_table
        '
        Me.marks_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.marks_table.Location = New System.Drawing.Point(87, 34)
        Me.marks_table.Name = "marks_table"
        Me.marks_table.RowHeadersWidth = 62
        Me.marks_table.RowTemplate.Height = 25
        Me.marks_table.Size = New System.Drawing.Size(761, 358)
        Me.marks_table.TabIndex = 5
        '
        'marksSearch_comboBox
        '
        Me.marksSearch_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.marksSearch_comboBox.FormattingEnabled = True
        Me.marksSearch_comboBox.Location = New System.Drawing.Point(683, 6)
        Me.marksSearch_comboBox.Name = "marksSearch_comboBox"
        Me.marksSearch_comboBox.Size = New System.Drawing.Size(165, 23)
        Me.marksSearch_comboBox.TabIndex = 4
        '
        'marksSearch_textBox
        '
        Me.marksSearch_textBox.Location = New System.Drawing.Point(157, 6)
        Me.marksSearch_textBox.Name = "marksSearch_textBox"
        Me.marksSearch_textBox.Size = New System.Drawing.Size(424, 23)
        Me.marksSearch_textBox.TabIndex = 3
        '
        'marksDelete_button
        '
        Me.marksDelete_button.Location = New System.Drawing.Point(6, 64)
        Me.marksDelete_button.Name = "marksDelete_button"
        Me.marksDelete_button.Size = New System.Drawing.Size(75, 23)
        Me.marksDelete_button.TabIndex = 2
        Me.marksDelete_button.Text = "Delete"
        Me.marksDelete_button.UseVisualStyleBackColor = True
        '
        'marksUpdate_button
        '
        Me.marksUpdate_button.Location = New System.Drawing.Point(6, 35)
        Me.marksUpdate_button.Name = "marksUpdate_button"
        Me.marksUpdate_button.Size = New System.Drawing.Size(75, 23)
        Me.marksUpdate_button.TabIndex = 1
        Me.marksUpdate_button.Text = "Update"
        Me.marksUpdate_button.UseVisualStyleBackColor = True
        '
        'marksAdd_button
        '
        Me.marksAdd_button.Location = New System.Drawing.Point(6, 6)
        Me.marksAdd_button.Name = "marksAdd_button"
        Me.marksAdd_button.Size = New System.Drawing.Size(75, 23)
        Me.marksAdd_button.TabIndex = 0
        Me.marksAdd_button.Text = "Add New"
        Me.marksAdd_button.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.periodSearch_textBox)
        Me.TabPage2.Controls.Add(Me.period_table)
        Me.TabPage2.Controls.Add(Me.periodSearch_comboBox)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.periodDelete_button)
        Me.TabPage2.Controls.Add(Me.periodUpdate_button)
        Me.TabPage2.Controls.Add(Me.periodAdd_button)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(854, 398)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Period"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'periodSearch_textBox
        '
        Me.periodSearch_textBox.Location = New System.Drawing.Point(157, 6)
        Me.periodSearch_textBox.Name = "periodSearch_textBox"
        Me.periodSearch_textBox.Size = New System.Drawing.Size(424, 23)
        Me.periodSearch_textBox.TabIndex = 7
        '
        'period_table
        '
        Me.period_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.period_table.Location = New System.Drawing.Point(87, 34)
        Me.period_table.Name = "period_table"
        Me.period_table.RowHeadersWidth = 62
        Me.period_table.RowTemplate.Height = 25
        Me.period_table.Size = New System.Drawing.Size(761, 358)
        Me.period_table.TabIndex = 6
        '
        'periodSearch_comboBox
        '
        Me.periodSearch_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.periodSearch_comboBox.FormattingEnabled = True
        Me.periodSearch_comboBox.Location = New System.Drawing.Point(683, 6)
        Me.periodSearch_comboBox.Name = "periodSearch_comboBox"
        Me.periodSearch_comboBox.Size = New System.Drawing.Size(165, 23)
        Me.periodSearch_comboBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(590, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Search for: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(87, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Search: "
        '
        'periodDelete_button
        '
        Me.periodDelete_button.Location = New System.Drawing.Point(6, 64)
        Me.periodDelete_button.Name = "periodDelete_button"
        Me.periodDelete_button.Size = New System.Drawing.Size(75, 23)
        Me.periodDelete_button.TabIndex = 2
        Me.periodDelete_button.Text = "Delete"
        Me.periodDelete_button.UseVisualStyleBackColor = True
        '
        'periodUpdate_button
        '
        Me.periodUpdate_button.Location = New System.Drawing.Point(6, 35)
        Me.periodUpdate_button.Name = "periodUpdate_button"
        Me.periodUpdate_button.Size = New System.Drawing.Size(75, 23)
        Me.periodUpdate_button.TabIndex = 1
        Me.periodUpdate_button.Text = "Update"
        Me.periodUpdate_button.UseVisualStyleBackColor = True
        '
        'periodAdd_button
        '
        Me.periodAdd_button.Location = New System.Drawing.Point(6, 6)
        Me.periodAdd_button.Name = "periodAdd_button"
        Me.periodAdd_button.Size = New System.Drawing.Size(75, 23)
        Me.periodAdd_button.TabIndex = 0
        Me.periodAdd_button.Text = "Add New"
        Me.periodAdd_button.UseVisualStyleBackColor = True
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
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.marks_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.period_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_control As TabControl
    Friend WithEvents student_tab As TabPage
    Friend WithEvents teacher_tab As TabPage
    Friend WithEvents class_tab As TabPage
    Friend WithEvents subject_tab As TabPage
    Friend WithEvents classAllocStudent_button As Button
    Friend WithEvents classUpdate_button As Button
    Friend WithEvents classRemoveStudent_button As Button
    Friend WithEvents class_table As DataGridView
    Friend WithEvents subjectAdd_button As Button
    Friend WithEvents subjectUpdate_button As Button
    Friend WithEvents subjectDelete_button As Button
    Friend WithEvents subject_table As DataGridView
    Friend WithEvents studentAdd_button As Button
    Friend WithEvents student_table As DataGridView
    Friend WithEvents studentDelete_button As Button
    Friend WithEvents studentUpdate_button As Button
    Friend WithEvents teacherAdd_button As Button
    Friend WithEvents teacherUpdate_button As Button
    Friend WithEvents teacherDelete_button As Button
    Friend WithEvents teacher_table As DataGridView
    Friend WithEvents studentSearch_textBox As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents teacherSearch_textBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents classSearch_textBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents subjectSearch_textBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents studentSearch_comboBox As ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents teacherSearch_comboBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents classSearch_comboBox As ComboBox
    Friend WithEvents subjectSearch_comboBox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents marks_table As DataGridView
    Friend WithEvents marksSearch_comboBox As ComboBox
    Friend WithEvents marksSearch_textBox As TextBox
    Friend WithEvents marksDelete_button As Button
    Friend WithEvents marksUpdate_button As Button
    Friend WithEvents marksAdd_button As Button
    Friend WithEvents periodSearch_textBox As TextBox
    Friend WithEvents period_table As DataGridView
    Friend WithEvents periodSearch_comboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents periodDelete_button As Button
    Friend WithEvents periodUpdate_button As Button
    Friend WithEvents periodAdd_button As Button
    Friend WithEvents classAddClass_button As Button
    Friend WithEvents classDeleteClass_button As Button
End Class
