<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Enemy
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.EnTmr = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.Transparent
        Me.PicBox.ImageLocation = ""
        Me.PicBox.InitialImage = Global.Game.My.Resources.Resources.Orc_Idle
        Me.PicBox.Location = New System.Drawing.Point(0, 0)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(120, 150)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox.TabIndex = 0
        Me.PicBox.TabStop = False
        '
        'EnTmr
        '
        Me.EnTmr.Enabled = True
        Me.EnTmr.Interval = 1
        '
        'Enemy
        '
        Me.Controls.Add(Me.PicBox)
        Me.Name = "Enemy"
        Me.Size = New System.Drawing.Size(120, 150)
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Clock As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents EnTmr As Timer
End Class
