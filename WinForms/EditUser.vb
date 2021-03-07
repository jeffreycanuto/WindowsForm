Public Class EditUser
    Private SQL As New SQLControl

    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = MainForm
        FetchUser()
    End Sub

    Private Sub FetchUser()
        'REFRESH USER LIST
        lbUser.Items.Clear()

        ' ADD PARAMS & RUN QUERY
        SQL.AddParam("@user", "%" & txtsearch.Text & "%")
        SQL.ExecQuery("SELECT username FROM tblUser WHERE username LIKE @user ORDER BY username ASC;")

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROWS & RETURN USER TO LIST
        For Each r As DataRow In SQL.DBDT.Rows
            lbUser.Items.Add(r("username"))
        Next
    End Sub

    Private Sub GetUserDetail(Username As String)
        SQL.AddParam("@name", Username)
        SQL.ExecQuery("SELECT * FROM tblUser WHERE username = @name;")

        If SQL.RecordCount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            txtID.Text = r("ID")
            txtUser.Text = r("username")
            txtPwd.Text = r("pwd")
            cbActive.Checked = r("active")
        Next
    End Sub

    Private Sub UpdateUser()
        SQL.AddParam("@pwd", txtPwd.Text)
        SQL.AddParam("@active", cbActive.Checked)
        SQL.AddParam("@ID", txtID.Text)

        SQL.ExecQuery("UPDATE tblUser set pwd=@pwd, active=@active WHERE ID=@ID;")

        If SQL.HasException(True) Then Exit Sub

        MsgBox("User has been updated.")
        'btnSave.Enabled = False
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchUser()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub lbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbUser.SelectedIndexChanged
        GetUserDetail(lbUser.Text)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateUser()
    End Sub
End Class