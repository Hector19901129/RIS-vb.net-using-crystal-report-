Imports RIS.RISdataDataSet
Imports RIS.RISdataDataSetTableAdapters
Imports Umbrae.Windows.Forms
Imports System.Threading

Public Class frmIncentiveLogs

    Private pType As IncentTypes
    Private pTable As IncentiveLogDataTable
    Private pGrid As DataGridView
    Private pdtpFrom As DateTimeSlicker
    Private pdtpTo As DateTimePicker
    Private pStudycmb As ComboBox
    Private pSavebtn As ToolStripButton
    Private pCancelBtn As ToolStripButton
    Private pBS As BindingSource
    Private pRefreshBtn As Button



    Public Property IncentType() As IncentTypes
        Get
            Return Me.pType

        End Get
        Set(ByVal value As IncentTypes)
            Me.pType = value
        End Set
    End Property

    Public Property IncentiveTable() As IncentiveLogDataTable

        Get
            If Me.pTable Is Nothing Then
                Me.pTable = Me.RISdataDataSet2.Tables("Movies")
            End If
            Return Me.pTable
        End Get
        Set(ByVal value As IncentiveLogDataTable)
            Me.pTable = value
        End Set
    End Property

    Public Property Grid() As DataGridView
        Get
            If Me.pGrid Is Nothing Then
                Me.pGrid = Me.grdMovies
            End If
            Return Me.pGrid
        End Get
        Set(ByVal value As DataGridView)
            Me.pGrid = value
        End Set
    End Property

    Public Property dtpFrom() As DateTimeSlicker
        Get
            Return Me.pdtpFrom
        End Get
        Set(ByVal value As DateTimeSlicker)
            Me.pdtpFrom = value
        End Set
    End Property

    Public Property dtpTo() As DateTimeSlicker
        Get
            Return Me.pdtpTo
        End Get
        Set(ByVal value As DateTimeSlicker)
            Me.pdtpTo = value
        End Set
    End Property

    Public Property Studycmb() As ComboBox
        Get
            Return Me.pStudycmb
        End Get
        Set(ByVal value As ComboBox)
            Me.pStudycmb = value
        End Set
    End Property

    Public Property SaveBtn() As ToolStripButton
        Get
            Return Me.pSavebtn
        End Get
        Set(ByVal value As ToolStripButton)
            Me.pSavebtn = value
        End Set
    End Property

    Public Property CancelBtn() As ToolStripButton
        Get
            Return Me.pCancelBtn
        End Get
        Set(ByVal value As ToolStripButton)
            Me.pCancelBtn = value
        End Set
    End Property

    Public Property BindingSrc() As BindingSource
        Get
            Return Me.pBS

        End Get
        Set(ByVal value As BindingSource)
            Me.pBS = value

        End Set
    End Property

    Public Property RefreshBtn() As Button
        Get
            Return Me.pRefreshBtn
        End Get
        Set(ByVal value As Button)
            Me.pRefreshBtn = value
        End Set
    End Property

    Public Enum IncentTypes
        MovieTickets = 8
        GiftCards = 14
        MetroCards = 15
    End Enum

    Private Sub frmIncentiveLogs_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        vfrmIncetiveLog = Nothing

    End Sub

    Private Sub frmIncentiveLogs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = Me.CheckChanges

    End Sub


    Private Sub frmIncentiveLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim handler As ThreadExceptionHandler = _
                   New ThreadExceptionHandler()

        AddHandler Application.ThreadException, _
            AddressOf handler.Application_ThreadException

        Me.IncentiveLogTableAdapter.SetConnectionString(strConn)
        Me.DdvResearcherTableAdapter.SetConnectionString(strConn)
        Me.TbStudyTableAdapter.SetConnectionString(strConn)



        Me.TbStudyTableAdapter.Fill(Me.RISdataDataSet2.tbStudy)
        Me.DdvResearcherTableAdapter.Fill(Me.RISdataDataSet2.ddvResearcher)


        Dim Movies As New IncentiveLogDataTable
        Dim Gifts As New IncentiveLogDataTable
        Dim MetroCards As New IncentiveLogDataTable

        Movies.TableName = "Movies"
        Gifts.TableName = "Gifts"
        MetroCards.TableName = "MetroCards"

        Me.RISdataDataSet2.Tables.Add(Movies)
        Me.RISdataDataSet2.Tables.Add(Gifts)
        Me.RISdataDataSet2.Tables.Add(MetroCards)

        Me.bsGiftCard.DataMember = "Gifts"
        Me.bsMovie.DataMember = "Movies"
        Me.bsMetroCard.DataMember = "MetroCards"

        Me.SetupMovieTab()
        Me.AcceptButton = Me.RefreshBtn

        Me.dtpFromDate.Value = Today.AddDays(-30)
        Me.dtpTodate.Value = Today





    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        Select Case Me.TabControl1.SelectedIndex
            Case Is = 0
                Me.SetupMovieTab()

            Case Is = 1
                Me.SetupGiftsTab()
            Case Is = 2
                Me.SetupMetroCardTab()

        End Select
        Me.AcceptButton = Me.RefreshBtn

    End Sub

    Private Sub SetupMovieTab()
        Me.IncentType = IncentTypes.MovieTickets
        Me.IncentiveTable = Me.RISdataDataSet2.Tables("Movies")
        Me.Grid = Me.grdMovies
        Me.pdtpFrom = Me.dtpMovieFrom
        Me.pdtpTo = Me.dtpMovieTo
        Me.pStudycmb = Me.cmbMovieStudy
        Me.SaveBtn = Me.btnSaveMovieTickets
        Me.CancelBtn = Me.btnMTCancelChanges
        Me.BindingSrc = Me.bsMovie
        Me.RefreshBtn = Me.btnMovieRefresh

    End Sub

    Private Sub SetupGiftsTab()
        Me.IncentType = IncentTypes.GiftCards
        Me.IncentiveTable = Me.RISdataDataSet2.Tables("Gifts")
        Me.Grid = Me.grdGifts
        Me.pdtpFrom = Me.dtpFromDate
        Me.pdtpTo = Me.dtpToDate
        Me.pStudycmb = Me.cmbStudy
        Me.SaveBtn = Me.btnSaveGiftCards
        Me.CancelBtn = Me.btnGCCancelChanges
        Me.BindingSrc = Me.bsGiftCard
        Me.RefreshBtn = Me.btnGiftsRefresh

    End Sub

    Private Sub SetupMetroCardTab()
        Me.IncentType = IncentTypes.MetroCards
        Me.IncentiveTable = Me.RISdataDataSet2.Tables("MetroCards")
        Me.Grid = Me.grdMetrocard
        Me.pdtpFrom = Me.dtMFromDate
        Me.pdtpTo = Me.dtMToDt
        Me.pStudycmb = Me.cboMetroStudy
        Me.SaveBtn = Me.btnSaveMetroCards
        Me.CancelBtn = Me.btnMCCancelChanges
        Me.BindingSrc = Me.bsMetroCard
        Me.RefreshBtn = Me.cmdMetroRefresh

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGifts.CellEndEdit, grdMovies.CellEndEdit, grdMetrocard.CellEndEdit
        'Dim Incentive As IncentiveLogRow

        'Incentive = Me.IncentiveTable(e.RowIndex)

        'Dim Current As String
        'If Convert.IsDBNull(Incentive(Me.Grid.Columns(e.ColumnIndex).Name, DataRowVersion.Current)) Then
        '    Current = String.Empty
        'Else
        '    Current = Incentive(Incentive(Me.Grid.Columns(e.ColumnIndex).Name, DataRowVersion.Current))
        'End If

        'Dim Original As String
        'If Convert.IsDBNull(Incentive(e.ColumnIndex, DataRowVersion.Original)) Then
        '    Original = String.Empty
        'Else
        '    Original = Incentive(e.ColumnIndex, DataRowVersion.Original)
        'End If



        'Dim isDirty As Boolean = Current <> Original
        Me.SaveBtn.Enabled = True '= isDirty
        Me.CancelBtn.Visible = False


    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveGiftCards.Click, btnSaveMetroCards.Click, btnSaveMovieTickets.Click

        Me.UpdateTblIncentiveDtls()


    End Sub

    Private Sub UpdateTblIncentiveDtls()
        Dim CheckTable As tblIncentiveDtlsDataTable
        Me.BindingSrc.EndEdit()
        Me.BindingSrc.SuspendBinding()


        Dim TA As tblIncentiveDtlsTableAdapter = New tblIncentiveDtlsTableAdapter
        TA.SetConnectionString(strConn)

        If Me.IncentiveTable.GetChanges IsNot Nothing Then
            For Each row As IncentiveLogRow In Me.IncentiveTable.GetChanges.Rows

                'GET AMOUNT and ResearchCD Values
                Dim Amount As String
                Dim ResearcherCd As Nullable(Of Integer)
                Dim SerialNum As String = String.Empty

                If Not row.IsAmountNull Then
                    Amount = row.Amount
                End If

                If Not row.IsResearcherCdNull Then
                    ResearcherCd = row.ResearcherCd
                End If

                If Not row.IsSerialNumNull Then
                    SerialNum = row.SerialNum

                End If

                If row.IsIncentiveIDNull Then
                    'INSERT ROW IN THE DATABASE (tblIncentiveDtls)
                    TA.Insert(row.VisitID, row.FormCd, Amount, ResearcherCd, SerialNum)

                Else
                    'UPDATE ROW IN THE DATABASE (tblIncentiveDtls)
                    TA.Update(row.VisitID, row.FormCd, Amount, ResearcherCd, SerialNum, row.IncentiveID)
                End If
                row.AcceptChanges()

            Next
            Me.IncentiveTable.AcceptChanges()

        End If
        Me.SaveBtn.Enabled = False
        Me.BindingSrc.ResumeBinding()
        Me.RefreshData()


    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGiftsRefresh.Click, btnMovieRefresh.Click, cmdMetroRefresh.Click
        Me.RefreshData()

    End Sub

    Private Sub RefreshData()
        If Not Me.CheckChanges Then
            Dim FromDate As Nullable(Of Date)
            Dim ToDate As Nullable(Of Date)

            Try
                FromDate = Date.Parse(Me.dtpFrom.Value).ToShortDateString
            Catch ex As Exception
                FromDate = #1/1/2000#
            End Try
            Try
                ToDate = Date.Parse(Me.dtpTo.Value).ToShortDateString
            Catch ex As Exception
                ToDate = Today.AddDays(4)
            End Try

            Try
                Me.IncentiveLogTableAdapter.FillByDateStudy(Me.IncentiveTable, Me.IncentType, Me.Studycmb.SelectedValue, FromDate, ToDate)
                Me.SaveBtn.Enabled = False
            Catch ex As Exception
                ' ToDate = Today.AddDays(4)
            End Try
        End If
    End Sub

    Private Sub btnMCCancelChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMCCancelChanges.Click, btnMTCancelChanges.Click, btnGCCancelChanges.Click
        Me.Grid.CancelEdit()
        Me.CancelBtn.Visible = False
    End Sub

    Private Sub grdGifts_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdGifts.CellBeginEdit, grdMovies.CellBeginEdit, grdMetrocard.CellBeginEdit
        Me.CancelBtn.Visible = True

    End Sub

    Private Function CheckChanges() As Boolean
        If Me.SaveBtn.Enabled = True Then
            Dim Results As DialogResult = _
            MessageBox.Show("Changes detected, would you like to save?", "Changes Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            Select Case Results
                Case Windows.Forms.DialogResult.Yes
                    Me.UpdateTblIncentiveDtls()


                Case Windows.Forms.DialogResult.No
                    Me.BindingSrc.EndEdit()
                    Me.RISdataDataSet2.RejectChanges()
                    Me.SaveBtn.Enabled = False



                Case Windows.Forms.DialogResult.Cancel
                    Return True


            End Select
        End If
    End Function

    Private Sub TabControl1_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
        e.Cancel = Me.CheckChanges

    End Sub

    Private Sub CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grdGifts.CellValidating, grdMovies.CellValidating, grdMetrocard.CellValidating
        'If Me.Grid.Columns(e.ColumnIndex).HeaderText.ToLower = "amount" Then
        '    If Not IsNumeric(e.FormattedValue) And e.FormattedValue <> String.Empty Then
        '        MessageBox.Show("Amount must be a numeric value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        e.Cancel = True
        '    ElseIf e.FormattedValue = String.Empty Then

        '        ' Me.Grid.CurrentCell.Value = Nothing

        '    End If
        'End If
    End Sub

End Class

Friend Class ThreadExceptionHandler

    '''
    ''' Handles the thread exception.
    '''
    Public Sub Application_ThreadException( _
        ByVal sender As System.Object, _
        ByVal e As ThreadExceptionEventArgs)

        Try
            ' Exit the program if the user clicks Abort.
            Dim result As DialogResult = _
                ShowThreadExceptionDialog(e.Exception)

            If (result = DialogResult.Abort) Then
                Application.Exit()
            End If
        Catch
            ' Fatal error, terminate program
            Try
                MessageBox.Show("Fatal Error", _
                    "Fatal Error", _
                    MessageBoxButtons.OK, _
                    MessageBoxIcon.Stop)
            Finally
                Application.Exit()
            End Try
        End Try
    End Sub

    '''
    ''' Creates and displays the error message.
    '''
    Private Function ShowThreadExceptionDialog( _
        ByVal ex As Exception) As DialogResult

        Dim errorMessage As String = _
            "Unhandled Exception:" _
            & vbCrLf & vbCrLf & _
            ex.Message & vbCrLf & vbCrLf & _
            ex.GetType().ToString() & vbCrLf & vbCrLf & _
            "Stack Trace:" & vbCrLf & _
            ex.StackTrace

        Return MessageBox.Show(errorMessage, _
            "Application Error", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Stop)
    End Function

End Class ' ThreadExceptionHandler