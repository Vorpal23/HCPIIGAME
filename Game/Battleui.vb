Public Class Battleui
    Dim Player As PlayerAva
    Private Sub Battleui_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub inta(ply As PlayerAva)
        Me.Show()
        Player = ply
        Player.Mvmspeed = 0
        Player.PositionXY(1) = Player.Left
        Player.PositionXY(2) = Player.Top
        Player.Top = 200
        Player.Left = 200
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
        'paladin.Left = tempL
        ' paladin.Top = tempT
        Form1.PlayerAva1.Mvmspeed = 5
        Player.Left = Player.PositionXY(1)
        Player.Top = Player.PositionXY(2)
    End Sub

    Private Sub btFight_Click(sender As Object, e As EventArgs) Handles btFight.Click

    End Sub
End Class
