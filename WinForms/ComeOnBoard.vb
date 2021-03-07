Public Class ComeOnBoard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = TextBox1.Text
        If i >= 3 Then
            Label1.Text = "Do not dispatch"
        Else
            Label1.Text = "Dispatch"
        End If
    End Sub

End Class