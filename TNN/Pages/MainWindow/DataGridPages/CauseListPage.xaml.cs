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

namespace TNN.Pages.MainWindow.DataGridPages
{
    public partial class CauseListPage : Page
    {
        CommentManagerEntities DB;
        public CauseListPage()
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            Load();
        }

        void Load()
        {
            CauseList.ItemsSource = DB.Cause.ToArray();
            CountElements.Content = $"(Всего элементов: {CauseList.Items.Count}) ";
        }

        void Searh()
        {
            if (Search.Text == "")
            {
                Load();
            }
            else
            {
                CauseList.ItemsSource = DB.Cause.Where(q => q.Name.Contains(Search.Text)).ToArray();
                CountElements.Content = $"(Всего элементов: {CauseList.Items.Count}) ";
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Searh();
        }
        private void Refresh_click(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}
