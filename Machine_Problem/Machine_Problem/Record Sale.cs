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
    public partial class Record_Sale : Form
    {

        public Record_Sale()
        {
            InitializeComponent();
            StreamReader items = new StreamReader("Item Inventory.txt");
            string item = items.ReadLine();
            string[] info={};
            listBox1.Items.Add("Products:\t".PadLeft(5)+"\t"+"Quantity:".PadRight(30));
            if (item != null)
            {
                while (item != null)
                {
                    info = item.Split(',');
                    listBox1.Items.Add(info[0] + "\t" + "\t    " + info[1]);
                    item = items.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("There are no items for sale");
                this.Close();
            }
            items.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string quantity = textBox2.Text;
            string date = textBox3.Text;
            string price = textBox4.Text;
            int q = 0;

            TextWriter txt = new StreamWriter("Transaction Records.txt",true);
            TextWriter sales = new StreamWriter("Records.txt", true);
            txt.WriteLine("Date of Purchase: " + date);
            txt.WriteLine("Product Name: " + name + "\t" + "Quantity: " + quantity);
            txt.WriteLine("Price: " + price);
            txt.WriteLine();
            sales.WriteLine(name+','+quantity+','+price+','+ date);
            txt.Close();
            sales.Close();
            MessageBox.Show("Successfully Added");
            q = int.Parse(quantity);
            Update_Stock(name,q);
            
        }
        private void Update_Stock(string name, int q)
        {
            StreamReader items = new StreamReader("Item Inventory.txt");
            string item = items.ReadLine();
            string[] find_name;
            string updated="";
            while (item != null)
            {
                find_name = item.Split(',');
                if (name == find_name[0])
                {
                    string replace_text = item;
                    int quantity = int.Parse(find_name[1]) - q;
                    updated = find_name[0] + "," + quantity + "," + find_name[2];
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
                products = products.Replace(item, updated);
                File.WriteAllText("Item Inventory.txt", products);
            }
            catch (IOException)
            {
                items.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            StreamReader allItems = new StreamReader("Item Inventory.txt");
            string items = allItems.ReadLine();
            string[] product;
            string input_prod=textBox1.Text;
            string quantity = textBox2.Text;
            int q;
            if (int.TryParse(quantity, out q))
            {
                while (items != null)
                {
                    product = items.Split(',');
                    if (input_prod == product[0])
                    {
                        int price = int.Parse(product[2]);
                        textBox4.Text = (price * q).ToString();
                        break;
                    }
                    else
                    {
                        items = allItems.ReadLine();
                    }
                }
                allItems.Close();
            }
            else
            {
                errorProvider1.SetError(textBox2, "Invalid Input");
            }


        }
    }
}
