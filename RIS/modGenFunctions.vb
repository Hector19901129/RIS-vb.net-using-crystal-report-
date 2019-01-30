Imports System.Data.OleDb

Module modGenFunctions

    Public Function App_Path() As String
        'Return System.AppDomain.CurrentDomain.BaseDirectory()
        Return Application.StartupPath
        'Return "L:\HPVResearch\RIS\bin"
    End Function

    Friend Function LookUp(ByVal strColumn As String, ByVal strFrom As String, ByVal strWhere As String) As String

        Try

            LookUp = ""

            Dim strSQL As String = "SELECT " & strColumn & " AS COLUMN1 FROM " & strFrom & " WHERE " & strWhere

            Dim conn As New OleDbConnection(strConn)
            Dim cmd As New OleDbCommand(strSQL, conn)
            conn.Open()
            Return cmd.ExecuteScalar
            conn.Close()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Friend Function DataExists(ByVal strTable As String, ByVal strWhere As String) As Boolean

        Try

            DataExists = False

            Dim strSQL As String = "SELECT COUNT(*) AS FREQ FROM " & strTable & " " & strWhere

            'Console.WriteLine(strSQL)
            Dim conn As New OleDbConnection(strConn)
            Dim cmd As New OleDbCommand(strSQL, conn)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        If .Item(0) > 0 Then
                            DataExists = True
                        End If
                    Loop
                End If
                .Close()
            End With
            conn.Close()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Friend Function LvwMax(ByVal lvw As ListView, ByVal varType As String, Optional ByVal SubItem As Short = 0) As String

        Dim i As Integer
        'If varType = "date" Then
        Dim ItemText As Date, ItemText2 As Date, temp As Date
        'End If

        With lvw

            If SubItem > 0 Then
                temp = .Items(0).SubItems(SubItem).Text
            Else
                temp = .Items(0).Text
            End If

            For i = 1 To .Items.Count - 1
                If SubItem > 0 Then
                    ItemText = .Items(i).SubItems(SubItem).Text
                Else
                    ItemText = .Items(i).Text
                End If
                If temp < ItemText Then
                    temp = ItemText
                End If
            Next i

        End With

        LvwMax = temp

    End Function

    Friend Function LvwItems(ByVal lvw As ListView, Optional ByVal SubItem As Short = 0, Optional ByVal AddQuotes As Boolean = True) As String

        Dim i As Integer, ItemText As String
        With lvw

            For i = 0 To .Items.Count - 1
                If SubItem > 0 Then
                    ItemText = Trim(.Items(i).SubItems(SubItem).Text)
                Else
                    ItemText = Trim(.Items(i).Text)
                End If
                If Len(ItemText) > 0 Then
                    If Len(LvwItems) > 0 Then
                        If AddQuotes Then
                            LvwItems = LvwItems & ", '" & ItemText & "'"
                        Else
                            LvwItems = LvwItems & ", " & ItemText
                        End If
                    Else
                        If AddQuotes Then
                            LvwItems = "'" & ItemText & "'"  'Don't put comma if last one
                        Else
                            LvwItems = ItemText
                        End If
                    End If
                End If
            Next i

        End With

    End Function

    Friend Function LvwNoItemsChecked(ByVal lvw As ListView) As Boolean

        LvwNoItemsChecked = True

        If lvw.Items.Count = 0 Then Exit Function

        For Each itm As ListViewItem In lvw.Items
            If itm.Checked = True Then
                LvwNoItemsChecked = False
                Exit Function
            End If
        Next

    End Function

    Friend Function ValidEmailAddress(ByVal emailAddress As String) As Boolean

        'MsgBox(Len(Trim(emailAddress))) Trim(emailAddress).Length

        'If (Trim(emailAddress)).Length = 0 Then
            'MsgBox("Email address is required.", MsgBoxStyle.Information)
            'Return False
        'End If

        emailAddress = emailAddress.Trim

        If (emailAddress Like "*?@?*.?*") And _
          Not (emailAddress Like "*@*@*") And _
           Not (emailAddress Like "*..*") And _
            Not (emailAddress Like "* *") And _
           Not (emailAddress Like "*.") Then
            Return True
        Else
            MsgBox("Email address must have valid email address format." + ControlChars.Cr + _
                       "For example 'someone@example.com'", MsgBoxStyle.Information)
            Return False
        End If

    End Function

    Friend Function GetNumberPart(ByVal MixedDataString As String) As String
        GetNumberPart = ""
        Dim subString As String
        For i As Short = 1 To MixedDataString.Length
            subString = Mid(MixedDataString, i, 1)
            If IsNumeric(subString) Then
                GetNumberPart += subString
            End If
        Next
    End Function

    Friend Function FormatPhoneNumber(ByVal PhoneNumber As String) As String
        'Use this function to format the phone # 
        'so that its format matches the mask of the control mskPhone for user edit.
        '800-123-5678x12345
        '123 456 7890 12345
        '''''Old 
        'FormatPhoneNumber = "___-___-____x_____"
        'If PhoneNumber.Length = 0 Then Exit Function
        'For i As Byte = 1 To PhoneNumber.Length
        'Select Case i
        'Case Is <= 3
        'Mid(FormatPhoneNumber, i, 1) = Mid(PhoneNumber, i, 1)
        'Case 4 To 6
        'Mid(FormatPhoneNumber, i + 1, 1) = Mid(PhoneNumber, i, 1)
        'Case 7 To 10
        'Mid(FormatPhoneNumber, i + 2, 1) = Mid(PhoneNumber, i, 1)
        'Case 11 To 15
        'Mid(FormatPhoneNumber, i + 3, 1) = Mid(PhoneNumber, i, 1)
        'Case Is > 15
        'Exit Function
        'End Select
        'Next

        FormatPhoneNumber = "___-___-____x_____"
        If PhoneNumber.Length = 0 Then Exit Function
        'Position:     123456789012345678
        'PhoneNumber:  ___-___-____x_____
        For i As Byte = 1 To PhoneNumber.Length
            Select Case i
                Case 1 To 3, 5 To 7, 9 To 12, 14 To 18
                    If IsNumeric(Mid(PhoneNumber, i, 1)) Then
                        Mid(FormatPhoneNumber, i, 1) = Mid(PhoneNumber, i, 1)
                    End If
            End Select
        Next
    End Function


    Friend Function FormatZipCode(ByVal Zip As String) As String
        FormatZipCode = "_____-____"
        If Zip.Length = 0 Then Exit Function
        For i As Byte = 1 To Zip.Length
            Select Case i
                Case Is <= 5
                    Mid(FormatZipCode, i, 1) = Mid(Zip, i, 1)
                Case 6 To 9
                    Mid(FormatZipCode, i + 1, 1) = Mid(Zip, i, 1)
                Case Is > 9
                    Exit Function
            End Select
        Next
    End Function

    Friend Function HandleNull(ByVal s As Object) As String
        'Convert a null string field to an empty string when a null value is encountered.
        If s Is System.DBNull.Value Then
            Return String.Empty
        Else
            Return Convert.ToString(s)
        End If
    End Function

    Friend Function FormatString(ByVal StringToFormat As String, ByVal TheFormat As String) As String

        If Len(Trim((StringToFormat))) > 0 Then
            Return CLng(Replace(StringToFormat, " ", "")).ToString(TheFormat) 'must remove spaces
        Else
            Return String.Empty
        End If

    End Function

End Module
