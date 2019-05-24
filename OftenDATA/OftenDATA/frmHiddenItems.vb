Imports System.Data.OleDb
Public Class frmHiddenItems
    Private Sub LoadItem()
        Try
            sqL = "SELECT ItemNo, itemCode, iDescription ,StocksOnHand,Category FROM Item WHERE Hidden ='Yes' Order By iDescription"
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

    Private Sub SearchHiddenItems()
        Try
            sqL = "SELECT ItemNo, itemCode, iDescription ,StocksOnHand,Category FROM Item WHERE Hidden ='Yes' AND iDescription LIKE '" & txthiddenItems.Text & "%' Order By iDescription"
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


    Private Sub unhide()
        Try
            sqL = "UPDATE Item SET Hidden ='No' WHERE itemNo = " & dgw.CurrentRow.Cells(0).Value & ""
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Item has been unhidden", MsgBoxStyle.Information, "Unhide Item")
                Me.LoadItem()
            Else
                MsgBox("Failed to unhide item", MsgBoxStyle.Critical, "Unhide Item")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()

        End Try
    End Sub


    Private Sub frmHiddenItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.LoadItem()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportToExcel(Me.dgw)
    End Sub

    Private Sub txthiddenItems_TextChanged(sender As Object, e As EventArgs) Handles txthiddenItems.TextChanged
        Me.SearchHiddenItems()
    End Sub

    Private Sub btnUnhide_Click(sender As Object, e As EventArgs) Handles btnUnhide.Click
        If dgw.Rows.Count = 0 Then
            MsgBox("No Item to Unhide", MsgBoxStyle.Exclamation, "Unhide Item")
            txthiddenItems.Focus()
            Exit Sub
        Else
            If MsgBox("Are you sure you want to unhide this Item?", MsgBoxStyle.YesNo, "Unhide Item") = MsgBoxResult.Yes Then
                Me.unhide()
                txthiddenItems.Focus()
            Else
                Exit Sub
            End If
        End If
    End Sub
End Class