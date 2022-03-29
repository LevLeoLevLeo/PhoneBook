using System.Windows.Controls;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

namespace WPFTextBoxHelp.Classes.Support.Validation
{
    /// <summary>
    /// Класс, проверяющий равны ли два PasswordBox'а.
    /// </summary>
    public class PsbRepeatPassword : ITextPassBoxValidation
    {
        private PasswordBox PasswordBox { get; set; }

        private PasswordBox SecondPasswordBox { get; set; }

        public PsbRepeatPassword(ref PasswordBox passwordBox, ref PasswordBox secondPasswordBox)
        {
            PasswordBox = passwordBox;
            SecondPasswordBox = secondPasswordBox;
        }

        public bool IsValid()
        {
            if (PasswordBox == SecondPasswordBox)
                return true;
            else return false;
        }
    }
}
