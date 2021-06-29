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
    public partial class AllRemarkSetPage : Page
    {
        public AllRemarkSetPage()
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            AllRemarkSet.ItemsSource = DB.Set_remarks.Include(Kit_status_ID => Kit_status_ID.Kit_status).ToList();
        }
        CommentManagerEntities DB;

        void Searh()
        {
            if (Search.Text == "")
            {
                AllRemarkSet.ItemsSource = DB.Set_remarks.Include(Kit_status_ID => Kit_status_ID.Kit_status).ToList();
            }
            else
            {
                AllRemarkSet.ItemsSource = DB.Set_remarks.Where(q => q.Comment.Contains(Search.Text)).ToList();
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Searh();
        }
    }
}
