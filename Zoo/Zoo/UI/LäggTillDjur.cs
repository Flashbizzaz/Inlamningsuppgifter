using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoo.Metoder;
using Zoo.Models;

namespace Zoo.UI
{
    public partial class LäggTillDjur : Form
    {
        MetodKlass met = new MetodKlass();

        public LäggTillDjur()
        {
            InitializeComponent();

            comboBoxDjurArt.DataSource = met.ArtInformation();
            comboBoxDjurTyp.DataSource = met.DjurTypInformation();
            comboBoxMiljö.DataSource = met.BoendeMiljöInformation();
            comboBoxLänder.DataSource = met.UrsprungslandInformation();
            comboBoxMamma.DataSource = met.HämtaAllDjurInformation();
            comboBoxPappa.DataSource = met.HämtaAllDjurInformation();

            comboBoxDjurArt.SelectedIndex = -1;
            comboBoxDjurTyp.SelectedIndex = -1;
            comboBoxMiljö.SelectedIndex = -1;
            comboBoxLänder.SelectedIndex = -1;
            comboBoxMamma.SelectedIndex = -1;
            comboBoxPappa.SelectedIndex = -1;
        }

        private void buttonLäggTillDjur_Click(object sender, EventArgs e)
        {
            int IDförMamma = 0;
            int IDFörPappa = 0;
            
            var mammaID = (Models.Djuren)comboBoxMamma.SelectedItem;
            var pappaID = (Models.Djuren)comboBoxPappa.SelectedItem;
            var djurArtID = (Models.Arten)comboBoxDjurArt.SelectedItem;
            var boendemiljöID = (Models.Miljön)comboBoxMiljö.SelectedItem;
            var landID = (Models.Landet)comboBoxLänder.SelectedItem;
            var djurtypID = (Models.DjurTypen)comboBoxDjurTyp.SelectedItem;

            if (mammaID == null)
            {
                IDförMamma = 1;
            }
            else
            {
                IDförMamma = mammaID.DjurID;
            }
            if (pappaID== null)
            {
                IDFörPappa = 1;
            }
            else
            {
                IDFörPappa = pappaID.DjurID;
            }

            var nyaFöräldrar = new Föräldrar();
            nyaFöräldrar.MammaID = IDförMamma;
            nyaFöräldrar.PappaID = IDFörPappa;

            var nyttDjur = new Djur();
            nyttDjur.Namn = textBoxDjurNamn.Text;
            nyttDjur.Vikt = float.Parse(textBoxVikt.Text);
            nyttDjur.DjurArtID = djurArtID.ArtID;
            nyttDjur.BoendemiljöID = boendemiljöID.MiljöID;
            nyttDjur.UrsprungslandID = landID.LandID;
            nyttDjur.DjurTypID = djurtypID.TypID;

            if (met.SkapaDjur(nyttDjur, nyaFöräldrar))
            {
                MessageBox.Show("Djur Tillagt");
                this.Close();
            }           

        }

        private void buttonRensaFält_Click(object sender, EventArgs e)
        {
            textBoxDjurNamn.Text = "";
            textBoxVikt.Text = "";

            comboBoxDjurArt.SelectedIndex = -1;
            comboBoxDjurTyp.SelectedIndex = -1;
            comboBoxMiljö.SelectedIndex = -1;
            comboBoxLänder.SelectedIndex = -1;
            comboBoxMamma.SelectedIndex = -1;
            comboBoxPappa.SelectedIndex = -1;

        }

        private void comboBoxMiljö_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LäggTillDjur_Load(object sender, EventArgs e)
        {

        }
    }
}
