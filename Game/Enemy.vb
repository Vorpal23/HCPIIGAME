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

End Class