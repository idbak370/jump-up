<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.win = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.win, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'win
        '
        Me.win.Image = Global.yeah.My.Resources.Resources.dd95bk8_442eb0ea_9592_47d1_99fc_2e88b922ffaf
        Me.win.Location = New System.Drawing.Point(738, 12)
        Me.win.Name = "win"
        Me.win.Size = New System.Drawing.Size(274, 400)
        Me.win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.win.TabIndex = 0
        Me.win.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 630)
        Me.Controls.Add(Me.win)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.win, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents win As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
