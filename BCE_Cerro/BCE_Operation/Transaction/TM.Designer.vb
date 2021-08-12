<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.crv_TM = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btn_Print = New MetroFramework.Controls.MetroButton()
        Me.dgv_TM = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewLinkColumn()
        CType(Me.dgv_TM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crv_TM
        '
        Me.crv_TM.ActiveViewIndex = -1
        Me.crv_TM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_TM.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_TM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_TM.Location = New System.Drawing.Point(20, 60)
        Me.crv_TM.Name = "crv_TM"
        Me.crv_TM.ShowCloseButton = False
        Me.crv_TM.ShowGotoPageButton = False
        Me.crv_TM.ShowGroupTreeButton = False
        Me.crv_TM.ShowLogo = False
        Me.crv_TM.ShowParameterPanelButton = False
        Me.crv_TM.ShowPrintButton = False
        Me.crv_TM.Size = New System.Drawing.Size(1133, 575)
        Me.crv_TM.TabIndex = 31
        Me.crv_TM.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btn_Print
        '
        Me.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Print.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Print.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Print.Location = New System.Drawing.Point(20, 635)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(1133, 31)
        Me.btn_Print.TabIndex = 33
        Me.btn_Print.Text = "Print"
        Me.btn_Print.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Print.UseSelectable = True
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
        Me.dgv_TM.EnableHeadersVisualStyles = False
        Me.dgv_TM.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_TM.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_TM.Location = New System.Drawing.Point(1067, 15)
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
        Me.dgv_TM.Size = New System.Drawing.Size(55, 39)
        Me.dgv_TM.TabIndex = 94
        Me.dgv_TM.Visible = False
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
        'TM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 686)
        Me.Controls.Add(Me.dgv_TM)
        Me.Controls.Add(Me.crv_TM)
        Me.Controls.Add(Me.btn_Print)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TM"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transfer Manifest"
        CType(Me.dgv_TM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crv_TM As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_Print As MetroFramework.Controls.MetroButton
    Friend WithEvents dgv_TM As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewLinkColumn
End Class
