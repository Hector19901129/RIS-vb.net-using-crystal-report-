Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb

Public Class frmPatientEdit
    Inherits System.Windows.Forms.Form
    Private Editors() As Control

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
    Friend WithEvents ds As RIS.DataSet1
    Friend WithEvents ada1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtMRN As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dts1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents ada1SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkRace6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRace1 As System.Windows.Forms.CheckBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents rbEthnicity3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbEthnicity2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbEthnicity1 As System.Windows.Forms.RadioButton
    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lvwxStudy As ListViewEx.ListViewEx
    Friend WithEvents lvwxStudyC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwxStudyC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwxStudyC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwxStudyC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboEligible As System.Windows.Forms.ComboBox
    Friend WithEvents txtStudy As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLastEditDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientEdit))
        Me.btnExit = New System.Windows.Forms.Button
        Me.ada1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.ada1SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.rbEthnicity3 = New System.Windows.Forms.RadioButton
        Me.rbEthnicity2 = New System.Windows.Forms.RadioButton
        Me.rbEthnicity1 = New System.Windows.Forms.RadioButton
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.txtMRN = New System.Windows.Forms.TextBox
        Me.ds = New RIS.DataSet1
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkRace6 = New System.Windows.Forms.CheckBox
        Me.chkRace5 = New System.Windows.Forms.CheckBox
        Me.chkRace4 = New System.Windows.Forms.CheckBox
        Me.chkRace3 = New System.Windows.Forms.CheckBox
        Me.chkRace2 = New System.Windows.Forms.CheckBox
        Me.chkRace1 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dts1 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboGender = New System.Windows.Forms.ComboBox
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lvwxStudy = New ListViewEx.ListViewEx
        Me.lvwxStudyC1 = New System.Windows.Forms.ColumnHeader
        Me.lvwxStudyC2 = New System.Windows.Forms.ColumnHeader
        Me.lvwxStudyC3 = New System.Windows.Forms.ColumnHeader
        Me.lvwxStudyC4 = New System.Windows.Forms.ColumnHeader
        Me.cboEligible = New System.Windows.Forms.ComboBox
        Me.txtStudy = New System.Windows.Forms.TextBox
        Me.txtSubjectID = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLastEditDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPatientID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox14.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 1
        Me.btnExit.Location = New System.Drawing.Point(511, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 20)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ada1
        '
        Me.ada1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.ada1.InsertCommand = Me.OleDbInsertCommand1
        Me.ada1.SelectCommand = Me.ada1SelectComm
        Me.ada1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbPatient", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DateOfBirth", "DateOfBirth"), New System.Data.Common.DataColumnMapping("Ethnicity", "Ethnicity"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Gender", "Gender"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("MRN", "MRN"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("Race", "Race")})})
        Me.ada1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateOfBirth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfBirth", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateOfBirth1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfBirth", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ethnicity", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ethnicity", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ethnicity1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ethnicity", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Gender", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gender", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Gender1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gender", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MRN", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Race", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Race", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Race1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Race", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO tbPatient(DateOfBirth, Ethnicity, FirstName, Gender, LastEditDate, La" & _
            "stEditLoginID, LastName, MRN, Notes, Race) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" & _
            ""
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("DateOfBirth", System.Data.OleDb.OleDbType.DBDate, 0, "DateOfBirth"), New System.Data.OleDb.OleDbParameter("Ethnicity", System.Data.OleDb.OleDbType.VarWChar, 1, "Ethnicity"), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 30, "FirstName"), New System.Data.OleDb.OleDbParameter("Gender", System.Data.OleDb.OleDbType.VarWChar, 1, "Gender"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 30, "LastName"), New System.Data.OleDb.OleDbParameter("MRN", System.Data.OleDb.OleDbType.VarWChar, 30, "MRN"), New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes"), New System.Data.OleDb.OleDbParameter("Race", System.Data.OleDb.OleDbType.VarWChar, 6, "Race")})
        '
        'ada1SelectComm
        '
        Me.ada1SelectComm.CommandText = "SELECT DateOfBirth, Ethnicity, FirstName, Gender, LastEditDate, LastEditLoginID, " & _
            "LastName, MRN, Notes, PatientID, Race FROM tbPatient"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("DateOfBirth", System.Data.OleDb.OleDbType.DBDate, 0, "DateOfBirth"), New System.Data.OleDb.OleDbParameter("Ethnicity", System.Data.OleDb.OleDbType.VarWChar, 1, "Ethnicity"), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 30, "FirstName"), New System.Data.OleDb.OleDbParameter("Gender", System.Data.OleDb.OleDbType.VarWChar, 1, "Gender"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 30, "LastName"), New System.Data.OleDb.OleDbParameter("MRN", System.Data.OleDb.OleDbType.VarWChar, 30, "MRN"), New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes"), New System.Data.OleDb.OleDbParameter("Race", System.Data.OleDb.OleDbType.VarWChar, 6, "Race"), New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateOfBirth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfBirth", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateOfBirth1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateOfBirth", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ethnicity", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ethnicity", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ethnicity1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ethnicity", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Gender", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gender", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Gender1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gender", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MRN", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MRN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Race", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Race", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Race1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Race", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString")
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.rbEthnicity3)
        Me.GroupBox14.Controls.Add(Me.rbEthnicity2)
        Me.GroupBox14.Controls.Add(Me.rbEthnicity1)
        Me.GroupBox14.Controls.Add(Me.Label61)
        Me.GroupBox14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.Location = New System.Drawing.Point(9, 139)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(243, 84)
        Me.GroupBox14.TabIndex = 6
        Me.GroupBox14.TabStop = False
        '
        'rbEthnicity3
        '
        Me.rbEthnicity3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbEthnicity3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEthnicity3.Location = New System.Drawing.Point(11, 57)
        Me.rbEthnicity3.Name = "rbEthnicity3"
        Me.rbEthnicity3.Size = New System.Drawing.Size(219, 21)
        Me.rbEthnicity3.TabIndex = 2
        Me.rbEthnicity3.Tag = "3"
        Me.rbEthnicity3.Text = "Caribbean or West Indian (Non Hispanic)"
        '
        'rbEthnicity2
        '
        Me.rbEthnicity2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbEthnicity2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEthnicity2.Location = New System.Drawing.Point(11, 36)
        Me.rbEthnicity2.Name = "rbEthnicity2"
        Me.rbEthnicity2.Size = New System.Drawing.Size(169, 21)
        Me.rbEthnicity2.TabIndex = 1
        Me.rbEthnicity2.Tag = "2"
        Me.rbEthnicity2.Text = "Other (Non Hispanic or Latino)"
        '
        'rbEthnicity1
        '
        Me.rbEthnicity1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbEthnicity1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEthnicity1.Location = New System.Drawing.Point(11, 15)
        Me.rbEthnicity1.Name = "rbEthnicity1"
        Me.rbEthnicity1.Size = New System.Drawing.Size(107, 21)
        Me.rbEthnicity1.TabIndex = 0
        Me.rbEthnicity1.Tag = "1"
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
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label60.Location = New System.Drawing.Point(32, 40)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(28, 15)
        Me.Label60.TabIndex = 77
        Me.Label60.Text = "MRN"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.SystemColors.Info
        Me.txtMRN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatient.MRN", True))
        Me.txtMRN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRN.Location = New System.Drawing.Point(62, 36)
        Me.txtMRN.MaxLength = 30
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.Size = New System.Drawing.Size(165, 21)
        Me.txtMRN.TabIndex = 2
        Me.txtMRN.Text = "MRN"
        '
        'ds
        '
        Me.ds.DataSetName = "DataSet1"
        Me.ds.Locale = New System.Globalization.CultureInfo("en-US")
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkRace6)
        Me.GroupBox1.Controls.Add(Me.chkRace5)
        Me.GroupBox1.Controls.Add(Me.chkRace4)
        Me.GroupBox1.Controls.Add(Me.chkRace3)
        Me.GroupBox1.Controls.Add(Me.chkRace2)
        Me.GroupBox1.Controls.Add(Me.chkRace1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 66)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
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
        Me.chkRace6.TabIndex = 5
        Me.chkRace6.Text = "Don't Know"
        '
        'chkRace5
        '
        Me.chkRace5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace5.Location = New System.Drawing.Point(129, 41)
        Me.chkRace5.Name = "chkRace5"
        Me.chkRace5.Size = New System.Drawing.Size(85, 19)
        Me.chkRace5.TabIndex = 4
        Me.chkRace5.Text = "Other"
        '
        'chkRace4
        '
        Me.chkRace4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace4.Location = New System.Drawing.Point(8, 41)
        Me.chkRace4.Name = "chkRace4"
        Me.chkRace4.Size = New System.Drawing.Size(107, 19)
        Me.chkRace4.TabIndex = 3
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
        Me.chkRace3.TabIndex = 2
        Me.chkRace3.Text = "Asian or Pacific Islander"
        '
        'chkRace2
        '
        Me.chkRace2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace2.Location = New System.Drawing.Point(129, 16)
        Me.chkRace2.Name = "chkRace2"
        Me.chkRace2.Size = New System.Drawing.Size(141, 19)
        Me.chkRace2.TabIndex = 1
        Me.chkRace2.Text = "Black or African American"
        '
        'chkRace1
        '
        Me.chkRace1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkRace1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkRace1.Location = New System.Drawing.Point(8, 16)
        Me.chkRace1.Name = "chkRace1"
        Me.chkRace1.Size = New System.Drawing.Size(114, 19)
        Me.chkRace1.TabIndex = 0
        Me.chkRace1.Text = "White or Caucasian"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(5, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 15)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Race (Check all that apply)"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(352, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "DOB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(236, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Gender"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dts1
        '
        Me.dts1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dts1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dts1.Location = New System.Drawing.Point(385, 36)
        Me.dts1.Name = "dts1"
        Me.dts1.ShowCheckBox = True
        Me.dts1.Size = New System.Drawing.Size(99, 21)
        Me.dts1.TabIndex = 4
        Me.dts1.Tag = "DateOfBirth"
        Me.dts1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Last name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Info
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatient.LastName", True))
        Me.txtLastName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(62, 8)
        Me.txtLastName.MaxLength = 30
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(165, 21)
        Me.txtLastName.TabIndex = 0
        Me.txtLastName.Text = "LastName"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(259, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "First name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Info
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatient.FirstName", True))
        Me.txtFirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(319, 10)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(165, 21)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = "FirstName"
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatient.Notes", True))
        Me.txtNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(9, 242)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(541, 183)
        Me.txtNotes.TabIndex = 8
        Me.txtNotes.Text = "Notes"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(9, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Notes"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboGender
        '
        Me.cboGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatient.Gender", True))
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.ItemHeight = 13
        Me.cboGender.Items.AddRange(New Object() {"M", "F", "T", " "})
        Me.cboGender.Location = New System.Drawing.Point(280, 36)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(41, 21)
        Me.cboGender.TabIndex = 3
        '
        'lvwxStudy
        '
        Me.lvwxStudy.AllowColumnReorder = True
        Me.lvwxStudy.CheckBoxes = True
        Me.lvwxStudy.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwxStudyC1, Me.lvwxStudyC2, Me.lvwxStudyC3, Me.lvwxStudyC4})
        Me.lvwxStudy.DoubleClickActivation = False
        Me.lvwxStudy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwxStudy.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwxStudy.FullRowSelect = True
        Me.lvwxStudy.GridLines = True
        Me.lvwxStudy.Location = New System.Drawing.Point(259, 159)
        Me.lvwxStudy.MultiSelect = False
        Me.lvwxStudy.Name = "lvwxStudy"
        Me.lvwxStudy.Size = New System.Drawing.Size(290, 43)
        Me.lvwxStudy.TabIndex = 7
        Me.lvwxStudy.UseCompatibleStateImageBehavior = False
        Me.lvwxStudy.View = System.Windows.Forms.View.Details
        Me.lvwxStudy.Visible = False
        '
        'lvwxStudyC1
        '
        Me.lvwxStudyC1.Text = "Studies Participated"
        Me.lvwxStudyC1.Width = 144
        '
        'lvwxStudyC2
        '
        Me.lvwxStudyC2.Text = "Subject ID"
        Me.lvwxStudyC2.Width = 74
        '
        'lvwxStudyC3
        '
        Me.lvwxStudyC3.Text = "Eligible"
        Me.lvwxStudyC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwxStudyC3.Width = 48
        '
        'lvwxStudyC4
        '
        Me.lvwxStudyC4.Text = "Study CD"
        Me.lvwxStudyC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwxStudyC4.Width = 0
        '
        'cboEligible
        '
        Me.cboEligible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEligible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEligible.ItemHeight = 13
        Me.cboEligible.Items.AddRange(New Object() {"Y", "N", ""})
        Me.cboEligible.Location = New System.Drawing.Point(431, 188)
        Me.cboEligible.Name = "cboEligible"
        Me.cboEligible.Size = New System.Drawing.Size(43, 21)
        Me.cboEligible.TabIndex = 103
        Me.cboEligible.TabStop = False
        Me.cboEligible.Visible = False
        '
        'txtStudy
        '
        Me.txtStudy.BackColor = System.Drawing.SystemColors.Control
        Me.txtStudy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudy.Location = New System.Drawing.Point(271, 187)
        Me.txtStudy.MaxLength = 30
        Me.txtStudy.Name = "txtStudy"
        Me.txtStudy.ReadOnly = True
        Me.txtStudy.Size = New System.Drawing.Size(76, 21)
        Me.txtStudy.TabIndex = 102
        Me.txtStudy.TabStop = False
        Me.txtStudy.Text = "Study"
        Me.txtStudy.Visible = False
        '
        'txtSubjectID
        '
        Me.txtSubjectID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSubjectID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectID.Location = New System.Drawing.Point(351, 187)
        Me.txtSubjectID.MaxLength = 5
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.Size = New System.Drawing.Size(76, 21)
        Me.txtSubjectID.TabIndex = 101
        Me.txtSubjectID.TabStop = False
        Me.txtSubjectID.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(257, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "(Check all that apply && enter data into appropriate fields)"
        Me.Label9.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLastEditDate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtPatientID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(331, 430)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 75)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        '
        'txtLastEditDate
        '
        Me.txtLastEditDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastEditDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatient.LastEditDate", True))
        Me.txtLastEditDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastEditDate.ForeColor = System.Drawing.Color.DimGray
        Me.txtLastEditDate.Location = New System.Drawing.Point(88, 45)
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
        Me.Label7.Location = New System.Drawing.Point(8, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Last Edit Date"
        '
        'txtPatientID
        '
        Me.txtPatientID.BackColor = System.Drawing.SystemColors.Control
        Me.txtPatientID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatient.PatientID", True))
        Me.txtPatientID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.ForeColor = System.Drawing.Color.DimGray
        Me.txtPatientID.Location = New System.Drawing.Point(88, 18)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(122, 21)
        Me.txtPatientID.TabIndex = 87
        Me.txtPatientID.TabStop = False
        Me.txtPatientID.Text = "PatientID"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(27, 21)
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
        Me.Label10.Location = New System.Drawing.Point(5, -1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 15)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "For system use only"
        '
        'frmPatientEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(565, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lvwxStudy)
        Me.Controls.Add(Me.cboEligible)
        Me.Controls.Add(Me.txtStudy)
        Me.Controls.Add(Me.txtSubjectID)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMRN)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dts1)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPatientEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing Patient General Info"
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim FormActivated As Boolean = False
    Dim conn As OleDbConnection
    Dim lvwxStudyIsDirty As Boolean = False

    Private Sub frmPatientEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Need the following to Retrieve Microsoft Access Autonumber Value
        'for: xLvwIdx = Me.txtVisitID.Text on save
        conn = New OleDbConnection
        conn.ConnectionString = strConn
        AddHandler ada1.RowUpdated, AddressOf ada1_OnRowUpdate

        Editors = New Control() {Me.txtStudy, Me.txtSubjectID, Me.cboEligible}
        ' Immediately accept the new value once the value of the control has changed
        ' (for example, the dateTimePicker and the comboBox)
        'AddHandler dateTimePicker1.ValueChanged, AddressOf control_SelectedValueChanged
        AddHandler cboEligible.SelectedValueChanged, AddressOf control_SelectedValueChanged

        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            FillCheckBoxGroup(Me, Me.ds.tbPatient.Rows(0).Item("Race").ToString, "chkRace", 6)
            FillRadioButtonGroup(Me, Me.ds.tbPatient.Rows(0).Item("Ethnicity").ToString, "rbEthnicity", 3)
        Else
            Me.BindingContext(Me.ds, "tbPatient").AddNew()
            'Need this after AddNew
            Me.BindingContext(Me.ds, "tbPatient").Position = 0
            If UCase(vfrmPatient.cboStudy.SelectedItem.ToString) = "HPV" Then Me.cboGender.Text = "F"
        End If

        FillDateTimeSlickers(Me, Me.ds.tbPatient, "dts", 1, "01/01/" & Today.Year - 15)
        'Fill_lvwxStudy()

    End Sub

    Private Sub frmPatientEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub

    Private Sub frmPatientEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmPatientEdit = Nothing
    End Sub

    Private Sub ada1_OnRowUpdate(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
        Try
            'If vb.Left(Me.Text.ToString, 6) = "Adding" Then
            If e.StatementType = StatementType.Insert Then
                Dim oCmd As New OleDbCommand("SELECT @@IDENTITY")
                oCmd.Connection = conn
                e.Row("PatientID") = oCmd.ExecuteScalar()
                e.Row.AcceptChanges()
                'MsgBox(e.Row("PatientID"))
            End If
        Catch ex As Exception
            Throw
        End Try        
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Try
            Dim resp As MsgBoxResult
            If vb.Left(Me.Text.ToString, 6) = "Adding" Then
                resp = MsgBox("Do you want to add this new patient?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then

                    If ValidationPassed() Then
                        'MsgBox(System.DateTime.Now.ToString)
                        txtLastEditDate.Text = System.DateTime.Now
                        Me.BindingContext(Me.ds, "tbPatient").EndCurrentEdit()

                        UpdateDataSourceAddNew(Me.ds, "tbPatient", conn, Me.ada1)
                        CloseAndUpdate()

                    End If

                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If

            Else

                Dim objDataSetChanges As DataSet1 = New DataSet1
                Me.BindingContext(Me.ds, "tbPatient").EndCurrentEdit()
                objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)
                If (Not (objDataSetChanges) Is Nothing) Or lvwxStudyIsDirty Then
                    resp = MsgBox("Do you want to save your changes?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                    If resp = MsgBoxResult.Yes Then

                        If ValidationPassed() Then
                            'Must cancel edit first
                            Me.BindingContext(Me.ds, "tbPatient").CancelCurrentEdit()
                            txtLastEditDate.Text = System.DateTime.Now
                            Me.BindingContext(Me.ds, "tbPatient").EndCurrentEdit()
                            objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)

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

        If Me.txtLastName.Text.Trim.Length = 0 Then
            MsgBox("'Last Name' is required.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
            Me.txtLastName.Focus()
            Return False
            Exit Function
        End If

        If Me.txtFirstName.Text.Trim.Length = 0 Then
            MsgBox("'First Name' is required.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
            Me.txtFirstName.Focus()
            Return False
            Exit Function
        End If

        If Me.txtMRN.Text.Trim.Length = 0 Then
            MsgBox("'MRN' is required.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
            Me.txtMRN.Focus()
            Return False
            Exit Function
        End If

        If Not IsNumeric(Me.txtMRN.Text.Trim) Then
            MsgBox("'MRN' MUST be a number.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
            Me.txtMRN.Focus()
            Return False
            Exit Function
        End If

        Dim strDataExists As String
        strDataExists = "WHERE TRIM(MRN)='" & Me.txtMRN.Text.Trim & "'"
        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            strDataExists = strDataExists & " AND PatientID<>" & txtPatientID.Text
        End If
        If DataExists("tbPatient", strDataExists) Then
            MsgBox("MRN '" & Me.txtMRN.Text.Trim & "' already exists.", vbOKOnly + vbInformation)
            Me.txtMRN.Focus()
            Return False
            Exit Function
        End If

        'Don't really need the following 
        'because if the above condition is false then the following ever happens
        'but leave them here for now
        strDataExists = _
        "WHERE TRIM(LastName)='" & Me.txtLastName.Text.Trim & "' AND TRIM(FirstName)='" & Me.txtFirstName.Text.Trim & "' AND TRIM(MRN)='" & Me.txtMRN.Text.Trim & "'"
        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            strDataExists = strDataExists & " AND PatientID<>" & txtPatientID.Text
        End If
        If DataExists("tbPatient", strDataExists) Then
            MsgBox("Patient '" & Me.txtFirstName.Text.Trim & " " & Me.txtLastName.Text.Trim & "' with MRN '" & Me.txtMRN.Text.Trim & "' already exists.", vbOKOnly + vbInformation)
            Me.txtLastName.Focus()
            Return False
            Exit Function
        End If

    End Function

    Private Sub CloseAndUpdate()

        xLvwIdx = Me.txtPatientID.Text 'Need this 
        'MsgBox(xLvwIdx)

        If lvwxStudyIsDirty Then
            Update_tbStudyPatient()
        End If

        With vfrmPatient
            Select Case UCase(.cboStudy.SelectedItem.ToString)
                Case "ALL PATIENTS"
                    Me.Close()
                    .Fill_lvw0()
                    SelectLvwItem(.lvw0, xLvwIdx, .lvw0.Columns.Count - 1)
                    .Update_Tab1()
                    .lvw0.Focus()
                Case "HPV"
                    If MsgBox("Do you want to create a HPV episode for this patient so she'll be in the HPV patient group?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        If vfrmStuHpvEpiEdit Is Nothing Then
                            vfrmStuHpvEpiEdit = New frmStuHpvEpiEdit
                            With vfrmStuHpvEpiEdit
                                .Text = "Adding a new HPV episode . . ."
                                .ShowDialog()
                            End With
                        End If
                    Else
                        Me.Close()
                    End If
                Case Else
                    Me.Close()
            End Select
        End With

    End Sub

    Private Sub Update_tbStudyPatient()

        Dim PatID As Integer = Me.txtPatientID.Text
        Dim strSQL As String, strEligible As String
        
        RunSQL("DELETE * FROM tbStudyPatient WHERE PatientID=" & PatID)
        For Each itm As ListViewItem In Me.lvwxStudy.Items
            If itm.Checked Then
                strSQL = "INSERT INTO tbStudyPatient " & _
                          "(StudyCd, PatientID, SubjectID, Eligible) " & _
                           "VALUES (" & itm.SubItems(3).Text & ", " & _
                                        PatID & ", '" & _
                                        itm.SubItems(1).Text & "', '" & _
                                        itm.SubItems(2).Text & "')"
                Console.WriteLine(strSQL)
                RunSQL(strSQL)
            End If
        Next

    End Sub

    Private Sub Fill_lvwxStudy()

        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            LvwMoveAll(vfrmPatient.lvwStudy, Me.lvwxStudy, False, False, True, False)
        End If

        Dim strSQL As String = "SELECT StudyDesc, '' AS SubjectID, '' AS Eligible, StudyCd FROM tbStudy WHERE Active<0 "
        If lvwxStudy.Items.Count > 0 Then
            strSQL = strSQL & " AND " & _
                     "StudyCd Not In (" & LvwItems(lvwxStudy, 3, False) & ")"
        End If
        Fill_lvw(lvwxStudy, strSQL, False, False)
    End Sub

    Private Sub dts1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.TextChanged
        If FormActivated Then
            Me.ds.tbPatient.Item(0).DateOfBirth = dts1.Value
        End If
    End Sub

    Private Sub dts1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.CheckedChanged
        If FormActivated Then
            Select Case dts1.Checked
                Case True
                    Me.ds.tbPatient.Item(0).DateOfBirth = dts1.Value
                Case False
                    Me.ds.tbPatient.Item(0).SetDateOfBirthNull()
            End Select
        End If
    End Sub

    Private Sub chkRace_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles chkRace1.Click, chkRace2.Click, chkRace3.Click, _
                    chkRace4.Click, chkRace5.Click, chkRace6.Click
        'MsgBox(sender.name)
        UpdateCheckBoxGroupField(Me, Me.ds.tbPatient, "Race", "chkRace", 6)

    End Sub

    Private Sub cboGender_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGender.SelectedValueChanged
        If FormActivated Then
            Me.ds.tbPatient.Rows(0).Item("Gender") = cboGender.Text
        End If
    End Sub

    Private Sub rbEthnicity_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rbEthnicity1.Click, rbEthnicity2.Click, rbEthnicity3.Click

        Me.ds.tbPatient.Rows(0).Item("Ethnicity") = sender.tag
        'The following also works
        'UpdateRadioButtonGroupField(Me, Me.ds.tbPatient, "Ethnicity", "rbEthnicity", 3)

    End Sub
    Private Sub rbEthnicity_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
            Handles rbEthnicity1.MouseDown, rbEthnicity2.MouseDown, rbEthnicity3.MouseDown
        If e.Button = MouseButtons.Right Then
            EmptyRadioButtonGroup(Me, Me.ds.tbPatient, "Ethnicity", sender.name, 3)
        End If
    End Sub





    Private Sub control_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        lvwxStudy.EndEditing(True)
    End Sub 'control_SelectedValueChanged

    Private Sub lvwxStudy_SubItemClicked(ByVal sender As Object, ByVal e As ListViewEx.SubItemEventArgs) Handles lvwxStudy.SubItemClicked
        If e.Item.Checked Then
            lvwxStudy.StartEditing(Editors(e.SubItem), e.Item, e.SubItem)
            If Me.ActiveControl.Name = "txtStudy" Then 'Editing the 1st column is NOT allowed
                txtStudy.Visible = False
                'e.Item.Selected = True
                lvwxStudy.Focus()
            End If
        End If
    End Sub

    Private Sub lvwxStudy_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwxStudy.ColumnClick
        'SortLvw(lvwxStudy, e.Column)
    End Sub

    Private Sub lvwxStudy_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvwxStudy.ItemCheck
        If FormActivated Then lvwxStudyIsDirty = True
    End Sub

    Private Sub txtSubjectID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubjectID.TextChanged
        If Me.ActiveControl.Name = "txtSubjectID" Then
            If FormActivated Then lvwxStudyIsDirty = True
        End If
    End Sub

    Private Sub cboEligible_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEligible.SelectedValueChanged
        If Me.ActiveControl.Name = "cboEligible" Then
            If FormActivated Then lvwxStudyIsDirty = True
        End If
    End Sub

    Private Sub txtTrimText_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtLastName.LostFocus, txtFirstName.LostFocus, txtMRN.LostFocus
        Dim txt As TextBox = CType(FindControl(Me, sender.name), TextBox)
        txt.Text = txt.Text.Trim
    End Sub
End Class


