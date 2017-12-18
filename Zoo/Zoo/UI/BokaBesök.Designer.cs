namespace Zoo.UI
{
    partial class BokaBesök
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVeterinärer = new System.Windows.Forms.ComboBox();
            this.veterinärBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBoka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veterinärBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum för besök";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Välj Veterinär";
            // 
            // comboBoxVeterinärer
            // 
            this.comboBoxVeterinärer.DataSource = this.veterinärBindingSource;
            this.comboBoxVeterinärer.DisplayMember = "Namn";
            this.comboBoxVeterinärer.FormattingEnabled = true;
            this.comboBoxVeterinärer.Location = new System.Drawing.Point(298, 68);
            this.comboBoxVeterinärer.Name = "comboBoxVeterinärer";
            this.comboBoxVeterinärer.Size = new System.Drawing.Size(167, 21);
            this.comboBoxVeterinärer.TabIndex = 3;
            this.comboBoxVeterinärer.ValueMember = "ID";
            // 
            // veterinärBindingSource
            // 
            this.veterinärBindingSource.DataSource = typeof(Zoo.Models.Veterinären);
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(37, 69);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tid för besök";
            // 
            // buttonBoka
            // 
            this.buttonBoka.Location = new System.Drawing.Point(298, 118);
            this.buttonBoka.Name = "buttonBoka";
            this.buttonBoka.Size = new System.Drawing.Size(177, 36);
            this.buttonBoka.TabIndex = 6;
            this.buttonBoka.Text = "Boka";
            this.buttonBoka.UseVisualStyleBackColor = true;
            this.buttonBoka.Click += new System.EventHandler(this.buttonBoka_Click);
            // 
            // BokaBesök
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 228);
            this.Controls.Add(this.buttonBoka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.comboBoxVeterinärer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "BokaBesök";
            this.Text = "BokaBesök";
            ((System.ComponentModel.ISupportInitialize)(this.veterinärBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVeterinärer;
        private System.Windows.Forms.BindingSource veterinärBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBoka;
    }
}