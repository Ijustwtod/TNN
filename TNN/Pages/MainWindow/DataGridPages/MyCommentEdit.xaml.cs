using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TNN.Pages.MainWindow.DataGridPages
{
    public partial class MyCommentEdit : Page
    {
        CommentManagerEntities DB;
        public MyCommentEdit(string sv)
        {
            DB = new CommentManagerEntities();
            InitializeComponent();
            sve = sv;
            IC();
        }

        void IC()
        {
            var sv = DB.Remark.Where(s => s.Name == sve).FirstOrDefault();
            if(sv != null)
            {
                Name.Text = sv.Name;
                Expert_review.Text = sv.Expert_review;
                Expert_comment.Text = sv.Expert_comment;
                Response_status.ItemsSource = DB.Response_status.ToList();
                Response_project_company.ItemsSource = DB.Response_Project_Company_.ToList();
                Project_info.ItemsSource = DB.Project_Info.ToList();
                Branch_Id.ItemsSource = DB.Group.ToList();
                Set_Remarks_ID.ItemsSource = DB.Set_remarks.ToList();
            }
        }
        string sve;
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var sv = DB.Remark.Where(s => s.Name == sve).FirstOrDefault();
            sv.Name = Name.Text;
            sv.Expert_review = Expert_review.Text;
            sv.Expert_comment = Expert_comment.Text;
            sv.Response_project_company_ = (int)Response_project_company.SelectedValue;
            sv.Response_status = (int)Response_status.SelectedValue;
            sv.Project_info = (int)Project_info.SelectedValue;
            sv.Branch_Id = (int)Branch_Id.SelectedValue;
            sv.Set_Remarks_ID = (int)Set_Remarks_ID.SelectedValue;
            DB.SaveChanges();
            App.ParentMainMenuRef.GrideFrame.Navigate(new MyCommentPage());
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var sv = DB.Remark.Where(s => s.Name == sve).FirstOrDefault();
            DB.Remark.Remove(sv);
            DB.SaveChanges();
            App.ParentMainMenuRef.GrideFrame.Navigate(new MyCommentPage());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.GoBack();
        }
    }
}
