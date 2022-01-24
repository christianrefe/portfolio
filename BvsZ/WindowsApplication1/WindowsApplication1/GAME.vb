Public Class GAME
    Public bomb = True
    Public b(50), l(50), t(20), r(50), bmb(3), dmg(2), buy(3), speed(1)
    Public loc As Point
    Public x, wave, level, remain, rn, money, mwave, z, rndspawn, killedz As Integer
    Public reqdmg(2)
    Public n As New Random
    Private Sub GAME_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
       
        b(0) = 0
        b(1) = 0
        b(2) = 0
        b(3) = 0
        b(4) = 0
        b(5) = 0
        b(6) = 0
        b(7) = 0
        b(8) = 0
        b(9) = 0
        b(10) = 0
        b(11) = 0
        b(12) = 0
        b(13) = 0
        b(14) = 0
        b(15) = 0
        b(16) = 0
        b(17) = 0
        b(19) = 0
        b(20) = 0
        b(21) = 0
        b(22) = 0
        b(23) = 0
        b(24) = 0
        b(25) = 0
        b(26) = 0
        b(27) = 0
        b(28) = 0
        b(29) = 0
        b(30) = 0
        b(31) = 0
        b(32) = 0
        b(33) = 0
        b(34) = 0
        b(35) = 0

        l(0) = 1
        l(1) = 1
        l(2) = 1
        l(3) = 1
        l(4) = 1
        l(5) = 1
        l(6) = 1
        l(7) = 1
        l(8) = 1
        l(9) = 1
        l(10) = 1
        l(11) = 1
        l(12) = 1
        l(13) = 1
        l(14) = 1
        l(15) = 1
        l(16) = 1
        l(17) = 0
        l(19) = 0
        l(20) = 0
        l(21) = 0
        l(22) = 0
        l(23) = 1
        l(24) = 1
        l(25) = 1
        l(26) = 1
        l(27) = 1
        l(28) = 1
        l(29) = 1
        l(30) = 1
        l(31) = 1
        l(32) = 1
        l(33) = 1
        l(34) = 1
        l(35) = 1
        ' If PictureBox16.Location.Y >= 0 = True Then

        'If e.KeyCode = Keys.W Then
        'PictureBox16.Top -= 10
        '   End If
        '  End If
        '    If PictureBox16.Location.Y <= 275 Then
        'If e.KeyCode = Keys.S Then
        '   PictureBox16.Top += 10
        '   End If

        'End If


        ' If PictureBox16.Location.X >= 0 Then
        'If e.KeyCode = Keys.A Then
        'PictureBox16.Left -= 5
        ' End If
        '  End If
        '  If PictureBox16.Location.X <= 401 Then
        'If e.KeyCode = Keys.D Then
        'PictureBox16.Left += 5
        '  End If
        '  End If
    End Sub

    Private Sub GAME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If Timer2.Enabled = True Then
            intro.Text = "3"
        End If

        t(0) = p1.Location.X
        t(1) = p1.Location.Y
        money = 100
        z = 4
        speed(0) = 2
        speed(1) = 2
        wave = 14
        remain = 3
        level = 1
        mwave = 0
        dmg(0) = 5
        dmg(1) = 5
        reqdmg(0) = 5
        reqdmg(1) = 5
        If buy(0) = 0 Then
            cdbox2.Text = "Buy It: 20g"
        Else
            cdbox2.Text = "5"
        End If
        If buy(1) = 0 Then
            cdbox3.Text = "Buy It: 50g"
        Else
            cdbox3.Text = "7"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Label3.Text = PictureBox16.Top
        '  Label4.Text = PictureBox16.Left
        dmg(0) = reqdmg(0)
        dmg(1) = reqdmg(1)
        pera.Text = money
        killed.Text = mwave
        life.Text = ProgressBar1.Value & " / 100"
        If mwave = 14 Then
            mwave = 0
            level = level + 1
            speed(0) = speed(0) + 1
            speed(1) = speed(1) + 1
            x = 0
            money = money + 35
            intro.BringToFront()
            intro.Text = "3"
            Timer2.Enabled = True
            Timer1.Enabled = False
            l(1) = 0
            l(2) = 0
            l(3) = 0
            l(4) = 0
            l(5) = 0
            l(6) = 0
            l(7) = 0
            l(8) = 0
            l(9) = 0
            l(10) = 0
            l(11) = 0
            l(12) = 0
            l(13) = 0
            l(14) = 0

            p1.Show()
            p1.Location = New Point(476, 28)

            p2.Show()
            p2.Location = New Point(476, 78)

            p3.Show()
            p3.Location = New Point(476, 128)

            p4.Show()
            p4.Location = New Point(476, 178)

            p5.Show()
            p5.Location = New Point(476, 228)

            p6.Show()
            p6.Location = New Point(476, 278)

            p7.Show()
            p7.Location = New Point(476, 328)


            p8.Location = New Point(476, 28)
            p8.Show()

            p9.Location = New Point(476, 78)
            p9.Show()

            p10.Location = New Point(476, 128)
            p10.Show()

            p11.Location = New Point(476, 178)
            p11.Show()

            p12.Location = New Point(476, 228)
            p12.Show()

            p13.Location = New Point(476, 278)
            p13.Show()

            p14.Location = New Point(476, 328)
            p14.Show()


        End If
        If p1.Location.X >= 0 Then
            p1.Left -= speed(0)
            p2.Left -= speed(0)
            p3.Left -= speed(0)
            p4.Left -= speed(0)
            p5.Left -= speed(0)
            p6.Left -= speed(0)
            p7.Left -= speed(0)
        End If
        If p1.Bounds.IntersectsWith(t5.Bounds) Then
            x = 1
        End If
        If x = 1 Then
            p8.Left -= speed(1)
            p9.Left -= speed(1)
            p10.Left -= speed(1)
            p11.Left -= speed(1)
            p12.Left -= speed(1)
            p13.Left -= speed(1)
            p14.Left -= speed(1)
        End If
        If p1.Bounds.IntersectsWith(TOWER.Bounds) Then

            p1.Location = New Point(476, 28)
            If l(1) = 0 Then
                If ProgressBar1.Value < dmg(0) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(0)
                    life.Text = ProgressBar1.Value - dmg(0)
                End If

                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p1.Show()
            speed(0) = speed(0) + 1
            l(1) = 0
            reqdmg(0) = reqdmg(0) + 2
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p8.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(8) = 0 Then
                If ProgressBar1.Value < dmg(1) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(1)
                    life.Text = ProgressBar1.Value - dmg(1)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            speed(1) = speed(1) + 1
            p8.Show()
            p8.Location = New Point(476, 28)
            reqdmg(1) = reqdmg(1) + 2
            l(8) = 0
        End If
        If p2.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(2) = 0 Then
                If ProgressBar1.Value < dmg(0) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(0)
                    life.Text = ProgressBar1.Value - dmg(0)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p2.Show()
            p2.Location = New Point(476, 78)
            l(2) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p9.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(9) = 0 Then
                If ProgressBar1.Value < dmg(1) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(1)
                    life.Text = ProgressBar1.Value - dmg(1)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p9.Show()
            p9.Location = New Point(476, 78)
            l(9) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If

        If p3.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(3) = 0 Then
                If ProgressBar1.Value < dmg(0) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(0)
                    life.Text = ProgressBar1.Value - dmg(0)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p3.Show()
            p3.Location = New Point(476, 128)
            l(3) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p10.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(10) = 0 Then
                If ProgressBar1.Value < dmg(1) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(1)
                    life.Text = ProgressBar1.Value - dmg(1)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p10.Show()
            p10.Location = New Point(476, 128)
            l(10) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p4.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(4) = 0 Then
                If ProgressBar1.Value < dmg(0) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(0)
                    life.Text = ProgressBar1.Value - dmg(0)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p4.Show()
            p4.Location = New Point(476, 178)
            l(4) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p11.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(11) = 0 Then
                If ProgressBar1.Value < dmg(1) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(1)
                    life.Text = ProgressBar1.Value - dmg(1)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p11.Show()
            p11.Location = New Point(476, 178)
            l(11) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p5.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(5) = 0 Then
                If ProgressBar1.Value < dmg(0) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(0)
                    life.Text = ProgressBar1.Value - dmg(0)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p5.Show()
            p5.Location = New Point(476, 228)
            l(5) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p12.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(12) = 0 Then
                If ProgressBar1.Value < dmg(1) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(1)
                    life.Text = ProgressBar1.Value - dmg(1)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p12.Show()
            p12.Location = New Point(476, 228)
            l(12) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p6.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(6) = 0 Then
                If ProgressBar1.Value < dmg(0) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(0)
                    life.Text = ProgressBar1.Value - dmg(0)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p6.Show()
            p6.Location = New Point(476, 278)
            l(6) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p13.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(13) = 0 Then
                If ProgressBar1.Value < dmg(1) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(1)
                    life.Text = ProgressBar1.Value - dmg(1)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p13.Show()
            p13.Location = New Point(476, 278)
            l(13) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p7.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(7) = 0 Then
                If ProgressBar1.Value < dmg(0) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(0)
                    life.Text = ProgressBar1.Value - dmg(0)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p7.Show()
            p7.Location = New Point(476, 328)
            l(7) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p14.Bounds.IntersectsWith(TOWER.Bounds) Then

            If l(14) = 0 Then
                If ProgressBar1.Value < dmg(1) Then
                    ProgressBar1.Value = 0
                    life.Text = "0"
                Else
                    ProgressBar1.Value = ProgressBar1.Value - dmg(1)
                    life.Text = ProgressBar1.Value - dmg(1)
                End If
                If ProgressBar1.Value <= 0 Then
                    Timer1.Enabled = False

                    Me.Hide()
                    SHOP.Show()
                End If
            End If
            p14.Show()
            p14.Location = New Point(476, 328)
            l(14) = 0
        End If
        If ProgressBar1.Value <= 0 Then
            Timer1.Enabled = False

            Me.Hide()
            SHOP.Show()
        End If
        If p1.Bounds.IntersectsWith(t5.Bounds) Then
            If b(5) = 1 Then
                If l(1) = 0 Then
                    p1.Image = My.Resources.BADUY
                    p1.Hide()

                    t5.Image = Nothing
                    b(5) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                    End If

                End If
            End If
            If b(5) = 2 Then
                If l(1) = 0 Then
                    p1.Image = My.Resources.BADUY
                    p1.Hide()
                    p8.Image = My.Resources.BADUY
                    p8.Hide()
                    t5.Image = Nothing
                    b(5) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(5) = 3 Then
                If l(1) = 0 Then

                    p1.Hide()
                    p1.Image = My.Resources.BADUY
                    p2.Hide()
                    p2.Image = My.Resources.BADUY
                    p8.Hide()
                    p8.Image = My.Resources.BADUY
                    t5.Image = Nothing
                    b(5) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p1.Bounds.IntersectsWith(t4.Bounds) Then
            If b(4) = 1 Then
                If l(1) = 0 Then
                    p1.Hide()

                    t4.Image = Nothing
                    b(4) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(4) = 2 Then
                If l(1) = 0 Then
                    p1.Hide()
                    p8.Hide()

                    t4.Image = Nothing
                    b(4) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(4) = 3 Then
                If l(1) = 0 Then

                    p1.Hide()
                    p2.Hide()
                    p8.Hide()
                    t4.Image = Nothing
                    b(4) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p1.Bounds.IntersectsWith(t3.Bounds) Then
            If b(3) = 1 Then
                If l(1) = 0 Then
                    p1.Hide()

                    t3.Image = Nothing
                    b(3) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(3) = 2 Then
                If l(1) = 0 Then
                    p1.Hide()
                    p8.Hide()

                    t3.Image = Nothing
                    b(3) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(3) = 3 Then
                If l(1) = 0 Then

                    p1.Hide()
                    p2.Hide()
                    p8.Hide()
                    t3.Image = Nothing
                    b(3) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p1.Bounds.IntersectsWith(t2.Bounds) Then
            If b(2) = 1 Then
                If l(1) = 0 Then
                    p1.Hide()

                    t2.Image = Nothing
                    b(2) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(2) = 2 Then
                If l(1) = 0 Then
                    p1.Hide()
                    p8.Hide()

                    t2.Image = Nothing
                    b(2) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(2) = 3 Then
                If l(1) = 0 Then

                    p1.Hide()
                    p2.Hide()
                    p8.Hide()
                    t2.Image = Nothing
                    b(2) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p1.Bounds.IntersectsWith(t1.Bounds) Then
            If b(1) = 1 Then
                If l(1) = 0 Then
                    p1.Hide()

                    t1.Image = Nothing
                    b(1) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(1) = 2 Then
                If l(1) = 0 Then
                    p1.Hide()
                    p8.Hide()

                    t1.Image = Nothing
                    b(1) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(1) = 3 Then
                If l(1) = 0 Then

                    p1.Hide()
                    p2.Hide()
                    p8.Hide()
                    t1.Image = Nothing
                    b(1) = 0
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p8.Bounds.IntersectsWith(t5.Bounds) Then
            If b(5) = 1 Then
                If l(8) = 0 Then
                    p8.Hide()

                    t5.Image = Nothing
                    b(5) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(5) = 2 Then
                If l(8) = 0 Then
                    p8.Hide()
                    t5.Image = Nothing
                    b(5) = 0

                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(5) = 3 Then
                If l(8) = 0 Then
                    p9.Hide()
                    p8.Hide()
                    t5.Image = Nothing
                    b(5) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p8.Bounds.IntersectsWith(t4.Bounds) Then
            If b(4) = 1 Then
                If l(8) = 0 Then
                    p8.Hide()

                    t4.Image = Nothing
                    b(4) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(4) = 2 Then
                If l(8) = 0 Then
                    p8.Hide()
                    t4.Image = Nothing
                    b(4) = 0

                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(4) = 3 Then
                If l(8) = 0 Then
                    p9.Hide()
                    p8.Hide()
                    t4.Image = Nothing
                    b(4) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p8.Bounds.IntersectsWith(t3.Bounds) Then
            If b(3) = 1 Then
                If l(8) = 0 Then
                    p8.Hide()

                    t3.Image = Nothing
                    b(3) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(3) = 2 Then
                If l(8) = 0 Then
                    p8.Hide()
                    t3.Image = Nothing
                    b(3) = 0

                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(3) = 3 Then
                If l(8) = 0 Then
                    p9.Hide()
                    p8.Hide()
                    t3.Image = Nothing
                    b(3) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p8.Bounds.IntersectsWith(t2.Bounds) Then
            If b(2) = 1 Then
                If l(8) = 0 Then
                    p8.Hide()

                    t2.Image = Nothing
                    b(2) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(2) = 2 Then
                If l(8) = 0 Then
                    p8.Hide()
                    t2.Image = Nothing
                    b(2) = 0

                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(2) = 3 Then
                If l(8) = 0 Then
                    p9.Hide()
                    p8.Hide()
                    t2.Image = Nothing
                    b(2) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p8.Bounds.IntersectsWith(t1.Bounds) Then
            If b(1) = 1 Then
                If l(8) = 0 Then
                    p8.Hide()

                    t1.Image = Nothing
                    b(1) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(1) = 2 Then
                If l(8) = 0 Then
                    p8.Hide()
                    t1.Image = Nothing
                    b(1) = 0

                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(1) = 3 Then
                If l(8) = 0 Then
                    p9.Hide()
                    p8.Hide()
                    t1.Image = Nothing
                    b(1) = 0
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p2.Bounds.IntersectsWith(t10.Bounds) Then
            If b(10) = 1 Then
                If l(2) = 0 Then
                    p2.Hide()

                    t10.Image = Nothing
                    b(10) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(10) = 2 Then
                If l(2) = 0 Then
                    p2.Hide()
                    p9.Hide()
                    t10.Image = Nothing
                    b(10) = 0

                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(10) = 3 Then
                If l(2) = 0 Then
                    p1.Hide()
                    p2.Hide()
                    p3.Hide()
                    p9.Hide()
                    t10.Image = Nothing
                    b(10) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p2.Bounds.IntersectsWith(t9.Bounds) Then
            If b(9) = 1 Then
                If l(2) = 0 Then
                    p2.Hide()

                    t9.Image = Nothing
                    b(9) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(9) = 2 Then
                If l(2) = 0 Then
                    p2.Hide()
                    p9.Hide()
                    t9.Image = Nothing
                    b(9) = 0

                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(9) = 3 Then
                If l(2) = 0 Then
                    p1.Hide()
                    p2.Hide()
                    p3.Hide()
                    p9.Hide()
                    t9.Image = Nothing
                    b(9) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p2.Bounds.IntersectsWith(t8.Bounds) Then
            If b(8) = 1 Then
                If l(2) = 0 Then
                    p2.Hide()

                    t8.Image = Nothing
                    b(8) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(8) = 2 Then
                If l(2) = 0 Then
                    p2.Hide()
                    p9.Hide()
                    t8.Image = Nothing
                    b(8) = 0

                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(8) = 3 Then
                If l(2) = 0 Then
                    p1.Hide()
                    p2.Hide()
                    p3.Hide()
                    p9.Hide()
                    t8.Image = Nothing
                    b(8) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p2.Bounds.IntersectsWith(t7.Bounds) Then
            If b(7) = 1 Then
                If l(2) = 0 Then
                    p2.Hide()

                    t7.Image = Nothing
                    b(7) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(7) = 2 Then
                If l(2) = 0 Then
                    p2.Hide()
                    p9.Hide()
                    t7.Image = Nothing
                    b(7) = 0

                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(7) = 3 Then
                If l(2) = 0 Then
                    p1.Hide()
                    p2.Hide()
                    p3.Hide()
                    p9.Hide()
                    t7.Image = Nothing
                    b(7) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p2.Bounds.IntersectsWith(t6.Bounds) Then
            If b(6) = 1 Then
                If l(2) = 0 Then
                    p2.Hide()

                    t6.Image = Nothing
                    b(6) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(6) = 2 Then
                If l(2) = 0 Then
                    p2.Hide()
                    p9.Hide()
                    t6.Image = Nothing
                    b(6) = 0

                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(6) = 3 Then
                If l(2) = 0 Then
                    p1.Hide()
                    p2.Hide()
                    p3.Hide()
                    p9.Hide()
                    t6.Image = Nothing
                    b(6) = 0
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(1) = 0 Then
                        l(1) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p9.Bounds.IntersectsWith(t10.Bounds) Then
            If b(10) = 1 Then
                If l(9) = 0 Then
                    p9.Hide()

                    t10.Image = Nothing
                    b(10) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(10) = 2 Then
                If l(9) = 0 Then
                    p9.Hide()
                    t10.Image = Nothing
                    b(10) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(10) = 3 Then
                If l(9) = 0 Then
                    p10.Hide()
                    p8.Hide()
                    p9.Hide()
                    t10.Image = Nothing
                    b(10) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p9.Bounds.IntersectsWith(t9.Bounds) Then
            If b(9) = 1 Then
                If l(9) = 0 Then
                    p9.Hide()

                    t9.Image = Nothing
                    b(9) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(9) = 2 Then
                If l(9) = 0 Then
                    p9.Hide()
                    t9.Image = Nothing
                    b(9) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(9) = 3 Then
                If l(9) = 0 Then
                    p10.Hide()
                    p8.Hide()
                    p9.Hide()
                    t9.Image = Nothing
                    b(9) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p9.Bounds.IntersectsWith(t8.Bounds) Then
            If b(8) = 1 Then
                If l(9) = 0 Then
                    p9.Hide()

                    t8.Image = Nothing
                    b(8) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(8) = 2 Then
                If l(9) = 0 Then
                    p8.Hide()
                    t8.Image = Nothing
                    b(9) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(8) = 3 Then
                If l(9) = 0 Then
                    p10.Hide()
                    p8.Hide()
                    p8.Hide()
                    t8.Image = Nothing
                    b(9) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p9.Bounds.IntersectsWith(t7.Bounds) Then


            If b(7) = 1 Then
                If l(9) = 0 Then
                    p9.Hide()

                    t7.Image = Nothing
                    b(7) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(7) = 2 Then
                If l(9) = 0 Then
                    p9.Hide()
                    t7.Image = Nothing
                    b(7) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(7) = 3 Then
                If l(9) = 0 Then
                    p10.Hide()
                    p8.Hide()
                    p9.Hide()
                    t7.Image = Nothing
                    b(7) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p9.Bounds.IntersectsWith(t6.Bounds) Then

            If b(6) = 1 Then
                If l(9) = 0 Then
                    p9.Hide()

                    t6.Image = Nothing
                    b(6) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(6) = 2 Then
                If l(9) = 0 Then
                    p9.Hide()
                    t6.Image = Nothing
                    b(6) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(6) = 3 Then
                If l(9) = 0 Then
                    p10.Hide()
                    p8.Hide()
                    p9.Hide()
                    t6.Image = Nothing
                    b(6) = 0
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(8) = 0 Then
                        l(8) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p3.Bounds.IntersectsWith(t15.Bounds) Then
            If b(15) = 1 Then
                If l(3) = 0 Then
                    p3.Hide()

                    t15.Image = Nothing
                    b(15) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(15) = 2 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p9.Hide()
                    t15.Image = Nothing
                    b(15) = 0

                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(15) = 3 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p10.Hide()
                    p2.Hide()
                    p4.Hide()
                    t15.Image = Nothing
                    b(15) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p3.Bounds.IntersectsWith(t14.Bounds) Then
            If b(14) = 1 Then
                If l(3) = 0 Then
                    p3.Hide()

                    t14.Image = Nothing
                    b(14) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(14) = 2 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p9.Hide()
                    t14.Image = Nothing
                    b(14) = 0

                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(14) = 3 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p10.Hide()
                    p2.Hide()
                    p4.Hide()
                    t14.Image = Nothing
                    b(14) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p3.Bounds.IntersectsWith(t13.Bounds) Then
            If b(13) = 1 Then
                If l(3) = 0 Then
                    p3.Hide()

                    t13.Image = Nothing
                    b(13) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(13) = 2 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p9.Hide()
                    t13.Image = Nothing
                    b(13) = 0

                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(13) = 3 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p10.Hide()
                    p2.Hide()
                    p4.Hide()
                    t13.Image = Nothing
                    b(13) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p3.Bounds.IntersectsWith(t12.Bounds) Then
            If b(12) = 1 Then
                If l(3) = 0 Then
                    p3.Hide()

                    t12.Image = Nothing
                    b(12) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(12) = 2 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p9.Hide()
                    t12.Image = Nothing
                    b(12) = 0

                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(12) = 3 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p10.Hide()
                    p2.Hide()
                    p4.Hide()
                    t12.Image = Nothing
                    b(12) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p3.Bounds.IntersectsWith(t11.Bounds) Then
            If b(11) = 1 Then
                If l(3) = 0 Then
                    p3.Hide()

                    t11.Image = Nothing
                    b(11) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(11) = 2 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p9.Hide()
                    t11.Image = Nothing
                    b(11) = 0

                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(11) = 3 Then
                If l(3) = 0 Then
                    p3.Hide()
                    p10.Hide()
                    p2.Hide()
                    p4.Hide()
                    t11.Image = Nothing
                    b(11) = 0
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(2) = 0 Then
                        l(2) = 1
                        mwave = mwave + 1
                    End If
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If


        If p10.Bounds.IntersectsWith(t15.Bounds) Then
            If b(15) = 1 Then
                If l(10) = 0 Then
                    p10.Hide()

                    t15.Image = Nothing
                    b(15) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(15) = 2 Then
                If l(10) = 0 Then
                    p10.Hide()
                    t15.Image = Nothing
                    b(15) = 0

                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(15) = 3 Then
                If l(10) = 0 Then
                    p11.Hide()
                    p10.Hide()
                    p9.Hide()

                    t15.Image = Nothing
                    b(15) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
        End If
        If p10.Bounds.IntersectsWith(t14.Bounds) Then
            If b(14) = 1 Then
                If l(10) = 0 Then
                    p10.Hide()

                    t14.Image = Nothing
                    b(14) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(14) = 2 Then
                If l(10) = 0 Then
                    p10.Hide()
                    t15.Image = Nothing
                    b(14) = 0

                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(14) = 3 Then
                If l(10) = 0 Then
                    p11.Hide()
                    p10.Hide()
                    p9.Hide()

                    t14.Image = Nothing
                    b(14) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
        End If
        If p10.Bounds.IntersectsWith(t13.Bounds) Then
            If b(13) = 1 Then
                If l(10) = 0 Then
                    p10.Hide()

                    t13.Image = Nothing
                    b(13) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(13) = 2 Then
                If l(10) = 0 Then
                    p10.Hide()
                    t13.Image = Nothing
                    b(13) = 0

                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(13) = 3 Then
                If l(10) = 0 Then
                    p11.Hide()
                    p10.Hide()
                    p9.Hide()

                    t13.Image = Nothing
                    b(13) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
        End If
        If p10.Bounds.IntersectsWith(t12.Bounds) Then
            If b(12) = 1 Then
                If l(10) = 0 Then
                    p10.Hide()

                    t12.Image = Nothing
                    b(12) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(12) = 2 Then
                If l(10) = 0 Then
                    p10.Hide()
                    t12.Image = Nothing
                    b(12) = 0

                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(12) = 3 Then
                If l(10) = 0 Then
                    p11.Hide()
                    p10.Hide()
                    p9.Hide()

                    t12.Image = Nothing
                    b(12) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
        End If
        If p10.Bounds.IntersectsWith(t11.Bounds) Then
            If b(11) = 1 Then
                If l(10) = 0 Then
                    p10.Hide()

                    t11.Image = Nothing
                    b(11) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(11) = 2 Then
                If l(10) = 0 Then
                    p10.Hide()
                    t11.Image = Nothing
                    b(11) = 0

                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(11) = 3 Then
                If l(10) = 0 Then
                    p11.Hide()
                    p10.Hide()
                    p9.Hide()

                    t11.Image = Nothing
                    b(11) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(9) = 0 Then
                        l(9) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
        End If

        If p4.Bounds.IntersectsWith(t20.Bounds) Then
            If b(20) = 1 Then
                If l(4) = 0 Then
                    p4.Hide()

                    t20.Image = Nothing
                    b(20) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(20) = 2 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    t20.Image = Nothing
                    b(20) = 0

                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(20) = 3 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    p3.Hide()
                    p5.Hide()
                    t20.Image = Nothing
                    b(20) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p4.Bounds.IntersectsWith(t19.Bounds) Then
            If b(19) = 1 Then
                If l(4) = 0 Then
                    p4.Hide()

                    t19.Image = Nothing
                    b(19) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(19) = 2 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    t19.Image = Nothing
                    b(19) = 0

                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(19) = 3 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    p3.Hide()
                    p5.Hide()
                    t19.Image = Nothing
                    b(19) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p4.Bounds.IntersectsWith(t18.Bounds) Then
            If b(18) = 1 Then
                If l(4) = 0 Then
                    p4.Hide()

                    t18.Image = Nothing
                    b(18) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(18) = 2 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    t18.Image = Nothing
                    b(18) = 0

                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(18) = 3 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    p3.Hide()
                    p5.Hide()
                    t18.Image = Nothing
                    b(18) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p4.Bounds.IntersectsWith(t17.Bounds) Then
            If b(17) = 1 Then
                If l(4) = 0 Then
                    p4.Hide()

                    t17.Image = Nothing
                    b(17) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(17) = 2 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    t17.Image = Nothing
                    b(17) = 0

                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(17) = 3 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    p3.Hide()
                    p5.Hide()
                    t17.Image = Nothing
                    b(17) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p4.Bounds.IntersectsWith(t16.Bounds) Then
            If b(16) = 1 Then
                If l(4) = 0 Then
                    p4.Hide()

                    t16.Image = Nothing
                    b(16) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(16) = 2 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    t16.Image = Nothing
                    b(16) = 0

                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(16) = 3 Then
                If l(4) = 0 Then
                    p4.Hide()
                    p11.Hide()
                    p3.Hide()
                    p5.Hide()
                    t16.Image = Nothing
                    b(16) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(3) = 0 Then
                        l(3) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p11.Bounds.IntersectsWith(t20.Bounds) Then
            If b(20) = 1 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t20.Image = Nothing
                    b(20) = 0
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(20) = 2 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t20.Image = Nothing
                    b(20) = 0

                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(20) = 3 Then
                If l(11) = 0 Then
                    p10.Hide()
                    p11.Hide()
                    p12.Hide()

                    t20.Image = Nothing
                    b(20) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p11.Bounds.IntersectsWith(t19.Bounds) Then
            If b(19) = 1 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t19.Image = Nothing
                    b(19) = 0
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(19) = 2 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t19.Image = Nothing
                    b(19) = 0

                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(19) = 3 Then
                If l(11) = 0 Then
                    p10.Hide()
                    p11.Hide()
                    p12.Hide()

                    t19.Image = Nothing
                    b(19) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p11.Bounds.IntersectsWith(t18.Bounds) Then
            If b(18) = 1 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t18.Image = Nothing
                    b(18) = 0
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(18) = 2 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t18.Image = Nothing
                    b(18) = 0

                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(18) = 3 Then
                If l(11) = 0 Then
                    p10.Hide()
                    p11.Hide()
                    p12.Hide()

                    t18.Image = Nothing
                    b(18) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p11.Bounds.IntersectsWith(t17.Bounds) Then
            If b(17) = 1 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t17.Image = Nothing
                    b(17) = 0
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(17) = 2 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t17.Image = Nothing
                    b(17) = 0

                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(17) = 3 Then
                If l(11) = 0 Then
                    p10.Hide()
                    p11.Hide()
                    p12.Hide()

                    t17.Image = Nothing
                    b(17) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p11.Bounds.IntersectsWith(t16.Bounds) Then
            If b(16) = 1 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t16.Image = Nothing
                    b(16) = 0
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(16) = 2 Then
                If l(11) = 0 Then
                    p11.Hide()

                    t16.Image = Nothing
                    b(16) = 0

                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
            If b(16) = 3 Then
                If l(11) = 0 Then
                    p10.Hide()
                    p11.Hide()
                    p12.Hide()

                    t16.Image = Nothing
                    b(16) = 0
                    If l(10) = 0 Then
                        l(10) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p5.Bounds.IntersectsWith(t25.Bounds) Then
            If b(25) = 1 Then
                If l(5) = 0 Then
                    p5.Hide()

                    t25.Image = Nothing
                    b(25) = 0
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(25) = 2 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p12.Hide()
                    t25.Image = Nothing
                    b(25) = 0

                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(25) = 3 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p6.Hide()
                    p4.Hide()
                    p12.Hide()
                    t25.Image = Nothing
                    b(25) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p5.Bounds.IntersectsWith(t24.Bounds) Then
            If b(24) = 1 Then
                If l(5) = 0 Then
                    p5.Hide()

                    t24.Image = Nothing
                    b(24) = 0
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(24) = 2 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p12.Hide()
                    t24.Image = Nothing
                    b(24) = 0

                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(24) = 3 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p6.Hide()
                    p4.Hide()
                    p12.Hide()
                    t24.Image = Nothing
                    b(24) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p5.Bounds.IntersectsWith(t23.Bounds) Then
            If b(23) = 1 Then
                If l(5) = 0 Then
                    p5.Hide()

                    t23.Image = Nothing
                    b(23) = 0
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(23) = 2 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p12.Hide()
                    t23.Image = Nothing
                    b(23) = 0

                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(23) = 3 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p6.Hide()
                    p4.Hide()
                    p12.Hide()
                    t23.Image = Nothing
                    b(23) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p5.Bounds.IntersectsWith(t22.Bounds) Then
            If b(22) = 1 Then
                If l(5) = 0 Then
                    p5.Hide()

                    t22.Image = Nothing
                    b(22) = 0
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(22) = 2 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p12.Hide()
                    t22.Image = Nothing
                    b(22) = 0

                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(22) = 3 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p6.Hide()
                    p4.Hide()
                    p12.Hide()
                    t22.Image = Nothing
                    b(22) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p5.Bounds.IntersectsWith(t21.Bounds) Then
            If b(21) = 1 Then
                If l(5) = 0 Then
                    p5.Hide()

                    t21.Image = Nothing
                    b(21) = 0
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(21) = 2 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p12.Hide()
                    t21.Image = Nothing
                    b(21) = 0

                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(21) = 3 Then
                If l(5) = 0 Then
                    p5.Hide()
                    p6.Hide()
                    p4.Hide()
                    p12.Hide()
                    t21.Image = Nothing
                    b(21) = 0
                    If l(4) = 0 Then
                        l(4) = 1
                        mwave = mwave + 1
                    End If
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If


        If p12.Bounds.IntersectsWith(t25.Bounds) Then
            If b(25) = 1 Then
                If l(12) = 0 Then
                    p12.Hide()

                    t25.Image = Nothing
                    b(25) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(25) = 2 Then
                If l(12) = 0 Then

                    p12.Hide()
                    t25.Image = Nothing
                    b(25) = 0

                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(25) = 3 Then
                If l(12) = 0 Then
                    p11.Hide()
                    p13.Hide()
                    p12.Hide()
                    t25.Image = Nothing
                    b(25) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p12.Bounds.IntersectsWith(t24.Bounds) Then
            If b(24) = 1 Then
                If l(12) = 0 Then
                    p12.Hide()

                    t24.Image = Nothing
                    b(24) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(24) = 2 Then
                If l(12) = 0 Then

                    p12.Hide()
                    t24.Image = Nothing
                    b(24) = 0

                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(24) = 3 Then
                If l(12) = 0 Then
                    p11.Hide()
                    p13.Hide()
                    p12.Hide()
                    t24.Image = Nothing
                    b(24) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p12.Bounds.IntersectsWith(t23.Bounds) Then
            If b(23) = 1 Then
                If l(12) = 0 Then
                    p12.Hide()

                    t23.Image = Nothing
                    b(23) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(23) = 2 Then
                If l(12) = 0 Then

                    p12.Hide()
                    t23.Image = Nothing
                    b(23) = 0

                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(23) = 3 Then
                If l(12) = 0 Then
                    p11.Hide()
                    p13.Hide()
                    p12.Hide()
                    t23.Image = Nothing
                    b(23) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p12.Bounds.IntersectsWith(t22.Bounds) Then
            If b(22) = 1 Then
                If l(12) = 0 Then
                    p12.Hide()

                    t22.Image = Nothing
                    b(22) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(22) = 2 Then
                If l(12) = 0 Then

                    p12.Hide()
                    t22.Image = Nothing
                    b(22) = 0

                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(22) = 3 Then
                If l(12) = 0 Then
                    p11.Hide()
                    p13.Hide()
                    p12.Hide()
                    t22.Image = Nothing
                    b(22) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p12.Bounds.IntersectsWith(t21.Bounds) Then
            If b(21) = 1 Then
                If l(12) = 0 Then
                    p12.Hide()

                    t21.Image = Nothing
                    b(21) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(21) = 2 Then
                If l(12) = 0 Then

                    p12.Hide()
                    t21.Image = Nothing
                    b(21) = 0

                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(21) = 3 Then
                If l(12) = 0 Then
                    p11.Hide()
                    p13.Hide()
                    p12.Hide()
                    t21.Image = Nothing
                    b(21) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(11) = 0 Then
                        l(11) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p6.Bounds.IntersectsWith(t30.Bounds) Then
            If b(30) = 1 Then
                If l(6) = 0 Then
                    p6.Hide()

                    t30.Image = Nothing
                    b(30) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(30) = 2 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p13.Hide()
                    t30.Image = Nothing
                    b(30) = 0

                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(30) = 3 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p5.Hide()
                    p7.Hide()
                    p13.Hide()
                    t30.Image = Nothing
                    b(30) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p6.Bounds.IntersectsWith(t29.Bounds) Then
            If b(29) = 1 Then
                If l(6) = 0 Then
                    p6.Hide()

                    t29.Image = Nothing
                    b(29) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(29) = 2 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p13.Hide()
                    t29.Image = Nothing
                    b(29) = 0

                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(29) = 3 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p5.Hide()
                    p7.Hide()
                    p13.Hide()
                    t29.Image = Nothing
                    b(29) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p6.Bounds.IntersectsWith(t28.Bounds) Then
            If b(28) = 1 Then
                If l(6) = 0 Then
                    p6.Hide()

                    t28.Image = Nothing
                    b(28) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(28) = 2 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p13.Hide()
                    t28.Image = Nothing
                    b(28) = 0

                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(28) = 3 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p5.Hide()
                    p7.Hide()
                    p13.Hide()
                    t28.Image = Nothing
                    b(28) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p6.Bounds.IntersectsWith(t27.Bounds) Then
            If b(27) = 1 Then
                If l(6) = 0 Then
                    p6.Hide()

                    t27.Image = Nothing
                    b(27) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(27) = 2 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p13.Hide()
                    t27.Image = Nothing
                    b(27) = 0

                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(27) = 3 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p5.Hide()
                    p7.Hide()
                    p13.Hide()
                    t27.Image = Nothing
                    b(27) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p6.Bounds.IntersectsWith(t26.Bounds) Then
            If b(26) = 1 Then
                If l(6) = 0 Then
                    p6.Hide()

                    t26.Image = Nothing
                    b(26) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(26) = 2 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p13.Hide()
                    t26.Image = Nothing
                    b(26) = 0

                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(26) = 3 Then
                If l(6) = 0 Then
                    p6.Hide()
                    p5.Hide()
                    p7.Hide()
                    p13.Hide()
                    t26.Image = Nothing
                    b(26) = 0
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(5) = 0 Then
                        l(5) = 1
                        mwave = mwave + 1
                    End If
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p13.Bounds.IntersectsWith(t30.Bounds) Then
            If b(30) = 1 Then
                If l(13) = 0 Then
                    p13.Hide()

                    t30.Image = Nothing
                    b(30) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(30) = 2 Then
                If l(13) = 0 Then

                    p13.Hide()
                    t30.Image = Nothing
                    b(30) = 0

                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(30) = 3 Then
                If l(13) = 0 Then
                    p13.Hide()
                    p12.Hide()
                    p14.Hide()
                    t30.Image = Nothing
                    b(30) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p13.Bounds.IntersectsWith(t29.Bounds) Then
            If b(29) = 1 Then
                If l(13) = 0 Then
                    p13.Hide()

                    t29.Image = Nothing
                    b(29) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(29) = 2 Then
                If l(13) = 0 Then

                    p13.Hide()
                    t29.Image = Nothing
                    b(29) = 0

                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(29) = 3 Then
                If l(13) = 0 Then
                    p13.Hide()
                    p12.Hide()
                    p14.Hide()
                    t29.Image = Nothing
                    b(29) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p13.Bounds.IntersectsWith(t28.Bounds) Then
            If b(28) = 1 Then
                If l(13) = 0 Then
                    p13.Hide()

                    t28.Image = Nothing
                    b(28) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(28) = 2 Then
                If l(13) = 0 Then

                    p13.Hide()
                    t28.Image = Nothing
                    b(28) = 0

                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(28) = 3 Then
                If l(13) = 0 Then
                    p13.Hide()
                    p12.Hide()
                    p14.Hide()
                    t28.Image = Nothing
                    b(28) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p13.Bounds.IntersectsWith(t27.Bounds) Then
            If b(27) = 1 Then
                If l(13) = 0 Then
                    p13.Hide()

                    t27.Image = Nothing
                    b(27) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(27) = 2 Then
                If l(13) = 0 Then

                    p13.Hide()
                    t27.Image = Nothing
                    b(27) = 0

                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(27) = 3 Then
                If l(13) = 0 Then
                    p13.Hide()
                    p12.Hide()
                    p14.Hide()
                    t27.Image = Nothing
                    b(27) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p13.Bounds.IntersectsWith(t26.Bounds) Then
            If b(26) = 1 Then
                If l(13) = 0 Then
                    p13.Hide()

                    t26.Image = Nothing
                    b(26) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(26) = 2 Then
                If l(13) = 0 Then

                    p13.Hide()
                    t26.Image = Nothing
                    b(26) = 0

                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(26) = 3 Then
                If l(13) = 0 Then
                    p13.Hide()
                    p12.Hide()
                    p14.Hide()
                    t26.Image = Nothing
                    b(26) = 0
                    If l(12) = 0 Then
                        l(12) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p7.Bounds.IntersectsWith(t35.Bounds) Then
            If b(35) = 1 Then
                If l(7) = 0 Then
                    p7.Hide()

                    t35.Image = Nothing
                    b(35) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(35) = 2 Then
                If l(7) = 0 Then
                    p14.Hide()
                    p7.Hide()
                    t35.Image = Nothing
                    b(35) = 0

                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(35) = 3 Then
                If l(7) = 0 Then
                    p7.Hide()
                    p6.Hide()
                    p14.Hide()
                    t35.Image = Nothing
                    b(35) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p7.Bounds.IntersectsWith(t34.Bounds) Then
            If b(34) = 1 Then
                If l(7) = 0 Then
                    p7.Hide()

                    t34.Image = Nothing
                    b(34) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(34) = 2 Then
                If l(7) = 0 Then
                    p14.Hide()
                    p7.Hide()
                    t34.Image = Nothing
                    b(34) = 0

                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(34) = 3 Then
                If l(7) = 0 Then
                    p7.Hide()
                    p6.Hide()
                    p14.Hide()
                    t34.Image = Nothing
                    b(34) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p7.Bounds.IntersectsWith(t33.Bounds) Then
            If b(33) = 1 Then
                If l(7) = 0 Then
                    p7.Hide()

                    t33.Image = Nothing
                    b(33) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(33) = 2 Then
                If l(7) = 0 Then
                    p14.Hide()
                    p7.Hide()
                    t33.Image = Nothing
                    b(33) = 0

                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(33) = 3 Then
                If l(7) = 0 Then
                    p7.Hide()
                    p6.Hide()
                    p14.Hide()
                    t33.Image = Nothing
                    b(33) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p7.Bounds.IntersectsWith(t32.Bounds) Then
            If b(32) = 1 Then
                If l(7) = 0 Then
                    p7.Hide()

                    t32.Image = Nothing
                    b(32) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(32) = 2 Then
                If l(7) = 0 Then
                    p14.Hide()
                    p7.Hide()
                    t32.Image = Nothing
                    b(32) = 0

                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(32) = 3 Then
                If l(7) = 0 Then
                    p7.Hide()
                    p6.Hide()
                    p14.Hide()
                    t32.Image = Nothing
                    b(32) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p7.Bounds.IntersectsWith(t31.Bounds) Then
            If b(31) = 1 Then
                If l(7) = 0 Then
                    p7.Hide()

                    t31.Image = Nothing
                    b(31) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(1) = 2 Then
                If l(7) = 0 Then
                    p14.Hide()
                    p7.Hide()

                    t31.Image = Nothing
                    b(31) = 0

                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(31) = 3 Then
                If l(7) = 0 Then
                    p7.Hide()
                    p6.Hide()
                    p14.Hide()

                    t31.Image = Nothing
                    b(31) = 0
                    If l(7) = 0 Then
                        l(7) = 1
                        mwave = mwave + 1
                    End If
                    If l(6) = 0 Then
                        l(6) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If

        If p14.Bounds.IntersectsWith(t35.Bounds) Then
            If b(35) = 1 Then
                If l(14) = 0 Then
                    p14.Hide()

                    t35.Image = Nothing
                    b(35) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(35) = 2 Then
                If l(14) = 0 Then
                    p14.Hide()

                    t35.Image = Nothing
                    b(35) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(35) = 3 Then
                If l(14) = 0 Then
                    p13.Hide()
                    p14.Hide()

                    t35.Image = Nothing
                    b(35) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p14.Bounds.IntersectsWith(t34.Bounds) Then
            If b(34) = 1 Then
                If l(14) = 0 Then
                    p14.Hide()

                    t34.Image = Nothing
                    b(34) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(34) = 2 Then
                If l(14) = 0 Then
                    p14.Hide()

                    t34.Image = Nothing
                    b(34) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(34) = 3 Then
                If l(14) = 0 Then
                    p13.Hide()
                    p14.Hide()

                    t34.Image = Nothing
                    b(34) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p14.Bounds.IntersectsWith(t33.Bounds) Then
            If b(33) = 1 Then
                If l(14) = 0 Then
                    p14.Hide()

                    t33.Image = Nothing
                    b(33) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(33) = 2 Then
                If l(14) = 0 Then
                    p14.Hide()

                    t33.Image = Nothing
                    b(33) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(33) = 3 Then
                If l(14) = 0 Then
                    p13.Hide()
                    p14.Hide()

                    t33.Image = Nothing
                    b(33) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p14.Bounds.IntersectsWith(t32.Bounds) Then
            If b(32) = 1 Then
                If l(14) = 0 Then
                    p14.Hide()

                    t32.Image = Nothing
                    b(32) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(32) = 2 Then
                If l(14) = 0 Then
                    p14.Hide()
                    t32.Image = Nothing

                    b(32) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(32) = 3 Then
                If l(14) = 0 Then
                    p13.Hide()
                    p14.Hide()
                    t32.Image = Nothing

                    b(32) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
        If p14.Bounds.IntersectsWith(t31.Bounds) Then
            If b(31) = 1 Then
                If l(14) = 0 Then
                    p14.Hide()

                    t31.Image = Nothing
                    b(31) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If

                End If
            End If
            If b(31) = 2 Then
                If l(14) = 0 Then
                    p14.Hide()
                    t31.Image = Nothing

                    b(31) = 0
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If

            If b(31) = 3 Then
                If l(14) = 0 Then
                    p13.Hide()
                    p14.Hide()
                    t31.Image = Nothing

                    b(31) = 0
                    If l(13) = 0 Then
                        l(13) = 1
                        mwave = mwave + 1
                    End If
                    If l(14) = 0 Then
                        l(14) = 1
                        mwave = mwave + 1
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
5:
    End Sub


    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub


    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t16.Click
        If bmb(0) = 1 Then
            t16.Image = My.Resources.Dynamite_70681
            b(16) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t16.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(16) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t16.Image = My.Resources.gfBZVMa1
            b(16) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.Click
        If bmb(0) = 1 Then
            t1.Image = My.Resources.Dynamite_70681
            b(1) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t1.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(1) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t1.Image = My.Resources.gfBZVMa1
            b(1) = 3
            bmb(2) = 0
        End If
    End Sub


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2.Click
        If bmb(0) = 1 Then
            t2.Image = My.Resources.Dynamite_70681
            b(2) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t2.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(2) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t2.Image = My.Resources.gfBZVMa1
            b(2) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t4.Click
        If bmb(0) = 1 Then
            t4.Image = My.Resources.Dynamite_70681
            b(4) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t4.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(4) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t4.Image = My.Resources.gfBZVMa1
            b(4) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t5.Click
        If bmb(0) = 1 Then
            t5.Image = My.Resources.Dynamite_70681
            b(5) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t5.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(5) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t5.Image = My.Resources.gfBZVMa1
            b(5) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t3.Click
        If bmb(0) = 1 Then
            t3.Image = My.Resources.Dynamite_70681
            b(3) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t3.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(3) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t3.Image = My.Resources.gfBZVMa1
            b(3) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        intro.Text = Val(intro.Text) - 1
        If Val(intro.Text) = 0 Then

            Timer2.Enabled = False


        End If
        If Timer2.Enabled = False Then
            intro.Text = ""
            intro.SendToBack()
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub t6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t6.Click
        If bmb(0) = 1 Then
            t6.Image = My.Resources.Dynamite_70681
            b(6) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t6.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(6) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t6.Image = My.Resources.gfBZVMa1
            b(6) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t7.Click
        If bmb(0) = 1 Then
            t7.Image = My.Resources.Dynamite_70681
            b(7) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t7.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(7) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t7.Image = My.Resources.gfBZVMa1
            b(7) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If bmb(0) = 1 Then
            t8.Image = My.Resources.Dynamite_70681
            b(8) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t8.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(8) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t8.Image = My.Resources.gfBZVMa1
            b(8) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t9.Click
        If bmb(0) = 1 Then
            t9.Image = My.Resources.Dynamite_70681
            b(9) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t9.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(9) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t9.Image = My.Resources.gfBZVMa1
            b(9) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t10.Click
        If bmb(0) = 1 Then
            t10.Image = My.Resources.Dynamite_70681
            b(10) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t10.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(10) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t10.Image = My.Resources.gfBZVMa1
            b(10) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t11.Click
        If bmb(0) = 1 Then
            t11.Image = My.Resources.Dynamite_70681
            b(11) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t11.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(11) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t11.Image = My.Resources.gfBZVMa1
            b(11) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t12.Click
        If bmb(0) = 1 Then
            t12.Image = My.Resources.Dynamite_70681
            b(12) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t12.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(12) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t12.Image = My.Resources.gfBZVMa1
            b(12) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t13.Click
        If bmb(0) = 1 Then
            t13.Image = My.Resources.Dynamite_70681
            b(13) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t13.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(13) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t13.Image = My.Resources.gfBZVMa1
            b(13) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t14.Click
        If bmb(0) = 1 Then
            t14.Image = My.Resources.Dynamite_70681
            b(14) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t14.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(14) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t14.Image = My.Resources.gfBZVMa1
            b(14) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t15.Click
        If bmb(0) = 1 Then
            t15.Image = My.Resources.Dynamite_70681
            b(15) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t15.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(15) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t15.Image = My.Resources.gfBZVMa1
            b(15) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t17.Click
        If bmb(0) = 1 Then
            t17.Image = My.Resources.Dynamite_70681
            b(17) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t17.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(17) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t17.Image = My.Resources.gfBZVMa1
            b(17) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t18.Click
        If bmb(0) = 1 Then
            t18.Image = My.Resources.Dynamite_70681
            b(18) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t18.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(18) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t18.Image = My.Resources.gfBZVMa1
            b(18) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t19.Click
        If bmb(0) = 1 Then
            t19.Image = My.Resources.Dynamite_70681
            b(19) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t19.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(19) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t19.Image = My.Resources.gfBZVMa1
            b(19) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t20.Click
        If bmb(0) = 1 Then
            t20.Image = My.Resources.Dynamite_70681
            b(20) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t20.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(20) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t20.Image = My.Resources.gfBZVMa1
            b(20) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t21.Click
        If bmb(0) = 1 Then
            t21.Image = My.Resources.Dynamite_70681
            b(21) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t21.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(21) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t21.Image = My.Resources.gfBZVMa1
            b(21) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t22.Click
        If bmb(0) = 1 Then
            t22.Image = My.Resources.Dynamite_70681
            b(22) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t22.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(22) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t22.Image = My.Resources.gfBZVMa1
            b(22) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t23.Click
        If bmb(0) = 1 Then
            t23.Image = My.Resources.Dynamite_70681
            b(23) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t23.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(23) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t23.Image = My.Resources.gfBZVMa1
            b(23) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t24.Click
        If bmb(0) = 1 Then
            t24.Image = My.Resources.Dynamite_70681
            b(24) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t24.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(24) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t24.Image = My.Resources.gfBZVMa1
            b(24) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t25.Click
        If bmb(0) = 1 Then
            t25.Image = My.Resources.Dynamite_70681
            b(25) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t25.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(25) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t25.Image = My.Resources.gfBZVMa1
            b(25) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t26.Click
        If bmb(0) = 1 Then
            t26.Image = My.Resources.Dynamite_70681
            b(26) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t26.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(26) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t26.Image = My.Resources.gfBZVMa1
            b(26) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t27.Click
        If bmb(0) = 1 Then
            t27.Image = My.Resources.Dynamite_70681
            b(27) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t27.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(27) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t27.Image = My.Resources.gfBZVMa1
            b(27) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t28.Click
        If bmb(0) = 1 Then
            t28.Image = My.Resources.Dynamite_70681
            b(28) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t28.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(28) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t28.Image = My.Resources.gfBZVMa1
            b(28) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t29.Click
        If bmb(0) = 1 Then
            t29.Image = My.Resources.Dynamite_70681
            b(29) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t29.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(29) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t29.Image = My.Resources.gfBZVMa1
            b(29) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t30.Click
        If bmb(0) = 1 Then
            t30.Image = My.Resources.Dynamite_70681
            b(30) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t30.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(30) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t30.Image = My.Resources.gfBZVMa1
            b(30) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t31.Click
        If bmb(0) = 1 Then
            t31.Image = My.Resources.Dynamite_70681
            b(31) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t31.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(31) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t31.Image = My.Resources.gfBZVMa1
            b(31) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t32.Click
        If bmb(0) = 1 Then
            t32.Image = My.Resources.Dynamite_70681
            b(32) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t32.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(32) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t32.Image = My.Resources.gfBZVMa1
            b(32) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t33.Click
        If bmb(0) = 1 Then
            t33.Image = My.Resources.Dynamite_70681
            b(33) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t33.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(33) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t33.Image = My.Resources.gfBZVMa1
            b(33) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t34.Click
        If bmb(0) = 1 Then
            t34.Image = My.Resources.Dynamite_70681
            b(34) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t34.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(34) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t34.Image = My.Resources.gfBZVMa1
            b(34) = 3
            bmb(2) = 0
        End If
    End Sub

    Private Sub t35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t35.Click
        If bmb(0) = 1 Then
            t35.Image = My.Resources.Dynamite_70681
            b(35) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t35.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(35) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t35.Image = My.Resources.gfBZVMa1
            b(35) = 3
            bmb(2) = 0


        End If
    End Sub

    Private Sub t8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t8.Click
        If bmb(0) = 1 Then
            t8.Image = My.Resources.Dynamite_70681
            b(8) = 1
            bmb(0) = 0
        End If
        If bmb(1) = 1 Then
            t8.Image = My.Resources.Cartoon_Bomb_clip_art_hight1
            b(8) = 2
            bmb(1) = 0
        End If
        If bmb(2) = 1 Then
            t8.Image = My.Resources.gfBZVMa1
            b(8) = 3
            bmb(2) = 0


        End If
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        bmb(0) = 1
        bmb(1) = 0
        bmb(2) = 0
        cd1.Enabled = TRUE

        cdbox1.Text = "3"
        cdbox1.BringToFront()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        bmb(0) = 0
        bmb(1) = 1
        bmb(2) = 0
        cd2.Enabled = True
        cdbox2.Text = "5"
        cdbox2.BringToFront()
    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        bmb(0) = 0
        bmb(1) = 0
        bmb(2) = 1
        cd3.Enabled = True
        cdbox3.Text = "10"
        cdbox3.BringToFront()
    End Sub

    Private Sub cd1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd1.Tick

        cdbox1.Text = Val(cdbox1.Text) - 1
        If Val(cdbox1.Text) = 0 = True Then

            cd1.Enabled = False
        End If
        If cd1.Enabled = False Then
            cdbox1.SendToBack()
            cdbox1.Text = " "

        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdbox2.Click
        If buy(0) = 0 Then
            If money >= 20 Then
                money = money - 20
                buy(0) = 1
                cdbox2.SendToBack()
            Else
                MsgBox("You Dont Have Enough Money")
            End If
        End If

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intro.Click

    End Sub

    Private Sub cdbox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdbox3.Click
        If buy(1) = 0 Then
            If money >= 50 Then
                money = money - 50
                buy(1) = 1
                cdbox3.SendToBack()

            Else
                MsgBox("You Dont Have Enough Money")
            End If
        End If
    End Sub

    Private Sub cd2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd2.Tick

        cdbox2.Text = Val(cdbox2.Text) - 1
        If Val(cdbox2.Text) = 0 = True Then

            cd2.Enabled = False
        End If
        If cd2.Enabled = False Then
            cdbox2.SendToBack()
            cdbox2.Text = " "

        End If
    End Sub

    Private Sub cd3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd3.Tick

        cdbox3.Text = Val(cdbox3.Text) - 1
        If Val(cdbox3.Text) = 0 = True Then

            cd3.Enabled = False
        End If
        If cd3.Enabled = False Then
            cdbox3.SendToBack()
            cdbox3.Text = " "

        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub p8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p8.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rep.Click
        If ProgressBar1.Value <= 65 Then
            If money < 20 Then
                MsgBox("Not Enough Money")
            Else
                ProgressBar1.Value = ProgressBar1.Value + 35
                money = money - 20
            End If
        Else

        End If
        repa.BringToFront()
        repa.Text = "3"
        repair.Enabled = True
    End Sub

    Private Sub repair_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repair.Tick

        repa.Text = Val(repa.Text) - 1
        If Val(repa.Text) <= 0 Then
            repa.SendToBack()
            repair.Enabled = False
        End If
    End Sub
End Class
