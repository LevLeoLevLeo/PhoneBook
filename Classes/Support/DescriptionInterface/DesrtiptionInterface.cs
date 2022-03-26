using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFTextBoxHelp.Classes.Support
{
    /// <summary>
    /// Описывает интерфейсы для библиотеке WPFTextBoxHelp
    /// </summary>
    public class DesrtiptionInterface
    {
        /// <summary>
        /// Интерфейс для placeholder'а
        /// </summary>
        public interface IPlaceHolder
        {
            /// <summary>
            /// Метод, отвечающий за работу placeholder'а у textbox'а.
            /// </summary>
            void PlaceHolder();
        }
    }
}
