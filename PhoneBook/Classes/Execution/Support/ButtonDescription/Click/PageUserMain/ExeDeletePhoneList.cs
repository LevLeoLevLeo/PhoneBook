using PhoneBook.Classes.Support;
using PhoneBook.DataBase;
using PhoneBook.MessageDialog.MessBox;
using System;
using System.Linq;
using System.Windows.Controls;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.PageUserMain
{
    public class ExeDeletePhoneList : IClick
    {
        private ComboBox ComboBox { get; set; }
        public ExeDeletePhoneList(ref ComboBox comboBox)
        {
            ComboBox = comboBox;
        }

        public void Click()
        {
            MessBox messBox = new MessBox("Вы действительно хотите удалить список " +
                $@"'{ComboBox.DisplayMemberPath}'", "Удаление списка", TypeMessage.Information, ButtonEn.YesNo);
            messBox.ShowDialog();
            if (messBox.DialogResult == true)
            {
                PhoneList phoneList = (PhoneList)DataBaseEnt.TelephoneBookEntities.PhoneList.Where(x =>
                Convert.ToInt32(ComboBox.SelectedItem) == x.Id);
                DataBaseEnt.TelephoneBookEntities.PhoneList.Remove(phoneList);
                ComboBox.ItemsSource = DataBaseEnt.TelephoneBookEntities.PhoneList.Where(
                x => x.IdUser == CurrentUser.currentUser.Id).ToList();
                ComboBox.SelectedIndex = 0;
            }
        }
    }
}