using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AirportInformationSystem
{
    /// <summary>
    /// Форма отображающая таблицу пассажиров
    /// </summary>
    public partial class PassengersForm : Form
    {
        /// <summary>
        /// Главная форма приложения, создающая данную форму
        /// </summary>
        private readonly MainForm _parent;

        /// <summary>
        /// Инициализирует новый экземпляр класса AirportInformationSystem.PassengersForm
        /// </summary>
        /// <param name="parent">Главная форма приложения, создающая данную форму</param>
        public PassengersForm(MainForm parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        /// <summary>
        /// Устанавливает фильтр в таблице "Пассажир"
        /// </summary>
        /// <param name="expression">Выражение фильтра</param>
        public void SetFilter(string expression)
        {
            пассажирBindingSource.Filter = expression;
        }

        /// <summary>
        /// Сбрасывает фильтр в таблице "Пассажир"
        /// </summary>
        public void RemoveFilter()
        {
            пассажирBindingSource.RemoveFilter();
        }

        /// <summary>
        /// Возвращает значение, показывающее была ли изменена база данных в этой форме
        /// </summary>
        /// <returns>true - база данных изменена, иначе false</returns>
        public bool HasChanges()
        {
            return airportDataBaseDataSet.HasChanges();
        }

        /// <summary>
        /// Обрабатывает событие загрузка формы PassengersForm:
        /// отображает информацию из таблицы "Пассажир" базы данных в таблице пассажирDataGridView на форме
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void PassengersForm_Load(object sender, EventArgs e)
        {
            пассажирTableAdapter.Fill(airportDataBaseDataSet.Пассажир);
        }

        /// <summary>
        /// Отображает форму добавления данных о пассажире
        /// </summary>
        private void AppendPassenger()
        {
            EditPassengerForm additionPassenger = new EditPassengerForm(airportDataBaseDataSet.Пассажир);
            additionPassenger.Text = "Добавление данных о пассажире";
            additionPassenger.ShowDialog();
        }

        /// <summary>
        /// Отображает форму изменения данных о пассажире
        /// </summary>
        private void ChangePassenger()
        {
            if (пассажирDataGridView.SelectedCells.Count > 0)
            {
                DataRowView rowView = (DataRowView)пассажирDataGridView.SelectedCells[0].OwningRow.DataBoundItem;
                EditPassengerForm changePassenger = new EditPassengerForm(airportDataBaseDataSet.Пассажир, (AirportDataBaseDataSet.ПассажирRow)rowView.Row);
                changePassenger.Text = "Изменение данных о пассажире";
                changePassenger.ShowDialog();
            }
        }

        /// <summary>
        /// Удаляет выбранные в таблице пассажирDataGridView записи о пассажирах
        /// </summary>
        private void Delete()
        {
            // начать удаление если в таблице есть записи и выделены ячейки
            if (airportDataBaseDataSet.Пассажир.Count != 0
                && пассажирDataGridView.SelectedCells.Count != 0)
            {
                DataGridViewSelectedCellCollection cells = пассажирDataGridView.SelectedCells;
                List<int> rowIndexes = new List<int>();
                rowIndexes.Add(cells[0].RowIndex);
                // получение списка newCells, в котором все ячейки принадлежат разным строкам
                bool unique;
                for (int i = 1; i < cells.Count; i++)
                {
                    // делаем предположение что cells[i] обладает индексом строки
                    // не встречающимся у ячеек newCells
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
                    пассажирBindingSource.RemoveAt(index);
                }
            }
        }

        /// <summary>
        /// Сохраняет изменения в базе данных
        /// </summary>
        public void Save()
        {
            Validate();
            пассажирBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(airportDataBaseDataSet);
        }

        /// <summary>
        /// Делает доступными или недоступными некоторые кнопки главного меню и панели инструментов
        /// в зависимости от количества выбранных записей в таблице пассажирDataGridView
        /// </summary>
        private void ReenableButtons()
        {
            DataGridViewSelectedCellCollection cells = пассажирDataGridView.SelectedCells;
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
                        return;
                    }
                }
                изменитьToolStripMenuItem.Enabled = true;
                _changeToolStripButton.Enabled = true;
            }
            else
            {
                if (пассажирDataGridView.SelectedRows.Count == 1)
                {
                    изменитьToolStripMenuItem.Enabled = true;
                    _changeToolStripButton.Enabled = true;
                    удалитьToolStripMenuItem.Enabled = true;
                    _deleteToolStripButton.Enabled = true;
                }
                else
                {
                    изменитьToolStripMenuItem.Enabled = false;
                    _changeToolStripButton.Enabled = false;
                    удалитьToolStripMenuItem.Enabled = false;
                    _deleteToolStripButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки добавитьToolStripMenuItem в главном меню:
        /// отображает форму добавления данных о пассажире
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppendPassenger();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки изменитьToolStripMenuItem в главном меню:
        /// отображает форму изменения данных о пассажире
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassenger();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки удалитьToolStripMenuItem в главном меню:
        /// удаляет выбранные в таблице пассажирDataGridView записи о пассажирах
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
            _parent.Search(TableName.Flight);
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки пассажирыToolStripMenuItem в главном меню:
        /// отображает форму поиска данных о пассажирах
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void пассажирыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _parent.Search(TableName.Passenger);
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки сброситьРезультатПоискаToolStripMenuItem в главном меню:
        /// сбрасывает результаты поиска в таблице "Пассажир"
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void сброситьРезультатПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            пассажирBindingSource.RemoveFilter();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _addToolStripButton на панели инструментов:
        /// отображает форму добавления данных о пассажире
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _addToolStripButton_Click(object sender, EventArgs e)
        {
            AppendPassenger();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _changeToolStripButton на панели инструментов:
        /// отображает форму изменения данных о пассажире
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _changeToolStripButton_Click(object sender, EventArgs e)
        {
            ChangePassenger();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _deleteToolStripButton на панели инструментов:
        /// удаляет выбранные в таблице пассажирDataGridView записи о пассажирах
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _deleteToolStripButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки пассажирBindingNavigatorSaveItem на панели инструментов:
        /// сохраняет изменения в базе данных
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void пассажирBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _searchToolStripButton на панели инструментов:
        /// отображает форму поиска данных о пассажирах
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _searchToolStripButton_Click(object sender, EventArgs e)
        {
            _parent.Search(TableName.Passenger);
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки _resetSearchToolStripButton на панели инструментов:
        /// сбрасывает результаты поиска в таблице "Пассажир"
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void _resetSearchToolStripButton_Click(object sender, EventArgs e)
        {
            пассажирBindingSource.RemoveFilter();
        }

        /// <summary>
        /// Обрабатывает событие изменение состояния ячеек таблицы пассажирDataGridView:
        /// делает доступными или недоступными некоторые кнопки главного меню и панели инструментов
        /// в зависимости от количества выбранных записей в таблице пассажирDataGridView
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void пассажирDataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            ReenableButtons();
        }

        /// <summary>
        /// Обрабатывает событие изменение состояния строк таблицы пассажирDataGridView:
        /// делает доступными или недоступными некоторые кнопки главного меню и панели инструментов
        /// в зависимости от количества выбранных записей в таблице пассажирDataGridView
        /// </summary>
        /// <param name="sender">Объект, создавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void пассажирDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            ReenableButtons();
        }
    }
}
