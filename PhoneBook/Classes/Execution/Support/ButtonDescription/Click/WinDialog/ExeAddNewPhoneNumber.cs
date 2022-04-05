using PhoneBook.Classes.Support;
using PhoneBook.DataBase;
using PhoneBook.MessageDialog.MessBox;
using PhoneBook.WindowList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinDialog
{
    public class ExeAddNewPhoneNumber : IClick
    {
        private TextBox TextBoxName { get; set; }
        private TextBox TextBoxNumber { get; set; }
        private TextBox TextBoxDescription { get; set; }
        private ComboBox ComboBox { get; set; }
        public ExeAddNewPhoneNumber(ref TextBox textBoxName, ref TextBox textBoxNumber,
            ref TextBox textBoxDescription, ref ComboBox comboBox)
        {
            TextBoxName = textBoxName;
            TextBoxNumber = textBoxNumber;
            TextBoxDescription = textBoxDescription;
            ComboBox = comboBox;
        }

        public void Click()
        {
            try
            {
                if (WPFTextPassBox.TextBoxIsNull(TextBoxName) && WPFTextPassBox.TextBoxIsNull(TextBoxNumber) &&
                    WPFTextPassBox.TextBoxIsNull(TextBoxDescription) || TextBoxName.Foreground == Brushes.Gray ||
                    TextBoxNumber.Foreground == Brushes.Gray || TextBoxDescription.Foreground == Brushes.Gray)
                {
                   MessBox messBox = new MessBox("Вы заполнили не все поля.", "Внимание!",
                       TypeMessage.Warning, ButtonEn.Ok);
                    messBox.ShowDialog();
                }
                else 
                {
                    PhoneNumber phoneNumber = new PhoneNumber()
                    {
                        Name = TextBoxName.Text,
                        Number = TextBoxNumber.Text,
                        Description = TextBoxDescription.Text,
                        IdPhoneList = Convert.ToInt32(ComboBox.SelectedValue),
                    };
                    DataBaseEnt.TelephoneBookEntities.PhoneNumber.Add(phoneNumber);
                    DataBaseEnt.TelephoneBookEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessBox messBox = new MessBox(ex.Message, "Ошибка",
                    TypeMessage.Error, ButtonEn.Ok);
                messBox.ShowDialog();
            }
        }
    }
}
