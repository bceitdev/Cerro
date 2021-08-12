<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingTrans
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
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.dtp_Transmit = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Terms = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Duedate = New MetroFramework.Controls.MetroLabel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_ControlNo = New MetroFramework.Controls.MetroLabel()
        Me.lbl_pastdue = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(20, 108)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel9.TabIndex = 132
        Me.MetroLabel9.Text = "Transmittal Date:"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'dtp_Transmit
        '
        Me.dtp_Transmit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Transmit.Location = New System.Drawing.Point(20, 130)
        Me.dtp_Transmit.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_Transmit.Name = "dtp_Transmit"
        Me.dtp_Transmit.Size = New System.Drawing.Size(127, 29)
        Me.dtp_Transmit.TabIndex = 133
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(20, 171)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 134
        Me.MetroLabel1.Text = "Terms:"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'lbl_Terms
        '
        Me.lbl_Terms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Terms.AutoSize = True
        Me.lbl_Terms.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_Terms.Location = New System.Drawing.Point(20, 190)
        Me.lbl_Terms.Name = "lbl_Terms"
        Me.lbl_Terms.Size = New System.Drawing.Size(65, 19)
        Me.lbl_Terms.TabIndex = 135
        Me.lbl_Terms.Text = "lbl_Terms"
        Me.lbl_Terms.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(20, 219)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel3.TabIndex = 136
        Me.MetroLabel3.Text = "Due Date:"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'lbl_Duedate
        '
        Me.lbl_Duedate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Duedate.AutoSize = True
        Me.lbl_Duedate.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_Duedate.Location = New System.Drawing.Point(20, 238)
        Me.lbl_Duedate.Name = "lbl_Duedate"
        Me.lbl_Duedate.Size = New System.Drawing.Size(81, 19)
        Me.lbl_Duedate.TabIndex = 137
        Me.lbl_Duedate.Text = "lbl_Duedate"
        Me.lbl_Duedate.UseCustomBackColor = True
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(20, 335)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(150, 31)
        Me.btn_Submit.TabIndex = 138
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(20, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel2.TabIndex = 139
        Me.MetroLabel2.Text = "Control No.:"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'lbl_ControlNo
        '
        Me.lbl_ControlNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ControlNo.AutoSize = True
        Me.lbl_ControlNo.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_ControlNo.ForeColor = System.Drawing.Color.Red
        Me.lbl_ControlNo.Location = New System.Drawing.Point(20, 79)
        Me.lbl_ControlNo.Name = "lbl_ControlNo"
        Me.lbl_ControlNo.Size = New System.Drawing.Size(93, 19)
        Me.lbl_ControlNo.TabIndex = 140
        Me.lbl_ControlNo.Text = "lbl_ControlNo"
        Me.lbl_ControlNo.UseCustomBackColor = True
        Me.lbl_ControlNo.UseCustomForeColor = True
        '
        'lbl_pastdue
        '
        Me.lbl_pastdue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_pastdue.AutoSize = True
        Me.lbl_pastdue.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_pastdue.Location = New System.Drawing.Point(20, 288)
        Me.lbl_pastdue.Name = "lbl_pastdue"
        Me.lbl_pastdue.Size = New System.Drawing.Size(78, 19)
        Me.lbl_pastdue.TabIndex = 142
        Me.lbl_pastdue.Text = "lbl_pastdue"
        Me.lbl_pastdue.UseCustomBackColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(20, 269)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel5.TabIndex = 141
        Me.MetroLabel5.Text = "Past Due:"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'BillingTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 386)
        Me.Controls.Add(Me.lbl_pastdue)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.lbl_ControlNo)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.lbl_Duedate)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lbl_Terms)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtp_Transmit)
        Me.Controls.Add(Me.MetroLabel9)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BillingTrans"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transmission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_Transmit As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Terms As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Duedate As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_ControlNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_pastdue As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
End Class
