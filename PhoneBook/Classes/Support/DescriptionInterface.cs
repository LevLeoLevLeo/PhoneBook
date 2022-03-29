﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Classes.Support
{
    /// <summary>
    /// Класс, содержащий интерфейсы приложения.
    /// </summary>
    public class DescriptionInterface
    {
        /// <summary>
        /// Интерфейс, описывающий переход на другую страницу.
        /// </summary>
        public interface IGoToPage
        {
            /// <summary>
            /// Переход на другую страницу.
            /// </summary>
            void GoToPage();
        }
    }
}
