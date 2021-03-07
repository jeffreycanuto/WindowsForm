<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbActive = New System.Windows.Forms.CheckBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "User name"
        '
        'cbActive
        '
        Me.cbActive.AutoSize = True
        Me.cbActive.Location = New System.Drawing.Point(253, 53)
        Me.cbActive.Name = "cbActive"
        Me.cbActive.Size = New System.Drawing.Size(56, 17)
        Me.cbActive.TabIndex = 10
        Me.cbActive.Text = "Active"
        Me.cbActive.UseVisualStyleBackColor = True
        '
        'txtPwd
        '
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd.Location = New System.Drawing.Point(135, 79)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(112, 20)
        Me.txtPwd.TabIndex = 9
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Location = New System.Drawing.Point(135, 53)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(112, 20)
        Me.txtUser.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(160, 131)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbActive)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "NewUser"
        Me.Text = "User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbActive As CheckBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnSave As Button
End Class
