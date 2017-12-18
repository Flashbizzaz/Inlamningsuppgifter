namespace Zoo.UI
{
    partial class MedicinTillStälldDiagnos
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
            this.buttonNyMedicin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonLäggTillMedicin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMedicin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMedicin = new System.Windows.Forms.TextBox();
            this.buttonFärdig = new System.Windows.Forms.Button();
            this.buttonTaBortMedicin = new System.Windows.Forms.Button();
            this.medicinenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNyMedicin
            // 
            this.buttonNyMedicin.Location = new System.Drawing.Point(58, 270);
            this.buttonNyMedicin.Name = "buttonNyMedicin";
            this.buttonNyMedicin.Size = new System.Drawing.Size(205, 23);
            this.buttonNyMedicin.TabIndex = 25;
            this.buttonNyMedicin.Text = "Ny Medicin";
            this.buttonNyMedicin.UseVisualStyleBackColor = true;
            this.buttonNyMedicin.Click += new System.EventHandler(this.buttonNyMedicin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mediciner";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namnDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicinenBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(308, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(223, 277);
            this.dataGridView1.TabIndex = 23;
            // 
            // namnDataGridViewTextBoxColumn
            // 
            this.namnDataGridViewTextBoxColumn.DataPropertyName = "Namn";
            this.namnDataGridViewTextBoxColumn.HeaderText = "Namn";
            this.namnDataGridViewTextBoxColumn.Name = "namnDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // medicinenBindingSource1
            // 
            this.medicinenBindingSource1.DataSource = typeof(Zoo.Models.Medicinen);
            // 
            // buttonLäggTillMedicin
            // 
            this.buttonLäggTillMedicin.Location = new System.Drawing.Point(58, 86);
            this.buttonLäggTillMedicin.Name = "buttonLäggTillMedicin";
            this.buttonLäggTillMedicin.Size = new System.Drawing.Size(205, 46);
            this.buttonLäggTillMedicin.TabIndex = 22;
            this.buttonLäggTillMedicin.Text = "Medicin till Diagnos";
            this.buttonLäggTillMedicin.UseVisualStyleBackColor = true;
            this.buttonLäggTillMedicin.Click += new System.EventHandler(this.buttonLäggTillMedicin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Välj Mediciner";
            // 
            // comboBoxMedicin
            // 
            this.comboBoxMedicin.DisplayMember = "Namn";
            this.comboBoxMedicin.FormattingEnabled = true;
            this.comboBoxMedicin.Location = new System.Drawing.Point(58, 48);
            this.comboBoxMedicin.Name = "comboBoxMedicin";
            this.comboBoxMedicin.Size = new System.Drawing.Size(205, 21);
            this.comboBoxMedicin.TabIndex = 20;
            this.comboBoxMedicin.ValueMember = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lägg till ny Medicin";
            // 
            // textBoxMedicin
            // 
            this.textBoxMedicin.Location = new System.Drawing.Point(58, 244);
            this.textBoxMedicin.Name = "textBoxMedicin";
            this.textBoxMedicin.Size = new System.Drawing.Size(205, 20);
            this.textBoxMedicin.TabIndex = 18;
            // 
            // buttonFärdig
            // 
            this.buttonFärdig.Location = new System.Drawing.Point(65, 400);
            this.buttonFärdig.Name = "buttonFärdig";
            this.buttonFärdig.Size = new System.Drawing.Size(466, 55);
            this.buttonFärdig.TabIndex = 26;
            this.buttonFärdig.Text = "Gär färdigt besök hos veterinär!";
            this.buttonFärdig.UseVisualStyleBackColor = true;
            this.buttonFärdig.Click += new System.EventHandler(this.buttonFärdig_Click);
            // 
            // buttonTaBortMedicin
            // 
            this.buttonTaBortMedicin.Location = new System.Drawing.Point(58, 138);
            this.buttonTaBortMedicin.Name = "buttonTaBortMedicin";
            this.buttonTaBortMedicin.Size = new System.Drawing.Size(205, 46);
            this.buttonTaBortMedicin.TabIndex = 27;
            this.buttonTaBortMedicin.Text = "Ta bort medicin ";
            this.buttonTaBortMedicin.UseVisualStyleBackColor = true;
            this.buttonTaBortMedicin.Click += new System.EventHandler(this.buttonTaBortMedicin_Click);
            // 
            // medicinenBindingSource
            // 
            this.medicinenBindingSource.DataSource = typeof(Zoo.Models.Medicinen);
            // 
            // MedicinTillStälldDiagnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 495);
            this.Controls.Add(this.buttonTaBortMedicin);
            this.Controls.Add(this.buttonFärdig);
            this.Controls.Add(this.buttonNyMedicin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLäggTillMedicin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMedicin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMedicin);
            this.Name = "MedicinTillStälldDiagnos";
            this.Text = "MedicinTillStälldDiagnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNyMedicin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLäggTillMedicin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMedicin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMedicin;
        private System.Windows.Forms.DataGridViewTextBoxColumn namnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosNamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicinenBindingSource;
        private System.Windows.Forms.Button buttonFärdig;
        private System.Windows.Forms.Button buttonTaBortMedicin;
        private System.Windows.Forms.BindingSource medicinenBindingSource1;
    }
}