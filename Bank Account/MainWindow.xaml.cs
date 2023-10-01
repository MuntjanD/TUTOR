using System;
using AccountLibrary;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web.UI.MobileControls;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;

namespace Bank_Account
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Account account;
        ArrayList accounts = new ArrayList();



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (check_mult.IsChecked == false)
            {

                // CREATING OF OBJECT!!!!!!!!!!!!!!!!!!
                account = new Account();
                Account.Count++;
                label_Count.Content = "Count" + Account.Count.ToString();
                account.Name = text_Name.Text;
                account.Number = text_No.Text;
                account.Balnace = Convert.ToDouble(text_Balance.Text);
                MessageBox.Show("Account has been created.");
                text_Name.Text = "";
                text_Balance.Text = "";
                text_No.Text = "";
                list.Items.Add(account.printString());
                accounts.Add(account);
            }
            else
            {
                AccountMult accountmult = new AccountMult(text_Name.Text, text_No.Text, double.Parse(text_Balance.Text), int.Parse(text_Currency.Text));
                Account.Count++;
                list.Items.Add((accountmult.printString()));
                accounts.Add(accountmult);
            }
        }

        private void Show_Balance_Click(object sender, RoutedEventArgs e)
        {
            //if (account == null)
            //{
            //    MessageBox.Show("Account is not Created.");
            //}
            //else
            //    Label_Account.Content = account.printString();

            string search_name = test.Text;
            //for (int i = 0; i < accounts.Count; i++)
            //    if (search_name == (accounts[i] as Account).name)
            //        MessageBox.Show("Balnace is " + (accounts[i] as Account).Balnace);


            foreach (Account a in accounts)
                if (search_name == (a.Name))
                    if (MessageBox.Show("balance is" + a.printString() + "/n" +
                         "You want to add money?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        a.Balnace = Convert.ToDouble(text_Balance.Text);
                    }

            UpdateList();

        }

        private void UpdateList()
        {
            list.Items.Clear();
            foreach (Account a in accounts)
                list.Items.Add(a.printString());
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = list.SelectedIndex;
            if (index >= 0)
            {
                Account a = accounts[index] as Account;
                text_Name.Text = a.Name;
                text_No.Text = a.Name;
                text_Balance.Text = a.Balnace.ToString();
            }

        }

        private void Edit_button_Click(object sender, RoutedEventArgs e)
        {
            int index = list.SelectedIndex;

            (accounts[index] as Account).Name = text_Name.Text;
            (accounts[index] as Account).Number = text_No.Text;
            (accounts[index] as Account).Balnace = double.Parse(text_Balance.Text);
            UpdateList();
        }

        private void list_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            int index = list.SelectedIndex;
            if (index >= 0)
            {
                Account a = accounts[index] as Account;
                text_Name.Text = a.Name;
                text_No.Text = a.Number;
                text_Balance.Text = a.Balnace.ToString();
            }
        }









        private void check_mult_Click(object sender, RoutedEventArgs e)
        {
            text_Currency.Visibility = Visibility.Visible;
            label_currency.Visibility = Visibility.Visible;
            if (check_mult.IsChecked == true)
            {
                label_currency.Visibility = Visibility.Visible;

            }
            else
            {
                label_currency.Visibility = Visibility.Hidden;
            }
            if (check_mult.IsChecked == true)
            {
                text_Currency.Visibility = Visibility.Visible;

            }
            else
            {
                text_Currency.Visibility = Visibility.Hidden;
            }
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = new FileStream("MyAccounts.dat", FileMode.OpenOrCreate, FileAccess.Write);
            foreach (Account a in accounts)
            {
                bf.Serialize(file, a);
            }
            file.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream file = new FileStream("MyAccounts.dat", FileMode.OpenOrCreate, FileAccess.Read);
            //Account a = (Account)bf.Deserialize(file);
            //while(a != null)
            //{
            //    new_list.Items.Add(a.printString());
            //    if (file.Position != file.Length)
            //        a = (Account)bf.Deserialize(file);
            //    else a = null;
            //}
            
            //file.Close();
        }

        private void Read_File_Click(object sender, RoutedEventArgs e)
        {
            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream file = new FileStream("MyAccounts.dat", FileMode.OpenOrCreate, FileAccess.Read);
            //Account a = (Account)bf.Deserialize(file);
            //while (a != null)
            //{
            //    new_list.Items.Add(a.printString());
            //    if (file.Position != file.Length)
            //        a = (Account)bf.Deserialize(file);
            //    else a = null;
            //}

            //file.Close();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = new FileStream("MyAccounts.dat", FileMode.Open, FileAccess.Read);
            while(file.Position != file.Length)
            {
                Account a = (Account)bf.Deserialize(file);
                new_list.Items.Add(a.printString());
            }
            file.Close();
        }
    }
}
