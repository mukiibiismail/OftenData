Imports System.Data.OleDb
Public Class frmLicence
    Private Sub uploadLicence()
        Try
            Dim pcname As String = My.Computer.Name
            sqL = "INSERT INTO Licences(LicenceNo, DateAdded,TimeAdded,ComputerName) Values('" & txtlicence.Text & "', '" & Format(Date.Now, "Short Date") & "', '" & Format(Date.Now, "Long Time") & "', '" & pcname & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Licence uploaded successfully", MsgBoxStyle.Information, "Upload Licence")
                txtlicence.Text = ""

            Else
                MsgBox("Failed to uploaded the licence", MsgBoxStyle.Critical, "Upload Licence")
                txtlicence.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnKey_Click(sender As System.Object, e As System.EventArgs) Handles btnKey.Click
        Me.uploadLicence()
    End Sub

    Private Sub frmLicence_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'If frmMain.lbllic.Text = "lic" Then
        '    lblLicenseStatus.Text = "Unlicenced Copy"
        '    txtlicence.Enabled = True
        'Else
        '    lblLicenseStatus.Text = frmMain.lbllicencedto.Text
        '    txtlicence.Enabled = False
        '    btnKey.Enabled = False
        'End If
    End Sub
End Class