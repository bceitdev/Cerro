<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loading
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
        Me.txt_loading = New MetroFramework.Controls.MetroTextBox()
        Me.dgv_loading = New MetroFramework.Controls.MetroGrid()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_Remove = New MetroFramework.Controls.MetroButton()
        CType(Me.dgv_loading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_loading
        '
        Me.txt_loading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_loading.CustomButton.Image = Nothing
        Me.txt_loading.CustomButton.Location = New System.Drawing.Point(328, 1)
        Me.txt_loading.CustomButton.Name = ""
        Me.txt_loading.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_loading.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_loading.CustomButton.TabIndex = 1
        Me.txt_loading.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_loading.CustomButton.UseSelectable = True
        Me.txt_loading.CustomButton.Visible = False
        Me.txt_loading.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txt_loading.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txt_loading.Lines = New String(-1) {}
        Me.txt_loading.Location = New System.Drawing.Point(23, 63)
        Me.txt_loading.MaxLength = 32767
        Me.txt_loading.Name = "txt_loading"
        Me.txt_loading.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_loading.PromptText = "Loading Description"
        Me.txt_loading.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_loading.SelectedText = ""
        Me.txt_loading.SelectionLength = 0
        Me.txt_loading.SelectionStart = 0
        Me.txt_loading.ShortcutsEnabled = True
        Me.txt_loading.Size = New System.Drawing.Size(350, 23)
        Me.txt_loading.TabIndex = 0
        Me.txt_loading.UseSelectable = True
        Me.txt_loading.WaterMark = "Loading Description"
        Me.txt_loading.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_loading.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dgv_loading
        '
        Me.dgv_loading.AllowUserToAddRows = False
        Me.dgv_loading.AllowUserToDeleteRows = False
        Me.dgv_loading.AllowUserToResizeRows = False
        Me.dgv_loading.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_loading.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_loading.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_loading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_loading.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_loading.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_loading.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_loading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_loading.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_loading.EnableHeadersVisualStyles = False
        Me.dgv_loading.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_loading.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_loading.Location = New System.Drawing.Point(23, 92)
        Me.dgv_loading.Name = "dgv_loading"
        Me.dgv_loading.ReadOnly = True
        Me.dgv_loading.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_loading.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_loading.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_loading.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_loading.Size = New System.Drawing.Size(350, 116)
        Me.dgv_loading.TabIndex = 1
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(40, 214)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_Submit.TabIndex = 2
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(266, 214)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(107, 31)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "&Cancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'btn_Remove
        '
        Me.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Remove.Enabled = False
        Me.btn_Remove.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Remove.Location = New System.Drawing.Point(153, 214)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(107, 31)
        Me.btn_Remove.TabIndex = 3
        Me.btn_Remove.Text = "Remove"
        Me.btn_Remove.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Remove.UseSelectable = True
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 254)
        Me.Controls.Add(Me.btn_Remove)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.dgv_loading)
        Me.Controls.Add(Me.txt_loading)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loading"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Loading Mode"
        CType(Me.dgv_loading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_loading As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgv_loading As MetroFramework.Controls.MetroGrid
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Remove As MetroFramework.Controls.MetroButton
End Class
