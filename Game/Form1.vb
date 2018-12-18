Imports System.Net.Sockets
Imports System.IO
Imports System.Net
Imports System.Threading
Public Class Form1
    Dim key As KeyPressEventArgs
    Dim hc As Boolean
    Dim turn As String

    Sub Chose()
        Dim pal As New PlayerAva With {
           .Left = 50,
           .Top = 50,
            .Visible = True,
        .type = "Paladin"
        }
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'PlayerAva1.Movement(e)
        key = e
        PlayerAva1.keyPressed = True
        ' If (PlayerAva1.Left + PlayerAva1.Width) > Wallex1.Left Then
        'MsgBox("T")
        'End If

    End Sub


    Private Sub Wallex1_Load(sender As Object, e As EventArgs) Handles Wallex1.Load
        Tm1.Start()
    End Sub

    Private Sub Wallex1_Click(sender As Object, e As EventArgs) Handles Wallex1.Click
        Hitpointsbar1.Update(PlayerAva1)
    End Sub

    Private Sub Wallex1_DoubleClick(sender As Object, e As EventArgs) Handles Wallex1.DoubleClick
        PlayerAva1.Hitpoints += -1
        Hitpointsbar1.Update(PlayerAva1)
    End Sub

    Private Sub Tm1_Tick(sender As Object, e As EventArgs) Handles Tm1.Tick
        '  Dim ListenerThread As New Thread(New ThreadStart(AddressOf Host_Start))
        ' If Not ListenerThread.IsAlive Then ListenerThread.Start()

        If PlayerAva1.keyPressed = True Then
            PlayerAva1.Movement(key)
        End If
    End Sub
    Sub Host_Start()
        Dim h As New Host("10.24.81.72")
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        PlayerAva1.keyPressed = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hitpointsbar1.Update(PlayerAva1)
        PlayerAva1.Mvmspeed = 5
        Chose()




    End Sub

    Private Sub btnBattleUI_Click(sender As Object, e As EventArgs) Handles btnBattleUI.Click
        Battleui1.inta(PlayerAva1)
        Battleui1.Width = Me.Width
        Battleui1.Height = Me.Height
        Battleui1.Left = 0
        Battleui1.Top = 55
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayerAva1.type = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




    End Sub
End Class
