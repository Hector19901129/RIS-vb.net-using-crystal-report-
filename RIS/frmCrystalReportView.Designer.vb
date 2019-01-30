<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrystalReportView
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
        Me.CrystalReportView = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportView
        '
        Me.CrystalReportView.ActiveViewIndex = -1
        Me.CrystalReportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportView.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportView.Name = "CrystalReportView"
        Me.CrystalReportView.SelectionFormula = ""
        Me.CrystalReportView.Size = New System.Drawing.Size(778, 519)
        Me.CrystalReportView.TabIndex = 0
        Me.CrystalReportView.ViewTimeSelectionFormula = ""
        '
        'frmCrystalReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 519)
        Me.Controls.Add(Me.CrystalReportView)
        Me.Name = "frmCrystalReportView"
        Me.Text = "frmCrystalReportView"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportView As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
