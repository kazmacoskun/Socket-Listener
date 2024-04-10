using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;


namespace ServerSingleUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ArrayList players = new ArrayList();
        public ArrayList playerThreads = new ArrayList();
        public ArrayList readThread = new ArrayList();
        public ArrayList listen = new ArrayList();
        public int cnt = 0;
        string portNumber;
        public AracTakipDataContext PoPl = new AracTakipDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter Port number or Car number");
                }
                else
                {

                   portNumber = textBox1.Text;                   
                   readThread.Add(new Thread(new ThreadStart(RunServer)));
                   Thread read = readThread[readThread.Count - 1] as Thread;
                   read.Start();                   
                   listBox1.Items.Add ("\r\n"+ textBox1.Text);
                   textBox1.Text = "";
                   notifyIcon1.Text = "SERVER LISTENER";
                }
            }
            catch { }
        }
        
        public void RunServer()
        {
            try
            {
                listen.Add(new TcpListener(IPAddress.Any, Convert.ToInt32(portNumber)));
                TcpListener listener = listen[listen.Count-1] as TcpListener;
                listener.Start();
                while (true)
                {
                    players.Add(new who(listener.AcceptSocket(), displayTextBox, label3, label5, players.Count + 1));
                    who value = players[players.Count-1] as who;
                    playerThreads.Add( new Thread(new ThreadStart(value.read)));
                    Thread tre = playerThreads[playerThreads.Count-1] as Thread;
                    tre.Start();                    
                }
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                int a = 1000;
                notifyIcon1.ShowBalloonTip(a, "SERVER LISTENER", "Program çalışıyor.\n", ToolTipIcon.Info);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
        }

        private void displayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count != 0)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);                    
                    button4.Enabled = false;
                }
                else
                    MessageBox.Show("No Item");
            }
            catch { }
        }

        private void displayTextBox_TextChanged_1(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == 100)
            {
                displayTextBox.Clear();
                cnt = 0;
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortPlaka pp = new PortPlaka();
            pp.PortNumber = listBox1.Items[listBox1.SelectedIndex].ToString().Trim();
            pp.Plaka = textBox2.Text;
            PoPl.PortPlakas.InsertOnSubmit(pp);
            PoPl.SubmitChanges();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var plakalar = from a in PoPl.PortPlakas
                           select a;
            dataGridView1.DataSource = plakalar;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //PortPlaka pp = new PortPlaka();

            var plakalar = from a in PoPl.PortPlakas
                           where a.Plaka.Contains(textBox2.Text)
                           select a;
            PoPl.PortPlakas.DeleteAllOnSubmit(plakalar);
            PoPl.SubmitChanges();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var plakalar = from a in PoPl.PortPlakas
                           where a.PortNumber==textBox3.Text
                           select a;
            dataGridView1.DataSource = plakalar;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


}

