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
        public MessBox(String textMessage, TypeMessage typeMessage, ButtonEn buttons)
        {
            InitializeComponent();
            Init.WinMessageBox(textMessage, TxtMessage,
                typeMessage, buttons, BtnOk, BtnNo, BtnYes, BtnCancel);
        }
    }
}
