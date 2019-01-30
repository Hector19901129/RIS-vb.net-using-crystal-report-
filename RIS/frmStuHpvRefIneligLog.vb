
Public Class frmStuHpvRefIneligLog

    Private Sub frmStuHpvRefIneligLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Set Connection Strings
        Me.taResearcher.SetConnectionString(strConn)
        Me.taSession.SetConnectionString(strConn)
        Me.taStudy.SetConnectionString(strConn)

        'Fill Dataset
        Me.taResearcher.Fill(Me.RISdataDataSet.ddvResearcher)
        Me.taSession.FillAll(Me.RISdataDataSet.ddvSession)
        Me.FillLog()

    End Sub

    Private Sub frmStuHpvRefIneligLog_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        vfrmStuHpvRefIneligLog = Nothing

    End Sub

    Private Sub frmStuHpvRefIneligLog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.CheckForChanges Then
            Dim Results As DialogResult
            Results = MessageBox.Show("Changes were detected. Would you like to save now?", "Changes Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Select Case Results
                Case Windows.Forms.DialogResult.Yes
                    Me.UpdateLogs()

                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True

            End Select
        End If
    End Sub

    Private Sub FillLog()

        RemoveHandler grdLog.CellEndEdit, AddressOf grdLog_CellEndEdit
        RemoveHandler grdLog.CellValidating, AddressOf grdLog_CellValidating
        RemoveHandler grdLog.RowValidating, AddressOf grdLog_RowValidating


        Me.taStudy.FillAll(Me.RISdataDataSet.tbStuHpvRefIneligLog)

        AddHandler grdLog.CellEndEdit, AddressOf grdLog_CellEndEdit
        AddHandler grdLog.CellValidating, AddressOf grdLog_CellValidating
        AddHandler grdLog.RowValidating, AddressOf grdLog_RowValidating


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Me.UpdateLogs()
    End Sub

    Private Sub UpdateLogs()
        Me.Validate()
        If Not Me.RISdataDataSet.tbStuHpvRefIneligLog.HasErrors Then
            Me.bsLog.EndEdit()
            Me.taStudy.Update(Me.RISdataDataSet.tbStuHpvRefIneligLog)
            Me.btnSave.Enabled = False
        Else
            MessageBox.Show("Errors were found. Please correct errors and try again.", "Errors Detected", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.DeleteCurrent()
    End Sub

    Private Sub DeleteCurrent()
        Dim Results As DialogResult
        Results = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If Results = Windows.Forms.DialogResult.OK Then
            Dim CurrentRow As RISdataDataSet.tbStuHpvRefIneligLogRow
            CurrentRow = Me.GetCurrentLogRow
            If CurrentRow IsNot Nothing Then
                If CurrentRow.RowState = DataRowState.Detached Then
                    Me.grdLog.Rows.Remove(Me.grdLog.CurrentRow)
                Else
                    CurrentRow.Delete()
                    Me.taStudy.Update(CurrentRow)
                End If

            End If
        End If
    End Sub

    Private Sub SetLastEditInfo()
        Dim Current As RISdataDataSet.tbStuHpvRefIneligLogRow
        Current = Me.GetCurrentLogRow
        If Current IsNot Nothing Then
            Current.LastEditLoginID = strLoginID
            Current.LastEditDate = Now
        End If
    End Sub

    Private Function GetCurrentLogRow() As RISdataDataSet.tbStuHpvRefIneligLogRow

        If Me.bsLog.Position <> -1 Then
            Return CType(Me.bsLog.Current, DataRowView).Row

        End If
    End Function

    Public Function ValidateCells(ByVal value As String, ByVal ColIndex As Integer, ByVal RowIndex As Integer) As Boolean
        Dim Col As DataGridViewColumn
        Dim ColName As String
        Dim ErrorText As String = String.Empty
        Dim Cancel As Boolean


        Col = Me.grdLog.Columns(ColIndex)
        ColName = Col.DataPropertyName

        Select Case ColName
            Case Is = "DateApproached"
                If String.IsNullOrEmpty(value) Then
                    Cancel = True
                    ErrorText = Col.HeaderText & " is required."
                Else
                    If Not IsDate(value) Then
                        Cancel = True
                        ErrorText = Col.HeaderText & " is not a recognized date."
                    End If

                End If
               
            Case Is = "SessionID", "ResearcherID"
                If Not String.IsNullOrEmpty(value) AndAlso Not Validation.HasValue(value) Then
                    Cancel = True
                    ErrorText = Col.HeaderText & " is required."
                End If
            Case Is = "Notes", "LastEditLoginID", "LastEditDate"


            Case Else

                If Not String.IsNullOrEmpty(value) AndAlso Not Validation.IsPositiveNumber(value) Then
                    Cancel = True
                    ErrorText = Col.HeaderText & " must be greater than or equal to zero."
                End If


        End Select

        grdLog.Rows(RowIndex).ErrorText = ErrorText
        Return Cancel

    End Function

    Private Function CheckForChanges() As Boolean
        Dim isChanged As Boolean

        Me.bsLog.EndEdit()
        isChanged = Validation.CheckForChanges(Me.RISdataDataSet.tbStuHpvRefIneligLog)

        Me.btnSave.Enabled = isChanged
        Return isChanged

    End Function

    Private Function CheckCellForChange(ByVal e As DataGridViewCellEventArgs) As Boolean

        Dim isChanged As Boolean

        Dim row As RISdataDataSet.tbStuHpvRefIneligLogRow
        row = Me.GetCurrentLogRow
        If row IsNot Nothing Then
            row.EndEdit()
            isChanged = Validation.CheckForChanges(row, grdLog.Columns(e.ColumnIndex).DataPropertyName)
        End If
        Return isChanged

    End Function

    Private Sub grdLog_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)

        For Each c As DataGridViewCell In Me.grdLog.Rows(e.RowIndex).Cells
            If Me.ValidateCells(c.FormattedValue, c.ColumnIndex, e.RowIndex) Then
                e.Cancel = True
                Exit Sub
            End If
        Next
    End Sub

    Private Sub grdLog_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdLog.CellBeginEdit
        Me.btnCancelEdit.Visible = True
    End Sub

    Private Sub grdLog_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Me.btnCancelEdit.Visible = False
        grdLog.Rows(e.RowIndex).ErrorText = String.Empty
        Me.CheckForChanges()
        If Me.CheckCellForChange(e) Then
            Me.SetLastEditInfo()
        End If
    End Sub

    Private Sub grdLog_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs)
        e.Cancel = Me.ValidateCells(e.FormattedValue.ToString, e.ColumnIndex, e.RowIndex)
    End Sub

    Private Sub grdLog_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdLog.DataError
        e.ThrowException = False

    End Sub

    Private Sub btnCancelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.grdLog.CancelEdit()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.FillLog()
    End Sub
End Class