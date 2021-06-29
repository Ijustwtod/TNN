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
    public partial class MainPageProfile : Page
    {
        CommentManagerEntities DB;
        public MainPageProfile(int ID)
        {
            DB = new CommentManagerEntities();
            InitializeComponent();
            var Empl = DB.Employee.Where(u => u.ID == ID).FirstOrDefault();
            var gr = DB.Group.Where(g => g.ID == Empl.Group_Id).FirstOrDefault();
            FullName.Content = Empl.Fname_ + " " + Empl.Lname + " " + Empl.Sname;
            Group.Content = gr.Name;
            UID = ID;
            Image(Empl.Photo);
        }
        void Image(string photo)
        {
            if (photo != "")
            {
                Uri uri = new Uri(photo);
                BitmapImage bitmap = new BitmapImage(uri);
                Image img = new Image();
                PhotoProfile.Source = bitmap;
            }
        }
        int UID;
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            App.ParentProfilePageRef.ProfileFrame.Navigate(new ProfileSettingsPage(UID));   
        }
    }
}
