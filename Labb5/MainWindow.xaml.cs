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
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            string usersInputName = usersName.Text;
            string usersInputEmail = usersEmail.Text;
            userList.Add(new User(usersInputName, usersInputEmail));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Displays the username of the user in the first index of userList.
            MessageBox.Show(userList[0].UserName, "User");
        }

        //private void PrintList()
        //{
        //    foreach (var item in userList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
