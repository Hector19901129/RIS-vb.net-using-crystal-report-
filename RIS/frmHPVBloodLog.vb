Imports RIS.RISdataDataSet


Public Class frmHPVBloodLog

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

    Private Sub frmHPVBloodLog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.btnSaveBloodLog.Enabled = True Then
            Dim Results As DialogResult = _
            MessageBox.Show("Changes detected, would you like to save?", "Changes Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            Select Case Results
                Case Windows.Forms.DialogResult.Yes
                    Me.SaveBloodLog()


                Case Windows.Forms.DialogResult.No


                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True


            End Select
        End If
    End Sub

    Private Sub frmHPVBloodLog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Me.taBloodLogDisplay.SetConnectionString(strConn)
        Me.taResearcher.SetConnectionString(strConn)
        Me.taBloodLog.SetConnectionString(strConn)

        Me.dtpFromDate.Value = Today.AddDays(-30)
        Me.dtpToDate.Value = Today



        Me.taResearcher.Fill(Me.RISdataDataSet.ddvResearcher)
        Me.FillLog()


    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.taBloodLog.ClearBeforeFill = True

        Me.FillLog()

    End Sub

    Private Sub FillLog()
        Me.bsBloodLog.SuspendBinding()
        Me.RISdataDataSet.HpvBloodLogDisplay.Clear()
        Me.taBloodLogDisplay.Fill(Me.RISdataDataSet.HpvBloodLogDisplay, FromDate, ToDate)
        Me.bsBloodLog.ResumeBinding()
        Me.btnSaveBloodLog.Enabled = False

    End Sub

    Private Sub frmHPVBloodLog_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vfrmHPVBloodLog = Nothing

    End Sub

    Private Sub btnSaveBloodLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBloodLog.Click
        Me.SaveBloodLog()

    End Sub

    Private Sub SaveBloodLog()


        Me.Validate()
        Me.bsBloodLog.EndEdit()
        If Not Me.RISdataDataSet.HpvBloodLogDisplay.HasErrors Then

            For Each row As HpvBloodLogDisplayRow In Me.RISdataDataSet.HpvBloodLogDisplay.GetChanges.Rows

                Dim VisitProcActID As Nullable(Of Int32)
                Dim BloodDrawnTime As String = String.Empty
                Dim BloodSpunTime As String = String.Empty
                Dim BloodStoredTime As String = String.Empty
                Dim TransportDate As Nullable(Of Date)
                Dim SerumExtractTime As String = String.Empty
                Dim NumberOfAliquots As Nullable(Of Integer)
                Dim SerumStoredTime As String = String.Empty
                Dim Notes As String = String.Empty
                Dim ResearcherNameID As Nullable(Of Integer)
                Dim ResearcherEntryDate As Nullable(Of Date)

                Dim LastEditLoginID As String = strLoginID
                Dim LastEditDate As Date = Now

                With row

                    If Not .IsVisitProcActIDNull Then
                        VisitProcActID = .VisitProcActID
                    End If

                    If Not .IsBloodDrawnTimeNull Then
                        BloodDrawnTime = .BloodDrawnTime
                    End If

                    If Not .IsBloodSpunTimeNull Then
                        BloodSpunTime = .BloodSpunTime
                    End If

                    If Not .IsBloodStoredTimeNull Then
                        BloodStoredTime = .BloodStoredTime
                    End If

                    If Not .IsTransportToGCRCDateNull Then
                        TransportDate = .TransportToGCRCDate
                    End If

                    If Not .IsSerumExtractedTimeNull Then
                        SerumExtractTime = .SerumExtractedTime
                    End If
                    If Not .IsNumberAliquotsNull Then
                        NumberOfAliquots = .NumberAliquots
                    End If

                    If Not .IsSerumStoredTimeNull Then
                        SerumStoredTime = .SerumStoredTime
                    End If
                    If Not .IsNotesNull Then
                        Notes = .Notes
                    End If

                    If Not .IsResearcherNameIDNull Then
                        ResearcherNameID = .ResearcherNameID
                    End If

                    If Not .IsResearcherEntryDateNull Then
                        ResearcherEntryDate = .ResearcherEntryDate
                    End If


                    If .IsBloodLogIDNull Then
                        Me.taBloodLog.Insert(VisitProcActID, BloodDrawnTime, BloodSpunTime, BloodStoredTime, TransportDate, SerumExtractTime, NumberOfAliquots, SerumStoredTime, Notes, ResearcherNameID, ResearcherEntryDate, LastEditLoginID, LastEditDate)
                    Else
                        Me.taBloodLog.Update(VisitProcActID, BloodDrawnTime, BloodSpunTime, BloodStoredTime, TransportDate, SerumExtractTime, NumberOfAliquots, SerumStoredTime, Notes, ResearcherNameID, ResearcherEntryDate, LastEditLoginID, LastEditDate, .BloodLogID)
                    End If
                End With



            Next
            Me.btnSaveBloodLog.Enabled = False
            FillLog()
        Else
            MessageBox.Show("Errors were found. Please correct errors and try again.", "Errors Detected", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnCancelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEdit.Click
        Me.grdBloodLog.CancelEdit()
    End Sub

    Private Sub grdBloodLog_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdBloodLog.CellBeginEdit
        Me.btnCancelEdit.Visible = True
    End Sub

    Private Sub grdBloodLog_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdBloodLog.CellEndEdit
        Me.btnCancelEdit.Visible = False
        grdBloodLog.Rows(e.RowIndex).ErrorText = String.Empty
        Me.CheckForChanges()
        If Me.CheckCellForChange(e) Then
            Me.SetLastEditInfo()
        End If

    End Sub

    Private Sub grdBloodLog_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grdBloodLog.CellValidating
        e.Cancel = Me.ValidateCells(e.FormattedValue.ToString, e.ColumnIndex, e.RowIndex)
    End Sub

    Private Sub grdBloodLog_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdBloodLog.RowValidating
        For Each c As DataGridViewCell In Me.grdBloodLog.Rows(e.RowIndex).Cells
            If Me.ValidateCells(c.FormattedValue, c.ColumnIndex, e.RowIndex) Then
                e.Cancel = True
                Exit Sub
            End If
        Next
    End Sub

    Private Function ValidateCells(ByVal value As String, ByVal ColIndex As Integer, ByVal RowIndex As Integer) As Boolean

        Dim Col As DataGridViewColumn
        Dim ColName As String
        Dim ErrorText As String = String.Empty
        Dim Cancel As Boolean


        Col = Me.grdBloodLog.Columns(ColIndex)
        ColName = Col.DataPropertyName

        Select Case ColName
            'validate times
            Case Is = "BloodDrawnTime", "BloodSpunTime", "BloodStoredTime", "SerumExtractedTime", "SerumStoredTime"
                If Not String.IsNullOrEmpty(value) And Not Validation.IsTime(value) Then
                    Cancel = True
                    ErrorText = Col.HeaderText & " is not a recognized time."
                End If
            Case Is = "TransportToGCRCDate", "ResearcherEntryDate"
                If Not String.IsNullOrEmpty(value) And Not IsDate(value) Then
                    Cancel = True
                    ErrorText = Col.HeaderText & " is not a recognized date."
                End If
            Case Is = "NumberAliquots"
                If Not String.IsNullOrEmpty(value) And Not Validation.IsPositiveNumber(value) Then
                    Cancel = True
                    ErrorText = Col.HeaderText & " must be blank or have a value of 0 or greater."
                End If
        End Select

        Me.grdBloodLog.Rows(RowIndex).ErrorText = ErrorText
        Return Cancel
    End Function

    Private Function CheckForChanges() As Boolean
        Dim isChanged As Boolean

        Me.bsBloodLog.EndEdit()
        isChanged = Validation.CheckForChanges(Me.RISdataDataSet.HpvBloodLogDisplay)

        Me.btnSaveBloodLog.Enabled = isChanged
        Return isChanged

    End Function

    Private Function CheckCellForChange(ByVal e As DataGridViewCellEventArgs) As Boolean

        Dim isChanged As Boolean

        Dim row As RISdataDataSet.HpvBloodLogDisplayRow
        row = Me.GetCurrentLogRow
        If row IsNot Nothing Then
            row.EndEdit()
            isChanged = Validation.CheckForChanges(row, Me.grdBloodLog.Columns(e.ColumnIndex).DataPropertyName)
        End If
        Return isChanged

    End Function

    Private Function GetCurrentLogRow() As RISdataDataSet.HpvBloodLogDisplayRow

        If Me.bsBloodLog.Position <> -1 Then
            Return CType(Me.bsBloodLog.Current, DataRowView).Row
        Else
            Return Nothing
        End If

    End Function

    Private Sub SetLastEditInfo()
        Dim Current As RISdataDataSet.HpvBloodLogDisplayRow
        Current = Me.GetCurrentLogRow
        If Current IsNot Nothing Then
            Current.LastEditLoginID = strLoginID
            Current.LastEditDate = Now
        End If
    End Sub

    Private Sub grdBloodLog_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdBloodLog.DataError
        e.ThrowException = False

    End Sub

End Class