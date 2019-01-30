
Imports System.Text.RegularExpressions

Public Class Validation


    Public Shared Function CheckForChanges(ByVal DT As DataTable) As Boolean
        If DT IsNot Nothing Then
            For Each row As DataRow In DT.Rows
                If CheckForChanges(row, DT.Columns.Count) = True Then
                    Return True
                End If
            Next
        End If



    End Function

    Public Shared Function CheckForChanges(ByVal Row As DataRow, ByVal ColumnCount As Integer) As Boolean
        If Row IsNot Nothing Then
            For i As Integer = 0 To ColumnCount - 1
                If TestRow(Row, i) Then
                    Return True
                End If
            Next
        End If


    End Function

    Public Shared Function CheckForChanges(ByVal ColumnIndex As Integer, ByVal DataRow As DataRow) As Boolean
        TestRow(DataRow, ColumnIndex)

    End Function

    Private Shared Function TestRow(ByVal Row As DataRow, ByVal ColumnIndex As Integer) As Boolean
        If Row.RowState = DataRowState.Deleted Then
            Return False

        End If
        If Row.RowState = DataRowState.Added Or Row.RowState = DataRowState.Detached Then
            Return True
        End If
        If Not Convert.IsDBNull(Row(ColumnIndex, DataRowVersion.Current)) And Not Convert.IsDBNull(Row(ColumnIndex, DataRowVersion.Original)) Then
            If Row(ColumnIndex, DataRowVersion.Current) <> Row(ColumnIndex, DataRowVersion.Original) Then
                Return True
            End If
        Else
            If Not Convert.IsDBNull(Row(ColumnIndex, DataRowVersion.Current)) And Convert.IsDBNull(Row(ColumnIndex, DataRowVersion.Original)) Then
                Return True
            End If

            If Convert.IsDBNull(Row(ColumnIndex, DataRowVersion.Current)) And Not Convert.IsDBNull(Row(ColumnIndex, DataRowVersion.Original)) Then

                Return True
            End If


        End If


    End Function

    Public Shared Function CheckForChanges(ByVal Row As DataRow, ByVal ColumnName As String) As Boolean
        If Row.RowState = DataRowState.Deleted Then
            Return False

        End If
        If Row.RowState = DataRowState.Added Or Row.RowState = DataRowState.Detached Then
            Return True
        End If
        If Not Convert.IsDBNull(Row(ColumnName, DataRowVersion.Current)) And Not Convert.IsDBNull(Row(ColumnName, DataRowVersion.Original)) Then
            If Row(ColumnName, DataRowVersion.Current) <> Row(ColumnName, DataRowVersion.Original) Then
                Return True
            End If
        End If

    End Function

    Public Shared Function HasValue(ByVal Value As Object) As Boolean
        If Not String.IsNullOrEmpty(Value.ToString()) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function IsPositiveNumber(ByVal Value As Object) As Boolean
        If IsNumeric(Value) AndAlso Value >= 0 Then
            Return True
        Else

            Return False
        End If
    End Function

    Public Shared Function IsTime(ByVal Value As String) As Boolean
        
        Dim Formats(2) As String
        Formats(0) = "HH:mm"
        Formats(1) = "H:mm"
        'Formats(2) = "HH:m"
        Return DateTime.TryParseExact(Value, Formats, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.AllowWhiteSpaces, New DateTime)

    End Function

End Class
