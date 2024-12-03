<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BackBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ItemMngGOBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.CatMngGOBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.DashGOBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.OrderGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.GrandTot = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.CountTxt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ExitBTN2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.ExitBTN = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2GradientPanel4 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientPanel5 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.GunaPieDataset2 = New Guna.Charts.WinForms.GunaPieDataset()
        Me.GunaAreaDataset1 = New Guna.Charts.WinForms.GunaAreaDataset()
        Me.GunaAreaDataset2 = New Guna.Charts.WinForms.GunaAreaDataset()
        Me.GunaAreaDataset3 = New Guna.Charts.WinForms.GunaAreaDataset()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.OrderGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2GradientPanel3.SuspendLayout()
        CType(Me.ExitBTN2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel4.SuspendLayout()
        Me.Guna2GradientPanel5.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BackBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BackBTN.ForeColor = System.Drawing.Color.White
        Me.BackBTN.Location = New System.Drawing.Point(47, 431)
        Me.BackBTN.Name = "BackBTN"
        Me.BackBTN.Size = New System.Drawing.Size(102, 43)
        Me.BackBTN.TabIndex = 9
        Me.BackBTN.Text = "LOGOUT"
        Me.BackBTN.UseTransparentBackground = True
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(62, 59)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(161, 31)
        Me.Guna2HtmlLabel2.TabIndex = 12
        Me.Guna2HtmlLabel2.Text = "DASHBOARD"
        '
        'ItemMngGOBTN
        '
        Me.ItemMngGOBTN.Animated = True
        Me.ItemMngGOBTN.AutoRoundedCorners = True
        Me.ItemMngGOBTN.BackColor = System.Drawing.Color.Transparent
        Me.ItemMngGOBTN.BorderRadius = 20
        Me.ItemMngGOBTN.BorderThickness = -1
        Me.ItemMngGOBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.ItemMngGOBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ItemMngGOBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ItemMngGOBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ItemMngGOBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ItemMngGOBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ItemMngGOBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ItemMngGOBTN.FillColor = System.Drawing.Color.DarkRed
        Me.ItemMngGOBTN.FillColor2 = System.Drawing.Color.Maroon
        Me.ItemMngGOBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ItemMngGOBTN.ForeColor = System.Drawing.Color.White
        Me.ItemMngGOBTN.Location = New System.Drawing.Point(47, 305)
        Me.ItemMngGOBTN.Name = "ItemMngGOBTN"
        Me.ItemMngGOBTN.Size = New System.Drawing.Size(189, 43)
        Me.ItemMngGOBTN.TabIndex = 11
        Me.ItemMngGOBTN.Text = "ITEMS"
        Me.ItemMngGOBTN.UseTransparentBackground = True
        '
        'CatMngGOBTN
        '
        Me.CatMngGOBTN.Animated = True
        Me.CatMngGOBTN.AutoRoundedCorners = True
        Me.CatMngGOBTN.BackColor = System.Drawing.Color.Transparent
        Me.CatMngGOBTN.BorderRadius = 20
        Me.CatMngGOBTN.BorderThickness = -1
        Me.CatMngGOBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.CatMngGOBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CatMngGOBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CatMngGOBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CatMngGOBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CatMngGOBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CatMngGOBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CatMngGOBTN.FillColor = System.Drawing.Color.DarkRed
        Me.CatMngGOBTN.FillColor2 = System.Drawing.Color.Maroon
        Me.CatMngGOBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CatMngGOBTN.ForeColor = System.Drawing.Color.White
        Me.CatMngGOBTN.Location = New System.Drawing.Point(47, 235)
        Me.CatMngGOBTN.Name = "CatMngGOBTN"
        Me.CatMngGOBTN.Size = New System.Drawing.Size(189, 43)
        Me.CatMngGOBTN.TabIndex = 10
        Me.CatMngGOBTN.Text = "CATOGORIES"
        Me.CatMngGOBTN.UseTransparentBackground = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.DashGOBTN)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.ItemMngGOBTN)
        Me.Guna2GradientPanel1.Controls.Add(Me.CatMngGOBTN)
        Me.Guna2GradientPanel1.Controls.Add(Me.BackBTN)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Gold
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkGoldenrod
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(265, 517)
        Me.Guna2GradientPanel1.TabIndex = 24
        '
        'DashGOBTN
        '
        Me.DashGOBTN.Animated = True
        Me.DashGOBTN.AutoRoundedCorners = True
        Me.DashGOBTN.BackColor = System.Drawing.Color.Transparent
        Me.DashGOBTN.BorderRadius = 20
        Me.DashGOBTN.BorderThickness = -1
        Me.DashGOBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.DashGOBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashGOBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DashGOBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DashGOBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DashGOBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DashGOBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DashGOBTN.FillColor = System.Drawing.Color.DarkRed
        Me.DashGOBTN.FillColor2 = System.Drawing.Color.Maroon
        Me.DashGOBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DashGOBTN.ForeColor = System.Drawing.Color.White
        Me.DashGOBTN.Location = New System.Drawing.Point(47, 156)
        Me.DashGOBTN.Name = "DashGOBTN"
        Me.DashGOBTN.Size = New System.Drawing.Size(189, 43)
        Me.DashGOBTN.TabIndex = 14
        Me.DashGOBTN.Text = "DASHBOARD"
        Me.DashGOBTN.UseTransparentBackground = True
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
        'OrderGridView
        '
        Me.OrderGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.OrderGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.OrderGridView.ColumnHeadersHeight = 4
        Me.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.OrderGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.OrderGridView, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrderGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.OrderGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.OrderGridView.Location = New System.Drawing.Point(324, 235)
        Me.OrderGridView.Name = "OrderGridView"
        Me.OrderGridView.ReadOnly = True
        Me.OrderGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.OrderGridView.RowHeadersVisible = False
        Me.OrderGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.OrderGridView.Size = New System.Drawing.Size(387, 236)
        Me.OrderGridView.TabIndex = 32
        Me.OrderGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot
        Me.OrderGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.OrderGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OrderGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Yellow
        Me.OrderGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.OrderGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.OrderGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.OrderGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.OrderGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.OrderGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.OrderGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.OrderGridView.ThemeStyle.HeaderStyle.Height = 4
        Me.OrderGridView.ThemeStyle.ReadOnly = True
        Me.OrderGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.OrderGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.OrderGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.OrderGridView.ThemeStyle.RowsStyle.Height = 22
        Me.OrderGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Yellow
        Me.OrderGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BorderRadius = 20
        Me.Guna2GradientPanel2.Controls.Add(Me.GrandTot)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.DarkRed
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.Maroon
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(283, 12)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(200, 100)
        Me.Guna2GradientPanel2.TabIndex = 33
        '
        'GrandTot
        '
        Me.GrandTot.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.GrandTot, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GrandTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTot.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrandTot.IsSelectionEnabled = False
        Me.GrandTot.Location = New System.Drawing.Point(63, 47)
        Me.GrandTot.Name = "GrandTot"
        Me.GrandTot.Size = New System.Drawing.Size(87, 31)
        Me.GrandTot.TabIndex = 16
        Me.GrandTot.Text = "TOTAL"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(41, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(133, 22)
        Me.Guna2HtmlLabel1.TabIndex = 14
        Me.Guna2HtmlLabel1.Text = "Total Appointment"
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.BorderRadius = 20
        Me.Guna2GradientPanel3.Controls.Add(Me.CountTxt)
        Me.Guna2GradientPanel3.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.DarkRed
        Me.Guna2GradientPanel3.FillColor2 = System.Drawing.Color.Maroon
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(579, 12)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(200, 100)
        Me.Guna2GradientPanel3.TabIndex = 35
        '
        'CountTxt
        '
        Me.CountTxt.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.CountTxt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CountTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CountTxt.IsSelectionEnabled = False
        Me.CountTxt.Location = New System.Drawing.Point(59, 40)
        Me.CountTxt.Name = "CountTxt"
        Me.CountTxt.Size = New System.Drawing.Size(87, 31)
        Me.CountTxt.TabIndex = 16
        Me.CountTxt.Text = "TOTAL"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2HtmlLabel7.IsSelectionEnabled = False
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(14, 12)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(166, 22)
        Me.Guna2HtmlLabel7.TabIndex = 14
        Me.Guna2HtmlLabel7.Text = "Appointment Approved"
        '
        'ExitBTN2
        '
        Me.ExitBTN2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.ExitBTN2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ExitBTN2.Image = Global.Pizza_Shop_System.My.Resources.Resource.Close_BTN1
        Me.ExitBTN2.ImageRotate = 0!
        Me.ExitBTN2.Location = New System.Drawing.Point(839, 0)
        Me.ExitBTN2.Name = "ExitBTN2"
        Me.ExitBTN2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ExitBTN2.Size = New System.Drawing.Size(29, 29)
        Me.ExitBTN2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitBTN2.TabIndex = 31
        Me.ExitBTN2.TabStop = False
        '
        'ExitBTN
        '
        Me.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.ExitBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ExitBTN.Image = Global.Pizza_Shop_System.My.Resources.Resource.Close_BTN1
        Me.ExitBTN.ImageRotate = 0!
        Me.ExitBTN.Location = New System.Drawing.Point(805, -31)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ExitBTN.Size = New System.Drawing.Size(29, 29)
        Me.ExitBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitBTN.TabIndex = 25
        Me.ExitBTN.TabStop = False
        '
        'Guna2GradientPanel4
        '
        Me.Guna2GradientPanel4.AutoRoundedCorners = True
        Me.Guna2GradientPanel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel4.BorderRadius = 19
        Me.Guna2GradientPanel4.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2GradientPanel4.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel4.FillColor = System.Drawing.Color.DarkRed
        Me.Guna2GradientPanel4.FillColor2 = System.Drawing.Color.Maroon
        Me.Guna2GradientPanel4.Location = New System.Drawing.Point(383, 139)
        Me.Guna2GradientPanel4.Name = "Guna2GradientPanel4"
        Me.Guna2GradientPanel4.Size = New System.Drawing.Size(313, 40)
        Me.Guna2GradientPanel4.TabIndex = 53
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2HtmlLabel8.IsSelectionEnabled = False
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(35, 3)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(238, 31)
        Me.Guna2HtmlLabel8.TabIndex = 15
        Me.Guna2HtmlLabel8.Text = "Recent Appointment"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel5.IsSelectionEnabled = False
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(542, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(123, 32)
        Me.Guna2HtmlLabel5.TabIndex = 48
        Me.Guna2HtmlLabel5.Text = "Today Menu"
        '
        'Guna2GradientPanel5
        '
        Me.Guna2GradientPanel5.AutoRoundedCorners = True
        Me.Guna2GradientPanel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel5.BorderRadius = 10
        Me.Guna2GradientPanel5.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Guna2GradientPanel5.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2GradientPanel5.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GradientPanel5.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel5.FillColor = System.Drawing.Color.DarkRed
        Me.Guna2GradientPanel5.FillColor2 = System.Drawing.Color.Maroon
        Me.Guna2GradientPanel5.Location = New System.Drawing.Point(324, 202)
        Me.Guna2GradientPanel5.Name = "Guna2GradientPanel5"
        Me.Guna2GradientPanel5.Size = New System.Drawing.Size(387, 22)
        Me.Guna2GradientPanel5.TabIndex = 54
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2HtmlLabel11.IsSelectionEnabled = False
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(287, -2)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(62, 22)
        Me.Guna2HtmlLabel11.TabIndex = 51
        Me.Guna2HtmlLabel11.Text = "Total Bill"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2HtmlLabel10.IsSelectionEnabled = False
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(157, -2)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(38, 22)
        Me.Guna2HtmlLabel10.TabIndex = 50
        Me.Guna2HtmlLabel10.Text = "Date"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2HtmlLabel6.IsSelectionEnabled = False
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(23, -2)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(86, 22)
        Me.Guna2HtmlLabel6.TabIndex = 49
        Me.Guna2HtmlLabel6.Text = "Payment ID"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel9.IsSelectionEnabled = False
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(542, 0)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(123, 32)
        Me.Guna2HtmlLabel9.TabIndex = 48
        Me.Guna2HtmlLabel9.Text = "Today Menu"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'GunaPieDataset2
        '
        Me.GunaPieDataset2.Label = "Pie2"
        '
        'GunaAreaDataset1
        '
        Me.GunaAreaDataset1.BorderColor = System.Drawing.Color.Empty
        Me.GunaAreaDataset1.FillColor = System.Drawing.Color.Empty
        Me.GunaAreaDataset1.Label = "Area1"
        '
        'GunaAreaDataset2
        '
        Me.GunaAreaDataset2.BorderColor = System.Drawing.Color.Empty
        Me.GunaAreaDataset2.FillColor = System.Drawing.Color.Empty
        Me.GunaAreaDataset2.Label = "Area2"
        '
        'GunaAreaDataset3
        '
        Me.GunaAreaDataset3.BorderColor = System.Drawing.Color.Empty
        Me.GunaAreaDataset3.FillColor = System.Drawing.Color.Empty
        Me.GunaAreaDataset3.Label = "Area3"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(870, 499)
        Me.Controls.Add(Me.Guna2GradientPanel5)
        Me.Controls.Add(Me.Guna2GradientPanel4)
        Me.Controls.Add(Me.Guna2GradientPanel3)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.ExitBTN2)
        Me.Controls.Add(Me.OrderGridView)
        Me.Controls.Add(Me.ExitBTN)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.OrderGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        Me.Guna2GradientPanel3.PerformLayout()
        CType(Me.ExitBTN2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitBTN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel4.ResumeLayout(False)
        Me.Guna2GradientPanel4.PerformLayout()
        Me.Guna2GradientPanel5.ResumeLayout(False)
        Me.Guna2GradientPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents ExitBTN As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BackBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ItemMngGOBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents CatMngGOBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents DashGOBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents GunaPieDataset2 As Guna.Charts.WinForms.GunaPieDataset
    Friend WithEvents ExitBTN2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents OrderGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GrandTot As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents CountTxt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientPanel4 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientPanel5 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GunaAreaDataset1 As Guna.Charts.WinForms.GunaAreaDataset
    Friend WithEvents GunaAreaDataset2 As Guna.Charts.WinForms.GunaAreaDataset
    Friend WithEvents GunaAreaDataset3 As Guna.Charts.WinForms.GunaAreaDataset
End Class
