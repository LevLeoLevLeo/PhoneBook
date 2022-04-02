using PhoneBook.DataBase;

namespace PhoneBook.Classes.Support
{
    /// <summary>
    /// Содержит данные авторизированного пользователя.
    /// </summary>
    public class CurrentUser
    {
        /// <summary>
        /// Авторизированный пользователь.
        /// </summary>
        public static User currentUser;
    }
}
