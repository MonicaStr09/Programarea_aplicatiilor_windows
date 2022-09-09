using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stirbescu_Monica_Proiect_Paw
{
    public partial class Form2 : Form
    {
        List<Rezervare> listarezervari = new List<Rezervare>();
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonRezerva_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source= rezervari.accdb");

            ErrorProvider errorProvider1 = new ErrorProvider();
            if (textBoxNrCamera.Text == "")
                errorProvider1.SetError(textBoxNrCamera, " Introduceti numarul!");
            else
                if (textBoxCapacitate.Text == "")
                errorProvider1.SetError(textBoxCapacitate, "Introduceti capacitatea!");
            else
                    if (textBoxPret.Text == "")

                errorProvider1.SetError(textBoxPret, "Introduceti pretul!");
            else
                    if (textBoxNumeClient.Text == "")

                errorProvider1.SetError(textBoxNumeClient, "Introduceti numele!");
            if (textBoxPrenumeClient.Text == "")

                errorProvider1.SetError(textBoxPrenumeClient, "Introduceti tipul prenumele!");
            else

                    if (textBoxZi.Text == "")

                errorProvider1.SetError(textBoxZi, "Introduceti anul!");
            else
                    if (textBoxLuna.Text == "")

                errorProvider1.SetError(textBoxLuna, "Introduceti luna!");
            else
                    if (textBoxAn.Text == "")
                errorProvider1.SetError(textBoxAn, "Introduceti ziua!");

            else

            {


                try
                {
                    int numarcamera = Convert.ToInt32(textBoxNrCamera.Text);
                    int capacitate = Convert.ToInt32(textBoxCapacitate.Text);
                    int pret = Convert.ToInt32(textBoxPret.Text);
                    string nume = textBoxNumeClient.Text;
                    string prenume = textBoxPrenumeClient.Text;
                    int zi = Convert.ToInt32(textBoxZi.Text);
                    int luna = Convert.ToInt32(textBoxLuna.Text);
                    int an = Convert.ToInt32(textBoxAn.Text);
                    Rezervare p = new Rezervare( nume,  prenume,  zi,  luna,  an);
                    listarezervari.Add(p);
                    MessageBox.Show(p.ToString());

                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT MAX(nrcamera) From rezervari";
                    int id = Convert.ToInt32(comanda.ExecuteScalar());

                    comanda.CommandText = "INSERT INTO rezervari VALUES (?,?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("nrcamera", OleDbType.Integer).Value = numarcamera + 100;
                    comanda.Parameters.Add("capacitate", OleDbType.Integer).Value = textBoxCapacitate.Text;
                    comanda.Parameters.Add("pret", OleDbType.Integer).Value = textBoxPret.Text;
                    comanda.Parameters.Add("numeclient", OleDbType.Char, 50).Value = textBoxNumeClient.Text;
                    comanda.Parameters.Add("prenumeclient", OleDbType.Char, 50).Value = textBoxPrenumeClient.Text;
                    comanda.Parameters.Add("zi", OleDbType.Integer).Value = Convert.ToInt32(textBoxZi.Text);
                    comanda.Parameters.Add("luna", OleDbType.Integer).Value = Convert.ToInt32(textBoxLuna.Text);
                    comanda.Parameters.Add("an", OleDbType.Integer).Value = Convert.ToInt32(textBoxAn.Text);

                    comanda.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    textBoxNrCamera.Clear();
                    textBoxCapacitate.Clear();
                    textBoxPret.Clear();
                    textBoxNumeClient.Clear();
                    textBoxPrenumeClient.Text = "";
                    textBoxZi.Text = "";
                    textBoxLuna.Clear();
                    textBoxAn.Clear();
                    errorProvider1.Clear();
                    conexiune.Close();

                }
            }
        }

        private void buttonVizualizare_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(listarezervari);
            frm.ShowDialog();
        }

        private void paginaPrincipalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void vizualizareGraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }
    }
}

