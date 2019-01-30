<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncentiveLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncentiveLogs))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabMovieTickets = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.bnMovieTickets = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bsMovie = New System.Windows.Forms.BindingSource(Me.components)
        Me.RISdataDataSet2 = New RIS.RISdataDataSet
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSaveMovieTickets = New System.Windows.Forms.ToolStripButton
        Me.btnMTCancelChanges = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpMovieTo = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dtpMovieFrom = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbMovieStudy = New System.Windows.Forms.ComboBox
        Me.TbStudyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnMovieRefresh = New System.Windows.Forms.Button
        Me.grdMovies = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerialNum = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DdvResearcherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tabGiftCards = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.bnGiftCards = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bsGiftCard = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSaveGiftCards = New System.Windows.Forms.ToolStripButton
        Me.btnGCCancelChanges = New System.Windows.Forms.ToolStripButton
        Me.grdGifts = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ResearcherCd = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpTodate = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dtpFromDate = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGiftsRefresh = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbStudy = New System.Windows.Forms.ComboBox
        Me.tabMetroCards = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.grdMetrocard = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsMetroCard = New System.Windows.Forms.BindingSource(Me.components)
        Me.bnMetroCard = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSaveMetroCards = New System.Windows.Forms.ToolStripButton
        Me.btnMCCancelChanges = New System.Windows.Forms.ToolStripButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtMToDt = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dtMFromDate = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdMetroRefresh = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboMetroStudy = New System.Windows.Forms.ComboBox
        Me.IncentiveLogTableAdapter = New RIS.RISdataDataSettableadapters.IncentiveLogTableAdapter
        Me.DdvResearcherTableAdapter = New RIS.RISdataDataSettableadapters.ddvResearcherTableAdapter
        Me.TbStudyTableAdapter = New RIS.RISdataDataSettableadapters.tbStudyTableAdapter
        Me.RiSdataDataSet = New RIS.RISdataDataSet
        Me.TabControl1.SuspendLayout()
        Me.tabMovieTickets.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.bnMovieTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnMovieTickets.SuspendLayout()
        CType(Me.bsMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RISdataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TbStudyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMovies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvResearcherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGiftCards.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bnGiftCards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnGiftCards.SuspendLayout()
        CType(Me.bsGiftCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGifts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tabMetroCards.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grdMetrocard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMetroCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnMetroCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnMetroCard.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RiSdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabMovieTickets)
        Me.TabControl1.Controls.Add(Me.tabGiftCards)
        Me.TabControl1.Controls.Add(Me.tabMetroCards)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(944, 538)
        Me.TabControl1.TabIndex = 0
        '
        'tabMovieTickets
        '
        Me.tabMovieTickets.Controls.Add(Me.Panel2)
        Me.tabMovieTickets.Controls.Add(Me.GroupBox1)
        Me.tabMovieTickets.Controls.Add(Me.grdMovies)
        Me.tabMovieTickets.Location = New System.Drawing.Point(4, 22)
        Me.tabMovieTickets.Name = "tabMovieTickets"
        Me.tabMovieTickets.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMovieTickets.Size = New System.Drawing.Size(936, 512)
        Me.tabMovieTickets.TabIndex = 0
        Me.tabMovieTickets.Text = "Movie Tickets"
        Me.tabMovieTickets.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.bnMovieTickets)
        Me.Panel2.Location = New System.Drawing.Point(3, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(930, 27)
        Me.Panel2.TabIndex = 12
        '
        'bnMovieTickets
        '
        Me.bnMovieTickets.AddNewItem = Nothing
        Me.bnMovieTickets.BindingSource = Me.bsMovie
        Me.bnMovieTickets.CountItem = Me.BindingNavigatorCountItem1
        Me.bnMovieTickets.DeleteItem = Nothing
        Me.bnMovieTickets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.btnSaveMovieTickets, Me.btnMTCancelChanges})
        Me.bnMovieTickets.Location = New System.Drawing.Point(0, 0)
        Me.bnMovieTickets.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.bnMovieTickets.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.bnMovieTickets.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.bnMovieTickets.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.bnMovieTickets.Name = "bnMovieTickets"
        Me.bnMovieTickets.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bnMovieTickets.Size = New System.Drawing.Size(930, 25)
        Me.bnMovieTickets.TabIndex = 15
        Me.bnMovieTickets.Text = "BindingNavigator1"
        '
        'bsMovie
        '
        Me.bsMovie.DataMember = "IncentiveLog"
        Me.bsMovie.DataSource = Me.RISdataDataSet2
        '
        'RISdataDataSet2
        '
        Me.RISdataDataSet2.DataSetName = "RISdataDataSet"
        Me.RISdataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnSaveMovieTickets
        '
        Me.btnSaveMovieTickets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveMovieTickets.Enabled = False
        Me.btnSaveMovieTickets.Image = CType(resources.GetObject("btnSaveMovieTickets.Image"), System.Drawing.Image)
        Me.btnSaveMovieTickets.Name = "btnSaveMovieTickets"
        Me.btnSaveMovieTickets.Size = New System.Drawing.Size(23, 22)
        Me.btnSaveMovieTickets.Text = "Save Data"
        '
        'btnMTCancelChanges
        '
        Me.btnMTCancelChanges.Image = CType(resources.GetObject("btnMTCancelChanges.Image"), System.Drawing.Image)
        Me.btnMTCancelChanges.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMTCancelChanges.Name = "btnMTCancelChanges"
        Me.btnMTCancelChanges.Size = New System.Drawing.Size(104, 22)
        Me.btnMTCancelChanges.Text = "Cancel Changes"
        Me.btnMTCancelChanges.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtpMovieTo)
        Me.GroupBox1.Controls.Add(Me.dtpMovieFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbMovieStudy)
        Me.GroupBox1.Controls.Add(Me.btnMovieRefresh)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 80)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter By Study and Date Range"
        '
        'dtpMovieTo
        '
        Me.dtpMovieTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMovieTo.Location = New System.Drawing.Point(264, 44)
        Me.dtpMovieTo.Name = "dtpMovieTo"
        Me.dtpMovieTo.ShowCheckBox = True
        Me.dtpMovieTo.Size = New System.Drawing.Size(110, 20)
        Me.dtpMovieTo.TabIndex = 15
        Me.dtpMovieTo.Value = New Date(2008, 8, 6, 17, 24, 12, 297)
        '
        'dtpMovieFrom
        '
        Me.dtpMovieFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMovieFrom.Location = New System.Drawing.Point(146, 44)
        Me.dtpMovieFrom.Name = "dtpMovieFrom"
        Me.dtpMovieFrom.ShowCheckBox = True
        Me.dtpMovieFrom.Size = New System.Drawing.Size(110, 20)
        Me.dtpMovieFrom.TabIndex = 14
        Me.dtpMovieFrom.Value = New Date(2008, 8, 6, 17, 24, 12, 297)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Study:"
        '
        'cmbMovieStudy
        '
        Me.cmbMovieStudy.DataSource = Me.TbStudyBindingSource
        Me.cmbMovieStudy.DisplayMember = "StudyDesc"
        Me.cmbMovieStudy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMovieStudy.FormattingEnabled = True
        Me.cmbMovieStudy.Location = New System.Drawing.Point(9, 44)
        Me.cmbMovieStudy.Name = "cmbMovieStudy"
        Me.cmbMovieStudy.Size = New System.Drawing.Size(133, 21)
        Me.cmbMovieStudy.TabIndex = 10
        Me.cmbMovieStudy.ValueMember = "StudyCd"
        '
        'TbStudyBindingSource
        '
        Me.TbStudyBindingSource.DataMember = "tbStudy"
        Me.TbStudyBindingSource.DataSource = Me.RISdataDataSet2
        '
        'btnMovieRefresh
        '
        Me.btnMovieRefresh.Location = New System.Drawing.Point(382, 43)
        Me.btnMovieRefresh.Name = "btnMovieRefresh"
        Me.btnMovieRefresh.Size = New System.Drawing.Size(75, 21)
        Me.btnMovieRefresh.TabIndex = 9
        Me.btnMovieRefresh.Text = "Refresh"
        Me.btnMovieRefresh.UseVisualStyleBackColor = True
        '
        'grdMovies
        '
        Me.grdMovies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMovies.AutoGenerateColumns = False
        Me.grdMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdMovies.BackgroundColor = System.Drawing.Color.White
        Me.grdMovies.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.SerialNum, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn7})
        Me.grdMovies.DataSource = Me.bsMovie
        Me.grdMovies.Location = New System.Drawing.Point(3, 120)
        Me.grdMovies.Name = "grdMovies"
        Me.grdMovies.Size = New System.Drawing.Size(930, 389)
        Me.grdMovies.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FormDesc"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Incentive"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VisitDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Visit Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SubjectID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Subject ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VisitNumDescShort"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Visit Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'SerialNum
        '
        Me.SerialNum.DataPropertyName = "SerialNum"
        Me.SerialNum.HeaderText = "Serial Number"
        Me.SerialNum.Name = "SerialNum"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "ResearcherCd"
        Me.DataGridViewComboBoxColumn1.DataSource = Me.DdvResearcherBindingSource
        Me.DataGridViewComboBoxColumn1.DisplayMember = "FirstName"
        Me.DataGridViewComboBoxColumn1.HeaderText = "Researcher"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ValueMember = "ResearcherCd"
        '
        'DdvResearcherBindingSource
        '
        Me.DdvResearcherBindingSource.DataMember = "ddvResearcher"
        Me.DdvResearcherBindingSource.DataSource = Me.RISdataDataSet2
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Amount"
        DataGridViewCellStyle1.Format = "C2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'tabGiftCards
        '
        Me.tabGiftCards.Controls.Add(Me.Panel1)
        Me.tabGiftCards.Controls.Add(Me.grdGifts)
        Me.tabGiftCards.Controls.Add(Me.GroupBox2)
        Me.tabGiftCards.Location = New System.Drawing.Point(4, 22)
        Me.tabGiftCards.Name = "tabGiftCards"
        Me.tabGiftCards.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGiftCards.Size = New System.Drawing.Size(936, 512)
        Me.tabGiftCards.TabIndex = 1
        Me.tabGiftCards.Text = "Gift Cards"
        Me.tabGiftCards.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.bnGiftCards)
        Me.Panel1.Location = New System.Drawing.Point(3, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(930, 27)
        Me.Panel1.TabIndex = 18
        '
        'bnGiftCards
        '
        Me.bnGiftCards.AddNewItem = Nothing
        Me.bnGiftCards.BindingSource = Me.bsGiftCard
        Me.bnGiftCards.CountItem = Me.ToolStripLabel1
        Me.bnGiftCards.DeleteItem = Nothing
        Me.bnGiftCards.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.btnSaveGiftCards, Me.btnGCCancelChanges})
        Me.bnGiftCards.Location = New System.Drawing.Point(0, 0)
        Me.bnGiftCards.MoveFirstItem = Me.ToolStripButton3
        Me.bnGiftCards.MoveLastItem = Me.ToolStripButton6
        Me.bnGiftCards.MoveNextItem = Me.ToolStripButton5
        Me.bnGiftCards.MovePreviousItem = Me.ToolStripButton4
        Me.bnGiftCards.Name = "bnGiftCards"
        Me.bnGiftCards.PositionItem = Me.ToolStripTextBox1
        Me.bnGiftCards.Size = New System.Drawing.Size(930, 25)
        Me.bnGiftCards.Stretch = True
        Me.bnGiftCards.TabIndex = 5
        Me.bnGiftCards.Text = "BindingNavigator1"
        '
        'bsGiftCard
        '
        Me.bsGiftCard.DataMember = "IncentiveLog"
        Me.bsGiftCard.DataSource = Me.RISdataDataSet2
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnSaveGiftCards
        '
        Me.btnSaveGiftCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveGiftCards.Enabled = False
        Me.btnSaveGiftCards.Image = CType(resources.GetObject("btnSaveGiftCards.Image"), System.Drawing.Image)
        Me.btnSaveGiftCards.Name = "btnSaveGiftCards"
        Me.btnSaveGiftCards.Size = New System.Drawing.Size(23, 22)
        Me.btnSaveGiftCards.Text = "Save Data"
        '
        'btnGCCancelChanges
        '
        Me.btnGCCancelChanges.Image = CType(resources.GetObject("btnGCCancelChanges.Image"), System.Drawing.Image)
        Me.btnGCCancelChanges.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGCCancelChanges.Name = "btnGCCancelChanges"
        Me.btnGCCancelChanges.Size = New System.Drawing.Size(104, 22)
        Me.btnGCCancelChanges.Text = "Cancel Changes"
        Me.btnGCCancelChanges.Visible = False
        '
        'grdGifts
        '
        Me.grdGifts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGifts.AutoGenerateColumns = False
        Me.grdGifts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdGifts.BackgroundColor = System.Drawing.Color.White
        Me.grdGifts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.ResearcherCd, Me.DataGridViewTextBoxColumn16})
        Me.grdGifts.DataSource = Me.bsGiftCard
        Me.grdGifts.Location = New System.Drawing.Point(3, 117)
        Me.grdGifts.Name = "grdGifts"
        Me.grdGifts.Size = New System.Drawing.Size(930, 392)
        Me.grdGifts.TabIndex = 1
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FormDesc"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Incentive"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "VisitDate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Visit Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn10.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SubjectID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Subject ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "VisitNumDescShort"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Visit Number"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SerialNum"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'ResearcherCd
        '
        Me.ResearcherCd.DataPropertyName = "ResearcherCd"
        Me.ResearcherCd.DataSource = Me.DdvResearcherBindingSource
        Me.ResearcherCd.DisplayMember = "FirstName"
        Me.ResearcherCd.HeaderText = "Researcher  "
        Me.ResearcherCd.Name = "ResearcherCd"
        Me.ResearcherCd.ValueMember = "ResearcherCd"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Amount"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn16.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dtpTodate)
        Me.GroupBox2.Controls.Add(Me.dtpFromDate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnGiftsRefresh)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbStudy)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 80)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter By Study and Date Range"
        '
        'dtpTodate
        '
        Me.dtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTodate.Location = New System.Drawing.Point(264, 44)
        Me.dtpTodate.Name = "dtpTodate"
        Me.dtpTodate.ShowCheckBox = True
        Me.dtpTodate.Size = New System.Drawing.Size(110, 20)
        Me.dtpTodate.TabIndex = 18
        Me.dtpTodate.Value = New Date(2008, 8, 6, 17, 22, 49, 735)
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(146, 44)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.ShowCheckBox = True
        Me.dtpFromDate.Size = New System.Drawing.Size(110, 20)
        Me.dtpFromDate.TabIndex = 17
        Me.dtpFromDate.Value = New Date(2008, 8, 6, 17, 22, 49, 719)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "To:"
        '
        'btnGiftsRefresh
        '
        Me.btnGiftsRefresh.Location = New System.Drawing.Point(382, 43)
        Me.btnGiftsRefresh.Name = "btnGiftsRefresh"
        Me.btnGiftsRefresh.Size = New System.Drawing.Size(75, 21)
        Me.btnGiftsRefresh.TabIndex = 5
        Me.btnGiftsRefresh.Text = "Refresh"
        Me.btnGiftsRefresh.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "From:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Study:"
        '
        'cmbStudy
        '
        Me.cmbStudy.DataSource = Me.TbStudyBindingSource
        Me.cmbStudy.DisplayMember = "StudyDesc"
        Me.cmbStudy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudy.FormattingEnabled = True
        Me.cmbStudy.Location = New System.Drawing.Point(9, 44)
        Me.cmbStudy.Name = "cmbStudy"
        Me.cmbStudy.Size = New System.Drawing.Size(133, 21)
        Me.cmbStudy.TabIndex = 6
        Me.cmbStudy.ValueMember = "StudyCd"
        '
        'tabMetroCards
        '
        Me.tabMetroCards.Controls.Add(Me.Panel3)
        Me.tabMetroCards.Controls.Add(Me.GroupBox3)
        Me.tabMetroCards.Location = New System.Drawing.Point(4, 22)
        Me.tabMetroCards.Name = "tabMetroCards"
        Me.tabMetroCards.Size = New System.Drawing.Size(936, 512)
        Me.tabMetroCards.TabIndex = 2
        Me.tabMetroCards.Text = "Metro Cards"
        Me.tabMetroCards.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.grdMetrocard)
        Me.Panel3.Controls.Add(Me.bnMetroCard)
        Me.Panel3.Location = New System.Drawing.Point(3, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(930, 420)
        Me.Panel3.TabIndex = 20
        '
        'grdMetrocard
        '
        Me.grdMetrocard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMetrocard.AutoGenerateColumns = False
        Me.grdMetrocard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdMetrocard.BackgroundColor = System.Drawing.Color.White
        Me.grdMetrocard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewComboBoxColumn2, Me.DataGridViewTextBoxColumn24})
        Me.grdMetrocard.DataSource = Me.bsMetroCard
        Me.grdMetrocard.Location = New System.Drawing.Point(0, 25)
        Me.grdMetrocard.Name = "grdMetrocard"
        Me.grdMetrocard.Size = New System.Drawing.Size(930, 392)
        Me.grdMetrocard.TabIndex = 21
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FormDesc"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Incentive"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "VisitDate"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Visit Date"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn19.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "SubjectID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Subject ID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "VisitNumDescShort"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Visit Number"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "SerialNum"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.DataPropertyName = "ResearcherCd"
        Me.DataGridViewComboBoxColumn2.DataSource = Me.DdvResearcherBindingSource
        Me.DataGridViewComboBoxColumn2.DisplayMember = "FirstName"
        Me.DataGridViewComboBoxColumn2.HeaderText = "Researcher  "
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.ValueMember = "ResearcherCd"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Amount"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn24.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'bsMetroCard
        '
        Me.bsMetroCard.DataMember = "IncentiveLog"
        Me.bsMetroCard.DataSource = Me.RISdataDataSet2
        '
        'bnMetroCard
        '
        Me.bnMetroCard.AddNewItem = Nothing
        Me.bnMetroCard.BindingSource = Me.bsMetroCard
        Me.bnMetroCard.CountItem = Me.ToolStripLabel2
        Me.bnMetroCard.DeleteItem = Nothing
        Me.bnMetroCard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripSeparator6, Me.btnSaveMetroCards, Me.btnMCCancelChanges})
        Me.bnMetroCard.Location = New System.Drawing.Point(0, 0)
        Me.bnMetroCard.MoveFirstItem = Me.ToolStripButton1
        Me.bnMetroCard.MoveLastItem = Me.ToolStripButton8
        Me.bnMetroCard.MoveNextItem = Me.ToolStripButton7
        Me.bnMetroCard.MovePreviousItem = Me.ToolStripButton2
        Me.bnMetroCard.Name = "bnMetroCard"
        Me.bnMetroCard.PositionItem = Me.ToolStripTextBox2
        Me.bnMetroCard.Size = New System.Drawing.Size(930, 25)
        Me.bnMetroCard.Stretch = True
        Me.bnMetroCard.TabIndex = 20
        Me.bnMetroCard.Text = "BindingNavigator1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Move next"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnSaveMetroCards
        '
        Me.btnSaveMetroCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveMetroCards.Enabled = False
        Me.btnSaveMetroCards.Image = CType(resources.GetObject("btnSaveMetroCards.Image"), System.Drawing.Image)
        Me.btnSaveMetroCards.Name = "btnSaveMetroCards"
        Me.btnSaveMetroCards.Size = New System.Drawing.Size(23, 22)
        Me.btnSaveMetroCards.Text = "Save Data"
        '
        'btnMCCancelChanges
        '
        Me.btnMCCancelChanges.Image = CType(resources.GetObject("btnMCCancelChanges.Image"), System.Drawing.Image)
        Me.btnMCCancelChanges.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMCCancelChanges.Name = "btnMCCancelChanges"
        Me.btnMCCancelChanges.Size = New System.Drawing.Size(104, 22)
        Me.btnMCCancelChanges.Text = "Cancel Changes"
        Me.btnMCCancelChanges.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dtMToDt)
        Me.GroupBox3.Controls.Add(Me.dtMFromDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmdMetroRefresh)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cboMetroStudy)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(930, 80)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter By Study and Date Range"
        '
        'dtMToDt
        '
        Me.dtMToDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMToDt.Location = New System.Drawing.Point(264, 44)
        Me.dtMToDt.Name = "dtMToDt"
        Me.dtMToDt.ShowCheckBox = True
        Me.dtMToDt.Size = New System.Drawing.Size(110, 20)
        Me.dtMToDt.TabIndex = 18
        Me.dtMToDt.Value = New Date(2008, 8, 6, 17, 22, 49, 735)
        '
        'dtMFromDate
        '
        Me.dtMFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMFromDate.Location = New System.Drawing.Point(146, 44)
        Me.dtMFromDate.Name = "dtMFromDate"
        Me.dtMFromDate.ShowCheckBox = True
        Me.dtMFromDate.Size = New System.Drawing.Size(110, 20)
        Me.dtMFromDate.TabIndex = 17
        Me.dtMFromDate.Value = New Date(2008, 8, 6, 17, 22, 49, 719)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "To:"
        '
        'cmdMetroRefresh
        '
        Me.cmdMetroRefresh.Location = New System.Drawing.Point(382, 43)
        Me.cmdMetroRefresh.Name = "cmdMetroRefresh"
        Me.cmdMetroRefresh.Size = New System.Drawing.Size(75, 21)
        Me.cmdMetroRefresh.TabIndex = 5
        Me.cmdMetroRefresh.Text = "Refresh"
        Me.cmdMetroRefresh.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(146, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "From:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Study:"
        '
        'cboMetroStudy
        '
        Me.cboMetroStudy.DataSource = Me.TbStudyBindingSource
        Me.cboMetroStudy.DisplayMember = "StudyDesc"
        Me.cboMetroStudy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMetroStudy.FormattingEnabled = True
        Me.cboMetroStudy.Location = New System.Drawing.Point(9, 44)
        Me.cboMetroStudy.Name = "cboMetroStudy"
        Me.cboMetroStudy.Size = New System.Drawing.Size(133, 21)
        Me.cboMetroStudy.TabIndex = 6
        Me.cboMetroStudy.ValueMember = "StudyCd"
        '
        'IncentiveLogTableAdapter
        '
        Me.IncentiveLogTableAdapter.ClearBeforeFill = True
        '
        'DdvResearcherTableAdapter
        '
        Me.DdvResearcherTableAdapter.ClearBeforeFill = True
        '
        'TbStudyTableAdapter
        '
        Me.TbStudyTableAdapter.ClearBeforeFill = True
        '
        'RiSdataDataSet
        '
        Me.RiSdataDataSet.DataSetName = "RISdataDataSet"
        Me.RiSdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmIncentiveLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 538)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmIncentiveLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Incentive Logs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tabMovieTickets.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.bnMovieTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnMovieTickets.ResumeLayout(False)
        Me.bnMovieTickets.PerformLayout()
        CType(Me.bsMovie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RISdataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TbStudyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMovies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvResearcherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGiftCards.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bnGiftCards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnGiftCards.ResumeLayout(False)
        Me.bnGiftCards.PerformLayout()
        CType(Me.bsGiftCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGifts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabMetroCards.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.grdMetrocard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMetroCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnMetroCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnMetroCard.ResumeLayout(False)
        Me.bnMetroCard.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.RiSdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabMovieTickets As System.Windows.Forms.TabPage
    Friend WithEvents tabGiftCards As System.Windows.Forms.TabPage
    Friend WithEvents RISdataDataSet2 As RIS.RISdataDataSet
    Friend WithEvents bsMovie As System.Windows.Forms.BindingSource
    Friend WithEvents IncentiveLogTableAdapter As RIS.RISdataDataSetTableAdapters.IncentiveLogTableAdapter
    Friend WithEvents grdMovies As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdGifts As System.Windows.Forms.DataGridView
    Friend WithEvents bsGiftCard As System.Windows.Forms.BindingSource
    Friend WithEvents DdvResearcherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvResearcherTableAdapter As RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter
    Friend WithEvents TbStudyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbStudyTableAdapter As RIS.RISdataDataSetTableAdapters.tbStudyTableAdapter
    Friend WithEvents cmbMovieStudy As System.Windows.Forms.ComboBox
    Friend WithEvents btnMovieRefresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpMovieTo As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtpMovieFrom As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bnGiftCards As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSaveGiftCards As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGCCancelChanges As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResearcherCd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTodate As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtpFromDate As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGiftsRefresh As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbStudy As System.Windows.Forms.ComboBox
    Friend WithEvents tabMetroCards As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtMToDt As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtMFromDate As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdMetroRefresh As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboMetroStudy As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents bsMetroCard As System.Windows.Forms.BindingSource
    Friend WithEvents grdMetrocard As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bnMetroCard As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSaveMetroCards As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMCCancelChanges As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnMovieTickets As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSaveMovieTickets As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMTCancelChanges As System.Windows.Forms.ToolStripButton
    Friend WithEvents RiSdataDataSet As RIS.RISdataDataSet
End Class
