Public Class login

    
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username, password As String
        username = txtuser.Text
        password = pasword.Text
        If username = "BIT2118" And password = "12345" Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Wrong Details!")
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtpassword.Clear()
        txtuser.Clear()

    End Sub
End Class