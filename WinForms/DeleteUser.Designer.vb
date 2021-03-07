<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteUser
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
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.cblUser = New System.Windows.Forms.CheckedListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFilter
        '
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.Location = New System.Drawing.Point(12, 25)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(161, 20)
        Me.txtFilter.TabIndex = 0
        '
        'cblUser
        '
        Me.cblUser.FormattingEnabled = True
        Me.cblUser.Location = New System.Drawing.Point(13, 52)
        Me.cblUser.Name = "cblUser"
        Me.cblUser.Size = New System.Drawing.Size(160, 229)
        Me.cblUser.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(13, 288)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(180, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DeleteUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 335)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cblUser)
        Me.Controls.Add(Me.txtFilter)
        Me.Name = "DeleteUser"
        Me.Text = "DeleteUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFilter As TextBox
    Friend WithEvents cblUser As CheckedListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button2 As Button
End Class
