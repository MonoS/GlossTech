<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Uninstall
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
        Me.Lbl_Progress = New System.Windows.Forms.Label()
        Me.Btn_Uninstall = New System.Windows.Forms.Button()
        Me.Check_Fem = New System.Windows.Forms.CheckBox()
        Me.Check_man = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Lbl_Progress
        '
        Me.Lbl_Progress.AutoSize = True
        Me.Lbl_Progress.Location = New System.Drawing.Point(12, 87)
        Me.Lbl_Progress.Name = "Lbl_Progress"
        Me.Lbl_Progress.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Progress.TabIndex = 0
        Me.Lbl_Progress.Visible = False
        '
        'Btn_Uninstall
        '
        Me.Btn_Uninstall.Location = New System.Drawing.Point(109, 60)
        Me.Btn_Uninstall.Name = "Btn_Uninstall"
        Me.Btn_Uninstall.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Uninstall.TabIndex = 2
        Me.Btn_Uninstall.Text = "Uninstall"
        Me.Btn_Uninstall.UseVisualStyleBackColor = True
        '
        'Check_Fem
        '
        Me.Check_Fem.AutoSize = True
        Me.Check_Fem.Location = New System.Drawing.Point(13, 13)
        Me.Check_Fem.Name = "Check_Fem"
        Me.Check_Fem.Size = New System.Drawing.Size(115, 17)
        Me.Check_Fem.TabIndex = 3
        Me.Check_Fem.Text = "Uninstall for female"
        Me.Check_Fem.UseVisualStyleBackColor = True
        '
        'Check_man
        '
        Me.Check_man.AutoSize = True
        Me.Check_man.Location = New System.Drawing.Point(13, 37)
        Me.Check_man.Name = "Check_man"
        Me.Check_man.Size = New System.Drawing.Size(104, 17)
        Me.Check_man.TabIndex = 4
        Me.Check_man.Text = "Uninstall for man"
        Me.Check_man.UseVisualStyleBackColor = True
        '
        'Form_Uninstall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Check_man)
        Me.Controls.Add(Me.Check_Fem)
        Me.Controls.Add(Me.Btn_Uninstall)
        Me.Controls.Add(Me.Lbl_Progress)
        Me.MaximizeBox = False
        Me.Name = "Form_Uninstall"
        Me.Text = "Uninstalling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Progress As System.Windows.Forms.Label
    Friend WithEvents Btn_Uninstall As System.Windows.Forms.Button
    Friend WithEvents Check_Fem As System.Windows.Forms.CheckBox
    Friend WithEvents Check_man As System.Windows.Forms.CheckBox
End Class
