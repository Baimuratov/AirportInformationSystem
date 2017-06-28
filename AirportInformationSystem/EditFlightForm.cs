using System;
using System.Data;
using System.Windows.Forms;

namespace AirportInformationSystem
{
    /// <summary>
    /// Форма добавления/изменения данных об авиарейсе
    /// </summary>
    public partial class EditFlightForm : Form
    {
        /// <summary>
        /// Таблица, в которой добавляются/изменяются данные об авиарейсе
        /// </summary>
        private readonly AirportDataBaseDataSet.АвиарейсDataTable _table;

        /// <summary>
        /// Строка, которая будет добавлена в таблицу, или изменяемая строка из таблицы
        /// </summary>
        private AirportDataBaseDataSet.АвиарейсRow _row;

        /// <summary>
        /// Инициализирует новый экземпляр класса AirportInformationSystem.EditFlightForm
        /// </summary>
        /// <param name="table">Таблица, в которой добавляются/изменяются данные об авиарейсе</param>
        /// <param name="row">Изменяемая строка, если параметр не задан, это означает, что в table нужно добавить новую строку</param>
        public EditFlightForm(AirportDataBaseDataSet.АвиарейсDataTable table, AirportDataBaseDataSet.АвиарейсRow row = null)
        {
            InitializeComponent();

            _table = table;
            _row = row;

            _planeNameTextBox.MaxLength = _table.Идентификатор_самолётаColumn.MaxLength;
            _embarkationsTextBox.MaxLength = _table.ПосадкиColumn.MaxLength;
            _destinationTextBox.MaxLength = _table.НазначениеColumn.MaxLength;

            if (_row != null)
            {
                _idTextBox.Text = _row.Field<int>("Номер рейса").ToString();
                _planeNameTextBox.Text = _row.Field<string>("Идентификатор самолёта");
                _departureMaskedTextBox.Text = _row.IsNull("Дата отправления") ? null : _row.Field<DateTime>("Дата отправления").ToString();
                _arrivalMaskedTextBox.Text = _row.IsNull("Дата прибытия") ? null : _row.Field<DateTime>("Дата прибытия").ToString();
                _embarkationsTextBox.Text = _row.Field<string>("Посадки");
                _destinationTextBox.Text = _row.Field<string>("Назначение");
                _ticketPriceTextBox.Text = _row.IsNull("Стоимость билета") ? null : _row.Field<decimal>("Стоимость билета").ToString();
            }
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _okButton:
        /// заносит данные введённые в текстовых полях в базу данных
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _okButton_Click(object sender, EventArgs e)
        {
            // Переменные, в которых хранятся сконвертированные значения из полей,
            // пока не закончилась проверка всех введённых данных. 
            // Общий тип object выбран потому что не все типы (int, DateTime) допускают значение null
            object id = null;
            object planeName = null;
            object departure = null;
            object arrival = null;
            object embarkations = null;
            object destination = null;
            object ticketPrice = null;

            // Проверка номера
            try
            {
                id = Convert.ToInt32(_idTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Номер авиарейса должен быть положительным целым числом", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Номера авиарейса вызывает переполнение", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // Проверка идентификатора самолёта
            if (_planeNameTextBox.Text != string.Empty)
            {
                planeName = _planeNameTextBox.Text;
            }

            // Проверка даты отправления
            if (!Verification.CheckDateTime(_departureMaskedTextBox.Text, ref departure, "Дата отправления"))
            {
                return;
            }

            // Проверка даты прибытия
            if (!Verification.CheckDateTime(_arrivalMaskedTextBox.Text, ref arrival, "Дата прибытия"))
            {
                return;
            }

            // Проверка пунктов посадки
            if (_embarkationsTextBox.Text != string.Empty)
            {
                embarkations = _embarkationsTextBox.Text;
            }

            // Проверка пункта назначения
            if (_destinationTextBox.Text != string.Empty)
            {
                destination = _destinationTextBox.Text;
            }

            // Проверка стоимости билета
            if (_ticketPriceTextBox.Text == string.Empty)
            {
                ticketPrice = null;
            }
            else
            {
                try
                {
                    ticketPrice = Convert.ToDecimal(_ticketPriceTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Стоимость билета должна быть положительным числом", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Стоимость билета вызывает переполнение", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            
            // Изменяемая строка из таблицы
            if (_row != null)
            {
                try
                {
                    _row.SetField<object>("Номер рейса", id);
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Номер рейса должен быть уникальным", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                _row.SetField<object>("Идентификатор самолёта", planeName);
                _row.SetField<object>("Дата отправления", departure);
                _row.SetField<object>("Дата прибытия", arrival);
                _row.SetField<object>("Посадки", embarkations);
                _row.SetField<object>("Назначение", destination);
                _row.SetField<object>("Стоимость билета", ticketPrice);
            }
            
            // Добавляемая в таблицу строка
            else
            {
                _row = _table.NewАвиарейсRow();

                _row.Номер_рейса = (int)id;
                _row.Идентификатор_самолёта = (string)planeName;
                if (departure != null)
                {
                    _row.Дата_отправления = (DateTime)departure;
                }
                if (arrival != null)
                {
                    _row.Дата_прибытия = (DateTime)arrival;
                }
                _row.Посадки = (string)embarkations;
                _row.Назначение = (string)destination;
                if (ticketPrice != null)
                {
                    _row.Стоимость_билета = (decimal)ticketPrice;
                }
                try
                {
                    _table.AddАвиарейсRow(_row);
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Номер рейса должен быть уникальным", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            Close();
        }

        /// <summary>
        /// Обрабатывает событие изменение текста в поле _idTextBox:
        /// оставляет в тексте только допустимые символы
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _idTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если текстовое поле изменено пользователем
            if (_idTextBox.Modified)
            {
                // выполнить фильтрацию текста, оставив только символы
                // представляющие целое беззнаковое число
                Verification.FilterInt(ref _idTextBox);
            }
        }

        /// <summary>
        /// Обрабатывает событие изменение текста в поле _ticketPriceTextBox:
        /// оставляет в тексте только допустимые символы
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _ticketPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если текстовое поле изменено пользователем
            if (_ticketPriceTextBox.Modified)
            {
                // выполнить фильтрацию текста, оставив только символы
                // представляющие натуральное или дробное число
                Verification.FilterDouble(ref _ticketPriceTextBox);
            }
        }
    }
}
