Imports System
Imports System.Drawing
Imports System.Collections
'Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports vbAccelerator.Components.Controls.ExplorerBarFramework
Imports vbAccelerator.Components.Controls 'need this!!!
'Imports vbAccelerator.Components.ListBarControl
Imports Microsoft.Office.Interop
Imports System.Data.OleDb

Public Class frmMDI
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'Application.EnableVisualStyles()

    End Sub

    Shared Sub main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New frmMDI)
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
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWinTileHori As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWinTileVert As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWinTileCasc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWinTileArrIcons As System.Windows.Forms.MenuItem
    Friend WithEvents tooltip As System.Windows.Forms.ToolTip
    Friend WithEvents ilsIconsLarge As System.Windows.Forms.ImageList
    Friend WithEvents grpExBar As System.Windows.Forms.GroupBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ExBar As vbAccelerator.Components.Controls.acclExplorerBar
    Friend WithEvents tbMDI As System.Windows.Forms.ToolBar
    Friend WithEvents ilstbMDI As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuView As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewToolbar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuViewModuleBar As System.Windows.Forms.MenuItem
    Friend WithEvents tbMDImodulebar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbMDImail As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuTools As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsMail As System.Windows.Forms.MenuItem
    Friend WithEvents tbMDImailmerge As System.Windows.Forms.ToolBarButton
    Friend WithEvents rbReports As System.Windows.Forms.RadioButton
    Friend WithEvents rbPatients As System.Windows.Forms.RadioButton
    Friend WithEvents ils16X16 As System.Windows.Forms.ImageList
    Friend WithEvents tbMDIPatients As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbMDIReports As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbMDIIncentiveLog As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbMDIRefInelLog As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbMDIBloodLog As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbMDIAdverseEventsLog As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuRunEinstreinMacro As System.Windows.Forms.MenuItem
    Friend WithEvents tbMDIScannedFileLog As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuDbInfo As System.Windows.Forms.MenuItem
    Friend WithEvents tbMDIShip As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDI))
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFileExit = New System.Windows.Forms.MenuItem
        Me.mnuView = New System.Windows.Forms.MenuItem
        Me.mnuViewToolbar = New System.Windows.Forms.MenuItem
        Me.mnuViewModuleBar = New System.Windows.Forms.MenuItem
        Me.mnuTools = New System.Windows.Forms.MenuItem
        Me.mnuToolsMail = New System.Windows.Forms.MenuItem
        Me.mnuRunEinstreinMacro = New System.Windows.Forms.MenuItem
        Me.mnuWin = New System.Windows.Forms.MenuItem
        Me.mnuWinTileHori = New System.Windows.Forms.MenuItem
        Me.mnuWinTileVert = New System.Windows.Forms.MenuItem
        Me.mnuWinTileCasc = New System.Windows.Forms.MenuItem
        Me.mnuWinTileArrIcons = New System.Windows.Forms.MenuItem
        Me.ilsIconsLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpExBar = New System.Windows.Forms.GroupBox
        Me.rbReports = New System.Windows.Forms.RadioButton
        Me.rbPatients = New System.Windows.Forms.RadioButton
        Me.tbMDI = New System.Windows.Forms.ToolBar
        Me.tbMDImodulebar = New System.Windows.Forms.ToolBarButton
        Me.tbMDImail = New System.Windows.Forms.ToolBarButton
        Me.tbMDImailmerge = New System.Windows.Forms.ToolBarButton
        Me.tbMDIPatients = New System.Windows.Forms.ToolBarButton
        Me.tbMDIShip = New System.Windows.Forms.ToolBarButton
        Me.tbMDIReports = New System.Windows.Forms.ToolBarButton
        Me.tbMDIIncentiveLog = New System.Windows.Forms.ToolBarButton
        Me.tbMDIRefInelLog = New System.Windows.Forms.ToolBarButton
        Me.tbMDIBloodLog = New System.Windows.Forms.ToolBarButton
        Me.tbMDIAdverseEventsLog = New System.Windows.Forms.ToolBarButton
        Me.tbMDIScannedFileLog = New System.Windows.Forms.ToolBarButton
        Me.ilstbMDI = New System.Windows.Forms.ImageList(Me.components)
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.ExBar = New vbAccelerator.Components.Controls.acclExplorerBar
        Me.ils16X16 = New System.Windows.Forms.ImageList(Me.components)
        Me.mnuDbInfo = New System.Windows.Forms.MenuItem
        Me.grpExBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuView, Me.mnuTools, Me.mnuWin})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDbInfo, Me.mnuFileExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 1
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuView
        '
        Me.mnuView.Index = 1
        Me.mnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuViewToolbar, Me.mnuViewModuleBar})
        Me.mnuView.Text = "&View"
        '
        'mnuViewToolbar
        '
        Me.mnuViewToolbar.Checked = True
        Me.mnuViewToolbar.Index = 0
        Me.mnuViewToolbar.Text = "&Toolbar"
        '
        'mnuViewModuleBar
        '
        Me.mnuViewModuleBar.Checked = True
        Me.mnuViewModuleBar.Index = 1
        Me.mnuViewModuleBar.Text = "&Modulebar"
        Me.mnuViewModuleBar.Visible = False
        '
        'mnuTools
        '
        Me.mnuTools.Index = 2
        Me.mnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuToolsMail, Me.mnuRunEinstreinMacro})
        Me.mnuTools.Text = "&Tools"
        '
        'mnuToolsMail
        '
        Me.mnuToolsMail.Index = 0
        Me.mnuToolsMail.Text = "Send Mail..."
        '
        'mnuRunEinstreinMacro
        '
        Me.mnuRunEinstreinMacro.Index = 1
        Me.mnuRunEinstreinMacro.Text = "Run Einstein Macro"
        '
        'mnuWin
        '
        Me.mnuWin.Index = 3
        Me.mnuWin.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuWinTileHori, Me.mnuWinTileVert, Me.mnuWinTileCasc, Me.mnuWinTileArrIcons})
        Me.mnuWin.Text = "&Window"
        '
        'mnuWinTileHori
        '
        Me.mnuWinTileHori.Index = 0
        Me.mnuWinTileHori.Text = "&Tile Horizontally"
        '
        'mnuWinTileVert
        '
        Me.mnuWinTileVert.Index = 1
        Me.mnuWinTileVert.Text = "&Tile Vertically"
        '
        'mnuWinTileCasc
        '
        Me.mnuWinTileCasc.Index = 2
        Me.mnuWinTileCasc.Text = "&Cascade"
        '
        'mnuWinTileArrIcons
        '
        Me.mnuWinTileArrIcons.Index = 3
        Me.mnuWinTileArrIcons.Text = "&Arrange Icons"
        '
        'ilsIconsLarge
        '
        Me.ilsIconsLarge.ImageStream = CType(resources.GetObject("ilsIconsLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsIconsLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsIconsLarge.Images.SetKeyName(0, "")
        Me.ilsIconsLarge.Images.SetKeyName(1, "")
        Me.ilsIconsLarge.Images.SetKeyName(2, "")
        Me.ilsIconsLarge.Images.SetKeyName(3, "")
        Me.ilsIconsLarge.Images.SetKeyName(4, "")
        '
        'grpExBar
        '
        Me.grpExBar.Controls.Add(Me.rbReports)
        Me.grpExBar.Controls.Add(Me.rbPatients)
        Me.grpExBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpExBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpExBar.Location = New System.Drawing.Point(0, 0)
        Me.grpExBar.Name = "grpExBar"
        Me.grpExBar.Size = New System.Drawing.Size(0, 573)
        Me.grpExBar.TabIndex = 8
        Me.grpExBar.TabStop = False
        Me.grpExBar.Text = "grpExBar"
        '
        'rbReports
        '
        Me.rbReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbReports.Location = New System.Drawing.Point(12, 49)
        Me.rbReports.Name = "rbReports"
        Me.rbReports.Size = New System.Drawing.Size(72, 24)
        Me.rbReports.TabIndex = 1
        Me.rbReports.Text = "Hsp_MM"
        Me.rbReports.UseVisualStyleBackColor = False
        '
        'rbPatients
        '
        Me.rbPatients.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbPatients.Location = New System.Drawing.Point(12, 23)
        Me.rbPatients.Name = "rbPatients"
        Me.rbPatients.Size = New System.Drawing.Size(72, 24)
        Me.rbPatients.TabIndex = 0
        Me.rbPatients.Text = "Hsp_CI"
        Me.rbPatients.UseVisualStyleBackColor = False
        '
        'tbMDI
        '
        Me.tbMDI.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.tbMDI.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbMDImodulebar, Me.tbMDImail, Me.tbMDImailmerge, Me.tbMDIPatients, Me.tbMDIShip, Me.tbMDIReports, Me.tbMDIIncentiveLog, Me.tbMDIRefInelLog, Me.tbMDIBloodLog, Me.tbMDIAdverseEventsLog, Me.tbMDIScannedFileLog})
        Me.tbMDI.DropDownArrows = True
        Me.tbMDI.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMDI.ImageList = Me.ilstbMDI
        Me.tbMDI.Location = New System.Drawing.Point(0, 0)
        Me.tbMDI.Name = "tbMDI"
        Me.tbMDI.ShowToolTips = True
        Me.tbMDI.Size = New System.Drawing.Size(952, 28)
        Me.tbMDI.TabIndex = 10
        Me.tbMDI.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'tbMDImodulebar
        '
        Me.tbMDImodulebar.ImageIndex = 0
        Me.tbMDImodulebar.Name = "tbMDImodulebar"
        Me.tbMDImodulebar.ToolTipText = "Hide Modulebar"
        Me.tbMDImodulebar.Visible = False
        '
        'tbMDImail
        '
        Me.tbMDImail.ImageIndex = 2
        Me.tbMDImail.Name = "tbMDImail"
        Me.tbMDImail.Text = " Send Mail"
        Me.tbMDImail.ToolTipText = "Send Mail..."
        Me.tbMDImail.Visible = False
        '
        'tbMDImailmerge
        '
        Me.tbMDImailmerge.ImageIndex = 3
        Me.tbMDImailmerge.Name = "tbMDImailmerge"
        Me.tbMDImailmerge.Text = " Mail Merge"
        Me.tbMDImailmerge.ToolTipText = "Mail Merge"
        Me.tbMDImailmerge.Visible = False
        '
        'tbMDIPatients
        '
        Me.tbMDIPatients.ImageIndex = 4
        Me.tbMDIPatients.Name = "tbMDIPatients"
        Me.tbMDIPatients.Text = " Patients"
        '
        'tbMDIShip
        '
        Me.tbMDIShip.ImageIndex = 13
        Me.tbMDIShip.Name = "tbMDIShip"
        Me.tbMDIShip.Text = " Shipment Tracking"
        '
        'tbMDIReports
        '
        Me.tbMDIReports.ImageIndex = 15
        Me.tbMDIReports.Name = "tbMDIReports"
        Me.tbMDIReports.Text = " Reports"
        '
        'tbMDIIncentiveLog
        '
        Me.tbMDIIncentiveLog.Name = "tbMDIIncentiveLog"
        Me.tbMDIIncentiveLog.Text = "Incentive Log"
        '
        'tbMDIRefInelLog
        '
        Me.tbMDIRefInelLog.Name = "tbMDIRefInelLog"
        Me.tbMDIRefInelLog.Text = "Refusal/Ineligible Log"
        '
        'tbMDIBloodLog
        '
        Me.tbMDIBloodLog.Name = "tbMDIBloodLog"
        Me.tbMDIBloodLog.Text = "Blood Log"
        '
        'tbMDIAdverseEventsLog
        '
        Me.tbMDIAdverseEventsLog.Name = "tbMDIAdverseEventsLog"
        Me.tbMDIAdverseEventsLog.Text = "Adverse Events Log"
        '
        'tbMDIScannedFileLog
        '
        Me.tbMDIScannedFileLog.Name = "tbMDIScannedFileLog"
        Me.tbMDIScannedFileLog.Text = "Scanned/Filed Log"
        '
        'ilstbMDI
        '
        Me.ilstbMDI.ImageStream = CType(resources.GetObject("ilstbMDI.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilstbMDI.TransparentColor = System.Drawing.Color.Transparent
        Me.ilstbMDI.Images.SetKeyName(0, "")
        Me.ilstbMDI.Images.SetKeyName(1, "")
        Me.ilstbMDI.Images.SetKeyName(2, "")
        Me.ilstbMDI.Images.SetKeyName(3, "")
        Me.ilstbMDI.Images.SetKeyName(4, "")
        Me.ilstbMDI.Images.SetKeyName(5, "")
        Me.ilstbMDI.Images.SetKeyName(6, "")
        Me.ilstbMDI.Images.SetKeyName(7, "")
        Me.ilstbMDI.Images.SetKeyName(8, "")
        Me.ilstbMDI.Images.SetKeyName(9, "")
        Me.ilstbMDI.Images.SetKeyName(10, "")
        Me.ilstbMDI.Images.SetKeyName(11, "")
        Me.ilstbMDI.Images.SetKeyName(12, "")
        Me.ilstbMDI.Images.SetKeyName(13, "")
        Me.ilstbMDI.Images.SetKeyName(14, "")
        Me.ilstbMDI.Images.SetKeyName(15, "")
        '
        'Splitter1
        '
        Me.Splitter1.Enabled = False
        Me.Splitter1.Location = New System.Drawing.Point(0, 28)
        Me.Splitter1.MinExtra = 770
        Me.Splitter1.MinSize = 5
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 545)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'ExBar
        '
        Me.ExBar.AnimateStateChanges = True
        Me.ExBar.BackColor = System.Drawing.SystemColors.Control
        Me.ExBar.BackColorEnd = System.Drawing.Color.Empty
        Me.ExBar.BackColorStart = System.Drawing.Color.Empty
        Me.ExBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExBar.DrawingStyle = vbAccelerator.Components.Controls.ExplorerBarDrawingStyle.System
        Me.ExBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExBar.ImageList = Me.ils16X16
        Me.ExBar.Location = New System.Drawing.Point(0, 28)
        Me.ExBar.Mode = vbAccelerator.Components.Controls.ExplorerBarMode.[Default]
        Me.ExBar.Name = "ExBar"
        Me.ExBar.Redraw = True
        Me.ExBar.ShowFocusRect = True
        Me.ExBar.Size = New System.Drawing.Size(0, 545)
        Me.ExBar.TabIndex = 12
        Me.ExBar.TitleImageList = Nothing
        Me.ExBar.ToolTip = Nothing
        '
        'ils16X16
        '
        Me.ils16X16.ImageStream = CType(resources.GetObject("ils16X16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ils16X16.TransparentColor = System.Drawing.Color.Transparent
        Me.ils16X16.Images.SetKeyName(0, "")
        Me.ils16X16.Images.SetKeyName(1, "")
        '
        'mnuDbInfo
        '
        Me.mnuDbInfo.Index = 0
        Me.mnuDbInfo.Text = "DB Info"
        '
        'frmMDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(952, 573)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.ExBar)
        Me.Controls.Add(Me.tbMDI)
        Me.Controls.Add(Me.grpExBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu
        Me.Name = "frmMDI"
        Me.Text = "Research Information System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpExBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Load_frmMail()

        'If vfrmMail Is Nothing Then
        'vfrmMail = New frmMail
        'With vfrmMail
        '.ShowDialog()
        'End With
        'End If

    End Sub
    Private Sub Load_frmPatient()

        If vfrmPatient Is Nothing Then 'If not already loaded
            Cursor.Current = Cursors.WaitCursor
            vfrmPatient = New frmPatient
            With vfrmPatient
                .MdiParent = Me
                .Show()
                .Focus()
            End With
            Cursor.Current = Cursors.Default
        Else
            vfrmPatient.Focus()
        End If

    End Sub
    Private Sub Load_frmReportList()

        If vfrmReportList Is Nothing Then 'If not already loaded
            vfrmReportList = New frmReportList
            With vfrmReportList
                .MdiParent = Me
                .Show()
                .Focus()
            End With
        Else
            vfrmReportList.Focus()
        End If

    End Sub

    Private Sub Load_frmStuHpvShip()

        If vfrmStuHpvShip Is Nothing Then 'If not already loaded
            vfrmStuHpvShip = New frmStuHpvShip
            With vfrmStuHpvShip
                .MdiParent = Me
                .Show()
                '.ShowDialog()
                .Focus()
            End With
        Else
            vfrmStuHpvShip.Focus()
        End If

    End Sub

    Private Sub Load_frmIncentiveLog()
        If vfrmIncetiveLog Is Nothing Then 'If not already loaded
            vfrmIncetiveLog = New frmIncentiveLogs
            With vfrmIncetiveLog
                .MdiParent = Me
                .Show()
                .Focus()
            End With
        Else
            vfrmIncetiveLog.Focus()
        End If
    End Sub

    Private Sub Load_frmStuHpvRefIneligLog()
        If vfrmStuHpvRefIneligLog Is Nothing Then 'If not already loaded
            vfrmStuHpvRefIneligLog = New frmStuHpvRefIneligLog
            With vfrmStuHpvRefIneligLog
                .MdiParent = Me
                .Show()
                .Focus()
            End With
        Else
            vfrmStuHpvRefIneligLog.Focus()
        End If
    End Sub

    Private Sub Load_frmHPVBloodLog()
        If vfrmHPVBloodLog Is Nothing Then 'If not already loaded
            vfrmHPVBloodLog = New frmHPVBloodLog
            With vfrmHPVBloodLog
                .MdiParent = Me
                .Show()
                .Focus()
            End With
        Else
            vfrmHPVBloodLog.Focus()
        End If
    End Sub

    Private Sub Load_frmHPVAdverseEventsLog()
        If vfrmHPVAdverseEventsLog Is Nothing Then 'If not already loaded
            vfrmHPVAdverseEventsLog = New frmHPVAdverseEventsLog
            With vfrmHPVAdverseEventsLog
                .MdiParent = Me
                .Show()
                .Focus()
            End With
        Else
            vfrmHPVAdverseEventsLog.Focus()
        End If
    End Sub

    Private Sub Load_frmHPVScannedFiledLog()
        If vfrmHPVScannedFiledLog Is Nothing Then 'If not already loaded
            vfrmHPVScannedFiledLog = New frmHPVScannedFiledLog
            With vfrmHPVScannedFiledLog
                .MdiParent = Me
                .Show()
                .Focus()
            End With
        Else
            vfrmHPVScannedFiledLog.Focus()
        End If
    End Sub

    Private Sub frmMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vfrmMDI = Me
        Call Load_ExBar()
        SetDefaultBar(0) 'Make hospital the default bar
        Load_frmPatient()
        'Load_frmReportList()
        'Load_frmStuHpvShip()

        Me.Text = "Research Information System - v" & Application.ProductVersion.Trim


    End Sub

    Private Sub SetDefaultBar(ByVal bar As Short)

        ExBar.Bars(bar).IsSpecial = True
        ActiveBarText = ExBar.Bars(bar).Text
        'Call ChangeExBarColor()
        'CollapseAllBars()
        'ExBar.Bars(bar).State = ExplorerBarState.Expanded

    End Sub

    Private Sub CollapseAllBars()
        ExBar.Bars(0).State = ExplorerBarState.Collapsed
        ExBar.Bars(1).State = ExplorerBarState.Collapsed
        ExBar.Bars(2).State = ExplorerBarState.Collapsed
        ExBar.Bars(3).State = ExplorerBarState.Collapsed
        ExBar.Bars(4).State = ExplorerBarState.Collapsed
    End Sub

    Private Sub Load_ExBar()

        AddExplorerBarCommon("")

    End Sub

    Private Sub AddExplorerBarCommon(ByVal BarText As String)

        'Me.ExBar.ImageList = Me.ilsIcons
        With Me.ExBar
            .ToolTip = Me.tooltip
            '.AnimateStateChanges = True
        End With
        Dim bar As ExplorerBar
        Dim item As ExplorerBarLinkItem

        bar = New ExplorerBar
        bar.Text = BarText

        item = New ExplorerBarLinkItem
        With item
            .Text = "Patients"
            .IconIndex = 0
            .ToolTipText = "Click to load the Patients module"
            .Tag = 1
        End With
        bar.Items.Add(item)

        item = New ExplorerBarLinkItem
        With item
            .Text = ""
        End With
        bar.Items.Add(item)

        item = New ExplorerBarLinkItem
        With item
            .Text = "Reports"
            .IconIndex = 1
            .ToolTipText = "Click to load the Reports module"
            .Tag = 2
        End With
        bar.Items.Add(item)

        Me.ExBar.Bars.Add(bar)
    End Sub
    Friend Sub mnuFileExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        If MsgBox("Are you sure you want to exit RIS now?", vbYesNo + vbQuestion) = vbYes Then
            End
        End If
    End Sub

    Private Sub mnuWinTileHori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWinTileHori.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuWinTileVert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWinTileVert.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuWinTileCasc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWinTileCasc.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuWinTileArrIcons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWinTileArrIcons.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub Set_ExBar_IsSpecial_False()
        Dim bar As ExplorerBar
        For Each bar In ExBar.Bars
            bar.IsSpecial = False
        Next
    End Sub


    Private Sub ExBar_ItemClick(ByVal sender As Object, ByVal args As vbAccelerator.Components.Controls.ExplorerBarItemClickEventArgs) Handles ExBar.ItemClick
        Call Set_ExBar_IsSpecial_False()

        Dim selectedItem As ExplorerBarItem
        selectedItem = args.Item
        ActiveBarText = selectedItem.Bar.Text
        Select Case ActiveBarText
            Case ""
                Select Case selectedItem.Tag
                    Case 1
                        rbPatients.Checked = True
                        rbPatients.Focus()
                    Case 2
                        rbReports.Checked = True
                        rbReports.Focus()
                End Select
                ExBar.Bars(0).IsSpecial = True
            Case Else
        End Select

        'Call ChangeExBarColor()
    End Sub

    Private Sub ExBar_BarClick(ByVal sender As Object, ByVal args As vbAccelerator.Components.Controls.ExplorerBarClickEventArgs) Handles ExBar.BarClick
        Set_ExBar_IsSpecial_False()
        args.Bar.IsSpecial = True
        ActiveBarText = args.Bar.Text
        'Call ChangeExBarColor()
    End Sub

    Private Sub tbMDI_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbMDI.ButtonClick
        Select Case tbMDI.Buttons.IndexOf(e.Button)
            Case 0
                'MessageBox.Show("First toolbar button clicked")
                Call mnuViewModuleBar_Click(sender, e)
            Case 1
                Load_frmMail()
            Case 3
                Load_frmPatient()
            Case 4
                Load_frmStuHpvShip()
            Case 5
                Load_frmReportList()
            Case 6
                Load_frmIncentiveLog()
            Case 7
                Load_frmStuHpvRefIneligLog()
            Case 8
                Load_frmHPVBloodLog()
            Case 9
                Me.Load_frmHPVAdverseEventsLog()
            Case 10
                Load_frmHPVScannedFiledLog()
        End Select

    End Sub

    Private Sub mnuViewToolbar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewToolbar.Click
        If Me.tbMDI.Visible = False Then
            Me.tbMDI.Visible = True
            mnuViewToolbar.Checked() = True
        Else
            Me.tbMDI.Visible = False
            mnuViewToolbar.Checked() = False
        End If
    End Sub

    Private Sub mnuViewModuleBar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewModuleBar.Click

        With Me.tbMDImodulebar
            If .ImageIndex = 0 Then
                .ImageIndex = 1
                mnuViewModuleBar.Checked() = False
            Else
                .ImageIndex = 0
                mnuViewModuleBar.Checked() = True
            End If
        End With
        Call Show_ExBar()
    End Sub

    Private Sub Show_ExBar()

        With Me.tbMDImodulebar
            If .ImageIndex = 1 Then
                Me.ExBar.Width = 0
                ' .ImageIndex = 1
                .ToolTipText = "Show Modulebar"
            Else
                Me.ExBar.Width = 133
                ' .ImageIndex = 0
                .ToolTipText = "Hide Modulebar"
            End If
        End With
    End Sub

    Private Sub frmMDI_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        vfrmMDI = Nothing
        'need these!!!
        If Not vfrmLogin Is Nothing Then
            vfrmLogin.Close()
        End If

    End Sub

    Private Sub rbPatients_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPatients.GotFocus
        If rbPatients.Checked = True Then Call Load_frmPatient()
    End Sub

    Private Sub frmMDI_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MsgBox("Are you sure you want to exit RIS now?", vbYesNo + vbQuestion) = vbYes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRunEinstreinMacro.Click
        Try
            RunmcrEinsteinSAASHDataExport1()
            RunImportEinsteinDb()
            'RunSharePointConnection()

            MsgBox("Einstein Macro Complete", MsgBoxStyle.Information, "Complete")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Macro Error")
        End Try
    End Sub
    Sub RunmcrEinsteinSAASHDataExport1()
        Try
            Dim Adb As New Access.Application
            'Adb.OpenCurrentDatabase("C:\Bittersweet Software\Bittersweet Software Working Folder\RIS\RIS\Data\RISdata.mdb", False)

            Dim cn As New OleDb.OleDbConnection(strConn)
            Adb.OpenCurrentDatabase(cn.DataSource)
            Adb.Visible = False
            Adb.DoCmd.RunMacro("mcrEinsteinSAASHDataExport1")
            Adb.DoCmd().Quit(Access.AcQuitOption.acQuitSaveNone)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Adb)
            Adb = Nothing
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub RunImportEinsteinDb()
        Try
            'Dim strConn2 = "Provider=Microsoft.Jet.OLEDB.4.0;data source=L:\HPVResearch\RIS\SAASHDataTransfer1\EinsteinRISdata.accdb; "
            Dim strConn2 = "Provider=Microsoft.Ace.OLEDB.12.0;data source=L:\HPVResearch\RIS\SAASHDataTransfer1\EinsteinRISdata.accdb; "

            Dim cn As New OleDb.OleDbConnection(strConn2)
            'cn.Open()
            'Dim CMD As New OleDb.OleDbCommand("mcrSAASHDataImport1", cn)
            'CMD.ExecuteNonQuery()
            'cn.Close()

            Dim Adb As New Access.Application
            Adb.Visible = False
            Adb.OpenCurrentDatabase(cn.DataSource)
            Adb.DoCmd.RunMacro("mcrSAASHDataImport1")
            Adb.DoCmd().Quit(Access.AcQuitOption.acQuitSaveNone)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Adb)
            Adb = Nothing
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub mnuSharePointConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunSharePointConnection()
    End Sub
    Sub RunSharePointConnection()
        'Dim CommandLine As String = "L:\HPVresearch\RIS\SAASHDataTransfer1\EinsteinRISdata.accdb """"https://rifc.aecom.yu.edu/CollaborationSites/HPVMS/Shared Documents/"""" /user:dbmu\PFrancaviglia /Password:Ahc12345 /o"
        'Dim p As New Process
        'With p.StartInfo
        '    '.FileName = "L:\HPVresearch\RIS\davcopy\DavCopy\DavCopy.exe"
        '    .UseShellExecute = False
        '    .CreateNoWindow = True
        'End With

        'p.Start()

        'Shell("cmd.exe /k cd L:\HPVresearch\RIS\davcopy\DavCopy\")
    End Sub

    Private Sub MenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDbInfo.Click
        Try
            MessageBox.Show(strConn, "DB Info", MessageBoxButtons.OK)
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
