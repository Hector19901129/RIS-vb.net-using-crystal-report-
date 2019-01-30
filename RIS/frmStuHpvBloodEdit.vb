Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb

Public Class frmStuHpvBloodEdit
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
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLastEditDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEpisodeID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents da1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents da1SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents dtsTime1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtsTime2 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtsTime3 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dts1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dts3 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dts2 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents mskNumSerum As FlxMaskBox.FlexMaskEditBox
    Friend WithEvents cboNumSerum As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ds = New RIS.DataSet1
        Me.btnExit = New System.Windows.Forms.Button
        Me.da1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.da1SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLastEditDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtEpisodeID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtsTime1 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dtsTime2 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dtsTime3 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dts1 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dts3 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.dts2 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.mskNumSerum = New FlxMaskBox.FlexMaskEditBox
        Me.cboNumSerum = New System.Windows.Forms.ComboBox
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ds
        '
        Me.ds.DataSetName = "DataSet1"
        Me.ds.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 1
        Me.btnExit.Location = New System.Drawing.Point(377, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 20)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'da1
        '
        Me.da1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.da1.InsertCommand = Me.OleDbInsertCommand1
        Me.da1.SelectCommand = Me.da1SelectComm
        Me.da1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbStuHpvPatVisitBlood", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BloodDrawnDate", "BloodDrawnDate"), New System.Data.Common.DataColumnMapping("BloodDrawnTime", "BloodDrawnTime"), New System.Data.Common.DataColumnMapping("BloodID", "BloodID"), New System.Data.Common.DataColumnMapping("BloodSpunDate", "BloodSpunDate"), New System.Data.Common.DataColumnMapping("BloodSpunTime", "BloodSpunTime"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("SerumExtractedDate", "SerumExtractedDate"), New System.Data.Common.DataColumnMapping("SerumExtractedTime", "SerumExtractedTime"), New System.Data.Common.DataColumnMapping("VisitProcActID", "VisitProcActID")})})
        Me.da1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM tbStuHpvPatVisitBlood WHERE (BloodID = ?) AND (BloodDrawnDate = ? OR " & _
        "? IS NULL AND BloodDrawnDate IS NULL) AND (BloodDrawnTime = ? OR ? IS NULL AND B" & _
        "loodDrawnTime IS NULL) AND (BloodSpunDate = ? OR ? IS NULL AND BloodSpunDate IS " & _
        "NULL) AND (BloodSpunTime = ? OR ? IS NULL AND BloodSpunTime IS NULL) AND (LastEd" & _
        "itDate = ? OR ? IS NULL AND LastEditDate IS NULL) AND (LastEditLoginID = ? OR ? " & _
        "IS NULL AND LastEditLoginID IS NULL) AND (SerumExtractedDate = ? OR ? IS NULL AN" & _
        "D SerumExtractedDate IS NULL) AND (SerumExtractedTime = ? OR ? IS NULL AND Serum" & _
        "ExtractedTime IS NULL) AND (VisitProcActID = ?)"
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodDrawnDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodDrawnDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodDrawnDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodDrawnDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodDrawnTime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodDrawnTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodDrawnTime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodDrawnTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodSpunDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodSpunDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodSpunDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodSpunDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodSpunTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodSpunTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodSpunTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodSpunTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerumExtractedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerumExtractedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerumExtractedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerumExtractedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerumExtractedTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerumExtractedTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerumExtractedTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerumExtractedTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VisitProcActID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitProcActID", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO tbStuHpvPatVisitBlood(BloodDrawnDate, BloodDrawnTime, BloodSpunDate, " & _
        "BloodSpunTime, LastEditDate, LastEditLoginID, SerumExtractedDate, SerumExtracted" & _
        "Time, VisitProcActID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BloodDrawnDate", System.Data.OleDb.OleDbType.DBDate, 0, "BloodDrawnDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BloodDrawnTime", System.Data.OleDb.OleDbType.VarWChar, 25, "BloodDrawnTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BloodSpunDate", System.Data.OleDb.OleDbType.DBDate, 0, "BloodSpunDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BloodSpunTime", System.Data.OleDb.OleDbType.VarWChar, 50, "BloodSpunTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SerumExtractedDate", System.Data.OleDb.OleDbType.DBDate, 0, "SerumExtractedDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SerumExtractedTime", System.Data.OleDb.OleDbType.VarWChar, 50, "SerumExtractedTime"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("VisitProcActID", System.Data.OleDb.OleDbType.Integer, 0, "VisitProcActID"))
        '
        'da1SelectComm
        '
        Me.da1SelectComm.CommandText = "SELECT BloodDrawnDate, BloodDrawnTime, BloodID, BloodSpunDate, BloodSpunTime, Las" & _
        "tEditDate, LastEditLoginID, SerumExtractedDate, SerumExtractedTime, VisitProcAct" & _
        "ID FROM tbStuHpvPatVisitBlood"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE tbStuHpvPatVisitBlood SET BloodDrawnDate = ?, BloodDrawnTime = ?, BloodSpu" & _
        "nDate = ?, BloodSpunTime = ?, LastEditDate = ?, LastEditLoginID = ?, SerumExtrac" & _
        "tedDate = ?, SerumExtractedTime = ?, VisitProcActID = ? WHERE (BloodID = ?) AND " & _
        "(BloodDrawnDate = ? OR ? IS NULL AND BloodDrawnDate IS NULL) AND (BloodDrawnTime" & _
        " = ? OR ? IS NULL AND BloodDrawnTime IS NULL) AND (BloodSpunDate = ? OR ? IS NUL" & _
        "L AND BloodSpunDate IS NULL) AND (BloodSpunTime = ? OR ? IS NULL AND BloodSpunTi" & _
        "me IS NULL) AND (LastEditDate = ? OR ? IS NULL AND LastEditDate IS NULL) AND (La" & _
        "stEditLoginID = ? OR ? IS NULL AND LastEditLoginID IS NULL) AND (SerumExtractedD" & _
        "ate = ? OR ? IS NULL AND SerumExtractedDate IS NULL) AND (SerumExtractedTime = ?" & _
        " OR ? IS NULL AND SerumExtractedTime IS NULL) AND (VisitProcActID = ?)"
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BloodDrawnDate", System.Data.OleDb.OleDbType.DBDate, 0, "BloodDrawnDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BloodDrawnTime", System.Data.OleDb.OleDbType.VarWChar, 25, "BloodDrawnTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BloodSpunDate", System.Data.OleDb.OleDbType.DBDate, 0, "BloodSpunDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BloodSpunTime", System.Data.OleDb.OleDbType.VarWChar, 50, "BloodSpunTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SerumExtractedDate", System.Data.OleDb.OleDbType.DBDate, 0, "SerumExtractedDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SerumExtractedTime", System.Data.OleDb.OleDbType.VarWChar, 50, "SerumExtractedTime"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("VisitProcActID", System.Data.OleDb.OleDbType.Integer, 0, "VisitProcActID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodDrawnDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodDrawnDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodDrawnDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodDrawnDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodDrawnTime", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodDrawnTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodDrawnTime1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodDrawnTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodSpunDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodSpunDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodSpunDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodSpunDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodSpunTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodSpunTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BloodSpunTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BloodSpunTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerumExtractedDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerumExtractedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerumExtractedDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerumExtractedDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerumExtractedTime", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerumExtractedTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SerumExtractedTime1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerumExtractedTime", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VisitProcActID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VisitProcActID", System.Data.DataRowVersion.Original, Nothing))
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
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label60.Location = New System.Drawing.Point(12, 49)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(145, 15)
        Me.Label60.TabIndex = 77
        Me.Label60.Text = "Blood Spun Date/Time"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 15)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Serum Extracted Date/Time"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Blood Drawn Date/Time"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLastEditDate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtEpisodeID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(192, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 75)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        '
        'txtLastEditDate
        '
        Me.txtLastEditDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastEditDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitBlood.LastEditDate"))
        Me.txtLastEditDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastEditDate.ForeColor = System.Drawing.Color.DimGray
        Me.txtLastEditDate.Location = New System.Drawing.Point(88, 45)
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
        Me.Label7.Location = New System.Drawing.Point(8, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Last Edit Date"
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
        'txtEpisodeID
        '
        Me.txtEpisodeID.BackColor = System.Drawing.SystemColors.Control
        Me.txtEpisodeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitBlood.VisitProcActID"))
        Me.txtEpisodeID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpisodeID.ForeColor = System.Drawing.Color.DimGray
        Me.txtEpisodeID.Location = New System.Drawing.Point(88, 16)
        Me.txtEpisodeID.Name = "txtEpisodeID"
        Me.txtEpisodeID.ReadOnly = True
        Me.txtEpisodeID.Size = New System.Drawing.Size(130, 21)
        Me.txtEpisodeID.TabIndex = 92
        Me.txtEpisodeID.TabStop = False
        Me.txtEpisodeID.Text = "VisitProcActID"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(10, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "VisitProcActID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtsTime1
        '
        Me.dtsTime1.CustomFormat = "hh:mm tt"
        Me.dtsTime1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsTime1.Location = New System.Drawing.Point(276, 13)
        Me.dtsTime1.Name = "dtsTime1"
        Me.dtsTime1.ShowCheckBox = True
        Me.dtsTime1.ShowUpDown = True
        Me.dtsTime1.Size = New System.Drawing.Size(92, 21)
        Me.dtsTime1.TabIndex = 1
        Me.dtsTime1.Tag = "BloodDrawnTime"
        Me.dtsTime1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'dtsTime2
        '
        Me.dtsTime2.CustomFormat = "hh:mm tt"
        Me.dtsTime2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsTime2.Location = New System.Drawing.Point(276, 43)
        Me.dtsTime2.Name = "dtsTime2"
        Me.dtsTime2.ShowCheckBox = True
        Me.dtsTime2.ShowUpDown = True
        Me.dtsTime2.Size = New System.Drawing.Size(92, 21)
        Me.dtsTime2.TabIndex = 3
        Me.dtsTime2.Tag = "BloodSpunTime"
        Me.dtsTime2.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'dtsTime3
        '
        Me.dtsTime3.CustomFormat = "hh:mm tt"
        Me.dtsTime3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsTime3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsTime3.Location = New System.Drawing.Point(276, 75)
        Me.dtsTime3.Name = "dtsTime3"
        Me.dtsTime3.ShowCheckBox = True
        Me.dtsTime3.ShowUpDown = True
        Me.dtsTime3.Size = New System.Drawing.Size(92, 21)
        Me.dtsTime3.TabIndex = 5
        Me.dtsTime3.Tag = "SerumExtractedTime"
        Me.dtsTime3.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 15)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Number of Aliquots Obtained"
        '
        'dts1
        '
        Me.dts1.CustomFormat = "MM/dd/yyyy"
        Me.dts1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dts1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dts1.Location = New System.Drawing.Point(170, 13)
        Me.dts1.Name = "dts1"
        Me.dts1.ShowCheckBox = True
        Me.dts1.Size = New System.Drawing.Size(100, 21)
        Me.dts1.TabIndex = 0
        Me.dts1.Tag = "BloodDrawnDate"
        Me.dts1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'dts3
        '
        Me.dts3.CustomFormat = "MM/dd/yyyy"
        Me.dts3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dts3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dts3.Location = New System.Drawing.Point(170, 75)
        Me.dts3.Name = "dts3"
        Me.dts3.ShowCheckBox = True
        Me.dts3.Size = New System.Drawing.Size(100, 21)
        Me.dts3.TabIndex = 4
        Me.dts3.Tag = "SerumExtractedDate"
        Me.dts3.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'dts2
        '
        Me.dts2.CustomFormat = "MM/dd/yyyy"
        Me.dts2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dts2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dts2.Location = New System.Drawing.Point(170, 44)
        Me.dts2.Name = "dts2"
        Me.dts2.ShowCheckBox = True
        Me.dts2.Size = New System.Drawing.Size(100, 21)
        Me.dts2.TabIndex = 2
        Me.dts2.Tag = "BloodSpunDate"
        Me.dts2.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'mskNumSerum
        '
        Me.mskNumSerum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mskNumSerum.Location = New System.Drawing.Point(269, 114)
        Me.mskNumSerum.Mask = "#"
        Me.mskNumSerum.Name = "mskNumSerum"
        Me.mskNumSerum.Size = New System.Drawing.Size(33, 20)
        Me.mskNumSerum.TabIndex = 113
        Me.mskNumSerum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskNumSerum.Visible = False
        '
        'cboNumSerum
        '
        Me.cboNumSerum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbPatient.Gender"))
        Me.cboNumSerum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNumSerum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNumSerum.ItemHeight = 13
        Me.cboNumSerum.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboNumSerum.Location = New System.Drawing.Point(170, 114)
        Me.cboNumSerum.Name = "cboNumSerum"
        Me.cboNumSerum.Size = New System.Drawing.Size(41, 21)
        Me.cboNumSerum.TabIndex = 114
        '
        'frmStuHpvBloodEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboNumSerum)
        Me.Controls.Add(Me.mskNumSerum)
        Me.Controls.Add(Me.dts2)
        Me.Controls.Add(Me.dts3)
        Me.Controls.Add(Me.dts1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtsTime3)
        Me.Controls.Add(Me.dtsTime2)
        Me.Controls.Add(Me.dtsTime1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStuHpvBloodEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing Blood"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FormActivated As Boolean = False
    Dim conn As OleDbConnection
    Dim NumSerumOldValue As Short

    Private Sub frmStuHpvBloodEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Need the following to Retrieve Microsoft Access Autonumber Value
            'for: xLvwIdx = Me.txtVisitID.Text on save
            conn = New OleDbConnection
            conn.ConnectionString = strConn
            AddHandler da1.RowUpdated, AddressOf da1_OnRowUpdate

            With vfrmPatient
                If vb.Left(Me.Text.ToString, 7) = "Editing" Then
                    'cboNumSerum.Text = LookUp("COUNT(*)", "tbStuHpvPatVisitBloodAliquot", _
                    '"BloodID=" & Me.ds.tbStuHpvPatVisitBlood.Item(0).BloodID)
                    With .txtHpvBlood4
                        If .Text.Length > 0 Then
                            cboNumSerum.Text = .Text
                        Else
                            cboNumSerum.Text = 0
                        End If
                    End With
                    NumSerumOldValue = Me.cboNumSerum.Text
                Else
                    Me.BindingContext(Me.ds, "tbStuHpvPatVisitBlood").AddNew()
                    Me.BindingContext(Me.ds, "tbStuHpvPatVisitBlood").Position = 0
                    Me.ds.tbStuHpvPatVisitBlood.Item(0).VisitProcActID = .txtHpvBloodVisitProcActID.Text
                End If
                FillDateTimeSlickers(Me, Me.ds.tbStuHpvPatVisitBlood, "dts", 3, .lvwHpvVst.SelectedItems(0).SubItems(2).Text) 'Default to visit date
                FillDateTimeSlickersTime(Me, Me.ds.tbStuHpvPatVisitBlood, "dtsTime", 3, "11:00 AM")
            End With

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub da1_OnRowUpdate(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)

        'If vb.Left(Me.Text.ToString, 6) = "Adding" Then
        If e.StatementType = StatementType.Insert Then
            Dim oCmd As New OleDbCommand("SELECT @@IDENTITY")
            oCmd.Connection = conn
            e.Row("BloodID") = oCmd.ExecuteScalar()
            e.Row.AcceptChanges()
            'MsgBox(e.Row("VisitID"))
        End If

    End Sub

    Private Sub frmStuHpvBloodEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub

    Private Sub frmStuHpvBloodEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmStuHpvBloodEdit = Nothing
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'MsgBox(Me.ds.tbStuHpvPatVisitBlood.Item(0).TimeBloodDrawn)
        Try
            Dim resp As MsgBoxResult
            If vb.Left(Me.Text.ToString, 6) = "Adding" Then
                resp = MsgBox("Do you want to add this Blood info to the selected visit?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then

                    If ValidationPassed() Then
                        'MsgBox(System.DateTime.Now.ToString)
                        txtLastEditDate.Text = System.DateTime.Now.ToLongDateString
                        Me.BindingContext(Me.ds, "tbStuHpvPatVisitBlood").EndCurrentEdit()

                        UpdateDataSourceAddNew(Me.ds, "tbStuHpvPatVisitBlood", conn, Me.da1)
                        CloseAndUpdate()

                    End If

                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If

            Else

                Dim objDataSetChanges As DataSet1 = New DataSet1
                Me.BindingContext(Me.ds, "tbStuHpvPatVisitBlood").EndCurrentEdit()
                objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)
                If Not (objDataSetChanges) Is Nothing Or Me.cboNumSerum.Text <> NumSerumOldValue Then
                    resp = MsgBox("Do you want to save your changes?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                    If resp = MsgBoxResult.Yes Then

                        If ValidationPassed() Then
                            'Must cancel edit first
                            Me.BindingContext(Me.ds, "tbStuHpvPatVisitBlood").CancelCurrentEdit()
                            txtLastEditDate.Text = System.DateTime.Now
                            Me.BindingContext(Me.ds, "tbStuHpvPatVisitBlood").EndCurrentEdit()
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

    End Function

    Private Sub CloseAndUpdate()

        Cursor.Current = Cursors.WaitCursor

        If vb.Left(Me.Text.ToString, 6) = "Adding" Then
            If Me.cboNumSerum.Text.Length > 0 Then
                If Me.cboNumSerum.Text > 0 Then Update_tbStuHpvPatVisitBloodAliquot()
            End If
        Else
            If Me.cboNumSerum.Text <> NumSerumOldValue Then Update_tbStuHpvPatVisitBloodAliquot()
        End If

        Me.Close()
        With vfrmPatient
            .Update_tabHpvVst()
        End With

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub dtsTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles dtsTime1.TextChanged, dtsTime2.TextChanged, dtsTime3.TextChanged
        If FormActivated Then
            With Me.ds.tbStuHpvPatVisitBlood.Item(0)
                Select Case sender.name
                    Case "dtsTime1"
                        .BloodDrawnTime = dtsTime1.Text
                    Case "dtsTime2"
                        .BloodSpunTime = dtsTime2.Text
                    Case "dtsTime3"
                        .SerumExtractedTime = dtsTime3.Text
                End Select
            End With
        End If
    End Sub

    Private Sub dtsTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles dtsTime1.CheckedChanged, dtsTime2.CheckedChanged, dtsTime3.CheckedChanged
        If FormActivated Then
            With Me.ds.tbStuHpvPatVisitBlood.Item(0)
                Select Case sender.name
                    Case "dtsTime1"
                        Select Case dtsTime1.Checked
                            Case True
                                .BloodDrawnTime = dtsTime1.Text
                            Case False
                                .SetBloodDrawnTimeNull()
                        End Select
                    Case "dtsTime2"
                        Select Case dtsTime2.Checked
                            Case True
                                .BloodSpunTime = dtsTime2.Text
                            Case False
                                .SetBloodSpunTimeNull()
                        End Select
                    Case "dtsTime3"
                        Select Case dtsTime3.Checked
                            Case True
                                .SerumExtractedTime = dtsTime3.Text
                            Case False
                                .SetSerumExtractedTimeNull()
                        End Select
                End Select
            End With
        End If
    End Sub

    Private Sub dts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles dts1.CheckedChanged, dts2.CheckedChanged, dts3.CheckedChanged
        If FormActivated Then
            With Me.ds.tbStuHpvPatVisitBlood.Item(0)
                Select Case sender.name
                    Case "dts1"
                        Select Case dts1.Checked
                            Case True
                                If dts1.Value.ToString <> "" Then .BloodDrawnDate = dts1.Value
                                '.BloodDrawnDate = dts1.Value.ToString
                            Case False
                                .SetBloodDrawnDateNull()
                        End Select
                    Case "dts2"
                        Select Case dts2.Checked
                            Case True
                                If dts2.Value.ToString <> "" Then .BloodSpunDate = dts2.Value
                                '.BloodSpunDate = dts2.Value.ToString
                            Case False
                                .SetBloodSpunDateNull()
                        End Select
                    Case "dts3"
                        Select Case dts3.Checked
                            Case True
                                If dts3.Value.ToString <> "" Then .SerumExtractedDate = dts3.Value
                                '.SerumExtractedDate = dts3.Value.ToString
                            Case False
                                .SetSerumExtractedDateNull()
                        End Select
                End Select
            End With
        End If
    End Sub

    Private Sub dts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles dts1.TextChanged, dts2.TextChanged, dts3.TextChanged

        If FormActivated Then
            With Me.ds.tbStuHpvPatVisitBlood.Item(0)
                Select Case sender.name
                    Case "dts1"
                        .BloodDrawnDate = dts1.Value
                    Case "dts2"
                        .BloodSpunDate = dts2.Value
                    Case "dts3"
                        .SerumExtractedDate = dts3.Value
                End Select
            End With
        End If
    End Sub

    Private Sub Update_tbStuHpvPatVisitBloodAliquot()

        Dim BloodID As Integer = Me.ds.tbStuHpvPatVisitBlood.Item(0).BloodID
        RunSQL("DELETE * FROM tbStuHpvPatVisitBloodAliquot WHERE BloodID=" & BloodID)

        If cboNumSerum.Text > 0 Then
            For i As Short = 1 To Me.cboNumSerum.Text
                RunSQL("INSERT INTO tbStuHpvPatVisitBloodAliquot " & _
                      "(BloodID, AliquotID, LastEditDate) " & _
                       "VALUES (" & BloodID & ", " & i & ", NOW)")
            Next
        End If

    End Sub

End Class


