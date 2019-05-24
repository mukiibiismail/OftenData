Imports System.Data.OleDb
Public Class frmOwnerInfo
    Dim adding As Boolean
    Dim updating As Boolean
    Public search As Boolean

    Private Sub AddOwner()
        Try
            If txtCompanyName.Text = "" Or txtCompanyAddress.Text = "" Or txtCompanyPhoneNo.Text = "" Then
                MsgBox("Please Add the Company Name, Address and PhoneNo", MsgBoxStyle.Critical, "Add Company Profile")
                Exit Sub
            End If
            sqL = "INSERT INTO OwnerInfo(CompanyName, Address,PhoneNo,Email,Website,DealsIn,TIN,VAT) Values('" & txtCompanyName.Text & "', '" & txtCompanyAddress.Text & "', '" & txtCompanyPhoneNo.Text & "', '" & txtCompanyEmail.Text & "', '" & txtCompanyWebsite.Text & "', '" & txtdealersin.Text & "','" & txtTinNo.Text & "','" & txtVAT.Text & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Owner Added", MsgBoxStyle.Information, "Add Owner")
            Else
                MsgBox("Failed to add Owner", MsgBoxStyle.Critical, "Add Owner")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetOwnerInfo()
        Try
            sqL = "SELECT OwnerNo,CompanyName, Address,PhoneNo,Email,Website,DealsIn,TIN,VAT FROM OwnerInfo "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                txtOwnerNo.Text = dr(0)
                txtCompanyName.Text = dr(1)
                txtCompanyAddress.Text = dr(2)
                txtCompanyPhoneNo.Text = dr(3)
                txtCompanyEmail.Text = dr(4)
                txtCompanyWebsite.Text = dr(5)
                txtdealersin.Text = dr(6)
                txtTinNo.Text = dr(7)
                txtVAT.Text = dr(8)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub UpdateOwner()
        Try
            If txtCompanyName.Text = "" Or txtCompanyAddress.Text = "" Or txtCompanyPhoneNo.Text = "" Then
                MsgBox("Please Add the Company Name, Address and PhoneNo", MsgBoxStyle.Critical, "Update Company Profile")
                Exit Sub
            End If
            sqL = "Update OwnerInfo SET CompanyName ='" & txtCompanyName.Text & "', Address ='" & txtCompanyAddress.Text & "', PhoneNo = '" & txtCompanyPhoneNo.Text & "',Email = '" & txtCompanyEmail.Text & "',Website = '" & txtCompanyWebsite.Text & "',DealsIn= '" & txtdealersin.Text & "',TIN ='" & txtTinNo.Text & "'  WHERE OwnerNo = " & txtOwnerNo.Text & ""
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Owner Updated", MsgBoxStyle.Information, "Update Owner")
            Else
                MsgBox("Failed to update Owner", MsgBoxStyle.Critical, "Update Owner")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmOwnerInfo_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Anime(Me.Handle.ToInt32)
    End Sub
    Private Sub frmOwnerInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GetOwnerInfo()
        Me.txtOwnerNo.Enabled = False

        'Me.txtCompanyName.Text = frmMain.lbllicencedto.Text
        If txtCompanyName.Text <> "" Then
            Me.btnAdd.Enabled = False
            Me.btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.GetownerNo()
        txtCompanyName.Focus()
        txtOwnerNo.Enabled = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.AddOwner()
    End Sub

    Private Sub GetownerNo()
        Try
            sqL = "SELECT OwnerNo FROM OwnerInfo Order By OwnerNo Desc"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                txtOwnerNo.Text = dr(0)
            Else
                txtOwnerNo.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Me.UpdateOwner()
    End Sub
End Class