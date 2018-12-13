<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Battleui
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnHide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(12, 6)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(96, 23)
        Me.btnHide.TabIndex = 0
        Me.btnHide.Text = "Hide Battle UI"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'Battleui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnHide)
        Me.Name = "Battleui"
        Me.Size = New System.Drawing.Size(841, 399)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHide As Button
End Class
