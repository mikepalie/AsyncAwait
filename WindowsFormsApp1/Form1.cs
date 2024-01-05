using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<string> task = new Task<string>(GetData);
            task.Start();

            string result = await task;

            textBox1.Text += result; 
        }

        public string GetData()
        {
            Thread.Sleep(5000);
            return "Some Text";
        }

    }
}
