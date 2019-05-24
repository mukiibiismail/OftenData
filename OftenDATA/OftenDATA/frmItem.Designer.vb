<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItem))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbcItemDetails = New System.Windows.Forms.TabControl()
        Me.tpgItemDetails = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboReceivedFrom = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkHide = New System.Windows.Forms.CheckBox()
        Me.txtFileID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboGroup = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboFileCategory = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CboFileLocation = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtfileName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfileNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteCF = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tbcItemDetails.SuspendLayout()
        Me.tpgItemDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.cmMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(5, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 390)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tbcItemDetails)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(10, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(623, 305)
        Me.Panel3.TabIndex = 1
        '
        'tbcItemDetails
        '
        Me.tbcItemDetails.Controls.Add(Me.tpgItemDetails)
        Me.tbcItemDetails.Location = New System.Drawing.Point(3, 3)
        Me.tbcItemDetails.Name = "tbcItemDetails"
        Me.tbcItemDetails.SelectedIndex = 0
        Me.tbcItemDetails.Size = New System.Drawing.Size(619, 240)
        Me.tbcItemDetails.TabIndex = 1
        '
        'tpgItemDetails
        '
        Me.tpgItemDetails.Controls.Add(Me.GroupBox1)
        Me.tpgItemDetails.Location = New System.Drawing.Point(4, 25)
        Me.tpgItemDetails.Name = "tpgItemDetails"
        Me.tpgItemDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgItemDetails.Size = New System.Drawing.Size(611, 211)
        Me.tpgItemDetails.TabIndex = 0
        Me.tpgItemDetails.Text = "File Details"
        Me.tpgItemDetails.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboReceivedFrom)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.chkHide)
        Me.GroupBox1.Controls.Add(Me.txtFileID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboGroup)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cboFileCategory)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.CboFileLocation)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtfileName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtfileNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(603, 195)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'cboReceivedFrom
        '
        Me.cboReceivedFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReceivedFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboReceivedFrom.FormattingEnabled = True
        Me.cboReceivedFrom.Items.AddRange(New Object() {"NA"})
        Me.cboReceivedFrom.Location = New System.Drawing.Point(419, 23)
        Me.cboReceivedFrom.MaxDropDownItems = 100
        Me.cboReceivedFrom.Name = "cboReceivedFrom"
        Me.cboReceivedFrom.Size = New System.Drawing.Size(177, 24)
        Me.cboReceivedFrom.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Received From :"
        '
        'chkHide
        '
        Me.chkHide.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHide.Location = New System.Drawing.Point(348, 128)
        Me.chkHide.Name = "chkHide"
        Me.chkHide.Size = New System.Drawing.Size(247, 20)
        Me.chkHide.TabIndex = 26
        Me.chkHide.Text = "Hide File :"
        Me.chkHide.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkHide.UseVisualStyleBackColor = True
        '
        'txtFileID
        '
        Me.txtFileID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtFileID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileID.Location = New System.Drawing.Point(113, 24)
        Me.txtFileID.MaxLength = 20
        Me.txtFileID.Name = "txtFileID"
        Me.txtFileID.Size = New System.Drawing.Size(194, 23)
        Me.txtFileID.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "File ID :"
        '
        'CboGroup
        '
        Me.CboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CboGroup.FormattingEnabled = True
        Me.CboGroup.Items.AddRange(New Object() {"NA"})
        Me.CboGroup.Location = New System.Drawing.Point(418, 102)
        Me.CboGroup.MaxDropDownItems = 100
        Me.CboGroup.Name = "CboGroup"
        Me.CboGroup.Size = New System.Drawing.Size(177, 24)
        Me.CboGroup.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(366, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 16)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Group:"
        '
        'cboFileCategory
        '
        Me.cboFileCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFileCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboFileCategory.FormattingEnabled = True
        Me.cboFileCategory.Items.AddRange(New Object() {"NA"})
        Me.cboFileCategory.Location = New System.Drawing.Point(418, 76)
        Me.cboFileCategory.MaxDropDownItems = 100
        Me.cboFileCategory.Name = "cboFileCategory"
        Me.cboFileCategory.Size = New System.Drawing.Size(177, 24)
        Me.cboFileCategory.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(345, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Category :"
        '
        'CboFileLocation
        '
        Me.CboFileLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFileLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CboFileLocation.FormattingEnabled = True
        Me.CboFileLocation.Items.AddRange(New Object() {"NA"})
        Me.CboFileLocation.Location = New System.Drawing.Point(418, 50)
        Me.CboFileLocation.MaxDropDownItems = 100
        Me.CboFileLocation.Name = "CboFileLocation"
        Me.CboFileLocation.Size = New System.Drawing.Size(177, 24)
        Me.CboFileLocation.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(325, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "File Location :"
        '
        'txtfileName
        '
        Me.txtfileName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtfileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfileName.Location = New System.Drawing.Point(113, 102)
        Me.txtfileName.MaxLength = 200
        Me.txtfileName.Multiline = True
        Me.txtfileName.Name = "txtfileName"
        Me.txtfileName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtfileName.Size = New System.Drawing.Size(194, 51)
        Me.txtfileName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "File Name :"
        '
        'txtRefNo
        '
        Me.txtRefNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefNo.Location = New System.Drawing.Point(113, 76)
        Me.txtRefNo.MaxLength = 20
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(194, 23)
        Me.txtRefNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ref No:"
        '
        'txtfileNo
        '
        Me.txtfileNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtfileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfileNo.Location = New System.Drawing.Point(113, 50)
        Me.txtfileNo.MaxLength = 20
        Me.txtfileNo.Name = "txtfileNo"
        Me.txtfileNo.Size = New System.Drawing.Size(194, 23)
        Me.txtfileNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "File No :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 56)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(528, 20)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 26)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(462, 20)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 26)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(365, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 26)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Location = New System.Drawing.Point(299, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 26)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Location = New System.Drawing.Point(232, 20)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(60, 26)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Location = New System.Drawing.Point(166, 20)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 26)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(10, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(623, 58)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Files"
        '
        'cmMain
        '
        Me.cmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteCF})
        Me.cmMain.Name = "cmMain"
        Me.cmMain.Size = New System.Drawing.Size(174, 26)
        '
        'DeleteCF
        '
        Me.DeleteCF.Image = CType(resources.GetObject("DeleteCF.Image"), System.Drawing.Image)
        Me.DeleteCF.Name = "DeleteCF"
        Me.DeleteCF.Size = New System.Drawing.Size(173, 22)
        Me.DeleteCF.Text = "Delete Custom Fee"
        '
        'frmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(654, 411)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Files"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tbcItemDetails.ResumeLayout(False)
        Me.tpgItemDetails.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.cmMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbcItemDetails As System.Windows.Forms.TabControl
    Friend WithEvents tpgItemDetails As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboFileCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CboFileLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtfileName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfileNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteCF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFileID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboReceivedFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkHide As System.Windows.Forms.CheckBox
End Class
