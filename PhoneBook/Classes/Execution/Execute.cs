using PhoneBook.Classes.Execution.Support;
using PhoneBook.Classes.Execution.Support.ButtonDescription.Click.PageUserMain;
using PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg;
using PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinDialog;
using PhoneBook.Classes.Execution.Support.ComboBoxDescription.SelectionChange.PageMainUser;
using PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.AuthRegPage;
using PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.CheckCodeEmail;
using PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.PageMainUser;
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
            PasswordBox passwordBox1, TextBlock textBlock, Button button)
        {
            ExePsbRepeatPasswordChange exePsbRepeatPasswordChange = new ExePsbRepeatPasswordChange(ref textBox,
                ref passwordBox, ref passwordBox1, ref textBlock, ref button);
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
        /// <summary>
        /// Проверка логина на совпадение в БД.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textBox"></param>
        /// <param name="textBlock"></param>
        /// <param name="button"></param>
        public static void AuthLoginNotCorrectMessage(string text, TextBox textBox, TextBlock textBlock, Button button)
        {
            ExeTxbLoginTextChange exeTxbLoginTextChange = new ExeTxbLoginTextChange(ref text, ref textBox, ref textBlock, ref button);
            exeTxbLoginTextChange.TextPassChange();
        }
        /// <summary>
        /// Проверка новой почты на валдиность.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textBox"></param>
        /// <param name="textBlock"></param>
        /// <param name="button"></param>
        public static void RegEmailNotCorrectMessage(string text, TextBox textBox, TextBlock textBlock, Button button)
        {
            ExeTxbEmailTextChange exeTxbEmailTextChange = new ExeTxbEmailTextChange(ref text, ref textBox, ref textBlock, ref button);
            exeTxbEmailTextChange.TextPassChange();
        }
        /// <summary>
        /// Проверка доступности логина при регистрации.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textBox"></param>
        /// <param name="textBlock"></param>
        /// <param name="button"></param>
        public static void RegLoginNotCorrectMessage(string text, TextBox textBox, TextBlock textBlock, Button button)
        {
            ExeTxbRegLoginTextChange exeTxbRegLoginTextChange = new ExeTxbRegLoginTextChange(ref text, ref textBox, ref textBlock,
                ref button);
            exeTxbRegLoginTextChange.TextPassChange();
        }
        /// <summary>
        /// Проверка на валидность кода подтверждения.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="textBlock"></param>
        /// <param name="button"></param>
        public static void VerifyEmailCode(TextBox textBox, TextBlock textBlock, Button button)
        {
            ExeTxbCheckVerifyEmailCode exeTxbCheckVerifyEmailCode = new ExeTxbCheckVerifyEmailCode(ref textBox, ref textBlock,
                ref button);
            exeTxbCheckVerifyEmailCode.TextPassChange();
        }
        #endregion

        #region Окно пользователя

        public static void CmbChangePhoneList(ComboBox comboBox, DataGrid dataGrid)
        {
            ExeCmbPhoneListChange exeCmbPhoneListChang = new ExeCmbPhoneListChange(ref comboBox, ref dataGrid);
            exeCmbPhoneListChang.Change();
        }

        public static void CreateNewList(ComboBox comboBox)
        {
            ExeBtnClickAddPhoneList exeBtnClickAddPhoneList = new ExeBtnClickAddPhoneList(ref comboBox);
            exeBtnClickAddPhoneList.AddPhoneList();
        }
        public static void CreateNewPhoneList(Window window, TextBox textBox)
        {
            ExeBtnClickCreateNewPhoneList exeBtnClickCreateNewPhoneList = new ExeBtnClickCreateNewPhoneList(
                ref textBox, ref window);
            exeBtnClickCreateNewPhoneList.Click();
        }
        public static void DeletePhoneList(ComboBox comboBox)
        {
            ExeDeletePhoneList deletePhoneList = new ExeDeletePhoneList(ref comboBox);
            deletePhoneList.Click();
        }
        public static void AddNewPhoneNumber(TextBox textBoxName, TextBox textBoxNumber,
            TextBox textBoxDescription, ComboBox comboBox)
        {
            ExeAddNewPhoneNumber exeAddNewPhoneNumber = new ExeAddNewPhoneNumber(ref textBoxName,
                ref textBoxNumber, ref textBoxDescription, ref comboBox);
            exeAddNewPhoneNumber.Click();
        }
        public static void DeletePhoneNumber(DataGrid dataGrid, ComboBox comboBox)
        {
            ExeDeletePhoneNumber exeDeletePhoneNumber = new ExeDeletePhoneNumber(ref dataGrid, ref comboBox);
            exeDeletePhoneNumber.Click();
        }
        public static void SearchPhoneNumber(TextBox TextBox, ComboBox ComboBox, DataGrid DataGrid)
        {
            ExeSearchPhone exeSearchPhone = new ExeSearchPhone(ref TextBox,
                ref ComboBox, ref DataGrid);
            exeSearchPhone.TextPassChange();
        }
        #endregion

    }
}