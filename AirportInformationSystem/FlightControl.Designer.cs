namespace AirportInformationSystem
{
    partial class FlightControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this._destinationTextBox = new System.Windows.Forms.TextBox();
            this._embarkationsTextBox = new System.Windows.Forms.TextBox();
            this._arrivalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._departureMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._planeNameTextBox = new System.Windows.Forms.TextBox();
            this._idTextBox = new System.Windows.Forms.TextBox();
            this._attributesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _ticketPriceTextBox
            // 
            this._ticketPriceTextBox.Location = new System.Drawing.Point(184, 160);
            this._ticketPriceTextBox.Name = "_ticketPriceTextBox";
            this._ticketPriceTextBox.Size = new System.Drawing.Size(150, 20);
            this._ticketPriceTextBox.TabIndex = 15;
            // 
            // _destinationTextBox
            // 
            this._destinationTextBox.Location = new System.Drawing.Point(184, 134);
            this._destinationTextBox.Name = "_destinationTextBox";
            this._destinationTextBox.Size = new System.Drawing.Size(150, 20);
            this._destinationTextBox.TabIndex = 14;
            // 
            // _embarkationsTextBox
            // 
            this._embarkationsTextBox.Location = new System.Drawing.Point(184, 108);
            this._embarkationsTextBox.Multiline = true;
            this._embarkationsTextBox.Name = "_embarkationsTextBox";
            this._embarkationsTextBox.Size = new System.Drawing.Size(150, 20);
            this._embarkationsTextBox.TabIndex = 13;
            // 
            // _arrivalMaskedTextBox
            // 
            this._arrivalMaskedTextBox.Location = new System.Drawing.Point(184, 82);
            this._arrivalMaskedTextBox.Mask = "00/00/0000 90:00";
            this._arrivalMaskedTextBox.Name = "_arrivalMaskedTextBox";
            this._arrivalMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._arrivalMaskedTextBox.TabIndex = 12;
            this._arrivalMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _departureMaskedTextBox
            // 
            this._departureMaskedTextBox.Location = new System.Drawing.Point(184, 56);
            this._departureMaskedTextBox.Mask = "00/00/0000 90:00";
            this._departureMaskedTextBox.Name = "_departureMaskedTextBox";
            this._departureMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this._departureMaskedTextBox.TabIndex = 11;
            this._departureMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // _planeNameTextBox
            // 
            this._planeNameTextBox.Location = new System.Drawing.Point(184, 30);
            this._planeNameTextBox.Name = "_planeNameTextBox";
            this._planeNameTextBox.Size = new System.Drawing.Size(150, 20);
            this._planeNameTextBox.TabIndex = 10;
            // 
            // _idTextBox
            // 
            this._idTextBox.Location = new System.Drawing.Point(184, 4);
            this._idTextBox.Name = "_idTextBox";
            this._idTextBox.Size = new System.Drawing.Size(150, 20);
            this._idTextBox.TabIndex = 9;
            // 
            // _attributesLabel
            // 
            this._attributesLabel.AutoSize = true;
            this._attributesLabel.Location = new System.Drawing.Point(3, 7);
            this._attributesLabel.Name = "_attributesLabel";
            this._attributesLabel.Size = new System.Drawing.Size(139, 169);
            this._attributesLabel.TabIndex = 8;
            this._attributesLabel.Text = "Номер\r\n\r\nИдентификатор самолёта\r\n\r\nДата отправления\r\n\r\nДата прибытия\r\n\r\nПункты по" +
    "садки\r\n\r\nПунк назначения\r\n\r\nСтоимость билета";
            // 
            // FlightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._ticketPriceTextBox);
            this.Controls.Add(this._destinationTextBox);
            this.Controls.Add(this._embarkationsTextBox);
            this.Controls.Add(this._arrivalMaskedTextBox);
            this.Controls.Add(this._departureMaskedTextBox);
            this.Controls.Add(this._planeNameTextBox);
            this.Controls.Add(this._idTextBox);
            this.Controls.Add(this._attributesLabel);
            this.Name = "FlightControl";
            this.Size = new System.Drawing.Size(338, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _ticketPriceTextBox;
        private System.Windows.Forms.TextBox _destinationTextBox;
        private System.Windows.Forms.TextBox _embarkationsTextBox;
        private System.Windows.Forms.MaskedTextBox _arrivalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox _departureMaskedTextBox;
        private System.Windows.Forms.TextBox _planeNameTextBox;
        private System.Windows.Forms.TextBox _idTextBox;
        private System.Windows.Forms.Label _attributesLabel;
    }
}
