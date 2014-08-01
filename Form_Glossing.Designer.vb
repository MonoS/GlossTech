<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Glossing
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
        Me.SuspendLayout()
        '
        'Lbl_Progress
        '
        Me.Lbl_Progress.AutoSize = True
        Me.Lbl_Progress.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Progress.Name = "Lbl_Progress"
        Me.Lbl_Progress.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Progress.TabIndex = 1
        '
        'Form_Glossing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 266)
        Me.Controls.Add(Me.Lbl_Progress)
        Me.Name = "Form_Glossing"
        Me.Text = "Glossing..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Progress As System.Windows.Forms.Label
End Class
