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
        Me.SuspendLayout()
        '
        'HWB
        '
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Name = "HWB"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv_HWB As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_Gen As MetroFramework.Controls.MetroButton
End Class
