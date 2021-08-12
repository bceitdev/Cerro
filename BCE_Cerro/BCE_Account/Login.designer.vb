<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_ForgotPass = New System.Windows.Forms.Label()
        Me.txt_Pwd = New System.Windows.Forms.TextBox()
        Me.txt_EMPLID = New System.Windows.Forms.TextBox()
        Me.sign_in = New System.Windows.Forms.PictureBox()
        Me.btn_login = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.sign_in, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), System.Drawing.Image)
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo.Location = New System.Drawing.Point(2, 19)
        Me.logo.Margin = New System.Windows.Forms.Padding(2)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(97, 53)
        Me.logo.TabIndex = 5
        Me.logo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.lbl_ForgotPass)
        Me.Panel1.Controls.Add(Me.txt_Pwd)
        Me.Panel1.Controls.Add(Me.txt_EMPLID)
        Me.Panel1.Controls.Add(Me.sign_in)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.logo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 499)
        Me.Panel1.TabIndex = 6
        '
        'lbl_ForgotPass
        '
        Me.lbl_ForgotPass.AutoSize = True
        Me.lbl_ForgotPass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ForgotPass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_ForgotPass.Location = New System.Drawing.Point(163, 342)
        Me.lbl_ForgotPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ForgotPass.Name = "lbl_ForgotPass"
        Me.lbl_ForgotPass.Size = New System.Drawing.Size(82, 13)
        Me.lbl_ForgotPass.TabIndex = 12
        Me.lbl_ForgotPass.Text = "forgot password"
        '
        'txt_Pwd
        '
        Me.txt_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Pwd.Location = New System.Drawing.Point(67, 289)
        Me.txt_Pwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Pwd.Name = "txt_Pwd"
        Me.txt_Pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Pwd.Size = New System.Drawing.Size(215, 13)
        Me.txt_Pwd.TabIndex = 15
        '
        'txt_EMPLID
        '
        Me.txt_EMPLID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_EMPLID.Location = New System.Drawing.Point(67, 236)
        Me.txt_EMPLID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_EMPLID.Name = "txt_EMPLID"
        Me.txt_EMPLID.Size = New System.Drawing.Size(215, 13)
        Me.txt_EMPLID.TabIndex = 14
        '
        'sign_in
        '
        Me.sign_in.BackColor = System.Drawing.Color.Transparent
        Me.sign_in.BackgroundImage = CType(resources.GetObject("sign_in.BackgroundImage"), System.Drawing.Image)
        Me.sign_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sign_in.Location = New System.Drawing.Point(83, 192)
        Me.sign_in.Margin = New System.Windows.Forms.Padding(2)
        Me.sign_in.Name = "sign_in"
        Me.sign_in.Size = New System.Drawing.Size(37, 14)
        Me.sign_in.TabIndex = 12
        Me.sign_in.TabStop = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BackgroundImage = CType(resources.GetObject("btn_login.BackgroundImage"), System.Drawing.Image)
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.Location = New System.Drawing.Point(258, 331)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(41, 35)
        Me.btn_login.TabIndex = 8
        Me.btn_login.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(33, 278)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(267, 34)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(32, 225)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 34)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(34, 114)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(99, 30)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(37, 144)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(189, 27)
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(40, 192)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(33, 14)
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(856, 456)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.sign_in, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents sign_in As System.Windows.Forms.PictureBox
    Friend WithEvents txt_Pwd As System.Windows.Forms.TextBox
    Friend WithEvents txt_EMPLID As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_ForgotPass As System.Windows.Forms.Label

End Class
