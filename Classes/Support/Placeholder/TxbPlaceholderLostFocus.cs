using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

namespace WPFTextBoxHelp.Classes.Support.Placeholder
{
    /// <summary>
    /// Класс, отвечающий за работу placeholder'а при потери фокуса клавиатуры на TextBox.
    /// </summary>
    public class TxbPlaceholderLostFocus : IPlaceHolder
    {
        private TextBox TextBox { get; set; }

        private string Placeholdertext { get; set; }

        public TxbPlaceholderLostFocus(ref TextBox textBox, ref string placeholderText)
        {
            TextBox = textBox;
            Placeholdertext = placeholderText;
        }

        public void PlaceHolder()
        {
            if (WPFTextPassBox.TextBoxIsNull(TextBox))
            {
                TextBox.Foreground = Brushes.Gray;
                TextBox.Text = Placeholdertext;
            }
        }
    }
}