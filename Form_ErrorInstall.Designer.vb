<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ErrorInstall
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
        Me.Lbl_Error = New System.Windows.Forms.Label()
        Me.Btn_Female = New System.Windows.Forms.Button()
        Me.Btn_man = New System.Windows.Forms.Button()
        Me.Btn_main = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Error
        '
        Me.Lbl_Error.AutoSize = True
        Me.Lbl_Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Error.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Error.Name = "Lbl_Error"
        Me.Lbl_Error.Size = New System.Drawing.Size(229, 16)
        Me.Lbl_Error.TabIndex = 0
        Me.Lbl_Error.Text = "You haven't selected any option"
        '
        'Btn_Female
        '
        Me.Btn_Female.Location = New System.Drawing.Point(15, 28)
        Me.Btn_Female.Name = "Btn_Female"
        Me.Btn_Female.Size = New System.Drawing.Size(265, 24)
        Me.Btn_Female.TabIndex = 1
        Me.Btn_Female.Text = "Return to Female Gloss selection"
        Me.Btn_Female.UseVisualStyleBackColor = True
        '
        'Btn_man
        '
        Me.Btn_man.Location = New System.Drawing.Point(15, 58)
        Me.Btn_man.Name = "Btn_man"
        Me.Btn_man.Size = New System.Drawing.Size(265, 24)
        Me.Btn_man.TabIndex = 2
        Me.Btn_man.Text = "Return to Man Gloss selection"
        Me.Btn_man.UseVisualStyleBackColor = True
        '
        'Btn_main
        '
        Me.Btn_main.Location = New System.Drawing.Point(15, 88)
        Me.Btn_main.Name = "Btn_main"
        Me.Btn_main.Size = New System.Drawing.Size(265, 23)
        Me.Btn_main.TabIndex = 3
        Me.Btn_main.Text = "Return to main page"
        Me.Btn_main.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(15, 117)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(265, 22)
        Me.Btn_Exit.TabIndex = 4
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Form_ErrorInstall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 146)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_main)
        Me.Controls.Add(Me.Btn_man)
        Me.Controls.Add(Me.Btn_Female)
        Me.Controls.Add(Me.Lbl_Error)
        Me.MaximizeBox = False
        Me.Name = "Form_ErrorInstall"
        Me.Text = "No option selected"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Error As System.Windows.Forms.Label
    Friend WithEvents Btn_Female As System.Windows.Forms.Button
    Friend WithEvents Btn_man As System.Windows.Forms.Button
    Friend WithEvents Btn_main As System.Windows.Forms.Button
    Friend WithEvents Btn_Exit As System.Windows.Forms.Button
End Class
