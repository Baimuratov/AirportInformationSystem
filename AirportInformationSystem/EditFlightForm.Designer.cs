namespace AirportInformationSystem
{
    partial class EditFlightForm
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
            this._flightAttributesLabel = new System.Windows.Forms.Label();
            this._idTextBox = new System.Windows.Forms.TextBox();
            this._planeNameTextBox = new System.Windows.Forms.TextBox();
            this._departureMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._arrivalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this._destinationTextBox = new System.Windows.Forms.TextBox();
            this._ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _flightAttributesLabel
            // 
            this._flightAttributesLabel.AutoSize = true;
            this._flightAttributesLabel.Location = new System.Drawing.Point(12, 24);
            this._flightAttributesLabel.Name = "_flightAttributesLabel";
            this._flightAttributesLabel.Size = new System.Drawing.Size(139, 169);
            this._flightAttributesLabel.TabIndex = 0;
            this._flightAttributesLabel.Text = "Номер\r\n\r\nИдентификатор самолёта\r\n\r\nДата отправления\r\n\r\nДата прибытия\r\n\r\nПункты по" +
    "садки\r\n\r\nПунк назначения\r\n\r\nСтоимость билета";
            // 
            // _idTextBox
            // 
            this._idTextBox.Location = new System.Drawing.Point(193, 21);
            this._idTextBox.Name = "_idTextBox";
            this._idTextBox.Size = new System.Drawing.Size(150, 20);
            this._idTextBox.TabIndex = 1;
            // 
            // _planeNameTextBox
            // 
            this._planeNameTextBox.Location = new System.Drawing.Point(193, 47);
            this._planeNameTextBox.Name = "_planeNameTextBox";
            this._planeNameTextBox.Size = new System.Drawing.Size(150, 20);
            this._planeNameTextBox.TabIndex = 2;
            // 
            // _departureMaskedTextBox
            // 
            this._departureMaskedTextBox.Location = new System.Drawing.Point(193, 73);
            this._departureMaskedTextBox.Mask = "00/00/0000 90:00";
            this._departureMaskedTextBox.Name = "_departureMaskedTextBox";
            this._departureMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._departureMaskedTextBox.TabIndex = 3;
            this._departureMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _arrivalMaskedTextBox
            // 
            this._arrivalMaskedTextBox.Location = new System.Drawing.Point(193, 99);
            this._arrivalMaskedTextBox.Mask = "00/00/0000 90:00";
            this._arrivalMaskedTextBox.Name = "_arrivalMaskedTextBox";
            this._arrivalMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._arrivalMaskedTextBox.TabIndex = 4;
            this._arrivalMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 125);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 5;
            // 
            // _destinationTextBox
            // 
            this._destinationTextBox.Location = new System.Drawing.Point(193, 151);
            this._destinationTextBox.Name = "_destinationTextBox";
            this._destinationTextBox.Size = new System.Drawing.Size(150, 20);
            this._destinationTextBox.TabIndex = 6;
            // 
            // _ticketPriceTextBox
            // 
            this._ticketPriceTextBox.Location = new System.Drawing.Point(193, 177);
            this._ticketPriceTextBox.Name = "_ticketPriceTextBox";
            this._ticketPriceTextBox.Size = new System.Drawing.Size(150, 20);
            this._ticketPriceTextBox.TabIndex = 7;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(71, 225);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(80, 25);
            this._okButton.TabIndex = 8;
            this._okButton.Text = "Ок";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(214, 225);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(80, 25);
            this._cancelButton.TabIndex = 9;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditFlightForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(366, 262);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._ticketPriceTextBox);
            this.Controls.Add(this._destinationTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this._arrivalMaskedTextBox);
            this.Controls.Add(this._departureMaskedTextBox);
            this.Controls.Add(this._planeNameTextBox);
            this.Controls.Add(this._idTextBox);
            this.Controls.Add(this._flightAttributesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditFlightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _flightAttributesLabel;
        private System.Windows.Forms.TextBox _idTextBox;
        private System.Windows.Forms.TextBox _planeNameTextBox;
        private System.Windows.Forms.MaskedTextBox _departureMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox _arrivalMaskedTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox _destinationTextBox;
        private System.Windows.Forms.TextBox _ticketPriceTextBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}