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
    public partial class Insert_Products : Form
    {
        public Insert_Products()
        {
            InitializeComponent();
        }

        private void btnSubmitprod_Click(object sender, EventArgs e)
        {
            Insert_Products prodForm = new Insert_Products();
            string prodName = txtProdname.Text;
            string prodNum = txtProdnum.Text;
            string prod_Price = prod_price.Text;
            int price=0,quantity;
            if (int.TryParse(prod_Price, out price)&&int.TryParse(prodNum, out quantity))
            {
                StreamWriter txt = new StreamWriter("Item Inventory.txt", true);
                txt.Write("\n"+prodName + "," + quantity + ","+price);
                txt.Close();
                string message = ("Successfully Added to the Inventory");
                MessageBox.Show(message);
            }
            else
            {
                errorProvider1.SetError(prod_price, "One or both inputs are invalid");
                errorProvider1.SetError(txtProdnum, "One or both inputs are invalid");
            }
  
        }

        private void btnExitprod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insert_Products_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
