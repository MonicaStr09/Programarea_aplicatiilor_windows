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
    public partial class Form4 : Form
    {
        string connString;
        public Form4()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source= rezervari.accdb";
        }

        private void buttonPreluaredate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM rezervari";

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["nrcamera"].ToString());
                    itm.SubItems.Add(reader["capacitate"].ToString());
                    itm.SubItems.Add(reader["pret"].ToString());
                    itm.SubItems.Add(reader["numeclient"].ToString());
                    itm.SubItems.Add(reader["prenumeclient"].ToString());
                    itm.SubItems.Add(reader["zi"].ToString());
                    itm.SubItems.Add(reader["luna"].ToString());
                    itm.SubItems.Add(reader["an"].ToString());
                    listView1.Items.Add(itm);
                }
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
                conexiune.Close();
            }

        }

        private void buttonInserare_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        int numarcamera = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "UPDATE rezervari SET pret=300 WHERE nrcamera=" + numarcamera;

                        comanda.ExecuteNonQuery();
                    }

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
                conexiune.Close();
            }
        }

        private void toolStripMenuItemSterge_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                //stabilesc leg intre comanda si conexiune
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int nrcamera = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM rezervari WHERE nrcamera=" + nrcamera;
                        comanda.ExecuteNonQuery();
                    }
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
                conexiune.Close();
            }
            buttonPreluaredate_Click(sender, e);
        }
    }
}
    

