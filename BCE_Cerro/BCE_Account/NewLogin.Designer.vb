<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewLogin))
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.lbl_RecPass = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Reg = New MetroFramework.Controls.MetroLink()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_SignIn = New MetroFramework.Controls.MetroButton()
        Me.txt_pwd = New MetroFramework.Controls.MetroTextBox()
        Me.txt_EMPLID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel2.BackColor = System.Drawing.Color.Turquoise
        Me.MetroPanel2.Controls.Add(Me.PictureBox3)
        Me.MetroPanel2.Controls.Add(Me.PictureBox2)
        Me.MetroPanel2.Controls.Add(Me.PictureBox1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(428, 60)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(943, 604)
        Me.MetroPanel2.TabIndex = 1
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(180, 210)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(583, 17)
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(195, 240)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(553, 184)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(195, 162)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 42)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.lbl_RecPass)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.lbl_Reg)
        Me.MetroPanel1.Controls.Add(Me.Panel3)
        Me.MetroPanel1.Controls.Add(Me.Panel4)
        Me.MetroPanel1.Controls.Add(Me.btn_SignIn)
        Me.MetroPanel1.Controls.Add(Me.txt_pwd)
        Me.MetroPanel1.Controls.Add(Me.txt_EMPLID)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(402, 604)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'lbl_RecPass
        '
        Me.lbl_RecPass.AutoSize = True
        Me.lbl_RecPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_RecPass.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lbl_RecPass.ForeColor = System.Drawing.Color.Black
        Me.lbl_RecPass.Location = New System.Drawing.Point(217, 400)
        Me.lbl_RecPass.Name = "lbl_RecPass"
        Me.lbl_RecPass.Size = New System.Drawing.Size(107, 23)
        Me.lbl_RecPass.TabIndex = 33
        Me.lbl_RecPass.Text = "Recover Password"
        Me.lbl_RecPass.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_RecPass.UseCustomForeColor = True
        Me.lbl_RecPass.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel3.Location = New System.Drawing.Point(79, 400)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(140, 15)
        Me.MetroLabel3.TabIndex = 32
        Me.MetroLabel3.Text = "Forgotten your password?"
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.MetroLabel2.Location = New System.Drawing.Point(105, 382)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(131, 15)
        Me.MetroLabel2.TabIndex = 31
        Me.MetroLabel2.Text = "Do you have an account?"
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'lbl_Reg
        '
        Me.lbl_Reg.AutoSize = True
        Me.lbl_Reg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_Reg.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lbl_Reg.ForeColor = System.Drawing.Color.Black
        Me.lbl_Reg.Location = New System.Drawing.Point(233, 382)
        Me.lbl_Reg.Name = "lbl_Reg"
        Me.lbl_Reg.Size = New System.Drawing.Size(56, 23)
        Me.lbl_Reg.TabIndex = 30
        Me.lbl_Reg.Text = "Register"
        Me.lbl_Reg.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbl_Reg.UseCustomForeColor = True
        Me.lbl_Reg.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(51, 365)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(299, 1)
        Me.Panel3.TabIndex = 29
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(51, 218)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(299, 1)
        Me.Panel4.TabIndex = 28
        '
        'btn_SignIn
        '
        Me.btn_SignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SignIn.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_SignIn.Location = New System.Drawing.Point(51, 312)
        Me.btn_SignIn.Name = "btn_SignIn"
        Me.btn_SignIn.Size = New System.Drawing.Size(299, 31)
        Me.btn_SignIn.TabIndex = 27
        Me.btn_SignIn.Text = "Sign In"
        Me.btn_SignIn.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_SignIn.UseSelectable = True
        '
        'txt_pwd
        '
        '
        '
        '
        Me.txt_pwd.CustomButton.Image = Nothing
        Me.txt_pwd.CustomButton.Location = New System.Drawing.Point(277, 1)
        Me.txt_pwd.CustomButton.Name = ""
        Me.txt_pwd.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_pwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_pwd.CustomButton.TabIndex = 1
        Me.txt_pwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_pwd.CustomButton.UseSelectable = True
        Me.txt_pwd.CustomButton.Visible = False
        Me.txt_pwd.Lines = New String(-1) {}
        Me.txt_pwd.Location = New System.Drawing.Point(51, 268)
        Me.txt_pwd.MaxLength = 32767
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_pwd.PromptText = "Password"
        Me.txt_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_pwd.SelectedText = ""
        Me.txt_pwd.SelectionLength = 0
        Me.txt_pwd.SelectionStart = 0
        Me.txt_pwd.ShortcutsEnabled = True
        Me.txt_pwd.Size = New System.Drawing.Size(299, 23)
        Me.txt_pwd.TabIndex = 26
        Me.txt_pwd.UseSelectable = True
        Me.txt_pwd.WaterMark = "Password"
        Me.txt_pwd.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_pwd.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_EMPLID
        '
        '
        '
        '
        Me.txt_EMPLID.CustomButton.Image = Nothing
        Me.txt_EMPLID.CustomButton.Location = New System.Drawing.Point(277, 1)
        Me.txt_EMPLID.CustomButton.Name = ""
        Me.txt_EMPLID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_EMPLID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_EMPLID.CustomButton.TabIndex = 1
        Me.txt_EMPLID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_EMPLID.CustomButton.UseSelectable = True
        Me.txt_EMPLID.CustomButton.Visible = False
        Me.txt_EMPLID.Lines = New String(-1) {}
        Me.txt_EMPLID.Location = New System.Drawing.Point(51, 239)
        Me.txt_EMPLID.MaxLength = 32767
        Me.txt_EMPLID.Multiline = True
        Me.txt_EMPLID.Name = "txt_EMPLID"
        Me.txt_EMPLID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_EMPLID.PromptText = "Employee ID"
        Me.txt_EMPLID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_EMPLID.SelectedText = ""
        Me.txt_EMPLID.SelectionLength = 0
        Me.txt_EMPLID.SelectionStart = 0
        Me.txt_EMPLID.ShortcutsEnabled = True
        Me.txt_EMPLID.Size = New System.Drawing.Size(299, 23)
        Me.txt_EMPLID.TabIndex = 25
        Me.txt_EMPLID.UseSelectable = True
        Me.txt_EMPLID.WaterMark = "Employee ID"
        Me.txt_EMPLID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_EMPLID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(51, 178)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(200, 25)
        Me.MetroLabel1.TabIndex = 24
        Me.MetroLabel1.Text = "Sign In to your Account"
        '
        'NewLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1394, 684)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "NewLogin"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Sign In"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents lbl_RecPass As MetroFramework.Controls.MetroLink
    Friend WithEvents lbl_Reg As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_SignIn As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_pwd As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_EMPLID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
