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
    public partial class PassengersForm : Form
    {
        public PassengersForm()
        {
            InitializeComponent();
        }

        private void пассажирBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            пассажирBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(airportDataBaseDataSet);

        }

        private void PassengersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataBaseDataSet.Пассажир". При необходимости она может быть перемещена или удалена.
            пассажирTableAdapter.Fill(airportDataBaseDataSet.Пассажир);

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPassengerForm addingPassenger = new EditPassengerForm(airportDataBaseDataSet.Пассажир, airportDataBaseDataSet.Пассажир.Count);
            addingPassenger.ShowDialog();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (пассажирDataGridView.CurrentCell != null)
            {
                EditPassengerForm changePassenger = new EditPassengerForm(airportDataBaseDataSet.Пассажир, пассажирDataGridView.CurrentCell.RowIndex);
                changePassenger.ShowDialog();
            }
        }
    }
}
