<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportItems
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportItems))
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.ColItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPurchasePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBatchNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColItemQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnitOfMeasure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColItemCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColExpiryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSaved = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtImportExisting = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtsheet = New System.Windows.Forms.TextBox()
        Me.ofdstock = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ImportedRows = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColItemCode, Me.ColDescription, Me.ColPurchasePrice, Me.ColUnitPrice, Me.ColBatchNo, Me.ColItemQuantity, Me.ColUnitOfMeasure, Me.ColItemCategory, Me.ColExpiryDate, Me.ColSaved})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(4, 106)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgw.RowHeadersVisible = False
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(797, 330)
        Me.dgw.TabIndex = 48
        '
        'ColItemCode
        '
        Me.ColItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColItemCode.DataPropertyName = "ItemNo"
        Me.ColItemCode.HeaderText = "ItemNo"
        Me.ColItemCode.Name = "ColItemCode"
        Me.ColItemCode.ReadOnly = True
        '
        'ColDescription
        '
        Me.ColDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColDescription.DataPropertyName = "ItemName"
        Me.ColDescription.HeaderText = "ItemName"
        Me.ColDescription.Name = "ColDescription"
        Me.ColDescription.ReadOnly = True
        '
        'ColPurchasePrice
        '
        Me.ColPurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColPurchasePrice.DataPropertyName = "UnitCost"
        DataGridViewCellStyle3.NullValue = "0"
        Me.ColPurchasePrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColPurchasePrice.HeaderText = "Unit Cost"
        Me.ColPurchasePrice.Name = "ColPurchasePrice"
        Me.ColPurchasePrice.ReadOnly = True
        '
        'ColUnitPrice
        '
        Me.ColUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColUnitPrice.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle4.NullValue = "0"
        Me.ColUnitPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColUnitPrice.HeaderText = "Unit Price"
        Me.ColUnitPrice.Name = "ColUnitPrice"
        Me.ColUnitPrice.ReadOnly = True
        '
        'ColBatchNo
        '
        Me.ColBatchNo.DataPropertyName = "BatchNo"
        Me.ColBatchNo.HeaderText = "BatchNo"
        Me.ColBatchNo.Name = "ColBatchNo"
        Me.ColBatchNo.ReadOnly = True
        '
        'ColItemQuantity
        '
        Me.ColItemQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColItemQuantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle5.NullValue = "0"
        Me.ColItemQuantity.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColItemQuantity.HeaderText = "Quantity"
        Me.ColItemQuantity.Name = "ColItemQuantity"
        Me.ColItemQuantity.ReadOnly = True
        '
        'ColUnitOfMeasure
        '
        Me.ColUnitOfMeasure.DataPropertyName = "UnitOfMeasure"
        Me.ColUnitOfMeasure.HeaderText = "UnitOfMeasure"
        Me.ColUnitOfMeasure.Name = "ColUnitOfMeasure"
        Me.ColUnitOfMeasure.ReadOnly = True
        '
        'ColItemCategory
        '
        Me.ColItemCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColItemCategory.DataPropertyName = "ItemGroup"
        Me.ColItemCategory.HeaderText = "ItemGroup"
        Me.ColItemCategory.Name = "ColItemCategory"
        Me.ColItemCategory.ReadOnly = True
        '
        'ColExpiryDate
        '
        Me.ColExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColExpiryDate.DataPropertyName = "ExpiryDate"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ColExpiryDate.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColExpiryDate.HeaderText = "Expiry Date"
        Me.ColExpiryDate.Name = "ColExpiryDate"
        Me.ColExpiryDate.ReadOnly = True
        '
        'ColSaved
        '
        Me.ColSaved.HeaderText = "Saved"
        Me.ColSaved.Name = "ColSaved"
        Me.ColSaved.ReadOnly = True
        Me.ColSaved.Width = 40
        '
        'btnImport
        '
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Location = New System.Drawing.Point(629, 10)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(89, 23)
        Me.btnImport.TabIndex = 49
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(711, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 51
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtImportExisting
        '
        Me.txtImportExisting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImportExisting.Location = New System.Drawing.Point(7, 10)
        Me.txtImportExisting.Name = "txtImportExisting"
        Me.txtImportExisting.Size = New System.Drawing.Size(432, 20)
        Me.txtImportExisting.TabIndex = 52
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 48)
        Me.Panel2.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Import New Items"
        '
        'btnbrowse
        '
        Me.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowse.Location = New System.Drawing.Point(551, 10)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnbrowse.TabIndex = 54
        Me.btnbrowse.Text = "&Browse"
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(630, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 55
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtsheet)
        Me.Panel1.Controls.Add(Me.btnbrowse)
        Me.Panel1.Controls.Add(Me.txtImportExisting)
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Location = New System.Drawing.Point(4, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 48)
        Me.Panel1.TabIndex = 56
        '
        'txtsheet
        '
        Me.txtsheet.Location = New System.Drawing.Point(445, 12)
        Me.txtsheet.Name = "txtsheet"
        Me.txtsheet.Size = New System.Drawing.Size(100, 20)
        Me.txtsheet.TabIndex = 55
        Me.txtsheet.Text = "Sheet1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ImportedRows)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Location = New System.Drawing.Point(18, 454)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(791, 38)
        Me.Panel3.TabIndex = 57
        '
        'ImportedRows
        '
        Me.ImportedRows.AutoSize = True
        Me.ImportedRows.Location = New System.Drawing.Point(17, 12)
        Me.ImportedRows.Name = "ImportedRows"
        Me.ImportedRows.Size = New System.Drawing.Size(0, 13)
        Me.ImportedRows.TabIndex = 56
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.dgw)
        Me.Panel4.Location = New System.Drawing.Point(7, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(809, 494)
        Me.Panel4.TabIndex = 58
        '
        'frmImportItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 512)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Items"
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtImportExisting As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ofdstock As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtsheet As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ImportedRows As System.Windows.Forms.Label
    Friend WithEvents ColItemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPurchasePrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColUnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBatchNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColItemQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColUnitOfMeasure As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColItemCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColExpiryDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSaved As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
