namespace AirportInformationSystem
{
    partial class EditPassengerForm
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
            this._attributesLabel = new System.Windows.Forms.Label();
            this._flightIdTextBox = new System.Windows.Forms.TextBox();
            this._passportSeriesMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._passportNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._surnameTextBox = new System.Windows.Forms.TextBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._patronymicTextBox = new System.Windows.Forms.TextBox();
            this._birthDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._genderComboBox = new System.Windows.Forms.ComboBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _attributesLabel
            // 
            this._attributesLabel.AutoSize = true;
            this._attributesLabel.Location = new System.Drawing.Point(12, 18);
            this._attributesLabel.Name = "_attributesLabel";
            this._attributesLabel.Size = new System.Drawing.Size(314, 234);
            this._attributesLabel.TabIndex = 0;
            this._attributesLabel.Text = "Номер рейса*\r\n\r\nСерия паспорта*\r\n\r\nНомер паспорта*\r\n\r\nФамилия\r\n\r\nИмя\r\n\r\nОтчество\r" +
    "\n\r\nДата рождения\r\n\r\nПол\r\n\r\n\r\nПоля отмеченные символом * обязательны для заполнен" +
    "ия";
            // 
            // _flightIdTextBox
            // 
            this._flightIdTextBox.Location = new System.Drawing.Point(153, 15);
            this._flightIdTextBox.Name = "_flightIdTextBox";
            this._flightIdTextBox.Size = new System.Drawing.Size(150, 20);
            this._flightIdTextBox.TabIndex = 1;
            this._flightIdTextBox.TextChanged += new System.EventHandler(this._flightIdTextBox_TextChanged);
            // 
            // _passportSeriesMaskedTextBox
            // 
            this._passportSeriesMaskedTextBox.Location = new System.Drawing.Point(153, 41);
            this._passportSeriesMaskedTextBox.Mask = "0000";
            this._passportSeriesMaskedTextBox.Name = "_passportSeriesMaskedTextBox";
            this._passportSeriesMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._passportSeriesMaskedTextBox.TabIndex = 2;
            // 
            // _passportNumberMaskedTextBox
            // 
            this._passportNumberMaskedTextBox.Location = new System.Drawing.Point(153, 67);
            this._passportNumberMaskedTextBox.Mask = "000000";
            this._passportNumberMaskedTextBox.Name = "_passportNumberMaskedTextBox";
            this._passportNumberMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._passportNumberMaskedTextBox.TabIndex = 3;
            // 
            // _surnameTextBox
            // 
            this._surnameTextBox.Location = new System.Drawing.Point(153, 93);
            this._surnameTextBox.Name = "_surnameTextBox";
            this._surnameTextBox.Size = new System.Drawing.Size(150, 20);
            this._surnameTextBox.TabIndex = 4;
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(153, 119);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(150, 20);
            this._nameTextBox.TabIndex = 5;
            // 
            // _patronymicTextBox
            // 
            this._patronymicTextBox.Location = new System.Drawing.Point(153, 145);
            this._patronymicTextBox.Name = "_patronymicTextBox";
            this._patronymicTextBox.Size = new System.Drawing.Size(150, 20);
            this._patronymicTextBox.TabIndex = 6;
            // 
            // _birthDateMaskedTextBox
            // 
            this._birthDateMaskedTextBox.Location = new System.Drawing.Point(153, 171);
            this._birthDateMaskedTextBox.Mask = "00/00/0000 90:00";
            this._birthDateMaskedTextBox.Name = "_birthDateMaskedTextBox";
            this._birthDateMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._birthDateMaskedTextBox.TabIndex = 7;
            this._birthDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _genderComboBox
            // 
            this._genderComboBox.FormattingEnabled = true;
            this._genderComboBox.Items.AddRange(new object[] {
            "муж",
            "жен"});
            this._genderComboBox.Location = new System.Drawing.Point(153, 197);
            this._genderComboBox.Name = "_genderComboBox";
            this._genderComboBox.Size = new System.Drawing.Size(100, 21);
            this._genderComboBox.TabIndex = 8;
            // 
            // _okButton
            // 
            this._okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._okButton.Location = new System.Drawing.Point(60, 276);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(80, 25);
            this._okButton.TabIndex = 9;
            this._okButton.Text = "Ок";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(189, 276);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(80, 25);
            this._cancelButton.TabIndex = 10;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditPassengerForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(332, 313);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._genderComboBox);
            this.Controls.Add(this._birthDateMaskedTextBox);
            this.Controls.Add(this._patronymicTextBox);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this._surnameTextBox);
            this.Controls.Add(this._passportNumberMaskedTextBox);
            this.Controls.Add(this._passportSeriesMaskedTextBox);
            this.Controls.Add(this._flightIdTextBox);
            this.Controls.Add(this._attributesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPassengerForm";
            this.ShowIcon = false;
            this.Text = "EditPassengerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _attributesLabel;
        private System.Windows.Forms.TextBox _flightIdTextBox;
        private System.Windows.Forms.MaskedTextBox _passportSeriesMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox _passportNumberMaskedTextBox;
        private System.Windows.Forms.TextBox _surnameTextBox;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _patronymicTextBox;
        private System.Windows.Forms.MaskedTextBox _birthDateMaskedTextBox;
        private System.Windows.Forms.ComboBox _genderComboBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}