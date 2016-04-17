'Josh Gibbs
'12 October 2010
'System information
'Version 0.2.6

'To-Do list
'--Make pgbRAM.maximum = *AMOUNT OF RAM*
'--Make ping get average in 5 seconds
'--Make adjustable refresh speed
'--Make lblPing say disconnected if GetPing = False
'--Name everything
'--Make better error handeling system
'--Make better interface

'gets temperature from System.Management .NET Reference
Imports System
Imports System.Management

Public Class frmMain

    'this gets ping value (Function)
    Public Shared Function GetPingMs(ByRef hostNameOrAddress As String)
        Try
        Dim ping As New System.Net.NetworkInformation.Ping
            Return ping.Send("208.67.222.222").RoundtripTime
        Catch ex As Exception
            Return "error"
        End Try
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Try
            'gets and displays CPU Load
            Dim CPU As Integer = CDec(PerformanceCounter1.NextValue.ToString())
            CPU = 100 - CPU
            lblCPUUsage.Text = CPU.ToString() & "%"
            ProgressBar1.Value = CPU.ToString

            'gets and displays RAM info *****max needs to = RAM*****
            Dim RAM As Integer = CDec(PerformanceCounter2.NextValue.ToString())
            lblRAM.Text = RAM.ToString() & "MB"
            ProgressBar2.Value = RAM.ToString

            'gets and displays temperature info
            Dim searcher As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature")
            For Each queryObj As ManagementObject In searcher.Get()
                Dim temperature As Double = CDbl(queryObj("CurrentTemperature"))
                temperature = (temperature - 2732) / 10.0
                lblCPUTemp.Text = temperature.ToString() & "*C"
                ProgressBar3.Value = temperature.ToString
            Next

            'this displays ping value
            lblPing.Text = GetPingMs("208.67.222.222") & "ms"
            ProgressBar4.Value = GetPingMs("208.67.222.222")

            'displays error, if any
        Catch err As ManagementException
            Timer1.Enabled = False
            MsgBox("There was an error: " & err.Message & "Try running as an administraitor! Or something just went terrible wrong")
            End
        End Try
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
