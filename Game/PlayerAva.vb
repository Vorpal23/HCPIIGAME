Imports System.IO

Public Class PlayerAva
    Dim ClockC As Integer= 1
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            ' Make background transparent
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H20
            Return cp
        End Get
    End Property
    Sub attack_Ani()
Load_Ani:
        Dim img(9) As Image

        Clock.Interval = (1000 / 5)
        Clock.Start()
        Dim c As Integer
        c = TimeOfDay.Second
        Do While TimeOfDay.Second - c < 2
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Jorda\source\repos\Game\Game\Imgs\Attack\PA-1.gif", True)
        Loop

        PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Jorda\source\repos\Game\Game\Imgs\Idle\PI 1.png", True)


        '"C:\Users\Jorda\source\repos\Game\Game\obj\Debug\Imgs\Attack\PA 1.png"

    End Sub
    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        '' call MyBase.OnPaintBackground(e) only if the backColor is not Color.Transparent
        If Me.BackColor <> Color.Transparent Then
            MyBase.OnPaintBackground(e)
        End If


    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Jorda\source\repos\Game\Game\Imgs\Idle\PI " + Trim(Str(1)) + ".png")
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom

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
