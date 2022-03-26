using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// Отвечает за работу placeholder'а при получении фокуса клавиатуры на TextBox.
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="placeholdertext"></param>
        public static void TextBoxPlaceholderGotFocus(TextBox textBox, string placeholdertext)
        {
            TxbPlaceholderGotFocus txbPlaceholderGotFocus = new TxbPlaceholderGotFocus(ref textBox, ref placeholdertext);
            txbPlaceholderGotFocus.PlaceHolder();
        }
    }
}
