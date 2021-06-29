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

namespace TNN.Pages.MainWindow.EditPages
{
    /// <summary>
    /// Логика взаимодействия для TaslGrid.xaml
    /// </summary>
    public partial class TaslGrid : Page
    {
        CommentManagerEntities DB;
        public TaslGrid(int sv)
        {
            DB = new CommentManagerEntities();
            InitializeComponent();
            sve = sv;
            IC();
        }

        void IC()
        {
            var sv = DB.Task.Where(s => s.ID == sve).Include(pr => pr.Projects).Include(org => org.Organizations).Include(rpc => rpc.Response_Project_Company_).FirstOrDefault();
            Name.Text = sv.Name;
            Customer_ID.Content = sv.Organizations.Name;
            Performer_ID.Content = sv.Organizations.Name;
            Attachment.Text = sv.Attachment;
            Link_On_Documentation.Text = sv.Link_On_Documentation;
            Text.Text = sv.Text;
            Date_completion.Content = sv.Date_completion;
            Date_Create.Content = sv.Date_Create;
            Acceptance_status_ID.SelectedItem = sv.Acceptance_status.Name;
            Acceptance_status_ID.ItemsSource = DB.Acceptance_status.ToList();
            Response_project_company.ItemsSource = DB.Response_Project_Company_.ToList();
            Project_info.Content = sv.Projects.Name;
        }
        int sve;
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var sv = DB.Task.Where(s => s.ID == sve).Include(pr => pr.Projects).Include(org => org.Organizations).Include(rpc => rpc.Response_Project_Company_).FirstOrDefault();
            sv.Attachment = Attachment.Text;
            sv.Link_On_Documentation = Link_On_Documentation.Text;
            sv.Text = Text.Text; 
            sv.Name = Name.Text;
            sv.Acceptance_status_ID = (int)Acceptance_status_ID.SelectedValue;
            sv.Response_project_company_ID = (int)Response_project_company.SelectedValue;
            DB.SaveChanges();
            App.ParentMainMenuRef.GrideFrame.GoBack();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var sv = DB.Remark.Where(s => s.ID == sve).FirstOrDefault();
            DB.Remark.Remove(sv);
            DB.SaveChanges();
            App.ParentMainMenuRef.GrideFrame.GoBack();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.GoBack();
        }

    }
}
