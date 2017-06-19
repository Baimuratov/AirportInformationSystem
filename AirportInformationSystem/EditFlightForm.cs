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

        private int _index;

        public EditFlightForm(AirportDataBaseDataSet.АвиарейсDataTable table, int index)
        {
            InitializeComponent();

            _table = table;
            _index = index;
            if (_index < _table.Count)
            {
                DataRow row = _table.Rows[_index];

                _idTextBox.Text = row.Field<int>("Номер рейса").ToString();
                _planeNameTextBox.Text = row.Field<string>("Идентификатор самолёта");
                _departureMaskedTextBox.Text = row.IsNull("Дата отправки") ? null : row.Field<DateTime>("Дата отправки").ToString();
                _arrivalMaskedTextBox.Text = row.IsNull("Дата прибытия") ? null : row.Field<DateTime>("Дата прибытия").ToString();
                _embarkationsTextBox.Text = row.Field<string>("Пункты посадки");
                _destinationTextBox.Text = row.Field<string>("Пункт назначения");
                _ticketPriceTextBox.Text = row.IsNull("Стоимость билета") ? null : row.Field<decimal>("Стоимость билета").ToString();
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
            if (!Verification.CheckString(_planeNameTextBox.Text, ref planeName, _table.Идентификатор_самолётаColumn.MaxLength, "Идентификатор самолёта"))
            {
                return;
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
            if (!Verification.CheckString(_embarkationsTextBox.Text, ref embarkations, _table.Пункты_посадкиColumn.MaxLength, "Пункты посадки"))
            {
                return;
            }

            // Проверка пункта назначения
            if (!Verification.CheckString(_destinationTextBox.Text, ref destination, _table.Пункт_назначенияColumn.MaxLength, "Пункт назначения"))
            {
                return;
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
            if (_index < _table.Count)
            {
                DataRow row = _table.Rows[_index];

                try
                {
                    row.SetField<object>("Номер рейса", id);
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Номер рейса должен быть уникальным", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                row.SetField<object>("Идентификатор самолёта", planeName);
                row.SetField<object>("Дата отправки", departure);
                row.SetField<object>("Дата прибытия", arrival);
                row.SetField<object>("Пункты посадки", embarkations);
                row.SetField<object>("Пункт назначения", destination);
                row.SetField<object>("Стоимость билета", ticketPrice);
            }
            else
            {
                AirportDataBaseDataSet.АвиарейсRow row = _table.NewАвиарейсRow();

                row.Номер_рейса = (int)id;
                row.Идентификатор_самолёта = (string)planeName;
                if (departure != null)
                {
                    row.Дата_отправки = (DateTime)departure;
                }
                if (arrival != null)
                {
                    row.Дата_прибытия = (DateTime)arrival;
                }
                row.Пункты_посадки = (string)embarkations;
                row.Пункт_назначения = (string)destination;
                if (ticketPrice != null)
                {
                    row.Стоимость_билета = (decimal)ticketPrice;
                }
                try
                {
                    _table.AddАвиарейсRow(row);
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
