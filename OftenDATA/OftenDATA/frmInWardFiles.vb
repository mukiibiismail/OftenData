Imports System.Data.OleDb
Public Class frmInWardFiles

    Private Sub frmInWardFiles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadUnAvailabeFileName(cboAvailableFiles)
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            Dim one As Integer = 1

            If txtGivenTo.Text = "" Or cboAvailableFiles.Text = "" Or txtNotes.Text = "" Then
                MsgBox("Please fill the fields", MsgBoxStyle.Information, "Out Ward Files")
            Else

                sqL = "UPDATE FileMovement SET ReturnedBy ='" & txtGivenTo.Text & "',InWardDate ='" & Format(Date.Now, "Short Date") & "',DetailsIn ='" & txtNotes.Text & "',ReturnedFile = val('" & one & "') Where FileID = val('" & cboAvailableFiles.SelectedValue & "') "
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                cmd.ExecuteNonQuery()
                MarkItemUnAvailable()
                MsgBox("InWard File Recorded Successfully", MsgBoxStyle.Information, "InWard Files")
                clearcontrols()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub MarkItemUnAvailable()
        Try
            If txtGivenTo.Text = "" Or cboAvailableFiles.Text = "" Or txtNotes.Text = "" Then
                MsgBox("Please fill the fields", MsgBoxStyle.Information, "Out Ward Files")
            Else
                sqL = "UPDATE Files SET FileStatus ='Available' Where ID = val('" & cboAvailableFiles.SelectedValue & "') "
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                cmd.ExecuteNonQuery()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub clearcontrols()
        txtGivenTo.Clear()
        txtNotes.Clear()

    End Sub

End Class