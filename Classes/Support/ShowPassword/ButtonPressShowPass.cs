using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

/// <summary>
/// Класс, показывающий/скрывающий пароль по checkbox'у.
/// </summary>
namespace WPFTextBoxHelp.Classes.Support.ShowPassword
{
    /// <summary>
    /// Класс, показывающий/скрывающий пароль по checkbox'у.
    /// </summary>
    public class ButtonPressShowPass : IShowPass
    {
        private TextBox TextBox { get; set; }
        private PasswordBox PasswordBox { get; set; }
        public ButtonPressShowPass(ref TextBox textBox,
            ref PasswordBox passwordBox)
        {
            TextBox = textBox;
            PasswordBox = passwordBox;
        }
        public void ShowPass()
        {
                TextBox.Text = PasswordBox.Password;
                TextBox.Foreground = Brushes.Black;
                TextBox.Visibility = Visibility.Visible;
                PasswordBox.Visibility = Visibility.Collapsed;
        }
    }
}
