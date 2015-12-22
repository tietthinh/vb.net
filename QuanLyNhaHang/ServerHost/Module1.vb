Imports System.ServiceProcess
Module Module1
    Sub Main()
        Dim _ServicesToRun() As ServiceBase
        _ServicesToRun = New ServiceBase() {New TransferService()}
        ServiceBase.Run(_ServicesToRun)
    End Sub
End Module