﻿
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class frmUsers
    Dim adding As Boolean
    Public uSearch As Boolean

    Private Sub AddUser()
        Try
            Dim encryptMD5 As New MD5CryptoServiceProvider()
            Dim encryptedText As Byte()
            Dim encoder As New UTF8Encoding()
            Dim convertedPass As String
            encryptedText = encryptMD5.ComputeHash(encoder.GetBytes(txtCpwd.Text))
            convertedPass = Convert.ToBase64String(encryptedText)



            sqL = "SELECT StaffID FROM USERS WHERE StaffID = val('" & txtStaffID.Text & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                MessageBox.Show("User Already Exists Please Use a different User, Or Register A New Staff", "OftenSales", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                sqL = "INSERT INTO USERS VALUES('" & txtUser.Text & "','" & convertedPass & "','" & cmbRole.Text & "', '" & txtStaffID.Text & "')"
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("User Added Successfully", MsgBoxStyle.Information, "Add User")
                Else
                    MsgBox("Failed in Adding User", MsgBoxStyle.Exclamation, "Add User")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub DeleteUser()
        Try
            sqL = "DELETE FROM USERS Where username = '" & ListBox1.SelectedItem & "'"
            ConnDB()
            cmd = New OledbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("User Deleted", MsgBoxStyle.Information, "Delete User")
            Else
                MsgBox("Failed in Deleting User")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Loadusers()
        Try
            sqL = "SELECT username from Users order by username"
            ConnDB()
            cmd = New OledbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            ListBox1.Items.Clear()
            Do While dr.Read = True
                ListBox1.Items.Add(dr(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub getusername()
        Try
            sqL = "SELECT username FROM Users  WHERE StaffID = " & frmLogin.LoginStaffNo & " "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                Me.lblcurrentUser.Text = dr("username")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If ListBox1.SelectedItem = "" Then
            MsgBox("Please select username to delete", MsgBoxStyle.Exclamation, "Delete user")
        ElseIf lblcurrentUser.Text = ListBox1.SelectedItem
            MsgBox("The system Can't delete currently logged in user!", MsgBoxStyle.Exclamation, "Delete user")
        Else
            If MsgBox("Are you sure you want delete user?", MsgBoxStyle.YesNo, "Delete User") = MsgBoxResult.Yes Then
                DeleteUser()
                Loadusers()
            Else
                Exit Sub
            End If

           
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtUser.Enabled = True
        txtCpwd.Enabled = True
        txtpwd.Enabled = True
        txtStaffID.Enabled = True
        cmbRole.Enabled = True
        adding = True
        txtUser.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtPwd.Text <> txtCpwd.Text Then
            MsgBox("Password Not Match", MsgBoxStyle.Exclamation, "Add user")
            txtPwd.SelectAll()
            txtCpwd.SelectAll()
            txtPwd.Focus()
            Exit Sub

        End If
        If adding = True Then
            AddUser()
            Loadusers()
            txtUser.Enabled = False
            txtCpwd.Enabled = False
            txtPwd.Enabled = False
            txtStaffID.Enabled = False
            cmbRole.Enabled = False
            txtCpwd.Text = ""
            txtPwd.Text = ""
            txtUser.Text = ""
            txtStaffID.Text = ""
            cmbRole.Text = ""
            adding = False
        Else
            MsgBox("Nothing to Save: Click [Add Button] to Add User", MsgBoxStyle.Information, "Add User")
        End If
        
        
    End Sub

    Private Sub frmUsers_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Anime(Me.Handle.ToInt32)
    End Sub

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Enabled = False
        txtCpwd.Enabled = False
        txtpwd.Enabled = False
        txtStaffID.Enabled = False
        cmbRole.Enabled = False
        txtCpwd.Text = ""
        txtPwd.Text = ""
        txtUser.Text = ""
        txtStaffID.Text = ""
        cmbRole.Text = ""
        Me.Loadusers()
        Me.getusername()

        LoadLookupData(Me.cmbRole, "Staff Positions")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        uSearch = True
        frmLoadStaff.ShowDialog()
    End Sub
End Class