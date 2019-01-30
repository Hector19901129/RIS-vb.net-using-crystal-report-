Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb
Imports RIS.DataSet1
Imports RIS.DataSet1TableAdapters

Public Class frmStuHpvEpiEdit
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
    Friend WithEvents ada1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLastEditDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEpisodeID As System.Windows.Forms.TextBox
    Friend WithEvents ada1SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DS As RIS.DataSet1
    Friend WithEvents RiSdataDataSet1 As RIS.RISdataDataSet
    Friend WithEvents DdvStuHpvSubjEntryTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvStuHpvSubjEntryTypeTableAdapter As RIS.RISdataDataSettableadapters.ddvStuHpvSubjEntryTypeTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDateVaccinated As System.Windows.Forms.TextBox
    Friend WithEvents lblDateVaccinated As System.Windows.Forms.Label
    Friend WithEvents lblEntryType As System.Windows.Forms.Label
    Friend WithEvents cboEntryType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents cboEligible As System.Windows.Forms.ComboBox
    Friend WithEvents txtSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dts1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDateVaccinatedOr As System.Windows.Forms.Label
    Friend WithEvents DTVaccinatedDt As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents cboConsent As System.Windows.Forms.ComboBox
    Friend WithEvents lblConsent As System.Windows.Forms.Label
    Friend WithEvents cboConsentOtherResearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboConsentDirect As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboConsentContact As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DTVaccinatedDt2 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents lblDateVaccinatedOr2 As System.Windows.Forms.Label
    Friend WithEvents txtDateVaccinated2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDateVaccinated2 As System.Windows.Forms.Label
    Friend WithEvents DTVaccinatedDt1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents lblDateVaccinatedOr1 As System.Windows.Forms.Label
    Friend WithEvents txtDateVaccinated1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDateVaccinated1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboResearcher As System.Windows.Forms.ComboBox
    Friend WithEvents BSResearchers As System.Windows.Forms.BindingSource
    Friend WithEvents DdvResearcherTableAdapter As RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter
    Friend WithEvents txtReferredBy As System.Windows.Forms.TextBox
    Friend WithEvents lblReferredBy As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboEpisodeStatus As System.Windows.Forms.ComboBox
    Friend WithEvents DdvStuHpvEpisodeStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvStuHpvEpisodeStatusTableAdapter As RIS.RISdataDataSetTableAdapters.ddvStuHpvEpisodeStatusTableAdapter
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboEpisodeType As System.Windows.Forms.ComboBox
    Friend WithEvents DdvStuHpvEpisodeTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DdvStuHpvEpisodeTypeTableAdapter As RIS.RISdataDataSettableadapters.ddvStuHpvEpisodeTypeTableAdapter
    Friend WithEvents DtTerminationDt As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents lblSelfSampling As System.Windows.Forms.Label
    Friend WithEvents chkSelfSampling As System.Windows.Forms.CheckBox
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStuHpvEpiEdit))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ada1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.ada1SelectComm = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLastEditDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEpisodeID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DS = New RIS.DataSet1()
        Me.RiSdataDataSet1 = New RIS.RISdataDataSet()
        Me.DdvStuHpvSubjEntryTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DdvStuHpvSubjEntryTypeTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvStuHpvSubjEntryTypeTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSelfSampling = New System.Windows.Forms.Label()
        Me.chkSelfSampling = New System.Windows.Forms.CheckBox()
        Me.DtTerminationDt = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboEpisodeType = New System.Windows.Forms.ComboBox()
        Me.DdvStuHpvEpisodeTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboEpisodeStatus = New System.Windows.Forms.ComboBox()
        Me.DdvStuHpvEpisodeStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtReferredBy = New System.Windows.Forms.TextBox()
        Me.lblReferredBy = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboResearcher = New System.Windows.Forms.ComboBox()
        Me.BSResearchers = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTVaccinatedDt2 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.lblDateVaccinatedOr2 = New System.Windows.Forms.Label()
        Me.txtDateVaccinated2 = New System.Windows.Forms.TextBox()
        Me.lblDateVaccinated2 = New System.Windows.Forms.Label()
        Me.DTVaccinatedDt1 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.lblDateVaccinatedOr1 = New System.Windows.Forms.Label()
        Me.txtDateVaccinated1 = New System.Windows.Forms.TextBox()
        Me.lblDateVaccinated1 = New System.Windows.Forms.Label()
        Me.cboConsentOtherResearch = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboConsentDirect = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboConsentContact = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboConsent = New System.Windows.Forms.ComboBox()
        Me.lblConsent = New System.Windows.Forms.Label()
        Me.DTVaccinatedDt = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.lblDateVaccinatedOr = New System.Windows.Forms.Label()
        Me.txtDateVaccinated = New System.Windows.Forms.TextBox()
        Me.lblDateVaccinated = New System.Windows.Forms.Label()
        Me.lblEntryType = New System.Windows.Forms.Label()
        Me.cboEntryType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.cboEligible = New System.Windows.Forms.ComboBox()
        Me.txtSubjectID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dts1 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DdvResearcherTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvResearcherTableAdapter()
        Me.DdvStuHpvEpisodeStatusTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvStuHpvEpisodeStatusTableAdapter()
        Me.DdvStuHpvEpisodeTypeTableAdapter = New RIS.RISdataDataSetTableAdapters.ddvStuHpvEpisodeTypeTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RiSdataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvStuHpvSubjEntryTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DdvStuHpvEpisodeTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvStuHpvEpisodeStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSResearchers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 1
        Me.btnExit.Location = New System.Drawing.Point(384, 550)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 20)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ada1
        '
        Me.ada1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.ada1.InsertCommand = Me.OleDbInsertCommand1
        Me.ada1.SelectCommand = Me.ada1SelectComm
        Me.ada1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbStuHpvEpisode", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Eligible", "Eligible"), New System.Data.Common.DataColumnMapping("EpisodeDate", "EpisodeDate"), New System.Data.Common.DataColumnMapping("EpisodeID", "EpisodeID"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("SubjectID", "SubjectID"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("SubjEntryTypeCd", "SubjEntryTypeCd"), New System.Data.Common.DataColumnMapping("VaccineDateKnown", "VaccineDateKnown"), New System.Data.Common.DataColumnMapping("VaccineDateEst", "VaccineDateEst"), New System.Data.Common.DataColumnMapping("ConsentStoreSerum", "ConsentStoreSerum"), New System.Data.Common.DataColumnMapping("ConsentContact", "ConsentContact"), New System.Data.Common.DataColumnMapping("ConsentDirect", "ConsentDirect"), New System.Data.Common.DataColumnMapping("ConsentOtherResearch", "ConsentOtherResearch"), New System.Data.Common.DataColumnMapping("Vaccine2DateKnown", "Vaccine2DateKnown"), New System.Data.Common.DataColumnMapping("Vaccine2DateEst", "Vaccine2DateEst"), New System.Data.Common.DataColumnMapping("Vaccine3DateKnown", "Vaccine3DateKnown"), New System.Data.Common.DataColumnMapping("Vaccine3DateEst", "Vaccine3DateEst"), New System.Data.Common.DataColumnMapping("ResearcherCd", "ResearcherCd"), New System.Data.Common.DataColumnMapping("ReferredBy", "ReferredBy")})})
        Me.ada1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM tbStuHpvEpisode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (EpisodeID = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EpisodeID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Bittersweet Software\Bittersweet" &
    " Software Working Folder\RIS\RIS\bin\Data\RISdata.mdb"""
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Eligible", System.Data.OleDb.OleDbType.WChar, 3, "Eligible"), New System.Data.OleDb.OleDbParameter("EpisodeDate", System.Data.OleDb.OleDbType.[Date], 0, "EpisodeDate"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.WChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.[Integer], 0, "PatientID"), New System.Data.OleDb.OleDbParameter("SubjectID", System.Data.OleDb.OleDbType.WChar, 5, "SubjectID"), New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.WChar, 255, "Notes"), New System.Data.OleDb.OleDbParameter("SubjEntryTypeCd", System.Data.OleDb.OleDbType.[Integer], 0, "SubjEntryTypeCd"), New System.Data.OleDb.OleDbParameter("VaccineDateKnown", System.Data.OleDb.OleDbType.[Date], 0, "VaccineDateKnown"), New System.Data.OleDb.OleDbParameter("VaccineDateEst", System.Data.OleDb.OleDbType.WChar, 50, "VaccineDateEst"), New System.Data.OleDb.OleDbParameter("ConsentStoreSerum", System.Data.OleDb.OleDbType.WChar, 3, "ConsentStoreSerum"), New System.Data.OleDb.OleDbParameter("ConsentContact", System.Data.OleDb.OleDbType.WChar, 255, "ConsentContact"), New System.Data.OleDb.OleDbParameter("ConsentDirect", System.Data.OleDb.OleDbType.WChar, 255, "ConsentDirect"), New System.Data.OleDb.OleDbParameter("ConsentOtherResearch", System.Data.OleDb.OleDbType.WChar, 255, "ConsentOtherResearch"), New System.Data.OleDb.OleDbParameter("Vaccine2DateKnown", System.Data.OleDb.OleDbType.[Date], 0, "Vaccine2DateKnown"), New System.Data.OleDb.OleDbParameter("Vaccine2DateEst", System.Data.OleDb.OleDbType.WChar, 50, "Vaccine2DateEst"), New System.Data.OleDb.OleDbParameter("Vaccine3DateKnown", System.Data.OleDb.OleDbType.[Date], 0, "Vaccine3DateKnown"), New System.Data.OleDb.OleDbParameter("Vaccine3DateEst", System.Data.OleDb.OleDbType.WChar, 50, "Vaccine3DateEst"), New System.Data.OleDb.OleDbParameter("ResearcherCd", System.Data.OleDb.OleDbType.[Integer], 0, "ResearcherCd"), New System.Data.OleDb.OleDbParameter("ReferredBy", System.Data.OleDb.OleDbType.WChar, 255, "ReferredBy"), New System.Data.OleDb.OleDbParameter("EpisodeStatus", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeStatus"), New System.Data.OleDb.OleDbParameter("EpisodeType", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeType"), New System.Data.OleDb.OleDbParameter("TerminationDt", System.Data.OleDb.OleDbType.[Date], 0, "TerminationDt"), New System.Data.OleDb.OleDbParameter("SelfSampling", System.Data.OleDb.OleDbType.[Boolean], 2, "SelfSampling")})
        '
        'ada1SelectComm
        '
        Me.ada1SelectComm.CommandText = resources.GetString("ada1SelectComm.CommandText")
        Me.ada1SelectComm.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Eligible", System.Data.OleDb.OleDbType.WChar, 3, "Eligible"), New System.Data.OleDb.OleDbParameter("EpisodeDate", System.Data.OleDb.OleDbType.[Date], 0, "EpisodeDate"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.WChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.[Integer], 0, "PatientID"), New System.Data.OleDb.OleDbParameter("SubjectID", System.Data.OleDb.OleDbType.WChar, 5, "SubjectID"), New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.WChar, 255, "Notes"), New System.Data.OleDb.OleDbParameter("SubjEntryTypeCd", System.Data.OleDb.OleDbType.[Integer], 0, "SubjEntryTypeCd"), New System.Data.OleDb.OleDbParameter("VaccineDateKnown", System.Data.OleDb.OleDbType.[Date], 0, "VaccineDateKnown"), New System.Data.OleDb.OleDbParameter("VaccineDateEst", System.Data.OleDb.OleDbType.WChar, 50, "VaccineDateEst"), New System.Data.OleDb.OleDbParameter("ConsentStoreSerum", System.Data.OleDb.OleDbType.WChar, 3, "ConsentStoreSerum"), New System.Data.OleDb.OleDbParameter("ConsentContact", System.Data.OleDb.OleDbType.WChar, 255, "ConsentContact"), New System.Data.OleDb.OleDbParameter("ConsentDirect", System.Data.OleDb.OleDbType.WChar, 255, "ConsentDirect"), New System.Data.OleDb.OleDbParameter("ConsentOtherResearch", System.Data.OleDb.OleDbType.WChar, 255, "ConsentOtherResearch"), New System.Data.OleDb.OleDbParameter("Vaccine2DateKnown", System.Data.OleDb.OleDbType.[Date], 0, "Vaccine2DateKnown"), New System.Data.OleDb.OleDbParameter("Vaccine2DateEst", System.Data.OleDb.OleDbType.WChar, 50, "Vaccine2DateEst"), New System.Data.OleDb.OleDbParameter("Vaccine3DateKnown", System.Data.OleDb.OleDbType.[Date], 0, "Vaccine3DateKnown"), New System.Data.OleDb.OleDbParameter("Vaccine3DateEst", System.Data.OleDb.OleDbType.WChar, 50, "Vaccine3DateEst"), New System.Data.OleDb.OleDbParameter("ResearcherCd", System.Data.OleDb.OleDbType.[Integer], 0, "ResearcherCd"), New System.Data.OleDb.OleDbParameter("ReferredBy", System.Data.OleDb.OleDbType.WChar, 255, "ReferredBy"), New System.Data.OleDb.OleDbParameter("EpisodeStatus", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeStatus"), New System.Data.OleDb.OleDbParameter("EpisodeType", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeType"), New System.Data.OleDb.OleDbParameter("TerminationDt", System.Data.OleDb.OleDbType.[Date], 0, "TerminationDt"), New System.Data.OleDb.OleDbParameter("SelfSampling", System.Data.OleDb.OleDbType.[Boolean], 2, "SelfSampling"), New System.Data.OleDb.OleDbParameter("Original_EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EpisodeID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLastEditDate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtPatientID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtEpisodeID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 564)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 100)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'txtLastEditDate
        '
        Me.txtLastEditDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastEditDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastEditDate.ForeColor = System.Drawing.Color.DimGray
        Me.txtLastEditDate.Location = New System.Drawing.Point(88, 69)
        Me.txtLastEditDate.Name = "txtLastEditDate"
        Me.txtLastEditDate.ReadOnly = True
        Me.txtLastEditDate.Size = New System.Drawing.Size(130, 21)
        Me.txtLastEditDate.TabIndex = 90
        Me.txtLastEditDate.TabStop = False
        Me.txtLastEditDate.Text = "LastEditDate"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Last Edit Date"
        '
        'txtPatientID
        '
        Me.txtPatientID.BackColor = System.Drawing.SystemColors.Control
        Me.txtPatientID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.ForeColor = System.Drawing.Color.DimGray
        Me.txtPatientID.Location = New System.Drawing.Point(88, 43)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(130, 21)
        Me.txtPatientID.TabIndex = 87
        Me.txtPatientID.TabStop = False
        Me.txtPatientID.Text = "PatientID"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(27, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Patient ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(6, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 15)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "For system use only"
        '
        'txtEpisodeID
        '
        Me.txtEpisodeID.BackColor = System.Drawing.SystemColors.Control
        Me.txtEpisodeID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpisodeID.ForeColor = System.Drawing.Color.DimGray
        Me.txtEpisodeID.Location = New System.Drawing.Point(88, 16)
        Me.txtEpisodeID.Name = "txtEpisodeID"
        Me.txtEpisodeID.ReadOnly = True
        Me.txtEpisodeID.Size = New System.Drawing.Size(130, 21)
        Me.txtEpisodeID.TabIndex = 92
        Me.txtEpisodeID.TabStop = False
        Me.txtEpisodeID.Text = "EpisodeID"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(27, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Episode ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DS
        '
        Me.DS.DataSetName = "DataSet1"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RiSdataDataSet1
        '
        Me.RiSdataDataSet1.DataSetName = "RISdataDataSet"
        Me.RiSdataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DdvStuHpvSubjEntryTypeBindingSource
        '
        Me.DdvStuHpvSubjEntryTypeBindingSource.DataMember = "ddvStuHpvSubjEntryType"
        Me.DdvStuHpvSubjEntryTypeBindingSource.DataSource = Me.RiSdataDataSet1
        '
        'DdvStuHpvSubjEntryTypeTableAdapter
        '
        Me.DdvStuHpvSubjEntryTypeTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSelfSampling)
        Me.GroupBox1.Controls.Add(Me.chkSelfSampling)
        Me.GroupBox1.Controls.Add(Me.DtTerminationDt)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cboEpisodeType)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cboEpisodeStatus)
        Me.GroupBox1.Controls.Add(Me.txtReferredBy)
        Me.GroupBox1.Controls.Add(Me.lblReferredBy)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cboResearcher)
        Me.GroupBox1.Controls.Add(Me.DTVaccinatedDt2)
        Me.GroupBox1.Controls.Add(Me.lblDateVaccinatedOr2)
        Me.GroupBox1.Controls.Add(Me.txtDateVaccinated2)
        Me.GroupBox1.Controls.Add(Me.lblDateVaccinated2)
        Me.GroupBox1.Controls.Add(Me.DTVaccinatedDt1)
        Me.GroupBox1.Controls.Add(Me.lblDateVaccinatedOr1)
        Me.GroupBox1.Controls.Add(Me.txtDateVaccinated1)
        Me.GroupBox1.Controls.Add(Me.lblDateVaccinated1)
        Me.GroupBox1.Controls.Add(Me.cboConsentOtherResearch)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cboConsentDirect)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cboConsentContact)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboConsent)
        Me.GroupBox1.Controls.Add(Me.lblConsent)
        Me.GroupBox1.Controls.Add(Me.DTVaccinatedDt)
        Me.GroupBox1.Controls.Add(Me.lblDateVaccinatedOr)
        Me.GroupBox1.Controls.Add(Me.txtDateVaccinated)
        Me.GroupBox1.Controls.Add(Me.lblDateVaccinated)
        Me.GroupBox1.Controls.Add(Me.lblEntryType)
        Me.GroupBox1.Controls.Add(Me.cboEntryType)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.cboEligible)
        Me.GroupBox1.Controls.Add(Me.txtSubjectID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dts1)
        Me.GroupBox1.Controls.Add(Me.Label60)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 542)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        '
        'lblSelfSampling
        '
        Me.lblSelfSampling.BackColor = System.Drawing.Color.Transparent
        Me.lblSelfSampling.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelfSampling.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblSelfSampling.Location = New System.Drawing.Point(2, 422)
        Me.lblSelfSampling.Name = "lblSelfSampling"
        Me.lblSelfSampling.Size = New System.Drawing.Size(161, 15)
        Me.lblSelfSampling.TabIndex = 156
        Me.lblSelfSampling.Text = "Self Sampling"
        Me.lblSelfSampling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkSelfSampling
        '
        Me.chkSelfSampling.AutoSize = True
        Me.chkSelfSampling.Location = New System.Drawing.Point(166, 422)
        Me.chkSelfSampling.Name = "chkSelfSampling"
        Me.chkSelfSampling.Size = New System.Drawing.Size(15, 14)
        Me.chkSelfSampling.TabIndex = 155
        Me.chkSelfSampling.UseVisualStyleBackColor = True
        '
        'DtTerminationDt
        '
        Me.DtTerminationDt.Enabled = False
        Me.DtTerminationDt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtTerminationDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTerminationDt.Location = New System.Drawing.Point(325, 69)
        Me.DtTerminationDt.Name = "DtTerminationDt"
        Me.DtTerminationDt.ShowCheckBox = True
        Me.DtTerminationDt.Size = New System.Drawing.Size(121, 21)
        Me.DtTerminationDt.TabIndex = 154
        Me.DtTerminationDt.Tag = "TerminationDt"
        Me.DtTerminationDt.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label20.Location = New System.Drawing.Point(2, 44)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 15)
        Me.Label20.TabIndex = 152
        Me.Label20.Text = "Episode Type:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEpisodeType
        '
        Me.cboEpisodeType.DataSource = Me.DdvStuHpvEpisodeTypeBindingSource
        Me.cboEpisodeType.DisplayMember = "EpisodeStuTypeNm"
        Me.cboEpisodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEpisodeType.Enabled = False
        Me.cboEpisodeType.FormattingEnabled = True
        Me.cboEpisodeType.Location = New System.Drawing.Point(166, 42)
        Me.cboEpisodeType.Name = "cboEpisodeType"
        Me.cboEpisodeType.Size = New System.Drawing.Size(170, 21)
        Me.cboEpisodeType.TabIndex = 151
        Me.cboEpisodeType.ValueMember = "EpisodeStuTypeID"
        '
        'DdvStuHpvEpisodeTypeBindingSource
        '
        Me.DdvStuHpvEpisodeTypeBindingSource.DataMember = "ddvStuHpvEpisodeType"
        Me.DdvStuHpvEpisodeTypeBindingSource.DataSource = Me.RiSdataDataSet1
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label19.Location = New System.Drawing.Point(2, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 15)
        Me.Label19.TabIndex = 150
        Me.Label19.Text = "Episode Status:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEpisodeStatus
        '
        Me.cboEpisodeStatus.DataSource = Me.DdvStuHpvEpisodeStatusBindingSource
        Me.cboEpisodeStatus.DisplayMember = "EpisodeStatus"
        Me.cboEpisodeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEpisodeStatus.FormattingEnabled = True
        Me.cboEpisodeStatus.Location = New System.Drawing.Point(166, 69)
        Me.cboEpisodeStatus.Name = "cboEpisodeStatus"
        Me.cboEpisodeStatus.Size = New System.Drawing.Size(148, 21)
        Me.cboEpisodeStatus.TabIndex = 1
        Me.cboEpisodeStatus.ValueMember = "EpisodeStatusID"
        '
        'DdvStuHpvEpisodeStatusBindingSource
        '
        Me.DdvStuHpvEpisodeStatusBindingSource.DataMember = "ddvStuHpvEpisodeStatus"
        Me.DdvStuHpvEpisodeStatusBindingSource.DataSource = Me.RiSdataDataSet1
        '
        'txtReferredBy
        '
        Me.txtReferredBy.BackColor = System.Drawing.SystemColors.Window
        Me.txtReferredBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferredBy.Location = New System.Drawing.Point(166, 203)
        Me.txtReferredBy.MaxLength = 255
        Me.txtReferredBy.Name = "txtReferredBy"
        Me.txtReferredBy.Size = New System.Drawing.Size(275, 21)
        Me.txtReferredBy.TabIndex = 6
        '
        'lblReferredBy
        '
        Me.lblReferredBy.BackColor = System.Drawing.Color.Transparent
        Me.lblReferredBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferredBy.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblReferredBy.Location = New System.Drawing.Point(2, 205)
        Me.lblReferredBy.Name = "lblReferredBy"
        Me.lblReferredBy.Size = New System.Drawing.Size(107, 15)
        Me.lblReferredBy.TabIndex = 148
        Me.lblReferredBy.Text = "Referred By:"
        Me.lblReferredBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label17.Location = New System.Drawing.Point(2, 151)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 15)
        Me.Label17.TabIndex = 146
        Me.Label17.Text = "Researcher:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboResearcher
        '
        Me.cboResearcher.DataSource = Me.BSResearchers
        Me.cboResearcher.DisplayMember = "LastName"
        Me.cboResearcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResearcher.FormattingEnabled = True
        Me.cboResearcher.Location = New System.Drawing.Point(166, 149)
        Me.cboResearcher.Name = "cboResearcher"
        Me.cboResearcher.Size = New System.Drawing.Size(170, 21)
        Me.cboResearcher.TabIndex = 4
        Me.cboResearcher.ValueMember = "ResearcherCd"
        '
        'BSResearchers
        '
        Me.BSResearchers.DataMember = "ddvResearcher"
        Me.BSResearchers.DataSource = Me.RiSdataDataSet1
        '
        'DTVaccinatedDt2
        '
        Me.DTVaccinatedDt2.Checked = False
        Me.DTVaccinatedDt2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTVaccinatedDt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTVaccinatedDt2.Location = New System.Drawing.Point(320, 284)
        Me.DTVaccinatedDt2.Name = "DTVaccinatedDt2"
        Me.DTVaccinatedDt2.ShowCheckBox = True
        Me.DTVaccinatedDt2.Size = New System.Drawing.Size(121, 21)
        Me.DTVaccinatedDt2.TabIndex = 12
        Me.DTVaccinatedDt2.Tag = "EpisodeDate"
        Me.DTVaccinatedDt2.Value = CType(resources.GetObject("DTVaccinatedDt2.Value"), Object)
        '
        'lblDateVaccinatedOr2
        '
        Me.lblDateVaccinatedOr2.BackColor = System.Drawing.Color.Transparent
        Me.lblDateVaccinatedOr2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateVaccinatedOr2.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDateVaccinatedOr2.Location = New System.Drawing.Point(293, 289)
        Me.lblDateVaccinatedOr2.Name = "lblDateVaccinatedOr2"
        Me.lblDateVaccinatedOr2.Size = New System.Drawing.Size(21, 15)
        Me.lblDateVaccinatedOr2.TabIndex = 144
        Me.lblDateVaccinatedOr2.Text = "Or"
        Me.lblDateVaccinatedOr2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDateVaccinated2
        '
        Me.txtDateVaccinated2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDateVaccinated2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateVaccinated2.Location = New System.Drawing.Point(166, 284)
        Me.txtDateVaccinated2.MaxLength = 50
        Me.txtDateVaccinated2.Name = "txtDateVaccinated2"
        Me.txtDateVaccinated2.Size = New System.Drawing.Size(121, 21)
        Me.txtDateVaccinated2.TabIndex = 11
        '
        'lblDateVaccinated2
        '
        Me.lblDateVaccinated2.BackColor = System.Drawing.Color.Transparent
        Me.lblDateVaccinated2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateVaccinated2.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDateVaccinated2.Location = New System.Drawing.Point(2, 287)
        Me.lblDateVaccinated2.Name = "lblDateVaccinated2"
        Me.lblDateVaccinated2.Size = New System.Drawing.Size(107, 15)
        Me.lblDateVaccinated2.TabIndex = 143
        Me.lblDateVaccinated2.Text = "Date Vaccinated #3:"
        Me.lblDateVaccinated2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTVaccinatedDt1
        '
        Me.DTVaccinatedDt1.Checked = False
        Me.DTVaccinatedDt1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTVaccinatedDt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTVaccinatedDt1.Location = New System.Drawing.Point(320, 257)
        Me.DTVaccinatedDt1.Name = "DTVaccinatedDt1"
        Me.DTVaccinatedDt1.ShowCheckBox = True
        Me.DTVaccinatedDt1.Size = New System.Drawing.Size(121, 21)
        Me.DTVaccinatedDt1.TabIndex = 10
        Me.DTVaccinatedDt1.Tag = "EpisodeDate"
        Me.DTVaccinatedDt1.Value = CType(resources.GetObject("DTVaccinatedDt1.Value"), Object)
        '
        'lblDateVaccinatedOr1
        '
        Me.lblDateVaccinatedOr1.BackColor = System.Drawing.Color.Transparent
        Me.lblDateVaccinatedOr1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateVaccinatedOr1.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDateVaccinatedOr1.Location = New System.Drawing.Point(293, 262)
        Me.lblDateVaccinatedOr1.Name = "lblDateVaccinatedOr1"
        Me.lblDateVaccinatedOr1.Size = New System.Drawing.Size(21, 15)
        Me.lblDateVaccinatedOr1.TabIndex = 140
        Me.lblDateVaccinatedOr1.Text = "Or"
        Me.lblDateVaccinatedOr1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDateVaccinated1
        '
        Me.txtDateVaccinated1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDateVaccinated1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateVaccinated1.Location = New System.Drawing.Point(166, 257)
        Me.txtDateVaccinated1.MaxLength = 50
        Me.txtDateVaccinated1.Name = "txtDateVaccinated1"
        Me.txtDateVaccinated1.Size = New System.Drawing.Size(121, 21)
        Me.txtDateVaccinated1.TabIndex = 9
        '
        'lblDateVaccinated1
        '
        Me.lblDateVaccinated1.BackColor = System.Drawing.Color.Transparent
        Me.lblDateVaccinated1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateVaccinated1.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDateVaccinated1.Location = New System.Drawing.Point(2, 260)
        Me.lblDateVaccinated1.Name = "lblDateVaccinated1"
        Me.lblDateVaccinated1.Size = New System.Drawing.Size(107, 15)
        Me.lblDateVaccinated1.TabIndex = 139
        Me.lblDateVaccinated1.Text = "Date Vaccinated #2:"
        Me.lblDateVaccinated1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboConsentOtherResearch
        '
        Me.cboConsentOtherResearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsentOtherResearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConsentOtherResearch.ItemHeight = 13
        Me.cboConsentOtherResearch.Items.AddRange(New Object() {"Y", "N"})
        Me.cboConsentOtherResearch.Location = New System.Drawing.Point(166, 395)
        Me.cboConsentOtherResearch.Name = "cboConsentOtherResearch"
        Me.cboConsentOtherResearch.Size = New System.Drawing.Size(62, 21)
        Me.cboConsentOtherResearch.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(2, 397)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 15)
        Me.Label12.TabIndex = 136
        Me.Label12.Text = "Consent for Other Researchers"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboConsentDirect
        '
        Me.cboConsentDirect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsentDirect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConsentDirect.ItemHeight = 13
        Me.cboConsentDirect.Items.AddRange(New Object() {"Y", "N"})
        Me.cboConsentDirect.Location = New System.Drawing.Point(166, 368)
        Me.cboConsentDirect.Name = "cboConsentDirect"
        Me.cboConsentDirect.Size = New System.Drawing.Size(62, 21)
        Me.cboConsentDirect.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(2, 370)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 15)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "Consent for Direct Studies"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboConsentContact
        '
        Me.cboConsentContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsentContact.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConsentContact.ItemHeight = 13
        Me.cboConsentContact.Items.AddRange(New Object() {"Y", "N"})
        Me.cboConsentContact.Location = New System.Drawing.Point(166, 339)
        Me.cboConsentContact.Name = "cboConsentContact"
        Me.cboConsentContact.Size = New System.Drawing.Size(62, 21)
        Me.cboConsentContact.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(2, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 15)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Consent to Contact"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboConsent
        '
        Me.cboConsent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConsent.ItemHeight = 13
        Me.cboConsent.Items.AddRange(New Object() {"Y", "N"})
        Me.cboConsent.Location = New System.Drawing.Point(166, 312)
        Me.cboConsent.Name = "cboConsent"
        Me.cboConsent.Size = New System.Drawing.Size(62, 21)
        Me.cboConsent.TabIndex = 13
        '
        'lblConsent
        '
        Me.lblConsent.BackColor = System.Drawing.Color.Transparent
        Me.lblConsent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsent.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblConsent.Location = New System.Drawing.Point(2, 314)
        Me.lblConsent.Name = "lblConsent"
        Me.lblConsent.Size = New System.Drawing.Size(72, 15)
        Me.lblConsent.TabIndex = 130
        Me.lblConsent.Text = "Consent:"
        Me.lblConsent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTVaccinatedDt
        '
        Me.DTVaccinatedDt.Checked = False
        Me.DTVaccinatedDt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTVaccinatedDt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTVaccinatedDt.Location = New System.Drawing.Point(320, 230)
        Me.DTVaccinatedDt.Name = "DTVaccinatedDt"
        Me.DTVaccinatedDt.ShowCheckBox = True
        Me.DTVaccinatedDt.Size = New System.Drawing.Size(121, 21)
        Me.DTVaccinatedDt.TabIndex = 8
        Me.DTVaccinatedDt.Tag = "EpisodeDate"
        Me.DTVaccinatedDt.Value = CType(resources.GetObject("DTVaccinatedDt.Value"), Object)
        '
        'lblDateVaccinatedOr
        '
        Me.lblDateVaccinatedOr.BackColor = System.Drawing.Color.Transparent
        Me.lblDateVaccinatedOr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateVaccinatedOr.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDateVaccinatedOr.Location = New System.Drawing.Point(293, 235)
        Me.lblDateVaccinatedOr.Name = "lblDateVaccinatedOr"
        Me.lblDateVaccinatedOr.Size = New System.Drawing.Size(21, 15)
        Me.lblDateVaccinatedOr.TabIndex = 128
        Me.lblDateVaccinatedOr.Text = "Or"
        Me.lblDateVaccinatedOr.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDateVaccinated
        '
        Me.txtDateVaccinated.BackColor = System.Drawing.SystemColors.Window
        Me.txtDateVaccinated.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateVaccinated.Location = New System.Drawing.Point(166, 230)
        Me.txtDateVaccinated.MaxLength = 50
        Me.txtDateVaccinated.Name = "txtDateVaccinated"
        Me.txtDateVaccinated.Size = New System.Drawing.Size(121, 21)
        Me.txtDateVaccinated.TabIndex = 7
        '
        'lblDateVaccinated
        '
        Me.lblDateVaccinated.BackColor = System.Drawing.Color.Transparent
        Me.lblDateVaccinated.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateVaccinated.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDateVaccinated.Location = New System.Drawing.Point(2, 232)
        Me.lblDateVaccinated.Name = "lblDateVaccinated"
        Me.lblDateVaccinated.Size = New System.Drawing.Size(107, 15)
        Me.lblDateVaccinated.TabIndex = 127
        Me.lblDateVaccinated.Text = "Date Vaccinated #1:"
        Me.lblDateVaccinated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntryType
        '
        Me.lblEntryType.BackColor = System.Drawing.Color.Transparent
        Me.lblEntryType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryType.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblEntryType.Location = New System.Drawing.Point(1, 178)
        Me.lblEntryType.Name = "lblEntryType"
        Me.lblEntryType.Size = New System.Drawing.Size(79, 15)
        Me.lblEntryType.TabIndex = 125
        Me.lblEntryType.Text = "Entry Type:"
        Me.lblEntryType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEntryType
        '
        Me.cboEntryType.DataSource = Me.DdvStuHpvSubjEntryTypeBindingSource
        Me.cboEntryType.DisplayMember = "SubjEntryTypeDesc"
        Me.cboEntryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEntryType.FormattingEnabled = True
        Me.cboEntryType.Location = New System.Drawing.Point(166, 176)
        Me.cboEntryType.Name = "cboEntryType"
        Me.cboEntryType.Size = New System.Drawing.Size(170, 21)
        Me.cboEntryType.TabIndex = 5
        Me.cboEntryType.ValueMember = "SubjEntryTypeCd"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(2, 451)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Notes:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(49, 451)
        Me.txtNotes.MaxLength = 255
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(392, 85)
        Me.txtNotes.TabIndex = 17
        '
        'cboEligible
        '
        Me.cboEligible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEligible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEligible.ItemHeight = 13
        Me.cboEligible.Items.AddRange(New Object() {"Y", "N", "YNT"})
        Me.cboEligible.Location = New System.Drawing.Point(166, 95)
        Me.cboEligible.Name = "cboEligible"
        Me.cboEligible.Size = New System.Drawing.Size(62, 21)
        Me.cboEligible.TabIndex = 2
        '
        'txtSubjectID
        '
        Me.txtSubjectID.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubjectID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectID.Location = New System.Drawing.Point(166, 15)
        Me.txtSubjectID.MaxLength = 5
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.Size = New System.Drawing.Size(99, 21)
        Me.txtSubjectID.TabIndex = 0
        Me.txtSubjectID.Text = "SubjectID"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(2, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Subject ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dts1
        '
        Me.dts1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dts1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dts1.Location = New System.Drawing.Point(166, 122)
        Me.dts1.Name = "dts1"
        Me.dts1.ShowCheckBox = True
        Me.dts1.Size = New System.Drawing.Size(121, 21)
        Me.dts1.TabIndex = 3
        Me.dts1.Tag = "EpisodeDate"
        Me.dts1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label60.Location = New System.Drawing.Point(2, 97)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(72, 15)
        Me.Label60.TabIndex = 121
        Me.Label60.Text = "Eligible"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(2, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Episode  Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DdvResearcherTableAdapter
        '
        Me.DdvResearcherTableAdapter.ClearBeforeFill = True
        '
        'DdvStuHpvEpisodeStatusTableAdapter
        '
        Me.DdvStuHpvEpisodeStatusTableAdapter.ClearBeforeFill = True
        '
        'DdvStuHpvEpisodeTypeTableAdapter
        '
        Me.DdvStuHpvEpisodeTypeTableAdapter.ClearBeforeFill = True
        '
        'frmStuHpvEpiEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(559, 671)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStuHpvEpiEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing HPV Episode"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RiSdataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvStuHpvSubjEntryTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DdvStuHpvEpisodeTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvStuHpvEpisodeStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSResearchers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FormActivated As Boolean = False
    Dim conn As OleDbConnection

    Private Sub frmStuHpvEpiEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvStuHpvEpisodeType' table. You can move, or remove it, as needed.
        Me.DdvStuHpvEpisodeTypeTableAdapter.Connection.ConnectionString = strConn
        Me.DdvStuHpvEpisodeTypeTableAdapter.Fill(Me.RiSdataDataSet1.ddvStuHpvEpisodeType)

        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvStuHpvEpisodeStatus' table. You can move, or remove it, as needed.
        Me.DdvStuHpvEpisodeStatusTableAdapter.Connection.ConnectionString = strConn
        Me.DdvStuHpvEpisodeStatusTableAdapter.Fill(Me.RiSdataDataSet1.ddvStuHpvEpisodeStatus)

        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvResearcher' table. You can move, or remove it, as needed.
        Me.DdvResearcherTableAdapter.Connection.ConnectionString = strConn
        Me.DdvResearcherTableAdapter.Fill(Me.RiSdataDataSet1.ddvResearcher)

        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvStuHpvSubjEntryType' table. You can move, or remove it, as needed.
        Me.DdvStuHpvSubjEntryTypeTableAdapter.Connection.ConnectionString = strConn
        Me.DdvStuHpvSubjEntryTypeTableAdapter.Fill(Me.RiSdataDataSet1.ddvStuHpvSubjEntryType)

        'Need the following to Retrieve Microsoft Access Autonumber Value
        'for: xLvwIdx = Me.txtVisitID.Text on save
        conn = New OleDbConnection
        conn.ConnectionString = strConn
        AddHandler ada1.RowUpdated, AddressOf ada1_OnRowUpdate

        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            FillDateTimeSlickers(Me, Me.DS.tbStuHpvEpisode, "dts", 1, Today)

            '* SET THE CURRENT VALUES HERE.
            Me.txtSubjectID.Text = Me.DS.tbStuHpvEpisode.Item(0).SubjectID
            Me.txtEpisodeID.Text = Me.DS.tbStuHpvEpisode.Item(0).EpisodeID
            Me.txtPatientID.Text = Me.DS.tbStuHpvEpisode.Item(0).PatientID
            Me.txtLastEditDate.Text = Today

            If Me.DS.tbStuHpvEpisode.Item(0).IsEpisodeDateNull Then
                Me.dts1.Checked = False
            Else
                Me.dts1.Checked = True
                Me.dts1.Value = Me.DS.tbStuHpvEpisode.Item(0).EpisodeDate
            End If

            If Me.DS.tbStuHpvEpisode.Item(0).IsTerminationDtNull Then
                Me.DtTerminationDt.Checked = False
            Else
                Me.DtTerminationDt.Checked = True
                Me.DtTerminationDt.Value = Me.DS.tbStuHpvEpisode.Item(0).TerminationDt
            End If

            If Not Me.DS.tbStuHpvEpisode.Item(0).IsNotesNull() Then
                Me.txtNotes.Text = Me.DS.tbStuHpvEpisode.Item(0).Notes
            Else
                Me.txtNotes.Text = ""
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsEligibleNull() Then
                Me.cboEligible.Text = Me.DS.tbStuHpvEpisode.Item(0).Eligible
            Else
                Me.cboEligible.Text = "Y"
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsResearcherCdNull Then
                Me.cboResearcher.SelectedValue = Me.DS.tbStuHpvEpisode.Item(0).ResearcherCd
            Else
                Me.cboResearcher.SelectedIndex = -1
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsReferredByNull() Then
                Me.txtReferredBy.Text = Me.DS.tbStuHpvEpisode.Item(0).ReferredBy
            Else
                Me.txtReferredBy.Text = ""
            End If
            '* Vaccine 1
            If Me.DS.tbStuHpvEpisode.Item(0).IsVaccineDateKnownNull Then
                Me.DTVaccinatedDt.Checked = False
            Else
                Me.DTVaccinatedDt.Checked = True
                Me.DTVaccinatedDt.Value = Me.DS.tbStuHpvEpisode.Item(0).VaccineDateKnown
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsVaccineDateEstNull Then
                Me.txtDateVaccinated.Text = Me.DS.tbStuHpvEpisode.Item(0).VaccineDateEst
            Else
                Me.txtDateVaccinated.Text = ""
            End If

            '* Vaccine 2
            If Me.DS.tbStuHpvEpisode.Item(0).IsVaccine2DateKnownNull Then
                Me.DTVaccinatedDt1.Checked = False
            Else
                Me.DTVaccinatedDt1.Checked = True
                Me.DTVaccinatedDt1.Value = Me.DS.tbStuHpvEpisode.Item(0).Vaccine2DateKnown
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsVaccine2DateEstNull Then
                Me.txtDateVaccinated1.Text = Me.DS.tbStuHpvEpisode.Item(0).Vaccine2DateEst
            Else
                Me.txtDateVaccinated1.Text = ""
            End If

            '* Vaccine 3
            If Me.DS.tbStuHpvEpisode.Item(0).IsVaccine3DateKnownNull Then
                Me.DTVaccinatedDt2.Checked = False
            Else
                Me.DTVaccinatedDt2.Checked = True
                Me.DTVaccinatedDt2.Value = Me.DS.tbStuHpvEpisode.Item(0).Vaccine3DateKnown
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsVaccine3DateEstNull Then
                Me.txtDateVaccinated2.Text = Me.DS.tbStuHpvEpisode.Item(0).Vaccine3DateEst
            Else
                Me.txtDateVaccinated2.Text = ""
            End If

            If Not Me.DS.tbStuHpvEpisode.Item(0).IsEpisodeStatusNull Then
                Me.cboEpisodeStatus.SelectedValue = Me.DS.tbStuHpvEpisode.Item(0).EpisodeStatus
            Else
                Me.cboEpisodeStatus.SelectedIndex = 0
            End If

            If Not Me.DS.tbStuHpvEpisode.Item(0).IsSubjEntryTypeCdNull Then
                Me.cboEntryType.SelectedValue = Me.DS.tbStuHpvEpisode.Item(0).SubjEntryTypeCd
            Else
                Me.cboEntryType.SelectedIndex = -1
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsConsentStoreSerumNull Then
                Me.cboConsent.SelectedIndex = IIf(Me.DS.tbStuHpvEpisode.Item(0).ConsentStoreSerum = "N", 1, 0)
            Else
                Me.cboConsent.SelectedIndex = -1
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsConsentContactNull Then
                Me.cboConsentContact.SelectedIndex = IIf(Me.DS.tbStuHpvEpisode.Item(0).ConsentContact = "N", 1, 0)
            Else
                Me.cboConsentContact.SelectedIndex = -1
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsConsentDirectNull Then
                Me.cboConsentDirect.SelectedIndex = IIf(Me.DS.tbStuHpvEpisode.Item(0).ConsentDirect = "N", 1, 0)
            Else
                Me.cboConsentDirect.SelectedIndex = -1
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsConsentOtherResearchNull Then
                Me.cboConsentOtherResearch.SelectedIndex = IIf(Me.DS.tbStuHpvEpisode.Item(0).ConsentOtherResearch = "N", 1, 0)
            Else
                Me.cboConsentOtherResearch.SelectedIndex = -1
            End If
            If Not Me.DS.tbStuHpvEpisode.Item(0).IsSelfSamplingNull Then
                Me.chkSelfSampling.Checked = Me.DS.tbStuHpvEpisode.Item(0).SelfSampling
            Else
                Me.chkSelfSampling.Checked = False
            End If

            If Not Me.DS.tbStuHpvEpisode.Item(0).IsEpisodeTypeNull Then
                Me.cboEpisodeType.SelectedValue = Me.DS.tbStuHpvEpisode.Item(0).EpisodeType
                If Me.DS.tbStuHpvEpisode.Item(0).EpisodeType = 2 Then
                    DisplayExtensionStudyFields(False)
                Else
                    DisplayExtensionStudyFields(True)
                End If
            Else
                Me.cboEpisodeType.SelectedIndex = 0
                DisplayExtensionStudyFields(True)
            End If

            DisplayTerminationDt()
        Else
            Me.BindingContext(Me.DS, "tbStuHpvEpisode").AddNew()
            'Need this after AddNew
            Me.BindingContext(Me.DS, "tbStuHpvEpisode").Position = 0

            With vfrmPatient
                If Not vfrmPatientEdit Is Nothing Then
                    Me.DS.tbStuHpvEpisode.Item(0).PatientID = vfrmPatientEdit.txtPatientID.Text
                Else
                    Me.DS.tbStuHpvEpisode.Item(0).PatientID = .lvw0.SelectedItems(0).SubItems(.lvw0.Columns.Count - 1).Text
                    If .lvwHpvEpi.Items.Count > 0 Then
                        Me.txtSubjectID.Text = .lvwHpvEpi.Items(0).SubItems(1).Text
                        Me.DS.tbStuHpvEpisode.Item(0).SubjectID = Me.txtSubjectID.Text
                    End If
                End If

                '* DEFAULT VALUES
                Me.DS.tbStuHpvEpisode.Item(0).EpisodeDate = Today
                Me.DS.tbStuHpvEpisode.Item(0).Eligible = "Y"
            End With

            If Me.Tag <> 0 Then
                If Me.Tag = 1 Then

                    Me.cboEpisodeType.SelectedIndex = 0
                    Me.DS.tbStuHpvEpisode.Item(0).EpisodeType = 1

                    Me.cboEntryType.SelectedIndex = -1
                    Me.txtReferredBy.Text = ""
                    Me.DTVaccinatedDt.Value = CDate(FormatDateTime(Now, DateFormat.ShortDate))
                    Me.DTVaccinatedDt.Checked = False
                    Me.txtDateVaccinated.Text = ""
                    Me.DTVaccinatedDt1.Value = CDate(FormatDateTime(Now, DateFormat.ShortDate))
                    Me.DTVaccinatedDt1.Checked = False
                    Me.txtDateVaccinated1.Text = ""
                    Me.DTVaccinatedDt2.Value = CDate(FormatDateTime(Now, DateFormat.ShortDate))
                    Me.DTVaccinatedDt2.Checked = False
                    Me.txtDateVaccinated2.Text = ""
                    DisplayExtensionStudyFields(True)
                ElseIf Me.Tag = 2 Then
                    Me.cboEpisodeType.SelectedIndex = 1
                    Me.DS.tbStuHpvEpisode.Item(0).EpisodeType = 2

                    '* GET PREVIOUS EPISODE INFO FOR VACCINATION                    
                    DisplayExtensionStudyFields(False)
                    LoadPreviousStudyInfoVaccination()

                Else
                    Me.cboEpisodeType.SelectedIndex = 2
                    Me.DS.tbStuHpvEpisode.Item(0).EpisodeType = 3

                    '* GET PREVIOUS EPISODE INFO FOR VACCINATION                    
                    DisplayExtensionStudyFields(False)
                    LoadPreviousStudyInfoVaccination()
                End If
            Else
                Me.cboEpisodeType.SelectedIndex = 0
                Me.DS.tbStuHpvEpisode.Item(0).EpisodeType = 1

                Me.cboEntryType.SelectedIndex = -1
                Me.txtReferredBy.Text = ""
                Me.DTVaccinatedDt.Value = CDate(FormatDateTime(Now, DateFormat.ShortDate))
                Me.DTVaccinatedDt.Checked = False
                Me.txtDateVaccinated.Text = ""
                Me.DTVaccinatedDt1.Value = CDate(FormatDateTime(Now, DateFormat.ShortDate))
                Me.DTVaccinatedDt1.Checked = False
                Me.txtDateVaccinated1.Text = ""
                Me.DTVaccinatedDt2.Value = CDate(FormatDateTime(Now, DateFormat.ShortDate))
                Me.DTVaccinatedDt2.Checked = False
                Me.txtDateVaccinated2.Text = ""
                DisplayExtensionStudyFields(True)
            End If

            Me.cboEpisodeStatus.SelectedIndex = 0
            Me.DS.tbStuHpvEpisode.Item(0).EpisodeStatus = 1
            DisplayTerminationDt()

            Me.cboEligible.Text = "Y"
            Me.dts1.Text = Today
            Me.DtTerminationDt.Checked = False
            Me.dts1.Checked = True
            Me.txtNotes.Text = ""
            Me.cboConsent.SelectedIndex = -1
            Me.cboConsentContact.SelectedIndex = -1
            Me.cboConsentDirect.SelectedIndex = -1
            Me.cboConsentOtherResearch.SelectedIndex = -1
            Me.cboResearcher.SelectedIndex = -1

        End If

    End Sub
    Sub LoadPreviousStudyInfoVaccination()
        Try
            Dim PatID As String = vfrmPatient.lvw0.SelectedItems(0).SubItems(vfrmPatient.lvw0.Columns.Count - 1).Text
            Dim MyDA As tbStuHpvEpisodeTableAdapter = New tbStuHpvEpisodeTableAdapter
            MyDA.Connection.ConnectionString = strConn

            Dim MyDR As DataRow() = Nothing
            Dim MyDataRow As tbStuHpvEpisodeRow = Nothing
            Dim Mydt As RIS.DataSet1.tbStuHpvEpisodeDataTable = New RIS.DataSet1.tbStuHpvEpisodeDataTable
            MyDA.FillByPatient(Mydt, PatID)
            If Not Mydt Is Nothing Then
                If Mydt.Rows.Count > 0 Then
                    '* Check if eligible hpv study exists
                    MyDR = Mydt.Select("EpisodeType=1 AND Eligible='Y'")
                    If MyDR.Length > 0 Then
                        MyDataRow = CType(MyDR(0), tbStuHpvEpisodeRow)
                        If Not MyDataRow.IsSubjEntryTypeCdNull Then
                            Me.cboEntryType.SelectedValue = MyDataRow.SubjEntryTypeCd
                            Me.DS.tbStuHpvEpisode.Item(0).SubjEntryTypeCd = MyDataRow.SubjEntryTypeCd
                        Else
                            Me.cboEntryType.SelectedIndex = -1
                        End If

                        If Not MyDataRow.IsReferredByNull() Then
                            Me.txtReferredBy.Text = MyDataRow.ReferredBy
                            Me.DS.tbStuHpvEpisode.Item(0).ReferredBy = MyDataRow.ReferredBy
                        Else
                            Me.txtReferredBy.Text = ""
                        End If

                        '* Vaccine 1
                        If MyDataRow.IsVaccineDateKnownNull Then
                            Me.DTVaccinatedDt.Checked = False
                        Else
                            Me.DTVaccinatedDt.Checked = True
                            Me.DTVaccinatedDt.Value = MyDataRow.VaccineDateKnown
                            Me.DS.tbStuHpvEpisode.Item(0).VaccineDateKnown = MyDataRow.VaccineDateKnown
                        End If
                        If Not MyDataRow.IsVaccineDateEstNull Then
                            Me.txtDateVaccinated.Text = MyDataRow.VaccineDateEst
                            Me.DS.tbStuHpvEpisode.Item(0).VaccineDateEst = MyDataRow.VaccineDateEst
                        Else
                            Me.txtDateVaccinated.Text = ""
                        End If

                        '* Vaccine 2
                        If MyDataRow.IsVaccine2DateKnownNull Then
                            Me.DTVaccinatedDt1.Checked = False
                        Else
                            Me.DTVaccinatedDt1.Checked = True
                            Me.DTVaccinatedDt1.Value = MyDataRow.Vaccine2DateKnown
                            Me.DS.tbStuHpvEpisode.Item(0).Vaccine2DateKnown = MyDataRow.Vaccine2DateKnown
                        End If
                        If Not MyDataRow.IsVaccine2DateEstNull Then
                            Me.txtDateVaccinated1.Text = MyDataRow.Vaccine2DateEst
                            Me.DS.tbStuHpvEpisode.Item(0).Vaccine2DateEst = MyDataRow.Vaccine2DateEst
                        Else
                            Me.txtDateVaccinated1.Text = ""
                        End If

                        '* Vaccine 3
                        If MyDataRow.IsVaccine3DateKnownNull Then
                            Me.DTVaccinatedDt2.Checked = False
                        Else
                            Me.DTVaccinatedDt2.Checked = True
                            Me.DTVaccinatedDt2.Value = MyDataRow.Vaccine3DateKnown
                            Me.DS.tbStuHpvEpisode.Item(0).Vaccine3DateKnown = MyDataRow.Vaccine3DateKnown
                        End If
                        If Not MyDataRow.IsVaccine3DateEstNull Then
                            Me.txtDateVaccinated2.Text = MyDataRow.Vaccine3DateEst
                            Me.DS.tbStuHpvEpisode.Item(0).Vaccine3DateEst = MyDataRow.Vaccine3DateEst
                        Else
                            Me.txtDateVaccinated2.Text = ""
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub frmStuHpvEpiEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub

    Private Sub frmStuHpvEpiEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmStuHpvEpiEdit = Nothing
    End Sub

    Private Sub ada1_OnRowUpdate(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)

        'If vb.Left(Me.Text.ToString, 6) = "Adding" Then
        If e.StatementType = StatementType.Insert Then
            Dim oCmd As New OleDbCommand("SELECT @@IDENTITY")
            oCmd.Connection = conn
            e.Row("EpisodeID") = oCmd.ExecuteScalar()
            e.Row.AcceptChanges()
            'MsgBox(e.Row("EpisodeID"))
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Try
            Dim resp As MsgBoxResult
            If vb.Left(Me.Text.ToString, 6) = "Adding" Then
                resp = MsgBox("Do you want to add this new HPV episode?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then

                    If ValidationPassed() Then
                        'MsgBox(System.DateTime.Now.ToString)
                        txtLastEditDate.Text = System.DateTime.Now
                        Me.BindingContext(Me.DS, "tbStuHpvEpisode").EndCurrentEdit()

                        UpdateDataSourceAddNew(Me.DS, "tbStuHpvEpisode", conn, Me.ada1)
                        CloseAndUpdate()

                    End If

                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If

            Else

                Dim objDataSetChanges As DataSet1 = New DataSet1
                Me.BindingContext(Me.DS, "tbStuHpvEpisode").EndCurrentEdit()
                objDataSetChanges = CType(Me.DS.GetChanges, DataSet1)
                If Not (objDataSetChanges) Is Nothing Then
                    resp = MsgBox("Do you want to save your changes?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                    If resp = MsgBoxResult.Yes Then

                        If ValidationPassed() Then
                            'Must cancel edit first
                            Me.BindingContext(Me.DS, "tbStuHpvEpisode").CancelCurrentEdit()
                            txtLastEditDate.Text = System.DateTime.Now
                            Me.BindingContext(Me.DS, "tbStuHpvEpisode").EndCurrentEdit()
                            objDataSetChanges = CType(Me.DS.GetChanges, DataSet1)

                            UpdateDataSource(objDataSetChanges, conn, Me.ada1)

                            CloseAndUpdate()

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
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function ValidationPassed() As Boolean

        ValidationPassed = True

        If Me.txtSubjectID.Text.Trim.Length = 0 Or Me.txtSubjectID.Text = "SubjectID" Then
            MsgBox("'Subject ID' is required.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information)
            txtSubjectID.Focus()
            Return False
            Exit Function
        End If

        '* CHECK FEMALE PATIENTS SUBJECT ID STARTS WITH A
        '* CHECK FEMALE PATIENTS SUBJECT ID STARTS WITH B
        If Me.txtSubjectID.Text.Trim.Length > 0 And Me.txtSubjectID.Text <> "SubjectID" Then
            If Me.txtSubjectID.Text.Trim.Substring(0, 1).ToUpper <> "A" And Me.txtSubjectID.Text.Trim.Substring(0, 1).ToUpper <> "B" Then
                MsgBox("'Subject ID' must start with an 'A' for Female and 'B' for Male.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information)
                txtSubjectID.Focus()
                Return False
                Exit Function
            End If

            If Me.txtSubjectID.Text.Trim.Substring(0, 1).ToUpper = "A" Then
                Dim strDataExistsGender1 As String = "WHERE Gender='F' " & _
                                           " AND PatientID=" & Me.DS.tbStuHpvEpisode.Item(0).PatientID                
                If Not DataExists("tbPatient", strDataExistsGender1) Then
                    MsgBox("Subject ID '" & Me.txtSubjectID.Text.Trim & "' must be assigned to a Female Patient.", vbOKOnly + vbInformation)
                    Me.txtSubjectID.Focus()
                    Return False
                    Exit Function
                End If
            ElseIf Me.txtSubjectID.Text.Trim.Substring(0, 1).ToUpper = "B" Then
                Dim strDataExistsGender1 As String = "WHERE Gender='M' " & _
                                           " AND PatientID=" & Me.DS.tbStuHpvEpisode.Item(0).PatientID                
                If Not DataExists("tbPatient", strDataExistsGender1) Then
                    MsgBox("Subject ID '" & Me.txtSubjectID.Text.Trim & "' must be assigned to a Male Patient.", vbOKOnly + vbInformation)
                    Me.txtSubjectID.Focus()
                    Return False
                    Exit Function
                End If
            End If
        End If

        Dim strDataExists As String = "WHERE TRIM(SubjectID)='" & Me.txtSubjectID.Text.Trim & "' " & _
                                           " AND PatientID<>" & Me.DS.tbStuHpvEpisode.Item(0).PatientID        
        If DataExists("tbStuHpvEpisode", strDataExists) Then
            MsgBox("Subject ID '" & Me.txtSubjectID.Text.Trim & "' has been assigned to a different patient.", vbOKOnly + vbInformation)
            Me.txtSubjectID.Focus()
            Return False
            Exit Function
        End If

        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            If Me.cboEligible.Text = "Y" Or Me.cboEligible.Text = "YNT" Then
                With vfrmPatient.lvwHpvEpi
                    If .Items.Count > 0 Then
                        For i As Short = 0 To .Items.Count - 1
                            If .Items(i).SubItems(.Columns.Count - 1).Text <> Me.txtEpisodeID.Text Then
                                'If UCase(.Items(i).SubItems(2).Text) = "Y" Then 'Check the Eligible column
                                '    MsgBox("There is already an eligible HPV episode for the selected patient.", vbOKOnly + vbInformation)
                                '    Me.cboEligible.Focus()
                                '    Return False
                                '    Exit Function
                                'End If
                            End If
                        Next
                    End If
                End With
            End If
        End If

    End Function

    Private Sub CloseAndUpdate()

        With vfrmPatient
            If Not vfrmPatientEdit Is Nothing Then
                xLvwIdx = Me.txtPatientID.Text
                Me.Close()
                vfrmPatientEdit.Close()
                .Fill_lvw0()
                SelectLvwItem(.lvw0, xLvwIdx, .lvw0.Columns.Count - 1)
                .Update_Tab1()
                .lvw0.Focus()
            Else
                xLvwIdx = Me.txtEpisodeID.Text
                Me.Close()
                .Update_Tab1(False)
                SelectLvwItem(.lvwHpvEpi, xLvwIdx, .lvwHpvEpi.Columns.Count - 1)
                .Update_tabHpv()
            End If
        End With

    End Sub
    Private Sub dts1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.ValueChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).EpisodeDate = dts1.Value
        End If
    End Sub
    Private Sub DtTerminationDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtTerminationDt.ValueChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).TerminationDt = FormatDateTime(DtTerminationDt.Value, DateFormat.ShortDate)
        End If
    End Sub
    Private Sub dts1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.CheckedChanged
        If FormActivated Then
            Select Case dts1.Checked
                Case True
                    Me.DS.tbStuHpvEpisode.Item(0).EpisodeDate = FormatDateTime(dts1.Value, DateFormat.ShortDate)
                Case False
                    Me.DS.tbStuHpvEpisode.Item(0).SetEpisodeDateNull()
            End Select
        End If
    End Sub
    Private Sub DtTerminationDt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtTerminationDt.CheckedChanged
        If FormActivated Then
            Select Case DtTerminationDt.Checked
                Case True
                    Me.DS.tbStuHpvEpisode.Item(0).TerminationDt = FormatDateTime(DtTerminationDt.Value, DateFormat.ShortDate)
                Case False
                    Me.DS.tbStuHpvEpisode.Item(0).SetTerminationDtNull()
            End Select
        End If
    End Sub

    Private Sub txtNotes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotes.TextChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).Notes = Me.txtNotes.Text
        End If
    End Sub

    Private Sub txtDateVaccinated_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateVaccinated.TextChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).VaccineDateEst = Me.txtDateVaccinated.Text
        End If
    End Sub

    Private Sub DTVaccinatedDt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTVaccinatedDt.CheckedChanged
        Try
            If FormActivated Then
                If Not IsDBNull(DTVaccinatedDt.Value) Then
                    Me.DS.tbStuHpvEpisode.Item(0).VaccineDateKnown = CDate(FormatDateTime(DTVaccinatedDt.Value, DateFormat.ShortDate))
                Else
                    Me.DS.tbStuHpvEpisode.Item(0).SetVaccineDateKnownNull()
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub DTVaccinatedDt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTVaccinatedDt.ValueChanged
        Try
            If FormActivated Then
                If Not IsDBNull(DTVaccinatedDt.Value) Then
                    Me.DS.tbStuHpvEpisode.Item(0).VaccineDateKnown = CDate(FormatDateTime(DTVaccinatedDt.Value, DateFormat.ShortDate))
                Else
                    Me.DS.tbStuHpvEpisode.Item(0).SetVaccineDateKnownNull()
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cboEntryType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEntryType.SelectedIndexChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).SubjEntryTypeCd = cboEntryType.SelectedValue
        End If
    End Sub

    Private Sub cboEligible_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEligible.SelectedIndexChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).Eligible = cboEligible.Text
        End If
    End Sub

    Private Sub txtSubjectID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubjectID.TextChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).SubjectID = txtSubjectID.Text
        End If
    End Sub

    Private Sub cboConsent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConsent.SelectedIndexChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).ConsentStoreSerum = cboConsent.Text
        End If
    End Sub

    Private Sub cboConsentContact_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConsentContact.SelectedIndexChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).ConsentContact = cboConsentContact.Text
        End If
    End Sub

    Private Sub cboConsentDirect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConsentDirect.SelectedIndexChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).ConsentDirect = cboConsentDirect.Text
        End If
    End Sub

    Private Sub cboConsentOtherResearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConsentOtherResearch.SelectedIndexChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).ConsentOtherResearch = cboConsentOtherResearch.Text
        End If
    End Sub

    Private Sub txtDateVaccinated1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateVaccinated1.TextChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).Vaccine2DateEst = Me.txtDateVaccinated1.Text
        End If
    End Sub

    Private Sub txtDateVaccinated2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateVaccinated2.TextChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).Vaccine3DateEst = Me.txtDateVaccinated2.Text
        End If
    End Sub

    Private Sub DTVaccinatedDt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTVaccinatedDt1.CheckedChanged
        Try
            If FormActivated Then
                If Not IsDBNull(DTVaccinatedDt1.Value) Then
                    Me.DS.tbStuHpvEpisode.Item(0).Vaccine2DateKnown = CDate(FormatDateTime(DTVaccinatedDt1.Value, DateFormat.ShortDate))
                Else
                    Me.DS.tbStuHpvEpisode.Item(0).SetVaccine2DateKnownNull()
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub DTVaccinatedDt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTVaccinatedDt2.CheckedChanged
        Try
            If FormActivated Then
                If Not IsDBNull(DTVaccinatedDt2.Value) Then
                    Me.DS.tbStuHpvEpisode.Item(0).Vaccine3DateKnown = CDate(FormatDateTime(DTVaccinatedDt2.Value, DateFormat.ShortDate))
                Else
                    Me.DS.tbStuHpvEpisode.Item(0).SetVaccine3DateKnownNull()
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub DTVaccinatedDt1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTVaccinatedDt1.ValueChanged
        Try
            If FormActivated Then
                If Not IsDBNull(DTVaccinatedDt1.Value) Then
                    Me.DS.tbStuHpvEpisode.Item(0).Vaccine2DateKnown = CDate(FormatDateTime(DTVaccinatedDt1.Value, DateFormat.ShortDate))
                Else
                    Me.DS.tbStuHpvEpisode.Item(0).SetVaccine3DateKnownNull()
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub DTVaccinatedDt2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTVaccinatedDt2.ValueChanged
        Try
            If FormActivated Then
                If Not IsDBNull(DTVaccinatedDt2.Value) Then
                    Me.DS.tbStuHpvEpisode.Item(0).Vaccine3DateKnown = CDate(FormatDateTime(DTVaccinatedDt2.Value, DateFormat.ShortDate))
                Else
                    Me.DS.tbStuHpvEpisode.Item(0).SetVaccine3DateKnownNull()
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cboResearcher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboResearcher.SelectedIndexChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).ResearcherCd = Me.cboResearcher.SelectedValue
        End If
    End Sub

    Private Sub txtReferredBy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReferredBy.TextChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).ReferredBy = Me.txtReferredBy.Text
        End If
    End Sub

    Private Sub cboEpisodeStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEpisodeStatus.SelectedIndexChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).EpisodeStatus = Me.cboEpisodeStatus.SelectedValue
        End If

        DisplayTerminationDt()

    End Sub

    Private Sub cboEpisodeType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEpisodeType.SelectedIndexChanged
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).EpisodeType = Me.cboEpisodeType.SelectedValue

            If Me.cboEpisodeType.SelectedValue = 3 Then
                DisplayExtensionStudyFields(False)
            ElseIf Me.cboEpisodeType.SelectedValue = 2 Then
                DisplayExtensionStudyFields(False)
            Else
                DisplayExtensionStudyFields(True)
            End If

        End If
    End Sub
    Sub DisplayTerminationDt()
        If Me.cboEpisodeStatus.SelectedIndex = 1 Or Me.cboEpisodeStatus.SelectedIndex = 2 Then
            Me.DtTerminationDt.Enabled = True
            Me.DtTerminationDt.Checked = True
        Else
            Me.DtTerminationDt.Enabled = False
            Me.DtTerminationDt.Checked = False
        End If
    End Sub
    Sub DisplayExtensionStudyFields(ByVal Show As Boolean)
        If Not Show Then
            Me.cboEntryType.Enabled = False
            Me.txtReferredBy.Text = ""
            Me.txtReferredBy.Enabled = False
            Me.txtDateVaccinated.Text = ""
            Me.txtDateVaccinated.Enabled = False
            Me.txtDateVaccinated1.Text = ""
            Me.txtDateVaccinated1.Enabled = False
            Me.txtDateVaccinated2.Text = ""
            Me.txtDateVaccinated2.Enabled = False
            Me.DTVaccinatedDt.Enabled = False
            Me.DTVaccinatedDt1.Enabled = False
            Me.DTVaccinatedDt2.Enabled = False
            Me.DTVaccinatedDt.Checked = False
            Me.DTVaccinatedDt1.Checked = False
            Me.DTVaccinatedDt2.Checked = False
            Me.lblEntryType.Enabled = False
            Me.lblReferredBy.Enabled = False
            Me.lblDateVaccinated.Enabled = False
            Me.lblDateVaccinated1.Enabled = False
            Me.lblDateVaccinated2.Enabled = False
            Me.lblDateVaccinatedOr.Enabled = False
            Me.lblDateVaccinatedOr1.Enabled = False
            Me.lblDateVaccinatedOr2.Enabled = False
            Me.chkSelfSampling.Enabled = True
            Me.lblSelfSampling.Enabled = True
        Else
            Me.cboEntryType.Enabled = True
            Me.txtReferredBy.Enabled = True
            Me.txtDateVaccinated.Enabled = True
            Me.txtDateVaccinated1.Enabled = True
            Me.txtDateVaccinated2.Enabled = True
            Me.DTVaccinatedDt.Enabled = True
            Me.DTVaccinatedDt1.Enabled = True
            Me.DTVaccinatedDt2.Enabled = True
            Me.lblEntryType.Enabled = True
            Me.lblReferredBy.Enabled = True
            Me.lblDateVaccinated.Enabled = True
            Me.lblDateVaccinated1.Enabled = True
            Me.lblDateVaccinated2.Enabled = True
            Me.lblDateVaccinatedOr.Enabled = True
            Me.lblDateVaccinatedOr1.Enabled = True
            Me.lblDateVaccinatedOr2.Enabled = True
            Me.chkSelfSampling.Enabled = False
            Me.lblSelfSampling.Enabled = False
        End If
    End Sub

    Private Sub chkSelfSampling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelfSampling.Click
        If FormActivated Then
            Me.DS.tbStuHpvEpisode.Item(0).SelfSampling = Me.chkSelfSampling.Checked
        End If
    End Sub
End Class


