using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportInformationSystem
{
    public partial class FlightControl : UserControl
    {
        private AirportDataBaseDataSet.АвиарейсDataTable _table;

        private int _index;

        public FlightControl(AirportDataBaseDataSet.АвиарейсDataTable table, int index)
        {
            InitializeComponent();

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

        public bool CheckFields()
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
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Номера авиарейса вызывает переполнение", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            // Проверка идентификатора самолёта
            if (!Verification.CheckString(_planeNameTextBox.Text, ref planeName, _table.Идентификатор_самолётаColumn.MaxLength, "Идентификатор самолёта"))
            {
                return false;
            }

            // Проверка даты отправления
            if (!Verification.CheckDate(_departureMaskedTextBox.Text, ref departure, "Дата отправления"))
            {
                return false;
            }

            // Проверка даты прибытия
            if (!Verification.CheckDate(_arrivalMaskedTextBox.Text, ref arrival, "Дата прибытия"))
            {
                return false;
            }

            // Проверка пунктов посадки
            if (!Verification.CheckString(_embarkationsTextBox.Text, ref embarkations, _table.Пункты_посадкиColumn.MaxLength, "Пункты посадки"))
            {
                return false;
            }

            // Проверка пункта назначения
            if (!Verification.CheckString(_destinationTextBox.Text, ref destination, _table.Пункт_назначенияColumn.MaxLength, "Пункт назначения"))
            {
                return false;
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
                    return false;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Стоимость билета вызывает переполнение", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            }
            return true;
        }
    }
}
