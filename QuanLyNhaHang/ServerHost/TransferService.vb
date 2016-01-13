Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports System.ServiceProcess
Imports Library
Imports Remote

Public Class TransferService
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        Dim _Channel As New HttpChannel(12345)
        ChannelServices.RegisterChannel(_Channel)
        RemotingConfiguration.RegisterWellKnownServiceType(GetType(ServerObject), "TransferData", WellKnownObjectMode.Singleton)
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        Me.Stop()
    End Sub
End Class
