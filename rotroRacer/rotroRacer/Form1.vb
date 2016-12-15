Public Class frmTitlescreen
    Private Sub tmrFlash_Tick(sender As Object, e As EventArgs) Handles tmrFlash.Tick
        If picFlashystuff.Visible = True Then
            picFlashystuff.Visible = False
        ElseIf picFlashystuff.Visible = False Then
            picFlashystuff.Visible = True
        End If
    End Sub

    Private Sub frmTitlescreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub frmTitlescreen_Keydown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Hide()
            frmSelectionMenu.Show()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

End Class
