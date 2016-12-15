<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectionMenu
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
        Me.picSelectioinMenuTitle = New System.Windows.Forms.PictureBox()
        Me.picShipSelection = New System.Windows.Forms.PictureBox()
        Me.picOptions = New System.Windows.Forms.PictureBox()
        Me.picGameDetails = New System.Windows.Forms.PictureBox()
        Me.picExitGame = New System.Windows.Forms.PictureBox()
        CType(Me.picSelectioinMenuTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShipSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGameDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExitGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSelectioinMenuTitle
        '
        Me.picSelectioinMenuTitle.BackColor = System.Drawing.Color.Transparent
        Me.picSelectioinMenuTitle.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_selection_menu_logo
        Me.picSelectioinMenuTitle.Location = New System.Drawing.Point(12, 12)
        Me.picSelectioinMenuTitle.Name = "picSelectioinMenuTitle"
        Me.picSelectioinMenuTitle.Size = New System.Drawing.Size(413, 65)
        Me.picSelectioinMenuTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picSelectioinMenuTitle.TabIndex = 0
        Me.picSelectioinMenuTitle.TabStop = False
        '
        'picShipSelection
        '
        Me.picShipSelection.BackColor = System.Drawing.Color.Transparent
        Me.picShipSelection.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_choose_racer1
        Me.picShipSelection.Location = New System.Drawing.Point(506, 70)
        Me.picShipSelection.Name = "picShipSelection"
        Me.picShipSelection.Size = New System.Drawing.Size(127, 25)
        Me.picShipSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picShipSelection.TabIndex = 1
        Me.picShipSelection.TabStop = False
        '
        'picOptions
        '
        Me.picOptions.BackColor = System.Drawing.Color.Transparent
        Me.picOptions.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_options1
        Me.picOptions.Location = New System.Drawing.Point(506, 101)
        Me.picOptions.Name = "picOptions"
        Me.picOptions.Size = New System.Drawing.Size(76, 25)
        Me.picOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picOptions.TabIndex = 2
        Me.picOptions.TabStop = False
        '
        'picGameDetails
        '
        Me.picGameDetails.BackColor = System.Drawing.Color.Transparent
        Me.picGameDetails.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_details
        Me.picGameDetails.Location = New System.Drawing.Point(506, 132)
        Me.picGameDetails.Name = "picGameDetails"
        Me.picGameDetails.Size = New System.Drawing.Size(139, 25)
        Me.picGameDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGameDetails.TabIndex = 3
        Me.picGameDetails.TabStop = False
        '
        'picExitGame
        '
        Me.picExitGame.BackColor = System.Drawing.Color.Transparent
        Me.picExitGame.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_exit
        Me.picExitGame.Location = New System.Drawing.Point(506, 163)
        Me.picExitGame.Name = "picExitGame"
        Me.picExitGame.Size = New System.Drawing.Size(104, 25)
        Me.picExitGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExitGame.TabIndex = 4
        Me.picExitGame.TabStop = False
        '
        'frmSelectionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.rotroRacer.My.Resources.Resources.rotro_racer_selection_menu_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.picExitGame)
        Me.Controls.Add(Me.picGameDetails)
        Me.Controls.Add(Me.picOptions)
        Me.Controls.Add(Me.picShipSelection)
        Me.Controls.Add(Me.picSelectioinMenuTitle)
        Me.Name = "frmSelectionMenu"
        Me.Text = " "
        CType(Me.picSelectioinMenuTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShipSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGameDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExitGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSelectioinMenuTitle As PictureBox
    Friend WithEvents picShipSelection As PictureBox
    Friend WithEvents picOptions As PictureBox
    Friend WithEvents picGameDetails As PictureBox
    Friend WithEvents picExitGame As PictureBox
End Class
