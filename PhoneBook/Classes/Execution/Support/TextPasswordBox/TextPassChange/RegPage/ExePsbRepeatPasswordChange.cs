using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.RegPage
{
    public class ExePsbRepeatPasswordChange : ITextPassChange
    {
        private TextBox TextBox { get; set; }
        private PasswordBox PasswordBox { get; set; }
        private TextBlock TextBlock { get; set; }
        public void TextPassChange()
        {
            throw new NotImplementedException();
        }
    }
}
