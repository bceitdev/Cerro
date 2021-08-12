<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.pnl_Setting = New MetroFramework.Controls.MetroPanel()
        Me.btn_unbilled = New System.Windows.Forms.Button()
        Me.btn_CanBillList = New System.Windows.Forms.Button()
        Me.btn_RevBillList = New System.Windows.Forms.Button()
        Me.btn_StaApp = New System.Windows.Forms.Button()
        Me.btn_TrackingList = New System.Windows.Forms.Button()
        Me.btn_BillingList = New System.Windows.Forms.Button()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.btn_Next = New MetroFramework.Controls.MetroButton()
        Me.dgv_ClientList = New MetroFramework.Controls.MetroGrid()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txt_ClientSearch = New MetroFramework.Controls.MetroTextBox()
        Me.lbl_ClientCount = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel9 = New MetroFramework.Controls.MetroPanel()
        Me.btn_Next1 = New MetroFramework.Controls.MetroButton()
        Me.btn_Back = New MetroFramework.Controls.MetroButton()
        Me.lbl_Balance = New MetroFramework.Controls.MetroLabel()
        Me.lbl_BillingDate = New MetroFramework.Controls.MetroLabel()
        Me.lbl_ControlNo = New MetroFramework.Controls.MetroLabel()
        Me.txt_BillingSearch = New MetroFramework.Controls.MetroTextBox()
        Me.dgv_BillingList = New MetroFramework.Controls.MetroGrid()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lbl_BillingCount = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.btn_Done = New MetroFramework.Controls.MetroButton()
        Me.btn_Back1 = New MetroFramework.Controls.MetroButton()
        Me.crv_SOA = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MetroPanel17 = New MetroFramework.Controls.MetroPanel()
        Me.mt_Setting = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.pnl_Setting.SuspendLayout()
        Me.MetroPanel5.SuspendLayout()
        CType(Me.dgv_ClientList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroPanel9.SuspendLayout()
        CType(Me.dgv_BillingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(200, 100)
        Me.MetroTabPage4.TabIndex = 0
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(1029, 516)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.pnl_Setting)
        Me.MetroTabPage1.Controls.Add(Me.MetroPanel5)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1021, 474)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "[1] Client Information >"
        Me.MetroTabPage1.UseStyleColors = True
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'pnl_Setting
        '
        Me.pnl_Setting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_Setting.Controls.Add(Me.btn_unbilled)
        Me.pnl_Setting.Controls.Add(Me.btn_CanBillList)
        Me.pnl_Setting.Controls.Add(Me.btn_RevBillList)
        Me.pnl_Setting.Controls.Add(Me.btn_StaApp)
        Me.pnl_Setting.Controls.Add(Me.btn_TrackingList)
        Me.pnl_Setting.Controls.Add(Me.btn_BillingList)
        Me.pnl_Setting.HorizontalScrollbarBarColor = True
        Me.pnl_Setting.HorizontalScrollbarHighlightOnWheel = False
        Me.pnl_Setting.HorizontalScrollbarSize = 10
        Me.pnl_Setting.Location = New System.Drawing.Point(890, -1)
        Me.pnl_Setting.Name = "pnl_Setting"
        Me.pnl_Setting.Size = New System.Drawing.Size(131, 0)
        Me.pnl_Setting.TabIndex = 15
        Me.pnl_Setting.VerticalScrollbarBarColor = True
        Me.pnl_Setting.VerticalScrollbarHighlightOnWheel = False
        Me.pnl_Setting.VerticalScrollbarSize = 10
        '
        'btn_unbilled
        '
        Me.btn_unbilled.BackColor = System.Drawing.Color.Transparent
        Me.btn_unbilled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_unbilled.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_unbilled.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_unbilled.FlatAppearance.BorderSize = 0
        Me.btn_unbilled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_unbilled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_unbilled.ForeColor = System.Drawing.Color.Black
        Me.btn_unbilled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_unbilled.Location = New System.Drawing.Point(0, 170)
        Me.btn_unbilled.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_unbilled.Name = "btn_unbilled"
        Me.btn_unbilled.Size = New System.Drawing.Size(131, 34)
        Me.btn_unbilled.TabIndex = 103
        Me.btn_unbilled.Text = "Billed/Unbilled List"
        Me.btn_unbilled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_unbilled.UseVisualStyleBackColor = False
        '
        'btn_CanBillList
        '
        Me.btn_CanBillList.BackColor = System.Drawing.Color.Transparent
        Me.btn_CanBillList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CanBillList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_CanBillList.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_CanBillList.FlatAppearance.BorderSize = 0
        Me.btn_CanBillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CanBillList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CanBillList.ForeColor = System.Drawing.Color.Black
        Me.btn_CanBillList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CanBillList.Location = New System.Drawing.Point(0, 136)
        Me.btn_CanBillList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_CanBillList.Name = "btn_CanBillList"
        Me.btn_CanBillList.Size = New System.Drawing.Size(131, 34)
        Me.btn_CanBillList.TabIndex = 102
        Me.btn_CanBillList.Text = "Cancelled Billing List"
        Me.btn_CanBillList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_CanBillList.UseVisualStyleBackColor = False
        '
        'btn_RevBillList
        '
        Me.btn_RevBillList.BackColor = System.Drawing.Color.Transparent
        Me.btn_RevBillList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_RevBillList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_RevBillList.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_RevBillList.FlatAppearance.BorderSize = 0
        Me.btn_RevBillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RevBillList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RevBillList.ForeColor = System.Drawing.Color.Black
        Me.btn_RevBillList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_RevBillList.Location = New System.Drawing.Point(0, 102)
        Me.btn_RevBillList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_RevBillList.Name = "btn_RevBillList"
        Me.btn_RevBillList.Size = New System.Drawing.Size(131, 34)
        Me.btn_RevBillList.TabIndex = 100
        Me.btn_RevBillList.Text = "Revised Billing List"
        Me.btn_RevBillList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_RevBillList.UseVisualStyleBackColor = False
        '
        'btn_StaApp
        '
        Me.btn_StaApp.BackColor = System.Drawing.Color.Transparent
        Me.btn_StaApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_StaApp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_StaApp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_StaApp.FlatAppearance.BorderSize = 0
        Me.btn_StaApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_StaApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_StaApp.ForeColor = System.Drawing.Color.Black
        Me.btn_StaApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_StaApp.Location = New System.Drawing.Point(0, 68)
        Me.btn_StaApp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_StaApp.Name = "btn_StaApp"
        Me.btn_StaApp.Size = New System.Drawing.Size(131, 34)
        Me.btn_StaApp.TabIndex = 99
        Me.btn_StaApp.Text = "Statement Approval"
        Me.btn_StaApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_StaApp.UseVisualStyleBackColor = False
        '
        'btn_TrackingList
        '
        Me.btn_TrackingList.BackColor = System.Drawing.Color.Transparent
        Me.btn_TrackingList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_TrackingList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_TrackingList.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_TrackingList.FlatAppearance.BorderSize = 0
        Me.btn_TrackingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TrackingList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TrackingList.ForeColor = System.Drawing.Color.Black
        Me.btn_TrackingList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_TrackingList.Location = New System.Drawing.Point(0, 34)
        Me.btn_TrackingList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_TrackingList.Name = "btn_TrackingList"
        Me.btn_TrackingList.Size = New System.Drawing.Size(131, 34)
        Me.btn_TrackingList.TabIndex = 101
        Me.btn_TrackingList.Text = "Tracking List"
        Me.btn_TrackingList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_TrackingList.UseVisualStyleBackColor = False
        '
        'btn_BillingList
        '
        Me.btn_BillingList.BackColor = System.Drawing.Color.Transparent
        Me.btn_BillingList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_BillingList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_BillingList.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_BillingList.FlatAppearance.BorderSize = 0
        Me.btn_BillingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BillingList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BillingList.ForeColor = System.Drawing.Color.Black
        Me.btn_BillingList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_BillingList.Location = New System.Drawing.Point(0, 0)
        Me.btn_BillingList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_BillingList.Name = "btn_BillingList"
        Me.btn_BillingList.Size = New System.Drawing.Size(131, 34)
        Me.btn_BillingList.TabIndex = 98
        Me.btn_BillingList.Text = "Billing List"
        Me.btn_BillingList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_BillingList.UseVisualStyleBackColor = False
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel5.Controls.Add(Me.btn_Next)
        Me.MetroPanel5.Controls.Add(Me.dgv_ClientList)
        Me.MetroPanel5.Controls.Add(Me.txt_ClientSearch)
        Me.MetroPanel5.Controls.Add(Me.lbl_ClientCount)
        Me.MetroPanel5.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(200, 10)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(621, 454)
        Me.MetroPanel5.TabIndex = 8
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'btn_Next
        '
        Me.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Next.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Next.Location = New System.Drawing.Point(0, 421)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(619, 31)
        Me.btn_Next.TabIndex = 11
        Me.btn_Next.Text = "Next"
        Me.btn_Next.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Next.UseSelectable = True
        '
        'dgv_ClientList
        '
        Me.dgv_ClientList.AllowUserToAddRows = False
        Me.dgv_ClientList.AllowUserToDeleteRows = False
        Me.dgv_ClientList.AllowUserToResizeRows = False
        Me.dgv_ClientList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_ClientList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_ClientList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_ClientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_ClientList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ClientList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ClientList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_ClientList.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_ClientList.EnableHeadersVisualStyles = False
        Me.dgv_ClientList.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_ClientList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_ClientList.Location = New System.Drawing.Point(0, 35)
        Me.dgv_ClientList.Name = "dgv_ClientList"
        Me.dgv_ClientList.ReadOnly = True
        Me.dgv_ClientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ClientList.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_ClientList.RowHeadersWidth = 35
        Me.dgv_ClientList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_ClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ClientList.Size = New System.Drawing.Size(619, 380)
        Me.dgv_ClientList.TabIndex = 137
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Select"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCheckBoxColumn2.Width = 41
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
        Me.txt_ClientSearch.Location = New System.Drawing.Point(451, 6)
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
        Me.txt_ClientSearch.TabIndex = 131
        Me.txt_ClientSearch.UseSelectable = True
        Me.txt_ClientSearch.WaterMark = "Search here"
        Me.txt_ClientSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ClientSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lbl_ClientCount
        '
        Me.lbl_ClientCount.BackColor = System.Drawing.Color.White
        Me.lbl_ClientCount.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_ClientCount.ForeColor = System.Drawing.Color.Red
        Me.lbl_ClientCount.Location = New System.Drawing.Point(3, 10)
        Me.lbl_ClientCount.Name = "lbl_ClientCount"
        Me.lbl_ClientCount.Size = New System.Drawing.Size(23, 19)
        Me.lbl_ClientCount.TabIndex = 130
        Me.lbl_ClientCount.Text = "0"
        Me.lbl_ClientCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_ClientCount.UseCustomBackColor = True
        Me.lbl_ClientCount.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.White
        Me.MetroLabel2.Location = New System.Drawing.Point(32, 10)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(158, 19)
        Me.MetroLabel2.TabIndex = 129
        Me.MetroLabel2.Text = "account subject for billing"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroPanel9)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1021, 474)
        Me.MetroTabPage2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "[2] Billing Information >"
        Me.MetroTabPage2.UseStyleColors = True
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroPanel9
        '
        Me.MetroPanel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel9.BackColor = System.Drawing.Color.White
        Me.MetroPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel9.Controls.Add(Me.btn_Next1)
        Me.MetroPanel9.Controls.Add(Me.btn_Back)
        Me.MetroPanel9.Controls.Add(Me.lbl_Balance)
        Me.MetroPanel9.Controls.Add(Me.lbl_BillingDate)
        Me.MetroPanel9.Controls.Add(Me.lbl_ControlNo)
        Me.MetroPanel9.Controls.Add(Me.txt_BillingSearch)
        Me.MetroPanel9.Controls.Add(Me.dgv_BillingList)
        Me.MetroPanel9.Controls.Add(Me.lbl_BillingCount)
        Me.MetroPanel9.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel9.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel9.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel9.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel9.HorizontalScrollbarBarColor = True
        Me.MetroPanel9.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel9.HorizontalScrollbarSize = 10
        Me.MetroPanel9.Location = New System.Drawing.Point(200, 10)
        Me.MetroPanel9.Name = "MetroPanel9"
        Me.MetroPanel9.Size = New System.Drawing.Size(621, 454)
        Me.MetroPanel9.TabIndex = 11
        Me.MetroPanel9.UseCustomBackColor = True
        Me.MetroPanel9.VerticalScrollbarBarColor = True
        Me.MetroPanel9.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel9.VerticalScrollbarSize = 10
        '
        'btn_Next1
        '
        Me.btn_Next1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Next1.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Next1.Location = New System.Drawing.Point(0, 390)
        Me.btn_Next1.Name = "btn_Next1"
        Me.btn_Next1.Size = New System.Drawing.Size(619, 31)
        Me.btn_Next1.TabIndex = 10
        Me.btn_Next1.Text = "Next"
        Me.btn_Next1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Next1.UseSelectable = True
        '
        'btn_Back
        '
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Back.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Back.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Back.Location = New System.Drawing.Point(0, 421)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(619, 31)
        Me.btn_Back.TabIndex = 41
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseSelectable = True
        '
        'lbl_Balance
        '
        Me.lbl_Balance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Balance.AutoSize = True
        Me.lbl_Balance.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_Balance.Location = New System.Drawing.Point(373, 15)
        Me.lbl_Balance.Name = "lbl_Balance"
        Me.lbl_Balance.Size = New System.Drawing.Size(75, 19)
        Me.lbl_Balance.TabIndex = 141
        Me.lbl_Balance.Text = "lbl_Balance"
        Me.lbl_Balance.UseCustomBackColor = True
        '
        'lbl_BillingDate
        '
        Me.lbl_BillingDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_BillingDate.AutoSize = True
        Me.lbl_BillingDate.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_BillingDate.Location = New System.Drawing.Point(112, 47)
        Me.lbl_BillingDate.Name = "lbl_BillingDate"
        Me.lbl_BillingDate.Size = New System.Drawing.Size(94, 19)
        Me.lbl_BillingDate.TabIndex = 140
        Me.lbl_BillingDate.Text = "lbl_BillingDate"
        Me.lbl_BillingDate.UseCustomBackColor = True
        '
        'lbl_ControlNo
        '
        Me.lbl_ControlNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ControlNo.AutoSize = True
        Me.lbl_ControlNo.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_ControlNo.ForeColor = System.Drawing.Color.Red
        Me.lbl_ControlNo.Location = New System.Drawing.Point(112, 15)
        Me.lbl_ControlNo.Name = "lbl_ControlNo"
        Me.lbl_ControlNo.Size = New System.Drawing.Size(93, 19)
        Me.lbl_ControlNo.TabIndex = 138
        Me.lbl_ControlNo.Text = "lbl_ControlNo"
        Me.lbl_ControlNo.UseCustomBackColor = True
        Me.lbl_ControlNo.UseCustomForeColor = True
        '
        'txt_BillingSearch
        '
        Me.txt_BillingSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_BillingSearch.CustomButton.Image = Nothing
        Me.txt_BillingSearch.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txt_BillingSearch.CustomButton.Name = ""
        Me.txt_BillingSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_BillingSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_BillingSearch.CustomButton.TabIndex = 1
        Me.txt_BillingSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_BillingSearch.CustomButton.UseSelectable = True
        Me.txt_BillingSearch.CustomButton.Visible = False
        Me.txt_BillingSearch.Lines = New String(-1) {}
        Me.txt_BillingSearch.Location = New System.Drawing.Point(454, 79)
        Me.txt_BillingSearch.MaxLength = 32767
        Me.txt_BillingSearch.Name = "txt_BillingSearch"
        Me.txt_BillingSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_BillingSearch.PromptText = "Search here"
        Me.txt_BillingSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_BillingSearch.SelectedText = ""
        Me.txt_BillingSearch.SelectionLength = 0
        Me.txt_BillingSearch.SelectionStart = 0
        Me.txt_BillingSearch.ShortcutsEnabled = True
        Me.txt_BillingSearch.Size = New System.Drawing.Size(162, 23)
        Me.txt_BillingSearch.TabIndex = 137
        Me.txt_BillingSearch.UseSelectable = True
        Me.txt_BillingSearch.WaterMark = "Search here"
        Me.txt_BillingSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_BillingSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dgv_BillingList
        '
        Me.dgv_BillingList.AllowUserToAddRows = False
        Me.dgv_BillingList.AllowUserToDeleteRows = False
        Me.dgv_BillingList.AllowUserToResizeRows = False
        Me.dgv_BillingList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_BillingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_BillingList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_BillingList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_BillingList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_BillingList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_BillingList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_BillingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_BillingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_BillingList.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_BillingList.EnableHeadersVisualStyles = False
        Me.dgv_BillingList.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_BillingList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_BillingList.Location = New System.Drawing.Point(1, 108)
        Me.dgv_BillingList.Name = "dgv_BillingList"
        Me.dgv_BillingList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_BillingList.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_BillingList.RowHeadersWidth = 35
        Me.dgv_BillingList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_BillingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_BillingList.Size = New System.Drawing.Size(619, 276)
        Me.dgv_BillingList.TabIndex = 136
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Select"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCheckBoxColumn1.Width = 41
        '
        'lbl_BillingCount
        '
        Me.lbl_BillingCount.AutoSize = True
        Me.lbl_BillingCount.BackColor = System.Drawing.Color.White
        Me.lbl_BillingCount.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_BillingCount.ForeColor = System.Drawing.Color.Black
        Me.lbl_BillingCount.Location = New System.Drawing.Point(370, 47)
        Me.lbl_BillingCount.Name = "lbl_BillingCount"
        Me.lbl_BillingCount.Size = New System.Drawing.Size(103, 19)
        Me.lbl_BillingCount.TabIndex = 135
        Me.lbl_BillingCount.Text = "lbl_BillingCount"
        Me.lbl_BillingCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_BillingCount.UseCustomBackColor = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(307, 47)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel10.TabIndex = 132
        Me.MetroLabel10.Text = "Unbilled:"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(25, 47)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel9.TabIndex = 131
        Me.MetroLabel9.Text = "Billing Date:"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(310, 15)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel8.TabIndex = 130
        Me.MetroLabel8.Text = "Balance:"
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(25, 15)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel5.TabIndex = 128
        Me.MetroLabel5.Text = "Control No.:"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.btn_Done)
        Me.MetroTabPage3.Controls.Add(Me.btn_Back1)
        Me.MetroTabPage3.Controls.Add(Me.crv_SOA)
        Me.MetroTabPage3.Controls.Add(Me.MetroPanel17)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(1021, 474)
        Me.MetroTabPage3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "[3] Billing Statement"
        Me.MetroTabPage3.UseStyleColors = True
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'btn_Done
        '
        Me.btn_Done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Done.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Done.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Done.Location = New System.Drawing.Point(0, 402)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(1021, 31)
        Me.btn_Done.TabIndex = 10
        Me.btn_Done.Text = "Generate"
        Me.btn_Done.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Done.UseSelectable = True
        '
        'btn_Back1
        '
        Me.btn_Back1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Back1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Back1.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Back1.Location = New System.Drawing.Point(0, 433)
        Me.btn_Back1.Name = "btn_Back1"
        Me.btn_Back1.Size = New System.Drawing.Size(1021, 31)
        Me.btn_Back1.TabIndex = 41
        Me.btn_Back1.Text = "Back"
        Me.btn_Back1.UseSelectable = True
        '
        'crv_SOA
        '
        Me.crv_SOA.ActiveViewIndex = -1
        Me.crv_SOA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crv_SOA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_SOA.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_SOA.Location = New System.Drawing.Point(0, 0)
        Me.crv_SOA.Name = "crv_SOA"
        Me.crv_SOA.ShowCloseButton = False
        Me.crv_SOA.ShowCopyButton = False
        Me.crv_SOA.ShowGotoPageButton = False
        Me.crv_SOA.ShowGroupTreeButton = False
        Me.crv_SOA.ShowLogo = False
        Me.crv_SOA.ShowParameterPanelButton = False
        Me.crv_SOA.ShowPrintButton = False
        Me.crv_SOA.Size = New System.Drawing.Size(1021, 396)
        Me.crv_SOA.TabIndex = 17
        Me.crv_SOA.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MetroPanel17
        '
        Me.MetroPanel17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroPanel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel17.HorizontalScrollbarBarColor = True
        Me.MetroPanel17.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel17.HorizontalScrollbarSize = 10
        Me.MetroPanel17.Location = New System.Drawing.Point(0, 464)
        Me.MetroPanel17.Name = "MetroPanel17"
        Me.MetroPanel17.Size = New System.Drawing.Size(1021, 10)
        Me.MetroPanel17.TabIndex = 16
        Me.MetroPanel17.UseCustomBackColor = True
        Me.MetroPanel17.VerticalScrollbarBarColor = True
        Me.MetroPanel17.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel17.VerticalScrollbarSize = 10
        '
        'mt_Setting
        '
        Me.mt_Setting.ActiveControl = Nothing
        Me.mt_Setting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mt_Setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_Setting.Location = New System.Drawing.Point(1008, 78)
        Me.mt_Setting.Name = "mt_Setting"
        Me.mt_Setting.Size = New System.Drawing.Size(26, 10)
        Me.mt_Setting.TabIndex = 14
        Me.mt_Setting.TileImage = CType(resources.GetObject("mt_Setting.TileImage"), System.Drawing.Image)
        Me.mt_Setting.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mt_Setting.UseCustomBackColor = True
        Me.mt_Setting.UseSelectable = True
        Me.mt_Setting.UseTileImage = True
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.mt_Setting)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Billing"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Billing"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.pnl_Setting.ResumeLayout(False)
        Me.MetroPanel5.ResumeLayout(False)
        Me.MetroPanel5.PerformLayout()
        CType(Me.dgv_ClientList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroPanel9.ResumeLayout(False)
        Me.MetroPanel9.PerformLayout()
        CType(Me.dgv_BillingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel9 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_Next1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Back As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Back1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Done As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel5 As MetroFramework.Controls.MetroPanel
    Friend WithEvents txt_ClientSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbl_ClientCount As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Next As MetroFramework.Controls.MetroButton
    Friend WithEvents lbl_BillingCount As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_BillingList As MetroFramework.Controls.MetroGrid
    Friend WithEvents dgv_ClientList As MetroFramework.Controls.MetroGrid
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents txt_BillingSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbl_ControlNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Balance As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_BillingDate As MetroFramework.Controls.MetroLabel
    Friend WithEvents crv_SOA As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MetroPanel17 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mt_Setting As MetroFramework.Controls.MetroTile
    Friend WithEvents pnl_Setting As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_BillingList As Button
    Friend WithEvents btn_StaApp As Button
    Friend WithEvents btn_RevBillList As Button
    Friend WithEvents btn_TrackingList As Button
    Friend WithEvents btn_CanBillList As Button
    Friend WithEvents btn_unbilled As Button
End Class
