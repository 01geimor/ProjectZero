using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace _09_Arduino
{
    public partial class Arduino : Form
    {
        string analogPin;
        string gv = "getvalue#";
        Thread childGraphic;
        Graphics g;
        Pen p;
        int graphicdiv;
        string gs;
        int interval;

        public Arduino()
        {
            InitializeComponent();
        }

        string[] a;

        private void Arduino_Load(object sender, EventArgs e)
        {
            a = SerialPort.GetPortNames();
            cmb_COM.Items.AddRange(a);
            graphicdiv = 1024 / pb_GGraphic.Height - 10;
            p = new Pen(Color.Red, 3);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (btn_Connect.Text == "Connect")
            {
                try
                {
                    Convert.ToInt32(cmb_Baud.Text);
                }
                catch
                {
                    cmb_Baud.Text = "9600";
                }

                try
                {
                    sP1 = new SerialPort(cmb_COM.Text, Convert.ToInt32(cmb_Baud.Text));
                    btn_Connect.Text = "Disconnect";
                    InOff(false);
                    sP1.Open();
                }
                catch
                {
                    MessageBox.Show("COM muss ausgewählt werden!");
                }
            }
            else
            {
                sP1.Close();
                InOff(true);
                btn_Connect.Text = "Connect";
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string s;
            try
            {
                s = txt_Eingabe.Text;
                sP1.WriteLine(s);
                txt_Eingabe.Text = null;
                ltb_Ausgabe.Items.Add("[Master]" + s);
            }
            catch
            {
                MessageBox.Show("Eingabe Fehlerhaft");
            }
        }

        private void InOff(bool b)
        {
            cmb_Baud.Enabled = b;
            cmb_COM.Enabled = b;
            btn_Refresh.Enabled = b;
            gpb_Arduino.Enabled = !b;
            tc_Interface.Enabled = !b;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_COM.Items.Clear();
            string[] a = SerialPort.GetPortNames();
            cmb_COM.Items.AddRange(a);
        }

        private void btn_GCreate_Click(object sender, EventArgs e)
        {
            analogPin = cmb_Ganalogpins.Text;
            g = pb_GGraphic.CreateGraphics();
            childGraphic = new Thread(this.createGraphic);
            childGraphic.Start();
        }

        public void createGraphic()
        {
            int y1 = 0, y2, x1 = 1;
            string s = String.Empty;

            while (true)
            {
                sP1.WriteLine(gv + analogPin);

                s = gs;
                
                try
                {
                    y2 = Convert.ToInt32(s);
                    Draw(x1, y1, x1 + 1, y2);
                }
                catch
                {

                }
                gs = null;
                Thread.Sleep(interval);
            }
        }

        private void Draw(float x1, float y1, float x2, float y2)
        {
            y1 = Heights(y1);
            y2 = Heights(y2);
            g.DrawLine(p, x1, y1, x2, y2);
        }

        private float Heights(float y)
        {
            y /= graphicdiv;
            y *= -1;
            y -= pb_GGraphic.Height;

            return y;
        }

        private void tb_ValueTimer_Scroll(object sender, EventArgs e)
        {
            interval = tb_ValueTimer.Value;
        }

        delegate void ShowDataCallBack(string recieved);

        private void sP1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string s = sP1.ReadExisting();
            if (s != String.Empty)
            {
                this.BeginInvoke(new ShowDataCallBack(DataReciever), new object[] { s });
                ltb_Ausgabe.Items.Add("[Slave]" + s);
            }
        }

        private void DataReciever(string data)
        {
            try
            {
                if (data.Substring(0,4) == ">" + analogPin + "=")
                {
                    gs = data.Substring(4);
                }
                else
                {
                    ltb_Ausgabe.Text = data;
                }
            }
            catch
            {

            }

            
        }
    }
}