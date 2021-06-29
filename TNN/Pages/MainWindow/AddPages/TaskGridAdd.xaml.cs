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

namespace TNN.Pages.MainWindow.AddPages
{

    public partial class TaskGridAdd : Page
    {
        CommentManagerEntities DB;
        public TaskGridAdd()
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            IC();
        }

        void IC()
        {
            Customer_ID.ItemsSource = DB.Organizations.ToArray();
            Performer_ID.ItemsSource = DB.Organizations.ToArray();
            Project_info.ItemsSource = DB.Projects.ToArray();
            CauseCode.ItemsSource = DB.Cause.ToArray();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task();
            task.Name = Name.Text;
            task.Text = Text.Text;
            task.Attachment = Attachment.Text;
            task.Link_On_Documentation = Link_On_Documentation.Text;
            task.Date_completion = Date_completion.SelectedDate;
            task.Date_Create = DateTime.Now;
            task.Project_info_ID = (int)Project_info.SelectedValue;
            task.Customer_ID = (int)Customer_ID.SelectedValue;
            task.Performer_ID = (int)Performer_ID.SelectedValue;
            task.Cause_code_ID = (int)CauseCode.SelectedValue;
            task.Acceptance_status_ID = 2;
            task.Response_project_company_ID = 1;
            DB.Task.Add(task);
            DB.SaveChanges();
            App.ParentMainMenuRef.GrideFrame.GoBack();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.GoBack();
        }
    }
}
