Imports System.IO
Public Class Form_Head
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_ExpTrasparency.Click

    End Sub

    Private Sub Group_Mesh_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Group_Mesh.Enter

    End Sub

    Private Sub Rad_HeadMesh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_HeadMesh.CheckedChanged
        If Me.Rad_HeadMesh.Checked = True Then
            Me.Group_Mesh.Visible = True
        Else
            Me.Group_Mesh.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_OpenFemMesh.Click
        System.Diagnostics.Process.Start("femalehead_base.dds")
    End Sub

    Private Sub Lbl_ExpOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_ExpOpen.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Dim gloss_fem As Byte
        Dim gloss_man As Byte
        Dim i As Integer
        Data.Bool_HeadAll = Me.Rad_HeadAll.Checked
        Data.Bool_HeadMesh = Me.Rad_HeadMesh.Checked

        REM Female glossing
        If Data.Bool_FemaleGloss = True Then

            'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Glossing female body" & vbNewLine

            REM backup of femalebody_1_s.dds
            If File.Exists("textures/actors/character/female/femalebody_1_s.dds") Then
                If Not File.Exists("textures/actors/character/female/femalebody_1_s.dds.gloss") Then
                    File.Copy("textures/actors/character/female/femalebody_1_s.dds", "textures/actors/character/female/femalebody_1_s.dds.gloss")
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of femalebody_1_s.dds created" & vbNewLine
                    File.Delete("textures/actors/character/female/femalebody_1_s.dds")
                Else
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of femalebody_1_s.dds already exists" & vbNewLine
                End If
            Else
                'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Cannot create backup of femalebody_1_s.dds, file not found" & vbNewLine
            End If

            REM backup of femalehands_1_s.dds
            If File.Exists("textures/actors/character/female/femalehands_1_s.dds") Then
                If Not File.Exists("textures/actors/character/female/femalehands_1_s.dds.gloss") Then
                    File.Copy("textures/actors/character/female/femalehands_1_s.dds", "textures/actors/character/female/femalehands_1_s.dds.gloss")
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of femalehands_1_s.dds created" & vbNewLine
                Else
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of femalehands_1_s.dds already exists" & vbNewLine
                End If
            Else
                'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Cannot create backup of femalehands_1_s.dds, file not found" & vbNewLine
            End If

            REM backup of femalehead_s.dds
            If File.Exists("textures/actors/character/female/femalehead_s.dds") Then
                If Not File.Exists("textures/actors/character/female/femalehead_s.dds.gloss") Then
                    File.Copy("textures/actors/character/female/femalehead_s.dds", "textures/actors/character/female/femalehead_s.dds.gloss")
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of femalehead_s.dds created" & vbNewLine
                Else
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of femalehead_s.dds already exists" & vbNewLine
                End If
            Else
                'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Cannot create backup of femalehead_s.dds, file not found" & vbNewLine
            End If

            gloss_fem = Data.Value_FemaleGloss * 255 / 100

            FileOpen(1, "textures/actors/character/female/femalebody_1_s.dds", OpenMode.Binary, OpenAccess.Write)


            i = 0
            Do While i < 128
                FilePut(1, Data.header_body(i), )
                i = i + 1
            Loop

            i = 0
            Do While i < 192
                FilePut(1, gloss_fem, )
                i = i + 1
            Loop

            FileClose(1)

            FileCopy("textures/actors/character/female/femalebody_1_s.dds", "textures/actors/character/female/femalehands_1_s.dds")
            If Data.Bool_HeadAll = True Then
                File.Delete("textures/actors/character/female/femalehead_s.dds")
                FileCopy("textures/actors/character/female/femalebody_1_s.dds", "textures/actors/character/female/femalehead_s.dds")
            End If

            If Data.Bool_HeadMesh = True Then
                'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Creating head mesh" & vbNewLine

                Data.Do_Head_Mesh(1, gloss_fem)

            End If
        Else
            'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Skipping female gloss" & vbNewLine
        End If

        REM Man glossing
        If Data.Bool_ManGloss = True Then

            'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Glossing man body" & vbNewLine

            REM backup of malebody_1_s.dds
            If File.Exists("textures/actors/character/male/malebody_1_s.dds") Then
                If Not File.Exists("textures/actors/character/male/malebody_1_s.dds.gloss") Then
                    File.Copy("textures/actors/character/male/malebody_1_s.dds", "textures/actors/character/male/malebody_1_s.dds.gloss")
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "backup of malebody_1_s.dds created" & vbNewLine
                    File.Delete("textures/actors/character/male/malebody_1_s.dds")
                Else
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of malebody_1_s.dds already exists" & vbNewLine
                End If
            Else
                'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Cannot create backup of malebody_1_s.dds, file not found" & vbNewLine
            End If

            REM backup of malehands_1_s.dds
            If File.Exists("textures/actors/character/male/malehands_1_s.dds") Then
                If Not File.Exists("textures/actors/character/male/malehands_1_s.dds.gloss") Then
                    File.Copy("textures/actors/character/male/malehands_1_s.dds", "textures/actors/character/male/malehands_1_s.dds.gloss")
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "backup of malehands_1_s.dds created" & vbNewLine
                Else
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of malehands_1_s.dds already exists" & vbNewLine
                End If
            Else
                'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Cannot create backup of malehands_1_s.dds, file not found" & vbNewLine
            End If

            REM backup of malehead_s.dds
            If File.Exists("textures/actors/character/male/malehead_s.dds") Then
                If Not File.Exists("textures/actors/character/male/malehead_s.dds.gloss") Then
                    File.Copy("textures/actors/character/male/malehead_s.dds", "textures/actors/character/male/malehead_s.dds.gloss")
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "backup of malehead_s.dds created" & vbNewLine
                Else
                    'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Backup of malehead_s.dds already exists" & vbNewLine
                End If
            Else
                'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Cannot create backup of malebodyhead_s.dds, file not found" & vbNewLine
            End If

            gloss_man = Data.Value_ManGloss * 255 / 100

            FileOpen(1, "textures/actors/character/male/malebody_1_s.dds", OpenMode.Binary, OpenAccess.Write)

            i = 0
            Do While i < 128
                FilePut(1, Data.header_body(i), )
                i = i + 1
            Loop

            i = 0
            Do While i < 192
                FilePut(1, gloss_man)
                i = i + 1
            Loop

            FileClose(1)

            FileCopy("textures/actors/character/male/malebody_1_s.dds", "textures/actors/character/male/malehands_1_s.dds")
            If Data.Bool_HeadAll = True Then
                File.Delete("textures/actors/character/male/malehead_s.dds")
                FileCopy("textures/actors/character/male/malebody_1_s.dds", "textures/actors/character/male/malehead_s.dds")
            End If

            If Data.Bool_HeadMesh = True Then
                'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Creating head mesh" & vbNewLine

                Data.Do_Head_Mesh(2, gloss_man)

            End If

        Else
            'Me.Lbl_Progress.Text = Me.Lbl_Progress.Text & "Skipping man gloss" & vbNewLine
        End If

        If Data.Bool_HeadMesh = True Then
            Form_TexBlend.Show()
        Else
            Form_End.Show()
            Form_End.Lbl_Finish.Text = "Congratulation, you've succesfully installed GlossTech"
        End If

        Me.Close()
    End Sub

    Private Sub Btn_OpenManMesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_OpenManMesh.Click
        System.Diagnostics.Process.Start("malehead_base.dds")
    End Sub

    Private Sub Rad_HeadAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_HeadAll.CheckedChanged

    End Sub

    Private Sub Form_Head_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class