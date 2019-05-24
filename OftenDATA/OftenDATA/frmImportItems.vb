Imports System.Data.OleDb

Public Class frmImportItems

    Private Sub btnbrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnbrowse.Click
        Dim openFileDLG As New OpenFileDialog()

        Try
            Me.Cursor = Cursors.WaitCursor

            With openFileDLG

                Try
                    .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                Catch ex As Exception
                    Exit Try
                End Try

                .Filter = "Microsoft Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then Me.txtImportExisting.Text = .FileName.ToString()

            End With

        Catch ex As Exception
            Throw ex

        Finally
            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub SaveNewItem()
        Try


            For Each row As DataGridViewRow In dgw.Rows

                If CBool(Me.dgw.Item(Me.ColSaved.Name, row.Index).Value) = False Then

                    sqL = " INSERT INTO Item(ItemCode, iDescription, StocksOnHand,BatchNo, UnitPrice, ReproduceLevel,PurchasePrice,Category,ExpiryDate,Hidden,BarCode,ItemGroup,Units) VALUES(@ItemNo,@iDescription,@Quantity,@BatchNo,@UnitPrice,@ReproduceLevel,@UnitCost,@Category,@ExpiryDate,@Hidden,@BarCode, @ItemGroup,@UnitOfMeasure)"
                    ConnDB()
                    cmd = New OleDbCommand(sqL, conn)
                    cmd.Parameters.AddWithValue("@ItemNo", row.Cells("ColItemCode").Value)
                    cmd.Parameters.AddWithValue("@iDescription", row.Cells("ColDescription").Value)
                    cmd.Parameters.AddWithValue("@Quantity", row.Cells("ColItemQuantity").Value)
                    cmd.Parameters.AddWithValue("@BatchNo", row.Cells("ColBatchNo").Value)
                    cmd.Parameters.AddWithValue("@UnitPrice", row.Cells("ColUnitPrice").Value)
                    cmd.Parameters.AddWithValue("@ReproduceLevel", 0)
                    cmd.Parameters.AddWithValue("@UnitCost", row.Cells("ColPurchasePrice").Value)
                    cmd.Parameters.AddWithValue("@Category", "NA")
                    cmd.Parameters.AddWithValue("@ExpiryDate", row.Cells("ColExpiryDate").Value)
                    cmd.Parameters.AddWithValue("@Hidden", "NO")
                    cmd.Parameters.AddWithValue("@BarCode", "NO")
                    cmd.Parameters.AddWithValue("@ItemGroup", row.Cells("ColItemCategory").Value)
                    cmd.Parameters.AddWithValue("@UnitOfMeasure", row.Cells("ColUnitOfMeasure").Value)
                    cmd.ExecuteNonQuery()

                End If
            Next

            For rowNo As Integer = 0 To Me.dgw.RowCount - 1
                Me.dgw.Item(Me.ColSaved.Name, rowNo).Value = True
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnImport_Click(sender As System.Object, e As System.EventArgs) Handles btnImport.Click
        Try
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = txtImportExisting.Text
            Dim sheet As String = txtsheet.Text + "$"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")

            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select ItemNo,ItemName,UnitCost,UnitPrice,BatchNo,Quantity,UnitOfMeasure,ItemGroup,ExpiryDate from [" & sheet & "] ", MyConnection)
            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            dgw.DataSource = dataSet.Tables(0)
            Me.ImportedRows.ForeColor = Color.Red
            Me.ImportedRows.Text = dgw.RowCount.ToString + " Rows Successfully Imported,Please Save them !"
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            dgw.Rows.Clear()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            SaveNewItem()

        Catch ex As Exception

        End Try
    End Sub


  
End Class