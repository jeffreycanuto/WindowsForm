<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
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
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lbUser = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbActive = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Location = New System.Drawing.Point(24, 31)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(159, 20)
        Me.txtsearch.TabIndex = 0
        '
        'lbUser
        '
        Me.lbUser.FormattingEnabled = True
        Me.lbUser.Location = New System.Drawing.Point(24, 58)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(159, 251)
        Me.lbUser.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.cbActive)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPwd)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 278)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(219, 208)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbActive
        '
        Me.cbActive.AutoSize = True
        Me.cbActive.Location = New System.Drawing.Point(180, 135)
        Me.cbActive.Name = "cbActive"
        Me.cbActive.Size = New System.Drawing.Size(56, 17)
        Me.cbActive.TabIndex = 6
        Me.cbActive.Text = "Active"
        Me.cbActive.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(78, 99)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(158, 20)
        Me.txtPwd.TabIndex = 2
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(78, 73)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(158, 20)
        Me.txtUser.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(41, 27)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(47, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbUser)
        Me.Controls.Add(Me.txtsearch)
        Me.Name = "EditUser"
        Me.Text = "EditUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lbUser As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents cbActive As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtID As TextBox
End Class
