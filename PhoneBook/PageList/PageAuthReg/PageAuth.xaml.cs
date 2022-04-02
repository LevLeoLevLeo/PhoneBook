using PhoneBook.Classes.Execution;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFTextBoxHelp.Classes;

namespace PhoneBook.PageList.PageAuthReg
{
    /// <summary>
    /// Логика взаимодействия для PageAuth.xaml
    /// </summary>
    public partial class PageAuth : Page
    {
        public PageAuth()
        {
            InitializeComponent();
            TxbLogin.Text = "Логин или почта";
        }

        #region Placeholder
        private void TxbLogin_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbLogin, "Логин или почта");
        }

        private void TxbLogin_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbLogin, "Логин или почта");
        }

        private void TxbPassword_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderGotFocus(TxbPassword, PsbPassword, "Пароль");
        }

        private void TxbPassword_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderLostFocus(TxbPassword, PsbPassword);
        }
        #endregion
       
        #region ShowPass
        private void BtnShowPass_Click(object sender, RoutedEventArgs e)
        {
            WPFTextPassBox.ShowPassword(TxbPassword, PsbPassword);
        }

        private void BtnShowPass_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WPFTextPassBox.HidePassword(TxbPassword, PsbPassword);
        }

        private void PsbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Execute.PsbPasswordChangeText(PsbPassword, BtnShowPass);
        }
        #endregion
        
        private void BtnAuthorize_Click(object sender, RoutedEventArgs e)
        {
            Execute.Authorization(TxbLogin, PsbPassword);
        }

        private void TxbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            Execute.NotCorrectMessage("Пользователя с таким логином/почтой нет", TxbLogin, TxtLoginEmailNotCorrect, BtnAuthorize);
        }
    }
}
