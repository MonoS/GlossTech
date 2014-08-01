<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TexBlend
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
        Me.Lbl_TexBlend = New System.Windows.Forms.Label()
        Me.Btn_Press = New System.Windows.Forms.Button()
        Me.Pic_TexBlendFem = New System.Windows.Forms.PictureBox()
        Me.Pic_TexBlendMan = New System.Windows.Forms.PictureBox()
        Me.Tmr_FemToMan = New System.Windows.Forms.Timer(Me.components)
        Me.Tmr_ManFromFem = New System.Windows.Forms.Timer(Me.components)
        Me.Tmr_Man = New System.Windows.Forms.Timer(Me.components)
        Me.Tmr_Fem = New System.Windows.Forms.Timer(Me.components)
        Me.Tmr_Custom = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Pic_TexBlendFem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_TexBlendMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_TexBlend
        '
        Me.Lbl_TexBlend.AutoSize = True
        Me.Lbl_TexBlend.Location = New System.Drawing.Point(13, 13)
        Me.Lbl_TexBlend.Name = "Lbl_TexBlend"
        Me.Lbl_TexBlend.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_TexBlend.TabIndex = 2
        '
        'Btn_Press
        '
        Me.Btn_Press.Location = New System.Drawing.Point(16, 28)
        Me.Btn_Press.Name = "Btn_Press"
        Me.Btn_Press.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Press.TabIndex = 3
        Me.Btn_Press.Text = "Press Me!"
        Me.Btn_Press.UseVisualStyleBackColor = True
        Me.Btn_Press.Visible = False
        '
        'Pic_TexBlendFem
        '
        Me.Pic_TexBlendFem.Location = New System.Drawing.Point(12, 57)
        Me.Pic_TexBlendFem.Name = "Pic_TexBlendFem"
        Me.Pic_TexBlendFem.Size = New System.Drawing.Size(456, 569)
        Me.Pic_TexBlendFem.TabIndex = 1
        Me.Pic_TexBlendFem.TabStop = False
        Me.Pic_TexBlendFem.Visible = False
        '
        'Pic_TexBlendMan
        '
        Me.Pic_TexBlendMan.Location = New System.Drawing.Point(12, 57)
        Me.Pic_TexBlendMan.Name = "Pic_TexBlendMan"
        Me.Pic_TexBlendMan.Size = New System.Drawing.Size(454, 567)
        Me.Pic_TexBlendMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_TexBlendMan.TabIndex = 4
        Me.Pic_TexBlendMan.TabStop = False
        Me.Pic_TexBlendMan.Visible = False
        '
        'Tmr_FemToMan
        '
        Me.Tmr_FemToMan.Interval = 200
        '
        'Tmr_ManFromFem
        '
        Me.Tmr_ManFromFem.Interval = 200
        '
        'Tmr_Man
        '
        Me.Tmr_Man.Interval = 200
        '
        'Tmr_Fem
        '
        Me.Tmr_Fem.Interval = 200
        '
        'Tmr_Custom
        '
        Me.Tmr_Custom.Interval = 200
        '
        'Form_TexBlend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 639)
        Me.Controls.Add(Me.Pic_TexBlendMan)
        Me.Controls.Add(Me.Btn_Press)
        Me.Controls.Add(Me.Lbl_TexBlend)
        Me.Controls.Add(Me.Pic_TexBlendFem)
        Me.Name = "Form_TexBlend"
        Me.Text = "TexBlend"
        CType(Me.Pic_TexBlendFem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_TexBlendMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pic_TexBlendFem As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_TexBlend As System.Windows.Forms.Label
    Friend WithEvents Btn_Press As System.Windows.Forms.Button
    Friend WithEvents Pic_TexBlendMan As System.Windows.Forms.PictureBox
    Friend WithEvents Tmr_FemToMan As System.Windows.Forms.Timer
    Friend WithEvents Tmr_ManFromFem As System.Windows.Forms.Timer
    Friend WithEvents Tmr_Man As System.Windows.Forms.Timer
    Friend WithEvents Tmr_Fem As System.Windows.Forms.Timer
    Friend WithEvents Tmr_Custom As System.Windows.Forms.Timer
End Class
