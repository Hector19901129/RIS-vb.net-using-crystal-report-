Friend Module Module1


    'Friend strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
    '"Data Source=" & App_Path() & "\RIS.mdb;"


    Friend INDEBUGMODE As Boolean

    Friend appPath As String
    Friend ReportappPath As String
    Friend strConn As String
    Friend strLoginID As String
    Friend strPassword As String
    Friend strAdminLoginID As String
    Friend strAdminPassword As String
    Friend strLoginErr As String

    Friend xLvwIdx As String
    Friend ActiveBarText As String
    Friend vfrmLogin As frmLogin
    Friend vfrmMDI As frmMDI
    Friend vfrmPatient As frmPatient
    Friend vfrmPatientEdit As frmPatientEdit
    Friend vfrmPatCtsEdit As frmPatCtsEdit
    Friend vfrmPatCtsFrdEdit As frmPatCtsFrdEdit
    Friend vfrmStuHpvPatVisitEdit As frmStuHpvPatVisitEdit
    Friend vfrmStuHpvEpiEdit As frmStuHpvEpiEdit
    Friend vfrmStuHpvScrnFrmEdit As frmStuHpvScrnFrmEdit
    Friend vfrmStuHpvBloodEdit As frmStuHpvBloodEdit
    Friend vfrmStuHpvCtHxEdit As frmStuHpvCtHxEdit
    Friend vfrmReport As frmReport
    Friend vfrmReportList As frmReportList
    Friend vfrmStuHpvShip As frmStuHpvShip
    Friend vfrmStuHpvShipEdit As frmStuHpvShipEdit
    Friend vfrmIncetiveLog As frmIncentiveLogs
    Friend vfrmStuHpvRefIneligLog As frmStuHpvRefIneligLog
    Friend vfrmHPVBloodLog As frmHPVBloodLog
    Friend vfrmHPVAdverseEventsLog As frmHPVAdverseEventsLog
    Friend vfrmHPVScannedFiledLog As frmHPVScannedFiledLog




    Friend m_SortingColumn As ColumnHeader

    Public Class ControlByName

        'A class level variable to hold the value of a form. 
        Private _f As Form

        'This class can o­nly be instantiated if a form is passed to it's constructor (this will ensure that we always have a form reference in the _f variable). 
        Public Sub New(ByVal f As Form)
            Me._f = f
        End Sub

        'This property allows you to use the same calling convention that you are already familiar with. 
        Public ReadOnly Property Controls(ByVal Name As String) As Control
            Get
                Return Me.FindControl(Name, Me._f)
            End Get
        End Property

        Private Function FindControl(ByVal Name As String, ByVal InControl As Control) As Control
            'Use a recursive loop to search for the control o­n the form 
            Dim c As Control
            For Each c In InControl.Controls
                Me.FindControl(Name, c)
                If c.Name = Name Then Return c
            Next
        End Function
    End Class

    Friend Function FindControl(ByVal frm As Form, ByVal Name As String) As Control
        Try
            Dim propInfo As Reflection.PropertyInfo
            propInfo = frm.GetType().GetProperty(Name, Reflection.BindingFlags.IgnoreCase Or _
            Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Public)
            If Not propInfo Is Nothing Then
                Dim value As Object = propInfo.GetValue(frm, Nothing)
                If TypeOf value Is Control Then
                    Return CType(value, Control)
                End If
            End If
            Return Nothing
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Module
