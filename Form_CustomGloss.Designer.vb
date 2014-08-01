<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CustomGloss
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
        Me.Dir_Custom = New System.Windows.Forms.FolderBrowserDialog()
        Me.Rad_Preset5 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset4 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset3 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset2 = New System.Windows.Forms.RadioButton()
        Me.Rad_Preset1 = New System.Windows.Forms.RadioButton()
        Me.lbl_preset = New System.Windows.Forms.Label()
        Me.Lbl_BarProgress = New System.Windows.Forms.Label()
        Me.Btn_Next = New System.Windows.Forms.Button()
        Me.lbl_Female = New System.Windows.Forms.Label()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Bar_Custom = New System.Windows.Forms.TrackBar()
        Me.Rad_CustomFem = New System.Windows.Forms.RadioButton()
        Me.Rad_CustomMan = New System.Windows.Forms.RadioButton()
        Me.Tmr_BarProgress = New System.Windows.Forms.Timer(Me.components)
        Me.Rad_CustomOther = New System.Windows.Forms.RadioButton()
        Me.File_Custom = New System.Windows.Forms.OpenFileDialog()
        Me.Group_Custom = New System.Windows.Forms.Panel()
        Me.Group_Head = New System.Windows.Forms.GroupBox()
        Me.Rad_HeadAll = New System.Windows.Forms.RadioButton()
        Me.Rad_HeadMesh = New System.Windows.Forms.RadioButton()
        Me.Group_Mesh = New System.Windows.Forms.GroupBox()
        Me.Btn_OpenCustomMesh = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Rad_UseCustomMesh = New System.Windows.Forms.RadioButton()
        Me.Rad_UseMaleMesh = New System.Windows.Forms.RadioButton()
        Me.Rad_UseFemMesh = New System.Windows.Forms.RadioButton()
        Me.Btn_OpenManMesh = New System.Windows.Forms.Button()
        Me.Lbl_ExpOpen = New System.Windows.Forms.Label()
        Me.Btn_OpenFemMesh = New System.Windows.Forms.Button()
        Me.Lbl_ExpIntensity = New System.Windows.Forms.Label()
        Me.Lbl_ExpTrasparency = New System.Windows.Forms.Label()
        Me.Rad_Mesh2 = New System.Windows.Forms.RadioButton()
        Me.Rad_Mesh1 = New System.Windows.Forms.RadioButton()
        CType(Me.Bar_Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Custom.SuspendLayout()
        Me.Group_Head.SuspendLayout()
        Me.Group_Mesh.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rad_Preset5
        '
        Me.Rad_Preset5.AutoSize = True
        Me.Rad_Preset5.Location = New System.Drawing.Point(362, 29)
        Me.Rad_Preset5.Name = "Rad_Preset5"
        Me.Rad_Preset5.Size = New System.Drawing.Size(76, 17)
        Me.Rad_Preset5.TabIndex = 28
        Me.Rad_Preset5.TabStop = True
        Me.Rad_Preset5.Text = "Ultra Gloss"
        Me.Rad_Preset5.UseVisualStyleBackColor = True
        '
        'Rad_Preset4
        '
        Me.Rad_Preset4.AutoSize = True
        Me.Rad_Preset4.Location = New System.Drawing.Point(280, 29)
        Me.Rad_Preset4.Name = "Rad_Preset4"
        Me.Rad_Preset4.Size = New System.Drawing.Size(76, 17)
        Me.Rad_Preset4.TabIndex = 27
        Me.Rad_Preset4.TabStop = True
        Me.Rad_Preset4.Text = "High Gloss"
        Me.Rad_Preset4.UseVisualStyleBackColor = True
        '
        'Rad_Preset3
        '
        Me.Rad_Preset3.AutoSize = True
        Me.Rad_Preset3.Location = New System.Drawing.Point(203, 29)
        Me.Rad_Preset3.Name = "Rad_Preset3"
        Me.Rad_Preset3.Size = New System.Drawing.Size(71, 17)
        Me.Rad_Preset3.TabIndex = 26
        Me.Rad_Preset3.TabStop = True
        Me.Rad_Preset3.Text = "Mid Gloss"
        Me.Rad_Preset3.UseVisualStyleBackColor = True
        '
        'Rad_Preset2
        '
        Me.Rad_Preset2.AutoSize = True
        Me.Rad_Preset2.Location = New System.Drawing.Point(123, 29)
        Me.Rad_Preset2.Name = "Rad_Preset2"
        Me.Rad_Preset2.Size = New System.Drawing.Size(74, 17)
        Me.Rad_Preset2.TabIndex = 25
        Me.Rad_Preset2.TabStop = True
        Me.Rad_Preset2.Text = "Low Gloss"
        Me.Rad_Preset2.UseVisualStyleBackColor = True
        '
        'Rad_Preset1
        '
        Me.Rad_Preset1.AutoSize = True
        Me.Rad_Preset1.Location = New System.Drawing.Point(49, 29)
        Me.Rad_Preset1.Name = "Rad_Preset1"
        Me.Rad_Preset1.Size = New System.Drawing.Size(68, 17)
        Me.Rad_Preset1.TabIndex = 24
        Me.Rad_Preset1.TabStop = True
        Me.Rad_Preset1.Text = "No Gloss"
        Me.Rad_Preset1.UseVisualStyleBackColor = True
        '
        'lbl_preset
        '
        Me.lbl_preset.AutoSize = True
        Me.lbl_preset.Location = New System.Drawing.Point(2, 31)
        Me.lbl_preset.Name = "lbl_preset"
        Me.lbl_preset.Size = New System.Drawing.Size(37, 13)
        Me.lbl_preset.TabIndex = 23
        Me.lbl_preset.Text = "Preset"
        '
        'Lbl_BarProgress
        '
        Me.Lbl_BarProgress.AutoSize = True
        Me.Lbl_BarProgress.Location = New System.Drawing.Point(220, 52)
        Me.Lbl_BarProgress.Name = "Lbl_BarProgress"
        Me.Lbl_BarProgress.Size = New System.Drawing.Size(19, 13)
        Me.Lbl_BarProgress.TabIndex = 22
        Me.Lbl_BarProgress.Text = "15"
        '
        'Btn_Next
        '
        Me.Btn_Next.Location = New System.Drawing.Point(179, 448)
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(134, 27)
        Me.Btn_Next.TabIndex = 20
        Me.Btn_Next.Text = "Start glossing"
        Me.Btn_Next.UseVisualStyleBackColor = True
        Me.Btn_Next.Visible = False
        '
        'lbl_Female
        '
        Me.lbl_Female.AutoSize = True
        Me.lbl_Female.Location = New System.Drawing.Point(2, 13)
        Me.lbl_Female.Name = "lbl_Female"
        Me.lbl_Female.Size = New System.Drawing.Size(218, 13)
        Me.lbl_Female.TabIndex = 18
        Me.lbl_Female.Text = "Chose the level of gloss for your custom race"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(162, 1)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(179, 37)
        Me.Lbl_Title.TabIndex = 17
        Me.Lbl_Title.Text = "GlossTech"
        '
        'Bar_Custom
        '
        Me.Bar_Custom.Location = New System.Drawing.Point(5, 65)
        Me.Bar_Custom.Maximum = 100
        Me.Bar_Custom.Name = "Bar_Custom"
        Me.Bar_Custom.Size = New System.Drawing.Size(468, 45)
        Me.Bar_Custom.TabIndex = 16
        Me.Bar_Custom.Value = 15
        '
        'Rad_CustomFem
        '
        Me.Rad_CustomFem.AutoSize = True
        Me.Rad_CustomFem.Location = New System.Drawing.Point(10, 60)
        Me.Rad_CustomFem.Name = "Rad_CustomFem"
        Me.Rad_CustomFem.Size = New System.Drawing.Size(120, 17)
        Me.Rad_CustomFem.TabIndex = 29
        Me.Rad_CustomFem.TabStop = True
        Me.Rad_CustomFem.Text = "Female custom race"
        Me.Rad_CustomFem.UseVisualStyleBackColor = True
        '
        'Rad_CustomMan
        '
        Me.Rad_CustomMan.AutoSize = True
        Me.Rad_CustomMan.Location = New System.Drawing.Point(137, 60)
        Me.Rad_CustomMan.Name = "Rad_CustomMan"
        Me.Rad_CustomMan.Size = New System.Drawing.Size(109, 17)
        Me.Rad_CustomMan.TabIndex = 30
        Me.Rad_CustomMan.TabStop = True
        Me.Rad_CustomMan.Text = "Male custom race"
        Me.Rad_CustomMan.UseVisualStyleBackColor = True
        '
        'Tmr_BarProgress
        '
        Me.Tmr_BarProgress.Enabled = True
        Me.Tmr_BarProgress.Interval = 50
        '
        'Rad_CustomOther
        '
        Me.Rad_CustomOther.AutoSize = True
        Me.Rad_CustomOther.Location = New System.Drawing.Point(253, 60)
        Me.Rad_CustomOther.Name = "Rad_CustomOther"
        Me.Rad_CustomOther.Size = New System.Drawing.Size(51, 17)
        Me.Rad_CustomOther.TabIndex = 31
        Me.Rad_CustomOther.TabStop = True
        Me.Rad_CustomOther.Text = "Other"
        Me.Rad_CustomOther.UseVisualStyleBackColor = True
        '
        'File_Custom
        '
        '
        'Group_Custom
        '
        Me.Group_Custom.Controls.Add(Me.Rad_Preset5)
        Me.Group_Custom.Controls.Add(Me.Rad_Preset4)
        Me.Group_Custom.Controls.Add(Me.Rad_Preset3)
        Me.Group_Custom.Controls.Add(Me.Rad_Preset2)
        Me.Group_Custom.Controls.Add(Me.Rad_Preset1)
        Me.Group_Custom.Controls.Add(Me.lbl_preset)
        Me.Group_Custom.Controls.Add(Me.Lbl_BarProgress)
        Me.Group_Custom.Controls.Add(Me.lbl_Female)
        Me.Group_Custom.Controls.Add(Me.Bar_Custom)
        Me.Group_Custom.Location = New System.Drawing.Point(10, 83)
        Me.Group_Custom.Name = "Group_Custom"
        Me.Group_Custom.Size = New System.Drawing.Size(483, 116)
        Me.Group_Custom.TabIndex = 33
        Me.Group_Custom.Visible = False
        '
        'Group_Head
        '
        Me.Group_Head.Controls.Add(Me.Rad_HeadAll)
        Me.Group_Head.Controls.Add(Me.Rad_HeadMesh)
        Me.Group_Head.Location = New System.Drawing.Point(10, 205)
        Me.Group_Head.Name = "Group_Head"
        Me.Group_Head.Size = New System.Drawing.Size(467, 69)
        Me.Group_Head.TabIndex = 34
        Me.Group_Head.TabStop = False
        Me.Group_Head.Text = "Head option"
        Me.Group_Head.Visible = False
        '
        'Rad_HeadAll
        '
        Me.Rad_HeadAll.AutoSize = True
        Me.Rad_HeadAll.Location = New System.Drawing.Point(7, 44)
        Me.Rad_HeadAll.Name = "Rad_HeadAll"
        Me.Rad_HeadAll.Size = New System.Drawing.Size(111, 17)
        Me.Rad_HeadAll.TabIndex = 1
        Me.Rad_HeadAll.TabStop = True
        Me.Rad_HeadAll.Text = "Cover all the head"
        Me.Rad_HeadAll.UseVisualStyleBackColor = True
        '
        'Rad_HeadMesh
        '
        Me.Rad_HeadMesh.AutoSize = True
        Me.Rad_HeadMesh.Location = New System.Drawing.Point(7, 20)
        Me.Rad_HeadMesh.Name = "Rad_HeadMesh"
        Me.Rad_HeadMesh.Size = New System.Drawing.Size(188, 17)
        Me.Rad_HeadMesh.TabIndex = 0
        Me.Rad_HeadMesh.TabStop = True
        Me.Rad_HeadMesh.Text = "Cover the head following the mesh"
        Me.Rad_HeadMesh.UseVisualStyleBackColor = True
        '
        'Group_Mesh
        '
        Me.Group_Mesh.Controls.Add(Me.Btn_OpenCustomMesh)
        Me.Group_Mesh.Controls.Add(Me.Panel1)
        Me.Group_Mesh.Controls.Add(Me.Btn_OpenManMesh)
        Me.Group_Mesh.Controls.Add(Me.Lbl_ExpOpen)
        Me.Group_Mesh.Controls.Add(Me.Btn_OpenFemMesh)
        Me.Group_Mesh.Controls.Add(Me.Lbl_ExpIntensity)
        Me.Group_Mesh.Controls.Add(Me.Lbl_ExpTrasparency)
        Me.Group_Mesh.Controls.Add(Me.Rad_Mesh2)
        Me.Group_Mesh.Controls.Add(Me.Rad_Mesh1)
        Me.Group_Mesh.Location = New System.Drawing.Point(10, 280)
        Me.Group_Mesh.Name = "Group_Mesh"
        Me.Group_Mesh.Size = New System.Drawing.Size(468, 162)
        Me.Group_Mesh.TabIndex = 35
        Me.Group_Mesh.TabStop = False
        Me.Group_Mesh.Text = "Mesh option"
        Me.Group_Mesh.Visible = False
        '
        'Btn_OpenCustomMesh
        '
        Me.Btn_OpenCustomMesh.Location = New System.Drawing.Point(272, 100)
        Me.Btn_OpenCustomMesh.Name = "Btn_OpenCustomMesh"
        Me.Btn_OpenCustomMesh.Size = New System.Drawing.Size(166, 23)
        Me.Btn_OpenCustomMesh.TabIndex = 8
        Me.Btn_OpenCustomMesh.Text = "Create or modify custom mesh"
        Me.Btn_OpenCustomMesh.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Rad_UseCustomMesh)
        Me.Panel1.Controls.Add(Me.Rad_UseMaleMesh)
        Me.Panel1.Controls.Add(Me.Rad_UseFemMesh)
        Me.Panel1.Location = New System.Drawing.Point(2, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 27)
        Me.Panel1.TabIndex = 7
        '
        'Rad_UseCustomMesh
        '
        Me.Rad_UseCustomMesh.AutoSize = True
        Me.Rad_UseCustomMesh.Location = New System.Drawing.Point(224, 4)
        Me.Rad_UseCustomMesh.Name = "Rad_UseCustomMesh"
        Me.Rad_UseCustomMesh.Size = New System.Drawing.Size(118, 17)
        Me.Rad_UseCustomMesh.TabIndex = 2
        Me.Rad_UseCustomMesh.TabStop = True
        Me.Rad_UseCustomMesh.Text = "Use a custom mesh"
        Me.Rad_UseCustomMesh.UseVisualStyleBackColor = True
        '
        'Rad_UseMaleMesh
        '
        Me.Rad_UseMaleMesh.AutoSize = True
        Me.Rad_UseMaleMesh.Location = New System.Drawing.Point(120, 4)
        Me.Rad_UseMaleMesh.Name = "Rad_UseMaleMesh"
        Me.Rad_UseMaleMesh.Size = New System.Drawing.Size(97, 17)
        Me.Rad_UseMaleMesh.TabIndex = 1
        Me.Rad_UseMaleMesh.TabStop = True
        Me.Rad_UseMaleMesh.Text = "Use male mesh"
        Me.Rad_UseMaleMesh.UseVisualStyleBackColor = True
        '
        'Rad_UseFemMesh
        '
        Me.Rad_UseFemMesh.AutoSize = True
        Me.Rad_UseFemMesh.Location = New System.Drawing.Point(7, 3)
        Me.Rad_UseFemMesh.Name = "Rad_UseFemMesh"
        Me.Rad_UseFemMesh.Size = New System.Drawing.Size(106, 17)
        Me.Rad_UseFemMesh.TabIndex = 0
        Me.Rad_UseFemMesh.TabStop = True
        Me.Rad_UseFemMesh.Text = "Use female mesh"
        Me.Rad_UseFemMesh.UseVisualStyleBackColor = True
        '
        'Btn_OpenManMesh
        '
        Me.Btn_OpenManMesh.Location = New System.Drawing.Point(148, 100)
        Me.Btn_OpenManMesh.Name = "Btn_OpenManMesh"
        Me.Btn_OpenManMesh.Size = New System.Drawing.Size(118, 23)
        Me.Btn_OpenManMesh.TabIndex = 6
        Me.Btn_OpenManMesh.Text = "Modify man mesh"
        Me.Btn_OpenManMesh.UseVisualStyleBackColor = True
        '
        'Lbl_ExpOpen
        '
        Me.Lbl_ExpOpen.AutoSize = True
        Me.Lbl_ExpOpen.Location = New System.Drawing.Point(91, 126)
        Me.Lbl_ExpOpen.Name = "Lbl_ExpOpen"
        Me.Lbl_ExpOpen.Size = New System.Drawing.Size(302, 26)
        Me.Lbl_ExpOpen.TabIndex = 5
        Me.Lbl_ExpOpen.Text = "You need a program like Paint.net for open and save the mesh" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IMPORTANT: save as " & _
            "R8G8B8 or will NOT work"
        '
        'Btn_OpenFemMesh
        '
        Me.Btn_OpenFemMesh.Location = New System.Drawing.Point(24, 100)
        Me.Btn_OpenFemMesh.Name = "Btn_OpenFemMesh"
        Me.Btn_OpenFemMesh.Size = New System.Drawing.Size(118, 23)
        Me.Btn_OpenFemMesh.TabIndex = 4
        Me.Btn_OpenFemMesh.Text = "Modify female mesh"
        Me.Btn_OpenFemMesh.UseVisualStyleBackColor = True
        '
        'Lbl_ExpIntensity
        '
        Me.Lbl_ExpIntensity.AutoSize = True
        Me.Lbl_ExpIntensity.Location = New System.Drawing.Point(97, 46)
        Me.Lbl_ExpIntensity.Name = "Lbl_ExpIntensity"
        Me.Lbl_ExpIntensity.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_ExpIntensity.TabIndex = 3
        Me.Lbl_ExpIntensity.Text = "For next version"
        '
        'Lbl_ExpTrasparency
        '
        Me.Lbl_ExpTrasparency.AutoSize = True
        Me.Lbl_ExpTrasparency.Location = New System.Drawing.Point(97, 24)
        Me.Lbl_ExpTrasparency.Name = "Lbl_ExpTrasparency"
        Me.Lbl_ExpTrasparency.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_ExpTrasparency.TabIndex = 2
        Me.Lbl_ExpTrasparency.Text = "For next version"
        '
        'Rad_Mesh2
        '
        Me.Rad_Mesh2.AutoSize = True
        Me.Rad_Mesh2.Enabled = False
        Me.Rad_Mesh2.Location = New System.Drawing.Point(7, 44)
        Me.Rad_Mesh2.Name = "Rad_Mesh2"
        Me.Rad_Mesh2.Size = New System.Drawing.Size(64, 17)
        Me.Rad_Mesh2.TabIndex = 1
        Me.Rad_Mesh2.TabStop = True
        Me.Rad_Mesh2.Text = "Intensity"
        Me.Rad_Mesh2.UseVisualStyleBackColor = True
        '
        'Rad_Mesh1
        '
        Me.Rad_Mesh1.AutoSize = True
        Me.Rad_Mesh1.Enabled = False
        Me.Rad_Mesh1.Location = New System.Drawing.Point(7, 20)
        Me.Rad_Mesh1.Name = "Rad_Mesh1"
        Me.Rad_Mesh1.Size = New System.Drawing.Size(84, 17)
        Me.Rad_Mesh1.TabIndex = 0
        Me.Rad_Mesh1.TabStop = True
        Me.Rad_Mesh1.Text = "Trasparency"
        Me.Rad_Mesh1.UseVisualStyleBackColor = True
        '
        'Form_CustomGloss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 483)
        Me.Controls.Add(Me.Group_Mesh)
        Me.Controls.Add(Me.Group_Head)
        Me.Controls.Add(Me.Group_Custom)
        Me.Controls.Add(Me.Rad_CustomOther)
        Me.Controls.Add(Me.Rad_CustomMan)
        Me.Controls.Add(Me.Rad_CustomFem)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.Lbl_Title)
        Me.MaximizeBox = False
        Me.Name = "Form_CustomGloss"
        Me.Text = "Install for custom race"
        CType(Me.Bar_Custom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Custom.ResumeLayout(False)
        Me.Group_Custom.PerformLayout()
        Me.Group_Head.ResumeLayout(False)
        Me.Group_Head.PerformLayout()
        Me.Group_Mesh.ResumeLayout(False)
        Me.Group_Mesh.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dir_Custom As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Rad_Preset5 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset4 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Preset1 As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_preset As System.Windows.Forms.Label
    Friend WithEvents Lbl_BarProgress As System.Windows.Forms.Label
    Friend WithEvents Btn_Next As System.Windows.Forms.Button
    Friend WithEvents lbl_Female As System.Windows.Forms.Label
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Bar_Custom As System.Windows.Forms.TrackBar
    Friend WithEvents Rad_CustomFem As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_CustomMan As System.Windows.Forms.RadioButton
    Friend WithEvents Tmr_BarProgress As System.Windows.Forms.Timer
    Friend WithEvents Rad_CustomOther As System.Windows.Forms.RadioButton
    Friend WithEvents File_Custom As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Group_Custom As System.Windows.Forms.Panel
    Friend WithEvents Group_Head As System.Windows.Forms.GroupBox
    Friend WithEvents Rad_HeadAll As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_HeadMesh As System.Windows.Forms.RadioButton
    Friend WithEvents Group_Mesh As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_OpenManMesh As System.Windows.Forms.Button
    Friend WithEvents Lbl_ExpOpen As System.Windows.Forms.Label
    Friend WithEvents Btn_OpenFemMesh As System.Windows.Forms.Button
    Friend WithEvents Lbl_ExpIntensity As System.Windows.Forms.Label
    Friend WithEvents Lbl_ExpTrasparency As System.Windows.Forms.Label
    Friend WithEvents Rad_Mesh2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Mesh1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Rad_UseCustomMesh As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_UseMaleMesh As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_UseFemMesh As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_OpenCustomMesh As System.Windows.Forms.Button
End Class
