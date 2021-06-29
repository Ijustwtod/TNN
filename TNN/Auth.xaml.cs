using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace TNN
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            App.ParentWindowRef = this;
            InitializeComponent();
            AuthWindowFrame.Content = new Pages.Authorization();
        }
    }
}
