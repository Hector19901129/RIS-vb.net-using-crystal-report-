Public Class frmStuHpvAdverseEvent
    Private Sub frmStuHpvAdverseEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RiSdataDataSet.ddvAdEventsSymptom' table. You can move, or remove it, as needed.
        Me.DdvAdEventsSymptomTableAdapter.Fill(Me.RiSdataDataSet.ddvAdEventsSymptom)
        'TODO: This line of code loads data into the 'RiSdataDataSet.ddvAdEventIntervention' table. You can move, or remove it, as needed.
        Me.DdvAdEventInterventionTableAdapter.Fill(Me.RiSdataDataSet.ddvAdEventIntervention)
        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvAdEventRelProtocol' table. You can move, or remove it, as needed.
        Me.DdvAdEventRelProtocolTableAdapter.Fill(Me.RiSdataDataSet.ddvAdEventRelProtocol)
        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvAdEventRecovery' table. You can move, or remove it, as needed.
        Me.DdvAdEventRecoveryTableAdapter.Fill(Me.RiSdataDataSet.ddvAdEventRecovery)
        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvAdEventSeverity' table. You can move, or remove it, as needed.
        Me.DdvAdEventSeverityTableAdapter.Fill(Me.RiSdataDataSet.ddvAdEventSeverity)
        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvPhysician' table. You can move, or remove it, as needed.
        Me.DdvPhysicianTableAdapter.Fill(Me.RiSdataDataSet.ddvPhysician)
        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvYesNo' table. You can move, or remove it, as needed.
        Me.DdvYesNoTableAdapter.Fill(Me.RiSdataDataSet.ddvYesNo)
        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvResearcher' table. You can move, or remove it, as needed.
        Me.DdvResearcherTableAdapter.Fill(Me.RiSdataDataSet.ddvResearcher)
        'TODO: This line of code loads data into the 'RiSdataDataSet1.ddvResearcher' table. You can move, or remove it, as needed.
        Me.DdvResearcherTableAdapter.Fill(Me.RiSdataDataSet.ddvResearcher)
        'TODO: This line of code loads data into the 'RiSdataDataSet1.tbStuHpvAdEventsInterventions' table. You can move, or remove it, as needed.
        Me.TbStuHpvAdEventsInterventionsTableAdapter.Fill(Me.RiSdataDataSet.tbStuHpvAdEventsInterventions)
        'TODO: This line of code loads data into the 'RiSdataDataSet1.tbStuHpvAdEventsSymptoms' table. You can move, or remove it, as needed.
        Me.TbStuHpvAdEventsSymptomsTableAdapter.Fill(Me.RiSdataDataSet.tbStuHpvAdEventsSymptoms)
        'TODO: This line of code loads data into the 'RISdataDataSet.tbStuHpvAdEventsSymptoms' table. You can move, or remove it, as needed.
        Me.TbStuHpvAdEventsSymptomsTableAdapter.Fill(Me.RiSdataDataSet.tbStuHpvAdEventsSymptoms)
    End Sub
    Private Sub frmStuHpvAdverseEvent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            '* PROMPT IF THE USER WANTS TO SAVE THE CURRENT ADVENT EVENT
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            '* SAVE THE ADVERSE EVENT

            '* SAVE THE SYMPTOMS

            '* SAVE THE INTERVENTIONS
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            '* EXIT FORM WITHOUT SAVING
        Catch ex As Exception

        End Try
    End Sub
End Class