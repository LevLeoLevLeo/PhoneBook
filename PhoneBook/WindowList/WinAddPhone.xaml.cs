using PhoneBook.Classes.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для WinAddPhone.xaml
    /// </summary>
    public partial class WinAddPhone : Window
    {
        public WinAddPhone(ComboBox comboBox)
        {
            InitializeComponent();
            TxbNewPhoneName.Text = "Имя";
            TxbNewPhoneNumber.Text = "Номер";
            TxbNewPhoneDescription.Text = "Описание";
            ComboBox = comboBox;
        }
        private readonly string pattern = @"^[0-9]+$";
        private ComboBox ComboBox;
        private void TxbNewPhoneName_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbNewPhoneName, "Имя");
        }

        private void TxbNewPhoneName_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbNewPhoneName, "Имя");
        }

        private void BtnAddNewPhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            Execute.AddNewPhoneNumber(TxbNewPhoneName, TxbNewPhoneNumber, TxbNewPhoneDescription, ComboBox);
            DialogResult = true;
        }

        private void TxbNewPhoneNumber_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbNewPhoneNumber, "Номер");
        }

        private void TxbNewPhoneNumber_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbNewPhoneNumber, "Номер");
        }

        private void TxbNewPhoneDescription_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbNewPhoneDescription, "Описание");
        }

        private void TxbNewPhoneDescription_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbNewPhoneDescription, "Описание");
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void TxbNewPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Regex.IsMatch(TxbNewPhoneNumber.Text, pattern))
            {
                BtnAddNewPhoneNumber.IsEnabled = false;
                BtnAddNewPhoneNumber.Background = Brushes.Gray;
            }
            else
            {
                BtnAddNewPhoneNumber.IsEnabled = true;
                BtnAddNewPhoneNumber.Background = (Brush)new BrushConverter().ConvertFromString("#29435C");
            }
        }
    }
}
