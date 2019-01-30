Imports System.Data.OleDb

Module modGenernal1

    Friend Sub Fill_lvw(ByVal lvw As ListView, ByVal strSQL As String, _
                        Optional ByVal ClearLvw As Boolean = True, _
                        Optional ByVal ShowTotal As Boolean = True, _
                        Optional ByVal CheckIt As Boolean = False)

        'Console.WriteLine(strSQL)

        Try

            Cursor.Current = Cursors.WaitCursor

            If ClearLvw Then lvw.Items.Clear()

            Dim conn As New OleDbConnection(strConn)
            Dim cmd As New OleDbCommand(strSQL, conn)

            conn.Open()

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            With reader
                If .HasRows Then
                    Do While .Read()
                        Dim item As New ListViewItem
                        'item.Text = reader.GetDateTime(0).ToShortDateString & " - " & reader.GetDateTime(1).ToShortDateString
                        If Not IsDBNull(.Item(0)) Then
                            item.Text = .Item(0)
                        Else
                            item.Text = ""
                        End If
                        If CheckIt Then item.Checked = True
                        'Console.WriteLine(item.Text)
                        For i As Short = 1 To .FieldCount - 1

                            'Console.WriteLine(reader.GetName(i) & ":" & reader.GetFieldType(i).FullName)
                            'Console.WriteLine("Press Enter to finish.")
                            'Console.ReadLine()

                            'INTENSITY:              System.Double
                            'ACT_DESC:               System.String
                            'ACTIVE:                 System.String
                            'ACT_DATE:               System.DateTime
                            'NOTES:                  System.String
                            'LAST_EDIT_USER_ID:      System.String
                            'LAST_EDIT_DATE:         System.DateTime
                            'ACT_KEY:                System.Double
                            'ACT_CAT_DESC:           System.String
                            If Not IsDBNull(.Item(i)) Then
                                'Dim FieldType As String = .GetFieldType(i).FullName
                                'MsgBox(.GetFieldType(i).FullName)
                                Select Case .GetFieldType(i).FullName
                                    Case "System.String"
                                        item.SubItems.Add(.GetString(i))
                                        'item.SubItems.Add(.Item(i))
                                    Case "System.Double"
                                        item.SubItems.Add(.GetDouble(i))
                                    Case "System.Decimal"
                                        item.SubItems.Add(.GetDecimal(i))
                                    Case "System.Boolean"
                                        item.SubItems.Add(.GetBoolean(i))
                                    Case "System.DateTime"
                                        item.SubItems.Add(.GetDateTime(i))
                                    Case "System.Int16"
                                        item.SubItems.Add(.GetInt16(i))
                                    Case "System.Int32"
                                        item.SubItems.Add(.GetInt32(i))
                                    Case "System.Int64"
                                        item.SubItems.Add(.GetInt64(i))
                                    Case "System.Byte"
                                        item.SubItems.Add(.GetByte(i))
                                End Select
                            Else
                                item.SubItems.Add("")
                            End If

                            'If Not IsDBNull(reader.Item(2)) Then item.SubItems.Add(reader.Item(2))
                            'If Not IsDBNull(reader.Item(3)) Then item.SubItems.Add(reader.Item(3))
                        Next
                        lvw.Items.Add(item)
                        'MsgBox(reader.Item(0))
                    Loop
                    lvw.Items(0).Selected = True
                End If
                .Close()
            End With
            conn.Close()

            If ShowTotal Then ShowTotalOnLvw(lvw, 0)

            Cursor.Current = Cursors.Default

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub ShowTotalOnLvw(ByVal lvw As ListView, ByVal lvwCol As Short, Optional ByVal ShowWhat As String = "ItemsCount")

        Dim posTotal As Short
        posTotal = InStr(lvw.Columns(lvwCol).Text, "(")
        With lvw
            .Columns(lvwCol).Text = Left(.Columns(lvwCol).Text, _
            IIf(posTotal = 0, Len(.Columns(lvwCol).Text), posTotal - 2)) & _
            " (" & IIf(ShowWhat = "ItemsCount", .Items.Count, ShowWhat) & ")"
        End With
    End Sub

    Friend Sub Fill_cbo(ByVal cbo As ComboBox, ByVal strSQL As String)

        Try

            With cbo
                .Items.Clear()
                Dim conn As New OleDbConnection(strConn)
                Dim cmd As New OleDbCommand(strSQL, conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                With reader
                    If .HasRows Then
                        Do While .Read()
                            cbo.Items.Add(New ValueDescriptionPair(.Item(0), .Item(1)))
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

    Friend Sub UpdateDataSourceAddNew(ByVal ds As DataSet1, _
                                      ByVal TableName As String, _
                                      ByVal conn As OleDbConnection, _
                                      ByVal adapter As OleDbDataAdapter)

        'Dim conn As New OleDbConnection(strConn)
        Try
            'conn.ConnectionString = strConn
            conn.Open()
            With adapter

                '.UpdateCommand.Connection = conn
                .InsertCommand.Connection = conn
                .Update(ds, TableName)
            End With
        Catch ex As System.Exception

            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Friend Sub UpdateDataSource(ByVal ChangedRows As DataSet1, _
                                ByVal conn As OleDbConnection, _
                                ByVal adapter As OleDbDataAdapter)

        'Dim conn As New OleDbConnection(strConn)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'conn.ConnectionString = strConn
                conn.Open()
                With adapter
                    .UpdateCommand.Connection = conn
                    .Update(ChangedRows)
                End With
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Friend Sub SelectLvwItem(ByVal lvw As ListView, ByVal ItmTextToSelect As String, Optional ByVal SubItem As Short = 0)
        Dim item As New ListViewItem
        For Each item In lvw.Items
            'If Trim(item.SubItems(SubItmIdx).Text) = ItmTextToFind Then
            'Lvw.Items(item.Index).Selected = True
            'Exit Sub
            'End If
            If SubItem > 0 Then
                If Trim(item.SubItems(SubItem).Text) = ItmTextToSelect Then
                    lvw.Items(item.Index).Selected = True
                    Exit Sub
                End If
            Else
                If Trim(item.Text) = ItmTextToSelect Then
                    lvw.Items(item.Index).Selected = True
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Friend Function FindLvwItem(ByVal lvw As ListView, ByVal ItmTextToFind As String, Optional ByVal FindSubItem As Short = 0, Optional ByVal ReturnSubItem As Short = 0) As String
        Dim item As New ListViewItem
        For Each item In lvw.Items
            If FindSubItem > 0 Then
                If Trim(item.SubItems(FindSubItem).Text) = ItmTextToFind Then
                    If ReturnSubItem > 0 Then
                        FindLvwItem = item.SubItems(ReturnSubItem).Text
                    Else
                        FindLvwItem = item.Text
                    End If
                    Exit Function
                End If
            Else
                If Trim(item.Text) = ItmTextToFind Then
                    If ReturnSubItem > 0 Then
                        FindLvwItem = item.SubItems(ReturnSubItem).Text
                    Else
                        FindLvwItem = item.Text
                    End If
                    Exit Function
                End If
            End If
        Next
    End Function

    Friend Sub ColorLvwItem(ByVal lvw As ListView, ByVal ItmTextToColor As String, Optional ByVal SubItem As Short = 0)
        Dim item As New ListViewItem
        For Each item In lvw.Items
            If SubItem > 0 Then
                If Trim(item.SubItems(SubItem).Text) = ItmTextToColor Then
                    lvw.Items(item.Index).BackColor = Color.Yellow
                    Exit Sub
                End If
            Else
                If Trim(item.Text) = ItmTextToColor Then
                    lvw.Items(item.Index).BackColor = Color.Yellow
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Friend Sub RunSQL(ByVal strSQL As String)

        Cursor.Current = Cursors.WaitCursor

        'Console.WriteLine(strSQL)
        Dim conn As New OleDbConnection(strConn)
        Dim cmd As New OleDbCommand(strSQL, conn)
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        Cursor.Current = Cursors.Default

    End Sub

    Friend Sub FillDateTimeSlickers(ByVal frm As Form, _
                                    ByVal dt As DataTable, _
                                    ByVal dtsName As String, _
                                    ByVal dtsCount As Short, _
                                    Optional ByVal DefaultDay As String = "Today")

        Try
            Dim dts As Umbrae.Windows.Forms.DateTimeSlicker

            With dt
                For i As Short = 1 To dtsCount
                    dts = CType(FindControl(frm, dtsName & i), Umbrae.Windows.Forms.DateTimeSlicker)
                    'MsgBox(.Rows(0).Item(dts.Tag))
                    If Not IsDBNull(.Rows(0).Item(dts.Tag)) Then
                        dts.Text = .Rows(0).Item(dts.Tag)
                        dts.Checked = True
                    Else
                        If DefaultDay <> "Today" Then
                            dts.Text = DefaultDay '"11/1/2007"
                        Else
                            dts.Text = Today
                        End If
                        dts.Checked = False
                    End If
                Next
            End With

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub FillDateTimeSlickersTime(ByVal frm As Form, _
                                        ByVal dt As DataTable, _
                                        ByVal dtsName As String, _
                                        ByVal dtsCount As Short, _
                                        Optional ByVal DefaultTime As String = "Now")

        Try
            Dim dts As Umbrae.Windows.Forms.DateTimeSlicker

            With dt
                For i As Short = 1 To dtsCount
                    dts = CType(FindControl(frm, dtsName & i), Umbrae.Windows.Forms.DateTimeSlicker)
                    'MsgBox(.Rows(0).Item(dts.Tag))
                    If Len(Trim(.Rows(0).Item(dts.Tag).ToString)) > 0 Then
                        dts.Text = .Rows(0).Item(dts.Tag)
                        dts.Checked = True
                    Else
                        If DefaultTime <> "Now" Then
                            dts.Text = DefaultTime '"11/1/2007"
                        Else
                            dts.Text = "12:00:00 AM"
                        End If
                        dts.Checked = False
                    End If
                Next
            End With

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub FillCheckBoxes(ByVal frm As Form, _
                              ByVal dt As DataTable, _
                              ByVal ChkBxName As String, _
                              ByVal ChkBxCount As Short)

        Dim ChkBx As CheckBox

        For i As Short = 1 To ChkBxCount
            ChkBx = CType(FindControl(frm, ChkBxName & i), CheckBox)
            'MsgBox(.Rows(0).Item(ChkBx.Tag))
            'If Not IsDBNull(.Rows(0).Item(ChkBx.Tag)) Then
            'ChkBx.Checked = True
            'Else
            'ChkBx.Checked = False
            'End If
            If dt.Rows(0).Item(ChkBx.Tag) = True Then
                ChkBx.Checked = True
            Else
                ChkBx.Checked = False
            End If
        Next

    End Sub

    Friend Sub FillCheckBoxGroup(ByVal frm As Form, _
                                 ByVal FieldValue As String, _
                                 ByVal ChkBxGroupName As String, _
                                 ByVal ChkBxCount As Short)

        Try
            For i As Short = 1 To ChkBxCount
                CType(FindControl(frm, ChkBxGroupName & i), CheckBox).Checked = False
            Next
            'MsgBox(FieldValue.Length)
            For i As Short = 1 To FieldValue.Length
                If Mid(FieldValue, i, 1) = 1 Then
                    CType(FindControl(frm, ChkBxGroupName & i), CheckBox).Checked = True
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub UpdateCheckBoxGroupField(ByVal frm As Form, _
                                        ByVal dt As DataTable, _
                                        ByVal FieldName As String, _
                                        ByVal ChkBxName As String, _
                                        ByVal ChkBxCount As Short)

        Dim ChkBx As CheckBox, str As String

        For i As Short = 1 To ChkBxCount
            ChkBx = CType(FindControl(frm, ChkBxName & i), CheckBox)
            str = str & IIf(ChkBx.Checked, "1", "0")
        Next

        dt.Rows(0).Item(FieldName) = str

    End Sub

    Friend Sub FillRBYesNo(ByVal FieldValue As String, _
                           ByVal RBYes As RadioButton, _
                           ByVal RBNo As RadioButton)

        RBYes.Checked = False
        RBNo.Checked = False
        Select Case UCase(FieldValue)
            Case "Y"
                RBYes.Checked = True
            Case "N"
                RBNo.Checked = True
        End Select

    End Sub

    Friend Sub FillRadioButtonGroup(ByVal frm As Form, _
                                    ByVal FieldValue As String, _
                                    ByVal RadioButtonName As String, _
                                    ByVal RBCount As Short)

        Dim rb As RadioButton
        For i As Short = 1 To RBCount
            rb = CType(FindControl(frm, RadioButtonName & i), RadioButton)
            rb.Checked = False
        Next
        If FieldValue.Trim.Length > 0 Then
            rb = CType(FindControl(frm, RadioButtonName & FieldValue), RadioButton)
            rb.Checked = True
        End If

    End Sub

    Friend Sub EmptyRadioButtonGroup(ByVal frm As Form, _
                                     ByVal dt As DataTable, _
                                     ByVal FieldName As String, _
                                     ByVal RadioButtonName As String, _
                                     ByVal RBCount As Short)

        Dim rb As RadioButton
        'For i As Short = 1 To RBCount
        'rb = CType(FindControl(frm, RadioButtonName & i), RadioButton)
        'rb.Checked = False
        'Next
        rb = CType(FindControl(frm, RadioButtonName), RadioButton)
        rb.Checked = False
        dt.Rows(0).Item(FieldName) = ""

    End Sub

    Friend Sub UpdateRadioButtonGroupField(ByVal frm As Form, _
                                           ByVal dt As DataTable, _
                                           ByVal FieldName As String, _
                                           ByVal RadioButtonName As String, _
                                           ByVal RBCount As Short)

        Dim rb As RadioButton
        For i As Short = 1 To RBCount
            rb = CType(FindControl(frm, RadioButtonName & i), RadioButton)
            If rb.Checked Then
                dt.Rows(0).Item(FieldName) = i
                Exit Sub
            End If
        Next

    End Sub

    Friend Sub LvwMoveOne(ByVal lvwAvailable As ListView, ByVal lvwSelected As ListView)

        If lvwAvailable.Items.Count = 0 Then
            MsgBox("Sorry, There are NO items in the list!", vbOKOnly + vbInformation)
            Exit Sub
        End If

        If lvwAvailable.SelectedItems.Count = 0 Then
            MsgBox("Please click a desired item on the list to select.", MsgBoxStyle.Information)
            lvwAvailable.Focus()
            Exit Sub
        End If

        'The Clone method is better ...
        Dim item As ListViewItem = lvwAvailable.SelectedItems(0)
        Dim newItem As ListViewItem = CType(item.Clone(), ListViewItem)
        lvwSelected.Items.Add(newItem)

        'Then remove the item from this list.
        Dim RemovedItemIndex As Integer = lvwAvailable.SelectedItems(0).Index
        lvwAvailable.SelectedItems(0).Remove()

        'Make sure the correct item is selected & visible
        With lvwAvailable
            If .Items.Count > 0 Then
                If RemovedItemIndex <= .Items.Count - 1 Then
                    .Items(RemovedItemIndex).Selected = True
                Else
                    .Items(RemovedItemIndex - 1).Selected = True
                End If
                .SelectedItems(0).EnsureVisible()
            End If
        End With
        If lvwSelected.Items.Count = 1 Then
            lvwSelected.Items(0).Selected = True
        End If

        'Show total available and selected items
        ShowTotalOnLvw(lvwAvailable, 0)
        ShowTotalOnLvw(lvwSelected, 0)

    End Sub

    Friend Sub LvwMoveAll(ByVal lvwAvailable As ListView, _
                          ByVal lvwSelected As ListView, _
                          Optional ByVal ShowMsgbox As Boolean = True, _
                          Optional ByVal Clear_lvwAvailable As Boolean = True, _
                          Optional ByVal CheckIt As Boolean = False, _
                          Optional ByVal ShowTotal As Boolean = True)

        Try

            If lvwAvailable.Items.Count = 0 Then
                If ShowMsgbox Then MsgBox("Sorry, There are NO items in the list!", vbOKOnly + vbInformation)
                Exit Sub
            End If

            'Add all items to the other list first.
            For Each item As ListViewItem In lvwAvailable.Items
                Dim newItem As ListViewItem = CType(item.Clone(), ListViewItem)
                newItem.Checked = CheckIt
                lvwSelected.Items.Add(newItem)
            Next

            'Then remove all items from this list.
            If Clear_lvwAvailable Then lvwAvailable.Items.Clear()

            'Make sure the correct item is selected & visible
            With lvwSelected
                If .Items.Count > 0 Then
                    .Items(0).Selected = True
                    .SelectedItems(0).EnsureVisible()
                End If
            End With

            If ShowTotal Then
                ShowTotalOnLvw(lvwAvailable, 0)
                ShowTotalOnLvw(lvwSelected, 0)
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Friend Sub MoveListViewItem(ByVal lvw As ListView, ByVal UpDown As Short)

        With lvw

            If .Items.Count = 0 Then
                MsgBox("There are NO items on the list to move.", MsgBoxStyle.Information)
                Exit Sub
            End If

            If .SelectedItems.Count = 0 Then
                MsgBox("Please select a desired item on the list to move.", MsgBoxStyle.Information)
                .Focus()
                Exit Sub
            End If

            If UpDown = -1 Then 'Move up
                If .SelectedItems(0).Index = 0 Then Exit Sub
            Else
                If .SelectedItems(0).Index = .Items.Count - 1 Then Exit Sub
            End If

            Dim item As ListViewItem = .SelectedItems(0)
            Dim TempItem As ListViewItem = CType(item.Clone(), ListViewItem)

            Dim NewPostionIndex As Short = .SelectedItems(0).Index + UpDown

            'MsgBox(NewPostionIndex)
            item.Text = .Items(NewPostionIndex).Text
            item.SubItems(2).Text = .Items(NewPostionIndex).SubItems(2).Text
            With .Items(NewPostionIndex)
                .Text = TempItem.Text
                .SubItems(2).Text = TempItem.SubItems(2).Text
                .Selected = True
            End With

            .Focus()

        End With

    End Sub

    Friend Sub En_Disable_btnMoveUpDown(ByVal lvw As ListView, ByVal btnUp As Button, ByVal btnDown As Button)
        btnUp.Enabled = True
        btnDown.Enabled = True
        With lvw
            If .Items.Count = 0 Then
                btnUp.Enabled = False
                btnDown.Enabled = False
            ElseIf .SelectedItems.Count = 0 Then
                btnUp.Enabled = False
                btnDown.Enabled = False
            ElseIf .SelectedItems(0).Index = 0 Then
                btnUp.Enabled = False
            ElseIf .SelectedItems(0).Index = .Items.Count - 1 Then
                btnDown.Enabled = False
            End If
        End With
    End Sub

    Friend Sub LvwCheckAll(ByVal lvw As ListView, ByVal btn As Button)

        If lvw.Items.Count = 0 Then
            MsgBox("Sorry, There are NO items to check or uncheck.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
            Exit Sub
        End If

        If btn.Text = "Check All" Then
            For Each itm As ListViewItem In lvw.Items
                itm.Checked = True
                btn.Text = "Uncheck All"
            Next
        Else
            For Each itm As ListViewItem In lvw.Items
                itm.Checked = False
                btn.Text = "Check All"
            Next
        End If

    End Sub

End Module
