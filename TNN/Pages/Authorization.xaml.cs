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
    public partial class Authorization : Page
    {
        CommentManagerEntities DB;

        public object AuthWindowFrame { get; private set; }

        public Authorization()
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            if (Login_textbox.Text == "" || Password_box.Password == "")
            {
                ErrorLabel.Content = "Поля не могут быть пустыми";
            }
            else
            {
                Login();
            }
        }

        public void Login()
        {
            if (DB.Users.Select(w => w.Login + w.Password).Contains(Login_textbox.Text + Password_box.Password))
            {
                var user = DB.Users.Where(q => q.Login == Login_textbox.Text && q.Password == Password_box.Password).FirstOrDefault();
                MainMenu MM = new MainMenu(user.Emp_ID);
                MM.Show();
                App.ParentWindowRef.Close();
            }
            else
            {
                ErrorLabel.Content = "Неверный логин или пароль";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu MM = new MainMenu(4);
            MM.Show();
            App.ParentWindowRef.Close();
        }

        private void FogotPassword_Click(object sender, MouseButtonEventArgs e)
        {
            App.ParentWindowRef.AuthWindowFrame.Navigate(new RestorePassword_Page());
        }

       
    }

}