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
        private PassengersForm _passengers;

        public MainForm()
        {
            InitializeComponent();

            _passengers = new PassengersForm();
        }

        private void авиарейсBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataBaseDataSet.Авиарейс". При необходимости она может быть перемещена или удалена.
            авиарейсTableAdapter.Fill(airportDataBaseDataSet.Авиарейс);
        }

        private void AppendFlight()
        {
            EditFlightForm additionFlight = new EditFlightForm(airportDataBaseDataSet.Авиарейс);
            additionFlight.Text = "Добавление данных об авиарейсе";
            additionFlight.ShowDialog();
        }

        private void ChangeFlight()
        {
            if (авиарейсDataGridView.SelectedCells.Count > 0)
            {
                DataRowView rowView = (DataRowView)авиарейсDataGridView.SelectedCells[0].OwningRow.DataBoundItem;
                EditFlightForm changeFlight = new EditFlightForm(airportDataBaseDataSet.Авиарейс, (AirportDataBaseDataSet.АвиарейсRow)rowView.Row);
                changeFlight.Text = "Изменение данных об авиарейсе";
                changeFlight.ShowDialog();
            }
        }

        private void DeleteFlight()
        {
            if (airportDataBaseDataSet.Авиарейс.Count != 0
                && авиарейсDataGridView.SelectedCells.Count != 0)
            {
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
                    авиарейсBindingSource.RemoveAt(cell.RowIndex);
                }
            }
        }

        public void Search(TableName tableName)
        {
            SearchForm searchForm = new SearchForm(tableName);
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                switch (searchForm.Table)
                {
                    case TableName.Flight:
                        авиарейсBindingSource.Filter = searchForm.FilterExpression;
                        break;
                    case TableName.Passenger:
                        if (_passengers.IsDisposed)
                        {
                            _passengers = new PassengersForm();
                        }
                        _passengers.SetFilter(searchForm.FilterExpression);
                        if (!_passengers.Visible)
                        {
                            _passengers.Show(this);
                        }
                        _passengers.Activate();
                        break;
                }
            }
        }

        void Save()
        {
            Validate();
            авиарейсBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(airportDataBaseDataSet);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppendFlight();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFlight();
        }

        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_passengers.IsDisposed)
            {
                _passengers = new PassengersForm();
            }
            _passengers.RemoveFilter();
            if (!_passengers.Visible)
            {
                _passengers.Show(this);
            }
            _passengers.Activate();
        }

        private void выбранногоРейсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = авиарейсDataGridView.SelectedCells;

            if (cells.Count > 0)
            {
                DataRowView rowView = (DataRowView)cells[0].OwningRow.DataBoundItem;
                string val = rowView.Row.Field<int>("Номер рейса").ToString();

                if (_passengers.IsDisposed)
                {
                    _passengers = new PassengersForm();
                }
                _passengers.SetFilter("[Номер рейса] = " + val);
                if (!_passengers.Visible)
                {
                    _passengers.Show(this);
                }
                _passengers.Activate();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFlight();
        }

        private void авиарейсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search(TableName.Flight);
        }

        private void пассажирыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search(TableName.Passenger);
        }

        private void сброситьРезультатПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авиарейсBindingSource.RemoveFilter();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (airportDataBaseDataSet.HasChanges() || _passengers.HasChanges())
            {
                switch (MessageBox.Show("Сохранить изменения в базе данных?", "", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        Save();
                        _passengers.Save();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void авиарейсDataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            //MessageBox.Show(string.Format("SRC {0}", авиарейсDataGridView.SelectedRows.Count));
            DataGridViewSelectedCellCollection cells = авиарейсDataGridView.SelectedCells;
            if (cells.Count > 0)
            {
                удалитьToolStripMenuItem.Enabled = true;
                int i = cells[0].RowIndex;
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.RowIndex != i)
                    {
                        изменитьToolStripMenuItem.Enabled = false;
                        выбранногоРейсаToolStripMenuItem.Enabled = false;
                        return;
                    }
                }
                изменитьToolStripMenuItem.Enabled = true;
                выбранногоРейсаToolStripMenuItem.Enabled = true;
            }
            else
            {
                if (авиарейсDataGridView.SelectedRows.Count == 1)
                {
                    изменитьToolStripMenuItem.Enabled = true;
                    удалитьToolStripMenuItem.Enabled = true;
                    выбранногоРейсаToolStripMenuItem.Enabled = true;
                }
                else
                {
                    изменитьToolStripMenuItem.Enabled = false;
                    удалитьToolStripMenuItem.Enabled = false;
                    выбранногоРейсаToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void авиарейсDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            DataGridViewSelectedCellCollection cells = авиарейсDataGridView.SelectedCells;
            if (cells.Count > 0)
            {
                удалитьToolStripMenuItem.Enabled = true;
                int i = cells[0].RowIndex;
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.RowIndex != i)
                    {
                        изменитьToolStripMenuItem.Enabled = false;
                        выбранногоРейсаToolStripMenuItem.Enabled = false;
                        return;
                    }
                }
                изменитьToolStripMenuItem.Enabled = true;
                выбранногоРейсаToolStripMenuItem.Enabled = true;
            }
            else
            {
                if (авиарейсDataGridView.SelectedRows.Count == 1)
                {
                    изменитьToolStripMenuItem.Enabled = true;
                    удалитьToolStripMenuItem.Enabled = true;
                    выбранногоРейсаToolStripMenuItem.Enabled = true;
                }
                else
                {
                    изменитьToolStripMenuItem.Enabled = false;
                    удалитьToolStripMenuItem.Enabled = false;
                    выбранногоРейсаToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void _addToolStripButton_Click(object sender, EventArgs e)
        {
            AppendFlight();
        }

        private void _changeToolStripButton_Click(object sender, EventArgs e)
        {
            ChangeFlight();
        }

        private void _searchToolStripButton_Click(object sender, EventArgs e)
        {
            Search(TableName.Flight);
        }

        private void _resetSearchToolStripButton_Click(object sender, EventArgs e)
        {
            авиарейсBindingSource.RemoveFilter();
        }

        private void _deleteToolStripButton_Click(object sender, EventArgs e)
        {
            DeleteFlight();
        }
    }
}
