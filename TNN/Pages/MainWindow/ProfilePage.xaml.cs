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

namespace TNN.Pages.MainWindow
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        CommentManagerEntities DB;
        public ProfilePage(int UID)
        {
            //Определение родительского окна
            App.ParentProfilePageRef = this;
            DB = new CommentManagerEntities();
            InitializeComponent();
            UserID = UID;
            //Загрузка окна "Главное окно профиля"
            ProfileFrame.Content = new Pages.Profile.MainPageProfile(UID); 
        }
        int UserID;
        private void BackProfile_Click(object sender, RoutedEventArgs e)
        {
            //Переход в главное окно программы
            App.ParentMainMenuRef.MainWindowFrame.Navigate(new TreeViewPage(UserID));  
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //Переход в окно настроек профиля
            ProfileFrame.Content = new Pages.Profile.ProfileSettingsPage(UserID);
        }
    }
}
