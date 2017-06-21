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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void авиарейсBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            авиарейсBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(airportDataBaseDataSet);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataBaseDataSet.Авиарейс". При необходимости она может быть перемещена или удалена.
            авиарейсTableAdapter.Fill(airportDataBaseDataSet.Авиарейс);
        }

        private void addFlight()
        {
            EditFlightForm addFlightRowForm = new EditFlightForm(airportDataBaseDataSet.Авиарейс, airportDataBaseDataSet.Авиарейс.Count);
            addFlightRowForm.ShowDialog();
        }

        private void changeFlight()
        {
            if (авиарейсDataGridView.CurrentCell != null)
            {
                EditFlightForm changeFlightForm = new EditFlightForm(airportDataBaseDataSet.Авиарейс, авиарейсDataGridView.CurrentCell.RowIndex);
                changeFlightForm.ShowDialog();
            }
        }

        private void deleteFlight()
        {
            if (airportDataBaseDataSet.Авиарейс.Count == 0 || авиарейсDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            DataGridViewSelectedCellCollection cells = авиарейсDataGridView.SelectedCells;
            List<DataGridViewCell> newCells = new List<DataGridViewCell>();
            newCells.Add(cells[0]);
            // получение списка newCells, в котором все ячейки принадлежат разным строкам
            bool unique;
            for (int i = 1; i < cells.Count; i++)
            {
                // делаем предположение что cells[i] обладает индексом строки
                // не встречающимся у ячеек newCells
                unique = true;
                for (int j = 0; j < newCells.Count; j++)
                {
                    if (newCells[j].RowIndex == cells[i].RowIndex)
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique)
                {
                    newCells.Add(cells[i]);
                }
            }

            foreach (DataGridViewCell cell in newCells)
            {
                DataRow row = airportDataBaseDataSet.Авиарейс.Rows[cell.RowIndex];
                airportDataBaseDataSet.Авиарейс.RemoveАвиарейсRow((AirportDataBaseDataSet.АвиарейсRow)row);
            }
        }

        private void ShowAllPassengers()
        {
            PassengersForm passengers = new PassengersForm();
            passengers.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFlight();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeFlight();
        }

        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllPassengers();
        }

        private void выбранногоРейсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (авиарейсDataGridView.CurrentCell != null)
            {
                PassengersForm passengers = new PassengersForm();
                string val = airportDataBaseDataSet.Авиарейс.Rows[авиарейсDataGridView.CurrentCell.RowIndex].Field<int>("Номер рейса").ToString();
                passengers.SetFilter("[Номер рейса] = " + val);
                passengers.Show();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteFlight();
        }

        private void авиарейсToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchForm flightSearch = new SearchForm(TableName.Flight);
            if (flightSearch.ShowDialog() == DialogResult.OK && flightSearch.Table == TableName.Flight)
            {
                авиарейсBindingSource.Filter = flightSearch.FilterExpression;
            }
        }

        private void пассажирыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchForm flightSearch = new SearchForm(TableName.Passenger);
            if (flightSearch.ShowDialog() == DialogResult.OK && flightSearch.Table == TableName.Flight)
            {
                PassengersForm passengers = new PassengersForm();
                passengers.SetFilter(flightSearch.FilterExpression);
                passengers.Show();
            }
        }
    }
}
