Imports System.Net.Sockets
Imports System.Runtime.Serialization



Public Class Class1
    Dim Server As New TcpListener(8888)
    Dim client As TcpClient
    Sub Idk()
        client = Server.AcceptTcpClient()

    End Sub

End Class
