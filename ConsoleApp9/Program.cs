
class DataSender
{
    public delegate void SendDataDelegate();

    public void SendData(SendDataDelegate sendDataDelegate)
    {
        Console.WriteLine("Preparing to send data...");
        sendDataDelegate(); 

    }
}

class ServerDataSender : DataSender
{
    public delegate void SendToServerDelegate();

    public void SendToServer(SendToServerDelegate sendToServerDelegate)
    {
        Console.WriteLine("Preparing to send data to server...");
        sendToServerDelegate(); 
    }
}

class Program
{
    static void Main()
    {
        DataSender dbSender = new DataSender();
        ServerDataSender serverSender = new ServerDataSender();

        dbSender.SendData(() => Console.WriteLine("Data sent to database\n"));

        serverSender.SendToServer(() => Console.WriteLine("Data sent to server\n"));
    }
}
