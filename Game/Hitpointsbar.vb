Public Class Hitpointsbar
    Property max As Integer
    Property current As Integer



    Sub laod() Handles MyBase.Load
        Dim d As Integer = PictureBox1.Width
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub Update(e As PlayerAva)
        current = e.Hitpoints
        max = e.Max_Hitpoints
        Label1.Text = Str(current) + "/" + Str(max)

        PictureBox1.Width = Me.Width * ((current / max))
    End Sub
End Class
