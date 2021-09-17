Public Class MemberPaymentsForm
    Private Sub MemberPaymentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This loads data into the Karate Payments DataSet.Payments Table
        Me.PaymentsTableAdapter.Fill(Me.KaratePaymentsDataSet.Payments, CDate(lbMembers.SelectedValue))

        'This loads data into the Karate Members dataSet.Members table
        Me.MembersTableAdapter.Fill(Me.AllMembersDataSet.Members)

    End Sub

    Private Sub lbMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMembers.SelectedIndexChanged
        Me.PaymentsTableAdapter.Fill(Me.KaratePaymentsDataSet.Payments, CDate(lbMembers.SelectedValue))
    End Sub
End Class