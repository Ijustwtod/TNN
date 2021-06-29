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
using System.Data.Entity;

namespace TNN.Pages.MainWindow.DataGridPages
{

    public partial class MyGroupCommentPage : Page
    {
        CommentManagerEntities DB;
        public MyGroupCommentPage(int ID)
        {
            InitializeComponent();
            DB = new CommentManagerEntities();

          
            Id = ID;
            Load();
        }

        void Load()
        { 
            //Определение пользователя
            //Вывод данных по отделу пользователя  таблицу 
            var User = DB.Employee.Where(q => q.ID == Id).FirstOrDefault();
            CommentList.ItemsSource = DB.Remark.Include(Rs => Rs.Response_status1).
              Include(Project_info => Project_info.Projects).
              Include(Set_Remarks_ID => Set_Remarks_ID.Set_remarks).
              Include(Response_project_company => Response_project_company.Response_Project_Company_1).
              Include(Branch_Id => Branch_Id.Group).Where(q => q.Branch_Id == User.Group_Id).ToArray();

            FilterRSCmb.ItemsSource = DB.Set_remarks.ToList();
            FilterStatusCmb.ItemsSource = DB.Response_status.ToList();
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //Переход в окно редактирования записи
            App.ParentMainMenuRef.GrideFrame.Navigate(new EditPages.MyGroupCommentEdit(SV));
        }
        string SV;
        int Id;


        //Выбор столбца в таблице
     
        //функция поиска
        void Searh()
        {
            var User = DB.Employee.Where(q => q.ID == Id).FirstOrDefault();
            if (Search.Text == "")
            {
                CommentList.ItemsSource = DB.Remark.ToArray();
            }
            else
            {
                CommentList.ItemsSource = DB.Remark.Where(q => q.Name.Contains(Search.Text) && q.Branch_Id == User.Group_Id).ToArray();
            }

        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Searh();
        }

        private void ResetSettings_Click(object sender, RoutedEventArgs e)
        {
            Load();
            FilterRSCmb.SelectedIndex = 0;
            FilterStatusCmb.SelectedIndex = 0;
        }

        private void FilterRSCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FilterRSCmb.SelectedIndex == 0)
            {
                Load();
            }
            var filt = FilterRSCmb.SelectedItem as Set_remarks;
            CommentList.ItemsSource = DB.Remark.Where(r => r.Set_Remarks_ID == filt.ID).Include(Rs => Rs.Response_status1).
             Include(Project_info => Project_info.Projects).
             Include(Set_Remarks_ID => Set_Remarks_ID.Set_remarks).
             Include(Response_project_company => Response_project_company.Response_Project_Company_1).
             Include(Branch_Id => Branch_Id.Group).ToList();
        }

        private void FilterStatusCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FilterStatusCmb.SelectedIndex == 0)
            {
                Load();
            }
            var filt = FilterRSCmb.SelectedItem as Acceptance_status;
            try
            {
                CommentList.ItemsSource = DB.Remark.Where(r => r.Response_status == filt.ID)
                    .Include(Rs => Rs.Response_status1)
                    .Include(Project_info => Project_info.Projects)
                    .Include(Set_Remarks_ID => Set_Remarks_ID.Set_remarks)
                    .Include(Response_project_company => Response_project_company.Response_Project_Company_1)
                    .Include(Branch_Id => Branch_Id.Group)
                    .ToList();
            }
            catch
            {

            }
        }
    }
}

