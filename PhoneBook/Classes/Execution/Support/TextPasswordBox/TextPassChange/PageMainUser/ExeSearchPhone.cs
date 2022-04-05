using PhoneBook.Classes.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.TextPasswordBox.TextPassChange.PageMainUser
{
    public class ExeSearchPhone :ITextPassChange
    {
        private TextBox TextBox { get; set; }
        private ComboBox ComboBox { get; set; }
        private DataGrid DataGrid { get; set; }
        public ExeSearchPhone(ref TextBox textBox, 
            ref ComboBox comboBox, ref DataGrid dataGrid)
        {
            TextBox = textBox;
            ComboBox = comboBox;
            DataGrid = dataGrid;
        }
        public void TextPassChange()
        {
            var IdList = Convert.ToInt32(ComboBox.SelectedValue);
            if (TextBox.Foreground != Brushes.Gray && !WPFTextPassBox.TextBoxIsNull(TextBox))
            {
                DataGrid.ItemsSource = DataBaseEnt.TelephoneBookEntities.PhoneNumber.Where(x =>
                x.PhoneList.IdUser == CurrentUser.currentUser.Id &&
                x.Name.Contains(TextBox.Text) || x.PhoneList.IdUser == CurrentUser.currentUser.Id &&
                x.Description.Contains(TextBox.Text) || x.PhoneList.IdUser == CurrentUser.currentUser.Id &&
                x.Number.Contains(TextBox.Text)).ToList();
            }
            else
            {
                DataGrid.ItemsSource = DataBaseEnt.TelephoneBookEntities.PhoneNumber.Where(x =>
                x.IdPhoneList == IdList) .ToList();
            }
        }
    }
}
