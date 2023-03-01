using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Problem
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_Items showItems = new Show_Items();
            showItems.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Items manageItem = new Manage_Items();
            manageItem.ShowDialog();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Record_Sale record = new Record_Sale();
            try
            {
                record.ShowDialog();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Unavailable at the moment\nNo items are present");
            }
            
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            Products_Sold sold = new Products_Sold();
            sold.ShowDialog();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            Total_Sales total = new Total_Sales();
            total.ShowDialog();
        }
    }
}
