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
    public partial class Total_Sales : Form
    {
        public Total_Sales()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sales = new StreamReader("Records.txt");
            string transaction = sales.ReadLine();
            string[] info;
            string[] items;
            int total_quantity=0, total_earned=0;
            while (transaction != null)
            {
                info = transaction.Split(',');
                total_quantity = total_quantity + int.Parse(info[1]);
                total_earned = total_earned + int.Parse(info[2]);
                transaction = sales.ReadLine();
            }
            sales.Close();
            listBox1.Items.Add("Amount of the items purchased: "+total_quantity);
            listBox1.Items.Add("Total price of the items purchased: " + total_earned);
            listBox1.Items.Add("Average price of the items purchased: " + total_earned/total_quantity);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
