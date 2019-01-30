Imports System.IO
'Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports System.Windows.Forms
Public Class frmReportList
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
    Friend WithEvents grpReportTree As System.Windows.Forms.GroupBox
    Friend WithEvents trvReports As System.Windows.Forms.TreeView
    Friend WithEvents grpReportDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblRptComments As System.Windows.Forms.Label
    Friend WithEvents lblReportComments As System.Windows.Forms.Label
    Friend WithEvents lblRptSubject As System.Windows.Forms.Label
    Friend WithEvents lblReportSubject As System.Windows.Forms.Label
    Friend WithEvents lblRptTitle As System.Windows.Forms.Label
    Friend WithEvents lblReportTitle As System.Windows.Forms.Label
    Friend WithEvents pnlFilterControls As System.Windows.Forms.Panel
    Friend WithEvents grpRunReport As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportList))
        Me.grpReportTree = New System.Windows.Forms.GroupBox()
        Me.trvReports = New System.Windows.Forms.TreeView()
        Me.grpReportDetails = New System.Windows.Forms.GroupBox()
        Me.lblRptComments = New System.Windows.Forms.Label()
        Me.lblReportComments = New System.Windows.Forms.Label()
        Me.lblRptSubject = New System.Windows.Forms.Label()
        Me.lblReportSubject = New System.Windows.Forms.Label()
        Me.lblRptTitle = New System.Windows.Forms.Label()
        Me.lblReportTitle = New System.Windows.Forms.Label()
        Me.grpRunReport = New System.Windows.Forms.GroupBox()
        Me.pnlFilterControls = New System.Windows.Forms.Panel()
        Me.grpReportTree.SuspendLayout()
        Me.grpReportDetails.SuspendLayout()
        Me.grpRunReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpReportTree
        '
        Me.grpReportTree.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpReportTree.Controls.Add(Me.trvReports)
        Me.grpReportTree.Location = New System.Drawing.Point(2, 2)
        Me.grpReportTree.Name = "grpReportTree"
        Me.grpReportTree.Size = New System.Drawing.Size(321, 723)
        Me.grpReportTree.TabIndex = 7
        Me.grpReportTree.TabStop = False
        Me.grpReportTree.Text = "Reports"
        '
        'trvReports
        '
        Me.trvReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvReports.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trvReports.FullRowSelect = True
        Me.trvReports.HideSelection = False
        Me.trvReports.Indent = 15
        Me.trvReports.Location = New System.Drawing.Point(7, 22)
        Me.trvReports.Name = "trvReports"
        TreeNode1.Name = "Reports"
        TreeNode1.Text = "Reports"
        TreeNode1.ToolTipText = "Reports"
        Me.trvReports.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.trvReports.ShowRootLines = False
        Me.trvReports.Size = New System.Drawing.Size(306, 692)
        Me.trvReports.TabIndex = 7
        '
        'grpReportDetails
        '
        Me.grpReportDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpReportDetails.Controls.Add(Me.lblRptComments)
        Me.grpReportDetails.Controls.Add(Me.lblReportComments)
        Me.grpReportDetails.Controls.Add(Me.lblRptSubject)
        Me.grpReportDetails.Controls.Add(Me.lblReportSubject)
        Me.grpReportDetails.Controls.Add(Me.lblRptTitle)
        Me.grpReportDetails.Controls.Add(Me.lblReportTitle)
        Me.grpReportDetails.Location = New System.Drawing.Point(330, 2)
        Me.grpReportDetails.Name = "grpReportDetails"
        Me.grpReportDetails.Size = New System.Drawing.Size(754, 198)
        Me.grpReportDetails.TabIndex = 8
        Me.grpReportDetails.TabStop = False
        Me.grpReportDetails.Text = "Report Details"
        '
        'lblRptComments
        '
        Me.lblRptComments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRptComments.BackColor = System.Drawing.SystemColors.Control
        Me.lblRptComments.Location = New System.Drawing.Point(148, 82)
        Me.lblRptComments.Name = "lblRptComments"
        Me.lblRptComments.Size = New System.Drawing.Size(814, 104)
        Me.lblRptComments.TabIndex = 5
        Me.lblRptComments.Text = "(Report Comments)"
        '
        'lblReportComments
        '
        Me.lblReportComments.AutoSize = True
        Me.lblReportComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportComments.Location = New System.Drawing.Point(13, 82)
        Me.lblReportComments.Name = "lblReportComments"
        Me.lblReportComments.Size = New System.Drawing.Size(141, 17)
        Me.lblReportComments.TabIndex = 4
        Me.lblReportComments.Text = "Report Comments:"
        '
        'lblRptSubject
        '
        Me.lblRptSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRptSubject.BackColor = System.Drawing.SystemColors.Control
        Me.lblRptSubject.Location = New System.Drawing.Point(148, 52)
        Me.lblRptSubject.Name = "lblRptSubject"
        Me.lblRptSubject.Size = New System.Drawing.Size(814, 15)
        Me.lblRptSubject.TabIndex = 3
        Me.lblRptSubject.Text = "(Report Subject)"
        '
        'lblReportSubject
        '
        Me.lblReportSubject.AutoSize = True
        Me.lblReportSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportSubject.Location = New System.Drawing.Point(13, 52)
        Me.lblReportSubject.Name = "lblReportSubject"
        Me.lblReportSubject.Size = New System.Drawing.Size(121, 17)
        Me.lblReportSubject.TabIndex = 2
        Me.lblReportSubject.Text = "Report Subject:"
        '
        'lblRptTitle
        '
        Me.lblRptTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRptTitle.BackColor = System.Drawing.SystemColors.Control
        Me.lblRptTitle.Location = New System.Drawing.Point(148, 22)
        Me.lblRptTitle.Name = "lblRptTitle"
        Me.lblRptTitle.Size = New System.Drawing.Size(596, 15)
        Me.lblRptTitle.TabIndex = 1
        Me.lblRptTitle.Text = "(Report Title)"
        '
        'lblReportTitle
        '
        Me.lblReportTitle.AutoSize = True
        Me.lblReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTitle.Location = New System.Drawing.Point(13, 22)
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.Size = New System.Drawing.Size(99, 17)
        Me.lblReportTitle.TabIndex = 0
        Me.lblReportTitle.Text = "Report Title:"
        '
        'grpRunReport
        '
        Me.grpRunReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRunReport.Controls.Add(Me.pnlFilterControls)
        Me.grpRunReport.Location = New System.Drawing.Point(330, 207)
        Me.grpRunReport.Name = "grpRunReport"
        Me.grpRunReport.Size = New System.Drawing.Size(972, 631)
        Me.grpRunReport.TabIndex = 10
        Me.grpRunReport.TabStop = False
        Me.grpRunReport.Text = "Report Parameters"
        '
        'pnlFilterControls
        '
        Me.pnlFilterControls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFilterControls.Location = New System.Drawing.Point(17, 22)
        Me.pnlFilterControls.Name = "pnlFilterControls"
        Me.pnlFilterControls.Size = New System.Drawing.Size(1163, 715)
        Me.pnlFilterControls.TabIndex = 0
        '
        'frmReportList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1090, 734)
        Me.Controls.Add(Me.grpRunReport)
        Me.Controls.Add(Me.grpReportDetails)
        Me.Controls.Add(Me.grpReportTree)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(240, 262)
        Me.Name = "frmReportList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpReportTree.ResumeLayout(False)
        Me.grpReportDetails.ResumeLayout(False)
        Me.grpReportDetails.PerformLayout()
        Me.grpRunReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cursor.Current = Cursors.WaitCursor
            Fill_Reports(Me.trvReports)
            ClearReportInfo()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub
    Private Sub frmReportList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vfrmReportList = Nothing

    End Sub
    Private Sub trvReports_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles trvReports.NodeMouseClick
        Try
            Cursor.Current = Cursors.WaitCursor

            '* SET THE SELECTED NODE OR THE TREE-SELECTION JUMPS AROUND
            Me.trvReports.SelectedNode = e.Node

            ClearReportInfo()

            If e.Node.Tag <> "" Then
                ReadReportInfo(e.Node.Tag)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub ClearReportInfo()
        Try
            Me.lblRptTitle.Text = ""
            Me.lblRptSubject.Text = ""
            Me.lblRptComments.Text = ""
            Me.pnlFilterControls.Controls.Clear()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub ReadReportInfo(ByVal FullReportPath As String)
        Try
            Dim NumberOfParameters As Int16 = 0
            Dim CurRow As Int16 = 0
            Dim DistanceBetweenControls As Int16 = 32
            Dim DistanceBetweenLabelAndControl As Int16 = 22
            Dim btnControl As Button
            Dim lblControl As Label
            Dim lblIndex As Int16 = 0
            Dim DtControl As DateTimePicker
            Dim cboControl As ComboBox
            Dim NumControl As NumericUpDown
            Dim ChkControl As CheckBox
            Dim rptDocument As New ReportDocument

            '* LOAD THE REPORT FILE
            'rptDocument.Load(FullReportPath)
            rptDocument.Load(FullReportPath)

            '* SHOW TITLE SUBJECT COMMENTS>> IN REPORT INFO
            Me.lblRptTitle.Text = rptDocument.SummaryInfo.ReportTitle
            Me.lblRptSubject.Text = rptDocument.SummaryInfo.ReportSubject
            Me.lblRptComments.Text = rptDocument.SummaryInfo.ReportComments

            '* CHECK PARAMETERS ON THE REPORS
            For Each MyParam As ParameterField In rptDocument.ParameterFields
                If MyParam.ReportName = "" Then
                    NumberOfParameters += 1
                    Select Case MyParam.ParameterValueType
                        Case ParameterValueKind.BooleanParameter
                            lblControl = New Label
                            lblControl.Name = "lblBoolean"
                            lblControl.Text = NumberOfParameters & ". " & MyParam.PromptText
                            lblControl.Top = CurRow
                            lblControl.AutoSize = True
                            Me.pnlFilterControls.Controls.Add(lblControl)
                            CurRow += DistanceBetweenLabelAndControl

                            ChkControl = New CheckBox
                            ChkControl.Name = MyParam.Name
                            ChkControl.Tag = MyParam.Name
                            ChkControl.Top = CurRow
                            ChkControl.Checked = False
                            ChkControl.Left = 20
                            
                            Me.pnlFilterControls.Controls.Add(ChkControl)
                            CurRow += DistanceBetweenControls

                        Case ParameterValueKind.CurrencyParameter
                            lblControl = New Label
                            lblControl.Name = "lblCurrency"
                            lblControl.Text = NumberOfParameters & ". " & MyParam.PromptText
                            lblControl.Top = CurRow
                            lblControl.AutoSize = True
                            Me.pnlFilterControls.Controls.Add(lblControl)
                            CurRow += DistanceBetweenLabelAndControl

                            NumControl = New NumericUpDown
                            NumControl.Name = MyParam.Name
                            NumControl.Tag = MyParam.Name
                            NumControl.Top = CurRow
                            NumControl.Minimum = 0
                            NumControl.Maximum = 100
                            NumControl.Left = 20
                            
                            Me.pnlFilterControls.Controls.Add(NumControl)
                            CurRow += DistanceBetweenControls

                        Case ParameterValueKind.DateParameter, ParameterValueKind.DateTimeParameter
                            lblControl = New Label
                            lblControl.Name = "lblTextDt"
                            lblControl.Text = NumberOfParameters & ". " & MyParam.PromptText
                            lblControl.Top = CurRow
                            lblControl.AutoSize = True
                            Me.pnlFilterControls.Controls.Add(lblControl)
                            CurRow += DistanceBetweenLabelAndControl

                            DtControl = New DateTimePicker
                            DtControl.Name = "FROM_" & MyParam.Name
                            DtControl.Tag = MyParam.Name
                            DtControl.Top = CurRow
                            DtControl.Left = 20
                            
                            Select Case MyParam.ParameterValueType
                                Case ParameterValueKind.DateParameter
                                    DtControl.Format = DateTimePickerFormat.Short
                                Case ParameterValueKind.DateTimeParameter
                                    DtControl.Format = DateTimePickerFormat.Long
                                Case ParameterValueKind.TimeParameter
                                    DtControl.Format = DateTimePickerFormat.Time
                            End Select
                            DtControl.Value = DateAdd(DateInterval.Day, -DatePart(DateInterval.Day, Now), Now)
                            pnlFilterControls.Controls.Add(DtControl)
                            CurRow += DistanceBetweenLabelAndControl

                            If MyParam.PromptingType = DiscreteOrRangeKind.DiscreteAndRangeValue Or MyParam.PromptingType = DiscreteOrRangeKind.RangeValue Then
                                DtControl = New DateTimePicker
                                DtControl.Name = "TO_" & MyParam.Name
                                DtControl.Tag = MyParam.Name
                                DtControl.Top = CurRow
                                DtControl.Left = 20

                                Select Case MyParam.ParameterValueType
                                    Case ParameterValueKind.DateParameter
                                        DtControl.Format = DateTimePickerFormat.Short
                                    Case ParameterValueKind.DateTimeParameter
                                        DtControl.Format = DateTimePickerFormat.Long
                                    Case ParameterValueKind.TimeParameter
                                        DtControl.Format = DateTimePickerFormat.Time
                                End Select
                                DtControl.Value = Now
                                pnlFilterControls.Controls.Add(DtControl)
                                CurRow += DistanceBetweenControls
                            End If
                        Case ParameterValueKind.NumberParameter
                            lblControl = New Label
                            lblControl.Name = "lblNumber"
                            lblControl.Text = NumberOfParameters & ". " & MyParam.PromptText
                            lblControl.Top = CurRow
                            lblControl.AutoSize = True
                            Me.pnlFilterControls.Controls.Add(lblControl)
                            CurRow += DistanceBetweenLabelAndControl

                            NumControl = New NumericUpDown
                            NumControl.Name = MyParam.Name
                            NumControl.Tag = MyParam.Name
                            NumControl.Top = CurRow
                            'NumControl.Minimum = MyParam.MinimumValue
                            'NumControl.Maximum = MyParam.MaximumValue
                            NumControl.Left = 20

                            Me.pnlFilterControls.Controls.Add(NumControl)
                            CurRow += DistanceBetweenControls
                        Case ParameterValueKind.StringParameter
                            lblControl = New Label
                            lblControl.Name = "lblString"
                            lblControl.Text = NumberOfParameters & ". " & MyParam.PromptText
                            lblControl.Top = CurRow
                            lblControl.AutoSize = True
                            Me.pnlFilterControls.Controls.Add(lblControl)
                            CurRow += DistanceBetweenLabelAndControl

                            cboControl = New ComboBox
                            cboControl.Top = CurRow
                            cboControl.Left = 20
                            cboControl.Name = MyParam.Name
                            cboControl.Tag = MyParam.Name
                            For Each X As ParameterDiscreteValue In MyParam.DefaultValues
                                cboControl.Items.Add(X.Value)
                            Next

                            Me.pnlFilterControls.Controls.Add(cboControl)
                            CurRow += DistanceBetweenControls
                    End Select
                End If
            Next

            '* CREATE THE RUN REPORT BUTTON                
            btnControl = New Button
            btnControl.Name = "cmdRunReport"
            btnControl.AutoSize = True
            btnControl.Text = "Run Report"
            btnControl.Top = CurRow
            AddHandler btnControl.Click, AddressOf cmdRunReport_Click
            Me.pnlFilterControls.Controls.Add(btnControl)            

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Load Report form
    Sub Fill_Reports(ByVal MyTreeView As TreeView)
        Try
            Dim ReportRootPath As String = ReportappPath
            Dim DirInfo As DirectoryInfo = New DirectoryInfo(ReportRootPath)

            Dim RootNode As TreeNode = MyTreeView.Nodes(0)
            Dim StudyFolderNode As TreeNode = Nothing
            Dim SubFolderNode As TreeNode = Nothing
            Dim ReportNode As TreeNode = Nothing

            For Each MyStudyDirInfo As DirectoryInfo In DirInfo.GetDirectories()
                StudyFolderNode = New TreeNode
                StudyFolderNode.Text = MyStudyDirInfo.Name
                StudyFolderNode.Tag = ""

                For Each MySubFolderDirInfo As DirectoryInfo In MyStudyDirInfo.GetDirectories()

                    SubFolderNode = New TreeNode
                    SubFolderNode.Text = MySubFolderDirInfo.Name
                    SubFolderNode.Tag = ""

                    '* LOOP THROUG THE FILES IN THIS DIRECTORY                                
                    For Each MyFileInfo As FileInfo In MySubFolderDirInfo.GetFiles()
                        ReportNode = New TreeNode
                        ReportNode.Text = MyFileInfo.Name
                        ReportNode.Tag = MyFileInfo.FullName
                        'MsgBox(MyFileInfo.Name + " name  " + MyFileInfo.FullName)
                        If MyFileInfo.Name = "Thumbs.db" Then
                            'MsgBox(MyFileInfo.Name + " name  " + MyFileInfo.FullName)
                        Else
                            SubFolderNode.Nodes.Add(ReportNode)
                        End If

                    Next
                    StudyFolderNode.Nodes.Add(SubFolderNode)
                Next
                RootNode.Nodes.Add(StudyFolderNode)
            Next
            MyTreeView.ExpandAll()
            MyTreeView.SelectedNode = MyTreeView.Nodes(0)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cmdRunReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            RunReport()         
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub RunReport()
        Try
            'MessageBox.Show("run")
            Dim frmrptViewer As New frmReportViewer
            frmrptViewer.reportDocument1.Load(Me.trvReports.SelectedNode.Tag)
            frmrptViewer.reportDocument1.DataSourceConnections(0).SetConnection(appPath & "\Data\RISdata.mdb", appPath & "\Data\RISdata.mdb", False)
            frmrptViewer.CrystalReportViewer1.ReportSource = frmrptViewer.reportDocument1


            '* CLEAR PARAMETERS
            frmrptViewer.CrystalReportViewer1.ParameterFieldInfo.Clear()

            Dim pField As CrystalDecisions.Shared.ParameterField = Nothing
            Dim pVal As CrystalDecisions.Shared.ParameterDiscreteValue = Nothing
            Dim ParameterRangeValue As CrystalDecisions.Shared.ParameterRangeValue = Nothing
            Dim FromDtCrl As DateTimePicker = Nothing
            For Each x As Control In Me.pnlFilterControls.Controls
                If TypeOf x Is Label Then

                ElseIf (TypeOf x Is TextBox) Or (TypeOf x Is ComboBox) Or (TypeOf x Is NumericUpDown) Then
                    'If Not x.Text.ToUpper <> "USER" And Not x.Text.ToUpper <> "PSWD" Then
                    pVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    pVal.Value = x.Text
                    pField = New CrystalDecisions.Shared.ParameterField
                    pField.Name = x.Tag
                    pField.CurrentValues.Add(pVal)
                    pField.HasCurrentValue = True
                    pField.PromptingType = DiscreteOrRangeKind.DiscreteValue
                    pField.ReportParameterType = ParameterType.ReportParameter
                    frmrptViewer.CrystalReportViewer1.ParameterFieldInfo.Add(pField)
                    'End If
                ElseIf TypeOf x Is CheckBox Then
                    pVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    pVal.Value = CType(x, CheckBox).Checked
                    pField = New CrystalDecisions.Shared.ParameterField
                    pField.Name = x.Tag
                    pField.CurrentValues.Add(pVal)
                    pField.HasCurrentValue = True
                    pField.PromptingType = DiscreteOrRangeKind.DiscreteValue
                    pField.ReportParameterType = ParameterType.ReportParameter
                    frmrptViewer.CrystalReportViewer1.ParameterFieldInfo.Add(pField)
                ElseIf TypeOf x Is DateTimePicker Then
                    If Me.pnlFilterControls.Controls.Find("TO_" & x.Name.Substring(x.Name.IndexOf("_") + 1), False).Length > 0 Then
                        '* SET DATE RANGE VALUE
                        ParameterRangeValue = New CrystalDecisions.Shared.ParameterRangeValue
                        ParameterRangeValue.EndValue = CType(Me.pnlFilterControls.Controls.Find("TO_" & x.Name.Substring(x.Name.IndexOf("_") + 1), False)(0).Text, Date)
                        ParameterRangeValue.StartValue = CType(Me.pnlFilterControls.Controls.Find("FROM_" & x.Name.Substring(x.Name.IndexOf("_") + 1), False)(0).Text, Date)

                        pField = New CrystalDecisions.Shared.ParameterField
                        pField.Name = x.Tag
                        pField.CurrentValues.Add(ParameterRangeValue)
                        pField.HasCurrentValue = True
                        pField.PromptingType = DiscreteOrRangeKind.RangeValue
                        pField.ReportParameterType = ParameterType.ReportParameter
                        frmrptViewer.CrystalReportViewer1.ParameterFieldInfo.Add(pField)
                    Else
                        pVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                        pVal.Value = CType(Me.pnlFilterControls.Controls.Find("FROM_" & x.Name.Substring(x.Name.IndexOf("_") + 1), False)(0).Text, Date)
                        pField = New CrystalDecisions.Shared.ParameterField
                        pField.Name = x.Tag
                        pField.CurrentValues.Add(pVal)
                        pField.HasCurrentValue = True
                        pField.PromptingType = DiscreteOrRangeKind.DiscreteValue
                        pField.ReportParameterType = ParameterType.ReportParameter
                        frmrptViewer.CrystalReportViewer1.ParameterFieldInfo.Add(pField)
                    End If
                Else


                End If
            Next
            'Dim i As Integer
            'i = 0
            'Dim paths As String() = Me.trvReports.SelectedNode.Tag.Split(New Char() {"\"c})
            'Dim path As String = paths(paths.Length - 1)
            'If Path = "Female Subjects - CryoVial Labels.rpt" Then
            'MessageBox.Show(frmrptViewer.reportDocument1.RecordSelectionFormula)
            'frmrptViewer.reportDocument1.RecordSelectionFormula = "(   (   (  {qryStuHpvFindExistingSubjectIDs2.LabelVisit} = {?Visit#}  AND  {@SubjNum} in right({?PmSubjNum1},5) to right({?PmSubjNum2},5)  )   AND  {qryStuHpvFindExistingSubjectIDs2.LabelCode} = ""S""  )   AND  {qryStuHpvFindExistingSubjectIDs2.LabelGender} in [""MF"", ""F""]  )"
            'frmrptViewer.CrystalReportViewer1.ReportSource = frmrptViewer.reportDocument1
            'End If
            'MessageBox.Show(frmrptViewer.reportDocument1.RecordSelectionFormula)
            'frmrptViewer.CrystalReportViewer1.SelectionFormula = "(   (   (  {qryStuHpvFindExistingSubjectIDs2.LabelVisit} = {?Visit#}  AND  {@SubjNum} in right({?PmSubjNum1},5) to right({?PmSubjNum2},5)  )   AND  {qryStuHpvFindExistingSubjectIDs2.LabelCode} = ""S""  )   AND  {qryStuHpvFindExistingSubjectIDs2.LabelGender} in [""MF"", ""F""]  )"
            'frmReportViewer.CrystalReportViewer1.SelectionFormula = "( ( ({qryStuHpvFindExistingSubjectIDs2.LabelVisit} = {?Visit#} ) )  )"
            frmrptViewer.CrystalReportViewer1.SelectionFormula = frmrptViewer.reportDocument1.RecordSelectionFormula

            frmrptViewer.CrystalReportViewer1.Show()
            frmrptViewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class


