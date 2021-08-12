<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForCosting
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_TrackList = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.txt_Search = New MetroFramework.Controls.MetroTextBox()
        CType(Me.dgv_TrackList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_TrackList
        '
        Me.dgv_TrackList.AllowUserToAddRows = False
        Me.dgv_TrackList.AllowUserToDeleteRows = False
        Me.dgv_TrackList.AllowUserToResizeRows = False
        Me.dgv_TrackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_TrackList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_TrackList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_TrackList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_TrackList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_TrackList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_TrackList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_TrackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_TrackList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_TrackList.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_TrackList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_TrackList.EnableHeadersVisualStyles = False
        Me.dgv_TrackList.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_TrackList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_TrackList.Location = New System.Drawing.Point(20, 60)
        Me.dgv_TrackList.Name = "dgv_TrackList"
        Me.dgv_TrackList.ReadOnly = True
        Me.dgv_TrackList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_TrackList.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgv_TrackList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_TrackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_TrackList.Size = New System.Drawing.Size(1029, 516)
        Me.dgv_TrackList.TabIndex = 93
        '
        'Column1
        '
        Me.Column1.HeaderText = "Reprint"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Reprint"
        Me.Column1.UseColumnTextForLinkValue = True
        Me.Column1.Width = 49
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cancel"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "Cancel"
        Me.Column2.UseColumnTextForLinkValue = True
        Me.Column2.Width = 45
        '
        'txt_Search
        '
        Me.txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_Search.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_Search.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_Search.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_Search.CustomButton.Image = Nothing
        Me.txt_Search.CustomButton.Location = New System.Drawing.Point(143, 1)
        Me.txt_Search.CustomButton.Name = ""
        Me.txt_Search.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Search.CustomButton.TabIndex = 1
        Me.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Search.CustomButton.UseSelectable = True
        Me.txt_Search.CustomButton.Visible = False
        Me.txt_Search.Lines = New String(-1) {}
        Me.txt_Search.Location = New System.Drawing.Point(884, 31)
        Me.txt_Search.MaxLength = 32767
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Search.PromptText = "Search here"
        Me.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Search.SelectedText = ""
        Me.txt_Search.SelectionLength = 0
        Me.txt_Search.SelectionStart = 0
        Me.txt_Search.ShortcutsEnabled = True
        Me.txt_Search.ShowClearButton = True
        Me.txt_Search.Size = New System.Drawing.Size(165, 23)
        Me.txt_Search.TabIndex = 104
        Me.txt_Search.UseSelectable = True
        Me.txt_Search.WaterMark = "Search here"
        Me.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Search.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ForCosting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.dgv_TrackList)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ForCosting"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tracking List"
        CType(Me.dgv_TrackList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_TrackList As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewLinkColumn
    Friend WithEvents Column2 As DataGridViewLinkColumn
    Friend WithEvents txt_Search As MetroFramework.Controls.MetroTextBox
End Class
