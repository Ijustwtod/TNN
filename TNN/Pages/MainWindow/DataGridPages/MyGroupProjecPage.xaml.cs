using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TNN.Pages.MainWindow.DataGridPages
{
    public partial class MyGroupProjecPage : Page
    {
        CommentManagerEntities DB;
        public MyGroupProjecPage(int ID)
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            AllProjectList.ItemsSource = DB.Projects.Include(Organizations => Organizations.Organizations)
                .Include(Employee => Employee.Employee)
                .Include(Project_Status => Project_Status.Project_Status)
                .Include(Object => Object.Project_Info).ToList();
            CountElements.Content = $"(Всего элементов: {AllProjectList.Items.Count}) ";
        }

        void Searh()
        {
            if (Search.Text == "")
            {
                AllProjectList.ItemsSource = DB.Projects.Include(Organizations => Organizations.Organizations)
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

        }
    }
}
