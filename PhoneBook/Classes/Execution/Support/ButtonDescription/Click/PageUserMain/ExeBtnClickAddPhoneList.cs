using PhoneBook.Classes.Support;
using PhoneBook.DataBase;
using PhoneBook.MessageDialog.MessBox;
using PhoneBook.WindowList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.PageUserMain
{
    public class ExeBtnClickAddPhoneList
    {
        private ComboBox ComboBox { get; set; }

        public ExeBtnClickAddPhoneList(ref ComboBox comboBox)
        {

            ComboBox = comboBox;

        }

        public void AddPhoneList()
        {

            WinAddList winAddList = new WinAddList();
            if (winAddList.ShowDialog() == true)
            {

                try
                {
                    PhoneList phoneList = new PhoneList
                    {

                        IdUser = CurrentUser.currentUser.Id,
                        Name = winAddList.TxbNewPhoneList.Text,

                    };

                    DataBaseEnt.TelephoneBookEntities.PhoneList.Add(phoneList);
                    DataBaseEnt.TelephoneBookEntities.SaveChanges();

                    ComboBox.ItemsSource = DataBaseEnt.TelephoneBookEntities.PhoneList.Where(
                        x => x.IdUser == CurrentUser.currentUser.Id).ToList();
                    winAddList.Close();
                    MessBox messBox = new MessBox("Новый список создан.", "Создание нового списка",
                        TypeMessage.Information, ButtonEn.Ok);

                }

                catch (Exception ex)
                {

                    MessBox messBox = new MessBox(ex.Message, "Создание нового списка",
                        TypeMessage.Error, ButtonEn.Ok);

                }

            }

        }
    }
}
