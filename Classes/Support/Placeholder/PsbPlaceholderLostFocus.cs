using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFTextBoxHelp.Classes.Support.Validation;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

namespace WPFTextBoxHelp.Classes.Support.Placeholder
{
    /// <summary>
    /// Класс отвечает за работу placeholder'а у поля "показать пароль" при потери фокуса на password/textbox.
    /// </summary>
    public class PsbPlaceholderLostFocus : IPlaceHolder
    {
        private TextBox TextBox { get; set; }

        private PasswordBox PasswordBox { get; set; }

        public PsbPlaceholderLostFocus (ref TextBox textBox, ref PasswordBox passwordBox)
        {
            TextBox = textBox;
            PasswordBox = passwordBox;
        }

        public void PlaceHolder()
        {
            if (WPFTextPassBox.PassBoxIsNull(PasswordBox) && PasswordBox.Foreground == Brushes.Black)
            {
                PasswordBox.Password = String.Empty;
                PasswordBox.Visibility = Visibility.Collapsed;
                TextBox.Visibility = Visibility.Visible;
            }
        }
    }
}
