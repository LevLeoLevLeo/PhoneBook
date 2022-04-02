using PhoneBook.Classes.Execution;
using PhoneBook.Classes.InitializationDescription;
using PhoneBook.Classes.Support;
using System.Windows;

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
            WindowTransfer.window = this;
            Init.WinAuthPage(FrmAuthReg);
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
