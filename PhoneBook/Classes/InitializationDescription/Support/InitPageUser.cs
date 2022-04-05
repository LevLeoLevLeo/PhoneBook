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
        private DataGrid DataGrid { get; set; }
        private ComboBox ComboBox { get; set; }
        public InitPageUser(ref DataGrid dataGrid, ref ComboBox comboBox)
        {
            DataGrid = dataGrid;
            ComboBox = comboBox;
        }
        public void Initialization()
        {
            ComboBox.SelectedValuePath = "Id";
            ComboBox.DisplayMemberPath = "Name";
            ComboBox.ItemsSource = DataBaseEnt.TelephoneBookEntities.PhoneList.Where(
                x => x.IdUser == CurrentUser.currentUser.Id).ToList();
            ComboBox.SelectedIndex = 0;
            int y = Convert.ToInt32(ComboBox.SelectedValue);
            DataGrid.ItemsSource = DataBaseEnt.TelephoneBookEntities.PhoneNumber.Where(x =>
            x.IdPhoneList == y).ToList();
        }
    }
}
