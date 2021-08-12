<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PickUpSched_Mod
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_PickupNo = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.dtp_pickupdate = New System.Windows.Forms.DateTimePicker()
        Me.dtp_pickuptime = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.dgv_Origin = New MetroFramework.Controls.MetroGrid()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txt_Commodity = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txt_SpeIns = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.dgv_Dimension = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txt_TotalWeight = New MetroFramework.Controls.MetroTextBox()
        Me.cbo_Loading = New System.Windows.Forms.ComboBox()
        Me.cbo_Service = New System.Windows.Forms.ComboBox()
        Me.cbo_Pay = New System.Windows.Forms.ComboBox()
        Me.cbo_Freight = New System.Windows.Forms.ComboBox()
        Me.cbo_Type = New System.Windows.Forms.ComboBox()
        Me.cbo_Origin = New System.Windows.Forms.ComboBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel7 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel11 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_TotalQty = New MetroFramework.Controls.MetroLabel()
        Me.lbl_TotalVol = New MetroFramework.Controls.MetroLabel()
        CType(Me.dgv_Origin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel5.SuspendLayout()
        CType(Me.dgv_Dimension, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel7.SuspendLayout()
        Me.MetroPanel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(26, 75)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Pickup No."
        '
        'lbl_PickupNo
        '
        Me.lbl_PickupNo.AutoSize = True
        Me.lbl_PickupNo.ForeColor = System.Drawing.Color.Red
        Me.lbl_PickupNo.Location = New System.Drawing.Point(133, 75)
        Me.lbl_PickupNo.Name = "lbl_PickupNo"
        Me.lbl_PickupNo.Size = New System.Drawing.Size(0, 0)
        Me.lbl_PickupNo.TabIndex = 1
        Me.lbl_PickupNo.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(26, 104)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Date/Time:"
        '
        'dtp_pickupdate
        '
        Me.dtp_pickupdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_pickupdate.Location = New System.Drawing.Point(133, 103)
        Me.dtp_pickupdate.Name = "dtp_pickupdate"
        Me.dtp_pickupdate.Size = New System.Drawing.Size(97, 20)
        Me.dtp_pickupdate.TabIndex = 38
        '
        'dtp_pickuptime
        '
        Me.dtp_pickuptime.CustomFormat = "HH:mm"
        Me.dtp_pickuptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_pickuptime.Location = New System.Drawing.Point(236, 103)
        Me.dtp_pickuptime.Name = "dtp_pickuptime"
        Me.dtp_pickuptime.ShowUpDown = True
        Me.dtp_pickuptime.Size = New System.Drawing.Size(59, 20)
        Me.dtp_pickuptime.TabIndex = 39
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(26, 161)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel4.TabIndex = 42
        Me.MetroLabel4.Text = "Pickup Address:"
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
        Me.dgv_Origin.EnableHeadersVisualStyles = False
        Me.dgv_Origin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_Origin.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Origin.Location = New System.Drawing.Point(133, 161)
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
        Me.dgv_Origin.RowHeadersVisible = False
        Me.dgv_Origin.RowHeadersWidth = 35
        Me.dgv_Origin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_Origin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Origin.Size = New System.Drawing.Size(258, 88)
        Me.dgv_Origin.TabIndex = 43
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
        Me.Column2.HeaderText = "Remove"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Text = "Remove"
        Me.Column2.UseColumnTextForLinkValue = True
        Me.Column2.Width = 51
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(24, 290)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel3.TabIndex = 44
        Me.MetroLabel3.Text = "Loading:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(22, 321)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel5.TabIndex = 46
        Me.MetroLabel5.Text = "Service:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 352)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel6.TabIndex = 50
        Me.MetroLabel6.Text = "Pay:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(22, 383)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel7.TabIndex = 51
        Me.MetroLabel7.Text = "Freight:"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(24, 414)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel13.TabIndex = 56
        Me.MetroLabel13.Text = "Type:"
        '
        'txt_Commodity
        '
        '
        '
        '
        Me.txt_Commodity.CustomButton.Image = Nothing
        Me.txt_Commodity.CustomButton.Location = New System.Drawing.Point(237, 1)
        Me.txt_Commodity.CustomButton.Name = ""
        Me.txt_Commodity.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Commodity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Commodity.CustomButton.TabIndex = 1
        Me.txt_Commodity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Commodity.CustomButton.UseSelectable = True
        Me.txt_Commodity.CustomButton.Visible = False
        Me.txt_Commodity.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txt_Commodity.Lines = New String(-1) {}
        Me.txt_Commodity.Location = New System.Drawing.Point(133, 439)
        Me.txt_Commodity.MaxLength = 32767
        Me.txt_Commodity.Name = "txt_Commodity"
        Me.txt_Commodity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Commodity.PromptText = "Item description"
        Me.txt_Commodity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Commodity.SelectedText = ""
        Me.txt_Commodity.SelectionLength = 0
        Me.txt_Commodity.SelectionStart = 0
        Me.txt_Commodity.ShortcutsEnabled = True
        Me.txt_Commodity.Size = New System.Drawing.Size(259, 23)
        Me.txt_Commodity.TabIndex = 58
        Me.txt_Commodity.UseSelectable = True
        Me.txt_Commodity.WaterMark = "Item description"
        Me.txt_Commodity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Commodity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(23, 443)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel12.TabIndex = 59
        Me.MetroLabel12.Text = "Commodity:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(23, 472)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel8.TabIndex = 61
        Me.MetroLabel8.Text = "Instruction:"
        '
        'txt_SpeIns
        '
        '
        '
        '
        Me.txt_SpeIns.CustomButton.Image = Nothing
        Me.txt_SpeIns.CustomButton.Location = New System.Drawing.Point(237, 1)
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
        Me.txt_SpeIns.Location = New System.Drawing.Point(133, 468)
        Me.txt_SpeIns.MaxLength = 32767
        Me.txt_SpeIns.Name = "txt_SpeIns"
        Me.txt_SpeIns.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_SpeIns.PromptText = "Remarks or any special instruction"
        Me.txt_SpeIns.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SpeIns.SelectedText = ""
        Me.txt_SpeIns.SelectionLength = 0
        Me.txt_SpeIns.SelectionStart = 0
        Me.txt_SpeIns.ShortcutsEnabled = True
        Me.txt_SpeIns.Size = New System.Drawing.Size(259, 23)
        Me.txt_SpeIns.TabIndex = 62
        Me.txt_SpeIns.UseSelectable = True
        Me.txt_SpeIns.WaterMark = "Remarks or any special instruction"
        Me.txt_SpeIns.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_SpeIns.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(26, 132)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel20.TabIndex = 70
        Me.MetroLabel20.Text = "Origin:"
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(264, 0)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_Submit.TabIndex = 72
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Controls.Add(Me.btn_Submit)
        Me.MetroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(20, 619)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(379, 31)
        Me.MetroPanel5.TabIndex = 73
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Dimension.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Dimension.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Dimension.EnableHeadersVisualStyles = False
        Me.dgv_Dimension.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_Dimension.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Dimension.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Dimension.Name = "dgv_Dimension"
        Me.dgv_Dimension.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Dimension.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Dimension.RowHeadersVisible = False
        Me.dgv_Dimension.RowHeadersWidth = 35
        Me.dgv_Dimension.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_Dimension.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Dimension.Size = New System.Drawing.Size(256, 80)
        Me.dgv_Dimension.TabIndex = 74
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(24, 259)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel9.TabIndex = 75
        Me.MetroLabel9.Text = "Weight:"
        '
        'txt_TotalWeight
        '
        '
        '
        '
        Me.txt_TotalWeight.CustomButton.Image = Nothing
        Me.txt_TotalWeight.CustomButton.Location = New System.Drawing.Point(237, 1)
        Me.txt_TotalWeight.CustomButton.Name = ""
        Me.txt_TotalWeight.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_TotalWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_TotalWeight.CustomButton.TabIndex = 1
        Me.txt_TotalWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_TotalWeight.CustomButton.UseSelectable = True
        Me.txt_TotalWeight.CustomButton.Visible = False
        Me.txt_TotalWeight.Lines = New String(-1) {}
        Me.txt_TotalWeight.Location = New System.Drawing.Point(133, 255)
        Me.txt_TotalWeight.MaxLength = 32767
        Me.txt_TotalWeight.Name = "txt_TotalWeight"
        Me.txt_TotalWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_TotalWeight.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TotalWeight.SelectedText = ""
        Me.txt_TotalWeight.SelectionLength = 0
        Me.txt_TotalWeight.SelectionStart = 0
        Me.txt_TotalWeight.ShortcutsEnabled = True
        Me.txt_TotalWeight.Size = New System.Drawing.Size(259, 23)
        Me.txt_TotalWeight.TabIndex = 76
        Me.txt_TotalWeight.UseSelectable = True
        Me.txt_TotalWeight.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_TotalWeight.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbo_Loading
        '
        Me.cbo_Loading.FormattingEnabled = True
        Me.cbo_Loading.Location = New System.Drawing.Point(133, 287)
        Me.cbo_Loading.Name = "cbo_Loading"
        Me.cbo_Loading.Size = New System.Drawing.Size(258, 21)
        Me.cbo_Loading.TabIndex = 83
        '
        'cbo_Service
        '
        Me.cbo_Service.FormattingEnabled = True
        Me.cbo_Service.Location = New System.Drawing.Point(133, 319)
        Me.cbo_Service.Name = "cbo_Service"
        Me.cbo_Service.Size = New System.Drawing.Size(258, 21)
        Me.cbo_Service.TabIndex = 84
        '
        'cbo_Pay
        '
        Me.cbo_Pay.FormattingEnabled = True
        Me.cbo_Pay.Location = New System.Drawing.Point(133, 350)
        Me.cbo_Pay.Name = "cbo_Pay"
        Me.cbo_Pay.Size = New System.Drawing.Size(258, 21)
        Me.cbo_Pay.TabIndex = 85
        '
        'cbo_Freight
        '
        Me.cbo_Freight.FormattingEnabled = True
        Me.cbo_Freight.Location = New System.Drawing.Point(133, 381)
        Me.cbo_Freight.Name = "cbo_Freight"
        Me.cbo_Freight.Size = New System.Drawing.Size(258, 21)
        Me.cbo_Freight.TabIndex = 86
        '
        'cbo_Type
        '
        Me.cbo_Type.FormattingEnabled = True
        Me.cbo_Type.Location = New System.Drawing.Point(133, 411)
        Me.cbo_Type.Name = "cbo_Type"
        Me.cbo_Type.Size = New System.Drawing.Size(258, 21)
        Me.cbo_Type.TabIndex = 87
        '
        'cbo_Origin
        '
        Me.cbo_Origin.FormattingEnabled = True
        Me.cbo_Origin.Location = New System.Drawing.Point(133, 131)
        Me.cbo_Origin.Name = "cbo_Origin"
        Me.cbo_Origin.Size = New System.Drawing.Size(258, 21)
        Me.cbo_Origin.TabIndex = 88
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(23, 500)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel10.TabIndex = 89
        Me.MetroLabel10.Text = "Dimension:"
        '
        'MetroPanel7
        '
        Me.MetroPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel7.Controls.Add(Me.dgv_Dimension)
        Me.MetroPanel7.Controls.Add(Me.MetroPanel11)
        Me.MetroPanel7.HorizontalScrollbarBarColor = True
        Me.MetroPanel7.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel7.HorizontalScrollbarSize = 10
        Me.MetroPanel7.Location = New System.Drawing.Point(133, 500)
        Me.MetroPanel7.Name = "MetroPanel7"
        Me.MetroPanel7.Size = New System.Drawing.Size(258, 113)
        Me.MetroPanel7.TabIndex = 90
        Me.MetroPanel7.VerticalScrollbarBarColor = True
        Me.MetroPanel7.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel7.VerticalScrollbarSize = 10
        '
        'MetroPanel11
        '
        Me.MetroPanel11.Controls.Add(Me.MetroLabel16)
        Me.MetroPanel11.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel11.Controls.Add(Me.lbl_TotalQty)
        Me.MetroPanel11.Controls.Add(Me.lbl_TotalVol)
        Me.MetroPanel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel11.HorizontalScrollbarBarColor = True
        Me.MetroPanel11.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel11.HorizontalScrollbarSize = 10
        Me.MetroPanel11.Location = New System.Drawing.Point(0, 80)
        Me.MetroPanel11.Name = "MetroPanel11"
        Me.MetroPanel11.Size = New System.Drawing.Size(256, 31)
        Me.MetroPanel11.TabIndex = 64
        Me.MetroPanel11.VerticalScrollbarBarColor = True
        Me.MetroPanel11.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel11.VerticalScrollbarSize = 10
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(167, 6)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(27, 19)
        Me.MetroLabel16.TabIndex = 69
        Me.MetroLabel16.Text = "TV:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(74, 6)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel11.TabIndex = 68
        Me.MetroLabel11.Text = "TQ:"
        '
        'lbl_TotalQty
        '
        Me.lbl_TotalQty.AutoSize = True
        Me.lbl_TotalQty.ForeColor = System.Drawing.Color.Red
        Me.lbl_TotalQty.Location = New System.Drawing.Point(109, 6)
        Me.lbl_TotalQty.Name = "lbl_TotalQty"
        Me.lbl_TotalQty.Size = New System.Drawing.Size(0, 0)
        Me.lbl_TotalQty.TabIndex = 66
        Me.lbl_TotalQty.UseCustomForeColor = True
        '
        'lbl_TotalVol
        '
        Me.lbl_TotalVol.AutoSize = True
        Me.lbl_TotalVol.ForeColor = System.Drawing.Color.Red
        Me.lbl_TotalVol.Location = New System.Drawing.Point(200, 6)
        Me.lbl_TotalVol.Name = "lbl_TotalVol"
        Me.lbl_TotalVol.Size = New System.Drawing.Size(0, 0)
        Me.lbl_TotalVol.TabIndex = 67
        Me.lbl_TotalVol.UseCustomForeColor = True
        '
        'PickUpSched_Mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 670)
        Me.Controls.Add(Me.MetroPanel7)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.cbo_Origin)
        Me.Controls.Add(Me.cbo_Type)
        Me.Controls.Add(Me.cbo_Freight)
        Me.Controls.Add(Me.cbo_Pay)
        Me.Controls.Add(Me.cbo_Service)
        Me.Controls.Add(Me.cbo_Loading)
        Me.Controls.Add(Me.txt_TotalWeight)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroPanel5)
        Me.Controls.Add(Me.MetroLabel20)
        Me.Controls.Add(Me.txt_SpeIns)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.txt_Commodity)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.dgv_Origin)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.dtp_pickuptime)
        Me.Controls.Add(Me.dtp_pickupdate)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lbl_PickupNo)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PickUpSched_Mod"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Modify Pickup Schedule"
        CType(Me.dgv_Origin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel5.ResumeLayout(False)
        CType(Me.dgv_Dimension, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel7.ResumeLayout(False)
        Me.MetroPanel11.ResumeLayout(False)
        Me.MetroPanel11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_PickupNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_pickupdate As DateTimePicker
    Friend WithEvents dtp_pickuptime As DateTimePicker
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_Origin As MetroFramework.Controls.MetroGrid
    Friend WithEvents sel As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewLinkColumn
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_Commodity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_SpeIns As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel5 As MetroFramework.Controls.MetroPanel
    Friend WithEvents dgv_Dimension As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_TotalWeight As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbo_Loading As ComboBox
    Friend WithEvents cbo_Service As ComboBox
    Friend WithEvents cbo_Pay As ComboBox
    Friend WithEvents cbo_Freight As ComboBox
    Friend WithEvents cbo_Type As ComboBox
    Friend WithEvents cbo_Origin As ComboBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel7 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel11 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_TotalQty As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_TotalVol As MetroFramework.Controls.MetroLabel
End Class
