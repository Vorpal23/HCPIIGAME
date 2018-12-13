Imports System.Net.Sockets
Imports System.IO
Imports System.Net

Public Class Form1
    Dim key As KeyPressEventArgs
    Dim tc As TcpClient = New TcpClient()
    Dim ns As NetworkStream
    Dim br As BinaryReader
    Dim bw As BinaryWriter
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
    Private Sub PlayerAva1_Load(sender As Object, e As EventArgs)
        PlayerAva1.BackgroundImage = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath + "\Imgs\Idle\PI 1.png")
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

        If PlayerAva1.keyPressed = True Then
            PlayerAva1.Movement(key)
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        PlayerAva1.keyPressed = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hitpointsbar1.Update(PlayerAva1)
        PlayerAva1.Mvmspeed = 5
        'TCPServerHOST.Main()
        Me.Show()

        tc.Connect(“10.24.81.72”, 8888)
        ns = tc.GetStream
        br = New BinaryReader(ns)
        bw = New BinaryWriter(ns)


        MsgBox(br.ReadString)

    End Sub

    Private Sub btnBattleUI_Click(sender As Object, e As EventArgs) Handles btnBattleUI.Click
        Battleui1.inta(PlayerAva1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ns = tc.GetStream
        br = New BinaryReader(ns)
        bw = New BinaryWriter(ns)
        bw.Write(TextBox1.Text)
    End Sub
End Class
