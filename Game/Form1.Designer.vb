<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Wallex1 = New Game.Wallex()
        Me.PlayerAva1 = New Game.PlayerAva()
        Me.Hitpointsbar1 = New Game.Hitpointsbar()
        Me.Tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.Battleui1 = New Game.Battleui()
        Me.btnBattleUI = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Wallex1
        '
        Me.Wallex1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wallex1.Location = New System.Drawing.Point(365, 165)
        Me.Wallex1.Name = "Wallex1"
        Me.Wallex1.Size = New System.Drawing.Size(181, 81)
        Me.Wallex1.TabIndex = 1
        '
        'PlayerAva1
        '
        Me.PlayerAva1.AutoSize = True
        Me.PlayerAva1.BackColor = System.Drawing.Color.Transparent
        Me.PlayerAva1.Hitpoints = 20
        Me.PlayerAva1.keyPressed = False
        Me.PlayerAva1.Location = New System.Drawing.Point(103, 135)
        Me.PlayerAva1.Max_Hitpoints = 20
        Me.PlayerAva1.Mvmspeed = 5
        Me.PlayerAva1.Name = "PlayerAva1"
        Me.PlayerAva1.pname = Nothing
        Me.PlayerAva1.PositionXY = New Integer() {0, 0, 0}
        Me.PlayerAva1.Size = New System.Drawing.Size(104, 126)
        Me.PlayerAva1.TabIndex = 0
        Me.PlayerAva1.type = "Cleric"
        '
        'Hitpointsbar1
        '
        Me.Hitpointsbar1.BackColor = System.Drawing.Color.Transparent
        Me.Hitpointsbar1.current = 0
        Me.Hitpointsbar1.Location = New System.Drawing.Point(12, 12)
        Me.Hitpointsbar1.max = 0
        Me.Hitpointsbar1.Name = "Hitpointsbar1"
        Me.Hitpointsbar1.Size = New System.Drawing.Size(262, 43)
        Me.Hitpointsbar1.TabIndex = 2
        '
        'Tm1
        '
        Me.Tm1.Interval = 1
        '
        'Battleui1
        '
        Me.Battleui1.Location = New System.Drawing.Point(32, 316)
        Me.Battleui1.Name = "Battleui1"
        Me.Battleui1.Size = New System.Drawing.Size(841, 399)
        Me.Battleui1.TabIndex = 3
        Me.Battleui1.Visible = False
        '
        'btnBattleUI
        '
        Me.btnBattleUI.Location = New System.Drawing.Point(12, 61)
        Me.btnBattleUI.Name = "btnBattleUI"
        Me.btnBattleUI.Size = New System.Drawing.Size(96, 23)
        Me.btnBattleUI.TabIndex = 4
        Me.btnBattleUI.Text = "Show Battle UI"
        Me.btnBattleUI.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(346, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(560, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1284, 638)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBattleUI)
        Me.Controls.Add(Me.Battleui1)
        Me.Controls.Add(Me.Hitpointsbar1)
        Me.Controls.Add(Me.Wallex1)
        Me.Controls.Add(Me.PlayerAva1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PlayerAva1 As PlayerAva
    Friend WithEvents Wallex1 As Wallex
    Friend WithEvents Hitpointsbar1 As Hitpointsbar
    Friend WithEvents Tm1 As Timer
    Friend WithEvents Battleui1 As Battleui
    Friend WithEvents btnBattleUI As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
