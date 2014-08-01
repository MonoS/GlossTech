<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ManGloss
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
        Me.Pic_Preset = New System.Windows.Forms.PictureBox()
        Me.Rad_Preset5 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset4 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset3 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset2 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset1 = New System.Windows.Forms.RadioButton()
        Me.lbl_preset = New System.Windows.Forms.Label()
        Me.Lbl_BarProgress = New System.Windows.Forms.Label()
        Me.lbl_ExpManGloss = New System.Windows.Forms.Label()
        Me.Btn_Next = New System.Windows.Forms.Button()
        Me.Check_Man = New System.Windows.Forms.CheckBox()
        Me.lbl_Man = New System.Windows.Forms.Label()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Bar_Man = New System.Windows.Forms.TrackBar()
        Me.Tmr_BarProgress = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Pic_Preset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar_Man, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic_Preset
        '
        Me.Pic_Preset.Location = New System.Drawing.Point(-1, 192)
        Me.Pic_Preset.Name = "Pic_Preset"
        Me.Pic_Preset.Size = New System.Drawing.Size(222, 301)
        Me.Pic_Preset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Preset.TabIndex = 29
        Me.Pic_Preset.TabStop = False
        Me.Pic_Preset.Visible = False
        '
        'Rad_Preset5
        '
        Me.Rad_Preset5.AutoSize = True
        Me.Rad_Preset5.Location = New System.Drawing.Point(368, 115)
        Me.Rad_Preset5.Name = "Rad_Preset5"
        Me.Rad_Preset5.Size = New System.Drawing.Size(76, 17)
        Me.Rad_Preset5.TabIndex = 28
        Me.Rad_Preset5.TabStop = True
        Me.Rad_Preset5.Text = "Ultra Gloss"
        Me.Rad_Preset5.UseVisualStyleBackColor = True
        Me.Rad_Preset5.Visible = False
        '
        'Rad_Preset4
        '
        Me.Rad_Preset4.AutoSize = True
        Me.Rad_Preset4.Location = New System.Drawing.Point(286, 115)
        Me.Rad_Preset4.Name = "Rad_Preset4"
        Me.Rad_Preset4.Size = New System.Drawing.Size(76, 17)
        Me.Rad_Preset4.TabIndex = 27
        Me.Rad_Preset4.TabStop = True
        Me.Rad_Preset4.Text = "High Gloss"
        Me.Rad_Preset4.UseVisualStyleBackColor = True
        Me.Rad_Preset4.Visible = False
        '
        'Rad_Preset3
        '
        Me.Rad_Preset3.AutoSize = True
        Me.Rad_Preset3.Location = New System.Drawing.Point(209, 115)
        Me.Rad_Preset3.Name = "Rad_Preset3"
        Me.Rad_Preset3.Size = New System.Drawing.Size(71, 17)
        Me.Rad_Preset3.TabIndex = 26
        Me.Rad_Preset3.TabStop = True
        Me.Rad_Preset3.Text = "Mid Gloss"
        Me.Rad_Preset3.UseVisualStyleBackColor = True
        Me.Rad_Preset3.Visible = False
        '
        'Rad_Preset2
        '
        Me.Rad_Preset2.AutoSize = True
        Me.Rad_Preset2.Location = New System.Drawing.Point(129, 115)
        Me.Rad_Preset2.Name = "Rad_Preset2"
        Me.Rad_Preset2.Size = New System.Drawing.Size(74, 17)
        Me.Rad_Preset2.TabIndex = 25
        Me.Rad_Preset2.TabStop = True
        Me.Rad_Preset2.Text = "Low Gloss"
        Me.Rad_Preset2.UseVisualStyleBackColor = True
        Me.Rad_Preset2.Visible = False
        '
        'Rad_Preset1
        '
        Me.Rad_Preset1.AutoSize = True
        Me.Rad_Preset1.Location = New System.Drawing.Point(55, 115)
        Me.Rad_Preset1.Name = "Rad_Preset1"
        Me.Rad_Preset1.Size = New System.Drawing.Size(68, 17)
        Me.Rad_Preset1.TabIndex = 24
        Me.Rad_Preset1.TabStop = True
        Me.Rad_Preset1.Text = "No Gloss"
        Me.Rad_Preset1.UseVisualStyleBackColor = True
        Me.Rad_Preset1.Visible = False
        '
        'lbl_preset
        '
        Me.lbl_preset.AutoSize = True
        Me.lbl_preset.Location = New System.Drawing.Point(8, 117)
        Me.lbl_preset.Name = "lbl_preset"
        Me.lbl_preset.Size = New System.Drawing.Size(37, 13)
        Me.lbl_preset.TabIndex = 23
        Me.lbl_preset.Text = "Preset"
        Me.lbl_preset.Visible = False
        '
        'Lbl_BarProgress
        '
        Me.Lbl_BarProgress.AutoSize = True
        Me.Lbl_BarProgress.Location = New System.Drawing.Point(226, 138)
        Me.Lbl_BarProgress.Name = "Lbl_BarProgress"
        Me.Lbl_BarProgress.Size = New System.Drawing.Size(19, 13)
        Me.Lbl_BarProgress.TabIndex = 22
        Me.Lbl_BarProgress.Text = "15"
        Me.Lbl_BarProgress.Visible = False
        '
        'lbl_ExpManGloss
        '
        Me.lbl_ExpManGloss.AutoSize = True
        Me.lbl_ExpManGloss.Location = New System.Drawing.Point(97, 71)
        Me.lbl_ExpManGloss.Name = "lbl_ExpManGloss"
        Me.lbl_ExpManGloss.Size = New System.Drawing.Size(302, 26)
        Me.lbl_ExpManGloss.TabIndex = 21
        Me.lbl_ExpManGloss.Text = "Chose if apply the gloss on the man (if you don't want the gloss" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "check the box a" & _
            "nd set no gloss, it could improve perfomance)"
        '
        'Btn_Next
        '
        Me.Btn_Next.Location = New System.Drawing.Point(344, 428)
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(134, 27)
        Me.Btn_Next.TabIndex = 20
        Me.Btn_Next.Text = "Next"
        Me.Btn_Next.UseVisualStyleBackColor = True
        '
        'Check_Man
        '
        Me.Check_Man.AutoSize = True
        Me.Check_Man.Location = New System.Drawing.Point(15, 71)
        Me.Check_Man.Name = "Check_Man"
        Me.Check_Man.Size = New System.Drawing.Size(76, 17)
        Me.Check_Man.TabIndex = 19
        Me.Check_Man.Text = "Man Gloss"
        Me.Check_Man.UseVisualStyleBackColor = True
        '
        'lbl_Man
        '
        Me.lbl_Man.AutoSize = True
        Me.lbl_Man.Location = New System.Drawing.Point(12, 55)
        Me.lbl_Man.Name = "lbl_Man"
        Me.lbl_Man.Size = New System.Drawing.Size(217, 13)
        Me.lbl_Man.TabIndex = 18
        Me.lbl_Man.Text = "Chose the level of gloss for man (if you want)"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(156, 7)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(179, 37)
        Me.Lbl_Title.TabIndex = 17
        Me.Lbl_Title.Text = "GlossTech"
        '
        'Bar_Man
        '
        Me.Bar_Man.Location = New System.Drawing.Point(11, 151)
        Me.Bar_Man.Maximum = 100
        Me.Bar_Man.Name = "Bar_Man"
        Me.Bar_Man.Size = New System.Drawing.Size(468, 45)
        Me.Bar_Man.TabIndex = 16
        Me.Bar_Man.Value = 15
        Me.Bar_Man.Visible = False
        '
        'Tmr_BarProgress
        '
        Me.Tmr_BarProgress.Interval = 50
        '
        'Form_ManGloss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 494)
        Me.Controls.Add(Me.Pic_Preset)
        Me.Controls.Add(Me.Rad_Preset5)
        Me.Controls.Add(Me.Rad_Preset4)
        Me.Controls.Add(Me.Rad_Preset3)
        Me.Controls.Add(Me.Rad_Preset2)
        Me.Controls.Add(Me.Rad_Preset1)
        Me.Controls.Add(Me.lbl_preset)
        Me.Controls.Add(Me.Lbl_BarProgress)
        Me.Controls.Add(Me.lbl_ExpManGloss)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.Check_Man)
        Me.Controls.Add(Me.lbl_Man)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.Bar_Man)
        Me.MaximizeBox = False
        Me.Name = "Form_ManGloss"
        Me.Text = "Gloss for man"
        CType(Me.Pic_Preset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar_Man, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pic_Preset As System.Windows.Forms.PictureBox
    Friend WithEvents Rad_Preset5 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset4 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset1 As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_preset As System.Windows.Forms.Label
    Friend WithEvents Lbl_BarProgress As System.Windows.Forms.Label
    Friend WithEvents lbl_ExpManGloss As System.Windows.Forms.Label
    Friend WithEvents Btn_Next As System.Windows.Forms.Button
    Friend WithEvents Check_Man As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Man As System.Windows.Forms.Label
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Bar_Man As System.Windows.Forms.TrackBar
    Friend WithEvents Tmr_BarProgress As System.Windows.Forms.Timer
End Class
