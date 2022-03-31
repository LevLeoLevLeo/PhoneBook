using PhoneBook.Classes.Execution;
using PhoneBook.Classes.InitializationDescription;
using PhoneBook.MessageDialog.MessBox;
using System.Windows;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;

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
