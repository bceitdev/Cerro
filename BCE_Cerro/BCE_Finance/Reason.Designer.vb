<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reason
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
        Me.txt_Reason = New MetroFramework.Controls.MetroTextBox()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txt_Reason
        '
        Me.txt_Reason.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txt_Reason.CustomButton.Image = Nothing
        Me.txt_Reason.CustomButton.Location = New System.Drawing.Point(348, 2)
        Me.txt_Reason.CustomButton.Name = ""
        Me.txt_Reason.CustomButton.Size = New System.Drawing.Size(89, 89)
        Me.txt_Reason.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Reason.CustomButton.TabIndex = 1
        Me.txt_Reason.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Reason.CustomButton.UseSelectable = True
        Me.txt_Reason.CustomButton.Visible = False
        Me.txt_Reason.Lines = New String(-1) {}
        Me.txt_Reason.Location = New System.Drawing.Point(23, 63)
        Me.txt_Reason.MaxLength = 32767
        Me.txt_Reason.Multiline = True
        Me.txt_Reason.Name = "txt_Reason"
        Me.txt_Reason.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Reason.PromptText = "Input reason here"
        Me.txt_Reason.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Reason.SelectedText = ""
        Me.txt_Reason.SelectionLength = 0
        Me.txt_Reason.SelectionStart = 0
        Me.txt_Reason.ShortcutsEnabled = True
        Me.txt_Reason.Size = New System.Drawing.Size(440, 94)
        Me.txt_Reason.TabIndex = 133
        Me.txt_Reason.UseSelectable = True
        Me.txt_Reason.WaterMark = "Input reason here"
        Me.txt_Reason.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Reason.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_Submit
        '
        Me.btn_Submit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(23, 163)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(217, 31)
        Me.btn_Submit.TabIndex = 134
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(246, 163)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(217, 31)
        Me.btn_Cancel.TabIndex = 135
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'Reason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 208)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_Reason)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reason"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reason"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_Reason As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
End Class
