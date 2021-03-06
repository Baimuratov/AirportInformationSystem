﻿using System;
using System.Windows.Forms;

namespace AirportInformationSystem
{
    /// <summary>
    /// Имя таблицы базы данных, в которой будет производится поиск
    /// </summary>
    public enum TableName
    {
        /// <summary>
        /// Авиарейс
        /// </summary>
        Flight,
        /// <summary>
        /// Пассажир
        /// </summary>
        Passenger,
    }

    /// <summary>
    /// Форма поиска данных
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Имя таблицы базы данных, в которой будет производится поиск
        /// </summary>
        public TableName Table { get; set; }

        /// <summary>
        /// Выражение фильтра, которое составляется из значений, введённых в полях формы
        /// </summary>
        public string FilterExpression { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса AirportInformationSystem.SearchForm
        /// </summary>
        /// <param name="tableName">Имя таблицы базы данных, в которой будет производится поиск</param>
        public SearchForm(TableName tableName)
        {
            InitializeComponent();

            Table = tableName;
            switch (tableName)
            {
                case TableName.Flight:
                    _flightRadioButton.Checked = true;
                    _flightGroupBox.Visible = true;
                    _passengerGroupBox.Visible = false;
                    break;
                case TableName.Passenger:
                    _passengerRadioButton.Checked = true;
                    _passengerGroupBox.Visible = true;
                    _flightGroupBox.Visible = false;
                    break;
            }
            _idComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _idComboBox.SelectedItem = "=";

            _ticketPriceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _ticketPriceComboBox.SelectedItem = "=";

            _flightIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _flightIdComboBox.SelectedItem = "=";

            _passportSeriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _passportSeriesComboBox.SelectedItem = "=";

            _passportNumberComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _passportNumberComboBox.SelectedItem = "=";

            _genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _findButton:
        /// присваивает свойству FilterExpression строку, 
        /// которая составлена из значений, введённых в полях формы
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _findButton_Click(object sender, EventArgs e)
        {
            FilterExpression = string.Empty;

            if (_flightRadioButton.Checked)
            {
                // Составление выражения фильтрации таблицы "Авиарейс"

                if (_idTextBox.Text != string.Empty)
                {
                    FilterExpression += string.Format("[Номер рейса] {0} {1} ", _idComboBox.SelectedItem, _idTextBox.Text);
                }
                if (_planeNameTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "AND ";
                    }
                    FilterExpression += string.Format("[Идентификатор самолёта] LIKE '*{0}*' ", _planeNameTextBox.Text);
                }
                if (_departureMaskedTextBox.Text != "  .  .       :")
                {
                    if (_departureMaskedTextBox.MaskCompleted)
                    {
                        if (FilterExpression != string.Empty)
                        {
                            FilterExpression += "AND ";
                        }
                        FilterExpression += string.Format("[Дата отправления] = '{0}' ", _departureMaskedTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Дата отправления имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (_arrivalMaskedTextBox.Text != "  .  .       :")
                {
                    if (_arrivalMaskedTextBox.MaskCompleted)
                    {
                        if (FilterExpression != string.Empty)
                        {
                            FilterExpression += "AND ";
                        }
                        FilterExpression += string.Format("[Дата прибытия] = '{0}' ", _arrivalMaskedTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Дата прибытия имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (_embarkationsTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "AND ";
                    }
                    FilterExpression += string.Format("[Посадки] LIKE '*{0}*' ", _embarkationsTextBox.Text);
                }
                if (_destinationTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "AND ";
                    }
                    FilterExpression += string.Format("[Назначение] LIKE '*{0}*' ", _destinationTextBox.Text);
                }
                if (_ticketPriceTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "AND ";
                    }
                    FilterExpression += string.Format("[Стоимость билета] {0} {1}", _ticketPriceComboBox.SelectedItem, _ticketPriceTextBox.Text);
                }
            }

            else
            {
                // Составление выражения фильтрации таблицы "Пассажир"

                if (_flightIdTextBox.Text != string.Empty)
                {
                    FilterExpression += string.Format("[Номер рейса] {0} {1} ", _flightIdComboBox.SelectedItem, _flightIdTextBox.Text);
                }
                if (_passportSeriesMaskedTextBox.Text != string.Empty)
                {
                    if (_passportSeriesMaskedTextBox.MaskCompleted)
                    {
                        if (FilterExpression != string.Empty)
                        {
                            FilterExpression += "AND ";
                        }
                        FilterExpression += string.Format("[Серия паспорта] {0} {1} ", _passportSeriesComboBox.SelectedItem, _passportSeriesMaskedTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Серия паспорта имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (_passportNumberMaskedTextBox.Text != string.Empty)
                {
                    if (_passportNumberMaskedTextBox.MaskCompleted)
                    {
                        if (FilterExpression != string.Empty)
                        {
                            FilterExpression += "AND ";
                        }
                        FilterExpression += string.Format("[Номер паспорта] {0} {1} ", _passportNumberComboBox.SelectedItem, _passportNumberMaskedTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Номер паспорта имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (_surnameTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "AND ";
                    }
                    FilterExpression += string.Format("[Фамилия] LIKE '*{0}*' ", _surnameTextBox.Text);
                }
                if (_nameTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "AND ";
                    }
                    FilterExpression += string.Format("[Имя] LIKE '*{0}*' ", _nameTextBox.Text);
                }
                if (_patronymicTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "AND ";
                    }
                    FilterExpression += string.Format("[Отчество] LIKE '*{0}*' ", _patronymicTextBox.Text);
                }
                if (_birthDateMaskedTextBox.Text != "  .  .")
                {
                    if (_birthDateMaskedTextBox.MaskCompleted)
                    {
                        if (FilterExpression != string.Empty)
                        {
                            FilterExpression += "AND ";
                        }
                        FilterExpression += string.Format("[Дата рождения] = '{0}' ", _birthDateMaskedTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Дата рождения имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (_genderComboBox.SelectedItem != null)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "AND ";
                    }
                    FilterExpression += string.Format("[Пол] = '{0}'", _genderComboBox.Text == "мужской" ? "м" : "ж");
                }
            }
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Обрабатывает событие переключение кнопки _flightRadioButton:
        /// перенастраивает форму на поиск авиарейсов
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _flightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_flightRadioButton.Checked)
            {
                _flightGroupBox.Visible = true;
                _passengerGroupBox.Visible = false;
                Table = TableName.Flight;
            }
            else
            {
                _flightGroupBox.Visible = false;
                _passengerGroupBox.Visible = true;
                Table = TableName.Passenger;
            }
        }

        /// <summary>
        /// Обрабатывает событие переключение кнопки _passengerRadioButton:
        /// перенастраивает форму на поиск пассажиров
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _passengerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_passengerRadioButton.Checked)
            {
                _passengerGroupBox.Visible = true;
                _flightGroupBox.Visible = false;
                Table = TableName.Passenger;
            }
            else
            {
                _passengerGroupBox.Visible = false;
                _flightGroupBox.Visible = true;
                Table = TableName.Flight;
            }
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
