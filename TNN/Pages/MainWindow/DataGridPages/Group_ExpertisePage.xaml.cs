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

    public partial class Group_ExpertisePage : Page
    {
        public Group_ExpertisePage()
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            Load();
        }
        void Load()
        {
            Expertise.ItemsSource = DB.Group_Expertise.ToArray();
            CountElements.Content = $"(Всего элементов: {Expertise.Items.Count}) ";
        }
        CommentManagerEntities DB;
        void Searh()
        {
            if (Search.Text == "")
            {
                Load();
            }
            else
            {
                Expertise.ItemsSource = DB.Group_Expertise.Where(q => q.Name.Contains(Search.Text)).ToList();
                CountElements.Content = $"(Всего элементов: {Expertise.Items.Count}) ";
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Searh();
        }

        private void ResetSettings_Click(object sender, RoutedEventArgs e)
        {
            Search.Text = "";
            Load();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}

