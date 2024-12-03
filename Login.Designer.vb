<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LoginBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.BackBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ExitBTN = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PasswordTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UsernameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.ExitBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(39, 186)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(213, 42)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Welcome Back !"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Gold
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkGoldenrod
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-85, -24)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(312, 454)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(87, 245)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(222, 31)
        Me.Guna2HtmlLabel2.TabIndex = 0
        Me.Guna2HtmlLabel2.Text = "WELCOME BACK !"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel4.IsSelectionEnabled = False
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(290, 88)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(84, 31)
        Me.Guna2HtmlLabel4.TabIndex = 3
        Me.Guna2HtmlLabel4.Text = "ADMIN "
        '
        'LoginBTN
        '
        Me.LoginBTN.Animated = True
        Me.LoginBTN.AutoRoundedCorners = True
        Me.LoginBTN.BackColor = System.Drawing.Color.Transparent
        Me.LoginBTN.BorderRadius = 20
        Me.LoginBTN.BorderThickness = -1
        Me.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.LoginBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoginBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginBTN.FillColor = System.Drawing.Color.Black
        Me.LoginBTN.FillColor2 = System.Drawing.Color.Black
        Me.LoginBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LoginBTN.ForeColor = System.Drawing.Color.White
        Me.LoginBTN.Location = New System.Drawing.Point(243, 286)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(109, 43)
        Me.LoginBTN.TabIndex = 5
        Me.LoginBTN.Text = "LOGIN"
        Me.LoginBTN.UseTransparentBackground = True
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'BackBTN
        '
        Me.BackBTN.Animated = True
        Me.BackBTN.AutoRoundedCorners = True
        Me.BackBTN.BackColor = System.Drawing.Color.Transparent
        Me.BackBTN.BorderRadius = 20
        Me.BackBTN.BorderThickness = -1
        Me.BackBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BackBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BackBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BackBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BackBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BackBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BackBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BackBTN.FillColor = System.Drawing.Color.Black
        Me.BackBTN.FillColor2 = System.Drawing.Color.Black
        Me.BackBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BackBTN.ForeColor = System.Drawing.Color.White
        Me.BackBTN.Location = New System.Drawing.Point(358, 286)
        Me.BackBTN.Name = "BackBTN"
        Me.BackBTN.Size = New System.Drawing.Size(102, 43)
        Me.BackBTN.TabIndex = 8
        Me.BackBTN.Text = "USER"
        Me.BackBTN.UseTransparentBackground = True
        '
        'ExitBTN
        '
        Me.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.ExitBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ExitBTN.Image = Global.Pizza_Shop_System.My.Resources.Resource.Close_BTN1
        Me.ExitBTN.ImageRotate = 0!
        Me.ExitBTN.Location = New System.Drawing.Point(437, 5)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ExitBTN.Size = New System.Drawing.Size(29, 29)
        Me.ExitBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitBTN.TabIndex = 9
        Me.ExitBTN.TabStop = False
        '
        'PasswordTB
        '
        Me.PasswordTB.Animated = True
        Me.PasswordTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.PasswordTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.PasswordTB.AutoRoundedCorners = True
        Me.PasswordTB.BorderColor = System.Drawing.Color.Gray
        Me.PasswordTB.BorderRadius = 17
        Me.PasswordTB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.PasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.PasswordTB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PasswordTB.DefaultText = ""
        Me.PasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordTB.ForeColor = System.Drawing.Color.Black
        Me.PasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTB.IconLeft = CType(resources.GetObject("PasswordTB.IconLeft"), System.Drawing.Image)
        Me.PasswordTB.IconLeftOffset = New System.Drawing.Point(7, 0)
        Me.PasswordTB.IconLeftSize = New System.Drawing.Size(15, 15)
        Me.PasswordTB.Location = New System.Drawing.Point(243, 216)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.PasswordTB.PlaceholderText = "Enter Password"
        Me.PasswordTB.SelectedText = ""
        Me.PasswordTB.Size = New System.Drawing.Size(200, 36)
        Me.PasswordTB.TabIndex = 4
        '
        'UsernameTB
        '
        Me.UsernameTB.Animated = True
        Me.UsernameTB.AutoCompleteCustomSource.AddRange(New String() {"Admin"})
        Me.UsernameTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.UsernameTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.UsernameTB.AutoRoundedCorners = True
        Me.UsernameTB.BorderColor = System.Drawing.Color.Gray
        Me.UsernameTB.BorderRadius = 17
        Me.UsernameTB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.UsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.UsernameTB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UsernameTB.DefaultText = ""
        Me.UsernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UsernameTB.ForeColor = System.Drawing.Color.Black
        Me.UsernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTB.IconLeft = CType(resources.GetObject("UsernameTB.IconLeft"), System.Drawing.Image)
        Me.UsernameTB.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.UsernameTB.Location = New System.Drawing.Point(243, 156)
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTB.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UsernameTB.PlaceholderText = "Enter Your ID"
        Me.UsernameTB.SelectedText = ""
        Me.UsernameTB.Size = New System.Drawing.Size(200, 36)
        Me.UsernameTB.TabIndex = 1
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.Image = Global.Pizza_Shop_System.My.Resources.Resource.logo_saloon
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(97, 45)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(185, 171)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 56
        Me.Guna2PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 420)
        Me.Controls.Add(Me.ExitBTN)
        Me.Controls.Add(Me.BackBTN)
        Me.Controls.Add(Me.LoginBTN)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.UsernameTB)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.ExitBTN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents LoginBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PasswordTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UsernameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BackBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ExitBTN As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
