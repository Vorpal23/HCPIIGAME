Imports System.IO

Public Class Enemy
    '// Property declarations
    Property Mvmspeed As Integer = 5
    Property Hitpoints As Integer
    Property Max_Hitpoints As Integer = 20
    Property PositionXY As Integer()
    Property wep As Item
    Property ename As String
    '// Global Declarations ( ONLY USED IN THIS CLASS ) 
    Dim walk As Boolean


    Structure position ' This is a better way of handeling positions IMO FUCK IT DONT WORK LIKE THAT
        Dim x As Integer
        Dim y As Integer
    End Structure

    Structure Item ' provides a structure for items Mainly weapons
        Dim AP As Integer ' attack Points
        Dim name As String ' item Name
    End Structure

    Public Sub New()

        ' This call is required by the designer.
        ReDim PositionXY(2)

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
