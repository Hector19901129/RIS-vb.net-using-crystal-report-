Imports System.Data.OleDb
Imports DAO
Imports System.IO

Module modAppSpecific1

    Friend Sub Fill_cboStudy(ByVal cbo As ComboBox)

        Try

            With cbo

                With .Items
                    .Clear()
                    .Add(New ValueDescriptionPair(0, "All patients"))
                    .Add("----------------------------------------------------------------------------------------------------")
                    .Add(New ValueDescriptionPair(-1, "HPV patients to follow up"))
                    .Add(New ValueDescriptionPair(-2, "HPV (DOB)"))
                End With

                Dim strSQL As String = "SELECT StudyCd, StudyDesc FROM tbStudy WHERE Active=-1"
                Dim conn As New OleDbConnection(strConn)
                Dim cmd As New OleDbCommand(strSQL, conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                With reader
                    If .HasRows Then
                        Do While .Read()
                            cbo.Items.Add(New ValueDescriptionPair(.Item(0), .Item(1)))
                            If .Item(1) = "HPV" Then
                                cbo.Items.Add(New ValueDescriptionPair(0, "----------------------------------------------------------------------------------------------------"))
                            End If
                        Loop
                    End If
                    .Close()
                End With
                conn.Close()

                .MaxDropDownItems = .Items.Count

            End With

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub ShowLvwEditButtons(ByVal lvw As ListView, ByVal btnEdit As Button, ByVal btnDel As Button)
        btnEdit.Enabled = lvw.Items.Count > 0
        btnDel.Enabled = lvw.Items.Count > 0
    End Sub

    Friend Sub PreviewReport(ByVal RebuildQuery As Boolean, _
                             ByVal strSQL As String, _
                             ByVal QueryName As String, _
                             ByVal ReportName As String, _
                             ByVal ReportTitle2 As String, _
                             Optional ByVal ReportTitle3 As String = "", _
                             Optional ByVal SortBy As String = "")

        'On Error GoTo errHandler

        Dim objAccess As Object
        'objAccess = CreateObject("Access.Application")
        ''Dim objAccess As Access.application
        ''Set objAccess = New Access.application

        Dim ReportMdb As String = appPath & "\Reports\RISreports.mdb"

        Cursor.Current = Cursors.WaitCursor

        If RebuildQuery = True Then
            Dim WS As Workspace, dbReports As Database, qdf As QueryDef

            'Open non-secured mdb
            'dbReports = objAccess.DBEngine.Workspaces(0).OpenDatabase(appPath & "\Reports\RISrpt.mdb")

            'Open secured mdb
            Dim DBEC As DAO.DBEngineClass = New DBEngineClass
            DBEC.SystemDB = appPath & "\Security\Wrkgrp_Sec.mdw"
            WS = DBEC.CreateWorkspace("", strAdminLoginID, strAdminPassword)
            dbReports = WS.OpenDatabase(ReportMdb)

            qdf = dbReports.QueryDefs(QueryName)
            qdf.SQL = strSQL
            qdf.Close()
            dbReports.Close()
            qdf = Nothing
            dbReports = Nothing

        End If

        'This replaces objAccess.OpenCurrentDatabase
        OpenDBWithPwd(ReportMdb)
        objAccess = GetObject(ReportMdb)

        Dim OutputFile As String
        OutputFile = appPath & "\Reports\" & ReportName & ".snp"
        'Delete the snapshot file first so Access won't ask if you want to replace the existing file.
        If Dir(OutputFile) <> "" Then Kill(OutputFile)
        With objAccess
            '.OpenCurrentDatabase(appPath & "\Reports\RISrpt.mdb")

            .DoCmd.OpenForm("frmReportTitle2")
            .Forms!frmReportTitle2.lblReportTitle2.Caption = ReportTitle2

            If ReportTitle3.Length > 0 Then
                .Forms!frmReportTitle2.lblReportTitle3.Caption = ReportTitle3
            End If

            If SortBy.Length > 0 Then
                .Forms!frmReportTitle2.lblSortBy.Caption = SortBy
            End If

            .DoCmd.OutputTo(3, ReportName, "Snapshot Format (*.snp)", OutputFile, False)
            .CloseCurrentDatabase()
            .quit()
        End With
        objAccess = Nothing

        Load_frmReport(OutputFile)

        Cursor.Current = Cursors.Default

ExitSub:
        Exit Sub

errHandler:
        MsgBox(Err.Description)
        Cursor.Current = Cursors.Default

    End Sub

    Public Sub OpenDBWithPwd(ByVal dbs As String)

        'On Error Resume Next
        On Error GoTo errHandler

        Dim AccessPath As String = "C:\Program Files\Microsoft Office\"
        Dim workgroup As String
        Dim user As String, Password As String
        Dim X

        Select Case Left(appPath, 1)
            Case "C", "E", "F"
                AccessPath = AccessPath & "\Office\MSACCESS.EXE"
            Case Else
                AccessPath = AccessPath & "\Office10\MSACCESS.EXE"
        End Select
        'AccessPath = SysCmd(acSysCmdAccessDir) & "\MSAccess.exe"

        workgroup = appPath & "\Security\Wrkgrp_Sec.mdw "
        user = strAdminLoginID
        Password = strAdminPassword

        X = Shell(AccessPath & " " & Chr(34) & dbs & Chr(34) & " /nostartup /user " & user & _
        " /pwd " & Password & " /wrkgrp " & Chr(34) & workgroup & Chr(34), vbMinimizedFocus)

ExitSub:
        Exit Sub

errHandler:
        MsgBox(Err.Description)

    End Sub

    Friend Sub Load_frmReport(ByVal SnapshotFile As String)

        Try

            If vfrmReport Is Nothing Then 'If not already loaded
                vfrmReport = New frmReport
            End If

            With vfrmReport
                .MdiParent = vfrmMDI
                .Show()
                '.WebBrowser.Navigate(App_Path() & "\" & SnapshotFile) 'DeltekNotes.htm rptBillingReport.snp
                .WebBrowser.Navigate(SnapshotFile)
                .Focus()
            End With

            vfrmReport.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Function PasswordVerified(ByVal ID As String, ByVal Password As String) As Boolean

        PasswordVerified = True
        Try
            Dim strCnnPV As String
            'If (Path.GetExtension(appPath).ToLower().Trim() = ".xls" And Environment.Is64BitOperatingSystem = False) Then


            '    strCnnPV = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + appPath + ";User ID=" & ID & ";Password=" & Password & ";Extended Properties="" Excel 8.0;HDR=Yes;IMEX=2"""
            'Else
            '    strCnnPV = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + ";User ID=" & ID & ";Password=" & Password & ";Extended Properties=""Excel 12.0;HDR=Yes;IMEX=2"""
            'End If
            ' strCnnPV= "Provider=Microsoft.Jet.OLEDB.4.0;Mode=Share Deny None;Data Source={0};user id=Admin;password=;", gisdbPath

            strCnnPV = "Provider=Microsoft.Jet.OLEDB.4.0; " & _
                       "Jet OLEDB:Database Password=RIS;" & _
                       "Jet OLEDB:System Database=" & appPath & "\Security\Wrkgrp_Sec.mdw; " & _
                       "data source=" & appPath & "\Security\Security.mdb; " & _
                        "User ID=" & ID & "; " & _
                       "Password=" & Password & ";"

            Dim conn As New OleDbConnection(strCnnPV)
            conn.Open()
            conn.Close()
        Catch ex As System.Exception
            strLoginErr = ex.Message
            PasswordVerified = False
        End Try

    End Function

End Module
