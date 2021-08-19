<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HWB
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
        Me.crv_HWB = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
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
        Me.crv_HWB.Size = New System.Drawing.Size(866, 606)
        Me.crv_HWB.TabIndex = 32
        Me.crv_HWB.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'HWB
        '
        Me.ClientSize = New System.Drawing.Size(906, 686)
        Me.Controls.Add(Me.crv_HWB)
        Me.Name = "HWB"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Way Bill"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Gen As MetroFramework.Controls.MetroButton
    Friend WithEvents crv_HWB As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
