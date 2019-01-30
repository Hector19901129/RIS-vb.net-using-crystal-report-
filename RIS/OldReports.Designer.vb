<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldReports
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lstReports = New System.Windows.Forms.ListBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.grpRptHpvPatByDOB = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboMOB = New System.Windows.Forms.ComboBox
        Me.dtsDOB2 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dtsDOB1 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboRptHpvPatByDOBSortBy = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpRptReceptionList = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpVisitDate2 = New System.Windows.Forms.DateTimePicker
        Me.cboRptReceptionListSortBy = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpVisitDate1 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grpRptHpvPatByDOB.SuspendLayout()
        Me.grpRptReceptionList.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.btnPreview)
        Me.Panel3.Location = New System.Drawing.Point(487, 118)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(137, 258)
        Me.Panel3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(5, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 15)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "3. "
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPreview.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ImageIndex = 1
        Me.btnPreview.Location = New System.Drawing.Point(28, 12)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(96, 26)
        Me.btnPreview.TabIndex = 111
        Me.btnPreview.Text = "Preview Report"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.lstReports)
        Me.Panel1.Controls.Add(Me.Label62)
        Me.Panel1.Location = New System.Drawing.Point(190, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 258)
        Me.Panel1.TabIndex = 3
        '
        'lstReports
        '
        Me.lstReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstReports.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReports.ItemHeight = 16
        Me.lstReports.Location = New System.Drawing.Point(5, 38)
        Me.lstReports.Name = "lstReports"
        Me.lstReports.Size = New System.Drawing.Size(200, 148)
        Me.lstReports.TabIndex = 110
        '
        'Label62
        '
        Me.Label62.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label62.Location = New System.Drawing.Point(5, 16)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(139, 15)
        Me.Label62.TabIndex = 111
        Me.Label62.Text = "1. Select a report"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.grpRptHpvPatByDOB)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.grpRptReceptionList)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(351, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(130, 258)
        Me.Panel2.TabIndex = 4
        '
        'grpRptHpvPatByDOB
        '
        Me.grpRptHpvPatByDOB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRptHpvPatByDOB.Controls.Add(Me.Label9)
        Me.grpRptHpvPatByDOB.Controls.Add(Me.cboMOB)
        Me.grpRptHpvPatByDOB.Controls.Add(Me.dtsDOB2)
        Me.grpRptHpvPatByDOB.Controls.Add(Me.dtsDOB1)
        Me.grpRptHpvPatByDOB.Controls.Add(Me.Label6)
        Me.grpRptHpvPatByDOB.Controls.Add(Me.cboRptHpvPatByDOBSortBy)
        Me.grpRptHpvPatByDOB.Controls.Add(Me.Label7)
        Me.grpRptHpvPatByDOB.Controls.Add(Me.Label8)
        Me.grpRptHpvPatByDOB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpRptHpvPatByDOB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRptHpvPatByDOB.Location = New System.Drawing.Point(5, 32)
        Me.grpRptHpvPatByDOB.Name = "grpRptHpvPatByDOB"
        Me.grpRptHpvPatByDOB.Size = New System.Drawing.Size(125, 202)
        Me.grpRptHpvPatByDOB.TabIndex = 114
        Me.grpRptHpvPatByDOB.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 15)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Month of Birth"
        '
        'cboMOB
        '
        Me.cboMOB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMOB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMOB.ItemHeight = 13
        Me.cboMOB.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", ""})
        Me.cboMOB.Location = New System.Drawing.Point(11, 126)
        Me.cboMOB.MaxDropDownItems = 13
        Me.cboMOB.Name = "cboMOB"
        Me.cboMOB.Size = New System.Drawing.Size(108, 21)
        Me.cboMOB.TabIndex = 115
        '
        'dtsDOB2
        '
        Me.dtsDOB2.CustomFormat = "MM/dd/yyyy"
        Me.dtsDOB2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsDOB2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsDOB2.Location = New System.Drawing.Point(11, 73)
        Me.dtsDOB2.Name = "dtsDOB2"
        Me.dtsDOB2.ShowCheckBox = True
        Me.dtsDOB2.Size = New System.Drawing.Size(108, 22)
        Me.dtsDOB2.TabIndex = 114
        Me.dtsDOB2.Tag = "VisitDate"
        Me.dtsDOB2.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'dtsDOB1
        '
        Me.dtsDOB1.CustomFormat = "MM/dd/yyyy"
        Me.dtsDOB1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsDOB1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsDOB1.Location = New System.Drawing.Point(11, 30)
        Me.dtsDOB1.Name = "dtsDOB1"
        Me.dtsDOB1.ShowCheckBox = True
        Me.dtsDOB1.Size = New System.Drawing.Size(108, 22)
        Me.dtsDOB1.TabIndex = 113
        Me.dtsDOB1.Tag = "VisitDate"
        Me.dtsDOB1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(48, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 15)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "and"
        '
        'cboRptHpvPatByDOBSortBy
        '
        Me.cboRptHpvPatByDOBSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRptHpvPatByDOBSortBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRptHpvPatByDOBSortBy.ItemHeight = 13
        Me.cboRptHpvPatByDOBSortBy.Location = New System.Drawing.Point(11, 172)
        Me.cboRptHpvPatByDOBSortBy.Name = "cboRptHpvPatByDOBSortBy"
        Me.cboRptHpvPatByDOBSortBy.Size = New System.Drawing.Size(108, 21)
        Me.cboRptHpvPatByDOBSortBy.TabIndex = 110
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 15)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Sort by"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(9, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "DOB between"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(5, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 15)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "2. Specify criteria"
        '
        'grpRptReceptionList
        '
        Me.grpRptReceptionList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRptReceptionList.Controls.Add(Me.Label5)
        Me.grpRptReceptionList.Controls.Add(Me.dtpVisitDate2)
        Me.grpRptReceptionList.Controls.Add(Me.cboRptReceptionListSortBy)
        Me.grpRptReceptionList.Controls.Add(Me.Label1)
        Me.grpRptReceptionList.Controls.Add(Me.Label3)
        Me.grpRptReceptionList.Controls.Add(Me.dtpVisitDate1)
        Me.grpRptReceptionList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpRptReceptionList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRptReceptionList.Location = New System.Drawing.Point(5, 32)
        Me.grpRptReceptionList.Name = "grpRptReceptionList"
        Me.grpRptReceptionList.Size = New System.Drawing.Size(125, 151)
        Me.grpRptReceptionList.TabIndex = 112
        Me.grpRptReceptionList.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "End date"
        '
        'dtpVisitDate2
        '
        Me.dtpVisitDate2.CustomFormat = "MM/dd/yyyy"
        Me.dtpVisitDate2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVisitDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVisitDate2.Location = New System.Drawing.Point(11, 73)
        Me.dtpVisitDate2.Name = "dtpVisitDate2"
        Me.dtpVisitDate2.Size = New System.Drawing.Size(96, 22)
        Me.dtpVisitDate2.TabIndex = 111
        '
        'cboRptReceptionListSortBy
        '
        Me.cboRptReceptionListSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRptReceptionListSortBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRptReceptionListSortBy.ItemHeight = 13
        Me.cboRptReceptionListSortBy.Location = New System.Drawing.Point(11, 123)
        Me.cboRptReceptionListSortBy.Name = "cboRptReceptionListSortBy"
        Me.cboRptReceptionListSortBy.Size = New System.Drawing.Size(96, 21)
        Me.cboRptReceptionListSortBy.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Sort by"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Start date"
        '
        'dtpVisitDate1
        '
        Me.dtpVisitDate1.CustomFormat = "MM/dd/yyyy"
        Me.dtpVisitDate1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpVisitDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVisitDate1.Location = New System.Drawing.Point(11, 30)
        Me.dtpVisitDate1.Name = "dtpVisitDate1"
        Me.dtpVisitDate1.Size = New System.Drawing.Size(96, 22)
        Me.dtpVisitDate1.TabIndex = 108
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label10.Location = New System.Drawing.Point(10, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 186)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Criteria not required for this report"
        '
        'OldReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 495)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "OldReports"
        Me.Text = "OldReports"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.grpRptHpvPatByDOB.ResumeLayout(False)
        Me.grpRptReceptionList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstReports As System.Windows.Forms.ListBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents grpRptHpvPatByDOB As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboMOB As System.Windows.Forms.ComboBox
    Friend WithEvents dtsDOB2 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtsDOB1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboRptHpvPatByDOBSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpRptReceptionList As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpVisitDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboRptReceptionListSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpVisitDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
