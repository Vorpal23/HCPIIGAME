Public Class Multiplayer
    Public Sub New(path As String, people As Integer)
        Me.path = path
    End Sub
    Property path As String
    Property Turn As String
    Property Count As Integer
    Sub Take_trun(p1 As PlayerAva, p2 As PlayerAva, p3 As PlayerAva)
        Dim player1 As String
        Dim player2 As String
        Dim player3 As String

        FileOpen(1, path, OpenMode.Input, OpenAccess.ReadWrite)
        player1 = LineInput(1)
        player2 = LineInput(1)
        player3 = LineInput(1)
        With p1 '// we start by updateing the player Pos
            .Top = Val(player1.Split(",")(2))
            .Left = Val(player1.Split(",")(3))
            .Hitpoints = Val(player1.Split(",")(1))
        End With
        '// Format ,HP,Top,Left
        With p2
            .Top = Val(player2.Split(",")(2))
            .Left = Val(player2.Split(",")(3))
            .Hitpoints = Val(player2.Split(",")(1))
        End With
        With p3
            .Top = Val(player3.Split(",")(2))
            .Left = Val(player3.Split(",")(3))
            .Hitpoints = Val(player3.Split(",")(1))
        End With
        FileClose(1)
        '// TURN CODE


        '// Advance the turn
    End Sub
    Sub Turn_Advance(p1 As PlayerAva, p2 As PlayerAva, p3 As PlayerAva)
        Dim player1 As String
        Dim player2 As String
        Dim player3 As String
        Kill(path)

        FileOpen(1, path, OpenMode.Input, OpenAccess.ReadWrite)

        With p1 '// we start by updateing the player Pos
            player1 = player1 + "," + .Hitpoints + "," + .Top + "," + .Left

        End With
        '// Format ,HP,Top,Left
        With p2
            player2 = player2 + "," + .Hitpoints + "," + .Top + "," + .Left
        End With
        With p3
            player3 = player3 + "," + .Hitpoints + "," + .Top + "," + .Left
        End With
        WriteLine(1, player1)
        WriteLine(1, player2)
        WriteLine(1, player3)


    End Sub
End Class
