using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.RegPage
{
    /// <summary>
    /// Класс, отвечающий за поведение passwordbox при отсутствии введенных данных.
    /// </summary>
    public class ExePsbPasswordChangeText : ITextPassChange
    {
        private TextBox TextBox { get; set; }
        private PasswordBox PasswordBox { get; set; }
        private CheckBox CheckBox { get; set; }
        public ExePsbPasswordChangeText(ref TextBox textBox, ref PasswordBox passwordBox, ref CheckBox checkBox)
        {
            TextBox = textBox;
            PasswordBox = passwordBox;
            CheckBox = checkBox;
        }

        public void TextPassChange()
        {
            if (WPFTextPassBox.PassBoxIsNull(PasswordBox) == true ||
                WPFTextPassBox.TextBoxIsNull(TextBox) == true)
            {
                CheckBox.IsChecked = false;
                WPFTextPassBox.CheckBoxShowPassword(CheckBox, TextBox, PasswordBox);
                CheckBox.Visibility = Visibility.Collapsed;
            }
            else CheckBox.Visibility = Visibility.Visible;
        }
    }
}
