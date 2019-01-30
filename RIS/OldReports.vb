Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb
Public Class OldReports
    Dim FormActivated As Boolean = False

    Private Sub OldReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Fill_lstReports()

            Me.dtpVisitDate1.Value = Today.AddDays(1)
            Me.dtpVisitDate2.MinDate = Me.dtpVisitDate1.Value
            Me.dtpVisitDate2.Value = Today.AddDays(2)
            Fill_cboRptReceptionListSortBy()

            Me.dtsDOB1.Text = "01/01/" & Today.Year - 15
            Me.dtsDOB2.MinDate = Me.dtsDOB1.Value
            Me.dtsDOB2.Text = "01/01/" & Today.Year - 14

            Fill_cboRptHpvPatByDOBSortBy()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmReportList_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub

    Private Sub frmReportList_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmReportList = Nothing
    End Sub

    Private Sub ResizePanels()
        Me.Panel1.Width = Me.Width * 0.5
        Me.lstReports.Width = Me.Panel1.Width - 5
        Me.Panel2.Width = Me.Width * 0.3
        Me.grpRptReceptionList.Width = Me.Panel2.Width - 5
        Me.Panel3.Width = Me.Width * 0.2
        Me.btnPreview.Width = Me.Panel3.Width - 40
    End Sub

    Private Sub frmReportList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ResizePanels()
    End Sub

    Private Sub Fill_lstReports()

        With Me.lstReports
            .Items.Add(" 1. Reception List")
            .Items.Add(" 2. HPV Patients to Follow-Up")
            .Items.Add(" 3. HPV Patients Coming Up for a Visit")
            .Items.Add(" 4. HPV Patient Visit Overdue Report")
            .Items.Add(" 5. HPV Patients by Date of Birth")
            .SelectedIndex = 0
        End With

    End Sub

    Private Sub Fill_cboRptReceptionListSortBy()

        With Me.cboRptReceptionListSortBy
            .Items.Add(New ValueDescriptionPair("PatName", "Patient Name"))
            .Items.Add(New ValueDescriptionPair("SubjectID", "Subject ID"))
            .Items.Add(New ValueDescriptionPair("MRN", "MRN"))
            .Items.Add(New ValueDescriptionPair("VisitTimeToSort", "Time of Visit"))
            .Items.Add(New ValueDescriptionPair("VisitNumDescShort", "Visit Number"))
            .SelectedIndex = 0
        End With

    End Sub

    Private Sub Fill_cboRptHpvPatByDOBSortBy()

        With Me.cboRptHpvPatByDOBSortBy
            .Items.Add(New ValueDescriptionPair("PatName", "Patient Name"))
            .Items.Add(New ValueDescriptionPair("MRN", "MRN"))
            .Items.Add(New ValueDescriptionPair("SubjectID", "Subject ID"))
            .Items.Add(New ValueDescriptionPair("DateofBirth", "Date Of Birth"))
            .SelectedIndex = 0
        End With

    End Sub

    Private Sub Load_rptReceptionList()

        Try
            Dim strSQL As String = _
            "SELECT * FROM tbStuHpvPatVisit " & _
            "WHERE ApptStatusCd=2 AND VisitDate BETWEEN #" & Me.dtpVisitDate1.Value & "# AND #" & Me.dtpVisitDate2.Value & "#"  'Completed=0

            Dim strReportTitle2 As String = _
              "All Visits Scheduled in CERNER for " & Format(Me.dtpVisitDate1.Value, "MM/dd/yyyy") & " - " & Format(Me.dtpVisitDate2.Value, "MM/dd/yyyy") & _
              ", Sorted by " & cboRptReceptionListSortBy.Text
            Dim strSortBy As String = CType(cboRptReceptionListSortBy.SelectedItem, ValueDescriptionPair).Value

            PreviewReport(True, strSQL, "qryHpvReceptionList1", "rptHpvReceptionList", strReportTitle2, , strSortBy)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Load_rptPatToFU()

        Try
            Dim strSQL As String = _
            "SELECT * FROM tbStuHpvPatVisit " & _
            "WHERE ApptStatusCd IN (1,3) AND VisitDate BETWEEN #" & Me.dtpVisitDate1.Value & "# AND #" & Me.dtpVisitDate2.Value & "#"  'Completed=0

            Dim strReportTitle2 As String = _
              "Date of Visit: " & Format(Me.dtpVisitDate1.Value, "MM/dd/yyyy") & " - " & Format(Me.dtpVisitDate2.Value, "MM/dd/yyyy") & _
              ", Sorted by " & cboRptReceptionListSortBy.Text
            Dim strSortBy As String = CType(cboRptReceptionListSortBy.SelectedItem, ValueDescriptionPair).Value

            PreviewReport(True, strSQL, "qryHpvPatToFU1", "rptHpvPatToFU", strReportTitle2, , strSortBy)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Load_rptHpvPatByDOB()

        Try

            Dim strDateRange As String = ""
            Dim strTitleDateRange As String
            If Me.dtsDOB1.Checked = True And Me.dtsDOB2.Checked = False Then
                strDateRange = " DateOfBirth >= #" & _
                  Me.dtsDOB1.Value & "# "
                strTitleDateRange = " with DOB >= " & Me.dtsDOB1.Value
            ElseIf Me.dtsDOB1.Checked = False And Me.dtsDOB2.Checked = True Then
                strDateRange = " DateOfBirth <= #" & _
                  Me.dtsDOB2.Value & "# "
                strTitleDateRange = " with DOB <= " & Me.dtsDOB2.Value
            ElseIf Me.dtsDOB1.Checked = True And Me.dtsDOB2.Checked = True Then
                strDateRange = " DateOfBirth BETWEEN #" & _
                  Me.dtsDOB1.Value & "# AND #" & Me.dtsDOB2.Value & "# "
                strTitleDateRange = " with DOB between " & Me.dtsDOB1.Value & " and " & Me.dtsDOB2.Value
            End If

            Dim strMOB As String = "Month([DateOfBirth])=" & Me.cboMOB.SelectedIndex + 1

            Dim strSQL As String = _
            "SELECT PatientID, LastName, FirstName, MRN, DateOfBirth " & _
            "FROM tbPatient "

            Dim strReportTitle2 As String = "All Patients"
            Dim strTitleMonth As String = " Born in the Month of " & Me.cboMOB.Text
            If strDateRange.Length > 0 And Me.cboMOB.Text.Length = 0 Then
                strSQL = strSQL & " WHERE " & strDateRange
                strReportTitle2 = strReportTitle2 & strTitleDateRange
            ElseIf strDateRange.Length = 0 And Me.cboMOB.Text.Length > 0 Then
                strSQL = strSQL & "WHERE " & strMOB
                strReportTitle2 = strReportTitle2 & strTitleMonth
            ElseIf strDateRange.Length > 0 And Me.cboMOB.Text.Length > 0 Then
                strSQL = strSQL & "WHERE (" & strDateRange & ") AND " & strMOB
                strReportTitle2 = strReportTitle2 & strTitleDateRange & " and" & strTitleMonth
            End If

            'MsgBox(strSQL)
            'Exit Sub

            strReportTitle2 = strReportTitle2 & ", Sorted by " & Me.cboRptHpvPatByDOBSortBy.Text
            Dim strSortBy As String = CType(Me.cboRptHpvPatByDOBSortBy.SelectedItem, ValueDescriptionPair).Value

            PreviewReport(True, strSQL, "qryHpvPatByDOB1", "rptHpvPatByDOB", strReportTitle2, , strSortBy)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Load_rptHpvPatComing()

        Try
            Dim strSQL As String = _
            "SELECT * FROM qryHpvPatComing5_SchedAndProj " & _
            "WHERE VisitDate BETWEEN #" & Me.dtpVisitDate1.Value & "# AND #" & Me.dtpVisitDate2.Value & "#"

            Dim strReportTitle2 As String = _
              "Date of Visit: " & Format(Me.dtpVisitDate1.Value, "MM/dd/yyyy") & " - " & Format(Me.dtpVisitDate2.Value, "MM/dd/yyyy") & _
              ", Sorted by " & cboRptReceptionListSortBy.Text
            Dim strSortBy As String = CType(cboRptReceptionListSortBy.SelectedItem, ValueDescriptionPair).Value

            PreviewReport(True, strSQL, "qryHpvPatComing6_SchedAndProj", "rptHpvPatComing", strReportTitle2, , strSortBy)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Load_rptHpvPatVstOverdue()

        Try

            PreviewReport(False, "", "", "rptHpvPatVstOverdue", "")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub temp()
        Dim strMOB As String
        Select Case LCase(Me.cboMOB.Text)
            Case "january"
                strMOB = strMOB & "1"
            Case "february"
                strMOB = strMOB & "2"
            Case "march"
                strMOB = strMOB & "3"
            Case "april"
                strMOB = strMOB & "4"
            Case "may"
                strMOB = strMOB & "5"
            Case "june"
                strMOB = strMOB & "6"
            Case "july"
                strMOB = strMOB & "7"
            Case "august"
                strMOB = strMOB & "8"
            Case "september"
                strMOB = strMOB & "9"
            Case "october"
                strMOB = strMOB & "10"
            Case "november"
                strMOB = strMOB & "11"
            Case "december"
                strMOB = strMOB & "12"
        End Select
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case vb.Right(Me.lstReports.SelectedItem, Len(Me.lstReports.SelectedItem) - 4)
            Case "Reception List"
                Load_rptReceptionList()
            Case "HPV Patients to Follow-Up"
                Load_rptPatToFU()
            Case "HPV Patients by Date of Birth"
                Load_rptHpvPatByDOB()
            Case "HPV Patients Coming Up for a Visit"
                Load_rptHpvPatComing()
            Case "HPV Patient Visit Overdue Report"
                Load_rptHpvPatVstOverdue()
        End Select
    End Sub

    Private Sub lstReports_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'MsgBox(Me.lstReports.SelectedItem)
        Me.grpRptReceptionList.Visible = False
        Me.grpRptHpvPatByDOB.Visible = False
        Select Case vb.Right(Me.lstReports.SelectedItem, Len(Me.lstReports.SelectedItem) - 4)
            Case "Reception List"
                Me.grpRptReceptionList.Visible = True
            Case "HPV Patients to Follow-Up"
                Me.grpRptReceptionList.Visible = True
            Case "HPV Patients by Date of Birth"
                Me.grpRptHpvPatByDOB.Visible = True
            Case "HPV Patients Coming Up for a Visit"
                Me.grpRptReceptionList.Visible = True
            Case "HPV Patient Visit Overdue Report"
        End Select
    End Sub

    Private Sub dtsDOB1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.dtsDOB2.MinDate = Me.dtsDOB1.Value
    End Sub

    Private Sub dtpVisitDate1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.dtpVisitDate2.MinDate = Me.dtpVisitDate1.Value
    End Sub
End Class