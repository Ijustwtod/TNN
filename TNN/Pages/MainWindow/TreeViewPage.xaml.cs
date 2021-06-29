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

namespace TNN.Pages.MainWindow
{
    public partial class TreeViewPage : Page
    {
        public TreeViewPage(int ID)
        {
            InitializeComponent();
            idd = ID;
        }
        int idd;
        private void MyComment_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.MyCommentPage());
        }

        private void CommentMyGroup_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.MyGroupCommentPage(idd));
        }

        private void CauseLoadBtn_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.CauseListPage());
        }

        private void OrgLoadBtn_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.OrganizatoinListPage());
        }

        private void TypeCompObhLoadBtn_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.TypeCompObjListPage());
        }

        private void AllProject_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.AllProjectPage());      
        }

        private void MyProject_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.MyProjectList(idd));
        }

        private void MyGroupProject_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.MyGroupProjecPage(idd));
        }

        private void Intask_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.InTaskPage());
        }

        private void ExpertiseLoadbtn_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.ExpertiseGrid());
        }

        private void ExpertiseGrLoadbtn_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.Group_ExpertisePage());
        }

        private void AllRemarkSetPage_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.AllRemarkSetPage());
        }

        private void MyRemarkSetPage_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.MyRemarkSetPage());
        }

        private void MyGroupRemarkSetPage_click(object sender, MouseButtonEventArgs e)
        {
            App.ParentMainMenuRef.GrideFrame.Navigate(new DataGridPages.MyGroupRemarkSetPage(idd));
        }
    }
}
