using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

namespace WPFTextBoxHelp.Classes.Support.ShowPassword
{
    public class ButtonUpLeftButtonShowPass : IShowPass
    {
        private TextBox TextBox { get; set; }
        private PasswordBox PasswordBox { get; set; }
        public ButtonUpLeftButtonShowPass(ref TextBox textBox, ref PasswordBox passwordBox)
        {
            TextBox = textBox;
            PasswordBox = passwordBox;
        }
        public void ShowPass()
        {
                TextBox.Visibility = Visibility.Collapsed;
                PasswordBox.Visibility = Visibility.Visible;
                TextBox.Foreground = Brushes.Gray;
                TextBox.Text = "Пароль";
        }
    }
}
