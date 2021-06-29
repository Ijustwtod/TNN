using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

    public partial class SendVerificationCode_Page : Page
    {
        public SendVerificationCode_Page(string email, int Code)
        {
            InitializeComponent();
            SendVerCode(email, Code);
            Email = email;
        }
        string Email;
        //Функция отправки кода верификации пользователю
        void SendVerCode(string email, int Code)
        {
            MailAddress from = new MailAddress("denistestmail2@gmail.com", "TEST");
            MailAddress to = new MailAddress(email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Код подтверждения для восстановления данных";
            m.Body = $"{Code}";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("denistestmail2@gmail.com", "QWEasd456");
            smtp.EnableSsl = true;
            smtp.Send(m);
            CheckCode(email, Code);
        }

        //Отображение информаци пользователю
        void CheckCode(string email, int Code)
        {
            VerCode_lbl.Content = $"На ваш E-mai был отправлен код подтвержденя, введите его в поле ниже";
            code = Code;
        }
        int code;
        //Проверка совпадения кодов
        bool CheckVerCode(int Code)
        {
            if (Code == Convert.ToInt32(VerCode_txtbox.Text))
            {
                return true;
            }
            return false;
        }

        //Переход в окно изменения пароля
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            VerCode_lbl.Content = "Code";
            if (CheckVerCode(code))
            {
                App.ParentWindowRef.AuthWindowFrame.Navigate(new ChangePassword(Email));
            }
            else
            {
                MessageBox.Show("Неверный код подтверждения");
            }
        }

        //Отмена 
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            App.ParentWindowRef.AuthWindowFrame.Navigate(new Authorization());
        }
    }
}
