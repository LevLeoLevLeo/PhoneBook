using PhoneBook.MessageDialog.MessBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using WPFTextBoxHelp.Classes;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;
using static PhoneBook.Classes.Support.DescriptionInterface;

namespace PhoneBook.Classes.Execution.Support.ButtonDescription.Click.WinAuthReg
{
    internal class ExeVerifyEmail : IClick
    {
        private Window Window { get; set; }
        private string Code { get; set; }
        private System.Windows.Controls.TextBox TextBox { get; set; }
        public ExeVerifyEmail(ref Window window, ref string code, ref System.Windows.Controls.TextBox textBox)
        {
            Window = window;
            Code = code;
            TextBox = textBox;
        }
        public void Click()
        {
            if (!WPFTextPassBox.TextBoxIsNull(TextBox))
            if (TextBox.Text == Code)
            {
                Window.DialogResult = true;
                Window.Close();
            }
            else
            {
                MessBox messBox = new MessBox("Вы ввели неправильный код. Проверьте введенные цифры и повторите еще раз!",
                    "Регистрация", TypeMessage.Warning, ButtonEn.Ok);
                messBox.ShowDialog();
            }
            else
            {
                MessBox messBox = new MessBox("Вы не ввели код!",
                    "Регистрация", TypeMessage.Warning, ButtonEn.Ok);
                messBox.ShowDialog();
            }
        }
    }
}
