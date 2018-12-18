Public Class Multiplayer
    Public Sub New(path As String, people As Integer)
        Me.path = path
    End Sub
    Property path As String
    Property Turn As String
    Property Count As Integer
    Sub Take_trun(Obj As PlayerAva)
        Dim player1 As String
        Dim player2 As String
        Dim player3 As String

        FileOpen(1, path, OpenMode.Input, OpenAccess.ReadWrite)
        player1 = LineInput(1)
        player2 = LineInput(1)
        player3 = LineInput(1)


    End Sub
    Sub Turn_Advance()

    End Sub
End Class
