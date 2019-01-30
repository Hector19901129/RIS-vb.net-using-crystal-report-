Imports System.Data.OleDb
Imports vb = Microsoft.VisualBasic.Strings
Imports System.Runtime.InteropServices 'For ListViewColumnOrder
Imports RIS.DataSet1

Public Class frmPatient    
    Inherits System.Windows.Forms.Form    
    Dim lvw1_ColumnClicked As Boolean
    Dim cboStudyOldValue As String
    Dim FormActivated As Boolean = False
    Dim HPVNUMBEROFVISITS As Integer = 6
    Dim booCiCanMailReminder As Boolean = False
    Dim booCiCanTextMessage As Boolean = False

    Dim lvw0XSelectedIndex As Integer
    Dim lvwHpvEpiXSelectedIndex As Integer
    Dim lvwHpvVstXSelectedIndex As Integer

    Const LVM_FIRST As Integer = &H1000
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtWhoIs As System.Windows.Forms.TextBox
    Friend WithEvents lvwHpvBS As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvBsC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvBsC5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelHpvBS As System.Windows.Forms.Button
    Friend WithEvents btnAddHpvBS As System.Windows.Forms.Button
    Friend WithEvents btnEditHpvBS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHpvBlood4 As System.Windows.Forms.TextBox
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents txtHpvBlood3 As System.Windows.Forms.TextBox
    Friend WithEvents txtHpvBlood2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHpvBlood1 As System.Windows.Forms.TextBox
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents txtHpvBloodVisitProcActID As System.Windows.Forms.TextBox
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents RiSdataDataSet As RIS.RISdataDataSet
    Friend WithEvents TbStuHpvAdEventsLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbStuHpvAdEventsLogTableAdapter As RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsLogTableAdapter
    Friend WithEvents tabHpvVstAdveresEvent As System.Windows.Forms.TabPage
    Friend WithEvents grpInterventions As System.Windows.Forms.GroupBox
    Friend WithEvents grdInterventions As System.Windows.Forms.DataGridView
    Friend WithEvents grpSymptoms As System.Windows.Forms.GroupBox
    Friend WithEvents grdSymptoms As System.Windows.Forms.DataGridView
    Friend WithEvents grpAdverseEvent As System.Windows.Forms.GroupBox
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
    Friend WithEvents TbStuHpvAdEventsSymptomsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbStuHpvAdEventsSymptomsTableAdapter As RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsSymptomsTableAdapter
    Friend WithEvents TbStuHpvAdEventsInterventionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbStuHpvAdEventsInterventionsTableAdapter As RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsInterventionsTableAdapter
    Friend WithEvents DdvYesNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvYesNoTableAdapter As RIS.RISdataDataSetTableAdapters.ddvYesNoTableAdapter
    Friend WithEvents DdvResearcherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvResearcherTableAdapter As RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter
    Friend WithEvents DdvPhysicianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvPhysicianTableAdapter As RIS.RISdataDataSetTableAdapters.ddvPhysicianTableAdapter
    Friend WithEvents DdvAdEventSeverityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvAdEventSeverityTableAdapter As RIS.RISdataDataSetTableAdapters.ddvAdEventSeverityTableAdapter
    Friend WithEvents DdvAdEventRelProtocolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvAdEventRelProtocolTableAdapter As RIS.RISdataDataSetTableAdapters.ddvAdEventRelProtocolTableAdapter
    Friend WithEvents DdvAdEventRecoveryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvAdEventRecoveryTableAdapter As RIS.RISdataDataSettableadapters.ddvAdEventRecoveryTableAdapter
    Friend WithEvents AdEventsInterIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEventsLogIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEvInterventionCdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterventionDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEvInterventionOtherDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEventsSymptomsIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEventsLogIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEvSymptomCdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SymptomDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdEvSymptomOtherDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lvwHpvEpiC7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabPregnancies As System.Windows.Forms.TabPage
    Friend WithEvents bsPregnancy As System.Windows.Forms.BindingSource
    Friend WithEvents taPregnancy As RIS.RISdataDataSetTableAdapters.tbPregnancyTableAdapter
    Friend WithEvents grdPregnancies As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents btnAddPregnancy As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnDeletePregnancy As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSavePregnancy As System.Windows.Forms.ToolStripButton
    Friend WithEvents TbImmunizationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbImmunizationsTableAdapter As RIS.RISdataDataSettableadapters.tbImmunizationsTableAdapter
    Friend WithEvents Dose1CompletedLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose1DateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose4DateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose3PODLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose3DoneInAHCLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose3CompletedLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose3DateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose2PODLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose2DoneInAHCLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose2CompletedLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose2DateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose1PODLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose1DoneInAHCLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Dose4CompletedLabel1 As System.Windows.Forms.Label
    Friend WithEvents NotesLabel2 As System.Windows.Forms.Label
    Friend WithEvents Dose5PODLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose5DoneInAHCLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose5CompletedLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose5DateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose4PODLabel1 As System.Windows.Forms.Label
    Friend WithEvents Dose4DoneInAHCLabel1 As System.Windows.Forms.Label
    Friend WithEvents TbPregnancyOutcomeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbPregnancyOutcomeTableAdapter As RIS.RISdataDataSettableadapters.tbPregnancyOutcomeTableAdapter
    Friend WithEvents grdPregnancyOutcome As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents btnAddPregOutcome As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnDeletePregOutcome As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DdvPregnancyOutcomeTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvPregnancyOutcomeTypeTableAdapter As RIS.RISdataDataSetTableAdapters.ddvPregnancyOutcomeTypeTableAdapter
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateMenstrual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUrineTest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuestCompDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lvwHpvEpiC10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstC5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboOutComeOfPreg As System.Windows.Forms.ComboBox
    Friend WithEvents TbStuHpvEpisodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbStuHpvEpisodeTableAdapter As RIS.DataSet1TableAdapters.tbStuHpvEpisodeTableAdapter
    Friend WithEvents lvwHpvEpiC14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC17 As System.Windows.Forms.ColumnHeader
    'For ListViewColumnOrder
    Const LVM_SETCOLUMNORDERARRAY = LVM_FIRST + 58 'For ListViewColumnOrder


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        'Application.EnableVisualStyles()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents splitVer1 As System.Windows.Forms.Splitter
    Friend WithEvents Tab1 As System.Windows.Forms.TabControl
    Friend WithEvents lvw0 As System.Windows.Forms.ListView
    Friend WithEvents Tab1P2 As System.Windows.Forms.TabPage
    Friend WithEvents Tab1P3 As System.Windows.Forms.TabPage
    Friend WithEvents ils16X16 As System.Windows.Forms.ImageList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tab1P1 As System.Windows.Forms.TabPage
    Friend WithEvents tabCts As System.Windows.Forms.TabControl
    Friend WithEvents tabCtsP2 As System.Windows.Forms.TabPage
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents tabCtsP1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboStudy As System.Windows.Forms.ComboBox
    Friend WithEvents lvw0C1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvw0C2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvw0C3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvw0C5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvw0C4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwStudy As System.Windows.Forms.ListView
    Friend WithEvents lvwStudyC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents btnDelPat As System.Windows.Forms.Button
    Friend WithEvents btnAddPat As System.Windows.Forms.Button
    Friend WithEvents btnEditPat As System.Windows.Forms.Button
    Friend WithEvents rbFindPt3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFindPt2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFindPt1 As System.Windows.Forms.RadioButton
    Friend WithEvents tabHpv As System.Windows.Forms.TabControl
    Friend WithEvents txtMRN As System.Windows.Forms.TextBox
    Friend WithEvents txtDateOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents btnDelHpvVst As System.Windows.Forms.Button
    Friend WithEvents btnAddHpvVst As System.Windows.Forms.Button
    Friend WithEvents btnEditHpvVst As System.Windows.Forms.Button
    Friend WithEvents lvwHpvVst As System.Windows.Forms.ListView
    Friend WithEvents tabHpvVst As System.Windows.Forms.TabControl
    Friend WithEvents txtLastEditDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents txtVisitID As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents grpProgressInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblHpvVstDate6 As System.Windows.Forms.Label
    Friend WithEvents lblHpvVstDate5 As System.Windows.Forms.Label
    Friend WithEvents lblHpvVstDate4 As System.Windows.Forms.Label
    Friend WithEvents lblHpvVstDate3 As System.Windows.Forms.Label
    Friend WithEvents lblHpvVstDate2 As System.Windows.Forms.Label
    Friend WithEvents lblHpvVstDate1 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents spbHpvNumVisits As SPB.SmoothProgressBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHpvProjected As System.Windows.Forms.Label
    Friend WithEvents lvwHpvVstVac As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstSpec As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstProc As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstVacC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstSpecC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstProcC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstFormPF As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstFormPFC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstFormR As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstFormRC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstFormRC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstProcC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstSpecC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstVacC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstC0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents chkRace6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEthnicity3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbEthnicity2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbEthnicity1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtRace As System.Windows.Forms.TextBox
    Friend WithEvents txtEthnicity As System.Windows.Forms.TextBox
    Friend WithEvents lvwStudyC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwStudyC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwStudyC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCtsSlfZip As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsSlfState As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsSlfCity As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsSlfAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnEditCtsSlf As System.Windows.Forms.Button
    Friend WithEvents chkCtsSlfCanMailReminder As System.Windows.Forms.CheckBox
    Friend WithEvents txtCtsFrd1FirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsFrd1LastName As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabCtsP3 As System.Windows.Forms.TabPage
    Friend WithEvents btnEditCtsFrd1 As System.Windows.Forms.Button
    Friend WithEvents btnEditCtsFrd2 As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCtsSlf As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCtsFrd1 As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCtsFrd2 As System.Windows.Forms.Button
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents tabHpvP1 As System.Windows.Forms.TabPage
    Friend WithEvents tabHpvP2 As System.Windows.Forms.TabPage
    Friend WithEvents lvwHpvSpecSent As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvSpecSentC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvSpecSentC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpi As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvEpiC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelHpvEpi As System.Windows.Forms.Button
    Friend WithEvents btnAddHpvEpi As System.Windows.Forms.Button
    Friend WithEvents btnEditHpvEpi As System.Windows.Forms.Button
    Friend WithEvents grpSearchBy As System.Windows.Forms.GroupBox
    Friend WithEvents lblNoPatients As System.Windows.Forms.Label
    Friend WithEvents spbHpvVst1 As SPB.SmoothProgressBar
    Friend WithEvents spbHpvVst2 As SPB.SmoothProgressBar
    Friend WithEvents spbHpvVst3 As SPB.SmoothProgressBar
    Friend WithEvents spbHpvVst4 As SPB.SmoothProgressBar
    Friend WithEvents spbHpvVst6 As SPB.SmoothProgressBar
    Friend WithEvents spbHpvVst5 As SPB.SmoothProgressBar
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents btnDelScrnForm As System.Windows.Forms.Button
    Friend WithEvents btnEditScrnForm As System.Windows.Forms.Button
    Friend WithEvents lblNoHpvEpisodes As System.Windows.Forms.Label
    Friend WithEvents lblNoHpvVisits As System.Windows.Forms.Label
    Friend WithEvents da1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents da1SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents grpHpvSfPlanToLeaveNYC As System.Windows.Forms.GroupBox
    Friend WithEvents rbScrFrmNo8 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes8 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPreg3 As System.Windows.Forms.Label
    Friend WithEvents grpHpvSfEndPregnancy As System.Windows.Forms.GroupBox
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents lblPreg6 As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents lblPreg1 As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents grpHpvSfHPVvaccinated As System.Windows.Forms.GroupBox
    Friend WithEvents rbScrFrmNo5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes5 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPreg5 As System.Windows.Forms.Label
    Friend WithEvents grpHpvSfHasPeriod As System.Windows.Forms.GroupBox
    Friend WithEvents rbScrFrmNo4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes4 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPreg4 As System.Windows.Forms.Label
    Friend WithEvents grpHpvSfThoughtPregnant As System.Windows.Forms.GroupBox
    Friend WithEvents rbScrFrmNo3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes3 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPreg2 As System.Windows.Forms.Label
    Friend WithEvents grpHpvSfCurrentlyPregnant As System.Windows.Forms.GroupBox
    Friend WithEvents rbScrFrmNo2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents grpHpvSfWantHPVvaccine As System.Windows.Forms.GroupBox
    Friend WithEvents rbScrFrmNo6 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes6 As System.Windows.Forms.RadioButton
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents grpHpvSfSexuallyActive As System.Windows.Forms.GroupBox
    Friend WithEvents rbScrFrmNo1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes1 As System.Windows.Forms.RadioButton
    Friend WithEvents grpHpvSfSexualActType As System.Windows.Forms.GroupBox
    Friend WithEvents chkScrFrm1_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrFrm1_1 As System.Windows.Forms.CheckBox
    Friend WithEvents ds As RIS.DataSet1
    Friend WithEvents txtDateScreened As System.Windows.Forms.TextBox
    Friend WithEvents txtEndPregnancyDate As System.Windows.Forms.TextBox
    Friend WithEvents lvwHpvVstFormPFC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiC5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents chkCtsSlfCanTextMessage As System.Windows.Forms.CheckBox
    Friend WithEvents lvwCtMthdSlf As System.Windows.Forms.ListView
    Friend WithEvents lvwCtMthdSlfC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlfC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlfC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfSpecialRequests As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsSlfAptNum As System.Windows.Forms.TextBox
    Friend WithEvents lvwCtMthdFrd1 As System.Windows.Forms.ListView
    Friend WithEvents lvwCtMthdFrd1C1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdFrd1C2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdFrd1C3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCtsFrd1SpecialRequests As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwCtMthdFrd2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents txtCtsFrd2SpecialRequests As System.Windows.Forms.TextBox
    Friend WithEvents tabHpvVstP2 As System.Windows.Forms.TabPage
    Friend WithEvents tabHpvVstP3 As System.Windows.Forms.TabPage
    Friend WithEvents tabHpvVstP4 As System.Windows.Forms.TabPage
    Friend WithEvents tabHpvVstP5 As System.Windows.Forms.TabPage
    Friend WithEvents tabHpvVstP1 As System.Windows.Forms.TabPage
    Friend WithEvents lvwHpvVstCtHxC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstCtHxC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstCtHxC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstCtHxC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstCtHxC5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvCtHx As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstC6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbRefreshLvw0 As System.Windows.Forms.ToolBar
    Friend WithEvents tbRefreshLvw0B1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents panAddEdit As System.Windows.Forms.Panel
    Friend WithEvents panHPVvstDates As System.Windows.Forms.Panel
    Friend WithEvents dtsHPVvstDate2 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtsHPVvstDate1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvEpiFU As System.Windows.Forms.ListView
    Friend WithEvents lblHpvEpiFU As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCtsFrd2LastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsFrd2FirstName As System.Windows.Forms.TextBox
    Friend WithEvents rtbCtsSlf As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCtsFrd1 As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbCtsFrd2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tabContactInfo As System.Windows.Forms.TabControl
    Friend WithEvents rtbContactInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents btnDelContactInfo As System.Windows.Forms.Button
    Friend WithEvents btnEditContactInfo As System.Windows.Forms.Button
    Friend WithEvents grpCiAddress As System.Windows.Forms.GroupBox
    Friend WithEvents chkCiCanMailReminder As System.Windows.Forms.CheckBox
    Friend WithEvents txtCiZip As System.Windows.Forms.TextBox
    Friend WithEvents txtCiState As System.Windows.Forms.TextBox
    Friend WithEvents txtCiCity As System.Windows.Forms.TextBox
    Friend WithEvents txtCiAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents chkCiCanTextMessage As System.Windows.Forms.CheckBox
    Friend WithEvents txtCiAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents grpCiContactName As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCiFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCiLastName As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lvwCiContactChoice As System.Windows.Forms.ListView
    Friend WithEvents txtCiSpecialRequests As System.Windows.Forms.TextBox
    Friend WithEvents txtHasAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtHasContact As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Dim Dose1DateLabel As System.Windows.Forms.Label
        Dim Dose1CompletedLabel As System.Windows.Forms.Label
        Dim Dose1DoneInAHCLabel As System.Windows.Forms.Label
        Dim Dose1PODLabel As System.Windows.Forms.Label
        Dim Dose2DateLabel As System.Windows.Forms.Label
        Dim Dose2CompletedLabel As System.Windows.Forms.Label
        Dim Dose2DoneInAHCLabel As System.Windows.Forms.Label
        Dim Dose2PODLabel As System.Windows.Forms.Label
        Dim Dose3DateLabel As System.Windows.Forms.Label
        Dim Dose3CompletedLabel As System.Windows.Forms.Label
        Dim Dose3DoneInAHCLabel As System.Windows.Forms.Label
        Dim Dose3PODLabel As System.Windows.Forms.Label
        Dim Dose4DateLabel As System.Windows.Forms.Label
        Dim Dose4CompletedLabel As System.Windows.Forms.Label
        Dim Dose4DoneInAHCLabel As System.Windows.Forms.Label
        Dim Dose4PODLabel As System.Windows.Forms.Label
        Dim Dose5DateLabel As System.Windows.Forms.Label
        Dim Dose5CompletedLabel As System.Windows.Forms.Label
        Dim Dose5DoneInAHCLabel As System.Windows.Forms.Label
        Dim Dose5PODLabel As System.Windows.Forms.Label
        Dim NotesLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatient))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboStudy = New System.Windows.Forms.ComboBox()
        Me.btnDelHpvEpi = New System.Windows.Forms.Button()
        Me.btnAddHpvEpi = New System.Windows.Forms.Button()
        Me.btnEditHpvEpi = New System.Windows.Forms.Button()
        Me.btnDelPat = New System.Windows.Forms.Button()
        Me.btnAddPat = New System.Windows.Forms.Button()
        Me.btnEditPat = New System.Windows.Forms.Button()
        Me.btnDelHpvVst = New System.Windows.Forms.Button()
        Me.btnAddHpvVst = New System.Windows.Forms.Button()
        Me.btnEditHpvVst = New System.Windows.Forms.Button()
        Me.btnDelScrnForm = New System.Windows.Forms.Button()
        Me.btnEditScrnForm = New System.Windows.Forms.Button()
        Me.tbRefreshLvw0 = New System.Windows.Forms.ToolBar()
        Me.tbRefreshLvw0B1 = New System.Windows.Forms.ToolBarButton()
        Me.ils16X16 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtsHPVvstDate2 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.dtsHPVvstDate1 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.btnDelContactInfo = New System.Windows.Forms.Button()
        Me.btnEditContactInfo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panAddEdit = New System.Windows.Forms.Panel()
        Me.grpSearchBy = New System.Windows.Forms.GroupBox()
        Me.rbFindPt3 = New System.Windows.Forms.RadioButton()
        Me.rbFindPt2 = New System.Windows.Forms.RadioButton()
        Me.rbFindPt1 = New System.Windows.Forms.RadioButton()
        Me.lvw0 = New System.Windows.Forms.ListView()
        Me.lvw0C1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvw0C2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvw0C3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvw0C4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvw0C5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panHPVvstDates = New System.Windows.Forms.Panel()
        Me.splitVer1 = New System.Windows.Forms.Splitter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.Tab1P1 = New System.Windows.Forms.TabPage()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.txtEthnicity = New System.Windows.Forms.TextBox()
        Me.rbEthnicity3 = New System.Windows.Forms.RadioButton()
        Me.rbEthnicity2 = New System.Windows.Forms.RadioButton()
        Me.rbEthnicity1 = New System.Windows.Forms.RadioButton()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.lvwStudy = New System.Windows.Forms.ListView()
        Me.lvwStudyC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwStudyC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwStudyC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwStudyC4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRace = New System.Windows.Forms.TextBox()
        Me.chkRace6 = New System.Windows.Forms.CheckBox()
        Me.chkRace5 = New System.Windows.Forms.CheckBox()
        Me.chkRace4 = New System.Windows.Forms.CheckBox()
        Me.chkRace3 = New System.Windows.Forms.CheckBox()
        Me.chkRace2 = New System.Windows.Forms.CheckBox()
        Me.chkRace1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Tab1P2 = New System.Windows.Forms.TabPage()
        Me.lvwCiContactChoice = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCiSpecialRequests = New System.Windows.Forms.TextBox()
        Me.tabCts = New System.Windows.Forms.TabControl()
        Me.tabCtsP1 = New System.Windows.Forms.TabPage()
        Me.btnDeleteCtsSlf = New System.Windows.Forms.Button()
        Me.btnEditCtsSlf = New System.Windows.Forms.Button()
        Me.rtbCtsSlf = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.chkCtsSlfCanMailReminder = New System.Windows.Forms.CheckBox()
        Me.txtCtsSlfZip = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtCtsSlfState = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtCtsSlfCity = New System.Windows.Forms.TextBox()
        Me.txtCtsSlfAddress = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.chkCtsSlfCanTextMessage = New System.Windows.Forms.CheckBox()
        Me.txtCtsSlfAptNum = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lvwCtMthdSlf = New System.Windows.Forms.ListView()
        Me.lvwCtMthdSlfC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwCtMthdSlfC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwCtMthdSlfC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtCtsSlfSpecialRequests = New System.Windows.Forms.TextBox()
        Me.tabCtsP2 = New System.Windows.Forms.TabPage()
        Me.rtbCtsFrd1 = New System.Windows.Forms.RichTextBox()
        Me.lvwCtMthdFrd1 = New System.Windows.Forms.ListView()
        Me.lvwCtMthdFrd1C1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwCtMthdFrd1C2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwCtMthdFrd1C3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCtsFrd1SpecialRequests = New System.Windows.Forms.TextBox()
        Me.btnDeleteCtsFrd1 = New System.Windows.Forms.Button()
        Me.btnEditCtsFrd1 = New System.Windows.Forms.Button()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txtCtsFrd1FirstName = New System.Windows.Forms.TextBox()
        Me.txtCtsFrd1LastName = New System.Windows.Forms.TextBox()
        Me.tabCtsP3 = New System.Windows.Forms.TabPage()
        Me.rtbCtsFrd2 = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCtsFrd2FirstName = New System.Windows.Forms.TextBox()
        Me.txtCtsFrd2LastName = New System.Windows.Forms.TextBox()
        Me.lvwCtMthdFrd2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label89 = New System.Windows.Forms.Label()
        Me.txtCtsFrd2SpecialRequests = New System.Windows.Forms.TextBox()
        Me.btnDeleteCtsFrd2 = New System.Windows.Forms.Button()
        Me.btnEditCtsFrd2 = New System.Windows.Forms.Button()
        Me.grpCiContactName = New System.Windows.Forms.GroupBox()
        Me.txtWhoIs = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCiFirstName = New System.Windows.Forms.TextBox()
        Me.txtCiLastName = New System.Windows.Forms.TextBox()
        Me.rtbContactInfo = New System.Windows.Forms.RichTextBox()
        Me.grpCiAddress = New System.Windows.Forms.GroupBox()
        Me.txtHasAddress = New System.Windows.Forms.TextBox()
        Me.txtHasContact = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkCiCanMailReminder = New System.Windows.Forms.CheckBox()
        Me.txtCiZip = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCiState = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCiCity = New System.Windows.Forms.TextBox()
        Me.txtCiAddress1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkCiCanTextMessage = New System.Windows.Forms.CheckBox()
        Me.txtCiAddress2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tabContactInfo = New System.Windows.Forms.TabControl()
        Me.Tab1P3 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblHpvEpiFU = New System.Windows.Forms.Label()
        Me.lvwHpvEpiFU = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpi = New System.Windows.Forms.ListView()
        Me.lvwHpvEpiC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvEpiC6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabHpv = New System.Windows.Forms.TabControl()
        Me.tabHpvP1 = New System.Windows.Forms.TabPage()
        Me.grpProgressInfo = New System.Windows.Forms.GroupBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.spbHpvVst6 = New SPB.SmoothProgressBar()
        Me.spbHpvVst5 = New SPB.SmoothProgressBar()
        Me.spbHpvVst4 = New SPB.SmoothProgressBar()
        Me.spbHpvVst3 = New SPB.SmoothProgressBar()
        Me.spbHpvVst2 = New SPB.SmoothProgressBar()
        Me.lblHpvProjected = New System.Windows.Forms.Label()
        Me.spbHpvVst1 = New SPB.SmoothProgressBar()
        Me.lblHpvVstDate6 = New System.Windows.Forms.Label()
        Me.lblHpvVstDate5 = New System.Windows.Forms.Label()
        Me.lblHpvVstDate4 = New System.Windows.Forms.Label()
        Me.lblHpvVstDate3 = New System.Windows.Forms.Label()
        Me.lblHpvVstDate2 = New System.Windows.Forms.Label()
        Me.lblHpvVstDate1 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.spbHpvNumVisits = New SPB.SmoothProgressBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabHpvVst = New System.Windows.Forms.TabControl()
        Me.tabHpvVstP1 = New System.Windows.Forms.TabPage()
        Me.lvwHpvCtHx = New System.Windows.Forms.ListView()
        Me.lvwHpvVstCtHxC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstCtHxC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstCtHxC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstCtHxC4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstCtHxC5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblNoHpvVisits = New System.Windows.Forms.Label()
        Me.tabHpvVstP2 = New System.Windows.Forms.TabPage()
        Me.lvwHpvVstVac = New System.Windows.Forms.ListView()
        Me.lvwHpvVstVacC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstVacC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstSpec = New System.Windows.Forms.ListView()
        Me.lvwHpvVstSpecC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstSpecC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstProc = New System.Windows.Forms.ListView()
        Me.lvwHpvVstProcC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstProcC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstFormR = New System.Windows.Forms.ListView()
        Me.lvwHpvVstFormRC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstFormRC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstFormPF = New System.Windows.Forms.ListView()
        Me.lvwHpvVstFormPFC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstFormPFC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabHpvVstP3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHpvBlood4 = New System.Windows.Forms.TextBox()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.txtHpvBlood3 = New System.Windows.Forms.TextBox()
        Me.txtHpvBlood2 = New System.Windows.Forms.TextBox()
        Me.txtHpvBlood1 = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.txtHpvBloodVisitProcActID = New System.Windows.Forms.TextBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.lvwHpvBS = New System.Windows.Forms.ListView()
        Me.lvwHpvBsC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvBsC5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelHpvBS = New System.Windows.Forms.Button()
        Me.btnAddHpvBS = New System.Windows.Forms.Button()
        Me.btnEditHpvBS = New System.Windows.Forms.Button()
        Me.tabHpvVstP4 = New System.Windows.Forms.TabPage()
        Me.lvwHpvSpecSent = New System.Windows.Forms.ListView()
        Me.lvwHpvSpecSentC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvSpecSentC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtLastEditDate = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.txtVisitID = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.tabHpvVstAdveresEvent = New System.Windows.Forms.TabPage()
        Me.grpInterventions = New System.Windows.Forms.GroupBox()
        Me.grdInterventions = New System.Windows.Forms.DataGridView()
        Me.AdEventsInterIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEventsLogIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEvInterventionCdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterventionDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbStuHpvAdEventsInterventionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RiSdataDataSet = New RIS.RISdataDataSet()
        Me.grpSymptoms = New System.Windows.Forms.GroupBox()
        Me.grdSymptoms = New System.Windows.Forms.DataGridView()
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEventsLogIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEvSymptomCdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymptomDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbStuHpvAdEventsSymptomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpAdverseEvent = New System.Windows.Forms.GroupBox()
        Me.ResearcherCdComboBox = New System.Windows.Forms.ComboBox()
        Me.TbStuHpvAdEventsLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DdvResearcherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.tabHpvVstP5 = New System.Windows.Forms.TabPage()
        Me.lvwHpvVst = New System.Windows.Forms.ListView()
        Me.lvwHpvVstC0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstC4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstC5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstC6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabHpvP2 = New System.Windows.Forms.TabPage()
        Me.txtDateScreened = New System.Windows.Forms.TextBox()
        Me.grpHpvSfEndPregnancy = New System.Windows.Forms.GroupBox()
        Me.cboOutComeOfPreg = New System.Windows.Forms.ComboBox()
        Me.DdvPregnancyOutcomeTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtEndPregnancyDate = New System.Windows.Forms.TextBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.lblPreg6 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.lblPreg1 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.grpHpvSfHPVvaccinated = New System.Windows.Forms.GroupBox()
        Me.rbScrFrmNo5 = New System.Windows.Forms.RadioButton()
        Me.rbScrFrmYes5 = New System.Windows.Forms.RadioButton()
        Me.lblPreg5 = New System.Windows.Forms.Label()
        Me.grpHpvSfHasPeriod = New System.Windows.Forms.GroupBox()
        Me.rbScrFrmNo4 = New System.Windows.Forms.RadioButton()
        Me.rbScrFrmYes4 = New System.Windows.Forms.RadioButton()
        Me.lblPreg4 = New System.Windows.Forms.Label()
        Me.grpHpvSfThoughtPregnant = New System.Windows.Forms.GroupBox()
        Me.rbScrFrmNo3 = New System.Windows.Forms.RadioButton()
        Me.rbScrFrmYes3 = New System.Windows.Forms.RadioButton()
        Me.lblPreg2 = New System.Windows.Forms.Label()
        Me.grpHpvSfCurrentlyPregnant = New System.Windows.Forms.GroupBox()
        Me.rbScrFrmNo2 = New System.Windows.Forms.RadioButton()
        Me.rbScrFrmYes2 = New System.Windows.Forms.RadioButton()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.grpHpvSfWantHPVvaccine = New System.Windows.Forms.GroupBox()
        Me.rbScrFrmNo6 = New System.Windows.Forms.RadioButton()
        Me.rbScrFrmYes6 = New System.Windows.Forms.RadioButton()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.grpHpvSfSexuallyActive = New System.Windows.Forms.GroupBox()
        Me.rbScrFrmNo1 = New System.Windows.Forms.RadioButton()
        Me.rbScrFrmYes1 = New System.Windows.Forms.RadioButton()
        Me.grpHpvSfSexualActType = New System.Windows.Forms.GroupBox()
        Me.chkScrFrm1_2 = New System.Windows.Forms.CheckBox()
        Me.chkScrFrm1_1 = New System.Windows.Forms.CheckBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.grpHpvSfPlanToLeaveNYC = New System.Windows.Forms.GroupBox()
        Me.rbScrFrmNo8 = New System.Windows.Forms.RadioButton()
        Me.rbScrFrmYes8 = New System.Windows.Forms.RadioButton()
        Me.lblPreg3 = New System.Windows.Forms.Label()
        Me.tabPregnancies = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.grdPregnancyOutcome = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbPregnancyOutcomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPregnancy = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnAddPregOutcome = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnDeletePregOutcome = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnAddPregnancy = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.btnDeletePregnancy = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSavePregnancy = New System.Windows.Forms.ToolStripButton()
        Me.grdPregnancies = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateMenstrual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUrineTest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuestCompDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NotesLabel2 = New System.Windows.Forms.Label()
        Me.TbImmunizationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dose5PODLabel1 = New System.Windows.Forms.Label()
        Me.Dose5DoneInAHCLabel1 = New System.Windows.Forms.Label()
        Me.Dose5CompletedLabel1 = New System.Windows.Forms.Label()
        Me.Dose5DateLabel1 = New System.Windows.Forms.Label()
        Me.Dose4PODLabel1 = New System.Windows.Forms.Label()
        Me.Dose4DoneInAHCLabel1 = New System.Windows.Forms.Label()
        Me.Dose4CompletedLabel1 = New System.Windows.Forms.Label()
        Me.Dose1DateLabel1 = New System.Windows.Forms.Label()
        Me.Dose4DateLabel1 = New System.Windows.Forms.Label()
        Me.Dose1CompletedLabel1 = New System.Windows.Forms.Label()
        Me.Dose3DoneInAHCLabel1 = New System.Windows.Forms.Label()
        Me.Dose1DoneInAHCLabel1 = New System.Windows.Forms.Label()
        Me.Dose1PODLabel1 = New System.Windows.Forms.Label()
        Me.Dose3CompletedLabel1 = New System.Windows.Forms.Label()
        Me.Dose2DateLabel1 = New System.Windows.Forms.Label()
        Me.Dose3DateLabel1 = New System.Windows.Forms.Label()
        Me.Dose2CompletedLabel1 = New System.Windows.Forms.Label()
        Me.Dose2PODLabel1 = New System.Windows.Forms.Label()
        Me.Dose2DoneInAHCLabel1 = New System.Windows.Forms.Label()
        Me.Dose3PODLabel1 = New System.Windows.Forms.Label()
        Me.lblNoHpvEpisodes = New System.Windows.Forms.Label()
        Me.lblNoPatients = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.da1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.da1SelectComm = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.ds = New RIS.DataSet1()
        Me.TbStuHpvAdEventsLogTableAdapter = New RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsLogTableAdapter()
        Me.TbStuHpvAdEventsSymptomsTableAdapter = New RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsSymptomsTableAdapter()
        Me.TbStuHpvAdEventsInterventionsTableAdapter = New RIS.RISdataDataSetTableAdapters.tbStuHpvAdEventsInterventionsTableAdapter()
        Me.DdvYesNoTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvYesNoTableAdapter()
        Me.DdvResearcherTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter()
        Me.DdvPhysicianTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvPhysicianTableAdapter()
        Me.DdvAdEventSeverityTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvAdEventSeverityTableAdapter()
        Me.DdvAdEventRelProtocolTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvAdEventRelProtocolTableAdapter()
        Me.DdvAdEventRecoveryTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvAdEventRecoveryTableAdapter()
        Me.taPregnancy = New RIS.RISdataDataSetTableAdapters.tbPregnancyTableAdapter()
        Me.TbImmunizationsTableAdapter = New RIS.RISdataDataSetTableAdapters.tbImmunizationsTableAdapter()
        Me.TbPregnancyOutcomeTableAdapter = New RIS.RISdataDataSetTableAdapters.tbPregnancyOutcomeTableAdapter()
        Me.DdvPregnancyOutcomeTypeTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvPregnancyOutcomeTypeTableAdapter()
        Me.TbStuHpvEpisodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbStuHpvEpisodeTableAdapter = New RIS.DataSet1TableAdapters.tbStuHpvEpisodeTableAdapter()
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
        Dose1DateLabel = New System.Windows.Forms.Label()
        Dose1CompletedLabel = New System.Windows.Forms.Label()
        Dose1DoneInAHCLabel = New System.Windows.Forms.Label()
        Dose1PODLabel = New System.Windows.Forms.Label()
        Dose2DateLabel = New System.Windows.Forms.Label()
        Dose2CompletedLabel = New System.Windows.Forms.Label()
        Dose2DoneInAHCLabel = New System.Windows.Forms.Label()
        Dose2PODLabel = New System.Windows.Forms.Label()
        Dose3DateLabel = New System.Windows.Forms.Label()
        Dose3CompletedLabel = New System.Windows.Forms.Label()
        Dose3DoneInAHCLabel = New System.Windows.Forms.Label()
        Dose3PODLabel = New System.Windows.Forms.Label()
        Dose4DateLabel = New System.Windows.Forms.Label()
        Dose4CompletedLabel = New System.Windows.Forms.Label()
        Dose4DoneInAHCLabel = New System.Windows.Forms.Label()
        Dose4PODLabel = New System.Windows.Forms.Label()
        Dose5DateLabel = New System.Windows.Forms.Label()
        Dose5CompletedLabel = New System.Windows.Forms.Label()
        Dose5DoneInAHCLabel = New System.Windows.Forms.Label()
        Dose5PODLabel = New System.Windows.Forms.Label()
        NotesLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panAddEdit.SuspendLayout()
        Me.grpSearchBy.SuspendLayout()
        Me.panHPVvstDates.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.Tab1P1.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Tab1P2.SuspendLayout()
        Me.tabCts.SuspendLayout()
        Me.tabCtsP1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabCtsP2.SuspendLayout()
        Me.tabCtsP3.SuspendLayout()
        Me.grpCiContactName.SuspendLayout()
        Me.grpCiAddress.SuspendLayout()
        Me.Tab1P3.SuspendLayout()
        Me.tabHpv.SuspendLayout()
        Me.tabHpvP1.SuspendLayout()
        Me.grpProgressInfo.SuspendLayout()
        Me.tabHpvVst.SuspendLayout()
        Me.tabHpvVstP1.SuspendLayout()
        Me.tabHpvVstP2.SuspendLayout()
        Me.tabHpvVstP3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabHpvVstP4.SuspendLayout()
        Me.tabHpvVstAdveresEvent.SuspendLayout()
        Me.grpInterventions.SuspendLayout()
        CType(Me.grdInterventions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbStuHpvAdEventsInterventionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RiSdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSymptoms.SuspendLayout()
        CType(Me.grdSymptoms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbStuHpvAdEventsSymptomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAdverseEvent.SuspendLayout()
        CType(Me.TbStuHpvAdEventsLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvResearcherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvPhysicianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvYesNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvAdEventRelProtocolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvAdEventRecoveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvAdEventSeverityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHpvP2.SuspendLayout()
        Me.grpHpvSfEndPregnancy.SuspendLayout()
        CType(Me.DdvPregnancyOutcomeTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHpvSfHPVvaccinated.SuspendLayout()
        Me.grpHpvSfHasPeriod.SuspendLayout()
        Me.grpHpvSfThoughtPregnant.SuspendLayout()
        Me.grpHpvSfCurrentlyPregnant.SuspendLayout()
        Me.grpHpvSfWantHPVvaccine.SuspendLayout()
        Me.grpHpvSfSexuallyActive.SuspendLayout()
        Me.grpHpvSfSexualActType.SuspendLayout()
        Me.grpHpvSfPlanToLeaveNYC.SuspendLayout()
        Me.tabPregnancies.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.grdPregnancyOutcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPregnancyOutcomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPregnancy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.grdPregnancies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TbImmunizationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbStuHpvEpisodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoAdEventYNCdLabel
        '
        NoAdEventYNCdLabel.AutoSize = True
        NoAdEventYNCdLabel.Location = New System.Drawing.Point(6, 26)
        NoAdEventYNCdLabel.Name = "NoAdEventYNCdLabel"
        NoAdEventYNCdLabel.Size = New System.Drawing.Size(82, 13)
        NoAdEventYNCdLabel.TabIndex = 4
        NoAdEventYNCdLabel.Text = "Adverse Event:"
        '
        'DateOnsetLabel
        '
        DateOnsetLabel.AutoSize = True
        DateOnsetLabel.Location = New System.Drawing.Point(11, 54)
        DateOnsetLabel.Name = "DateOnsetLabel"
        DateOnsetLabel.Size = New System.Drawing.Size(77, 13)
        DateOnsetLabel.TabIndex = 6
        DateOnsetLabel.Text = "Date of onset:"
        '
        'SeriousEventYNCdLabel
        '
        SeriousEventYNCdLabel.AutoSize = True
        SeriousEventYNCdLabel.Location = New System.Drawing.Point(11, 78)
        SeriousEventYNCdLabel.Name = "SeriousEventYNCdLabel"
        SeriousEventYNCdLabel.Size = New System.Drawing.Size(77, 13)
        SeriousEventYNCdLabel.TabIndex = 8
        SeriousEventYNCdLabel.Text = "Serious Event:"
        '
        'SeverityIDLabel
        '
        SeverityIDLabel.AutoSize = True
        SeverityIDLabel.Location = New System.Drawing.Point(254, 78)
        SeverityIDLabel.Name = "SeverityIDLabel"
        SeverityIDLabel.Size = New System.Drawing.Size(51, 13)
        SeverityIDLabel.TabIndex = 10
        SeverityIDLabel.Text = "Severity:"
        '
        'RecoveryIDLabel
        '
        RecoveryIDLabel.AutoSize = True
        RecoveryIDLabel.Location = New System.Drawing.Point(29, 104)
        RecoveryIDLabel.Name = "RecoveryIDLabel"
        RecoveryIDLabel.Size = New System.Drawing.Size(57, 13)
        RecoveryIDLabel.TabIndex = 12
        RecoveryIDLabel.Text = "Recovery:"
        '
        'RelProtocolIDLabel
        '
        RelProtocolIDLabel.AutoSize = True
        RelProtocolIDLabel.Location = New System.Drawing.Point(237, 104)
        RelProtocolIDLabel.Name = "RelProtocolIDLabel"
        RelProtocolIDLabel.Size = New System.Drawing.Size(68, 13)
        RelProtocolIDLabel.TabIndex = 14
        RelProtocolIDLabel.Text = "Rel Protocol:"
        '
        'IncreaseRiskYNCdLabel
        '
        IncreaseRiskYNCdLabel.AutoSize = True
        IncreaseRiskYNCdLabel.Location = New System.Drawing.Point(11, 133)
        IncreaseRiskYNCdLabel.Name = "IncreaseRiskYNCdLabel"
        IncreaseRiskYNCdLabel.Size = New System.Drawing.Size(75, 13)
        IncreaseRiskYNCdLabel.TabIndex = 16
        IncreaseRiskYNCdLabel.Text = "Increase Risk:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(11, 157)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(39, 13)
        NotesLabel.TabIndex = 18
        NotesLabel.Text = "Notes:"
        '
        'PhysicianCdLabel
        '
        PhysicianCdLabel.AutoSize = True
        PhysicianCdLabel.Location = New System.Drawing.Point(250, 54)
        PhysicianCdLabel.Name = "PhysicianCdLabel"
        PhysicianCdLabel.Size = New System.Drawing.Size(55, 13)
        PhysicianCdLabel.TabIndex = 20
        PhysicianCdLabel.Text = "Physician:"
        '
        'ResearcherCdLabel
        '
        ResearcherCdLabel.AutoSize = True
        ResearcherCdLabel.Location = New System.Drawing.Point(239, 26)
        ResearcherCdLabel.Name = "ResearcherCdLabel"
        ResearcherCdLabel.Size = New System.Drawing.Size(66, 13)
        ResearcherCdLabel.TabIndex = 22
        ResearcherCdLabel.Text = "Researcher:"
        '
        'Dose1DateLabel
        '
        Dose1DateLabel.AutoSize = True
        Dose1DateLabel.Location = New System.Drawing.Point(3, 0)
        Dose1DateLabel.Name = "Dose1DateLabel"
        Dose1DateLabel.Size = New System.Drawing.Size(64, 13)
        Dose1DateLabel.TabIndex = 0
        Dose1DateLabel.Text = "Dose1Date:"
        '
        'Dose1CompletedLabel
        '
        Dose1CompletedLabel.AutoSize = True
        Dose1CompletedLabel.Location = New System.Drawing.Point(3, 15)
        Dose1CompletedLabel.Name = "Dose1CompletedLabel"
        Dose1CompletedLabel.Size = New System.Drawing.Size(92, 13)
        Dose1CompletedLabel.TabIndex = 2
        Dose1CompletedLabel.Text = "Dose1Completed:"
        '
        'Dose1DoneInAHCLabel
        '
        Dose1DoneInAHCLabel.AutoSize = True
        Dose1DoneInAHCLabel.Location = New System.Drawing.Point(3, 30)
        Dose1DoneInAHCLabel.Name = "Dose1DoneInAHCLabel"
        Dose1DoneInAHCLabel.Size = New System.Drawing.Size(103, 13)
        Dose1DoneInAHCLabel.TabIndex = 4
        Dose1DoneInAHCLabel.Text = "Dose1Done In AHC:"
        '
        'Dose1PODLabel
        '
        Dose1PODLabel.AutoSize = True
        Dose1PODLabel.Location = New System.Drawing.Point(3, 45)
        Dose1PODLabel.Name = "Dose1PODLabel"
        Dose1PODLabel.Size = New System.Drawing.Size(62, 13)
        Dose1PODLabel.TabIndex = 6
        Dose1PODLabel.Text = "Dose1POD:"
        '
        'Dose2DateLabel
        '
        Dose2DateLabel.AutoSize = True
        Dose2DateLabel.Location = New System.Drawing.Point(3, 60)
        Dose2DateLabel.Name = "Dose2DateLabel"
        Dose2DateLabel.Size = New System.Drawing.Size(64, 13)
        Dose2DateLabel.TabIndex = 8
        Dose2DateLabel.Text = "Dose2Date:"
        '
        'Dose2CompletedLabel
        '
        Dose2CompletedLabel.AutoSize = True
        Dose2CompletedLabel.Location = New System.Drawing.Point(3, 75)
        Dose2CompletedLabel.Name = "Dose2CompletedLabel"
        Dose2CompletedLabel.Size = New System.Drawing.Size(92, 13)
        Dose2CompletedLabel.TabIndex = 10
        Dose2CompletedLabel.Text = "Dose2Completed:"
        '
        'Dose2DoneInAHCLabel
        '
        Dose2DoneInAHCLabel.AutoSize = True
        Dose2DoneInAHCLabel.Location = New System.Drawing.Point(3, 90)
        Dose2DoneInAHCLabel.Name = "Dose2DoneInAHCLabel"
        Dose2DoneInAHCLabel.Size = New System.Drawing.Size(103, 13)
        Dose2DoneInAHCLabel.TabIndex = 12
        Dose2DoneInAHCLabel.Text = "Dose2Done In AHC:"
        '
        'Dose2PODLabel
        '
        Dose2PODLabel.AutoSize = True
        Dose2PODLabel.Location = New System.Drawing.Point(3, 105)
        Dose2PODLabel.Name = "Dose2PODLabel"
        Dose2PODLabel.Size = New System.Drawing.Size(62, 13)
        Dose2PODLabel.TabIndex = 14
        Dose2PODLabel.Text = "Dose2POD:"
        '
        'Dose3DateLabel
        '
        Dose3DateLabel.AutoSize = True
        Dose3DateLabel.Location = New System.Drawing.Point(3, 120)
        Dose3DateLabel.Name = "Dose3DateLabel"
        Dose3DateLabel.Size = New System.Drawing.Size(64, 13)
        Dose3DateLabel.TabIndex = 16
        Dose3DateLabel.Text = "Dose3Date:"
        '
        'Dose3CompletedLabel
        '
        Dose3CompletedLabel.AutoSize = True
        Dose3CompletedLabel.Location = New System.Drawing.Point(3, 135)
        Dose3CompletedLabel.Name = "Dose3CompletedLabel"
        Dose3CompletedLabel.Size = New System.Drawing.Size(92, 13)
        Dose3CompletedLabel.TabIndex = 18
        Dose3CompletedLabel.Text = "Dose3Completed:"
        '
        'Dose3DoneInAHCLabel
        '
        Dose3DoneInAHCLabel.AutoSize = True
        Dose3DoneInAHCLabel.Location = New System.Drawing.Point(3, 150)
        Dose3DoneInAHCLabel.Name = "Dose3DoneInAHCLabel"
        Dose3DoneInAHCLabel.Size = New System.Drawing.Size(103, 13)
        Dose3DoneInAHCLabel.TabIndex = 20
        Dose3DoneInAHCLabel.Text = "Dose3Done In AHC:"
        '
        'Dose3PODLabel
        '
        Dose3PODLabel.AutoSize = True
        Dose3PODLabel.Location = New System.Drawing.Point(3, 165)
        Dose3PODLabel.Name = "Dose3PODLabel"
        Dose3PODLabel.Size = New System.Drawing.Size(62, 13)
        Dose3PODLabel.TabIndex = 22
        Dose3PODLabel.Text = "Dose3POD:"
        '
        'Dose4DateLabel
        '
        Dose4DateLabel.AutoSize = True
        Dose4DateLabel.Location = New System.Drawing.Point(3, 180)
        Dose4DateLabel.Name = "Dose4DateLabel"
        Dose4DateLabel.Size = New System.Drawing.Size(64, 13)
        Dose4DateLabel.TabIndex = 24
        Dose4DateLabel.Text = "Dose4Date:"
        '
        'Dose4CompletedLabel
        '
        Dose4CompletedLabel.AutoSize = True
        Dose4CompletedLabel.Location = New System.Drawing.Point(3, 195)
        Dose4CompletedLabel.Name = "Dose4CompletedLabel"
        Dose4CompletedLabel.Size = New System.Drawing.Size(92, 13)
        Dose4CompletedLabel.TabIndex = 26
        Dose4CompletedLabel.Text = "Dose4Completed:"
        '
        'Dose4DoneInAHCLabel
        '
        Dose4DoneInAHCLabel.AutoSize = True
        Dose4DoneInAHCLabel.Location = New System.Drawing.Point(3, 210)
        Dose4DoneInAHCLabel.Name = "Dose4DoneInAHCLabel"
        Dose4DoneInAHCLabel.Size = New System.Drawing.Size(103, 13)
        Dose4DoneInAHCLabel.TabIndex = 28
        Dose4DoneInAHCLabel.Text = "Dose4Done In AHC:"
        '
        'Dose4PODLabel
        '
        Dose4PODLabel.AutoSize = True
        Dose4PODLabel.Location = New System.Drawing.Point(3, 225)
        Dose4PODLabel.Name = "Dose4PODLabel"
        Dose4PODLabel.Size = New System.Drawing.Size(62, 13)
        Dose4PODLabel.TabIndex = 30
        Dose4PODLabel.Text = "Dose4POD:"
        '
        'Dose5DateLabel
        '
        Dose5DateLabel.AutoSize = True
        Dose5DateLabel.Location = New System.Drawing.Point(3, 240)
        Dose5DateLabel.Name = "Dose5DateLabel"
        Dose5DateLabel.Size = New System.Drawing.Size(64, 13)
        Dose5DateLabel.TabIndex = 32
        Dose5DateLabel.Text = "Dose5Date:"
        '
        'Dose5CompletedLabel
        '
        Dose5CompletedLabel.AutoSize = True
        Dose5CompletedLabel.Location = New System.Drawing.Point(3, 255)
        Dose5CompletedLabel.Name = "Dose5CompletedLabel"
        Dose5CompletedLabel.Size = New System.Drawing.Size(92, 13)
        Dose5CompletedLabel.TabIndex = 34
        Dose5CompletedLabel.Text = "Dose5Completed:"
        '
        'Dose5DoneInAHCLabel
        '
        Dose5DoneInAHCLabel.AutoSize = True
        Dose5DoneInAHCLabel.Location = New System.Drawing.Point(3, 270)
        Dose5DoneInAHCLabel.Name = "Dose5DoneInAHCLabel"
        Dose5DoneInAHCLabel.Size = New System.Drawing.Size(103, 13)
        Dose5DoneInAHCLabel.TabIndex = 36
        Dose5DoneInAHCLabel.Text = "Dose5Done In AHC:"
        '
        'Dose5PODLabel
        '
        Dose5PODLabel.AutoSize = True
        Dose5PODLabel.Location = New System.Drawing.Point(3, 285)
        Dose5PODLabel.Name = "Dose5PODLabel"
        Dose5PODLabel.Size = New System.Drawing.Size(62, 13)
        Dose5PODLabel.TabIndex = 38
        Dose5PODLabel.Text = "Dose5POD:"
        '
        'NotesLabel1
        '
        NotesLabel1.AutoSize = True
        NotesLabel1.Location = New System.Drawing.Point(3, 300)
        NotesLabel1.Name = "NotesLabel1"
        NotesLabel1.Size = New System.Drawing.Size(39, 13)
        NotesLabel1.TabIndex = 40
        NotesLabel1.Text = "Notes:"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 0
        Me.ToolTip1.ReshowDelay = 100
        '
        'cboStudy
        '
        Me.cboStudy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudy.Location = New System.Drawing.Point(3, 3)
        Me.cboStudy.Name = "cboStudy"
        Me.cboStudy.Size = New System.Drawing.Size(136, 21)
        Me.cboStudy.TabIndex = 47
        Me.cboStudy.TabStop = False
        Me.ToolTip1.SetToolTip(Me.cboStudy, "Select a group of patients.")
        '
        'btnDelHpvEpi
        '
        Me.btnDelHpvEpi.Enabled = False
        Me.btnDelHpvEpi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelHpvEpi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelHpvEpi.ImageIndex = 1
        Me.btnDelHpvEpi.Location = New System.Drawing.Point(79, 3)
        Me.btnDelHpvEpi.Name = "btnDelHpvEpi"
        Me.btnDelHpvEpi.Size = New System.Drawing.Size(40, 20)
        Me.btnDelHpvEpi.TabIndex = 78
        Me.btnDelHpvEpi.Text = "Delete"
        Me.btnDelHpvEpi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnDelHpvEpi, "Click to delete the selected HPV episode.")
        '
        'btnAddHpvEpi
        '
        Me.btnAddHpvEpi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddHpvEpi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHpvEpi.ImageIndex = 1
        Me.btnAddHpvEpi.Location = New System.Drawing.Point(5, 3)
        Me.btnAddHpvEpi.Name = "btnAddHpvEpi"
        Me.btnAddHpvEpi.Size = New System.Drawing.Size(34, 20)
        Me.btnAddHpvEpi.TabIndex = 77
        Me.btnAddHpvEpi.Text = "Add"
        Me.btnAddHpvEpi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnAddHpvEpi, "Click to add a new HPV episode to the selected patient.")
        '
        'btnEditHpvEpi
        '
        Me.btnEditHpvEpi.Enabled = False
        Me.btnEditHpvEpi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditHpvEpi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditHpvEpi.ImageIndex = 1
        Me.btnEditHpvEpi.Location = New System.Drawing.Point(42, 3)
        Me.btnEditHpvEpi.Name = "btnEditHpvEpi"
        Me.btnEditHpvEpi.Size = New System.Drawing.Size(34, 20)
        Me.btnEditHpvEpi.TabIndex = 76
        Me.btnEditHpvEpi.Text = "Edit"
        Me.btnEditHpvEpi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnEditHpvEpi, "Click to edit the selected HPV episode.")
        '
        'btnDelPat
        '
        Me.btnDelPat.Enabled = False
        Me.btnDelPat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelPat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelPat.ImageIndex = 1
        Me.btnDelPat.Location = New System.Drawing.Point(76, 0)
        Me.btnDelPat.Name = "btnDelPat"
        Me.btnDelPat.Size = New System.Drawing.Size(40, 20)
        Me.btnDelPat.TabIndex = 44
        Me.btnDelPat.Text = "Delete"
        Me.btnDelPat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnDelPat, "Click to delete the selected patient.")
        '
        'btnAddPat
        '
        Me.btnAddPat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddPat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPat.ImageIndex = 1
        Me.btnAddPat.Location = New System.Drawing.Point(0, 0)
        Me.btnAddPat.Name = "btnAddPat"
        Me.btnAddPat.Size = New System.Drawing.Size(34, 20)
        Me.btnAddPat.TabIndex = 43
        Me.btnAddPat.Text = "Add"
        Me.btnAddPat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnAddPat, "Click to add a new patient.")
        '
        'btnEditPat
        '
        Me.btnEditPat.Enabled = False
        Me.btnEditPat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditPat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPat.ImageIndex = 1
        Me.btnEditPat.Location = New System.Drawing.Point(39, 0)
        Me.btnEditPat.Name = "btnEditPat"
        Me.btnEditPat.Size = New System.Drawing.Size(34, 20)
        Me.btnEditPat.TabIndex = 42
        Me.btnEditPat.Text = "Edit"
        Me.btnEditPat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnEditPat, "Click to edit the selected patient.")
        '
        'btnDelHpvVst
        '
        Me.btnDelHpvVst.Enabled = False
        Me.btnDelHpvVst.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelHpvVst.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelHpvVst.ImageIndex = 1
        Me.btnDelHpvVst.Location = New System.Drawing.Point(77, 70)
        Me.btnDelHpvVst.Name = "btnDelHpvVst"
        Me.btnDelHpvVst.Size = New System.Drawing.Size(40, 20)
        Me.btnDelHpvVst.TabIndex = 75
        Me.btnDelHpvVst.Text = "Delete"
        Me.btnDelHpvVst.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnDelHpvVst, "Click to delete the selected HPV visit.")
        '
        'btnAddHpvVst
        '
        Me.btnAddHpvVst.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddHpvVst.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHpvVst.ImageIndex = 1
        Me.btnAddHpvVst.Location = New System.Drawing.Point(3, 70)
        Me.btnAddHpvVst.Name = "btnAddHpvVst"
        Me.btnAddHpvVst.Size = New System.Drawing.Size(34, 20)
        Me.btnAddHpvVst.TabIndex = 74
        Me.btnAddHpvVst.Text = "Add"
        Me.btnAddHpvVst.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnAddHpvVst, "Click to add a HPV visit.")
        '
        'btnEditHpvVst
        '
        Me.btnEditHpvVst.Enabled = False
        Me.btnEditHpvVst.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditHpvVst.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditHpvVst.ImageIndex = 1
        Me.btnEditHpvVst.Location = New System.Drawing.Point(40, 70)
        Me.btnEditHpvVst.Name = "btnEditHpvVst"
        Me.btnEditHpvVst.Size = New System.Drawing.Size(34, 20)
        Me.btnEditHpvVst.TabIndex = 73
        Me.btnEditHpvVst.Text = "Edit"
        Me.btnEditHpvVst.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnEditHpvVst, "Click to edit the selected HPV visit.")
        '
        'btnDelScrnForm
        '
        Me.btnDelScrnForm.Enabled = False
        Me.btnDelScrnForm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelScrnForm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelScrnForm.ImageIndex = 1
        Me.btnDelScrnForm.Location = New System.Drawing.Point(48, 6)
        Me.btnDelScrnForm.Name = "btnDelScrnForm"
        Me.btnDelScrnForm.Size = New System.Drawing.Size(40, 20)
        Me.btnDelScrnForm.TabIndex = 111
        Me.btnDelScrnForm.Text = "Delete"
        Me.btnDelScrnForm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnDelScrnForm, "Click to delete the Screening Form data of the selected HPV episode.")
        '
        'btnEditScrnForm
        '
        Me.btnEditScrnForm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditScrnForm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditScrnForm.ImageIndex = 1
        Me.btnEditScrnForm.Location = New System.Drawing.Point(6, 6)
        Me.btnEditScrnForm.Name = "btnEditScrnForm"
        Me.btnEditScrnForm.Size = New System.Drawing.Size(36, 20)
        Me.btnEditScrnForm.TabIndex = 110
        Me.btnEditScrnForm.Text = "Edit"
        Me.btnEditScrnForm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnEditScrnForm, "Click to edit the Screening Form data of the selected HPV episode.")
        '
        'tbRefreshLvw0
        '
        Me.tbRefreshLvw0.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRefreshLvw0.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.tbRefreshLvw0.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbRefreshLvw0B1})
        Me.tbRefreshLvw0.ButtonSize = New System.Drawing.Size(16, 16)
        Me.tbRefreshLvw0.Divider = False
        Me.tbRefreshLvw0.Dock = System.Windows.Forms.DockStyle.None
        Me.tbRefreshLvw0.DropDownArrows = True
        Me.tbRefreshLvw0.ImageList = Me.ils16X16
        Me.tbRefreshLvw0.Location = New System.Drawing.Point(142, 3)
        Me.tbRefreshLvw0.Name = "tbRefreshLvw0"
        Me.tbRefreshLvw0.ShowToolTips = True
        Me.tbRefreshLvw0.Size = New System.Drawing.Size(34, 26)
        Me.tbRefreshLvw0.TabIndex = 50
        Me.tbRefreshLvw0.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        Me.ToolTip1.SetToolTip(Me.tbRefreshLvw0, "Click to refresh the Patient List below")
        '
        'tbRefreshLvw0B1
        '
        Me.tbRefreshLvw0B1.ImageIndex = 3
        Me.tbRefreshLvw0B1.Name = "tbRefreshLvw0B1"
        '
        'ils16X16
        '
        Me.ils16X16.ImageStream = CType(resources.GetObject("ils16X16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ils16X16.TransparentColor = System.Drawing.Color.Transparent
        Me.ils16X16.Images.SetKeyName(0, "")
        Me.ils16X16.Images.SetKeyName(1, "")
        Me.ils16X16.Images.SetKeyName(2, "")
        Me.ils16X16.Images.SetKeyName(3, "")
        Me.ils16X16.Images.SetKeyName(4, "")
        Me.ils16X16.Images.SetKeyName(5, "")
        Me.ils16X16.Images.SetKeyName(6, "")
        Me.ils16X16.Images.SetKeyName(7, "")
        Me.ils16X16.Images.SetKeyName(8, "")
        Me.ils16X16.Images.SetKeyName(9, "")
        Me.ils16X16.Images.SetKeyName(10, "")
        Me.ils16X16.Images.SetKeyName(11, "")
        Me.ils16X16.Images.SetKeyName(12, "")
        Me.ils16X16.Images.SetKeyName(13, "")
        Me.ils16X16.Images.SetKeyName(14, "")
        Me.ils16X16.Images.SetKeyName(15, "")
        Me.ils16X16.Images.SetKeyName(16, "")
        Me.ils16X16.Images.SetKeyName(17, "")
        '
        'dtsHPVvstDate2
        '
        Me.dtsHPVvstDate2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtsHPVvstDate2.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsHPVvstDate2.CustomFormat = "MM/dd/yyyy"
        Me.dtsHPVvstDate2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsHPVvstDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsHPVvstDate2.Location = New System.Drawing.Point(84, 0)
        Me.dtsHPVvstDate2.Name = "dtsHPVvstDate2"
        Me.dtsHPVvstDate2.ShowCheckBox = True
        Me.dtsHPVvstDate2.Size = New System.Drawing.Size(83, 18)
        Me.dtsHPVvstDate2.TabIndex = 122
        Me.dtsHPVvstDate2.Tag = "DateOfBirth"
        Me.ToolTip1.SetToolTip(Me.dtsHPVvstDate2, "Select an End Date")
        Me.dtsHPVvstDate2.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'dtsHPVvstDate1
        '
        Me.dtsHPVvstDate1.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsHPVvstDate1.CustomFormat = "MM/dd/yyyy"
        Me.dtsHPVvstDate1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsHPVvstDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsHPVvstDate1.Location = New System.Drawing.Point(0, 0)
        Me.dtsHPVvstDate1.Name = "dtsHPVvstDate1"
        Me.dtsHPVvstDate1.ShowCheckBox = True
        Me.dtsHPVvstDate1.Size = New System.Drawing.Size(83, 18)
        Me.dtsHPVvstDate1.TabIndex = 121
        Me.dtsHPVvstDate1.Tag = "DateOfBirth"
        Me.ToolTip1.SetToolTip(Me.dtsHPVvstDate1, "Select a Start Date")
        Me.dtsHPVvstDate1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'btnDelContactInfo
        '
        Me.btnDelContactInfo.Enabled = False
        Me.btnDelContactInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelContactInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelContactInfo.ImageIndex = 1
        Me.btnDelContactInfo.Location = New System.Drawing.Point(53, 27)
        Me.btnDelContactInfo.Name = "btnDelContactInfo"
        Me.btnDelContactInfo.Size = New System.Drawing.Size(40, 20)
        Me.btnDelContactInfo.TabIndex = 107
        Me.btnDelContactInfo.Text = "Delete"
        Me.btnDelContactInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnDelContactInfo, "Click to delete contact info.")
        '
        'btnEditContactInfo
        '
        Me.btnEditContactInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditContactInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditContactInfo.ImageIndex = 1
        Me.btnEditContactInfo.Location = New System.Drawing.Point(9, 27)
        Me.btnEditContactInfo.Name = "btnEditContactInfo"
        Me.btnEditContactInfo.Size = New System.Drawing.Size(36, 20)
        Me.btnEditContactInfo.TabIndex = 106
        Me.btnEditContactInfo.Text = "Edit"
        Me.btnEditContactInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnEditContactInfo, "Click to add/edit contact info.")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.panAddEdit)
        Me.Panel1.Controls.Add(Me.cboStudy)
        Me.Panel1.Controls.Add(Me.grpSearchBy)
        Me.Panel1.Controls.Add(Me.lvw0)
        Me.Panel1.Controls.Add(Me.panHPVvstDates)
        Me.Panel1.Controls.Add(Me.tbRefreshLvw0)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 676)
        Me.Panel1.TabIndex = 8
        '
        'panAddEdit
        '
        Me.panAddEdit.Controls.Add(Me.btnDelPat)
        Me.panAddEdit.Controls.Add(Me.btnAddPat)
        Me.panAddEdit.Controls.Add(Me.btnEditPat)
        Me.panAddEdit.Location = New System.Drawing.Point(3, 27)
        Me.panAddEdit.Name = "panAddEdit"
        Me.panAddEdit.Size = New System.Drawing.Size(131, 23)
        Me.panAddEdit.TabIndex = 123
        '
        'grpSearchBy
        '
        Me.grpSearchBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSearchBy.Controls.Add(Me.rbFindPt3)
        Me.grpSearchBy.Controls.Add(Me.rbFindPt2)
        Me.grpSearchBy.Controls.Add(Me.rbFindPt1)
        Me.grpSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpSearchBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchBy.Location = New System.Drawing.Point(3, 49)
        Me.grpSearchBy.Name = "grpSearchBy"
        Me.grpSearchBy.Size = New System.Drawing.Size(163, 36)
        Me.grpSearchBy.TabIndex = 46
        Me.grpSearchBy.TabStop = False
        Me.grpSearchBy.Text = "Search By"
        '
        'rbFindPt3
        '
        Me.rbFindPt3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbFindPt3.Enabled = False
        Me.rbFindPt3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbFindPt3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFindPt3.Location = New System.Drawing.Point(96, 13)
        Me.rbFindPt3.Name = "rbFindPt3"
        Me.rbFindPt3.Size = New System.Drawing.Size(55, 21)
        Me.rbFindPt3.TabIndex = 2
        Me.rbFindPt3.Text = "Subj ID"
        Me.rbFindPt3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbFindPt2
        '
        Me.rbFindPt2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbFindPt2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbFindPt2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFindPt2.Location = New System.Drawing.Point(47, 13)
        Me.rbFindPt2.Name = "rbFindPt2"
        Me.rbFindPt2.Size = New System.Drawing.Size(42, 21)
        Me.rbFindPt2.TabIndex = 1
        Me.rbFindPt2.Text = "MRN"
        '
        'rbFindPt1
        '
        Me.rbFindPt1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbFindPt1.Checked = True
        Me.rbFindPt1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbFindPt1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFindPt1.Location = New System.Drawing.Point(7, 13)
        Me.rbFindPt1.Name = "rbFindPt1"
        Me.rbFindPt1.Size = New System.Drawing.Size(32, 21)
        Me.rbFindPt1.TabIndex = 0
        Me.rbFindPt1.TabStop = True
        Me.rbFindPt1.Text = "LN"
        '
        'lvw0
        '
        Me.lvw0.AllowColumnReorder = True
        Me.lvw0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvw0.BackColor = System.Drawing.SystemColors.Info
        Me.lvw0.CausesValidation = False
        Me.lvw0.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvw0C1, Me.lvw0C2, Me.lvw0C3, Me.lvw0C4, Me.lvw0C5})
        Me.lvw0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw0.FullRowSelect = True
        Me.lvw0.GridLines = True
        Me.lvw0.HideSelection = False
        Me.lvw0.Location = New System.Drawing.Point(3, 88)
        Me.lvw0.MultiSelect = False
        Me.lvw0.Name = "lvw0"
        Me.lvw0.Size = New System.Drawing.Size(164, 293)
        Me.lvw0.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvw0.TabIndex = 7
        Me.lvw0.UseCompatibleStateImageBehavior = False
        Me.lvw0.View = System.Windows.Forms.View.Details
        '
        'lvw0C1
        '
        Me.lvw0C1.Text = "Last Name"
        Me.lvw0C1.Width = 90
        '
        'lvw0C2
        '
        Me.lvw0C2.Text = "First Name"
        Me.lvw0C2.Width = 80
        '
        'lvw0C3
        '
        Me.lvw0C3.Text = "MRN"
        Me.lvw0C3.Width = 70
        '
        'lvw0C4
        '
        Me.lvw0C4.Text = "Subj. ID"
        '
        'lvw0C5
        '
        Me.lvw0C5.Text = "Pat. ID"
        Me.lvw0C5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvw0C5.Width = 0
        '
        'panHPVvstDates
        '
        Me.panHPVvstDates.Controls.Add(Me.dtsHPVvstDate2)
        Me.panHPVvstDates.Controls.Add(Me.dtsHPVvstDate1)
        Me.panHPVvstDates.Location = New System.Drawing.Point(3, 27)
        Me.panHPVvstDates.Name = "panHPVvstDates"
        Me.panHPVvstDates.Size = New System.Drawing.Size(168, 23)
        Me.panHPVvstDates.TabIndex = 124
        '
        'splitVer1
        '
        Me.splitVer1.BackColor = System.Drawing.SystemColors.Control
        Me.splitVer1.Location = New System.Drawing.Point(173, 0)
        Me.splitVer1.MinExtra = 800
        Me.splitVer1.Name = "splitVer1"
        Me.splitVer1.Size = New System.Drawing.Size(3, 676)
        Me.splitVer1.TabIndex = 9
        Me.splitVer1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Tab1)
        Me.Panel2.Controls.Add(Me.lblNoPatients)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(176, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1373, 660)
        Me.Panel2.TabIndex = 10
        '
        'Tab1
        '
        Me.Tab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab1.Controls.Add(Me.Tab1P1)
        Me.Tab1.Controls.Add(Me.Tab1P2)
        Me.Tab1.Controls.Add(Me.Tab1P3)
        Me.Tab1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1.ImageList = Me.ils16X16
        Me.Tab1.ItemSize = New System.Drawing.Size(94, 18)
        Me.Tab1.Location = New System.Drawing.Point(0, 3)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(1374, 658)
        Me.Tab1.TabIndex = 0
        '
        'Tab1P1
        '
        Me.Tab1P1.BackColor = System.Drawing.SystemColors.Control
        Me.Tab1P1.Controls.Add(Me.GroupBox14)
        Me.Tab1P1.Controls.Add(Me.Label62)
        Me.Tab1P1.Controls.Add(Me.txtNotes)
        Me.Tab1P1.Controls.Add(Me.Label60)
        Me.Tab1P1.Controls.Add(Me.txtMRN)
        Me.Tab1P1.Controls.Add(Me.lvwStudy)
        Me.Tab1P1.Controls.Add(Me.GroupBox1)
        Me.Tab1P1.Controls.Add(Me.Label4)
        Me.Tab1P1.Controls.Add(Me.txtDateOfBirth)
        Me.Tab1P1.Controls.Add(Me.Label2)
        Me.Tab1P1.Controls.Add(Me.txtGender)
        Me.Tab1P1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tab1P1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1P1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1P1.Name = "Tab1P1"
        Me.Tab1P1.Size = New System.Drawing.Size(1366, 632)
        Me.Tab1P1.TabIndex = 0
        Me.Tab1P1.Text = "General Info"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.txtEthnicity)
        Me.GroupBox14.Controls.Add(Me.rbEthnicity3)
        Me.GroupBox14.Controls.Add(Me.rbEthnicity2)
        Me.GroupBox14.Controls.Add(Me.rbEthnicity1)
        Me.GroupBox14.Controls.Add(Me.Label61)
        Me.GroupBox14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.Location = New System.Drawing.Point(18, 116)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(243, 84)
        Me.GroupBox14.TabIndex = 93
        Me.GroupBox14.TabStop = False
        '
        'txtEthnicity
        '
        Me.txtEthnicity.BackColor = System.Drawing.SystemColors.Window
        Me.txtEthnicity.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEthnicity.Location = New System.Drawing.Point(172, 12)
        Me.txtEthnicity.Name = "txtEthnicity"
        Me.txtEthnicity.ReadOnly = True
        Me.txtEthnicity.Size = New System.Drawing.Size(56, 21)
        Me.txtEthnicity.TabIndex = 37
        Me.txtEthnicity.Text = "Ethnicity"
        Me.txtEthnicity.Visible = False
        '
        'rbEthnicity3
        '
        Me.rbEthnicity3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbEthnicity3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEthnicity3.Location = New System.Drawing.Point(11, 57)
        Me.rbEthnicity3.Name = "rbEthnicity3"
        Me.rbEthnicity3.Size = New System.Drawing.Size(219, 21)
        Me.rbEthnicity3.TabIndex = 34
        Me.rbEthnicity3.Text = "Caribbean or West Indian (Non Hispanic)"
        '
        'rbEthnicity2
        '
        Me.rbEthnicity2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbEthnicity2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEthnicity2.Location = New System.Drawing.Point(11, 36)
        Me.rbEthnicity2.Name = "rbEthnicity2"
        Me.rbEthnicity2.Size = New System.Drawing.Size(169, 21)
        Me.rbEthnicity2.TabIndex = 33
        Me.rbEthnicity2.Text = "Other (Non Hispanic or Latino)"
        '
        'rbEthnicity1
        '
        Me.rbEthnicity1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbEthnicity1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEthnicity1.Location = New System.Drawing.Point(11, 15)
        Me.rbEthnicity1.Name = "rbEthnicity1"
        Me.rbEthnicity1.Size = New System.Drawing.Size(107, 21)
        Me.rbEthnicity1.TabIndex = 32
        Me.rbEthnicity1.Text = "Hispanic or Latino"
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.SystemColors.Control
        Me.Label61.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label61.Location = New System.Drawing.Point(5, -1)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(49, 15)
        Me.Label61.TabIndex = 31
        Me.Label61.Text = "Ethnicity"
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label62.Location = New System.Drawing.Point(18, 205)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(33, 15)
        Me.Label62.TabIndex = 92
        Me.Label62.Text = "Notes"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(18, 221)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(527, 183)
        Me.txtNotes.TabIndex = 91
        Me.txtNotes.Text = "Notes"
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label60.Location = New System.Drawing.Point(18, 13)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(28, 15)
        Me.Label60.TabIndex = 69
        Me.Label60.Text = "MRN"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.SystemColors.Window
        Me.txtMRN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRN.Location = New System.Drawing.Point(49, 10)
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.ReadOnly = True
        Me.txtMRN.Size = New System.Drawing.Size(131, 21)
        Me.txtMRN.TabIndex = 68
        Me.txtMRN.Text = "mrn"
        '
        'lvwStudy
        '
        Me.lvwStudy.AllowColumnReorder = True
        Me.lvwStudy.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwStudyC1, Me.lvwStudyC2, Me.lvwStudyC3, Me.lvwStudyC4})
        Me.lvwStudy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwStudy.FullRowSelect = True
        Me.lvwStudy.GridLines = True
        Me.lvwStudy.HideSelection = False
        Me.lvwStudy.Location = New System.Drawing.Point(271, 121)
        Me.lvwStudy.MultiSelect = False
        Me.lvwStudy.Name = "lvwStudy"
        Me.lvwStudy.Size = New System.Drawing.Size(275, 92)
        Me.lvwStudy.TabIndex = 67
        Me.lvwStudy.UseCompatibleStateImageBehavior = False
        Me.lvwStudy.View = System.Windows.Forms.View.Details
        Me.lvwStudy.Visible = False
        '
        'lvwStudyC1
        '
        Me.lvwStudyC1.Text = "Studies Participated"
        Me.lvwStudyC1.Width = 139
        '
        'lvwStudyC2
        '
        Me.lvwStudyC2.Text = "Subject ID"
        Me.lvwStudyC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwStudyC2.Width = 77
        '
        'lvwStudyC3
        '
        Me.lvwStudyC3.Text = "Eligible"
        Me.lvwStudyC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwStudyC3.Width = 50
        '
        'lvwStudyC4
        '
        Me.lvwStudyC4.Text = "Study CD"
        Me.lvwStudyC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwStudyC4.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRace)
        Me.GroupBox1.Controls.Add(Me.chkRace6)
        Me.GroupBox1.Controls.Add(Me.chkRace5)
        Me.GroupBox1.Controls.Add(Me.chkRace4)
        Me.GroupBox1.Controls.Add(Me.chkRace3)
        Me.GroupBox1.Controls.Add(Me.chkRace2)
        Me.GroupBox1.Controls.Add(Me.chkRace1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 70)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'txtRace
        '
        Me.txtRace.BackColor = System.Drawing.SystemColors.Window
        Me.txtRace.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRace.Location = New System.Drawing.Point(189, 39)
        Me.txtRace.Name = "txtRace"
        Me.txtRace.ReadOnly = True
        Me.txtRace.Size = New System.Drawing.Size(75, 21)
        Me.txtRace.TabIndex = 36
        Me.txtRace.Text = "Race"
        Me.txtRace.Visible = False
        '
        'chkRace6
        '
        Me.chkRace6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkRace6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace6.Location = New System.Drawing.Point(277, 41)
        Me.chkRace6.Name = "chkRace6"
        Me.chkRace6.Size = New System.Drawing.Size(85, 19)
        Me.chkRace6.TabIndex = 2
        Me.chkRace6.Text = "Don't Know"
        '
        'chkRace5
        '
        Me.chkRace5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace5.Location = New System.Drawing.Point(129, 41)
        Me.chkRace5.Name = "chkRace5"
        Me.chkRace5.Size = New System.Drawing.Size(85, 19)
        Me.chkRace5.TabIndex = 1
        Me.chkRace5.Text = "Other"
        '
        'chkRace4
        '
        Me.chkRace4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace4.Location = New System.Drawing.Point(8, 41)
        Me.chkRace4.Name = "chkRace4"
        Me.chkRace4.Size = New System.Drawing.Size(107, 19)
        Me.chkRace4.TabIndex = 35
        Me.chkRace4.Text = "Native American"
        '
        'chkRace3
        '
        Me.chkRace3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkRace3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace3.Location = New System.Drawing.Point(277, 16)
        Me.chkRace3.Name = "chkRace3"
        Me.chkRace3.Size = New System.Drawing.Size(134, 19)
        Me.chkRace3.TabIndex = 34
        Me.chkRace3.Text = "Asian or Pacific Islander"
        '
        'chkRace2
        '
        Me.chkRace2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace2.Location = New System.Drawing.Point(129, 16)
        Me.chkRace2.Name = "chkRace2"
        Me.chkRace2.Size = New System.Drawing.Size(141, 19)
        Me.chkRace2.TabIndex = 0
        Me.chkRace2.Text = "Black or African American"
        '
        'chkRace1
        '
        Me.chkRace1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace1.Location = New System.Drawing.Point(8, 16)
        Me.chkRace1.Name = "chkRace1"
        Me.chkRace1.Size = New System.Drawing.Size(114, 19)
        Me.chkRace1.TabIndex = 32
        Me.chkRace1.Text = "White or Caucasian"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(5, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Race"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(255, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DOB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.BackColor = System.Drawing.SystemColors.Window
        Me.txtDateOfBirth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateOfBirth.Location = New System.Drawing.Point(286, 10)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.ReadOnly = True
        Me.txtDateOfBirth.Size = New System.Drawing.Size(75, 21)
        Me.txtDateOfBirth.TabIndex = 11
        Me.txtDateOfBirth.Text = "DateOfBirth"
        Me.txtDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(179, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gender"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.SystemColors.Window
        Me.txtGender.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(227, 10)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(26, 21)
        Me.txtGender.TabIndex = 1
        Me.txtGender.Text = "Gender"
        '
        'Tab1P2
        '
        Me.Tab1P2.BackColor = System.Drawing.SystemColors.Control
        Me.Tab1P2.Controls.Add(Me.lvwCiContactChoice)
        Me.Tab1P2.Controls.Add(Me.Label21)
        Me.Tab1P2.Controls.Add(Me.txtCiSpecialRequests)
        Me.Tab1P2.Controls.Add(Me.btnDelContactInfo)
        Me.Tab1P2.Controls.Add(Me.btnEditContactInfo)
        Me.Tab1P2.Controls.Add(Me.tabCts)
        Me.Tab1P2.Controls.Add(Me.grpCiContactName)
        Me.Tab1P2.Controls.Add(Me.rtbContactInfo)
        Me.Tab1P2.Controls.Add(Me.grpCiAddress)
        Me.Tab1P2.Controls.Add(Me.tabContactInfo)
        Me.Tab1P2.Location = New System.Drawing.Point(4, 22)
        Me.Tab1P2.Name = "Tab1P2"
        Me.Tab1P2.Size = New System.Drawing.Size(911, 632)
        Me.Tab1P2.TabIndex = 1
        Me.Tab1P2.Text = "Contact Info"
        '
        'lvwCiContactChoice
        '
        Me.lvwCiContactChoice.AllowColumnReorder = True
        Me.lvwCiContactChoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCiContactChoice.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lvwCiContactChoice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCiContactChoice.FullRowSelect = True
        Me.lvwCiContactChoice.GridLines = True
        Me.lvwCiContactChoice.HideSelection = False
        Me.lvwCiContactChoice.Location = New System.Drawing.Point(594, 192)
        Me.lvwCiContactChoice.MultiSelect = False
        Me.lvwCiContactChoice.Name = "lvwCiContactChoice"
        Me.lvwCiContactChoice.Size = New System.Drawing.Size(299, 205)
        Me.lvwCiContactChoice.TabIndex = 133
        Me.lvwCiContactChoice.UseCompatibleStateImageBehavior = False
        Me.lvwCiContactChoice.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Choice"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 50
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Contact method"
        Me.ColumnHeader12.Width = 150
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Cd"
        Me.ColumnHeader13.Width = 0
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label21.Location = New System.Drawing.Point(594, 404)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(180, 15)
        Me.Label21.TabIndex = 132
        Me.Label21.Text = "Special requests when contacting"
        '
        'txtCiSpecialRequests
        '
        Me.txtCiSpecialRequests.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCiSpecialRequests.BackColor = System.Drawing.SystemColors.Window
        Me.txtCiSpecialRequests.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiSpecialRequests.Location = New System.Drawing.Point(594, 422)
        Me.txtCiSpecialRequests.Multiline = True
        Me.txtCiSpecialRequests.Name = "txtCiSpecialRequests"
        Me.txtCiSpecialRequests.ReadOnly = True
        Me.txtCiSpecialRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCiSpecialRequests.Size = New System.Drawing.Size(299, 176)
        Me.txtCiSpecialRequests.TabIndex = 131
        Me.txtCiSpecialRequests.Text = "SpecialRequestsWhenContact"
        '
        'tabCts
        '
        Me.tabCts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabCts.Controls.Add(Me.tabCtsP1)
        Me.tabCts.Controls.Add(Me.tabCtsP2)
        Me.tabCts.Controls.Add(Me.tabCtsP3)
        Me.tabCts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCts.ImageList = Me.ils16X16
        Me.tabCts.ItemSize = New System.Drawing.Size(94, 18)
        Me.tabCts.Location = New System.Drawing.Point(1, 1)
        Me.tabCts.Name = "tabCts"
        Me.tabCts.SelectedIndex = 0
        Me.tabCts.Size = New System.Drawing.Size(4, 628)
        Me.tabCts.TabIndex = 8
        Me.tabCts.Visible = False
        '
        'tabCtsP1
        '
        Me.tabCtsP1.BackColor = System.Drawing.SystemColors.Control
        Me.tabCtsP1.Controls.Add(Me.btnDeleteCtsSlf)
        Me.tabCtsP1.Controls.Add(Me.btnEditCtsSlf)
        Me.tabCtsP1.Controls.Add(Me.rtbCtsSlf)
        Me.tabCtsP1.Controls.Add(Me.GroupBox3)
        Me.tabCtsP1.Controls.Add(Me.lvwCtMthdSlf)
        Me.tabCtsP1.Controls.Add(Me.Label47)
        Me.tabCtsP1.Controls.Add(Me.txtCtsSlfSpecialRequests)
        Me.tabCtsP1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabCtsP1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtsP1.Location = New System.Drawing.Point(4, 22)
        Me.tabCtsP1.Name = "tabCtsP1"
        Me.tabCtsP1.Size = New System.Drawing.Size(0, 602)
        Me.tabCtsP1.TabIndex = 0
        Me.tabCtsP1.Text = "Patient"
        '
        'btnDeleteCtsSlf
        '
        Me.btnDeleteCtsSlf.Enabled = False
        Me.btnDeleteCtsSlf.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeleteCtsSlf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCtsSlf.ImageIndex = 1
        Me.btnDeleteCtsSlf.Location = New System.Drawing.Point(48, 4)
        Me.btnDeleteCtsSlf.Name = "btnDeleteCtsSlf"
        Me.btnDeleteCtsSlf.Size = New System.Drawing.Size(40, 20)
        Me.btnDeleteCtsSlf.TabIndex = 57
        Me.btnDeleteCtsSlf.Text = "Delete"
        Me.btnDeleteCtsSlf.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEditCtsSlf
        '
        Me.btnEditCtsSlf.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditCtsSlf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCtsSlf.ImageIndex = 1
        Me.btnEditCtsSlf.Location = New System.Drawing.Point(4, 4)
        Me.btnEditCtsSlf.Name = "btnEditCtsSlf"
        Me.btnEditCtsSlf.Size = New System.Drawing.Size(36, 20)
        Me.btnEditCtsSlf.TabIndex = 55
        Me.btnEditCtsSlf.Text = "Edit"
        Me.btnEditCtsSlf.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rtbCtsSlf
        '
        Me.rtbCtsSlf.BackColor = System.Drawing.SystemColors.Control
        Me.rtbCtsSlf.Location = New System.Drawing.Point(10, 134)
        Me.rtbCtsSlf.Name = "rtbCtsSlf"
        Me.rtbCtsSlf.ReadOnly = True
        Me.rtbCtsSlf.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbCtsSlf.Size = New System.Drawing.Size(483, 461)
        Me.rtbCtsSlf.TabIndex = 128
        Me.rtbCtsSlf.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label100)
        Me.GroupBox3.Controls.Add(Me.Label50)
        Me.GroupBox3.Controls.Add(Me.Label52)
        Me.GroupBox3.Controls.Add(Me.chkCtsSlfCanMailReminder)
        Me.GroupBox3.Controls.Add(Me.txtCtsSlfZip)
        Me.GroupBox3.Controls.Add(Me.Label51)
        Me.GroupBox3.Controls.Add(Me.txtCtsSlfState)
        Me.GroupBox3.Controls.Add(Me.Label53)
        Me.GroupBox3.Controls.Add(Me.txtCtsSlfCity)
        Me.GroupBox3.Controls.Add(Me.txtCtsSlfAddress)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.chkCtsSlfCanTextMessage)
        Me.GroupBox3.Controls.Add(Me.txtCtsSlfAptNum)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 107)
        Me.GroupBox3.TabIndex = 105
        Me.GroupBox3.TabStop = False
        '
        'Label100
        '
        Me.Label100.BackColor = System.Drawing.Color.Transparent
        Me.Label100.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label100.Location = New System.Drawing.Point(5, 63)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(126, 15)
        Me.Label100.TabIndex = 92
        Me.Label100.Text = "Can mail reminder cards"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label50.Location = New System.Drawing.Point(353, 40)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(19, 15)
        Me.Label50.TabIndex = 21
        Me.Label50.Text = "Zip"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label52.Location = New System.Drawing.Point(5, 40)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(26, 15)
        Me.Label52.TabIndex = 12
        Me.Label52.Text = "City"
        '
        'chkCtsSlfCanMailReminder
        '
        Me.chkCtsSlfCanMailReminder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCtsSlfCanMailReminder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkCtsSlfCanMailReminder.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkCtsSlfCanMailReminder.Location = New System.Drawing.Point(9, 60)
        Me.chkCtsSlfCanMailReminder.Name = "chkCtsSlfCanMailReminder"
        Me.chkCtsSlfCanMailReminder.Size = New System.Drawing.Size(144, 21)
        Me.chkCtsSlfCanMailReminder.TabIndex = 53
        Me.chkCtsSlfCanMailReminder.Text = "Can mail reminder cards"
        '
        'txtCtsSlfZip
        '
        Me.txtCtsSlfZip.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfZip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfZip.Location = New System.Drawing.Point(377, 37)
        Me.txtCtsSlfZip.Name = "txtCtsSlfZip"
        Me.txtCtsSlfZip.ReadOnly = True
        Me.txtCtsSlfZip.Size = New System.Drawing.Size(98, 21)
        Me.txtCtsSlfZip.TabIndex = 20
        Me.txtCtsSlfZip.Text = "Zip"
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label51.Location = New System.Drawing.Point(268, 40)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(31, 15)
        Me.Label51.TabIndex = 19
        Me.Label51.Text = "State"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtsSlfState
        '
        Me.txtCtsSlfState.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfState.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfState.Location = New System.Drawing.Point(304, 37)
        Me.txtCtsSlfState.Name = "txtCtsSlfState"
        Me.txtCtsSlfState.ReadOnly = True
        Me.txtCtsSlfState.Size = New System.Drawing.Size(40, 21)
        Me.txtCtsSlfState.TabIndex = 18
        Me.txtCtsSlfState.Text = "State"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label53.Location = New System.Drawing.Point(5, 14)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(44, 15)
        Me.Label53.TabIndex = 8
        Me.Label53.Text = "Address"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtsSlfCity
        '
        Me.txtCtsSlfCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfCity.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfCity.Location = New System.Drawing.Point(54, 37)
        Me.txtCtsSlfCity.Name = "txtCtsSlfCity"
        Me.txtCtsSlfCity.ReadOnly = True
        Me.txtCtsSlfCity.Size = New System.Drawing.Size(212, 21)
        Me.txtCtsSlfCity.TabIndex = 11
        Me.txtCtsSlfCity.Text = "City"
        '
        'txtCtsSlfAddress
        '
        Me.txtCtsSlfAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfAddress.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfAddress.Location = New System.Drawing.Point(54, 11)
        Me.txtCtsSlfAddress.Name = "txtCtsSlfAddress"
        Me.txtCtsSlfAddress.ReadOnly = True
        Me.txtCtsSlfAddress.Size = New System.Drawing.Size(340, 21)
        Me.txtCtsSlfAddress.TabIndex = 6
        Me.txtCtsSlfAddress.Text = "Address"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label29.Location = New System.Drawing.Point(2, 84)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(97, 15)
        Me.Label29.TabIndex = 97
        Me.Label29.Text = "Can text message    "
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkCtsSlfCanTextMessage
        '
        Me.chkCtsSlfCanTextMessage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCtsSlfCanTextMessage.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkCtsSlfCanTextMessage.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkCtsSlfCanTextMessage.Location = New System.Drawing.Point(5, 81)
        Me.chkCtsSlfCanTextMessage.Name = "chkCtsSlfCanTextMessage"
        Me.chkCtsSlfCanTextMessage.Size = New System.Drawing.Size(148, 21)
        Me.chkCtsSlfCanTextMessage.TabIndex = 96
        Me.chkCtsSlfCanTextMessage.Text = "Can text message"
        '
        'txtCtsSlfAptNum
        '
        Me.txtCtsSlfAptNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfAptNum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfAptNum.Location = New System.Drawing.Point(435, 11)
        Me.txtCtsSlfAptNum.Name = "txtCtsSlfAptNum"
        Me.txtCtsSlfAptNum.ReadOnly = True
        Me.txtCtsSlfAptNum.Size = New System.Drawing.Size(40, 21)
        Me.txtCtsSlfAptNum.TabIndex = 95
        Me.txtCtsSlfAptNum.Text = "AptNum"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label42.Location = New System.Drawing.Point(397, 14)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(33, 15)
        Me.Label42.TabIndex = 94
        Me.Label42.Text = "Apt #"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lvwCtMthdSlf
        '
        Me.lvwCtMthdSlf.AllowColumnReorder = True
        Me.lvwCtMthdSlf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCtMthdSlf.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwCtMthdSlfC1, Me.lvwCtMthdSlfC2, Me.lvwCtMthdSlfC3})
        Me.lvwCtMthdSlf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCtMthdSlf.FullRowSelect = True
        Me.lvwCtMthdSlf.GridLines = True
        Me.lvwCtMthdSlf.HideSelection = False
        Me.lvwCtMthdSlf.Location = New System.Drawing.Point(500, 30)
        Me.lvwCtMthdSlf.MultiSelect = False
        Me.lvwCtMthdSlf.Name = "lvwCtMthdSlf"
        Me.lvwCtMthdSlf.Size = New System.Drawing.Size(0, 206)
        Me.lvwCtMthdSlf.TabIndex = 104
        Me.lvwCtMthdSlf.UseCompatibleStateImageBehavior = False
        Me.lvwCtMthdSlf.View = System.Windows.Forms.View.Details
        '
        'lvwCtMthdSlfC1
        '
        Me.lvwCtMthdSlfC1.Text = "Choice"
        Me.lvwCtMthdSlfC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwCtMthdSlfC1.Width = 50
        '
        'lvwCtMthdSlfC2
        '
        Me.lvwCtMthdSlfC2.Text = "Contact method"
        Me.lvwCtMthdSlfC2.Width = 150
        '
        'lvwCtMthdSlfC3
        '
        Me.lvwCtMthdSlfC3.Text = "Cd"
        Me.lvwCtMthdSlfC3.Width = 0
        '
        'Label47
        '
        Me.Label47.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label47.Location = New System.Drawing.Point(500, 240)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(0, 15)
        Me.Label47.TabIndex = 103
        Me.Label47.Text = "Special requests when contacting"
        '
        'txtCtsSlfSpecialRequests
        '
        Me.txtCtsSlfSpecialRequests.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfSpecialRequests.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfSpecialRequests.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfSpecialRequests.Location = New System.Drawing.Point(500, 260)
        Me.txtCtsSlfSpecialRequests.Multiline = True
        Me.txtCtsSlfSpecialRequests.Name = "txtCtsSlfSpecialRequests"
        Me.txtCtsSlfSpecialRequests.ReadOnly = True
        Me.txtCtsSlfSpecialRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCtsSlfSpecialRequests.Size = New System.Drawing.Size(0, 193)
        Me.txtCtsSlfSpecialRequests.TabIndex = 102
        Me.txtCtsSlfSpecialRequests.Text = "SpecialRequestsWhenContact"
        '
        'tabCtsP2
        '
        Me.tabCtsP2.BackColor = System.Drawing.SystemColors.Control
        Me.tabCtsP2.Controls.Add(Me.rtbCtsFrd1)
        Me.tabCtsP2.Controls.Add(Me.lvwCtMthdFrd1)
        Me.tabCtsP2.Controls.Add(Me.Label25)
        Me.tabCtsP2.Controls.Add(Me.txtCtsFrd1SpecialRequests)
        Me.tabCtsP2.Controls.Add(Me.btnDeleteCtsFrd1)
        Me.tabCtsP2.Controls.Add(Me.btnEditCtsFrd1)
        Me.tabCtsP2.Controls.Add(Me.Label76)
        Me.tabCtsP2.Controls.Add(Me.Label77)
        Me.tabCtsP2.Controls.Add(Me.txtCtsFrd1FirstName)
        Me.tabCtsP2.Controls.Add(Me.txtCtsFrd1LastName)
        Me.tabCtsP2.Location = New System.Drawing.Point(4, 22)
        Me.tabCtsP2.Name = "tabCtsP2"
        Me.tabCtsP2.Size = New System.Drawing.Size(0, 602)
        Me.tabCtsP2.TabIndex = 1
        Me.tabCtsP2.Text = "Friend #1"
        Me.tabCtsP2.Visible = False
        '
        'rtbCtsFrd1
        '
        Me.rtbCtsFrd1.BackColor = System.Drawing.SystemColors.Control
        Me.rtbCtsFrd1.Location = New System.Drawing.Point(10, 71)
        Me.rtbCtsFrd1.Name = "rtbCtsFrd1"
        Me.rtbCtsFrd1.ReadOnly = True
        Me.rtbCtsFrd1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbCtsFrd1.Size = New System.Drawing.Size(483, 526)
        Me.rtbCtsFrd1.TabIndex = 129
        Me.rtbCtsFrd1.Text = ""
        '
        'lvwCtMthdFrd1
        '
        Me.lvwCtMthdFrd1.AllowColumnReorder = True
        Me.lvwCtMthdFrd1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCtMthdFrd1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwCtMthdFrd1C1, Me.lvwCtMthdFrd1C2, Me.lvwCtMthdFrd1C3})
        Me.lvwCtMthdFrd1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCtMthdFrd1.FullRowSelect = True
        Me.lvwCtMthdFrd1.GridLines = True
        Me.lvwCtMthdFrd1.HideSelection = False
        Me.lvwCtMthdFrd1.Location = New System.Drawing.Point(500, 30)
        Me.lvwCtMthdFrd1.MultiSelect = False
        Me.lvwCtMthdFrd1.Name = "lvwCtMthdFrd1"
        Me.lvwCtMthdFrd1.Size = New System.Drawing.Size(4, 191)
        Me.lvwCtMthdFrd1.TabIndex = 122
        Me.lvwCtMthdFrd1.UseCompatibleStateImageBehavior = False
        Me.lvwCtMthdFrd1.View = System.Windows.Forms.View.Details
        '
        'lvwCtMthdFrd1C1
        '
        Me.lvwCtMthdFrd1C1.Text = "Choice"
        Me.lvwCtMthdFrd1C1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwCtMthdFrd1C1.Width = 50
        '
        'lvwCtMthdFrd1C2
        '
        Me.lvwCtMthdFrd1C2.Text = "Contact method"
        Me.lvwCtMthdFrd1C2.Width = 150
        '
        'lvwCtMthdFrd1C3
        '
        Me.lvwCtMthdFrd1C3.Text = "Cd"
        Me.lvwCtMthdFrd1C3.Width = 0
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label25.Location = New System.Drawing.Point(500, 228)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(179, 15)
        Me.Label25.TabIndex = 121
        Me.Label25.Text = "Special requests when contacting"
        '
        'txtCtsFrd1SpecialRequests
        '
        Me.txtCtsFrd1SpecialRequests.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsFrd1SpecialRequests.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsFrd1SpecialRequests.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsFrd1SpecialRequests.Location = New System.Drawing.Point(500, 246)
        Me.txtCtsFrd1SpecialRequests.Multiline = True
        Me.txtCtsFrd1SpecialRequests.Name = "txtCtsFrd1SpecialRequests"
        Me.txtCtsFrd1SpecialRequests.ReadOnly = True
        Me.txtCtsFrd1SpecialRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCtsFrd1SpecialRequests.Size = New System.Drawing.Size(4, 193)
        Me.txtCtsFrd1SpecialRequests.TabIndex = 120
        Me.txtCtsFrd1SpecialRequests.Text = "SpecialRequestsWhenContact"
        '
        'btnDeleteCtsFrd1
        '
        Me.btnDeleteCtsFrd1.Enabled = False
        Me.btnDeleteCtsFrd1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeleteCtsFrd1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCtsFrd1.ImageIndex = 1
        Me.btnDeleteCtsFrd1.Location = New System.Drawing.Point(48, 4)
        Me.btnDeleteCtsFrd1.Name = "btnDeleteCtsFrd1"
        Me.btnDeleteCtsFrd1.Size = New System.Drawing.Size(40, 20)
        Me.btnDeleteCtsFrd1.TabIndex = 119
        Me.btnDeleteCtsFrd1.Text = "Delete"
        Me.btnDeleteCtsFrd1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEditCtsFrd1
        '
        Me.btnEditCtsFrd1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditCtsFrd1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCtsFrd1.ImageIndex = 1
        Me.btnEditCtsFrd1.Location = New System.Drawing.Point(4, 4)
        Me.btnEditCtsFrd1.Name = "btnEditCtsFrd1"
        Me.btnEditCtsFrd1.Size = New System.Drawing.Size(36, 20)
        Me.btnEditCtsFrd1.TabIndex = 118
        Me.btnEditCtsFrd1.Text = "Edit"
        Me.btnEditCtsFrd1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label76
        '
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label76.Location = New System.Drawing.Point(246, 36)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(60, 15)
        Me.Label76.TabIndex = 74
        Me.Label76.Text = "First name"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label77.Location = New System.Drawing.Point(8, 36)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(57, 15)
        Me.Label77.TabIndex = 73
        Me.Label77.Text = "Last name"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtsFrd1FirstName
        '
        Me.txtCtsFrd1FirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsFrd1FirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsFrd1FirstName.Location = New System.Drawing.Point(315, 33)
        Me.txtCtsFrd1FirstName.Name = "txtCtsFrd1FirstName"
        Me.txtCtsFrd1FirstName.ReadOnly = True
        Me.txtCtsFrd1FirstName.Size = New System.Drawing.Size(165, 21)
        Me.txtCtsFrd1FirstName.TabIndex = 72
        Me.txtCtsFrd1FirstName.Text = "FirstName"
        '
        'txtCtsFrd1LastName
        '
        Me.txtCtsFrd1LastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsFrd1LastName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsFrd1LastName.Location = New System.Drawing.Point(74, 33)
        Me.txtCtsFrd1LastName.Name = "txtCtsFrd1LastName"
        Me.txtCtsFrd1LastName.ReadOnly = True
        Me.txtCtsFrd1LastName.Size = New System.Drawing.Size(165, 21)
        Me.txtCtsFrd1LastName.TabIndex = 71
        Me.txtCtsFrd1LastName.Text = "LastName"
        '
        'tabCtsP3
        '
        Me.tabCtsP3.BackColor = System.Drawing.SystemColors.Control
        Me.tabCtsP3.Controls.Add(Me.rtbCtsFrd2)
        Me.tabCtsP3.Controls.Add(Me.Label10)
        Me.tabCtsP3.Controls.Add(Me.Label15)
        Me.tabCtsP3.Controls.Add(Me.txtCtsFrd2FirstName)
        Me.tabCtsP3.Controls.Add(Me.txtCtsFrd2LastName)
        Me.tabCtsP3.Controls.Add(Me.lvwCtMthdFrd2)
        Me.tabCtsP3.Controls.Add(Me.Label89)
        Me.tabCtsP3.Controls.Add(Me.txtCtsFrd2SpecialRequests)
        Me.tabCtsP3.Controls.Add(Me.btnDeleteCtsFrd2)
        Me.tabCtsP3.Controls.Add(Me.btnEditCtsFrd2)
        Me.tabCtsP3.Location = New System.Drawing.Point(4, 22)
        Me.tabCtsP3.Name = "tabCtsP3"
        Me.tabCtsP3.Size = New System.Drawing.Size(0, 602)
        Me.tabCtsP3.TabIndex = 3
        Me.tabCtsP3.Text = "Friend #2"
        Me.tabCtsP3.Visible = False
        '
        'rtbCtsFrd2
        '
        Me.rtbCtsFrd2.BackColor = System.Drawing.SystemColors.Control
        Me.rtbCtsFrd2.Location = New System.Drawing.Point(10, 71)
        Me.rtbCtsFrd2.Name = "rtbCtsFrd2"
        Me.rtbCtsFrd2.ReadOnly = True
        Me.rtbCtsFrd2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbCtsFrd2.Size = New System.Drawing.Size(483, 526)
        Me.rtbCtsFrd2.TabIndex = 134
        Me.rtbCtsFrd2.Text = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(246, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 15)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "First name"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label15.Location = New System.Drawing.Point(8, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 15)
        Me.Label15.TabIndex = 132
        Me.Label15.Text = "Last name"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtsFrd2FirstName
        '
        Me.txtCtsFrd2FirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsFrd2FirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsFrd2FirstName.Location = New System.Drawing.Point(315, 33)
        Me.txtCtsFrd2FirstName.Name = "txtCtsFrd2FirstName"
        Me.txtCtsFrd2FirstName.ReadOnly = True
        Me.txtCtsFrd2FirstName.Size = New System.Drawing.Size(165, 21)
        Me.txtCtsFrd2FirstName.TabIndex = 131
        Me.txtCtsFrd2FirstName.Text = "FirstName"
        '
        'txtCtsFrd2LastName
        '
        Me.txtCtsFrd2LastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsFrd2LastName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsFrd2LastName.Location = New System.Drawing.Point(74, 33)
        Me.txtCtsFrd2LastName.Name = "txtCtsFrd2LastName"
        Me.txtCtsFrd2LastName.ReadOnly = True
        Me.txtCtsFrd2LastName.Size = New System.Drawing.Size(165, 21)
        Me.txtCtsFrd2LastName.TabIndex = 130
        Me.txtCtsFrd2LastName.Text = "LastName"
        '
        'lvwCtMthdFrd2
        '
        Me.lvwCtMthdFrd2.AllowColumnReorder = True
        Me.lvwCtMthdFrd2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCtMthdFrd2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvwCtMthdFrd2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCtMthdFrd2.FullRowSelect = True
        Me.lvwCtMthdFrd2.GridLines = True
        Me.lvwCtMthdFrd2.HideSelection = False
        Me.lvwCtMthdFrd2.Location = New System.Drawing.Point(500, 30)
        Me.lvwCtMthdFrd2.MultiSelect = False
        Me.lvwCtMthdFrd2.Name = "lvwCtMthdFrd2"
        Me.lvwCtMthdFrd2.Size = New System.Drawing.Size(4, 191)
        Me.lvwCtMthdFrd2.TabIndex = 129
        Me.lvwCtMthdFrd2.UseCompatibleStateImageBehavior = False
        Me.lvwCtMthdFrd2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Choice"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 50
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Contact method"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Cd"
        Me.ColumnHeader8.Width = 0
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.Transparent
        Me.Label89.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label89.Location = New System.Drawing.Point(500, 228)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(179, 15)
        Me.Label89.TabIndex = 128
        Me.Label89.Text = "Special requests when contacting"
        '
        'txtCtsFrd2SpecialRequests
        '
        Me.txtCtsFrd2SpecialRequests.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsFrd2SpecialRequests.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsFrd2SpecialRequests.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsFrd2SpecialRequests.Location = New System.Drawing.Point(500, 246)
        Me.txtCtsFrd2SpecialRequests.Multiline = True
        Me.txtCtsFrd2SpecialRequests.Name = "txtCtsFrd2SpecialRequests"
        Me.txtCtsFrd2SpecialRequests.ReadOnly = True
        Me.txtCtsFrd2SpecialRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCtsFrd2SpecialRequests.Size = New System.Drawing.Size(4, 193)
        Me.txtCtsFrd2SpecialRequests.TabIndex = 127
        Me.txtCtsFrd2SpecialRequests.Text = "SpecialRequestsWhenContact"
        '
        'btnDeleteCtsFrd2
        '
        Me.btnDeleteCtsFrd2.Enabled = False
        Me.btnDeleteCtsFrd2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDeleteCtsFrd2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCtsFrd2.ImageIndex = 1
        Me.btnDeleteCtsFrd2.Location = New System.Drawing.Point(48, 4)
        Me.btnDeleteCtsFrd2.Name = "btnDeleteCtsFrd2"
        Me.btnDeleteCtsFrd2.Size = New System.Drawing.Size(40, 20)
        Me.btnDeleteCtsFrd2.TabIndex = 120
        Me.btnDeleteCtsFrd2.Text = "Delete"
        Me.btnDeleteCtsFrd2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEditCtsFrd2
        '
        Me.btnEditCtsFrd2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditCtsFrd2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCtsFrd2.ImageIndex = 1
        Me.btnEditCtsFrd2.Location = New System.Drawing.Point(4, 4)
        Me.btnEditCtsFrd2.Name = "btnEditCtsFrd2"
        Me.btnEditCtsFrd2.Size = New System.Drawing.Size(36, 20)
        Me.btnEditCtsFrd2.TabIndex = 118
        Me.btnEditCtsFrd2.Text = "Edit"
        Me.btnEditCtsFrd2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpCiContactName
        '
        Me.grpCiContactName.Controls.Add(Me.txtWhoIs)
        Me.grpCiContactName.Controls.Add(Me.Label23)
        Me.grpCiContactName.Controls.Add(Me.Label19)
        Me.grpCiContactName.Controls.Add(Me.Label20)
        Me.grpCiContactName.Controls.Add(Me.txtCiFirstName)
        Me.grpCiContactName.Controls.Add(Me.txtCiLastName)
        Me.grpCiContactName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpCiContactName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCiContactName.Location = New System.Drawing.Point(9, 44)
        Me.grpCiContactName.Name = "grpCiContactName"
        Me.grpCiContactName.Size = New System.Drawing.Size(881, 37)
        Me.grpCiContactName.TabIndex = 130
        Me.grpCiContactName.TabStop = False
        '
        'txtWhoIs
        '
        Me.txtWhoIs.Location = New System.Drawing.Point(600, 11)
        Me.txtWhoIs.Name = "txtWhoIs"
        Me.txtWhoIs.Size = New System.Drawing.Size(165, 21)
        Me.txtWhoIs.TabIndex = 80
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label23.Location = New System.Drawing.Point(495, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 13)
        Me.Label23.TabIndex = 79
        Me.Label23.Text = "Who is this Person?"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label19.Location = New System.Drawing.Point(244, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 15)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "First name"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label20.Location = New System.Drawing.Point(4, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 15)
        Me.Label20.TabIndex = 77
        Me.Label20.Text = "Last name"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCiFirstName
        '
        Me.txtCiFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCiFirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiFirstName.Location = New System.Drawing.Point(308, 11)
        Me.txtCiFirstName.Name = "txtCiFirstName"
        Me.txtCiFirstName.ReadOnly = True
        Me.txtCiFirstName.Size = New System.Drawing.Size(165, 21)
        Me.txtCiFirstName.TabIndex = 76
        Me.txtCiFirstName.Text = "FirstName"
        '
        'txtCiLastName
        '
        Me.txtCiLastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCiLastName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiLastName.Location = New System.Drawing.Point(68, 11)
        Me.txtCiLastName.Name = "txtCiLastName"
        Me.txtCiLastName.ReadOnly = True
        Me.txtCiLastName.Size = New System.Drawing.Size(165, 21)
        Me.txtCiLastName.TabIndex = 75
        Me.txtCiLastName.Text = "LastName"
        '
        'rtbContactInfo
        '
        Me.rtbContactInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtbContactInfo.Location = New System.Drawing.Point(15, 192)
        Me.rtbContactInfo.Name = "rtbContactInfo"
        Me.rtbContactInfo.ReadOnly = True
        Me.rtbContactInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbContactInfo.Size = New System.Drawing.Size(576, 430)
        Me.rtbContactInfo.TabIndex = 129
        Me.rtbContactInfo.Text = ""
        '
        'grpCiAddress
        '
        Me.grpCiAddress.Controls.Add(Me.txtHasAddress)
        Me.grpCiAddress.Controls.Add(Me.txtHasContact)
        Me.grpCiAddress.Controls.Add(Me.Label11)
        Me.grpCiAddress.Controls.Add(Me.Label12)
        Me.grpCiAddress.Controls.Add(Me.Label13)
        Me.grpCiAddress.Controls.Add(Me.chkCiCanMailReminder)
        Me.grpCiAddress.Controls.Add(Me.txtCiZip)
        Me.grpCiAddress.Controls.Add(Me.Label14)
        Me.grpCiAddress.Controls.Add(Me.txtCiState)
        Me.grpCiAddress.Controls.Add(Me.Label16)
        Me.grpCiAddress.Controls.Add(Me.txtCiCity)
        Me.grpCiAddress.Controls.Add(Me.txtCiAddress1)
        Me.grpCiAddress.Controls.Add(Me.Label17)
        Me.grpCiAddress.Controls.Add(Me.chkCiCanTextMessage)
        Me.grpCiAddress.Controls.Add(Me.txtCiAddress2)
        Me.grpCiAddress.Controls.Add(Me.Label18)
        Me.grpCiAddress.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpCiAddress.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCiAddress.Location = New System.Drawing.Point(9, 80)
        Me.grpCiAddress.Name = "grpCiAddress"
        Me.grpCiAddress.Size = New System.Drawing.Size(489, 104)
        Me.grpCiAddress.TabIndex = 108
        Me.grpCiAddress.TabStop = False
        '
        'txtHasAddress
        '
        Me.txtHasAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtHasAddress.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasAddress.Location = New System.Drawing.Point(440, 64)
        Me.txtHasAddress.Name = "txtHasAddress"
        Me.txtHasAddress.ReadOnly = True
        Me.txtHasAddress.Size = New System.Drawing.Size(29, 21)
        Me.txtHasAddress.TabIndex = 101
        Me.txtHasAddress.Visible = False
        '
        'txtHasContact
        '
        Me.txtHasContact.BackColor = System.Drawing.SystemColors.Window
        Me.txtHasContact.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasContact.Location = New System.Drawing.Point(168, 72)
        Me.txtHasContact.Name = "txtHasContact"
        Me.txtHasContact.ReadOnly = True
        Me.txtHasContact.Size = New System.Drawing.Size(29, 21)
        Me.txtHasContact.TabIndex = 100
        Me.txtHasContact.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(5, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 15)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Can mail reminder cards"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(353, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Zip"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(5, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "City"
        '
        'chkCiCanMailReminder
        '
        Me.chkCiCanMailReminder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCiCanMailReminder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkCiCanMailReminder.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkCiCanMailReminder.Location = New System.Drawing.Point(9, 60)
        Me.chkCiCanMailReminder.Name = "chkCiCanMailReminder"
        Me.chkCiCanMailReminder.Size = New System.Drawing.Size(144, 21)
        Me.chkCiCanMailReminder.TabIndex = 53
        Me.chkCiCanMailReminder.Text = "Can mail reminder cards"
        '
        'txtCiZip
        '
        Me.txtCiZip.BackColor = System.Drawing.SystemColors.Window
        Me.txtCiZip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiZip.Location = New System.Drawing.Point(377, 37)
        Me.txtCiZip.Name = "txtCiZip"
        Me.txtCiZip.ReadOnly = True
        Me.txtCiZip.Size = New System.Drawing.Size(98, 21)
        Me.txtCiZip.TabIndex = 20
        Me.txtCiZip.Text = "Zip"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label14.Location = New System.Drawing.Point(268, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "State"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCiState
        '
        Me.txtCiState.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCiState.BackColor = System.Drawing.SystemColors.Window
        Me.txtCiState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiState.Location = New System.Drawing.Point(304, 37)
        Me.txtCiState.Name = "txtCiState"
        Me.txtCiState.ReadOnly = True
        Me.txtCiState.Size = New System.Drawing.Size(40, 21)
        Me.txtCiState.TabIndex = 18
        Me.txtCiState.Text = "State"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label16.Location = New System.Drawing.Point(5, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 15)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Address"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCiCity
        '
        Me.txtCiCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCiCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtCiCity.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiCity.Location = New System.Drawing.Point(54, 37)
        Me.txtCiCity.Name = "txtCiCity"
        Me.txtCiCity.ReadOnly = True
        Me.txtCiCity.Size = New System.Drawing.Size(212, 21)
        Me.txtCiCity.TabIndex = 11
        Me.txtCiCity.Text = "City"
        '
        'txtCiAddress1
        '
        Me.txtCiAddress1.BackColor = System.Drawing.SystemColors.Window
        Me.txtCiAddress1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiAddress1.Location = New System.Drawing.Point(54, 11)
        Me.txtCiAddress1.Name = "txtCiAddress1"
        Me.txtCiAddress1.ReadOnly = True
        Me.txtCiAddress1.Size = New System.Drawing.Size(340, 21)
        Me.txtCiAddress1.TabIndex = 6
        Me.txtCiAddress1.Text = "Address"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label17.Location = New System.Drawing.Point(2, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 15)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "Can text message    "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkCiCanTextMessage
        '
        Me.chkCiCanTextMessage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCiCanTextMessage.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkCiCanTextMessage.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkCiCanTextMessage.Location = New System.Drawing.Point(5, 81)
        Me.chkCiCanTextMessage.Name = "chkCiCanTextMessage"
        Me.chkCiCanTextMessage.Size = New System.Drawing.Size(148, 21)
        Me.chkCiCanTextMessage.TabIndex = 96
        Me.chkCiCanTextMessage.Text = "Can text message"
        '
        'txtCiAddress2
        '
        Me.txtCiAddress2.BackColor = System.Drawing.SystemColors.Window
        Me.txtCiAddress2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiAddress2.Location = New System.Drawing.Point(435, 11)
        Me.txtCiAddress2.Name = "txtCiAddress2"
        Me.txtCiAddress2.ReadOnly = True
        Me.txtCiAddress2.Size = New System.Drawing.Size(40, 21)
        Me.txtCiAddress2.TabIndex = 95
        Me.txtCiAddress2.Text = "AptNum"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label18.Location = New System.Drawing.Point(397, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 15)
        Me.Label18.TabIndex = 94
        Me.Label18.Text = "Apt #"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tabContactInfo
        '
        Me.tabContactInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabContactInfo.Location = New System.Drawing.Point(2, 2)
        Me.tabContactInfo.Name = "tabContactInfo"
        Me.tabContactInfo.SelectedIndex = 0
        Me.tabContactInfo.Size = New System.Drawing.Size(898, 30)
        Me.tabContactInfo.TabIndex = 109
        '
        'Tab1P3
        '
        Me.Tab1P3.BackColor = System.Drawing.SystemColors.Control
        Me.Tab1P3.Controls.Add(Me.Label22)
        Me.Tab1P3.Controls.Add(Me.lblHpvEpiFU)
        Me.Tab1P3.Controls.Add(Me.lvwHpvEpiFU)
        Me.Tab1P3.Controls.Add(Me.btnDelHpvEpi)
        Me.Tab1P3.Controls.Add(Me.btnAddHpvEpi)
        Me.Tab1P3.Controls.Add(Me.btnEditHpvEpi)
        Me.Tab1P3.Controls.Add(Me.lvwHpvEpi)
        Me.Tab1P3.Controls.Add(Me.tabHpv)
        Me.Tab1P3.Controls.Add(Me.lblNoHpvEpisodes)
        Me.Tab1P3.Location = New System.Drawing.Point(4, 22)
        Me.Tab1P3.Name = "Tab1P3"
        Me.Tab1P3.Size = New System.Drawing.Size(911, 632)
        Me.Tab1P3.TabIndex = 2
        Me.Tab1P3.Text = "HPV"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label22.Location = New System.Drawing.Point(136, 7)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 14)
        Me.Label22.TabIndex = 117
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHpvEpiFU
        '
        Me.lblHpvEpiFU.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpvEpiFU.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHpvEpiFU.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblHpvEpiFU.Location = New System.Drawing.Point(861, 8)
        Me.lblHpvEpiFU.Name = "lblHpvEpiFU"
        Me.lblHpvEpiFU.Size = New System.Drawing.Size(183, 15)
        Me.lblHpvEpiFU.TabIndex = 115
        Me.lblHpvEpiFU.Text = "Episodes/Visits  to follow  up:"
        Me.lblHpvEpiFU.Visible = False
        '
        'lvwHpvEpiFU
        '
        Me.lvwHpvEpiFU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwHpvEpiFU.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvwHpvEpiFU.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvEpiFU.GridLines = True
        Me.lvwHpvEpiFU.HideSelection = False
        Me.lvwHpvEpiFU.Location = New System.Drawing.Point(746, 26)
        Me.lvwHpvEpiFU.MultiSelect = False
        Me.lvwHpvEpiFU.Name = "lvwHpvEpiFU"
        Me.lvwHpvEpiFU.Size = New System.Drawing.Size(210, 92)
        Me.lvwHpvEpiFU.TabIndex = 98
        Me.lvwHpvEpiFU.UseCompatibleStateImageBehavior = False
        Me.lvwHpvEpiFU.View = System.Windows.Forms.View.Details
        Me.lvwHpvEpiFU.Visible = False
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Episode ID"
        Me.ColumnHeader9.Width = 67
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Visit ID"
        Me.ColumnHeader10.Width = 50
        '
        'lvwHpvEpi
        '
        Me.lvwHpvEpi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvEpiC1, Me.lvwHpvEpiC2, Me.lvwHpvEpiC3, Me.lvwHpvEpiC15, Me.lvwHpvEpiC17, Me.lvwHpvEpiC4, Me.lvwHpvEpiC7, Me.lvwHpvEpiC8, Me.lvwHpvEpiC9, Me.lvwHpvEpiC10, Me.lvwHpvEpiC5, Me.lvwHpvEpiC13, Me.lvwHpvEpiC14, Me.lvwHpvEpiC6})
        Me.lvwHpvEpi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvEpi.FullRowSelect = True
        Me.lvwHpvEpi.GridLines = True
        Me.lvwHpvEpi.HideSelection = False
        Me.lvwHpvEpi.Location = New System.Drawing.Point(5, 25)
        Me.lvwHpvEpi.MultiSelect = False
        Me.lvwHpvEpi.Name = "lvwHpvEpi"
        Me.lvwHpvEpi.Size = New System.Drawing.Size(1107, 93)
        Me.lvwHpvEpi.TabIndex = 33
        Me.lvwHpvEpi.UseCompatibleStateImageBehavior = False
        Me.lvwHpvEpi.View = System.Windows.Forms.View.Details
        '
        'lvwHpvEpiC1
        '
        Me.lvwHpvEpiC1.Text = "Episode#"
        '
        'lvwHpvEpiC2
        '
        Me.lvwHpvEpiC2.Text = "Subj. ID"
        Me.lvwHpvEpiC2.Width = 55
        '
        'lvwHpvEpiC3
        '
        Me.lvwHpvEpiC3.Text = "Eligible"
        Me.lvwHpvEpiC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwHpvEpiC3.Width = 48
        '
        'lvwHpvEpiC15
        '
        Me.lvwHpvEpiC15.Text = "Type"
        Me.lvwHpvEpiC15.Width = 125
        '
        'lvwHpvEpiC17
        '
        Me.lvwHpvEpiC17.Text = "Status"
        Me.lvwHpvEpiC17.Width = 140
        '
        'lvwHpvEpiC4
        '
        Me.lvwHpvEpiC4.Text = "Date"
        Me.lvwHpvEpiC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwHpvEpiC4.Width = 55
        '
        'lvwHpvEpiC7
        '
        Me.lvwHpvEpiC7.Text = "Entry Type"
        Me.lvwHpvEpiC7.Width = 80
        '
        'lvwHpvEpiC8
        '
        Me.lvwHpvEpiC8.Text = "Vacc. Date 1"
        Me.lvwHpvEpiC8.Width = 76
        '
        'lvwHpvEpiC9
        '
        Me.lvwHpvEpiC9.Text = "Vacc. Date 2"
        Me.lvwHpvEpiC9.Width = 76
        '
        'lvwHpvEpiC10
        '
        Me.lvwHpvEpiC10.Text = "Vacc. Date 3"
        Me.lvwHpvEpiC10.Width = 76
        '
        'lvwHpvEpiC5
        '
        Me.lvwHpvEpiC5.Text = "Notes"
        Me.lvwHpvEpiC5.Width = 225
        '
        'lvwHpvEpiC13
        '
        Me.lvwHpvEpiC13.Text = "Research"
        Me.lvwHpvEpiC13.Width = 90
        '
        'lvwHpvEpiC14
        '
        Me.lvwHpvEpiC14.Text = "TypeID"
        Me.lvwHpvEpiC14.Width = 0
        '
        'lvwHpvEpiC6
        '
        Me.lvwHpvEpiC6.Text = "Epi. ID"
        Me.lvwHpvEpiC6.Width = 0
        '
        'tabHpv
        '
        Me.tabHpv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabHpv.Controls.Add(Me.tabHpvP1)
        Me.tabHpv.Controls.Add(Me.tabHpvP2)
        Me.tabHpv.Controls.Add(Me.tabPregnancies)
        Me.tabHpv.Location = New System.Drawing.Point(5, 124)
        Me.tabHpv.Name = "tabHpv"
        Me.tabHpv.SelectedIndex = 0
        Me.tabHpv.Size = New System.Drawing.Size(900, 503)
        Me.tabHpv.TabIndex = 0
        '
        'tabHpvP1
        '
        Me.tabHpvP1.Controls.Add(Me.grpProgressInfo)
        Me.tabHpvP1.Controls.Add(Me.tabHpvVst)
        Me.tabHpvP1.Controls.Add(Me.btnDelHpvVst)
        Me.tabHpvP1.Controls.Add(Me.btnAddHpvVst)
        Me.tabHpvP1.Controls.Add(Me.btnEditHpvVst)
        Me.tabHpvP1.Controls.Add(Me.lvwHpvVst)
        Me.tabHpvP1.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvP1.Name = "tabHpvP1"
        Me.tabHpvP1.Size = New System.Drawing.Size(892, 477)
        Me.tabHpvP1.TabIndex = 2
        Me.tabHpvP1.Text = "Visit Related Info"
        '
        'grpProgressInfo
        '
        Me.grpProgressInfo.Controls.Add(Me.Label102)
        Me.grpProgressInfo.Controls.Add(Me.spbHpvVst6)
        Me.grpProgressInfo.Controls.Add(Me.spbHpvVst5)
        Me.grpProgressInfo.Controls.Add(Me.spbHpvVst4)
        Me.grpProgressInfo.Controls.Add(Me.spbHpvVst3)
        Me.grpProgressInfo.Controls.Add(Me.spbHpvVst2)
        Me.grpProgressInfo.Controls.Add(Me.lblHpvProjected)
        Me.grpProgressInfo.Controls.Add(Me.spbHpvVst1)
        Me.grpProgressInfo.Controls.Add(Me.lblHpvVstDate6)
        Me.grpProgressInfo.Controls.Add(Me.lblHpvVstDate5)
        Me.grpProgressInfo.Controls.Add(Me.lblHpvVstDate4)
        Me.grpProgressInfo.Controls.Add(Me.lblHpvVstDate3)
        Me.grpProgressInfo.Controls.Add(Me.lblHpvVstDate2)
        Me.grpProgressInfo.Controls.Add(Me.lblHpvVstDate1)
        Me.grpProgressInfo.Controls.Add(Me.Label79)
        Me.grpProgressInfo.Controls.Add(Me.Label69)
        Me.grpProgressInfo.Controls.Add(Me.spbHpvNumVisits)
        Me.grpProgressInfo.Controls.Add(Me.Label9)
        Me.grpProgressInfo.Controls.Add(Me.Label8)
        Me.grpProgressInfo.Controls.Add(Me.Label7)
        Me.grpProgressInfo.Controls.Add(Me.Label6)
        Me.grpProgressInfo.Controls.Add(Me.Label5)
        Me.grpProgressInfo.Controls.Add(Me.Label1)
        Me.grpProgressInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpProgressInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProgressInfo.Location = New System.Drawing.Point(3, 0)
        Me.grpProgressInfo.Name = "grpProgressInfo"
        Me.grpProgressInfo.Size = New System.Drawing.Size(577, 66)
        Me.grpProgressInfo.TabIndex = 108
        Me.grpProgressInfo.TabStop = False
        '
        'Label102
        '
        Me.Label102.BackColor = System.Drawing.Color.Transparent
        Me.Label102.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label102.Location = New System.Drawing.Point(513, 15)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(441, 20)
        Me.Label102.TabIndex = 129
        Me.Label102.Text = "1 (Baseline)                            2 (6 mon.)     3 (12 mon.)   4 (18 mon.) " &
    "   5 (24 mon.)"
        Me.Label102.Visible = False
        '
        'spbHpvVst6
        '
        Me.spbHpvVst6.BackColor1 = System.Drawing.SystemColors.ControlLight
        Me.spbHpvVst6.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.spbHpvVst6.BackColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst6.BackGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst6.BackSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst6.BarColor1 = System.Drawing.Color.LightCyan
        Me.spbHpvVst6.BarColor2 = System.Drawing.Color.SkyBlue
        Me.spbHpvVst6.BarColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst6.BarGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst6.BarSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst6.Location = New System.Drawing.Point(429, 13)
        Me.spbHpvVst6.Maximum = 1
        Me.spbHpvVst6.Name = "spbHpvVst6"
        Me.spbHpvVst6.Size = New System.Drawing.Size(75, 16)
        Me.spbHpvVst6.TabIndex = 128
        '
        'spbHpvVst5
        '
        Me.spbHpvVst5.BackColor1 = System.Drawing.SystemColors.ControlLight
        Me.spbHpvVst5.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.spbHpvVst5.BackColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst5.BackGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst5.BackSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst5.BarColor1 = System.Drawing.Color.LightCyan
        Me.spbHpvVst5.BarColor2 = System.Drawing.Color.SkyBlue
        Me.spbHpvVst5.BarColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst5.BarGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst5.BarSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst5.Location = New System.Drawing.Point(355, 13)
        Me.spbHpvVst5.Maximum = 1
        Me.spbHpvVst5.Name = "spbHpvVst5"
        Me.spbHpvVst5.Size = New System.Drawing.Size(75, 16)
        Me.spbHpvVst5.TabIndex = 127
        '
        'spbHpvVst4
        '
        Me.spbHpvVst4.BackColor1 = System.Drawing.SystemColors.ControlLight
        Me.spbHpvVst4.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.spbHpvVst4.BackColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst4.BackGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst4.BackSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst4.BarColor1 = System.Drawing.Color.LightCyan
        Me.spbHpvVst4.BarColor2 = System.Drawing.Color.SkyBlue
        Me.spbHpvVst4.BarColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst4.BarGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst4.BarSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst4.Location = New System.Drawing.Point(283, 13)
        Me.spbHpvVst4.Maximum = 1
        Me.spbHpvVst4.Name = "spbHpvVst4"
        Me.spbHpvVst4.Size = New System.Drawing.Size(73, 16)
        Me.spbHpvVst4.TabIndex = 126
        '
        'spbHpvVst3
        '
        Me.spbHpvVst3.BackColor1 = System.Drawing.SystemColors.ControlLight
        Me.spbHpvVst3.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.spbHpvVst3.BackColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst3.BackGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst3.BackSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst3.BarColor1 = System.Drawing.Color.LightCyan
        Me.spbHpvVst3.BarColor2 = System.Drawing.Color.SkyBlue
        Me.spbHpvVst3.BarColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst3.BarGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst3.BarSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst3.Location = New System.Drawing.Point(211, 13)
        Me.spbHpvVst3.Maximum = 1
        Me.spbHpvVst3.Name = "spbHpvVst3"
        Me.spbHpvVst3.Size = New System.Drawing.Size(73, 16)
        Me.spbHpvVst3.TabIndex = 125
        '
        'spbHpvVst2
        '
        Me.spbHpvVst2.BackColor1 = System.Drawing.SystemColors.ControlLight
        Me.spbHpvVst2.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.spbHpvVst2.BackColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst2.BackGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst2.BackSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst2.BarColor1 = System.Drawing.Color.LightCyan
        Me.spbHpvVst2.BarColor2 = System.Drawing.Color.SkyBlue
        Me.spbHpvVst2.BarColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst2.BarGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst2.BarSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst2.Location = New System.Drawing.Point(139, 13)
        Me.spbHpvVst2.Maximum = 1
        Me.spbHpvVst2.Name = "spbHpvVst2"
        Me.spbHpvVst2.Size = New System.Drawing.Size(73, 16)
        Me.spbHpvVst2.TabIndex = 124
        '
        'lblHpvProjected
        '
        Me.lblHpvProjected.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpvProjected.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHpvProjected.ForeColor = System.Drawing.Color.Red
        Me.lblHpvProjected.Location = New System.Drawing.Point(511, 45)
        Me.lblHpvProjected.Name = "lblHpvProjected"
        Me.lblHpvProjected.Size = New System.Drawing.Size(62, 15)
        Me.lblHpvProjected.TabIndex = 126
        Me.lblHpvProjected.Text = "*Projected"
        Me.lblHpvProjected.Visible = False
        '
        'spbHpvVst1
        '
        Me.spbHpvVst1.BackColor1 = System.Drawing.SystemColors.ControlLight
        Me.spbHpvVst1.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.spbHpvVst1.BackColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst1.BackGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst1.BackSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst1.BarColor1 = System.Drawing.Color.LightCyan
        Me.spbHpvVst1.BarColor2 = System.Drawing.Color.SkyBlue
        Me.spbHpvVst1.BarColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvVst1.BarGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvVst1.BarSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvVst1.Location = New System.Drawing.Point(65, 13)
        Me.spbHpvVst1.Maximum = 1
        Me.spbHpvVst1.Name = "spbHpvVst1"
        Me.spbHpvVst1.Size = New System.Drawing.Size(75, 16)
        Me.spbHpvVst1.TabIndex = 123
        '
        'lblHpvVstDate6
        '
        Me.lblHpvVstDate6.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpvVstDate6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHpvVstDate6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHpvVstDate6.Location = New System.Drawing.Point(431, 45)
        Me.lblHpvVstDate6.Name = "lblHpvVstDate6"
        Me.lblHpvVstDate6.Size = New System.Drawing.Size(74, 15)
        Me.lblHpvVstDate6.TabIndex = 122
        Me.lblHpvVstDate6.Text = "Visit Date 6"
        Me.lblHpvVstDate6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHpvVstDate6.Visible = False
        '
        'lblHpvVstDate5
        '
        Me.lblHpvVstDate5.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpvVstDate5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHpvVstDate5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHpvVstDate5.Location = New System.Drawing.Point(358, 45)
        Me.lblHpvVstDate5.Name = "lblHpvVstDate5"
        Me.lblHpvVstDate5.Size = New System.Drawing.Size(74, 15)
        Me.lblHpvVstDate5.TabIndex = 121
        Me.lblHpvVstDate5.Text = "Visit Date 5"
        Me.lblHpvVstDate5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHpvVstDate5.Visible = False
        '
        'lblHpvVstDate4
        '
        Me.lblHpvVstDate4.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpvVstDate4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHpvVstDate4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHpvVstDate4.Location = New System.Drawing.Point(284, 45)
        Me.lblHpvVstDate4.Name = "lblHpvVstDate4"
        Me.lblHpvVstDate4.Size = New System.Drawing.Size(74, 15)
        Me.lblHpvVstDate4.TabIndex = 120
        Me.lblHpvVstDate4.Text = "Visit Date 4"
        Me.lblHpvVstDate4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHpvVstDate4.Visible = False
        '
        'lblHpvVstDate3
        '
        Me.lblHpvVstDate3.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpvVstDate3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHpvVstDate3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHpvVstDate3.Location = New System.Drawing.Point(211, 45)
        Me.lblHpvVstDate3.Name = "lblHpvVstDate3"
        Me.lblHpvVstDate3.Size = New System.Drawing.Size(74, 15)
        Me.lblHpvVstDate3.TabIndex = 119
        Me.lblHpvVstDate3.Text = "Visit Date 3"
        Me.lblHpvVstDate3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHpvVstDate3.Visible = False
        '
        'lblHpvVstDate2
        '
        Me.lblHpvVstDate2.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpvVstDate2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHpvVstDate2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHpvVstDate2.Location = New System.Drawing.Point(139, 45)
        Me.lblHpvVstDate2.Name = "lblHpvVstDate2"
        Me.lblHpvVstDate2.Size = New System.Drawing.Size(74, 15)
        Me.lblHpvVstDate2.TabIndex = 118
        Me.lblHpvVstDate2.Text = "Visit Date 2"
        Me.lblHpvVstDate2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHpvVstDate2.Visible = False
        '
        'lblHpvVstDate1
        '
        Me.lblHpvVstDate1.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpvVstDate1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHpvVstDate1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHpvVstDate1.Location = New System.Drawing.Point(65, 45)
        Me.lblHpvVstDate1.Name = "lblHpvVstDate1"
        Me.lblHpvVstDate1.Size = New System.Drawing.Size(74, 15)
        Me.lblHpvVstDate1.TabIndex = 117
        Me.lblHpvVstDate1.Text = "Visit Date 1"
        Me.lblHpvVstDate1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHpvVstDate1.Visible = False
        '
        'Label79
        '
        Me.Label79.BackColor = System.Drawing.SystemColors.Control
        Me.Label79.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label79.Location = New System.Drawing.Point(5, 45)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(56, 15)
        Me.Label79.TabIndex = 116
        Me.Label79.Text = "Visit Date:"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.SystemColors.Control
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label69.Location = New System.Drawing.Point(5, 14)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(52, 15)
        Me.Label69.TabIndex = 114
        Me.Label69.Text = "Progress:"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'spbHpvNumVisits
        '
        Me.spbHpvNumVisits.BackColor1 = System.Drawing.SystemColors.ControlLight
        Me.spbHpvNumVisits.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.spbHpvNumVisits.BackColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvNumVisits.BackGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvNumVisits.BackSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvNumVisits.BarColor1 = System.Drawing.Color.LightCyan
        Me.spbHpvNumVisits.BarColor2 = System.Drawing.Color.SkyBlue
        Me.spbHpvNumVisits.BarColorStyle = SPB.SmoothProgressBar.ColorStyle.Gradient
        Me.spbHpvNumVisits.BarGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.spbHpvNumVisits.BarSigmaMode = SPB.SmoothProgressBar.SigmaMode.SigmaBell
        Me.spbHpvNumVisits.Location = New System.Drawing.Point(65, 13)
        Me.spbHpvNumVisits.Maximum = 60
        Me.spbHpvNumVisits.Name = "spbHpvNumVisits"
        Me.spbHpvNumVisits.Size = New System.Drawing.Size(439, 16)
        Me.spbHpvNumVisits.TabIndex = 113
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(145, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 14)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "1x (2 mon.)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(436, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "5 (24 mon.)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(361, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 14)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "4 (18 mon.)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(288, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 14)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "3 (12 mon.)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(216, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "2 (6 mon.)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(69, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 14)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "1 (Baseline)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tabHpvVst
        '
        Me.tabHpvVst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstP1)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstP2)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstP3)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstP4)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstAdveresEvent)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstP5)
        Me.tabHpvVst.Location = New System.Drawing.Point(457, 69)
        Me.tabHpvVst.Name = "tabHpvVst"
        Me.tabHpvVst.SelectedIndex = 0
        Me.tabHpvVst.Size = New System.Drawing.Size(432, 405)
        Me.tabHpvVst.TabIndex = 76
        '
        'tabHpvVstP1
        '
        Me.tabHpvVstP1.Controls.Add(Me.lvwHpvCtHx)
        Me.tabHpvVstP1.Controls.Add(Me.lblNoHpvVisits)
        Me.tabHpvVstP1.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstP1.Name = "tabHpvVstP1"
        Me.tabHpvVstP1.Size = New System.Drawing.Size(424, 379)
        Me.tabHpvVstP1.TabIndex = 5
        Me.tabHpvVstP1.Text = "Contact Hx"
        Me.tabHpvVstP1.UseVisualStyleBackColor = True
        '
        'lvwHpvCtHx
        '
        Me.lvwHpvCtHx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwHpvCtHx.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lvwHpvCtHx.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstCtHxC1, Me.lvwHpvVstCtHxC2, Me.lvwHpvVstCtHxC3, Me.lvwHpvVstCtHxC4, Me.lvwHpvVstCtHxC5})
        Me.lvwHpvCtHx.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvCtHx.FullRowSelect = True
        Me.lvwHpvCtHx.GridLines = True
        Me.lvwHpvCtHx.HideSelection = False
        Me.lvwHpvCtHx.Location = New System.Drawing.Point(3, 3)
        Me.lvwHpvCtHx.MultiSelect = False
        Me.lvwHpvCtHx.Name = "lvwHpvCtHx"
        Me.lvwHpvCtHx.Size = New System.Drawing.Size(420, 372)
        Me.lvwHpvCtHx.TabIndex = 35
        Me.lvwHpvCtHx.UseCompatibleStateImageBehavior = False
        Me.lvwHpvCtHx.View = System.Windows.Forms.View.Details
        '
        'lvwHpvVstCtHxC1
        '
        Me.lvwHpvVstCtHxC1.Text = "Visit ID"
        Me.lvwHpvVstCtHxC1.Width = 0
        '
        'lvwHpvVstCtHxC2
        '
        Me.lvwHpvVstCtHxC2.Text = "Date"
        Me.lvwHpvVstCtHxC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwHpvVstCtHxC2.Width = 75
        '
        'lvwHpvVstCtHxC3
        '
        Me.lvwHpvVstCtHxC3.Text = "Contact Method"
        Me.lvwHpvVstCtHxC3.Width = 176
        '
        'lvwHpvVstCtHxC4
        '
        Me.lvwHpvVstCtHxC4.Text = "Notes"
        Me.lvwHpvVstCtHxC4.Width = 350
        '
        'lvwHpvVstCtHxC5
        '
        Me.lvwHpvVstCtHxC5.Text = "ID"
        Me.lvwHpvVstCtHxC5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstCtHxC5.Width = 0
        '
        'lblNoHpvVisits
        '
        Me.lblNoHpvVisits.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoHpvVisits.BackColor = System.Drawing.SystemColors.Control
        Me.lblNoHpvVisits.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHpvVisits.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoHpvVisits.Location = New System.Drawing.Point(-3, 3)
        Me.lblNoHpvVisits.Name = "lblNoHpvVisits"
        Me.lblNoHpvVisits.Size = New System.Drawing.Size(514, 113)
        Me.lblNoHpvVisits.TabIndex = 127
        Me.lblNoHpvVisits.Text = "No visits have been added to the selected HPV episode.  Click the 'Add' button to" &
    " add a new visit."
        Me.lblNoHpvVisits.Visible = False
        '
        'tabHpvVstP2
        '
        Me.tabHpvVstP2.Controls.Add(Me.lvwHpvVstVac)
        Me.tabHpvVstP2.Controls.Add(Me.lvwHpvVstSpec)
        Me.tabHpvVstP2.Controls.Add(Me.lvwHpvVstProc)
        Me.tabHpvVstP2.Controls.Add(Me.lvwHpvVstFormR)
        Me.tabHpvVstP2.Controls.Add(Me.lvwHpvVstFormPF)
        Me.tabHpvVstP2.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstP2.Name = "tabHpvVstP2"
        Me.tabHpvVstP2.Size = New System.Drawing.Size(424, 379)
        Me.tabHpvVstP2.TabIndex = 0
        Me.tabHpvVstP2.Text = "Forms & Procedures"
        Me.tabHpvVstP2.UseVisualStyleBackColor = True
        '
        'lvwHpvVstVac
        '
        Me.lvwHpvVstVac.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvwHpvVstVac.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lvwHpvVstVac.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstVacC1, Me.lvwHpvVstVacC2})
        Me.lvwHpvVstVac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstVac.GridLines = True
        Me.lvwHpvVstVac.HideSelection = False
        Me.lvwHpvVstVac.Location = New System.Drawing.Point(253, 307)
        Me.lvwHpvVstVac.Name = "lvwHpvVstVac"
        Me.lvwHpvVstVac.Size = New System.Drawing.Size(245, 66)
        Me.lvwHpvVstVac.TabIndex = 36
        Me.lvwHpvVstVac.UseCompatibleStateImageBehavior = False
        Me.lvwHpvVstVac.View = System.Windows.Forms.View.Details
        '
        'lvwHpvVstVacC1
        '
        Me.lvwHpvVstVacC1.Text = "Vaccinations confirmed"
        Me.lvwHpvVstVacC1.Width = 214
        '
        'lvwHpvVstVacC2
        '
        Me.lvwHpvVstVacC2.Text = "Cd"
        Me.lvwHpvVstVacC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstVacC2.Width = 0
        '
        'lvwHpvVstSpec
        '
        Me.lvwHpvVstSpec.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lvwHpvVstSpec.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstSpecC1, Me.lvwHpvVstSpecC2})
        Me.lvwHpvVstSpec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstSpec.GridLines = True
        Me.lvwHpvVstSpec.HideSelection = False
        Me.lvwHpvVstSpec.Location = New System.Drawing.Point(253, 157)
        Me.lvwHpvVstSpec.Name = "lvwHpvVstSpec"
        Me.lvwHpvVstSpec.Size = New System.Drawing.Size(245, 147)
        Me.lvwHpvVstSpec.TabIndex = 35
        Me.lvwHpvVstSpec.UseCompatibleStateImageBehavior = False
        Me.lvwHpvVstSpec.View = System.Windows.Forms.View.Details
        '
        'lvwHpvVstSpecC1
        '
        Me.lvwHpvVstSpecC1.Text = "Specimens collected"
        Me.lvwHpvVstSpecC1.Width = 214
        '
        'lvwHpvVstSpecC2
        '
        Me.lvwHpvVstSpecC2.Text = "Cd"
        Me.lvwHpvVstSpecC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstSpecC2.Width = 0
        '
        'lvwHpvVstProc
        '
        Me.lvwHpvVstProc.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lvwHpvVstProc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstProcC1, Me.lvwHpvVstProcC2})
        Me.lvwHpvVstProc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstProc.GridLines = True
        Me.lvwHpvVstProc.HideSelection = False
        Me.lvwHpvVstProc.Location = New System.Drawing.Point(253, 6)
        Me.lvwHpvVstProc.Name = "lvwHpvVstProc"
        Me.lvwHpvVstProc.Size = New System.Drawing.Size(245, 147)
        Me.lvwHpvVstProc.TabIndex = 34
        Me.lvwHpvVstProc.UseCompatibleStateImageBehavior = False
        Me.lvwHpvVstProc.View = System.Windows.Forms.View.Details
        '
        'lvwHpvVstProcC1
        '
        Me.lvwHpvVstProcC1.Text = "Procedures completed"
        Me.lvwHpvVstProcC1.Width = 214
        '
        'lvwHpvVstProcC2
        '
        Me.lvwHpvVstProcC2.Text = "Cd"
        Me.lvwHpvVstProcC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstProcC2.Width = 0
        '
        'lvwHpvVstFormR
        '
        Me.lvwHpvVstFormR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvwHpvVstFormR.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lvwHpvVstFormR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstFormRC1, Me.lvwHpvVstFormRC2})
        Me.lvwHpvVstFormR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstFormR.GridLines = True
        Me.lvwHpvVstFormR.HideSelection = False
        Me.lvwHpvVstFormR.Location = New System.Drawing.Point(7, 307)
        Me.lvwHpvVstFormR.Name = "lvwHpvVstFormR"
        Me.lvwHpvVstFormR.Size = New System.Drawing.Size(237, 66)
        Me.lvwHpvVstFormR.TabIndex = 32
        Me.lvwHpvVstFormR.UseCompatibleStateImageBehavior = False
        Me.lvwHpvVstFormR.View = System.Windows.Forms.View.Details
        '
        'lvwHpvVstFormRC1
        '
        Me.lvwHpvVstFormRC1.Text = "Forms for Researcher:"
        Me.lvwHpvVstFormRC1.Width = 214
        '
        'lvwHpvVstFormRC2
        '
        Me.lvwHpvVstFormRC2.Text = "Cd"
        Me.lvwHpvVstFormRC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstFormRC2.Width = 0
        '
        'lvwHpvVstFormPF
        '
        Me.lvwHpvVstFormPF.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lvwHpvVstFormPF.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstFormPFC1, Me.lvwHpvVstFormPFC2})
        Me.lvwHpvVstFormPF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstFormPF.GridLines = True
        Me.lvwHpvVstFormPF.HideSelection = False
        Me.lvwHpvVstFormPF.Location = New System.Drawing.Point(7, 6)
        Me.lvwHpvVstFormPF.Name = "lvwHpvVstFormPF"
        Me.lvwHpvVstFormPF.Size = New System.Drawing.Size(237, 297)
        Me.lvwHpvVstFormPF.TabIndex = 12
        Me.lvwHpvVstFormPF.UseCompatibleStateImageBehavior = False
        Me.lvwHpvVstFormPF.View = System.Windows.Forms.View.Details
        '
        'lvwHpvVstFormPFC1
        '
        Me.lvwHpvVstFormPFC1.Text = "Forms for Participant Folder:"
        Me.lvwHpvVstFormPFC1.Width = 214
        '
        'lvwHpvVstFormPFC2
        '
        Me.lvwHpvVstFormPFC2.Text = "Cd"
        Me.lvwHpvVstFormPFC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstFormPFC2.Width = 0
        '
        'tabHpvVstP3
        '
        Me.tabHpvVstP3.Controls.Add(Me.GroupBox2)
        Me.tabHpvVstP3.Controls.Add(Me.lvwHpvBS)
        Me.tabHpvVstP3.Controls.Add(Me.btnDelHpvBS)
        Me.tabHpvVstP3.Controls.Add(Me.btnAddHpvBS)
        Me.tabHpvVstP3.Controls.Add(Me.btnEditHpvBS)
        Me.tabHpvVstP3.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstP3.Name = "tabHpvVstP3"
        Me.tabHpvVstP3.Size = New System.Drawing.Size(424, 379)
        Me.tabHpvVstP3.TabIndex = 2
        Me.tabHpvVstP3.Text = "Blood"
        Me.tabHpvVstP3.UseVisualStyleBackColor = True
        Me.tabHpvVstP3.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtHpvBlood4)
        Me.GroupBox2.Controls.Add(Me.Label122)
        Me.GroupBox2.Controls.Add(Me.txtHpvBlood3)
        Me.GroupBox2.Controls.Add(Me.txtHpvBlood2)
        Me.GroupBox2.Controls.Add(Me.txtHpvBlood1)
        Me.GroupBox2.Controls.Add(Me.Label110)
        Me.GroupBox2.Controls.Add(Me.Label111)
        Me.GroupBox2.Controls.Add(Me.Label113)
        Me.GroupBox2.Controls.Add(Me.txtHpvBloodVisitProcActID)
        Me.GroupBox2.Controls.Add(Me.Label112)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 163)
        Me.GroupBox2.TabIndex = 130
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Blood Info:"
        '
        'txtHpvBlood4
        '
        Me.txtHpvBlood4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHpvBlood4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtHpvBlood4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHpvBlood4.Location = New System.Drawing.Point(166, 106)
        Me.txtHpvBlood4.Name = "txtHpvBlood4"
        Me.txtHpvBlood4.ReadOnly = True
        Me.txtHpvBlood4.Size = New System.Drawing.Size(49, 21)
        Me.txtHpvBlood4.TabIndex = 131
        '
        'Label122
        '
        Me.Label122.BackColor = System.Drawing.Color.Transparent
        Me.Label122.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label122.Location = New System.Drawing.Point(6, 109)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(152, 15)
        Me.Label122.TabIndex = 130
        Me.Label122.Text = "Number of Aliquots Obtained"
        '
        'txtHpvBlood3
        '
        Me.txtHpvBlood3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHpvBlood3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtHpvBlood3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHpvBlood3.Location = New System.Drawing.Point(166, 79)
        Me.txtHpvBlood3.Name = "txtHpvBlood3"
        Me.txtHpvBlood3.ReadOnly = True
        Me.txtHpvBlood3.Size = New System.Drawing.Size(174, 21)
        Me.txtHpvBlood3.TabIndex = 129
        '
        'txtHpvBlood2
        '
        Me.txtHpvBlood2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHpvBlood2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtHpvBlood2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHpvBlood2.Location = New System.Drawing.Point(166, 52)
        Me.txtHpvBlood2.Name = "txtHpvBlood2"
        Me.txtHpvBlood2.ReadOnly = True
        Me.txtHpvBlood2.Size = New System.Drawing.Size(174, 21)
        Me.txtHpvBlood2.TabIndex = 128
        '
        'txtHpvBlood1
        '
        Me.txtHpvBlood1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHpvBlood1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtHpvBlood1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHpvBlood1.Location = New System.Drawing.Point(166, 25)
        Me.txtHpvBlood1.Name = "txtHpvBlood1"
        Me.txtHpvBlood1.ReadOnly = True
        Me.txtHpvBlood1.Size = New System.Drawing.Size(174, 21)
        Me.txtHpvBlood1.TabIndex = 127
        '
        'Label110
        '
        Me.Label110.BackColor = System.Drawing.Color.Transparent
        Me.Label110.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label110.Location = New System.Drawing.Point(6, 28)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(138, 15)
        Me.Label110.TabIndex = 124
        Me.Label110.Text = "Blood Drawn Date/Time"
        '
        'Label111
        '
        Me.Label111.BackColor = System.Drawing.Color.Transparent
        Me.Label111.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label111.Location = New System.Drawing.Point(6, 55)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(138, 15)
        Me.Label111.TabIndex = 123
        Me.Label111.Text = "Blood Spun Date/Time"
        '
        'Label113
        '
        Me.Label113.BackColor = System.Drawing.Color.Transparent
        Me.Label113.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label113.Location = New System.Drawing.Point(6, 82)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(145, 15)
        Me.Label113.TabIndex = 122
        Me.Label113.Text = "Serum Extracted Date/Time"
        '
        'txtHpvBloodVisitProcActID
        '
        Me.txtHpvBloodVisitProcActID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtHpvBloodVisitProcActID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHpvBloodVisitProcActID.ForeColor = System.Drawing.Color.DimGray
        Me.txtHpvBloodVisitProcActID.Location = New System.Drawing.Point(166, 133)
        Me.txtHpvBloodVisitProcActID.Name = "txtHpvBloodVisitProcActID"
        Me.txtHpvBloodVisitProcActID.ReadOnly = True
        Me.txtHpvBloodVisitProcActID.Size = New System.Drawing.Size(81, 21)
        Me.txtHpvBloodVisitProcActID.TabIndex = 125
        Me.txtHpvBloodVisitProcActID.TabStop = False
        Me.txtHpvBloodVisitProcActID.Text = "VisitProcActID"
        '
        'Label112
        '
        Me.Label112.BackColor = System.Drawing.Color.Transparent
        Me.Label112.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.ForeColor = System.Drawing.Color.DimGray
        Me.Label112.Location = New System.Drawing.Point(6, 136)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(112, 15)
        Me.Label112.TabIndex = 126
        Me.Label112.Text = "Blood VisitProcActID"
        '
        'lvwHpvBS
        '
        Me.lvwHpvBS.AllowColumnReorder = True
        Me.lvwHpvBS.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lvwHpvBS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvBsC1, Me.lvwHpvBsC5})
        Me.lvwHpvBS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvBS.FullRowSelect = True
        Me.lvwHpvBS.GridLines = True
        Me.lvwHpvBS.HideSelection = False
        Me.lvwHpvBS.Location = New System.Drawing.Point(6, 198)
        Me.lvwHpvBS.MultiSelect = False
        Me.lvwHpvBS.Name = "lvwHpvBS"
        Me.lvwHpvBS.Size = New System.Drawing.Size(160, 107)
        Me.lvwHpvBS.TabIndex = 129
        Me.lvwHpvBS.UseCompatibleStateImageBehavior = False
        Me.lvwHpvBS.View = System.Windows.Forms.View.Details
        Me.lvwHpvBS.Visible = False
        '
        'lvwHpvBsC1
        '
        Me.lvwHpvBsC1.Text = "Aliquot #"
        Me.lvwHpvBsC1.Width = 66
        '
        'lvwHpvBsC5
        '
        Me.lvwHpvBsC5.Text = "ID"
        Me.lvwHpvBsC5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvBsC5.Width = 79
        '
        'btnDelHpvBS
        '
        Me.btnDelHpvBS.Enabled = False
        Me.btnDelHpvBS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelHpvBS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelHpvBS.ImageIndex = 1
        Me.btnDelHpvBS.Location = New System.Drawing.Point(81, 172)
        Me.btnDelHpvBS.Name = "btnDelHpvBS"
        Me.btnDelHpvBS.Size = New System.Drawing.Size(40, 20)
        Me.btnDelHpvBS.TabIndex = 128
        Me.btnDelHpvBS.Text = "Delete"
        Me.btnDelHpvBS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelHpvBS.Visible = False
        '
        'btnAddHpvBS
        '
        Me.btnAddHpvBS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddHpvBS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHpvBS.ImageIndex = 1
        Me.btnAddHpvBS.Location = New System.Drawing.Point(7, 172)
        Me.btnAddHpvBS.Name = "btnAddHpvBS"
        Me.btnAddHpvBS.Size = New System.Drawing.Size(34, 20)
        Me.btnAddHpvBS.TabIndex = 127
        Me.btnAddHpvBS.Text = "Add"
        Me.btnAddHpvBS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddHpvBS.Visible = False
        '
        'btnEditHpvBS
        '
        Me.btnEditHpvBS.Enabled = False
        Me.btnEditHpvBS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditHpvBS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditHpvBS.ImageIndex = 1
        Me.btnEditHpvBS.Location = New System.Drawing.Point(44, 172)
        Me.btnEditHpvBS.Name = "btnEditHpvBS"
        Me.btnEditHpvBS.Size = New System.Drawing.Size(34, 20)
        Me.btnEditHpvBS.TabIndex = 126
        Me.btnEditHpvBS.Text = "Edit"
        Me.btnEditHpvBS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditHpvBS.Visible = False
        '
        'tabHpvVstP4
        '
        Me.tabHpvVstP4.Controls.Add(Me.lvwHpvSpecSent)
        Me.tabHpvVstP4.Controls.Add(Me.txtLastEditDate)
        Me.tabHpvVstP4.Controls.Add(Me.txtPatientID)
        Me.tabHpvVstP4.Controls.Add(Me.txtVisitID)
        Me.tabHpvVstP4.Controls.Add(Me.Label63)
        Me.tabHpvVstP4.Controls.Add(Me.Label64)
        Me.tabHpvVstP4.Controls.Add(Me.Label65)
        Me.tabHpvVstP4.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstP4.Name = "tabHpvVstP4"
        Me.tabHpvVstP4.Size = New System.Drawing.Size(424, 379)
        Me.tabHpvVstP4.TabIndex = 3
        Me.tabHpvVstP4.Text = "Specimens Sent"
        Me.tabHpvVstP4.UseVisualStyleBackColor = True
        Me.tabHpvVstP4.Visible = False
        '
        'lvwHpvSpecSent
        '
        Me.lvwHpvSpecSent.AllowColumnReorder = True
        Me.lvwHpvSpecSent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwHpvSpecSent.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lvwHpvSpecSent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvSpecSentC1, Me.lvwHpvSpecSentC2})
        Me.lvwHpvSpecSent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvSpecSent.FullRowSelect = True
        Me.lvwHpvSpecSent.GridLines = True
        Me.lvwHpvSpecSent.HideSelection = False
        Me.lvwHpvSpecSent.Location = New System.Drawing.Point(4, 5)
        Me.lvwHpvSpecSent.MultiSelect = False
        Me.lvwHpvSpecSent.Name = "lvwHpvSpecSent"
        Me.lvwHpvSpecSent.Size = New System.Drawing.Size(418, 358)
        Me.lvwHpvSpecSent.TabIndex = 80
        Me.lvwHpvSpecSent.UseCompatibleStateImageBehavior = False
        Me.lvwHpvSpecSent.View = System.Windows.Forms.View.Details
        '
        'lvwHpvSpecSentC1
        '
        Me.lvwHpvSpecSentC1.Text = "Specimen"
        Me.lvwHpvSpecSentC1.Width = 180
        '
        'lvwHpvSpecSentC2
        '
        Me.lvwHpvSpecSentC2.Text = "Date Sent"
        Me.lvwHpvSpecSentC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwHpvSpecSentC2.Width = 109
        '
        'txtLastEditDate
        '
        Me.txtLastEditDate.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLastEditDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastEditDate.Location = New System.Drawing.Point(337, 371)
        Me.txtLastEditDate.Name = "txtLastEditDate"
        Me.txtLastEditDate.ReadOnly = True
        Me.txtLastEditDate.Size = New System.Drawing.Size(128, 21)
        Me.txtLastEditDate.TabIndex = 60
        Me.txtLastEditDate.Visible = False
        '
        'txtPatientID
        '
        Me.txtPatientID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPatientID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(71, 371)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(62, 21)
        Me.txtPatientID.TabIndex = 57
        Me.txtPatientID.Visible = False
        '
        'txtVisitID
        '
        Me.txtVisitID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtVisitID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitID.Location = New System.Drawing.Point(203, 371)
        Me.txtVisitID.Name = "txtVisitID"
        Me.txtVisitID.ReadOnly = True
        Me.txtVisitID.Size = New System.Drawing.Size(62, 21)
        Me.txtVisitID.TabIndex = 56
        Me.txtVisitID.Visible = False
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label63.Location = New System.Drawing.Point(280, 377)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(51, 15)
        Me.Label63.TabIndex = 61
        Me.Label63.Text = "Last Edit Date:"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label63.Visible = False
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label64.Location = New System.Drawing.Point(6, 377)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(59, 15)
        Me.Label64.TabIndex = 59
        Me.Label64.Text = "Patient ID:"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label64.Visible = False
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label65.Location = New System.Drawing.Point(150, 377)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(47, 15)
        Me.Label65.TabIndex = 58
        Me.Label65.Text = "Visit ID:"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label65.Visible = False
        '
        'tabHpvVstAdveresEvent
        '
        Me.tabHpvVstAdveresEvent.AutoScroll = True
        Me.tabHpvVstAdveresEvent.Controls.Add(Me.grpInterventions)
        Me.tabHpvVstAdveresEvent.Controls.Add(Me.grpSymptoms)
        Me.tabHpvVstAdveresEvent.Controls.Add(Me.grpAdverseEvent)
        Me.tabHpvVstAdveresEvent.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstAdveresEvent.Name = "tabHpvVstAdveresEvent"
        Me.tabHpvVstAdveresEvent.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHpvVstAdveresEvent.Size = New System.Drawing.Size(424, 379)
        Me.tabHpvVstAdveresEvent.TabIndex = 6
        Me.tabHpvVstAdveresEvent.Text = "Adverse Event"
        Me.tabHpvVstAdveresEvent.UseVisualStyleBackColor = True
        '
        'grpInterventions
        '
        Me.grpInterventions.Controls.Add(Me.grdInterventions)
        Me.grpInterventions.Location = New System.Drawing.Point(271, 247)
        Me.grpInterventions.Name = "grpInterventions"
        Me.grpInterventions.Size = New System.Drawing.Size(262, 138)
        Me.grpInterventions.TabIndex = 14
        Me.grpInterventions.TabStop = False
        Me.grpInterventions.Text = "Interventions"
        '
        'grdInterventions
        '
        Me.grdInterventions.AllowUserToAddRows = False
        Me.grdInterventions.AllowUserToDeleteRows = False
        Me.grdInterventions.AutoGenerateColumns = False
        Me.grdInterventions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdInterventions.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.grdInterventions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdInterventions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdEventsInterIDDataGridViewTextBoxColumn, Me.AdEventsLogIDDataGridViewTextBoxColumn1, Me.AdEvInterventionCdDataGridViewTextBoxColumn, Me.InterventionDesc, Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn})
        Me.grdInterventions.DataSource = Me.TbStuHpvAdEventsInterventionsBindingSource
        Me.grdInterventions.Location = New System.Drawing.Point(6, 18)
        Me.grdInterventions.Name = "grdInterventions"
        Me.grdInterventions.ReadOnly = True
        Me.grdInterventions.RowHeadersVisible = False
        Me.grdInterventions.Size = New System.Drawing.Size(250, 114)
        Me.grdInterventions.TabIndex = 11
        '
        'AdEventsInterIDDataGridViewTextBoxColumn
        '
        Me.AdEventsInterIDDataGridViewTextBoxColumn.DataPropertyName = "AdEventsInterID"
        Me.AdEventsInterIDDataGridViewTextBoxColumn.HeaderText = "AdEventsInterID"
        Me.AdEventsInterIDDataGridViewTextBoxColumn.Name = "AdEventsInterIDDataGridViewTextBoxColumn"
        Me.AdEventsInterIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdEventsInterIDDataGridViewTextBoxColumn.Visible = False
        '
        'AdEventsLogIDDataGridViewTextBoxColumn1
        '
        Me.AdEventsLogIDDataGridViewTextBoxColumn1.DataPropertyName = "AdEventsLogID"
        Me.AdEventsLogIDDataGridViewTextBoxColumn1.HeaderText = "AdEventsLogID"
        Me.AdEventsLogIDDataGridViewTextBoxColumn1.Name = "AdEventsLogIDDataGridViewTextBoxColumn1"
        Me.AdEventsLogIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AdEventsLogIDDataGridViewTextBoxColumn1.Visible = False
        '
        'AdEvInterventionCdDataGridViewTextBoxColumn
        '
        Me.AdEvInterventionCdDataGridViewTextBoxColumn.DataPropertyName = "AdEvInterventionCd"
        Me.AdEvInterventionCdDataGridViewTextBoxColumn.HeaderText = "AdEvInterventionCd"
        Me.AdEvInterventionCdDataGridViewTextBoxColumn.Name = "AdEvInterventionCdDataGridViewTextBoxColumn"
        Me.AdEvInterventionCdDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdEvInterventionCdDataGridViewTextBoxColumn.Visible = False
        '
        'InterventionDesc
        '
        Me.InterventionDesc.DataPropertyName = "InterventionDesc"
        Me.InterventionDesc.HeaderText = "Intervention"
        Me.InterventionDesc.Name = "InterventionDesc"
        Me.InterventionDesc.ReadOnly = True
        '
        'AdEvInterventionOtherDescDataGridViewTextBoxColumn
        '
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.DataPropertyName = "AdEvInterventionOtherDesc"
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.HeaderText = "Descriptions"
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.Name = "AdEvInterventionOtherDescDataGridViewTextBoxColumn"
        Me.AdEvInterventionOtherDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbStuHpvAdEventsInterventionsBindingSource
        '
        Me.TbStuHpvAdEventsInterventionsBindingSource.DataMember = "tbStuHpvAdEventsInterventions"
        Me.TbStuHpvAdEventsInterventionsBindingSource.DataSource = Me.RiSdataDataSet
        '
        'RiSdataDataSet
        '
        Me.RiSdataDataSet.DataSetName = "RISdataDataSet"
        Me.RiSdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpSymptoms
        '
        Me.grpSymptoms.Controls.Add(Me.grdSymptoms)
        Me.grpSymptoms.Location = New System.Drawing.Point(6, 247)
        Me.grpSymptoms.Name = "grpSymptoms"
        Me.grpSymptoms.Size = New System.Drawing.Size(262, 138)
        Me.grpSymptoms.TabIndex = 13
        Me.grpSymptoms.TabStop = False
        Me.grpSymptoms.Text = "Symptoms"
        '
        'grdSymptoms
        '
        Me.grdSymptoms.AllowUserToAddRows = False
        Me.grdSymptoms.AllowUserToDeleteRows = False
        Me.grdSymptoms.AutoGenerateColumns = False
        Me.grdSymptoms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdSymptoms.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.grdSymptoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSymptoms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdEventsSymptomsIDDataGridViewTextBoxColumn, Me.AdEventsLogIDDataGridViewTextBoxColumn, Me.AdEvSymptomCdDataGridViewTextBoxColumn, Me.SymptomDesc, Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn})
        Me.grdSymptoms.DataSource = Me.TbStuHpvAdEventsSymptomsBindingSource
        Me.grdSymptoms.Location = New System.Drawing.Point(6, 18)
        Me.grdSymptoms.Name = "grdSymptoms"
        Me.grdSymptoms.ReadOnly = True
        Me.grdSymptoms.RowHeadersVisible = False
        Me.grdSymptoms.Size = New System.Drawing.Size(250, 114)
        Me.grdSymptoms.TabIndex = 10
        '
        'AdEventsSymptomsIDDataGridViewTextBoxColumn
        '
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn.DataPropertyName = "AdEventsSymptomsID"
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn.HeaderText = "AdEventsSymptomsID"
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn.Name = "AdEventsSymptomsIDDataGridViewTextBoxColumn"
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdEventsSymptomsIDDataGridViewTextBoxColumn.Visible = False
        '
        'AdEventsLogIDDataGridViewTextBoxColumn
        '
        Me.AdEventsLogIDDataGridViewTextBoxColumn.DataPropertyName = "AdEventsLogID"
        Me.AdEventsLogIDDataGridViewTextBoxColumn.HeaderText = "AdEventsLogID"
        Me.AdEventsLogIDDataGridViewTextBoxColumn.Name = "AdEventsLogIDDataGridViewTextBoxColumn"
        Me.AdEventsLogIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdEventsLogIDDataGridViewTextBoxColumn.Visible = False
        '
        'AdEvSymptomCdDataGridViewTextBoxColumn
        '
        Me.AdEvSymptomCdDataGridViewTextBoxColumn.DataPropertyName = "AdEvSymptomCd"
        Me.AdEvSymptomCdDataGridViewTextBoxColumn.HeaderText = "AdEvSymptomCd"
        Me.AdEvSymptomCdDataGridViewTextBoxColumn.Name = "AdEvSymptomCdDataGridViewTextBoxColumn"
        Me.AdEvSymptomCdDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdEvSymptomCdDataGridViewTextBoxColumn.Visible = False
        '
        'SymptomDesc
        '
        Me.SymptomDesc.DataPropertyName = "SymptomDesc"
        Me.SymptomDesc.HeaderText = "Symptom"
        Me.SymptomDesc.Name = "SymptomDesc"
        Me.SymptomDesc.ReadOnly = True
        '
        'AdEvSymptomOtherDescDataGridViewTextBoxColumn
        '
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.DataPropertyName = "AdEvSymptomOtherDesc"
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.HeaderText = "Descriptions"
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.Name = "AdEvSymptomOtherDescDataGridViewTextBoxColumn"
        Me.AdEvSymptomOtherDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbStuHpvAdEventsSymptomsBindingSource
        '
        Me.TbStuHpvAdEventsSymptomsBindingSource.DataMember = "tbStuHpvAdEventsSymptoms"
        Me.TbStuHpvAdEventsSymptomsBindingSource.DataSource = Me.RiSdataDataSet
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
        Me.grpAdverseEvent.Location = New System.Drawing.Point(3, 6)
        Me.grpAdverseEvent.Name = "grpAdverseEvent"
        Me.grpAdverseEvent.Size = New System.Drawing.Size(530, 235)
        Me.grpAdverseEvent.TabIndex = 12
        Me.grpAdverseEvent.TabStop = False
        Me.grpAdverseEvent.Text = "Adverse Event"
        '
        'ResearcherCdComboBox
        '
        Me.ResearcherCdComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ResearcherCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbStuHpvAdEventsLogBindingSource, "ResearcherCd", True))
        Me.ResearcherCdComboBox.DataSource = Me.DdvResearcherBindingSource
        Me.ResearcherCdComboBox.DisplayMember = "LastName"
        Me.ResearcherCdComboBox.Enabled = False
        Me.ResearcherCdComboBox.FormattingEnabled = True
        Me.ResearcherCdComboBox.Location = New System.Drawing.Point(311, 21)
        Me.ResearcherCdComboBox.Name = "ResearcherCdComboBox"
        Me.ResearcherCdComboBox.Size = New System.Drawing.Size(210, 21)
        Me.ResearcherCdComboBox.TabIndex = 5
        Me.ResearcherCdComboBox.ValueMember = "ResearcherCd"
        '
        'TbStuHpvAdEventsLogBindingSource
        '
        Me.TbStuHpvAdEventsLogBindingSource.DataMember = "tbStuHpvAdEventsLog"
        Me.TbStuHpvAdEventsLogBindingSource.DataSource = Me.RiSdataDataSet
        '
        'DdvResearcherBindingSource
        '
        Me.DdvResearcherBindingSource.DataMember = "ddvResearcher"
        Me.DdvResearcherBindingSource.DataSource = Me.RiSdataDataSet
        '
        'PhysicianCdComboBox
        '
        Me.PhysicianCdComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PhysicianCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbStuHpvAdEventsLogBindingSource, "PhysicianCd", True))
        Me.PhysicianCdComboBox.DataSource = Me.DdvPhysicianBindingSource
        Me.PhysicianCdComboBox.DisplayMember = "LastName"
        Me.PhysicianCdComboBox.Enabled = False
        Me.PhysicianCdComboBox.FormattingEnabled = True
        Me.PhysicianCdComboBox.Location = New System.Drawing.Point(311, 48)
        Me.PhysicianCdComboBox.Name = "PhysicianCdComboBox"
        Me.PhysicianCdComboBox.Size = New System.Drawing.Size(210, 21)
        Me.PhysicianCdComboBox.TabIndex = 6
        Me.PhysicianCdComboBox.ValueMember = "PhysicianCd"
        '
        'DdvPhysicianBindingSource
        '
        Me.DdvPhysicianBindingSource.DataMember = "ddvPhysician"
        Me.DdvPhysicianBindingSource.DataSource = Me.RiSdataDataSet
        '
        'NotesTextBox
        '
        Me.NotesTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbStuHpvAdEventsLogBindingSource, "Notes", True))
        Me.NotesTextBox.Enabled = False
        Me.NotesTextBox.Location = New System.Drawing.Point(10, 175)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(511, 54)
        Me.NotesTextBox.TabIndex = 9
        '
        'IncreaseRiskYNCdComboBox
        '
        Me.IncreaseRiskYNCdComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.IncreaseRiskYNCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbStuHpvAdEventsLogBindingSource, "IncreaseRiskYNCd", True))
        Me.IncreaseRiskYNCdComboBox.DataSource = Me.DdvYesNoBindingSource
        Me.IncreaseRiskYNCdComboBox.DisplayMember = "YesNo"
        Me.IncreaseRiskYNCdComboBox.Enabled = False
        Me.IncreaseRiskYNCdComboBox.FormattingEnabled = True
        Me.IncreaseRiskYNCdComboBox.Location = New System.Drawing.Point(94, 130)
        Me.IncreaseRiskYNCdComboBox.Name = "IncreaseRiskYNCdComboBox"
        Me.IncreaseRiskYNCdComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IncreaseRiskYNCdComboBox.TabIndex = 4
        Me.IncreaseRiskYNCdComboBox.ValueMember = "YNCd"
        '
        'DdvYesNoBindingSource
        '
        Me.DdvYesNoBindingSource.DataMember = "ddvYesNo"
        Me.DdvYesNoBindingSource.DataSource = Me.RiSdataDataSet
        '
        'RelProtocolIDComboBox
        '
        Me.RelProtocolIDComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.RelProtocolIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbStuHpvAdEventsLogBindingSource, "RelProtocolID", True))
        Me.RelProtocolIDComboBox.DataSource = Me.DdvAdEventRelProtocolBindingSource
        Me.RelProtocolIDComboBox.DisplayMember = "AdEvRelProtocolDesc"
        Me.RelProtocolIDComboBox.Enabled = False
        Me.RelProtocolIDComboBox.FormattingEnabled = True
        Me.RelProtocolIDComboBox.Location = New System.Drawing.Point(311, 102)
        Me.RelProtocolIDComboBox.Name = "RelProtocolIDComboBox"
        Me.RelProtocolIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.RelProtocolIDComboBox.TabIndex = 8
        Me.RelProtocolIDComboBox.ValueMember = "AdEvRelProtocolCd"
        '
        'DdvAdEventRelProtocolBindingSource
        '
        Me.DdvAdEventRelProtocolBindingSource.DataMember = "ddvAdEventRelProtocol"
        Me.DdvAdEventRelProtocolBindingSource.DataSource = Me.RiSdataDataSet
        '
        'RecoveryIDComboBox
        '
        Me.RecoveryIDComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.RecoveryIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbStuHpvAdEventsLogBindingSource, "RecoveryID", True))
        Me.RecoveryIDComboBox.DataSource = Me.DdvAdEventRecoveryBindingSource
        Me.RecoveryIDComboBox.DisplayMember = "AdEvRecoveryDesc"
        Me.RecoveryIDComboBox.Enabled = False
        Me.RecoveryIDComboBox.FormattingEnabled = True
        Me.RecoveryIDComboBox.Location = New System.Drawing.Point(94, 102)
        Me.RecoveryIDComboBox.Name = "RecoveryIDComboBox"
        Me.RecoveryIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.RecoveryIDComboBox.TabIndex = 3
        Me.RecoveryIDComboBox.ValueMember = "AdEvRecoveryCd"
        '
        'DdvAdEventRecoveryBindingSource
        '
        Me.DdvAdEventRecoveryBindingSource.DataMember = "ddvAdEventRecovery"
        Me.DdvAdEventRecoveryBindingSource.DataSource = Me.RiSdataDataSet
        '
        'SeverityIDComboBox
        '
        Me.SeverityIDComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SeverityIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbStuHpvAdEventsLogBindingSource, "SeverityID", True))
        Me.SeverityIDComboBox.DataSource = Me.DdvAdEventSeverityBindingSource
        Me.SeverityIDComboBox.DisplayMember = "AdEvSeverityDesc"
        Me.SeverityIDComboBox.Enabled = False
        Me.SeverityIDComboBox.FormattingEnabled = True
        Me.SeverityIDComboBox.Location = New System.Drawing.Point(311, 75)
        Me.SeverityIDComboBox.Name = "SeverityIDComboBox"
        Me.SeverityIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SeverityIDComboBox.TabIndex = 7
        Me.SeverityIDComboBox.ValueMember = "AdEvSeverityCd"
        '
        'DdvAdEventSeverityBindingSource
        '
        Me.DdvAdEventSeverityBindingSource.DataMember = "ddvAdEventSeverity"
        Me.DdvAdEventSeverityBindingSource.DataSource = Me.RiSdataDataSet
        '
        'SeriousEventYNCdComboBox
        '
        Me.SeriousEventYNCdComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SeriousEventYNCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbStuHpvAdEventsLogBindingSource, "SeriousEventYNCd", True))
        Me.SeriousEventYNCdComboBox.DataSource = Me.DdvYesNoBindingSource
        Me.SeriousEventYNCdComboBox.DisplayMember = "YesNo"
        Me.SeriousEventYNCdComboBox.Enabled = False
        Me.SeriousEventYNCdComboBox.FormattingEnabled = True
        Me.SeriousEventYNCdComboBox.Location = New System.Drawing.Point(94, 75)
        Me.SeriousEventYNCdComboBox.Name = "SeriousEventYNCdComboBox"
        Me.SeriousEventYNCdComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SeriousEventYNCdComboBox.TabIndex = 2
        Me.SeriousEventYNCdComboBox.ValueMember = "YNCd"
        '
        'DateOnsetDateTimePicker
        '
        Me.DateOnsetDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder
        Me.DateOnsetDateTimePicker.CustomFormat = ""
        Me.DateOnsetDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbStuHpvAdEventsLogBindingSource, "DateOnset", True))
        Me.DateOnsetDateTimePicker.Enabled = False
        Me.DateOnsetDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateOnsetDateTimePicker.Location = New System.Drawing.Point(94, 48)
        Me.DateOnsetDateTimePicker.Name = "DateOnsetDateTimePicker"
        Me.DateOnsetDateTimePicker.Size = New System.Drawing.Size(121, 21)
        Me.DateOnsetDateTimePicker.TabIndex = 1
        '
        'NoAdEventYNCdComboBox
        '
        Me.NoAdEventYNCdComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.NoAdEventYNCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbStuHpvAdEventsLogBindingSource, "NoAdEventYNCd", True))
        Me.NoAdEventYNCdComboBox.DataSource = Me.DdvYesNoBindingSource
        Me.NoAdEventYNCdComboBox.DisplayMember = "YesNo"
        Me.NoAdEventYNCdComboBox.Enabled = False
        Me.NoAdEventYNCdComboBox.FormattingEnabled = True
        Me.NoAdEventYNCdComboBox.Location = New System.Drawing.Point(94, 21)
        Me.NoAdEventYNCdComboBox.Name = "NoAdEventYNCdComboBox"
        Me.NoAdEventYNCdComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NoAdEventYNCdComboBox.TabIndex = 0
        Me.NoAdEventYNCdComboBox.ValueMember = "YNCd"
        '
        'tabHpvVstP5
        '
        Me.tabHpvVstP5.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstP5.Name = "tabHpvVstP5"
        Me.tabHpvVstP5.Size = New System.Drawing.Size(424, 379)
        Me.tabHpvVstP5.TabIndex = 4
        Me.tabHpvVstP5.Text = "Results"
        Me.tabHpvVstP5.UseVisualStyleBackColor = True
        '
        'lvwHpvVst
        '
        Me.lvwHpvVst.AllowColumnReorder = True
        Me.lvwHpvVst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvwHpvVst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstC0, Me.lvwHpvVstC1, Me.lvwHpvVstC2, Me.lvwHpvVstC3, Me.lvwHpvVstC4, Me.lvwHpvVstC5, Me.lvwHpvVstC6})
        Me.lvwHpvVst.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVst.FullRowSelect = True
        Me.lvwHpvVst.GridLines = True
        Me.lvwHpvVst.HideSelection = False
        Me.lvwHpvVst.Location = New System.Drawing.Point(3, 92)
        Me.lvwHpvVst.MultiSelect = False
        Me.lvwHpvVst.Name = "lvwHpvVst"
        Me.lvwHpvVst.Size = New System.Drawing.Size(448, 378)
        Me.lvwHpvVst.TabIndex = 72
        Me.lvwHpvVst.UseCompatibleStateImageBehavior = False
        Me.lvwHpvVst.View = System.Windows.Forms.View.Details
        '
        'lvwHpvVstC0
        '
        Me.lvwHpvVstC0.Text = "VisitNum"
        Me.lvwHpvVstC0.Width = 0
        '
        'lvwHpvVstC1
        '
        Me.lvwHpvVstC1.Text = "#"
        Me.lvwHpvVstC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwHpvVstC1.Width = 25
        '
        'lvwHpvVstC2
        '
        Me.lvwHpvVstC2.Text = "Vst Date"
        Me.lvwHpvVstC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwHpvVstC2.Width = 68
        '
        'lvwHpvVstC3
        '
        Me.lvwHpvVstC3.Text = "Status"
        Me.lvwHpvVstC3.Width = 100
        '
        'lvwHpvVstC4
        '
        Me.lvwHpvVstC4.Text = "Notes"
        Me.lvwHpvVstC4.Width = 155
        '
        'lvwHpvVstC5
        '
        Me.lvwHpvVstC5.Text = "Visit Provider"
        Me.lvwHpvVstC5.Width = 90
        '
        'lvwHpvVstC6
        '
        Me.lvwHpvVstC6.Text = "Vst ID"
        Me.lvwHpvVstC6.Width = 0
        '
        'tabHpvP2
        '
        Me.tabHpvP2.Controls.Add(Me.txtDateScreened)
        Me.tabHpvP2.Controls.Add(Me.grpHpvSfEndPregnancy)
        Me.tabHpvP2.Controls.Add(Me.Label105)
        Me.tabHpvP2.Controls.Add(Me.lblPreg6)
        Me.tabHpvP2.Controls.Add(Me.Label107)
        Me.tabHpvP2.Controls.Add(Me.lblPreg1)
        Me.tabHpvP2.Controls.Add(Me.Label109)
        Me.tabHpvP2.Controls.Add(Me.Label114)
        Me.tabHpvP2.Controls.Add(Me.grpHpvSfHPVvaccinated)
        Me.tabHpvP2.Controls.Add(Me.lblPreg5)
        Me.tabHpvP2.Controls.Add(Me.grpHpvSfHasPeriod)
        Me.tabHpvP2.Controls.Add(Me.lblPreg4)
        Me.tabHpvP2.Controls.Add(Me.grpHpvSfThoughtPregnant)
        Me.tabHpvP2.Controls.Add(Me.lblPreg2)
        Me.tabHpvP2.Controls.Add(Me.grpHpvSfCurrentlyPregnant)
        Me.tabHpvP2.Controls.Add(Me.Label118)
        Me.tabHpvP2.Controls.Add(Me.Label119)
        Me.tabHpvP2.Controls.Add(Me.grpHpvSfWantHPVvaccine)
        Me.tabHpvP2.Controls.Add(Me.Label120)
        Me.tabHpvP2.Controls.Add(Me.Label121)
        Me.tabHpvP2.Controls.Add(Me.grpHpvSfSexuallyActive)
        Me.tabHpvP2.Controls.Add(Me.grpHpvSfSexualActType)
        Me.tabHpvP2.Controls.Add(Me.btnDelScrnForm)
        Me.tabHpvP2.Controls.Add(Me.btnEditScrnForm)
        Me.tabHpvP2.Controls.Add(Me.Label78)
        Me.tabHpvP2.Controls.Add(Me.grpHpvSfPlanToLeaveNYC)
        Me.tabHpvP2.Controls.Add(Me.lblPreg3)
        Me.tabHpvP2.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvP2.Name = "tabHpvP2"
        Me.tabHpvP2.Size = New System.Drawing.Size(892, 477)
        Me.tabHpvP2.TabIndex = 3
        Me.tabHpvP2.Text = "Screening Form"
        '
        'txtDateScreened
        '
        Me.txtDateScreened.BackColor = System.Drawing.SystemColors.Window
        Me.txtDateScreened.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateScreened.Location = New System.Drawing.Point(40, 33)
        Me.txtDateScreened.Name = "txtDateScreened"
        Me.txtDateScreened.ReadOnly = True
        Me.txtDateScreened.Size = New System.Drawing.Size(75, 21)
        Me.txtDateScreened.TabIndex = 181
        Me.txtDateScreened.Text = "DateScreened"
        Me.txtDateScreened.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpHpvSfEndPregnancy
        '
        Me.grpHpvSfEndPregnancy.Controls.Add(Me.cboOutComeOfPreg)
        Me.grpHpvSfEndPregnancy.Controls.Add(Me.txtEndPregnancyDate)
        Me.grpHpvSfEndPregnancy.Controls.Add(Me.Label104)
        Me.grpHpvSfEndPregnancy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHpvSfEndPregnancy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHpvSfEndPregnancy.Location = New System.Drawing.Point(301, 172)
        Me.grpHpvSfEndPregnancy.Name = "grpHpvSfEndPregnancy"
        Me.grpHpvSfEndPregnancy.Size = New System.Drawing.Size(242, 63)
        Me.grpHpvSfEndPregnancy.TabIndex = 161
        Me.grpHpvSfEndPregnancy.TabStop = False
        '
        'cboOutComeOfPreg
        '
        Me.cboOutComeOfPreg.DataSource = Me.DdvPregnancyOutcomeTypeBindingSource
        Me.cboOutComeOfPreg.DisplayMember = "OutcomeDesc"
        Me.cboOutComeOfPreg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOutComeOfPreg.FormattingEnabled = True
        Me.cboOutComeOfPreg.Location = New System.Drawing.Point(10, 11)
        Me.cboOutComeOfPreg.Name = "cboOutComeOfPreg"
        Me.cboOutComeOfPreg.Size = New System.Drawing.Size(224, 21)
        Me.cboOutComeOfPreg.TabIndex = 183
        Me.cboOutComeOfPreg.ValueMember = "PregOutcomeTypeCd"
        '
        'DdvPregnancyOutcomeTypeBindingSource
        '
        Me.DdvPregnancyOutcomeTypeBindingSource.DataMember = "ddvPregnancyOutcomeType"
        Me.DdvPregnancyOutcomeTypeBindingSource.DataSource = Me.RiSdataDataSet
        '
        'txtEndPregnancyDate
        '
        Me.txtEndPregnancyDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndPregnancyDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndPregnancyDate.Location = New System.Drawing.Point(93, 36)
        Me.txtEndPregnancyDate.Name = "txtEndPregnancyDate"
        Me.txtEndPregnancyDate.ReadOnly = True
        Me.txtEndPregnancyDate.Size = New System.Drawing.Size(141, 21)
        Me.txtEndPregnancyDate.TabIndex = 182
        Me.txtEndPregnancyDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label104
        '
        Me.Label104.BackColor = System.Drawing.SystemColors.Control
        Me.Label104.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label104.Location = New System.Drawing.Point(1, 40)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(86, 15)
        Me.Label104.TabIndex = 157
        Me.Label104.Text = "Outcome Date:"
        Me.Label104.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label105
        '
        Me.Label105.BackColor = System.Drawing.SystemColors.Control
        Me.Label105.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.ForeColor = System.Drawing.Color.Black
        Me.Label105.Location = New System.Drawing.Point(6, 311)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(89, 15)
        Me.Label105.TabIndex = 177
        Me.Label105.Text = "HPV Vaccine Hx:"
        '
        'lblPreg6
        '
        Me.lblPreg6.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg6.ForeColor = System.Drawing.Color.Black
        Me.lblPreg6.Location = New System.Drawing.Point(6, 268)
        Me.lblPreg6.Name = "lblPreg6"
        Me.lblPreg6.Size = New System.Drawing.Size(75, 15)
        Me.lblPreg6.TabIndex = 176
        Me.lblPreg6.Text = "Menstrual Hx:"
        '
        'Label107
        '
        Me.Label107.BackColor = System.Drawing.SystemColors.Control
        Me.Label107.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.ForeColor = System.Drawing.Color.Black
        Me.Label107.Location = New System.Drawing.Point(6, 386)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(61, 15)
        Me.Label107.TabIndex = 178
        Me.Label107.Text = "Mobility:"
        '
        'lblPreg1
        '
        Me.lblPreg1.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg1.ForeColor = System.Drawing.Color.Black
        Me.lblPreg1.Location = New System.Drawing.Point(6, 132)
        Me.lblPreg1.Name = "lblPreg1"
        Me.lblPreg1.Size = New System.Drawing.Size(80, 15)
        Me.lblPreg1.TabIndex = 175
        Me.lblPreg1.Text = "Pregnancy Hx:"
        '
        'Label109
        '
        Me.Label109.BackColor = System.Drawing.SystemColors.Control
        Me.Label109.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.ForeColor = System.Drawing.Color.Black
        Me.Label109.Location = New System.Drawing.Point(6, 60)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(61, 15)
        Me.Label109.TabIndex = 174
        Me.Label109.Text = "Sexual Hx:"
        '
        'Label114
        '
        Me.Label114.BackColor = System.Drawing.SystemColors.Control
        Me.Label114.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label114.Location = New System.Drawing.Point(6, 330)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(295, 15)
        Me.Label114.TabIndex = 171
        Me.Label114.Text = "8. Have you ever been vaccinated with the HPV vaccine?"
        '
        'grpHpvSfHPVvaccinated
        '
        Me.grpHpvSfHPVvaccinated.Controls.Add(Me.rbScrFrmNo5)
        Me.grpHpvSfHPVvaccinated.Controls.Add(Me.rbScrFrmYes5)
        Me.grpHpvSfHPVvaccinated.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHpvSfHPVvaccinated.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHpvSfHPVvaccinated.Location = New System.Drawing.Point(301, 318)
        Me.grpHpvSfHPVvaccinated.Name = "grpHpvSfHPVvaccinated"
        Me.grpHpvSfHPVvaccinated.Size = New System.Drawing.Size(94, 33)
        Me.grpHpvSfHPVvaccinated.TabIndex = 163
        Me.grpHpvSfHPVvaccinated.TabStop = False
        '
        'rbScrFrmNo5
        '
        Me.rbScrFrmNo5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo5.Location = New System.Drawing.Point(54, 8)
        Me.rbScrFrmNo5.Name = "rbScrFrmNo5"
        Me.rbScrFrmNo5.Size = New System.Drawing.Size(33, 21)
        Me.rbScrFrmNo5.TabIndex = 33
        Me.rbScrFrmNo5.Tag = "N"
        Me.rbScrFrmNo5.Text = "No"
        Me.rbScrFrmNo5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbScrFrmYes5
        '
        Me.rbScrFrmYes5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmYes5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmYes5.Location = New System.Drawing.Point(5, 8)
        Me.rbScrFrmYes5.Name = "rbScrFrmYes5"
        Me.rbScrFrmYes5.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes5.TabIndex = 32
        Me.rbScrFrmYes5.Tag = "Y"
        Me.rbScrFrmYes5.Text = "Yes"
        Me.rbScrFrmYes5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPreg5
        '
        Me.lblPreg5.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg5.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPreg5.Location = New System.Drawing.Point(6, 287)
        Me.lblPreg5.Name = "lblPreg5"
        Me.lblPreg5.Size = New System.Drawing.Size(295, 15)
        Me.lblPreg5.TabIndex = 170
        Me.lblPreg5.Text = "7. Do you have your period right now?"
        '
        'grpHpvSfHasPeriod
        '
        Me.grpHpvSfHasPeriod.Controls.Add(Me.rbScrFrmNo4)
        Me.grpHpvSfHasPeriod.Controls.Add(Me.rbScrFrmYes4)
        Me.grpHpvSfHasPeriod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHpvSfHasPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHpvSfHasPeriod.Location = New System.Drawing.Point(301, 275)
        Me.grpHpvSfHasPeriod.Name = "grpHpvSfHasPeriod"
        Me.grpHpvSfHasPeriod.Size = New System.Drawing.Size(94, 33)
        Me.grpHpvSfHasPeriod.TabIndex = 162
        Me.grpHpvSfHasPeriod.TabStop = False
        '
        'rbScrFrmNo4
        '
        Me.rbScrFrmNo4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo4.Location = New System.Drawing.Point(54, 8)
        Me.rbScrFrmNo4.Name = "rbScrFrmNo4"
        Me.rbScrFrmNo4.Size = New System.Drawing.Size(33, 21)
        Me.rbScrFrmNo4.TabIndex = 33
        Me.rbScrFrmNo4.Tag = "N"
        Me.rbScrFrmNo4.Text = "No"
        Me.rbScrFrmNo4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbScrFrmYes4
        '
        Me.rbScrFrmYes4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmYes4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmYes4.Location = New System.Drawing.Point(5, 8)
        Me.rbScrFrmYes4.Name = "rbScrFrmYes4"
        Me.rbScrFrmYes4.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes4.TabIndex = 32
        Me.rbScrFrmYes4.Tag = "Y"
        Me.rbScrFrmYes4.Text = "Yes"
        Me.rbScrFrmYes4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPreg4
        '
        Me.lblPreg4.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg4.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPreg4.Location = New System.Drawing.Point(6, 247)
        Me.lblPreg4.Name = "lblPreg4"
        Me.lblPreg4.Size = New System.Drawing.Size(295, 15)
        Me.lblPreg4.TabIndex = 169
        Me.lblPreg4.Text = "5. As of today, do you think you are pregnant?"
        '
        'grpHpvSfThoughtPregnant
        '
        Me.grpHpvSfThoughtPregnant.Controls.Add(Me.rbScrFrmNo3)
        Me.grpHpvSfThoughtPregnant.Controls.Add(Me.rbScrFrmYes3)
        Me.grpHpvSfThoughtPregnant.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHpvSfThoughtPregnant.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHpvSfThoughtPregnant.Location = New System.Drawing.Point(301, 236)
        Me.grpHpvSfThoughtPregnant.Name = "grpHpvSfThoughtPregnant"
        Me.grpHpvSfThoughtPregnant.Size = New System.Drawing.Size(94, 33)
        Me.grpHpvSfThoughtPregnant.TabIndex = 160
        Me.grpHpvSfThoughtPregnant.TabStop = False
        '
        'rbScrFrmNo3
        '
        Me.rbScrFrmNo3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo3.Location = New System.Drawing.Point(54, 8)
        Me.rbScrFrmNo3.Name = "rbScrFrmNo3"
        Me.rbScrFrmNo3.Size = New System.Drawing.Size(33, 21)
        Me.rbScrFrmNo3.TabIndex = 33
        Me.rbScrFrmNo3.Tag = "N"
        Me.rbScrFrmNo3.Text = "No"
        Me.rbScrFrmNo3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbScrFrmYes3
        '
        Me.rbScrFrmYes3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmYes3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmYes3.Location = New System.Drawing.Point(5, 8)
        Me.rbScrFrmYes3.Name = "rbScrFrmYes3"
        Me.rbScrFrmYes3.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes3.TabIndex = 32
        Me.rbScrFrmYes3.Tag = "Y"
        Me.rbScrFrmYes3.Text = "Yes"
        Me.rbScrFrmYes3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPreg2
        '
        Me.lblPreg2.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg2.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPreg2.Location = New System.Drawing.Point(6, 152)
        Me.lblPreg2.Name = "lblPreg2"
        Me.lblPreg2.Size = New System.Drawing.Size(295, 15)
        Me.lblPreg2.TabIndex = 168
        Me.lblPreg2.Text = "3. Have you ever been pregnant?"
        '
        'grpHpvSfCurrentlyPregnant
        '
        Me.grpHpvSfCurrentlyPregnant.Controls.Add(Me.rbScrFrmNo2)
        Me.grpHpvSfCurrentlyPregnant.Controls.Add(Me.rbScrFrmYes2)
        Me.grpHpvSfCurrentlyPregnant.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHpvSfCurrentlyPregnant.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHpvSfCurrentlyPregnant.Location = New System.Drawing.Point(301, 137)
        Me.grpHpvSfCurrentlyPregnant.Name = "grpHpvSfCurrentlyPregnant"
        Me.grpHpvSfCurrentlyPregnant.Size = New System.Drawing.Size(94, 33)
        Me.grpHpvSfCurrentlyPregnant.TabIndex = 159
        Me.grpHpvSfCurrentlyPregnant.TabStop = False
        '
        'rbScrFrmNo2
        '
        Me.rbScrFrmNo2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo2.Location = New System.Drawing.Point(54, 8)
        Me.rbScrFrmNo2.Name = "rbScrFrmNo2"
        Me.rbScrFrmNo2.Size = New System.Drawing.Size(33, 21)
        Me.rbScrFrmNo2.TabIndex = 33
        Me.rbScrFrmNo2.Tag = "N"
        Me.rbScrFrmNo2.Text = "No"
        Me.rbScrFrmNo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbScrFrmYes2
        '
        Me.rbScrFrmYes2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmYes2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmYes2.Location = New System.Drawing.Point(5, 8)
        Me.rbScrFrmYes2.Name = "rbScrFrmYes2"
        Me.rbScrFrmYes2.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes2.TabIndex = 32
        Me.rbScrFrmYes2.Tag = "Y"
        Me.rbScrFrmYes2.Text = "Yes"
        Me.rbScrFrmYes2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label118
        '
        Me.Label118.BackColor = System.Drawing.Color.Transparent
        Me.Label118.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label118.Location = New System.Drawing.Point(7, 35)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(30, 15)
        Me.Label118.TabIndex = 173
        Me.Label118.Text = "Date"
        '
        'Label119
        '
        Me.Label119.BackColor = System.Drawing.SystemColors.Control
        Me.Label119.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label119.Location = New System.Drawing.Point(6, 363)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(295, 15)
        Me.Label119.TabIndex = 172
        Me.Label119.Text = "9. Would you like to receive the HPV vaccine?"
        '
        'grpHpvSfWantHPVvaccine
        '
        Me.grpHpvSfWantHPVvaccine.Controls.Add(Me.rbScrFrmNo6)
        Me.grpHpvSfWantHPVvaccine.Controls.Add(Me.rbScrFrmYes6)
        Me.grpHpvSfWantHPVvaccine.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHpvSfWantHPVvaccine.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHpvSfWantHPVvaccine.Location = New System.Drawing.Point(301, 351)
        Me.grpHpvSfWantHPVvaccine.Name = "grpHpvSfWantHPVvaccine"
        Me.grpHpvSfWantHPVvaccine.Size = New System.Drawing.Size(94, 33)
        Me.grpHpvSfWantHPVvaccine.TabIndex = 164
        Me.grpHpvSfWantHPVvaccine.TabStop = False
        '
        'rbScrFrmNo6
        '
        Me.rbScrFrmNo6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo6.Location = New System.Drawing.Point(54, 8)
        Me.rbScrFrmNo6.Name = "rbScrFrmNo6"
        Me.rbScrFrmNo6.Size = New System.Drawing.Size(33, 21)
        Me.rbScrFrmNo6.TabIndex = 33
        Me.rbScrFrmNo6.Tag = "N"
        Me.rbScrFrmNo6.Text = "No"
        Me.rbScrFrmNo6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbScrFrmYes6
        '
        Me.rbScrFrmYes6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmYes6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmYes6.Location = New System.Drawing.Point(5, 8)
        Me.rbScrFrmYes6.Name = "rbScrFrmYes6"
        Me.rbScrFrmYes6.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes6.TabIndex = 32
        Me.rbScrFrmYes6.Tag = "Y"
        Me.rbScrFrmYes6.Text = "Yes"
        Me.rbScrFrmYes6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label120
        '
        Me.Label120.BackColor = System.Drawing.SystemColors.Control
        Me.Label120.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label120.Location = New System.Drawing.Point(6, 111)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(295, 15)
        Me.Label120.TabIndex = 167
        Me.Label120.Text = "2. Type of sexual activity ever: Check all that apply"
        '
        'Label121
        '
        Me.Label121.BackColor = System.Drawing.SystemColors.Control
        Me.Label121.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label121.Location = New System.Drawing.Point(6, 80)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(295, 15)
        Me.Label121.TabIndex = 166
        Me.Label121.Text = "1. Are you or have you ever been sexually active?"
        '
        'grpHpvSfSexuallyActive
        '
        Me.grpHpvSfSexuallyActive.Controls.Add(Me.rbScrFrmNo1)
        Me.grpHpvSfSexuallyActive.Controls.Add(Me.rbScrFrmYes1)
        Me.grpHpvSfSexuallyActive.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHpvSfSexuallyActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHpvSfSexuallyActive.Location = New System.Drawing.Point(301, 68)
        Me.grpHpvSfSexuallyActive.Name = "grpHpvSfSexuallyActive"
        Me.grpHpvSfSexuallyActive.Size = New System.Drawing.Size(94, 33)
        Me.grpHpvSfSexuallyActive.TabIndex = 157
        Me.grpHpvSfSexuallyActive.TabStop = False
        '
        'rbScrFrmNo1
        '
        Me.rbScrFrmNo1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo1.Location = New System.Drawing.Point(54, 8)
        Me.rbScrFrmNo1.Name = "rbScrFrmNo1"
        Me.rbScrFrmNo1.Size = New System.Drawing.Size(33, 21)
        Me.rbScrFrmNo1.TabIndex = 33
        Me.rbScrFrmNo1.Tag = "N"
        Me.rbScrFrmNo1.Text = "No"
        Me.rbScrFrmNo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbScrFrmYes1
        '
        Me.rbScrFrmYes1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmYes1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmYes1.Location = New System.Drawing.Point(5, 8)
        Me.rbScrFrmYes1.Name = "rbScrFrmYes1"
        Me.rbScrFrmYes1.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes1.TabIndex = 32
        Me.rbScrFrmYes1.Tag = "Y"
        Me.rbScrFrmYes1.Text = "Yes"
        Me.rbScrFrmYes1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpHpvSfSexualActType
        '
        Me.grpHpvSfSexualActType.Controls.Add(Me.chkScrFrm1_2)
        Me.grpHpvSfSexualActType.Controls.Add(Me.chkScrFrm1_1)
        Me.grpHpvSfSexualActType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHpvSfSexualActType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHpvSfSexualActType.Location = New System.Drawing.Point(301, 99)
        Me.grpHpvSfSexualActType.Name = "grpHpvSfSexualActType"
        Me.grpHpvSfSexualActType.Size = New System.Drawing.Size(116, 33)
        Me.grpHpvSfSexualActType.TabIndex = 158
        Me.grpHpvSfSexualActType.TabStop = False
        '
        'chkScrFrm1_2
        '
        Me.chkScrFrm1_2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkScrFrm1_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkScrFrm1_2.Location = New System.Drawing.Point(66, 10)
        Me.chkScrFrm1_2.Name = "chkScrFrm1_2"
        Me.chkScrFrm1_2.Size = New System.Drawing.Size(42, 19)
        Me.chkScrFrm1_2.TabIndex = 1
        Me.chkScrFrm1_2.Text = "Anal"
        '
        'chkScrFrm1_1
        '
        Me.chkScrFrm1_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkScrFrm1_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkScrFrm1_1.Location = New System.Drawing.Point(6, 10)
        Me.chkScrFrm1_1.Name = "chkScrFrm1_1"
        Me.chkScrFrm1_1.Size = New System.Drawing.Size(55, 19)
        Me.chkScrFrm1_1.TabIndex = 0
        Me.chkScrFrm1_1.Text = "Vaginal"
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.SystemColors.Control
        Me.Label78.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label78.Location = New System.Drawing.Point(6, 406)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(401, 15)
        Me.Label78.TabIndex = 180
        Me.Label78.Text = "10. Do you have any plans to move or leave the NYC area in the next 2 years?"
        '
        'grpHpvSfPlanToLeaveNYC
        '
        Me.grpHpvSfPlanToLeaveNYC.Controls.Add(Me.rbScrFrmNo8)
        Me.grpHpvSfPlanToLeaveNYC.Controls.Add(Me.rbScrFrmYes8)
        Me.grpHpvSfPlanToLeaveNYC.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpHpvSfPlanToLeaveNYC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHpvSfPlanToLeaveNYC.Location = New System.Drawing.Point(410, 394)
        Me.grpHpvSfPlanToLeaveNYC.Name = "grpHpvSfPlanToLeaveNYC"
        Me.grpHpvSfPlanToLeaveNYC.Size = New System.Drawing.Size(94, 33)
        Me.grpHpvSfPlanToLeaveNYC.TabIndex = 165
        Me.grpHpvSfPlanToLeaveNYC.TabStop = False
        '
        'rbScrFrmNo8
        '
        Me.rbScrFrmNo8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo8.Location = New System.Drawing.Point(54, 8)
        Me.rbScrFrmNo8.Name = "rbScrFrmNo8"
        Me.rbScrFrmNo8.Size = New System.Drawing.Size(33, 21)
        Me.rbScrFrmNo8.TabIndex = 33
        Me.rbScrFrmNo8.Tag = "N"
        Me.rbScrFrmNo8.Text = "No"
        Me.rbScrFrmNo8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbScrFrmYes8
        '
        Me.rbScrFrmYes8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmYes8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmYes8.Location = New System.Drawing.Point(5, 8)
        Me.rbScrFrmYes8.Name = "rbScrFrmYes8"
        Me.rbScrFrmYes8.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes8.TabIndex = 32
        Me.rbScrFrmYes8.Tag = "Y"
        Me.rbScrFrmYes8.Text = "Yes"
        Me.rbScrFrmYes8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPreg3
        '
        Me.lblPreg3.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg3.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPreg3.Location = New System.Drawing.Point(6, 183)
        Me.lblPreg3.Name = "lblPreg3"
        Me.lblPreg3.Size = New System.Drawing.Size(295, 15)
        Me.lblPreg3.TabIndex = 179
        Me.lblPreg3.Text = "4. What was the outcome of the pregnancy? "
        '
        'tabPregnancies
        '
        Me.tabPregnancies.AutoScroll = True
        Me.tabPregnancies.Controls.Add(Me.GroupBox6)
        Me.tabPregnancies.Controls.Add(Me.GroupBox4)
        Me.tabPregnancies.Controls.Add(Me.GroupBox5)
        Me.tabPregnancies.Location = New System.Drawing.Point(4, 22)
        Me.tabPregnancies.Name = "tabPregnancies"
        Me.tabPregnancies.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPregnancies.Size = New System.Drawing.Size(892, 477)
        Me.tabPregnancies.TabIndex = 4
        Me.tabPregnancies.Text = "Pregnancies"
        Me.tabPregnancies.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.grdPregnancyOutcome)
        Me.GroupBox6.Controls.Add(Me.BindingNavigator2)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 260)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(596, 229)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Pregnancy Outcomes"
        '
        'grdPregnancyOutcome
        '
        Me.grdPregnancyOutcome.AllowUserToAddRows = False
        Me.grdPregnancyOutcome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPregnancyOutcome.AutoGenerateColumns = False
        Me.grdPregnancyOutcome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdPregnancyOutcome.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdPregnancyOutcome.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdPregnancyOutcome.ColumnHeadersHeight = 33
        Me.grdPregnancyOutcome.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.grdPregnancyOutcome.DataSource = Me.TbPregnancyOutcomeBindingSource
        Me.grdPregnancyOutcome.Location = New System.Drawing.Point(3, 48)
        Me.grdPregnancyOutcome.Name = "grdPregnancyOutcome"
        Me.grdPregnancyOutcome.RowHeadersVisible = False
        Me.grdPregnancyOutcome.Size = New System.Drawing.Size(587, 175)
        Me.grdPregnancyOutcome.TabIndex = 3
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PregOutcomeID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PregOutcomeID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PregnancyID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PregnancyID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PregOutcomeBaby"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Preg Outcome Baby"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PregOutcomeTypeCd"
        Me.DataGridViewTextBoxColumn11.DataSource = Me.DdvPregnancyOutcomeTypeBindingSource
        Me.DataGridViewTextBoxColumn11.DisplayMember = "OutcomeDesc"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Outcome Type"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn11.ValueMember = "PregOutcomeTypeCd"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PregOutcomeDate"
        DataGridViewCellStyle2.Format = "d"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn12.HeaderText = "Preg Outcome Date"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'TbPregnancyOutcomeBindingSource
        '
        Me.TbPregnancyOutcomeBindingSource.DataMember = "FK_tbPregnancy_tbPregnancyOutcome"
        Me.TbPregnancyOutcomeBindingSource.DataSource = Me.bsPregnancy
        '
        'bsPregnancy
        '
        Me.bsPregnancy.DataMember = "tbPregnancy"
        Me.bsPregnancy.DataSource = Me.RiSdataDataSet
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.btnAddPregOutcome
        Me.BindingNavigator2.BindingSource = Me.TbPregnancyOutcomeBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator2.DeleteItem = Me.btnDeletePregOutcome
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.btnAddPregOutcome, Me.btnDeletePregOutcome, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 17)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator2.Size = New System.Drawing.Size(590, 25)
        Me.BindingNavigator2.TabIndex = 4
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'btnAddPregOutcome
        '
        Me.btnAddPregOutcome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddPregOutcome.Image = CType(resources.GetObject("btnAddPregOutcome.Image"), System.Drawing.Image)
        Me.btnAddPregOutcome.Name = "btnAddPregOutcome"
        Me.btnAddPregOutcome.RightToLeftAutoMirrorImage = True
        Me.btnAddPregOutcome.Size = New System.Drawing.Size(23, 22)
        Me.btnAddPregOutcome.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'btnDeletePregOutcome
        '
        Me.btnDeletePregOutcome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeletePregOutcome.Image = CType(resources.GetObject("btnDeletePregOutcome.Image"), System.Drawing.Image)
        Me.btnDeletePregOutcome.Name = "btnDeletePregOutcome"
        Me.btnDeletePregOutcome.RightToLeftAutoMirrorImage = True
        Me.btnDeletePregOutcome.Size = New System.Drawing.Size(23, 22)
        Me.btnDeletePregOutcome.Text = "Delete"
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
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "&Save"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox4.Controls.Add(Me.grdPregnancies)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(599, 250)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pregnancies"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.btnAddPregnancy
        Me.BindingNavigator1.BindingSource = Me.bsPregnancy
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.btnDeletePregnancy
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnAddPregnancy, Me.btnDeletePregnancy, Me.ToolStripSeparator1, Me.btnSavePregnancy})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 17)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(593, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'btnAddPregnancy
        '
        Me.btnAddPregnancy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddPregnancy.Image = CType(resources.GetObject("btnAddPregnancy.Image"), System.Drawing.Image)
        Me.btnAddPregnancy.Name = "btnAddPregnancy"
        Me.btnAddPregnancy.RightToLeftAutoMirrorImage = True
        Me.btnAddPregnancy.Size = New System.Drawing.Size(23, 22)
        Me.btnAddPregnancy.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'btnDeletePregnancy
        '
        Me.btnDeletePregnancy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeletePregnancy.Image = CType(resources.GetObject("btnDeletePregnancy.Image"), System.Drawing.Image)
        Me.btnDeletePregnancy.Name = "btnDeletePregnancy"
        Me.btnDeletePregnancy.RightToLeftAutoMirrorImage = True
        Me.btnDeletePregnancy.Size = New System.Drawing.Size(23, 22)
        Me.btnDeletePregnancy.Text = "Delete"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSavePregnancy
        '
        Me.btnSavePregnancy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSavePregnancy.Image = CType(resources.GetObject("btnSavePregnancy.Image"), System.Drawing.Image)
        Me.btnSavePregnancy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSavePregnancy.Name = "btnSavePregnancy"
        Me.btnSavePregnancy.Size = New System.Drawing.Size(23, 22)
        Me.btnSavePregnancy.Text = "&Save"
        '
        'grdPregnancies
        '
        Me.grdPregnancies.AllowUserToAddRows = False
        Me.grdPregnancies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPregnancies.AutoGenerateColumns = False
        Me.grdPregnancies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdPregnancies.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdPregnancies.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdPregnancies.ColumnHeadersHeight = 33
        Me.grdPregnancies.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.colDateMenstrual, Me.colUrineTest, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.colQuestCompDate})
        Me.grdPregnancies.DataSource = Me.bsPregnancy
        Me.grdPregnancies.Location = New System.Drawing.Point(3, 42)
        Me.grdPregnancies.Name = "grdPregnancies"
        Me.grdPregnancies.RowHeadersVisible = False
        Me.grdPregnancies.Size = New System.Drawing.Size(590, 202)
        Me.grdPregnancies.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PregnancyID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PregnancyID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'colDateMenstrual
        '
        Me.colDateMenstrual.DataPropertyName = "DateLastMenstrual"
        DataGridViewCellStyle4.Format = "d"
        Me.colDateMenstrual.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDateMenstrual.FillWeight = 41.94922!
        Me.colDateMenstrual.HeaderText = "Date Last Menstrual"
        Me.colDateMenstrual.Name = "colDateMenstrual"
        '
        'colUrineTest
        '
        Me.colUrineTest.DataPropertyName = "DateUrineTest"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.colUrineTest.DefaultCellStyle = DataGridViewCellStyle5
        Me.colUrineTest.FillWeight = 42.51269!
        Me.colUrineTest.HeaderText = "Date Urine Test"
        Me.colUrineTest.Name = "colUrineTest"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ResultUrineTest"
        Me.DataGridViewTextBoxColumn5.FillWeight = 42.51269!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Result Urine Test"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "QuestionnaireCompletedBy"
        Me.DataGridViewTextBoxColumn6.FillWeight = 42.51269!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Questionnaire Completed By"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'colQuestCompDate
        '
        Me.colQuestCompDate.DataPropertyName = "QuestionnaireCompletedDate"
        DataGridViewCellStyle6.Format = "d"
        Me.colQuestCompDate.DefaultCellStyle = DataGridViewCellStyle6
        Me.colQuestCompDate.FillWeight = 42.51269!
        Me.colQuestCompDate.HeaderText = "Questionnaire Completed Date"
        Me.colQuestCompDate.Name = "colQuestCompDate"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox5.Location = New System.Drawing.Point(608, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(180, 483)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Immunizations"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.69427!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.30573!))
        Me.TableLayoutPanel1.Controls.Add(NotesLabel1, 0, 20)
        Me.TableLayoutPanel1.Controls.Add(Me.NotesLabel2, 1, 20)
        Me.TableLayoutPanel1.Controls.Add(Dose5PODLabel, 0, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose5PODLabel1, 1, 19)
        Me.TableLayoutPanel1.Controls.Add(Dose5DoneInAHCLabel, 0, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose5DoneInAHCLabel1, 1, 18)
        Me.TableLayoutPanel1.Controls.Add(Dose5CompletedLabel, 0, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose5CompletedLabel1, 1, 17)
        Me.TableLayoutPanel1.Controls.Add(Dose5DateLabel, 0, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose5DateLabel1, 1, 16)
        Me.TableLayoutPanel1.Controls.Add(Dose4PODLabel, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose4PODLabel1, 1, 15)
        Me.TableLayoutPanel1.Controls.Add(Dose4DoneInAHCLabel, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose4DoneInAHCLabel1, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Dose4CompletedLabel, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Dose1DateLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose4CompletedLabel1, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose1DateLabel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Dose4DateLabel, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Dose1CompletedLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose4DateLabel1, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose1CompletedLabel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Dose3PODLabel, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Dose1DoneInAHCLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose3DoneInAHCLabel1, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose1DoneInAHCLabel1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Dose3DoneInAHCLabel, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Dose1PODLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose1PODLabel1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose3CompletedLabel1, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Dose3CompletedLabel, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Dose2DateLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose2DateLabel1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose3DateLabel1, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Dose3DateLabel, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Dose2CompletedLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose2CompletedLabel1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose2PODLabel1, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Dose2PODLabel, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Dose2DoneInAHCLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose2DoneInAHCLabel1, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Dose3PODLabel1, 1, 11)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 21
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(174, 463)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'NotesLabel2
        '
        Me.NotesLabel2.AutoSize = True
        Me.NotesLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Notes", True))
        Me.NotesLabel2.Location = New System.Drawing.Point(113, 300)
        Me.NotesLabel2.Name = "NotesLabel2"
        Me.NotesLabel2.Size = New System.Drawing.Size(0, 13)
        Me.NotesLabel2.TabIndex = 41
        '
        'TbImmunizationsBindingSource
        '
        Me.TbImmunizationsBindingSource.DataMember = "tbImmunizations"
        Me.TbImmunizationsBindingSource.DataSource = Me.RiSdataDataSet
        '
        'Dose5PODLabel1
        '
        Me.Dose5PODLabel1.AutoSize = True
        Me.Dose5PODLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose5POD", True))
        Me.Dose5PODLabel1.Location = New System.Drawing.Point(113, 285)
        Me.Dose5PODLabel1.Name = "Dose5PODLabel1"
        Me.Dose5PODLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose5PODLabel1.TabIndex = 39
        '
        'Dose5DoneInAHCLabel1
        '
        Me.Dose5DoneInAHCLabel1.AutoSize = True
        Me.Dose5DoneInAHCLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose5DoneInAHC", True))
        Me.Dose5DoneInAHCLabel1.Location = New System.Drawing.Point(113, 270)
        Me.Dose5DoneInAHCLabel1.Name = "Dose5DoneInAHCLabel1"
        Me.Dose5DoneInAHCLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose5DoneInAHCLabel1.TabIndex = 37
        '
        'Dose5CompletedLabel1
        '
        Me.Dose5CompletedLabel1.AutoSize = True
        Me.Dose5CompletedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose5Completed", True))
        Me.Dose5CompletedLabel1.Location = New System.Drawing.Point(113, 255)
        Me.Dose5CompletedLabel1.Name = "Dose5CompletedLabel1"
        Me.Dose5CompletedLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose5CompletedLabel1.TabIndex = 35
        '
        'Dose5DateLabel1
        '
        Me.Dose5DateLabel1.AutoSize = True
        Me.Dose5DateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose5Date", True))
        Me.Dose5DateLabel1.Location = New System.Drawing.Point(113, 240)
        Me.Dose5DateLabel1.Name = "Dose5DateLabel1"
        Me.Dose5DateLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose5DateLabel1.TabIndex = 33
        '
        'Dose4PODLabel1
        '
        Me.Dose4PODLabel1.AutoSize = True
        Me.Dose4PODLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose4POD", True))
        Me.Dose4PODLabel1.Location = New System.Drawing.Point(113, 225)
        Me.Dose4PODLabel1.Name = "Dose4PODLabel1"
        Me.Dose4PODLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose4PODLabel1.TabIndex = 31
        '
        'Dose4DoneInAHCLabel1
        '
        Me.Dose4DoneInAHCLabel1.AutoSize = True
        Me.Dose4DoneInAHCLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose4DoneInAHC", True))
        Me.Dose4DoneInAHCLabel1.Location = New System.Drawing.Point(113, 210)
        Me.Dose4DoneInAHCLabel1.Name = "Dose4DoneInAHCLabel1"
        Me.Dose4DoneInAHCLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose4DoneInAHCLabel1.TabIndex = 29
        '
        'Dose4CompletedLabel1
        '
        Me.Dose4CompletedLabel1.AutoSize = True
        Me.Dose4CompletedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose4Completed", True))
        Me.Dose4CompletedLabel1.Location = New System.Drawing.Point(113, 195)
        Me.Dose4CompletedLabel1.Name = "Dose4CompletedLabel1"
        Me.Dose4CompletedLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose4CompletedLabel1.TabIndex = 27
        '
        'Dose1DateLabel1
        '
        Me.Dose1DateLabel1.AutoSize = True
        Me.Dose1DateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose1Date", True))
        Me.Dose1DateLabel1.Location = New System.Drawing.Point(113, 0)
        Me.Dose1DateLabel1.Name = "Dose1DateLabel1"
        Me.Dose1DateLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose1DateLabel1.TabIndex = 1
        '
        'Dose4DateLabel1
        '
        Me.Dose4DateLabel1.AutoSize = True
        Me.Dose4DateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose4Date", True))
        Me.Dose4DateLabel1.Location = New System.Drawing.Point(113, 180)
        Me.Dose4DateLabel1.Name = "Dose4DateLabel1"
        Me.Dose4DateLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose4DateLabel1.TabIndex = 25
        '
        'Dose1CompletedLabel1
        '
        Me.Dose1CompletedLabel1.AutoSize = True
        Me.Dose1CompletedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose1Completed", True))
        Me.Dose1CompletedLabel1.Location = New System.Drawing.Point(113, 15)
        Me.Dose1CompletedLabel1.Name = "Dose1CompletedLabel1"
        Me.Dose1CompletedLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose1CompletedLabel1.TabIndex = 3
        '
        'Dose3DoneInAHCLabel1
        '
        Me.Dose3DoneInAHCLabel1.AutoSize = True
        Me.Dose3DoneInAHCLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose3DoneInAHC", True))
        Me.Dose3DoneInAHCLabel1.Location = New System.Drawing.Point(113, 150)
        Me.Dose3DoneInAHCLabel1.Name = "Dose3DoneInAHCLabel1"
        Me.Dose3DoneInAHCLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose3DoneInAHCLabel1.TabIndex = 21
        '
        'Dose1DoneInAHCLabel1
        '
        Me.Dose1DoneInAHCLabel1.AutoSize = True
        Me.Dose1DoneInAHCLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose1DoneInAHC", True))
        Me.Dose1DoneInAHCLabel1.Location = New System.Drawing.Point(113, 30)
        Me.Dose1DoneInAHCLabel1.Name = "Dose1DoneInAHCLabel1"
        Me.Dose1DoneInAHCLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose1DoneInAHCLabel1.TabIndex = 5
        '
        'Dose1PODLabel1
        '
        Me.Dose1PODLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose1POD", True))
        Me.Dose1PODLabel1.Location = New System.Drawing.Point(113, 45)
        Me.Dose1PODLabel1.Name = "Dose1PODLabel1"
        Me.Dose1PODLabel1.Size = New System.Drawing.Size(57, 15)
        Me.Dose1PODLabel1.TabIndex = 7
        '
        'Dose3CompletedLabel1
        '
        Me.Dose3CompletedLabel1.AutoSize = True
        Me.Dose3CompletedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose3Completed", True))
        Me.Dose3CompletedLabel1.Location = New System.Drawing.Point(113, 135)
        Me.Dose3CompletedLabel1.Name = "Dose3CompletedLabel1"
        Me.Dose3CompletedLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose3CompletedLabel1.TabIndex = 19
        '
        'Dose2DateLabel1
        '
        Me.Dose2DateLabel1.AutoSize = True
        Me.Dose2DateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose2Date", True))
        Me.Dose2DateLabel1.Location = New System.Drawing.Point(113, 60)
        Me.Dose2DateLabel1.Name = "Dose2DateLabel1"
        Me.Dose2DateLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose2DateLabel1.TabIndex = 9
        '
        'Dose3DateLabel1
        '
        Me.Dose3DateLabel1.AutoSize = True
        Me.Dose3DateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose3Date", True))
        Me.Dose3DateLabel1.Location = New System.Drawing.Point(113, 120)
        Me.Dose3DateLabel1.Name = "Dose3DateLabel1"
        Me.Dose3DateLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose3DateLabel1.TabIndex = 17
        '
        'Dose2CompletedLabel1
        '
        Me.Dose2CompletedLabel1.AutoSize = True
        Me.Dose2CompletedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose2Completed", True))
        Me.Dose2CompletedLabel1.Location = New System.Drawing.Point(113, 75)
        Me.Dose2CompletedLabel1.Name = "Dose2CompletedLabel1"
        Me.Dose2CompletedLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose2CompletedLabel1.TabIndex = 11
        '
        'Dose2PODLabel1
        '
        Me.Dose2PODLabel1.AutoSize = True
        Me.Dose2PODLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose2POD", True))
        Me.Dose2PODLabel1.Location = New System.Drawing.Point(113, 105)
        Me.Dose2PODLabel1.Name = "Dose2PODLabel1"
        Me.Dose2PODLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose2PODLabel1.TabIndex = 15
        '
        'Dose2DoneInAHCLabel1
        '
        Me.Dose2DoneInAHCLabel1.AutoSize = True
        Me.Dose2DoneInAHCLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose2DoneInAHC", True))
        Me.Dose2DoneInAHCLabel1.Location = New System.Drawing.Point(113, 90)
        Me.Dose2DoneInAHCLabel1.Name = "Dose2DoneInAHCLabel1"
        Me.Dose2DoneInAHCLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose2DoneInAHCLabel1.TabIndex = 13
        '
        'Dose3PODLabel1
        '
        Me.Dose3PODLabel1.AutoSize = True
        Me.Dose3PODLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbImmunizationsBindingSource, "Dose3POD", True))
        Me.Dose3PODLabel1.Location = New System.Drawing.Point(113, 165)
        Me.Dose3PODLabel1.Name = "Dose3PODLabel1"
        Me.Dose3PODLabel1.Size = New System.Drawing.Size(0, 13)
        Me.Dose3PODLabel1.TabIndex = 23
        '
        'lblNoHpvEpisodes
        '
        Me.lblNoHpvEpisodes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoHpvEpisodes.BackColor = System.Drawing.SystemColors.Control
        Me.lblNoHpvEpisodes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoHpvEpisodes.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoHpvEpisodes.Location = New System.Drawing.Point(6, 37)
        Me.lblNoHpvEpisodes.Name = "lblNoHpvEpisodes"
        Me.lblNoHpvEpisodes.Size = New System.Drawing.Size(892, 113)
        Me.lblNoHpvEpisodes.TabIndex = 97
        Me.lblNoHpvEpisodes.Text = "No HPV episodes have been added to the selected patient.  Click the 'Add' button " &
    "to add a new episode."
        Me.lblNoHpvEpisodes.Visible = False
        '
        'lblNoPatients
        '
        Me.lblNoPatients.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoPatients.BackColor = System.Drawing.Color.Transparent
        Me.lblNoPatients.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPatients.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoPatients.Location = New System.Drawing.Point(11, 22)
        Me.lblNoPatients.Name = "lblNoPatients"
        Me.lblNoPatients.Size = New System.Drawing.Size(1350, 179)
        Me.lblNoPatients.TabIndex = 98
        Me.lblNoPatients.Text = "There are no patients for the selected group of patients.  Click the 'Add' button" &
    "  to add a new patient."
        Me.lblNoPatients.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Choice"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Contact method"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Choice"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Contact method"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cd"
        Me.ColumnHeader5.Width = 0
        '
        'da1
        '
        Me.da1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.da1.InsertCommand = Me.OleDbInsertCommand1
        Me.da1.SelectCommand = Me.da1SelectComm
        Me.da1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbStuHpvScreeningForm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CurrentlyPregnant", "CurrentlyPregnant"), New System.Data.Common.DataColumnMapping("DateScreened", "DateScreened"), New System.Data.Common.DataColumnMapping("EpisodeID", "EpisodeID"), New System.Data.Common.DataColumnMapping("HasPeriod", "HasPeriod"), New System.Data.Common.DataColumnMapping("HpvScrnFrmID", "HpvScrnFrmID"), New System.Data.Common.DataColumnMapping("HPVvaccinated", "HPVvaccinated"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("SexualActType", "SexualActType"), New System.Data.Common.DataColumnMapping("SexuallyActive", "SexuallyActive"), New System.Data.Common.DataColumnMapping("ThoughtPregnant", "ThoughtPregnant"), New System.Data.Common.DataColumnMapping("WantHPVvaccine", "WantHPVvaccine"), New System.Data.Common.DataColumnMapping("EndPregnancy", "EndPregnancy"), New System.Data.Common.DataColumnMapping("EndPregnancyDate", "EndPregnancyDate"), New System.Data.Common.DataColumnMapping("PlanToLeaveNYC", "PlanToLeaveNYC")})})
        Me.da1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_HpvScrnFrmID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HpvScrnFrmID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CurrentlyPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentlyPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CurrentlyPregnant1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentlyPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateScreened", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateScreened", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateScreened1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateScreened", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancy", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancy", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancy1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancy", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancyDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancyDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancyDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancyDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EpisodeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HPVvaccinated", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HPVvaccinated", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HPVvaccinated1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HPVvaccinated", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HasPeriod", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HasPeriod", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HasPeriod1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HasPeriod", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PlanToLeaveNYC", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlanToLeaveNYC", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PlanToLeaveNYC1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlanToLeaveNYC", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexualActType", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexualActType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexualActType1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexualActType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexuallyActive", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexuallyActive", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexuallyActive1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexuallyActive", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ThoughtPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ThoughtPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ThoughtPregnant1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ThoughtPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_WantHPVvaccine", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WantHPVvaccine", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_WantHPVvaccine1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WantHPVvaccine", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CurrentlyPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, "CurrentlyPregnant"), New System.Data.OleDb.OleDbParameter("DateScreened", System.Data.OleDb.OleDbType.DBDate, 0, "DateScreened"), New System.Data.OleDb.OleDbParameter("EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeID"), New System.Data.OleDb.OleDbParameter("HasPeriod", System.Data.OleDb.OleDbType.VarWChar, 1, "HasPeriod"), New System.Data.OleDb.OleDbParameter("HPVvaccinated", System.Data.OleDb.OleDbType.VarWChar, 1, "HPVvaccinated"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("SexualActType", System.Data.OleDb.OleDbType.VarWChar, 2, "SexualActType"), New System.Data.OleDb.OleDbParameter("SexuallyActive", System.Data.OleDb.OleDbType.VarWChar, 1, "SexuallyActive"), New System.Data.OleDb.OleDbParameter("ThoughtPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, "ThoughtPregnant"), New System.Data.OleDb.OleDbParameter("WantHPVvaccine", System.Data.OleDb.OleDbType.VarWChar, 1, "WantHPVvaccine"), New System.Data.OleDb.OleDbParameter("EndPregnancy", System.Data.OleDb.OleDbType.VarWChar, 1, "EndPregnancy"), New System.Data.OleDb.OleDbParameter("EndPregnancyDate", System.Data.OleDb.OleDbType.DBDate, 0, "EndPregnancyDate"), New System.Data.OleDb.OleDbParameter("PlanToLeaveNYC", System.Data.OleDb.OleDbType.VarWChar, 1, "PlanToLeaveNYC")})
        '
        'da1SelectComm
        '
        Me.da1SelectComm.CommandText = resources.GetString("da1SelectComm.CommandText")
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CurrentlyPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, "CurrentlyPregnant"), New System.Data.OleDb.OleDbParameter("DateScreened", System.Data.OleDb.OleDbType.DBDate, 0, "DateScreened"), New System.Data.OleDb.OleDbParameter("EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeID"), New System.Data.OleDb.OleDbParameter("HasPeriod", System.Data.OleDb.OleDbType.VarWChar, 1, "HasPeriod"), New System.Data.OleDb.OleDbParameter("HPVvaccinated", System.Data.OleDb.OleDbType.VarWChar, 1, "HPVvaccinated"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("SexualActType", System.Data.OleDb.OleDbType.VarWChar, 2, "SexualActType"), New System.Data.OleDb.OleDbParameter("SexuallyActive", System.Data.OleDb.OleDbType.VarWChar, 1, "SexuallyActive"), New System.Data.OleDb.OleDbParameter("ThoughtPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, "ThoughtPregnant"), New System.Data.OleDb.OleDbParameter("WantHPVvaccine", System.Data.OleDb.OleDbType.VarWChar, 1, "WantHPVvaccine"), New System.Data.OleDb.OleDbParameter("EndPregnancy", System.Data.OleDb.OleDbType.VarWChar, 1, "EndPregnancy"), New System.Data.OleDb.OleDbParameter("EndPregnancyDate", System.Data.OleDb.OleDbType.DBDate, 0, "EndPregnancyDate"), New System.Data.OleDb.OleDbParameter("PlanToLeaveNYC", System.Data.OleDb.OleDbType.VarWChar, 1, "PlanToLeaveNYC"), New System.Data.OleDb.OleDbParameter("Original_HpvScrnFrmID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HpvScrnFrmID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CurrentlyPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentlyPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CurrentlyPregnant1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentlyPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateScreened", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateScreened", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateScreened1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateScreened", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancy", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancy", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancy1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancy", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancyDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancyDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancyDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancyDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EpisodeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HPVvaccinated", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HPVvaccinated", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HPVvaccinated1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HPVvaccinated", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HasPeriod", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HasPeriod", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HasPeriod1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HasPeriod", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PlanToLeaveNYC", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlanToLeaveNYC", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PlanToLeaveNYC1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlanToLeaveNYC", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexualActType", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexualActType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexualActType1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexualActType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexuallyActive", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexuallyActive", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexuallyActive1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexuallyActive", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ThoughtPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ThoughtPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ThoughtPregnant1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ThoughtPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_WantHPVvaccine", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WantHPVvaccine", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_WantHPVvaccine1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WantHPVvaccine", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString")
        '
        'ds
        '
        Me.ds.DataSetName = "DataSet1"
        Me.ds.Locale = New System.Globalization.CultureInfo("en-US")
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DdvYesNoTableAdapter
        '
        Me.DdvYesNoTableAdapter.ClearBeforeFill = True
        '
        'DdvResearcherTableAdapter
        '
        Me.DdvResearcherTableAdapter.ClearBeforeFill = True
        '
        'DdvPhysicianTableAdapter
        '
        Me.DdvPhysicianTableAdapter.ClearBeforeFill = True
        '
        'DdvAdEventSeverityTableAdapter
        '
        Me.DdvAdEventSeverityTableAdapter.ClearBeforeFill = True
        '
        'DdvAdEventRelProtocolTableAdapter
        '
        Me.DdvAdEventRelProtocolTableAdapter.ClearBeforeFill = True
        '
        'DdvAdEventRecoveryTableAdapter
        '
        Me.DdvAdEventRecoveryTableAdapter.ClearBeforeFill = True
        '
        'taPregnancy
        '
        Me.taPregnancy.ClearBeforeFill = True
        '
        'TbImmunizationsTableAdapter
        '
        Me.TbImmunizationsTableAdapter.ClearBeforeFill = True
        '
        'TbPregnancyOutcomeTableAdapter
        '
        Me.TbPregnancyOutcomeTableAdapter.ClearBeforeFill = True
        '
        'DdvPregnancyOutcomeTypeTableAdapter
        '
        Me.DdvPregnancyOutcomeTypeTableAdapter.ClearBeforeFill = True
        '
        'TbStuHpvEpisodeBindingSource
        '
        Me.TbStuHpvEpisodeBindingSource.DataMember = "tbStuHpvEpisode"
        Me.TbStuHpvEpisodeBindingSource.DataSource = Me.ds
        '
        'TbStuHpvEpisodeTableAdapter
        '
        Me.TbStuHpvEpisodeTableAdapter.ClearBeforeFill = True
        '
        'frmPatient
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1549, 676)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.splitVer1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 100)
        Me.Name = "frmPatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patients"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panAddEdit.ResumeLayout(False)
        Me.grpSearchBy.ResumeLayout(False)
        Me.panHPVvstDates.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1P1.ResumeLayout(False)
        Me.Tab1P1.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Tab1P2.ResumeLayout(False)
        Me.Tab1P2.PerformLayout()
        Me.tabCts.ResumeLayout(False)
        Me.tabCtsP1.ResumeLayout(False)
        Me.tabCtsP1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tabCtsP2.ResumeLayout(False)
        Me.tabCtsP2.PerformLayout()
        Me.tabCtsP3.ResumeLayout(False)
        Me.tabCtsP3.PerformLayout()
        Me.grpCiContactName.ResumeLayout(False)
        Me.grpCiContactName.PerformLayout()
        Me.grpCiAddress.ResumeLayout(False)
        Me.grpCiAddress.PerformLayout()
        Me.Tab1P3.ResumeLayout(False)
        Me.tabHpv.ResumeLayout(False)
        Me.tabHpvP1.ResumeLayout(False)
        Me.grpProgressInfo.ResumeLayout(False)
        Me.tabHpvVst.ResumeLayout(False)
        Me.tabHpvVstP1.ResumeLayout(False)
        Me.tabHpvVstP2.ResumeLayout(False)
        Me.tabHpvVstP3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabHpvVstP4.ResumeLayout(False)
        Me.tabHpvVstP4.PerformLayout()
        Me.tabHpvVstAdveresEvent.ResumeLayout(False)
        Me.grpInterventions.ResumeLayout(False)
        CType(Me.grdInterventions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbStuHpvAdEventsInterventionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RiSdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSymptoms.ResumeLayout(False)
        CType(Me.grdSymptoms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbStuHpvAdEventsSymptomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAdverseEvent.ResumeLayout(False)
        Me.grpAdverseEvent.PerformLayout()
        CType(Me.TbStuHpvAdEventsLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvResearcherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvPhysicianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvYesNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvAdEventRelProtocolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvAdEventRecoveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvAdEventSeverityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHpvP2.ResumeLayout(False)
        Me.tabHpvP2.PerformLayout()
        Me.grpHpvSfEndPregnancy.ResumeLayout(False)
        Me.grpHpvSfEndPregnancy.PerformLayout()
        CType(Me.DdvPregnancyOutcomeTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHpvSfHPVvaccinated.ResumeLayout(False)
        Me.grpHpvSfHasPeriod.ResumeLayout(False)
        Me.grpHpvSfThoughtPregnant.ResumeLayout(False)
        Me.grpHpvSfCurrentlyPregnant.ResumeLayout(False)
        Me.grpHpvSfWantHPVvaccine.ResumeLayout(False)
        Me.grpHpvSfSexuallyActive.ResumeLayout(False)
        Me.grpHpvSfSexualActType.ResumeLayout(False)
        Me.grpHpvSfPlanToLeaveNYC.ResumeLayout(False)
        Me.tabPregnancies.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.grdPregnancyOutcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPregnancyOutcomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPregnancy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.grdPregnancies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TbImmunizationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbStuHpvEpisodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public PatID As Integer
    Public pHPVSTUDYCD As Int16
    Public pPatientGender As String
    '* SET WHEN THE USER CHOOSES A PATIENT
    Public Property HPVStudyCD() As Int16
        Get
            HPVSTUDYCD = pHPVSTUDYCD
        End Get
        Set(ByVal value As Int16)
            pHPVSTUDYCD = value
        End Set
    End Property

    '* SET WHEN THE USER CHOOSES A PATIENT
    Public Property PatientGender() As String
        Get
            PatientGender = pPatientGender
        End Get
        Set(ByVal value As String)
            pPatientGender = value
        End Set
    End Property

    Private Sub frmPatient_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub frmPatient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ds.tbStuHpvEpisode' table. You can move, or remove it, as needed.
        Me.TbStuHpvEpisodeTableAdapter.Connection.ConnectionString = strConn        

        Me.DdvPregnancyOutcomeTypeTableAdapter.Connection.ConnectionString = strConn
        Me.TbPregnancyOutcomeTableAdapter.Connection.ConnectionString = strConn
        Me.TbImmunizationsTableAdapter.Connection.ConnectionString = strConn
        Me.taPregnancy.Connection.ConnectionString = strConn
        Me.TbStuHpvAdEventsLogTableAdapter.Connection.ConnectionString = strConn
        Me.TbStuHpvAdEventsSymptomsTableAdapter.Connection.ConnectionString = strConn
        Me.TbStuHpvAdEventsInterventionsTableAdapter.Connection.ConnectionString = strConn
        Me.DdvYesNoTableAdapter.Connection.ConnectionString = strConn
        Me.DdvAdEventRecoveryTableAdapter.Connection.ConnectionString = strConn
        Me.DdvAdEventRelProtocolTableAdapter.Connection.ConnectionString = strConn
        Me.DdvAdEventSeverityTableAdapter.Connection.ConnectionString = strConn
        Me.DdvPhysicianTableAdapter.Connection.ConnectionString = strConn
        Me.DdvResearcherTableAdapter.Connection.ConnectionString = strConn

        Me.DdvPregnancyOutcomeTypeTableAdapter.FillAll(Me.RiSdataDataSet.ddvPregnancyOutcomeType)
        Me.DdvAdEventRecoveryTableAdapter.Fill(Me.RiSdataDataSet.ddvAdEventRecovery)
        Me.DdvAdEventRelProtocolTableAdapter.Fill(Me.RiSdataDataSet.ddvAdEventRelProtocol)
        Me.DdvAdEventSeverityTableAdapter.Fill(Me.RiSdataDataSet.ddvAdEventSeverity)
        Me.DdvPhysicianTableAdapter.Fill(Me.RiSdataDataSet.ddvPhysician)
        Me.DdvResearcherTableAdapter.Fill(Me.RiSdataDataSet.ddvResearcher)
        Me.DdvYesNoTableAdapter.Fill(Me.RiSdataDataSet.ddvYesNo)

        vfrmPatient = Me

        Fill_cboStudy(Me.cboStudy)
        Me.cboStudy.SelectedIndex = 0 ' Me.cboStudy.Text = "All Patients"
        'Fill_lvw0()

        Me.dtsHPVvstDate1.Value = Today.AddDays(7)
        Me.dtsHPVvstDate2.MinDate = Me.dtsHPVvstDate1.Value
        Me.dtsHPVvstDate2.Value = Me.dtsHPVvstDate1.Value

        splitVer1_SplitterMoved(Nothing, Nothing)
        Set_splitVer1MinSize()

        Me.rtbCtsSlf.BorderStyle = BorderStyle.None
        Me.rtbCtsFrd1.BorderStyle = BorderStyle.None
        Me.rtbCtsFrd2.BorderStyle = BorderStyle.None
        Me.rtbContactInfo.BorderStyle = BorderStyle.None

        AddTabsTo_tabContactInfo()

    End Sub

    Private Sub frmPatient_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub

    Private Sub frmPatient_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmPatient = Nothing
    End Sub

    Private Sub splitVer1_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles splitVer1.SplitterMoved
        Me.cboStudy.Width = Me.Panel1.Width - 29
        Me.tbRefreshLvw0.Left = Me.cboStudy.Width + 5

        Me.lvw0.Width = Me.Panel1.Width - 3
        Me.lvw0.Height = Me.Panel1.Height - 92
        'Me.Panel2.Height = Me.Height - 38
        Me.Tab1.Width = Panel2.Width - 2
        'Me.Tab1.Height = Me.Panel2.Height - 5
    End Sub

    Private Sub Set_splitVer1MinSize()
        splitVer1.MinExtra = Me.Width * 0.65
        splitVer1.MinSize = Me.Width * 0.015
    End Sub

    Private Sub frmPatient_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        splitVer1_SplitterMoved(Nothing, Nothing)
        Set_splitVer1MinSize()
    End Sub

    Private Sub btnAddPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPat.Click

        If vfrmPatientEdit Is Nothing Then
            vfrmPatientEdit = New frmPatientEdit
            With vfrmPatientEdit
                .Text = "Adding a new patient . . ."
                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub lvw0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvw0.Click

        lvw0XSelectedIndex = lvw0.SelectedItems(0).Index
        Update_Tab1()

    End Sub

    Private Sub lvw0_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvw0.KeyUp
        lvw0_Click(sender, e)
    End Sub

    Private Sub cboStudy_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboStudy.SelectedValueChanged

        If vb.Left(cboStudy.Text, 5) = "-----" Then
            cboStudy.Text = cboStudyOldValue
        End If

        If cboStudy.Text <> cboStudyOldValue Then

            Call Fill_lvw0()
            Me.lvw0.Focus()
            Update_Tab1()
            cboStudyOldValue = cboStudy.Text
        End If

        Me.panAddEdit.Visible = False
        Me.panHPVvstDates.Visible = False
        Me.rbFindPt3.Enabled = False
        Select Case UCase(cboStudy.SelectedItem.ToString)
            Case "ALL PATIENTS"
                Me.panAddEdit.Visible = True
            Case "HPV PATIENTS TO FOLLOW UP"
                Me.panHPVvstDates.Visible = True
                Me.rbFindPt3.Enabled = True
            Case "HPV (DOB)"
                Me.panHPVvstDates.Visible = True
                Me.rbFindPt3.Enabled = True
            Case Else

                Me.panAddEdit.Visible = True
                Me.rbFindPt3.Enabled = True
        End Select

    End Sub
    Private Sub SetHPVGenderSetup()
        Try
            Dim EpisodeTypeID As String
            If lvwHpvEpi.SelectedItems.Count > 0 Then
                EpisodeTypeID = lvwHpvEpi.SelectedItems(0).SubItems(lvwHpvEpi.Columns.Count - 2).Text
            Else
                EpisodeTypeID = "1"
            End If

            '* GET PATIENT GENDER                
            If Me.PatientGender = "F" Then
                lblPreg1.Enabled = True
                lblPreg2.Enabled = True
                lblPreg3.Enabled = True
                lblPreg4.Enabled = True
                lblPreg5.Enabled = True
                grpHpvSfCurrentlyPregnant.Visible = True
                grpHpvSfEndPregnancy.Visible = True
                grpHpvSfThoughtPregnant.Visible = True
                grpHpvSfHasPeriod.Visible = True
                tabHpv.TabPages(2).Enabled = True
                tabHpv.TabPages(2).Text = "Pregnancies"

                '* SCREENING FORM
                lblPreg1.Enabled = True
                lblPreg2.Enabled = True
                lblPreg3.Enabled = True
                lblPreg4.Enabled = True
                lblPreg5.Enabled = True
                lblPreg6.Enabled = True
                grpHpvSfCurrentlyPregnant.Enabled = True
                grpHpvSfEndPregnancy.Enabled = True
                grpHpvSfThoughtPregnant.Enabled = True
                grpHpvSfHasPeriod.Enabled = True

                If EpisodeTypeID = "2" Then
                    tabHpv.TabPages(1).Enabled = False
                    tabHpv.TabPages(1).Text = "-----"
                    tabHpv.TabPages(2).Enabled = False
                    tabHpv.TabPages(2).Text = "-----"
                    grpProgressInfo.Visible = False
                Else
                    tabHpv.TabPages(1).Enabled = True
                    tabHpv.TabPages(1).Text = "Screening Form"
                    tabHpv.TabPages(2).Enabled = True
                    tabHpv.TabPages(2).Text = "Pregnancies"
                    grpProgressInfo.Visible = True
                End If
            Else
                lblPreg1.Enabled = False
                lblPreg2.Enabled = False
                lblPreg3.Enabled = False
                lblPreg4.Enabled = False
                lblPreg5.Enabled = False
                grpHpvSfCurrentlyPregnant.Visible = False
                grpHpvSfEndPregnancy.Visible = False
                grpHpvSfThoughtPregnant.Visible = False
                grpHpvSfHasPeriod.Visible = False
                tabHpv.TabPages(2).Enabled = False
                tabHpv.TabPages(2).Text = "-----"

                '* SCREENING FORM
                lblPreg1.Enabled = False
                lblPreg2.Enabled = False
                lblPreg3.Enabled = False
                lblPreg4.Enabled = False
                lblPreg5.Enabled = False
                lblPreg6.Enabled = False
                grpHpvSfCurrentlyPregnant.Enabled = False
                grpHpvSfEndPregnancy.Enabled = False
                grpHpvSfThoughtPregnant.Enabled = False
                grpHpvSfHasPeriod.Enabled = False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Friend Sub Update_Tab1(Optional ByVal booUpdate_tabHpv As Boolean = True)

        If Me.lvw0.Items.Count = 0 Then Exit Sub

        'Me.Text = "Patient - " & Me.lvw0.SelectedItems(0).Text      
        Dim strSQL As String
        PatID = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text

        '* SET FORM BASES ON GENDER
        Me.PatientGender = GetPatientGender(PatID)
        Call SetHPVGenderSetup()
        If Me.PatientGender = "F" Then
            Me.HPVStudyCD = 1            
        Else
            Me.HPVStudyCD = 2
        End If        

        Select Case Tab1.SelectedIndex
            Case 0 'General Info               
                strSQL = "SELECT * FROM tbPatient " & _
                         "WHERE PatientID=" & PatID
                Dim conn As New OleDbConnection(strConn)
                Dim cmd As New OleDbCommand(strSQL, conn)
                'Console.WriteLine(strSQL)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                With reader
                    If .HasRows Then
                        Do While .Read()
                            Me.txtMRN.Text = IIf(Not IsDBNull(.Item("MRN")), .Item("MRN"), "")
                            Me.txtGender.Text = IIf(Not IsDBNull(.Item("Gender")), .Item("Gender"), "")
                            Me.txtDateOfBirth.Text = IIf(Not IsDBNull(.Item("DateOfBirth")), .Item("DateOfBirth"), "")
                            Me.txtNotes.Text = IIf(Not IsDBNull(.Item("Notes")), .Item("Notes"), "")
                            Me.txtRace.Text = IIf(Not IsDBNull(.Item("Race")), .Item("Race"), "")
                            FillCheckBoxGroup(Me, Me.txtRace.Text, "chkRace", 6)
                            Me.txtEthnicity.Text = IIf(Not IsDBNull(.Item("Ethnicity")), .Item("Ethnicity"), "")
                            FillRadioButtonGroup(Me, Me.txtEthnicity.Text, "rbEthnicity", 3)
                        Loop
                    Else
                        Me.txtMRN.Text = ""
                        Me.txtGender.Text = ""
                        Me.txtDateOfBirth.Text = ""
                        For i As Short = 1 To 6
                            CType(FindControl(Me, "chkRace" & i), CheckBox).Checked = False
                        Next
                    End If
                    .Close()
                End With
                conn.Close()

                'strSQL = "SELECT StudyDesc, SubjectID, Eligible, tbStudyPatient.StudyCd " & _
                '"FROM tbStudyPatient LEFT JOIN tbStudy ON tbStudyPatient.StudyCd = tbStudy.StudyCd " & _
                '"WHERE PatientID=" & PatID
                'Fill_lvw(Me.lvwStudy, strSQL)
            Case 1 'Contacts
                Update_tabCts()
            Case 2 'HPV
                'Update_chkHPV_Terminated()

                strSQL = "SELECT '' AS D, SubjectID, UCASE(Eligible),ddvStuHpvEpisodeType.EpisodeStuTypeNm,ddvStuHpvEpisodeStatus.EpisodeStatus " & _
                            ",FORMAT(EpisodeDate, 'MM/dd/yyyy'), ddvStuHpvSubjEntryType.SubjEntryTypeDesc, " & _
                            "VaccineDateKnown & ' ' & VaccineDateEst,Vaccine2DateKnown & ' ' & Vaccine2DateEst ,Vaccine3DateKnown & ' ' & Vaccine3DateEst, " & _
                            "Notes,ddvResearcher.LastName " & _
                            ",ddvStuHpvEpisodeType.EpisodeStuTypeID " & _
                            ",EpisodeID " & _
                         "FROM ((((tbStuHpvEpisode)" & _
                         "LEFT JOIN ddvStuHpvSubjEntryType ON ddvStuHpvSubjEntryType.SubjEntryTypeCd=tbStuHpvEpisode.SubjEntryTypeCd) " & _
                         "LEFT JOIN ddvResearcher ON ddvResearcher.ResearcherCd=tbStuHpvEpisode.ResearcherCd) " & _
                         "LEFT JOIN ddvStuHpvEpisodeType ON ddvStuHpvEpisodeType.EpisodeStuTypeID=tbStuHpvEpisode.EpisodeType) " & _
                         "LEFT JOIN ddvStuHpvEpisodeStatus ON ddvStuHpvEpisodeStatus.EpisodeStatusID=tbStuHpvEpisode.EpisodeStatus " & _
                         "WHERE PatientID=" & PatID & _
                        " ORDER BY ddvStuHpvEpisodeType.EpisodeStuTypeID desc,EpisodeDate " '" ORDER BY Eligible DESC"
                Fill_lvw(Me.lvwHpvEpi, strSQL, , False)
                'MsgBox(Me.lvwHpvEpi.Items.Count)
                ShowLvwEditButtons(Me.lvwHpvEpi, btnEditHpvEpi, btnDelHpvEpi)
                If Me.lvwHpvEpi.Items.Count > 0 Then
                    AddSeqNumToLvw(Me.lvwHpvEpi)

                    Me.lvwHpvEpi.Visible = True
                    Me.tabHpv.Visible = True
                    Me.lblNoHpvEpisodes.Visible = False

                    If booUpdate_tabHpv Then
                        If UCase(cboStudy.SelectedItem.ToString) <> "HPV PATIENTS TO FOLLOW UP" Then
                            Update_tabHpv()
                            Me.lblHpvEpiFU.Visible = False
                            Me.lvwHpvEpiFU.Visible = False
                        Else
                            Fill_lvwHpvEpiFU()
                            Me.lblHpvEpiFU.Visible = True
                            Me.lvwHpvEpiFU.Visible = True
                            SelectLvwItem(lvwHpvEpi, Me.lvwHpvEpiFU.Items(0).Text, lvwHpvEpi.Columns.Count - 1)
                            Update_tabHpv()
                        End If
                    End If
                Else
                    Me.lvwHpvEpi.Visible = False
                    Me.tabHpv.Visible = False
                    Me.lblNoHpvEpisodes.Visible = True
                End If

                Me.BindPregnancyTab()
        End Select

    End Sub
    Private Function GetPatientGender(ByVal PatID As String) As String
        GetPatientGender = ""
        Try
            Dim strSQL As String = "SELECT Gender FROM tbPatient " & _
                                     "WHERE PatientID=" & PatID
            Dim conn As New OleDbConnection(strConn)
            Dim cmd As New OleDbCommand(strSQL, conn)
            'Console.WriteLine(strSQL)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    .Read()
                    GetPatientGender = IIf(Not IsDBNull(.Item("Gender")), .Item("Gender"), "F")
                End If
                .Close()
            End With
            conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub BindPregnancyTab()
        'Bind Pregnancy Sub Tab
        Me.RiSdataDataSet.EnforceConstraints = True
        Me.TbPregnancyOutcomeTableAdapter.FillByPatientID(Me.RiSdataDataSet.tbPregnancyOutcome, PatID)
        Me.taPregnancy.FillByPatientID(Me.RiSdataDataSet.tbPregnancy, PatID)
        Me.TbImmunizationsTableAdapter.FillByPatientID(Me.RiSdataDataSet.tbImmunizations, PatID)
        Me.RiSdataDataSet.EnforceConstraints = True
    End Sub

    Private Sub Update_chkHPV_Terminated()

        'Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
        'Dim strSQL As String = "SELECT HPV_Terminated FROM tbPatient WHERE PatientID=" & PatID
        'Dim conn As New OleDbConnection(strConn)
        'Dim cmd As New OleDbCommand(strSQL, conn)
        'conn.Open()
        ''MsgBox(cmd.ExecuteScalar)
        'With Me.chkHPV_Terminated
        '    If cmd.ExecuteScalar = True Then
        '        .Checked = True
        '    Else
        '        .Checked = False
        '    End If
        'End With
        'conn.Close()
    End Sub

    Friend Sub AddSeqNumToLvw(ByVal lvw As ListView, Optional ByVal SubItem As Short = 0)

        If lvw.Items.Count > 0 Then
            For i As Short = 0 To lvw.Items.Count - 1
                If SubItem > 0 Then
                    lvw.Items(i).SubItems(SubItem).Text = i + 1
                Else
                    lvw.Items(i).Text = i + 1
                End If
            Next
        End If

    End Sub

    Friend Sub Update_tabCts()

        Update_tabContactInfo()
        Exit Sub

        Try
            'On Error Resume Next 'need this in case RichTextBoxes have invalid format value 

            Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
            Dim strSQL As String

            Dim strSQLContactChoice As String = _
               "SELECT ContactChoice, ContactMethodDesc, tbContactChoice.ContactMethodCd " & _
               "FROM tbContactChoice LEFT JOIN ddvContactMethod " & _
                 "ON tbContactChoice.ContactMethodCd = ddvContactMethod.ContactMethodCd " & _
               "WHERE PatientID=" & PatID

            Select Case tabCts.SelectedIndex

                Case 0 'Self
                    booCiCanMailReminder = False
                    Me.chkCtsSlfCanMailReminder.Checked = False
                    booCiCanTextMessage = False
                    Me.chkCtsSlfCanTextMessage.Checked = False
                    Me.txtCtsSlfAddress.Text = ""
                    Me.txtCtsSlfAptNum.Text = ""
                    Me.txtCtsSlfCity.Text = ""
                    Me.txtCtsSlfState.Text = ""
                    Me.txtCtsSlfZip.Text = ""
                    Me.txtHasContact.Text = ""
                    Me.txtHasAddress.Text = ""
                    Me.txtCtsSlfSpecialRequests.Text = ""

                    Dim conn As New OleDbConnection(strConn)
                    Dim reader As OleDbDataReader, cmd As OleDbCommand

                    strSQL = "SELECT * FROM tbContact " & _
                             "WHERE ContactOwnerCd=1 AND PatientID=" & PatID
                    conn.Open()
                    cmd = New OleDbCommand(strSQL, conn)
                    reader = cmd.ExecuteReader()
                    With reader
                        If .HasRows Then
                            Do While .Read()
                                'Me.txtCtsSlfCellPhone.Text = FormatString(HandleNull(.Item("PhoneNumber")), "###-###-####")
                                booCiCanMailReminder = .Item("CanMailReminder")
                                Me.chkCtsSlfCanMailReminder.Checked = .Item("CanMailReminder")
                                booCiCanTextMessage = .Item("CanTextMessage")
                                Me.chkCtsSlfCanTextMessage.Checked = .Item("CanTextMessage")
                                Me.txtCtsSlfSpecialRequests.Text = .Item("SpecialRequestsWhenContact").ToString
                                Me.txtHasContact.Text = "Y"
                            Loop
                            Me.btnEditCtsSlf.Text = "Edit"
                            btnDeleteCtsSlf.Enabled = True
                        Else
                            Me.btnEditCtsSlf.Text = "Add"
                            btnDeleteCtsSlf.Enabled = False
                        End If
                        .Close()
                    End With
                    'conn.Close()

                    strSQL = "SELECT * FROM tbContactAddress " & _
                             "WHERE ContactOwnerCd=1 AND PatientID=" & PatID
                    cmd = New OleDbCommand(strSQL, conn)
                    'Console.WriteLine(strSQL)
                    'conn.Open()
                    reader = cmd.ExecuteReader()
                    With reader
                        If .HasRows Then
                            Do While .Read()
                                Me.txtCtsSlfAddress.Text = .Item("Address1").ToString
                                Me.txtCtsSlfAptNum.Text = .Item("Address2").ToString
                                Me.txtCtsSlfCity.Text = .Item("City").ToString
                                Me.txtCtsSlfState.Text = .Item("State").ToString
                                Me.txtCtsSlfZip.Text = FormatString(HandleNull(.Item("Zip")), "#####-####")
                                Me.txtHasAddress.Text = "Y"
                            Loop
                            If Me.btnEditCtsSlf.Text = "Add" Then
                                Me.btnEditCtsSlf.Text = "Edit"
                                btnDeleteCtsSlf.Enabled = True
                            End If
                        Else
                            'Me.btnEditCtsSlf.Text = "Add"
                            'btnDeleteCtsSlf.Enabled = False
                        End If
                        .Close()
                    End With
                    conn.Close()

                    strSQLContactChoice = strSQLContactChoice & " AND tbContactChoice.ContactOwnerCd=1 ORDER BY ContactChoice"
                    'Console.WriteLine(strSQLContactChoice)
                    Fill_lvw(Me.lvwCtMthdSlf, strSQLContactChoice, , False)
                    Update_rtbCts(Me.rtbCtsSlf)

                Case 1 'Friend 1

                    Me.txtCtsFrd1LastName.Text = ""
                    Me.txtCtsFrd1FirstName.Text = ""
                    Me.txtCtsFrd1SpecialRequests.Text = ""

                    strSQL = "SELECT * FROM tbContact " & _
                             "WHERE ContactOwnerCd=2 AND PatientID=" & PatID
                    Dim conn As New OleDbConnection(strConn)
                    Dim cmd As New OleDbCommand(strSQL, conn)
                    'Console.WriteLine(strSQL)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    With reader
                        If .HasRows Then
                            Do While .Read()
                                Me.txtCtsFrd1LastName.Text = .Item("LastName").ToString
                                Me.txtCtsFrd1FirstName.Text = .Item("FirstName").ToString
                                Me.txtCtsFrd1SpecialRequests.Text = .Item("SpecialRequestsWhenContact").ToString
                                Me.txtWhoIs.Text = .Item("WhoIsThisPerson").ToString
                            Loop
                            Me.btnEditCtsFrd1.Text = "Edit"
                            Me.btnDeleteCtsFrd1.Enabled = True
                        Else
                            Me.btnEditCtsFrd1.Text = "Add"
                            Me.btnDeleteCtsFrd1.Enabled = False
                        End If
                        .Close()
                    End With
                    conn.Close()

                    strSQLContactChoice = strSQLContactChoice & " AND tbContactChoice.ContactOwnerCd=2 ORDER BY ContactChoice"
                    'Console.WriteLine(strSQLContactChoice)
                    Fill_lvw(Me.lvwCtMthdFrd1, strSQLContactChoice, , False)
                    Update_rtbCts(Me.rtbCtsFrd1)

                Case 2 'Friend 2

                    Me.txtCtsFrd2LastName.Text = ""
                    Me.txtCtsFrd2FirstName.Text = ""
                    Me.txtCtsFrd2SpecialRequests.Text = ""

                    strSQL = "SELECT * FROM tbContact " & _
                            "WHERE ContactOwnerCd=3 AND PatientID=" & PatID
                    Dim conn As New OleDbConnection(strConn)
                    Dim cmd As New OleDbCommand(strSQL, conn)
                    'Console.WriteLine(strSQL)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    With reader
                        If .HasRows Then
                            Do While .Read()
                                Me.txtCtsFrd2LastName.Text = .Item("LastName").ToString
                                Me.txtCtsFrd2FirstName.Text = .Item("FirstName").ToString
                                Me.txtCtsFrd2SpecialRequests.Text = .Item("SpecialRequestsWhenContact").ToString
                                Me.txtWhoIs.Text = .Item("WhoIsThisPerson").ToString
                            Loop
                            Me.btnEditCtsFrd2.Text = "Edit"
                            Me.btnDeleteCtsFrd2.Enabled = True
                        Else
                            Me.btnEditCtsFrd2.Text = "Add"
                            Me.btnDeleteCtsFrd2.Enabled = False
                        End If
                        .Close()
                    End With
                    conn.Close()

                    strSQLContactChoice = strSQLContactChoice & " AND tbContactChoice.ContactOwnerCd=3 ORDER BY ContactChoice"
                    'Console.WriteLine(strSQLContactChoice)
                    Fill_lvw(Me.lvwCtMthdFrd2, strSQLContactChoice, , False)
                    Update_rtbCts(Me.rtbCtsFrd2)

            End Select

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub Update_tabContactInfo()

        Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
        Dim ContactOwnerCd As Byte = Me.tabContactInfo.SelectedTab.Tag
        Dim strSQL As String

        Me.btnEditContactInfo.Text = "Add"
        Me.btnDelContactInfo.Enabled = False

        Me.txtCiLastName.Text = ""
        Me.txtCiLastName.BackColor = SystemColors.Control
        Me.txtCiFirstName.Text = ""
        Me.txtCiFirstName.BackColor = SystemColors.Control
        Me.txtWhoIs.Text = String.Empty
        Me.txtWhoIs.BackColor = SystemColors.Control
        booCiCanMailReminder = False
        Me.chkCiCanMailReminder.Checked = False
        booCiCanTextMessage = False
        Me.chkCiCanTextMessage.Checked = False
        Me.txtHasContact.Text = ""

        Me.txtCiAddress1.Text = ""
        Me.txtCiAddress1.BackColor = SystemColors.Control
        Me.txtCiAddress2.Text = ""
        Me.txtCiAddress2.BackColor = SystemColors.Control
        Me.txtCiCity.Text = ""
        Me.txtCiCity.BackColor = SystemColors.Control
        Me.txtCiState.Text = ""
        Me.txtCiState.BackColor = SystemColors.Control
        Me.txtCiZip.Text = ""
        Me.txtCiZip.BackColor = SystemColors.Control
        Me.txtCiSpecialRequests.Text = ""
        Me.txtHasAddress.Text = ""

        Dim conn As New OleDbConnection(strConn)
        Dim reader As OleDbDataReader, cmd As OleDbCommand

        strSQL = "SELECT * FROM tbContact " & _
                 "WHERE ContactOwnerCd=" & ContactOwnerCd & " AND PatientID=" & PatID
        conn.Open()
        cmd = New OleDbCommand(strSQL, conn)
        reader = cmd.ExecuteReader()
        With reader
            If .HasRows Then
                Do While .Read()
                    Me.txtCiSpecialRequests.Text = .Item("SpecialRequestsWhenContact").ToString
                    If ContactOwnerCd = 1 Or UCase(tabContactInfo.SelectedTab.Text) = "PATIENT" Then
                        booCiCanMailReminder = .Item("CanMailReminder")
                        Me.chkCiCanMailReminder.Checked = .Item("CanMailReminder")
                        booCiCanTextMessage = .Item("CanTextMessage")
                        Me.chkCiCanTextMessage.Checked = .Item("CanTextMessage")
                    Else
                        Me.txtCiLastName.Text = .Item("LastName").ToString
                        Me.txtCiFirstName.Text = .Item("FirstName").ToString
                        Me.txtWhoIs.Text = .Item("WhoIsThisPerson").ToString
                    End If
                Loop
                Me.txtHasContact.Text = "Y"
                Me.btnEditContactInfo.Text = "Edit"
                Me.btnDelContactInfo.Enabled = True
            End If
            .Close()
        End With
        'conn.Close()

        If ContactOwnerCd = 1 Or UCase(tabContactInfo.SelectedTab.Text) = "PATIENT" Then
            Me.grpCiContactName.Enabled = False
            Me.grpCiAddress.Enabled = True
            Me.txtCiAddress1.BackColor = SystemColors.Window
            Me.txtCiAddress2.BackColor = SystemColors.Window
            Me.txtCiCity.BackColor = SystemColors.Window
            Me.txtCiState.BackColor = SystemColors.Window
            Me.txtCiZip.BackColor = SystemColors.Window

            strSQL = "SELECT * FROM tbContactAddress " & _
                     "WHERE ContactOwnerCd=" & ContactOwnerCd & " AND PatientID=" & PatID
            cmd = New OleDbCommand(strSQL, conn)
            'Console.WriteLine(strSQL)
            'conn.Open()
            reader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        Me.txtCiAddress1.Text = .Item("Address1").ToString
                        Me.txtCiAddress2.Text = .Item("Address2").ToString
                        Me.txtCiCity.Text = .Item("City").ToString
                        Me.txtCiState.Text = .Item("State").ToString
                        Me.txtCiZip.Text = FormatZipCode(GetNumberPart(.Item("Zip").ToString)) ' FormatString(HandleNull(.Item("Zip")), "#####-####")
                    Loop
                    Me.txtHasAddress.Text = "Y"
                    Me.btnEditContactInfo.Text = "Edit"
                    Me.btnDelContactInfo.Enabled = True
                End If
                .Close()
            End With
            conn.Close()

        Else
            Me.grpCiContactName.Enabled = True
            Me.grpCiAddress.Enabled = False
            Me.txtCiLastName.BackColor = SystemColors.Window
            Me.txtCiFirstName.BackColor = SystemColors.Window
            Me.txtWhoIs.BackColor = SystemColors.Window
            Me.txtWhoIs.Enabled = True

        End If

        Update_rtbContactInfo(ContactOwnerCd)

        Dim strSQLContactChoice As String = _
                      "SELECT ContactChoice, ContactMethodDesc, tbContactChoice.ContactMethodCd " & _
                      "FROM tbContactChoice LEFT JOIN ddvContactMethod " & _
                        "ON tbContactChoice.ContactMethodCd = ddvContactMethod.ContactMethodCd " & _
                      "WHERE PatientID=" & PatID & " AND " & _
                            "tbContactChoice.ContactOwnerCd=" & ContactOwnerCd & _
                     " ORDER BY ContactChoice"
        Fill_lvw(Me.lvwCiContactChoice, strSQLContactChoice, , False)
        If Me.lvwCiContactChoice.Items.Count > 0 Then
            Me.btnEditContactInfo.Text = "Edit"
            Me.btnDelContactInfo.Enabled = True
        End If

    End Sub
    Friend Sub Update_rtbContactInfo_(ByVal ContactOwnerCd As Byte)

        'MsgBox(ContactOwnerCd)

        'Try

        Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text

        Dim strSQL As String, strContents As String
        Dim conn As New OleDbConnection(strConn)
        Dim reader As OleDbDataReader, cmd As OleDbCommand
        Dim rtf As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Tahoma;}}" & _
                            "\viewkind4\uc1\pard\f0\fs17 "

        rtbContactInfo.Rtf = ""
        conn.Open()

        ''''Fill Phone 
        strSQL = "SELECT PhoneTypeDesc, Q.PhoneNumber, Q.PhoneNumberOwner " & _
                 "FROM ddvPhoneType LEFT JOIN " & _
                     "(SELECT PhoneTypeCd, PhoneNumber, PhoneNumberOwner " & _
                      "FROM tbContactPhone " & _
                      "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                      "ON ddvPhoneType.PhoneTypeCd = Q.PhoneTypeCd " & _
                "WHERE ddvPhoneType.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & _
               " ORDER BY DisplayOrder"
        'Console.WriteLine(strSQL)
        cmd = New OleDbCommand(strSQL, conn)
        reader = cmd.ExecuteReader()
        With reader
            If .HasRows Then
                Do While .Read()
                    strContents = strContents & vbNewLine & _
                   "\b " & .Item("PhoneTypeDesc").ToString & ": " & _
                   "\b0 " & FormatPhoneNumber(.Item("PhoneNumber").ToString.TrimEnd) & _
                        IIf(.Item("PhoneNumberOwner").ToString.Trim.Length > 0, ". \cf1 Who: \cf2" & .Item("PhoneNumberOwner").ToString, "") & _
                        "\par\par"
                    If .Item("PhoneNumber").ToString.TrimEnd.Length > 0 Then
                        Me.btnEditContactInfo.Text = "Edit"
                        Me.btnDelContactInfo.Enabled = True
                    End If
                Loop
            End If
            .Close()
        End With

        strContents = strContents & "\b0 " & StrDup(121, "-") & "\par"

        ''''Fill Email
        strSQL = "SELECT EmailTypeDesc, Q.EmailAddress " & _
                     "FROM ddvEmailType LEFT JOIN " & _
                          "(SELECT EmailTypeCd, EmailAddress " & _
                           "FROM tbContactEmail " & _
                           "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                           "ON ddvEmailType.EmailTypeCd = Q.EmailTypeCd " & _
                     "WHERE ddvEmailType.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & _
                    " ORDER BY DisplayOrder"
        cmd = New OleDbCommand(strSQL, conn)
        reader = cmd.ExecuteReader()
        With reader
            If .HasRows Then
                Do While .Read()
                    strContents = strContents & vbNewLine & _
                    "\b " & .Item("EmailTypeDesc").ToString & ": " & _
                    "\b0 " & .Item("EmailAddress").ToString & "\par\par"
                    If .Item("EmailAddress").ToString.TrimEnd.Length > 0 Then
                        Me.btnEditContactInfo.Text = "Edit"
                        Me.btnDelContactInfo.Enabled = True
                    End If
                Loop
            End If
            .Close()
        End With

        strContents = strContents & "\b0 " & StrDup(121, "-") & "\par"

        ''''Fill Online
        Dim Q2 As String = _
                 "SELECT OnlineTypeDesc, OnlineName, OnlineDisplayName, OnlineEmail, OnlineURL, ddvOnlineType.OnlineTypeCd, ddvOnlineType.DisplayOrder " & _
                 "FROM ddvOnlineType LEFT JOIN " & _
                     "(SELECT OnlineTypeCd, OnlineName, OnlineDisplayName, OnlineEmail, OnlineURL " & _
                      "FROM tbContactOnline " & _
                      "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                      "ON ddvOnlineType.OnlineTypeCd = Q.OnlineTypeCd " & _
                 "WHERE ddvOnlineType.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & " "
        strSQL = "SELECT Q2.OnlineTypeDesc, Q2.OnlineName, Q2.OnlineDisplayName, Q2.OnlineEmail, Q2.OnlineURL, trefOnlineTypeCd_FieldName.FieldName, trefOnlineTypeCd_FieldName.FieldLabel " & _
                 "FROM (" & Q2 & ") AS Q2 LEFT JOIN trefOnlineTypeCd_FieldName ON Q2.OnlineTypeCd = trefOnlineTypeCd_FieldName.OnlineTypeCd " & _
                 "WHERE trefOnlineTypeCd_FieldName.Active < 0 " & _
                 "ORDER BY Q2.DisplayOrder, trefOnlineTypeCd_FieldName.DisplayOrder"
        'Console.WriteLine(strSQL)

        cmd = New OleDbCommand(strSQL, conn)
        reader = cmd.ExecuteReader()
        Dim xOnlineTypeDesc As String, strOnlineTypeDesc As String
        With reader
            If .HasRows Then
                Do While .Read()
                    'Separate each online type with blank line
                    'If .Item("OnlineTypeDesc").ToString <> xOnlineTypeDesc Then
                    'strContents = strContents & "\par"
                    'End If
                    'If .Item("OnlineTypeDesc").ToString <> xOnlineTypeDesc Then
                    strOnlineTypeDesc = "\b " & .Item("OnlineTypeDesc").ToString & " "
                    'Else
                    'strOnlineTypeDesc = StrDup(.Item("OnlineTypeDesc").ToString.Length + 1, "_")
                    'End If
                    If .Item("FieldName").ToString <> "OnlineDisplayName" Then
                        strContents = strContents & vbNewLine & _
                        strOnlineTypeDesc & _
                        .Item("FieldLabel").ToString & ": \b0 " & _
                        .Item(.Item("FieldName").ToString).ToString & "\par\par"
                    Else
                        strContents = strContents & vbNewLine & _
                       strOnlineTypeDesc & _
                       .Item("FieldLabel").ToString & ": " & _
                        IIf(.Item(.Item("FieldName").ToString).ToString.Trim.Length > 0, _
                            .Item(.Item("FieldName").ToString).ToString & "\par", "\par\par") 'doesn't need "\par" for DisplayName. already has it in the data 
                    End If
                    xOnlineTypeDesc = .Item("OnlineTypeDesc").ToString
                    If .Item(.Item("FieldName").ToString).ToString.Trim.Length > 0 Then
                        Me.btnEditContactInfo.Text = "Edit"
                        Me.btnDelContactInfo.Enabled = True
                    End If
                Loop
            End If
            .Close()
        End With

        conn.Close()

        ' strContents = strContents & vbNewLine & "\par"

        strContents = rtf & strContents '& " " & rtbContactInfo.Rtf
        Console.WriteLine(strContents)

        rtbContactInfo.Rtf = strContents

        ' Catch ex As System.Exception
        ' MsgBox(ex.Message)
        'End Try

    End Sub

    Friend Sub Update_rtbContactInfo(ByVal ContactOwnerCd As Byte)

        'MsgBox(ContactOwnerCd)

        Try

            Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text

            Dim strSQL As String, strContents As String
            Dim conn As New OleDbConnection(strConn)
            Dim reader As OleDbDataReader, cmd As OleDbCommand
            Dim rtf As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Tahoma;}}" & _
                                "\viewkind4\uc1\pard\f0\fs17 " & _
                                "{\colortbl ;\red0\green0\blue140;\red0\green0\blue0;\red170\green170\blue170;}"

            rtbContactInfo.Rtf = ""
            conn.Open()

            ''''Fill Phone 
            strSQL = "SELECT PhoneTypeDesc, Q.PhoneNumber, Q.PhoneNumberOwner " & _
                     "FROM ddvPhoneType LEFT JOIN " & _
                         "(SELECT PhoneTypeCd, PhoneNumber, PhoneNumberOwner " & _
                          "FROM tbContactPhone " & _
                          "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                          "ON ddvPhoneType.PhoneTypeCd = Q.PhoneTypeCd " & _
                    "WHERE ddvPhoneType.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & _
                   " ORDER BY DisplayOrder"
            'Console.WriteLine(strSQL)
            cmd = New OleDbCommand(strSQL, conn)
            reader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        strContents = strContents & vbNewLine & _
                       "\cf1\b " & .Item("PhoneTypeDesc").ToString & ":  " & _
                       "\cf2\b0 " & FormatPhoneNumber(.Item("PhoneNumber").ToString.TrimEnd) & _
                            IIf(.Item("PhoneNumberOwner").ToString.Trim.Length > 0, ". \cf1\b Who:  \cf2\b0 " & .Item("PhoneNumberOwner").ToString, "") & _
                            "\par\par"
                        If .Item("PhoneNumber").ToString.TrimEnd.Length > 0 Then
                            Me.btnEditContactInfo.Text = "Edit"
                            Me.btnDelContactInfo.Enabled = True
                        End If
                    Loop
                End If
                .Close()
            End With

            strContents = strContents & "\cf3 " & StrDup(121, "-") & "\par"

            ''''Fill Email
            strSQL = "SELECT EmailTypeDesc, Q.EmailAddress " & _
                         "FROM ddvEmailType LEFT JOIN " & _
                              "(SELECT EmailTypeCd, EmailAddress " & _
                               "FROM tbContactEmail " & _
                               "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                               "ON ddvEmailType.EmailTypeCd = Q.EmailTypeCd " & _
                         "WHERE ddvEmailType.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & _
                        " ORDER BY DisplayOrder"
            cmd = New OleDbCommand(strSQL, conn)
            reader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        strContents = strContents & vbNewLine & _
                        "\cf1\b " & .Item("EmailTypeDesc").ToString & ":  " & _
                        "\cf2\b0 " & .Item("EmailAddress").ToString & "\par\par"
                        If .Item("EmailAddress").ToString.TrimEnd.Length > 0 Then
                            Me.btnEditContactInfo.Text = "Edit"
                            Me.btnDelContactInfo.Enabled = True
                        End If
                    Loop
                End If
                .Close()
            End With

            strContents = strContents & "\cf3 " & StrDup(121, "-") & "\par"

            ''''Fill Online
            Dim Q2 As String = _
                     "SELECT OnlineTypeDesc, OnlineName, OnlineDisplayName, OnlineEmail, OnlineURL, ddvOnlineType.OnlineTypeCd, ddvOnlineType.DisplayOrder " & _
                     "FROM ddvOnlineType LEFT JOIN " & _
                         "(SELECT OnlineTypeCd, OnlineName, OnlineDisplayName, OnlineEmail, OnlineURL " & _
                          "FROM tbContactOnline " & _
                          "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                          "ON ddvOnlineType.OnlineTypeCd = Q.OnlineTypeCd " & _
                     "WHERE ddvOnlineType.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & " "
            strSQL = "SELECT Q2.OnlineTypeDesc, Q2.OnlineName, Q2.OnlineDisplayName, Q2.OnlineEmail, Q2.OnlineURL, trefOnlineTypeCd_FieldName.FieldName, trefOnlineTypeCd_FieldName.FieldLabel " & _
                     "FROM (" & Q2 & ") AS Q2 LEFT JOIN trefOnlineTypeCd_FieldName ON Q2.OnlineTypeCd = trefOnlineTypeCd_FieldName.OnlineTypeCd " & _
                     "WHERE trefOnlineTypeCd_FieldName.Active < 0 " & _
                     "ORDER BY Q2.DisplayOrder, trefOnlineTypeCd_FieldName.DisplayOrder"
            'Console.WriteLine(strSQL)

            cmd = New OleDbCommand(strSQL, conn)
            reader = cmd.ExecuteReader()
            Dim xOnlineTypeDesc As String, strOnlineTypeDesc As String
            With reader
                If .HasRows Then
                    Do While .Read()
                        'Separate each online type with blank line
                        'If .Item("OnlineTypeDesc").ToString <> xOnlineTypeDesc Then
                        'strContents = strContents & "\par"
                        'End If
                        'If .Item("OnlineTypeDesc").ToString <> xOnlineTypeDesc Then
                        strOnlineTypeDesc = "\cf1\b " & .Item("OnlineTypeDesc").ToString & " "
                        'Else
                        'strOnlineTypeDesc = StrDup(.Item("OnlineTypeDesc").ToString.Length + 1, "_")
                        'End If
                        If .Item("FieldName").ToString <> "OnlineDisplayName" Then
                            strContents = strContents & vbNewLine & _
                            strOnlineTypeDesc & _
                            .Item("FieldLabel").ToString & ":  \cf2\b0 " & _
                            .Item(.Item("FieldName").ToString).ToString & "\par\par"
                        Else
                            strContents = strContents & vbNewLine & _
                           strOnlineTypeDesc & _
                           .Item("FieldLabel").ToString & ":  " & _
                            IIf(.Item(.Item("FieldName").ToString).ToString.Trim.Length > 0, _
                                .Item(.Item("FieldName").ToString).ToString & "\par", "\par\par") 'doesn't need "\par" for DisplayName. already has it in the data 
                        End If
                        xOnlineTypeDesc = .Item("OnlineTypeDesc").ToString
                        If .Item(.Item("FieldName").ToString).ToString.Trim.Length > 0 Then
                            Me.btnEditContactInfo.Text = "Edit"
                            Me.btnDelContactInfo.Enabled = True
                        End If
                    Loop
                End If
                .Close()
            End With

            conn.Close()

            ' strContents = strContents & vbNewLine & "\par"

            strContents = rtf & strContents & " " & rtbContactInfo.Rtf

            rtbContactInfo.Rtf = strContents

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Update_rtbCts(ByVal rtb As RichTextBox)

        Try

            Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
            Dim ContactOwnerCd As Byte = tabCts.SelectedIndex + 1
            Dim strSQL As String, strContents As String
            Dim conn As New OleDbConnection(strConn)
            Dim reader As OleDbDataReader, cmd As OleDbCommand
            Dim rtf As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Tahoma;}}" & _
                                "\viewkind4\uc1\pard\f0\fs17 "

            rtb.Rtf = ""
            conn.Open()

            ''''Fill Phone
            strSQL = "SELECT PhoneTypeDesc, Q.PhoneNumber " & _
                     "FROM ddvPhoneType LEFT JOIN " & _
                          "(SELECT PhoneTypeCd, PhoneNumber " & _
                           "FROM tbContactPhone " & _
                           "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                           "ON ddvPhoneType.PhoneTypeCd = Q.PhoneTypeCd " & _
                     "WHERE ddvPhoneType.Active<0 " & _
                     "ORDER BY DisplayOrder"
            cmd = New OleDbCommand(strSQL, conn)
            reader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        strContents = strContents & vbNewLine & _
                       .Item("PhoneTypeDesc").ToString & ": " & FormatPhoneNumber(.Item("PhoneNumber").ToString) & "\par"
                    Loop
                End If
                .Close()
            End With

            strContents = strContents & "\par" & StrDup(116, "-") & "\par"

            ''''Fill Email
            strSQL = "SELECT EmailTypeDesc, Q.EmailAddress " & _
                         "FROM ddvEmailType LEFT JOIN " & _
                              "(SELECT EmailTypeCd, EmailAddress " & _
                               "FROM tbContactEmail " & _
                               "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                               "ON ddvEmailType.EmailTypeCd = Q.EmailTypeCd " & _
                         "WHERE ddvEmailType.Active<0 " & _
                         "ORDER BY DisplayOrder"
            cmd = New OleDbCommand(strSQL, conn)
            reader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        strContents = strContents & vbNewLine & _
                       .Item("EmailTypeDesc").ToString & ": " & .Item("EmailAddress").ToString & "\par"
                    Loop
                End If
                .Close()
            End With

            strContents = strContents & "\par" & StrDup(116, "-") & "\par"

            ''''Fill Online
            strSQL = "SELECT OnlineTypeDesc, OnlineName, OnlineDisplayName, OnlineEmail, OnlineURL, ddvOnlineType.OnlineTypeCd " & _
                      "FROM ddvOnlineType LEFT JOIN " & _
                           "(SELECT OnlineTypeCd, OnlineName, OnlineDisplayName, OnlineEmail, OnlineURL " & _
                            "FROM tbContactOnline " & _
                            "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                            "ON ddvOnlineType.OnlineTypeCd = Q.OnlineTypeCd " & _
                      "WHERE ddvOnlineType.Active<0 " & _
                      "ORDER BY DisplayOrder"
            cmd = New OleDbCommand(strSQL, conn)
            reader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        strContents = strContents & vbNewLine & _
                       .Item("OnlineTypeDesc").ToString & "\par"

                        strContents = strContents & vbNewLine & _
                        "Name: " & .Item("OnlineName").ToString & "\par"

                        strContents = strContents & vbNewLine & _
                        "DisplayName: " & _
                        IIf(.Item("OnlineDisplayName").ToString.Trim.Length > 0, _
                        .Item("OnlineDisplayName").ToString(), "\par") 'doesn't need "\par" for DisplayName. already has it in the data 

                        strContents = strContents & vbNewLine & _
                        "Email: " & .Item("OnlineEmail").ToString & "\par"

                        strContents = strContents & vbNewLine & _
                        "Network/URL: " & .Item("OnlineURL").ToString & "\par" & " \par"
                    Loop
                End If
                .Close()
            End With

            conn.Close()

            strContents = strContents & vbNewLine & "\par"

            strContents = rtf & strContents & " " & rtb.Rtf

            rtb.Rtf = strContents

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Friend Sub Update_tabHpv(Optional ByVal booUpdate_tabHpvVst As Boolean = True)

        If Me.lvwHpvEpi.Items.Count = 0 Then Exit Sub

        Dim EpiID As Integer = lvwHpvEpi.SelectedItems(0).SubItems(lvwHpvEpi.Columns.Count - 1).Text
        Dim EpisodeTypeID As String = lvwHpvEpi.SelectedItems(0).SubItems(lvwHpvEpi.Columns.Count - 2).Text

        SetHPVGenderSetup()

        Select Case tabHpv.SelectedIndex
            Case 0 'Visit Related Info                
                Fill_lvwHpvVisits()

                If EpisodeTypeID <> "2" Then
                    Fill_lblHpvVstDate()
                End If

                If booUpdate_tabHpvVst Then Update_tabHpvVst()
            Case 1 'Screening form
                If EpisodeTypeID <> "2" Then
                    Fill_ScreeningForm(EpiID)
                End If
        End Select

    End Sub
    Sub Fill_ScreeningForm(ByVal EpiID As Integer)
        Dim strSQL As String = "SELECT * FROM tbStuHpvScreeningForm " & _
                                 "WHERE EpisodeID=" & EpiID
        Dim conn As New OleDbConnection(strConn)
        Dim cmd As New OleDbCommand(strSQL, conn)
        conn.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        With reader
            If .HasRows Then
                Do While .Read()
                    Me.txtDateScreened.Text = IIf(Not IsDBNull(.Item("DateScreened")), FormatDateTime(.Item("DateScreened"), DateFormat.ShortDate), "")

                    If Not IsDBNull(.Item("TermDate")) Then
                        Me.txtEndPregnancyDate.Text = FormatDateTime(.Item("TermDate"), DateFormat.ShortDate).ToString
                    Else
                        Me.txtEndPregnancyDate.Text = .Item("TermDateEstimate").ToString
                    End If

                    Me.grpHpvSfSexuallyActive.Tag = IIf(Not IsDBNull(.Item("SexuallyActive")), .Item("SexuallyActive"), "")
                    FillRBYesNo(Me.grpHpvSfSexuallyActive.Tag, rbScrFrmYes1, rbScrFrmNo1)

                    Me.grpHpvSfSexualActType.Tag = IIf(Not IsDBNull(.Item("SexualActType")), .Item("SexualActType"), "")
                    FillCheckBoxGroup(Me, Me.grpHpvSfSexualActType.Tag, "chkScrFrm1_", 2)

                    Me.rbScrFrmYes2.Checked = .Item("CurrentPreg")
                    Me.rbScrFrmNo2.Checked = Not .Item("CurrentPreg")
                    Me.rbScrFrmYes3.Checked = .Item("TodayPreg")
                    Me.rbScrFrmNo3.Checked = Not .Item("TodayPreg")

                    Me.grpHpvSfHasPeriod.Tag = IIf(Not IsDBNull(.Item("HasPeriod")), .Item("HasPeriod"), "")
                    FillRBYesNo(Me.grpHpvSfHasPeriod.Tag, rbScrFrmYes4, rbScrFrmNo4)
                    Me.grpHpvSfHPVvaccinated.Tag = IIf(Not IsDBNull(.Item("HPVvaccinated")), .Item("HPVvaccinated"), "")
                    FillRBYesNo(Me.grpHpvSfHPVvaccinated.Tag, rbScrFrmYes5, rbScrFrmNo5)
                    Me.grpHpvSfWantHPVvaccine.Tag = IIf(Not IsDBNull(.Item("WantHPVvaccine")), .Item("WantHPVvaccine"), "")
                    FillRBYesNo(Me.grpHpvSfWantHPVvaccine.Tag, rbScrFrmYes6, rbScrFrmNo6)

                    If Not IsDBNull(.Item("TermPreg")) Then
                        Me.cboOutComeOfPreg.SelectedValue = .Item("TermPreg").ToString
                    Else
                        Me.cboOutComeOfPreg.SelectedIndex = -1
                    End If

                    Me.grpHpvSfPlanToLeaveNYC.Tag = IIf(Not IsDBNull(.Item("PlanToLeaveNYC")), .Item("PlanToLeaveNYC"), "")
                    FillRBYesNo(Me.grpHpvSfPlanToLeaveNYC.Tag, rbScrFrmYes8, rbScrFrmNo8)
                Loop
                Me.btnEditScrnForm.Text = "Edit"
                Me.btnDelScrnForm.Enabled = True
            Else
                Dim i As Short
                Me.txtDateScreened.Text = ""
                Me.txtEndPregnancyDate.Text = ""
                Me.grpHpvSfSexuallyActive.Tag = ""
                Me.grpHpvSfSexualActType.Tag = ""
                Me.grpHpvSfCurrentlyPregnant.Tag = ""
                Me.grpHpvSfThoughtPregnant.Tag = ""
                Me.grpHpvSfHasPeriod.Tag = ""
                Me.grpHpvSfHPVvaccinated.Tag = ""
                Me.grpHpvSfWantHPVvaccine.Tag = ""
                Me.grpHpvSfEndPregnancy.Tag = ""
                Me.grpHpvSfPlanToLeaveNYC.Tag = ""
                For i = 1 To 8
                    If i <> 7 Then
                        CType(FindControl(Me, "rbScrFrmYes" & i), RadioButton).Checked = False
                        CType(FindControl(Me, "rbScrFrmNo" & i), RadioButton).Checked = False
                    End If
                Next
                For i = 1 To 2
                    CType(FindControl(Me, "chkScrFrm1_" & i), CheckBox).Checked = False
                Next

                Me.btnEditScrnForm.Text = "Add"
                Me.btnDelScrnForm.Enabled = False
            End If
            .Close()
        End With
        conn.Close()
    End Sub
    Friend Sub Update_tabHpvVst()

        Try

            If Me.lvwHpvVst.Items.Count > 0 Then
                Me.tabHpvVst.Visible = True
                Me.lblNoHpvVisits.Visible = False
            Else
                Me.tabHpvVst.Visible = False
                Me.lblNoHpvVisits.Visible = True
                Exit Sub
            End If

            Dim VisitID As Integer = lvwHpvVst.SelectedItems(0).SubItems(lvwHpvVst.Columns.Count - 1).Text
            Dim strSQL As String
            Select Case tabHpvVst.SelectedIndex
                Case 0 'Contact Hx
                    strSQL = "SELECT VisitID, Format(ContactDate, 'MM/dd/yyyy'), ContactMethodDesc, Notes, ContactID " & _
                             "FROM tbStuHpvPatVisitContactHx LEFT JOIN ddvContactMethod ON " & _
                                  "tbStuHpvPatVisitContactHx.ContactMethodCd = ddvContactMethod.ContactMethodCd " & _
                             "WHERE VisitID=" & VisitID & _
                            " ORDER BY ContactDate,ContactMethodDesc"
                    Fill_lvw(Me.lvwHpvCtHx, strSQL, , False)
                    ShowTotalOnLvw(Me.lvwHpvCtHx, 1)
                    'ShowLvwEditButtons(Me.lvwHpvCtHx, btnEditHpvCtHx, btnDelHpvCtHx)
                Case 1 'Forms & Procedures 
                    Fill_lvwHpvVstForm(lvwHpvVstFormPF, 1)
                    Fill_lvwHpvVstForm(lvwHpvVstFormR, 2)
                    Fill_lvwHpvVstProc(lvwHpvVstProc, 1)
                    Fill_lvwHpvVstProc(lvwHpvVstSpec, 2)
                    Fill_lvwHpvVstProc(lvwHpvVstVac, 3)

                Case 2 'Blood    
                    DisableHpvBloodSection()

                    '2=Specimens collected, 7=Blood draw (Einstein)
                    Dim VisitProcActID As String = _
                        LookUp("VisitProcActID", "tbStuHpvPatVisitProcAct", _
                               "VisitID=" & VisitID & " AND ActivityCd=2 AND ProcCd=7")
                    Me.txtHpvBloodVisitProcActID.Text = VisitProcActID

                    If Me.txtHpvBloodVisitProcActID.Text.Trim.Length > 0 Then
                        'Me.tabHpvVstP2.Text = "Blood Drawn"
                        'strSQL = "SELECT tbStuHpvPatVisitBlood.* " & _
                        '"FROM tbStuHpvPatVisitProcAct INNER JOIN tbStuHpvPatVisitBlood " & _
                        '"ON tbStuHpvPatVisitProcAct.VisitProcActID = tbStuHpvPatVisitBlood.VisitProcActID " & _
                        '"WHERE VisitID = " & VisitID
                        'strSQL = "SELECT * FROM tbStuHpvPatVisitBlood " & _
                        '         "WHERE VisitProcActID = " & VisitProcActID

                        strSQL = "SELECT tbStuHpvPatVisit.VisitDate & ' ' & BloodDrawnTime AS DrawnDate, tbStuHpvPatVisit.VisitDate & ' ' & BloodSpunTime AS SpunDate, TransportToGCRCDate & ' ' & SerumExtractedTime AS ExtractedDate, IIF(tbStuHpvBloodLog.NumberAliquots is null,'0',tbStuHpvBloodLog.NumberAliquots ) as Aliquots, BloodLogID " _
& "FROM (tbStuHpvPatVisit LEFT JOIN tbStuHpvPatVisitProcAct ON tbStuHpvPatVisit.VisitID = tbStuHpvPatVisitProcAct.VisitID) LEFT JOIN tbStuHpvBloodLog ON tbStuHpvPatVisitProcAct.VisitProcActID = tbStuHpvBloodLog.VisitProcActID " _
& "WHERE tbStuHpvPatVisitProcAct.VisitProcActID =" & VisitProcActID & " AND BloodLogID is not null;"


                        Dim conn As New OleDbConnection(strConn)
                        Dim cmd As New OleDbCommand(strSQL, conn)
                        conn.Open()
                        Dim reader As OleDbDataReader = cmd.ExecuteReader()
                        With reader
                            If .HasRows Then

                                Dim BloodID As Integer
                                Do While .Read()
                                    If Not IsDBNull(.Item("DrawnDate")) Then
                                        Me.txtHpvBlood1.Text = Date.Parse(.Item("DrawnDate"))
                                    End If
                                    'Me.txtHpvBlood1.Text = Me.txtHpvBlood1.Text & " " & _
                                    '                       IIf(Not IsDBNull(.Item("BloodDrawnTime")), .Item("BloodDrawnTime"), "")
                                    If Not IsDBNull(.Item("SpunDate")) Then
                                        Me.txtHpvBlood2.Text = Date.Parse(.Item("SpunDate"))
                                    End If
                                    'Me.txtHpvBlood2.Text = Me.txtHpvBlood2.Text & " " & _
                                    '                       IIf(Not IsDBNull(.Item("BloodSpunTime")), .Item("BloodSpunTime"), "")
                                    If Not IsDBNull(.Item("ExtractedDate")) Then
                                        Me.txtHpvBlood3.Text = Date.Parse(.Item("ExtractedDate"))
                                    End If
                                    'Me.txtHpvBlood3.Text = Me.txtHpvBlood3.Text & " " & _
                                    '                       IIf(Not IsDBNull(.Item("SerumExtractedTime")), .Item("SerumExtractedTime"), "")
                                    BloodID = .Item("BloodLogID")
                                    'The format function does not work in the following
                                    'Me.txtHpvBlood1.Text = IIf(Not IsDBNull(.Item("BloodDrawnDate")), Format(.Item("BloodDrawnDate"), "MM/dd/yyyy"), "") & " " & _
                                    'IIf(Not IsDBNull(.Item("BloodDrawnTime")), .Item("BloodDrawnTime"), "")
                                    'Me.txtHpvBlood2.Text = IIf(Not IsDBNull(.Item("BloodSpunDate")), Format(.Item("BloodSpunDate"), "MM/dd/yyyy"), "") & " " & _
                                    'IIf(Not IsDBNull(.Item("BloodSpunTime")), .Item("BloodSpunTime"), "")
                                    'Me.txtHpvBlood3.Text = IIf(Not IsDBNull(.Item("SerumExtractedDate")), Format(.Item("SerumExtractedDate"), "MM/dd/yyyy"), "") & " " & _
                                    'IIf(Not IsDBNull(.Item("SerumExtractedTime")), .Item("SerumExtractedTime"), "")
                                    Dim NumberAliquts As Integer = 0

                                    If Not Convert.IsDBNull(.Item("Aliquots")) Then
                                        NumberAliquts = .Item("Aliquots")
                                    End If
                                    Me.txtHpvBlood4.Text = NumberAliquts


                                Loop


                                ' LookUp("COUNT(*)", "tbStuHpvPatVisitBloodAliquot", "BloodID=" & BloodID)

                                'Me.btnEditHpvBlood.Text = "Edit"
                                'Me.btnEditHpvBlood.Enabled = True
                                'Me.btnDelHpvBlood.Enabled = True
                            Else
                                'Me.btnEditHpvBlood.Text = "Add"
                                'Me.btnEditHpvBlood.Enabled = True
                            End If
                            .Close()
                        End With
                        conn.Close()
                    Else
                        'Me.tabHpvVstP2.Text = "Blood Not Drawn"
                    End If

                    'If Me.btnEditHpvBlood.Enabled = False And _
                    'Me.btnDelHpvBlood.Enabled = False Then
                    'Me.tabHpvVstP2.Text = "Blood Drawn N/A"
                    'End If

                Case 3 'Specimen Sent

                Case 4 'Adverse Events
                    Me.ShowAdverseEvents(VisitID)
                Case 5 'Results

            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub DisableHpvBloodSection()

        Me.txtHpvBlood1.Text = ""
        Me.txtHpvBlood2.Text = ""
        Me.txtHpvBlood3.Text = ""
        Me.txtHpvBlood4.Text = ""
        Me.txtHpvBloodVisitProcActID.Text = ""
        'Me.btnEditHpvBlood.Enabled = False
        'Me.btnDelHpvBlood.Enabled = False

    End Sub

    Friend Sub Fill_lvwHpvVstForm(ByVal lvw As ListView, ByVal FormPurposeCd As Short)

        With lvwHpvVst

            If .Items.Count = 0 Then
                lvw.Items.Clear()
                ShowTotalOnLvw(lvw, 0)
                Exit Sub
            End If

            Dim VisitID As Integer = .SelectedItems(0).SubItems(.Columns.Count - 1).Text

            Dim strSQL As String
            'strSQL = "Select FormDesc, tbStuHpvPatVisitForm.FormCd " & _
            '"FROM (tbStuHpvPatVisitForm LEFT JOIN ddvForm ON tbStuHpvPatVisitForm.FormCd = ddvForm.FormCd) LEFT JOIN trefStuHpvFormCd_FormPurposeCd ON tbStuHpvPatVisitForm.FormCd = trefStuHpvFormCd_FormPurposeCd.FormCd " & _
            '"WHERE trefStuHpvFormCd_FormPurposeCd.FormPurposeCd=" & FormPurposeCd & " AND " & _
            '"tbStuHpvPatVisitForm.VisitID=" & VisitID
            'Console.WriteLine(strSQL)

            strSQL = "SELECT FormDesc, q.FormCd " & _
                     "FROM ((" & _
                            "(SELECT FormCd, VisitNum " & _
                             "FROM tbStuHpvPatVisitForm LEFT JOIN tbStuHpvPatVisit " & _
                                   "ON tbStuHpvPatVisitForm.VisitID = tbStuHpvPatVisit.VisitID " & _
                             "WHERE tbStuHpvPatVisitForm.VisitID=" & VisitID & ") AS q " & _
                          "LEFT JOIN trefStuHpvFormCd_FormPurposeCd ON q.FormCd = trefStuHpvFormCd_FormPurposeCd.FormCd) " & _
                          "LEFT JOIN ddvForm ON q.FormCd = ddvForm.FormCd) " & _
                          "LEFT JOIN trefStuHpvVisitNum_FormCd ON q.FormCd = trefStuHpvVisitNum_FormCd.FormCd AND q.VisitNum = trefStuHpvVisitNum_FormCd.VisitNum " & _
                     "WHERE trefStuHpvFormCd_FormPurposeCd.FormPurposeCd = " & FormPurposeCd & _
                    " ORDER BY DisplayOrder"
            Fill_lvw(lvw, strSQL)

        End With

    End Sub

    Friend Sub Fill_lvwHpvVstProc(ByVal lvw As ListView, ByVal ActivityCd As Short)

        With lvwHpvVst

            If .Items.Count = 0 Then
                lvw.Items.Clear()
                ShowTotalOnLvw(lvw, 0)
                Exit Sub
            End If

            Dim VisitID As Integer = .SelectedItems(0).SubItems(.Columns.Count - 1).Text

            Dim strSQL As String
            'strSQL = "SELECT ProcDesc, tbStuHpvPatVisitProcAct.ProcCd " & _
            '"FROM tbStuHpvPatVisitProcAct LEFT JOIN ddvProcedure ON tbStuHpvPatVisitProcAct.ProcCd = ddvProcedure.ProcCd " & _
            '"WHERE ActivityCd=" & ActivityCd & " AND VisitID=" & VisitID          

            strSQL = "SELECT ProcDesc, q.ProcCd " & _
                     "FROM (" & _
                            "(SELECT ProcCd, VisitNum " & _
                             "FROM tbStuHpvPatVisitProcAct " & _
                                "LEFT JOIN tbStuHpvPatVisit ON tbStuHpvPatVisitProcAct.VisitID = tbStuHpvPatVisit.VisitID " & _
                             "WHERE tbStuHpvPatVisitProcAct.VisitID=" & VisitID & " AND " & _
                                    "ActivityCd=" & ActivityCd & ") AS q " & _
                          "LEFT JOIN ddvProcedure ON q.ProcCd = ddvProcedure.ProcCd) " & _
                          "LEFT JOIN trefStuHpvVisitNum_ProcCd ON q.ProcCd = trefStuHpvVisitNum_ProcCd.ProcCd AND q.VisitNum = trefStuHpvVisitNum_ProcCd.VisitNum " & _
                    " ORDER BY DisplayOrder"
            Fill_lvw(lvw, strSQL)

        End With
    End Sub

    Private Function HPV_NumVisits(ByVal EpiID As Short) As Short

        Try
            Dim strSQL As String = "SELECT MAX(VisitNum) AS MaxVisitNum " & _
                                   "FROM tbStuHpvPatVisit " & _
                                   "WHERE Completed<0 AND EpisodeID = " & EpiID & _
                                  " GROUP BY EpisodeID"
            Dim conn As New OleDbConnection(strConn)
            Dim cmd As New OleDbCommand(strSQL, conn)
            conn.Open()
            Return cmd.ExecuteScalar
            conn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub Fill_lvwHpvVisits()
        Dim EpiID As Integer = lvwHpvEpi.SelectedItems(0).SubItems(lvwHpvEpi.Columns.Count - 1).Text
        ' "IIF(Completed<0,' x','')" has bee replaced by ApptStatusDesc
        Dim strSQL As String = "SELECT tbStuHpvPatVisit.VisitNum, VisitNumDescShort, FORMAT(VisitDate,'MM/dd/yyyy'), ApptStatusDesc, tbStuHpvPatVisit.Notes,ddvPhysician.LastName as VisitProvider, VisitID " & _
                               "FROM (((tbStuHpvPatVisit LEFT JOIN ddvStuHpvVisitNum ON tbStuHpvPatVisit.VisitNum = ddvStuHpvVisitNum.VisitNum) " & _
                               "LEFT JOIN ddvStuHpvApptStatus ON tbStuHpvPatVisit.ApptStatusCd = ddvStuHpvApptStatus.ApptStatusCd) " & _
                               "LEFT JOIN ddvPhysician ON tbStuHpvPatVisit.PhysicianCd=ddvPhysician.PhysicianCd) " & _
                               "WHERE EpisodeID=" & EpiID & _
                              " ORDER BY tbStuHpvPatVisit.VisitNum,VisitDate asc"
        Fill_lvw(Me.lvwHpvVst, strSQL, , False)
        ShowLvwEditButtons(Me.lvwHpvVst, btnEditHpvVst, btnDelHpvVst)

        If UCase(cboStudy.SelectedItem.ToString) = "HPV PATIENTS TO FOLLOW UP" Then
            If lvwHpvEpiFU.Items.Count = 1 Then
                ColorLvwItem(lvwHpvVst, Me.lvwHpvEpiFU.Items(0).SubItems(1).Text, lvwHpvVst.Columns.Count - 1)
            Else
                Color_lvwHpvVst_Items()
            End If
        End If
    End Sub

    Friend Sub Color_lvwHpvVst_Items()
        Dim item As New ListViewItem
        With lvwHpvEpi
            For Each item In lvwHpvEpiFU.Items
                If item.Text = .SelectedItems(0).SubItems(.Columns.Count - 1).Text Then
                    ColorLvwItem(lvwHpvVst, item.SubItems(1).Text, lvwHpvVst.Columns.Count - 1)
                End If
            Next
        End With
    End Sub

    Private Sub Fill_lblHpvVstDate()

        Try
            ShowHPVStatus(False)

            Dim lblHpvVstDateX As Label, lblHpvVstDate As Label, spbHpvVst As SPB.SmoothProgressBar, i As Short ', LastItemIndex As Short            

            If Me.lvwHpvVst.Items.Count = 0 Then Exit Sub

            'On Error Resume Next
            Dim grpVisitNum As String = ""
            Dim grpVisitNumFirstDt As String = ""
            Dim FirstVisitDt As String = ""
            Dim CurLblNum As Int16 = 0

            With Me.lvwHpvVst
                For i = 0 To .Items.Count - 1
                    If .Items(i).SubItems(2).Text.Length > 0 Then 'VisitDate

                        '* CHECK IF THIS VISIT IS TERMINATED
                        If UCase(.Items(i).SubItems(3).Text) = "TERMINATED" Then
                            ShowHPVStatus(False)

                            '* MAY NEED TO SET THIS FLAG IF TERMINATED.
                            'Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
                            'Dim strSQL As String = "UPDATE tbPatient SET HPV_Terminated = 1 WHERE PatientID=" & PatID
                            'RunSQL(strSQL)

                            Exit Sub
                        End If

                        '* GET THE FIRST VISIT DATE FOR EACH VISITNUM
                        If grpVisitNumFirstDt <> .Items(i).SubItems(0).Text Then
                            FirstVisitDt = .Items(i).SubItems(2).Text
                        End If

                        '* IF THIS IS THE FIRST COMPLETED VISIT THEN USE THIS INFO TO UPDATE PROGRESS
                        If (grpVisitNum <> .Items(i).SubItems(0).Text) And (UCase(.Items(i).SubItems(3).Text) = "COMPLETED" Or UCase(.Items(i).SubItems(3).Text) = "SKIPPED") Then

                            CurLblNum += 1
                            '* ONLY SHOW THE BLUE STATUS BAR INCREASE IN COMPLETED STATUS
                            If UCase(.Items(i).SubItems(3).Text) = "COMPLETED" Then
                                spbHpvVst = CType(FindControl(Me, "spbHpvVst" & CurLblNum), SPB.SmoothProgressBar)
                                spbHpvVst.Value = 1
                            End If

                            lblHpvVstDate = CType(FindControl(Me, "lblHpvVstDate" & CurLblNum), Label)
                            lblHpvVstDate.Visible = True
                            lblHpvVstDate.Text = FirstVisitDt
                            grpVisitNum = .Items(i).SubItems(0).Text
                        End If

                        grpVisitNumFirstDt = .Items(i).SubItems(0).Text
                    End If
                Next
            End With

            If CurLblNum = 0 Then
                ShowHPVStatus(False)
                Exit Sub
            End If

            If CurLblNum <> HPVNUMBEROFVISITS Then
                CurLblNum += 1

                '* INCREASE THE DAYS TO NEXT VISIT BY THE FOLLOWING AMOUNTS
                '* INCREASE THE DAYS TO NEXT VISIT BY THE FOLLOWING AMOUNTS
                Dim NumMontsToAdd As Short
                Select Case CurLblNum
                    Case 2
                        NumMontsToAdd = 2
                    Case 3
                        NumMontsToAdd = 4
                    Case 4
                        NumMontsToAdd = 6
                    Case 5
                        NumMontsToAdd = 6
                    Case 6
                        NumMontsToAdd = 6
                    Case Else
                        NumMontsToAdd = 6
                End Select

                lblHpvVstDateX = CType(FindControl(Me, "lblHpvVstDate" & CurLblNum - 1), Label)
                lblHpvVstDate = CType(FindControl(Me, "lblHpvVstDate" & CurLblNum), Label)
                If Not lblHpvVstDateX Is Nothing Then
                    lblHpvVstDate.Text = CType(lblHpvVstDateX.Text, Date).AddMonths(NumMontsToAdd) & "*"
                    lblHpvVstDate.ForeColor = Color.Red
                    lblHpvVstDate.Visible = True
                    lblHpvProjected.Visible = True
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ShowHPVStatus(ByVal Enabled As Boolean)
        Dim lblHpvVstDate As Label
        Dim spbHpvVst As SPB.SmoothProgressBar
        Dim i As Short
        For i = 1 To HPVNUMBEROFVISITS
            spbHpvVst = CType(FindControl(Me, "spbHpvVst" & i), SPB.SmoothProgressBar)
            spbHpvVst.Value = 0
            lblHpvVstDate = CType(FindControl(Me, "lblHpvVstDate" & i), Label)
            With lblHpvVstDate
                .Visible = Enabled
                .Text = ""
                .ForeColor = SystemColors.ControlDarkDark
            End With
        Next
        lblHpvProjected.Visible = False
    End Sub
    Private Sub Tab1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab1.Click
        Update_Tab1()
    End Sub

    Private Sub tabCts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabCts.Click
        Update_tabCts()
    End Sub

    Private Sub tabHpv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabHpv.Click
        Update_tabHpv()
    End Sub

    Private Sub rbFindPt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles rbFindPt1.Click, rbFindPt2.Click, rbFindPt3.Click

        Fill_lvw0()
        Update_Tab1()
        Exit Sub

        With lvw0
            Select Case sender.name
                Case "rbFindPt1" 'Last Name 
                Case "rbFindPt2" 'MRN
                Case "rbFindPt3" 'Subj ID
            End Select
        End With

    End Sub

    Friend Sub Fill_lvw0()

        Dim strSQL As String

        With lvw0
            If rbFindPt1.Checked Then 'LastName
                .Columns(0).Text = "Last Name"
                .Columns(1).Text = "First Name"
                .Columns(2).Text = "MRN"
                .Columns(3).Text = "Subj. ID"
                'strSQL = "SELECT LastName, FirstName, MRN, '' AS SubjectID, tbPatient.PatientID "
            ElseIf rbFindPt2.Checked Then 'MRN
                .Columns(0).Text = "MRN"
                .Columns(1).Text = "Last Name"
                .Columns(2).Text = "First Name"
                .Columns(3).Text = "Subj. ID"
                'strSQL = "SELECT MRN, LastName, FirstName, '' AS SubjectID, tbPatient.PatientID "
            ElseIf rbFindPt3.Checked Then 'SubjectID
                .Columns(0).Text = "Subj. ID"
                .Columns(1).Text = "Last Name"
                .Columns(2).Text = "First Name"
                .Columns(3).Text = "MRN"
                'strSQL = "SELECT SubjectID, LastName, FirstName, MRN, tbPatient.PatientID "
            End If
            .Columns(4).Text = "Pat. ID"
        End With

        Dim TextSelected As String = cboStudy.SelectedItem.ToString
        Dim ValueSelected As Short = CType(cboStudy.SelectedItem, ValueDescriptionPair).Value

        Select Case UCase(cboStudy.SelectedItem.ToString)
            Case "ALL PATIENTS"
                If rbFindPt1.Checked Then 'LastName              
                    strSQL = "SELECT LastName, FirstName, MRN, '' AS SubjectID, tbPatient.PatientID "
                ElseIf rbFindPt2.Checked Then 'MRN               
                    strSQL = "SELECT MRN, LastName, FirstName, '' AS SubjectID, tbPatient.PatientID "
                ElseIf rbFindPt3.Checked Then 'SubjectID              
                    strSQL = "SELECT '' AS SubjectID, LastName, FirstName, MRN, tbPatient.PatientID "
                End If
                strSQL = strSQL & _
                        "FROM tbPatient "

            Case "HPV PATIENTS TO FOLLOW UP"
                Dim strDateRange As String = "", strFROM As String, strWhere As String
                If Me.dtsHPVvstDate1.Checked = True And Me.dtsHPVvstDate2.Checked = False Then
                    strDateRange = " AND tbStuHpvPatVisit.VisitDate >= #" & _
                      Me.dtsHPVvstDate1.Value & "# "
                ElseIf Me.dtsHPVvstDate1.Checked = False And Me.dtsHPVvstDate2.Checked = True Then
                    strDateRange = " AND tbStuHpvPatVisit.VisitDate <= #" & _
                      Me.dtsHPVvstDate2.Value & "# "
                ElseIf Me.dtsHPVvstDate1.Checked = True And Me.dtsHPVvstDate2.Checked = True Then
                    strDateRange = " AND tbStuHpvPatVisit.VisitDate BETWEEN #" & _
                      Me.dtsHPVvstDate1.Value & "# AND #" & Me.dtsHPVvstDate2.Value & "# "
                End If
                strFROM = "tbStuHpvEpisode INNER JOIN tbStuHpvPatVisit " & _
                          "ON tbStuHpvEpisode.EpisodeID = tbStuHpvPatVisit.EpisodeID "
                strWhere = "WHERE ApptStatusCd In (1,3) " & strDateRange
                If rbFindPt1.Checked Or rbFindPt2.Checked Then
                    If rbFindPt1.Checked Then 'LastName              
                        strSQL = "SELECT LastName, FirstName, MRN, '' AS SubjectID, A.PatientID "
                    ElseIf rbFindPt2.Checked Then 'MRN               
                        strSQL = "SELECT MRN, LastName, FirstName, '' AS SubjectID, A.PatientID "
                    End If
                    strSQL = strSQL & _
                                 "FROM " & _
                                 "(SELECT DISTINCT PatientID " & _
                                  "FROM " & strFROM & strWhere & ") AS A " & _
                                 "LEFT JOIN " & _
                                 "tbPatient " & _
                                 "ON A.PatientID = tbPatient.PatientID"
                ElseIf rbFindPt3.Checked Then 'SubjectID              
                    strSQL = "SELECT DISTINCT SubjectID, LastName, FirstName, MRN, tbPatient.PatientID " & _
                             "FROM (" & strFROM & ") LEFT JOIN tbPatient ON tbStuHpvEpisode.PatientID = tbPatient.PatientID " & _
                             strWhere
                End If

            Case "HPV (DOB)"
                Dim strWhere As String = "", strFROM As String
                If Me.dtsHPVvstDate1.Checked = True And Me.dtsHPVvstDate2.Checked = False Then
                    strWhere = " WHERE tbPatient.DateOfBirth >= #" & _
                      Me.dtsHPVvstDate1.Value & "# "
                ElseIf Me.dtsHPVvstDate1.Checked = False And Me.dtsHPVvstDate2.Checked = True Then
                    strWhere = " WHERE tbPatient.DateOfBirth <= #" & _
                      Me.dtsHPVvstDate2.Value & "# "
                ElseIf Me.dtsHPVvstDate1.Checked = True And Me.dtsHPVvstDate2.Checked = True Then
                    strWhere = " WHERE tbPatient.DateOfBirth BETWEEN #" & _
                      Me.dtsHPVvstDate1.Value & "# AND #" & Me.dtsHPVvstDate2.Value & "# "
                End If
                strFROM = "FROM tbStuHpvEpisode INNER JOIN tbPatient " & _
                               "ON tbStuHpvEpisode.PatientID = tbPatient.PatientID "
                If rbFindPt1.Checked Then 'LastName              
                    strSQL = "SELECT DISTINCT LastName, FirstName, MRN, '' AS SubjectID, tbPatient.PatientID "
                ElseIf rbFindPt2.Checked Then 'MRN               
                    strSQL = "SELECT DISTINCT MRN, LastName, FirstName, '' AS SubjectID, tbPatient.PatientID "
                ElseIf rbFindPt3.Checked Then 'SubjectID              
                    strSQL = "SELECT DISTINCT SubjectID, LastName, FirstName, MRN, tbPatient.PatientID "
                End If
                strSQL = strSQL & strFROM & strWhere

            Case Else
                Select Case ValueSelected
                    Case 1 'HPV  
                        If rbFindPt1.Checked Or rbFindPt2.Checked Then
                            If rbFindPt1.Checked Then 'LastName              
                                strSQL = "SELECT LastName, FirstName, MRN, '' AS SubjectID, A.PatientID "
                            ElseIf rbFindPt2.Checked Then 'MRN               
                                strSQL = "SELECT MRN, LastName, FirstName, '' AS SubjectID, A.PatientID "
                            End If

                            strSQL = strSQL & _
                                         "FROM " & _
                                         "(SELECT DISTINCT PatientID FROM tbStuHpvEpisode) AS A " & _
                                         "LEFT JOIN tbPatient ON A.PatientID = tbPatient.PatientID " & _
                                         "WHERE tbPatient.Gender='F' "
                        ElseIf rbFindPt3.Checked Then 'SubjectID              
                            strSQL = "SELECT DISTINCT SubjectID, LastName, FirstName, MRN, tbPatient.PatientID " & _
                                     "FROM tbStuHpvEpisode LEFT JOIN tbPatient ON tbStuHpvEpisode.PatientID = tbPatient.PatientID WHERE  tbPatient.Gender='F' or tbPatient.Gender='M' "
                        End If
                    Case 2 'STUDY2 MAIL
                        If rbFindPt1.Checked Or rbFindPt2.Checked Then
                            If rbFindPt1.Checked Then 'LastName              
                                strSQL = "SELECT LastName, FirstName, MRN, '' AS SubjectID, A.PatientID "
                            ElseIf rbFindPt2.Checked Then 'MRN               
                                strSQL = "SELECT MRN, LastName, FirstName, '' AS SubjectID, A.PatientID "
                            End If

                            strSQL = strSQL & _
                                         "FROM " & _
                                         "(SELECT DISTINCT PatientID FROM tbStuHpvEpisode) AS A " & _
                                         "LEFT JOIN tbPatient ON A.PatientID = tbPatient.PatientID " & _
                                         "WHERE tbPatient.Gender='M' "

                        ElseIf rbFindPt3.Checked Then 'SubjectID              
                            strSQL = "SELECT DISTINCT SubjectID, LastName, FirstName, MRN, tbPatient.PatientID " & _
                                     "FROM tbStuHpvEpisode LEFT JOIN tbPatient ON tbStuHpvEpisode.PatientID = tbPatient.PatientID WHERE tbPatient.Gender='M' "
                        End If
                    Case Else
                        lvw0.Items.Clear()
                        ShowLvwEditButtons(lvw0, btnEditPat, btnDelPat)
                        reset_lblNoPatients()
                        Exit Sub
                End Select
        End Select

        If rbFindPt1.Checked Then 'LastName
            strSQL = strSQL & _
                     " ORDER BY LastName, FirstName"
        ElseIf rbFindPt2.Checked Then 'MRN
            strSQL = strSQL & _
                     " ORDER BY MRN"
        ElseIf rbFindPt3.Checked Then 'SubjectID
            If vb.Left(TextSelected, 12) = "All patients" Then
                strSQL = strSQL & _
                     " ORDER BY LastName, FirstName"
            Else
                strSQL = strSQL & _
                     " ORDER BY SubjectID"
            End If
        End If

        Call Fill_lvw(Me.lvw0, strSQL)
        ShowLvwEditButtons(lvw0, btnEditPat, btnDelPat)
        reset_lblNoPatients()

    End Sub

    Private Sub reset_lblNoPatients()
        If Me.lvw0.Items.Count > 0 Then
            grpSearchBy.Visible = True
            lvw0.Visible = True
            'lvw0.Focus() 'shouldn't be here
            Tab1.Visible = True
            lblNoPatients.Visible = False
        Else
            grpSearchBy.Visible = False
            lvw0.Visible = False
            Tab1.Visible = False
            lblNoPatients.Visible = True
            lblNoPatients.Text = "There are no patients for the selected group '" & _
                                    Me.cboStudy.Text
            Select Case UCase(cboStudy.SelectedItem.ToString)
                Case "HPV PATIENTS TO FOLLOW UP", "HPV (DOB)"
                    lblNoPatients.Text = lblNoPatients.Text & "' based on the dates you sepecified."
                Case Else
                    lblNoPatients.Text = lblNoPatients.Text & "'.  Click the 'Add' button to add a new patient."
            End Select
        End If
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessageA")> _
    Private Shared Function ListViewColumnOrder(ByVal hwnd As Integer, ByVal Msg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
    End Function


    'Sub to change order of columns

    Public Sub SetColumnOrder(ByVal ListViewToReorder As ListView, ByVal SortOrder As Integer())
        If SortOrder.Length < 1 Then Exit Sub
        If SortOrder.Length > ListViewToReorder.Columns.Count Then
            Exit Sub
        End If

        Dim liSetColumnOrderArray As Integer = LVM_SETCOLUMNORDERARRAY
        Dim liSuccess As Integer
        liSuccess = ListViewColumnOrder(lvw0.Handle.ToInt32, liSetColumnOrderArray, SortOrder.Length, SortOrder(0))
        If Not liSuccess.Equals(0) Then
            lvw0.Refresh()
        End If
    End Sub

    Private Sub btnEditPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPat.Click

        If lvw0.SelectedItems.Count > 0 Then
            'Try
            'xLvwIdx = lvwHpvVst.SelectedItems(0).Index
            If vfrmPatientEdit Is Nothing Then
                vfrmPatientEdit = New frmPatientEdit
                With vfrmPatientEdit
                    Dim conn As New OleDbConnection(strConn)
                    .ada1SelectComm.Connection = conn
                    .ada1SelectComm.CommandText = _
                    "SELECT * FROM tbPatient WHERE PatientID=" & _
                    lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
                    .ada1.Fill(.ds.tbPatient)
                    .Text = "Editing patient . . ."
                    .ShowDialog()
                End With
            End If
            'Catch ex As System.Exception
            'MsgBox(ex.Message)
            'End Try
        Else
            MsgBox("Please select a desired patient from the Patient list to edit.", MsgBoxStyle.Information)
            lvwHpvVst.Focus()
        End If

    End Sub

    Private Sub btnDelPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelPat.Click

        If lvw0.SelectedItems.Count > 0 Then
            If MsgBox("Are you sure you want to delete patient '" & _
                       lvw0.SelectedItems(0).SubItems(1).Text & " " & lvw0.SelectedItems(0).Text & _
                       "' with MRN '" & lvw0.SelectedItems(0).SubItems(2).Text & _
                       "'?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                RunSQL("DELETE * FROM tbPatient " & _
                       "WHERE PatientID=" & lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text)
                Call Fill_lvw0()
                Update_Tab1()
            End If
        Else
            MsgBox("Please select a patient from the Patient list to delete.", MsgBoxStyle.Information)
            lvw0.Focus()
        End If

    End Sub

    Private Sub btnAddHpvVst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHpvVst.Click
        With Me.lvwHpvEpi
            If UCase(.SelectedItems(0).SubItems(2).Text) <> "Y" And UCase(.SelectedItems(0).SubItems(2).Text) <> "YNT" Then
                If MsgBox("The selected episode is NOT eligible for HPV. Do you still want to add a new visit to it?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            '* YOU CAN NOW HAVE AN UNLIMITED NUMBER OF VISITS            
            If Me.lvwHpvVst.Items.Count > 0 Then
                Dim i As Int16 = 0
                Dim StatusText As String = ""
                Dim VisitCnt As Int16 = 0
                For i = 0 To Me.lvwHpvVst.Items.Count - 1
                    StatusText = UCase(Trim(Me.lvwHpvVst.Items(i).SubItems(3).Text))
                    If StatusText = "COMPLETED" Or StatusText = "SKIPPED" Then
                        VisitCnt += 1
                    End If
                Next i

                Dim EpisodeTypeID As String = lvwHpvEpi.SelectedItems(0).SubItems(lvwHpvEpi.Columns.Count - 2).Text
                If VisitCnt = HPVNUMBEROFVISITS And EpisodeTypeID <> "2" Then
                    MsgBox("Subject ID '" & .SelectedItems(0).SubItems(1).Text & "' " & _
                           "already reaches the maximum # of visits allowed.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
        End With

        If vfrmStuHpvPatVisitEdit Is Nothing Then
            vfrmStuHpvPatVisitEdit = New frmStuHpvPatVisitEdit
            With vfrmStuHpvPatVisitEdit
                '.conn.ConnectionString = strConn
                '.ada1SelectComm.CommandText = "SELECT * FROM tbStuHpvPatVisit"
                '.ada1.Fill(.ds.tbStuHpvPatVisit)
                '.BindingContext(.ds, "tbStuHpvPatVisit").AddNew() 'Need this!
                '.txtPatientID.Text = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
                .Text = "Adding a new visit . . ."
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnEditHpvVst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditHpvVst.Click
        If lvwHpvVst.SelectedItems.Count > 0 Then
            'Try
            'xLvwIdx = lvwHpvVst.SelectedItems(0).Index
            If vfrmStuHpvPatVisitEdit Is Nothing Then
                vfrmStuHpvPatVisitEdit = New frmStuHpvPatVisitEdit
                With vfrmStuHpvPatVisitEdit
                    'Dim conn As New OleDbConnection(strConn)
                    '.ada1SelectComm.Connection = conn
                    '.ada1SelectComm.CommandText = _
                    '"SELECT * FROM tbStuHpvPatVisit WHERE VisitID=" & _
                    'lvwHpvVst.SelectedItems(0).SubItems(lvwHpvVst.Columns.Count - 1).Text
                    '.ada1.Fill(.ds.tbStuHpvPatVisit)
                    '.Text = "Editing RIS visit . . ."
                    Dim lvItem As ListViewItem = Me.lvwHpvVst.SelectedItems(0)

                    .Tag = (lvItem.SubItems(6).Text)



                    .ShowDialog()
                End With
            End If
            'Catch ex As System.Exception
            'MsgBox(ex.Message)
            'End Try
        Else
            MsgBox("Please select a desired visit from the Visit list to edit.", MsgBoxStyle.Information)
            lvwHpvVst.Focus()
        End If
    End Sub

    Private Sub btnDelHpvVst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelHpvVst.Click

        'MsgBox(LvwMax(lvwHpvVst, "date", 2))
        'Exit Sub

        With lvwHpvVst
            If .SelectedItems.Count > 0 Then
                If MsgBox("Are you sure you want to delete visit # " & _
                          .SelectedItems(0).SubItems(1).Text & " from Subject ID '" & _
                           Me.lvwHpvEpi.SelectedItems(0).SubItems(1).Text & "' ?" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & _
                           "Note that if you delete this visit, ALL data related to " & _
                           "this visit will also be deleted.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    RunSQL("DELETE * FROM tbStuHpvPatVisit " & _
                           "WHERE VisitID=" & .SelectedItems(0).SubItems(.Columns.Count - 1).Text)
                    Update_tabHpv()
                End If
            Else
                MsgBox("Please select a desired visit from the Visit list to delete.", MsgBoxStyle.Information)
                .Focus()
            End If
        End With

    End Sub

    Private Sub lvwHpvVst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwHpvVst.Click
        lvwHpvVstXSelectedIndex = lvwHpvVst.SelectedItems(0).Index '
        Update_tabHpvVst()
    End Sub

    Private Sub lvwHpvVst_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwHpvVst.KeyUp
        lvwHpvVst_Click(sender, e)
    End Sub

    Private Sub lvw_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) _
      Handles lvw0.ColumnClick, lvwHpvVstFormPF.ColumnClick, lvwHpvVstFormR.ColumnClick, lvwHpvVstProc.ColumnClick, lvwHpvVstSpec.ColumnClick, lvwHpvVstVac.ColumnClick, lvwHpvCtHx.ColumnClick

        Dim lvw As ListView = CType(FindControl(Me, sender.name), ListView)
        SortLvw(lvw, e.Column)

    End Sub

    Private Sub tabHpvVst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabHpvVst.Click
        Update_tabHpvVst()
    End Sub

    Private Sub lvw_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles lvw0.DoubleClick, lvwHpvVst.DoubleClick, lvwHpvEpi.DoubleClick, lvwHpvCtHx.DoubleClick
        Select Case sender.name
            Case "lvw0"
                btnEditPat_Click(sender, e)
            Case "lvwHpvVst"
                btnEditHpvVst_Click(sender, e)
            Case "lvwHpvEpi"
                btnEditHpvEpi_Click(sender, e)
            Case "lvwHpvCtHx"
                'btnEditHpvCtHx_Click(sender, e)
        End Select
    End Sub

    Private Sub chkRace_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles chkRace1.Click, chkRace2.Click, chkRace3.Click, chkRace4.Click, chkRace5.Click, chkRace6.Click
        'If FormActivated Then
        'If Me.ActiveControl.Name = sender.name Then
        FillCheckBoxGroup(Me, Me.txtRace.Text, "chkRace", 6)
        'End If
        'End If
    End Sub

    Private Sub rbEthnicity_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rbEthnicity1.Click, rbEthnicity2.Click, rbEthnicity3.Click
        FillRadioButtonGroup(Me, Me.txtEthnicity.Text, "rbEthnicity", 3)
    End Sub

    Private Sub chkCi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCiCanMailReminder.Click, chkCiCanTextMessage.Click
        Select Case sender.name
            Case "chkCiCanMailReminder"
                Me.chkCiCanMailReminder.Checked = booCiCanMailReminder
            Case "chkCiCanTextMessage"
                Me.chkCiCanTextMessage.Checked = booCiCanTextMessage
        End Select
    End Sub

    Private Sub btnDeleteCts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles btnDeleteCtsSlf.Click, btnDeleteCtsFrd1.Click, btnDeleteCtsFrd2.Click

        Try
            Dim MsgText As String, strSQL As String
            Dim PatientID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
            MsgText = "Are you sure you want to delete all contact info including the contact methods"
            Select Case sender.name
                Case "btnDeleteCtsSlf"
                    MsgText = MsgText & " from patient '"
                    strSQL = "DELETE * FROM tbPatientContactInfo " & _
                             "WHERE PatientID=" & PatientID
                Case "btnDeleteCtsFrd1", "btnDeleteCtsFrd2"
                    Dim FriendNum As Byte
                    Select Case sender.name
                        Case "btnDeleteCtsFrd1"
                            FriendNum = 1
                        Case "btnDeleteCtsFrd2"
                            FriendNum = 2
                    End Select
                    MsgText = MsgText & " of friend #" & FriendNum & " from patient '"
                    strSQL = "DELETE * FROM tbPatientContactInfoFriend " & _
                             "WHERE PatientID=" & PatientID & " AND " & _
                             "FriendNum=" & FriendNum
            End Select

            If MsgBox(MsgText & lvw0.SelectedItems(0).SubItems(1).Text & " " & lvw0.SelectedItems(0).Text & _
                       "'?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                RunSQL(strSQL)
                Update_tabCts()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnEditPatCts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            If vfrmPatCtsEdit Is Nothing Then
                vfrmPatCtsEdit = New frmPatCtsEdit
                With vfrmPatCtsEdit
                    If Me.btnEditCtsSlf.Text = "Edit" Then
                        Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
                        Dim conn As New OleDbConnection(strConn)
                        '.da1SelectComm.Connection = conn
                        '.da1SelectComm.CommandText = _
                        '"SELECT * FROM tbPatientContactInfo WHERE PatientID=" & PatID
                        '.da1.Fill(.ds.tbPatientContactInfo)
                        '.Text = "Editing patient contact info . . ."

                        .da_Address_SelectComm.Connection = conn
                        .da_Address_SelectComm.CommandText = _
                        "SELECT * FROM tbContactAddress WHERE ContactOwnerCd=1 AND PatientID=" & PatID
                        .da_Address.Fill(.ds.tbContactAddress)

                        .da_Phone_SelectComm.Connection = conn
                        .da_Phone_SelectComm.CommandText = _
                        "SELECT * FROM tbContactPhone WHERE PhoneTypeCd=1 AND ContactOwnerCd=1 AND PatientID=" & PatID
                        .da_Phone.Fill(.ds.tbContactPhoneHome)

                        .da_Phone_SelectComm.CommandText = _
                        "SELECT * FROM tbContactPhone WHERE PhoneTypeCd=2 AND ContactOwnerCd=1 AND PatientID=" & PatID
                        .da_Phone.Fill(.ds.tbContactPhoneCell)

                        .Text = "Editing patient contact info . . ."

                    Else
                        .Text = "Adding patient contact info . . ."
                    End If
                    .ShowDialog()
                End With
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnEditCtsFrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnEditCtsSlf.Click, btnEditCtsFrd1.Click, btnEditCtsFrd2.Click

        Try

            If vfrmPatCtsFrdEdit Is Nothing Then
                vfrmPatCtsFrdEdit = New frmPatCtsFrdEdit

                With vfrmPatCtsFrdEdit
                    Dim FormText As String, ContactOwnerCd As Byte

                    Dim btn As Button = CType(FindControl(Me, sender.name), Button)
                    ContactOwnerCd = tabCts.SelectedIndex + 1
                    If btn.Text = "Edit" Then
                        If ContactOwnerCd = 1 Then
                            FormText = "Editing patient contact info" & " . . ."
                        Else
                            FormText = "Editing contact info of patient's friend #" & tabCts.SelectedIndex & " . . ."
                        End If
                    Else
                        If ContactOwnerCd = 1 Then
                            FormText = "Adding contact info to patient" & " . . ."
                        Else
                            FormText = "Adding contact info to patient's friend #" & tabCts.SelectedIndex & " . . ."
                        End If
                    End If

                    If btn.Text = "Edit" Then
                        'Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
                        'Dim conn As New OleDbConnection(strConn)
                        '.da_tbContact_SelectComm.Connection = conn
                        '.da_tbContact_SelectComm.CommandText = _
                        '"SELECT * FROM tbContact " & _
                        '"WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd
                        '.da_tbContact.Fill(.ds.tbContact)

                        'If ContactOwnerCd = 1 Then 'patient
                        '.da_tbContactAddress_SelectComm.Connection = conn
                        '.da_tbContactAddress_SelectComm.CommandText = _
                        '"SELECT * FROM tbContactAddress " & _
                        '"WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd
                        '.da_tbContactAddress.Fill(.ds.tbContactAddress)
                        'End If
                    End If
                    .Text = FormText

                    .ShowDialog()
                End With

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lvw_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles lvw0.LostFocus, lvwHpvEpi.LostFocus, lvwHpvVst.LostFocus
        'make sure there always is an item selected
        Try
            Select Case sender.name
                Case "lvw0"
                    With lvw0
                        If .Items.Count > 0 And .SelectedItems.Count = 0 Then
                            .Items(lvw0XSelectedIndex).Selected = True
                        End If
                    End With
                Case "lvwHpvEpi"
                    With lvwHpvEpi
                        If .Items.Count > 0 And .SelectedItems.Count = 0 Then
                            .Items(lvwHpvEpiXSelectedIndex).Selected = True
                        End If
                    End With
                Case "lvwHpvVst"
                    With lvwHpvVst
                        If .Items.Count > 0 And .SelectedItems.Count = 0 Then
                            .Items(lvwHpvVstXSelectedIndex).Selected = True
                        End If
                    End With
            End Select
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lvwHpvEpi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwHpvEpi.Click

        lvwHpvEpiXSelectedIndex = lvwHpvEpi.SelectedItems(0).Index '
        Update_tabHpv()

    End Sub

    Private Sub lvwHpvEpi_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwHpvEpi.KeyUp
        lvwHpvEpi_Click(sender, e)
    End Sub

    Private Sub btnAddHpvEpi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHpvEpi.Click
        Dim IsExtension As Boolean = False

        If AllowNewEpisode(IsExtension) Then
            If vfrmStuHpvEpiEdit Is Nothing Then
                vfrmStuHpvEpiEdit = New frmStuHpvEpiEdit
                With vfrmStuHpvEpiEdit
                    Dim itemInGrid As Int32 = lvwHpvEpi.Items.Count
                    .Text = "Adding a new HPV episode . . ."

                    '* USE the form tag to tell the form if the new episode is an extension or not
                    If IsExtension Then
                        If itemInGrid = 2 Then
                            .Tag = 3
                        ElseIf itemInGrid = 1 Then
                            .Tag = 2
                        End If
                    Else
                        .Tag = 1
                    End If

                    .ShowDialog()
                End With
            End If
        Else
            MsgBox("A new HPV episode CANNOT be added because there is at least one ELIGIBLE HPV episode and HPV Extension for the selected patient.", vbOKOnly + vbInformation)
        End If

    End Sub

    Private Sub btnEditHpvEpi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditHpvEpi.Click
        If lvwHpvEpi.SelectedItems.Count > 0 Then
            Try
                'xLvwIdx = lvwHpvVst.SelectedItems(0).Index
                If vfrmStuHpvEpiEdit Is Nothing Then
                    vfrmStuHpvEpiEdit = New frmStuHpvEpiEdit
                    With vfrmStuHpvEpiEdit
                        Dim conn As New OleDbConnection(strConn)
                        .ada1SelectComm.Connection = conn
                        .ada1SelectComm.CommandText = _
                          "SELECT * FROM tbStuHpvEpisode WHERE EpisodeID=" & _
                          lvwHpvEpi.SelectedItems(0).SubItems(lvwHpvEpi.Columns.Count - 1).Text
                        .ada1.Fill(.DS.tbStuHpvEpisode)
                        .Text = "Editing HPV episode . . ."
                        .ShowDialog()
                    End With
                End If
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please select a desired episode from the HPV episode list to edit.", MsgBoxStyle.Information)
            lvwHpvEpi.Focus()
        End If
    End Sub

    Private Sub btnDelHpvEpi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelHpvEpi.Click
        With lvwHpvEpi
            If .SelectedItems.Count > 0 Then
                If MsgBox("Are you sure you want to delete the selected HPV episode with Subject ID '" & _
                          .SelectedItems(0).SubItems(1).Text & "'?" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & _
                           "Note that if you delete this episode, " & _
                           "ALL data such as patient visits, screening form, that are associated with " & _
                           "this episode will also be deleted.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    RunSQL("DELETE * FROM tbStuHpvEpisode " & _
                           "WHERE EpisodeID=" & .SelectedItems(0).SubItems(.Columns.Count - 1).Text)
                    Update_Tab1()
                End If
            Else
                MsgBox("Please select a desired episode from the HPV episode list to delete.", MsgBoxStyle.Information)
                .Focus()
            End If
        End With
    End Sub

    Private Function AllowNewEpisode(ByRef IsExtension As Boolean) As Boolean

        Try
            AllowNewEpisode = True

            Dim itemInGrid As Int32 = lvwHpvEpi.Items.Count 'check item in grid 

            If (itemInGrid >= 3) Then
                Return False
                Exit Function
            End If

            Dim MyDR As DataRow() = Nothing
            Dim FoundHPVEligible As Boolean = False
            Dim FoundHPVExtensionEligible As Boolean = False
            Dim Mydt As RIS.DataSet1.tbStuHpvEpisodeDataTable = New RIS.DataSet1.tbStuHpvEpisodeDataTable
            Me.TbStuHpvEpisodeTableAdapter.FillByPatient(Mydt, PatID)

            If Not Mydt Is Nothing Then
                If Mydt.Rows.Count > 0 Then
                    '* Check if eligible hpv study exists
                    MyDR = Mydt.Select("EpisodeType=1 AND Eligible='Y'")
                    If MyDR.Length > 0 Then
                        FoundHPVEligible = True
                    End If

                    '* Check if eligible hpv extension study exists
                    MyDR = Mydt.Select("EpisodeType=2 AND Eligible='Y'")
                    If MyDR.Length > 1 Then
                        FoundHPVExtensionEligible = True
                    End If

                    '* Check if eligible hpv extension study exists
                    MyDR = Mydt.Select("EpisodeType=3 AND Eligible='Y'")
                    If MyDR.Length > 2 Then
                        FoundHPVExtensionEligible = True
                    End If


                    '* found eligible hpv so the next should be an extension
                    IsExtension = FoundHPVEligible

                    If FoundHPVEligible And FoundHPVExtensionEligible Then
                        AllowNewEpisode = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'AllowNewEpisode = True

        'With Me.lvwHpvEpi
        '    If .Items.Count = 0 Then Exit Function
        '    For i As Short = 0 To .Items.Count - 1
        '        If UCase(.Items(i).SubItems(2).Text) = "Y" Then 'Check the Eligible column
        '            AllowNewEpisode = False
        '            Exit Function
        '        End If
        '    Next
        'End With
    End Function

    Private Sub rbScrFrm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles rbScrFrmYes1.Click, rbScrFrmNo1.Click, rbScrFrmYes2.Click, rbScrFrmNo2.Click, rbScrFrmYes3.Click, rbScrFrmNo3.Click, rbScrFrmYes4.Click, rbScrFrmNo4.Click, rbScrFrmYes5.Click, rbScrFrmNo5.Click, rbScrFrmYes6.Click, rbScrFrmNo6.Click, rbScrFrmYes8.Click, rbScrFrmNo8.Click
        Select Case sender.name
            Case "rbScrFrmYes1", "rbScrFrmNo1"
                FillRBYesNo(Me.grpHpvSfSexuallyActive.Tag, rbScrFrmYes1, rbScrFrmNo1)
            Case "rbScrFrmYes2", "rbScrFrmNo2"
                FillRBYesNo(Me.grpHpvSfCurrentlyPregnant.Tag, rbScrFrmYes2, rbScrFrmNo2)
            Case "rbScrFrmYes3", "rbScrFrmNo3"
                FillRBYesNo(Me.grpHpvSfThoughtPregnant.Tag, rbScrFrmYes3, rbScrFrmNo3)
            Case "rbScrFrmYes4", "rbScrFrmNo4"
                FillRBYesNo(Me.grpHpvSfHasPeriod.Tag, rbScrFrmYes4, rbScrFrmNo4)
            Case "rbScrFrmYes5", "rbScrFrmNo5"
                FillRBYesNo(Me.grpHpvSfHPVvaccinated.Tag, rbScrFrmYes5, rbScrFrmNo5)
            Case "rbScrFrmYes6", "rbScrFrmNo6"
                FillRBYesNo(Me.grpHpvSfWantHPVvaccine.Tag, rbScrFrmYes6, rbScrFrmNo6)
                'Case "rbScrFrmYes7", "rbScrFrmNo7"
                '    FillRBYesNo(Me.grpHpvSfEndPregnancy.Tag, rbScrFrmYes7, rbScrFrmNo7)
            Case "rbScrFrmYes8", "rbScrFrmNo8"
                FillRBYesNo(Me.grpHpvSfPlanToLeaveNYC.Tag, rbScrFrmYes8, rbScrFrmNo8)
        End Select
    End Sub

    Private Sub chkScrFrm1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles chkScrFrm1_1.Click, chkScrFrm1_2.Click
        FillCheckBoxGroup(Me, Me.grpHpvSfSexualActType.Tag, "chkScrFrm1_", 2)
    End Sub

    Private Sub btnEditScrnForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditScrnForm.Click
        Try
            If vfrmStuHpvScrnFrmEdit Is Nothing Then
                vfrmStuHpvScrnFrmEdit = New frmStuHpvScrnFrmEdit
                With vfrmStuHpvScrnFrmEdit
                    .Gender = Me.PatientGender
                    If Me.btnEditScrnForm.Text = "Edit" Then
                        Dim EpiID As Integer = lvwHpvEpi.SelectedItems(0).SubItems(lvwHpvEpi.Columns.Count - 1).Text
                        Dim conn As New OleDbConnection(strConn)

                        Dim MyDA As DataSet1TableAdapters.tbStuHpvScreeningFormTableAdapter = New DataSet1TableAdapters.tbStuHpvScreeningFormTableAdapter
                        MyDA.Connection = conn
                        MyDA.FillByEpisodeID(.ds.tbStuHpvScreeningForm, EpiID)

                        '.da1SelectComm.Connection = conn
                        '.da1SelectComm.CommandText = _
                        '"SELECT * FROM tbStuHpvScreeningForm WHERE EpisodeID=" & EpiID
                        '.da1.Fill(.ds.tbStuHpvScreeningForm)
                        .Text = "Editing HPV screening form . . ."
                    Else
                        .Text = "Adding HPV screening form . . ."
                    End If
                    .ShowDialog()
                End With
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelScrnForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelScrnForm.Click
        Try
            Dim EpiID As Integer = lvwHpvEpi.SelectedItems(0).SubItems(lvwHpvEpi.Columns.Count - 1).Text
            If MsgBox("Are you sure you want to delete the HPV Screening Form from Subject ID '" & _
                       Me.lvwHpvEpi.SelectedItems(0).SubItems(1).Text & "' ?" _
                       , MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                RunSQL("DELETE * FROM tbStuHpvScreeningForm WHERE EpisodeID=" & EpiID)
                Update_tabHpv()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '* SEPT 1, 2008. DO NOT ALLOW EDIT OF BLOOD INFO FROM THE PATIENT FORM
    'Private Sub btnEditHpvBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditHpvBlood.Click    
    'Try
    '    If vfrmStuHpvBloodEdit Is Nothing Then
    '        vfrmStuHpvBloodEdit = New frmStuHpvBloodEdit
    '        With vfrmStuHpvBloodEdit
    '            If Me.btnEditHpvBlood.Text = "Edit" Then
    '                Dim EpiID As Integer = lvwHpvEpi.SelectedItems(0).SubItems(lvwHpvEpi.Columns.Count - 1).Text
    '                Dim conn As New OleDbConnection(strConn)
    '                .da1SelectComm.Connection = conn
    '                .da1SelectComm.CommandText = _
    '                "SELECT * FROM tbStuHpvPatVisitBlood WHERE VisitProcActID=" & txtHpvBloodVisitProcActID.Text
    '                .da1.Fill(.ds.tbStuHpvPatVisitBlood)
    '                .Text = "Editing blood specimen info . . ."
    '            Else
    '                .Text = "Adding blood specimen info . . ."
    '            End If
    '            .ShowDialog()
    '        End With
    '    End If

    'Catch ex As System.Exception
    '    MsgBox(ex.Message)
    'End Try
    'End Sub

    '* SEPT 1, 2008. DO NOT ALLOW DELETE OF BLOOD INFO FROM THE PATIENT FORM
    'Private Sub btnDelHpvBlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelHpvBlood.Click
    '    Try
    '        If MsgBox("Are you sure you want to delete the Blood info from visit # " & _
    '                  Me.lvwHpvVst.SelectedItems(0).SubItems(1).Text & "?" _
    '                   , MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
    '            RunSQL("DELETE * FROM tbStuHpvPatVisitBlood WHERE VisitProcActID=" & _
    '                   txtHpvBloodVisitProcActID.Text)
    '            Update_tabHpvVst()
    '        End If
    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub MySpaceURL_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim txtMySpaceURL As TextBox = CType(FindControl(Me, sender.name), TextBox)
        If vb.Len(vb.Trim(txtMySpaceURL.Text)) > 0 Then
            If UCase(vb.Left(txtMySpaceURL.Text, 4)) <> "WWW." Then
                ShellExecuteA(Me.Handle, "open", "www." & txtMySpaceURL.Text, "", "", 4)
            Else
                ShellExecuteA(Me.Handle, "open", txtMySpaceURL.Text, "", "", 4)
            End If
        Else
            MsgBox("There is NO URL in this field!", vbOKOnly + vbInformation)
        End If
    End Sub

    Private Sub Email_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim txtEmail As TextBox = CType(FindControl(Me, sender.name), TextBox)
        If vb.Len(vb.Trim(txtEmail.Text)) > 0 Then
            ShellExecuteA(Me.Handle, "open", "mailto:" & txtEmail.Text, "", "", 1)
        Else
            MsgBox("There is NO email address in this field!", vbOKOnly + vbInformation)
        End If
    End Sub

    Private Sub txt_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs)
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    ' SEPT 1, 2008 - REMOVE ABILITY TO ALTER CONTACT HX FROM THE PATIENT FORM
    'Private Sub btnAddHpvCtHx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHpvCtHx.Click
    '    If vfrmStuHpvCtHxEdit Is Nothing Then
    '        vfrmStuHpvCtHxEdit = New frmStuHpvCtHxEdit
    '        With vfrmStuHpvCtHxEdit
    '            .Text = "Adding a new contact hx . . ."
    '            .ShowDialog()
    '        End With
    '    End If
    'End Sub

    ' SEPT 1, 2008 - REMOVE ABILITY TO ALTER CONTACT HX FROM THE PATIENT FORM
    'Private Sub btnEditHpvCtHx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditHpvCtHx.Click
    '    With lvwHpvCtHx
    '        If .SelectedItems.Count > 0 Then
    '            Try
    '                'xLvwIdx = lvwHpvVst.SelectedItems(0).Index
    '                If vfrmStuHpvCtHxEdit Is Nothing Then
    '                    vfrmStuHpvCtHxEdit = New frmStuHpvCtHxEdit
    '                    With vfrmStuHpvCtHxEdit
    '                        .ShowDialog()
    '                    End With
    '                End If
    '            Catch ex As System.Exception
    '                MsgBox(ex.Message)
    '            End Try
    '        Else
    '            MsgBox("Please select a desired item from the HPV contact hx list to edit.", MsgBoxStyle.Information)
    '            .Focus()
    '        End If
    '    End With
    'End Sub

    ' SEPT 1, 2008 - REMOVE ABILITY TO ALTER CONTACT HX FROM THE PATIENT FORM
    'Private Sub btnDelHpvCtHx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelHpvCtHx.Click
    '    With lvwHpvCtHx
    '        If .SelectedItems.Count > 0 Then
    '            If MsgBox("Are you sure you want to delete the selected contact hx?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
    '                RunSQL("DELETE * FROM tbStuHpvPatVisitContactHx WHERE ContactID=" & _
    '                        vfrmPatient.lvwHpvCtHx.SelectedItems(0).SubItems(vfrmPatient.lvwHpvCtHx.Columns.Count - 1).Text)
    '                Update_tabHpvVst()
    '            End If
    '        Else
    '            MsgBox("Please select a desired item from the HPV contact hx list to delete.", MsgBoxStyle.Information)
    '            .Focus()
    '        End If
    '    End With
    'End Sub

    Private Sub tbRefreshLvw0_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbRefreshLvw0.ButtonClick
        Select Case tbRefreshLvw0.Buttons.IndexOf(e.Button)
            Case 0
                Call Fill_lvw0()
                Me.lvw0.Focus()
                Update_Tab1()
        End Select
    End Sub

    Private Sub dtsHPVvstDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
          Handles dtsHPVvstDate1.TextChanged, dtsHPVvstDate2.TextChanged
        If FormActivated Then
            If sender.name = "dtsHPVvstDate1" Then Me.dtsHPVvstDate2.MinDate = Me.dtsHPVvstDate1.Value
            Fill_lvw0()
            Update_Tab1()
        End If
    End Sub
    Private Sub dtsHPVvstDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles dtsHPVvstDate1.CheckedChanged, dtsHPVvstDate2.CheckedChanged
        If FormActivated Then
            Fill_lvw0()
            Update_Tab1()
        End If
    End Sub

    Friend Sub Fill_lvwHpvEpiFU()

        Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text

        Dim strDateRange As String = "", strFROM As String, strWhere As String
        If Me.dtsHPVvstDate1.Checked = True And Me.dtsHPVvstDate2.Checked = False Then
            strDateRange = " AND tbStuHpvPatVisit.VisitDate >= #" & _
              Me.dtsHPVvstDate1.Value & "# "
        ElseIf Me.dtsHPVvstDate1.Checked = False And Me.dtsHPVvstDate2.Checked = True Then
            strDateRange = " AND tbStuHpvPatVisit.VisitDate <= #" & _
              Me.dtsHPVvstDate2.Value & "# "
        ElseIf Me.dtsHPVvstDate1.Checked = True And Me.dtsHPVvstDate2.Checked = True Then
            strDateRange = " AND tbStuHpvPatVisit.VisitDate BETWEEN #" & _
              Me.dtsHPVvstDate1.Value & "# AND #" & Me.dtsHPVvstDate2.Value & "# "
        End If

        Dim strSQL As String
        strSQL = "SELECT tbStuHpvEpisode.EpisodeID, VisitID,  tbStuHpvEpisode.PatientID " & _
                 "FROM tbStuHpvEpisode INNER JOIN tbStuHpvPatVisit ON tbStuHpvEpisode.EpisodeID = tbStuHpvPatVisit.EpisodeID " & _
                 "WHERE PatientID=" & PatID & " AND ApptStatusCd In (1,3)" & strDateRange

        Fill_lvw(lvwHpvEpiFU, strSQL, , False)

    End Sub

    Private Sub rtbCtsSlf_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles rtbCtsSlf.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub AddTabsTo_tabContactInfo()

        With tabContactInfo
            .Height = 628
            .SizeMode = TabSizeMode.Fixed
        End With

        Dim conn As New OleDbConnection(strConn)
        Dim reader As OleDbDataReader, cmd As OleDbCommand

        Dim strSQL As String = _
            "SELECT ContactOwnerDesc, ContactOwnerCd FROM ddvContactOwner " & _
            "WHERE Active<0 ORDER BY DisplayOrder"
        conn.Open()
        cmd = New OleDbCommand(strSQL, conn)
        reader = cmd.ExecuteReader()
        With reader
            If .HasRows Then
                Do While .Read()
                    Dim tp As New TabPage
                    tp.Text = .Item(0)
                    tp.Text = tp.Text.Trim 'this only centers the text
                    tp.Tag = .Item(1)
                    tabContactInfo.TabPages.Add(tp)
                Loop
            End If
            .Close()
        End With
        conn.Close()

    End Sub

    Private Sub tabContactInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabContactInfo.Click
        Update_tabContactInfo()
    End Sub

    Private Sub rtbContactInfo_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles rtbContactInfo.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub btnEditContactInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditContactInfo.Click
        Try

            If vfrmPatCtsFrdEdit Is Nothing Then
                vfrmPatCtsFrdEdit = New frmPatCtsFrdEdit

                With vfrmPatCtsFrdEdit
                    Dim FormText As String
                    Dim ContactOwnerCd As Byte = Me.tabContactInfo.SelectedTab.Tag
                    Dim ContactOwnerText As String = tabContactInfo.SelectedTab.Text

                    If btnEditContactInfo.Text = "Edit" Then
                        If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then
                            FormText = "Editing contact info of the selected patient . . ."
                        Else
                            FormText = "Editing " & ContactOwnerText & "'s contact info of the selected patient . . ."
                        End If
                    Else
                        If ContactOwnerCd = 1 Then
                            FormText = "Adding contact info to the selected patient . . ."
                        Else
                            FormText = "Adding " & ContactOwnerText & "'s contact info to the selected patient . . ."
                        End If
                    End If
                    .Text = FormText
                    .ShowDialog()
                End With

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelContactInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelContactInfo.Click
        Try
            Dim MsgText As String, strSQL As String
            Dim PatientID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
            Dim ContactOwnerCd As Byte = Me.tabContactInfo.SelectedTab.Tag
            Dim ContactOwnerText As String = tabContactInfo.SelectedTab.Text
            Dim strWhere As String = _
                " WHERE PatientID=" & PatientID & " AND ContactOwnerCd=" & ContactOwnerCd

            MsgText = "Are you sure you want to delete ALL contact info. shown on this tab " & _
                      "including contact methods "

            If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then
                MsgText = MsgText & "from the selected patient? "
            Else
                MsgText = MsgText & "of patient's " & ContactOwnerText & " from the selected patient? "
            End If

            If MsgBox(MsgText, MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                strSQL = "DELETE * FROM tbContact " & strWhere
                RunSQL(strSQL)
                strSQL = "DELETE * FROM tbContactPhone " & strWhere
                RunSQL(strSQL)
                strSQL = "DELETE * FROM tbContactEmail " & strWhere
                RunSQL(strSQL)
                strSQL = "DELETE * FROM tbContactOnline " & strWhere
                RunSQL(strSQL)
                strSQL = "DELETE * FROM tbContactChoice " & strWhere
                RunSQL(strSQL)
                If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then
                    strSQL = "DELETE * FROM tbContactAddress " & strWhere
                    RunSQL(strSQL)
                End If
                Update_tabCts()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkHPV_Terminated_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'Dim HpvTerminated As Byte = chkHPV_Terminated.Checked * (-1)
        ''MsgBox(HpvTerminated)
        'Dim PatID As Integer = lvw0.SelectedItems(0).SubItems(lvw0.Columns.Count - 1).Text
        'Dim strSQL As String = "UPDATE tbPatient SET HPV_Terminated = -" & HpvTerminated & " WHERE PatientID=" & PatID
        'RunSQL(strSQL)

    End Sub
    Private Sub ShowAdverseEvents(ByVal VisitID As Int16)
        Try
            Me.TbStuHpvAdEventsLogTableAdapter.Connection.ConnectionString = strConn
            Me.TbStuHpvAdEventsInterventionsTableAdapter.Connection.ConnectionString = strConn
            Me.TbStuHpvAdEventsSymptomsTableAdapter.Connection.ConnectionString = strConn
            Me.TbStuHpvAdEventsLogTableAdapter.FillByTableFieldsByVisitID(Me.RiSdataDataSet.tbStuHpvAdEventsLog, VisitID)


            If Me.TbStuHpvAdEventsLogBindingSource.Position <> -1 Then
                Dim MyEventLogID As Integer = CType(CType(Me.TbStuHpvAdEventsLogBindingSource.Current, DataRowView).Row, RISdataDataSet.tbStuHpvAdEventsLogRow).AdEventsLogID

                Me.TbStuHpvAdEventsInterventionsTableAdapter.FillByAdEventsLogID(Me.RiSdataDataSet.tbStuHpvAdEventsInterventions, MyEventLogID)
                Me.TbStuHpvAdEventsSymptomsTableAdapter.FillByAdEventsLogID(Me.RiSdataDataSet.tbStuHpvAdEventsSymptoms, MyEventLogID)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSavePregnancy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePregnancy.Click, ToolStripButton1.Click
        Me.SavePregnancy()
    End Sub

    Private Sub SavePregnancy()
        Me.Validate()

        Me.grdPregnancies.EndEdit()
        Me.grdPregnancyOutcome.EndEdit()

        Me.taPregnancy.Update(Me.RiSdataDataSet)
        Me.TbPregnancyOutcomeTableAdapter.Update(Me.RiSdataDataSet)

        Me.BindPregnancyTab()

    End Sub

    Private Sub grdPregnancies_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grdPregnancies.RowsAdded
        Me.grdPregnancies.Rows(e.RowIndex).Cells(1).Value = PatID
        Me.grdPregnancies.EndEdit()
        Me.btnSavePregnancy.Enabled = True

    End Sub

    Private Sub grdPregnancies_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdPregnancies.SelectionChanged

        'Dim row As RISdataDataSet.tbPregnancyOutcomeRow
        'row = CType(Me.TbPregnancyOutcomeBindingSource.Current, DataRowView).Row
        'Me.TbPregnancyOutcomeTableAdapter.FillByPregnancyID(Me.RiSdataDataSet.tbPregnancyOutcome, row.PregnancyID)

    End Sub

    Private Sub grdPregnancies_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdPregnancies.DataError, grdPregnancyOutcome.DataError
        e.ThrowException = False

    End Sub
    Private Function ValidateCells(ByVal value As String, ByVal ColIndex As Integer, ByVal RowIndex As Integer, ByVal DataGrid As DataGridView) As Boolean
        Dim Col As DataGridViewColumn
        Dim ColName As String
        Dim ErrorText As String = String.Empty
        Dim Cancel As Boolean
        DataGrid.Rows(RowIndex).ErrorText = String.Empty

        DataGrid.Rows(RowIndex).Cells(ColIndex).ErrorText = String.Empty

        Col = DataGrid.Columns(ColIndex)
        ColName = Col.Name

        Select Case ColName
            Case Is = "colQuestCompDate", "colDateMenstrual", "colDateMenstrual", "colPregOutcomeDate"
                If Not String.IsNullOrEmpty(value) And Not IsDate(value) Then
                    Cancel = True
                    ErrorText = Col.HeaderText & " is not a recognized time."
                End If

        End Select
        DataGrid.Rows(RowIndex).ErrorText = ErrorText
    End Function

    Private Sub grid_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdPregnancies.RowValidating, grdPregnancyOutcome.RowValidating
        Dim datagrid As DataGridView = CType(sender, DataGridView)
        For Each c As DataGridViewCell In datagrid.Rows(e.RowIndex).Cells
            If Me.ValidateCells(c.FormattedValue, c.ColumnIndex, e.RowIndex, datagrid) Then
                e.Cancel = True
                Exit Sub
            End If
        Next
    End Sub


    Private Sub tabPregnancies_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tabPregnancies.Validating
        If Validation.CheckForChanges(Me.RiSdataDataSet.tbPregnancyOutcome) Or Validation.CheckForChanges(Me.RiSdataDataSet.tbPregnancy) Then
            Dim Results As DialogResult
            Results = MessageBox.Show("Changes detected. Would you like to save your changes?", "Changes Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case Results
                Case Windows.Forms.DialogResult.Yes
                    Me.SavePregnancy()

                Case Windows.Forms.DialogResult.No


                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True

            End Select
        End If
    End Sub

End Class




