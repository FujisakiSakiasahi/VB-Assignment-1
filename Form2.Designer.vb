<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.student_tab = New System.Windows.Forms.TabPage()
        Me.student_add_button = New System.Windows.Forms.Button()
        Me.student_table = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.student_delete_button = New System.Windows.Forms.Button()
        Me.student_update_button = New System.Windows.Forms.Button()
        Me.student_search_button = New System.Windows.Forms.Button()
        Me.teacher_tab = New System.Windows.Forms.TabPage()
        Me.teacher_add_button = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.teacher_update_button = New System.Windows.Forms.Button()
        Me.teacher_search_button = New System.Windows.Forms.Button()
        Me.teacher_delete_button = New System.Windows.Forms.Button()
        Me.teacher_table = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.class_tab = New System.Windows.Forms.TabPage()
        Me.class_add_button = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.class_update_button = New System.Windows.Forms.Button()
        Me.class_search_button = New System.Windows.Forms.Button()
        Me.class_delete_button = New System.Windows.Forms.Button()
        Me.class_table = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subject_tab = New System.Windows.Forms.TabPage()
        Me.subject_add_button = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.subject_update_button = New System.Windows.Forms.Button()
        Me.subject_search_button = New System.Windows.Forms.Button()
        Me.subject_delete_button = New System.Windows.Forms.Button()
        Me.subject_table = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.student_tab)
        Me.TabControl1.Controls.Add(Me.teacher_tab)
        Me.TabControl1.Controls.Add(Me.class_tab)
        Me.TabControl1.Controls.Add(Me.subject_tab)
        Me.TabControl1.Location = New System.Drawing.Point(13, 20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1394, 710)
        Me.TabControl1.TabIndex = 1
        '
        'student_tab
        '
        Me.student_tab.Controls.Add(Me.student_add_button)
        Me.student_tab.Controls.Add(Me.student_table)
        Me.student_tab.Controls.Add(Me.Button2)
        Me.student_tab.Controls.Add(Me.student_delete_button)
        Me.student_tab.Controls.Add(Me.student_update_button)
        Me.student_tab.Controls.Add(Me.student_search_button)
        Me.student_tab.Location = New System.Drawing.Point(4, 34)
        Me.student_tab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.student_tab.Name = "student_tab"
        Me.student_tab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.student_tab.Size = New System.Drawing.Size(1386, 672)
        Me.student_tab.TabIndex = 0
        Me.student_tab.Text = "Student"
        Me.student_tab.UseVisualStyleBackColor = True
        '
        'student_add_button
        '
        Me.student_add_button.Location = New System.Drawing.Point(33, 35)
        Me.student_add_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.student_add_button.Name = "student_add_button"
        Me.student_add_button.Size = New System.Drawing.Size(107, 38)
        Me.student_add_button.TabIndex = 11
        Me.student_add_button.Text = "Add New"
        Me.student_add_button.UseVisualStyleBackColor = True
        '
        'student_table
        '
        Me.student_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.student_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.student_table.Location = New System.Drawing.Point(173, 10)
        Me.student_table.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.student_table.Name = "student_table"
        Me.student_table.RowHeadersWidth = 51
        Me.student_table.RowTemplate.Height = 25
        Me.student_table.Size = New System.Drawing.Size(1205, 652)
        Me.student_table.TabIndex = 10
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Column3"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Column4"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Column5"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Column6"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 125
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(33, 227)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 38)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'student_delete_button
        '
        Me.student_delete_button.Location = New System.Drawing.Point(33, 132)
        Me.student_delete_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.student_delete_button.Name = "student_delete_button"
        Me.student_delete_button.Size = New System.Drawing.Size(107, 38)
        Me.student_delete_button.TabIndex = 13
        Me.student_delete_button.Text = "Delete"
        Me.student_delete_button.UseVisualStyleBackColor = True
        '
        'student_update_button
        '
        Me.student_update_button.Location = New System.Drawing.Point(33, 83)
        Me.student_update_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.student_update_button.Name = "student_update_button"
        Me.student_update_button.Size = New System.Drawing.Size(107, 38)
        Me.student_update_button.TabIndex = 12
        Me.student_update_button.Text = "Update"
        Me.student_update_button.UseVisualStyleBackColor = True
        '
        'student_search_button
        '
        Me.student_search_button.Location = New System.Drawing.Point(33, 180)
        Me.student_search_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.student_search_button.Name = "student_search_button"
        Me.student_search_button.Size = New System.Drawing.Size(107, 38)
        Me.student_search_button.TabIndex = 14
        Me.student_search_button.Text = "Search"
        Me.student_search_button.UseVisualStyleBackColor = True
        '
        'teacher_tab
        '
        Me.teacher_tab.Controls.Add(Me.teacher_add_button)
        Me.teacher_tab.Controls.Add(Me.Button7)
        Me.teacher_tab.Controls.Add(Me.teacher_update_button)
        Me.teacher_tab.Controls.Add(Me.teacher_search_button)
        Me.teacher_tab.Controls.Add(Me.teacher_delete_button)
        Me.teacher_tab.Controls.Add(Me.teacher_table)
        Me.teacher_tab.Location = New System.Drawing.Point(4, 34)
        Me.teacher_tab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.teacher_tab.Name = "teacher_tab"
        Me.teacher_tab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.teacher_tab.Size = New System.Drawing.Size(1386, 672)
        Me.teacher_tab.TabIndex = 1
        Me.teacher_tab.Text = "Teacher"
        Me.teacher_tab.UseVisualStyleBackColor = True
        '
        'teacher_add_button
        '
        Me.teacher_add_button.Location = New System.Drawing.Point(33, 35)
        Me.teacher_add_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.teacher_add_button.Name = "teacher_add_button"
        Me.teacher_add_button.Size = New System.Drawing.Size(107, 38)
        Me.teacher_add_button.TabIndex = 5
        Me.teacher_add_button.Text = "Add New"
        Me.teacher_add_button.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(33, 227)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 38)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'teacher_update_button
        '
        Me.teacher_update_button.Location = New System.Drawing.Point(33, 83)
        Me.teacher_update_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.teacher_update_button.Name = "teacher_update_button"
        Me.teacher_update_button.Size = New System.Drawing.Size(107, 38)
        Me.teacher_update_button.TabIndex = 6
        Me.teacher_update_button.Text = "Update"
        Me.teacher_update_button.UseVisualStyleBackColor = True
        '
        'teacher_search_button
        '
        Me.teacher_search_button.Location = New System.Drawing.Point(33, 180)
        Me.teacher_search_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.teacher_search_button.Name = "teacher_search_button"
        Me.teacher_search_button.Size = New System.Drawing.Size(107, 38)
        Me.teacher_search_button.TabIndex = 8
        Me.teacher_search_button.Text = "Search"
        Me.teacher_search_button.UseVisualStyleBackColor = True
        '
        'teacher_delete_button
        '
        Me.teacher_delete_button.Location = New System.Drawing.Point(33, 132)
        Me.teacher_delete_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.teacher_delete_button.Name = "teacher_delete_button"
        Me.teacher_delete_button.Size = New System.Drawing.Size(107, 38)
        Me.teacher_delete_button.TabIndex = 7
        Me.teacher_delete_button.Text = "Delete"
        Me.teacher_delete_button.UseVisualStyleBackColor = True
        '
        'teacher_table
        '
        Me.teacher_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.teacher_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.teacher_table.Location = New System.Drawing.Point(173, 15)
        Me.teacher_table.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.teacher_table.Name = "teacher_table"
        Me.teacher_table.RowHeadersWidth = 51
        Me.teacher_table.RowTemplate.Height = 25
        Me.teacher_table.Size = New System.Drawing.Size(1205, 633)
        Me.teacher_table.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Column3"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Column4"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Column5"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Column6"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'class_tab
        '
        Me.class_tab.Controls.Add(Me.class_add_button)
        Me.class_tab.Controls.Add(Me.Button12)
        Me.class_tab.Controls.Add(Me.class_update_button)
        Me.class_tab.Controls.Add(Me.class_search_button)
        Me.class_tab.Controls.Add(Me.class_delete_button)
        Me.class_tab.Controls.Add(Me.class_table)
        Me.class_tab.Location = New System.Drawing.Point(4, 34)
        Me.class_tab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.class_tab.Name = "class_tab"
        Me.class_tab.Size = New System.Drawing.Size(1386, 672)
        Me.class_tab.TabIndex = 2
        Me.class_tab.Text = "Class"
        Me.class_tab.UseVisualStyleBackColor = True
        '
        'class_add_button
        '
        Me.class_add_button.Location = New System.Drawing.Point(33, 35)
        Me.class_add_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.class_add_button.Name = "class_add_button"
        Me.class_add_button.Size = New System.Drawing.Size(107, 38)
        Me.class_add_button.TabIndex = 5
        Me.class_add_button.Text = "Add New"
        Me.class_add_button.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(33, 227)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(107, 38)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'class_update_button
        '
        Me.class_update_button.Location = New System.Drawing.Point(33, 83)
        Me.class_update_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.class_update_button.Name = "class_update_button"
        Me.class_update_button.Size = New System.Drawing.Size(107, 38)
        Me.class_update_button.TabIndex = 6
        Me.class_update_button.Text = "Update"
        Me.class_update_button.UseVisualStyleBackColor = True
        '
        'class_search_button
        '
        Me.class_search_button.Location = New System.Drawing.Point(33, 180)
        Me.class_search_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.class_search_button.Name = "class_search_button"
        Me.class_search_button.Size = New System.Drawing.Size(107, 38)
        Me.class_search_button.TabIndex = 8
        Me.class_search_button.Text = "Search"
        Me.class_search_button.UseVisualStyleBackColor = True
        '
        'class_delete_button
        '
        Me.class_delete_button.Location = New System.Drawing.Point(33, 132)
        Me.class_delete_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.class_delete_button.Name = "class_delete_button"
        Me.class_delete_button.Size = New System.Drawing.Size(107, 38)
        Me.class_delete_button.TabIndex = 7
        Me.class_delete_button.Text = "Delete"
        Me.class_delete_button.UseVisualStyleBackColor = True
        '
        'class_table
        '
        Me.class_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.class_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.class_table.Location = New System.Drawing.Point(173, 15)
        Me.class_table.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.class_table.Name = "class_table"
        Me.class_table.RowHeadersWidth = 51
        Me.class_table.RowTemplate.Height = 25
        Me.class_table.Size = New System.Drawing.Size(1209, 633)
        Me.class_table.TabIndex = 1
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Column3"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Column4"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Column5"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Column6"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'subject_tab
        '
        Me.subject_tab.Controls.Add(Me.subject_add_button)
        Me.subject_tab.Controls.Add(Me.Button17)
        Me.subject_tab.Controls.Add(Me.subject_update_button)
        Me.subject_tab.Controls.Add(Me.subject_search_button)
        Me.subject_tab.Controls.Add(Me.subject_delete_button)
        Me.subject_tab.Controls.Add(Me.subject_table)
        Me.subject_tab.Location = New System.Drawing.Point(4, 34)
        Me.subject_tab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.subject_tab.Name = "subject_tab"
        Me.subject_tab.Size = New System.Drawing.Size(1386, 672)
        Me.subject_tab.TabIndex = 3
        Me.subject_tab.Text = "Subject"
        Me.subject_tab.UseVisualStyleBackColor = True
        '
        'subject_add_button
        '
        Me.subject_add_button.Location = New System.Drawing.Point(33, 35)
        Me.subject_add_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.subject_add_button.Name = "subject_add_button"
        Me.subject_add_button.Size = New System.Drawing.Size(107, 38)
        Me.subject_add_button.TabIndex = 5
        Me.subject_add_button.Text = "Add New"
        Me.subject_add_button.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(33, 228)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(107, 38)
        Me.Button17.TabIndex = 9
        Me.Button17.Text = "Button17"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'subject_update_button
        '
        Me.subject_update_button.Location = New System.Drawing.Point(33, 83)
        Me.subject_update_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.subject_update_button.Name = "subject_update_button"
        Me.subject_update_button.Size = New System.Drawing.Size(107, 38)
        Me.subject_update_button.TabIndex = 6
        Me.subject_update_button.Text = "Update"
        Me.subject_update_button.UseVisualStyleBackColor = True
        '
        'subject_search_button
        '
        Me.subject_search_button.Location = New System.Drawing.Point(33, 180)
        Me.subject_search_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.subject_search_button.Name = "subject_search_button"
        Me.subject_search_button.Size = New System.Drawing.Size(107, 38)
        Me.subject_search_button.TabIndex = 8
        Me.subject_search_button.Text = "Search"
        Me.subject_search_button.UseVisualStyleBackColor = True
        '
        'subject_delete_button
        '
        Me.subject_delete_button.Location = New System.Drawing.Point(33, 132)
        Me.subject_delete_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.subject_delete_button.Name = "subject_delete_button"
        Me.subject_delete_button.Size = New System.Drawing.Size(107, 38)
        Me.subject_delete_button.TabIndex = 7
        Me.subject_delete_button.Text = "Delete"
        Me.subject_delete_button.UseVisualStyleBackColor = True
        '
        'subject_table
        '
        Me.subject_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subject_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.subject_table.Location = New System.Drawing.Point(173, 15)
        Me.subject_table.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.subject_table.Name = "subject_table"
        Me.subject_table.RowHeadersWidth = 51
        Me.subject_table.RowTemplate.Height = 25
        Me.subject_table.Size = New System.Drawing.Size(1209, 633)
        Me.subject_table.TabIndex = 1
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Column3"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Column4"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Column5"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Column6"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 750)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form2"
        Me.Text = "School Database"
        Me.TabControl1.ResumeLayout(False)
        Me.student_tab.ResumeLayout(False)
        CType(Me.student_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.teacher_tab.ResumeLayout(False)
        CType(Me.teacher_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.class_tab.ResumeLayout(False)
        CType(Me.class_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.subject_tab.ResumeLayout(False)
        CType(Me.subject_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents student_tab As TabPage
    Friend WithEvents teacher_tab As TabPage
    Friend WithEvents class_tab As TabPage
    Friend WithEvents subject_tab As TabPage
    Friend WithEvents class_add_button As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents class_update_button As Button
    Friend WithEvents class_search_button As Button
    Friend WithEvents class_delete_button As Button
    Friend WithEvents class_table As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents subject_add_button As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents subject_update_button As Button
    Friend WithEvents subject_search_button As Button
    Friend WithEvents subject_delete_button As Button
    Friend WithEvents subject_table As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents student_add_button As Button
    Friend WithEvents student_table As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents student_delete_button As Button
    Friend WithEvents student_update_button As Button
    Friend WithEvents student_search_button As Button
    Friend WithEvents teacher_add_button As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents teacher_update_button As Button
    Friend WithEvents teacher_search_button As Button
    Friend WithEvents teacher_delete_button As Button
    Friend WithEvents teacher_table As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
