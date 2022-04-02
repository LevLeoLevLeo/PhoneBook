using PhoneBook.Classes.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.InitializationDescription.Support
{
    /// <summary>
    /// Класс, описывающий инициализацию главной страницы пользователя.
    /// </summary>
    public class InitPageUser : IInit
    {
        private ComboBox ComboBox { get; set; }
        public InitPageUser(ref ComboBox comboBox)
        {
            ComboBox = comboBox;
        }
        public void Initialization()
        {
            ComboBox.SelectedValuePath = "Id";
            ComboBox.DisplayMemberPath = "Name";
            ComboBox.ItemsSource = DataBaseEnt.TelephoneBookEntities.PhoneList.Where(
                x => x.IdUser == CurrentUser.currentUser.Id).ToList();
            ComboBox.SelectedIndex = 0;
        }
    }
}
