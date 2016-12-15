<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitlescreen
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
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picFlashystuff = New System.Windows.Forms.PictureBox()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        CType(Me.picFlashystuff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrFlash
        '
        Me.tmrFlash.Enabled = True
        Me.tmrFlash.Interval = 500
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(-2, 537)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'picFlashystuff
        '
        Me.picFlashystuff.BackColor = System.Drawing.Color.Transparent
        Me.picFlashystuff.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_start_image2
        Me.picFlashystuff.Location = New System.Drawing.Point(283, 348)
        Me.picFlashystuff.Name = "picFlashystuff"
        Me.picFlashystuff.Size = New System.Drawing.Size(239, 31)
        Me.picFlashystuff.TabIndex = 1
        Me.picFlashystuff.TabStop = False
        '
        'picTitle
        '
        Me.picTitle.BackColor = System.Drawing.Color.Transparent
        Me.picTitle.Image = Global.rotroRacer.My.Resources.Resources.rotro_racer_logo
        Me.picTitle.Location = New System.Drawing.Point(169, 30)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(430, 80)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTitle.TabIndex = 0
        Me.picTitle.TabStop = False
        '
        'frmTitlescreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.rotroRacer.My.Resources.Resources.rotro_racer_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picFlashystuff)
        Me.Controls.Add(Me.picTitle)
        Me.Name = "frmTitlescreen"
        Me.Text = "Rotro Racer"
        CType(Me.picFlashystuff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTitle As PictureBox
    Friend WithEvents picFlashystuff As PictureBox
    Friend WithEvents tmrFlash As Timer
    Friend WithEvents btnExit As Button
End Class
