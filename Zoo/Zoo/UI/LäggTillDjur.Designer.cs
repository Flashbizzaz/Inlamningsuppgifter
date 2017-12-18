namespace Zoo.UI
{
    partial class LäggTillDjur
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
            this.textBoxDjurNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVikt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMiljö = new System.Windows.Forms.ComboBox();
            this.miljönBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDjurArt = new System.Windows.Forms.ComboBox();
            this.artenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDjurTyp = new System.Windows.Forms.ComboBox();
            this.djurTypenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMamma = new System.Windows.Forms.ComboBox();
            this.djurenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPappa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLäggTillDjur = new System.Windows.Forms.Button();
            this.comboBoxLänder = new System.Windows.Forms.ComboBox();
            this.landetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRensaFält = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.miljönBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djurTypenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djurenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDjurNamn
            // 
            this.textBoxDjurNamn.Location = new System.Drawing.Point(30, 48);
            this.textBoxDjurNamn.Name = "textBoxDjurNamn";
            this.textBoxDjurNamn.Size = new System.Drawing.Size(182, 20);
            this.textBoxDjurNamn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DjurNamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vikt";
            // 
            // textBoxVikt
            // 
            this.textBoxVikt.Location = new System.Drawing.Point(30, 90);
            this.textBoxVikt.Name = "textBoxVikt";
            this.textBoxVikt.Size = new System.Drawing.Size(182, 20);
            this.textBoxVikt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BoendeMiljö";
            // 
            // comboBoxMiljö
            // 
            this.comboBoxMiljö.DataSource = this.miljönBindingSource;
            this.comboBoxMiljö.DisplayMember = "MiljöBenämning";
            this.comboBoxMiljö.FormattingEnabled = true;
            this.comboBoxMiljö.Location = new System.Drawing.Point(30, 140);
            this.comboBoxMiljö.Name = "comboBoxMiljö";
            this.comboBoxMiljö.Size = new System.Drawing.Size(182, 21);
            this.comboBoxMiljö.TabIndex = 5;
            this.comboBoxMiljö.ValueMember = "MiljöID";
            this.comboBoxMiljö.SelectedIndexChanged += new System.EventHandler(this.comboBoxMiljö_SelectedIndexChanged);
            // 
            // miljönBindingSource
            // 
            this.miljönBindingSource.DataSource = typeof(Zoo.Models.Miljön);
            // 
            // comboBoxDjurArt
            // 
            this.comboBoxDjurArt.DataSource = this.artenBindingSource;
            this.comboBoxDjurArt.DisplayMember = "Benämning";
            this.comboBoxDjurArt.FormattingEnabled = true;
            this.comboBoxDjurArt.Location = new System.Drawing.Point(30, 190);
            this.comboBoxDjurArt.Name = "comboBoxDjurArt";
            this.comboBoxDjurArt.Size = new System.Drawing.Size(182, 21);
            this.comboBoxDjurArt.TabIndex = 7;
            this.comboBoxDjurArt.ValueMember = "ArtID";
            // 
            // artenBindingSource
            // 
            this.artenBindingSource.DataSource = typeof(Zoo.Models.Arten);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Art";
            // 
            // comboBoxDjurTyp
            // 
            this.comboBoxDjurTyp.DataSource = this.djurTypenBindingSource;
            this.comboBoxDjurTyp.DisplayMember = "Benämning";
            this.comboBoxDjurTyp.FormattingEnabled = true;
            this.comboBoxDjurTyp.Location = new System.Drawing.Point(30, 246);
            this.comboBoxDjurTyp.Name = "comboBoxDjurTyp";
            this.comboBoxDjurTyp.Size = new System.Drawing.Size(182, 21);
            this.comboBoxDjurTyp.TabIndex = 9;
            this.comboBoxDjurTyp.ValueMember = "TypID";
            // 
            // djurTypenBindingSource
            // 
            this.djurTypenBindingSource.DataSource = typeof(Zoo.Models.DjurTypen);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Typ";
            // 
            // comboBoxMamma
            // 
            this.comboBoxMamma.DataSource = this.djurenBindingSource;
            this.comboBoxMamma.DisplayMember = "Namnet";
            this.comboBoxMamma.FormattingEnabled = true;
            this.comboBoxMamma.Location = new System.Drawing.Point(30, 360);
            this.comboBoxMamma.Name = "comboBoxMamma";
            this.comboBoxMamma.Size = new System.Drawing.Size(182, 21);
            this.comboBoxMamma.TabIndex = 11;
            this.comboBoxMamma.ValueMember = "DjurID";
            // 
            // djurenBindingSource
            // 
            this.djurenBindingSource.DataSource = typeof(Zoo.Models.Djuren);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mamma";
            // 
            // comboBoxPappa
            // 
            this.comboBoxPappa.DataSource = this.djurenBindingSource;
            this.comboBoxPappa.DisplayMember = "Namnet";
            this.comboBoxPappa.FormattingEnabled = true;
            this.comboBoxPappa.Location = new System.Drawing.Point(30, 419);
            this.comboBoxPappa.Name = "comboBoxPappa";
            this.comboBoxPappa.Size = new System.Drawing.Size(182, 21);
            this.comboBoxPappa.TabIndex = 13;
            this.comboBoxPappa.ValueMember = "DjurID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pappa";
            // 
            // buttonLäggTillDjur
            // 
            this.buttonLäggTillDjur.Location = new System.Drawing.Point(259, 168);
            this.buttonLäggTillDjur.Name = "buttonLäggTillDjur";
            this.buttonLäggTillDjur.Size = new System.Drawing.Size(192, 272);
            this.buttonLäggTillDjur.TabIndex = 14;
            this.buttonLäggTillDjur.Text = "Lägg Till Djur";
            this.buttonLäggTillDjur.UseVisualStyleBackColor = true;
            this.buttonLäggTillDjur.Click += new System.EventHandler(this.buttonLäggTillDjur_Click);
            // 
            // comboBoxLänder
            // 
            this.comboBoxLänder.DataSource = this.landetBindingSource;
            this.comboBoxLänder.DisplayMember = "Benmämning";
            this.comboBoxLänder.FormattingEnabled = true;
            this.comboBoxLänder.Location = new System.Drawing.Point(30, 299);
            this.comboBoxLänder.Name = "comboBoxLänder";
            this.comboBoxLänder.Size = new System.Drawing.Size(182, 21);
            this.comboBoxLänder.TabIndex = 16;
            this.comboBoxLänder.ValueMember = "LandID";
            // 
            // landetBindingSource
            // 
            this.landetBindingSource.DataSource = typeof(Zoo.Models.Landet);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ursprungsland";
            // 
            // buttonRensaFält
            // 
            this.buttonRensaFält.Location = new System.Drawing.Point(259, 42);
            this.buttonRensaFält.Name = "buttonRensaFält";
            this.buttonRensaFält.Size = new System.Drawing.Size(192, 68);
            this.buttonRensaFält.TabIndex = 17;
            this.buttonRensaFält.Text = "Rensa Fält";
            this.buttonRensaFält.UseVisualStyleBackColor = true;
            this.buttonRensaFält.Click += new System.EventHandler(this.buttonRensaFält_Click);
            // 
            // LäggTillDjur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 460);
            this.Controls.Add(this.buttonRensaFält);
            this.Controls.Add(this.comboBoxLänder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonLäggTillDjur);
            this.Controls.Add(this.comboBoxPappa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxMamma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDjurTyp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDjurArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMiljö);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVikt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDjurNamn);
            this.Name = "LäggTillDjur";
            this.Text = "LäggTillDjur";
            this.Load += new System.EventHandler(this.LäggTillDjur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miljönBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djurTypenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djurenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDjurNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVikt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMiljö;
        private System.Windows.Forms.ComboBox comboBoxDjurArt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDjurTyp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource miljönBindingSource;
        private System.Windows.Forms.BindingSource artenBindingSource;
        private System.Windows.Forms.BindingSource djurTypenBindingSource;
        private System.Windows.Forms.ComboBox comboBoxMamma;
        private System.Windows.Forms.BindingSource djurenBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPappa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonLäggTillDjur;
        private System.Windows.Forms.ComboBox comboBoxLänder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource landetBindingSource;
        private System.Windows.Forms.Button buttonRensaFält;
    }
}