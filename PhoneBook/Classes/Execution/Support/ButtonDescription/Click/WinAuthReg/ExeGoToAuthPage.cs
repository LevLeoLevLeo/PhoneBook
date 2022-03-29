using PhoneBook.Classes.Support;
using PhoneBook.PageList.PageAuthReg;
using System.Windows.Controls;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg
{
    /// <summary>
    /// Переход на страницу авторизации.
    /// </summary>
    public class ExeGoToAuthPage : IGoToPage
    {
        private Button ButtonAuth { get; set; }
        private Button ButtonReg { get; set; }

        public ExeGoToAuthPage (ref Button buttonAuth, ref Button buttonReg)
        {
            ButtonAuth = buttonAuth;
            ButtonReg = buttonReg;
        }
        public void GoToPage()
        {
            ButtonAuth.IsDefault = true;
            ButtonReg.IsDefault = false;
            NavigationFrame.frame.Navigate(new PageAuth());
        }
    }
}
