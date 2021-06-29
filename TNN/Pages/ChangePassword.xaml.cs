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

namespace TNN.Pages
{
    public partial class ChangePassword : Page
    {
        CommentManagerEntities DB;
        public ChangePassword(string email)
        {
            InitializeComponent();
            Email = email;
            DB = new CommentManagerEntities();
        }

        string Email;
        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            ShowPass.Text = ChangePasswordFirst.Password;
            ChangePasswordFirst.Visibility = Visibility.Collapsed;
            ShowPass.Visibility = Visibility.Visible;
        }

        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangePasswordFirst.Password = ShowPass.Text;
            ShowPass.Visibility = Visibility.Collapsed;
            ChangePasswordFirst.Visibility = Visibility.Visible;
        }


        private void Check_match(object sender, RoutedEventArgs e)
        {
            if (ChangePasswordFirst.Password == ChangePasswordSecond.Password)
            {
                Checked_match.Content = "Пароли совпадают";
                Checked_match.Foreground = Brushes.Green;
                ChangePasswordSecond.BorderBrush = Brushes.Green;
                ChangePasswordFirst.BorderBrush = Brushes.Green;
            }
            else
            {
                Checked_match.Foreground = Brushes.Red;
                ChangePasswordSecond.BorderBrush = Brushes.Red;
                ChangePasswordFirst.BorderBrush = Brushes.Red;
                Checked_match.Content = "Пароли не совпадают";
            }
        }

        void ChangePaword(string Email)
        {
            var Empl = DB.Employee.Where(e => e.E_mail == Email).FirstOrDefault();
            var User = DB.Users.Where(u => u.Emp_ID == Empl.ID).FirstOrDefault();
            User.Password = ChangePasswordFirst.Password;
            DB.SaveChanges();
            MessageBox.Show("Пароль изменён");
        }
        private void Ready_Click(object sender, RoutedEventArgs e)
        {
            if (ChangePasswordFirst.Password != "" && ChangePasswordSecond.Password != "")
            {
                ChangePaword(Email);
                App.ParentWindowRef.AuthWindowFrame.Navigate(new Authorization());
            }
            else
            {
                Checked_match.Content = "Поля не могут быть пустыми";
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.AuthWindowFrame.Navigate(new Authorization());
        }
    }
}
