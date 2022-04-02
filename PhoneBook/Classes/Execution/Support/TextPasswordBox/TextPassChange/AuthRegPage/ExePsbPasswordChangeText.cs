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
        private PasswordBox PasswordBox { get; set; }
        private Button Button { get; set; }
        public ExePsbPasswordChangeText(ref PasswordBox passwordBox, ref Button button)
        {
            PasswordBox = passwordBox;
            Button = button;
        }

        public void TextPassChange()
        {
            if (!WPFTextPassBox.PassBoxIsNull(PasswordBox))
                Button.Visibility = Visibility.Visible;
            else Button.Visibility = Visibility.Collapsed;
        }
    }
}
