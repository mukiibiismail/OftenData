Public Class frmAbout

    Private Sub frmAbout_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Anime(Me.Handle.ToInt32)
    End Sub

    Private Sub frmAbout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.lblremainigDays.Text = frmMain.lblsvcDate.Text
        'Me.lbllNo.Text = frmMain.lbllicencedto.Text
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub
End Class