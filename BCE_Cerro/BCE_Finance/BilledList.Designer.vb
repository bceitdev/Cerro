<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BilledList
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_TrackList = New MetroFramework.Controls.MetroGrid()
        Me.txt_TrackList = New MetroFramework.Controls.MetroTextBox()
        Me.lbl_Export = New MetroFramework.Controls.MetroLink()
        CType(Me.dgv_TrackList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_TrackList
        '
        Me.dgv_TrackList.AllowUserToAddRows = False
        Me.dgv_TrackList.AllowUserToDeleteRows = False
        Me.dgv_TrackList.AllowUserToResizeRows = False
        Me.dgv_TrackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_TrackList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_TrackList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_TrackList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_TrackList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_TrackList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_TrackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_TrackList.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_TrackList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_TrackList.EnableHeadersVisualStyles = False
        Me.dgv_TrackList.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_TrackList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_TrackList.Location = New System.Drawing.Point(20, 60)
        Me.dgv_TrackList.Name = "dgv_TrackList"
        Me.dgv_TrackList.ReadOnly = True
        Me.dgv_TrackList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_TrackList.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_TrackList.RowHeadersWidth = 35
        Me.dgv_TrackList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_TrackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_TrackList.Size = New System.Drawing.Size(1108, 516)
        Me.dgv_TrackList.TabIndex = 139
        '
        'txt_TrackList
        '
        Me.txt_TrackList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_TrackList.CustomButton.Image = Nothing
        Me.txt_TrackList.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txt_TrackList.CustomButton.Name = ""
        Me.txt_TrackList.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_TrackList.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_TrackList.CustomButton.TabIndex = 1
        Me.txt_TrackList.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_TrackList.CustomButton.UseSelectable = True
        Me.txt_TrackList.CustomButton.Visible = False
        Me.txt_TrackList.Lines = New String(-1) {}
        Me.txt_TrackList.Location = New System.Drawing.Point(966, 31)
        Me.txt_TrackList.MaxLength = 32767
        Me.txt_TrackList.Name = "txt_TrackList"
        Me.txt_TrackList.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_TrackList.PromptText = "Search here"
        Me.txt_TrackList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TrackList.SelectedText = ""
        Me.txt_TrackList.SelectionLength = 0
        Me.txt_TrackList.SelectionStart = 0
        Me.txt_TrackList.ShortcutsEnabled = True
        Me.txt_TrackList.Size = New System.Drawing.Size(162, 23)
        Me.txt_TrackList.TabIndex = 140
        Me.txt_TrackList.UseSelectable = True
        Me.txt_TrackList.WaterMark = "Search here"
        Me.txt_TrackList.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_TrackList.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lbl_Export
        '
        Me.lbl_Export.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Export.AutoSize = True
        Me.lbl_Export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_Export.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lbl_Export.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Export.Location = New System.Drawing.Point(913, 31)
        Me.lbl_Export.Name = "lbl_Export"
        Me.lbl_Export.Size = New System.Drawing.Size(47, 23)
        Me.lbl_Export.TabIndex = 141
        Me.lbl_Export.Text = "Export"
        Me.lbl_Export.UseCustomForeColor = True
        Me.lbl_Export.UseSelectable = True
        '
        'BilledList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 596)
        Me.Controls.Add(Me.lbl_Export)
        Me.Controls.Add(Me.txt_TrackList)
        Me.Controls.Add(Me.dgv_TrackList)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "BilledList"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tracking List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_TrackList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_TrackList As MetroFramework.Controls.MetroGrid
    Friend WithEvents txt_TrackList As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbl_Export As MetroFramework.Controls.MetroLink
End Class
