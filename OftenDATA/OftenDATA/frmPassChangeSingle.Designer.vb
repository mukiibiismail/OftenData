<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassChangeSingle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassChangeSingle))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblchangepass = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblconfirmpass = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtCpwd = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.btnchangepass = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblchangepass)
        Me.Panel1.Location = New System.Drawing.Point(8, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 43)
        Me.Panel1.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(188, 15)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(13, 13)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "0"
        Me.lblUser.Visible = False
        '
        'lblchangepass
        '
        Me.lblchangepass.AutoSize = True
        Me.lblchangepass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchangepass.Location = New System.Drawing.Point(13, 12)
        Me.lblchangepass.Name = "lblchangepass"
        Me.lblchangepass.Size = New System.Drawing.Size(153, 20)
        Me.lblchangepass.TabIndex = 0
        Me.lblchangepass.Text = "Change Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblconfirmpass)
        Me.Panel2.Controls.Add(Me.lblpass)
        Me.Panel2.Controls.Add(Me.txtCpwd)
        Me.Panel2.Controls.Add(Me.txtpwd)
        Me.Panel2.Location = New System.Drawing.Point(8, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 126)
        Me.Panel2.TabIndex = 1
        '
        'lblconfirmpass
        '
        Me.lblconfirmpass.AutoSize = True
        Me.lblconfirmpass.Location = New System.Drawing.Point(17, 67)
        Me.lblconfirmpass.Name = "lblconfirmpass"
        Me.lblconfirmpass.Size = New System.Drawing.Size(91, 13)
        Me.lblconfirmpass.TabIndex = 3
        Me.lblconfirmpass.Text = "Confirm Password"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(17, 13)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(56, 13)
        Me.lblpass.TabIndex = 2
        Me.lblpass.Text = "Password "
        '
        'txtCpwd
        '
        Me.txtCpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCpwd.Location = New System.Drawing.Point(17, 87)
        Me.txtCpwd.MaxLength = 20
        Me.txtCpwd.Name = "txtCpwd"
        Me.txtCpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(124)
        Me.txtCpwd.Size = New System.Drawing.Size(196, 20)
        Me.txtCpwd.TabIndex = 1
        '
        'txtpwd
        '
        Me.txtpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpwd.Location = New System.Drawing.Point(17, 34)
        Me.txtpwd.MaxLength = 20
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(124)
        Me.txtpwd.Size = New System.Drawing.Size(196, 20)
        Me.txtpwd.TabIndex = 0
        '
        'btnchangepass
        '
        Me.btnchangepass.BackColor = System.Drawing.Color.White
        Me.btnchangepass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnchangepass.Location = New System.Drawing.Point(66, 184)
        Me.btnchangepass.Name = "btnchangepass"
        Me.btnchangepass.Size = New System.Drawing.Size(119, 23)
        Me.btnchangepass.TabIndex = 2
        Me.btnchangepass.Text = "&Change Password"
        Me.btnchangepass.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.White
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclose.Location = New System.Drawing.Point(198, 184)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnclose)
        Me.Panel3.Controls.Add(Me.btnchangepass)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(286, 222)
        Me.Panel3.TabIndex = 4
        '
        'frmPassChangeSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 228)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPassChangeSingle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblchangepass As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblconfirmpass As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtCpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents btnchangepass As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
