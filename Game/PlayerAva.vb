Imports System.IO

Public Class PlayerAva
    Property Mvmspeed As Integer = 5

    Sub Movement(KEY As KeyPressEventArgs)
        Dim k As String = LCase(KEY.KeyChar)
        If k = "w" Then Me.Top = Me.Top - Mvmspeed
        If k = "s" Then Me.Top = Me.Top + Mvmspeed
        If k = "a" Then Me.Left = Me.Left - Mvmspeed
        If k = "d" Then Me.Left = Me.Left + Mvmspeed
    End Sub

    Private Sub Wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
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

        PictureBox1.ImageLocation = "C:\Users\Jorda\source\repos\Game\Game\Imgs\Attack\PA-1.gif"
        Wait(550)
        ' PictureBox1.BackColor = Color.Black
        'Wait(5)
        'PictureBox1.BackColor = Color.Transparent
        PictureBox1.ImageLocation = "C:\Users\Jorda\source\repos\Game\Game\Imgs\Idle\PI 1.png"
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

        PictureBox1.BackColor = Color.Transparent
        PictureBox1.ImageLocation = "C:\Users\Jorda\source\repos\Game\Game\Imgs\Idle\PI 1.png"
    End Sub

    Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
        ClockC += 1

    End Sub

    Private Sub Clock_Disposed(sender As Object, e As EventArgs) Handles Clock.Disposed

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        attack_Ani()
    End Sub
End Class
