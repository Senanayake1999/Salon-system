Public Class Login
    Private Sub LoginBTN_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click

        Dim username As String
        Dim password As String

        username = UsernameTB.Text
        password = PasswordTB.Text

        If UsernameTB.Text = "" Or PasswordTB.Text = "" Then
            MsgBox("Enter Username & Password")
        ElseIf UsernameTB.Text = "Admin" And PasswordTB.Text = "1234" Then
            Dim Obj = New Dashboard
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect UserName or Password")
            UsernameTB.Text = ""
            PasswordTB.Text = ""
        End If
    End Sub
    'show password text as password
    Private Sub PasswordTB_TextChanged(sender As Object, e As EventArgs) Handles PasswordTB.TextChanged
        PasswordTB.UseSystemPasswordChar = True
    End Sub

    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles BackBTN.Click
        Dim Obj = New Emp_Order
        Obj.Show()
        Me.Hide()
        Reset()
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Application.Exit()
    End Sub
End Class
