<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class outClients
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblHello = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClientsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimtimDataSet1 = New EKOW_YAMOAH_10678514.TimtimDataSet1()
        Me.TimtimDataSet = New EKOW_YAMOAH_10678514.TimtimDataSet()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientsTableAdapter = New EKOW_YAMOAH_10678514.TimtimDataSetTableAdapters.clientsTableAdapter()
        Me.ClientsTableAdapter1 = New EKOW_YAMOAH_10678514.TimtimDataSet1TableAdapters.clientsTableAdapter()
        Me.PanelList = New System.Windows.Forms.Panel()
        Me.ClientsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimtimDataSetM = New EKOW_YAMOAH_10678514.TimtimDataSetM()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnViewList = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientsTableAdapter2 = New EKOW_YAMOAH_10678514.TimtimDataSetMTableAdapters.clientsTableAdapter()
        Me.BtneX = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ClientsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimtimDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimtimDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimtimDataSetM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.LblHello)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 43)
        Me.Panel1.TabIndex = 17
        '
        'LblHello
        '
        Me.LblHello.AutoSize = True
        Me.LblHello.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblHello.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHello.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblHello.Location = New System.Drawing.Point(65, 8)
        Me.LblHello.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LblHello.Name = "LblHello"
        Me.LblHello.Size = New System.Drawing.Size(157, 25)
        Me.LblHello.TabIndex = 1
        Me.LblHello.Text = "Out Clients List"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1023, 73)
        Me.Panel2.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Timtim Travel and Tour CO. Ltd. "
        '
        'ClientsBindingSource1
        '
        Me.ClientsBindingSource1.DataMember = "clients"
        Me.ClientsBindingSource1.DataSource = Me.TimtimDataSet1
        '
        'TimtimDataSet1
        '
        Me.TimtimDataSet1.DataSetName = "TimtimDataSet1"
        Me.TimtimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimtimDataSet
        '
        Me.TimtimDataSet.DataSetName = "TimtimDataSet"
        Me.TimtimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "clients"
        Me.ClientsBindingSource.DataSource = Me.TimtimDataSet
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'ClientsTableAdapter1
        '
        Me.ClientsTableAdapter1.ClearBeforeFill = True
        '
        'PanelList
        '
        Me.PanelList.BackColor = System.Drawing.Color.Moccasin
        Me.PanelList.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelList.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelList.Location = New System.Drawing.Point(279, 116)
        Me.PanelList.Name = "PanelList"
        Me.PanelList.Size = New System.Drawing.Size(744, 357)
        Me.PanelList.TabIndex = 18
        '
        'ClientsBindingSource2
        '
        Me.ClientsBindingSource2.DataMember = "clients"
        Me.ClientsBindingSource2.DataSource = Me.TimtimDataSetM
        '
        'TimtimDataSetM
        '
        Me.TimtimDataSetM.DataSetName = "TimtimDataSetM"
        Me.TimtimDataSetM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gold
        Me.Panel3.Controls.Add(Me.BtneX)
        Me.Panel3.Controls.Add(Me.BtnViewList)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(282, 357)
        Me.Panel3.TabIndex = 19
        '
        'BtnViewList
        '
        Me.BtnViewList.BackColor = System.Drawing.Color.Red
        Me.BtnViewList.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewList.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnViewList.Location = New System.Drawing.Point(4, 148)
        Me.BtnViewList.Name = "BtnViewList"
        Me.BtnViewList.Size = New System.Drawing.Size(269, 59)
        Me.BtnViewList.TabIndex = 5
        Me.BtnViewList.Text = "View List"
        Me.BtnViewList.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(282, 81)
        Me.Panel4.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EKOW_YAMOAH_10678514.My.Resources.Resources.admin
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 50)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(88, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ADMIN SECTION"
        '
        'ClientsTableAdapter2
        '
        Me.ClientsTableAdapter2.ClearBeforeFill = True
        '
        'BtneX
        '
        Me.BtneX.BackColor = System.Drawing.Color.Red
        Me.BtneX.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtneX.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtneX.Location = New System.Drawing.Point(3, 213)
        Me.BtneX.Name = "BtneX"
        Me.BtneX.Size = New System.Drawing.Size(269, 59)
        Me.BtneX.TabIndex = 6
        Me.BtneX.Text = "Exit"
        Me.BtneX.UseVisualStyleBackColor = False
        '
        'outClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1023, 473)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "outClients"
        Me.Text = "outClients"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ClientsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimtimDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimtimDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimtimDataSetM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblHello As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TimtimDataSet As TimtimDataSet
    Friend WithEvents ClientsBindingSource As BindingSource
    Friend WithEvents ClientsTableAdapter As TimtimDataSetTableAdapters.clientsTableAdapter
    Friend WithEvents TimtimDataSet1 As TimtimDataSet1
    Friend WithEvents ClientsBindingSource1 As BindingSource
    Friend WithEvents ClientsTableAdapter1 As TimtimDataSet1TableAdapters.clientsTableAdapter
    Friend WithEvents PanelList As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnViewList As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TimtimDataSetM As TimtimDataSetM
    Friend WithEvents ClientsBindingSource2 As BindingSource
    Friend WithEvents ClientsTableAdapter2 As TimtimDataSetMTableAdapters.clientsTableAdapter
    Friend WithEvents BtneX As Button
End Class
