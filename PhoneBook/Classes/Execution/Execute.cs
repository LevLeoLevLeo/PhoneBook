using PhoneBook.Classes.Execution.Support;
using PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg;
using PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.AuthRegPage;
using PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.RegPage;
using System.Windows;
using System.Windows.Controls;

namespace PhoneBook.Classes.Execution
{

    /// <summary>
    /// Класс, отвечающий за выполнения различных действий в приложении.
    /// </summary>
    public class Execute
    {

        #region Окно авторизации/регистрации

        /// <summary>
        /// Переход на страницу авторизации в окне Авторизации/Регистрации.
        /// </summary>
        /// <param name="buttonAuth"></param>
        /// <param name="buttonReg"></param>
        public static void GoToAuthPage(Button buttonAuth, Button buttonReg)
        {
            ExeGoToAuthPage exeGoToAuthPage = new ExeGoToAuthPage(ref buttonAuth, ref buttonReg);
            exeGoToAuthPage.Click();
        }
        /// <summary>
        /// Переход на страницу регистрации в окне Авторизации/Регистрации.
        /// </summary>
        /// <param name="buttonAuth"></param>
        /// <param name="buttonReg"></param>
        public static void GoToRegPage(Button buttonAuth, Button buttonReg)
        {
            ExeGoToRegPage exeGoToRegPage = new ExeGoToRegPage(ref buttonAuth, ref buttonReg);
            exeGoToRegPage.Click();
        }

        /// <summary>
        /// Авторизация пользователя в приложении.
        /// </summary>
        /// <param name="textBoxLogin"></param>
        /// <param name="textBoxPass"></param>
        /// <param name="passwordBox"></param>
        /// <param name="checkBox"></param>
        public static void Authorization(TextBox textBoxLogin, PasswordBox passwordBox)
        {
            ExeAuthorize exeAuthorize = new ExeAuthorize(ref textBoxLogin, ref passwordBox);
            exeAuthorize.Click();
        }

        /// <summary>
        /// Проверка на совпадение повторно введенного пароля при регистриции.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="passwordBox"></param>
        /// <param name="passwordBox1"></param>
        /// <param name="textBlock"></param>
        public static void RepeatPassword(TextBox textBox, PasswordBox passwordBox,
            PasswordBox passwordBox1, TextBlock textBlock)
        {
            ExePsbRepeatPasswordChange exePsbRepeatPasswordChange = new ExePsbRepeatPasswordChange(ref textBox,
                ref passwordBox, ref passwordBox1, ref textBlock);
            exePsbRepeatPasswordChange.TextPassChange();
        }

        /// <summary>
        /// Логика поведения passwordbpx'а при пустом значении поля.
        /// </summary>
        /// <param name="passwordBox"></param>
        /// <param name="checkBox"></param>
        public static void PsbPasswordChangeText(PasswordBox passwordBox, Button button)
        {
            ExePsbPasswordChangeText exePsbPasswordChangeText = new ExePsbPasswordChangeText(ref passwordBox,
                ref button);
            exePsbPasswordChangeText.TextPassChange();
        }

        /// <summary>
        /// Отправляет Email с кодом подтверждения на почту.
        /// </summary>
        /// <param name="textBoxEmail"></param>
        /// <param name="textBoxLogin"></param>
        /// <returns></returns>
        public static string SendCodeToEmail(TextBox textBoxEmail, TextBox textBoxLogin)
        {
            ExeSendEmail exeSendEmail = new ExeSendEmail(ref textBoxEmail, ref textBoxLogin);
            return exeSendEmail.Send();
        }
        /// <summary>
        /// Регистрация в приложении.
        /// </summary>
        /// <param name="textBoxLogin"></param>
        /// <param name="textBoxEmail"></param>
        /// <param name="textBoxPassword"></param>
        /// <param name="passwordBox"></param>
        /// <param name="repeatPassworBox"></param>
        public static void Registration(TextBox textBoxLogin, TextBox textBoxEmail, TextBox textBoxPassword,
            PasswordBox passwordBox, PasswordBox repeatPassworBox)
        {
            ExeRegistration exeRegistration = new ExeRegistration(ref textBoxLogin, ref textBoxEmail,
                ref textBoxPassword, ref passwordBox, ref repeatPassworBox);
            exeRegistration.Click();
        }
        /// <summary>
        /// Проверка кода для подтверждения регистрации.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="code"></param>
        /// <param name="textBox"></param>
        public static void VerifyEmail(Window window, string code, TextBox textBox)
        {
            ExeVerifyEmail exeVerifyEmail = new ExeVerifyEmail(ref window, ref code, ref textBox);
            exeVerifyEmail.Click();
        }
        public static void NotCorrectMessage(string text, TextBox textBox, TextBlock textBlock, Button button)
        {
            ExeTxbLoginTextChange exeTxbLoginTextChange = new ExeTxbLoginTextChange(ref text, ref textBox, ref textBlock, ref button);
            exeTxbLoginTextChange.TextPassChange();
        }
        #endregion

    }
}
