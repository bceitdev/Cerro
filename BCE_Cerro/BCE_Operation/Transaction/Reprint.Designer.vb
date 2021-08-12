<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reprint
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
        Me.MetroPanel6 = New MetroFramework.Controls.MetroPanel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.txt_Search = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel6
        '
        Me.MetroPanel6.Controls.Add(Me.btn_Submit)
        Me.MetroPanel6.Controls.Add(Me.btn_Cancel)
        Me.MetroPanel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel6.HorizontalScrollbarBarColor = True
        Me.MetroPanel6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.HorizontalScrollbarSize = 10
        Me.MetroPanel6.Location = New System.Drawing.Point(20, 125)
        Me.MetroPanel6.Name = "MetroPanel6"
        Me.MetroPanel6.Size = New System.Drawing.Size(380, 37)
        Me.MetroPanel6.TabIndex = 66
        Me.MetroPanel6.VerticalScrollbarBarColor = True
        Me.MetroPanel6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.VerticalScrollbarSize = 10
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(166, 0)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 37)
        Me.btn_Submit.TabIndex = 22
        Me.btn_Submit.Text = "&Reprint"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(273, 0)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(107, 37)
        Me.btn_Cancel.TabIndex = 61
        Me.btn_Cancel.Text = "C&ancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'txt_Search
        '
        Me.txt_Search.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txt_Search.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_Search.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_Search.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_Search.CustomButton.Image = Nothing
        Me.txt_Search.CustomButton.Location = New System.Drawing.Point(358, 1)
        Me.txt_Search.CustomButton.Name = ""
        Me.txt_Search.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Search.CustomButton.TabIndex = 1
        Me.txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Search.CustomButton.UseSelectable = True
        Me.txt_Search.CustomButton.Visible = False
        Me.txt_Search.Lines = New String(-1) {}
        Me.txt_Search.Location = New System.Drawing.Point(20, 82)
        Me.txt_Search.MaxLength = 32767
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Search.PromptText = "Search HWB here"
        Me.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Search.SelectedText = ""
        Me.txt_Search.SelectionLength = 0
        Me.txt_Search.SelectionStart = 0
        Me.txt_Search.ShortcutsEnabled = True
        Me.txt_Search.ShowClearButton = True
        Me.txt_Search.Size = New System.Drawing.Size(380, 23)
        Me.txt_Search.TabIndex = 101
        Me.txt_Search.UseSelectable = True
        Me.txt_Search.WaterMark = "Search HWB here"
        Me.txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Search.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel1.TabIndex = 102
        Me.MetroLabel1.Text = "HWB No."
        '
        'Reprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 182)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.MetroPanel6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reprint"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reprint"
        Me.MetroPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroPanel6 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_Search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
