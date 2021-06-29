using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TNN.Pages.MainWindow;

namespace TNN
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow ParentWindowRef;
        public static MainMenu ParentMainMenuRef;
        public static ProfilePage ParentProfilePageRef;
    }
}
