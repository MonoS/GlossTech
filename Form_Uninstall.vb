Imports System.IO
Public Class Form_Uninstall

    Private Sub Form_Uninstall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Btn_Uninstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Uninstall.Click
        If Me.Check_Fem.Checked = True Or Me.Check_man.Checked = True Then

            Me.Lbl_Progress.Visible = True

            If Me.Check_Fem.Checked = True Then
                If File.Exists("textures/actors/character/female/femalebody_1_s.dds.gloss") Then
                    File.Copy("textures/actors/character/female/femalebody_1_s.dds.gloss", "textures/actors/character/female/femalebody_1_s.dds", True)
                    File.Delete("textures/actors/character/female/femalebody_1_s.dds.gloss")
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of femalebody_1_s.dds restored" & vbNewLine
                Else
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Unable to restore femalebody_1_s.dds! File not found" & vbNewLine
                End If

                If File.Exists("textures/actors/character/female/femalehands_1_s.dds.gloss") Then
                    File.Copy("textures/actors/character/female/femalehands_1_s.dds.gloss", "textures/actors/character/female/femalehands_1_s.dds", True)
                    File.Delete("textures/actors/character/female/femalehands_1_s.dds.gloss")
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of femalehands_1_s.dds restored" & vbNewLine
                Else
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Unable to restore femalehands_1_s.dds! File not found" & vbNewLine
                End If

                If File.Exists("textures/actors/character/female/femalehead_s.dds.gloss") Then
                    File.Copy("textures/actors/character/female/femalehead_s.dds.gloss", "textures/actors/character/female/femalehead_s.dds", True)
                    File.Delete("textures/actors/character/female/femalehead_s.dds.gloss")
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of femalehead_s.dds restored" & vbNewLine
                Else
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Unable to restore femalehead_s.dds! File not found" & vbNewLine
                End If
            End If

            If Me.Check_man.Checked = True Then
                If File.Exists("textures/actors/character/male/malebody_1_s.dds.gloss") Then
                    File.Copy("textures/actors/character/male/malebody_1_s.dds.gloss", "textures/actors/character/male/malebody_1_s.dds", True)
                    File.Delete("textures/actors/character/male/malebody_1_s.dds.gloss")
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of malebody_1_s.dds restored" & vbNewLine
                Else
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Unable to restore malebody_1_s.dds! File not found" & vbNewLine
                End If

                If File.Exists("textures/actors/character/male/malehands_1_s.dds.gloss") Then
                    File.Copy("textures/actors/character/male/malehands_1_s.dds.gloss", "textures/actors/character/male/malehands_1_s.dds", True)
                    File.Delete("textures/actors/character/male/malehands_1_s.dds.gloss")
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of malehands_1_s.dds restored" & vbNewLine
                Else
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Unable to restore malehands_1_s.dds! File not found" & vbNewLine
                End If

                If File.Exists("textures/actors/character/male/malehead_s.dds.gloss") Then
                    File.Copy("textures/actors/character/male/malehead_s.dds.gloss", "textures/actors/character/male/malehead_s.dds", True)
                    File.Delete("textures/actors/character/male/malehead_s.dds.gloss")
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of malehead_s.dds restored" & vbNewLine
                Else
                    Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Unable to restore malehead_s.dds! File not found" & vbNewLine
                End If
            End If

            Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "All done!"
            Me.Btn_Exit.Visible = True
        Else
            Form_ErrorUninstall.Show()
            Me.Enabled = False
        End If
    End Sub

    Private Sub Btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub
End Class