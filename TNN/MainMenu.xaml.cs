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
using System.Windows.Shapes;

namespace TNN
{
    public partial class MainMenu : Window
    {

        CommentManagerEntities DB;
        public MainMenu(int IDD)
        {
            InitializeComponent();
            DB = new CommentManagerEntities();

            //Определение родительского окна
            App.ParentMainMenuRef = this;
            //Загрузка окна "TreeView"
            MainWindowFrame.Content = new Pages.MainWindow.TreeViewPage(IDD);
            //Определение пользователя
            var user = DB.Employee.Where(w => w.ID == IDD).FirstOrDefault();
            //Вывод информации пользователя
            qwe.Content= ($"{user.Fname_} " + $"{ user.Lname}");
            userid = IDD;
        }
        int userid;
        private void GoToProfile(object sender, RoutedEventArgs e)
        {
            //Загрузка окна "Профиль"
            MainWindowFrame.Content = new Pages.MainWindow.ProfilePage(userid);
            //Обнуление текущего окна
            GrideFrame.Content = null;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //Кнопка смены пользователя в контекстном меню
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            //Кнопка выхода в контекстном меню
            Application.Current.Shutdown();
        }

        private void Mainbtn(object sender, MouseButtonEventArgs e)
        {
            MainWindowFrame.Content = new Pages.MainWindow.TreeViewPage(userid);
        }
    }
}
