Public Class Battleui
    Private Sub Battleui_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub inta(ply As PlayerAva)
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
        Form1.PlayerAva1.Mvmspeed = 5
    End Sub
End Class
