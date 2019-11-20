using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntier
{
    public partial class Form1 : Form
    {
        ServiceReference2.WebService2SoapClient client;

        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference2.WebService2SoapClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text =="")
            {
                MessageBox.Show("Veuillez renseigner le nom du pays !");
            } else
            {
                client.createPaysAsync(textBox1.Text);
            }
            //client.HelloWorld1Completed += Client_HelloWorld1Completed;
            //client.HelloWorld1Async();
        }

        //private void Client_HelloWorld1Completed(object sender, ServiceReference1.HelloWorld1CompletedEventArgs e)
        //{
        //    MessageBox.Show(e.Result);
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
