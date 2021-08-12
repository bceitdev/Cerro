<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PickupDispatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PickupDispatch))
        Me.clb_Driver = New System.Windows.Forms.CheckedListBox()
        Me.mtc_Dispatch = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txt_Driver = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.btn_Next = New MetroFramework.Controls.MetroButton()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.mt_ClosedVan = New MetroFramework.Controls.MetroTile()
        Me.mt_Van = New MetroFramework.Controls.MetroTile()
        Me.mt_Motor = New MetroFramework.Controls.MetroTile()
        Me.lbl_Height = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Width = New MetroFramework.Controls.MetroLabel()
        Me.lbl_Length = New MetroFramework.Controls.MetroLabel()
        Me.lbl_PlateNo = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.btn_Back = New MetroFramework.Controls.MetroButton()
        Me.mtc_Dispatch.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'clb_Driver
        '
        Me.clb_Driver.CheckOnClick = True
        Me.clb_Driver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Driver.HorizontalScrollbar = True
        Me.clb_Driver.Location = New System.Drawing.Point(16, 75)
        Me.clb_Driver.Name = "clb_Driver"
        Me.clb_Driver.Size = New System.Drawing.Size(589, 214)
        Me.clb_Driver.TabIndex = 0
        '
        'mtc_Dispatch
        '
        Me.mtc_Dispatch.Controls.Add(Me.MetroTabPage3)
        Me.mtc_Dispatch.Controls.Add(Me.MetroTabPage2)
        Me.mtc_Dispatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mtc_Dispatch.Location = New System.Drawing.Point(20, 60)
        Me.mtc_Dispatch.Name = "mtc_Dispatch"
        Me.mtc_Dispatch.SelectedIndex = 1
        Me.mtc_Dispatch.Size = New System.Drawing.Size(630, 394)
        Me.mtc_Dispatch.Style = MetroFramework.MetroColorStyle.Teal
        Me.mtc_Dispatch.TabIndex = 66
        Me.mtc_Dispatch.UseSelectable = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage3.Controls.Add(Me.txt_Driver)
        Me.MetroTabPage3.Controls.Add(Me.clb_Driver)
        Me.MetroTabPage3.Controls.Add(Me.MetroPanel2)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(622, 352)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Personnel"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(16, 53)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel6.TabIndex = 70
        Me.MetroLabel6.Text = "Cargo Associate"
        '
        'txt_Driver
        '
        '
        '
        '
        Me.txt_Driver.CustomButton.Image = Nothing
        Me.txt_Driver.CustomButton.Location = New System.Drawing.Point(567, 1)
        Me.txt_Driver.CustomButton.Name = ""
        Me.txt_Driver.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Driver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Driver.CustomButton.TabIndex = 1
        Me.txt_Driver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Driver.CustomButton.UseSelectable = True
        Me.txt_Driver.CustomButton.Visible = False
        Me.txt_Driver.Lines = New String(-1) {}
        Me.txt_Driver.Location = New System.Drawing.Point(16, 12)
        Me.txt_Driver.MaxLength = 32767
        Me.txt_Driver.Name = "txt_Driver"
        Me.txt_Driver.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Driver.PromptText = "Driver Name"
        Me.txt_Driver.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Driver.SelectedText = ""
        Me.txt_Driver.SelectionLength = 0
        Me.txt_Driver.SelectionStart = 0
        Me.txt_Driver.ShortcutsEnabled = True
        Me.txt_Driver.Size = New System.Drawing.Size(589, 23)
        Me.txt_Driver.TabIndex = 69
        Me.txt_Driver.UseSelectable = True
        Me.txt_Driver.WaterMark = "Driver Name"
        Me.txt_Driver.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Driver.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.btn_Next)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 301)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(620, 49)
        Me.MetroPanel2.TabIndex = 68
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'btn_Next
        '
        Me.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Next.Location = New System.Drawing.Point(498, 9)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(107, 31)
        Me.btn_Next.TabIndex = 39
        Me.btn_Next.Text = "Next"
        Me.btn_Next.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Next.UseSelectable = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage2.Controls.Add(Me.mt_ClosedVan)
        Me.MetroTabPage2.Controls.Add(Me.mt_Van)
        Me.MetroTabPage2.Controls.Add(Me.mt_Motor)
        Me.MetroTabPage2.Controls.Add(Me.lbl_Height)
        Me.MetroTabPage2.Controls.Add(Me.lbl_Width)
        Me.MetroTabPage2.Controls.Add(Me.lbl_Length)
        Me.MetroTabPage2.Controls.Add(Me.lbl_PlateNo)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage2.Controls.Add(Me.MetroPanel1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(622, 352)
        Me.MetroTabPage2.TabIndex = 3
        Me.MetroTabPage2.Text = "Vehicle"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'mt_ClosedVan
        '
        Me.mt_ClosedVan.ActiveControl = Nothing
        Me.mt_ClosedVan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_ClosedVan.Location = New System.Drawing.Point(254, 12)
        Me.mt_ClosedVan.Name = "mt_ClosedVan"
        Me.mt_ClosedVan.Size = New System.Drawing.Size(113, 102)
        Me.mt_ClosedVan.TabIndex = 81
        Me.mt_ClosedVan.TileImage = CType(resources.GetObject("mt_ClosedVan.TileImage"), System.Drawing.Image)
        Me.mt_ClosedVan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mt_ClosedVan.UseSelectable = True
        Me.mt_ClosedVan.UseTileImage = True
        '
        'mt_Van
        '
        Me.mt_Van.ActiveControl = Nothing
        Me.mt_Van.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_Van.Location = New System.Drawing.Point(135, 12)
        Me.mt_Van.Name = "mt_Van"
        Me.mt_Van.Size = New System.Drawing.Size(113, 102)
        Me.mt_Van.TabIndex = 80
        Me.mt_Van.TileImage = CType(resources.GetObject("mt_Van.TileImage"), System.Drawing.Image)
        Me.mt_Van.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mt_Van.UseSelectable = True
        Me.mt_Van.UseTileImage = True
        '
        'mt_Motor
        '
        Me.mt_Motor.ActiveControl = Nothing
        Me.mt_Motor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_Motor.Location = New System.Drawing.Point(16, 12)
        Me.mt_Motor.Name = "mt_Motor"
        Me.mt_Motor.Size = New System.Drawing.Size(113, 102)
        Me.mt_Motor.TabIndex = 78
        Me.mt_Motor.Text = "Motorcycle"
        Me.mt_Motor.UseSelectable = True
        '
        'lbl_Height
        '
        Me.lbl_Height.AutoSize = True
        Me.lbl_Height.Location = New System.Drawing.Point(88, 229)
        Me.lbl_Height.Name = "lbl_Height"
        Me.lbl_Height.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Height.TabIndex = 77
        '
        'lbl_Width
        '
        Me.lbl_Width.AutoSize = True
        Me.lbl_Width.Location = New System.Drawing.Point(88, 201)
        Me.lbl_Width.Name = "lbl_Width"
        Me.lbl_Width.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Width.TabIndex = 76
        '
        'lbl_Length
        '
        Me.lbl_Length.AutoSize = True
        Me.lbl_Length.Location = New System.Drawing.Point(88, 172)
        Me.lbl_Length.Name = "lbl_Length"
        Me.lbl_Length.Size = New System.Drawing.Size(0, 0)
        Me.lbl_Length.TabIndex = 75
        '
        'lbl_PlateNo
        '
        Me.lbl_PlateNo.AutoSize = True
        Me.lbl_PlateNo.Location = New System.Drawing.Point(88, 143)
        Me.lbl_PlateNo.Name = "lbl_PlateNo"
        Me.lbl_PlateNo.Size = New System.Drawing.Size(0, 0)
        Me.lbl_PlateNo.TabIndex = 74
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(16, 229)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel5.TabIndex = 73
        Me.MetroLabel5.Text = "Height:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(16, 201)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel4.TabIndex = 72
        Me.MetroLabel4.Text = "Width:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(16, 172)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel3.TabIndex = 71
        Me.MetroLabel3.Text = "Length:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(16, 143)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 70
        Me.MetroLabel2.Text = "Plate No.:"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btn_Submit)
        Me.MetroPanel1.Controls.Add(Me.btn_Back)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 301)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(620, 49)
        Me.MetroPanel1.TabIndex = 67
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(498, 9)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_Submit.TabIndex = 39
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'btn_Back
        '
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Back.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Back.Location = New System.Drawing.Point(385, 9)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(107, 31)
        Me.btn_Back.TabIndex = 40
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseSelectable = True
        '
        'PickupDispatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 474)
        Me.Controls.Add(Me.mtc_Dispatch)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PickupDispatch"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Pickup Dispatch"
        Me.mtc_Dispatch.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clb_Driver As CheckedListBox
    Friend WithEvents mtc_Dispatch As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Back As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_Driver As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mt_ClosedVan As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_Van As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_Motor As MetroFramework.Controls.MetroTile
    Friend WithEvents lbl_Height As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Width As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_Length As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_PlateNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_Next As MetroFramework.Controls.MetroButton
End Class
