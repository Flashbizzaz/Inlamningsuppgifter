using AdressBok2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBok2
{
    public partial class Form1 : Form
    {
        DataAccess dataAccess = new DataAccess();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = dataAccess.ExecuteSelectCommand("select * from Kontakttyp", CommandType.Text);
            comboBoxKontaktTyp.DataSource = dataSet.Tables[0];
            comboBoxKontaktTyp.DisplayMember = "KontaktTypNamn";
            comboBoxKontaktTyp.ValueMember = "TypID";

            UpdateKontaktGriden();
        }



        private void UpdateKontaktGriden()
        {

            string command1 = "select Kontakt.KontaktId, Kontakt.Namn, Kontakt.Epost, Kontakt.Telefon, Adress.Adress, Adress.Postort, Adress.Postnummer," +
                " Kontakttyp.KontaktTypNamn from kontakt join adress on Kontakt.KontaktID = Adress.KontaktID join Kontakttyp on" +
                " Kontakt.TypID = Kontakttyp.TypID order by Kontakt.KontaktID";

            DataSet dataSet = dataAccess.ExecuteSelectCommand(command1, CommandType.Text);
            dataGridViewKontakt.DataSource = dataSet.Tables[0];


        }

        private void buttonSkapa_Click(object sender, EventArgs e)
        {
            dataAccess.UpdatePrice();

            

            string command = "insert into Kontakt values (@Namn, @Telefon, @Epost, @TypKontakt);" +
                "declare @KontaktID int = scope_Identity(); " +
                "insert into Adress values (@Adress, @Postort,@Postnummer,@KontaktID);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@Namn", textBoxNamn.Text),
                    new SqlParameter("@Adress", textBoxAdress.Text),
                    new SqlParameter("@Postnummer", int.Parse(textBoxPostnummer.Text)),
                    new SqlParameter("@Postort", textBoxPostort.Text),
                    new SqlParameter("@Telefon", textBoxTelefon.Text),
                    new SqlParameter("@Epost", textBoxEpost.Text),
                    new SqlParameter("@TypKontakt", comboBoxKontaktTyp.SelectedValue),
            };


            if (dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters))
            {
                MessageBox.Show("Kontakt Sparad");
            }


            UpdateKontaktGriden();
        }

        private void buttonRadera_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewKontakt.CurrentCell.RowIndex;
            string ID = dataGridViewKontakt.Rows[rowindex].Cells[0].Value.ToString();

            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@KontaktID", ID)
            };

            var command = "delete from kontakt where KontaktID = @KontaktID;";

            if (dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters))
            {
                MessageBox.Show("Kontakten är raderad");

                dataGridViewKontakt.DataSource = null;

                RensaAllaTextFält();
            }

            UpdateKontaktGriden();
        }

        private void RensaAllaTextFält()
        {
            textBoxNamn.Text = "";
            textBoxAdress.Text = "";
            textBoxPostnummer.Text = "";
            textBoxPostort.Text = "";
            textBoxTelefon.Text = "";
            textBoxEpost.Text = "";
            comboBoxKontaktTyp.Text = "";
        }

        private void comboBoxKontaktTyp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUppdatera_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewKontakt.CurrentCell.RowIndex;
            string ID = dataGridViewKontakt.Rows[rowindex].Cells[0].Value.ToString();

            SqlParameter[] parameters =
           {
                    new SqlParameter("@Namn", textBoxNamn.Text),
                    new SqlParameter("@Adress", textBoxAdress.Text),
                    new SqlParameter("@Postnummer", int.Parse(textBoxPostnummer.Text)),
                    new SqlParameter("@Postort", textBoxPostort.Text),
                    new SqlParameter("@Telefon", textBoxTelefon.Text),
                    new SqlParameter("@Epost", textBoxEpost.Text),
                    new SqlParameter("@TypKontakt", comboBoxKontaktTyp.SelectedValue),
                    new SqlParameter("@KontaktID", ID)
            };

            var command = "Update Kontakt set Namn = @Namn, Telefon = @Telefon, Epost = @Epost, TypID = @TypKontakt where KontaktID = @KontaktID;" +
                "update adress set adress = @adress, postort = @postort, postnummer = @postnummer where KontaktID = @KontaktID;";

            if (dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters))
            {
                MessageBox.Show("Kontakt är uppdaterad");
                RensaAllaTextFält();
            }

            UpdateKontaktGriden();
        }

        private void buttonRensaFälten_Click(object sender, EventArgs e)
        {
            RensaAllaTextFält();
        }

        private void textBoxSök_TextChanged(object sender, EventArgs e)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("select Kontakt.KontaktID, Kontakt.Namn, Kontakt.Epost, Kontakt.Telefon, Adress.Adress, Adress.Postort, Adress.Postnummer, " +
                "Kontakttyp.KontaktTypNamn from kontakt join adress on Kontakt.KontaktID = Adress.KontaktID join Kontakttyp on Kontakt.TypID = Kontakttyp.TypID order by Kontakt.KontaktID",
                dataAccess.con))
            {
                DataTable Dt = new DataTable();
                adapter.Fill(Dt);
                dataGridViewKontakt.DataSource = Dt;

                if (!string.IsNullOrEmpty(textBoxSök.Text))
                {
                    Dt.DefaultView.RowFilter = string.Format("Namn LIKE '%{0}%' OR Adress LIKE '%{0}%' OR Postort LIKE '%{0}%'", textBoxSök.Text);
                }
                else
                {
                    dataGridViewKontakt.DataSource = null;
                }
            }
        }

        private void dataGridViewKontakt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewKontakt_CellClick(object sender, DataGridViewCellEventArgs e) //Väljer i fel ordning
        {
            int rowindex = dataGridViewKontakt.CurrentCell.RowIndex;

            var command = "select Kontakt.KontaktID, Kontakt.Namn, Kontakt.Epost, Kontakt.Telefon, Adress.Adress, Adress.Postort, Adress.Postnummer, Kontakttyp.KontaktTypNamn " +
                "from kontakt left join adress on Kontakt.KontaktID = Adress.KontaktID left join Kontakttyp on Kontakt.TypID = Kontakttyp.TypID order by Adress.AdressID";

            var rad = dataAccess.ExecuteSelectCommand(command, CommandType.Text);

            textBoxNamn.Text = rad.Tables[0].Rows[rowindex][1].ToString();
            textBoxAdress.Text = rad.Tables[0].Rows[rowindex][4].ToString();
            textBoxPostnummer.Text = rad.Tables[0].Rows[rowindex][6].ToString();
            textBoxPostort.Text = rad.Tables[0].Rows[rowindex][5].ToString();
            textBoxTelefon.Text = rad.Tables[0].Rows[rowindex][2].ToString();
            textBoxEpost.Text = rad.Tables[0].Rows[rowindex][3].ToString();
            comboBoxKontaktTyp.Text = rad.Tables[0].Rows[rowindex][7].ToString();
        }

        private void buttonLäggTillAdress_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewKontakt.CurrentCell.RowIndex;
            string ID = dataGridViewKontakt.Rows[rowindex].Cells[0].Value.ToString();

            SqlParameter[] parameters =
           {
                    new SqlParameter("@Namn", textBoxNamn.Text),
                    new SqlParameter("@Adress", textBoxAdress.Text),
                    new SqlParameter("@Postnummer", int.Parse(textBoxPostnummer.Text)),
                    new SqlParameter("@Postort", textBoxPostort.Text),
                    new SqlParameter("@Telefon", textBoxTelefon.Text),
                    new SqlParameter("@Epost", textBoxEpost.Text),
                    new SqlParameter("@TypKontakt", comboBoxKontaktTyp.SelectedValue),
                    new SqlParameter("@KontaktID", ID)
            };

            var command = "Insert into adress (Adress, Postort, postnummer, kontaktID) Values (@Adress, @postort, @postnummer,@kontaktID)";


            if (dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters))
            {
                MessageBox.Show("Adressen är Tillagd");
                RensaAllaTextFält();
                UpdateKontaktGriden();
            }
        }

        private void buttonRaderaAdress_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewKontakt.CurrentCell.RowIndex;
            string ID = dataGridViewKontakt.Rows[rowindex].Cells[0].Value.ToString();

            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@KontaktID", ID)
            };

            var command = "delete from Adress where KontaktID = @KontaktID;";

            if (dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters))
            {
                MessageBox.Show("adressen är raderad");

                dataGridViewKontakt.DataSource = null;

                RensaAllaTextFält();
            }

            UpdateKontaktGriden();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAdress_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

