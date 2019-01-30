Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb
Public Class frmStuHpvScrnFrmEdit
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
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents rbScrFrmNo6 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes6 As System.Windows.Forms.RadioButton
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents rbScrFrmNo5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes5 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPreg7 As System.Windows.Forms.Label
    Friend WithEvents rbScrFrmNo4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes4 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPreg5 As System.Windows.Forms.Label
    Friend WithEvents rbScrFrmNo3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes3 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPreg2 As System.Windows.Forms.Label
    Friend WithEvents rbScrFrmNo2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents rbScrFrmNo1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes1 As System.Windows.Forms.RadioButton
    Friend WithEvents chkScrFrm1_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrFrm1_1 As System.Windows.Forms.CheckBox
    Friend WithEvents ds As RIS.DataSet1
    Friend WithEvents dts1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVisitID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLastEditDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEpisodeID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPreg1 As System.Windows.Forms.Label
    Friend WithEvents lblPreg6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPreg3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents da1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents da1SelectComm As System.Data.OleDb.OleDbCommand
    Friend WithEvents rbScrFrmNo8 As System.Windows.Forms.RadioButton
    Friend WithEvents rbScrFrmYes8 As System.Windows.Forms.RadioButton
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents lblPreg4 As System.Windows.Forms.Label
    Friend WithEvents DtTermDate As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents RISdataDataSet As RIS.RISdataDataSet
    Friend WithEvents DdvPregnancyOutcomeTypeTableAdapter As RIS.RISdataDataSetTableAdapters.ddvPregnancyOutcomeTypeTableAdapter
    Friend WithEvents DdvPregnancyOutcomeTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboOutComeOfPreg As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtDtTermDateEstimate As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStuHpvScrnFrmEdit))
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label103 = New System.Windows.Forms.Label
        Me.rbScrFrmNo6 = New System.Windows.Forms.RadioButton
        Me.rbScrFrmYes6 = New System.Windows.Forms.RadioButton
        Me.Label104 = New System.Windows.Forms.Label
        Me.rbScrFrmNo5 = New System.Windows.Forms.RadioButton
        Me.rbScrFrmYes5 = New System.Windows.Forms.RadioButton
        Me.lblPreg7 = New System.Windows.Forms.Label
        Me.rbScrFrmNo4 = New System.Windows.Forms.RadioButton
        Me.rbScrFrmYes4 = New System.Windows.Forms.RadioButton
        Me.lblPreg5 = New System.Windows.Forms.Label
        Me.rbScrFrmNo3 = New System.Windows.Forms.RadioButton
        Me.rbScrFrmYes3 = New System.Windows.Forms.RadioButton
        Me.lblPreg2 = New System.Windows.Forms.Label
        Me.rbScrFrmNo2 = New System.Windows.Forms.RadioButton
        Me.rbScrFrmYes2 = New System.Windows.Forms.RadioButton
        Me.Label108 = New System.Windows.Forms.Label
        Me.Label109 = New System.Windows.Forms.Label
        Me.rbScrFrmNo1 = New System.Windows.Forms.RadioButton
        Me.rbScrFrmYes1 = New System.Windows.Forms.RadioButton
        Me.chkScrFrm1_2 = New System.Windows.Forms.CheckBox
        Me.chkScrFrm1_1 = New System.Windows.Forms.CheckBox
        Me.ds = New RIS.DataSet1
        Me.da1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.da1SelectComm = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.dts1 = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtVisitID = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLastEditDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtEpisodeID = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblPreg1 = New System.Windows.Forms.Label
        Me.lblPreg6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblPreg3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.rbScrFrmNo8 = New System.Windows.Forms.RadioButton
        Me.rbScrFrmYes8 = New System.Windows.Forms.RadioButton
        Me.lblPreg4 = New System.Windows.Forms.Label
        Me.DtTermDate = New Umbrae.Windows.Forms.DateTimeSlicker
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtDtTermDateEstimate = New System.Windows.Forms.TextBox
        Me.RISdataDataSet = New RIS.RISdataDataSet
        Me.DdvPregnancyOutcomeTypeTableAdapter = New RIS.RISdataDataSettableadapters.ddvPregnancyOutcomeTypeTableAdapter
        Me.DdvPregnancyOutcomeTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboOutComeOfPreg = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DdvPregnancyOutcomeTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 1
        Me.btnExit.Location = New System.Drawing.Point(473, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 20)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label78.Location = New System.Drawing.Point(13, 15)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(30, 15)
        Me.Label78.TabIndex = 142
        Me.Label78.Text = "Date"
        '
        'Label103
        '
        Me.Label103.BackColor = System.Drawing.SystemColors.Control
        Me.Label103.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label103.Location = New System.Drawing.Point(15, 353)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(249, 15)
        Me.Label103.TabIndex = 141
        Me.Label103.Text = "9. Would you like to receive the HPV vaccine?"
        '
        'rbScrFrmNo6
        '
        Me.rbScrFrmNo6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo6.Location = New System.Drawing.Point(58, 2)
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
        Me.rbScrFrmYes6.Location = New System.Drawing.Point(9, 2)
        Me.rbScrFrmYes6.Name = "rbScrFrmYes6"
        Me.rbScrFrmYes6.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes6.TabIndex = 32
        Me.rbScrFrmYes6.Tag = "Y"
        Me.rbScrFrmYes6.Text = "Yes"
        Me.rbScrFrmYes6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label104
        '
        Me.Label104.BackColor = System.Drawing.SystemColors.Control
        Me.Label104.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label104.Location = New System.Drawing.Point(15, 320)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(249, 15)
        Me.Label104.TabIndex = 139
        Me.Label104.Text = "8. Have you ever been vaccinated with the HPV vaccine?"
        '
        'rbScrFrmNo5
        '
        Me.rbScrFrmNo5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo5.Location = New System.Drawing.Point(58, 0)
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
        Me.rbScrFrmYes5.Location = New System.Drawing.Point(9, 0)
        Me.rbScrFrmYes5.Name = "rbScrFrmYes5"
        Me.rbScrFrmYes5.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes5.TabIndex = 32
        Me.rbScrFrmYes5.Tag = "Y"
        Me.rbScrFrmYes5.Text = "Yes"
        Me.rbScrFrmYes5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPreg7
        '
        Me.lblPreg7.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg7.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPreg7.Location = New System.Drawing.Point(15, 277)
        Me.lblPreg7.Name = "lblPreg7"
        Me.lblPreg7.Size = New System.Drawing.Size(249, 15)
        Me.lblPreg7.TabIndex = 137
        Me.lblPreg7.Text = "7. Do you have your period right now?"
        '
        'rbScrFrmNo4
        '
        Me.rbScrFrmNo4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo4.Location = New System.Drawing.Point(58, 2)
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
        Me.rbScrFrmYes4.Location = New System.Drawing.Point(9, 2)
        Me.rbScrFrmYes4.Name = "rbScrFrmYes4"
        Me.rbScrFrmYes4.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes4.TabIndex = 32
        Me.rbScrFrmYes4.Tag = "Y"
        Me.rbScrFrmYes4.Text = "Yes"
        Me.rbScrFrmYes4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPreg5
        '
        Me.lblPreg5.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg5.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPreg5.Location = New System.Drawing.Point(17, 223)
        Me.lblPreg5.Name = "lblPreg5"
        Me.lblPreg5.Size = New System.Drawing.Size(236, 15)
        Me.lblPreg5.TabIndex = 135
        Me.lblPreg5.Text = "5. As of today, do you think you are pregnant?"
        '
        'rbScrFrmNo3
        '
        Me.rbScrFrmNo3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo3.Location = New System.Drawing.Point(58, 0)
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
        Me.rbScrFrmYes3.Location = New System.Drawing.Point(9, 0)
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
        Me.lblPreg2.Location = New System.Drawing.Point(15, 146)
        Me.lblPreg2.Name = "lblPreg2"
        Me.lblPreg2.Size = New System.Drawing.Size(193, 15)
        Me.lblPreg2.TabIndex = 133
        Me.lblPreg2.Text = "3. Have you ever been pregnant?"
        '
        'rbScrFrmNo2
        '
        Me.rbScrFrmNo2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo2.Location = New System.Drawing.Point(58, 2)
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
        Me.rbScrFrmYes2.Location = New System.Drawing.Point(9, 2)
        Me.rbScrFrmYes2.Name = "rbScrFrmYes2"
        Me.rbScrFrmYes2.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes2.TabIndex = 32
        Me.rbScrFrmYes2.Tag = "Y"
        Me.rbScrFrmYes2.Text = "Yes"
        Me.rbScrFrmYes2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label108
        '
        Me.Label108.BackColor = System.Drawing.SystemColors.Control
        Me.Label108.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label108.Location = New System.Drawing.Point(16, 94)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(261, 15)
        Me.Label108.TabIndex = 131
        Me.Label108.Text = "2. Type of sexual activity ever: Check all that apply"
        '
        'Label109
        '
        Me.Label109.BackColor = System.Drawing.SystemColors.Control
        Me.Label109.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label109.Location = New System.Drawing.Point(15, 73)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(253, 15)
        Me.Label109.TabIndex = 130
        Me.Label109.Text = "1. Are you or have you ever been sexually active?"
        '
        'rbScrFrmNo1
        '
        Me.rbScrFrmNo1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo1.Location = New System.Drawing.Point(62, 3)
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
        Me.rbScrFrmYes1.Location = New System.Drawing.Point(6, 3)
        Me.rbScrFrmYes1.Name = "rbScrFrmYes1"
        Me.rbScrFrmYes1.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes1.TabIndex = 32
        Me.rbScrFrmYes1.Tag = "Y"
        Me.rbScrFrmYes1.Text = "Yes"
        Me.rbScrFrmYes1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkScrFrm1_2
        '
        Me.chkScrFrm1_2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkScrFrm1_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkScrFrm1_2.Location = New System.Drawing.Point(345, 94)
        Me.chkScrFrm1_2.Name = "chkScrFrm1_2"
        Me.chkScrFrm1_2.Size = New System.Drawing.Size(42, 19)
        Me.chkScrFrm1_2.TabIndex = 1
        Me.chkScrFrm1_2.Text = "Anal"
        '
        'chkScrFrm1_1
        '
        Me.chkScrFrm1_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkScrFrm1_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.chkScrFrm1_1.Location = New System.Drawing.Point(283, 94)
        Me.chkScrFrm1_1.Name = "chkScrFrm1_1"
        Me.chkScrFrm1_1.Size = New System.Drawing.Size(55, 19)
        Me.chkScrFrm1_1.TabIndex = 0
        Me.chkScrFrm1_1.Text = "Vaginal"
        '
        'ds
        '
        Me.ds.DataSetName = "DataSet1"
        Me.ds.Locale = New System.Globalization.CultureInfo("en-US")
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'da1
        '
        Me.da1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.da1.InsertCommand = Me.OleDbInsertCommand1
        Me.da1.SelectCommand = Me.da1SelectComm
        Me.da1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tbStuHpvScreeningForm", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CurrentPreg", "CurrentPreg"), New System.Data.Common.DataColumnMapping("DateScreened", "DateScreened"), New System.Data.Common.DataColumnMapping("EpisodeID", "EpisodeID"), New System.Data.Common.DataColumnMapping("HasPeriod", "HasPeriod"), New System.Data.Common.DataColumnMapping("HpvScrnFrmID", "HpvScrnFrmID"), New System.Data.Common.DataColumnMapping("HPVvaccinated", "HPVvaccinated"), New System.Data.Common.DataColumnMapping("LastEditDate", "LastEditDate"), New System.Data.Common.DataColumnMapping("LastEditLoginID", "LastEditLoginID"), New System.Data.Common.DataColumnMapping("SexualActType", "SexualActType"), New System.Data.Common.DataColumnMapping("SexuallyActive", "SexuallyActive"), New System.Data.Common.DataColumnMapping("TodayPreg", "TodayPreg"), New System.Data.Common.DataColumnMapping("WantHPVvaccine", "WantHPVvaccine"), New System.Data.Common.DataColumnMapping("TermPreg", "TermPreg"), New System.Data.Common.DataColumnMapping("TermDate", "TermDate"), New System.Data.Common.DataColumnMapping("PlanToLeaveNYC", "PlanToLeaveNYC"), New System.Data.Common.DataColumnMapping("TermDateEstimate", "TermDateEstimate")})})
        Me.da1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_HpvScrnFrmID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HpvScrnFrmID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CurrentlyPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentlyPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CurrentlyPregnant1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentlyPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateScreened", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateScreened", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateScreened1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateScreened", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancy", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TermPreg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancy1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TermPreg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancyDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancyDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EndPregnancyDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EndPregnancyDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EpisodeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HPVvaccinated", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HPVvaccinated", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HPVvaccinated1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HPVvaccinated", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HasPeriod", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HasPeriod", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HasPeriod1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HasPeriod", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PlanToLeaveNYC", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlanToLeaveNYC", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PlanToLeaveNYC1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlanToLeaveNYC", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexualActType", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexualActType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexualActType1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexualActType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexuallyActive", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexuallyActive", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexuallyActive1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexuallyActive", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ThoughtPregnant", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ThoughtPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ThoughtPregnant1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ThoughtPregnant", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_WantHPVvaccine", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WantHPVvaccine", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_WantHPVvaccine1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WantHPVvaccine", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("DateScreened", System.Data.OleDb.OleDbType.[Date], 0, "DateScreened"), New System.Data.OleDb.OleDbParameter("EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeID"), New System.Data.OleDb.OleDbParameter("HasPeriod", System.Data.OleDb.OleDbType.WChar, 1, "HasPeriod"), New System.Data.OleDb.OleDbParameter("HPVvaccinated", System.Data.OleDb.OleDbType.WChar, 1, "HPVvaccinated"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.WChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("SexualActType", System.Data.OleDb.OleDbType.WChar, 2, "SexualActType"), New System.Data.OleDb.OleDbParameter("SexuallyActive", System.Data.OleDb.OleDbType.WChar, 1, "SexuallyActive"), New System.Data.OleDb.OleDbParameter("WantHPVvaccine", System.Data.OleDb.OleDbType.WChar, 1, "WantHPVvaccine"), New System.Data.OleDb.OleDbParameter("PlanToLeaveNYC", System.Data.OleDb.OleDbType.WChar, 1, "PlanToLeaveNYC"), New System.Data.OleDb.OleDbParameter("CurrentPreg", System.Data.OleDb.OleDbType.[Boolean], 2, "CurrentPreg"), New System.Data.OleDb.OleDbParameter("TodayPreg", System.Data.OleDb.OleDbType.[Boolean], 2, "TodayPreg"), New System.Data.OleDb.OleDbParameter("TermPreg", System.Data.OleDb.OleDbType.WChar, 255, "TermPreg"), New System.Data.OleDb.OleDbParameter("TermDate", System.Data.OleDb.OleDbType.[Date], 0, "TermDate"), New System.Data.OleDb.OleDbParameter("TermDateEstimate", System.Data.OleDb.OleDbType.WChar, 255, "TermDateEstimate")})
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Bittersweet Software\Bittersweet" & _
            " Software Working Folder\RIS\RIS\bin\Data\RISdata.mdb"""
        '
        'da1SelectComm
        '
        Me.da1SelectComm.CommandText = resources.GetString("da1SelectComm.CommandText")
        Me.da1SelectComm.Connection = Me.OleDbConnection2
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CurrentPreg", System.Data.OleDb.OleDbType.[Boolean], 2, "CurrentPreg"), New System.Data.OleDb.OleDbParameter("DateScreened", System.Data.OleDb.OleDbType.[Date], 0, "DateScreened"), New System.Data.OleDb.OleDbParameter("EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, "EpisodeID"), New System.Data.OleDb.OleDbParameter("HasPeriod", System.Data.OleDb.OleDbType.WChar, 1, "HasPeriod"), New System.Data.OleDb.OleDbParameter("HPVvaccinated", System.Data.OleDb.OleDbType.WChar, 1, "HPVvaccinated"), New System.Data.OleDb.OleDbParameter("LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, "LastEditDate"), New System.Data.OleDb.OleDbParameter("LastEditLoginID", System.Data.OleDb.OleDbType.WChar, 20, "LastEditLoginID"), New System.Data.OleDb.OleDbParameter("SexualActType", System.Data.OleDb.OleDbType.WChar, 2, "SexualActType"), New System.Data.OleDb.OleDbParameter("SexuallyActive", System.Data.OleDb.OleDbType.WChar, 1, "SexuallyActive"), New System.Data.OleDb.OleDbParameter("TodayPreg", System.Data.OleDb.OleDbType.[Boolean], 2, "TodayPreg"), New System.Data.OleDb.OleDbParameter("WantHPVvaccine", System.Data.OleDb.OleDbType.WChar, 1, "WantHPVvaccine"), New System.Data.OleDb.OleDbParameter("TermPreg", System.Data.OleDb.OleDbType.WChar, 255, "TermPreg"), New System.Data.OleDb.OleDbParameter("TermDate", System.Data.OleDb.OleDbType.[Date], 0, "TermDate"), New System.Data.OleDb.OleDbParameter("PlanToLeaveNYC", System.Data.OleDb.OleDbType.WChar, 1, "PlanToLeaveNYC"), New System.Data.OleDb.OleDbParameter("TermDateEstimate", System.Data.OleDb.OleDbType.WChar, 255, "TermDateEstimate"), New System.Data.OleDb.OleDbParameter("Original_HpvScrnFrmID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HpvScrnFrmID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_DateScreened", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateScreened", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param18", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_EpisodeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EpisodeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HPVvaccinated", System.Data.OleDb.OleDbType.WChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HPVvaccinated", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param21", System.Data.OleDb.OleDbType.VarWChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HasPeriod", System.Data.OleDb.OleDbType.WChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HasPeriod", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param23", System.Data.OleDb.OleDbType.VarWChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditDate", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param25", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastEditLoginID", System.Data.OleDb.OleDbType.WChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastEditLoginID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param27", System.Data.OleDb.OleDbType.VarWChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PlanToLeaveNYC", System.Data.OleDb.OleDbType.WChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PlanToLeaveNYC", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param29", System.Data.OleDb.OleDbType.VarWChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexualActType", System.Data.OleDb.OleDbType.WChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexualActType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param31", System.Data.OleDb.OleDbType.VarWChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SexuallyActive", System.Data.OleDb.OleDbType.WChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SexuallyActive", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param33", System.Data.OleDb.OleDbType.VarWChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_WantHPVvaccine", System.Data.OleDb.OleDbType.WChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WantHPVvaccine", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param35", System.Data.OleDb.OleDbType.VarWChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CurrentPreg", System.Data.OleDb.OleDbType.[Boolean], 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CurrentPreg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param37", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TodayPreg", System.Data.OleDb.OleDbType.[Boolean], 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TodayPreg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param39", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TermPreg", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TermPreg", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param41", System.Data.OleDb.OleDbType.VarWChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TermDate", System.Data.OleDb.OleDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TermDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param43", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TermDateEstimate", System.Data.OleDb.OleDbType.WChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TermDateEstimate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Param45", System.Data.OleDb.OleDbType.VarWChar, 1024, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing)})
        '
        'dts1
        '
        Me.dts1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dts1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dts1.Location = New System.Drawing.Point(46, 12)
        Me.dts1.Name = "dts1"
        Me.dts1.ShowCheckBox = True
        Me.dts1.Size = New System.Drawing.Size(100, 21)
        Me.dts1.TabIndex = 0
        Me.dts1.Tag = "DateScreened"
        Me.dts1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
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
        Me.GroupBox2.Location = New System.Drawing.Point(18, 435)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 98)
        Me.GroupBox2.TabIndex = 145
        Me.GroupBox2.TabStop = False
        '
        'txtVisitID
        '
        Me.txtVisitID.BackColor = System.Drawing.SystemColors.Control
        Me.txtVisitID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvScreeningForm.HpvScrnFrmID", True))
        Me.txtVisitID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitID.ForeColor = System.Drawing.Color.DimGray
        Me.txtVisitID.Location = New System.Drawing.Point(86, 18)
        Me.txtVisitID.Name = "txtVisitID"
        Me.txtVisitID.ReadOnly = True
        Me.txtVisitID.Size = New System.Drawing.Size(122, 21)
        Me.txtVisitID.TabIndex = 92
        Me.txtVisitID.TabStop = False
        Me.txtVisitID.Text = "HpvScrnFrmID"
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
        Me.Label9.Text = "ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLastEditDate
        '
        Me.txtLastEditDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastEditDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvScreeningForm.LastEditDate", True))
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
        Me.txtEpisodeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tbStuHpvScreeningForm.EpisodeID", True))
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Sexual Hx:"
        '
        'lblPreg1
        '
        Me.lblPreg1.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg1.ForeColor = System.Drawing.Color.Black
        Me.lblPreg1.Location = New System.Drawing.Point(15, 125)
        Me.lblPreg1.Name = "lblPreg1"
        Me.lblPreg1.Size = New System.Drawing.Size(80, 15)
        Me.lblPreg1.TabIndex = 147
        Me.lblPreg1.Text = "Pregnancy Hx:"
        '
        'lblPreg6
        '
        Me.lblPreg6.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg6.ForeColor = System.Drawing.Color.Black
        Me.lblPreg6.Location = New System.Drawing.Point(15, 258)
        Me.lblPreg6.Name = "lblPreg6"
        Me.lblPreg6.Size = New System.Drawing.Size(75, 15)
        Me.lblPreg6.TabIndex = 148
        Me.lblPreg6.Text = "Menstrual Hx:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "HPV Vaccine Hx:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Mobility:"
        '
        'lblPreg3
        '
        Me.lblPreg3.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg3.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPreg3.Location = New System.Drawing.Point(15, 170)
        Me.lblPreg3.Name = "lblPreg3"
        Me.lblPreg3.Size = New System.Drawing.Size(220, 15)
        Me.lblPreg3.TabIndex = 152
        Me.lblPreg3.Text = "4. What was the outcome of the pregnancy? "
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(15, 396)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(389, 15)
        Me.Label12.TabIndex = 155
        Me.Label12.Text = "10. Do you have any plans to move or leave the NYC area in the next 2 years?"
        '
        'rbScrFrmNo8
        '
        Me.rbScrFrmNo8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbScrFrmNo8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbScrFrmNo8.Location = New System.Drawing.Point(64, 0)
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
        Me.rbScrFrmYes8.Location = New System.Drawing.Point(9, 0)
        Me.rbScrFrmYes8.Name = "rbScrFrmYes8"
        Me.rbScrFrmYes8.Size = New System.Drawing.Size(38, 21)
        Me.rbScrFrmYes8.TabIndex = 32
        Me.rbScrFrmYes8.Tag = "Y"
        Me.rbScrFrmYes8.Text = "Yes"
        Me.rbScrFrmYes8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPreg4
        '
        Me.lblPreg4.BackColor = System.Drawing.SystemColors.Control
        Me.lblPreg4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreg4.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPreg4.Location = New System.Drawing.Point(34, 197)
        Me.lblPreg4.Name = "lblPreg4"
        Me.lblPreg4.Size = New System.Drawing.Size(230, 15)
        Me.lblPreg4.TabIndex = 156
        Me.lblPreg4.Text = "Outcome Date:"
        '
        'DtTermDate
        '
        Me.DtTermDate.Checked = False
        Me.DtTermDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtTermDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTermDate.Location = New System.Drawing.Point(395, 193)
        Me.DtTermDate.Name = "DtTermDate"
        Me.DtTermDate.ShowCheckBox = True
        Me.DtTermDate.Size = New System.Drawing.Size(112, 21)
        Me.DtTermDate.TabIndex = 161
        Me.DtTermDate.Tag = "TermDate"
        Me.DtTermDate.Value = CType(resources.GetObject("DtTermDate.Value"), Object)
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label35.Location = New System.Drawing.Point(368, 197)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(21, 15)
        Me.Label35.TabIndex = 162
        Me.Label35.Text = "Or"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDtTermDateEstimate
        '
        Me.txtDtTermDateEstimate.BackColor = System.Drawing.SystemColors.Window
        Me.txtDtTermDateEstimate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtTermDateEstimate.Location = New System.Drawing.Point(280, 193)
        Me.txtDtTermDateEstimate.MaxLength = 255
        Me.txtDtTermDateEstimate.Name = "txtDtTermDateEstimate"
        Me.txtDtTermDateEstimate.Size = New System.Drawing.Size(82, 21)
        Me.txtDtTermDateEstimate.TabIndex = 159
        '
        'RISdataDataSet
        '
        Me.RISdataDataSet.DataSetName = "RISdataDataSet"
        Me.RISdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DdvPregnancyOutcomeTypeTableAdapter
        '
        Me.DdvPregnancyOutcomeTypeTableAdapter.ClearBeforeFill = True
        '
        'DdvPregnancyOutcomeTypeBindingSource
        '
        Me.DdvPregnancyOutcomeTypeBindingSource.DataMember = "ddvPregnancyOutcomeType"
        Me.DdvPregnancyOutcomeTypeBindingSource.DataSource = Me.RISdataDataSet
        '
        'cboOutComeOfPreg
        '
        Me.cboOutComeOfPreg.DataSource = Me.DdvPregnancyOutcomeTypeBindingSource
        Me.cboOutComeOfPreg.DisplayMember = "OutcomeDesc"
        Me.cboOutComeOfPreg.FormattingEnabled = True
        Me.cboOutComeOfPreg.Location = New System.Drawing.Point(280, 166)
        Me.cboOutComeOfPreg.Name = "cboOutComeOfPreg"
        Me.cboOutComeOfPreg.Size = New System.Drawing.Size(227, 21)
        Me.cboOutComeOfPreg.TabIndex = 163
        Me.cboOutComeOfPreg.ValueMember = "PregOutcomeTypeCd"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbScrFrmNo1)
        Me.Panel1.Controls.Add(Me.rbScrFrmYes1)
        Me.Panel1.Location = New System.Drawing.Point(277, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(110, 23)
        Me.Panel1.TabIndex = 164
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbScrFrmNo2)
        Me.Panel2.Controls.Add(Me.rbScrFrmYes2)
        Me.Panel2.Location = New System.Drawing.Point(277, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(110, 23)
        Me.Panel2.TabIndex = 165
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbScrFrmNo3)
        Me.Panel3.Controls.Add(Me.rbScrFrmYes3)
        Me.Panel3.Location = New System.Drawing.Point(279, 220)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(110, 23)
        Me.Panel3.TabIndex = 166
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbScrFrmNo4)
        Me.Panel4.Controls.Add(Me.rbScrFrmYes4)
        Me.Panel4.Location = New System.Drawing.Point(277, 269)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(110, 23)
        Me.Panel4.TabIndex = 166
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.rbScrFrmNo8)
        Me.Panel5.Controls.Add(Me.rbScrFrmYes8)
        Me.Panel5.Location = New System.Drawing.Point(407, 388)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(110, 23)
        Me.Panel5.TabIndex = 166
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.rbScrFrmNo6)
        Me.Panel6.Controls.Add(Me.rbScrFrmYes6)
        Me.Panel6.Location = New System.Drawing.Point(277, 345)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(110, 23)
        Me.Panel6.TabIndex = 166
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.rbScrFrmYes5)
        Me.Panel7.Controls.Add(Me.rbScrFrmNo5)
        Me.Panel7.Location = New System.Drawing.Point(277, 318)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(110, 23)
        Me.Panel7.TabIndex = 166
        '
        'frmStuHpvScrnFrmEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(525, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cboOutComeOfPreg)
        Me.Controls.Add(Me.chkScrFrm1_2)
        Me.Controls.Add(Me.chkScrFrm1_1)
        Me.Controls.Add(Me.DtTermDate)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtDtTermDateEstimate)
        Me.Controls.Add(Me.lblPreg4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblPreg3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPreg6)
        Me.Controls.Add(Me.lblPreg1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dts1)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.Label103)
        Me.Controls.Add(Me.Label104)
        Me.Controls.Add(Me.lblPreg7)
        Me.Controls.Add(Me.lblPreg5)
        Me.Controls.Add(Me.lblPreg2)
        Me.Controls.Add(Me.Label108)
        Me.Controls.Add(Me.Label109)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStuHpvScrnFrmEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing Screening Form"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RISdataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DdvPregnancyOutcomeTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim FormActivated As Boolean = False
    Dim conn As OleDbConnection
    Dim pGender As String

    Public Property Gender() As String
        Get
            Gender = pGender
        End Get
        Set(ByVal value As String)
            pGender = value
        End Set
    End Property

    Private Sub frmStuHpvScrnFrmEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub
    Private Sub frmStuHpvScrnFrmEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmStuHpvScrnFrmEdit = Nothing
    End Sub
    Private Sub SetHPVGenderSetup()
        Try
            If Me.Gender = "F" Then
                lblPreg1.Enabled = True
                lblPreg2.Enabled = True
                lblPreg3.Enabled = True
                lblPreg4.Enabled = True
                lblPreg5.Enabled = True
                lblPreg6.Enabled = True
                lblPreg7.Enabled = True
                Panel2.Enabled = True
                cboOutComeOfPreg.Enabled = True
                txtDtTermDateEstimate.Enabled = True
                DtTermDate.Enabled = True
                Label35.Enabled = True
                Panel3.Enabled = True
                Panel4.Enabled = True
            Else
                lblPreg1.Enabled = False
                lblPreg2.Enabled = False
                lblPreg3.Enabled = False
                lblPreg4.Enabled = False
                lblPreg5.Enabled = False
                lblPreg6.Enabled = False
                lblPreg7.Enabled = False
                Panel2.Enabled = False
                cboOutComeOfPreg.Enabled = False
                txtDtTermDateEstimate.Enabled = False
                DtTermDate.Enabled = False
                Label35.Enabled = False
                Panel3.Enabled = False
                Panel4.Enabled = False
            End If
            
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub frmStuHpvScrnFrmEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DdvPregnancyOutcomeTypeTableAdapter.Connection.ConnectionString = strConn
        Me.DdvPregnancyOutcomeTypeTableAdapter.FillAll(Me.RISdataDataSet.ddvPregnancyOutcomeType)

        conn = New OleDbConnection
        conn.ConnectionString = strConn


        SetHPVGenderSetup()


        If vb.Left(Me.Text.ToString, 7) = "Editing" Then
            With Me.ds.tbStuHpvScreeningForm.Rows(0)
                FillCheckBoxGroup(Me, .Item("SexualActType").ToString, "chkScrFrm1_", 2)
                FillRBYesNo(.Item("SexuallyActive").ToString, rbScrFrmYes1, rbScrFrmNo1)
                FillRBYesNo(.Item("HasPeriod").ToString, rbScrFrmYes4, rbScrFrmNo4)
                FillRBYesNo(.Item("HPVvaccinated").ToString, rbScrFrmYes5, rbScrFrmNo5)
                FillRBYesNo(.Item("WantHPVvaccine").ToString, rbScrFrmYes6, rbScrFrmNo6)
                FillRBYesNo(.Item("PlanToLeaveNYC").ToString, rbScrFrmYes8, rbScrFrmNo8)

                Me.rbScrFrmYes2.Checked = .Item("CurrentPreg")
                Me.rbScrFrmNo2.Checked = Not .Item("CurrentPreg")
                Me.rbScrFrmYes3.Checked = .Item("TodayPreg")
                Me.rbScrFrmNo3.Checked = Not .Item("TodayPreg")

                If Not IsDBNull(.Item("TermPreg")) Then
                    Me.cboOutComeOfPreg.SelectedValue = .Item("TermPreg").ToString
                Else
                    Me.cboOutComeOfPreg.SelectedIndex = -1
                End If

                If Not IsDBNull(.Item("TermDate")) Then
                    Me.DtTermDate.Checked = True
                    Me.DtTermDate.Value = .Item("TermDate")
                End If

                If Not IsDBNull(.Item("TermDateEstimate")) Then
                    Me.txtDtTermDateEstimate.Text = .Item("TermDateEstimate")
                End If

                If Not IsDBNull(.Item("DateScreened")) Then
                    dts1.Checked = True
                    Me.dts1.Text = .Item("DateScreened").ToString
                Else
                    dts1.Checked = False
                    Me.dts1.Text = Today
                End If

            End With
        Else
            Me.BindingContext(Me.ds, "tbStuHpvScreeningForm").AddNew()
            Me.BindingContext(Me.ds, "tbStuHpvScreeningForm").Position = 0
            With vfrmPatient
                Me.ds.tbStuHpvScreeningForm.Item(0).EpisodeID = _
                .lvwHpvEpi.SelectedItems(0).SubItems(.lvwHpvEpi.Columns.Count - 1).Text
                Me.ds.tbStuHpvScreeningForm.Item(0).DateScreened = Today
            End With

            Me.dts1.Checked = True
            dts1.Text = Today
            Me.cboOutComeOfPreg.SelectedIndex = -1
        End If

        'FillDateTimeSlickers(Me, Me.ds.tbStuHpvScreeningForm, "dts", 2)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Try

            conn = New OleDbConnection
            conn.ConnectionString = strConn

            Dim MyDA As DataSet1TableAdapters.tbStuHpvScreeningFormTableAdapter = New DataSet1TableAdapters.tbStuHpvScreeningFormTableAdapter
            MyDA.Connection = conn

            Dim resp As MsgBoxResult
            If vb.Left(Me.Text.ToString, 6) = "Adding" Then
                resp = MsgBox("Do you want to add this new screening form?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then

                    If ValidationPassed() Then
                        'txtLastEditDate.Text = System.DateTime.Now
                        'Me.BindingContext(Me.ds, "tbStuHpvScreeningForm").EndCurrentEdit()

                        SetRowValues()
                        MyDA.Update(Me.ds.tbStuHpvScreeningForm)

                        'UpdateDataSourceAddNew(Me.ds, "tbStuHpvScreeningForm", conn, Me.da1)
                        CloseAndUpdate()

                    End If

                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If

            Else

                'Dim objDataSetChanges As DataSet1 = New DataSet1
                'Me.BindingContext(Me.ds, "tbStuHpvScreeningForm").EndCurrentEdit()
                'objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)
                'If Not (objDataSetChanges) Is Nothing Then
                resp = MsgBox("Do you want to save your changes?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
                If resp = MsgBoxResult.Yes Then

                    If ValidationPassed() Then
                        'Must cancel edit first
                        'Me.BindingContext(Me.ds, "tbStuHpvScreeningForm").CancelCurrentEdit()
                        'txtLastEditDate.Text = System.DateTime.Now
                        'Me.BindingContext(Me.ds, "tbStuHpvScreeningForm").EndCurrentEdit()

                        SetRowValues()
                        MyDA.Update(Me.ds.tbStuHpvScreeningForm)

                        'objDataSetChanges = CType(Me.ds.GetChanges, DataSet1)
                        'UpdateDataSource(objDataSetChanges, conn, Me.da1)

                        CloseAndUpdate()

                    End If

                ElseIf resp = MsgBoxResult.No Then
                    Me.Close()
                ElseIf resp = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
                Me.Close()
            End If


        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SetRowValues()
        Try
            Me.ds.tbStuHpvScreeningForm(0).BeginEdit()
            If Me.dts1.Checked Then
                Me.ds.tbStuHpvScreeningForm(0).DateScreened = Me.dts1.Value
            Else
                Me.ds.tbStuHpvScreeningForm(0).SetDateScreenedNull()
            End If

            UpdateCheckBoxGroupField(Me, Me.ds.tbStuHpvScreeningForm, "SexualActType", "chkScrFrm1_", 2)

            Me.ds.tbStuHpvScreeningForm(0).SexuallyActive = IIf(Me.rbScrFrmYes1.Checked, "Y", "N")
            Me.ds.tbStuHpvScreeningForm(0).CurrentPreg = Me.rbScrFrmYes2.Checked
            Me.ds.tbStuHpvScreeningForm(0).TodayPreg = Me.rbScrFrmYes3.Checked
            Me.ds.tbStuHpvScreeningForm(0).TermPreg = Me.cboOutComeOfPreg.SelectedValue

            If Me.DtTermDate.Checked Then
                Me.ds.tbStuHpvScreeningForm(0).TermDate = Me.DtTermDate.Value
            Else
                Me.ds.tbStuHpvScreeningForm(0).SetTermDateNull()
            End If
            Me.ds.tbStuHpvScreeningForm(0).TermDateEstimate = Me.txtDtTermDateEstimate.Text

            Me.ds.tbStuHpvScreeningForm(0).HasPeriod = IIf(Me.rbScrFrmYes4.Checked, "Y", "N")
            Me.ds.tbStuHpvScreeningForm(0).HPVvaccinated = IIf(Me.rbScrFrmYes5.Checked, "Y", "N")
            Me.ds.tbStuHpvScreeningForm(0).WantHPVvaccine = IIf(Me.rbScrFrmYes6.Checked, "Y", "N")
            Me.ds.tbStuHpvScreeningForm(0).PlanToLeaveNYC = IIf(Me.rbScrFrmYes8.Checked, "Y", "N")
            Me.ds.tbStuHpvScreeningForm(0).LastEditDate = Today
            Me.ds.tbStuHpvScreeningForm(0).EndEdit()

        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Function ValidationPassed() As Boolean
        ValidationPassed = True
        If Me.dts1.Checked = False Then
            MsgBox("'Date Screened' is required.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information)
            Me.dts1.Focus()
            Return False
            Exit Function
        End If
    End Function

    Private Sub CloseAndUpdate()
        Me.Close()
        With vfrmPatient
            .Update_tabHpv()
        End With
    End Sub
End Class
