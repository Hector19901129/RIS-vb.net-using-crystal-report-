Module modGenernal2

    Public Structure struDescValuePair
        Private Desc As String, Value As Object
        Public Sub New(ByVal NewDesc As String, ByVal NewValue As Object)
            Desc = NewDesc
            Value = NewValue
        End Sub
        Public ReadOnly Property getDesc() As String
            Get
                Return Desc
            End Get
        End Property
        Public ReadOnly Property getValue() As Byte
            Get
                Return Value
            End Get
        End Property
    End Structure

    Public Class ValueDescriptionPair
        Public Value As Object, Description As String
        Public Sub New(ByVal NewValue As Object, ByVal NewDescription As String)
            Value = NewValue
            Description = NewDescription
        End Sub
        Public Overrides Function ToString() As String
            Return Description
        End Function
    End Class

    Public Class ListViewComparer
        Implements IComparer
        Private m_ColumnNumber As Integer
        Private m_SortOrder As SortOrder

        Public Sub New(ByVal column_number As Integer, ByVal sort_order As SortOrder)
            m_ColumnNumber = column_number
            m_SortOrder = sort_order
        End Sub

        ' Compare the items in the appropriate column
        ' for objects x and y.
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim item_x As ListViewItem = DirectCast(x, ListViewItem)
            Dim item_y As ListViewItem = DirectCast(y, ListViewItem)

            ' Get the sub-item values.
            Dim string_x As String
            If item_x.SubItems.Count <= m_ColumnNumber Then
                string_x = ""
            Else
                string_x = item_x.SubItems(m_ColumnNumber).Text
            End If

            Dim string_y As String
            If item_y.SubItems.Count <= m_ColumnNumber Then
                string_y = ""
            Else
                string_y = item_y.SubItems(m_ColumnNumber).Text
            End If

            ' Compare them.
            If m_SortOrder = SortOrder.Ascending Then
                Return String.Compare(string_x, string_y)
            Else
                Return String.Compare(string_y, string_x)
            End If
        End Function
    End Class

    Friend Class LvwSortString

        Implements IComparer
        Private mSortColumn As Integer
        Private mSortOrder As SortOrder

        Friend Sub New(ByVal sortColumn As Integer, ByVal sortOrder As SortOrder)
            mSortColumn = sortColumn
            mSortOrder = sortOrder
        End Sub

        Friend Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

            Dim Result As Integer
            Dim ItemX As ListViewItem
            Dim ItemY As ListViewItem

            ItemX = CType(x, ListViewItem)
            ItemY = CType(y, ListViewItem)

            On Error Resume Next
            If mSortColumn = 0 Then
                Result = ItemX.Text.CompareTo(ItemY.Text)
            Else
                Result = ItemX.SubItems(mSortColumn).Text.CompareTo(ItemY.SubItems(mSortColumn).Text)
            End If

            If mSortOrder = SortOrder.Descending Then
                Result = -Result
            End If

            Return Result

        End Function

    End Class

    Friend Class LvwSortDate

        Implements IComparer
        Private mSortColumn As Integer
        Private mSortOrder As SortOrder

        Friend Sub New(ByVal sortColumn As Integer, ByVal sortOrder As SortOrder)
            mSortColumn = sortColumn
            mSortOrder = sortOrder
        End Sub

        Friend Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

            Dim Result As Integer
            Dim ItemX As ListViewItem
            Dim ItemY As ListViewItem

            ItemX = CType(x, ListViewItem)
            ItemY = CType(y, ListViewItem)

            On Error Resume Next
            If mSortColumn = 0 Then
                Result = DateTime.Compare(CType(ItemX.Text, DateTime), CType(ItemY.Text, DateTime))
            Else
                Result = DateTime.Compare(CType(ItemX.SubItems(mSortColumn).Text, DateTime), CType(ItemY.SubItems(mSortColumn).Text, DateTime))
            End If

            If mSortOrder = SortOrder.Descending Then
                Result = -Result
            End If

            Return Result

        End Function

    End Class

    Friend Class LvwSortNumeric

        Implements IComparer
        Private mSortColumn As Integer
        Private mSortOrder As SortOrder

        Friend Sub New(ByVal sortColumn As Integer, ByVal sortOrder As SortOrder)
            mSortColumn = sortColumn
            mSortOrder = sortOrder
        End Sub

        Friend Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

            Dim Result As Integer
            Dim ItemX As ListViewItem
            Dim ItemY As ListViewItem

            ItemX = CType(x, ListViewItem)
            ItemY = CType(y, ListViewItem)

            On Error Resume Next
            If mSortColumn = 0 Then
                Result = Decimal.Compare(CType(ItemX.Text, Decimal), CType(ItemY.Text, Decimal))
            Else
                Result = Decimal.Compare(CType(ItemX.SubItems(mSortColumn).Text, Decimal), CType(ItemY.SubItems(mSortColumn).Text, Decimal))
            End If

            If mSortOrder = SortOrder.Descending Then
                Result = -Result
            End If

            Return Result

        End Function

    End Class

    Friend Sub SortLvw(ByVal lvw As ListView, ByVal col As Short, Optional ByVal ChangeSortingColumnText As Boolean = True)
        'MsgBox(e.Column.ToString)
        ' Get the new sorting column.
        Dim new_sorting_column As ColumnHeader = lvw.Columns(col)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder

        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("^ ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            If ChangeSortingColumnText Then
                ' Remove the old sort indicator.
                m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
            End If
        End If

        If ChangeSortingColumnText Then
            ' Display the new sort order.
            m_SortingColumn = new_sorting_column
            If sort_order = SortOrder.Ascending Then
                m_SortingColumn.Text = "^ " & m_SortingColumn.Text
            Else
                m_SortingColumn.Text = "v " & m_SortingColumn.Text
            End If
        End If

        ' Create a comparer.
        Select Case new_sorting_column.TextAlign
            Case HorizontalAlignment.Left   'String
                lvw.ListViewItemSorter = New LvwSortString(col, sort_order)
            Case HorizontalAlignment.Center 'Date
                lvw.ListViewItemSorter = New LvwSortDate(col, sort_order)
            Case HorizontalAlignment.Right  'Numeric
                'MsgBox(sort_order)
                lvw.ListViewItemSorter = New LvwSortNumeric(col, sort_order)
        End Select

        ' Sort.
        lvw.Sort()
    End Sub

End Module
