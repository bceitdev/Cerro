<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransferManifest
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
        Me.cbo_Station = New MetroFramework.Controls.MetroComboBox()
        Me.cbo_Dest = New MetroFramework.Controls.MetroComboBox()
        Me.txt_phone = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt_SP = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dgv_TM = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.btn_Gen = New MetroFramework.Controls.MetroButton()
        CType(Me.dgv_TM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_Station
        '
        Me.cbo_Station.FormattingEnabled = True
        Me.cbo_Station.ItemHeight = 23
        Me.cbo_Station.Location = New System.Drawing.Point(362, 82)
        Me.cbo_Station.Name = "cbo_Station"
        Me.cbo_Station.Size = New System.Drawing.Size(165, 29)
        Me.cbo_Station.TabIndex = 2
        Me.cbo_Station.UseSelectable = True
        '
        'cbo_Dest
        '
        Me.cbo_Dest.FormattingEnabled = True
        Me.cbo_Dest.ItemHeight = 23
        Me.cbo_Dest.Location = New System.Drawing.Point(533, 82)
        Me.cbo_Dest.Name = "cbo_Dest"
        Me.cbo_Dest.Size = New System.Drawing.Size(165, 29)
        Me.cbo_Dest.TabIndex = 3
        Me.cbo_Dest.UseSelectable = True
        '
        'txt_phone
        '
        '
        '
        '
        Me.txt_phone.CustomButton.Image = Nothing
        Me.txt_phone.CustomButton.Location = New System.Drawing.Point(143, 1)
        Me.txt_phone.CustomButton.Name = ""
        Me.txt_phone.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_phone.CustomButton.TabIndex = 1
        Me.txt_phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_phone.CustomButton.UseSelectable = True
        Me.txt_phone.CustomButton.Visible = False
        Me.txt_phone.Lines = New String(-1) {}
        Me.txt_phone.Location = New System.Drawing.Point(191, 82)
        Me.txt_phone.MaxLength = 32767
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_phone.SelectedText = ""
        Me.txt_phone.SelectionLength = 0
        Me.txt_phone.SelectionStart = 0
        Me.txt_phone.ShortcutsEnabled = True
        Me.txt_phone.Size = New System.Drawing.Size(165, 23)
        Me.txt_phone.TabIndex = 1
        Me.txt_phone.UseSelectable = True
        Me.txt_phone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_phone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(191, 60)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel4.TabIndex = 72
        Me.MetroLabel4.Text = "Contact No.:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(362, 60)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel3.TabIndex = 70
        Me.MetroLabel3.Text = "Station:"
        '
        'txt_SP
        '
        '
        '
        '
        Me.txt_SP.CustomButton.Image = Nothing
        Me.txt_SP.CustomButton.Location = New System.Drawing.Point(143, 1)
        Me.txt_SP.CustomButton.Name = ""
        Me.txt_SP.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_SP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_SP.CustomButton.TabIndex = 1
        Me.txt_SP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_SP.CustomButton.UseSelectable = True
        Me.txt_SP.CustomButton.Visible = False
        Me.txt_SP.Lines = New String(-1) {}
        Me.txt_SP.Location = New System.Drawing.Point(23, 82)
        Me.txt_SP.MaxLength = 32767
        Me.txt_SP.Name = "txt_SP"
        Me.txt_SP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_SP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SP.SelectedText = ""
        Me.txt_SP.SelectionLength = 0
        Me.txt_SP.SelectionStart = 0
        Me.txt_SP.ShortcutsEnabled = True
        Me.txt_SP.Size = New System.Drawing.Size(165, 23)
        Me.txt_SP.TabIndex = 0
        Me.txt_SP.UseSelectable = True
        Me.txt_SP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_SP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel2.TabIndex = 68
        Me.MetroLabel2.Text = "Service Partner:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(533, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel1.TabIndex = 66
        Me.MetroLabel1.Text = "Destination:"
        '
        'dgv_TM
        '
        Me.dgv_TM.AllowUserToAddRows = False
        Me.dgv_TM.AllowUserToDeleteRows = False
        Me.dgv_TM.AllowUserToResizeRows = False
        Me.dgv_TM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_TM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_TM.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_TM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_TM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_TM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_TM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_TM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_TM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_TM.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_TM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_TM.EnableHeadersVisualStyles = False
        Me.dgv_TM.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_TM.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_TM.Location = New System.Drawing.Point(20, 117)
        Me.dgv_TM.Name = "dgv_TM"
        Me.dgv_TM.ReadOnly = True
        Me.dgv_TM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_TM.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_TM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_TM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_TM.Size = New System.Drawing.Size(1029, 428)
        Me.dgv_TM.TabIndex = 93
        '
        'Column1
        '
        Me.Column1.HeaderText = "Remove"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Remove"
        Me.Column1.UseColumnTextForLinkValue = True
        Me.Column1.Width = 51
        '
        'btn_Gen
        '
        Me.btn_Gen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Gen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Gen.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Gen.Location = New System.Drawing.Point(20, 545)
        Me.btn_Gen.Name = "btn_Gen"
        Me.btn_Gen.Size = New System.Drawing.Size(1029, 31)
        Me.btn_Gen.TabIndex = 97
        Me.btn_Gen.Text = "Generate"
        Me.btn_Gen.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Gen.UseSelectable = True
        '
        'TransferManifest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.dgv_TM)
        Me.Controls.Add(Me.txt_SP)
        Me.Controls.Add(Me.cbo_Dest)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cbo_Station)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btn_Gen)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransferManifest"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transfer Manifest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_TM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_SP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_phone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_TM As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewLinkColumn
    Friend WithEvents cbo_Dest As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbo_Station As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btn_Gen As MetroFramework.Controls.MetroButton
End Class
