﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlotWells
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LblNbrOfPosToFind = New System.Windows.Forms.Label()
        Me.NumPosToFind = New System.Windows.Forms.NumericUpDown()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Lbliteration = New System.Windows.Forms.Label()
        Me.NumWells = New System.Windows.Forms.NumericUpDown()
        Me.LblWells = New System.Windows.Forms.Label()
        Me.BtnGenWells = New System.Windows.Forms.Button()
        Me.LblIDwell = New System.Windows.Forms.Label()
        Me.TimerShowPositins = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPosToFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumWells, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(841, 570)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'LblNbrOfPosToFind
        '
        Me.LblNbrOfPosToFind.AutoSize = True
        Me.LblNbrOfPosToFind.Location = New System.Drawing.Point(386, 599)
        Me.LblNbrOfPosToFind.Name = "LblNbrOfPosToFind"
        Me.LblNbrOfPosToFind.Size = New System.Drawing.Size(139, 13)
        Me.LblNbrOfPosToFind.TabIndex = 3
        Me.LblNbrOfPosToFind.Text = "Nombre de points à Trouver"
        '
        'NumPosToFind
        '
        Me.NumPosToFind.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumPosToFind.Location = New System.Drawing.Point(389, 615)
        Me.NumPosToFind.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumPosToFind.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumPosToFind.Name = "NumPosToFind"
        Me.NumPosToFind.Size = New System.Drawing.Size(120, 20)
        Me.NumPosToFind.TabIndex = 4
        Me.NumPosToFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumPosToFind.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(715, 640)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 9
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Lbliteration
        '
        Me.Lbliteration.AutoSize = True
        Me.Lbliteration.Location = New System.Drawing.Point(712, 617)
        Me.Lbliteration.Name = "Lbliteration"
        Me.Lbliteration.Size = New System.Drawing.Size(45, 13)
        Me.Lbliteration.TabIndex = 10
        Me.Lbliteration.Text = "Iteration"
        '
        'NumWells
        '
        Me.NumWells.Location = New System.Drawing.Point(250, 617)
        Me.NumWells.Name = "NumWells"
        Me.NumWells.Size = New System.Drawing.Size(120, 20)
        Me.NumWells.TabIndex = 11
        Me.NumWells.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblWells
        '
        Me.LblWells.AutoSize = True
        Me.LblWells.Location = New System.Drawing.Point(247, 599)
        Me.LblWells.Name = "LblWells"
        Me.LblWells.Size = New System.Drawing.Size(82, 13)
        Me.LblWells.TabIndex = 12
        Me.LblWells.Text = "Nomber of wells"
        '
        'BtnGenWells
        '
        Me.BtnGenWells.Location = New System.Drawing.Point(484, 656)
        Me.BtnGenWells.Name = "BtnGenWells"
        Me.BtnGenWells.Size = New System.Drawing.Size(120, 23)
        Me.BtnGenWells.TabIndex = 13
        Me.BtnGenWells.Text = "Generate plate"
        Me.BtnGenWells.UseVisualStyleBackColor = True
        '
        'LblIDwell
        '
        Me.LblIDwell.AutoSize = True
        Me.LblIDwell.Location = New System.Drawing.Point(770, 617)
        Me.LblIDwell.Name = "LblIDwell"
        Me.LblIDwell.Size = New System.Drawing.Size(38, 13)
        Me.LblIDwell.TabIndex = 14
        Me.LblIDwell.Text = "ID puit"
        '
        'TimerShowPositins
        '
        '
        'PlotWells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 727)
        Me.Controls.Add(Me.LblIDwell)
        Me.Controls.Add(Me.BtnGenWells)
        Me.Controls.Add(Me.LblWells)
        Me.Controls.Add(Me.NumWells)
        Me.Controls.Add(Me.Lbliteration)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.NumPosToFind)
        Me.Controls.Add(Me.LblNbrOfPosToFind)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "PlotWells"
        Me.Text = "Plot Point"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPosToFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumWells, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LblNbrOfPosToFind As Label
    Friend WithEvents NumPosToFind As NumericUpDown
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BtnClear As Button
    Friend WithEvents Lbliteration As Label
    Friend WithEvents NumWells As NumericUpDown
    Friend WithEvents LblWells As Label
    Friend WithEvents BtnGenWells As Button
    Friend WithEvents LblIDwell As Label
    Friend WithEvents TimerShowPositins As Timer
End Class