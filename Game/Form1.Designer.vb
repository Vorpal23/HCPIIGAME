<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBattleUI = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btNet = New System.Windows.Forms.Button()
        Me.Wallex2 = New Game.Wallex()
        Me.Enemy1 = New Game.Enemy()
        Me.PlayerAva3 = New Game.PlayerAva()
        Me.PlayerAva2 = New Game.PlayerAva()
        Me.Battleui1 = New Game.Battleui()
        Me.Hitpointsbar1 = New Game.Hitpointsbar()
        Me.Wallex1 = New Game.Wallex()
        Me.PlayerAva1 = New Game.PlayerAva()
        Me.btTake = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tm1
        '
        Me.Tm1.Interval = 1
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
        Me.TextBox1.Location = New System.Drawing.Point(280, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(485, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(926, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 148)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(17, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(17, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btNet
        '
        Me.btNet.Location = New System.Drawing.Point(431, 312)
        Me.btNet.Name = "btNet"
        Me.btNet.Size = New System.Drawing.Size(128, 78)
        Me.btNet.TabIndex = 12
        Me.btNet.Text = "NETWORK TEST"
        Me.btNet.UseVisualStyleBackColor = True
        '
        'Wallex2
        '
        Me.Wallex2.AutoSize = True
        Me.Wallex2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Wallex2.BackColor = System.Drawing.Color.Transparent
        Me.Wallex2.Location = New System.Drawing.Point(943, 423)
        Me.Wallex2.Name = "Wallex2"
        Me.Wallex2.Size = New System.Drawing.Size(240, 128)
        Me.Wallex2.TabIndex = 11
        '
        'Enemy1
        '
        Me.Enemy1.Hitpoints = 0
        Me.Enemy1.Location = New System.Drawing.Point(965, 251)
        Me.Enemy1.Max_Hitpoints = 20
        Me.Enemy1.Mvmspeed = 5
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.PositionXY = New Integer() {0, 0, 0}
        Me.Enemy1.Size = New System.Drawing.Size(108, 156)
        Me.Enemy1.TabIndex = 10
        '
        'PlayerAva3
        '
        Me.PlayerAva3.AutoSize = True
        Me.PlayerAva3.BackColor = System.Drawing.Color.Transparent
        Me.PlayerAva3.Hitpoints = 20
        Me.PlayerAva3.keyPressed = False
        Me.PlayerAva3.Location = New System.Drawing.Point(741, 123)
        Me.PlayerAva3.Max_Hitpoints = 20
        Me.PlayerAva3.Mvmspeed = 5
        Me.PlayerAva3.Name = "PlayerAva3"
        Me.PlayerAva3.pname = Nothing
        Me.PlayerAva3.PositionXY = New Integer() {0, 0, 0}
        Me.PlayerAva3.Size = New System.Drawing.Size(104, 126)
        Me.PlayerAva3.TabIndex = 9
        Me.PlayerAva3.type = "Cleric"
        '
        'PlayerAva2
        '
        Me.PlayerAva2.AutoSize = True
        Me.PlayerAva2.BackColor = System.Drawing.Color.Transparent
        Me.PlayerAva2.Hitpoints = 20
        Me.PlayerAva2.keyPressed = False
        Me.PlayerAva2.Location = New System.Drawing.Point(517, 118)
        Me.PlayerAva2.Max_Hitpoints = 20
        Me.PlayerAva2.Mvmspeed = 5
        Me.PlayerAva2.Name = "PlayerAva2"
        Me.PlayerAva2.pname = Nothing
        Me.PlayerAva2.PositionXY = New Integer() {0, 0, 0}
        Me.PlayerAva2.Size = New System.Drawing.Size(104, 126)
        Me.PlayerAva2.TabIndex = 8
        Me.PlayerAva2.type = "Cleric"
        '
        'Battleui1
        '
        Me.Battleui1.BackColor = System.Drawing.Color.Transparent
        Me.Battleui1.Location = New System.Drawing.Point(-8, 255)
        Me.Battleui1.Name = "Battleui1"
        Me.Battleui1.Size = New System.Drawing.Size(841, 399)
        Me.Battleui1.TabIndex = 3
        Me.Battleui1.Visible = False
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
        'Wallex1
        '
        Me.Wallex1.AutoSize = True
        Me.Wallex1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Wallex1.BackColor = System.Drawing.Color.Transparent
        Me.Wallex1.Location = New System.Drawing.Point(271, 118)
        Me.Wallex1.Name = "Wallex1"
        Me.Wallex1.Size = New System.Drawing.Size(240, 128)
        Me.Wallex1.TabIndex = 1
        '
        'PlayerAva1
        '
        Me.PlayerAva1.AutoSize = True
        Me.PlayerAva1.BackColor = System.Drawing.Color.Transparent
        Me.PlayerAva1.Hitpoints = 20
        Me.PlayerAva1.keyPressed = False
        Me.PlayerAva1.Location = New System.Drawing.Point(615, 123)
        Me.PlayerAva1.Max_Hitpoints = 20
        Me.PlayerAva1.Mvmspeed = 5
        Me.PlayerAva1.Name = "PlayerAva1"
        Me.PlayerAva1.pname = Nothing
        Me.PlayerAva1.PositionXY = New Integer() {0, 0, 0}
        Me.PlayerAva1.Size = New System.Drawing.Size(104, 126)
        Me.PlayerAva1.TabIndex = 0
        Me.PlayerAva1.type = "Paladin"
        '
        'btTake
        '
        Me.btTake.Location = New System.Drawing.Point(565, 312)
        Me.btTake.Name = "btTake"
        Me.btTake.Size = New System.Drawing.Size(128, 78)
        Me.btTake.TabIndex = 13
        Me.btTake.Text = "TAKE TURN"
        Me.btTake.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1276, 638)
        Me.Controls.Add(Me.btTake)
        Me.Controls.Add(Me.btNet)
        Me.Controls.Add(Me.Wallex2)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.PlayerAva3)
        Me.Controls.Add(Me.PlayerAva2)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents PlayerAva2 As PlayerAva
    Friend WithEvents PlayerAva3 As PlayerAva
    Friend WithEvents Enemy1 As Enemy
    Friend WithEvents Wallex2 As Wallex
    Friend WithEvents btNet As Button
    Friend WithEvents btTake As Button
End Class
