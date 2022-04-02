namespace PhoneBook.Classes.Support
{
    /// <summary>
    /// Класс, содержащий интерфейсы приложения.
    /// </summary>
    public class DescriptionInterface
    {
        /// <summary>
        /// Интерфейс, описывающий событие "click".
        /// </summary>
        public interface IClick
        {
            /// <summary>
            /// Переход на другую страницу.
            /// </summary>
            void Click();
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
