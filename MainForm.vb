Public Class MainForm
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub ListAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllToolStripMenuItem.Click
        'Create an instance of AllMembersForm
        Dim frmAllMembers As New AllMembersForm

        'Display the form
        frmAllMembers.ShowDialog()
    End Sub

    Private Sub AddNewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        ' Create an instance of AddMemberForm
        Dim frmAddMember As New AddMemberForm
        ' Display the form.
        frmAddMember.ShowDialog()
    End Sub

    Private Sub FindMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindMemberToolStripMenuItem.Click
        ' Create an instance of FindMemberForm
        Dim frmFindMember As New FindMemberForm

        ' Display the form.
        frmFindMember.ShowDialog()
    End Sub

    Private Sub AllMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllMembersToolStripMenuItem.Click
        ' Create an instance of AllPaymentsForm
        Dim frmPaymentsAll As New AllPaymentsForm
        ' Display the form.
        frmPaymentsAll.ShowDialog()
    End Sub

    Private Sub ListMembersByJoinDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListMembersByJoinDateToolStripMenuItem.Click
        ' Create an instance of KarateMemberDates
        Dim frmMemberDates As New KarateMemberDates
        ' Display the form.
        frmMemberDates.ShowDialog()
    End Sub

    Private Sub ModifyExistingPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyExistingPaymentsToolStripMenuItem.Click
        'Create an instance of ModifyExistingPayments
        Dim frmModifyPayments As New ModifyExistingPayments
        'Display the form.
        frmModifyPayments.ShowDialog()
    End Sub

    Private Sub PaymentsBySingleMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsBySingleMemberToolStripMenuItem.Click
        'Create an instance of ModifyingExistingPayments
        Dim frmPaymentsSingleMember As New MemberPaymentsForm
        'Display the form.
        frmPaymentsSingleMember.ShowDialog()
    End Sub
End Class