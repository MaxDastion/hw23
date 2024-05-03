
class DataSender
{
    public delegate void SendDataDelegate();

    public void SendData(SendDataDelegate sendDataDelegate)
    {
        Console.WriteLine("Preparing to send data...");
        sendDataDelegate(); 
        Console.WriteLine("Data sent successfully.\n");
    }
}

class ServerDataSender : DataSender
{
    public delegate void SendToServerDelegate();

    public void SendToServer(SendToServerDelegate sendToServerDelegate)
    {
        Console.WriteLine("Preparing to send data to server...");
        sendToServerDelegate(); 
        Console.WriteLine("Data sent to server successfully.\n");
    }
}

class Program
{
    static void Main()
    {
        DataSender dbSender = new DataSender();
        ServerDataSender serverSender = new ServerDataSender();

        dbSender.SendData(() => Console.WriteLine("Data sent to database"));

        serverSender.SendToServer(() => Console.WriteLine("Data sent to server"));
    }
}
