<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PickUpSched
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbo_Pay = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.cbo_Service = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txt_Commodity = New MetroFramework.Controls.MetroTextBox()
        Me.cbo_Type = New MetroFramework.Controls.MetroComboBox()
        Me.ml_attached = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mtp_shipper = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel10 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.pnl_ship_selectadd = New MetroFramework.Controls.MetroPanel()
        Me.dgv_Origin = New MetroFramework.Controls.MetroGrid()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.lbl_ship_newadd = New MetroFramework.Controls.MetroLink()
        Me.pnl_ship_newadd = New MetroFramework.Controls.MetroPanel()
        Me.btn_shipadd_cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_shipadd_submit = New MetroFramework.Controls.MetroButton()
        Me.txt_ship_zip = New MetroFramework.Controls.MetroTextBox()
        Me.txt_ship_email = New MetroFramework.Controls.MetroTextBox()
        Me.txt_ship_street = New MetroFramework.Controls.MetroTextBox()
        Me.txt_ship_phone = New MetroFramework.Controls.MetroTextBox()
        Me.txt_ship_contact = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel13 = New MetroFramework.Controls.MetroPanel()
        Me.btn_ShipperNext = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.txt_Ship_Company = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel6 = New MetroFramework.Controls.MetroPanel()
        Me.dtp_pickuptime = New System.Windows.Forms.DateTimePicker()
        Me.dtp_pickupdate = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.lbl_UomDesc = New MetroFramework.Controls.MetroLabel()
        Me.cbo_Uom = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_SpeIns = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txt_TotalWeight = New MetroFramework.Controls.MetroTextBox()
        Me.ml_clear = New MetroFramework.Controls.MetroLink()
        Me.pb_Cargo = New System.Windows.Forms.PictureBox()
        Me.txt_DeclaredValue = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.cbo_Loading = New MetroFramework.Controls.MetroComboBox()
        Me.cbo_Freight = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel7 = New MetroFramework.Controls.MetroPanel()
        Me.dgv_Dimension = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroPanel11 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_TotalVol = New MetroFramework.Controls.MetroLabel()
        Me.lbl_TotalQty = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.btn_ShipmentBack = New MetroFramework.Controls.MetroButton()
        Me.mtc_Pickup = New MetroFramework.Controls.MetroTabControl()
        Me.mtp_shipment = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.cbo_Origin = New MetroFramework.Controls.MetroComboBox()
        Me.lbl_Code = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mtp_shipper.SuspendLayout()
        Me.MetroPanel10.SuspendLayout()
        Me.pnl_ship_selectadd.SuspendLayout()
        CType(Me.dgv_Origin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ship_newadd.SuspendLayout()
        Me.MetroPanel13.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel6.SuspendLayout()
        Me.MetroPanel4.SuspendLayout()
        CType(Me.pb_Cargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel3.SuspendLayout()
        Me.MetroPanel7.SuspendLayout()
        CType(Me.dgv_Dimension, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel11.SuspendLayout()
        Me.mtc_Pickup.SuspendLayout()
        Me.mtp_shipment.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_Pay
        '
        Me.cbo_Pay.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_Pay.FormattingEnabled = True
        Me.cbo_Pay.ItemHeight = 19
        Me.cbo_Pay.Location = New System.Drawing.Point(122, 81)
        Me.cbo_Pay.Name = "cbo_Pay"
        Me.cbo_Pay.Size = New System.Drawing.Size(279, 25)
        Me.cbo_Pay.TabIndex = 27
        Me.cbo_Pay.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(84, 87)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel1.TabIndex = 60
        Me.MetroLabel1.Text = "Pay:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(34, 68)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel12.TabIndex = 15
        Me.MetroLabel12.Text = "Commodity:"
        '
        'cbo_Service
        '
        Me.cbo_Service.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_Service.FormattingEnabled = True
        Me.cbo_Service.ItemHeight = 19
        Me.cbo_Service.Location = New System.Drawing.Point(122, 50)
        Me.cbo_Service.Name = "cbo_Service"
        Me.cbo_Service.Size = New System.Drawing.Size(279, 25)
        Me.cbo_Service.TabIndex = 26
        Me.cbo_Service.UseSelectable = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(57, 25)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel17.TabIndex = 58
        Me.MetroLabel17.Text = "Loading:"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(77, 39)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel13.TabIndex = 55
        Me.MetroLabel13.Text = "Type:"
        '
        'txt_Commodity
        '
        '
        '
        '
        Me.txt_Commodity.CustomButton.Image = Nothing
        Me.txt_Commodity.CustomButton.Location = New System.Drawing.Point(257, 1)
        Me.txt_Commodity.CustomButton.Name = ""
        Me.txt_Commodity.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Commodity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Commodity.CustomButton.TabIndex = 1
        Me.txt_Commodity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Commodity.CustomButton.UseSelectable = True
        Me.txt_Commodity.CustomButton.Visible = False
        Me.txt_Commodity.Lines = New String(-1) {}
        Me.txt_Commodity.Location = New System.Drawing.Point(122, 64)
        Me.txt_Commodity.MaxLength = 32767
        Me.txt_Commodity.Name = "txt_Commodity"
        Me.txt_Commodity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Commodity.PromptText = "Item description"
        Me.txt_Commodity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Commodity.SelectedText = ""
        Me.txt_Commodity.SelectionLength = 0
        Me.txt_Commodity.SelectionStart = 0
        Me.txt_Commodity.ShortcutsEnabled = True
        Me.txt_Commodity.Size = New System.Drawing.Size(279, 23)
        Me.txt_Commodity.TabIndex = 30
        Me.txt_Commodity.UseSelectable = True
        Me.txt_Commodity.WaterMark = "Item description"
        Me.txt_Commodity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Commodity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbo_Type
        '
        Me.cbo_Type.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_Type.FormattingEnabled = True
        Me.cbo_Type.ItemHeight = 19
        Me.cbo_Type.Location = New System.Drawing.Point(122, 33)
        Me.cbo_Type.Name = "cbo_Type"
        Me.cbo_Type.Size = New System.Drawing.Size(279, 25)
        Me.cbo_Type.TabIndex = 29
        Me.cbo_Type.UseSelectable = True
        '
        'ml_attached
        '
        Me.ml_attached.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ml_attached.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.ml_attached.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ml_attached.Location = New System.Drawing.Point(407, 15)
        Me.ml_attached.Name = "ml_attached"
        Me.ml_attached.Size = New System.Drawing.Size(49, 13)
        Me.ml_attached.TabIndex = 35
        Me.ml_attached.Text = "Attach"
        Me.ml_attached.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ml_attached.UseCustomForeColor = True
        Me.ml_attached.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(63, 56)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel3.TabIndex = 43
        Me.MetroLabel3.Text = "Service:"
        '
        'mtp_shipper
        '
        Me.mtp_shipper.Controls.Add(Me.MetroPanel10)
        Me.mtp_shipper.Controls.Add(Me.MetroPanel13)
        Me.mtp_shipper.Controls.Add(Me.MetroPanel1)
        Me.mtp_shipper.HorizontalScrollbarBarColor = True
        Me.mtp_shipper.HorizontalScrollbarHighlightOnWheel = False
        Me.mtp_shipper.HorizontalScrollbarSize = 10
        Me.mtp_shipper.Location = New System.Drawing.Point(4, 38)
        Me.mtp_shipper.Name = "mtp_shipper"
        Me.mtp_shipper.Size = New System.Drawing.Size(947, 474)
        Me.mtp_shipper.TabIndex = 0
        Me.mtp_shipper.Text = "Shipper"
        Me.mtp_shipper.VerticalScrollbarBarColor = True
        Me.mtp_shipper.VerticalScrollbarHighlightOnWheel = False
        Me.mtp_shipper.VerticalScrollbarSize = 10
        '
        'MetroPanel10
        '
        Me.MetroPanel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel10.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel10.Controls.Add(Me.pnl_ship_selectadd)
        Me.MetroPanel10.Controls.Add(Me.pnl_ship_newadd)
        Me.MetroPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel10.HorizontalScrollbarBarColor = True
        Me.MetroPanel10.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel10.HorizontalScrollbarSize = 10
        Me.MetroPanel10.Location = New System.Drawing.Point(0, 90)
        Me.MetroPanel10.Name = "MetroPanel10"
        Me.MetroPanel10.Size = New System.Drawing.Size(947, 335)
        Me.MetroPanel10.TabIndex = 7
        Me.MetroPanel10.VerticalScrollbarBarColor = True
        Me.MetroPanel10.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel10.VerticalScrollbarSize = 10
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel4.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel4.TabIndex = 20
        Me.MetroLabel4.Text = "PICKUP ADDRESS"
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'pnl_ship_selectadd
        '
        Me.pnl_ship_selectadd.Controls.Add(Me.dgv_Origin)
        Me.pnl_ship_selectadd.Controls.Add(Me.lbl_ship_newadd)
        Me.pnl_ship_selectadd.HorizontalScrollbarBarColor = True
        Me.pnl_ship_selectadd.HorizontalScrollbarHighlightOnWheel = False
        Me.pnl_ship_selectadd.HorizontalScrollbarSize = 10
        Me.pnl_ship_selectadd.Location = New System.Drawing.Point(91, 34)
        Me.pnl_ship_selectadd.Name = "pnl_ship_selectadd"
        Me.pnl_ship_selectadd.Size = New System.Drawing.Size(730, 283)
        Me.pnl_ship_selectadd.TabIndex = 21
        Me.pnl_ship_selectadd.VerticalScrollbarBarColor = True
        Me.pnl_ship_selectadd.VerticalScrollbarHighlightOnWheel = False
        Me.pnl_ship_selectadd.VerticalScrollbarSize = 10
        '
        'dgv_Origin
        '
        Me.dgv_Origin.AllowUserToAddRows = False
        Me.dgv_Origin.AllowUserToDeleteRows = False
        Me.dgv_Origin.AllowUserToResizeRows = False
        Me.dgv_Origin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_Origin.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Origin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Origin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_Origin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Origin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Origin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Origin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Origin.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Origin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Origin.EnableHeadersVisualStyles = False
        Me.dgv_Origin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_Origin.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Origin.Location = New System.Drawing.Point(0, 32)
        Me.dgv_Origin.Name = "dgv_Origin"
        Me.dgv_Origin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Origin.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Origin.RowHeadersWidth = 35
        Me.dgv_Origin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_Origin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Origin.Size = New System.Drawing.Size(730, 251)
        Me.dgv_Origin.TabIndex = 2
        '
        'sel
        '
        Me.sel.HeaderText = "Select"
        Me.sel.MinimumWidth = 8
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sel.Width = 41
        '
        'Column2
        '
        Me.Column2.HeaderText = "Modify"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Text = "Modify"
        Me.Column2.UseColumnTextForLinkValue = True
        Me.Column2.Width = 47
        '
        'lbl_ship_newadd
        '
        Me.lbl_ship_newadd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ship_newadd.AutoSize = True
        Me.lbl_ship_newadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_ship_newadd.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lbl_ship_newadd.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_ship_newadd.Location = New System.Drawing.Point(622, 5)
        Me.lbl_ship_newadd.Name = "lbl_ship_newadd"
        Me.lbl_ship_newadd.Size = New System.Drawing.Size(105, 23)
        Me.lbl_ship_newadd.TabIndex = 1
        Me.lbl_ship_newadd.Text = "Add New Address"
        Me.lbl_ship_newadd.UseCustomForeColor = True
        Me.lbl_ship_newadd.UseSelectable = True
        '
        'pnl_ship_newadd
        '
        Me.pnl_ship_newadd.Controls.Add(Me.btn_shipadd_cancel)
        Me.pnl_ship_newadd.Controls.Add(Me.btn_shipadd_submit)
        Me.pnl_ship_newadd.Controls.Add(Me.txt_ship_zip)
        Me.pnl_ship_newadd.Controls.Add(Me.txt_ship_email)
        Me.pnl_ship_newadd.Controls.Add(Me.txt_ship_street)
        Me.pnl_ship_newadd.Controls.Add(Me.txt_ship_phone)
        Me.pnl_ship_newadd.Controls.Add(Me.txt_ship_contact)
        Me.pnl_ship_newadd.HorizontalScrollbarBarColor = True
        Me.pnl_ship_newadd.HorizontalScrollbarHighlightOnWheel = False
        Me.pnl_ship_newadd.HorizontalScrollbarSize = 10
        Me.pnl_ship_newadd.Location = New System.Drawing.Point(91, 34)
        Me.pnl_ship_newadd.Name = "pnl_ship_newadd"
        Me.pnl_ship_newadd.Size = New System.Drawing.Size(730, 158)
        Me.pnl_ship_newadd.TabIndex = 21
        Me.pnl_ship_newadd.VerticalScrollbarBarColor = True
        Me.pnl_ship_newadd.VerticalScrollbarHighlightOnWheel = False
        Me.pnl_ship_newadd.VerticalScrollbarSize = 10
        '
        'btn_shipadd_cancel
        '
        Me.btn_shipadd_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shipadd_cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_shipadd_cancel.Location = New System.Drawing.Point(509, 112)
        Me.btn_shipadd_cancel.Name = "btn_shipadd_cancel"
        Me.btn_shipadd_cancel.Size = New System.Drawing.Size(107, 31)
        Me.btn_shipadd_cancel.TabIndex = 10
        Me.btn_shipadd_cancel.Text = "Cancel"
        Me.btn_shipadd_cancel.UseSelectable = True
        '
        'btn_shipadd_submit
        '
        Me.btn_shipadd_submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_shipadd_submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_shipadd_submit.Location = New System.Drawing.Point(622, 112)
        Me.btn_shipadd_submit.Name = "btn_shipadd_submit"
        Me.btn_shipadd_submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_shipadd_submit.TabIndex = 9
        Me.btn_shipadd_submit.Text = "Submit"
        Me.btn_shipadd_submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_shipadd_submit.UseSelectable = True
        '
        'txt_ship_zip
        '
        Me.txt_ship_zip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_ship_zip.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_ship_zip.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_ship_zip.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_ship_zip.CustomButton.Image = Nothing
        Me.txt_ship_zip.CustomButton.Location = New System.Drawing.Point(58, 1)
        Me.txt_ship_zip.CustomButton.Name = ""
        Me.txt_ship_zip.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_ship_zip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_ship_zip.CustomButton.TabIndex = 1
        Me.txt_ship_zip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_ship_zip.CustomButton.UseSelectable = True
        Me.txt_ship_zip.CustomButton.Visible = False
        Me.txt_ship_zip.Lines = New String(-1) {}
        Me.txt_ship_zip.Location = New System.Drawing.Point(650, 13)
        Me.txt_ship_zip.MaxLength = 32767
        Me.txt_ship_zip.Name = "txt_ship_zip"
        Me.txt_ship_zip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ship_zip.PromptText = "ZIP Code"
        Me.txt_ship_zip.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ship_zip.SelectedText = ""
        Me.txt_ship_zip.SelectionLength = 0
        Me.txt_ship_zip.SelectionStart = 0
        Me.txt_ship_zip.ShortcutsEnabled = True
        Me.txt_ship_zip.ShowClearButton = True
        Me.txt_ship_zip.Size = New System.Drawing.Size(80, 23)
        Me.txt_ship_zip.TabIndex = 4
        Me.txt_ship_zip.UseSelectable = True
        Me.txt_ship_zip.WaterMark = "ZIP Code"
        Me.txt_ship_zip.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ship_zip.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_ship_email
        '
        Me.txt_ship_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_ship_email.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_ship_email.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_ship_email.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_ship_email.CustomButton.Image = Nothing
        Me.txt_ship_email.CustomButton.Location = New System.Drawing.Point(220, 1)
        Me.txt_ship_email.CustomButton.Name = ""
        Me.txt_ship_email.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_ship_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_ship_email.CustomButton.TabIndex = 1
        Me.txt_ship_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_ship_email.CustomButton.UseSelectable = True
        Me.txt_ship_email.CustomButton.Visible = False
        Me.txt_ship_email.Lines = New String(-1) {}
        Me.txt_ship_email.Location = New System.Drawing.Point(488, 42)
        Me.txt_ship_email.MaxLength = 32767
        Me.txt_ship_email.Name = "txt_ship_email"
        Me.txt_ship_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ship_email.PromptText = "Email"
        Me.txt_ship_email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ship_email.SelectedText = ""
        Me.txt_ship_email.SelectionLength = 0
        Me.txt_ship_email.SelectionStart = 0
        Me.txt_ship_email.ShortcutsEnabled = True
        Me.txt_ship_email.ShowClearButton = True
        Me.txt_ship_email.Size = New System.Drawing.Size(242, 23)
        Me.txt_ship_email.TabIndex = 8
        Me.txt_ship_email.UseSelectable = True
        Me.txt_ship_email.WaterMark = "Email"
        Me.txt_ship_email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ship_email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_ship_street
        '
        Me.txt_ship_street.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_ship_street.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_ship_street.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_ship_street.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_ship_street.CustomButton.Image = Nothing
        Me.txt_ship_street.CustomButton.Location = New System.Drawing.Point(622, 1)
        Me.txt_ship_street.CustomButton.Name = ""
        Me.txt_ship_street.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_ship_street.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_ship_street.CustomButton.TabIndex = 1
        Me.txt_ship_street.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_ship_street.CustomButton.UseSelectable = True
        Me.txt_ship_street.CustomButton.Visible = False
        Me.txt_ship_street.Lines = New String(-1) {}
        Me.txt_ship_street.Location = New System.Drawing.Point(0, 13)
        Me.txt_ship_street.MaxLength = 32767
        Me.txt_ship_street.Name = "txt_ship_street"
        Me.txt_ship_street.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ship_street.PromptText = "Complete Address"
        Me.txt_ship_street.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ship_street.SelectedText = ""
        Me.txt_ship_street.SelectionLength = 0
        Me.txt_ship_street.SelectionStart = 0
        Me.txt_ship_street.ShortcutsEnabled = True
        Me.txt_ship_street.ShowClearButton = True
        Me.txt_ship_street.Size = New System.Drawing.Size(644, 23)
        Me.txt_ship_street.TabIndex = 5
        Me.txt_ship_street.UseSelectable = True
        Me.txt_ship_street.WaterMark = "Complete Address"
        Me.txt_ship_street.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ship_street.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_ship_phone
        '
        Me.txt_ship_phone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_ship_phone.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_ship_phone.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_ship_phone.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_ship_phone.CustomButton.Image = Nothing
        Me.txt_ship_phone.CustomButton.Location = New System.Drawing.Point(209, 1)
        Me.txt_ship_phone.CustomButton.Name = ""
        Me.txt_ship_phone.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_ship_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_ship_phone.CustomButton.TabIndex = 1
        Me.txt_ship_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_ship_phone.CustomButton.UseSelectable = True
        Me.txt_ship_phone.CustomButton.Visible = False
        Me.txt_ship_phone.Lines = New String(-1) {}
        Me.txt_ship_phone.Location = New System.Drawing.Point(251, 42)
        Me.txt_ship_phone.MaxLength = 32767
        Me.txt_ship_phone.Name = "txt_ship_phone"
        Me.txt_ship_phone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ship_phone.PromptText = "Phone"
        Me.txt_ship_phone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ship_phone.SelectedText = ""
        Me.txt_ship_phone.SelectionLength = 0
        Me.txt_ship_phone.SelectionStart = 0
        Me.txt_ship_phone.ShortcutsEnabled = True
        Me.txt_ship_phone.ShowClearButton = True
        Me.txt_ship_phone.Size = New System.Drawing.Size(231, 23)
        Me.txt_ship_phone.TabIndex = 7
        Me.txt_ship_phone.UseSelectable = True
        Me.txt_ship_phone.WaterMark = "Phone"
        Me.txt_ship_phone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ship_phone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_ship_contact
        '
        Me.txt_ship_contact.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_ship_contact.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_ship_contact.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_ship_contact.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_ship_contact.CustomButton.Image = Nothing
        Me.txt_ship_contact.CustomButton.Location = New System.Drawing.Point(223, 1)
        Me.txt_ship_contact.CustomButton.Name = ""
        Me.txt_ship_contact.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_ship_contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_ship_contact.CustomButton.TabIndex = 1
        Me.txt_ship_contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_ship_contact.CustomButton.UseSelectable = True
        Me.txt_ship_contact.CustomButton.Visible = False
        Me.txt_ship_contact.Lines = New String(-1) {}
        Me.txt_ship_contact.Location = New System.Drawing.Point(0, 42)
        Me.txt_ship_contact.MaxLength = 32767
        Me.txt_ship_contact.Name = "txt_ship_contact"
        Me.txt_ship_contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ship_contact.PromptText = "Contact Person"
        Me.txt_ship_contact.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ship_contact.SelectedText = ""
        Me.txt_ship_contact.SelectionLength = 0
        Me.txt_ship_contact.SelectionStart = 0
        Me.txt_ship_contact.ShortcutsEnabled = True
        Me.txt_ship_contact.ShowClearButton = True
        Me.txt_ship_contact.Size = New System.Drawing.Size(245, 23)
        Me.txt_ship_contact.TabIndex = 6
        Me.txt_ship_contact.UseSelectable = True
        Me.txt_ship_contact.WaterMark = "Contact Person"
        Me.txt_ship_contact.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ship_contact.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel13
        '
        Me.MetroPanel13.Controls.Add(Me.btn_ShipperNext)
        Me.MetroPanel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel13.HorizontalScrollbarBarColor = True
        Me.MetroPanel13.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel13.HorizontalScrollbarSize = 10
        Me.MetroPanel13.Location = New System.Drawing.Point(0, 425)
        Me.MetroPanel13.Name = "MetroPanel13"
        Me.MetroPanel13.Size = New System.Drawing.Size(947, 49)
        Me.MetroPanel13.TabIndex = 56
        Me.MetroPanel13.VerticalScrollbarBarColor = True
        Me.MetroPanel13.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel13.VerticalScrollbarSize = 10
        '
        'btn_ShipperNext
        '
        Me.btn_ShipperNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ShipperNext.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_ShipperNext.Location = New System.Drawing.Point(714, 8)
        Me.btn_ShipperNext.Name = "btn_ShipperNext"
        Me.btn_ShipperNext.Size = New System.Drawing.Size(107, 31)
        Me.btn_ShipperNext.TabIndex = 11
        Me.btn_ShipperNext.Text = "Next"
        Me.btn_ShipperNext.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_ShipperNext.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.MetroLabel23)
        Me.MetroPanel1.Controls.Add(Me.txt_Ship_Company)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(947, 90)
        Me.MetroPanel1.TabIndex = 6
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel23.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel23.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel23.TabIndex = 20
        Me.MetroLabel23.Text = "CLIENT NAME"
        Me.MetroLabel23.UseCustomForeColor = True
        '
        'txt_Ship_Company
        '
        Me.txt_Ship_Company.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_Ship_Company.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_Ship_Company.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_Ship_Company.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_Ship_Company.CustomButton.Image = Nothing
        Me.txt_Ship_Company.CustomButton.Location = New System.Drawing.Point(708, 1)
        Me.txt_Ship_Company.CustomButton.Name = ""
        Me.txt_Ship_Company.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Ship_Company.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Ship_Company.CustomButton.TabIndex = 1
        Me.txt_Ship_Company.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Ship_Company.CustomButton.UseSelectable = True
        Me.txt_Ship_Company.CustomButton.Visible = False
        Me.txt_Ship_Company.Lines = New String(-1) {}
        Me.txt_Ship_Company.Location = New System.Drawing.Point(90, 38)
        Me.txt_Ship_Company.MaxLength = 32767
        Me.txt_Ship_Company.Name = "txt_Ship_Company"
        Me.txt_Ship_Company.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Ship_Company.PromptText = "Company or Individual"
        Me.txt_Ship_Company.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Ship_Company.SelectedText = ""
        Me.txt_Ship_Company.SelectionLength = 0
        Me.txt_Ship_Company.SelectionStart = 0
        Me.txt_Ship_Company.ShortcutsEnabled = True
        Me.txt_Ship_Company.ShowClearButton = True
        Me.txt_Ship_Company.Size = New System.Drawing.Size(730, 23)
        Me.txt_Ship_Company.TabIndex = 0
        Me.txt_Ship_Company.UseSelectable = True
        Me.txt_Ship_Company.WaterMark = "Company or Individual"
        Me.txt_Ship_Company.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Ship_Company.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel6
        '
        Me.MetroPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel6.Controls.Add(Me.dtp_pickuptime)
        Me.MetroPanel6.Controls.Add(Me.dtp_pickupdate)
        Me.MetroPanel6.Controls.Add(Me.MetroLabel15)
        Me.MetroPanel6.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel6.Controls.Add(Me.MetroLabel18)
        Me.MetroPanel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel6.HorizontalScrollbarBarColor = True
        Me.MetroPanel6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.HorizontalScrollbarSize = 10
        Me.MetroPanel6.Location = New System.Drawing.Point(0, 346)
        Me.MetroPanel6.Name = "MetroPanel6"
        Me.MetroPanel6.Size = New System.Drawing.Size(282, 79)
        Me.MetroPanel6.TabIndex = 65
        Me.MetroPanel6.VerticalScrollbarBarColor = True
        Me.MetroPanel6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.VerticalScrollbarSize = 10
        '
        'dtp_pickuptime
        '
        Me.dtp_pickuptime.CustomFormat = "HH:mm"
        Me.dtp_pickuptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_pickuptime.Location = New System.Drawing.Point(208, 37)
        Me.dtp_pickuptime.Name = "dtp_pickuptime"
        Me.dtp_pickuptime.ShowUpDown = True
        Me.dtp_pickuptime.Size = New System.Drawing.Size(59, 20)
        Me.dtp_pickuptime.TabIndex = 38
        '
        'dtp_pickupdate
        '
        Me.dtp_pickupdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_pickupdate.Location = New System.Drawing.Point(58, 37)
        Me.dtp_pickupdate.Name = "dtp_pickupdate"
        Me.dtp_pickupdate.Size = New System.Drawing.Size(97, 20)
        Me.dtp_pickupdate.TabIndex = 37
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(13, 38)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel15.TabIndex = 69
        Me.MetroLabel15.Text = "Date:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(161, 37)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel5.TabIndex = 70
        Me.MetroLabel5.Text = "Time:"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel18.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel18.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel18.TabIndex = 20
        Me.MetroLabel18.Text = "PICKUP TIME SLOT"
        Me.MetroLabel18.UseCustomForeColor = True
        '
        'MetroPanel4
        '
        Me.MetroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel4.Controls.Add(Me.lbl_UomDesc)
        Me.MetroPanel4.Controls.Add(Me.cbo_Uom)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel19)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel4.Controls.Add(Me.txt_SpeIns)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel14)
        Me.MetroPanel4.Controls.Add(Me.txt_TotalWeight)
        Me.MetroPanel4.Controls.Add(Me.ml_clear)
        Me.MetroPanel4.Controls.Add(Me.ml_attached)
        Me.MetroPanel4.Controls.Add(Me.pb_Cargo)
        Me.MetroPanel4.Controls.Add(Me.txt_DeclaredValue)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel13)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel12)
        Me.MetroPanel4.Controls.Add(Me.txt_Commodity)
        Me.MetroPanel4.Controls.Add(Me.cbo_Type)
        Me.MetroPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(0, 153)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(564, 193)
        Me.MetroPanel4.TabIndex = 63
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'lbl_UomDesc
        '
        Me.lbl_UomDesc.Location = New System.Drawing.Point(289, 126)
        Me.lbl_UomDesc.Name = "lbl_UomDesc"
        Me.lbl_UomDesc.Size = New System.Drawing.Size(112, 19)
        Me.lbl_UomDesc.TabIndex = 72
        '
        'cbo_Uom
        '
        Me.cbo_Uom.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_Uom.FormattingEnabled = True
        Me.cbo_Uom.ItemHeight = 19
        Me.cbo_Uom.Location = New System.Drawing.Point(289, 93)
        Me.cbo_Uom.Name = "cbo_Uom"
        Me.cbo_Uom.Size = New System.Drawing.Size(112, 25)
        Me.cbo_Uom.TabIndex = 32
        Me.cbo_Uom.UseSelectable = True
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(244, 97)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel19.TabIndex = 68
        Me.MetroLabel19.Text = "UOM:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(63, 126)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel2.TabIndex = 67
        Me.MetroLabel2.Text = "Weight:"
        '
        'txt_SpeIns
        '
        '
        '
        '
        Me.txt_SpeIns.CustomButton.Image = Nothing
        Me.txt_SpeIns.CustomButton.Location = New System.Drawing.Point(257, 1)
        Me.txt_SpeIns.CustomButton.Name = ""
        Me.txt_SpeIns.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_SpeIns.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_SpeIns.CustomButton.TabIndex = 1
        Me.txt_SpeIns.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_SpeIns.CustomButton.UseSelectable = True
        Me.txt_SpeIns.CustomButton.Visible = False
        Me.txt_SpeIns.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_SpeIns.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txt_SpeIns.Lines = New String(-1) {}
        Me.txt_SpeIns.Location = New System.Drawing.Point(122, 151)
        Me.txt_SpeIns.MaxLength = 32767
        Me.txt_SpeIns.Name = "txt_SpeIns"
        Me.txt_SpeIns.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_SpeIns.PromptText = "Remarks or any special instruction"
        Me.txt_SpeIns.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SpeIns.SelectedText = ""
        Me.txt_SpeIns.SelectionLength = 0
        Me.txt_SpeIns.SelectionStart = 0
        Me.txt_SpeIns.ShortcutsEnabled = True
        Me.txt_SpeIns.Size = New System.Drawing.Size(279, 23)
        Me.txt_SpeIns.TabIndex = 34
        Me.txt_SpeIns.UseSelectable = True
        Me.txt_SpeIns.WaterMark = "Remarks or any special instruction"
        Me.txt_SpeIns.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_SpeIns.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(45, 155)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel14.TabIndex = 65
        Me.MetroLabel14.Text = "Instruction:"
        '
        'txt_TotalWeight
        '
        Me.txt_TotalWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_TotalWeight.CustomButton.Image = Nothing
        Me.txt_TotalWeight.CustomButton.Location = New System.Drawing.Point(93, 1)
        Me.txt_TotalWeight.CustomButton.Name = ""
        Me.txt_TotalWeight.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_TotalWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_TotalWeight.CustomButton.TabIndex = 1
        Me.txt_TotalWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_TotalWeight.CustomButton.UseSelectable = True
        Me.txt_TotalWeight.CustomButton.Visible = False
        Me.txt_TotalWeight.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_TotalWeight.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txt_TotalWeight.Lines = New String(-1) {}
        Me.txt_TotalWeight.Location = New System.Drawing.Point(123, 122)
        Me.txt_TotalWeight.MaxLength = 32767
        Me.txt_TotalWeight.Name = "txt_TotalWeight"
        Me.txt_TotalWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_TotalWeight.PromptText = "Item weight (kg)"
        Me.txt_TotalWeight.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TotalWeight.SelectedText = ""
        Me.txt_TotalWeight.SelectionLength = 0
        Me.txt_TotalWeight.SelectionStart = 0
        Me.txt_TotalWeight.ShortcutsEnabled = True
        Me.txt_TotalWeight.Size = New System.Drawing.Size(115, 23)
        Me.txt_TotalWeight.TabIndex = 33
        Me.txt_TotalWeight.UseSelectable = True
        Me.txt_TotalWeight.WaterMark = "Item weight (kg)"
        Me.txt_TotalWeight.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_TotalWeight.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ml_clear
        '
        Me.ml_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ml_clear.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.ml_clear.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ml_clear.Location = New System.Drawing.Point(488, 15)
        Me.ml_clear.Name = "ml_clear"
        Me.ml_clear.Size = New System.Drawing.Size(49, 13)
        Me.ml_clear.TabIndex = 36
        Me.ml_clear.Text = "Clear"
        Me.ml_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ml_clear.UseCustomForeColor = True
        Me.ml_clear.UseSelectable = True
        '
        'pb_Cargo
        '
        Me.pb_Cargo.Location = New System.Drawing.Point(407, 33)
        Me.pb_Cargo.Name = "pb_Cargo"
        Me.pb_Cargo.Size = New System.Drawing.Size(131, 141)
        Me.pb_Cargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Cargo.TabIndex = 51
        Me.pb_Cargo.TabStop = False
        '
        'txt_DeclaredValue
        '
        '
        '
        '
        Me.txt_DeclaredValue.CustomButton.Image = Nothing
        Me.txt_DeclaredValue.CustomButton.Location = New System.Drawing.Point(93, 1)
        Me.txt_DeclaredValue.CustomButton.Name = ""
        Me.txt_DeclaredValue.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_DeclaredValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_DeclaredValue.CustomButton.TabIndex = 1
        Me.txt_DeclaredValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_DeclaredValue.CustomButton.UseSelectable = True
        Me.txt_DeclaredValue.CustomButton.Visible = False
        Me.txt_DeclaredValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_DeclaredValue.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txt_DeclaredValue.Lines = New String(-1) {}
        Me.txt_DeclaredValue.Location = New System.Drawing.Point(123, 93)
        Me.txt_DeclaredValue.MaxLength = 32767
        Me.txt_DeclaredValue.Name = "txt_DeclaredValue"
        Me.txt_DeclaredValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_DeclaredValue.PromptText = "Item amount"
        Me.txt_DeclaredValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DeclaredValue.SelectedText = ""
        Me.txt_DeclaredValue.SelectionLength = 0
        Me.txt_DeclaredValue.SelectionStart = 0
        Me.txt_DeclaredValue.ShortcutsEnabled = True
        Me.txt_DeclaredValue.Size = New System.Drawing.Size(115, 23)
        Me.txt_DeclaredValue.TabIndex = 31
        Me.txt_DeclaredValue.UseSelectable = True
        Me.txt_DeclaredValue.WaterMark = "Item amount"
        Me.txt_DeclaredValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_DeclaredValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(18, 97)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel11.TabIndex = 60
        Me.MetroLabel11.Text = "Declared Value:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel10.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel10.TabIndex = 20
        Me.MetroLabel10.Text = "COMMODITIES"
        Me.MetroLabel10.UseCustomForeColor = True
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel3.Controls.Add(Me.cbo_Loading)
        Me.MetroPanel3.Controls.Add(Me.cbo_Freight)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel3.Controls.Add(Me.cbo_Pay)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel17)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel3.Controls.Add(Me.cbo_Service)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(564, 153)
        Me.MetroPanel3.TabIndex = 62
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'cbo_Loading
        '
        Me.cbo_Loading.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_Loading.FormattingEnabled = True
        Me.cbo_Loading.ItemHeight = 19
        Me.cbo_Loading.Location = New System.Drawing.Point(122, 19)
        Me.cbo_Loading.Name = "cbo_Loading"
        Me.cbo_Loading.Size = New System.Drawing.Size(279, 25)
        Me.cbo_Loading.TabIndex = 25
        Me.cbo_Loading.UseSelectable = True
        '
        'cbo_Freight
        '
        Me.cbo_Freight.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_Freight.FormattingEnabled = True
        Me.cbo_Freight.ItemHeight = 19
        Me.cbo_Freight.Location = New System.Drawing.Point(122, 112)
        Me.cbo_Freight.Name = "cbo_Freight"
        Me.cbo_Freight.Size = New System.Drawing.Size(279, 25)
        Me.cbo_Freight.TabIndex = 28
        Me.cbo_Freight.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(63, 118)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel8.TabIndex = 62
        Me.MetroLabel8.Text = "Freight:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel9.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel9.TabIndex = 20
        Me.MetroLabel9.Text = "MODE"
        Me.MetroLabel9.UseCustomForeColor = True
        '
        'MetroPanel7
        '
        Me.MetroPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel7.Controls.Add(Me.dgv_Dimension)
        Me.MetroPanel7.Controls.Add(Me.MetroPanel11)
        Me.MetroPanel7.Controls.Add(Me.MetroLabel21)
        Me.MetroPanel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroPanel7.HorizontalScrollbarBarColor = True
        Me.MetroPanel7.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel7.HorizontalScrollbarSize = 10
        Me.MetroPanel7.Location = New System.Drawing.Point(564, 0)
        Me.MetroPanel7.Name = "MetroPanel7"
        Me.MetroPanel7.Size = New System.Drawing.Size(383, 425)
        Me.MetroPanel7.TabIndex = 66
        Me.MetroPanel7.VerticalScrollbarBarColor = True
        Me.MetroPanel7.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel7.VerticalScrollbarSize = 10
        '
        'dgv_Dimension
        '
        Me.dgv_Dimension.AllowUserToAddRows = False
        Me.dgv_Dimension.AllowUserToDeleteRows = False
        Me.dgv_Dimension.AllowUserToResizeRows = False
        Me.dgv_Dimension.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_Dimension.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Dimension.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Dimension.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_Dimension.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Dimension.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Dimension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Dimension.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Dimension.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Dimension.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Dimension.EnableHeadersVisualStyles = False
        Me.dgv_Dimension.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_Dimension.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Dimension.Location = New System.Drawing.Point(0, 19)
        Me.dgv_Dimension.Name = "dgv_Dimension"
        Me.dgv_Dimension.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Dimension.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Dimension.RowHeadersWidth = 35
        Me.dgv_Dimension.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_Dimension.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Dimension.Size = New System.Drawing.Size(381, 373)
        Me.dgv_Dimension.TabIndex = 38
        '
        'Column1
        '
        Me.Column1.HeaderText = "L"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 35
        '
        'Column3
        '
        Me.Column3.HeaderText = "W"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 41
        '
        'Column4
        '
        Me.Column4.HeaderText = "H"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 38
        '
        'Column5
        '
        Me.Column5.HeaderText = "Qty"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 47
        '
        'Column6
        '
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column6.HeaderText = "Vol"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 46
        '
        'MetroPanel11
        '
        Me.MetroPanel11.Controls.Add(Me.MetroLabel16)
        Me.MetroPanel11.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel11.Controls.Add(Me.lbl_TotalVol)
        Me.MetroPanel11.Controls.Add(Me.lbl_TotalQty)
        Me.MetroPanel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel11.HorizontalScrollbarBarColor = True
        Me.MetroPanel11.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel11.HorizontalScrollbarSize = 10
        Me.MetroPanel11.Location = New System.Drawing.Point(0, 392)
        Me.MetroPanel11.Name = "MetroPanel11"
        Me.MetroPanel11.Size = New System.Drawing.Size(381, 31)
        Me.MetroPanel11.TabIndex = 64
        Me.MetroPanel11.VerticalScrollbarBarColor = True
        Me.MetroPanel11.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel11.VerticalScrollbarSize = 10
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(276, 6)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(27, 19)
        Me.MetroLabel16.TabIndex = 69
        Me.MetroLabel16.Text = "TV:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(164, 6)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel7.TabIndex = 68
        Me.MetroLabel7.Text = "TQ:"
        '
        'lbl_TotalVol
        '
        Me.lbl_TotalVol.AutoSize = True
        Me.lbl_TotalVol.ForeColor = System.Drawing.Color.Red
        Me.lbl_TotalVol.Location = New System.Drawing.Point(309, 6)
        Me.lbl_TotalVol.Name = "lbl_TotalVol"
        Me.lbl_TotalVol.Size = New System.Drawing.Size(0, 0)
        Me.lbl_TotalVol.TabIndex = 67
        Me.lbl_TotalVol.UseCustomForeColor = True
        '
        'lbl_TotalQty
        '
        Me.lbl_TotalQty.AutoSize = True
        Me.lbl_TotalQty.ForeColor = System.Drawing.Color.Red
        Me.lbl_TotalQty.Location = New System.Drawing.Point(199, 6)
        Me.lbl_TotalQty.Name = "lbl_TotalQty"
        Me.lbl_TotalQty.Size = New System.Drawing.Size(0, 0)
        Me.lbl_TotalQty.TabIndex = 66
        Me.lbl_TotalQty.UseCustomForeColor = True
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel21.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel21.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel21.TabIndex = 20
        Me.MetroLabel21.Text = "DIMENSION"
        Me.MetroLabel21.UseCustomForeColor = True
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(834, 8)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_Submit.TabIndex = 40
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'btn_ShipmentBack
        '
        Me.btn_ShipmentBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ShipmentBack.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_ShipmentBack.Location = New System.Drawing.Point(721, 8)
        Me.btn_ShipmentBack.Name = "btn_ShipmentBack"
        Me.btn_ShipmentBack.Size = New System.Drawing.Size(107, 31)
        Me.btn_ShipmentBack.TabIndex = 40
        Me.btn_ShipmentBack.Text = "Back"
        Me.btn_ShipmentBack.UseSelectable = True
        '
        'mtc_Pickup
        '
        Me.mtc_Pickup.Controls.Add(Me.mtp_shipper)
        Me.mtc_Pickup.Controls.Add(Me.mtp_shipment)
        Me.mtc_Pickup.Location = New System.Drawing.Point(57, 60)
        Me.mtc_Pickup.Name = "mtc_Pickup"
        Me.mtc_Pickup.SelectedIndex = 1
        Me.mtc_Pickup.Size = New System.Drawing.Size(955, 516)
        Me.mtc_Pickup.Style = MetroFramework.MetroColorStyle.Teal
        Me.mtc_Pickup.TabIndex = 11
        Me.mtc_Pickup.UseSelectable = True
        '
        'mtp_shipment
        '
        Me.mtp_shipment.Controls.Add(Me.MetroPanel2)
        Me.mtp_shipment.Controls.Add(Me.MetroPanel6)
        Me.mtp_shipment.Controls.Add(Me.MetroPanel4)
        Me.mtp_shipment.Controls.Add(Me.MetroPanel3)
        Me.mtp_shipment.Controls.Add(Me.MetroPanel7)
        Me.mtp_shipment.Controls.Add(Me.MetroPanel5)
        Me.mtp_shipment.HorizontalScrollbarBarColor = True
        Me.mtp_shipment.HorizontalScrollbarHighlightOnWheel = False
        Me.mtp_shipment.HorizontalScrollbarSize = 10
        Me.mtp_shipment.Location = New System.Drawing.Point(4, 38)
        Me.mtp_shipment.Name = "mtp_shipment"
        Me.mtp_shipment.Size = New System.Drawing.Size(947, 474)
        Me.mtp_shipment.TabIndex = 2
        Me.mtp_shipment.Text = "Shipment"
        Me.mtp_shipment.VerticalScrollbarBarColor = True
        Me.mtp_shipment.VerticalScrollbarHighlightOnWheel = False
        Me.mtp_shipment.VerticalScrollbarSize = 10
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.cbo_Origin)
        Me.MetroPanel2.Controls.Add(Me.lbl_Code)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel20)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel24)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(282, 346)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(282, 79)
        Me.MetroPanel2.TabIndex = 67
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'cbo_Origin
        '
        Me.cbo_Origin.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_Origin.FormattingEnabled = True
        Me.cbo_Origin.ItemHeight = 19
        Me.cbo_Origin.Location = New System.Drawing.Point(72, 32)
        Me.cbo_Origin.Name = "cbo_Origin"
        Me.cbo_Origin.Size = New System.Drawing.Size(184, 25)
        Me.cbo_Origin.TabIndex = 39
        Me.cbo_Origin.UseSelectable = True
        '
        'lbl_Code
        '
        Me.lbl_Code.AutoSize = True
        Me.lbl_Code.Location = New System.Drawing.Point(72, 10)
        Me.lbl_Code.Name = "lbl_Code"
        Me.lbl_Code.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Code.TabIndex = 71
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(18, 38)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel20.TabIndex = 69
        Me.MetroLabel20.Text = "Origin:"
        '
        'MetroLabel24
        '
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroLabel24.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel24.ForeColor = System.Drawing.Color.Gray
        Me.MetroLabel24.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel24.TabIndex = 20
        Me.MetroLabel24.Text = "ORIGIN"
        Me.MetroLabel24.UseCustomForeColor = True
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Controls.Add(Me.btn_Submit)
        Me.MetroPanel5.Controls.Add(Me.btn_ShipmentBack)
        Me.MetroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(0, 425)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(947, 49)
        Me.MetroPanel5.TabIndex = 64
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'PickUpSched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.mtc_Pickup)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PickUpSched"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Pickup Schedule"
        Me.mtp_shipper.ResumeLayout(False)
        Me.MetroPanel10.ResumeLayout(False)
        Me.MetroPanel10.PerformLayout()
        Me.pnl_ship_selectadd.ResumeLayout(False)
        Me.pnl_ship_selectadd.PerformLayout()
        CType(Me.dgv_Origin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ship_newadd.ResumeLayout(False)
        Me.MetroPanel13.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel6.ResumeLayout(False)
        Me.MetroPanel6.PerformLayout()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        CType(Me.pb_Cargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.MetroPanel7.ResumeLayout(False)
        Me.MetroPanel7.PerformLayout()
        CType(Me.dgv_Dimension, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel11.ResumeLayout(False)
        Me.MetroPanel11.PerformLayout()
        Me.mtc_Pickup.ResumeLayout(False)
        Me.mtp_shipment.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbo_Pay As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_Service As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_Vehicle As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_Commodity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbo_Type As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ml_attached As MetroFramework.Controls.MetroLink
    Friend WithEvents pb_Cargo As PictureBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtp_shipper As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel10 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnl_ship_newadd As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_shipadd_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_shipadd_submit As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_ship_zip As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_ship_email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_ship_street As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_ship_phone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_ship_contact As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnl_ship_selectadd As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_Ship_Company As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtc_Pickup As MetroFramework.Controls.MetroTabControl
    Friend WithEvents lbl_ship_newadd As MetroFramework.Controls.MetroLink
    Friend WithEvents dgv_Origin As MetroFramework.Controls.MetroGrid
    Friend WithEvents approval As DataGridViewCheckBoxColumn
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_ShipmentBack As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_DeclaredValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel6 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel7 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_TotalWeight As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ml_clear As MetroFramework.Controls.MetroLink
    Friend WithEvents dgv_Dimension As MetroFramework.Controls.MetroGrid
    Friend WithEvents cbo_Freight As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_SpeIns As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_Loading As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtp_pickupdate As DateTimePicker
    Friend WithEvents dtp_pickuptime As DateTimePicker
    Friend WithEvents MetroPanel11 As MetroFramework.Controls.MetroPanel
    Friend WithEvents lbl_TotalVol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_TotalQty As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_Uom As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lbl_UomDesc As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel13 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_ShipperNext As MetroFramework.Controls.MetroButton
    Friend WithEvents mtp_shipment As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel5 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Code As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_Origin As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents sel As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewLinkColumn
End Class
