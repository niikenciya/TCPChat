using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client
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

        public int Connect()
        {
            var ipEndPoint = new IPEndPoint(IPAddress.Parse(Host), Port);
            TcpClient client = new TcpClient();
            // TODO сервера нет
            try
            {
                client.Connect(ipEndPoint);
            }
            catch
            {
                MessageBox.Show("Сервера не существует или он не доступен", "Не удалось подключиться к серверу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
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
                MessageBox.Show(serverHello.Split('|')[1], "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            listener = new Thread(Listen);
            listener.Start();
            return 0;
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
                // TODO сервер выключился раньше клиента
                UpdateLog(streamReader.ReadLine());
            }
        }
        private void UpdateLog(string message) 
        {
            RichTextBox.AppendText(message + "\n");
        }
    }
}
