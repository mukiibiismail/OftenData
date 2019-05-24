Imports System.Data.OleDb
Public Class frmItem

    Dim adding As Boolean
    Dim updating As Boolean
    Public search As Boolean
    Dim getStocksOnHand As Integer

    Private Sub GetQuantity()
        Try
            sqL = "SELECT StocksOnhand FROM Item WHERE ItemNo = " & txtfileNo.Text & ""
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                getStocksOnHand = dr(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub



    Private Sub AddStocksInAdding()
        Try
            sqL = "INSERT INTO StocksIn(ItemNo, ItemQuantity, SIDate,CurrentStocks) VALUES(@ItemNo,@Quantity,@SIDate,@CurrentStocks)"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            'cmd.Parameters.AddWithValue("@ItemNo", txtItemNo.Text)
            'cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            'cmd.Parameters.AddWithValue("@SIDate", Format(Date.Now, "Short Date"))
            'cmd.Parameters.AddWithValue("@CurrentStocks", txtQuantity.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetItemNo()
        Try
            sqL = "SELECT ID From Files Order By ID desc"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                txtFileID.Text = dr(0) + 1

            Else
                txtFileID.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub checkitemNo()
        Try
            sqL = "SELECT TOP 1 ID From Files Order By ID desc"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                Dim itNo As String = Val(dr(0))

                If (itNo >= txtFileID.Text) Then

                    GetItemNo()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddNewFile()

        Try
            Me.checkitemNo()


            sqL = "INSERT INTO Files (FileNo,ReferenceNo,FileName,Location,FileCatgeory,FileGroup,ReceivedFrom,RegisteredBy,FileStatus,LastUpdatedBy,LastUpdateDate,RecordDate,Hidden) VALUES (@FileNo,@ReferenceNo,@FileName,@Location,@FileCatgeory,@FileGroup,@ReceivedFrom,@RegisteredBy,@FileStatus,@LastUpdatedBy,@LastUpdateDate,@RecordDate,@Hidden)"
            ConnDB()

            cmd = New OleDbCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@FileNo", txtfileNo.Text)
            cmd.Parameters.AddWithValue("@ReferenceNo", txtRefNo.Text)
            cmd.Parameters.AddWithValue("@FileName", txtfileName.Text)
            cmd.Parameters.AddWithValue("@Location", CboFileLocation.Text)
            cmd.Parameters.AddWithValue("@FileCatgeory", cboFileCategory.Text)
            cmd.Parameters.AddWithValue("@FileGroup", CboGroup.Text)
            cmd.Parameters.AddWithValue("@ReceivedFrom", cboReceivedFrom.Text)
            cmd.Parameters.AddWithValue("@RegisteredBy", currentUser)
            cmd.Parameters.AddWithValue("@FileStatus", "Available")
            cmd.Parameters.AddWithValue("@LastUpdatedBy", currentUser)
            cmd.Parameters.AddWithValue("@LastUpdateDate", Format(Now, "Short Date"))
            cmd.Parameters.AddWithValue("@RecordDate", Format(Now, "Short Date"))
            cmd.Parameters.AddWithValue("@Hidden", chkHide.CheckState)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then

                MsgBox("New File Added Successfully", MsgBoxStyle.Information, "Expenditure")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub

    Private Sub UpdateFile()

        Try
            sqL = "UPDATE Files SET FileNo = @FileNo,ReferenceNo = @ReferenceNo,FileName = @FileName,Location = @Location,FileCatgeory = @FileCatgeory,FileGroup = @FileGroup,ReceivedFrom = @ReceivedFrom,LastUpdatedBy = @LastUpdatedBy,LastUpdateDate = @LastUpdateDate,Hidden = @Hidden WHERE ID = val(" & txtFileID.Text & ")"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@FileNo", txtfileNo.Text)
            cmd.Parameters.AddWithValue("@ReferenceNo", txtRefNo.Text)
            cmd.Parameters.AddWithValue("@FileName", txtfileName.Text)
            cmd.Parameters.AddWithValue("@Location", CboFileLocation.Text)
            cmd.Parameters.AddWithValue("@FileCatgeory", cboFileCategory.Text)
            cmd.Parameters.AddWithValue("@FileGroup", CboGroup.Text)
            cmd.Parameters.AddWithValue("@ReceivedFrom", cboReceivedFrom.Text)
            cmd.Parameters.AddWithValue("@LastUpdatedBy", currentUser)
            cmd.Parameters.AddWithValue("@LastUpdateDate", Format(Now, "Short Date"))
            cmd.Parameters.AddWithValue("@Hidden", chkHide.CheckState)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then

                MsgBox("File Updated", MsgBoxStyle.Information, "Update File")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetItemRecord()
        Try
            LoadLookupData(Me.CboFileLocation, "Location")
            LoadLookupData(Me.cboFileCategory, "Category")
            LoadLookupData(Me.CboGroup, "Group")
            LoadLookupData(Me.cboReceivedFrom, "Received From")
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            sqL = "SELECT FileNo,IIF(ReferenceNo IS NULL,'NA',ReferenceNo),FileName,Location,FileCatgeory,FileGroup,ReceivedFrom,Hidden FROM Files Where ID = " & txtFileID.Text & ""
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                txtfileNo.Text = dr(0)
                txtRefNo.Text = dr(1)
                txtfileName.Text = dr(2)
                CboFileLocation.Text = dr(3)
                cboFileCategory.Text = dr(4)
                CboGroup.Text = dr(5)
                cboReceivedFrom.Text = dr(6)
                chkHide.CheckState = dr(7)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub



    Private Sub ClearFields()
        txtfileNo.Clear()
        txtRefNo.Clear()
        txtfileName.Clear()
        txtFileID.Clear()
        chkHide.CheckState = CheckState.Unchecked

    End Sub
 


    Private Sub EnabledText()
        txtfileNo.Enabled = True
        txtRefNo.Enabled = True
        txtfileName.Enabled = True
        CboFileLocation.Enabled = True
        CboGroup.Enabled = True
        cboFileCategory.Enabled = True
        cboReceivedFrom.Enabled = True

    End Sub

    Private Sub DisabledText()
        txtfileNo.Enabled = False
        txtRefNo.Enabled = False
        txtfileName.Enabled = False
        CboFileLocation.Enabled = False
        CboGroup.Enabled = False
        cboFileCategory.Enabled = False
        cboReceivedFrom.Enabled = False

    End Sub

    Private Sub EnabledButton()
        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        btnSearch.Enabled = True
        btnClose.Enabled = True

        btnSave.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub DisabledButton()
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnSearch.Enabled = False
        btnClose.Enabled = False

        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        adding = True
        updating = False

        EnabledText()
        DisabledButton()
        ClearFields()
        GetItemNo()
        txtfileNo.Focus()
        txtFileID.Enabled = False

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        adding = False
        updating = True

        EnabledText()
        DisabledButton()
        txtfileNo.Focus()
        txtFileID.Enabled = False
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search = True
        frmLoadAllItems.ShowDialog()
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Anime(Me.Handle.ToInt32)
        Me.Close()
    End Sub
    Private Sub UpdateAFile()
        UpdateFile()
        DisabledText()
        EnabledButton()
        ClearFields()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If adding = True Then

            If txtfileName.Text = "" Or txtfileNo.Text = "" Or cboFileCategory.Text = "" Or CboFileLocation.Text = "" Or CboGroup.Text = "" Or cboReceivedFrom.Text = "" Then
                MessageBox.Show("Please Enter File No,File Name,Category, " & vbCrLf & "Location,Group,Received From", "Often DATA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                AddNewFile()
                DisabledText()
                EnabledButton()
                ClearFields()
            End If


        ElseIf updating = True Then

            If txtfileName.Text = "" Or txtfileNo.Text = "" Or cboFileCategory.Text = "" Or CboFileLocation.Text = "" Or CboGroup.Text = "" Or cboReceivedFrom.Text = "" Then
                MessageBox.Show("Please Enter File No,File Name,Category, " & vbCrLf & "Location,Group,Received From", "Often DATA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                UpdateAFile()
            End If

            End If

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DisabledText()
        EnabledButton()
        ClearFields()
    End Sub

    Private Sub frmItem_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Anime(Me.Handle.ToInt32)
    End Sub

    Private Sub frmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnabledButton()
        DisabledText()
        ClearFields()

        LoadLookupData(Me.CboFileLocation, "Location")
        LoadLookupData(Me.cboFileCategory, "Category")
        LoadLookupData(Me.CboGroup, "Group")
        LoadLookupData(Me.cboReceivedFrom, "Received From")
    End Sub


    Private Sub txtFileID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFileID.TextChanged
        If search = True Then
            GetItemRecord()
            search = False
        End If
    End Sub
End Class