
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class frmLogin
    Public LoginUserName As String
    Public LoginStaffNo As String

    Private Sub Login()
        Try
            Dim encryptMD5 As New MD5CryptoServiceProvider()
            Dim encryptedText As Byte()
            Dim encoder As New UTF8Encoding()
            Dim convertedPass As String
            encryptedText = encryptMD5.ComputeHash(encoder.GetBytes(txtPwd.Text))
            convertedPass = Convert.ToBase64String(encryptedText)
            sqL = "SELECT * FROM Users WHERE Username = '" & txtUser.Text & "' AND pwd = '" & convertedPass & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                LoginUserName = txtUser.Text
                LoginStaffNo = dr("StaffID")
                Anime(Me.Handle.ToInt32)
                Me.Close()


            ElseIf dr.Read = False Then
                MsgBox("Incorrect username or password!, Please check the Credentials", MsgBoxStyle.Critical, "Login")
                txtPwd.Focus()
            End If

        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Me.Login()


    End Sub

    Private Sub txtUser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.GotFocus
        AcceptButton = btnLogin
    End Sub


    Private Sub txtPwd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPwd.GotFocus
        AcceptButton = btnLogin
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Close Window") = MsgBoxResult.Yes Then
            Anime(Me.Handle.ToInt32)
            End
        End If
        txtUser.Focus()
    End Sub



    Private Sub lblLicence_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLicence.LinkClicked
        frmLicenceDetails.ShowDialog()
    End Sub



    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'If CInt(lblsvcDate.Text) <= 15 Then
        '    lblLicence.Visible = True
        'End If
        'txtUser.Text = My.Settings.LoginUserName
        'txtPwd.Text = My.Settings.LoginPass
        'If txtUser.Text <> "" Then
        '    chkRemember.Checked = True
        'End If


    End Sub
End Class

