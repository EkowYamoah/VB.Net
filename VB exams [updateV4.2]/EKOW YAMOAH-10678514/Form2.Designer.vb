<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormList
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COUNTRYOFRESIDENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NATIONALITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDISTANCEKMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimtimDataSetMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimtimDataSetM = New EKOW_YAMOAH_10678514.TimtimDataSetM()
        Me.ClientsTableAdapter = New EKOW_YAMOAH_10678514.TimtimDataSetMTableAdapters.clientsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimtimDataSetMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimtimDataSetM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.COUNTRYOFRESIDENCEDataGridViewTextBoxColumn, Me.NATIONALITYDataGridViewTextBoxColumn, Me.TOTALDISTANCEKMDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(746, 462)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'COUNTRYOFRESIDENCEDataGridViewTextBoxColumn
        '
        Me.COUNTRYOFRESIDENCEDataGridViewTextBoxColumn.DataPropertyName = "COUNTRY OF RESIDENCE"
        Me.COUNTRYOFRESIDENCEDataGridViewTextBoxColumn.HeaderText = "COUNTRY OF RESIDENCE"
        Me.COUNTRYOFRESIDENCEDataGridViewTextBoxColumn.Name = "COUNTRYOFRESIDENCEDataGridViewTextBoxColumn"
        '
        'NATIONALITYDataGridViewTextBoxColumn
        '
        Me.NATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "NATIONALITY"
        Me.NATIONALITYDataGridViewTextBoxColumn.HeaderText = "NATIONALITY"
        Me.NATIONALITYDataGridViewTextBoxColumn.Name = "NATIONALITYDataGridViewTextBoxColumn"
        '
        'TOTALDISTANCEKMDataGridViewTextBoxColumn
        '
        Me.TOTALDISTANCEKMDataGridViewTextBoxColumn.DataPropertyName = "TOTAL DISTANCE (KM)"
        Me.TOTALDISTANCEKMDataGridViewTextBoxColumn.HeaderText = "TOTAL DISTANCE (KM)"
        Me.TOTALDISTANCEKMDataGridViewTextBoxColumn.Name = "TOTALDISTANCEKMDataGridViewTextBoxColumn"
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "clients"
        Me.ClientsBindingSource.DataSource = Me.TimtimDataSetMBindingSource
        '
        'TimtimDataSetMBindingSource
        '
        Me.TimtimDataSetMBindingSource.DataSource = Me.TimtimDataSetM
        Me.TimtimDataSetMBindingSource.Position = 0
        '
        'TimtimDataSetM
        '
        Me.TimtimDataSetM.DataSetName = "TimtimDataSetM"
        Me.TimtimDataSetM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'FormList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 474)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormList"
        Me.Text = "Out List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimtimDataSetMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimtimDataSetM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TimtimDataSetMBindingSource As BindingSource
    Friend WithEvents TimtimDataSetM As TimtimDataSetM
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As TimtimDataSetMTableAdapters.clientsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COUNTRYOFRESIDENCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NATIONALITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDISTANCEKMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
