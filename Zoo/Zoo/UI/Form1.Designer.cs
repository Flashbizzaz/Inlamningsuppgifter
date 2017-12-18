namespace Zoo
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewDjurInformation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxArt = new System.Windows.Forms.ComboBox();
            this.artenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDjurtyp = new System.Windows.Forms.ComboBox();
            this.djurTypenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMiljö = new System.Windows.Forms.ComboBox();
            this.miljönBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRadera = new System.Windows.Forms.Button();
            this.buttonLäggTill = new System.Windows.Forms.Button();
            this.buttonBokaTidHosVet = new System.Windows.Forms.Button();
            this.buttonUppdatera = new System.Windows.Forms.Button();
            this.buttonRensaBoxarna = new System.Windows.Forms.Button();
            this.buttonSorteraSök = new System.Windows.Forms.Button();
            this.buttonHosVeterinär = new System.Windows.Forms.Button();
            this.buttonAvboka = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewBokningar = new System.Windows.Forms.DataGridView();
            this.besökIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.djuridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinärNamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bokadeBesökBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bokadeBesökBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonHämtaBokningar = new System.Windows.Forms.Button();
            this.bokadeBesökBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDjurInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djurTypenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miljönBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBokningar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokadeBesökBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokadeBesökBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokadeBesökBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDjurInformation
            // 
            this.dataGridViewDjurInformation.AllowUserToAddRows = false;
            this.dataGridViewDjurInformation.AllowUserToDeleteRows = false;
            this.dataGridViewDjurInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDjurInformation.Location = new System.Drawing.Point(262, 94);
            this.dataGridViewDjurInformation.Name = "dataGridViewDjurInformation";
            this.dataGridViewDjurInformation.ReadOnly = true;
            this.dataGridViewDjurInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDjurInformation.Size = new System.Drawing.Size(942, 279);
            this.dataGridViewDjurInformation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "på Art";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "På djurtyp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "På Miljö";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sortera";
            // 
            // comboBoxArt
            // 
            this.comboBoxArt.DataSource = this.artenBindingSource;
            this.comboBoxArt.DisplayMember = "Benämning";
            this.comboBoxArt.FormattingEnabled = true;
            this.comboBoxArt.Location = new System.Drawing.Point(25, 220);
            this.comboBoxArt.Name = "comboBoxArt";
            this.comboBoxArt.Size = new System.Drawing.Size(194, 21);
            this.comboBoxArt.TabIndex = 8;
            this.comboBoxArt.ValueMember = "ArtID";
            // 
            // artenBindingSource
            // 
            this.artenBindingSource.DataSource = typeof(Zoo.Models.Arten);
            // 
            // comboBoxDjurtyp
            // 
            this.comboBoxDjurtyp.DataSource = this.djurTypenBindingSource;
            this.comboBoxDjurtyp.DisplayMember = "Benämning";
            this.comboBoxDjurtyp.FormattingEnabled = true;
            this.comboBoxDjurtyp.Location = new System.Drawing.Point(25, 176);
            this.comboBoxDjurtyp.Name = "comboBoxDjurtyp";
            this.comboBoxDjurtyp.Size = new System.Drawing.Size(194, 21);
            this.comboBoxDjurtyp.TabIndex = 9;
            this.comboBoxDjurtyp.ValueMember = "TypID";
            // 
            // djurTypenBindingSource
            // 
            this.djurTypenBindingSource.DataSource = typeof(Zoo.Models.DjurTypen);
            // 
            // comboBoxMiljö
            // 
            this.comboBoxMiljö.DataSource = this.miljönBindingSource;
            this.comboBoxMiljö.DisplayMember = "MiljöBenämning";
            this.comboBoxMiljö.FormattingEnabled = true;
            this.comboBoxMiljö.Location = new System.Drawing.Point(25, 136);
            this.comboBoxMiljö.Name = "comboBoxMiljö";
            this.comboBoxMiljö.Size = new System.Drawing.Size(194, 21);
            this.comboBoxMiljö.TabIndex = 10;
            this.comboBoxMiljö.ValueMember = "MiljöID";
            // 
            // miljönBindingSource
            // 
            this.miljönBindingSource.DataSource = typeof(Zoo.Models.Miljön);
            // 
            // buttonRadera
            // 
            this.buttonRadera.Location = new System.Drawing.Point(510, 12);
            this.buttonRadera.Name = "buttonRadera";
            this.buttonRadera.Size = new System.Drawing.Size(242, 56);
            this.buttonRadera.TabIndex = 11;
            this.buttonRadera.Text = "Radera Djur";
            this.buttonRadera.UseVisualStyleBackColor = true;
            this.buttonRadera.Click += new System.EventHandler(this.buttonRadera_Click);
            // 
            // buttonLäggTill
            // 
            this.buttonLäggTill.Location = new System.Drawing.Point(262, 12);
            this.buttonLäggTill.Name = "buttonLäggTill";
            this.buttonLäggTill.Size = new System.Drawing.Size(242, 56);
            this.buttonLäggTill.TabIndex = 12;
            this.buttonLäggTill.Text = "Lägg Till Djur";
            this.buttonLäggTill.UseVisualStyleBackColor = true;
            this.buttonLäggTill.Click += new System.EventHandler(this.buttonLäggTillDjur_Click);
            // 
            // buttonBokaTidHosVet
            // 
            this.buttonBokaTidHosVet.Location = new System.Drawing.Point(1006, 12);
            this.buttonBokaTidHosVet.Name = "buttonBokaTidHosVet";
            this.buttonBokaTidHosVet.Size = new System.Drawing.Size(242, 56);
            this.buttonBokaTidHosVet.TabIndex = 14;
            this.buttonBokaTidHosVet.Text = "Boka Besök Hos Veterinär";
            this.buttonBokaTidHosVet.UseVisualStyleBackColor = true;
            this.buttonBokaTidHosVet.Click += new System.EventHandler(this.buttonBokaTidHosVet_Click);
            // 
            // buttonUppdatera
            // 
            this.buttonUppdatera.Location = new System.Drawing.Point(758, 12);
            this.buttonUppdatera.Name = "buttonUppdatera";
            this.buttonUppdatera.Size = new System.Drawing.Size(242, 56);
            this.buttonUppdatera.TabIndex = 15;
            this.buttonUppdatera.Text = "Uppdatera Valt Djur";
            this.buttonUppdatera.UseVisualStyleBackColor = true;
            this.buttonUppdatera.Click += new System.EventHandler(this.buttonUppdatera_Click);
            // 
            // buttonRensaBoxarna
            // 
            this.buttonRensaBoxarna.Location = new System.Drawing.Point(25, 12);
            this.buttonRensaBoxarna.Name = "buttonRensaBoxarna";
            this.buttonRensaBoxarna.Size = new System.Drawing.Size(194, 62);
            this.buttonRensaBoxarna.TabIndex = 16;
            this.buttonRensaBoxarna.Text = "Uppdatera";
            this.buttonRensaBoxarna.UseVisualStyleBackColor = true;
            this.buttonRensaBoxarna.Click += new System.EventHandler(this.buttonRensaBoxarna_Click);
            // 
            // buttonSorteraSök
            // 
            this.buttonSorteraSök.Location = new System.Drawing.Point(25, 262);
            this.buttonSorteraSök.Name = "buttonSorteraSök";
            this.buttonSorteraSök.Size = new System.Drawing.Size(194, 69);
            this.buttonSorteraSök.TabIndex = 19;
            this.buttonSorteraSök.Text = "Sortera";
            this.buttonSorteraSök.UseVisualStyleBackColor = true;
            this.buttonSorteraSök.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonHosVeterinär
            // 
            this.buttonHosVeterinär.Location = new System.Drawing.Point(1026, 425);
            this.buttonHosVeterinär.Name = "buttonHosVeterinär";
            this.buttonHosVeterinär.Size = new System.Drawing.Size(178, 119);
            this.buttonHosVeterinär.TabIndex = 20;
            this.buttonHosVeterinär.Text = "Gå till veterinär";
            this.buttonHosVeterinär.UseVisualStyleBackColor = true;
            this.buttonHosVeterinär.Click += new System.EventHandler(this.buttonHosVeterinär_Click);
            // 
            // buttonAvboka
            // 
            this.buttonAvboka.Location = new System.Drawing.Point(821, 467);
            this.buttonAvboka.Name = "buttonAvboka";
            this.buttonAvboka.Size = new System.Drawing.Size(183, 44);
            this.buttonAvboka.TabIndex = 21;
            this.buttonAvboka.Text = "Avboka Tid Hos Veterinär";
            this.buttonAvboka.UseVisualStyleBackColor = true;
            this.buttonAvboka.Click += new System.EventHandler(this.buttonAvboka_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bokade Besök";
            // 
            // dataGridViewBokningar
            // 
            this.dataGridViewBokningar.AllowUserToAddRows = false;
            this.dataGridViewBokningar.AllowUserToDeleteRows = false;
            this.dataGridViewBokningar.AutoGenerateColumns = false;
            this.dataGridViewBokningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBokningar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.besökIDDataGridViewTextBoxColumn,
            this.djuridDataGridViewTextBoxColumn,
            this.veterinärNamnDataGridViewTextBoxColumn,
            this.tidDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dataGridViewBokningar.DataSource = this.bokadeBesökBindingSource2;
            this.dataGridViewBokningar.Location = new System.Drawing.Point(262, 425);
            this.dataGridViewBokningar.Name = "dataGridViewBokningar";
            this.dataGridViewBokningar.ReadOnly = true;
            this.dataGridViewBokningar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBokningar.Size = new System.Drawing.Size(553, 129);
            this.dataGridViewBokningar.TabIndex = 24;
            // 
            // besökIDDataGridViewTextBoxColumn
            // 
            this.besökIDDataGridViewTextBoxColumn.DataPropertyName = "besökID";
            this.besökIDDataGridViewTextBoxColumn.HeaderText = "besökID";
            this.besökIDDataGridViewTextBoxColumn.Name = "besökIDDataGridViewTextBoxColumn";
            this.besökIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // djuridDataGridViewTextBoxColumn
            // 
            this.djuridDataGridViewTextBoxColumn.DataPropertyName = "djurid";
            this.djuridDataGridViewTextBoxColumn.HeaderText = "djurid";
            this.djuridDataGridViewTextBoxColumn.Name = "djuridDataGridViewTextBoxColumn";
            this.djuridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veterinärNamnDataGridViewTextBoxColumn
            // 
            this.veterinärNamnDataGridViewTextBoxColumn.DataPropertyName = "veterinärNamn";
            this.veterinärNamnDataGridViewTextBoxColumn.HeaderText = "veterinärNamn";
            this.veterinärNamnDataGridViewTextBoxColumn.Name = "veterinärNamnDataGridViewTextBoxColumn";
            this.veterinärNamnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "Tid";
            this.tidDataGridViewTextBoxColumn.HeaderText = "Tid";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            this.tidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bokadeBesökBindingSource2
            // 
            this.bokadeBesökBindingSource2.DataSource = typeof(Zoo.Models.BokadeBesök);
            // 
            // bokadeBesökBindingSource1
            // 
            this.bokadeBesökBindingSource1.DataSource = typeof(Zoo.Models.BokadeBesök);
            // 
            // buttonHämtaBokningar
            // 
            this.buttonHämtaBokningar.Location = new System.Drawing.Point(50, 447);
            this.buttonHämtaBokningar.Name = "buttonHämtaBokningar";
            this.buttonHämtaBokningar.Size = new System.Drawing.Size(169, 74);
            this.buttonHämtaBokningar.TabIndex = 25;
            this.buttonHämtaBokningar.Text = "Hämta kommande bokningar";
            this.buttonHämtaBokningar.UseVisualStyleBackColor = true;
            this.buttonHämtaBokningar.Click += new System.EventHandler(this.buttonHämtaBokningar_Click);
            // 
            // bokadeBesökBindingSource
            // 
            this.bokadeBesökBindingSource.DataSource = typeof(Zoo.Models.BokadeBesök);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 585);
            this.Controls.Add(this.buttonHämtaBokningar);
            this.Controls.Add(this.dataGridViewBokningar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAvboka);
            this.Controls.Add(this.buttonHosVeterinär);
            this.Controls.Add(this.buttonSorteraSök);
            this.Controls.Add(this.buttonRensaBoxarna);
            this.Controls.Add(this.buttonUppdatera);
            this.Controls.Add(this.buttonBokaTidHosVet);
            this.Controls.Add(this.buttonLäggTill);
            this.Controls.Add(this.buttonRadera);
            this.Controls.Add(this.comboBoxMiljö);
            this.Controls.Add(this.comboBoxDjurtyp);
            this.Controls.Add(this.comboBoxArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDjurInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDjurInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djurTypenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miljönBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBokningar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokadeBesökBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokadeBesökBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bokadeBesökBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDjurInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxArt;
        private System.Windows.Forms.ComboBox comboBoxDjurtyp;
        private System.Windows.Forms.ComboBox comboBoxMiljö;
        private System.Windows.Forms.BindingSource artenBindingSource;
        private System.Windows.Forms.BindingSource djurTypenBindingSource;
        private System.Windows.Forms.BindingSource miljönBindingSource;
        private System.Windows.Forms.Button buttonRadera;
        private System.Windows.Forms.Button buttonLäggTill;
        private System.Windows.Forms.Button buttonBokaTidHosVet;
        private System.Windows.Forms.Button buttonUppdatera;
        private System.Windows.Forms.Button buttonRensaBoxarna;
        private System.Windows.Forms.Button buttonSorteraSök;
        private System.Windows.Forms.Button buttonHosVeterinär;
        private System.Windows.Forms.Button buttonAvboka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bokadeBesökBindingSource;
        private System.Windows.Forms.BindingSource bokadeBesökBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewBokningar;
        private System.Windows.Forms.DataGridViewTextBoxColumn besökIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn djuridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinärNamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonHämtaBokningar;
        private System.Windows.Forms.BindingSource bokadeBesökBindingSource2;
    }
}

