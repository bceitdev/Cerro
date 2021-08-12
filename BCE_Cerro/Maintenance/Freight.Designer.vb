<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Freight
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
        Me.txt_service = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dgv_loading = New MetroFramework.Controls.MetroGrid()
        Me.btn_Remove = New MetroFramework.Controls.MetroButton()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.cbo_Cat = New MetroFramework.Controls.MetroComboBox()
        CType(Me.dgv_loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_service
        '
        Me.txt_service.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_service.CustomButton.Image = Nothing
        Me.txt_service.CustomButton.Location = New System.Drawing.Point(328, 1)
        Me.txt_service.CustomButton.Name = ""
        Me.txt_service.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_service.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_service.CustomButton.TabIndex = 1
        Me.txt_service.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_service.CustomButton.UseSelectable = True
        Me.txt_service.CustomButton.Visible = False
        Me.txt_service.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_service.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txt_service.Lines = New String(-1) {}
        Me.txt_service.Location = New System.Drawing.Point(23, 117)
        Me.txt_service.MaxLength = 32767
        Me.txt_service.Name = "txt_service"
        Me.txt_service.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_service.PromptText = "Freight Description"
        Me.txt_service.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_service.SelectedText = ""
        Me.txt_service.SelectionLength = 0
        Me.txt_service.SelectionStart = 0
        Me.txt_service.ShortcutsEnabled = True
        Me.txt_service.Size = New System.Drawing.Size(350, 23)
        Me.txt_service.TabIndex = 1
        Me.txt_service.UseSelectable = True
        Me.txt_service.WaterMark = "Freight Description"
        Me.txt_service.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_service.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Category:"
        '
        'dgv_loading
        '
        Me.dgv_loading.AllowUserToAddRows = False
        Me.dgv_loading.AllowUserToDeleteRows = False
        Me.dgv_loading.AllowUserToResizeRows = False
        Me.dgv_loading.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_loading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_loading.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_loading.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_loading.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_loading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_loading.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_loading.EnableHeadersVisualStyles = False
        Me.dgv_loading.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_loading.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_loading.Location = New System.Drawing.Point(23, 146)
        Me.dgv_loading.Name = "dgv_loading"
        Me.dgv_loading.ReadOnly = True
        Me.dgv_loading.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_loading.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_loading.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_loading.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_loading.Size = New System.Drawing.Size(350, 116)
        Me.dgv_loading.TabIndex = 4
        '
        'btn_Remove
        '
        Me.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Remove.Enabled = False
        Me.btn_Remove.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Remove.Location = New System.Drawing.Point(153, 268)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(107, 31)
        Me.btn_Remove.TabIndex = 6
        Me.btn_Remove.Text = "Remove"
        Me.btn_Remove.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Remove.UseSelectable = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(266, 268)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(107, 31)
        Me.btn_Cancel.TabIndex = 7
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(40, 268)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_Submit.TabIndex = 5
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'cbo_Cat
        '
        Me.cbo_Cat.FormattingEnabled = True
        Me.cbo_Cat.ItemHeight = 23
        Me.cbo_Cat.Items.AddRange(New Object() {"Customer Service", "Operations"})
        Me.cbo_Cat.Location = New System.Drawing.Point(23, 82)
        Me.cbo_Cat.Name = "cbo_Cat"
        Me.cbo_Cat.Size = New System.Drawing.Size(350, 29)
        Me.cbo_Cat.TabIndex = 9
        Me.cbo_Cat.UseSelectable = True
        '
        'Freight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 306)
        Me.Controls.Add(Me.cbo_Cat)
        Me.Controls.Add(Me.btn_Remove)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.dgv_loading)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txt_service)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Freight"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Freight Mode"
        CType(Me.dgv_loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_service As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgv_loading As MetroFramework.Controls.MetroGrid
    Friend WithEvents btn_Remove As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents cbo_Cat As MetroFramework.Controls.MetroComboBox
End Class
