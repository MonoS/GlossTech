Imports System.IO
Public Class Form_UninstalCustom
    Dim path As String
    Dim temp1 As String
    Dim temp2 As String
    Dim temp3 As String
    Dim temp4 As String
    Dim temp5 As String
    Dim temp6 As String
    Private Sub Form_UninstalCustom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dir_Custom.SelectedPath = AppDomain.CurrentDomain.BaseDirectory
        Me.Dir_Custom.Description = "Select the custom race texture folder"
        Me.Dir_Custom.ShowDialog()

        Me.path = Me.Dir_Custom.SelectedPath
    End Sub

    Private Sub Rad_CustomFem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_CustomFem.CheckedChanged
        If Me.Rad_CustomFem.Checked = True Then
            temp1 = path & "/femalebody_1_s.dds"
            temp2 = path & "/femalehands_1_s.dds"
            temp3 = path & "/femalehead_s.dds"
            If Not File.Exists(temp1) And Not File.Exists(temp2) And Not File.Exists(temp3) Then
                Me.Rad_CustomFem.Checked = False
                Form_ErrorUninstalCustomMis.Show()
                Me.Btn_Uninstall.Visible = False
                Me.Enabled = False
            Else
                Me.Btn_Uninstall.Visible = True
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
                Form_ErrorUninstalCustomMis.Show()
                Me.Btn_Uninstall.Visible = False
                Me.Enabled = False
            Else
                Me.Btn_Uninstall.Visible = True
            End If
        End If
    End Sub

    Private Sub Rad_CustomOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rad_CustomOther.CheckedChanged
        If Me.Rad_CustomOther.Checked = True Then
            Me.File_Custom.InitialDirectory = path
            Me.File_Custom.Filter = "DirectDrawSurface(*.dds)|*.dds"
            Me.File_Custom.Title = "Select the body _s file"
            Me.File_Custom.ShowDialog()

            temp1 = Me.File_Custom.FileName

            Me.File_Custom.Title = "Select the hands _s file"
            Me.File_Custom.ShowDialog()

            temp2 = Me.File_Custom.FileName

            Me.File_Custom.Title = "Select the head _s file"
            Me.File_Custom.ShowDialog()

            temp3 = Me.File_Custom.FileName

            Me.Btn_Uninstall.Visible = True
        End If
    End Sub

    Private Sub Btn_Uninstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Uninstall.Click
        temp4 = temp1 & ".gloss"
        temp5 = temp2 & ".gloss"
        temp6 = temp3 & ".gloss"

        If File.Exists(temp4) Then
            File.Delete(temp1)
            FileCopy(temp4, temp1)
            File.Delete(temp4)
        End If

        If File.Exists(temp5) Then
            File.Delete(temp2)
            FileCopy(temp5, temp2)
            File.Delete(temp5)
        End If

        If File.Exists(temp6) Then
            File.Delete(temp3)
            FileCopy(temp6, temp3)
            File.Delete(temp6)
        End If

        Form_End.Show()
        Form_End.Lbl_Finish.Text = "Congratulation, you've succesfully uninstalled GlossTech"
        Me.Close()
    End Sub
End Class