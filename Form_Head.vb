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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_OpenMesh.Click
        System.Diagnostics.Process.Start("head_base.dds")
    End Sub

    Private Sub Lbl_ExpOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_ExpOpen.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Data.Bool_HeadAll = Me.Rad_HeadAll.Checked
        Data.Bool_HeadMesh = Me.Rad_HeadMesh.Checked
        Form_Glossing.show()
        Me.Close()
    End Sub
End Class