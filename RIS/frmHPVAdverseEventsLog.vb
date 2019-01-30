Imports RIS.RISdataDataSet


Public Class frmHPVAdverseEventsLog
    Private pFromDate As Nullable(Of Date)
    Private pToDate As Nullable(Of Date)


    Public ReadOnly Property FromDate() As Nullable(Of Date)
        Get
            Me.pFromDate = New Nullable(Of Date)

            If Not IsDBNull(Me.dtpFromDate.Value) Then
                pFromDate = Me.dtpFromDate.Value
            Else
                pFromDate = #1/1/1900#
            End If
            Return pFromDate

        End Get
    End Property

    Public ReadOnly Property ToDate() As Nullable(Of Date)
        Get
            Me.pToDate = New Nullable(Of Date)

            If Not IsDBNull(Me.dtpToDate.Value) Then
                pToDate = Me.dtpToDate.Value
            Else
                pToDate = Today.AddYears(10)

            End If
            Return pToDate
        End Get
    End Property

    Private Sub btnSaveLog_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveLog.Click

        Me.SaveLog()
    End Sub

    Private Sub SaveLog()
        Me.Validate()
        Me.bsAdverseEvents.EndEdit()
        Me.bsSymptoms.EndEdit()
        Me.bsInterventions.EndEdit()

        Me.RISdataDataSet.tbStuHpvAdEventsLog.Merge(Me.RISdataDataSet.qryAdverseEvents)
        Me.TbStuHpvAdEventsLogTableAdapter.Update(Me.RISdataDataSet.tbStuHpvAdEventsLog)
        Me.TbStuHpvAdEventsSymptomsTableAdapter.Update(Me.RISdataDataSet)
        Me.TbStuHpvAdEventsInterventionsTableAdapter.Update(Me.RISdataDataSet)

        Me.btnSaveLog.Enabled = False

    End Sub

    Private Sub frmHPVAdverseEventsLog_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        vfrmHPVAdverseEventsLog = Nothing
    End Sub

    Private Sub frmHPVAdverseEventsLog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        If Me.btnSaveLog.Enabled = True Then
            Dim Results As DialogResult = _
            MessageBox.Show("Changes detected, would you like to save?", "Changes Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            Select Case Results
                Case Windows.Forms.DialogResult.Yes
                    Me.SaveLog()
                Case Windows.Forms.DialogResult.No


                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If


    End Sub

    Private Sub frmHPVAdverseEventsLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
        'Sets connection strings
        Me.DdvAdEventRelProtocolTableAdapter.SetConnectionString(strConn)
        Me.DdvAdEventRecoveryTableAdapter.SetConnectionString(strConn)
        Me.DdvAdEventSeverityTableAdapter.SetConnectionString(strConn)
        Me.DdvResearcherTableAdapter.SetConnectionString(strConn)
        Me.DdvPhysicianTableAdapter.SetConnectionString(strConn)
        Me.TbStuHpvAdEventsLogTableAdapter.SetConnectionString(strConn)
        Me.DdvYesNoTableAdapter.Connection.ConnectionString = strConn
        Me.TbStuHpvAdEventsSymptomsTableAdapter.Connection.ConnectionString = strConn
        Me.TbStuHpvAdEventsInterventionsTableAdapter.Connection.ConnectionString = strConn
        Me.TbStuHpvAdEventsInterventionsTableAdapter.Connection.ConnectionString = strConn
        Me.TbStuHpvAdEventsSymptomsTableAdapter.Connection.ConnectionString = strConn
        Me.QryAdverseEventsTableAdapter.Connection.ConnectionString = strConn
        Me.DdvAdEventInterventionTableAdapter.Connection.ConnectionString = strConn
        Me.DdvAdEventsSymptomTableAdapter.Connection.ConnectionString = strConn


        'Fill dropdown tables
        Me.DdvAdEventRelProtocolTableAdapter.Fill(Me.RISdataDataSet.ddvAdEventRelProtocol)
        Me.DdvAdEventRecoveryTableAdapter.Fill(Me.RISdataDataSet.ddvAdEventRecovery)
        Me.DdvAdEventSeverityTableAdapter.Fill(Me.RISdataDataSet.ddvAdEventSeverity)
        Me.DdvResearcherTableAdapter.Fill(Me.RISdataDataSet.ddvResearcher)
        Me.DdvPhysicianTableAdapter.Fill(Me.RISdataDataSet.ddvPhysician)
        Me.DdvYesNoTableAdapter.Fill(Me.RISdataDataSet.ddvYesNo)
        Me.DdvAdEventInterventionTableAdapter.Fill(Me.RISdataDataSet.ddvAdEventIntervention)
        Me.DdvAdEventsSymptomTableAdapter.Fill(Me.RISdataDataSet.ddvAdEventsSymptom)


        Me.dtpFromDate.Value = Today.AddDays(-30)
        Me.dtpToDate.Value = Today


    End Sub

    Private Sub CreateStubs()
        For Each r As qryAdverseEventsRow In Me.RISdataDataSet.qryAdverseEvents
            If r.IsAdEventsLogIDNull Then
                Dim newrow As tbStuHpvAdEventsLogRow
                newrow = Me.RISdataDataSet.tbStuHpvAdEventsLog.NewtbStuHpvAdEventsLogRow
                newrow.VisitID = r.VisitID
                Me.RISdataDataSet.tbStuHpvAdEventsLog.AddtbStuHpvAdEventsLogRow(newrow)
            End If
        Next
        Me.TbStuHpvAdEventsLogTableAdapter.Update(Me.RISdataDataSet.tbStuHpvAdEventsLog)
        Me.RISdataDataSet.tbStuHpvAdEventsLog.Clear()


    End Sub
    Private Sub TbStuHpvAdEventsLogDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdSymptoms.DataError, grdIntervention.DataError, grdAdverseEventLog.DataError
        e.ThrowException = False

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        Me.bsAdverseEvents.SuspendBinding()
        Me.bsInterventions.SuspendBinding()
        Me.bsSymptoms.SuspendBinding()
        Dim hasRows As Boolean
        If Me.QryAdverseEventsTableAdapter.FillByDate(Me.RISdataDataSet.qryAdverseEvents, Me.FromDate, Me.ToDate) > 0 Then
            hasRows = True
        End If
        Me.bsSymptoms.AllowNew = hasRows
        Me.bsInterventions.AllowNew = hasRows

        Me.TbStuHpvAdEventsSymptomsTableAdapter.FillByDate(Me.RISdataDataSet.tbStuHpvAdEventsSymptoms, Me.FromDate, Me.ToDate)
        Me.TbStuHpvAdEventsInterventionsTableAdapter.FillByDate(Me.RISdataDataSet.tbStuHpvAdEventsInterventions, Me.FromDate, Me.ToDate)

        Me.CreateStubs()

        Me.btnSaveLog.Enabled = False

        Me.bsAdverseEVents.ResumeBinding()
        Me.bsInterventions.ResumeBinding()
        Me.bsSymptoms.ResumeBinding()
    End Sub


    Private Function CheckForChanges() As Boolean
        Dim isChanged As Boolean

        Me.bsAdverseEvents.EndEdit()
        Me.bsInterventions.EndEdit()
        Me.bsSymptoms.EndEdit()

        isChanged = Validation.CheckForChanges(Me.RISdataDataSet.qryAdverseEvents)
        If isChanged Then
            Return isChanged
        End If

        isChanged = Validation.CheckForChanges(Me.RISdataDataSet.tbStuHpvAdEventsInterventions)
        If isChanged Then
            Return isChanged
        End If

        isChanged = Validation.CheckForChanges(Me.RISdataDataSet.tbStuHpvAdEventsSymptoms)
        If isChanged Then
            Return isChanged
        End If


        Return isChanged

    End Function

    Private Function CheckCellForChange(ByVal e As DataGridViewCellEventArgs) As Boolean

        Dim isChanged As Boolean

        Dim row As RISdataDataSet.qryAdverseEventsRow
        row = Me.GetCurrentAdverseLogRow
        If row IsNot Nothing Then
            row.EndEdit()
            isChanged = Validation.CheckForChanges(row, Me.grdAdverseEventLog.Columns(e.ColumnIndex).DataPropertyName)
        End If
        Return isChanged

    End Function

    Public Function GetCurrentAdverseLogRow() As qryAdverseEventsRow
        Dim Row As qryAdverseEventsRow = Nothing
        If Me.bsAdverseEvents.Position <> -1 Then
            Row = CType(Me.bsAdverseEvents.Current, DataRowView).Row
        End If
        Return Row

    End Function

    Private Sub grdAdverseEventLog_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdAdverseEventLog.CellBeginEdit
        Me.btnCancelEdit.Visible = True
    End Sub

    Private Sub grdAdverseEventLog_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAdverseEventLog.CellEndEdit, grdIntervention.CellEndEdit, grdSymptoms.CellEndEdit

        Dim DataGrid As DataGridView = CType(sender, DataGridView)
        If DataGrid.Name = "grdAdverseEventLog" Then
            Me.btnCancelEdit.Visible = False
            Me.grdAdverseEventLog.Rows(e.RowIndex).ErrorText = String.Empty
        End If
        Me.btnSaveLog.Enabled = Me.CheckForChanges()
        If Me.CheckCellForChange(e) Then
            Me.SetLastEditInfo()
        End If
    End Sub

    Private Sub grdAdverseEventLog_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grdAdverseEventLog.CellValidating
        e.Cancel = Me.ValidateCells(e.FormattedValue.ToString, e.ColumnIndex, e.RowIndex)
    End Sub

    Private Sub grdAdverseEventLog_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdAdverseEventLog.RowValidating
        For Each c As DataGridViewCell In Me.grdAdverseEventLog.Rows(e.RowIndex).Cells
            If Me.ValidateCells(c.FormattedValue, c.ColumnIndex, e.RowIndex) Then
                e.Cancel = True
                Exit Sub
            End If
        Next
    End Sub

    Private Sub btnCancelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEdit.Click
        Me.grdAdverseEventLog.CancelEdit()
    End Sub

    Private Function ValidateCells(ByVal value As String, ByVal ColIndex As Integer, ByVal RowIndex As Integer) As Boolean
        Dim Col As DataGridViewColumn
        Dim ColName As String
        Dim ErrorText As String = String.Empty
        Dim Cancel As Boolean


        Col = Me.grdAdverseEventLog.Columns(ColIndex)
        ColName = Col.DataPropertyName


        Select Case ColName

            Case Is = "DateOnset", "ResearcherEntryDate", "PhysicianReviewDate"
                If Not String.IsNullOrEmpty(value) And Not IsDate(value) Then
                    Cancel = True
                    ErrorText = Col.HeaderText & " is not a recognized date."
                End If

        End Select

        Me.grdAdverseEventLog.Rows(RowIndex).ErrorText = ErrorText
        Return Cancel

    End Function

    Private Sub SetLastEditInfo()
        Dim Current As RISdataDataSet.qryAdverseEventsRow
        Current = Me.GetCurrentAdverseLogRow
        If Current IsNot Nothing Then
            Current.LastEditLoginID = strLoginID
            Current.LastEditDate = Now
        End If
    End Sub
 
 
    Private Sub ChildGridAddOrDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem1.Click, BindingNavigatorDeleteItem2.Click, BindingNavigatorDeleteItem1.Click, BindingNavigatorAddNewItem2.Click
        Me.btnSaveLog.Enabled = True

    End Sub
End Class