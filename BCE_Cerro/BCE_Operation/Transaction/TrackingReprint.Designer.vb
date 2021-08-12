<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackingReprint
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
        Me.crv_HWB = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btn_Gen = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'crv_HWB
        '
        Me.crv_HWB.ActiveViewIndex = -1
        Me.crv_HWB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_HWB.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_HWB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_HWB.Location = New System.Drawing.Point(20, 60)
        Me.crv_HWB.Name = "crv_HWB"
        Me.crv_HWB.ShowCloseButton = False
        Me.crv_HWB.ShowGroupTreeButton = False
        Me.crv_HWB.ShowLogo = False
        Me.crv_HWB.ShowParameterPanelButton = False
        Me.crv_HWB.ShowPrintButton = False
        Me.crv_HWB.Size = New System.Drawing.Size(866, 575)
        Me.crv_HWB.TabIndex = 33
        Me.crv_HWB.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btn_Gen
        '
        Me.btn_Gen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Gen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Gen.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Gen.Location = New System.Drawing.Point(20, 635)
        Me.btn_Gen.Name = "btn_Gen"
        Me.btn_Gen.Size = New System.Drawing.Size(866, 31)
        Me.btn_Gen.TabIndex = 34
        Me.btn_Gen.Text = "Generate"
        Me.btn_Gen.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Gen.UseSelectable = True
        '
        'TrackingReprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 686)
        Me.Controls.Add(Me.crv_HWB)
        Me.Controls.Add(Me.btn_Gen)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TrackingReprint"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tracking No."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crv_HWB As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_Gen As MetroFramework.Controls.MetroButton
End Class
