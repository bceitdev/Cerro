<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcctReq
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AcctReq))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_EMPLID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_ImmHead = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Pos = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Dep = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Fullname = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_EmailAdd = New MetroFramework.Controls.MetroLabel()
        Me.lbl_MobNo = New MetroFramework.Controls.MetroLabel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel1.Location = New System.Drawing.Point(22, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 1)
        Me.Panel1.TabIndex = 1
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
        Me.txt_EMPLID.Location = New System.Drawing.Point(22, 149)
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
        Me.txt_EMPLID.TabIndex = 3
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
        Me.MetroLabel1.Location = New System.Drawing.Point(22, 97)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(189, 25)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Employee Information"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(22, 213)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Department:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(22, 243)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Position:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(22, 273)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "Immediate Head:"
        '
        'lbl_ImmHead
        '
        Me.lbl_ImmHead.AutoSize = True
        Me.lbl_ImmHead.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_ImmHead.Location = New System.Drawing.Point(138, 273)
        Me.lbl_ImmHead.Name = "lbl_ImmHead"
        Me.lbl_ImmHead.Size = New System.Drawing.Size(0, 0)
        Me.lbl_ImmHead.TabIndex = 8
        '
        'lbl_Pos
        '
        Me.lbl_Pos.AutoSize = True
        Me.lbl_Pos.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_Pos.Location = New System.Drawing.Point(138, 243)
        Me.lbl_Pos.Name = "lbl_Pos"
        Me.lbl_Pos.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Pos.TabIndex = 9
        '
        'lbl_Dep
        '
        Me.lbl_Dep.AutoSize = True
        Me.lbl_Dep.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_Dep.Location = New System.Drawing.Point(138, 213)
        Me.lbl_Dep.Name = "lbl_Dep"
        Me.lbl_Dep.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Dep.TabIndex = 10
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(22, 184)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel5.TabIndex = 11
        Me.MetroLabel5.Text = "Fullname:"
        '
        'lbl_Fullname
        '
        Me.lbl_Fullname.AutoSize = True
        Me.lbl_Fullname.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_Fullname.Location = New System.Drawing.Point(138, 184)
        Me.lbl_Fullname.Name = "lbl_Fullname"
        Me.lbl_Fullname.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Fullname.TabIndex = 12
        '
        'MetroLabel7
        '
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.Location = New System.Drawing.Point(22, 395)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(578, 48)
        Me.MetroLabel7.TabIndex = 15
        Me.MetroLabel7.Text = resources.GetString("MetroLabel7.Text")
        Me.MetroLabel7.WrapToLine = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(22, 304)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel8.TabIndex = 16
        Me.MetroLabel8.Text = "Email Address:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(23, 334)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel9.TabIndex = 17
        Me.MetroLabel9.Text = "Mobile No.:"
        '
        'lbl_EmailAdd
        '
        Me.lbl_EmailAdd.AutoSize = True
        Me.lbl_EmailAdd.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_EmailAdd.Location = New System.Drawing.Point(138, 304)
        Me.lbl_EmailAdd.Name = "lbl_EmailAdd"
        Me.lbl_EmailAdd.Size = New System.Drawing.Size(0, 0)
        Me.lbl_EmailAdd.TabIndex = 18
        '
        'lbl_MobNo
        '
        Me.lbl_MobNo.AutoSize = True
        Me.lbl_MobNo.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lbl_MobNo.Location = New System.Drawing.Point(138, 334)
        Me.lbl_MobNo.Name = "lbl_MobNo"
        Me.lbl_MobNo.Size = New System.Drawing.Size(0, 0)
        Me.lbl_MobNo.TabIndex = 19
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(411, 456)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(92, 31)
        Me.btn_Submit.TabIndex = 20
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(509, 456)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(92, 31)
        Me.btn_Cancel.TabIndex = 21
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel2.Location = New System.Drawing.Point(23, 366)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(578, 1)
        Me.Panel2.TabIndex = 13
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.Location = New System.Drawing.Point(22, 131)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(318, 15)
        Me.MetroLabel10.TabIndex = 22
        Me.MetroLabel10.Text = "Input your Employee ID for the verification of your informations"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.ForeColor = System.Drawing.Color.Red
        Me.MetroLabel6.Location = New System.Drawing.Point(46, 377)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(52, 15)
        Me.MetroLabel6.TabIndex = 23
        Me.MetroLabel6.Text = "NOTICE:"
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 300
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 60
        Me.ToolTip1.ToolTipTitle = "Employee ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(278, 152)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "A unique identification as employee indicated at the back/front of your Company I" &
        "D")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(23, 372)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'AcctReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 497)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.lbl_MobNo)
        Me.Controls.Add(Me.lbl_EmailAdd)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_Fullname)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.lbl_Dep)
        Me.Controls.Add(Me.lbl_Pos)
        Me.Controls.Add(Me.lbl_ImmHead)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txt_EMPLID)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "AcctReq"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "User Account Requisition"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_EMPLID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_ImmHead As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Pos As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Dep As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Fullname As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_EmailAdd As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_MobNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox2 As PictureBox
End Class
