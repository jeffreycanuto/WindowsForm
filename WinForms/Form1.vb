



Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Chr(Asc(TextBox1.Text.Substring(0, 1))) >= Nothing Then
            Label1.Text = Chr(Asc(TextBox1.Text.Substring(0, 1)) - 1)
        Else
            Exit Sub
        End If

        If Chr(Asc(TextBox1.Text.Substring(1, 2))) >= Nothing Then
            Label2.Text = Chr(Asc(TextBox1.Text.Substring(1, 2)) - 1)
        Else
            Exit Sub
        End If

        If Chr(Asc(TextBox1.Text.Substring(2, 1))) >= Nothing Then
            Label3.Text = Chr(Asc(TextBox1.Text.Substring(2, 1)) - 1)
        Else
            Exit Sub
        End If

        If Chr(Asc(TextBox1.Text.Substring(3, 1))) >= Nothing Then
            Label4.Text = Chr(Asc(TextBox1.Text.Substring(3, 1)) - 1)
        Else
            Exit Sub
        End If
        If Chr(Asc(TextBox1.Text.Substring(4, 1))) >= Nothing Then
            Label5.Text = Chr(Asc(TextBox1.Text.Substring(4, 1)) - 1)
        Else
            Exit Sub
        End If
        If Chr(Asc(TextBox1.Text.Substring(5, 1))) >= Nothing Then
            Label6.Text = Chr(Asc(TextBox1.Text.Substring(5, 1)) - 1)
        Else
            Exit Sub
        End If
        If Chr(Asc(TextBox1.Text.Substring(6, 1))) >= Nothing Then
            Label7.Text = Chr(Asc(TextBox1.Text.Substring(6, 1)) - 1)
        Else
            Exit Sub
        End If
        If Chr(Asc(TextBox1.Text.Substring(7, 1))) >= Nothing Then
            Label8.Text = Chr(Asc(TextBox1.Text.Substring(7, 1)) - 1)
        Else
            Exit Sub
        End If

        TextBox2.Text = Label1.Text + Label2.Text + Label3.Text + Label4.Text + Label5.Text + Label6.Text + Label7.Text + Label8.Text
        'If Chr(Asc(TextBox1.Text.Substring(0, 2))) >= Nothing Then
        '    Dim a As String = (Chr(Asc(TextBox1.Text.Substring(0, 2)) - 1))
        '    TextBox2.Text = a + (TextBox2.Text)
        'Else
        '    Exit Sub
        'End If

        'If Chr(Asc(TextBox1.Text.Substring(0, 3))) >= Nothing Then

        '    Dim b As String = (Chr(Asc(TextBox1.Text.Substring(0, 3)) - 1))
        '    TextBox2.Text = b + (TextBox2.Text)
        'Else
        '    Exit Sub
        'End If
        'If Chr(Asc(TextBox1.Text.Substring(0, 4))) >= Nothing Then

        '    Dim c As String = (Chr(Asc(TextBox1.Text.Substring(0, 4)) - 1))
        '    TextBox2.Text = c + (TextBox2.Text)
        'Else
        '    Exit Sub
        'End If
        'If Chr(Asc(TextBox1.Text.Substring(0, 5))) >= Nothing Then

        '    Dim d As String = (Chr(Asc(TextBox1.Text.Substring(0, 5)) - 1))
        '    TextBox2.Text = d + (TextBox2.Text)
        'Else
        '    Exit Sub
        'End If
        'If Chr(Asc(TextBox1.Text.Substring(0, 6))) >= Nothing Then

        '    Dim j As String = (Chr(Asc(TextBox1.Text.Substring(0, 6)) - 1))
        '    TextBox2.Text = j + (TextBox2.Text)
        'Else
        '    Exit Sub
        'End If
        'If Chr(Asc(TextBox1.Text.Substring(0, 7))) >= Nothing Then

        '    Dim f As String = (Chr(Asc(TextBox1.Text.Substring(0, 7)) - 1))
        '    TextBox2.Text = f + (TextBox2.Text)
        'Else
        '    Exit Sub
        'End If
        'If Chr(Asc(TextBox1.Text.Substring(0, 8))) >= Nothing Then

        '    Dim g As String = (Chr(Asc(TextBox1.Text.Substring(0, 8)) - 1))
        '    TextBox2.Text = g + (TextBox2.Text)
        'Else
        '    Exit Sub
        'End If

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) > 1 Then
            MsgBox("key pressed " & e.KeyChar, MsgBoxStyle.Information)
            Label9.Text = TextBox3.Text + e.KeyChar
        End If
    End Sub

End Class
