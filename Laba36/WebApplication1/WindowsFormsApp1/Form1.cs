using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        WebService.WebService1SoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new WebService.WebService1SoapClient();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int numberX = int.Parse(xText.Text);
            int numberY = int.Parse(yText.Text);
            resultText.Text = client.Add(numberX, numberY).ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int numberX = int.Parse(xText.Text);
            int numberY = int.Parse(yText.Text);
            resultText.Text = client.Sub(numberX, numberY).ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int numberX = int.Parse(xText.Text);
            int numberY = int.Parse(yText.Text);
            resultText.Text = client.Mult(numberX, numberY).ToString();
        }

        
    }
}
