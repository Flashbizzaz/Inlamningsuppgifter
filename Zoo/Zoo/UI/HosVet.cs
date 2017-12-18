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

namespace Zoo.UI
{
    public partial class HosVet : Form
    {
        Metoder.VeterinärMetoderna vet = new Metoder.VeterinärMetoderna();
        int bokId;

        public HosVet(int bokningsID)
        {
            InitializeComponent();

            bokId = bokningsID;

            BindingList<Veterinären> vetNamn;

            using (var db = new ZooContext())
            {
                var query = from o in db.BesökHosVeterinär
                            join a in db.Veterinär on o.VeterinärID equals a.VeterinärID
                            where o.ID == bokningsID
                            select new Veterinären
                            {
                                Namn = a.Namn
                            };

                vetNamn  = new BindingList<Veterinären>(query.ToList());
            }

            foreach (var item in vetNamn)
            {
                label1.Text = "Du är nu hos: " + item.Namn;
            }
            label1.Refresh();

            var lista = vet.HämtaDiagnoser();
            var lista2 = lista.GroupBy(i => i.Namn).Select(p => p.First()).ToList();

            comboBoxDiagnos.DataSource = lista2;
        }
   

        private void buttonNyDiagnos_Click(object sender, EventArgs e)
        {
            var nyDiganopsNamn = textBoxNyDiagnos.Text;
            var nydiagnosBeskrivning = textBoxDiagnosBeskricning.Text;

            if (vet.NyDiagnos(nydiagnosBeskrivning, nyDiganopsNamn))
            {
                MessageBox.Show("Diagnos tillagd");
            }
            textBoxNyDiagnos.Text = "";

            var lista = vet.HämtaDiagnoser();
            var lista2 = lista.GroupBy(i => i.Namn).Select(p => p.First()).ToList();
            comboBoxDiagnos.DataSource = lista2;
        }

        private void buttonKlarMedBesök_Click(object sender, EventArgs e)
        {
            var diagnosID = (Models.Diganos)comboBoxDiagnos.SelectedItem;
            vet.BestämdDiagnosFörBokning(bokId, diagnosID.Namn);

            MedicinTillStälldDiagnos ställaMed = new MedicinTillStälldDiagnos(diagnosID.ID);
            ställaMed.Show();
            this.Close();
        }
    }
}
