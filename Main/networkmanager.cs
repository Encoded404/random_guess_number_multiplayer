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
    Thread trd1 = new Thread(recieve_DontUseOutsideNetworkManagerClass);
    Socket hole1 = new Socket(SocketType.Stream, ProtocolType.Tcp);
    public bool connectToServer()
    {
        try
        {
            bool b = connect_DontUseOutsideNetworkManagerClass();
            if(!b)
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
        return true;
        //trd1.Start();
    }


    private void startRecievingData()
    {

    }
    IPEndPoint serverIp = new IPEndPoint(IPAddress.Parse("127.0.0.0"),4786);
    Socket hole2 = new Socket(SocketType.Stream, ProtocolType.Tcp);
    private bool connect_DontUseOutsideNetworkManagerClass()
    {
        try
        {
            hole2.Connect(serverIp);
        }
        catch
        {
            return false;
        }
        return true;
    }
    public void recieve_DontUseOutsideNetworkManagerClass()
    {
        byte[] bytes = new byte[2];
        hole2.Receive(bytes);
        playerString ps = new playerString();
        ps.playerID = Convert.ToUInt16(bytes[0]);
        ps.guessedNumber = Convert.ToUInt16(bytes[1]);
        //return ps;
    }
}

public class onlinePortListener
{
}