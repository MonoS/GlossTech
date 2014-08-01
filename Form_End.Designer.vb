<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_End
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
        Me.Lbl_Finish = New System.Windows.Forms.Label()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Finish
        '
        Me.Lbl_Finish.AutoSize = True
        Me.Lbl_Finish.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Finish.Name = "Lbl_Finish"
        Me.Lbl_Finish.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Finish.TabIndex = 0
        Me.Lbl_Finish.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(159, 31)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Exit.TabIndex = 1
        Me.Btn_Exit.Text = "Exit!"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Form_End
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 66)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Lbl_Finish)
        Me.MaximizeBox = False
        Me.Name = "Form_End"
        Me.Text = "WELL DONE!!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Finish As System.Windows.Forms.Label
    Friend WithEvents Btn_Exit As System.Windows.Forms.Button
End Class
