using PhoneBook.Classes.Execution;
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
using System.Windows.Shapes;
using WPFTextBoxHelp.Classes;

namespace PhoneBook.WindowList
{
    /// <summary>
    /// Логика взаимодействия для WinCheckEmail.xaml
    /// </summary>
    public partial class WinCheckEmail : Window
    {
        public WinCheckEmail(TextBox textBoxEmail, TextBox textBoxLogin)
        {
            InitializeComponent();
            x = Execute.SendCodeToEmail(textBoxEmail, textBoxLogin);
        }
        private static string x;
        private void BtnThisClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            DialogResult = false;
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Execute.VerifyEmail(this, x, TxbCheckCode);
        }

        private void TxbCheckCode_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbCheckCode, "Код подтверждения");
        }

        private void TxbCheckCode_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbCheckCode, "Код подтверждения");
        }
    }
}
