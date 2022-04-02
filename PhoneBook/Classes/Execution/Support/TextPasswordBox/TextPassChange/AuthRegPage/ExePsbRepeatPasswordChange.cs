using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.RegPage
{
    public class ExePsbRepeatPasswordChange : ITextPassChange
    {
        private TextBox TextBox { get; set; }
        private PasswordBox PasswordBox { get; set; }
        private PasswordBox PasswordBox1 { get; set; }
        private TextBlock TextBlock { get; set; }
        public ExePsbRepeatPasswordChange(ref TextBox textBox, ref PasswordBox passwordBox,
            ref PasswordBox passwordBox1, ref TextBlock textBlock)
        {
            TextBox = textBox;
            PasswordBox = passwordBox;
            TextBlock = textBlock;
            PasswordBox1 = passwordBox1;
        }
        public void TextPassChange()
        {
            if (!WPFTextPassBox.PassboxRepeatPassword(TextBox, PasswordBox, PasswordBox1))
            {
                PasswordBox1.BorderBrush = (Brush)new BrushConverter().ConvertFromString("#E21616");
                TextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                PasswordBox1.BorderBrush = (Brush)new BrushConverter().ConvertFromString("#0BC00B");
                TextBlock.Visibility = Visibility.Collapsed;
            }
        }
    }
}
