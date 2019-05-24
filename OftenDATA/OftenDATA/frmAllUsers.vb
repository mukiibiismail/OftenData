Public Class frmAllUsers

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        ExportToExcel(dgw)
    End Sub

    Private Sub frmAllUsers_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Anime(Me.Handle.ToInt32)
    End Sub

    Private Sub frmAllUsers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'LoadAllUsers()
    End Sub
End Class