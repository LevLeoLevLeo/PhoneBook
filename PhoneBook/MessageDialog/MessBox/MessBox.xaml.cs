using PhoneBook.Classes.InitializationDescription;
using System;
using System.Windows;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;

namespace PhoneBook.MessageDialog.MessBox
{
    /// <summary>
    /// Логика взаимодействия для MessBox.xaml
    /// </summary>
    public partial class MessBox : Window
    {
        public MessBox(String textTitle, String textMessage, TypeMessage typeMessage, ButtonEn buttons)
        {
            InitializeComponent();
            Init.WinMessageBox(this, textTitle, textMessage, TxtMessage,
                typeMessage, buttons, BtnOk, BtnNo, BtnYes, BtnCancel);
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void BtnYes_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
