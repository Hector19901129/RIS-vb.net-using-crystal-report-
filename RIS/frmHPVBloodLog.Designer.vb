<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHPVBloodLog
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHPVBloodLog))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.bsBloodLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.RISdataDataSet = New RIS.RISdataDataSet
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpToDate = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dtpFromDate = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.taBloodLogDisplay = New RIS.RISdataDataSetTableAdapters.HpvBloodLogDisplayTableAdapter
        Me.pnlLog = New System.Windows.Forms.Panel
        Me.grdBloodLog = New System.Windows.Forms.DataGridView
        Me.bsResearcher = New System.Windows.Forms.BindingSource(Me.components)
        Me.bnBloodLog = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.taResearcher = New RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter
        Me.taBloodLog = New RIS.RISdataDataSetTableAdapters.tbStuHpvBloodLogTableAdapter
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MRNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubjectIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VisitDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VisitNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BloodDrawnTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BloodSpunTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BloodStoredTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransportToGCRCDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerumExtractedTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumberAliquotsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerumStoredTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResearcherNameIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ResearcherEntryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.bsBloodLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnlLog.SuspendLayout()
        CType(Me.grdBloodLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsResearcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnBloodLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnBloodLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'bsBloodLog
        '
        Me.bsBloodLog.DataMember = "HpvBloodLogDisplay"
        Me.bsBloodLog.DataSource = Me.RISdataDataSet
        '
        'RISdataDataSet
        '
        Me.RISdataDataSet.DataSetName = "RISdataDataSet"
        Me.RISdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1011, 80)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HPV Blood Log Filters"
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
        Me.btnRefresh.Location = New System.Drawing.Point(252, 37)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 21)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'taBloodLogDisplay
        '
        Me.taBloodLogDisplay.ClearBeforeFill = False
        '
        'pnlLog
        '
        Me.pnlLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLog.Controls.Add(Me.grdBloodLog)
        Me.pnlLog.Controls.Add(Me.bnBloodLog)
        Me.pnlLog.Location = New System.Drawing.Point(4, 92)
        Me.pnlLog.Name = "pnlLog"
        Me.pnlLog.Size = New System.Drawing.Size(1011, 544)
        Me.pnlLog.TabIndex = 17
        '
        'grdBloodLog
        '
        Me.grdBloodLog.AllowUserToAddRows = False
        Me.grdBloodLog.AllowUserToDeleteRows = False
        Me.grdBloodLog.AllowUserToOrderColumns = True
        Me.grdBloodLog.AllowUserToResizeRows = False
        Me.grdBloodLog.AutoGenerateColumns = False
        Me.grdBloodLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdBloodLog.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBloodLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdBloodLog.ColumnHeadersHeight = 44
        Me.grdBloodLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MRNDataGridViewTextBoxColumn, Me.SubjectIDDataGridViewTextBoxColumn, Me.VisitDateDataGridViewTextBoxColumn, Me.VisitNumDataGridViewTextBoxColumn, Me.BloodDrawnTimeDataGridViewTextBoxColumn, Me.BloodSpunTimeDataGridViewTextBoxColumn, Me.BloodStoredTimeDataGridViewTextBoxColumn, Me.TransportToGCRCDateDataGridViewTextBoxColumn, Me.SerumExtractedTimeDataGridViewTextBoxColumn, Me.NumberAliquotsDataGridViewTextBoxColumn, Me.SerumStoredTimeDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.ResearcherNameIDDataGridViewTextBoxColumn, Me.ResearcherEntryDateDataGridViewTextBoxColumn})
        Me.grdBloodLog.DataSource = Me.bsBloodLog
        Me.grdBloodLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdBloodLog.Location = New System.Drawing.Point(0, 25)
        Me.grdBloodLog.MultiSelect = False
        Me.grdBloodLog.Name = "grdBloodLog"
        Me.grdBloodLog.Size = New System.Drawing.Size(1011, 519)
        Me.grdBloodLog.TabIndex = 18
        '
        'bsResearcher
        '
        Me.bsResearcher.DataMember = "ddvResearcher"
        Me.bsResearcher.DataSource = Me.RISdataDataSet
        '
        'bnBloodLog
        '
        Me.bnBloodLog.AddNewItem = Nothing
        Me.bnBloodLog.BindingSource = Me.bsBloodLog
        Me.bnBloodLog.CountItem = Me.BindingNavigatorCountItem
        Me.bnBloodLog.DeleteItem = Nothing
        Me.bnBloodLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnSaveBloodLog, Me.btnCancelEdit})
        Me.bnBloodLog.Location = New System.Drawing.Point(0, 0)
        Me.bnBloodLog.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnBloodLog.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnBloodLog.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnBloodLog.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnBloodLog.Name = "bnBloodLog"
        Me.bnBloodLog.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnBloodLog.Size = New System.Drawing.Size(1011, 25)
        Me.bnBloodLog.Stretch = True
        Me.bnBloodLog.TabIndex = 17
        Me.bnBloodLog.Text = "BindingNavigator1"
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
        Me.btnSaveBloodLog.Enabled = False
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
        'taResearcher
        '
        Me.taResearcher.ClearBeforeFill = True
        '
        'taBloodLog
        '
        Me.taBloodLog.ClearBeforeFill = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Width = 77
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 76
        '
        'MRNDataGridViewTextBoxColumn
        '
        Me.MRNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MRNDataGridViewTextBoxColumn.DataPropertyName = "MRN"
        Me.MRNDataGridViewTextBoxColumn.HeaderText = "MRN"
        Me.MRNDataGridViewTextBoxColumn.Name = "MRNDataGridViewTextBoxColumn"
        Me.MRNDataGridViewTextBoxColumn.ReadOnly = True
        Me.MRNDataGridViewTextBoxColumn.Width = 57
        '
        'SubjectIDDataGridViewTextBoxColumn
        '
        Me.SubjectIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID"
        Me.SubjectIDDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectIDDataGridViewTextBoxColumn.Name = "SubjectIDDataGridViewTextBoxColumn"
        Me.SubjectIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubjectIDDataGridViewTextBoxColumn.Width = 68
        '
        'VisitDateDataGridViewTextBoxColumn
        '
        Me.VisitDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VisitDateDataGridViewTextBoxColumn.DataPropertyName = "VisitDate"
        Me.VisitDateDataGridViewTextBoxColumn.HeaderText = "Visit Date"
        Me.VisitDateDataGridViewTextBoxColumn.Name = "VisitDateDataGridViewTextBoxColumn"
        Me.VisitDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.VisitDateDataGridViewTextBoxColumn.Width = 71
        '
        'VisitNumDataGridViewTextBoxColumn
        '
        Me.VisitNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VisitNumDataGridViewTextBoxColumn.DataPropertyName = "VisitNumDescShort"
        Me.VisitNumDataGridViewTextBoxColumn.HeaderText = "Visit Number"
        Me.VisitNumDataGridViewTextBoxColumn.Name = "VisitNumDataGridViewTextBoxColumn"
        Me.VisitNumDataGridViewTextBoxColumn.ReadOnly = True
        Me.VisitNumDataGridViewTextBoxColumn.Width = 84
        '
        'BloodDrawnTimeDataGridViewTextBoxColumn
        '
        Me.BloodDrawnTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BloodDrawnTimeDataGridViewTextBoxColumn.DataPropertyName = "BloodDrawnTime"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.BloodDrawnTimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.BloodDrawnTimeDataGridViewTextBoxColumn.HeaderText = "Blood Drawn Time"
        Me.BloodDrawnTimeDataGridViewTextBoxColumn.Name = "BloodDrawnTimeDataGridViewTextBoxColumn"
        Me.BloodDrawnTimeDataGridViewTextBoxColumn.Width = 88
        '
        'BloodSpunTimeDataGridViewTextBoxColumn
        '
        Me.BloodSpunTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BloodSpunTimeDataGridViewTextBoxColumn.DataPropertyName = "BloodSpunTime"
        DataGridViewCellStyle3.Format = "t"
        Me.BloodSpunTimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.BloodSpunTimeDataGridViewTextBoxColumn.HeaderText = "Blood Spun Time"
        Me.BloodSpunTimeDataGridViewTextBoxColumn.Name = "BloodSpunTimeDataGridViewTextBoxColumn"
        Me.BloodSpunTimeDataGridViewTextBoxColumn.Width = 77
        '
        'BloodStoredTimeDataGridViewTextBoxColumn
        '
        Me.BloodStoredTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BloodStoredTimeDataGridViewTextBoxColumn.DataPropertyName = "BloodStoredTime"
        Me.BloodStoredTimeDataGridViewTextBoxColumn.HeaderText = "Blood Stored Time"
        Me.BloodStoredTimeDataGridViewTextBoxColumn.Name = "BloodStoredTimeDataGridViewTextBoxColumn"
        Me.BloodStoredTimeDataGridViewTextBoxColumn.Width = 88
        '
        'TransportToGCRCDateDataGridViewTextBoxColumn
        '
        Me.TransportToGCRCDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TransportToGCRCDateDataGridViewTextBoxColumn.DataPropertyName = "TransportToGCRCDate"
        Me.TransportToGCRCDateDataGridViewTextBoxColumn.HeaderText = "Transport To GCRC Date"
        Me.TransportToGCRCDateDataGridViewTextBoxColumn.Name = "TransportToGCRCDateDataGridViewTextBoxColumn"
        Me.TransportToGCRCDateDataGridViewTextBoxColumn.Width = 88
        '
        'SerumExtractedTimeDataGridViewTextBoxColumn
        '
        Me.SerumExtractedTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SerumExtractedTimeDataGridViewTextBoxColumn.DataPropertyName = "SerumExtractedTime"
        Me.SerumExtractedTimeDataGridViewTextBoxColumn.HeaderText = "Serum Extracted Time"
        Me.SerumExtractedTimeDataGridViewTextBoxColumn.Name = "SerumExtractedTimeDataGridViewTextBoxColumn"
        Me.SerumExtractedTimeDataGridViewTextBoxColumn.Width = 95
        '
        'NumberAliquotsDataGridViewTextBoxColumn
        '
        Me.NumberAliquotsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumberAliquotsDataGridViewTextBoxColumn.DataPropertyName = "NumberAliquots"
        Me.NumberAliquotsDataGridViewTextBoxColumn.HeaderText = "Number Aliquots"
        Me.NumberAliquotsDataGridViewTextBoxColumn.Name = "NumberAliquotsDataGridViewTextBoxColumn"
        '
        'SerumStoredTimeDataGridViewTextBoxColumn
        '
        Me.SerumStoredTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SerumStoredTimeDataGridViewTextBoxColumn.DataPropertyName = "SerumStoredTime"
        Me.SerumStoredTimeDataGridViewTextBoxColumn.HeaderText = "Serum Stored Time"
        Me.SerumStoredTimeDataGridViewTextBoxColumn.Name = "SerumStoredTimeDataGridViewTextBoxColumn"
        Me.SerumStoredTimeDataGridViewTextBoxColumn.Width = 82
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.Width = 60
        '
        'ResearcherNameIDDataGridViewTextBoxColumn
        '
        Me.ResearcherNameIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ResearcherNameIDDataGridViewTextBoxColumn.DataPropertyName = "ResearcherNameID"
        Me.ResearcherNameIDDataGridViewTextBoxColumn.DataSource = Me.bsResearcher
        Me.ResearcherNameIDDataGridViewTextBoxColumn.DisplayMember = "LastName"
        Me.ResearcherNameIDDataGridViewTextBoxColumn.HeaderText = "Researcher Name"
        Me.ResearcherNameIDDataGridViewTextBoxColumn.Name = "ResearcherNameIDDataGridViewTextBoxColumn"
        Me.ResearcherNameIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ResearcherNameIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ResearcherNameIDDataGridViewTextBoxColumn.ValueMember = "ResearcherCd"
        Me.ResearcherNameIDDataGridViewTextBoxColumn.Width = 108
        '
        'ResearcherEntryDateDataGridViewTextBoxColumn
        '
        Me.ResearcherEntryDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ResearcherEntryDateDataGridViewTextBoxColumn.DataPropertyName = "ResearcherEntryDate"
        Me.ResearcherEntryDateDataGridViewTextBoxColumn.HeaderText = "Researcher Entry Date"
        Me.ResearcherEntryDateDataGridViewTextBoxColumn.Name = "ResearcherEntryDateDataGridViewTextBoxColumn"
        Me.ResearcherEntryDateDataGridViewTextBoxColumn.Width = 107
        '
        'frmHPVBloodLog
        '
        Me.AcceptButton = Me.btnRefresh
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 639)
        Me.Controls.Add(Me.pnlLog)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmHPVBloodLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HPV Blood Log"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bsBloodLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlLog.ResumeLayout(False)
        Me.pnlLog.PerformLayout()
        CType(Me.grdBloodLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsResearcher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnBloodLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnBloodLog.ResumeLayout(False)
        Me.bnBloodLog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RISdataDataSet As RIS.RISdataDataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpToDate As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtpFromDate As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents bsBloodLog As System.Windows.Forms.BindingSource
    Friend WithEvents taBloodLogDisplay As RIS.RISdataDataSetTableAdapters.HpvBloodLogDisplayTableAdapter
    Friend WithEvents pnlLog As System.Windows.Forms.Panel
    Friend WithEvents grdBloodLog As System.Windows.Forms.DataGridView
    Friend WithEvents bnBloodLog As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents bsResearcher As System.Windows.Forms.BindingSource
    Friend WithEvents taResearcher As RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter
    Friend WithEvents taBloodLog As RIS.RISdataDataSetTableAdapters.tbStuHpvBloodLogTableAdapter
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MRNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodDrawnTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodSpunTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodStoredTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransportToGCRCDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerumExtractedTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberAliquotsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerumStoredTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResearcherNameIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ResearcherEntryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
