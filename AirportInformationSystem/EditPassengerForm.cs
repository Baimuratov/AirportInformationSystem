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
    public partial class EditPassengerForm : Form
    {
        private readonly AirportDataBaseDataSet.ПассажирDataTable _table;

        private readonly int _index;

        public EditPassengerForm(AirportDataBaseDataSet.ПассажирDataTable table, int index)
        {
            InitializeComponent();

            _table = table;
            _index = index;
            if (_index < _table.Count)
            {
                DataRow row = _table.Rows[_index];

                _flightIdTextBox.Text = row.Field<int>("Номер рейса").ToString();
                _passportSeriesMaskedTextBox.Text = row.Field<string>("Серия паспорта");
                _passportNumberMaskedTextBox.Text = row.Field<string>("Номер паспорта");
                _surnameTextBox.Text = row.Field<string>("Фамилия");
                _nameTextBox.Text = row.Field<string>("Имя");
                _patronymicTextBox.Text = row.Field<string>("Отчество");
                _birthDateMaskedTextBox.Text = row.IsNull("Дата рождения") ? null : row.Field<DateTime>("Дата рождения").ToString();
                _genderComboBox.Text = row.Field<string>("Пол");
            }
            _genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            object flightId = null;
            object passportSeries = null;
            object passportNumber = null;
            object surname = null;
            object name = null;
            object patronymic = null;
            object birthDate = null;
            object gender = null;

            // Проверка номера рейса
            try
            {
                flightId = Convert.ToInt32(_flightIdTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Номер авиарейса должен быть положительным целым числом", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Номера авиарейса вызывает переполнение", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // Проверка серии паспорта
            if (!Verification.CheckNotEmptyString(_passportSeriesMaskedTextBox.Text, ref passportSeries, _table.Серия_паспортаColumn.MaxLength, "Серия паспорта"))
            {
                return;
            }

            // Проверка номера паспорта
            if (!Verification.CheckNotEmptyString(_passportNumberMaskedTextBox.Text, ref passportNumber, _table.Номер_паспортаColumn.MaxLength, "Номер паспорта"))
            {
                return;
            }

            // Проверка фамилии
            if (!Verification.CheckString(_surnameTextBox.Text, ref surname, _table.ФамилияColumn.MaxLength, "Фамилия"))
            {
                return;
            }

            // Проверка имени
            if (!Verification.CheckString(_nameTextBox.Text, ref name, _table.ИмяColumn.MaxLength, "Имя"))
            {
                return;
            }

            // Проверка отчества
            if (!Verification.CheckString(_patronymicTextBox.Text, ref patronymic, _table.ОтчествоColumn.MaxLength, "Отчество"))
            {
                return;
            }

            // Проверка даты рождения
            if (!Verification.CheckDate(_birthDateMaskedTextBox.Text, ref birthDate, "Дата рождения"))
            {
                return;
            }

            // Проверка пола
            gender = _genderComboBox.Text != string.Empty ? _genderComboBox.Text : null;

            if (_index < _table.Count)
            {
                DataRow row = _table.Rows[_index];

                try
                {
                    row.SetField<object>("Номер рейса", flightId);
                    row.SetField<object>("Серия паспорта", passportSeries);
                    row.SetField<object>("Номер паспорта", passportNumber);
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Поля: номер рейса, серия паспорта, номер паспорта, должны быть уникальной комбинацией",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                row.SetField<object>("Фамилия", surname);
                row.SetField<object>("Имя", name);
                row.SetField<object>("Отчество", patronymic);
                row.SetField<object>("Дата рождения", birthDate);
                row.SetField<object>("Пол", gender);
            }
            else
            {
                AirportDataBaseDataSet.ПассажирRow row = _table.NewПассажирRow();

                row.Номер_рейса = (int)flightId;
                row.Серия_паспорта = (string)passportSeries;
                row.Номер_паспорта = (string)passportNumber;
                row.Фамилия = (string)surname;
                row.Имя = (string)name;
                row.Отчество = (string)patronymic;
                if (birthDate != null)
                {
                    row.Дата_рождения = (DateTime)birthDate;
                }
                row.Пол = (string)gender;
                try
                {
                    _table.AddПассажирRow(row);
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Поля: номер рейса, серия паспорта, номер паспорта, должны быть уникальной комбинацией",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            Close();
        }

        private void _flightIdTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если текстовое поле изменено пользователем
            if (_flightIdTextBox.Modified)
            {
                // выполнить фильтрацию текста, оставив только символы
                // представляющие натуральное или дробное число
                Verification.FilterInt(ref _flightIdTextBox);
            }
        }
    }
}
