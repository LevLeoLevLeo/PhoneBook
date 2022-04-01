using System.Windows.Controls;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

namespace WPFTextBoxHelp.Classes.Support.Validation
{
    /// <summary>
    /// Класс, проверяющий равны ли два PasswordBox'а.
    /// </summary>
    public class PsbRepeatPassword : ITextPassBoxValidation
    {
        private TextBox TextBox { get; set; }
        private PasswordBox PasswordBox { get; set; }

        private PasswordBox SecondPasswordBox { get; set; }

        public PsbRepeatPassword(ref TextBox textBox, ref PasswordBox passwordBox,
            ref PasswordBox secondPasswordBox)
        {
            PasswordBox = passwordBox;
            SecondPasswordBox = secondPasswordBox;
            TextBox = textBox;
        }

        public bool IsValid()
        {
            if (PasswordBox.Password == SecondPasswordBox.Password ||
                TextBox.Text == SecondPasswordBox.Password)
                return true;
            else return false;
        }
    }
}
