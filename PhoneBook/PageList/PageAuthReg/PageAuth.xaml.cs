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
        }

        #region Placeholder
        private void TxbLogin_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbLogin, "Логин или почта...");
        }

        private void TxbLogin_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbLogin, "Логин или почта...");
        }

        private void TxbPassword_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderGotFocus(TxbPassword, PsbPassword, "Пароль...");
        }

        private void TxbPassword_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderLostFocus(TxbPassword, PsbPassword);
        }

        #endregion
        private void BtnAuthorize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PsbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void BtnShowPass_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChbShowPass_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
