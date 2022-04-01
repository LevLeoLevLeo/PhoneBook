using PhoneBook.Classes.Support;
using PhoneBook.DataBase;
using PhoneBook.MessageDialog.MessBox;
using PhoneBook.WindowList;
using System;
using System.Windows.Controls;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg
{
    public class ExeRegistration
    {

        private TextBox TxbLogin { get; set; }
        private TextBox TxbEmail { get; set; }
        private TextBox TextBoxPassword { get; set; }
        private PasswordBox PsbPassword { get; set; }
        private PasswordBox PsbRepeatPassword { get; set; }

        public ExeRegistration(ref TextBox textBoxLogin, ref TextBox textBoxEmail, ref TextBox textBoxPassword,
            ref PasswordBox passwordBoxPassword, ref PasswordBox passwordBoxRepeatPassword)
        {

            TxbLogin = textBoxLogin;
            TxbEmail = textBoxEmail;
            TextBoxPassword = textBoxPassword;
            PsbPassword = passwordBoxPassword;
            PsbRepeatPassword = passwordBoxRepeatPassword;

        }

        public void Registration()
        {

            if (WPFTextPassBox.TextBoxIsNull(TxbLogin) && WPFTextPassBox.CheckValidEmail(TxbEmail) &&
                WPFTextPassBox.TextBoxIsNull(TxbEmail) &&
                WPFTextPassBox.PassBoxIsNull(PsbPassword) &&
                WPFTextPassBox.PassboxRepeatPassword(TextBoxPassword, PsbPassword, PsbRepeatPassword))
            {
                WinCheckEmail winCheckEmail = new WinCheckEmail();
                if (winCheckEmail.ShowDialog() == true)
                {
                    try
                    {
                        User user = new User
                        {

                            Email = TxbEmail.Text,
                            Login = TxbLogin.Text,
                            Password = PsbPassword.Password,

                        };

                        DataBaseEnt.TelephoneBookEntities.User.Add(user);
                        PhoneList phoneList = new PhoneList()
                        {

                            Name = "Мой список",
                            IdUser = user.Id,

                        };

                        DataBaseEnt.TelephoneBookEntities.PhoneList.Add(phoneList);
                        DataBaseEnt.TelephoneBookEntities.SaveChanges();
                        MessBox messBox = new MessBox("Вы зарегестрированы!", "Регистрация", TypeMessage.Information,
                            ButtonEn.Ok);
                        messBox.ShowDialog();
                        TxbLogin.Text = "";
                        TxbEmail.Text = "";
                        PsbPassword.Password = "";
                        PsbRepeatPassword.Password = "";
                    }

                    catch (Exception ex)

                    {
                        MessBox messBox = new MessBox(ex.Message, "Ошибка", TypeMessage.Error,
                            ButtonEn.Ok);
                        messBox.ShowDialog();
                    }
                }
                else
                {
                    MessBox messBox = new MessBox("Вы отменили регистрацию!", "Регистрация", TypeMessage.Information,
                          ButtonEn.Ok);
                    messBox.ShowDialog();
                }
            }
            else
            {
                MessBox messBox = new MessBox("Вы заполнили не все поля.", "Регистрация", TypeMessage.Warning,
                          ButtonEn.Ok);
                messBox.ShowDialog();
            }
        }

    }
}
