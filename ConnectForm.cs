using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPChat
{

    public partial class ConnectForm : Form
    {
        Chat Chat;
        string IpHint;
        string PortHint;
        string NameHint;
        Color ForeTextColor = Color.White;
        Color HintTextColor;

        public ConnectForm()
        {
            InitializeComponent();
            IpHint = ipTxt.Text;
            PortHint = portTxt.Text;
            NameHint = nameTxt.Text;
            HintTextColor = ipTxt.ForeColor;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (IpHint == ipTxt.Text)
            {
            ipTxt.Text = "";
            ipTxt.ForeColor = ForeTextColor;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (ipTxt.Text == "")
            {
                ipTxt.Text = IpHint;
                ipTxt.ForeColor = HintTextColor;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (portTxt.Text == PortHint)
            {
                portTxt.Text = "";
                portTxt.ForeColor = ForeTextColor;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (portTxt.Text == "")
            {
                portTxt.Text = PortHint;
                portTxt.ForeColor = HintTextColor;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (nameTxt.Text == NameHint)
            {
                nameTxt.Text = "";
                nameTxt.ForeColor = ForeTextColor;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameTxt.Text = NameHint;
                nameTxt.ForeColor = HintTextColor;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chat = new Chat();
            Chat.Host = ipTxt.Text;
            try
            {
                Chat.Port = int.Parse(portTxt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введен некорректный порт", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Chat.Name = nameTxt.Text;
            ChatForm chatForm = new ChatForm(Chat);
            chatForm.Show();
        }

        private void ipTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
