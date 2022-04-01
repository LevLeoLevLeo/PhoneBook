namespace WPFTextBoxHelp.Classes.Support
{
    /// <summary>
    /// Описывает интерфейсы для библиотеке WPFTextBoxHelp
    /// </summary>
    public class DesrtiptionInterface
    {
        
        /// <summary>
        /// Интерфейс, описывающий placeholder.
        /// </summary>
        public interface IPlaceHolder
        {
            /// <summary>
            /// Метод, отвечающий за работу placeholder'а.
            /// </summary>
            void PlaceHolder();
        }
       
        /// <summary>
        /// Интерфейс, описывающий проверку Text/PasswordBox на пустоту.
        /// </summary>
        public interface ITextPassBoxNull
        {
            /// <summary>
            /// Bool, возвращающий - пустой ли TextBox.
            /// </summary>
            /// <returns></returns>
            bool Isnull();
        }

        /// <summary>
        /// Интерфейс, описывающий проверку вводимых данных в Text/Passbox
        /// </summary>
        public interface ITextPassBoxValidation
        {
            bool IsValid();
        }

        /// <summary>
        /// Интерфейс, описывающий показ пароля.
        /// </summary>
        public interface IShowPass
        {
            /// <summary>
            /// Реализует показ пароля.
            /// </summary>
            void ShowPass();
        }
    }
}
