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

namespace Zoo.UI
{
    public partial class BokaBesök : Form
    {
        VeterinärMetoderna met2 = new VeterinärMetoderna();
        int djurIdet;

        public BokaBesök(int djurid)
        {
            djurIdet = djurid;
            InitializeComponent();
            comboBoxVeterinärer.DataSource = met2.VeterinärInformation();

            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.CustomFormat = "hh:mm";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }

        private void buttonBoka_Click(object sender, EventArgs e)
        {
            DateTime tiden = dateTimePicker1.Value;
            DateTime datum = dateTimePickerDatum.Value;

            TimeSpan tid = tiden.TimeOfDay;

            var veterinär = (Models.Veterinären)comboBoxVeterinärer.SelectedItem;

            if (met2.SkapaBesök(djurIdet, tid, datum, veterinär.ID))
            {
                MessageBox.Show("Din bokning är registrerad!!\nVälkommen!!");
                this.Close();
            }
        }
    }
}
