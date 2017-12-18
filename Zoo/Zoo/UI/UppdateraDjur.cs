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

namespace Zoo.UI
{
    public partial class UppdateraDjur : Form
    {
        MetodKlass met = new MetodKlass();

        int valtDjursID;

        public UppdateraDjur(int djurID)
        {
            InitializeComponent();
           var djur =  met.HämtaDjurFörUppdatering(djurID);

            valtDjursID = djurID;

            comboBoxDjurArt.DataSource = met.ArtInformation();
            comboBoxDjurTyp.DataSource = met.DjurTypInformation();
            comboBoxMiljö.DataSource = met.BoendeMiljöInformation();
            comboBoxLänder.DataSource = met.UrsprungslandInformation();
            comboBoxMamma.DataSource = met.HämtaAllDjurInformation();
            comboBoxPappa.DataSource = met.HämtaAllDjurInformation();

            textBoxDjurNamn.Text = djur.Namnet;
            textBoxVikt.Text = djur.Vikten.ToString();
            comboBoxDjurArt.SelectedValue = djur.ArtID;
            comboBoxDjurTyp.SelectedValue = djur.TypID;
            comboBoxLänder.SelectedValue = djur.LandID;
            comboBoxMiljö.SelectedValue = djur.MiljöID;
            comboBoxMamma.SelectedValue = djur.MammaID;
            comboBoxPappa.SelectedValue = djur.PappaID;
        }


        private void buttonUppdatera_Click(object sender, EventArgs e)
        {
            int IDförMamma = 0;
            int IDFörPappa = 0;

            var mammaID = (Models.Djuren)comboBoxMamma.SelectedItem;
            var pappaID = (Models.Djuren)comboBoxPappa.SelectedItem;

            var djurArtID = (Models.Arten)comboBoxDjurArt.SelectedItem;
            var boendemiljöID = (Models.Miljön)comboBoxMiljö.SelectedItem;
            var landID = (Models.Landet)comboBoxLänder.SelectedItem;
            var djurtypID = (Models.DjurTypen)comboBoxDjurTyp.SelectedItem;
            var namnet = textBoxDjurNamn.Text;
            var vikten = float.Parse(textBoxVikt.Text);


            if (mammaID == null)
            {
                IDförMamma = 1;
            }
            else
            {
                IDförMamma = mammaID.DjurID;
            }

            if (pappaID == null)
            {
                IDFörPappa = 2;
            }
            else
            {
                IDFörPappa = pappaID.DjurID;
            }




            if (met.UppdateraDjur(valtDjursID, namnet, vikten, djurArtID.ArtID, djurtypID.TypID, boendemiljöID.MiljöID, landID.LandID, IDförMamma, IDFörPappa))
            {
                MessageBox.Show("Djur Uppdaterat ");
                this.Close();
            }
        }

        private void UppdateraDjur_Load(object sender, EventArgs e)
        {

        }
    }
}
