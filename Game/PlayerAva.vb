Imports System.IO

Public Class PlayerAva
    Property Mvmspeed As Integer = 5
    Property Hitpoints As Integer
    Property Max_Hitpoints As Integer = 20
    Public keyPressed As Boolean
    Dim walk As Boolean

    Async Sub Movement(KEY As KeyPressEventArgs)
        Dim k As String = LCase(KEY.KeyChar)
        Dim X As Integer = Me.Left
        Dim Y As Integer = Me.Top

        If k = "w" Then
            Y = Me.Top - Mvmspeed
            If Form1.Wallex1.Can_Move_Ver(Me) Then
                Me.Top = Y
                Me.Left = X
            Else
                Me.Top = Y + (Mvmspeed + 1)

            End If
        End If
        If k = "s" Then
            Y = Me.Top + Mvmspeed
            If Form1.Wallex1.Can_Move_Ver(Me) Then
                Me.Top = Y
                Me.Left = X
            Else
                Me.Top = Y - (Mvmspeed + 1)

            End If
        End If
        If k = "a" Then
            X = Me.Left - Mvmspeed
            If Form1.Wallex1.Can_Move_Hor(Me) Then
                Me.Top = Y
                Me.Left = X
            Else

                Me.Left = X + (Mvmspeed + 1)
            End If
        End If
        If k = "d" Then

            X = Me.Left + Mvmspeed
            If Form1.Wallex1.Can_Move_Hor(Me) Then
                Me.Top = Y
                Me.Left = X
            Else





                Me.Left = X - (Mvmspeed + 1)
            End If
        End If
        walk = True
        'While walk
        '    'If Not PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif" And walk = True Then PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif"

        '    Clock.Interval = (1000 / 5)
        '    Clock.Start()
        '    walk = False
        'End While
        'If Not PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif" And walk = True Then PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif"


        'PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Idle\PI.gif"

    End Sub

    Private Sub Wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Restart()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Reset()
    End Sub
    Dim ClockC As Integer = 1
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            ' Make background transparent
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H20
            Return cp
        End Get
    End Property
    Sub Attack_Ani()
Load_Ani:
        Dim img(9) As Image

        Clock.Interval = (1000 / 5)
        Clock.Start()



        'PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Jorda\source\repos\Game\Game\Imgs\Attack\PA-1.gif", True)

        PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Attack\PA.gif"
        Wait(550)
        ' PictureBox1.BackColor = Color.Black
        'Wait(5)
        'PictureBox1.BackColor = Color.Transparent
        PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Idle\PI.gif"
        'System.Drawing.Image.FromFile("C:\Users\Jorda\source\repos\Game\Game\Imgs\Idle\PI 1.png", True)


        '"C:\Users\Jorda\source\repos\Game\Game\obj\Debug\Imgs\Attack\PA 1.png"

    End Sub
    'Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
    '' call MyBase.OnPaintBackground(e) only if the backColor is not Color.Transparent
    'If Me.BackColor <> Color.Transparent Then
    'MyBase.OnPaintBackground(e)
    'End If


    ' End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.Transparent
        ' PictureBox1.BackColor = Color.Transparent
        Clock.Start()
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Idle\PI.gif"
        Max_Hitpoints = 20
        Hitpoints = 20
    End Sub

    Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
        ClockC += 1
        If keyPressed = True And PictureBox1.ImageLocation <> My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif" Then
            PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif"
        ElseIf keyPressed = False And PictureBox1.ImageLocation <> My.Application.Info.DirectoryPath + "\Imgs\Idle\PI.gif" Then
            PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Idle\PI.gif"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        attack_Ani()
    End Sub
End Class
