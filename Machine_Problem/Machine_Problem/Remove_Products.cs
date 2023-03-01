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
using System.Windows.Forms.VisualStyles;

namespace Machine_Problem
{
    public partial class Remove_Products : Form
    {
        public Remove_Products()
        {
            InitializeComponent();
        }

        private void btnExitremove_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            string to_delete = listBox1.GetItemText(listBox1.SelectedItem);
            Update_Stock(to_delete);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            
            string message = "Successfully deleted";
            MessageBox.Show(message);
        }

        private void Update_Stock(string name)
        {
            StreamReader items = new StreamReader("Item Inventory.txt");
            string item = items.ReadLine();
            string[] find_name;
            string[] del_prod = name.Split(',');
            while (item != null)
            {
                find_name = item.Split(',');
                if (del_prod[0] == find_name[0])
                {  
                    break;
                }
                else
                {
                    item = items.ReadLine();
                }
            }
            items.Close();
            try
            {
                string products = File.ReadAllText("Item Inventory.txt");
                products = products.Replace(item, string.Empty);
                File.WriteAllText("Item Inventory.txt", products.Trim());
            }
            catch (IOException)
            {
                items.Close();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(name+" does not exist");
            }

        }



        private void listbox1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Item Inventory.txt");
            listBox1.Items.AddRange(lines);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
