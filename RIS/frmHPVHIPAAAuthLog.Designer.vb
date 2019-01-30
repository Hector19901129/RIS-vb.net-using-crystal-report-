<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHPVScannedFiledLog
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHPVScannedFiledLog))
        Me.bsResearcher = New System.Windows.Forms.BindingSource(Me.components)
        Me.RISdataDataSet = New RIS.RISdataDataSet
        Me.taResearcher = New RIS.RISdataDataSettableadapters.ddvResearcherTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpToDate = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dtpFromDate = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bnLogDisplay = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.HpvScannedFiledLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSaveBloodLog = New System.Windows.Forms.ToolStripButton
        Me.btnCancelEdit = New System.Windows.Forms.ToolStripButton
        Me.HpvHIPAAScannedFiledLogDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResearcherCd = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.taScannedFiledLogDisplay = New RIS.RISdataDataSettableadapters.HpvScannedFiledLogTableAdapter
        Me.TbStuHpvScanFileLogTableAdapter = New RIS.RISdataDataSettableadapters.tbStuHpvScanFileLogTableAdapter
        CType(Me.bsResearcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.bnLogDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnLogDisplay.SuspendLayout()
        CType(Me.HpvScannedFiledLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HpvHIPAAScannedFiledLogDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bsResearcher
        '
        Me.bsResearcher.DataMember = "ddvResearcher"
        Me.bsResearcher.DataSource = Me.RISdataDataSet
        '
        'RISdataDataSet
        '
        Me.RISdataDataSet.DataSetName = "RISdataDataSet"
        Me.RISdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'taResearcher
        '
        Me.taResearcher.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtpToDate)
        Me.GroupBox1.Controls.Add(Me.dtpFromDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1153, 291)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HPV HIPAA Authorization Scanned/ Files Log"
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(134, 38)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.ShowCheckBox = True
        Me.dtpToDate.Size = New System.Drawing.Size(110, 20)
        Me.dtpToDate.TabIndex = 15
        Me.dtpToDate.Value = New Date(2008, 8, 6, 17, 24, 12, 297)
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(16, 38)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.ShowCheckBox = True
        Me.dtpFromDate.Size = New System.Drawing.Size(110, 20)
        Me.dtpFromDate.TabIndex = 14
        Me.dtpFromDate.Value = New Date(2008, 8, 6, 17, 24, 12, 297)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "From:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(250, 37)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 21)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.bnLogDisplay)
        Me.GroupBox2.Controls.Add(Me.HpvHIPAAScannedFiledLogDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1158, 407)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'bnLogDisplay
        '
        Me.bnLogDisplay.AddNewItem = Nothing
        Me.bnLogDisplay.BindingSource = Me.HpvScannedFiledLogBindingSource
        Me.bnLogDisplay.CountItem = Me.BindingNavigatorCountItem
        Me.bnLogDisplay.DeleteItem = Nothing
        Me.bnLogDisplay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnSaveBloodLog, Me.btnCancelEdit})
        Me.bnLogDisplay.Location = New System.Drawing.Point(3, 16)
        Me.bnLogDisplay.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnLogDisplay.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnLogDisplay.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnLogDisplay.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnLogDisplay.Name = "bnLogDisplay"
        Me.bnLogDisplay.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnLogDisplay.Size = New System.Drawing.Size(1152, 25)
        Me.bnLogDisplay.Stretch = True
        Me.bnLogDisplay.TabIndex = 18
        Me.bnLogDisplay.Text = "BindingNavigator1"
        '
        'HpvScannedFiledLogBindingSource
        '
        Me.HpvScannedFiledLogBindingSource.DataMember = "HpvScannedFiledLog"
        Me.HpvScannedFiledLogBindingSource.DataSource = Me.RISdataDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnSaveBloodLog
        '
        Me.btnSaveBloodLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveBloodLog.Image = CType(resources.GetObject("btnSaveBloodLog.Image"), System.Drawing.Image)
        Me.btnSaveBloodLog.Name = "btnSaveBloodLog"
        Me.btnSaveBloodLog.Size = New System.Drawing.Size(23, 22)
        Me.btnSaveBloodLog.Text = "Save Data"
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Image = CType(resources.GetObject("btnCancelEdit.Image"), System.Drawing.Image)
        Me.btnCancelEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(104, 22)
        Me.btnCancelEdit.Text = "Cancel Changes"
        Me.btnCancelEdit.Visible = False
        '
        'HpvHIPAAScannedFiledLogDataGridView
        '
        Me.HpvHIPAAScannedFiledLogDataGridView.AllowUserToAddRows = False
        Me.HpvHIPAAScannedFiledLogDataGridView.AllowUserToDeleteRows = False
        Me.HpvHIPAAScannedFiledLogDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HpvHIPAAScannedFiledLogDataGridView.AutoGenerateColumns = False
        Me.HpvHIPAAScannedFiledLogDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.HpvHIPAAScannedFiledLogDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.ResearcherCd, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3})
        Me.HpvHIPAAScannedFiledLogDataGridView.DataSource = Me.HpvScannedFiledLogBindingSource
        Me.HpvHIPAAScannedFiledLogDataGridView.Location = New System.Drawing.Point(6, 41)
        Me.HpvHIPAAScannedFiledLogDataGridView.MultiSelect = False
        Me.HpvHIPAAScannedFiledLogDataGridView.Name = "HpvHIPAAScannedFiledLogDataGridView"
        Me.HpvHIPAAScannedFiledLogDataGridView.Size = New System.Drawing.Size(1146, 360)
        Me.HpvHIPAAScannedFiledLogDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SubjectNm"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MRN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MRN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SubjectID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Subject ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VisitDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Visit Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "VisitNumDescShort"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Visit Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FormDesc"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Form"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'ResearcherCd
        '
        Me.ResearcherCd.DataPropertyName = "ResearcherCd"
        Me.ResearcherCd.DataSource = Me.bsResearcher
        Me.ResearcherCd.DisplayMember = "LastName"
        Me.ResearcherCd.HeaderText = "Researcher"
        Me.ResearcherCd.Name = "ResearcherCd"
        Me.ResearcherCd.ValueMember = "ResearcherCd"
        Me.ResearcherCd.Width = 120
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Scanned"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Scanned"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Copied"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Copied"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 60
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Filed"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Filed"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 60
        '
        'taScannedFiledLogDisplay
        '
        Me.taScannedFiledLogDisplay.ClearBeforeFill = True
        '
        'TbStuHpvScanFileLogTableAdapter
        '
        Me.TbStuHpvScanFileLogTableAdapter.ClearBeforeFill = True
        '
        'frmHPVScannedFiledLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 494)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "frmHPVScannedFiledLog"
        Me.Text = "HPV Scanned Filed Log"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bsResearcher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.bnLogDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnLogDisplay.ResumeLayout(False)
        Me.bnLogDisplay.PerformLayout()
        CType(Me.HpvScannedFiledLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HpvHIPAAScannedFiledLogDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsResearcher As System.Windows.Forms.BindingSource
    Friend WithEvents taResearcher As RIS.RISdataDataSettableadapters.ddvResearcherTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpToDate As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtpFromDate As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RISdataDataSet As RIS.RISdataDataSet
    Friend WithEvents HpvScannedFiledLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents taScannedFiledLogDisplay As RIS.RISdataDataSettableadapters.HpvScannedFiledLogTableAdapter
    Friend WithEvents HpvHIPAAScannedFiledLogDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents bnLogDisplay As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSaveBloodLog As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResearcherCd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TbStuHpvScanFileLogTableAdapter As RIS.RISdataDataSettableadapters.tbStuHpvScanFileLogTableAdapter
End Class
