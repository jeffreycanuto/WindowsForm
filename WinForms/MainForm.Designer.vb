<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRUDFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GridviewToolStripMenuItem, Me.CRUDFormToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'CRUDFormToolStripMenuItem
        '
        Me.CRUDFormToolStripMenuItem.Name = "CRUDFormToolStripMenuItem"
        Me.CRUDFormToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CRUDFormToolStripMenuItem.Text = "CRUD Form"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GridviewToolStripMenuItem
        '
        Me.GridviewToolStripMenuItem.Name = "GridviewToolStripMenuItem"
        Me.GridviewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GridviewToolStripMenuItem.Text = "Gridview"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.UpdateUserToolStripMenuItem, Me.DeleteUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewUserToolStripMenuItem.Text = "New User"
        '
        'UpdateUserToolStripMenuItem
        '
        Me.UpdateUserToolStripMenuItem.Name = "UpdateUserToolStripMenuItem"
        Me.UpdateUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateUserToolStripMenuItem.Text = "Update User"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 540)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CRUDFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GridviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
End Class
