using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportInformationSystem
{
    public enum TableName
    {
        Flight,
        Passenger,
    }
    public partial class SearchForm : Form
    {
        public TableName Table { get; set; }

        public string FilterExpression { get; set; }

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

        private void _findButton_Click(object sender, EventArgs e)
        {
            FilterExpression = string.Empty;

            if (_flightRadioButton.Checked)
            {
                if (_idTextBox.Text != string.Empty)
                {
                    FilterExpression += string.Format("[Номер рейса] {0} {1} ", _idComboBox.SelectedItem, _idTextBox.Text);
                }
                if (_planeNameTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "And ";
                    }
                    FilterExpression += string.Format("[Идентификатор самолёта] = '{0}' ", _planeNameTextBox.Text);
                }
                if (_departureMaskedTextBox.Text != "  .  .       :")
                {
                    if (_departureMaskedTextBox.MaskCompleted)
                    {
                        if (FilterExpression != string.Empty)
                        {
                            FilterExpression += "And ";
                        }
                        FilterExpression += string.Format("[Дата отправки] = '{0}' ", _departureMaskedTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Дата отправки имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (_arrivalMaskedTextBox.Text != "  .  .       :")
                {
                    if (_arrivalMaskedTextBox.MaskCompleted)
                    {
                        if (FilterExpression != string.Empty)
                        {
                            FilterExpression += "And ";
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
                        FilterExpression += "And ";
                    }
                    FilterExpression += string.Format("[Пункты посадки] = '{0}' ", _embarkationsTextBox.Text);
                }
                if (_destinationTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "And ";
                    }
                    FilterExpression += string.Format("[Пункт назначения] = '{0}' ", _destinationTextBox.Text);
                }
                if (_ticketPriceTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "And ";
                    }
                    FilterExpression += string.Format("[Стоимость билета] {0} {1}", _ticketPriceComboBox.SelectedItem, _ticketPriceTextBox.Text);
                }
                //MessageBox.Show(FilterExpression);
            }
            else
            {
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
                            FilterExpression += "And ";
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
                            FilterExpression += "And ";
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
                        FilterExpression += "And ";
                    }
                    FilterExpression += string.Format("[Фамилия] = '{0}' ", _surnameTextBox.Text);
                }
                if (_nameTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "And ";
                    }
                    FilterExpression += string.Format("[Имя] = '{0}' ", _nameTextBox.Text);
                }
                if (_patronymicTextBox.Text != string.Empty)
                {
                    if (FilterExpression != string.Empty)
                    {
                        FilterExpression += "And ";
                    }
                    FilterExpression += string.Format("[Отчество] = '{0}' ", _patronymicTextBox.Text);
                }
                if (_birthDateMaskedTextBox.Text != "  .  .       :")
                {
                    if (_birthDateMaskedTextBox.MaskCompleted)
                    {
                        if (FilterExpression != string.Empty)
                        {
                            FilterExpression += "And ";
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
                        FilterExpression += "And ";
                    }
                    FilterExpression += string.Format("[Пол] = '{0}'", _genderComboBox.SelectedItem);
                }
                //MessageBox.Show(FilterExpression);
            }
            DialogResult = DialogResult.OK;
        }

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

        private void _idTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если текстовое поле изменено пользователем
            if (_idTextBox.Modified)
            {
                // выполнить фильтрацию текста, оставив только символы
                // представляющие натуральное или дробное число
                Verification.FilterInt(ref _idTextBox);
            }
        }

        private void _ticketPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_ticketPriceTextBox.Modified)
            {
                Verification.FilterDouble(ref _ticketPriceTextBox);
            }
        }

        private void _flightIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_flightIdTextBox.Modified)
            {
                Verification.FilterInt(ref _flightIdTextBox);
            }
        }
    }
}
