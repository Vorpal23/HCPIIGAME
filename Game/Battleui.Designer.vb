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
        Me.btFight = New System.Windows.Forms.Button()
        Me.btSpecial = New System.Windows.Forms.Button()
        Me.btItem = New System.Windows.Forms.Button()
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
        'btFight
        '
        Me.btFight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFight.Location = New System.Drawing.Point(12, 327)
        Me.btFight.Name = "btFight"
        Me.btFight.Size = New System.Drawing.Size(170, 59)
        Me.btFight.TabIndex = 1
        Me.btFight.Text = "FIGHT"
        Me.btFight.UseVisualStyleBackColor = True
        '
        'btSpecial
        '
        Me.btSpecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSpecial.Location = New System.Drawing.Point(201, 327)
        Me.btSpecial.Name = "btSpecial"
        Me.btSpecial.Size = New System.Drawing.Size(170, 59)
        Me.btSpecial.TabIndex = 2
        Me.btSpecial.Text = "FEATS"
        Me.btSpecial.UseVisualStyleBackColor = True
        '
        'btItem
        '
        Me.btItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btItem.Location = New System.Drawing.Point(388, 327)
        Me.btItem.Name = "btItem"
        Me.btItem.Size = New System.Drawing.Size(170, 59)
        Me.btItem.TabIndex = 3
        Me.btItem.Text = "ITEM"
        Me.btItem.UseVisualStyleBackColor = True
        '
        'Battleui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btItem)
        Me.Controls.Add(Me.btSpecial)
        Me.Controls.Add(Me.btFight)
        Me.Controls.Add(Me.btnHide)
        Me.Name = "Battleui"
        Me.Size = New System.Drawing.Size(1300, 621)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHide As Button
    Friend WithEvents btFight As Button
    Friend WithEvents btSpecial As Button
    Friend WithEvents btItem As Button
End Class
