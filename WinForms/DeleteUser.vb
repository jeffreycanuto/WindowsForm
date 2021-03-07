Public Class DeleteUser
    Private SQL As New SQLControl

    Private Sub DeleteUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = MainForm
        FetchUser()
    End Sub

    Private Sub FetchUser()
        'REFRESH USER LIST 
        cblUser.Items.Clear()

        'ADD PARAMS & RUN QUERY
        SQL.AddParam("@user", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("SELECT username FROM tblUser " &
                      "WHERE username LIKE @user ORDER BY username;")

        ' LOOP ROWS & RETURN USERS TO THE LIST
        For Each r As DataRow In SQL.DBDT.Rows
            cblUser.Items.Add(r("username"))
        Next

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SQL.AddParam("@user", txtFilter.Text)
        SQL.ExecQuery("SELECT username FROM tblUser WHERE username=@user;")

        If SQL.RecordCount > 0 Then
            SQL.AddParam("@Duser", txtFilter.Text)
            SQL.ExecQuery("Delete FROM tblUser WHERE username=@Duser;")
            MsgBox("User has beed deleted.", vbInformation, "Information")
        Else
            MsgBox("User account does not exist.", vbCritical, "Information")
        End If

        If SQL.HasException(True) Then Exit Sub

    End Sub

    Private Sub DeleteUser()
        If MsgBox("The selected user will be deleted! Are you sure you wish to continue?", MsgBoxStyle.YesNo, "Delete User?") = MsgBoxResult.Yes Then
            'GENERATE A MASS DELETE COMMAND
            Dim c As Integer 'unique ID for auto generated numbers
            Dim DelString As String = "" ' query string

            For Each i As String In cblUser.CheckedItems
                SQL.AddParam("@userA" & c, i)
                DelString += "DELETE FROM tblUser WHERE username=@userA" & c & ";"
                c += 1
            Next

            SQL.ExecQuery(DelString)

            ' REPORT & ABORT ON ERRORS
            If SQL.HasException(True) Then Exit Sub

            ' REPORT SUCCESS
            MsgBox("The selected users have been deleted successfully.")

            ' REFRESH LIST
            FetchUser()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchUser()
            e.Handled = True
            e.SuppressKeyPress = True   'suppress ding

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If cblUser.CheckedItems.Count > 0 Then DeleteUser()
    End Sub
End Class