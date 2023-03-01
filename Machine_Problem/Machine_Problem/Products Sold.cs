using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Problem
{
    public partial class Products_Sold : Form
    {
        public Products_Sold()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader items = new StreamReader("Transaction Records.txt");
            string item = items.ReadLine();
            while (item != null)
            {
                listBox1.Items.Add(item);
                item = items.ReadLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
