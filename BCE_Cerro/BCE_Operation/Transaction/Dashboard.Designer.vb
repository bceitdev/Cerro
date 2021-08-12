<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.lbl_datetime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.dgv_delivery = New MetroFramework.Controls.MetroGrid()
        Me.mt_DelOpen = New MetroFramework.Controls.MetroTile()
        Me.mt_DelIntransit = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.mt_PUOpen = New MetroFramework.Controls.MetroTile()
        Me.mt_PUIntransit = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dgv_pickup = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel3.SuspendLayout()
        CType(Me.dgv_delivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.dgv_pickup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.Teal
        Me.MetroPanel1.Controls.Add(Me.lbl_datetime)
        Me.MetroPanel1.Controls.Add(Me.PictureBox1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1024, 100)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'lbl_datetime
        '
        Me.lbl_datetime.AutoSize = True
        Me.lbl_datetime.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datetime.ForeColor = System.Drawing.Color.White
        Me.lbl_datetime.Location = New System.Drawing.Point(794, 41)
        Me.lbl_datetime.Name = "lbl_datetime"
        Me.lbl_datetime.Size = New System.Drawing.Size(90, 18)
        Me.lbl_datetime.TabIndex = 4
        Me.lbl_datetime.Text = "lbl_datetime"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.BCE_Cerro.My.Resources.Resources.newlogo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 100)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BackColor = System.Drawing.Color.Gainsboro
        Me.MetroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel3.Controls.Add(Me.dgv_delivery)
        Me.MetroPanel3.Controls.Add(Me.mt_DelOpen)
        Me.MetroPanel3.Controls.Add(Me.mt_DelIntransit)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(429, 160)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(409, 539)
        Me.MetroPanel3.TabIndex = 2
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'dgv_delivery
        '
        Me.dgv_delivery.AllowUserToResizeRows = False
        Me.dgv_delivery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_delivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_delivery.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_delivery.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_delivery.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_delivery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_delivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_delivery.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_delivery.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_delivery.Enabled = False
        Me.dgv_delivery.EnableHeadersVisualStyles = False
        Me.dgv_delivery.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_delivery.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_delivery.Location = New System.Drawing.Point(0, 157)
        Me.dgv_delivery.Name = "dgv_delivery"
        Me.dgv_delivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_delivery.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_delivery.RowHeadersVisible = False
        Me.dgv_delivery.RowHeadersWidth = 62
        Me.dgv_delivery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_delivery.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_delivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_delivery.Size = New System.Drawing.Size(407, 381)
        Me.dgv_delivery.TabIndex = 11
        '
        'mt_DelOpen
        '
        Me.mt_DelOpen.ActiveControl = Nothing
        Me.mt_DelOpen.BackColor = System.Drawing.Color.Firebrick
        Me.mt_DelOpen.Enabled = False
        Me.mt_DelOpen.ForeColor = System.Drawing.Color.White
        Me.mt_DelOpen.Location = New System.Drawing.Point(114, 50)
        Me.mt_DelOpen.Name = "mt_DelOpen"
        Me.mt_DelOpen.Size = New System.Drawing.Size(141, 101)
        Me.mt_DelOpen.Style = MetroFramework.MetroColorStyle.White
        Me.mt_DelOpen.TabIndex = 9
        Me.mt_DelOpen.Text = "OPEN"
        Me.mt_DelOpen.UseCustomBackColor = True
        Me.mt_DelOpen.UseCustomForeColor = True
        Me.mt_DelOpen.UseSelectable = True
        Me.mt_DelOpen.UseStyleColors = True
        Me.mt_DelOpen.UseTileImage = True
        '
        'mt_DelIntransit
        '
        Me.mt_DelIntransit.ActiveControl = Nothing
        Me.mt_DelIntransit.BackColor = System.Drawing.Color.Gold
        Me.mt_DelIntransit.Enabled = False
        Me.mt_DelIntransit.ForeColor = System.Drawing.Color.White
        Me.mt_DelIntransit.Location = New System.Drawing.Point(261, 50)
        Me.mt_DelIntransit.Name = "mt_DelIntransit"
        Me.mt_DelIntransit.Size = New System.Drawing.Size(141, 101)
        Me.mt_DelIntransit.Style = MetroFramework.MetroColorStyle.White
        Me.mt_DelIntransit.TabIndex = 10
        Me.mt_DelIntransit.Text = "IN TRANSIT"
        Me.mt_DelIntransit.UseCustomBackColor = True
        Me.mt_DelIntransit.UseCustomForeColor = True
        Me.mt_DelIntransit.UseSelectable = True
        Me.mt_DelIntransit.UseStyleColors = True
        Me.mt_DelIntransit.UseTileImage = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 13)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(83, 25)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Delivery"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.Gainsboro
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.mt_PUOpen)
        Me.MetroPanel2.Controls.Add(Me.mt_PUIntransit)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel2.Controls.Add(Me.dgv_pickup)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(20, 160)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(409, 539)
        Me.MetroPanel2.TabIndex = 1
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'mt_PUOpen
        '
        Me.mt_PUOpen.ActiveControl = Nothing
        Me.mt_PUOpen.BackColor = System.Drawing.Color.Firebrick
        Me.mt_PUOpen.Enabled = False
        Me.mt_PUOpen.ForeColor = System.Drawing.Color.White
        Me.mt_PUOpen.Location = New System.Drawing.Point(114, 50)
        Me.mt_PUOpen.Name = "mt_PUOpen"
        Me.mt_PUOpen.Size = New System.Drawing.Size(141, 101)
        Me.mt_PUOpen.Style = MetroFramework.MetroColorStyle.White
        Me.mt_PUOpen.TabIndex = 7
        Me.mt_PUOpen.Text = "OPEN"
        Me.mt_PUOpen.UseCustomBackColor = True
        Me.mt_PUOpen.UseCustomForeColor = True
        Me.mt_PUOpen.UseSelectable = True
        Me.mt_PUOpen.UseStyleColors = True
        Me.mt_PUOpen.UseTileImage = True
        '
        'mt_PUIntransit
        '
        Me.mt_PUIntransit.ActiveControl = Nothing
        Me.mt_PUIntransit.BackColor = System.Drawing.Color.Gold
        Me.mt_PUIntransit.Enabled = False
        Me.mt_PUIntransit.ForeColor = System.Drawing.Color.White
        Me.mt_PUIntransit.Location = New System.Drawing.Point(261, 50)
        Me.mt_PUIntransit.Name = "mt_PUIntransit"
        Me.mt_PUIntransit.Size = New System.Drawing.Size(141, 101)
        Me.mt_PUIntransit.Style = MetroFramework.MetroColorStyle.White
        Me.mt_PUIntransit.TabIndex = 8
        Me.mt_PUIntransit.Text = "IN TRANSIT"
        Me.mt_PUIntransit.UseCustomBackColor = True
        Me.mt_PUIntransit.UseCustomForeColor = True
        Me.mt_PUIntransit.UseSelectable = True
        Me.mt_PUIntransit.UseStyleColors = True
        Me.mt_PUIntransit.UseTileImage = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(69, 25)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Pickup"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'dgv_pickup
        '
        Me.dgv_pickup.AllowUserToResizeRows = False
        Me.dgv_pickup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_pickup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_pickup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_pickup.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_pickup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_pickup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_pickup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_pickup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_pickup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_pickup.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_pickup.Enabled = False
        Me.dgv_pickup.EnableHeadersVisualStyles = False
        Me.dgv_pickup.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_pickup.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_pickup.Location = New System.Drawing.Point(0, 157)
        Me.dgv_pickup.Name = "dgv_pickup"
        Me.dgv_pickup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_pickup.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_pickup.RowHeadersVisible = False
        Me.dgv_pickup.RowHeadersWidth = 62
        Me.dgv_pickup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_pickup.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_pickup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_pickup.Size = New System.Drawing.Size(407, 379)
        Me.dgv_pickup.TabIndex = 2
        '
        'MetroPanel4
        '
        Me.MetroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel4.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel4.Controls.Add(Me.PictureBox4)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel4.Controls.Add(Me.PictureBox3)
        Me.MetroPanel4.Controls.Add(Me.PictureBox2)
        Me.MetroPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(838, 160)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(206, 539)
        Me.MetroPanel4.TabIndex = 3
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(5, 479)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(132, 15)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "www.bosscargo.express"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.BCE_Cerro.My.Resources.Resources.Facebook_logo
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(1, 453)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 27)
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(5, 305)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(22, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "P1"
        Me.MetroLabel3.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Location = New System.Drawing.Point(0, 284)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(204, 165)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.BCE_Cerro.My.Resources.Resources._1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 284)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1200
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 719)
        Me.Controls.Add(Me.MetroPanel4)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        CType(Me.dgv_delivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.dgv_pickup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents dgv_pickup As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mt_PUOpen As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_PUIntransit As MetroFramework.Controls.MetroTile
    Friend WithEvents Timer1 As Timer
    Friend WithEvents mt_DelOpen As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_DelIntransit As MetroFramework.Controls.MetroTile
    Friend WithEvents dgv_delivery As MetroFramework.Controls.MetroGrid
    Friend WithEvents lbl_datetime As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
End Class
