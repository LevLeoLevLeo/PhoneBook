#region Using
using System.Windows.Controls;
using System.Windows.Media;
using WPFTextBoxHelp.Classes.Support.Placeholder;
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

        /// <summary>
        /// Возвращает true, если оба PasswordBox'а равны.
        /// </summary>
        /// <param name="passwordBox"></param>
        /// <param name="secondPasswordBox"></param>
        /// <returns></returns>
        public static bool PassboxRepeatPassword(PasswordBox passwordBox, PasswordBox secondPasswordBox)
        {
            PsbRepeatPassword psbRepeatPassword = new PsbRepeatPassword(ref passwordBox, ref secondPasswordBox);
            return psbRepeatPassword.IsValid();
        }

        #endregion
    }
}
