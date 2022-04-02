using PhoneBook.Classes.Execution;
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
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbNewLogin, "Логин");
        }

        private void TxbLogin_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbNewLogin, "Логин");
        }

        private void TxbNewEmail_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbNewEmail, "Почта");
        }

        private void TxbNewEmail_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbNewEmail, "Почта");
        }

        private void TxbNewPassword_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderGotFocus(TxbNewPassword, PsbNewPassword, "Пароль");
        }

        private void TxbNewPassword_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderLostFocus(TxbNewPassword, PsbNewPassword);
        }

        private void TxbRepeatNewPassword_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderGotFocus(TxbRepeatNewPassword, PsbRepeatNewPassword,
                "Повторите пароль");
        }

        private void TxbRepeatNewPassword_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.PasswordBoxPlaceholderLostFocus(TxbRepeatNewPassword, PsbRepeatNewPassword);
        }

        #endregion

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Execute.Registration(TxbNewLogin, TxbNewEmail, TxbNewPassword, PsbNewPassword, PsbRepeatNewPassword);
        }

        #region Предупреждения
        
        private void TxbNewEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        #endregion

        private void PsbRepeatNewPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Execute.RepeatPassword(TxbRepeatNewPassword, PsbNewPassword, PsbRepeatNewPassword, TxtPasswordNotMatch);
        }

        #region ShowPass
        private void PsbNewPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Execute.PsbPasswordChangeText(PsbNewPassword, BtnShowPass);
        }
        
        private void BtnShowPass_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WPFTextPassBox.HidePassword(TxbNewPassword, PsbNewPassword);
        }

        private void BtnShowPass_Click(object sender, RoutedEventArgs e)
        {
            WPFTextPassBox.ShowPassword(TxbNewPassword, PsbNewPassword);
        }
        #endregion
    }
}
