using System;
using System.Data;
using System.Windows.Forms;

namespace AirportInformationSystem
{
    /// <summary>
    /// Форма добавления/изменения данных о пассажире
    /// </summary>
    public partial class EditPassengerForm : Form
    {
        /// <summary>
        /// Таблица, в которой добавляются/изменяются данные о пассажире
        /// </summary>
        private readonly AirportDataBaseDataSet.ПассажирDataTable _table;

        /// <summary>
        /// Строка, которая будет добавлена в таблицу, или изменяемая строка из таблицы
        /// </summary>
        private AirportDataBaseDataSet.ПассажирRow _row;

        /// <summary>
        /// Инициализирует новый экземпляр класса AirportInformationSystem.EditPassengerForm
        /// </summary>
        /// <param name="table">Таблица, в которой добавляются/изменяются данные о пассажире</param>
        /// <param name="row">Изменяемая строка, если параметр не задан, это означает, что в table нужно добавить новую строку</param>
        public EditPassengerForm(AirportDataBaseDataSet.ПассажирDataTable table, AirportDataBaseDataSet.ПассажирRow row = null)
        {
            InitializeComponent();

            _table = table;
            _row = row;

            _surnameTextBox.MaxLength = _table.ФамилияColumn.MaxLength;
            _nameTextBox.MaxLength = _table.ИмяColumn.MaxLength;
            _patronymicTextBox.MaxLength = _table.ОтчествоColumn.MaxLength;

            if (_row != null)
            {
                _flightIdTextBox.Text = _row.Field<int>("Номер рейса").ToString();
                _passportSeriesMaskedTextBox.Text = _row.Field<string>("Серия паспорта");
                _passportNumberMaskedTextBox.Text = _row.Field<string>("Номер паспорта");
                _surnameTextBox.Text = _row.Field<string>("Фамилия");
                _nameTextBox.Text = _row.Field<string>("Имя");
                _patronymicTextBox.Text = _row.Field<string>("Отчество");
                _birthDateMaskedTextBox.Text = _row.IsNull("Дата рождения") ? null : _row.Field<DateTime>("Дата рождения").ToString();
                _genderComboBox.Text = _row.Field<string>("Пол") == "м" ? "мужской" : "женский";
            }
            _genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
            object flightId = null;
            object passportSeries = null;
            object passportNumber = null;
            object surname = null;
            object name = null;
            object patronymic = null;
            object birthDate = null;
            object gender = null;

            // Проверка номера рейса
            try
            {
                flightId = Convert.ToInt32(_flightIdTextBox.Text);
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

            // Проверка серии паспорта
            if (_passportSeriesMaskedTextBox.MaskCompleted)
            {
                passportSeries = _passportSeriesMaskedTextBox.Text;
            }
            else
            {
                MessageBox.Show("Не указана серия паспорта", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // Проверка номера паспорта
            if (_passportNumberMaskedTextBox.MaskCompleted)
            {
                passportNumber = _passportNumberMaskedTextBox.Text;
            }
            else
            {
                MessageBox.Show("Не указан номер паспорта", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // Проверка фамилии
            if (_surnameTextBox.Text != string.Empty)
            {
                surname = _surnameTextBox.Text;
            }

            // Проверка имени
            if (_nameTextBox.Text != string.Empty)
            {
                name = _nameTextBox.Text;
            }

            // Проверка отчества
            if (_patronymicTextBox.Text != string.Empty)
            {
                patronymic = _patronymicTextBox.Text;
            }

            // Проверка даты рождения
            if (_birthDateMaskedTextBox.Text != "  .  .")
            {
                try
                {
                    birthDate = Convert.ToDateTime(_birthDateMaskedTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Дата рождения имеет имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            // Проверка пола
            if (_genderComboBox.Text != string.Empty)
            {
                gender = _genderComboBox.Text == "мужской" ? "м" : "ж";
            }
            
            // Изменяемая строка из таблицы
            if (_row != null)
            {
                try
                {
                    _row.SetField<object>("Номер рейса", flightId);
                    _row.SetField<object>("Серия паспорта", passportSeries);
                    _row.SetField<object>("Номер паспорта", passportNumber);
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Поля: номер рейса, серия паспорта, номер паспорта, должны быть уникальной комбинацией",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                _row.SetField<object>("Фамилия", surname);
                _row.SetField<object>("Имя", name);
                _row.SetField<object>("Отчество", patronymic);
                _row.SetField<object>("Дата рождения", birthDate);
                _row.SetField<object>("Пол", gender);
            }

            // Добавляемая в таблицу строка
            else
            {
                _row = _table.NewПассажирRow();

                _row.Номер_рейса = (int)flightId;
                _row.Серия_паспорта = (string)passportSeries;
                _row.Номер_паспорта = (string)passportNumber;
                _row.Фамилия = (string)surname;
                _row.Имя = (string)name;
                _row.Отчество = (string)patronymic;
                if (birthDate != null)
                {
                    _row.Дата_рождения = (DateTime)birthDate;
                }
                _row.Пол = (string)gender;
                try
                {
                    _table.AddПассажирRow(_row);
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Поля: номер рейса, серия паспорта, номер паспорта, должны быть уникальной комбинацией",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            Close();
        }

        /// <summary>
        /// Обрабатывает событие изменение текста в поле _flightIdTextBox:
        /// оставляет в тексте только допустимые символы
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _flightIdTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если текстовое поле изменено пользователем
            if (_flightIdTextBox.Modified)
            {
                // выполнить фильтрацию текста, оставив только символы
                // представляющие целое беззнаковое число
                Verification.FilterInt(ref _flightIdTextBox);
            }
        }
    }
}
