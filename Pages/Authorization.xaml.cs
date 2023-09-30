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

namespace TurAgency.pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorize(object sender, RoutedEventArgs e)
        {
            if(Login.Text == "root" && Password.Text == "12345")
            {
                classes.Manager.MainFrame.Navigate(new Admin());
            }
            if (Login.Text == "user" && Password.Text == "12345")
            {
                classes.Manager.MainFrame.Navigate(new User());
            }
        }
    }
}
