Imports SpeechLib
Public Class Form1
    Inherits System.Windows.Forms.Form
    'Dim m_speakFlags As SpeechVoiceSpeakFlags


#Region " Windows Form Designer generated code "

    Public WithEvents vox As New SpVoice
    Public RateOfSpeech As Integer = -1

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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents chkUseVoice As System.Windows.Forms.CheckBox
    Friend WithEvents grpVoice As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbarRateOfSpeech As System.Windows.Forms.TrackBar
    Friend WithEvents cboVoxOptions As System.Windows.Forms.ComboBox
    Friend WithEvents chkFlagsAsync As System.Windows.Forms.CheckBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnReadFile As System.Windows.Forms.Button
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtA2Q As System.Windows.Forms.TextBox
    Friend WithEvents txtA1Q As System.Windows.Forms.TextBox
    Friend WithEvents btnA1 As System.Windows.Forms.Button
    Friend WithEvents btnA2 As System.Windows.Forms.Button
    Friend WithEvents grpA2Ans As System.Windows.Forms.GroupBox
    Friend WithEvents txtA2Ans2 As System.Windows.Forms.TextBox
    Friend WithEvents txtA2Ans1 As System.Windows.Forms.TextBox
    Friend WithEvents lblA1 As System.Windows.Forms.Label
    Friend WithEvents lblA2 As System.Windows.Forms.Label
    Friend WithEvents lblA3 As System.Windows.Forms.Label
    Friend WithEvents txtA3Q As System.Windows.Forms.TextBox
    Friend WithEvents btnA3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtA3Ans2 As System.Windows.Forms.TextBox
    Friend WithEvents txtA3Ans1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtA3Ans3 As System.Windows.Forms.TextBox
    Friend WithEvents txtA3Ans7 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents txtA3Ans6 As System.Windows.Forms.TextBox
    Friend WithEvents txtA3Ans4 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents txtA3Ans5 As System.Windows.Forms.TextBox
    Friend WithEvents txtA3Ans8 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents txtA3Ans9 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents txtA3Ans10 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents txtA3Ans11 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents txtA3Ans12 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.chkUseVoice = New System.Windows.Forms.CheckBox
        Me.grpVoice = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbarRateOfSpeech = New System.Windows.Forms.TrackBar
        Me.cboVoxOptions = New System.Windows.Forms.ComboBox
        Me.chkFlagsAsync = New System.Windows.Forms.CheckBox
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnReadFile = New System.Windows.Forms.Button
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.txtA3Ans12 = New System.Windows.Forms.TextBox
        Me.txtA3Ans11 = New System.Windows.Forms.TextBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.txtA3Ans10 = New System.Windows.Forms.TextBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.txtA3Ans9 = New System.Windows.Forms.TextBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.txtA3Ans8 = New System.Windows.Forms.TextBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.txtA3Ans5 = New System.Windows.Forms.TextBox
        Me.txtA3Ans7 = New System.Windows.Forms.TextBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.txtA3Ans6 = New System.Windows.Forms.TextBox
        Me.txtA3Ans4 = New System.Windows.Forms.TextBox
        Me.txtA3Ans3 = New System.Windows.Forms.TextBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.txtA3Ans2 = New System.Windows.Forms.TextBox
        Me.txtA3Ans1 = New System.Windows.Forms.TextBox
        Me.btnA3 = New System.Windows.Forms.Button
        Me.lblA3 = New System.Windows.Forms.Label
        Me.txtA3Q = New System.Windows.Forms.TextBox
        Me.lblA2 = New System.Windows.Forms.Label
        Me.lblA1 = New System.Windows.Forms.Label
        Me.btnA1 = New System.Windows.Forms.Button
        Me.grpA2Ans = New System.Windows.Forms.GroupBox
        Me.txtA2Ans2 = New System.Windows.Forms.TextBox
        Me.txtA2Ans1 = New System.Windows.Forms.TextBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.btnA2 = New System.Windows.Forms.Button
        Me.txtA2Q = New System.Windows.Forms.TextBox
        Me.txtA1Q = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.grpVoice.SuspendLayout()
        CType(Me.tbarRateOfSpeech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpA2Ans.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(837, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(11, 21)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = ""
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(815, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(33, 21)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = ""
        Me.TextBox2.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'chkUseVoice
        '
        Me.chkUseVoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkUseVoice.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkUseVoice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseVoice.Location = New System.Drawing.Point(0, 0)
        Me.chkUseVoice.Name = "chkUseVoice"
        Me.chkUseVoice.Size = New System.Drawing.Size(855, 24)
        Me.chkUseVoice.TabIndex = 19
        Me.chkUseVoice.Text = "Use Voice"
        '
        'grpVoice
        '
        Me.grpVoice.Controls.Add(Me.Label1)
        Me.grpVoice.Controls.Add(Me.tbarRateOfSpeech)
        Me.grpVoice.Controls.Add(Me.cboVoxOptions)
        Me.grpVoice.Controls.Add(Me.chkFlagsAsync)
        Me.grpVoice.Controls.Add(Me.btnStop)
        Me.grpVoice.Controls.Add(Me.btnReadFile)
        Me.grpVoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpVoice.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpVoice.Location = New System.Drawing.Point(0, 24)
        Me.grpVoice.Name = "grpVoice"
        Me.grpVoice.Size = New System.Drawing.Size(855, 68)
        Me.grpVoice.TabIndex = 21
        Me.grpVoice.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Rate"
        '
        'tbarRateOfSpeech
        '
        Me.tbarRateOfSpeech.Location = New System.Drawing.Point(181, 18)
        Me.tbarRateOfSpeech.Maximum = 3
        Me.tbarRateOfSpeech.Minimum = -3
        Me.tbarRateOfSpeech.Name = "tbarRateOfSpeech"
        Me.tbarRateOfSpeech.Size = New System.Drawing.Size(116, 45)
        Me.tbarRateOfSpeech.TabIndex = 15
        '
        'cboVoxOptions
        '
        Me.cboVoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVoxOptions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVoxOptions.Location = New System.Drawing.Point(16, 22)
        Me.cboVoxOptions.Name = "cboVoxOptions"
        Me.cboVoxOptions.TabIndex = 14
        '
        'chkFlagsAsync
        '
        Me.chkFlagsAsync.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkFlagsAsync.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFlagsAsync.ImageList = Me.ImageList1
        Me.chkFlagsAsync.Location = New System.Drawing.Point(306, 20)
        Me.chkFlagsAsync.Name = "chkFlagsAsync"
        Me.chkFlagsAsync.Size = New System.Drawing.Size(78, 25)
        Me.chkFlagsAsync.TabIndex = 13
        Me.chkFlagsAsync.Text = "FlagsAsync"
        '
        'btnStop
        '
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStop.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(440, 20)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(39, 27)
        Me.btnStop.TabIndex = 11
        Me.btnStop.Text = "Stop"
        '
        'btnReadFile
        '
        Me.btnReadFile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReadFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReadFile.Location = New System.Drawing.Point(391, 20)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(39, 27)
        Me.btnReadFile.TabIndex = 12
        Me.btnReadFile.Text = "Start"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(0, 92)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(855, 3)
        Me.Splitter2.TabIndex = 22
        Me.Splitter2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 95)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(855, 427)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnA3)
        Me.TabPage1.Controls.Add(Me.lblA3)
        Me.TabPage1.Controls.Add(Me.txtA3Q)
        Me.TabPage1.Controls.Add(Me.lblA2)
        Me.TabPage1.Controls.Add(Me.lblA1)
        Me.TabPage1.Controls.Add(Me.btnA1)
        Me.TabPage1.Controls.Add(Me.grpA2Ans)
        Me.TabPage1.Controls.Add(Me.btnA2)
        Me.TabPage1.Controls.Add(Me.txtA2Q)
        Me.TabPage1.Controls.Add(Me.txtA1Q)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(847, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox12)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans12)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans11)
        Me.GroupBox1.Controls.Add(Me.CheckBox11)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans10)
        Me.GroupBox1.Controls.Add(Me.CheckBox10)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans9)
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans8)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans5)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans7)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans6)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans4)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans3)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans2)
        Me.GroupBox1.Controls.Add(Me.txtA3Ans1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(209, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 153)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'CheckBox12
        '
        Me.CheckBox12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox12.ImageList = Me.ImageList1
        Me.CheckBox12.Location = New System.Drawing.Point(9, 119)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox12.TabIndex = 37
        '
        'txtA3Ans12
        '
        Me.txtA3Ans12.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans12.Location = New System.Drawing.Point(27, 125)
        Me.txtA3Ans12.Multiline = True
        Me.txtA3Ans12.Name = "txtA3Ans12"
        Me.txtA3Ans12.Size = New System.Drawing.Size(156, 18)
        Me.txtA3Ans12.TabIndex = 36
        Me.txtA3Ans12.Tag = ""
        Me.txtA3Ans12.Text = "Other. Please tell us which:"
        '
        'txtA3Ans11
        '
        Me.txtA3Ans11.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans11.Location = New System.Drawing.Point(427, 98)
        Me.txtA3Ans11.Multiline = True
        Me.txtA3Ans11.Name = "txtA3Ans11"
        Me.txtA3Ans11.Size = New System.Drawing.Size(127, 18)
        Me.txtA3Ans11.TabIndex = 35
        Me.txtA3Ans11.Tag = "txtA3Ans12"
        Me.txtA3Ans11.Text = "Australia or New Zealand"
        '
        'CheckBox11
        '
        Me.CheckBox11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox11.ImageList = Me.ImageList1
        Me.CheckBox11.Location = New System.Drawing.Point(407, 92)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox11.TabIndex = 34
        '
        'txtA3Ans10
        '
        Me.txtA3Ans10.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans10.Location = New System.Drawing.Point(322, 98)
        Me.txtA3Ans10.Multiline = True
        Me.txtA3Ans10.Name = "txtA3Ans10"
        Me.txtA3Ans10.Size = New System.Drawing.Size(79, 18)
        Me.txtA3Ans10.TabIndex = 33
        Me.txtA3Ans10.Tag = "txtA3Ans11"
        Me.txtA3Ans10.Text = "South America"
        '
        'CheckBox10
        '
        Me.CheckBox10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox10.ImageList = Me.ImageList1
        Me.CheckBox10.Location = New System.Drawing.Point(302, 92)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox10.TabIndex = 32
        '
        'txtA3Ans9
        '
        Me.txtA3Ans9.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans9.Location = New System.Drawing.Point(259, 98)
        Me.txtA3Ans9.Multiline = True
        Me.txtA3Ans9.Name = "txtA3Ans9"
        Me.txtA3Ans9.Size = New System.Drawing.Size(36, 18)
        Me.txtA3Ans9.TabIndex = 31
        Me.txtA3Ans9.Tag = "txtA3Ans10"
        Me.txtA3Ans9.Text = "Asia"
        '
        'CheckBox9
        '
        Me.CheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox9.ImageList = Me.ImageList1
        Me.CheckBox9.Location = New System.Drawing.Point(239, 92)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox9.TabIndex = 30
        '
        'txtA3Ans8
        '
        Me.txtA3Ans8.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans8.Location = New System.Drawing.Point(189, 98)
        Me.txtA3Ans8.Multiline = True
        Me.txtA3Ans8.Name = "txtA3Ans8"
        Me.txtA3Ans8.Size = New System.Drawing.Size(44, 18)
        Me.txtA3Ans8.TabIndex = 29
        Me.txtA3Ans8.Tag = "txtA3Ans9"
        Me.txtA3Ans8.Text = "Europe"
        '
        'CheckBox8
        '
        Me.CheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.ImageList = Me.ImageList1
        Me.CheckBox8.Location = New System.Drawing.Point(169, 92)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox8.TabIndex = 28
        '
        'CheckBox7
        '
        Me.CheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.ImageList = Me.ImageList1
        Me.CheckBox7.Location = New System.Drawing.Point(9, 63)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox7.TabIndex = 27
        '
        'txtA3Ans5
        '
        Me.txtA3Ans5.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans5.Location = New System.Drawing.Point(26, 69)
        Me.txtA3Ans5.Multiline = True
        Me.txtA3Ans5.Name = "txtA3Ans5"
        Me.txtA3Ans5.Size = New System.Drawing.Size(393, 18)
        Me.txtA3Ans5.TabIndex = 26
        Me.txtA3Ans5.Tag = "txtA3Ans6"
        Me.txtA3Ans5.Text = "Other Central American country (for example Panama, Guatemala, Nicaragua)"
        '
        'txtA3Ans7
        '
        Me.txtA3Ans7.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans7.Location = New System.Drawing.Point(113, 98)
        Me.txtA3Ans7.Multiline = True
        Me.txtA3Ans7.Name = "txtA3Ans7"
        Me.txtA3Ans7.Size = New System.Drawing.Size(38, 18)
        Me.txtA3Ans7.TabIndex = 25
        Me.txtA3Ans7.Tag = "txtA3Ans8"
        Me.txtA3Ans7.Text = "Africa"
        '
        'CheckBox4
        '
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ImageList = Me.ImageList1
        Me.CheckBox4.Location = New System.Drawing.Point(96, 92)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox4.TabIndex = 24
        '
        'CheckBox5
        '
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.ImageList = Me.ImageList1
        Me.CheckBox5.Location = New System.Drawing.Point(9, 92)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox5.TabIndex = 23
        '
        'CheckBox6
        '
        Me.CheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.ImageList = Me.ImageList1
        Me.CheckBox6.Location = New System.Drawing.Point(9, 37)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox6.TabIndex = 22
        '
        'txtA3Ans6
        '
        Me.txtA3Ans6.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans6.Location = New System.Drawing.Point(26, 98)
        Me.txtA3Ans6.Multiline = True
        Me.txtA3Ans6.Name = "txtA3Ans6"
        Me.txtA3Ans6.Size = New System.Drawing.Size(49, 18)
        Me.txtA3Ans6.TabIndex = 21
        Me.txtA3Ans6.Tag = "txtA3Ans7"
        Me.txtA3Ans6.Text = "Canada"
        '
        'txtA3Ans4
        '
        Me.txtA3Ans4.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans4.Location = New System.Drawing.Point(26, 43)
        Me.txtA3Ans4.Multiline = True
        Me.txtA3Ans4.Name = "txtA3Ans4"
        Me.txtA3Ans4.Size = New System.Drawing.Size(368, 18)
        Me.txtA3Ans4.TabIndex = 20
        Me.txtA3Ans4.Tag = "txtA3Ans5"
        Me.txtA3Ans4.Text = "Other Caribbean country (for example Virgin Islands, Jamaica, Cuba, Haiti)"
        '
        'txtA3Ans3
        '
        Me.txtA3Ans3.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans3.Location = New System.Drawing.Point(189, 16)
        Me.txtA3Ans3.Multiline = True
        Me.txtA3Ans3.Name = "txtA3Ans3"
        Me.txtA3Ans3.Size = New System.Drawing.Size(102, 18)
        Me.txtA3Ans3.TabIndex = 19
        Me.txtA3Ans3.Tag = "txtA3Ans4"
        Me.txtA3Ans3.Text = "Dominican Republic"
        '
        'CheckBox3
        '
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ImageList = Me.ImageList1
        Me.CheckBox3.Location = New System.Drawing.Point(169, 10)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox3.TabIndex = 18
        '
        'CheckBox2
        '
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ImageList = Me.ImageList1
        Me.CheckBox2.Location = New System.Drawing.Point(96, 10)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox2.TabIndex = 17
        '
        'CheckBox1
        '
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ImageList = Me.ImageList1
        Me.CheckBox1.Location = New System.Drawing.Point(9, 10)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(17, 25)
        Me.CheckBox1.TabIndex = 16
        '
        'txtA3Ans2
        '
        Me.txtA3Ans2.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans2.Location = New System.Drawing.Point(113, 16)
        Me.txtA3Ans2.Multiline = True
        Me.txtA3Ans2.Name = "txtA3Ans2"
        Me.txtA3Ans2.Size = New System.Drawing.Size(41, 18)
        Me.txtA3Ans2.TabIndex = 15
        Me.txtA3Ans2.Tag = "txtA3Ans3"
        Me.txtA3Ans2.Text = "Mexico"
        '
        'txtA3Ans1
        '
        Me.txtA3Ans1.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Ans1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Ans1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Ans1.Location = New System.Drawing.Point(26, 16)
        Me.txtA3Ans1.Multiline = True
        Me.txtA3Ans1.Name = "txtA3Ans1"
        Me.txtA3Ans1.Size = New System.Drawing.Size(63, 18)
        Me.txtA3Ans1.TabIndex = 14
        Me.txtA3Ans1.Tag = "txtA3Ans2"
        Me.txtA3Ans1.Text = "Puerto Rico"
        '
        'btnA3
        '
        Me.btnA3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnA3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA3.Location = New System.Drawing.Point(60, 138)
        Me.btnA3.Name = "btnA3"
        Me.btnA3.Size = New System.Drawing.Size(39, 24)
        Me.btnA3.TabIndex = 26
        Me.btnA3.Text = "Next"
        '
        'lblA3
        '
        Me.lblA3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA3.Location = New System.Drawing.Point(57, 173)
        Me.lblA3.Name = "lblA3"
        Me.lblA3.Size = New System.Drawing.Size(23, 15)
        Me.lblA3.TabIndex = 25
        Me.lblA3.Text = "A.3"
        '
        'txtA3Q
        '
        Me.txtA3Q.BackColor = System.Drawing.SystemColors.Control
        Me.txtA3Q.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA3Q.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA3Q.Location = New System.Drawing.Point(83, 173)
        Me.txtA3Q.Multiline = True
        Me.txtA3Q.Name = "txtA3Q"
        Me.txtA3Q.Size = New System.Drawing.Size(120, 24)
        Me.txtA3Q.TabIndex = 24
        Me.txtA3Q.Tag = "txtA3Ans1"
        Me.txtA3Q.Text = "Where were you born? "
        '
        'lblA2
        '
        Me.lblA2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA2.Location = New System.Drawing.Point(25, 109)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(23, 15)
        Me.lblA2.TabIndex = 23
        Me.lblA2.Text = "A.2"
        '
        'lblA1
        '
        Me.lblA1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA1.Location = New System.Drawing.Point(26, 42)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(23, 15)
        Me.lblA1.TabIndex = 22
        Me.lblA1.Text = "A.1"
        '
        'btnA1
        '
        Me.btnA1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnA1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA1.Location = New System.Drawing.Point(8, 8)
        Me.btnA1.Name = "btnA1"
        Me.btnA1.Size = New System.Drawing.Size(39, 24)
        Me.btnA1.TabIndex = 20
        Me.btnA1.Text = "Start"
        '
        'grpA2Ans
        '
        Me.grpA2Ans.Controls.Add(Me.txtA2Ans2)
        Me.grpA2Ans.Controls.Add(Me.txtA2Ans1)
        Me.grpA2Ans.Controls.Add(Me.RadioButton2)
        Me.grpA2Ans.Controls.Add(Me.RadioButton1)
        Me.grpA2Ans.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpA2Ans.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpA2Ans.Location = New System.Drawing.Point(245, 94)
        Me.grpA2Ans.Name = "grpA2Ans"
        Me.grpA2Ans.Size = New System.Drawing.Size(217, 40)
        Me.grpA2Ans.TabIndex = 19
        Me.grpA2Ans.TabStop = False
        '
        'txtA2Ans2
        '
        Me.txtA2Ans2.BackColor = System.Drawing.SystemColors.Control
        Me.txtA2Ans2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA2Ans2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA2Ans2.Location = New System.Drawing.Point(76, 16)
        Me.txtA2Ans2.Multiline = True
        Me.txtA2Ans2.Name = "txtA2Ans2"
        Me.txtA2Ans2.Size = New System.Drawing.Size(119, 18)
        Me.txtA2Ans2.TabIndex = 15
        Me.txtA2Ans2.Text = "Yes. If Yes, skip to A.5"
        '
        'txtA2Ans1
        '
        Me.txtA2Ans1.BackColor = System.Drawing.SystemColors.Control
        Me.txtA2Ans1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA2Ans1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA2Ans1.Location = New System.Drawing.Point(26, 16)
        Me.txtA2Ans1.Multiline = True
        Me.txtA2Ans1.Name = "txtA2Ans1"
        Me.txtA2Ans1.Size = New System.Drawing.Size(19, 18)
        Me.txtA2Ans1.TabIndex = 14
        Me.txtA2Ans1.Tag = "txtA2Ans2"
        Me.txtA2Ans1.Text = "No"
        '
        'RadioButton2
        '
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(57, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(15, 24)
        Me.RadioButton2.TabIndex = 1
        '
        'RadioButton1
        '
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(18, 24)
        Me.RadioButton1.TabIndex = 0
        '
        'btnA2
        '
        Me.btnA2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnA2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA2.Location = New System.Drawing.Point(14, 68)
        Me.btnA2.Name = "btnA2"
        Me.btnA2.Size = New System.Drawing.Size(39, 24)
        Me.btnA2.TabIndex = 18
        Me.btnA2.Text = "Next"
        '
        'txtA2Q
        '
        Me.txtA2Q.BackColor = System.Drawing.SystemColors.Control
        Me.txtA2Q.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA2Q.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA2Q.Location = New System.Drawing.Point(51, 109)
        Me.txtA2Q.Multiline = True
        Me.txtA2Q.Name = "txtA2Q"
        Me.txtA2Q.Size = New System.Drawing.Size(181, 24)
        Me.txtA2Q.TabIndex = 17
        Me.txtA2Q.Tag = "txtA2Ans1"
        Me.txtA2Q.Text = "Were you born in the United States?"
        '
        'txtA1Q
        '
        Me.txtA1Q.BackColor = System.Drawing.SystemColors.Control
        Me.txtA1Q.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtA1Q.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA1Q.Location = New System.Drawing.Point(54, 42)
        Me.txtA1Q.Multiline = True
        Me.txtA1Q.Name = "txtA1Q"
        Me.txtA1Q.Size = New System.Drawing.Size(678, 24)
        Me.txtA1Q.TabIndex = 16
        Me.txtA1Q.Text = "How old are you?"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(847, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(847, 401)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(855, 531)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.grpVoice)
        Me.Controls.Add(Me.chkUseVoice)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpVoice.ResumeLayout(False)
        CType(Me.tbarRateOfSpeech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpA2Ans.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ActiveTxt As TextBox
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Dim ctl As Control
        'For Each ctl In Me.Controls
        'MsgBox(ctl.Name)
        'Next
        'Exit Sub

        'Must use code to Set Checked = True
        'Application.EnableVisualStyles() DOESN'T work if set in design mode!!!
        Me.chkUseVoice.Checked = True
        Me.chkFlagsAsync.Checked = True

        ' Load the voices combo box
        Dim Token As ISpeechObjectToken
        For Each Token In vox.GetVoices
            cboVoxOptions.Items.Add(Token.GetDescription())
        Next
        cboVoxOptions.SelectedIndex = 0

        'Dim str As String = Environment.UserName.ToString()
        'SayGreeting(str)

        'm_speakFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync

        'Me.txtA1.Text = "please test me and see if you like my voice"
        'txtA1.Focus()
        'txtA1.SelectionStart = 0
        'txtA1.SelectionLength = 10
       

    End Sub

    Public Sub SayGreeting(ByVal strUser As String)

        ' Now say something
        vox.Voice = vox.GetVoices().Item(cboVoxOptions.SelectedIndex)

        Dim dt As DateTime
        dt = Now

        ' clear your throat
        vox.Rate = RateOfSpeech
        vox.Speak("".ToString, SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)

        Try
            vox.Speak("Greetings " & strUser & " from Text To Speech", _
            SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
            vox.Speak("Today's Date is " & dt.ToShortDateString, _
            SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
            vox.Speak("The time is " & dt.ToShortTimeString, _
            SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "I'm Speechless")
        End Try

    End Sub

    Private Sub tbarRateOfSpeech_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.RateOfSpeech = tbarRateOfSpeech.Value

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, _
            ByVal e As System.Windows.Forms.KeyPressEventArgs) _
            Handles TextBox1.KeyPress

        vox.Rate = RateOfSpeech

        ' this will try to speak each word as you type, it does not keep up        
        ' all that well
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space) Or _
           e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            vox.Speak(TextBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault)
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, _
           ByVal e As System.Windows.Forms.KeyPressEventArgs) _
           Handles TextBox2.KeyPress

        vox.Rate = RateOfSpeech

        ' this will try to speak the contents of the textbox on Enter
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            vox.Speak(TextBox2.Text, SpeechVoiceSpeakFlags.SVSFDefault)
            TextBox2.Text = ""
        End If

    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        vox.Rate = RateOfSpeech

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            'Me.txtA1.Text = sr.ReadToEnd.ToString()
            sr.Close()

        End If

    End Sub






    ' This following helper function will set or clear a bit (flag) in the given
    ' integer (base) according to the condition (cond). If cond is 0, the bit
    ' is cleared. Otherwise, the bit is set. The resulting integer is returned.
    Private Function SetOrClearFlag(ByVal cond As Long, _
                                    ByVal base As Long, _
                                    ByVal flag As Long) As Long

        If cond = 0 Then
            ' the condition is false, clear the flag
            SetOrClearFlag = base And Not flag
        Else
            ' the condition is false, set the flag
            SetOrClearFlag = base Or flag
        End If
    End Function

    Private Sub chkFlagsAsync_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(ctype(Me.chkFlagsAsync))
    End Sub


    Private Sub vox_EndStream(ByVal StreamNumber As Integer, ByVal StreamPosition As Object) Handles vox.EndStream
        ' select all text to indicate that we are done
        HighLightSpokenWords(0, Len(ActiveTxt.Text))

        Try
            If Len(Trim(ActiveTxt.Tag)) > 0 Then
                'MsgBox(ActiveTxt.Tag)
                'Dim NextTxt As TextBox
                'NextTxt = CType(getControlFromName(grpA2Ans, ActiveTxt.Tag), TextBox)
                'MsgBox(NextTxt.Name)
                System.Threading.Thread.Sleep(500)
                SpeakText(FindControl(Me, ActiveTxt.Tag))
                'vox.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
            Else
                'vox.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub vox_Word(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal CharacterPosition As Integer, ByVal Length As Integer) Handles vox.Word
        ' Select the word that's currently being spoken.
        HighLightSpokenWords(CharacterPosition, Length)
    End Sub

    Private Sub SpeakText(ByVal txt As TextBox)
        If Me.chkUseVoice.Checked Then
            ActiveTxt = txt
            vox.Rate = tbarRateOfSpeech.Value
            vox.Speak(txt.Text.ToString(), SpeechVoiceSpeakFlags.SVSFlagsAsync)
        End If
    End Sub

    Private Sub HighLightSpokenWords(ByVal Pos As Long, ByVal Length As Long)

        ' Only high light when the MainTxtBox is actually showing the spoken text,
        ' instead of file name
        If chkFlagsAsync.CheckState = 1 Then
            'MsgBox(Length)
            With ActiveTxt
                .Focus()
                .SelectionStart = Pos
                .SelectionLength = Length
            End With
        End If

    End Sub


    Private Sub txtReadFile_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txtA1.SelectionStart = 0
        'txtA1.SelectionLength = 10
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vox.Speak("", SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
    End Sub

    Private Sub chkUseVoice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseVoice.CheckedChanged
        grpVoice.Visible = chkUseVoice.Checked
    End Sub

    Private Sub btnReadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadFile.Click
        vox.Rate = tbarRateOfSpeech.Value
        vox.Speak(txtA1Q.Text.ToString(), SpeechVoiceSpeakFlags.SVSFlagsAsync)
        ActiveTxt = txtA1Q
    End Sub

    Private Sub cboVoxOptions_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVoxOptions.SelectedIndexChanged
        vox.Voice = vox.GetVoices().Item(cboVoxOptions.SelectedIndex)
    End Sub

    Private Sub btnA1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA1.Click
        SpeakText(txtA1Q)
    End Sub


    Private Sub btnA2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA2.Click
        SpeakText(txtA2Q)
    End Sub

    Function getControlFromName(ByRef containerObj As Object, ByVal name As String) As Control
        Try
            Dim tempCtrl As Control
            For Each tempCtrl In containerObj.Controls
                If tempCtrl.Name.ToUpper.Trim = name.ToUpper.Trim Then
                    Return tempCtrl
                End If
            Next tempCtrl
        Catch ex As Exception
        End Try
    End Function

    Function getControlByName(ByVal name As String) As Control

        Try
            Dim ctrl As Control
            For Each ctrl In Me.Controls
                If ctrl.Name.ToUpper.Trim = name.ToUpper.Trim Then
                    Return ctrl
                    Exit Function
                End If
            Next ctrl

            For Each ctrl In Me.Controls
                MsgBox(ctrl.Name & ", count:" & ctrl.Controls.Count)
                If ctrl.Controls.Count > 0 Then
                    Dim ctrl2 As Control
                    For Each ctrl2 In ctrl.Controls
                        If ctrl2.Name.ToUpper.Trim = name.ToUpper.Trim Then
                            Return ctrl2
                            Exit Function
                        End If
                    Next ctrl2
                End If
            Next ctrl

        Catch ex As Exception

        End Try

    End Function

   


    Private Sub btnA3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA3.Click
        SpeakText(txtA3Q)
    End Sub
End Class
