using PhoneBook.Classes.Support;
using PhoneBook.MessageDialog.MessBox;
using PhoneBook.WindowList;
using System;
using System.Linq;
using System.Windows.Controls;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg
{
    /// <summary>
    /// Класс, отвечающий за авторизацию.
    /// </summary>
    public class ExeAuthorize : IClick
    { 
        private TextBox TextBoxLogin { get; set; }
        private PasswordBox PasswordBox { get; set; }
        public ExeAuthorize (ref TextBox textBoxLogin, ref PasswordBox passwordBox)
        {
            TextBoxLogin = textBoxLogin;
            PasswordBox = passwordBox;
        }

        public void Click()
        {
            try
            {
                if (WPFTextPassBox.TextBoxIsNull(TextBoxLogin) || WPFTextPassBox.PassBoxIsNull(PasswordBox))
                {
                    MessBox messBox = new MessBox("Вы заполнили не все поля!", "Авторизация", TypeMessage.Warning,
                        ButtonEn.Ok);
                    messBox.ShowDialog();
                }
                
                else
                {
                    var UserLogIn = DataBaseEnt.TelephoneBookEntities.User.FirstOrDefault(Alien =>
                            Alien.Login == TextBoxLogin.Text && Alien.Password == PasswordBox.Password);

                    if (UserLogIn != null)
                    {
                        CurrentUser.currentUser = UserLogIn;
                        WinUser winUser = new WinUser();
                        winUser.Show();
                        WindowTransfer.window.Close();
                    }
                    else
                    {
                        MessBox messBox = new MessBox("Логин или пароль введены неверно!", "Авторизация",
                                    TypeMessage.Warning, ButtonEn.Ok);
                        messBox.ShowDialog();
                        PasswordBox.Password = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessBox messBox = new MessBox(ex.Message, "Ошибка", TypeMessage.Error, ButtonEn.Ok);
                messBox.ShowDialog();
            }
        }
    }
}
