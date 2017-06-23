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

        public void RemoveFilter()
        {
            пассажирBindingSource.RemoveFilter();
        }

        public bool HasChanges()
        {
            return airportDataBaseDataSet.HasChanges();
        }

        private void пассажирBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void PassengersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataBaseDataSet.Пассажир". При необходимости она может быть перемещена или удалена.
            пассажирTableAdapter.Fill(airportDataBaseDataSet.Пассажир);

        }

        private void AppendPassenger()
        {
            EditPassengerForm additionPassenger = new EditPassengerForm(airportDataBaseDataSet.Пассажир);
            additionPassenger.ShowDialog();
        }

        private void ChangePassenger()
        {
            if (пассажирDataGridView.SelectedCells.Count > 0)
            {
                DataRowView rowView = (DataRowView)пассажирDataGridView.SelectedCells[0].OwningRow.DataBoundItem;
                EditPassengerForm changePassenger = new EditPassengerForm(airportDataBaseDataSet.Пассажир, (AirportDataBaseDataSet.ПассажирRow)rowView.Row);
                changePassenger.ShowDialog();
            }
        }

        private void DeletePassenger()
        {
            if (airportDataBaseDataSet.Пассажир.Count != 0 && пассажирDataGridView.SelectedCells.Count != 0)
            {
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
                    DataRowView rowView = (DataRowView)cell.OwningRow.DataBoundItem;
                    airportDataBaseDataSet.Пассажир.RemoveПассажирRow((AirportDataBaseDataSet.ПассажирRow)rowView.Row);
                }
            }
        }

        public void Save()
        {
            Validate();
            пассажирBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(airportDataBaseDataSet);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppendPassenger();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassenger();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePassenger();
        }

        private void авиарейсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            mainForm.Search(TableName.Flight);
        }

        private void пассажирыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            mainForm.Search(TableName.Passenger);
        }

        private void сброситьРезультатПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            пассажирBindingSource.RemoveFilter();
        }

        private void пассажирDataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            DataGridViewSelectedCellCollection cells = пассажирDataGridView.SelectedCells;
            if (cells.Count > 0)
            {
                удалитьToolStripMenuItem.Enabled = true;
                int i = cells[0].RowIndex;
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.RowIndex != i)
                    {
                        изменитьToolStripMenuItem.Enabled = false;
                        return;
                    }
                }
                изменитьToolStripMenuItem.Enabled = true;
            }
            else
            {
                if (пассажирDataGridView.SelectedRows.Count == 1)
                {
                    изменитьToolStripMenuItem.Enabled = true;
                    удалитьToolStripMenuItem.Enabled = true;
                }
                else
                {
                    изменитьToolStripMenuItem.Enabled = false;
                    удалитьToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void пассажирDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            DataGridViewSelectedCellCollection cells = пассажирDataGridView.SelectedCells;
            if (cells.Count > 0)
            {
                удалитьToolStripMenuItem.Enabled = true;
                int i = cells[0].RowIndex;
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.RowIndex != i)
                    {
                        изменитьToolStripMenuItem.Enabled = false;
                        return;
                    }
                }
                изменитьToolStripMenuItem.Enabled = true;
            }
            else
            {
                if (пассажирDataGridView.SelectedRows.Count == 1)
                {
                    изменитьToolStripMenuItem.Enabled = true;
                    удалитьToolStripMenuItem.Enabled = true;
                }
                else
                {
                    изменитьToolStripMenuItem.Enabled = false;
                    удалитьToolStripMenuItem.Enabled = false;
                }
            }
        }
    }
}
