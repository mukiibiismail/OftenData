Public Class frmMain

    Private Sub tsbAddItems_Click(sender As System.Object, e As System.EventArgs) Handles tsbAddItems.Click
        frmItem.ShowDialog()
    End Sub

    Private Sub mnuSettingLookupData_Click(sender As System.Object, e As System.EventArgs) Handles mnuSettingLookupData.Click
        frmLookupData.ShowDialog()
    End Sub

    Private Sub mnuSettingsLookupDataDetails_Click(sender As System.Object, e As System.EventArgs) Handles mnuSettingsLookupDataDetails.Click
        frmLookupDataReport.ShowDialog()
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        LoadAllNotifications()
    End Sub

  
    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()
        LoadStartFiles()
        LoadOutWardFiles()
        LoadAllNotifications()
        LoadFileHistory()
        LoadStartRemindersReport()
        getEmployee()
    End Sub

    Private Sub tbcMain_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tbcMain.SelectedIndexChanged
        Select Case Me.tbcMain.SelectedTab.Name

            Case Me.tpgAvailableItems.Name
                LoadStartFiles()
            Case Me.tpgReminders.Name
                LoadStartRemindersReport()
            Case Me.tpgOutWardFiles.Name
                LoadOutWardFiles()
            Case Me.tpgFileHistory.Name
                LoadFileHistory()

        End Select
    End Sub

    Private Sub txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged
        Select Case Me.tbcMain.SelectedTab.Name

            Case Me.tpgAvailableItems.Name
                SearchStartFiles()
            Case Me.tpgReminders.Name
                LoadSearchRemindersReport()
            Case Me.tpgOutWardFiles.Name
                LoadSearchOutWardFiles()
            Case Me.tpgFileHistory.Name
                LoadSearchFileHistory()

        End Select
    End Sub

    Private Sub tbcReminders_Click(sender As System.Object, e As System.EventArgs) Handles tbcReminders.Click
        frmReminders.ShowDialog()
    End Sub

    Private Sub mnuBookings_Click(sender As System.Object, e As System.EventArgs)
        frmFileUpload.ShowDialog()
    End Sub

    Private Sub tsbSoldItems_Click(sender As System.Object, e As System.EventArgs) Handles tsbSoldItems.Click
        frmOutWardFiles.ShowDialog()
    End Sub

    Private Sub tspStocksoutReport_Click(sender As System.Object, e As System.EventArgs) Handles tspStocksoutReport.Click
        frmInWardFiles.ShowDialog()
    End Sub

    Private Sub mnuResetUsersPasswords_Click(sender As System.Object, e As System.EventArgs) Handles mnuResetUsersPasswords.Click
        frmChangepassAll.ShowDialog()
    End Sub

    Private Sub mnuSettingsAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuSettingsAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuStaff_Click(sender As System.Object, e As System.EventArgs) Handles mnuStaff.Click
        frmStaff.ShowDialog()
    End Sub

    Private Sub mnuAllStaff_Click(sender As System.Object, e As System.EventArgs) Handles mnuAllStaff.Click
        frmAllUsers.ShowDialog()
    End Sub

    Private Sub mnuEmployeeNewUser_Click(sender As System.Object, e As System.EventArgs) Handles mnuEmployeeNewUser.Click
        frmUsers.ShowDialog()
    End Sub

    Private Sub mnuChangePassword_Click(sender As System.Object, e As System.EventArgs) Handles mnuChangePassword.Click
        frmPassChangeSingle.ShowDialog()
    End Sub

    Private Sub btnRefreshGrid_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshGrid.Click
        LoadStartFiles()
        LoadOutWardFiles()
        LoadAllNotifications()
        LoadRemindersReport()
        LoadFileHistory()
    End Sub

    Private Sub tspFileUpload_Click(sender As System.Object, e As System.EventArgs) Handles tspFileUpload.Click
        frmFileUpload.ShowDialog()
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripDropDownButton1.Click
        frmViewAllFiles.ShowDialog()
    End Sub
End Class
