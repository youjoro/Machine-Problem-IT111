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
    public partial class Manage_Items : Form
    {
        public Manage_Items()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert_Products showProd = new Insert_Products();
            showProd.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove_Products file = new Remove_Products();

            file.ShowDialog();
            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
