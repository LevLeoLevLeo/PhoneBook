using PhoneBook.Classes.Execution.Support;
using PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg;
using PhoneBook.Classes.Execution.Support.CheckBoxDescription.Click.AuthRegPage;
using PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.RegPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static void Authorization(TextBox textBoxLogin, TextBox textBoxPass,
            PasswordBox passwordBox, CheckBox checkBox)
        {
            ExeAuthorize exeAuthorize = new ExeAuthorize(ref textBoxLogin, ref textBoxPass,
                ref passwordBox, ref checkBox);
            exeAuthorize.Click();
        }

        /// <summary>
        /// Скрытие/показ пароля по нажатию на checkbox.
        /// </summary>
        /// <param name="checkBox"></param>
        /// <param name="textBox"></param>
        /// <param name="passwordBox"></param>
        public static void ShowHidePassword(CheckBox checkBox, TextBox textBox, PasswordBox passwordBox)
        {
            ExeChckBoxShowPass exeChckBoxShowPass = new ExeChckBoxShowPass(ref checkBox,
                ref textBox, ref passwordBox);
            exeChckBoxShowPass.ShowPassword();
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
        public static void PsbPasswordChangeText(TextBox textBox, PasswordBox passwordBox, CheckBox checkBox)
        {
            ExePsbPasswordChangeText exePsbPasswordChangeText = new ExePsbPasswordChangeText(ref textBox, ref passwordBox,
                ref checkBox);
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
        public static void Registration(TextBox textBoxLogin, TextBox textBoxEmail, TextBox textBoxPassword,
            PasswordBox passwordBox, PasswordBox repeatPassworBox)
        {
            ExeRegistration exeRegistration = new ExeRegistration(ref textBoxLogin, ref textBoxEmail,
                ref textBoxPassword, ref passwordBox, ref repeatPassworBox);
            exeRegistration.Registration();
        }
        #endregion

    }
}
