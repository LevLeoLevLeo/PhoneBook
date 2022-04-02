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
    /// Логика взаимодействия для WinAddList.xaml
    /// </summary>
    public partial class WinAddList : Window
    {
        public WinAddList()
        {
            InitializeComponent();
            TxbNewPhoneList.Text = "Название";
        }

        private void TxbNewPhoneList_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbNewPhoneList, "Название");
        }

        private void TxbNewPhoneList_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbNewPhoneList, "Название");  
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void BtnCreateNewPhone_Click(object sender, RoutedEventArgs e)
        {
            Execute.CreateNewPhoneList(this, TxbNewPhoneList);
        }
    }
}
