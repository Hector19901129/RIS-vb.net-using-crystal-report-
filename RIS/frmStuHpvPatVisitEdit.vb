Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb
Imports RIS.RISdataDataSet


Public Class frmStuHpvPatVisitEdit
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ds As RIS.DataSet1
    Friend WithEvents txtVisitNum As System.Windows.Forms.TextBox
    Friend WithEvents dts1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents tabHpvVst As System.Windows.Forms.TabControl
    Friend WithEvents tabHpvVstP1 As System.Windows.Forms.TabPage
    Friend WithEvents tabHpvVstP2 As System.Windows.Forms.TabPage
    Friend WithEvents tabHpvVstP4 As System.Windows.Forms.TabPage
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheckAllProc As System.Windows.Forms.Button
    Friend WithEvents btnCheckAllSpec As System.Windows.Forms.Button
    Friend WithEvents btnCheckAllVac As System.Windows.Forms.Button
    Friend WithEvents lvwHpvVstProc As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstProcC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstSpec As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstSpecC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstVac As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstVacC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstFormR As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstFormRC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstFormPF As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstFormPFC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCheckAllFormPF As System.Windows.Forms.Button
    Friend WithEvents btnCheckAllFormR As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastEditDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVisitID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEpisodeID As System.Windows.Forms.TextBox
    Friend WithEvents cboVisitNum As System.Windows.Forms.ComboBox
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents ada2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents ada2SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents lvwHpvVstFormPFC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstFormPFC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstFormRC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstVacC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstSpecC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstProcC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstFormRC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstProcC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstSpecC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstVacC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtsTime1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents da1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboApptStatus As System.Windows.Forms.ComboBox
    Friend WithEvents OleDbConnection3 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents tabHpvVstContactHX As System.Windows.Forms.TabPage
    Friend WithEvents btnDelHpvCtHx As System.Windows.Forms.Button
    Friend WithEvents btnAddHpvCtHx As System.Windows.Forms.Button
    Friend WithEvents btnEditHpvCtHx As System.Windows.Forms.Button
    Friend WithEvents lvwHpvCtHx As System.Windows.Forms.ListView
    Friend WithEvents lvwHpvVstCtHxC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstCtHxC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstCtHxC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstCtHxC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwHpvVstCtHxC5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabHpvVstPrepForms As System.Windows.Forms.TabPage
    Friend WithEvents bsCervical As System.Windows.Forms.BindingSource
    Friend WithEvents RISdataDataSet As RIS.RISdataDataSet
    Friend WithEvents DdvPathologistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvPathIndicatorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents bsAdequacy As System.Windows.Forms.BindingSource
    Friend WithEvents DdvPathIndicatorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents taPathologist As RIS.RISdataDataSetTableAdapters.ddvPathologistTableAdapter
    Friend WithEvents taAdequacy As RIS.RISdataDataSetTableAdapters.ddvPathAdequacyTableAdapter
    Friend WithEvents taCervical As RIS.RISdataDataSetTableAdapters.tbStuHpvPatVisitCervicalPathTableAdapter
    Friend WithEvents taIndicator As RIS.RISdataDataSetTableAdapters.ddvPathIndicatorTableAdapter
    Friend WithEvents tabPrepForms As System.Windows.Forms.TabControl
    Friend WithEvents tabCervicalPrep As System.Windows.Forms.TabPage
    Friend WithEvents tabAnalPrep As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NotesRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SqCellSevDysCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SqCellModDysCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SqCellMildDysCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SqCellCondyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SqCellSCCCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SqCellHSILCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SqCellLSILCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SqCellASCUSCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IntResSecondBVCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IntResTrichCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IntResCandCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IntResReactCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IntResNegMaligCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EvalLimitScantCellCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPathAdequacyCd As System.Windows.Forms.ComboBox
    Friend WithEvents grpCerv4 As System.Windows.Forms.GroupBox
    Friend WithEvents grpCerv3 As System.Windows.Forms.GroupBox
    Friend WithEvents GlandCellAtypicalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GlandCellAdenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GlandCellOtherCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents grpCerv5 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox24 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox25 As System.Windows.Forms.CheckBox
    Friend WithEvents grpAnal5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox26 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox27 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox28 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox29 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox30 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox31 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox32 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox34 As System.Windows.Forms.CheckBox
    Friend WithEvents grpAnal4 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox37 As System.Windows.Forms.CheckBox
    Friend WithEvents grpAnal3 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox43 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox46 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox47 As System.Windows.Forms.CheckBox
    Friend WithEvents grpAnal1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTransComp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAdeq As System.Windows.Forms.ComboBox
    Friend WithEvents taAnalPath As RIS.RISdataDataSettableadapters.tbStuHpvPatVisitAnalPathTableAdapter
    Friend WithEvents bsAnalPath As System.Windows.Forms.BindingSource
    Friend WithEvents DdvPathIndicatorBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents bsIndicator As System.Windows.Forms.BindingSource
    Friend WithEvents bsddvPathologist As System.Windows.Forms.BindingSource
    Friend WithEvents bsAdequacy1 As System.Windows.Forms.BindingSource
    Friend WithEvents bsIndicator1 As System.Windows.Forms.BindingSource
    Friend WithEvents grpCerv2 As System.Windows.Forms.GroupBox
    Friend WithEvents EvalLimitOtherCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SqCellASCHCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IntResHerpesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents grpCerv1 As System.Windows.Forms.GroupBox
    Friend WithEvents IntResCandidaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IntResHerpesCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents SqCellASCHCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents OtherAbnormalityCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EvalLimitOtherCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents grpAnal2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabHpvVstPregScreenForm As System.Windows.Forms.TabPage
    Friend WithEvents grpPregScreening As System.Windows.Forms.GroupBox
    Friend WithEvents lblTermPreg As System.Windows.Forms.Label
    Friend WithEvents lblasoftodaythingpreg As System.Windows.Forms.Label
    Friend WithEvents lblCurrPreg As System.Windows.Forms.Label
    Friend WithEvents lblMenstHistory As System.Windows.Forms.Label
    Friend WithEvents lblPregHistory As System.Windows.Forms.Label
    Friend WithEvents chkThinkPregNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkThinkPregYes As System.Windows.Forms.CheckBox
    Friend WithEvents chkPregNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkPregYes As System.Windows.Forms.CheckBox
    Friend WithEvents lblDoyouhaveperiod As System.Windows.Forms.Label
    Friend WithEvents lblIfyeswhen1 As System.Windows.Forms.Label
    Friend WithEvents chkHavePeriodNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkHavePeriodYes As System.Windows.Forms.CheckBox
    Friend WithEvents DtTermPregnancy As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtDtTermPregnancy As System.Windows.Forms.TextBox
    Friend WithEvents TbStuHpvPatVisitPregnancyScreeningTableAdapter As RIS.RISdataDataSettableadapters.tbStuHpvPatVisitPregnancyScreeningTableAdapter
    Friend WithEvents DdvPregnancyOutcomeTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvPregnancyOutcomeTypeTableAdapter As RIS.RISdataDataSettableadapters.ddvPregnancyOutcomeTypeTableAdapter
    Friend WithEvents cboOutComeOfPreg As System.Windows.Forms.ComboBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents bsddvPathologist1 As System.Windows.Forms.BindingSource
    Friend WithEvents TransZoneIndicatorCdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents chkPregScreening As System.Windows.Forms.CheckBox
    Friend WithEvents chkCervPrep As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnalPrep As System.Windows.Forms.CheckBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbPath As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPathologistCd As System.Windows.Forms.ComboBox
    Friend WithEvents taDdvPhysician As RIS.RISdataDataSettableadapters.ddvPhysicianTableAdapter
    Friend WithEvents bsPhysician As System.Windows.Forms.BindingSource
    Friend WithEvents cboPhysician As System.Windows.Forms.ComboBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents bsResearcher As System.Windows.Forms.BindingSource
    Friend WithEvents DdvResearcherTableAdapter As RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter
    Friend WithEvents da1SelectComm As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SqCellSevDysLabel As System.Windows.Forms.Label
        Dim SqCellModDysLabel As System.Windows.Forms.Label
        Dim SqCellMildDysLabel As System.Windows.Forms.Label
        Dim SqCellCondyLabel As System.Windows.Forms.Label
        Dim SqCellSCCLabel As System.Windows.Forms.Label
        Dim SqCellHSILLabel As System.Windows.Forms.Label
        Dim SqCellLSILLabel As System.Windows.Forms.Label
        Dim SqCellASCUSLabel As System.Windows.Forms.Label
        Dim IntResSecondBVLabel As System.Windows.Forms.Label
        Dim IntResTrichLabel As System.Windows.Forms.Label
        Dim IntResCandLabel As System.Windows.Forms.Label
        Dim IntResReactLabel As System.Windows.Forms.Label
        Dim IntResNegMaligLabel As System.Windows.Forms.Label
        Dim EvalLimitScantCellLabel As System.Windows.Forms.Label
        Dim PathAdequacyCdLabel As System.Windows.Forms.Label
        Dim GlandCellAtypicalLabel As System.Windows.Forms.Label
        Dim GlandCellAdenLabel As System.Windows.Forms.Label
        Dim GlandCellOtherLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
        Dim Label33 As System.Windows.Forms.Label
        Dim Label34 As System.Windows.Forms.Label
        Dim Label36 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim Label38 As System.Windows.Forms.Label
        Dim Label42 As System.Windows.Forms.Label
        Dim Label45 As System.Windows.Forms.Label
        Dim Label50 As System.Windows.Forms.Label
        Dim Label51 As System.Windows.Forms.Label
        Dim Label53 As System.Windows.Forms.Label
        Dim Label54 As System.Windows.Forms.Label
        Dim TransZoneIndicatorCdLabel As System.Windows.Forms.Label
        Dim EvalLimitOtherLabel As System.Windows.Forms.Label
        Dim SqCellASCHLabel As System.Windows.Forms.Label
        Dim IntResHerpesLabel As System.Windows.Forms.Label
        Dim IntResCandidaLabel As System.Windows.Forms.Label
        Dim IntResHerpesLabel1 As System.Windows.Forms.Label
        Dim SqCellASCHLabel1 As System.Windows.Forms.Label
        Dim OtherAbnormalityLabel As System.Windows.Forms.Label
        Dim EvalLimitOtherLabel1 As System.Windows.Forms.Label
        Dim Label55 As System.Windows.Forms.Label
        Dim PathologistCdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStuHpvPatVisitEdit))
        Me.txtVisitNum = New System.Windows.Forms.TextBox()
        Me.ds = New RIS.DataSet1()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.da1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection3 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.da1SelectComm = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.dts1 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.tabHpvVst = New System.Windows.Forms.TabControl()
        Me.tabHpvVstP1 = New System.Windows.Forms.TabPage()
        Me.cboPhysician = New System.Windows.Forms.ComboBox()
        Me.bsPhysician = New System.Windows.Forms.BindingSource(Me.components)
        Me.RISdataDataSet = New RIS.RISdataDataSet()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btnCheckAllFormR = New System.Windows.Forms.Button()
        Me.lvwHpvVstFormR = New System.Windows.Forms.ListView()
        Me.lvwHpvVstFormRC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstFormRC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstFormRC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstFormPF = New System.Windows.Forms.ListView()
        Me.lvwHpvVstFormPFC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstFormPFC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstFormPFC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstVac = New System.Windows.Forms.ListView()
        Me.lvwHpvVstVacC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstVacC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstVacC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstSpec = New System.Windows.Forms.ListView()
        Me.lvwHpvVstSpecC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstSpecC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstSpecC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstProc = New System.Windows.Forms.ListView()
        Me.lvwHpvVstProcC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstProcC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstProcC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCheckAllFormPF = New System.Windows.Forms.Button()
        Me.btnCheckAllVac = New System.Windows.Forms.Button()
        Me.btnCheckAllSpec = New System.Windows.Forms.Button()
        Me.btnCheckAllProc = New System.Windows.Forms.Button()
        Me.tabHpvVstP2 = New System.Windows.Forms.TabPage()
        Me.tabHpvVstP4 = New System.Windows.Forms.TabPage()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtVisitID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLastEditDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEpisodeID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabHpvVstContactHX = New System.Windows.Forms.TabPage()
        Me.btnDelHpvCtHx = New System.Windows.Forms.Button()
        Me.btnAddHpvCtHx = New System.Windows.Forms.Button()
        Me.btnEditHpvCtHx = New System.Windows.Forms.Button()
        Me.lvwHpvCtHx = New System.Windows.Forms.ListView()
        Me.lvwHpvVstCtHxC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstCtHxC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstCtHxC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstCtHxC4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwHpvVstCtHxC5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabHpvVstPrepForms = New System.Windows.Forms.TabPage()
        Me.tabPrepForms = New System.Windows.Forms.TabControl()
        Me.tabCervicalPrep = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkCervPrep = New System.Windows.Forms.CheckBox()
        Me.grpCerv1 = New System.Windows.Forms.GroupBox()
        Me.cmbPathAdequacyCd = New System.Windows.Forms.ComboBox()
        Me.bsCervical = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAdequacy = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpCerv2 = New System.Windows.Forms.GroupBox()
        Me.TransZoneIndicatorCdComboBox = New System.Windows.Forms.ComboBox()
        Me.bsIndicator = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpCerv5 = New System.Windows.Forms.GroupBox()
        Me.cmbPathologistCd = New System.Windows.Forms.ComboBox()
        Me.bsddvPathologist = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.grpCerv4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.EvalLimitOtherCheckBox = New System.Windows.Forms.CheckBox()
        Me.EvalLimitScantCellCheckBox = New System.Windows.Forms.CheckBox()
        Me.grpCerv3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SqCellSCCCheckBox = New System.Windows.Forms.CheckBox()
        Me.GlandCellOtherCheckBox = New System.Windows.Forms.CheckBox()
        Me.SqCellSevDysCheckBox = New System.Windows.Forms.CheckBox()
        Me.SqCellLSILCheckBox = New System.Windows.Forms.CheckBox()
        Me.GlandCellAdenCheckBox = New System.Windows.Forms.CheckBox()
        Me.GlandCellAtypicalCheckBox = New System.Windows.Forms.CheckBox()
        Me.SqCellModDysCheckBox = New System.Windows.Forms.CheckBox()
        Me.SqCellHSILCheckBox = New System.Windows.Forms.CheckBox()
        Me.IntResReactCheckBox = New System.Windows.Forms.CheckBox()
        Me.IntResTrichCheckBox = New System.Windows.Forms.CheckBox()
        Me.IntResSecondBVCheckBox = New System.Windows.Forms.CheckBox()
        Me.SqCellMildDysCheckBox = New System.Windows.Forms.CheckBox()
        Me.SqCellCondyCheckBox = New System.Windows.Forms.CheckBox()
        Me.IntResCandCheckBox = New System.Windows.Forms.CheckBox()
        Me.SqCellASCUSCheckBox = New System.Windows.Forms.CheckBox()
        Me.SqCellASCHCheckBox = New System.Windows.Forms.CheckBox()
        Me.IntResHerpesCheckBox = New System.Windows.Forms.CheckBox()
        Me.IntResNegMaligCheckBox = New System.Windows.Forms.CheckBox()
        Me.tabAnalPrep = New System.Windows.Forms.TabPage()
        Me.chkAnalPrep = New System.Windows.Forms.CheckBox()
        Me.grpAnal2 = New System.Windows.Forms.GroupBox()
        Me.cmbAdeq = New System.Windows.Forms.ComboBox()
        Me.bsAnalPath = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAdequacy1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpAnal5 = New System.Windows.Forms.GroupBox()
        Me.cmbPath = New System.Windows.Forms.ComboBox()
        Me.bsddvPathologist1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.CheckBox25 = New System.Windows.Forms.CheckBox()
        Me.grpAnal4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.EvalLimitOtherCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox37 = New System.Windows.Forms.CheckBox()
        Me.grpAnal3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox26 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.CheckBox27 = New System.Windows.Forms.CheckBox()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.CheckBox47 = New System.Windows.Forms.CheckBox()
        Me.CheckBox46 = New System.Windows.Forms.CheckBox()
        Me.CheckBox28 = New System.Windows.Forms.CheckBox()
        Me.CheckBox29 = New System.Windows.Forms.CheckBox()
        Me.CheckBox43 = New System.Windows.Forms.CheckBox()
        Me.CheckBox32 = New System.Windows.Forms.CheckBox()
        Me.CheckBox31 = New System.Windows.Forms.CheckBox()
        Me.CheckBox30 = New System.Windows.Forms.CheckBox()
        Me.CheckBox34 = New System.Windows.Forms.CheckBox()
        Me.IntResCandidaCheckBox = New System.Windows.Forms.CheckBox()
        Me.IntResHerpesCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SqCellASCHCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OtherAbnormalityCheckBox = New System.Windows.Forms.CheckBox()
        Me.grpAnal1 = New System.Windows.Forms.GroupBox()
        Me.cmbTransComp = New System.Windows.Forms.ComboBox()
        Me.bsIndicator1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabHpvVstPregScreenForm = New System.Windows.Forms.TabPage()
        Me.chkPregScreening = New System.Windows.Forms.CheckBox()
        Me.grpPregScreening = New System.Windows.Forms.GroupBox()
        Me.cboOutComeOfPreg = New System.Windows.Forms.ComboBox()
        Me.DdvPregnancyOutcomeTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtTermPregnancy = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtDtTermPregnancy = New System.Windows.Forms.TextBox()
        Me.chkHavePeriodNo = New System.Windows.Forms.CheckBox()
        Me.chkHavePeriodYes = New System.Windows.Forms.CheckBox()
        Me.chkThinkPregNo = New System.Windows.Forms.CheckBox()
        Me.chkThinkPregYes = New System.Windows.Forms.CheckBox()
        Me.chkPregNo = New System.Windows.Forms.CheckBox()
        Me.chkPregYes = New System.Windows.Forms.CheckBox()
        Me.lblDoyouhaveperiod = New System.Windows.Forms.Label()
        Me.lblIfyeswhen1 = New System.Windows.Forms.Label()
        Me.lblTermPreg = New System.Windows.Forms.Label()
        Me.lblasoftodaythingpreg = New System.Windows.Forms.Label()
        Me.lblCurrPreg = New System.Windows.Forms.Label()
        Me.lblMenstHistory = New System.Windows.Forms.Label()
        Me.lblPregHistory = New System.Windows.Forms.Label()
        Me.bsResearcher = New System.Windows.Forms.BindingSource(Me.components)
        Me.DdvPathologistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DdvPathIndicatorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DdvPathIndicatorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DdvPathIndicatorBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboVisitNum = New System.Windows.Forms.ComboBox()
        Me.ada2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.ada2SelectComm = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.dtsTime1 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.cboApptStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.taPathologist = New RIS.RISdataDataSetTableAdapters.ddvPathologistTableAdapter()
        Me.taAdequacy = New RIS.RISdataDataSetTableAdapters.ddvPathAdequacyTableAdapter()
        Me.taCervical = New RIS.RISdataDataSetTableAdapters.tbStuHpvPatVisitCervicalPathTableAdapter()
        Me.taIndicator = New RIS.RISdataDataSetTableAdapters.ddvPathIndicatorTableAdapter()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.taAnalPath = New RIS.RISdataDataSetTableAdapters.tbStuHpvPatVisitAnalPathTableAdapter()
        Me.TbStuHpvPatVisitPregnancyScreeningTableAdapter = New RIS.RISdataDataSetTableAdapters.tbStuHpvPatVisitPregnancyScreeningTableAdapter()
        Me.DdvPregnancyOutcomeTypeTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvPregnancyOutcomeTypeTableAdapter()
        Me.taDdvPhysician = New RIS.RISdataDataSetTableAdapters.ddvPhysicianTableAdapter()
        Me.DdvResearcherTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter()
        SqCellSevDysLabel = New System.Windows.Forms.Label()
        SqCellModDysLabel = New System.Windows.Forms.Label()
        SqCellMildDysLabel = New System.Windows.Forms.Label()
        SqCellCondyLabel = New System.Windows.Forms.Label()
        SqCellSCCLabel = New System.Windows.Forms.Label()
        SqCellHSILLabel = New System.Windows.Forms.Label()
        SqCellLSILLabel = New System.Windows.Forms.Label()
        SqCellASCUSLabel = New System.Windows.Forms.Label()
        IntResSecondBVLabel = New System.Windows.Forms.Label()
        IntResTrichLabel = New System.Windows.Forms.Label()
        IntResCandLabel = New System.Windows.Forms.Label()
        IntResReactLabel = New System.Windows.Forms.Label()
        IntResNegMaligLabel = New System.Windows.Forms.Label()
        EvalLimitScantCellLabel = New System.Windows.Forms.Label()
        PathAdequacyCdLabel = New System.Windows.Forms.Label()
        GlandCellAtypicalLabel = New System.Windows.Forms.Label()
        GlandCellAdenLabel = New System.Windows.Forms.Label()
        GlandCellOtherLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        Label33 = New System.Windows.Forms.Label()
        Label34 = New System.Windows.Forms.Label()
        Label36 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        Label38 = New System.Windows.Forms.Label()
        Label42 = New System.Windows.Forms.Label()
        Label45 = New System.Windows.Forms.Label()
        Label50 = New System.Windows.Forms.Label()
        Label51 = New System.Windows.Forms.Label()
        Label53 = New System.Windows.Forms.Label()
        Label54 = New System.Windows.Forms.Label()
        TransZoneIndicatorCdLabel = New System.Windows.Forms.Label()
        EvalLimitOtherLabel = New System.Windows.Forms.Label()
        SqCellASCHLabel = New System.Windows.Forms.Label()
        IntResHerpesLabel = New System.Windows.Forms.Label()
        IntResCandidaLabel = New System.Windows.Forms.Label()
        IntResHerpesLabel1 = New System.Windows.Forms.Label()
        SqCellASCHLabel1 = New System.Windows.Forms.Label()
        OtherAbnormalityLabel = New System.Windows.Forms.Label()
        EvalLimitOtherLabel1 = New System.Windows.Forms.Label()
        Label55 = New System.Windows.Forms.Label()
        PathologistCdLabel = New System.Windows.Forms.Label()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHpvVst.SuspendLayout()
        Me.tabHpvVstP1.SuspendLayout()
        CType(Me.bsPhysician, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHpvVstP4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabHpvVstContactHX.SuspendLayout()
        Me.tabHpvVstPrepForms.SuspendLayout()
        Me.tabPrepForms.SuspendLayout()
        Me.tabCervicalPrep.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpCerv1.SuspendLayout()
        CType(Me.bsCervical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAdequacy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCerv2.SuspendLayout()
        CType(Me.bsIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCerv5.SuspendLayout()
        CType(Me.bsddvPathologist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCerv4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.grpCerv3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tabAnalPrep.SuspendLayout()
        Me.grpAnal2.SuspendLayout()
        CType(Me.bsAnalPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAdequacy1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAnal5.SuspendLayout()
        CType(Me.bsddvPathologist1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.grpAnal4.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.grpAnal3.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.grpAnal1.SuspendLayout()
        CType(Me.bsIndicator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabHpvVstPregScreenForm.SuspendLayout()
        Me.grpPregScreening.SuspendLayout()
        CType(Me.DdvPregnancyOutcomeTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsResearcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvPathologistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvPathIndicatorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvPathIndicatorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvPathIndicatorBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqCellSevDysLabel
        '
        SqCellSevDysLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellSevDysLabel.AutoSize = True
        SqCellSevDysLabel.Location = New System.Drawing.Point(64, 263)
        SqCellSevDysLabel.Name = "SqCellSevDysLabel"
        SqCellSevDysLabel.Size = New System.Drawing.Size(138, 13)
        SqCellSevDysLabel.TabIndex = 236
        SqCellSevDysLabel.Text = "Severe dysplasia/CIS/CIN3"
        '
        'SqCellModDysLabel
        '
        SqCellModDysLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellModDysLabel.AutoSize = True
        SqCellModDysLabel.Location = New System.Drawing.Point(64, 242)
        SqCellModDysLabel.Name = "SqCellModDysLabel"
        SqCellModDysLabel.Size = New System.Drawing.Size(127, 13)
        SqCellModDysLabel.TabIndex = 234
        SqCellModDysLabel.Text = "Moderate dysplasia/CIN2"
        '
        'SqCellMildDysLabel
        '
        SqCellMildDysLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellMildDysLabel.AutoSize = True
        SqCellMildDysLabel.Location = New System.Drawing.Point(64, 201)
        SqCellMildDysLabel.Name = "SqCellMildDysLabel"
        SqCellMildDysLabel.Size = New System.Drawing.Size(101, 13)
        SqCellMildDysLabel.TabIndex = 232
        SqCellMildDysLabel.Text = "Mild dysplasia/CIN1"
        '
        'SqCellCondyLabel
        '
        SqCellCondyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellCondyLabel.AutoSize = True
        SqCellCondyLabel.Location = New System.Drawing.Point(64, 181)
        SqCellCondyLabel.Name = "SqCellCondyLabel"
        SqCellCondyLabel.Size = New System.Drawing.Size(59, 13)
        SqCellCondyLabel.TabIndex = 230
        SqCellCondyLabel.Text = "Condyloma"
        '
        'SqCellSCCLabel
        '
        SqCellSCCLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellSCCLabel.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(SqCellSCCLabel, 2)
        SqCellSCCLabel.Location = New System.Drawing.Point(23, 283)
        SqCellSCCLabel.Name = "SqCellSCCLabel"
        SqCellSCCLabel.Size = New System.Drawing.Size(128, 13)
        SqCellSCCLabel.TabIndex = 222
        SqCellSCCLabel.Text = "Squamous cell carcinoma"
        '
        'SqCellHSILLabel
        '
        SqCellHSILLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellHSILLabel.AutoSize = True
        SqCellHSILLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SqCellHSILLabel.Location = New System.Drawing.Point(23, 221)
        SqCellHSILLabel.Name = "SqCellHSILLabel"
        SqCellHSILLabel.Size = New System.Drawing.Size(35, 13)
        SqCellHSILLabel.TabIndex = 220
        SqCellHSILLabel.Text = "HSIL"
        '
        'SqCellLSILLabel
        '
        SqCellLSILLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellLSILLabel.AutoSize = True
        SqCellLSILLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SqCellLSILLabel.Location = New System.Drawing.Point(23, 161)
        SqCellLSILLabel.Name = "SqCellLSILLabel"
        SqCellLSILLabel.Size = New System.Drawing.Size(33, 13)
        SqCellLSILLabel.TabIndex = 218
        SqCellLSILLabel.Text = "LSIL"
        '
        'SqCellASCUSLabel
        '
        SqCellASCUSLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellASCUSLabel.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(SqCellASCUSLabel, 2)
        SqCellASCUSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SqCellASCUSLabel.Location = New System.Drawing.Point(23, 121)
        SqCellASCUSLabel.Name = "SqCellASCUSLabel"
        SqCellASCUSLabel.Size = New System.Drawing.Size(52, 13)
        SqCellASCUSLabel.TabIndex = 216
        SqCellASCUSLabel.Text = "ASC-US"
        '
        'IntResSecondBVLabel
        '
        IntResSecondBVLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IntResSecondBVLabel.AutoSize = True
        IntResSecondBVLabel.Location = New System.Drawing.Point(64, 42)
        IntResSecondBVLabel.Name = "IntResSecondBVLabel"
        IntResSecondBVLabel.Size = New System.Drawing.Size(130, 13)
        IntResSecondBVLabel.TabIndex = 208
        IntResSecondBVLabel.Text = "Changes secondary to BV"
        '
        'IntResTrichLabel
        '
        IntResTrichLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IntResTrichLabel.AutoSize = True
        IntResTrichLabel.Location = New System.Drawing.Point(64, 61)
        IntResTrichLabel.Name = "IntResTrichLabel"
        IntResTrichLabel.Size = New System.Drawing.Size(68, 13)
        IntResTrichLabel.TabIndex = 206
        IntResTrichLabel.Text = "Trichomonas"
        '
        'IntResCandLabel
        '
        IntResCandLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IntResCandLabel.AutoSize = True
        IntResCandLabel.Location = New System.Drawing.Point(64, 81)
        IntResCandLabel.Name = "IntResCandLabel"
        IntResCandLabel.Size = New System.Drawing.Size(46, 13)
        IntResCandLabel.TabIndex = 204
        IntResCandLabel.Text = "Candida"
        '
        'IntResReactLabel
        '
        IntResReactLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IntResReactLabel.AutoSize = True
        IntResReactLabel.Location = New System.Drawing.Point(64, 23)
        IntResReactLabel.Name = "IntResReactLabel"
        IntResReactLabel.Size = New System.Drawing.Size(94, 13)
        IntResReactLabel.TabIndex = 202
        IntResReactLabel.Text = "Reactive changes"
        '
        'IntResNegMaligLabel
        '
        IntResNegMaligLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IntResNegMaligLabel.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(IntResNegMaligLabel, 2)
        IntResNegMaligLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IntResNegMaligLabel.Location = New System.Drawing.Point(23, 3)
        IntResNegMaligLabel.Name = "IntResNegMaligLabel"
        IntResNegMaligLabel.Size = New System.Drawing.Size(264, 13)
        IntResNegMaligLabel.TabIndex = 200
        IntResNegMaligLabel.Text = "Negative for intraepithelial lesion/Malignancy"
        '
        'EvalLimitScantCellLabel
        '
        EvalLimitScantCellLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        EvalLimitScantCellLabel.AutoSize = True
        EvalLimitScantCellLabel.Location = New System.Drawing.Point(206, 3)
        EvalLimitScantCellLabel.Name = "EvalLimitScantCellLabel"
        EvalLimitScantCellLabel.Size = New System.Drawing.Size(84, 13)
        EvalLimitScantCellLabel.TabIndex = 198
        EvalLimitScantCellLabel.Text = "Scant cellularity:"
        EvalLimitScantCellLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PathAdequacyCdLabel
        '
        PathAdequacyCdLabel.AutoSize = True
        PathAdequacyCdLabel.Location = New System.Drawing.Point(10, 17)
        PathAdequacyCdLabel.Name = "PathAdequacyCdLabel"
        PathAdequacyCdLabel.Size = New System.Drawing.Size(108, 13)
        PathAdequacyCdLabel.TabIndex = 188
        PathAdequacyCdLabel.Text = "Speciman Adequacy:"
        '
        'GlandCellAtypicalLabel
        '
        GlandCellAtypicalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        GlandCellAtypicalLabel.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(GlandCellAtypicalLabel, 2)
        GlandCellAtypicalLabel.Location = New System.Drawing.Point(23, 303)
        GlandCellAtypicalLabel.Name = "GlandCellAtypicalLabel"
        GlandCellAtypicalLabel.Size = New System.Drawing.Size(194, 13)
        GlandCellAtypicalLabel.TabIndex = 240
        GlandCellAtypicalLabel.Text = "Atypical Glandular Cells (see comments)"
        '
        'GlandCellAdenLabel
        '
        GlandCellAdenLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        GlandCellAdenLabel.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(GlandCellAdenLabel, 2)
        GlandCellAdenLabel.Location = New System.Drawing.Point(23, 323)
        GlandCellAdenLabel.Name = "GlandCellAdenLabel"
        GlandCellAdenLabel.Size = New System.Drawing.Size(87, 13)
        GlandCellAdenLabel.TabIndex = 242
        GlandCellAdenLabel.Text = "Adenocarcinoma"
        '
        'GlandCellOtherLabel
        '
        GlandCellOtherLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        GlandCellOtherLabel.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(GlandCellOtherLabel, 2)
        GlandCellOtherLabel.Location = New System.Drawing.Point(23, 343)
        GlandCellOtherLabel.Name = "GlandCellOtherLabel"
        GlandCellOtherLabel.Size = New System.Drawing.Size(167, 13)
        GlandCellOtherLabel.TabIndex = 244
        GlandCellOtherLabel.Text = "Other Abnormality (see comments)"
        '
        'Label4
        '
        Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(189, 81)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(87, 13)
        Label4.TabIndex = 244
        Label4.Text = "Gland Cell Other:"
        '
        'Label5
        '
        Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(190, 56)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 13)
        Label5.TabIndex = 242
        Label5.Text = "Gland Cell Aden:"
        '
        'Label6
        '
        Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(178, 31)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(98, 13)
        Label6.TabIndex = 240
        Label6.Text = "Gland Cell Atypical:"
        '
        'Label11
        '
        Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(177, 6)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(99, 13)
        Label11.TabIndex = 238
        Label11.Text = "Gland Cell No Pres:"
        '
        'Label12
        '
        Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(155, 156)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(113, 13)
        Label12.TabIndex = 236
        Label12.Text = "Sever dysplasia/CIN3:"
        '
        'Label13
        '
        Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(34, 81)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(31, 13)
        Label13.TabIndex = 222
        Label13.Text = "SCC:"
        '
        'Label14
        '
        Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(138, 131)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(130, 13)
        Label14.TabIndex = 234
        Label14.Text = "Moderate dysplasia/CIN2:"
        '
        'Label15
        '
        Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(179, 81)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(89, 13)
        Label15.TabIndex = 230
        Label15.Text = "Condyloma/HPV:"
        '
        'Label16
        '
        Label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(31, 56)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(34, 13)
        Label16.TabIndex = 220
        Label16.Text = "HSIL:"
        '
        'Label17
        '
        Label17.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(166, 56)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(102, 13)
        Label17.TabIndex = 228
        Label17.Text = "Suggestive of HSIL:"
        '
        'Label18
        '
        Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(193, 106)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(75, 13)
        Label18.TabIndex = 232
        Label18.Text = "Mild dysplasia:"
        '
        'Label19
        '
        Label19.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(33, 31)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(32, 13)
        Label19.TabIndex = 218
        Label19.Text = "LSIL:"
        '
        'Label20
        '
        Label20.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(19, 6)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(46, 13)
        Label20.TabIndex = 216
        Label20.Text = "ASCUS:"
        '
        'Label21
        '
        Label21.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(190, 6)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(78, 13)
        Label21.TabIndex = 224
        Label21.Text = "Favor reactive:"
        '
        'Label22
        '
        Label22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(168, 31)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(100, 13)
        Label22.TabIndex = 226
        Label22.Text = "Suggestive of LSIL:"
        '
        'Label23
        '
        Label23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(178, 6)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(87, 13)
        Label23.TabIndex = 194
        Label23.Text = "Obscuring blood:"
        '
        'Label24
        '
        Label24.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(181, 56)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(84, 13)
        Label24.TabIndex = 198
        Label24.Text = "Scant cellularity:"
        '
        'Label25
        '
        Label25.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(146, 31)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(119, 13)
        Label25.TabIndex = 196
        Label25.Text = "Obscuring inflammation:"
        '
        'Label26
        '
        Label26.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(160, 63)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(113, 13)
        Label26.TabIndex = 244
        Label26.Text = "Other (see comments):"
        Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Label27.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label27.AutoSize = True
        Me.TableLayoutPanel12.SetColumnSpan(Label27, 2)
        Label27.Location = New System.Drawing.Point(23, 303)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(87, 13)
        Label27.TabIndex = 242
        Label27.Text = "Adenocarcinoma"
        '
        'Label28
        '
        Label28.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label28.AutoSize = True
        Me.TableLayoutPanel12.SetColumnSpan(Label28, 2)
        Label28.Location = New System.Drawing.Point(23, 283)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(194, 13)
        Label28.TabIndex = 240
        Label28.Text = "Atypical Glandular Cells (see comments)"
        '
        'Label29
        '
        Label29.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label29.AutoSize = True
        Label29.Location = New System.Drawing.Point(135, 3)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(138, 13)
        Label29.TabIndex = 238
        Label29.Text = "No glandular cell(s) present:"
        Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Label30.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label30.AutoSize = True
        Label30.Location = New System.Drawing.Point(44, 242)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(153, 13)
        Label30.TabIndex = 236
        Label30.Text = "Severe dysplasia / CIS / AIN3 "
        '
        'Label31
        '
        Label31.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label31.AutoSize = True
        Me.TableLayoutPanel12.SetColumnSpan(Label31, 2)
        Label31.Location = New System.Drawing.Point(23, 263)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(128, 13)
        Label31.TabIndex = 222
        Label31.Text = "Squamous cell carcinoma"
        '
        'Label32
        '
        Label32.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label32.AutoSize = True
        Label32.Location = New System.Drawing.Point(44, 221)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(133, 13)
        Label32.TabIndex = 234
        Label32.Text = "Moderate dysplasia / AIN2"
        '
        'Label33
        '
        Label33.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label33.AutoSize = True
        Label33.Location = New System.Drawing.Point(44, 161)
        Label33.Name = "Label33"
        Label33.Size = New System.Drawing.Size(59, 13)
        Label33.TabIndex = 230
        Label33.Text = "Condyloma"
        '
        'Label34
        '
        Label34.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label34.AutoSize = True
        Me.TableLayoutPanel12.SetColumnSpan(Label34, 2)
        Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label34.Location = New System.Drawing.Point(23, 201)
        Label34.Name = "Label34"
        Label34.Size = New System.Drawing.Size(35, 13)
        Label34.TabIndex = 220
        Label34.Text = "HSIL"
        '
        'Label36
        '
        Label36.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label36.AutoSize = True
        Label36.Location = New System.Drawing.Point(44, 181)
        Label36.Name = "Label36"
        Label36.Size = New System.Drawing.Size(107, 13)
        Label36.TabIndex = 232
        Label36.Text = "Mild dysplasia / AIN1"
        '
        'Label37
        '
        Label37.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label37.AutoSize = True
        Me.TableLayoutPanel12.SetColumnSpan(Label37, 2)
        Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label37.Location = New System.Drawing.Point(23, 141)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(33, 13)
        Label37.TabIndex = 218
        Label37.Text = "LSIL"
        '
        'Label38
        '
        Label38.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label38.AutoSize = True
        Me.TableLayoutPanel12.SetColumnSpan(Label38, 2)
        Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label38.Location = New System.Drawing.Point(23, 101)
        Label38.Name = "Label38"
        Label38.Size = New System.Drawing.Size(52, 13)
        Label38.TabIndex = 216
        Label38.Text = "ASC-US"
        '
        'Label42
        '
        Label42.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label42.AutoSize = True
        Label42.Location = New System.Drawing.Point(209, 3)
        Label42.Name = "Label42"
        Label42.Size = New System.Drawing.Size(84, 13)
        Label42.TabIndex = 198
        Label42.Text = "Scant cellularity:"
        Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label45
        '
        Label45.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label45.AutoSize = True
        Label45.Location = New System.Drawing.Point(44, 81)
        Label45.Name = "Label45"
        Label45.Size = New System.Drawing.Size(160, 13)
        Label45.TabIndex = 210
        Label45.Text = "Other organisms (see comments)"
        '
        'Label50
        '
        Label50.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label50.AutoSize = True
        Label50.Location = New System.Drawing.Point(44, 23)
        Label50.Name = "Label50"
        Label50.Size = New System.Drawing.Size(94, 13)
        Label50.TabIndex = 202
        Label50.Text = "Reactive changes"
        '
        'Label51
        '
        Label51.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label51.AutoSize = True
        Me.TableLayoutPanel12.SetColumnSpan(Label51, 2)
        Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label51.Location = New System.Drawing.Point(23, 3)
        Label51.Name = "Label51"
        Label51.Size = New System.Drawing.Size(264, 13)
        Label51.TabIndex = 200
        Label51.Text = "Negative for intraepithelial lesion/Malignancy"
        '
        'Label53
        '
        Label53.AutoSize = True
        Label53.Location = New System.Drawing.Point(6, 16)
        Label53.Name = "Label53"
        Label53.Size = New System.Drawing.Size(167, 13)
        Label53.TabIndex = 192
        Label53.Text = "Transformation zone components:"
        '
        'Label54
        '
        Label54.AutoSize = True
        Label54.Location = New System.Drawing.Point(13, 16)
        Label54.Name = "Label54"
        Label54.Size = New System.Drawing.Size(108, 13)
        Label54.TabIndex = 256
        Label54.Text = "Speciman Adequacy:"
        '
        'TransZoneIndicatorCdLabel
        '
        TransZoneIndicatorCdLabel.AutoSize = True
        TransZoneIndicatorCdLabel.Location = New System.Drawing.Point(9, 19)
        TransZoneIndicatorCdLabel.Name = "TransZoneIndicatorCdLabel"
        TransZoneIndicatorCdLabel.Size = New System.Drawing.Size(170, 13)
        TransZoneIndicatorCdLabel.TabIndex = 0
        TransZoneIndicatorCdLabel.Text = "Transformation Zone Components:"
        '
        'EvalLimitOtherLabel
        '
        EvalLimitOtherLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        EvalLimitOtherLabel.AutoSize = True
        EvalLimitOtherLabel.Location = New System.Drawing.Point(206, 23)
        EvalLimitOtherLabel.Name = "EvalLimitOtherLabel"
        EvalLimitOtherLabel.Size = New System.Drawing.Size(84, 13)
        EvalLimitOtherLabel.TabIndex = 198
        EvalLimitOtherLabel.Text = "Eval Limit Other:"
        '
        'SqCellASCHLabel
        '
        SqCellASCHLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellASCHLabel.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(SqCellASCHLabel, 2)
        SqCellASCHLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SqCellASCHLabel.Location = New System.Drawing.Point(23, 141)
        SqCellASCHLabel.Name = "SqCellASCHLabel"
        SqCellASCHLabel.Size = New System.Drawing.Size(44, 13)
        SqCellASCHLabel.TabIndex = 244
        SqCellASCHLabel.Text = "ASC-H"
        '
        'IntResHerpesLabel
        '
        IntResHerpesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IntResHerpesLabel.AutoSize = True
        IntResHerpesLabel.Location = New System.Drawing.Point(64, 101)
        IntResHerpesLabel.Name = "IntResHerpesLabel"
        IntResHerpesLabel.Size = New System.Drawing.Size(66, 13)
        IntResHerpesLabel.TabIndex = 245
        IntResHerpesLabel.Text = "Herpes virus"
        '
        'IntResCandidaLabel
        '
        IntResCandidaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IntResCandidaLabel.AutoSize = True
        IntResCandidaLabel.Location = New System.Drawing.Point(44, 42)
        IntResCandidaLabel.Name = "IntResCandidaLabel"
        IntResCandidaLabel.Size = New System.Drawing.Size(46, 13)
        IntResCandidaLabel.TabIndex = 242
        IntResCandidaLabel.Text = "Candida"
        '
        'IntResHerpesLabel1
        '
        IntResHerpesLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        IntResHerpesLabel1.AutoSize = True
        IntResHerpesLabel1.Location = New System.Drawing.Point(44, 61)
        IntResHerpesLabel1.Name = "IntResHerpesLabel1"
        IntResHerpesLabel1.Size = New System.Drawing.Size(66, 13)
        IntResHerpesLabel1.TabIndex = 243
        IntResHerpesLabel1.Text = "Herpes virus"
        '
        'SqCellASCHLabel1
        '
        SqCellASCHLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        SqCellASCHLabel1.AutoSize = True
        Me.TableLayoutPanel12.SetColumnSpan(SqCellASCHLabel1, 2)
        SqCellASCHLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SqCellASCHLabel1.Location = New System.Drawing.Point(23, 121)
        SqCellASCHLabel1.Name = "SqCellASCHLabel1"
        SqCellASCHLabel1.Size = New System.Drawing.Size(44, 13)
        SqCellASCHLabel1.TabIndex = 244
        SqCellASCHLabel1.Text = "ASC-H"
        '
        'OtherAbnormalityLabel
        '
        OtherAbnormalityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        OtherAbnormalityLabel.AutoSize = True
        Me.TableLayoutPanel12.SetColumnSpan(OtherAbnormalityLabel, 2)
        OtherAbnormalityLabel.Location = New System.Drawing.Point(23, 323)
        OtherAbnormalityLabel.Name = "OtherAbnormalityLabel"
        OtherAbnormalityLabel.Size = New System.Drawing.Size(167, 13)
        OtherAbnormalityLabel.TabIndex = 245
        OtherAbnormalityLabel.Text = "Other Abnormality (see comments)"
        '
        'EvalLimitOtherLabel1
        '
        EvalLimitOtherLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        EvalLimitOtherLabel1.AutoSize = True
        EvalLimitOtherLabel1.Location = New System.Drawing.Point(180, 23)
        EvalLimitOtherLabel1.Name = "EvalLimitOtherLabel1"
        EvalLimitOtherLabel1.Size = New System.Drawing.Size(113, 13)
        EvalLimitOtherLabel1.TabIndex = 198
        EvalLimitOtherLabel1.Text = "Other (see comments):"
        '
        'Label55
        '
        Label55.AutoSize = True
        Label55.Location = New System.Drawing.Point(124, 287)
        Label55.Name = "Label55"
        Label55.Size = New System.Drawing.Size(100, 13)
        Label55.TabIndex = 266
        Label55.Text = "Signing Pathologist:"
        '
        'PathologistCdLabel
        '
        PathologistCdLabel.AutoSize = True
        PathologistCdLabel.Location = New System.Drawing.Point(115, 281)
        PathologistCdLabel.Name = "PathologistCdLabel"
        PathologistCdLabel.Size = New System.Drawing.Size(100, 13)
        PathologistCdLabel.TabIndex = 248
        PathologistCdLabel.Text = "Signing Pathologist:"
        '
        'txtVisitNum
        '
        Me.txtVisitNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVisitNum.BackColor = System.Drawing.SystemColors.Control
        Me.txtVisitNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisit.VisitNum", True))
        Me.txtVisitNum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitNum.Location = New System.Drawing.Point(776, 15)
        Me.txtVisitNum.Name = "txtVisitNum"
        Me.txtVisitNum.ReadOnly = True
        Me.txtVisitNum.Size = New System.Drawing.Size(21, 21)
        Me.txtVisitNum.TabIndex = 4
        Me.txtVisitNum.TabStop = False
        Me.txtVisitNum.Visible = False
        '
        'ds
        '
        Me.ds.DataSetName = "DataSet1"
        Me.ds.Locale = New System.Globalization.CultureInfo("en-US")
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 1
        Me.btnExit.Location = New System.Drawing.Point(602, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 20)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(5, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Visit: Appt status"
        '
        'da1
        '
        Me.da1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.da1.InsertCommand = Me.OleDbInsertCommand1
        Me.da1.SelectCommand = Me.da1SelectComm
        Me.da1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbStuHpvPatVisit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("VisitID", "VisitID"), New System.Data.Common.DataColumnMapping("EpisodeID", "EpisodeID"), New System.Data.Common.DataColumnMapping("VisitNum", "VisitNum"), New System.Data.Common.DataColumnMapping("VisitDate", "VisitDate"), New System.Data.Common.DataColumnMapping("VisitTime", "VisitTime"), New System.Data.Common.DataColumnMapping("ApptStatusCd", "ApptStatusCd"), New System.Data.Common.DataColumnMapping("PhysicianCd", "PhysicianCd"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("Notes", "Notes")})})
        Me.da1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM tbStuHpvPatVisit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (VisitID = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection3
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("VisitID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection3
        '
        Me.OleDbConnection3.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Bittersweet Software\Bittersweet" &
    " Software Working Folder\RIS\RIS\bin\Data\RISdata.mdb"""
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO tbStuHpvPatVisit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                      (EpisodeID, VisitNum, VisitDa" &
    "te, VisitTime, ApptStatusCd, PhysicianCd, LastEditDate, LastEditLoginID, Notes)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES     (?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection3
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeID"), New System.Data.OleDb.OleDbParameter("VisitNum", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "VisitNum"), New System.Data.OleDb.OleDbParameter("VisitDate", System.Data.OleDb.OleDbType.[Date], 0, "VisitDate"), New System.Data.OleDb.OleDbParameter("VisitTime", System.Data.OleDb.OleDbType.WChar, 8, "VisitTime"), New System.Data.OleDb.OleDbParameter("ApptStatusCd", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "ApptStatusCd"), New System.Data.OleDb.OleDbParameter("PhysicianCd", System.Data.OleDb.OleDbType.[Integer], 0, "PhysicianCd"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.WChar, 10, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.WChar, 1024, "Notes")})
        '
        'da1SelectComm
        '
        Me.da1SelectComm.CommandText = "SELECT     VisitID, EpisodeID, VisitNum, VisitDate, VisitTime, ApptStatusCd, Phys" &
    "icianCd, LastEditDate, LastEditLoginID, Notes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         tbStuHpvPatVisit"
        Me.da1SelectComm.Connection = Me.OleDbConnection3
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection3
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeID"), New System.Data.OleDb.OleDbParameter("VisitNum", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "VisitNum"), New System.Data.OleDb.OleDbParameter("VisitDate", System.Data.OleDb.OleDbType.[Date], 0, "VisitDate"), New System.Data.OleDb.OleDbParameter("VisitTime", System.Data.OleDb.OleDbType.WChar, 8, "VisitTime"), New System.Data.OleDb.OleDbParameter("ApptStatusCd", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "ApptStatusCd"), New System.Data.OleDb.OleDbParameter("PhysicianCd", System.Data.OleDb.OleDbType.[Integer], 0, "PhysicianCd"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.WChar, 10, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.WChar, 1024, "Notes"), New System.Data.OleDb.OleDbParameter("Original_VisitID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'chk1
        '
        Me.chk1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chk1.Location = New System.Drawing.Point(751, 15)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(19, 20)
        Me.chk1.TabIndex = 4
        Me.chk1.Tag = "Completed"
        Me.chk1.Visible = False
        '
        'dts1
        '
        Me.dts1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dts1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dts1.Location = New System.Drawing.Point(283, 11)
        Me.dts1.Name = "dts1"
        Me.dts1.ShowCheckBox = True
        Me.dts1.Size = New System.Drawing.Size(100, 21)
        Me.dts1.TabIndex = 1
        Me.dts1.Tag = "VisitDate"
        Me.dts1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'tabHpvVst
        '
        Me.tabHpvVst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstP1)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstP2)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstP4)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstContactHX)
        Me.tabHpvVst.Controls.Add(Me.tabHpvVstPrepForms)
        Me.tabHpvVst.Controls.Add(Me.TabHpvVstPregScreenForm)
        Me.tabHpvVst.Location = New System.Drawing.Point(4, 38)
        Me.tabHpvVst.Name = "tabHpvVst"
        Me.tabHpvVst.SelectedIndex = 0
        Me.tabHpvVst.Size = New System.Drawing.Size(800, 596)
        Me.tabHpvVst.TabIndex = 3
        '
        'tabHpvVstP1
        '
        Me.tabHpvVstP1.Controls.Add(Me.cboPhysician)
        Me.tabHpvVstP1.Controls.Add(Me.Label40)
        Me.tabHpvVstP1.Controls.Add(Me.btnCheckAllFormR)
        Me.tabHpvVstP1.Controls.Add(Me.lvwHpvVstFormR)
        Me.tabHpvVstP1.Controls.Add(Me.lvwHpvVstFormPF)
        Me.tabHpvVstP1.Controls.Add(Me.lvwHpvVstVac)
        Me.tabHpvVstP1.Controls.Add(Me.lvwHpvVstSpec)
        Me.tabHpvVstP1.Controls.Add(Me.lvwHpvVstProc)
        Me.tabHpvVstP1.Controls.Add(Me.btnCheckAllFormPF)
        Me.tabHpvVstP1.Controls.Add(Me.btnCheckAllVac)
        Me.tabHpvVstP1.Controls.Add(Me.btnCheckAllSpec)
        Me.tabHpvVstP1.Controls.Add(Me.btnCheckAllProc)
        Me.tabHpvVstP1.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstP1.Name = "tabHpvVstP1"
        Me.tabHpvVstP1.Size = New System.Drawing.Size(792, 570)
        Me.tabHpvVstP1.TabIndex = 0
        Me.tabHpvVstP1.Text = "Forms & Procedures"
        Me.tabHpvVstP1.UseVisualStyleBackColor = True
        '
        'cboPhysician
        '
        Me.cboPhysician.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ds, "tbStuHpvPatVisit.PhysicianCd", True))
        Me.cboPhysician.DataSource = Me.bsPhysician
        Me.cboPhysician.DisplayMember = "LastName"
        Me.cboPhysician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhysician.FormattingEnabled = True
        Me.cboPhysician.Location = New System.Drawing.Point(264, 399)
        Me.cboPhysician.Name = "cboPhysician"
        Me.cboPhysician.Size = New System.Drawing.Size(241, 21)
        Me.cboPhysician.TabIndex = 11
        Me.cboPhysician.ValueMember = "PhysicianCd"
        '
        'bsPhysician
        '
        Me.bsPhysician.DataMember = "ddvPhysician"
        Me.bsPhysician.DataSource = Me.RISdataDataSet
        '
        'RISdataDataSet
        '
        Me.RISdataDataSet.DataSetName = "RISdataDataSet"
        Me.RISdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(261, 383)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(52, 13)
        Me.Label40.TabIndex = 10
        Me.Label40.Text = "Physician"
        '
        'btnCheckAllFormR
        '
        Me.btnCheckAllFormR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCheckAllFormR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllFormR.ImageIndex = 1
        Me.btnCheckAllFormR.Location = New System.Drawing.Point(6, 361)
        Me.btnCheckAllFormR.Name = "btnCheckAllFormR"
        Me.btnCheckAllFormR.Size = New System.Drawing.Size(66, 20)
        Me.btnCheckAllFormR.TabIndex = 2
        Me.btnCheckAllFormR.Text = "Check All"
        Me.btnCheckAllFormR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lvwHpvVstFormR
        '
        Me.lvwHpvVstFormR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvwHpvVstFormR.CheckBoxes = True
        Me.lvwHpvVstFormR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstFormRC1, Me.lvwHpvVstFormRC2, Me.lvwHpvVstFormRC3})
        Me.lvwHpvVstFormR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstFormR.HideSelection = False
        Me.lvwHpvVstFormR.Location = New System.Drawing.Point(6, 383)
        Me.lvwHpvVstFormR.Name = "lvwHpvVstFormR"
        Me.lvwHpvVstFormR.Size = New System.Drawing.Size(237, 182)
        Me.lvwHpvVstFormR.TabIndex = 3
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
        Me.lvwHpvVstFormRC2.Text = "Order"
        Me.lvwHpvVstFormRC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstFormRC2.Width = 0
        '
        'lvwHpvVstFormRC3
        '
        Me.lvwHpvVstFormRC3.Text = "Cd"
        Me.lvwHpvVstFormRC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstFormRC3.Width = 0
        '
        'lvwHpvVstFormPF
        '
        Me.lvwHpvVstFormPF.CheckBoxes = True
        Me.lvwHpvVstFormPF.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstFormPFC1, Me.lvwHpvVstFormPFC2, Me.lvwHpvVstFormPFC3})
        Me.lvwHpvVstFormPF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstFormPF.HideSelection = False
        Me.lvwHpvVstFormPF.Location = New System.Drawing.Point(6, 27)
        Me.lvwHpvVstFormPF.Name = "lvwHpvVstFormPF"
        Me.lvwHpvVstFormPF.Size = New System.Drawing.Size(237, 328)
        Me.lvwHpvVstFormPF.TabIndex = 1
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
        Me.lvwHpvVstFormPFC2.Text = "Order"
        Me.lvwHpvVstFormPFC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstFormPFC2.Width = 0
        '
        'lvwHpvVstFormPFC3
        '
        Me.lvwHpvVstFormPFC3.Text = "Cd"
        Me.lvwHpvVstFormPFC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstFormPFC3.Width = 0
        '
        'lvwHpvVstVac
        '
        Me.lvwHpvVstVac.CheckBoxes = True
        Me.lvwHpvVstVac.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstVacC1, Me.lvwHpvVstVacC2, Me.lvwHpvVstVacC3})
        Me.lvwHpvVstVac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstVac.HideSelection = False
        Me.lvwHpvVstVac.Location = New System.Drawing.Point(511, 383)
        Me.lvwHpvVstVac.Name = "lvwHpvVstVac"
        Me.lvwHpvVstVac.Size = New System.Drawing.Size(239, 69)
        Me.lvwHpvVstVac.TabIndex = 9
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
        Me.lvwHpvVstVacC2.Text = "Order"
        Me.lvwHpvVstVacC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstVacC2.Width = 0
        '
        'lvwHpvVstVacC3
        '
        Me.lvwHpvVstVacC3.Text = "Cd"
        Me.lvwHpvVstVacC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstVacC3.Width = 0
        '
        'lvwHpvVstSpec
        '
        Me.lvwHpvVstSpec.CheckBoxes = True
        Me.lvwHpvVstSpec.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstSpecC1, Me.lvwHpvVstSpecC2, Me.lvwHpvVstSpecC3})
        Me.lvwHpvVstSpec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstSpec.HideSelection = False
        Me.lvwHpvVstSpec.Location = New System.Drawing.Point(511, 27)
        Me.lvwHpvVstSpec.Name = "lvwHpvVstSpec"
        Me.lvwHpvVstSpec.Size = New System.Drawing.Size(239, 328)
        Me.lvwHpvVstSpec.TabIndex = 7
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
        Me.lvwHpvVstSpecC2.Text = "Order"
        Me.lvwHpvVstSpecC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstSpecC2.Width = 0
        '
        'lvwHpvVstSpecC3
        '
        Me.lvwHpvVstSpecC3.Text = "Cd"
        Me.lvwHpvVstSpecC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstSpecC3.Width = 0
        '
        'lvwHpvVstProc
        '
        Me.lvwHpvVstProc.CheckBoxes = True
        Me.lvwHpvVstProc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstProcC1, Me.lvwHpvVstProcC2, Me.lvwHpvVstProcC3})
        Me.lvwHpvVstProc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvVstProc.HideSelection = False
        Me.lvwHpvVstProc.Location = New System.Drawing.Point(264, 27)
        Me.lvwHpvVstProc.Name = "lvwHpvVstProc"
        Me.lvwHpvVstProc.Size = New System.Drawing.Size(239, 328)
        Me.lvwHpvVstProc.TabIndex = 5
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
        Me.lvwHpvVstProcC2.Text = "Order"
        Me.lvwHpvVstProcC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstProcC2.Width = 0
        '
        'lvwHpvVstProcC3
        '
        Me.lvwHpvVstProcC3.Text = "Cd"
        Me.lvwHpvVstProcC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwHpvVstProcC3.Width = 0
        '
        'btnCheckAllFormPF
        '
        Me.btnCheckAllFormPF.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCheckAllFormPF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllFormPF.ImageIndex = 1
        Me.btnCheckAllFormPF.Location = New System.Drawing.Point(6, 5)
        Me.btnCheckAllFormPF.Name = "btnCheckAllFormPF"
        Me.btnCheckAllFormPF.Size = New System.Drawing.Size(66, 20)
        Me.btnCheckAllFormPF.TabIndex = 0
        Me.btnCheckAllFormPF.Text = "Check All"
        Me.btnCheckAllFormPF.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCheckAllVac
        '
        Me.btnCheckAllVac.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCheckAllVac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllVac.ImageIndex = 1
        Me.btnCheckAllVac.Location = New System.Drawing.Point(511, 361)
        Me.btnCheckAllVac.Name = "btnCheckAllVac"
        Me.btnCheckAllVac.Size = New System.Drawing.Size(66, 20)
        Me.btnCheckAllVac.TabIndex = 8
        Me.btnCheckAllVac.Text = "Check All"
        Me.btnCheckAllVac.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCheckAllSpec
        '
        Me.btnCheckAllSpec.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCheckAllSpec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllSpec.ImageIndex = 1
        Me.btnCheckAllSpec.Location = New System.Drawing.Point(511, 5)
        Me.btnCheckAllSpec.Name = "btnCheckAllSpec"
        Me.btnCheckAllSpec.Size = New System.Drawing.Size(66, 20)
        Me.btnCheckAllSpec.TabIndex = 6
        Me.btnCheckAllSpec.Text = "Check All"
        Me.btnCheckAllSpec.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCheckAllProc
        '
        Me.btnCheckAllProc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCheckAllProc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllProc.ImageIndex = 1
        Me.btnCheckAllProc.Location = New System.Drawing.Point(264, 5)
        Me.btnCheckAllProc.Name = "btnCheckAllProc"
        Me.btnCheckAllProc.Size = New System.Drawing.Size(66, 20)
        Me.btnCheckAllProc.TabIndex = 4
        Me.btnCheckAllProc.Text = "Check All"
        Me.btnCheckAllProc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tabHpvVstP2
        '
        Me.tabHpvVstP2.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstP2.Name = "tabHpvVstP2"
        Me.tabHpvVstP2.Size = New System.Drawing.Size(645, 484)
        Me.tabHpvVstP2.TabIndex = 1
        Me.tabHpvVstP2.Text = "Results"
        Me.tabHpvVstP2.UseVisualStyleBackColor = True
        '
        'tabHpvVstP4
        '
        Me.tabHpvVstP4.Controls.Add(Me.txtNotes)
        Me.tabHpvVstP4.Controls.Add(Me.Label39)
        Me.tabHpvVstP4.Controls.Add(Me.GroupBox2)
        Me.tabHpvVstP4.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstP4.Name = "tabHpvVstP4"
        Me.tabHpvVstP4.Size = New System.Drawing.Size(645, 484)
        Me.tabHpvVstP4.TabIndex = 3
        Me.tabHpvVstP4.Text = "Other"
        Me.tabHpvVstP4.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisit.Notes", True))
        Me.txtNotes.Location = New System.Drawing.Point(14, 27)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(751, 168)
        Me.txtNotes.TabIndex = 109
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(4, 11)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(44, 13)
        Me.Label39.TabIndex = 108
        Me.Label39.Text = "Notes:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVisitID)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtLastEditDate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtEpisodeID)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(576, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 98)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        '
        'txtVisitID
        '
        Me.txtVisitID.BackColor = System.Drawing.SystemColors.Control
        Me.txtVisitID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisit.VisitID", True))
        Me.txtVisitID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitID.ForeColor = System.Drawing.Color.DimGray
        Me.txtVisitID.Location = New System.Drawing.Point(86, 18)
        Me.txtVisitID.Name = "txtVisitID"
        Me.txtVisitID.ReadOnly = True
        Me.txtVisitID.Size = New System.Drawing.Size(122, 21)
        Me.txtVisitID.TabIndex = 92
        Me.txtVisitID.TabStop = False
        Me.txtVisitID.Text = "VisitID"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(25, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Visit ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLastEditDate
        '
        Me.txtLastEditDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastEditDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisit.LastEditDate", True))
        Me.txtLastEditDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastEditDate.ForeColor = System.Drawing.Color.DimGray
        Me.txtLastEditDate.Location = New System.Drawing.Point(86, 68)
        Me.txtLastEditDate.Name = "txtLastEditDate"
        Me.txtLastEditDate.ReadOnly = True
        Me.txtLastEditDate.Size = New System.Drawing.Size(122, 21)
        Me.txtLastEditDate.TabIndex = 90
        Me.txtLastEditDate.TabStop = False
        Me.txtLastEditDate.Text = "LastEditDate"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(6, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Last Edit Date"
        '
        'txtEpisodeID
        '
        Me.txtEpisodeID.BackColor = System.Drawing.SystemColors.Control
        Me.txtEpisodeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisit.EpisodeID", True))
        Me.txtEpisodeID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpisodeID.ForeColor = System.Drawing.Color.DimGray
        Me.txtEpisodeID.Location = New System.Drawing.Point(86, 43)
        Me.txtEpisodeID.Name = "txtEpisodeID"
        Me.txtEpisodeID.ReadOnly = True
        Me.txtEpisodeID.Size = New System.Drawing.Size(122, 21)
        Me.txtEpisodeID.TabIndex = 87
        Me.txtEpisodeID.TabStop = False
        Me.txtEpisodeID.Text = "EpisodeID"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(25, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Episode ID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(5, -1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 15)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "For system use only"
        '
        'tabHpvVstContactHX
        '
        Me.tabHpvVstContactHX.Controls.Add(Me.btnDelHpvCtHx)
        Me.tabHpvVstContactHX.Controls.Add(Me.btnAddHpvCtHx)
        Me.tabHpvVstContactHX.Controls.Add(Me.btnEditHpvCtHx)
        Me.tabHpvVstContactHX.Controls.Add(Me.lvwHpvCtHx)
        Me.tabHpvVstContactHX.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstContactHX.Name = "tabHpvVstContactHX"
        Me.tabHpvVstContactHX.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHpvVstContactHX.Size = New System.Drawing.Size(645, 484)
        Me.tabHpvVstContactHX.TabIndex = 4
        Me.tabHpvVstContactHX.Text = "Contact Hx"
        Me.tabHpvVstContactHX.UseVisualStyleBackColor = True
        '
        'btnDelHpvCtHx
        '
        Me.btnDelHpvCtHx.Enabled = False
        Me.btnDelHpvCtHx.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelHpvCtHx.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelHpvCtHx.ImageIndex = 1
        Me.btnDelHpvCtHx.Location = New System.Drawing.Point(80, 6)
        Me.btnDelHpvCtHx.Name = "btnDelHpvCtHx"
        Me.btnDelHpvCtHx.Size = New System.Drawing.Size(40, 20)
        Me.btnDelHpvCtHx.TabIndex = 51
        Me.btnDelHpvCtHx.Text = "Delete"
        Me.btnDelHpvCtHx.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAddHpvCtHx
        '
        Me.btnAddHpvCtHx.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddHpvCtHx.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHpvCtHx.ImageIndex = 1
        Me.btnAddHpvCtHx.Location = New System.Drawing.Point(6, 6)
        Me.btnAddHpvCtHx.Name = "btnAddHpvCtHx"
        Me.btnAddHpvCtHx.Size = New System.Drawing.Size(34, 20)
        Me.btnAddHpvCtHx.TabIndex = 50
        Me.btnAddHpvCtHx.Text = "Add"
        Me.btnAddHpvCtHx.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEditHpvCtHx
        '
        Me.btnEditHpvCtHx.Enabled = False
        Me.btnEditHpvCtHx.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditHpvCtHx.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditHpvCtHx.ImageIndex = 1
        Me.btnEditHpvCtHx.Location = New System.Drawing.Point(43, 6)
        Me.btnEditHpvCtHx.Name = "btnEditHpvCtHx"
        Me.btnEditHpvCtHx.Size = New System.Drawing.Size(34, 20)
        Me.btnEditHpvCtHx.TabIndex = 49
        Me.btnEditHpvCtHx.Text = "Edit"
        Me.btnEditHpvCtHx.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lvwHpvCtHx
        '
        Me.lvwHpvCtHx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwHpvCtHx.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwHpvVstCtHxC1, Me.lvwHpvVstCtHxC2, Me.lvwHpvVstCtHxC3, Me.lvwHpvVstCtHxC4, Me.lvwHpvVstCtHxC5})
        Me.lvwHpvCtHx.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwHpvCtHx.FullRowSelect = True
        Me.lvwHpvCtHx.GridLines = True
        Me.lvwHpvCtHx.HideSelection = False
        Me.lvwHpvCtHx.Location = New System.Drawing.Point(6, 32)
        Me.lvwHpvCtHx.MultiSelect = False
        Me.lvwHpvCtHx.Name = "lvwHpvCtHx"
        Me.lvwHpvCtHx.Size = New System.Drawing.Size(766, 445)
        Me.lvwHpvCtHx.TabIndex = 48
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
        'tabHpvVstPrepForms
        '
        Me.tabHpvVstPrepForms.Controls.Add(Me.tabPrepForms)
        Me.tabHpvVstPrepForms.Location = New System.Drawing.Point(4, 22)
        Me.tabHpvVstPrepForms.Name = "tabHpvVstPrepForms"
        Me.tabHpvVstPrepForms.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHpvVstPrepForms.Size = New System.Drawing.Size(645, 484)
        Me.tabHpvVstPrepForms.TabIndex = 5
        Me.tabHpvVstPrepForms.Text = "Prep Forms"
        Me.tabHpvVstPrepForms.UseVisualStyleBackColor = True
        '
        'tabPrepForms
        '
        Me.tabPrepForms.Controls.Add(Me.tabCervicalPrep)
        Me.tabPrepForms.Controls.Add(Me.tabAnalPrep)
        Me.tabPrepForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPrepForms.Location = New System.Drawing.Point(3, 3)
        Me.tabPrepForms.Name = "tabPrepForms"
        Me.tabPrepForms.SelectedIndex = 0
        Me.tabPrepForms.Size = New System.Drawing.Size(639, 478)
        Me.tabPrepForms.TabIndex = 0
        '
        'tabCervicalPrep
        '
        Me.tabCervicalPrep.Controls.Add(Me.Panel1)
        Me.tabCervicalPrep.Location = New System.Drawing.Point(4, 22)
        Me.tabCervicalPrep.Name = "tabCervicalPrep"
        Me.tabCervicalPrep.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCervicalPrep.Size = New System.Drawing.Size(631, 452)
        Me.tabCervicalPrep.TabIndex = 0
        Me.tabCervicalPrep.Text = "Cervical Thin Prep"
        Me.tabCervicalPrep.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.chkCervPrep)
        Me.Panel1.Controls.Add(Me.grpCerv1)
        Me.Panel1.Controls.Add(Me.grpCerv2)
        Me.Panel1.Controls.Add(Me.grpCerv5)
        Me.Panel1.Controls.Add(Me.grpCerv4)
        Me.Panel1.Controls.Add(Me.grpCerv3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 446)
        Me.Panel1.TabIndex = 188
        '
        'chkCervPrep
        '
        Me.chkCervPrep.AutoSize = True
        Me.chkCervPrep.Location = New System.Drawing.Point(7, 3)
        Me.chkCervPrep.Name = "chkCervPrep"
        Me.chkCervPrep.Size = New System.Drawing.Size(149, 17)
        Me.chkCervPrep.TabIndex = 257
        Me.chkCervPrep.Text = "Enable Cervical Thin Prep"
        Me.chkCervPrep.UseVisualStyleBackColor = True
        '
        'grpCerv1
        '
        Me.grpCerv1.Controls.Add(Me.cmbPathAdequacyCd)
        Me.grpCerv1.Controls.Add(PathAdequacyCdLabel)
        Me.grpCerv1.Enabled = False
        Me.grpCerv1.Location = New System.Drawing.Point(6, 21)
        Me.grpCerv1.Name = "grpCerv1"
        Me.grpCerv1.Size = New System.Drawing.Size(393, 40)
        Me.grpCerv1.TabIndex = 256
        Me.grpCerv1.TabStop = False
        Me.grpCerv1.Text = "Qaulity Indicators"
        '
        'cmbPathAdequacyCd
        '
        Me.cmbPathAdequacyCd.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsCervical, "PathAdequacyCd", True))
        Me.cmbPathAdequacyCd.DataSource = Me.bsAdequacy
        Me.cmbPathAdequacyCd.DisplayMember = "PathAdequacyDesc"
        Me.cmbPathAdequacyCd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPathAdequacyCd.FormattingEnabled = True
        Me.cmbPathAdequacyCd.Location = New System.Drawing.Point(124, 14)
        Me.cmbPathAdequacyCd.Name = "cmbPathAdequacyCd"
        Me.cmbPathAdequacyCd.Size = New System.Drawing.Size(121, 21)
        Me.cmbPathAdequacyCd.TabIndex = 0
        Me.cmbPathAdequacyCd.ValueMember = "PathAdequacyCd"
        '
        'bsCervical
        '
        Me.bsCervical.DataMember = "tbStuHpvPatVisitCervicalPath"
        Me.bsCervical.DataSource = Me.RISdataDataSet
        '
        'bsAdequacy
        '
        Me.bsAdequacy.DataMember = "ddvPathAdequacy"
        Me.bsAdequacy.DataSource = Me.RISdataDataSet
        '
        'grpCerv2
        '
        Me.grpCerv2.Controls.Add(Me.TransZoneIndicatorCdComboBox)
        Me.grpCerv2.Controls.Add(TransZoneIndicatorCdLabel)
        Me.grpCerv2.Enabled = False
        Me.grpCerv2.Location = New System.Drawing.Point(402, 20)
        Me.grpCerv2.Name = "grpCerv2"
        Me.grpCerv2.Size = New System.Drawing.Size(351, 41)
        Me.grpCerv2.TabIndex = 255
        Me.grpCerv2.TabStop = False
        Me.grpCerv2.Text = "Qaulity Indicators"
        '
        'TransZoneIndicatorCdComboBox
        '
        Me.TransZoneIndicatorCdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsCervical, "TransZoneIndicatorCd", True))
        Me.TransZoneIndicatorCdComboBox.DataSource = Me.bsIndicator
        Me.TransZoneIndicatorCdComboBox.DisplayMember = "PathAdequacyDesc"
        Me.TransZoneIndicatorCdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransZoneIndicatorCdComboBox.FormattingEnabled = True
        Me.TransZoneIndicatorCdComboBox.Location = New System.Drawing.Point(185, 16)
        Me.TransZoneIndicatorCdComboBox.Name = "TransZoneIndicatorCdComboBox"
        Me.TransZoneIndicatorCdComboBox.Size = New System.Drawing.Size(160, 21)
        Me.TransZoneIndicatorCdComboBox.TabIndex = 2
        Me.TransZoneIndicatorCdComboBox.ValueMember = "PathAdequacyCd"
        '
        'bsIndicator
        '
        Me.bsIndicator.DataMember = "ddvPathIndicator"
        Me.bsIndicator.DataSource = Me.RISdataDataSet
        '
        'grpCerv5
        '
        Me.grpCerv5.Controls.Add(PathologistCdLabel)
        Me.grpCerv5.Controls.Add(Me.cmbPathologistCd)
        Me.grpCerv5.Controls.Add(Me.NotesRichTextBox)
        Me.grpCerv5.Enabled = False
        Me.grpCerv5.Location = New System.Drawing.Point(402, 129)
        Me.grpCerv5.Name = "grpCerv5"
        Me.grpCerv5.Size = New System.Drawing.Size(348, 305)
        Me.grpCerv5.TabIndex = 254
        Me.grpCerv5.TabStop = False
        Me.grpCerv5.Text = "Notes:"
        '
        'cmbPathologistCd
        '
        Me.cmbPathologistCd.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsCervical, "PathologistCd", True))
        Me.cmbPathologistCd.DataSource = Me.bsddvPathologist
        Me.cmbPathologistCd.DisplayMember = "LastName"
        Me.cmbPathologistCd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPathologistCd.FormattingEnabled = True
        Me.cmbPathologistCd.Location = New System.Drawing.Point(221, 278)
        Me.cmbPathologistCd.Name = "cmbPathologistCd"
        Me.cmbPathologistCd.Size = New System.Drawing.Size(121, 21)
        Me.cmbPathologistCd.TabIndex = 247
        Me.cmbPathologistCd.ValueMember = "PathologistCd"
        '
        'bsddvPathologist
        '
        Me.bsddvPathologist.DataMember = "ddvPathologist"
        Me.bsddvPathologist.DataSource = Me.RISdataDataSet
        '
        'NotesRichTextBox
        '
        Me.NotesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCervical, "Notes", True))
        Me.NotesRichTextBox.Location = New System.Drawing.Point(3, 16)
        Me.NotesRichTextBox.Name = "NotesRichTextBox"
        Me.NotesRichTextBox.Size = New System.Drawing.Size(342, 250)
        Me.NotesRichTextBox.TabIndex = 29
        Me.NotesRichTextBox.Text = ""
        '
        'grpCerv4
        '
        Me.grpCerv4.Controls.Add(Me.TableLayoutPanel3)
        Me.grpCerv4.Enabled = False
        Me.grpCerv4.Location = New System.Drawing.Point(402, 61)
        Me.grpCerv4.Name = "grpCerv4"
        Me.grpCerv4.Size = New System.Drawing.Size(351, 62)
        Me.grpCerv4.TabIndex = 252
        Me.grpCerv4.TabStop = False
        Me.grpCerv4.Text = "Evaluation Limited By:"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoScroll = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.92754!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07246!))
        Me.TableLayoutPanel3.Controls.Add(EvalLimitOtherLabel, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.EvalLimitOtherCheckBox, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(EvalLimitScantCellLabel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.EvalLimitScantCellCheckBox, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(345, 43)
        Me.TableLayoutPanel3.TabIndex = 200
        '
        'EvalLimitOtherCheckBox
        '
        Me.EvalLimitOtherCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "EvalLimitOther", True))
        Me.EvalLimitOtherCheckBox.Location = New System.Drawing.Point(296, 23)
        Me.EvalLimitOtherCheckBox.Name = "EvalLimitOtherCheckBox"
        Me.EvalLimitOtherCheckBox.Size = New System.Drawing.Size(45, 13)
        Me.EvalLimitOtherCheckBox.TabIndex = 199
        '
        'EvalLimitScantCellCheckBox
        '
        Me.EvalLimitScantCellCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "EvalLimitScantCell", True))
        Me.EvalLimitScantCellCheckBox.Location = New System.Drawing.Point(296, 3)
        Me.EvalLimitScantCellCheckBox.Name = "EvalLimitScantCellCheckBox"
        Me.EvalLimitScantCellCheckBox.Size = New System.Drawing.Size(24, 14)
        Me.EvalLimitScantCellCheckBox.TabIndex = 17
        '
        'grpCerv3
        '
        Me.grpCerv3.Controls.Add(Me.TableLayoutPanel2)
        Me.grpCerv3.Enabled = False
        Me.grpCerv3.Location = New System.Drawing.Point(3, 62)
        Me.grpCerv3.Name = "grpCerv3"
        Me.grpCerv3.Size = New System.Drawing.Size(396, 381)
        Me.grpCerv3.TabIndex = 251
        Me.grpCerv3.TabStop = False
        Me.grpCerv3.Text = "Interpretation/Results:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(IntResHerpesLabel, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.SqCellSCCCheckBox, 0, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.GlandCellOtherCheckBox, 0, 17)
        Me.TableLayoutPanel2.Controls.Add(SqCellSCCLabel, 1, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.SqCellSevDysCheckBox, 1, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.SqCellLSILCheckBox, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(IntResNegMaligLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GlandCellAdenCheckBox, 0, 16)
        Me.TableLayoutPanel2.Controls.Add(SqCellLSILLabel, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(SqCellSevDysLabel, 2, 13)
        Me.TableLayoutPanel2.Controls.Add(GlandCellAdenLabel, 1, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.GlandCellAtypicalCheckBox, 0, 15)
        Me.TableLayoutPanel2.Controls.Add(IntResReactLabel, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SqCellModDysCheckBox, 1, 12)
        Me.TableLayoutPanel2.Controls.Add(IntResTrichLabel, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(GlandCellAtypicalLabel, 1, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.SqCellHSILCheckBox, 0, 11)
        Me.TableLayoutPanel2.Controls.Add(SqCellModDysLabel, 2, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.IntResReactCheckBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.IntResTrichCheckBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(IntResSecondBVLabel, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.IntResSecondBVCheckBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.SqCellMildDysCheckBox, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(SqCellHSILLabel, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.SqCellCondyCheckBox, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(SqCellMildDysLabel, 2, 10)
        Me.TableLayoutPanel2.Controls.Add(SqCellCondyLabel, 2, 9)
        Me.TableLayoutPanel2.Controls.Add(GlandCellOtherLabel, 1, 17)
        Me.TableLayoutPanel2.Controls.Add(Me.IntResCandCheckBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(IntResCandLabel, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.SqCellASCUSCheckBox, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(SqCellASCUSLabel, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.SqCellASCHCheckBox, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(SqCellASCHLabel, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.IntResHerpesCheckBox, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.IntResNegMaligCheckBox, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 19
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(390, 362)
        Me.TableLayoutPanel2.TabIndex = 216
        '
        'SqCellSCCCheckBox
        '
        Me.SqCellSCCCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellSCCCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellSCC", True))
        Me.SqCellSCCCheckBox.Location = New System.Drawing.Point(3, 283)
        Me.SqCellSCCCheckBox.Name = "SqCellSCCCheckBox"
        Me.SqCellSCCCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.SqCellSCCCheckBox.TabIndex = 21
        Me.SqCellSCCCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GlandCellOtherCheckBox
        '
        Me.GlandCellOtherCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GlandCellOtherCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "GlandCellOther", True))
        Me.GlandCellOtherCheckBox.Location = New System.Drawing.Point(3, 343)
        Me.GlandCellOtherCheckBox.Name = "GlandCellOtherCheckBox"
        Me.GlandCellOtherCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.GlandCellOtherCheckBox.TabIndex = 14
        Me.GlandCellOtherCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SqCellSevDysCheckBox
        '
        Me.SqCellSevDysCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellSevDysCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellSevDys", True))
        Me.SqCellSevDysCheckBox.Location = New System.Drawing.Point(44, 262)
        Me.SqCellSevDysCheckBox.Name = "SqCellSevDysCheckBox"
        Me.SqCellSevDysCheckBox.Size = New System.Drawing.Size(14, 15)
        Me.SqCellSevDysCheckBox.TabIndex = 28
        '
        'SqCellLSILCheckBox
        '
        Me.SqCellLSILCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellLSILCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellLSIL", True))
        Me.SqCellLSILCheckBox.Location = New System.Drawing.Point(3, 161)
        Me.SqCellLSILCheckBox.Name = "SqCellLSILCheckBox"
        Me.SqCellLSILCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.SqCellLSILCheckBox.TabIndex = 19
        Me.SqCellLSILCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GlandCellAdenCheckBox
        '
        Me.GlandCellAdenCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GlandCellAdenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "GlandCellAden", True))
        Me.GlandCellAdenCheckBox.Location = New System.Drawing.Point(3, 323)
        Me.GlandCellAdenCheckBox.Name = "GlandCellAdenCheckBox"
        Me.GlandCellAdenCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.GlandCellAdenCheckBox.TabIndex = 13
        Me.GlandCellAdenCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GlandCellAtypicalCheckBox
        '
        Me.GlandCellAtypicalCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GlandCellAtypicalCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "GlandCellAtypical", True))
        Me.GlandCellAtypicalCheckBox.Location = New System.Drawing.Point(3, 303)
        Me.GlandCellAtypicalCheckBox.Name = "GlandCellAtypicalCheckBox"
        Me.GlandCellAtypicalCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.GlandCellAtypicalCheckBox.TabIndex = 12
        Me.GlandCellAtypicalCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SqCellModDysCheckBox
        '
        Me.SqCellModDysCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellModDysCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellModDys", True))
        Me.SqCellModDysCheckBox.Location = New System.Drawing.Point(44, 241)
        Me.SqCellModDysCheckBox.Name = "SqCellModDysCheckBox"
        Me.SqCellModDysCheckBox.Size = New System.Drawing.Size(14, 15)
        Me.SqCellModDysCheckBox.TabIndex = 27
        '
        'SqCellHSILCheckBox
        '
        Me.SqCellHSILCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellHSILCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellHSIL", True))
        Me.SqCellHSILCheckBox.Location = New System.Drawing.Point(3, 221)
        Me.SqCellHSILCheckBox.Name = "SqCellHSILCheckBox"
        Me.SqCellHSILCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.SqCellHSILCheckBox.TabIndex = 20
        Me.SqCellHSILCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'IntResReactCheckBox
        '
        Me.IntResReactCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IntResReactCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "IntResReact", True))
        Me.IntResReactCheckBox.Location = New System.Drawing.Point(44, 23)
        Me.IntResReactCheckBox.Name = "IntResReactCheckBox"
        Me.IntResReactCheckBox.Size = New System.Drawing.Size(14, 13)
        Me.IntResReactCheckBox.TabIndex = 4
        '
        'IntResTrichCheckBox
        '
        Me.IntResTrichCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IntResTrichCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "IntResTrich", True))
        Me.IntResTrichCheckBox.Location = New System.Drawing.Point(44, 61)
        Me.IntResTrichCheckBox.Name = "IntResTrichCheckBox"
        Me.IntResTrichCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.IntResTrichCheckBox.TabIndex = 6
        '
        'IntResSecondBVCheckBox
        '
        Me.IntResSecondBVCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IntResSecondBVCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "IntResSecondBV", True))
        Me.IntResSecondBVCheckBox.Location = New System.Drawing.Point(44, 42)
        Me.IntResSecondBVCheckBox.Name = "IntResSecondBVCheckBox"
        Me.IntResSecondBVCheckBox.Size = New System.Drawing.Size(14, 13)
        Me.IntResSecondBVCheckBox.TabIndex = 7
        '
        'SqCellMildDysCheckBox
        '
        Me.SqCellMildDysCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellMildDysCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellMildDys", True))
        Me.SqCellMildDysCheckBox.Location = New System.Drawing.Point(44, 201)
        Me.SqCellMildDysCheckBox.Name = "SqCellMildDysCheckBox"
        Me.SqCellMildDysCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.SqCellMildDysCheckBox.TabIndex = 26
        '
        'SqCellCondyCheckBox
        '
        Me.SqCellCondyCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellCondyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellCondy", True))
        Me.SqCellCondyCheckBox.Location = New System.Drawing.Point(44, 181)
        Me.SqCellCondyCheckBox.Name = "SqCellCondyCheckBox"
        Me.SqCellCondyCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.SqCellCondyCheckBox.TabIndex = 25
        '
        'IntResCandCheckBox
        '
        Me.IntResCandCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IntResCandCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "IntResCand", True))
        Me.IntResCandCheckBox.Location = New System.Drawing.Point(44, 81)
        Me.IntResCandCheckBox.Name = "IntResCandCheckBox"
        Me.IntResCandCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.IntResCandCheckBox.TabIndex = 5
        '
        'SqCellASCUSCheckBox
        '
        Me.SqCellASCUSCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellASCUSCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellASCUS", True))
        Me.SqCellASCUSCheckBox.Location = New System.Drawing.Point(3, 121)
        Me.SqCellASCUSCheckBox.Name = "SqCellASCUSCheckBox"
        Me.SqCellASCUSCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.SqCellASCUSCheckBox.TabIndex = 18
        Me.SqCellASCUSCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SqCellASCHCheckBox
        '
        Me.SqCellASCHCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellASCHCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellASCH", True))
        Me.SqCellASCHCheckBox.Location = New System.Drawing.Point(3, 141)
        Me.SqCellASCHCheckBox.Name = "SqCellASCHCheckBox"
        Me.SqCellASCHCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.SqCellASCHCheckBox.TabIndex = 245
        Me.SqCellASCHCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'IntResHerpesCheckBox
        '
        Me.IntResHerpesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IntResHerpesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "IntResHerpes", True))
        Me.IntResHerpesCheckBox.Location = New System.Drawing.Point(44, 101)
        Me.IntResHerpesCheckBox.Name = "IntResHerpesCheckBox"
        Me.IntResHerpesCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.IntResHerpesCheckBox.TabIndex = 246
        '
        'IntResNegMaligCheckBox
        '
        Me.IntResNegMaligCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IntResNegMaligCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "IntResNegMalig", True))
        Me.IntResNegMaligCheckBox.Location = New System.Drawing.Point(3, 3)
        Me.IntResNegMaligCheckBox.Name = "IntResNegMaligCheckBox"
        Me.IntResNegMaligCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.IntResNegMaligCheckBox.TabIndex = 3
        Me.IntResNegMaligCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabAnalPrep
        '
        Me.tabAnalPrep.AutoScroll = True
        Me.tabAnalPrep.Controls.Add(Me.chkAnalPrep)
        Me.tabAnalPrep.Controls.Add(Me.grpAnal2)
        Me.tabAnalPrep.Controls.Add(Me.grpAnal5)
        Me.tabAnalPrep.Controls.Add(Me.grpAnal4)
        Me.tabAnalPrep.Controls.Add(Me.grpAnal3)
        Me.tabAnalPrep.Controls.Add(Me.grpAnal1)
        Me.tabAnalPrep.Location = New System.Drawing.Point(4, 22)
        Me.tabAnalPrep.Name = "tabAnalPrep"
        Me.tabAnalPrep.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAnalPrep.Size = New System.Drawing.Size(634, 455)
        Me.tabAnalPrep.TabIndex = 1
        Me.tabAnalPrep.Text = "Anal Thin Prep"
        Me.tabAnalPrep.UseVisualStyleBackColor = True
        '
        'chkAnalPrep
        '
        Me.chkAnalPrep.AutoSize = True
        Me.chkAnalPrep.Location = New System.Drawing.Point(6, 6)
        Me.chkAnalPrep.Name = "chkAnalPrep"
        Me.chkAnalPrep.Size = New System.Drawing.Size(132, 17)
        Me.chkAnalPrep.TabIndex = 264
        Me.chkAnalPrep.Text = "Enable Anal Thin Prep"
        Me.chkAnalPrep.UseVisualStyleBackColor = True
        '
        'grpAnal2
        '
        Me.grpAnal2.Controls.Add(Me.cmbAdeq)
        Me.grpAnal2.Controls.Add(Label54)
        Me.grpAnal2.Enabled = False
        Me.grpAnal2.Location = New System.Drawing.Point(6, 22)
        Me.grpAnal2.Name = "grpAnal2"
        Me.grpAnal2.Size = New System.Drawing.Size(387, 39)
        Me.grpAnal2.TabIndex = 263
        Me.grpAnal2.TabStop = False
        Me.grpAnal2.Text = "Qaulity Indicators"
        '
        'cmbAdeq
        '
        Me.cmbAdeq.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsAnalPath, "PathAdequacyCd", True))
        Me.cmbAdeq.DataSource = Me.bsAdequacy1
        Me.cmbAdeq.DisplayMember = "PathAdequacyDesc"
        Me.cmbAdeq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdeq.FormattingEnabled = True
        Me.cmbAdeq.Location = New System.Drawing.Point(127, 13)
        Me.cmbAdeq.Name = "cmbAdeq"
        Me.cmbAdeq.Size = New System.Drawing.Size(121, 21)
        Me.cmbAdeq.TabIndex = 0
        Me.cmbAdeq.ValueMember = "PathAdequacyCd"
        '
        'bsAnalPath
        '
        Me.bsAnalPath.DataMember = "tbStuHpvPatVisitAnalPath"
        Me.bsAnalPath.DataSource = Me.RISdataDataSet
        '
        'bsAdequacy1
        '
        Me.bsAdequacy1.DataMember = "ddvPathAdequacy"
        Me.bsAdequacy1.DataSource = Me.RISdataDataSet
        '
        'grpAnal5
        '
        Me.grpAnal5.Controls.Add(Label55)
        Me.grpAnal5.Controls.Add(Me.cmbPath)
        Me.grpAnal5.Controls.Add(Me.RichTextBox2)
        Me.grpAnal5.Controls.Add(Me.GroupBox14)
        Me.grpAnal5.Enabled = False
        Me.grpAnal5.Location = New System.Drawing.Point(402, 129)
        Me.grpAnal5.Name = "grpAnal5"
        Me.grpAnal5.Size = New System.Drawing.Size(357, 311)
        Me.grpAnal5.TabIndex = 262
        Me.grpAnal5.TabStop = False
        Me.grpAnal5.Text = "Notes:"
        '
        'cmbPath
        '
        Me.cmbPath.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsAnalPath, "PathologistCd", True))
        Me.cmbPath.DataSource = Me.bsddvPathologist1
        Me.cmbPath.DisplayMember = "LastName"
        Me.cmbPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPath.FormattingEnabled = True
        Me.cmbPath.Location = New System.Drawing.Point(230, 284)
        Me.cmbPath.Name = "cmbPath"
        Me.cmbPath.Size = New System.Drawing.Size(121, 21)
        Me.cmbPath.TabIndex = 265
        Me.cmbPath.ValueMember = "PathologistCd"
        '
        'bsddvPathologist1
        '
        Me.bsddvPathologist1.DataMember = "ddvPathologist"
        Me.bsddvPathologist1.DataSource = Me.RISdataDataSet
        '
        'RichTextBox2
        '
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalPath, "Notes", True))
        Me.RichTextBox2.Location = New System.Drawing.Point(5, 20)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(345, 245)
        Me.RichTextBox2.TabIndex = 264
        Me.RichTextBox2.Text = ""
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox14.Location = New System.Drawing.Point(3, 94)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(360, 133)
        Me.GroupBox14.TabIndex = 263
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Glandular Cells:"
        Me.GroupBox14.Visible = False
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.CheckBox22, 1, 3)
        Me.TableLayoutPanel9.Controls.Add(Label26, 0, 3)
        Me.TableLayoutPanel9.Controls.Add(Label29, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.CheckBox25, 1, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 5
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(354, 114)
        Me.TableLayoutPanel9.TabIndex = 246
        '
        'CheckBox22
        '
        Me.CheckBox22.Location = New System.Drawing.Point(279, 63)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(72, 14)
        Me.CheckBox22.TabIndex = 0
        '
        'CheckBox25
        '
        Me.CheckBox25.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "GlandCellNoPres", True))
        Me.CheckBox25.Location = New System.Drawing.Point(279, 3)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(23, 14)
        Me.CheckBox25.TabIndex = 9
        '
        'grpAnal4
        '
        Me.grpAnal4.Controls.Add(Me.TableLayoutPanel11)
        Me.grpAnal4.Enabled = False
        Me.grpAnal4.Location = New System.Drawing.Point(399, 61)
        Me.grpAnal4.Name = "grpAnal4"
        Me.grpAnal4.Size = New System.Drawing.Size(357, 62)
        Me.grpAnal4.TabIndex = 260
        Me.grpAnal4.TabStop = False
        Me.grpAnal4.Text = "Evaluation Limited By:"
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.AutoScroll = True
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.34783!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.65217!))
        Me.TableLayoutPanel11.Controls.Add(EvalLimitOtherLabel1, 0, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.EvalLimitOtherCheckBox1, 1, 1)
        Me.TableLayoutPanel11.Controls.Add(Label42, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.CheckBox37, 1, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 3
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(351, 43)
        Me.TableLayoutPanel11.TabIndex = 200
        '
        'EvalLimitOtherCheckBox1
        '
        Me.EvalLimitOtherCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "EvalLimitOther", True))
        Me.EvalLimitOtherCheckBox1.Location = New System.Drawing.Point(299, 23)
        Me.EvalLimitOtherCheckBox1.Name = "EvalLimitOtherCheckBox1"
        Me.EvalLimitOtherCheckBox1.Size = New System.Drawing.Size(48, 13)
        Me.EvalLimitOtherCheckBox1.TabIndex = 199
        '
        'CheckBox37
        '
        Me.CheckBox37.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "EvalLimitScantCell", True))
        Me.CheckBox37.Location = New System.Drawing.Point(299, 3)
        Me.CheckBox37.Name = "CheckBox37"
        Me.CheckBox37.Size = New System.Drawing.Size(24, 14)
        Me.CheckBox37.TabIndex = 15
        '
        'grpAnal3
        '
        Me.grpAnal3.Controls.Add(Me.TableLayoutPanel12)
        Me.grpAnal3.Enabled = False
        Me.grpAnal3.Location = New System.Drawing.Point(6, 62)
        Me.grpAnal3.Name = "grpAnal3"
        Me.grpAnal3.Size = New System.Drawing.Size(390, 381)
        Me.grpAnal3.TabIndex = 259
        Me.grpAnal3.TabStop = False
        Me.grpAnal3.Text = "Interpretation/Results:"
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 3
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel12.Controls.Add(OtherAbnormalityLabel, 1, 16)
        Me.TableLayoutPanel12.Controls.Add(SqCellASCHLabel1, 1, 6)
        Me.TableLayoutPanel12.Controls.Add(IntResHerpesLabel1, 2, 3)
        Me.TableLayoutPanel12.Controls.Add(IntResCandidaLabel, 2, 2)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox26, 0, 13)
        Me.TableLayoutPanel12.Controls.Add(Label51, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox23, 0, 15)
        Me.TableLayoutPanel12.Controls.Add(Label31, 1, 13)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox27, 1, 12)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox24, 0, 14)
        Me.TableLayoutPanel12.Controls.Add(Label27, 1, 15)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox47, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Label30, 2, 12)
        Me.TableLayoutPanel12.Controls.Add(Label28, 1, 14)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox46, 1, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox28, 1, 11)
        Me.TableLayoutPanel12.Controls.Add(Label50, 2, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox29, 0, 10)
        Me.TableLayoutPanel12.Controls.Add(Label32, 2, 11)
        Me.TableLayoutPanel12.Controls.Add(Label45, 2, 4)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox43, 1, 4)
        Me.TableLayoutPanel12.Controls.Add(Label38, 1, 5)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox32, 1, 9)
        Me.TableLayoutPanel12.Controls.Add(Label34, 1, 10)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox31, 1, 8)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox30, 0, 7)
        Me.TableLayoutPanel12.Controls.Add(Me.CheckBox34, 0, 5)
        Me.TableLayoutPanel12.Controls.Add(Label37, 1, 7)
        Me.TableLayoutPanel12.Controls.Add(Label36, 2, 9)
        Me.TableLayoutPanel12.Controls.Add(Label33, 2, 8)
        Me.TableLayoutPanel12.Controls.Add(Me.IntResCandidaCheckBox, 1, 2)
        Me.TableLayoutPanel12.Controls.Add(Me.IntResHerpesCheckBox1, 1, 3)
        Me.TableLayoutPanel12.Controls.Add(Me.SqCellASCHCheckBox1, 0, 6)
        Me.TableLayoutPanel12.Controls.Add(Me.OtherAbnormalityCheckBox, 0, 16)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 18
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(384, 362)
        Me.TableLayoutPanel12.TabIndex = 216
        '
        'CheckBox26
        '
        Me.CheckBox26.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "SqCellSCC", True))
        Me.CheckBox26.Location = New System.Drawing.Point(3, 262)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(14, 15)
        Me.CheckBox26.TabIndex = 19
        '
        'CheckBox23
        '
        Me.CheckBox23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBox23.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "GlandCellAden", True))
        Me.CheckBox23.Location = New System.Drawing.Point(3, 303)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(14, 14)
        Me.CheckBox23.TabIndex = 11
        Me.CheckBox23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox27
        '
        Me.CheckBox27.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBox27.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "SqCellSevDys", True))
        Me.CheckBox27.Location = New System.Drawing.Point(23, 241)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(15, 15)
        Me.CheckBox27.TabIndex = 26
        '
        'CheckBox24
        '
        Me.CheckBox24.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "GlandCellAtypical", True))
        Me.CheckBox24.Location = New System.Drawing.Point(3, 283)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(14, 14)
        Me.CheckBox24.TabIndex = 10
        '
        'CheckBox47
        '
        Me.CheckBox47.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "IntResNegMalig", True))
        Me.CheckBox47.Location = New System.Drawing.Point(3, 3)
        Me.CheckBox47.Name = "CheckBox47"
        Me.CheckBox47.Size = New System.Drawing.Size(14, 14)
        Me.CheckBox47.TabIndex = 3
        '
        'CheckBox46
        '
        Me.CheckBox46.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBox46.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "IntResReact", True))
        Me.CheckBox46.Location = New System.Drawing.Point(23, 23)
        Me.CheckBox46.Name = "CheckBox46"
        Me.CheckBox46.Size = New System.Drawing.Size(15, 13)
        Me.CheckBox46.TabIndex = 4
        '
        'CheckBox28
        '
        Me.CheckBox28.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBox28.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "SqCellModDys", True))
        Me.CheckBox28.Location = New System.Drawing.Point(23, 221)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox28.TabIndex = 25
        '
        'CheckBox29
        '
        Me.CheckBox29.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "SqCellHSIL", True))
        Me.CheckBox29.Location = New System.Drawing.Point(3, 201)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(14, 14)
        Me.CheckBox29.TabIndex = 18
        '
        'CheckBox43
        '
        Me.CheckBox43.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBox43.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "IntResOther", True))
        Me.CheckBox43.Location = New System.Drawing.Point(23, 81)
        Me.CheckBox43.Name = "CheckBox43"
        Me.CheckBox43.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox43.TabIndex = 8
        '
        'CheckBox32
        '
        Me.CheckBox32.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBox32.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "SqCellMildDys", True))
        Me.CheckBox32.Location = New System.Drawing.Point(23, 181)
        Me.CheckBox32.Name = "CheckBox32"
        Me.CheckBox32.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox32.TabIndex = 24
        '
        'CheckBox31
        '
        Me.CheckBox31.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CheckBox31.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "SqCellCondy", True))
        Me.CheckBox31.Location = New System.Drawing.Point(23, 161)
        Me.CheckBox31.Name = "CheckBox31"
        Me.CheckBox31.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox31.TabIndex = 23
        '
        'CheckBox30
        '
        Me.CheckBox30.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "SqCellLSIL", True))
        Me.CheckBox30.Location = New System.Drawing.Point(3, 141)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(14, 14)
        Me.CheckBox30.TabIndex = 17
        '
        'CheckBox34
        '
        Me.CheckBox34.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "SqCellASCUS", True))
        Me.CheckBox34.Location = New System.Drawing.Point(3, 101)
        Me.CheckBox34.Name = "CheckBox34"
        Me.CheckBox34.Size = New System.Drawing.Size(14, 14)
        Me.CheckBox34.TabIndex = 16
        '
        'IntResCandidaCheckBox
        '
        Me.IntResCandidaCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IntResCandidaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "IntResCandida", True))
        Me.IntResCandidaCheckBox.Location = New System.Drawing.Point(23, 42)
        Me.IntResCandidaCheckBox.Name = "IntResCandidaCheckBox"
        Me.IntResCandidaCheckBox.Size = New System.Drawing.Size(15, 13)
        Me.IntResCandidaCheckBox.TabIndex = 243
        Me.IntResCandidaCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IntResHerpesCheckBox1
        '
        Me.IntResHerpesCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IntResHerpesCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "IntResHerpes", True))
        Me.IntResHerpesCheckBox1.Location = New System.Drawing.Point(23, 61)
        Me.IntResHerpesCheckBox1.Name = "IntResHerpesCheckBox1"
        Me.IntResHerpesCheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.IntResHerpesCheckBox1.TabIndex = 244
        Me.IntResHerpesCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqCellASCHCheckBox1
        '
        Me.SqCellASCHCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SqCellASCHCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "SqCellASCH", True))
        Me.SqCellASCHCheckBox1.Location = New System.Drawing.Point(3, 121)
        Me.SqCellASCHCheckBox1.Name = "SqCellASCHCheckBox1"
        Me.SqCellASCHCheckBox1.Size = New System.Drawing.Size(14, 14)
        Me.SqCellASCHCheckBox1.TabIndex = 245
        Me.SqCellASCHCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OtherAbnormalityCheckBox
        '
        Me.OtherAbnormalityCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.OtherAbnormalityCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsAnalPath, "OtherAbnormality", True))
        Me.OtherAbnormalityCheckBox.Location = New System.Drawing.Point(3, 323)
        Me.OtherAbnormalityCheckBox.Name = "OtherAbnormalityCheckBox"
        Me.OtherAbnormalityCheckBox.Size = New System.Drawing.Size(14, 14)
        Me.OtherAbnormalityCheckBox.TabIndex = 246
        Me.OtherAbnormalityCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpAnal1
        '
        Me.grpAnal1.Controls.Add(Me.cmbTransComp)
        Me.grpAnal1.Controls.Add(Label53)
        Me.grpAnal1.Enabled = False
        Me.grpAnal1.Location = New System.Drawing.Point(399, 22)
        Me.grpAnal1.Name = "grpAnal1"
        Me.grpAnal1.Size = New System.Drawing.Size(357, 39)
        Me.grpAnal1.TabIndex = 258
        Me.grpAnal1.TabStop = False
        Me.grpAnal1.Text = "Quality Indicators:"
        '
        'cmbTransComp
        '
        Me.cmbTransComp.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsAnalPath, "TransZoneIndicatorCd", True))
        Me.cmbTransComp.DataSource = Me.bsIndicator1
        Me.cmbTransComp.DisplayMember = "PathAdequacyDesc"
        Me.cmbTransComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransComp.FormattingEnabled = True
        Me.cmbTransComp.Location = New System.Drawing.Point(186, 13)
        Me.cmbTransComp.Name = "cmbTransComp"
        Me.cmbTransComp.Size = New System.Drawing.Size(162, 21)
        Me.cmbTransComp.TabIndex = 2
        Me.cmbTransComp.ValueMember = "PathAdequacyCd"
        '
        'bsIndicator1
        '
        Me.bsIndicator1.DataMember = "ddvPathIndicator"
        Me.bsIndicator1.DataSource = Me.RISdataDataSet
        '
        'TabHpvVstPregScreenForm
        '
        Me.TabHpvVstPregScreenForm.AutoScroll = True
        Me.TabHpvVstPregScreenForm.Controls.Add(Me.chkPregScreening)
        Me.TabHpvVstPregScreenForm.Controls.Add(Me.grpPregScreening)
        Me.TabHpvVstPregScreenForm.Location = New System.Drawing.Point(4, 22)
        Me.TabHpvVstPregScreenForm.Name = "TabHpvVstPregScreenForm"
        Me.TabHpvVstPregScreenForm.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHpvVstPregScreenForm.Size = New System.Drawing.Size(645, 484)
        Me.TabHpvVstPregScreenForm.TabIndex = 6
        Me.TabHpvVstPregScreenForm.Text = "Pregnancy Screening Form"
        Me.TabHpvVstPregScreenForm.UseVisualStyleBackColor = True
        '
        'chkPregScreening
        '
        Me.chkPregScreening.AutoSize = True
        Me.chkPregScreening.Location = New System.Drawing.Point(6, 10)
        Me.chkPregScreening.Name = "chkPregScreening"
        Me.chkPregScreening.Size = New System.Drawing.Size(190, 17)
        Me.chkPregScreening.TabIndex = 1
        Me.chkPregScreening.Text = "Enable Pregnancy Screening Form"
        Me.chkPregScreening.UseVisualStyleBackColor = True
        '
        'grpPregScreening
        '
        Me.grpPregScreening.Controls.Add(Me.cboOutComeOfPreg)
        Me.grpPregScreening.Controls.Add(Me.DtTermPregnancy)
        Me.grpPregScreening.Controls.Add(Me.Label35)
        Me.grpPregScreening.Controls.Add(Me.txtDtTermPregnancy)
        Me.grpPregScreening.Controls.Add(Me.chkHavePeriodNo)
        Me.grpPregScreening.Controls.Add(Me.chkHavePeriodYes)
        Me.grpPregScreening.Controls.Add(Me.chkThinkPregNo)
        Me.grpPregScreening.Controls.Add(Me.chkThinkPregYes)
        Me.grpPregScreening.Controls.Add(Me.chkPregNo)
        Me.grpPregScreening.Controls.Add(Me.chkPregYes)
        Me.grpPregScreening.Controls.Add(Me.lblDoyouhaveperiod)
        Me.grpPregScreening.Controls.Add(Me.lblIfyeswhen1)
        Me.grpPregScreening.Controls.Add(Me.lblTermPreg)
        Me.grpPregScreening.Controls.Add(Me.lblasoftodaythingpreg)
        Me.grpPregScreening.Controls.Add(Me.lblCurrPreg)
        Me.grpPregScreening.Controls.Add(Me.lblMenstHistory)
        Me.grpPregScreening.Controls.Add(Me.lblPregHistory)
        Me.grpPregScreening.Enabled = False
        Me.grpPregScreening.Location = New System.Drawing.Point(6, 25)
        Me.grpPregScreening.Name = "grpPregScreening"
        Me.grpPregScreening.Size = New System.Drawing.Size(768, 241)
        Me.grpPregScreening.TabIndex = 0
        Me.grpPregScreening.TabStop = False
        '
        'cboOutComeOfPreg
        '
        Me.cboOutComeOfPreg.DataSource = Me.DdvPregnancyOutcomeTypeBindingSource
        Me.cboOutComeOfPreg.DisplayMember = "OutcomeDesc"
        Me.cboOutComeOfPreg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOutComeOfPreg.FormattingEnabled = True
        Me.cboOutComeOfPreg.Location = New System.Drawing.Point(268, 67)
        Me.cboOutComeOfPreg.Name = "cboOutComeOfPreg"
        Me.cboOutComeOfPreg.Size = New System.Drawing.Size(158, 21)
        Me.cboOutComeOfPreg.TabIndex = 2
        Me.cboOutComeOfPreg.ValueMember = "PregOutcomeTypeCd"
        '
        'DdvPregnancyOutcomeTypeBindingSource
        '
        Me.DdvPregnancyOutcomeTypeBindingSource.DataMember = "ddvPregnancyOutcomeType"
        Me.DdvPregnancyOutcomeTypeBindingSource.DataSource = Me.RISdataDataSet
        '
        'DtTermPregnancy
        '
        Me.DtTermPregnancy.Checked = False
        Me.DtTermPregnancy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtTermPregnancy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTermPregnancy.Location = New System.Drawing.Point(422, 94)
        Me.DtTermPregnancy.Name = "DtTermPregnancy"
        Me.DtTermPregnancy.ShowCheckBox = True
        Me.DtTermPregnancy.Size = New System.Drawing.Size(121, 21)
        Me.DtTermPregnancy.TabIndex = 4
        Me.DtTermPregnancy.Tag = "EpisodeDate"
        Me.DtTermPregnancy.Value = CType(resources.GetObject("DtTermPregnancy.Value"), Object)
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label35.Location = New System.Drawing.Point(395, 99)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(21, 15)
        Me.Label35.TabIndex = 131
        Me.Label35.Text = "Or"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDtTermPregnancy
        '
        Me.txtDtTermPregnancy.BackColor = System.Drawing.SystemColors.Window
        Me.txtDtTermPregnancy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtTermPregnancy.Location = New System.Drawing.Point(268, 94)
        Me.txtDtTermPregnancy.MaxLength = 255
        Me.txtDtTermPregnancy.Name = "txtDtTermPregnancy"
        Me.txtDtTermPregnancy.Size = New System.Drawing.Size(121, 21)
        Me.txtDtTermPregnancy.TabIndex = 3
        '
        'chkHavePeriodNo
        '
        Me.chkHavePeriodNo.AutoSize = True
        Me.chkHavePeriodNo.Location = New System.Drawing.Point(319, 188)
        Me.chkHavePeriodNo.Name = "chkHavePeriodNo"
        Me.chkHavePeriodNo.Size = New System.Drawing.Size(40, 17)
        Me.chkHavePeriodNo.TabIndex = 8
        Me.chkHavePeriodNo.Text = "No"
        Me.chkHavePeriodNo.UseVisualStyleBackColor = True
        '
        'chkHavePeriodYes
        '
        Me.chkHavePeriodYes.AutoSize = True
        Me.chkHavePeriodYes.Location = New System.Drawing.Point(269, 188)
        Me.chkHavePeriodYes.Name = "chkHavePeriodYes"
        Me.chkHavePeriodYes.Size = New System.Drawing.Size(44, 17)
        Me.chkHavePeriodYes.TabIndex = 7
        Me.chkHavePeriodYes.Text = "Yes"
        Me.chkHavePeriodYes.UseVisualStyleBackColor = True
        '
        'chkThinkPregNo
        '
        Me.chkThinkPregNo.AutoSize = True
        Me.chkThinkPregNo.Location = New System.Drawing.Point(319, 121)
        Me.chkThinkPregNo.Name = "chkThinkPregNo"
        Me.chkThinkPregNo.Size = New System.Drawing.Size(40, 17)
        Me.chkThinkPregNo.TabIndex = 6
        Me.chkThinkPregNo.Text = "No"
        Me.chkThinkPregNo.UseVisualStyleBackColor = True
        '
        'chkThinkPregYes
        '
        Me.chkThinkPregYes.AutoSize = True
        Me.chkThinkPregYes.Location = New System.Drawing.Point(269, 121)
        Me.chkThinkPregYes.Name = "chkThinkPregYes"
        Me.chkThinkPregYes.Size = New System.Drawing.Size(44, 17)
        Me.chkThinkPregYes.TabIndex = 5
        Me.chkThinkPregYes.Text = "Yes"
        Me.chkThinkPregYes.UseVisualStyleBackColor = True
        '
        'chkPregNo
        '
        Me.chkPregNo.AutoSize = True
        Me.chkPregNo.Location = New System.Drawing.Point(319, 44)
        Me.chkPregNo.Name = "chkPregNo"
        Me.chkPregNo.Size = New System.Drawing.Size(40, 17)
        Me.chkPregNo.TabIndex = 1
        Me.chkPregNo.Text = "No"
        Me.chkPregNo.UseVisualStyleBackColor = True
        '
        'chkPregYes
        '
        Me.chkPregYes.AutoSize = True
        Me.chkPregYes.Location = New System.Drawing.Point(269, 44)
        Me.chkPregYes.Name = "chkPregYes"
        Me.chkPregYes.Size = New System.Drawing.Size(44, 17)
        Me.chkPregYes.TabIndex = 0
        Me.chkPregYes.Text = "Yes"
        Me.chkPregYes.UseVisualStyleBackColor = True
        '
        'lblDoyouhaveperiod
        '
        Me.lblDoyouhaveperiod.AutoSize = True
        Me.lblDoyouhaveperiod.Location = New System.Drawing.Point(41, 189)
        Me.lblDoyouhaveperiod.Name = "lblDoyouhaveperiod"
        Me.lblDoyouhaveperiod.Size = New System.Drawing.Size(175, 13)
        Me.lblDoyouhaveperiod.TabIndex = 6
        Me.lblDoyouhaveperiod.Text = "Do you have your period right now?"
        '
        'lblIfyeswhen1
        '
        Me.lblIfyeswhen1.AutoSize = True
        Me.lblIfyeswhen1.Location = New System.Drawing.Point(158, 99)
        Me.lblIfyeswhen1.Name = "lblIfyeswhen1"
        Me.lblIfyeswhen1.Size = New System.Drawing.Size(80, 13)
        Me.lblIfyeswhen1.TabIndex = 5
        Me.lblIfyeswhen1.Text = "Outcome date?"
        '
        'lblTermPreg
        '
        Me.lblTermPreg.AutoSize = True
        Me.lblTermPreg.Location = New System.Drawing.Point(56, 70)
        Me.lblTermPreg.Name = "lblTermPreg"
        Me.lblTermPreg.Size = New System.Drawing.Size(182, 13)
        Me.lblTermPreg.TabIndex = 4
        Me.lblTermPreg.Text = "What was the outcome of prenancy?"
        '
        'lblasoftodaythingpreg
        '
        Me.lblasoftodaythingpreg.AutoSize = True
        Me.lblasoftodaythingpreg.Location = New System.Drawing.Point(23, 123)
        Me.lblasoftodaythingpreg.Name = "lblasoftodaythingpreg"
        Me.lblasoftodaythingpreg.Size = New System.Drawing.Size(215, 13)
        Me.lblasoftodaythingpreg.TabIndex = 3
        Me.lblasoftodaythingpreg.Text = "As of today. Do you think you are pregnant?"
        '
        'lblCurrPreg
        '
        Me.lblCurrPreg.AutoSize = True
        Me.lblCurrPreg.Location = New System.Drawing.Point(83, 45)
        Me.lblCurrPreg.Name = "lblCurrPreg"
        Me.lblCurrPreg.Size = New System.Drawing.Size(155, 13)
        Me.lblCurrPreg.TabIndex = 2
        Me.lblCurrPreg.Text = "Have you ever been pregnant?"
        '
        'lblMenstHistory
        '
        Me.lblMenstHistory.AutoSize = True
        Me.lblMenstHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenstHistory.Location = New System.Drawing.Point(16, 161)
        Me.lblMenstHistory.Name = "lblMenstHistory"
        Me.lblMenstHistory.Size = New System.Drawing.Size(105, 13)
        Me.lblMenstHistory.TabIndex = 1
        Me.lblMenstHistory.Text = "Menstrual History"
        '
        'lblPregHistory
        '
        Me.lblPregHistory.AutoSize = True
        Me.lblPregHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregHistory.Location = New System.Drawing.Point(16, 20)
        Me.lblPregHistory.Name = "lblPregHistory"
        Me.lblPregHistory.Size = New System.Drawing.Size(110, 13)
        Me.lblPregHistory.TabIndex = 0
        Me.lblPregHistory.Text = "Pregnancy History"
        '
        'bsResearcher
        '
        Me.bsResearcher.DataMember = "ddvResearcher"
        Me.bsResearcher.DataSource = Me.RISdataDataSet
        '
        'DdvPathologistBindingSource
        '
        Me.DdvPathologistBindingSource.DataMember = "ddvPathologist"
        Me.DdvPathologistBindingSource.DataSource = Me.RISdataDataSet
        '
        'DdvPathIndicatorBindingSource1
        '
        Me.DdvPathIndicatorBindingSource1.DataMember = "ddvPathIndicator"
        Me.DdvPathIndicatorBindingSource1.DataSource = Me.RISdataDataSet
        '
        'DdvPathIndicatorBindingSource
        '
        Me.DdvPathIndicatorBindingSource.DataMember = "ddvPathIndicator"
        Me.DdvPathIndicatorBindingSource.DataSource = Me.RISdataDataSet
        '
        'DdvPathIndicatorBindingSource2
        '
        Me.DdvPathIndicatorBindingSource2.DataMember = "ddvPathIndicator"
        Me.DdvPathIndicatorBindingSource2.DataSource = Me.RISdataDataSet
        '
        'cboVisitNum
        '
        Me.cboVisitNum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ds, "tbStuHpvPatVisit.VisitNum", True))
        Me.cboVisitNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVisitNum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVisitNum.ItemHeight = 13
        Me.cboVisitNum.Location = New System.Drawing.Point(4, 8)
        Me.cboVisitNum.Name = "cboVisitNum"
        Me.cboVisitNum.Size = New System.Drawing.Size(191, 21)
        Me.cboVisitNum.TabIndex = 0
        '
        'ada2
        '
        Me.ada2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.ada2.InsertCommand = Me.OleDbInsertCommand2
        Me.ada2.SelectCommand = Me.ada2SelectComm
        Me.ada2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ddvStuHpvVisitNum", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("VisitNum", "VisitNum"), New System.Data.Common.DataColumnMapping("VisitNumDescLong", "VisitNumDescLong")})})
        Me.ada2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM ddvStuHpvVisitNum WHERE (VisitNum = ?) AND (VisitNumDescLong = ? OR ?" &
    " IS NULL AND VisitNumDescLong IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_VisitNum", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VisitNumDescLong", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitNumDescLong", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VisitNumDescLong1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitNumDescLong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = resources.GetString("OleDbConnection2.ConnectionString")
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO ddvStuHpvVisitNum(VisitNum, VisitNumDescLong) VALUES (?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("VisitNum", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "VisitNum"), New System.Data.OleDb.OleDbParameter("VisitNumDescLong", System.Data.OleDb.OleDbType.VarWChar, 50, "VisitNumDescLong")})
        '
        'ada2SelectComm
        '
        Me.ada2SelectComm.CommandText = "SELECT VisitNum, VisitNumDescLong FROM ddvStuHpvVisitNum"
        Me.ada2SelectComm.Connection = Me.OleDbConnection2
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE ddvStuHpvVisitNum SET VisitNum = ?, VisitNumDescLong = ? WHERE (VisitNum =" &
    " ?) AND (VisitNumDescLong = ? OR ? IS NULL AND VisitNumDescLong IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("VisitNum", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "VisitNum"), New System.Data.OleDb.OleDbParameter("VisitNumDescLong", System.Data.OleDb.OleDbType.VarWChar, 50, "VisitNumDescLong"), New System.Data.OleDb.OleDbParameter("Original_VisitNum", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitNum", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VisitNumDescLong", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitNumDescLong", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VisitNumDescLong1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitNumDescLong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'dtsTime1
        '
        Me.dtsTime1.CustomFormat = "hh:mm tt"
        Me.dtsTime1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsTime1.Location = New System.Drawing.Point(417, 11)
        Me.dtsTime1.Name = "dtsTime1"
        Me.dtsTime1.ShowCheckBox = True
        Me.dtsTime1.ShowUpDown = True
        Me.dtsTime1.Size = New System.Drawing.Size(86, 21)
        Me.dtsTime1.TabIndex = 2
        Me.dtsTime1.Tag = "VisitTime"
        Me.dtsTime1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'cboApptStatus
        '
        Me.cboApptStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ds, "tbStuHpvPatVisit.ApptStatusCd", True))
        Me.cboApptStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApptStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboApptStatus.ItemHeight = 13
        Me.cboApptStatus.Location = New System.Drawing.Point(98, 11)
        Me.cboApptStatus.Name = "cboApptStatus"
        Me.cboApptStatus.Size = New System.Drawing.Size(151, 21)
        Me.cboApptStatus.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dts1)
        Me.GroupBox1.Controls.Add(Me.cboApptStatus)
        Me.GroupBox1.Controls.Add(Me.dtsTime1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(206, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 37)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(387, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Time"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(252, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Date"
        '
        'taPathologist
        '
        Me.taPathologist.ClearBeforeFill = True
        '
        'taAdequacy
        '
        Me.taAdequacy.ClearBeforeFill = True
        '
        'taCervical
        '
        Me.taCervical.ClearBeforeFill = True
        '
        'taIndicator
        '
        Me.taIndicator.ClearBeforeFill = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox9.Location = New System.Drawing.Point(28, 321)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(360, 160)
        Me.GroupBox9.TabIndex = 263
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Glandular Cells:"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.CheckBox1, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Label4, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.CheckBox2, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.CheckBox3, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Label5, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.CheckBox4, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Label6, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Label11, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(354, 141)
        Me.TableLayoutPanel5.TabIndex = 246
        '
        'CheckBox1
        '
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "GlandCellOther", True))
        Me.CheckBox1.Location = New System.Drawing.Point(282, 78)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(23, 19)
        Me.CheckBox1.TabIndex = 245
        '
        'CheckBox2
        '
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "GlandCellAden", True))
        Me.CheckBox2.Location = New System.Drawing.Point(282, 53)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(23, 19)
        Me.CheckBox2.TabIndex = 243
        '
        'CheckBox3
        '
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "GlandCellAtypical", True))
        Me.CheckBox3.Location = New System.Drawing.Point(282, 28)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(23, 19)
        Me.CheckBox3.TabIndex = 241
        '
        'CheckBox4
        '
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "GlandCellNoPres", True))
        Me.CheckBox4.Location = New System.Drawing.Point(282, 3)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(23, 19)
        Me.CheckBox4.TabIndex = 239
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.RichTextBox1)
        Me.GroupBox10.Location = New System.Drawing.Point(403, 321)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(351, 160)
        Me.GroupBox10.TabIndex = 262
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Notes:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCervical, "Notes", True))
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(345, 141)
        Me.RichTextBox1.TabIndex = 249
        Me.RichTextBox1.Text = ""
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox11.Location = New System.Drawing.Point(403, 96)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(351, 219)
        Me.GroupBox11.TabIndex = 261
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Squamous Cells:"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox5, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox6, 3, 6)
        Me.TableLayoutPanel6.Controls.Add(Label12, 2, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox7, 3, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox8, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Label13, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Label14, 2, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox9, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox10, 3, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox11, 3, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox12, 3, 2)
        Me.TableLayoutPanel6.Controls.Add(Label15, 2, 3)
        Me.TableLayoutPanel6.Controls.Add(Label16, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Label17, 2, 2)
        Me.TableLayoutPanel6.Controls.Add(Label18, 2, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox13, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Label19, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Label20, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox14, 3, 1)
        Me.TableLayoutPanel6.Controls.Add(Label21, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Label22, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.CheckBox15, 3, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 8
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(345, 200)
        Me.TableLayoutPanel6.TabIndex = 238
        '
        'CheckBox5
        '
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellSCC", True))
        Me.CheckBox5.Location = New System.Drawing.Point(71, 78)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(21, 19)
        Me.CheckBox5.TabIndex = 223
        '
        'CheckBox6
        '
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellSevDys", True))
        Me.CheckBox6.Location = New System.Drawing.Point(274, 153)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox6.TabIndex = 237
        '
        'CheckBox7
        '
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellModDys", True))
        Me.CheckBox7.Location = New System.Drawing.Point(274, 128)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox7.TabIndex = 235
        '
        'CheckBox8
        '
        Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellHSIL", True))
        Me.CheckBox8.Location = New System.Drawing.Point(71, 53)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(21, 19)
        Me.CheckBox8.TabIndex = 221
        '
        'CheckBox9
        '
        Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellLSIL", True))
        Me.CheckBox9.Location = New System.Drawing.Point(71, 28)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(21, 19)
        Me.CheckBox9.TabIndex = 219
        '
        'CheckBox10
        '
        Me.CheckBox10.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellCondy", True))
        Me.CheckBox10.Location = New System.Drawing.Point(274, 78)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox10.TabIndex = 231
        '
        'CheckBox11
        '
        Me.CheckBox11.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellMildDys", True))
        Me.CheckBox11.Location = New System.Drawing.Point(274, 103)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox11.TabIndex = 233
        '
        'CheckBox12
        '
        Me.CheckBox12.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellSuggHSIL", True))
        Me.CheckBox12.Location = New System.Drawing.Point(274, 53)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox12.TabIndex = 229
        '
        'CheckBox13
        '
        Me.CheckBox13.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellASCUS", True))
        Me.CheckBox13.Location = New System.Drawing.Point(71, 3)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(21, 19)
        Me.CheckBox13.TabIndex = 217
        '
        'CheckBox14
        '
        Me.CheckBox14.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellSuggLSIL", True))
        Me.CheckBox14.Location = New System.Drawing.Point(274, 28)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox14.TabIndex = 227
        '
        'CheckBox15
        '
        Me.CheckBox15.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "SqCellFavorReact", True))
        Me.CheckBox15.Location = New System.Drawing.Point(274, 3)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox15.TabIndex = 225
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupBox12.Location = New System.Drawing.Point(403, -20)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(351, 110)
        Me.GroupBox12.TabIndex = 260
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Evaluation Limited By:"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.97102!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.02899!))
        Me.TableLayoutPanel7.Controls.Add(Label23, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Label24, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.CheckBox16, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.CheckBox17, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.CheckBox18, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Label25, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 4
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(345, 91)
        Me.TableLayoutPanel7.TabIndex = 200
        '
        'CheckBox16
        '
        Me.CheckBox16.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "EvalLimitScantCell", True))
        Me.CheckBox16.Location = New System.Drawing.Point(271, 53)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox16.TabIndex = 199
        '
        'CheckBox17
        '
        Me.CheckBox17.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "EvalLimitObInf", True))
        Me.CheckBox17.Location = New System.Drawing.Point(271, 28)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox17.TabIndex = 197
        '
        'CheckBox18
        '
        Me.CheckBox18.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "EvalLimitObBlood", True))
        Me.CheckBox18.Location = New System.Drawing.Point(271, 3)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(24, 19)
        Me.CheckBox18.TabIndex = 195
        '
        'GroupBox13
        '
        Me.GroupBox13.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.81356!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.18644!))
        Me.TableLayoutPanel8.Controls.Add(Me.CheckBox19, 1, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.CheckBox20, 1, 7)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 8
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'CheckBox19
        '
        Me.CheckBox19.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "IntResTrich", True))
        Me.CheckBox19.Location = New System.Drawing.Point(160, 63)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox19.TabIndex = 207
        '
        'CheckBox20
        '
        Me.CheckBox20.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "IntResBact", True))
        Me.CheckBox20.Location = New System.Drawing.Point(160, 143)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox20.TabIndex = 215
        '
        'CheckBox21
        '
        Me.CheckBox21.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bsCervical, "IntResMeta", True))
        Me.CheckBox21.Location = New System.Drawing.Point(282, 153)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(15, 19)
        Me.CheckBox21.TabIndex = 213
        '
        'taAnalPath
        '
        Me.taAnalPath.ClearBeforeFill = True
        '
        'TbStuHpvPatVisitPregnancyScreeningTableAdapter
        '
        Me.TbStuHpvPatVisitPregnancyScreeningTableAdapter.ClearBeforeFill = True
        '
        'DdvPregnancyOutcomeTypeTableAdapter
        '
        Me.DdvPregnancyOutcomeTypeTableAdapter.ClearBeforeFill = True
        '
        'taDdvPhysician
        '
        Me.taDdvPhysician.ClearBeforeFill = True
        '
        'DdvResearcherTableAdapter
        '
        Me.DdvResearcherTableAdapter.ClearBeforeFill = True
        '
        'frmStuHpvPatVisitEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(809, 643)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboVisitNum)
        Me.Controls.Add(Me.tabHpvVst)
        Me.Controls.Add(Me.txtVisitNum)
        Me.Controls.Add(Me.chk1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStuHpvPatVisitEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing RIS Visit"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHpvVst.ResumeLayout(False)
        Me.tabHpvVstP1.ResumeLayout(False)
        Me.tabHpvVstP1.PerformLayout()
        CType(Me.bsPhysician, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHpvVstP4.ResumeLayout(False)
        Me.tabHpvVstP4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabHpvVstContactHX.ResumeLayout(False)
        Me.tabHpvVstPrepForms.ResumeLayout(False)
        Me.tabPrepForms.ResumeLayout(False)
        Me.tabCervicalPrep.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpCerv1.ResumeLayout(False)
        Me.grpCerv1.PerformLayout()
        CType(Me.bsCervical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAdequacy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCerv2.ResumeLayout(False)
        Me.grpCerv2.PerformLayout()
        CType(Me.bsIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCerv5.ResumeLayout(False)
        Me.grpCerv5.PerformLayout()
        CType(Me.bsddvPathologist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCerv4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.grpCerv3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tabAnalPrep.ResumeLayout(False)
        Me.tabAnalPrep.PerformLayout()
        Me.grpAnal2.ResumeLayout(False)
        Me.grpAnal2.PerformLayout()
        CType(Me.bsAnalPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAdequacy1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAnal5.ResumeLayout(False)
        Me.grpAnal5.PerformLayout()
        CType(Me.bsddvPathologist1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.grpAnal4.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.grpAnal3.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.grpAnal1.ResumeLayout(False)
        Me.grpAnal1.PerformLayout()
        CType(Me.bsIndicator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabHpvVstPregScreenForm.ResumeLayout(False)
        Me.TabHpvVstPregScreenForm.PerformLayout()
        Me.grpPregScreening.ResumeLayout(False)
        Me.grpPregScreening.PerformLayout()
        CType(Me.DdvPregnancyOutcomeTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsResearcher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvPathologistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvPathIndicatorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvPathIndicatorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvPathIndicatorBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim FormActivated As Boolean = False
    Dim conn As OleDbConnection

    Dim LvwsAreDirty As Boolean = False
    Dim LvwFormPFIsDirty As Boolean = False
    Dim LvwFormRIsDirty As Boolean = False
    Dim LvwProcIsDirty As Boolean = False
    Dim LvwSpecIsDirty As Boolean = False
    Dim LvwVacIsDirty As Boolean = False

    Dim shtVisitNum As Short
    Dim cboVisitNumOldValue As String




    Private Sub frmStuHpvPatVisitEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'RISdataDataSet.ddvPregnancyOutcomeType' table. You can move, or remove it, as needed.
        Me.DdvPregnancyOutcomeTypeTableAdapter.Connection.ConnectionString = strConn
        Me.DdvPregnancyOutcomeTypeTableAdapter.FillAll(Me.RISdataDataSet.ddvPregnancyOutcomeType)



        Me.taDdvPhysician.Connection.ConnectionString = strConn
        Me.DdvResearcherTableAdapter.Connection.ConnectionString = strConn

        Try
            '* fill physicians            
            Dim MyBlankPhysicianRow As ddvPhysicianRow = Me.RISdataDataSet.ddvPhysician.NewRow
            MyBlankPhysicianRow.PhysicianCd = 0
            MyBlankPhysicianRow.LastName = ""
            Me.RISdataDataSet.ddvPhysician.Rows.Add(MyBlankPhysicianRow)

            Me.taDdvPhysician.ClearBeforeFill = False
            Me.taDdvPhysician.Fill(Me.RISdataDataSet.ddvPhysician)

            Me.DdvResearcherTableAdapter.ClearBeforeFill = True
            Me.DdvResearcherTableAdapter.Fill(Me.RISdataDataSet.ddvResearcher)
        Catch ex As Exception
            MsgBox("Fill Physicians: " & ex.Message & " " & ex.StackTrace)
        End Try


        Try
            'Need the following to Retrieve Microsoft Access Autonumber Value
            'for: xLvwIdx = Me.txtVisitID.Text on save
            conn = New OleDbConnection
            conn.ConnectionString = strConn
            AddHandler da1.RowUpdated, AddressOf da1_OnRowUpdate

            Me.TbStuHpvPatVisitPregnancyScreeningTableAdapter.Connection.ConnectionString = strConn
            Me.taIndicator.Connection.ConnectionString = strConn
            Me.taPathologist.Connection.ConnectionString = strConn
            Me.taCervical.Connection.ConnectionString = strConn
            Me.taAdequacy.Connection.ConnectionString = strConn
            Me.taAnalPath.Connection.ConnectionString = strConn

            Dim StudyType As String = vfrmPatient.txtGender.Text

            Dim EpisodeType As Int16 = 1
            With vfrmPatient
                If .lvwHpvEpi.SelectedItems(0).SubItems(.lvwHpvEpi.Columns.Count - 1).Text <> "" Then
                    EpisodeType = vfrmPatient.lvwHpvEpi.SelectedItems(0).SubItems(.lvwHpvEpi.Columns.Count - 2).Text
                End If
            End With

            Fill_cboApptStatus()
            If vb.Left(Me.Text.ToString, 7) = "Editing" Then
                Me.cboVisitNum.Visible = False
                shtVisitNum = vfrmPatient.lvwHpvVst.SelectedItems(0).Text

                Fill_tbStuHpvPatVisit()
                FillDateTimeSlickers(Me, Me.ds.tbStuHpvPatVisit, "dts", 1)
                'FillCheckBoxes(Me, Me.ds.tbStuHpvPatVisit, "chk", 1)

                Me.Text = "Editing " & LookUp("VisitNumDescLong", "ddvStuHpvVisitNum", _
                                 "VisitNum=" & shtVisitNum) & " ..."

                Me.BindCervicalPrepForm(Me.Tag)
                Me.BindAnalPrepForm(Me.Tag)
                SetupPregnancyScreen(Me.Tag)
                Fill_LvwContactHx(Me.Tag)

                ShowContactInfo(True)
            Else
                'SetColumnDefaultValue() 'Need this before AddNew
                Me.BindingContext(Me.ds, "tbStuHpvPatVisit").AddNew()
                'Need this after AddNew
                Me.BindingContext(Me.ds, "tbStuHpvPatVisit").Position = 0

                Fill_cboVisitNum(EpisodeType)

                If cboVisitNum.Items.Count > 0 Then
                    cboVisitNum.SelectedIndex = 0
                    shtVisitNum = cboVisitNum.SelectedValue
                    cboVisitNumOldValue = cboVisitNum.Text
                End If

                dts1.Text = GetVisitDate() ' Today                
                With vfrmPatient
                    Me.ds.tbStuHpvPatVisit.Rows(0).Item("EpisodeID") = .lvwHpvEpi.SelectedItems(0).SubItems(.lvwHpvEpi.Columns.Count - 1).Text
                    Me.ds.tbStuHpvPatVisit.Rows(0).Item("VisitNum") = shtVisitNum
                    Me.ds.tbStuHpvPatVisit.Item(0).VisitDate = dts1.Value
                End With

                Me.BindCervicalPrepForm(0)
                Me.BindAnalPrepForm(0)

                '* DISABLE CONTACT IMPORT TILL SAVE IS COMPLETE
                ShowContactInfo(False)

                Me.Text = "Adding a new visit ..."
            End If

            FillDateTimeSlickersTime(Me, Me.ds.tbStuHpvPatVisit, "dtsTime", 1, "09:00 AM")

            '* SHOW EPISODE TYPE INFO

            Fill_Lvws()

            'Me.tabHpvVst.SelectedIndex = vfrmPatient.tabHpvVst.SelectedIndex

            'Do not show prep forms for anal or cervical if first visit
            'If shtVisitNum <> 1 Then
            'Sets connection strings for tableadapters on Prep Forms 
            Me.SetConnectionStrings()
            'Fills dropdown tables for prep form tables
            Me.FillReferenceTables()

            Me.cmbPathAdequacyCd.SelectedIndex = -1
            Me.TransZoneIndicatorCdComboBox.SelectedIndex = -1
            Me.cmbPathologistCd.SelectedIndex = -1
            Me.cmbAdeq.SelectedIndex = -1
            Me.cmbTransComp.SelectedIndex = -1
            Me.cmbPath.SelectedIndex = -1
            'Else
            '* KIRK Dec 10 2008, We now want to show all the tabs on all visit numbers
            'Me.tabHpvVst.TabPages.Remove(Me.tabHpvVstPrepForms)
            'Me.tabHpvVst.TabPages.Remove(Me.TabHpvVstPregScreenForm)
            'End If

            If vfrmPatient.HPVStudyCD = 2 Then
                Me.tabHpvVst.TabPages.Remove(Me.TabHpvVstPregScreenForm)
            End If



        Catch ex As System.Exception
            MsgBox(ex.Message & " " & ex.StackTrace)
        End Try

    End Sub
    Private Sub DisplayEpisodeTypeInfo(ByVal EpisodeType As Int16)
        Try
            If EpisodeType = 2 Then
                '* Extension of HPV
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ShowContactInfo(ByVal IsEnabled As Boolean)
        Me.btnAddHpvCtHx.Enabled = IsEnabled
        Me.btnEditHpvCtHx.Enabled = IsEnabled
        Me.btnDelHpvCtHx.Enabled = IsEnabled
    End Sub
    Private Sub SetConnectionStrings()
        Me.taAdequacy.Connection.ConnectionString = strConn
        Me.taIndicator.Connection.ConnectionString = strConn
        Me.taCervical.Connection.ConnectionString = strConn
        Me.taPathologist.Connection.ConnectionString = strConn
        Me.taAnalPath.Connection.ConnectionString = strConn
    End Sub

    Private Sub FillReferenceTables()
        With Me.RISdataDataSet
            Me.taPathologist.Fill(.ddvPathologist)
            Me.taIndicator.Fill(.ddvPathIndicator)
            Me.taAdequacy.Fill(.ddvPathAdequacy)
        End With

    End Sub
    Private Sub SetupPregnancyScreen(ByVal VisitID As String)
        '* LOAD THE CURRENT PREGNANCYSCREENING
        Dim MyNewPregnancyScreenRow As RISdataDataSet.tbStuHpvPatVisitPregnancyScreeningRow
        Me.TbStuHpvPatVisitPregnancyScreeningTableAdapter.FillByVisitID(Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening, VisitID)
        If Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening.Rows.Count > 0 Then
            Me.chkPregScreening.Checked = True
            MyNewPregnancyScreenRow = Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening(0)
            If Not MyNewPregnancyScreenRow Is Nothing Then
                If Not MyNewPregnancyScreenRow.IsCurrentPregNull Then
                    If MyNewPregnancyScreenRow.CurrentPreg = True Then
                        Me.chkPregYes.Checked = True
                        Me.chkPregNo.Checked = False
                    Else
                        Me.chkPregYes.Checked = False
                        Me.chkPregNo.Checked = True
                    End If
                End If
                If Not MyNewPregnancyScreenRow.IsTodayPregNull Then
                    If MyNewPregnancyScreenRow.TodayPreg = True Then
                        Me.chkThinkPregYes.Checked = True
                        Me.chkThinkPregNo.Checked = False
                    Else
                        Me.chkThinkPregYes.Checked = False
                        Me.chkThinkPregNo.Checked = True
                    End If
                End If
                If Not MyNewPregnancyScreenRow.IsTermPregNull Then
                    Me.cboOutComeOfPreg.SelectedValue = MyNewPregnancyScreenRow.TermPreg
                End If
                If Not MyNewPregnancyScreenRow.IsTermDateNull Then
                    Me.DtTermPregnancy.Value = MyNewPregnancyScreenRow.TermDate
                Else
                    Me.DtTermPregnancy.Checked = False
                End If
                If Not MyNewPregnancyScreenRow.IsTermDateEstimateNull Then
                    Me.txtDtTermPregnancy.Text = MyNewPregnancyScreenRow.TermDateEstimate
                End If
                If Not MyNewPregnancyScreenRow.IsPeriodNowNull Then
                    If MyNewPregnancyScreenRow.PeriodNow = True Then
                        Me.chkHavePeriodYes.Checked = True
                        Me.chkHavePeriodNo.Checked = False
                    Else
                        Me.chkHavePeriodYes.Checked = False
                        Me.chkHavePeriodNo.Checked = True
                    End If
                End If
            End If
        Else
            Me.chkPregScreening.Checked = False
            MyNewPregnancyScreenRow = Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening.NewRow()
            MyNewPregnancyScreenRow.VisitID = VisitID
            Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening.Rows.Add(MyNewPregnancyScreenRow)
        End If
        LvwsAreDirty = False
    End Sub
    Private Sub frmStuHpvPatVisitEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'need this so that dts1_TextChanged won't fire on Load, only after activated
        FormActivated = True
    End Sub

    Private Sub frmPatientEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmStuHpvPatVisitEdit = Nothing
    End Sub

    Friend Function GetNextVisitNum(ByVal lvw As ListView) As String

        Dim i As Integer
        Dim VisitText As String
        Dim StatusText As String
        Dim CommaStr As String = ""

        With lvw
            For i = 0 To .Items.Count - 1
                '*PREVIOUS VISIT NUM
                VisitText = Trim(.Items(i).SubItems(0).Text)
                '*PREVIOUS VISIT STATUS
                StatusText = UCase(Trim(.Items(i).SubItems(3).Text))

                If StatusText = "COMPLETED" Or StatusText = "SKIPPED" Then
                    GetNextVisitNum = GetNextVisitNum & CommaStr & VisitText
                    CommaStr = ","
                End If
            Next i
        End With

    End Function
    Private Sub Fill_cboVisitNum(ByVal EpisodeType As Int16)

        Try

            Dim strSQL As String
            Dim arlVisitNum As New ArrayList
            Dim MyFilter As String = ""
            With vfrmPatient

                If EpisodeType = 2 Then
                    strSQL = "SELECT VisitNumDescLong, VisitNum FROM ddvStuHpvVisitNum WHERE VisitNum>=7 "

                    If .lvwHpvVst.Items.Count > 0 Then
                        MyFilter = GetNextVisitNum(.lvwHpvVst)
                        If MyFilter <> "" Then
                            strSQL = strSQL & " AND VisitNum NOT IN (" & GetNextVisitNum(.lvwHpvVst) & ")"
                        End If
                    End If
                Else
                    strSQL = "SELECT VisitNumDescLong, VisitNum FROM ddvStuHpvVisitNum WHERE NOT VisitNum IN(7,8) "

                    If .lvwHpvVst.Items.Count > 1 Then
                        MyFilter = GetNextVisitNum(.lvwHpvVst)
                        If MyFilter <> "" Then
                            strSQL = strSQL & " AND VisitNum NOT IN (" & GetNextVisitNum(.lvwHpvVst) & ")"
                        End If
                    End If
                End If
            End With

            Dim conn As New OleDbConnection(strConn)
            Dim cmd As New OleDbCommand(strSQL, conn)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        arlVisitNum.Add(New struDescValuePair(.Item(0), .Item(1)))
                    Loop

                    With Me.cboVisitNum
                        .DataSource = arlVisitNum
                        .DisplayMember = "getDesc"
                        .ValueMember = "getValue"
                        .SelectedIndex = 0
                    End With
                End If
                .Close()
            End With
            conn.Close()


        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Fill_tbStuHpvPatVisit()
        Try
            'Dim conn As New OleDbConnection(strConn)
            With vfrmPatient
                da1SelectComm.Connection = conn
                da1SelectComm.CommandText = _
                   "SELECT * FROM tbStuHpvPatVisit WHERE VisitID=" & _
                          .lvwHpvVst.SelectedItems(0).SubItems(.lvwHpvVst.Columns.Count - 1).Text
            End With
            da1.Fill(ds.tbStuHpvPatVisit)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function GetVisitNum() As Short
        Try
            With vfrmPatient.lvwHpvVst
                GetVisitNum = .Items.Count + 1
                If .Items.Count = 0 Then Exit Function
                For i As Short = 0 To .Items.Count - 1
                    If .Items(i).Text <> i + 1 Then
                        GetVisitNum = i + 1
                        Exit Function
                    End If
                Next
            End With
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function GetVisitDate() As Date
        Try
            With vfrmPatient.lvwHpvVst
                If .Items.Count = 0 Or shtVisitNum = 1 Or shtVisitNum >= 7 Then
                    GetVisitDate = Today
                    Exit Function
                End If
            End With

            With Me.cboVisitNum
                Dim lblHpvVstDateX As Label
                lblHpvVstDateX = CType(FindControl(vfrmPatient, "lblHpvVstDate" & .SelectedValue - 1), Label)

                Dim NumMonthsToAdd As Short = 0

                Select Case .SelectedValue
                    Case 2
                        NumMonthsToAdd = 2
                    Case 3
                        NumMonthsToAdd = 4
                    Case 4
                        NumMonthsToAdd = 6
                    Case 5
                        NumMonthsToAdd = 6
                    Case 6
                        NumMonthsToAdd = 6
                    Case Else
                        NumMonthsToAdd = 6
                End Select

                If lblHpvVstDateX.Text <> "" And IsDate(lblHpvVstDateX.Text) Then
                    GetVisitDate = CType(lblHpvVstDateX.Text, Date).AddMonths(NumMonthsToAdd)
                Else
                    MsgBox("Previous visit was not completed, current visit date as been set to today.", MsgBoxStyle.Information, "Visit Information")
                End If
            End With
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub da1_OnRowUpdate(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)

        'If vb.Left(Me.Text.ToString, 6) = "Adding" Then
        If e.StatementType = StatementType.Insert Then
            Dim oCmd As New OleDbCommand("SELECT @@IDENTITY")
            oCmd.Connection = conn
            e.Row("VisitID") = oCmd.ExecuteScalar()
            e.Row.AcceptChanges()
            Me.Tag = e.Row("VisitID")

            'shtVisitNum = e.Row("VisitID")
            'MsgBox(e.Row("VisitID"))
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Try

            Dim resp As MsgBoxResult
            Me.bsCervical.EndEdit()
            Me.bsAnalPath.EndEdit()

            If vb.Left(Me.Text.ToString, 6) = "Adding" Then
                resp = MsgBox("Do you want to add this new visit?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then

                    If ValidationPassed() Then

                        'MsgBox(System.DateTime.Now.ToString)
                        txtLastEditDate.Text = System.DateTime.Now
                        Me.BindingContext(Me.ds, "tbStuHpvPatVisit").EndCurrentEdit()
                        ' MsgBox(Me.OleDbInsertCommand1.CommandText)
                        Cursor.Current = Cursors.WaitCursor
                        UpdateDataSourceAddNew(Me.ds, "tbStuHpvPatVisit", conn, Me.da1)

                        '* SAVE SCREENING
                        If Me.chkCervPrep.Checked Then
                            Me.UpdatetbStuHpvPatVisitCervical(Me.Tag)
                        End If
                        If Me.chkAnalPrep.Checked Then
                            Me.UpdatetbStuHpvPatVisitAnal(Me.Tag)
                        End If
                        If Me.chkPregScreening.Checked Then
                            SavePregnancyScreen(Me.Tag)
                        End If

                        CloseAndUpdate()
                        Cursor.Current = Cursors.Default

                    End If

                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If

            Else

                Dim objDataSetChanges As DataSet1 = New DataSet1
                Me.BindingContext(Me.ds, "tbStuHpvPatVisit").EndCurrentEdit()
                objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)
                If (Not (objDataSetChanges) Is Nothing) Or LvwsAreDirty Or Validation.CheckForChanges(Me.RISdataDataSet.tbStuHpvPatVisitCervicalPath) _
                Or Validation.CheckForChanges(Me.RISdataDataSet.tbStuHpvPatVisitAnalPath) Then
                    resp = MsgBox("Do you want to save your changes?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                    If resp = MsgBoxResult.Yes Then

                        If ValidationPassed() Then
                            'Must cancel edit first

                            Me.BindingContext(Me.ds, "tbStuHpvPatVisit").CancelCurrentEdit()
                            txtLastEditDate.Text = System.DateTime.Now
                            Me.BindingContext(Me.ds, "tbStuHpvPatVisit").EndCurrentEdit()
                            objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)

                            Cursor.Current = Cursors.WaitCursor
                            UpdateDataSource(objDataSetChanges, conn, Me.da1)



                            If Me.chkCervPrep.Checked Then
                                Me.UpdatetbStuHpvPatVisitCervical()
                            Else
                                '* DO DELETE
                                Me.DeletetbStuHpvPatVisitCervical()
                            End If
                            If Me.chkAnalPrep.Checked Then
                                Me.UpdatetbStuHpvPatVisitAnal()
                            Else
                                '* DO DELETE
                                Me.DeletetbStuHpvPatVisitAnal()
                            End If
                            If Me.chkPregScreening.Checked Then
                                SavePregnancyScreen(0)
                            Else
                                '* REMOVE PREG SCREEN IF IN DB
                                DeletePregnancyScreen(0)
                            End If



                            CloseAndUpdate()
                            Cursor.Current = Cursors.Default

                        End If

                    ElseIf resp = MsgBoxResult.No Then
                        Me.Close()
                    ElseIf resp = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If
                Else
                    Me.Close()
                End If

            End If

        Catch ex As System.Exception
            MsgBox("here")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CloseAndUpdate()

        Cursor.Current = Cursors.WaitCursor

        tabHpvVst.SelectedIndex = 2 'Need this because txtVisitID is in this tab
        xLvwIdx = Me.txtVisitID.Text  'Need this 
        'MsgBox(xLvwIdx)
        'MsgBox(shtVisitNum)
        If LvwsAreDirty Then
            Update_FormAndProcAct()
        End If





        Me.Close()
        With vfrmPatient
            If UCase(.cboStudy.SelectedItem.ToString) = "HPV PATIENTS TO FOLLOW UP" Then
                .Fill_lvwHpvEpiFU()
                'SelectLvwItem(.lvwHpvEpi, .lvwHpvEpiFU.Items(0).Text, .lvwHpvEpi.Columns.Count - 1)
            End If

            .Update_tabHpv(False)
            SelectLvwItem(.lvwHpvVst, xLvwIdx, .lvwHpvVst.Columns.Count - 1)
            .lvwHpvVst.Focus()
            .Update_tabHpvVst()
        End With

        Cursor.Current = Cursors.Default

    End Sub
    Private Sub Update_FormAndProcAct()

        If LvwFormPFIsDirty Then Update_FormBy(1, Me.lvwHpvVstFormPF)
        If LvwFormRIsDirty Then Update_FormBy(2, Me.lvwHpvVstFormR)
        If LvwProcIsDirty Then Update_ProcActBy(1, Me.lvwHpvVstProc)
        If LvwSpecIsDirty Then Update_ProcActBy(2, Me.lvwHpvVstSpec)
        If LvwVacIsDirty Then Update_ProcActBy(3, Me.lvwHpvVstVac)

    End Sub

    Private Sub Update_FormBy(ByVal FormPurposeCd As Short, ByVal lvw As ListView)

        RunSQL("DELETE * FROM tbStuHpvPatVisitForm " & _
               "WHERE VisitID=" & Me.txtVisitID.Text & " AND FormCd IN " & _
               "(SELECT FormCd FROM trefStuHpvFormCd_FormPurposeCd " & _
                "WHERE FormPurposeCd=" & FormPurposeCd & ")")

        'Create text file DataToInsert.txt with data to be inserted into 
        'table tbStuHpvPatVisitSpecShippedDetails
        FileOpen(1, appPath & "\DataToInsert.txt", OpenMode.Output, OpenAccess.Write)
        'Write column name
        Print(1, "VisitID, FormCd, LastEditDate" & vbNewLine)
        For Each itm As ListViewItem In lvw.Items
            If itm.Checked Then
                Print(1, Me.txtVisitID.Text & ", " & _
                         itm.SubItems(lvw.Columns.Count - 1).Text & ", " & _
                         Today & vbNewLine)
            End If
        Next
        FileClose(1)
        'Insert data from text file ShipDetails.txt into 
        'table tbStuHpvPatVisitSpecShippedDetails 
        Dim strSQL As String = _
           "INSERT INTO tbStuHpvPatVisitForm " & _
           "SELECT * FROM [Text;Database=" & appPath & "\" & _
           ";HDR=YES;FMT=Delimited].[DataToInsert.txt]"
        RunSQL(strSQL)

        Exit Sub
        For Each itm As ListViewItem In lvw.Items
            If itm.Checked Then
                RunSQL("INSERT INTO tbStuHpvPatVisitForm " & _
                      "(VisitID, FormCd, LastEditDate) " & _
                       "VALUES (" & Me.txtVisitID.Text & ", " & _
                                    itm.SubItems(lvw.Columns.Count - 1).Text & ", NOW)")
            End If
        Next

    End Sub

    Private Sub Update_ProcActBy(ByVal ActivityCd As Short, ByVal lvw As ListView)

        RunSQL("DELETE * FROM tbStuHpvPatVisitProcAct " & _
               "WHERE ActivityCd=" & ActivityCd & " AND VisitID=" & Me.txtVisitID.Text)

        'Create text file DataToInsert.txt with data to be inserted into 
        'table tbStuHpvPatVisitSpecShippedDetails
        FileOpen(1, appPath & "\DataToInsert.txt", OpenMode.Output, OpenAccess.Write)
        'Write column name
        Print(1, "VisitID, ProcCd, ActivityCd, LastEditDate" & vbNewLine)
        For Each itm As ListViewItem In lvw.Items
            If itm.Checked Then
                Print(1, Me.txtVisitID.Text & ", " & _
                         itm.SubItems(lvw.Columns.Count - 1).Text & ", " & _
                         ActivityCd & ", " & _
                         Today & vbNewLine)
            End If
        Next
        FileClose(1)
        'Insert data from text file ShipDetails.txt into 
        'table tbStuHpvPatVisitSpecShippedDetails 
        Dim strSQL As String = _
           "INSERT INTO tbStuHpvPatVisitProcAct " & _
           "SELECT * FROM [Text;Database=" & appPath & "\" & _
           ";HDR=YES;FMT=Delimited].[DataToInsert.txt]"
        RunSQL(strSQL)

        Exit Sub
        For Each itm As ListViewItem In lvw.Items
            If itm.Checked Then
                RunSQL("INSERT INTO tbStuHpvPatVisitProcAct " & _
                      "(VisitID, ProcCd, ActivityCd, LastEditDate) " & _
                       "VALUES (" & Me.txtVisitID.Text & ", " & _
                                    itm.SubItems(lvw.Columns.Count - 1).Text & ", " & _
                                    ActivityCd & ", NOW)")
            End If
        Next

    End Sub

    Private Sub Fill_Lvws()
        'Me.tabHpvVst.SelectedIndex = 1 'need this!
        With vfrmPatient
            If vb.Left(Me.Text.ToString, 7) = "Editing" Then
                If .tabHpvVst.SelectedIndex <> 1 Then 'need this
                    .Fill_lvwHpvVstForm(.lvwHpvVstFormPF, 1)
                    .Fill_lvwHpvVstForm(.lvwHpvVstFormR, 2)
                    .Fill_lvwHpvVstProc(.lvwHpvVstProc, 1)
                    .Fill_lvwHpvVstProc(.lvwHpvVstSpec, 2)
                    .Fill_lvwHpvVstProc(.lvwHpvVstVac, 3)
                End If
                'LvwMoveAll(.lvwHpvVstFormPF, Me.lvwHpvVstFormPF, False, False, True, False)
                Fill_LvwSelectedForm(Me.lvwHpvVstFormPF, .lvwHpvVstFormPF)
                'LvwMoveAll(.lvwHpvVstFormR, Me.lvwHpvVstFormR, False, False, True, False)
                Fill_LvwSelectedForm(Me.lvwHpvVstFormR, .lvwHpvVstFormR)
                'LvwMoveAll(.lvwHpvVstProc, Me.lvwHpvVstProc, False, False, True, False)
                Fill_LvwSelectedProc(Me.lvwHpvVstProc, .lvwHpvVstProc)
                'LvwMoveAll(.lvwHpvVstSpec, Me.lvwHpvVstSpec, False, False, True, False)
                Fill_LvwSelectedProc(Me.lvwHpvVstSpec, .lvwHpvVstSpec)
                'LvwMoveAll(.lvwHpvVstVac, Me.lvwHpvVstVac, False, False, True, False)
                Fill_LvwSelectedProc(Me.lvwHpvVstVac, .lvwHpvVstVac)
                Fill_LvwAvailableForm(Me.lvwHpvVstFormPF, .lvwHpvVstFormPF, 1, .PatientGender)
                Fill_LvwAvailableForm(Me.lvwHpvVstFormR, .lvwHpvVstFormR, 2, .PatientGender)
                Fill_LvwAvailableProc(Me.lvwHpvVstProc, .lvwHpvVstProc, 1, .PatientGender)
                Fill_LvwAvailableProc(Me.lvwHpvVstSpec, .lvwHpvVstSpec, 2, .PatientGender)
                Fill_LvwAvailableProc(Me.lvwHpvVstVac, .lvwHpvVstVac, 3, .PatientGender)
            Else
                'MsgBox("this")
                Fill_LvwAvailableForm(Me.lvwHpvVstFormPF, Me.lvwHpvVstFormPF, 1, .PatientGender)
                Fill_LvwAvailableForm(Me.lvwHpvVstFormR, Me.lvwHpvVstFormR, 2, .PatientGender)
                Fill_LvwAvailableProc(Me.lvwHpvVstProc, Me.lvwHpvVstProc, 1, .PatientGender)
                Fill_LvwAvailableProc(Me.lvwHpvVstSpec, Me.lvwHpvVstSpec, 2, .PatientGender)
                Fill_LvwAvailableProc(Me.lvwHpvVstVac, Me.lvwHpvVstVac, 3, .PatientGender)
            End If
        End With
    End Sub

    Private Sub Fill_LvwSelectedForm(ByVal lvw0 As ListView, ByVal lvw As ListView)

        If lvw.Items.Count = 0 Then Exit Sub
        Dim strSQL As String
        strSQL = "SELECT FormDesc, DisplayOrder, trefStuHpvVisitNum_FormCd.FormCd " & _
                 "FROM trefStuHpvVisitNum_FormCd LEFT JOIN ddvForm ON trefStuHpvVisitNum_FormCd.FormCd = ddvForm.FormCd " & _
                 "WHERE VisitNum=" & shtVisitNum & " AND " & _
                       "trefStuHpvVisitNum_FormCd.FormCd In (" & LvwItems(lvw, 1, False) & ") "
        Fill_lvw(lvw0, strSQL, , False, True)

    End Sub

    Private Sub Fill_LvwSelectedProc(ByVal lvw0 As ListView, ByVal lvw As ListView)

        If lvw.Items.Count = 0 Then Exit Sub
        Dim strSQL As String
        strSQL = "SELECT ProcDesc, DisplayOrder, trefStuHpvVisitNum_ProcCd.ProcCd " & _
                 "FROM trefStuHpvVisitNum_ProcCd " & _
                 "LEFT JOIN ddvProcedure ON trefStuHpvVisitNum_ProcCd.ProcCd = ddvProcedure.ProcCd " & _
                 "WHERE VisitNum=" & shtVisitNum & " AND " & _
                       "trefStuHpvVisitNum_ProcCd.ProcCd In (" & LvwItems(lvw, 1, False) & ") "
        Fill_lvw(lvw0, strSQL, , False, True)

    End Sub

    Private Sub Fill_LvwAvailableForm(ByVal lvw0 As ListView, ByVal lvw As ListView, ByVal FormPurposeCd As Short, ByVal Gender As String)

        Dim strSQL As String
        strSQL = "SELECT FormDesc, DisplayOrder, trefStuHpvVisitNum_FormCd.FormCd " & _
                 "FROM (trefStuHpvVisitNum_FormCd LEFT JOIN ddvForm ON trefStuHpvVisitNum_FormCd.FormCd = ddvForm.FormCd) LEFT JOIN trefStuHpvFormCd_FormPurposeCd ON trefStuHpvVisitNum_FormCd.FormCd = trefStuHpvFormCd_FormPurposeCd.FormCd " & _
                 "WHERE trefStuHpvFormCd_FormPurposeCd.FormPurposeCd=" & FormPurposeCd & " AND " & _
                       "VisitNum=" & shtVisitNum & " AND " & _
                       "trefStuHpvVisitNum_FormCd.Active<0 "
        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            If lvw.Items.Count > 0 Then
                strSQL = strSQL & " AND " & _
                           "trefStuHpvVisitNum_FormCd.FormCd Not In (" & LvwItems(lvw, 1, False) & ") "
                '& _
                '"ORDER BY DisplayOrder"
            End If
            Fill_lvw(lvw0, strSQL, False, False)
        Else
            'strSQL = strSQL & " ORDER BY DisplayOrder"
            Fill_lvw(lvw0, strSQL, , False)
        End If

        SortLvw(lvw0, 1, False)

    End Sub

    Private Sub Fill_LvwAvailableProc(ByVal lvw0 As ListView, ByVal lvw As ListView, ByVal ActivityCd As Short, ByVal Gender As String)

        Dim strSQL As String
        strSQL = "SELECT ProcDesc, DisplayOrder, trefStuHpvVisitNum_ProcCd.ProcCd " & _
                 "FROM (trefStuHpvVisitNum_ProcCd LEFT JOIN ddvProcedure ON trefStuHpvVisitNum_ProcCd.ProcCd = ddvProcedure.ProcCd) LEFT JOIN trefStuHpvProcCd_ActivityCd ON trefStuHpvVisitNum_ProcCd.ProcCd = trefStuHpvProcCd_ActivityCd.ProcCd " & _
                 "WHERE trefStuHpvProcCd_ActivityCd.ActivityCd=" & ActivityCd & " AND " & _
                       "VisitNum=" & shtVisitNum & " AND " & _
                       "trefStuHpvVisitNum_ProcCd.Active<0 "
        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            If lvw.Items.Count > 0 Then
                strSQL = strSQL & " AND " & _
                           "trefStuHpvVisitNum_ProcCd.ProcCd Not In (" & LvwItems(lvw, 1, False) & ")"
            End If
            Fill_lvw(lvw0, strSQL, False, False)
        Else
            Fill_lvw(lvw0, strSQL, , False)
        End If

        SortLvw(lvw0, 1, False)

    End Sub

    Private Sub Fill_LvwContactHx(ByVal VisitID As String)
        If Me.Tag <> "" Then
            Dim strSQL As String
            strSQL = "SELECT VisitID, Format(ContactDate, 'MM/dd/yyyy'), ContactMethodDesc, Notes, ContactID " & _
                                 "FROM tbStuHpvPatVisitContactHx LEFT JOIN ddvContactMethod ON " & _
                                      "tbStuHpvPatVisitContactHx.ContactMethodCd = ddvContactMethod.ContactMethodCd " & _
                                 "WHERE VisitID=" & VisitID & _
                                " ORDER BY ContactDate,ContactMethodDesc"
            Fill_lvw(Me.lvwHpvCtHx, strSQL, , False)
            ShowTotalOnLvw(Me.lvwHpvCtHx, 1)
            ShowLvwEditButtons(Me.lvwHpvCtHx, btnEditHpvCtHx, btnDelHpvCtHx)
        End If
    End Sub

    Private Sub SetColumnDefaultValue()
        Dim dt As DataTable = ds.Tables("tbStuHpvPatVisit")

        'The Checked property of a CheckBox control DOES NOT understand Null!
        'The control is checked if value is >0 and unchecked if 0.
        'So must set DefaultValue to 0 to have it unchecked!!!
        'dt.Columns("Completed").DefaultValue = 0
    End Sub

    Private Function ValidationPassed() As Boolean

        ValidationPassed = True

        If Me.dts1.Checked = False Then
            MsgBox("'Visit Date' is required.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information)
            Me.dts1.Focus()
            Return False
            Exit Function
        End If

        Dim EpisodeType As Int16 = 1
        With vfrmPatient
            If .lvwHpvEpi.SelectedItems(0).SubItems(.lvwHpvEpi.Columns.Count - 1).Text <> "" Then
                EpisodeType = vfrmPatient.lvwHpvEpi.SelectedItems(0).SubItems(.lvwHpvEpi.Columns.Count - 2).Text
            End If
        End With

        If EpisodeType <> 2 Then
            Dim VstDateLB As Date = FindVstDateLB(shtVisitNum)
            If dts1.Value <= VstDateLB Then
                If MsgBox("You have entered a visit date that is EARLIER THAN OR EQUAL to '" & VstDateLB & "' which is from the earlier visit " & _
                          "that's been entered into the system. Do you still want to save?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Return True
                Else
                    Me.dts1.Focus()
                    Return False
                End If
                Exit Function
            End If

            Dim VstDateUB As Date = FindVstDateUB(shtVisitNum)
            If dts1.Value >= VstDateUB Then
                If MsgBox("You have entered a visit date that is LATER THAN OR EQUAL to '" & VstDateUB & "' which is from the later visit " & _
                          "that's been entered into the system. Do you still want to save?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    Return True
                Else
                    Me.dts1.Focus()
                    Return False
                End If
                Exit Function
            End If
        End If
    End Function

    Private Sub dts1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.TextChanged
        If FormActivated Then
            Me.ds.tbStuHpvPatVisit.Item(0).VisitDate = dts1.Value
        End If
    End Sub

    Private Sub dts1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.CheckedChanged
        If FormActivated Then
            Select Case dts1.Checked
                Case True
                    Me.ds.tbStuHpvPatVisit.Item(0).VisitDate = dts1.Value
                Case False
                    Me.ds.tbStuHpvPatVisit.Item(0).SetVisitDateNull()
            End Select
        End If
    End Sub
    Private Sub dtsTime1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtsTime1.TextChanged
        If FormActivated Then
            Me.ds.tbStuHpvPatVisit.Item(0).VisitTime = dtsTime1.Text
        End If
    End Sub

    Private Sub dtsTime1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtsTime1.CheckedChanged
        If FormActivated Then
            With Me.ds.tbStuHpvPatVisit.Item(0)
                Select Case dtsTime1.Checked
                    Case True
                        .VisitTime = dtsTime1.Text
                    Case False
                        .SetVisitTimeNull()
                End Select
            End With
        End If
    End Sub

    Private Sub chk1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk1.Click
        If FormActivated Then
            'Me.ds.tbStuHpvPatVisit.Item(0).Completed = chk1.Checked
        End If
    End Sub

    Private Sub lvw_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) _
       Handles lvwHpvVstFormPF.ColumnClick, lvwHpvVstFormR.ColumnClick, lvwHpvVstProc.ColumnClick, lvwHpvVstSpec.ColumnClick, lvwHpvVstVac.ColumnClick

        Select Case sender.name
            Case "lvwHpvVstFormPF"
                SortLvw(lvwHpvVstFormPF, e.Column)
            Case "lvwHpvVstFormR"
                SortLvw(lvwHpvVstFormR, e.Column)
            Case "lvwHpvVstProc"
                SortLvw(lvwHpvVstProc, e.Column)
            Case "lvwHpvVstSpec"
                SortLvw(lvwHpvVstSpec, e.Column)
            Case "lvwHpvVstVac"
                SortLvw(lvwHpvVstVac, e.Column)
        End Select
    End Sub

    Private Sub lvw_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) _
        Handles lvwHpvVstFormPF.ItemCheck, lvwHpvVstFormR.ItemCheck, lvwHpvVstProc.ItemCheck, lvwHpvVstSpec.ItemCheck, lvwHpvVstVac.ItemCheck

        If FormActivated Then
            LvwsAreDirty = True
            Select Case sender.name
                Case "lvwHpvVstFormPF"
                    LvwFormPFIsDirty = True
                Case "lvwHpvVstFormR"
                    LvwFormRIsDirty = True
                Case "lvwHpvVstProc"
                    LvwProcIsDirty = True
                Case "lvwHpvVstSpec"
                    LvwSpecIsDirty = True
                Case "lvwHpvVstVac"
                    LvwVacIsDirty = True
            End Select
        End If

    End Sub

    Private Sub btnCheckAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles btnCheckAllFormPF.Click, btnCheckAllFormR.Click, btnCheckAllProc.Click, btnCheckAllSpec.Click, btnCheckAllVac.Click

        Select Case sender.name
            Case "btnCheckAllFormPF"
                LvwCheckAll(Me.lvwHpvVstFormPF, Me.btnCheckAllFormPF)
            Case "btnCheckAllFormR"
                LvwCheckAll(Me.lvwHpvVstFormR, Me.btnCheckAllFormR)
            Case "btnCheckAllProc"
                LvwCheckAll(Me.lvwHpvVstProc, Me.btnCheckAllProc)
            Case "btnCheckAllSpec"
                LvwCheckAll(Me.lvwHpvVstSpec, Me.btnCheckAllSpec)
            Case "btnCheckAllVac"
                LvwCheckAll(Me.lvwHpvVstVac, Me.btnCheckAllVac)
        End Select

    End Sub

    Private Sub cboVisitNum_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVisitNum.SelectedValueChanged

        'If FormActivated Then MsgBox(shtVisitNum)
        If FormActivated Then
            If vb.Left(Me.Text.ToString, 6) = "Adding" Then

                If cboVisitNum.Text <> cboVisitNumOldValue Then
                    cboVisitNumOldValue = cboVisitNum.Text
                    shtVisitNum = cboVisitNum.SelectedValue
                    Fill_Lvws()
                End If

            End If
        End If
    End Sub

    Private Function FindVstDateLB(ByVal VisitNum As Short) As Date

        'Find the visit date of the next visit that's earlier than this one
        FindVstDateLB = #1/1/1000#
        Dim strTempText As String
        For i As Short = VisitNum - 1 To 1 Step -1
            strTempText = CType(FindControl(vfrmPatient, "lblHpvVstDate" & i), Label).Text
            If strTempText.Length > 0 And vb.Right(strTempText, 1) <> "*" Then
                FindVstDateLB = strTempText
                Exit Function
            End If
        Next

    End Function

    Private Function FindVstDateUB(ByVal VisitNum As Short) As Date

        'Find the visit date of the next visit that's later than this one
        FindVstDateUB = #1/1/9999#
        Dim strTempText As String
        For i As Short = VisitNum + 1 To 6
            strTempText = CType(FindControl(vfrmPatient, "lblHpvVstDate" & i), Label).Text
            If strTempText.Length > 0 And vb.Right(strTempText, 1) <> "*" Then
                FindVstDateUB = strTempText
                Exit Function
            End If
        Next

    End Function

    Private Sub Fill_cboApptStatus()
        Try

            Dim strSQL As String
            Dim arlApptStatus As New ArrayList

            strSQL = "SELECT ApptStatusDesc, ApptStatusCd FROM ddvStuHpvApptStatus"

            Dim conn As New OleDbConnection(strConn)
            Dim cmd As New OleDbCommand(strSQL, conn)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        arlApptStatus.Add(New struDescValuePair(.Item(0), .Item(1)))
                    Loop
                End If
                .Close()
            End With
            conn.Close()
            'Add an empty choice
            arlApptStatus.Add(New struDescValuePair("", Nothing))

            With Me.cboApptStatus
                .DataSource = arlApptStatus
                .DisplayMember = "getDesc"
                .ValueMember = "getValue"
                .MaxDropDownItems = .Items.Count
            End With

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddHpvCtHx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHpvCtHx.Click
        If vfrmStuHpvCtHxEdit Is Nothing Then
            vfrmStuHpvCtHxEdit = New frmStuHpvCtHxEdit
            With vfrmStuHpvCtHxEdit
                .Text = "Adding a new contact hx . . ."
                .ParentVisitfrm = Me
                .ShowDialog()
                Fill_LvwContactHx(Me.Tag)
            End With
        End If
    End Sub

    Private Sub btnEditHpvCtHx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditHpvCtHx.Click, lvwHpvCtHx.DoubleClick
        With lvwHpvCtHx
            If .SelectedItems.Count > 0 Then
                Try
                    'xLvwIdx = lvwHpvVst.SelectedItems(0).Index
                    If vfrmStuHpvCtHxEdit Is Nothing Then
                        vfrmStuHpvCtHxEdit = New frmStuHpvCtHxEdit
                        With vfrmStuHpvCtHxEdit
                            vfrmStuHpvCtHxEdit.ParentVisitfrm = Me
                            .ShowDialog()
                            Fill_LvwContactHx(Me.Tag)
                        End With
                    End If
                Catch ex As System.Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Please select a desired item from the HPV contact hx list to edit.", MsgBoxStyle.Information)
                .Focus()
            End If
        End With
    End Sub

    Private Sub btnDelHpvCtHx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelHpvCtHx.Click
        With lvwHpvCtHx
            If .SelectedItems.Count > 0 Then
                If MsgBox("Are you sure you want to delete the selected contact hx?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    RunSQL("DELETE * FROM tbStuHpvPatVisitContactHx WHERE ContactID=" & _
                            lvwHpvCtHx.SelectedItems(0).SubItems(lvwHpvCtHx.Columns.Count - 1).Text)

                    Fill_LvwContactHx(Me.Tag)

                    With vfrmPatient
                        .Update_tabHpvVst()
                        SelectLvwItem(.lvwHpvCtHx, xLvwIdx, .lvwHpvCtHx.Columns.Count - 1)
                    End With
                End If
            Else
                MsgBox("Please select a desired item from the HPV contact hx list to delete.", MsgBoxStyle.Information)
                .Focus()
            End If
        End With
    End Sub


    Public Sub BindCervicalPrepForm(ByVal VisitID As Integer)
        If Me.taCervical.FillByVisitID(Me.RISdataDataSet.tbStuHpvPatVisitCervicalPath, VisitID) = 0 Then
            Me.chkCervPrep.Checked = False
            Me.bsCervical.AddNew()
            Dim Row As tbStuHpvPatVisitCervicalPathRow = Me.GetCurrecntCervicalPathRow
            If Row IsNot Nothing Then
                Row.VisitID = VisitID
            End If

            'If VisitID <> 0 Then
            'Me.UpdatetbStuHpvPatVisitCervical()
            'End If
        Else
            Me.chkCervPrep.Checked = True
        End If
    End Sub

    Public Sub BindAnalPrepForm(ByVal VisitID As Integer)
        If Me.taAnalPath.FillByVisitID(Me.RISdataDataSet.tbStuHpvPatVisitAnalPath, VisitID) = 0 Then
            Me.chkAnalPrep.Checked = False
            Me.bsAnalPath.AddNew()
            Dim Row As tbStuHpvPatVisitAnalPathRow = Me.GetCurrecntAnalPathRow
            If Row IsNot Nothing Then
                Row.VisitID = VisitID
            End If
            'If VisitID <> 0 Then
            'Me.UpdatetbStuHpvPatVisitAnal()
            'End If
        Else
            Me.chkAnalPrep.Checked = True
        End If
    End Sub

    Public Function GetCurrecntCervicalPathRow() As tbStuHpvPatVisitCervicalPathRow
        Dim Row As tbStuHpvPatVisitCervicalPathRow = Nothing
        If Me.bsCervical.Position <> -1 Then
            Row = CType(Me.bsCervical.Current, DataRowView).Row
        End If
        Return Row
    End Function

    Public Function GetCurrecntAnalPathRow() As tbStuHpvPatVisitAnalPathRow
        Dim Row As tbStuHpvPatVisitAnalPathRow = Nothing
        If Me.bsAnalPath.Position <> -1 Then
            Row = CType(Me.bsAnalPath.Current, DataRowView).Row
        End If
        Return Row
    End Function

    Private Sub UpdatetbStuHpvPatVisitCervical()
        Me.bsCervical.EndEdit()
        Dim Modified As tbStuHpvPatVisitCervicalPathDataTable
        Modified = Me.RISdataDataSet.tbStuHpvPatVisitCervicalPath.GetChanges(DataRowState.Modified)

        If Modified IsNot Nothing Then
            For Each r As tbStuHpvPatVisitCervicalPathRow In Modified

                r.LastEditDate = Now
                r.LastEditLoginID = strLoginID
            Next
        End If


        Dim Inserted As tbStuHpvPatVisitCervicalPathDataTable
        Inserted = Me.RISdataDataSet.tbStuHpvPatVisitCervicalPath.GetChanges(DataRowState.Added)
        If Inserted IsNot Nothing Then
            For Each r As tbStuHpvPatVisitCervicalPathRow In Inserted

                r.LastEditDate = Now
                r.LastEditLoginID = strLoginID
            Next
        End If


        Me.taCervical.Update(Me.RISdataDataSet.tbStuHpvPatVisitCervicalPath)
        Me.BindCervicalPrepForm(Me.Tag)

    End Sub

    Private Sub UpdatetbStuHpvPatVisitAnal()
        Me.bsAnalPath.EndEdit()
        Dim Modified As tbStuHpvPatVisitAnalPathDataTable
        Modified = Me.RISdataDataSet.tbStuHpvPatVisitAnalPath.GetChanges(DataRowState.Modified)
        If Modified IsNot Nothing Then
            For Each r As tbStuHpvPatVisitAnalPathRow In Modified

                r.LastEditDate = Now
                r.LastEditLoginID = strLoginID
            Next
        End If

        Dim Inserted As tbStuHpvPatVisitAnalPathDataTable
        Inserted = Me.RISdataDataSet.tbStuHpvPatVisitAnalPath.GetChanges(DataRowState.Added)
        If Inserted IsNot Nothing Then
            For Each r As tbStuHpvPatVisitAnalPathRow In Inserted

                r.LastEditDate = Now
                r.LastEditLoginID = strLoginID
            Next
        End If


        Me.taAnalPath.Update(Me.RISdataDataSet.tbStuHpvPatVisitAnalPath)
        Me.BindAnalPrepForm(Me.Tag)

    End Sub

    Private Sub UpdatetbStuHpvPatVisitCervical(ByVal VisitID As Integer)
        Dim Row As tbStuHpvPatVisitCervicalPathRow = Me.GetCurrecntCervicalPathRow
        If Row IsNot Nothing Then
            Row.VisitID = VisitID
        End If
        Me.UpdatetbStuHpvPatVisitCervical()
    End Sub
    Private Sub DeletetbStuHpvPatVisitCervical()
        Dim Row As tbStuHpvPatVisitCervicalPathRow = Me.GetCurrecntCervicalPathRow
        If Row IsNot Nothing Then
            Row.Delete()
            Try
                Me.UpdatetbStuHpvPatVisitCervical()
            Catch
            End Try
        End If
    End Sub

    Private Sub UpdatetbStuHpvPatVisitAnal(ByVal VisitID As Integer)
        Dim Row As tbStuHpvPatVisitAnalPathRow = Me.GetCurrecntAnalPathRow
        If Row IsNot Nothing Then
            Row.VisitID = VisitID
        End If
        Me.UpdatetbStuHpvPatVisitAnal()
    End Sub
    Private Sub DeletetbStuHpvPatVisitAnal()
        Dim Row As tbStuHpvPatVisitAnalPathRow = Me.GetCurrecntAnalPathRow
        If Row IsNot Nothing Then
            Row.Delete()
            Try
                Me.UpdatetbStuHpvPatVisitAnal()
            Catch
            End Try
        End If
    End Sub
    Private Sub SaveAnalScreen(ByVal VisitID As Integer)
        Dim MyNewAnalScreenRow As RISdataDataSet.tbStuHpvPatVisitAnalPathRow
        If Me.RISdataDataSet.tbStuHpvPatVisitAnalPath.Rows.Count > 0 Then
            MyNewAnalScreenRow = Me.RISdataDataSet.tbStuHpvPatVisitAnalPath.Rows(0)
        Else
            MyNewAnalScreenRow = Me.RISdataDataSet.tbStuHpvPatVisitAnalPath.NewRow()
            MyNewAnalScreenRow.VisitID = VisitID
            Me.RISdataDataSet.tbStuHpvPatVisitAnalPath.Rows.Add(MyNewAnalScreenRow)
        End If
        'UpdatetbStuHpvPatPregScreenRow(MyNewAnalScreenRow)
        'MyNewPregnancyScreenRow.LastEditDate = Now
        'If strLoginID.Length > 10 Then
        'MyNewPregnancyScreenRow.LastEditLoginID = strLoginID.Substring(1, 10)
        'Else
        'MyNewPregnancyScreenRow.LastEditLoginID = strLoginID
        'End If
        Me.taAnalPath.Update(Me.RISdataDataSet.tbStuHpvPatVisitAnalPath)
    End Sub
    Private Sub SavePregnancyScreen(ByVal VisitID As Integer)
        Dim MyNewPregnancyScreenRow As RISdataDataSet.tbStuHpvPatVisitPregnancyScreeningRow
        If Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening.Rows.Count > 0 Then
            MyNewPregnancyScreenRow = Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening.Rows(0)
        Else
            MyNewPregnancyScreenRow = Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening.NewRow()
            MyNewPregnancyScreenRow.VisitID = VisitID
            Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening.Rows.Add(MyNewPregnancyScreenRow)
        End If
        UpdatetbStuHpvPatPregScreenRow(MyNewPregnancyScreenRow)
        MyNewPregnancyScreenRow.LastEditDate = Now
        If strLoginID.Length > 10 Then
            MyNewPregnancyScreenRow.LastEditLoginID = strLoginID.Substring(1, 10)
        Else
            MyNewPregnancyScreenRow.LastEditLoginID = strLoginID
        End If
        Me.TbStuHpvPatVisitPregnancyScreeningTableAdapter.Update(Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening)
    End Sub
    Private Sub DeletePregnancyScreen(ByVal VisitID As Integer)
        If Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening.Rows.Count > 0 Then
            Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening.Rows(0).Delete()
        End If
        Try
            Me.TbStuHpvPatVisitPregnancyScreeningTableAdapter.Update(Me.RISdataDataSet.tbStuHpvPatVisitPregnancyScreening)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdatetbStuHpvPatPregScreenRow(ByRef MyNewPregnancyScreenRow As RISdataDataSet.tbStuHpvPatVisitPregnancyScreeningRow)
        MyNewPregnancyScreenRow.CurrentPreg = Me.chkPregYes.Checked
        MyNewPregnancyScreenRow.TodayPreg = Me.chkThinkPregYes.Checked
        MyNewPregnancyScreenRow.TermPreg = Me.cboOutComeOfPreg.SelectedValue
        If Me.DtTermPregnancy.Checked Then
            MyNewPregnancyScreenRow.TermDate = Me.DtTermPregnancy.Value
        Else
            MyNewPregnancyScreenRow.SetTermDateNull()
        End If
        MyNewPregnancyScreenRow.TermDateEstimate = Me.txtDtTermPregnancy.Text
        MyNewPregnancyScreenRow.PeriodNow = Me.chkHavePeriodYes.Checked
    End Sub

    Private Sub chkPregYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPregYes.CheckedChanged
        LvwsAreDirty = True
        If Me.chkPregYes.Checked Then
            Me.chkPregNo.Checked = False
        End If
    End Sub

    Private Sub chkPregNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPregNo.CheckedChanged
        LvwsAreDirty = True
        If Me.chkPregNo.Checked Then
            Me.chkPregYes.Checked = False
        End If
    End Sub

    Private Sub chkThinkPregYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkThinkPregYes.CheckedChanged
        LvwsAreDirty = True
        If Me.chkThinkPregYes.Checked Then
            Me.chkThinkPregNo.Checked = False
        End If
    End Sub

    Private Sub chkThinkPregNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkThinkPregNo.CheckedChanged
        LvwsAreDirty = True
        If Me.chkThinkPregNo.Checked Then
            Me.chkThinkPregYes.Checked = False
        End If
    End Sub
    Private Sub chkHavePeriodYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHavePeriodYes.CheckedChanged
        LvwsAreDirty = True
        If Me.chkHavePeriodYes.Checked Then
            Me.chkHavePeriodNo.Checked = False
        End If
    End Sub

    Private Sub chkHavePeriodNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHavePeriodNo.CheckedChanged
        LvwsAreDirty = True
        If Me.chkHavePeriodNo.Checked Then
            Me.chkHavePeriodYes.Checked = False
        End If
    End Sub

    Private Sub txtDtTermPregnancy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDtTermPregnancy.TextChanged
        LvwsAreDirty = True
    End Sub

    Private Sub DtTermPregnancy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtTermPregnancy.ValueChanged
        LvwsAreDirty = True
    End Sub

    Private Sub cboOutComeOfPreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutComeOfPreg.Click
        LvwsAreDirty = True
    End Sub

    Private Sub chkPregScreening_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPregScreening.CheckedChanged
        Me.grpPregScreening.Enabled = Me.chkPregScreening.Checked
        LvwsAreDirty = True
    End Sub

    Private Sub chkAnalPrep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnalPrep.CheckedChanged
        Me.grpAnal1.Enabled = chkAnalPrep.Checked
        Me.grpAnal2.Enabled = chkAnalPrep.Checked
        Me.grpAnal3.Enabled = chkAnalPrep.Checked
        Me.grpAnal4.Enabled = chkAnalPrep.Checked
        Me.grpAnal5.Enabled = chkAnalPrep.Checked
        LvwsAreDirty = True
    End Sub

    Private Sub chkCervPrep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCervPrep.CheckedChanged
        Me.grpCerv1.Enabled = chkCervPrep.Checked
        Me.grpCerv2.Enabled = chkCervPrep.Checked
        Me.grpCerv3.Enabled = chkCervPrep.Checked
        Me.grpCerv4.Enabled = chkCervPrep.Checked
        Me.grpCerv5.Enabled = chkCervPrep.Checked
        LvwsAreDirty = True
    End Sub

    Private Sub cboPhysician_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPhysician.SelectedIndexChanged
        If FormActivated Then
            If Me.cboPhysician.SelectedValue = 0 Then
                Me.ds.tbStuHpvPatVisit.Item(0).SetPhysicianCdNull()
            Else
                Me.ds.tbStuHpvPatVisit.Item(0).PhysicianCd = Me.cboPhysician.SelectedValue
            End If
        End If
    End Sub


    Private Sub cboResearcher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If FormActivated Then
        '    If Me.cboResearcher.SelectedValue = 0 Then
        '        Me.ds.tbStuHpvPatVisit.Item(0).SetResearcherCDNull()
        '    Else
        '        Me.ds.tbStuHpvPatVisit.Item(0).ResearcherCD = Me.cboResearcher.SelectedValue
        '    End If
        'End If
    End Sub

    Private Sub OleDbConnection3_InfoMessage(sender As Object, e As OleDbInfoMessageEventArgs) Handles OleDbConnection3.InfoMessage

    End Sub

    Private Sub lvwHpvVstFormPF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwHpvVstFormPF.SelectedIndexChanged

    End Sub
End Class
