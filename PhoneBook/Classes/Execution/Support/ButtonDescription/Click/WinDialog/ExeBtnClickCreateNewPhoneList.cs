using PhoneBook.MessageDialog.MessBox;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinDialog
{
    public class ExeBtnClickCreateNewPhoneList : IClick
    {
        private TextBox TextBox { get; set; }
        private Window Window { get; set; }
        public ExeBtnClickCreateNewPhoneList(ref TextBox textBox, ref Window window)
        {
            TextBox = textBox;
            Window = window;
        }

        public void Click()
        {
            if (!WPFTextPassBox.TextBoxIsNull(TextBox) && TextBox.Foreground != Brushes.Gray)
            {
                Window.DialogResult = true;
                Window.Close();
            }
            else
            {
                MessBox messBox = new MessBox("Вы не заполнили поле!", "Добавление нового списка",
                    TypeMessage.Warning, ButtonEn.Ok);
                messBox.ShowDialog();
            }
        }
    }
}
