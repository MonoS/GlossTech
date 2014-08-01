<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Head
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
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Group_Mesh = New System.Windows.Forms.GroupBox()
        Me.Btn_OpenManMesh = New System.Windows.Forms.Button()
        Me.Lbl_ExpOpen = New System.Windows.Forms.Label()
        Me.Btn_OpenFemMesh = New System.Windows.Forms.Button()
        Me.Lbl_ExpIntensity = New System.Windows.Forms.Label()
        Me.Lbl_ExpTrasparency = New System.Windows.Forms.Label()
        Me.Rad_Mesh2 = New System.Windows.Forms.RadioButton()
        Me.Rad_Mesh1 = New System.Windows.Forms.RadioButton()
        Me.Group_Head = New System.Windows.Forms.GroupBox()
        Me.Rad_HeadAll = New System.Windows.Forms.RadioButton()
        Me.Rad_HeadMesh = New System.Windows.Forms.RadioButton()
        Me.Btn_Next = New System.Windows.Forms.Button()
        Me.Group_Mesh.SuspendLayout()
        Me.Group_Head.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(157, 9)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(179, 37)
        Me.Lbl_Title.TabIndex = 4
        Me.Lbl_Title.Text = "GlossTech"
        '
        'Group_Mesh
        '
        Me.Group_Mesh.Controls.Add(Me.Btn_OpenManMesh)
        Me.Group_Mesh.Controls.Add(Me.Lbl_ExpOpen)
        Me.Group_Mesh.Controls.Add(Me.Btn_OpenFemMesh)
        Me.Group_Mesh.Controls.Add(Me.Lbl_ExpIntensity)
        Me.Group_Mesh.Controls.Add(Me.Lbl_ExpTrasparency)
        Me.Group_Mesh.Controls.Add(Me.Rad_Mesh2)
        Me.Group_Mesh.Controls.Add(Me.Rad_Mesh1)
        Me.Group_Mesh.Location = New System.Drawing.Point(12, 124)
        Me.Group_Mesh.Name = "Group_Mesh"
        Me.Group_Mesh.Size = New System.Drawing.Size(468, 129)
        Me.Group_Mesh.TabIndex = 6
        Me.Group_Mesh.TabStop = False
        Me.Group_Mesh.Text = "Mesh option"
        Me.Group_Mesh.Visible = False
        '
        'Btn_OpenManMesh
        '
        Me.Btn_OpenManMesh.Location = New System.Drawing.Point(244, 67)
        Me.Btn_OpenManMesh.Name = "Btn_OpenManMesh"
        Me.Btn_OpenManMesh.Size = New System.Drawing.Size(118, 23)
        Me.Btn_OpenManMesh.TabIndex = 6
        Me.Btn_OpenManMesh.Text = "Modify man mesh"
        Me.Btn_OpenManMesh.UseVisualStyleBackColor = True
        '
        'Lbl_ExpOpen
        '
        Me.Lbl_ExpOpen.AutoSize = True
        Me.Lbl_ExpOpen.Location = New System.Drawing.Point(97, 93)
        Me.Lbl_ExpOpen.Name = "Lbl_ExpOpen"
        Me.Lbl_ExpOpen.Size = New System.Drawing.Size(302, 26)
        Me.Lbl_ExpOpen.TabIndex = 5
        Me.Lbl_ExpOpen.Text = "You need a program like Paint.net for open and save the mesh" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IMPORTANT: save as " & _
            "R8G8B8 or will NOT work"
        '
        'Btn_OpenFemMesh
        '
        Me.Btn_OpenFemMesh.Location = New System.Drawing.Point(120, 67)
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
        'Group_Head
        '
        Me.Group_Head.Controls.Add(Me.Rad_HeadAll)
        Me.Group_Head.Controls.Add(Me.Rad_HeadMesh)
        Me.Group_Head.Location = New System.Drawing.Point(12, 49)
        Me.Group_Head.Name = "Group_Head"
        Me.Group_Head.Size = New System.Drawing.Size(467, 69)
        Me.Group_Head.TabIndex = 7
        Me.Group_Head.TabStop = False
        Me.Group_Head.Text = "Head option"
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
        'Btn_Next
        '
        Me.Btn_Next.Location = New System.Drawing.Point(197, 259)
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(102, 23)
        Me.Btn_Next.TabIndex = 8
        Me.Btn_Next.Text = "Start glossing"
        Me.Btn_Next.UseVisualStyleBackColor = True
        '
        'Form_Head
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 289)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.Group_Head)
        Me.Controls.Add(Me.Group_Mesh)
        Me.Controls.Add(Me.Lbl_Title)
        Me.MaximizeBox = False
        Me.Name = "Form_Head"
        Me.Text = "Gloss for your face"
        Me.Group_Mesh.ResumeLayout(False)
        Me.Group_Mesh.PerformLayout()
        Me.Group_Head.ResumeLayout(False)
        Me.Group_Head.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Group_Mesh As System.Windows.Forms.GroupBox
    Friend WithEvents Rad_Mesh2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_Mesh1 As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_ExpTrasparency As System.Windows.Forms.Label
    Friend WithEvents Lbl_ExpIntensity As System.Windows.Forms.Label
    Friend WithEvents Group_Head As System.Windows.Forms.GroupBox
    Friend WithEvents Rad_HeadAll As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_HeadMesh As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_OpenFemMesh As System.Windows.Forms.Button
    Friend WithEvents Lbl_ExpOpen As System.Windows.Forms.Label
    Friend WithEvents Btn_Next As System.Windows.Forms.Button
    Friend WithEvents Btn_OpenManMesh As System.Windows.Forms.Button
End Class
