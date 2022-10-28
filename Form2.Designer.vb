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
        Me.student_soptions_label = New System.Windows.Forms.Label()
        Me.student_soptions_dropdown = New System.Windows.Forms.ComboBox()
        Me.student_search_label = New System.Windows.Forms.Label()
        Me.student_search_textbox = New System.Windows.Forms.TextBox()
        Me.student_add_button = New System.Windows.Forms.Button()
        Me.student_table = New System.Windows.Forms.DataGridView()
        Me.student_delete_button = New System.Windows.Forms.Button()
        Me.student_update_button = New System.Windows.Forms.Button()
        Me.teacher_tab = New System.Windows.Forms.TabPage()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.teacher_add_button = New System.Windows.Forms.Button()
        Me.teacher_update_button = New System.Windows.Forms.Button()
        Me.teacher_delete_button = New System.Windows.Forms.Button()
        Me.teacher_table = New System.Windows.Forms.DataGridView()
        Me.class_tab = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.class_add_button = New System.Windows.Forms.Button()
        Me.class_update_button = New System.Windows.Forms.Button()
        Me.class_delete_button = New System.Windows.Forms.Button()
        Me.class_table = New System.Windows.Forms.DataGridView()
        Me.subject_tab = New System.Windows.Forms.TabPage()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.subject_add_button = New System.Windows.Forms.Button()
        Me.subject_update_button = New System.Windows.Forms.Button()
        Me.subject_delete_button = New System.Windows.Forms.Button()
        Me.subject_table = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.marks_table = New System.Windows.Forms.DataGridView()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.period_table = New System.Windows.Forms.DataGridView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.student_tab.Controls.Add(Me.student_soptions_label)
        Me.student_tab.Controls.Add(Me.student_soptions_dropdown)
        Me.student_tab.Controls.Add(Me.student_search_label)
        Me.student_tab.Controls.Add(Me.student_search_textbox)
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
        'student_soptions_label
        '
        Me.student_soptions_label.AutoSize = True
        Me.student_soptions_label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.student_soptions_label.Location = New System.Drawing.Point(590, 6)
        Me.student_soptions_label.Name = "student_soptions_label"
        Me.student_soptions_label.Size = New System.Drawing.Size(88, 21)
        Me.student_soptions_label.TabIndex = 19
        Me.student_soptions_label.Text = "Search for: "
        '
        'student_soptions_dropdown
        '
        Me.student_soptions_dropdown.FormattingEnabled = True
        Me.student_soptions_dropdown.Location = New System.Drawing.Point(683, 6)
        Me.student_soptions_dropdown.Name = "student_soptions_dropdown"
        Me.student_soptions_dropdown.Size = New System.Drawing.Size(165, 23)
        Me.student_soptions_dropdown.TabIndex = 18
        '
        'student_search_label
        '
        Me.student_search_label.AutoSize = True
        Me.student_search_label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.student_search_label.Location = New System.Drawing.Point(87, 6)
        Me.student_search_label.Name = "student_search_label"
        Me.student_search_label.Size = New System.Drawing.Size(64, 21)
        Me.student_search_label.TabIndex = 17
        Me.student_search_label.Text = "Search: "
        '
        'student_search_textbox
        '
        Me.student_search_textbox.Location = New System.Drawing.Point(157, 6)
        Me.student_search_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.student_search_textbox.Name = "student_search_textbox"
        Me.student_search_textbox.Size = New System.Drawing.Size(424, 23)
        Me.student_search_textbox.TabIndex = 16
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
        Me.teacher_tab.Controls.Add(Me.ComboBox4)
        Me.teacher_tab.Controls.Add(Me.Label9)
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
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(683, 6)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(165, 23)
        Me.ComboBox4.TabIndex = 13
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(157, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(424, 23)
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
        Me.teacher_table.Location = New System.Drawing.Point(87, 34)
        Me.teacher_table.Name = "teacher_table"
        Me.teacher_table.RowHeadersWidth = 51
        Me.teacher_table.RowTemplate.Height = 25
        Me.teacher_table.Size = New System.Drawing.Size(761, 358)
        Me.teacher_table.TabIndex = 1
        '
        'class_tab
        '
        Me.class_tab.Controls.Add(Me.Label10)
        Me.class_tab.Controls.Add(Me.ComboBox5)
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
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(683, 6)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(165, 23)
        Me.ComboBox5.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(157, 6)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(424, 23)
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
        Me.class_table.Location = New System.Drawing.Point(87, 34)
        Me.class_table.Name = "class_table"
        Me.class_table.RowHeadersWidth = 51
        Me.class_table.RowTemplate.Height = 25
        Me.class_table.Size = New System.Drawing.Size(761, 358)
        Me.class_table.TabIndex = 1
        '
        'subject_tab
        '
        Me.subject_tab.Controls.Add(Me.ComboBox6)
        Me.subject_tab.Controls.Add(Me.Label11)
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
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(683, 6)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(165, 23)
        Me.ComboBox6.TabIndex = 13
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
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(157, 6)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(424, 23)
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
        Me.TabPage1.Controls.Add(Me.ComboBox3)
        Me.TabPage1.Controls.Add(Me.TextBox6)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
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
        Me.marks_table.RowTemplate.Height = 25
        Me.marks_table.Size = New System.Drawing.Size(761, 358)
        Me.marks_table.TabIndex = 5
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(683, 6)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(165, 23)
        Me.ComboBox3.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(157, 6)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(424, 23)
        Me.TextBox6.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.period_table)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(854, 398)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Period"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(157, 6)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(424, 23)
        Me.TextBox5.TabIndex = 7
        '
        'period_table
        '
        Me.period_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.period_table.Location = New System.Drawing.Point(87, 34)
        Me.period_table.Name = "period_table"
        Me.period_table.RowTemplate.Height = 25
        Me.period_table.Size = New System.Drawing.Size(761, 358)
        Me.period_table.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(683, 6)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(165, 23)
        Me.ComboBox2.TabIndex = 5
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
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 35)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Add New"
        Me.Button4.UseVisualStyleBackColor = True
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
    Friend WithEvents student_search_textbox As TextBox
    Friend WithEvents student_search_label As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents student_soptions_label As Label
    Friend WithEvents student_soptions_dropdown As ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents marks_table As DataGridView
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents period_table As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
End Class
