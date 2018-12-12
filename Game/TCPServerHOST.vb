Imports System.Net.Sockets
Module TCPServerHOST
    Sub Main()
        Dim ServerHost As New TcpListener(8888)
        Dim Client As New TcpClient
        ServerHost.Start()

        ' Client.Connect(ServerHost.AcceptSocket)

    End Sub
End Module
