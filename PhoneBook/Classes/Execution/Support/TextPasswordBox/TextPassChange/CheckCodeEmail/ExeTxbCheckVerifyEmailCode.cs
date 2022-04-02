using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.CheckCodeEmail
{
    public class ExeTxbCheckVerifyEmailCode : ITextPassChange
    {
        private TextBox TextBox { get; set; }
        private TextBlock TextBlock { get; set; }
        private Button Button { get; set; }
        private readonly string CheckCode = @"{0-9]{6}";
        public ExeTxbCheckVerifyEmailCode(ref TextBox textBox, ref TextBlock textBlock, ref Button button)
        {
            TextBox = textBox;
            TextBlock = textBlock;
            Button = button;
        }
        public void TextPassChange()
        {
            if (!Regex.IsMatch(TextBox.Text, CheckCode, RegexOptions.IgnoreCase) && TextBox.Foreground != Brushes.Gray
                && !WPFTextPassBox.TextBoxIsNull(TextBox) && TextBox.Text.Length == 6)
            {
                Button.IsEnabled = false;
                Button.Background = Brushes.Gray;
                TextBox.BorderBrush = (Brush)new BrushConverter().ConvertFromString("#E21616");
                TextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                Button.IsEnabled = true;
                Button.Background = (Brush)new BrushConverter().ConvertFromString("#29435C");
                TextBox.BorderBrush = (Brush)new BrushConverter().ConvertFromString("#29435C");
                TextBlock.Visibility = Visibility.Collapsed;
            }
        }
    }
}
