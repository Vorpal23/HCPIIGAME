Imports System.Net.Sockets
Imports System.IO
Imports System.Net
Imports System.Threading

Public Class Host
    Property Ip As IPAddress

    Dim ServerHost As New TcpListener(8887)
    Dim Client As New TcpClient
    Dim soc As Socket
    Dim hostn As String = System.Net.Dns.GetHostName()

    Dim ns As NetworkStream
    Dim br As BinaryReader
    Dim bw As BinaryWriter
    Public Sub New(pip As String)
        Dim ListenerThread As New Thread(New ThreadStart(AddressOf Listening))
        ListenerThread.Start()

        Ip = IPAddress.Parse(pip)


        ServerHost.Start()
        MsgBox("Server started")
        soc = ServerHost.AcceptSocket
        ns = New NetworkStream(soc)
    End Sub
    Private Sub Listening()

    End Sub




    Sub rd()
        Dim s As String = br.ReadString
    End Sub
    Sub wr(s As String)
        bw.Write(s)
    End Sub
End Class