Public Class FindMemberForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        ' Perform a wildcard search for last name.
        Me.MembersTableAdapter.Fill(Me.FindMemberDataSet.Members,
                                txtLastName.Text)
    End Sub


End Class