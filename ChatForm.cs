using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPChat
{
    public partial class ChatForm : Form
    {
        Chat Chat;
        public ChatForm(Chat chat)
        {
            Chat = chat;
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            Chat.RichTextBox = richTextBox1;
            Chat.Connect();
            this.Visible = false;
        }
    }
}
