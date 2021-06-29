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
    /// <summary>
    /// Логика взаимодействия для OrganizatoinListPage.xaml
    /// </summary>
    public partial class OrganizatoinListPage : Page
    {
        CommentManagerEntities DB;
        public OrganizatoinListPage()
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            Load();
        }

        void Load()
        {
            OrganizatoinList.ItemsSource = DB.Organizations.ToArray();
            CountElements.Content = $"(Всего элементов: {OrganizatoinList.Items.Count}) ";
        }
  
        void Searh()
        {
            if (Search.Text == "")
            {
               OrganizatoinList.ItemsSource = DB.Organizations.ToList();
                CountElements.Content = $"(Всего элементов: {OrganizatoinList.Items.Count}) ";
            }
            else
            {
                OrganizatoinList.ItemsSource = DB.Organizations.Where(q => q.Name.Contains(Search.Text)).ToList();
                CountElements.Content = $"(Всего элементов: {OrganizatoinList.Items.Count}) ";
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Searh();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void ResetSettings_Click(object sender, RoutedEventArgs e)
        {
            Search.Text = "";
            Load();
        }
    }
}
