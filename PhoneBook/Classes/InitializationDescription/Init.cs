using PhoneBook.Classes.InitializationDescription.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
    }
}
