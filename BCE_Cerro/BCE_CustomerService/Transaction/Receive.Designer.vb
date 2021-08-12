<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Receive
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
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.dtp_recdate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_recby = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_hwbno = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(20, 169)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel17.TabIndex = 59
        Me.MetroLabel17.Text = "Received by:"
        '
        'dtp_recdate
        '
        Me.dtp_recdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_recdate.Location = New System.Drawing.Point(20, 129)
        Me.dtp_recdate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_recdate.Name = "dtp_recdate"
        Me.dtp_recdate.Size = New System.Drawing.Size(113, 29)
        Me.dtp_recdate.TabIndex = 61
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(20, 107)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel1.TabIndex = 62
        Me.MetroLabel1.Text = "Received Date:"
        '
        'txt_recby
        '
        '
        '
        '
        Me.txt_recby.CustomButton.Image = Nothing
        Me.txt_recby.CustomButton.Location = New System.Drawing.Point(261, 1)
        Me.txt_recby.CustomButton.Name = ""
        Me.txt_recby.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_recby.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_recby.CustomButton.TabIndex = 1
        Me.txt_recby.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_recby.CustomButton.UseSelectable = True
        Me.txt_recby.CustomButton.Visible = False
        Me.txt_recby.Lines = New String(-1) {}
        Me.txt_recby.Location = New System.Drawing.Point(20, 191)
        Me.txt_recby.MaxLength = 32767
        Me.txt_recby.Name = "txt_recby"
        Me.txt_recby.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_recby.PromptText = "Receiver's Name"
        Me.txt_recby.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_recby.SelectedText = ""
        Me.txt_recby.SelectionLength = 0
        Me.txt_recby.SelectionStart = 0
        Me.txt_recby.ShortcutsEnabled = True
        Me.txt_recby.Size = New System.Drawing.Size(283, 23)
        Me.txt_recby.TabIndex = 63
        Me.txt_recby.UseSelectable = True
        Me.txt_recby.WaterMark = "Receiver's Name"
        Me.txt_recby.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_recby.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Controls.Add(Me.btn_Submit)
        Me.MetroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(20, 236)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(283, 31)
        Me.MetroPanel5.TabIndex = 74
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
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
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(20, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel2.TabIndex = 76
        Me.MetroLabel2.Text = "Tracking No.:"
        '
        'lbl_hwbno
        '
        Me.lbl_hwbno.AutoSize = True
        Me.lbl_hwbno.ForeColor = System.Drawing.Color.Red
        Me.lbl_hwbno.Location = New System.Drawing.Point(23, 79)
        Me.lbl_hwbno.Name = "lbl_hwbno"
        Me.lbl_hwbno.Size = New System.Drawing.Size(0, 0)
        Me.lbl_hwbno.TabIndex = 77
        Me.lbl_hwbno.UseCustomForeColor = True
        '
        'Receive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 287)
        Me.Controls.Add(Me.lbl_hwbno)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroPanel5)
        Me.Controls.Add(Me.txt_recby)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtp_recdate)
        Me.Controls.Add(Me.MetroLabel17)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Receive"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Receive"
        Me.MetroPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_recdate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_recby As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel5 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_hwbno As MetroFramework.Controls.MetroLabel
End Class
