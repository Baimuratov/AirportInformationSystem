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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFlightForm));
            this._attributesLabel = new System.Windows.Forms.Label();
            this._idTextBox = new System.Windows.Forms.TextBox();
            this._planeNameTextBox = new System.Windows.Forms.TextBox();
            this._departureMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._arrivalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this._embarkationsTextBox = new System.Windows.Forms.TextBox();
            this._destinationTextBox = new System.Windows.Forms.TextBox();
            this._ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _attributesLabel
            // 
            this._attributesLabel.AutoSize = true;
            this._attributesLabel.Location = new System.Drawing.Point(12, 24);
            this._attributesLabel.Name = "_attributesLabel";
            this._attributesLabel.Size = new System.Drawing.Size(293, 208);
            this._attributesLabel.TabIndex = 0;
            this._attributesLabel.Text = resources.GetString("_attributesLabel.Text");
            // 
            // _idTextBox
            // 
            this._idTextBox.Location = new System.Drawing.Point(193, 21);
            this._idTextBox.Name = "_idTextBox";
            this._idTextBox.Size = new System.Drawing.Size(150, 20);
            this._idTextBox.TabIndex = 1;
            this._idTextBox.TextChanged += new System.EventHandler(this._idTextBox_TextChanged);
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
            // _embarkationsTextBox
            // 
            this._embarkationsTextBox.Location = new System.Drawing.Point(193, 125);
            this._embarkationsTextBox.Multiline = true;
            this._embarkationsTextBox.Name = "_embarkationsTextBox";
            this._embarkationsTextBox.Size = new System.Drawing.Size(150, 20);
            this._embarkationsTextBox.TabIndex = 5;
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
            this._ticketPriceTextBox.TextChanged += new System.EventHandler(this._ticketPriceTextBox_TextChanged);
            // 
            // _okButton
            // 
            this._okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._okButton.Location = new System.Drawing.Point(71, 250);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(80, 25);
            this._okButton.TabIndex = 8;
            this._okButton.Text = "Ок";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(214, 250);
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
            this.ClientSize = new System.Drawing.Size(366, 287);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._ticketPriceTextBox);
            this.Controls.Add(this._destinationTextBox);
            this.Controls.Add(this._embarkationsTextBox);
            this.Controls.Add(this._arrivalMaskedTextBox);
            this.Controls.Add(this._departureMaskedTextBox);
            this.Controls.Add(this._planeNameTextBox);
            this.Controls.Add(this._idTextBox);
            this.Controls.Add(this._attributesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFlightForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFlightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _attributesLabel;
        private System.Windows.Forms.TextBox _idTextBox;
        private System.Windows.Forms.TextBox _planeNameTextBox;
        private System.Windows.Forms.MaskedTextBox _departureMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox _arrivalMaskedTextBox;
        private System.Windows.Forms.TextBox _embarkationsTextBox;
        private System.Windows.Forms.TextBox _destinationTextBox;
        private System.Windows.Forms.TextBox _ticketPriceTextBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}