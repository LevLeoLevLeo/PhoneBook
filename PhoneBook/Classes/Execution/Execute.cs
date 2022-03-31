using PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg;
using PhoneBook.Classes.Execution.Support.CheckBoxDescription.Click.AuthRegPage;
using PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.RegPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            exeGoToAuthPage.GoToPage();
        }
        /// <summary>
        /// Переход на страницу регистрации в окне Авторизации/Регистрации.
        /// </summary>
        /// <param name="buttonAuth"></param>
        /// <param name="buttonReg"></param>
        public static void GoToRegPage(Button buttonAuth, Button buttonReg)
        {
            ExeGoToRegPage exeGoToRegPage = new ExeGoToRegPage(ref buttonAuth, ref buttonReg);
            exeGoToRegPage.GoToPage();
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
        public static void RepeatPassword(TextBox textBox, PasswordBox passwordBox,
            PasswordBox passwordBox1, TextBlock textBlock)
        {
            ExePsbRepeatPasswordChange exePsbRepeatPasswordChange = new ExePsbRepeatPasswordChange(ref textBox,
                ref passwordBox, ref passwordBox1, ref textBlock);
            exePsbRepeatPasswordChange.TextPassChange();
        }
        #endregion

    }
}
