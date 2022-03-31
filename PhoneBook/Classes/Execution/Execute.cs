using PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg;
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
        public static void Authorization(TextBox textBoxLogin, TextBox textBoxPass, PasswordBox passwordBox, CheckBox checkBox)
        {
            ExeAuthorize exeAuthorize = new ExeAuthorize(ref textBoxLogin, ref textBoxPass, ref passwordBox, ref checkBox);
            exeAuthorize.Click();
        }

        #endregion

    }
}
