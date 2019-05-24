Imports System.Data.OleDb

Public Class frmFileUpload

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.Filter = "PDF | *.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                TextBox1.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Timer1.Start()
    End Sub

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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try

            ProgressBar1.Value += 1
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                sqL = "INSERT INTO Uploads(FileName) Values('" & System.IO.Path.GetFileName(TextBox1.Text) & "')"
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)

                cmd.ExecuteNonQuery()
                If TextBox1.Text <> "" Then
                    System.IO.File.Copy(TextBox1.Text, Application.StartupPath & "\PDF_Files\" & System.IO.Path.GetFileName(TextBox1.Text), True)
                End If
                MsgBox("Scanned file uploaded successfully.")


                TextBox1.Clear()
                ProgressBar1.Value = 0
                LoadFiles()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()

        End Try

        Call Form1_Load(sender, e)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFiles()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
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

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
