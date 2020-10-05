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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TiedostoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VäritToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PunainenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VihreäToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SininenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeltainenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MustaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValkoinenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TallennaKuvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MeneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeneOhjelmasivulleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeneKuvasivulleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(957, 458)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 496)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(433, 123)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(425, 97)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kirjoita"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiedostoToolStripMenuItem, Me.VäritToolStripMenuItem, Me.MeneToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TiedostoToolStripMenuItem
        '
        Me.TiedostoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TallennaKuvaToolStripMenuItem})
        Me.TiedostoToolStripMenuItem.Name = "TiedostoToolStripMenuItem"
        Me.TiedostoToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.TiedostoToolStripMenuItem.Text = "Tiedosto"
        '
        'VäritToolStripMenuItem
        '
        Me.VäritToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PunainenToolStripMenuItem, Me.VihreäToolStripMenuItem, Me.SininenToolStripMenuItem, Me.KeltainenToolStripMenuItem, Me.MustaToolStripMenuItem, Me.ValkoinenToolStripMenuItem})
        Me.VäritToolStripMenuItem.Name = "VäritToolStripMenuItem"
        Me.VäritToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.VäritToolStripMenuItem.Text = "Värit"
        '
        'PunainenToolStripMenuItem
        '
        Me.PunainenToolStripMenuItem.Name = "PunainenToolStripMenuItem"
        Me.PunainenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PunainenToolStripMenuItem.Text = "Punainen"
        '
        'VihreäToolStripMenuItem
        '
        Me.VihreäToolStripMenuItem.Name = "VihreäToolStripMenuItem"
        Me.VihreäToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VihreäToolStripMenuItem.Text = "Vihreä"
        '
        'SininenToolStripMenuItem
        '
        Me.SininenToolStripMenuItem.Name = "SininenToolStripMenuItem"
        Me.SininenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SininenToolStripMenuItem.Text = "Sininen"
        '
        'KeltainenToolStripMenuItem
        '
        Me.KeltainenToolStripMenuItem.Name = "KeltainenToolStripMenuItem"
        Me.KeltainenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KeltainenToolStripMenuItem.Text = "Keltainen"
        '
        'MustaToolStripMenuItem
        '
        Me.MustaToolStripMenuItem.Name = "MustaToolStripMenuItem"
        Me.MustaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MustaToolStripMenuItem.Text = "Musta"
        '
        'ValkoinenToolStripMenuItem
        '
        Me.ValkoinenToolStripMenuItem.Name = "ValkoinenToolStripMenuItem"
        Me.ValkoinenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ValkoinenToolStripMenuItem.Text = "Valkoinen"
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.Location = New System.Drawing.Point(804, 529)
        Me.TrackBar1.Maximum = 45
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(168, 45)
        Me.TrackBar1.TabIndex = 3
        Me.TrackBar1.Value = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(813, 506)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Piirtäminen"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(953, 507)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "5"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(813, 566)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Tyhjennä"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(165, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Pieni Kuva"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(165, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Iso Kuva"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TallennaKuvaToolStripMenuItem
        '
        Me.TallennaKuvaToolStripMenuItem.Name = "TallennaKuvaToolStripMenuItem"
        Me.TallennaKuvaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TallennaKuvaToolStripMenuItem.Text = "Tallenna Kuva"
        '
        'MeneToolStripMenuItem
        '
        Me.MeneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MeneOhjelmasivulleToolStripMenuItem, Me.MeneKuvasivulleToolStripMenuItem})
        Me.MeneToolStripMenuItem.Name = "MeneToolStripMenuItem"
        Me.MeneToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.MeneToolStripMenuItem.Text = "Mene"
        '
        'MeneOhjelmasivulleToolStripMenuItem
        '
        Me.MeneOhjelmasivulleToolStripMenuItem.Name = "MeneOhjelmasivulleToolStripMenuItem"
        Me.MeneOhjelmasivulleToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.MeneOhjelmasivulleToolStripMenuItem.Text = "Mene ohjelmasivulle"
        '
        'MeneKuvasivulleToolStripMenuItem
        '
        Me.MeneKuvasivulleToolStripMenuItem.Name = "MeneKuvasivulleToolStripMenuItem"
        Me.MeneKuvasivulleToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.MeneKuvasivulleToolStripMenuItem.Text = "Mene kuvasivulle"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(246, 50)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(160, 23)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Mene kuvasivulle"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(246, 21)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(160, 23)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Mene ohjelmasivulle"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 640)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Elisa TV-Kuva Selain"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TiedostoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VäritToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PunainenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VihreäToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SininenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeltainenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MustaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValkoinenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TallennaKuvaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MeneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MeneOhjelmasivulleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MeneKuvasivulleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
