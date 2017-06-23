namespace AirportInformationSystem
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._flightRadioButton = new System.Windows.Forms.RadioButton();
            this._passengerRadioButton = new System.Windows.Forms.RadioButton();
            this._flightGroupBox = new System.Windows.Forms.GroupBox();
            this._ticketPriceComboBox = new System.Windows.Forms.ComboBox();
            this._idComboBox = new System.Windows.Forms.ComboBox();
            this._ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this._destinationTextBox = new System.Windows.Forms.TextBox();
            this._embarkationsTextBox = new System.Windows.Forms.TextBox();
            this._arrivalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._departureMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._planeNameTextBox = new System.Windows.Forms.TextBox();
            this._idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._passengerGroupBox = new System.Windows.Forms.GroupBox();
            this._passportNumberComboBox = new System.Windows.Forms.ComboBox();
            this._passportSeriesComboBox = new System.Windows.Forms.ComboBox();
            this._flightIdComboBox = new System.Windows.Forms.ComboBox();
            this._genderComboBox = new System.Windows.Forms.ComboBox();
            this._birthDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._patronymicTextBox = new System.Windows.Forms.TextBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._surnameTextBox = new System.Windows.Forms.TextBox();
            this._passportNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._passportSeriesMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._flightIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._hintLabel = new System.Windows.Forms.Label();
            this._findButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._tableNameGroupBox = new System.Windows.Forms.GroupBox();
            this._flightGroupBox.SuspendLayout();
            this._passengerGroupBox.SuspendLayout();
            this._tableNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flightRadioButton
            // 
            this._flightRadioButton.AutoSize = true;
            this._flightRadioButton.Location = new System.Drawing.Point(6, 19);
            this._flightRadioButton.Name = "_flightRadioButton";
            this._flightRadioButton.Size = new System.Drawing.Size(82, 17);
            this._flightRadioButton.TabIndex = 0;
            this._flightRadioButton.TabStop = true;
            this._flightRadioButton.Text = "Авиарейсы";
            this._flightRadioButton.UseVisualStyleBackColor = true;
            this._flightRadioButton.CheckedChanged += new System.EventHandler(this._flightRadioButton_CheckedChanged);
            // 
            // _passengerRadioButton
            // 
            this._passengerRadioButton.AutoSize = true;
            this._passengerRadioButton.Location = new System.Drawing.Point(94, 19);
            this._passengerRadioButton.Name = "_passengerRadioButton";
            this._passengerRadioButton.Size = new System.Drawing.Size(85, 17);
            this._passengerRadioButton.TabIndex = 1;
            this._passengerRadioButton.TabStop = true;
            this._passengerRadioButton.Text = "Пассажиры";
            this._passengerRadioButton.UseVisualStyleBackColor = true;
            this._passengerRadioButton.CheckedChanged += new System.EventHandler(this._passengerRadioButton_CheckedChanged);
            // 
            // _flightGroupBox
            // 
            this._flightGroupBox.Controls.Add(this._ticketPriceComboBox);
            this._flightGroupBox.Controls.Add(this._idComboBox);
            this._flightGroupBox.Controls.Add(this._ticketPriceTextBox);
            this._flightGroupBox.Controls.Add(this._destinationTextBox);
            this._flightGroupBox.Controls.Add(this._embarkationsTextBox);
            this._flightGroupBox.Controls.Add(this._arrivalMaskedTextBox);
            this._flightGroupBox.Controls.Add(this._departureMaskedTextBox);
            this._flightGroupBox.Controls.Add(this._planeNameTextBox);
            this._flightGroupBox.Controls.Add(this._idTextBox);
            this._flightGroupBox.Controls.Add(this.label1);
            this._flightGroupBox.Location = new System.Drawing.Point(12, 91);
            this._flightGroupBox.Name = "_flightGroupBox";
            this._flightGroupBox.Size = new System.Drawing.Size(360, 198);
            this._flightGroupBox.TabIndex = 2;
            this._flightGroupBox.TabStop = false;
            this._flightGroupBox.Text = "Параметры поиска";
            // 
            // _ticketPriceComboBox
            // 
            this._ticketPriceComboBox.FormattingEnabled = true;
            this._ticketPriceComboBox.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this._ticketPriceComboBox.Location = new System.Drawing.Point(151, 174);
            this._ticketPriceComboBox.Name = "_ticketPriceComboBox";
            this._ticketPriceComboBox.Size = new System.Drawing.Size(50, 21);
            this._ticketPriceComboBox.TabIndex = 17;
            // 
            // _idComboBox
            // 
            this._idComboBox.FormattingEnabled = true;
            this._idComboBox.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this._idComboBox.Location = new System.Drawing.Point(151, 18);
            this._idComboBox.Name = "_idComboBox";
            this._idComboBox.Size = new System.Drawing.Size(50, 21);
            this._idComboBox.TabIndex = 16;
            // 
            // _ticketPriceTextBox
            // 
            this._ticketPriceTextBox.Location = new System.Drawing.Point(207, 174);
            this._ticketPriceTextBox.Name = "_ticketPriceTextBox";
            this._ticketPriceTextBox.Size = new System.Drawing.Size(150, 20);
            this._ticketPriceTextBox.TabIndex = 15;
            this._ticketPriceTextBox.TextChanged += new System.EventHandler(this._ticketPriceTextBox_TextChanged);
            // 
            // _destinationTextBox
            // 
            this._destinationTextBox.Location = new System.Drawing.Point(207, 148);
            this._destinationTextBox.Name = "_destinationTextBox";
            this._destinationTextBox.Size = new System.Drawing.Size(150, 20);
            this._destinationTextBox.TabIndex = 14;
            // 
            // _embarkationsTextBox
            // 
            this._embarkationsTextBox.Location = new System.Drawing.Point(207, 122);
            this._embarkationsTextBox.Multiline = true;
            this._embarkationsTextBox.Name = "_embarkationsTextBox";
            this._embarkationsTextBox.Size = new System.Drawing.Size(150, 20);
            this._embarkationsTextBox.TabIndex = 13;
            // 
            // _arrivalMaskedTextBox
            // 
            this._arrivalMaskedTextBox.Location = new System.Drawing.Point(207, 96);
            this._arrivalMaskedTextBox.Mask = "00/00/0000 90:00";
            this._arrivalMaskedTextBox.Name = "_arrivalMaskedTextBox";
            this._arrivalMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._arrivalMaskedTextBox.TabIndex = 12;
            this._arrivalMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _departureMaskedTextBox
            // 
            this._departureMaskedTextBox.Location = new System.Drawing.Point(207, 70);
            this._departureMaskedTextBox.Mask = "00/00/0000 90:00";
            this._departureMaskedTextBox.Name = "_departureMaskedTextBox";
            this._departureMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._departureMaskedTextBox.TabIndex = 11;
            this._departureMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _planeNameTextBox
            // 
            this._planeNameTextBox.Location = new System.Drawing.Point(207, 44);
            this._planeNameTextBox.Name = "_planeNameTextBox";
            this._planeNameTextBox.Size = new System.Drawing.Size(150, 20);
            this._planeNameTextBox.TabIndex = 10;
            // 
            // _idTextBox
            // 
            this._idTextBox.Location = new System.Drawing.Point(207, 18);
            this._idTextBox.Name = "_idTextBox";
            this._idTextBox.Size = new System.Drawing.Size(150, 20);
            this._idTextBox.TabIndex = 9;
            this._idTextBox.TextChanged += new System.EventHandler(this._idTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 169);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер\r\n\r\nИдентификатор самолёта\r\n\r\nДата отправления\r\n\r\nДата прибытия\r\n\r\nПункты по" +
    "садки\r\n\r\nПункт назначения\r\n\r\nСтоимость билета";
            // 
            // _passengerGroupBox
            // 
            this._passengerGroupBox.Controls.Add(this._passportNumberComboBox);
            this._passengerGroupBox.Controls.Add(this._passportSeriesComboBox);
            this._passengerGroupBox.Controls.Add(this._flightIdComboBox);
            this._passengerGroupBox.Controls.Add(this._genderComboBox);
            this._passengerGroupBox.Controls.Add(this._birthDateMaskedTextBox);
            this._passengerGroupBox.Controls.Add(this._patronymicTextBox);
            this._passengerGroupBox.Controls.Add(this._nameTextBox);
            this._passengerGroupBox.Controls.Add(this._surnameTextBox);
            this._passengerGroupBox.Controls.Add(this._passportNumberMaskedTextBox);
            this._passengerGroupBox.Controls.Add(this._passportSeriesMaskedTextBox);
            this._passengerGroupBox.Controls.Add(this._flightIdTextBox);
            this._passengerGroupBox.Controls.Add(this.label2);
            this._passengerGroupBox.Location = new System.Drawing.Point(12, 91);
            this._passengerGroupBox.Name = "_passengerGroupBox";
            this._passengerGroupBox.Size = new System.Drawing.Size(313, 224);
            this._passengerGroupBox.TabIndex = 3;
            this._passengerGroupBox.TabStop = false;
            this._passengerGroupBox.Text = "Параметры поиска";
            // 
            // _passportNumberComboBox
            // 
            this._passportNumberComboBox.FormattingEnabled = true;
            this._passportNumberComboBox.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this._passportNumberComboBox.Location = new System.Drawing.Point(103, 69);
            this._passportNumberComboBox.Name = "_passportNumberComboBox";
            this._passportNumberComboBox.Size = new System.Drawing.Size(50, 21);
            this._passportNumberComboBox.TabIndex = 20;
            // 
            // _passportSeriesComboBox
            // 
            this._passportSeriesComboBox.FormattingEnabled = true;
            this._passportSeriesComboBox.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this._passportSeriesComboBox.Location = new System.Drawing.Point(103, 45);
            this._passportSeriesComboBox.Name = "_passportSeriesComboBox";
            this._passportSeriesComboBox.Size = new System.Drawing.Size(50, 21);
            this._passportSeriesComboBox.TabIndex = 19;
            // 
            // _flightIdComboBox
            // 
            this._flightIdComboBox.FormattingEnabled = true;
            this._flightIdComboBox.Items.AddRange(new object[] {
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this._flightIdComboBox.Location = new System.Drawing.Point(103, 18);
            this._flightIdComboBox.Name = "_flightIdComboBox";
            this._flightIdComboBox.Size = new System.Drawing.Size(50, 21);
            this._flightIdComboBox.TabIndex = 18;
            // 
            // _genderComboBox
            // 
            this._genderComboBox.FormattingEnabled = true;
            this._genderComboBox.Items.AddRange(new object[] {
            "муж",
            "жен"});
            this._genderComboBox.Location = new System.Drawing.Point(159, 200);
            this._genderComboBox.Name = "_genderComboBox";
            this._genderComboBox.Size = new System.Drawing.Size(55, 21);
            this._genderComboBox.TabIndex = 17;
            // 
            // _birthDateMaskedTextBox
            // 
            this._birthDateMaskedTextBox.Location = new System.Drawing.Point(159, 174);
            this._birthDateMaskedTextBox.Mask = "00/00/0000 90:00";
            this._birthDateMaskedTextBox.Name = "_birthDateMaskedTextBox";
            this._birthDateMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._birthDateMaskedTextBox.TabIndex = 16;
            this._birthDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _patronymicTextBox
            // 
            this._patronymicTextBox.Location = new System.Drawing.Point(159, 148);
            this._patronymicTextBox.Name = "_patronymicTextBox";
            this._patronymicTextBox.Size = new System.Drawing.Size(150, 20);
            this._patronymicTextBox.TabIndex = 15;
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(159, 122);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(150, 20);
            this._nameTextBox.TabIndex = 14;
            // 
            // _surnameTextBox
            // 
            this._surnameTextBox.Location = new System.Drawing.Point(159, 96);
            this._surnameTextBox.Name = "_surnameTextBox";
            this._surnameTextBox.Size = new System.Drawing.Size(150, 20);
            this._surnameTextBox.TabIndex = 13;
            // 
            // _passportNumberMaskedTextBox
            // 
            this._passportNumberMaskedTextBox.Location = new System.Drawing.Point(159, 70);
            this._passportNumberMaskedTextBox.Mask = "000000";
            this._passportNumberMaskedTextBox.Name = "_passportNumberMaskedTextBox";
            this._passportNumberMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._passportNumberMaskedTextBox.TabIndex = 12;
            // 
            // _passportSeriesMaskedTextBox
            // 
            this._passportSeriesMaskedTextBox.Location = new System.Drawing.Point(159, 44);
            this._passportSeriesMaskedTextBox.Mask = "0000";
            this._passportSeriesMaskedTextBox.Name = "_passportSeriesMaskedTextBox";
            this._passportSeriesMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._passportSeriesMaskedTextBox.TabIndex = 11;
            // 
            // _flightIdTextBox
            // 
            this._flightIdTextBox.Location = new System.Drawing.Point(159, 18);
            this._flightIdTextBox.Name = "_flightIdTextBox";
            this._flightIdTextBox.Size = new System.Drawing.Size(150, 20);
            this._flightIdTextBox.TabIndex = 10;
            this._flightIdTextBox.TextChanged += new System.EventHandler(this._flightIdTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 195);
            this.label2.TabIndex = 9;
            this.label2.Text = "Номер рейса\r\n\r\nСерия паспорта\r\n\r\nНомер паспорта\r\n\r\nФамилия\r\n\r\nИмя\r\n\r\nОтчество\r\n\r\n" +
    "Дата рождения\r\n\r\nПол";
            // 
            // _hintLabel
            // 
            this._hintLabel.AutoSize = true;
            this._hintLabel.Location = new System.Drawing.Point(9, 9);
            this._hintLabel.Name = "_hintLabel";
            this._hintLabel.Size = new System.Drawing.Size(293, 26);
            this._hintLabel.TabIndex = 4;
            this._hintLabel.Text = "Пустые поля не учитываются при поиске. \r\nДробные числа записываются с разделителе" +
    "м-запятой";
            // 
            // _findButton
            // 
            this._findButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._findButton.Location = new System.Drawing.Point(70, 330);
            this._findButton.Name = "_findButton";
            this._findButton.Size = new System.Drawing.Size(80, 25);
            this._findButton.TabIndex = 5;
            this._findButton.Text = "Поиск";
            this._findButton.UseVisualStyleBackColor = true;
            this._findButton.Click += new System.EventHandler(this._findButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(241, 330);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(80, 25);
            this._cancelButton.TabIndex = 6;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _tableNameGroupBox
            // 
            this._tableNameGroupBox.Controls.Add(this._passengerRadioButton);
            this._tableNameGroupBox.Controls.Add(this._flightRadioButton);
            this._tableNameGroupBox.Location = new System.Drawing.Point(12, 42);
            this._tableNameGroupBox.Name = "_tableNameGroupBox";
            this._tableNameGroupBox.Size = new System.Drawing.Size(360, 43);
            this._tableNameGroupBox.TabIndex = 7;
            this._tableNameGroupBox.TabStop = false;
            this._tableNameGroupBox.Text = "Таблица";
            // 
            // SearchForm
            // 
            this.AcceptButton = this._findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(387, 367);
            this.Controls.Add(this._tableNameGroupBox);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._findButton);
            this.Controls.Add(this._hintLabel);
            this.Controls.Add(this._flightGroupBox);
            this.Controls.Add(this._passengerGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this._flightGroupBox.ResumeLayout(false);
            this._flightGroupBox.PerformLayout();
            this._passengerGroupBox.ResumeLayout(false);
            this._passengerGroupBox.PerformLayout();
            this._tableNameGroupBox.ResumeLayout(false);
            this._tableNameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton _flightRadioButton;
        private System.Windows.Forms.RadioButton _passengerRadioButton;
        private System.Windows.Forms.GroupBox _flightGroupBox;
        private System.Windows.Forms.TextBox _ticketPriceTextBox;
        private System.Windows.Forms.TextBox _destinationTextBox;
        private System.Windows.Forms.TextBox _embarkationsTextBox;
        private System.Windows.Forms.MaskedTextBox _arrivalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox _departureMaskedTextBox;
        private System.Windows.Forms.TextBox _planeNameTextBox;
        private System.Windows.Forms.TextBox _idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _ticketPriceComboBox;
        private System.Windows.Forms.ComboBox _idComboBox;
        private System.Windows.Forms.GroupBox _passengerGroupBox;
        private System.Windows.Forms.ComboBox _genderComboBox;
        private System.Windows.Forms.MaskedTextBox _birthDateMaskedTextBox;
        private System.Windows.Forms.TextBox _patronymicTextBox;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _surnameTextBox;
        private System.Windows.Forms.MaskedTextBox _passportNumberMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox _passportSeriesMaskedTextBox;
        private System.Windows.Forms.TextBox _flightIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _passportNumberComboBox;
        private System.Windows.Forms.ComboBox _passportSeriesComboBox;
        private System.Windows.Forms.ComboBox _flightIdComboBox;
        private System.Windows.Forms.Label _hintLabel;
        private System.Windows.Forms.Button _findButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.GroupBox _tableNameGroupBox;
    }
}