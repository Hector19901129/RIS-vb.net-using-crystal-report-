Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb

Public Class frmStuHpvCtHxEdit
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
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dts1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLastEditDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboContactMethod As System.Windows.Forms.ComboBox
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents da1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents da1SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents txtVisitID As System.Windows.Forms.TextBox
    Friend WithEvents txtContactID As System.Windows.Forms.TextBox
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents da2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents da2SelectComm As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStuHpvCtHxEdit))
        Me.ds = New RIS.DataSet1
        Me.btnExit = New System.Windows.Forms.Button
        Me.da1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.da1SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dts1 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLastEditDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtVisitID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtContactID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboContactMethod = New System.Windows.Forms.ComboBox
        Me.da2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.da2SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 1
        Me.btnExit.Location = New System.Drawing.Point(356, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 20)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'da1
        '
        Me.da1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.da1.InsertCommand = Me.OleDbInsertCommand1
        Me.da1.SelectCommand = Me.da1SelectComm
        Me.da1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbStuHpvPatVisitContactHx", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ContactDate", "ContactDate"), New System.Data.Common.DataColumnMapping("ContactID", "ContactID"), New System.Data.Common.DataColumnMapping("ContactMethodCd", "ContactMethodCd"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("VisitID", "VisitID")})})
        Me.da1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ContactID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactMethodCd", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodCd", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactMethodCd1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodCd", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Notes1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VisitID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO tbStuHpvPatVisitContactHx(ContactDate, ContactMethodCd, LastEditDate," & _
            " LastEditLoginID, Notes, VisitID) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ContactDate", System.Data.OleDb.OleDbType.DBDate, 0, "ContactDate"), New System.Data.OleDb.OleDbParameter("ContactMethodCd", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "ContactMethodCd"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 10, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 255, "Notes"), New System.Data.OleDb.OleDbParameter("VisitID", System.Data.OleDb.OleDbType.[Integer], 0, "VisitID")})
        '
        'da1SelectComm
        '
        Me.da1SelectComm.CommandText = "SELECT ContactDate, ContactID, ContactMethodCd, LastEditDate, LastEditLoginID, No" & _
            "tes, VisitID FROM tbStuHpvPatVisitContactHx"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ContactDate", System.Data.OleDb.OleDbType.DBDate, 0, "ContactDate"), New System.Data.OleDb.OleDbParameter("ContactMethodCd", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "ContactMethodCd"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 10, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 255, "Notes"), New System.Data.OleDb.OleDbParameter("VisitID", System.Data.OleDb.OleDbType.[Integer], 0, "VisitID"), New System.Data.OleDb.OleDbParameter("Original_ContactID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactMethodCd", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodCd", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactMethodCd1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodCd", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Notes1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_VisitID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitID", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label60.Location = New System.Drawing.Point(7, 21)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(84, 15)
        Me.Label60.TabIndex = 77
        Me.Label60.Text = "Contact Method"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(10, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Contact Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dts1
        '
        Me.dts1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dts1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dts1.Location = New System.Drawing.Point(94, 48)
        Me.dts1.Name = "dts1"
        Me.dts1.ShowCheckBox = True
        Me.dts1.Size = New System.Drawing.Size(99, 21)
        Me.dts1.TabIndex = 1
        Me.dts1.Tag = "ContactDate"
        Me.dts1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLastEditDate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtVisitID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtContactID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(170, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 97)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        '
        'txtLastEditDate
        '
        Me.txtLastEditDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastEditDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitContactHx.LastEditDate", True))
        Me.txtLastEditDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastEditDate.ForeColor = System.Drawing.Color.DimGray
        Me.txtLastEditDate.Location = New System.Drawing.Point(88, 70)
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
        'txtVisitID
        '
        Me.txtVisitID.BackColor = System.Drawing.SystemColors.Control
        Me.txtVisitID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitContactHx.VisitID", True))
        Me.txtVisitID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitID.ForeColor = System.Drawing.Color.DimGray
        Me.txtVisitID.Location = New System.Drawing.Point(88, 43)
        Me.txtVisitID.Name = "txtVisitID"
        Me.txtVisitID.ReadOnly = True
        Me.txtVisitID.Size = New System.Drawing.Size(130, 21)
        Me.txtVisitID.TabIndex = 87
        Me.txtVisitID.TabStop = False
        Me.txtVisitID.Text = "VisitID"
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
        Me.Label6.Text = "Visit ID"
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
        'txtContactID
        '
        Me.txtContactID.BackColor = System.Drawing.SystemColors.Control
        Me.txtContactID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitContactHx.ContactID", True))
        Me.txtContactID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactID.ForeColor = System.Drawing.Color.DimGray
        Me.txtContactID.Location = New System.Drawing.Point(88, 16)
        Me.txtContactID.Name = "txtContactID"
        Me.txtContactID.ReadOnly = True
        Me.txtContactID.Size = New System.Drawing.Size(130, 21)
        Me.txtContactID.TabIndex = 92
        Me.txtContactID.TabStop = False
        Me.txtContactID.Text = "ContactID"
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
        Me.Label3.Text = "Contact ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitContactHx.Notes", True))
        Me.txtNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(94, 79)
        Me.txtNotes.MaxLength = 255
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(302, 106)
        Me.txtNotes.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(56, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Notes"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboContactMethod
        '
        Me.cboContactMethod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ds, "tbStuHpvPatVisitContactHx.ContactMethodCd", True))
        Me.cboContactMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContactMethod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboContactMethod.ItemHeight = 13
        Me.cboContactMethod.Location = New System.Drawing.Point(94, 17)
        Me.cboContactMethod.Name = "cboContactMethod"
        Me.cboContactMethod.Size = New System.Drawing.Size(216, 21)
        Me.cboContactMethod.TabIndex = 0
        '
        'da2
        '
        Me.da2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.da2.InsertCommand = Me.OleDbInsertCommand2
        Me.da2.SelectCommand = Me.da2SelectComm
        Me.da2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ddvContactMethod", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ContactMethodCd", "ContactMethodCd"), New System.Data.Common.DataColumnMapping("ContactMethodDesc", "ContactMethodDesc")})})
        Me.da2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM ddvContactMethod WHERE (ContactMethodCd = ?) AND (ContactMethodDesc =" & _
            " ? OR ? IS NULL AND ContactMethodDesc IS NULL)"
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ContactMethodCd", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodCd", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactMethodDesc", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactMethodDesc1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodDesc", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO ddvContactMethod(ContactMethodDesc) VALUES (?)"
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ContactMethodDesc", System.Data.OleDb.OleDbType.VarWChar, 100, "ContactMethodDesc")})
        '
        'da2SelectComm
        '
        Me.da2SelectComm.CommandText = "SELECT ContactMethodCd, ContactMethodDesc FROM ddvContactMethod"
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE ddvContactMethod SET ContactMethodDesc = ? WHERE (ContactMethodCd = ?) AND" & _
            " (ContactMethodDesc = ? OR ? IS NULL AND ContactMethodDesc IS NULL)"
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ContactMethodDesc", System.Data.OleDb.OleDbType.VarWChar, 100, "ContactMethodDesc"), New System.Data.OleDb.OleDbParameter("Original_ContactMethodCd", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodCd", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactMethodDesc", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodDesc", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactMethodDesc1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactMethodDesc", System.Data.DataRowVersion.Original, Nothing)})
        '
        'frmStuHpvCtHxEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(406, 198)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboContactMethod)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dts1)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStuHpvCtHxEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing Contact Hx"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim FormActivated As Boolean = False
    Dim conn As OleDbConnection    
    Private pParentVisitfrm As frmStuHpvPatVisitEdit

    Public Property ParentVisitfrm() As frmStuHpvPatVisitEdit
        Get
            Return pParentVisitfrm
        End Get
        Set(ByVal value As frmStuHpvPatVisitEdit)
            pParentVisitfrm = value
        End Set
    End Property

    Private Sub frmStuHpvCtHxEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Need the following to Retrieve Microsoft Access Autonumber Value
            'for: xLvwIdx = Me.txtVisitID.Text on save
            conn = New OleDbConnection
            conn.ConnectionString = strConn
            AddHandler da1.RowUpdated, AddressOf da1_OnRowUpdate

            Fill_cboContactMethod()
            If vb.Left(Me.Text.ToString, 7) = "Editing" Then
                Fill_tbStuHpvPatVisitContactHx()
                FillDateTimeSlickers(Me, Me.ds.tbStuHpvPatVisitContactHx, "dts", 1)
                Me.Text = "Editing contact hx" & " ..."
            Else


                'SetColumnDefaultValue() 'Need this before AddNew
                Me.BindingContext(Me.ds, "tbStuHpvPatVisitContactHx").AddNew()
                'Need this after AddNew
                Me.BindingContext(Me.ds, "tbStuHpvPatVisitContactHx").Position = 0

                'visitid is the parent form tag
                Me.ds.tbStuHpvPatVisitContactHx.Item(0).VisitID = Me.ParentVisitfrm.Tag
                
                dts1.Text = Today
                Me.ds.tbStuHpvPatVisitContactHx.Item(0).ContactDate = dts1.Value

                Me.Text = "Adding a new contact hx ..."
            End If

            'Me.tabHpvVst.SelectedIndex = vfrmPatient.tabHpvVst.SelectedIndex

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Fill_cboContactMethod()
        Try

            Dim PatID As Integer = vfrmPatient.lvw0.SelectedItems(0).SubItems(vfrmPatient.lvw0.Columns.Count - 1).Text
            Dim strSQL As String
            Dim arlContactMethod As New ArrayList

            strSQL = "SELECT IIf([ContactChoice] IS NULL, STRING(6,' ') & [ContactMethodDesc], FORMAT([ContactChoice],'00') & '. ' & [ContactMethodDesc]) AS CTDesc, ddvContactMethod.ContactMethodCd " & _
                     "FROM ddvContactMethod LEFT JOIN " & _
                         "(SELECT ContactMethodCd, ContactChoice " & _
                          "FROM tbContactChoice " & _
                          "WHERE ContactOwnerCd = 1 AND PatientID=" & PatID & ") AS Q " & _
                     "ON ddvContactMethod.ContactMethodCd = Q.ContactMethodCd " & _
                     "WHERE ContactOwnerCd = 1 " & _
                     "ORDER BY IIF([ContactChoice] IS NULL, 99,[ContactChoice]), ddvContactMethod.ContactMethodCd"
            Console.WriteLine(strSQL)

            Dim conn As New OleDbConnection(strConn)
            Dim cmd As New OleDbCommand(strSQL, conn)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        arlContactMethod.Add(New struDescValuePair(.Item(0), .Item(1)))
                    Loop
                End If
                .Close()
            End With
            conn.Close()

            With Me.cboContactMethod
                .DataSource = arlContactMethod
                .DisplayMember = "getDesc"
                .ValueMember = "getValue"
                .MaxDropDownItems = .Items.Count
            End With

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Fill_tbStuHpvPatVisitContactHx()
        Try
            'Dim conn As New OleDbConnection(strConn)            
            With Me.ParentVisitfrm
                da1SelectComm.Connection = conn
                da1SelectComm.CommandText = _
                   "SELECT * FROM tbStuHpvPatVisitContactHx WHERE ContactID=" & _
                   .lvwHpvCtHx.SelectedItems(0).SubItems(.lvwHpvCtHx.Columns.Count - 1).Text
            End With
            da1.Fill(ds.tbStuHpvPatVisitContactHx)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmStuHpvCtHxEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub

    Private Sub frmStuHpvCtHxEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmStuHpvCtHxEdit = Nothing
    End Sub

    Private Sub da1_OnRowUpdate(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)

        'If vb.Left(Me.Text.ToString, 6) = "Adding" Then
        If e.StatementType = StatementType.Insert Then
            Dim oCmd As New OleDbCommand("SELECT @@IDENTITY")
            oCmd.Connection = conn
            e.Row("ContactID") = oCmd.ExecuteScalar()
            e.Row.AcceptChanges()
            'MsgBox(e.Row("EpisodeID"))
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Try
            Dim resp As MsgBoxResult
            If vb.Left(Me.Text.ToString, 6) = "Adding" Then
                resp = MsgBox("Do you want to add this new contact hx?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then

                    If ValidationPassed() Then
                        'MsgBox(System.DateTime.Now.ToString)
                        txtLastEditDate.Text = System.DateTime.Now
                        Me.BindingContext(Me.ds, "tbStuHpvPatVisitContactHx").EndCurrentEdit()

                        UpdateDataSourceAddNew(Me.ds, "tbStuHpvPatVisitContactHx", conn, Me.da1)
                        CloseAndUpdate()

                    End If

                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If

            Else

                Dim objDataSetChanges As DataSet1 = New DataSet1
                Me.BindingContext(Me.ds, "tbStuHpvPatVisitContactHx").EndCurrentEdit()
                objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)
                If Not (objDataSetChanges) Is Nothing Then
                    resp = MsgBox("Do you want to save your changes?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                    If resp = MsgBoxResult.Yes Then

                        If ValidationPassed() Then
                            'Must cancel edit first
                            Me.BindingContext(Me.ds, "tbStuHpvPatVisitContactHx").CancelCurrentEdit()
                            txtLastEditDate.Text = System.DateTime.Now
                            Me.BindingContext(Me.ds, "tbStuHpvPatVisitContactHx").EndCurrentEdit()
                            objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)

                            UpdateDataSource(objDataSetChanges, conn, Me.da1)

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

        If Me.cboContactMethod.Text.Trim.Length = 0 Then
            MsgBox("'Contact Method' is required.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
            Me.cboContactMethod.Focus()
            Return False
            Exit Function
        End If

        If Me.dts1.Checked = False Then
            MsgBox("'Contact Date' is required.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
            Me.dts1.Focus()
            Return False
            Exit Function
        End If

    End Function

    Private Sub CloseAndUpdate()

        xLvwIdx = Me.txtContactID.Text 'Need this 
        'MsgBox(xLvwIdx)

        Me.Close()
        With vfrmPatient
            .Update_tabHpvVst()
            SelectLvwItem(.lvwHpvCtHx, xLvwIdx, .lvwHpvCtHx.Columns.Count - 1)
        End With

    End Sub

    Private Sub dts1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.TextChanged
        If FormActivated Then
            Me.ds.tbStuHpvPatVisitContactHx.Item(0).ContactDate = dts1.Value
        End If
    End Sub

    Private Sub dts1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.CheckedChanged
        If FormActivated Then
            Select Case dts1.Checked
                Case True
                    Me.ds.tbStuHpvPatVisitContactHx.Item(0).ContactDate = dts1.Value
                Case False
                    Me.ds.tbStuHpvPatVisitContactHx.Item(0).SetContactDateNull()
            End Select
        End If
    End Sub
End Class


