Imports System.IO

Public Class Enemy
    '// Property declarations
    Property Mvmspeed As Integer = 5
    Property Hitpoints As Integer
    Property Max_Hitpoints As Integer = 20
    Property PositionXY As Integer()
    Property Damage As Integer = 5
    Dim tickCount As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReDim PositionXY(2)
        PicBox.Image = My.Resources.Orc_Idle
        PicBox.SizeMode = PictureBoxSizeMode.Zoom

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub MoveAround()
        Dim MoveDir As Integer
        Select Case MoveDir
            Case 0 'Move up
                Me.Top = Me.Top + Mvmspeed
            Case 1 'Move Left
                Me.Left = Me.Left + Mvmspeed
            Case 2 'Move Right
                Me.Left = Me.Left - Mvmspeed
            Case 3 'Move Down
                Me.Top = Me.Top - Mvmspeed
        End Select

        'Messing with direction
        If MoveDir <= 3 Then
            MoveDir += 1
        Else
            MoveDir = 0
        End If
    End Sub

    Function Can_Move_Hor(obj As PlayerAva, Mvmspeed As Integer) As Boolean


        If obj.Top + Mvmspeed + 1 < Me.Top + Me.Height AndAlso obj.Top + obj.Height > Me.Top Then
            If obj.Right > Me.Left AndAlso obj.Left < Me.Right Then
                Return False
            Else
                Return True
            End If
        Else
            Return True

        End If
    End Function

    Function Can_Move_Ver(obj As PlayerAva, Mvmspeed As Integer) As Boolean
        If obj.Right + Mvmspeed + 1 > Me.Left AndAlso obj.Left < Me.Right Then

            If obj.Top < Me.Bottom AndAlso obj.Bottom > Me.Top Then
                Return False
            Else
                Return True
            End If
        Else
            Return True

        End If
    End Function

    Private Sub EnTmr_Tick(sender As Object, e As EventArgs) Handles EnTmr.Tick
        If tickCount <= 5 Then
            tickCount += 1
        Else
            MoveAround()
            tickCount = 0
        End If
    End Sub
End Class