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

namespace TNN.Pages.Profile
{
   
    public partial class ProfileSettingsPage : Page
    {
        //Окно настроек профиля
        public ProfileSettingsPage(int UID)
        {
            InitializeComponent();
            UserID = UID;
        }
        int UserID;
        private void SLbtn_Click(object sender, RoutedEventArgs e)
        {
            //Отображение раздела "Вход и безопасность"
            SettingsPage.Content = new Settings.SecurityLoginPage(UserID);
        }

        private void PDbtn_Click(object sender, RoutedEventArgs e)
        {
            //Отображение раздела "Персональные данные"
            SettingsPage.Content = new Settings.PersonalDataPage(UserID);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            App.ParentProfilePageRef.ProfileFrame.Navigate(new MainPageProfile(UserID));
        }
    }
}
