using PhoneBook.Classes.InitializationDescription.Support;
using System.Windows.Controls;
using static PhoneBook.Classes.EnumNameSpace.WinMessageBox.EnumWinMessageBox;

namespace PhoneBook.Classes.InitializationDescription
{
    public class Init
    {
        /// <summary>
        /// Инициализация окна авторизации/регистрации.
        /// </summary>
        /// <param name="frame"></param>
        public static void WinAuthPage(Frame frame)
        {
            InitWinAuthReg initWinAuthReg = new InitWinAuthReg(ref frame);
            initWinAuthReg.Initialization();
        }
        public static void WinMessageBox(string TextMessage, TextBlock TextBlock,
            TypeMessage TypeMessage, ButtonEn ButtonEn, Button ButtonOk,
            Button ButtonNo, Button ButtonYes, Button ButtonCancel)
        {
            InitWinMessageBox initWinMessageBox = new InitWinMessageBox(ref TextMessage,
                ref TextBlock, ref TypeMessage, ref ButtonEn, ref ButtonOk, ref ButtonNo,
                ref ButtonYes, ref ButtonCancel);
            initWinMessageBox.Initialization();
        }
    }
}
