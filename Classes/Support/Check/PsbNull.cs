using System;
using System.Windows.Controls;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

namespace WPFTextBoxHelp.Classes.Support.Check
{
    /// <summary>
    /// Класс, проверяющий пустой ли PasswordBox
    /// </summary>
    public class PsbNull : ITextPassBoxNull
    {
        private PasswordBox PasswordBox { get; set; }

        public PsbNull (ref PasswordBox passwordBox)
        {
            PasswordBox = passwordBox;
        }

        public bool Isnull()
        {
            if (String.IsNullOrEmpty(PasswordBox.Password) &&
               String.IsNullOrWhiteSpace(PasswordBox.Password))
                return true;
            else return false;
        }
    }
}
