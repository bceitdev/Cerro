<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Disbursement
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel13 = New MetroFramework.Controls.MetroPanel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.dgv_Disbursement = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.cbo_Chart = New MetroFramework.Controls.MetroComboBox()
        Me.lbl_Add = New MetroFramework.Controls.MetroLink()
        Me.txt_Cre = New MetroFramework.Controls.MetroTextBox()
        Me.txt_Deb = New MetroFramework.Controls.MetroTextBox()
        Me.txt_Desc = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Checkseries = New MetroFramework.Controls.MetroLabel()
        Me.cbo_Bank = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dtp_date = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_ControlNo = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_particulars = New MetroFramework.Controls.MetroTextBox()
        Me.lbl_amtwd = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.txt_amtno = New MetroFramework.Controls.MetroTextBox()
        Me.txt_Payee = New MetroFramework.Controls.MetroTextBox()
        Me.dgv_dummy = New MetroFramework.Controls.MetroGrid()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PostCheckApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChartToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_Search = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.crv_CV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crv_C = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroPanel13.SuspendLayout()
        CType(Me.dgv_Disbursement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dummy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 84)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(495, 492)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage1.Controls.Add(Me.MetroPanel13)
        Me.MetroTabPage1.Controls.Add(Me.dgv_Disbursement)
        Me.MetroTabPage1.Controls.Add(Me.cbo_Chart)
        Me.MetroTabPage1.Controls.Add(Me.lbl_Add)
        Me.MetroTabPage1.Controls.Add(Me.txt_Cre)
        Me.MetroTabPage1.Controls.Add(Me.txt_Deb)
        Me.MetroTabPage1.Controls.Add(Me.txt_Desc)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage1.Controls.Add(Me.lbl_Checkseries)
        Me.MetroTabPage1.Controls.Add(Me.cbo_Bank)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage1.Controls.Add(Me.dtp_date)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage1.Controls.Add(Me.lbl_ControlNo)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.txt_particulars)
        Me.MetroTabPage1.Controls.Add(Me.lbl_amtwd)
        Me.MetroTabPage1.Controls.Add(Me.MetroPanel2)
        Me.MetroTabPage1.Controls.Add(Me.txt_amtno)
        Me.MetroTabPage1.Controls.Add(Me.txt_Payee)
        Me.MetroTabPage1.Controls.Add(Me.dgv_dummy)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(487, 450)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Data Entry"
        Me.MetroTabPage1.UseStyleColors = True
        Me.MetroTabPage1.UseVisualStyleBackColor = True
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroPanel13
        '
        Me.MetroPanel13.Controls.Add(Me.btn_Submit)
        Me.MetroPanel13.Controls.Add(Me.btn_Cancel)
        Me.MetroPanel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel13.HorizontalScrollbarBarColor = True
        Me.MetroPanel13.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel13.HorizontalScrollbarSize = 10
        Me.MetroPanel13.Location = New System.Drawing.Point(0, 410)
        Me.MetroPanel13.Name = "MetroPanel13"
        Me.MetroPanel13.Size = New System.Drawing.Size(485, 38)
        Me.MetroPanel13.TabIndex = 119
        Me.MetroPanel13.VerticalScrollbarBarColor = True
        Me.MetroPanel13.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel13.VerticalScrollbarSize = 10
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(271, 0)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 38)
        Me.btn_Submit.TabIndex = 10
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(378, 0)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(107, 38)
        Me.btn_Cancel.TabIndex = 11
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'dgv_Disbursement
        '
        Me.dgv_Disbursement.AllowUserToAddRows = False
        Me.dgv_Disbursement.AllowUserToDeleteRows = False
        Me.dgv_Disbursement.AllowUserToResizeRows = False
        Me.dgv_Disbursement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Disbursement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_Disbursement.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Disbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Disbursement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_Disbursement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Disbursement.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Disbursement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Disbursement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Disbursement.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Disbursement.EnableHeadersVisualStyles = False
        Me.dgv_Disbursement.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_Disbursement.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Disbursement.Location = New System.Drawing.Point(0, 332)
        Me.dgv_Disbursement.Name = "dgv_Disbursement"
        Me.dgv_Disbursement.ReadOnly = True
        Me.dgv_Disbursement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Disbursement.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Disbursement.RowHeadersWidth = 35
        Me.dgv_Disbursement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_Disbursement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Disbursement.Size = New System.Drawing.Size(485, 78)
        Me.dgv_Disbursement.TabIndex = 107
        '
        'Column1
        '
        Me.Column1.HeaderText = "Chart"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 58
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 89
        '
        'Column3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Debit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 58
        '
        'Column4
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Credit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 61
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Text = "Remove"
        Me.Column5.UseColumnTextForLinkValue = True
        Me.Column5.Width = 5
        '
        'cbo_Chart
        '
        Me.cbo_Chart.FormattingEnabled = True
        Me.cbo_Chart.ItemHeight = 23
        Me.cbo_Chart.Location = New System.Drawing.Point(23, 297)
        Me.cbo_Chart.Name = "cbo_Chart"
        Me.cbo_Chart.Size = New System.Drawing.Size(77, 29)
        Me.cbo_Chart.TabIndex = 118
        Me.cbo_Chart.UseSelectable = True
        '
        'lbl_Add
        '
        Me.lbl_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_Add.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lbl_Add.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Add.Location = New System.Drawing.Point(431, 300)
        Me.lbl_Add.Name = "lbl_Add"
        Me.lbl_Add.Size = New System.Drawing.Size(32, 20)
        Me.lbl_Add.TabIndex = 8
        Me.lbl_Add.Text = "Add"
        Me.lbl_Add.UseCustomForeColor = True
        Me.lbl_Add.UseSelectable = True
        '
        'txt_Cre
        '
        '
        '
        '
        Me.txt_Cre.CustomButton.Image = Nothing
        Me.txt_Cre.CustomButton.Location = New System.Drawing.Point(37, 1)
        Me.txt_Cre.CustomButton.Name = ""
        Me.txt_Cre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Cre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Cre.CustomButton.TabIndex = 1
        Me.txt_Cre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Cre.CustomButton.UseSelectable = True
        Me.txt_Cre.CustomButton.Visible = False
        Me.txt_Cre.Lines = New String(-1) {}
        Me.txt_Cre.Location = New System.Drawing.Point(366, 297)
        Me.txt_Cre.MaxLength = 32767
        Me.txt_Cre.Name = "txt_Cre"
        Me.txt_Cre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Cre.PromptText = "Credit"
        Me.txt_Cre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Cre.SelectedText = ""
        Me.txt_Cre.SelectionLength = 0
        Me.txt_Cre.SelectionStart = 0
        Me.txt_Cre.ShortcutsEnabled = True
        Me.txt_Cre.Size = New System.Drawing.Size(59, 23)
        Me.txt_Cre.TabIndex = 7
        Me.txt_Cre.UseSelectable = True
        Me.txt_Cre.WaterMark = "Credit"
        Me.txt_Cre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Cre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_Deb
        '
        '
        '
        '
        Me.txt_Deb.CustomButton.Image = Nothing
        Me.txt_Deb.CustomButton.Location = New System.Drawing.Point(36, 1)
        Me.txt_Deb.CustomButton.Name = ""
        Me.txt_Deb.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Deb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Deb.CustomButton.TabIndex = 1
        Me.txt_Deb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Deb.CustomButton.UseSelectable = True
        Me.txt_Deb.CustomButton.Visible = False
        Me.txt_Deb.Lines = New String(-1) {}
        Me.txt_Deb.Location = New System.Drawing.Point(302, 297)
        Me.txt_Deb.MaxLength = 32767
        Me.txt_Deb.Name = "txt_Deb"
        Me.txt_Deb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Deb.PromptText = "Debit"
        Me.txt_Deb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Deb.SelectedText = ""
        Me.txt_Deb.SelectionLength = 0
        Me.txt_Deb.SelectionStart = 0
        Me.txt_Deb.ShortcutsEnabled = True
        Me.txt_Deb.Size = New System.Drawing.Size(58, 23)
        Me.txt_Deb.TabIndex = 6
        Me.txt_Deb.UseSelectable = True
        Me.txt_Deb.WaterMark = "Debit"
        Me.txt_Deb.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Deb.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_Desc
        '
        '
        '
        '
        Me.txt_Desc.CustomButton.Image = Nothing
        Me.txt_Desc.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txt_Desc.CustomButton.Name = ""
        Me.txt_Desc.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Desc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Desc.CustomButton.TabIndex = 1
        Me.txt_Desc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Desc.CustomButton.UseSelectable = True
        Me.txt_Desc.CustomButton.Visible = False
        Me.txt_Desc.Lines = New String(-1) {}
        Me.txt_Desc.Location = New System.Drawing.Point(106, 297)
        Me.txt_Desc.MaxLength = 32767
        Me.txt_Desc.Name = "txt_Desc"
        Me.txt_Desc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Desc.PromptText = "Description"
        Me.txt_Desc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Desc.SelectedText = ""
        Me.txt_Desc.SelectionLength = 0
        Me.txt_Desc.SelectionStart = 0
        Me.txt_Desc.ShortcutsEnabled = True
        Me.txt_Desc.Size = New System.Drawing.Size(190, 23)
        Me.txt_Desc.TabIndex = 5
        Me.txt_Desc.UseSelectable = True
        Me.txt_Desc.WaterMark = "Description"
        Me.txt_Desc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Desc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 275)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel7.TabIndex = 109
        Me.MetroLabel7.Text = "Chart:"
        '
        'lbl_Checkseries
        '
        Me.lbl_Checkseries.ForeColor = System.Drawing.Color.Red
        Me.lbl_Checkseries.Location = New System.Drawing.Point(308, 221)
        Me.lbl_Checkseries.Name = "lbl_Checkseries"
        Me.lbl_Checkseries.Size = New System.Drawing.Size(155, 19)
        Me.lbl_Checkseries.TabIndex = 108
        Me.lbl_Checkseries.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_Checkseries.UseCustomForeColor = True
        '
        'cbo_Bank
        '
        Me.cbo_Bank.FormattingEnabled = True
        Me.cbo_Bank.ItemHeight = 23
        Me.cbo_Bank.Location = New System.Drawing.Point(23, 243)
        Me.cbo_Bank.Name = "cbo_Bank"
        Me.cbo_Bank.Size = New System.Drawing.Size(440, 29)
        Me.cbo_Bank.TabIndex = 3
        Me.cbo_Bank.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(22, 221)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel6.TabIndex = 104
        Me.MetroLabel6.Text = "Bank:"
        '
        'dtp_date
        '
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date.Location = New System.Drawing.Point(350, 10)
        Me.dtp_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(113, 29)
        Me.dtp_date.TabIndex = 9
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(305, 20)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel5.TabIndex = 102
        Me.MetroLabel5.Text = "Date:"
        '
        'lbl_ControlNo
        '
        Me.lbl_ControlNo.AutoSize = True
        Me.lbl_ControlNo.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_ControlNo.ForeColor = System.Drawing.Color.Red
        Me.lbl_ControlNo.Location = New System.Drawing.Point(110, 20)
        Me.lbl_ControlNo.Name = "lbl_ControlNo"
        Me.lbl_ControlNo.Size = New System.Drawing.Size(0, 0)
        Me.lbl_ControlNo.TabIndex = 100
        Me.lbl_ControlNo.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 20)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel4.TabIndex = 99
        Me.MetroLabel4.Text = "Control No.:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(22, 173)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel3.TabIndex = 98
        Me.MetroLabel3.Text = "Particulars:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(22, 96)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel2.TabIndex = 97
        Me.MetroLabel2.Text = "Amount:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(22, 48)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 96
        Me.MetroLabel1.Text = "Payee:"
        '
        'txt_particulars
        '
        '
        '
        '
        Me.txt_particulars.CustomButton.Image = Nothing
        Me.txt_particulars.CustomButton.Location = New System.Drawing.Point(418, 1)
        Me.txt_particulars.CustomButton.Name = ""
        Me.txt_particulars.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_particulars.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_particulars.CustomButton.TabIndex = 1
        Me.txt_particulars.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_particulars.CustomButton.UseSelectable = True
        Me.txt_particulars.CustomButton.Visible = False
        Me.txt_particulars.Lines = New String(-1) {}
        Me.txt_particulars.Location = New System.Drawing.Point(23, 195)
        Me.txt_particulars.MaxLength = 32767
        Me.txt_particulars.Name = "txt_particulars"
        Me.txt_particulars.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_particulars.PromptText = "Description"
        Me.txt_particulars.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_particulars.SelectedText = ""
        Me.txt_particulars.SelectionLength = 0
        Me.txt_particulars.SelectionStart = 0
        Me.txt_particulars.ShortcutsEnabled = True
        Me.txt_particulars.Size = New System.Drawing.Size(440, 23)
        Me.txt_particulars.TabIndex = 2
        Me.txt_particulars.UseSelectable = True
        Me.txt_particulars.WaterMark = "Description"
        Me.txt_particulars.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_particulars.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lbl_amtwd
        '
        Me.lbl_amtwd.AutoSize = True
        Me.lbl_amtwd.Location = New System.Drawing.Point(22, 147)
        Me.lbl_amtwd.Name = "lbl_amtwd"
        Me.lbl_amtwd.Size = New System.Drawing.Size(0, 0)
        Me.lbl_amtwd.TabIndex = 93
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(23, 169)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(440, 1)
        Me.MetroPanel2.TabIndex = 92
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'txt_amtno
        '
        '
        '
        '
        Me.txt_amtno.CustomButton.Image = Nothing
        Me.txt_amtno.CustomButton.Location = New System.Drawing.Point(418, 1)
        Me.txt_amtno.CustomButton.Name = ""
        Me.txt_amtno.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_amtno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_amtno.CustomButton.TabIndex = 1
        Me.txt_amtno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_amtno.CustomButton.UseSelectable = True
        Me.txt_amtno.CustomButton.Visible = False
        Me.txt_amtno.Lines = New String(-1) {}
        Me.txt_amtno.Location = New System.Drawing.Point(23, 118)
        Me.txt_amtno.MaxLength = 32767
        Me.txt_amtno.Name = "txt_amtno"
        Me.txt_amtno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_amtno.PromptText = "In Figure"
        Me.txt_amtno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_amtno.SelectedText = ""
        Me.txt_amtno.SelectionLength = 0
        Me.txt_amtno.SelectionStart = 0
        Me.txt_amtno.ShortcutsEnabled = True
        Me.txt_amtno.Size = New System.Drawing.Size(440, 23)
        Me.txt_amtno.TabIndex = 1
        Me.txt_amtno.UseSelectable = True
        Me.txt_amtno.WaterMark = "In Figure"
        Me.txt_amtno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_amtno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_Payee
        '
        '
        '
        '
        Me.txt_Payee.CustomButton.Image = Nothing
        Me.txt_Payee.CustomButton.Location = New System.Drawing.Point(418, 1)
        Me.txt_Payee.CustomButton.Name = ""
        Me.txt_Payee.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Payee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Payee.CustomButton.TabIndex = 1
        Me.txt_Payee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Payee.CustomButton.UseSelectable = True
        Me.txt_Payee.CustomButton.Visible = False
        Me.txt_Payee.Lines = New String(-1) {}
        Me.txt_Payee.Location = New System.Drawing.Point(23, 70)
        Me.txt_Payee.MaxLength = 32767
        Me.txt_Payee.Name = "txt_Payee"
        Me.txt_Payee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Payee.PromptText = "Name"
        Me.txt_Payee.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Payee.SelectedText = ""
        Me.txt_Payee.SelectionLength = 0
        Me.txt_Payee.SelectionStart = 0
        Me.txt_Payee.ShortcutsEnabled = True
        Me.txt_Payee.Size = New System.Drawing.Size(440, 23)
        Me.txt_Payee.TabIndex = 0
        Me.txt_Payee.UseSelectable = True
        Me.txt_Payee.WaterMark = "Name"
        Me.txt_Payee.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Payee.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dgv_dummy
        '
        Me.dgv_dummy.AllowUserToAddRows = False
        Me.dgv_dummy.AllowUserToDeleteRows = False
        Me.dgv_dummy.AllowUserToResizeRows = False
        Me.dgv_dummy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_dummy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_dummy.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_dummy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_dummy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_dummy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dummy.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_dummy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_dummy.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_dummy.EnableHeadersVisualStyles = False
        Me.dgv_dummy.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_dummy.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_dummy.Location = New System.Drawing.Point(0, 332)
        Me.dgv_dummy.Name = "dgv_dummy"
        Me.dgv_dummy.ReadOnly = True
        Me.dgv_dummy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dummy.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_dummy.RowHeadersWidth = 35
        Me.dgv_dummy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_dummy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_dummy.Size = New System.Drawing.Size(485, 78)
        Me.dgv_dummy.TabIndex = 108
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PostCheckApprovalToolStripMenuItem, Me.ChartToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1029, 24)
        Me.MenuStrip1.TabIndex = 116
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PostCheckApprovalToolStripMenuItem
        '
        Me.PostCheckApprovalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApprovalToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.PostCheckApprovalToolStripMenuItem.Name = "PostCheckApprovalToolStripMenuItem"
        Me.PostCheckApprovalToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.PostCheckApprovalToolStripMenuItem.Text = "Check"
        '
        'ApprovalToolStripMenuItem
        '
        Me.ApprovalToolStripMenuItem.Name = "ApprovalToolStripMenuItem"
        Me.ApprovalToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ApprovalToolStripMenuItem.Text = "Posting"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'ChartToolStripMenuItem
        '
        Me.ChartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChartToolStripMenuItem1})
        Me.ChartToolStripMenuItem.Name = "ChartToolStripMenuItem"
        Me.ChartToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ChartToolStripMenuItem.Text = "Maintenance"
        '
        'ChartToolStripMenuItem1
        '
        Me.ChartToolStripMenuItem1.Name = "ChartToolStripMenuItem1"
        Me.ChartToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ChartToolStripMenuItem1.Text = "Chart"
        '
        'txt_Search
        '
        '
        '
        '
        Me.txt_Search.CustomButton.Image = Nothing
        Me.txt_Search.CustomButton.Location = New System.Drawing.Point(115, 1)
        Me.txt_Search.CustomButton.Name = ""
        Me.txt_Search.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Search.CustomButton.TabIndex = 1
        Me.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Search.CustomButton.UseSelectable = True
        Me.txt_Search.CustomButton.Visible = False
        Me.txt_Search.Lines = New String(-1) {}
        Me.txt_Search.Location = New System.Drawing.Point(375, 91)
        Me.txt_Search.MaxLength = 32767
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Search.PromptText = "Search here"
        Me.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Search.SelectedText = ""
        Me.txt_Search.SelectionLength = 0
        Me.txt_Search.SelectionStart = 0
        Me.txt_Search.ShortcutsEnabled = True
        Me.txt_Search.Size = New System.Drawing.Size(137, 23)
        Me.txt_Search.TabIndex = 118
        Me.txt_Search.UseSelectable = True
        Me.txt_Search.WaterMark = "Search here"
        Me.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Search.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage3.Controls.Add(Me.crv_C)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(526, 450)
        Me.MetroTabPage3.TabIndex = 1
        Me.MetroTabPage3.Text = "Check"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage2.Controls.Add(Me.crv_CV)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(526, 450)
        Me.MetroTabPage2.TabIndex = 0
        Me.MetroTabPage2.Text = "Voucher"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl2.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl2.Location = New System.Drawing.Point(515, 84)
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(534, 492)
        Me.MetroTabControl2.TabIndex = 117
        Me.MetroTabControl2.UseSelectable = True
        '
        'crv_CV
        '
        Me.crv_CV.ActiveViewIndex = -1
        Me.crv_CV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_CV.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_CV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_CV.Location = New System.Drawing.Point(0, 0)
        Me.crv_CV.Name = "crv_CV"
        Me.crv_CV.ShowCloseButton = False
        Me.crv_CV.ShowCopyButton = False
        Me.crv_CV.ShowGotoPageButton = False
        Me.crv_CV.ShowGroupTreeButton = False
        Me.crv_CV.ShowLogo = False
        Me.crv_CV.ShowParameterPanelButton = False
        Me.crv_CV.ShowPrintButton = False
        Me.crv_CV.Size = New System.Drawing.Size(524, 448)
        Me.crv_CV.TabIndex = 18
        Me.crv_CV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'crv_C
        '
        Me.crv_C.ActiveViewIndex = -1
        Me.crv_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_C.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_C.Location = New System.Drawing.Point(0, 0)
        Me.crv_C.Name = "crv_C"
        Me.crv_C.ShowCloseButton = False
        Me.crv_C.ShowCopyButton = False
        Me.crv_C.ShowGotoPageButton = False
        Me.crv_C.ShowGroupTreeButton = False
        Me.crv_C.ShowLogo = False
        Me.crv_C.ShowParameterPanelButton = False
        Me.crv_C.ShowPrintButton = False
        Me.crv_C.Size = New System.Drawing.Size(524, 448)
        Me.crv_C.TabIndex = 19
        Me.crv_C.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Disbursement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.MetroTabControl2)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Disbursement"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Disbursement"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroPanel13.ResumeLayout(False)
        CType(Me.dgv_Disbursement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dummy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txt_amtno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_Payee As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_particulars As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_ControlNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_Bank As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_Disbursement As MetroFramework.Controls.MetroGrid
    Friend WithEvents lbl_Checkseries As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_Cre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_Deb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_Desc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbl_Add As MetroFramework.Controls.MetroLink
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PostCheckApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_amtwd As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel

    Friend WithEvents cbo_Chart As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroPanel13 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents ChartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChartToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txt_Search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgv_dummy As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewLinkColumn
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents crv_C As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crv_CV As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
