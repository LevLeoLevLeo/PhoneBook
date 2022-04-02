using PhoneBook.Classes.Support;
using System;
using System.Linq;
using System.Windows.Controls;

namespace PhoneBook.Classes.Execution.Support.ComboBoxDescription.SelectionChange.PageMainUser
{
    public class ExeCmbPhoneListChange
    {
        private ComboBox ComboBox { get; set; }
        private DataGrid DataGrid { get; set; }
        public ExeCmbPhoneListChange(ref ComboBox comboBox, ref DataGrid dataGrid)
        {
            ComboBox = comboBox;
            DataGrid = dataGrid;
        }
        public void Change()
        {
            int y = Convert.ToInt32(ComboBox.SelectedValue);
            DataGrid.ItemsSource = DataBaseEnt.TelephoneBookEntities.PhoneNumber.Where(x => x.IdPhoneList == y).ToList();
        }
    }
}
