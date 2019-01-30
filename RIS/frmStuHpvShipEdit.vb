Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb

Public Class frmStuHpvShipEdit
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dts1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLastEditDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtShipmentID As System.Windows.Forms.TextBox
    Friend WithEvents da1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents da1SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ds = New RIS.DataSet1
        Me.btnExit = New System.Windows.Forms.Button
        Me.da1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.da1SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.Label4 = New System.Windows.Forms.Label
        Me.dts1 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLastEditDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPatientID = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtShipmentID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.btnExit.Location = New System.Drawing.Point(356, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 20)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'da1
        '
        Me.da1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.da1.InsertCommand = Me.OleDbInsertCommand1
        Me.da1.SelectCommand = Me.da1SelectComm
        Me.da1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbStuHpvPatVisitSpecShipped", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DateShipped", "DateShipped"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ShipmentID", "ShipmentID")})})
        Me.da1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM tbStuHpvPatVisitSpecShipped WHERE (ShipmentID = ?) AND (DateShipped =" & _
        " ?) AND (LastEditDate = ? OR ? IS NULL AND LastEditDate IS NULL) AND (LastEditLo" & _
        "ginID = ? OR ? IS NULL AND LastEditLoginID IS NULL) AND (Notes = ? OR ? IS NULL " & _
        "AND Notes IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ShipmentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipmentID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateShipped", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateShipped", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Notes1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing))
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
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO tbStuHpvPatVisitSpecShipped(DateShipped, LastEditDate, LastEditLoginI" & _
        "D, Notes) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateShipped", System.Data.OleDb.OleDbType.DBDate, 0, "DateShipped"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 255, "Notes"))
        '
        'da1SelectComm
        '
        Me.da1SelectComm.CommandText = "SELECT DateShipped, LastEditDate, LastEditLoginID, Notes, ShipmentID FROM tbStuHp" & _
        "vPatVisitSpecShipped"
        Me.da1SelectComm.Connection = Me.OleDbConnection2
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE tbStuHpvPatVisitSpecShipped SET DateShipped = ?, LastEditDate = ?, LastEdi" & _
        "tLoginID = ?, Notes = ? WHERE (ShipmentID = ?) AND (DateShipped = ?) AND (LastEd" & _
        "itDate = ? OR ? IS NULL AND LastEditDate IS NULL) AND (LastEditLoginID = ? OR ? " & _
        "IS NULL AND LastEditLoginID IS NULL) AND (Notes = ? OR ? IS NULL AND Notes IS NU" & _
        "LL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateShipped", System.Data.OleDb.OleDbType.DBDate, 0, "DateShipped"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, "LastEditDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, "LastEditLoginID"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 255, "Notes"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ShipmentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipmentID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateShipped", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateShipped", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Notes1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing))
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(10, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Date Shipped"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dts1
        '
        Me.dts1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dts1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dts1.Location = New System.Drawing.Point(94, 46)
        Me.dts1.Name = "dts1"
        Me.dts1.ShowCheckBox = True
        Me.dts1.Size = New System.Drawing.Size(99, 21)
        Me.dts1.TabIndex = 2
        Me.dts1.Tag = "DateShipped"
        Me.dts1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLastEditDate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtPatientID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtShipmentID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(170, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 97)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        '
        'txtLastEditDate
        '
        Me.txtLastEditDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastEditDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitSpecShipped.LastEditDate"))
        Me.txtLastEditDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastEditDate.ForeColor = System.Drawing.Color.DimGray
        Me.txtLastEditDate.Location = New System.Drawing.Point(88, 43)
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
        Me.Label7.Text = "Last Edit User"
        '
        'txtPatientID
        '
        Me.txtPatientID.BackColor = System.Drawing.SystemColors.Control
        Me.txtPatientID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitSpecShipped.LastEditLoginID"))
        Me.txtPatientID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.ForeColor = System.Drawing.Color.DimGray
        Me.txtPatientID.Location = New System.Drawing.Point(88, 70)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(130, 21)
        Me.txtPatientID.TabIndex = 87
        Me.txtPatientID.TabStop = False
        Me.txtPatientID.Text = "LastEditLoginID"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(8, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Last Edit Date"
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
        'txtShipmentID
        '
        Me.txtShipmentID.BackColor = System.Drawing.SystemColors.Control
        Me.txtShipmentID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitSpecShipped.ShipmentID"))
        Me.txtShipmentID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipmentID.ForeColor = System.Drawing.Color.DimGray
        Me.txtShipmentID.Location = New System.Drawing.Point(88, 16)
        Me.txtShipmentID.Name = "txtShipmentID"
        Me.txtShipmentID.ReadOnly = True
        Me.txtShipmentID.Size = New System.Drawing.Size(130, 21)
        Me.txtShipmentID.TabIndex = 92
        Me.txtShipmentID.TabStop = False
        Me.txtShipmentID.Text = "ShipmentID"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(8, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Shipment ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvPatVisitSpecShipped.Notes"))
        Me.txtNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(94, 77)
        Me.txtNotes.MaxLength = 255
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(302, 106)
        Me.txtNotes.TabIndex = 3
        Me.txtNotes.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(56, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Notes"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(17, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(314, 15)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Enter 'Date Shipped' ('Notes' is optional), then click 'Exit'."
        '
        'frmStuHpvShipEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(406, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dts1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStuHpvShipEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing Specimen Shipment"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FormActivated As Boolean = False
    Dim conn As OleDbConnection

    Private Sub frmStuHpvShipEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Need the following to Retrieve Microsoft Access Autonumber Value
        'for: xLvwIdx = Me.txtVisitID.Text on save
        conn = New OleDbConnection
        conn.ConnectionString = strConn
        AddHandler da1.RowUpdated, AddressOf da1_OnRowUpdate

        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            FillDateTimeSlickers(Me, Me.ds.tbStuHpvPatVisitSpecShipped, "dts", 1, Today)
        Else
            Me.BindingContext(Me.ds, "tbStuHpvPatVisitSpecShipped").AddNew()
            Me.BindingContext(Me.ds, "tbStuHpvPatVisitSpecShipped").Position = 0
          
            Me.ds.tbStuHpvPatVisitSpecShipped.Item(0).DateShipped = Today
            dts1.Text = Today
            dts1.Checked = True
        End If

        dts1.MaxDate = Today

    End Sub

    Private Sub frmStuHpvShipEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub

    Private Sub frmStuHpvShipEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmStuHpvShipEdit = Nothing
    End Sub

    Private Sub dts1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.TextChanged
        If FormActivated Then
            Me.ds.tbStuHpvPatVisitSpecShipped.Item(0).DateShipped = dts1.Value
        End If
    End Sub

    Private Sub dts1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dts1.CheckedChanged
        With Me.ds.tbStuHpvPatVisitSpecShipped.Item(0)
            If FormActivated Then
                Select Case dts1.Checked
                    Case True
                        .DateShipped = dts1.Value
                    Case False
                        .SetDateShippedNull()
                End Select
            End If
        End With
    End Sub

    Private Sub da1_OnRowUpdate(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)

        'If vb.Left(Me.Text.ToString, 6) = "Adding" Then
        If e.StatementType = StatementType.Insert Then
            Dim oCmd As New OleDbCommand("SELECT @@IDENTITY")
            oCmd.Connection = conn
            e.Row("ShipmentID") = oCmd.ExecuteScalar()
            e.Row.AcceptChanges()
            'MsgBox(e.Row("ShipmentID"))
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Try
            Dim resp As MsgBoxResult
            If vb.Left(Me.Text.ToString, 6) = "Adding" Then
                resp = MsgBox("Do you want to add this new shipment?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then

                    If ValidationPassed() Then
                        'MsgBox(System.DateTime.Now.ToString)
                        txtLastEditDate.Text = System.DateTime.Now
                        Me.BindingContext(Me.ds, "tbStuHpvPatVisitSpecShipped").EndCurrentEdit()

                        UpdateDataSourceAddNew(Me.ds, "tbStuHpvPatVisitSpecShipped", conn, Me.da1)
                        CloseAndUpdate()

                    End If

                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If

            Else

                Dim objDataSetChanges As DataSet1 = New DataSet1
                Me.BindingContext(Me.ds, "tbStuHpvPatVisitSpecShipped").EndCurrentEdit()
                objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)
                If Not (objDataSetChanges) Is Nothing Then
                    resp = MsgBox("Do you want to save your changes?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                    If resp = MsgBoxResult.Yes Then

                        If ValidationPassed() Then
                            'Must cancel edit first
                            Me.BindingContext(Me.ds, "tbStuHpvPatVisitSpecShipped").CancelCurrentEdit()
                            txtLastEditDate.Text = System.DateTime.Now
                            Me.BindingContext(Me.ds, "tbStuHpvPatVisitSpecShipped").EndCurrentEdit()
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

        If Me.dts1.Checked = False Then
            MsgBox("'Date Shipped' is required.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
            Me.dts1.Focus()
            Return False
            Exit Function
        End If

    End Function

    Private Sub CloseAndUpdate()

        If ValidationPassed() Then

            Try

                With vfrmStuHpvShip

                    If .tab0.SelectedIndex = 0 Then 'Tab Not Shipped Yet

                        Cursor.Current = Cursors.WaitCursor
                        If .lvwNS.Items.Count = 0 Then Exit Sub

                        'Create text file ShipDetails.txt with data to be inserted into 
                        'table tbStuHpvPatVisitSpecShippedDetails
                        FileOpen(1, appPath & "\DataToInsert.txt", OpenMode.Output, OpenAccess.Write)
                        'Write column name
                        Print(1, "VisitProcActID, ShipmentID" & vbNewLine)
                        For Each itm As ListViewItem In .lvwNS.Items
                            If itm.Checked Then
                                Print(1, itm.SubItems(3).Text & ", " & Me.txtShipmentID.Text & vbNewLine)
                            End If
                        Next
                        FileClose(1)
                        'Insert data from text file ShipDetails.txt into 
                        'table tbStuHpvPatVisitSpecShippedDetails 
                        Dim strSQL As String = _
                           "INSERT INTO tbStuHpvPatVisitSpecShippedDetails " & _
                           "SELECT * FROM [Text;Database=" & appPath & "\" & _
                           ";HDR=YES;FMT=Delimited].[DataToInsert.txt]"
                        RunSQL(strSQL)

                        .Fill_lvwNS()
                        Cursor.Current = Cursors.Default
                        .LockControls(False)
                        .grpSaveNS.Enabled = False

                        Me.Close()

                    Else

                        .lvwShipped.SelectedItems(0).SubItems(2).Text = Me.dts1.Value ' Me.ds.tbStuHpvPatVisitSpecShipped.Item(0).DateShipped
                        .lvwShipped.SelectedItems(0).SubItems(3).Text = Me.txtNotes.Text
                        Me.Close()

                    End If

                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub CloseAndUpdateSlow()

        If ValidationPassed() Then

            Try

                With vfrmStuHpvShip

                    If .tab0.SelectedIndex = 0 Then 'Tab Not Shipped Yet

                        Cursor.Current = Cursors.WaitCursor
                        If .lvwNS.Items.Count = 0 Then Exit Sub
                        For Each itm As ListViewItem In .lvwNS.Items
                            If itm.Checked Then
                                RunSQL("INSERT INTO tbStuHpvPatVisitSpecShippedDetails " & _
                                      "(VisitProcActID, ShipmentID) " & _
                                       "VALUES (" & itm.SubItems(3).Text & ", " & _
                                                    Me.txtShipmentID.Text & ")")
                            End If
                        Next
                        .Fill_lvwNS()
                        Cursor.Current = Cursors.Default
                        .LockControls(False)
                        .grpSaveNS.Enabled = False

                        Me.Close()

                    Else

                        .lvwShipped.SelectedItems(0).SubItems(2).Text = Me.dts1.Value ' Me.ds.tbStuHpvPatVisitSpecShipped.Item(0).DateShipped
                        .lvwShipped.SelectedItems(0).SubItems(3).Text = Me.txtNotes.Text
                        Me.Close()

                    End If

                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub


    Friend Sub WriteDataToTxtFile(ByVal FilePathAndName)

        FileOpen(1, FilePathAndName, OpenMode.Output, OpenAccess.Write)

        'Write column name
        Print(1, "VisitProcActID, ShipmentID")
        For Each itm As ListViewItem In vfrmStuHpvShip.lvwNS.Items
            If itm.Checked Then
                Print(1, itm.SubItems(3).Text & ", " & Me.txtShipmentID.Text)
            End If
        Next

        FileClose(1)

    End Sub

End Class


