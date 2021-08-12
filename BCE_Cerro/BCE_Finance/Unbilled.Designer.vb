<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unbilled
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
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.dgv_AcctReq = New MetroFramework.Controls.MetroGrid()
        Me.txt_Search = New MetroFramework.Controls.MetroTextBox()
        CType(Me.dgv_AcctReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(20, 60)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(274, 19)
        Me.MetroLabel7.TabIndex = 33
        Me.MetroLabel7.Text = "Below are the list of revised billing statements"
        '
        'dgv_AcctReq
        '
        Me.dgv_AcctReq.AllowUserToAddRows = False
        Me.dgv_AcctReq.AllowUserToDeleteRows = False
        Me.dgv_AcctReq.AllowUserToResizeRows = False
        Me.dgv_AcctReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_AcctReq.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_AcctReq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_AcctReq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_AcctReq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_AcctReq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_AcctReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_AcctReq.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_AcctReq.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_AcctReq.EnableHeadersVisualStyles = False
        Me.dgv_AcctReq.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_AcctReq.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_AcctReq.Location = New System.Drawing.Point(20, 82)
        Me.dgv_AcctReq.Name = "dgv_AcctReq"
        Me.dgv_AcctReq.ReadOnly = True
        Me.dgv_AcctReq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_AcctReq.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_AcctReq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_AcctReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_AcctReq.Size = New System.Drawing.Size(1083, 526)
        Me.dgv_AcctReq.TabIndex = 34
        '
        'txt_Search
        '
        Me.txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_Search.CustomButton.Image = Nothing
        Me.txt_Search.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txt_Search.CustomButton.Name = ""
        Me.txt_Search.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Search.CustomButton.TabIndex = 1
        Me.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Search.CustomButton.UseSelectable = True
        Me.txt_Search.CustomButton.Visible = False
        Me.txt_Search.Lines = New String(-1) {}
        Me.txt_Search.Location = New System.Drawing.Point(941, 53)
        Me.txt_Search.MaxLength = 32767
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Search.PromptText = "Search here"
        Me.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Search.SelectedText = ""
        Me.txt_Search.SelectionLength = 0
        Me.txt_Search.SelectionStart = 0
        Me.txt_Search.ShortcutsEnabled = True
        Me.txt_Search.Size = New System.Drawing.Size(162, 23)
        Me.txt_Search.TabIndex = 141
        Me.txt_Search.UseSelectable = True
        Me.txt_Search.WaterMark = "Search here"
        Me.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Search.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'billedun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 628)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.dgv_AcctReq)
        Me.Controls.Add(Me.MetroLabel7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "billedun"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Billed and Unbilled List"
        CType(Me.dgv_AcctReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_AcctReq As MetroFramework.Controls.MetroGrid
    Friend WithEvents txt_Search As MetroFramework.Controls.MetroTextBox
End Class
