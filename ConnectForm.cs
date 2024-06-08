﻿using System;
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
        public ConnectForm()
        {
            InitializeComponent();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (ipTxt.Text == "ip сервера")
            {
            ipTxt.Text = "";
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (ipTxt.Text == "")
            {
                ipTxt.Text = "ip сервера";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (portTxt.Text == "порт сервера")
            {
                portTxt.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (portTxt.Text == "")
            {
                portTxt.Text = "порт сервера";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (nameTxt.Text == "имя")
            {
                nameTxt.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameTxt.Text = "имя";
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
    }
}
