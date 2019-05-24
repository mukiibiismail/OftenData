Public Class frmReportReminders

   
    Private Sub btnUnhide_Click(sender As System.Object, e As System.EventArgs) Handles btnUnhide.Click
        If dgw.Rows.Count = 0 Then
            MsgBox("No Reminder selected to Mark Done", MsgBoxStyle.Exclamation, "Mark Reminders")

            Exit Sub
        Else
            If MsgBox("Are you sure you want to mark this Reminder Done?", MsgBoxStyle.YesNo, "Mark Reminders") = MsgBoxResult.Yes Then
                MarkRemindersDone()
                LoadRemindersReport()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub frmReportReminders_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Anime(Me.Handle.ToInt32)
    End Sub

    Private Sub frmReportReminders_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadRemindersReport()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        ExportToExcel(Me.dgw)
    End Sub
End Class