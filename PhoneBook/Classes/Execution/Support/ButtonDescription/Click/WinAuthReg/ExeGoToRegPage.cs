using PhoneBook.Classes.Support;
using PhoneBook.PageList.PageAuthReg;
using System.Windows.Controls;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg
{
    /// <summary>
    /// Переход на страницу регистрации.
    /// </summary>
    class ExeGoToRegPage : IClick
    {
        private Button ButtonAuth { get; set; }
        private Button ButtonReg { get; set; }

        public ExeGoToRegPage(ref Button buttonAuth, ref Button buttonReg)
        {
            ButtonAuth = buttonAuth;
            ButtonReg = buttonReg;
        }
        public void Click()
        {
            ButtonAuth.IsDefault = false;
            ButtonReg.IsDefault = true;
            NavigationFrame.frame.Navigate(new PageReg());
        }
    }
}
