<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CS_PickUpList
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
        Me.txt_Search = New MetroFramework.Controls.MetroTextBox()
        Me.dgv_Pickuplist = New MetroFramework.Controls.MetroGrid()
        Me.cancel = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.modify = New System.Windows.Forms.DataGridViewLinkColumn()
        CType(Me.dgv_Pickuplist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Search
        '
        '
        '
        '
        Me.txt_Search.CustomButton.Image = Nothing
        Me.txt_Search.CustomButton.Location = New System.Drawing.Point(183, 1)
        Me.txt_Search.CustomButton.Name = ""
        Me.txt_Search.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Search.CustomButton.TabIndex = 1
        Me.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Search.CustomButton.UseSelectable = True
        Me.txt_Search.CustomButton.Visible = False
        Me.txt_Search.Lines = New String(-1) {}
        Me.txt_Search.Location = New System.Drawing.Point(844, 31)
        Me.txt_Search.MaxLength = 32767
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Search.PromptText = "Search here"
        Me.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Search.SelectedText = ""
        Me.txt_Search.SelectionLength = 0
        Me.txt_Search.SelectionStart = 0
        Me.txt_Search.ShortcutsEnabled = True
        Me.txt_Search.Size = New System.Drawing.Size(205, 23)
        Me.txt_Search.TabIndex = 7
        Me.txt_Search.UseSelectable = True
        Me.txt_Search.WaterMark = "Search here"
        Me.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Search.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dgv_Pickuplist
        '
        Me.dgv_Pickuplist.AllowUserToAddRows = False
        Me.dgv_Pickuplist.AllowUserToDeleteRows = False
        Me.dgv_Pickuplist.AllowUserToResizeColumns = False
        Me.dgv_Pickuplist.AllowUserToResizeRows = False
        Me.dgv_Pickuplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_Pickuplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Pickuplist.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Pickuplist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Pickuplist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_Pickuplist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Pickuplist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Pickuplist.ColumnHeadersHeight = 33
        Me.dgv_Pickuplist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cancel, Me.modify})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Pickuplist.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Pickuplist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Pickuplist.EnableHeadersVisualStyles = False
        Me.dgv_Pickuplist.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_Pickuplist.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Pickuplist.Location = New System.Drawing.Point(20, 60)
        Me.dgv_Pickuplist.Name = "dgv_Pickuplist"
        Me.dgv_Pickuplist.ReadOnly = True
        Me.dgv_Pickuplist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Pickuplist.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Pickuplist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_Pickuplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Pickuplist.Size = New System.Drawing.Size(1029, 516)
        Me.dgv_Pickuplist.TabIndex = 8
        '
        'cancel
        '
        Me.cancel.HeaderText = "Cancel"
        Me.cancel.Name = "cancel"
        Me.cancel.ReadOnly = True
        Me.cancel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cancel.Text = "Cancel"
        Me.cancel.UseColumnTextForLinkValue = True
        Me.cancel.Width = 64
        '
        'modify
        '
        Me.modify.HeaderText = "Modify"
        Me.modify.Name = "modify"
        Me.modify.ReadOnly = True
        Me.modify.Text = "Modify"
        Me.modify.UseColumnTextForLinkValue = True
        Me.modify.Width = 47
        '
        'CS_PickUpList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.dgv_Pickuplist)
        Me.Controls.Add(Me.txt_Search)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CS_PickUpList"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Pickup List"
        CType(Me.dgv_Pickuplist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_Search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgv_Pickuplist As MetroFramework.Controls.MetroGrid
    Friend WithEvents cancel As DataGridViewLinkColumn
    Friend WithEvents modify As DataGridViewLinkColumn
End Class
