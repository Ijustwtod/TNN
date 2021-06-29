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
    public partial class InTaskPage : Page
    {
        CommentManagerEntities DB;
        public InTaskPage()
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            Load();
        }

       void Load()
       {
            TaskGrid.ItemsSource = DB.Task.Include(Organizations => Organizations.Organizations)
               .Include(Cause => Cause.Cause)
               .Include(Acceptance_status => Acceptance_status.Acceptance_status)
               .Include(Response_Project_Company_ => Response_Project_Company_.Response_Project_Company_)
               .Include(Project_Info => Project_Info.Projects).ToList();
            CountElements.Content = $"(Всего элементов: {TaskGrid.Items.Count}) ";

       }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            TaskGrid.ItemsSource = DB.Task.Include(Organizations => Organizations.Organizations)
              .Include(Cause => Cause.Cause)
              .Include(Acceptance_status => Acceptance_status.Acceptance_status)
              .Include(Response_Project_Company_ => Response_Project_Company_.Response_Project_Company_)
              .Include(Project_Info => Project_Info.Projects).ToList();

            if (Search.Text == "")
            {
                TaskGrid.ItemsSource = DB.Task.Where(q => q.Name.Contains(Search.Text)).Include(Organizations => Organizations.Organizations)
               .Include(Cause => Cause.Cause)
               .Include(Acceptance_status => Acceptance_status.Acceptance_status)
               .Include(Response_Project_Company_ => Response_Project_Company_.Response_Project_Company_)
               .Include(Project_Info => Project_Info.Projects).ToList();
                CountElements.Content = $"(Всего элементов: {TaskGrid.Items.Count}) ";
            }
            else
            {
                TaskGrid.ItemsSource = DB.Task.Where(q => q.Name.Contains(Search.Text)).ToArray();
                CountElements.Content = $"(Всего элементов: {TaskGrid.Items.Count}) ";
            }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new AddPages.TaskGridAdd());
        }

        int TaskId;
        private void TaslGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var task = TaskGrid.SelectedItem as Task;
            TaskId = task.ID;
        }

        private void ResetSettings_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            try
            {
                App.ParentMainMenuRef.GrideFrame.Navigate(new EditPages.TaslGrid(TaskId));
            }
            catch
            {

            }
        }
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}