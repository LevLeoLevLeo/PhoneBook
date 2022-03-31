using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.CheckBoxDescription.Click.AuthRegPage
{
    public class ExeChckBoxShowPass : IShowPassword
    {
        private CheckBox CheckBox { get; set; }
        private TextBox TextBox { get; set; }
        private PasswordBox PasswordBox { get; set; }
        public ExeChckBoxShowPass(ref CheckBox checkBox, ref TextBox textBox,
            ref PasswordBox passwordBox)
        {
            CheckBox = checkBox;
            TextBox = textBox;
            PasswordBox = passwordBox;
        }
        public void ShowPassword()
        {
            WPFTextPassBox.CheckBoxShowPassword(CheckBox, TextBox, PasswordBox);
        }
    }
}
