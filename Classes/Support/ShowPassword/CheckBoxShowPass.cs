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
    public class CheckBoxShowPass : IShowPass
    {
        private CheckBox CheckBox { get; set; }
        private TextBox TextBox { get; set; }
        private PasswordBox PasswordBox { get; set; }
        public CheckBoxShowPass(ref CheckBox checkBox, ref TextBox textBox,
            ref PasswordBox passwordBox)
        {
            CheckBox = checkBox;
            TextBox = textBox;
            PasswordBox = passwordBox;
        }
        public void ShowPass()
        {
            if (CheckBox.IsChecked == true && TextBox.Foreground != Brushes.Gray)
            {
                TextBox.Text = PasswordBox.Password;
                PasswordBox.Visibility = Visibility.Collapsed;
                TextBox.Foreground = Brushes.Black;
                TextBox.Visibility = Visibility.Visible;
                PasswordBox.Password = null;
            }
            else if (CheckBox.IsChecked == false && TextBox.Foreground != Brushes.Gray)
            {
                PasswordBox.Password = TextBox.Text;
                TextBox.Visibility = Visibility.Collapsed;
                PasswordBox.Visibility = Visibility.Visible;
                TextBox.Foreground = Brushes.Gray;
                TextBox.Text = "Пароль";
            }
        }
    }
}
