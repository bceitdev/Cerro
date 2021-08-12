<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_EMPLID = New MetroFramework.Controls.MetroTextBox()
        Me.txt_Pwd = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_SignIn = New MetroFramework.Controls.MetroButton()
        Me.lbl_Req = New MetroFramework.Controls.MetroLink()
        Me.lbl_ForgotPwd = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(22, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 1)
        Me.Panel1.TabIndex = 0
        '
        'txt_EMPLID
        '
        '
        '
        '
        Me.txt_EMPLID.CustomButton.Image = Nothing
        Me.txt_EMPLID.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txt_EMPLID.CustomButton.Name = ""
        Me.txt_EMPLID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_EMPLID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_EMPLID.CustomButton.TabIndex = 1
        Me.txt_EMPLID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_EMPLID.CustomButton.UseSelectable = True
        Me.txt_EMPLID.CustomButton.Visible = False
        Me.txt_EMPLID.Lines = New String(-1) {}
        Me.txt_EMPLID.Location = New System.Drawing.Point(22, 117)
        Me.txt_EMPLID.MaxLength = 32767
        Me.txt_EMPLID.Name = "txt_EMPLID"
        Me.txt_EMPLID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_EMPLID.PromptText = "Employee ID"
        Me.txt_EMPLID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_EMPLID.SelectedText = ""
        Me.txt_EMPLID.SelectionLength = 0
        Me.txt_EMPLID.SelectionStart = 0
        Me.txt_EMPLID.ShortcutsEnabled = True
        Me.txt_EMPLID.Size = New System.Drawing.Size(254, 23)
        Me.txt_EMPLID.TabIndex = 2
        Me.txt_EMPLID.UseSelectable = True
        Me.txt_EMPLID.WaterMark = "Employee ID"
        Me.txt_EMPLID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_EMPLID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_Pwd
        '
        '
        '
        '
        Me.txt_Pwd.CustomButton.Image = Nothing
        Me.txt_Pwd.CustomButton.Location = New System.Drawing.Point(233, 1)
        Me.txt_Pwd.CustomButton.Name = ""
        Me.txt_Pwd.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Pwd.CustomButton.TabIndex = 1
        Me.txt_Pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Pwd.CustomButton.UseSelectable = True
        Me.txt_Pwd.CustomButton.Visible = False
        Me.txt_Pwd.Lines = New String(-1) {}
        Me.txt_Pwd.Location = New System.Drawing.Point(22, 146)
        Me.txt_Pwd.MaxLength = 32767
        Me.txt_Pwd.Name = "txt_Pwd"
        Me.txt_Pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_Pwd.PromptText = "Password"
        Me.txt_Pwd.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Pwd.SelectedText = ""
        Me.txt_Pwd.SelectionLength = 0
        Me.txt_Pwd.SelectionStart = 0
        Me.txt_Pwd.ShortcutsEnabled = True
        Me.txt_Pwd.Size = New System.Drawing.Size(255, 23)
        Me.txt_Pwd.TabIndex = 4
        Me.txt_Pwd.UseSelectable = True
        Me.txt_Pwd.UseSystemPasswordChar = True
        Me.txt_Pwd.WaterMark = "Password"
        Me.txt_Pwd.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Pwd.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(22, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(254, 1)
        Me.Panel2.TabIndex = 5
        '
        'btn_SignIn
        '
        Me.btn_SignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SignIn.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_SignIn.Location = New System.Drawing.Point(185, 185)
        Me.btn_SignIn.Name = "btn_SignIn"
        Me.btn_SignIn.Size = New System.Drawing.Size(92, 31)
        Me.btn_SignIn.TabIndex = 6
        Me.btn_SignIn.Text = "Sign In"
        Me.btn_SignIn.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_SignIn.UseSelectable = True
        '
        'lbl_Req
        '
        Me.lbl_Req.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_Req.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lbl_Req.Location = New System.Drawing.Point(22, 268)
        Me.lbl_Req.Name = "lbl_Req"
        Me.lbl_Req.Size = New System.Drawing.Size(130, 23)
        Me.lbl_Req.TabIndex = 7
        Me.lbl_Req.Text = "Request an account?"
        Me.lbl_Req.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_Req.UseSelectable = True
        '
        'lbl_ForgotPwd
        '
        Me.lbl_ForgotPwd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_ForgotPwd.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lbl_ForgotPwd.Location = New System.Drawing.Point(147, 268)
        Me.lbl_ForgotPwd.Name = "lbl_ForgotPwd"
        Me.lbl_ForgotPwd.Size = New System.Drawing.Size(130, 23)
        Me.lbl_ForgotPwd.TabIndex = 8
        Me.lbl_ForgotPwd.Text = "Forgot Password?"
        Me.lbl_ForgotPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_ForgotPwd.UseSelectable = True
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 561)
        Me.Controls.Add(Me.lbl_ForgotPwd)
        Me.Controls.Add(Me.lbl_Req)
        Me.Controls.Add(Me.btn_SignIn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_Pwd)
        Me.Controls.Add(Me.txt_EMPLID)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignIn"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Sign In"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_EMPLID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_Pwd As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_SignIn As MetroFramework.Controls.MetroButton
    Friend WithEvents lbl_Req As MetroFramework.Controls.MetroLink
    Friend WithEvents lbl_ForgotPwd As MetroFramework.Controls.MetroLink
End Class
