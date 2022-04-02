using PhoneBook.Classes.Execution;
using PhoneBook.Classes.InitializationDescription;
using PhoneBook.Classes.Support;
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

namespace PhoneBook.PageList.PageUser
{
    /// <summary>
    /// Логика взаимодействия для PageUserMain.xaml
    /// </summary>
    public partial class PageUserMain : Page
    {
        public PageUserMain()
        {
            InitializeComponent();
            Init.PageMainUser(CmbPhoneList);
        }

        private void BtnAddNumber_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteNumber_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxbSearchRecord_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderGotFocus(TxbSearchRecord, "Имя, номер, описание");
        }

        private void TxbSearchRecord_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            WPFTextPassBox.TextBoxPlaceholderLostFocus(TxbSearchRecord, "Имя, номер, описание");
        }

        private void TxbSearchRecord_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void CmbPhoneList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Execute.CmbChangePhoneList(CmbPhoneList, DtGrTelephoneInfo);
        }

        private void BtnNewPhoneList_Click(object sender, RoutedEventArgs e)
        {
            Execute.CreateNewList(CmbPhoneList);
        }

        private void BtnDeletePhoneList_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
