using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AirportInformationSystem
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Форма отображающая таблицу пассажиров
        /// </summary>
        private PassengersForm _passengers;

        /// <summary>
        /// Инициализирует новый экземпляр класса AirportInformationSystem.MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _passengers = new PassengersForm(this);
        }

        /// <summary>
        /// Обрабатывает событие загрузка формы MainForm:
        /// отображает информацию из таблицы "Авиарейс" базы данных в таблице авиарейсDataGridView на форме
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            авиарейсTableAdapter.Fill(airportDataBaseDataSet.Авиарейс);
        }

        /// <summary>
        /// Отображает форму добавления данных об авиарейсе
        /// </summary>
        private void AppendFlight()
        {
            EditFlightForm additionFlight = new EditFlightForm(airportDataBaseDataSet.Авиарейс);
            additionFlight.Text = "Добавление данных об авиарейсе";
            additionFlight.ShowDialog();
        }

        /// <summary>
        /// Отображает форму изменения данных об авиарейсе
        /// </summary>
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

        /// <summary>
        /// Удаляет выбранные в таблице авиарейсDataGridView записи об авиарейсах
        /// </summary>
        private void Delete()
        {
            // начать удаление если в таблице есть записи и выделены ячейки
            if (airportDataBaseDataSet.Авиарейс.Count != 0
                && авиарейсDataGridView.SelectedCells.Count != 0)
            {
                DataGridViewSelectedCellCollection cells = авиарейсDataGridView.SelectedCells;
                List<int> rowIndexes = new List<int>();
                rowIndexes.Add(cells[0].RowIndex);

                // получение списка индексов строк выделенных ячеек
                bool unique;
                for (int i = 1; i < cells.Count; i++)
                {
                    // делаем предположение что cells[i] обладает индексом строки
                    // не встречающимся в rowIndexes
                    unique = true;
                    for (int j = 0; j < rowIndexes.Count; j++)
                    {
                        if (rowIndexes[j] == cells[i].RowIndex)
                        {
                            unique = false;
                            break;
                        }
                    }
                    if (unique)
                    {
                        rowIndexes.Add(cells[i].RowIndex);
                    }
                }

                foreach (int index in rowIndexes)
                {
                    авиарейсBindingSource.RemoveAt(index);
                }
            }
        }

        /// <summary>
        /// Отображает форму поиска данных
        /// </summary>
        /// <param name="tableName">Имя таблицы базы данных, в которой будет производиться поиск</param>
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
                            _passengers = new PassengersForm(this);
                        }
                        _passengers.SetFilter(searchForm.FilterExpression);
                        if (!_passengers.Visible)
                        {
                            _passengers.Show();
                        }
                        _passengers.Activate();
                        break;
                }
            }
        }

        /// <summary>
        /// Сохраняет изменения в базе данных
        /// </summary>
        private void Save()
        {
            Validate();
            авиарейсBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(airportDataBaseDataSet);
        }

        /// <summary>
        /// Делает доступными или недоступными некоторые кнопки главного меню и панели инструментов
        /// в зависимости от количества выбранных записей в таблице авиарейсDataGridView
        /// </summary>
        private void ReenableButtons()
        {
            DataGridViewSelectedCellCollection cells = авиарейсDataGridView.SelectedCells;
            if (cells.Count > 0)
            {
                удалитьToolStripMenuItem.Enabled = true;
                _deleteToolStripButton.Enabled = true;
                int i = cells[0].RowIndex;
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.RowIndex != i)
                    {
                        изменитьToolStripMenuItem.Enabled = false;
                        _changeToolStripButton.Enabled = false;
                        выбранногоРейсаToolStripMenuItem.Enabled = false;
                        return;
                    }
                }
                изменитьToolStripMenuItem.Enabled = true;
                _changeToolStripButton.Enabled = true;
                выбранногоРейсаToolStripMenuItem.Enabled = true;
            }
            else
            {
                if (авиарейсDataGridView.SelectedRows.Count == 1)
                {
                    изменитьToolStripMenuItem.Enabled = true;
                    _changeToolStripButton.Enabled = true;
                    удалитьToolStripMenuItem.Enabled = true;
                    _deleteToolStripButton.Enabled = true;
                    выбранногоРейсаToolStripMenuItem.Enabled = true;
                }
                else
                {
                    изменитьToolStripMenuItem.Enabled = false;
                    _changeToolStripButton.Enabled = false;
                    удалитьToolStripMenuItem.Enabled = false;
                    _deleteToolStripButton.Enabled = false;
                    выбранногоРейсаToolStripMenuItem.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки добавитьToolStripMenuItem в главном меню:
        /// отображает форму добавления данных об авиарейсе
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppendFlight();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки изменитьToolStripMenuItem в главном меню:
        /// отображает форму изменения данных об авиарейсе
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFlight();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки всеToolStripMenuItem в главном меню:
        /// отображает форму с таблицей всех пассажиров
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_passengers.IsDisposed)
            {
                _passengers = new PassengersForm(this);
            }
            _passengers.RemoveFilter();
            if (!_passengers.Visible)
            {
                _passengers.Show();
            }
            _passengers.Activate();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки выбранногоРейсаToolStripMenuItem в главном меню:
        /// отображает форму с таблицей пассажиров выбранного рейса
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void выбранногоРейсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = авиарейсDataGridView.SelectedCells;

            if (cells.Count > 0)
            {
                DataRowView rowView = (DataRowView)cells[0].OwningRow.DataBoundItem;
                string val = rowView.Row.Field<int>("Номер рейса").ToString();

                if (_passengers.IsDisposed)
                {
                    _passengers = new PassengersForm(this);
                }
                _passengers.SetFilter("[Номер рейса] = " + val);
                if (!_passengers.Visible)
                {
                    _passengers.Show();
                }
                _passengers.Activate();
            }
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки удалитьToolStripMenuItem в главном меню:
        /// удаляет выбранные в таблице авиарейсDataGridView записи об авиарейсах
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки авиарейсыToolStripMenuItem в главном меню:
        /// отображает форму поиска данных об авиарейсах
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void авиарейсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search(TableName.Flight);
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки пассажирыToolStripMenuItem1 в главном меню:
        /// отображает форму поиска данных о пассажирах
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void пассажирыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search(TableName.Passenger);
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки сброситьРезультатПоискаToolStripMenuItem в главном меню:
        /// сбрасывает результаты поиска в таблице "Авиарейс"
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void сброситьРезультатПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авиарейсBindingSource.RemoveFilter();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки сохранитьToolStripMenuItem в главном меню:
        /// сохраняет изменения в базе данных
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки выходToolStripMenuItem в главном меню:
        /// закрывает главную форму приложения
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _addToolStripButton на панели инструментов:
        /// отображает форму добавления данных об авиарейсе
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _addToolStripButton_Click(object sender, EventArgs e)
        {
            AppendFlight();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _changeToolStripButton на панели инструментов:
        /// отображает форму изменения данных об авиарейсе
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _changeToolStripButton_Click(object sender, EventArgs e)
        {
            ChangeFlight();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _deleteToolStripButton на панели инструментов:
        /// удаляет выбранные в таблице авиарейсDataGridView записи об авиарейсах
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _deleteToolStripButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки авиарейсBindingNavigatorSaveItem на панели инструментов:
        /// сохраняет изменения в базе данных
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void авиарейсBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _searchToolStripButton на панели инструментов:
        /// отображает форму поиска данных об авиарейсах
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _searchToolStripButton_Click(object sender, EventArgs e)
        {
            Search(TableName.Flight);
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _resetSearchToolStripButton на панели инструментов:
        /// сбрасывает результаты поиска в таблице "Авиарейс"
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _resetSearchToolStripButton_Click(object sender, EventArgs e)
        {
            авиарейсBindingSource.RemoveFilter();
        }

        /// <summary>
        /// Обрабатывает событие изменение состояния ячеек таблицы авиарейсDataGridView:
        /// делает доступными или недоступными некоторые кнопки главного меню и панели инструментов
        /// в зависимости от количества выбранных записей в таблице авиарейсDataGridView
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void авиарейсDataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            ReenableButtons();
        }

        /// <summary>
        /// Обрабатывает событие изменение состояния строк таблицы авиарейсDataGridView:
        /// делает доступными или недоступными некоторые кнопки главного меню и панели инструментов
        /// в зависимости от количества выбранных записей в таблице авиарейсDataGridView
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void авиарейсDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            ReenableButtons();
        }

        /// <summary>
        /// Обрабатывает событие закрытие главной формы MainForm:
        /// отображает окно подтверждения закрытия и сохранения изменений в базе данных
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
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
    }
}
