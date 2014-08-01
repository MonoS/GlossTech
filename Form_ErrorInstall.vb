Public Class Form_ErrorInstall

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Female.Click
        Form_FemaleGloss.Show()
        Me.Close()

    End Sub

    Private Sub Btn_man_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_man.Click
        Form_ManGloss.Show()
        Me.Close()

    End Sub

    Private Sub Btn_main_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_main.Click
        Form_Main.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub
End Class