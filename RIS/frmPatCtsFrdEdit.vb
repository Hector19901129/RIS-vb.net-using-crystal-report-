Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb
Imports RIS.DataSet1
Public Class frmPatCtsFrdEdit
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
    Friend WithEvents ds As RIS.DataSet1
    Friend WithEvents lvwCtMthdSlf2C3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlf1C1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlf1C2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlf2C2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlf2C1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnMoveCtMthdUp As System.Windows.Forms.Button
    Friend WithEvents btnMoveCtMthdDn As System.Windows.Forms.Button
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ils16X16 As System.Windows.Forms.ImageList
    Friend WithEvents Tab1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab1P1 As System.Windows.Forms.TabPage
    Friend WithEvents Tab1P2 As System.Windows.Forms.TabPage
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtSpecialRequests As System.Windows.Forms.TextBox
    Friend WithEvents lvwEmail As System.Windows.Forms.ListView
    Friend WithEvents lvwEmailC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwEmailC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cboEmail As System.Windows.Forms.ComboBox
    Friend WithEvents cboPhone As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents grpAddress As System.Windows.Forms.GroupBox
    Friend WithEvents grpName As System.Windows.Forms.GroupBox
    Friend WithEvents cboOnline As System.Windows.Forms.ComboBox
    Friend WithEvents grpPhone As System.Windows.Forms.GroupBox
    Friend WithEvents grpEmail As System.Windows.Forms.GroupBox
    Friend WithEvents grpOnline As System.Windows.Forms.GroupBox
    Friend WithEvents lvwPhone As System.Windows.Forms.ListView
    Friend WithEvents lvwPhoneC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwPhoneC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents mskPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnShowlvwPhone As System.Windows.Forms.Button
    Friend WithEvents btnShowlvwEmail As System.Windows.Forms.Button
    Friend WithEvents txtOnlineDispName As System.Windows.Forms.RichTextBox
    Friend WithEvents txtOnlineURL As System.Windows.Forms.TextBox
    Friend WithEvents txtOnlineEmail As System.Windows.Forms.TextBox
    Friend WithEvents lvwOnline As System.Windows.Forms.ListView
    Friend WithEvents lvwOnlineC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwOnlineC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwOnlineC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwOnlineC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwOnlineC5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtOnlineName As System.Windows.Forms.TextBox
    Friend WithEvents lvwOnlineTypeCd_FieldName As System.Windows.Forms.ListView
    Friend WithEvents lvwOnlineTypeCd_FieldNameC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwOnlineTypeCd_FieldNameC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection

    Friend WithEvents da_tbContact As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents mskZip As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents da_tbContactAddress As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents lvwEmailC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwOnlineC6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents da_tbContact_SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents da_tbContactAddress_SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents lvwContactChoiceSelected As System.Windows.Forms.ListView
    Friend WithEvents lvwContactChoiceAvailable As System.Windows.Forms.ListView
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbDispName As System.Windows.Forms.ToolBar
    Friend WithEvents lvwPhoneC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwPhoneC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPhoneNumberOwner As System.Windows.Forms.TextBox
    Friend WithEvents lvwPhoneTypeCd_FieldName As System.Windows.Forms.ListView
    Friend WithEvents lvwPhoneTypeCd_FieldNameC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwPhoneTypeCd_FieldNameC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtWhoIsThis As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbContactBestTimeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbContactBestTimeTableAdapter As RIS.DataSet1TableAdapters.tbContactBestTimeTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkEveningsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAfternoonsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMorningsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTimeAfter5CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTime3to5CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTime1to3CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTime12to1CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTime10to11CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTime8to10CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSaturdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFridayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkThursdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkWednesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTuesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMondayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lblPhoneNumberOwner As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatCtsFrdEdit))
        Me.ds = New RIS.DataSet1
        Me.btnExit = New System.Windows.Forms.Button
        Me.da_tbContact = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.da_tbContact_SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.lvwContactChoiceSelected = New System.Windows.Forms.ListView
        Me.lvwCtMthdSlf2C1 = New System.Windows.Forms.ColumnHeader
        Me.lvwCtMthdSlf2C2 = New System.Windows.Forms.ColumnHeader
        Me.lvwCtMthdSlf2C3 = New System.Windows.Forms.ColumnHeader
        Me.lvwContactChoiceAvailable = New System.Windows.Forms.ListView
        Me.lvwCtMthdSlf1C1 = New System.Windows.Forms.ColumnHeader
        Me.lvwCtMthdSlf1C2 = New System.Windows.Forms.ColumnHeader
        Me.btnMoveCtMthdUp = New System.Windows.Forms.Button
        Me.ils16X16 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnMoveCtMthdDn = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnShowlvwPhone = New System.Windows.Forms.Button
        Me.btnShowlvwEmail = New System.Windows.Forms.Button
        Me.cboEmail = New System.Windows.Forms.ComboBox
        Me.cboPhone = New System.Windows.Forms.ComboBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Tab1 = New System.Windows.Forms.TabControl
        Me.Tab1P1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ChkEveningsCheckBox = New System.Windows.Forms.CheckBox
        Me.TbContactBestTimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChkAfternoonsCheckBox = New System.Windows.Forms.CheckBox
        Me.ChkMorningsCheckBox = New System.Windows.Forms.CheckBox
        Me.ChkTimeAfter5CheckBox = New System.Windows.Forms.CheckBox
        Me.ChkTime3to5CheckBox = New System.Windows.Forms.CheckBox
        Me.ChkTime1to3CheckBox = New System.Windows.Forms.CheckBox
        Me.ChkTime12to1CheckBox = New System.Windows.Forms.CheckBox
        Me.ChkTime10to11CheckBox = New System.Windows.Forms.CheckBox
        Me.ChkTime8to10CheckBox = New System.Windows.Forms.CheckBox
        Me.ChkSaturdayCheckBox = New System.Windows.Forms.CheckBox
        Me.ChkFridayCheckBox = New System.Windows.Forms.CheckBox
        Me.ChkThursdayCheckBox = New System.Windows.Forms.CheckBox
        Me.ChkWednesdayCheckBox = New System.Windows.Forms.CheckBox
        Me.ChkTuesdayCheckBox = New System.Windows.Forms.CheckBox
        Me.ChkMondayCheckBox = New System.Windows.Forms.CheckBox
        Me.lvwEmail = New System.Windows.Forms.ListView
        Me.lvwEmailC1 = New System.Windows.Forms.ColumnHeader
        Me.lvwEmailC2 = New System.Windows.Forms.ColumnHeader
        Me.lvwEmailC3 = New System.Windows.Forms.ColumnHeader
        Me.grpOnline = New System.Windows.Forms.GroupBox
        Me.txtOnlineDispName = New System.Windows.Forms.RichTextBox
        Me.tbDispName = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.lvwOnlineTypeCd_FieldName = New System.Windows.Forms.ListView
        Me.lvwOnlineTypeCd_FieldNameC1 = New System.Windows.Forms.ColumnHeader
        Me.lvwOnlineTypeCd_FieldNameC2 = New System.Windows.Forms.ColumnHeader
        Me.cboOnline = New System.Windows.Forms.ComboBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtOnlineName = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtOnlineURL = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtOnlineEmail = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.lvwOnline = New System.Windows.Forms.ListView
        Me.lvwOnlineC1 = New System.Windows.Forms.ColumnHeader
        Me.lvwOnlineC2 = New System.Windows.Forms.ColumnHeader
        Me.lvwOnlineC3 = New System.Windows.Forms.ColumnHeader
        Me.lvwOnlineC4 = New System.Windows.Forms.ColumnHeader
        Me.lvwOnlineC5 = New System.Windows.Forms.ColumnHeader
        Me.lvwOnlineC6 = New System.Windows.Forms.ColumnHeader
        Me.grpEmail = New System.Windows.Forms.GroupBox
        Me.lvwPhone = New System.Windows.Forms.ListView
        Me.lvwPhoneC1 = New System.Windows.Forms.ColumnHeader
        Me.lvwPhoneC2 = New System.Windows.Forms.ColumnHeader
        Me.lvwPhoneC3 = New System.Windows.Forms.ColumnHeader
        Me.lvwPhoneC4 = New System.Windows.Forms.ColumnHeader
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.grpPhone = New System.Windows.Forms.GroupBox
        Me.txtPhoneNumberOwner = New System.Windows.Forms.TextBox
        Me.lblPhoneNumberOwner = New System.Windows.Forms.Label
        Me.mskPhone = New System.Windows.Forms.TextBox
        Me.lvwPhoneTypeCd_FieldName = New System.Windows.Forms.ListView
        Me.lvwPhoneTypeCd_FieldNameC1 = New System.Windows.Forms.ColumnHeader
        Me.lvwPhoneTypeCd_FieldNameC2 = New System.Windows.Forms.ColumnHeader
        Me.grpAddress = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.mskZip = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.cboState = New System.Windows.Forms.ComboBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.chk2 = New System.Windows.Forms.CheckBox
        Me.chk1 = New System.Windows.Forms.CheckBox
        Me.grpName = New System.Windows.Forms.GroupBox
        Me.txtWhoIsThis = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.Tab1P2 = New System.Windows.Forms.TabPage
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtSpecialRequests = New System.Windows.Forms.TextBox
        Me.da_tbContactAddress = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.da_tbContactAddress_SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.TbContactBestTimeTableAdapter = New RIS.DataSet1TableAdapters.tbContactBestTimeTableAdapter
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab1.SuspendLayout()
        Me.Tab1P1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TbContactBestTimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOnline.SuspendLayout()
        Me.grpEmail.SuspendLayout()
        Me.grpPhone.SuspendLayout()
        CType(Me.mskPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddress.SuspendLayout()
        CType(Me.mskZip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpName.SuspendLayout()
        Me.Tab1P2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ds
        '
        Me.ds.DataSetName = "DataSet1"
        Me.ds.Locale = New System.Globalization.CultureInfo("en-US")
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 1
        Me.btnExit.Location = New System.Drawing.Point(751, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(34, 20)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'da_tbContact
        '
        Me.da_tbContact.DeleteCommand = Me.OleDbDeleteCommand1
        Me.da_tbContact.InsertCommand = Me.OleDbInsertCommand1
        Me.da_tbContact.SelectCommand = Me.da_tbContact_SelectComm
        Me.da_tbContact.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbContact", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CanMailReminder", "CanMailReminder"), New System.Data.Common.DataColumnMapping("CanTextMessage", "CanTextMessage"), New System.Data.Common.DataColumnMapping("ContactID", "ContactID"), New System.Data.Common.DataColumnMapping("ContactOwnerCd", "ContactOwnerCd"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("SpecialRequestsWhenContact", "SpecialRequestsWhenContact"), New System.Data.Common.DataColumnMapping("WhoIsThisPerson", "WhoIsThisPerson")})})
        Me.da_tbContact.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("IsNull_CanMailReminder", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CanMailReminder", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CanMailReminder", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanMailReminder", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_CanTextMessage", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CanTextMessage", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CanTextMessage", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanTextMessage", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ContactOwnerCd", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ContactOwnerCd", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactOwnerCd", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_LastEditDate", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_LastEditLoginID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_PatientID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SpecialRequestsWhenContact", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialRequestsWhenContact", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_WhoIsThisPerson", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WhoIsThisPerson", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_WhoIsThisPerson", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WhoIsThisPerson", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Data\RISdata.mdb" & _
            ""
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CanMailReminder", System.Data.OleDb.OleDbType.[Boolean], 0, "CanMailReminder"), New System.Data.OleDb.OleDbParameter("CanTextMessage", System.Data.OleDb.OleDbType.[Boolean], 0, "CanTextMessage"), New System.Data.OleDb.OleDbParameter("ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, "ContactOwnerCd"), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 0, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"), New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.[Integer], 0, "PatientID"), New System.Data.OleDb.OleDbParameter("SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.VarWChar, 0, "SpecialRequestsWhenContact"), New System.Data.OleDb.OleDbParameter("WhoIsThisPerson", System.Data.OleDb.OleDbType.VarWChar, 0, "WhoIsThisPerson")})
        '
        'da_tbContact_SelectComm
        '
        Me.da_tbContact_SelectComm.CommandText = "SELECT CanMailReminder, CanTextMessage, ContactID, ContactOwnerCd, FirstName, Las" & _
            "tEditDate, LastEditLoginID, LastName, PatientID, SpecialRequestsWhenContact, Who" & _
            "IsThisPerson  FROM tbContact"
        Me.da_tbContact_SelectComm.Connection = Me.OleDbConnection2
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CanMailReminder", System.Data.OleDb.OleDbType.[Boolean], 0, "CanMailReminder"), New System.Data.OleDb.OleDbParameter("CanTextMessage", System.Data.OleDb.OleDbType.[Boolean], 0, "CanTextMessage"), New System.Data.OleDb.OleDbParameter("ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, "ContactOwnerCd"), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 0, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"), New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.[Integer], 0, "PatientID"), New System.Data.OleDb.OleDbParameter("SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.VarWChar, 0, "SpecialRequestsWhenContact"), New System.Data.OleDb.OleDbParameter("WhoIsThisPerson", System.Data.OleDb.OleDbType.VarWChar, 0, "WhoIsThisPerson"), New System.Data.OleDb.OleDbParameter("IsNull_CanMailReminder", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CanMailReminder", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CanMailReminder", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanMailReminder", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_CanTextMessage", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CanTextMessage", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CanTextMessage", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanTextMessage", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ContactOwnerCd", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ContactOwnerCd", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactOwnerCd", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_LastEditDate", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_LastEditLoginID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_PatientID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SpecialRequestsWhenContact", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialRequestsWhenContact", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_WhoIsThisPerson", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WhoIsThisPerson", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_WhoIsThisPerson", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WhoIsThisPerson", System.Data.DataRowVersion.Original, Nothing)})
        '
        'lvwContactChoiceSelected
        '
        Me.lvwContactChoiceSelected.BackColor = System.Drawing.SystemColors.Window
        Me.lvwContactChoiceSelected.CheckBoxes = True
        Me.lvwContactChoiceSelected.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwCtMthdSlf2C1, Me.lvwCtMthdSlf2C2, Me.lvwCtMthdSlf2C3})
        Me.lvwContactChoiceSelected.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwContactChoiceSelected.FullRowSelect = True
        Me.lvwContactChoiceSelected.GridLines = True
        Me.lvwContactChoiceSelected.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwContactChoiceSelected.HideSelection = False
        Me.lvwContactChoiceSelected.Location = New System.Drawing.Point(527, 26)
        Me.lvwContactChoiceSelected.MultiSelect = False
        Me.lvwContactChoiceSelected.Name = "lvwContactChoiceSelected"
        Me.lvwContactChoiceSelected.Size = New System.Drawing.Size(223, 226)
        Me.lvwContactChoiceSelected.TabIndex = 0
        Me.lvwContactChoiceSelected.UseCompatibleStateImageBehavior = False
        Me.lvwContactChoiceSelected.View = System.Windows.Forms.View.Details
        '
        'lvwCtMthdSlf2C1
        '
        Me.lvwCtMthdSlf2C1.Text = "Contact methods selected"
        Me.lvwCtMthdSlf2C1.Width = 163
        '
        'lvwCtMthdSlf2C2
        '
        Me.lvwCtMthdSlf2C2.Text = "Choice"
        Me.lvwCtMthdSlf2C2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwCtMthdSlf2C2.Width = 38
        '
        'lvwCtMthdSlf2C3
        '
        Me.lvwCtMthdSlf2C3.Text = "Cd"
        Me.lvwCtMthdSlf2C3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwCtMthdSlf2C3.Width = 0
        '
        'lvwContactChoiceAvailable
        '
        Me.lvwContactChoiceAvailable.BackColor = System.Drawing.SystemColors.Window
        Me.lvwContactChoiceAvailable.CheckBoxes = True
        Me.lvwContactChoiceAvailable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwCtMthdSlf1C1, Me.lvwCtMthdSlf1C2})
        Me.lvwContactChoiceAvailable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwContactChoiceAvailable.FullRowSelect = True
        Me.lvwContactChoiceAvailable.GridLines = True
        Me.lvwContactChoiceAvailable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwContactChoiceAvailable.HideSelection = False
        Me.lvwContactChoiceAvailable.Location = New System.Drawing.Point(527, 271)
        Me.lvwContactChoiceAvailable.MultiSelect = False
        Me.lvwContactChoiceAvailable.Name = "lvwContactChoiceAvailable"
        Me.lvwContactChoiceAvailable.Size = New System.Drawing.Size(223, 226)
        Me.lvwContactChoiceAvailable.TabIndex = 1
        Me.lvwContactChoiceAvailable.UseCompatibleStateImageBehavior = False
        Me.lvwContactChoiceAvailable.View = System.Windows.Forms.View.Details
        '
        'lvwCtMthdSlf1C1
        '
        Me.lvwCtMthdSlf1C1.Text = "Contact methods available"
        Me.lvwCtMthdSlf1C1.Width = 163
        '
        'lvwCtMthdSlf1C2
        '
        Me.lvwCtMthdSlf1C2.Text = "Cd"
        Me.lvwCtMthdSlf1C2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwCtMthdSlf1C2.Width = 0
        '
        'btnMoveCtMthdUp
        '
        Me.btnMoveCtMthdUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoveCtMthdUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveCtMthdUp.ImageIndex = 2
        Me.btnMoveCtMthdUp.ImageList = Me.ils16X16
        Me.btnMoveCtMthdUp.Location = New System.Drawing.Point(754, 98)
        Me.btnMoveCtMthdUp.Name = "btnMoveCtMthdUp"
        Me.btnMoveCtMthdUp.Size = New System.Drawing.Size(27, 26)
        Me.btnMoveCtMthdUp.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnMoveCtMthdUp, "Move the selected contact method up.")
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
        '
        'btnMoveCtMthdDn
        '
        Me.btnMoveCtMthdDn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoveCtMthdDn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveCtMthdDn.ImageIndex = 3
        Me.btnMoveCtMthdDn.ImageList = Me.ils16X16
        Me.btnMoveCtMthdDn.Location = New System.Drawing.Point(754, 133)
        Me.btnMoveCtMthdDn.Name = "btnMoveCtMthdDn"
        Me.btnMoveCtMthdDn.Size = New System.Drawing.Size(27, 26)
        Me.btnMoveCtMthdDn.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnMoveCtMthdDn, "Move the selected contact method down.")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'btnShowlvwPhone
        '
        Me.btnShowlvwPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowlvwPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowlvwPhone.ImageIndex = 3
        Me.btnShowlvwPhone.ImageList = Me.ils16X16
        Me.btnShowlvwPhone.Location = New System.Drawing.Point(473, 11)
        Me.btnShowlvwPhone.Name = "btnShowlvwPhone"
        Me.btnShowlvwPhone.Size = New System.Drawing.Size(22, 19)
        Me.btnShowlvwPhone.TabIndex = 127
        Me.ToolTip1.SetToolTip(Me.btnShowlvwPhone, "Show all phone numbers.")
        '
        'btnShowlvwEmail
        '
        Me.btnShowlvwEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowlvwEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowlvwEmail.ImageIndex = 3
        Me.btnShowlvwEmail.ImageList = Me.ils16X16
        Me.btnShowlvwEmail.Location = New System.Drawing.Point(473, 11)
        Me.btnShowlvwEmail.Name = "btnShowlvwEmail"
        Me.btnShowlvwEmail.Size = New System.Drawing.Size(22, 19)
        Me.btnShowlvwEmail.TabIndex = 128
        Me.ToolTip1.SetToolTip(Me.btnShowlvwEmail, "Show all email addresses.")
        '
        'cboEmail
        '
        Me.cboEmail.BackColor = System.Drawing.SystemColors.Control
        Me.cboEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmail.DropDownWidth = 136
        Me.cboEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmail.ForeColor = System.Drawing.Color.DarkBlue
        Me.cboEmail.Location = New System.Drawing.Point(5, 10)
        Me.cboEmail.Name = "cboEmail"
        Me.cboEmail.Size = New System.Drawing.Size(169, 21)
        Me.cboEmail.TabIndex = 0
        Me.cboEmail.TabStop = False
        '
        'cboPhone
        '
        Me.cboPhone.BackColor = System.Drawing.SystemColors.Control
        Me.cboPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhone.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPhone.ForeColor = System.Drawing.Color.DarkBlue
        Me.cboPhone.Location = New System.Drawing.Point(5, 10)
        Me.cboPhone.Name = "cboPhone"
        Me.cboPhone.Size = New System.Drawing.Size(141, 21)
        Me.cboPhone.TabIndex = 0
        Me.cboPhone.TabStop = False
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label53.Location = New System.Drawing.Point(527, 10)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(227, 15)
        Me.Label53.TabIndex = 61
        Me.Label53.Text = "Contact methods selected          Choice"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(527, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 15)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Contact methods available"
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.Tab1P1)
        Me.Tab1.Controls.Add(Me.Tab1P2)
        Me.Tab1.Location = New System.Drawing.Point(4, 5)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(519, 653)
        Me.Tab1.TabIndex = 0
        '
        'Tab1P1
        '
        Me.Tab1P1.Controls.Add(Me.GroupBox1)
        Me.Tab1P1.Controls.Add(Me.lvwEmail)
        Me.Tab1P1.Controls.Add(Me.grpOnline)
        Me.Tab1P1.Controls.Add(Me.lvwOnline)
        Me.Tab1P1.Controls.Add(Me.grpEmail)
        Me.Tab1P1.Controls.Add(Me.grpPhone)
        Me.Tab1P1.Controls.Add(Me.grpAddress)
        Me.Tab1P1.Controls.Add(Me.grpName)
        Me.Tab1P1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1P1.Name = "Tab1P1"
        Me.Tab1P1.Size = New System.Drawing.Size(511, 627)
        Me.Tab1P1.TabIndex = 2
        Me.Tab1P1.Text = "Contact Info"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ChkEveningsCheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkAfternoonsCheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkMorningsCheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkTimeAfter5CheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkTime3to5CheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkTime1to3CheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkTime12to1CheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkTime10to11CheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkTime8to10CheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkSaturdayCheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkFridayCheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkThursdayCheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkWednesdayCheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkTuesdayCheckBox)
        Me.GroupBox1.Controls.Add(Me.ChkMondayCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 498)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 121)
        Me.GroupBox1.TabIndex = 131
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Best Time To Contact"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "OR GENERALLY"
        '
        'ChkEveningsCheckBox
        '
        Me.ChkEveningsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkEvenings", True))
        Me.ChkEveningsCheckBox.Location = New System.Drawing.Point(408, 76)
        Me.ChkEveningsCheckBox.Name = "ChkEveningsCheckBox"
        Me.ChkEveningsCheckBox.Size = New System.Drawing.Size(81, 24)
        Me.ChkEveningsCheckBox.TabIndex = 29
        Me.ChkEveningsCheckBox.Text = "Evenings"
        '
        'TbContactBestTimeBindingSource
        '
        Me.TbContactBestTimeBindingSource.DataMember = "tbContactBestTime"
        Me.TbContactBestTimeBindingSource.DataSource = Me.ds
        '
        'ChkAfternoonsCheckBox
        '
        Me.ChkAfternoonsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkAfternoons", True))
        Me.ChkAfternoonsCheckBox.Location = New System.Drawing.Point(328, 76)
        Me.ChkAfternoonsCheckBox.Name = "ChkAfternoonsCheckBox"
        Me.ChkAfternoonsCheckBox.Size = New System.Drawing.Size(83, 24)
        Me.ChkAfternoonsCheckBox.TabIndex = 27
        Me.ChkAfternoonsCheckBox.Text = "Afternoons"
        '
        'ChkMorningsCheckBox
        '
        Me.ChkMorningsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkMornings", True))
        Me.ChkMorningsCheckBox.Location = New System.Drawing.Point(243, 76)
        Me.ChkMorningsCheckBox.Name = "ChkMorningsCheckBox"
        Me.ChkMorningsCheckBox.Size = New System.Drawing.Size(79, 24)
        Me.ChkMorningsCheckBox.TabIndex = 25
        Me.ChkMorningsCheckBox.Text = "Mornings"
        '
        'ChkTimeAfter5CheckBox
        '
        Me.ChkTimeAfter5CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkTimeAfter5", True))
        Me.ChkTimeAfter5CheckBox.Location = New System.Drawing.Point(128, 95)
        Me.ChkTimeAfter5CheckBox.Name = "ChkTimeAfter5CheckBox"
        Me.ChkTimeAfter5CheckBox.Size = New System.Drawing.Size(104, 23)
        Me.ChkTimeAfter5CheckBox.TabIndex = 23
        Me.ChkTimeAfter5CheckBox.Text = "After 5pm"
        '
        'ChkTime3to5CheckBox
        '
        Me.ChkTime3to5CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkTime3to5", True))
        Me.ChkTime3to5CheckBox.Location = New System.Drawing.Point(18, 95)
        Me.ChkTime3to5CheckBox.Name = "ChkTime3to5CheckBox"
        Me.ChkTime3to5CheckBox.Size = New System.Drawing.Size(104, 23)
        Me.ChkTime3to5CheckBox.TabIndex = 21
        Me.ChkTime3to5CheckBox.Text = "3pm-5pm"
        '
        'ChkTime1to3CheckBox
        '
        Me.ChkTime1to3CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkTime1to3", True))
        Me.ChkTime1to3CheckBox.Location = New System.Drawing.Point(128, 76)
        Me.ChkTime1to3CheckBox.Name = "ChkTime1to3CheckBox"
        Me.ChkTime1to3CheckBox.Size = New System.Drawing.Size(104, 23)
        Me.ChkTime1to3CheckBox.TabIndex = 19
        Me.ChkTime1to3CheckBox.Text = "1pm-3pm"
        '
        'ChkTime12to1CheckBox
        '
        Me.ChkTime12to1CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkTime12to1", True))
        Me.ChkTime12to1CheckBox.Location = New System.Drawing.Point(18, 76)
        Me.ChkTime12to1CheckBox.Name = "ChkTime12to1CheckBox"
        Me.ChkTime12to1CheckBox.Size = New System.Drawing.Size(79, 23)
        Me.ChkTime12to1CheckBox.TabIndex = 17
        Me.ChkTime12to1CheckBox.Text = "12pm-1pm"
        '
        'ChkTime10to11CheckBox
        '
        Me.ChkTime10to11CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkTime10to11", True))
        Me.ChkTime10to11CheckBox.Location = New System.Drawing.Point(128, 56)
        Me.ChkTime10to11CheckBox.Name = "ChkTime10to11CheckBox"
        Me.ChkTime10to11CheckBox.Size = New System.Drawing.Size(104, 23)
        Me.ChkTime10to11CheckBox.TabIndex = 15
        Me.ChkTime10to11CheckBox.Text = "10am-11:30am"
        '
        'ChkTime8to10CheckBox
        '
        Me.ChkTime8to10CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkTime8to10", True))
        Me.ChkTime8to10CheckBox.Location = New System.Drawing.Point(18, 56)
        Me.ChkTime8to10CheckBox.Name = "ChkTime8to10CheckBox"
        Me.ChkTime8to10CheckBox.Size = New System.Drawing.Size(104, 23)
        Me.ChkTime8to10CheckBox.TabIndex = 13
        Me.ChkTime8to10CheckBox.Text = "8:30am-10a"
        '
        'ChkSaturdayCheckBox
        '
        Me.ChkSaturdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkSaturday", True))
        Me.ChkSaturdayCheckBox.Location = New System.Drawing.Point(403, 18)
        Me.ChkSaturdayCheckBox.Name = "ChkSaturdayCheckBox"
        Me.ChkSaturdayCheckBox.Size = New System.Drawing.Size(70, 24)
        Me.ChkSaturdayCheckBox.TabIndex = 11
        Me.ChkSaturdayCheckBox.Text = "Saturday"
        '
        'ChkFridayCheckBox
        '
        Me.ChkFridayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkFriday", True))
        Me.ChkFridayCheckBox.Location = New System.Drawing.Point(336, 18)
        Me.ChkFridayCheckBox.Name = "ChkFridayCheckBox"
        Me.ChkFridayCheckBox.Size = New System.Drawing.Size(61, 24)
        Me.ChkFridayCheckBox.TabIndex = 9
        Me.ChkFridayCheckBox.Text = "Friday"
        '
        'ChkThursdayCheckBox
        '
        Me.ChkThursdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkThursday", True))
        Me.ChkThursdayCheckBox.Location = New System.Drawing.Point(258, 18)
        Me.ChkThursdayCheckBox.Name = "ChkThursdayCheckBox"
        Me.ChkThursdayCheckBox.Size = New System.Drawing.Size(71, 24)
        Me.ChkThursdayCheckBox.TabIndex = 7
        Me.ChkThursdayCheckBox.Text = "Thursday"
        '
        'ChkWednesdayCheckBox
        '
        Me.ChkWednesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkWednesday", True))
        Me.ChkWednesdayCheckBox.Location = New System.Drawing.Point(168, 19)
        Me.ChkWednesdayCheckBox.Name = "ChkWednesdayCheckBox"
        Me.ChkWednesdayCheckBox.Size = New System.Drawing.Size(85, 24)
        Me.ChkWednesdayCheckBox.TabIndex = 5
        Me.ChkWednesdayCheckBox.Text = "Wednesday"
        '
        'ChkTuesdayCheckBox
        '
        Me.ChkTuesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkTuesday", True))
        Me.ChkTuesdayCheckBox.Location = New System.Drawing.Point(94, 19)
        Me.ChkTuesdayCheckBox.Name = "ChkTuesdayCheckBox"
        Me.ChkTuesdayCheckBox.Size = New System.Drawing.Size(68, 24)
        Me.ChkTuesdayCheckBox.TabIndex = 3
        Me.ChkTuesdayCheckBox.Text = "Tuesday"
        '
        'ChkMondayCheckBox
        '
        Me.ChkMondayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbContactBestTimeBindingSource, "ChkMonday", True))
        Me.ChkMondayCheckBox.Location = New System.Drawing.Point(18, 19)
        Me.ChkMondayCheckBox.Name = "ChkMondayCheckBox"
        Me.ChkMondayCheckBox.Size = New System.Drawing.Size(70, 24)
        Me.ChkMondayCheckBox.TabIndex = 1
        Me.ChkMondayCheckBox.Text = "Monday"
        '
        'lvwEmail
        '
        Me.lvwEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwEmail.BackColor = System.Drawing.SystemColors.Window
        Me.lvwEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwEmail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwEmailC1, Me.lvwEmailC2, Me.lvwEmailC3})
        Me.lvwEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwEmail.FullRowSelect = True
        Me.lvwEmail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwEmail.HideSelection = False
        Me.lvwEmail.Location = New System.Drawing.Point(17, 268)
        Me.lvwEmail.MultiSelect = False
        Me.lvwEmail.Name = "lvwEmail"
        Me.lvwEmail.Size = New System.Drawing.Size(397, 7)
        Me.lvwEmail.TabIndex = 121
        Me.lvwEmail.UseCompatibleStateImageBehavior = False
        Me.lvwEmail.View = System.Windows.Forms.View.Details
        Me.lvwEmail.Visible = False
        '
        'lvwEmailC1
        '
        Me.lvwEmailC1.Text = "Email Type"
        Me.lvwEmailC1.Width = 162
        '
        'lvwEmailC2
        '
        Me.lvwEmailC2.Text = "Email Address"
        Me.lvwEmailC2.Width = 238
        '
        'lvwEmailC3
        '
        Me.lvwEmailC3.Text = "Email Type Cd"
        Me.lvwEmailC3.Width = 0
        '
        'grpOnline
        '
        Me.grpOnline.Controls.Add(Me.txtOnlineDispName)
        Me.grpOnline.Controls.Add(Me.tbDispName)
        Me.grpOnline.Controls.Add(Me.lvwOnlineTypeCd_FieldName)
        Me.grpOnline.Controls.Add(Me.cboOnline)
        Me.grpOnline.Controls.Add(Me.Label36)
        Me.grpOnline.Controls.Add(Me.txtOnlineName)
        Me.grpOnline.Controls.Add(Me.Label38)
        Me.grpOnline.Controls.Add(Me.txtOnlineURL)
        Me.grpOnline.Controls.Add(Me.Label34)
        Me.grpOnline.Controls.Add(Me.txtOnlineEmail)
        Me.grpOnline.Controls.Add(Me.Label35)
        Me.grpOnline.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpOnline.Location = New System.Drawing.Point(6, 264)
        Me.grpOnline.Name = "grpOnline"
        Me.grpOnline.Size = New System.Drawing.Size(500, 228)
        Me.grpOnline.TabIndex = 128
        Me.grpOnline.TabStop = False
        '
        'txtOnlineDispName
        '
        Me.txtOnlineDispName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOnlineDispName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnlineDispName.Location = New System.Drawing.Point(56, 86)
        Me.txtOnlineDispName.MaxLength = 500
        Me.txtOnlineDispName.Name = "txtOnlineDispName"
        Me.txtOnlineDispName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtOnlineDispName.Size = New System.Drawing.Size(437, 81)
        Me.txtOnlineDispName.TabIndex = 2
        Me.txtOnlineDispName.Text = ""
        '
        'tbDispName
        '
        Me.tbDispName.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.tbDispName.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3})
        Me.tbDispName.ButtonSize = New System.Drawing.Size(16, 16)
        Me.tbDispName.Divider = False
        Me.tbDispName.Dock = System.Windows.Forms.DockStyle.None
        Me.tbDispName.DropDownArrows = True
        Me.tbDispName.ImageList = Me.ils16X16
        Me.tbDispName.Location = New System.Drawing.Point(422, 62)
        Me.tbDispName.Name = "tbDispName"
        Me.tbDispName.ShowToolTips = True
        Me.tbDispName.Size = New System.Drawing.Size(70, 26)
        Me.tbDispName.TabIndex = 132
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 5
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.ToolTipText = "Load MS Word"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 6
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.ToolTipText = "Undo"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 7
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.ToolTipText = "Redo"
        '
        'lvwOnlineTypeCd_FieldName
        '
        Me.lvwOnlineTypeCd_FieldName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwOnlineTypeCd_FieldName.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwOnlineTypeCd_FieldNameC1, Me.lvwOnlineTypeCd_FieldNameC2})
        Me.lvwOnlineTypeCd_FieldName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwOnlineTypeCd_FieldName.GridLines = True
        Me.lvwOnlineTypeCd_FieldName.HideSelection = False
        Me.lvwOnlineTypeCd_FieldName.Location = New System.Drawing.Point(242, 13)
        Me.lvwOnlineTypeCd_FieldName.MultiSelect = False
        Me.lvwOnlineTypeCd_FieldName.Name = "lvwOnlineTypeCd_FieldName"
        Me.lvwOnlineTypeCd_FieldName.Size = New System.Drawing.Size(232, 21)
        Me.lvwOnlineTypeCd_FieldName.TabIndex = 126
        Me.lvwOnlineTypeCd_FieldName.UseCompatibleStateImageBehavior = False
        Me.lvwOnlineTypeCd_FieldName.View = System.Windows.Forms.View.Details
        Me.lvwOnlineTypeCd_FieldName.Visible = False
        '
        'lvwOnlineTypeCd_FieldNameC1
        '
        Me.lvwOnlineTypeCd_FieldNameC1.Text = "OnlineTypeDesc"
        Me.lvwOnlineTypeCd_FieldNameC1.Width = 104
        '
        'lvwOnlineTypeCd_FieldNameC2
        '
        Me.lvwOnlineTypeCd_FieldNameC2.Text = "FieldName"
        Me.lvwOnlineTypeCd_FieldNameC2.Width = 107
        '
        'cboOnline
        '
        Me.cboOnline.BackColor = System.Drawing.SystemColors.Control
        Me.cboOnline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOnline.DropDownWidth = 136
        Me.cboOnline.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOnline.ForeColor = System.Drawing.Color.DarkBlue
        Me.cboOnline.Location = New System.Drawing.Point(5, 10)
        Me.cboOnline.Name = "cboOnline"
        Me.cboOnline.Size = New System.Drawing.Size(169, 21)
        Me.cboOnline.TabIndex = 0
        Me.cboOnline.TabStop = False
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label36.Location = New System.Drawing.Point(6, 41)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(45, 16)
        Me.Label36.TabIndex = 33
        Me.Label36.Text = "Name"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtOnlineName
        '
        Me.txtOnlineName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOnlineName.BackColor = System.Drawing.SystemColors.Window
        Me.txtOnlineName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnlineName.Location = New System.Drawing.Point(56, 38)
        Me.txtOnlineName.MaxLength = 50
        Me.txtOnlineName.Name = "txtOnlineName"
        Me.txtOnlineName.Size = New System.Drawing.Size(437, 21)
        Me.txtOnlineName.TabIndex = 1
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label38.Location = New System.Drawing.Point(6, 86)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(45, 44)
        Me.Label38.TabIndex = 30
        Me.Label38.Text = "Display/Screen name"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtOnlineURL
        '
        Me.txtOnlineURL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOnlineURL.BackColor = System.Drawing.SystemColors.Window
        Me.txtOnlineURL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnlineURL.Location = New System.Drawing.Point(58, 201)
        Me.txtOnlineURL.MaxLength = 100
        Me.txtOnlineURL.Name = "txtOnlineURL"
        Me.txtOnlineURL.Size = New System.Drawing.Size(437, 21)
        Me.txtOnlineURL.TabIndex = 4
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label34.Location = New System.Drawing.Point(8, 176)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 16)
        Me.Label34.TabIndex = 37
        Me.Label34.Text = "Email"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtOnlineEmail
        '
        Me.txtOnlineEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOnlineEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtOnlineEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnlineEmail.Location = New System.Drawing.Point(58, 173)
        Me.txtOnlineEmail.MaxLength = 50
        Me.txtOnlineEmail.Name = "txtOnlineEmail"
        Me.txtOnlineEmail.Size = New System.Drawing.Size(437, 21)
        Me.txtOnlineEmail.TabIndex = 3
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label35.Location = New System.Drawing.Point(8, 196)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(46, 26)
        Me.Label35.TabIndex = 36
        Me.Label35.Text = "Network/URL"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lvwOnline
        '
        Me.lvwOnline.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwOnline.BackColor = System.Drawing.SystemColors.Window
        Me.lvwOnline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwOnline.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwOnlineC1, Me.lvwOnlineC2, Me.lvwOnlineC3, Me.lvwOnlineC4, Me.lvwOnlineC5, Me.lvwOnlineC6})
        Me.lvwOnline.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwOnline.FullRowSelect = True
        Me.lvwOnline.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwOnline.HideSelection = False
        Me.lvwOnline.Location = New System.Drawing.Point(7, 484)
        Me.lvwOnline.MultiSelect = False
        Me.lvwOnline.Name = "lvwOnline"
        Me.lvwOnline.Size = New System.Drawing.Size(412, 8)
        Me.lvwOnline.TabIndex = 130
        Me.lvwOnline.UseCompatibleStateImageBehavior = False
        Me.lvwOnline.View = System.Windows.Forms.View.Details
        Me.lvwOnline.Visible = False
        '
        'lvwOnlineC1
        '
        Me.lvwOnlineC1.Text = "OnlineType"
        Me.lvwOnlineC1.Width = 107
        '
        'lvwOnlineC2
        '
        Me.lvwOnlineC2.Text = "Name"
        Me.lvwOnlineC2.Width = 114
        '
        'lvwOnlineC3
        '
        Me.lvwOnlineC3.Text = "Display name"
        Me.lvwOnlineC3.Width = 131
        '
        'lvwOnlineC4
        '
        Me.lvwOnlineC4.Text = "Email"
        Me.lvwOnlineC4.Width = 56
        '
        'lvwOnlineC5
        '
        Me.lvwOnlineC5.Text = "URL"
        Me.lvwOnlineC5.Width = 73
        '
        'lvwOnlineC6
        '
        Me.lvwOnlineC6.Text = "OnlineType Cd"
        Me.lvwOnlineC6.Width = 0
        '
        'grpEmail
        '
        Me.grpEmail.Controls.Add(Me.btnShowlvwEmail)
        Me.grpEmail.Controls.Add(Me.lvwPhone)
        Me.grpEmail.Controls.Add(Me.txtEmail)
        Me.grpEmail.Controls.Add(Me.cboEmail)
        Me.grpEmail.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpEmail.Location = New System.Drawing.Point(6, 221)
        Me.grpEmail.Name = "grpEmail"
        Me.grpEmail.Size = New System.Drawing.Size(500, 37)
        Me.grpEmail.TabIndex = 127
        Me.grpEmail.TabStop = False
        '
        'lvwPhone
        '
        Me.lvwPhone.BackColor = System.Drawing.SystemColors.Window
        Me.lvwPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwPhone.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwPhoneC1, Me.lvwPhoneC2, Me.lvwPhoneC3, Me.lvwPhoneC4})
        Me.lvwPhone.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwPhone.FullRowSelect = True
        Me.lvwPhone.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwPhone.HideSelection = False
        Me.lvwPhone.Location = New System.Drawing.Point(12, -19)
        Me.lvwPhone.MultiSelect = False
        Me.lvwPhone.Name = "lvwPhone"
        Me.lvwPhone.Size = New System.Drawing.Size(485, 6)
        Me.lvwPhone.TabIndex = 129
        Me.lvwPhone.UseCompatibleStateImageBehavior = False
        Me.lvwPhone.View = System.Windows.Forms.View.Details
        Me.lvwPhone.Visible = False
        '
        'lvwPhoneC1
        '
        Me.lvwPhoneC1.Text = "Phone Type"
        Me.lvwPhoneC1.Width = 136
        '
        'lvwPhoneC2
        '
        Me.lvwPhoneC2.Text = "Phone # "
        Me.lvwPhoneC2.Width = 168
        '
        'lvwPhoneC3
        '
        Me.lvwPhoneC3.Text = "Who"
        Me.lvwPhoneC3.Width = 149
        '
        'lvwPhoneC4
        '
        Me.lvwPhoneC4.Text = "Phone Type Cd"
        Me.lvwPhoneC4.Width = 0
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(177, 10)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(239, 21)
        Me.txtEmail.TabIndex = 1
        '
        'grpPhone
        '
        Me.grpPhone.Controls.Add(Me.txtPhoneNumberOwner)
        Me.grpPhone.Controls.Add(Me.lblPhoneNumberOwner)
        Me.grpPhone.Controls.Add(Me.btnShowlvwPhone)
        Me.grpPhone.Controls.Add(Me.mskPhone)
        Me.grpPhone.Controls.Add(Me.cboPhone)
        Me.grpPhone.Controls.Add(Me.lvwPhoneTypeCd_FieldName)
        Me.grpPhone.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpPhone.Location = New System.Drawing.Point(6, 182)
        Me.grpPhone.Name = "grpPhone"
        Me.grpPhone.Size = New System.Drawing.Size(500, 37)
        Me.grpPhone.TabIndex = 126
        Me.grpPhone.TabStop = False
        '
        'txtPhoneNumberOwner
        '
        Me.txtPhoneNumberOwner.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhoneNumberOwner.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumberOwner.Location = New System.Drawing.Point(319, 10)
        Me.txtPhoneNumberOwner.MaxLength = 25
        Me.txtPhoneNumberOwner.Name = "txtPhoneNumberOwner"
        Me.txtPhoneNumberOwner.Size = New System.Drawing.Size(148, 21)
        Me.txtPhoneNumberOwner.TabIndex = 2
        '
        'lblPhoneNumberOwner
        '
        Me.lblPhoneNumberOwner.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneNumberOwner.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumberOwner.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPhoneNumberOwner.Location = New System.Drawing.Point(291, 14)
        Me.lblPhoneNumberOwner.Name = "lblPhoneNumberOwner"
        Me.lblPhoneNumberOwner.Size = New System.Drawing.Size(28, 15)
        Me.lblPhoneNumberOwner.TabIndex = 128
        Me.lblPhoneNumberOwner.Text = "Who"
        '
        'mskPhone
        '
        Me.mskPhone.Location = New System.Drawing.Point(149, 10)
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(137, 21)
        Me.mskPhone.TabIndex = 1
        '
        'lvwPhoneTypeCd_FieldName
        '
        Me.lvwPhoneTypeCd_FieldName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwPhoneTypeCd_FieldName.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwPhoneTypeCd_FieldNameC1, Me.lvwPhoneTypeCd_FieldNameC2})
        Me.lvwPhoneTypeCd_FieldName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwPhoneTypeCd_FieldName.GridLines = True
        Me.lvwPhoneTypeCd_FieldName.HideSelection = False
        Me.lvwPhoneTypeCd_FieldName.Location = New System.Drawing.Point(134, 8)
        Me.lvwPhoneTypeCd_FieldName.MultiSelect = False
        Me.lvwPhoneTypeCd_FieldName.Name = "lvwPhoneTypeCd_FieldName"
        Me.lvwPhoneTypeCd_FieldName.Size = New System.Drawing.Size(232, 21)
        Me.lvwPhoneTypeCd_FieldName.TabIndex = 134
        Me.lvwPhoneTypeCd_FieldName.UseCompatibleStateImageBehavior = False
        Me.lvwPhoneTypeCd_FieldName.View = System.Windows.Forms.View.Details
        Me.lvwPhoneTypeCd_FieldName.Visible = False
        '
        'lvwPhoneTypeCd_FieldNameC1
        '
        Me.lvwPhoneTypeCd_FieldNameC1.Text = "PhoneTypeDesc"
        Me.lvwPhoneTypeCd_FieldNameC1.Width = 104
        '
        'lvwPhoneTypeCd_FieldNameC2
        '
        Me.lvwPhoneTypeCd_FieldNameC2.Text = "FieldName"
        Me.lvwPhoneTypeCd_FieldNameC2.Width = 107
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(Me.Label9)
        Me.grpAddress.Controls.Add(Me.Label13)
        Me.grpAddress.Controls.Add(Me.mskZip)
        Me.grpAddress.Controls.Add(Me.Label50)
        Me.grpAddress.Controls.Add(Me.Label51)
        Me.grpAddress.Controls.Add(Me.Label52)
        Me.grpAddress.Controls.Add(Me.Label11)
        Me.grpAddress.Controls.Add(Me.Label12)
        Me.grpAddress.Controls.Add(Me.txtCity)
        Me.grpAddress.Controls.Add(Me.cboState)
        Me.grpAddress.Controls.Add(Me.txtAddress1)
        Me.grpAddress.Controls.Add(Me.txtAddress2)
        Me.grpAddress.Controls.Add(Me.chk2)
        Me.grpAddress.Controls.Add(Me.chk1)
        Me.grpAddress.Enabled = False
        Me.grpAddress.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpAddress.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddress.Location = New System.Drawing.Point(6, 76)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(500, 100)
        Me.grpAddress.TabIndex = 107
        Me.grpAddress.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(4, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 15)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Can mail reminder cards"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(4, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 15)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Can text message    "
        '
        'mskZip
        '
        Me.mskZip.Location = New System.Drawing.Point(399, 37)
        Me.mskZip.Name = "mskZip"
        Me.mskZip.Size = New System.Drawing.Size(93, 21)
        Me.mskZip.TabIndex = 5
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label50.Location = New System.Drawing.Point(369, 40)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(23, 15)
        Me.Label50.TabIndex = 80
        Me.Label50.Text = "Zip"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label51.Location = New System.Drawing.Point(283, 40)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(31, 15)
        Me.Label51.TabIndex = 78
        Me.Label51.Text = "State"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label52.Location = New System.Drawing.Point(5, 40)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(26, 15)
        Me.Label52.TabIndex = 76
        Me.Label52.Text = "City"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(5, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 15)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Address"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(422, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Apt #"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCity
        '
        Me.txtCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCity.BackColor = System.Drawing.SystemColors.Control
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactAddress.City", True))
        Me.txtCity.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(54, 37)
        Me.txtCity.MaxLength = 50
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(199, 21)
        Me.txtCity.TabIndex = 3
        '
        'cboState
        '
        Me.cboState.BackColor = System.Drawing.SystemColors.Control
        Me.cboState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactAddress.State", True))
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.ItemHeight = 13
        Me.cboState.Items.AddRange(New Object() {"NY", "NJ", "CT", ""})
        Me.cboState.Location = New System.Drawing.Point(319, 37)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(45, 21)
        Me.cboState.TabIndex = 4
        '
        'txtAddress1
        '
        Me.txtAddress1.BackColor = System.Drawing.SystemColors.Control
        Me.txtAddress1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactAddress.Address1", True))
        Me.txtAddress1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(54, 11)
        Me.txtAddress1.MaxLength = 50
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(367, 21)
        Me.txtAddress1.TabIndex = 0
        '
        'txtAddress2
        '
        Me.txtAddress2.BackColor = System.Drawing.SystemColors.Control
        Me.txtAddress2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactAddress.Address2", True))
        Me.txtAddress2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(460, 11)
        Me.txtAddress2.MaxLength = 10
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(32, 21)
        Me.txtAddress2.TabIndex = 2
        '
        'chk2
        '
        Me.chk2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk2.ForeColor = System.Drawing.Color.DarkBlue
        Me.chk2.Location = New System.Drawing.Point(13, 77)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(139, 21)
        Me.chk2.TabIndex = 7
        Me.chk2.Tag = "CanTextMessage"
        Me.chk2.Text = "Can text message"
        '
        'chk1
        '
        Me.chk1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk1.ForeColor = System.Drawing.Color.DarkBlue
        Me.chk1.Location = New System.Drawing.Point(13, 58)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(139, 21)
        Me.chk1.TabIndex = 6
        Me.chk1.Tag = "CanMailReminder"
        Me.chk1.Text = "Can mail reminder cards"
        '
        'grpName
        '
        Me.grpName.Controls.Add(Me.txtWhoIsThis)
        Me.grpName.Controls.Add(Me.Label2)
        Me.grpName.Controls.Add(Me.txtLastName)
        Me.grpName.Controls.Add(Me.Label3)
        Me.grpName.Controls.Add(Me.Label5)
        Me.grpName.Controls.Add(Me.txtFirstName)
        Me.grpName.Enabled = False
        Me.grpName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpName.Location = New System.Drawing.Point(6, 2)
        Me.grpName.Name = "grpName"
        Me.grpName.Size = New System.Drawing.Size(499, 67)
        Me.grpName.TabIndex = 0
        Me.grpName.TabStop = False
        '
        'txtWhoIsThis
        '
        Me.txtWhoIsThis.BackColor = System.Drawing.SystemColors.Control
        Me.txtWhoIsThis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContact.WhoIsThisPerson", True))
        Me.txtWhoIsThis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhoIsThis.Location = New System.Drawing.Point(110, 39)
        Me.txtWhoIsThis.MaxLength = 30
        Me.txtWhoIsThis.Name = "txtWhoIsThis"
        Me.txtWhoIsThis.Size = New System.Drawing.Size(142, 21)
        Me.txtWhoIsThis.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(-4, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Who Is This Person"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContact.LastName", True))
        Me.txtLastName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(64, 12)
        Me.txtLastName.MaxLength = 30
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(188, 21)
        Me.txtLastName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Last name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(255, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "First name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Control
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContact.FirstName", True))
        Me.txtFirstName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(319, 12)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(172, 21)
        Me.txtFirstName.TabIndex = 1
        '
        'Tab1P2
        '
        Me.Tab1P2.Controls.Add(Me.Label29)
        Me.Tab1P2.Controls.Add(Me.txtSpecialRequests)
        Me.Tab1P2.Location = New System.Drawing.Point(4, 22)
        Me.Tab1P2.Name = "Tab1P2"
        Me.Tab1P2.Size = New System.Drawing.Size(511, 627)
        Me.Tab1P2.TabIndex = 3
        Me.Tab1P2.Text = "Special requests when contacting"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label29.Location = New System.Drawing.Point(6, 6)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(215, 15)
        Me.Label29.TabIndex = 112
        Me.Label29.Text = "Special requests when contacting"
        '
        'txtSpecialRequests
        '
        Me.txtSpecialRequests.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSpecialRequests.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpecialRequests.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContact.SpecialRequestsWhenContact", True))
        Me.txtSpecialRequests.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpecialRequests.Location = New System.Drawing.Point(6, 24)
        Me.txtSpecialRequests.MaxLength = 255
        Me.txtSpecialRequests.Multiline = True
        Me.txtSpecialRequests.Name = "txtSpecialRequests"
        Me.txtSpecialRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSpecialRequests.Size = New System.Drawing.Size(497, 242)
        Me.txtSpecialRequests.TabIndex = 111
        '
        'da_tbContactAddress
        '
        Me.da_tbContactAddress.DeleteCommand = Me.OleDbDeleteCommand2
        Me.da_tbContactAddress.InsertCommand = Me.OleDbInsertCommand2
        Me.da_tbContactAddress.SelectCommand = Me.da_tbContactAddress_SelectComm
        Me.da_tbContactAddress.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbContactAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Address1", "Address1"), New System.Data.Common.DataColumnMapping("Address2", "Address2"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("ContactAddressID", "ContactAddressID"), New System.Data.Common.DataColumnMapping("ContactOwnerCd", "ContactOwnerCd"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("State", "State"), New System.Data.Common.DataColumnMapping("Zip", "Zip")})})
        Me.da_tbContactAddress.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM tbContactAddress WHERE (ContactAddressID = ?)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ContactAddressID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactAddressID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO tbContactAddress(Address1, Address2, City, ContactOwnerCd, LastEditDa" & _
            "te, LastEditLoginID, PatientID, State, Zip) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Address1", System.Data.OleDb.OleDbType.VarWChar, 50, "Address1"), New System.Data.OleDb.OleDbParameter("Address2", System.Data.OleDb.OleDbType.VarWChar, 50, "Address2"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"), New System.Data.OleDb.OleDbParameter("ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, "ContactOwnerCd"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.[Integer], 0, "PatientID"), New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 2, "State"), New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 10, "Zip")})
        '
        'da_tbContactAddress_SelectComm
        '
        Me.da_tbContactAddress_SelectComm.CommandText = "SELECT Address1, Address2, City, ContactAddressID, ContactOwnerCd, LastEditDate, " & _
            "LastEditLoginID, PatientID, State, Zip FROM tbContactAddress"
        Me.da_tbContactAddress_SelectComm.Connection = Me.OleDbConnection2
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE tbContactAddress SET Address1 = ?, Address2 = ?, City = ?, ContactOwnerCd " & _
            "= ?, LastEditDate = ?, LastEditLoginID = ?, PatientID = ?, State = ?, Zip = ? WH" & _
            "ERE (ContactAddressID = ?)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Address1", System.Data.OleDb.OleDbType.VarWChar, 50, "Address1"), New System.Data.OleDb.OleDbParameter("Address2", System.Data.OleDb.OleDbType.VarWChar, 50, "Address2"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"), New System.Data.OleDb.OleDbParameter("ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, "ContactOwnerCd"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.[Integer], 0, "PatientID"), New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 2, "State"), New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 10, "Zip"), New System.Data.OleDb.OleDbParameter("Original_ContactAddressID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactAddressID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'TbContactBestTimeTableAdapter
        '
        Me.TbContactBestTimeTableAdapter.ClearBeforeFill = True
        '
        'frmPatCtsFrdEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(911, 662)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Tab1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.btnMoveCtMthdDn)
        Me.Controls.Add(Me.btnMoveCtMthdUp)
        Me.Controls.Add(Me.lvwContactChoiceSelected)
        Me.Controls.Add(Me.lvwContactChoiceAvailable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPatCtsFrdEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing Contact Info"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab1.ResumeLayout(False)
        Me.Tab1P1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TbContactBestTimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOnline.ResumeLayout(False)
        Me.grpOnline.PerformLayout()
        Me.grpEmail.ResumeLayout(False)
        Me.grpEmail.PerformLayout()
        Me.grpPhone.ResumeLayout(False)
        Me.grpPhone.PerformLayout()
        CType(Me.mskPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        CType(Me.mskZip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpName.ResumeLayout(False)
        Me.grpName.PerformLayout()
        Me.Tab1P2.ResumeLayout(False)
        Me.Tab1P2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FormActivated As Boolean = False
    Dim conn As OleDbConnection
    Dim mskPhoneIsDirty As Boolean = False, cboPhoneOldSelectedIndex As Byte
    Dim txtEmailIsDirty As Boolean = False, cboEmailOldSelectedIndex As Byte
    Dim OnlineFieldsAreDirty As Boolean = False, cboOnlineOldSelectedIndex As Byte
    Dim lvwContactChoiceSelectedIsDirty As Boolean = False

    Dim PatID As Integer = vfrmPatient.lvw0.SelectedItems(0).SubItems(vfrmPatient.lvw0.Columns.Count - 1).Text
    Dim ContactOwnerCd As Byte = vfrmPatient.tabContactInfo.SelectedTab.Tag
    Dim ContactOwnerText As String = vfrmPatient.tabContactInfo.SelectedTab.Text

    Private Sub frmPatCtsFrdEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ds.tbContactBestTime' table. You can move, or remove it, as needed.
        Try
            'On Error Resume Next 'need this in case RichTextBox txtMySpaceDisplayName has invalid format value 

            'Need the following to Retrieve Microsoft Access Autonumber Value
            conn = New OleDbConnection
            conn.ConnectionString = strConn
            'AddHandler da_tbContact.RowUpdated, AddressOf da_tbContact_OnRowUpdate

            Me.TbContactBestTimeTableAdapter.Connection.ConnectionString = strConn

            If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then 'Patient
                'AddHandler da_tbContactAddress.RowUpdated, AddressOf da_tbContactAddress_OnRowUpdate
                Me.grpAddress.Enabled = True
                Me.txtAddress1.BackColor = SystemColors.Window
                Me.txtAddress2.BackColor = SystemColors.Window
                Me.txtCity.BackColor = SystemColors.Window
                Me.cboState.BackColor = SystemColors.Window
                Me.mskZip.BackColor = SystemColors.Window

                'For MaskEdBox control, must set prop. at runtime.  
                'Doesn't quite work if set using the designer.
                'Why? Because it's not a .NET component?
                Me.mskZip.DataBindings.Add("CtlText", Me.ds, "tbContactAddress.Zip") 'Must bind to "CtlText" property, NOT "Text"! 

            Else 'friends
                Me.grpName.Enabled = True
                Me.txtLastName.BackColor = SystemColors.Info
                Me.txtFirstName.BackColor = SystemColors.Info
                Me.txtWhoIsThis.BackColor = SystemColors.Info

            End If

            '''' Handle tbContact and tbContactAddress
            If vb.Left(Me.Text.ToString, 7) = "Editing" Then 'Edit if tbContact already has a record for his patient
                If vfrmPatient.txtHasContact.Text = "Y" Then 'Don't need this, should always Fill_tbContact()
                    Fill_tbContact()
                    FillCheckBoxes(Me, Me.ds.tbContact, "chk", 2)
                Else
                    AddNewTo_tbContact() 'Don't need this. There always exists a record in tbContact
                End If
                If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then 'Patient   
                    If vfrmPatient.txtHasAddress.Text = "Y" Then 'Don't need this, should always Fill_tbContactAddress()
                        Fill_tbContactAddress()
                    Else
                        AddNewTo_tbContactAddress() 'Don't need this. There always exists a record in tbContactAddress
                    End If
                End If

                '* FILL THE BEST TIME TO CONTACT
                Me.TbContactBestTimeTableAdapter.FillByPatientOwner(Me.ds.tbContactBestTime, PatID, ContactOwnerCd)
                If Me.ds.tbContactBestTime.Rows.Count = 0 Then
                    '* no best time is found in the db.
                    AddNewTo_tbBestTime()
                End If


            Else 'Adding
                AddNewTo_tbContact() 'tbContact applies to both patient and patient's other
                AddNewTo_tbBestTime()
                If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then 'Patient   
                    AddNewTo_tbContactAddress()
                End If
            End If

            '''' Handle tbContactPhone, tbContactEmail, tbContactOnline
            HandlePhoneEmailOnline()

            '''' Handle tbContactChoice
            Fill_lvwContactChoiceSelected()
            Fill_lvwContactChoiceAvailable()
            En_Disable_btnMoveUpDown(Me.lvwContactChoiceSelected, Me.btnMoveCtMthdUp, Me.btnMoveCtMthdDn)

        Catch ex As System.Exception
            MsgBox(ex.Message)
            Me.Close()
            vfrmPatCtsFrdEdit = Nothing
        End Try
    End Sub

    Private Sub Fill_tbContact()
        Dim conn As New OleDbConnection(strConn)
        da_tbContact_SelectComm.Connection = conn
        da_tbContact_SelectComm.CommandText = _
        "SELECT * FROM tbContact " & _
        "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd
        da_tbContact.Fill(ds.tbContact)
    End Sub
    Private Sub Fill_tbContactAddress()
        Dim conn As New OleDbConnection(strConn)
        da_tbContactAddress_SelectComm.Connection = conn
        da_tbContactAddress_SelectComm.CommandText = _
        "SELECT * FROM tbContactAddress " & _
        "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd
        da_tbContactAddress.Fill(ds.tbContactAddress)
    End Sub
    Private Sub AddNewTo_tbContact()
        Me.BindingContext(Me.ds, "tbContact").AddNew()
        Me.BindingContext(Me.ds, "tbContact").Position = 0
        With Me.ds.tbContact.Item(0)
            .PatientID = PatID
            .ContactOwnerCd = ContactOwnerCd
        End With
    End Sub
    Private Sub AddNewTo_tbBestTime()
        Try

            Dim MyBestTimeRow As tbContactBestTimeRow = Me.ds.tbContactBestTime.NewRow()
            MyBestTimeRow.PatientID = PatID
            MyBestTimeRow.ContactOwnerCd = ContactOwnerCd
            MyBestTimeRow.ChkMonday = False
            MyBestTimeRow.ChkTuesday = False
            MyBestTimeRow.ChkWednesday = False
            MyBestTimeRow.ChkThursday = False
            MyBestTimeRow.ChkFriday = False
            MyBestTimeRow.ChkSaturday = False
            MyBestTimeRow.ChkTime10to11 = False
            MyBestTimeRow.ChkTime12to1 = False
            MyBestTimeRow.ChkTime1to3 = False
            MyBestTimeRow.ChkTime3to5 = False
            MyBestTimeRow.ChkTime8to10 = False
            MyBestTimeRow.ChkTimeAfter5 = False
            MyBestTimeRow.ChkMornings = False
            MyBestTimeRow.ChkAfternoons = False
            MyBestTimeRow.ChkEvenings = False
            Me.ds.tbContactBestTime.Rows.Add(MyBestTimeRow)
            Me.TbContactBestTimeBindingSource.Position = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
    Private Sub AddNewTo_tbContactAddress()
        Me.BindingContext(Me.ds, "tbContactAddress").AddNew()
        Me.BindingContext(Me.ds, "tbContactAddress").Position = 0
        With Me.ds.tbContactAddress.Item(0)
            .PatientID = PatID
            .ContactOwnerCd = ContactOwnerCd
        End With
    End Sub
    Private Sub frmPatCtsFrdEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
        Tab1_Click(Nothing, Nothing)
    End Sub
    Private Sub Tab1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab1.Click
        Select Case Tab1.SelectedIndex
            Case 0
                If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then 'Patient
                    Me.txtAddress1.Focus()
                Else
                    Me.txtLastName.Focus()
                End If
            Case 1
                Me.txtSpecialRequests.Focus()
        End Select
    End Sub
    Private Sub frmPatCtsFrdEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmPatCtsFrdEdit = Nothing
    End Sub

    Private Sub da_tbContact_OnRowUpdate(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)

        'If vb.Left(Me.Text.ToString, 6) = "Adding" Then
        If e.StatementType = StatementType.Insert Then
            Dim oCmd As New OleDbCommand("SELECT @@IDENTITY")
            oCmd.Connection = conn
            e.Row("ContactID") = oCmd.ExecuteScalar()
            e.Row.AcceptChanges()
            'MsgBox(e.Row("VisitID"))
        End If

    End Sub

    Private Sub da_tbContactAddress_OnRowUpdate(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)

        'If vb.Left(Me.Text.ToString, 6) = "Adding" Then
        If e.StatementType = StatementType.Insert Then
            Dim oCmd As New OleDbCommand("SELECT @@IDENTITY")
            oCmd.Connection = conn
            e.Row("ContactAddressID") = oCmd.ExecuteScalar()
            e.Row.AcceptChanges()
            'MsgBox(e.Row("VisitID"))
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        'Exit Sub
        Try
            Dim resp As MsgBoxResult
            If vb.Left(Me.Text.ToString, 6) = "Adding" Then
                resp = MsgBox("Do you want to add " & ContactOwnerText & "'s contact info to the selected patient?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then
                    If ValidationPassed() Then
                        Save_tbContact()
                        If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then Save_tbContactAddress() 'patient only                                              
                        Save_tbBestTime()
                        CloseAndUpdate()
                    End If
                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            Else                
                resp = MsgBox("Do you want to save your changes?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then
                    If ValidationPassed() Then
                        Save_tbContact()
                        If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then Save_tbContactAddress() 'patient only                      
                        Save_tbBestTime()
                        CloseAndUpdate()
                    End If
                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If                
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function IsDirty() As Boolean

        'Exit Function

        IsDirty = False

        If vfrmPatient.txtHasContact.Text = "Y" Then 'Data exists
            Me.BindingContext(Me.ds.tbContact).EndCurrentEdit() 'need this to detect changes!!!
            Dim objChanges_Contact As DataTable = Me.ds.tbContact.GetChanges
            If (Not (objChanges_Contact) Is Nothing) Then
                'MsgBox("'tbContact' changed")
                IsDirty = True
                Exit Function
            End If
        Else
            'Newly added so only considered dirty if there is at least one field filled 
            If tbContact_SomeDataEntered() = True Then
                IsDirty = True
                Exit Function
            End If
        End If

        If ContactOwnerCd = 1 Or UCase(ContactOwnerText) = "PATIENT" Then
            If vfrmPatient.txtHasAddress.Text = "Y" Then 'Data exists
                Me.BindingContext(Me.ds.tbContactAddress).EndCurrentEdit() 'need this to detect changes!!!
                Dim objChanges_ContactAddress As DataTable = Me.ds.tbContactAddress.GetChanges
                If (Not (objChanges_ContactAddress) Is Nothing) Then
                    'MsgBox("'tbContactAddress' changed")
                    IsDirty = True
                    Exit Function
                End If
            Else
                'Newly added so only considered dirty if there is at least one field filled 
                If tbContactAddress_SomeDataEntered() = True Then
                    IsDirty = True
                    Exit Function
                End If
            End If
        End If

        If mskPhoneIsDirty Then
            IsDirty = True
            Exit Function
        End If

        If txtEmailIsDirty Then
            IsDirty = True
            Exit Function
        End If

        If OnlineFieldsAreDirty Then
            IsDirty = True
            Exit Function
        End If

        If lvwContactChoiceSelectedIsDirty Then
            IsDirty = True
            Exit Function
        End If

    End Function
    Private Function tbContact_SomeDataEntered() As Boolean

        'For Each col As DataColumn In Me.ds.tbContact.Columns
        'MsgBox(col.ColumnName)
        'Next

        tbContact_SomeDataEntered = False

        If Me.txtLastName.Text.Trim.Length > 0 Then
            tbContact_SomeDataEntered = True
            Exit Function
        End If

        If Me.txtFirstName.Text.Trim.Length > 0 Then
            tbContact_SomeDataEntered = True
            Exit Function
        End If

        If Me.chk1.Checked Then
            tbContact_SomeDataEntered = True
            Exit Function
        End If

        If Me.chk2.Checked Then
            tbContact_SomeDataEntered = True
            Exit Function
        End If

        Dim tab1_xSelectedIndex As Byte
        tab1_xSelectedIndex = Me.Tab1.SelectedIndex
        Me.Tab1.SelectedIndex = 1
        If Me.txtSpecialRequests.Text.Trim.Length > 0 Then
            tbContact_SomeDataEntered = True
            Me.Tab1.SelectedIndex = tab1_xSelectedIndex
            Exit Function
        End If
        Me.Tab1.SelectedIndex = tab1_xSelectedIndex

    End Function

    Private Function tbContactAddress_SomeDataEntered() As Boolean

        tbContactAddress_SomeDataEntered = False

        If Me.txtAddress1.Text.Trim.Length > 0 Then
            tbContactAddress_SomeDataEntered = True
            Exit Function
        End If

        If Me.txtAddress2.Text.Trim.Length > 0 Then
            tbContactAddress_SomeDataEntered = True
            Exit Function
        End If

        If Me.txtCity.Text.Trim.Length > 0 Then
            tbContactAddress_SomeDataEntered = True
            Exit Function
        End If

        If Me.cboState.Text.Trim.Length > 0 Then
            tbContactAddress_SomeDataEntered = True
            Exit Function
        End If

        If Me.mskZip.Text.Trim.Length > 0 Then
            tbContactAddress_SomeDataEntered = True
            Exit Function
        End If

    End Function

    Private Sub Save_tbContact()

        Try
            If vfrmPatient.txtHasContact.Text <> "Y" Then 'New entry so add
                If tbContact_SomeDataEntered() = True Then 'Don't save if nothing has been put on at least one field
                    Me.BindingContext(Me.ds.tbContact).EndCurrentEdit()
                    UpdateDataSourceAddNew(Me.ds, "tbContact", conn, Me.da_tbContact)
                End If
            Else 'Existing entry so update
                If tbContact_SomeDataEntered() = True Then 'Update if there's some data
                    Me.BindingContext(Me.ds.tbContact).EndCurrentEdit()
                    'Dim objChanges_Contact As DataSet1 = New DataSet1
                    'objChanges_Contact = CType(Me.ds.GetChanges, DataSet1)
                    Dim objChanges_Contact As DataTable = Me.ds.tbContact.GetChanges
                    If (Not (objChanges_Contact) Is Nothing) Then
                        UpdateDataSourceTable(objChanges_Contact, conn, Me.da_tbContact)
                    End If
                Else 'Delete the whole row if all fields are empty
                    'MsgBox(Me.ds.tbContact.Rows.Count)
                    'For Each dr As DataRow In Me.ds.tbContact.Rows
                    'dr.Delete()
                    'Next
                    'Me.ds.tbContact.AcceptChanges()
                    RunSQL("DELETE * FROM tbContact " & _
                           "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd)
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Save_tbContactAddress()

        Try
            If vfrmPatient.txtHasAddress.Text <> "Y" Then 'New entry so add
                If tbContactAddress_SomeDataEntered() = True Then 'Don't save if nothing has been put on at least one field
                    Me.BindingContext(Me.ds.tbContactAddress).EndCurrentEdit()
                    UpdateDataSourceAddNew(Me.ds, "tbContactAddress", conn, Me.da_tbContactAddress)
                End If
            Else 'Existing entry so update
                If tbContactAddress_SomeDataEntered() = True Then 'Update if there's some data
                    Me.BindingContext(Me.ds.tbContactAddress).EndCurrentEdit()
                    'Dim objChanges_ContactAddress As DataSet1 = New DataSet1
                    'objChanges_ContactAddress = CType(Me.ds.GetChanges, DataSet1)
                    Dim objChanges_ContactAddress As DataTable = Me.ds.tbContactAddress.GetChanges
                    If (Not (objChanges_ContactAddress) Is Nothing) Then
                        UpdateDataSourceTable(objChanges_ContactAddress, conn, Me.da_tbContactAddress)
                    End If
                Else 'Delete the whole row if all fields are empty
                    RunSQL("DELETE * FROM tbContactAddress " & _
                           "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd)
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub    
    Private Sub Save_tbBestTime()
        Try
            Me.TbContactBestTimeBindingSource.EndEdit()
            Me.TbContactBestTimeTableAdapter.Update(Me.ds.tbContactBestTime)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Friend Sub UpdateDataSourceTable(ByVal ChangedRows As DataTable, _
                                ByVal conn As OleDbConnection, _
                                ByVal adapter As OleDbDataAdapter)

        'Dim conn As New OleDbConnection(strConn)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'conn.ConnectionString = strConn
                conn.Open()
                With adapter
                    .UpdateCommand.Connection = conn
                    .Update(ChangedRows)
                End With
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Function ValidationPassed() As Boolean

        ValidationPassed = True

        If ContactOwnerCd > 1 Then 'Patient's other contacts
            If Me.txtLastName.Text.Trim.Length = 0 Then
                MsgBox("'Last Name' is required.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information)
                Me.Tab1.SelectedIndex = 0
                Me.txtLastName.Focus()
                Return False
                Exit Function
            End If

            If Me.txtFirstName.Text.Trim.Length = 0 Then
                MsgBox("'First Name' is required.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information)
                Me.Tab1.SelectedIndex = 0
                Me.txtFirstName.Focus()
                Return False
                Exit Function
            End If
        End If

    End Function

    Private Sub CloseAndUpdate()

        Cursor.Current = Cursors.WaitCursor

        If mskPhoneIsDirty Then Update_tbContactPhone()
        If txtEmailIsDirty Then Update_tbContactEmail()
        If OnlineFieldsAreDirty Then Update_tbContactOnline()
        If lvwContactChoiceSelectedIsDirty Then Update_tbContactChoice()

        Me.Close()
        With vfrmPatient
            .Update_tabCts()
        End With

        Cursor.Current = Cursors.Default

    End Sub
    Private Sub Update_tbContactPhone()

        Try

            RunSQL("DELETE * FROM tbContactPhone " & _
                   "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd)

            For Each itm As ListViewItem In Me.lvwPhone.Items
                If GetNumberPart(itm.SubItems(1).Text).Length > 0 Or itm.SubItems(2).Text.Length > 0 Then
                    RunSQL("INSERT INTO tbContactPhone " & _
                          "(PatientID, ContactOwnerCd, PhoneTypeCd, PhoneNumber, PhoneNumberOwner, LastEditDate) " & _
                           "VALUES (" & PatID & ", " & _
                                        ContactOwnerCd & ", " & _
                                        itm.SubItems(3).Text & ", '" & _
                                        itm.SubItems(1).Text & "', '" & _
                                        itm.SubItems(2).Text & "', NOW)")
                End If
            Next

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Update_tbContactEmail()

        Try

            RunSQL("DELETE * FROM tbContactEmail " & _
                   "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd)
            Dim strEmailAddress As String
            For Each itm As ListViewItem In Me.lvwEmail.Items
                strEmailAddress = itm.SubItems(1).Text.Trim
                If strEmailAddress.Length > 0 Then
                    strEmailAddress = Replace(strEmailAddress, Chr(34), "''")
                    RunSQL("INSERT INTO tbContactEmail " & _
                          "(PatientID, ContactOwnerCd, EmailTypeCd, EmailAddress, LastEditDate) " & _
                           "VALUES (" & PatID & ", " & _
                                        ContactOwnerCd & ", " & _
                                        itm.SubItems(2).Text & ", " & _
                                        Chr(34) & strEmailAddress & Chr(34) & ", NOW)")
                End If
            Next

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Update_tbContactOnline()

        'Exit Sub

        Try

            RunSQL("DELETE * FROM tbContactOnline " & _
                   "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd)

            Dim strSQL As String
            Dim strOnlineName As String, strDisplayName As String, strOnlineEmail As String, strOnlineURL As String
            For Each itm As ListViewItem In Me.lvwOnline.Items

                'strDisplayName = Replace(Me.txtOnlineDispName.Rtf, Microsoft.VisualBasic.ControlChars.NewLine, " ")
                'strDisplayName = Replace(strDisplayName, Microsoft.VisualBasic.ControlChars.Cr, "")
                'strDisplayName = Replace(strDisplayName, Microsoft.VisualBasic.ControlChars.CrLf, "")
                'strDisplayName = Replace(strDisplayName, Microsoft.VisualBasic.ControlChars.Lf, "")

                strOnlineName = itm.SubItems(1).Text.Trim
                If itm.SubItems(2).Text.Trim.Length > 0 Then
                    'strDisplayName = Replace(itm.SubItems(2).Text, Microsoft.VisualBasic.ControlChars.NewLine, " ")
                    'strDisplayName = vb.Left(strDisplayName, Len(strDisplayName) - 1)
                    strDisplayName = vb.Left(itm.SubItems(2).Text, Len(itm.SubItems(2).Text) - 1) 'must backward 1 char, otherwise won't work. weird!!!
                Else
                    strDisplayName = ""
                End If
                strOnlineEmail = itm.SubItems(3).Text.Trim
                strOnlineURL = itm.SubItems(4).Text.Trim

                'Replace double quotes with two single quotes
                If strOnlineName.Length > 0 Then strOnlineName = Replace(strOnlineName, Chr(34), "''")
                If strDisplayName.Length > 0 Then strDisplayName = Replace(strDisplayName, Chr(34), "''")
                If strOnlineEmail.Length > 0 Then strOnlineEmail = Replace(strOnlineEmail, Chr(34), "''")
                If strOnlineURL.Length > 0 Then strOnlineURL = Replace(strOnlineURL, Chr(34), "''")

                If strOnlineName.Length + strDisplayName.Length + strOnlineEmail.Length + strOnlineURL.Length > 0 Then

                    strSQL = "INSERT INTO tbContactOnline " & _
                          "(PatientID, ContactOwnerCd, OnlineTypeCd, " & _
                           "OnlineName, OnlineDisplayName, OnlineEmail, OnlineURL, LastEditDate) " & _
                           "VALUES (" & PatID & ", " & _
                                        ContactOwnerCd & ", " & _
                                        itm.SubItems(5).Text & ", " & _
                                        Chr(34) & strOnlineName & Chr(34) & ", " & _
                                        Chr(34) & strDisplayName & Chr(34) & ", " & _
                                        Chr(34) & strOnlineEmail & Chr(34) & ", " & _
                                        Chr(34) & strOnlineURL & Chr(34) & ", NOW)"
                    'Chr(39) is single quote ' Chr(34) for double quote
                    'But cannot use single quote in SQL because richtextbox's rtf might use it!!!
                    'Console.WriteLine(strSQL)
                    RunSQL(strSQL)
                End If
            Next

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Update_tbContactChoice()

        Try

            RunSQL("DELETE * FROM tbContactChoice " & _
                   "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd)

            For Each itm As ListViewItem In Me.lvwContactChoiceSelected.Items
                RunSQL("INSERT INTO tbContactChoice " & _
                      "(PatientID, ContactOwnerCd, ContactChoice, ContactMethodCd, LastEditDate) " & _
                       "VALUES (" & PatID & ", " & _
                                    ContactOwnerCd & ", " & _
                                    itm.SubItems(1).Text & ", " & _
                                    itm.SubItems(2).Text & ", NOW)")
            Next

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Fill_lvwContactChoiceSelected()

        Dim strSQL As String

        strSQL = "SELECT ContactMethodDesc, ContactChoice, tbContactChoice.ContactMethodCd " & _
                 "FROM tbContactChoice LEFT JOIN ddvContactMethod " & _
                      "ON tbContactChoice.ContactMethodCd = ddvContactMethod.ContactMethodCd " & _
                 "WHERE tbContactChoice.ContactOwnerCd=" & ContactOwnerCd & " AND " & _
                       "PatientID=" & PatID & _
                " ORDER BY ContactChoice"
        'Fill_lvw(Me.lvwContactChoiceSelected, strSQL, , , True)

        With vfrmPatient.lvwCiContactChoice
            For i As Short = 0 To .Items.Count - 1
                Dim itm As New ListViewItem
                itm.Text = .Items(i).SubItems(1).Text
                itm.Checked = True
                itm.SubItems.Add(.Items(i).Text)
                itm.SubItems.Add(.Items(i).SubItems(2).Text)
                Me.lvwContactChoiceSelected.Items.Add(itm)
            Next
        End With

    End Sub

    Private Sub Fill_lvwContactChoiceAvailable()

        Dim strSQL As String = _
            "SELECT ContactMethodDesc, ContactMethodCd " & _
            "FROM ddvContactMethod " & _
            "WHERE Active<0 AND ContactOwnerCd=" & ContactOwnerCd
        If lvwContactChoiceSelected.Items.Count > 0 Then
            strSQL = strSQL & " AND " & _
                       "ContactMethodCd Not In (" & LvwItems(lvwContactChoiceSelected, 2, False) & ")"
        End If
        Fill_lvw(Me.lvwContactChoiceAvailable, strSQL)

    End Sub

    Private Sub lvw_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvwContactChoiceSelected.ItemCheck, lvwContactChoiceAvailable.ItemCheck
        Try
            If FormActivated Then
                Select Case sender.name
                    Case "lvwContactChoiceAvailable"
                        If Me.ActiveControl.Name = "lvwContactChoiceAvailable" Then
                            'LvwMoveOne(lvwContactChoiceAvailable, lvwContactChoiceSelected)
                            With Me.lvwContactChoiceAvailable
                                If .Items.Count = 0 Then
                                    MsgBox("Sorry, There are NO items in the list!", vbOKOnly + vbInformation)
                                    Exit Sub
                                End If

                                '.Items(e.Index).Selected = True 'need this!
                                'If .SelectedItems.Count > 0 Then
                                'Dim item As ListViewItem = .SelectedItems(0)
                                Dim item As ListViewItem = lvwContactChoiceAvailable.Items(e.Index)

                                Dim newItem As New ListViewItem
                                With newItem
                                    .Text = item.Text
                                    .Checked = True
                                    .SubItems.Add(lvwContactChoiceSelected.Items.Count + 1)
                                    .SubItems.Add(item.SubItems(1).Text)
                                    .Selected = True
                                End With

                                With lvwContactChoiceSelected
                                    .Items.Add(newItem)
                                    '.Items(.Items.Count - 1).Selected = True
                                End With

                                'Then remove the item from this list.                                
                                'lvwContactChoiceAvailable.Items.RemoveAt(item.Index)                                
                                lvw_ItemCheck2()
                            End With
                        End If
                    Case "lvwContactChoiceSelected"
                        If Me.ActiveControl.Name = "lvwContactChoiceSelected" Then
                            With Me.lvwContactChoiceSelected
                                If .Items.Count = 0 Then
                                    MsgBox("Sorry, There are NO items in the list!", vbOKOnly + vbInformation)
                                    Exit Sub
                                End If
                                .Items(e.Index).Selected = True 'need this!
                                Dim item As ListViewItem = .SelectedItems(0)
                                Dim newItem As New ListViewItem
                                With newItem
                                    .Text = item.Text
                                    .SubItems.Add(item.SubItems(2).Text)
                                End With
                                lvwContactChoiceAvailable.Items.Add(newItem)

                                'Then remove the item from this list.
                                Dim RemovedItemIndex As Integer = item.Index
                                item.Remove()

                                For i As Short = 0 To .Items.Count - 1 'Assign new order
                                    .Items(i).SubItems(1).Text = i + 1
                                    'MsgBox(.Items(i).SubItems(1).Text)
                                Next

                                lvw_ItemCheck2()
                            End With
                        End If
                End Select

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lvw_ItemCheck2()
        lvwContactChoiceSelectedIsDirty = True
        'ShowTotalOnLvw(lvwContactChoiceAvailable, 0)
        'ShowTotalOnLvw(lvwContactChoiceSelected, 0)
        En_Disable_btnMoveUpDown(Me.lvwContactChoiceSelected, Me.btnMoveCtMthdUp, Me.btnMoveCtMthdDn)
    End Sub

    Private Sub btnUpDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles btnMoveCtMthdUp.Click, btnMoveCtMthdDn.Click

        Dim MoveDirection As Short
        If sender.name = "btnMoveCtMthdUp" Then
            MoveDirection = -1
        Else
            MoveDirection = 1
        End If
        MoveListViewItem(lvwContactChoiceSelected, MoveDirection)
        En_Disable_btnMoveUpDown(lvwContactChoiceSelected, Me.btnMoveCtMthdUp, Me.btnMoveCtMthdDn)
        lvwContactChoiceSelectedIsDirty = True

    End Sub

    Private Sub lvwContactChoiceSelected_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwContactChoiceSelected.Click
        En_Disable_btnMoveUpDown(Me.lvwContactChoiceSelected, Me.btnMoveCtMthdUp, Me.btnMoveCtMthdDn)
    End Sub

    Private Sub lvwContactChoiceSelected_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwContactChoiceSelected.KeyUp
        lvwContactChoiceSelected_Click(sender, e)
    End Sub

    Private Sub chk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk1.Click, chk2.Click
        If FormActivated Then
            With Me.ds.tbContact.Item(0)
                Select Case sender.name
                    Case "chk1"
                        .CanMailReminder = chk1.Checked
                    Case "chk2"
                        .CanTextMessage = chk2.Checked
                End Select
            End With
        End If
    End Sub
    Private Sub cboState_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboState.SelectedValueChanged
        If FormActivated Then
            Me.ds.tbContactAddress.Item(0).State = cboState.Text
        End If
    End Sub





    Private Sub HandlePhoneEmailOnline()

        Try

            Dim strSQL As String

            ''''Fill lvwPhone

            'Need this to decide which online fields to show/hide
            strSQL = "SELECT PhoneTypeDesc, FieldName " & _
                     "FROM trefPhoneTypeCd_FieldName LEFT JOIN ddvPhoneType ON trefPhoneTypeCd_FieldName.PhoneTypeCd = ddvPhoneType.PhoneTypeCd " & _
                     "WHERE trefPhoneTypeCd_FieldName.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & _
                    " ORDER BY PhoneTypeDesc, trefPhoneTypeCd_FieldName.DisplayOrder"
            Fill_lvw(lvwPhoneTypeCd_FieldName, strSQL, , False)

            'If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            strSQL = "SELECT PhoneTypeDesc, Q.PhoneNumber, Q.PhoneNumberOwner, ddvPhoneType.PhoneTypeCd " & _
                     "FROM ddvPhoneType LEFT JOIN " & _
                          "(SELECT PhoneTypeCd, PhoneNumber, PhoneNumberOwner " & _
                           "FROM tbContactPhone " & _
                           "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                           "ON ddvPhoneType.PhoneTypeCd = Q.PhoneTypeCd " & _
                     "WHERE ddvPhoneType.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & _
                    " ORDER BY DisplayOrder"
            'Console.WriteLine(strSQL)
            'Else
            'strSQL = "SELECT PhoneTypeDesc, '' AS PhoneNumber FROM ddvPhoneType WHERE Active<0 ORDER BY DisplayOrder"
            'End If
            Fill_lvw(Me.lvwPhone, strSQL, , False)
            'Extract number and format phone #
            Dim itm As ListViewItem
            For Each itm In Me.lvwPhone.Items
                itm.SubItems(1).Text = FormatPhoneNumber(itm.SubItems(1).Text)
            Next
            'Fill cboPhone       
            FillCboFromLvw(Me.cboPhone, Me.lvwPhone, 1, True)
            Me.cboPhone.SelectedIndex = 0
            Synch_mskPhone_with_cboPhone()
            HideShowPhoneFields()

            ''''Fill lvwEmail
            'If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            strSQL = "SELECT EmailTypeDesc, Q.EmailAddress, ddvEmailType.EmailTypeCd " & _
                     "FROM ddvEmailType LEFT JOIN " & _
                          "(SELECT EmailTypeCd, EmailAddress " & _
                           "FROM tbContactEmail " & _
                           "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                           "ON ddvEmailType.EmailTypeCd = Q.EmailTypeCd " & _
                     "WHERE ddvEmailType.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & _
                    " ORDER BY DisplayOrder"
            'Else
            'strSQL = "SELECT EmailTypeDesc, '' AS EmailAddress FROM ddvEmailType WHERE Active<0 ORDER BY DisplayOrder"
            'End If
            Fill_lvw(Me.lvwEmail, strSQL, , False)
            'Fill cboEmail        
            FillCboFromLvw(Me.cboEmail, Me.lvwEmail, 1)
            Me.cboEmail.SelectedIndex = 0
            Synch_txtEmail_with_cboEmail()

            ''''Fill lvwOnline
            'Need this to decide which online fields to show/hide
            strSQL = "SELECT OnlineTypeDesc, FieldName " & _
                     "FROM trefOnlineTypeCd_FieldName LEFT JOIN ddvOnlineType ON trefOnlineTypeCd_FieldName.OnlineTypeCd = ddvOnlineType.OnlineTypeCd " & _
                     "WHERE trefOnlineTypeCd_FieldName.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & _
                    " ORDER BY OnlineTypeDesc, trefOnlineTypeCd_FieldName.DisplayOrder"
            Fill_lvw(lvwOnlineTypeCd_FieldName, strSQL, , False)

            'If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            strSQL = "SELECT OnlineTypeDesc, OnlineName, OnlineDisplayName, OnlineEmail, OnlineURL, ddvOnlineType.OnlineTypeCd " & _
                     "FROM ddvOnlineType LEFT JOIN " & _
                          "(SELECT OnlineTypeCd, OnlineName, OnlineDisplayName, OnlineEmail, OnlineURL " & _
                           "FROM tbContactOnline " & _
                           "WHERE PatientID=" & PatID & " AND ContactOwnerCd=" & ContactOwnerCd & ") AS Q " & _
                           "ON ddvOnlineType.OnlineTypeCd = Q.OnlineTypeCd " & _
                     "WHERE ddvOnlineType.Active<0 AND ContactOwnerCd=" & ContactOwnerCd & _
                    " ORDER BY DisplayOrder"
            'Console.WriteLine(strSQL)
            'Else
            'strSQL = "SELECT OnlineTypeDesc, '' AS OnlineName, '' AS OnlineDisplayName, '' AS OnlineEmail, '' AS OnlineURL " & _
            '"FROM ddvPhoneType WHERE Active<0 ORDER BY DisplayOrder"
            'End If
            Fill_lvw(Me.lvwOnline, strSQL, , False)
            'Fill cboOnline    
            FillCboFromLvwOnline()
            Me.cboOnline.SelectedIndex = 0
            Synch_OnlineFields_with_cboOnline()
            HideShowOnlineFields()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FillCboFromLvw(ByVal cbo As ComboBox, ByVal lvw As ListView, ByVal DataValueColumn As Byte, Optional ByVal CheckNumericOnly As Boolean = False)

        Try

            With lvw
                cbo.Items.Clear()
                Dim itm As ListViewItem
                Dim Prefix As String
                Dim TextToCheckForBlank As String
                'Dim DataValue As String
                For Each itm In .Items
                    If CheckNumericOnly Then
                        TextToCheckForBlank = GetNumberPart(itm.SubItems(DataValueColumn).Text.Trim)
                    Else
                        TextToCheckForBlank = itm.SubItems(DataValueColumn).Text.Trim
                    End If
                    If TextToCheckForBlank.Length > 0 Then 'If the value is not blank
                        Prefix = "*" & Space(1) ' "* "
                        'DataValue = itm.SubItems(DataValueColumn).Text.Trim
                    Else
                        Prefix = Space(3)  ' "   "
                        'DataValue = ""
                    End If
                    'The following doesn't work very well, always generates an error 'not a valid value for index!!!!
                    ''cbo.Items.Add(New ValueDescriptionPair(itm.SubItems(.Items.Count - 1).Text, itm.Text & ": " & DataValue))
                    'cbo.Items.Add(New ValueDescriptionPair(itm.SubItems(.Items.Count - 1).Text, Prefix & itm.Text))

                    cbo.Items.Add(Prefix & itm.Text)
                Next
                cbo.MaxDropDownItems = .Items.Count
            End With

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FillCboFromLvwOnline()

        Try

            With lvwOnline
                cboOnline.Items.Clear()
                Dim itm As ListViewItem
                Dim Prefix As String
                For Each itm In .Items
                    Prefix = Space(3)
                    For i As Short = 1 To 4
                        If itm.SubItems(i).Text.Trim.Length > 0 Then
                            Prefix = "*" & Space(1)
                            Exit For
                        End If
                    Next
                    cboOnline.Items.Add(Prefix & itm.Text)
                Next
                cboOnline.MaxDropDownItems = .Items.Count
            End With

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    '************** Phone **************************

    Private Sub mskPhone_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskPhone.TextChanged
        If FormActivated Then
            If Me.ActiveControl.Name = "mskPhone" Then
                'Dim tempPhone As String
                'tempPhone = Replace(Me.mskPhone.CtlText, "(", "")
                'tempPhone = Replace(tempPhone, ")", "")
                'tempPhone = Replace(tempPhone, "-", "")
                'tempPhone = Replace(tempPhone, "_", "")
                Me.lvwPhone.Items(Me.cboPhone.SelectedIndex).SubItems(1).Text = mskPhone.Text 'mskPhone.ClipText  ' tempPhone
                Synch_cboPhone_with_mskPhone()
                mskPhoneIsDirty = True
            End If
        End If
    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoneNumberOwner.TextChanged

        If FormActivated Then
            If Me.ActiveControl.Name = "txtPhoneNumberOwner" Then
                Me.lvwPhone.Items(Me.cboPhone.SelectedIndex).SubItems(2).Text = txtPhoneNumberOwner.Text
                'Synch_cboPhone_with_mskPhone()
                mskPhoneIsDirty = True
            End If
        End If
    End Sub
    Private Sub Synch_cboPhone_with_mskPhone()
        cboPhoneOldSelectedIndex = Me.cboPhone.SelectedIndex
        FillCboFromLvw(Me.cboPhone, Me.lvwPhone, 1, True)
        Me.cboPhone.SelectedIndex = cboPhoneOldSelectedIndex
    End Sub
    Private Sub Synch_mskPhone_with_cboPhone()
        Try
            With Me.mskPhone
                If Me.lvwPhone.Items(Me.cboPhone.SelectedIndex).SubItems(1).Text.Length > 0 Then
                    .Text = Me.lvwPhone.Items(Me.cboPhone.SelectedIndex).SubItems(1).Text
                    Me.txtPhoneNumberOwner.Text = Me.lvwPhone.Items(Me.cboPhone.SelectedIndex).SubItems(2).Text
                Else
                    .Text = "" 'Then empty it
                End If
                'Me.lvwPhone.Items(Me.cboPhone.SelectedIndex).BackColor = Color.Gray
            End With
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mskPhone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskPhone.GotFocus

        'With mskPhone
        '    If .ClipText.Length > 0 Then 'text with literal characters excluded
        '        Select Case .ClipText.Length
        '            Case Is <= 3
        '                .SelStart = .ClipText.Length
        '            Case 4 To 6
        '                .SelStart = .ClipText.Length + 1 '+1 for 1 hyphen
        '            Case 7 To 10
        '                .SelStart = .ClipText.Length + 2 '+2 for 2 hyphens
        '            Case 11 To 15
        '                .SelStart = .ClipText.Length + 3 '+3 for 2 hyphens and the x
        '        End Select
        '    Else
        '        .SelStart = 0
        '    End If
        'End With
    End Sub
    Private Sub HideShowPhoneFields()
        Try
            txtPhoneNumberOwner.Enabled = False : txtPhoneNumberOwner.BackColor = SystemColors.Control
            'Me.lblPhoneNumberOwner.BackColor = SystemColors.Control

            Dim itm As ListViewItem, FieldName As String, txt As TextBox
            For Each itm In Me.lvwPhoneTypeCd_FieldName.Items
                If itm.Text = Me.lvwPhone.Items(Me.cboPhone.SelectedIndex).Text Then
                    FieldName = "txt" & itm.SubItems(1).Text
                    'MsgBox(FieldName)                  
                    txt = CType(FindControl(Me, FieldName), TextBox)
                    txt.Enabled = True
                    txt.BackColor = SystemColors.Window
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    '************** Email **************************

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

        'Dim lvw As ListView = CType(FindControl(Me, sender.name), ListView)

        If FormActivated Then
            Select Case Me.ActiveControl.Name
                Case "txtEmail"
                    Me.lvwEmail.Items(Me.cboEmail.SelectedIndex).SubItems(1).Text = txtEmail.Text.Trim
                    Synch_cboEmail_with_txtEmail()
                    txtEmailIsDirty = True
            End Select
        End If

    End Sub
    Private Sub txtEmail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        If txtEmail.Text.Trim.Length > 0 Then
            If Not ValidEmailAddress(txtEmail.Text) Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub Synch_cboEmail_with_txtEmail()
        cboEmailOldSelectedIndex = Me.cboEmail.SelectedIndex
        FillCboFromLvw(Me.cboEmail, Me.lvwEmail, 1)
        Me.cboEmail.SelectedIndex = cboEmailOldSelectedIndex
    End Sub
    Private Sub Synch_txtEmail_with_cboEmail()
        'Dim cboEmailValueSelected As Short = CType(cboEmail.SelectedItem, ValueDescriptionPair).Value
        'Me.txtEmail.Text = FindLvwItem(Me.lvwEmail, cboEmailValueSelected, 2, 1)
        Me.txtEmail.Text = Me.lvwEmail.Items(Me.cboEmail.SelectedIndex).SubItems(1).Text
    End Sub
    Private Sub txtEmail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
        With txtEmail
            .SelectionStart() = .Text.Length
            .SelectionLength = .Text.Length
        End With
    End Sub


    '************** Online **************************

    Private Sub txtOnline_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles txtOnlineName.TextChanged, txtOnlineDispName.TextChanged, txtOnlineEmail.TextChanged, txtOnlineURL.TextChanged
        Dim i As Byte = Me.cboOnline.SelectedIndex
        If FormActivated Then
            With Me.lvwOnline.Items(i)
                Select Case Me.ActiveControl.Name
                    Case "txtOnlineName"
                        .SubItems(1).Text = txtOnlineName.Text.Trim
                    Case "txtOnlineDispName"
                        If txtOnlineDispName.Text.Trim.Length > 0 Then
                            .SubItems(2).Text = txtOnlineDispName.Rtf
                        Else
                            .SubItems(2).Text = ""
                        End If
                    Case "txtOnlineEmail"
                        .SubItems(3).Text = txtOnlineEmail.Text.Trim
                    Case "txtOnlineURL"
                        .SubItems(4).Text = txtOnlineURL.Text.Trim
                    Case "txtOnlineName", "txtOnlineDispName", "txtOnlineEmail", "txtOnlineURL"
                        Synch_cboOnline_with_OnlineFields()
                        OnlineFieldsAreDirty = True
                End Select
                Select Case Me.ActiveControl.Name
                    Case "txtOnlineName", "txtOnlineDispName", "txtOnlineEmail", "txtOnlineURL"
                        Synch_cboOnline_with_OnlineFields()
                        OnlineFieldsAreDirty = True
                End Select
            End With
        End If
    End Sub
    Private Sub txtOnlineEmail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtOnlineEmail.Validating
        If txtOnlineEmail.Text.Trim.Length > 0 Then
            If Not ValidEmailAddress(txtOnlineEmail.Text) Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub Synch_cboOnline_with_OnlineFields()
        cboOnlineOldSelectedIndex = Me.cboOnline.SelectedIndex
        FillCboFromLvwOnline()
        Me.cboOnline.SelectedIndex = cboOnlineOldSelectedIndex
    End Sub
    Private Sub Synch_OnlineFields_with_cboOnline()
        Dim i As Byte = Me.cboOnline.SelectedIndex
        With Me.lvwOnline
            txtOnlineName.Text = .Items(i).SubItems(1).Text
            txtOnlineDispName.Rtf = .Items(i).SubItems(2).Text
            txtOnlineEmail.Text = .Items(i).SubItems(3).Text
            txtOnlineURL.Text = .Items(i).SubItems(4).Text
        End With
    End Sub
    Private Sub OnlineFields_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles txtOnlineName.GotFocus, txtOnlineEmail.GotFocus, txtOnlineURL.GotFocus
        Dim txt As TextBox = CType(FindControl(Me, sender.name), TextBox)
        With txt
            .SelectionStart() = .Text.Length
            .SelectionLength = .Text.Length
        End With
    End Sub
    Private Sub HideShowOnlineFields()
        Try
            txtOnlineName.Enabled = False : txtOnlineName.BackColor = SystemColors.Control
            txtOnlineDispName.Enabled = False
            txtOnlineEmail.Enabled = False : txtOnlineEmail.BackColor = SystemColors.Control
            txtOnlineURL.Enabled = False : txtOnlineURL.BackColor = SystemColors.Control
            Dim itm As ListViewItem, FieldName As String, txt As TextBox
            For Each itm In Me.lvwOnlineTypeCd_FieldName.Items
                If itm.Text = Me.lvwOnline.Items(Me.cboOnline.SelectedIndex).Text Then
                    FieldName = "txt" & itm.SubItems(1).Text
                    'MsgBox(FieldName)
                    If UCase(vb.Right(FieldName, 11)) = "DISPLAYNAME" Then
                        txtOnlineDispName.Enabled = True
                    Else
                        txt = CType(FindControl(Me, FieldName), TextBox)
                        txt.Enabled = True
                        txt.BackColor = SystemColors.Window
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    '************** Shared by Phone, Email, Online **************************

    Private Sub cbo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles cboPhone.SelectedValueChanged, cboEmail.SelectedValueChanged, cboOnline.SelectedValueChanged
        If FormActivated Then
            Select Case Me.ActiveControl.Name
                Case "cboPhone"
                    Synch_mskPhone_with_cboPhone()
                    HideShowPhoneFields()
                    Me.mskPhone.Focus()

                    Me.lvwPhone.Items(Me.cboPhone.SelectedIndex).Selected = True

                Case "cboEmail"
                    Synch_txtEmail_with_cboEmail()
                    Me.txtEmail.Focus()

                    Me.lvwEmail.Items(Me.cboEmail.SelectedIndex).Selected = True

                Case "cboOnline"
                    Synch_OnlineFields_with_cboOnline()
                    HideShowOnlineFields()
                    Me.txtOnlineName.Focus()
            End Select
        End If
    End Sub


    '************** lvw **************************

    Private Sub btnShowlvw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles btnShowlvwPhone.Click, btnShowlvwEmail.Click
        Dim lvwName As String = vb.Right(sender.name, vb.Len(sender.name) - 7) 'btnShow is 7 chr long
        Dim lvw As ListView = CType(FindControl(Me, lvwName), ListView)
        With lvw
            .Height = .Items.Count * 17
            .Visible = (Not .Visible)
        End With
    End Sub
    Private Sub lvw_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles lvwPhone.VisibleChanged, lvwEmail.VisibleChanged
        If FormActivated Then
            Dim lvw As ListView = CType(FindControl(Me, sender.name), ListView)
            Dim btnShow As Button = CType(FindControl(Me, "btnShow" & sender.name), Button)
            Dim TipText As String, lvwToHide As ListView

            Select Case sender.name
                Case "lvwPhone"
                    TipText = " all phone numbers."
                    lvwToHide = Me.lvwEmail
                Case "lvwEmail"
                    TipText = " all email addresses."
                    lvwToHide = Me.lvwPhone
            End Select
            With btnShow
                If lvw.Visible = False Then
                    .ImageIndex = 3 'open
                    Me.ToolTip1.SetToolTip(btnShow, "Show" & TipText)
                Else
                    .ImageIndex = 4 'Close
                    Me.ToolTip1.SetToolTip(btnShow, "Hide" & TipText)
                    lvwToHide.Visible = False
                End If
                lvw.Focus()
            End With
        End If
    End Sub
    Private Sub lvw_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles lvwPhone.Click, lvwEmail.Click
        Dim cboName As String = "cbo" & vb.Right(sender.name, vb.Len(sender.name) - 3) 'lvw is 3 chr long
        Dim cbo As ComboBox = CType(FindControl(Me, cboName), ComboBox)
        Dim lvw As ListView = CType(FindControl(Me, sender.name), ListView)
        'Synch the combox with the listview
        cbo.SelectedIndex = lvw.SelectedItems(0).Index
        Select Case sender.name
            Case "lvwPhone"
                Synch_mskPhone_with_cboPhone()
                HideShowPhoneFields()
                'Me.mskPhone.Focus()
            Case "lvwEmail"
                Synch_txtEmail_with_cboEmail()
                'Me.txtEmail.Focus()
        End Select
    End Sub
    Private Sub lvw_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
      Handles lvwPhone.KeyUp, lvwEmail.KeyUp
        lvw_Click(sender, e)
    End Sub



    Private Sub tbDispName_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbDispName.ButtonClick
        Try
            Select Case tbDispName.Buttons.IndexOf(e.Button)
                Case 0
                    Dim X = Shell("C:\Program Files\Microsoft Office\Office10\WINWORD.EXE", AppWinStyle.NormalFocus)
                Case 1
                    Me.txtOnlineDispName.Undo()
                Case 2
                    Me.txtOnlineDispName.Redo()
            End Select
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
End Class
