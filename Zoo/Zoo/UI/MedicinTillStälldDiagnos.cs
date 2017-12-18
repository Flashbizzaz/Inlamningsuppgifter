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
    public partial class MedicinTillStälldDiagnos : Form
    {
        VeterinärMetoderna vet = new VeterinärMetoderna();
        int diagnosIDet;

        BindingList<Medicinen> medLista = new BindingList<Medicinen>();


        public MedicinTillStälldDiagnos(int diagnosId)
        {
            InitializeComponent();

            diagnosIDet = diagnosId;


            var lista = vet.HämtaAllaMediciner();

            var lista2 = lista.GroupBy(p => p.Namn).Select(i => i.First()).ToList();

            comboBoxMedicin.DataSource = lista2;
            dataGridView1.DataSource = medLista;
        }

        private void buttonNyMedicin_Click(object sender, EventArgs e)
        {
            var nyMedNamn = textBoxMedicin.Text;
            if (vet.SkapaNyMedicin(nyMedNamn))
            {
                MessageBox.Show("Medicin tillagd");
            }
            textBoxMedicin.Text = "";

            var lista = vet.HämtaAllaMediciner();
            var lista2 = lista.GroupBy(p => p.Namn).Select(i => i.First()).ToList();
            comboBoxMedicin.DataSource = lista2;
        }

        private void buttonLäggTillMedicin_Click(object sender, EventArgs e)
        {
            try
            {
                var valdMedcin = (Models.Medicinen)comboBoxMedicin.SelectedItem;
                var medattläggatill = vet.LäggMedicinerTillDatagriden(valdMedcin.ID);

                var diagnosID = diagnosIDet;

                medLista.Add(medattläggatill.FirstOrDefault());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du måste välja en Medicin att lägga till");
            }

            dataGridView1.DataSource = medLista;
        }

        private void buttonFärdig_Click(object sender, EventArgs e)
        {
            foreach (var item in medLista)
            {
                vet.RegistreraKlartBesökMedMedicinListaTillDiagnos(item.ID, diagnosIDet, item.Namn);
                vet.SparaMedicinernaTillistan();
            }
            this.Close();
        }

        private void buttonTaBortMedicin_Click(object sender, EventArgs e)
        {
            var valdMedcinID = int.Parse(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());

            foreach (var item in medLista.ToList())
            {
                if (item.ID==valdMedcinID)
                {
                    medLista.Remove(item);
                }
            }
            dataGridView1.DataSource = medLista;
        }
    }
}
