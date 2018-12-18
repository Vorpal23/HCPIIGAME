Imports System.IO

Public Class Enemy
    '// Property declarations
    Property Mvmspeed As Integer = 5
    Property Hitpoints As Integer
    Property Max_Hitpoints As Integer = 20
    Property PositionXY As Integer()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReDim PositionXY(2)
        PicBox.Image = My.Resources.Orc_Idle
        PicBox.SizeMode = PictureBoxSizeMode.Zoom

        ' Add any initialization after the InitializeComponent() call.

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
End Class