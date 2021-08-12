<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Outbound
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
        Me.txt_pur = New MetroFramework.Controls.MetroTextBox()
        Me.dgv_Received = New MetroFramework.Controls.MetroGrid()
        Me.modify = New System.Windows.Forms.DataGridViewLinkColumn()
        CType(Me.dgv_Received, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_pur
        '
        Me.txt_pur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_pur.CustomButton.Image = Nothing
        Me.txt_pur.CustomButton.Location = New System.Drawing.Point(146, 1)
        Me.txt_pur.CustomButton.Name = ""
        Me.txt_pur.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_pur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_pur.CustomButton.TabIndex = 1
        Me.txt_pur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_pur.CustomButton.UseSelectable = True
        Me.txt_pur.CustomButton.Visible = False
        Me.txt_pur.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_pur.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txt_pur.Lines = New String(-1) {}
        Me.txt_pur.Location = New System.Drawing.Point(866, 31)
        Me.txt_pur.MaxLength = 32767
        Me.txt_pur.Name = "txt_pur"
        Me.txt_pur.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pur.PromptText = "Search here"
        Me.txt_pur.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_pur.SelectedText = ""
        Me.txt_pur.SelectionLength = 0
        Me.txt_pur.SelectionStart = 0
        Me.txt_pur.ShortcutsEnabled = True
        Me.txt_pur.Size = New System.Drawing.Size(168, 23)
        Me.txt_pur.TabIndex = 75
        Me.txt_pur.UseSelectable = True
        Me.txt_pur.WaterMark = "Search here"
        Me.txt_pur.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_pur.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dgv_Received
        '
        Me.dgv_Received.AllowUserToAddRows = False
        Me.dgv_Received.AllowUserToDeleteRows = False
        Me.dgv_Received.AllowUserToResizeColumns = False
        Me.dgv_Received.AllowUserToResizeRows = False
        Me.dgv_Received.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_Received.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Received.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Received.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Received.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_Received.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Received.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Received.ColumnHeadersHeight = 33
        Me.dgv_Received.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.modify})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Received.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Received.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Received.EnableHeadersVisualStyles = False
        Me.dgv_Received.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_Received.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Received.Location = New System.Drawing.Point(20, 60)
        Me.dgv_Received.Name = "dgv_Received"
        Me.dgv_Received.ReadOnly = True
        Me.dgv_Received.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Received.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Received.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_Received.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Received.Size = New System.Drawing.Size(1029, 516)
        Me.dgv_Received.TabIndex = 94
        '
        'modify
        '
        Me.modify.HeaderText = ""
        Me.modify.Name = "modify"
        Me.modify.ReadOnly = True
        Me.modify.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.modify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.modify.Text = "Print"
        Me.modify.UseColumnTextForLinkValue = True
        Me.modify.Width = 17
        '
        'Outbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.dgv_Received)
        Me.Controls.Add(Me.txt_pur)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Outbound"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Way Bill"
        CType(Me.dgv_Received, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_pur As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgv_Received As MetroFramework.Controls.MetroGrid
    Friend WithEvents modify As DataGridViewLinkColumn
End Class
