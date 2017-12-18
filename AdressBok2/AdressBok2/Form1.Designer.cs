namespace AdressBok2
{
    partial class Form1
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
            this.dataGridViewKontakt = new System.Windows.Forms.DataGridView();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxEpost = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxPostnummer = new System.Windows.Forms.TextBox();
            this.textBoxPostort = new System.Windows.Forms.TextBox();
            this.buttonSkapa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRadera = new System.Windows.Forms.Button();
            this.buttonRensaFälten = new System.Windows.Forms.Button();
            this.comboBoxKontaktTyp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSök = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUppdatera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKontakt
            // 
            this.dataGridViewKontakt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontakt.Location = new System.Drawing.Point(28, 328);
            this.dataGridViewKontakt.Name = "dataGridViewKontakt";
            this.dataGridViewKontakt.Size = new System.Drawing.Size(724, 198);
            this.dataGridViewKontakt.TabIndex = 0;
            this.dataGridViewKontakt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKontakt_CellClick);
            this.dataGridViewKontakt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKontakt_CellContentClick);
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(109, 38);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(254, 20);
            this.textBoxNamn.TabIndex = 2;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(109, 64);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(254, 20);
            this.textBoxTelefon.TabIndex = 3;
            // 
            // textBoxEpost
            // 
            this.textBoxEpost.Location = new System.Drawing.Point(109, 93);
            this.textBoxEpost.Name = "textBoxEpost";
            this.textBoxEpost.Size = new System.Drawing.Size(254, 20);
            this.textBoxEpost.TabIndex = 4;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(109, 119);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(254, 20);
            this.textBoxAdress.TabIndex = 5;
            // 
            // textBoxPostnummer
            // 
            this.textBoxPostnummer.Location = new System.Drawing.Point(109, 145);
            this.textBoxPostnummer.Name = "textBoxPostnummer";
            this.textBoxPostnummer.Size = new System.Drawing.Size(254, 20);
            this.textBoxPostnummer.TabIndex = 6;
            // 
            // textBoxPostort
            // 
            this.textBoxPostort.Location = new System.Drawing.Point(109, 173);
            this.textBoxPostort.Name = "textBoxPostort";
            this.textBoxPostort.Size = new System.Drawing.Size(254, 20);
            this.textBoxPostort.TabIndex = 7;
            // 
            // buttonSkapa
            // 
            this.buttonSkapa.Location = new System.Drawing.Point(399, 38);
            this.buttonSkapa.Name = "buttonSkapa";
            this.buttonSkapa.Size = new System.Drawing.Size(155, 49);
            this.buttonSkapa.TabIndex = 8;
            this.buttonSkapa.Text = "Skapa Kontakt";
            this.buttonSkapa.UseVisualStyleBackColor = true;
            this.buttonSkapa.Click += new System.EventHandler(this.buttonSkapa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Epost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Postnummer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Postort";
            // 
            // buttonRadera
            // 
            this.buttonRadera.Location = new System.Drawing.Point(399, 172);
            this.buttonRadera.Name = "buttonRadera";
            this.buttonRadera.Size = new System.Drawing.Size(155, 49);
            this.buttonRadera.TabIndex = 15;
            this.buttonRadera.Text = "Radera Kontakt";
            this.buttonRadera.UseVisualStyleBackColor = true;
            this.buttonRadera.Click += new System.EventHandler(this.buttonRadera_Click);
            // 
            // buttonRensaFälten
            // 
            this.buttonRensaFälten.Location = new System.Drawing.Point(621, 108);
            this.buttonRensaFälten.Name = "buttonRensaFälten";
            this.buttonRensaFälten.Size = new System.Drawing.Size(155, 49);
            this.buttonRensaFälten.TabIndex = 16;
            this.buttonRensaFälten.Text = "Rensa Fält";
            this.buttonRensaFälten.UseVisualStyleBackColor = true;
            this.buttonRensaFälten.Click += new System.EventHandler(this.buttonRensaFälten_Click);
            // 
            // comboBoxKontaktTyp
            // 
            this.comboBoxKontaktTyp.FormattingEnabled = true;
            this.comboBoxKontaktTyp.Location = new System.Drawing.Point(109, 200);
            this.comboBoxKontaktTyp.Name = "comboBoxKontaktTyp";
            this.comboBoxKontaktTyp.Size = new System.Drawing.Size(254, 21);
            this.comboBoxKontaktTyp.TabIndex = 18;
            this.comboBoxKontaktTyp.SelectedIndexChanged += new System.EventHandler(this.comboBoxKontaktTyp_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "KontaktTyp";
            // 
            // textBoxSök
            // 
            this.textBoxSök.Location = new System.Drawing.Point(109, 298);
            this.textBoxSök.Name = "textBoxSök";
            this.textBoxSök.Size = new System.Drawing.Size(254, 20);
            this.textBoxSök.TabIndex = 20;
            this.textBoxSök.TextChanged += new System.EventHandler(this.textBoxSök_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(38, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Sök";
            // 
            // buttonUppdatera
            // 
            this.buttonUppdatera.Location = new System.Drawing.Point(399, 108);
            this.buttonUppdatera.Name = "buttonUppdatera";
            this.buttonUppdatera.Size = new System.Drawing.Size(155, 49);
            this.buttonUppdatera.TabIndex = 17;
            this.buttonUppdatera.Text = "Uppdatera Kontakt";
            this.buttonUppdatera.UseVisualStyleBackColor = true;
            this.buttonUppdatera.Click += new System.EventHandler(this.buttonUppdatera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 559);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSök);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxKontaktTyp);
            this.Controls.Add(this.buttonUppdatera);
            this.Controls.Add(this.buttonRensaFälten);
            this.Controls.Add(this.buttonRadera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSkapa);
            this.Controls.Add(this.textBoxPostort);
            this.Controls.Add(this.textBoxPostnummer);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxEpost);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.dataGridViewKontakt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKontakt;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxEpost;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxPostnummer;
        private System.Windows.Forms.TextBox textBoxPostort;
        private System.Windows.Forms.Button buttonSkapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRadera;
        private System.Windows.Forms.Button buttonRensaFälten;
        private System.Windows.Forms.ComboBox comboBoxKontaktTyp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSök;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUppdatera;
    }
}

