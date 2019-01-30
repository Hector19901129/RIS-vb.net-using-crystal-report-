Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb

Public Class frmPatCtsEdit
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
    Friend WithEvents lvwCtMthdSlf2 As System.Windows.Forms.ListView
    Friend WithEvents lvwCtMthdSlf2C3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlf1 As System.Windows.Forms.ListView
    Friend WithEvents lvwCtMthdSlf1C1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlf1C2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlf2C2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwCtMthdSlf2C1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnMoveCtMthdUp As System.Windows.Forms.Button
    Friend WithEvents btnMoveCtMthdDn As System.Windows.Forms.Button
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfFaceBookNetwork As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsSlfFaceBookEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfFaceBookSignUpName As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfSpecialRequests As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfMySpaceURL As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsSlfMySpaceEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfMySpaceSignUpName As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsSlfEmail2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsSlfEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfCity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfAddress As System.Windows.Forms.TextBox
    Friend WithEvents Tab1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab1P1 As System.Windows.Forms.TabPage
    Friend WithEvents Tab1P2 As System.Windows.Forms.TabPage
    Friend WithEvents cboCtsSlfState As System.Windows.Forms.ComboBox
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastEditDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents mskHomePhone As FlxMaskBox.FlexMaskEditBox
    Friend WithEvents mskCellPhone As FlxMaskBox.FlexMaskEditBox
    Friend WithEvents mskZip As FlxMaskBox.FlexMaskEditBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfMySpaceDisplayName As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfIMScreenName As System.Windows.Forms.TextBox
    Friend WithEvents txtCtsSlfIMName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtCtsSlfNextelWalkieTalkie As System.Windows.Forms.TextBox
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents da1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents da1SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents ils16X16 As System.Windows.Forms.ImageList
    Friend WithEvents txtCtsSlfOtherContactNum As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents da_Address As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents da_Address_SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents da_Phone As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents da_Phone_SelectComm As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPatCtsEdit))
        Me.ds = New RIS.DataSet1
        Me.btnExit = New System.Windows.Forms.Button
        Me.da1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.da1SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.lvwCtMthdSlf2 = New System.Windows.Forms.ListView
        Me.lvwCtMthdSlf2C1 = New System.Windows.Forms.ColumnHeader
        Me.lvwCtMthdSlf2C2 = New System.Windows.Forms.ColumnHeader
        Me.lvwCtMthdSlf2C3 = New System.Windows.Forms.ColumnHeader
        Me.lvwCtMthdSlf1 = New System.Windows.Forms.ListView
        Me.lvwCtMthdSlf1C1 = New System.Windows.Forms.ColumnHeader
        Me.lvwCtMthdSlf1C2 = New System.Windows.Forms.ColumnHeader
        Me.btnMoveCtMthdUp = New System.Windows.Forms.Button
        Me.ils16X16 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnMoveCtMthdDn = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Tab1 = New System.Windows.Forms.TabControl
        Me.Tab1P1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.mskCellPhone = New FlxMaskBox.FlexMaskEditBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.txtCtsSlfEmail2 = New System.Windows.Forms.TextBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCtsSlfOtherContactNum = New System.Windows.Forms.TextBox
        Me.chk1 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chk2 = New System.Windows.Forms.CheckBox
        Me.txtCtsSlfCity = New System.Windows.Forms.TextBox
        Me.cboCtsSlfState = New System.Windows.Forms.ComboBox
        Me.txtCtsSlfEmail1 = New System.Windows.Forms.TextBox
        Me.txtCtsSlfAddress = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.mskZip = New FlxMaskBox.FlexMaskEditBox
        Me.txtCtsSlfNextelWalkieTalkie = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.mskHomePhone = New FlxMaskBox.FlexMaskEditBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.txtCtsSlfMySpaceDisplayName = New System.Windows.Forms.RichTextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtCtsSlfMySpaceURL = New System.Windows.Forms.TextBox
        Me.txtCtsSlfMySpaceEmail = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtCtsSlfMySpaceSignUpName = New System.Windows.Forms.TextBox
        Me.Tab1P2 = New System.Windows.Forms.TabPage
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtCtsSlfIMScreenName = New System.Windows.Forms.TextBox
        Me.txtCtsSlfIMName = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLastEditDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPatientID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtCtsSlfSpecialRequests = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtCtsSlfFaceBookNetwork = New System.Windows.Forms.TextBox
        Me.txtCtsSlfFaceBookEmail = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtCtsSlfFaceBookSignUpName = New System.Windows.Forms.TextBox
        Me.da_Address = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.da_Address_SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.da_Phone = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.da_Phone_SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab1.SuspendLayout()
        Me.Tab1P1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Tab1P2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ds
        '
        Me.ds.DataSetName = "DataSet1"
        Me.ds.Locale = New System.Globalization.CultureInfo("en-US")
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
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'da1
        '
        Me.da1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.da1.InsertCommand = Me.OleDbInsertCommand1
        Me.da1.SelectCommand = Me.da1SelectComm
        Me.da1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbPatientContactInfo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("AptNum", "AptNum"), New System.Data.Common.DataColumnMapping("CanMailReminder", "CanMailReminder"), New System.Data.Common.DataColumnMapping("CanTextMessage", "CanTextMessage"), New System.Data.Common.DataColumnMapping("CellPhone", "CellPhone"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Email1", "Email1"), New System.Data.Common.DataColumnMapping("Email2", "Email2"), New System.Data.Common.DataColumnMapping("FaceBookEmail", "FaceBookEmail"), New System.Data.Common.DataColumnMapping("FaceBookNetworks", "FaceBookNetworks"), New System.Data.Common.DataColumnMapping("FaceBookSignUpName", "FaceBookSignUpName"), New System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"), New System.Data.Common.DataColumnMapping("IMName", "IMName"), New System.Data.Common.DataColumnMapping("IMScreenName", "IMScreenName"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("MySpaceDisplayName", "MySpaceDisplayName"), New System.Data.Common.DataColumnMapping("MySpaceEmail", "MySpaceEmail"), New System.Data.Common.DataColumnMapping("MySpaceSignUpName", "MySpaceSignUpName"), New System.Data.Common.DataColumnMapping("MySpaceURL", "MySpaceURL"), New System.Data.Common.DataColumnMapping("NextelWalkieTalkie", "NextelWalkieTalkie"), New System.Data.Common.DataColumnMapping("OtherContactNum", "OtherContactNum"), New System.Data.Common.DataColumnMapping("PatientContactInfoID", "PatientContactInfoID"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("SpecialRequestsWhenContact", "SpecialRequestsWhenContact"), New System.Data.Common.DataColumnMapping("State", "State"), New System.Data.Common.DataColumnMapping("Zip", "Zip")})})
        Me.da1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM tbPatientContactInfo WHERE (PatientContactInfoID = ?) AND (Address = " & _
        "? OR ? IS NULL AND Address IS NULL) AND (AptNum = ? OR ? IS NULL AND AptNum IS N" & _
        "ULL) AND (CanMailReminder = ?) AND (CanTextMessage = ?) AND (CellPhone = ? OR ? " & _
        "IS NULL AND CellPhone IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND " & _
        "(Email1 = ? OR ? IS NULL AND Email1 IS NULL) AND (Email2 = ? OR ? IS NULL AND Em" & _
        "ail2 IS NULL) AND (FaceBookEmail = ? OR ? IS NULL AND FaceBookEmail IS NULL) AND" & _
        " (FaceBookNetworks = ? OR ? IS NULL AND FaceBookNetworks IS NULL) AND (FaceBookS" & _
        "ignUpName = ? OR ? IS NULL AND FaceBookSignUpName IS NULL) AND (HomePhone = ? OR" & _
        " ? IS NULL AND HomePhone IS NULL) AND (IMName = ? OR ? IS NULL AND IMName IS NUL" & _
        "L) AND (IMScreenName = ? OR ? IS NULL AND IMScreenName IS NULL) AND (LastEditDat" & _
        "e = ? OR ? IS NULL AND LastEditDate IS NULL) AND (LastEditLoginID = ? OR ? IS NU" & _
        "LL AND LastEditLoginID IS NULL) AND (MySpaceEmail = ? OR ? IS NULL AND MySpaceEm" & _
        "ail IS NULL) AND (MySpaceSignUpName = ? OR ? IS NULL AND MySpaceSignUpName IS NU" & _
        "LL) AND (MySpaceURL = ? OR ? IS NULL AND MySpaceURL IS NULL) AND (NextelWalkieTa" & _
        "lkie = ? OR ? IS NULL AND NextelWalkieTalkie IS NULL) AND (OtherContactNum = ? O" & _
        "R ? IS NULL AND OtherContactNum IS NULL) AND (PatientID = ?) AND (SpecialRequest" & _
        "sWhenContact = ? OR ? IS NULL AND SpecialRequestsWhenContact IS NULL) AND (State" & _
        " = ? OR ? IS NULL AND State IS NULL) AND (Zip = ? OR ? IS NULL AND Zip IS NULL)"
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientContactInfoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientContactInfoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AptNum", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AptNum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AptNum1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AptNum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanMailReminder", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanMailReminder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanTextMessage", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanTextMessage", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CellPhone", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CellPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CellPhone1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CellPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookEmail", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookEmail1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookNetworks", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookNetworks", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookNetworks1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookNetworks", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookSignUpName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookSignUpName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookSignUpName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookSignUpName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HomePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HomePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IMName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IMName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IMName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IMName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IMScreenName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IMScreenName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IMScreenName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IMScreenName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceEmail", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceEmail1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceSignUpName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceSignUpName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceSignUpName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceSignUpName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceURL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceURL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceURL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceURL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NextelWalkieTalkie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextelWalkieTalkie", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NextelWalkieTalkie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextelWalkieTalkie", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OtherContactNum", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtherContactNum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OtherContactNum1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtherContactNum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialRequestsWhenContact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SpecialRequestsWhenContact1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialRequestsWhenContact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO tbPatientContactInfo(Address, AptNum, CanMailReminder, CanTextMessage" & _
        ", CellPhone, City, Email1, Email2, FaceBookEmail, FaceBookNetworks, FaceBookSign" & _
        "UpName, HomePhone, IMName, IMScreenName, LastEditDate, LastEditLoginID, MySpaceD" & _
        "isplayName, MySpaceEmail, MySpaceSignUpName, MySpaceURL, NextelWalkieTalkie, Oth" & _
        "erContactNum, PatientID, SpecialRequestsWhenContact, State, Zip) VALUES (?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AptNum", System.Data.OleDb.OleDbType.VarWChar, 10, "AptNum"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanMailReminder", System.Data.OleDb.OleDbType.Boolean, 2, "CanMailReminder"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanTextMessage", System.Data.OleDb.OleDbType.Boolean, 2, "CanTextMessage"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CellPhone", System.Data.OleDb.OleDbType.VarWChar, 10, "CellPhone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email1", System.Data.OleDb.OleDbType.VarWChar, 50, "Email1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email2", System.Data.OleDb.OleDbType.VarWChar, 50, "Email2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FaceBookEmail", System.Data.OleDb.OleDbType.VarWChar, 50, "FaceBookEmail"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FaceBookNetworks", System.Data.OleDb.OleDbType.VarWChar, 100, "FaceBookNetworks"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FaceBookSignUpName", System.Data.OleDb.OleDbType.VarWChar, 50, "FaceBookSignUpName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 10, "HomePhone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IMName", System.Data.OleDb.OleDbType.VarWChar, 50, "IMName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IMScreenName", System.Data.OleDb.OleDbType.VarWChar, 50, "IMScreenName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MySpaceDisplayName", System.Data.OleDb.OleDbType.VarWChar, 0, "MySpaceDisplayName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MySpaceEmail", System.Data.OleDb.OleDbType.VarWChar, 50, "MySpaceEmail"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MySpaceSignUpName", System.Data.OleDb.OleDbType.VarWChar, 50, "MySpaceSignUpName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MySpaceURL", System.Data.OleDb.OleDbType.VarWChar, 100, "MySpaceURL"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("NextelWalkieTalkie", System.Data.OleDb.OleDbType.VarWChar, 15, "NextelWalkieTalkie"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OtherContactNum", System.Data.OleDb.OleDbType.VarWChar, 30, "OtherContactNum"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.Integer, 0, "PatientID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.VarWChar, 255, "SpecialRequestsWhenContact"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 2, "State"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 10, "Zip"))
        '
        'da1SelectComm
        '
        Me.da1SelectComm.CommandText = "SELECT Address, AptNum, CanMailReminder, CanTextMessage, CellPhone, City, Email1," & _
        " Email2, FaceBookEmail, FaceBookNetworks, FaceBookSignUpName, HomePhone, IMName," & _
        " IMScreenName, LastEditDate, LastEditLoginID, MySpaceDisplayName, MySpaceEmail, " & _
        "MySpaceSignUpName, MySpaceURL, NextelWalkieTalkie, OtherContactNum, PatientConta" & _
        "ctInfoID, PatientID, SpecialRequestsWhenContact, State, Zip FROM tbPatientContac" & _
        "tInfo"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE tbPatientContactInfo SET Address = ?, AptNum = ?, CanMailReminder = ?, Can" & _
        "TextMessage = ?, CellPhone = ?, City = ?, Email1 = ?, Email2 = ?, FaceBookEmail " & _
        "= ?, FaceBookNetworks = ?, FaceBookSignUpName = ?, HomePhone = ?, IMName = ?, IM" & _
        "ScreenName = ?, LastEditDate = ?, LastEditLoginID = ?, MySpaceDisplayName = ?, M" & _
        "ySpaceEmail = ?, MySpaceSignUpName = ?, MySpaceURL = ?, NextelWalkieTalkie = ?, " & _
        "OtherContactNum = ?, PatientID = ?, SpecialRequestsWhenContact = ?, State = ?, Z" & _
        "ip = ? WHERE (PatientContactInfoID = ?) AND (Address = ? OR ? IS NULL AND Addres" & _
        "s IS NULL) AND (AptNum = ? OR ? IS NULL AND AptNum IS NULL) AND (CanMailReminder" & _
        " = ?) AND (CanTextMessage = ?) AND (CellPhone = ? OR ? IS NULL AND CellPhone IS " & _
        "NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Email1 = ? OR ? IS NULL " & _
        "AND Email1 IS NULL) AND (Email2 = ? OR ? IS NULL AND Email2 IS NULL) AND (FaceBo" & _
        "okEmail = ? OR ? IS NULL AND FaceBookEmail IS NULL) AND (FaceBookNetworks = ? OR" & _
        " ? IS NULL AND FaceBookNetworks IS NULL) AND (FaceBookSignUpName = ? OR ? IS NUL" & _
        "L AND FaceBookSignUpName IS NULL) AND (HomePhone = ? OR ? IS NULL AND HomePhone " & _
        "IS NULL) AND (IMName = ? OR ? IS NULL AND IMName IS NULL) AND (IMScreenName = ? " & _
        "OR ? IS NULL AND IMScreenName IS NULL) AND (LastEditDate = ? OR ? IS NULL AND La" & _
        "stEditDate IS NULL) AND (LastEditLoginID = ? OR ? IS NULL AND LastEditLoginID IS" & _
        " NULL) AND (MySpaceEmail = ? OR ? IS NULL AND MySpaceEmail IS NULL) AND (MySpace" & _
        "SignUpName = ? OR ? IS NULL AND MySpaceSignUpName IS NULL) AND (MySpaceURL = ? O" & _
        "R ? IS NULL AND MySpaceURL IS NULL) AND (NextelWalkieTalkie = ? OR ? IS NULL AND" & _
        " NextelWalkieTalkie IS NULL) AND (OtherContactNum = ? OR ? IS NULL AND OtherCont" & _
        "actNum IS NULL) AND (PatientID = ?) AND (SpecialRequestsWhenContact = ? OR ? IS " & _
        "NULL AND SpecialRequestsWhenContact IS NULL) AND (State = ? OR ? IS NULL AND Sta" & _
        "te IS NULL) AND (Zip = ? OR ? IS NULL AND Zip IS NULL)"
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AptNum", System.Data.OleDb.OleDbType.VarWChar, 10, "AptNum"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanMailReminder", System.Data.OleDb.OleDbType.Boolean, 2, "CanMailReminder"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanTextMessage", System.Data.OleDb.OleDbType.Boolean, 2, "CanTextMessage"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CellPhone", System.Data.OleDb.OleDbType.VarWChar, 10, "CellPhone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email1", System.Data.OleDb.OleDbType.VarWChar, 50, "Email1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Email2", System.Data.OleDb.OleDbType.VarWChar, 50, "Email2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FaceBookEmail", System.Data.OleDb.OleDbType.VarWChar, 50, "FaceBookEmail"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FaceBookNetworks", System.Data.OleDb.OleDbType.VarWChar, 100, "FaceBookNetworks"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FaceBookSignUpName", System.Data.OleDb.OleDbType.VarWChar, 50, "FaceBookSignUpName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 10, "HomePhone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IMName", System.Data.OleDb.OleDbType.VarWChar, 50, "IMName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IMScreenName", System.Data.OleDb.OleDbType.VarWChar, 50, "IMScreenName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MySpaceDisplayName", System.Data.OleDb.OleDbType.VarWChar, 0, "MySpaceDisplayName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MySpaceEmail", System.Data.OleDb.OleDbType.VarWChar, 50, "MySpaceEmail"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MySpaceSignUpName", System.Data.OleDb.OleDbType.VarWChar, 50, "MySpaceSignUpName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MySpaceURL", System.Data.OleDb.OleDbType.VarWChar, 100, "MySpaceURL"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("NextelWalkieTalkie", System.Data.OleDb.OleDbType.VarWChar, 15, "NextelWalkieTalkie"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OtherContactNum", System.Data.OleDb.OleDbType.VarWChar, 30, "OtherContactNum"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.Integer, 0, "PatientID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.VarWChar, 255, "SpecialRequestsWhenContact"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 2, "State"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 10, "Zip"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientContactInfoID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientContactInfoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AptNum", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AptNum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AptNum1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AptNum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanMailReminder", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanMailReminder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanTextMessage", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanTextMessage", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CellPhone", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CellPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CellPhone1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CellPhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Email21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookEmail", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookEmail1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookNetworks", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookNetworks", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookNetworks1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookNetworks", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookSignUpName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookSignUpName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FaceBookSignUpName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FaceBookSignUpName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HomePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HomePhone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IMName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IMName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IMName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IMName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IMScreenName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IMScreenName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IMScreenName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IMScreenName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceEmail", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceEmail1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceSignUpName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceSignUpName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceSignUpName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceSignUpName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceURL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceURL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MySpaceURL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MySpaceURL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NextelWalkieTalkie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextelWalkieTalkie", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NextelWalkieTalkie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NextelWalkieTalkie", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OtherContactNum", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtherContactNum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OtherContactNum1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtherContactNum", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SpecialRequestsWhenContact", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialRequestsWhenContact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SpecialRequestsWhenContact1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SpecialRequestsWhenContact", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""E:\VBnetProj\Other\RIS\bin\RIS.mdb"";Jet OLEDB:Engine " & _
        "Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:S" & _
        "FP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;J" & _
        "et OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB" & _
        ":Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=Fal" & _
        "se;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"
        '
        'lvwCtMthdSlf2
        '
        Me.lvwCtMthdSlf2.CheckBoxes = True
        Me.lvwCtMthdSlf2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwCtMthdSlf2C1, Me.lvwCtMthdSlf2C2, Me.lvwCtMthdSlf2C3})
        Me.lvwCtMthdSlf2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCtMthdSlf2.FullRowSelect = True
        Me.lvwCtMthdSlf2.GridLines = True
        Me.lvwCtMthdSlf2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwCtMthdSlf2.HideSelection = False
        Me.lvwCtMthdSlf2.Location = New System.Drawing.Point(527, 25)
        Me.lvwCtMthdSlf2.MultiSelect = False
        Me.lvwCtMthdSlf2.Name = "lvwCtMthdSlf2"
        Me.lvwCtMthdSlf2.Size = New System.Drawing.Size(223, 226)
        Me.lvwCtMthdSlf2.TabIndex = 1
        Me.lvwCtMthdSlf2.View = System.Windows.Forms.View.Details
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
        'lvwCtMthdSlf1
        '
        Me.lvwCtMthdSlf1.CheckBoxes = True
        Me.lvwCtMthdSlf1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwCtMthdSlf1C1, Me.lvwCtMthdSlf1C2})
        Me.lvwCtMthdSlf1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwCtMthdSlf1.FullRowSelect = True
        Me.lvwCtMthdSlf1.GridLines = True
        Me.lvwCtMthdSlf1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwCtMthdSlf1.HideSelection = False
        Me.lvwCtMthdSlf1.Location = New System.Drawing.Point(527, 270)
        Me.lvwCtMthdSlf1.MultiSelect = False
        Me.lvwCtMthdSlf1.Name = "lvwCtMthdSlf1"
        Me.lvwCtMthdSlf1.Size = New System.Drawing.Size(223, 226)
        Me.lvwCtMthdSlf1.TabIndex = 2
        Me.lvwCtMthdSlf1.View = System.Windows.Forms.View.Details
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
        Me.btnMoveCtMthdUp.Location = New System.Drawing.Point(754, 97)
        Me.btnMoveCtMthdUp.Name = "btnMoveCtMthdUp"
        Me.btnMoveCtMthdUp.Size = New System.Drawing.Size(27, 26)
        Me.btnMoveCtMthdUp.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnMoveCtMthdUp, "Move the selected contact method up.")
        '
        'ils16X16
        '
        Me.ils16X16.ImageSize = New System.Drawing.Size(16, 16)
        Me.ils16X16.ImageStream = CType(resources.GetObject("ils16X16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ils16X16.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnMoveCtMthdDn
        '
        Me.btnMoveCtMthdDn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMoveCtMthdDn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveCtMthdDn.ImageIndex = 3
        Me.btnMoveCtMthdDn.ImageList = Me.ils16X16
        Me.btnMoveCtMthdDn.Location = New System.Drawing.Point(754, 132)
        Me.btnMoveCtMthdDn.Name = "btnMoveCtMthdDn"
        Me.btnMoveCtMthdDn.Size = New System.Drawing.Size(27, 26)
        Me.btnMoveCtMthdDn.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnMoveCtMthdDn, "Move the selected contact method down.")
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
        Me.Label1.Location = New System.Drawing.Point(527, 255)
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
        Me.Tab1.Size = New System.Drawing.Size(519, 491)
        Me.Tab1.TabIndex = 0
        '
        'Tab1P1
        '
        Me.Tab1P1.Controls.Add(Me.GroupBox1)
        Me.Tab1P1.Controls.Add(Me.GroupBox8)
        Me.Tab1P1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1P1.Name = "Tab1P1"
        Me.Tab1P1.Size = New System.Drawing.Size(511, 465)
        Me.Tab1P1.TabIndex = 2
        Me.Tab1P1.Text = "Contact Info 1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.mskCellPhone)
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Controls.Add(Me.txtCtsSlfEmail2)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.Label52)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCtsSlfOtherContactNum)
        Me.GroupBox1.Controls.Add(Me.chk1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chk2)
        Me.GroupBox1.Controls.Add(Me.txtCtsSlfCity)
        Me.GroupBox1.Controls.Add(Me.cboCtsSlfState)
        Me.GroupBox1.Controls.Add(Me.txtCtsSlfEmail1)
        Me.GroupBox1.Controls.Add(Me.txtCtsSlfAddress)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.mskZip)
        Me.GroupBox1.Controls.Add(Me.txtCtsSlfNextelWalkieTalkie)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.Label49)
        Me.GroupBox1.Controls.Add(Me.mskHomePhone)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(5, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 15)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Can mail reminder cards"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(5, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Email 2"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(5, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 15)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Email 1"
        '
        'mskCellPhone
        '
        Me.mskCellPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactPhoneCell.PhoneNumber"))
        Me.mskCellPhone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mskCellPhone.Location = New System.Drawing.Point(240, 84)
        Me.mskCellPhone.Mask = "(###)-###-####"
        Me.mskCellPhone.MaskCharInclude = False
        Me.mskCellPhone.Name = "mskCellPhone"
        Me.mskCellPhone.Size = New System.Drawing.Size(104, 21)
        Me.mskCellPhone.TabIndex = 7
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label50.Location = New System.Drawing.Point(376, 40)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(22, 15)
        Me.Label50.TabIndex = 80
        Me.Label50.Text = "Zip"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtsSlfEmail2
        '
        Me.txtCtsSlfEmail2.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfEmail2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.Email2"))
        Me.txtCtsSlfEmail2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfEmail2.Location = New System.Drawing.Point(90, 200)
        Me.txtCtsSlfEmail2.MaxLength = 50
        Me.txtCtsSlfEmail2.Name = "txtCtsSlfEmail2"
        Me.txtCtsSlfEmail2.Size = New System.Drawing.Size(330, 21)
        Me.txtCtsSlfEmail2.TabIndex = 12
        Me.txtCtsSlfEmail2.Text = "Email2"
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label51.Location = New System.Drawing.Point(297, 40)
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(5, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Address"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtsSlfOtherContactNum
        '
        Me.txtCtsSlfOtherContactNum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfOtherContactNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfOtherContactNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.OtherContactNum"))
        Me.txtCtsSlfOtherContactNum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfOtherContactNum.Location = New System.Drawing.Point(90, 146)
        Me.txtCtsSlfOtherContactNum.MaxLength = 30
        Me.txtCtsSlfOtherContactNum.Name = "txtCtsSlfOtherContactNum"
        Me.txtCtsSlfOtherContactNum.Size = New System.Drawing.Size(217, 21)
        Me.txtCtsSlfOtherContactNum.TabIndex = 10
        Me.txtCtsSlfOtherContactNum.Text = "OtherContactNum"
        '
        'chk1
        '
        Me.chk1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk1.ForeColor = System.Drawing.Color.DarkBlue
        Me.chk1.Location = New System.Drawing.Point(9, 60)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(144, 21)
        Me.chk1.TabIndex = 5
        Me.chk1.Tag = "CanMailReminder"
        Me.chk1.Text = "Can mail reminder cards"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(422, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Apt #"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(348, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Can text message    "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chk2
        '
        Me.chk2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk2.ForeColor = System.Drawing.Color.DarkBlue
        Me.chk2.Location = New System.Drawing.Point(351, 84)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(117, 21)
        Me.chk2.TabIndex = 8
        Me.chk2.Tag = "CanTextMessage"
        Me.chk2.Text = "Can text message"
        '
        'txtCtsSlfCity
        '
        Me.txtCtsSlfCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactAddress.City"))
        Me.txtCtsSlfCity.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfCity.Location = New System.Drawing.Point(54, 37)
        Me.txtCtsSlfCity.MaxLength = 50
        Me.txtCtsSlfCity.Name = "txtCtsSlfCity"
        Me.txtCtsSlfCity.Size = New System.Drawing.Size(239, 21)
        Me.txtCtsSlfCity.TabIndex = 2
        Me.txtCtsSlfCity.Text = "City"
        '
        'cboCtsSlfState
        '
        Me.cboCtsSlfState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactAddress.State"))
        Me.cboCtsSlfState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCtsSlfState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtsSlfState.ItemHeight = 13
        Me.cboCtsSlfState.Items.AddRange(New Object() {"NY", "NJ", "CT", ""})
        Me.cboCtsSlfState.Location = New System.Drawing.Point(330, 37)
        Me.cboCtsSlfState.Name = "cboCtsSlfState"
        Me.cboCtsSlfState.Size = New System.Drawing.Size(45, 21)
        Me.cboCtsSlfState.TabIndex = 3
        '
        'txtCtsSlfEmail1
        '
        Me.txtCtsSlfEmail1.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfEmail1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.Email1"))
        Me.txtCtsSlfEmail1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfEmail1.Location = New System.Drawing.Point(90, 175)
        Me.txtCtsSlfEmail1.MaxLength = 50
        Me.txtCtsSlfEmail1.Name = "txtCtsSlfEmail1"
        Me.txtCtsSlfEmail1.Size = New System.Drawing.Size(330, 21)
        Me.txtCtsSlfEmail1.TabIndex = 11
        Me.txtCtsSlfEmail1.Text = "Email1"
        '
        'txtCtsSlfAddress
        '
        Me.txtCtsSlfAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactAddress.Address1"))
        Me.txtCtsSlfAddress.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfAddress.Location = New System.Drawing.Point(54, 11)
        Me.txtCtsSlfAddress.MaxLength = 50
        Me.txtCtsSlfAddress.Name = "txtCtsSlfAddress"
        Me.txtCtsSlfAddress.Size = New System.Drawing.Size(367, 21)
        Me.txtCtsSlfAddress.TabIndex = 0
        Me.txtCtsSlfAddress.Text = "Address"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactAddress.Address2"))
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(460, 11)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(32, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Address"
        '
        'mskZip
        '
        Me.mskZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactAddress.Zip"))
        Me.mskZip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskZip.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mskZip.Location = New System.Drawing.Point(403, 37)
        Me.mskZip.Mask = "#####-####"
        Me.mskZip.MaskCharInclude = False
        Me.mskZip.Name = "mskZip"
        Me.mskZip.Size = New System.Drawing.Size(89, 21)
        Me.mskZip.TabIndex = 4
        '
        'txtCtsSlfNextelWalkieTalkie
        '
        Me.txtCtsSlfNextelWalkieTalkie.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfNextelWalkieTalkie.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfNextelWalkieTalkie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.NextelWalkieTalkie"))
        Me.txtCtsSlfNextelWalkieTalkie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfNextelWalkieTalkie.Location = New System.Drawing.Point(90, 116)
        Me.txtCtsSlfNextelWalkieTalkie.MaxLength = 15
        Me.txtCtsSlfNextelWalkieTalkie.Name = "txtCtsSlfNextelWalkieTalkie"
        Me.txtCtsSlfNextelWalkieTalkie.Size = New System.Drawing.Size(146, 21)
        Me.txtCtsSlfNextelWalkieTalkie.TabIndex = 9
        Me.txtCtsSlfNextelWalkieTalkie.Text = "NextelWalkieTalkie"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label45.Location = New System.Drawing.Point(5, 112)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 26)
        Me.Label45.TabIndex = 99
        Me.Label45.Text = "Nextel/Verizon walkie talkie #"
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label46.Location = New System.Drawing.Point(5, 145)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(81, 26)
        Me.Label46.TabIndex = 98
        Me.Label46.Text = "Other phone / contact #"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label48.Location = New System.Drawing.Point(192, 87)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(42, 15)
        Me.Label48.TabIndex = 30
        Me.Label48.Text = "Cellular"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label49.Location = New System.Drawing.Point(5, 87)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(73, 15)
        Me.Label49.TabIndex = 29
        Me.Label49.Text = "Home phone"
        '
        'mskHomePhone
        '
        Me.mskHomePhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbContactPhoneHome.PhoneNumber"))
        Me.mskHomePhone.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskHomePhone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mskHomePhone.Location = New System.Drawing.Point(90, 84)
        Me.mskHomePhone.Mask = "(###)-###-####"
        Me.mskHomePhone.MaskCharInclude = False
        Me.mskHomePhone.Name = "mskHomePhone"
        Me.mskHomePhone.Size = New System.Drawing.Size(101, 21)
        Me.mskHomePhone.TabIndex = 6
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtCtsSlfMySpaceDisplayName)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Controls.Add(Me.Label35)
        Me.GroupBox8.Controls.Add(Me.txtCtsSlfMySpaceURL)
        Me.GroupBox8.Controls.Add(Me.txtCtsSlfMySpaceEmail)
        Me.GroupBox8.Controls.Add(Me.Label36)
        Me.GroupBox8.Controls.Add(Me.Label37)
        Me.GroupBox8.Controls.Add(Me.Label38)
        Me.GroupBox8.Controls.Add(Me.txtCtsSlfMySpaceSignUpName)
        Me.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(7, 250)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(500, 195)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        '
        'txtCtsSlfMySpaceDisplayName
        '
        Me.txtCtsSlfMySpaceDisplayName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfMySpaceDisplayName.Location = New System.Drawing.Point(58, 42)
        Me.txtCtsSlfMySpaceDisplayName.Name = "txtCtsSlfMySpaceDisplayName"
        Me.txtCtsSlfMySpaceDisplayName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtCtsSlfMySpaceDisplayName.Size = New System.Drawing.Size(434, 95)
        Me.txtCtsSlfMySpaceDisplayName.TabIndex = 1
        Me.txtCtsSlfMySpaceDisplayName.Text = ""
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label34.Location = New System.Drawing.Point(13, 145)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(43, 16)
        Me.Label34.TabIndex = 37
        Me.Label34.Text = "Email"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label35.Location = New System.Drawing.Point(13, 171)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(42, 18)
        Me.Label35.TabIndex = 36
        Me.Label35.Text = "URL"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtsSlfMySpaceURL
        '
        Me.txtCtsSlfMySpaceURL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfMySpaceURL.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfMySpaceURL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.MySpaceURL"))
        Me.txtCtsSlfMySpaceURL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfMySpaceURL.Location = New System.Drawing.Point(58, 168)
        Me.txtCtsSlfMySpaceURL.MaxLength = 100
        Me.txtCtsSlfMySpaceURL.Name = "txtCtsSlfMySpaceURL"
        Me.txtCtsSlfMySpaceURL.Size = New System.Drawing.Size(434, 21)
        Me.txtCtsSlfMySpaceURL.TabIndex = 3
        Me.txtCtsSlfMySpaceURL.Text = "MySpaceURL"
        '
        'txtCtsSlfMySpaceEmail
        '
        Me.txtCtsSlfMySpaceEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfMySpaceEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfMySpaceEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.MySpaceEmail"))
        Me.txtCtsSlfMySpaceEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfMySpaceEmail.Location = New System.Drawing.Point(58, 142)
        Me.txtCtsSlfMySpaceEmail.MaxLength = 50
        Me.txtCtsSlfMySpaceEmail.Name = "txtCtsSlfMySpaceEmail"
        Me.txtCtsSlfMySpaceEmail.Size = New System.Drawing.Size(434, 21)
        Me.txtCtsSlfMySpaceEmail.TabIndex = 2
        Me.txtCtsSlfMySpaceEmail.Text = "MySpaceEmail"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label36.Location = New System.Drawing.Point(13, 13)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 24)
        Me.Label36.TabIndex = 33
        Me.Label36.Text = "Sign up name"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label37.Location = New System.Drawing.Point(5, -1)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 15)
        Me.Label37.TabIndex = 31
        Me.Label37.Text = " MySpace"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label38.Location = New System.Drawing.Point(13, 43)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(42, 24)
        Me.Label38.TabIndex = 30
        Me.Label38.Text = "Display name"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtsSlfMySpaceSignUpName
        '
        Me.txtCtsSlfMySpaceSignUpName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfMySpaceSignUpName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfMySpaceSignUpName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.MySpaceSignUpName"))
        Me.txtCtsSlfMySpaceSignUpName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfMySpaceSignUpName.Location = New System.Drawing.Point(58, 16)
        Me.txtCtsSlfMySpaceSignUpName.MaxLength = 50
        Me.txtCtsSlfMySpaceSignUpName.Name = "txtCtsSlfMySpaceSignUpName"
        Me.txtCtsSlfMySpaceSignUpName.Size = New System.Drawing.Size(434, 21)
        Me.txtCtsSlfMySpaceSignUpName.TabIndex = 0
        Me.txtCtsSlfMySpaceSignUpName.Text = "MySpaceSignUpName"
        '
        'Tab1P2
        '
        Me.Tab1P2.Controls.Add(Me.GroupBox9)
        Me.Tab1P2.Controls.Add(Me.GroupBox2)
        Me.Tab1P2.Controls.Add(Me.Label29)
        Me.Tab1P2.Controls.Add(Me.txtCtsSlfSpecialRequests)
        Me.Tab1P2.Controls.Add(Me.GroupBox7)
        Me.Tab1P2.Location = New System.Drawing.Point(4, 22)
        Me.Tab1P2.Name = "Tab1P2"
        Me.Tab1P2.Size = New System.Drawing.Size(511, 465)
        Me.Tab1P2.TabIndex = 3
        Me.Tab1P2.Text = "Contact Info 2"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label39)
        Me.GroupBox9.Controls.Add(Me.Label40)
        Me.GroupBox9.Controls.Add(Me.Label41)
        Me.GroupBox9.Controls.Add(Me.txtCtsSlfIMScreenName)
        Me.GroupBox9.Controls.Add(Me.txtCtsSlfIMName)
        Me.GroupBox9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(7, 118)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(499, 75)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label39.Location = New System.Drawing.Point(9, 16)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(89, 26)
        Me.Label39.TabIndex = 33
        Me.Label39.Text = "Name of Instant Messenger"
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.Control
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label40.Location = New System.Drawing.Point(6, -1)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(112, 15)
        Me.Label40.TabIndex = 31
        Me.Label40.Text = "Instant Messenger"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label41.Location = New System.Drawing.Point(9, 46)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(69, 16)
        Me.Label41.TabIndex = 30
        Me.Label41.Text = "Screen name"
        '
        'txtCtsSlfIMScreenName
        '
        Me.txtCtsSlfIMScreenName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfIMScreenName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfIMScreenName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.IMScreenName"))
        Me.txtCtsSlfIMScreenName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfIMScreenName.Location = New System.Drawing.Point(98, 43)
        Me.txtCtsSlfIMScreenName.MaxLength = 50
        Me.txtCtsSlfIMScreenName.Name = "txtCtsSlfIMScreenName"
        Me.txtCtsSlfIMScreenName.Size = New System.Drawing.Size(395, 21)
        Me.txtCtsSlfIMScreenName.TabIndex = 1
        Me.txtCtsSlfIMScreenName.Text = "IMScreenName"
        '
        'txtCtsSlfIMName
        '
        Me.txtCtsSlfIMName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfIMName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfIMName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.IMName"))
        Me.txtCtsSlfIMName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfIMName.Location = New System.Drawing.Point(98, 14)
        Me.txtCtsSlfIMName.MaxLength = 50
        Me.txtCtsSlfIMName.Name = "txtCtsSlfIMName"
        Me.txtCtsSlfIMName.Size = New System.Drawing.Size(395, 21)
        Me.txtCtsSlfIMName.TabIndex = 0
        Me.txtCtsSlfIMName.Text = "IMName"
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
        Me.GroupBox2.Location = New System.Drawing.Point(286, 383)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 75)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        '
        'txtLastEditDate
        '
        Me.txtLastEditDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastEditDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.LastEditDate"))
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
        Me.txtPatientID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.PatientID"))
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
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label29.Location = New System.Drawing.Point(7, 200)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(215, 15)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "Other special instructions for contacting"
        '
        'txtCtsSlfSpecialRequests
        '
        Me.txtCtsSlfSpecialRequests.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfSpecialRequests.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfSpecialRequests.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.SpecialRequestsWhenContact"))
        Me.txtCtsSlfSpecialRequests.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfSpecialRequests.Location = New System.Drawing.Point(7, 218)
        Me.txtCtsSlfSpecialRequests.MaxLength = 255
        Me.txtCtsSlfSpecialRequests.Multiline = True
        Me.txtCtsSlfSpecialRequests.Name = "txtCtsSlfSpecialRequests"
        Me.txtCtsSlfSpecialRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCtsSlfSpecialRequests.Size = New System.Drawing.Size(497, 81)
        Me.txtCtsSlfSpecialRequests.TabIndex = 2
        Me.txtCtsSlfSpecialRequests.Text = "SpecialRequestsWhenContact"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.txtCtsSlfFaceBookNetwork)
        Me.GroupBox7.Controls.Add(Me.txtCtsSlfFaceBookEmail)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Controls.Add(Me.txtCtsSlfFaceBookSignUpName)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(499, 106)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label30.Location = New System.Drawing.Point(17, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 16)
        Me.Label30.TabIndex = 37
        Me.Label30.Text = "Email"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label31.Location = New System.Drawing.Point(9, 77)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 18)
        Me.Label31.TabIndex = 36
        Me.Label31.Text = "Networks"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCtsSlfFaceBookNetwork
        '
        Me.txtCtsSlfFaceBookNetwork.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfFaceBookNetwork.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfFaceBookNetwork.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.FaceBookNetworks"))
        Me.txtCtsSlfFaceBookNetwork.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfFaceBookNetwork.Location = New System.Drawing.Point(64, 74)
        Me.txtCtsSlfFaceBookNetwork.MaxLength = 100
        Me.txtCtsSlfFaceBookNetwork.Name = "txtCtsSlfFaceBookNetwork"
        Me.txtCtsSlfFaceBookNetwork.Size = New System.Drawing.Size(429, 21)
        Me.txtCtsSlfFaceBookNetwork.TabIndex = 2
        Me.txtCtsSlfFaceBookNetwork.Text = "FaceBookNetworks"
        '
        'txtCtsSlfFaceBookEmail
        '
        Me.txtCtsSlfFaceBookEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfFaceBookEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfFaceBookEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.FaceBookEmail"))
        Me.txtCtsSlfFaceBookEmail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfFaceBookEmail.Location = New System.Drawing.Point(64, 47)
        Me.txtCtsSlfFaceBookEmail.MaxLength = 50
        Me.txtCtsSlfFaceBookEmail.Name = "txtCtsSlfFaceBookEmail"
        Me.txtCtsSlfFaceBookEmail.Size = New System.Drawing.Size(429, 21)
        Me.txtCtsSlfFaceBookEmail.TabIndex = 1
        Me.txtCtsSlfFaceBookEmail.Text = "FaceBookEmail"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label32.Location = New System.Drawing.Point(17, 17)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 24)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = "Sign up name"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label33.Location = New System.Drawing.Point(6, -1)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(60, 15)
        Me.Label33.TabIndex = 31
        Me.Label33.Text = "FaceBook"
        '
        'txtCtsSlfFaceBookSignUpName
        '
        Me.txtCtsSlfFaceBookSignUpName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtsSlfFaceBookSignUpName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtsSlfFaceBookSignUpName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatientContactInfo.FaceBookSignUpName"))
        Me.txtCtsSlfFaceBookSignUpName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtsSlfFaceBookSignUpName.Location = New System.Drawing.Point(64, 20)
        Me.txtCtsSlfFaceBookSignUpName.MaxLength = 50
        Me.txtCtsSlfFaceBookSignUpName.Name = "txtCtsSlfFaceBookSignUpName"
        Me.txtCtsSlfFaceBookSignUpName.Size = New System.Drawing.Size(429, 21)
        Me.txtCtsSlfFaceBookSignUpName.TabIndex = 0
        Me.txtCtsSlfFaceBookSignUpName.Text = "FaceBookSignUpName"
        '
        'da_Address
        '
        Me.da_Address.DeleteCommand = Me.OleDbDeleteCommand2
        Me.da_Address.InsertCommand = Me.OleDbInsertCommand2
        Me.da_Address.SelectCommand = Me.da_Address_SelectComm
        Me.da_Address.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbContactAddress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Address1", "Address1"), New System.Data.Common.DataColumnMapping("Address2", "Address2"), New System.Data.Common.DataColumnMapping("CanMailReminder", "CanMailReminder"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("ContactAddressID", "ContactAddressID"), New System.Data.Common.DataColumnMapping("ContactOwnerCd", "ContactOwnerCd"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("State", "State"), New System.Data.Common.DataColumnMapping("Zip", "Zip")})})
        Me.da_Address.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM tbContactAddress WHERE (ContactAddressID = ?) AND (Address1 = ? OR ? " & _
        "IS NULL AND Address1 IS NULL) AND (Address2 = ? OR ? IS NULL AND Address2 IS NUL" & _
        "L) AND (CanMailReminder = ?) AND (City = ? OR ? IS NULL AND City IS NULL) AND (C" & _
        "ontactOwnerCd = ?) AND (LastEditDate = ? OR ? IS NULL AND LastEditDate IS NULL) " & _
        "AND (LastEditLoginID = ? OR ? IS NULL AND LastEditLoginID IS NULL) AND (PatientI" & _
        "D = ?) AND (State = ? OR ? IS NULL AND State IS NULL) AND (Zip = ? OR ? IS NULL " & _
        "AND Zip IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ContactAddressID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactAddressID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanMailReminder", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanMailReminder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactOwnerCd", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""E:\VBnetProj\Other\RIS\bin\Data\RISdata.mdb"";Jet OLED" & _
        "B:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=""E:" & _
        "\VBnetProj\Other\RIS\bin\Security\Wrkgrp_Sec.mdw"";Jet OLEDB:SFP=False;persist se" & _
        "curity info=False;Extended Properties=;Mode=ReadWrite;Jet OLEDB:Encrypt Database" & _
        "=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Com" & _
        "pact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=administrator;" & _
        "Jet OLEDB:Global Bulk Transactions=1"
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO tbContactAddress(Address1, Address2, CanMailReminder, City, ContactOw" & _
        "nerCd, LastEditDate, LastEditLoginID, PatientID, State, Zip) VALUES (?, ?, ?, ?," & _
        " ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address1", System.Data.OleDb.OleDbType.VarWChar, 50, "Address1"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address2", System.Data.OleDb.OleDbType.VarWChar, 50, "Address2"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanMailReminder", System.Data.OleDb.OleDbType.Boolean, 2, "CanMailReminder"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, "ContactOwnerCd"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.Integer, 0, "PatientID"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 2, "State"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 10, "Zip"))
        '
        'da_Address_SelectComm
        '
        Me.da_Address_SelectComm.CommandText = "SELECT Address1, Address2, CanMailReminder, City, ContactAddressID, ContactOwnerC" & _
        "d, LastEditDate, LastEditLoginID, PatientID, State, Zip FROM tbContactAddress"
        Me.da_Address_SelectComm.Connection = Me.OleDbConnection2
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE tbContactAddress SET Address1 = ?, Address2 = ?, CanMailReminder = ?, City" & _
        " = ?, ContactOwnerCd = ?, LastEditDate = ?, LastEditLoginID = ?, PatientID = ?, " & _
        "State = ?, Zip = ? WHERE (ContactAddressID = ?) AND (Address1 = ? OR ? IS NULL A" & _
        "ND Address1 IS NULL) AND (Address2 = ? OR ? IS NULL AND Address2 IS NULL) AND (C" & _
        "anMailReminder = ?) AND (City = ? OR ? IS NULL AND City IS NULL) AND (ContactOwn" & _
        "erCd = ?) AND (LastEditDate = ? OR ? IS NULL AND LastEditDate IS NULL) AND (Last" & _
        "EditLoginID = ? OR ? IS NULL AND LastEditLoginID IS NULL) AND (PatientID = ?) AN" & _
        "D (State = ? OR ? IS NULL AND State IS NULL) AND (Zip = ? OR ? IS NULL AND Zip I" & _
        "S NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address1", System.Data.OleDb.OleDbType.VarWChar, 50, "Address1"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address2", System.Data.OleDb.OleDbType.VarWChar, 50, "Address2"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanMailReminder", System.Data.OleDb.OleDbType.Boolean, 2, "CanMailReminder"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, "ContactOwnerCd"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.Integer, 0, "PatientID"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("State", System.Data.OleDb.OleDbType.VarWChar, 2, "State"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Zip", System.Data.OleDb.OleDbType.VarWChar, 10, "Zip"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ContactAddressID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactAddressID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address11", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanMailReminder", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanMailReminder", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactOwnerCd", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_State1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "State", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Zip1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'da_Phone
        '
        Me.da_Phone.DeleteCommand = Me.OleDbDeleteCommand3
        Me.da_Phone.InsertCommand = Me.OleDbInsertCommand3
        Me.da_Phone.SelectCommand = Me.da_Phone_SelectComm
        Me.da_Phone.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbContactPhone", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CanTextMessage", "CanTextMessage"), New System.Data.Common.DataColumnMapping("ContactOwnerCd", "ContactOwnerCd"), New System.Data.Common.DataColumnMapping("ContactPhoneID", "ContactPhoneID"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("PatientID", "PatientID"), New System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"), New System.Data.Common.DataColumnMapping("PhoneTypeCd", "PhoneTypeCd"), New System.Data.Common.DataColumnMapping("PTTExt", "PTTExt")})})
        Me.da_Phone.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM tbContactPhone WHERE (ContactPhoneID = ?) AND (CanTextMessage = ?) AN" & _
        "D (ContactOwnerCd = ?) AND (LastEditDate = ? OR ? IS NULL AND LastEditDate IS NU" & _
        "LL) AND (LastEditLoginID = ? OR ? IS NULL AND LastEditLoginID IS NULL) AND (PTTE" & _
        "xt = ? OR ? IS NULL AND PTTExt IS NULL) AND (PatientID = ?) AND (PhoneNumber = ?" & _
        ") AND (PhoneTypeCd = ?)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ContactPhoneID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactPhoneID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanTextMessage", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanTextMessage", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactOwnerCd", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PTTExt", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PTTExt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PTTExt1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PTTExt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneTypeCd", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneTypeCd", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO tbContactPhone(CanTextMessage, ContactOwnerCd, LastEditDate, LastEdit" & _
        "LoginID, PatientID, PhoneNumber, PhoneTypeCd, PTTExt) VALUES (?, ?, ?, ?, ?, ?, " & _
        "?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanTextMessage", System.Data.OleDb.OleDbType.Boolean, 2, "CanTextMessage"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, "ContactOwnerCd"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.Integer, 0, "PatientID"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 10, "PhoneNumber"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhoneTypeCd", System.Data.OleDb.OleDbType.SmallInt, 0, "PhoneTypeCd"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PTTExt", System.Data.OleDb.OleDbType.VarWChar, 10, "PTTExt"))
        '
        'da_Phone_SelectComm
        '
        Me.da_Phone_SelectComm.CommandText = "SELECT CanTextMessage, ContactOwnerCd, ContactPhoneID, LastEditDate, LastEditLogi" & _
        "nID, PatientID, PhoneNumber, PhoneTypeCd, PTTExt FROM tbContactPhone"
        Me.da_Phone_SelectComm.Connection = Me.OleDbConnection2
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE tbContactPhone SET CanTextMessage = ?, ContactOwnerCd = ?, LastEditDate = " & _
        "?, LastEditLoginID = ?, PatientID = ?, PhoneNumber = ?, PhoneTypeCd = ?, PTTExt " & _
        "= ? WHERE (ContactPhoneID = ?) AND (CanTextMessage = ?) AND (ContactOwnerCd = ?)" & _
        " AND (LastEditDate = ? OR ? IS NULL AND LastEditDate IS NULL) AND (LastEditLogin" & _
        "ID = ? OR ? IS NULL AND LastEditLoginID IS NULL) AND (PTTExt = ? OR ? IS NULL AN" & _
        "D PTTExt IS NULL) AND (PatientID = ?) AND (PhoneNumber = ?) AND (PhoneTypeCd = ?" & _
        ")"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CanTextMessage", System.Data.OleDb.OleDbType.Boolean, 2, "CanTextMessage"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, "ContactOwnerCd"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.Integer, 0, "PatientID"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 10, "PhoneNumber"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PhoneTypeCd", System.Data.OleDb.OleDbType.SmallInt, 0, "PhoneTypeCd"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("PTTExt", System.Data.OleDb.OleDbType.VarWChar, 10, "PTTExt"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ContactPhoneID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactPhoneID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CanTextMessage", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CanTextMessage", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ContactOwnerCd", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactOwnerCd", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PTTExt", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PTTExt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PTTExt1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PTTExt", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PatientID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneNumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PhoneTypeCd", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PhoneTypeCd", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmPatCtsEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(788, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Tab1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.btnMoveCtMthdDn)
        Me.Controls.Add(Me.btnMoveCtMthdUp)
        Me.Controls.Add(Me.lvwCtMthdSlf2)
        Me.Controls.Add(Me.lvwCtMthdSlf1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPatCtsEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing Contact Info"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab1.ResumeLayout(False)
        Me.Tab1P1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.Tab1P2.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FormActivated As Boolean = False
    Dim conn As OleDbConnection
    Dim lvwCtMthdSlf2IsDirty As Boolean = False

    Private Sub frmPatCtsEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Need the following to Retrieve Microsoft Access Autonumber Value
        'for: xLvwIdx = Me.txtVisitID.Text on save
        conn = New OleDbConnection
        conn.ConnectionString = strConn
        AddHandler da1.RowUpdated, AddressOf da1_OnRowUpdate

        'txtCtsSlfMySpaceDisplayName.DataBindings.Add("Rtf", Me.ds, "tbPatientContactInfo.MySpaceDisplayName")


        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            'FillCheckBoxes(Me, Me.ds.tbPatientContactInfo, "chk", 2)

            'If bind txtCtsSlfMySpaceDisplayName directly to the data column, the data always gets editted
            'even though the user didn't do anything, and thus prompts if you want to save change upon exit!!!
            'This way, along with the code in txtCtsSlfMySpaceDisplayName_TextChanged it won't!           
            'If Not Me.ds.tbPatientContactInfo.Item(0).IsMySpaceDisplayNameNull Then
            'txtCtsSlfMySpaceDisplayName.Rtf = Me.ds.tbPatientContactInfo.Item(0).MySpaceDisplayName
            'End If
        Else
            'Me.BindingContext(Me.ds, "tbPatientContactInfo").AddNew()
            ''Need this after AddNew
            'Me.BindingContext(Me.ds, "tbPatientContactInfo").Position = 0
            'With vfrmPatient
            ''Me.ds.tbPatientContactInfo.Item(0).PatientID = .lvw0.SelectedItems(0).SubItems(.lvw0.Columns.Count - 1).Text
            'Me.ds.tbPatientContactInfo.Rows(0).Item("PatientID") = .lvw0.SelectedItems(0).SubItems(.lvw0.Columns.Count - 1).Text
            'End With

            Me.BindingContext(Me.ds.tbContactAddress).AddNew()
            Me.BindingContext(Me.ds.tbContactAddress).Position = 0
            Me.BindingContext(Me.ds.tbContactPhoneHome).AddNew()
            Me.BindingContext(Me.ds.tbContactPhoneHome).Position = 0
            Me.BindingContext(Me.ds.tbContactPhoneCell).AddNew()
            Me.BindingContext(Me.ds.tbContactPhoneCell).Position = 0
            With vfrmPatient
                Dim PatID As Integer = .lvw0.SelectedItems(0).SubItems(.lvw0.Columns.Count - 1).Text
                With Me.ds.tbContactAddress.Item(0)
                    .PatientID = PatID
                    .ContactOwnerCd = 1
                End With
                With Me.ds.tbContactPhoneHome.Item(0)
                    .PatientID = PatID
                    .ContactOwnerCd = 1
                    .PhoneTypeCd = 1
                End With
                With Me.ds.tbContactPhoneCell.Item(0)
                    .PatientID = PatID
                    .ContactOwnerCd = 1
                    .PhoneTypeCd = 2
                End With
            End With
        End If
        Fill_lvwCtMthdSlf2()
        Fill_lvwCtMthdSlf1()
        En_Disable_btnMoveUpDown(Me.lvwCtMthdSlf2, Me.btnMoveCtMthdUp, Me.btnMoveCtMthdDn)
        Me.txtCtsSlfAddress.TabIndex = 0

    End Sub

    Private Sub frmPatCtsEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub
    Private Sub frmPatCtsEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmPatCtsEdit = Nothing
    End Sub

    Private Sub da1_OnRowUpdate(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)

        'If vb.Left(Me.Text.ToString, 6) = "Adding" Then
        If e.StatementType = StatementType.Insert Then
            Dim oCmd As New OleDbCommand("SELECT @@IDENTITY")
            oCmd.Connection = conn
            e.Row("PatientContactInfoID") = oCmd.ExecuteScalar()
            e.Row.AcceptChanges()
            'MsgBox(e.Row("VisitID"))
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Try
            Dim resp As MsgBoxResult
            If vb.Left(Me.Text.ToString, 6) = "Adding" Then
                resp = MsgBox("Do you want to add the contact info for the selected patient?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then

                    If ValidationPassed() Then
                        txtLastEditDate.Text = System.DateTime.Now
                        'Me.BindingContext(Me.ds, "tbPatientContactInfo").EndCurrentEdit()
                        'UpdateDataSourceAddNew(Me.ds, "tbPatientContactInfo", conn, Me.da1)

                        Me.BindingContext(Me.ds.tbContactAddress).EndCurrentEdit()
                        UpdateDataSourceAddNew(Me.ds, "tbContactAddress", conn, Me.da_Address)
                        Me.BindingContext(Me.ds.tbContactPhoneHome).EndCurrentEdit()
                        UpdateDataSourceAddNew(Me.ds, "tbContactPhoneHome", conn, Me.da_Phone)
                        Me.BindingContext(Me.ds.tbContactPhoneCell).EndCurrentEdit()
                        UpdateDataSourceAddNew(Me.ds, "tbContactPhoneCell", conn, Me.da_Phone)

                        CloseAndUpdate()
                    End If

                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If

            Else

                'Dim objDataSetChanges As DataSet1 = New DataSet1
                'Me.BindingContext(Me.ds, "tbPatientContactInfo").EndCurrentEdit()
                'objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)
                'If (Not (objDataSetChanges) Is Nothing) Or lvwCtMthdSlf2IsDirty Then

                'Dim ContactAddressChanged As DataSet1 = New DataSet1
                'Me.BindingContext(Me.ds.tbContactAddress).EndCurrentEdit()
                'ContactAddressChanged = CType(Me.ds.GetChanges, DataSet1)

                Dim ContactPhoneHomeChanged As DataSet1 = New DataSet1
                Me.BindingContext(Me.ds.tbContactPhoneHome).EndCurrentEdit()
                ContactPhoneHomeChanged = CType(Me.ds.GetChanges, DataSet1)

                'Dim ContactPhoneCellChanged As DataSet1 = New DataSet1
                'Me.BindingContext(Me.ds.tbContactPhoneCell).EndCurrentEdit()
                'ContactPhonecellChanged = CType(Me.ds.GetChanges, DataSet1)

                If (Not (ContactPhoneHomeChanged) Is Nothing) Or _
                   lvwCtMthdSlf2IsDirty Then
                    resp = MsgBox("Do you want to save your changes?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                    If resp = MsgBoxResult.Yes Then

                        If ValidationPassed() Then
                            'Must cancel edit first
                            'Me.BindingContext(Me.ds, "tbPatientContactInfo").CancelCurrentEdit()
                            'txtLastEditDate.Text = System.DateTime.Now
                            'Me.BindingContext(Me.ds, "tbPatientContactInfo").EndCurrentEdit()
                            'objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)
                            'UpdateDataSource(objDataSetChanges, conn, Me.da1)
                            'CloseAndUpdate()

                            'Me.BindingContext(Me.ds.tbContactAddress).EndCurrentEdit()
                            'UpdateDataSource(ContactAddressChanged, conn, Me.da_Address)
                            Me.BindingContext(Me.ds.tbContactPhoneHome).EndCurrentEdit()
                            UpdateDataSource(ContactPhoneHomeChanged, conn, Me.da_Phone)
                            'Me.BindingContext(Me.ds.tbContactPhoneCell).EndCurrentEdit()
                            'UpdateDataSource(ContactPhoneCellChanged, conn, Me.da_Phone)
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
    End Function

    Private Sub CloseAndUpdate()

        Cursor.Current = Cursors.WaitCursor

        If lvwCtMthdSlf2IsDirty Then Update_tbPatientContactChoice()

        Me.Close()
        With vfrmPatient
            .Update_tabCts()
        End With

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub Update_tbPatientContactChoice()

        Dim ContactInfoID As Integer = Me.ds.tbPatientContactInfo.Item(0).PatientContactInfoID

        RunSQL("DELETE * FROM tbPatientContactChoice WHERE PatientContactInfoID=" & ContactInfoID)

        For Each itm As ListViewItem In Me.lvwCtMthdSlf2.Items
            RunSQL("INSERT INTO tbPatientContactChoice " & _
                  "(PatientContactInfoID, ContactChoice, ContactMethodCd, LastEditDate) " & _
                   "VALUES (" & ContactInfoID & ", " & _
                                itm.SubItems(1).Text & ", " & _
                                itm.SubItems(2).Text & ", NOW)")
        Next

    End Sub

    Private Sub Fill_lvwCtMthdSlf2()
        Dim PatID As Integer, strSQL As String
        With vfrmPatient
            PatID = .lvw0.SelectedItems(0).SubItems(.lvw0.Columns.Count - 1).Text
        End With

        strSQL = "SELECT ContactMethodDesc, ContactChoice, tbPatientContactChoice.ContactMethodCd " & _
                 "FROM (tbPatientContactChoice LEFT JOIN tbPatientContactInfo " & _
                        "ON tbPatientContactChoice.PatientContactInfoID = tbPatientContactInfo.PatientContactInfoID) " & _
                        "LEFT JOIN ddvContactMethod " & _
                        "ON tbPatientContactChoice.ContactMethodCd = ddvContactMethod.ContactMethodCd " & _
                 "WHERE PatientID=" & PatID & _
                " ORDER BY ContactChoice"
        Fill_lvw(Me.lvwCtMthdSlf2, strSQL, , , True)
    End Sub

    Private Sub Fill_lvwCtMthdSlf1()

        Dim strSQL As String
        strSQL = "SELECT ContactMethodDesc, ddvContactMethod.ContactMethodCd " & _
                 "FROM ddvContactMethod " & _
                 "WHERE Active<0 AND ForWho='" & vfrmPatient.tabCts.SelectedIndex & "'"
        If lvwCtMthdSlf2.Items.Count > 0 Then
            strSQL = strSQL & " AND " & _
                       "ddvContactMethod.ContactMethodCd Not In (" & LvwItems(lvwCtMthdSlf2, 2, False) & ")"
        End If
        Fill_lvw(Me.lvwCtMthdSlf1, strSQL)

    End Sub

    Private Sub lvw_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) _
            Handles lvwCtMthdSlf1.ItemCheck, lvwCtMthdSlf2.ItemCheck

        If FormActivated Then
            Select Case sender.name
                Case "lvwCtMthdSlf1"
                    If Me.ActiveControl.Name = "lvwCtMthdSlf1" Then
                        'LvwMoveOne(lvwCtMthdSlf1, lvwCtMthdSlf2)
                        With Me.lvwCtMthdSlf1
                            If .Items.Count = 0 Then
                                MsgBox("Sorry, There are NO items in the list!", vbOKOnly + vbInformation)
                                Exit Sub
                            End If
                            .Items(e.Index).Selected = True 'need this!
                            Dim item As ListViewItem = .SelectedItems(0)
                            Dim newItem As New ListViewItem
                            With newItem
                                .Text = item.Text
                                .Checked = True
                                .SubItems.Add(lvwCtMthdSlf2.Items.Count + 1)
                                .SubItems.Add(item.SubItems(1).Text)
                            End With
                            With lvwCtMthdSlf2
                                .Items.Add(newItem)
                                .Items(.Items.Count - 1).Selected = True
                            End With

                            'Then remove the item from this list.
                            Dim RemovedItemIndex As Integer = item.Index
                            item.Remove()

                            lvw_ItemCheck2()
                        End With
                    End If
                Case "lvwCtMthdSlf2"
                    If Me.ActiveControl.Name = "lvwCtMthdSlf2" Then
                        With Me.lvwCtMthdSlf2
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
                            lvwCtMthdSlf1.Items.Add(newItem)

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

    End Sub

    Private Sub lvw_ItemCheck2()
        lvwCtMthdSlf2IsDirty = True
        ShowTotalOnLvw(lvwCtMthdSlf1, 0)
        ShowTotalOnLvw(lvwCtMthdSlf2, 0)
        En_Disable_btnMoveUpDown(Me.lvwCtMthdSlf2, Me.btnMoveCtMthdUp, Me.btnMoveCtMthdDn)
    End Sub

    Private Sub btnUpDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles btnMoveCtMthdUp.Click, btnMoveCtMthdDn.Click

        Dim MoveDirection As Short
        If sender.name = "btnMoveCtMthdUp" Then
            MoveDirection = -1
        Else
            MoveDirection = 1
        End If
        MoveListViewItem(lvwCtMthdSlf2, MoveDirection)
        En_Disable_btnMoveUpDown(lvwCtMthdSlf2, Me.btnMoveCtMthdUp, Me.btnMoveCtMthdDn)
        lvwCtMthdSlf2IsDirty = True

    End Sub


    Private Sub lvwCtMthdSlf2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwCtMthdSlf2.Click
        En_Disable_btnMoveUpDown(Me.lvwCtMthdSlf2, Me.btnMoveCtMthdUp, Me.btnMoveCtMthdDn)
    End Sub

    Private Sub lvwCtMthdSlf2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwCtMthdSlf2.KeyUp
        lvwCtMthdSlf2_Click(sender, e)
    End Sub

    Private Sub chk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk1.Click, chk2.Click
        If FormActivated Then
            Select Case sender.name
                Case "chk1"
                    Me.ds.tbPatientContactInfo.Item(0).CanMailReminder = chk1.Checked
                Case "chk2"
                    Me.ds.tbPatientContactInfo.Item(0).CanTextMessage = chk2.Checked
            End Select
        End If
    End Sub

    Private Sub cboCtsSlfState_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCtsSlfState.SelectedValueChanged
        If FormActivated Then
            'Me.ds.tbPatientContactInfo.Item(0).State = cboCtsSlfState.Text
            Me.ds.tbContactAddress.Item(0).State = cboCtsSlfState.Text
        End If
    End Sub

    Private Sub txtCtsSlfMySpaceDisplayName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCtsSlfMySpaceDisplayName.TextChanged
        If FormActivated Then
            Me.ds.tbPatientContactInfo.Item(0).MySpaceDisplayName = txtCtsSlfMySpaceDisplayName.Rtf
        End If
    End Sub
End Class
