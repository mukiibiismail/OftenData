<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangepassAll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangepassAll))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnchangepass = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtusername = New System.Windows.Forms.Label()
        Me.cbouser = New System.Windows.Forms.ComboBox()
        Me.lblconfirmpass = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtCpwd = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblchangepass = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnclose)
        Me.Panel3.Controls.Add(Me.btnchangepass)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(2, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 277)
        Me.Panel3.TabIndex = 5
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.White
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclose.Location = New System.Drawing.Point(157, 239)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnchangepass
        '
        Me.btnchangepass.BackColor = System.Drawing.Color.White
        Me.btnchangepass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnchangepass.Location = New System.Drawing.Point(21, 239)
        Me.btnchangepass.Name = "btnchangepass"
        Me.btnchangepass.Size = New System.Drawing.Size(119, 23)
        Me.btnchangepass.TabIndex = 2
        Me.btnchangepass.Text = "&Change Password"
        Me.btnchangepass.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.cbouser)
        Me.Panel2.Controls.Add(Me.lblconfirmpass)
        Me.Panel2.Controls.Add(Me.lblpass)
        Me.Panel2.Controls.Add(Me.txtCpwd)
        Me.Panel2.Controls.Add(Me.txtpwd)
        Me.Panel2.Location = New System.Drawing.Point(8, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(306, 181)
        Me.Panel2.TabIndex = 1
        '
        'txtusername
        '
        Me.txtusername.AutoSize = True
        Me.txtusername.Location = New System.Drawing.Point(24, 8)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(29, 13)
        Me.txtusername.TabIndex = 5
        Me.txtusername.Text = "User"
        '
        'cbouser
        '
        Me.cbouser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbouser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbouser.FormattingEnabled = True
        Me.cbouser.Location = New System.Drawing.Point(20, 32)
        Me.cbouser.Name = "cbouser"
        Me.cbouser.Size = New System.Drawing.Size(193, 21)
        Me.cbouser.TabIndex = 4
        '
        'lblconfirmpass
        '
        Me.lblconfirmpass.AutoSize = True
        Me.lblconfirmpass.Location = New System.Drawing.Point(17, 117)
        Me.lblconfirmpass.Name = "lblconfirmpass"
        Me.lblconfirmpass.Size = New System.Drawing.Size(91, 13)
        Me.lblconfirmpass.TabIndex = 3
        Me.lblconfirmpass.Text = "Confirm Password"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(17, 63)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(56, 13)
        Me.lblpass.TabIndex = 2
        Me.lblpass.Text = "Password "
        '
        'txtCpwd
        '
        Me.txtCpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCpwd.Location = New System.Drawing.Point(17, 137)
        Me.txtCpwd.MaxLength = 20
        Me.txtCpwd.Name = "txtCpwd"
        Me.txtCpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(124)
        Me.txtCpwd.Size = New System.Drawing.Size(196, 20)
        Me.txtCpwd.TabIndex = 1
        '
        'txtpwd
        '
        Me.txtpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpwd.Location = New System.Drawing.Point(17, 84)
        Me.txtpwd.MaxLength = 20
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(124)
        Me.txtpwd.Size = New System.Drawing.Size(196, 20)
        Me.txtpwd.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblchangepass)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 43)
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
        Me.lblchangepass.Size = New System.Drawing.Size(148, 20)
        Me.lblchangepass.TabIndex = 0
        Me.lblchangepass.Text = "Reset Passwords"
        '
        'frmChangepassAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 295)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChangepassAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Users Password"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnchangepass As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblconfirmpass As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtCpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblchangepass As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.Label
    Friend WithEvents cbouser As System.Windows.Forms.ComboBox
End Class
