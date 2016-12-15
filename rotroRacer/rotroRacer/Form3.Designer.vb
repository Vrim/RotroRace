<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShipSelection
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
        Me.picShipTitle = New System.Windows.Forms.PictureBox()
        Me.picShip1 = New System.Windows.Forms.PictureBox()
        Me.picShip2 = New System.Windows.Forms.PictureBox()
        Me.picShip3 = New System.Windows.Forms.PictureBox()
        Me.picShip4 = New System.Windows.Forms.PictureBox()
        Me.picShip5 = New System.Windows.Forms.PictureBox()
        Me.picShip6 = New System.Windows.Forms.PictureBox()
        CType(Me.picShipTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShip6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picShipTitle
        '
        Me.picShipTitle.BackColor = System.Drawing.Color.Black
        Me.picShipTitle.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_ship_selection_title_65pt
        Me.picShipTitle.Location = New System.Drawing.Point(12, 12)
        Me.picShipTitle.Name = "picShipTitle"
        Me.picShipTitle.Size = New System.Drawing.Size(396, 65)
        Me.picShipTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picShipTitle.TabIndex = 0
        Me.picShipTitle.TabStop = False
        '
        'picShip1
        '
        Me.picShip1.BackColor = System.Drawing.Color.Transparent
        Me.picShip1.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_space_shuttle
        Me.picShip1.Location = New System.Drawing.Point(12, 117)
        Me.picShip1.Name = "picShip1"
        Me.picShip1.Size = New System.Drawing.Size(150, 150)
        Me.picShip1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShip1.TabIndex = 1
        Me.picShip1.TabStop = False
        '
        'picShip2
        '
        Me.picShip2.BackColor = System.Drawing.Color.Transparent
        Me.picShip2.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_space_shuttle21
        Me.picShip2.Location = New System.Drawing.Point(307, 117)
        Me.picShip2.Name = "picShip2"
        Me.picShip2.Size = New System.Drawing.Size(150, 150)
        Me.picShip2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShip2.TabIndex = 2
        Me.picShip2.TabStop = False
        '
        'picShip3
        '
        Me.picShip3.BackColor = System.Drawing.Color.Transparent
        Me.picShip3.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_space_shuttle31
        Me.picShip3.Location = New System.Drawing.Point(590, 117)
        Me.picShip3.Name = "picShip3"
        Me.picShip3.Size = New System.Drawing.Size(150, 150)
        Me.picShip3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShip3.TabIndex = 3
        Me.picShip3.TabStop = False
        '
        'picShip4
        '
        Me.picShip4.BackColor = System.Drawing.Color.Transparent
        Me.picShip4.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_space_shuttle41
        Me.picShip4.Location = New System.Drawing.Point(12, 358)
        Me.picShip4.Name = "picShip4"
        Me.picShip4.Size = New System.Drawing.Size(150, 150)
        Me.picShip4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShip4.TabIndex = 4
        Me.picShip4.TabStop = False
        '
        'picShip5
        '
        Me.picShip5.BackColor = System.Drawing.Color.Transparent
        Me.picShip5.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_space_shuttle5
        Me.picShip5.Location = New System.Drawing.Point(307, 358)
        Me.picShip5.Name = "picShip5"
        Me.picShip5.Size = New System.Drawing.Size(150, 150)
        Me.picShip5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShip5.TabIndex = 5
        Me.picShip5.TabStop = False
        '
        'picShip6
        '
        Me.picShip6.BackColor = System.Drawing.Color.Transparent
        Me.picShip6.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_space_shuttle6
        Me.picShip6.Location = New System.Drawing.Point(590, 358)
        Me.picShip6.Name = "picShip6"
        Me.picShip6.Size = New System.Drawing.Size(150, 150)
        Me.picShip6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShip6.TabIndex = 6
        Me.picShip6.TabStop = False
        '
        'frmShipSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.rotroRacer.My.Resources.Resources.rotro_racer_ship_selection_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.picShip6)
        Me.Controls.Add(Me.picShip5)
        Me.Controls.Add(Me.picShip4)
        Me.Controls.Add(Me.picShip3)
        Me.Controls.Add(Me.picShip2)
        Me.Controls.Add(Me.picShip1)
        Me.Controls.Add(Me.picShipTitle)
        Me.Name = "frmShipSelection"
        Me.Text = "Ship Selection"
        CType(Me.picShipTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShip6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picShipTitle As PictureBox
    Friend WithEvents picShip1 As PictureBox
    Friend WithEvents picShip2 As PictureBox
    Friend WithEvents picShip3 As PictureBox
    Friend WithEvents picShip4 As PictureBox
    Friend WithEvents picShip5 As PictureBox
    Friend WithEvents picShip6 As PictureBox
End Class
