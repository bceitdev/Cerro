<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.mt_CS = New MetroFramework.Controls.MetroTile()
        Me.mt_Ops = New MetroFramework.Controls.MetroTile()
        Me.mt_Finance = New MetroFramework.Controls.MetroTile()
        Me.mt_Sales = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'mt_CS
        '
        Me.mt_CS.ActiveControl = Nothing
        Me.mt_CS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_CS.Location = New System.Drawing.Point(213, 63)
        Me.mt_CS.Name = "mt_CS"
        Me.mt_CS.Size = New System.Drawing.Size(184, 195)
        Me.mt_CS.Style = MetroFramework.MetroColorStyle.Teal
        Me.mt_CS.TabIndex = 1
        Me.mt_CS.Text = "Customer Service"
        Me.mt_CS.TileImage = CType(resources.GetObject("mt_CS.TileImage"), System.Drawing.Image)
        Me.mt_CS.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.mt_CS.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mt_CS.UseSelectable = True
        Me.mt_CS.UseTileImage = True
        '
        'mt_Ops
        '
        Me.mt_Ops.ActiveControl = Nothing
        Me.mt_Ops.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_Ops.Location = New System.Drawing.Point(23, 264)
        Me.mt_Ops.Name = "mt_Ops"
        Me.mt_Ops.Size = New System.Drawing.Size(184, 195)
        Me.mt_Ops.Style = MetroFramework.MetroColorStyle.Teal
        Me.mt_Ops.TabIndex = 2
        Me.mt_Ops.Text = "Operation"
        Me.mt_Ops.TileImage = CType(resources.GetObject("mt_Ops.TileImage"), System.Drawing.Image)
        Me.mt_Ops.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.mt_Ops.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mt_Ops.UseSelectable = True
        Me.mt_Ops.UseTileImage = True
        '
        'mt_Finance
        '
        Me.mt_Finance.ActiveControl = Nothing
        Me.mt_Finance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_Finance.Location = New System.Drawing.Point(213, 264)
        Me.mt_Finance.Name = "mt_Finance"
        Me.mt_Finance.Size = New System.Drawing.Size(184, 195)
        Me.mt_Finance.Style = MetroFramework.MetroColorStyle.Teal
        Me.mt_Finance.TabIndex = 3
        Me.mt_Finance.Text = "Finance"
        Me.mt_Finance.TileImage = CType(resources.GetObject("mt_Finance.TileImage"), System.Drawing.Image)
        Me.mt_Finance.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.mt_Finance.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mt_Finance.UseSelectable = True
        Me.mt_Finance.UseTileImage = True
        '
        'mt_Sales
        '
        Me.mt_Sales.ActiveControl = Nothing
        Me.mt_Sales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mt_Sales.Location = New System.Drawing.Point(23, 63)
        Me.mt_Sales.Name = "mt_Sales"
        Me.mt_Sales.Size = New System.Drawing.Size(184, 195)
        Me.mt_Sales.Style = MetroFramework.MetroColorStyle.Teal
        Me.mt_Sales.TabIndex = 0
        Me.mt_Sales.Text = "Sales"
        Me.mt_Sales.TileImage = CType(resources.GetObject("mt_Sales.TileImage"), System.Drawing.Image)
        Me.mt_Sales.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.mt_Sales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mt_Sales.UseSelectable = True
        Me.mt_Sales.UseTileImage = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 474)
        Me.Controls.Add(Me.mt_Ops)
        Me.Controls.Add(Me.mt_Finance)
        Me.Controls.Add(Me.mt_CS)
        Me.Controls.Add(Me.mt_Sales)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenu"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mt_Sales As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_CS As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_Ops As MetroFramework.Controls.MetroTile
    Friend WithEvents mt_Finance As MetroFramework.Controls.MetroTile
End Class
