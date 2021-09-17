<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KarateMemberDates
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
        Me.components = New System.ComponentModel.Container()
        Me.lblSelectADate = New System.Windows.Forms.Label()
        Me.dtpMemberDate = New System.Windows.Forms.DateTimePicker()
        Me.lblMembersJoined = New System.Windows.Forms.Label()
        Me.rdBtnBeforeDate = New System.Windows.Forms.RadioButton()
        Me.rdBtnAfterDate = New System.Windows.Forms.RadioButton()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KarateJoinDateDataSet = New KarateQueries.KarateJoinDateDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter1 = New KarateQueries.KarateJoinDateDataSetTableAdapters.MembersTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateJoinDateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectADate
        '
        Me.lblSelectADate.AutoSize = True
        Me.lblSelectADate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectADate.Location = New System.Drawing.Point(125, 83)
        Me.lblSelectADate.Name = "lblSelectADate"
        Me.lblSelectADate.Size = New System.Drawing.Size(92, 16)
        Me.lblSelectADate.TabIndex = 0
        Me.lblSelectADate.Text = "Select a Date:"
        '
        'dtpMemberDate
        '
        Me.dtpMemberDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMemberDate.Location = New System.Drawing.Point(223, 80)
        Me.dtpMemberDate.Name = "dtpMemberDate"
        Me.dtpMemberDate.Size = New System.Drawing.Size(102, 20)
        Me.dtpMemberDate.TabIndex = 1
        '
        'lblMembersJoined
        '
        Me.lblMembersJoined.AutoSize = True
        Me.lblMembersJoined.Location = New System.Drawing.Point(76, 126)
        Me.lblMembersJoined.Name = "lblMembersJoined"
        Me.lblMembersJoined.Size = New System.Drawing.Size(113, 13)
        Me.lblMembersJoined.TabIndex = 2
        Me.lblMembersJoined.Text = "Members who joined..."
        '
        'rdBtnBeforeDate
        '
        Me.rdBtnBeforeDate.AutoSize = True
        Me.rdBtnBeforeDate.Location = New System.Drawing.Point(223, 126)
        Me.rdBtnBeforeDate.Name = "rdBtnBeforeDate"
        Me.rdBtnBeforeDate.Size = New System.Drawing.Size(99, 17)
        Me.rdBtnBeforeDate.TabIndex = 3
        Me.rdBtnBeforeDate.TabStop = True
        Me.rdBtnBeforeDate.Text = "Before this date"
        Me.rdBtnBeforeDate.UseVisualStyleBackColor = True
        '
        'rdBtnAfterDate
        '
        Me.rdBtnAfterDate.AutoSize = True
        Me.rdBtnAfterDate.Location = New System.Drawing.Point(344, 126)
        Me.rdBtnAfterDate.Name = "rdBtnAfterDate"
        Me.rdBtnAfterDate.Size = New System.Drawing.Size(118, 17)
        Me.rdBtnAfterDate.TabIndex = 4
        Me.rdBtnAfterDate.TabStop = True
        Me.rdBtnAfterDate.Text = "On or after this date"
        Me.rdBtnAfterDate.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(612, 24)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem3.Text = "&Close"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(33, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(551, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'KarateJoinDateDataSet
        '
        Me.KarateJoinDateDataSet.DataSetName = "KarateJoinDateDataSet"
        Me.KarateJoinDateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Members"
        Me.BindingSource1.DataSource = Me.KarateJoinDateDataSet
        '
        'MembersTableAdapter1
        '
        Me.MembersTableAdapter1.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date_Joined"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date_Joined"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'KarateMemberDates
        '
        Me.ClientSize = New System.Drawing.Size(612, 401)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.rdBtnAfterDate)
        Me.Controls.Add(Me.rdBtnBeforeDate)
        Me.Controls.Add(Me.lblMembersJoined)
        Me.Controls.Add(Me.dtpMemberDate)
        Me.Controls.Add(Me.lblSelectADate)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "KarateMemberDates"
        Me.Text = "Karate Member Dates"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateJoinDateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMembers As Label
    Friend WithEvents dtpKarate As DateTimePicker
    Friend WithEvents dgvMemberDates As DataGridView
    Friend WithEvents lblSelectDate As Label
    Friend WithEvents RadioButtonBeforeDate As RadioButton
    Friend WithEvents RadioButtonAfterDate As RadioButton
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As DateMemberJoinDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSelectADate As Label
    Friend WithEvents dtpMemberDate As DateTimePicker
    Friend WithEvents lblMembersJoined As Label
    Friend WithEvents rdBtnBeforeDate As RadioButton
    Friend WithEvents rdBtnAfterDate As RadioButton
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KarateJoinDateDataSet As KarateJoinDateDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MembersTableAdapter1 As KarateJoinDateDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
