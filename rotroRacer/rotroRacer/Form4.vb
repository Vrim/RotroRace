Public Class frmAsteroidDodge
    Dim random As New Random
    Dim level As Integer
    Dim time As Decimal
    Public Sub resetAsteroids()
        picAsteroid1.Top = 48
        picAsteroid1.Left = 45
        picAsteroid2.Top = 48
        picAsteroid2.Left = 90
        picAsteroid3.Top = 48
        picAsteroid3.Left = 135
        picAsteroid4.Top = 48
        picAsteroid4.Left = 180
        picAsteroid5.Top = 48
        picAsteroid5.Left = 225
        picAsteroid6.Top = 48
        picAsteroid6.Left = 270
        picAsteroid8.Top = 48
        picAsteroid8.Left = 360
        picAsteroid9.Top = 48
        picAsteroid9.Left = 405
        picAsteroid10.Top = 48
        picAsteroid10.Left = 450
        picAsteroid11.Top = 48
        picAsteroid11.Left = 495
        picAsteroid12.Top = 48
        picAsteroid12.Left = 540
        picAsteroid13.Top = 48
        picAsteroid13.Left = 585
    End Sub

    Private Sub tmrAsteroidMovement_Tick(sender As Object, e As EventArgs) Handles tmrAsteroidMovement.Tick
        If picAsteroid1.Top >= 580 Then
            picAsteroid1.Top = 0
            picAsteroid1.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision() Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid1.Top += random.Next(5, 7 + level)
        End If
        If picAsteroid2.Top >= 580 Then
            picAsteroid2.Top = 0
            picAsteroid2.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid2.Top += random.Next(5, 10 + level)
        End If
        If picAsteroid3.Top >= 580 Then
            picAsteroid3.Top = 0
            picAsteroid3.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid3.Top += random.Next(5, 10 + level)
        End If
        If picAsteroid4.Top >= 580 Then
            picAsteroid4.Top = 0
            picAsteroid4.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid4.Top += random.Next(5, 10 + level)
        End If
        If picAsteroid5.Top >= 580 Then
            picAsteroid5.Top = 0
            picAsteroid5.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid5.Top += random.Next(5, 10 + level)
        End If
        If picAsteroid6.Top >= 580 Then
            picAsteroid6.Top = 0
            picAsteroid6.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid6.Top += random.Next(5, 10 + level)
        End If

        If picAsteroid8.Top >= 580 Then
            picAsteroid8.Top = 0
            picAsteroid8.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid8.Top += random.Next(5, 10 + level)
        End If
        If picAsteroid9.Top >= 580 Then
            picAsteroid9.Top = 0
            picAsteroid9.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid9.Top += random.Next(5, 10 + level)
        End If
        If picAsteroid10.Top >= 580 Then
            picAsteroid10.Top = 0
            picAsteroid10.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid10.Top += random.Next(5, 10 + level)
        End If
        If picAsteroid11.Top >= 580 Then
            picAsteroid11.Top = 0
            picAsteroid11.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid11.Top += random.Next(5, 10 + level)
        End If
        If picAsteroid12.Top >= 580 Then
            picAsteroid12.Top = 0
            picAsteroid12.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid12.Top += random.Next(5, 10 + level)
        End If
        If picAsteroid13.Top >= 580 Then
            picAsteroid13.Top = 0
            picAsteroid13.Left = random.Next(1, 661)
            level += 1
        ElseIf checkCollision Then
            tmrAsteroidMovement.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
            tmrTimeAlive.Enabled = False
            MessageBox.Show("You Died")
            resetAsteroids()
            level = 0
            picEnter.Visible = True
            tmrLabelFlash.Enabled = True

        Else
            picAsteroid13.Top += random.Next(5, 10 + level)
        End If
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        If Not picShip.Top <= Me.Height Then
            picShip.Top += 10
        Else
            picShip.Top -= 10
        End If
        If collision(picShip, picBoundaries1) Then
            picShip.Left += 10
        End If
        If collision(picShip, picBoundaries2) Then
            picShip.Left -= 10
        End If
    End Sub

    Private Sub tmrDown_Tick(sender As Object, e As EventArgs) Handles tmrDown.Tick
        If Not picShip.Top >= Me.Height Then
            picShip.Top += 10
        Else
            picShip.Top -= 10
        End If
        If collision(picShip, picBoundaries1) Then
            picShip.Left += 10
        End If
        If collision(picShip, picBoundaries2) Then
            picShip.Left -= 10
        End If
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        If Not picShip.Left <= 0 Then
            picShip.Left -= 10
        Else
            picShip.Left += 10
        End If
        If collision(picShip, picBoundaries1) Then
            picShip.Left += 10
        End If
        If collision(picShip, picBoundaries2) Then
            picShip.Left -= 10
        End If
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        If Not picShip.Left >= Me.Width Then
            picShip.Left += 10
        Else
            picShip.Left -= 10
        End If
        If collision(picShip, picBoundaries1) Then
            picShip.Left += 10
        End If
        If collision(picShip, picBoundaries2) Then
            picShip.Left -= 10
        End If
    End Sub
    Private Sub frmAsteroidDodge_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            tmrUp.Enabled = True

        End If
        If e.KeyCode = Keys.Down Then
            tmrDown.Enabled = True

        End If
        If e.KeyCode = Keys.Left Then
            tmrLeft.Enabled = True

        End If
        If e.KeyCode = Keys.Right Then
            tmrRight.Enabled = True


        End If
        If e.KeyCode = Keys.Enter Then
            tmrAsteroidMovement.Enabled = True
            tmrLabelFlash.Enabled = False
            picEnter.Visible = False
            tmrTimeAlive.Enabled = True
            time = 0
        End If

    End Sub

    Private Sub frmAsteroidDodge_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            tmrUp.Enabled = False
        End If
        If e.KeyCode = Keys.Down Then
            tmrDown.Enabled = False
        End If
        If e.KeyCode = Keys.Left Then
            tmrLeft.Enabled = False
        End If
        If e.KeyCode = Keys.Right Then
            tmrRight.Enabled = False
        End If
    End Sub
    Private Function collision(ByVal r1 As PictureBox, ByVal r2 As PictureBox) As Boolean
        Dim Area1 As Rectangle, Area2 As Rectangle
        Area1 = r1.Bounds
        Area2 = r2.Bounds
        Return Area1.IntersectsWith(Area2)
    End Function

    Function checkCollision() As Boolean
        If collision(picShip, picAsteroid1) Or collision(picShip, picAsteroid2) Or collision(picShip, picAsteroid3) Or collision(picShip, picAsteroid4) Or collision(picShip, picAsteroid5) Or collision(picShip, picAsteroid6) Or collision(picShip, picAsteroid8) Or collision(picShip, picAsteroid9) Or collision(picShip, picAsteroid10) Or collision(picShip, picAsteroid11) Or collision(picShip, picAsteroid12) Or collision(picShip, picAsteroid13) Then
            Return True
        End If
    End Function

    Private Sub tmrLabelFlash_Tick(sender As Object, e As EventArgs) Handles tmrLabelFlash.Tick
        If picEnter.Visible = True Then
            picEnter.Visible = False
        ElseIf picEnter.Visible = False Then
            picEnter.Visible = True
        End If
    End Sub

    Private Sub tmrTimeAlive_Tick(sender As Object, e As EventArgs) Handles tmrTimeAlive.Tick

        time += 0.01
        lblTimeAlive.Text = time
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        tmrTimeAlive.Enabled = False
        tmrAsteroidMovement.Enabled = False
    End Sub
End Class