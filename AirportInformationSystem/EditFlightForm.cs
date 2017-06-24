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
    public partial class EditFlightForm : Form
    {
        private AirportDataBaseDataSet.АвиарейсDataTable _table;

        private AirportDataBaseDataSet.АвиарейсRow _row;

        public EditFlightForm(AirportDataBaseDataSet.АвиарейсDataTable table, AirportDataBaseDataSet.АвиарейсRow row = null)
        {
            InitializeComponent();

            _table = table;
            _row = row;

            _planeNameTextBox.MaxLength = _table.Идентификатор_самолётаColumn.MaxLength;
            _embarkationsTextBox.MaxLength = _table.Пункты_посадкиColumn.MaxLength;
            _destinationTextBox.MaxLength = _table.Пункт_назначенияColumn.MaxLength;

            if (_row != null)
            {
                _idTextBox.Text = _row.Field<int>("Номер рейса").ToString();
                _planeNameTextBox.Text = _row.Field<string>("Идентификатор самолёта");
                _departureMaskedTextBox.Text = _row.IsNull("Дата отправления") ? null : _row.Field<DateTime>("Дата отправления").ToString();
                _arrivalMaskedTextBox.Text = _row.IsNull("Дата прибытия") ? null : _row.Field<DateTime>("Дата прибытия").ToString();
                _embarkationsTextBox.Text = _row.Field<string>("Пункты посадки");
                _destinationTextBox.Text = _row.Field<string>("Пункт назначения");
                _ticketPriceTextBox.Text = _row.IsNull("Стоимость билета") ? null : _row.Field<decimal>("Стоимость билета").ToString();
            }
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
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
            if (!Verification.CheckDate(_departureMaskedTextBox.Text, ref departure, "Дата отправления"))
            {
                return;
            }

            // Проверка даты прибытия
            if (!Verification.CheckDate(_arrivalMaskedTextBox.Text, ref arrival, "Дата прибытия"))
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
                _row.SetField<object>("Пункты посадки", embarkations);
                _row.SetField<object>("Пункт назначения", destination);
                _row.SetField<object>("Стоимость билета", ticketPrice);
            }
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
                _row.Пункты_посадки = (string)embarkations;
                _row.Пункт_назначения = (string)destination;
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
    }
}
