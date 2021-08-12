<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POD
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
        Me.lbl_hwbno = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dtp_poddate = New MetroFramework.Controls.MetroDateTime()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cbo_Type = New MetroFramework.Controls.MetroComboBox()
        Me.txt_DocRef = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_force = New MetroFramework.Controls.MetroLink()
        Me.MetroPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_hwbno
        '
        Me.lbl_hwbno.AutoSize = True
        Me.lbl_hwbno.ForeColor = System.Drawing.Color.Red
        Me.lbl_hwbno.Location = New System.Drawing.Point(23, 79)
        Me.lbl_hwbno.Name = "lbl_hwbno"
        Me.lbl_hwbno.Size = New System.Drawing.Size(29, 19)
        Me.lbl_hwbno.TabIndex = 81
        Me.lbl_hwbno.Text = "test"
        Me.lbl_hwbno.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(20, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel2.TabIndex = 80
        Me.MetroLabel2.Text = "Tracking No.:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(20, 107)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(142, 19)
        Me.MetroLabel1.TabIndex = 79
        Me.MetroLabel1.Text = "POD Transmitted Date:"
        '
        'dtp_poddate
        '
        Me.dtp_poddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_poddate.Location = New System.Drawing.Point(20, 129)
        Me.dtp_poddate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_poddate.Name = "dtp_poddate"
        Me.dtp_poddate.Size = New System.Drawing.Size(113, 29)
        Me.dtp_poddate.TabIndex = 78
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(176, 0)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_Submit.TabIndex = 72
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(20, 169)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel3.TabIndex = 84
        Me.MetroLabel3.Text = "Type:"
        '
        'cbo_Type
        '
        Me.cbo_Type.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_Type.FormattingEnabled = True
        Me.cbo_Type.ItemHeight = 19
        Me.cbo_Type.Location = New System.Drawing.Point(20, 191)
        Me.cbo_Type.Name = "cbo_Type"
        Me.cbo_Type.Size = New System.Drawing.Size(280, 25)
        Me.cbo_Type.TabIndex = 85
        Me.cbo_Type.UseSelectable = True
        '
        'txt_DocRef
        '
        '
        '
        '
        Me.txt_DocRef.CustomButton.Image = Nothing
        Me.txt_DocRef.CustomButton.Location = New System.Drawing.Point(258, 1)
        Me.txt_DocRef.CustomButton.Name = ""
        Me.txt_DocRef.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_DocRef.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_DocRef.CustomButton.TabIndex = 1
        Me.txt_DocRef.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_DocRef.CustomButton.UseSelectable = True
        Me.txt_DocRef.CustomButton.Visible = False
        Me.txt_DocRef.Lines = New String(-1) {}
        Me.txt_DocRef.Location = New System.Drawing.Point(20, 246)
        Me.txt_DocRef.MaxLength = 32767
        Me.txt_DocRef.Name = "txt_DocRef"
        Me.txt_DocRef.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_DocRef.PromptText = "Document Reference No."
        Me.txt_DocRef.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DocRef.SelectedText = ""
        Me.txt_DocRef.SelectionLength = 0
        Me.txt_DocRef.SelectionStart = 0
        Me.txt_DocRef.ShortcutsEnabled = True
        Me.txt_DocRef.Size = New System.Drawing.Size(280, 23)
        Me.txt_DocRef.TabIndex = 87
        Me.txt_DocRef.UseSelectable = True
        Me.txt_DocRef.WaterMark = "Document Reference No."
        Me.txt_DocRef.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_DocRef.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(20, 224)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(156, 19)
        Me.MetroLabel4.TabIndex = 86
        Me.MetroLabel4.Text = "Document Reference No."
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel5.Controls.Add(Me.lbl_force)
        Me.MetroPanel5.Controls.Add(Me.btn_Submit)
        Me.MetroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(20, 307)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(283, 31)
        Me.MetroPanel5.TabIndex = 82
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 8)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(100, 15)
        Me.MetroLabel5.TabIndex = 88
        Me.MetroLabel5.Text = "No need for POD?"
        '
        'lbl_force
        '
        Me.lbl_force.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_force.AutoSize = True
        Me.lbl_force.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_force.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lbl_force.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_force.Location = New System.Drawing.Point(99, 4)
        Me.lbl_force.Name = "lbl_force"
        Me.lbl_force.Size = New System.Drawing.Size(53, 23)
        Me.lbl_force.TabIndex = 88
        Me.lbl_force.Text = "Cleared"
        Me.lbl_force.UseCustomForeColor = True
        Me.lbl_force.UseSelectable = True
        '
        'POD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 358)
        Me.Controls.Add(Me.txt_DocRef)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.cbo_Type)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroPanel5)
        Me.Controls.Add(Me.lbl_hwbno)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtp_poddate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POD"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "POD"
        Me.MetroPanel5.ResumeLayout(False)
        Me.MetroPanel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_hwbno As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_poddate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbo_Type As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txt_DocRef As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel5 As MetroFramework.Controls.MetroPanel
    Friend WithEvents lbl_force As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
End Class
