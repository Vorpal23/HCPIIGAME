Public Class Form1
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub PlayerAva1_Load(sender As Object, e As EventArgs) Handles PlayerAva1.Load
        PlayerAva1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\Jorda\source\repos\Game\Game\Imgs\Idle\PI 1.png")
    End Sub
End Class
