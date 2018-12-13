Imports System.Net.Sockets
Imports System.IO
Imports System.Net


Module TCPServerHOST
    Sub Main()
        Dim hostn As String = Dns.GetHostName

        Dim ip As IPAddress = IPAddress.Parse(System.Net.Dns.GetHostByName(hostn).AddressList(0).ToString())
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim ServerHost As New TcpListener(ip, 8888)
        Dim Client As New TcpClient
        Dim soc As Socket

        ServerHost.Start()
        MsgBox("Server started")
        MsgBox(ip.ToString)
        soc = ServerHost.AcceptSocket
        ns = New NetworkStream(soc)
        bw = New BinaryWriter(ns)
        br = New BinaryReader(ns)

        Dim s As String = br.ReadString
        bw.Write(s)


        ' Client.Connect(ServerHost.AcceptSocket)

    End Sub
End Module
