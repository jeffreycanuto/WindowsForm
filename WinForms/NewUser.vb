Public Class NewUser
    Private SQL As New SQLControl

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = MainForm
    End Sub
    Private Sub insertUser()
        'ADD SQL Param & Run Command
        SQL.AddParam("@user", txtUser.Text)
        SQL.AddParam("@pwd", txtPwd.Text)
        SQL.AddParam("@active", cbActive.Checked)

        SQL.ExecQuery("INSERT INTO tblUser (username, pwd, joindate, active) VALUES " &
                        "(@user, @pwd, GETDATE(), @active);")

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        'OPTIONAL
        'If SQL.DBDT.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.DBDT.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If

        MsgBox("User added successfully!")


        'ID int,
        'username varchar(50),
        'pwd varchar(20),
        'lvl char(5),
        'joindate datetime,
        'lastactive datetime,
        'active bit

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged, txtPwd.TextChanged
        'PERFORM BASIC VALIDATIONS
        If Not String.IsNullOrWhiteSpace(txtUser.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPwd.Text) Then
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        insertUser()

        txtUser.Clear()
        txtPwd.Clear()
        cbActive.Checked = False
        btnSave.Enabled = False
    End Sub
End Class