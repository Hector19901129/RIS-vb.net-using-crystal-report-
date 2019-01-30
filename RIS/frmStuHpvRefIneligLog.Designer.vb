<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStuHpvRefIneligLog
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStuHpvRefIneligLog))
        Me.grpLogDescrition = New System.Windows.Forms.GroupBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.pnlLog = New System.Windows.Forms.Panel
        Me.grdLog = New System.Windows.Forms.DataGridView
        Me.DateApproached = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.bsSession = New System.Windows.Forms.BindingSource(Me.components)
        Me.RISdataDataSet = New RIS.RISdataDataSet
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.bsResearcher = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HealthEdOnly = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Male = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.bnLog = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnAdd = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDelete = New System.Windows.Forms.ToolStripButton
        Me.btnSave = New System.Windows.Forms.ToolStripButton
        Me.btnCancelEdit = New System.Windows.Forms.ToolStripButton
        Me.taStudy = New RIS.RISdataDataSetTableAdapters.tbStuHpvRefIneligLogTableAdapter
        Me.taSession = New RIS.RISdataDataSetTableAdapters.ddvSessionTableAdapter
        Me.taResearcher = New RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter
        Me.grpLogDescrition.SuspendLayout()
        Me.pnlLog.SuspendLayout()
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSession, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsResearcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLogDescrition
        '
        Me.grpLogDescrition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLogDescrition.Controls.Add(Me.btnRefresh)
        Me.grpLogDescrition.Location = New System.Drawing.Point(4, 6)
        Me.grpLogDescrition.Name = "grpLogDescrition"
        Me.grpLogDescrition.Size = New System.Drawing.Size(1014, 80)
        Me.grpLogDescrition.TabIndex = 2
        Me.grpLogDescrition.TabStop = False
        Me.grpLogDescrition.Text = "HPV Refusal/Ineligible Log"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(22, 33)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 21)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'pnlLog
        '
        Me.pnlLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLog.Controls.Add(Me.grdLog)
        Me.pnlLog.Controls.Add(Me.bnLog)
        Me.pnlLog.Location = New System.Drawing.Point(4, 92)
        Me.pnlLog.Name = "pnlLog"
        Me.pnlLog.Size = New System.Drawing.Size(1014, 479)
        Me.pnlLog.TabIndex = 3
        '
        'grdLog
        '
        Me.grdLog.AllowUserToAddRows = False
        Me.grdLog.AllowUserToOrderColumns = True
        Me.grdLog.AutoGenerateColumns = False
        Me.grdLog.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdLog.ColumnHeadersHeight = 41
        Me.grdLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateApproached, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.HealthEdOnly, Me.DataGridViewTextBoxColumn16, Me.Male, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.grdLog.DataSource = Me.bsLog
        Me.grdLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdLog.Location = New System.Drawing.Point(0, 25)
        Me.grdLog.MultiSelect = False
        Me.grdLog.Name = "grdLog"
        Me.grdLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLog.Size = New System.Drawing.Size(1014, 454)
        Me.grdLog.TabIndex = 2
        '
        'DateApproached
        '
        Me.DateApproached.DataPropertyName = "DateApproached"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DateApproached.DefaultCellStyle = DataGridViewCellStyle2
        Me.DateApproached.HeaderText = "Date Approached"
        Me.DateApproached.Name = "DateApproached"
        Me.DateApproached.Width = 106
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SessionID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.bsSession
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Session"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Session"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "SessionID"
        Me.DataGridViewTextBoxColumn3.Width = 69
        '
        'bsSession
        '
        Me.bsSession.DataMember = "ddvSession"
        Me.bsSession.DataSource = Me.RISdataDataSet
        '
        'RISdataDataSet
        '
        Me.RISdataDataSet.DataSetName = "RISdataDataSet"
        Me.RISdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ResearcherID"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.bsResearcher
        Me.DataGridViewTextBoxColumn4.DisplayMember = "FirstName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Researcher"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "ResearcherCd"
        Me.DataGridViewTextBoxColumn4.Width = 87
        '
        'bsResearcher
        '
        Me.bsResearcher.DataMember = "ddvResearcher"
        Me.bsResearcher.DataSource = Me.RISdataDataSet
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NotInterestedNoReason"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Not Interested No Reason"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 109
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "NotInterestedFamFriends"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Not Interested Fam\Friends"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 147
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HasPeriodNow"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Has Period Now"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "InsufficientTime"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Insufficient Time"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MightBePregnant"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Might Be Pregnant"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 110
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Pregnant"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Pregnant"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NotAgeRangeNotSpec"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Age Range Not Spec"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NotAgeRangeTooOld"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Too Old"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 51
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NotAgeRangeTooYoung"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Too Young"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 79
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NotSexuallyActive"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Not Sexually Active"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 114
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NotGYNVisit"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Not GYN Visit"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 89
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "OnlyWantVaccine"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Only Want Vaccine"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 114
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "AlreadyHadVaccine"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Already Had Vaccine"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 121
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NotInterestedVaccine"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Not Interested Vaccine"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 129
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "MaybeInterested"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Maybe Interested"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 105
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PreviouslyApproached"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Previously Approached"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 129
        '
        'HealthEdOnly
        '
        Me.HealthEdOnly.DataPropertyName = "HealthEdOnly"
        Me.HealthEdOnly.HeaderText = "Only Did Health Education"
        Me.HealthEdOnly.Name = "HealthEdOnly"
        Me.HealthEdOnly.Width = 143
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SpanishSpeaker"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Spanish Speaker"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 104
        '
        'Male
        '
        Me.Male.DataPropertyName = "Male"
        Me.Male.HeaderText = "Male"
        Me.Male.Name = "Male"
        Me.Male.Width = 55
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 60
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "LastEditLoginID"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Last Edit Login"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 94
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "LastEditDate"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Last Edit Date"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 91
        '
        'bsLog
        '
        Me.bsLog.DataMember = "tbStuHpvRefIneligLog"
        Me.bsLog.DataSource = Me.RISdataDataSet
        '
        'bnLog
        '
        Me.bnLog.AddNewItem = Me.btnAdd
        Me.bnLog.BindingSource = Me.bsLog
        Me.bnLog.CountItem = Me.BindingNavigatorCountItem
        Me.bnLog.DeleteItem = Nothing
        Me.bnLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnAdd, Me.btnDelete, Me.btnSave, Me.btnCancelEdit})
        Me.bnLog.Location = New System.Drawing.Point(0, 0)
        Me.bnLog.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnLog.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnLog.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnLog.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnLog.Name = "bnLog"
        Me.bnLog.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnLog.Size = New System.Drawing.Size(1014, 25)
        Me.bnLog.Stretch = True
        Me.bnLog.TabIndex = 1
        Me.bnLog.Text = "BindingNavigator1"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.RightToLeftAutoMirrorImage = True
        Me.btnAdd.Size = New System.Drawing.Size(23, 22)
        Me.btnAdd.Text = "Add new"
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
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeftAutoMirrorImage = True
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "Delete"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save Data"
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCancelEdit.Image = CType(resources.GetObject("btnCancelEdit.Image"), System.Drawing.Image)
        Me.btnCancelEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(64, 22)
        Me.btnCancelEdit.Text = "Cancel Edit"
        Me.btnCancelEdit.Visible = False
        '
        'taStudy
        '
        Me.taStudy.ClearBeforeFill = True
        '
        'taSession
        '
        Me.taSession.ClearBeforeFill = True
        '
        'taResearcher
        '
        Me.taResearcher.ClearBeforeFill = True
        '
        'frmStuHpvRefIneligLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 573)
        Me.Controls.Add(Me.pnlLog)
        Me.Controls.Add(Me.grpLogDescrition)
        Me.Name = "frmStuHpvRefIneligLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Refusal/Ineligible Log"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpLogDescrition.ResumeLayout(False)
        Me.pnlLog.ResumeLayout(False)
        Me.pnlLog.PerformLayout()
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSession, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsResearcher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnLog.ResumeLayout(False)
        Me.bnLog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RISdataDataSet As RIS.RISdataDataSet
    Friend WithEvents bsLog As System.Windows.Forms.BindingSource
    Friend WithEvents taStudy As RIS.RISdataDataSettableadapters.tbStuHpvRefIneligLogTableAdapter
    Friend WithEvents bsSession As System.Windows.Forms.BindingSource
    Friend WithEvents bsResearcher As System.Windows.Forms.BindingSource
    Friend WithEvents taSession As RIS.RISdataDataSetTableAdapters.ddvSessionTableAdapter
    Friend WithEvents taResearcher As RIS.RISdataDataSettableadapters.ddvResearcherTableAdapter
    Friend WithEvents grpLogDescrition As System.Windows.Forms.GroupBox
    Friend WithEvents pnlLog As System.Windows.Forms.Panel
    Friend WithEvents grdLog As System.Windows.Forms.DataGridView
    Friend WithEvents bnLog As System.Windows.Forms.BindingNavigator
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents DateApproached As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HealthEdOnly As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Male As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
