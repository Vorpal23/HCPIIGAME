Imports System.Net.Sockets
Imports System.IO
Imports System.Net
Public Class Client
    Dim tc As TcpClient = New TcpClient()
    Dim ns As NetworkStream
    Dim br As BinaryReader
    Dim bw As BinaryWriter
    Sub Connect()
        tc.Connect("10.24.81.72", 8887)
        ns = tc.GetStream
        br = New BinaryReader(ns)
        bw = New BinaryWriter(ns)

    End Sub
    Sub send(str As String)
        bw.Write(str)
    End Sub
    Sub recieve()
        MsgBox(br.ReadString)
    End Sub
End Class
