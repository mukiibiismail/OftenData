Public Class frmLookupData

 Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub

    Private Sub frmLookupData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetLookupDataID()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        AddLookupData()
        GetLookupDataID()
        Me.txtName.Clear()
    End Sub

   
End Class