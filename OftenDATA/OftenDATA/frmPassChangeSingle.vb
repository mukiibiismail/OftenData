Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Public Class frmPassChangeSingle

    Private Sub updateuserpassword()
        Try
            Dim encryptMD5 As New MD5CryptoServiceProvider()
            Dim encryptedText As Byte()
            Dim encoder As New UTF8Encoding()
            Dim convertedPass As String
            encryptedText = encryptMD5.ComputeHash(encoder.GetBytes(txtCpwd.Text))
            convertedPass = Convert.ToBase64String(encryptedText)
            If txtCpwd.Text <> txtpwd.Text Then
                MsgBox("Your passwords don't match", MsgBoxStyle.Exclamation, "Password Update")

            Else
                sqL = "UPDATE Users SET pwd = '" & convertedPass & "' WHERE StaffID = val('" & (lblUser.Text) & "') "
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password Updated Successfully", MsgBoxStyle.Information, "Password Update")
                Else
                    MsgBox("Failed to update Password", MsgBoxStyle.Exclamation, "Password Update")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmPassChangeSingle_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Anime(Me.Handle.ToInt32)
    End Sub

    Private Sub frmPassChangeSingle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblUser.Text = frmLogin.LoginStaffNo
    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub


    Private Sub btnchangepass_Click(sender As System.Object, e As System.EventArgs) Handles btnchangepass.Click
        Me.updateuserpassword()
    End Sub
End Class