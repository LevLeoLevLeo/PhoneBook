using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WPFTextBoxHelp.Classes;

namespace PhoneBook.PageList.PageAuthReg
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
        }

        #region placeholder

        private void TxbLogin_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbNewLogin, "Логин...");
        }

        private void TxbLogin_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbNewLogin, "Логин...");
        }

        private void TxbNewEmail_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbNewEmail, "Почта...");
        }

        private void TxbNewEmail_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbNewEmail, "Почта...");
        }

        private void TxbNewPassword_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderGotFocus(TxbNewPassword, PsbNewPassword, "Пароль...");
        }

        private void TxbNewPassword_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderLostFocus(TxbNewPassword, PsbNewPassword);
        }

        private void TxbRepeatNewPassword_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderGotFocus(TxbRepeatNewPassword, PsbRepeatNewPassword,
                "Повторите пароль...");
        }

        private void TxbRepeatNewPassword_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderLostFocus(TxbRepeatNewPassword, PsbRepeatNewPassword);
        }

        #endregion

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {

        }

        #region Предупреждения
        
        private void TxbNewEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxbNewEmail.BorderBrush = (Brush)new BrushConverter().ConvertFromString("#0BC00B");
        }

        #endregion

        private void PsbNewPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
           
        }

        private void TxbNewPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ChbShowPass_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
