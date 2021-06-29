using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TNN.Pages.Profile.Settings
{
    public partial class PersonalDataPage : Page
    {
        //Раздел настройки профиля "Персональные данные"
        CommentManagerEntities DB;
        public PersonalDataPage(int ID)
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            EmplID = ID;
            //Определение пользователя
            var Empl = DB.Employee.Where(em => em.ID == EmplID).FirstOrDefault();
            //Отображение информации пользователя
            Fname.Text = Empl.Fname_;
            Lname.Text = Empl.Lname;
            Sname.Text = Empl.Sname;
            ImageSource image;
            if (Empl.Photo != "")
            {
                image = new BitmapImage(new Uri(Empl.Photo));
                PhotoEdit.Source = image;
            }
        }
        int EmplID;

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //Определение пользователя
            var Empl = DB.Employee.Where(em => em.ID == EmplID).FirstOrDefault();
            //Изменение данных в БД
            Empl.Fname_ = Fname.Text;
            Empl.Lname = Lname.Text;
            Empl.Sname = Sname.Text;
            if(photop!="") Empl.Photo = photop;
            //Сохранение измененённых данных в БД
            DB.SaveChanges();
        }

        private void ME(object sender, MouseEventArgs e)
        {
            PhotoEdit.Opacity = 0.3;
            rec.Opacity = 1;
            uploadphotolbl.Opacity = 1;
        }

        private void ML(object sender, MouseEventArgs e)
        {
            rec.Opacity = 0;
            PhotoEdit.Opacity = 1;
            uploadphotolbl.Opacity = 0;
        }
        string photop;
        private void MD(object sender, MouseButtonEventArgs e)
        {
            
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "Изображения(*.JPG; *.PNG)| *.JPG; *.PNG",
                CheckFileExists = true,
                Title = "Выберете изображение"
            };

            if (file.ShowDialog() == true)
            {
                photop = file.FileName;
            }
            var Empl = DB.Employee.Where(em => em.ID == EmplID).FirstOrDefault();
            DB.SaveChanges();
        }
        private void BackProfile_Click(object sender, RoutedEventArgs e)
        {
            App.ParentMainMenuRef.MainWindowFrame.Content = new MainWindow.TreeViewPage(EmplID);
        }
    }
}
