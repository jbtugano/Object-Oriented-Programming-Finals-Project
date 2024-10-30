<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainGame))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MovingRoad = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.RaceCar = New System.Windows.Forms.PictureBox()
        Me.LeftDirect = New System.Windows.Forms.Timer(Me.components)
        Me.RightDirect = New System.Windows.Forms.Timer(Me.components)
        Me.ECar3 = New System.Windows.Forms.PictureBox()
        Me.ECar1 = New System.Windows.Forms.PictureBox()
        Me.ECar2 = New System.Windows.Forms.PictureBox()
        Me.ECar1_Move = New System.Windows.Forms.Timer(Me.components)
        Me.ECar2_Move = New System.Windows.Forms.Timer(Me.components)
        Me.ECar3_Move = New System.Windows.Forms.Timer(Me.components)
        Me.EndText = New System.Windows.Forms.Label()
        Me.ScoreText = New System.Windows.Forms.Label()
        Me.ReplayBttn = New System.Windows.Forms.Button()
        Me.SpeedText = New System.Windows.Forms.Label()
        Me.UpDirect = New System.Windows.Forms.Timer(Me.components)
        Me.DownDirect = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RaceCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ECar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ECar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ECar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(105, -194)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 169)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Location = New System.Drawing.Point(259, -194)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 169)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox4.Location = New System.Drawing.Point(259, 25)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 169)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox3.Location = New System.Drawing.Point(105, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 169)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox6.Location = New System.Drawing.Point(259, 257)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 169)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox5.Location = New System.Drawing.Point(105, 257)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 169)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'MovingRoad
        '
        Me.MovingRoad.Enabled = True
        Me.MovingRoad.Interval = 10
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox7.Location = New System.Drawing.Point(259, 475)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 208)
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox8.Location = New System.Drawing.Point(105, 475)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 208)
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'RaceCar
        '
        Me.RaceCar.Image = CType(resources.GetObject("RaceCar.Image"), System.Drawing.Image)
        Me.RaceCar.Location = New System.Drawing.Point(172, 429)
        Me.RaceCar.Name = "RaceCar"
        Me.RaceCar.Size = New System.Drawing.Size(39, 91)
        Me.RaceCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RaceCar.TabIndex = 8
        Me.RaceCar.TabStop = False
        '
        'LeftDirect
        '
        Me.LeftDirect.Interval = 10
        '
        'RightDirect
        '
        Me.RightDirect.Interval = 10
        '
        'ECar3
        '
        Me.ECar3.Image = CType(resources.GetObject("ECar3.Image"), System.Drawing.Image)
        Me.ECar3.Location = New System.Drawing.Point(304, 283)
        Me.ECar3.Name = "ECar3"
        Me.ECar3.Size = New System.Drawing.Size(39, 91)
        Me.ECar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ECar3.TabIndex = 9
        Me.ECar3.TabStop = False
        '
        'ECar1
        '
        Me.ECar1.Image = CType(resources.GetObject("ECar1.Image"), System.Drawing.Image)
        Me.ECar1.Location = New System.Drawing.Point(34, 176)
        Me.ECar1.Name = "ECar1"
        Me.ECar1.Size = New System.Drawing.Size(39, 91)
        Me.ECar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ECar1.TabIndex = 10
        Me.ECar1.TabStop = False
        '
        'ECar2
        '
        Me.ECar2.Image = CType(resources.GetObject("ECar2.Image"), System.Drawing.Image)
        Me.ECar2.Location = New System.Drawing.Point(172, -36)
        Me.ECar2.Name = "ECar2"
        Me.ECar2.Size = New System.Drawing.Size(39, 91)
        Me.ECar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ECar2.TabIndex = 11
        Me.ECar2.TabStop = False
        '
        'ECar1_Move
        '
        Me.ECar1_Move.Enabled = True
        Me.ECar1_Move.Interval = 10
        '
        'ECar2_Move
        '
        Me.ECar2_Move.Enabled = True
        Me.ECar2_Move.Interval = 10
        '
        'ECar3_Move
        '
        Me.ECar3_Move.Enabled = True
        Me.ECar3_Move.Interval = 10
        '
        'EndText
        '
        Me.EndText.BackColor = System.Drawing.Color.Transparent
        Me.EndText.Font = New System.Drawing.Font("Broadway", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndText.ForeColor = System.Drawing.Color.Red
        Me.EndText.Location = New System.Drawing.Point(88, 102)
        Me.EndText.Name = "EndText"
        Me.EndText.Size = New System.Drawing.Size(206, 92)
        Me.EndText.TabIndex = 12
        Me.EndText.Text = "GAME OVER"
        Me.EndText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EndText.Visible = False
        '
        'ScoreText
        '
        Me.ScoreText.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreText.ForeColor = System.Drawing.Color.White
        Me.ScoreText.Location = New System.Drawing.Point(2, 9)
        Me.ScoreText.Name = "ScoreText"
        Me.ScoreText.Size = New System.Drawing.Size(111, 25)
        Me.ScoreText.TabIndex = 13
        Me.ScoreText.Text = "Score: 0"
        Me.ScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReplayBttn
        '
        Me.ReplayBttn.BackColor = System.Drawing.Color.White
        Me.ReplayBttn.BackgroundImage = CType(resources.GetObject("ReplayBttn.BackgroundImage"), System.Drawing.Image)
        Me.ReplayBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReplayBttn.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReplayBttn.ForeColor = System.Drawing.Color.Red
        Me.ReplayBttn.Location = New System.Drawing.Point(157, 245)
        Me.ReplayBttn.Name = "ReplayBttn"
        Me.ReplayBttn.Size = New System.Drawing.Size(69, 71)
        Me.ReplayBttn.TabIndex = 14
        Me.ReplayBttn.UseVisualStyleBackColor = False
        Me.ReplayBttn.Visible = False
        '
        'SpeedText
        '
        Me.SpeedText.Font = New System.Drawing.Font("Showcard Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedText.ForeColor = System.Drawing.Color.White
        Me.SpeedText.Location = New System.Drawing.Point(274, 9)
        Me.SpeedText.Name = "SpeedText"
        Me.SpeedText.Size = New System.Drawing.Size(111, 25)
        Me.SpeedText.TabIndex = 15
        Me.SpeedText.Text = "Speed: 0"
        Me.SpeedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpDirect
        '
        Me.UpDirect.Interval = 10
        '
        'DownDirect
        '
        Me.DownDirect.Interval = 10
        '
        'MainGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(382, 553)
        Me.Controls.Add(Me.SpeedText)
        Me.Controls.Add(Me.ReplayBttn)
        Me.Controls.Add(Me.ScoreText)
        Me.Controls.Add(Me.EndText)
        Me.Controls.Add(Me.ECar2)
        Me.Controls.Add(Me.ECar1)
        Me.Controls.Add(Me.ECar3)
        Me.Controls.Add(Me.RaceCar)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(400, 600)
        Me.MinimumSize = New System.Drawing.Size(400, 600)
        Me.Name = "MainGame"
        Me.Text = "MainGame"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RaceCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ECar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ECar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ECar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents MovingRoad As System.Windows.Forms.Timer
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents RaceCar As System.Windows.Forms.PictureBox
    Friend WithEvents LeftDirect As System.Windows.Forms.Timer
    Friend WithEvents RightDirect As System.Windows.Forms.Timer
    Friend WithEvents ECar3 As System.Windows.Forms.PictureBox
    Friend WithEvents ECar1 As System.Windows.Forms.PictureBox
    Friend WithEvents ECar2 As System.Windows.Forms.PictureBox
    Friend WithEvents ECar1_Move As System.Windows.Forms.Timer
    Friend WithEvents ECar2_Move As System.Windows.Forms.Timer
    Friend WithEvents ECar3_Move As System.Windows.Forms.Timer
    Friend WithEvents EndText As System.Windows.Forms.Label
    Friend WithEvents ScoreText As System.Windows.Forms.Label
    Friend WithEvents ReplayBttn As System.Windows.Forms.Button
    Friend WithEvents SpeedText As System.Windows.Forms.Label
    Friend WithEvents UpDirect As System.Windows.Forms.Timer
    Friend WithEvents DownDirect As System.Windows.Forms.Timer

End Class
