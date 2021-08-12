<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CS_Report
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lb_Month = New System.Windows.Forms.ListBox()
        Me.cbo_Year = New MetroFramework.Controls.MetroComboBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(34, 145)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Month:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(34, 106)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Year:"
        '
        'lb_Month
        '
        Me.lb_Month.FormattingEnabled = True
        Me.lb_Month.ItemHeight = 20
        Me.lb_Month.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.lb_Month.Location = New System.Drawing.Point(118, 145)
        Me.lb_Month.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lb_Month.Name = "lb_Month"
        Me.lb_Month.Size = New System.Drawing.Size(116, 204)
        Me.lb_Month.TabIndex = 3
        '
        'cbo_Year
        '
        Me.cbo_Year.FormattingEnabled = True
        Me.cbo_Year.ItemHeight = 23
        Me.cbo_Year.Location = New System.Drawing.Point(118, 91)
        Me.cbo_Year.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbo_Year.Name = "cbo_Year"
        Me.cbo_Year.Size = New System.Drawing.Size(116, 29)
        Me.cbo_Year.TabIndex = 2
        Me.cbo_Year.UseSelectable = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(690, 145)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(450, 462)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'CS_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 917)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lb_Month)
        Me.Controls.Add(Me.cbo_Year)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CS_Report"
        Me.Padding = New System.Windows.Forms.Padding(30, 92, 30, 31)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Report"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lb_Month As ListBox
    Friend WithEvents cbo_Year As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
