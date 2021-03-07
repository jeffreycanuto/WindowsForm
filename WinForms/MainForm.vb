Public Class MainForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub GridviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridviewToolStripMenuItem.Click
        GridView.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        NewUser.Show()
    End Sub

    Private Sub UpdateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateUserToolStripMenuItem.Click
        EditUser.Show()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        DeleteUser.Show()
    End Sub
End Class