Public Class KarateMemberDates
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Close()
    End Sub

    Private Sub KarateMemberDates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateJoinDateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter1.Fill(Me.KarateJoinDateDataSet.Members)
        dtpMemberDate.Value = Today()

    End Sub

    Private Sub rdBtnBeforeDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdBtnBeforeDate.CheckedChanged
        Me.MembersTableAdapter1.FillBeforeDate(Me.KarateJoinDateDataSet.Members, dtpMemberDate.Value)

    End Sub

    Private Sub rdBtnAfterDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdBtnAfterDate.CheckedChanged
        Me.MembersTableAdapter1.FillAfterDate(Me.KarateJoinDateDataSet.Members, dtpMemberDate.Value)
    End Sub

End Class