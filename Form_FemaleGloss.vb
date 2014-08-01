Public Class Form_FemaleGloss

    Private Sub Bar_Female_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bar_Female.Scroll
        If Me.Bar_Female.Value = 0 Then
            Me.Rad_Preset1.Checked = True
            Me.Pic_Preset.Image = My.Resources.No_Gloss
        Else
            Me.Rad_Preset1.Checked = False
        End If

        If Me.Bar_Female.Value = 15 Then
            Me.Rad_Preset2.Checked = True
            Me.Pic_Preset.Image = My.Resources.Low_Gloss
        Else
            Me.Rad_Preset2.Checked = False
        End If

        If Me.Bar_Female.Value = 25 Then
            Me.Rad_Preset3.Checked = True
            Me.Pic_Preset.Image = My.Resources.Mid_Gloss
        Else
            Me.Rad_Preset3.Checked = False
        End If

        If Me.Bar_Female.Value = 35 Then
            Me.Rad_Preset4.Checked = True
            Me.Pic_Preset.Image = My.Resources.High_Gloss
        Else
            Me.Rad_Preset4.Checked = False
        End If

        If Me.Bar_Female.Value = 100 Then
            Me.Rad_Preset5.Checked = True
            Me.Pic_Preset.Image = My.Resources.Ultra_Gloss
        Else
            Me.Rad_Preset5.Checked = False
        End If

        If Rad_Preset1.Checked = False And Rad_Preset2.Checked = False And Rad_Preset3.Checked = False And Rad_Preset4.Checked = False And Rad_Preset5.Checked = False Then
            Me.Pic_Preset.Image = Nothing
        End If

    End Sub

    Private Sub Check_Fem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Fem.CheckedChanged
        If Me.Check_Fem.Checked = True Then
            Me.Bar_Female.Visible = True
            Me.Tmr_BarProgress.Enabled = True
            Me.Lbl_BarProgress.Visible = True
            Me.lbl_preset.Visible = True
            Me.Rad_Preset1.Visible = True
            Me.Rad_Preset2.Visible = True
            Me.Rad_Preset3.Visible = True
            Me.Rad_Preset4.Visible = True
            Me.Rad_Preset5.Visible = True
            Me.Pic_Preset.Visible = True
        Else
            Me.Bar_Female.Visible = False
            Me.Tmr_BarProgress.Enabled = False
            Me.Lbl_BarProgress.Visible = False
            Me.lbl_preset.Visible = False
            Me.Rad_Preset1.Visible = False
            Me.Rad_Preset2.Visible = False
            Me.Rad_Preset3.Visible = False
            Me.Rad_Preset4.Visible = False
            Me.Rad_Preset5.Visible = False
            Me.Pic_Preset.Visible = False
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr_BarProgress.Tick
        Me.Lbl_BarProgress.Text = Me.Bar_Female.Value
    End Sub

    Private Sub Lbl_BarProgress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_BarProgress.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset1.CheckedChanged
        If Me.Rad_Preset1.Checked = True Then
            Me.Bar_Female.Value = 0
            Me.Pic_Preset.Image = My.Resources.No_Gloss
        End If
    End Sub

    Private Sub lbl_preset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_preset.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset3.CheckedChanged
        If Me.Rad_Preset3.Checked = True Then
            Me.Bar_Female.Value = 25
            Me.Pic_Preset.Image = My.Resources.Mid_Gloss
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset4.CheckedChanged
        If Me.Rad_Preset4.Checked = True Then
            Me.Bar_Female.Value = 35
            Me.Pic_Preset.Image = My.Resources.High_Gloss
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset5.CheckedChanged
        If Me.Rad_Preset5.Checked = True Then
            Me.Bar_Female.Value = 100
            Me.Pic_Preset.Image = My.Resources.Ultra_Gloss
        End If
    End Sub

    Private Sub Form_FemaleGloss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Rad_Preset2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset2.CheckedChanged
        If Me.Rad_Preset2.Checked = True Then
            Me.Bar_Female.Value = 15
            Me.Pic_Preset.Image = My.Resources.Low_Gloss
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_Preset.Click
        
    End Sub

    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Data.Bool_FemaleGloss = Me.Check_Fem.Checked
        If Me.Check_Fem.Checked = True Then
            Data.Value_FemaleGloss = Me.Bar_Female.Value
        Else
            Data.Value_FemaleGloss = -1
        End If

        Form_ManGloss.Show()
        Me.Close()
    End Sub
End Class