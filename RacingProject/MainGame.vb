Public Class MainGame
    Dim Speed As Integer
    Dim road(7) As PictureBox
    Dim Score As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Speed = 4
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
    End Sub

    Private Sub MovingRoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovingRoad.Tick
        For x As Integer = 0 To 5
            road(x).Top += Speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If Score > 10 And Score < 20 Then
            Speed = 5
        End If
        If Score > 20 And Score < 30 Then
            Speed = 6
        End If
        If Score > 30 Then
            Speed = 8
        End If
        SpeedText.Text = "Speed " & Speed
        If (RaceCar.Bounds.IntersectsWith(ECar1.Bounds)) Then
            gameOver()
        End If
        If (RaceCar.Bounds.IntersectsWith(ECar2.Bounds)) Then
            gameOver()
        End If
        If (RaceCar.Bounds.IntersectsWith(ECar3.Bounds)) Then
            gameOver()
        End If
    End Sub
    Private Sub gameOver()
        ReplayBttn.Visible = True
        EndText.Visible = True
        MovingRoad.Stop()
        ECar1_Move.Stop()
        ECar2_Move.Stop()
        ECar3_Move.Stop()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            UpDirect.Start()
        End If
        If e.KeyCode = Keys.A Then
            LeftDirect.Start()
        End If
        If e.KeyCode = Keys.S Then
            DownDirect.Start()
        End If
        If e.KeyCode = Keys.D Then
            RightDirect.Start()
        End If
    End Sub
    Private Sub UpDirect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpDirect.Tick
        If (RaceCar.Location.X < 220) Then
            RaceCar.Top -= 5
        End If
    End Sub
    Private Sub DownDirect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownDirect.Tick
        If (RaceCar.Location.X > 0) Then
            RaceCar.Top += 5
        End If
    End Sub

    Private Sub LeftDirect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftDirect.Tick
        If (RaceCar.Location.X > 0) Then
            RaceCar.Left -= 5
        End If
    End Sub

    Private Sub RightDirect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightDirect.Tick
        If (RaceCar.Location.X < 250) Then
            RaceCar.Left += 5
        End If
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        UpDirect.Stop()
        DownDirect.Stop()
        LeftDirect.Stop()
        RightDirect.Stop()
    End Sub

    Private Sub ECar1_Move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECar1_Move.Tick
        ECar1.Top += Speed + 2
        If ECar1.Top >= Me.Height Then
            Score += 1
            ScoreText.Text = "Score " & Score
            ECar1.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + ECar1.Height)
            ECar1.Left = CInt(Math.Ceiling(Rnd() * 100)) + 50
        End If
    End Sub

    Private Sub ECar2_Move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECar2_Move.Tick
        ECar2.Top += Speed + 1
        If ECar2.Top >= Me.Height Then
            Score += 1
            ScoreText.Text = "Score " & Score
            ECar2.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + ECar2.Height)
            ECar2.Left = CInt(Math.Ceiling(Rnd() * 100)) + 100
        End If
    End Sub

    Private Sub ECar3_Move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECar3_Move.Tick
        ECar3.Top += Speed * 2
        If ECar3.Top >= Me.Height Then
            Score += 1
            ScoreText.Text = "Score " & Score
            ECar3.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + ECar3.Height)
            ECar3.Left = CInt(Math.Ceiling(Rnd() * 50)) + 200
        End If
    End Sub

    Private Sub ReplayBttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplayBttn.Click
        Score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
End Class
