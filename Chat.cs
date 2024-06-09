using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace TCPChat
{
    public class Chat
    {
        public string Host;
        public int Port;
        public string Name;
        private StreamWriter streamWriter;
        private StreamReader streamReader;
        public RichTextBox RichTextBox;
        private bool connected;
        private Thread listener;
        private delegate void UpdateLogCallback(string log);

        public void Connect()
        {
            var ipEndPoint = new IPEndPoint(IPAddress.Parse(Host), Port);
            TcpClient client = new TcpClient();
            client.Connect(ipEndPoint);
            streamWriter = new StreamWriter(client.GetStream());
            streamReader = new StreamReader(client.GetStream());
            SendName();
            string serverHello = streamReader.ReadLine();
            if (serverHello[0] == '1') // первый символ - код ответа, 1 - успешно.
            { 
                UpdateLog("Подключено");
                connected = true;
            }
            else
            {
                
            }
            listener = new Thread(Listen);
            listener.Start();
        }
        private void SendName()
        {
            streamWriter.WriteLine(Name);
            streamWriter.Flush();
        }
        private void Listen()
        {
            while (connected)
            {
                UpdateLog(streamReader.ReadLine());
            }
        }
        private void UpdateLog(string message) 
        {
            RichTextBox.AppendText(message + "\n");
        }
    }
}
