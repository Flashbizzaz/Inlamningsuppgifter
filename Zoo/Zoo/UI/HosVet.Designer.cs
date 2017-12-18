namespace Zoo.UI
{
    partial class HosVet
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNyDiagnos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDiagnos = new System.Windows.Forms.ComboBox();
            this.diganosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.medicinenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonKlarMedBesök = new System.Windows.Forms.Button();
            this.textBoxDiagnosBeskricning = new System.Windows.Forms.TextBox();
            this.buttonNyDiagnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diganosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diagnos Beskrivning";
            // 
            // textBoxNyDiagnos
            // 
            this.textBoxNyDiagnos.Location = new System.Drawing.Point(24, 45);
            this.textBoxNyDiagnos.Name = "textBoxNyDiagnos";
            this.textBoxNyDiagnos.Size = new System.Drawing.Size(310, 20);
            this.textBoxNyDiagnos.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ny diagnos";
            // 
            // comboBoxDiagnos
            // 
            this.comboBoxDiagnos.DataSource = this.diganosBindingSource;
            this.comboBoxDiagnos.DisplayMember = "Namn";
            this.comboBoxDiagnos.FormattingEnabled = true;
            this.comboBoxDiagnos.Location = new System.Drawing.Point(24, 130);
            this.comboBoxDiagnos.Name = "comboBoxDiagnos";
            this.comboBoxDiagnos.Size = new System.Drawing.Size(310, 21);
            this.comboBoxDiagnos.TabIndex = 6;
            this.comboBoxDiagnos.ValueMember = "ID";
            // 
            // diganosBindingSource
            // 
            this.diganosBindingSource.DataSource = typeof(Zoo.Models.Diganos);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Välj Diagnos";
            // 
            // medicinenBindingSource
            // 
            this.medicinenBindingSource.DataSource = typeof(Zoo.Models.Medicinen);
            // 
            // buttonKlarMedBesök
            // 
            this.buttonKlarMedBesök.Location = new System.Drawing.Point(24, 441);
            this.buttonKlarMedBesök.Name = "buttonKlarMedBesök";
            this.buttonKlarMedBesök.Size = new System.Drawing.Size(310, 59);
            this.buttonKlarMedBesök.TabIndex = 12;
            this.buttonKlarMedBesök.Text = "Rergistrera Diagnos och Välj medicin";
            this.buttonKlarMedBesök.UseVisualStyleBackColor = true;
            this.buttonKlarMedBesök.Click += new System.EventHandler(this.buttonKlarMedBesök_Click);
            // 
            // textBoxDiagnosBeskricning
            // 
            this.textBoxDiagnosBeskricning.Location = new System.Drawing.Point(24, 190);
            this.textBoxDiagnosBeskricning.Multiline = true;
            this.textBoxDiagnosBeskricning.Name = "textBoxDiagnosBeskricning";
            this.textBoxDiagnosBeskricning.Size = new System.Drawing.Size(310, 216);
            this.textBoxDiagnosBeskricning.TabIndex = 16;
            // 
            // buttonNyDiagnos
            // 
            this.buttonNyDiagnos.Location = new System.Drawing.Point(24, 71);
            this.buttonNyDiagnos.Name = "buttonNyDiagnos";
            this.buttonNyDiagnos.Size = new System.Drawing.Size(310, 26);
            this.buttonNyDiagnos.TabIndex = 18;
            this.buttonNyDiagnos.Text = "Ny Diganos";
            this.buttonNyDiagnos.UseVisualStyleBackColor = true;
            this.buttonNyDiagnos.Click += new System.EventHandler(this.buttonNyDiagnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hos Veterinär!";
            // 
            // HosVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNyDiagnos);
            this.Controls.Add(this.textBoxDiagnosBeskricning);
            this.Controls.Add(this.buttonKlarMedBesök);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDiagnos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNyDiagnos);
            this.Controls.Add(this.label3);
            this.Name = "HosVet";
            this.Text = "HosVet";
            ((System.ComponentModel.ISupportInitialize)(this.diganosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNyDiagnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDiagnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonKlarMedBesök;
        private System.Windows.Forms.TextBox textBoxDiagnosBeskricning;
        private System.Windows.Forms.BindingSource diganosBindingSource;
        private System.Windows.Forms.BindingSource medicinenBindingSource;
        private System.Windows.Forms.Button buttonNyDiagnos;
        private System.Windows.Forms.Label label1;
    }
}