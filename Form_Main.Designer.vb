<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Me.Lbl_SubTitle = New System.Windows.Forms.Label()
        Me.Lbl_exp = New System.Windows.Forms.Label()
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Rad_Install = New System.Windows.Forms.RadioButton()
        Me.Rad_InstCust = New System.Windows.Forms.RadioButton()
        Me.Check_Uninstall = New System.Windows.Forms.CheckBox()
        Me.Rad_Uninstall = New System.Windows.Forms.RadioButton()
        Me.Rad_UninstCust = New System.Windows.Forms.RadioButton()
        Me.Btn_Special = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(179, 37)
        Me.Lbl_Title.TabIndex = 0
        Me.Lbl_Title.Text = "GlossTech"
        '
        'Lbl_SubTitle
        '
        Me.Lbl_SubTitle.AutoSize = True
        Me.Lbl_SubTitle.Location = New System.Drawing.Point(16, 46)
        Me.Lbl_SubTitle.Name = "Lbl_SubTitle"
        Me.Lbl_SubTitle.Size = New System.Drawing.Size(176, 13)
        Me.Lbl_SubTitle.TabIndex = 1
        Me.Lbl_SubTitle.Text = "Lets glossify your Skyrim experience"
        '
        'Lbl_exp
        '
        Me.Lbl_exp.AutoSize = True
        Me.Lbl_exp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_exp.Location = New System.Drawing.Point(255, 63)
        Me.Lbl_exp.Name = "Lbl_exp"
        Me.Lbl_exp.Size = New System.Drawing.Size(225, 112)
        Me.Lbl_exp.TabIndex = 3
        Me.Lbl_exp.Text = "This mod give at all the female" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "character in game a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*very natural* gloss shine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Whit the GlossTech technology" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you can chose your the quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of gloss of y" & _
            "our pleasure"
        '
        'Btn_Start
        '
        Me.Btn_Start.Location = New System.Drawing.Point(285, 343)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(195, 53)
        Me.Btn_Start.TabIndex = 4
        Me.Btn_Start.Text = "Start!"
        Me.Btn_Start.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GlossTechGUI.My.Resources.Resources.Clipboard02
        Me.PictureBox1.Location = New System.Drawing.Point(1, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 404)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Rad_Install
        '
        Me.Rad_Install.AutoSize = True
        Me.Rad_Install.Location = New System.Drawing.Point(285, 193)
        Me.Rad_Install.Name = "Rad_Install"
        Me.Rad_Install.Size = New System.Drawing.Size(52, 17)
        Me.Rad_Install.TabIndex = 5
        Me.Rad_Install.TabStop = True
        Me.Rad_Install.Text = "Install"
        Me.Rad_Install.UseVisualStyleBackColor = True
        '
        'Rad_InstCust
        '
        Me.Rad_InstCust.AutoSize = True
        Me.Rad_InstCust.Location = New System.Drawing.Point(285, 217)
        Me.Rad_InstCust.Name = "Rad_InstCust"
        Me.Rad_InstCust.Size = New System.Drawing.Size(128, 17)
        Me.Rad_InstCust.TabIndex = 6
        Me.Rad_InstCust.TabStop = True
        Me.Rad_InstCust.Text = "Install for custom race"
        Me.Rad_InstCust.UseVisualStyleBackColor = True
        '
        'Check_Uninstall
        '
        Me.Check_Uninstall.AutoSize = True
        Me.Check_Uninstall.Location = New System.Drawing.Point(285, 241)
        Me.Check_Uninstall.Name = "Check_Uninstall"
        Me.Check_Uninstall.Size = New System.Drawing.Size(66, 17)
        Me.Check_Uninstall.TabIndex = 7
        Me.Check_Uninstall.Text = "Uninstall"
        Me.Check_Uninstall.UseVisualStyleBackColor = True
        '
        'Rad_Uninstall
        '
        Me.Rad_Uninstall.AutoSize = True
        Me.Rad_Uninstall.Location = New System.Drawing.Point(304, 265)
        Me.Rad_Uninstall.Name = "Rad_Uninstall"
        Me.Rad_Uninstall.Size = New System.Drawing.Size(65, 17)
        Me.Rad_Uninstall.TabIndex = 8
        Me.Rad_Uninstall.TabStop = True
        Me.Rad_Uninstall.Text = "Uninstall"
        Me.Rad_Uninstall.UseVisualStyleBackColor = True
        Me.Rad_Uninstall.Visible = False
        '
        'Rad_UninstCust
        '
        Me.Rad_UninstCust.AutoSize = True
        Me.Rad_UninstCust.Location = New System.Drawing.Point(304, 289)
        Me.Rad_UninstCust.Name = "Rad_UninstCust"
        Me.Rad_UninstCust.Size = New System.Drawing.Size(141, 17)
        Me.Rad_UninstCust.TabIndex = 9
        Me.Rad_UninstCust.TabStop = True
        Me.Rad_UninstCust.Text = "Uninstall for custom race"
        Me.Rad_UninstCust.UseVisualStyleBackColor = True
        Me.Rad_UninstCust.Visible = False
        '
        'Btn_Special
        '
        Me.Btn_Special.Location = New System.Drawing.Point(285, 401)
        Me.Btn_Special.Name = "Btn_Special"
        Me.Btn_Special.Size = New System.Drawing.Size(195, 53)
        Me.Btn_Special.TabIndex = 10
        Me.Btn_Special.Text = "Special features"
        Me.Btn_Special.UseVisualStyleBackColor = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 466)
        Me.Controls.Add(Me.Btn_Special)
        Me.Controls.Add(Me.Rad_UninstCust)
        Me.Controls.Add(Me.Rad_Uninstall)
        Me.Controls.Add(Me.Check_Uninstall)
        Me.Controls.Add(Me.Rad_InstCust)
        Me.Controls.Add(Me.Rad_Install)
        Me.Controls.Add(Me.Btn_Start)
        Me.Controls.Add(Me.Lbl_exp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbl_SubTitle)
        Me.Controls.Add(Me.Lbl_Title)
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.Text = "GlossTech"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Lbl_SubTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_exp As System.Windows.Forms.Label
    Friend WithEvents Btn_Start As System.Windows.Forms.Button
    Friend WithEvents Rad_Install As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_InstCust As System.Windows.Forms.RadioButton
    Friend WithEvents Check_Uninstall As System.Windows.Forms.CheckBox
    Friend WithEvents Rad_Uninstall As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_UninstCust As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Special As System.Windows.Forms.Button

End Class
