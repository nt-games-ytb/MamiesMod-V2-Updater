using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Threading;
using System.CodeDom;
using System.Collections;
using System.Configuration;
using System.Deployment;
using System.Dynamic;
using System.Management;
using System.Net;
using System.Resources;
using System.Runtime;
using System.Security;
using System.Timers;
using System.Web;
using System.Windows;
using System.Xml;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.DesignerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Hosting;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Windows.Markup;
using System.Windows.Input;
using System.Net.Cache;
using System.Net.Sockets;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using New_Updater;
using System.IO.Compression;

namespace New_Updater
{
    public partial class Form1 : Form
    {
        WebClient client;
        WebClient client1;
        WebClient client2;
        WebClient client3;
        WebClient client4;
        WebClient client5;
        WebClient client6;
        WebClient client7;
        WebClient client8;
        WebClient client9;
        WebClient client10;

        public Form1()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            if (webClient.DownloadString("https://pastebin.com/raw/W4sN9mer").Contains("1"))
            {
                
            }
            else
            {
                if (MessageBox.Show("There are a new version of MamiesMod V2 Updater ! Would you like to download it ?", "MamiesMod V2", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        ExecuteAsAdmin("Updater of updater.exe");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            client1 = new WebClient();
            client1.DownloadProgressChanged += Client_DownloadProgressChanged1;
            client1.DownloadFileCompleted += Client_DownloadFileCompleted1;
            client2 = new WebClient();
            client2.DownloadProgressChanged += Client_DownloadProgressChanged2;
            client2.DownloadFileCompleted += Client_DownloadFileCompleted2;
            client3 = new WebClient();
            client3.DownloadProgressChanged += Client_DownloadProgressChanged3;
            client3.DownloadFileCompleted += Client_DownloadFileCompleted3;
            client4 = new WebClient();
            client4.DownloadProgressChanged += Client_DownloadProgressChanged4;
            client4.DownloadFileCompleted += Client_DownloadFileCompleted4;
            client5 = new WebClient();
            client5.DownloadProgressChanged += Client_DownloadProgressChanged5;
            client5.DownloadFileCompleted += Client_DownloadFileCompleted5;
            client6 = new WebClient();
            client6.DownloadProgressChanged += Client_DownloadProgressChanged6;
            client6.DownloadFileCompleted += Client_DownloadFileCompleted6;
            client7 = new WebClient();
            client7.DownloadProgressChanged += Client_DownloadProgressChanged7;
            client7.DownloadFileCompleted += Client_DownloadFileCompleted7;
            client8 = new WebClient();
            client8.DownloadProgressChanged += Client_DownloadProgressChanged8;
            client8.DownloadFileCompleted += Client_DownloadFileCompleted8;
            client9 = new WebClient();
            client9.DownloadProgressChanged += Client_DownloadProgressChanged9;
            client9.DownloadFileCompleted += Client_DownloadFileCompleted9;
            client10 = new WebClient();
            client10.DownloadProgressChanged += Client_DownloadProgressChanged10;
            client10.DownloadFileCompleted += Client_DownloadFileCompleted10;
            checkBox2.Checked = true;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void Client_DownloadFileCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            checkBox4.Checked = true;
        }

        private void Client_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            checkBox5.Checked = true;
        }

        private void Client_DownloadFileCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            checkBox6.Checked = true;
        }

        private void Client_DownloadFileCompleted4(object sender, AsyncCompletedEventArgs e)
        {
            checkBox7.Checked = true;
        }

        private void Client_DownloadFileCompleted5(object sender, AsyncCompletedEventArgs e)
        {
            checkBox8.Checked = true;
        }

        private void Client_DownloadFileCompleted6(object sender, AsyncCompletedEventArgs e)
        {
            checkBox9.Checked = true;
        }

        private void Client_DownloadFileCompleted7(object sender, AsyncCompletedEventArgs e)
        {
            checkBox10.Checked = true;
        }

        private void Client_DownloadFileCompleted8(object sender, AsyncCompletedEventArgs e)
        {
            checkBox11.Checked = true;
        }

        private void Client_DownloadFileCompleted9(object sender, AsyncCompletedEventArgs e)
        {
            checkBox12.Checked = true;
        }

        private void Client_DownloadFileCompleted10(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("MamiesMod V2 is updated !", "MamiesMod V2 [New Updater]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged1(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged2(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged3(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged4(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged5(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged6(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged7(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged8(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged9(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void Client_DownloadProgressChanged10(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                pourcentage.Text = label6.Text + $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/codes/AUMPDU.xml");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/codes/AUMPDU.xml");
                    label6.Text = "AUMPDU.xml - ";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/de/MamiesMod%20V2.resources.dll");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client1.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/de/MamiesMod V2.resources.dll");
                    label6.Text = "MamiesMod V2 [de] - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/it/MamiesMod%20V2.resources.dll");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client5.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/it/MamiesMod V2.resources.dll");
                    label6.Text = "MamiesMod V2 [it] - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/fr/MamiesMod%20V2.resources.dll");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client4.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/fr/MamiesMod V2.resources.dll");
                    label6.Text = "MamiesMod V2 [fr] - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/en/MamiesMod%20V2.resources.dll");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client2.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/en/MamiesMod V2.resources.dll");
                    label6.Text = "MamiesMod V2 [en] - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/Newtonsoft.Json.dll");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client9.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/Newtonsoft.Json.dll");
                    label6.Text = "Newtonsoft.Json.dll - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/BotwTrainer.exe");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client7.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/BotwTrainer.exe");
                    label6.Text = "BotwTrainer - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/ja/MamiesMod%20V2.resources.dll");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client6.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/ja/MamiesMod V2.resources.dll");
                    label6.Text = "MamiesMod V2 [ja] - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/codes.xml");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client8.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/codes.xml");
                    label6.Text = "codes - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/es/MamiesMod%20V2.resources.dll");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client3.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/es/MamiesMod V2.resources.dll");
                    label6.Text = "MamiesMod V2 [es] - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                try
                {
                    Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/MamiesMod%20V2.exe");
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client10.DownloadFileAsync(uri, @"C:/Program Files (x86)/MamiesMod V2/MamiesMod V2.exe");
                    label6.Text = "MamiesMod V2 - ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}
