<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_FemaleGloss
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
        Me.Bar_Female = New System.Windows.Forms.TrackBar()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_Female = New System.Windows.Forms.Label()
        Me.Check_Fem = New System.Windows.Forms.CheckBox()
        Me.Btn_Next = New System.Windows.Forms.Button()
        Me.lbl_ExpFemGloss = New System.Windows.Forms.Label()
        Me.Lbl_BarProgress = New System.Windows.Forms.Label()
        Me.Tmr_BarProgress = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_preset = New System.Windows.Forms.Label()
        Me.Rad_Preset1 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset2 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset3 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset4 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset5 = New System.Windows.Forms.RadioButton()
        Me.Pic_Preset = New System.Windows.Forms.PictureBox()
        CType(Me.Bar_Female, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Preset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar_Female
        '
        Me.Bar_Female.Location = New System.Drawing.Point(12, 153)
        Me.Bar_Female.Maximum = 100
        Me.Bar_Female.Name = "Bar_Female"
        Me.Bar_Female.Size = New System.Drawing.Size(468, 45)
        Me.Bar_Female.TabIndex = 1
        Me.Bar_Female.Value = 15
        Me.Bar_Female.Visible = False
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(157, 9)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(179, 37)
        Me.Lbl_Title.TabIndex = 3
        Me.Lbl_Title.Text = "GlossTech"
        '
        'lbl_Female
        '
        Me.lbl_Female.AutoSize = True
        Me.lbl_Female.Location = New System.Drawing.Point(13, 57)
        Me.lbl_Female.Name = "lbl_Female"
        Me.lbl_Female.Size = New System.Drawing.Size(228, 13)
        Me.lbl_Female.TabIndex = 4
        Me.lbl_Female.Text = "Chose the level of gloss for female (if you want)"
        '
        'Check_Fem
        '
        Me.Check_Fem.AutoSize = True
        Me.Check_Fem.Location = New System.Drawing.Point(16, 73)
        Me.Check_Fem.Name = "Check_Fem"
        Me.Check_Fem.Size = New System.Drawing.Size(89, 17)
        Me.Check_Fem.TabIndex = 5
        Me.Check_Fem.Text = "Female Gloss"
        Me.Check_Fem.UseVisualStyleBackColor = True
        '
        'Btn_Next
        '
        Me.Btn_Next.Location = New System.Drawing.Point(345, 430)
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(134, 27)
        Me.Btn_Next.TabIndex = 6
        Me.Btn_Next.Text = "Next"
        Me.Btn_Next.UseVisualStyleBackColor = True
        '
        'lbl_ExpFemGloss
        '
        Me.lbl_ExpFemGloss.AutoSize = True
        Me.lbl_ExpFemGloss.Location = New System.Drawing.Point(111, 73)
        Me.lbl_ExpFemGloss.Name = "lbl_ExpFemGloss"
        Me.lbl_ExpFemGloss.Size = New System.Drawing.Size(313, 26)
        Me.lbl_ExpFemGloss.TabIndex = 7
        Me.lbl_ExpFemGloss.Text = "Chose if apply the gloss on the female (if you don't want the gloss" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "check the bo" & _
            "x and set no gloss, it could improve perfomance)"
        '
        'Lbl_BarProgress
        '
        Me.Lbl_BarProgress.AutoSize = True
        Me.Lbl_BarProgress.Location = New System.Drawing.Point(227, 140)
        Me.Lbl_BarProgress.Name = "Lbl_BarProgress"
        Me.Lbl_BarProgress.Size = New System.Drawing.Size(19, 13)
        Me.Lbl_BarProgress.TabIndex = 8
        Me.Lbl_BarProgress.Text = "15"
        Me.Lbl_BarProgress.Visible = False
        '
        'Tmr_BarProgress
        '
        Me.Tmr_BarProgress.Interval = 50
        '
        'lbl_preset
        '
        Me.lbl_preset.AutoSize = True
        Me.lbl_preset.Location = New System.Drawing.Point(9, 119)
        Me.lbl_preset.Name = "lbl_preset"
        Me.lbl_preset.Size = New System.Drawing.Size(37, 13)
        Me.lbl_preset.TabIndex = 9
        Me.lbl_preset.Text = "Preset"
        Me.lbl_preset.Visible = False
        '
        'Rad_Preset1
        '
        Me.Rad_Preset1.AutoSize = True
        Me.Rad_Preset1.Location = New System.Drawing.Point(56, 117)
        Me.Rad_Preset1.Name = "Rad_Preset1"
        Me.Rad_Preset1.Size = New System.Drawing.Size(68, 17)
        Me.Rad_Preset1.TabIndex = 10
        Me.Rad_Preset1.TabStop = True
        Me.Rad_Preset1.Text = "No Gloss"
        Me.Rad_Preset1.UseVisualStyleBackColor = True
        Me.Rad_Preset1.Visible = False
        '
        'Rad_Preset2
        '
        Me.Rad_Preset2.AutoSize = True
        Me.Rad_Preset2.Location = New System.Drawing.Point(130, 117)
        Me.Rad_Preset2.Name = "Rad_Preset2"
        Me.Rad_Preset2.Size = New System.Drawing.Size(74, 17)
        Me.Rad_Preset2.TabIndex = 11
        Me.Rad_Preset2.TabStop = True
        Me.Rad_Preset2.Text = "Low Gloss"
        Me.Rad_Preset2.UseVisualStyleBackColor = True
        Me.Rad_Preset2.Visible = False
        '
        'Rad_Preset3
        '
        Me.Rad_Preset3.AutoSize = True
        Me.Rad_Preset3.Location = New System.Drawing.Point(210, 117)
        Me.Rad_Preset3.Name = "Rad_Preset3"
        Me.Rad_Preset3.Size = New System.Drawing.Size(71, 17)
        Me.Rad_Preset3.TabIndex = 12
        Me.Rad_Preset3.TabStop = True
        Me.Rad_Preset3.Text = "Mid Gloss"
        Me.Rad_Preset3.UseVisualStyleBackColor = True
        Me.Rad_Preset3.Visible = False
        '
        'Rad_Preset4
        '
        Me.Rad_Preset4.AutoSize = True
        Me.Rad_Preset4.Location = New System.Drawing.Point(287, 117)
        Me.Rad_Preset4.Name = "Rad_Preset4"
        Me.Rad_Preset4.Size = New System.Drawing.Size(76, 17)
        Me.Rad_Preset4.TabIndex = 13
        Me.Rad_Preset4.TabStop = True
        Me.Rad_Preset4.Text = "High Gloss"
        Me.Rad_Preset4.UseVisualStyleBackColor = True
        Me.Rad_Preset4.Visible = False
        '
        'Rad_Preset5
        '
        Me.Rad_Preset5.AutoSize = True
        Me.Rad_Preset5.Location = New System.Drawing.Point(369, 117)
        Me.Rad_Preset5.Name = "Rad_Preset5"
        Me.Rad_Preset5.Size = New System.Drawing.Size(76, 17)
        Me.Rad_Preset5.TabIndex = 14
        Me.Rad_Preset5.TabStop = True
        Me.Rad_Preset5.Text = "Ultra Gloss"
        Me.Rad_Preset5.UseVisualStyleBackColor = True
        Me.Rad_Preset5.Visible = False
        '
        'Pic_Preset
        '
        Me.Pic_Preset.Location = New System.Drawing.Point(0, 194)
        Me.Pic_Preset.Name = "Pic_Preset"
        Me.Pic_Preset.Size = New System.Drawing.Size(222, 301)
        Me.Pic_Preset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Preset.TabIndex = 15
        Me.Pic_Preset.TabStop = False
        Me.Pic_Preset.Visible = False
        '
        'Form_FemaleGloss
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
        Me.Controls.Add(Me.lbl_ExpFemGloss)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.Check_Fem)
        Me.Controls.Add(Me.lbl_Female)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.Bar_Female)
        Me.MaximizeBox = False
        Me.Name = "Form_FemaleGloss"
        Me.Text = "Gloss for female"
        CType(Me.Bar_Female, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Preset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar_Female As System.Windows.Forms.TrackBar
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_Female As System.Windows.Forms.Label
    Friend WithEvents Check_Fem As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_ExpFemGloss As System.Windows.Forms.Label
    Friend WithEvents Lbl_BarProgress As System.Windows.Forms.Label
    Friend WithEvents Tmr_BarProgress As System.Windows.Forms.Timer
    Friend WithEvents Btn_Next As System.Windows.Forms.Button
    Friend WithEvents lbl_preset As System.Windows.Forms.Label
    Friend WithEvents Rad_Preset1 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset4 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset5 As System.Windows.Forms.RadioButton
    Friend WithEvents Pic_Preset As System.Windows.Forms.PictureBox
End Class
