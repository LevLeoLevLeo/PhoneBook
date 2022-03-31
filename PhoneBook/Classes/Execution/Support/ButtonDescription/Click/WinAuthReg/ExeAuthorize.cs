using PhoneBook.Classes.Support;
using PhoneBook.MessageDialog.MessBox;
using PhoneBook.WindowList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg
{
    public class ExeAuthorize : IClick
    { 
        private TextBox TextBoxLogin { get; set; }
        private TextBox TextBoxPass { get; set; }
        private PasswordBox PasswordBox { get; set; }
        private CheckBox CheckBox { get; set; }
        public ExeAuthorize (ref TextBox textBoxLogin, ref TextBox textBoxPass,
            ref PasswordBox passwordBox, ref CheckBox checkBox)
        {
            TextBoxLogin = textBoxLogin;
            TextBoxPass = textBoxPass;
            PasswordBox = passwordBox;
            CheckBox = checkBox;
        }

        public void Click()
        {
            try
            {
                if (WPFTextPassBox.TextBoxIsNull(TextBoxLogin) || WPFTextPassBox.TextBoxIsNull(TextBoxPass) ||
                    WPFTextPassBox.PassBoxIsNull(PasswordBox))
                {
                    MessBox messBox = new MessBox("Вы заполнили не все поля!", TypeMessage.Information,
                        ButtonEn.Ok);
                    messBox.ShowDialog();
                }
                
                else
                {
                    switch (CheckBox.IsChecked)
                    {
                        case true:
                            //Тут будет процесс авторизации
                            WinUser winUser = new WinUser();
                            winUser.Show();
                            WindowTransfer.window.Close();
                            break;
                        case false:
                            //Тут будет процесс авторизации
                            WinUser winUser1 = new WinUser();
                            winUser1.Show();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessBox messBox = new MessBox(ex.Message, TypeMessage.Error, ButtonEn.Ok);
                messBox.ShowDialog();
            }
        }
    }
}
