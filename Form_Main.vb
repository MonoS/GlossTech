Imports System.IO
Public Class Form_Main

    Private Sub Btn_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Start.Click
        Data.Bool_Custom = False

        If Me.Rad_Install.Checked = False And Me.Rad_InstCust.Checked = False And Me.Rad_Uninstall.Checked = False And Me.Rad_UninstCust.Checked = False Then
            Form_ErrorMain.Show()
            Me.Enabled = False
        Else
            If Rad_Install.Checked = True Then
                Form_FemaleGloss.Show()
            End If

            If Rad_InstCust.Checked = True Then
                Data.Bool_Custom = True
                Form_CustomGloss.Show()
            End If

            If Rad_Uninstall.Checked = True Then
                Form_Uninstall.Show()
            End If

            If Rad_UninstCust.Checked = True Then
                Form_UninstalCustom.Show()
            End If

            Me.Close()

        End If

    End Sub

    Private Sub Check_Uninstall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Uninstall.CheckedChanged
        If Me.Check_Uninstall.Checked = True Then
            Me.Rad_Install.Checked = False
            Me.Rad_InstCust.Checked = False
            Me.Rad_Install.Visible = False
            Me.Rad_InstCust.Visible = False
            Me.Rad_Uninstall.Visible = True
            Me.Rad_UninstCust.Visible = True
        Else
            Me.Rad_Uninstall.Checked = False
            Me.Rad_UninstCust.Checked = False
            Me.Rad_UninstCust.Visible = False
            Me.Rad_Uninstall.Visible = False
            Me.Rad_Install.Visible = True
            Me.Rad_InstCust.Visible = True
        End If
    End Sub

    Private Sub Form_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists("femalehead_base.dds") Or Not File.Exists("malehead_base.dds") Or Not File.Exists("TexBlend/TexBlend.exe") Or Not File.Exists("customhead_base.dds") Then
            Form_ErrorMisFile.Show()
            Me.Close()
        End If
    End Sub
End Class
