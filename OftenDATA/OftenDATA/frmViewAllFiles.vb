Imports System.Data.OleDb

Public Class frmViewAllFiles

    Private Sub LoadFiles()
        Try
            sqL = "SELECT ID, FileName FROM Uploads"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1))

            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub SearchFiles()
        Try
            sqL = "SELECT ID, FileName FROM Uploads Where FileName LIKE '%" & TextBox1.Text & "%' "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            Do While dr.Read = True
                dgw.Rows.Add(dr(0), dr(1))

            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmViewAllFiles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadFiles()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        SearchFiles()
    End Sub

    Private Sub btnView_Click(sender As System.Object, e As System.EventArgs) Handles btnView.Click
        ViewFile()
    End Sub

    Private Sub ViewFile()
        Try

            Dim fileName As String = dgw.CurrentRow.Cells(1).Value
            With frmReadPdf
                .Show()
                .Focus()
                .AxAcroPDF1.src = Application.StartupPath & "\PDF_Files\" & fileName
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub dgw_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellDoubleClick
        Try
            ViewFile()
        Catch ex As Exception

        End Try
    End Sub
End Class