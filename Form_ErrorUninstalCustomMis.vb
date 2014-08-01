Public Class Form_ErrorUninstalCustomMis

    Private Sub Lbl_Error_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Error.Click

    End Sub
    Private Sub Btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Exit.Click
        Form_UninstalCustom.Enabled = True
        Me.Close()
    End Sub
End Class