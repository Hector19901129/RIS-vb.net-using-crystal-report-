Public Class frmSharePointLogin


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim CommandLine As String = Me.txtInputString.Text & Me.GetLoginString
        Dim p As New Process
        p.Start(Me.txtPath.Text, CommandLine)
        Me.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Function GetLoginString() As String
        Dim UserName As String = String.Empty
        Dim PassWord As String = String.Empty

        If Not Me.UsernameTextBox.Text = String.Empty Then
            UserName = "/UserName:" & Me.UsernameTextBox.Text
        End If

        If Not Me.PasswordTextBox.Text = String.Empty Then
            PassWord = "/PassWord:" & Me.PasswordTextBox.Text
        End If

        Return " " & UserName & " " & PassWord

    End Function

    Private Sub CredentialsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged, UsernameTextBox.TextChanged
        'Dim UserName As String
        'Dim PassWord As String

        'UserName = Me.UsernameTextBox.Text
        'PassWord = Me.PasswordTextBox.Text

        'Dim strUser As String
        'Dim strPW As String

        'strUser = FindString(OptionType.User)
        'strPW = FindString(OptionType.Password)

        'If (UserName <> String.Empty And strUser <> String.Empty) Then
        '    Me.txtInputString.Text = Me.txtInputString.Text.Replace(strUser, " /User:" & UserName & " ")
        'ElseIf strUser = String.Empty And UserName <> String.Empty Then
        '    Me.txtInputString.Text = Me.txtInputString.Text & " /User:" & UserName & " "
        'ElseIf strUser <> String.Empty And UserName = String.Empty Then
        '    Me.txtInputString.Text = Me.txtInputString.Text.Replace(strUser, String.Empty)
        'End If

        'If (PassWord <> String.Empty And strPW <> String.Empty) Then
        '    Me.txtInputString.Text = Me.txtInputString.Text.Replace(strUser, " /Password:" & PassWord & " ")
        'ElseIf strPW = String.Empty And PassWord <> String.Empty Then
        '    Me.txtInputString.Text = Me.txtInputString.Text & " /Password:" & PassWord & " "
        'ElseIf strPW <> String.Empty And PassWord = String.Empty Then
        '    Me.txtInputString.Text = Me.txtInputString.Text.Replace(strPW, String.Empty)
        'End If

    End Sub

    Private Sub frmSharePointLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtInputString.Text = "<database file name>.mdb 'https://172.16.20.24/sites/HPV/Shared Documents/DATA' /o"

    End Sub

    Private Function FindString(ByVal OptionType As OptionType) As String
        'Dim strFound As String = String.Empty
        'Dim strCurrent As String = Me.txtInputString.Text
        'Dim strSearch As String = String.Empty

        'If Not String.IsNullOrEmpty(strCurrent) Then
        '    Select Case OptionType
        '        Case RIS.OptionType.User
        '            If strCurrent.Contains(" /User:") Then
        '                strSearch = " /User:"
        '            End If
        '        Case RIS.OptionType.Password
        '            If strCurrent.Contains(" /Password:") Then
        '                strSearch = " /Password:"
        '            End If
        '    End Select
        'End If

        'If Not String.IsNullOrEmpty(strSearch) Then
        '    Dim StartIndex As Integer = strCurrent.IndexOf(strSearch)
        '    Dim EndIndex As Integer = strCurrent.IndexOf(" ", StartIndex)

        '    strFound = strCurrent.Substring(StartIndex, EndIndex - StartIndex)

        'End If

        'Return strFound

    End Function


End Class


Public Enum OptionType
    User
    Password
End Enum

