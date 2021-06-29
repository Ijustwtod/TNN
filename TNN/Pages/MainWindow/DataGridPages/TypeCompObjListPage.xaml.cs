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
    /// Логика взаимодействия для TypeCompObjListPage.xaml
    /// </summary>
    public partial class TypeCompObjListPage : Page
    {
        CommentManagerEntities DB;
        public TypeCompObjListPage()
        {
            InitializeComponent();
            DB = new CommentManagerEntities();
            Load();
        }
        void Load()
        {
            TypeCompObjList.ItemsSource = DB.Type_complex__object.ToArray();
            CountElements.Content = $"(Всего элементов: {TypeCompObjList.Items.Count}) ";
        }

        void Searh()
        {
            if (Search.Text == "")
            {
                TypeCompObjList.ItemsSource = DB.Type_complex__object.ToList();
                CountElements.Content = $"(Всего элементов: {TypeCompObjList.Items.Count}) ";
            }
            else
            {
                TypeCompObjList.ItemsSource = DB.Type_complex__object.Where(q => q.Name.Contains(Search.Text)).ToList();
                CountElements.Content = $"(Всего элементов: {TypeCompObjList.Items.Count}) ";
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Searh();
        }

        private void ResetSettings_Click(object sender, RoutedEventArgs e)
        {
            Search.Text = "";
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}
