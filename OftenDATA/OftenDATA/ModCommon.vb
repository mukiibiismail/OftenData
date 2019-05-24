Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Net
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel


Module ModCommon
    Dim _cipherEngine As New Cypher
    Public lastsaleDate As Date
    Public currentUser As String
    Public rightAssets As Boolean = False
    Public rightBanking As Boolean = False
    Public rightAccounting As Boolean = False
    Public rightReminders As Boolean = False
    Public rightSuppliers As Boolean = False
    Public rightViewProfits As Boolean = False
    Public rightInvoices As Boolean = False
    Private todaysDate As Date = Date.Now.ToString("MMM dd, yyyy")



#Region "CRUD"

#Region "LookupData"

    Friend Sub GetLookupDataID()
        Try
            sqL = "SELECT LookupDataID FROM LookupData Order By LookupDataID Desc"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                frmLookupData.txtItemCode.Text = dr(0) + 1
            Else
                frmLookupData.txtItemCode.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub



    Public Sub GetCustomerAccountBalance(ByVal customerNo As String, ByVal x As Control)
        Try
            sqL = "SELECT IIF(SUM(Amount) IS NULL,0,SUM(Amount)) FROM Accounts Where CustomerNo = val('" & customerNo & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                x.Text = Format(dr(0), "#,##0.00")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Function GetInvoiceBalance(ByVal invoiceNo As String) As Decimal
        Try
            Dim Amount As Decimal

            sqL = "SELECT IIF(SUM(Amount) IS NULL,0,SUM(Amount)) FROM Accounts Where InvoiceNo = val('" & invoiceNo & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                Amount = dr(0)
            End If

            Return Amount

        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Friend Sub AddLookupData()
        Try
            sqL = "INSERT INTO LookupData(ItemCategory, ItemName,RecordDate) Values('" & frmLookupData.cboItemCategory.Text & "', '" & frmLookupData.txtName.Text & "','" & Format(Date.Now, "Short Date") & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("LookupData Object Added", MsgBoxStyle.Information, "Add LookupData Object")
            Else
                MsgBox("Failed to add LookupData Object", MsgBoxStyle.Critical, "Add LookupData Object")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    
    Friend Sub LoadLookupData(ByVal ComboName As ComboBox, ByVal Category As String)
        Try
            Dim strSQL As String = "SELECT ItemName FROM LookupData where ItemCategory = ('" & Category & "')"
            Dim da As New OleDbDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "LookupData")

            With ComboName
                .DataSource = ds.Tables("LookupData")
                .DisplayMember = "ItemName"
                .ValueMember = "ItemName"
                .SelectedIndex = -1
            End With
        Catch ex As Exception
        End Try
    End Sub


    Friend Sub LoadAvailabeFileName(ByVal ComboName As ComboBox)
        Try
            Dim strSQL As String = "SELECT ID,FileName FROM Files where FileStatus = 'Available' And Hidden =0 "
            Dim da As New OleDbDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "Files")

            With ComboName
                .DataSource = ds.Tables("Files")
                .DisplayMember = "FileName"
                .ValueMember = "ID"
                .SelectedIndex = -1
            End With
        Catch ex As Exception
        End Try
    End Sub

    Friend Sub LoadUnAvailabeFileName(ByVal ComboName As ComboBox)
        Try
            Dim strSQL As String = "SELECT ID,FileName FROM Files where FileStatus = 'Borrowed' And Hidden =0 "
            Dim da As New OleDbDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "Files")

            With ComboName
                .DataSource = ds.Tables("Files")
                .DisplayMember = "FileName"
                .ValueMember = "ID"
                .SelectedIndex = -1
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Function LookupDataDesc(ByVal Category As String) As String
        Try
            Dim value As String
            sqL = "SELECT ItemName FROM LookupData where ItemCategory = ('" & Category & "')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                value = dr(0)
            Else
                value = 0
            End If
            Return value
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Friend Sub LoadLookupDataReport()
        Try
            sqL = "SELECT LookupDataID,ItemCategory, ItemName,RecordDate from LookupData"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmLookupDataReport.dgw.Rows.Clear()
            Do While dr.Read = True
                frmLookupDataReport.dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Friend Sub deleteLookupDataItem()
        Try
            sqL = "DELETE FROM LookupData WHERE LookupDataID = " & frmLookupDataReport.dgw.CurrentRow.Cells(0).Value & ""
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Item has been deleted", MsgBoxStyle.Information, "Delete Item")

            Else
                MsgBox("Failed to delete item", MsgBoxStyle.Critical, "Delete Item")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()

        End Try
    End Sub
#End Region

    Friend Sub getEmployee()
        Try
            sqL = "SELECT StaffID, LastName, FirstName,MI FROM STaff  WHERE StaffID = " & frmLogin.LoginStaffNo & " "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                
                frmMain.lblloggedFullName.Text = dr("FirstName") & " " & dr("LastName")
                currentUser = dr("FirstName") & " " & dr("LastName")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

#Region "Reminders"

    Friend Sub AddReminders()
        Try
            sqL = "INSERT INTO Reminders(Reminder, ReminderDate,Details,Status) Values('" & frmReminders.txtReminder.Text & "', '" & frmReminders.dtpReminder.Text & "','" & frmReminders.txtDetails.Text & "','NOT DONE')"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Reminder Set", MsgBoxStyle.Information, "Add Reminder")
            Else
                MsgBox("Failed to Set Reminder", MsgBoxStyle.Critical, "Add Reminder")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Friend Sub LoadRemindersReport()
        Try
            sqL = "SELECT ID,Reminder, ReminderDate,Details,Status from Reminders ORDER BY ReminderDate DESC"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmReportReminders.dgw.Rows.Clear()
            Do While dr.Read = True
                frmReportReminders.dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Friend Sub MarkRemindersDone()
        Try
            sqL = "UPDATE Reminders SET Status ='DONE' WHERE ID = " & frmReportReminders.dgw.CurrentRow.Cells(0).Value & ""
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("The Reminder has been marked Done", MsgBoxStyle.Information, "Mark Reminders")

            Else
                MsgBox("Failed to Mark Reminder Done", MsgBoxStyle.Critical, "Mark Reminders")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()

        End Try
    End Sub

    Friend Sub MarkBookingDone()
        Try
            'sqL = "UPDATE Bookings SET Status =1 WHERE ID = " & frmMain.dgwBookings.CurrentRow.Cells(0).Value & ""
            'ConnDB()
            'cmd = New OleDbCommand(sqL, conn)
            'Dim i As Integer
            'i = cmd.ExecuteNonQuery
            'If i > 0 Then
            '    MsgBox("The Booking has been marked Done/Delivered", MsgBoxStyle.Information, "Mark Booking")

            'Else
            '    MsgBox("Failed to Mark Booking Done", MsgBoxStyle.Critical, "Mark Booking")
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()

        End Try
    End Sub
#End Region


    Friend Sub LoadStartRemindersReport()
        Try
            sqL = "SELECT TOP 500 ReminderDate,Reminder,Details from Reminders WHERE Status ='NOT DONE' ORDER BY ReminderDate DESC"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmMain.dgvReminders.Rows.Clear()
            Do While dr.Read = True
                frmMain.dgvReminders.Rows.Add(dr(0), dr(1), dr(2))
            Loop
            frmMain.lblReturnedItems.Text = frmMain.dgvReminders.RowCount
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Friend Sub LoadSearchRemindersReport()
        Try
            sqL = "SELECT ReminderDate,Reminder,Details from Reminders WHERE Details LIKE '%" & frmMain.txtsearch.Text & "%' ORDER BY ReminderDate DESC"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmMain.dgvReminders.Rows.Clear()
            Do While dr.Read = True
                frmMain.dgvReminders.Rows.Add(dr(0), dr(1), dr(2))
            Loop
            frmMain.lblReturnedItems.Text = frmMain.dgvReminders.RowCount
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Public Sub LoadStartFiles()
        Try
            sqL = "SELECT FileNo,ReferenceNo,FileName,Location,FileCatgeory,FileGroup,ReceivedFrom,FileStatus,LastUpdatedBy,LastUpdateDate,RegisteredBy,RecordDate FROM Files WHERE Hidden = 0 Order By FileName"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmMain.dgw.Rows.Clear()
            Do While dr.Read = True
                frmMain.dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11))
            Loop
            frmMain.lblReturnedItems.Text = frmMain.dgw.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub SearchStartFiles()
        Try
            If frmMain.txtsearch.Text = "***" Then
                sqL = "SELECT FileNo,ReferenceNo,FileName,Location,FileCatgeory,FileGroup,ReceivedFrom,FileStatus,LastUpdatedBy,LastUpdateDate,RegisteredBy,RecordDate FROM Files WHERE Hidden = 0 Order By FileName"
            Else
                sqL = "SELECT FileNo,ReferenceNo,FileName,Location,FileCatgeory,FileGroup,ReceivedFrom,FileStatus,LastUpdatedBy,LastUpdateDate,RegisteredBy,RecordDate FROM Files WHERE Hidden =0 AND FileName LIKE '%" & frmMain.txtsearch.Text & "%' OR RegisteredBy LIKE '%" & frmMain.txtsearch.Text & "%' OR Location LIKE '%" & frmMain.txtsearch.Text & "%'  OR ReceivedFrom LIKE '%" & frmMain.txtsearch.Text & "%' OR FileNo LIKE '%" & frmMain.txtsearch.Text & "%' Order By FileName"
            End If

            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmMain.dgw.Rows.Clear()
            Do While dr.Read = True
                frmMain.dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11))

            Loop
            frmMain.lblReturnedItems.Text = frmMain.dgw.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub



    Public Sub LoadOutWardFiles()
        Try
            sqL = "SELECT ExpectedDate,FileID,FileName,BorrowedBy,DetailsOut,RecordedBy,RecordDate FROM FileMovement Where ReturnedFile = 0 order by RecordDate desc "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmMain.dgwOutWard.Rows.Clear()
            Do While dr.Read = True
                frmMain.dgwOutWard.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
            frmMain.lblReturnedItems.Text = frmMain.dgwOutWard.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub LoadSearchOutWardFiles()
        Try
            sqL = "SELECT ExpectedDate,FileID,FileName,BorrowedBy,DetailsOut,RecordedBy,RecordDate FROM FileMovement Where FileName LIKE '%" & frmMain.txtsearch.Text & "%' OR BorrowedBy LIKE '%" & frmMain.txtsearch.Text & "%' And ReturnedFile = 0 Order By RecordDate desc"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmMain.dgwOutWard.Rows.Clear()
            Do While dr.Read = True
                frmMain.dgwOutWard.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
            Loop
            frmMain.lblReturnedItems.Text = frmMain.dgwOutWard.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub LoadFileHistory()
        Try
            sqL = "SELECT FileID,FileName,BorrowedBy,DetailsOut,RecordedBy,RecordDate,ReturnedBy,InWardDate,DetailsIn FROM FileMovement Where Len(ReturnedBy) >0 Order By InWardDate desc"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmMain.dgwFileHistory.Rows.Clear()
            Do While dr.Read = True
                frmMain.dgwFileHistory.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8))
            Loop
            frmMain.lblReturnedItems.Text = frmMain.dgwFileHistory.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub LoadSearchFileHistory()
        Try
            sqL = "SELECT FileID,FileName,BorrowedBy,DetailsOut,RecordedBy,RecordDate,ReturnedBy,InWardDate,DetailsIn FROM FileMovement Where Len(ReturnedBy) > 0  AND FileName LIKE '%" & frmMain.txtsearch.Text & "%' OR BorrowedBy LIKE '%" & frmMain.txtsearch.Text & "%' Order By RecordDate"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            frmMain.dgwFileHistory.Rows.Clear()
            Do While dr.Read = True
                frmMain.dgwFileHistory.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8))
            Loop
            frmMain.lblReturnedItems.Text = frmMain.dgwFileHistory.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Friend Sub todayreminders()
        Try



            Dim ReminderDateOne As Date = todaysDate.AddDays(7)

            sqL = "SELECT COUNT(ID) FROM Reminders Where Status ='NOT DONE' and ReminderDate >= CDATE('" & todaysDate & "') AND ReminderDate <= CDATE('" & ReminderDateOne & "') "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                frmMain.lblReminders.Text = dr(0).ToString
                If dr(0) > 0 Then
                    frmMain.lblReminders.Visible = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Friend Sub todayOutWardFiles()
        Try


            sqL = "SELECT COUNT(ID) FROM Files Where FileStatus = 'Borrowed' And Hidden =0 "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                frmMain.lblReturns.Text = dr(0).ToString
                If dr(0) > 0 Then
                    frmMain.lblReturns.Visible = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Friend Sub todayAvailableFiles()
        Try




            sqL = "SELECT COUNT(ID) FROM Files Where FileStatus = 'Available' "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                frmMain.lblAvailableFiles.Text = dr(0).ToString
                If dr(0) > 0 Then
                    frmMain.lblAvailableFiles.Visible = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Friend Sub todayUploadedFiles()
        Try




            sqL = "SELECT COUNT(ID) FROM Uploads "
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                frmMain.lblUploadedFiles.Text = dr(0).ToString
                If dr(0) > 0 Then
                    frmMain.lblUploadedFiles.Visible = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Friend Sub LoadAllNotifications()
        todayreminders()
        todayOutWardFiles()
        todayAvailableFiles()
        todayUploadedFiles()
    End Sub


#Region "Checks"

    
    

#End Region


#End Region



#Region "Animate"
    Private Declare Function AnimateWindow Lib "user32" (ByVal hwnd As Int32, ByVal dwTime As Int32, ByVal dwFlags As Int32) As Boolean
    Private Const AW_BLEND = &H80000  'Uses a fade effect. This flag can be used only if hwnd is a top-level window.

    Public Sub Anime(ByVal hwnd As Int32)

        Dim winHide As Integer = &H10000
        Dim winBlend As Integer = &H80000
        AnimateWindow(hwnd, CInt(500), winHide Or winBlend)
    End Sub

 
#End Region

#Region "Export To Excel"
    'Export to Excel
    Public Sub ExportToExcel(ByVal xdgv As DataGridView)
        ' Dim xdgv As DataGridView
        If xdgv.RowCount < 1 Then
            MessageBox.Show("There are no Items to export to excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Application

        Try
            Dim excelBook As Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Worksheet = CType(excelBook.Worksheets(1), Worksheet)
            xlApp.Visible = True

            rowsTotal = xdgv.RowCount - 1
            colsTotal = xdgv.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = xdgv.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = xdgv.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

#End Region

#Region "SMS"

    Public Sub SendSMSViaJolis(ByVal username As String, ByVal password As String, ByVal IS_GET As String, ByVal command As String, ByVal action As String, ByVal sendto As String, ByVal from As String, ByVal message As String)
        Try
            Dim Uri As Uri
            Dim myUrl As String
            Dim contentType As String
            Dim method As String
            Dim jsonString As String = "username=" & username & "&password=" & password & "&IS_GET=" & IS_GET & "&command=" & command & "&action=" & action & "&to=" & sendto & "&from=" & from & "&message=" & message
            myUrl = "https://secure.jolis.net/api.php"
            contentType = "application/x-www-form-urlencoded"
            method = "POST"

            Uri = New Uri(myUrl)
            Dim jsonDataBytes As Byte() = Encoding.UTF8.GetBytes(jsonString)

            Dim req As WebRequest = WebRequest.Create(Uri)
            req.ContentType = contentType
            req.Method = method
            req.ContentLength = jsonDataBytes.Length

            Dim stream As Stream = req.GetRequestStream()
            stream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
            stream.Close()
            Dim response As Stream = req.GetResponse().GetResponseStream()
            Dim reader As New StreamReader(response)
            Dim res As String = reader.ReadToEnd

            If res.Contains("SUCCESS") = True Then
                MessageBox.Show("Message has been Successfully Sent!")
                reader.Close()
                response.Close()
            Else
                MsgBox("Please connect to the Internet,If this Persists Call Mukiibi :0789571300", MsgBoxStyle.Information, "Send Message")
            End If

        Catch ex As Exception
            MsgBox("You are Offline,Please connect to the Internet", MsgBoxStyle.Information, "Send Message")
        End Try
    End Sub

    Public Function GetSMSUserName(ByVal agent As String) As String
        Try
            Dim value As String = Nothing

            sqL = "SELECT Username from SMSAgents where Agent ='" & agent & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                value = dr(0)

            End If
            Return value
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function GetSMSPass(ByVal agent As String) As String
        Try
            Dim value As String = Nothing

            sqL = "SELECT Pass from SMSAgents where Agent ='" & agent & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                value = _cipherEngine.Decipher(dr(0))

            End If
            Return value
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function GetVATValue() As Decimal
        Try
            Dim value As Decimal

            sqL = "SELECT VAT from OwnerInfo"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then

                value = (dr(0) / 100)

            End If
            Return value
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function


    Public Sub sendSMS(ByVal phone As String, ByVal Msg As String)
        Try

            sqL = "INSERT INTO SMS(Phone,Messages,SendDate,SendTime,LoginID,PCName) Values(@Phone,@Messages,@SendDate,@SendTime,@LoginID,@PCName)"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@Phone", phone)
            cmd.Parameters.AddWithValue("@Messages", Msg)
            cmd.Parameters.AddWithValue("@SendDate", Format(Date.Now, "Short Date"))
            cmd.Parameters.AddWithValue("@SendTime", Format(Date.Now, "Long Time"))
            '  cmd.Parameters.AddWithValue("@LoginID", frmMain.lblloggedFullName.Text)
            cmd.Parameters.AddWithValue("@PCName", My.Computer.Name)
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                SendSMSViaJolis("Mukiibii", "OFTEN2@13", "3", "vsms", "broadcast", phone, phone, Msg)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub '


#End Region


End Module
