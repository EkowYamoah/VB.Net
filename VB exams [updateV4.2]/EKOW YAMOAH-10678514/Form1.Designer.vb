<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DestinCmbBox = New System.Windows.Forms.ComboBox()
        Me.LblMapDist = New System.Windows.Forms.Label()
        Me.txtMapDist = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GrpBoxSelected = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.LblWalk = New System.Windows.Forms.Label()
        Me.LblTaxi = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTrans = New System.Windows.Forms.Label()
        Me.TxtMapkm = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnProceed = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.WalkPic = New System.Windows.Forms.PictureBox()
        Me.TaxiPic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxSelected.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WalkPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxiPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 22
        Me.ListBox1.Location = New System.Drawing.Point(6, 99)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(272, 158)
        Me.ListBox1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DestinCmbBox)
        Me.GroupBox1.Controls.Add(Me.LblMapDist)
        Me.GroupBox1.Controls.Add(Me.txtMapDist)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 261)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Destinations"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(265, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 36)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "cm"
        '
        'DestinCmbBox
        '
        Me.DestinCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DestinCmbBox.FormattingEnabled = True
        Me.DestinCmbBox.Items.AddRange(New Object() {"National Museum", "Accra Mall", "University of Ghana", "National Theatre"})
        Me.DestinCmbBox.Location = New System.Drawing.Point(5, 51)
        Me.DestinCmbBox.Name = "DestinCmbBox"
        Me.DestinCmbBox.Size = New System.Drawing.Size(232, 30)
        Me.DestinCmbBox.TabIndex = 5
        '
        'LblMapDist
        '
        Me.LblMapDist.AutoSize = True
        Me.LblMapDist.Location = New System.Drawing.Point(6, 193)
        Me.LblMapDist.Name = "LblMapDist"
        Me.LblMapDist.Size = New System.Drawing.Size(138, 22)
        Me.LblMapDist.TabIndex = 4
        Me.LblMapDist.Text = "Map Distance"
        '
        'txtMapDist
        '
        Me.txtMapDist.AcceptsTab = True
        Me.txtMapDist.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtMapDist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMapDist.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMapDist.ForeColor = System.Drawing.SystemColors.Info
        Me.txtMapDist.Location = New System.Drawing.Point(160, 191)
        Me.txtMapDist.Name = "txtMapDist"
        Me.txtMapDist.Size = New System.Drawing.Size(100, 36)
        Me.txtMapDist.TabIndex = 3
        '
        'BtnAdd
        '
        Me.BtnAdd.ActiveBorderThickness = 1
        Me.BtnAdd.ActiveCornerRadius = 20
        Me.BtnAdd.ActiveFillColor = System.Drawing.Color.DeepPink
        Me.BtnAdd.ActiveForecolor = System.Drawing.Color.White
        Me.BtnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnAdd.BackgroundImage = CType(resources.GetObject("BtnAdd.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdd.ButtonText = "Add"
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.IdleBorderThickness = 1
        Me.BtnAdd.IdleCornerRadius = 20
        Me.BtnAdd.IdleFillColor = System.Drawing.Color.Tomato
        Me.BtnAdd.IdleForecolor = System.Drawing.Color.Honeydew
        Me.BtnAdd.IdleLineColor = System.Drawing.Color.Honeydew
        Me.BtnAdd.Location = New System.Drawing.Point(5, 99)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(128, 41)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpBoxSelected
        '
        Me.GrpBoxSelected.BackColor = System.Drawing.SystemColors.Highlight
        Me.GrpBoxSelected.Controls.Add(Me.Label4)
        Me.GrpBoxSelected.Controls.Add(Me.Label3)
        Me.GrpBoxSelected.Controls.Add(Me.ListBox2)
        Me.GrpBoxSelected.Controls.Add(Me.ListBox1)
        Me.GrpBoxSelected.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxSelected.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrpBoxSelected.Location = New System.Drawing.Point(412, 17)
        Me.GrpBoxSelected.Name = "GrpBoxSelected"
        Me.GrpBoxSelected.Size = New System.Drawing.Size(415, 270)
        Me.GrpBoxSelected.TabIndex = 5
        Me.GrpBoxSelected.TabStop = False
        Me.GrpBoxSelected.Text = "Selected Destinations"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Distance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Destination"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 22
        Me.ListBox2.Location = New System.Drawing.Point(302, 99)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(101, 158)
        Me.ListBox2.TabIndex = 4
        '
        'LblWalk
        '
        Me.LblWalk.AutoSize = True
        Me.LblWalk.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWalk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblWalk.Location = New System.Drawing.Point(719, 452)
        Me.LblWalk.Name = "LblWalk"
        Me.LblWalk.Size = New System.Drawing.Size(45, 20)
        Me.LblWalk.TabIndex = 11
        Me.LblWalk.Text = "Walk"
        '
        'LblTaxi
        '
        Me.LblTaxi.AutoSize = True
        Me.LblTaxi.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTaxi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTaxi.Location = New System.Drawing.Point(719, 373)
        Me.LblTaxi.Name = "LblTaxi"
        Me.LblTaxi.Size = New System.Drawing.Size(34, 20)
        Me.LblTaxi.TabIndex = 10
        Me.LblTaxi.Text = "Taxi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(510, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Total Distance"
        '
        'LblTrans
        '
        Me.LblTrans.AutoSize = True
        Me.LblTrans.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrans.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTrans.Location = New System.Drawing.Point(429, 415)
        Me.LblTrans.Name = "LblTrans"
        Me.LblTrans.Size = New System.Drawing.Size(268, 20)
        Me.LblTrans.TabIndex = 6
        Me.LblTrans.Text = "Recommended Mode of Transport :"
        '
        'TxtMapkm
        '
        Me.TxtMapkm.AcceptsTab = True
        Me.TxtMapkm.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtMapkm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMapkm.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMapkm.ForeColor = System.Drawing.SystemColors.Info
        Me.TxtMapkm.Location = New System.Drawing.Point(463, 339)
        Me.TxtMapkm.Name = "TxtMapkm"
        Me.TxtMapkm.Size = New System.Drawing.Size(100, 36)
        Me.TxtMapkm.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.EKOW_YAMOAH_10678514.My.Resources.Resources.img_87110
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(569, 334)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 41)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.EKOW_YAMOAH_10678514.My.Resources.Resources.arrrigh
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(333, 434)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 73)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'BtnProceed
        '
        Me.BtnProceed.ActiveBorderThickness = 1
        Me.BtnProceed.ActiveCornerRadius = 20
        Me.BtnProceed.ActiveFillColor = System.Drawing.Color.DeepPink
        Me.BtnProceed.ActiveForecolor = System.Drawing.Color.White
        Me.BtnProceed.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BtnProceed.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnProceed.BackgroundImage = CType(resources.GetObject("BtnProceed.BackgroundImage"), System.Drawing.Image)
        Me.BtnProceed.ButtonText = "Proceed"
        Me.BtnProceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProceed.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProceed.ForeColor = System.Drawing.Color.White
        Me.BtnProceed.IdleBorderThickness = 1
        Me.BtnProceed.IdleCornerRadius = 20
        Me.BtnProceed.IdleFillColor = System.Drawing.Color.Tomato
        Me.BtnProceed.IdleForecolor = System.Drawing.Color.Black
        Me.BtnProceed.IdleLineColor = System.Drawing.Color.Honeydew
        Me.BtnProceed.Location = New System.Drawing.Point(32, 434)
        Me.BtnProceed.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnProceed.Name = "BtnProceed"
        Me.BtnProceed.Size = New System.Drawing.Size(309, 73)
        Me.BtnProceed.TabIndex = 6
        Me.BtnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WalkPic
        '
        Me.WalkPic.BackgroundImage = Global.EKOW_YAMOAH_10678514.My.Resources.Resources.walk
        Me.WalkPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.WalkPic.Location = New System.Drawing.Point(723, 398)
        Me.WalkPic.Name = "WalkPic"
        Me.WalkPic.Size = New System.Drawing.Size(42, 51)
        Me.WalkPic.TabIndex = 8
        Me.WalkPic.TabStop = False
        '
        'TaxiPic
        '
        Me.TaxiPic.BackgroundImage = Global.EKOW_YAMOAH_10678514.My.Resources.Resources.car
        Me.TaxiPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TaxiPic.Location = New System.Drawing.Point(710, 398)
        Me.TaxiPic.Name = "TaxiPic"
        Me.TaxiPic.Size = New System.Drawing.Size(76, 51)
        Me.TaxiPic.TabIndex = 7
        Me.TaxiPic.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(459, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Scale : 1 cm : 0.25 km"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(841, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnProceed)
        Me.Controls.Add(Me.TxtMapkm)
        Me.Controls.Add(Me.LblWalk)
        Me.Controls.Add(Me.GrpBoxSelected)
        Me.Controls.Add(Me.LblTaxi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WalkPic)
        Me.Controls.Add(Me.TaxiPic)
        Me.Controls.Add(Me.LblTrans)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "MAPS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpBoxSelected.ResumeLayout(False)
        Me.GrpBoxSelected.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WalkPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxiPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnAdd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GrpBoxSelected As GroupBox
    Friend WithEvents TaxiPic As PictureBox
    Friend WithEvents WalkPic As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblWalk As Label
    Friend WithEvents LblTaxi As Label
    Friend WithEvents LblTrans As Label
    Friend WithEvents txtMapDist As TextBox
    Friend WithEvents TxtMapkm As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents DestinCmbBox As ComboBox
    Friend WithEvents LblMapDist As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnProceed As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
End Class
