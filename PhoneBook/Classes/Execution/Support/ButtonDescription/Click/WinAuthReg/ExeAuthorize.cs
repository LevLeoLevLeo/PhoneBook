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
                            var UserLogIn = DataBaseEnt.TelephoneBookEntities.User.FirstOrDefault(Alien =>
                            Alien.Login == TextBoxLogin.Text && Alien.Password == TextBoxPass.Text ||
                            Alien.Email == TextBoxLogin.Text && Alien.Password == TextBoxPass.Text);

                            if (UserLogIn != null)
                            {
                                CurrentUser.currentUser = UserLogIn;
                                WinUser winUser = new WinUser();
                                winUser.Show();
                                WindowTransfer.window.Close();
                            }
                            else
                            {
                                MessBox messBox = new MessBox("Логин или пароль введены неверно!",
                                    TypeMessage.Information, ButtonEn.Ok);
                                messBox.ShowDialog();
                                PasswordBox.Password = null;
                            }
                            break;
                        case false:
                            var UserLogInT = DataBaseEnt.TelephoneBookEntities.User.FirstOrDefault(Alien =>
                             Alien.Login == TextBoxLogin.Text && Alien.Password == PasswordBox.Password ||
                             Alien.Email == TextBoxLogin.Text && Alien.Password == PasswordBox.Password);

                            if (UserLogInT != null)
                            {
                                CurrentUser.currentUser = UserLogInT;
                                WinUser winUser = new WinUser();
                                winUser.Show();
                                WindowTransfer.window.Close();
                            }
                            else
                            {
                                MessBox messBox = new MessBox("Такого пользователя!", TypeMessage.Information,
                        ButtonEn.Ok);
                                messBox.ShowDialog();
                                PasswordBox.Password = null;
                            }
                            break;
                        default:
                            MessBox messBox2 = new MessBox("Произошла непредвиденная ошибка!", TypeMessage.Information,
                        ButtonEn.Ok);
                            messBox2.ShowDialog();
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
