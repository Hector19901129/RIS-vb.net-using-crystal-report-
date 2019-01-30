Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb
Imports System.Runtime.InteropServices 'For ListViewColumnOrder

Public Class frmStuHpvShip
    Inherits System.Windows.Forms.Form

    Const LVM_FIRST As Integer = &H1000 'For ListViewColumnOrder
    Const LVM_SETCOLUMNORDERARRAY = LVM_FIRST + 58 'For ListViewColumnOrder

    Dim lvwShippedXSelectedIndex As Integer
    Dim lvwNS_CheckedItemsCount As Integer
    'Private Editors() As Control

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvwNSC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwNSC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwNSC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwNSC5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwNSC6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpVisitDate As System.Windows.Forms.GroupBox
    Friend WithEvents tab0 As System.Windows.Forms.TabControl
    Friend WithEvents tab0P1 As System.Windows.Forms.TabPage
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaveNS As System.Windows.Forms.Button
    Friend WithEvents btnCancelNS As System.Windows.Forms.Button
    Friend WithEvents grpSaveNS As System.Windows.Forms.GroupBox
    Friend WithEvents btnCheckAllNS As System.Windows.Forms.Button
    Friend WithEvents cboSpecNS As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtsVisitDate1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtsVisitDate2 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnCheckAllS As System.Windows.Forms.Button
    Friend WithEvents grpSaveS As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSaveS As System.Windows.Forms.Button
    Friend WithEvents btnCancelS As System.Windows.Forms.Button
    Friend WithEvents grpShipDate As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtsDateShipped2 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents dtsDateShipped1 As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents cboSpecS As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtsDateShippedToSave As Umbrae.Windows.Forms.DateTimeSlicker
    Friend WithEvents lvwNS As System.Windows.Forms.ListView
    Friend WithEvents lvwNSC0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwNSC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwS As System.Windows.Forms.ListView
    Friend WithEvents lvwSC0 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwSC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwSC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwSC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwSC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwSC5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwSC6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefreshNS As System.Windows.Forms.Button
    Friend WithEvents btnRefreshS As System.Windows.Forms.Button
    Friend WithEvents ils16X16 As System.Windows.Forms.ImageList
    Friend WithEvents tbRefreshNS As System.Windows.Forms.ToolBar
    Friend WithEvents tbRefreshNSb1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbRefreshS As System.Windows.Forms.ToolBar
    Friend WithEvents tbRefreshSb1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents lvwNSC7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents lvwShipped As System.Windows.Forms.ListView
    Friend WithEvents lvwShippedDetails As System.Windows.Forms.ListView
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnDelShipped As System.Windows.Forms.Button
    Friend WithEvents btnEditShipped As System.Windows.Forms.Button
    Friend WithEvents tbRefreshShipped As System.Windows.Forms.ToolBar
    Friend WithEvents panShippedDetails As System.Windows.Forms.Panel
    Friend WithEvents panShipped As System.Windows.Forms.Panel
    Friend WithEvents lvwShippedC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedDetailsC1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedDetailsC2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedDetailsC3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedDetailsC4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedDetailsC5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedDetailsC6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedDetailsC7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwShippedDetailsC8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents panShippedEditDetails As System.Windows.Forms.Panel
    Friend WithEvents panShippedEdit As System.Windows.Forms.Panel
    Friend WithEvents btnSaveSDtls As System.Windows.Forms.Button
    Friend WithEvents btnCancelSDtls As System.Windows.Forms.Button
    Friend WithEvents tab0P2 As System.Windows.Forms.TabPage
    Friend WithEvents tab0P3 As System.Windows.Forms.TabPage
    Friend WithEvents btnCheckAllSDtls As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStuHpvShip))
        Me.grpVisitDate = New System.Windows.Forms.GroupBox()
        Me.btnRefreshNS = New System.Windows.Forms.Button()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.dtsVisitDate2 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.dtsVisitDate1 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.cboSpecNS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbRefreshNS = New System.Windows.Forms.ToolBar()
        Me.tbRefreshNSb1 = New System.Windows.Forms.ToolBarButton()
        Me.ils16X16 = New System.Windows.Forms.ImageList(Me.components)
        Me.lvwNS = New System.Windows.Forms.ListView()
        Me.lvwNSC0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwNSC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwNSC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwNSC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwNSC4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwNSC5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwNSC6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwNSC7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSaveNS = New System.Windows.Forms.Button()
        Me.btnCancelNS = New System.Windows.Forms.Button()
        Me.tab0 = New System.Windows.Forms.TabControl()
        Me.tab0P1 = New System.Windows.Forms.TabPage()
        Me.btnCheckAllNS = New System.Windows.Forms.Button()
        Me.grpSaveNS = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtsDateShippedToSave = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab0P2 = New System.Windows.Forms.TabPage()
        Me.panShippedDetails = New System.Windows.Forms.Panel()
        Me.lvwShippedDetails = New System.Windows.Forms.ListView()
        Me.lvwShippedDetailsC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedDetailsC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedDetailsC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedDetailsC4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedDetailsC5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedDetailsC6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedDetailsC7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedDetailsC8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCheckAllSDtls = New System.Windows.Forms.Button()
        Me.panShippedEditDetails = New System.Windows.Forms.Panel()
        Me.btnSaveSDtls = New System.Windows.Forms.Button()
        Me.btnCancelSDtls = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.panShipped = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lvwShipped = New System.Windows.Forms.ListView()
        Me.lvwShippedC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwShippedC4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panShippedEdit = New System.Windows.Forms.Panel()
        Me.tbRefreshShipped = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.btnDelShipped = New System.Windows.Forms.Button()
        Me.btnEditShipped = New System.Windows.Forms.Button()
        Me.tab0P3 = New System.Windows.Forms.TabPage()
        Me.btnCheckAllS = New System.Windows.Forms.Button()
        Me.grpSaveS = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSaveS = New System.Windows.Forms.Button()
        Me.btnCancelS = New System.Windows.Forms.Button()
        Me.lvwS = New System.Windows.Forms.ListView()
        Me.lvwSC0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwSC1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwSC2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwSC3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwSC4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwSC5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwSC6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpShipDate = New System.Windows.Forms.GroupBox()
        Me.tbRefreshS = New System.Windows.Forms.ToolBar()
        Me.tbRefreshSb1 = New System.Windows.Forms.ToolBarButton()
        Me.btnRefreshS = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtsDateShipped2 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.dtsDateShipped1 = New Umbrae.Windows.Forms.DateTimeSlicker()
        Me.cboSpecS = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpVisitDate.SuspendLayout()
        Me.tab0.SuspendLayout()
        Me.tab0P1.SuspendLayout()
        Me.grpSaveNS.SuspendLayout()
        Me.tab0P2.SuspendLayout()
        Me.panShippedDetails.SuspendLayout()
        Me.panShippedEditDetails.SuspendLayout()
        Me.panShipped.SuspendLayout()
        Me.panShippedEdit.SuspendLayout()
        Me.tab0P3.SuspendLayout()
        Me.grpSaveS.SuspendLayout()
        Me.grpShipDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpVisitDate
        '
        Me.grpVisitDate.Controls.Add(Me.btnRefreshNS)
        Me.grpVisitDate.Controls.Add(Me.Label70)
        Me.grpVisitDate.Controls.Add(Me.dtsVisitDate2)
        Me.grpVisitDate.Controls.Add(Me.dtsVisitDate1)
        Me.grpVisitDate.Controls.Add(Me.cboSpecNS)
        Me.grpVisitDate.Controls.Add(Me.Label2)
        Me.grpVisitDate.Controls.Add(Me.Label3)
        Me.grpVisitDate.Controls.Add(Me.Label4)
        Me.grpVisitDate.Controls.Add(Me.tbRefreshNS)
        Me.grpVisitDate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpVisitDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVisitDate.Location = New System.Drawing.Point(3, 6)
        Me.grpVisitDate.Name = "grpVisitDate"
        Me.grpVisitDate.Size = New System.Drawing.Size(423, 59)
        Me.grpVisitDate.TabIndex = 113
        Me.grpVisitDate.TabStop = False
        '
        'btnRefreshNS
        '
        Me.btnRefreshNS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRefreshNS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshNS.ImageIndex = 1
        Me.btnRefreshNS.Location = New System.Drawing.Point(-25, 17)
        Me.btnRefreshNS.Name = "btnRefreshNS"
        Me.btnRefreshNS.Size = New System.Drawing.Size(51, 20)
        Me.btnRefreshNS.TabIndex = 124
        Me.btnRefreshNS.Text = "Refresh"
        Me.btnRefreshNS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefreshNS.Visible = False
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.SystemColors.Control
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label70.Location = New System.Drawing.Point(5, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(322, 15)
        Me.Label70.TabIndex = 123
        Me.Label70.Text = "Retrieve data:  Retrieve specimens that are not yet shipped by"
        '
        'dtsVisitDate2
        '
        Me.dtsVisitDate2.CustomFormat = "MM/dd/yyyy"
        Me.dtsVisitDate2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsVisitDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsVisitDate2.Location = New System.Drawing.Point(175, 32)
        Me.dtsVisitDate2.Name = "dtsVisitDate2"
        Me.dtsVisitDate2.ShowCheckBox = True
        Me.dtsVisitDate2.Size = New System.Drawing.Size(97, 21)
        Me.dtsVisitDate2.TabIndex = 121
        Me.dtsVisitDate2.Tag = "DateOfBirth"
        Me.dtsVisitDate2.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'dtsVisitDate1
        '
        Me.dtsVisitDate1.CustomFormat = "MM/dd/yyyy"
        Me.dtsVisitDate1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsVisitDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsVisitDate1.Location = New System.Drawing.Point(33, 32)
        Me.dtsVisitDate1.Name = "dtsVisitDate1"
        Me.dtsVisitDate1.ShowCheckBox = True
        Me.dtsVisitDate1.Size = New System.Drawing.Size(97, 21)
        Me.dtsVisitDate1.TabIndex = 120
        Me.dtsVisitDate1.Tag = "DateOfBirth"
        Me.dtsVisitDate1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'cboSpecNS
        '
        Me.cboSpecNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpecNS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecNS.Items.AddRange(New Object() {"Blood", "Other Specimens", "ALL"})
        Me.cboSpecNS.Location = New System.Drawing.Point(278, 32)
        Me.cboSpecNS.Name = "cboSpecNS"
        Me.cboSpecNS.Size = New System.Drawing.Size(111, 21)
        Me.cboSpecNS.TabIndex = 112
        Me.cboSpecNS.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 15)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = ">=                                and <="
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(73, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 15)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Date Collected (Visit Date)"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(261, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 15)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "and    Specimen Type"
        '
        'tbRefreshNS
        '
        Me.tbRefreshNS.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.tbRefreshNS.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbRefreshNSb1})
        Me.tbRefreshNS.ButtonSize = New System.Drawing.Size(16, 16)
        Me.tbRefreshNS.Divider = False
        Me.tbRefreshNS.Dock = System.Windows.Forms.DockStyle.None
        Me.tbRefreshNS.DropDownArrows = True
        Me.tbRefreshNS.ImageList = Me.ils16X16
        Me.tbRefreshNS.Location = New System.Drawing.Point(393, 31)
        Me.tbRefreshNS.Name = "tbRefreshNS"
        Me.tbRefreshNS.ShowToolTips = True
        Me.tbRefreshNS.Size = New System.Drawing.Size(26, 26)
        Me.tbRefreshNS.TabIndex = 121
        '
        'tbRefreshNSb1
        '
        Me.tbRefreshNSb1.ImageIndex = 0
        Me.tbRefreshNSb1.Name = "tbRefreshNSb1"
        Me.tbRefreshNSb1.ToolTipText = "Click to refresh the Specimen List below"
        '
        'ils16X16
        '
        Me.ils16X16.ImageStream = CType(resources.GetObject("ils16X16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ils16X16.TransparentColor = System.Drawing.Color.Transparent
        Me.ils16X16.Images.SetKeyName(0, "")
        '
        'lvwNS
        '
        Me.lvwNS.AllowColumnReorder = True
        Me.lvwNS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwNS.CheckBoxes = True
        Me.lvwNS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwNSC0, Me.lvwNSC1, Me.lvwNSC2, Me.lvwNSC3, Me.lvwNSC4, Me.lvwNSC5, Me.lvwNSC6, Me.lvwNSC7})
        Me.lvwNS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwNS.FullRowSelect = True
        Me.lvwNS.GridLines = True
        Me.lvwNS.HideSelection = False
        Me.lvwNS.Location = New System.Drawing.Point(3, 67)
        Me.lvwNS.MultiSelect = False
        Me.lvwNS.Name = "lvwNS"
        Me.lvwNS.Size = New System.Drawing.Size(1147, 588)
        Me.lvwNS.TabIndex = 116
        Me.lvwNS.UseCompatibleStateImageBehavior = False
        Me.lvwNS.View = System.Windows.Forms.View.Details
        '
        'lvwNSC0
        '
        Me.lvwNSC0.Text = "Ship"
        Me.lvwNSC0.Width = 71
        '
        'lvwNSC1
        '
        Me.lvwNSC1.Text = "Date Collected"
        Me.lvwNSC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwNSC1.Width = 88
        '
        'lvwNSC2
        '
        Me.lvwNSC2.Text = "Specimen Name"
        Me.lvwNSC2.Width = 169
        '
        'lvwNSC3
        '
        Me.lvwNSC3.Text = "Specimen ID"
        Me.lvwNSC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwNSC3.Width = 79
        '
        'lvwNSC4
        '
        Me.lvwNSC4.Text = "Subject ID"
        Me.lvwNSC4.Width = 94
        '
        'lvwNSC5
        '
        Me.lvwNSC5.Text = "Patient Name"
        Me.lvwNSC5.Width = 179
        '
        'lvwNSC6
        '
        Me.lvwNSC6.Text = "MRN"
        Me.lvwNSC6.Width = 70
        '
        'lvwNSC7
        '
        Me.lvwNSC7.Text = "Visit #"
        Me.lvwNSC7.Width = 50
        '
        'btnSaveNS
        '
        Me.btnSaveNS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaveNS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNS.ImageIndex = 1
        Me.btnSaveNS.Location = New System.Drawing.Point(6, 17)
        Me.btnSaveNS.Name = "btnSaveNS"
        Me.btnSaveNS.Size = New System.Drawing.Size(39, 20)
        Me.btnSaveNS.TabIndex = 117
        Me.btnSaveNS.Text = "Save"
        Me.btnSaveNS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnSaveNS, "Click to save changes.")
        '
        'btnCancelNS
        '
        Me.btnCancelNS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelNS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelNS.ImageIndex = 1
        Me.btnCancelNS.Location = New System.Drawing.Point(48, 17)
        Me.btnCancelNS.Name = "btnCancelNS"
        Me.btnCancelNS.Size = New System.Drawing.Size(45, 20)
        Me.btnCancelNS.TabIndex = 118
        Me.btnCancelNS.Text = "Cancel"
        Me.btnCancelNS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnCancelNS, "Click to cancel/undo ALL changes.")
        '
        'tab0
        '
        Me.tab0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab0.Controls.Add(Me.tab0P1)
        Me.tab0.Controls.Add(Me.tab0P2)
        Me.tab0.Controls.Add(Me.tab0P3)
        Me.tab0.Location = New System.Drawing.Point(2, 2)
        Me.tab0.Name = "tab0"
        Me.tab0.SelectedIndex = 0
        Me.tab0.Size = New System.Drawing.Size(1162, 684)
        Me.tab0.TabIndex = 119
        '
        'tab0P1
        '
        Me.tab0P1.Controls.Add(Me.btnCheckAllNS)
        Me.tab0P1.Controls.Add(Me.grpSaveNS)
        Me.tab0P1.Controls.Add(Me.lvwNS)
        Me.tab0P1.Controls.Add(Me.grpVisitDate)
        Me.tab0P1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab0P1.Location = New System.Drawing.Point(4, 22)
        Me.tab0P1.Name = "tab0P1"
        Me.tab0P1.Size = New System.Drawing.Size(1154, 658)
        Me.tab0P1.TabIndex = 0
        Me.tab0P1.Text = "Unshipped"
        '
        'btnCheckAllNS
        '
        Me.btnCheckAllNS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCheckAllNS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllNS.ImageIndex = 1
        Me.btnCheckAllNS.Location = New System.Drawing.Point(535, 23)
        Me.btnCheckAllNS.Name = "btnCheckAllNS"
        Me.btnCheckAllNS.Size = New System.Drawing.Size(66, 20)
        Me.btnCheckAllNS.TabIndex = 120
        Me.btnCheckAllNS.Text = "Check All"
        Me.btnCheckAllNS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnCheckAllNS, "Click to check or uncheck ALL items")
        '
        'grpSaveNS
        '
        Me.grpSaveNS.Controls.Add(Me.Label5)
        Me.grpSaveNS.Controls.Add(Me.dtsDateShippedToSave)
        Me.grpSaveNS.Controls.Add(Me.Label1)
        Me.grpSaveNS.Controls.Add(Me.btnSaveNS)
        Me.grpSaveNS.Controls.Add(Me.btnCancelNS)
        Me.grpSaveNS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpSaveNS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSaveNS.Location = New System.Drawing.Point(435, 6)
        Me.grpSaveNS.Name = "grpSaveNS"
        Me.grpSaveNS.Size = New System.Drawing.Size(173, 43)
        Me.grpSaveNS.TabIndex = 119
        Me.grpSaveNS.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Edit/Save data"
        '
        'dtsDateShippedToSave
        '
        Me.dtsDateShippedToSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsDateShippedToSave.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtsDateShippedToSave.Location = New System.Drawing.Point(238, 16)
        Me.dtsDateShippedToSave.Name = "dtsDateShippedToSave"
        Me.dtsDateShippedToSave.ShowCheckBox = True
        Me.dtsDateShippedToSave.Size = New System.Drawing.Size(99, 21)
        Me.dtsDateShippedToSave.TabIndex = 119
        Me.dtsDateShippedToSave.Tag = "DateOfBirth"
        Me.dtsDateShippedToSave.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        Me.dtsDateShippedToSave.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(164, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Date Shipped"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Visible = False
        '
        'tab0P2
        '
        Me.tab0P2.Controls.Add(Me.panShippedDetails)
        Me.tab0P2.Controls.Add(Me.Splitter1)
        Me.tab0P2.Controls.Add(Me.panShipped)
        Me.tab0P2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab0P2.Location = New System.Drawing.Point(4, 22)
        Me.tab0P2.Name = "tab0P2"
        Me.tab0P2.Size = New System.Drawing.Size(668, 389)
        Me.tab0P2.TabIndex = 2
        Me.tab0P2.Text = "Shipped"
        '
        'panShippedDetails
        '
        Me.panShippedDetails.BackColor = System.Drawing.SystemColors.Control
        Me.panShippedDetails.Controls.Add(Me.lvwShippedDetails)
        Me.panShippedDetails.Controls.Add(Me.Label12)
        Me.panShippedDetails.Controls.Add(Me.btnCheckAllSDtls)
        Me.panShippedDetails.Controls.Add(Me.panShippedEditDetails)
        Me.panShippedDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.panShippedDetails.Location = New System.Drawing.Point(293, 0)
        Me.panShippedDetails.Name = "panShippedDetails"
        Me.panShippedDetails.Size = New System.Drawing.Size(375, 351)
        Me.panShippedDetails.TabIndex = 2
        '
        'lvwShippedDetails
        '
        Me.lvwShippedDetails.AllowColumnReorder = True
        Me.lvwShippedDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwShippedDetails.CheckBoxes = True
        Me.lvwShippedDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwShippedDetailsC1, Me.lvwShippedDetailsC2, Me.lvwShippedDetailsC3, Me.lvwShippedDetailsC4, Me.lvwShippedDetailsC5, Me.lvwShippedDetailsC6, Me.lvwShippedDetailsC7, Me.lvwShippedDetailsC8})
        Me.lvwShippedDetails.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwShippedDetails.FullRowSelect = True
        Me.lvwShippedDetails.GridLines = True
        Me.lvwShippedDetails.HideSelection = False
        Me.lvwShippedDetails.Location = New System.Drawing.Point(0, 26)
        Me.lvwShippedDetails.MultiSelect = False
        Me.lvwShippedDetails.Name = "lvwShippedDetails"
        Me.lvwShippedDetails.Size = New System.Drawing.Size(373, 291)
        Me.lvwShippedDetails.TabIndex = 128
        Me.lvwShippedDetails.UseCompatibleStateImageBehavior = False
        Me.lvwShippedDetails.View = System.Windows.Forms.View.Details
        '
        'lvwShippedDetailsC1
        '
        Me.lvwShippedDetailsC1.Text = "Shipped"
        Me.lvwShippedDetailsC1.Width = 55
        '
        'lvwShippedDetailsC2
        '
        Me.lvwShippedDetailsC2.Text = "Date Collected"
        Me.lvwShippedDetailsC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwShippedDetailsC2.Width = 88
        '
        'lvwShippedDetailsC3
        '
        Me.lvwShippedDetailsC3.Text = "Specimen Name"
        Me.lvwShippedDetailsC3.Width = 139
        '
        'lvwShippedDetailsC4
        '
        Me.lvwShippedDetailsC4.Text = "Spec. ID"
        Me.lvwShippedDetailsC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwShippedDetailsC4.Width = 79
        '
        'lvwShippedDetailsC5
        '
        Me.lvwShippedDetailsC5.Text = "Subject ID"
        Me.lvwShippedDetailsC5.Width = 80
        '
        'lvwShippedDetailsC6
        '
        Me.lvwShippedDetailsC6.Text = "Patient Name"
        Me.lvwShippedDetailsC6.Width = 145
        '
        'lvwShippedDetailsC7
        '
        Me.lvwShippedDetailsC7.Text = "MRN"
        Me.lvwShippedDetailsC7.Width = 70
        '
        'lvwShippedDetailsC8
        '
        Me.lvwShippedDetailsC8.Text = "Visit #"
        Me.lvwShippedDetailsC8.Width = 50
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(3, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 15)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "Specimens shipped"
        '
        'btnCheckAllSDtls
        '
        Me.btnCheckAllSDtls.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCheckAllSDtls.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllSDtls.ImageIndex = 1
        Me.btnCheckAllSDtls.Location = New System.Drawing.Point(221, 3)
        Me.btnCheckAllSDtls.Name = "btnCheckAllSDtls"
        Me.btnCheckAllSDtls.Size = New System.Drawing.Size(66, 20)
        Me.btnCheckAllSDtls.TabIndex = 125
        Me.btnCheckAllSDtls.Text = "Uncheck All"
        Me.btnCheckAllSDtls.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnCheckAllSDtls, "Click to check or uncheck ALL items")
        '
        'panShippedEditDetails
        '
        Me.panShippedEditDetails.Controls.Add(Me.btnSaveSDtls)
        Me.panShippedEditDetails.Controls.Add(Me.btnCancelSDtls)
        Me.panShippedEditDetails.Location = New System.Drawing.Point(120, 3)
        Me.panShippedEditDetails.Name = "panShippedEditDetails"
        Me.panShippedEditDetails.Size = New System.Drawing.Size(95, 24)
        Me.panShippedEditDetails.TabIndex = 130
        '
        'btnSaveSDtls
        '
        Me.btnSaveSDtls.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaveSDtls.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSDtls.ImageIndex = 1
        Me.btnSaveSDtls.Location = New System.Drawing.Point(0, 0)
        Me.btnSaveSDtls.Name = "btnSaveSDtls"
        Me.btnSaveSDtls.Size = New System.Drawing.Size(39, 20)
        Me.btnSaveSDtls.TabIndex = 117
        Me.btnSaveSDtls.Text = "Save"
        Me.btnSaveSDtls.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnSaveSDtls, "Click to save changes.")
        '
        'btnCancelSDtls
        '
        Me.btnCancelSDtls.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelSDtls.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSDtls.ImageIndex = 1
        Me.btnCancelSDtls.Location = New System.Drawing.Point(44, 0)
        Me.btnCancelSDtls.Name = "btnCancelSDtls"
        Me.btnCancelSDtls.Size = New System.Drawing.Size(45, 20)
        Me.btnCancelSDtls.TabIndex = 118
        Me.btnCancelSDtls.Text = "Cancel"
        Me.btnCancelSDtls.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnCancelSDtls, "Click to cancel/undo ALL changes.")
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Splitter1.Location = New System.Drawing.Point(291, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(2, 389)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'panShipped
        '
        Me.panShipped.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.panShipped.Controls.Add(Me.Label7)
        Me.panShipped.Controls.Add(Me.lvwShipped)
        Me.panShipped.Controls.Add(Me.panShippedEdit)
        Me.panShipped.Dock = System.Windows.Forms.DockStyle.Left
        Me.panShipped.Location = New System.Drawing.Point(0, 0)
        Me.panShipped.Name = "panShipped"
        Me.panShipped.Size = New System.Drawing.Size(291, 389)
        Me.panShipped.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(2, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "Shipments"
        '
        'lvwShipped
        '
        Me.lvwShipped.AllowColumnReorder = True
        Me.lvwShipped.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwShipped.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwShippedC1, Me.lvwShippedC2, Me.lvwShippedC3, Me.lvwShippedC4})
        Me.lvwShipped.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwShipped.FullRowSelect = True
        Me.lvwShipped.GridLines = True
        Me.lvwShipped.HideSelection = False
        Me.lvwShipped.Location = New System.Drawing.Point(2, 26)
        Me.lvwShipped.MultiSelect = False
        Me.lvwShipped.Name = "lvwShipped"
        Me.lvwShipped.Size = New System.Drawing.Size(288, 360)
        Me.lvwShipped.TabIndex = 127
        Me.lvwShipped.UseCompatibleStateImageBehavior = False
        Me.lvwShipped.View = System.Windows.Forms.View.Details
        '
        'lvwShippedC1
        '
        Me.lvwShippedC1.Text = ""
        Me.lvwShippedC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwShippedC1.Width = 0
        '
        'lvwShippedC2
        '
        Me.lvwShippedC2.Text = "Ship. ID"
        Me.lvwShippedC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwShippedC2.Width = 71
        '
        'lvwShippedC3
        '
        Me.lvwShippedC3.Text = "Date Shipped"
        Me.lvwShippedC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwShippedC3.Width = 88
        '
        'lvwShippedC4
        '
        Me.lvwShippedC4.Text = "Notes"
        Me.lvwShippedC4.Width = 248
        '
        'panShippedEdit
        '
        Me.panShippedEdit.Controls.Add(Me.tbRefreshShipped)
        Me.panShippedEdit.Controls.Add(Me.btnDelShipped)
        Me.panShippedEdit.Controls.Add(Me.btnEditShipped)
        Me.panShippedEdit.Location = New System.Drawing.Point(70, 3)
        Me.panShippedEdit.Name = "panShippedEdit"
        Me.panShippedEdit.Size = New System.Drawing.Size(145, 24)
        Me.panShippedEdit.TabIndex = 130
        '
        'tbRefreshShipped
        '
        Me.tbRefreshShipped.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.tbRefreshShipped.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1})
        Me.tbRefreshShipped.ButtonSize = New System.Drawing.Size(16, 16)
        Me.tbRefreshShipped.Divider = False
        Me.tbRefreshShipped.Dock = System.Windows.Forms.DockStyle.None
        Me.tbRefreshShipped.DropDownArrows = True
        Me.tbRefreshShipped.ImageList = Me.ils16X16
        Me.tbRefreshShipped.Location = New System.Drawing.Point(86, 0)
        Me.tbRefreshShipped.Name = "tbRefreshShipped"
        Me.tbRefreshShipped.ShowToolTips = True
        Me.tbRefreshShipped.Size = New System.Drawing.Size(26, 26)
        Me.tbRefreshShipped.TabIndex = 130
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.ToolTipText = "Click to refresh the list below"
        '
        'btnDelShipped
        '
        Me.btnDelShipped.Enabled = False
        Me.btnDelShipped.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelShipped.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelShipped.ImageIndex = 1
        Me.btnDelShipped.Location = New System.Drawing.Point(41, 0)
        Me.btnDelShipped.Name = "btnDelShipped"
        Me.btnDelShipped.Size = New System.Drawing.Size(40, 20)
        Me.btnDelShipped.TabIndex = 129
        Me.btnDelShipped.Text = "Delete"
        Me.btnDelShipped.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEditShipped
        '
        Me.btnEditShipped.Enabled = False
        Me.btnEditShipped.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEditShipped.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditShipped.ImageIndex = 1
        Me.btnEditShipped.Location = New System.Drawing.Point(0, 0)
        Me.btnEditShipped.Name = "btnEditShipped"
        Me.btnEditShipped.Size = New System.Drawing.Size(36, 20)
        Me.btnEditShipped.TabIndex = 128
        Me.btnEditShipped.Text = "Edit"
        Me.btnEditShipped.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tab0P3
        '
        Me.tab0P3.Controls.Add(Me.btnCheckAllS)
        Me.tab0P3.Controls.Add(Me.grpSaveS)
        Me.tab0P3.Controls.Add(Me.lvwS)
        Me.tab0P3.Controls.Add(Me.grpShipDate)
        Me.tab0P3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab0P3.Location = New System.Drawing.Point(4, 22)
        Me.tab0P3.Name = "tab0P3"
        Me.tab0P3.Size = New System.Drawing.Size(668, 389)
        Me.tab0P3.TabIndex = 1
        Me.tab0P3.Text = "Shipped"
        '
        'btnCheckAllS
        '
        Me.btnCheckAllS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCheckAllS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllS.ImageIndex = 1
        Me.btnCheckAllS.Location = New System.Drawing.Point(556, 23)
        Me.btnCheckAllS.Name = "btnCheckAllS"
        Me.btnCheckAllS.Size = New System.Drawing.Size(66, 20)
        Me.btnCheckAllS.TabIndex = 124
        Me.btnCheckAllS.Text = "Uncheck All"
        Me.btnCheckAllS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnCheckAllS, "Click to check or uncheck ALL items")
        '
        'grpSaveS
        '
        Me.grpSaveS.Controls.Add(Me.Label6)
        Me.grpSaveS.Controls.Add(Me.btnSaveS)
        Me.grpSaveS.Controls.Add(Me.btnCancelS)
        Me.grpSaveS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpSaveS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSaveS.Location = New System.Drawing.Point(435, 6)
        Me.grpSaveS.Name = "grpSaveS"
        Me.grpSaveS.Size = New System.Drawing.Size(342, 43)
        Me.grpSaveS.TabIndex = 123
        Me.grpSaveS.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Edit/Save data:  "
        '
        'btnSaveS
        '
        Me.btnSaveS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaveS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveS.ImageIndex = 1
        Me.btnSaveS.Location = New System.Drawing.Point(6, 17)
        Me.btnSaveS.Name = "btnSaveS"
        Me.btnSaveS.Size = New System.Drawing.Size(39, 20)
        Me.btnSaveS.TabIndex = 117
        Me.btnSaveS.Text = "Save"
        Me.btnSaveS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnSaveS, "Click to save changes.")
        '
        'btnCancelS
        '
        Me.btnCancelS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelS.ImageIndex = 1
        Me.btnCancelS.Location = New System.Drawing.Point(48, 17)
        Me.btnCancelS.Name = "btnCancelS"
        Me.btnCancelS.Size = New System.Drawing.Size(45, 20)
        Me.btnCancelS.TabIndex = 118
        Me.btnCancelS.Text = "Cancel"
        Me.btnCancelS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.btnCancelS, "Click to cancel/undo ALL changes.")
        '
        'lvwS
        '
        Me.lvwS.AllowColumnReorder = True
        Me.lvwS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwS.CheckBoxes = True
        Me.lvwS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvwSC0, Me.lvwSC1, Me.lvwSC2, Me.lvwSC3, Me.lvwSC4, Me.lvwSC5, Me.lvwSC6})
        Me.lvwS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwS.FullRowSelect = True
        Me.lvwS.GridLines = True
        Me.lvwS.Location = New System.Drawing.Point(3, 67)
        Me.lvwS.MultiSelect = False
        Me.lvwS.Name = "lvwS"
        Me.lvwS.Size = New System.Drawing.Size(661, 319)
        Me.lvwS.TabIndex = 122
        Me.lvwS.UseCompatibleStateImageBehavior = False
        Me.lvwS.View = System.Windows.Forms.View.Details
        '
        'lvwSC0
        '
        Me.lvwSC0.Text = "Shipped"
        '
        'lvwSC1
        '
        Me.lvwSC1.Text = "Date Shipped"
        Me.lvwSC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvwSC1.Width = 88
        '
        'lvwSC2
        '
        Me.lvwSC2.Text = "Specimen Name"
        Me.lvwSC2.Width = 169
        '
        'lvwSC3
        '
        Me.lvwSC3.Text = "Specimen ID"
        Me.lvwSC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvwSC3.Width = 79
        '
        'lvwSC4
        '
        Me.lvwSC4.Text = "Subject ID"
        Me.lvwSC4.Width = 94
        '
        'lvwSC5
        '
        Me.lvwSC5.Text = "Patient Name"
        Me.lvwSC5.Width = 179
        '
        'lvwSC6
        '
        Me.lvwSC6.Text = "MRN"
        Me.lvwSC6.Width = 70
        '
        'grpShipDate
        '
        Me.grpShipDate.Controls.Add(Me.tbRefreshS)
        Me.grpShipDate.Controls.Add(Me.btnRefreshS)
        Me.grpShipDate.Controls.Add(Me.Label8)
        Me.grpShipDate.Controls.Add(Me.dtsDateShipped2)
        Me.grpShipDate.Controls.Add(Me.dtsDateShipped1)
        Me.grpShipDate.Controls.Add(Me.cboSpecS)
        Me.grpShipDate.Controls.Add(Me.Label9)
        Me.grpShipDate.Controls.Add(Me.Label10)
        Me.grpShipDate.Controls.Add(Me.Label11)
        Me.grpShipDate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpShipDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpShipDate.Location = New System.Drawing.Point(3, 6)
        Me.grpShipDate.Name = "grpShipDate"
        Me.grpShipDate.Size = New System.Drawing.Size(423, 58)
        Me.grpShipDate.TabIndex = 121
        Me.grpShipDate.TabStop = False
        '
        'tbRefreshS
        '
        Me.tbRefreshS.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.tbRefreshS.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbRefreshSb1})
        Me.tbRefreshS.ButtonSize = New System.Drawing.Size(16, 16)
        Me.tbRefreshS.Divider = False
        Me.tbRefreshS.Dock = System.Windows.Forms.DockStyle.None
        Me.tbRefreshS.DropDownArrows = True
        Me.tbRefreshS.ImageList = Me.ils16X16
        Me.tbRefreshS.Location = New System.Drawing.Point(393, 31)
        Me.tbRefreshS.Name = "tbRefreshS"
        Me.tbRefreshS.ShowToolTips = True
        Me.tbRefreshS.Size = New System.Drawing.Size(26, 26)
        Me.tbRefreshS.TabIndex = 126
        '
        'tbRefreshSb1
        '
        Me.tbRefreshSb1.ImageIndex = 0
        Me.tbRefreshSb1.Name = "tbRefreshSb1"
        '
        'btnRefreshS
        '
        Me.btnRefreshS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRefreshS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshS.ImageIndex = 1
        Me.btnRefreshS.Location = New System.Drawing.Point(-20, 15)
        Me.btnRefreshS.Name = "btnRefreshS"
        Me.btnRefreshS.Size = New System.Drawing.Size(51, 20)
        Me.btnRefreshS.TabIndex = 125
        Me.btnRefreshS.Text = "Refresh"
        Me.btnRefreshS.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefreshS.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(291, 15)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Retrieve data:  Retrieve specimens that were shipped by"
        '
        'dtsDateShipped2
        '
        Me.dtsDateShipped2.CustomFormat = "MM/dd/yyyy"
        Me.dtsDateShipped2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsDateShipped2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsDateShipped2.Location = New System.Drawing.Point(175, 32)
        Me.dtsDateShipped2.Name = "dtsDateShipped2"
        Me.dtsDateShipped2.ShowCheckBox = True
        Me.dtsDateShipped2.Size = New System.Drawing.Size(97, 21)
        Me.dtsDateShipped2.TabIndex = 121
        Me.dtsDateShipped2.Tag = "DateOfBirth"
        Me.dtsDateShipped2.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'dtsDateShipped1
        '
        Me.dtsDateShipped1.CustomFormat = "MM/dd/yyyy"
        Me.dtsDateShipped1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtsDateShipped1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtsDateShipped1.Location = New System.Drawing.Point(33, 32)
        Me.dtsDateShipped1.Name = "dtsDateShipped1"
        Me.dtsDateShipped1.ShowCheckBox = True
        Me.dtsDateShipped1.Size = New System.Drawing.Size(97, 21)
        Me.dtsDateShipped1.TabIndex = 120
        Me.dtsDateShipped1.Tag = "DateOfBirth"
        Me.dtsDateShipped1.Value = New Date(2007, 10, 24, 15, 4, 23, 93)
        '
        'cboSpecS
        '
        Me.cboSpecS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpecS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpecS.Items.AddRange(New Object() {"Blood", "Other Specimens", "ALL"})
        Me.cboSpecS.Location = New System.Drawing.Point(278, 32)
        Me.cboSpecS.Name = "cboSpecS"
        Me.cboSpecS.Size = New System.Drawing.Size(111, 21)
        Me.cboSpecS.TabIndex = 112
        Me.cboSpecS.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(252, 15)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = ">=                                and <="
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(73, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 15)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Date shipped"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(261, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 15)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "and    Specimen Type"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 1
        Me.btnExit.Location = New System.Drawing.Point(767, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 20)
        Me.btnExit.TabIndex = 121
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Visible = False
        '
        'frmStuHpvShip
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1166, 688)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tab0)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(200, 227)
        Me.Name = "frmStuHpvShip"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specimen Shipment Tracking"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpVisitDate.ResumeLayout(False)
        Me.grpVisitDate.PerformLayout()
        Me.tab0.ResumeLayout(False)
        Me.tab0P1.ResumeLayout(False)
        Me.grpSaveNS.ResumeLayout(False)
        Me.tab0P2.ResumeLayout(False)
        Me.panShippedDetails.ResumeLayout(False)
        Me.panShippedEditDetails.ResumeLayout(False)
        Me.panShipped.ResumeLayout(False)
        Me.panShippedEdit.ResumeLayout(False)
        Me.panShippedEdit.PerformLayout()
        Me.tab0P3.ResumeLayout(False)
        Me.grpSaveS.ResumeLayout(False)
        Me.grpShipDate.ResumeLayout(False)
        Me.grpShipDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FormActivated As Boolean = False
    Dim Fill_lvwNS_Count As Integer
    Dim cboSpecNSOldValue As String, cboSpecSOldValue As String
    'Dim VisitDate1OldValue As Date, VisitDate2OldValue As Date

    Private Sub frmStuHpvShip_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Editors = New Control() {Me.chkSent}
        'AddHandler chkSent.Click, AddressOf control_SelectedValueChanged

        Try

            'Don't need this now but might later!
            Me.tab0.TabPages.Remove(Me.tab0.TabPages(2))

            '' Not shipped
            Me.dtsVisitDate1.Value = Today.AddDays(-1)
            'VisitDate1OldValue = Me.dtsVisitDate1.Value
            Me.dtsVisitDate2.MinDate = Me.dtsVisitDate1.Value
            Me.dtsVisitDate2.Value = Today.AddDays(-1)
            Me.cboSpecNS.Text = "Blood"
            cboSpecNSOldValue = Me.cboSpecNS.Text

            Me.dtsDateShippedToSave.Value = Today
            Me.dtsDateShippedToSave.Checked = False
            Fill_lvwNS()
            SortLvw(lvwNS, 1, False)

            Dim ColPosNS() As Integer
            ReDim ColPosNS(lvwNS.Columns.Count - 1)
            ColPosNS(0) = 1 'ColPos(0) refers to position 0 so this means put column 1 in pos 0
            ColPosNS(1) = 2
            ColPosNS(2) = 3
            ColPosNS(3) = 4
            ColPosNS(4) = 5
            ColPosNS(5) = 6
            ColPosNS(6) = 7
            ColPosNS(7) = 0
            SetColumnOrder(lvwNS, ColPosNS)

            '' Shipped
            'Set_TabPages2()

            '' Shipped new
            Me.tab0.SelectedIndex = 1 'must goto this tab to retrieve Me.lvwShipped.SelectedItems(0).SubItems(1).Text
            Fill_lvwShipped()
            Me.tab0.SelectedIndex = 0

            Splitter1_SplitterMoved(Nothing, Nothing)

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Set_TabPages2()
        Me.dtsDateShipped1.Value = Today.AddDays(-1)
        Me.dtsDateShipped2.MinDate = Me.dtsDateShipped1.Value
        Me.dtsDateShipped2.Value = Today.AddDays(-1)
        Me.cboSpecS.Text = "Blood"
        cboSpecSOldValue = Me.cboSpecS.Text

        Fill_lvwS()
        SortLvw(lvwS, 1, False)

        Dim ColPosS() As Integer
        ReDim ColPosS(lvwS.Columns.Count - 1)
        ColPosS(0) = 1 'ColPos(0) refers to position 0 so this means put column 1 in pos 0
        ColPosS(1) = 2
        ColPosS(2) = 3
        ColPosS(3) = 4
        ColPosS(4) = 5
        ColPosS(5) = 6
        ColPosS(6) = 0
        SetColumnOrder(lvwS, ColPosS)
    End Sub

    Private Sub frmStuHpvShip_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub

    Private Sub frmStuHpvShip_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmStuHpvShip = Nothing
    End Sub

    Friend Sub LockControls(ByVal Lock As Boolean)

        If Lock Then

            Me.ControlBox = False
            vfrmMDI.ControlBox = False
            vfrmMDI.mnuFileExit.Enabled = False
            'Me.btnExit.Enabled = False

            Me.tab0.TabPages(0).Enabled = False
            Me.tab0.TabPages(1).Enabled = False
            'Me.tab0.TabPages(2).Enabled = False
            Me.tab0.TabPages(tab0.SelectedIndex).Enabled = True

            Select Case tab0.SelectedIndex
                Case 0
                    Me.grpVisitDate.Enabled = False
                    grpSaveNS.Enabled = True
                Case 1
                    Me.panShipped.Enabled = False
                    panShippedEditDetails.Enabled = True
                Case 2
                    Me.grpShipDate.Enabled = False
                    grpSaveS.Enabled = True
            End Select

        Else

            Me.ControlBox = True
            vfrmMDI.ControlBox = True
            vfrmMDI.mnuFileExit.Enabled = True
            'Me.btnExit.Enabled = True

            Me.tab0.TabPages(0).Enabled = True
            Me.tab0.TabPages(1).Enabled = True
            'Me.tab0.TabPages(2).Enabled = True

            Select Case tab0.SelectedIndex
                Case 0
                    Me.grpVisitDate.Enabled = True
                    grpSaveNS.Enabled = False
                Case 1
                    Me.panShipped.Enabled = True
                    panShippedEditDetails.Enabled = False
                Case 2
                    Me.grpShipDate.Enabled = True
                    grpSaveS.Enabled = False
            End Select

        End If

    End Sub

    Private Sub Splitter1_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles Splitter1.SplitterMoved

        Me.panShippedDetails.Height = Me.panShipped.Height
        Me.lvwShippedDetails.Height = Me.lvwShipped.Height

    End Sub

    Private Sub frmStuHpvShip_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Splitter1_SplitterMoved(Nothing, Nothing)
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
        liSuccess = ListViewColumnOrder(ListViewToReorder.Handle.ToInt32, liSetColumnOrderArray, SortOrder.Length, SortOrder(0))
        If Not liSuccess.Equals(0) Then
            ListViewToReorder.Refresh()
        End If
    End Sub




    'Event handlers for NOT SHIPPED '''''''''''''''''''''''''''''''''''''''''''''''''''

    Friend Sub Fill_lvwNS()

        'Fill_lvwNS_Count = Fill_lvwNS_Count + 1
        'Me.Text = Fill_lvwNS_Count

        'Me.btnSaveNS.Enabled = False
        grpSaveNS.Enabled = False

        Dim strDateRange As String = ""
        If Me.dtsVisitDate1.Checked = True And Me.dtsVisitDate2.Checked = False Then
            strDateRange = " AND tbStuHpvPatVisit.VisitDate >= #" & _
              Me.dtsVisitDate1.Value & "# "
        ElseIf Me.dtsVisitDate1.Checked = False And Me.dtsVisitDate2.Checked = True Then
            strDateRange = " AND tbStuHpvPatVisit.VisitDate <= #" & _
              Me.dtsVisitDate2.Value & "# "
        ElseIf Me.dtsVisitDate1.Checked = True And Me.dtsVisitDate2.Checked = True Then
            strDateRange = " AND tbStuHpvPatVisit.VisitDate BETWEEN #" & _
              Me.dtsVisitDate1.Value & "# AND #" & Me.dtsVisitDate2.Value & "# "
        End If

        Dim strProcs As String = ""
        Select Case Me.cboSpecNS.Text
            Case "Blood"
                strProcs = " AND ProcDesc='Blood draw (Einstein)'"
            Case "Other Specimens"
                strProcs = " AND ProcDesc IN ('Anal Pap (Einstein)','Cervical Pap (Einstein)','Oral Lavage (Einstein)','Penile Swab (Head) (Einstein)','Penile Swab (Shaft) (Einstein)')"
        End Select

        'Kirk 11/1/08 chaning VisitNum to VisitNumDescShort with 'LEFT JOIN ddvStuHpvVisitNum ON tbStuHpvPatVisit.VisitNum = ddvStuHpvVisitNum.VisitNum)'
        Dim strSQL As String
        strSQL = _
        "SELECT '' AS Sent, tbStuHpvPatVisit.VisitDate, ProcDesc, tbStuHpvPatVisitProcAct.VisitProcActID, SubjectID, [LastName] & ', ' & [FirstName] AS Name, MRN, VisitNumDescShort " & _
        "FROM (((((tbStuHpvPatVisitProcAct LEFT JOIN ddvProcedure ON tbStuHpvPatVisitProcAct.ProcCd = ddvProcedure.ProcCd) LEFT JOIN tbStuHpvPatVisit ON tbStuHpvPatVisitProcAct.VisitID = tbStuHpvPatVisit.VisitID) LEFT JOIN ddvStuHpvVisitNum ON tbStuHpvPatVisit.VisitNum = ddvStuHpvVisitNum.VisitNum) LEFT JOIN tbStuHpvEpisode ON tbStuHpvPatVisit.EpisodeID = tbStuHpvEpisode.EpisodeID) LEFT JOIN tbPatient ON tbStuHpvEpisode.PatientID = tbPatient.PatientID) LEFT JOIN (tbStuHpvPatVisitSpecShipped RIGHT JOIN tbStuHpvPatVisitSpecShippedDetails ON tbStuHpvPatVisitSpecShipped.ShipmentID = tbStuHpvPatVisitSpecShippedDetails.ShipmentID) ON tbStuHpvPatVisitProcAct.VisitProcActID = tbStuHpvPatVisitSpecShippedDetails.VisitProcActID " & _
        "WHERE DateShipped Is Null AND " & _
              "ddvProcedure.Site='EI' AND " & _
              "ActivityCd=2 " & strDateRange & strProcs
        'Console.WriteLine(strSQL)
        Call Fill_lvw(Me.lvwNS, strSQL, , False)
        ShowTotalOnLvw(lvwNS, 2)
        lvwNS_CheckedItemsCount = 0 'need this!
        ShowTotalOnLvw(lvwNS, 0, lvwNS_CheckedItemsCount)

    End Sub
    Private Sub dtsVisitDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles dtsVisitDate1.TextChanged, dtsVisitDate2.TextChanged
        If FormActivated Then
            If sender.name = "dtsVisitDate1" Then Me.dtsVisitDate2.MinDate = Me.dtsVisitDate1.Value
            Fill_lvwNS()
        End If
    End Sub
    Private Sub dtsVisitDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles dtsVisitDate1.CheckedChanged, dtsVisitDate2.CheckedChanged
        If FormActivated Then
            Fill_lvwNS()
        End If
    End Sub
    Private Sub cboSpecNS_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSpecNS.SelectedValueChanged
        If FormActivated Then
            If cboSpecNS.Text <> cboSpecNSOldValue Then
                cboSpecNSOldValue = cboSpecNS.Text
                Fill_lvwNS()
            End If
        End If
    End Sub
    Private Sub btnRefreshNS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshNS.Click
        'Fill_lvwNS()
    End Sub
    Private Sub tbRefreshNS_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbRefreshNS.ButtonClick
        Select Case tbRefreshNS.Buttons.IndexOf(e.Button)
            Case 0
                Fill_lvwNS()
        End Select
    End Sub
    Private Sub lvwNS_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwNS.ColumnClick
        SortLvw(lvwNS, e.Column)
    End Sub
    Private Sub btnCheckAllNS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAllNS.Click
        LvwCheckAll(Me.lvwNS, Me.btnCheckAllNS)
        If Me.lvwNS.Items.Count > 0 Then LockControls(True)
        Me.lvwNS.Focus()
    End Sub
    Private Sub lvwNS_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvwNS.ItemCheck

        If Not lvwNS.Items(e.Index).Checked Then
            lvwNS_CheckedItemsCount = lvwNS_CheckedItemsCount + 1
            lvwNS.Items(e.Index).BackColor = Color.LemonChiffon
        Else
            lvwNS_CheckedItemsCount = lvwNS_CheckedItemsCount - 1
            lvwNS.Items(e.Index).BackColor = Color.White
        End If
        Me.Text = lvwNS_CheckedItemsCount
        ShowTotalOnLvw(lvwNS, 0, lvwNS_CheckedItemsCount)

        If Me.ActiveControl.Name = "lvwNS" Then
            If Me.grpVisitDate.Enabled = True Then LockControls(True)
            lvwNS.Focus()
        End If

        'Me.btnSaveNS.Enabled = True
        'Me.btnCancelNS.Enabled = True
        'grpSaveNS.Enabled = True
    End Sub
    Private Sub btnSaveNS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNS.Click

        If Me.lvwNS.Items.Count > 0 Then
            If Not LvwNoItemsChecked(Me.lvwNS) Then
                If vfrmStuHpvShipEdit Is Nothing Then
                    vfrmStuHpvShipEdit = New frmStuHpvShipEdit
                    With vfrmStuHpvShipEdit
                        .Text = "Adding a new specimen shipment . . ."
                        .ShowDialog()
                    End With
                End If
            Else
                MsgBox("Please indicate which specimen items to ship by checking the check box under the 'Ship' column.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
                lvwNS.Focus()
            End If
        Else
            MsgBox("There is NO specimen items to ship.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
        End If



        Exit Sub

        If ValidationPassed() Then
            SaveChangesNS()
            LockControls(False)
            'Me.btnSaveNS.Enabled = False
            'Me.btnCancelNS.Enabled = False
            'grpSaveNS.Enabled = False
        End If
    End Sub
    Private Sub btnCanceNS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelNS.Click
        'Clear all checkboxes
        With Me.lvwNS
            If .Items.Count = 0 Then Exit Sub
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = False
            Next
        End With
        LockControls(False)
        'Me.btnSaveNS.Enabled = False
        'Me.btnCancelNS.Enabled = False
    End Sub
    Private Function ValidationPassed() As Boolean

        ValidationPassed = True

        If Me.dtsDateShippedToSave.Checked = False Then
            MsgBox("'Date Shipped' is required.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
            dtsDateShippedToSave.Focus()
            Return False
            Exit Function
        End If

    End Function
    Private Sub SaveChangesNS()

        Try

            Cursor.Current = Cursors.WaitCursor
            If Me.lvwNS.Items.Count = 0 Then Exit Sub
            For Each itm As ListViewItem In Me.lvwNS.Items
                If itm.Checked Then
                    RunSQL("INSERT INTO tbStuHpvPatVisitSpecimenShipped " & _
                          "(VisitProcActID, DateShipped) " & _
                           "VALUES (" & itm.SubItems(3).Text & ", #" & _
                                        Me.dtsDateShippedToSave.Value & "#)")
                End If
            Next
            Fill_lvwNS()
            Cursor.Current = Cursors.Default

            Exit Sub
            With Me.lvwNS
                If .Items.Count = 0 Then Exit Sub
                For i As Integer = 0 To .Items.Count - 1
                    If .Items(i).Checked Then
                        .Items(i).Selected = True
                        MsgBox(.Items(i).SubItems(2).Text & ", " & .Items(i).SubItems(3).Text)
                    End If
                Next
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dtsVisitDate_TextChangedOld(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtsVisitDate2.TextChanged

        If FormActivated Then

            If Me.ActiveControl.Name = "dtsVisitDate2" Then
                If Me.btnSaveNS.Enabled = True Then
                    lvwNS.Focus() 'dtsVisitDate1.Focus() 'Must send focus away otherwise
                    Dim resp As String = MsgBox("Do you want to save your changes?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question)
                    If resp = MsgBoxResult.Yes Then
                        SaveChangesNS()
                    ElseIf resp = MsgBoxResult.No Then
                        Fill_lvwNS()
                    ElseIf resp = MsgBoxResult.Cancel Then
                        'If Me.dtsVisitDate1.Value <> VisitDate1OldValue Then
                        'Me.dtsVisitDate1.Value = VisitDate1OldValue
                        'Me.dtsVisitDate2.Value = VisitDate2OldValue
                        'Else
                        'Exit Sub
                        'End If
                    End If
                Else
                    Fill_lvwNS()
                End If
            End If

        End If

    End Sub





    'Event handlers for SHIPPED '''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub Fill_lvwS()

        grpSaveS.Enabled = False

        Dim strDateRange As String = ""
        If Me.dtsDateShipped1.Checked = True And Me.dtsDateShipped2.Checked = False Then
            strDateRange = " DateShipped >= #" & Me.dtsDateShipped1.Value & "# "
        ElseIf Me.dtsDateShipped1.Checked = False And Me.dtsDateShipped2.Checked = True Then
            strDateRange = " DateShipped <= #" & Me.dtsDateShipped2.Value & "# "
        ElseIf Me.dtsDateShipped1.Checked = True And Me.dtsDateShipped2.Checked = True Then
            strDateRange = " DateShipped BETWEEN #" & _
              Me.dtsDateShipped1.Value & "# AND #" & Me.dtsDateShipped2.Value & "# "
        End If

        Dim strProcs As String = ""
        Select Case Me.cboSpecS.Text
            Case "Blood"
                strProcs = " ProcDesc='Blood draw (Einstein)'"
            Case "Other Specimens"
                strProcs = " ProcDesc IN ('Anal Pap (Einstein)','Cervical Pap (Einstein)','Oral Lavage (Einstein)')"
        End Select

        Dim strWhere As String = ""
        If strDateRange.Length > 0 And strProcs.Length = 0 Then
            strWhere = " WHERE " & strDateRange
        ElseIf strDateRange.Length = 0 And strProcs.Length > 0 Then
            strWhere = " WHERE " & strProcs
        ElseIf strDateRange.Length > 0 And strProcs.Length > 0 Then
            strWhere = " WHERE " & strDateRange & " AND " & strProcs
        End If

        Dim strSQL As String = _
        "SELECT '' AS Shipped, DateShipped, ProcDesc, tbStuHpvPatVisitProcAct.VisitProcActID, SubjectID, [LastName] & ', ' & [FirstName] AS Name, MRN " & _
        "FROM ((((tbStuHpvPatVisitSpecimenShipped LEFT JOIN tbStuHpvPatVisitProcAct ON tbStuHpvPatVisitSpecimenShipped.VisitProcActID = tbStuHpvPatVisitProcAct.VisitProcActID) LEFT JOIN tbStuHpvPatVisit ON tbStuHpvPatVisitProcAct.VisitID = tbStuHpvPatVisit.VisitID) LEFT JOIN tbStuHpvEpisode ON tbStuHpvPatVisit.EpisodeID = tbStuHpvEpisode.EpisodeID) LEFT JOIN tbPatient ON tbStuHpvEpisode.PatientID = tbPatient.PatientID) LEFT JOIN ddvProcedure ON tbStuHpvPatVisitProcAct.ProcCd = ddvProcedure.ProcCd " & _
        strWhere

        'Console.WriteLine(strSQL)

        Call Fill_lvw(Me.lvwS, strSQL, , False, True)
        ShowTotalOnLvw(lvwS, 2)

    End Sub
    Private Sub dtsDateShipped_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles dtsDateShipped1.TextChanged, dtsDateShipped2.TextChanged
        If FormActivated Then
            If sender.name = "dtsDateShipped1" Then Me.dtsDateShipped2.MinDate = Me.dtsDateShipped1.Value
            Fill_lvwS()
        End If
    End Sub
    Private Sub dtsDateShipped_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles dtsDateShipped1.CheckedChanged, dtsDateShipped2.CheckedChanged
        If FormActivated Then
            Fill_lvwS()
        End If
    End Sub
    Private Sub cboSpecS_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSpecS.SelectedValueChanged
        If FormActivated Then
            If cboSpecS.Text <> cboSpecSOldValue Then
                cboSpecSOldValue = cboSpecS.Text
                Fill_lvwS()
            End If
        End If
    End Sub
    Private Sub btnRefreshS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshS.Click
        'Fill_lvwS()
    End Sub
    Private Sub tbRefreshS_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbRefreshS.ButtonClick
        Select Case tbRefreshS.Buttons.IndexOf(e.Button)
            Case 0
                Fill_lvwS()
        End Select
    End Sub
    Private Sub lvwS_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwS.ColumnClick
        SortLvw(lvwS, e.Column)
    End Sub
    Private Sub lvwS_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvwS.ItemCheck
        If Me.ActiveControl.Name = "lvwS" Then
            LockControls(True)
        End If
    End Sub
    Private Sub btnSaveS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveS.Click
        SaveChangesS()
        LockControls(False)
    End Sub
    Private Sub btnCancelS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelS.Click
        'Check all checkboxes
        With Me.lvwS
            If .Items.Count = 0 Then Exit Sub
            For i As Integer = 0 To .Items.Count - 1
                .Items(i).Checked = True
            Next
        End With
        LockControls(False)
    End Sub
    Private Sub btnCheckAllS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAllS.Click

        LvwCheckAll(Me.lvwS, Me.btnCheckAllS)
        LockControls(True)

    End Sub
    Private Sub SaveChangesS()

        Try

            Cursor.Current = Cursors.WaitCursor
            If Me.lvwS.Items.Count = 0 Then Exit Sub
            For Each itm As ListViewItem In Me.lvwS.Items
                If itm.Checked = False Then
                    RunSQL("DELETE * FROM tbStuHpvPatVisitSpecimenShipped " & _
                           "WHERE VisitProcActID = " & itm.SubItems(3).Text)
                End If
            Next
            Fill_lvwS()
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    'Event handlers for SHIPPED NEW '''''''''''''''''''''''''''''''''''''''''''''''''''

    Friend Sub Fill_lvwShipped(Optional ByVal booFill_lvwShippedDetails As Boolean = True)
        Dim strsql As String = _
           "SELECT '' AS D, ShipmentID, DateShipped, Notes " & _
           "FROM tbStuHpvPatVisitSpecShipped " & _
           "ORDER BY DateShipped DESC"
        Fill_lvw(Me.lvwShipped, strsql, , False)
        ShowTotalOnLvw(Me.lvwShipped, 1)
        ShowLvwEditButtons(Me.lvwShipped, Me.btnEditShipped, Me.btnDelShipped)

        If booFill_lvwShippedDetails Then Fill_lvwShippedDetails()
    End Sub
    Friend Sub Fill_lvwShippedDetails()

        panShippedEditDetails.Enabled = False

        If lvwShipped.Items.Count = 0 Then
            Me.lvwShippedDetails.Items.Clear()
            Exit Sub
        End If

        'Kirk 11/1/08 chaning VisitNum to VisitNumDescShort with 'LEFT JOIN ddvStuHpvVisitNum ON tbStuHpvPatVisit.VisitNum = ddvStuHpvVisitNum.VisitNum)'
        Dim strSQL As String = _
           "SELECT '' AS Sent, tbStuHpvPatVisit.VisitDate, ProcDesc, tbStuHpvPatVisitProcAct.VisitProcActID, SubjectID, [LastName] & ', ' & [FirstName] AS Name, MRN, VisitNumDescShort " & _
           "FROM tbStuHpvPatVisitSpecShippedDetails " & _
                 "LEFT JOIN (((((tbStuHpvPatVisitProcAct " & _
                 "LEFT JOIN tbStuHpvPatVisit ON tbStuHpvPatVisitProcAct.VisitID = tbStuHpvPatVisit.VisitID) " & _
                 "LEFT JOIN tbStuHpvEpisode ON tbStuHpvPatVisit.EpisodeID = tbStuHpvEpisode.EpisodeID) " & _
                 "LEFT JOIN tbPatient ON tbStuHpvEpisode.PatientID = tbPatient.PatientID) " & _
                 "LEFT JOIN ddvStuHpvVisitNum ON tbStuHpvPatVisit.VisitNum = ddvStuHpvVisitNum.VisitNum) " & _
                 "LEFT JOIN ddvProcedure ON tbStuHpvPatVisitProcAct.ProcCd = ddvProcedure.ProcCd) ON tbStuHpvPatVisitSpecShippedDetails.VisitProcActID = tbStuHpvPatVisitProcAct.VisitProcActID " & _
           "WHERE tbStuHpvPatVisitSpecShippedDetails.ShipmentID =" & Me.lvwShipped.SelectedItems(0).SubItems(1).Text
        Console.WriteLine(strSQL)
        Fill_lvw(Me.lvwShippedDetails, strSQL, , False, True)
        ShowTotalOnLvw(Me.lvwShippedDetails, 2)

    End Sub
    Private Sub lvwShipped_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwShipped.Click
        lvwShippedXSelectedIndex = lvwShipped.SelectedItems(0).Index
        Fill_lvwShippedDetails()
    End Sub
    Private Sub lvwShipped_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwShipped.KeyUp
        lvwShipped_Click(sender, e)
    End Sub
    Private Sub lvwShipped_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwShipped.LostFocus
        With lvwShipped
            If .Items.Count > 0 And .SelectedItems.Count = 0 Then
                .Items(lvwShippedXSelectedIndex).Selected = True
            End If
        End With
    End Sub
    Private Sub lvwShipped_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwShipped.DoubleClick
        btnEditShipped_Click(sender, e)
    End Sub
    Private Sub lvwShipped_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) _
      Handles lvwShipped.ColumnClick, lvwShippedDetails.ColumnClick

        Dim lvw As ListView = CType(FindControl(Me, sender.name), ListView)
        SortLvw(lvw, e.Column)

    End Sub
    Private Sub tbRefreshShipped_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbRefreshShipped.ButtonClick
        Select Case tbRefreshShipped.Buttons.IndexOf(e.Button)
            Case 0
                Me.lvwShipped.Focus() 'need this first!
                Fill_lvwShipped()
        End Select
    End Sub
    Private Sub btnEditShipped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditShipped.Click
        If Me.lvwShipped.SelectedItems.Count > 0 Then
            Try
                If vfrmStuHpvShipEdit Is Nothing Then
                    vfrmStuHpvShipEdit = New frmStuHpvShipEdit
                    With vfrmStuHpvShipEdit
                        Dim intShipmentID As Integer = lvwShipped.SelectedItems(0).SubItems(1).Text
                        Dim conn As New OleDbConnection(strConn)
                        .da1SelectComm.Connection = conn
                        .da1SelectComm.CommandText = _
                          "SELECT * FROM tbStuHpvPatVisitSpecShipped WHERE ShipmentID=" & intShipmentID
                        .da1.Fill(.ds.tbStuHpvPatVisitSpecShipped)
                        .Text = "Editing specimen shipment ID " & intShipmentID & " . . ."
                        .ShowDialog()
                    End With
                End If
            Catch ex As System.Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please select a desired item to edit.", MsgBoxStyle.Information)
            Me.lvwShipped.Focus()
        End If
    End Sub
    Private Sub lvwShippedDetails_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lvwShippedDetails.ItemCheck
        If Me.ActiveControl.Name = "lvwShippedDetails" Then
            LockControls(True)
            lvwShippedDetails.Focus()
        End If
    End Sub
    Private Sub btnCancelSDtls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSDtls.Click
        'Check all checkboxes
        With Me.lvwShippedDetails
            If .Items.Count > 0 Then
                For i As Integer = 0 To .Items.Count - 1
                    .Items(i).Checked = True
                Next
            End If
        End With
        LockControls(False)
    End Sub
    Private Sub btnCheckAllSDtls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAllSDtls.Click
        LvwCheckAll(Me.lvwShippedDetails, Me.btnCheckAllSDtls)
        If Me.lvwShippedDetails.Items.Count > 0 Then LockControls(True)
    End Sub
    Private Sub btnSaveSDtls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSDtls.Click

        If Me.lvwShippedDetails.Items.Count > 0 Then
            If MsgBox("Are you sure you want to save the changes made to the list of specimens shipped? " & Chr(13) & Chr(10) & Chr(13) & Chr(10) & _
                "The specimen items you unchecked will be treated as unshipped if you click 'Yes'.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    Cursor.Current = Cursors.WaitCursor
                    If Me.lvwShippedDetails.Items.Count = 0 Then Exit Sub
                    For Each itm As ListViewItem In Me.lvwShippedDetails.Items
                        If itm.Checked = False Then
                            RunSQL("DELETE * FROM tbStuHpvPatVisitSpecShippedDetails " & _
                                   "WHERE VisitProcActID = " & itm.SubItems(3).Text)
                        End If
                    Next
                    Fill_lvwShippedDetails()
                    LockControls(False)
                    Cursor.Current = Cursors.Default

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("There is NO specimen items to save.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub btnDelShipped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelShipped.Click
        With Me.lvwShipped
            Dim intShipmentID As Integer = .SelectedItems(0).SubItems(1).Text
            If .SelectedItems.Count > 0 Then
                If MsgBox("Are you sure you want to delete the selected shipment with shipment ID '" & _
                          intShipmentID & "'?" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & _
                           "Note that if you delete this shipment, " & _
                           "ALL specimens that were flagged as shipped in this shipment will be treated as unshipped.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    RunSQL("DELETE * FROM tbStuHpvPatVisitSpecShipped " & _
                           "WHERE ShipmentID=" & intShipmentID)
                    Fill_lvwShipped()
                End If
            Else
                MsgBox("Please select a desired shipment from the shipment list to delete.", MsgBoxStyle.Information)
                .Focus()
            End If
        End With
    End Sub
End Class


