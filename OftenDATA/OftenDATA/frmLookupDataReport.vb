Public Class frmLookupDataReport

    Private Sub frmLookupDataReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadLookupDataReport()
    End Sub

   
    Private Sub btnUnhide_Click(sender As System.Object, e As System.EventArgs) Handles btnhide.Click
        If dgw.Rows.Count = 0 Then
            MsgBox("No Item to hiden", MsgBoxStyle.Exclamation, "hide Item")

            Exit Sub
        Else
            If MsgBox("Are you sure you want to delete this Item?", MsgBoxStyle.YesNo, "Delete Item") = MsgBoxResult.Yes Then
                deleteLookupDataItem()
                LoadLookupDataReport()
            Else
                Exit Sub
            End If
        End If
    End Sub

   
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        ExportToExcel(Me.dgw)
    End Sub
End Class