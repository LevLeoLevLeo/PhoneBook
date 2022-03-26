using System;
using System.Windows.Controls;
using static WPFTextBoxHelp.Classes.Support.DesrtiptionInterface;

namespace WPFTextBoxHelp.Classes.Support.Validation
{
    /// <summary>
    /// Класс, проверяющий пустой ли TextBox.
    /// </summary>
    public class TxbNull : ITextPassBoxNull
    {
        private TextBox TextBox { get; set; }

        public TxbNull(ref TextBox textbox)
        {
            TextBox = textbox;
        }

        public bool Isnull()
        {
            if (String.IsNullOrEmpty(TextBox.Text) || String.IsNullOrWhiteSpace(TextBox.Text))
                return true;
            else return false;
        }
    }
}
