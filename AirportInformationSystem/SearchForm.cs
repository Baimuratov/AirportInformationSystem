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
        public string FilterExpression { get; set; }

        public SearchForm(TableName tableName)
        {
            InitializeComponent();

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
                    FilterExpression += string.Format("And [Идентификтор самолёта] = '{0}' ", _planeNameTextBox.Text);
                }
                if (_departureMaskedTextBox.MaskCompleted)
                {
                    FilterExpression += string.Format("And [Дата отправки] = '{0}' ", _departureMaskedTextBox.Text);
                }
                if (_arrivalMaskedTextBox.MaskCompleted)
                {
                    FilterExpression += string.Format("And [Дата прибытия] = '{0}' ", _arrivalMaskedTextBox.Text);
                }
                if (_embarkationsTextBox.Text != string.Empty)
                {
                    FilterExpression += string.Format("And [Пункты посадки] = '{0}' ", _embarkationsTextBox.Text);
                }
                if (_destinationTextBox.Text != string.Empty)
                {
                    FilterExpression += string.Format("And [Пункт назначения] = '{0}' ", _destinationTextBox.Text);
                }
                if (_ticketPriceTextBox.Text != string.Empty)
                {
                    FilterExpression += string.Format("And [Стоимость билета] {0} {1}", _ticketPriceComboBox.SelectedItem, _ticketPriceTextBox.Text);
                }
                MessageBox.Show(FilterExpression);
            }
            else
            {

            }
        }
    }
}
