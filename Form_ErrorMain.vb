Public Class Form_ErrorMain

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Error.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form_Main.Enabled = True
        Me.Close()
    End Sub
End Class