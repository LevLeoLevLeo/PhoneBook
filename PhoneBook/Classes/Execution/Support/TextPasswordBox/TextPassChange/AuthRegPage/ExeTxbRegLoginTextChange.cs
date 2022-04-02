using PhoneBook.Classes.Support;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.AuthRegPage
{
    /// <summary>
    /// Класс, проверяющий на неналичие пользователя в системе.
    /// </summary>
    public class ExeTxbRegLoginTextChange : ITextPassChange
    {
        private string Text { get; set; }
        private TextBox TextBox { get; set; }
        private TextBlock TextBlock { get; set; }
        private Button Button { get; set; }
        public ExeTxbRegLoginTextChange(ref string text, ref TextBox textBox, ref TextBlock textBlock, ref Button button)
        {
            Text = text;
            TextBox = textBox;
            TextBlock = textBlock;
            Button = button;
        }

        public void TextPassChange()
        {
            if (TextBox.Foreground != Brushes.Gray && !WPFTextPassBox.TextBoxIsNull(TextBox))
            {
                var Login = DataBaseEnt.TelephoneBookEntities.User.FirstOrDefault(x => TextBox.Text == x.Login ||
                TextBox.Text == x.Email);
                if (Login != null)
                {
                    TextBlock.Text = Text;
                    Button.IsEnabled = false;
                    Button.Background = Brushes.Gray;
                    TextBox.BorderBrush = (Brush)new BrushConverter().ConvertFromString("#E21616");
                    TextBlock.Visibility = Visibility.Visible;
                }
                else
                {
                    Button.IsEnabled = true;
                    Button.Background = (Brush)new BrushConverter().ConvertFromString("#29435C");
                    TextBox.BorderBrush = (Brush)new BrushConverter().ConvertFromString("#0BC00B");
                    TextBlock.Visibility = Visibility.Collapsed;
                }
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
