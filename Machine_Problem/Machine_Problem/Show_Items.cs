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
    public partial class Show_Items : Form
    {
        public Show_Items()
        {
            InitializeComponent();
        }

        private void label3_Load(object sender, EventArgs e)
        {
            //label3.Text = File.ReadAllText("Item Inventory.txt");
            StreamReader allItems = new StreamReader("Item Inventory.txt");
            string[] yes = allItems.ReadToEnd().Split(',');
            allItems.Close();
            label3.Text = string.Join("                                    ", yes);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
