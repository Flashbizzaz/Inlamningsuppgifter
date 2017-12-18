using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoo.Models;
using Zoo.Metoder;
using Zoo.UI;

namespace Zoo
{
    public partial class Form1 : Form
    {
        MetodKlass met = new MetodKlass();
        VeterinärMetoderna vet = new VeterinärMetoderna();
        ZooContext db = new ZooContext();

        public Form1()
        {
            InitializeComponent();
            UppdateraAllInformation();
        }

        private void UppdateraAllInformation()
        {
            dataGridViewDjurInformation.DataSource = met.HämtaAllDjurInformation();
            comboBoxArt.DataSource = met.ArtInformation();
            comboBoxDjurtyp.DataSource = met.DjurTypInformation();
            comboBoxMiljö.DataSource = met.BoendeMiljöInformation();

            comboBoxArt.SelectedIndex = -1;
            comboBoxMiljö.SelectedIndex = -1;
            comboBoxDjurtyp.SelectedIndex = -1;
        }

        private void buttonLäggTillDjur_Click(object sender, EventArgs e)
        {
            LäggTillDjur frm = new LäggTillDjur();
            frm.Show();
        }

        private void buttonRensaBoxarna_Click(object sender, EventArgs e)
        {
            comboBoxArt.SelectedIndex = -1;
            comboBoxMiljö.SelectedIndex = -1;
            comboBoxDjurtyp.SelectedIndex = -1;

            dataGridViewBokningar.DataSource = null;
            UppdateraAllInformation();
        }
        //Sortera knappen
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewDjurInformation.DataSource = met.HämtaAllDjurInformation();

            try
            {
                var miljöSortering = (Models.Miljön)comboBoxMiljö.SelectedItem;
                var typSortering = (Models.DjurTypen)comboBoxDjurtyp.SelectedItem;
                var artSortering = (Models.Arten)comboBoxArt.SelectedItem;

                var miljöId = 0;
                var typId = 0;
                var artId = 0;

                if (miljöSortering != null)
                {
                    if (miljöSortering.MiljöID >= 1)
                    {
                        miljöId = miljöSortering.MiljöID;
                    }
                }

                if (typSortering != null)
                {
                    if (typSortering.TypID >= 1)
                    {
                        typId = typSortering.TypID;
                    }
                }

                if (artSortering != null)
                {
                    if (artSortering.ArtID >= 1)
                    {
                        artId = artSortering.ArtID;
                    }
                }

                var result = met.Sortera(miljöId, artId, typId);
                dataGridViewDjurInformation.DataSource = result;
            }

            catch (Exception)
            {

                MessageBox.Show("Du behöver göra en sortering");
            }
        }

        private void buttonRadera_Click(object sender, EventArgs e)
        {
            int djurID = 0;
            try
            {
                djurID = int.Parse(this.dataGridViewDjurInformation.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Du måste välja ett djur att radera");
            }

            if (djurID==0)
            {
                MessageBox.Show("Du måste välja ett djur att radera");
            }


            if (met.RaderaDjur(djurID))
            {
                MessageBox.Show("Djur Raderad");
            }

            UppdateraAllInformation();
        }

        private void buttonUppdatera_Click(object sender, EventArgs e)
        {
            var djurID = int.Parse(this.dataGridViewDjurInformation.CurrentRow.Cells[0].Value.ToString());

            UppdateraDjur uppdateraForm = new UppdateraDjur(djurID);
            uppdateraForm.Show();
        }

        private void buttonBokaTidHosVet_Click(object sender, EventArgs e)
        {
            var djurID = int.Parse(this.dataGridViewDjurInformation.CurrentRow.Cells[0].Value.ToString());
            BokaBesök besök = new BokaBesök(djurID);
            besök.Show();
        }

        private void buttonHosVeterinär_Click(object sender, EventArgs e)
        {
            var bokningsID = int.Parse(this.dataGridViewBokningar.CurrentRow.Cells[0].Value.ToString());

            HosVet hosveterinären = new HosVet(bokningsID);
            hosveterinären.Show();
        }

        private void buttonHämtaBokningar_Click(object sender, EventArgs e)
        {
            try
            {
                var djurID = int.Parse(this.dataGridViewDjurInformation.CurrentRow.Cells[0].Value.ToString());

                var bokningslistanUtanFiltrering = vet.HämtaBokningar(djurID);
                var dagensDatum = DateTime.Now;

                foreach (var item in bokningslistanUtanFiltrering.ToList())
                {
                    if (item.Datum.Date < dagensDatum.Date)
                    {
                        bokningslistanUtanFiltrering.Remove(item);
                    }
                }

                dataGridViewBokningar.DataSource = bokningslistanUtanFiltrering;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Djuret har inga bokningar hos Veterinär");
            }
        }

        private void buttonAvboka_Click(object sender, EventArgs e)
        {
            var bokningsID = int.Parse(this.dataGridViewBokningar.CurrentRow.Cells[0].Value.ToString());

            if (vet.RaderaBokning(bokningsID))
            {
                MessageBox.Show("Bokning Raderad");
            }
        }
    }
}
