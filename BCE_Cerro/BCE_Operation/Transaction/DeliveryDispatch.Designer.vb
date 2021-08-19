<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeliveryDispatch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeliveryDispatch))
        Me.mtc_Dispatch = New MetroFramework.Controls.MetroTabControl()
        Me.tp_Shipment = New MetroFramework.Controls.MetroTabPage()
        Me.dgv_DelDis = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_ShipNext = New MetroFramework.Controls.MetroButton()
        Me.cbo_Carrier = New MetroFramework.Controls.MetroComboBox()
        Me.dtp_Shipdate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.tp_Personnel = New MetroFramework.Controls.MetroTabPage()
        Me.clb_Driver = New System.Windows.Forms.CheckedListBox()
        Me.btn_PerNext = New MetroFramework.Controls.MetroButton()
        Me.btn_PerBack = New MetroFramework.Controls.MetroButton()
        Me.txt_Driver = New MetroFramework.Controls.MetroTextBox()
        Me.tp_Vehicle = New MetroFramework.Controls.MetroTabPage()
        Me.btn_VehSubmit = New MetroFramework.Controls.MetroButton()
        Me.btn_VehBack = New MetroFramework.Controls.MetroButton()
        Me.mt_Motor = New MetroFramework.Controls.MetroTile()
        Me.mt_ClosedVan = New MetroFramework.Controls.MetroTile()
        Me.lbl_PlateNo = New MetroFramework.Controls.MetroLabel()
        Me.mt_Van = New MetroFramework.Controls.MetroTile()
        Me.lbl_Length = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Width = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Height = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mtc_Dispatch.SuspendLayout()
        Me.tp_Shipment.SuspendLayout()
        CType(Me.dgv_DelDis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_Personnel.SuspendLayout()
        Me.tp_Vehicle.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtc_Dispatch
        '
        Me.mtc_Dispatch.Controls.Add(Me.tp_Shipment)
        Me.mtc_Dispatch.Controls.Add(Me.tp_Personnel)
        Me.mtc_Dispatch.Controls.Add(Me.tp_Vehicle)
        Me.mtc_Dispatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mtc_Dispatch.Location = New System.Drawing.Point(20, 60)
        Me.mtc_Dispatch.Name = "mtc_Dispatch"
        Me.mtc_Dispatch.SelectedIndex = 0
        Me.mtc_Dispatch.Size = New System.Drawing.Size(1029, 516)
        Me.mtc_Dispatch.Style = MetroFramework.MetroColorStyle.Teal
        Me.mtc_Dispatch.TabIndex = 67
        Me.mtc_Dispatch.UseSelectable = True
        '
        'tp_Shipment
        '
        Me.tp_Shipment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tp_Shipment.Controls.Add(Me.dgv_DelDis)
        Me.tp_Shipment.Controls.Add(Me.btn_ShipNext)
        Me.tp_Shipment.Controls.Add(Me.cbo_Carrier)
        Me.tp_Shipment.Controls.Add(Me.dtp_Shipdate)
        Me.tp_Shipment.Controls.Add(Me.MetroLabel1)
        Me.tp_Shipment.Controls.Add(Me.MetroLabel7)
        Me.tp_Shipment.HorizontalScrollbarBarColor = True
        Me.tp_Shipment.HorizontalScrollbarHighlightOnWheel = False
        Me.tp_Shipment.HorizontalScrollbarSize = 10
        Me.tp_Shipment.Location = New System.Drawing.Point(4, 38)
        Me.tp_Shipment.Name = "tp_Shipment"
        Me.tp_Shipment.Size = New System.Drawing.Size(1021, 474)
        Me.tp_Shipment.TabIndex = 2
        Me.tp_Shipment.Text = "Shipment"
        Me.tp_Shipment.VerticalScrollbarBarColor = True
        Me.tp_Shipment.VerticalScrollbarHighlightOnWheel = False
        Me.tp_Shipment.VerticalScrollbarSize = 10
        '
        'dgv_DelDis
        '
        Me.dgv_DelDis.AllowUserToAddRows = False
        Me.dgv_DelDis.AllowUserToDeleteRows = False
        Me.dgv_DelDis.AllowUserToResizeColumns = False
        Me.dgv_DelDis.AllowUserToResizeRows = False
        Me.dgv_DelDis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_DelDis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_DelDis.BackgroundColor = System.Drawing.Color.White
        Me.dgv_DelDis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_DelDis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_DelDis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_DelDis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_DelDis.ColumnHeadersHeight = 33
        Me.dgv_DelDis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_DelDis.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_DelDis.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_DelDis.EnableHeadersVisualStyles = False
        Me.dgv_DelDis.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_DelDis.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_DelDis.Location = New System.Drawing.Point(0, 71)
        Me.dgv_DelDis.Name = "dgv_DelDis"
        Me.dgv_DelDis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_DelDis.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_DelDis.RowHeadersWidth = 62
        Me.dgv_DelDis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_DelDis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_DelDis.Size = New System.Drawing.Size(1019, 370)
        Me.dgv_DelDis.TabIndex = 97
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 8
        '
        'btn_ShipNext
        '
        Me.btn_ShipNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ShipNext.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_ShipNext.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_ShipNext.Location = New System.Drawing.Point(0, 441)
        Me.btn_ShipNext.Name = "btn_ShipNext"
        Me.btn_ShipNext.Size = New System.Drawing.Size(1019, 31)
        Me.btn_ShipNext.TabIndex = 39
        Me.btn_ShipNext.Text = "Next"
        Me.btn_ShipNext.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_ShipNext.UseSelectable = True
        '
        'cbo_Carrier
        '
        Me.cbo_Carrier.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_Carrier.FormattingEnabled = True
        Me.cbo_Carrier.ItemHeight = 19
        Me.cbo_Carrier.Location = New System.Drawing.Point(186, 32)
        Me.cbo_Carrier.Name = "cbo_Carrier"
        Me.cbo_Carrier.Size = New System.Drawing.Size(168, 25)
        Me.cbo_Carrier.TabIndex = 95
        Me.cbo_Carrier.UseSelectable = True
        '
        'dtp_Shipdate
        '
        Me.dtp_Shipdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Shipdate.Location = New System.Drawing.Point(13, 32)
        Me.dtp_Shipdate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtp_Shipdate.Name = "dtp_Shipdate"
        Me.dtp_Shipdate.Size = New System.Drawing.Size(167, 29)
        Me.dtp_Shipdate.TabIndex = 93
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(186, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel1.TabIndex = 94
        Me.MetroLabel1.Text = "Carrier:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(13, 10)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel7.TabIndex = 96
        Me.MetroLabel7.Text = "Ship Date:"
        '
        'tp_Personnel
        '
        Me.tp_Personnel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tp_Personnel.Controls.Add(Me.clb_Driver)
        Me.tp_Personnel.Controls.Add(Me.btn_PerNext)
        Me.tp_Personnel.Controls.Add(Me.btn_PerBack)
        Me.tp_Personnel.Controls.Add(Me.txt_Driver)
        Me.tp_Personnel.HorizontalScrollbarBarColor = True
        Me.tp_Personnel.HorizontalScrollbarHighlightOnWheel = False
        Me.tp_Personnel.HorizontalScrollbarSize = 10
        Me.tp_Personnel.Location = New System.Drawing.Point(4, 38)
        Me.tp_Personnel.Name = "tp_Personnel"
        Me.tp_Personnel.Size = New System.Drawing.Size(1021, 474)
        Me.tp_Personnel.TabIndex = 3
        Me.tp_Personnel.Text = "Personnel"
        Me.tp_Personnel.VerticalScrollbarBarColor = True
        Me.tp_Personnel.VerticalScrollbarHighlightOnWheel = False
        Me.tp_Personnel.VerticalScrollbarSize = 10
        '
        'clb_Driver
        '
        Me.clb_Driver.CheckOnClick = True
        Me.clb_Driver.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.clb_Driver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Driver.HorizontalScrollbar = True
        Me.clb_Driver.Location = New System.Drawing.Point(0, 196)
        Me.clb_Driver.Name = "clb_Driver"
        Me.clb_Driver.Size = New System.Drawing.Size(1019, 214)
        Me.clb_Driver.TabIndex = 0
        '
        'btn_PerNext
        '
        Me.btn_PerNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PerNext.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_PerNext.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_PerNext.Location = New System.Drawing.Point(0, 410)
        Me.btn_PerNext.Name = "btn_PerNext"
        Me.btn_PerNext.Size = New System.Drawing.Size(1019, 31)
        Me.btn_PerNext.TabIndex = 39
        Me.btn_PerNext.Text = "Next"
        Me.btn_PerNext.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_PerNext.UseSelectable = True
        '
        'btn_PerBack
        '
        Me.btn_PerBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PerBack.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_PerBack.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_PerBack.Location = New System.Drawing.Point(0, 441)
        Me.btn_PerBack.Name = "btn_PerBack"
        Me.btn_PerBack.Size = New System.Drawing.Size(1019, 31)
        Me.btn_PerBack.TabIndex = 41
        Me.btn_PerBack.Text = "Back"
        Me.btn_PerBack.UseSelectable = True
        '
        'txt_Driver
        '
        Me.txt_Driver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_Driver.CustomButton.Image = Nothing
        Me.txt_Driver.CustomButton.Location = New System.Drawing.Point(644, 1)
        Me.txt_Driver.CustomButton.Name = ""
        Me.txt_Driver.CustomButton.Size = New System.Drawing.Size(14, 14)
        Me.txt_Driver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Driver.CustomButton.TabIndex = 1
        Me.txt_Driver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Driver.CustomButton.UseSelectable = True
        Me.txt_Driver.CustomButton.Visible = False
        Me.txt_Driver.Lines = New String(-1) {}
        Me.txt_Driver.Location = New System.Drawing.Point(16, 20)
        Me.txt_Driver.MaxLength = 32767
        Me.txt_Driver.Name = "txt_Driver"
        Me.txt_Driver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Driver.PromptText = "Driver's Name"
        Me.txt_Driver.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Driver.SelectedText = ""
        Me.txt_Driver.SelectionLength = 0
        Me.txt_Driver.SelectionStart = 0
        Me.txt_Driver.ShortcutsEnabled = True
        Me.txt_Driver.Size = New System.Drawing.Size(988, 23)
        Me.txt_Driver.TabIndex = 69
        Me.txt_Driver.UseSelectable = True
        Me.txt_Driver.WaterMark = "Driver's Name"
        Me.txt_Driver.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Driver.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tp_Vehicle
        '
        Me.tp_Vehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tp_Vehicle.Controls.Add(Me.btn_VehSubmit)
        Me.tp_Vehicle.Controls.Add(Me.btn_VehBack)
        Me.tp_Vehicle.Controls.Add(Me.mt_Motor)
        Me.tp_Vehicle.Controls.Add(Me.mt_ClosedVan)
        Me.tp_Vehicle.Controls.Add(Me.lbl_PlateNo)
        Me.tp_Vehicle.Controls.Add(Me.mt_Van)
        Me.tp_Vehicle.Controls.Add(Me.lbl_Length)
        Me.tp_Vehicle.Controls.Add(Me.MetroLabel2)
        Me.tp_Vehicle.Controls.Add(Me.MetroLabel5)
        Me.tp_Vehicle.Controls.Add(Me.MetroLabel3)
        Me.tp_Vehicle.Controls.Add(Me.lbl_Width)
        Me.tp_Vehicle.Controls.Add(Me.lbl_Height)
        Me.tp_Vehicle.Controls.Add(Me.MetroLabel4)
        Me.tp_Vehicle.HorizontalScrollbarBarColor = True
        Me.tp_Vehicle.HorizontalScrollbarHighlightOnWheel = False
        Me.tp_Vehicle.HorizontalScrollbarSize = 10
        Me.tp_Vehicle.Location = New System.Drawing.Point(4, 38)
        Me.tp_Vehicle.Name = "tp_Vehicle"
        Me.tp_Vehicle.Size = New System.Drawing.Size(1021, 474)
        Me.tp_Vehicle.TabIndex = 4
        Me.tp_Vehicle.Text = "Vehicle"
        Me.tp_Vehicle.VerticalScrollbarBarColor = True
        Me.tp_Vehicle.VerticalScrollbarHighlightOnWheel = False
        Me.tp_Vehicle.VerticalScrollbarSize = 10
        '
        'btn_VehSubmit
        '
        Me.btn_VehSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_VehSubmit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_VehSubmit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_VehSubmit.Location = New System.Drawing.Point(0, 410)
        Me.btn_VehSubmit.Name = "btn_VehSubmit"
        Me.btn_VehSubmit.Size = New System.Drawing.Size(1019, 31)
        Me.btn_VehSubmit.TabIndex = 39
        Me.btn_VehSubmit.Text = "Submit"
        Me.btn_VehSubmit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_VehSubmit.UseSelectable = True
        '
        'btn_VehBack
        '
        Me.btn_VehBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_VehBack.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_VehBack.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_VehBack.Location = New System.Drawing.Point(0, 441)
        Me.btn_VehBack.Name = "btn_VehBack"
        Me.btn_VehBack.Size = New System.Drawing.Size(1019, 31)
        Me.btn_VehBack.TabIndex = 40
        Me.btn_VehBack.Text = "Back"
        Me.btn_VehBack.UseSelectable = True
        '
        'mt_Motor
        '
        Me.mt_Motor.ActiveControl = Nothing
        Me.mt_Motor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_Motor.Location = New System.Drawing.Point(15, 13)
        Me.mt_Motor.Name = "mt_Motor"
        Me.mt_Motor.Size = New System.Drawing.Size(113, 102)
        Me.mt_Motor.TabIndex = 78
        Me.mt_Motor.Text = "Motorcycle"
        Me.mt_Motor.UseSelectable = True
        '
        'mt_ClosedVan
        '
        Me.mt_ClosedVan.ActiveControl = Nothing
        Me.mt_ClosedVan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_ClosedVan.Location = New System.Drawing.Point(253, 13)
        Me.mt_ClosedVan.Name = "mt_ClosedVan"
        Me.mt_ClosedVan.Size = New System.Drawing.Size(113, 102)
        Me.mt_ClosedVan.TabIndex = 81
        Me.mt_ClosedVan.TileImage = CType(resources.GetObject("mt_ClosedVan.TileImage"), System.Drawing.Image)
        Me.mt_ClosedVan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mt_ClosedVan.UseSelectable = True
        Me.mt_ClosedVan.UseTileImage = True
        '
        'lbl_PlateNo
        '
        Me.lbl_PlateNo.AutoSize = True
        Me.lbl_PlateNo.Location = New System.Drawing.Point(87, 144)
        Me.lbl_PlateNo.Name = "lbl_PlateNo"
        Me.lbl_PlateNo.Size = New System.Drawing.Size(0, 0)
        Me.lbl_PlateNo.TabIndex = 74
        '
        'mt_Van
        '
        Me.mt_Van.ActiveControl = Nothing
        Me.mt_Van.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_Van.Location = New System.Drawing.Point(134, 13)
        Me.mt_Van.Name = "mt_Van"
        Me.mt_Van.Size = New System.Drawing.Size(113, 102)
        Me.mt_Van.TabIndex = 80
        Me.mt_Van.TileImage = CType(resources.GetObject("mt_Van.TileImage"), System.Drawing.Image)
        Me.mt_Van.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mt_Van.UseSelectable = True
        Me.mt_Van.UseTileImage = True
        '
        'lbl_Length
        '
        Me.lbl_Length.AutoSize = True
        Me.lbl_Length.Location = New System.Drawing.Point(87, 173)
        Me.lbl_Length.Name = "lbl_Length"
        Me.lbl_Length.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Length.TabIndex = 75
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(15, 144)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 70
        Me.MetroLabel2.Text = "Plate No.:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(15, 230)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel5.TabIndex = 73
        Me.MetroLabel5.Text = "Height:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(15, 173)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel3.TabIndex = 71
        Me.MetroLabel3.Text = "Length:"
        '
        'lbl_Width
        '
        Me.lbl_Width.AutoSize = True
        Me.lbl_Width.Location = New System.Drawing.Point(87, 202)
        Me.lbl_Width.Name = "lbl_Width"
        Me.lbl_Width.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Width.TabIndex = 76
        '
        'lbl_Height
        '
        Me.lbl_Height.AutoSize = True
        Me.lbl_Height.Location = New System.Drawing.Point(87, 230)
        Me.lbl_Height.Name = "lbl_Height"
        Me.lbl_Height.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Height.TabIndex = 77
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(15, 202)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel4.TabIndex = 72
        Me.MetroLabel4.Text = "Width:"
        '
        'DeliveryDispatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.mtc_Dispatch)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeliveryDispatch"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Delivery Dispatch"
        Me.mtc_Dispatch.ResumeLayout(False)
        Me.tp_Shipment.ResumeLayout(False)
        Me.tp_Shipment.PerformLayout()
        CType(Me.dgv_DelDis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_Personnel.ResumeLayout(False)
        Me.tp_Vehicle.ResumeLayout(False)
        Me.tp_Vehicle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mtc_Dispatch As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tp_Shipment As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txt_Driver As MetroFramework.Controls.MetroTextBox
    Friend WithEvents clb_Driver As CheckedListBox
    Friend WithEvents btn_PerNext As MetroFramework.Controls.MetroButton
    Friend WithEvents tp_Personnel As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mt_ClosedVan As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_Van As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_Motor As MetroFramework.Controls.MetroTile
    Friend WithEvents lbl_Height As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Width As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Length As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_PlateNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_VehSubmit As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_VehBack As MetroFramework.Controls.MetroButton
    Friend WithEvents tp_Vehicle As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btn_PerBack As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_ShipNext As MetroFramework.Controls.MetroButton
    Friend WithEvents cbo_Carrier As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtp_Shipdate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_DelDis As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
End Class
