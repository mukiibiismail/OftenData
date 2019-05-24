Imports System.Data.OleDb

Public Class frmLoadAllItems

    Private Sub LoadItem()
        Try
            sqL = "SELECT TOP 50 ID,FileNo, FileName,FileCatgeory FROM Files WHERE Hidden =0 Order By FileName"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Search()
        Try
            sqL = "SELECT ID,FileNo, FileName,FileCatgeory FROM Files WHERE Hidden =0 AND FileName LIKE '%" & TextBox1.Text & "%' Order By FileName"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Search()
    End Sub

    Private Sub dgw_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellDoubleClick
        If frmItem.search = True Then
            frmItem.txtFileID.Text = dgw.CurrentRow.Cells(0).Value
            frmItem.search = False
            Me.Close()
        End If

    End Sub

    Private Sub frmLoadAllItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadItem()
    End Sub
End Class