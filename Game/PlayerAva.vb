Imports System.IO

Public Class PlayerAva
    '// Property declarations
    Property Mvmspeed As Integer = 5
    Property Hitpoints As Integer
    Property Max_Hitpoints As Integer = 20
    Property keyPressed As Boolean
    Property PositionXY As Integer()
    Property wep As Item
    Property pname As String
    Property type As String = "Cleric"
    Dim canMove As Boolean = True
    '// Global Declarations ( ONLY USED IN THIS CLASS ) 
    Dim walk As Boolean


    Structure position ' This is a better way of handeling positions IMO FUCK IT DONT WORK LIKE THAT
        Dim x As Integer
        Dim y As Integer
    End Structure

    Function Walk_Img() As Image
            Dim out As Image
            Select Case Type
                Case "Paladin"
                    out = My.Resources.Paladin_walk
                Case "Wizard"
                    out = My.Resources.Wizard_Walk
                Case "Cleric"
                    out = My.Resources.Cleric_Walk
                Case Else
                MsgBox("Class Invalid")

                End
        End Select
            Return out
        End Function
        Function Attack_Img() As Image
            Dim out As Image
            Select Case Type
                Case "Paladin"
                    out = My.Resources.Paladin_attack
                Case "Wizard"
                    out = My.Resources.Wizard_Attack
                Case "Cleric"
                    out = My.Resources.Cleric_Attack
                Case Else
                MsgBox("Class Invalid")
                End
        End Select
            Return out

        End Function
        Function Idle_Img() As Image
            Dim out As Image
            Select Case Type
                Case "Paladin"
                    out = My.Resources.Paladin_Idle
                Case "Wizard"
                    out = My.Resources.Wizard_Idle
                Case "Cleric"
                    out = My.Resources.Cleric_Idle
                Case Else
                MsgBox("Class Invalid")
                End
        End Select
            Return out
        End Function

    Structure Item ' provides a structure for items Mainly weapons
        Dim AP As Integer ' attack Points
        Dim name As String ' item Name
    End Structure
    Async Sub Movement(KEY As KeyPressEventArgs)
        Dim k As String = LCase(KEY.KeyChar)
        Dim X As Integer = Me.Left
        Dim Y As Integer = Me.Top

        If k = "w" Then
            If Form1.Wallex1.Can_Move_Ver(Me, -1 * Mvmspeed) Then
                Me.Top = Me.Top - Mvmspeed
                'If Not Form1.Wallex1.Can_Move_Ver(Me, -1 * Mvmspeed) Then
                '    Me.Top = Me.Top + 2 * Mvmspeed
                'End If
            End If
            CheckCol(0)
        End If

        If k = "s" Then
            If Form1.Wallex1.Can_Move_Ver(Me, Mvmspeed) Then
                Me.Top = Me.Top + Mvmspeed
                'If Not Form1.Wallex1.Can_Move_Ver(Me, Mvmspeed) Then
                '    Me.Top = Me.Top - 2 * Mvmspeed
                'End If
            End If
            CheckCol(1)
        End If

        If k = "a" Then
            If Form1.Wallex1.Can_Move_Hor(Me, -1 * Mvmspeed) Then
                Me.Left = Me.Left - Mvmspeed
                'If Not Form1.Wallex1.Can_Move_Hor(Me, -1 * Mvmspeed) Then
                '    Me.Left = Me.Left + 2 * Mvmspeed
                'End If
            End If
            CheckCol(2)
        End If

        If k = "d" Then
            If Form1.Wallex1.Can_Move_Hor(Me, Mvmspeed) Then
                Me.Left = Me.Left + Mvmspeed
                'If Not Form1.Wallex1.Can_Move_Hor(Me, -Mvmspeed) Then
                '    Me.Left = Me.Left - 2 * Mvmspeed
                'End If
            End If
            CheckCol(3)
        End If






        If Mvmspeed <> 0 Then
            walk = True
        Else
            walk = False
        End If
        'While walk
        '    'If Not PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif" And walk = True Then PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif"

        '    Clock.Interval = (1000 / 5)
        '    Clock.Start()
        '    walk = False
        'End While
        'If Not PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif" And walk = True Then PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Imgs\Walk\Pw.gif"



    End Sub

    Async Sub CheckCol(id As Integer)
        'Check if touching any walls
        For c = 0 To UBound(Form1.walls)
            Dim wall As Wallex = Form1.walls(c)
            Select Case id
                Case 0 'Top
                    If Not wall.Can_Move_Ver(Me, -1 * Mvmspeed) Then
                        Me.Top = Me.Top + 2 * Mvmspeed
                    End If
                Case 1 'Bottom
                    If Not wall.Can_Move_Ver(Me, Mvmspeed) Then
                        Me.Top = Me.Top - 2 * Mvmspeed
                    End If
                Case 2 'Left
                    If Not wall.Can_Move_Hor(Me, -1 * Mvmspeed) Then
                        Me.Left = Me.Left + 2 * Mvmspeed
                    End If
                Case 3 'Right
                    If Not wall.Can_Move_Hor(Me, -Mvmspeed) Then
                        Me.Left = Me.Left - 2 * Mvmspeed
                    End If
            End Select
        Next

        For c = 0 To UBound(Form1.enemies)
            Dim en As Enemy = Form1.enemies(c)
            Select Case id
                Case 0 'Top
                    If Not en.Can_Move_Ver(Me, -1 * Mvmspeed) Then
                        Me.Top = Me.Top + 2 * Mvmspeed
                    End If
                Case 1 'Bottom
                    If Not en.Can_Move_Ver(Me, Mvmspeed) Then
                        Me.Top = Me.Top - 2 * Mvmspeed
                    End If
                Case 2 'Left
                    If Not en.Can_Move_Hor(Me, -1 * Mvmspeed) Then
                        Me.Left = Me.Left + 2 * Mvmspeed
                    End If
                Case 3 'Right
                    If Not en.Can_Move_Hor(Me, -Mvmspeed) Then
                        Me.Left = Me.Left - 2 * Mvmspeed
                    End If
            End Select
        Next
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReDim PositionXY(2)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

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

        PictureBox1.Image = Attack_Img()
        Wait(550)
        ' PictureBox1.BackColor = Color.Black
        'Wait(5)
        'PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = Idle_Img()
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
        PictureBox1.Image = Idle_Img()
        Max_Hitpoints = 20
        Hitpoints = 20
    End Sub

    Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
        ClockC += 1
        If keyPressed = True And PictureBox1.Image.Width <> Walk_Img().Width Then
            PictureBox1.Image = Walk_Img()
        ElseIf keyPressed = False Then
            PictureBox1.Image = Idle_Img()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Attack_Ani()
    End Sub

End Class
