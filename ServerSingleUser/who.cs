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
    class who
    {
        public byte[] Buffer { get; set; }
        string Plaka, Latitude, LatPos, Longitude, LotPos, Speed, Course;
        DateTime zaman = new DateTime();
        internal RichTextBox displayTextBox;
        internal Label label3, label5;        
        ArrayList conn=new ArrayList();
        public ArrayList parca = new ArrayList();
        int concnt;
        string port;

        public who(Socket socket, RichTextBox Form_, Label lbl3, Label lbl5, int cnt)
        {            
            conn.Add(socket);
            displayTextBox = Form_;
            label3 = lbl3;
            label5 = lbl5;
            concnt = cnt;
        }

        public void read()
        {
            try
            {
                while (true)
                {
                    Socket connection = conn[conn.Count - 1] as Socket;
                    Buffer = new byte[connection.SendBufferSize];
                    int bytesRead = connection.Receive(Buffer);
                    byte[] formatted = new byte[bytesRead];
                    for (int i = 0; i < bytesRead; i++)
                    {
                        formatted[i] = Buffer[i];
                    }

                    string strData = Encoding.ASCII.GetString(formatted);                    
                    parcalamaca(strData);
                }
            }
            catch { }
        }

        public AracTakipDataContext database = new AracTakipDataContext(); 
        private delegate void DisplayDelege(string message);

        public void parcalamaca(string message)
        {
            try
            {
                if (displayTextBox.InvokeRequired)
                {
                    displayTextBox.Invoke(new DisplayDelege(parcalamaca), new object[] { message });
                }
                else
                {
                    //displayTextBox.AppendText("  " + message + "\n");
                    label3.Text = " connection done";
                    int leng = message.Length;
                    int pointCNT = 0;
                    int comaCNT = 0;
                    int[] comaPOS = new int[40];
                    for (int i = 0; i < leng; i++)
                    {
                        if (message[i] == '.')
                        {
                            pointCNT++;
                        }

                        if (message[i] == ',')
                        {
                            comaCNT++;
                            comaPOS[comaCNT - 1] = i;
                        }
                    }

                    if (pointCNT == 5)
                    {
                        zaman = DateTime.Now;
                        port = message.Substring(comaPOS[13] + 1, comaPOS[14] - comaPOS[13] - 1);
                        Plaka = message.Substring(comaPOS[12] + 1, comaPOS[13] - comaPOS[12] - 1);
                        Latitude = message.Substring(comaPOS[2] + 1, comaPOS[3] - comaPOS[2] - 1);
                        LatPos = message.Substring(comaPOS[3] + 1, comaPOS[4] - comaPOS[3] - 1);
                        Longitude = message.Substring(comaPOS[4] + 1, comaPOS[5] - comaPOS[4] - 1);
                        LotPos = message.Substring(comaPOS[5] + 1, comaPOS[6] - comaPOS[5] - 1);
                        Speed = message.Substring(comaPOS[6] + 1, comaPOS[7] - comaPOS[6] - 1);
                        Course = message.Substring(comaPOS[7] + 1, comaPOS[8] - comaPOS[7] - 1);
                        
                        TakipTablo ac = new TakipTablo();                        

                        if (Plaka.Length >= 1 && Latitude.Length >= 1 && LatPos.Length <= 1 &&
                            Longitude.Length >= 1 && LotPos.Length <= 1)
                        {
                            displayTextBox.AppendText("Port: " + port + " Plaka: " + Plaka.Trim() + " Latitude: " + Latitude.Trim() + "  LatPos: " + LatPos.Trim() + "  Longitude: " + Longitude.Trim() + "  LotPos: " + LotPos.Trim() + " Speed: " + Speed + " Course: " + Course + "  Time: " + zaman + " ");
                            label5.Text = concnt.ToString();
                            ac.PortNumber = port.TrimEnd();
                            ac.Plaka = Plaka.Trim();
                            ac.Latitude = Latitude.Trim();
                            ac.LatPos = LatPos.Trim();
                            ac.Longitude = Longitude.Trim();
                            ac.LonPos = LotPos.Trim();
                            ac.Speed = Speed;
                            ac.Course = Course;
                            ac.DateTime = zaman;

                            database.TakipTablos.InsertOnSubmit(ac);
                            database.SubmitChanges();
                            Plaka = null; Latitude = null; LatPos = null; Longitude = null; LotPos = null; message = null;
                        }
                    }
                }
            }
            catch { }
        }
        
    }
}

