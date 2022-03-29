using PhoneBook.Classes.Execution;
using PhoneBook.Classes.Support;
using PhoneBook.PageList.PageAuthReg;
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

namespace PhoneBook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationFrame.frame = FrmAuthReg;
            FrmAuthReg.Navigate(new PageAuth());
        }

        private void BtnAuthorize_Click(object sender, RoutedEventArgs e)
        {
            Execute.GoToAuthPage(BtnAuthorize, BtnRegistration);
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Execute.GoToRegPage(BtnAuthorize, BtnRegistration);
        }

        private void BtnCloseApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
