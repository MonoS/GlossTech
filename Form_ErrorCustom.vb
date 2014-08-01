Public Class Form_ErrorCustom

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Error.Click

    End Sub

    Private Sub Btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ok.Click
        Form_CustomGloss.Enabled = True
        Me.Close()
    End Sub
End Class