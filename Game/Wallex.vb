﻿Public Class Wallex
    Private Sub UserControl1_Load(sender As Object, e As EventArgs)

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


        'If obj.Left < Me.Left AndAlso Me.Left < obj.Left + obj.Width AndAlso obj.Left < Me.Left + Me.Width AndAlso Me.Left + Me.Width < obj.Left + obj.Width Then
        'Return False
        ' Else
        'Return True
        'End If






    End Function
    ' Overloads Function Right(obj As Wallex) As Integer
    'Return obj.Left + obj.Width
    ' End Function
    ' Overloads Function Right(obj As PlayerAva) As Integer
    'Return obj.Left + obj.Width
    'End Function

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
