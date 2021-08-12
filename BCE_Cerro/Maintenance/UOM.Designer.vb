<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UOM
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_divisor = New MetroFramework.Controls.MetroTextBox()
        Me.btn_Remove = New MetroFramework.Controls.MetroButton()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.dgv_loading = New MetroFramework.Controls.MetroGrid()
        Me.txt_service = New MetroFramework.Controls.MetroTextBox()
        CType(Me.dgv_loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_divisor
        '
        Me.txt_divisor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_divisor.CustomButton.Image = Nothing
        Me.txt_divisor.CustomButton.Location = New System.Drawing.Point(328, 1)
        Me.txt_divisor.CustomButton.Name = ""
        Me.txt_divisor.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_divisor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_divisor.CustomButton.TabIndex = 1
        Me.txt_divisor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_divisor.CustomButton.UseSelectable = True
        Me.txt_divisor.CustomButton.Visible = False
        Me.txt_divisor.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_divisor.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txt_divisor.Lines = New String(-1) {}
        Me.txt_divisor.Location = New System.Drawing.Point(23, 92)
        Me.txt_divisor.MaxLength = 32767
        Me.txt_divisor.Name = "txt_divisor"
        Me.txt_divisor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_divisor.PromptText = "UOM Description"
        Me.txt_divisor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_divisor.SelectedText = ""
        Me.txt_divisor.SelectionLength = 0
        Me.txt_divisor.SelectionStart = 0
        Me.txt_divisor.ShortcutsEnabled = True
        Me.txt_divisor.Size = New System.Drawing.Size(350, 23)
        Me.txt_divisor.TabIndex = 8
        Me.txt_divisor.UseSelectable = True
        Me.txt_divisor.WaterMark = "UOM Description"
        Me.txt_divisor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_divisor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_Remove
        '
        Me.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Remove.Enabled = False
        Me.btn_Remove.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Remove.Location = New System.Drawing.Point(153, 236)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(107, 31)
        Me.btn_Remove.TabIndex = 11
        Me.btn_Remove.Text = "Remove"
        Me.btn_Remove.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Remove.UseSelectable = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(266, 236)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(107, 31)
        Me.btn_Cancel.TabIndex = 12
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(40, 236)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_Submit.TabIndex = 10
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_loading.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_loading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_loading.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_loading.EnableHeadersVisualStyles = False
        Me.dgv_loading.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_loading.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_loading.Location = New System.Drawing.Point(23, 121)
        Me.dgv_loading.Name = "dgv_loading"
        Me.dgv_loading.ReadOnly = True
        Me.dgv_loading.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_loading.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_loading.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_loading.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_loading.Size = New System.Drawing.Size(350, 109)
        Me.dgv_loading.TabIndex = 9
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
        Me.txt_service.Location = New System.Drawing.Point(23, 63)
        Me.txt_service.MaxLength = 32767
        Me.txt_service.Name = "txt_service"
        Me.txt_service.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_service.PromptText = "UOM Code"
        Me.txt_service.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_service.SelectedText = ""
        Me.txt_service.SelectionLength = 0
        Me.txt_service.SelectionStart = 0
        Me.txt_service.ShortcutsEnabled = True
        Me.txt_service.Size = New System.Drawing.Size(350, 23)
        Me.txt_service.TabIndex = 7
        Me.txt_service.UseSelectable = True
        Me.txt_service.WaterMark = "UOM Code"
        Me.txt_service.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_service.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 290)
        Me.Controls.Add(Me.txt_divisor)
        Me.Controls.Add(Me.btn_Remove)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.dgv_loading)
        Me.Controls.Add(Me.txt_service)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UOM"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "UOM"
        CType(Me.dgv_loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_divisor As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_Remove As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents dgv_loading As MetroFramework.Controls.MetroGrid
    Friend WithEvents txt_service As MetroFramework.Controls.MetroTextBox
End Class
