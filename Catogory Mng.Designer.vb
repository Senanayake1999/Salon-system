<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Catogory_Mng
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
        Dim Animation3 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catogory_Mng))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.CatTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.CatCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CatNameTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CatGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.CatAddBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.DelBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ExitBTN = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.DashGOBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ItemMngGOBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.CatMngGOBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BackBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel5 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.CatGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel3.SuspendLayout()
        CType(Me.ExitBTN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation3
        '
        'CatTB
        '
        Me.CatTB.AutoRoundedCorners = True
        Me.CatTB.BackColor = System.Drawing.Color.Transparent
        Me.CatTB.BorderColor = System.Drawing.Color.Black
        Me.CatTB.BorderRadius = 17
        Me.CatTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.CatTB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CatTB.DefaultText = ""
        Me.CatTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CatTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CatTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CatTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CatTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CatTB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CatTB.Location = New System.Drawing.Point(191, 76)
        Me.CatTB.Name = "CatTB"
        Me.CatTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CatTB.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CatTB.PlaceholderText = "Add New Catogory"
        Me.CatTB.SelectedText = ""
        Me.CatTB.Size = New System.Drawing.Size(200, 36)
        Me.CatTB.TabIndex = 25
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BorderRadius = 20
        Me.Guna2GradientPanel2.Controls.Add(Me.CatCB)
        Me.Guna2GradientPanel2.Controls.Add(Me.CatTB)
        Me.Guna2GradientPanel2.Controls.Add(Me.CatNameTB)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.Gold
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.DarkGoldenrod
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(252, 46)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(554, 155)
        Me.Guna2GradientPanel2.TabIndex = 26
        '
        'CatCB
        '
        Me.CatCB.AutoRoundedCorners = True
        Me.CatCB.BackColor = System.Drawing.Color.Transparent
        Me.CatCB.BorderRadius = 17
        Me.Guna2Transition1.SetDecoration(Me.CatCB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CatCB.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.CatCB.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.CatCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CatCB.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CatCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CatCB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CatCB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CatCB.ItemHeight = 30
        Me.CatCB.Location = New System.Drawing.Point(381, 19)
        Me.CatCB.Name = "CatCB"
        Me.CatCB.Size = New System.Drawing.Size(167, 36)
        Me.CatCB.TabIndex = 29
        Me.CatCB.Visible = False
        '
        'CatNameTB
        '
        Me.CatNameTB.Animated = True
        Me.CatNameTB.AutoCompleteCustomSource.AddRange(New String() {"Admin"})
        Me.CatNameTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CatNameTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CatNameTB.AutoRoundedCorners = True
        Me.CatNameTB.BackColor = System.Drawing.Color.Transparent
        Me.CatNameTB.BorderColor = System.Drawing.Color.Gray
        Me.CatNameTB.BorderRadius = 17
        Me.CatNameTB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.CatNameTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.CatNameTB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CatNameTB.DefaultText = ""
        Me.CatNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CatNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CatNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CatNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CatNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CatNameTB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CatNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CatNameTB.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.CatNameTB.Location = New System.Drawing.Point(32, 19)
        Me.CatNameTB.Name = "CatNameTB"
        Me.CatNameTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CatNameTB.PlaceholderText = "Name"
        Me.CatNameTB.SelectedText = ""
        Me.CatNameTB.Size = New System.Drawing.Size(200, 36)
        Me.CatNameTB.TabIndex = 16
        Me.CatNameTB.Visible = False
        '
        'CatGridView
        '
        Me.CatGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.CatGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CatGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.CatGridView.ColumnHeadersHeight = 4
        Me.CatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CatGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.CatGridView, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CatGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.CatGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.CatGridView.Location = New System.Drawing.Point(270, 331)
        Me.CatGridView.Name = "CatGridView"
        Me.CatGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CatGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.CatGridView.RowHeadersVisible = False
        Me.CatGridView.Size = New System.Drawing.Size(562, 161)
        Me.CatGridView.TabIndex = 27
        Me.CatGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.SunFlower
        Me.CatGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.CatGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CatGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.CatGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.CatGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CatGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.CatGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CatGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CatGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CatGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CatGridView.ThemeStyle.HeaderStyle.Height = 4
        Me.CatGridView.ThemeStyle.ReadOnly = False
        Me.CatGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.CatGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CatGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.CatGridView.ThemeStyle.RowsStyle.Height = 22
        Me.CatGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.CatGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.BorderColor = System.Drawing.Color.Red
        Me.Guna2GradientPanel3.BorderRadius = 20
        Me.Guna2GradientPanel3.Controls.Add(Me.CatAddBTN)
        Me.Guna2GradientPanel3.Controls.Add(Me.DelBtn)
        Me.Guna2GradientPanel3.CustomBorderColor = System.Drawing.Color.IndianRed
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel3.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(419, 226)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(229, 50)
        Me.Guna2GradientPanel3.TabIndex = 28
        '
        'CatAddBTN
        '
        Me.CatAddBTN.Animated = True
        Me.CatAddBTN.AutoRoundedCorners = True
        Me.CatAddBTN.BackColor = System.Drawing.Color.Transparent
        Me.CatAddBTN.BorderRadius = 20
        Me.CatAddBTN.BorderThickness = -1
        Me.CatAddBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.CatAddBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CatAddBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CatAddBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CatAddBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CatAddBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CatAddBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CatAddBTN.FillColor = System.Drawing.Color.Black
        Me.CatAddBTN.FillColor2 = System.Drawing.Color.Black
        Me.CatAddBTN.FocusedColor = System.Drawing.Color.Black
        Me.CatAddBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CatAddBTN.ForeColor = System.Drawing.Color.White
        Me.CatAddBTN.Location = New System.Drawing.Point(24, 3)
        Me.CatAddBTN.Name = "CatAddBTN"
        Me.CatAddBTN.Size = New System.Drawing.Size(81, 43)
        Me.CatAddBTN.TabIndex = 18
        Me.CatAddBTN.Text = "ADD"
        Me.CatAddBTN.UseTransparentBackground = True
        '
        'DelBtn
        '
        Me.DelBtn.Animated = True
        Me.DelBtn.AutoRoundedCorners = True
        Me.DelBtn.BackColor = System.Drawing.Color.Transparent
        Me.DelBtn.BorderRadius = 20
        Me.DelBtn.BorderThickness = -1
        Me.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.DelBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DelBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DelBtn.FillColor = System.Drawing.Color.Black
        Me.DelBtn.FillColor2 = System.Drawing.Color.Black
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DelBtn.ForeColor = System.Drawing.Color.White
        Me.DelBtn.Location = New System.Drawing.Point(111, 3)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(101, 43)
        Me.DelBtn.TabIndex = 16
        Me.DelBtn.Text = "DELETE"
        Me.DelBtn.UseTransparentBackground = True
        '
        'ExitBTN
        '
        Me.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.ExitBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ExitBTN.Image = Global.Pizza_Shop_System.My.Resources.Resource.Close_BTN1
        Me.ExitBTN.ImageRotate = 0!
        Me.ExitBTN.Location = New System.Drawing.Point(839, 0)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ExitBTN.Size = New System.Drawing.Size(29, 29)
        Me.ExitBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitBTN.TabIndex = 30
        Me.ExitBTN.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(22, 31)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(174, 31)
        Me.Guna2HtmlLabel2.TabIndex = 12
        Me.Guna2HtmlLabel2.Text = "ADMIN PANEL"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(20, 78)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(167, 26)
        Me.Guna2HtmlLabel3.TabIndex = 13
        Me.Guna2HtmlLabel3.Text = "Manage Catogories"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.DashGOBTN)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GradientPanel1.Controls.Add(Me.ItemMngGOBTN)
        Me.Guna2GradientPanel1.Controls.Add(Me.CatMngGOBTN)
        Me.Guna2GradientPanel1.Controls.Add(Me.BackBTN)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Gold
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.DarkGoldenrod
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(247, 517)
        Me.Guna2GradientPanel1.TabIndex = 31
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
        Me.DashGOBTN.Location = New System.Drawing.Point(34, 168)
        Me.DashGOBTN.Name = "DashGOBTN"
        Me.DashGOBTN.Size = New System.Drawing.Size(189, 43)
        Me.DashGOBTN.TabIndex = 14
        Me.DashGOBTN.Text = "DASHBOARD"
        Me.DashGOBTN.UseTransparentBackground = True
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(26, 67)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(185, 22)
        Me.Guna2HtmlLabel1.TabIndex = 13
        Me.Guna2HtmlLabel1.Text = "Add Or Delete " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Catogories"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(25, 32)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(131, 31)
        Me.Guna2HtmlLabel4.TabIndex = 12
        Me.Guna2HtmlLabel4.Text = "Categories"
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
        Me.ItemMngGOBTN.Location = New System.Drawing.Point(34, 301)
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
        Me.CatMngGOBTN.Location = New System.Drawing.Point(34, 233)
        Me.CatMngGOBTN.Name = "CatMngGOBTN"
        Me.CatMngGOBTN.Size = New System.Drawing.Size(189, 43)
        Me.CatMngGOBTN.TabIndex = 10
        Me.CatMngGOBTN.Text = "CATOGORIES"
        Me.CatMngGOBTN.UseTransparentBackground = True
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
        'Guna2GradientPanel5
        '
        Me.Guna2GradientPanel5.AutoRoundedCorners = True
        Me.Guna2GradientPanel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel5.BorderRadius = 10
        Me.Guna2GradientPanel5.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Guna2GradientPanel5.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel5.FillColor = System.Drawing.Color.Orange
        Me.Guna2GradientPanel5.FillColor2 = System.Drawing.Color.Yellow
        Me.Guna2GradientPanel5.Location = New System.Drawing.Point(270, 303)
        Me.Guna2GradientPanel5.Name = "Guna2GradientPanel5"
        Me.Guna2GradientPanel5.Size = New System.Drawing.Size(562, 22)
        Me.Guna2GradientPanel5.TabIndex = 55
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel11.IsSelectionEnabled = False
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(440, -2)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(35, 22)
        Me.Guna2HtmlLabel11.TabIndex = 51
        Me.Guna2HtmlLabel11.Text = "Item"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel6.IsSelectionEnabled = False
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(67, -2)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(88, 22)
        Me.Guna2HtmlLabel6.TabIndex = 49
        Me.Guna2HtmlLabel6.Text = "Catogory ID"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Catogory_Mng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 499)
        Me.Controls.Add(Me.Guna2GradientPanel5)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.ExitBTN)
        Me.Controls.Add(Me.Guna2GradientPanel3)
        Me.Controls.Add(Me.CatGridView)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Catogory_Mng"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catogory_Mng"
        Me.Guna2GradientPanel2.ResumeLayout(False)
        CType(Me.CatGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        CType(Me.ExitBTN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2GradientPanel5.ResumeLayout(False)
        Me.Guna2GradientPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents CatTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents CatNameTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CatGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents CatAddBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DelBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents CatCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ExitBTN As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents DashGOBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ItemMngGOBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents CatMngGOBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BackBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel5 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
