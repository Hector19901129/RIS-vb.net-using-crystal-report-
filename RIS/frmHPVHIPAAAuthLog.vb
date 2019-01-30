Imports RIS.RISdataDataSet
Imports RIS.RISdataDataSetTableAdapters
Public Class frmHPVScannedFiledLog
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


    Private Sub frmHPVHIPAAAuthLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RISdataDataSet.tbStuHpvScanFileLog' table. You can move, or remove it, as needed.
        Me.TbStuHpvScanFileLogTableAdapter.SetConnectionString(strConn)        
        Me.TbStuHpvScanFileLogTableAdapter.Fill(Me.RISdataDataSet.tbStuHpvScanFileLog)

        Me.taResearcher.SetConnectionString(strConn)
        Me.taResearcher.Fill(Me.RISdataDataSet.ddvResearcher)

        Me.taScannedFiledLogDisplay.SetConnectionString(strConn)

        Me.dtpFromDate.Value = Today.AddDays(-30)
        Me.dtpToDate.Value = Today

        Me.FillLog()
    End Sub

    Private Sub FillLog()
        Me.RISdataDataSet.HpvScannedFiledLog.Clear()
        Me.taScannedFiledLogDisplay.Fill(Me.RISdataDataSet.HpvScannedFiledLog, FromDate, ToDate)
    End Sub
    Private Sub SaveLog()        

        '* END EDIT OF TABLE
        Me.Validate(False)
        HpvScannedFiledLogBindingSource.EndEdit()

        Dim MyScanRow As tbStuHpvScanFileLogRow = Nothing
        Me.RISdataDataSet.tbStuHpvScanFileLog.Clear()
        Dim IsNew As Boolean = False

        If Not Me.RISdataDataSet.HpvScannedFiledLog.HasErrors Then
            If Validation.CheckForChanges(Me.RISdataDataSet.HpvScannedFiledLog) Then            
                For Each row As HpvScannedFiledLogRow In Me.RISdataDataSet.HpvScannedFiledLog.GetChanges.Rows
                    With row
                        MyScanRow = Nothing

                        If Not row.IsScanFileIDNull Then
                            Me.TbStuHpvScanFileLogTableAdapter.FillByID(Me.RISdataDataSet.tbStuHpvScanFileLog, row.ScanFileID)
                            If Me.RISdataDataSet.tbStuHpvScanFileLog.Rows.Count <> 0 Then
                                MyScanRow = Me.RISdataDataSet.tbStuHpvScanFileLog.Rows(0)
                                IsNew = False
                            End If
                        Else
                            MyScanRow = Me.RISdataDataSet.tbStuHpvScanFileLog.NewRow
                            IsNew = True
                        End If

                        MyScanRow.VisitID = row.VisitID
                        MyScanRow.FormCd = row.FormCd

                        If Not .IsResearcherCdNull Then
                            MyScanRow.ResearcherCd = .ResearcherCd
                        End If

                        If Not .IsScannedNull Then
                            MyScanRow.Scanned = .Scanned
                        End If

                        If Not .IsCopiedNull Then
                            MyScanRow.Copied = .Copied
                        End If

                        If Not .IsFiledNull Then
                            MyScanRow.Filed = .Filed
                        End If

                        If IsNew Then
                            Me.RISdataDataSet.tbStuHpvScanFileLog.Rows.Add(MyScanRow)
                        End If

                        If Not MyScanRow Is Nothing Then
                            Me.TbStuHpvScanFileLogTableAdapter.Update(Me.RISdataDataSet.tbStuHpvScanFileLog)
                        End If
                    End With
                Next
            End If        
        Else
            MessageBox.Show("Errors were found. Please correct errors and try again.", "Errors Detected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        FillLog()
    End Sub

    Private Sub btnSaveBloodLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBloodLog.Click
        SaveLog()
    End Sub

    Private Sub frmHPVScannedFiledLog_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Validation.CheckForChanges(Me.RISdataDataSet.HpvScannedFiledLog) Then
            If MessageBox.Show("Changes detected, would you like to save?", "Changes Detected", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                Me.SaveLog()
            End If
        End If
    End Sub

    Private Sub frmHPVScannedFiledLog_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        vfrmHPVScannedFiledLog = Nothing
    End Sub

End Class