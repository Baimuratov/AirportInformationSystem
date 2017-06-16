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
            this.Validate();
            this.авиарейсBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataBaseDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataBaseDataSet.Авиарейс". При необходимости она может быть перемещена или удалена.
            this.авиарейсTableAdapter.Fill(this.airportDataBaseDataSet.Авиарейс);

        }
    }
}
