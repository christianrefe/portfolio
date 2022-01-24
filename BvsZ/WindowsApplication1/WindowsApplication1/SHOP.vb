Public Class SHOP

    Private Sub SHOP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GAME.Timer1.Enabled = False
        zombie.Text = GAME.mwave
        moneylabel.Text = GAME.money
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class