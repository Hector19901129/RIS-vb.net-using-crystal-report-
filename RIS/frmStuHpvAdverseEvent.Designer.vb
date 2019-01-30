<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStuHpvAdverseEvent
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
        Me.components = New System.ComponentModel.Container()
        Dim NoAdEventYNCdLabel As System.Windows.Forms.Label
        Dim DateOnsetLabel As System.Windows.Forms.Label
        Dim SeriousEventYNCdLabel As System.Windows.Forms.Label
        Dim SeverityIDLabel As System.Windows.Forms.Label
        Dim RecoveryIDLabel As System.Windows.Forms.Label
        Dim RelProtocolIDLabel As System.Windows.Forms.Label
        Dim IncreaseRiskYNCdLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim PhysicianCdLabel As System.Windows.Forms.Label
        Dim ResearcherCdLabel As System.Windows.Forms.Label
        Dim VisitProcActIDLabel As System.Windows.Forms.Label
        Dim AdEventsLogIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStuHpvAdverseEvent))
        Me.grpInterventions = New System.Windows.Forms.GroupBox()
        Me.BindingNavigatorInterventions = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.TbStuHpvAdEventsInterventionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbStuHpvAdEventsLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RiSdataDataSet = New RIS.RISdataDataSet()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.grdInterventions = New System.Windows.Forms.DataGridView()
        Me.AdEventsInterIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEventsLogIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEvInterventionCdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DdvAdEventInterventionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpSymptoms = New System.Windows.Forms.GroupBox()
        Me.BindingNavigatorSymptoms = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TbStuHpvAdEventsSymptomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.grdSymptoms = New System.Windows.Forms.DataGridView()
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEventsLogIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEvSymptomCdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DdvAdEventsSymptomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpAdverseEvent = New System.Windows.Forms.GroupBox()
        Me.ResearcherCdComboBox = New System.Windows.Forms.ComboBox()
        Me.DdvResearcherBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhysicianCdComboBox = New System.Windows.Forms.ComboBox()
        Me.DdvPhysicianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.IncreaseRiskYNCdComboBox = New System.Windows.Forms.ComboBox()
        Me.DdvYesNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RelProtocolIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DdvAdEventRelProtocolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecoveryIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DdvAdEventRecoveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeverityIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DdvAdEventSeverityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeriousEventYNCdComboBox = New System.Windows.Forms.ComboBox()
        Me.DateOnsetDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoAdEventYNCdComboBox = New System.Windows.Forms.ComboBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.TbStuHpvAdEventsLogTableAdapter = New RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsLogTableAdapter()
        Me.TbStuHpvAdEventsSymptomsTableAdapter = New RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsSymptomsTableAdapter()
        Me.TbStuHpvAdEventsInterventionsTableAdapter = New RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsInterventionsTableAdapter()
        Me.DdvResearcherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DdvResearcherTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter()
        Me.DdvYesNoTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvYesNoTableAdapter()
        Me.DdvPhysicianTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvPhysicianTableAdapter()
        Me.DdvAdEventSeverityTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvAdEventSeverityTableAdapter()
        Me.DdvAdEventRecoveryTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvAdEventRecoveryTableAdapter()
        Me.DdvAdEventRelProtocolTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvAdEventRelProtocolTableAdapter()
        Me.VisitProcActIDTextBox = New System.Windows.Forms.TextBox()
        Me.AdEventsLogIDTextBox = New System.Windows.Forms.TextBox()
        Me.DdvAdEventInterventionTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvAdEventInterventionTableAdapter()
        Me.DdvAdEventsSymptomTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvAdEventsSymptomTableAdapter()
        NoAdEventYNCdLabel = New System.Windows.Forms.Label()
        DateOnsetLabel = New System.Windows.Forms.Label()
        SeriousEventYNCdLabel = New System.Windows.Forms.Label()
        SeverityIDLabel = New System.Windows.Forms.Label()
        RecoveryIDLabel = New System.Windows.Forms.Label()
        RelProtocolIDLabel = New System.Windows.Forms.Label()
        IncreaseRiskYNCdLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        PhysicianCdLabel = New System.Windows.Forms.Label()
        ResearcherCdLabel = New System.Windows.Forms.Label()
        VisitProcActIDLabel = New System.Windows.Forms.Label()
        AdEventsLogIDLabel = New System.Windows.Forms.Label()
        Me.grpInterventions.SuspendLayout()
        CType(Me.BindingNavigatorInterventions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorInterventions.SuspendLayout()
        CType(Me.TbStuHpvAdEventsInterventionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbStuHpvAdEventsLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RiSdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdInterventions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvAdEventInterventionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSymptoms.SuspendLayout()
        CType(Me.BindingNavigatorSymptoms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorSymptoms.SuspendLayout()
        CType(Me.TbStuHpvAdEventsSymptomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSymptoms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvAdEventsSymptomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAdverseEvent.SuspendLayout()
        CType(Me.DdvResearcherBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvPhysicianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvYesNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvAdEventRelProtocolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvAdEventRecoveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvAdEventSeverityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvResearcherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoAdEventYNCdLabel
        '
        NoAdEventYNCdLabel.AutoSize = True
        NoAdEventYNCdLabel.Location = New System.Drawing.Point(8, 32)
        NoAdEventYNCdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NoAdEventYNCdLabel.Name = "NoAdEventYNCdLabel"
        NoAdEventYNCdLabel.Size = New System.Drawing.Size(104, 17)
        NoAdEventYNCdLabel.TabIndex = 4
        NoAdEventYNCdLabel.Text = "Adverse Event:"
        '
        'DateOnsetLabel
        '
        DateOnsetLabel.AutoSize = True
        DateOnsetLabel.Location = New System.Drawing.Point(429, 30)
        DateOnsetLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateOnsetLabel.Name = "DateOnsetLabel"
        DateOnsetLabel.Size = New System.Drawing.Size(97, 17)
        DateOnsetLabel.TabIndex = 6
        DateOnsetLabel.Text = "Date of onset:"
        '
        'SeriousEventYNCdLabel
        '
        SeriousEventYNCdLabel.AutoSize = True
        SeriousEventYNCdLabel.Location = New System.Drawing.Point(13, 98)
        SeriousEventYNCdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SeriousEventYNCdLabel.Name = "SeriousEventYNCdLabel"
        SeriousEventYNCdLabel.Size = New System.Drawing.Size(100, 17)
        SeriousEventYNCdLabel.TabIndex = 8
        SeriousEventYNCdLabel.Text = "Serious Event:"
        '
        'SeverityIDLabel
        '
        SeverityIDLabel.AutoSize = True
        SeverityIDLabel.Location = New System.Drawing.Point(464, 97)
        SeverityIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SeverityIDLabel.Name = "SeverityIDLabel"
        SeverityIDLabel.Size = New System.Drawing.Size(63, 17)
        SeverityIDLabel.TabIndex = 10
        SeverityIDLabel.Text = "Severity:"
        '
        'RecoveryIDLabel
        '
        RecoveryIDLabel.AutoSize = True
        RecoveryIDLabel.Location = New System.Drawing.Point(455, 129)
        RecoveryIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RecoveryIDLabel.Name = "RecoveryIDLabel"
        RecoveryIDLabel.Size = New System.Drawing.Size(72, 17)
        RecoveryIDLabel.TabIndex = 12
        RecoveryIDLabel.Text = "Recovery:"
        '
        'RelProtocolIDLabel
        '
        RelProtocolIDLabel.AutoSize = True
        RelProtocolIDLabel.Location = New System.Drawing.Point(439, 164)
        RelProtocolIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RelProtocolIDLabel.Name = "RelProtocolIDLabel"
        RelProtocolIDLabel.Size = New System.Drawing.Size(89, 17)
        RelProtocolIDLabel.TabIndex = 14
        RelProtocolIDLabel.Text = "Rel Protocol:"
        '
        'IncreaseRiskYNCdLabel
        '
        IncreaseRiskYNCdLabel.AutoSize = True
        IncreaseRiskYNCdLabel.Location = New System.Drawing.Point(15, 132)
        IncreaseRiskYNCdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IncreaseRiskYNCdLabel.Name = "IncreaseRiskYNCdLabel"
        IncreaseRiskYNCdLabel.Size = New System.Drawing.Size(97, 17)
        IncreaseRiskYNCdLabel.TabIndex = 16
        IncreaseRiskYNCdLabel.Text = "Increase Risk:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(15, 193)
        NotesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(49, 17)
        NotesLabel.TabIndex = 18
        NotesLabel.Text = "Notes:"
        '
        'PhysicianCdLabel
        '
        PhysicianCdLabel.AutoSize = True
        PhysicianCdLabel.Location = New System.Drawing.Point(455, 62)
        PhysicianCdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhysicianCdLabel.Name = "PhysicianCdLabel"
        PhysicianCdLabel.Size = New System.Drawing.Size(72, 17)
        PhysicianCdLabel.TabIndex = 20
        PhysicianCdLabel.Text = "Physician:"
        '
        'ResearcherCdLabel
        '
        ResearcherCdLabel.AutoSize = True
        ResearcherCdLabel.Location = New System.Drawing.Point(28, 65)
        ResearcherCdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ResearcherCdLabel.Name = "ResearcherCdLabel"
        ResearcherCdLabel.Size = New System.Drawing.Size(86, 17)
        ResearcherCdLabel.TabIndex = 22
        ResearcherCdLabel.Text = "Researcher:"
        '
        'VisitProcActIDLabel
        '
        VisitProcActIDLabel.AutoSize = True
        VisitProcActIDLabel.Location = New System.Drawing.Point(299, 553)
        VisitProcActIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        VisitProcActIDLabel.Name = "VisitProcActIDLabel"
        VisitProcActIDLabel.Size = New System.Drawing.Size(112, 17)
        VisitProcActIDLabel.TabIndex = 10
        VisitProcActIDLabel.Text = "Visit Proc Act ID:"
        '
        'AdEventsLogIDLabel
        '
        AdEventsLogIDLabel.AutoSize = True
        AdEventsLogIDLabel.Location = New System.Drawing.Point(23, 553)
        AdEventsLogIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AdEventsLogIDLabel.Name = "AdEventsLogIDLabel"
        AdEventsLogIDLabel.Size = New System.Drawing.Size(121, 17)
        AdEventsLogIDLabel.TabIndex = 8
        AdEventsLogIDLabel.Text = "Ad Events Log ID:"
        '
        'grpInterventions
        '
        Me.grpInterventions.Controls.Add(Me.BindingNavigatorInterventions)
        Me.grpInterventions.Controls.Add(Me.grdInterventions)
        Me.grpInterventions.Location = New System.Drawing.Point(501, 330)
        Me.grpInterventions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInterventions.Name = "grpInterventions"
        Me.grpInterventions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInterventions.Size = New System.Drawing.Size(447, 209)
        Me.grpInterventions.TabIndex = 5
        Me.grpInterventions.TabStop = False
        Me.grpInterventions.Text = "Interventions"
        '
        'BindingNavigatorInterventions
        '
        Me.BindingNavigatorInterventions.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigatorInterventions.BindingSource = Me.TbStuHpvAdEventsInterventionsBindingSource
        Me.BindingNavigatorInterventions.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigatorInterventions.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigatorInterventions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigatorInterventions.Location = New System.Drawing.Point(4, 19)
        Me.BindingNavigatorInterventions.MoveFirstItem = Nothing
        Me.BindingNavigatorInterventions.MoveLastItem = Nothing
        Me.BindingNavigatorInterventions.MoveNextItem = Nothing
        Me.BindingNavigatorInterventions.MovePreviousItem = Nothing
        Me.BindingNavigatorInterventions.Name = "BindingNavigatorInterventions"
        Me.BindingNavigatorInterventions.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigatorInterventions.Size = New System.Drawing.Size(439, 27)
        Me.BindingNavigatorInterventions.TabIndex = 1
        Me.BindingNavigatorInterventions.Text = "BindingNavigatorInterventions"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'TbStuHpvAdEventsInterventionsBindingSource
        '
        Me.TbStuHpvAdEventsInterventionsBindingSource.DataMember = "tbStuHpvAdEventsInterventions"
        Me.TbStuHpvAdEventsInterventionsBindingSource.DataSource = Me.TbStuHpvAdEventsLogBindingSource
        '
        'TbStuHpvAdEventsLogBindingSource
        '
        Me.TbStuHpvAdEventsLogBindingSource.DataSource = Me.RiSdataDataSet
        Me.TbStuHpvAdEventsLogBindingSource.Position = 0
        '
        'RiSdataDataSet
        '
        Me.RiSdataDataSet.DataSetName = "RISdataDataSet"
        Me.RiSdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'grdInterventions
        '
        Me.grdInterventions.AutoGenerateColumns = False
        Me.grdInterventions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdInterventions.BackgroundColor = System.Drawing.Color.White
        Me.grdInterventions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdInterventions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdEventsInterIDDataGridViewTextBoxColumn, Me.AdEventsLogIDDataGridViewTextBoxColumn1, Me.AdEvInterventionCdDataGridViewTextBoxColumn, Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn})
        Me.grdInterventions.DataSource = Me.TbStuHpvAdEventsInterventionsBindingSource
        Me.grdInterventions.Location = New System.Drawing.Point(8, 54)
        Me.grdInterventions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdInterventions.Name = "grdInterventions"
        Me.grdInterventions.Size = New System.Drawing.Size(429, 148)
        Me.grdInterventions.TabIndex = 0
        '
        'AdEventsInterIDDataGridViewTextBoxColumn
        '
        Me.AdEventsInterIDDataGridViewTextBoxColumn.DataPropertyName = "AdEventsInterID"
        Me.AdEventsInterIDDataGridViewTextBoxColumn.HeaderText = "AdEventsInterID"
        Me.AdEventsInterIDDataGridViewTextBoxColumn.Name = "AdEventsInterIDDataGridViewTextBoxColumn"
        Me.AdEventsInterIDDataGridViewTextBoxColumn.Visible = False
        '
        'AdEventsLogIDDataGridViewTextBoxColumn1
        '
        Me.AdEventsLogIDDataGridViewTextBoxColumn1.DataPropertyName = "AdEventsLogID"
        Me.AdEventsLogIDDataGridViewTextBoxColumn1.HeaderText = "AdEventsLogID"
        Me.AdEventsLogIDDataGridViewTextBoxColumn1.Name = "AdEventsLogIDDataGridViewTextBoxColumn1"
        Me.AdEventsLogIDDataGridViewTextBoxColumn1.Visible = False
        '
        'AdEvInterventionCdDataGridViewTextBoxColumn
        '
        Me.AdEvInterventionCdDataGridViewTextBoxColumn.DataPropertyName = "AdEvInterventionCd"
        Me.AdEvInterventionCdDataGridViewTextBoxColumn.HeaderText = "AdEvInterventionCd"
        Me.AdEvInterventionCdDataGridViewTextBoxColumn.Name = "AdEvInterventionCdDataGridViewTextBoxColumn"
        Me.AdEvInterventionCdDataGridViewTextBoxColumn.Visible = False
        '
        'AdEvInterventionOtherDescDataGridViewTextBoxColumn
        '
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.DataPropertyName = "AdEvInterventionOtherDesc"
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.DataSource = Me.DdvAdEventInterventionBindingSource
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.DisplayMember = "AdEvInterventionDesc"
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.HeaderText = "Intervention Desciption"
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.Name = "AdEvInterventionOtherDescDataGridViewTextBoxColumn"
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.ValueMember = "AdEvInterventionCd"
        '
        'DdvAdEventInterventionBindingSource
        '
        Me.DdvAdEventInterventionBindingSource.DataMember = "ddvAdEventIntervention"
        Me.DdvAdEventInterventionBindingSource.DataSource = Me.RiSdataDataSet
        '
        'grpSymptoms
        '
        Me.grpSymptoms.Controls.Add(Me.BindingNavigatorSymptoms)
        Me.grpSymptoms.Controls.Add(Me.grdSymptoms)
        Me.grpSymptoms.Location = New System.Drawing.Point(7, 330)
        Me.grpSymptoms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSymptoms.Name = "grpSymptoms"
        Me.grpSymptoms.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSymptoms.Size = New System.Drawing.Size(487, 209)
        Me.grpSymptoms.TabIndex = 4
        Me.grpSymptoms.TabStop = False
        Me.grpSymptoms.Text = "Symptoms"
        '
        'BindingNavigatorSymptoms
        '
        Me.BindingNavigatorSymptoms.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigatorSymptoms.BindingSource = Me.TbStuHpvAdEventsSymptomsBindingSource
        Me.BindingNavigatorSymptoms.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorSymptoms.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigatorSymptoms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigatorSymptoms.Location = New System.Drawing.Point(4, 19)
        Me.BindingNavigatorSymptoms.MoveFirstItem = Nothing
        Me.BindingNavigatorSymptoms.MoveLastItem = Nothing
        Me.BindingNavigatorSymptoms.MoveNextItem = Nothing
        Me.BindingNavigatorSymptoms.MovePreviousItem = Nothing
        Me.BindingNavigatorSymptoms.Name = "BindingNavigatorSymptoms"
        Me.BindingNavigatorSymptoms.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorSymptoms.Size = New System.Drawing.Size(479, 27)
        Me.BindingNavigatorSymptoms.TabIndex = 2
        Me.BindingNavigatorSymptoms.Text = "BindingNavigatorSymptoms"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TbStuHpvAdEventsSymptomsBindingSource
        '
        Me.TbStuHpvAdEventsSymptomsBindingSource.DataMember = "tbStuHpvAdEventsSymptoms"
        Me.TbStuHpvAdEventsSymptomsBindingSource.DataSource = Me.TbStuHpvAdEventsLogBindingSource
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'grdSymptoms
        '
        Me.grdSymptoms.AutoGenerateColumns = False
        Me.grdSymptoms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdSymptoms.BackgroundColor = System.Drawing.Color.White
        Me.grdSymptoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSymptoms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdEventsSymptomsIDDataGridViewTextBoxColumn, Me.AdEventsLogIDDataGridViewTextBoxColumn, Me.AdEvSymptomCdDataGridViewTextBoxColumn, Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn})
        Me.grdSymptoms.DataSource = Me.TbStuHpvAdEventsSymptomsBindingSource
        Me.grdSymptoms.Location = New System.Drawing.Point(8, 54)
        Me.grdSymptoms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdSymptoms.Name = "grdSymptoms"
        Me.grdSymptoms.Size = New System.Drawing.Size(471, 148)
        Me.grdSymptoms.TabIndex = 1
        '
        'AdEventsSymptomsIDDataGridViewTextBoxColumn
        '
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn.DataPropertyName = "AdEventsSymptomsID"
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn.HeaderText = "AdEventsSymptomsID"
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn.Name = "AdEventsSymptomsIDDataGridViewTextBoxColumn"
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn.Visible = False
        '
        'AdEventsLogIDDataGridViewTextBoxColumn
        '
        Me.AdEventsLogIDDataGridViewTextBoxColumn.DataPropertyName = "AdEventsLogID"
        Me.AdEventsLogIDDataGridViewTextBoxColumn.HeaderText = "AdEventsLogID"
        Me.AdEventsLogIDDataGridViewTextBoxColumn.Name = "AdEventsLogIDDataGridViewTextBoxColumn"
        Me.AdEventsLogIDDataGridViewTextBoxColumn.Visible = False
        '
        'AdEvSymptomCdDataGridViewTextBoxColumn
        '
        Me.AdEvSymptomCdDataGridViewTextBoxColumn.DataPropertyName = "AdEvSymptomCd"
        Me.AdEvSymptomCdDataGridViewTextBoxColumn.HeaderText = "AdEvSymptomCd"
        Me.AdEvSymptomCdDataGridViewTextBoxColumn.Name = "AdEvSymptomCdDataGridViewTextBoxColumn"
        Me.AdEvSymptomCdDataGridViewTextBoxColumn.Visible = False
        '
        'AdEvSymptomOtherDescDataGridViewTextBoxColumn
        '
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.DataPropertyName = "AdEvSymptomOtherDesc"
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.DataSource = Me.DdvAdEventsSymptomBindingSource
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.DisplayMember = "AdEvSymptomDesc"
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.HeaderText = "Symptom Description"
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.Name = "AdEvSymptomOtherDescDataGridViewTextBoxColumn"
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.ValueMember = "AdEvSymptomCd"
        '
        'DdvAdEventsSymptomBindingSource
        '
        Me.DdvAdEventsSymptomBindingSource.DataMember = "ddvAdEventsSymptom"
        Me.DdvAdEventsSymptomBindingSource.DataSource = Me.RiSdataDataSet
        '
        'grpAdverseEvent
        '
        Me.grpAdverseEvent.Controls.Add(ResearcherCdLabel)
        Me.grpAdverseEvent.Controls.Add(Me.ResearcherCdComboBox)
        Me.grpAdverseEvent.Controls.Add(PhysicianCdLabel)
        Me.grpAdverseEvent.Controls.Add(Me.PhysicianCdComboBox)
        Me.grpAdverseEvent.Controls.Add(NotesLabel)
        Me.grpAdverseEvent.Controls.Add(Me.NotesTextBox)
        Me.grpAdverseEvent.Controls.Add(IncreaseRiskYNCdLabel)
        Me.grpAdverseEvent.Controls.Add(Me.IncreaseRiskYNCdComboBox)
        Me.grpAdverseEvent.Controls.Add(RelProtocolIDLabel)
        Me.grpAdverseEvent.Controls.Add(Me.RelProtocolIDComboBox)
        Me.grpAdverseEvent.Controls.Add(RecoveryIDLabel)
        Me.grpAdverseEvent.Controls.Add(Me.RecoveryIDComboBox)
        Me.grpAdverseEvent.Controls.Add(SeverityIDLabel)
        Me.grpAdverseEvent.Controls.Add(Me.SeverityIDComboBox)
        Me.grpAdverseEvent.Controls.Add(SeriousEventYNCdLabel)
        Me.grpAdverseEvent.Controls.Add(Me.SeriousEventYNCdComboBox)
        Me.grpAdverseEvent.Controls.Add(DateOnsetLabel)
        Me.grpAdverseEvent.Controls.Add(Me.DateOnsetDateTimePicker)
        Me.grpAdverseEvent.Controls.Add(NoAdEventYNCdLabel)
        Me.grpAdverseEvent.Controls.Add(Me.NoAdEventYNCdComboBox)
        Me.grpAdverseEvent.Location = New System.Drawing.Point(3, 4)
        Me.grpAdverseEvent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAdverseEvent.Name = "grpAdverseEvent"
        Me.grpAdverseEvent.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAdverseEvent.Size = New System.Drawing.Size(836, 319)
        Me.grpAdverseEvent.TabIndex = 3
        Me.grpAdverseEvent.TabStop = False
        Me.grpAdverseEvent.Text = "Adverse Event"
        '
        'ResearcherCdComboBox
        '
        Me.ResearcherCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "ResearcherCd", True))
        Me.ResearcherCdComboBox.DataSource = Me.DdvResearcherBindingSource1
        Me.ResearcherCdComboBox.DisplayMember = "ResearcherCd"
        Me.ResearcherCdComboBox.FormattingEnabled = True
        Me.ResearcherCdComboBox.Location = New System.Drawing.Point(125, 59)
        Me.ResearcherCdComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ResearcherCdComboBox.Name = "ResearcherCdComboBox"
        Me.ResearcherCdComboBox.Size = New System.Drawing.Size(279, 24)
        Me.ResearcherCdComboBox.TabIndex = 23
        Me.ResearcherCdComboBox.ValueMember = "ResearcherCd"
        '
        'DdvResearcherBindingSource1
        '
        Me.DdvResearcherBindingSource1.DataMember = "ddvResearcher"
        Me.DdvResearcherBindingSource1.DataSource = Me.TbStuHpvAdEventsLogBindingSource
        '
        'PhysicianCdComboBox
        '
        Me.PhysicianCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "PhysicianCd", True))
        Me.PhysicianCdComboBox.DataSource = Me.DdvPhysicianBindingSource
        Me.PhysicianCdComboBox.DisplayMember = "PhysicianCd"
        Me.PhysicianCdComboBox.FormattingEnabled = True
        Me.PhysicianCdComboBox.Location = New System.Drawing.Point(536, 60)
        Me.PhysicianCdComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PhysicianCdComboBox.Name = "PhysicianCdComboBox"
        Me.PhysicianCdComboBox.Size = New System.Drawing.Size(279, 24)
        Me.PhysicianCdComboBox.TabIndex = 21
        Me.PhysicianCdComboBox.ValueMember = "PhysicianCd"
        '
        'DdvPhysicianBindingSource
        '
        Me.DdvPhysicianBindingSource.DataMember = "ddvPhysician"
        Me.DdvPhysicianBindingSource.DataSource = Me.RiSdataDataSet
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(13, 213)
        Me.NotesTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(813, 99)
        Me.NotesTextBox.TabIndex = 19
        '
        'IncreaseRiskYNCdComboBox
        '
        Me.IncreaseRiskYNCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "IncreaseRiskYNCd", True))
        Me.IncreaseRiskYNCdComboBox.DataSource = Me.DdvYesNoBindingSource
        Me.IncreaseRiskYNCdComboBox.DisplayMember = "YesNo"
        Me.IncreaseRiskYNCdComboBox.FormattingEnabled = True
        Me.IncreaseRiskYNCdComboBox.Location = New System.Drawing.Point(125, 128)
        Me.IncreaseRiskYNCdComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IncreaseRiskYNCdComboBox.Name = "IncreaseRiskYNCdComboBox"
        Me.IncreaseRiskYNCdComboBox.Size = New System.Drawing.Size(160, 24)
        Me.IncreaseRiskYNCdComboBox.TabIndex = 17
        Me.IncreaseRiskYNCdComboBox.ValueMember = "YNCd"
        '
        'DdvYesNoBindingSource
        '
        Me.DdvYesNoBindingSource.DataMember = "ddvYesNo"
        Me.DdvYesNoBindingSource.DataSource = Me.RiSdataDataSet
        '
        'RelProtocolIDComboBox
        '
        Me.RelProtocolIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "RelProtocolID", True))
        Me.RelProtocolIDComboBox.DataSource = Me.DdvAdEventRelProtocolBindingSource
        Me.RelProtocolIDComboBox.DisplayMember = "AdEvRelProtocolDesc"
        Me.RelProtocolIDComboBox.FormattingEnabled = True
        Me.RelProtocolIDComboBox.Location = New System.Drawing.Point(536, 160)
        Me.RelProtocolIDComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RelProtocolIDComboBox.Name = "RelProtocolIDComboBox"
        Me.RelProtocolIDComboBox.Size = New System.Drawing.Size(160, 24)
        Me.RelProtocolIDComboBox.TabIndex = 15
        Me.RelProtocolIDComboBox.ValueMember = "AdEvRelProtocolCd"
        '
        'DdvAdEventRelProtocolBindingSource
        '
        Me.DdvAdEventRelProtocolBindingSource.DataMember = "ddvAdEventRelProtocol"
        Me.DdvAdEventRelProtocolBindingSource.DataSource = Me.RiSdataDataSet
        '
        'RecoveryIDComboBox
        '
        Me.RecoveryIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "RecoveryID", True))
        Me.RecoveryIDComboBox.DataSource = Me.DdvAdEventRecoveryBindingSource
        Me.RecoveryIDComboBox.DisplayMember = "AdEvRecoveryDesc"
        Me.RecoveryIDComboBox.FormattingEnabled = True
        Me.RecoveryIDComboBox.Location = New System.Drawing.Point(536, 127)
        Me.RecoveryIDComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RecoveryIDComboBox.Name = "RecoveryIDComboBox"
        Me.RecoveryIDComboBox.Size = New System.Drawing.Size(160, 24)
        Me.RecoveryIDComboBox.TabIndex = 13
        Me.RecoveryIDComboBox.ValueMember = "AdEvRecoveryCd"
        '
        'DdvAdEventRecoveryBindingSource
        '
        Me.DdvAdEventRecoveryBindingSource.DataMember = "ddvAdEventRecovery"
        Me.DdvAdEventRecoveryBindingSource.DataSource = Me.RiSdataDataSet
        '
        'SeverityIDComboBox
        '
        Me.SeverityIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "SeverityID", True))
        Me.SeverityIDComboBox.DataSource = Me.DdvAdEventSeverityBindingSource
        Me.SeverityIDComboBox.DisplayMember = "AdEvSeverityDesc"
        Me.SeverityIDComboBox.FormattingEnabled = True
        Me.SeverityIDComboBox.Location = New System.Drawing.Point(536, 94)
        Me.SeverityIDComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SeverityIDComboBox.Name = "SeverityIDComboBox"
        Me.SeverityIDComboBox.Size = New System.Drawing.Size(160, 24)
        Me.SeverityIDComboBox.TabIndex = 11
        Me.SeverityIDComboBox.ValueMember = "AdEvSeverityCd"
        '
        'DdvAdEventSeverityBindingSource
        '
        Me.DdvAdEventSeverityBindingSource.DataMember = "ddvAdEventSeverity"
        Me.DdvAdEventSeverityBindingSource.DataSource = Me.RiSdataDataSet
        '
        'SeriousEventYNCdComboBox
        '
        Me.SeriousEventYNCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "SeriousEventYNCd", True))
        Me.SeriousEventYNCdComboBox.DataSource = Me.DdvYesNoBindingSource
        Me.SeriousEventYNCdComboBox.DisplayMember = "YesNo"
        Me.SeriousEventYNCdComboBox.FormattingEnabled = True
        Me.SeriousEventYNCdComboBox.Location = New System.Drawing.Point(125, 95)
        Me.SeriousEventYNCdComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SeriousEventYNCdComboBox.Name = "SeriousEventYNCdComboBox"
        Me.SeriousEventYNCdComboBox.Size = New System.Drawing.Size(160, 24)
        Me.SeriousEventYNCdComboBox.TabIndex = 9
        Me.SeriousEventYNCdComboBox.ValueMember = "YNCd"
        '
        'DateOnsetDateTimePicker
        '
        Me.DateOnsetDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbStuHpvAdEventsLogBindingSource, "DateOnset", True))
        Me.DateOnsetDateTimePicker.Location = New System.Drawing.Point(536, 28)
        Me.DateOnsetDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateOnsetDateTimePicker.Name = "DateOnsetDateTimePicker"
        Me.DateOnsetDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DateOnsetDateTimePicker.TabIndex = 7
        '
        'NoAdEventYNCdComboBox
        '
        Me.NoAdEventYNCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "NoAdEventYNCd", True))
        Me.NoAdEventYNCdComboBox.DataSource = Me.DdvYesNoBindingSource
        Me.NoAdEventYNCdComboBox.DisplayMember = "YesNo"
        Me.NoAdEventYNCdComboBox.FormattingEnabled = True
        Me.NoAdEventYNCdComboBox.Location = New System.Drawing.Point(125, 26)
        Me.NoAdEventYNCdComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NoAdEventYNCdComboBox.Name = "NoAdEventYNCdComboBox"
        Me.NoAdEventYNCdComboBox.Size = New System.Drawing.Size(160, 24)
        Me.NoAdEventYNCdComboBox.TabIndex = 5
        Me.NoAdEventYNCdComboBox.ValueMember = "YNCd"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(739, 546)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 28)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(847, 546)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 28)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'TbStuHpvAdEventsLogTableAdapter
        '
        Me.TbStuHpvAdEventsLogTableAdapter.ClearBeforeFill = True
        '
        'TbStuHpvAdEventsSymptomsTableAdapter
        '
        Me.TbStuHpvAdEventsSymptomsTableAdapter.ClearBeforeFill = True
        '
        'TbStuHpvAdEventsInterventionsTableAdapter
        '
        Me.TbStuHpvAdEventsInterventionsTableAdapter.ClearBeforeFill = True
        '
        'DdvResearcherBindingSource
        '
        Me.DdvResearcherBindingSource.DataMember = "ddvResearcher"
        Me.DdvResearcherBindingSource.DataSource = Me.RiSdataDataSet
        '
        'DdvResearcherTableAdapter
        '
        Me.DdvResearcherTableAdapter.ClearBeforeFill = True
        '
        'DdvYesNoTableAdapter
        '
        Me.DdvYesNoTableAdapter.ClearBeforeFill = True
        '
        'DdvPhysicianTableAdapter
        '
        Me.DdvPhysicianTableAdapter.ClearBeforeFill = True
        '
        'DdvAdEventSeverityTableAdapter
        '
        Me.DdvAdEventSeverityTableAdapter.ClearBeforeFill = True
        '
        'DdvAdEventRecoveryTableAdapter
        '
        Me.DdvAdEventRecoveryTableAdapter.ClearBeforeFill = True
        '
        'DdvAdEventRelProtocolTableAdapter
        '
        Me.DdvAdEventRelProtocolTableAdapter.ClearBeforeFill = True
        '
        'VisitProcActIDTextBox
        '
        Me.VisitProcActIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "VisitProcActID", True))
        Me.VisitProcActIDTextBox.Location = New System.Drawing.Point(423, 546)
        Me.VisitProcActIDTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.VisitProcActIDTextBox.Name = "VisitProcActIDTextBox"
        Me.VisitProcActIDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.VisitProcActIDTextBox.TabIndex = 11
        '
        'AdEventsLogIDTextBox
        '
        Me.AdEventsLogIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "AdEventsLogID", True))
        Me.AdEventsLogIDTextBox.Location = New System.Drawing.Point(156, 549)
        Me.AdEventsLogIDTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AdEventsLogIDTextBox.Name = "AdEventsLogIDTextBox"
        Me.AdEventsLogIDTextBox.Size = New System.Drawing.Size(132, 22)
        Me.AdEventsLogIDTextBox.TabIndex = 9
        '
        'DdvAdEventInterventionTableAdapter
        '
        Me.DdvAdEventInterventionTableAdapter.ClearBeforeFill = True
        '
        'DdvAdEventsSymptomTableAdapter
        '
        Me.DdvAdEventsSymptomTableAdapter.ClearBeforeFill = True
        '
        'frmStuHpvAdverseEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 581)
        Me.Controls.Add(VisitProcActIDLabel)
        Me.Controls.Add(Me.VisitProcActIDTextBox)
        Me.Controls.Add(AdEventsLogIDLabel)
        Me.Controls.Add(Me.AdEventsLogIDTextBox)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grpInterventions)
        Me.Controls.Add(Me.grpSymptoms)
        Me.Controls.Add(Me.grpAdverseEvent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStuHpvAdverseEvent"
        Me.Text = "Adverse Event"
        Me.grpInterventions.ResumeLayout(False)
        Me.grpInterventions.PerformLayout()
        CType(Me.BindingNavigatorInterventions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorInterventions.ResumeLayout(False)
        Me.BindingNavigatorInterventions.PerformLayout()
        CType(Me.TbStuHpvAdEventsInterventionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbStuHpvAdEventsLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RiSdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdInterventions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvAdEventInterventionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSymptoms.ResumeLayout(False)
        Me.grpSymptoms.PerformLayout()
        CType(Me.BindingNavigatorSymptoms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorSymptoms.ResumeLayout(False)
        Me.BindingNavigatorSymptoms.PerformLayout()
        CType(Me.TbStuHpvAdEventsSymptomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSymptoms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvAdEventsSymptomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAdverseEvent.ResumeLayout(False)
        Me.grpAdverseEvent.PerformLayout()
        CType(Me.DdvResearcherBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvPhysicianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvYesNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvAdEventRelProtocolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvAdEventRecoveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvAdEventSeverityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvResearcherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpInterventions As System.Windows.Forms.GroupBox
    Friend WithEvents grpSymptoms As System.Windows.Forms.GroupBox
    Friend WithEvents grpAdverseEvent As System.Windows.Forms.GroupBox
    Friend WithEvents TbStuHpvAdEventsLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbStuHpvAdEventsLogTableAdapter As RIS.RISdataDataSettableadapters.tbStuHpvAdEventsLogTableAdapter
    Friend WithEvents ResearcherCdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PhysicianCdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IncreaseRiskYNCdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RelProtocolIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RecoveryIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SeverityIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SeriousEventYNCdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateOnsetDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NoAdEventYNCdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents grdInterventions As System.Windows.Forms.DataGridView
    Friend WithEvents grdSymptoms As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents RiSdataDataSet As RIS.RISdataDataSet
    Friend WithEvents TbStuHpvAdEventsSymptomsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbStuHpvAdEventsSymptomsTableAdapter As RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsSymptomsTableAdapter
    Friend WithEvents TbStuHpvAdEventsInterventionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbStuHpvAdEventsInterventionsTableAdapter As RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsInterventionsTableAdapter
    Friend WithEvents DdvResearcherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvResearcherTableAdapter As RIS.RISdataDataSettableadapters.ddvResearcherTableAdapter
    Friend WithEvents DdvResearcherBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DdvYesNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvYesNoTableAdapter As RIS.RISdataDataSettableadapters.ddvYesNoTableAdapter
    Friend WithEvents DdvPhysicianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvPhysicianTableAdapter As RIS.RISdataDataSettableadapters.ddvPhysicianTableAdapter
    Friend WithEvents DdvAdEventSeverityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvAdEventSeverityTableAdapter As RIS.RISdataDataSettableadapters.ddvAdEventSeverityTableAdapter
    Friend WithEvents DdvAdEventRecoveryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvAdEventRecoveryTableAdapter As RIS.RISdataDataSettableadapters.ddvAdEventRecoveryTableAdapter
    Friend WithEvents DdvAdEventRelProtocolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvAdEventRelProtocolTableAdapter As RIS.RISdataDataSettableadapters.ddvAdEventRelProtocolTableAdapter
    Friend WithEvents BindingNavigatorInterventions As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSymptoms As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VisitProcActIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdEventsLogIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DdvAdEventInterventionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvAdEventInterventionTableAdapter As RIS.RISdataDataSettableadapters.ddvAdEventInterventionTableAdapter
    Friend WithEvents AdEventsInterIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEventsLogIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEvInterventionCdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEvInterventionOtherDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DdvAdEventsSymptomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvAdEventsSymptomTableAdapter As RIS.RISdataDataSetTableAdapters.ddvAdEventsSymptomTableAdapter
    Friend WithEvents AdEventsSymptomsIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEventsLogIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEvSymptomCdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEvSymptomOtherDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
