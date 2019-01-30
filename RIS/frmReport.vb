Imports vb = Microsoft.VisualBasic.Strings
Imports System.Data.OleDb

Public Class frmReport
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents WebBrowser As AxSHDocVw.AxWebBrowser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReport))
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.WebBrowser = New AxSHDocVw.AxWebBrowser
        CType(Me.WebBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser
        '
        Me.WebBrowser.Enabled = True
        Me.WebBrowser.Location = New System.Drawing.Point(4, 3)
        Me.WebBrowser.OcxState = CType(resources.GetObject("WebBrowser.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WebBrowser.Size = New System.Drawing.Size(534, 243)
        Me.WebBrowser.TabIndex = 0
        '
        'frmReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(547, 259)
        Me.Controls.Add(Me.WebBrowser)
        Me.Name = "frmReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Preview"
        CType(Me.WebBrowser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FormActivated As Boolean = False
   
    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Try
        With Me.WebBrowser
            '.Left = 0
            '.Top = 0
        End With
        'Catch ex As System.Exception
        'MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub frmReport_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormActivated = True
    End Sub

    Private Sub frmReport_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        vfrmReport = Nothing
    End Sub

    Private Sub frmReport_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        With Me.WebBrowser
            .Left = 0
            .Top = 0
            .Width = Me.Width - 9
            .Height = Me.Height - 35
        End With
    End Sub
End Class


