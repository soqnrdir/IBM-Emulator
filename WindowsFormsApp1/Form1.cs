﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int seq = 1;

        // (1) UdpClient 객체 성성
        UdpClient udp = new UdpClient();

        public DateTime localTime;
        public DateTime localDate;

        IPEndPoint multicastEP = new IPEndPoint(IPAddress.Parse("10.128.100.233"), 5500);
        

        string sendIp = "192.168.5.23";
        // string receiveIp = "10.128.100.233";
        string receiveIp = "";

        public Form1()
        {

            InitializeComponent();

            
        // IPEndPoint multicastEP = new IPEndPoint(IPAddress.Parse("10.128.101.145"), 5500);

            //int ifIndex = 4;
            //udp.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastInterface, (int)IPAddress.HostToNetworkOrder(ifIndex));
            //System.Diagnostics.Debug.WriteLine("ifIndex: " + ifIndex);

            textBox1.Text = seq.ToString();


            textBox3.Text = sendIp;
            textBox2.Text = receiveIp;

        }

        public static byte[] StringToByteArray(String hex)
        {
          int NumberChars = hex.Length;
          byte[] bytes = new byte[NumberChars / 2];
          for (int i = 0; i < NumberChars; i += 2)
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
          return bytes;
        }

        private byte toBCD(int val)
        {
            return (byte)(((val / 10) << 4) | (val % 10));
        }
        private byte getFireByte0()
        {
            byte val = 0;
            if (chkFire0.Checked)
                val |= 0x01;
            if (chkFire1.Checked)
                val |= 0x02;
            if (chkFire2.Checked)
                val |= 0x03;
            if (chkFire3.Checked)
                val |= 0x04;
            if (chkFire4.Checked)
                val |= 0x05;
            if (chkFire5.Checked)
                val |= 0x06;
            if (chkFire6.Checked)
                val |= 0x07;
            if (chkFire7.Checked)
                val |= 0x08;
            return val;
        }
        private byte getFireByte1()
        {
            byte val = 0;
            if (chkFire8.Checked)
                val |= 0x09;
            if (chkFire9.Checked)
                val |= 0x0A;
            return val;
        }

        private byte getPAByte0()
        {
            byte val = 0;
            if (chkPA0.Checked)
                val |= 0x01;
            if (chkPA1.Checked)
                val |= 0x02;
            if (chkPA2.Checked)
                val |= 0x03;
            if (chkPA3.Checked)
                val |= 0x04;
            if (chkPA4.Checked)
                val |= 0x05;
            if (chkPA5.Checked)
                val |= 0x06;
            if (chkPA6.Checked)
                val |= 0x07;
            if (chkPA7.Checked)
                val |= 0x08;
            return val;
        }
        private byte getPAByte1()
        {
            byte val = 0;
            if (chkPA8.Checked)
                val |= 0x09;
            if (chkPA9.Checked)
                val |= 0x0A;
            return val;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            byte[] dgram = new byte[42];

            dgram[0] = (byte)((seq >> 24) & 0xFF);
            dgram[1] = (byte)((seq >> 16) & 0xFF);
            dgram[2] = (byte)((seq >> 8) & 0xFF);
            dgram[3] = (byte)((seq >> 0) & 0xFF);


            string[] sendIpS = sendIp.Split('.');
            Console.WriteLine(sendIpS);
            string[] receiveIpS = textBox2.Text.Split('.');
            Console.WriteLine(receiveIpS);

            dgram[4] = (byte)Int32.Parse(sendIpS[0]);
            dgram[5] = (byte)Int32.Parse(sendIpS[1]);
            dgram[6] = (byte)Int32.Parse(sendIpS[2]);
            dgram[7] = (byte)Int32.Parse(sendIpS[3]);

            dgram[8] = (byte)Int32.Parse(receiveIpS[0]);
            dgram[9] = (byte)Int32.Parse(receiveIpS[1]);
            dgram[10] = (byte)Int32.Parse(receiveIpS[2]);
            dgram[11] = (byte)Int32.Parse(receiveIpS[3]);

            dgram[12] = 0x20;

            localTime = DateTime.Now;
            localDate = DateTime.Now;

            dgram[13] = toBCD(localDate.Year % 100);
            dgram[14] = toBCD(localDate.Month);
            dgram[15] = toBCD(localDate.Day);

            dgram[16] = toBCD(localDate.Hour);
            dgram[17] = toBCD(localDate.Minute);
            dgram[18] = toBCD(localDate.Second);

            dgram[19] = 1;
            dgram[20] = 0x31;
            dgram[21] = 100; 
            dgram[22] = 150;
            dgram[23] = 200;
            dgram[24] = 01;
            dgram[23] = 0x4D;
            dgram[24] = 0x5D;
            dgram[25] = 0x31;
            dgram[26] = 100;
            dgram[27] = 150;
            dgram[28] = 200;
            dgram[29] = 01;
            dgram[30] = getFireByte0();
            dgram[31] = getFireByte1();
            dgram[32] = getPAByte0();
            dgram[33] = getPAByte1();
            dgram[34] = 0x4D;
            dgram[35] = 0x00;
            dgram[36] = 0x00;
            dgram[37] = 0x00;
            dgram[38] = 0x00;
            dgram[39] = 0x00;
            dgram[40] = 0x00;
            dgram[41] = 0x00;

            // (3) Multicast 그룹에 데이타그램 전송      
            udp.Send(dgram, dgram.Length, multicastEP);

            MessageBox.Show("전송");

            string dgramStr = Encoding.Default.GetString(dgram);
            Console.WriteLine("SEND: " + BitConverter.ToString(dgram).Replace("-", ""));

            //Console.WriteLine(dgramStr);
            Thread.Sleep(1000);
            
            seq++;
            textBox1.Text = seq.ToString();
        }
    }
}