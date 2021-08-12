<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileUpload
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
        Me.btn_Upload = New MetroFramework.Controls.MetroButton()
        Me.dgv_FileUpload = New MetroFramework.Controls.MetroGrid()
        Me.btn_Browse = New MetroFramework.Controls.MetroButton()
        Me.txt_FileName = New MetroFramework.Controls.MetroTextBox()
        CType(Me.dgv_FileUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Upload
        '
        Me.btn_Upload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Upload.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Upload.Location = New System.Drawing.Point(942, 63)
        Me.btn_Upload.Name = "btn_Upload"
        Me.btn_Upload.Size = New System.Drawing.Size(107, 23)
        Me.btn_Upload.TabIndex = 24
        Me.btn_Upload.Text = "Upload"
        Me.btn_Upload.UseSelectable = True
        '
        'dgv_FileUpload
        '
        Me.dgv_FileUpload.AllowUserToAddRows = False
        Me.dgv_FileUpload.AllowUserToDeleteRows = False
        Me.dgv_FileUpload.AllowUserToResizeColumns = False
        Me.dgv_FileUpload.AllowUserToResizeRows = False
        Me.dgv_FileUpload.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_FileUpload.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_FileUpload.BackgroundColor = System.Drawing.Color.White
        Me.dgv_FileUpload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_FileUpload.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_FileUpload.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_FileUpload.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_FileUpload.ColumnHeadersHeight = 33
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_FileUpload.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_FileUpload.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_FileUpload.EnableHeadersVisualStyles = False
        Me.dgv_FileUpload.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_FileUpload.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_FileUpload.Location = New System.Drawing.Point(20, 92)
        Me.dgv_FileUpload.Name = "dgv_FileUpload"
        Me.dgv_FileUpload.ReadOnly = True
        Me.dgv_FileUpload.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_FileUpload.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_FileUpload.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_FileUpload.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_FileUpload.Size = New System.Drawing.Size(1029, 484)
        Me.dgv_FileUpload.TabIndex = 95
        '
        'btn_Browse
        '
        Me.btn_Browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Browse.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Browse.Location = New System.Drawing.Point(906, 63)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(30, 23)
        Me.btn_Browse.TabIndex = 96
        Me.btn_Browse.Text = "..."
        Me.btn_Browse.UseSelectable = True
        '
        'txt_FileName
        '
        '
        '
        '
        Me.txt_FileName.CustomButton.Image = Nothing
        Me.txt_FileName.CustomButton.Location = New System.Drawing.Point(858, 1)
        Me.txt_FileName.CustomButton.Name = ""
        Me.txt_FileName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_FileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_FileName.CustomButton.TabIndex = 1
        Me.txt_FileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_FileName.CustomButton.UseSelectable = True
        Me.txt_FileName.CustomButton.Visible = False
        Me.txt_FileName.Lines = New String(-1) {}
        Me.txt_FileName.Location = New System.Drawing.Point(20, 63)
        Me.txt_FileName.MaxLength = 32767
        Me.txt_FileName.Name = "txt_FileName"
        Me.txt_FileName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_FileName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_FileName.SelectedText = ""
        Me.txt_FileName.SelectionLength = 0
        Me.txt_FileName.SelectionStart = 0
        Me.txt_FileName.ShortcutsEnabled = True
        Me.txt_FileName.Size = New System.Drawing.Size(880, 23)
        Me.txt_FileName.TabIndex = 132
        Me.txt_FileName.UseSelectable = True
        Me.txt_FileName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_FileName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FileUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 596)
        Me.Controls.Add(Me.txt_FileName)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.dgv_FileUpload)
        Me.Controls.Add(Me.btn_Upload)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FileUpload"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "File Upload"
        CType(Me.dgv_FileUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Upload As MetroFramework.Controls.MetroButton
    Friend WithEvents dgv_FileUpload As MetroFramework.Controls.MetroGrid
    Friend WithEvents btn_Browse As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_FileName As MetroFramework.Controls.MetroTextBox
End Class
