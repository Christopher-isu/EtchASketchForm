<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketch
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
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.BackColor = System.Drawing.Color.White
        Me.DisplayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayPictureBox.Location = New System.Drawing.Point(0, 30)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(800, 420)
        Me.DisplayPictureBox.TabIndex = 0
        Me.DisplayPictureBox.TabStop = False
        '
        'ButtonPanel
        '
        Me.ButtonPanel.Controls.Add(Me.ExitButton)
        Me.ButtonPanel.Controls.Add(Me.ClearButton)
        Me.ButtonPanel.Controls.Add(Me.DrawWaveformsButton)
        Me.ButtonPanel.Controls.Add(Me.SelectColorButton)
        Me.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonPanel.Location = New System.Drawing.Point(0, 427)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(800, 23)
        Me.ButtonPanel.TabIndex = 1
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(604, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(184, 23)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(396, 0)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(202, 23)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(196, 0)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(194, 23)
        Me.DrawWaveformsButton.TabIndex = 1
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(0, 0)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(190, 23)
        Me.SelectColorButton.TabIndex = 0
        Me.SelectColorButton.Text = "&Select Color"
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuItem, Me.EditMenuItem, Me.HelpMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileMenuItem
        '
        Me.FileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitMenuItem})
        Me.FileMenuItem.Name = "FileMenuItem"
        Me.FileMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileMenuItem.Text = "&File"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitMenuItem.Text = "E&xit"
        '
        'EditMenuItem
        '
        Me.EditMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorMenuItem, Me.DrawWaveformsMenuItem, Me.ClearMenuItem})
        Me.EditMenuItem.Name = "EditMenuItem"
        Me.EditMenuItem.Size = New System.Drawing.Size(49, 26)
        Me.EditMenuItem.Text = "&Edit"
        '
        'SelectColorMenuItem
        '
        Me.SelectColorMenuItem.Name = "SelectColorMenuItem"
        Me.SelectColorMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SelectColorMenuItem.Text = "Set &Color"
        '
        'DrawWaveformsMenuItem
        '
        Me.DrawWaveformsMenuItem.Name = "DrawWaveformsMenuItem"
        Me.DrawWaveformsMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DrawWaveformsMenuItem.Text = "Draw &Waveforms"
        '
        'ClearMenuItem
        '
        Me.ClearMenuItem.Name = "ClearMenuItem"
        Me.ClearMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ClearMenuItem.Text = "&Clear"
        '
        'HelpMenuItem
        '
        Me.HelpMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMenuItem})
        Me.HelpMenuItem.Name = "HelpMenuItem"
        Me.HelpMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.HelpMenuItem.Text = "&Help"
        '
        'AboutMenuItem
        '
        Me.AboutMenuItem.Name = "AboutMenuItem"
        Me.AboutMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutMenuItem.Text = "Abo&ut"
        '
        'EtchASketch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonPanel)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EtchASketch"
        Me.Text = "Etch-A-Sketch"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonPanel.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents FileMenuItem As ToolStripMenuItem
    Friend WithEvents EditMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsMenuItem As ToolStripMenuItem
    Friend WithEvents ClearMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenuItem As ToolStripMenuItem
    Friend WithEvents AboutMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
End Class
