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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Wallex1 = New Game.Wallex()
        Me.PlayerAva1 = New Game.PlayerAva()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
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
        Me.PlayerAva1.Location = New System.Drawing.Point(95, 165)
        Me.PlayerAva1.Mvmspeed = 5
        Me.PlayerAva1.Name = "PlayerAva1"
        Me.PlayerAva1.Size = New System.Drawing.Size(90, 102)
        Me.PlayerAva1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1480, 638)
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
End Class
