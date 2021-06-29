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
    public partial class MyProjectList : Page
    {
        CommentManagerEntities DB;
        public MyProjectList(int Id)
        {
            InitializeComponent();
            Load();
            ID = Id;
        }
        int ID;

        void Load()
        {
            DB = new CommentManagerEntities();
            AllProjectList.ItemsSource = DB.Projects.Where(q => q.Project_manager == ID)
                .Include(Organizations => Organizations.Organizations)
                .Include(Employee => Employee.Employee)
                .Include(Project_Status => Project_Status.Project_Status)
                .Include(Object => Object.Project_Info).ToList();
            CountElements.Content = $"(Всего элементов: {AllProjectList.Items.Count}) ";
        }
        void Searh()
        {
            if (Search.Text == "")
            {
                AllProjectList.ItemsSource = DB.Projects.Where(q => q.Project_manager == ID)
                .Include(Organizations => Organizations.Organizations)
                .Include(Employee => Employee.Employee)
                .Include(Project_Status => Project_Status.Project_Status)
                .Include(Object => Object.Project_Info).ToList();
            }
            else
            {
                switch (AdvancedSearchCmb.SelectedIndex)
                {

                    case 0:
                        AllProjectList.ItemsSource = DB.Projects.Where(q => q.Name.Contains(Search.Text))
                            .Include(Organizations => Organizations.Organizations)
                            .Include(Employee => Employee.Employee)
                            .Include(Project_Status => Project_Status.Project_Status)
                            .Include(Object => Object.Project_Info).ToList();
                        break;
                    case 1:
                        AllProjectList.ItemsSource = DB.Projects.Where(q => q.Code.Contains(Search.Text))
                            .Include(Organizations => Organizations.Organizations)
                            .Include(Employee => Employee.Employee)
                            .Include(Project_Status => Project_Status.Project_Status)
                            .Include(Object => Object.Project_Info).ToList();
                        break;
                    case 2:
                        AllProjectList.ItemsSource = DB.Projects.Where(q => q.Contract_number == Convert.ToInt32(Search.Text))
                            .Include(Organizations => Organizations.Organizations)
                            .Include(Employee => Employee.Employee)
                            .Include(Project_Status => Project_Status.Project_Status)
                            .Include(Object => Object.Project_Info).ToList();
                        break;
                    case 3:
                        AllProjectList.ItemsSource = DB.Projects.Where(q => q.Year == Convert.ToInt32(Search.Text))
                            .Include(Organizations => Organizations.Organizations)
                            .Include(Employee => Employee.Employee)
                            .Include(Project_Status => Project_Status.Project_Status)
                            .Include(Object => Object.Project_Info).ToList();
                        break;
                }
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Searh();
        }

        private void AllProjectList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = AllProjectList.SelectedItem as Projects;
        }

        private void ResetSettings_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}
