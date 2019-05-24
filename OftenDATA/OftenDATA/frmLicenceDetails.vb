Imports System.Data.OleDb

Public Class frmLicenceDetails

    Private Sub uploadLicence()
        Try
            Dim pcname As String = My.Computer.Name
            sqL = "UPDATE Licences SET ED = @ItemNo"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@ItemNo", txtFieldOne.Text)

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Licence Details uploaded successfully,Please Restart the System", MsgBoxStyle.Information, "Upload Licence")
                txtFieldOne.Clear()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmLicenceDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Me.txtlicencedto.Text = frmMain.lbllicencedto.Text
    End Sub

    Private Sub btnUpload_Click(sender As System.Object, e As System.EventArgs) Handles btnUpload.Click
        If MsgBox("Are you sure you want to change your License?", MsgBoxStyle.YesNo, "License Update") = MsgBoxResult.Yes Then
            uploadLicence()
        End If
    End Sub
End Class