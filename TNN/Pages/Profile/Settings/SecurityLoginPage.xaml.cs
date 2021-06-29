using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TNN.Pages.Profile.Settings
{
    //Раздел настройки профиля "Персональные данные"
    public partial class SecurityLoginPage : Page
    {

        CommentManagerEntities DB;
        public SecurityLoginPage(int UID)
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            UserID = UID;
            //Определение пользователя
            var Empl = DB.Employee.Where(u => u.ID == UID).FirstOrDefault();
            var User = DB.Users.Where(u => u.Emp_ID == UID).FirstOrDefault();

            //Отображение информации пользователя
            EmailPr.Content = Empl.E_mail;
            LoginPr.Content = User.Login;
        }
        int UserID;
        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            //Меню измененения пароля
            PasswordPOP.IsOpen = true;
        }

        private void ChangeLogin_Click(object sender, RoutedEventArgs e)
        {
            //Меню измененения логина
            LoginPOP.IsOpen = true;
        }

        private void EmailChange_Click(object sender, RoutedEventArgs e)
        {
            //Меню измененения эл.почты
            EmailPop.IsOpen = true;
        }
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
            //Проверка данных на совпадение 
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
        void ChangePaword()
        {
            //Определение пользователя
            var User = DB.Users.Where(u => u.Emp_ID == UserID).FirstOrDefault();
            //Изменение данных в БД
            User.Password = ChangePasswordFirst.Password;
            //Сохранение БД
            DB.SaveChanges();
            MessageBox.Show("Пароль изменён");

            //Отчистка полей
            ChangePasswordFirst = null;
            ChangePasswordSecond = null;
            Checked_match = null;
        }
        private void Ready_Click(object sender, RoutedEventArgs e)
        {
            //Волтдация полей
            if (ChangePasswordFirst.Password != "" && ChangePasswordSecond.Password != "")
            {
                ChangePaword();
            }
            else
            {
                Checked_match.Content = "Поля не могут быть пустыми";
            }
        }

        private void ChangeEMailReady_Click(object sender, RoutedEventArgs e)
        {
            if (NewEmail.Text != "")
            {
                //Определение пользователя
                var Empl = DB.Employee.Where(u => u.ID == UserID).FirstOrDefault();
                //Изменение данных в БД
                Empl.E_mail = NewEmail.Text;
                //Сохранение БД
                DB.SaveChanges();
                MessageBox.Show("E-mail изменён");
                //Отчистка полей
                NewEmail.Text = null;

                EmailPr.Content = Empl.E_mail;

            }
        }
        private void ChangeLogReady_Click(object sender, RoutedEventArgs e)
        {
            if (NewLogin.Text != "")
            {
                //Определение пользователя
                var User = DB.Users.Where(u => u.Emp_ID == UserID).FirstOrDefault();
                //Изменение данных в БД
                User.Login = NewLogin.Text;
                //Сохранение БД
                DB.SaveChanges();
                MessageBox.Show("Логин изменён");
                //Отчистка полей
                NewLogin.Text = null;
                //Отображение новых данных
                LoginPr.Content = User.Login;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            //Вернуться в профиль
            App.ParentProfilePageRef.ProfileFrame.Navigate(new MainPageProfile(UserID));
        }
    }
}
