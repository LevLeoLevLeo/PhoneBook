#region Using
using System.Windows.Controls;
using WPFTextBoxHelp.Classes.Support.Placeholder;
#endregion

namespace WPFTextBoxHelp.Classes
{
    /// <summary>
    /// Организует работу placeholder'ов у textbox'ов и passwordbox'ов, проверяет их на валидность.
    /// </summary>
    public class WPFTextBoxHelp
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
        #endregion
    }
}
