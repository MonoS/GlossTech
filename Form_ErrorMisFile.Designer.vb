<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ErrorMisFile
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
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Lbl_Error = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(103, 31)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Exit.TabIndex = 0
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Lbl_Error
        '
        Me.Lbl_Error.AutoSize = True
        Me.Lbl_Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Error.Location = New System.Drawing.Point(2, 9)
        Me.Lbl_Error.Name = "Lbl_Error"
        Me.Lbl_Error.Size = New System.Drawing.Size(279, 16)
        Me.Lbl_Error.TabIndex = 1
        Me.Lbl_Error.Text = "Some file are missing, reinstall the mod"
        '
        'Form_ErrorMisFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 66)
        Me.Controls.Add(Me.Lbl_Error)
        Me.Controls.Add(Me.Btn_Exit)
        Me.MaximizeBox = False
        Me.Name = "Form_ErrorMisFile"
        Me.Text = "Error"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Exit As System.Windows.Forms.Button
    Friend WithEvents Lbl_Error As System.Windows.Forms.Label
End Class
