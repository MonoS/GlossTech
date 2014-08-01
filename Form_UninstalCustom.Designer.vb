<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_UninstalCustom
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
        Me.Rad_CustomOther = New System.Windows.Forms.RadioButton()
        Me.Rad_CustomMan = New System.Windows.Forms.RadioButton()
        Me.Rad_CustomFem = New System.Windows.Forms.RadioButton()
        Me.Dir_Custom = New System.Windows.Forms.FolderBrowserDialog()
        Me.File_Custom = New System.Windows.Forms.OpenFileDialog()
        Me.Btn_Uninstall = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Rad_CustomOther
        '
        Me.Rad_CustomOther.AutoSize = True
        Me.Rad_CustomOther.Location = New System.Drawing.Point(255, 12)
        Me.Rad_CustomOther.Name = "Rad_CustomOther"
        Me.Rad_CustomOther.Size = New System.Drawing.Size(51, 17)
        Me.Rad_CustomOther.TabIndex = 34
        Me.Rad_CustomOther.TabStop = True
        Me.Rad_CustomOther.Text = "Other"
        Me.Rad_CustomOther.UseVisualStyleBackColor = True
        '
        'Rad_CustomMan
        '
        Me.Rad_CustomMan.AutoSize = True
        Me.Rad_CustomMan.Location = New System.Drawing.Point(139, 12)
        Me.Rad_CustomMan.Name = "Rad_CustomMan"
        Me.Rad_CustomMan.Size = New System.Drawing.Size(109, 17)
        Me.Rad_CustomMan.TabIndex = 33
        Me.Rad_CustomMan.TabStop = True
        Me.Rad_CustomMan.Text = "Male custom race"
        Me.Rad_CustomMan.UseVisualStyleBackColor = True
        '
        'Rad_CustomFem
        '
        Me.Rad_CustomFem.AutoSize = True
        Me.Rad_CustomFem.Location = New System.Drawing.Point(12, 12)
        Me.Rad_CustomFem.Name = "Rad_CustomFem"
        Me.Rad_CustomFem.Size = New System.Drawing.Size(120, 17)
        Me.Rad_CustomFem.TabIndex = 32
        Me.Rad_CustomFem.TabStop = True
        Me.Rad_CustomFem.Text = "Female custom race"
        Me.Rad_CustomFem.UseVisualStyleBackColor = True
        '
        'Btn_Uninstall
        '
        Me.Btn_Uninstall.Location = New System.Drawing.Point(134, 36)
        Me.Btn_Uninstall.Name = "Btn_Uninstall"
        Me.Btn_Uninstall.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Uninstall.TabIndex = 35
        Me.Btn_Uninstall.Text = "Uninstall"
        Me.Btn_Uninstall.UseVisualStyleBackColor = True
        '
        'Form_UninstalCustom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 70)
        Me.Controls.Add(Me.Btn_Uninstall)
        Me.Controls.Add(Me.Rad_CustomOther)
        Me.Controls.Add(Me.Rad_CustomMan)
        Me.Controls.Add(Me.Rad_CustomFem)
        Me.MaximizeBox = False
        Me.Name = "Form_UninstalCustom"
        Me.Text = "Uninstall for custom race"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rad_CustomOther As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_CustomMan As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_CustomFem As System.Windows.Forms.RadioButton
    Friend WithEvents Dir_Custom As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents File_Custom As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Btn_Uninstall As System.Windows.Forms.Button
End Class
