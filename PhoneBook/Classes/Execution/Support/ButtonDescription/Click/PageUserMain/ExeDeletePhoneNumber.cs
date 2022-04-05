using PhoneBook.Classes.Support;
using PhoneBook.DataBase;
using PhoneBook.MessageDialog.MessBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.PageUserMain
{
    public class ExeDeletePhoneNumber : IClick
    {
        private DataGrid DataGrid { get; set; }
        private ComboBox ComboBox { get; set; }
        public ExeDeletePhoneNumber(ref DataGrid dataGrid, ref ComboBox comboBox)
        {
            DataGrid = dataGrid;
            ComboBox = comboBox;
        }
        public void Click()
        {
            try

            {
                MessBox messBox = new MessBox("Вы точно хотите удалить этот номер телефона?",
                    "Удаление телефона", TypeMessage.Information, ButtonEn.YesNo);
                if (DataGrid.SelectedValue != null)
                {
                    var cmb = Convert.ToInt32(ComboBox.SelectedValue);
                    PhoneNumber phoneNumber = (PhoneNumber)DataGrid.SelectedValue;
                    if (messBox.ShowDialog() == true)
                    {
                        var number = DataBaseEnt.TelephoneBookEntities.PhoneNumber
                                        .FirstOrDefault(x => x.Id == phoneNumber.Id);

                        DataBaseEnt.TelephoneBookEntities.PhoneNumber.Remove(number);
                        DataBaseEnt.TelephoneBookEntities.SaveChanges();

                        DataGrid.ItemsSource = DataBaseEnt.TelephoneBookEntities.PhoneNumber.
                            Where(x => x.IdPhoneList == cmb).ToList();
                    }
                }
                else
                {
                    MessBox messBox1 = new MessBox("Для удаление телефона выберите запись.",
                            "Удаление телефона", TypeMessage.Warning, ButtonEn.Ok);
                }
            }
            catch (Exception ex)
            {
                MessBox messBox = new MessBox(ex.Message, "Ошибка", TypeMessage.Error, ButtonEn.Ok);
            }
        }
    }
}