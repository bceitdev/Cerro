<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Collection
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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.txt_ClientSearch = New MetroFramework.Controls.MetroTextBox()
        Me.dgv_bill = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lbl_BillingCount = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectionListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OldAccountReceivableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.cb_5wt = New MetroFramework.Controls.MetroCheckBox()
        Me.cb_2wt = New MetroFramework.Controls.MetroCheckBox()
        Me.dgv_track = New MetroFramework.Controls.MetroGrid()
        Me.lbl_TrackingNo = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.lbl_withhold = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel12 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.btn_set = New MetroFramework.Controls.MetroButton()
        Me.lbl_bal = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel9 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txt_payment = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_TotalDue = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel8 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel6 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel7 = New MetroFramework.Controls.MetroPanel()
        Me.pnl_cash = New MetroFramework.Controls.MetroPanel()
        Me.dtp_ch_colldate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.rb_dirdep = New MetroFramework.Controls.MetroRadioButton()
        Me.rb_cash = New MetroFramework.Controls.MetroRadioButton()
        Me.rb_check = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.pnl_check = New MetroFramework.Controls.MetroPanel()
        Me.dtp_ck_colldate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.dtp_ck_checkdate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.cbo_ck_bank = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txt_ck_check = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txt_ck_orno = New MetroFramework.Controls.MetroTextBox()
        Me.pnl_dirdep = New MetroFramework.Controls.MetroPanel()
        Me.dtp_dd_depdate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.cbo_dd_bank = New MetroFramework.Controls.MetroComboBox()
        Me.MetroPanel10 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel11 = New MetroFramework.Controls.MetroPanel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.btn_Close = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.dgv_bill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.dgv_track, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel3.SuspendLayout()
        Me.MetroPanel7.SuspendLayout()
        Me.pnl_cash.SuspendLayout()
        Me.pnl_check.SuspendLayout()
        Me.pnl_dirdep.SuspendLayout()
        Me.MetroPanel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.txt_ClientSearch)
        Me.MetroPanel1.Controls.Add(Me.dgv_bill)
        Me.MetroPanel1.Controls.Add(Me.lbl_BillingCount)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.MenuStrip1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(202, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(665, 265)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'txt_ClientSearch
        '
        Me.txt_ClientSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_ClientSearch.CustomButton.Image = Nothing
        Me.txt_ClientSearch.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txt_ClientSearch.CustomButton.Name = ""
        Me.txt_ClientSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_ClientSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_ClientSearch.CustomButton.TabIndex = 1
        Me.txt_ClientSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_ClientSearch.CustomButton.UseSelectable = True
        Me.txt_ClientSearch.CustomButton.Visible = False
        Me.txt_ClientSearch.Lines = New String(-1) {}
        Me.txt_ClientSearch.Location = New System.Drawing.Point(496, 60)
        Me.txt_ClientSearch.MaxLength = 32767
        Me.txt_ClientSearch.Name = "txt_ClientSearch"
        Me.txt_ClientSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ClientSearch.PromptText = "Search here"
        Me.txt_ClientSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ClientSearch.SelectedText = ""
        Me.txt_ClientSearch.SelectionLength = 0
        Me.txt_ClientSearch.SelectionStart = 0
        Me.txt_ClientSearch.ShortcutsEnabled = True
        Me.txt_ClientSearch.Size = New System.Drawing.Size(162, 23)
        Me.txt_ClientSearch.TabIndex = 139
        Me.txt_ClientSearch.UseSelectable = True
        Me.txt_ClientSearch.WaterMark = "Search here"
        Me.txt_ClientSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ClientSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dgv_bill
        '
        Me.dgv_bill.AllowUserToAddRows = False
        Me.dgv_bill.AllowUserToDeleteRows = False
        Me.dgv_bill.AllowUserToResizeRows = False
        Me.dgv_bill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_bill.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_bill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_bill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_bill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_bill.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_bill.EnableHeadersVisualStyles = False
        Me.dgv_bill.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_bill.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_bill.Location = New System.Drawing.Point(0, 89)
        Me.dgv_bill.Name = "dgv_bill"
        Me.dgv_bill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_bill.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_bill.RowHeadersWidth = 35
        Me.dgv_bill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_bill.Size = New System.Drawing.Size(663, 174)
        Me.dgv_bill.TabIndex = 138
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 5
        '
        'lbl_BillingCount
        '
        Me.lbl_BillingCount.BackColor = System.Drawing.Color.White
        Me.lbl_BillingCount.ForeColor = System.Drawing.Color.Red
        Me.lbl_BillingCount.Location = New System.Drawing.Point(4, 64)
        Me.lbl_BillingCount.Name = "lbl_BillingCount"
        Me.lbl_BillingCount.Size = New System.Drawing.Size(41, 19)
        Me.lbl_BillingCount.TabIndex = 132
        Me.lbl_BillingCount.Text = "0"
        Me.lbl_BillingCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_BillingCount.UseCustomBackColor = True
        Me.lbl_BillingCount.UseCustomForeColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(51, 64)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(178, 19)
        Me.MetroLabel1.TabIndex = 131
        Me.MetroLabel1.Text = "account subject for collection"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.White
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(5, 32)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(164, 25)
        Me.MetroLabel2.TabIndex = 130
        Me.MetroLabel2.Text = "Account Receivable"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(663, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CollectionListToolStripMenuItem, Me.OldAccountReceivableToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'CollectionListToolStripMenuItem
        '
        Me.CollectionListToolStripMenuItem.Name = "CollectionListToolStripMenuItem"
        Me.CollectionListToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CollectionListToolStripMenuItem.Text = "Collection List"
        '
        'OldAccountReceivableToolStripMenuItem
        '
        Me.OldAccountReceivableToolStripMenuItem.CheckOnClick = True
        Me.OldAccountReceivableToolStripMenuItem.Name = "OldAccountReceivableToolStripMenuItem"
        Me.OldAccountReceivableToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.OldAccountReceivableToolStripMenuItem.Text = "Enable Old AR"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.cb_5wt)
        Me.MetroPanel2.Controls.Add(Me.cb_2wt)
        Me.MetroPanel2.Controls.Add(Me.dgv_track)
        Me.MetroPanel2.Controls.Add(Me.lbl_TrackingNo)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(202, 332)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(665, 206)
        Me.MetroPanel2.TabIndex = 1
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'cb_5wt
        '
        Me.cb_5wt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_5wt.AutoSize = True
        Me.cb_5wt.Location = New System.Drawing.Point(598, 19)
        Me.cb_5wt.Name = "cb_5wt"
        Me.cb_5wt.Size = New System.Drawing.Size(60, 15)
        Me.cb_5wt.TabIndex = 141
        Me.cb_5wt.Text = "5% WT"
        Me.cb_5wt.UseSelectable = True
        '
        'cb_2wt
        '
        Me.cb_2wt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_2wt.AutoSize = True
        Me.cb_2wt.Location = New System.Drawing.Point(598, 38)
        Me.cb_2wt.Name = "cb_2wt"
        Me.cb_2wt.Size = New System.Drawing.Size(60, 15)
        Me.cb_2wt.TabIndex = 140
        Me.cb_2wt.Text = "2% WT"
        Me.cb_2wt.UseSelectable = True
        '
        'dgv_track
        '
        Me.dgv_track.AllowUserToAddRows = False
        Me.dgv_track.AllowUserToDeleteRows = False
        Me.dgv_track.AllowUserToResizeRows = False
        Me.dgv_track.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_track.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_track.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_track.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_track.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_track.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_track.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_track.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_track.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_track.EnableHeadersVisualStyles = False
        Me.dgv_track.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_track.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_track.Location = New System.Drawing.Point(0, 59)
        Me.dgv_track.Name = "dgv_track"
        Me.dgv_track.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_track.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_track.RowHeadersWidth = 35
        Me.dgv_track.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_track.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_track.Size = New System.Drawing.Size(663, 145)
        Me.dgv_track.TabIndex = 139
        '
        'lbl_TrackingNo
        '
        Me.lbl_TrackingNo.BackColor = System.Drawing.Color.White
        Me.lbl_TrackingNo.ForeColor = System.Drawing.Color.Red
        Me.lbl_TrackingNo.Location = New System.Drawing.Point(4, 34)
        Me.lbl_TrackingNo.Name = "lbl_TrackingNo"
        Me.lbl_TrackingNo.Size = New System.Drawing.Size(41, 19)
        Me.lbl_TrackingNo.TabIndex = 134
        Me.lbl_TrackingNo.Text = "0"
        Me.lbl_TrackingNo.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_TrackingNo.UseCustomBackColor = True
        Me.lbl_TrackingNo.UseCustomForeColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.White
        Me.MetroLabel5.Location = New System.Drawing.Point(51, 34)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(201, 19)
        Me.MetroLabel5.TabIndex = 133
        Me.MetroLabel5.Text = "tracking no. subject for collection"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.White
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(5, 2)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(109, 25)
        Me.MetroLabel3.TabIndex = 131
        Me.MetroLabel3.Text = "Tracking No."
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel3.Controls.Add(Me.lbl_withhold)
        Me.MetroPanel3.Controls.Add(Me.MetroPanel12)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel19)
        Me.MetroPanel3.Controls.Add(Me.btn_set)
        Me.MetroPanel3.Controls.Add(Me.lbl_bal)
        Me.MetroPanel3.Controls.Add(Me.MetroPanel9)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel3.Controls.Add(Me.txt_payment)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel3.Controls.Add(Me.lbl_TotalDue)
        Me.MetroPanel3.Controls.Add(Me.MetroPanel8)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(175, 478)
        Me.MetroPanel3.TabIndex = 2
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'lbl_withhold
        '
        Me.lbl_withhold.BackColor = System.Drawing.Color.White
        Me.lbl_withhold.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_withhold.Location = New System.Drawing.Point(13, 202)
        Me.lbl_withhold.Name = "lbl_withhold"
        Me.lbl_withhold.Size = New System.Drawing.Size(152, 19)
        Me.lbl_withhold.TabIndex = 150
        Me.lbl_withhold.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_withhold.UseCustomBackColor = True
        '
        'MetroPanel12
        '
        Me.MetroPanel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel12.HorizontalScrollbarBarColor = True
        Me.MetroPanel12.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel12.HorizontalScrollbarSize = 10
        Me.MetroPanel12.Location = New System.Drawing.Point(13, 224)
        Me.MetroPanel12.Name = "MetroPanel12"
        Me.MetroPanel12.Size = New System.Drawing.Size(152, 1)
        Me.MetroPanel12.TabIndex = 149
        Me.MetroPanel12.VerticalScrollbarBarColor = True
        Me.MetroPanel12.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel12.VerticalScrollbarSize = 10
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.BackColor = System.Drawing.Color.White
        Me.MetroLabel19.Location = New System.Drawing.Point(7, 174)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(136, 19)
        Me.MetroLabel19.TabIndex = 148
        Me.MetroLabel19.Text = "Total Withholding Tax:"
        Me.MetroLabel19.UseCustomBackColor = True
        '
        'btn_set
        '
        Me.btn_set.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_set.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_set.Location = New System.Drawing.Point(115, 304)
        Me.btn_set.Name = "btn_set"
        Me.btn_set.Size = New System.Drawing.Size(50, 31)
        Me.btn_set.TabIndex = 147
        Me.btn_set.Text = "Set"
        Me.btn_set.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_set.UseSelectable = True
        '
        'lbl_bal
        '
        Me.lbl_bal.BackColor = System.Drawing.Color.White
        Me.lbl_bal.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_bal.Location = New System.Drawing.Point(12, 273)
        Me.lbl_bal.Name = "lbl_bal"
        Me.lbl_bal.Size = New System.Drawing.Size(152, 19)
        Me.lbl_bal.TabIndex = 146
        Me.lbl_bal.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_bal.UseCustomBackColor = True
        '
        'MetroPanel9
        '
        Me.MetroPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel9.HorizontalScrollbarBarColor = True
        Me.MetroPanel9.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel9.HorizontalScrollbarSize = 10
        Me.MetroPanel9.Location = New System.Drawing.Point(12, 295)
        Me.MetroPanel9.Name = "MetroPanel9"
        Me.MetroPanel9.Size = New System.Drawing.Size(152, 1)
        Me.MetroPanel9.TabIndex = 145
        Me.MetroPanel9.VerticalScrollbarBarColor = True
        Me.MetroPanel9.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel9.VerticalScrollbarSize = 10
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.White
        Me.MetroLabel11.Location = New System.Drawing.Point(11, 245)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel11.TabIndex = 144
        Me.MetroLabel11.Text = "Outstanding Balance:"
        Me.MetroLabel11.UseCustomBackColor = True
        '
        'txt_payment
        '
        Me.txt_payment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_payment.CustomButton.Image = Nothing
        Me.txt_payment.CustomButton.Location = New System.Drawing.Point(130, 1)
        Me.txt_payment.CustomButton.Name = ""
        Me.txt_payment.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_payment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_payment.CustomButton.TabIndex = 1
        Me.txt_payment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_payment.CustomButton.UseSelectable = True
        Me.txt_payment.CustomButton.Visible = False
        Me.txt_payment.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_payment.Lines = New String(-1) {}
        Me.txt_payment.Location = New System.Drawing.Point(11, 66)
        Me.txt_payment.MaxLength = 32767
        Me.txt_payment.Name = "txt_payment"
        Me.txt_payment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_payment.PromptText = "Input collection here"
        Me.txt_payment.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_payment.SelectedText = ""
        Me.txt_payment.SelectionLength = 0
        Me.txt_payment.SelectionStart = 0
        Me.txt_payment.ShortcutsEnabled = True
        Me.txt_payment.Size = New System.Drawing.Size(152, 23)
        Me.txt_payment.TabIndex = 143
        Me.txt_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_payment.UseSelectable = True
        Me.txt_payment.WaterMark = "Input collection here"
        Me.txt_payment.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_payment.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.White
        Me.MetroLabel8.Location = New System.Drawing.Point(7, 44)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(121, 19)
        Me.MetroLabel8.TabIndex = 142
        Me.MetroLabel8.Text = "Collection Amount:"
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'lbl_TotalDue
        '
        Me.lbl_TotalDue.BackColor = System.Drawing.Color.White
        Me.lbl_TotalDue.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_TotalDue.Location = New System.Drawing.Point(13, 132)
        Me.lbl_TotalDue.Name = "lbl_TotalDue"
        Me.lbl_TotalDue.Size = New System.Drawing.Size(152, 19)
        Me.lbl_TotalDue.TabIndex = 141
        Me.lbl_TotalDue.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_TotalDue.UseCustomBackColor = True
        '
        'MetroPanel8
        '
        Me.MetroPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel8.HorizontalScrollbarBarColor = True
        Me.MetroPanel8.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel8.HorizontalScrollbarSize = 10
        Me.MetroPanel8.Location = New System.Drawing.Point(13, 154)
        Me.MetroPanel8.Name = "MetroPanel8"
        Me.MetroPanel8.Size = New System.Drawing.Size(152, 1)
        Me.MetroPanel8.TabIndex = 140
        Me.MetroPanel8.VerticalScrollbarBarColor = True
        Me.MetroPanel8.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel8.VerticalScrollbarSize = 10
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.White
        Me.MetroLabel7.Location = New System.Drawing.Point(7, 104)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel7.TabIndex = 132
        Me.MetroLabel7.Text = "Total Due:"
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.White
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(4, 4)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(77, 25)
        Me.MetroLabel6.TabIndex = 131
        Me.MetroLabel6.Text = "Amount"
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(202, 325)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(665, 7)
        Me.MetroPanel4.TabIndex = 3
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(867, 60)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(7, 478)
        Me.MetroPanel5.TabIndex = 4
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'MetroPanel6
        '
        Me.MetroPanel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel6.HorizontalScrollbarBarColor = True
        Me.MetroPanel6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.HorizontalScrollbarSize = 10
        Me.MetroPanel6.Location = New System.Drawing.Point(195, 60)
        Me.MetroPanel6.Name = "MetroPanel6"
        Me.MetroPanel6.Size = New System.Drawing.Size(7, 478)
        Me.MetroPanel6.TabIndex = 5
        Me.MetroPanel6.VerticalScrollbarBarColor = True
        Me.MetroPanel6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.VerticalScrollbarSize = 10
        '
        'MetroPanel7
        '
        Me.MetroPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel7.Controls.Add(Me.pnl_cash)
        Me.MetroPanel7.Controls.Add(Me.rb_dirdep)
        Me.MetroPanel7.Controls.Add(Me.rb_cash)
        Me.MetroPanel7.Controls.Add(Me.rb_check)
        Me.MetroPanel7.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel7.Controls.Add(Me.pnl_check)
        Me.MetroPanel7.Controls.Add(Me.pnl_dirdep)
        Me.MetroPanel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroPanel7.HorizontalScrollbarBarColor = True
        Me.MetroPanel7.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel7.HorizontalScrollbarSize = 10
        Me.MetroPanel7.Location = New System.Drawing.Point(874, 60)
        Me.MetroPanel7.Name = "MetroPanel7"
        Me.MetroPanel7.Size = New System.Drawing.Size(175, 478)
        Me.MetroPanel7.TabIndex = 6
        Me.MetroPanel7.VerticalScrollbarBarColor = True
        Me.MetroPanel7.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel7.VerticalScrollbarSize = 10
        '
        'pnl_cash
        '
        Me.pnl_cash.Controls.Add(Me.dtp_ch_colldate)
        Me.pnl_cash.Controls.Add(Me.MetroLabel15)
        Me.pnl_cash.HorizontalScrollbarBarColor = True
        Me.pnl_cash.HorizontalScrollbarHighlightOnWheel = False
        Me.pnl_cash.HorizontalScrollbarSize = 10
        Me.pnl_cash.Location = New System.Drawing.Point(-1, 104)
        Me.pnl_cash.Name = "pnl_cash"
        Me.pnl_cash.Size = New System.Drawing.Size(175, 76)
        Me.pnl_cash.TabIndex = 140
        Me.pnl_cash.VerticalScrollbarBarColor = True
        Me.pnl_cash.VerticalScrollbarHighlightOnWheel = False
        Me.pnl_cash.VerticalScrollbarSize = 10
        Me.pnl_cash.Visible = False
        '
        'dtp_ch_colldate
        '
        Me.dtp_ch_colldate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ch_colldate.Location = New System.Drawing.Point(12, 35)
        Me.dtp_ch_colldate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_ch_colldate.Name = "dtp_ch_colldate"
        Me.dtp_ch_colldate.Size = New System.Drawing.Size(152, 29)
        Me.dtp_ch_colldate.TabIndex = 150
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.BackColor = System.Drawing.Color.White
        Me.MetroLabel15.Location = New System.Drawing.Point(7, 13)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel15.TabIndex = 149
        Me.MetroLabel15.Text = "Collection Date:"
        Me.MetroLabel15.UseCustomBackColor = True
        '
        'rb_dirdep
        '
        Me.rb_dirdep.AutoSize = True
        Me.rb_dirdep.Location = New System.Drawing.Point(12, 79)
        Me.rb_dirdep.Name = "rb_dirdep"
        Me.rb_dirdep.Size = New System.Drawing.Size(97, 15)
        Me.rb_dirdep.TabIndex = 142
        Me.rb_dirdep.Text = "Direct Deposit"
        Me.rb_dirdep.UseSelectable = True
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Location = New System.Drawing.Point(11, 37)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(49, 15)
        Me.rb_cash.TabIndex = 140
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseSelectable = True
        '
        'rb_check
        '
        Me.rb_check.AutoSize = True
        Me.rb_check.Location = New System.Drawing.Point(12, 58)
        Me.rb_check.Name = "rb_check"
        Me.rb_check.Size = New System.Drawing.Size(56, 15)
        Me.rb_check.TabIndex = 141
        Me.rb_check.Text = "Check"
        Me.rb_check.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.White
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(4, 4)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(91, 25)
        Me.MetroLabel4.TabIndex = 131
        Me.MetroLabel4.Text = "Pay Mode"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'pnl_check
        '
        Me.pnl_check.Controls.Add(Me.dtp_ck_colldate)
        Me.pnl_check.Controls.Add(Me.MetroLabel13)
        Me.pnl_check.Controls.Add(Me.MetroLabel10)
        Me.pnl_check.Controls.Add(Me.dtp_ck_checkdate)
        Me.pnl_check.Controls.Add(Me.MetroLabel9)
        Me.pnl_check.Controls.Add(Me.cbo_ck_bank)
        Me.pnl_check.Controls.Add(Me.MetroLabel12)
        Me.pnl_check.Controls.Add(Me.txt_ck_check)
        Me.pnl_check.Controls.Add(Me.MetroLabel14)
        Me.pnl_check.Controls.Add(Me.txt_ck_orno)
        Me.pnl_check.HorizontalScrollbarBarColor = True
        Me.pnl_check.HorizontalScrollbarHighlightOnWheel = False
        Me.pnl_check.HorizontalScrollbarSize = 10
        Me.pnl_check.Location = New System.Drawing.Point(-1, 104)
        Me.pnl_check.Name = "pnl_check"
        Me.pnl_check.Size = New System.Drawing.Size(175, 372)
        Me.pnl_check.TabIndex = 140
        Me.pnl_check.VerticalScrollbarBarColor = True
        Me.pnl_check.VerticalScrollbarHighlightOnWheel = False
        Me.pnl_check.VerticalScrollbarSize = 10
        Me.pnl_check.Visible = False
        '
        'dtp_ck_colldate
        '
        Me.dtp_ck_colldate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ck_colldate.Location = New System.Drawing.Point(12, 35)
        Me.dtp_ck_colldate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtp_ck_colldate.Name = "dtp_ck_colldate"
        Me.dtp_ck_colldate.Size = New System.Drawing.Size(152, 29)
        Me.dtp_ck_colldate.TabIndex = 148
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.BackColor = System.Drawing.Color.White
        Me.MetroLabel13.Location = New System.Drawing.Point(7, 13)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel13.TabIndex = 147
        Me.MetroLabel13.Text = "Collection Date:"
        Me.MetroLabel13.UseCustomBackColor = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.White
        Me.MetroLabel10.Location = New System.Drawing.Point(8, 85)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel10.TabIndex = 145
        Me.MetroLabel10.Text = "Check Date:"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'dtp_ck_checkdate
        '
        Me.dtp_ck_checkdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ck_checkdate.Location = New System.Drawing.Point(13, 107)
        Me.dtp_ck_checkdate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_ck_checkdate.Name = "dtp_ck_checkdate"
        Me.dtp_ck_checkdate.Size = New System.Drawing.Size(152, 29)
        Me.dtp_ck_checkdate.TabIndex = 146
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.BackColor = System.Drawing.Color.White
        Me.MetroLabel9.Location = New System.Drawing.Point(8, 160)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel9.TabIndex = 133
        Me.MetroLabel9.Text = "Bank:"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'cbo_ck_bank
        '
        Me.cbo_ck_bank.FormattingEnabled = True
        Me.cbo_ck_bank.ItemHeight = 23
        Me.cbo_ck_bank.Location = New System.Drawing.Point(14, 182)
        Me.cbo_ck_bank.Name = "cbo_ck_bank"
        Me.cbo_ck_bank.Size = New System.Drawing.Size(152, 29)
        Me.cbo_ck_bank.TabIndex = 134
        Me.cbo_ck_bank.UseSelectable = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.BackColor = System.Drawing.Color.White
        Me.MetroLabel12.Location = New System.Drawing.Point(8, 233)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel12.TabIndex = 135
        Me.MetroLabel12.Text = "Check No.:"
        Me.MetroLabel12.UseCustomBackColor = True
        '
        'txt_ck_check
        '
        Me.txt_ck_check.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_ck_check.CustomButton.Image = Nothing
        Me.txt_ck_check.CustomButton.Location = New System.Drawing.Point(130, 1)
        Me.txt_ck_check.CustomButton.Name = ""
        Me.txt_ck_check.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_ck_check.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_ck_check.CustomButton.TabIndex = 1
        Me.txt_ck_check.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_ck_check.CustomButton.UseSelectable = True
        Me.txt_ck_check.CustomButton.Visible = False
        Me.txt_ck_check.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_ck_check.Lines = New String(-1) {}
        Me.txt_ck_check.Location = New System.Drawing.Point(13, 255)
        Me.txt_ck_check.MaxLength = 32767
        Me.txt_ck_check.Name = "txt_ck_check"
        Me.txt_ck_check.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ck_check.PromptText = "Input check here"
        Me.txt_ck_check.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ck_check.SelectedText = ""
        Me.txt_ck_check.SelectionLength = 0
        Me.txt_ck_check.SelectionStart = 0
        Me.txt_ck_check.ShortcutsEnabled = True
        Me.txt_ck_check.Size = New System.Drawing.Size(152, 23)
        Me.txt_ck_check.TabIndex = 144
        Me.txt_ck_check.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_ck_check.UseSelectable = True
        Me.txt_ck_check.WaterMark = "Input check here"
        Me.txt_ck_check.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ck_check.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.BackColor = System.Drawing.Color.White
        Me.MetroLabel14.Location = New System.Drawing.Point(8, 301)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel14.TabIndex = 149
        Me.MetroLabel14.Text = "OR No.:"
        Me.MetroLabel14.UseCustomBackColor = True
        '
        'txt_ck_orno
        '
        Me.txt_ck_orno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_ck_orno.CustomButton.Image = Nothing
        Me.txt_ck_orno.CustomButton.Location = New System.Drawing.Point(130, 1)
        Me.txt_ck_orno.CustomButton.Name = ""
        Me.txt_ck_orno.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_ck_orno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_ck_orno.CustomButton.TabIndex = 1
        Me.txt_ck_orno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_ck_orno.CustomButton.UseSelectable = True
        Me.txt_ck_orno.CustomButton.Visible = False
        Me.txt_ck_orno.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_ck_orno.Lines = New String(-1) {}
        Me.txt_ck_orno.Location = New System.Drawing.Point(13, 323)
        Me.txt_ck_orno.MaxLength = 32767
        Me.txt_ck_orno.Name = "txt_ck_orno"
        Me.txt_ck_orno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ck_orno.PromptText = "Input OR here"
        Me.txt_ck_orno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ck_orno.SelectedText = ""
        Me.txt_ck_orno.SelectionLength = 0
        Me.txt_ck_orno.SelectionStart = 0
        Me.txt_ck_orno.ShortcutsEnabled = True
        Me.txt_ck_orno.Size = New System.Drawing.Size(152, 23)
        Me.txt_ck_orno.TabIndex = 150
        Me.txt_ck_orno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_ck_orno.UseSelectable = True
        Me.txt_ck_orno.WaterMark = "Input OR here"
        Me.txt_ck_orno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ck_orno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pnl_dirdep
        '
        Me.pnl_dirdep.Controls.Add(Me.dtp_dd_depdate)
        Me.pnl_dirdep.Controls.Add(Me.MetroLabel16)
        Me.pnl_dirdep.Controls.Add(Me.MetroLabel18)
        Me.pnl_dirdep.Controls.Add(Me.cbo_dd_bank)
        Me.pnl_dirdep.HorizontalScrollbarBarColor = True
        Me.pnl_dirdep.HorizontalScrollbarHighlightOnWheel = False
        Me.pnl_dirdep.HorizontalScrollbarSize = 10
        Me.pnl_dirdep.Location = New System.Drawing.Point(-1, 104)
        Me.pnl_dirdep.Name = "pnl_dirdep"
        Me.pnl_dirdep.Size = New System.Drawing.Size(175, 372)
        Me.pnl_dirdep.TabIndex = 147
        Me.pnl_dirdep.VerticalScrollbarBarColor = True
        Me.pnl_dirdep.VerticalScrollbarHighlightOnWheel = False
        Me.pnl_dirdep.VerticalScrollbarSize = 10
        Me.pnl_dirdep.Visible = False
        '
        'dtp_dd_depdate
        '
        Me.dtp_dd_depdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dd_depdate.Location = New System.Drawing.Point(12, 35)
        Me.dtp_dd_depdate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtp_dd_depdate.Name = "dtp_dd_depdate"
        Me.dtp_dd_depdate.Size = New System.Drawing.Size(152, 29)
        Me.dtp_dd_depdate.TabIndex = 148
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.BackColor = System.Drawing.Color.White
        Me.MetroLabel16.Location = New System.Drawing.Point(7, 13)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel16.TabIndex = 147
        Me.MetroLabel16.Text = "Deposit Date:"
        Me.MetroLabel16.UseCustomBackColor = True
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.BackColor = System.Drawing.Color.White
        Me.MetroLabel18.Location = New System.Drawing.Point(8, 85)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel18.TabIndex = 133
        Me.MetroLabel18.Text = "Bank:"
        Me.MetroLabel18.UseCustomBackColor = True
        '
        'cbo_dd_bank
        '
        Me.cbo_dd_bank.FormattingEnabled = True
        Me.cbo_dd_bank.ItemHeight = 23
        Me.cbo_dd_bank.Location = New System.Drawing.Point(14, 107)
        Me.cbo_dd_bank.Name = "cbo_dd_bank"
        Me.cbo_dd_bank.Size = New System.Drawing.Size(152, 29)
        Me.cbo_dd_bank.TabIndex = 134
        Me.cbo_dd_bank.UseSelectable = True
        '
        'MetroPanel10
        '
        Me.MetroPanel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel10.HorizontalScrollbarBarColor = True
        Me.MetroPanel10.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel10.HorizontalScrollbarSize = 10
        Me.MetroPanel10.Location = New System.Drawing.Point(20, 538)
        Me.MetroPanel10.Name = "MetroPanel10"
        Me.MetroPanel10.Size = New System.Drawing.Size(1029, 7)
        Me.MetroPanel10.TabIndex = 7
        Me.MetroPanel10.VerticalScrollbarBarColor = True
        Me.MetroPanel10.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel10.VerticalScrollbarSize = 10
        '
        'MetroPanel11
        '
        Me.MetroPanel11.Controls.Add(Me.btn_Submit)
        Me.MetroPanel11.Controls.Add(Me.btn_Close)
        Me.MetroPanel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel11.HorizontalScrollbarBarColor = True
        Me.MetroPanel11.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel11.HorizontalScrollbarSize = 10
        Me.MetroPanel11.Location = New System.Drawing.Point(20, 545)
        Me.MetroPanel11.Name = "MetroPanel11"
        Me.MetroPanel11.Size = New System.Drawing.Size(1029, 31)
        Me.MetroPanel11.TabIndex = 65
        Me.MetroPanel11.VerticalScrollbarBarColor = True
        Me.MetroPanel11.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel11.VerticalScrollbarSize = 10
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(789, 0)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(120, 31)
        Me.btn_Submit.TabIndex = 40
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'btn_Close
        '
        Me.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Close.Location = New System.Drawing.Point(909, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(120, 31)
        Me.btn_Close.TabIndex = 41
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseSelectable = True
        '
        'Collection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel4)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroPanel6)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.MetroPanel5)
        Me.Controls.Add(Me.MetroPanel7)
        Me.Controls.Add(Me.MetroPanel10)
        Me.Controls.Add(Me.MetroPanel11)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Collection"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Collection"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.dgv_bill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.dgv_track, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.MetroPanel7.ResumeLayout(False)
        Me.MetroPanel7.PerformLayout()
        Me.pnl_cash.ResumeLayout(False)
        Me.pnl_cash.PerformLayout()
        Me.pnl_check.ResumeLayout(False)
        Me.pnl_check.PerformLayout()
        Me.pnl_dirdep.ResumeLayout(False)
        Me.pnl_dirdep.PerformLayout()
        Me.MetroPanel11.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel5 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_BillingCount As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_bill As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_track As MetroFramework.Controls.MetroGrid
    Friend WithEvents lbl_TrackingNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel6 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel7 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_ClientSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel8 As MetroFramework.Controls.MetroPanel
    Friend WithEvents lbl_TotalDue As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_payment As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_bal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel9 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_ck_check As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_ck_bank As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroPanel10 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel11 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_ck_checkdate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btn_Close As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_ck_orno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_ck_colldate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents rb_dirdep As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rb_cash As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rb_check As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents pnl_check As MetroFramework.Controls.MetroPanel
    Friend WithEvents pnl_cash As MetroFramework.Controls.MetroPanel
    Friend WithEvents dtp_ch_colldate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnl_dirdep As MetroFramework.Controls.MetroPanel
    Friend WithEvents dtp_dd_depdate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_dd_bank As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents btn_set As MetroFramework.Controls.MetroButton
    Friend WithEvents cb_2wt As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lbl_withhold As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel12 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cb_5wt As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollectionListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OldAccountReceivableToolStripMenuItem As ToolStripMenuItem
End Class
