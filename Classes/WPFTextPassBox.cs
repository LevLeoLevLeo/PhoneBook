#region Using
using System.Windows.Controls;
using WPFTextBoxHelp.Classes.Support.Check;
using WPFTextBoxHelp.Classes.Support.Placeholder;
using WPFTextBoxHelp.Classes.Support.ShowPassword;
using WPFTextBoxHelp.Classes.Support.Validation;
#endregion

namespace WPFTextBoxHelp.Classes
{
    /// <summary>
    /// Организует работу placeholder'ов у textbox'ов и passwordbox'ов, проверяет их на валидность.
    /// </summary>
    public class WPFTextPassBox
    {
        #region Placeholder

        /// <summary>
        /// Действие placeholder'а при получении фокуса клавиатуры на TextBox'е.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="placeholdertext"></param>
        public static void TextBoxPlaceholderGotFocus(TextBox textBox, string placeholdertext)
        {
            TxbPlaceholderGotFocus txbPlaceholderGotFocus = new TxbPlaceholderGotFocus(ref textBox, ref placeholdertext);
            txbPlaceholderGotFocus.PlaceHolder();
        }

        /// <summary>
        /// Действие placeholder'а при потери фокуса клавиатуры на TextBox'е.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="placeholdertext"></param>
        public static void TextBoxPlaceholderLostFocus(TextBox textBox, string placeholdertext)
        {
            TxbPlaceholderLostFocus txbPlaceholderLostFocus = new TxbPlaceholderLostFocus(ref textBox, ref placeholdertext);
            txbPlaceholderLostFocus.PlaceHolder();
        }

        /// <summary>
        /// Действие placeholder'а у поля "пароль" при получении фокуса клавиатуры на password/textbox.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="passwordBox"></param>
        /// <param name="placeholdertext"></param>
        public static void PasswordBoxPlaceholderGotFocus(TextBox textBox, PasswordBox passwordBox, string placeholdertext)
        {
            PsbPlaceholderGotFocus psbPlaceholderGotFocus = new PsbPlaceholderGotFocus(ref textBox, ref passwordBox, ref placeholdertext);
            psbPlaceholderGotFocus.PlaceHolder();
        }

        /// <summary>
        /// Действие placeholder'а у поля "пароль" при получении фокуса клавиатуры на password/textbox
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="passwordBox"></param>
        public static void PasswordBoxPlaceholderLostFocus(TextBox textBox, PasswordBox passwordBox)
        {
            PsbPlaceholderLostFocus psbPlaceholderLostFocus = new PsbPlaceholderLostFocus(ref textBox, ref passwordBox);
            psbPlaceholderLostFocus.PlaceHolder();
        }

        #endregion

        #region IsNull

        /// <summary>
        /// Возвращает true, если TextBox пустой или содержит placeholder.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool TextBoxIsNull(TextBox textBox)
        {
            TxbNull txbNull = new TxbNull(ref textBox);
            return txbNull.Isnull();
        }

        public static bool PassBoxIsNull(PasswordBox passwordBox)
        {
            PsbNull psbNull = new PsbNull(ref passwordBox);
            return psbNull.Isnull();
        }

        #endregion
        
        /// <summary>
        /// Возвращает true, если оба PasswordBox'а равны.
        /// </summary>
        /// <param name="passwordBox"></param>
        /// <param name="secondPasswordBox"></param>
        /// <returns></returns>
        public static bool PassboxRepeatPassword(TextBox textBoxPass, PasswordBox passwordBox,
            PasswordBox secondPasswordBox)
        {
            PsbRepeatPassword psbRepeatPassword = new PsbRepeatPassword(ref textBoxPass, ref passwordBox,
                ref secondPasswordBox);
            return psbRepeatPassword.IsValid();
        }

        /// <summary>
        /// Показ пароля по удержанию.
        /// </summary>
        /// <param name="checkBoxPass"></param>
        /// <param name="textBoxPass"></param>
        /// <param name="passwordBox"></param>
        public static void ShowPassword(TextBox textBoxPass, PasswordBox passwordBox)
        {
            ButtonPressShowPass checkBoxShowPass = new ButtonPressShowPass(
            ref textBoxPass, ref passwordBox);
            checkBoxShowPass.ShowPass();
        }
        /// <summary>
        /// Скрытие пароля.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="passwordBox"></param>
        public static void HidePassword(TextBox textBox, PasswordBox passwordBox)
        {
            ButtonUpLeftButtonShowPass buttonUpLeftButtonShowPass = new ButtonUpLeftButtonShowPass(ref textBox,
                ref passwordBox);
            buttonUpLeftButtonShowPass.ShowPass();
        }
        /// <summary>
        /// Проверяет почту на валидность.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool CheckValidEmail(TextBox textBox)
        {
            ValidEmail validEmail = new ValidEmail(ref textBox);
            return validEmail.IsValid();
        }
    }
}
