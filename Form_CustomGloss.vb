Imports System.IO
Public Class Form_CustomGloss
    Dim path As String
    Dim temp1 As String
    Dim temp2 As String
    Dim temp3 As String
    Dim temp4 As String
    Dim temp5 As String
    Dim temp6 As String

    Private Sub Form_CustomGloss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dir_Custom.SelectedPath = Application.StartupPath
        Me.Dir_Custom.Description = "Select the custom race texture folder"
        Me.Dir_Custom.ShowDialog()

        Me.path = Me.Dir_Custom.SelectedPath
    End Sub

    Private Sub Rad_Preset1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset1.CheckedChanged
        If Me.Rad_Preset1.Checked = True Then
            Me.Bar_Custom.Value = 0
        End If
    End Sub

    Private Sub Bar_Female_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bar_Custom.Scroll
        If Me.Bar_Custom.Value = 0 Then
            Me.Rad_Preset1.Checked = True
        Else
            Me.Rad_Preset1.Checked = False
        End If

        If Me.Bar_Custom.Value = 15 Then
            Me.Rad_Preset2.Checked = True
        Else
            Me.Rad_Preset2.Checked = False
        End If

        If Me.Bar_Custom.Value = 25 Then
            Me.Rad_Preset3.Checked = True
        Else
            Me.Rad_Preset3.Checked = False
        End If

        If Me.Bar_Custom.Value = 35 Then
            Me.Rad_Preset4.Checked = True
        Else
            Me.Rad_Preset4.Checked = False
        End If

        If Me.Bar_Custom.Value = 100 Then
            Me.Rad_Preset5.Checked = True
        Else
            Me.Rad_Preset5.Checked = False
        End If

        If Rad_Preset1.Checked = False And Rad_Preset2.Checked = False And Rad_Preset3.Checked = False And Rad_Preset4.Checked = False And Rad_Preset5.Checked = False Then
        End If
    End Sub

    Private Sub Tmr_BarProgress_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr_BarProgress.Tick
        Me.Lbl_BarProgress.Text = Me.Bar_Custom.Value
    End Sub

    Private Sub Rad_Preset2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset2.CheckedChanged
        If Me.Rad_Preset2.Checked = True Then
            Me.Bar_Custom.Value = 15
        End If
    End Sub

    Private Sub Rad_Preset3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset3.CheckedChanged
        If Me.Rad_Preset3.Checked = True Then
            Me.Bar_Custom.Value = 25
        End If
    End Sub

    Private Sub Rad_Preset4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset4.CheckedChanged
        If Me.Rad_Preset4.Checked = True Then
            Me.Bar_Custom.Value = 35
        End If
    End Sub

    Private Sub Rad_Preset5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_Preset5.CheckedChanged
        If Me.Rad_Preset5.Checked = True Then
            Me.Bar_Custom.Value = 100
        End If
    End Sub

    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Dim gloss As Byte
        Dim i As Integer
        Dim mesh As Integer

        If (Me.Rad_HeadAll.Checked = False And Me.Rad_HeadMesh.Checked = False) Or (Me.Rad_HeadMesh.Checked = True And Me.Rad_UseFemMesh.Checked = False And Me.Rad_UseMaleMesh.Checked = False And Me.Rad_UseCustomMesh.Checked = False) Then
            Form_ErrorCustom.Show()
            Me.Enabled = False
        Else
            Data.Bool_HeadAll = Me.Rad_HeadAll.Checked
            Data.Bool_HeadMesh = Me.Rad_HeadMesh.Checked
            Data.Value_CustomGloss = Me.Bar_Custom.Value

            If Rad_CustomFem.Checked = True Then
                Data.Int_CustomType = 1
            End If
            If Rad_CustomMan.Checked = True Then
                Data.Int_CustomType = 2
            End If
            If Rad_CustomOther.Checked = True Then
                Data.Int_CustomType = 3
            End If

            If Rad_UseFemMesh.Checked = True Then
                Data.Int_CustomHeadType = 4
            End If
            If Rad_UseMaleMesh.Checked = True Then
                Data.Int_CustomHeadType = 5
            End If
            If Rad_UseCustomMesh.Checked = True Then
                Data.Int_CustomHeadType = 3
            End If

            If Me.Rad_Mesh0.Checked = True Then
                mesh = 0
            ElseIf Me.Rad_Mesh1.Checked = True Then
                mesh = 1
            ElseIf Me.Rad_Mesh2.Checked = True Then
                mesh = 2
            End If

            Select Case Data.Int_CustomType
                Case 1
                    temp1 = path & "/femalebody_1_s.dds"
                    temp2 = path & "/femalehands_1_s.dds"
                    temp3 = path & "/femalehead_s.dds"
                Case 2
                    temp1 = path & "/malebody_1_s.dds"
                    temp2 = path & "/malehands_1_s.dds"
                    temp3 = path & "/malehead_s.dds"
                Case 3
                    temp1 = Data.String_CustomBody
                    temp2 = Data.String_CustomHands
                    temp3 = Data.String_CustomHead
            End Select

            Data.String_CustomBody = temp1
            Data.String_CustomHands = temp2
            Data.String_CustomHead = temp3

            temp4 = temp1 & ".gloss"
            temp5 = temp2 & ".gloss"
            temp6 = temp3 & ".gloss"

            If Not File.Exists(temp4) Then
                File.Copy(temp1, temp4)
                File.Delete(temp1)
            End If

            If Not File.Exists(temp5) Then
                File.Copy(temp2, temp5)
                File.Delete(temp2)
            End If

            If Not File.Exists(temp6) Then
                File.Copy(temp3, temp6)
            End If

            gloss = Data.Value_CustomGloss * 255 / 100

            FileOpen(1, temp1, OpenMode.Binary, OpenAccess.Write)

            i = 0
            Do While i < 128
                FilePut(1, Data.header_body(i), )
                i = i + 1
            Loop

            i = 0
            Do While i < 192
                FilePut(1, gloss, )
                i = i + 1
            Loop

            FileClose(1)

            FileCopy(temp1, temp2)
            If Data.Bool_HeadAll = True Then
                File.Delete(temp3)
                FileCopy(temp1, temp3)
            End If

            If Data.Bool_HeadMesh = True Then
                Data.Do_Head_Mesh(Data.Int_CustomHeadType, gloss, mesh)
            End If

            If Data.Bool_HeadMesh = True Then
                Form_TexBlend.Show()
            Else
                Form_End.Show()
                Form_End.Lbl_Finish.Text = "Congratulation, you've succesfully installed GlossTech"
            End If

            Me.Close()
            End If
    End Sub

    Private Sub Rad_CustomFem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_CustomFem.CheckedChanged
        If Me.Rad_CustomFem.Checked = True Then
            temp1 = path & "/femalebody_1_s.dds"
            temp2 = path & "/femalehands_1_s.dds"
            temp3 = path & "/femalehead_s.dds"
            If Not File.Exists(temp1) And Not File.Exists(temp2) And Not File.Exists(temp3) Then
                Me.Rad_CustomFem.Checked = False
                Form_ErrorCustomMis.Show()
                Me.Group_Custom.Visible = False
                Me.Group_Head.Visible = False
                Me.Rad_HeadMesh.Checked = False
                Me.Btn_Next.Visible = False
                Me.Rad_UseFemMesh.Checked = False
                Me.Enabled = False
            Else
                Me.Group_Custom.Visible = True
                Me.Group_Head.Visible = True
                Me.Btn_Next.Visible = True
                Me.Rad_HeadMesh.Checked = True
                Me.Rad_UseFemMesh.Checked = True
            End If
        End If
    End Sub

    Private Sub Rad_CustomMan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_CustomMan.CheckedChanged
        If Me.Rad_CustomMan.Checked = True Then
            temp1 = path & "/malebody_1_s.dds"
            temp2 = path & "/malehands_1_s.dds"
            temp3 = path & "/malehead_s.dds"
            If Not File.Exists(temp1) And Not File.Exists(temp2) And Not File.Exists(temp3) Then
                Me.Rad_CustomMan.Checked = False
                Form_ErrorCustomMis.Show()
                Me.Group_Custom.Visible = False
                Me.Group_Head.Visible = False
                Me.Rad_HeadMesh.Checked = False
                Me.Btn_Next.Visible = False
                Me.Rad_UseMaleMesh.Checked = False
                Me.Enabled = False
            Else
                Me.Group_Custom.Visible = True
                Me.Group_Head.Visible = True
                Me.Btn_Next.Visible = True
                Me.Rad_HeadMesh.Checked = True
                Me.Rad_UseMaleMesh.Checked = True
            End If
        End If
    End Sub

    Private Sub Rad_CustomOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_CustomOther.CheckedChanged
        If Me.Rad_CustomOther.Checked = True Then
            Me.File_Custom.InitialDirectory = path
            Me.File_Custom.Filter = "DirectDrawSurface(*.dds)|*.dds"
            Me.File_Custom.Title = "Select the body _s file"
            Me.File_Custom.ShowDialog()

            Data.String_CustomBody = Me.File_Custom.FileName

            Me.File_Custom.Title = "Select the hands _s file"
            Me.File_Custom.ShowDialog()

            Data.String_CustomHands = Me.File_Custom.FileName

            Me.File_Custom.Title = "Select the head _s file"
            Me.File_Custom.ShowDialog()

            Data.String_CustomHead = Me.File_Custom.FileName

            Me.Group_Custom.Visible = True
            Me.Group_Head.Visible = True
            Me.Btn_Next.Visible = True
            Me.Rad_HeadMesh.Checked = True
            Me.Rad_UseCustomMesh.Checked = True
        End If
    End Sub

    Private Sub Rad_HeadAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_HeadAll.CheckedChanged

    End Sub

    Private Sub Rad_HeadMesh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_HeadMesh.CheckedChanged
        If Me.Rad_HeadMesh.Checked = True Then
            Me.Group_Mesh.Visible = True
        Else
            Me.Group_Mesh.Visible = False
        End If
    End Sub

    Private Sub Btn_OpenCustomMesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_OpenCustomMesh.Click
            System.Diagnostics.Process.Start("customhead_base.dds")
    End Sub

    Private Sub Rad_UseCustomMesh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_UseCustomMesh.CheckedChanged
        
    End Sub

    Private Sub File_Custom_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles File_Custom.FileOk

    End Sub

    Private Sub Dir_Custom_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dir_Custom.HelpRequest

    End Sub
End Class