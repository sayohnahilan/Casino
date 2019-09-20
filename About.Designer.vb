<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.Info = New System.Windows.Forms.Label()
        Me.Hom = New System.Windows.Forms.Button()
        Me.Infotext = New System.Windows.Forms.Label()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Info
        '
        Me.Info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Info.AutoSize = True
        Me.Info.BackColor = System.Drawing.Color.Transparent
        Me.Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info.ForeColor = System.Drawing.Color.White
        Me.Info.Location = New System.Drawing.Point(33, 36)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(234, 39)
        Me.Info.TabIndex = 36
        Me.Info.Text = "About Casino:"
        '
        'Hom
        '
        Me.Hom.BackColor = System.Drawing.Color.Transparent
        Me.Hom.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hom.Location = New System.Drawing.Point(397, 36)
        Me.Hom.Name = "Hom"
        Me.Hom.Size = New System.Drawing.Size(87, 44)
        Me.Hom.TabIndex = 38
        Me.Hom.Text = "Home"
        Me.Hom.UseVisualStyleBackColor = False
        '
        'Infotext
        '
        Me.Infotext.AutoSize = True
        Me.Infotext.BackColor = System.Drawing.Color.Transparent
        Me.Infotext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Infotext.ForeColor = System.Drawing.Color.White
        Me.Infotext.Location = New System.Drawing.Point(28, 187)
        Me.Infotext.Name = "Infotext"
        Me.Infotext.Size = New System.Drawing.Size(502, 100)
        Me.Infotext.TabIndex = 39
        Me.Infotext.Text = "Created by: Sayohn Ahilan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Environment: Microsoft Visual Studio Express 2012" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wor" & _
    "kspace: Colonel By Secondary School" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Project Manager: Cameron Baird"
        Me.Infotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Background
        '
        Me.Background.BackgroundImage = Global.Casino.My.Resources.Resources.Casino_Background
        Me.Background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.MaximumSize = New System.Drawing.Size(558, 405)
        Me.Background.MinimumSize = New System.Drawing.Size(558, 405)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(558, 405)
        Me.Background.TabIndex = 23
        Me.Background.TabStop = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.Infotext)
        Me.Controls.Add(Me.Hom)
        Me.Controls.Add(Me.Info)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 444)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 444)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents Info As System.Windows.Forms.Label
    Friend WithEvents Hom As System.Windows.Forms.Button
    Friend WithEvents Infotext As System.Windows.Forms.Label
End Class
