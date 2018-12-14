Public Class Battleui
    Dim tempL As Single, tempT As Single
    Dim paladin As PlayerAva
    Sub inta(ply As PlayerAva)
        Me.Show()
        tempL = ply.Left
        tempT = ply.Top
        paladin = ply
        'Should probably move players to a designated position
        'Turn on a battle flag
        ply.Left = 200
        ply.Top = 200
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Hide()
        paladin.Left = tempL
        paladin.Top = tempT
        Form1.PlayerAva1.Mvmspeed = 5
    End Sub
End Class
