using PhoneBook.Classes.InitializationDescription.Support;
using System.Windows;
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

        /// <summary>
        /// Инициализация кастомного messagebox'а.
        /// </summary>
        /// <param name="TextMessage"></param>
        /// <param name="TextBlock"></param>
        /// <param name="TypeMessage"></param>
        /// <param name="ButtonEn"></param>
        /// <param name="ButtonOk"></param>
        /// <param name="ButtonNo"></param>
        /// <param name="ButtonYes"></param>
        /// <param name="ButtonCancel"></param>
        public static void WinMessageBox(Window Window, string TextMessage, string TextTitle, TextBlock TextBlock,
            TypeMessage TypeMessage, ButtonEn ButtonEn, Button ButtonOk,
            Button ButtonNo, Button ButtonYes, Button ButtonCancel, ref Image image)
        {
            InitWinMessageBox initWinMessageBox = new InitWinMessageBox(ref Window, ref TextMessage, ref TextTitle,
                ref TextBlock, ref TypeMessage, ref ButtonEn, ref ButtonOk, ref ButtonNo,
                ref ButtonYes, ref ButtonCancel, ref image);
            initWinMessageBox.Initialization();
        }
    }
}
