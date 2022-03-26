using System.Windows.Controls;
using WPFTextBoxHelp.Classes.Support.Placeholder;

namespace WPFTextBoxHelp.Classes
{
    /// <summary>
    /// Организует работу placeholder'ов у textbox'ов и passwordbox'ов, проверяет их на валидность.
    /// </summary>
    public class WPFTextBoxHelp
    {
        /// <summary>
        /// Действиет placeholder'а при получении фокуса клавиатуры на TextBox'е.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="placeholdertext"></param>
        public static void TextBoxPlaceholderGotFocus(TextBox textBox, string placeholdertext)
        {
            TxbPlaceholderGotFocus txbPlaceholderGotFocus = new TxbPlaceholderGotFocus(ref textBox, ref placeholdertext);
            txbPlaceholderGotFocus.PlaceHolder();
        }
        /// <summary>
        /// Действиеи placeholder'а при потери фокуса клавиатуры на TextBox'е.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="placeholdertext"></param>
        public static void TextBoxPlaceholderLostFocus(TextBox textBox, string placeholdertext)
        {
            TxbPlaceholderLostFocus txbPlaceholderLostFocus = new TxbPlaceholderLostFocus(ref textBox, ref placeholdertext);
            txbPlaceholderLostFocus.PlaceHolder();
        }
    }
}
