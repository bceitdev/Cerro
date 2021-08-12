<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Status
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
        Me.cbo_status = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.lbl_hwbno = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'cbo_status
        '
        Me.cbo_status.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbo_status.FormattingEnabled = True
        Me.cbo_status.ItemHeight = 19
        Me.cbo_status.Location = New System.Drawing.Point(23, 136)
        Me.cbo_status.Name = "cbo_status"
        Me.cbo_status.Size = New System.Drawing.Size(278, 25)
        Me.cbo_status.TabIndex = 87
        Me.cbo_status.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 114)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel3.TabIndex = 86
        Me.MetroLabel3.Text = "Cargo Status:"
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(194, 188)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_Submit.TabIndex = 88
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'lbl_hwbno
        '
        Me.lbl_hwbno.AutoSize = True
        Me.lbl_hwbno.ForeColor = System.Drawing.Color.Red
        Me.lbl_hwbno.Location = New System.Drawing.Point(23, 79)
        Me.lbl_hwbno.Name = "lbl_hwbno"
        Me.lbl_hwbno.Size = New System.Drawing.Size(0, 0)
        Me.lbl_hwbno.TabIndex = 90
        Me.lbl_hwbno.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel2.TabIndex = 89
        Me.MetroLabel2.Text = "Tracking No.:"
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 234)
        Me.Controls.Add(Me.lbl_hwbno)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.cbo_status)
        Me.Controls.Add(Me.MetroLabel3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Status"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbo_status As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents lbl_hwbno As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
