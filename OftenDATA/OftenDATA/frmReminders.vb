Public Class frmReminders

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If txtDetails.Text = "" Or txtReminder.Text = "" Then
            MessageBox.Show("Please enter all the details")
        Else
            AddReminders()
            txtReminder.Clear()
            txtDetails.Clear()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub

    Private Sub frmReminders_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Anime(Me.Handle.ToInt32)
    End Sub
End Class