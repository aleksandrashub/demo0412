using Avalonia.Controls;
using demo02121.Models;
using Metsys.Bson;
using System.Collections.Generic;
using System.Linq;

namespace demo02121
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            List<User> users = Helper.user11037.Users.ToList();
            bool access = false;
            string passwordStr = passwd.Text;
            string loginStr = login.Text;
            foreach (User user in users)
            {

                if (user.Login == loginStr && user.Passwd == passwordStr)
                {
                    Helper.curruser = user;
                    access = true;
                }
            }
            if (access)
            {
                CurrentZayavki currentZayavki = new CurrentZayavki();
                currentZayavki.Show();
                this.Close();
            }

        }

        private void Reg_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

            Reg reg = new Reg();
            reg.Show();
            this.Close();
        }


        private void Guest_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            CurrentZayavki currentZayavki = new CurrentZayavki();
            currentZayavki.Show();
            this.Close();
        }
    }
}