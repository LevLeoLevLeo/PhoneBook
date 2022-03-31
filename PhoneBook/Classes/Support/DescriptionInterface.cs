using System;
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
        
        /// <summary>
        /// Интерфейс, описывающий логику при инициализации окна/страницы.
        /// </summary>
        public interface IInit
        {
            /// <summary>
            /// Происходит при инициализации окна/страницы.
            /// </summary>
            void Initialization();
        }

        /// <summary>
        /// Интерфейс, описывающий происходящее при изменеии текста в Text/PasswordBox'ас.
        /// </summary>
        public interface ITextPassChange
        {
            /// <summary>
            /// Происходит при изменении текста в Text/PasswordBox'ас.
            /// </summary>
            void TextPassChange();
        }
        
        /// <summary>
        /// Интерфейс, описывающий показ пароля.
        /// </summary>
        public interface IShowPassword
        {
            /// <summary>
            /// Реализует показ пароля.
            /// </summary>
            void ShowPassword();
        }
    }
}
