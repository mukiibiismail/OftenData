Imports System.Data.OleDb

Public Class frmOutWardFiles

    Private Sub frmOutWardFiles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadAvailabeFileName(cboAvailableFiles)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If txtGivenTo.Text = "" Or cboAvailableFiles.Text = "" Or txtNotes.Text = "" Then
                MsgBox("Please fill the fields", MsgBoxStyle.Information, "Out Ward Files")
            Else
                sqL = "INSERT INTO FileMovement(FileID,FileName,OutWardDate,ExpectedDate,BorrowedBy,RecordDate, RecordedBy,DetailsOut) Values(@FileID,@FileName,@OutWardDate,@ExpectedDate,@BorrowedBy,@RecordDate, @RecordedBy,@DetailsOut)"
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                cmd.Parameters.AddWithValue("@FileID", cboAvailableFiles.SelectedValue)
                cmd.Parameters.AddWithValue("@FileName", cboAvailableFiles.Text)
                cmd.Parameters.AddWithValue("@OutWardDate", Format(Date.Now, "Short Date"))
                cmd.Parameters.AddWithValue("@ExpectedDate", Format(dtpExpectedDate.Text, "Short Date"))
                cmd.Parameters.AddWithValue("@BorrowedBy", txtGivenTo.Text)
                cmd.Parameters.AddWithValue("@RecordDate", Format(Date.Now, "Short Date"))
                cmd.Parameters.AddWithValue("@RecordedBy", currentUser)
                cmd.Parameters.AddWithValue("@DetailsOut", txtNotes.Text)
                cmd.ExecuteNonQuery()
                MarkItemUnAvailable()
                MsgBox("OutWard File Recorded Successfully", MsgBoxStyle.Information, "OutFiles")
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
                sqL = "UPDATE Files SET FileStatus ='Borrowed' Where ID = val('" & cboAvailableFiles.SelectedValue & "') "
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

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clearcontrols()
        txtGivenTo.Clear()
        txtNotes.Clear()

    End Sub
End Class