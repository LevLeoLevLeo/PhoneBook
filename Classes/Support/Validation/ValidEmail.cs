using System.Text.RegularExpressions;
using System.Windows.Controls;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

namespace WPFTextBoxHelp.Classes.Support.Validation
{
    /// <summary>
    /// Класс, проверяющий валидность почты.
    /// </summary>
    public class ValidEmail : ITextPassBoxValidation
    {
        private TextBox TextBox { get; set; }
        
        private readonly Regex regexEmail = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|
                                                      [-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))"
                                                      + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][
                                                      -\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
        
        public ValidEmail (ref TextBox textBox)
        {
            TextBox = textBox;
        }

        public bool IsValid()
        {
            if (regexEmail.IsMatch(TextBox.Text))
                return true;
            else return false;
        }
    }
}
