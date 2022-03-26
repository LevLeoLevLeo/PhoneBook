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
    /// Класс отвечает за работу placeholder'а при получении фокуса клавиатуры.
    /// </summary>
    public class TxbPlaceholderGotFocus : IPlaceHolder
    {
        private TextBox TextBox { get; set; }
        private string Placeholdertext { get; set; }
        public TxbPlaceholderGotFocus(ref TextBox textBox, ref string placeholdertext)
        {
            TextBox = textBox;
            Placeholdertext = placeholdertext;
        }
        public void PlaceHolder()
        {
            if (TextBox.Text == Placeholdertext && TextBox.Foreground == Brushes.Gray)
            {
                TextBox.Text = String.Empty;
                TextBox.Foreground = Brushes.Black;
            }
        }
    }
}