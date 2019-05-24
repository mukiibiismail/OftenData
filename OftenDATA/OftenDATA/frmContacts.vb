Imports System.Data.OleDb

Public Class frmContacts

    Private Sub LoadSuppliers()
        Try
            sqL = "SELECT SupplierNo,SupplierNames, ContactNo,SupplierDetails FROM Suppliers Order By SupplierNames"
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

    Private Sub LoadCustomer()
        Try
            sqL = "SELECT CustomerNo, CustName, Address FROM Customer Order By CustName"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            Do While dr.Read = True
                dgvCustomers.Rows.Add(dr(0), dr(1), dr(2))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Private Sub frmContacts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.LoadCustomer()
        Me.LoadSuppliers()
    End Sub


    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class