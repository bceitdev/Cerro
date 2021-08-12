<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SwitchStation
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
        Me.cbo_BranchCode = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'cbo_BranchCode
        '
        Me.cbo_BranchCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_BranchCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_BranchCode.FormattingEnabled = True
        Me.cbo_BranchCode.ItemHeight = 23
        Me.cbo_BranchCode.Location = New System.Drawing.Point(81, 63)
        Me.cbo_BranchCode.Name = "cbo_BranchCode"
        Me.cbo_BranchCode.Size = New System.Drawing.Size(274, 29)
        Me.cbo_BranchCode.Style = MetroFramework.MetroColorStyle.Black
        Me.cbo_BranchCode.TabIndex = 12
        Me.cbo_BranchCode.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 73)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel1.TabIndex = 13
        Me.MetroLabel1.Text = "Station:"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(263, 112)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(92, 31)
        Me.btn_Cancel.TabIndex = 24
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(165, 112)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(92, 31)
        Me.btn_Submit.TabIndex = 23
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'SwitchStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 157)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cbo_BranchCode)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SwitchStation"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Switch Station"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbo_BranchCode As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
End Class
