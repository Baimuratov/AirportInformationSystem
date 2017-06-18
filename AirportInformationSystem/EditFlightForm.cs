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
        private int _id;
        private string _planeName;
        private DateTime _departure;
        private DateTime _arrival;
        private string _embarkations;
        private string _destination;
        private decimal _ticketPrice;

        private bool[] _hasValue;

        private AirportDataBaseDataSet.АвиарейсDataTable _table;

        private int _index;

        public EditFlightForm(AirportDataBaseDataSet.АвиарейсDataTable table, int index)
        {
            InitializeComponent();

            _hasValue = new bool[6];
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
            int difference;

            // Проверка номера
            try
            {
                _id = Convert.ToInt32(_idTextBox.Text);
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
            if (_planeNameTextBox.Text == string.Empty)
            {
                _hasValue[0] = false;
            }
            else
            {
                difference = _planeNameTextBox.Text.Count<char>() - _table.Идентификатор_самолётаColumn.MaxLength;
                if (difference > 0)
                {
                    MessageBox.Show(string.Format("Идентификатор самолёта превышает допустимую длину на {0}", difference), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                _planeName = _planeNameTextBox.Text;
                _hasValue[0] = true;
            }
            
            // Проверка даты отправления
            if (_departureMaskedTextBox.Text == "  .  .       :")
            {
                _hasValue[1] = false;
            }
            else
            {
                try
                {
                    _departure = Convert.ToDateTime(_departureMaskedTextBox.Text);
                    _hasValue[1] = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Дата отправления имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            // Проверка даты прибытия
            if (_arrivalMaskedTextBox.Text == "  .  .       :")
            {
                _hasValue[2] = false;
            }
            else
            {
                try
                {
                    _arrival = Convert.ToDateTime(_arrivalMaskedTextBox.Text);
                    _hasValue[2] = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Дата прибытия имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            // Проверка пунктов посадки
            if (_embarkationsTextBox.Text == string.Empty)
            {
                _hasValue[3] = false;
            }
            else
            {
                difference = _embarkationsTextBox.Text.Count<char>() - _table.Пункты_посадкиColumn.MaxLength;
                if (difference > 0)
                {
                    MessageBox.Show(string.Format("Пункты посадки превышает допустимую длину на {0}", difference), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                _embarkations = _embarkationsTextBox.Text;
                _hasValue[3] = true;
            }

            // Проверка пункта назначения
            if (_destinationTextBox.Text == string.Empty)
            {
                _hasValue[4] = false;
            }
            else
            {
                difference = _destinationTextBox.Text.Count<char>() - _table.Пункт_назначенияColumn.MaxLength;
                if (difference > 0)
                {
                    MessageBox.Show(string.Format("Пункт назначения превышает допустимую длину на {0}", difference), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                _destination = _destinationTextBox.Text;
                _hasValue[4] = true;
            }

            // Проверка стоимости билета
            if (_ticketPriceTextBox.Text == string.Empty)
            {
                _hasValue[5] = false;
            }
            else
            {
                try
                {
                    _ticketPrice = Convert.ToDecimal(_ticketPriceTextBox.Text);
                    _hasValue[5] = true;
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
                _table.Rows[_index].SetField<int>("Номер рейса", _id);
                _table.Rows[_index].SetField<object>("Идентификатор самолёта", _hasValue[0] ? _planeName : null);
                if (_hasValue[1])
                {
                    _table.Rows[_index].SetField<DateTime>("Дата отправки", _departure);
                }
                else
                {
                    _table.Rows[_index].SetField<object>("Дата отправки", null);
                }
                if (_hasValue[2])
                {
                    _table.Rows[_index].SetField<DateTime>("Дата прибытия", _arrival);
                }
                else
                {
                    _table.Rows[_index].SetField<object>("Дата прибытия", null);
                }
                if (_hasValue[3])
                {
                    _table.Rows[_index].SetField<string>("Пункты посадки", _embarkations);
                }
                else
                {
                    _table.Rows[_index].SetField<object>("Пункты посадки", null);
                }
                if (_hasValue[4])
                {
                    _table.Rows[_index].SetField<string>("Пункт назначения", _destination);
                }
                else
                {
                    _table.Rows[_index].SetField<object>("Пункт назначения", null);
                }
                if (_hasValue[5])
                {
                    _table.Rows[_index].SetField<decimal>("Стоимость билета", _ticketPrice);
                }
                else
                {
                    _table.Rows[_index].SetField<object>("Стоимость билета", null);
                }
            }
            else
            {
                AirportDataBaseDataSet.АвиарейсRow row = _table.NewАвиарейсRow();
                row.Номер_рейса = _id;
                if (_hasValue[0])
                {
                    row.Идентификатор_самолёта = _planeName;
                }
                if (_hasValue[1])
                {
                    row.Дата_отправки = _departure;
                }
                if (_hasValue[2])
                {
                    row.Дата_прибытия = _arrival;
                }
                if (_hasValue[3])
                {
                    row.Пункты_посадки = _embarkations;
                }
                if (_hasValue[4])
                {
                    row.Пункт_назначения = _destination;
                }
                if (_hasValue[5])
                {
                    row.Стоимость_билета = _ticketPrice;
                }
                _table.AddАвиарейсRow(row);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
