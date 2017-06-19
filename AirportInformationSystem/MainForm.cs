﻿using System;
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
                passengers.пассажирBindingSource.Filter = "[Номер рейса] = " + val;
                passengers.Show();
            }
        }
    }
}
