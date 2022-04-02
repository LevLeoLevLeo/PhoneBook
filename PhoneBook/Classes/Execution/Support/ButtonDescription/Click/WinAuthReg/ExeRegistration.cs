using PhoneBook.Classes.Support;
using PhoneBook.DataBase;
using PhoneBook.MessageDialog.MessBox;
using PhoneBook.PageList.PageAuthReg;
using PhoneBook.WindowList;
using System;
using System.Linq;
using System.Windows.Controls;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg
{
    public class ExeRegistration : IClick
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

        public void Click()
        {

            if (!WPFTextPassBox.TextBoxIsNull(TxbLogin) &&
                !WPFTextPassBox.TextBoxIsNull(TxbEmail) &&
                !WPFTextPassBox.PassBoxIsNull(PsbPassword) &&
                WPFTextPassBox.PassboxRepeatPassword(TextBoxPassword, PsbPassword, PsbRepeatPassword))
            {
                var user = DataBaseEnt.TelephoneBookEntities.User.FirstOrDefault(x => TxbLogin.Text == x.Login ||
                TxbEmail.Text == x.Email);
                if (user == null)
                {
                    WinCheckEmail winCheckEmail = new WinCheckEmail(TxbEmail, TxbLogin);
                    if (winCheckEmail.ShowDialog() == true)
                    {
                        try
                        {
                            User newUser = new User
                            {

                                Email = TxbEmail.Text,
                                Login = TxbLogin.Text,
                                Password = PsbPassword.Password,

                            };

                            DataBaseEnt.TelephoneBookEntities.User.Add(newUser);
                            PhoneList phoneList = new PhoneList()
                            {

                                Name = "Мой список",
                                IdUser = newUser.Id,

                            };

                            DataBaseEnt.TelephoneBookEntities.PhoneList.Add(phoneList);
                            DataBaseEnt.TelephoneBookEntities.SaveChanges();
                            MessBox messBox = new MessBox("Вы зарегестрированы!", "Регистрация", TypeMessage.Information,
                                ButtonEn.Ok);
                            messBox.ShowDialog();
                            NavigationFrame.frame.Navigate(new PageReg());
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
                    MessBox messBox = new MessBox("Такой пользователь уже есть!", "Регистрация", TypeMessage.Warning, ButtonEn.Ok);
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
