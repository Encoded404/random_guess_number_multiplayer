using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public struct playerString
{
    public uint playerID;
    public int guessedNumber;
}

public class networkManager
{
    Thread trd1 = new Thread(onlinePortListener.Main);
    Socket hole1 = new Socket(SocketType.Stream, ProtocolType.Tcp);
}

public class onlinePortListener
{
    public static playerString Main()
    {
        IPEndPoint serverIp = new IPEndPoint(IPAddress.Parse("127.0.0.0"),4786);
        Socket hole2 = new Socket(SocketType.Stream, ProtocolType.Tcp);
        byte[] bytes = new byte[2];
        hole2.Connect(serverIp);
        hole2.Receive(bytes);
        playerString ps = new playerString();
        ps.playerID = Convert.ToUInt16(bytes[0]);
        ps.guessedNumber = Convert.ToUInt16(bytes[1]);
        return ps;
    }
}