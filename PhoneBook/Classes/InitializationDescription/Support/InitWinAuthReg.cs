using PhoneBook.Classes.Support;
using PhoneBook.DataBase;
using PhoneBook.PageList.PageAuthReg;
using System.Windows.Controls;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.InitializationDescription.Support
{
    /// <summary>
    /// Описывает логику при инициализации окна авторизации/регистрации.
    /// </summary>
    public class InitWinAuthReg : IInit
    {
        private Frame Frame { get; set; }
        public InitWinAuthReg(ref Frame frame)
        {
            Frame = frame;
        }
        public void Initialization()
        {
            DataBaseEnt.TelephoneBookEntities = new TelephoneBookEntities();
            NavigationFrame.frame = Frame;
            Frame.Navigate(new PageAuth());
        }
    }
}
