Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.ServiceProcess

Public Class ProjectInstaller

    Public Sub New()
        'This call is required by the Component Designer.
        InitializeComponent()
        'Add initialization code after the call to InitializeComponent

    End Sub
    Public Overrides Sub Install(stateSaver As IDictionary)
        MyBase.Install(stateSaver)
        Dim _Controller As New ServiceController("TransferService")
        _Controller.Start()
    End Sub
    Private Sub ServiceProcessInstaller1_AfterInstall(sender As Object, e As InstallEventArgs) Handles ServiceProcessInstaller1.AfterInstall

    End Sub

    Private Sub ServiceInstaller1_AfterInstall(sender As Object, e As InstallEventArgs) Handles ServiceInstaller1.AfterInstall

    End Sub
End Class
