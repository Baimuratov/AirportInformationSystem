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
        private AirportDataBaseDataSet airportDataBaseDataSet;
        public FlightData FlightObject
        {
            set
            {
                if (value == null)
                {
                    _idTextBox.Text = string.Empty;
                    _planeNameTextBox.Text = string.Empty;
                    _departureMaskedTextBox.Text = string.Empty;
                    _arrivalMaskedTextBox.Text = string.Empty;
                    _embarkationsTextBox.Text = string.Empty;
                    _destinationTextBox.Text = string.Empty;
                    _ticketPriceTextBox.Text = string.Empty;
                }
                else
                {
                    _idTextBox.Text = value.ID.ToString();
                    _planeNameTextBox.Text = value.PlaneName;
                    _departureMaskedTextBox.Text = value.Departure.ToString();
                    _arrivalMaskedTextBox.Text = value.Arrival.ToString();
                    _embarkationsTextBox.Text = value.Embarkations;
                    _destinationTextBox.Text = value.Destination;
                    _ticketPriceTextBox.Text = value.TicketPrice.ToString();
                }
            }
            get
            {
                FlightData flightObject = new FlightData();

                try
                {
                    flightObject.ID = Convert.ToInt32(_idTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Номер авиарейса должен быть положительным целым числом", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return null;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Номера авиарейса вызывает переполнение", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return null;
                }

                int difference = _planeNameTextBox.Text.Count<char>() - airportDataBaseDataSet.Авиарейс.Идентификатор_самолётаColumn.MaxLength;
                if (difference > 0)
                {
                    MessageBox.Show(string.Format("Идентификатор самолёта превышает допустимую длину на {0}", difference), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return null;
                }
                flightObject.PlaneName = _planeNameTextBox.Text;

                if (_departureMaskedTextBox.Text != "  .  .       :")
                {
                    try
                    {
                        flightObject.Departure = Convert.ToDateTime(_departureMaskedTextBox.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Дата отправления имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return null;
                    }
                }

                if (_arrivalMaskedTextBox.Text != "  .  .       :")
                {
                    try
                    {
                        flightObject.Arrival = Convert.ToDateTime(_arrivalMaskedTextBox.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Дата прибытия имеет неправильный формат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return null;
                    }
                }

                difference = _embarkationsTextBox.Text.Count<char>() - airportDataBaseDataSet.Авиарейс.Пункты_посадкиColumn.MaxLength;
                if (difference > 0)
                {
                    MessageBox.Show(string.Format("Пункты посадки превышает допустимую длину на {0}", difference), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return null;
                }
                flightObject.Embarkations = _embarkationsTextBox.Text;

                difference = _destinationTextBox.Text.Count<char>() - airportDataBaseDataSet.Авиарейс.Пункт_назначенияColumn.MaxLength;
                if (difference > 0)
                {
                    MessageBox.Show(string.Format("Пункт назначения превышает допустимую длину на {0}", difference), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return null;
                }
                flightObject.Destination = _destinationTextBox.Text;

                if (_ticketPriceTextBox.Text != string.Empty)
                {
                    try
                    {
                        flightObject.TicketPrice = Convert.ToDecimal(_ticketPriceTextBox.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Стоимость билета должна быть положительным числом", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return null;
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Стоимость билета вызывает переполнение", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return null;
                    }
                }

                return flightObject;
            }
        }
        public EditFlightForm()
        {
            InitializeComponent();

            airportDataBaseDataSet = new AirportDataBaseDataSet();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            if (FlightObject == null)
            {
                return;
            }
            _okButton.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
