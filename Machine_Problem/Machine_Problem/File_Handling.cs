using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Machine_Problem
{
    class File_Handling
    {
        public void new_account()
        {
            FileCheck();
            string acc_username = " ", acc_password = " ";

            Console.Write("Enter new approved username: ");
            acc_username = Console.ReadLine();
            Console.Write("Enter password: ");
            acc_password = Console.ReadLine();


            StreamWriter customer_Write = new StreamWriter("Customer.txt", true);

            customer_Write.WriteLine(acc_username+','+acc_password);
            customer_Write.Close();

        }
        public void Instantiate_Files()
        {
            checkInventory();
            transactionRecords();
        }
        public void check_login(string username, string password)
        {
            FileCheck();
            string account = " ";
            StreamReader text_reader = new StreamReader("Accounts.txt");
            account = text_reader.ReadLine();

            if (account == null)
            {
                FileCheck();
            }
            else
            {
                while (account != null)
                {
                    string[] credentials = account.Split(',');
                    if (username == credentials[0]&&password==credentials[1])
                    {
                        Main_Menu menu = new Main_Menu();
                        menu.Show();
                        text_reader.Close();
                        break;
                    }
                    else
                    {
                        account = text_reader.ReadLine();
                    }
                }
            }
            
        }
        private void FileCheck()
        {
            try
            {
                FileStream fs = new FileStream("Accounts.txt", FileMode.Open);
                fs.Close();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unable to access file");
            }
            catch (FileNotFoundException)
            {
                FileStream FC = new FileStream("Accounts.txt", FileMode.CreateNew);
                FC.Close();
            }
            catch (IOException)
            {
                
            }

        }
        private void checkInventory()
        {
            try
            {
                FileStream fs = new FileStream("Item Inventory.txt", FileMode.Open);
                fs.Close();
            }
            
            catch (FileNotFoundException)
            {
                FileStream fc = new FileStream("Item Inventory.txt", FileMode.CreateNew);
                fc.Close();
            }

        }
        private void transactionRecords()
        {

            try
            {
                FileStream fs = new FileStream("Transaction Records.txt", FileMode.Open);
                fs.Close();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unable to Access File");
            }
            catch (FileNotFoundException)
            {
                FileStream fc = new FileStream("Transaction Records.txt", FileMode.CreateNew);
                fc.Close();
            }
        }


    }
}
