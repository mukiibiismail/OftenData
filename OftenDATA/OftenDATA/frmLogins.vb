Imports System.Data.OleDb
Public Class frmLogins

    Private Sub frmLogins_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'LoadUserNames(cboSoldby)
        dtpTo.MaxDate = Today
        dtpFrom.MaxDate = Today
    End Sub


    Private Sub Loadlogins()
        If cboSoldby.Text = "" Then
            sqL = "SELECT username,exactdate,exacttime,computername,state FROM loginlogs WHERE exactdate >= CDate('" & dtpFrom.Text & "') AND exactdate <=CDate('" & dtpTo.Text & "')  Order by ID desc"

        Else
            sqL = "SELECT username,exactdate,exacttime,computername,state FROM loginlogs WHERE username ='" & cboSoldby.Text & "' AND  exactdate >= CDate('" & dtpFrom.Text & "') AND exactdate <=CDate('" & dtpTo.Text & "')  Order by ID desc"

        End If
        Try
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))

            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

  
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Loadlogins()
    End Sub

    Private Sub btnExportToExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportToExcel.Click
        ExportToExcel(Me.dgw)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub
End Class