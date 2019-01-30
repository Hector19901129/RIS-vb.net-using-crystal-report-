Module modClass1

    Public Class ListViewOrder
        Private Declare Function ListViewColumnOrder Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal Msg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
        Public Shared Sub SetColumnOrder(ByVal ListViewToReorder As ListView, ByVal SortOrder As Integer())
            If SortOrder.Length < 1 Then Exit Sub
            If SortOrder.Length > ListViewToReorder.Columns.Count Then Exit Sub
            Dim liSetColumnOrderArray As Integer = (&H1000S + 58)
            Dim liSuccess As Integer
            liSuccess = ListViewColumnOrder(ListViewToReorder.Handle.ToInt32, liSetColumnOrderArray, SortOrder.Length, SortOrder(0))
            If Not liSuccess.Equals(0) Then
                ListViewToReorder.Refresh()
            End If
        End Sub
        Public Shared Function GetColumnOrder(ByVal ListViewToReorder As ListView) As Integer()
            Dim liGetColumnOrderArray As Integer = (&H1000S + 59)
            Dim liSuccess As Integer
            Dim liSortOrder As Integer()
            ReDim liSortOrder(ListViewToReorder.Columns.Count - 1)
            liSuccess = ListViewColumnOrder(ListViewToReorder.Handle.ToInt32, liGetColumnOrderArray, liSortOrder.Length, liSortOrder(0))
            If Not liSuccess.Equals(0) Then
                Return liSortOrder
            Else
                Throw New Exception("Could not get the column order for listview " & ListViewToReorder.Name)
            End If
        End Function

End Class

    Public Class ListViewWidth
        Public Shared Sub SetColumnWidth(ByVal ListViewToResize As ListView, ByVal WidthSizes As Integer())
            Dim liIdx As Integer
            For liIdx = 0 To ListViewToResize.Columns.Count - 1
                With CType(ListViewToResize.Columns(liIdx), ColumnHeader)
                    Try
                        .Width = WidthSizes(liIdx)
                    Catch eException As NullReferenceException ' Width Sizes not Available
                    End Try
                End With
            Next
            ListViewToResize.Refresh()
        End Sub
        Public Shared Function GetColumnWidth(ByVal ListViewToResize As ListView) As Integer()
            Dim liColumnWidth As Integer()
            Dim liIdx As Integer
            ReDim liColumnWidth(ListViewToResize.Columns.Count - 1)
            For liIdx = 0 To ListViewToResize.Columns.Count - 1
                Try
                    With CType(ListViewToResize.Columns(liIdx), ColumnHeader)
                        liColumnWidth(liIdx) = .Width
                    End With
                Catch eException As Exception
                End Try
            Next
            Return liColumnWidth
        End Function
    End Class



End Module
