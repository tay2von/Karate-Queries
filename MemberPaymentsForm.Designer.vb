<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberPaymentsForm
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
        Me.lbMembers = New System.Windows.Forms.ListBox()
        Me.KaratePaymentsDataSet = New KarateQueries.KaratePaymentsDataSet()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTableAdapter = New KarateQueries.KaratePaymentsDataSetTableAdapters.PaymentsTableAdapter()
        Me.AllMembersDataSet = New KarateQueries.AllMembersDataSet()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New KarateQueries.AllMembersDataSetTableAdapters.MembersTableAdapter()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KaratePaymentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbMembers
        '
        Me.lbMembers.DataSource = Me.MembersBindingSource
        Me.lbMembers.DisplayMember = "First_Name"
        Me.lbMembers.FormattingEnabled = True
        Me.lbMembers.Location = New System.Drawing.Point(51, 58)
        Me.lbMembers.Name = "lbMembers"
        Me.lbMembers.Size = New System.Drawing.Size(215, 264)
        Me.lbMembers.TabIndex = 0
        Me.lbMembers.ValueMember = "ID"
        '
        'KaratePaymentsDataSet
        '
        Me.KaratePaymentsDataSet.DataSetName = "KaratePaymentsDataSet"
        Me.KaratePaymentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.KaratePaymentsDataSet
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'AllMembersDataSet
        '
        Me.AllMembersDataSet.DataSetName = "AllMembersDataSet"
        Me.AllMembersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.AllMembersDataSet
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'dgvPayments
        '
        Me.dgvPayments.AllowUserToAddRows = False
        Me.dgvPayments.AllowUserToDeleteRows = False
        Me.dgvPayments.AutoGenerateColumns = False
        Me.dgvPayments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.dgvPayments.DataSource = Me.PaymentsBindingSource
        Me.dgvPayments.GridColor = System.Drawing.SystemColors.Control
        Me.dgvPayments.Location = New System.Drawing.Point(376, 58)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.Size = New System.Drawing.Size(320, 264)
        Me.dgvPayments.TabIndex = 1
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        Me.PaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberPaymentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvPayments)
        Me.Controls.Add(Me.lbMembers)
        Me.Name = "MemberPaymentsForm"
        Me.Text = "Payments by One Member"
        CType(Me.KaratePaymentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbMembers As ListBox
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents KaratePaymentsDataSet As KaratePaymentsDataSet
    Friend WithEvents PaymentsTableAdapter As KaratePaymentsDataSetTableAdapters.PaymentsTableAdapter
    Friend WithEvents AllMembersDataSet As AllMembersDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As AllMembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
