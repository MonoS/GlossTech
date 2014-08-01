Imports System.IO
Public Class Form_TexBlend
    Public Go As Boolean
    Public startInfo As New ProcessStartInfo("TexBlend.exe")
    Private Sub Form_TexBlend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Go = False
        startInfo.WorkingDirectory = "TexBlend/"

        If Data.Bool_Custom = True Then
            FileCopy("textures/actors/character/female/femalehead_s.dds", "textures/actors/character/female/femalehead_s.dds.tmp")
            FileCopy(Data.String_CustomHead, "TexBlend/Source/Head/Specular/customhead_s.dds")
            File.Delete("textures/actors/character/female/femalehead_s.dds")

            Me.Lbl_TexBlend.Text = "Configure TexBlend as the image and press Blend Image then press the button down here"
            Me.Pic_TexBlendMan.Visible = True
            Me.Pic_TexBlendMan.Image = My.Resources.TexBlendCustom
            Me.Btn_Press.Visible = True
            Process.Start(startInfo)
            Me.Tmr_Custom.Enabled = True
        Else
            If Data.Bool_FemaleGloss = True And Data.Bool_ManGloss = True Then

                Me.Pic_TexBlendFem.Visible = True
                Me.Pic_TexBlendFem.Image = My.Resources.TexBlendFem
                Me.Lbl_TexBlend.Text = "Configure TexBlend as the image and press Blend Image then press the button down here"
                Process.Start(startInfo)
                Me.Btn_Press.Visible = True
                Me.Tmr_FemToMan.Enabled = True

            Else
                If Data.Bool_FemaleGloss = True Then
                    Me.Pic_TexBlendFem.Visible = True
                    Me.Pic_TexBlendFem.Image = My.Resources.TexBlendFem
                    Me.Lbl_TexBlend.Text = "Configure TexBlend as the image and press Blend Image then press the button down here"
                    Process.Start(startInfo)
                    Me.Btn_Press.Visible = True
                    Me.Tmr_Fem.Enabled = True
                Else
                    FileCopy("textures/actors/character/female/femalehead_s.dds", "textures/actors/character/female/femalehead_s.dds.tmp")
                    File.Delete("textures/actors/character/female/femalehead_s.dds")
                    FileCopy("textures/actors/character/male/malehead_s.dds", "TexBlend/Source/Head/Specular/malehead_s.dds")

                    Me.Lbl_TexBlend.Text = "Configure TexBlend as the image and press Blend Image then press the button down here"
                    Me.Pic_TexBlendMan.Visible = True
                    Me.Pic_TexBlendMan.Image = My.Resources.TexBlendMan
                    Me.Btn_Press.Visible = True
                    Process.Start(startInfo)
                    Me.Tmr_Man.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Btn_Press1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Press.Click
        Go = True
    End Sub

    Private Sub Tmr_Fem_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr_FemToMan.Tick
        If Go = True Then
            Me.Pic_TexBlendFem.Visible = False
            Me.Btn_Press.Visible = False
            File.Delete("TexBlend/Library/Head/Specular/femalehead_s.dds")
            Go = False

            FileCopy("textures/actors/character/female/femalehead_s.dds", "textures/actors/character/female/femalehead_s.dds.tmp")
            File.Delete("textures/actors/character/female/femalehead_s.dds")
            FileCopy("textures/actors/character/male/malehead_s.dds", "TexBlend/Source/Head/Specular/malehead_s.dds")

            Me.Pic_TexBlendMan.Visible = True
            Me.Pic_TexBlendMan.Image = My.Resources.TexBlendMan
            Me.Btn_Press.Visible = True
            Process.Start(startInfo)
            Me.Tmr_ManFromFem.Enabled = True
            Me.Tmr_FemToMan.Enabled = False
        End If
    End Sub

    Private Sub Tmr_ManFromFem_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr_ManFromFem.Tick
        If Go = True Then

            Go = False
            Me.Pic_TexBlendMan.Visible = False
            Me.Btn_Press.Visible = False

            File.Delete("TexBlend/Source/Head/Specular/malehead_s.dds")
            File.Delete("textures/actors/character/male/malehead_s.dds")
            FileCopy("textures/actors/character/female/femalehead_s.dds", "textures/actors/character/male/malehead_s.dds")
            File.Delete("textures/actors/character/female/femalehead_s.dds")
            FileCopy("textures/actors/character/female/femalehead_s.dds.tmp", "textures/actors/character/female/femalehead_s.dds")

            File.Delete("TexBlend/Library/Head/Specular/malehead_s.dds")
            Me.Tmr_ManFromFem.Enabled = False
            Form_End.Show()
            Form_End.Lbl_Finish.Text = "Congratulation, you've succesfully installed GlossTech"
            Me.Close()
        End If
    End Sub

    Private Sub Tmr_Man_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr_Man.Tick
        If Go = True Then

            Go = False
            Me.Pic_TexBlendMan.Visible = False
            Me.Btn_Press.Visible = False

            File.Delete("textures/actors/character/male/malehead_s.dds")
            FileCopy("textures/actors/character/female/femalehead_s.dds", "textures/actors/character/male/malehead_s.dds")
            File.Delete("textures/actors/character/female/femalehead_s.dds")
            FileCopy("textures/actors/character/female/femalehead_s.dds.tmp", "textures/actors/character/female/femalehead_s.dds")

            File.Delete("TexBlend/Library/Head/Specular/malehead_s.dds")
            Me.Tmr_Man.Enabled = False
            Form_End.Show()
            Form_End.Lbl_Finish.Text = "Congratulation, you've succesfully installed GlossTech"
            Me.Close()
        End If
    End Sub

    Private Sub Tmr_Fem_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr_Fem.Tick
        If Go = True Then
            File.Delete("TexBlend/Library/Head/Specular/femalehead_s.dds")
            Tmr_Fem.Enabled = False
            Form_End.Show()
            Form_End.Lbl_Finish.Text = "Congratulation, you've succesfully installed GlossTech"
            Me.Close()
        End If
    End Sub

    Private Sub Tmr_Custom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr_Custom.Tick
        If Go = True Then
            Go = False
            Me.Pic_TexBlendMan.Visible = False
            Me.Btn_Press.Visible = False

            File.Delete(Data.String_CustomHead)
            FileCopy("textures/actors/character/female/femalehead_s.dds", Data.String_CustomHead)
            File.Delete("textures/actors/character/female/femalehead_s.dds")
            FileCopy("textures/actors/character/female/femalehead_s.dds.tmp", "textures/actors/character/female/femalehead_s.dds")

            File.Delete("TexBlend/Library/Head/Specular/customhead_s.dds")
            Me.Tmr_Man.Enabled = False
            Form_End.Show()
            Form_End.Lbl_Finish.Text = "Congratulation, you've succesfully installed GlossTech"
            Me.Close()
        End If

    End Sub
End Class