Public Class Form_ManGloss

    Private Sub Bar_Man_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bar_Man.Scroll
        If Me.Bar_Man.Value = 0 Then
            Me.Rad_Preset1.Checked = True
            Me.Pic_Preset.Image = Nothing
        Else
            Me.Rad_Preset1.Checked = False
        End If

        If Me.Bar_Man.Value = 15 Then
            Me.Rad_Preset2.Checked = True
            Me.Pic_Preset.Image = Nothing
        Else
            Me.Rad_Preset2.Checked = False
        End If

        If Me.Bar_Man.Value = 25 Then
            Me.Rad_Preset3.Checked = True
            Me.Pic_Preset.Image = Nothing
        Else
            Me.Rad_Preset3.Checked = False
        End If

        If Me.Bar_Man.Value = 35 Then
            Me.Rad_Preset4.Checked = True
            Me.Pic_Preset.Image = Nothing
        Else
            Me.Rad_Preset4.Checked = False
        End If

        If Me.Bar_Man.Value = 100 Then
            Me.Rad_Preset5.Checked = True
            Me.Pic_Preset.Image = Nothing
        Else
            Me.Rad_Preset5.Checked = False
        End If

        If Rad_Preset1.Checked = False And Rad_Preset2.Checked = False And Rad_Preset3.Checked = False And Rad_Preset4.Checked = False And Rad_Preset5.Checked = False Then
            Me.Pic_Preset.Image = Nothing
        End If
    End Sub

    Private Sub Check_Man_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Man.CheckedChanged
        If Me.Check_Man.Checked = True Then
            Me.Bar_Man.Visible = True
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
            Me.Bar_Man.Visible = False
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

    Private Sub Tmr_BarProgress_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr_BarProgress.Tick
        Me.Lbl_BarProgress.Text = Me.Bar_Man.Value
    End Sub

    Private Sub Rad_Preset1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset1.CheckedChanged
        If Me.Rad_Preset1.Checked = True Then
            Me.Bar_Man.Value = 0
            Me.Pic_Preset.Image = Nothing
        End If
    End Sub

    Private Sub Rad_Preset2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset2.CheckedChanged
        If Me.Rad_Preset2.Checked = True Then
            Me.Bar_Man.Value = 15
            Me.Pic_Preset.Image = Nothing
        End If
    End Sub

    Private Sub Rad_Preset3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset3.CheckedChanged
        If Me.Rad_Preset3.Checked = True Then
            Me.Bar_Man.Value = 25
            Me.Pic_Preset.Image = Nothing
        End If
    End Sub

    Private Sub Rad_Preset4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset4.CheckedChanged
        If Me.Rad_Preset4.Checked = True Then
            Me.Bar_Man.Value = 35
            Me.Pic_Preset.Image = Nothing
        End If
    End Sub

    Private Sub Rad_Preset5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset5.CheckedChanged
        If Me.Rad_Preset5.Checked = True Then
            Me.Bar_Man.Value = 100
            Me.Pic_Preset.Image = Nothing
        End If
    End Sub

    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Data.Bool_ManGloss = Check_Man.Checked

        If Me.Check_Man.Checked = True Then
            Data.Value_ManGloss = Me.Bar_Man.Value
        Else
            Data.Value_ManGloss = -1
        End If

        If Data.Bool_FemaleGloss = False And Data.Bool_ManGloss = False Then
            Form_ErrorInstall.Show()
        Else
            Form_Head.Show()
        End If

        Me.Close()

    End Sub
End Class