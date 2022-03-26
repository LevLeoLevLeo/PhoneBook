using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

namespace WPFTextBoxHelp.Classes.Support.Placeholder
{
    /// <summary>
    /// Класс отвечает за отображение placeholder'а у поля "пароль" при получении фокуса клавиатуры на password/textbox.
    /// </summary>
    public class PsbPlaceholderGotFocus : IPlaceHolder
    {
        private TextBox TextBox { get; set; }
        private PasswordBox PasswordBox { get; set; }
        private string PlaceholderText { get; set; }
        public PsbPlaceholderGotFocus(ref TextBox textBox, ref PasswordBox passwordBox, ref string placeholdertext)
        {
            TextBox = textBox;
            PasswordBox = passwordBox;
            PlaceholderText = placeholdertext;
        }
        public void PlaceHolder()
        {
            if (TextBox.Text == PlaceholderText && TextBox.Foreground == Brushes.Gray)
            {
                TextBox.Visibility = Visibility.Collapsed;
                PasswordBox.Visibility = Visibility.Visible;
                PasswordBox.Focus();
            }
        }
    }
}
