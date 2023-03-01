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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            File_Handling files = new File_Handling();
            files.Instantiate_Files();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File_Handling file = new File_Handling();
            string username = textBox1.Text;
            string password = textBox2.Text;
            file.check_login(username, password);
            textBox1.Clear();
            textBox2.Clear();
            
        }

        public void see_error(string text)
        {
            this.label3.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
