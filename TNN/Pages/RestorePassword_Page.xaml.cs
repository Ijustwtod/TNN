using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TNN.Pages
{
    public partial class RestorePassword_Page : Page
    {
        CommentManagerEntities DB;
        public RestorePassword_Page()
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
        }

        //Генератор кода верификации
        int CodeGenerator()
        {
            Random ran = new Random();
            int Code = ran.Next(1000, 9999);
            return Code;
        }


        //Проверка на наличие пользователя, переход в окно проверки кода
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (Email_txtbox.Text != "" && DB.Employee.Select(u => u.E_mail).Contains(Email_txtbox.Text))
            {
                string email = Email_txtbox.Text;
                int code = CodeGenerator();
                App.ParentWindowRef.AuthWindowFrame.Navigate(new SendVerificationCode_Page(email, code));
            }
            else
            {
                EnterEmail_lbl.Content = "Пользователь не найден";
            }
        }

        //Отмена
        private void Cancel_btnSU_Click_1(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.AuthWindowFrame.Navigate(new Authorization());
        }
    }
}
