Imports System.Data.OleDb
Imports vb = Microsoft.VisualBasic.Strings

'Imports System.Diagnostics
Public Class frmLogin
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Application.EnableVisualStyles()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboDriveLetter As System.Windows.Forms.ComboBox
    Friend WithEvents grpLogin As System.Windows.Forms.GroupBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginID As System.Windows.Forms.TextBox
    Friend WithEvents lblLoginID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboDriveLetter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtLoginID = New System.Windows.Forms.TextBox()
        Me.lblLoginID = New System.Windows.Forms.Label()
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOK.ImageIndex = 1
        Me.btnOK.Location = New System.Drawing.Point(256, 125)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 27)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.ImageIndex = 1
        Me.btnCancel.Location = New System.Drawing.Point(162, 125)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 27)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboDriveLetter
        '
        Me.cboDriveLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDriveLetter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDriveLetter.ItemHeight = 17
        Me.cboDriveLetter.Items.AddRange(New Object() {"D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.cboDriveLetter.Location = New System.Drawing.Point(256, 198)
        Me.cboDriveLetter.MaxDropDownItems = 23
        Me.cboDriveLetter.Name = "cboDriveLetter"
        Me.cboDriveLetter.Size = New System.Drawing.Size(58, 25)
        Me.cboDriveLetter.TabIndex = 32
        Me.cboDriveLetter.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 18)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Drive of data source"
        Me.Label1.Visible = False
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.lblPassword)
        Me.grpLogin.Controls.Add(Me.txtPassword)
        Me.grpLogin.Controls.Add(Me.txtLoginID)
        Me.grpLogin.Controls.Add(Me.lblLoginID)
        Me.grpLogin.Location = New System.Drawing.Point(15, 6)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(327, 112)
        Me.grpLogin.TabIndex = 34
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Security Login"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPassword.Location = New System.Drawing.Point(15, 73)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(98, 18)
        Me.lblPassword.TabIndex = 35
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(122, 69)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(196, 24)
        Me.txtPassword.TabIndex = 33
        '
        'txtLoginID
        '
        Me.txtLoginID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLoginID.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoginID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginID.Location = New System.Drawing.Point(122, 30)
        Me.txtLoginID.Name = "txtLoginID"
        Me.txtLoginID.Size = New System.Drawing.Size(196, 24)
        Me.txtLoginID.TabIndex = 32
        '
        'lblLoginID
        '
        Me.lblLoginID.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginID.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblLoginID.Location = New System.Drawing.Point(15, 34)
        Me.lblLoginID.Name = "lblLoginID"
        Me.lblLoginID.Size = New System.Drawing.Size(73, 18)
        Me.lblLoginID.TabIndex = 34
        Me.lblLoginID.Text = "Login ID"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.ClientSize = New System.Drawing.Size(350, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cboDriveLetter)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RIS Login"
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Me.txtLoginID.Text.Trim.Length = 0 Then
            MsgBox("Please enter your Login ID.", vbOKOnly + vbInformation)
            txtLoginID.Focus()
        ElseIf txtPassword.Text.Trim.Length = 0 Then
            MsgBox("Please enter your password.", vbOKOnly + vbInformation)
            txtPassword.Focus()
            'ElseIf Me.cboDriveLetter.Text.Length = 0 Then
            'MsgBox("Please locate the drive of the data source.", vbOKOnly + vbInformation)
            'Me.cboDriveLetter.Focus()
        Else

            'appPath = Me.cboDriveLetter.Text & ":\RIS"

            strLoginID = LCase(Me.txtLoginID.Text.Trim)
            strPassword = LCase(Me.txtPassword.Text.Trim)


            If PasswordVerified(strLoginID, strPassword) Then
                strAdminLoginID = "ahcis" : strAdminPassword = "accessahcis"

                strConn = "Provider=Microsoft.Jet.OLEDB.4.0; " & _
                          "Jet OLEDB:Database Password=RIS;" & _
                          "Jet OLEDB:System Database=" & appPath & "\Security\Wrkgrp_Sec.mdw; " & _
                          "data source=" & appPath & "\Data\RISdata.mdb; " & _
                          "User ID=" & strAdminLoginID & "; " & _
                          "Password=" & strAdminPassword & ";"

                Me.Hide()
                Load_frmMDI()
            Else
                Dim strMsgText As String
                If vb.Left(strLoginErr, 29) = "Cannot start your application" Then
                    strMsgText = "Incorrect database path. "
                Else
                    strMsgText = "Login incorrect. "
                End If

                If MsgBox(strMsgText & "Would you like to try again?", vbYesNo + vbExclamation) = vbYes Then
                    txtPassword.Focus()
                Else
                    End
                End If
            End If
        End If

    End Sub

    Public Sub Load_frmMDI()

        If vfrmMDI Is Nothing Then
            vfrmMDI = New frmMDI
            vfrmMDI.Show()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub txtLoginID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        With txtLoginID
            .SelectionStart() = 0
            .SelectionLength = .Text.Length
        End With
    End Sub

    Private Sub txtLoginID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then Me.txtPassword.Focus()
    End Sub
    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        With txtPassword
            .SelectionStart() = 0
            .SelectionLength = .Text.Length
        End With
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then btnOK_Click(sender, e)
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Process.GetProcessesByName("RIS").Length > 1 Then
            MsgBox("An instance of RIS is already open. Only one open instance is allowed on your desktop.", vbOKOnly + vbExclamation)
            'Application.Exit()
            End
        Else
            'need this
            vfrmLogin = Me

            If Command() <> String.Empty Then
                appPath = App_Path()
                INDEBUGMODE = True
            Else
                '* 3 different production release environments-- change prior to publishing
                appPath = "L:\HPVResearch\RIS\bin"
                'appPath = "L:\HPVResearch\RIS\bin_prod"
                'appPath = "L:\HPVResearch\RIS\bin_test"
            End If

            Me.TopMost = True


            '* THIS IS FOR TESTING AT BITTERSWEET LOCATION
            ReportappPath = appPath & "\Reports\"
            'ReportappPath = "C:\Bittersweet Software\RIS\Crystal Reports\Reports\"

            'appPath = Me.cboDriveLetter.Text & ":\RIS"

            Select Case vb.Left(appPath, 1)
                Case "C", "E", "F"
                    Me.txtLoginID.Text = "administrator"
                    Me.txtPassword.Text = "accessris"
            End Select

        End If

    End Sub
    Public Function iGetProcessCount(ByVal ProcessName As String)
        Dim proc() As Process = Nothing
        Try
            proc = Process.GetProcessesByName(ProcessName)
            Return proc.Length
        Finally
            proc = Nothing
        End Try
    End Function

    Private Sub frmLogin_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmLogin = Nothing
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
