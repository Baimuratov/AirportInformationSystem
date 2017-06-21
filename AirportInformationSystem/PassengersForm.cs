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

        public void SetFilter(string expression)
        {
            пассажирBindingSource.Filter = expression;
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

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (airportDataBaseDataSet.Пассажир.Count == 0 || пассажирDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            DataGridViewSelectedCellCollection cells = пассажирDataGridView.SelectedCells;
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
                DataRow row = airportDataBaseDataSet.Пассажир.Rows[cell.RowIndex];
                airportDataBaseDataSet.Пассажир.RemoveПассажирRow((AirportDataBaseDataSet.ПассажирRow)row);
            }
        }
    }
}
