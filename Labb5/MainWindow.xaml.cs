using System;
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

namespace Labb5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> userList = new List<User>();
        int userListIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            if (UsersInputIsInvalid(usersName.Text, usersEmail.Text)) { }
            else
            {
                string usersInputName = usersName.Text.Trim();
                string usersInputEmail = usersEmail.Text.Trim();

                userList.Add(new User(usersInputName, usersInputEmail));

                listBox.Items.Add(userList[userListIndex].UserName);
                userListIndex++;


            }
        }


        private bool UsersInputIsInvalid(string usersInputName, string usersInputEmail)
        {
            if (string.IsNullOrEmpty(usersInputName) ||
                string.IsNullOrEmpty(usersInputEmail) ||
                string.IsNullOrWhiteSpace(usersInputName) ||
                string.IsNullOrWhiteSpace(usersInputEmail))
            {
                MessageBox.Show("Null or single WhiteSpace not allowed in either field.\n" +
                    "Try again.", "INVALID_INPUT");

                return true;
            }
            else
                return false;
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (UsersInputIsInvalid(usersName.Text, usersEmail.Text)) { }
            else
            {
                string usersInputName = usersName.Text.Trim();
                string usersInputEmail = usersEmail.Text.Trim();

                userList[listBox.SelectedIndex].UserName = usersInputName;
                userList[listBox.SelectedIndex].UserEmail = usersInputEmail;

                listBox.Items.Insert(listBox.SelectedIndex, userList[listBox.SelectedIndex].UserName);
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }
    }
}
