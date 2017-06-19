using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AirportInformationSystem
{
    /// <summary>
    /// Инкапсулирует методы проверки текста
    /// </summary>
    public static class Verification
    {
        /// <summary>
        /// Изменяет значение свойства Text элемента управления TextBox,
        /// оставляя только символы, которые будут представлять натуральное число
        /// </summary>
        /// <param name="textBox"></param>
        public static void FilterInt(ref TextBox textBox)
        {
            string text = textBox.Text;
            int cursorPosition = textBox.SelectionStart;
            int deletedSymbols = 0;

            // удаление из текста всех символов, кроме десятичных цифр
            text = Regex.Replace(text, @"[^\d]", (Match match) => { deletedSymbols++; return string.Empty; });
            textBox.Text = text;
            textBox.SelectionStart = cursorPosition - deletedSymbols;
            textBox.Modified = false;
        }

        /// <summary>
        /// Изменяет значение свойства Text элемента управления TextBox,
        /// оставляя только символы, которые будут представлять натуральное или дробное число
        /// </summary>
        /// <param name="textBox">передаваемый по ссылке элемент управления TextBox</param>
        public static void FilterDouble(ref TextBox textBox)
        {
            string text = textBox.Text;
            int cursorPosition = textBox.SelectionStart;
            int deletedSymbols = 0;

            // удаление из текста всех символов, кроме десятичных цифр и запятых
            text = Regex.Replace(text, @"[^\d | \,]", (Match match) => { deletedSymbols++; return string.Empty; });

            bool textHasComma = false;

            // Делегат, указывающий на метод, который будет
            // вызываться при каждом обнаружении запятой в тексте.
            // Возвращает заменяющую строку
            MatchEvaluator myEvaluator = delegate (Match match)
            {
                if (!textHasComma)
                {
                    textHasComma = true;
                    return ",";
                }
                else
                {
                    deletedSymbols++;
                    return string.Empty;
                }
            };

            // Удаление из текста всех запятых, кроме первой
            text = Regex.Replace(text, @"\,", myEvaluator);

            textBox.Text = text;
            textBox.SelectionStart = cursorPosition - deletedSymbols;
            textBox.Modified = false;
        }

        public static bool CheckString(string verifiableText, ref object variable, int maxLength, string name)
        {
            if (verifiableText == string.Empty)
            {
                variable = null;
            }
            else
            {
                int difference = verifiableText.Length - maxLength;
                if (difference > 0)
                {
                    MessageBox.Show(string.Format("{0} превышает допустимую длину на {1}", name, difference), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                variable = verifiableText;
            }
            return true;
        }

        public static bool CheckNotEmptyString(string verifiableText, ref object variable, int maxLength, string name)
        {
            if (verifiableText == string.Empty)
            {
                variable = null;
                MessageBox.Show(string.Format("Поле {0} не должно быть пустым", name), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                int difference = verifiableText.Length - maxLength;
                if (difference > 0)
                {
                    MessageBox.Show(string.Format("{0} превышает допустимую длину на {1}", name, difference), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                variable = verifiableText;
            }
            return true;
        }

        public static bool CheckDate(string verifiableText, ref object variable, string name)
        {
            if (verifiableText == "  .  .       :")
            {
                variable = null;
            }
            else
            {
                try
                {
                    variable = Convert.ToDateTime(verifiableText);
                }
                catch (FormatException)
                {
                    MessageBox.Show(string.Format("{0} имеет неправильный формат", name), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            }
            return true;
        }
    }
}
